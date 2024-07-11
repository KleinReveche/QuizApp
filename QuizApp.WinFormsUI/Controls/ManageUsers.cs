 using QuizApp.Core.Data;
 using QuizApp.Core.Data.Models;
 using QuizApp.Core.Data.Serializable;
 using QuizApp.WinFormsUI.Properties;
using ReaLTaiizor.Controls;
using System.Text;
using QuizApp.Core.Data.Validation;

namespace QuizApp.WinFormsUI.Controls;

public partial class ManageUsers : UserControl
{
    private bool _isUserEditMode;
    private List<User> _users = [];

    public ManageUsers()
    {
        InitializeComponent();
    }

    private void ManageUsers_Load(object sender, EventArgs e)
    {
        _users = QuizApp.Repo.GetUsers().Where(u => u.UserType == UserType.User).ToList();
        UpdateUI();
        if (_users.Count > 0) SetUserDetails(_users[0], true);
    }

    private void ManageUsers_Layout(object sender, LayoutEventArgs e)
    {
        var noUsers = _users.Count == 0;
        btnSaveUser.Visible = !noUsers;
        btnRemoveUser.Visible = !noUsers;
        listUsers.Visible = !noUsers;
        grpBxUserDetails.Visible = !noUsers;
        LblNoUsersAvailable.Visible = noUsers;

        if (noUsers) return;
        listUsers.Items.Clear();
        listUsers.Items.AddRange(_users.Select(user => user.FullName).ToArray());

        listUsers.Items.Clear();
        listUsers.Items.AddRange(_users.Select(user => user.FullName).ToArray());

        if (listUsers.SelectedIndex < 0)
            grpBxUserDetails.Visible = false;
    }

    private void btnEditUser_Click(object sender, EventArgs e)
    {
        if (_isUserEditMode)
        {
            if (InUserCreation()) return;

            var user = _users[listUsers.SelectedIndex];
            SetUserDetails(user, true);
            _isUserEditMode = false;
            btnSaveUser.Enabled = false;
        }
        else
        {
            var user = _users[listUsers.SelectedIndex];
            SetUserDetails(user, false);
            _isUserEditMode = true;
            btnSaveUser.Enabled = true;
        }
    }

    private void btnRemoveUser_Click(object sender, EventArgs e)
    {
        if (listUsers.SelectedIndex < 0) return;
        if (_isUserEditMode)
        {
            InUserCreation();
            return;
        }

        var result = MessageBox.Show(Resources.delete_user, Resources.warning, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
        if (result == DialogResult.No) return;

        var user = _users[listUsers.SelectedIndex];
        QuizApp.Repo.RemoveUser(user);
        _users.Remove(user);
        listUsers.Items.RemoveAt(listUsers.SelectedIndex);

        UpdateUI();
    }

    private void btnAddUser_Click(object sender, EventArgs e)
    {
        if (InUserCreation()) return;

        var newUser = new User
        {
            UserType = UserType.User,
            FirstName = "Juan",
            LastName = "Dela Cruz",
            Username = "",
            Email = "",
            PasswordHash = "password",
            Salt = []
        };

        _users.Add(newUser);
        UpdateUI();
        listUsers.SelectedIndex = listUsers.Items.Count - 1;
        btnEditUser_Click(sender, e);
    }

    private bool InUserCreation()
    {
        if (!_isUserEditMode) return false;

        var result = MessageBox.Show(Resources.discard_user, Resources.warning, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
        if (result == DialogResult.No) return true;

        _isUserEditMode = false;
        _users.RemoveAt(_users.Count - 1);
        UpdateUI();
        return false;
    }

    private void btnSaveUser_Click(object sender, EventArgs e)
    {

        var result = MessageBox.Show(Resources.save_user_confirmation, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return;


        var errorMsg = new StringBuilder();
        var validation = new RegisterValidation(QuizApp.Repo);
        var retainOldPassword = boxPassword.Text != "retain" && boxRepeatPassword.Text != "retain";
        var newUser = boxPassword.Text != "password" && boxRepeatPassword.Text != "password";

        errorMsg.Append(validation.ValidateUsername(boxUsername.Text, true));
        if (retainOldPassword && newUser)
            errorMsg.Append(validation.ValidatePassword(boxPassword.Text, boxRepeatPassword.Text));
        errorMsg.Append(validation.ValidateEmail(boxEmail.Text, true));

        if (!string.IsNullOrEmpty(errorMsg.ToString()))
        {
            MessageBox.Show(errorMsg.ToString(), Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var passwordHash = new Credentials().HashPassword(boxPassword.Text, out var salt);
        var original = QuizApp.Repo.GetUser(boxUsername.Text);

        if (retainOldPassword)
        {
            passwordHash = original!.PasswordHash;
            salt = original.Salt;
        }

        if (newUser)
        {
            passwordHash = "password";
            salt = [];
        }

        var user = new User
        {
            UserType = UserType.User,
            FirstName = boxFirstName.Text,
            LastName = boxLastName.Text,
            Username = boxUsername.Text,
            Email = boxEmail.Text,
            PasswordHash = passwordHash,
            Salt = salt
        };

        if (original != null)
        {
            QuizApp.Repo.UpdateUser(original, user);
            _users[listUsers.SelectedIndex] = user;
        }
        else
        {
            QuizApp.Repo.AddUser(user);
        }
    }

    private void UpdateUI()
    {
        var noUsers = _users.Count == 0;
        btnSaveUser.Visible = !noUsers;
        btnRemoveUser.Visible = !noUsers;
        btnEditUser.Visible = !noUsers;
        listUsers.Visible = !noUsers;
        grpBxUserDetails.Visible = !noUsers;
        LblNoUsersAvailable.Visible = noUsers;

        if (noUsers) return;
        listUsers.Items.Clear();
        listUsers.Items.AddRange(_users.Select(user => user.FullName).ToArray());
        if (listUsers.SelectedIndex < 0 && listUsers.Items.Count > 0)
            listUsers.SelectedIndex = 0;
        grpBxUserDetails.Visible = false;
    }

    private void SetUserDetails(User? user, bool readOnly)
    {
        boxFirstName.Text = user?.FirstName ?? "";
        boxLastName.Text = user?.LastName ?? "";
        boxUsername.Text = user?.Username ?? "";
        boxEmail.Text = user?.Email ?? "";
        boxPassword.Text = readOnly ? "password" : "retain";
        boxRepeatPassword.Text = readOnly ? "password" : "retain";

        boxFirstName.Enabled = !readOnly;
        boxLastName.Enabled = !readOnly;
        boxUsername.Enabled = !readOnly;
        boxEmail.Enabled = !readOnly;
        boxPassword.Enabled = !readOnly;
        boxRepeatPassword.Enabled = !readOnly;
    }

    private void btnImportUsers_Click(object sender, EventArgs e)
    {
        if (InUserCreation()) return;
        using var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = Resources.files_csv;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        var file = openFileDialog.OpenFile();

        var newUsers = UsersImportManager.ImportFromCsv(new StreamReader(file), QuizApp.Repo);
        _users.AddRange(newUsers);
        QuizApp.Repo.AddUsers(newUsers);
        UpdateUI();
    }

    private void listUsers_SelectedIndexChanged(object sender)
    {
        if (sender is not MetroListBox list) return;
        var index = list.SelectedIndex;

        if (index < 0) return;
        var user = _users[index];

        btnSaveUser.Visible = true;
        btnRemoveUser.Visible = true;
        btnEditUser.Visible = true;
        grpBxUserDetails.Visible = true;

        boxFirstName.Text = user.FirstName;
        boxLastName.Text = user.LastName;
        boxUsername.Text = user.Username;
        boxEmail.Text = user.Email;
    }

    private void boxUsername_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Back)
        {
            boxEmail.Text = boxUsername.Text[..^1] + Resources.email;
            return;
        }

        var letter = char.IsLetter(e.KeyChar) ? e.KeyChar.ToString() : "";
        boxEmail.Text = boxUsername.Text + letter + Resources.email;
    }
}