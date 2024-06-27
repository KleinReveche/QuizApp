using QuizApp.Core.Data;
using QuizApp.Core.Data.Repo;
using QuizApp.WinFormsUI.Forms;

namespace QuizApp.WinFormsUI;

internal static class QuizApp
{
    public static readonly IRepo Repo = new SqlRepo(new SqliteDbContext());

    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        if (File.Exists(SqliteDbContext.DbName))
            Application.Run(new EntryForm());
        else
            Application.Run(new InitialSetupForm());

        //Application.Run(new StudentDashboardForm(
        //    new StudentDashboardViewModel
        //    {
        //        User = new User
        //        {
        //            Username = "kleinreveche",
        //            Email = "kreveche@tracecollege.edu.ph",
        //            PasswordHash = "",
        //            Salt = [],
        //            UserType = UserType.User
        //        }
        //    }
        //    ));
        //Application.Run(new EntryForm());
        //Application.Run(new AdminDashboardForm(new AdminDashboardViewModel() {User = Repo.GetUser("admin")!}));
    }
}