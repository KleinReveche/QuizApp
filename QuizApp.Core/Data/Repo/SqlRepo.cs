using Microsoft.EntityFrameworkCore;
using QuizApp.Core.Data.Models;

namespace QuizApp.Core.Data.Repo;

public class SqlRepo : IRepo
{
    private readonly DatabaseContext _db;

    public SqlRepo(DatabaseContext db)
    {
        _db = db;
        try
        {
            if (_db.Users.ToList().Count == 0) InitializeRepo();
        }
        catch
        {
            InitializeRepo();
        }
    }

    public void AddUser(User user)
    {
        _db.Users.Add(user);
        _db.SaveChanges();
    }

    public void RemoveUser(User user)
    {
        _db.Users.Remove(user);
        _db.SaveChanges();
    }

    public void UpdateUser(User original, User updated)
    {
        _db.Remove(original);
        _db.Add(updated);
        _db.SaveChanges();
    }

    public void AddUsers(IEnumerable<User> users)
    {
        _db.Users.AddRange(users);
        _db.SaveChanges();
    }

    public User GetUser(int id)
    {
        return _db.Users.First(x => x.Id == id);
    }

    public User? GetUser(string username)
    {
        return _db.Users.FirstOrDefault(x => x.Username == username);
    }

    public User? GetUserByEmail(string email)
    {
        return _db.Users.FirstOrDefault(x => x.Email == email);
    }

    public List<User> GetUsers()
    {
        return _db.Users.ToList();
    }

    public void AddQuiz(Quiz quiz)
    {
        _db.Quizzes.Add(quiz);
        _db.SaveChanges();
    }

    public void RemoveQuiz(Quiz quiz)
    {
        _db.Quizzes.Remove(quiz);
        _db.SaveChanges();
    }

    public void UpdateQuiz(Quiz original, Quiz updated)
    {
        _db.Remove(original);
        _db.Add(updated);
        _db.SaveChanges();
    }

    public Quiz GetQuiz(int id)
    {
        return _db.Quizzes.Include(q => q.Questions).First(x => x.Id == id);
    }

    public List<Quiz> GetQuizzes()
    {
        return _db.Quizzes.Include(q => q.Questions).ToList();
    }

    public void AddTakerScore(TakerScore takerScore)
    {
        _db.TakerScores.Add(takerScore);
        _db.SaveChanges();
    }

    public void RemoveTakerScore(TakerScore takerScore)
    {
        _db.TakerScores.Remove(takerScore);
        _db.SaveChanges();
    }

    public void UpdateTakerScore(TakerScore original, TakerScore updated)
    {
        _db.Remove(original);
        _db.Add(updated);
        _db.SaveChanges();
    }

    public TakerScore GetTakerScore(int id)
    {
        return _db.TakerScores.First(x => x.Id == id);
    }

    public List<TakerScore> GetTakerScores()
    {
        return _db.TakerScores.ToList();
    }

    public List<TakerScore> GetTakerScores(int userId)
    {
        return _db.TakerScores.Where(x => x.UserId == userId).ToList();
    }

    private void InitializeRepo()
    {
        _db.Database.EnsureCreated();
        _db.SaveChanges();
    }
}