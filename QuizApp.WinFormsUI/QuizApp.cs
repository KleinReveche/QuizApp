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
        //Application.Run(new AdminDashboardForm(Repo.GetUser("admin")!));
        // Application.Run(new QuizForm(Repo.GetQuizzes()[1], Repo.GetUser(1)));
        // return;

        if (File.Exists(SqliteDbContext.DbName))
            Application.Run(new EntryForm());
        else
            Application.Run(new InitialSetupForm());
    }
}