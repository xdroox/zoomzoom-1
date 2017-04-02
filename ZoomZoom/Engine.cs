// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Engine
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using ZoomZoom.Common;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Core;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Images;
using ZoomZoom.Models.Meetings;
using ZoomZoom.Properties;
using ZoomZoom.Views;

namespace ZoomZoom
{
  public sealed class Engine : ObservableObject
  {
    private static readonly ILog log = Engine.\u206B⁪‫‌‮⁭⁮⁮‬‎⁮‭⁮‬‫‬⁮‍⁪‍⁮⁬⁭‪‭⁮⁪⁭⁮‫‮‭​⁫‎⁯‪‭‌‎‮(Engine.\u202D⁪⁭‏‎‪​⁫‬​‫‏‪‏⁬⁯‭‫‌‬‮⁫⁮⁯‏⁬⁫‫​⁫‎​‮⁮⁮⁮⁪⁭‬‌‮((MemberInfo) Engine.\u202D‮‪⁪⁬‍⁬⁬⁭‪‍⁬‭⁯‍⁯⁪⁮‍‪​​‌‮‌‪⁯‪​‪‮⁯‭⁪⁮⁪⁫‫⁮‎‮()));
    private Dispatcher userInterfaceDispatcher = (Dispatcher) null;
    private EngineView engineView = (EngineView) null;
    private ImageHistoryView imageHistoryView = (ImageHistoryView) null;
    private WindowSelector selectorWindow = (WindowSelector) null;
    private volatile ZoomMeeting activeMeeting = (ZoomMeeting) null;
    private volatile ZoomWindow activeMeetingWindow = (ZoomWindow) null;
    private volatile ActivityBase activeActivity = (ActivityBase) null;
    private SharedData sharedData = (SharedData) null;
    private volatile bool errorDetected = false;
    internal IntPtr mainProcessWindow = IntPtr.Zero;
    private volatile string logMessage = string.Empty;
    private MachineState machineState = MachineState.Undetermined;
    private EngineState engineState = EngineState.Undefined;
    private bool activityQueuePurgeRequested = false;
    private HighlightInfo highlightTarget = (HighlightInfo) null;
    private TrackingWindow trackingWindow = (TrackingWindow) null;
    public const string StaticContent_PublicChat = "Previous Public Chat";
    public const string StaticContent_RandomText = "Random Text";
    public const string StaticContent_Guid = "GUID";
    public const string StaticContent_DateTime = "Date & Time";
    private readonly IEventAggregator _eventAggregator;
    private const string REMOTEMEETINGWEBFILE = "meetings/meetings.txt";
    private const string LOCALMEETINGWEBFILE = "c:\\zoomzoom\\meetings_web.txt";
    private static SynchronizationContext context;
    private static readonly object engineLock;
    private static Engine instance;
    private static EventManager eventManager;
    private static EventHookManager hookManager;
    private static WindowManager windowManager;
    private static ActivityManager activityManager;
    private static ChatManager chatManager;
    private static LockedObservableCollection<ZoomImage> images;
    private static ConcurrentBag<ZoomWindow> activeWindows;
    private static ConcurrentBag<ZoomUser> users;
    private static ConcurrentDictionary<string, ActivityBase> activitiesOnHold;
    private static ConcurrentQueue<ZoomEvent> activityQueue;
    private static ConcurrentQueue<ZoomEvent> eventQueue;
    private static ConcurrentQueue<ZoomEvent> hookQueue;
    private static ConcurrentQueue<ZoomEvent> layoutQueue;
    private static ConcurrentQueue<ZoomEvent> windowQueue;
    private static ObservableCollection<LayoutPattern> patterns;
    private static ObservableCollection<string> activeUsers;
    private static ObservableCollection<ZoomMeeting> meetings;
    private static ObservableCollection<ZoomButton> buttons;
    private static LockedObservableCollection<MessageCategory> messageCategories;
    private static LockedObservableCollection<MessageContent> messageContents;
    private static LockedObservableCollection<ZoomWindow> windows;
    private static ConcurrentBag<ActivityBase> savedActivities;
    private static List<string> JoinOrder;
    private static int JoinOrderIndex;
    private static bool quitApplication;
    private static List<ActivityBase> activitiesPending;
    private static ConcurrentBag<ActivityBase> activitiesCompleted;
    private static bool isExecuting;
    private static LayoutPattern activePattern;
    private static Settings settings;
    private static CancellationToken token;
    private static CancellationToken managersToken;
    private static CancellationTokenSource managersTokenSource;
    private static DateTime startupTime;
    private static ZoomDB zoomDatabase;
    private static ZoomZoomDatabase zoomZoomDatabase;
    private static Process mainProcess;
    private static string currentName;

    public ConcurrentDictionary<string, ActivityBase> ActivitiesOnHold
    {
      get
      {
label_1:
        int num1 = -1906148810;
        ConcurrentDictionary<string, ActivityBase> activitiesOnHold;
        while (true)
        {
          int num2 = -1675885805;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              activitiesOnHold = Engine.activitiesOnHold;
              num1 = (int) num3 * -492096904 ^ 1736310733;
              continue;
            case 2:
              num1 = (int) num3 * -1899059766 ^ 1832398588;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activitiesOnHold;
      }
      set
      {
        Engine.activitiesOnHold = value;
      }
    }

    public SharedData SharedData
    {
      get
      {
        SharedData sharedData = this.sharedData;
label_1:
        int num1 = 1759626729;
        while (true)
        {
          int num2 = 1820285952;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1659762679 ^ 1679525049;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return sharedData;
      }
      set
      {
        this.sharedData = value;
      }
    }

    public IntPtr MainProcessWindow
    {
      get
      {
label_1:
        int num1 = -2021731925;
        IntPtr num2;
        while (true)
        {
          int num3 = -1176842794;
          uint num4;
          switch ((num4 = (uint) (num1 ^ num3)) % 4U)
          {
            case 0:
              num2 = Engine.\u200B⁯‫⁬‎​⁪‪‎​‮‪⁬‬‏‫‪⁪⁮‬‭‌‫‭‬‫⁮‍⁬⁪‎‪⁪⁬⁪‌⁫‎​‍‮(Engine.mainProcess);
              num1 = (int) num4 * 1241546852 ^ -1723151276;
              continue;
            case 1:
              Engine.\u202B‍‎⁬⁫‎‍‭‎‍⁮⁬⁬⁮​⁯‬⁫‫‬⁬⁫‫⁮‍‌⁭​⁪⁯⁯‎⁮⁪‪‌⁯‎​‬‮(Engine.mainProcess);
              num1 = (int) num4 * -846884800 ^ 878065074;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return num2;
      }
    }

    public ConcurrentQueue<ZoomEvent> EventQueue
    {
      get
      {
        return this.EventQueue1;
      }
      set
      {
label_1:
        int num1 = -460600423;
        while (true)
        {
          int num2 = -2089504368;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.EventQueue1 = value;
              num1 = (int) num3 * 895676588 ^ 867321906;
              continue;
            case 2:
              num1 = (int) num3 * -1807932272 ^ -617684884;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public ActivityBase ActiveActivity
    {
      get
      {
label_1:
        int num1 = 68361922;
        ActivityBase activeActivity;
        while (true)
        {
          int num2 = 858998877;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -2016344474 ^ 528094352;
              continue;
            case 2:
              goto label_1;
            case 3:
              activeActivity = this.activeActivity;
              num1 = (int) num3 * -1704868869 ^ 756848636;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activeActivity;
      }
      private set
      {
label_1:
        int num1 = -817484965;
        object engineLock;
        while (true)
        {
          int num2 = -1872620493;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * 756977422 ^ -641612093;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_6:
          int num2 = -1039049247;
          while (true)
          {
            int num3 = -1872620493;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_6;
              case 1:
                num2 = (int) num4 * 1644385860 ^ 401502772;
                continue;
              case 2:
                num2 = (int) num4 * -354884305 ^ 723299964;
                continue;
              default:
                goto label_10;
            }
          }
label_10:
          this.activeActivity = value;
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = -1522732328;
            while (true)
            {
              int num3 = -1872620493;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  num2 = (int) num4 * 1974889411 ^ -1351223230;
                  continue;
                case 2:
                  goto label_12;
                case 3:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -1234880987 ^ 365409684;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(916082893U));
      }
    }

    public ZoomMeeting ActiveMeeting
    {
      get
      {
        return this.activeMeeting;
      }
      private set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
          int num1 = 1867862468;
          while (true)
          {
            int num2 = 2021994072;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                num1 = (int) num3 * 1096423839 ^ -928186720;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          this.activeMeeting = value;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num1 = 327452429;
            while (true)
            {
              int num2 = 2021994072;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_7;
                case 2:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 1243390415 ^ -537536445;
                  continue;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(211981426U));
label_13:
        int num4 = 433003046;
        while (true)
        {
          int num1 = 2021994072;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 3U)
          {
            case 0:
              goto label_13;
            case 1:
              num4 = (int) num2 * -757115786 ^ 2138992372;
              continue;
            case 2:
              goto label_15;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_15:;
      }
    }

    public ZoomWindow ActiveMeetingWindow
    {
      get
      {
        ZoomWindow activeMeetingWindow = this.activeMeetingWindow;
label_1:
        int num1 = -328451706;
        while (true)
        {
          int num2 = -441146904;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1315641117 ^ 1705548401;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeMeetingWindow;
      }
      private set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
          int num1 = -2004511459;
          while (true)
          {
            int num2 = -2063369990;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_2;
              case 2:
                num1 = (int) num3 * -2142245711 ^ -1035306499;
                continue;
              case 3:
                num1 = (int) num3 * 2045482964 ^ -1098124112;
                continue;
              default:
                goto label_6;
            }
          }
label_6:
          this.activeMeetingWindow = value;
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = -333579969;
            while (true)
            {
              int num2 = -2063369990;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_8;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 2133244387 ^ -1134732106;
                  continue;
                case 3:
                  num1 = (int) num3 * -1926269635 ^ 1755210667;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2962592274U));
      }
    }

    public ObservableCollection<ZoomMeeting> Meetings
    {
      get
      {
label_1:
        int num1 = 269867318;
        ObservableCollection<ZoomMeeting> meetings;
        while (true)
        {
          int num2 = 893380736;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meetings = Engine.meetings;
              num1 = (int) num3 * 1332056332 ^ 1731719935;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetings;
      }
      private set
      {
label_1:
        int num1 = 1405655004;
        object engineLock;
        while (true)
        {
          int num2 = 1962313884;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * -1977876930 ^ -1724568562;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
          Engine.meetings = value;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num2 = 55392968;
            while (true)
            {
              int num3 = 1962313884;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -1312595530 ^ 505574774;
                  continue;
                case 2:
                  goto label_7;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2879229487U));
label_13:
        int num5 = 1218756394;
        while (true)
        {
          int num2 = 1962313884;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 3U)
          {
            case 0:
              goto label_15;
            case 1:
              num5 = (int) num3 * 1638140277 ^ 1333732916;
              continue;
            case 2:
              goto label_13;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_15:;
      }
    }

    public ConcurrentBag<ZoomUser> Users
    {
      get
      {
        return Engine.users;
      }
    }

    public Settings Settings
    {
      get
      {
        return Engine.settings;
      }
    }

    public bool Initialized
    {
      get
      {
        if (this.EventManager == null)
          goto label_14;
label_1:
        int num1 = 1517892185;
label_2:
        bool flag1;
        bool flag2;
        while (true)
        {
          int num2 = 1330133906;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              int num4 = !flag2 ? 992545547 : (num4 = 1661862294);
              int num5 = (int) num3 * -1573178656;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag1 = true;
              num1 = (int) num3 * 1547124874 ^ -458767146;
              continue;
            case 2:
              if (this.ActivityManager.Initialized)
              {
                num1 = (int) num3 * -1052596623 ^ 1436168910;
                continue;
              }
              goto label_14;
            case 4:
              goto label_13;
            case 5:
              num1 = (int) num3 * -1074497247 ^ -1612042251;
              continue;
            case 6:
              if (this.EventManager.Initialized)
              {
                num1 = (int) num3 * 1185490210 ^ -1558928811;
                continue;
              }
              goto label_14;
            case 7:
              goto label_1;
            case 8:
              flag1 = false;
              num1 = 1719916165;
              continue;
            case 9:
              num1 = (int) num3 * 49132830 ^ -585143885;
              continue;
            case 10:
              num1 = (int) num3 * -1292331172 ^ -344268470;
              continue;
            default:
              goto label_16;
          }
        }
label_13:
        int num6 = this.WindowManager.Initialized ? 1 : 0;
        goto label_15;
label_16:
        return flag1;
label_14:
        num6 = 0;
label_15:
        flag2 = num6 != 0;
        num1 = 2075332493;
        goto label_2;
      }
    }

    public HighlightInfo HighlightTarget
    {
      get
      {
        HighlightInfo highlightTarget = this.highlightTarget;
label_1:
        int num1 = 82311401;
        while (true)
        {
          int num2 = 457150858;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -108114114 ^ 100376663;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return highlightTarget;
      }
      set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
          this.highlightTarget = value;
        }
        finally
        {
          if (flag)
          {
label_3:
            int num1 = 856594913;
            while (true)
            {
              int num2 = 727198404;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_3;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * -539224804 ^ -1266162765;
                  continue;
                case 3:
                  num1 = (int) num3 * -1049810927 ^ 1036877981;
                  continue;
                default:
                  goto label_7;
              }
            }
          }
label_7:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4082347520U));
      }
    }

    public TrackingWindow TrackingWindow
    {
      get
      {
label_1:
        int num1 = -228214898;
        TrackingWindow trackingWindow;
        while (true)
        {
          int num2 = -510207188;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              trackingWindow = this.trackingWindow;
              num1 = (int) num3 * 1214589133 ^ -1094190136;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return trackingWindow;
      }
      set
      {
        this.trackingWindow = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2250995075U));
      }
    }

    public WindowSelector SelectorWindow
    {
      get
      {
label_1:
        int num1 = -1164764878;
        WindowSelector selectorWindow;
        while (true)
        {
          int num2 = -581335132;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              selectorWindow = this.selectorWindow;
              num1 = (int) num3 * 550224421 ^ -1205357323;
              continue;
            case 3:
              num1 = (int) num3 * -1368751649 ^ 77771760;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return selectorWindow;
      }
      set
      {
        this.selectorWindow = value;
label_1:
        int num1 = 1545258158;
        while (true)
        {
          int num2 = 1396377840;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1165101655U));
              num1 = (int) num3 * 1425409847 ^ 1329650015;
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
    }

    public LockedObservableCollection<ZoomImage> Images
    {
      get
      {
        return Engine.images;
      }
    }

    public CancellationTokenSource ManagersTokenSource
    {
      get
      {
label_1:
        int num1 = -851727187;
        CancellationTokenSource managersTokenSource;
        while (true)
        {
          int num2 = -887079740;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              managersTokenSource = Engine.managersTokenSource;
              num1 = (int) num3 * 573448342 ^ 301318556;
              continue;
            case 2:
              num1 = (int) num3 * 1229373597 ^ 969353169;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return managersTokenSource;
      }
      set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
          int num1 = 1557837725;
          while (true)
          {
            int num2 = 1285326068;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 2:
                Engine.managersTokenSource = value;
                num1 = (int) num3 * -1356109831 ^ 1414326522;
                continue;
              default:
                goto label_11;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_6:
            int num1 = 1295819693;
            while (true)
            {
              int num2 = 1285326068;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 838460343 ^ 1830393804;
                  continue;
                case 2:
                  goto label_6;
                case 3:
                  num1 = (int) num3 * -1997509001 ^ 345701645;
                  continue;
                default:
                  goto label_10;
              }
            }
          }
label_10:;
        }
label_11:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4141336345U));
      }
    }

    public CancellationToken ManagersToken
    {
      get
      {
        CancellationToken managersToken = Engine.managersToken;
label_1:
        int num1 = 1320713255;
        while (true)
        {
          int num2 = 311045431;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1864506727 ^ 57861300;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return managersToken;
      }
      set
      {
label_1:
        int num1 = -614106280;
        object engineLock;
        while (true)
        {
          int num2 = -1579401771;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * 1357334761 ^ 491540178;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_6:
          int num2 = -1640206928;
          while (true)
          {
            int num3 = -1579401771;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_6;
              case 1:
                num2 = (int) num4 * 158980033 ^ -878643302;
                continue;
              case 2:
                Engine.managersToken = value;
                num2 = (int) num4 * 227972031 ^ -1382719460;
                continue;
              default:
                goto label_16;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_11:
            int num2 = -196936818;
            while (true)
            {
              int num3 = -1579401771;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * 1364468921 ^ -1528127186;
                  continue;
                case 2:
                  goto label_11;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
label_16:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2876033156U));
label_17:
        int num5 = -234927433;
        while (true)
        {
          int num2 = -1579401771;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 3U)
          {
            case 0:
              goto label_17;
            case 1:
              goto label_19;
            case 2:
              num5 = (int) num3 * -716146877 ^ -411672617;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_19:;
      }
    }

    public static Engine Instance
    {
      get
      {
label_1:
        int num1 = -1651833179;
        object engineLock;
        while (true)
        {
          int num2 = -233778889;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              if (Engine.instance == null)
              {
                num1 = (int) num3 * 1241247131 ^ 2083139202;
                continue;
              }
              goto label_24;
            case 3:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * 871415281 ^ -459582667;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_8:
          int num2 = -1082870887;
          while (true)
          {
            int num3 = -233778889;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 1:
                num2 = (int) num4 * 33380578 ^ 544918608;
                continue;
              case 2:
                num2 = -594555129;
                continue;
              case 3:
                num2 = (int) num4 * -2045508007 ^ -578058865;
                continue;
              case 4:
                int num5 = Engine.instance == null ? -1721089604 : (num5 = -825579390);
                int num6 = (int) num4 * 1770614279;
                num2 = num5 ^ num6;
                continue;
              case 5:
                Engine.instance = new Engine();
                num2 = (int) num4 * 807767454 ^ 1801869173;
                continue;
              case 6:
                goto label_8;
              default:
                goto label_21;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_16:
            int num2 = -206745555;
            while (true)
            {
              int num3 = -233778889;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_16;
                case 2:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * 1103071146 ^ -869253572;
                  continue;
                case 3:
                  num2 = (int) num4 * 872673127 ^ 712470843;
                  continue;
                default:
                  goto label_20;
              }
            }
          }
label_20:;
        }
label_21:
label_22:
        int num7 = -1500959467;
label_23:
        int num8 = -233778889;
        uint num9;
        Engine instance;
        switch ((num9 = (uint) (num7 ^ num8)) % 3U)
        {
          case 0:
            goto label_22;
          case 1:
            break;
          default:
            return instance;
        }
label_24:
        instance = Engine.instance;
        num7 = -160553165;
        goto label_23;
      }
    }

    public ZoomMeeting NextMeeting
    {
      get
      {
        if (Engine.JoinOrder.Count != 0)
          goto label_17;
label_1:
        int num1 = -2038890913;
label_2:
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = -1516244788;
          uint num3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              goto label_17;
            case 1:
              ++Engine.JoinOrderIndex;
              num1 = (int) num3 * -1411970522 ^ 1814430413;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -876288002 ^ 1115286776;
              continue;
            case 4:
              num1 = (int) num3 * 2829510 ^ 1781526443;
              continue;
            case 5:
              if (Engine.JoinOrder.Count > 0)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 602757099 ^ 1400793314;
              continue;
            case 6:
              Engine.JoinOrderIndex = 0;
              num1 = (int) num3 * 1637836093 ^ -1802900897;
              continue;
            case 7:
              int num5 = Engine.JoinOrderIndex >= Engine.JoinOrder.Count ? -1005909299 : (num5 = -479044938);
              int num6 = (int) num3 * -1252419279;
              num1 = num5 ^ num6;
              continue;
            case 9:
              num4 = -1;
              break;
            case 10:
              num1 = (int) num3 * -1421358980 ^ 1490720172;
              continue;
            case 11:
              meeting = this.GetMeeting(Engine.JoinOrder[Engine.JoinOrderIndex], false);
              num1 = -1696879722;
              continue;
            case 12:
              num1 = (int) num3 * -1382837548 ^ -441768631;
              continue;
            case 13:
              num1 = -442915737;
              continue;
            case 14:
              this.FillJoinOrder();
              num1 = (int) num3 * -503658453 ^ 1265881210;
              continue;
            case 15:
              num1 = (int) num3 * -422156564 ^ -1693956365;
              continue;
            default:
              goto label_20;
          }
          Engine.JoinOrderIndex = num4;
          num1 = -1581995432;
        }
label_20:
        return meeting;
label_17:
        num1 = -194752915;
        goto label_2;
      }
    }

    public ZoomDB ZoomDatabase
    {
      get
      {
label_1:
        int num1 = 1584970647;
        ZoomDB zoomDatabase;
        while (true)
        {
          int num2 = 842521586;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              zoomDatabase = Engine.zoomDatabase;
              num1 = (int) num3 * -1276199918 ^ 1442857423;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -86324642 ^ -1571998940;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return zoomDatabase;
      }
    }

    public ZoomUser PublicUser { get; internal set; }

    public ConcurrentQueue<ZoomEvent> ActivityQueue
    {
      get
      {
        ConcurrentQueue<ZoomEvent> activityQueue = Engine.activityQueue;
label_1:
        int num1 = 928677553;
        while (true)
        {
          int num2 = 2054023241;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1110803886 ^ 420849374;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activityQueue;
      }
      set
      {
label_1:
        int num1 = 2022707652;
        while (true)
        {
          int num2 = 794680466;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              Engine.activityQueue = value;
              num1 = (int) num3 * -1041695102 ^ -471354083;
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
    }

    public ConcurrentQueue<ZoomEvent> EventQueue1
    {
      get
      {
label_1:
        int num1 = 240041007;
        ConcurrentQueue<ZoomEvent> eventQueue;
        while (true)
        {
          int num2 = 1976339886;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              eventQueue = Engine.eventQueue;
              num1 = (int) num3 * 1912792594 ^ 295069603;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1813182517 ^ 897896947;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return eventQueue;
      }
      set
      {
label_1:
        int num1 = 1523229699;
        while (true)
        {
          int num2 = 142464337;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              Engine.eventQueue = value;
              num1 = (int) num3 * -211829695 ^ -1302745849;
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
    }

    public ConcurrentQueue<ZoomEvent> HookQueue
    {
      get
      {
label_1:
        int num1 = -1898392078;
        ConcurrentQueue<ZoomEvent> hookQueue;
        while (true)
        {
          int num2 = -766683896;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1401383715 ^ 586348886;
              continue;
            case 2:
              hookQueue = Engine.hookQueue;
              num1 = (int) num3 * 1448827120 ^ -2138613635;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return hookQueue;
      }
      set
      {
label_1:
        int num1 = -180461695;
        while (true)
        {
          int num2 = -1997839071;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              Engine.hookQueue = value;
              num1 = (int) num3 * -635240092 ^ -1386447785;
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
    }

    public ConcurrentQueue<ZoomEvent> LayoutQueue
    {
      get
      {
label_1:
        int num1 = 768623041;
        ConcurrentQueue<ZoomEvent> layoutQueue;
        while (true)
        {
          int num2 = 1365723844;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              layoutQueue = Engine.layoutQueue;
              num1 = (int) num3 * 918084300 ^ 1948798650;
              continue;
            case 2:
              num1 = (int) num3 * 2020248047 ^ 1365344165;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return layoutQueue;
      }
      set
      {
        Engine.layoutQueue = value;
      }
    }

    public ConcurrentQueue<ZoomEvent> WindowQueue
    {
      get
      {
label_1:
        int num1 = 273516819;
        ConcurrentQueue<ZoomEvent> windowQueue;
        while (true)
        {
          int num2 = 683160257;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -276068850 ^ -1210864797;
              continue;
            case 2:
              windowQueue = Engine.windowQueue;
              num1 = (int) num3 * 1753150037 ^ -444256826;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return windowQueue;
      }
      set
      {
        Engine.windowQueue = value;
      }
    }

    public List<ActivityBase> ActivitiesPending
    {
      get
      {
        List<ActivityBase> activitiesPending = Engine.activitiesPending;
label_1:
        int num1 = 1980104777;
        while (true)
        {
          int num2 = 49375005;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1669923020 ^ 380787486;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activitiesPending;
      }
      set
      {
        Engine.activitiesPending = value;
      }
    }

    public ConcurrentBag<ActivityBase> ActivitiesCompleted
    {
      get
      {
        ConcurrentBag<ActivityBase> activitiesCompleted = Engine.activitiesCompleted;
label_1:
        int num1 = -2071163125;
        while (true)
        {
          int num2 = -641058437;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 921380815 ^ -993064668;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return activitiesCompleted;
      }
      set
      {
label_1:
        int num1 = 762058241;
        while (true)
        {
          int num2 = 1802205173;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              Engine.activitiesCompleted = value;
              num1 = (int) num3 * 2037759517 ^ -1430551516;
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
    }

    public string CurrentName
    {
      get
      {
label_1:
        int num1 = 1968170239;
        string currentName;
        while (true)
        {
          int num2 = 444552562;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              currentName = Engine.currentName;
              num1 = (int) num3 * -2075438201 ^ 1782703995;
              continue;
            case 2:
              num1 = (int) num3 * -2104602417 ^ 1603051271;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return currentName;
      }
      set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
          int num1 = -1951864096;
          while (true)
          {
            int num2 = -834388809;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                num1 = (int) num3 * -1626353551 ^ -322190365;
                continue;
              case 1:
                num1 = (int) num3 * 698333324 ^ 1330011894;
                continue;
              case 3:
                goto label_2;
              case 4:
                Engine.currentName = value;
                num1 = (int) num3 * 1737637911 ^ 1020657200;
                continue;
              default:
                goto label_14;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = -1554233146;
            while (true)
            {
              int num2 = -834388809;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * 1616599032 ^ 2058599473;
                  continue;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * -1848494779 ^ 1316895502;
                  continue;
                case 3:
                  goto label_8;
                default:
                  goto label_13;
              }
            }
          }
label_13:;
        }
label_14:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3196029940U));
label_15:
        int num4 = -1991401676;
        while (true)
        {
          int num1 = -834388809;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 3U)
          {
            case 0:
              goto label_15;
            case 1:
              goto label_17;
            case 2:
              num4 = (int) num2 * 966440805 ^ -1582023949;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_17:;
      }
    }

    public bool QuitApplication
    {
      get
      {
        bool quitApplication = Engine.quitApplication;
label_1:
        int num1 = -44674973;
        while (true)
        {
          int num2 = -27606501;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -275891793 ^ -365305050;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return quitApplication;
      }
      internal set
      {
        object engineLock = Engine.engineLock;
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
          Engine.quitApplication = value;
        }
        finally
        {
          if (flag1)
          {
label_3:
            int num1 = -804871245;
            while (true)
            {
              int num2 = -174650144;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_3;
                case 1:
                  num1 = (int) num3 * 1842836628 ^ 1920282242;
                  continue;
                case 3:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 1994080122 ^ 1990445107;
                  continue;
                default:
                  goto label_8;
              }
            }
          }
label_8:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2346255124U));
label_10:
        int num4 = -768613967;
        while (true)
        {
          int num1 = -174650144;
          uint num2;
          bool flag2;
          switch ((num2 = (uint) (num4 ^ num1)) % 11U)
          {
            case 0:
              int num3 = !flag2 ? 875791722 : (num3 = 992488446);
              int num5 = (int) num2 * -973879828;
              num4 = num3 ^ num5;
              continue;
            case 1:
              num4 = (int) num2 * 2059683590 ^ 730148750;
              continue;
            case 2:
              num4 = (int) num2 * -1014556086 ^ -657368661;
              continue;
            case 3:
              num4 = (int) num2 * -1348402269 ^ -1349149270;
              continue;
            case 4:
              this.logMessage = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2497786796U);
              flag2 = this.OnQuitApplicationRequested != null;
              num4 = (int) num2 * 1482845831 ^ -412001467;
              continue;
            case 5:
              num4 = -380220815;
              continue;
            case 6:
              int num6 = Engine.quitApplication ? -638305497 : (num6 = -533988584);
              int num7 = (int) num2 * 542318353;
              num4 = num6 ^ num7;
              continue;
            case 7:
              this.OnQuitApplicationRequested((object) this, (EventArgs) null);
              num4 = (int) num2 * -39661774 ^ 1412902972;
              continue;
            case 8:
              num4 = (int) num2 * -1751595690 ^ 1923261209;
              continue;
            case 9:
              goto label_10;
            case 10:
              goto label_12;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_12:;
      }
    }

    public EventHookManager HookManager
    {
      get
      {
label_1:
        int num1 = -1751651989;
        object engineLock;
        while (true)
        {
          int num2 = -123129575;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * 128359237 ^ 1859749902;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_6:
          int num2 = -1296419650;
          while (true)
          {
            int num3 = -123129575;
            uint num4;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 0:
                int num5 = !flag2 ? 1407840973 : (num5 = 1031989067);
                int num6 = (int) num4 * -1587806922;
                num2 = num5 ^ num6;
                continue;
              case 2:
                num2 = (int) num4 * 579724485 ^ 1898167960;
                continue;
              case 3:
                Engine.hookManager = EventHookManager.Instance;
                num2 = (int) num4 * 1808899425 ^ 1604210071;
                continue;
              case 4:
                num2 = -1984238336;
                continue;
              case 5:
                num2 = (int) num4 * 1962118465 ^ 1679122488;
                continue;
              case 6:
                goto label_6;
              case 7:
                flag2 = Engine.hookManager == null;
                num2 = (int) num4 * 1713243634 ^ 745744239;
                continue;
              default:
                goto label_20;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_15:
            int num2 = -325665270;
            while (true)
            {
              int num3 = -123129575;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  num2 = (int) num4 * 853398316 ^ 2072028896;
                  continue;
                case 2:
                  goto label_15;
                case 3:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -1069289695 ^ 955581842;
                  continue;
                default:
                  goto label_19;
              }
            }
          }
label_19:;
        }
label_20:
        EventHookManager hookManager = Engine.hookManager;
label_21:
        int num7 = -2115679977;
        while (true)
        {
          int num2 = -123129575;
          uint num3;
          switch ((num3 = (uint) (num7 ^ num2)) % 3U)
          {
            case 0:
              goto label_21;
            case 1:
              num7 = (int) num3 * -1359660986 ^ -334492138;
              continue;
            default:
              goto label_24;
          }
        }
label_24:
        return hookManager;
      }
      set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
          int num1 = -1171549883;
          while (true)
          {
            int num2 = -124844264;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * 1451998774 ^ -1980520732;
                continue;
              case 2:
                num1 = (int) num3 * -480841307 ^ -310605978;
                continue;
              case 3:
                goto label_2;
              default:
                goto label_6;
            }
          }
label_6:
          Engine.hookManager = value;
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = -318516753;
            while (true)
            {
              int num2 = -124844264;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * 1195784738 ^ -226426015;
                  continue;
                case 2:
                  goto label_8;
                case 3:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * -1040140566 ^ -717569854;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1866720868U));
      }
    }

    public WindowManager WindowManager
    {
      get
      {
label_1:
        int num1 = -2008928129;
        WindowManager windowManager;
        while (true)
        {
          int num2 = -1371701745;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              windowManager = Engine.windowManager;
              num1 = (int) num3 * 1402361292 ^ -2070091194;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowManager;
      }
      set
      {
label_1:
        int num1 = -1118567653;
        object engineLock;
        while (true)
        {
          int num2 = -2041492604;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * -769273493 ^ 1496781398;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_6:
          int num2 = -1806844990;
          while (true)
          {
            int num3 = -2041492604;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_6;
              case 1:
                num2 = (int) num4 * 610954149 ^ -134127826;
                continue;
              case 2:
                num2 = (int) num4 * 198304839 ^ 1975657363;
                continue;
              default:
                goto label_10;
            }
          }
label_10:
          Engine.windowManager = value;
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = -1007158963;
            while (true)
            {
              int num3 = -2041492604;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -217149534 ^ 1710665852;
                  continue;
                case 2:
                  num2 = (int) num4 * 776206218 ^ 672260180;
                  continue;
                case 3:
                  goto label_12;
                default:
                  goto label_17;
              }
            }
          }
label_17:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(727775692U));
label_19:
        int num5 = -683543607;
        while (true)
        {
          int num2 = -2041492604;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 3U)
          {
            case 0:
              goto label_21;
            case 1:
              num5 = (int) num3 * -1842518064 ^ 799537378;
              continue;
            case 2:
              goto label_19;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_21:;
      }
    }

    public ActivityManager ActivityManager
    {
      get
      {
        object engineLock = Engine.engineLock;
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_2:
          int num1 = 1748645019;
          while (true)
          {
            int num2 = 475943105;
            uint num3;
            bool flag2;
            switch ((num3 = (uint) (num1 ^ num2)) % 7U)
            {
              case 0:
                goto label_2;
              case 1:
                flag2 = Engine.activityManager == null;
                num1 = (int) num3 * 1974216462 ^ 1122453793;
                continue;
              case 2:
                num1 = 1068468779;
                continue;
              case 3:
                num1 = (int) num3 * -1555688385 ^ 1749702054;
                continue;
              case 4:
                int num4 = flag2 ? 1506617648 : (num4 = 242083632);
                int num5 = (int) num3 * -156118999;
                num1 = num4 ^ num5;
                continue;
              case 5:
                Engine.activityManager = ActivityManager.Instance;
                num1 = (int) num3 * 5448648 ^ 1934411375;
                continue;
              default:
                goto label_15;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_10:
            int num1 = 653712084;
            while (true)
            {
              int num2 = 475943105;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * -1012452367 ^ 1320327047;
                  continue;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 696202723 ^ -1030386362;
                  continue;
                case 3:
                  goto label_10;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
label_15:
        ActivityManager activityManager = Engine.activityManager;
label_16:
        int num6 = 586876195;
        while (true)
        {
          int num1 = 475943105;
          uint num2;
          switch ((num2 = (uint) (num6 ^ num1)) % 3U)
          {
            case 1:
              num6 = (int) num2 * -683471015 ^ -1844622483;
              continue;
            case 2:
              goto label_16;
            default:
              goto label_19;
          }
        }
label_19:
        return activityManager;
      }
      set
      {
label_1:
        int num1 = 91348263;
        object engineLock;
        while (true)
        {
          int num2 = 1524477241;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * 800910311 ^ 521149572;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_6:
          int num2 = 1296233295;
          while (true)
          {
            int num3 = 1524477241;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                Engine.activityManager = value;
                num2 = (int) num4 * -681608721 ^ 1376881367;
                continue;
              case 2:
                num2 = (int) num4 * 1767352953 ^ 177284866;
                continue;
              case 3:
                goto label_6;
              case 4:
                num2 = (int) num4 * -1366637322 ^ -236973581;
                continue;
              default:
                goto label_17;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = 2083666160;
            while (true)
            {
              int num3 = 1524477241;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_12;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -1465543790 ^ 1756981164;
                  continue;
                case 3:
                  num2 = (int) num4 * 2132068982 ^ 1166272669;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
label_17:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(861334147U));
      }
    }

    public ChatManager ChatManager
    {
      get
      {
label_1:
        int num1 = 1065908661;
        object engineLock;
        while (true)
        {
          int num2 = 1614024834;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * -1577005034 ^ 1103996040;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_6:
          int num2 = 85374892;
          while (true)
          {
            int num3 = 1614024834;
            uint num4;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                num2 = (int) num4 * -1559488868 ^ -1650262011;
                continue;
              case 1:
                flag2 = Engine.chatManager == null;
                num2 = (int) num4 * 1335788947 ^ 426819141;
                continue;
              case 2:
                num2 = (int) num4 * -809113855 ^ 1922179901;
                continue;
              case 3:
                Engine.chatManager = ChatManager.Instance;
                num2 = (int) num4 * 686211512 ^ -278005935;
                continue;
              case 5:
                goto label_6;
              case 6:
                int num5 = !flag2 ? 1007892375 : (num5 = 1065066973);
                int num6 = (int) num4 * -1292179307;
                num2 = num5 ^ num6;
                continue;
              default:
                goto label_18;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_14:
            int num2 = 707596589;
            while (true)
            {
              int num3 = 1614024834;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_14;
                case 2:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -1418735979 ^ -686665230;
                  continue;
                default:
                  goto label_17;
              }
            }
          }
label_17:;
        }
label_18:
        return Engine.chatManager;
      }
      set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
          int num1 = 459872744;
          while (true)
          {
            int num2 = 574363584;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                Engine.chatManager = value;
                num1 = (int) num3 * -326862066 ^ 1235049584;
                continue;
              case 1:
                num1 = (int) num3 * -1775705114 ^ -1053604554;
                continue;
              case 3:
                num1 = (int) num3 * 139286210 ^ -1519573513;
                continue;
              case 4:
                goto label_2;
              default:
                goto label_12;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = 1455615946;
            while (true)
            {
              int num2 = 574363584;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 1235470690 ^ -771553660;
                  continue;
                case 2:
                  goto label_8;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
label_12:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4150914722U));
      }
    }

    public EventManager EventManager
    {
      get
      {
label_1:
        int num1 = 81448230;
        object engineLock;
        while (true)
        {
          int num2 = 1657911212;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * -164415790 ^ 26323571;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_6:
          int num2 = 1818357603;
          while (true)
          {
            int num3 = 1657911212;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                int num5 = Engine.eventManager != null ? 1837871911 : (num5 = 965929618);
                int num6 = (int) num4 * -1949361386;
                num2 = num5 ^ num6;
                continue;
              case 2:
                num2 = (int) num4 * -1508027445 ^ 2040386664;
                continue;
              case 3:
                goto label_6;
              case 4:
                Engine.eventManager = EventManager.Instance;
                num2 = (int) num4 * 509804445 ^ 1097711665;
                continue;
              case 5:
                num2 = (int) num4 * 969807914 ^ 697411038;
                continue;
              default:
                goto label_18;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_13:
            int num2 = 330012353;
            while (true)
            {
              int num3 = 1657911212;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  num2 = (int) num4 * -1391216741 ^ 311906583;
                  continue;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -1593604891 ^ 155046301;
                  continue;
                case 2:
                  goto label_13;
                default:
                  goto label_17;
              }
            }
          }
label_17:;
        }
label_18:
        EventManager eventManager = Engine.eventManager;
label_19:
        int num7 = 1668836153;
        while (true)
        {
          int num2 = 1657911212;
          uint num3;
          switch ((num3 = (uint) (num7 ^ num2)) % 3U)
          {
            case 0:
              goto label_19;
            case 2:
              num7 = (int) num3 * -1100950460 ^ 1483931471;
              continue;
            default:
              goto label_22;
          }
        }
label_22:
        return eventManager;
      }
      set
      {
        object engineLock = Engine.engineLock;
        bool flag = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
          int num1 = -72483854;
          while (true)
          {
            int num2 = -874413429;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                Engine.eventManager = value;
                num1 = (int) num3 * -1494986698 ^ 589667583;
                continue;
              case 1:
                num1 = (int) num3 * 1172033641 ^ -2074471355;
                continue;
              case 2:
                goto label_2;
              case 4:
                num1 = (int) num3 * -1516632772 ^ 1936783196;
                continue;
              default:
                goto label_13;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = -1976737566;
            while (true)
            {
              int num2 = -874413429;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_8;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * -35178309 ^ 1221715883;
                  continue;
                case 3:
                  num1 = (int) num3 * -876832714 ^ 976918199;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
label_13:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3844191134U));
      }
    }

    internal ZoomZoomDatabase ZoomZoomDatabase
    {
      get
      {
        return Engine.zoomZoomDatabase;
      }
      private set
      {
        Engine.zoomZoomDatabase = value;
      }
    }

    public ObservableCollection<LayoutPattern> Patterns
    {
      get
      {
label_1:
        int num1 = -789371113;
        ObservableCollection<LayoutPattern> patterns;
        while (true)
        {
          int num2 = -171113247;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              patterns = Engine.patterns;
              num1 = (int) num3 * 610969580 ^ -924425522;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return patterns;
      }
      private set
      {
        Engine.patterns = value;
label_1:
        int num1 = 1607122309;
        while (true)
        {
          int num2 = 243368284;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4198341850U));
              num1 = (int) num3 * -2139287747 ^ -792781708;
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
    }

    public ObservableCollection<string> ActiveUsers
    {
      get
      {
label_1:
        int num1 = -1590215155;
        ObservableCollection<string> activeUsers;
        while (true)
        {
          int num2 = -1669770029;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              activeUsers = Engine.activeUsers;
              num1 = (int) num3 * 1224388861 ^ -542175065;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeUsers;
      }
      set
      {
label_1:
        int num1 = -918168059;
        while (true)
        {
          int num2 = -1675251284;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              Engine.activeUsers = value;
              num1 = (int) num3 * 1348143502 ^ -1080160817;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public bool IsExecuting
    {
      get
      {
label_1:
        int num1 = -591045377;
        bool isExecuting;
        while (true)
        {
          int num2 = -1504524491;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 2070812861 ^ -1817375536;
              continue;
            case 2:
              isExecuting = Engine.isExecuting;
              num1 = (int) num3 * 829468323 ^ 946638394;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return isExecuting;
      }
      set
      {
        Engine.isExecuting = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(940661105U));
      }
    }

    public CancellationToken Token
    {
      get
      {
        return Engine.token;
      }
      set
      {
label_1:
        int num1 = -476714289;
        while (true)
        {
          int num2 = -1036579490;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              Engine.token = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2387709620U));
              num1 = (int) num3 * -1238720772 ^ 569996566;
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
    }

    public bool ErrorDetected
    {
      get
      {
label_1:
        int num1 = 87073854;
        bool errorDetected;
        while (true)
        {
          int num2 = 2138467997;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              errorDetected = this.errorDetected;
              num1 = (int) num3 * 552278568 ^ -1807822912;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return errorDetected;
      }
      set
      {
        this.errorDetected = value;
      }
    }

    public ObservableCollection<ZoomButton> Buttons
    {
      get
      {
        ObservableCollection<ZoomButton> buttons = Engine.buttons;
label_1:
        int num1 = -536791762;
        while (true)
        {
          int num2 = -968693141;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 752463631 ^ 1869990343;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return buttons;
      }
      set
      {
label_1:
        int num1 = -533793763;
        while (true)
        {
          int num2 = -1525361032;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              Engine.buttons = value;
              num1 = (int) num3 * -1338874842 ^ -47993312;
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
    }

    public LockedObservableCollection<MessageCategory> MessageCategories
    {
      get
      {
        return Engine.messageCategories;
      }
      set
      {
        Engine.messageCategories = value;
label_1:
        int num1 = -1536929168;
        while (true)
        {
          int num2 = -23208520;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3908369732U));
              num1 = (int) num3 * -1514921619 ^ 1674806574;
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
    }

    public LockedObservableCollection<MessageContent> MessageContents
    {
      get
      {
        LockedObservableCollection<MessageContent> messageContents = Engine.messageContents;
label_1:
        int num1 = -568834733;
        while (true)
        {
          int num2 = -2063083984;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -885552117 ^ -1006827372;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return messageContents;
      }
      set
      {
label_1:
        int num1 = 169733358;
        while (true)
        {
          int num2 = 821354643;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              Engine.messageContents = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(78913594U));
              num1 = (int) num3 * 311029432 ^ 1870674945;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public MachineState MachineState
    {
      get
      {
        MachineState machineState = this.machineState;
label_1:
        int num1 = -1723128629;
        while (true)
        {
          int num2 = -1240708502;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 601077754 ^ -32595219;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return machineState;
      }
      private set
      {
        this.machineState = value;
      }
    }

    public EngineState EngineState
    {
      get
      {
label_1:
        int num1 = -2109487909;
        EngineState engineState;
        while (true)
        {
          int num2 = -1324357992;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1468562778 ^ -727302767;
              continue;
            case 2:
              goto label_1;
            case 3:
              engineState = this.engineState;
              num1 = (int) num3 * 1428170463 ^ 2100706529;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return engineState;
      }
      private set
      {
        this.engineState = value;
      }
    }

    public LockedObservableCollection<ZoomWindow> Windows
    {
      get
      {
label_1:
        int num1 = 633683071;
        LockedObservableCollection<ZoomWindow> windows;
        while (true)
        {
          int num2 = 2044931829;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              windows = Engine.windows;
              num1 = (int) num3 * 727432457 ^ 1958606435;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windows;
      }
      set
      {
label_1:
        int num1 = 374790602;
        while (true)
        {
          int num2 = 103828851;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              Engine.windows = value;
              num1 = (int) num3 * 1224571873 ^ -1141809672;
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
    }

    public ConcurrentBag<ActivityBase> SavedActivities
    {
      get
      {
label_1:
        int num1 = -323868786;
        ConcurrentBag<ActivityBase> savedActivities;
        while (true)
        {
          int num2 = -454361725;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              savedActivities = Engine.savedActivities;
              num1 = (int) num3 * 96716432 ^ 489126092;
              continue;
            case 3:
              num1 = (int) num3 * -10137743 ^ -1146036658;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return savedActivities;
      }
      set
      {
        bool flag = Engine.savedActivities == value;
label_1:
        int num1 = 700642011;
        while (true)
        {
          int num2 = 638894704;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1858406202 ^ 281165703;
              continue;
            case 1:
              int num4 = !flag ? -718459192 : (num4 = -313488187);
              int num5 = (int) num3 * -1636774377;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * -1438412982 ^ -683157729;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(339720445U));
              num1 = (int) num3 * -312332949 ^ -1217847195;
              continue;
            case 4:
              Engine.savedActivities = value;
              num1 = 1792022611;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool ActivityQueuePurgeRequested
    {
      get
      {
        return this.activityQueuePurgeRequested;
      }
      private set
      {
label_1:
        int num1 = -1717115528;
        while (true)
        {
          int num2 = -109379270;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -823862049 ^ 874486130;
              continue;
            case 1:
              this.activityQueuePurgeRequested = value;
              num1 = (int) num3 * -156517629 ^ -631038314;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1188183508U));
              num1 = (int) num3 * 2029740956 ^ 1478878265;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public Dispatcher UserInterfaceDispatcher
    {
      get
      {
label_1:
        int num1 = -598399095;
        Dispatcher interfaceDispatcher;
        while (true)
        {
          int num2 = -257934436;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              interfaceDispatcher = this.userInterfaceDispatcher;
              num1 = (int) num3 * -764042932 ^ 2007731570;
              continue;
            case 2:
              num1 = (int) num3 * -886887794 ^ 428903784;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return interfaceDispatcher;
      }
      set
      {
label_1:
        int num1 = -972667211;
        while (true)
        {
          int num2 = -948002795;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.userInterfaceDispatcher = value;
              num1 = (int) num3 * 1208022417 ^ 1827324815;
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
    }

    public EngineView EngineView
    {
      get
      {
label_1:
        int num1 = 281997901;
        EngineView engineView;
        while (true)
        {
          int num2 = 793313188;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              engineView = this.engineView;
              num1 = (int) num3 * -566248880 ^ -605716165;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return engineView;
      }
      set
      {
        this.engineView = value;
      }
    }

    public ImageHistoryView ImageHistoryView
    {
      get
      {
label_1:
        int num1 = 1678731817;
        ImageHistoryView imageHistoryView;
        while (true)
        {
          int num2 = 1511243578;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              imageHistoryView = this.imageHistoryView;
              num1 = (int) num3 * 744024597 ^ -811470042;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return imageHistoryView;
      }
      set
      {
        this.imageHistoryView = value;
      }
    }

    public ConcurrentBag<ZoomWindow> ActiveWindows
    {
      get
      {
label_1:
        int num1 = -2028469768;
        ConcurrentBag<ZoomWindow> activeWindows;
        while (true)
        {
          int num2 = -138696979;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              activeWindows = Engine.activeWindows;
              num1 = (int) num3 * -836723130 ^ 2079388092;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeWindows;
      }
      set
      {
        Engine.activeWindows = value;
      }
    }

    public LayoutPattern ActivePattern
    {
      get
      {
label_1:
        int num1 = -1127377092;
        LayoutPattern activePattern;
        while (true)
        {
          int num2 = -1648583627;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              activePattern = Engine.activePattern;
              num1 = (int) num3 * 1280263119 ^ 1157644028;
              continue;
            case 2:
              num1 = (int) num3 * -997413790 ^ -1105236298;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activePattern;
      }
      internal set
      {
        if (Engine.activePattern == null)
          goto label_12;
label_1:
        int num1 = -1301460628;
label_2:
        while (true)
        {
          int num2 = -150338281;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              num1 = (int) num3 * -1649773129 ^ 484076297;
              continue;
            case 1:
              int num4 = this.ActivePattern == null ? 1908931937 : (num4 = 241952836);
              int num5 = (int) num3 * -745627879;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * 1836978721 ^ 1630757383;
              continue;
            case 3:
              Engine.activePattern = value;
              num1 = -972572294;
              continue;
            case 4:
              this.Settings.LastActivePatternName = this.ActivePattern.PatternName;
              num1 = (int) num3 * 1202659117 ^ -373913470;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_11;
            case 7:
              num1 = (int) num3 * -1211100915 ^ 1477043361;
              continue;
            case 8:
              goto label_3;
            case 9:
              ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
              {
                ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (LayoutPattern)),
                ChangeType = ChangeType.Deactivated,
                ChangedObject = (object) Engine.activePattern
              });
              num1 = (int) num3 * 769559604 ^ -1345989513;
              continue;
            case 10:
              ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
              {
                ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (LayoutPattern)),
                ChangeType = ChangeType.Activated,
                ChangedObject = (object) Engine.activePattern
              });
              num1 = (int) num3 * 962867486 ^ 808690822;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_3:
        return;
label_11:
        int num6 = Engine.activePattern != value ? 1 : 0;
        goto label_13;
label_12:
        num6 = 0;
label_13:
        num1 = num6 == 0 ? -1438797819 : (num1 = -23946270);
        goto label_2;
      }
    }

    public event EventHandler OnMeetingJoined
    {
      add
      {
        EventHandler eventHandler1 = this.OnMeetingJoined;
label_1:
        int num1 = 1085466389;
        while (true)
        {
          int num2 = 906813556;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              int num4 = eventHandler1 == comparand ? 695128313 : (num4 = 1086413953);
              int num5 = (int) num3 * 353190442;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = eventHandler1;
              num1 = 870623903;
              continue;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingJoined, eventHandler2, comparand);
              num1 = (int) num3 * -203910174 ^ -943580442;
              continue;
            case 3:
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1757238822 ^ -326660658;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnMeetingJoined;
label_1:
        int num1 = -1800622033;
        while (true)
        {
          int num2 = -741527920;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = -1789280718;
              continue;
            case 3:
              int num4 = eventHandler1 == comparand ? -1209351405 : (num4 = -1844968345);
              int num5 = (int) num3 * -522699370;
              num1 = num4 ^ num5;
              continue;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingJoined, eventHandler2, comparand);
              num1 = (int) num3 * -177404406 ^ 1950505256;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnMeetingLeft
    {
      add
      {
        EventHandler eventHandler = this.OnMeetingLeft;
label_1:
        int num1 = 333920108;
        while (true)
        {
          int num2 = 776635006;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingLeft, (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = 982352437;
              continue;
            case 3:
              int num4 = eventHandler != comparand ? -112269149 : (num4 = -1015004868);
              int num5 = (int) num3 * -1241836531;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnMeetingLeft;
label_1:
        int num1 = 374227930;
        while (true)
        {
          int num2 = 104827796;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -3797188 ^ -537954825;
              continue;
            case 2:
              comparand = eventHandler1;
              num1 = 1023171039;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingLeft, eventHandler2, comparand);
              num1 = (int) num3 * 1610403401 ^ 1428053794;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = eventHandler1 != comparand ? -1852988499 : (num4 = -896010305);
              int num5 = (int) num3 * 909526479;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public event EventHandler OnMeetingsChanged
    {
      add
      {
        EventHandler eventHandler = this.OnMeetingsChanged;
label_1:
        int num1 = -510228174;
        while (true)
        {
          int num2 = -2012104119;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = eventHandler == comparand ? -2062424946 : (num4 = -2143866313);
              int num5 = (int) num3 * 1531559085;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingsChanged, (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = -765095696;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnMeetingsChanged;
label_1:
        int num1 = -1013616990;
        while (true)
        {
          int num2 = -1028621958;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1981931552 ^ -165413309;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num4 = eventHandler1 != comparand ? 258444097 : (num4 = 288641676);
              int num5 = (int) num3 * -72177623;
              num1 = num4 ^ num5;
              continue;
            case 4:
              comparand = eventHandler1;
              num1 = -1795592006;
              continue;
            case 5:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingsChanged, eventHandler2, comparand);
              num1 = (int) num3 * -1121434004 ^ 342258781;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public event EventHandler OnActivityStarted
    {
      add
      {
        EventHandler eventHandler1 = this.OnActivityStarted;
label_1:
        int num1 = 1288407130;
        while (true)
        {
          int num2 = 872412237;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1926177073 ^ 561740210;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityStarted, eventHandler2, comparand);
              num1 = (int) num3 * 514845177 ^ 554584218;
              continue;
            case 4:
              int num4 = eventHandler1 != comparand ? 1615113946 : (num4 = 1829084500);
              int num5 = (int) num3 * -2018273663;
              num1 = num4 ^ num5;
              continue;
            case 5:
              comparand = eventHandler1;
              num1 = 1648061053;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnActivityStarted;
label_1:
        int num1 = -1209677269;
        while (true)
        {
          int num2 = -478114272;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityStarted, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? -1191278411 : (num4 = -431262257);
              int num5 = (int) num3 * -1826773908;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1877286511 ^ 875860097;
              continue;
            case 4:
              comparand = eventHandler1;
              num1 = -1935391258;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnActivityEnded
    {
      add
      {
        EventHandler eventHandler1 = this.OnActivityEnded;
label_1:
        int num1 = -1549636302;
        while (true)
        {
          int num2 = -552125544;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = -1213790709;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityEnded, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? -1080176883 : (num4 = -1830999242);
              int num5 = (int) num3 * 1588843557;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler = this.OnActivityEnded;
label_1:
        int num1 = 352060935;
        while (true)
        {
          int num2 = 1311371041;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              comparand = eventHandler;
              num1 = 2042200014;
              continue;
            case 3:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityEnded, (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = eventHandler != comparand ? -356717812 : (num4 = -1545442025);
              int num5 = (int) num3 * 1107209637;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public event EventHandler OnActivityChanged
    {
      add
      {
        EventHandler eventHandler1 = this.OnActivityChanged;
label_1:
        int num1 = 593225536;
        while (true)
        {
          int num2 = 148286208;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityChanged, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? -70596032 : (num4 = -1284961316);
              int num5 = (int) num3 * 1394498537;
              num1 = num4 ^ num5;
              continue;
            case 3:
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1516126550 ^ 2034092758;
              continue;
            case 4:
              comparand = eventHandler1;
              num1 = 1750503871;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnActivityChanged;
label_1:
        int num1 = -1035586771;
        while (true)
        {
          int num2 = -1673601865;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1602753887 ^ -1240981193;
              continue;
            case 2:
              comparand = eventHandler1;
              num1 = -340369105;
              continue;
            case 3:
              goto label_1;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityChanged, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? 383253395 : (num4 = 775999565);
              int num5 = (int) num3 * -497857884;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnActivityProgressReport
    {
      add
      {
        EventHandler eventHandler = this.OnActivityProgressReport;
label_1:
        int num1 = -180780471;
        while (true)
        {
          int num2 = -970071100;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityProgressReport, (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -444604908 ^ 799889071;
              continue;
            case 1:
              int num4 = eventHandler != comparand ? -1056482390 : (num4 = -882413934);
              int num5 = (int) num3 * -1017695211;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              comparand = eventHandler;
              num1 = -2131149225;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler = this.OnActivityProgressReport;
label_1:
        int num1 = -488237211;
        while (true)
        {
          int num2 = -800118401;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityProgressReport, (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -1255859338 ^ -1395023941;
              continue;
            case 2:
              comparand = eventHandler;
              num1 = -285529957;
              continue;
            case 3:
              int num4 = eventHandler == comparand ? -122935934 : (num4 = -893311687);
              int num5 = (int) num3 * -2084455455;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnPatternChanged
    {
      add
      {
        EventHandler eventHandler1 = this.OnPatternChanged;
label_1:
        int num1 = -1985109101;
        while (true)
        {
          int num2 = -1737993604;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              int num4 = eventHandler1 != comparand ? -907803409 : (num4 = -143053781);
              int num5 = (int) num3 * -1274254506;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = eventHandler1;
              num1 = -1809022728;
              continue;
            case 2:
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1592764549 ^ -1225810037;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnPatternChanged, eventHandler2, comparand);
              num1 = (int) num3 * -16256328 ^ 1180681774;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnPatternChanged;
label_1:
        int num1 = 1356441177;
        while (true)
        {
          int num2 = 1699830242;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = 366055489;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = eventHandler1 == comparand ? -1181274178 : (num4 = -908952715);
              int num5 = (int) num3 * -40219065;
              num1 = num4 ^ num5;
              continue;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnPatternChanged, eventHandler2, comparand);
              num1 = (int) num3 * -1734748614 ^ 1214405240;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnQuitApplicationRequested
    {
      add
      {
        EventHandler eventHandler1 = this.OnQuitApplicationRequested;
label_1:
        int num1 = -1927149063;
        while (true)
        {
          int num2 = -1821151565;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnQuitApplicationRequested, eventHandler2, comparand);
              num1 = (int) num3 * 516201671 ^ -284761013;
              continue;
            case 2:
              int num4 = eventHandler1 != comparand ? -1541117879 : (num4 = -941505964);
              int num5 = (int) num3 * 1453828316;
              num1 = num4 ^ num5;
              continue;
            case 3:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = -1852288217;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnQuitApplicationRequested;
label_1:
        int num1 = 890067774;
        while (true)
        {
          int num2 = 112217281;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1805408765 ^ 786193875;
              continue;
            case 1:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnQuitApplicationRequested, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? -42833206 : (num4 = -688430171);
              int num5 = (int) num3 * -1799475946;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              comparand = eventHandler1;
              num1 = 1525943341;
              continue;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnLogMessageChanged
    {
      add
      {
        EventHandler eventHandler1 = this.OnLogMessageChanged;
label_1:
        int num1 = 237227302;
        while (true)
        {
          int num2 = 1054077877;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 334356268 ^ 1974000088;
              continue;
            case 1:
              goto label_3;
            case 2:
              int num4 = eventHandler1 != comparand ? 1551059836 : (num4 = 617727272);
              int num5 = (int) num3 * -1393540891;
              num1 = num4 ^ num5;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnLogMessageChanged, eventHandler2, comparand);
              num1 = (int) num3 * 1702737573 ^ 1762763926;
              continue;
            case 4:
              goto label_1;
            case 5:
              comparand = eventHandler1;
              num1 = 1834542257;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler = this.OnLogMessageChanged;
label_1:
        int num1 = -667977522;
        while (true)
        {
          int num2 = -1693238399;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = eventHandler == comparand ? -1507576442 : (num4 = -1627860849);
              int num5 = (int) num3 * -435700587;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnLogMessageChanged, (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = -1523655044;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public event EventHandler OnWindowStateChange
    {
      add
      {
        EventHandler eventHandler1 = this.OnWindowStateChange;
label_1:
        int num1 = -1007314129;
        while (true)
        {
          int num2 = -1516816509;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num4 = eventHandler1 != comparand ? 305369601 : (num4 = 15644603);
              int num5 = (int) num3 * -568876603;
              num1 = num4 ^ num5;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowStateChange, eventHandler2, comparand);
              num1 = (int) num3 * -1202362191 ^ 1800689023;
              continue;
            case 4:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = -1623362743;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnWindowStateChange;
label_1:
        int num1 = 1946960825;
        while (true)
        {
          int num2 = 165296822;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowStateChange, eventHandler2, comparand);
              num1 = (int) num3 * -1034950835 ^ -586404758;
              continue;
            case 1:
              comparand = eventHandler1;
              num1 = 1349934013;
              continue;
            case 2:
              int num4 = eventHandler1 != comparand ? 704188457 : (num4 = 116857032);
              int num5 = (int) num3 * 1220570748;
              num1 = num4 ^ num5;
              continue;
            case 3:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1040681120 ^ 1624634582;
              continue;
            case 4:
              goto label_3;
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

    public event EventHandler OnWindowHighlightStart
    {
      add
      {
        EventHandler eventHandler1 = this.OnWindowHighlightStart;
label_1:
        int num1 = 1081652383;
        while (true)
        {
          int num2 = 1964393505;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightStart, eventHandler2, comparand);
              num1 = (int) num3 * -1911267992 ^ -100431728;
              continue;
            case 1:
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -966860181 ^ 1452390740;
              continue;
            case 2:
              comparand = eventHandler1;
              num1 = 844504652;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              int num4 = eventHandler1 == comparand ? 956900912 : (num4 = 1473440644);
              int num5 = (int) num3 * -81695045;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnWindowHighlightStart;
label_1:
        int num1 = -635045587;
        while (true)
        {
          int num2 = -342816704;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1873806755 ^ 1851272343;
              continue;
            case 2:
              int num4 = eventHandler1 == comparand ? 917829814 : (num4 = 1696934841);
              int num5 = (int) num3 * -830168851;
              num1 = num4 ^ num5;
              continue;
            case 3:
              comparand = eventHandler1;
              num1 = -1967803441;
              continue;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightStart, eventHandler2, comparand);
              num1 = (int) num3 * 954516042 ^ 1271461664;
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

    public event EventHandler OnWindowHighlightEnd
    {
      add
      {
        EventHandler eventHandler = this.OnWindowHighlightEnd;
label_1:
        int num1 = 1452459939;
        while (true)
        {
          int num2 = 1893783465;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              EventHandler comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightEnd, (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value), comparand);
              int num4;
              num1 = num4 = eventHandler != comparand ? 1452459939 : (num4 = 1557857333);
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
      remove
      {
        EventHandler eventHandler1 = this.OnWindowHighlightEnd;
label_1:
        int num1 = -1677782111;
        while (true)
        {
          int num2 = -738061386;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler1;
              num1 = -390001977;
              continue;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightEnd, eventHandler2, comparand);
              num1 = (int) num3 * -107500337 ^ 1221247568;
              continue;
            case 3:
              eventHandler2 = (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1995470920 ^ -384035698;
              continue;
            case 4:
              int num4 = eventHandler1 != comparand ? 1442887131 : (num4 = 1905900234);
              int num5 = (int) num3 * 1327195687;
              num1 = num4 ^ num5;
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

    public event EventHandler OnWindowHighlightUpdate
    {
      add
      {
        EventHandler eventHandler1 = this.OnWindowHighlightUpdate;
label_1:
        int num1 = 226567811;
        while (true)
        {
          int num2 = 690015740;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightUpdate, eventHandler2, comparand);
              num1 = (int) num3 * -574213435 ^ -1767289794;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num4 = eventHandler1 == comparand ? 2089892894 : (num4 = 1069549256);
              int num5 = (int) num3 * 612304997;
              num1 = num4 ^ num5;
              continue;
            case 4:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value);
              num1 = 1655257269;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler = this.OnWindowHighlightUpdate;
label_1:
        int num1 = -842556284;
        while (true)
        {
          int num2 = -540378203;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightUpdate, (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = -316567942;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = eventHandler != comparand ? -1076177290 : (num4 = -1552007661);
              int num5 = (int) num3 * 18464590;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public event EventHandler OnEngineEvent
    {
      add
      {
        EventHandler eventHandler = this.OnEngineEvent;
label_1:
        int num1 = -371368577;
        while (true)
        {
          int num2 = -2105439221;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnEngineEvent, (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -1918924234 ^ -2120862896;
              continue;
            case 3:
              int num4 = eventHandler == comparand ? -547790830 : (num4 = -824619903);
              int num5 = (int) num3 * -326741358;
              num1 = num4 ^ num5;
              continue;
            case 4:
              comparand = eventHandler;
              num1 = -881279007;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler = this.OnEngineEvent;
label_1:
        int num1 = 103158556;
        while (true)
        {
          int num2 = 490316696;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler;
              num1 = 1030320625;
              continue;
            case 2:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnEngineEvent, (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -1388519554 ^ -546556853;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = eventHandler != comparand ? -1414026832 : (num4 = -1670428523);
              int num5 = (int) num3 * 1975641372;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnSettingChanged
    {
      add
      {
        EventHandler eventHandler = this.OnSettingChanged;
label_1:
        int num1 = -1975873754;
        while (true)
        {
          int num2 = -810073629;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnSettingChanged, (EventHandler) Engine.\u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -1515776146 ^ -386815624;
              continue;
            case 2:
              int num4 = eventHandler == comparand ? 852697557 : (num4 = 1865253594);
              int num5 = (int) num3 * -1072063012;
              num1 = num4 ^ num5;
              continue;
            case 3:
              comparand = eventHandler;
              num1 = -1463460652;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler = this.OnSettingChanged;
label_1:
        int num1 = 2110748022;
        while (true)
        {
          int num2 = 469960819;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler;
              num1 = 2064544569;
              continue;
            case 2:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnSettingChanged, (EventHandler) Engine.\u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = eventHandler == comparand ? 1066962283 : (num4 = 420355070);
              int num5 = (int) num3 * -1324466444;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    static Engine()
    {
label_1:
      int num1 = 992777262;
      while (true)
      {
        int num2 = 1443345887;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 22U)
        {
          case 0:
            Engine.engineLock = Engine.\u200E‮⁪⁪⁭‫⁪‫‍‪​‮⁮‏‮‍⁭⁮‌‭‌⁮‮⁮​​⁭⁫‍⁭⁪‎‪⁯​‮​‪⁯‬‮();
            Engine.instance = (Engine) null;
            num1 = (int) num3 * 1951495150 ^ 1310336077;
            continue;
          case 1:
            Engine.windows = new LockedObservableCollection<ZoomWindow>();
            Engine.savedActivities = new ConcurrentBag<ActivityBase>();
            Engine.JoinOrder = new List<string>();
            num1 = (int) num3 * -157649105 ^ 1756844743;
            continue;
          case 2:
            Engine.patterns = new ObservableCollection<LayoutPattern>();
            Engine.activeUsers = new ObservableCollection<string>();
            num1 = (int) num3 * -1459779797 ^ -420311765;
            continue;
          case 3:
            Engine.messageCategories = new LockedObservableCollection<MessageCategory>();
            Engine.messageContents = new LockedObservableCollection<MessageContent>();
            num1 = (int) num3 * -1099321571 ^ -2123815859;
            continue;
          case 4:
            Engine.eventManager = EventManager.Instance;
            Engine.hookManager = EventHookManager.Instance;
            num1 = (int) num3 * 254270714 ^ -1724047281;
            continue;
          case 5:
            Engine.isExecuting = false;
            num1 = (int) num3 * -518128608 ^ -1750528290;
            continue;
          case 6:
            Engine.activitiesPending = new List<ActivityBase>();
            Engine.activitiesCompleted = new ConcurrentBag<ActivityBase>();
            num1 = (int) num3 * -270593491 ^ -1632818516;
            continue;
          case 7:
            Engine.context = Engine.\u200C⁮⁪‮​‮‌⁫⁯⁯​‏⁫‭‭‭⁮‌‮⁯‪​‭‪⁮⁯⁬‪⁬‎‫⁪‏‍‫⁬⁭‏‎⁫‮() ?? Engine.\u202D‏⁮⁪‭⁯‭‏‏‌⁫‪⁭‌‫‎​⁮‫‫‬‍‪⁬​⁬⁬‬‬‫⁯‮⁪⁭⁭‏‭‎⁭‪‮();
            num1 = 519728623;
            continue;
          case 8:
            goto label_1;
          case 9:
            Engine.activePattern = (LayoutPattern) null;
            num1 = (int) num3 * -1826877330 ^ 1244784548;
            continue;
          case 10:
            Engine.users = new ConcurrentBag<ZoomUser>();
            Engine.activitiesOnHold = new ConcurrentDictionary<string, ActivityBase>();
            Engine.activityQueue = new ConcurrentQueue<ZoomEvent>();
            Engine.eventQueue = new ConcurrentQueue<ZoomEvent>();
            Engine.hookQueue = new ConcurrentQueue<ZoomEvent>();
            Engine.layoutQueue = new ConcurrentQueue<ZoomEvent>();
            Engine.windowQueue = new ConcurrentQueue<ZoomEvent>();
            num1 = (int) num3 * -1240992972 ^ 147935967;
            continue;
          case 11:
            Engine.mainProcess = Engine.\u202E‭‮⁯‫‎‭‌‮​‭‬‌⁬⁭‎⁯⁫​⁫‬‎‭‮⁫​‬‮‭⁪‍‌⁭​‪⁮⁯⁪⁫‫‮();
            num1 = (int) num3 * -1244750194 ^ 1186891172;
            continue;
          case 12:
            Engine.windowManager = WindowManager.Instance;
            Engine.activityManager = ActivityManager.Instance;
            num1 = (int) num3 * 1644103495 ^ -718265848;
            continue;
          case 13:
            Engine.settings = new Settings();
            Engine.managersTokenSource = Engine.\u206A‪⁪⁬⁭⁬‪‬⁪‪⁭⁮⁬‫⁮⁮​⁫‭‍‏‫‏‮⁯⁭‫⁪‬⁭⁫‏⁫⁫‮⁪⁪‮⁪‪‮();
            Engine.startupTime = DateTime.Now;
            Engine.zoomDatabase = (ZoomDB) null;
            Engine.zoomZoomDatabase = (ZoomZoomDatabase) null;
            num1 = (int) num3 * 1720639120 ^ -758017928;
            continue;
          case 14:
            Engine.buttons = new ObservableCollection<ZoomButton>();
            num1 = (int) num3 * -2046810600 ^ -725159704;
            continue;
          case 15:
            Engine.JoinOrderIndex = -1;
            num1 = (int) num3 * -275865883 ^ 2048700812;
            continue;
          case 16:
            Engine.quitApplication = false;
            num1 = (int) num3 * 255607777 ^ 873701281;
            continue;
          case 18:
            Engine.meetings = new ObservableCollection<ZoomMeeting>();
            num1 = (int) num3 * 1923579024 ^ 1136094189;
            continue;
          case 19:
            Engine.activeWindows = new ConcurrentBag<ZoomWindow>();
            num1 = (int) num3 * 737647288 ^ 989429931;
            continue;
          case 20:
            Engine.images = new LockedObservableCollection<ZoomImage>();
            num1 = (int) num3 * -1940413555 ^ 2080141470;
            continue;
          case 21:
            Engine.chatManager = ChatManager.Instance;
            num1 = (int) num3 * 1763407378 ^ -1657613373;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      Engine.currentName = string.Empty;
    }

    private Engine()
    {
      this._eventAggregator = ApplicationService.Instance.EventAggregator;
    }

    internal void SetUserAsFlooding(string userName)
    {
      try
      {
label_2:
        int num1 = 269754517;
        while (true)
        {
          int num2 = 17201778;
          uint num3;
          string str;
          bool flag1;
          ZoomUser user;
          bool flag2;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 19U)
          {
            case 0:
              num1 = (int) num3 * 1851974901 ^ 1925808411;
              continue;
            case 1:
              int num4 = flag1 ? 40224857 : (num4 = 1681384168);
              int num5 = (int) num3 * 449775651;
              num1 = num4 ^ num5;
              continue;
            case 2:
              flag2 = user != null;
              num1 = (int) num3 * -859104627 ^ -993484241;
              continue;
            case 3:
              num1 = 1817143098;
              continue;
            case 4:
              str = Engine.\u200B⁬​⁭‫‪‏⁯⁯‬‫‮‎‬‪⁫‪‬‮⁬‬⁭‫⁮‍⁭⁭⁫⁬‍‍⁭‫‭‮​‬⁪‬‏‮(str, userName);
              num1 = 1580528788;
              continue;
            case 5:
              num1 = (int) num3 * -1043015155 ^ 1781191749;
              continue;
            case 6:
              goto label_2;
            case 7:
              flag1 = !Engine.\u202B⁫⁮⁯‬‭⁫‪‫‮‬‭⁮‭‍‍⁯‌‌⁭‌⁫‎‮‍​‬‎‮‪⁫⁯‍⁮‍⁯⁯⁫⁪⁫‮(str, userName);
              num1 = (int) num3 * 74012912 ^ 59094863;
              continue;
            case 8:
              num1 = (int) num3 * 1653515879 ^ 106498541;
              continue;
            case 9:
              int num6 = flag2 ? -156089699 : (num6 = -1282557739);
              int num7 = (int) num3 * -1133724919;
              num1 = num6 ^ num7;
              continue;
            case 10:
              this.Settings.DesktopAlert_IgnoredUsers = userName;
              num1 = (int) num3 * 750587916 ^ -1698329340;
              continue;
            case 11:
              str = Engine.\u200B⁬​⁭‫‪‏⁯⁯‬‫‮‎‬‪⁫‪‬‮⁬‬⁭‫⁮‍⁭⁭⁫⁬‍‍⁭‫‭‮​‬⁪‬‏‮(str, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1783281445U));
              num1 = (int) num3 * 2045873864 ^ 1550601639;
              continue;
            case 12:
              num1 = (int) num3 * -668116040 ^ -643399713;
              continue;
            case 13:
              int num8 = !flag3 ? -1390192497 : (num8 = -350089469);
              int num9 = (int) num3 * 497494944;
              num1 = num8 ^ num9;
              continue;
            case 14:
              flag3 = !Engine.\u206C⁬⁯⁫‫‍‍⁯‌⁭⁬‍⁯‫⁫⁫⁫‫‏‏‪‪‌‏‫‮​‎⁭‮‍‏‪‬⁬‭⁪‍⁯‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3813324439U));
              num1 = (int) num3 * -28568388 ^ -1705146223;
              continue;
            case 15:
              str = Engine.\u200F‏‪​⁭⁭‎‪⁫‍⁭⁭‫⁬‫⁪⁭‎⁫⁪⁪‏‭⁬‌⁯‮‌​‭‪⁮‪⁮⁪⁮‭⁯⁯‪‮(this.Settings.DesktopAlert_IgnoredUsers);
              num1 = (int) num3 * -1880083527 ^ 1390853259;
              continue;
            case 16:
              user = this.GetUser(userName, true);
              num1 = 788224483;
              continue;
            case 17:
              goto label_25;
            case 18:
              user.BlockUser();
              num1 = (int) num3 * 1945495338 ^ -708506704;
              continue;
            default:
              goto label_21;
          }
        }
label_21:
        return;
label_25:;
      }
      catch (Exception ex)
      {
label_23:
        int num1 = 66730497;
        while (true)
        {
          int num2 = 17201778;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_23;
            case 1:
              num1 = (int) num3 * 1625391498 ^ 55851750;
              continue;
            case 3:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * -1958872685 ^ -149310750;
              continue;
            default:
              goto label_28;
          }
        }
label_28:
        throw;
      }
    }

    public void Initialize(Dispatcher dispatcher, CancellationToken token)
    {
      this.Token = token;
label_1:
      int num1 = -933206339;
      ZoomZoomDatabase zoomZoomDatabase;
      while (true)
      {
        int num2 = -1420926698;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            if (flag)
            {
              num1 = (int) num3 * 1300431303 ^ -1631969567;
              continue;
            }
            goto label_25;
          case 1:
            this.RaiseEvent(EngineEvent.LoadingData, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1208303262U));
            num1 = (int) num3 * 2039382862 ^ -16816187;
            continue;
          case 2:
            this.SetDispatcher(dispatcher);
            num1 = (int) num3 * 259897068 ^ 1955607743;
            continue;
          case 3:
            num1 = (int) num3 * -859317747 ^ -1741130885;
            continue;
          case 5:
            flag = Engine.zoomZoomDatabase == null;
            num1 = (int) num3 * 1240225197 ^ 1835565431;
            continue;
          case 6:
            goto label_1;
          case 7:
            zoomZoomDatabase = new ZoomZoomDatabase(true);
            num1 = (int) num3 * 426616763 ^ 1940428583;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_12:
        int num2 = -1557884009;
        while (true)
        {
          int num3 = -1420926698;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_12;
            case 2:
              Engine.zoomZoomDatabase = zoomZoomDatabase;
              num2 = (int) num4 * -65120572 ^ 742784809;
              continue;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_16:
          int num2 = -417685007;
          while (true)
          {
            int num3 = -1420926698;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 183578466 ^ -896653246;
                continue;
              case 2:
                goto label_16;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:
label_22:
      int num5 = -1397420951;
label_23:
      bool flag2;
      while (true)
      {
        int num2 = -1420926698;
        uint num3;
        bool flag3;
        CancellationTokenSource cancellationTokenSource;
        switch ((num3 = (uint) (num5 ^ num2)) % 41U)
        {
          case 0:
            num5 = (int) num3 * 160398792 ^ 1847122924;
            continue;
          case 1:
            this.LoadMessageCategories();
            num5 = (int) num3 * 1553955531 ^ -280544748;
            continue;
          case 2:
            Engine.zoomZoomDatabase.UpgradeDatabaseSchema();
            num5 = (int) num3 * -484102757 ^ -1498537609;
            continue;
          case 3:
            num5 = (int) num3 * -918682020 ^ 35151923;
            continue;
          case 4:
            num5 = (int) num3 * 655684508 ^ 1435517892;
            continue;
          case 5:
            this.RaiseEvent(EngineEvent.ValidatingSchema, (Exception) null, false);
            num5 = (int) num3 * 890158310 ^ -1352139183;
            continue;
          case 6:
            num5 = (int) num3 * -423924691 ^ -1276746670;
            continue;
          case 7:
            num5 = (int) num3 * -223887830 ^ 1034497049;
            continue;
          case 8:
            this.SharedData.Context = Engine.context;
            SharedData.contextId = Engine.\u206E⁮‬⁮​⁮‭‭‭⁮‪⁫‫⁭⁫‮⁬‬‍‭⁬‍​‏‎⁮⁭⁪‎‎​​‌⁯⁭‏‫⁫‏⁮‮(Engine.\u200D⁭⁬‪⁫‍⁯⁯⁬‌‎⁪⁮⁯⁯⁬‬⁯‌⁮‬⁫⁫‮‭‫‭‬‫⁬‫⁬‌​‭⁬‏‬⁯‫‮());
            this.SharedData.App = this;
            num5 = (int) num3 * 544397103 ^ 1775696282;
            continue;
          case 9:
            flag3 = !Engine.zoomZoomDatabase.IsSchemaValid;
            num5 = (int) num3 * 645954033 ^ 158768007;
            continue;
          case 10:
            this.SharedData.HookQueue = this.HookQueue;
            num5 = (int) num3 * -1474990174 ^ -1452494613;
            continue;
          case 11:
            this.SharedData.ActivityQueue = this.ActivityQueue;
            num5 = (int) num3 * -219597733 ^ 1276172057;
            continue;
          case 12:
            num5 = (int) num3 * -11327865 ^ -1888690971;
            continue;
          case 13:
            num5 = (int) num3 * 301366998 ^ -1148895945;
            continue;
          case 14:
            this.SharedData.ActiveWindows = this.ActiveWindows;
            num5 = (int) num3 * 1179083910 ^ 1717337115;
            continue;
          case 15:
            int num4 = !flag3 ? -694604736 : (num4 = -1119792615);
            int num6 = (int) num3 * -2141277196;
            num5 = num4 ^ num6;
            continue;
          case 16:
            this.SharedData.WindowQueue = this.WindowQueue;
            num5 = (int) num3 * -113895618 ^ 1750047329;
            continue;
          case 17:
            this.LoadMeetings();
            num5 = -1870896725;
            continue;
          case 18:
            num5 = (int) num3 * 1185338641 ^ 267210901;
            continue;
          case 19:
            cancellationTokenSource = Engine.\u206A‪⁪⁬⁭⁬‪‬⁪‪⁭⁮⁬‫⁮⁮​⁫‭‍‏‫‏‮⁯⁭‫⁪‬⁭⁫‏⁫⁫‮⁪⁪‮⁪‪‮();
            num5 = (int) num3 * 202981345 ^ -1719257606;
            continue;
          case 20:
            num5 = (int) num3 * 1016626546 ^ 796689303;
            continue;
          case 21:
            num5 = (int) num3 * 125345515 ^ 1389441646;
            continue;
          case 22:
            int num7 = !flag2 ? 524313293 : (num7 = 194802918);
            int num8 = (int) num3 * 956905207;
            num5 = num7 ^ num8;
            continue;
          case 23:
            Engine.settings.Initialize(this.SharedData);
            num5 = (int) num3 * 1191129681 ^ 1978008485;
            continue;
          case 24:
            num5 = (int) num3 * -90196574 ^ 1478106013;
            continue;
          case 25:
            goto label_25;
          case 26:
            this.LoadButtons();
            num5 = (int) num3 * -827897252 ^ 1874393171;
            continue;
          case 27:
            Engine.zoomDatabase = new ZoomDB();
            num5 = (int) num3 * 1422360639 ^ -1414308749;
            continue;
          case 28:
            this.Token = Engine.\u206F‍​⁪⁯⁬⁯⁯⁯⁫‏‬‮‌‎⁬⁭⁬‬‏⁯‍‌‫⁪‪⁪⁮‪‬‍‌‏⁭‭​⁫‬⁬⁬‮(cancellationTokenSource);
            num5 = (int) num3 * -1011617177 ^ -1667770367;
            continue;
          case 29:
            num5 = (int) num3 * -1823926214 ^ -2141994370;
            continue;
          case 30:
            this.SharedData = new SharedData();
            num5 = (int) num3 * -54710442 ^ 1728344761;
            continue;
          case 31:
            this.SharedData.Settings = Engine.settings;
            num5 = (int) num3 * -768267783 ^ 922291772;
            continue;
          case 32:
            num5 = (int) num3 * -966664717 ^ -1352176357;
            continue;
          case 33:
            this.LogException(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(181920185U));
            num5 = (int) num3 * 612640568 ^ 901862419;
            continue;
          case 34:
            goto label_24;
          case 35:
            this.LoadMessageContents();
            num5 = (int) num3 * -172680105 ^ 1265108352;
            continue;
          case 36:
            goto label_58;
          case 37:
            this.RaiseEvent(EngineEvent.LoadingData, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3908219621U));
            num5 = -985264130;
            continue;
          case 38:
            Engine.settings = new Settings();
            num5 = (int) num3 * 980183495 ^ -982420747;
            continue;
          case 39:
            this.SharedData.ActivitiesCompleted = this.ActivitiesCompleted;
            num5 = (int) num3 * 1915860233 ^ 979364243;
            continue;
          case 40:
            goto label_22;
          default:
            goto label_18;
        }
      }
label_18:
      return;
label_24:
      return;
label_58:
      Exception ex = Engine.\u206F‮⁬⁭‮‪‪‌‏‬‌⁮‍‎⁬‎⁪⁫‍‏⁯‭‌⁪‮⁫⁪⁯‌‭⁪⁪⁫‎‌⁬‫‭‭‏‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(295973787U));
      this.RaiseEvent(EngineEvent.Error, ex, false);
      throw ex;
label_25:
      flag2 = Engine.zoomZoomDatabase.DatabaseExists();
      num5 = -688593482;
      goto label_23;
    }

    public List<ZoomImage> GetImages(ImageEnums.ImageType imageType)
    {
      if (imageType == ImageEnums.ImageType.All)
        goto label_4;
label_1:
      int num1 = -2067612987;
label_2:
      List<ZoomImage> images;
      List<ZoomImage> zoomImageList;
      while (true)
      {
        int num2 = -1916485684;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            images = this.ZoomZoomDatabase.GetImages(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1372309215U) + ((int) imageType).ToString());
            num1 = (int) num3 * 1542255337 ^ -814464056;
            continue;
          case 1:
            num1 = (int) num3 * 1982627300 ^ 1967298385;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -308640419 ^ 1237696746;
            continue;
          case 4:
            goto label_4;
          case 5:
            zoomImageList = images;
            num1 = -848036668;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return zoomImageList;
label_4:
      images = this.ZoomZoomDatabase.GetImages(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4150846292U));
      num1 = -1666003717;
      goto label_2;
    }

    private void SetDispatcher(Dispatcher dispatcher)
    {
label_1:
      int num1 = 573311715;
      while (true)
      {
        int num2 = 1185258541;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -2091638472 ^ 1353194857;
            continue;
          case 2:
            this.UserInterfaceDispatcher = dispatcher;
            num1 = (int) num3 * 455507150 ^ -222600320;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    internal List<ZoomWindow> GetOverlappedWindows(ZoomWindow window)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass118_0 displayClass1180 = new Engine.\u003C\u003Ec__DisplayClass118_0();
label_1:
      int num1 = 2081513130;
      while (true)
      {
        int num2 = 1752287095;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass1180.window = window;
            num1 = (int) num3 * -1902606789 ^ 2134390515;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      List<ZoomWindow> zoomWindowList;
      try
      {
label_6:
        int num2 = 1964740780;
        while (true)
        {
          int num3 = 1752287095;
          uint num4;
          bool flag1;
          bool flag2;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 15U)
          {
            case 0:
              int num6 = !flag2 ? 87973085 : (num6 = 230542504);
              int num7 = (int) num4 * -502132117;
              num2 = num6 ^ num7;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated field
              flag2 = displayClass1180.window != null;
              num2 = 2010668057;
              continue;
            case 2:
              // ISSUE: method pointer
              zoomWindowList = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) displayClass1180, __methodptr(\u003CGetOverlappedWindows\u003Eb__0)))).ToList<ZoomWindow>();
              num2 = (int) num4 * 924773558 ^ -1245686864;
              continue;
            case 3:
              // ISSUE: method pointer
              zoomWindowList = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) displayClass1180, __methodptr(\u003CGetOverlappedWindows\u003Eb__1)))).ToList<ZoomWindow>();
              num2 = (int) num4 * 653392704 ^ 734650822;
              continue;
            case 4:
              goto label_6;
            case 5:
              zoomWindowList = new List<ZoomWindow>();
              num2 = 1334813656;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              if (displayClass1180.window != null)
              {
                num2 = (int) num4 * -989368470 ^ 1708258937;
                continue;
              }
              num5 = 0;
              break;
            case 7:
              // ISSUE: reference to a compiler-generated field
              num5 = displayClass1180.window.ZoomWindowType == ZoomWindowType.Video ? 1 : 0;
              break;
            case 8:
              num2 = (int) num4 * -2100610628 ^ -1904936118;
              continue;
            case 9:
              num2 = (int) num4 * -1881732528 ^ -2067795916;
              continue;
            case 10:
              int num8 = flag1 ? 437272375 : (num8 = 695977580);
              int num9 = (int) num4 * -57035795;
              num2 = num8 ^ num9;
              continue;
            case 12:
              num2 = (int) num4 * 996615701 ^ 1928956321;
              continue;
            case 13:
              num2 = (int) num4 * -823787918 ^ 1541340240;
              continue;
            case 14:
              num2 = (int) num4 * 767556856 ^ -136600617;
              continue;
            default:
              goto label_30;
          }
          flag1 = num5 != 0;
          num2 = 4931353;
        }
      }
      catch (Exception ex)
      {
label_25:
        int num2 = 231679484;
        while (true)
        {
          int num3 = 1752287095;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_25;
            case 1:
              num2 = (int) num4 * -1925798062 ^ 1404429400;
              continue;
            case 3:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num2 = (int) num4 * -909790102 ^ -1185614852;
              continue;
            case 4:
              zoomWindowList = new List<ZoomWindow>();
              num2 = (int) num4 * -35595445 ^ -467570788;
              continue;
            default:
              goto label_30;
          }
        }
      }
label_30:
      return zoomWindowList;
    }

    public void RaiseEvent(EngineEvent engineEvent, Exception ex = null, bool quitApplication = false)
    {
      EngineEventArgs engineEventArgs1 = new EngineEventArgs(this);
      engineEventArgs1.EngineEvent = engineEvent;
      int engineState = (int) this.EngineState;
      engineEventArgs1.EngineState = (EngineState) engineState;
      int machineState = (int) this.MachineState;
      engineEventArgs1.MachineState = (MachineState) machineState;
      Exception exception = ex;
      engineEventArgs1.Exception = exception;
      int num1 = quitApplication ? 1 : 0;
      engineEventArgs1.QuitApplication = num1 != 0;
      EngineEventArgs engineEventArgs2 = engineEventArgs1;
label_1:
      int num2 = 1402907126;
      while (true)
      {
        int num3 = 1076481667;
        uint num4;
        bool flag;
        switch ((num4 = (uint) (num2 ^ num3)) % 8U)
        {
          case 0:
            num2 = (int) num4 * -1403536948 ^ 1556224964;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            int num5 = !flag ? -1518829485 : (num5 = -890822110);
            int num6 = (int) num4 * -1574890949;
            num2 = num5 ^ num6;
            continue;
          case 4:
            num2 = (int) num4 * 1773010626 ^ 389369458;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            flag = this.OnEngineEvent != null;
            num2 = (int) num4 * -1805217055 ^ -726698291;
            continue;
          case 6:
            num2 = (int) num4 * -1367658867 ^ 1860989745;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            this.OnEngineEvent((object) this, (EventArgs) engineEventArgs2);
            num2 = (int) num4 * 365986411 ^ -1886980488;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    private void RaiseEvent(EngineEvent engineEvent, string statusMessage)
    {
label_1:
      int num1 = 1844449820;
      while (true)
      {
        int num2 = 398358835;
        uint num3;
        EngineEventArgs engineEventArgs1;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1268009510 ^ 1106374507;
            continue;
          case 3:
            EngineEventArgs engineEventArgs2 = new EngineEventArgs(this);
            engineEventArgs2.EngineEvent = engineEvent;
            int engineState = (int) this.EngineState;
            engineEventArgs2.EngineState = (EngineState) engineState;
            int machineState = (int) this.MachineState;
            engineEventArgs2.MachineState = (MachineState) machineState;
            string str = statusMessage;
            engineEventArgs2.StatusMessage = str;
            int num4 = Engine.quitApplication ? 1 : 0;
            engineEventArgs2.QuitApplication = num4 != 0;
            engineEventArgs1 = engineEventArgs2;
            // ISSUE: reference to a compiler-generated field
            int num5 = this.OnEngineEvent == null ? 2010533686 : (num5 = 37616047);
            int num6 = (int) num3 * -1915587170;
            num1 = num5 ^ num6;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.OnEngineEvent((object) this, (EventArgs) engineEventArgs1);
            num1 = (int) num3 * -1645516643 ^ 954375580;
            continue;
          case 5:
            num1 = (int) num3 * -1354250807 ^ 10206327;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void AttachEventHandlers()
    {
      this.EventManager.OnMeetingJoined += new EventHandler(this.EventManager_OnMeetingJoined);
label_1:
      int num1 = -1350287094;
      while (true)
      {
        int num2 = -1385776366;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 2:
            this.ActivityManager.OnActivityProgressReport += new EventHandler(this.ActivityManager_OnActivityProgressReport);
            num1 = (int) num3 * -617320236 ^ 299279883;
            continue;
          case 3:
            num1 = (int) num3 * -1674521091 ^ 588019085;
            continue;
          case 4:
            num1 = (int) num3 * 947168319 ^ -2049284664;
            continue;
          case 5:
            this.WindowManager.OnWindowHighlightStart += new EventHandler(this.WindowManager_OnWindowHighlightStart);
            this.WindowManager.OnWindowHighlightEnd += new EventHandler(this.WindowManager_OnWindowHighlightEnd);
            this.WindowManager.OnWindowHighlightUpdate += new EventHandler(this.WindowManager_OnWindowHighlightUpdate);
            num1 = (int) num3 * 1730100887 ^ 675733617;
            continue;
          case 6:
            this.WindowManager.OnWindowStateChange += new EventHandler(this.WindowManager_OnWindowStateChange);
            num1 = (int) num3 * -631174905 ^ -673242278;
            continue;
          case 7:
            this.EventManager.OnMeetingLeft += new EventHandler(this.EventManager_OnMeetingLeft);
            num1 = (int) num3 * -2021873763 ^ 79941576;
            continue;
          case 8:
            this.ActivityManager.OnActivityStarted += new EventHandler(this.ActivityManager_OnActivityStarted);
            this.ActivityManager.OnActivityEnded += new EventHandler(this.ActivityManager_OnActivityEnded);
            this.ActivityManager.OnActivityUpdated += new EventHandler(this.ActivityManager_OnActivityUpdated);
            num1 = (int) num3 * 2130992609 ^ -971906511;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      this.Settings.PropertyChanged += new PropertyChangedEventHandler(this.Settings_PropertyChanged);
    }

    private void Settings_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      if (Engine.\u200E‌⁯‭‌⁫‫⁫‏⁬‏⁮⁫‭‫⁬⁯‮⁪⁪⁫⁪‍‏​‏‫⁭⁭‌‮‍⁫‌‍⁭⁭‫‌‬‮(Engine.\u206F⁭⁯⁯​⁯⁪‏‏‌⁯‎​⁪‏​​‮⁮‮‫‮⁪⁯‌‮⁬‪‍​⁮⁪⁪‬‎‎⁪‫‫‮(e), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2471001539U)))
      {
label_1:
        int num1 = 307633686;
        while (true)
        {
          int num2 = 1222323921;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              Engine.\u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮(Engine.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2734243428U));
              num1 = (int) num3 * -324241823 ^ -1369410542;
              continue;
            case 3:
              num1 = (int) num3 * -1359898313 ^ 1494296430;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        object engineLock = Engine.engineLock;
        bool flag = false;
        List<LayoutPattern> list;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_7:
          int num2 = 902177246;
          while (true)
          {
            int num3 = 1222323921;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num2 = (int) num4 * -1963883511 ^ -382328538;
                continue;
              case 2:
                goto label_7;
              default:
                goto label_10;
            }
          }
label_10:
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: method pointer
          list = ((IEnumerable<LayoutPattern>) Enumerable.Where<LayoutPattern>((IEnumerable<M0>) this.Patterns, (Func<M0, bool>) (Engine.\u003C\u003Ec.\u003C\u003E9__170_0 ?? (Engine.\u003C\u003Ec.\u003C\u003E9__170_0 = new Func<LayoutPattern, bool>((object) Engine.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CSettings_PropertyChanged\u003Eb__170_0)))))).ToList<LayoutPattern>();
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = 1317413055;
            while (true)
            {
              int num3 = 1222323921;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * 1464801222 ^ 724578177;
                  continue;
                case 2:
                  goto label_12;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
        using (List<LayoutPattern>.Enumerator enumerator = list.GetEnumerator())
        {
label_21:
          int num2 = enumerator.MoveNext() ? 271973660 : (num2 = 147050399);
          while (true)
          {
            int num3 = 1222323921;
            uint num4;
            LayoutPattern current;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                num2 = 271973660;
                continue;
              case 1:
                current.StretchingEnabled = this.Settings.AutoLayoutsDefaultStretchingEnabled;
                num2 = (int) num4 * -834512586 ^ 441566768;
                continue;
              case 2:
                num2 = (int) num4 * -1568519205 ^ -1716089829;
                continue;
              case 3:
                current = enumerator.Current;
                num2 = 779527361;
                continue;
              case 4:
                goto label_21;
              case 6:
                num2 = (int) num4 * 941593191 ^ 596110182;
                continue;
              default:
                goto label_27;
            }
          }
        }
label_27:;
      }
      else
        goto label_31;
label_28:
      int num5 = 1476700589;
label_29:
      bool flag1;
      while (true)
      {
        int num1 = 1222323921;
        uint num2;
        switch ((num2 = (uint) (num5 ^ num1)) % 5U)
        {
          case 0:
            goto label_30;
          case 1:
            int num3 = !flag1 ? -693684115 : (num3 = -1998667349);
            int num4 = (int) num2 * 1755665809;
            num5 = num3 ^ num4;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.OnSettingChanged(sender, (EventArgs) e);
            num5 = (int) num2 * 1225382213 ^ 32777231;
            continue;
          case 3:
            goto label_31;
          case 4:
            goto label_28;
          default:
            goto label_25;
        }
      }
label_25:
      return;
label_30:
      return;
label_31:
      // ISSUE: reference to a compiler-generated field
      flag1 = this.OnSettingChanged != null;
      num5 = 1237782321;
      goto label_29;
    }

    private void ChatManager_OnChatMessageSent(object sender, EventArgs e)
    {
    }

    internal void CancelActivity(ActivityBase activity = null)
    {
label_1:
      int num1 = -195361011;
      while (true)
      {
        int num2 = -1270474401;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * 1338015299 ^ -2101174541;
            continue;
          case 1:
            goto label_4;
          case 2:
          case 7:
            num1 = -1942865237;
            continue;
          case 3:
            num1 = (int) num3 * 1482257316 ^ 581598472;
            continue;
          case 4:
label_11:
            this.ArchiveActivity(activity);
            num1 = -559022375;
            continue;
          case 5:
            activity = this.ActiveActivity;
            num1 = (int) num3 * 384105835 ^ 1586655462;
            continue;
          case 6:
            goto label_1;
          case 8:
            num1 = (int) num3 * -1726095912 ^ -443614168;
            continue;
          case 9:
            int num4 = activity == null ? 1975832015 : (num4 = 1613807266);
            int num5 = (int) num3 * 142578785;
            num1 = num4 ^ num5;
            continue;
          case 10:
label_14:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityCanceledEvent>()).Publish(new ActivityEventBaseArguments(activity, ""));
            num1 = -507775757;
            continue;
          case 11:
            switch (activity.ActivityState)
            {
              case ActivityState.Undefined:
              case ActivityState.Hold:
              case ActivityState.Pending:
              case ActivityState.Completed:
              case ActivityState.Error:
              case ActivityState.Canceled:
                goto label_11;
              case ActivityState.InProgress:
              case ActivityState.CancelRequested:
                goto label_14;
              default:
                num1 = (int) num3 * -1318962260 ^ 462653961;
                continue;
            }
          case 12:
            int num6;
            num1 = num6 = activity == null ? -1942865237 : (num6 = -1199200813);
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return;
label_4:;
    }

    private void WindowManager_OnWindowStateChange(object sender, EventArgs e)
    {
label_1:
      int num1 = -534241623;
      while (true)
      {
        int num2 = -319632161;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            int num4 = !flag ? -505279415 : (num4 = -465186551);
            int num5 = (int) num3 * 697623254;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * -1662510307 ^ 337476553;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1286086225 ^ 1113492573;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.OnWindowStateChange(sender, e);
            num1 = (int) num3 * 1389676806 ^ -1774122613;
            continue;
          case 5:
            goto label_3;
          case 6:
            // ISSUE: reference to a compiler-generated field
            flag = this.OnWindowStateChange != null;
            num1 = (int) num3 * 702057261 ^ 1487628661;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private void EventManager_OnMeetingJoined(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass174_0 displayClass1740 = new Engine.\u003C\u003Ec__DisplayClass174_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1740.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      displayClass1740.sender = sender;
label_1:
      int num1 = -1814254148;
      while (true)
      {
        int num2 = -1046425231;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            // ISSUE: method pointer
            Engine.\u206D⁭‪⁫⁭⁫⁬‮‬⁭⁯‬‍⁯‪‭⁪‮‍‍⁭⁭‌‮‎‬⁭‪‬⁮⁬‌‬‭⁪‪‫‮‎⁪‮(Engine.\u200E‏‬⁯‍‫⁬⁮‬⁭⁭⁮‍⁯‏‬⁯‪⁭⁯⁯⁮⁮⁯‫‬⁯‌​⁯‫‍‏‭‎‭‮⁭⁮⁭‮((DispatcherObject) Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮()), new Action((object) displayClass1740, __methodptr(\u003CEventManager_OnMeetingJoined\u003Eb__0)));
            num1 = -1955335718;
            continue;
          case 1:
            num4 = Engine.\u200E‏‬⁯‍‫⁬⁮‬⁭⁭⁮‍⁯‏‬⁯‪⁭⁯⁯⁮⁮⁯‫‬⁯‌​⁯‫‍‏‭‎‭‮⁭⁮⁭‮((DispatcherObject) Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮()) == null ? 1 : 0;
            break;
          case 2:
            goto label_1;
          case 3:
            int num5 = !flag ? -658563970 : (num5 = -372040950);
            int num6 = (int) num3 * -203342043;
            num1 = num5 ^ num6;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            displayClass1740.e = e;
            num1 = (int) num3 * -2047358802 ^ -1825682952;
            continue;
          case 5:
            num1 = (int) num3 * -495491348 ^ -259509023;
            continue;
          case 6:
            if (Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮() != null)
            {
              num1 = (int) num3 * 80258261 ^ 782910651;
              continue;
            }
            num4 = 1;
            break;
          case 7:
            goto label_3;
          case 8:
            num1 = (int) num3 * -27671738 ^ 145391147;
            continue;
          default:
            goto label_14;
        }
        flag = num4 != 0;
        num1 = -1150200737;
      }
label_14:
      return;
label_3:;
    }

    private void EventManager_OnMeetingLeft(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass175_0 displayClass1750 = new Engine.\u003C\u003Ec__DisplayClass175_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1750.\u003C\u003E4__this = this;
label_1:
      int num1 = 526802687;
      while (true)
      {
        int num2 = 2117614732;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            // ISSUE: method pointer
            Engine.\u206D⁭‪⁫⁭⁫⁬‮‬⁭⁯‬‍⁯‪‭⁪‮‍‍⁭⁭‌‮‎‬⁭‪‬⁮⁬‌‬‭⁪‪‫‮‎⁪‮(Engine.\u200E‏‬⁯‍‫⁬⁮‬⁭⁭⁮‍⁯‏‬⁯‪⁭⁯⁯⁮⁮⁯‫‬⁯‌​⁯‫‍‏‭‎‭‮⁭⁮⁭‮((DispatcherObject) Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮()), new Action((object) displayClass1750, __methodptr(\u003CEventManager_OnMeetingLeft\u003Eb__0)));
            num1 = 1718242204;
            continue;
          case 1:
            num1 = (int) num3 * 1301363809 ^ -1401796142;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            displayClass1750.sender = sender;
            num1 = (int) num3 * 660102583 ^ 1483342688;
            continue;
          case 3:
            goto label_1;
          case 4:
            if (Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮() != null)
            {
              num1 = (int) num3 * -101284012 ^ -1828655891;
              continue;
            }
            num4 = 1;
            break;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 1358920714 ^ 2071426010;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            displayClass1750.e = e;
            num1 = (int) num3 * -567462412 ^ 1321476368;
            continue;
          case 8:
            num4 = Engine.\u200E‏‬⁯‍‫⁬⁮‬⁭⁭⁮‍⁯‏‬⁯‪⁭⁯⁯⁮⁮⁯‫‬⁯‌​⁯‫‍‏‭‎‭‮⁭⁮⁭‮((DispatcherObject) Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮()) == null ? 1 : 0;
            break;
          default:
            goto label_14;
        }
        int num5;
        num1 = num5 = num4 != 0 ? 2002867088 : (num5 = 1757643572);
      }
label_14:
      return;
label_3:;
    }

    private void ActivityManager_OnActivityUpdated(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      if (this.OnActivityChanged == null)
        return;
label_1:
      int num1 = 40502366;
      while (true)
      {
        int num2 = 692543049;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_7;
          case 1:
            num1 = (int) num3 * 1502225229 ^ -1002426444;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.OnActivityChanged(sender, e);
            num1 = (int) num3 * 1104132191 ^ 1249177755;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 999583827 ^ 86872871;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_7:;
    }

    private void ActivityManager_OnActivityEnded(object sender, EventArgs e)
    {
label_1:
      int num1 = -2113419939;
      while (true)
      {
        int num2 = -1417246318;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            this.OnActivityEnded(sender, e);
            num1 = (int) num3 * -320397447 ^ 1512862355;
            continue;
          case 2:
            num1 = (int) num3 * 1414274792 ^ 238835054;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            int num4 = this.OnActivityEnded != null ? 994773998 : (num4 = 1778502718);
            int num5 = (int) num3 * -1743890264;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private void ActivityManager_OnActivityStarted(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      bool flag = this.OnActivityStarted != null;
label_1:
      int num1 = -1955968948;
      while (true)
      {
        int num2 = -731014789;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            int num4 = flag ? 193889163 : (num4 = 1663021552);
            int num5 = (int) num3 * -69234930;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 320576076 ^ 1725759818;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.OnActivityStarted(sender, e);
            num1 = (int) num3 * -951998005 ^ 2055497159;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    internal void AddActiveUser(ChatEventArgs args)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass179_0 displayClass1790 = new Engine.\u003C\u003Ec__DisplayClass179_0();
label_1:
      int num1 = -664223648;
      while (true)
      {
        int num2 = -2119683415;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            int num5 = !flag ? -103694138 : (num5 = -1777043723);
            int num6 = (int) num3 * 89547293;
            num1 = num5 ^ num6;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass1790.\u003C\u003E4__this = this;
            // ISSUE: reference to a compiler-generated field
            displayClass1790.args = args;
            // ISSUE: reference to a compiler-generated field
            displayClass1790.changed = false;
            num1 = (int) num3 * 863207469 ^ -1472868075;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * -1626203851 ^ -1581954136;
            continue;
          case 4:
            goto label_1;
          case 5:
            if (Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮() != null)
            {
              num1 = (int) num3 * -628123373 ^ -1145204151;
              continue;
            }
            num4 = 1;
            break;
          case 6:
            num4 = Engine.\u200E‏‬⁯‍‫⁬⁮‬⁭⁭⁮‍⁯‏‬⁯‪⁭⁯⁯⁮⁮⁯‫‬⁯‌​⁯‫‍‏‭‎‭‮⁭⁮⁭‮((DispatcherObject) Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮()) == null ? 1 : 0;
            break;
          case 7:
            num1 = (int) num3 * -434163843 ^ -939634821;
            continue;
          case 8:
            // ISSUE: method pointer
            Engine.\u206D⁭‪⁫⁭⁫⁬‮‬⁭⁯‬‍⁯‪‭⁪‮‍‍⁭⁭‌‮‎‬⁭‪‬⁮⁬‌‬‭⁪‪‫‮‎⁪‮(Engine.\u200E‏‬⁯‍‫⁬⁮‬⁭⁭⁮‍⁯‏‬⁯‪⁭⁯⁯⁮⁮⁯‫‬⁯‌​⁯‫‍‏‭‎‭‮⁭⁮⁭‮((DispatcherObject) Engine.\u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮()), new Action((object) displayClass1790, __methodptr(\u003CAddActiveUser\u003Eb__0)));
            num1 = -294007990;
            continue;
          default:
            goto label_14;
        }
        flag = num4 != 0;
        num1 = -1398286623;
      }
label_14:
      return;
label_3:;
    }

    public void InitializeThreads()
    {
    }

    public void StartManagers()
    {
label_1:
      int num1 = 1755075462;
      while (true)
      {
        int num2 = 741873219;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            this.CallEventManagerStart();
            num1 = (int) num3 * -1526820912 ^ 1024232577;
            continue;
          case 1:
            this.CallActivityManagerStart();
            num1 = (int) num3 * 1712338548 ^ 1588264695;
            continue;
          case 3:
            this.CallHookManagerStart();
            this.CallWindowInspectionStart();
            num1 = (int) num3 * -1612652107 ^ 2001660644;
            continue;
          case 4:
            num1 = (int) num3 * -848168509 ^ 36836632;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      this.CallChatManagerStart();
    }

    [STAThread]
    private void CallChatManagerStart()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003CCallChatManagerStart\u003Ed__182 managerStartD182 = new Engine.\u003CCallChatManagerStart\u003Ed__182();
label_1:
      int num1 = 476878721;
      AsyncVoidMethodBuilder tBuilder;
      while (true)
      {
        int num2 = 980440150;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            managerStartD182.\u003C\u003Et__builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num3 * 362322102 ^ -1810183547;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            managerStartD182.\u003C\u003E4__this = this;
            num1 = (int) num3 * -2088879137 ^ 359528032;
            continue;
          case 3:
            goto label_1;
          case 4:
            // ISSUE: reference to a compiler-generated field
            managerStartD182.\u003C\u003E1__state = -1;
            // ISSUE: reference to a compiler-generated field
            tBuilder = managerStartD182.\u003C\u003Et__builder;
            num1 = (int) num3 * 301782425 ^ 506705636;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncVoidMethodBuilder) @tBuilder).Start<Engine.\u003CCallChatManagerStart\u003Ed__182>((M0&) @managerStartD182);
    }

    [STAThread]
    private void CallHookManagerStart()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003CCallHookManagerStart\u003Ed__183 managerStartD183 = new Engine.\u003CCallHookManagerStart\u003Ed__183();
label_1:
      int num1 = -509823923;
      AsyncVoidMethodBuilder tBuilder;
      while (true)
      {
        int num2 = -106270437;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            managerStartD183.\u003C\u003E4__this = this;
            // ISSUE: reference to a compiler-generated field
            managerStartD183.\u003C\u003Et__builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num3 * -1967216112 ^ 1054407892;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = managerStartD183.\u003C\u003Et__builder;
            num1 = (int) num3 * 1405467512 ^ 1628741094;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            managerStartD183.\u003C\u003E1__state = -1;
            num1 = (int) num3 * -1079152085 ^ 557566536;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncVoidMethodBuilder) @tBuilder).Start<Engine.\u003CCallHookManagerStart\u003Ed__183>((M0&) @managerStartD183);
    }

    private void CallActivityManagerStart()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003CCallActivityManagerStart\u003Ed__184 managerStartD184 = new Engine.\u003CCallActivityManagerStart\u003Ed__184();
label_1:
      int num1 = -1462820195;
      while (true)
      {
        int num2 = -304956045;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            managerStartD184.\u003C\u003E1__state = -1;
            num1 = (int) num3 * 1117222680 ^ 2113287528;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            managerStartD184.\u003C\u003E4__this = this;
            // ISSUE: reference to a compiler-generated field
            managerStartD184.\u003C\u003Et__builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num3 * 458705334 ^ -133575250;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      AsyncVoidMethodBuilder tBuilder = managerStartD184.\u003C\u003Et__builder;
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncVoidMethodBuilder) @tBuilder).Start<Engine.\u003CCallActivityManagerStart\u003Ed__184>((M0&) @managerStartD184);
    }

    [STAThread]
    private async void CallWindowInspectionStart()
    {
      // ISSUE: reference to a compiler-generated field
      int num1 = this.\u003C\u003E1__state;
      try
      {
label_2:
        int num2 = -201191816;
        TaskAwaiter taskAwaiter1;
        while (true)
        {
          int num3 = -307924625;
          TaskAwaiter taskAwaiter;
          uint num4;
          int num5;
          // ISSUE: variable of a compiler-generated type
          Engine.\u003CCallWindowInspectionStart\u003Ed__185 inspectionStartD185;
          switch ((num4 = (uint) (num2 ^ num3)) % 14U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              this.\u003C\u003E1__state = num5 = 0;
              num2 = (int) num4 * -643262209 ^ 34330856;
              continue;
            case 1:
              num2 = (int) num4 * -1521135252 ^ 1868252610;
              continue;
            case 2:
              // ISSUE: explicit reference operation
              ((TaskAwaiter) @taskAwaiter1).GetResult();
              num2 = -301210426;
              continue;
            case 4:
            case 11:
              taskAwaiter1 = taskAwaiter;
              taskAwaiter = (TaskAwaiter) null;
              num2 = -434715271;
              continue;
            case 5:
              goto label_2;
            case 6:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: explicit reference operation
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              ((AsyncVoidMethodBuilder) @this.\u003C\u003Et__builder).AwaitUnsafeOnCompleted<TaskAwaiter, Engine.\u003CCallWindowInspectionStart\u003Ed__185>((M0&) @taskAwaiter1, (M1&) @inspectionStartD185);
              num2 = (int) num4 * -60721044 ^ 676928173;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              taskAwaiter1 = Engine.\u003CCallWindowInspectionStart\u003Ed__185.\u202B‬‫⁫‌‮‍‬⁭⁮‍⁯‫‬‮‌‍⁬‌‭⁭‌‌⁯‏⁯⁯‍‭⁬​⁬⁮‬‮‬‭⁫⁮‮‮(this.WindowManager.ManageWindowsAsync(this.Token));
              num2 = -1790378910;
              continue;
            case 8:
              num2 = (int) num4 * 929645111 ^ -1501627279;
              continue;
            case 9:
              // ISSUE: explicit reference operation
              int num6 = ((TaskAwaiter) @taskAwaiter1).get_IsCompleted() ? -2071614959 : (num6 = -297361669);
              int num7 = (int) num4 * -1780376896;
              num2 = num6 ^ num7;
              continue;
            case 10:
              goto label_22;
            case 12:
              // ISSUE: reference to a compiler-generated field
              this.\u003C\u003E1__state = num5 = -1;
              num2 = (int) num4 * 73181489 ^ 1239076839;
              continue;
            case 13:
              taskAwaiter = taskAwaiter1;
              inspectionStartD185 = this;
              num2 = (int) num4 * 717560852 ^ 1340816559;
              continue;
            default:
              goto label_16;
          }
        }
label_22:
        return;
label_16:
        taskAwaiter1 = (TaskAwaiter) null;
      }
      catch (Exception ex)
      {
label_18:
        int num2 = -504374316;
        while (true)
        {
          int num3 = -307924625;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_18;
            case 1:
              goto label_20;
            case 2:
              // ISSUE: reference to a compiler-generated field
              this.\u003C\u003E1__state = -2;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: explicit reference operation
              ((AsyncVoidMethodBuilder) @this.\u003C\u003Et__builder).SetException(ex);
              num2 = (int) num4 * -1697832985 ^ -1753334904;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_20:
        return;
      }
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -2;
label_24:
      int num8 = -457257163;
      while (true)
      {
        int num2 = -307924625;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 4U)
        {
          case 0:
            goto label_26;
          case 1:
            num8 = (int) num3 * 300049199 ^ 1501273644;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit reference operation
            ((AsyncVoidMethodBuilder) @this.\u003C\u003Et__builder).SetResult();
            num8 = (int) num3 * -379248287 ^ -380501892;
            continue;
          case 3:
            goto label_24;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_26:;
    }

    [STAThread]
    private void CallEventManagerStart()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003CCallEventManagerStart\u003Ed__186 managerStartD186 = new Engine.\u003CCallEventManagerStart\u003Ed__186();
      // ISSUE: reference to a compiler-generated field
      managerStartD186.\u003C\u003E4__this = this;
label_1:
      int num1 = -82688078;
      while (true)
      {
        int num2 = -1950186900;
        uint num3;
        AsyncVoidMethodBuilder tBuilder;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            // ISSUE: explicit reference operation
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            ((AsyncVoidMethodBuilder) @tBuilder).Start<Engine.\u003CCallEventManagerStart\u003Ed__186>((M0&) @managerStartD186);
            num1 = (int) num3 * -1118716346 ^ -1276003496;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            tBuilder = managerStartD186.\u003C\u003Et__builder;
            num1 = (int) num3 * 29138479 ^ 1358099415;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            // ISSUE: reference to a compiler-generated field
            managerStartD186.\u003C\u003Et__builder = AsyncVoidMethodBuilder.Create();
            // ISSUE: reference to a compiler-generated field
            managerStartD186.\u003C\u003E1__state = -1;
            num1 = (int) num3 * 1561546699 ^ -625329591;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    internal bool NewUser(string receiverName)
    {
label_1:
      int num1 = -150359135;
      bool flag;
      while (true)
      {
        int num2 = -354278006;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            flag = true;
            num1 = (int) num3 * 1767376390 ^ -474765916;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void AddUser(ZoomUser user)
    {
label_1:
      int num1 = -88437022;
      object engineLock;
      bool flag1;
      while (true)
      {
        int num2 = -1150939813;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 1:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 799293048 ^ -1762972150;
            continue;
          case 2:
            num1 = (int) num3 * -156838817 ^ -1360568338;
            continue;
          case 3:
            flag1 = false;
            num1 = (int) num3 * -686424191 ^ -310632721;
            continue;
          case 4:
            if (flag2)
            {
              num1 = (int) num3 * 817351113 ^ -1747775330;
              continue;
            }
            goto label_27;
          case 5:
            flag2 = user.SaveDatabaseObject();
            num1 = (int) num3 * 1768554213 ^ -1153904606;
            continue;
          case 6:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_9:
      bool flag3 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag3);
label_11:
        int num2 = -1027680968;
        while (true)
        {
          int num3 = -1150939813;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_11;
            case 2:
              num2 = (int) num4 * 1065902060 ^ -990305307;
              continue;
            case 3:
              this.Users.Add(user);
              num2 = (int) num4 * -32184289 ^ -2011641638;
              continue;
            case 4:
              num2 = (int) num4 * -2003015315 ^ -2035523143;
              continue;
            default:
              goto label_23;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_17:
          int num2 = -1286362519;
          while (true)
          {
            int num3 = -1150939813;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_17;
              case 1:
                num2 = (int) num4 * 1248280380 ^ 381839072;
                continue;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 2071329215 ^ 837861012;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_23:
label_24:
      int num5 = -1037786040;
label_25:
      bool flag4;
      while (true)
      {
        int num2 = -1150939813;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 7U)
        {
          case 0:
            // ISSUE: type reference
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
            {
              ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (ZoomUser)),
              ChangeType = ChangeType.Added,
              ChangedObject = (object) user
            });
            num5 = (int) num3 * -607459325 ^ 686860303;
            continue;
          case 1:
            num5 = (int) num3 * 653683227 ^ -1193400225;
            continue;
          case 2:
            goto label_24;
          case 3:
            goto label_27;
          case 4:
            int num4 = !flag4 ? -2003087965 : (num4 = -304792966);
            int num6 = (int) num3 * -874377265;
            num5 = num4 ^ num6;
            continue;
          case 5:
            goto label_26;
          case 6:
            num5 = (int) num3 * 1221676073 ^ 1086238690;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return;
label_26:
      return;
label_27:
      flag4 = flag1;
      num5 = -37180601;
      goto label_25;
    }

    internal ZoomUser GetUser(string userName, bool createIfMissing = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass189_0 displayClass1890 = new Engine.\u003C\u003Ec__DisplayClass189_0();
label_1:
      int num1 = -1231857483;
      object engineLock;
      while (true)
      {
        int num2 = -868582937;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * -2123134614 ^ 1086277313;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            displayClass1890.lowerUserName = Engine.\u206C⁫⁮‮‏‎‬⁪‍‏‍⁯​‭‮‬⁫⁬‭‬‫‫‫‫‌‍‫⁪⁬⁬‬⁫‪‎‌‭‭⁭‮‍‮(userName);
            num1 = (int) num3 * 1085432472 ^ -1714679430;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag1 = false;
      ZoomUser user;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_7:
        int num2 = -1818760628;
        while (true)
        {
          int num3 = -868582937;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = (int) num4 * -381874578 ^ 1469276728;
              continue;
            case 1:
              num2 = (int) num4 * 1196215702 ^ -1949971093;
              continue;
            case 2:
              goto label_7;
            case 3:
              // ISSUE: method pointer
              user = (ZoomUser) Enumerable.FirstOrDefault<ZoomUser>((IEnumerable<M0>) this.Users, (Func<M0, bool>) new Func<ZoomUser, bool>((object) displayClass1890, __methodptr(\u003CGetUser\u003Eb__0)));
              num2 = (int) num4 * -79500417 ^ -750609838;
              continue;
            case 4:
              num2 = (int) num4 * -38746318 ^ 1679386140;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_14:
          int num2 = -104489201;
          while (true)
          {
            int num3 = -868582937;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_14;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -580386850 ^ 666532434;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      bool flag2 = user == null & createIfMissing;
label_19:
      int num5 = -280048562;
      ZoomUser zoomUser;
      while (true)
      {
        int num2 = -868582937;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 7U)
        {
          case 0:
            user = new ZoomUser(userName);
            num5 = (int) num3 * -1390239584 ^ -1443109325;
            continue;
          case 1:
            zoomUser = user;
            num5 = -1240088332;
            continue;
          case 3:
            this.AddUser(user);
            num5 = (int) num3 * 1617153710 ^ -1043029604;
            continue;
          case 4:
            goto label_19;
          case 5:
            int num4 = flag2 ? -1949782222 : (num4 = -284398349);
            int num6 = (int) num3 * -895478241;
            num5 = num4 ^ num6;
            continue;
          case 6:
            num5 = (int) num3 * -10158779 ^ 190175829;
            continue;
          default:
            goto label_26;
        }
      }
label_26:
      return zoomUser;
    }

    internal ZoomUser GetUser(long userUri)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass190_0 displayClass1900 = new Engine.\u003C\u003Ec__DisplayClass190_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1900.userUri = userUri;
label_1:
      int num1 = -307059768;
      object engineLock;
      while (true)
      {
        int num2 = -1021659555;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * 1687079455 ^ -279547031;
            continue;
          case 2:
            goto label_1;
          case 3:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 1829676992 ^ 191821897;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag = false;
      ZoomUser zoomUser;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_7:
        int num2 = -874362621;
        while (true)
        {
          int num3 = -1021659555;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              // ISSUE: method pointer
              zoomUser = (ZoomUser) Enumerable.FirstOrDefault<ZoomUser>((IEnumerable<M0>) this.Users, (Func<M0, bool>) new Func<ZoomUser, bool>((object) displayClass1900, __methodptr(\u003CGetUser\u003Eb__0)));
              num2 = (int) num4 * 949235563 ^ 858749634;
              continue;
            case 2:
              num2 = (int) num4 * -957130811 ^ 216970410;
              continue;
            case 3:
              goto label_7;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_12:
          int num2 = -682449340;
          while (true)
          {
            int num3 = -1021659555;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 1299108743 ^ 1723046852;
                continue;
              case 2:
                num2 = (int) num4 * -534465911 ^ 1798676503;
                continue;
              case 3:
                goto label_12;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      return zoomUser;
    }

    public void AddActivity(ActivityBase activity, [CallerMemberName] string callerName = null)
    {
      Engine.\u200D⁯⁪⁫⁫‬‏⁬‎‮​‍⁪‎‏⁮‫‌⁭‏⁬‫‭⁪‮‮⁬‌‌‫​⁯⁪‍‏⁯⁭⁫‌‏‮(Engine.log, Engine.\u202C⁫⁭⁮‮⁪‌‫⁯⁫​‎‏⁪‍‫‎‏‍‎⁫‪⁭‬⁪‎‎⁫‎⁫⁭‍​‎‮‭‪‮‫‍‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2418979797U), (object) activity.Name, (object) callerName), new object[0]);
      try
      {
        this.ActivitiesPending.Add(activity);
label_2:
        int num1 = 508308165;
        while (true)
        {
          int num2 = 1396191332;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_15;
            case 2:
              num1 = (int) num3 * 578120212 ^ -428775831;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_15:;
      }
      catch (Exception ex)
      {
label_8:
        int num1 = 1593027172;
        while (true)
        {
          int num2 = 1396191332;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * -1838658048 ^ 1057315059;
              continue;
            case 1:
              num1 = (int) num3 * -181326863 ^ -432536254;
              continue;
            case 2:
              goto label_8;
            case 3:
              num1 = (int) num3 * -489732998 ^ 2095268905;
              continue;
            case 4:
              num1 = (int) num3 * -1955618461 ^ 820895038;
              continue;
            case 5:
              goto label_6;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_6:;
      }
    }

    public void CancelExecution()
    {
label_1:
      int num1 = 1466487078;
      while (true)
      {
        int num2 = 1017148548;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 31U)
        {
          case 0:
            this.HookManager.Cancel();
            this.HookManager = (EventHookManager) null;
            num1 = (int) num3 * -1117864371 ^ 965502267;
            continue;
          case 1:
            this.WindowManager = (WindowManager) null;
            num1 = (int) num3 * 303875335 ^ 320342682;
            continue;
          case 2:
            this.EventManager.Cancel();
            num1 = (int) num3 * -141431559 ^ 580788998;
            continue;
          case 3:
            this.EventManager = (EventManager) null;
            num1 = (int) num3 * -2020824951 ^ 970104550;
            continue;
          case 4:
            flag2 = this.ChatManager != null;
            num1 = 194764930;
            continue;
          case 5:
            num1 = (int) num3 * -227925411 ^ 485535515;
            continue;
          case 6:
            num1 = (int) num3 * -72893947 ^ -1132379726;
            continue;
          case 7:
            goto label_3;
          case 8:
            flag1 = this.ActivityManager != null;
            num1 = 1652516932;
            continue;
          case 9:
            this.ChatManager.Cancel();
            num1 = (int) num3 * 59143073 ^ -200400056;
            continue;
          case 10:
            int num4 = flag1 ? 1205152700 : (num4 = 1170953580);
            int num5 = (int) num3 * -1769797753;
            num1 = num4 ^ num5;
            continue;
          case 11:
            num1 = (int) num3 * 1773064971 ^ 405166274;
            continue;
          case 12:
            num1 = (int) num3 * -2091469253 ^ -999068872;
            continue;
          case 13:
            num1 = (int) num3 * -1352065533 ^ 837440167;
            continue;
          case 14:
            num1 = (int) num3 * 2004778109 ^ -122704912;
            continue;
          case 15:
            this.ChatManager = (ChatManager) null;
            num1 = (int) num3 * 111898291 ^ -1518712189;
            continue;
          case 16:
            num1 = (int) num3 * 1410011914 ^ -10404381;
            continue;
          case 17:
            num1 = (int) num3 * 766326090 ^ 1662122160;
            continue;
          case 18:
            int num6 = !flag2 ? 1047656165 : (num6 = 265400577);
            int num7 = (int) num3 * -339107964;
            num1 = num6 ^ num7;
            continue;
          case 19:
            this.ActivityManager = (ActivityManager) null;
            num1 = (int) num3 * -1937410256 ^ 1540053704;
            continue;
          case 20:
            num1 = (int) num3 * 269360075 ^ 1389631386;
            continue;
          case 21:
            this.WindowManager.Cancel();
            num1 = (int) num3 * -1482887964 ^ 1410102211;
            continue;
          case 22:
            this.ActivityManager.Cancel();
            num1 = (int) num3 * -1459790244 ^ 777031865;
            continue;
          case 23:
            goto label_1;
          case 24:
            num1 = (int) num3 * -597942694 ^ -198728211;
            continue;
          case 25:
            int num8;
            num1 = num8 = this.EventManager == null ? 801032552 : (num8 = 516065582);
            continue;
          case 26:
            num1 = (int) num3 * -1152105127 ^ 1898079784;
            continue;
          case 27:
            this.sharedData = (SharedData) null;
            num1 = 2128342853;
            continue;
          case 28:
            num1 = (int) num3 * -281937054 ^ -1513276987;
            continue;
          case 29:
            this.RaiseEvent(EngineEvent.Stopping, (Exception) null, false);
            int num9 = this.HookManager == null ? -633927196 : (num9 = -713174713);
            int num10 = (int) num3 * 1479749215;
            num1 = num9 ^ num10;
            continue;
          case 30:
            int num11;
            num1 = num11 = this.WindowManager == null ? 1031675309 : (num11 = 901784242);
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return;
label_3:;
    }

    public string GetLineArt()
    {
label_1:
      int num1 = -1545624666;
      string str;
      while (true)
      {
        int num2 = -1163435926;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -183327935 ^ 2039401483;
            continue;
          case 2:
            num1 = (int) num3 * -1274202858 ^ -1068193433;
            continue;
          case 3:
            num1 = -897454795;
            continue;
          case 4:
            int num4 = this.SharedData.Settings.Lineart.Count <= 0 ? -99831479 : (num4 = -1773885041);
            int num5 = (int) num3 * 1548560596;
            num1 = num4 ^ num5;
            continue;
          case 5:
            str = this.Settings.Lineart[Engine.\u200D⁫⁬‭‬‭‫⁬⁭‮‏⁮⁬⁪⁭⁭‫⁭‬⁭‬⁬‫‫​⁭⁯‬‌⁯‮⁮⁬‭‭⁪‬⁫‭⁪‮(Engine.\u206B⁪‌‍⁬‪​​‎⁪‫‪⁫‍‪‫‬‪‏‫‌⁮‫‏⁯⁬‮⁫⁫​⁫⁬‪⁯⁫⁭‫‍‫‮(), 0, this.Settings.Lineart.Count - 1)];
            num1 = (int) num3 * -500233466 ^ -2011623154;
            continue;
          case 6:
            goto label_1;
          case 7:
            str = "";
            num1 = (int) num3 * 618165580 ^ 2119964174;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return str;
    }

    internal void SetActiveActivity(ActivityBase activity)
    {
label_1:
      int num1 = 891366237;
      ActivityBase activity1;
      while (true)
      {
        int num2 = 1517380014;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            activity1 = (ActivityBase) null;
            num1 = (int) num3 * -2091212597 ^ 1948542119;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      object engineLock1 = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock1, ref flag1);
label_6:
        int num2 = 404445102;
        while (true)
        {
          int num3 = 1517380014;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              activity1 = this.ActiveActivity;
              num2 = (int) num4 * -1312674086 ^ -1127054265;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_10:
          int num2 = 1443787824;
          while (true)
          {
            int num3 = 1517380014;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_10;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock1);
                num2 = (int) num4 * 1774061083 ^ 1381671919;
                continue;
              case 3:
                num2 = (int) num4 * -1686763839 ^ 790991404;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      if (activity1 == null)
        goto label_21;
label_16:
      int num5 = 1082833652;
label_17:
      object engineLock2;
      bool flag2;
      while (true)
      {
        int num2 = 1517380014;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 6U)
        {
          case 1:
            engineLock2 = Engine.engineLock;
            num5 = 1850110068;
            continue;
          case 2:
            this.ArchiveActivity(activity1);
            num5 = (int) num3 * -1393092893 ^ -1672701857;
            continue;
          case 3:
            goto label_16;
          case 4:
            goto label_20;
          case 5:
            int num4 = !flag2 ? 236992833 : (num4 = 676733092);
            int num6 = (int) num3 * -1328715348;
            num5 = num4 ^ num6;
            continue;
          default:
            goto label_24;
        }
      }
label_20:
      int num7 = activity != activity1 ? 1 : 0;
      goto label_22;
label_24:
      bool flag3 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock2, ref flag3);
label_26:
        int num2 = 1453878140;
        while (true)
        {
          int num3 = 1517380014;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * -1840872904 ^ -621964221;
              continue;
            case 1:
              this.ActiveActivity = activity;
              num2 = (int) num4 * 300117179 ^ 811322098;
              continue;
            case 2:
              goto label_26;
            case 3:
              goto label_35;
            case 4:
              num2 = (int) num4 * -30661030 ^ -1435601991;
              continue;
            default:
              goto label_31;
          }
        }
label_31:
        return;
label_35:
        return;
      }
      finally
      {
        if (flag3)
        {
label_33:
          int num2 = 2111165303;
          while (true)
          {
            int num3 = 1517380014;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock2);
                num2 = (int) num4 * 1755243255 ^ 1930443589;
                continue;
              case 2:
                goto label_33;
              default:
                goto label_37;
            }
          }
        }
label_37:;
      }
label_21:
      num7 = 0;
label_22:
      flag2 = num7 != 0;
      num5 = 813512555;
      goto label_17;
    }

    internal void ArchiveActivity(ActivityBase activity)
    {
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_2:
        int num1 = -1591744316;
        while (true)
        {
          int num2 = -222396232;
          uint num3;
          bool flag2;
          bool flag3;
          bool flag4;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 20U)
          {
            case 0:
              if (activity != null)
              {
                num1 = (int) num3 * -1606883116 ^ -1529779125;
                continue;
              }
              num4 = 0;
              goto label_23;
            case 1:
              this.ActiveActivity = (ActivityBase) null;
              num1 = (int) num3 * -663685077 ^ -266767756;
              continue;
            case 3:
              num4 = !((IEnumerable<ActivityBase>) this.ActivitiesCompleted).Contains<ActivityBase>(activity) ? 1 : 0;
              goto label_23;
            case 4:
              this.ActivitiesCompleted.Add(activity);
              num1 = (int) num3 * -873304132 ^ -932703005;
              continue;
            case 5:
              num1 = (int) num3 * 378238415 ^ 670944403;
              continue;
            case 6:
              num1 = (int) num3 * 686155904 ^ -1644580384;
              continue;
            case 7:
              num1 = (int) num3 * 588625083 ^ -2054330584;
              continue;
            case 8:
              flag4 = this.ActiveActivity == activity;
              num1 = -626869981;
              continue;
            case 9:
              int num6 = !flag3 ? 1833684840 : (num6 = 195717826);
              int num7 = (int) num3 * -1700793444;
              num1 = num6 ^ num7;
              continue;
            case 10:
              this.ActivitiesPending.Remove(activity);
              num1 = (int) num3 * -164536146 ^ 416302389;
              continue;
            case 11:
              num1 = -247070766;
              continue;
            case 12:
              num1 = (int) num3 * 1773333116 ^ 945866692;
              continue;
            case 13:
              num1 = (int) num3 * -1995070921 ^ 1740055940;
              continue;
            case 14:
              if (activity == null)
              {
                num5 = 0;
                break;
              }
              num1 = -355387592;
              continue;
            case 15:
              int num8 = !flag4 ? -1513105637 : (num8 = -1326633635);
              int num9 = (int) num3 * 1851271204;
              num1 = num8 ^ num9;
              continue;
            case 16:
              num5 = this.ActivitiesPending.Contains(activity) ? 1 : 0;
              break;
            case 17:
              int num10 = !flag2 ? -214230987 : (num10 = -1559453547);
              int num11 = (int) num3 * 1565186327;
              num1 = num10 ^ num11;
              continue;
            case 18:
              goto label_2;
            case 19:
              num1 = (int) num3 * 1060886773 ^ 1100099237;
              continue;
            default:
              goto label_33;
          }
          flag3 = num5 != 0;
          num1 = -802688283;
          continue;
label_23:
          flag2 = num4 != 0;
          num1 = -1243661239;
        }
      }
      finally
      {
        if (flag1)
        {
label_29:
          int num1 = -308641334;
          while (true)
          {
            int num2 = -222396232;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_29;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * -1639109128 ^ -1871993641;
                continue;
              default:
                goto label_32;
            }
          }
        }
label_32:;
      }
label_33:
      bool traceActivityEvents = Engine.Instance.Settings.TraceActivityEvents;
      try
      {
        bool flag2 = activity != null & traceActivityEvents;
label_35:
        int num1 = -2139521222;
        string contents;
        while (true)
        {
          int num2 = -222396232;
          uint num3;
          ZoomEvent processedEvent;
          int index;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              goto label_35;
            case 1:
              flag3 = index < activity.ProcessedEvents.Count;
              num1 = -39724129;
              continue;
            case 2:
              num1 = (int) num3 * 1369504785 ^ 1351842626;
              continue;
            case 3:
              num1 = (int) num3 * 1633985835 ^ 1494195544;
              continue;
            case 5:
              ++index;
              num1 = (int) num3 * 846085625 ^ 2121875034;
              continue;
            case 6:
              processedEvent = activity.ProcessedEvents[index];
              num1 = -47986984;
              continue;
            case 7:
              contents = string.Empty;
              index = 0;
              num1 = (int) num3 * -1954020952 ^ 1956126705;
              continue;
            case 8:
              num1 = (int) num3 * -1772988651 ^ 2091326119;
              continue;
            case 9:
              contents = Engine.\u206B‫‏‏⁬⁯‪‌‫‏‮‌⁬‫⁮⁮‪‏⁫⁮⁮‎‏‌⁬⁯‌‏​⁫‏‍‫‏‏⁫‎‏​⁫‮(contents, Engine.\u206F‬⁪‪​⁭‮‏‍‌‫‏‫⁮‌⁭‮⁪‫‎⁬‏‪‪‫‬​‏‌⁫‎‮‭⁭⁭‮‏⁮‌‮‮((object) processedEvent), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(673517730U));
              num1 = (int) num3 * 466625292 ^ -210925037;
              continue;
            case 10:
              if (flag2)
              {
                num1 = (int) num3 * -6903001 ^ -181895951;
                continue;
              }
              goto label_70;
            case 11:
              int num4 = !flag3 ? 1258845465 : (num4 = 1016381361);
              int num5 = (int) num3 * -1954300927;
              num1 = num4 ^ num5;
              continue;
            case 12:
              Engine.\u206E⁫‮‭⁫‎‎‌⁯‬‫‎‎‫⁪⁬⁭‌‎⁫‎⁭⁬​‎‭⁯​‫‭⁫‬‬⁯‬‭⁮‭⁪⁮‮(Engine.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(888559711U), (object) activity.Name, (object) processedEvent);
              num1 = (int) num3 * -1592178138 ^ -1900945190;
              continue;
            case 13:
              num1 = (int) num3 * -371511084 ^ 625958549;
              continue;
            default:
              goto label_50;
          }
        }
label_50:
        List<ZoomEvent>.Enumerator enumerator = activity.ProcessedEvents.GetEnumerator();
        try
        {
label_54:
          int num2 = !enumerator.MoveNext() ? -1874901732 : (num2 = -2022276724);
          while (true)
          {
            int num3 = -222396232;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 1:
                num2 = (int) num4 * -1209459878 ^ 456099455;
                continue;
              case 2:
                goto label_54;
              case 3:
                num2 = -2022276724;
                continue;
              case 4:
                ZoomEvent current = enumerator.Current;
                num2 = -168641361;
                continue;
              case 5:
                num2 = (int) num4 * 558489984 ^ 1602684246;
                continue;
              default:
                goto label_63;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
label_59:
          int num2 = -849571574;
          while (true)
          {
            int num3 = -222396232;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num2 = (int) num4 * 2135079804 ^ 807098599;
                continue;
              case 2:
                goto label_59;
              default:
                goto label_62;
            }
          }
label_62:;
        }
label_63:
        activity.ProcessedEvents.Clear();
label_64:
        int num6 = -1569702974;
label_65:
        while (true)
        {
          int num2 = -222396232;
          uint num3;
          string path;
          switch ((num3 = (uint) (num6 ^ num2)) % 8U)
          {
            case 0:
              num6 = (int) num3 * -2045252940 ^ 206803681;
              continue;
            case 1:
              goto label_70;
            case 2:
              num6 = (int) num3 * 593873376 ^ 1625608974;
              continue;
            case 3:
              CoreUtils.CreateDirectory(Path.GetDirectoryName(path));
              num6 = (int) num3 * -961995718 ^ 1314677529;
              continue;
            case 4:
              goto label_64;
            case 6:
              path = string.Format(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2643926020U), (object) Engine.\u202B⁭‪⁯‬⁮⁪​‬⁪‎⁬⁪‫‮⁯‏‏⁫‪⁬⁫‪⁪‍⁯‮⁭‍‪‬‌​⁭⁮‪⁫‮‪‬‮((MemberInfo) Engine.\u200B⁪‭‫​‌‬‍‍‫⁫‪‬⁪‏⁬⁮‭‏‏‎⁪‫‏⁯​⁪‪⁬‏​⁯⁭‏‫‬‎⁯⁭‫‮((object) activity)), (object) DateTime.Now.ToString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(503634991U)));
              num6 = (int) num3 * 724486943 ^ -2136414575;
              continue;
            case 7:
              File.WriteAllText(path, contents);
              num6 = (int) num3 * 1837732418 ^ 817990838;
              continue;
            default:
              goto label_77;
          }
        }
label_70:
        num6 = -204163451;
        goto label_65;
      }
      catch (Exception ex)
      {
label_73:
        int num1 = -17478538;
        while (true)
        {
          int num2 = -222396232;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -206030719 ^ 230604569;
              continue;
            case 2:
              Engine.log.Error((object) ex);
              num1 = (int) num3 * -1027023949 ^ 569914415;
              continue;
            case 3:
              goto label_73;
            default:
              goto label_77;
          }
        }
      }
label_77:
      Engine.log.InfoFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(291334390U), (object) activity);
    }

    internal bool HoldActivity(string holdKey, ActivityBase activity)
    {
      return this.ActivitiesOnHold.TryAdd(holdKey, activity);
    }

    private void RemoveActivityType(Type type)
    {
      List<ActivityBase> activityBaseList = new List<ActivityBase>();
label_1:
      int num1 = -349442027;
      object engineLock;
      while (true)
      {
        int num2 = -1245486310;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 715562675 ^ 977987068;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_6:
        int num2 = -581651728;
        while (true)
        {
          int num3 = -1245486310;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_6;
            case 2:
              num2 = (int) num4 * 103029112 ^ 1469493701;
              continue;
            case 3:
              num2 = (int) num4 * -2136699317 ^ -2012824254;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        using (List<ActivityBase>.Enumerator enumerator = this.ActivitiesPending.GetEnumerator())
        {
label_15:
          int num3 = !enumerator.MoveNext() ? -1808760274 : (num3 = -78915014);
          while (true)
          {
            int num4 = -1245486310;
            uint num5;
            ActivityBase current;
            bool flag2;
            switch ((num5 = (uint) (num3 ^ num4)) % 10U)
            {
              case 0:
                num3 = -78915014;
                continue;
              case 1:
                num3 = -1549730302;
                continue;
              case 2:
                goto label_15;
              case 3:
                int num6 = flag2 ? -1163216185 : (num6 = -1132355925);
                int num7 = (int) num5 * 1882657220;
                num3 = num6 ^ num7;
                continue;
              case 4:
                flag2 = !Engine.\u206F⁯‍‭‮⁫⁭‏‪⁮⁭‏​‪‭‮⁫⁯‭‬⁮⁮​⁯‏‍‎⁪‎‬⁭‬‬⁪‌‏‮⁯‭‪‮(Engine.\u200B⁪‭‫​‌‬‍‍‫⁫‪‬⁪‏⁬⁮‭‏‏‎⁪‫‏⁯​⁪‪⁬‏​⁯⁭‏‫‬‎⁯⁭‫‮((object) current), type);
                num3 = (int) num5 * -88260424 ^ 863887587;
                continue;
              case 5:
                num3 = (int) num5 * -262317370 ^ -294092949;
                continue;
              case 6:
                current = enumerator.Current;
                num3 = -403080296;
                continue;
              case 7:
                activityBaseList.Add(current);
                num3 = (int) num5 * 1460393044 ^ -130807525;
                continue;
              case 9:
                num3 = (int) num5 * -368601820 ^ 1787571867;
                continue;
              default:
                goto label_29;
            }
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_24:
          int num2 = -468105036;
          while (true)
          {
            int num3 = -1245486310;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_24;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -960776767 ^ -1277866973;
                continue;
              case 3:
                num2 = (int) num4 * 1294288506 ^ 573371005;
                continue;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
label_29:
      List<ActivityBase>.Enumerator enumerator1 = activityBaseList.GetEnumerator();
      try
      {
label_34:
        int num2 = enumerator1.MoveNext() ? -774792469 : (num2 = -2048030022);
        while (true)
        {
          int num3 = -1245486310;
          uint num4;
          ActivityBase current;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              goto label_42;
            case 1:
              current = enumerator1.Current;
              num2 = -693085902;
              continue;
            case 2:
              num2 = (int) num4 * -220129031 ^ 280742811;
              continue;
            case 3:
              num2 = -774792469;
              continue;
            case 4:
              this.AddActivity(current, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1496469898U));
              num2 = (int) num4 * 1354574483 ^ 1809373345;
              continue;
            case 5:
              goto label_34;
            case 6:
              num2 = (int) num4 * 1721854030 ^ 1827297915;
              continue;
            default:
              goto label_38;
          }
        }
label_38:
        return;
label_42:;
      }
      finally
      {
        enumerator1.Dispose();
label_40:
        int num2 = -1943679447;
        while (true)
        {
          int num3 = -1245486310;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -318777223 ^ 1723650277;
              continue;
            case 2:
              goto label_40;
            default:
              goto label_44;
          }
        }
label_44:;
      }
    }

    internal bool GetNextActivity(out ActivityBase currentActivity)
    {
label_1:
      int num1 = -1313395757;
      bool flag1;
      while (true)
      {
        int num2 = -926694539;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag1 = false;
            num1 = (int) num3 * 789970384 ^ 848906381;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ActivityBase activity = (ActivityBase) null;
      try
      {
        ZoomMeeting activeMeeting = this.ActiveMeeting;
        if (activeMeeting == null)
          goto label_11;
label_6:
        int num2 = -325901892;
label_7:
        object engineLock;
        while (true)
        {
          int num3 = -926694539;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              num2 = -1183323088;
              continue;
            case 1:
              num2 = (int) num4 * 1863149993 ^ 1602609902;
              continue;
            case 2:
              engineLock = Engine.engineLock;
              num2 = (int) num4 * -1156384633 ^ -1017100689;
              continue;
            case 4:
              goto label_6;
            case 5:
              goto label_14;
            case 6:
              goto label_10;
            default:
              goto label_15;
          }
        }
label_10:
        int num5 = activeMeeting.InitialActivities.TryDequeue(ref activity) ? 1 : 0;
        goto label_12;
label_14:
        Engine.\u200F‫​​‌‏⁪⁬​‫‏‌⁭‬​‭⁮‮‮⁭‌‌‪‎‏⁬‏‍⁪‌⁬‍⁬‪⁭⁬⁪⁮‮⁯‮(Engine.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1163605296U), (object) activity);
        goto label_41;
label_15:
        bool flag2 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag2);
label_17:
          int num3 = -1976295206;
          while (true)
          {
            int num4 = -926694539;
            uint num6;
            bool flag3;
            switch ((num6 = (uint) (num3 ^ num4)) % 9U)
            {
              case 0:
                goto label_17;
              case 1:
                num3 = -439041971;
                continue;
              case 2:
                num3 = (int) num6 * 1761745598 ^ 273727429;
                continue;
              case 3:
                num3 = (int) num6 * 1754288730 ^ 1782566144;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: method pointer
                activity = (ActivityBase) Enumerable.FirstOrDefault<ActivityBase>((IEnumerable<M0>) this.ActivitiesPending, (Func<M0, bool>) (Engine.\u003C\u003Ec.\u003C\u003E9__198_0 ?? (Engine.\u003C\u003Ec.\u003C\u003E9__198_0 = new Func<ActivityBase, bool>((object) Engine.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CGetNextActivity\u003Eb__198_0)))));
                flag3 = activity != null;
                num3 = -1562559146;
                continue;
              case 6:
                this.ActivitiesPending.Remove(activity);
                num3 = (int) num6 * 1195023896 ^ -2029938972;
                continue;
              case 7:
                num3 = (int) num6 * -111354627 ^ -689596863;
                continue;
              case 8:
                int num7 = !flag3 ? 1987540054 : (num7 = 1317451513);
                int num8 = (int) num6 * -1549541761;
                num3 = num7 ^ num8;
                continue;
              default:
                goto label_32;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_27:
            int num3 = -767277668;
            while (true)
            {
              int num4 = -926694539;
              uint num6;
              switch ((num6 = (uint) (num3 ^ num4)) % 4U)
              {
                case 0:
                  num3 = (int) num6 * -482594671 ^ 1478893398;
                  continue;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num3 = (int) num6 * -972540398 ^ 1728364523;
                  continue;
                case 2:
                  goto label_27;
                default:
                  goto label_31;
              }
            }
          }
label_31:;
        }
label_32:
label_33:
        int num9 = -1914407367;
label_34:
        while (true)
        {
          int num3 = -926694539;
          uint num4;
          bool flag3;
          switch ((num4 = (uint) (num9 ^ num3)) % 13U)
          {
            case 0:
              int num6 = flag3 ? -2092625959 : (num6 = -1919085721);
              int num7 = (int) num4 * 1184582204;
              num9 = num6 ^ num7;
              continue;
            case 1:
              num9 = -232444309;
              continue;
            case 2:
              num9 = (int) num4 * 1455614307 ^ -1038470155;
              continue;
            case 3:
              flag3 = activity != null;
              num9 = (int) num4 * -1623652330 ^ 1026083707;
              continue;
            case 4:
              num9 = -1340471153;
              continue;
            case 5:
              flag1 = true;
              num9 = (int) num4 * -438659934 ^ 2005954220;
              continue;
            case 6:
              goto label_41;
            case 7:
              num9 = (int) num4 * 1804912108 ^ 209782125;
              continue;
            case 8:
              int num8 = activity.AuthorizationState != AuthorizationStates.Pending ? 1497013784 : (num8 = 952200535);
              int num10 = (int) num4 * 640162553;
              num9 = num8 ^ num10;
              continue;
            case 9:
              goto label_33;
            case 10:
              activity.AuthorizationState = AuthorizationStates.Authorized;
              num9 = (int) num4 * -1023699160 ^ 1008325714;
              continue;
            case 11:
              num9 = (int) num4 * 2119457582 ^ -1978285333;
              continue;
            default:
              goto label_52;
          }
        }
label_41:
        this.SetActiveActivity(activity);
        num9 = -1825412334;
        goto label_34;
label_11:
        num5 = 0;
label_12:
        num2 = num5 == 0 ? -1337319525 : (num2 = -260107004);
        goto label_7;
      }
      catch (Exception ex)
      {
label_47:
        int num2 = -1231621073;
        while (true)
        {
          int num3 = -926694539;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * 1655731217 ^ -2076846157;
              continue;
            case 1:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num2 = (int) num4 * -1151642355 ^ -1371187200;
              continue;
            case 2:
              num2 = (int) num4 * 1631071232 ^ -974154820;
              continue;
            case 4:
              goto label_47;
            default:
              goto label_52;
          }
        }
      }
label_52:
      currentActivity = activity;
label_53:
      int num11 = -840297545;
      bool flag4;
      while (true)
      {
        int num2 = -926694539;
        uint num3;
        switch ((num3 = (uint) (num11 ^ num2)) % 4U)
        {
          case 1:
            num11 = (int) num3 * 1406496943 ^ 102820098;
            continue;
          case 2:
            flag4 = flag1;
            num11 = (int) num3 * 1285624911 ^ 60499606;
            continue;
          case 3:
            goto label_53;
          default:
            goto label_57;
        }
      }
label_57:
      return flag4;
    }

    internal bool SaveActivity(ActivityBase activity)
    {
      bool flag1 = false;
      try
      {
        object engineLock = Engine.engineLock;
        bool flag2 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag2);
          bool flag3 = !((IEnumerable<ActivityBase>) this.SavedActivities).Contains<ActivityBase>(activity);
label_3:
          int num1 = -1585905265;
          while (true)
          {
            int num2 = -1122696858;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 8U)
            {
              case 0:
                goto label_3;
              case 1:
                int num4 = flag3 ? 1626617367 : (num4 = 621538242);
                int num5 = (int) num3 * 1551868059;
                num1 = num4 ^ num5;
                continue;
              case 2:
                num1 = (int) num3 * 1642091230 ^ 212574233;
                continue;
              case 3:
                this.SavedActivities.Add(activity);
                num1 = (int) num3 * 1325514842 ^ 603829390;
                continue;
              case 4:
                num1 = (int) num3 * -2137412252 ^ 306965953;
                continue;
              case 6:
                num1 = (int) num3 * 316548388 ^ 962965338;
                continue;
              case 7:
                num1 = -1204788133;
                continue;
              default:
                goto label_17;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_12:
            int num1 = -769865968;
            while (true)
            {
              int num2 = -1122696858;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_12;
                case 1:
                  num1 = (int) num3 * 936833011 ^ -1037388542;
                  continue;
                case 2:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 1671250577 ^ 976977349;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
label_17:
        flag1 = activity.SaveDatabaseObject();
label_18:
        int num6 = -853778716;
        while (true)
        {
          int num1 = -1122696858;
          uint num2;
          switch ((num2 = (uint) (num6 ^ num1)) % 3U)
          {
            case 0:
              goto label_18;
            case 1:
              num6 = (int) num2 * -1076198654 ^ 821645719;
              continue;
            default:
              goto label_26;
          }
        }
      }
      catch (Exception ex)
      {
        Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
label_22:
        int num1 = -844702857;
        while (true)
        {
          int num2 = -1122696858;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1117219076 ^ -1078635951;
              continue;
            case 1:
              num1 = (int) num3 * 1594658531 ^ -1734469663;
              continue;
            case 2:
              goto label_22;
            default:
              goto label_26;
          }
        }
      }
label_26:
      return flag1;
    }

    public void LoadSavedActivities()
    {
      List<ActivityBase> savedActivities = this.ZoomZoomDatabase.GetSavedActivities("");
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_2:
        int num1 = -831317061;
        while (true)
        {
          int num2 = -1769247190;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * -1895280426 ^ 1222351986;
              continue;
            case 2:
              num1 = (int) num3 * -799821976 ^ 694126277;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        using (List<ActivityBase>.Enumerator enumerator = savedActivities.GetEnumerator())
        {
label_16:
          int num2 = !enumerator.MoveNext() ? -1955470479 : (num2 = -1668249232);
          while (true)
          {
            int num3 = -1769247190;
            uint num4;
            ActivityBase current;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 10U)
            {
              case 0:
                flag2 = !((IEnumerable<ActivityBase>) Engine.savedActivities).Contains<ActivityBase>(current);
                num2 = (int) num4 * -281297720 ^ -1074560141;
                continue;
              case 1:
                goto label_26;
              case 2:
                num2 = -1668249232;
                continue;
              case 3:
                goto label_16;
              case 4:
                num2 = (int) num4 * 1082984146 ^ 1496065615;
                continue;
              case 5:
                int num5 = flag2 ? 891644541 : (num5 = 1417490556);
                int num6 = (int) num4 * -790470825;
                num2 = num5 ^ num6;
                continue;
              case 6:
                num2 = (int) num4 * -568975239 ^ 517358807;
                continue;
              case 7:
                this.SavedActivities.Add(current);
                num2 = (int) num4 * 2014115409 ^ 246319289;
                continue;
              case 8:
                current = enumerator.Current;
                num2 = -984120350;
                continue;
              case 9:
                num2 = -1456709011;
                continue;
              default:
                goto label_22;
            }
          }
label_22:
          return;
label_26:;
        }
      }
      finally
      {
        if (flag1)
        {
label_20:
          int num1 = -1287295245;
          while (true)
          {
            int num2 = -1769247190;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -676008999 ^ 930009052;
                continue;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 1357082695 ^ -50963867;
                continue;
              case 3:
                goto label_20;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
    }

    public ZoomWindow GetWindow(ZoomWindowType zoomWindowType)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass201_0 displayClass2010 = new Engine.\u003C\u003Ec__DisplayClass201_0();
      // ISSUE: reference to a compiler-generated field
      displayClass2010.zoomWindowType = zoomWindowType;
label_1:
      int num1 = -694675677;
      object engineLock;
      ZoomWindow zoomWindow;
      while (true)
      {
        int num2 = -1312222029;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1433941374 ^ 567210997;
            continue;
          case 2:
            zoomWindow = (ZoomWindow) null;
            num1 = (int) num3 * 519307663 ^ -1048553280;
            continue;
          case 3:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * -1843288123 ^ 1078686510;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_8:
        int num2 = -1852272012;
        while (true)
        {
          int num3 = -1312222029;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 1:
              num2 = (int) num4 * -385557773 ^ -652557716;
              continue;
            case 2:
              // ISSUE: method pointer
              zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) displayClass2010, __methodptr(\u003CGetWindow\u003Eb__0)));
              num2 = (int) num4 * 447026885 ^ -820105888;
              continue;
            case 3:
              num2 = (int) num4 * 924765780 ^ -493140741;
              continue;
            case 4:
              goto label_8;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_14:
          int num2 = -257102341;
          while (true)
          {
            int num3 = -1312222029;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_14;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 1850672464 ^ -592917479;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      return zoomWindow;
    }

    public ZoomWindow GetWindowViaButton(ZoomWindowType zoomWindowType)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass202_0 displayClass2020 = new Engine.\u003C\u003Ec__DisplayClass202_0();
label_1:
      int num1 = 677988246;
      ZoomWindow zoomWindow1;
      object engineLock;
      while (true)
      {
        int num2 = 1940396140;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * -1547062946 ^ -107370399;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            displayClass2020.zoomWindowType = zoomWindowType;
            num1 = (int) num3 * 84839305 ^ 954795108;
            continue;
          case 4:
            num1 = (int) num3 * 2042746164 ^ -1305215013;
            continue;
          case 5:
            zoomWindow1 = (ZoomWindow) null;
            num1 = (int) num3 * 586354860 ^ -1125187355;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_9:
        int num2 = 256286688;
        while (true)
        {
          int num3 = 1940396140;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              // ISSUE: method pointer
              zoomWindow1 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) displayClass2020, __methodptr(\u003CGetWindowViaButton\u003Eb__0)));
              num2 = (int) num4 * 78148552 ^ -1096179809;
              continue;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_13:
          int num2 = 1188876045;
          while (true)
          {
            int num3 = 1940396140;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_13;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 1826339215 ^ 628950381;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      bool flag2 = zoomWindow1 == null;
label_18:
      int num5 = 969238097;
      List<ZoomButton> list;
      while (true)
      {
        int num2 = 1940396140;
        uint num3;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num5 ^ num2)) % 11U)
        {
          case 0:
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomButton>) Enumerable.Where<ZoomButton>((IEnumerable<M0>) this.ActiveMeeting.MeetingButtons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) displayClass2020, __methodptr(\u003CGetWindowViaButton\u003Eb__1)))).ToList<ZoomButton>();
            num5 = (int) num3 * -555141137 ^ -1316631725;
            continue;
          case 1:
            if (flag3)
            {
              num5 = (int) num3 * 1265852140 ^ -65859993;
              continue;
            }
            goto label_88;
          case 2:
            // ISSUE: reference to a compiler-generated field
            Engine.\u206E⁫‮‭⁫‎‎‌⁯‬‫‎‎‫⁪⁬⁭‌‎⁫‎⁭⁬​‎‭⁯​‫‭⁫‬‬⁯‬‭⁮‭⁪⁮‮(Engine.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(962242635U), (object) list.Count, (object) displayClass2020.zoomWindowType);
            num5 = (int) num3 * 870806829 ^ -856662794;
            continue;
          case 4:
            num4 = this.ActiveMeetingWindow != null ? 1 : 0;
            break;
          case 5:
            num5 = (int) num3 * -1330087121 ^ 477599509;
            continue;
          case 6:
            num5 = (int) num3 * -686784275 ^ 61726269;
            continue;
          case 7:
            goto label_18;
          case 8:
            if (flag2)
            {
              num5 = (int) num3 * -2026666120 ^ -437538685;
              continue;
            }
            goto label_78;
          case 9:
            // ISSUE: reference to a compiler-generated field
            Engine.\u200D⁯⁪⁫⁫‬‏⁬‎‮​‍⁪‎‏⁮‫‌⁭‏⁬‫‭⁪‮‮⁬‌‌‫​⁯⁪‍‏⁯⁭⁫‌‏‮(Engine.log, Engine.\u206F⁬‮⁬‮‫‮‪⁮⁯⁪⁫‫‍‫‭⁯‮⁪‫⁮‬‏‭‮⁪⁬⁫‍‮‌⁯‍​‏⁮⁬‍‎⁯‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3436166923U), (object) displayClass2020.zoomWindowType), new object[0]);
            num5 = (int) num3 * 1052083977 ^ -715055526;
            continue;
          case 10:
            if (this.ActiveMeeting != null)
            {
              num5 = (int) num3 * 1657863278 ^ 1096730577;
              continue;
            }
            num4 = 0;
            break;
          default:
            goto label_34;
        }
        flag3 = num4 != 0;
        num5 = 509602875;
      }
label_34:
      using (List<ZoomButton>.Enumerator enumerator = list.GetEnumerator())
      {
label_57:
        int num2 = !enumerator.MoveNext() ? 2116620270 : (num2 = 169849262);
        while (true)
        {
          int num3 = 1940396140;
          uint num4;
          ZoomWindow zoomWindow2;
          bool flag3;
          ZoomButton current;
          bool flag4;
          int num6;
          switch ((num4 = (uint) (num2 ^ num3)) % 25U)
          {
            case 0:
              num2 = 169849262;
              continue;
            case 1:
              num2 = 1223567050;
              continue;
            case 2:
              flag3 = zoomWindow2 != null;
              num2 = (int) num4 * 662050524 ^ 1592461535;
              continue;
            case 3:
              zoomWindow2 = this.ActiveMeetingWindow.ClickButtonAwaitResult(current, this.Token, false);
              if (zoomWindow2 != null)
              {
                num2 = (int) num4 * -155127606 ^ 1775486971;
                continue;
              }
              num6 = 0;
              break;
            case 4:
              int num7 = flag4 ? 909547371 : (num7 = 737263543);
              int num8 = (int) num4 * 1033769991;
              num2 = num7 ^ num8;
              continue;
            case 5:
              goto label_57;
            case 6:
              num2 = 538727314;
              continue;
            case 7:
              current = enumerator.Current;
              num2 = 1535668474;
              continue;
            case 8:
              int num9 = !flag3 ? 1618206726 : (num9 = 556283105);
              int num10 = (int) num4 * -124458;
              num2 = num9 ^ num10;
              continue;
            case 9:
              zoomWindow1 = zoomWindow2;
              num2 = (int) num4 * 2020387419 ^ -214958513;
              continue;
            case 10:
              num2 = (int) num4 * 1329243248 ^ 1697551799;
              continue;
            case 11:
              num2 = (int) num4 * 2022671856 ^ -515723721;
              continue;
            case 12:
              Engine.log.Debug((object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1446015654U));
              num2 = (int) num4 * 198995619 ^ -2120787209;
              continue;
            case 13:
              num2 = (int) num4 * -1426178370 ^ 1470117625;
              continue;
            case 14:
              num2 = (int) num4 * 1917826882 ^ 1419273878;
              continue;
            case 15:
              this.ActiveMeetingWindow.Move(new Rectangle(this.ActiveMeetingWindow.Location, current.WindowSize));
              num2 = 1059790112;
              continue;
            case 16:
              int num11 = this.ActiveMeetingWindow != null ? -2026552117 : (num11 = -1456394466);
              int num12 = (int) num4 * -1554710206;
              num2 = num11 ^ num12;
              continue;
            case 17:
              num2 = (int) num4 * -687142474 ^ 1936937530;
              continue;
            case 18:
              num2 = (int) num4 * 1929289151 ^ 1528016025;
              continue;
            case 19:
              num2 = (int) num4 * -560826685 ^ -388668470;
              continue;
            case 21:
              // ISSUE: reference to a compiler-generated field
              Engine.log.DebugFormat(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4158414982U), (object) displayClass2020.zoomWindowType);
              num2 = (int) num4 * -84149499 ^ -1326401607;
              continue;
            case 22:
              current.Delete();
              num2 = 44086847;
              continue;
            case 23:
              num2 = (int) num4 * 1799750895 ^ 1649451362;
              continue;
            case 24:
              // ISSUE: reference to a compiler-generated field
              num6 = zoomWindow2.ZoomWindowType == displayClass2020.zoomWindowType ? 1 : 0;
              break;
            default:
              goto label_65;
          }
          flag4 = num6 != 0;
          num2 = 211325376;
        }
      }
label_65:
label_66:
      int num13 = 1054205281;
label_67:
      while (true)
      {
        int num2 = 1940396140;
        uint num3;
        FindButtons findButtons;
        switch ((num3 = (uint) (num13 ^ num2)) % 25U)
        {
          case 0:
            num13 = 2066989008;
            continue;
          case 1:
            num13 = (int) num3 * -194949885 ^ -1160409437;
            continue;
          case 2:
            num13 = (int) num3 * -499553200 ^ 74591292;
            continue;
          case 3:
            num13 = (int) num3 * -1525712245 ^ 1477438550;
            continue;
          case 4:
            int num4 = zoomWindow1 != null ? -1721055047 : (num4 = -1610092241);
            int num6 = (int) num3 * 1812913148;
            num13 = num4 ^ num6;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            findButtons = new FindButtons(displayClass2020.zoomWindowType);
            num13 = (int) num3 * -1231080028 ^ 2040038924;
            continue;
          case 7:
            num13 = (int) num3 * -1610308853 ^ -280004744;
            continue;
          case 8:
            num13 = 627022038;
            continue;
          case 9:
            Engine.log.DebugFormat(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2730678893U), new object[0]);
            num13 = (int) num3 * 1394684752 ^ -717734029;
            continue;
          case 10:
            num13 = (int) num3 * -562291125 ^ 1797819799;
            continue;
          case 11:
            goto label_78;
          case 12:
            // ISSUE: reference to a compiler-generated field
            zoomWindow1 = this.GetWindow(displayClass2020.zoomWindowType);
            num13 = (int) num3 * 1966309904 ^ -1616988008;
            continue;
          case 13:
            num13 = (int) num3 * 756752685 ^ -209932129;
            continue;
          case 14:
            goto label_88;
          case 15:
            Engine.log.DebugFormat(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2545801628U), new object[0]);
            num13 = (int) num3 * -1860532303 ^ -171404610;
            continue;
          case 16:
            num13 = (int) num3 * 1993876995 ^ 949091429;
            continue;
          case 17:
            num13 = (int) num3 * -152067279 ^ 44032249;
            continue;
          case 18:
            num13 = 1678521648;
            continue;
          case 19:
            int num7 = findButtons.Execute(Engine.token) == ActivityState.Completed ? 1220122195 : (num7 = 943536681);
            int num8 = (int) num3 * -1434749455;
            num13 = num7 ^ num8;
            continue;
          case 20:
            goto label_66;
          case 21:
            num13 = (int) num3 * -1476839496 ^ -1833582767;
            continue;
          case 22:
            num13 = 586089541;
            continue;
          case 23:
            Engine.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3263542804U), new object[0]);
            num13 = (int) num3 * 56140483 ^ -1102450208;
            continue;
          case 24:
            num13 = 467607165;
            continue;
          default:
            goto label_91;
        }
      }
label_91:
      ZoomWindow zoomWindow3;
      return zoomWindow3;
label_78:
      zoomWindow3 = zoomWindow1;
      num13 = 1267221618;
      goto label_67;
label_88:
      Engine.log.DebugFormat(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1955015795U), new object[0]);
      num13 = 1787277020;
      goto label_67;
    }

    public ZoomWindow GetWindow(IntPtr handle, bool createWindowIfNotFound = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass203_0 displayClass2030 = new Engine.\u003C\u003Ec__DisplayClass203_0();
      // ISSUE: reference to a compiler-generated field
      displayClass2030.handle = handle;
      ZoomWindow zoomWindow1 = (ZoomWindow) null;
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_2:
        int num1 = 1136940477;
        while (true)
        {
          int num2 = 579767503;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 2:
              num1 = (int) num3 * -1571349609 ^ 1674576610;
              continue;
            case 3:
              num1 = (int) num3 * 623759429 ^ 1594217864;
              continue;
            case 4:
              // ISSUE: method pointer
              zoomWindow1 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) displayClass2030, __methodptr(\u003CGetWindow\u003Eb__0)));
              num1 = (int) num3 * 1148403424 ^ -724982178;
              continue;
            default:
              goto label_13;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_8:
          int num1 = 1171345177;
          while (true)
          {
            int num2 = 579767503;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_8;
              case 1:
                num1 = (int) num3 * 1624683605 ^ 28782621;
                continue;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * -479901239 ^ 149437088;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      bool flag2 = zoomWindow1 == null & createWindowIfNotFound;
label_14:
      int num4 = 742714817;
      ZoomWindow zoomWindow2;
      while (true)
      {
        int num1 = 579767503;
        uint num2;
        bool flag3;
        switch ((num2 = (uint) (num4 ^ num1)) % 13U)
        {
          case 0:
            goto label_14;
          case 1:
            num4 = 1462208951;
            continue;
          case 2:
            int num3 = !flag3 ? 394890904 : (num3 = 2027563974);
            int num5 = (int) num2 * 641311004;
            num4 = num3 ^ num5;
            continue;
          case 3:
            this.SharedData.ActiveWindows.Add(zoomWindow1);
            num4 = (int) num2 * 1364483203 ^ -483038107;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            zoomWindow1 = ZoomFactory.CreateWindow(displayClass2030.handle);
            num4 = (int) num2 * 489086024 ^ -327976102;
            continue;
          case 6:
            num4 = (int) num2 * -207258106 ^ -925751776;
            continue;
          case 7:
            Engine.\u200F‫​​‌‏⁪⁬​‫‏‌⁭‬​‭⁮‮‮⁭‌‌‪‎‏⁬‏‍⁪‌⁬‍⁬‪⁭⁬⁪⁮‮⁯‮(Engine.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4191931762U), (object) zoomWindow1.ZoomWindowType);
            num4 = (int) num2 * -68695626 ^ 1112977057;
            continue;
          case 8:
            num4 = (int) num2 * 2011745965 ^ -353842734;
            continue;
          case 9:
            zoomWindow2 = zoomWindow1;
            num4 = 297623137;
            continue;
          case 10:
            flag3 = zoomWindow1 != null;
            num4 = (int) num2 * 1110583918 ^ 1198796309;
            continue;
          case 11:
            num4 = (int) num2 * 1635892844 ^ 1491937569;
            continue;
          case 12:
            int num6 = flag2 ? 1968345489 : (num6 = 696419933);
            int num7 = (int) num2 * 1785253539;
            num4 = num6 ^ num7;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return zoomWindow2;
    }

    public List<ZoomWindow> GetWindows(ZoomWindowType zoomWindowType)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass204_0 displayClass2040 = new Engine.\u003C\u003Ec__DisplayClass204_0();
label_1:
      int num1 = -1949726616;
      List<ZoomWindow> zoomWindowList;
      object engineLock;
      while (true)
      {
        int num2 = -12324123;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass2040.zoomWindowType = zoomWindowType;
            num1 = (int) num3 * -1197657164 ^ -378555886;
            continue;
          case 2:
            goto label_1;
          case 3:
            zoomWindowList = new List<ZoomWindow>();
            engineLock = Engine.engineLock;
            num1 = (int) num3 * -1912028344 ^ 759698497;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_7:
        int num2 = -278640880;
        while (true)
        {
          int num3 = -12324123;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * 58587844 ^ 655346260;
              continue;
            case 1:
              // ISSUE: method pointer
              zoomWindowList.AddRange((IEnumerable<ZoomWindow>) ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) displayClass2040, __methodptr(\u003CGetWindows\u003Eb__0)))).ToList<ZoomWindow>());
              num2 = (int) num4 * -908488291 ^ -670491503;
              continue;
            case 3:
              num2 = (int) num4 * 900392122 ^ -16725517;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_13:
          int num2 = -1912573669;
          while (true)
          {
            int num3 = -12324123;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 1608607061 ^ 569101449;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      return zoomWindowList;
    }

    public ZoomMeeting GetMeeting(string meetingId, bool createIfNotFound = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass205_0 displayClass2050 = new Engine.\u003C\u003Ec__DisplayClass205_0();
label_1:
      int num1 = 1406603986;
      object engineLock;
      ZoomMeeting meeting;
      while (true)
      {
        int num2 = 575951453;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass2050.meetingId = meetingId;
            num1 = (int) num3 * -1611515182 ^ -1827523378;
            continue;
          case 3:
            meeting = (ZoomMeeting) null;
            num1 = (int) num3 * 1335193513 ^ -1570608497;
            continue;
          case 4:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 1636835283 ^ 1916241941;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_8:
        int num2 = 1777104816;
        while (true)
        {
          int num3 = 575951453;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              // ISSUE: method pointer
              meeting = (ZoomMeeting) Enumerable.FirstOrDefault<ZoomMeeting>((IEnumerable<M0>) this.Meetings, (Func<M0, bool>) new Func<ZoomMeeting, bool>((object) displayClass2050, __methodptr(\u003CGetMeeting\u003Eb__0)));
              num2 = (int) num4 * 1928560419 ^ 497279953;
              continue;
            case 1:
              num2 = (int) num4 * 1753773313 ^ 814800932;
              continue;
            case 3:
              num2 = (int) num4 * -1534585667 ^ 497954818;
              continue;
            case 4:
              goto label_8;
            default:
              goto label_19;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_14:
          int num2 = 1758485863;
          while (true)
          {
            int num3 = 575951453;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_14;
              case 1:
                num2 = (int) num4 * 1893843737 ^ -732211673;
                continue;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 809832360 ^ -455783492;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
label_19:
      bool flag2 = meeting == null & createIfNotFound;
label_20:
      int num5 = 109710028;
      ZoomMeeting zoomMeeting;
      while (true)
      {
        int num2 = 575951453;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 8U)
        {
          case 0:
            goto label_20;
          case 1:
            int num4 = !flag2 ? 274293721 : (num4 = 1070108399);
            int num6 = (int) num3 * 1387990543;
            num5 = num4 ^ num6;
            continue;
          case 3:
            zoomMeeting = meeting;
            num5 = 1207453303;
            continue;
          case 4:
            num5 = (int) num3 * 167261393 ^ 602455314;
            continue;
          case 5:
            num5 = (int) num3 * 387254426 ^ -1377324151;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            meeting = new ZoomMeeting(displayClass2050.meetingId);
            this.AddMeeting(meeting);
            num5 = (int) num3 * 788539381 ^ -863656316;
            continue;
          case 7:
            num5 = (int) num3 * -763941507 ^ -1579030558;
            continue;
          default:
            goto label_28;
        }
      }
label_28:
      return zoomMeeting;
    }

    internal void SetActiveMeeting(ZoomMeeting meeting, ZoomWindow window)
    {
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
        int num1 = -115080783;
        while (true)
        {
          int num2 = -234785187;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.ActiveMeetingWindow = window;
              num1 = (int) num3 * 573213927 ^ 1056882534;
              continue;
            case 1:
              num1 = (int) num3 * -169265131 ^ 1125210854;
              continue;
            case 2:
              goto label_12;
            case 3:
              goto label_2;
            case 4:
              this.ActiveMeeting = meeting;
              num1 = (int) num3 * 159795514 ^ -1564322559;
              continue;
            case 5:
              num1 = (int) num3 * -1526216013 ^ -1815696359;
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
          int num1 = -1138577186;
          while (true)
          {
            int num2 = -234785187;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_10;
              case 2:
                num1 = (int) num3 * 985952515 ^ -451369210;
                continue;
              case 3:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 1772264829 ^ -1801967528;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    internal void AddButton(ZoomButton button)
    {
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
        if (((Collection<ZoomButton>) this.Buttons).Contains(button))
          goto label_6;
label_2:
        int num1 = 277613664;
label_3:
        bool flag2;
        while (true)
        {
          int num2 = 1148517697;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              goto label_19;
            case 1:
              num1 = (int) num3 * -1075274207 ^ -133612801;
              continue;
            case 2:
              num1 = (int) num3 * -1275665232 ^ 662245192;
              continue;
            case 3:
              ((Collection<ZoomButton>) this.Buttons).Add(button);
              num1 = (int) num3 * 802771074 ^ 2045383768;
              continue;
            case 4:
              goto label_10;
            case 5:
              num1 = (int) num3 * -1292389456 ^ 275272089;
              continue;
            case 6:
              int num4 = !flag2 ? 966163631 : (num4 = 2019219497);
              int num5 = (int) num3 * 217490979;
              num1 = num4 ^ num5;
              continue;
            case 7:
              goto label_2;
            case 8:
              this.ActiveMeeting.AddButton(button);
              num1 = (int) num3 * -194865165 ^ -681729637;
              continue;
            case 9:
              goto label_6;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_19:
        return;
label_10:
        int num6 = Engine.\u200E‌⁯‭‌⁫‫⁫‏⁬‏⁮⁫‭‫⁬⁯‮⁪⁪⁫⁪‍‏​‏‫⁭⁭‌‮‍⁫‌‍⁭⁭‫‌‬‮(this.ActiveMeeting.MeetingId, button.MeetingId) ? 1 : 0;
        goto label_12;
label_6:
        if (this.ActiveMeeting != null)
        {
          num1 = 579626007;
          goto label_3;
        }
        else
          num6 = 0;
label_12:
        flag2 = num6 != 0;
        num1 = 193388547;
        goto label_3;
      }
      finally
      {
        if (flag1)
        {
label_17:
          int num1 = 222743284;
          while (true)
          {
            int num2 = 1148517697;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -776808562 ^ 960505035;
                continue;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 1780044628 ^ -1500492619;
                continue;
              case 3:
                goto label_17;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
    }

    internal void ImportButton(ZoomButton button)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass208_0 displayClass2080 = new Engine.\u003C\u003Ec__DisplayClass208_0();
      // ISSUE: reference to a compiler-generated field
      displayClass2080.button = button;
label_1:
      int num1 = 170602900;
      ZoomButton zoomButton;
      while (true)
      {
        int num2 = 185979295;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            zoomButton = (ZoomButton) null;
            num1 = (int) num3 * 1625095635 ^ -1364534407;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_6:
        int num2 = 125058442;
        while (true)
        {
          int num3 = 185979295;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * 1256520385 ^ -310209190;
              continue;
            case 1:
              num2 = (int) num4 * -1669874211 ^ -72306369;
              continue;
            case 2:
              goto label_6;
            case 3:
              // ISSUE: method pointer
              zoomButton = (ZoomButton) Enumerable.FirstOrDefault<ZoomButton>((IEnumerable<M0>) this.Buttons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) displayClass2080, __methodptr(\u003CImportButton\u003Eb__0)));
              num2 = (int) num4 * -1696906707 ^ -195263994;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_12:
          int num2 = 1542581237;
          while (true)
          {
            int num3 = 185979295;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_12;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 1861242978 ^ -1648501260;
                continue;
              case 3:
                num2 = (int) num4 * 983561935 ^ -1507938781;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      bool flag2 = zoomButton == null;
label_19:
      int num5 = 654140156;
      while (true)
      {
        int num2 = 185979295;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 7U)
        {
          case 0:
            goto label_19;
          case 1:
            int num4 = flag2 ? -1152264186 : (num4 = -888675467);
            int num6 = (int) num3 * 904508329;
            num5 = num4 ^ num6;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.AddButton(displayClass2080.button);
            num5 = (int) num3 * -535281231 ^ 1241937673;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            displayClass2080.button.Uri = 0L;
            num5 = (int) num3 * 1702791029 ^ 1473376694;
            continue;
          case 4:
            num5 = (int) num3 * 285030868 ^ -1556368362;
            continue;
          case 5:
            num5 = (int) num3 * -902148455 ^ 725482740;
            continue;
          case 6:
            goto label_21;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_21:;
    }

    internal void SetMeetingStatus(string meetingId, MeetingStatus meetingStatus)
    {
      ZoomMeeting meeting = this.GetMeeting(meetingId, false);
      bool flag = meeting != null;
label_1:
      int num1 = -741515606;
      while (true)
      {
        int num2 = -718452009;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -1599990327 ^ 1322845804;
            continue;
          case 1:
            int num4 = !flag ? -742509268 : (num4 = -562074906);
            int num5 = (int) num3 * -1796210838;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_1;
          case 3:
            meeting.SaveDatabaseObject();
            num1 = (int) num3 * 635893933 ^ 1993109496;
            continue;
          case 4:
            num1 = (int) num3 * 703246758 ^ -1988700466;
            continue;
          case 5:
            meeting.MeetingStatus = meetingStatus;
            num1 = (int) num3 * 879305064 ^ -968712482;
            continue;
          case 6:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private List<string> LoadDatabase()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass210_1 displayClass2101 = new Engine.\u003C\u003Ec__DisplayClass210_1();
label_1:
      int num1 = -1739270158;
      List<ZoomMeeting> list;
      while (true)
      {
        int num2 = -1682905015;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 171401154 ^ 1190238522;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            displayClass2101.meetingIds = new List<string>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomMeeting>) Enumerable.OrderBy<ZoomMeeting, string>((IEnumerable<M0>) this.ZoomZoomDatabase.GetMeetings(), (Func<M0, M1>) (Engine.\u003C\u003Ec.\u003C\u003E9__210_0 ?? (Engine.\u003C\u003Ec.\u003C\u003E9__210_0 = new Func<ZoomMeeting, string>((object) Engine.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CLoadDatabase\u003Eb__210_0)))))).ToList<ZoomMeeting>();
            num1 = -2053269925;
            continue;
          case 4:
            num1 = (int) num3 * -1930771932 ^ 138367349;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      List<ZoomMeeting>.Enumerator enumerator1 = list.GetEnumerator();
      try
      {
label_14:
        int num2 = enumerator1.MoveNext() ? -946597542 : (num2 = -117252384);
        while (true)
        {
          int num3 = -1682905015;
          uint num4;
          // ISSUE: variable of a compiler-generated type
          Engine.\u003C\u003Ec__DisplayClass210_0 displayClass2100;
          ZoomMeeting keepThisMeeting;
          bool flag;
          switch ((num4 = (uint) (num2 ^ num3)) % 14U)
          {
            case 0:
              num2 = -946597542;
              continue;
            case 1:
              num2 = (int) num4 * 1154110911 ^ -977271358;
              continue;
            case 2:
              num2 = (int) num4 * -159026446 ^ -1635586671;
              continue;
            case 3:
              // ISSUE: object of a compiler-generated type is created
              displayClass2100 = new Engine.\u003C\u003Ec__DisplayClass210_0();
              // ISSUE: reference to a compiler-generated field
              displayClass2100.meeting = enumerator1.Current;
              num2 = -1829797809;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              this.ZoomZoomDatabase.MergeMeetings(keepThisMeeting, displayClass2100.meeting);
              num2 = (int) num4 * -1563908423 ^ 133379008;
              continue;
            case 5:
              num2 = -2057545830;
              continue;
            case 6:
              num2 = (int) num4 * 899954064 ^ 1361554626;
              continue;
            case 7:
              goto label_14;
            case 8:
              num2 = -560637817;
              continue;
            case 9:
              num2 = (int) num4 * 1819690675 ^ 936830601;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated field
              this.AddMeeting(displayClass2100.meeting);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              displayClass2101.meetingIds.Add(displayClass2100.meeting.MeetingId);
              num2 = (int) num4 * 1019678014 ^ -1535692884;
              continue;
            case 11:
              int num5 = flag ? -1706759046 : (num5 = -1911153924);
              int num6 = (int) num4 * -1494773045;
              num2 = num5 ^ num6;
              continue;
            case 12:
              // ISSUE: method pointer
              keepThisMeeting = (ZoomMeeting) Enumerable.FirstOrDefault<ZoomMeeting>((IEnumerable<M0>) this.Meetings, (Func<M0, bool>) new Func<ZoomMeeting, bool>((object) displayClass2100, __methodptr(\u003CLoadDatabase\u003Eb__1)));
              flag = keepThisMeeting != null;
              num2 = (int) num4 * -234560207 ^ -1059024558;
              continue;
            default:
              goto label_27;
          }
        }
      }
      finally
      {
        enumerator1.Dispose();
label_23:
        int num2 = -469130916;
        while (true)
        {
          int num3 = -1682905015;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * 1323201424 ^ 367574176;
              continue;
            case 2:
              goto label_23;
            default:
              goto label_26;
          }
        }
label_26:;
      }
label_27:
      bool meetingsFromWebsite = ZoomZoom.Properties.Settings.Default.LoadMeetingsFromWebsite;
label_28:
      int num7 = -1232423860;
      List<string> stringList;
      while (true)
      {
        int num2 = -1682905015;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            goto label_28;
          case 1:
            if (meetingsFromWebsite)
            {
              num7 = (int) num3 * 2023508885 ^ 263961266;
              continue;
            }
            goto label_48;
          case 2:
            stringList = this.LoadMeetingsFromWebsite();
            // ISSUE: reference to a compiler-generated method
            stringList.RemoveAll(new Predicate<string>(displayClass2101.\u003CLoadDatabase\u003Eb__2));
            num7 = (int) num3 * 1450463621 ^ 1470489548;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      using (List<string>.Enumerator enumerator2 = stringList.GetEnumerator())
      {
label_42:
        int num2 = enumerator2.MoveNext() ? -1271975098 : (num2 = -653614852);
        while (true)
        {
          int num3 = -1682905015;
          uint num4;
          string current;
          switch ((num4 = (uint) (num2 ^ num3)) % 9U)
          {
            case 0:
              num2 = -1271975098;
              continue;
            case 2:
              this.AddMeeting(new ZoomMeeting(current, (ZoomWindow) null));
              num2 = (int) num4 * -565507453 ^ 1802815945;
              continue;
            case 3:
              num2 = (int) num4 * 558183460 ^ 569008967;
              continue;
            case 4:
              goto label_42;
            case 5:
              num2 = (int) num4 * -1056112880 ^ -530955163;
              continue;
            case 6:
              num2 = (int) num4 * -1409083085 ^ -729489774;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              displayClass2101.meetingIds.Add(current);
              num2 = (int) num4 * 888198354 ^ 1723462546;
              continue;
            case 8:
              current = enumerator2.Current;
              num2 = -1741520377;
              continue;
            default:
              goto label_45;
          }
        }
      }
label_45:
label_46:
      int num8 = -373782358;
label_47:
      while (true)
      {
        int num2 = -1682905015;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 4U)
        {
          case 0:
            goto label_46;
          case 2:
            num8 = (int) num3 * 2015698161 ^ -1554831102;
            continue;
          case 3:
            goto label_48;
          default:
            goto label_50;
        }
      }
label_50:
      List<string> meetingIds;
      return meetingIds;
label_48:
      // ISSUE: reference to a compiler-generated field
      meetingIds = displayClass2101.meetingIds;
      num8 = -1081212409;
      goto label_47;
    }

    internal void CloseWindow(ZoomWindowType zoomWindowType)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass211_0 displayClass2110 = new Engine.\u003C\u003Ec__DisplayClass211_0();
label_1:
      int num1 = -407110300;
      while (true)
      {
        int num2 = -1624208581;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass2110.zoomWindowType = zoomWindowType;
            num1 = (int) num3 * 1239587790 ^ -1527431330;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
label_6:
        int num2 = -771841490;
        List<ZoomWindow> list;
        while (true)
        {
          int num3 = -1624208581;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              // ISSUE: method pointer
              list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) displayClass2110, __methodptr(\u003CCloseWindow\u003Eb__0)))).ToList<ZoomWindow>();
              num2 = (int) num4 * 1735975036 ^ -1793162880;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_9;
          }
        }
label_9:
        using (List<ZoomWindow>.Enumerator enumerator = list.GetEnumerator())
        {
label_15:
          int num3 = !enumerator.MoveNext() ? -584206139 : (num3 = -1917564798);
          while (true)
          {
            int num4 = -1624208581;
            uint num5;
            ZoomWindow current;
            switch ((num5 = (uint) (num3 ^ num4)) % 6U)
            {
              case 0:
                num3 = (int) num5 * -18241483 ^ -1623125776;
                continue;
              case 1:
                goto label_15;
              case 2:
                num3 = -1917564798;
                continue;
              case 3:
                current.Close(true, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2098732721U));
                num3 = (int) num5 * -526300441 ^ -1998519680;
                continue;
              case 4:
                goto label_26;
              case 5:
                current = enumerator.Current;
                num3 = -239986072;
                continue;
              default:
                goto label_23;
            }
          }
label_23:
          return;
label_26:;
        }
      }
      catch (Exception ex)
      {
label_21:
        int num2 = -350634386;
        while (true)
        {
          int num3 = -1624208581;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_21;
            case 1:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num2 = (int) num4 * -307912202 ^ 2043222823;
              continue;
            case 2:
              num2 = (int) num4 * 856289101 ^ 596580558;
              continue;
            case 3:
              goto label_19;
            default:
              goto label_17;
          }
        }
label_17:
        return;
label_19:;
      }
    }

    internal void ApplyPattern()
    {
      try
      {
        IEnumerator<ZoomWindow> enumerator = this.ActiveWindows.GetEnumerator();
        try
        {
label_7:
          int num1 = Engine.\u202D‏⁫‎‭‎‏⁭‏‫‬‮⁭‌‏⁮‏‌⁯⁮‌‭‌‬⁫⁬‍‬‏​‍‮‬⁪‬‫⁮‍‪‮((IEnumerator) enumerator) ? -838287746 : (num1 = -432778167);
          while (true)
          {
            int num2 = -96186866;
            uint num3;
            ZoomWindow current;
            switch ((num3 = (uint) (num1 ^ num2)) % 7U)
            {
              case 0:
                goto label_24;
              case 1:
                num1 = (int) num3 * 1577903362 ^ 948917232;
                continue;
              case 2:
                current = enumerator.Current;
                num1 = -604303450;
                continue;
              case 3:
                num1 = (int) num3 * -1238306299 ^ -1997461512;
                continue;
              case 4:
                current.Refresh(true, false);
                num1 = (int) num3 * 1180276083 ^ 732044913;
                continue;
              case 5:
                num1 = -838287746;
                continue;
              case 6:
                goto label_7;
              default:
                goto label_21;
            }
          }
label_21:
          return;
label_24:;
        }
        finally
        {
          if (enumerator != null)
          {
label_11:
            int num1 = -2070520120;
            while (true)
            {
              int num2 = -96186866;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_11;
                case 1:
                  num1 = (int) num3 * 898047789 ^ 1978341136;
                  continue;
                case 2:
                  Engine.\u202C​‮⁯‍‮⁭⁯​‮⁯‎‭⁯‫‍‫‮⁫⁫⁫​‍⁪‍‫⁪‫‭‪‍‎‏‭⁯‪⁮‭​⁭‮((IDisposable) enumerator);
                  num1 = (int) num3 * -472105322 ^ -525103373;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
label_19:
        int num1 = -1445425299;
        while (true)
        {
          int num2 = -96186866;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_19;
            case 1:
              num1 = (int) num3 * -684681464 ^ 1694439884;
              continue;
            case 2:
              goto label_17;
            case 3:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * 1145560878 ^ 1643378297;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_17:;
      }
    }

    private void LoadMeetings()
    {
      this.RaiseEvent(EngineEvent.LoadingData, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(626564989U));
label_1:
      int num1 = -20172920;
      while (true)
      {
        int num2 = -753263230;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            this.LoadDatabase();
            num1 = (int) num3 * -1994545592 ^ 1875093862;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      List<string>.Enumerator enumerator = Engine.zoomDatabase.GetPreviousZoomRooms().GetEnumerator();
      try
      {
label_16:
        int num2 = enumerator.MoveNext() ? -839770341 : (num2 = -1554915229);
        while (true)
        {
          int num3 = -753263230;
          uint num4;
          ZoomMeeting meeting;
          string current;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              num2 = -839770341;
              continue;
            case 1:
              if (meeting == null)
              {
                num5 = 0;
                break;
              }
              num2 = (int) num4 * -1169294967 ^ 1025504857;
              continue;
            case 2:
              num5 = meeting.MeetingStatus == MeetingStatus.Invalid ? 1 : 0;
              break;
            case 3:
              num2 = (int) num4 * 2122759116 ^ -889662744;
              continue;
            case 4:
              num2 = -1135244515;
              continue;
            case 6:
              meeting = this.GetMeeting(current, true);
              num2 = (int) num4 * 483719901 ^ -1556855371;
              continue;
            case 7:
              current = enumerator.Current;
              num2 = -1242990300;
              continue;
            case 8:
              Engine.zoomDatabase.ScrubMeeting(meeting.MeetingId);
              num2 = (int) num4 * 15850314 ^ -18186094;
              continue;
            case 9:
              goto label_16;
            default:
              goto label_24;
          }
          int num6;
          num2 = num6 = num5 == 0 ? -455591954 : (num6 = -2108468365);
        }
      }
      finally
      {
        enumerator.Dispose();
label_20:
        int num2 = -1313752878;
        while (true)
        {
          int num3 = -753263230;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * 506913134 ^ 1218638780;
              continue;
            case 2:
              goto label_20;
            default:
              goto label_23;
          }
        }
label_23:;
      }
label_24:
      // ISSUE: reference to a compiler-generated field
      EventHandler onMeetingsChanged = this.OnMeetingsChanged;
      if (onMeetingsChanged == null)
        return;
      // ISSUE: variable of the null type
      __Null local = null;
      onMeetingsChanged((object) this, (EventArgs) local);
    }

    private List<string> LoadMeetingsFromWebsite()
    {
label_1:
      int num1 = 2092832259;
      List<string> stringList1;
      while (true)
      {
        int num2 = 1650686928;
        uint num3;
        List<string> stringList2;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            stringList1 = stringList2;
            num1 = 1922037733;
            continue;
          case 2:
            int num4 = this.GetFile(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(643783331U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(307023589U)) ? -1667386285 : (num4 = -1231437955);
            int num5 = (int) num3 * 1294478238;
            num1 = num4 ^ num5;
            continue;
          case 3:
            stringList2 = new List<string>();
            num1 = (int) num3 * 1277935949 ^ 135252005;
            continue;
          case 4:
            num1 = (int) num3 * -714276221 ^ -821407387;
            continue;
          case 5:
            num1 = (int) num3 * 1093563730 ^ 1137798524;
            continue;
          case 7:
            stringList2.AddRange((IEnumerable<string>) ((IEnumerable<string>) Engine.\u206F⁭‍‭‪⁭‍‌⁪⁬‫⁫⁬⁪‫‍‮⁮‫‬‬‌‭⁮​‫‭‎​​⁪​⁪​‬⁭⁮⁮‍⁮‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2909948272U))).ToList<string>());
            CoreUtils.DeleteFile(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(984392172U));
            num1 = (int) num3 * -341403949 ^ 907478961;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return stringList1;
    }

    internal bool RemoveMeeting(string meetingId)
    {
      bool flag1 = false;
      try
      {
        ZoomMeeting meeting = this.GetMeeting(meetingId, false);
        if (meeting == null)
          goto label_8;
label_2:
        int num1 = 845468235;
label_3:
        while (true)
        {
          int num2 = 285027165;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              flag1 = true;
              num1 = (int) num3 * 835302029 ^ 1213520066;
              continue;
            case 1:
              this.RemoveMeeting(meeting);
              num1 = (int) num3 * -237793787 ^ -1088414755;
              continue;
            case 2:
              num1 = (int) num3 * 1102317955 ^ -798297741;
              continue;
            case 3:
              goto label_8;
            case 4:
              num1 = (int) num3 * -113471209 ^ -1531497365;
              continue;
            case 5:
              num1 = (int) num3 * -768729185 ^ -1484647216;
              continue;
            case 6:
              goto label_2;
            case 8:
              num1 = (int) num3 * -1140058327 ^ 611158870;
              continue;
            default:
              goto label_17;
          }
        }
label_8:
        Engine.zoomDatabase.ScrubMeeting(meetingId);
        num1 = 910430885;
        goto label_3;
      }
      catch (Exception ex)
      {
label_12:
        int num1 = 893583064;
        while (true)
        {
          int num2 = 285027165;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * -1206921380 ^ -82597323;
              continue;
            case 2:
              goto label_12;
            case 3:
              num1 = (int) num3 * 2090614631 ^ 1372273923;
              continue;
            case 4:
              num1 = (int) num3 * -2021153487 ^ -117703284;
              continue;
            default:
              goto label_17;
          }
        }
      }
label_17:
      bool flag2 = flag1;
label_18:
      int num4 = 1040263594;
      while (true)
      {
        int num1 = 285027165;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_18;
          case 1:
            num4 = (int) num2 * -974074521 ^ -626843306;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return flag2;
    }

    internal void RemoveMeeting(ZoomMeeting meeting)
    {
label_1:
      int num1 = -1895215453;
      bool flag1;
      while (true)
      {
        int num2 = -2137785650;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1795529945 ^ 1122064740;
            continue;
          case 1:
            flag1 = false;
            if (meeting != null)
            {
              num1 = (int) num3 * -2037409335 ^ 687051279;
              continue;
            }
            goto label_24;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_24:
      return;
label_6:
      object engineLock = Engine.engineLock;
      bool flag2 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag2);
label_8:
        int num2 = -937362419;
        while (true)
        {
          int num3 = -2137785650;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = -1000500529;
              continue;
            case 2:
              num2 = (int) num4 * 1346860007 ^ -1699280168;
              continue;
            case 3:
              goto label_8;
            case 4:
              ((Collection<ZoomMeeting>) this.Meetings).Remove(meeting);
              flag1 = true;
              num2 = (int) num4 * 1842747202 ^ -1409692524;
              continue;
            case 5:
              int num5 = !((Collection<ZoomMeeting>) this.Meetings).Contains(meeting) ? 25742965 : (num5 = 1308738629);
              int num6 = (int) num4 * -57520469;
              num2 = num5 ^ num6;
              continue;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_16:
          int num2 = -556657894;
          while (true)
          {
            int num3 = -2137785650;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 179276379 ^ -1269811703;
                continue;
              case 2:
                goto label_16;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:
      bool flag3 = meeting.Uri > 0L;
label_22:
      int num7 = -1007534751;
      while (true)
      {
        int num2 = -2137785650;
        uint num3;
        bool flag4;
        switch ((num3 = (uint) (num7 ^ num2)) % 14U)
        {
          case 0:
            int num4 = flag4 ? 1247379267 : (num4 = 2006446294);
            int num5 = (int) num3 * 1015834870;
            num7 = num4 ^ num5;
            continue;
          case 1:
            num7 = (int) num3 * 2062850397 ^ 622615759;
            continue;
          case 2:
            goto label_22;
          case 3:
            num7 = (int) num3 * -849861260 ^ -1260190435;
            continue;
          case 4:
            ((CompositePresentationEvent<string>) this._eventAggregator.GetEvent<MeetingDeleted>()).Publish(meeting.MeetingId);
            num7 = (int) num3 * 557693458 ^ 655644319;
            continue;
          case 5:
            // ISSUE: type reference
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
            {
              ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (ZoomMeeting)),
              ChangeType = ChangeType.Removed,
              ChangedObject = (object) meeting
            });
            num7 = (int) num3 * 461633850 ^ -1375925184;
            continue;
          case 6:
            goto label_18;
          case 7:
            int num6 = flag3 ? -1841562528 : (num6 = -715956662);
            int num8 = (int) num3 * 1722717747;
            num7 = num6 ^ num8;
            continue;
          case 8:
            num7 = -920884166;
            continue;
          case 9:
            flag4 = flag1;
            num7 = -870956756;
            continue;
          case 10:
            num7 = (int) num3 * 2080226777 ^ 2070711801;
            continue;
          case 11:
            num7 = (int) num3 * -578661176 ^ -1383846245;
            continue;
          case 12:
            num7 = (int) num3 * 664893868 ^ -569536726;
            continue;
          case 13:
            meeting.DeleteDatabaseObject();
            num7 = (int) num3 * 385591430 ^ 481248650;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_18:;
    }

    internal void AddMeeting(ZoomMeeting meeting)
    {
      bool flag1 = false;
label_1:
      int num1 = 351803420;
      object engineLock;
      while (true)
      {
        int num2 = 358983400;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 1070337645 ^ -1156443030;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag2 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag2);
label_6:
        int num2 = 1529166738;
        while (true)
        {
          int num3 = 358983400;
          uint num4;
          bool flag3;
          switch ((num4 = (uint) (num2 ^ num3)) % 11U)
          {
            case 0:
              flag1 = true;
              num2 = (int) num4 * 111802282 ^ 1133185316;
              continue;
            case 2:
              int num5 = flag3 ? 704168731 : (num5 = 283920782);
              int num6 = (int) num4 * -1715152642;
              num2 = num5 ^ num6;
              continue;
            case 3:
              flag3 = !((Collection<ZoomMeeting>) this.Meetings).Contains(meeting);
              num2 = (int) num4 * 62508120 ^ 641471612;
              continue;
            case 4:
              num2 = 670314471;
              continue;
            case 5:
              goto label_6;
            case 6:
              ((Collection<ZoomMeeting>) this.Meetings).Add(meeting);
              num2 = (int) num4 * -13559067 ^ 215317330;
              continue;
            case 7:
              num2 = (int) num4 * -451770718 ^ 1438711783;
              continue;
            case 8:
              num2 = (int) num4 * -1098841038 ^ 1515577462;
              continue;
            case 9:
              num2 = (int) num4 * -275956287 ^ 480995908;
              continue;
            case 10:
              num2 = (int) num4 * -1533669033 ^ -1744705828;
              continue;
            default:
              goto label_25;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_19:
          int num2 = 680709735;
          while (true)
          {
            int num3 = 358983400;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_19;
              case 1:
                num2 = (int) num4 * 148138310 ^ 417679432;
                continue;
              case 3:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 893476380 ^ -1001478171;
                continue;
              default:
                goto label_24;
            }
          }
        }
label_24:;
      }
label_25:
      if (!flag1)
        return;
label_26:
      int num7 = 1918078826;
      while (true)
      {
        int num2 = 358983400;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 5U)
        {
          case 0:
            // ISSUE: type reference
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
            {
              ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (ZoomMeeting)),
              ChangeType = ChangeType.Added,
              ChangedObject = (object) meeting
            });
            num7 = (int) num3 * 638231419 ^ -398029394;
            continue;
          case 1:
            num7 = (int) num3 * 1950517240 ^ 1876732941;
            continue;
          case 2:
            goto label_26;
          case 3:
            ((CompositePresentationEvent<string>) this._eventAggregator.GetEvent<MeetingAdded>()).Publish(meeting.MeetingId);
            num7 = (int) num3 * -581117156 ^ -1210189586;
            continue;
          case 4:
            goto label_21;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_21:;
    }

    internal void LogException(string newLogMessage)
    {
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
        this.logMessage = newLogMessage;
label_2:
        int num1 = 1474634604;
        while (true)
        {
          int num2 = 851430063;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1549818761 ^ -836937931;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_6:
          int num1 = 892751389;
          while (true)
          {
            int num2 = 851430063;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_6;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 405266725 ^ -417648626;
                continue;
              case 3:
                num1 = (int) num3 * -1691781881 ^ -1974790445;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
label_12:
      // ISSUE: reference to a compiler-generated field
      bool flag2 = this.OnLogMessageChanged != null;
label_13:
      int num4 = 615965676;
      while (true)
      {
        int num1 = 851430063;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 6U)
        {
          case 0:
            num4 = (int) num2 * 780002068 ^ -316706759;
            continue;
          case 1:
            int num3 = !flag2 ? -1276848946 : (num3 = -690797810);
            int num5 = (int) num2 * 1077043197;
            num4 = num3 ^ num5;
            continue;
          case 2:
            goto label_15;
          case 3:
            num4 = (int) num2 * 1274201080 ^ -110326905;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.OnLogMessageChanged((object) this, (EventArgs) new ZoomZoomEventArgs()
            {
              EventDescription = newLogMessage
            });
            num4 = (int) num2 * -265179283 ^ -1983803804;
            continue;
          case 5:
            goto label_13;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_15:;
    }

    internal void AddActivityQueue(ZoomEvent windowEvent)
    {
label_1:
      int num1 = 2059548117;
      object engineLock;
      while (true)
      {
        int num2 = 1983080398;
        uint num3;
        ActivityBase activeActivity;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 1:
            engineLock = Engine.engineLock;
            num1 = 1460851606;
            continue;
          case 2:
            goto label_1;
          case 3:
            activeActivity = Engine.Instance.ActivityManager.ActiveActivity;
            num1 = (int) num3 * 525309724 ^ 1090082974;
            continue;
          case 4:
            int num4 = activeActivity == null ? 899240495 : (num4 = 174545243);
            int num5 = (int) num3 * -356756370;
            num1 = num4 ^ num5;
            continue;
          case 5:
            num1 = (int) num3 * 76020052 ^ 1093117845;
            continue;
          case 6:
            num1 = (int) num3 * 74889720 ^ 979924551;
            continue;
          case 7:
            activeActivity.PendingEvents.Enqueue(windowEvent);
            num1 = (int) num3 * -995993459 ^ 304908131;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_11:
        int num2 = 702380075;
        while (true)
        {
          int num3 = 1983080398;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_11;
            case 1:
              goto label_18;
            case 2:
              this.ActivityQueue.Enqueue(windowEvent);
              num2 = (int) num4 * -1761052375 ^ -2132019056;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_18:;
      }
      finally
      {
        if (flag)
        {
label_16:
          int num2 = 175514995;
          while (true)
          {
            int num3 = 1983080398;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 77930455 ^ -2075485190;
                continue;
              case 2:
                goto label_16;
              case 3:
                num2 = (int) num4 * -494142033 ^ 118620451;
                continue;
              default:
                goto label_21;
            }
          }
        }
label_21:;
      }
    }

    internal void PurgeActivityQueue()
    {
label_1:
      int num1 = -691057248;
      object engineLock;
      while (true)
      {
        int num2 = -1530432599;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 826295275 ^ -1641281361;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_6:
        int num2 = -326335062;
        while (true)
        {
          int num3 = -1530432599;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              num2 = -1082910065;
              continue;
            case 1:
              num2 = (int) num4 * -247586626 ^ 321727205;
              continue;
            case 2:
              goto label_6;
            case 3:
              ZoomEvent zoomEvent;
              int num5;
              num2 = num5 = !this.ActivityQueue.TryDequeue(ref zoomEvent) ? -1149740008 : (num5 = -373407573);
              continue;
            case 4:
              num2 = (int) num4 * -171350784 ^ 651036559;
              continue;
            case 5:
              num2 = (int) num4 * -1951457773 ^ -1548185143;
              continue;
            case 6:
              goto label_17;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_17:;
      }
      finally
      {
        if (flag)
        {
label_15:
          int num2 = -1479178682;
          while (true)
          {
            int num3 = -1530432599;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_15;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -1779485655 ^ -387543280;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    private void FillJoinOrder()
    {
      bool flag = Engine.JoinOrder == null;
label_1:
      int num1 = 1845189939;
      while (true)
      {
        int num2 = 2127394572;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -1546319701 ^ -1778201329;
            continue;
          case 1:
            int num4 = !flag ? 180967510 : (num4 = 1738435854);
            int num5 = (int) num3 * 107524354;
            num1 = num4 ^ num5;
            continue;
          case 2:
            Engine.JoinOrder = new List<string>();
            num1 = (int) num3 * -287470314 ^ -1211341388;
            continue;
          case 3:
            num1 = (int) num3 * -723512218 ^ -1107966514;
            continue;
          case 4:
            Engine.JoinOrder.Clear();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            ((IEnumerable<ZoomMeeting>) Enumerable.OrderByDescending<ZoomMeeting, DateTime>((IEnumerable<M0>) this.Meetings, (Func<M0, M1>) (Engine.\u003C\u003Ec.\u003C\u003E9__325_0 ?? (Engine.\u003C\u003Ec.\u003C\u003E9__325_0 = new Func<ZoomMeeting, DateTime>((object) Engine.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CFillJoinOrder\u003Eb__325_0)))))).ToList<ZoomMeeting>().ForEach((Action<ZoomMeeting>) (o =>
            {
              Engine.JoinOrder.Add(o.MeetingId);
label_1:
              int num2 = 1751498474;
              while (true)
              {
                int num3 = 881854403;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num2 = (int) num4 * 1716677492 ^ 1143533744;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }));
            num1 = 1642041400;
            continue;
          case 5:
            goto label_1;
          case 6:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    internal bool GetFile(string sourceFile, string destinationFile)
    {
      bool flag1 = false;
      try
      {
        CoreUtils.DeleteFile(destinationFile);
label_2:
        int num1 = -1233078698;
        while (true)
        {
          int num2 = -675046973;
          uint num3;
          ftp ftp;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              ftp = new ftp(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2289391473U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1253402061U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1901107440U));
              num1 = (int) num3 * -580850344 ^ 1095892290;
              continue;
            case 1:
              ftp = (ftp) null;
              flag2 = Engine.\u206F‬⁯⁫‫‬‬‏‪‪⁬⁬‬⁬‌‫⁭‬⁯‎‎⁫​⁯‎⁬‎‮‫⁯⁫‎⁯‍‏​⁫‌⁮⁬‮(destinationFile);
              num1 = (int) num3 * -44795617 ^ 1314392557;
              continue;
            case 2:
              num1 = (int) num3 * 1249583564 ^ -1334350574;
              continue;
            case 3:
              num1 = (int) num3 * -564663076 ^ 1812698287;
              continue;
            case 4:
              num1 = (int) num3 * -1620652021 ^ -1129110790;
              continue;
            case 5:
              ftp.download(sourceFile, destinationFile);
              num1 = (int) num3 * 1890834565 ^ -304900282;
              continue;
            case 6:
              int num4 = !flag2 ? 484331094 : (num4 = 179579960);
              int num5 = (int) num3 * 1663626652;
              num1 = num4 ^ num5;
              continue;
            case 8:
              goto label_2;
            case 9:
              num1 = (int) num3 * -622815283 ^ -233304194;
              continue;
            case 10:
              flag1 = true;
              num1 = (int) num3 * -2046391111 ^ -2023319351;
              continue;
            default:
              goto label_18;
          }
        }
      }
      catch (Exception ex)
      {
label_14:
        int num1 = -487051983;
        while (true)
        {
          int num2 = -675046973;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * -1118158114 ^ 1810642233;
              continue;
            case 2:
              num1 = (int) num3 * 1745180252 ^ -1114102974;
              continue;
            case 3:
              goto label_14;
            default:
              goto label_18;
          }
        }
      }
label_18:
      bool flag3 = flag1;
label_19:
      int num6 = -1846801831;
      while (true)
      {
        int num1 = -675046973;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 1:
            num6 = (int) num2 * 680082321 ^ 1546161909;
            continue;
          case 2:
            goto label_19;
          default:
            goto label_22;
        }
      }
label_22:
      return flag3;
    }

    internal void SaveMeetings()
    {
      string str1 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1059073193U);
      try
      {
        List<string> stringList = new List<string>();
        object engineLock = Engine.engineLock;
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_3:
          int num1 = -1043077371;
          while (true)
          {
            int num2 = -1402522723;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 1:
                num1 = (int) num3 * 90542097 ^ 1563015190;
                continue;
              case 2:
                num1 = (int) num3 * -1403029584 ^ 1504117224;
                continue;
              case 3:
                num1 = (int) num3 * 983051252 ^ 1074577691;
                continue;
              case 4:
                goto label_3;
              default:
                goto label_8;
            }
          }
label_8:
          IEnumerator<ZoomMeeting> enumerator = ((Collection<ZoomMeeting>) this.Meetings).GetEnumerator();
          try
          {
label_19:
            int num2 = !Engine.\u202D‏⁫‎‭‎‏⁭‏‫‬‮⁭‌‏⁮‏‌⁯⁮‌‭‌‬⁫⁬‍‬‏​‍‮‬⁪‬‫⁮‍‪‮((IEnumerator) enumerator) ? -1642115969 : (num2 = -4296059);
            while (true)
            {
              int num3 = -1402522723;
              uint num4;
              ZoomMeeting current;
              string str2;
              bool flag2;
              int num5;
              switch ((num4 = (uint) (num2 ^ num3)) % 11U)
              {
                case 0:
                  num2 = -2051536005;
                  continue;
                case 2:
                  current = enumerator.Current;
                  str2 = Engine.\u206C‫‌‍‬‏‫‌⁫‌‎⁬‪‪‮⁫‌‌‭‬⁪‏⁫‬‭⁮‭​‏⁫‭⁪⁪⁯‮‌‍⁫‏‪‮(current.MeetingId, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2691421578U), "");
                  num2 = -1089382865;
                  continue;
                case 3:
                  goto label_19;
                case 4:
                  num2 = (int) num4 * 1887763048 ^ 565428113;
                  continue;
                case 5:
                  num2 = -4296059;
                  continue;
                case 6:
                  num5 = !Engine.\u200E‌⁯‭‌⁫‫⁫‏⁬‏⁮⁫‭‫⁬⁯‮⁪⁪⁫⁪‍‏​‏‫⁭⁭‌‮‍⁫‌‍⁭⁭‫‌‬‮(str2, string.Empty) ? 1 : 0;
                  break;
                case 7:
                  num2 = (int) num4 * -1817483021 ^ 735405674;
                  continue;
                case 8:
                  int num6 = !flag2 ? 324714077 : (num6 = 1494043496);
                  int num7 = (int) num4 * -365579218;
                  num2 = num6 ^ num7;
                  continue;
                case 9:
                  stringList.Add(str2);
                  num2 = (int) num4 * 271610914 ^ 888041539;
                  continue;
                case 10:
                  if (current.MeetingStatus != MeetingStatus.Invalid)
                  {
                    num2 = (int) num4 * 971461490 ^ -2106867447;
                    continue;
                  }
                  num5 = 0;
                  break;
                default:
                  goto label_34;
              }
              flag2 = num5 != 0;
              num2 = -2022175733;
            }
          }
          finally
          {
            if (enumerator != null)
            {
label_25:
              int num2 = -581910675;
              while (true)
              {
                int num3 = -1402522723;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_25;
                  case 2:
                    Engine.\u202C​‮⁯‍‮⁭⁯​‮⁯‎‭⁯‫‍‫‮⁫⁫⁫​‍⁪‍‫⁪‫‭‪‍‎‏‭⁯‪⁮‭​⁭‮((IDisposable) enumerator);
                    num2 = (int) num4 * -624697348 ^ 1378807319;
                    continue;
                  default:
                    goto label_28;
                }
              }
            }
label_28:;
          }
        }
        finally
        {
          if (flag1)
          {
label_30:
            int num1 = -595665751;
            while (true)
            {
              int num2 = -1402522723;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_30;
                case 2:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * -6417930 ^ 1195342061;
                  continue;
                default:
                  goto label_33;
              }
            }
          }
label_33:;
        }
label_34:
        bool flag3 = Engine.\u206F‬⁯⁫‫‬‬‏‪‪⁬⁬‬⁬‌‫⁭‬⁯‎‎⁫​⁯‎⁬‎‮‫⁯⁫‎⁯‍‏​⁫‌⁮⁬‮(str1);
label_35:
        int num8 = -338721793;
        while (true)
        {
          int num1 = -1402522723;
          uint num2;
          switch ((num2 = (uint) (num8 ^ num1)) % 7U)
          {
            case 0:
              goto label_35;
            case 1:
              Engine.\u202A​⁯‎⁫‏‍‪‬⁭‏⁭⁪‮‭‫⁪⁫‏‪‎‪⁬⁬⁯‪⁬⁯‮‪‬‎⁭⁮‪‏⁬⁭⁪⁭‮(str1, stringList.ToArray(), Engine.\u200E‫‏⁫⁮‌⁭‎⁭⁯​‫‬‬⁫‬‏​⁭‍⁮⁬‪​⁯⁮‌⁯⁪‎‬⁫​‭⁪⁭‮‬⁪‌‮());
              num8 = -305516767;
              continue;
            case 3:
              num8 = (int) num2 * -1422541230 ^ -339619058;
              continue;
            case 4:
              num8 = (int) num2 * 548109739 ^ -2123538263;
              continue;
            case 5:
              int num3 = !flag3 ? 596483776 : (num3 = 2137726469);
              int num4 = (int) num2 * 1793092149;
              num8 = num3 ^ num4;
              continue;
            case 6:
              Engine.\u200C‭‮‪⁫‫⁪‎‫⁯‌‭‏‏⁪‭‬‪⁪⁭‪⁮‪⁬‭‌‍⁭⁬⁮‎‎‍⁬⁭⁭‍‫‫‍‮(str1);
              num8 = (int) num2 * -446145634 ^ -155506445;
              continue;
            default:
              goto label_42;
          }
        }
label_42:
        IEnumerator<ZoomMeeting> enumerator1 = ((Collection<ZoomMeeting>) this.Meetings).GetEnumerator();
        try
        {
label_47:
          int num1 = !Engine.\u202D‏⁫‎‭‎‏⁭‏‫‬‮⁭‌‏⁮‏‌⁯⁮‌‭‌‬⁫⁬‍‬‏​‍‮‬⁪‬‫⁮‍‪‮((IEnumerator) enumerator1) ? -1487780383 : (num1 = -1886075921);
          while (true)
          {
            int num2 = -1402522723;
            uint num3;
            ZoomMeeting current;
            switch ((num3 = (uint) (num1 ^ num2)) % 6U)
            {
              case 1:
                current.SaveDatabaseObject();
                num1 = (int) num3 * 657583519 ^ 999237732;
                continue;
              case 2:
                current = enumerator1.Current;
                num1 = -1786220862;
                continue;
              case 3:
                num1 = -1886075921;
                continue;
              case 4:
                num1 = (int) num3 * -1401308358 ^ -971463848;
                continue;
              case 5:
                goto label_47;
              default:
                goto label_63;
            }
          }
        }
        finally
        {
          if (enumerator1 != null)
          {
label_51:
            int num1 = -895352154;
            while (true)
            {
              int num2 = -1402522723;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_51;
                case 1:
                  num1 = (int) num3 * 834321513 ^ -1689669862;
                  continue;
                case 3:
                  Engine.\u202C​‮⁯‍‮⁭⁯​‮⁯‎‭⁯‫‍‫‮⁫⁫⁫​‍⁪‍‫⁪‫‭‪‍‎‏‭⁯‪⁮‭​⁭‮((IDisposable) enumerator1);
                  num1 = (int) num3 * -807426557 ^ 1912456425;
                  continue;
                default:
                  goto label_55;
              }
            }
          }
label_55:;
        }
      }
      catch (Exception ex)
      {
label_58:
        int num1 = -1067093108;
        while (true)
        {
          int num2 = -1402522723;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_58;
            case 2:
              num1 = (int) num3 * -1863911518 ^ 289856853;
              continue;
            default:
              goto label_62;
          }
        }
label_62:
        Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
      }
label_63:
      if (!ZoomZoom.Properties.Settings.Default.SaveMeetingsToWebsite)
        return;
label_64:
      int num9 = -1306860530;
      while (true)
      {
        int num1 = -1402522723;
        uint num2;
        switch ((num2 = (uint) (num9 ^ num1)) % 6U)
        {
          case 0:
            num9 = (int) num2 * -987523787 ^ -1354128539;
            continue;
          case 1:
            num9 = (int) num2 * -1337323010 ^ 1618927569;
            continue;
          case 2:
            num9 = (int) num2 * 4029540 ^ 305538844;
            continue;
          case 3:
            goto label_60;
          case 4:
            this.SaveMeetingsToWebsite();
            num9 = (int) num2 * 518996859 ^ 1009445021;
            continue;
          case 5:
            goto label_64;
          default:
            goto label_56;
        }
      }
label_56:
      return;
label_60:;
    }

    private void SaveMeetingsToWebsite()
    {
      List<string> source = new List<string>();
      bool file = this.GetFile(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(643783331U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1474473424U));
label_1:
      int num1 = 628571886;
      List<string> list;
      while (true)
      {
        int num2 = 1941035740;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            source.AddRange((IEnumerable<string>) ((IEnumerable<string>) Engine.\u206F⁭‍‭‪⁭‍‌⁪⁬‫⁫⁬⁪‫‍‮⁮‫‬‬‌‭⁮​‫‭‎​​⁪​⁪​‬⁭⁮⁮‍⁮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2708152504U))).ToList<string>());
            num1 = (int) num3 * -1564971725 ^ -1007954535;
            continue;
          case 1:
            num1 = (int) num3 * 818763085 ^ -1437364492;
            continue;
          case 2:
            int num4 = file ? 801063906 : (num4 = 273524066);
            int num5 = (int) num3 * 1378033847;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * 960290538 ^ 954000158;
            continue;
          case 5:
            goto label_1;
          case 6:
            list = source.ToList<string>();
            num1 = 118760277;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      IEnumerator<ZoomMeeting> enumerator = ((Collection<ZoomMeeting>) this.Meetings).GetEnumerator();
      try
      {
label_18:
        int num2 = Engine.\u202D‏⁫‎‭‎‏⁭‏‫‬‮⁭‌‏⁮‏‌⁯⁮‌‭‌‬⁫⁬‍‬‏​‍‮‬⁪‬‫⁮‍‪‮((IEnumerator) enumerator) ? 1463849063 : (num2 = 1388169177);
        while (true)
        {
          int num3 = 1941035740;
          uint num4;
          ZoomMeeting current;
          int num5;
          int num6;
          switch ((num4 = (uint) (num2 ^ num3)) % 16U)
          {
            case 0:
              if (!list.Contains(current.MeetingId))
              {
                num2 = 1958376849;
                continue;
              }
              goto label_28;
            case 1:
              num2 = (int) num4 * 145509358 ^ 863950436;
              continue;
            case 2:
              num2 = (int) num4 * -1980754486 ^ 260113713;
              continue;
            case 3:
              num5 = !Engine.\u200E‌⁯‭‌⁫‫⁫‏⁬‏⁮⁫‭‫⁬⁯‮⁪⁪⁫⁪‍‏​‏‫⁭⁭‌‮‍⁫‌‍⁭⁭‫‌‬‮(current.MeetingId, string.Empty) ? 1 : 0;
              goto label_29;
            case 4:
              num2 = (int) num4 * 2022456170 ^ 1218026435;
              continue;
            case 6:
              num2 = 1224102358;
              continue;
            case 7:
              list.Remove(current.MeetingId);
              num2 = (int) num4 * 474790220 ^ 443632022;
              continue;
            case 8:
              num2 = 1463849063;
              continue;
            case 9:
              list.Add(current.MeetingId);
              num2 = (int) num4 * -1286877286 ^ 766412711;
              continue;
            case 10:
              goto label_18;
            case 11:
              current = enumerator.Current;
              num2 = 1988890963;
              continue;
            case 12:
              num6 = current.MeetingStatus == MeetingStatus.Invalid ? 1 : 0;
              break;
            case 13:
              if (current.MeetingStatus != MeetingStatus.Invalid)
              {
                num2 = (int) num4 * -199181625 ^ 525958916;
                continue;
              }
              goto label_28;
            case 14:
              num2 = (int) num4 * -796693553 ^ -875900632;
              continue;
            case 15:
              if (list.Contains(current.MeetingId))
              {
                num2 = (int) num4 * 1141672741 ^ -763812293;
                continue;
              }
              num6 = 0;
              break;
            default:
              goto label_39;
          }
          int num7;
          num2 = num7 = num6 == 0 ? 1882776444 : (num7 = 1147060744);
          continue;
label_28:
          num5 = 0;
label_29:
          int num8;
          num2 = num8 = num5 != 0 ? 195317214 : (num8 = 61711850);
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_34:
          int num2 = 1833523261;
          while (true)
          {
            int num3 = 1941035740;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Engine.\u202C​‮⁯‍‮⁭⁯​‮⁯‎‭⁯‫‍‫‮⁫⁫⁫​‍⁪‍‫⁪‫‭‪‍‎‏‭⁯‪⁮‭​⁭‮((IDisposable) enumerator);
                num2 = (int) num4 * 2116038435 ^ -1634146891;
                continue;
              case 2:
                num2 = (int) num4 * -1738171654 ^ 714632832;
                continue;
              case 3:
                goto label_34;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
label_39:
      CoreUtils.DeleteFile(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(307023589U));
      // ISSUE: reference to a compiler-generated method
      list.RemoveAll((Predicate<string>) (m => Engine.\u003C\u003Ec.\u206B‭⁬⁮‏⁯‭‍‮​‏‌⁫⁫‭‮‌​​‌‎⁪‪⁫​⁫⁮‍‭‫‬‪‍‮‌‬‍⁯⁬‏‮(m)));
      Engine.\u200D⁪‎‎‭⁪⁬‫​‫‫‎⁯‮‫‌⁮⁪⁮‭‌⁮‮‬⁪⁭‍‌⁯‭‪‮‏​‏‌‏‮‬‬‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1474473424U), list.ToArray());
    }

    internal void RemoveButton(ZoomButton button)
    {
label_1:
      int num1 = 1915350642;
      ZoomMeeting zoomMeeting;
      while (true)
      {
        int num2 = 1420459532;
        uint num3;
        bool autoGenerated;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            int num4 = !autoGenerated ? -1688472237 : (num4 = -905704868);
            int num5 = (int) num3 * -312044611;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_17;
          case 3:
            goto label_1;
          case 4:
            autoGenerated = button.AutoGenerated;
            num1 = (int) num3 * -234004399 ^ -1235414282;
            continue;
          case 5:
            zoomMeeting = (ZoomMeeting) null;
            num1 = 1760201885;
            continue;
          default:
            goto label_6;
        }
      }
label_17:
      return;
label_6:
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_8:
        int num2 = 751992154;
        while (true)
        {
          int num3 = 1420459532;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              ((Collection<ZoomButton>) this.Buttons).Remove(button);
              num2 = (int) num4 * -337500220 ^ 1918459641;
              continue;
            case 2:
              goto label_8;
            case 3:
              zoomMeeting = this.ActiveMeeting;
              num2 = (int) num4 * 1437711506 ^ -613194863;
              continue;
            case 4:
              num2 = (int) num4 * 1677191349 ^ 254363386;
              continue;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_15:
          int num2 = 300682443;
          while (true)
          {
            int num3 = 1420459532;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_15;
              case 2:
                num2 = (int) num4 * 1936493734 ^ 297303717;
                continue;
              case 3:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -60955093 ^ -256907321;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:
      bool flag2 = zoomMeeting != null;
label_22:
      int num6 = 438504023;
      while (true)
      {
        int num2 = 1420459532;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 6U)
        {
          case 0:
            zoomMeeting.RemoveButton(button);
            num6 = (int) num3 * 363687654 ^ 489539698;
            continue;
          case 1:
            goto label_24;
          case 2:
            num6 = (int) num3 * 1180892928 ^ 2054976619;
            continue;
          case 3:
            goto label_22;
          case 4:
            num6 = (int) num3 * 411793231 ^ 55563334;
            continue;
          case 5:
            int num4 = !flag2 ? 962455016 : (num4 = 1850423031);
            int num5 = (int) num3 * -2042177543;
            num6 = num4 ^ num5;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_24:;
    }

    internal List<ZoomButton> GetButtons(string meetingId)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass330_0 displayClass3300 = new Engine.\u003C\u003Ec__DisplayClass330_0();
label_1:
      int num1 = 1965034910;
      List<ZoomButton> zoomButtonList1;
      while (true)
      {
        int num2 = 1514927223;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * 1480042265 ^ 1915424464;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass3300.meetingId = meetingId;
            num1 = (int) num3 * -1875606332 ^ -1308028226;
            continue;
          case 2:
            goto label_1;
          case 3:
            zoomButtonList1 = new List<ZoomButton>();
            num1 = (int) num3 * -24725161 ^ 1922409886;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_8:
        int num2 = 84345618;
        List<ZoomButton> list;
        while (true)
        {
          int num3 = 1514927223;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_8;
            case 1:
              // ISSUE: method pointer
              list = ((IEnumerable<ZoomButton>) Enumerable.Where<ZoomButton>((IEnumerable<M0>) this.Buttons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) displayClass3300, __methodptr(\u003CGetButtons\u003Eb__0)))).ToList<ZoomButton>();
              num2 = (int) num4 * 237704097 ^ -778852675;
              continue;
            case 3:
              num2 = (int) num4 * -1536995702 ^ -444684561;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        List<ZoomButton>.Enumerator enumerator = list.GetEnumerator();
        try
        {
label_18:
          int num3 = enumerator.MoveNext() ? 1363463497 : (num3 = 1053305938);
          while (true)
          {
            int num4 = 1514927223;
            uint num5;
            ZoomButton current;
            switch ((num5 = (uint) (num3 ^ num4)) % 7U)
            {
              case 0:
                num3 = (int) num5 * 461823957 ^ -397105119;
                continue;
              case 1:
                zoomButtonList1.Add(current);
                num3 = (int) num5 * -1992373581 ^ -1916460246;
                continue;
              case 2:
                current = enumerator.Current;
                num3 = 1726481509;
                continue;
              case 4:
                goto label_18;
              case 5:
                num3 = 1363463497;
                continue;
              case 6:
                num3 = (int) num5 * -540670266 ^ 163771247;
                continue;
              default:
                goto label_32;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
label_22:
          int num3 = 1028343152;
          while (true)
          {
            int num4 = 1514927223;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 3U)
            {
              case 0:
                goto label_22;
              case 2:
                num3 = (int) num5 * 107855453 ^ 467321376;
                continue;
              default:
                goto label_25;
            }
          }
label_25:;
        }
      }
      finally
      {
        if (flag)
        {
label_27:
          int num2 = 486093638;
          while (true)
          {
            int num3 = 1514927223;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -1120935488 ^ -1516614652;
                continue;
              case 2:
                goto label_27;
              case 3:
                num2 = (int) num4 * -1075420043 ^ 223935544;
                continue;
              default:
                goto label_31;
            }
          }
        }
label_31:;
      }
label_32:
      List<ZoomButton> zoomButtonList2 = zoomButtonList1;
label_33:
      int num6 = 2009976172;
      while (true)
      {
        int num2 = 1514927223;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 3U)
        {
          case 0:
            goto label_33;
          case 2:
            num6 = (int) num3 * 192492856 ^ -1476624324;
            continue;
          default:
            goto label_36;
        }
      }
label_36:
      return zoomButtonList2;
    }

    public bool AddPattern(LayoutPattern pattern, bool setActive = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass334_0 displayClass3340 = new Engine.\u003C\u003Ec__DisplayClass334_0();
label_1:
      int num1 = 929633327;
      while (true)
      {
        int num2 = 490656234;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass3340.pattern = pattern;
            num1 = (int) num3 * -934605502 ^ 1685814446;
            continue;
          case 2:
            num1 = (int) num3 * -2092143442 ^ 1233403350;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag1 = false;
      bool flag2 = false;
      object engineLock = Engine.engineLock;
      bool flag3 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag3);
label_7:
        int num2 = 1549714174;
        while (true)
        {
          int num3 = 490656234;
          uint num4;
          LayoutPattern layoutPattern;
          bool flag4;
          switch ((num4 = (uint) (num2 ^ num3)) % 11U)
          {
            case 0:
              num2 = (int) num4 * 1574577957 ^ -753653164;
              continue;
            case 1:
              num2 = (int) num4 * 240856923 ^ -742260372;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              ((Collection<LayoutPattern>) this.Patterns).Add(displayClass3340.pattern);
              num2 = (int) num4 * 953192373 ^ -1716904803;
              continue;
            case 4:
              int num5 = flag4 ? 402517006 : (num5 = 1561588795);
              int num6 = (int) num4 * -2097621198;
              num2 = num5 ^ num6;
              continue;
            case 5:
              num2 = 727968495;
              continue;
            case 6:
              flag2 = true;
              num2 = (int) num4 * -340723489 ^ -333464433;
              continue;
            case 7:
              // ISSUE: method pointer
              layoutPattern = (LayoutPattern) Enumerable.FirstOrDefault<LayoutPattern>((IEnumerable<M0>) this.Patterns, (Func<M0, bool>) new Func<LayoutPattern, bool>((object) displayClass3340, __methodptr(\u003CAddPattern\u003Eb__0)));
              num2 = (int) num4 * -731779053 ^ -1574479705;
              continue;
            case 8:
              flag4 = layoutPattern == null;
              num2 = (int) num4 * -1748333684 ^ 807469076;
              continue;
            case 9:
              num2 = (int) num4 * 2001076801 ^ 890044247;
              continue;
            case 10:
              goto label_7;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_19:
          int num2 = 1731183919;
          while (true)
          {
            int num3 = 490656234;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_19;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -1593932236 ^ 1962854164;
                continue;
              case 2:
                num2 = (int) num4 * 1652865148 ^ 35381117;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:
      if (!flag2)
        goto label_32;
label_25:
      int num7 = 695170307;
label_26:
      while (true)
      {
        int num2 = 490656234;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 13U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            this.ActivePattern = displayClass3340.pattern;
            num7 = (int) num3 * 1478171610 ^ 1585370247;
            continue;
          case 1:
            num7 = (int) num3 * -786043550 ^ 1263156321;
            continue;
          case 2:
            num7 = (int) num3 * 1133349618 ^ 652574559;
            continue;
          case 4:
            goto label_25;
          case 5:
            num7 = (int) num3 * -216008304 ^ -1752806158;
            continue;
          case 6:
            num7 = (int) num3 * 638383435 ^ -546871647;
            continue;
          case 7:
            // ISSUE: type reference
            // ISSUE: reference to a compiler-generated field
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
            {
              ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (LayoutPattern)),
              ChangeType = ChangeType.Added,
              ChangedObject = (object) displayClass3340.pattern
            });
            num7 = (int) num3 * 348408410 ^ -356504912;
            continue;
          case 8:
            goto label_32;
          case 9:
            num7 = (int) num3 * 1710372117 ^ 1844247558;
            continue;
          case 10:
            flag1 = true;
            num7 = 1407020081;
            continue;
          case 11:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3555768355U));
            num7 = (int) num3 * -2034798704 ^ -1759385426;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            int num4 = !Engine.\u200E‌⁯‭‌⁫‫⁫‏⁬‏⁮⁫‭‫⁬⁯‮⁪⁪⁫⁪‍‏​‏‫⁭⁭‌‮‍⁫‌‍⁭⁭‫‌‬‮(displayClass3340.pattern.PatternName, this.Settings.LastActivePatternName) ? 2140389797 : (num4 = 151322006);
            int num5 = (int) num3 * 1078153758;
            num7 = num4 ^ num5;
            continue;
          default:
            goto label_38;
        }
      }
label_38:
      bool flag5;
      return flag5;
label_32:
      flag5 = flag1;
      num7 = 1424139757;
      goto label_26;
    }

    internal void RemovePattern(LayoutPattern remove)
    {
      if (!((Collection<LayoutPattern>) this.Patterns).Contains(remove))
        return;
label_1:
      int num1 = 555875237;
      while (true)
      {
        int num2 = 253046628;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 1435716197 ^ -818921832;
            continue;
          case 1:
            num1 = (int) num3 * 1620181453 ^ -908007770;
            continue;
          case 2:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1408993374U));
            num1 = (int) num3 * -736277407 ^ 1045628660;
            continue;
          case 3:
            // ISSUE: type reference
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
            {
              ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (LayoutPattern)),
              ChangeType = ChangeType.Removed,
              ChangedObject = (object) Engine.activePattern
            });
            num1 = (int) num3 * 887246008 ^ 1508813215;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_9;
          case 6:
            ((Collection<LayoutPattern>) this.Patterns).Remove(remove);
            num1 = (int) num3 * -599326684 ^ -1859344075;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_9:;
    }

    internal LayoutPattern GetPattern(string patternName)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass336_0 displayClass3360 = new Engine.\u003C\u003Ec__DisplayClass336_0();
label_1:
      int num1 = 487137275;
      object engineLock;
      LayoutPattern layoutPattern1;
      while (true)
      {
        int num2 = 1120876182;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 2:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 917006665 ^ -1973977901;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            displayClass3360.patternName = patternName;
            num1 = (int) num3 * -673179609 ^ -4790158;
            continue;
          case 4:
            layoutPattern1 = (LayoutPattern) null;
            num1 = (int) num3 * 1030606880 ^ -1786159483;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_8:
        int num2 = 927654254;
        while (true)
        {
          int num3 = 1120876182;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 1:
              // ISSUE: method pointer
              layoutPattern1 = (LayoutPattern) Enumerable.FirstOrDefault<LayoutPattern>((IEnumerable<M0>) this.Patterns, (Func<M0, bool>) new Func<LayoutPattern, bool>((object) displayClass3360, __methodptr(\u003CGetPattern\u003Eb__0)));
              num2 = (int) num4 * -66026617 ^ -1557583920;
              continue;
            case 2:
              num2 = (int) num4 * 428164585 ^ 32647482;
              continue;
            case 3:
              num2 = (int) num4 * -1150393710 ^ 849142873;
              continue;
            case 4:
              goto label_8;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_14:
          int num2 = 1185592017;
          while (true)
          {
            int num3 = 1120876182;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_14;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -533925713 ^ 376903335;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      LayoutPattern layoutPattern2 = layoutPattern1;
label_19:
      int num5 = 1950614434;
      while (true)
      {
        int num2 = 1120876182;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 1:
            num5 = (int) num3 * 1765523839 ^ -1621203808;
            continue;
          case 2:
            goto label_19;
          default:
            goto label_22;
        }
      }
label_22:
      return layoutPattern2;
    }

    internal void AddImage(ZoomImage image)
    {
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
        int num1 = -867298157;
        while (true)
        {
          int num2 = -1523670344;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1959506982 ^ 1856590050;
              continue;
            case 1:
              int num4 = ((Collection<ZoomImage>) this.Images).Contains(image) ? 1507391806 : (num4 = 2019033547);
              int num5 = (int) num3 * -1343256726;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * 39499628 ^ -1027201498;
              continue;
            case 3:
              goto label_2;
            case 4:
              num1 = (int) num3 * 501333068 ^ -535558976;
              continue;
            case 5:
              ((Collection<ZoomImage>) this.Images).Add(image);
              num1 = (int) num3 * 1685151244 ^ -981224184;
              continue;
            case 6:
              goto label_13;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_13:;
      }
      finally
      {
        if (flag)
        {
label_11:
          int num1 = -1881222975;
          while (true)
          {
            int num2 = -1523670344;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 100115394 ^ -777692534;
                continue;
              case 2:
                goto label_11;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    internal void AddImage(ImageCapture capture)
    {
label_1:
      int num1 = -1836192828;
      ZoomImage image;
      object engineLock;
      while (true)
      {
        int num2 = -1291810906;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            if (flag)
            {
              num1 = (int) num3 * -676497169 ^ 55791359;
              continue;
            }
            goto label_23;
          case 1:
            num1 = (int) num3 * -2039794491 ^ 1744293815;
            continue;
          case 2:
            if (capture == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 195326818 ^ -1249249179;
            continue;
          case 3:
            goto label_1;
          case 4:
            image = capture.Image;
            num1 = (int) num3 * 1041531853 ^ -462012316;
            continue;
          case 6:
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 1890278005 ^ 599078157;
            continue;
          case 7:
            num4 = capture.Image != null ? 1 : 0;
            break;
          default:
            goto label_13;
        }
        flag = num4 != 0;
        num1 = -394457234;
      }
label_23:
      return;
label_13:
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_15:
        int num2 = -1286351382;
        while (true)
        {
          int num3 = -1291810906;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_15;
            case 1:
              int num5 = ((Collection<ZoomImage>) this.Images).Contains(image) ? 1532126137 : (num5 = 804901883);
              int num6 = (int) num4 * -1551676748;
              num2 = num5 ^ num6;
              continue;
            case 2:
              ((Collection<ZoomImage>) this.Images).Add(image);
              num2 = (int) num4 * -418784068 ^ 194985925;
              continue;
            case 4:
              num2 = -2061357655;
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
label_21:
          int num2 = -19891001;
          while (true)
          {
            int num3 = -1291810906;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -1241225989 ^ 483941194;
                continue;
              case 2:
                goto label_21;
              case 3:
                num2 = (int) num4 * -2118032595 ^ -944215807;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
label_27:;
    }

    internal void RemoveImage(ZoomImage selectedImage)
    {
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_2:
        int num1 = -103159595;
        while (true)
        {
          int num2 = -1123061775;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = -1058880205;
              continue;
            case 3:
              int num4 = flag2 ? -1676600242 : (num4 = -228094910);
              int num5 = (int) num3 * 542186310;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * -48305434 ^ -494979881;
              continue;
            case 5:
              ((Collection<ZoomImage>) this.Images).Remove(selectedImage);
              num1 = (int) num3 * 2068248271 ^ -1188639643;
              continue;
            case 6:
              flag2 = ((Collection<ZoomImage>) this.Images).Contains(selectedImage);
              num1 = (int) num3 * -2022424828 ^ 391931762;
              continue;
            case 7:
              num1 = (int) num3 * 54321053 ^ 1770116939;
              continue;
            default:
              goto label_16;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_11:
          int num1 = -761406154;
          while (true)
          {
            int num2 = -1123061775;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_11;
              case 1:
                num1 = (int) num3 * 332569061 ^ -14475646;
                continue;
              case 3:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 1228824979 ^ 112808269;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_16:
      this.ZoomZoomDatabase.DeleteObject(ObjectDataTable.Images, selectedImage.GetDataDictionary());
    }

    internal void SaveImage(ZoomImage image)
    {
label_1:
      int num1 = -672527247;
      while (true)
      {
        int num2 = -1862897684;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            this.AddImage(image);
            num1 = (int) num3 * 938659182 ^ -1073996910;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      image.SaveDatabaseObject();
    }

    internal ZoomImage CaptureImage(ZoomWindow window, Rectangle region, ImageEnums.ImageType imageType, ImageOptions options = null)
    {
      ZoomImage zoomImage1 = (ZoomImage) null;
      try
      {
        ImageCapture imageCapture = (ImageCapture) null;
label_2:
        int num1 = -462767698;
        while (true)
        {
          int num2 = -1599403696;
          uint num3;
          bool flag1;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              num1 = (int) num3 * -787450160 ^ 284623984;
              continue;
            case 2:
              flag1 = window != null;
              num1 = (int) num3 * -473234378 ^ -1930433139;
              continue;
            case 3:
              zoomImage1.ImageType = imageType;
              num1 = (int) num3 * 687305362 ^ -1449586376;
              continue;
            case 4:
              zoomImage1 = imageCapture.Image;
              num1 = (int) num3 * -470668075 ^ -2052916731;
              continue;
            case 5:
              imageCapture = new ImageCapture(window, region, imageType, options);
              flag2 = imageCapture.Capture() == CaptureState.Captured;
              num1 = -110294617;
              continue;
            case 6:
              ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<ImageCapturedEvent>()).Publish(zoomImage1);
              num1 = (int) num3 * 462182144 ^ -274468694;
              continue;
            case 7:
              int num4 = flag2 ? -1518542014 : (num4 = -2100538549);
              int num5 = (int) num3 * 668864029;
              num1 = num4 ^ num5;
              continue;
            case 8:
              int num6 = !flag1 ? 2012041685 : (num6 = 1810088018);
              int num7 = (int) num3 * 1581981075;
              num1 = num6 ^ num7;
              continue;
            case 9:
              zoomImage1.SaveDatabaseObject();
              num1 = (int) num3 * -1757257001 ^ -778323792;
              continue;
            case 10:
              WindowHelper.ForceForeground(window.Handle);
              num1 = (int) num3 * -1492269323 ^ -386421565;
              continue;
            case 11:
              goto label_2;
            case 12:
              num1 = (int) num3 * 587520822 ^ 1351659734;
              continue;
            default:
              goto label_20;
          }
        }
      }
      catch (Exception ex)
      {
label_16:
        int num1 = -1033118268;
        while (true)
        {
          int num2 = -1599403696;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_16;
            case 2:
              num1 = (int) num3 * 641473420 ^ -1404375913;
              continue;
            default:
              goto label_19;
          }
        }
label_19:
        Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
      }
label_20:
      ZoomImage zoomImage2 = zoomImage1;
label_21:
      int num8 = -398802692;
      while (true)
      {
        int num1 = -1599403696;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 0:
            goto label_21;
          case 2:
            num8 = (int) num2 * 546500381 ^ 714838675;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      return zoomImage2;
    }

    internal void DisplayImage(ZoomImage image)
    {
label_1:
      int num1 = -1866394263;
      while (true)
      {
        int num2 = -2086678387;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<ImageDisplayEvent>()).Publish(image);
            num1 = (int) num3 * -250680455 ^ 1652140978;
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

    internal void DisplayImages(List<ZoomImage> images)
    {
      ((CompositePresentationEvent<List<ZoomImage>>) this._eventAggregator.GetEvent<ImagesDisplayEvent>()).Publish(images);
label_1:
      int num1 = 2096330549;
      while (true)
      {
        int num2 = 1658017824;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -828892930 ^ -840223492;
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

    internal BitmapImage GetImageBitmapImage(long uri)
    {
      string sSQL = Engine.\u206F⁮⁫‭‮‍‪⁬⁮‬​‌‎⁬​​⁯​⁪⁯​‫‫⁯‫⁫‬​‭⁪⁮‎‪⁬⁫‭​‭‭‮((object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1319880044U), (object) uri);
label_1:
      int num1 = -801995943;
      BitmapImage bitmapImage;
      while (true)
      {
        int num2 = -1598320233;
        uint num3;
        byte[] sqlScalarBytes;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * 1978269574 ^ 1131556256;
            continue;
          case 1:
            int num4 = !flag ? 529824284 : (num4 = 1108711387);
            int num5 = (int) num3 * -708993801;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_1;
          case 3:
            bitmapImage = ZoomImage.ByteToBitmapImage(sqlScalarBytes);
            num1 = (int) num3 * -625386870 ^ -74514367;
            continue;
          case 4:
            bitmapImage = (BitmapImage) null;
            num1 = -38265296;
            continue;
          case 5:
            flag = sqlScalarBytes != null;
            num1 = (int) num3 * -1454750150 ^ 1834148356;
            continue;
          case 6:
            sqlScalarBytes = this.ZoomZoomDatabase.GetSQLScalar_Bytes(sSQL);
            num1 = (int) num3 * -2073323090 ^ -2078451154;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return bitmapImage;
    }

    private void LoadMessageCategories()
    {
label_1:
      int num1 = -601396102;
      while (true)
      {
        int num2 = -2017183401;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            this.RaiseEvent(EngineEvent.LoadingData, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2891076288U));
            num1 = (int) num3 * 366610663 ^ -1093680425;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        ((Collection<MessageCategory>) this.MessageCategories).Clear();
label_6:
        int num2 = -1767359401;
        List<MessageCategory> messageCatories;
        while (true)
        {
          int num3 = -2017183401;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_6;
            case 1:
              this.Settings.StaticCategory_AutoGenerated = new MessageCategory(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3245227004U));
              num2 = (int) num4 * -1280353413 ^ -56035557;
              continue;
            case 3:
              this.Settings.StaticCategory_AutoGenerated.AutoGenerated = true;
              num2 = (int) num4 * -511355251 ^ 757712485;
              continue;
            case 4:
              num2 = (int) num4 * 1423933116 ^ -82994460;
              continue;
            case 5:
              this.AddMessageCategory(Engine.settings.StaticCategory_AutoGenerated);
              messageCatories = this.ZoomZoomDatabase.GetMessageCatories();
              num2 = (int) num4 * -324445549 ^ -1204223492;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        List<MessageCategory>.Enumerator enumerator = messageCatories.GetEnumerator();
        try
        {
label_18:
          int num3 = !enumerator.MoveNext() ? -1189321839 : (num3 = -1466630244);
          while (true)
          {
            int num4 = -2017183401;
            uint num5;
            MessageCategory current;
            switch ((num5 = (uint) (num3 ^ num4)) % 6U)
            {
              case 0:
                num3 = -1466630244;
                continue;
              case 1:
                goto label_18;
              case 3:
                current = enumerator.Current;
                num3 = -23890431;
                continue;
              case 4:
                this.AddMessageCategory(current);
                num3 = (int) num5 * 801706048 ^ 726162122;
                continue;
              case 5:
                num3 = (int) num5 * 1937269269 ^ 536464993;
                continue;
              default:
                goto label_25;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
label_21:
          int num3 = -1548557219;
          while (true)
          {
            int num4 = -2017183401;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 3U)
            {
              case 1:
                num3 = (int) num5 * -1930843645 ^ -1964015711;
                continue;
              case 2:
                goto label_21;
              default:
                goto label_24;
            }
          }
label_24:;
        }
label_25:
        MessageCategory category = this.GetMessageCategory(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3566233215U), false);
label_26:
        int num6 = -1285967533;
        while (true)
        {
          int num3 = -2017183401;
          uint num4;
          bool flag;
          switch ((num4 = (uint) (num6 ^ num3)) % 10U)
          {
            case 0:
              num6 = (int) num4 * 921435423 ^ 279804538;
              continue;
            case 1:
              goto label_44;
            case 2:
              goto label_26;
            case 3:
              int num5 = !flag ? -1143643508 : (num5 = -294576354);
              int num7 = (int) num4 * -421002406;
              num6 = num5 ^ num7;
              continue;
            case 4:
              flag = category == null;
              num6 = (int) num4 * -1213765003 ^ 571181130;
              continue;
            case 5:
              num6 = (int) num4 * 1734127570 ^ -2089741755;
              continue;
            case 6:
              category = new MessageCategory(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3912284707U));
              num6 = (int) num4 * -1729733234 ^ -372608850;
              continue;
            case 7:
              category.SaveDatabaseObject();
              num6 = (int) num4 * -1030844258 ^ -135265077;
              continue;
            case 8:
              this.AddMessageCategory(category);
              num6 = (int) num4 * -1279211262 ^ 1050423927;
              continue;
            case 9:
              num6 = -188470518;
              continue;
            default:
              goto label_41;
          }
        }
label_41:
        return;
label_44:;
      }
      catch (Exception ex)
      {
label_39:
        int num2 = -136431350;
        while (true)
        {
          int num3 = -2017183401;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_39;
            case 1:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num2 = (int) num4 * -1438926524 ^ -33691547;
              continue;
            case 2:
              num2 = (int) num4 * 1866138791 ^ 361783482;
              continue;
            case 3:
              goto label_37;
            default:
              goto label_28;
          }
        }
label_28:
        return;
label_37:;
      }
    }

    private void LoadMessageContents()
    {
      this.RaiseEvent(EngineEvent.LoadingData, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(984846596U));
      try
      {
label_2:
        int num1 = 42222961;
        while (true)
        {
          int num2 = 701067811;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              this.Settings.RandomTextContent.AutoGenerated = true;
              num1 = (int) num3 * 958838677 ^ -1706753449;
              continue;
            case 1:
              num1 = (int) num3 * 1051423194 ^ -2102538947;
              continue;
            case 2:
              this.Settings.PreviousChatContent.AutoGenerated = true;
              num1 = (int) num3 * 1086877081 ^ -1649145933;
              continue;
            case 3:
              num1 = (int) num3 * 2032696264 ^ 727007934;
              continue;
            case 4:
              num1 = (int) num3 * -1564224973 ^ 1106568844;
              continue;
            case 5:
              this.Settings.DateTimeContent.AutoGenerated = true;
              num1 = (int) num3 * 873338743 ^ -1234915756;
              continue;
            case 6:
              this.Settings.DateTimeContent = new MessageContent(this.Settings.StaticCategory_AutoGenerated, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3318039925U));
              num1 = (int) num3 * 2039880809 ^ 544404387;
              continue;
            case 7:
              Settings settings1 = this.Settings;
              MessageContent messageContent1 = new MessageContent(this.Settings.StaticCategory_AutoGenerated, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2934774063U));
              int num4 = 1;
              messageContent1.AutoGenerated = num4 != 0;
              settings1.RandomTextContent = messageContent1;
              num1 = (int) num3 * 1453048947 ^ 920782381;
              continue;
            case 8:
              goto label_2;
            case 9:
              this.Settings.GuidContent.AutoGenerated = true;
              num1 = (int) num3 * -1495016519 ^ -986713277;
              continue;
            case 11:
              Settings settings2 = this.Settings;
              MessageContent messageContent2 = new MessageContent(this.Settings.StaticCategory_AutoGenerated, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4040592947U));
              int num5 = 1;
              messageContent2.AutoGenerated = num5 != 0;
              settings2.PreviousChatContent = messageContent2;
              num1 = (int) num3 * -1281219827 ^ -1884645997;
              continue;
            case 12:
              Settings settings3 = this.Settings;
              MessageContent messageContent3 = new MessageContent(this.Settings.StaticCategory_AutoGenerated, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2051846353U));
              int num6 = 1;
              messageContent3.AutoGenerated = num6 != 0;
              settings3.GuidContent = messageContent3;
              num1 = (int) num3 * -179448056 ^ 915836365;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        object engineLock1 = Engine.engineLock;
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock1, ref flag1);
label_17:
          int num2 = 1040352684;
          while (true)
          {
            int num3 = 701067811;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 10U)
            {
              case 1:
                num2 = (int) num4 * 265538973 ^ 1782514870;
                continue;
              case 2:
                ((Collection<MessageContent>) this.MessageContents).Add(this.Settings.DateTimeContent);
                num2 = (int) num4 * 1724335615 ^ -703143777;
                continue;
              case 3:
                goto label_17;
              case 4:
                num2 = (int) num4 * -1004244765 ^ 782737345;
                continue;
              case 5:
                ((Collection<MessageContent>) this.MessageContents).Add(this.Settings.PreviousChatContent);
                num2 = (int) num4 * 740299700 ^ -913770228;
                continue;
              case 6:
                ((Collection<MessageContent>) this.MessageContents).Add(this.Settings.GuidContent);
                ((Collection<MessageContent>) this.MessageContents).Add(this.Settings.RandomTextContent);
                num2 = (int) num4 * 449568041 ^ 1140986532;
                continue;
              case 7:
                num2 = (int) num4 * 539567062 ^ -1052813015;
                continue;
              case 8:
                num2 = (int) num4 * 681369108 ^ 1362701426;
                continue;
              case 9:
                ((Collection<MessageContent>) this.MessageContents).Clear();
                num2 = (int) num4 * -2074007091 ^ 231321942;
                continue;
              default:
                goto label_33;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_28:
            int num2 = 1906790102;
            while (true)
            {
              int num3 = 701067811;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_28;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock1);
                  num2 = (int) num4 * 658587884 ^ -1895890056;
                  continue;
                case 3:
                  num2 = (int) num4 * -1235686156 ^ 314542433;
                  continue;
                default:
                  goto label_32;
              }
            }
          }
label_32:;
        }
label_33:
        List<MessageContent> messageContentList = new List<MessageContent>();
        IEnumerator<MessageCategory> enumerator1 = ((Collection<MessageCategory>) this.MessageCategories).GetEnumerator();
        try
        {
label_40:
          int num2 = Engine.\u202D‏⁫‎‭‎‏⁭‏‫‬‮⁭‌‏⁮‏‌⁯⁮‌‭‌‬⁫⁬‍‬‏​‍‮‬⁪‬‫⁮‍‪‮((IEnumerator) enumerator1) ? 173889984 : (num2 = 1467403757);
          while (true)
          {
            int num3 = 701067811;
            uint num4;
            MessageCategory current;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 1:
                messageContentList.AddRange((IEnumerable<MessageContent>) this.ZoomZoomDatabase.GetMessageContents(current.Uri));
                num2 = (int) num4 * -269603281 ^ -1027481964;
                continue;
              case 2:
                num2 = (int) num4 * -2019802415 ^ -1678745335;
                continue;
              case 3:
                current = enumerator1.Current;
                num2 = 1877509532;
                continue;
              case 4:
                goto label_40;
              case 5:
                num2 = 173889984;
                continue;
              default:
                goto label_47;
            }
          }
        }
        finally
        {
          if (enumerator1 != null)
          {
label_42:
            int num2 = 16571126;
            while (true)
            {
              int num3 = 701067811;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  num2 = (int) num4 * 533237440 ^ 1341965553;
                  continue;
                case 1:
                  Engine.\u202C​‮⁯‍‮⁭⁯​‮⁯‎‭⁯‫‍‫‮⁫⁫⁫​‍⁪‍‫⁪‫‭‪‍‎‏‭⁯‪⁮‭​⁭‮((IDisposable) enumerator1);
                  num2 = (int) num4 * -939108321 ^ -855744532;
                  continue;
                case 3:
                  goto label_42;
                default:
                  goto label_46;
              }
            }
          }
label_46:;
        }
label_47:
        object engineLock2 = Engine.engineLock;
        bool flag2 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock2, ref flag2);
label_49:
          int num2 = 1536672137;
          while (true)
          {
            int num3 = 701067811;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_49;
              case 2:
                num2 = (int) num4 * 1772621257 ^ 569844800;
                continue;
              default:
                goto label_52;
            }
          }
label_52:
          List<MessageContent>.Enumerator enumerator2 = messageContentList.GetEnumerator();
          try
          {
label_64:
            int num3 = !enumerator2.MoveNext() ? 1567096829 : (num3 = 1622292244);
            while (true)
            {
              int num4 = 701067811;
              uint num5;
              MessageContent current;
              switch ((num5 = (uint) (num3 ^ num4)) % 11U)
              {
                case 0:
                  goto label_64;
                case 1:
                  ((Collection<MessageContent>) this.MessageContents).Add(current);
                  num3 = (int) num5 * -341333412 ^ 197120625;
                  continue;
                case 2:
                  int num6 = ((Collection<MessageContent>) this.MessageContents).Contains(current) ? -738643915 : (num6 = -834101221);
                  int num7 = (int) num5 * 332916486;
                  num3 = num6 ^ num7;
                  continue;
                case 3:
                  num3 = (int) num5 * 68301336 ^ -466127102;
                  continue;
                case 4:
                  num3 = (int) num5 * -712947475 ^ 1924939711;
                  continue;
                case 5:
                  num3 = (int) num5 * -636511027 ^ -2084532734;
                  continue;
                case 6:
                  num3 = 1426508496;
                  continue;
                case 7:
                  current = enumerator2.Current;
                  num3 = 1375854423;
                  continue;
                case 8:
                  goto label_84;
                case 9:
                  num3 = 1622292244;
                  continue;
                case 10:
                  num3 = (int) num5 * -492193326 ^ 466449171;
                  continue;
                default:
                  goto label_81;
              }
            }
label_81:
            return;
label_84:;
          }
          finally
          {
            enumerator2.Dispose();
label_66:
            int num3 = 1177434231;
            while (true)
            {
              int num4 = 701067811;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 3U)
              {
                case 0:
                  goto label_66;
                case 2:
                  num3 = (int) num5 * -1160429983 ^ 1051267657;
                  continue;
                default:
                  goto label_69;
              }
            }
label_69:;
          }
        }
        finally
        {
          if (flag2)
          {
label_71:
            int num2 = 1026717049;
            while (true)
            {
              int num3 = 701067811;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  num2 = (int) num4 * -944051730 ^ 1634554889;
                  continue;
                case 2:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock2);
                  num2 = (int) num4 * 1926270864 ^ 1770189162;
                  continue;
                case 3:
                  goto label_71;
                default:
                  goto label_76;
              }
            }
          }
label_76:;
        }
      }
      catch (Exception ex)
      {
        Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
label_79:
        int num1 = 1671576102;
        while (true)
        {
          int num2 = 701067811;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_77;
            case 1:
              num1 = (int) num3 * -1353078874 ^ -1589832661;
              continue;
            case 2:
              num1 = (int) num3 * -1199167201 ^ -1867994639;
              continue;
            case 3:
              goto label_79;
            default:
              goto label_73;
          }
        }
label_73:
        return;
label_77:;
      }
    }

    internal MessageCategory GetMessageCategory(long uri)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass347_0 displayClass3470 = new Engine.\u003C\u003Ec__DisplayClass347_0();
      // ISSUE: reference to a compiler-generated field
      displayClass3470.uri = uri;
label_1:
      int num1 = -546146337;
      MessageCategory messageCategory;
      object engineLock;
      while (true)
      {
        int num2 = -1650032805;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            messageCategory = (MessageCategory) null;
            engineLock = Engine.engineLock;
            num1 = (int) num3 * 1183370730 ^ -1054756376;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_6:
        int num2 = -1064029875;
        while (true)
        {
          int num3 = -1650032805;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 1:
              num2 = (int) num4 * -1477269544 ^ 1232935989;
              continue;
            case 2:
              goto label_6;
            case 3:
              num2 = (int) num4 * -352793601 ^ -884398257;
              continue;
            case 4:
              // ISSUE: method pointer
              messageCategory = (MessageCategory) Enumerable.FirstOrDefault<MessageCategory>((IEnumerable<M0>) this.MessageCategories, (Func<M0, bool>) new Func<MessageCategory, bool>((object) displayClass3470, __methodptr(\u003CGetMessageCategory\u003Eb__0)));
              num2 = (int) num4 * -1574021098 ^ 768630409;
              continue;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_12:
          int num2 = -186126790;
          while (true)
          {
            int num3 = -1650032805;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_12;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -229684430 ^ -367146709;
                continue;
              case 2:
                num2 = (int) num4 * -1508442036 ^ -1482691760;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      return messageCategory;
    }

    internal MessageCategory GetMessageCategory(string categoryName, bool createIfNotFound = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass348_0 displayClass3480 = new Engine.\u003C\u003Ec__DisplayClass348_0();
label_1:
      int num1 = 727600159;
      MessageCategory messageCategory1;
      object engineLock;
      while (true)
      {
        int num2 = 331189628;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            displayClass3480.categoryName = categoryName;
            messageCategory1 = (MessageCategory) null;
            engineLock = Engine.engineLock;
            num1 = (int) num3 * -376688056 ^ 670994455;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_6:
        int num2 = 2077251709;
        while (true)
        {
          int num3 = 331189628;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              // ISSUE: method pointer
              messageCategory1 = (MessageCategory) Enumerable.FirstOrDefault<MessageCategory>((IEnumerable<M0>) this.MessageCategories, (Func<M0, bool>) new Func<MessageCategory, bool>((object) displayClass3480, __methodptr(\u003CGetMessageCategory\u003Eb__0)));
              num2 = (int) num4 * 1483527054 ^ -336616384;
              continue;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_10:
          int num2 = 231273227;
          while (true)
          {
            int num3 = 331189628;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_10;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -1162826856 ^ -1317866800;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_14:
      bool flag2 = messageCategory1 == null & createIfNotFound;
label_15:
      int num5 = 1556406205;
      MessageCategory messageCategory2;
      while (true)
      {
        int num2 = 331189628;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 8U)
        {
          case 0:
            goto label_15;
          case 1:
            int num4 = !flag2 ? 15444908 : (num4 = 1876965069);
            int num6 = (int) num3 * -1463678741;
            num5 = num4 ^ num6;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            messageCategory1 = new MessageCategory(displayClass3480.categoryName);
            messageCategory1.SaveDatabaseObject();
            num5 = (int) num3 * 814007512 ^ -1399454848;
            continue;
          case 3:
            messageCategory2 = messageCategory1;
            num5 = 1920085691;
            continue;
          case 4:
            ((Collection<MessageCategory>) this.MessageCategories).Add(messageCategory1);
            num5 = (int) num3 * -71587205 ^ -287606651;
            continue;
          case 5:
            num5 = (int) num3 * -1875926253 ^ 943040485;
            continue;
          case 6:
            num5 = (int) num3 * 2136922373 ^ -265176047;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return messageCategory2;
    }

    internal MessageContent GetMessageContent(long uri)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass349_0 displayClass3490 = new Engine.\u003C\u003Ec__DisplayClass349_0();
label_1:
      int num1 = -746279104;
      MessageContent messageContent;
      object engineLock;
      while (true)
      {
        int num2 = -1841015226;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            displayClass3490.uri = uri;
            num1 = (int) num3 * 419587207 ^ 1884998000;
            continue;
          case 3:
            num1 = (int) num3 * -1049606539 ^ -527461020;
            continue;
          case 4:
            messageContent = (MessageContent) null;
            engineLock = Engine.engineLock;
            num1 = (int) num3 * -1204556905 ^ 287323605;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_8:
        int num2 = -190626779;
        while (true)
        {
          int num3 = -1841015226;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_8;
            case 2:
              // ISSUE: method pointer
              messageContent = (MessageContent) Enumerable.FirstOrDefault<MessageContent>((IEnumerable<M0>) this.MessageContents, (Func<M0, bool>) new Func<MessageContent, bool>((object) displayClass3490, __methodptr(\u003CGetMessageContent\u003Eb__0)));
              num2 = (int) num4 * -1458450710 ^ -1843425977;
              continue;
            case 3:
              num2 = (int) num4 * -665607949 ^ 1068186425;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_13:
          int num2 = -1225005877;
          while (true)
          {
            int num3 = -1841015226;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -418146959 ^ 1117392129;
                continue;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * -226478307 ^ 2077937083;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      return messageContent;
    }

    internal MessageContent GetMessageContent(string contentValue)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass350_0 displayClass3500 = new Engine.\u003C\u003Ec__DisplayClass350_0();
      // ISSUE: reference to a compiler-generated field
      displayClass3500.contentValue = contentValue;
      MessageContent messageContent = (MessageContent) null;
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
        int num1 = -949578273;
        while (true)
        {
          int num2 = -1504585483;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: method pointer
              messageContent = (MessageContent) Enumerable.FirstOrDefault<MessageContent>((IEnumerable<M0>) this.MessageContents, (Func<M0, bool>) new Func<MessageContent, bool>((object) displayClass3500, __methodptr(\u003CGetMessageContent\u003Eb__0)));
              num1 = (int) num3 * -1216458775 ^ 1128608836;
              continue;
            default:
              goto label_10;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_6:
          int num1 = -1731585444;
          while (true)
          {
            int num2 = -1504585483;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_6;
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 1323824885 ^ 2115916359;
                continue;
              default:
                goto label_9;
            }
          }
        }
label_9:;
      }
label_10:
      return messageContent;
    }

    internal MessageContent GetMessageContent(MessageCategory category)
    {
label_1:
      int num1 = 761018207;
      MessageContent messageContent;
      while (true)
      {
        int num2 = 425261372;
        uint num3;
        DateTime now;
        List<MessageContent> messageContents;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -361727562 ^ 437418426;
            continue;
          case 1:
            num1 = (int) num3 * -753071205 ^ -1356184034;
            continue;
          case 3:
            Random random = new Random(now.Millisecond);
            messageContent = messageContents[random.Next(0, messageContents.Count - 1)];
            num1 = (int) num3 * 133567704 ^ 1255793150;
            continue;
          case 4:
            goto label_1;
          case 5:
            messageContents = this.GetMessageContents(category);
            now = DateTime.Now;
            num1 = (int) num3 * 1935563659 ^ 683153060;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return messageContent;
    }

    internal List<MessageContent> GetMessageContents(MessageCategory category)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003C\u003Ec__DisplayClass352_0 displayClass3520 = new Engine.\u003C\u003Ec__DisplayClass352_0();
label_1:
      int num1 = -787427613;
      List<MessageContent> messageContentList;
      while (true)
      {
        int num2 = -12406091;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            messageContentList = new List<MessageContent>();
            num1 = (int) num3 * -1935061367 ^ -667843919;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            displayClass3520.category = category;
            num1 = (int) num3 * 1550080393 ^ 687754604;
            continue;
          case 4:
            num1 = (int) num3 * 1553764267 ^ 220448228;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_8:
        int num2 = -494211337;
        while (true)
        {
          int num3 = -12406091;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              num2 = (int) num4 * -1900525006 ^ 1131385397;
              continue;
            case 1:
              num2 = (int) num4 * 1581453085 ^ -1936334358;
              continue;
            case 2:
              num2 = (int) num4 * -1982563371 ^ 245735547;
              continue;
            case 3:
              // ISSUE: method pointer
              messageContentList.AddRange((IEnumerable<MessageContent>) ((IEnumerable<MessageContent>) Enumerable.Where<MessageContent>((IEnumerable<M0>) this.MessageContents, (Func<M0, bool>) new Func<MessageContent, bool>((object) displayClass3520, __methodptr(\u003CGetMessageContents\u003Eb__0)))).ToList<MessageContent>());
              num2 = (int) num4 * -935512245 ^ 222488180;
              continue;
            case 4:
              num2 = (int) num4 * -1415366573 ^ 150611602;
              continue;
            case 6:
              goto label_8;
            default:
              goto label_20;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_16:
          int num2 = -1404452999;
          while (true)
          {
            int num3 = -12406091;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_16;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num2 = (int) num4 * 1870420345 ^ -104532697;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
label_20:
      return messageContentList;
    }

    internal List<MessageContent> GetMessageContents(string categoryName)
    {
label_1:
      int num1 = 1699657597;
      List<MessageContent> messageContentList;
      while (true)
      {
        int num2 = 1016845420;
        uint num3;
        bool flag;
        MessageCategory messageCategory;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            messageCategory = this.GetMessageCategory(categoryName, false);
            num1 = (int) num3 * 882146753 ^ -16975992;
            continue;
          case 2:
            messageContentList = this.GetMessageContents(messageCategory);
            num1 = (int) num3 * -547856490 ^ -401996154;
            continue;
          case 3:
            messageContentList = new List<MessageContent>();
            num1 = 513651451;
            continue;
          case 4:
            int num4 = !flag ? -511250709 : (num4 = -381562886);
            int num5 = (int) num3 * -1689825419;
            num1 = num4 ^ num5;
            continue;
          case 5:
            flag = messageCategory != null;
            num1 = (int) num3 * 592155573 ^ 1883039673;
            continue;
          case 6:
            num1 = (int) num3 * 609600844 ^ 388010227;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return messageContentList;
    }

    internal MessageContent AddMessageContent(MessageCategory category, string contentText)
    {
      MessageContent messageContent1 = (MessageContent) null;
      try
      {
        this.AddMessageCategory(category);
        messageContent1 = new MessageContent(category, contentText);
        object engineLock = Engine.engineLock;
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_3:
          int num1 = -1197128021;
          while (true)
          {
            int num2 = -1174547510;
            uint num3;
            bool flag2;
            switch ((num3 = (uint) (num1 ^ num2)) % 10U)
            {
              case 0:
                goto label_3;
              case 1:
                int num4 = flag2 ? -1679903998 : (num4 = -1230794067);
                int num5 = (int) num3 * 2028247987;
                num1 = num4 ^ num5;
                continue;
              case 3:
                num1 = (int) num3 * 1332403370 ^ 481670236;
                continue;
              case 4:
                num1 = (int) num3 * 1634886135 ^ -2142093854;
                continue;
              case 5:
                num1 = (int) num3 * -1299369521 ^ 1112639583;
                continue;
              case 6:
                num1 = (int) num3 * 1236488254 ^ -1255200797;
                continue;
              case 7:
                num1 = (int) num3 * 282598832 ^ 1298321430;
                continue;
              case 8:
                ((Collection<MessageContent>) this.MessageContents).Add(messageContent1);
                num1 = (int) num3 * -1079553621 ^ -185573775;
                continue;
              case 9:
                flag2 = ((Collection<MessageContent>) this.MessageContents).Contains(messageContent1);
                num1 = (int) num3 * -241349659 ^ -922074138;
                continue;
              default:
                goto label_19;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_14:
            int num1 = -875735223;
            while (true)
            {
              int num2 = -1174547510;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * 185978203 ^ -213664369;
                  continue;
                case 2:
                  goto label_14;
                case 3:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 1067361719 ^ 662408299;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
label_19:
        // ISSUE: type reference
        ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
        {
          ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (MessageContent)),
          ChangeType = ChangeType.Added,
          ChangedObject = (object) messageContent1
        });
label_20:
        int num6 = -473097736;
        while (true)
        {
          int num1 = -1174547510;
          uint num2;
          switch ((num2 = (uint) (num6 ^ num1)) % 4U)
          {
            case 0:
              goto label_20;
            case 1:
              messageContent1.SaveDatabaseObject();
              num6 = (int) num2 * -226214424 ^ -10348343;
              continue;
            case 2:
              num6 = (int) num2 * 1285015055 ^ -1723925463;
              continue;
            default:
              goto label_29;
          }
        }
      }
      catch (Exception ex)
      {
label_25:
        int num1 = -397730199;
        while (true)
        {
          int num2 = -1174547510;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_25;
            case 1:
              messageContent1 = (MessageContent) null;
              num1 = (int) num3 * 173436990 ^ 1893024818;
              continue;
            case 3:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * 1210198245 ^ 361777568;
              continue;
            default:
              goto label_29;
          }
        }
      }
label_29:
      MessageContent messageContent2 = messageContent1;
label_30:
      int num7 = -1627632664;
      while (true)
      {
        int num1 = -1174547510;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 3U)
        {
          case 1:
            num7 = (int) num2 * 1780332201 ^ -96921389;
            continue;
          case 2:
            goto label_30;
          default:
            goto label_33;
        }
      }
label_33:
      return messageContent2;
    }

    internal bool RemoveMessageContent(MessageContent content)
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = 1087676772;
        object engineLock;
        while (true)
        {
          int num2 = 23703397;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 2:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * -447583631 ^ -366024685;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        bool flag2 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag2);
label_7:
          int num2 = 867377278;
          while (true)
          {
            int num3 = 23703397;
            uint num4;
            bool flag3;
            switch ((num4 = (uint) (num2 ^ num3)) % 9U)
            {
              case 0:
                goto label_7;
              case 1:
                flag3 = ((Collection<MessageContent>) this.MessageContents).Contains(content);
                num2 = (int) num4 * -2130158833 ^ 460282388;
                continue;
              case 2:
                num2 = (int) num4 * 1317138060 ^ -1610912507;
                continue;
              case 3:
                int num5 = !flag3 ? 1916934281 : (num5 = 1091116391);
                int num6 = (int) num4 * 1536976224;
                num2 = num5 ^ num6;
                continue;
              case 5:
                num2 = (int) num4 * 1817498851 ^ -936354775;
                continue;
              case 6:
                num2 = (int) num4 * -322113956 ^ 2045707298;
                continue;
              case 7:
                ((Collection<MessageContent>) this.MessageContents).Remove(content);
                num2 = (int) num4 * 1727599818 ^ -465291424;
                continue;
              case 8:
                num2 = 185679017;
                continue;
              default:
                goto label_22;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_17:
            int num2 = 1319812126;
            while (true)
            {
              int num3 = 23703397;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_17;
                case 1:
                  num2 = (int) num4 * 1651273089 ^ 1055761866;
                  continue;
                case 3:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * 617664679 ^ -243941011;
                  continue;
                default:
                  goto label_21;
              }
            }
          }
label_21:;
        }
label_22:
        content.DeleteDatabaseObject();
        // ISSUE: type reference
        ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
        {
          ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (MessageContent)),
          ChangeType = ChangeType.Removed,
          ChangedObject = (object) content
        });
        content = (MessageContent) null;
        flag1 = true;
      }
      catch (Exception ex)
      {
        Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
      }
      bool flag4 = flag1;
label_25:
      int num7 = 1955634247;
      while (true)
      {
        int num1 = 23703397;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 3U)
        {
          case 1:
            num7 = (int) num2 * -263045454 ^ -1245673833;
            continue;
          case 2:
            goto label_25;
          default:
            goto label_28;
        }
      }
label_28:
      return flag4;
    }

    internal bool AddMessageCategory(MessageCategory category)
    {
      bool flag1 = false;
      try
      {
        object engineLock = Engine.engineLock;
        bool flag2 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag2);
label_3:
          int num1 = -991363676;
          while (true)
          {
            int num2 = -1811923046;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 8U)
            {
              case 0:
                ((Collection<MessageCategory>) this.MessageCategories).Add(category);
                num1 = (int) num3 * 702231188 ^ 1193184655;
                continue;
              case 2:
                num1 = (int) num3 * -1986572531 ^ 307479864;
                continue;
              case 3:
                num1 = -1439176973;
                continue;
              case 4:
                goto label_3;
              case 5:
                num1 = (int) num3 * -1164218895 ^ -1760830788;
                continue;
              case 6:
                num1 = (int) num3 * -1841331151 ^ 11470731;
                continue;
              case 7:
                int num4 = ((Collection<MessageCategory>) this.MessageCategories).Contains(category) ? 969241278 : (num4 = 1374481591);
                int num5 = (int) num3 * 748598409;
                num1 = num4 ^ num5;
                continue;
              default:
                goto label_16;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_12:
            int num1 = -2103892936;
            while (true)
            {
              int num2 = -1811923046;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_12;
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num1 = (int) num3 * 1649672854 ^ 327985440;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
label_16:
        // ISSUE: type reference
        ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
        {
          ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (MessageCategory)),
          ChangeType = ChangeType.Added,
          ChangedObject = (object) category
        });
label_17:
        int num6 = -1916108523;
        while (true)
        {
          int num1 = -1811923046;
          uint num2;
          switch ((num2 = (uint) (num6 ^ num1)) % 3U)
          {
            case 0:
              goto label_17;
            case 2:
              category.SaveDatabaseObject();
              num6 = (int) num2 * 856552327 ^ -1072026308;
              continue;
            default:
              goto label_20;
          }
        }
label_20:
        flag1 = true;
      }
      catch (Exception ex)
      {
label_22:
        int num1 = -1432446705;
        while (true)
        {
          int num2 = -1811923046;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 2080892323 ^ 1176543731;
              continue;
            case 2:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * 956822770 ^ 435472574;
              continue;
            case 3:
              goto label_22;
            default:
              goto label_26;
          }
        }
      }
label_26:
      bool flag3 = flag1;
label_27:
      int num7 = -742991969;
      while (true)
      {
        int num1 = -1811923046;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 3U)
        {
          case 0:
            goto label_27;
          case 1:
            num7 = (int) num2 * 734662722 ^ 1637457256;
            continue;
          default:
            goto label_30;
        }
      }
label_30:
      return flag3;
    }

    internal bool RemoveMessageCategory(MessageCategory category)
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = 55433251;
        object engineLock;
        while (true)
        {
          int num2 = 949597078;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * 643871226 ^ -703919668;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        bool flag2 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag2);
label_7:
          int num2 = 841930291;
          while (true)
          {
            int num3 = 949597078;
            uint num4;
            bool flag3;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 0:
                int num5 = flag3 ? -713022511 : (num5 = -254472649);
                int num6 = (int) num4 * 1285600359;
                num2 = num5 ^ num6;
                continue;
              case 2:
                flag3 = ((Collection<MessageCategory>) this.MessageCategories).Contains(category);
                num2 = (int) num4 * 510526072 ^ 2071720958;
                continue;
              case 3:
                goto label_7;
              case 4:
                num2 = (int) num4 * 615232155 ^ -1035818600;
                continue;
              case 5:
                num2 = (int) num4 * 1671316295 ^ -1091141879;
                continue;
              case 6:
                num2 = (int) num4 * 1740253475 ^ -945814675;
                continue;
              case 7:
                ((Collection<MessageCategory>) this.MessageCategories).Remove(category);
                num2 = (int) num4 * -2120150681 ^ -1090161575;
                continue;
              default:
                goto label_20;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_16:
            int num2 = 904656605;
            while (true)
            {
              int num3 = 949597078;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 1:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * -1472618318 ^ 212713165;
                  continue;
                case 2:
                  goto label_16;
                default:
                  goto label_19;
              }
            }
          }
label_19:;
        }
label_20:
        // ISSUE: type reference
        ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Publish(new ObjectChangedEventPayload()
        {
          ObjectType = Engine.\u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮(__typeref (MessageCategory)),
          ChangeType = ChangeType.Removed,
          ChangedObject = (object) category
        });
label_21:
        int num7 = 729064107;
        while (true)
        {
          int num2 = 949597078;
          uint num3;
          switch ((num3 = (uint) (num7 ^ num2)) % 4U)
          {
            case 0:
              flag1 = true;
              num7 = (int) num3 * 608526532 ^ 578673929;
              continue;
            case 1:
              category.DeleteDatabaseObject();
              num7 = (int) num3 * 768648479 ^ -1127383595;
              continue;
            case 2:
              goto label_21;
            default:
              goto label_30;
          }
        }
      }
      catch (Exception ex)
      {
label_26:
        int num1 = 1120842771;
        while (true)
        {
          int num2 = 949597078;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1581006878 ^ -155457226;
              continue;
            case 2:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * 51135357 ^ 1900069432;
              continue;
            case 3:
              goto label_26;
            default:
              goto label_30;
          }
        }
      }
label_30:
      return flag1;
    }

    [STAThread]
    public Task<bool> ExecuteAsync(Dispatcher mainDispatcher, CancellationToken token, object queue = null)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Engine.\u003CExecuteAsync\u003Ed__358 executeAsyncD358 = new Engine.\u003CExecuteAsync\u003Ed__358();
      // ISSUE: reference to a compiler-generated field
      executeAsyncD358.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      executeAsyncD358.mainDispatcher = mainDispatcher;
label_1:
      int num1 = -801024911;
      while (true)
      {
        int num2 = -547652681;
        uint num3;
        AsyncTaskMethodBuilder<bool> tBuilder;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            executeAsyncD358.\u003C\u003E1__state = -1;
            // ISSUE: reference to a compiler-generated field
            tBuilder = executeAsyncD358.\u003C\u003Et__builder;
            num1 = (int) num3 * -752741420 ^ 1959690980;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            executeAsyncD358.token = token;
            // ISSUE: reference to a compiler-generated field
            executeAsyncD358.queue = queue;
            // ISSUE: reference to a compiler-generated field
            executeAsyncD358.\u003C\u003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
            num1 = (int) num3 * 2031675892 ^ -1877130503;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            ((AsyncTaskMethodBuilder<bool>) @tBuilder).Start<Engine.\u003CExecuteAsync\u003Ed__358>((M0&) @executeAsyncD358);
            num1 = (int) num3 * 1886133853 ^ -1775411596;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      return ((AsyncTaskMethodBuilder<bool>) @executeAsyncD358.\u003C\u003Et__builder).get_Task();
    }

    public bool Execute(Dispatcher mainDispatcher, CancellationToken token)
    {
label_1:
      int num1 = -1169098918;
      bool flag1;
      while (true)
      {
        int num2 = -2045847969;
        uint num3;
        bool flag2;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 42U)
        {
          case 0:
            int num5 = this.IsExecuting ? 1014139966 : (num5 = 1020983531);
            int num6 = (int) num3 * -285493949;
            num1 = num5 ^ num6;
            continue;
          case 1:
            Engine.\u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮(Engine.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2304259623U));
            num1 = (int) num3 * 548314639 ^ -1858316621;
            continue;
          case 2:
            num1 = (int) num3 * 206733203 ^ -2136998846;
            continue;
          case 3:
            flag1 = !this.ErrorDetected;
            num1 = (int) num3 * 1636907635 ^ -906160889;
            continue;
          case 4:
            num1 = (int) num3 * -1725126406 ^ 1126016540;
            continue;
          case 5:
            this.ActivityManager.HandleActiveActivity();
            num1 = -1245726595;
            continue;
          case 6:
            this.IsExecuting = true;
            num1 = (int) num3 * 33414933 ^ -400968731;
            continue;
          case 7:
            num1 = (int) num3 * -274261854 ^ 766620207;
            continue;
          case 8:
            this.StartManagers();
            num1 = (int) num3 * 372605979 ^ 283335241;
            continue;
          case 9:
            this.Initialize(mainDispatcher, token);
            num1 = (int) num3 * -457762500 ^ 179031478;
            continue;
          case 10:
            this.CheckVersion();
            Engine.\u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮(Engine.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(174870844U));
            num1 = (int) num3 * -1335890673 ^ -701361750;
            continue;
          case 11:
            num1 = (int) num3 * -1759109 ^ 1442293232;
            continue;
          case 12:
            num1 = (int) num3 * 1877045712 ^ 1609948708;
            continue;
          case 13:
            this.IsExecuting = false;
            Engine.\u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮(Engine.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2375950591U));
            this.RaiseEvent(EngineEvent.Stopped, (Exception) null, false);
            num1 = -849571893;
            continue;
          case 14:
            num1 = (int) num3 * 1126575976 ^ 1876638485;
            continue;
          case 15:
            num1 = (int) num3 * -1911051442 ^ 125596261;
            continue;
          case 16:
            this.RaiseEvent(EngineEvent.CheckingVersion, (Exception) null, false);
            num1 = (int) num3 * 1642700540 ^ -1473580420;
            continue;
          case 17:
            num1 = (int) num3 * 1884018038 ^ -1864651357;
            continue;
          case 18:
            Engine.\u202A‎⁯⁪‮⁬‪‬‌⁭⁯⁯⁪⁯⁮​‏‍‌⁯⁪⁬‌‌‌⁯⁬‏⁭‍⁮‌‬‍⁮‬‫⁮‏‮‮(40);
            num1 = (int) num3 * 11318525 ^ 1184138351;
            continue;
          case 19:
            this.RaiseEvent(EngineEvent.Stopping, (Exception) null, false);
            this.CancelExecution();
            num1 = (int) num3 * -219493435 ^ -1100875554;
            continue;
          case 20:
            num1 = (int) num3 * 2132591362 ^ -1648655563;
            continue;
          case 21:
            this.UserInterfaceDispatcher = mainDispatcher;
            num1 = (int) num3 * 151381233 ^ -637677762;
            continue;
          case 22:
            num1 = (int) num3 * -1434523400 ^ 2090526556;
            continue;
          case 23:
            this.RaiseEvent(EngineEvent.Error, Engine.\u206F‮⁬⁭‮‪‪‌‏‬‌⁮‍‎⁬‎⁪⁫‍‏⁯‭‌⁪‮⁫⁪⁯‌‭⁪⁪⁫‎‌⁬‫‭‭‏‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3443367626U)), false);
            num1 = (int) num3 * 1503557988 ^ -1122047912;
            continue;
          case 24:
            num1 = (int) num3 * 491780264 ^ 154297463;
            continue;
          case 25:
            num1 = -305968812;
            continue;
          case 26:
            if (this.SharedData != null)
            {
              num1 = -1738774277;
              continue;
            }
            num4 = 0;
            break;
          case 28:
            int num7 = flag2 ? -1528152613 : (num7 = -1203987870);
            int num8 = (int) num3 * 1123421171;
            num1 = num7 ^ num8;
            continue;
          case 29:
            flag2 = this.MachineState == MachineState.Licensed;
            num1 = (int) num3 * -1988399039 ^ -1770677970;
            continue;
          case 30:
            this.RaiseEvent(EngineEvent.Started, (Exception) null, false);
            num1 = (int) num3 * 1392419229 ^ -344966130;
            continue;
          case 31:
            int num9 = !flag3 ? -135207168 : (num9 = -1538402938);
            int num10 = (int) num3 * -507452486;
            num1 = num9 ^ num10;
            continue;
          case 32:
            this.AttachEventHandlers();
            num1 = (int) num3 * -1369166668 ^ 565413342;
            continue;
          case 33:
            num1 = (int) num3 * -1382884054 ^ -1315558363;
            continue;
          case 34:
            this.CheckLicense();
            num1 = (int) num3 * -416993764 ^ -110977594;
            continue;
          case 35:
            Engine.\u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮(Engine.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3254736951U));
            num1 = (int) num3 * -954857390 ^ 526588737;
            continue;
          case 36:
            this.RaiseEvent(EngineEvent.Starting, (Exception) null, false);
            num1 = (int) num3 * 1742767392 ^ 396866886;
            continue;
          case 37:
            goto label_1;
          case 38:
            this.RaiseEvent(EngineEvent.CheckingLicense, (Exception) null, false);
            num1 = (int) num3 * 612177073 ^ 1590719915;
            continue;
          case 39:
            num1 = (int) num3 * -1224121359 ^ -164002241;
            continue;
          case 40:
            num4 = !this.ErrorDetected ? 1 : 0;
            break;
          case 41:
            num1 = -258643853;
            continue;
          default:
            goto label_46;
        }
        flag3 = num4 != 0;
        num1 = -264092298;
      }
label_46:
      return flag1;
    }

    private void LoadUsers()
    {
      this.RaiseEvent(EngineEvent.LoadingData, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(221876513U));
      try
      {
label_2:
        int num1 = -1112104999;
        object engineLock;
        List<ZoomUser> users;
        while (true)
        {
          int num2 = -1047091525;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              Engine.\u200F‫​​‌‏⁪⁬​‫‏‌⁭‬​‭⁮‮‮⁭‌‌‪‎‏⁬‏‍⁪‌⁬‍⁬‪⁭⁬⁪⁮‮⁯‮(Engine.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2955674907U), (object) users.Count);
              num1 = (int) num3 * 1134977304 ^ -1461917752;
              continue;
            case 2:
              Engine.\u206E⁬‭‪‎​‮⁭‌‎‮‍‏‪‌⁫​⁯‪‎⁪⁮‬⁯​⁮‍‪‪⁫‍‭‪⁭‫‏⁭⁭⁯⁯‮(Engine.log, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3618809415U), new object[0]);
              num1 = (int) num3 * -1434717459 ^ -1932483410;
              continue;
            case 3:
              engineLock = Engine.engineLock;
              num1 = (int) num3 * 472214508 ^ 1619255412;
              continue;
            case 4:
              goto label_2;
            case 5:
              users = this.ZoomZoomDatabase.GetUsers();
              num1 = (int) num3 * -1437905425 ^ 1591356434;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        bool flag1 = false;
        try
        {
          Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_10:
          int num2 = -1876557930;
          while (true)
          {
            int num3 = -1047091525;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                num2 = (int) num4 * -2113685380 ^ -1466886572;
                continue;
              case 2:
                goto label_10;
              case 3:
                num2 = (int) num4 * 214187166 ^ 1750161105;
                continue;
              default:
                goto label_14;
            }
          }
label_14:
          using (List<ZoomUser>.Enumerator enumerator = users.GetEnumerator())
          {
label_19:
            int num3 = enumerator.MoveNext() ? -1688889294 : (num3 = -1853471270);
            while (true)
            {
              int num4 = -1047091525;
              uint num5;
              int index;
              ZoomUser current;
              bool flag2;
              string name;
              string[] strArray1;
              string[] strArray2;
              switch ((num5 = (uint) (num3 ^ num4)) % 22U)
              {
                case 0:
                  num3 = -1688889294;
                  continue;
                case 1:
                  int num6 = Engine.\u202A‬‎‏‫‍‭‏⁮⁯​⁮‏⁮‭⁫‪⁭⁫‮‫‭⁪⁯‍​‮‮‮⁬‭⁪⁪⁮⁮‪⁭‍⁬‍‮(name) <= 5 ? -1650135549 : (num6 = -913420941);
                  int num7 = (int) num5 * 1215128964;
                  num3 = num6 ^ num7;
                  continue;
                case 2:
                  Engine.settings.AddName(name);
                  num3 = (int) num5 * 1475687317 ^ -732738351;
                  continue;
                case 3:
                  num3 = (int) num5 * 927282089 ^ 107655552;
                  continue;
                case 4:
                  ++index;
                  num3 = (int) num5 * 1742200063 ^ 157464018;
                  continue;
                case 5:
                  int num8;
                  num3 = num8 = index >= strArray2.Length ? -687136140 : (num8 = -1417342927);
                  continue;
                case 6:
                  num3 = (int) num5 * 487214122 ^ -1858526861;
                  continue;
                case 7:
                  goto label_19;
                case 8:
                  num3 = (int) num5 * 661262920 ^ -219745066;
                  continue;
                case 9:
                  current = enumerator.Current;
                  this.Users.Add(current);
                  num3 = -1231284419;
                  continue;
                case 10:
                  name = strArray2[index];
                  num3 = -2063998272;
                  continue;
                case 11:
                  num3 = (int) num5 * -801150401 ^ 1579356903;
                  continue;
                case 12:
                  num3 = (int) num5 * -1043532850 ^ -1463920437;
                  continue;
                case 14:
                  num3 = -463099260;
                  continue;
                case 15:
                  strArray2 = strArray1;
                  index = 0;
                  num3 = (int) num5 * 521377690 ^ -1677631188;
                  continue;
                case 16:
                  num3 = (int) num5 * 2040674818 ^ 68437258;
                  continue;
                case 17:
                  strArray1 = Engine.\u202C⁯‍⁭⁭‌⁫⁯‪‫⁬​⁬‮‌⁮‮‌‍‬⁫⁪‌‭‌⁪⁬‬⁬​‪‎‬⁫‬‏⁮⁯‬‬‮(current.UserName, new char[1]
                  {
                    ' '
                  });
                  num3 = (int) num5 * -1493695538 ^ 949441996;
                  continue;
                case 18:
                  num3 = -1501552319;
                  continue;
                case 19:
                  flag2 = Engine.\u202B⁫⁮⁯‬‭⁫‪‫‮‬‭⁮‭‍‍⁯‌‌⁭‌⁫‎‮‍​‬‎‮‪⁫⁯‍⁮‍⁯⁯⁫⁪⁫‮(current.UserName, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3518570259U));
                  num3 = (int) num5 * 1872348122 ^ 1626654589;
                  continue;
                case 20:
                  int num9 = !flag2 ? 2120315787 : (num9 = 294418505);
                  int num10 = (int) num5 * 75429447;
                  num3 = num9 ^ num10;
                  continue;
                case 21:
                  num3 = (int) num5 * -857523508 ^ -421735906;
                  continue;
                default:
                  goto label_45;
              }
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_40:
            int num2 = -899758811;
            while (true)
            {
              int num3 = -1047091525;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  num2 = (int) num4 * -1754481333 ^ 940730824;
                  continue;
                case 2:
                  Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                  num2 = (int) num4 * 107018381 ^ 902882528;
                  continue;
                case 3:
                  goto label_40;
                default:
                  goto label_44;
              }
            }
          }
label_44:;
        }
label_45:
        Engine.\u206E⁬‭‪‎​‮⁭‌‎‮‍‏‪‌⁫​⁯‪‎⁪⁮‬⁯​⁮‍‪‪⁫‍‭‪⁭‫‏⁭⁭⁯⁯‮(Engine.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(762812777U), new object[0]);
label_46:
        int num11 = -1540808230;
        while (true)
        {
          int num2 = -1047091525;
          uint num3;
          switch ((num3 = (uint) (num11 ^ num2)) % 4U)
          {
            case 0:
              goto label_59;
            case 1:
              num11 = (int) num3 * -1825717148 ^ 1901552921;
              continue;
            case 2:
              num11 = (int) num3 * -1561139790 ^ -2136555193;
              continue;
            case 3:
              goto label_46;
            default:
              goto label_55;
          }
        }
label_55:
        return;
label_59:;
      }
      catch (Exception ex)
      {
label_53:
        int num1 = -1237015747;
        while (true)
        {
          int num2 = -1047091525;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_53;
            case 1:
              num1 = (int) num3 * 349663122 ^ 424716496;
              continue;
            case 2:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num1 = (int) num3 * -1285837886 ^ 438654736;
              continue;
            case 3:
              num1 = (int) num3 * -1931365354 ^ -968665308;
              continue;
            case 4:
              goto label_51;
            default:
              goto label_48;
          }
        }
label_48:
        return;
label_51:;
      }
    }

    private void CheckLicense()
    {
label_1:
      int num1 = -88105975;
      while (true)
      {
        int num2 = -48897012;
        uint num3;
        DateTime datecompiled;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            int num4 = this.MachineState != MachineState.Licensed ? -817531039 : (num4 = -1625395363);
            int num5 = (int) num3 * -1886808069;
            num1 = num4 ^ num5;
            continue;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 485285980 ^ -213227769;
            continue;
          case 3:
            num1 = -2012730239;
            continue;
          case 4:
            this.RaiseEvent(EngineEvent.Error, new Exception(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(728060150U) + this.MachineState.ToString()), false);
            num1 = (int) num3 * -2101020264 ^ -1128794378;
            continue;
          case 5:
            this.MachineState = MachineState.Licensed;
            this.MachineState = CoreProtector.GetMachineState();
            num1 = (int) num3 * 1642244654 ^ -1802665478;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * 887315107 ^ -996383978;
            continue;
          case 8:
            num1 = (int) num3 * 49316685 ^ 1626190243;
            continue;
          case 9:
            num1 = (int) num3 * 1363299890 ^ 1901986099;
            continue;
          case 10:
            this.EngineState = EngineState.Error;
            num1 = (int) num3 * -798038321 ^ -166387886;
            continue;
          case 11:
            num1 = -249304889;
            continue;
          case 12:
            num1 = (int) num3 * 1176803833 ^ 1166767548;
            continue;
          case 13:
            num1 = (int) num3 * 1199348980 ^ 2076683224;
            continue;
          case 14:
            this.RaiseEvent(EngineEvent.Error, new Exception(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3315059386U)), false);
            num1 = (int) num3 * 793748601 ^ 1782692758;
            continue;
          case 15:
            this.EngineState = EngineState.Executing;
            num1 = (int) num3 * -871967926 ^ 695724741;
            continue;
          case 16:
            num1 = -259161245;
            continue;
          case 17:
            num1 = (int) num3 * -1742468374 ^ 942342622;
            continue;
          case 18:
            int num6 = flag ? -530790597 : (num6 = -1010049237);
            int num7 = (int) num3 * -844687668;
            num1 = num6 ^ num7;
            continue;
          case 19:
            flag = datecompiled.AddDays(30.0) > DateTime.Now;
            num1 = (int) num3 * -493321484 ^ -619886962;
            continue;
          case 20:
            datecompiled = CoreProtector.DATECOMPILED;
            num1 = (int) num3 * -1721592808 ^ -407747592;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return;
label_3:;
    }

    private void CheckVersion()
    {
label_1:
      int num1 = 1835154367;
      bool flag1;
      while (true)
      {
        int num2 = 1980198788;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            flag1 = false;
            num1 = (int) num3 * 752499039 ^ -1898339873;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
label_6:
        int num2 = 1149480566;
        while (true)
        {
          int num3 = 1980198788;
          uint num4;
          Version currentVersion;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 23U)
          {
            case 0:
              this.RaiseEvent(EngineEvent.Error, Engine.\u206F‮⁬⁭‮‪‪‌‏‬‌⁮‍‎⁬‎⁪⁫‍‏⁯‭‌⁪‮⁫⁪⁯‌‭⁪⁪⁫‎‌⁬‫‭‭‏‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3483044108U)), true);
              num2 = (int) num4 * 582011406 ^ 144893334;
              continue;
            case 1:
              Engine.\u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮(Engine.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3311766524U));
              num2 = (int) num4 * 379483812 ^ 2047515658;
              continue;
            case 2:
              goto label_31;
            case 3:
              num2 = (int) num4 * 734953309 ^ -456589062;
              continue;
            case 4:
              int num5 = AutoUpdater.HandleUpdate(currentVersion) ? 1712007140 : (num5 = 467156950);
              int num6 = (int) num4 * 33485409;
              num2 = num5 ^ num6;
              continue;
            case 5:
              num2 = (int) num4 * -827480942 ^ 1503607836;
              continue;
            case 6:
              currentVersion = Engine.\u206A‬⁬‍‏⁬⁬‌⁫‮‪⁬‭‭⁬‭⁭‬‍⁯‬‭‮‮‪⁯⁯‎‮‮‎‬‪‭‏‮‭‫​⁭‮(Engine.\u200C‪‏⁯‪⁭​‫‌‌⁪⁫‍⁫‬⁯‮‪‍⁭⁮⁪‫⁭‫‪⁪‏‪⁬⁬‍⁭​⁯‮‌‌‪‭‮(Engine.\u206B​​‌⁯⁪⁯⁯‭‍⁮⁪‌‬‍‍‫‬⁯⁫‎‎‍​‭⁬‌⁮‍⁫‏​⁫​⁪⁯‍‌​‏‮()));
              num2 = (int) num4 * 166198902 ^ -2131767966;
              continue;
            case 7:
              num2 = 1740220698;
              continue;
            case 8:
              num2 = (int) num4 * 1067671366 ^ -276671075;
              continue;
            case 9:
              num2 = (int) num4 * -1882197702 ^ -331002241;
              continue;
            case 10:
              num2 = (int) num4 * -2124356308 ^ -1339615318;
              continue;
            case 11:
              num2 = 1109405689;
              continue;
            case 12:
              this.CreateDirectoryStructure();
              num2 = (int) num4 * -656689362 ^ -917280306;
              continue;
            case 13:
              num2 = (int) num4 * 182188542 ^ 1716276186;
              continue;
            case 14:
              Engine.\u202B‪⁯⁬‪‍‎‭‬⁪⁪​‬‏⁮⁫‌‪‎⁭‭‌‬⁬‪‭‌⁪⁯⁭⁭​⁮‮‭‬⁬⁮‏⁯‮(Engine.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1847644034U), (object) currentVersion);
              num2 = (int) num4 * -269464340 ^ -1545628077;
              continue;
            case 15:
              int num7 = flag2 ? -1653444468 : (num7 = -1080709402);
              int num8 = (int) num4 * 1629111528;
              num2 = num7 ^ num8;
              continue;
            case 16:
              goto label_6;
            case 17:
              goto label_27;
            case 18:
              flag2 = !flag1;
              num2 = (int) num4 * 303940367 ^ -440004533;
              continue;
            case 19:
              num2 = 1379569783;
              continue;
            case 20:
              num2 = (int) num4 * 541635931 ^ -455618739;
              continue;
            case 21:
              num2 = (int) num4 * 1336446642 ^ 877393846;
              continue;
            default:
              goto label_33;
          }
        }
label_27:
        return;
label_31:
        return;
      }
      catch (Exception ex)
      {
label_29:
        int num2 = 1997511408;
        while (true)
        {
          int num3 = 1980198788;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_29;
            case 1:
              Engine.\u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮(Engine.log, (object) ex);
              num2 = (int) num4 * -351250343 ^ 923388686;
              continue;
            default:
              goto label_33;
          }
        }
      }
label_33:
      Engine.\u206A⁯⁮‏‍⁫‮‫‏⁮‭⁪⁫⁫⁯​‮​‬⁯⁮⁬⁫⁫⁮⁫‬‍‎‏⁯⁮‍‬‏⁪‎​⁪‫‮(0);
    }

    private void CreateDirectoryStructure()
    {
label_1:
      int num1 = 14547780;
      while (true)
      {
        int num2 = 83046405;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_3;
          case 1:
            CoreUtils.CreateDirectory(Resources.MeetingsRoot);
            num1 = (int) num3 * 1853860011 ^ -1264517064;
            continue;
          case 2:
            goto label_1;
          case 3:
            Engine.\u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮(Engine.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(76890454U));
            num1 = (int) num3 * 1013304579 ^ -1181708593;
            continue;
          case 4:
            CoreUtils.CreateDirectory(Resources.WindowsRoot);
            num1 = (int) num3 * -1886135479 ^ 125151311;
            continue;
          case 5:
            CoreUtils.CreateDirectory(Resources.ZoomZoomRoot);
            num1 = (int) num3 * -1514700975 ^ 909812220;
            continue;
          case 6:
            CoreUtils.CreateDirectory(Resources.LayoutsRoot);
            num1 = (int) num3 * 627917447 ^ -1792736574;
            continue;
          case 7:
            CoreUtils.CreateDirectory(Resources.LicenseRoot);
            num1 = (int) num3 * -1760272600 ^ 942690275;
            continue;
          case 8:
            CoreUtils.CreateDirectory(Resources.DatabaseRoot);
            CoreUtils.CreateDirectory(Resources.ImagesRoot);
            num1 = (int) num3 * 441525065 ^ 1134456934;
            continue;
          case 9:
            num1 = (int) num3 * 1744683827 ^ 660437781;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    public void SetMainWindowHandle(IntPtr handle)
    {
      this.WindowManager.SetMainWindowHandle(handle);
    }

    private void LoadButtons()
    {
      this.RaiseEvent(EngineEvent.LoadingData, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2249585399U));
      object engineLock = Engine.engineLock;
      bool flag1 = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag1);
label_2:
        int num1 = 1004292127;
        List<ZoomButton> buttons;
        while (true)
        {
          int num2 = 1247917802;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              buttons = Engine.zoomZoomDatabase.GetButtons();
              num1 = (int) num3 * 1793070784 ^ -626404959;
              continue;
            case 1:
              num1 = (int) num3 * -1722632945 ^ 924091357;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_6;
          }
        }
label_6:
        using (List<ZoomButton>.Enumerator enumerator = buttons.GetEnumerator())
        {
label_13:
          int num2 = enumerator.MoveNext() ? 1430400699 : (num2 = 233020771);
          while (true)
          {
            int num3 = 1247917802;
            uint num4;
            ZoomButton current;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 10U)
            {
              case 0:
                num2 = (int) num4 * 2126577220 ^ 183279626;
                continue;
              case 1:
                goto label_23;
              case 2:
                goto label_13;
              case 3:
                int num5 = flag2 ? 1550077918 : (num5 = 97687092);
                int num6 = (int) num4 * 650142058;
                num2 = num5 ^ num6;
                continue;
              case 4:
                num2 = 439377668;
                continue;
              case 5:
                num2 = 1430400699;
                continue;
              case 6:
                flag2 = !((Collection<ZoomButton>) this.Buttons).Contains(current);
                num2 = (int) num4 * 51237213 ^ 812128115;
                continue;
              case 7:
                num2 = (int) num4 * -638824619 ^ -1705712449;
                continue;
              case 8:
                ((Collection<ZoomButton>) this.Buttons).Add(current);
                num2 = (int) num4 * 428440218 ^ -2147453026;
                continue;
              case 9:
                current = enumerator.Current;
                num2 = 1305813585;
                continue;
              default:
                goto label_19;
            }
          }
label_19:
          return;
label_23:;
        }
      }
      finally
      {
        if (flag1)
        {
label_21:
          int num1 = 611069893;
          while (true)
          {
            int num2 = 1247917802;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_21;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * -575507398 ^ 1150764963;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
    }

    private void WindowManager_OnWindowHighlightUpdate(object sender, EventArgs e)
    {
label_1:
      int num1 = 2074902832;
      while (true)
      {
        int num2 = 1909925911;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            this.OnWindowHighlightUpdate(sender, e);
            num1 = (int) num3 * 1077245963 ^ 285346869;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            int num4 = this.OnWindowHighlightUpdate == null ? 358267769 : (num4 = 651930087);
            int num5 = (int) num3 * -1224798785;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 1975702630 ^ 1113653726;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private void WindowManager_OnWindowHighlightEnd(object sender, EventArgs e)
    {
label_1:
      int num1 = -2100903109;
      while (true)
      {
        int num2 = -1026646474;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            int num4 = this.OnWindowHighlightEnd != null ? -1911217367 : (num4 = -1165528662);
            int num5 = (int) num3 * 1761647468;
            num1 = num4 ^ num5;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.OnWindowHighlightEnd(sender, e);
            num1 = (int) num3 * 1381252947 ^ -779499515;
            continue;
          case 3:
            num1 = (int) num3 * -1246238210 ^ -1410695592;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * 50341414 ^ 1792381420;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void WindowManager_OnWindowHighlightStart(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      bool flag = this.OnWindowHighlightStart != null;
label_1:
      int num1 = 2028460046;
      while (true)
      {
        int num2 = 28514901;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -36861570 ^ 103430161;
            continue;
          case 1:
            int num4 = !flag ? -1218092226 : (num4 = -1790710531);
            int num5 = (int) num3 * 465743745;
            num1 = num4 ^ num5;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.OnWindowHighlightStart(sender, e);
            num1 = (int) num3 * 435028320 ^ 309643667;
            continue;
          case 3:
            num1 = (int) num3 * -1407626820 ^ 1382686095;
            continue;
          case 4:
            goto label_3;
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

    private void ActivityManager_OnActivityProgressReport(object sender, EventArgs e)
    {
label_1:
      int num1 = 1906797100;
      while (true)
      {
        int num2 = 478386055;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 408606634 ^ -1424779112;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            this.OnActivityProgressReport(sender, e);
            num1 = (int) num3 * 2071383673 ^ -1201149798;
            continue;
          case 4:
            num1 = (int) num3 * 844929166 ^ -2147329583;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            int num4 = this.OnActivityProgressReport != null ? -99099009 : (num4 = -1217870937);
            int num5 = (int) num3 * -2067290431;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    public bool SetZoomUserName(string newName, bool killZoomProceses = false)
    {
      if (!Engine.\u200E‌⁯‭‌⁫‫⁫‏⁬‏⁮⁫‭‫⁬⁯‮⁪⁪⁫⁪‍‏​‏‫⁭⁭‌‮‍⁫‌‍⁭⁭‫‌‬‮(newName, string.Empty))
        goto label_6;
label_1:
      int num1 = 1105580339;
label_2:
      bool flag1;
      while (true)
      {
        int num2 = 1952469812;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            flag2 = killZoomProceses;
            num1 = (int) num3 * 394658532 ^ 636823183;
            continue;
          case 1:
            flag1 = false;
            num1 = 888163378;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1666299138 ^ 758515168;
            continue;
          case 5:
            num1 = 702971025;
            continue;
          case 6:
            goto label_6;
          case 7:
            int num4 = !flag2 ? -212986126 : (num4 = -629187539);
            int num5 = (int) num3 * -1453295475;
            num1 = num4 ^ num5;
            continue;
          case 8:
            num1 = (int) num3 * 1497691778 ^ -933543387;
            continue;
          case 9:
            this.Settings.ZoomName = Engine.\u200B⁬​⁭‫‪‏⁯⁯‬‫‮‎‬‪⁫‪‬‮⁬‬⁭‫⁮‍⁭⁭⁫⁬‍‍⁭‫‭‮​‬⁪‬‏‮(newName, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1693148028U));
            num1 = (int) num3 * -1731050575 ^ 851123865;
            continue;
          case 10:
            this.KillZoomProcesses();
            num1 = (int) num3 * 518191838 ^ 1109758748;
            continue;
          case 11:
            newName = this.GetLineArt();
            num1 = (int) num3 * 1145611483 ^ -1710267413;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return flag1;
label_6:
      num1 = Engine.zoomDatabase.SetZoomUserNameForJoin(newName, true) ? 448303233 : (num1 = 702971025);
      goto label_2;
    }

    internal void KillZoomProcesses()
    {
label_1:
      int num1 = 1748636101;
      List<Process> list;
      while (true)
      {
        int num2 = 1162384198;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1691285413 ^ -826747047;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<Process>) Enumerable.Where<Process>((IEnumerable<M0>) ((IEnumerable<Process>) Engine.\u202E‬‍⁪‏⁮‍‪⁫‬‫‏⁬‮‮‭‭⁫⁭⁬‪‏⁮‎⁮⁯‫‭‏‏‌‮‫‫⁮⁪‫⁮⁫‮‮()).ToList<Process>(), (Func<M0, bool>) (Engine.\u003C\u003Ec.\u003C\u003E9__371_0 ?? (Engine.\u003C\u003Ec.\u003C\u003E9__371_0 = new Func<Process, bool>((object) Engine.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CKillZoomProcesses\u003Eb__371_0)))))).ToList<Process>();
            num1 = 1047757288;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      List<Process>.Enumerator enumerator = list.GetEnumerator();
      try
      {
label_19:
        uint num2;
        if (enumerator.MoveNext())
        {
label_9:
          Process current = enumerator.Current;
          int num3 = 991532132;
          while (true)
          {
            int num4 = 1162384198;
            switch ((num2 = (uint) (num3 ^ num4)) % 3U)
            {
              case 0:
                num3 = 1858876688;
                continue;
              case 1:
                goto label_9;
              default:
                goto label_10;
            }
          }
label_10:
          try
          {
            Engine.\u202B‬⁮‍‪⁫‍⁮‍‍‮‫⁯​‬⁮⁬‎‏‮‬⁫‮‮⁭⁪⁭⁬‪‬⁭‪⁬‭‎‏⁭‌⁭‪‮(current);
          }
          catch (Exception ex)
          {
label_13:
            int num4 = 1390653598;
            while (true)
            {
              int num5 = 1162384198;
              uint num6;
              switch ((num6 = (uint) (num4 ^ num5)) % 3U)
              {
                case 0:
                  goto label_13;
                case 1:
                  num4 = (int) num6 * 1563617217 ^ -1224091674;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
        else
          goto label_20;
label_17:
        int num7 = 1721718301;
label_18:
        int num8 = 1162384198;
        switch ((num2 = (uint) (num7 ^ num8)) % 3U)
        {
          case 0:
            goto label_17;
          case 1:
            goto label_19;
          case 2:
            return;
          default:
            return;
        }
label_20:
        num7 = 1576960021;
        goto label_18;
      }
      finally
      {
        enumerator.Dispose();
label_23:
        int num2 = 1133513744;
        while (true)
        {
          int num3 = 1162384198;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_23;
            case 2:
              num2 = (int) num4 * -181906465 ^ 1647316851;
              continue;
            default:
              goto label_27;
          }
        }
label_27:;
      }
    }

    public void ScrollMeetingWindow(bool scrollRight = true)
    {
label_1:
      int num1 = -1169988547;
      while (true)
      {
        int num2 = -792556409;
        uint num3;
        ZoomWindow zoomWindow1;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * -1056152436 ^ -1084148308;
            continue;
          case 1:
            ZoomWindow zoomWindow2 = zoomWindow1;
            System.Drawing.Size size = zoomWindow1.Size;
            int x = size.Width / 2;
            size = zoomWindow1.Size;
            int y = size.Height / 2;
            System.Drawing.Point coordinates = new System.Drawing.Point(x, y);
            int num5 = 1;
            int num6 = 1;
            int millisecondDelay = 0;
            zoomWindow2.Click(coordinates, num5 != 0, num6 != 0, millisecondDelay);
            num1 = (int) num3 * -266279028 ^ -1507267846;
            continue;
          case 2:
            num1 = (int) num3 * -420427305 ^ -1406252911;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            zoomWindow1 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) (Engine.\u003C\u003Ec.\u003C\u003E9__372_1 ?? (Engine.\u003C\u003Ec.\u003C\u003E9__372_1 = new Func<ZoomWindow, bool>((object) Engine.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CScrollMeetingWindow\u003Eb__372_1)))));
            num1 = -1479620038;
            continue;
          case 4:
            num1 = (int) num3 * 1121646316 ^ 570775634;
            continue;
          case 5:
            num1 = (int) num3 * 1783152377 ^ -919854328;
            continue;
          case 6:
            goto label_1;
          case 7:
            int num7 = !flag ? 811139976 : (num7 = 1099982954);
            int num8 = (int) num3 * 1244916823;
            num1 = num7 ^ num8;
            continue;
          case 8:
            goto label_3;
          case 9:
            num4 = zoomWindow1.IsVisible ? 1 : 0;
            break;
          case 10:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            zoomWindow1 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) (Engine.\u003C\u003Ec.\u003C\u003E9__372_0 ?? (Engine.\u003C\u003Ec.\u003C\u003E9__372_0 = new Func<ZoomWindow, bool>((object) Engine.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CScrollMeetingWindow\u003Eb__372_0)))));
            num1 = -1344169047;
            continue;
          case 11:
            flag = scrollRight;
            num1 = (int) num3 * 154996652 ^ -863143229;
            continue;
          case 12:
            if (zoomWindow1 == null)
            {
              num4 = 0;
              break;
            }
            num1 = -1395154874;
            continue;
          default:
            goto label_18;
        }
        int num9;
        num1 = num9 = num4 == 0 ? -1787935719 : (num9 = -695869892);
      }
label_18:
      return;
label_3:;
    }

    internal void SetTrackingWindow(TrackingWindow trackingWindow)
    {
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
        int num1 = -286603235;
        while (true)
        {
          int num2 = -906975009;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              this.TrackingWindow = trackingWindow;
              num1 = (int) num3 * 1943048880 ^ 896042465;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_9:;
      }
      finally
      {
        if (flag)
        {
label_7:
          int num1 = -1027497898;
          while (true)
          {
            int num2 = -906975009;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * -828952018 ^ 1846395574;
                continue;
              case 2:
                goto label_7;
              case 3:
                num1 = (int) num3 * 2143371941 ^ 891112960;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
    }

    internal void SetImageHistoryView(ImageHistoryView imageHistoryView)
    {
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
        int num1 = 1350549285;
        while (true)
        {
          int num2 = 1083264751;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              this.ImageHistoryView = imageHistoryView;
              num1 = (int) num3 * -881345781 ^ -416313815;
              continue;
            case 2:
              goto label_9;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_9:;
      }
      finally
      {
        if (flag)
        {
label_7:
          int num1 = 1540573549;
          while (true)
          {
            int num2 = 1083264751;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * -851557276 ^ 1387346443;
                continue;
              case 2:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 1959014336 ^ 191407314;
                continue;
              case 3:
                goto label_7;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
    }

    internal void SetEngineView(EngineView engineView)
    {
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
label_2:
        int num1 = 390821987;
        while (true)
        {
          int num2 = 1746741730;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_10;
            case 1:
              num1 = (int) num3 * -695204212 ^ 2030047313;
              continue;
            case 2:
              goto label_2;
            case 3:
              this.EngineView = engineView;
              num1 = (int) num3 * -1330632261 ^ 1994855979;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_10:;
      }
      finally
      {
        if (flag)
        {
label_8:
          int num1 = 208970665;
          while (true)
          {
            int num2 = 1746741730;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * 640187174 ^ -1982484561;
                continue;
              case 2:
                goto label_8;
              case 3:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * -1936851102 ^ -724801916;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    internal void SetSelectorWindow(WindowSelector selectorWindow)
    {
      object engineLock = Engine.engineLock;
      bool flag = false;
      try
      {
        Engine.\u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮(engineLock, ref flag);
        this.SelectorWindow = selectorWindow;
      }
      finally
      {
        if (flag)
        {
label_3:
          int num1 = -688750987;
          while (true)
          {
            int num2 = -174590916;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                Engine.\u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮(engineLock);
                num1 = (int) num3 * 901451539 ^ 803332348;
                continue;
              case 2:
                goto label_3;
              case 3:
                num1 = (int) num3 * 1612960754 ^ 73090030;
                continue;
              default:
                goto label_7;
            }
          }
        }
label_7:;
      }
    }

    static void \u202B‍‎⁬⁫‎‍‭‎‍⁮⁬⁬⁮​⁯‬⁫‫‬⁬⁫‫⁮‍‌⁭​⁪⁯⁯‎⁮⁪‪‌⁯‎​‬‮([In] Process obj0)
    {
      obj0.Refresh();
    }

    static IntPtr \u200B⁯‫⁬‎​⁪‪‎​‮‪⁬‬‏‫‪⁪⁮‬‭‌‫‭‬‫⁮‍⁬⁪‎‪⁪⁬⁪‌⁫‎​‍‮([In] Process obj0)
    {
      return obj0.MainWindowHandle;
    }

    static void \u202C‪‪‎​‪⁫​⁭⁫‎‏⁭‫‮‭‍⁯⁭‏‌‮⁪‮⁪⁫‮‍‌⁪‮‪‎‏‮⁫‏‭‫‮‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202C‮⁮‫⁫‏‎‫‬‮‫⁮⁮‎‭‪⁪‍‪‬‏⁪⁫⁭‎‎⁭​⁪⁮‍‏‮‬⁬‭‏⁬‌⁬‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static string \u200F‏‪​⁭⁭‎‪⁫‍⁭⁭‫⁬‫⁪⁭‎⁫⁪⁪‏‭⁬‌⁯‮‌​‭‪⁮‪⁮⁪⁮‭⁯⁯‪‮([In] string obj0)
    {
      return obj0.Trim();
    }

    static bool \u202B⁫⁮⁯‬‭⁫‪‫‮‬‭⁮‭‍‍⁯‌‌⁭‌⁫‎‮‍​‬‎‮‪⁫⁯‍⁮‍⁯⁯⁫⁪⁫‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static bool \u206C⁬⁯⁫‫‍‍⁯‌⁭⁬‍⁯‫⁫⁫⁫‫‏‏‪‪‌‏‫‮​‎⁭‮‍‏‪‬⁬‭⁪‍⁯‮([In] string obj0, [In] string obj1)
    {
      return obj0.EndsWith(obj1);
    }

    static string \u200B⁬​⁭‫‪‏⁯⁯‬‫‮‎‬‪⁫‪‬‮⁬‬⁭‫⁮‍⁭⁭⁫⁬‍‍⁭‫‭‮​‬⁪‬‏‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static void \u206E‮​‪‍​‎‌‬⁭‏‌⁬⁮‮⁭‪‏⁬‪‭‎⁬‎⁭‮‎‪‎‭‫‫‏‎‍⁭‭‪‌‬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static Exception \u206F‮⁬⁭‮‪‪‌‏‬‌⁮‍‎⁬‎⁪⁫‍‏⁯‭‌⁪‮⁫⁪⁯‌‭⁪⁪⁫‎‌⁬‫‭‭‏‮([In] string obj0)
    {
      return new Exception(obj0);
    }

    static Thread \u200D⁭⁬‪⁫‍⁯⁯⁬‌‎⁪⁮⁯⁯⁬‬⁯‌⁮‬⁫⁫‮‭‫‭‬‫⁬‫⁬‌​‭⁬‏‬⁯‫‮()
    {
      return Thread.CurrentThread;
    }

    static int \u206E⁮‬⁮​⁮‭‭‭⁮‪⁫‫⁭⁫‮⁬‬‍‭⁬‍​‏‎⁮⁭⁪‎‎​​‌⁯⁭‏‫⁫‏⁮‮([In] Thread obj0)
    {
      return obj0.ManagedThreadId;
    }

    static CancellationTokenSource \u206A‪⁪⁬⁭⁬‪‬⁪‪⁭⁮⁬‫⁮⁮​⁫‭‍‏‫‏‮⁯⁭‫⁪‬⁭⁫‏⁫⁫‮⁪⁪‮⁪‪‮()
    {
      return new CancellationTokenSource();
    }

    static CancellationToken \u206F‍​⁪⁯⁬⁯⁯⁯⁫‏‬‮‌‎⁬⁭⁬‬‏⁯‍‌‫⁪‪⁪⁮‪‬‍‌‏⁭‭​⁫‬⁬⁬‮([In] CancellationTokenSource obj0)
    {
      return obj0.get_Token();
    }

    static Delegate \u202C‭‪⁭‪‍⁮‌‌‫‌‭⁭‌‌‬‬⁮​⁯‍‫⁯⁭‬⁯⁪‪⁪⁬⁬‭‭‌‍‌‪⁪‫⁭‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u202A⁯⁯‏‍‭‪⁭⁬‮‎‬‎‭⁫⁯​⁭⁯‫⁪⁭‭‏‌⁪⁬‮‫‭‍‍​​‏‪⁮‮‍⁪‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static string \u206F⁭⁯⁯​⁯⁪‏‏‌⁯‎​⁪‏​​‮⁮‮‫‮⁪⁯‌‮⁬‪‍​⁮⁪⁪‬‎‎⁪‫‫‮([In] PropertyChangedEventArgs obj0)
    {
      return obj0.PropertyName;
    }

    static bool \u200E‌⁯‭‌⁫‫⁫‏⁬‏⁮⁫‭‫⁬⁯‮⁪⁪⁫⁪‍‏​‏‫⁭⁭‌‮‍⁫‌‍⁭⁭‫‌‬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u200F⁬⁭‪​‫⁭⁬‌‌‬‭‍⁬‪⁮⁯⁪⁮⁭⁯‮‬‎‏‬‬⁮⁮⁮⁮‍‍‫⁯‫‪‮‪⁭‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }

    static Application \u206A⁯‎‮‫‌‭‫⁭⁪⁯‪⁭‍‭‌‮‮‌‬‌⁪‮‫⁪‌‍‫‭‫‭‭‌‌⁬⁯‬⁯⁪‍‮()
    {
      return Application.Current;
    }

    static Dispatcher \u200E‏‬⁯‍‫⁬⁮‬⁭⁭⁮‍⁯‏‬⁯‪⁭⁯⁯⁮⁮⁯‫‬⁯‌​⁯‫‍‏‭‎‭‮⁭⁮⁭‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u206D⁭‪⁫⁭⁫⁬‮‬⁭⁯‬‍⁯‪‭⁪‮‍‍⁭⁭‌‮‎‬⁭‪‬⁮⁬‌‬‭⁪‪‫‮‎⁪‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static Type \u202D‌‪​‍‎⁪⁫‮‭⁮‪‬⁭‭‪‮⁯⁭‎‌​‌⁮‭‬‍‭⁪‍‏‫⁯⁮​⁮‌‫⁭⁯‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static string \u206C⁫⁮‮‏‎‬⁪‍‏‍⁯​‭‮‬⁫⁬‭‬‫‫‫‫‌‍‫⁪⁬⁬‬⁫‪‎‌‭‭⁭‮‍‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static string \u202C⁫⁭⁮‮⁪‌‫⁯⁫​‎‏⁪‍‫‎‏‍‎⁫‪⁭‬⁪‎‎⁫‎⁫⁭‍​‎‮‭‪‮‫‍‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static void \u200D⁯⁪⁫⁫‬‏⁬‎‮​‍⁪‎‏⁮‫‌⁭‏⁬‫‭⁪‮‮⁬‌‌‫​⁯⁪‍‏⁯⁭⁫‌‏‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static Random \u206B⁪‌‍⁬‪​​‎⁪‫‪⁫‍‪‫‬‪‏‫‌⁮‫‏⁯⁬‮⁫⁫​⁫⁬‪⁯⁫⁭‫‍‫‮()
    {
      return new Random();
    }

    static int \u200D⁫⁬‭‬‭‫⁬⁭‮‏⁮⁬⁪⁭⁭‫⁭‬⁭‬⁬‫‫​⁭⁯‬‌⁯‮⁮⁬‭‭⁪‬⁫‭⁪‮([In] Random obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Next(obj1, obj2);
    }

    static void \u206E⁫‮‭⁫‎‎‌⁯‬‫‎‎‫⁪⁬⁭‌‎⁫‎⁭⁬​‎‭⁯​‫‭⁫‬‬⁯‬‭⁮‭⁪⁮‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.DebugFormat(obj1, obj2, obj3);
    }

    static string \u206F‬⁪‪​⁭‮‏‍‌‫‏‫⁮‌⁭‮⁪‫‎⁬‏‪‪‫‬​‏‌⁫‎‮‭⁭⁭‮‏⁮‌‮‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u206B‫‏‏⁬⁯‪‌‫‏‮‌⁬‫⁮⁮‪‏⁫⁮⁮‎‏‌⁬⁯‌‏​⁫‏‍‫‏‏⁫‎‏​⁫‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0 + obj1 + obj2;
    }

    static Type \u200B⁪‭‫​‌‬‍‍‫⁫‪‬⁪‏⁬⁮‭‏‏‎⁪‫‏⁯​⁪‪⁬‏​⁯⁭‏‫‬‎⁯⁭‫‮([In] object obj0)
    {
      return obj0.GetType();
    }

    static string \u202B⁭‪⁯‬⁮⁪​‬⁪‎⁬⁪‫‮⁯‏‏⁫‪⁬⁫‪⁪‍⁯‮⁭‍‪‬‌​⁭⁮‪⁫‮‪‬‮([In] MemberInfo obj0)
    {
      return obj0.Name;
    }

    static bool \u206F⁯‍‭‮⁫⁭‏‪⁮⁭‏​‪‭‮⁫⁯‭‬⁮⁮​⁯‏‍‎⁪‎‬⁭‬‬⁪‌‏‮⁯‭‪‮([In] Type obj0, [In] Type obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u200F‫​​‌‏⁪⁬​‫‏‌⁭‬​‭⁮‮‮⁭‌‌‪‎‏⁬‏‍⁪‌⁬‍⁬‪⁭⁬⁪⁮‮⁯‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static string \u206F⁬‮⁬‮‫‮‪⁮⁯⁪⁫‫‍‫‭⁯‮⁪‫⁮‬‏‭‮⁪⁬⁫‍‮‌⁯‍​‏⁮⁬‍‎⁯‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static bool \u202D‏⁫‎‭‎‏⁭‏‫‬‮⁭‌‏⁮‏‌⁯⁮‌‭‌‬⁫⁬‍‬‏​‍‮‬⁪‬‫⁮‍‪‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u202C​‮⁯‍‮⁭⁯​‮⁯‎‭⁯‫‍‫‮⁫⁫⁫​‍⁪‍‫⁪‫‭‪‍‎‏‭⁯‪⁮‭​⁭‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static string[] \u206F⁭‍‭‪⁭‍‌⁪⁬‫⁫⁬⁪‫‍‮⁮‫‬‬‌‭⁮​‫‭‎​​⁪​⁪​‬⁭⁮⁮‍⁮‮([In] string obj0)
    {
      return File.ReadAllLines(obj0);
    }

    static bool \u206F‬⁯⁫‫‬‬‏‪‪⁬⁬‬⁬‌‫⁭‬⁯‎‎⁫​⁯‎⁬‎‮‫⁯⁫‎⁯‍‏​⁫‌⁮⁬‮([In] string obj0)
    {
      return File.Exists(obj0);
    }

    static string \u206C‫‌‍‬‏‫‌⁫‌‎⁬‪‪‮⁫‌‌‭‬⁪‏⁫‬‭⁮‭​‏⁫‭⁪⁪⁯‮‌‍⁫‏‪‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static void \u200C‭‮‪⁫‫⁪‎‫⁯‌‭‏‏⁪‭‬‪⁪⁭‪⁮‪⁬‭‌‍⁭⁬⁮‎‎‍⁬⁭⁭‍‫‫‍‮([In] string obj0)
    {
      File.Delete(obj0);
    }

    static Encoding \u200E‫‏⁫⁮‌⁭‎⁭⁯​‫‬‬⁫‬‏​⁭‍⁮⁬‪​⁯⁮‌⁯⁪‎‬⁫​‭⁪⁭‮‬⁪‌‮()
    {
      return Encoding.ASCII;
    }

    static void \u202A​⁯‎⁫‏‍‪‬⁭‏⁭⁪‮‭‫⁪⁫‏‪‎‪⁬⁬⁯‪⁬⁯‮‪‬‎⁭⁮‪‏⁬⁭⁪⁭‮([In] string obj0, [In] string[] obj1, [In] Encoding obj2)
    {
      File.WriteAllLines(obj0, obj1, obj2);
    }

    static void \u200D⁪‎‎‭⁪⁬‫​‫‫‎⁯‮‫‌⁮⁪⁮‭‌⁮‮‬⁪⁭‍‌⁯‭‪‮‏​‏‌‏‮‬‬‮([In] string obj0, [In] string[] obj1)
    {
      File.WriteAllLines(obj0, obj1);
    }

    static string \u206F⁮⁫‭‮‍‪⁬⁮‬​‌‎⁬​​⁯​⁪⁯​‫‫⁯‫⁫‬​‭⁪⁮‎‪⁬⁫‭​‭‭‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static void \u202A‎⁯⁪‮⁬‪‬‌⁭⁯⁯⁪⁯⁮​‏‍‌⁯⁪⁬‌‌‌⁯⁬‏⁭‍⁮‌‬‍⁮‬‫⁮‏‮‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static void \u206E⁬‭‪‎​‮⁭‌‎‮‍‏‪‌⁫​⁯‪‎⁪⁮‬⁯​⁮‍‪‪⁫‍‭‪⁭‫‏⁭⁭⁯⁯‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.InfoFormat(obj1, obj2);
    }

    static string[] \u202C⁯‍⁭⁭‌⁫⁯‪‫⁬​⁬‮‌⁮‮‌‍‬⁫⁪‌‭‌⁪⁬‬⁬​‪‎‬⁫‬‏⁮⁯‬‬‮([In] string obj0, [In] char[] obj1)
    {
      return obj0.Split(obj1);
    }

    static int \u202A‬‎‏‫‍‭‏⁮⁯​⁮‏⁮‭⁫‪⁭⁫‮‫‭⁪⁯‍​‮‮‮⁬‭⁪⁪⁮⁮‪⁭‍⁬‍‮([In] string obj0)
    {
      return obj0.Length;
    }

    static Assembly \u206B​​‌⁯⁪⁯⁯‭‍⁮⁪‌‬‍‍‫‬⁯⁫‎‎‍​‭⁬‌⁮‍⁫‏​⁫​⁪⁯‍‌​‏‮()
    {
      return Assembly.GetExecutingAssembly();
    }

    static AssemblyName \u200C‪‏⁯‪⁭​‫‌‌⁪⁫‍⁫‬⁯‮‪‍⁭⁮⁪‫⁭‫‪⁪‏‪⁬⁬‍⁭​⁯‮‌‌‪‭‮([In] Assembly obj0)
    {
      return obj0.GetName();
    }

    static Version \u206A‬⁬‍‏⁬⁬‌⁫‮‪⁬‭‭⁬‭⁭‬‍⁯‬‭‮‮‪⁯⁯‎‮‮‎‬‪‭‏‮‭‫​⁭‮([In] AssemblyName obj0)
    {
      return obj0.Version;
    }

    static void \u202B‪⁯⁬‪‍‎‭‬⁪⁪​‬‏⁮⁫‌‪‎⁭‭‌‬⁬‪‭‌⁪⁯⁭⁭​⁮‮‭‬⁬⁮‏⁯‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.InfoFormat(obj1, obj2);
    }

    static void \u206A⁯⁮‏‍⁫‮‫‏⁮‭⁪⁫⁫⁯​‮​‬⁯⁮⁬⁫⁫⁮⁫‬‍‎‏⁯⁮‍‬‏⁪‎​⁪‫‮([In] int obj0)
    {
      Environment.Exit(obj0);
    }

    static Process[] \u202E‬‍⁪‏⁮‍‪⁫‬‫‏⁬‮‮‭‭⁫⁭⁬‪‏⁮‎⁮⁯‫‭‏‏‌‮‫‫⁮⁪‫⁮⁫‮‮()
    {
      return Process.GetProcesses();
    }

    static void \u202B‬⁮‍‪⁫‍⁮‍‍‮‫⁯​‬⁮⁬‎‏‮‬⁫‮‮⁭⁪⁭⁬‪‬⁭‪⁬‭‎‏⁭‌⁭‪‮([In] Process obj0)
    {
      obj0.Kill();
    }

    static MethodBase \u202D‮‪⁪⁬‍⁬⁬⁭‪‍⁬‭⁯‍⁯⁪⁮‍‪​​‌‮‌‪⁯‪​‪‮⁯‭⁪⁮⁪⁫‫⁮‎‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202D⁪⁭‏‎‪​⁫‬​‫‏‪‏⁬⁯‭‫‌‬‮⁫⁮⁯‏⁬⁫‫​⁫‎​‮⁮⁮⁮⁪⁭‬‌‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206B⁪‫‌‮⁭⁮⁮‬‎⁮‭⁮‬‫‬⁮‍⁪‍⁮⁬⁭‪‭⁮⁪⁭⁮‫‮‭​⁫‎⁯‪‭‌‎‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static SynchronizationContext \u200C⁮⁪‮​‮‌⁫⁯⁯​‏⁫‭‭‭⁮‌‮⁯‪​‭‪⁮⁯⁬‪⁬‎‫⁪‏‍‫⁬⁭‏‎⁫‮()
    {
      return SynchronizationContext.Current;
    }

    static SynchronizationContext \u202D‏⁮⁪‭⁯‭‏‏‌⁫‪⁭‌‫‎​⁮‫‫‬‍‪⁬​⁬⁬‬‬‫⁯‮⁪⁭⁭‏‭‎⁭‪‮()
    {
      return new SynchronizationContext();
    }

    static object \u200E‮⁪⁪⁭‫⁪‫‍‪​‮⁮‏‮‍⁭⁮‌‭‌⁮‮⁮​​⁭⁫‍⁭⁪‎‪⁯​‮​‪⁯‬‮()
    {
      return new object();
    }

    static Process \u202E‭‮⁯‫‎‭‌‮​‭‬‌⁬⁭‎⁯⁫​⁫‬‎‭‮⁫​‬‮‭⁪‍‌⁭​‪⁮⁯⁪⁫‫‮()
    {
      return Process.GetCurrentProcess();
    }
  }
}
