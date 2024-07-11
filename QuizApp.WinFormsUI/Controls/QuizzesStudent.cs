using QuizApp.Core.Data.Models;
using QuizApp.WinFormsUI.Forms;

namespace QuizApp.WinFormsUI.Controls;

public partial class QuizzesStudent : UserControl
{
    private readonly List<Quiz> _quizzes = [];
    private readonly User _user;

    public QuizzesStudent(User user)
    {
        InitializeComponent();
        _user = user;
    }

    private void QuizzesStudent_Load(object sender, EventArgs e)
    {
        var allQuizzes = QuizApp.Repo.GetQuizzes();

        foreach (var quiz in allQuizzes)
        {
            _quizzes.Add(quiz); 
        }

        if (_quizzes.Count > 0)
        {
            lblNoQuiz.Visible = false;
        }
    }


    private void QuizzesStudent_Layout(object sender, LayoutEventArgs e)
    {
        ShowQuizzes();
    }

    private void ShowQuizzes()
    {
        if (_quizzes.Count == 0)
        {
            lblNoQuiz.Visible = true;
            listUsers.Visible = false;
            grpBxUserDetails.Visible = false;
        }
        else
        {
            lblNoQuiz.Visible = false;
            listUsers.Items.Clear();
            foreach (var quiz in _quizzes)
            {
                listUsers.Items.Add(quiz.Title);
            }
            listUsers.Visible = true;
            if (listUsers.SelectedIndex > 0) grpBxUserDetails.Visible = false;
        }
    }

    private void listUsers_SelectedIndexChanged(object sender)
    {
        if (listUsers.SelectedIndex < 0) return;
        grpBxUserDetails.Visible = true;
        var quiz = _quizzes[listUsers.SelectedIndex];
        lblQuizName.Text = quiz.Title;
        var takerScore = QuizApp.Repo.GetTakerScores(_user.Id).FirstOrDefault(x => x.QuizId == quiz.Id);

        if (takerScore == null)
        {
            lblDateDone.Text = "N/A";
            lblOverallScore.Text = "N/A";
            btnTakeQuiz.Enabled = true;
            return;
        }

        var dateFormatting = takerScore.DateTaken!.Value.ToString("MM/dd/yyyy").Replace(' ', '/');
        lblDateDone.Text = dateFormatting;
        lblOverallScore.Text = takerScore.Score + "/" + takerScore.Answers.Count;
        btnTakeQuiz.Enabled = false;
    }

    private void btnTakeQuiz_Click(object sender, EventArgs e)
    {
        var quiz = _quizzes[listUsers.SelectedIndex];
        var quizForm = new QuizForm(quiz, _user);
        quizForm.ShowDialog();
        listUsers_SelectedIndexChanged(sender);
    }
}