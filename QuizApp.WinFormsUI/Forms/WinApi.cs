using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace QuizApp.WinFormsUI.Forms;

/// Taken from https://www.codeproject.com/Articles/16618/How-To-Make-a-Windows-Form-App-Truly-Full-Screen-a
/// <summary>
///     Selected Windows API Function Calls
/// </summary>
internal static partial class WinApi
{
    private const int SM_CXSCREEN = 0;
    private const int SM_CYSCREEN = 1;
    private const int SWP_SHOWWINDOW = 64;
    private static readonly IntPtr HWND_TOP = IntPtr.Zero;

    private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
    private const uint SWP_NOSIZE = 0x0001;
    private const uint SWP_NOMOVE = 0x0002;
    private const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

    private static int ScreenX => GetSystemMetrics(SM_CXSCREEN);
    private static int ScreenY => GetSystemMetrics(SM_CYSCREEN);

    [LibraryImport("user32.dll", EntryPoint = "GetSystemMetrics")]
    private static partial int GetSystemMetrics(int which);

    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int width, int height, uint flags);

    internal static void SetWinFullScreen(IntPtr hwnd) => SetWindowPos(hwnd, HWND_TOP, 0, 0, ScreenX, ScreenY, SWP_SHOWWINDOW);

    [LibraryImport("Gdi32", EntryPoint = "CreateRoundRectRgn")]
    internal static partial IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

    [DllImport("user32.dll")]
#pragma warning disable SYSLIB1054 // LibraryImport seems not to work with user32.SendMessage
    internal static extern IntPtr SendMessage(IntPtr hWnd, uint wMsg, UIntPtr wParam, IntPtr lParam);
#pragma warning restore SYSLIB1054

    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static partial bool ReleaseCapture();

    public static void SetWindowAlwaysTop(IntPtr handle) => SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
}

/// <summary>
///     Class used to preserve / restore / maximize state of the form
/// </summary>
public class FormState
{
    private Rectangle _bounds;
    private FormBorderStyle _brdStyle;

    private bool _isMaximized;
    private bool _topMost;
    private FormWindowState _winState;

    public void Maximize(Form targetForm)
    {
        if (_isMaximized) return;
        _isMaximized = true;
        Save(targetForm);
        targetForm.WindowState = FormWindowState.Maximized;
        targetForm.FormBorderStyle = FormBorderStyle.None;
        targetForm.TopMost = true;
        WinApi.SetWinFullScreen(targetForm.Handle);
    }

    private void Save(Form targetForm)
    {
        _winState = targetForm.WindowState;
        _brdStyle = targetForm.FormBorderStyle;
        _topMost = targetForm.TopMost;
        _bounds = targetForm.Bounds;
    }

    public void Restore(Form targetForm)
    {
        targetForm.WindowState = _winState;
        targetForm.FormBorderStyle = _brdStyle;
        targetForm.TopMost = _topMost;
        targetForm.Bounds = _bounds;
        _isMaximized = false;
    }
}