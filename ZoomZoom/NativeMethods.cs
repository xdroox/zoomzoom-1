// Decompiled with JetBrains decompiler
// Type: ZoomZoom.NativeMethods
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ZoomZoom
{
  public static class NativeMethods
  {
    public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
    public const int GWL_HWNDPARENT = -8;
    public const int GWL_ID = -12;
    public const int GWL_STYLE = -16;
    public const int GWL_EXSTYLE = -20;
    public const uint WS_OVERLAPPED = 0;
    public const uint WS_POPUP = 2147483648;
    public const uint WS_CHILD = 1073741824;
    public const uint WS_MINIMIZE = 536870912;
    public const uint WS_VISIBLE = 268435456;
    public const uint WS_DISABLED = 134217728;
    public const uint WS_CLIPSIBLINGS = 67108864;
    public const uint WS_CLIPCHILDREN = 33554432;
    public const uint WS_MAXIMIZE = 16777216;
    public const uint WS_CAPTION = 12582912;
    public const uint WS_BORDER = 8388608;
    public const uint WS_DLGFRAME = 4194304;
    public const uint WS_VSCROLL = 2097152;
    public const uint WS_HSCROLL = 1048576;
    public const uint WS_SYSMENU = 524288;
    public const uint WS_THICKFRAME = 262144;
    public const uint WS_GROUP = 131072;
    public const uint WS_TABSTOP = 65536;
    public const uint WS_MINIMIZEBOX = 131072;
    public const uint WS_MAXIMIZEBOX = 65536;
    public const uint WS_TILED = 0;
    public const uint WS_ICONIC = 536870912;
    public const uint WS_SIZEBOX = 262144;
    public const uint WS_EX_DLGMODALFRAME = 1;
    public const uint WS_EX_NOPARENTNOTIFY = 4;
    public const uint WS_EX_TOPMOST = 8;
    public const uint WS_EX_ACCEPTFILES = 16;
    public const uint WS_EX_TRANSPARENT = 32;
    public const uint WS_EX_MDICHILD = 64;
    public const uint WS_EX_TOOLWINDOW = 128;
    public const uint WS_EX_WINDOWEDGE = 256;
    public const uint WS_EX_CLIENTEDGE = 512;
    public const uint WS_EX_CONTEXTHELP = 1024;
    public const uint WS_EX_RIGHT = 4096;
    public const uint WS_EX_LEFT = 0;
    public const uint WS_EX_RTLREADING = 8192;
    public const uint WS_EX_LTRREADING = 0;
    public const uint WS_EX_LEFTSCROLLBAR = 16384;
    public const uint WS_EX_RIGHTSCROLLBAR = 0;
    public const uint WS_EX_CONTROLPARENT = 65536;
    public const uint WS_EX_STATICEDGE = 131072;
    public const uint WS_EX_APPWINDOW = 262144;
    public const uint WS_EX_OVERLAPPEDWINDOW = 768;
    public const uint WS_EX_PALETTEWINDOW = 392;
    public const uint WS_EX_LAYERED = 524288;
    public const uint WS_EX_NOINHERITLAYOUT = 1048576;
    public const uint WS_EX_LAYOUTRTL = 4194304;
    public const uint WS_EX_COMPOSITED = 33554432;
    public const int SM_CXSCREEN = 0;
    public const int SM_CYSCREEN = 1;
    public const int WM_SYSCOMMAND = 274;
    public const int SC_CLOSE = 61536;
    public const uint SW_HIDE = 0;
    public const uint SW_SHOWNORMAL = 1;
    public const uint SW_NORMAL = 1;
    public const uint SW_SHOWMINIMIZED = 2;
    public const uint SW_SHOWMAXIMIZED = 3;
    public const uint SW_MAXIMIZE = 3;
    public const uint SW_SHOWNOACTIVATE = 4;
    public const uint SW_SHOW = 5;
    public const uint SW_MINIMIZE = 6;
    public const uint SW_SHOWMINNOACTIVE = 7;
    public const uint SW_SHOWNA = 8;
    public const uint SW_RESTORE = 9;
    public const int WM_USER = 1024;
    public const uint SWP_NOSIZE = 1;
    public const uint SWP_NOMOVE = 2;
    public const uint SWP_NOACTIVATE = 16;

    [DllImport("user32.dll", SetLastError = true)]
    public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll")]
    internal static extern bool IntersectRect(out NativeMethods.RECT lprcDst, ref NativeMethods.RECT lprcSrc1, ref NativeMethods.RECT lprcSrc2);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetWindowPlacement(IntPtr hWnd, ref NativeMethods.WINDOWPLACEMENT lpwndpl);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPlacement(IntPtr hWnd, [In] ref NativeMethods.WINDOWPLACEMENT lpwndpl);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, [Out] StringBuilder lParam);

    [DllImport("user32.dll")]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

    public static int MAKELPARAM(int p, int p_2)
    {
      int num1 = p_2 << 16 | p & (int) ushort.MaxValue;
label_1:
      int num2 = -881698881;
      while (true)
      {
        int num3 = -1578971659;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 3U)
        {
          case 1:
            num2 = (int) num4 * -1982974352 ^ 343388356;
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

    public static void PostMessageSafe(IntPtr hWnd, uint msg, int wParam, int lParam)
    {
      bool flag1 = NativeMethods.PostMessage(hWnd, msg, wParam, lParam);
label_1:
      int num1 = 974556588;
      while (true)
      {
        int num2 = 1825122585;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -204385215 ^ 504644829;
            continue;
          case 2:
            int num4 = !flag2 ? 833172201 : (num4 = 431180550);
            int num5 = (int) num3 * 528954411;
            num1 = num4 ^ num5;
            continue;
          case 3:
            flag2 = !flag1;
            num1 = (int) num3 * -977404288 ^ 1035767251;
            continue;
          case 4:
            goto label_3;
          case 5:
            goto label_6;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:
      return;
label_6:
      throw NativeMethods.\u200B‎‮⁪‭‏⁭⁮‌‎‍⁭‮​⁮‏​‭‎‭⁯‎‎⁫‪⁯‫⁯‍‭⁬‪‭‮‏⁭‍‪⁬⁪‮(NativeMethods.\u206B⁬​‌​⁬​​‫‎‍‮‫‎‎‪⁪⁭⁮⁯‭⁬⁯⁯‌⁬⁯⁭⁯⁪‏⁯‬‬‌‏⁫‫‮‭‮());
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr GetFocus();

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern IntPtr SetFocus(IntPtr hwnd);

    [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool DestroyWindow(IntPtr hwnd);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool EnumWindows(NativeMethods.EnumWindowsProc callback, IntPtr extraData);

    [DllImport("user32")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EnumChildWindows(IntPtr window, NativeMethods.EnumWindowProc callback, IntPtr i);

    [DllImport("coredll.dll", SetLastError = true)]
    public static extern int GetLastError();

    [DllImport("user32.dll")]
    public static extern bool SetCursorPos(int X, int Y);

    [DllImport("user32.dll")]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool GetWindowRect(IntPtr hwnd, out NativeMethods.RECT lpRect);

    [DllImport("USER32.DLL")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("kernel32.dll")]
    public static extern uint GetCurrentThreadId();

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

    [DllImport("user32.dll")]
    public static extern int GetSystemMetrics(int smIndex);

    [DllImport("user32.dll")]
    public static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);

    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(out System.Drawing.Point pt);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern int GetWindowTextLength(IntPtr hWnd);

    [DllImport("User32.dll")]
    public static extern int SendMessage(IntPtr hwnd, NativeMethods.WMConstants wmConstant, IntPtr wParam, IntPtr lParam);

    [DllImport("User32.dll")]
    public static extern int SendMessage(IntPtr hwnd, NativeMethods.WMConstants wmConstant, int wParam, StringBuilder sb);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr GetWindow(IntPtr hWnd, NativeMethods.GetWindow_Cmd uCmd);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool BringWindowToTop(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool BringWindowToTop(HandleRef hWnd);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EnumThreadWindows(uint threadId, NativeMethods.EnumThreadWindowsProc callback, int param);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsWindowVisible(IntPtr handle);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr GetShellWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
    internal static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDC(IntPtr hwnd);

    [DllImport("user32.dll")]
    public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

    [DllImport("gdi32.dll")]
    public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

    public static Color GetPixelColor(int x, int y)
    {
      IntPtr dc = NativeMethods.GetDC(IntPtr.Zero);
label_1:
      int num1 = -336381068;
      Color color;
      while (true)
      {
        int num2 = -2109913704;
        uint num3;
        uint pixel;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            color = Color.FromArgb((int) pixel & (int) byte.MaxValue, ((int) pixel & 65280) >> 8, ((int) pixel & 16711680) >> 16);
            num1 = (int) num3 * -564121590 ^ -1270095190;
            continue;
          case 2:
            num1 = (int) num3 * 926773553 ^ -971333839;
            continue;
          case 4:
            pixel = NativeMethods.GetPixel(dc, x, y);
            num1 = (int) num3 * -1009402820 ^ 1889539793;
            continue;
          case 5:
            NativeMethods.ReleaseDC(IntPtr.Zero, dc);
            num1 = (int) num3 * 1265916607 ^ -624871268;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return color;
    }

    [DllImport("User32.dll")]
    public static extern long WindowFromPoint(long x, long y);

    [DllImport("User32.dll")]
    public static extern long GetCursorPos(ref NativeMethods.POINTAPI p);

    [DllImport("User32.dll")]
    public static extern long GetWindowTextA(long hwnd, ref string lpString, long cch);

    [DllImport("User32.dll")]
    public static extern long GetParent(long hwnd);

    [DllImport("User32.dll")]
    public static extern long ChildWindowFromPoint(long hWndParent, long x, long y);

    [DllImport("User32.dll")]
    public static extern long GetclassNameA(long hwnd, string lpClassName, long nMaxCount);

    [DllImport("user32.dll")]
    public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern bool IsIconic(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern bool IsZoomed(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

    [DllImport("user32.dll")]
    public static extern IntPtr AttachThreadInput(IntPtr idAttach, IntPtr idAttachTo, int fAttach);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetTitleBarInfo(IntPtr hwnd, ref NativeMethods.TITLEBARINFO pti);

    [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
    public static extern int SetWindowLong32(HandleRef hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
    public static extern int SetWindowLong32(IntPtr windowHandle, NativeMethods.GWLParameter nIndex, int dwNewLong);

    [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
    public static extern IntPtr SetWindowLongPtr64(IntPtr windowHandle, NativeMethods.GWLParameter nIndex, IntPtr dwNewLong);

    [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
    public static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UnhookWinEvent(IntPtr eventHookHandle);

    [DllImport("user32.dll")]
    public static extern IntPtr SetWinEventHook(AccessibleEvents eventMin, AccessibleEvents eventMax, IntPtr eventHookAssemblyHandle, NativeMethods.WinEventProc eventHookHandle, uint processId, uint threadId, NativeMethods.SetWinEventHookParameter parameterFlags);

    public static bool enumWindow(IntPtr handle, IntPtr pointer)
    {
      GCHandle gcHandle = GCHandle.FromIntPtr(pointer);
label_1:
      int num1 = -1380835685;
      bool flag1;
      while (true)
      {
        int num2 = -1275954340;
        uint num3;
        List<IntPtr> target;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            int num4 = !flag2 ? -1621740758 : (num4 = -1147514849);
            int num5 = (int) num3 * -50240730;
            num1 = num4 ^ num5;
            continue;
          case 1:
            target = gcHandle.Target as List<IntPtr>;
            flag2 = target == null;
            num1 = (int) num3 * -165483394 ^ 1841181299;
            continue;
          case 2:
            goto label_1;
          case 4:
            goto label_9;
          case 5:
            num1 = (int) num3 * 110725964 ^ -2004307782;
            continue;
          case 6:
            target.Add(handle);
            num1 = -994671931;
            continue;
          case 7:
            flag1 = true;
            num1 = (int) num3 * -1433742692 ^ -1882275048;
            continue;
          case 8:
            num1 = (int) num3 * 1816902479 ^ 1901598723;
            continue;
          default:
            goto label_10;
        }
      }
label_9:
      throw new InvalidCastException(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2754598608U));
label_10:
      return flag1;
    }

    [DllImport("User32.dll")]
    private static extern IntPtr WindowFromPoint(NativeMethods.POINT p);

    [DllImport("User32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetCursorPos(ref NativeMethods.POINT p);

    [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern long GetWindowText(IntPtr hwnd, StringBuilder lpString, long cch);

    [DllImport("User32.dll")]
    private static extern IntPtr GetParent(IntPtr hwnd);

    [DllImport("User32.dll")]
    private static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, NativeMethods.POINT p);

    [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern long GetClassName(IntPtr hwnd, StringBuilder lpClassName, long nMaxCount);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool GetWindowInfo(IntPtr hwnd, out NativeMethods.WINDOWINFO pwi);

    static int \u206B⁬​‌​⁬​​‫‎‍‮‫‎‎‪⁪⁭⁮⁯‭⁬⁯⁯‌⁬⁯⁭⁯⁪‏⁯‬‬‌‏⁫‫‮‭‮()
    {
      return Marshal.GetLastWin32Error();
    }

    static Win32Exception \u200B‎‮⁪‭‏⁭⁮‌‎‍⁭‮​⁮‏​‭‎‭⁯‎‎⁫‪⁯‫⁯‍‭⁬‪‭‮‏⁭‍‪⁬⁪‮([In] int obj0)
    {
      return new Win32Exception(obj0);
    }

    public enum WMessages
    {
      WH_KEYBOARD_LL = 13,
      WH_MOUSE_LL = 14,
      WM_KEYDOWN = 256,
      WM_KEYUP = 257,
      WM_CHAR = 258,
      WM_LBUTTONDOWN = 513,
      WM_LBUTTONUP = 514,
    }

    public struct WINDOWPLACEMENT
    {
      public int length;
      public int flags;
      public int showCmd;
      public System.Drawing.Point ptMinPosition;
      public System.Drawing.Point ptMaxPosition;
      public Rectangle rcNormalPosition;
    }

    public struct POINTAPI
    {
      public long x;
      public long y;
    }

    public delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

    public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool EnumThreadWindowsProc(IntPtr handle, int param);

    public struct RECT
    {
      public int left;
      public int top;
      public int right;
      public int bottom;
    }

    public struct ChromeRECT
    {
      public int X;
      public int Y;
      public int Height;
      public int Width;
    }

    public enum GetWindow_Cmd : uint
    {
      GW_HWNDFIRST,
      GW_HWNDLAST,
      GW_HWNDNEXT,
      GW_HWNDPREV,
      GW_OWNER,
      GW_CHILD,
      GW_ENABLEDPOPUP,
    }

    public enum WMConstants
    {
      WM_GETTEXT = 13,
      WM_GETTEXTLENGTH = 14,
      WM_CLOSE = 16,
      WM_SYSCOMMAND = 274,
    }

    public struct WINDOWINFO
    {
      public uint cbSize;
      public NativeMethods.RECT rcWindow;
      public NativeMethods.RECT rcClient;
      public uint dwStyle;
      public uint dwExStyle;
      public uint dwWindowStatus;
      public uint cxWindowBorders;
      public uint cyWindowBorders;
      public ushort atomWindowType;
      public ushort wCreatorVersion;

      public WINDOWINFO(bool? filler)
      {
        this = new NativeMethods.WINDOWINFO();
        // ISSUE: type reference
        this.cbSize = (uint) NativeMethods.WINDOWINFO.\u206D‮​‫‭⁯‪‫⁬‮⁭‏​⁯‫⁯‫‫⁭⁮‪‏‪‎⁭⁮‮⁯‍‬⁮‪‎⁫‪⁯⁯‭‭⁫‮(NativeMethods.WINDOWINFO.\u200B‪⁪‌⁪‎⁫‮‌‪‍‏⁪⁫⁯​⁫​⁮‏⁪⁬‮‍‍⁫‭‬‎⁪⁫⁬‎‏⁭⁮‌⁪‍‏‮(__typeref (NativeMethods.WINDOWINFO)));
      }

      static System.Type \u200B‪⁪‌⁪‎⁫‮‌‪‍‏⁪⁫⁯​⁫​⁮‏⁪⁬‮‍‍⁫‭‬‎⁪⁫⁬‎‏⁭⁮‌⁪‍‏‮([In] RuntimeTypeHandle obj0)
      {
        return System.Type.GetTypeFromHandle(obj0);
      }

      static int \u206D‮​‫‭⁯‪‫⁬‮⁭‏​⁯‫⁯‫‫⁭⁮‪‏‪‎⁭⁮‮⁯‍‬⁮‪‎⁫‪⁯⁯‭‭⁫‮([In] System.Type obj0)
      {
        return Marshal.SizeOf(obj0);
      }
    }

    public struct TITLEBARINFO
    {
      public const int CCHILDREN_TITLEBAR = 5;
      public uint cbSize;
      public NativeMethods.RECT rcTitleBar;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public AccessibleStates[] rgstate;
    }

    public enum GWLParameter
    {
      GWL_USERDATA = -21,
      GWL_EXSTYLE = -20,
      GWL_STYLE = -16,
      GWL_ID = -12,
      GWL_HWNDPARENT = -8,
      GWL_HINSTANCE = -6,
      GWL_WNDPROC = -4,
    }

    public delegate void WinEventProc(IntPtr winEventHookHandle, AccessibleEvents accEvent, IntPtr windowHandle, int objectId, int childId, uint eventThreadId, uint eventTimeInMilliseconds);

    [Flags]
    public enum SetWinEventHookParameter
    {
      WINEVENT_INCONTEXT = 4,
      WINEVENT_OUTOFCONTEXT = 0,
      WINEVENT_SKIPOWNPROCESS = 2,
      WINEVENT_SKIPOWNTHREAD = 1,
    }

    public struct POINT
    {
      public int X;
      public int Y;

      public POINT(int x, int y)
      {
        this.X = x;
        this.Y = y;
      }

      public POINT(System.Drawing.Point pt)
      {
        this = new NativeMethods.POINT(pt.X, pt.Y);
      }

      public static implicit operator System.Drawing.Point(NativeMethods.POINT p)
      {
        return new System.Drawing.Point(p.X, p.Y);
      }

      public static implicit operator NativeMethods.POINT(System.Drawing.Point p)
      {
label_1:
        int num1 = 1487317611;
        NativeMethods.POINT point;
        while (true)
        {
          int num2 = 318437776;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 83157206 ^ -1134741895;
              continue;
            case 3:
              point = new NativeMethods.POINT(p.X, p.Y);
              num1 = (int) num3 * -2091669004 ^ 458592646;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return point;
      }
    }
  }
}
