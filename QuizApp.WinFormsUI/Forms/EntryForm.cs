using System.Text;
using QuizApp.Core.Data;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Validation;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Forms;

public partial class EntryForm : Form
{
    private bool _isRegisterForm;

    public EntryForm()
    {
        InitializeComponent();
        Region = Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
    }

    private void ActionBar_MouseDown(object sender, MouseEventArgs e)
    {
        WinApi.ReleaseCapture();
        WinApi.SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void lblClose_Click(object sender, EventArgs e) => Application.Exit();
    private void btnAction_Click(object sender, EventArgs e)
    {
        if (_isRegisterForm)
            RegisterUser();
        else
            LoginUser();
    }

    private void RegisterUser()
    {
        var errorMsg = ValidateRegistration();

        if (!string.IsNullOrEmpty(errorMsg))
        {
            MessageBox.Show(errorMsg, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var credentials = new Credentials();
        var newUser = new User
        {
            FirstName = boxRegisterFirstName.Text,
            LastName = boxRegisterLastName.Text,
            Username = boxRegisterUsername.Text,
            PasswordHash = credentials.HashPassword(boxRegisterPassword.Text, out var salt),
            Salt = salt,
            Email = boxEmail.Text
        };

        QuizApp.Repo.AddUser(newUser);
        ShowDashboard(newUser);
    }

    private string ValidateRegistration()
    {
        var errorMsg = new StringBuilder();
        var validation = new RegisterValidation(QuizApp.Repo);

        errorMsg.Append(validation.ValidateUsername(boxRegisterUsername.Text));
        errorMsg.Append(validation.ValidatePassword(boxRegisterPassword.Text, boxRepeatPassword.Text));
        errorMsg.Append(validation.ValidateEmail(boxEmail.Text));

        return errorMsg.ToString();
    }

    private void LoginUser()
    {
        var result = ValidateLogin();

        if (!string.IsNullOrEmpty(result))
        {
            MessageBox.Show(result, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var defaultPassword = boxLoginPassword.Text == "password";

        var user = QuizApp.Repo.GetUser(boxLoginUsername.Text);
        ShowDashboard(user!, defaultPassword);
    }

    private string ValidateLogin() => new LoginValidation(QuizApp.Repo).ValidateLogin(boxLoginUsername.Text, boxLoginPassword.Text);

    private void ShowDashboard(User user, bool defaultPassword = false)
    {
        Hide();

        if (user.UserType == UserType.User)
        {
            var dashboard = new StudentDashboardForm(user, defaultPassword);
            dashboard.Show();
        }
        else
        {
            var dashboard = new AdminDashboardForm(user);
            dashboard.Show();
        }
    }

    private void lblSwitchEntryForm_Click(object sender, EventArgs e)
    {
        if (_isRegisterForm)
        {
            panelLogin.Visible = true;
            panelRegister.Visible = false;
            _isRegisterForm = false;
        }
        else
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
            _isRegisterForm = true;
        }
    }

    private void box_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Return) return;

        if (_isRegisterForm)
            RegisterUser();
        else
            LoginUser();
    }
}