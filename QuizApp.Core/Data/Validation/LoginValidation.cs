using System.Text;
using QuizApp.Core.Data.Repo;

namespace QuizApp.Core.Data.Validation;

public class LoginValidation(IRepo repo)
{
    public string ValidateLogin(string username, string password)
    {
        var errorMsg = new StringBuilder();

        if (username.Length < 5)
            errorMsg.Append("\u2717 Username must be at least 5 characters long.\n");

        if (password.Length < 8)
            errorMsg.Append("\u2717 Password must be at least 8 characters long.\n");

        if (errorMsg.Length != 0) return errorMsg.ToString();

        var user = repo.GetUser(username);

        if (user == null)
        {
            errorMsg.Append("Username not found.\n");
            return errorMsg.ToString();
        }

        return !new Credentials().VerifyPassword(password, user.PasswordHash, user.Salt)
            ? errorMsg.Append("\u2717 Wrong password. Try again.").ToString()
            : errorMsg.ToString();
    }
}