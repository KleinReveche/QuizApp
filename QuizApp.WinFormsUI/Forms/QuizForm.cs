using QuizApp.Core.Data.Models;
using QuizApp.Core.Utils;
using QuizApp.WinFormsUI.Properties;
using ReaLTaiizor.Controls;

namespace QuizApp.WinFormsUI.Forms;

public partial class QuizForm : Form
{
    private readonly List<int> _answers = [];
    private readonly FormState _formState = new();
    private readonly Quiz _quiz;
    private readonly List<CyberRadioButton> _radioButtons;
    private readonly User? _user;
    private int _currentQuestionId = -1;
    private int _timerInSeconds;

    public QuizForm(Quiz quiz, User? user)
    {
        InitializeComponent();
        //FormBorderStyle = FormBorderStyle.Sizable;
        _formState.Maximize(this);
        WinApi.SetWindowAlwaysTop(this.Handle);
        _quiz = quiz;
        _user = user;
        lblQuizName.Text = quiz.Title;
        _timerInSeconds = quiz.TimerInSeconds;

        _radioButtons =
        [
            rbAnswer1,
            rbAnswer2,
            rbAnswer3,
            rbAnswer4,
            rbAnswer5
        ];
    }

    private void QuizForm_Load(object sender, EventArgs e)
    {
        var firstQuestion = _quiz.Questions[0];
        lblQuestion.Text = firstQuestion.QuestionText.Replace(QuizHandlers.NewLineIndicator, Environment.NewLine);
        _currentQuestionId = 0;

        for (var i = 0; i < _radioButtons.Count; i++)
            try
            {
                _radioButtons[i].TextButton = firstQuestion.Answers[i];
            }
            catch
            {
                _radioButtons[i].Visible = false;
            }
    }

    private void QuizForm_KeyDown(object sender, KeyEventArgs e)
    {
        e.Handled = e.KeyCode switch
        {
            Keys.Alt => true,
            _ => e.Handled
        };
    }

    private void rbAnswer_Click(object sender, EventArgs e)
    {
        if (sender is not CyberRadioButton radioButton) return;

        foreach (var rb in _radioButtons.Where(rb => rb != radioButton)) rb.Checked = false;
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        if (_currentQuestionId == 0) timer.Start();

        try
        {
            _answers.Add(_radioButtons.IndexOf(_radioButtons.First(x => x.Checked)));
        }
        catch
        {
            MessageBox.Show(Resources.select_answer, Resources.error);
            return;
        }

        if (_currentQuestionId == _quiz.Questions.Count - 1)
        {
            ValidateScore();
            return;
        }

        _currentQuestionId++;

        var nextQuestion = _quiz.Questions[_currentQuestionId];
        lblQuestion.Text = nextQuestion.QuestionText.Replace(QuizHandlers.NewLineIndicator, Environment.NewLine);

        for (var i = 0; i < _radioButtons.Count; i++)
            try
            {
                _radioButtons[i].TextButton = nextQuestion.Answers[i];
                _radioButtons[i].Checked = false;
                _radioButtons[i].Visible = true;
            }
            catch
            {
                _radioButtons[i].Visible = false;
            }
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        _timerInSeconds--;
        lblTimer.Text = _timerInSeconds.ToString();
        if (_timerInSeconds != 0) return;
        timer.Stop();
        TimerExpired();
    }

    private void TimerExpired()
    {
        if (_answers.Count != _quiz.Questions.Count)
            for (var i = _answers.Count; i < _quiz.Questions.Count; i++)
                _answers.Add(-1);

        ValidateScore();
    }

    private void ValidateScore()
    {
        var questionsAnswerKeys = _quiz.Questions.Select(q => q.CorrectAnswerIndex).ToArray();
        var score = _answers.Where((t, i) => t == questionsAnswerKeys[i]).Count();

        if (_user is null)
        {
            MessageBox.Show(string.Format(Resources.test_score, score), Resources.test_quiz);
            Close();
            return;
        }

        var takerScore = new TakerScore
        {
            DateTaken = DateTime.Now,
            Answers = _answers,
            Score = score,
            UserId = _user.Id,
            QuizId = _quiz.Id
        };

        QuizApp.Repo.AddTakerScore(takerScore);
        Close();
    }
}