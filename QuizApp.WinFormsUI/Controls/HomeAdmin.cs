using QuizApp.Core.Data.Models;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Controls;

public partial class HomeAdmin : UserControl
{
    private List<TakerScore> _scores;
    private List<User> _users;
    private List<Quiz> _quizzes;
    
    public HomeAdmin(User user)
    {
        InitializeComponent();
        lblWelcome.Text = string.Format(Resources.welcome_user, user.FullName);
        _scores = QuizApp.Repo.GetTakerScores();
        _users = QuizApp.Repo.GetUsers();
        _quizzes = QuizApp.Repo.GetQuizzes();
    }

    private void HomeAdmin_Load(object sender, EventArgs e)
    {
        _scores = QuizApp.Repo.GetTakerScores();
        _users = QuizApp.Repo.GetUsers();
        _quizzes = QuizApp.Repo.GetQuizzes();
        
        foreach (var quiz in _quizzes)
        {
            listQuizzes.Items.Add(quiz.Title);
        }
        
        listQuizzes.SelectedIndex = 0;
        var quizToDisplay = _quizzes.First();
        var quizScores = _scores.Where(s => s.QuizId == quizToDisplay.Id).ToList();
        quizScores.Reverse();

        foreach (var score in quizScores)
        {
            quizScoreView.Rows.Add(_users.First(u => u.Id == score.UserId).ReversedFullName, score.Score);
        }
    }
    
    private void listQuizzes_SelectedIndexChanged(object sender)
    {
        _scores = QuizApp.Repo.GetTakerScores();
        var quizToDisplay = _quizzes[listQuizzes.SelectedIndex];
        var quizScores = _scores.Where(s => s.QuizId == quizToDisplay.Id).ToList();
        quizScores.Reverse();

        quizScoreView.Rows.Clear();
        foreach (var score in quizScores)
        {
            quizScoreView.Rows.Add(_users.First(u => u.Id == score.UserId).ReversedFullName, score.Score);
        }
    }
}