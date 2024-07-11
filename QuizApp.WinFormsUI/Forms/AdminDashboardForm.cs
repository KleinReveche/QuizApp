using QuizApp.Core.Data.Models;

namespace QuizApp.WinFormsUI.Forms;

public partial class AdminDashboardForm : Form
{
    private UserControl _currentPageControl;

    private DateTime _lastClickTime = DateTime.MinValue;
    private User _user;

    public AdminDashboardForm(User user)
    {
        _user = user;
        InitializeComponent();
        _currentPageControl = home;
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

    private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

    private void btnMenu_Click(object sender, EventArgs e)
    {
        if (sender is not Button button) return;

        switch (button.Name)
        {
            case "btnHome":
                if (_currentPageControl == home) return;
                HideCurrentPage(button);
                _currentPageControl = home;
                _currentPageControl.Visible = true;
                break;
            case "btnQuizzes":
                if (_currentPageControl == quizzes) return;
                HideCurrentPage(button);
                _currentPageControl = quizzes;
                _currentPageControl.Visible = true;
                break;
            case "btnUsers":
                if (_currentPageControl == users) return;
                HideCurrentPage(button);
                _currentPageControl = users;
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

    private void AdminDashboard_Layout(object sender, LayoutEventArgs e)
    {
        btnClose.BringToFront();

        Region = WindowState switch
        {
            FormWindowState.Normal => Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 20, 20)),
            FormWindowState.Maximized => Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 0, 0)),
            _ => Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
        };
    }
}