using QuizApp.Core.Data.Models;

namespace QuizApp.WinFormsUI.Controls;

public partial class HomeStudent : UserControl
{
    private User _user;
    
    public HomeStudent()
    {
        //_viewModel = viewModel;
        InitializeComponent();
        //lblWelcome.Text = $"Welcome {_viewModel.User.Username}!";
    }
}