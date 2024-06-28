using System.Runtime.InteropServices;
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
        var clickDelta = DateTime.Now - _lastClickTime;

        if (clickDelta.TotalMilliseconds <= SystemInformation.DoubleClickTime)
        {
            WindowState = WindowState != FormWindowState.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        else
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
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
            FormWindowState.Normal => Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)),
            FormWindowState.Maximized => Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0)),
            _ => Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
        };
    }
}