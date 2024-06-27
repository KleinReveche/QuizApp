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
        return _db.Quizzes.First(x => x.Id == id);
    }

    public List<Quiz> GetQuizzes()
    {
        return _db.Quizzes.ToList();
    }

    public int GetNewUserId()
    {
        try
        {
            return GetUsers().OrderBy(x => x.Id).Last().Id + 1;
        }
        catch
        {
            return 0;
        }
    }

    public int GetNewQuizId()
    {
        try
        {
            return GetQuizzes().OrderBy(x => x.Id).Last().Id + 1;
        }
        catch
        {
            return 0;
        }
    }

    public int GetNewQuestionId()
    {
        try
        {
            return GetQuizzes().SelectMany(x => x.Questions).OrderBy(x => x.Id).Last().Id + 1;
        }
        catch
        {
            return 0;
        }
        
    }

    private void InitializeRepo()
    {
        _db.Database.EnsureCreated();
        _db.SaveChanges();
    }
}