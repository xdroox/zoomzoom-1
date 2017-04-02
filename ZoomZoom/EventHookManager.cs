// Decompiled with JetBrains decompiler
// Type: ZoomZoom.EventHookManager
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Events;
using ZoomZoom.Views;

namespace ZoomZoom
{
  public class EventHookManager : ManagerBase
  {
    private static EventHookManager instance = (EventHookManager) null;
    private IntPtr hookHandle = IntPtr.Zero;
    private volatile bool isLeftMouseButtonDown = false;
    private volatile bool isCtrlPressed = false;
    private volatile bool isAltPressed = false;
    private volatile bool isAPressed = false;
    private volatile bool isShiftPressed = false;
    private DateTime lastKeyPress = DateTime.MinValue;
    private DateTime lastMouseMovement = DateTime.MinValue;
    private KeyEventData keyData = new KeyEventData();
    private static readonly object hookLocker;
    private static List<int> processIds;
    private static EventHookManager.WinEventDelegate eventHandler;
    private static Dictionary<int, IntPtr> processHooks;
    private static Dictionary<int, IntPtr> processHookExs;
    private static ConcurrentQueue<ZoomEvent> hookQueue;
    private System.Drawing.Point lastClickPoint;
    public const uint WINEVENT_OUTOFCONTEXT = 0;
    public const uint WINEVENT_SKIPOWNTHREAD = 1;
    public const uint WINEVENT_SKIPOWNPROCESS = 2;
    public const uint WINEVENT_INCONTEXT = 4;
    public const uint EVENT_MIN = 1;
    public const uint EVENT_MAX = 2147483647;
    public const uint EVENT_SYSTEM_SOUND = 1;
    public const uint EVENT_SYSTEM_ALERT = 2;
    public const uint EVENT_SYSTEM_FOREGROUND = 3;
    public const uint EVENT_SYSTEM_MENUSTART = 4;
    public const uint EVENT_SYSTEM_MENUEND = 5;
    public const uint EVENT_SYSTEM_MENUPOPUPSTART = 6;
    public const uint EVENT_SYSTEM_MENUPOPUPEND = 7;
    public const uint EVENT_SYSTEM_CAPTURESTART = 8;
    public const uint EVENT_SYSTEM_CAPTUREEND = 9;
    public const uint EVENT_SYSTEM_MOVESIZESTART = 10;
    public const uint EVENT_SYSTEM_MOVESIZEEND = 11;
    public const uint EVENT_SYSTEM_CONTEXTHELPSTART = 12;
    public const uint EVENT_SYSTEM_CONTEXTHELPEND = 13;
    public const uint EVENT_SYSTEM_DRAGDROPSTART = 14;
    public const uint EVENT_SYSTEM_DRAGDROPEND = 15;
    public const uint EVENT_SYSTEM_DIALOGSTART = 16;
    public const uint EVENT_SYSTEM_DIALOGEND = 17;
    public const uint EVENT_SYSTEM_SCROLLINGSTART = 18;
    public const uint EVENT_SYSTEM_SCROLLINGEND = 19;
    public const uint EVENT_SYSTEM_SWITCHSTART = 20;
    public const uint EVENT_SYSTEM_SWITCHEND = 21;
    public const uint EVENT_SYSTEM_MINIMIZESTART = 22;
    public const uint EVENT_SYSTEM_MINIMIZEEND = 23;
    public const uint EVENT_SYSTEM_DESKTOPSWITCH = 32;
    public const uint EVENT_SYSTEM_END = 255;
    public const uint EVENT_OEM_DEFINED_START = 257;
    public const uint EVENT_OEM_DEFINED_END = 511;
    public const uint EVENT_UIA_EVENTID_START = 19968;
    public const uint EVENT_UIA_EVENTID_END = 20223;
    public const uint EVENT_UIA_PROPID_START = 29952;
    public const uint EVENT_UIA_PROPID_END = 30207;
    public const uint EVENT_CONSOLE_CARET = 16385;
    public const uint EVENT_CONSOLE_UPDATE_REGION = 16386;
    public const uint EVENT_CONSOLE_UPDATE_SIMPLE = 16387;
    public const uint EVENT_CONSOLE_UPDATE_SCROLL = 16388;
    public const uint EVENT_CONSOLE_LAYOUT = 16389;
    public const uint EVENT_CONSOLE_START_APPLICATION = 16390;
    public const uint EVENT_CONSOLE_END_APPLICATION = 16391;
    public const uint EVENT_CONSOLE_END = 16639;
    public const uint EVENT_OBJECT_CREATE = 32768;
    public const uint EVENT_OBJECT_DESTROY = 32769;
    public const uint EVENT_OBJECT_SHOW = 32770;
    public const uint EVENT_OBJECT_HIDE = 32771;
    public const uint EVENT_OBJECT_REORDER = 32772;
    public const uint EVENT_OBJECT_FOCUS = 32773;
    public const uint EVENT_OBJECT_SELECTION = 32774;
    public const uint EVENT_OBJECT_SELECTIONADD = 32775;
    public const uint EVENT_OBJECT_SELECTIONREMOVE = 32776;
    public const uint EVENT_OBJECT_SELECTIONWITHIN = 32777;
    public const uint EVENT_OBJECT_STATECHANGE = 32778;
    public const uint EVENT_OBJECT_LOCATIONCHANGE = 32779;
    public const uint EVENT_OBJECT_NAMECHANGE = 32780;
    public const uint EVENT_OBJECT_DESCRIPTIONCHANGE = 32781;
    public const uint EVENT_OBJECT_VALUECHANGE = 32782;
    public const uint EVENT_OBJECT_PARENTCHANGE = 32783;
    public const uint EVENT_OBJECT_HELPCHANGE = 32784;
    public const uint EVENT_OBJECT_DEFACTIONCHANGE = 32785;
    public const uint EVENT_OBJECT_ACCELERATORCHANGE = 32786;
    public const uint EVENT_OBJECT_INVOKED = 32787;
    public const uint EVENT_OBJECT_TEXTSELECTIONCHANGED = 32788;
    public const uint EVENT_OBJECT_CONTENTSCROLLED = 32789;
    public const uint EVENT_SYSTEM_ARRANGMENTPREVIEW = 32790;
    public const uint EVENT_OBJECT_END = 33023;
    public const uint EVENT_AIA_START = 40960;
    public const uint EVENT_AIA_END = 45055;
    private const uint PM_NOREMOVE = 0;
    private const uint PM_REMOVE = 1;
    private const uint WM_QUIT = 18;
    internal const int WH_MOUSE_LL = 14;
    internal const int WH_KEYBOARD_LL = 13;
    internal const int WH_MOUSE = 7;
    internal const int WH_KEYBOARD = 2;
    internal const int WM_MOUSEMOVE = 512;
    internal const int WM_LBUTTONDOWN = 513;
    internal const int WM_RBUTTONDOWN = 516;
    internal const int WM_MBUTTONDOWN = 519;
    internal const int WM_LBUTTONUP = 514;
    internal const int WM_RBUTTONUP = 517;
    internal const int WM_MBUTTONUP = 520;
    internal const int WM_LBUTTONDBLCLK = 515;
    internal const int WM_RBUTTONDBLCLK = 518;
    internal const int WM_MBUTTONDBLCLK = 521;
    internal const int WM_MOUSEWHEEL = 522;
    internal const int WM_KEYDOWN = 256;
    internal const int WM_KEYUP = 257;
    internal const int WM_SYSKEYDOWN = 260;
    internal const int WM_SYSKEYUP = 261;
    internal const byte VK_SHIFT = 16;
    internal const byte VK_CAPITAL = 20;
    internal const byte VK_NUMLOCK = 144;

    public static EventHookManager Instance
    {
      get
      {
        bool flag1 = EventHookManager.instance == null;
label_1:
        int num1 = 1336543394;
        while (true)
        {
          int num2 = 255893707;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              if (flag1)
              {
                num1 = (int) num3 * -2080914369 ^ -2103306473;
                continue;
              }
              goto label_22;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1343549481 ^ -939497468;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        object hookLocker = EventHookManager.hookLocker;
        bool flag2 = false;
        try
        {
          EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker, ref flag2);
label_8:
          int num2 = 1463713638;
          while (true)
          {
            int num3 = 255893707;
            uint num4;
            bool flag3;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 1:
                flag3 = EventHookManager.instance == null;
                num2 = (int) num4 * -1967044748 ^ 436535805;
                continue;
              case 2:
                num2 = 1159016059;
                continue;
              case 3:
                EventHookManager.instance = new EventHookManager();
                num2 = (int) num4 * -1215374890 ^ 1640742599;
                continue;
              case 4:
                int num5 = flag3 ? -1601665766 : (num5 = -515452875);
                int num6 = (int) num4 * 1064301942;
                num2 = num5 ^ num6;
                continue;
              case 5:
                goto label_8;
              default:
                goto label_19;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_15:
            int num2 = 890497638;
            while (true)
            {
              int num3 = 255893707;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_15;
                case 1:
                  EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker);
                  num2 = (int) num4 * 196925767 ^ 1245045938;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
label_19:
label_20:
        int num7 = 918892062;
label_21:
        while (true)
        {
          int num2 = 255893707;
          uint num3;
          switch ((num3 = (uint) (num7 ^ num2)) % 4U)
          {
            case 0:
              goto label_20;
            case 1:
              goto label_22;
            case 3:
              num7 = (int) num3 * -1537097100 ^ 2107128841;
              continue;
            default:
              goto label_24;
          }
        }
label_24:
        EventHookManager instance;
        return instance;
label_22:
        instance = EventHookManager.instance;
        num7 = 1909194384;
        goto label_21;
      }
    }

    public DateTime LastKeyPress
    {
      get
      {
label_1:
        int num1 = -597371197;
        DateTime lastKeyPress;
        while (true)
        {
          int num2 = -1051645067;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              lastKeyPress = this.lastKeyPress;
              num1 = (int) num3 * -845343691 ^ 2079067616;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return lastKeyPress;
      }
      set
      {
        this.lastKeyPress = value;
      }
    }

    public DateTime LastMouseMovement
    {
      get
      {
label_1:
        int num1 = -909874657;
        DateTime lastMouseMovement;
        while (true)
        {
          int num2 = -1202904464;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -936347842 ^ 404001313;
              continue;
            case 2:
              goto label_1;
            case 3:
              lastMouseMovement = this.lastMouseMovement;
              num1 = (int) num3 * 1730687567 ^ 898270501;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return lastMouseMovement;
      }
      set
      {
        this.lastMouseMovement = value;
      }
    }

    public bool IsLeftMouseDown
    {
      get
      {
label_1:
        int num1 = 808512367;
        bool leftMouseButtonDown;
        while (true)
        {
          int num2 = 379337424;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              leftMouseButtonDown = this.isLeftMouseButtonDown;
              num1 = (int) num3 * 24272296 ^ 1238357362;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return leftMouseButtonDown;
      }
      set
      {
        this.isLeftMouseButtonDown = value;
      }
    }

    public bool IsCtrlPressed
    {
      get
      {
label_1:
        int num1 = 1612444592;
        bool isCtrlPressed;
        while (true)
        {
          int num2 = 715633967;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -538508290 ^ 1244663343;
              continue;
            case 3:
              isCtrlPressed = this.isCtrlPressed;
              num1 = (int) num3 * 1063927875 ^ -605169877;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return isCtrlPressed;
      }
      set
      {
        this.isCtrlPressed = value;
      }
    }

    public bool IsAltPressed
    {
      get
      {
label_1:
        int num1 = 501393446;
        bool isAltPressed;
        while (true)
        {
          int num2 = 663892175;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              isAltPressed = this.isAltPressed;
              num1 = (int) num3 * 103014647 ^ 2033510946;
              continue;
            case 2:
              num1 = (int) num3 * 470260069 ^ -339693767;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return isAltPressed;
      }
      set
      {
        this.isAltPressed = value;
      }
    }

    public bool IsAPressed
    {
      get
      {
        return this.isAPressed;
      }
      set
      {
        this.isAPressed = value;
      }
    }

    public bool IsShiftPressed
    {
      get
      {
label_1:
        int num1 = 233677400;
        bool isShiftPressed;
        while (true)
        {
          int num2 = 1897071667;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1579541598 ^ 1116768591;
              continue;
            case 3:
              isShiftPressed = this.isShiftPressed;
              num1 = (int) num3 * -283655950 ^ -1597731520;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return isShiftPressed;
      }
      set
      {
        this.isShiftPressed = value;
      }
    }

    public System.Drawing.Point LastClickPoint
    {
      get
      {
label_1:
        int num1 = 351453332;
        System.Drawing.Point lastClickPoint;
        while (true)
        {
          int num2 = 283889697;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1498776366 ^ 29995423;
              continue;
            case 1:
              lastClickPoint = this.lastClickPoint;
              num1 = (int) num3 * 370684109 ^ 409550968;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return lastClickPoint;
      }
      set
      {
        this.lastClickPoint = value;
      }
    }

    static EventHookManager()
    {
label_1:
      int num1 = 1009242973;
      while (true)
      {
        int num2 = 952874834;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            EventHookManager.eventHandler = new EventHookManager.WinEventDelegate(EventHookManager.WindowEventCallback);
            num1 = (int) num3 * 58198872 ^ -599522537;
            continue;
          case 2:
            EventHookManager.hookLocker = EventHookManager.\u202B⁬‪‪‬‫‏⁫⁪⁫‫⁭⁮​⁬⁭‏‍⁯⁬‎‬⁫⁯‭‭⁮‍⁪⁭‭⁫⁫⁯⁪‌​​‭⁭‮();
            num1 = (int) num3 * -89377281 ^ -505010630;
            continue;
          case 3:
            EventHookManager.processIds = new List<int>();
            num1 = (int) num3 * 1390788742 ^ 1501699103;
            continue;
          case 4:
            EventHookManager.processHooks = new Dictionary<int, IntPtr>();
            num1 = (int) num3 * -1968211618 ^ -251424391;
            continue;
          case 6:
            EventHookManager.processHookExs = new Dictionary<int, IntPtr>();
            num1 = (int) num3 * -2102666547 ^ -1588599910;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      EventHookManager.hookQueue = new ConcurrentQueue<ZoomEvent>();
    }

    public EventHookManager()
    {
label_1:
      int num1 = -147538124;
      while (true)
      {
        int num2 = -1355832201;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 513994478 ^ 1553166738;
            continue;
          case 3:
            num1 = (int) num3 * 259269053 ^ 53469282;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    [DllImport("user32.dll")]
    private static extern bool PeekMessage(out EventHookManager.MSG lpMsg, IntPtr hwnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

    [DllImport("user32.dll")]
    private static extern bool TranslateMessage(ref EventHookManager.MSG lpMsg);

    [DllImport("user32.dll")]
    private static extern IntPtr DispatchMessage(ref EventHookManager.MSG lpMsg);

    [DllImport("user32.dll")]
    private static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, EventHookManager.WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, EventHookManager.HookProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int UnhookWinEvent(IntPtr hWinEventHook);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

    [DllImport("user32")]
    private static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

    [DllImport("user32")]
    private static extern int GetKeyboardState(byte[] pbKeyState);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern short GetKeyState(int vKey);

    [STAThread]
    private static void WindowEventCallback(IntPtr winEventHookHandle, uint eventType, IntPtr windowHandle, int idObject, int idChild, uint eventThreadId, uint eventTimeInMilliseconds)
    {
      try
      {
        bool flag = !windowHandle.Equals((object) IntPtr.Zero);
label_2:
        int num1 = 375747750;
        while (true)
        {
          int num2 = 1712141788;
          uint num3;
          ZoomEvent zoomEvent;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_16;
            case 1:
              num1 = 859977862;
              continue;
            case 2:
              int num4 = !flag ? 73279274 : (num4 = 1420101247);
              int num5 = (int) num3 * -803507314;
              num1 = num4 ^ num5;
              continue;
            case 3:
              uint num6 = 0;
              zoomEvent = new ZoomEvent(winEventHookHandle, windowHandle, eventType, Convert.ToInt32(num6), eventThreadId, eventTimeInMilliseconds);
              int num7 = zoomEvent != null ? 851036388 : (num7 = 1248839357);
              int num8 = (int) num3 * 387158388;
              num1 = num7 ^ num8;
              continue;
            case 4:
              ThreadPool.QueueUserWorkItem(new WaitCallback(EventHookManager.WindowEventCallback), (object) zoomEvent);
              num1 = (int) num3 * -1839535147 ^ -1687018548;
              continue;
            case 5:
              num1 = (int) num3 * 1627599772 ^ -2132629467;
              continue;
            case 6:
              goto label_2;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_16:;
      }
      catch (Exception ex)
      {
label_12:
        int num1 = 2115995256;
        while (true)
        {
          int num2 = 1712141788;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_12;
            case 1:
              num1 = (int) num3 * -1767115284 ^ 1727603508;
              continue;
            case 2:
              goto label_10;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_10:;
      }
    }

    [STAThread]
    private static void WindowEventCallback(object message)
    {
      try
      {
        if (message == null)
          goto label_6;
label_2:
        int num1 = -1619368775;
label_3:
        while (true)
        {
          int num2 = -1579310912;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_2;
            case 1:
              EventHookManager.hookQueue.Enqueue((ZoomEvent) message);
              num1 = (int) num3 * -1835417147 ^ -1034290437;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_14;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_14:
        return;
label_6:
        num1 = -1713292345;
        goto label_3;
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -1718958393;
        while (true)
        {
          int num2 = -1579310912;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              EventHookManager.\u202D‭‬‍⁫⁪‫‬⁮‪⁫‪‎‪⁫⁬⁮⁬‫⁪‮‎⁮⁮⁬⁮⁬⁮⁫⁫⁭⁯‎‎⁭‫‏⁭⁯‭‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -825951723 ^ 563130421;
              continue;
            case 1:
              goto label_7;
            case 2:
              goto label_9;
            case 3:
              num1 = (int) num3 * -1180780773 ^ -470151455;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_7:;
      }
    }

    [STAThread]
    internal Task ManageHooksAsync(CancellationToken token)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EventHookManager.\u003CManageHooksAsync\u003Ed__51 manageHooksAsyncD51 = new EventHookManager.\u003CManageHooksAsync\u003Ed__51();
      // ISSUE: reference to a compiler-generated field
      manageHooksAsyncD51.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      manageHooksAsyncD51.token = token;
label_1:
      int num1 = 710034067;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        int num2 = 2044815394;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            manageHooksAsyncD51.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num1 = (int) num3 * -75918741 ^ -948982771;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            manageHooksAsyncD51.\u003C\u003E1__state = -1;
            num1 = (int) num3 * 876297666 ^ -427467486;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            tBuilder = manageHooksAsyncD51.\u003C\u003Et__builder;
            num1 = (int) num3 * -1216082532 ^ 137771610;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncTaskMethodBuilder) @tBuilder).Start<EventHookManager.\u003CManageHooksAsync\u003Ed__51>((M0&) @manageHooksAsyncD51);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      return ((AsyncTaskMethodBuilder) @manageHooksAsyncD51.\u003C\u003Et__builder).get_Task();
    }

    [STAThread]
    internal void ManageHooks(CancellationToken token)
    {
      this.Token = token;
label_1:
      int num1 = 2118629300;
      DateTime dateTime;
      bool flag1;
      while (true)
      {
        int num2 = 1294893101;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            dateTime = DateTime.Now;
            this.LoadProcesses();
            num1 = (int) num3 * -632393350 ^ 466176737;
            continue;
          case 1:
            num1 = (int) num3 * 1800812665 ^ -331321529;
            continue;
          case 3:
            flag1 = false;
            num1 = (int) num3 * 1222211391 ^ 1830100064;
            continue;
          case 4:
            num1 = (int) num3 * -1242904526 ^ 363983549;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      List<int>.Enumerator enumerator1 = EventHookManager.processIds.GetEnumerator();
      try
      {
label_40:
        if (enumerator1.MoveNext())
        {
label_11:
          int current = enumerator1.Current;
          int num2 = 1332662393;
          while (true)
          {
            int num3 = 1294893101;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                num2 = (int) num4 * -1339103664 ^ -1468488280;
                continue;
              case 2:
                num2 = 538731207;
                continue;
              case 3:
                if (!EventHookManager.processHooks.ContainsKey(current))
                {
                  num2 = (int) num4 * -718073401 ^ -518910798;
                  continue;
                }
                goto label_39;
              case 4:
                goto label_11;
              default:
                goto label_15;
            }
          }
label_15:
          // ISSUE: type reference
          IEnumerator enumerator2 = EventHookManager.\u202D‏‌‏‎‌‫‎‬‮‍‭‭⁯‪‬‍‎⁫‬⁭‮‍‫‬⁪‌‬‭‎‍‫⁬⁮‭‫‭‏⁭⁭‮(EventHookManager.\u200F‏‭‎​‬‭⁪⁪‬‫‮⁮‭‏‫⁫‌‏⁫⁬⁫‫‌‪⁮‪​⁭⁫⁬‮⁫‏‏‮⁮‏‎‬‮(EventHookManager.\u206D⁫‭‪‏⁭‬⁬‪​⁯‌⁬⁭⁭⁭​‫⁪⁬​‫‏‭⁭‮​‎‭⁮‌⁯‫⁪‭‬⁪‫⁭‮(__typeref (ZoomEventType))));
          try
          {
label_24:
            int num3 = !EventHookManager.\u206D‍‫⁭‬⁬‫‪‫‪⁬‎​⁮‫‫⁪​‎⁮‭⁭‭⁫⁫‌‬‭‮‏‍⁮‌⁫‍‭‌‌⁬‏‮(enumerator2) ? 809990196 : (num3 = 752525482);
            while (true)
            {
              int num4 = 1294893101;
              uint num5;
              ZoomEventType zoomEventType;
              bool flag2;
              int num6;
              switch ((num5 = (uint) (num3 ^ num4)) % 11U)
              {
                case 0:
                  if (zoomEventType != ZoomEventType.Other)
                  {
                    num3 = (int) num5 * -538635782 ^ 1654303342;
                    continue;
                  }
                  num6 = 0;
                  break;
                case 1:
                  num3 = (int) num5 * 1244127935 ^ -1768639516;
                  continue;
                case 2:
                  num3 = 752525482;
                  continue;
                case 3:
                  int num7 = flag2 ? 911824556 : (num7 = 1846324044);
                  int num8 = (int) num5 * -1518228697;
                  num3 = num7 ^ num8;
                  continue;
                case 4:
                  this.AttachHook(current, zoomEventType);
                  num3 = (int) num5 * -518843298 ^ -680221625;
                  continue;
                case 5:
                  goto label_24;
                case 6:
                  num6 = zoomEventType != ZoomEventType.Undefined ? 1 : 0;
                  break;
                case 8:
                  zoomEventType = (ZoomEventType) EventHookManager.\u202D‮​‪‌⁮‬‌‍‏‬‍⁭‏⁮⁭⁬⁬‭⁮​‮⁪‮⁪‬‬‎⁪‍​​‭‭‬⁭⁭‮‪‪‮(enumerator2);
                  num3 = 860887393;
                  continue;
                case 9:
                  num3 = 674593869;
                  continue;
                case 10:
                  num3 = (int) num5 * -110298396 ^ -1620910928;
                  continue;
                default:
                  goto label_36;
              }
              flag2 = num6 != 0;
              num3 = 2117256321;
            }
          }
          finally
          {
            IDisposable disposable = enumerator2 as IDisposable;
            if (disposable != null)
            {
label_32:
              int num3 = 1748861133;
              while (true)
              {
                int num4 = 1294893101;
                uint num5;
                switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                {
                  case 1:
                    EventHookManager.\u200E‌‫‍⁮‪⁬⁫⁮​⁪‮⁫‪⁫⁮‮​‏‬‮‫‬‭⁫‮‎‫‬⁬‎‮‮‫⁯‮⁪⁭⁪‍‮(disposable);
                    num3 = (int) num5 * 857235266 ^ 15168335;
                    continue;
                  case 2:
                    goto label_32;
                  default:
                    goto label_35;
                }
              }
            }
label_35:;
          }
label_36:;
        }
        else
          goto label_41;
label_37:
        int num9 = 2023555640;
label_38:
        int num10 = 1294893101;
        uint num11;
        switch ((num11 = (uint) (num9 ^ num10)) % 4U)
        {
          case 0:
            goto label_40;
          case 1:
            break;
          case 3:
            goto label_37;
          default:
            goto label_47;
        }
label_39:
        num9 = 1335210129;
        goto label_38;
label_41:
        num9 = 1976121923;
        goto label_38;
      }
      finally
      {
        enumerator1.Dispose();
label_43:
        int num2 = 1908287656;
        while (true)
        {
          int num3 = 1294893101;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_43;
            case 1:
              num2 = (int) num4 * -1911895303 ^ 721373861;
              continue;
            default:
              goto label_46;
          }
        }
label_46:;
      }
label_47:
      this.Initialized = true;
label_48:
      int num12 = 699126289;
      while (true)
      {
        int num2 = 1294893101;
        uint num3;
        switch ((num3 = (uint) (num12 ^ num2)) % 11U)
        {
          case 0:
            num12 = (int) num3 * 880071971 ^ -966766404;
            continue;
          case 1:
            KeyboardHookManager.KeyDown += new KeyEventHandler(this.KeyboardHookManager_KeyDown);
            num12 = (int) num3 * -993709433 ^ 664734101;
            continue;
          case 2:
            goto label_104;
          case 3:
            num12 = (int) num3 * 335367541 ^ 1755150345;
            continue;
          case 4:
            num12 = (int) num3 * 223176377 ^ 501574723;
            continue;
          case 6:
            KeyboardHookManager.KeyUp += new KeyEventHandler(this.KeyboardHookManager_KeyUp);
            num12 = (int) num3 * 1832097430 ^ 623409239;
            continue;
          case 7:
            KeyboardHookManager.MouseUp += new MouseEventHandler(this.KeyboardHookManager_MouseUp);
            num12 = (int) num3 * 875956047 ^ -2077159769;
            continue;
          case 8:
            KeyboardHookManager.MouseClick += new MouseEventHandler(this.KeyboardHookManager_MouseClick);
            num12 = (int) num3 * -543830997 ^ -903420833;
            continue;
          case 9:
            goto label_48;
          case 10:
            KeyboardHookManager.MouseDown += new MouseEventHandler(this.KeyboardHookManager_MouseDown);
            num12 = (int) num3 * 355363324 ^ -933012222;
            continue;
          default:
            goto label_58;
        }
      }
label_58:
      try
      {
        EventHookManager.MSG lpMsg;
        if (!EventHookManager.PeekMessage(out lpMsg, IntPtr.Zero, 0U, 0U, 1U))
          goto label_62;
label_60:
        int num2 = 237182747;
label_61:
        object hookLocker;
        while (true)
        {
          int num3 = 1294893101;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              int num5 = flag2 ? -1720801093 : (num5 = -811379439);
              int num6 = (int) num4 * 1121800290;
              num2 = num5 ^ num6;
              continue;
            case 1:
              hookLocker = EventHookManager.hookLocker;
              num2 = (int) num4 * -52740551 ^ -189000822;
              continue;
            case 3:
              goto label_62;
            case 4:
              EventHookManager.TranslateMessage(ref lpMsg);
              EventHookManager.DispatchMessage(ref lpMsg);
              num2 = 1009927270;
              continue;
            case 5:
              goto label_60;
            case 6:
              goto label_99;
            case 7:
              num2 = (int) num4 * 1051284463 ^ -1171585679;
              continue;
            case 8:
              num2 = (int) num4 * -2132079548 ^ -2045184794;
              continue;
            case 9:
              flag2 = (int) lpMsg.Message == 18;
              num2 = (int) num4 * -62692657 ^ 1537205314;
              continue;
            default:
              goto label_70;
          }
        }
label_99:
        return;
label_70:
        bool flag3 = false;
        ZoomEvent zoomEvent;
        try
        {
          EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker, ref flag3);
label_72:
          int num3 = 1559157738;
          while (true)
          {
            int num4 = 1294893101;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 6U)
            {
              case 0:
                num3 = (int) num5 * 1082550237 ^ 1756126405;
                continue;
              case 1:
                num3 = (int) num5 * 208654590 ^ 1344721479;
                continue;
              case 3:
                goto label_72;
              case 4:
                this.SharedData.WindowQueue.Enqueue(zoomEvent);
                num3 = (int) num5 * -1734764009 ^ -590128202;
                continue;
              case 5:
                num3 = (int) num5 * -1548576850 ^ 447302737;
                continue;
              default:
                goto label_84;
            }
          }
        }
        finally
        {
          if (flag3)
          {
label_79:
            int num3 = 1306390428;
            while (true)
            {
              int num4 = 1294893101;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 0:
                  goto label_79;
                case 1:
                  EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker);
                  num3 = (int) num5 * -1237978785 ^ 1349558909;
                  continue;
                case 3:
                  num3 = (int) num5 * 206777998 ^ 1289303289;
                  continue;
                default:
                  goto label_83;
              }
            }
          }
label_83:;
        }
label_84:
        goto label_85;
label_62:
        if (EventHookManager.hookQueue.TryDequeue(ref zoomEvent))
        {
          num2 = 252885456;
          goto label_61;
        }
        else
          goto label_90;
label_85:
        int num7 = 476408075;
label_86:
        while (true)
        {
          int num3 = 1294893101;
          uint num4;
          DateTime now;
          switch ((num4 = (uint) (num7 ^ num3)) % 9U)
          {
            case 0:
              this.LoadProcesses();
              num7 = (int) num4 * 689718877 ^ -1627911352;
              continue;
            case 1:
              goto label_90;
            case 2:
              num7 = (int) num4 * 476808331 ^ -792049348;
              continue;
            case 3:
              now = DateTime.Now;
              num7 = (int) num4 * -2124257798 ^ -1816053765;
              continue;
            case 5:
              num7 = 1040076457;
              continue;
            case 6:
              num7 = (int) num4 * -1106191097 ^ 1988599622;
              continue;
            case 7:
              goto label_85;
            case 8:
              dateTime = now.AddSeconds(5.0);
              num7 = (int) num4 * -599334533 ^ -1964034201;
              continue;
            default:
              goto label_100;
          }
        }
label_90:
        num7 = !(dateTime < DateTime.Now) ? 1014545644 : (num7 = 1337504230);
        goto label_86;
      }
      catch (Exception ex)
      {
label_95:
        int num2 = 1119839711;
        while (true)
        {
          int num3 = 1294893101;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              CoreObject.log.Error((object) ex);
              num2 = (int) num4 * -1913389098 ^ -1592671619;
              continue;
            case 2:
              goto label_95;
            default:
              goto label_100;
          }
        }
      }
label_100:
label_101:
      int num13 = 1919319055;
label_102:
      bool flag4;
      while (true)
      {
        int num2 = 1294893101;
        uint num3;
        switch ((num3 = (uint) (num13 ^ num2)) % 5U)
        {
          case 0:
            goto label_106;
          case 1:
            goto label_104;
          case 2:
            if (!flag4)
            {
              num13 = (int) num3 * 1252994087 ^ -239985350;
              continue;
            }
            goto label_58;
          case 3:
            goto label_103;
          case 4:
            goto label_101;
          default:
            goto label_97;
        }
      }
label_97:
      return;
label_103:
      return;
label_106:
      int num14 = !this.CancelRequested ? 1 : 0;
      goto label_108;
label_104:
      if (!flag1)
      {
        num13 = 1983025805;
        goto label_102;
      }
      else
        num14 = 0;
label_108:
      flag4 = num14 != 0;
      num13 = 1349365430;
      goto label_102;
    }

    private void KeyboardHookManager_MouseUp(object sender, MouseEventArgs e)
    {
label_1:
      int num1 = -1325563224;
      while (true)
      {
        int num2 = -407109961;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1806749934 ^ -1350600957;
            continue;
          case 2:
            goto label_3;
          case 3:
            int num4 = EventHookManager.\u200D‌‬‪⁪‍⁯‪‬⁮⁭​⁬‌⁬⁮‌​​‏‫‪​⁯‍⁪⁯‌‍‍​‎‬‌‮​‏‪‪‪‮(e) != MouseButtons.Left ? 1266312124 : (num4 = 377121631);
            int num5 = (int) num3 * 1028808707;
            num1 = num4 ^ num5;
            continue;
          case 4:
            this.isLeftMouseButtonDown = false;
            this.LastClickPoint = new System.Drawing.Point(EventHookManager.\u202D​​⁯‮⁪‎‬‪‭‏‪‍‭‍⁬⁪⁮‪‬‍‌‏⁯​⁬‏‫⁬​⁭⁫​‎‪⁮‍‫‍⁪‮(e), EventHookManager.\u202B⁫⁭‫‭⁬⁭‏⁯⁭‍⁫⁬‌‪⁬‭⁭‭⁬⁬⁫⁮⁪‪‎‫‮‭⁫⁬⁪⁪‌‭‎⁪‪⁫⁯‮(e));
            num1 = (int) num3 * 1855350376 ^ -262752882;
            continue;
          case 5:
            num1 = (int) num3 * -605263169 ^ 18187878;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void KeyboardHookManager_MouseDown(object sender, MouseEventArgs e)
    {
      if (EventHookManager.\u200D‌‬‪⁪‍⁯‪‬⁮⁭​⁬‌⁬⁮‌​​‏‫‪​⁯‍⁪⁯‌‍‍​‎‬‌‮​‏‪‪‪‮(e) != MouseButtons.Left)
        return;
label_1:
      int num1 = 399117445;
      while (true)
      {
        int num2 = 2123974484;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_6;
          case 1:
            this.isLeftMouseButtonDown = true;
            num1 = (int) num3 * 614567135 ^ 1583418468;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1371209177 ^ -1478281407;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_6:;
    }

    private void KeyboardHookManager_MouseClick(object sender, MouseEventArgs e)
    {
label_1:
      int num1 = 160524381;
      while (true)
      {
        int num2 = 1433800316;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 1025795276 ^ -1019293968;
            continue;
          case 1:
            goto label_3;
          case 2:
            num4 = this.IsShiftPressed ? 1 : 0;
            break;
          case 3:
            if (this.IsCtrlPressed)
            {
              num1 = (int) num3 * -1713843567 ^ 440874474;
              continue;
            }
            num4 = 0;
            break;
          case 4:
            num1 = (int) num3 * -1082063375 ^ 857615593;
            continue;
          case 5:
            goto label_1;
          case 6:
            EventHookManager.\u206F‎⁯⁯‌⁬​‌‫⁫‎‏‍​‫​⁮‬⁪‭⁯‮​‍‍‫‬⁬‎‬‍⁫‬‏‪⁫⁬‬​‎‮(new WaitCallback(this.HandleAdminMouseClick), (object) e);
            num1 = (int) num3 * 796294474 ^ -1512695456;
            continue;
          case 7:
            num1 = (int) num3 * 1996910125 ^ -1683427406;
            continue;
          case 8:
            this.LastMouseMovement = DateTime.Now;
            num1 = (int) num3 * -1892763007 ^ -668104646;
            continue;
          default:
            goto label_14;
        }
        int num5;
        num1 = num5 = num4 != 0 ? 733087965 : (num5 = 2075268318);
      }
label_14:
      return;
label_3:;
    }

    private void HandleAdminMouseClick(object e)
    {
      MouseEventArgs args = e as MouseEventArgs;
label_1:
      int num1 = -2037553626;
      while (true)
      {
        int num2 = -1218124004;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            if (flag)
            {
              num1 = (int) num3 * 63963049 ^ 985587401;
              continue;
            }
            goto label_49;
          case 2:
            flag = args != null;
            num1 = (int) num3 * 987445406 ^ 838495017;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_49:
      return;
label_6:
      try
      {
label_8:
        int num2 = -941113693;
        while (true)
        {
          int num3 = -1218124004;
          uint num4;
          string[] strArray1;
          string[] strArray2;
          bool flag;
          ZoomWindow window;
          int index;
          POINT lpPoint;
          IntPtr handle;
          int num5;
          int num6;
          switch ((num4 = (uint) (num2 ^ num3)) % 29U)
          {
            case 0:
              num2 = (int) num4 * 861996479 ^ 387292221;
              continue;
            case 1:
              num2 = -1552874751;
              continue;
            case 2:
              if (window.ZoomWindowType == ZoomWindowType.Video)
              {
                num2 = (int) num4 * 1587141826 ^ 2138922826;
                continue;
              }
              break;
            case 3:
              num2 = (int) num4 * 516213227 ^ 1225758217;
              continue;
            case 4:
              if (window == null)
              {
                num6 = 0;
                goto label_27;
              }
              else
              {
                num2 = -758885098;
                continue;
              }
            case 6:
              num2 = (int) num4 * -1721739926 ^ -371460687;
              continue;
            case 7:
              num6 = EventHookManager.\u200D‌‬‪⁪‍⁯‪‬⁮⁭​⁬‌⁬⁮‌​​‏‫‪​⁯‍⁪⁯‌‍‍​‎‬‌‮​‏‪‪‪‮(args) == MouseButtons.Left ? 1 : 0;
              goto label_27;
            case 8:
              if (window != null)
              {
                num2 = (int) num4 * 1694117752 ^ -1734286223;
                continue;
              }
              break;
            case 9:
              lpPoint.x = EventHookManager.\u202D​​⁯‮⁪‎‬‪‭‏‪‍‭‍⁬⁪⁮‪‬‍‌‏⁯​⁬‏‫⁬​⁭⁫​‎‪⁮‍‫‍⁪‮(args);
              num2 = (int) num4 * -1406016317 ^ -191796466;
              continue;
            case 10:
              EventHookManager.\u206A⁯‪‫⁪‏‫‫‮‭‮‍⁮⁫⁮⁭‮‍‍⁬‮⁫‍⁫‭‮‫‍‍‍‫‫‌‮⁮‫⁯⁪⁯⁮‮(strArray2[index]);
              num2 = -1550189346;
              continue;
            case 11:
              index = 0;
              num2 = (int) num4 * 2032564179 ^ -2032376521;
              continue;
            case 12:
              lpPoint = new POINT();
              num2 = (int) num4 * -875654587 ^ 1270604956;
              continue;
            case 13:
              goto label_8;
            case 14:
              num2 = (int) num4 * -2141208058 ^ -2036520024;
              continue;
            case 15:
              strArray1 = EventHookManager.\u206B⁬‮⁮‎⁬⁮​⁯‍⁭⁭‪⁯‭‬⁪⁫‬⁪‬⁫‭⁬‮⁪⁮‍‫​⁯‭⁯⁭‌⁭⁫‮‭⁯‮(this.Engine.Settings.AdminRightClickAction, new char[1]
              {
                '|'
              });
              num2 = (int) num4 * -378640724 ^ 1118988654;
              continue;
            case 16:
              ++index;
              num2 = (int) num4 * -1466463089 ^ -492257754;
              continue;
            case 17:
              num2 = -1180578756;
              continue;
            case 18:
              int num7;
              num2 = num7 = index >= strArray2.Length ? -1250331848 : (num7 = -1568024034);
              continue;
            case 19:
              lpPoint.y = EventHookManager.\u202B⁫⁭‫‭⁬⁭‏⁯⁭‍⁫⁬‌‪⁬‭⁭‭⁬⁬⁫⁮⁪‪‎‫‮‭⁫⁬⁪⁪‌‭‎⁪‪⁫⁯‮(args);
              handle = User32.WindowFromPoint(lpPoint);
              int num8 = handle != IntPtr.Zero ? 76798450 : (num8 = 1712223862);
              int num9 = (int) num4 * 77696669;
              num2 = num8 ^ num9;
              continue;
            case 20:
              num5 = EventHookManager.\u200D‌‬‪⁪‍⁯‪‬⁮⁭​⁬‌⁬⁮‌​​‏‫‪​⁯‍⁪⁯‌‍‍​‎‬‌‮​‏‪‪‪‮(args) == MouseButtons.Right ? 1 : 0;
              goto label_23;
            case 21:
              window = this.Engine.GetWindow(handle, false);
              num2 = (int) num4 * 2057812353 ^ -612924732;
              continue;
            case 22:
              num2 = (int) num4 * -152143102 ^ 2130668564;
              continue;
            case 23:
              num2 = (int) num4 * 1103531740 ^ -1142200564;
              continue;
            case 24:
              strArray2 = strArray1;
              num2 = (int) num4 * -1212184865 ^ -390094390;
              continue;
            case 25:
              ((CompositePresentationEvent<MouseEventData>) this._eventAggregator.GetEvent<MouseEvent>()).Publish(new MouseEventData(args, this.GetKeysDown()));
              num2 = (int) num4 * -1853551429 ^ -4561363;
              continue;
            case 26:
              int num10 = flag ? -56714753 : (num10 = -1254086861);
              int num11 = (int) num4 * 1963468927;
              num2 = num10 ^ num11;
              continue;
            case 27:
              EventHookManager.\u202C‌⁪‫‮‬⁮‎⁫⁬‮⁭⁫⁬‪⁫‏⁯⁫‮‪⁬⁫​​⁪⁪‮‬‍‬​⁯⁪⁬‮‬⁭⁮‎‮(30);
              num2 = (int) num4 * 1760600980 ^ -589205115;
              continue;
            case 28:
              num2 = (int) num4 * -1831652115 ^ 1313471318;
              continue;
            default:
              goto label_50;
          }
          num5 = 0;
label_23:
          flag = num5 != 0;
          num2 = -480369501;
          continue;
label_27:
          int num12;
          num2 = num12 = num6 != 0 ? -67975762 : (num12 = -1877584784);
        }
      }
      catch (Exception ex)
      {
label_45:
        int num2 = -361446079;
        while (true)
        {
          int num3 = -1218124004;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_45;
            case 1:
              EventHookManager.\u202D‭‬‍⁫⁪‫‬⁮‪⁫‪‎‪⁫⁬⁮⁬‫⁪‮‎⁮⁮⁬⁮⁬⁮⁫⁫⁭⁯‎‎⁭‫‏⁭⁯‭‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * 1132897265 ^ -496571230;
              continue;
            case 3:
              num2 = (int) num4 * -463542483 ^ 2097690101;
              continue;
            default:
              goto label_50;
          }
        }
      }
label_50:;
    }

    private void KeyboardHookManager_MouseMove(object sender, MouseEventArgs e)
    {
    }

    public void AttachHook(int processId, ZoomEventType zoomEventType)
    {
      bool cancelRequested = this.CancelRequested;
label_1:
      int num1 = 1504825932;
      IntPtr hmodWinEventProc;
      while (true)
      {
        int num2 = 1138672551;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            goto label_1;
          case 1:
            if (EventHookManager.processHooks.ContainsKey(processId))
            {
              num1 = (int) num3 * -101578836 ^ 1291234422;
              continue;
            }
            goto label_27;
          case 2:
            num1 = (int) num3 * 31382781 ^ 1468930469;
            continue;
          case 3:
            num1 = 751576226;
            continue;
          case 4:
            goto label_7;
          case 5:
            hmodWinEventProc = IntPtr.Zero;
            num1 = (int) num3 * 1879047196 ^ 76701942;
            continue;
          case 6:
            num1 = (int) num3 * 675550052 ^ 522283503;
            continue;
          case 7:
            int num4;
            num1 = num4 = zoomEventType == ZoomEventType.Other ? 891112909 : (num4 = 14710060);
            continue;
          case 8:
            goto label_61;
          case 9:
            num1 = (int) num3 * 1598603051 ^ -327908370;
            continue;
          case 11:
            int num5 = !cancelRequested ? 659176119 : (num5 = 1001257514);
            int num6 = (int) num3 * 1927071941;
            num1 = num5 ^ num6;
            continue;
          default:
            goto label_13;
        }
      }
label_61:
      return;
label_7:
      throw EventHookManager.\u200F‏⁬‬⁬‬‮⁬‪⁫‬‪⁯⁭‍‪⁬​‬⁯‫⁪‎‭‪‬⁬‬⁭⁫⁫⁬⁭⁮‎‎‌​⁫‎‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3056113161U));
label_13:
      object hookLocker1 = EventHookManager.hookLocker;
      bool flag1 = false;
      try
      {
        EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker1, ref flag1);
label_15:
        int num2 = 895837873;
        while (true)
        {
          int num3 = 1138672551;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              hmodWinEventProc = EventHookManager.processHooks[processId];
              num2 = (int) num4 * -879651203 ^ -493156482;
              continue;
            case 2:
              num2 = (int) num4 * 1451884214 ^ 1181686038;
              continue;
            case 3:
              goto label_15;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_20:
          int num2 = 1955386690;
          while (true)
          {
            int num3 = 1138672551;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_20;
              case 1:
                EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker1);
                num2 = (int) num4 * -114595808 ^ -2014705149;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:
label_25:
      int num7 = 1572788241;
label_26:
      object hookLocker2;
      while (true)
      {
        int num2 = 1138672551;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            goto label_25;
          case 1:
            GCHandle.Alloc((object) EventHookManager.eventHandler);
            hookLocker2 = EventHookManager.hookLocker;
            num7 = (int) num3 * 1157359807 ^ -361556261;
            continue;
          case 2:
            goto label_27;
          default:
            goto label_29;
        }
      }
label_29:
      bool flag2 = false;
      uint eventType;
      try
      {
        EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker2, ref flag2);
label_31:
        int num2 = 670155508;
        while (true)
        {
          int num3 = 1138672551;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_31;
            case 1:
              num2 = (int) num4 * 2132342740 ^ -666526616;
              continue;
            case 2:
              hmodWinEventProc = EventHookManager.SetWinEventHook(eventType, eventType, hmodWinEventProc, EventHookManager.eventHandler, EventHookManager.\u206B⁯⁫⁪‍⁪⁫⁭⁪⁭⁪​⁮‎‫⁭⁪‭‮⁯⁫⁮‭‪‫‍⁪‎‫‮‌‍‌‍⁬‏‫⁭‏‍‮(processId), 0U, 2U);
              num2 = (int) num4 * -1929024067 ^ 2017897678;
              continue;
            case 3:
              num2 = (int) num4 * -1584681550 ^ -1166025144;
              continue;
            default:
              goto label_42;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_37:
          int num2 = 726820552;
          while (true)
          {
            int num3 = 1138672551;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 1262941185 ^ -343298970;
                continue;
              case 2:
                goto label_37;
              case 3:
                EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker2);
                num2 = (int) num4 * 658197812 ^ -828327737;
                continue;
              default:
                goto label_41;
            }
          }
        }
label_41:;
      }
label_42:
      if (!(hmodWinEventProc == IntPtr.Zero))
        goto label_45;
label_43:
      int num8 = 2144112173;
label_44:
      bool flag3;
      object hookLocker3;
      while (true)
      {
        int num2 = 1138672551;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 7U)
        {
          case 0:
            if (flag3)
            {
              num8 = (int) num3 * -776224309 ^ -14898075;
              continue;
            }
            goto label_75;
          case 1:
            goto label_45;
          case 2:
            goto label_43;
          case 3:
            num8 = (int) num3 * 608553688 ^ 223557276;
            continue;
          case 4:
            hookLocker3 = EventHookManager.hookLocker;
            num8 = (int) num3 * 202063049 ^ -1336698847;
            continue;
          case 5:
            goto label_70;
          default:
            goto label_50;
        }
      }
label_50:
      bool flag4 = false;
      try
      {
        EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker3, ref flag4);
label_52:
        int num2 = 1719762021;
        while (true)
        {
          int num3 = 1138672551;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * 1877590335 ^ 617892654;
              continue;
            case 1:
              EventHookManager.processHooks.Add(processId, hmodWinEventProc);
              num2 = (int) num4 * 458055437 ^ -744769380;
              continue;
            case 2:
              num2 = (int) num4 * -283057497 ^ -869317193;
              continue;
            case 3:
              goto label_52;
            default:
              goto label_65;
          }
        }
      }
      finally
      {
        if (flag4)
        {
label_59:
          int num2 = 1914476841;
          while (true)
          {
            int num3 = 1138672551;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_59;
              case 2:
                EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker3);
                num2 = (int) num4 * -1252348794 ^ -437794160;
                continue;
              case 3:
                num2 = (int) num4 * 161820241 ^ -1136128139;
                continue;
              default:
                goto label_64;
            }
          }
        }
label_64:;
      }
label_65:
label_66:
      int num9 = 149540366;
label_67:
      bool flag5;
      while (true)
      {
        int num2 = 1138672551;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 10U)
        {
          case 0:
            this.CreateExistingWindowEvents(processId);
            num9 = (int) num3 * 1179330845 ^ 604983410;
            continue;
          case 1:
            goto label_68;
          case 2:
            goto label_70;
          case 3:
            num9 = (int) num3 * -1370562257 ^ -1305924600;
            continue;
          case 4:
            goto label_66;
          case 5:
            int num4 = flag5 ? -1915771319 : (num4 = -834884698);
            int num5 = (int) num3 * 112776401;
            num9 = num4 ^ num5;
            continue;
          case 6:
            num9 = 201920039;
            continue;
          case 7:
            goto label_75;
          case 8:
            num9 = (int) num3 * -472687079 ^ 1705577921;
            continue;
          case 9:
            num9 = (int) num3 * -367077383 ^ 443184218;
            continue;
          default:
            goto label_57;
        }
      }
label_57:
      return;
label_68:
      return;
label_70:
      num9 = 1358411580;
      goto label_67;
label_75:
      flag5 = zoomEventType == ZoomEventType.Create;
      num9 = 1373139494;
      goto label_67;
label_45:
      flag3 = !EventHookManager.processHooks.ContainsKey(processId);
      num8 = 634094536;
      goto label_44;
label_27:
      eventType = ZoomEvent.GetEventType(zoomEventType);
      num7 = 1059452958;
      goto label_26;
    }

    internal void DetachAll()
    {
      try
      {
        using (Dictionary<int, IntPtr>.KeyCollection.Enumerator enumerator = EventHookManager.processHooks.Keys.GetEnumerator())
        {
label_6:
          int num1 = !enumerator.MoveNext() ? -33117566 : (num1 = -686189459);
          while (true)
          {
            int num2 = -1539103110;
            uint num3;
            int current;
            switch ((num3 = (uint) (num1 ^ num2)) % 6U)
            {
              case 0:
                num1 = -686189459;
                continue;
              case 1:
                current = enumerator.Current;
                num1 = -1552112637;
                continue;
              case 2:
                goto label_6;
              case 3:
                num1 = (int) num3 * 1209356085 ^ 1814343226;
                continue;
              case 4:
                goto label_17;
              case 5:
                this.DetachHook(current, EventHookManager.processHooks[current]);
                num1 = (int) num3 * -547518696 ^ -1877187662;
                continue;
              default:
                goto label_15;
            }
          }
label_15:
          return;
label_17:;
        }
      }
      catch (Exception ex)
      {
        this.Engine.LogException(EventHookManager.\u206F​‭⁫⁯‫​⁪‏⁯⁮‪​⁫⁯‌⁭‏⁭⁮‎‬⁭‮⁫⁭‫⁮‬‮⁫⁮⁮‫⁫‫⁭⁫⁬‏‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3796533045U), EventHookManager.\u206F‏‭‪‪‎‎⁪‪‫‫​‬‌​‪‪‬‎⁫⁮⁫⁭‭⁪⁮‮⁯‏‮‬‌​‮‮‭⁫⁯‬‎‮(ex)));
label_13:
        int num1 = -1453904388;
        while (true)
        {
          int num2 = -1539103110;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_11;
            case 1:
              num1 = (int) num3 * 878884518 ^ -729879117;
              continue;
            case 2:
              goto label_13;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_11:;
      }
    }

    private void DetachHook(List<int> processesNotRunning)
    {
      List<int>.Enumerator enumerator = processesNotRunning.GetEnumerator();
      try
      {
label_7:
        int num1 = enumerator.MoveNext() ? 1264751576 : (num1 = 1368899172);
        while (true)
        {
          int num2 = 41197247;
          uint num3;
          int current;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_7;
            case 1:
              current = enumerator.Current;
              num1 = 2050906965;
              continue;
            case 2:
              num1 = (int) num3 * 1478531530 ^ -1954132315;
              continue;
            case 3:
              goto label_12;
            case 4:
              this.DetachHook(current, IntPtr.Zero);
              num1 = (int) num3 * -334653721 ^ 1790773763;
              continue;
            case 5:
              num1 = 1264751576;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_12:;
      }
      finally
      {
        enumerator.Dispose();
label_10:
        int num1 = 1016900862;
        while (true)
        {
          int num2 = 41197247;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1912706104 ^ 1277016022;
              continue;
            case 2:
              goto label_10;
            default:
              goto label_14;
          }
        }
label_14:;
      }
    }

    internal bool DetachHook(int processId, IntPtr hookHandle)
    {
      if (!hookHandle.Equals((object) IntPtr.Zero))
        goto label_14;
label_1:
      int num1 = -481210352;
label_2:
      object hookLocker;
      while (true)
      {
        int num2 = -1063421744;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            hookHandle = EventHookManager.processHooks[processId];
            num1 = (int) num3 * 23513755 ^ -1658448016;
            continue;
          case 1:
            if (!hookHandle.Equals((object) IntPtr.Zero))
            {
              num1 = -29053192;
              continue;
            }
            num4 = 0;
            break;
          case 2:
            num4 = NativeMethods.UnhookWinEvent(hookHandle) ? 1 : 0;
            break;
          case 3:
            hookLocker = EventHookManager.hookLocker;
            num1 = (int) num3 * 491621822 ^ 821811218;
            continue;
          case 4:
            if (flag)
            {
              num1 = (int) num3 * 1990206738 ^ 1142541994;
              continue;
            }
            goto label_31;
          case 5:
            num1 = (int) num3 * 1048550190 ^ 144866077;
            continue;
          case 6:
            goto label_13;
          case 7:
            goto label_1;
          default:
            goto label_16;
        }
        flag = num4 != 0;
        num1 = -1707416143;
      }
label_13:
      int num5 = EventHookManager.processHooks.ContainsKey(processId) ? 1 : 0;
      goto label_15;
label_16:
      bool flag1 = false;
      try
      {
        Monitor.Enter(hookLocker, ref flag1);
label_18:
        int num2 = -2056351416;
        while (true)
        {
          int num3 = -1063421744;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_18;
            case 1:
              EventHookManager.processHooks.Remove(processId);
              num2 = (int) num4 * -2081784848 ^ -248033411;
              continue;
            default:
              goto label_27;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_22:
          int num2 = -712994819;
          while (true)
          {
            int num3 = -1063421744;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Monitor.Exit(hookLocker);
                num2 = (int) num4 * 241400775 ^ 2067106840;
                continue;
              case 2:
                goto label_22;
              case 3:
                num2 = (int) num4 * 2031782830 ^ 2060056526;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
label_27:
      bool flag2 = true;
label_28:
      int num6 = -2140859172;
label_29:
      while (true)
      {
        int num2 = -1063421744;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 5U)
        {
          case 0:
            goto label_28;
          case 1:
            flag2 = false;
            num6 = (int) num3 * 833425843 ^ -114251743;
            continue;
          case 2:
            num6 = (int) num3 * 1999617462 ^ -478883450;
            continue;
          case 3:
            goto label_31;
          default:
            goto label_33;
        }
      }
label_33:
      return flag2;
label_31:
      num6 = -790224827;
      goto label_29;
label_14:
      num5 = 0;
label_15:
      num1 = num5 == 0 ? -86384207 : (num1 = -455405282);
      goto label_2;
    }

    internal override void Cancel()
    {
      object hookLocker = EventHookManager.hookLocker;
      bool flag = false;
      try
      {
        EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker, ref flag);
label_2:
        int num1 = -1481320664;
        while (true)
        {
          int num2 = -1211919153;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.CancelRequested = true;
              num1 = (int) num3 * -1480945409 ^ 1623416576;
              continue;
            case 1:
              num1 = (int) num3 * 604354070 ^ -1880995092;
              continue;
            case 2:
              goto label_2;
            case 3:
              num1 = (int) num3 * -824849047 ^ -682261534;
              continue;
            case 4:
              goto label_12;
            case 5:
              num1 = (int) num3 * -57429449 ^ 978146158;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_12:;
      }
      finally
      {
        if (flag)
        {
label_10:
          int num1 = -839555154;
          while (true)
          {
            int num2 = -1211919153;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker);
                num1 = (int) num3 * -1268245616 ^ 340487680;
                continue;
              case 2:
                goto label_10;
              case 3:
                num1 = (int) num3 * 535777446 ^ -815071843;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    private void LoadProcesses()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EventHookManager.\u003C\u003Ec__DisplayClass64_0 cDisplayClass640 = new EventHookManager.\u003C\u003Ec__DisplayClass64_0();
label_1:
      int num1 = -1306990927;
      int index;
      Process[] processArray1;
      while (true)
      {
        int num2 = -1896072392;
        uint num3;
        Process[] processArray2;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 1:
            processArray2 = EventHookManager.\u202B⁯⁭⁫⁯‫⁮⁯‮⁫‭​‪‎‬⁪‭⁭‫‫⁮‫⁯‌‪⁭⁪‮​⁬‮‎‭⁭⁯‏‏‬‭‮();
            // ISSUE: reference to a compiler-generated field
            cDisplayClass640.foundProcesses = new List<int>();
            num1 = (int) num3 * 1201933321 ^ 1331821412;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_43;
          case 4:
            index = 0;
            num1 = (int) num3 * -368148937 ^ -131872921;
            continue;
          case 5:
            processArray1 = processArray2;
            num1 = (int) num3 * 1856391998 ^ -2142981654;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      Process process = processArray1[index];
      try
      {
label_8:
        int num2 = -1766374823;
        while (true)
        {
          int num3 = -1896072392;
          uint num4;
          bool flag;
          string str;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 1:
              str = EventHookManager.\u200C‬‍​‫‪​​‌⁬⁫​‫⁪‏‎​‬‌‏‫‎⁭‭⁫​⁬⁬⁪‮⁪⁮‬‬‍‮‫⁫‎‬‮(EventHookManager.\u206D⁭​‍‪⁫‭‮⁭‪⁮⁬‌⁫​‏⁫⁬‫⁭⁫‫⁯‌‬‎‍‪‍‮⁫‪‬‎⁯‌​⁬⁫‎‮(process));
              num2 = (int) num4 * -1361238448 ^ -1726001150;
              continue;
            case 2:
              num2 = (int) num4 * -1442997379 ^ -882628214;
              continue;
            case 3:
              num2 = (int) num4 * -1125636521 ^ 339760980;
              continue;
            case 4:
              int num6 = !EventHookManager.\u202B‪⁯⁯⁪‎⁫​‪⁮‪⁯⁪​⁯‬⁫⁭‎‭‍‫⁮⁭‫‫‎⁫‎⁪⁯​‬‎‏‭​‮​⁫‮(str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1342592171U)) ? -121760524 : (num6 = -728753449);
              int num7 = (int) num4 * 1176668062;
              num2 = num6 ^ num7;
              continue;
            case 5:
              num5 = !EventHookManager.processIds.Contains(EventHookManager.\u200D‭‏‬⁬‬‫‎‎‏‬‪‬‪⁫⁭‪​⁮⁫‮⁪⁪⁭‪‍‍⁬‎‍⁭‍​‎‏⁫⁬‎⁬⁪‮(process)) ? 1 : 0;
              break;
            case 6:
              if (flag)
              {
                num2 = (int) num4 * -576561334 ^ -2052186706;
                continue;
              }
              goto label_40;
            case 7:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass640.foundProcesses.Add(EventHookManager.\u200D‭‏‬⁬‬‫‎‎‏‬‪‬‪⁫⁭‪​⁮⁫‮⁪⁪⁭‪‍‍⁬‎‍⁭‍​‎‏⁫⁬‎⁬⁪‮(process));
              num2 = (int) num4 * -2134695667 ^ 776560682;
              continue;
            case 8:
              if (!EventHookManager.\u202B‪⁯⁯⁪‎⁫​‪⁮‪⁯⁪​⁯‬⁫⁭‎‭‍‫⁮⁭‫‫‎⁫‎⁪⁯​‬‎‏‭​‮​⁫‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3442382329U)))
              {
                num5 = 0;
                break;
              }
              num2 = (int) num4 * -1636954475 ^ 1305154459;
              continue;
            case 9:
              goto label_8;
            default:
              goto label_22;
          }
          flag = num5 != 0;
          num2 = -1004643720;
        }
label_22:
        object hookLocker = EventHookManager.hookLocker;
        bool flag1 = false;
        try
        {
          EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker, ref flag1);
label_24:
          int num3 = -1538234041;
          while (true)
          {
            int num4 = -1896072392;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 6U)
            {
              case 0:
                goto label_24;
              case 2:
                EventHookManager.processIds.Add(EventHookManager.\u200D‭‏‬⁬‬‫‎‎‏‬‪‬‪⁫⁭‪​⁮⁫‮⁪⁪⁭‪‍‍⁬‎‍⁭‍​‎‏⁫⁬‎⁬⁪‮(process));
                num3 = (int) num5 * -1507580734 ^ -1084200329;
                continue;
              case 3:
                num3 = (int) num5 * -447260174 ^ 897522720;
                continue;
              case 4:
                num3 = (int) num5 * 68157378 ^ 50710577;
                continue;
              case 5:
                num3 = (int) num5 * 1587257171 ^ -657531277;
                continue;
              default:
                goto label_35;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_31:
            int num3 = -226751289;
            while (true)
            {
              int num4 = -1896072392;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 3U)
              {
                case 0:
                  goto label_31;
                case 1:
                  EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker);
                  num3 = (int) num5 * 1667628773 ^ -529515341;
                  continue;
                default:
                  goto label_34;
              }
            }
          }
label_34:;
        }
label_35:;
      }
      catch (Exception ex)
      {
label_37:
        int num2 = -49911028;
        while (true)
        {
          int num3 = -1896072392;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_37;
            case 2:
              EventHookManager.\u202D‭‬‍⁫⁪‫‬⁮‪⁫‪‎‪⁫⁬⁮⁬‫⁪‮‎⁮⁮⁬⁮⁬⁮⁫⁫⁭⁯‎‎⁭‫‏⁭⁯‭‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * -1700068608 ^ 988836725;
              continue;
            default:
              goto label_40;
          }
        }
      }
label_40:
      ++index;
label_41:
      int num8 = -628319415;
label_42:
      List<int> list;
      while (true)
      {
        int num2 = -1896072392;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 4U)
        {
          case 0:
            goto label_41;
          case 1:
            goto label_43;
          case 2:
            // ISSUE: method pointer
            list = ((IEnumerable<int>) Enumerable.Where<int>((IEnumerable<M0>) EventHookManager.processIds, (Func<M0, bool>) new Func<int, bool>((object) cDisplayClass640, __methodptr(\u003CLoadProcesses\u003Eb__0)))).ToList<int>();
            num8 = (int) num3 * -1120760539 ^ -1448228859;
            continue;
          default:
            goto label_46;
        }
      }
label_46:
      List<int>.Enumerator enumerator1 = list.GetEnumerator();
      try
      {
label_53:
        int num2 = !enumerator1.MoveNext() ? -2092620063 : (num2 = -2038948725);
        while (true)
        {
          int num3 = -1896072392;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              this.DetachHook(list);
              num2 = (int) num4 * -706891316 ^ 2029565053;
              continue;
            case 1:
              goto label_53;
            case 3:
              num2 = (int) num4 * -2086466628 ^ 249044066;
              continue;
            case 4:
              num2 = (int) num4 * 1663959552 ^ 994179146;
              continue;
            case 5:
              int current = enumerator1.Current;
              num2 = -461098011;
              continue;
            case 6:
              num2 = -2038948725;
              continue;
            default:
              goto label_60;
          }
        }
      }
      finally
      {
        enumerator1.Dispose();
label_56:
        int num2 = -1056031545;
        while (true)
        {
          int num3 = -1896072392;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_56;
            case 1:
              num2 = (int) num4 * 1638262572 ^ 1097685898;
              continue;
            default:
              goto label_59;
          }
        }
label_59:;
      }
label_60:
      using (List<int>.Enumerator enumerator2 = EventHookManager.processIds.GetEnumerator())
      {
label_98:
        if (enumerator2.MoveNext())
        {
label_70:
          int current = enumerator2.Current;
          int num2 = -2060998625;
          while (true)
          {
            int num3 = -1896072392;
            uint num4;
            bool flag;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 1:
                goto label_70;
              case 2:
                num2 = (int) num4 * -1150092190 ^ 180395193;
                continue;
              case 3:
                flag = !EventHookManager.processHooks.ContainsKey(current);
                num2 = (int) num4 * 719523164 ^ -2119573056;
                continue;
              case 4:
                if (flag)
                {
                  num2 = (int) num4 * -894693418 ^ 108069594;
                  continue;
                }
                goto label_97;
              case 5:
                num2 = (int) num4 * -1577014356 ^ 432450756;
                continue;
              case 6:
                num2 = -2080098175;
                continue;
              case 7:
                num2 = (int) num4 * -1552403308 ^ -121437833;
                continue;
              default:
                goto label_71;
            }
          }
label_71:
          // ISSUE: type reference
          IEnumerator enumerator3 = EventHookManager.\u202D‏‌‏‎‌‫‎‬‮‍‭‭⁯‪‬‍‎⁫‬⁭‮‍‫‬⁪‌‬‭‎‍‫⁬⁮‭‫‭‏⁭⁭‮(EventHookManager.\u200F‏‭‎​‬‭⁪⁪‬‫‮⁮‭‏‫⁫‌‏⁫⁬⁫‫‌‪⁮‪​⁭⁫⁬‮⁫‏‏‮⁮‏‎‬‮(EventHookManager.\u206D⁫‭‪‏⁭‬⁬‪​⁯‌⁬⁭⁭⁭​‫⁪⁬​‫‏‭⁭‮​‎‭⁮‌⁯‫⁪‭‬⁪‫⁭‮(__typeref (ZoomEventType))));
          try
          {
label_79:
            int num3 = EventHookManager.\u206D‍‫⁭‬⁬‫‪‫‪⁬‎​⁮‫‫⁪​‎⁮‭⁭‭⁫⁫‌‬‭‮‏‍⁮‌⁫‍‭‌‌⁬‏‮(enumerator3) ? -902889585 : (num3 = -963076282);
            while (true)
            {
              int num4 = -1896072392;
              uint num5;
              ZoomEventType zoomEventType;
              bool flag;
              int num6;
              switch ((num5 = (uint) (num3 ^ num4)) % 10U)
              {
                case 0:
                  num6 = zoomEventType != ZoomEventType.Undefined ? 1 : 0;
                  break;
                case 1:
                  goto label_79;
                case 3:
                  num3 = -902889585;
                  continue;
                case 4:
                  int num7 = !flag ? 1329649922 : (num7 = 1632277355);
                  int num9 = (int) num5 * 48006818;
                  num3 = num7 ^ num9;
                  continue;
                case 5:
                  if (zoomEventType != ZoomEventType.Other)
                  {
                    num3 = (int) num5 * -276895512 ^ -640850082;
                    continue;
                  }
                  num6 = 0;
                  break;
                case 6:
                  num3 = -1043922765;
                  continue;
                case 7:
                  zoomEventType = (ZoomEventType) EventHookManager.\u202D‮​‪‌⁮‬‌‍‏‬‍⁭‏⁮⁭⁬⁬‭⁮​‮⁪‮⁪‬‬‎⁪‍​​‭‭‬⁭⁭‮‪‪‮(enumerator3);
                  num3 = -1361792133;
                  continue;
                case 8:
                  this.AttachHook(current, zoomEventType);
                  num3 = (int) num5 * 531138082 ^ -649207682;
                  continue;
                case 9:
                  num3 = (int) num5 * 822628916 ^ 1949077964;
                  continue;
                default:
                  goto label_93;
              }
              flag = num6 != 0;
              num3 = -373376354;
            }
          }
          finally
          {
            IDisposable disposable = enumerator3 as IDisposable;
label_87:
            int num3 = -758444858;
            while (true)
            {
              int num4 = -1896072392;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 5U)
              {
                case 0:
                  goto label_87;
                case 1:
                  int num6 = disposable != null ? -1356230681 : (num6 = -1015862286);
                  int num7 = (int) num5 * 1695967253;
                  num3 = num6 ^ num7;
                  continue;
                case 2:
                  EventHookManager.\u200E‌‫‍⁮‪⁬⁫⁮​⁪‮⁫‪⁫⁮‮​‏‬‮‫‬‭⁫‮‎‫‬⁬‎‮‮‫⁯‮⁪⁭⁪‍‮(disposable);
                  num3 = (int) num5 * -738874033 ^ -1734943565;
                  continue;
                case 3:
                  num3 = (int) num5 * -1748176488 ^ -900272892;
                  continue;
                default:
                  goto label_92;
              }
            }
label_92:;
          }
label_93:;
        }
        else
          goto label_99;
label_94:
        int num10 = -777173523;
label_95:
        int num11 = -1896072392;
        uint num12;
        switch ((num12 = (uint) (num10 ^ num11)) % 4U)
        {
          case 0:
            return;
          case 1:
            break;
          case 2:
            goto label_94;
          case 3:
            goto label_98;
          default:
            return;
        }
label_97:
        num10 = -98330185;
        goto label_95;
label_99:
        num10 = -2093578632;
        goto label_95;
      }
label_43:
      if (index >= processArray1.Length)
      {
        num8 = -1218841238;
        goto label_42;
      }
      else
        goto label_6;
    }

    private Process GetProcByID(int id)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EventHookManager.\u003C\u003Ec__DisplayClass65_0 cDisplayClass650 = new EventHookManager.\u003C\u003Ec__DisplayClass65_0();
label_1:
      int num1 = -66528358;
      Process process;
      while (true)
      {
        int num2 = -425353575;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass650.id = id;
            num1 = (int) num3 * 2113068060 ^ 1487054032;
            continue;
          case 2:
            // ISSUE: method pointer
            process = (Process) Enumerable.FirstOrDefault<Process>((IEnumerable<M0>) EventHookManager.\u202B⁯⁭⁫⁯‫⁮⁯‮⁫‭​‪‎‬⁪‭⁭‫‫⁮‫⁯‌‪⁭⁪‮​⁬‮‎‭⁭⁯‏‏‬‭‮(), (Func<M0, bool>) new Func<Process, bool>((object) cDisplayClass650, __methodptr(\u003CGetProcByID\u003Eb__0)));
            num1 = (int) num3 * 1452899459 ^ -774376579;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -382510022 ^ 980094711;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return process;
    }

    private void CreateExistingWindowEvents(int processId)
    {
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        EventHookManager.\u003C\u003Ec__DisplayClass66_0 cDisplayClass660 = new EventHookManager.\u003C\u003Ec__DisplayClass66_0();
        List<IntPtr> numList = new List<IntPtr>();
label_2:
        int num1 = 1013126537;
        Process procById;
        while (true)
        {
          int num2 = 1483096446;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 1:
              procById = this.GetProcByID(processId);
              // ISSUE: reference to a compiler-generated field
              cDisplayClass660.handleThreads = new Dictionary<IntPtr, int>();
              num1 = (int) num3 * 1937220047 ^ -1787545116;
              continue;
            case 2:
              if (flag)
              {
                num1 = (int) num3 * 1937856523 ^ 1004780514;
                continue;
              }
              goto label_45;
            case 3:
              if (procById == null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * -578768572 ^ -1451528397;
              continue;
            case 4:
              goto label_2;
            case 5:
              num4 = !EventHookManager.\u202B‏‬‏​‪⁬‎⁬‏⁪‎‍‫‌‌‏⁬‬⁯‍‌‬⁯⁭⁯‬⁫‭⁭‎‫‮⁮‌‮⁫‍⁫‪‮(procById) ? 1 : 0;
              break;
            default:
              goto label_12;
          }
          flag = num4 != 0;
          num1 = 1164079370;
        }
label_12:
        IEnumerator enumerator1 = EventHookManager.\u206D‎⁮‭‏⁪‌⁯‪⁪‮‏⁪⁫‍‫‪‭⁭‮‭⁮‍‍⁭⁫‬⁬⁫‮‎‮‪⁬‮‏⁯​‍‎‮((ReadOnlyCollectionBase) EventHookManager.\u202D⁯‍⁯‏​⁪‫⁮‫⁮‬‏‍‌⁯‪‬​⁮⁬⁯⁫⁮‬⁫‬‪⁪‏⁯⁭⁬⁮⁯‎‭‍⁭‮(procById));
        try
        {
label_18:
          int num2 = !EventHookManager.\u206D‍‫⁭‬⁬‫‪‫‪⁬‎​⁮‫‫⁪​‎⁮‭⁭‭⁫⁫‌‬‭‮‏‍⁮‌⁫‍‭‌‌⁬‏‮(enumerator1) ? 683685336 : (num2 = 1782417155);
          while (true)
          {
            int num3 = 1483096446;
            uint num4;
            // ISSUE: variable of a compiler-generated type
            EventHookManager.\u003C\u003Ec__DisplayClass66_1 cDisplayClass661;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                num2 = (int) num4 * -1486624330 ^ -209344085;
                continue;
              case 1:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass661 = new EventHookManager.\u003C\u003Ec__DisplayClass66_1();
                num2 = 1572155842;
                continue;
              case 2:
                goto label_18;
              case 4:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass661.thread = (ProcessThread) EventHookManager.\u202D‮​‪‌⁮‬‌‍‏‬‍⁭‏⁮⁭⁬⁬‭⁮​‮⁪‮⁪‬‬‎⁪‍​​‭‭‬⁭⁭‮‪‪‮(enumerator1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                NativeMethods.EnumThreadWindows(EventHookManager.\u206B⁯⁫⁪‍⁪⁫⁭⁪⁭⁪​⁮‎‫⁭⁪‭‮⁯⁫⁮‭‪‫‍⁪‎‫‮‌‍‌‍⁬‏‫⁭‏‍‮(EventHookManager.\u202E‪‭⁪⁫‬‫⁬‍‎⁯⁫‭⁫⁯⁮⁪‌‏​‬‭⁬‬‎​⁯‏⁭‍‍⁫‏⁪‏‪‬⁮​⁯‮(cDisplayClass661.thread)), new NativeMethods.EnumThreadWindowsProc(cDisplayClass661.\u003CCreateExistingWindowEvents\u003Eb__0), 0);
                num2 = (int) num4 * 798804262 ^ 334763448;
                continue;
              case 5:
                num2 = 1782417155;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass661.CS\u0024\u003C\u003E8__locals1 = cDisplayClass660;
                num2 = (int) num4 * -402379670 ^ -2033450072;
                continue;
              default:
                goto label_28;
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator1 as IDisposable;
label_22:
          int num2 = 1549991685;
          while (true)
          {
            int num3 = 1483096446;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                EventHookManager.\u200E‌‫‍⁮‪⁬⁫⁮​⁪‮⁫‪⁫⁮‮​‏‬‮‫‬‭⁫‮‎‫‬⁬‎‮‮‫⁯‮⁪⁭⁪‍‮(disposable);
                num2 = (int) num4 * -771739783 ^ 891443693;
                continue;
              case 1:
                int num5 = disposable == null ? -160717536 : (num5 = -1765128056);
                int num6 = (int) num4 * -830538989;
                num2 = num5 ^ num6;
                continue;
              case 2:
                goto label_22;
              case 3:
                num2 = (int) num4 * 1741644324 ^ -2119443279;
                continue;
              default:
                goto label_27;
            }
          }
label_27:;
        }
label_28:
        // ISSUE: reference to a compiler-generated field
        Dictionary<IntPtr, int>.KeyCollection.Enumerator enumerator2 = cDisplayClass660.handleThreads.Keys.GetEnumerator();
        try
        {
label_33:
          int num2 = enumerator2.MoveNext() ? 2013429795 : (num2 = 836418116);
          while (true)
          {
            int num3 = 1483096446;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                goto label_33;
              case 1:
                IntPtr current = enumerator2.Current;
                // ISSUE: reference to a compiler-generated field
                this.CreateExistingWindowEvent(this.hookHandle, current, processId, cDisplayClass660.handleThreads[current]);
                num2 = 203282292;
                continue;
              case 3:
                num2 = (int) num4 * 1265436883 ^ 447973049;
                continue;
              case 4:
                num2 = (int) num4 * -963650616 ^ 1077814259;
                continue;
              case 5:
                num2 = 2013429795;
                continue;
              default:
                goto label_41;
            }
          }
        }
        finally
        {
          enumerator2.Dispose();
label_37:
          int num2 = 1732885199;
          while (true)
          {
            int num3 = 1483096446;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num2 = (int) num4 * 508256177 ^ -382661638;
                continue;
              case 2:
                goto label_37;
              default:
                goto label_40;
            }
          }
label_40:;
        }
label_41:
label_42:
        int num7 = 637488926;
label_43:
        int num8 = 1483096446;
        uint num9;
        switch ((num9 = (uint) (num7 ^ num8)) % 3U)
        {
          case 0:
            goto label_42;
          case 1:
            break;
          case 2:
            return;
          default:
            return;
        }
label_45:
        num7 = 317566344;
        goto label_43;
      }
      catch (Exception ex)
      {
label_48:
        int num1 = 427405308;
        while (true)
        {
          int num2 = 1483096446;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_48;
            case 1:
              goto label_46;
            case 2:
              EventHookManager.\u202D‭‬‍⁫⁪‫‬⁮‪⁫‪‎‪⁫⁬⁮⁬‫⁪‮‎⁮⁮⁬⁮⁬⁮⁫⁫⁭⁯‎‎⁭‫‏⁭⁯‭‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -664518494 ^ 1970062781;
              continue;
            default:
              goto label_44;
          }
        }
label_44:
        return;
label_46:;
      }
    }

    private void CreateExistingWindowEvent(IntPtr hookHandle, IntPtr windowHandle, int processId, int threadId)
    {
      try
      {
        ZoomEvent zoomEvent = new ZoomEvent(hookHandle, windowHandle, ZoomEventType.Create, processId, EventHookManager.\u206B⁯⁫⁪‍⁪⁫⁭⁪⁭⁪​⁮‎‫⁭⁪‭‮⁯⁫⁮‭‪‫‍⁪‎‫‮‌‍‌‍⁬‏‫⁭‏‍‮(threadId), 0U);
        if (zoomEvent != null)
        {
          object hookLocker = EventHookManager.hookLocker;
          bool flag = false;
          try
          {
            EventHookManager.\u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮(hookLocker, ref flag);
label_4:
            int num1 = -262042589;
            while (true)
            {
              int num2 = -295157632;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 5U)
              {
                case 0:
                  EventHookManager.hookQueue.Enqueue(zoomEvent);
                  num1 = (int) num3 * 757511008 ^ -748517146;
                  continue;
                case 1:
                  num1 = (int) num3 * 23374224 ^ 220383089;
                  continue;
                case 3:
                  num1 = (int) num3 * -594196093 ^ -232714869;
                  continue;
                case 4:
                  goto label_4;
                default:
                  goto label_16;
              }
            }
          }
          finally
          {
            if (flag)
            {
label_10:
              int num1 = -2101128413;
              while (true)
              {
                int num2 = -295157632;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 4U)
                {
                  case 0:
                    goto label_10;
                  case 1:
                    num1 = (int) num3 * -870151907 ^ -1028192449;
                    continue;
                  case 3:
                    EventHookManager.\u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮(hookLocker);
                    num1 = (int) num3 * 1533353128 ^ 753540209;
                    continue;
                  default:
                    goto label_15;
                }
              }
            }
label_15:;
          }
label_16:;
        }
        else
          goto label_20;
label_17:
        int num4 = -267499524;
label_18:
        int num5 = -295157632;
        uint num6;
        switch ((num6 = (uint) (num4 ^ num5)) % 3U)
        {
          case 0:
            goto label_17;
          case 1:
            return;
          case 2:
            break;
          default:
            return;
        }
label_20:
        num4 = -551858752;
        goto label_18;
      }
      catch (Exception ex)
      {
      }
    }

    private void KeyboardHookManager_KeyPress(object sender, KeyPressEventArgs e)
    {
label_1:
      int num1 = -75147805;
      while (true)
      {
        int num2 = -138029649;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.lastKeyPress = DateTime.Now;
            num1 = (int) num3 * 1987713308 ^ 2127747818;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void KeyboardHookManager_KeyUp(object sender, KeyEventArgs e)
    {
label_1:
      int num1 = -578831109;
      while (true)
      {
        int num2 = -281061273;
        uint num3;
        bool flag1;
        bool flag2;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 26U)
        {
          case 0:
            num1 = (int) num3 * -203299764 ^ -2124486216;
            continue;
          case 1:
            num1 = (int) num3 * -349452842 ^ 1180490098;
            continue;
          case 2:
            num1 = (int) num3 * -1679427380 ^ 267974084;
            continue;
          case 3:
            this.IsAltPressed = false;
            num1 = (int) num3 * 1115011663 ^ -1332677053;
            continue;
          case 4:
            num4 = EventHookManager.\u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮(e) == Keys.LControlKey ? 1 : 0;
            goto label_23;
          case 5:
            if (EventHookManager.\u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮(e) != Keys.ControlKey)
            {
              num1 = (int) num3 * -751106876 ^ 1893942767;
              continue;
            }
            goto label_20;
          case 6:
            this.PublishEvent(e);
            num1 = (int) num3 * -1447064774 ^ -715090962;
            continue;
          case 7:
            this.IsShiftPressed = false;
            num1 = (int) num3 * -1978213813 ^ -1556356982;
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num3 * -2019860551 ^ 903269563;
            continue;
          case 10:
            num5 = EventHookManager.\u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮(e) == Keys.ShiftKey ? 1 : 0;
            goto label_10;
          case 11:
            if (EventHookManager.\u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮(e) != Keys.Control)
            {
              num1 = (int) num3 * -1530618004 ^ -2123012866;
              continue;
            }
            goto label_20;
          case 12:
            num1 = (int) num3 * 168456432 ^ 1729117734;
            continue;
          case 13:
            num6 = EventHookManager.\u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮(e) == Keys.Alt ? 1 : 0;
            goto label_38;
          case 14:
            num1 = (int) num3 * 930696604 ^ -1717329069;
            continue;
          case 15:
            goto label_21;
          case 16:
            num1 = (int) num3 * 1449844729 ^ -974357108;
            continue;
          case 17:
            if (!this.IsShiftPressed)
            {
              num5 = 0;
              goto label_10;
            }
            else
            {
              num1 = -955432948;
              continue;
            }
          case 18:
            if (EventHookManager.\u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮(e) != Keys.LShiftKey)
            {
              num1 = (int) num3 * -1092805176 ^ 975087307;
              continue;
            }
            break;
          case 19:
            if (EventHookManager.\u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮(e) != Keys.Shift)
            {
              num1 = (int) num3 * 605308270 ^ 147269923;
              continue;
            }
            break;
          case 20:
            int num7 = flag2 ? -130841100 : (num7 = -1197403566);
            int num8 = (int) num3 * 743542367;
            num1 = num7 ^ num8;
            continue;
          case 21:
            this.IsCtrlPressed = false;
            num1 = (int) num3 * -768498715 ^ -1855206084;
            continue;
          case 22:
            if (!this.IsAltPressed)
            {
              num6 = 0;
              goto label_38;
            }
            else
            {
              num1 = (int) num3 * 1292832903 ^ -1869324300;
              continue;
            }
          case 23:
            this.lastKeyPress = DateTime.Now;
            num1 = (int) num3 * 130834737 ^ -113009144;
            continue;
          case 24:
            int num9 = !flag1 ? 441469464 : (num9 = 915462487);
            int num10 = (int) num3 * 1450384451;
            num1 = num9 ^ num10;
            continue;
          case 25:
            if (!this.IsCtrlPressed)
            {
              num4 = 0;
              goto label_23;
            }
            else
            {
              num1 = -1590648848;
              continue;
            }
          default:
            goto label_8;
        }
        num5 = 1;
label_10:
        int num11;
        num1 = num11 = num5 == 0 ? -424476952 : (num11 = -242579603);
        continue;
label_20:
        num4 = 1;
label_23:
        flag1 = num4 != 0;
        num1 = -1911864883;
        continue;
label_38:
        flag2 = num6 != 0;
        num1 = -57696987;
      }
label_8:
      return;
label_21:;
    }

    private void KeyboardHookManager_KeyDown(object sender, KeyEventArgs e)
    {
      if (EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) == Keys.LControlKey)
        goto label_25;
label_1:
      int num1 = 205621639;
label_2:
      bool flag1;
      while (true)
      {
        int num2 = 1780453165;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 23U)
        {
          case 0:
            if (EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) != Keys.LShiftKey)
            {
              num1 = (int) num3 * 1457297948 ^ 1413085489;
              continue;
            }
            break;
          case 1:
            this.IsAltPressed = true;
            num1 = (int) num3 * 1486802612 ^ -1286392960;
            continue;
          case 2:
            if (EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) != Keys.RShiftKey)
            {
              num1 = (int) num3 * 71568445 ^ -941876817;
              continue;
            }
            break;
          case 3:
            num1 = (int) num3 * -894620469 ^ 1787815444;
            continue;
          case 4:
            int num5 = !flag2 ? 1347630943 : (num5 = 885948432);
            int num6 = (int) num3 * -1994426109;
            num1 = num5 ^ num6;
            continue;
          case 5:
            num4 = EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) == Keys.ShiftKey ? 1 : 0;
            goto label_9;
          case 6:
            if (EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) != Keys.Control)
            {
              num1 = (int) num3 * 1761223390 ^ -733526047;
              continue;
            }
            goto label_25;
          case 7:
            goto label_3;
          case 8:
            int num7 = !flag1 ? -823354969 : (num7 = -304258261);
            int num8 = (int) num3 * 563496774;
            num1 = num7 ^ num8;
            continue;
          case 9:
            num1 = (int) num3 * 1067153243 ^ 1461327272;
            continue;
          case 10:
            num1 = (int) num3 * -1318916282 ^ 108008488;
            continue;
          case 11:
            num1 = (int) num3 * 1694534788 ^ 863290261;
            continue;
          case 12:
            flag2 = EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) == Keys.Alt;
            num1 = 870444614;
            continue;
          case 13:
            num1 = (int) num3 * 634198150 ^ 335579401;
            continue;
          case 14:
            goto label_1;
          case 15:
            goto label_24;
          case 16:
            if (EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) != Keys.ControlKey)
            {
              num1 = (int) num3 * -1547870494 ^ 1773895459;
              continue;
            }
            goto label_25;
          case 17:
            this.PublishEvent(e);
            num1 = 312590011;
            continue;
          case 18:
            this.IsShiftPressed = true;
            num1 = (int) num3 * -1993495502 ^ 689334267;
            continue;
          case 19:
            if (EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) != Keys.Shift)
            {
              num1 = 1298294184;
              continue;
            }
            break;
          case 20:
            num1 = (int) num3 * -1276365929 ^ -582075508;
            continue;
          case 21:
            num1 = (int) num3 * 1354100004 ^ 11020319;
            continue;
          case 22:
            this.IsCtrlPressed = true;
            num1 = (int) num3 * 713173025 ^ -405406445;
            continue;
          default:
            goto label_34;
        }
        num4 = 1;
label_9:
        int num9;
        num1 = num9 = num4 != 0 ? 845623161 : (num9 = 1242573421);
      }
label_34:
      return;
label_3:
      return;
label_24:
      int num10 = EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) == Keys.RControlKey ? 1 : 0;
      goto label_26;
label_25:
      num10 = 1;
label_26:
      flag1 = num10 != 0;
      num1 = 784677945;
      goto label_2;
    }

    private void PublishEvent(KeyEventArgs e)
    {
      bool flag1 = !ZoomZoom.Properties.Settings.Default.EnableKeyboardShortcuts;
label_1:
      int num1 = -574538496;
      while (true)
      {
        int num2 = -1290260169;
        uint num3;
        bool flag2;
        bool flag3;
        bool flag4;
        string str;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 36U)
        {
          case 0:
            num1 = (int) num3 * 262298497 ^ 856165851;
            continue;
          case 1:
            goto label_3;
          case 2:
            num4 = EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) == Keys.A ? 1 : 0;
            goto label_47;
          case 3:
            this.Trace(TraceType.Application, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3387713678U));
            num1 = (int) num3 * 24204466 ^ 1585685593;
            continue;
          case 4:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityCanceledEvent>()).Publish(new ActivityEventBaseArguments(this.Engine.ActiveActivity, ""));
            num1 = -1515507609;
            continue;
          case 5:
            this.Trace(TraceType.Application, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1391385213U));
            num1 = (int) num3 * -1487729635 ^ 32061464;
            continue;
          case 6:
            num1 = (int) num3 * -1593975919 ^ -1892739964;
            continue;
          case 7:
            int num7 = !flag3 ? -878867664 : (num7 = -1530191943);
            int num8 = (int) num3 * 1096940837;
            num1 = num7 ^ num8;
            continue;
          case 8:
            num1 = (int) num3 * -1678619614 ^ -34530337;
            continue;
          case 9:
            ((CompositePresentationEvent<SubscriptionToken>) this._eventAggregator.GetEvent<ViewEvent>()).Publish((SubscriptionToken) null);
            num1 = (int) num3 * 1718989741 ^ -1033113573;
            continue;
          case 10:
            num1 = (int) num3 * -1478479405 ^ 1295268280;
            continue;
          case 11:
            flag2 = this.Engine.ActiveActivity != null;
            num1 = (int) num3 * 845572649 ^ -268926825;
            continue;
          case 12:
            if (this.IsShiftPressed)
            {
              num1 = -1913603668;
              continue;
            }
            break;
          case 13:
            str = this.Engine.ActiveActivity.Guid;
            num1 = (int) num3 * -1065228319 ^ -913037325;
            continue;
          case 14:
            num1 = (int) num3 * 2029930235 ^ -1529041938;
            continue;
          case 15:
            ((CompositePresentationEvent<KeyEventData>) this._eventAggregator.GetEvent<KeyPressedEvent>()).Publish(this.keyData);
            num1 = (int) num3 * 428509496 ^ 609378869;
            continue;
          case 16:
            num5 = EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) == Keys.C ? 1 : 0;
            goto label_6;
          case 17:
            this.Trace(TraceType.Application, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(798945375U));
            num1 = (int) num3 * -988813129 ^ -2127542610;
            continue;
          case 18:
            this.keyData.IsShiftDown = this.IsShiftPressed;
            this.keyData.Keys = EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e);
            num1 = (int) num3 * 677157221 ^ -1095372011;
            continue;
          case 19:
            num1 = (int) num3 * -413323656 ^ -206327922;
            continue;
          case 20:
            ((CompositePresentationEvent<object>) this._eventAggregator.GetEvent<QuickAddMessageContentEvent>()).Publish((object) null);
            num1 = (int) num3 * 1670579374 ^ 1941428958;
            continue;
          case 21:
            num1 = (int) num3 * -1200486531 ^ -1031531646;
            continue;
          case 22:
            num1 = (int) num3 * -1612100351 ^ 1526765863;
            continue;
          case 23:
            int num9 = flag2 ? 200444722 : (num9 = 192975319);
            int num10 = (int) num3 * -168869860;
            num1 = num9 ^ num10;
            continue;
          case 24:
            num1 = (int) num3 * 506924144 ^ -253911864;
            continue;
          case 25:
            num1 = (int) num3 * -974574819 ^ 824390562;
            continue;
          case 26:
            this.lastKeyPress = DateTime.Now;
            if (this.IsCtrlPressed)
            {
              num1 = -1204365747;
              continue;
            }
            num4 = 0;
            goto label_47;
          case 27:
            if (this.IsCtrlPressed)
            {
              num1 = (int) num3 * 1867060637 ^ 1490506680;
              continue;
            }
            break;
          case 28:
            num6 = EventHookManager.\u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮(e) == Keys.Q ? 1 : 0;
            goto label_36;
          case 29:
            goto label_1;
          case 30:
            int num11 = !flag4 ? 678845641 : (num11 = 63581936);
            int num12 = (int) num3 * 38539109;
            num1 = num11 ^ num12;
            continue;
          case 31:
            int num13 = !flag1 ? 1721820433 : (num13 = 811165748);
            int num14 = (int) num3 * 1138535260;
            num1 = num13 ^ num14;
            continue;
          case 32:
            if (this.IsCtrlPressed)
            {
              num1 = -1768133305;
              continue;
            }
            num6 = 0;
            goto label_36;
          case 33:
            num1 = (int) num3 * -1422502960 ^ -475304820;
            continue;
          case 34:
            str = "";
            num1 = (int) num3 * 78102677 ^ -868069710;
            continue;
          case 35:
            this.keyData.IsAltDown = this.IsAltPressed;
            this.keyData.IsCtrlDown = this.IsCtrlPressed;
            num1 = -1383381359;
            continue;
          default:
            goto label_48;
        }
        num5 = 0;
label_6:
        int num15;
        num1 = num15 = num5 != 0 ? -497453351 : (num15 = -1061088804);
        continue;
label_36:
        flag3 = num6 != 0;
        num1 = -178464316;
        continue;
label_47:
        flag4 = num4 != 0;
        num1 = -1983551187;
      }
label_48:
      return;
label_3:;
    }

    internal List<Keys> GetKeysDown()
    {
      List<Keys> keysList1 = new List<Keys>();
label_1:
      int num1 = 1978550465;
      List<Keys> keysList2;
      while (true)
      {
        int num2 = 329424186;
        uint num3;
        bool isAltPressed;
        bool isCtrlPressed;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            num1 = (int) num3 * -591520324 ^ 963003930;
            continue;
          case 1:
            num1 = (int) num3 * 962276305 ^ 977576049;
            continue;
          case 2:
            keysList1.Add(Keys.Control);
            num1 = (int) num3 * -1245883164 ^ -2056369601;
            continue;
          case 4:
            int num4;
            num1 = num4 = !this.IsShiftPressed ? 955998844 : (num4 = 294013325);
            continue;
          case 5:
            num1 = (int) num3 * 1875008649 ^ 1936316555;
            continue;
          case 6:
            int num5 = !isCtrlPressed ? 302609749 : (num5 = 455613580);
            int num6 = (int) num3 * -1268658290;
            num1 = num5 ^ num6;
            continue;
          case 7:
            keysList1.Add(Keys.Alt);
            num1 = (int) num3 * 203651069 ^ -948734165;
            continue;
          case 8:
            num1 = (int) num3 * -1536847530 ^ -939579400;
            continue;
          case 9:
            goto label_1;
          case 10:
            int num7 = isAltPressed ? -1823058520 : (num7 = -2068655649);
            int num8 = (int) num3 * 1330807341;
            num1 = num7 ^ num8;
            continue;
          case 11:
            keysList1.Add(Keys.Shift);
            num1 = (int) num3 * 1487709810 ^ 1342238604;
            continue;
          case 12:
            num1 = (int) num3 * -1374132142 ^ 1345276243;
            continue;
          case 13:
            isAltPressed = this.IsAltPressed;
            num1 = (int) num3 * 1044116272 ^ 724389859;
            continue;
          case 14:
            num1 = (int) num3 * 2082335025 ^ 420509283;
            continue;
          case 15:
            keysList2 = keysList1;
            num1 = 2021317073;
            continue;
          case 16:
            isCtrlPressed = this.IsCtrlPressed;
            num1 = 1930922681;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return keysList2;
    }

    static void \u202E‏‪⁭‏‮‫⁯⁮‪‭⁯⁯‌‏‌⁮​‌‬⁬‏⁭⁪‫⁭⁬⁫​⁭‎​‬​​⁭⁪‌⁮‏‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200E‏‏‌⁫‭‌‌‎⁪⁯‮‍‎‭⁭‮⁭‎‪‭‪‌‫‎⁫⁪⁮‮‎⁫‪‮‌⁬‏‫‎‮‌‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static void \u202D‭‬‍⁫⁪‫‬⁮‪⁫‪‎‪⁫⁬⁮⁬‫⁪‮‎⁮⁮⁬⁮⁬⁮⁫⁫⁭⁯‎‎⁭‫‏⁭⁯‭‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static System.Type \u206D⁫‭‪‏⁭‬⁬‪​⁯‌⁬⁭⁭⁭​‫⁪⁬​‫‏‭⁭‮​‎‭⁮‌⁯‫⁪‭‬⁪‫⁭‮([In] RuntimeTypeHandle obj0)
    {
      return System.Type.GetTypeFromHandle(obj0);
    }

    static Array \u200F‏‭‎​‬‭⁪⁪‬‫‮⁮‭‏‫⁫‌‏⁫⁬⁫‫‌‪⁮‪​⁭⁫⁬‮⁫‏‏‮⁮‏‎‬‮([In] System.Type obj0)
    {
      return Enum.GetValues(obj0);
    }

    static IEnumerator \u202D‏‌‏‎‌‫‎‬‮‍‭‭⁯‪‬‍‎⁫‬⁭‮‍‫‬⁪‌‬‭‎‍‫⁬⁮‭‫‭‏⁭⁭‮([In] Array obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u202D‮​‪‌⁮‬‌‍‏‬‍⁭‏⁮⁭⁬⁬‭⁮​‮⁪‮⁪‬‬‎⁪‍​​‭‭‬⁭⁭‮‪‪‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static bool \u206D‍‫⁭‬⁬‫‪‫‪⁬‎​⁮‫‫⁪​‎⁮‭⁭‭⁫⁫‌‬‭‮‏‍⁮‌⁫‍‭‌‌⁬‏‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u200E‌‫‍⁮‪⁬⁫⁮​⁪‮⁫‪⁫⁮‮​‏‬‮‫‬‭⁫‮‎‫‬⁬‎‮‮‫⁯‮⁪⁭⁪‍‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static MouseButtons \u200D‌‬‪⁪‍⁯‪‬⁮⁭​⁬‌⁬⁮‌​​‏‫‪​⁯‍⁪⁯‌‍‍​‎‬‌‮​‏‪‪‪‮([In] MouseEventArgs obj0)
    {
      return obj0.Button;
    }

    static int \u202D​​⁯‮⁪‎‬‪‭‏‪‍‭‍⁬⁪⁮‪‬‍‌‏⁯​⁬‏‫⁬​⁭⁫​‎‪⁮‍‫‍⁪‮([In] MouseEventArgs obj0)
    {
      return obj0.X;
    }

    static int \u202B⁫⁭‫‭⁬⁭‏⁯⁭‍⁫⁬‌‪⁬‭⁭‭⁬⁬⁫⁮⁪‪‎‫‮‭⁫⁬⁪⁪‌‭‎⁪‪⁫⁯‮([In] MouseEventArgs obj0)
    {
      return obj0.Y;
    }

    static bool \u206F‎⁯⁯‌⁬​‌‫⁫‎‏‍​‫​⁮‬⁪‭⁯‮​‍‍‫‬⁬‎‬‍⁫‬‏‪⁫⁬‬​‎‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static string[] \u206B⁬‮⁮‎⁬⁮​⁯‍⁭⁭‪⁯‭‬⁪⁫‬⁪‬⁫‭⁬‮⁪⁮‍‫​⁯‭⁯⁭‌⁭⁫‮‭⁯‮([In] string obj0, [In] char[] obj1)
    {
      return obj0.Split(obj1);
    }

    static void \u206A⁯‪‫⁪‏‫‫‮‭‮‍⁮⁫⁮⁭‮‍‍⁬‮⁫‍⁫‭‮‫‍‍‍‫‫‌‮⁮‫⁯⁪⁯⁮‮([In] string obj0)
    {
      SendKeys.SendWait(obj0);
    }

    static void \u202C‌⁪‫‮‬⁮‎⁫⁬‮⁭⁫⁬‪⁫‏⁯⁫‮‪⁬⁫​​⁪⁪‮‬‍‬​⁯⁪⁬‮‬⁭⁮‎‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static Exception \u200F‏⁬‬⁬‬‮⁬‪⁫‬‪⁯⁭‍‪⁬​‬⁯‫⁪‎‭‪‬⁬‬⁭⁫⁫⁬⁭⁮‎‎‌​⁫‎‮([In] string obj0)
    {
      return new Exception(obj0);
    }

    static uint \u206B⁯⁫⁪‍⁪⁫⁭⁪⁭⁪​⁮‎‫⁭⁪‭‮⁯⁫⁮‭‪‫‍⁪‎‫‮‌‍‌‍⁬‏‫⁭‏‍‮([In] int obj0)
    {
      return Convert.ToUInt32(obj0);
    }

    static string \u206F‏‭‪‪‎‎⁪‪‫‫​‬‌​‪‪‬‎⁫⁮⁫⁭‭⁪⁮‮⁯‏‮‬‌​‮‮‭⁫⁯‬‎‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u206F​‭⁫⁯‫​⁪‏⁯⁮‪​⁫⁯‌⁭‏⁭⁮‎‬⁭‮⁫⁭‫⁮‬‮⁫⁮⁮‫⁫‫⁭⁫⁬‏‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static Process[] \u202B⁯⁭⁫⁯‫⁮⁯‮⁫‭​‪‎‬⁪‭⁭‫‫⁮‫⁯‌‪⁭⁪‮​⁬‮‎‭⁭⁯‏‏‬‭‮()
    {
      return Process.GetProcesses();
    }

    static int \u200D‭‏‬⁬‬‫‎‎‏‬‪‬‪⁫⁭‪​⁮⁫‮⁪⁪⁭‪‍‍⁬‎‍⁭‍​‎‏⁫⁬‎⁬⁪‮([In] Process obj0)
    {
      return obj0.Id;
    }

    static string \u206D⁭​‍‪⁫‭‮⁭‪⁮⁬‌⁫​‏⁫⁬‫⁭⁫‫⁯‌‬‎‍‪‍‮⁫‪‬‎⁯‌​⁬⁫‎‮([In] Process obj0)
    {
      return obj0.ProcessName;
    }

    static string \u200C‬‍​‫‪​​‌⁬⁫​‫⁪‏‎​‬‌‏‫‎⁭‭⁫​⁬⁬⁪‮⁪⁮‬‬‍‮‫⁫‎‬‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static bool \u202B‪⁯⁯⁪‎⁫​‪⁮‪⁯⁪​⁯‬⁫⁭‎‭‍‫⁮⁭‫‫‎⁫‎⁪⁯​‬‎‏‭​‮​⁫‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u202B‏‬‏​‪⁬‎⁬‏⁪‎‍‫‌‌‏⁬‬⁯‍‌‬⁯⁭⁯‬⁫‭⁭‎‫‮⁮‌‮⁫‍⁫‪‮([In] Process obj0)
    {
      return obj0.HasExited;
    }

    static ProcessThreadCollection \u202D⁯‍⁯‏​⁪‫⁮‫⁮‬‏‍‌⁯‪‬​⁮⁬⁯⁫⁮‬⁫‬‪⁪‏⁯⁭⁬⁮⁯‎‭‍⁭‮([In] Process obj0)
    {
      return obj0.Threads;
    }

    static IEnumerator \u206D‎⁮‭‏⁪‌⁯‪⁪‮‏⁪⁫‍‫‪‭⁭‮‭⁮‍‍⁭⁫‬⁬⁫‮‎‮‪⁬‮‏⁯​‍‎‮([In] ReadOnlyCollectionBase obj0)
    {
      return obj0.GetEnumerator();
    }

    static int \u202E‪‭⁪⁫‬‫⁬‍‎⁯⁫‭⁫⁯⁮⁪‌‏​‬‭⁬‬‎​⁯‏⁭‍‍⁫‏⁪‏‪‬⁮​⁯‮([In] ProcessThread obj0)
    {
      return obj0.Id;
    }

    static Keys \u200C⁪‮⁬‮​⁫‬⁫‏‌‌⁪⁮​​​‍‮⁮⁭‭​⁯​⁮‎‪⁫‫‫‌⁮‬‫⁬‍‮‎‍‮([In] KeyEventArgs obj0)
    {
      return obj0.KeyData;
    }

    static Keys \u202D‭‮‍‏⁫‪⁭‭⁭‪‏⁭⁬‏⁭‭⁫⁫‍‌‎‫‬‌‏⁫‬⁯‏‎​‏⁫⁫‬‬⁬‎⁬‮([In] KeyEventArgs obj0)
    {
      return obj0.KeyCode;
    }

    static object \u202B⁬‪‪‬‫‏⁫⁪⁫‫⁭⁮​⁬⁭‏‍⁯⁬‎‬⁫⁯‭‭⁮‍⁪⁭‭⁫⁫⁯⁪‌​​‭⁭‮()
    {
      return new object();
    }

    private delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

    private delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);

    private struct MSG
    {
      public IntPtr Hwnd;
      public uint Message;
      public IntPtr WParam;
      public IntPtr LParam;
      public uint Time;
      public System.Drawing.Point Point;
    }

    private struct Point
    {
      public int X;
      public int Y;
    }

    [Flags]
    internal enum SetWinEventHookParameter
    {
      WINEVENT_INCONTEXT = 4,
      WINEVENT_OUTOFCONTEXT = 0,
      WINEVENT_SKIPOWNPROCESS = 2,
      WINEVENT_SKIPOWNTHREAD = 1,
    }

    private struct KeyboardHookStruct
    {
      public int VirtualKeyCode;
      public int ScanCode;
      public int Flags;
      public int Time;
      public int ExtraInfo;
    }
  }
}
