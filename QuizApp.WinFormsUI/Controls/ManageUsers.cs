using QuizApp.Core.Data;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Validation;
using QuizApp.WinFormsUI.Properties;
using ReaLTaiizor.Controls;

namespace QuizApp.WinFormsUI.Controls;

public partial class ManageUsers : UserControl
{
    private List<User> _users = [];

    public ManageUsers()
    {
        InitializeComponent();
    }

    private void ManageUsers_Layout(object sender, LayoutEventArgs e)
    {
        if (_users.Count == 0)
        {
            btnSaveUser.Visible = false;
            btnRemoveUser.Visible = false;
            listUsers.Visible = false;
            grpBxUserDetails.Visible = false;
            LblNoUsersAvailable.Visible = true;
        }
        else
        {
            listUsers.Items.Clear();
            foreach (var user in _users)
            {
                listUsers.Items.Add(user.FullName);
            }
            listUsers.Visible = true;
            if (listUsers.HotLightedIndex > 0) grpBxUserDetails.Visible = false;
            LblNoUsersAvailable.Visible = false;
        }
    }

    private void listUsers_Click(object sender, EventArgs e)
    {
        if (sender is not RoyalListBox list) return;
        var index = list.HotLightedIndex;

        if (index < 0) return;
        btnSaveUser.Visible = true;
        btnRemoveUser.Visible = true;
        grpBxUserDetails.Visible = true;
    }
    
    private void manageUsers_Load(object sender, EventArgs e)
    {
        _users = QuizApp.Repo.GetUsers().Where(u => u.UserType == UserType.User).ToList();
    }
}