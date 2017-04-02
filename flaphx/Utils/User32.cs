// Decompiled with JetBrains decompiler
// Type: flaphx.utils.User32
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace flaphx.utils
{
  public class User32
  {
    private const uint MIM_MAXHEIGHT = 1;
    private const uint MIM_BACKGROUND = 2;
    private const uint MIM_HELPID = 4;
    private const uint MIM_MENUDATA = 8;
    private const uint MIM_STYLE = 16;
    private const uint MIM_APPLYTOSUBMENUS = 2147483648;

    [DllImport("user32.dll")]
    public static extern bool GetClientRect(IntPtr hWnd, out Win32Rect rect);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDC(IntPtr hwnd);

    [DllImport("user32.dll")]
    public static extern uint SendMessage(IntPtr hWnd, uint msg, uint wParam, uint lParam);

    [DllImport("user32.dll")]
    public static extern uint SendMessage(IntPtr hWnd, uint msg, uint wParam, StringBuilder lParam);

    [DllImport("user32.dll")]
    public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, object lParam);

    [DllImport("user32.dll")]
    public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

    [DllImport("User32.dll")]
    public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("User32.dll")]
    public static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

    [DllImport("User32.dll")]
    public static extern bool MessageBeep(MB BeepType);

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("User32.dll")]
    public static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string strclassName, string strWindowName);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

    [DllImport("User32.dll")]
    public static extern IntPtr GetWindow(IntPtr hWnd, GW uCmd);

    [DllImport("User32.dll")]
    public static extern int GetWindowTextLength(IntPtr hWnd);

    [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetWindowText(IntPtr hWnd, out StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll")]
    public static extern uint GetClassLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll")]
    public static extern uint SetClassLong(IntPtr hWnd, int nIndex, uint dwNewLong);

    [DllImport("user32.dll")]
    public static extern bool GetWindowRect(IntPtr hWnd, out User32.RECT lprect);

    [DllImport("user32.dll")]
    public static extern bool GetWindowRect(IntPtr hWnd, out Win32Rect lprect);

    [DllImport("User32.dll", CharSet = CharSet.Auto)]
    public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

    [DllImport("user32")]
    public static extern IntPtr LoadMenu(IntPtr hInstance, int id);

    [DllImport("user32")]
    public static extern bool IsMenu(IntPtr hMenu);

    [DllImport("user32")]
    public static extern IntPtr GetMenu(IntPtr hwnd);

    [DllImport("user32")]
    public static extern uint GetMenuItemCount(IntPtr hMenu);

    [DllImport("user32")]
    public static extern uint GetMenuItemID(IntPtr hMenu, uint nPos);

    [DllImport("user32.dll")]
    public static extern bool GetMenuItemInfo(IntPtr hMenu, uint uItem, bool fByPosition, ref User32.MENUITEMINFO lpmii);

    [DllImport("user32")]
    public static extern uint GetMenuString(IntPtr hMenu, uint uIDItem, StringBuilder lpString, int nMaxCount, uint uFlag);

    [DllImport("user32")]
    public static extern IntPtr GetSubMenu(IntPtr hInstance, int id);

    [DllImport("user32")]
    public static extern int TrackPopupMenu(IntPtr hMenu, uint uFlags, int x, int y, int nReserved, IntPtr hWnd, IntPtr prcRect);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern IntPtr WindowFromPoint(POINT lpPoint);

    [DllImport("user32.dll")]
    public static extern IntPtr WindowFromPoint(Win32Point pt);

    [DllImport("user32.dll")]
    public static extern IntPtr ChildWindowFromPointEx(IntPtr hWndParent, POINT pt, uint uFlags);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern uint MessageBox(IntPtr hWnd, string text, string caption, uint options);

    [DllImport("user32.dll")]
    public static extern void mouse_event(MouseEventFlags dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

    [DllImport("user32.dll")]
    public static extern bool SetCursorPos(int X, int Y);

    [DllImport("user32.dll")]
    public static extern bool CloseWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    private static extern bool IsIconic(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern IntPtr GetLastActivePopup(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr GetParent(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr GetAncestor(IntPtr hWnd, uint gaFlags);

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

    [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
    private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
    private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

    public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
    {
label_1:
      int num1 = 1111494430;
      IntPtr num2;
      while (true)
      {
        int num3 = 1420793340;
        uint num4;
        bool flag;
        switch ((num4 = (uint) (num1 ^ num3)) % 7U)
        {
          case 0:
            num2 = User32.GetWindowLongPtr64(hWnd, nIndex);
            num1 = (int) num4 * 591864681 ^ 661002832;
            continue;
          case 1:
            int num5 = !flag ? 1537141205 : (num5 = 1192695907);
            int num6 = (int) num4 * -1922782277;
            num1 = num5 ^ num6;
            continue;
          case 3:
            goto label_1;
          case 4:
            num2 = User32.GetWindowLongPtr32(hWnd, nIndex);
            num1 = 667287847;
            continue;
          case 5:
            flag = IntPtr.Size == 8;
            num1 = (int) num4 * -1558690790 ^ 1051768970;
            continue;
          case 6:
            num1 = (int) num4 * 1218982410 ^ 2014962245;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return num2;
    }

    [DllImport("user32.dll")]
    public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

    [DllImport("user32.dll")]
    public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

    internal static bool GetWindowRect(IntPtr handle, out object rectangle)
    {
      throw User32.\u200D⁭⁪⁯‌‭⁯‭⁫‭⁪​⁭‮‪‎‪⁯‮⁯⁮‏‫‏‍‍‭‏⁯⁮‎‮‎‫‍‫‬⁬⁪‮();
    }

    [DllImport("user32.dll")]
    public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

    static NotImplementedException \u200D⁭⁪⁯‌‭⁯‭⁫‭⁪​⁭‮‪‎‪⁯‮⁯⁮‏‫‏‍‍‭‏⁯⁮‎‮‎‫‍‫‬⁬⁪‮()
    {
      return new NotImplementedException();
    }

    public struct RECT
    {
      public int X;
      public int Y;
      public int Right;
      public int Bottom;

      public int Width
      {
        get
        {
label_1:
          int num1 = 308728535;
          int num2;
          while (true)
          {
            int num3 = 103400989;
            uint num4;
            switch ((num4 = (uint) (num1 ^ num3)) % 4U)
            {
              case 0:
                goto label_1;
              case 2:
                num2 = this.Right - this.X;
                num1 = (int) num4 * 406413025 ^ 651355580;
                continue;
              case 3:
                num1 = (int) num4 * -673536750 ^ -1180826650;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          return num2;
        }
      }

      public int Height
      {
        get
        {
          return this.Bottom - this.Y;
        }
      }
    }

    public struct MENUITEMINFO
    {
      public uint cbSize;
      public uint fMask;
      public uint fType;
      public uint fState;
      public int wID;
      public int hSubMenu;
      public int hbmpChecked;
      public int hbmpUnchecked;
      public int dwItemData;
      public string dwTypeData;
      public uint cch;
      public int hbmpItem;
    }

    [Flags]
    public enum WindowStyleFlags : uint
    {
      WS_OVERLAPPED = 0,
      WS_POPUP = 2147483648,
      WS_CHILD = 1073741824,
      WS_MINIMIZE = 536870912,
      WS_VISIBLE = 268435456,
      WS_DISABLED = 134217728,
      WS_CLIPSIBLINGS = 67108864,
      WS_CLIPCHILDREN = 33554432,
      WS_MAXIMIZE = 16777216,
      WS_BORDER = 8388608,
      WS_DLGFRAME = 4194304,
      WS_VSCROLL = 2097152,
      WS_HSCROLL = 1048576,
      WS_SYSMENU = 524288,
      WS_THICKFRAME = 262144,
      WS_GROUP = 131072,
      WS_TABSTOP = 65536,
      WS_MINIMIZEBOX = WS_GROUP,
      WS_MAXIMIZEBOX = WS_TABSTOP,
    }

    [Flags]
    public enum ExtendedWindowStyleFlags
    {
      WS_EX_DLGMODALFRAME = 1,
      WS_EX_NOPARENTNOTIFY = 4,
      WS_EX_TOPMOST = 8,
      WS_EX_ACCEPTFILES = 16,
      WS_EX_TRANSPARENT = 32,
      WS_EX_MDICHILD = 64,
      WS_EX_TOOLWINDOW = 128,
      WS_EX_WINDOWEDGE = 256,
      WS_EX_CLIENTEDGE = 512,
      WS_EX_CONTEXTHELP = 1024,
      WS_EX_RIGHT = 4096,
      WS_EX_LEFT = 0,
      WS_EX_RTLREADING = 8192,
      WS_EX_LTRREADING = 0,
      WS_EX_LEFTSCROLLBAR = 16384,
      WS_EX_RIGHTSCROLLBAR = 0,
      WS_EX_CONTROLPARENT = 65536,
      WS_EX_STATICEDGE = 131072,
      WS_EX_APPWINDOW = 262144,
      WS_EX_LAYERED = 524288,
      WS_EX_NOINHERITLAYOUT = 1048576,
      WS_EX_LAYOUTRTL = 4194304,
      WS_EX_COMPOSITED = 33554432,
      WS_EX_NOACTIVATE = 134217728,
    }

    public enum GWL
    {
      GWL_USERDATA = -21,
      GWL_EXSTYLE = -20,
      GWL_STYLE = -16,
      GWL_ID = -12,
      GWL_HWNDPARENT = -8,
      GWL_HINSTANCE = -6,
      GWL_WNDPROC = -4,
    }
  }
}
