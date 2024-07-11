using QuizApp.Core.Data.Models;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Forms;

public partial class StudentDashboardForm : Form
{
    private UserControl _currentPageControl;

    private DateTime _lastClickTime = DateTime.MinValue;
    private readonly User _user;
    private readonly bool _defaultPassword;

    public StudentDashboardForm(User user, bool defaultPassword)
    {
        _user = user;
        _defaultPassword = defaultPassword;
        InitializeComponent();
        _currentPageControl = defaultPassword ? settings : quizzes;

        if (!defaultPassword) return;
        quizzes.Visible = false;
        SidePanelIndicator.Top = btnSettings.Top;
        SidePanelIndicator.Height = btnSettings.Height;
        _currentPageControl.Visible = false;
        _currentPageControl = settings;
        _currentPageControl.Visible = true;
        btnQuizzes.Enabled = false;
        MessageBox.Show(Resources.change_password, Resources.error, MessageBoxButtons.OK);
    }

    private void ActionBar_MouseDown(object sender, MouseEventArgs e)
    {
        var clickDelta = DateTime.Now - _lastClickTime;

        if (clickDelta.TotalMilliseconds <= SystemInformation.DoubleClickTime)
        {
            WindowState = WindowState != FormWindowState.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        else
        {
            WinApi.ReleaseCapture();
            WinApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        _lastClickTime = DateTime.Now;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnMenu_Click(object sender, EventArgs e)
    {
        if (sender is not Button button) return;

        switch (button.Name)
        {
            case "btnQuizzes":
                if (_currentPageControl == quizzes) return;
                HideCurrentPage(button);
                _currentPageControl = quizzes;
                _currentPageControl.Visible = true;
                break;
            case "btnSettings":
                if (_currentPageControl == settings) return;
                HideCurrentPage(button);
                _currentPageControl = settings;
                _currentPageControl.Visible = true;
                break;
        }
    }

    private void HideCurrentPage(Button button)
    {
        SidePanelIndicator.Top = button.Top;
        SidePanelIndicator.Height = button.Height;
        _currentPageControl.Visible = false;
    }

    private void StudentDashboard_Layout(object sender, LayoutEventArgs e)
    {
        btnClose.BringToFront();

        Region = WindowState switch
        {
            FormWindowState.Normal => Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 20, 20)),
            FormWindowState.Maximized => Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 0, 0)),
            _ => Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
        };

        if (settings.DefaultPassword) return;
        btnQuizzes.Enabled = true;
    }

    private void StudentDashboardForm_Paint(object sender, PaintEventArgs e)
    {
        if (settings.DefaultPassword) return;
        btnQuizzes.Enabled = true;
    }
}