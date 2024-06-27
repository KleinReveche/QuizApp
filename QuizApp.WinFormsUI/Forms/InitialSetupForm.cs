using System.Runtime.InteropServices;
using System.Text;
using QuizApp.Core.Data;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Validation;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Forms;

public partial class InitialSetupForm : Form
{
    public InitialSetupForm()
    {
        InitializeComponent();
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
    );

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

    private void ActionBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void lblClose_Click(object sender, EventArgs e) => Application.Exit();

    private void btnAction_Click(object sender, EventArgs e)
    {
        var errorMsg = new StringBuilder();
        var validation = new RegisterValidation(QuizApp.Repo);

        errorMsg.Append(validation.ValidateUsername(boxUsername.Text));
        errorMsg.Append(validation.ValidatePassword(boxPassword.Text, boxRepeatPassword.Text));
        errorMsg.Append(validation.ValidateEmail(boxEmail.Text));

        if (errorMsg.Length != 0)
        {
            MessageBox.Show(errorMsg.ToString(), Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var credentials = new Credentials();
        var newUser = new User
        {
            Username = boxUsername.Text,
            PasswordHash = credentials.HashPassword(boxPassword.Text, out var salt),
            Salt = salt,
            Email = boxEmail.Text,
            UserType = UserType.Admin
        };

        QuizApp.Repo.AddUser(newUser);

        var dashboard = new AdminDashboardForm(newUser);
        dashboard.Show();
    }
}