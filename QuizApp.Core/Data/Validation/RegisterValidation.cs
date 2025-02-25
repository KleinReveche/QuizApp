using System.Globalization;
using System.Text;
using QuizApp.Core.Data.Repo;

namespace QuizApp.Core.Data.Validation;

public class RegisterValidation(IRepo repo)
{
    public string ValidateUsername(string username, bool existingUser = false)
    {
        var errorMsg = new StringBuilder();
        if (username.Length < 5)
            errorMsg.Append("\u2717 Username must be at least 5 characters long.\n");

        if (repo.GetUser(username.ToLower(CultureInfo.InvariantCulture)) is not null && !existingUser)
            errorMsg.Append("\u2717 Username already exists.\n");

        return errorMsg.ToString();
    }

    public string ValidatePassword(string password, string repeatPassword, string modifier = "", bool changeDefaultPassword = false)
    {
        if (changeDefaultPassword)
        {
            if (password == "password" && repeatPassword == "password") return string.Empty;

            return "Use 'password' as the old password.";
        }

        var errorMsg = new StringBuilder();

        if (password.Length < 8)
            errorMsg.Append($"\u2717 {modifier}Password must be at least 8 characters long.\n");

        if (!password.Any(char.IsUpper))
            errorMsg.Append($"\u2717 {modifier}Password must contain at least one uppercase letter.\n");

        if (!password.Any(char.IsLower))
            errorMsg.Append($"\u2717 {modifier}Password must contain at least one lowercase letter.\n");

        if (!password.Any(char.IsDigit))
            errorMsg.Append($"\u2717 {modifier}Password must contain at least one digit.\n");

        if (password.All(char.IsLetterOrDigit))
            errorMsg.Append($"\u2717 {modifier}Password must contain at least one special character.\n");

        if (password != repeatPassword)
            errorMsg.Append($"\u2717 {modifier}Passwords do not match.\n");

        return errorMsg.ToString();
    }

    public string ValidateEmail(string email, bool existingUser = false)
    {
        var errorMsg = new StringBuilder();

        if (!email.Contains("@tracecollege.edu.ph"))
            errorMsg.Append("\u2717 Invalid email address. Please use your TRACE College email address.\n");

        if (repo.GetUserByEmail(email.ToLower(CultureInfo.InvariantCulture)) is not null && !existingUser)
            errorMsg.Append("\u2717 Email already exists.\n");

        return errorMsg.ToString();
    }

    public string ValidateName(string name) {

        var errorMsg = new StringBuilder();

        if (name.Length < 2)
            errorMsg.Append("\u2717 Name must be at least 2 characters long.\n");

        return errorMsg.ToString();
    }
}