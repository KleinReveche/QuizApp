using QuizApp.Core.Data.Models;

namespace QuizApp.Core.Data.Repo;

public interface IRepo
{
    public void AddUser(User user);
    public void RemoveUser(User user);
    public void UpdateUser(User original, User updated);
    public void AddUsers(IEnumerable<User> users);
    public User GetUser(int id);
    public User? GetUser(string username);
    public User? GetUserByEmail(string email);
    public List<User> GetUsers();
    public void AddQuiz(Quiz quiz);
    public void RemoveQuiz(Quiz quiz);
    public void UpdateQuiz(Quiz original, Quiz updated);
    public Quiz GetQuiz(int id);
    public List<Quiz> GetQuizzes();
    public void AddTakerScore(TakerScore takerScore);
    public void RemoveTakerScore(TakerScore takerScore);
    public void UpdateTakerScore(TakerScore original, TakerScore updated);
    public TakerScore GetTakerScore(int id);
    public List<TakerScore> GetTakerScores();
    public List<TakerScore> GetTakerScores(int userId);
}