using QuizApp.Core.Data.Models;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Controls;

public partial class HomeAdmin : UserControl
{
    private User _user;

    public HomeAdmin(User user)
    {
        _user = user;
        InitializeComponent();
        lblWelcome.Text = string.Format(Resources.welcome_user, _user.Username);
    }
}