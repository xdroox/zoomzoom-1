// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Win32
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace ZoomZoom
{
  public class Win32
  {
    public const uint MAX_PATH = 260;
    public const int GWL_HWNDPARENT = -8;
    public const int GWL_EXSTYLE = -20;
    public const int GWL_STYLE = -16;
    public const int GCL_HICON = -14;
    public const int GCL_HICONSM = -34;
    public const int WM_QUERYDRAGICON = 55;
    public const int WM_GETICON = 127;
    public const int WM_SETICON = 128;
    public const int ICON_SMALL = 0;
    public const int ICON_BIG = 1;
    public const int SMTO_ABORTIFHUNG = 2;
    public const int TRUE = 1;
    public const int FALSE = 0;
    public const int WHITE_BRUSH = 0;
    public const int LTGRAY_BRUSH = 1;
    public const int GRAY_BRUSH = 2;
    public const int DKGRAY_BRUSH = 3;
    public const int BLACK_BRUSH = 4;
    public const int NULL_BRUSH = 5;
    public const int HOLLOW_BRUSH = 5;
    public const int WHITE_PEN = 6;
    public const int BLACK_PEN = 7;
    public const int NULL_PEN = 8;
    public const int OEM_FIXED_FONT = 10;
    public const int ANSI_FIXED_FONT = 11;
    public const int ANSI_VAR_FONT = 12;
    public const int SYSTEM_FONT = 13;
    public const int DEVICE_DEFAULT_FONT = 14;
    public const int DEFAULT_PALETTE = 15;
    public const int SYSTEM_FIXED_FONT = 16;
    public const int RDW_INVALIDATE = 1;
    public const int RDW_INTERNALPAINT = 2;
    public const int RDW_ERASE = 4;
    public const int RDW_VALIDATE = 8;
    public const int RDW_NOINTERNALPAINT = 16;
    public const int RDW_NOERASE = 32;
    public const int RDW_NOCHILDREN = 64;
    public const int RDW_ALLCHILDREN = 128;
    public const int RDW_UPDATENOW = 256;
    public const int RDW_ERASENOW = 512;
    public const int RDW_FRAME = 1024;
    public const int RDW_NOFRAME = 2048;
    public const int HIDE_WINDOW = 0;
    public const int SHOW_OPENWINDOW = 1;
    public const int SHOW_ICONWINDOW = 2;
    public const int SHOW_FULLSCREEN = 3;
    public const int SHOW_OPENNOACTIVATE = 4;
    public const int SW_PARENTCLOSING = 1;
    public const int SW_OTHERZOOM = 2;
    public const int SW_PARENTOPENING = 3;
    public const int SW_OTHERUNZOOM = 4;
    public const int SWP_NOSIZE = 1;
    public const int SWP_NOMOVE = 2;
    public const int SWP_NOZORDER = 4;
    public const int SWP_NOREDRAW = 8;
    public const int SWP_NOACTIVATE = 16;
    public const int SWP_FRAMECHANGED = 32;
    public const int SWP_SHOWWINDOW = 64;
    public const int SWP_HIDEWINDOW = 128;
    public const int SWP_NOCOPYBITS = 256;
    public const int SWP_NOOWNERZORDER = 512;
    public const int SWP_NOSENDCHANGING = 1024;
    public const int SWP_DRAWFRAME = 32;
    public const int SWP_NOREPOSITION = 512;
    public const int SWP_DEFERERASE = 8192;
    public const int SWP_ASYNCWINDOWPOS = 16384;
    public const int HWND_TOP = 0;
    public const int HWND_BOTTOM = 1;
    public const int HWND_TOPMOST = -1;
    public const int HWND_NOTOPMOST = -2;

    public Win32()
    {
label_1:
      int num1 = -904134432;
      while (true)
      {
        int num2 = -321946254;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1287885844 ^ -260292998;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    [DllImport("user32.dll")]
    public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

    [DllImport("user32.dll")]
    public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

    [DllImport("user32.dll")]
    public static extern IntPtr SetWindowsHookEx(Win32.HookTypes hookType, Win32.HookProc hookProc, IntPtr hInstance, int nThreadId);

    [DllImport("user32.dll")]
    public static extern int UnhookWindowsHookEx(IntPtr hookHandle);

    [DllImport("user32.dll")]
    public static extern int CallNextHookEx(IntPtr hookHandle, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern int RegisterShellHookWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern int DeregisterShellHookWindow(IntPtr hWnd);

    [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
    public static extern int GetLastError();

    [DllImport("user32.dll")]
    public static extern int GetWindowModuleFileName(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll")]
    public static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    [DllImport("user32.dll")]
    public static extern bool GetWindowPlacement(IntPtr window, ref Win32.WindowPlacement position);

    [DllImport("User32.dll")]
    public static extern int RegisterWindowMessage(string message);

    [DllImport("User32.dll")]
    public static extern void EnumWindows(Win32.EnumWindowEventHandler callback, int lParam);

    [DllImport("User32.dll")]
    public static extern bool IsWindowVisible(IntPtr hWnd);

    [DllImport("User32.dll")]
    public static extern int GetWindow(IntPtr hWnd, int wCmd);

    [DllImport("User32.dll")]
    public static extern IntPtr GetParent(IntPtr hWnd);

    [DllImport("User32.dll")]
    public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

    [DllImport("User32.dll")]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("User32.dll")]
    public static extern Win32.WindowStyles GetWindowLong(IntPtr hWnd, int index);

    [DllImport("User32.dll")]
    public static extern int SendMessageTimeout(IntPtr hWnd, int uMsg, int wParam, int lParam, int fuFlags, int uTimeout, out int lpdwResult);

    [DllImport("User32.dll")]
    public static extern int GetClassLong(IntPtr hWnd, int index);

    [DllImport("User32.dll")]
    public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

    [DllImport("User32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int uMsg, IntPtr wParam, IntPtr lParam);

    [DllImport("User32.dll")]
    public static extern int PostMessage(IntPtr hWnd, int uMsg, IntPtr wParam, IntPtr lParam);

    [DllImport("User32.dll")]
    public static extern void SwitchToThisWindow(IntPtr hWnd, int altTabActivated);

    [DllImport("User32.dll")]
    public static extern int ShowWindowAsync(IntPtr hWnd, int command);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    public static extern bool BringWindowToTop(IntPtr window);

    [DllImport("user32.dll")]
    public static extern bool GetWindowInfo(IntPtr hwnd, ref Win32.WindowInfo info);

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowDC(IntPtr hwnd);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDC(IntPtr hwnd);

    [DllImport("user32.dll")]
    public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

    [DllImport("user32.dll")]
    public static extern bool GetWindowRect(IntPtr hwnd, ref Win32.Rect rectangle);

    [DllImport("user32.dll")]
    public static extern bool GetClientRect(IntPtr hwnd, ref Win32.Rect rectangle);

    [DllImport("user32.dll")]
    public static extern IntPtr WindowFromPoint(System.Drawing.Point pt);

    [DllImport("user32.dll")]
    public static extern IntPtr SetCapture(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern int ReleaseCapture();

    [DllImport("user32.dll")]
    public static extern IntPtr SelectObject(IntPtr hDc, IntPtr hObject);

    [DllImport("user32.dll")]
    public static extern IntPtr GetStockObject(int nObject);

    [DllImport("user32.dll")]
    public static extern int InvalidateRect(IntPtr hWnd, IntPtr lpRect, int bErase);

    [DllImport("user32.dll")]
    public static extern int UpdateWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern int RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);

    [DllImport("gdi32.dll")]
    public static extern bool BitBlt(IntPtr hdcDst, int xDst, int yDst, int cx, int cy, IntPtr hdcSrc, int xSrc, int ySrc, uint ulRop);

    [DllImport("gdi32.dll")]
    public static extern bool StretchBlt(IntPtr hdcDst, int xDst, int yDst, int cx, int cy, IntPtr hdcSrc, int xSrc, int ySrc, int cxSrc, int cySrc, uint ulRop);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateDC(IntPtr lpszDriver, string lpszDevice, IntPtr lpszOutput, IntPtr lpInitData);

    [DllImport("gdi32.dll")]
    public static extern IntPtr DeleteDC(IntPtr hdc);

    [DllImport("Shlwapi.dll")]
    public static extern string PathGetArgs(string path);

    public static string SafePathGetArgs(string path)
    {
      string str;
      try
      {
        str = Win32.PathGetArgs(path);
        goto label_10;
      }
      catch (Exception ex)
      {
label_3:
        int num1 = -873939143;
        while (true)
        {
          int num2 = -305325047;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 30293696 ^ -997124558;
              continue;
            default:
              goto label_6;
          }
        }
      }
label_6:
      str = string.Empty;
label_7:
      int num4 = -773232485;
      while (true)
      {
        int num1 = -305325047;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_7;
          case 1:
            num4 = (int) num2 * 845676306 ^ 946099638;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return str;
    }

    [DllImport("Shlwapi.dll")]
    public static extern int PathCompactPathEx(StringBuilder pszOut, StringBuilder pszSrc, uint cchMax, uint dwFlags);

    public static string PathCompactPathEx(string source, uint maxChars)
    {
      StringBuilder pszOut = Win32.\u200D⁮⁪⁭⁬⁯‪‭⁭⁪‍‏‎⁮‏⁭‬​⁬‫‫‬‍‫‏​‫​⁮‎‍⁮‏‎‍‎‍‏‬‭‮(260);
label_1:
      int num1 = 739277147;
      string str;
      while (true)
      {
        int num2 = 774120196;
        uint num3;
        StringBuilder pszSrc;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 1:
            pszSrc = Win32.\u200E⁬⁯​‮‌‏‏‮‭‭‬⁯‭‌‫‌‍‪⁫⁯‏‍⁫‮‫‌‬‪⁫‎‫⁪‪⁭⁫⁪‪⁫⁯‮(source);
            num1 = (int) num3 * -887170989 ^ -290500824;
            continue;
          case 2:
            num1 = 2044878045;
            continue;
          case 3:
            int num4 = Win32.PathCompactPathEx(pszOut, pszSrc, maxChars, 0U) != 1 ? 810646927 : (num4 = 576458344);
            int num5 = (int) num3 * 1828115865;
            num1 = num4 ^ num5;
            continue;
          case 4:
            str = string.Empty;
            num1 = (int) num3 * -943174617 ^ -498516640;
            continue;
          case 5:
            goto label_1;
          case 6:
            str = Win32.\u202D​‏⁮‌⁫‏‎‎⁬‮⁯‍‎⁫​‭​‏‎‭‬‮‏⁬‮⁫‏⁪‌‏⁮‏‏‬​⁬‎‮((object) pszOut);
            num1 = (int) num3 * -728141992 ^ 1174251863;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return str;
    }

    [DllImport("User32")]
    public static extern int RegisterHotKey(IntPtr hWnd, int id, uint modifiers, uint virtualkeyCode);

    [DllImport("User32")]
    public static extern int UnregisterHotKey(IntPtr hWnd, int id);

    [DllImport("Kernel32")]
    public static extern short GlobalAddAtom(string atomName);

    [DllImport("Kernel32")]
    public static extern short GlobalDeleteAtom(short atom);

    [DllImport("User32")]
    public static extern int LockWindowUpdate(IntPtr windowHandle);

    public static short MAKEWORD(byte a, byte b)
    {
label_1:
      int num1 = 1024074848;
      short num2;
      while (true)
      {
        int num3 = 123417493;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 1:
            num2 = (short) ((int) (byte) ((uint) a & (uint) byte.MaxValue) | (int) (byte) ((uint) b & (uint) byte.MaxValue) << 8);
            num1 = (int) num4 * -1032268816 ^ 616806390;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num4 * -624998114 ^ 515127939;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return num2;
    }

    public static byte LOBYTE(short a)
    {
label_1:
      int num1 = -2121978967;
      byte num2;
      while (true)
      {
        int num3 = -658872808;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num2 = (byte) ((uint) a & (uint) byte.MaxValue);
            num1 = (int) num4 * -2096033505 ^ 936660387;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return num2;
    }

    public static byte HIBYTE(short a)
    {
      byte num1 = (byte) ((uint) a >> 8);
label_1:
      int num2 = -1743089980;
      while (true)
      {
        int num3 = -1055658055;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num2 = (int) num4 * -197293390 ^ -1690678214;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return num1;
    }

    public static int MAKELONG(short a, short b)
    {
label_1:
      int num1 = 1522698496;
      int num2;
      while (true)
      {
        int num3 = 33824019;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 0:
            num1 = (int) num4 * 991551997 ^ 144499014;
            continue;
          case 2:
            goto label_1;
          case 3:
            num2 = (int) a & (int) ushort.MaxValue | ((int) b & (int) ushort.MaxValue) << 16;
            num1 = (int) num4 * 1537424535 ^ -2100342058;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return num2;
    }

    public static short HIWORD(int a)
    {
      short num1 = (short) (a >> 16);
label_1:
      int num2 = -299141209;
      while (true)
      {
        int num3 = -1053070057;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 3U)
        {
          case 1:
            num2 = (int) num4 * -442215918 ^ -356792764;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return num1;
    }

    public static short LOWORD(int a)
    {
label_1:
      int num1 = -82520980;
      short num2;
      while (true)
      {
        int num3 = -752000895;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num2 = (short) (a & (int) ushort.MaxValue);
            num1 = (int) num4 * 824881528 ^ 1263549974;
            continue;
          case 3:
            num1 = (int) num4 * 1172872390 ^ -53850387;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return num2;
    }

    [DllImport("Kernel32")]
    public static extern int CopyFile(string source, string destination, int failIfExists);

    static StringBuilder \u200D⁮⁪⁭⁬⁯‪‭⁭⁪‍‏‎⁮‏⁭‬​⁬‫‫‬‍‫‏​‫​⁮‎‍⁮‏‎‍‎‍‏‬‭‮([In] int obj0)
    {
      return new StringBuilder(obj0);
    }

    static StringBuilder \u200E⁬⁯​‮‌‏‏‮‭‭‬⁯‭‌‫‌‍‪⁫⁯‏‍⁫‮‫‌‬‪⁫‎‫⁪‪⁭⁫⁪‪⁫⁯‮([In] string obj0)
    {
      return new StringBuilder(obj0);
    }

    static string \u202D​‏⁮‌⁫‏‎‎⁬‮⁯‍‎⁫​‭​‏‎‭‬‮‏⁬‮⁫‏⁪‌‏⁮‏‏‬​⁬‎‮([In] object obj0)
    {
      return obj0.ToString();
    }

    public struct MSLLHOOKSTRUCT
    {
      public System.Drawing.Point Point;
      public int MouseData;
      public int Flags;
      public int Time;
      public int ExtraInfo;
    }

    public class HookEventArgs : EventArgs
    {
      private int _code;
      private IntPtr _wParam;
      private IntPtr _lParam;

      public int Code
      {
        get
        {
label_1:
          int num1 = -1697443047;
          int code;
          while (true)
          {
            int num2 = -10666216;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                code = this._code;
                num1 = (int) num3 * -2063591310 ^ -218225871;
                continue;
              case 2:
                goto label_1;
              case 3:
                num1 = (int) num3 * 1335474238 ^ 1332460998;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          return code;
        }
      }

      public IntPtr wParam
      {
        get
        {
          return this._wParam;
        }
      }

      public IntPtr lParam
      {
        get
        {
          return this._lParam;
        }
      }

      public HookEventArgs(int code, IntPtr wParam, IntPtr lParam)
      {
label_1:
        int num1 = 2102502439;
        while (true)
        {
          int num2 = 527298955;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              this._wParam = wParam;
              num1 = (int) num3 * 979357992 ^ -440279397;
              continue;
            case 2:
              this._lParam = lParam;
              num1 = (int) num3 * -367656130 ^ 1828474645;
              continue;
            case 3:
              this._code = code;
              num1 = (int) num3 * 2011550655 ^ -991246981;
              continue;
            case 4:
              num1 = (int) num3 * 997165821 ^ 1111847156;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public delegate void HookEventHandler(object sender, Win32.HookEventArgs e);

    public enum HookTypes
    {
      WH_JOURNALRECORD,
      WH_JOURNALPLAYBACK,
      WH_KEYBOARD,
      WH_GETMESSAGE,
      WH_CALLWNDPROC,
      WH_CBT,
      WH_SYSMSGFILTER,
      WH_MOUSE,
      WH_HARDWARE,
      WH_DEBUG,
      WH_SHELL,
      WH_FOREGROUNDIDLE,
      WH_CALLWNDPROCRET,
      WH_KEYBOARD_LL,
      WH_MOUSE_LL,
    }

    public enum ShellHookMessages
    {
      HSHELL_WINDOWCREATED = 1,
      HSHELL_WINDOWDESTROYED = 2,
      HSHELL_ACTIVATESHELLWINDOW = 3,
      HSHELL_WINDOWACTIVATED = 4,
      HSHELL_GETMINRECT = 5,
      HSHELL_REDRAW = 6,
      HSHELL_TASKMAN = 7,
      HSHELL_LANGUAGE = 8,
      HSHELL_ACCESSIBILITYSTATE = 11,
    }

    public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

    public enum ShowWindowCmds
    {
      SW_HIDE = 0,
      SW_NORMAL = 1,
      SW_SHOWNORMAL = 1,
      SW_SHOWMINIMIZED = 2,
      SW_MAXIMIZE = 3,
      SW_SHOWMAXIMIZED = 3,
      SW_SHOWNOACTIVATE = 4,
      SW_SHOW = 5,
      SW_MINIMIZE = 6,
      SW_SHOWMINNOACTIVE = 7,
      SW_SHOWNA = 8,
      SW_RESTORE = 9,
      SW_SHOWDEFAULT = 10,
      SW_FORCEMINIMIZE = 11,
      SW_MAX = 11,
    }

    public enum PeekMessageFlags
    {
      PM_NOREMOVE,
      PM_REMOVE,
      PM_NOYIELD,
    }

    public enum WindowMessages
    {
      WM_NULL = 0,
      WM_CREATE = 1,
      WM_DESTROY = 2,
      WM_MOVE = 3,
      WM_SIZE = 5,
      WM_ACTIVATE = 6,
      WM_SETFOCUS = 7,
      WM_KILLFOCUS = 8,
      WM_ENABLE = 10,
      WM_SETREDRAW = 11,
      WM_SETTEXT = 12,
      WM_GETTEXT = 13,
      WM_GETTEXTLENGTH = 14,
      WM_PAINT = 15,
      WM_CLOSE = 16,
      WM_QUERYENDSESSION = 17,
      WM_QUIT = 18,
      WM_QUERYOPEN = 19,
      WM_ERASEBKGND = 20,
      WM_SYSCOLORCHANGE = 21,
      WM_ENDSESSION = 22,
      WM_SHOWWINDOW = 24,
      WM_CTLCOLOR = 25,
      WM_SETTINGCHANGE = 26,
      WM_WININICHANGE = 26,
      WM_DEVMODECHANGE = 27,
      WM_ACTIVATEAPP = 28,
      WM_FONTCHANGE = 29,
      WM_TIMECHANGE = 30,
      WM_CANCELMODE = 31,
      WM_SETCURSOR = 32,
      WM_MOUSEACTIVATE = 33,
      WM_CHILDACTIVATE = 34,
      WM_QUEUESYNC = 35,
      WM_GETMINMAXINFO = 36,
      WM_PAINTICON = 38,
      WM_ICONERASEBKGND = 39,
      WM_NEXTDLGCTL = 40,
      WM_SPOOLERSTATUS = 42,
      WM_DRAWITEM = 43,
      WM_MEASUREITEM = 44,
      WM_DELETEITEM = 45,
      WM_VKEYTOITEM = 46,
      WM_CHARTOITEM = 47,
      WM_SETFONT = 48,
      WM_GETFONT = 49,
      WM_SETHOTKEY = 50,
      WM_GETHOTKEY = 51,
      WM_QUERYDRAGICON = 55,
      WM_COMPAREITEM = 57,
      WM_GETOBJECT = 61,
      WM_COMPACTING = 65,
      WM_COMMNOTIFY = 68,
      WM_WINDOWPOSCHANGING = 70,
      WM_WINDOWPOSCHANGED = 71,
      WM_POWER = 72,
      WM_COPYDATA = 74,
      WM_CANCELJOURNAL = 75,
      WM_NOTIFY = 78,
      WM_INPUTLANGCHANGEREQUEST = 80,
      WM_INPUTLANGCHANGE = 81,
      WM_TCARD = 82,
      WM_HELP = 83,
      WM_USERCHANGED = 84,
      WM_NOTIFYFORMAT = 85,
      WM_CONTEXTMENU = 123,
      WM_STYLECHANGING = 124,
      WM_STYLECHANGED = 125,
      WM_DISPLAYCHANGE = 126,
      WM_GETICON = 127,
      WM_SETICON = 128,
      WM_NCCREATE = 129,
      WM_NCDESTROY = 130,
      WM_NCCALCSIZE = 131,
      WM_NCHITTEST = 132,
      WM_NCPAINT = 133,
      WM_NCACTIVATE = 134,
      WM_GETDLGCODE = 135,
      WM_SYNCPAINT = 136,
      WM_NCMOUSEMOVE = 160,
      WM_NCLBUTTONDOWN = 161,
      WM_NCLBUTTONUP = 162,
      WM_NCLBUTTONDBLCLK = 163,
      WM_NCRBUTTONDOWN = 164,
      WM_NCRBUTTONUP = 165,
      WM_NCRBUTTONDBLCLK = 166,
      WM_NCMBUTTONDOWN = 167,
      WM_NCMBUTTONUP = 168,
      WM_NCMBUTTONDBLCLK = 169,
      WM_KEYDOWN = 256,
      WM_KEYUP = 257,
      WM_CHAR = 258,
      WM_DEADCHAR = 259,
      WM_SYSKEYDOWN = 260,
      WM_SYSKEYUP = 261,
      WM_SYSCHAR = 262,
      WM_SYSDEADCHAR = 263,
      WM_KEYLAST = 264,
      WM_IME_STARTCOMPOSITION = 269,
      WM_IME_ENDCOMPOSITION = 270,
      WM_IME_COMPOSITION = 271,
      WM_IME_KEYLAST = 271,
      WM_INITDIALOG = 272,
      WM_COMMAND = 273,
      WM_SYSCOMMAND = 274,
      WM_TIMER = 275,
      WM_HSCROLL = 276,
      WM_VSCROLL = 277,
      WM_INITMENU = 278,
      WM_INITMENUPOPUP = 279,
      WM_MENUSELECT = 287,
      WM_MENUCHAR = 288,
      WM_ENTERIDLE = 289,
      WM_MENURBUTTONUP = 290,
      WM_MENUDRAG = 291,
      WM_MENUGETOBJECT = 292,
      WM_UNINITMENUPOPUP = 293,
      WM_MENUCOMMAND = 294,
      WM_CTLCOLORMSGBOX = 306,
      WM_CTLCOLOREDIT = 307,
      WM_CTLCOLORLISTBOX = 308,
      WM_CTLCOLORBTN = 309,
      WM_CTLCOLORDLG = 310,
      WM_CTLCOLORSCROLLBAR = 311,
      WM_CTLCOLORSTATIC = 312,
      WM_MOUSEMOVE = 512,
      WM_LBUTTONDOWN = 513,
      WM_LBUTTONUP = 514,
      WM_LBUTTONDBLCLK = 515,
      WM_RBUTTONDOWN = 516,
      WM_RBUTTONUP = 517,
      WM_RBUTTONDBLCLK = 518,
      WM_MBUTTONDOWN = 519,
      WM_MBUTTONUP = 520,
      WM_MBUTTONDBLCLK = 521,
      WM_MOUSEWHEEL = 522,
      WM_PARENTNOTIFY = 528,
      WM_ENTERMENULOOP = 529,
      WM_EXITMENULOOP = 530,
      WM_NEXTMENU = 531,
      WM_SIZING = 532,
      WM_CAPTURECHANGED = 533,
      WM_MOVING = 534,
      WM_DEVICECHANGE = 537,
      WM_MDICREATE = 544,
      WM_MDIDESTROY = 545,
      WM_MDIACTIVATE = 546,
      WM_MDIRESTORE = 547,
      WM_MDINEXT = 548,
      WM_MDIMAXIMIZE = 549,
      WM_MDITILE = 550,
      WM_MDICASCADE = 551,
      WM_MDIICONARRANGE = 552,
      WM_MDIGETACTIVE = 553,
      WM_MDISETMENU = 560,
      WM_ENTERSIZEMOVE = 561,
      WM_EXITSIZEMOVE = 562,
      WM_DROPFILES = 563,
      WM_MDIREFRESHMENU = 564,
      WM_IME_SETCONTEXT = 641,
      WM_IME_NOTIFY = 642,
      WM_IME_CONTROL = 643,
      WM_IME_COMPOSITIONFULL = 644,
      WM_IME_SELECT = 645,
      WM_IME_CHAR = 646,
      WM_IME_REQUEST = 648,
      WM_IME_KEYDOWN = 656,
      WM_IME_KEYUP = 657,
      WM_MOUSEHOVER = 673,
      WM_MOUSELEAVE = 675,
      WM_CUT = 768,
      WM_COPY = 769,
      WM_PASTE = 770,
      WM_CLEAR = 771,
      WM_UNDO = 772,
      WM_RENDERFORMAT = 773,
      WM_RENDERALLFORMATS = 774,
      WM_DESTROYCLIPBOARD = 775,
      WM_DRAWCLIPBOARD = 776,
      WM_PAINTCLIPBOARD = 777,
      WM_VSCROLLCLIPBOARD = 778,
      WM_SIZECLIPBOARD = 779,
      WM_ASKCBFORMATNAME = 780,
      WM_CHANGECBCHAIN = 781,
      WM_HSCROLLCLIPBOARD = 782,
      WM_QUERYNEWPALETTE = 783,
      WM_PALETTEISCHANGING = 784,
      WM_PALETTECHANGED = 785,
      WM_HOTKEY = 786,
      WM_PRINT = 791,
      WM_PRINTCLIENT = 792,
      WM_HANDHELDFIRST = 856,
      WM_HANDHELDLAST = 863,
      WM_AFXFIRST = 864,
      WM_AFXLAST = 895,
      WM_PENWINFIRST = 896,
      WM_PENWINLAST = 911,
      WM_USER = 1024,
      WM_REFLECT = 8192,
      WM_APP = 32768,
    }

    public enum WindowStyles : uint
    {
      WS_OVERLAPPED = 0,
      WS_TILED = 0,
      WS_EX_DLGMODALFRAME = 1,
      WS_EX_NOPARENTNOTIFY = 4,
      WS_EX_TOPMOST = 8,
      WS_EX_ACCEPTFILES = 16,
      WS_EX_TRANSPARENT = 32,
      WS_EX_TOOLWINDOW = 128,
      WS_MAXIMIZEBOX = 65536,
      WS_TABSTOP = 65536,
      WS_GROUP = 131072,
      WS_MINIMIZEBOX = 131072,
      WS_EX_APPWINDOW = 262144,
      WS_SIZEBOX = 262144,
      WS_THICKFRAME = 262144,
      WS_SYSMENU = 524288,
      WS_HSCROLL = 1048576,
      WS_VSCROLL = 2097152,
      WS_DLGFRAME = 4194304,
      WS_BORDER = 8388608,
      WS_CAPTION = 12582912,
      WS_OVERLAPPEDWINDOW = 13565952,
      WS_MAXIMIZE = 16777216,
      WS_CLIPCHILDREN = 33554432,
      WS_CLIPSIBLINGS = 67108864,
      WS_DISABLED = 134217728,
      WS_VISIBLE = 268435456,
      WS_ICONIC = 536870912,
      WS_MINIMIZE = 536870912,
      WS_CHILD = 1073741824,
      WS_CHILDWINDOW = 1073741824,
      WS_POPUP = 2147483648,
      WS_POPUPWINDOW = 2156396544,
    }

    public struct WindowInfo
    {
      public int size;
      public Rectangle window;
      public Rectangle client;
      public int style;
      public int exStyle;
      public int windowStatus;
      public uint xWindowBorders;
      public uint yWindowBorders;
      public short atomWindowtype;
      public short creatorVersion;
    }

    public struct WindowPlacement
    {
      public int length;
      public int flags;
      public int showCmd;
      public System.Drawing.Point minPosition;
      public System.Drawing.Point maxPosition;
      public Rectangle normalPosition;
    }

    public struct Rect
    {
      public int left;
      public int top;
      public int right;
      public int bottom;

      public int Width
      {
        get
        {
          int num1 = this.right - this.left;
label_1:
          int num2 = -400293447;
          while (true)
          {
            int num3 = -1221967151;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_1;
              case 1:
                num2 = (int) num4 * 659187660 ^ 829181895;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return num1;
        }
      }

      public int Height
      {
        get
        {
label_1:
          int num1 = -411606660;
          int num2;
          while (true)
          {
            int num3 = -1612796784;
            uint num4;
            switch ((num4 = (uint) (num1 ^ num3)) % 3U)
            {
              case 0:
                goto label_1;
              case 1:
                num2 = this.bottom - this.top;
                num1 = (int) num4 * 1326310260 ^ 1616137503;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return num2;
        }
      }
    }

    public delegate bool EnumWindowEventHandler(IntPtr hWnd, int lParam);

    public enum BinaryRasterOperations
    {
      R2_BLACK = 1,
      R2_NOTMERGEPEN = 2,
      R2_MASKNOTPEN = 3,
      R2_NOTCOPYPEN = 4,
      R2_MASKPENNOT = 5,
      R2_NOT = 6,
      R2_XORPEN = 7,
      R2_NOTMASKPEN = 8,
      R2_MASKPEN = 9,
      R2_NOTXORPEN = 10,
      R2_NOP = 11,
      R2_MERGENOTPEN = 12,
      R2_COPYPEN = 13,
      R2_MERGEPENNOT = 14,
      R2_MERGEPEN = 15,
      R2_LAST = 16,
      R2_WHITE = 16,
    }

    public enum TernaryRasterOperations
    {
      BLACKNESS = 66,
      NOTSRCERASE = 1114278,
      NOTSRCCOPY = 3342344,
      SRCERASE = 4457256,
      DSTINVERT = 5570569,
      PATINVERT = 5898313,
      SRCINVERT = 6684742,
      SRCAND = 8913094,
      MERGEPAINT = 12255782,
      MERGECOPY = 12583114,
      SRCCOPY = 13369376,
      SRCPAINT = 15597702,
      PATCOPY = 15728673,
      PATPAINT = 16452105,
      WHITENESS = 16711778,
    }

    [Flags]
    public enum HotkeyModifiers
    {
      MOD_ALT = 1,
      MOD_CONTROL = 2,
      MOD_SHIFT = 4,
      MOD_WIN = 8,
    }
  }
}
