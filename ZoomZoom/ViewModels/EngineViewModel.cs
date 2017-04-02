// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.EngineViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Telerik.Windows.Controls;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Core;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Images;
using ZoomZoom.Models.Meetings;
using ZoomZoom.Models.Utils;
using ZoomZoom.Models.Windows;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  public class EngineViewModel : ViewModelBase
  {
    private static List<StringItem> meetingIds = new List<StringItem>();
    private static ObservableCollection<StringItem> savedActivities = new ObservableCollection<StringItem>();
    private static ObservableCollection<ZoomMonitor> monitorScreens = new ObservableCollection<ZoomMonitor>();
    private DispatcherTimer windowTimer = (DispatcherTimer) null;
    private ActivityManagerView activityManagerView = (ActivityManagerView) null;
    private string majorStatus = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1981647424U);
    private string minorStatus = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(205193473U);
    private List<string> recentStatuses = new List<string>();
    private CaptureWindowView captureWindow = (CaptureWindowView) null;
    private WindowHighlight highlightWindow = (WindowHighlight) null;
    private ImageHistoryViewModel imageHistoryViewModel = (ImageHistoryViewModel) null;
    private SettingsViewModel settingsViewModel = (SettingsViewModel) null;
    private string logMessage = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(907181687U);
    private bool displayMeetingsControl = false;
    private bool autoAttendent = false;
    private int mainDropDownButtonWidth = 150;
    private int mainDropDownButtonHeight = 150;
    private ButtonEditorView buttonEditorView = (ButtonEditorView) null;
    private int refTimeMs = 0;
    private List<System.Drawing.Point> buttonsInEditor = new List<System.Drawing.Point>();
    private string selectedMeetingId = (string) null;
    private LayoutEditorView layoutEditorView = (LayoutEditorView) null;
    private List<StringItem> availableActivityTypes = new List<StringItem>();
    private string monitor1 = "";
    private string monitor2 = "";
    private string monitor3 = "";
    private string monitor4 = "";
    private string monitor5 = "";
    private string monitor6 = "";
    private List<string> screens = new List<string>();
    private CompositeCommand activityCommand;
    private int locationX;
    private int locationY;
    private bool activityInProgress;
    private RadDesktopAlertManager desktopAlertManager;
    private IntPtr viewHandle;
    private DelegateCommand newActivityCommand;
    private DelegateCommand openActivityCommand;
    private DelegateCommand applyPatternCommand;
    private DelegateCommand editPatternCommand;
    private DelegateCommand deletePatternCommand;
    private DelegateCommand copyPatternCommand;
    private DelegateCommand quickJoinMeetingCommand;
    private DelegateCommand hammerMeetingCommand;
    private DelegateCommand findUserCommand;
    private StringItem selectedActivityType;
    private DelegateCommand cancelActivityCommand;
    private DelegateCommand moveNextMeetingCommand;
    private DelegateCommand leaveMeetingCommand;
    private DelegateCommand closeWindowCommand;
    private DelegateCommand minimizeWindowCommand;
    private DelegateCommand openImageHistoryViewCommand;
    private DelegateCommand queueActivityCommand;
    private LayoutPattern selectedPattern;
    private List<LayoutPattern> patterns;
    private LayoutPattern activePattern;

    public string LogMessage
    {
      get
      {
        return this.logMessage;
      }
      set
      {
label_1:
        int num1 = 1424525096;
        while (true)
        {
          int num2 = 847263867;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2145678028U));
              num1 = (int) num3 * 1785441996 ^ -1471048267;
              continue;
            case 1:
              num1 = (int) num3 * 197926949 ^ -263082172;
              continue;
            case 2:
              goto label_3;
            case 3:
              flag = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.logMessage, value);
              num1 = (int) num3 * 756298774 ^ -1824610594;
              continue;
            case 4:
              goto label_1;
            case 5:
              this.logMessage = value;
              num1 = 1734444955;
              continue;
            case 6:
              num1 = (int) num3 * 908992449 ^ -721850281;
              continue;
            case 7:
              int num4 = flag ? -832039857 : (num4 = -294009229);
              int num5 = (int) num3 * 527143275;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public WindowHighlight HighlightWindow
    {
      get
      {
        return this.highlightWindow;
      }
      set
      {
label_1:
        int num1 = -1902427229;
        while (true)
        {
          int num2 = -1234627272;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              this.highlightWindow = value;
              num1 = (int) num3 * -2132774939 ^ -524596562;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3265620895U));
      }
    }

    public CaptureWindowView CaptureWindow
    {
      get
      {
label_1:
        int num1 = -1754069978;
        CaptureWindowView captureWindow;
        while (true)
        {
          int num2 = -733757435;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              captureWindow = this.captureWindow;
              num1 = (int) num3 * -911569118 ^ 1142001709;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return captureWindow;
      }
      set
      {
label_1:
        int num1 = -1854607244;
        while (true)
        {
          int num2 = -331454474;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3383039970U));
              num1 = (int) num3 * 1211876410 ^ -1996614296;
              continue;
            case 2:
              this.captureWindow = value;
              num1 = (int) num3 * 1185356254 ^ -1154391197;
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

    public ActivityManagerView ActivityManagerView
    {
      get
      {
label_1:
        int num1 = 369671028;
        ActivityManagerView activityManagerView;
        while (true)
        {
          int num2 = 447384398;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -944748217 ^ 1296546029;
              continue;
            case 2:
              activityManagerView = this.activityManagerView;
              num1 = (int) num3 * -2059077550 ^ 1281856619;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return activityManagerView;
      }
      set
      {
        this.activityManagerView = value;
label_1:
        int num1 = 1245574873;
        while (true)
        {
          int num2 = 1045378410;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3985139125U));
              num1 = (int) num3 * -70598665 ^ -826628043;
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

    public new IntPtr ViewHandle
    {
      get
      {
        IntPtr viewHandle = this.viewHandle;
label_1:
        int num1 = -1418612488;
        while (true)
        {
          int num2 = -1744364042;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 281442940 ^ -395374880;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return viewHandle;
      }
      set
      {
label_1:
        int num1 = 867553896;
        while (true)
        {
          int num2 = 1226150027;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              num1 = (int) num3 * 251535630 ^ -909598735;
              continue;
            case 1:
              num1 = (int) num3 * 2096537150 ^ -1924300223;
              continue;
            case 2:
              flag = this.Engine != null;
              num1 = (int) num3 * -2015824905 ^ 1941757568;
              continue;
            case 3:
              int num4 = flag ? 1618238805 : (num4 = 1660102145);
              int num5 = (int) num3 * -2020515405;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * 9254510 ^ 1147800838;
              continue;
            case 5:
              this.viewHandle = value;
              num1 = (int) num3 * -1929267159 ^ 1271535367;
              continue;
            case 6:
              this.Engine.SetMainWindowHandle(this.viewHandle);
              num1 = (int) num3 * 404410462 ^ 65550241;
              continue;
            case 7:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1204558691U));
              num1 = (int) num3 * -662613477 ^ -1688741568;
              continue;
            case 8:
              goto label_1;
            case 9:
              goto label_3;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_3:;
      }
    }

    public string ZoomZoomInformation
    {
      get
      {
label_1:
        int num1 = 931499376;
        string information;
        while (true)
        {
          int num2 = 196562571;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -573816163 ^ -360775388;
              continue;
            case 3:
              information = this.Engine.Settings.Information;
              num1 = (int) num3 * -1684927747 ^ 141201610;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return information;
      }
    }

    public string MajorStatus
    {
      get
      {
label_1:
        int num1 = 1136262946;
        string majorStatus;
        while (true)
        {
          int num2 = 126191547;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              majorStatus = this.majorStatus;
              num1 = (int) num3 * -1111148522 ^ -341105786;
              continue;
            case 3:
              num1 = (int) num3 * 1656145716 ^ 352075061;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return majorStatus;
      }
      set
      {
label_1:
        int num1 = 1020885023;
        while (true)
        {
          int num2 = 535100194;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 1414265103 ^ 1524181785;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num4 = !EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.majorStatus, value) ? 447843893 : (num4 = 831179034);
              int num5 = (int) num3 * -906818198;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * -651996401 ^ 1494275983;
              continue;
            case 5:
              this.majorStatus = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1010330261U));
              num1 = 1823895154;
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

    public string MinorStatus
    {
      get
      {
label_1:
        int num1 = -1481713156;
        string minorStatus;
        while (true)
        {
          int num2 = -1559028610;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1744608390 ^ 983494299;
              continue;
            case 2:
              minorStatus = this.minorStatus;
              num1 = (int) num3 * -1846716682 ^ 632699455;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return minorStatus;
      }
      set
      {
label_1:
        int num1 = 789989052;
        while (true)
        {
          int num2 = 872011748;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.minorStatus = value;
              num1 = 1673224403;
              continue;
            case 1:
              num1 = (int) num3 * -798943682 ^ -36721075;
              continue;
            case 2:
              int num4 = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.minorStatus, value) ? 1593317459 : (num4 = 1467098920);
              int num5 = (int) num3 * -1005139800;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(804157603U));
              num1 = (int) num3 * 167823242 ^ 1271517241;
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
    }

    public string RecentStatuses
    {
      get
      {
label_1:
        int num1 = -748927989;
        string str;
        List<string> recentStatuses;
        while (true)
        {
          int num2 = -1224196327;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              str = string.Empty;
              recentStatuses = this.recentStatuses;
              num1 = (int) num3 * -53084061 ^ -594448818;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮((object) recentStatuses, ref flag);
label_6:
          int num2 = -417194744;
          while (true)
          {
            int num3 = -1224196327;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_6;
              case 1:
                num2 = (int) num4 * 127413331 ^ 909840384;
                continue;
              case 2:
                num2 = (int) num4 * -510709256 ^ 772148506;
                continue;
              default:
                goto label_10;
            }
          }
label_10:
          using (List<string>.Enumerator enumerator = this.recentStatuses.GetEnumerator())
          {
label_16:
            int num3 = !enumerator.MoveNext() ? -937639972 : (num3 = -1636929099);
            while (true)
            {
              int num4 = -1224196327;
              uint num5;
              string current;
              switch ((num5 = (uint) (num3 ^ num4)) % 5U)
              {
                case 0:
                  num3 = -1636929099;
                  continue;
                case 1:
                  str = EngineViewModel.\u200C‍‍⁬‪‬‭⁮⁫⁪‌​⁬‮‪‌‪⁭‏‪​⁬​‪⁬‮‏‎⁯⁪⁭⁫‮‎‪‎‪⁪⁫‌‮(str, current, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(693138702U));
                  num3 = (int) num5 * 120988695 ^ -1906940747;
                  continue;
                case 3:
                  current = enumerator.Current;
                  num3 = -1620937579;
                  continue;
                case 4:
                  goto label_16;
                default:
                  goto label_24;
              }
            }
          }
        }
        finally
        {
          if (flag)
          {
label_19:
            int num2 = -1341046557;
            while (true)
            {
              int num3 = -1224196327;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_19;
                case 2:
                  EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮((object) recentStatuses);
                  num2 = (int) num4 * -1537088129 ^ 2088868928;
                  continue;
                case 3:
                  num2 = (int) num4 * 1923126349 ^ 1626656683;
                  continue;
                default:
                  goto label_23;
              }
            }
          }
label_23:;
        }
label_24:
        return str;
      }
    }

    public ImageHistoryViewModel ImageHistoryViewModel
    {
      get
      {
label_1:
        int num1 = 321569175;
        ImageHistoryViewModel historyViewModel;
        while (true)
        {
          int num2 = 287408268;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              historyViewModel = this.imageHistoryViewModel;
              num1 = 1815012710;
              continue;
            case 1:
              this.imageHistoryViewModel = ((ViewModelLocator) EngineViewModel.\u206C⁮⁫⁬‪⁮‬‭‮⁪‎‬‪‫⁫‍⁫⁯⁯⁪‮‫‎‮‏‮⁬‪⁯‌‭⁮‮‬‭⁯‏​‮‮((FrameworkElement) this.View, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3860284910U))).ImageHistoryViewModel;
              num1 = (int) num3 * 482634450 ^ 1590111548;
              continue;
            case 2:
              int num4 = !flag ? 1020814090 : (num4 = 1832227115);
              int num5 = (int) num3 * 832797300;
              num1 = num4 ^ num5;
              continue;
            case 3:
              flag = this.imageHistoryViewModel == null;
              num1 = (int) num3 * 382695137 ^ -1701980503;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return historyViewModel;
      }
      set
      {
        this.imageHistoryViewModel = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1903185531U));
      }
    }

    public bool DisplayMeetingsControl
    {
      get
      {
label_1:
        int num1 = 897984663;
        bool displayMeetingsControl;
        while (true)
        {
          int num2 = 1619544478;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              displayMeetingsControl = this.displayMeetingsControl;
              num1 = (int) num3 * -275695449 ^ -2073921104;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return displayMeetingsControl;
      }
      set
      {
label_1:
        int num1 = 792662304;
        while (true)
        {
          int num2 = 1657228679;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1525909750 ^ -668218265;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.displayMeetingsControl = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4008272752U));
              num1 = (int) num3 * 365347229 ^ 1974113717;
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

    public SettingsViewModel SettingsViewModel
    {
      get
      {
label_1:
        int num1 = -1352298310;
        SettingsViewModel settingsViewModel;
        while (true)
        {
          int num2 = -2116367797;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num4 = this.settingsViewModel == null ? 1 : 0;
              break;
            case 1:
              if (this.View == null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 1037067214 ^ 1254292629;
              continue;
            case 2:
              settingsViewModel = this.settingsViewModel;
              num1 = -1637847756;
              continue;
            case 3:
              int num5 = !flag ? -1986553221 : (num5 = -973413028);
              int num6 = (int) num3 * 82652590;
              num1 = num5 ^ num6;
              continue;
            case 5:
              this.settingsViewModel = ((ViewModelLocator) EngineViewModel.\u206C⁮⁫⁬‪⁮‬‭‮⁪‎‬‪‫⁫‍⁫⁯⁯⁪‮‫‎‮‏‮⁬‪⁯‌‭⁮‮‬‭⁯‏​‮‮((FrameworkElement) this.View, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1458429715U))).SettingsViewModel;
              num1 = (int) num3 * 293954378 ^ 630511587;
              continue;
            case 6:
              goto label_1;
            case 7:
              num1 = (int) num3 * -748705953 ^ -1907530434;
              continue;
            default:
              goto label_12;
          }
          flag = num4 != 0;
          num1 = -819349360;
        }
label_12:
        return settingsViewModel;
      }
      set
      {
        this.settingsViewModel = value;
label_1:
        int num1 = 782509152;
        while (true)
        {
          int num2 = 1002448181;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -6806977 ^ 1866467111;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(965351369U));
              num1 = (int) num3 * -1171274062 ^ 344985535;
              continue;
            case 2:
              goto label_3;
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

    public int MainDropDownButtonWidth
    {
      get
      {
label_1:
        int num1 = -141127525;
        int dropDownButtonWidth;
        while (true)
        {
          int num2 = -1830222898;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              dropDownButtonWidth = this.mainDropDownButtonWidth;
              num1 = (int) num3 * 1780243052 ^ 1270693135;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dropDownButtonWidth;
      }
      set
      {
label_1:
        int num1 = 1206414579;
        while (true)
        {
          int num2 = 1585953933;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.mainDropDownButtonWidth = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2624079695U));
              num1 = 839346804;
              continue;
            case 1:
              num1 = (int) num3 * -982763438 ^ -1152919267;
              continue;
            case 2:
              int num4 = this.mainDropDownButtonWidth != value ? -758391207 : (num4 = -1789145444);
              int num5 = (int) num3 * -1488675016;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * -370555205 ^ 199437228;
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

    public int MainDropDownButtonHeight
    {
      get
      {
label_1:
        int num1 = -1548908006;
        int downButtonHeight;
        while (true)
        {
          int num2 = -1734736085;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              downButtonHeight = this.mainDropDownButtonHeight;
              num1 = (int) num3 * -913370824 ^ 952941041;
              continue;
            case 2:
              num1 = (int) num3 * 1035435485 ^ -1475351102;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return downButtonHeight;
      }
      set
      {
label_1:
        int num1 = -2099070079;
        while (true)
        {
          int num2 = -1069501753;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.mainDropDownButtonHeight = value;
              num1 = -1306072371;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3791134324U));
              num1 = (int) num3 * 28747607 ^ -1555178252;
              continue;
            case 2:
              int num4 = flag ? -2090582844 : (num4 = -555002111);
              int num5 = (int) num3 * 1554668735;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * -1689156938 ^ -331151560;
              continue;
            case 6:
              flag = this.mainDropDownButtonHeight == value;
              num1 = (int) num3 * -1780991945 ^ -1772604103;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool ActivityInProgress
    {
      get
      {
label_1:
        int num1 = -617452995;
        bool activityInProgress;
        while (true)
        {
          int num2 = -2029442005;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 643143128 ^ 1431008627;
              continue;
            case 2:
              activityInProgress = this.activityInProgress;
              num1 = (int) num3 * -397754666 ^ -1237462118;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return activityInProgress;
      }
      set
      {
        bool flag = this.activityInProgress == value;
label_1:
        int num1 = 998020231;
        while (true)
        {
          int num2 = 1439597245;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              ViewModelBase.log.Info((object) (\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1842694235U) + value.ToString()));
              this.activityInProgress = value;
              num1 = 1773625028;
              continue;
            case 1:
              num1 = (int) num3 * 1012524585 ^ -1769662459;
              continue;
            case 2:
              int num4 = flag ? 929659898 : (num4 = 1401448719);
              int num5 = (int) num3 * -2044696810;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(459516834U));
              num1 = (int) num3 * 2111567428 ^ -49008430;
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
    }

    public int LocationX
    {
      get
      {
        int locationX = this.locationX;
label_1:
        int num1 = 1341729429;
        while (true)
        {
          int num2 = 787792186;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -188547393 ^ -222133240;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return locationX;
      }
      set
      {
        bool flag = this.locationX == value;
label_1:
        int num1 = -616477589;
        while (true)
        {
          int num2 = -1430296078;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3685582700U));
              num1 = (int) num3 * 2052268094 ^ -1911563988;
              continue;
            case 2:
              this.locationX = value;
              WindowHelper.SetForegroundWindow(this.ViewHandle);
              num1 = -249602019;
              continue;
            case 3:
              num1 = (int) num3 * -1176738574 ^ 1239940540;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = flag ? -248290367 : (num4 = -1426151492);
              int num5 = (int) num3 * -1338523070;
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

    public int LocationY
    {
      get
      {
label_1:
        int num1 = -1292939327;
        int locationY;
        while (true)
        {
          int num2 = -1245561204;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              locationY = this.locationY;
              num1 = (int) num3 * -822446827 ^ 1752985246;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 2039030658 ^ 1451056282;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return locationY;
      }
      set
      {
        bool flag = this.locationY == value;
label_1:
        int num1 = -707196076;
        while (true)
        {
          int num2 = -1478371640;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              WindowHelper.SetForegroundWindow(this.ViewHandle);
              num1 = (int) num3 * -364222344 ^ 602731388;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2488303756U));
              num1 = (int) num3 * -2027006805 ^ 1253054186;
              continue;
            case 4:
              num1 = (int) num3 * -1328493658 ^ 1680816844;
              continue;
            case 5:
              this.locationY = value;
              num1 = -2092719428;
              continue;
            case 6:
              int num4 = !flag ? -263205507 : (num4 = -240120401);
              int num5 = (int) num3 * -1095430762;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public ObservableCollection<StringItem> SavedActivities
    {
      get
      {
label_1:
        int num1 = 1860493832;
        ObservableCollection<StringItem> savedActivities;
        while (true)
        {
          int num2 = 183404922;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1212158628 ^ 1279279941;
              continue;
            case 2:
              savedActivities = EngineViewModel.savedActivities;
              num1 = (int) num3 * -885916721 ^ 651740573;
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
        EngineViewModel.savedActivities = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3317572287U));
label_1:
        int num1 = -583565895;
        while (true)
        {
          int num2 = -928359302;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1923589643 ^ -1631212799;
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

    public string SelectedMeetingId
    {
      get
      {
        string selectedMeetingId = this.selectedMeetingId;
label_1:
        int num1 = 1805662297;
        while (true)
        {
          int num2 = 2107979117;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1246925240 ^ -313600503;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedMeetingId;
      }
      set
      {
label_1:
        int num1 = 1697042723;
        while (true)
        {
          int num2 = 1888550794;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              EngineViewModel.\u206E​‍⁬⁫‪‬‮⁮‬⁪‮‌⁮‮⁮​‬‌⁯‭⁫⁭‭⁮‪‮⁮‌‮⁫‎⁯‏​‬⁯‫‪‏‮((DelegateCommandBase) this.quickJoinMeetingCommand);
              num1 = (int) num3 * 2023474635 ^ -1876008245;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = !EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.selectedMeetingId, value) ? -1914256786 : (num4 = -1586925492);
              int num5 = (int) num3 * 340276490;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * 2125968029 ^ -1299430813;
              continue;
            case 5:
              num1 = (int) num3 * -1267592182 ^ -1786834895;
              continue;
            case 6:
              this.selectedMeetingId = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1141490886U));
              EngineViewModel.\u206E​‍⁬⁫‪‬‮⁮‬⁪‮‌⁮‮⁮​‬‌⁯‭⁫⁭‭⁮‪‮⁮‌‮⁫‎⁯‏​‬⁯‫‪‏‮((DelegateCommandBase) this.hammerMeetingCommand);
              num1 = 33441532;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public CompositeCommand ActivityCommand
    {
      get
      {
label_1:
        int num1 = 1004746430;
        CompositeCommand activityCommand;
        while (true)
        {
          int num2 = 1282760461;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -2065533346 ^ -2136317799;
              continue;
            case 3:
              activityCommand = this.activityCommand;
              num1 = (int) num3 * -1997079239 ^ -968670333;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activityCommand;
      }
    }

    public ICommand NewActivityCommand
    {
      get
      {
label_1:
        int num1 = 1444508664;
        ICommand newActivityCommand;
        while (true)
        {
          int num2 = 418186410;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              newActivityCommand = (ICommand) this.newActivityCommand;
              num1 = (int) num3 * 1173766188 ^ 1884278704;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return newActivityCommand;
      }
    }

    public ICommand OpenActivityCommand
    {
      get
      {
label_1:
        int num1 = -597716753;
        ICommand openActivityCommand;
        while (true)
        {
          int num2 = -1239316784;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              openActivityCommand = (ICommand) this.openActivityCommand;
              num1 = (int) num3 * -2058332125 ^ 1428919803;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return openActivityCommand;
      }
    }

    public ICommand HammerMeetingCommand
    {
      get
      {
label_1:
        int num1 = -1825607882;
        ICommand hammerMeetingCommand;
        while (true)
        {
          int num2 = -1301792853;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1746179044 ^ 725330861;
              continue;
            case 1:
              hammerMeetingCommand = (ICommand) this.hammerMeetingCommand;
              num1 = (int) num3 * -1468060701 ^ -308750084;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return hammerMeetingCommand;
      }
    }

    public ICommand FindUserCommand
    {
      get
      {
        return (ICommand) this.findUserCommand;
      }
    }

    public ICommand QuickJoinMeetingCommand
    {
      get
      {
label_1:
        int num1 = -1182635892;
        ICommand joinMeetingCommand;
        while (true)
        {
          int num2 = -971240191;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              joinMeetingCommand = (ICommand) this.quickJoinMeetingCommand;
              num1 = (int) num3 * -259037996 ^ -2008024391;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return joinMeetingCommand;
      }
    }

    public List<StringItem> MeetingIds
    {
      get
      {
label_1:
        int num1 = -1166263527;
        List<StringItem> meetingIds;
        while (true)
        {
          int num2 = -2115184400;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingIds = EngineViewModel.meetingIds;
              num1 = (int) num3 * 1482579334 ^ 2092513749;
              continue;
            case 3:
              num1 = (int) num3 * -719922254 ^ -1335262160;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingIds;
      }
      set
      {
        EngineViewModel.meetingIds = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1637877466U));
      }
    }

    public ICommand CancelActivityCommand
    {
      get
      {
label_1:
        int num1 = -851075786;
        ICommand cancelActivityCommand;
        while (true)
        {
          int num2 = -153534196;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              cancelActivityCommand = (ICommand) this.cancelActivityCommand;
              num1 = (int) num3 * 971507442 ^ 547509720;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return cancelActivityCommand;
      }
    }

    public ICommand MoveNextMeetingCommand
    {
      get
      {
label_1:
        int num1 = -877211169;
        ICommand nextMeetingCommand;
        while (true)
        {
          int num2 = -480248643;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              nextMeetingCommand = (ICommand) this.moveNextMeetingCommand;
              num1 = (int) num3 * -2144147960 ^ 244395704;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return nextMeetingCommand;
      }
    }

    public ICommand LeaveMeetingCommand
    {
      get
      {
label_1:
        int num1 = -1051227742;
        ICommand leaveMeetingCommand;
        while (true)
        {
          int num2 = -176284560;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1702116633 ^ 1059990621;
              continue;
            case 2:
              leaveMeetingCommand = (ICommand) this.leaveMeetingCommand;
              num1 = (int) num3 * -951718820 ^ 272242109;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return leaveMeetingCommand;
      }
    }

    public ICommand CloseWindowCommand
    {
      get
      {
        ICommand closeWindowCommand = (ICommand) this.closeWindowCommand;
label_1:
        int num1 = -1023359947;
        while (true)
        {
          int num2 = -2145648191;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -453013314 ^ -156154230;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return closeWindowCommand;
      }
    }

    public ICommand MinimizeWindowCommand
    {
      get
      {
label_1:
        int num1 = 1597075668;
        ICommand minimizeWindowCommand;
        while (true)
        {
          int num2 = 698626674;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              minimizeWindowCommand = (ICommand) this.minimizeWindowCommand;
              num1 = (int) num3 * -1620245921 ^ -894441889;
              continue;
            case 3:
              num1 = (int) num3 * -221137041 ^ 889203046;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return minimizeWindowCommand;
      }
    }

    public ICommand OpenImageHistoryViewCommand
    {
      get
      {
label_1:
        int num1 = -919159480;
        ICommand historyViewCommand;
        while (true)
        {
          int num2 = -1434149111;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              historyViewCommand = (ICommand) this.openImageHistoryViewCommand;
              num1 = (int) num3 * -693924033 ^ -1713964316;
              continue;
            case 2:
              num1 = (int) num3 * -1818927915 ^ 1651256764;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return historyViewCommand;
      }
    }

    public ICommand QueueActivityCommand
    {
      get
      {
label_1:
        int num1 = 751586101;
        ICommand queueActivityCommand;
        while (true)
        {
          int num2 = 1416873423;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              queueActivityCommand = (ICommand) this.queueActivityCommand;
              num1 = (int) num3 * 1534324237 ^ 1165490508;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return queueActivityCommand;
      }
    }

    public DispatcherTimer WindowTimer
    {
      get
      {
label_1:
        int num1 = 1772788128;
        DispatcherTimer windowTimer;
        while (true)
        {
          int num2 = 2074362493;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              windowTimer = this.windowTimer;
              num1 = (int) num3 * -1277434832 ^ 2140858100;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowTimer;
      }
      set
      {
        this.windowTimer = value;
      }
    }

    public bool ActivitiesEnabled
    {
      get
      {
        return Engine.Instance.Settings.ActivitiesEnabled;
      }
      set
      {
label_1:
        int num1 = 1051639600;
        while (true)
        {
          int num2 = 172201945;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              flag = Engine.Instance.Settings.ActivitiesEnabled == value;
              num1 = (int) num3 * 1886497699 ^ 972537934;
              continue;
            case 2:
              num1 = (int) num3 * -809740954 ^ 117693613;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(491677280U));
              num1 = (int) num3 * 2122345085 ^ -2111729556;
              continue;
            case 4:
              int num4 = flag ? 1116818302 : (num4 = 581458548);
              int num5 = (int) num3 * -528360222;
              num1 = num4 ^ num5;
              continue;
            case 5:
              Engine.Instance.Settings.ActivitiesEnabled = value;
              num1 = 1761000074;
              continue;
            case 6:
              goto label_1;
            case 7:
              num1 = (int) num3 * 1908719430 ^ 2131494011;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public bool ApplyLayoutPattern
    {
      get
      {
label_1:
        int num1 = -2029699525;
        bool applyLayoutPattern;
        while (true)
        {
          int num2 = -753394231;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              applyLayoutPattern = Engine.Instance.Settings.ApplyLayoutPattern;
              num1 = (int) num3 * -389142415 ^ 213943748;
              continue;
            case 3:
              num1 = (int) num3 * -967731923 ^ -1673910849;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return applyLayoutPattern;
      }
      set
      {
        if (Engine.Instance.Settings.ApplyLayoutPattern != value)
          goto label_5;
label_1:
        int num1 = 1438894561;
label_2:
        while (true)
        {
          int num2 = 493710375;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_5;
            case 1:
              num1 = (int) num3 * -1938519831 ^ 1463763221;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * 656847382 ^ 777376460;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        Engine.Instance.Settings.ApplyLayoutPattern = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2921942983U));
        num1 = 108714994;
        goto label_2;
      }
    }

    public bool AutoAttendent
    {
      get
      {
label_1:
        int num1 = 1142930560;
        bool autoAttendent;
        while (true)
        {
          int num2 = 777952041;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              autoAttendent = Engine.Instance.Settings.AutoAttendent;
              num1 = (int) num3 * 274738028 ^ 721806867;
              continue;
            case 2:
              num1 = (int) num3 * 277394852 ^ -1675914599;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return autoAttendent;
      }
      set
      {
label_1:
        int num1 = -1778523567;
        while (true)
        {
          int num2 = -495377177;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 760035249 ^ -1382353714;
              continue;
            case 1:
              Engine.Instance.Settings.AutoAttendent = value;
              num1 = -422999687;
              continue;
            case 2:
              num1 = (int) num3 * 375515177 ^ -1592583708;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3882331782U));
              num1 = (int) num3 * 697001765 ^ -1450442560;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = Engine.Instance.Settings.AutoAttendent == value ? 693547248 : (num4 = 1102969313);
              int num5 = (int) num3 * -1723645588;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool ZoomZoomDockingEnabled
    {
      get
      {
label_1:
        int num1 = 1289808150;
        bool zoomDockingEnabled;
        while (true)
        {
          int num2 = 1912607293;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              zoomDockingEnabled = Engine.Instance.Settings.ZoomZoomDockingEnabled;
              num1 = (int) num3 * -1799385345 ^ -380425293;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomDockingEnabled;
      }
      set
      {
        bool flag = Engine.Instance.Settings.ZoomZoomDockingEnabled == value;
label_1:
        int num1 = 473157228;
        while (true)
        {
          int num2 = 1647350726;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1113257969U));
              num1 = (int) num3 * 905518732 ^ 1941159005;
              continue;
            case 1:
              num1 = (int) num3 * -538718294 ^ -1183505377;
              continue;
            case 2:
              int num4 = flag ? -612401881 : (num4 = -1552452237);
              int num5 = (int) num3 * -1169936584;
              num1 = num4 ^ num5;
              continue;
            case 3:
              Engine.Instance.Settings.ZoomZoomDockingEnabled = value;
              num1 = 433348208;
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
    }

    public bool VideoChatLinkAutoInitiate
    {
      get
      {
        bool linkAutoInitiate = this.Engine.Settings.VideoChatLinkAutoInitiate;
label_1:
        int num1 = 173206698;
        while (true)
        {
          int num2 = 1438781344;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1118902321 ^ 1978706719;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return linkAutoInitiate;
      }
      set
      {
label_1:
        int num1 = -2135989033;
        while (true)
        {
          int num2 = -622793233;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.Engine.Settings.VideoChatLinkAutoInitiate = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(160042945U));
              num1 = (int) num3 * 1334703030 ^ 1692589100;
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

    public List<LayoutPattern> Patterns
    {
      get
      {
label_1:
        int num1 = -673535579;
        List<LayoutPattern> patterns;
        while (true)
        {
          int num2 = -954591101;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 695758443 ^ -327211076;
              continue;
            case 2:
              patterns = this.patterns;
              num1 = (int) num3 * -510507193 ^ 1653798348;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return patterns;
      }
      set
      {
label_1:
        int num1 = -1301461374;
        while (true)
        {
          int num2 = -323079380;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.patterns = value;
              num1 = (int) num3 * -1746649403 ^ 686717485;
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

    public LayoutPattern SelectedPattern
    {
      get
      {
label_1:
        int num1 = 116369848;
        LayoutPattern selectedPattern;
        while (true)
        {
          int num2 = 1581116476;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              selectedPattern = this.selectedPattern;
              num1 = (int) num3 * 1844865559 ^ 985499804;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedPattern;
      }
      set
      {
label_1:
        int num1 = 1829564941;
        while (true)
        {
          int num2 = 1750579682;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.selectedPattern = value;
              num1 = 1530768612;
              continue;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 509812551 ^ -1642514183;
              continue;
            case 3:
              goto label_1;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2355156330U));
              num1 = (int) num3 * -1930587014 ^ -2034395017;
              continue;
            case 5:
              int num4 = this.selectedPattern != value ? -1113091056 : (num4 = -647013984);
              int num5 = (int) num3 * 1516378980;
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

    public LayoutEditorView LayoutEditorView
    {
      get
      {
        return this.layoutEditorView;
      }
      set
      {
        this.layoutEditorView = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3523110802U));
      }
    }

    public LayoutPattern ActivePattern
    {
      get
      {
        LayoutPattern activePattern = this.activePattern;
label_1:
        int num1 = 1311021935;
        while (true)
        {
          int num2 = 986029868;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -232377690 ^ -695721831;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return activePattern;
      }
      set
      {
        this.activePattern = value;
      }
    }

    public List<StringItem> AvailableActivityTypes
    {
      get
      {
label_1:
        int num1 = 1975605127;
        List<StringItem> availableActivityTypes;
        while (true)
        {
          int num2 = 1909231555;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              availableActivityTypes = this.availableActivityTypes;
              num1 = (int) num3 * 905750806 ^ 1237024838;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return availableActivityTypes;
      }
      set
      {
        if (this.availableActivityTypes != value)
          goto label_5;
label_1:
        int num1 = -1647037728;
label_2:
        while (true)
        {
          int num2 = -1314779982;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 1100994179 ^ -1652561023;
              continue;
            case 3:
              goto label_5;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:
        return;
label_5:
        this.availableActivityTypes = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2358319266U));
        num1 = -2097707913;
        goto label_2;
      }
    }

    public StringItem SelectedActivityType
    {
      get
      {
        StringItem selectedActivityType = this.selectedActivityType;
label_1:
        int num1 = -1319608480;
        while (true)
        {
          int num2 = -26276924;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1011386649 ^ -1614390898;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedActivityType;
      }
      set
      {
label_1:
        int num1 = 471720804;
        while (true)
        {
          int num2 = 1861380372;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              this.selectedActivityType = this.AvailableActivityTypes[0];
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1314002810U));
              num1 = (int) num3 * -1149461929 ^ 1489607159;
              continue;
            case 1:
              flag1 = this.selectedActivityType == value;
              num1 = (int) num3 * 109584737 ^ -359613372;
              continue;
            case 2:
              if (value != null)
              {
                num1 = 1686740082;
                continue;
              }
              num4 = 0;
              break;
            case 3:
              num1 = (int) num3 * -945816516 ^ -1633567993;
              continue;
            case 4:
              num1 = (int) num3 * 675132246 ^ -1383158342;
              continue;
            case 5:
              goto label_3;
            case 6:
              this.QueueActivity();
              num1 = (int) num3 * 1679879097 ^ 88500424;
              continue;
            case 7:
              int num5 = !flag1 ? 539502518 : (num5 = 1845010903);
              int num6 = (int) num3 * 1322057000;
              num1 = num5 ^ num6;
              continue;
            case 8:
              num4 = !EngineViewModel.\u202A⁪⁬‍⁬⁯‭‌⁭‏⁫⁯​‌⁭⁬‫​‮‭‮‫‍⁯⁬​⁪‭‍‮‪‮⁯⁯‪⁪‭‎⁯‬‮(value.Value) ? 1 : 0;
              break;
            case 9:
              int num7 = !flag2 ? 1463350960 : (num7 = 1446606685);
              int num8 = (int) num3 * -1494167335;
              num1 = num7 ^ num8;
              continue;
            case 10:
              this.selectedActivityType = value;
              num1 = (int) num3 * -945383537 ^ -443520917;
              continue;
            case 11:
              num1 = (int) num3 * -1332086030 ^ -371818043;
              continue;
            case 12:
              goto label_1;
            default:
              goto label_18;
          }
          flag2 = num4 != 0;
          num1 = 1712809775;
        }
label_18:
        return;
label_3:;
      }
    }

    public bool AutoattendentMinimumParticipantsEnforced
    {
      get
      {
label_1:
        int num1 = 1663397083;
        bool minimumUserEnforced;
        while (true)
        {
          int num2 = 1976328293;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              minimumUserEnforced = Engine.Instance.Settings.MinimumUserEnforced;
              num1 = (int) num3 * 1566224242 ^ 233128284;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return minimumUserEnforced;
      }
      set
      {
        if (Engine.Instance.Settings.MinimumUserEnforced != value)
          goto label_7;
label_1:
        int num1 = -353473382;
label_2:
        while (true)
        {
          int num2 = -1250731883;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3023028237U));
              num1 = (int) num3 * 1858728226 ^ 103532647;
              continue;
            case 1:
              num1 = (int) num3 * -953045362 ^ 166831808;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_7;
            case 4:
              num1 = (int) num3 * 905341486 ^ -1126215370;
              continue;
            case 5:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:
        return;
label_7:
        Engine.Instance.Settings.MinimumUserEnforced = value;
        num1 = -191600845;
        goto label_2;
      }
    }

    public int AutoattendentMinimumParticipants
    {
      get
      {
label_1:
        int num1 = 1410014549;
        int minimumUserCount;
        while (true)
        {
          int num2 = 606372856;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              minimumUserCount = Engine.Instance.Settings.MinimumUserCount;
              num1 = (int) num3 * -1975463902 ^ -366381300;
              continue;
            case 2:
              num1 = (int) num3 * 1078640832 ^ -553416596;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return minimumUserCount;
      }
      set
      {
label_1:
        int num1 = 1250426940;
        while (true)
        {
          int num2 = 997285759;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              Engine.Instance.Settings.MinimumUserCount = value;
              num1 = 719933393;
              continue;
            case 2:
              num1 = (int) num3 * -39529532 ^ -1299232245;
              continue;
            case 3:
              flag = Engine.Instance.Settings.MinimumUserCount == value;
              num1 = (int) num3 * 203848249 ^ 2139276435;
              continue;
            case 4:
              goto label_3;
            case 5:
              num1 = (int) num3 * 995978287 ^ -713460152;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2841003233U));
              num1 = (int) num3 * 202464068 ^ -785548555;
              continue;
            case 7:
              int num4 = !flag ? 84249517 : (num4 = 1074661289);
              int num5 = (int) num3 * -587476107;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public bool AutoattendentMaximumDurationEnforced
    {
      get
      {
        bool durationEnforced = Engine.Instance.Settings.AutoattendentMaximumDurationEnforced;
label_1:
        int num1 = -449547467;
        while (true)
        {
          int num2 = -348842456;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -664456878 ^ -1886047667;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return durationEnforced;
      }
      set
      {
label_1:
        int num1 = -609702944;
        while (true)
        {
          int num2 = -1212073871;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * 1461515861 ^ -1520667341;
              continue;
            case 1:
              flag = Engine.Instance.Settings.AutoattendentMaximumDurationEnforced == value;
              num1 = (int) num3 * -1994688605 ^ -236403070;
              continue;
            case 2:
              int num4 = flag ? -1617012921 : (num4 = -844212458);
              int num5 = (int) num3 * -1656020542;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(606437380U));
              num1 = (int) num3 * -1418115016 ^ -37656732;
              continue;
            case 4:
              num1 = (int) num3 * 1407695879 ^ -613381571;
              continue;
            case 5:
              num1 = (int) num3 * -1198648951 ^ 680944;
              continue;
            case 6:
              Engine.Instance.Settings.AutoattendentMaximumDurationEnforced = value;
              num1 = -1142658793;
              continue;
            case 7:
              goto label_3;
            case 8:
              goto label_1;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public double AutoattendentMaximumDuration
    {
      get
      {
        double attendenceDuration = Engine.Instance.Settings.MaximumAttendenceDuration;
label_1:
        int num1 = 303960904;
        while (true)
        {
          int num2 = 677992802;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 300570271 ^ -1900085859;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return attendenceDuration;
      }
      set
      {
        bool flag = Engine.Instance.Settings.MaximumAttendenceDuration == value;
label_1:
        int num1 = -684939747;
        while (true)
        {
          int num2 = -1574947134;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2936469119U));
              num1 = (int) num3 * 2052526103 ^ -1258435261;
              continue;
            case 1:
              int num4 = flag ? -1773523733 : (num4 = -1152726697);
              int num5 = (int) num3 * 379072021;
              num1 = num4 ^ num5;
              continue;
            case 2:
              Engine.Instance.Settings.MaximumAttendenceDuration = value;
              num1 = -241017200;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * 1184967823 ^ 347386531;
              continue;
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
    }

    public MeetingEventAction MeetingRemovalAction
    {
      get
      {
label_1:
        int num1 = -1964325486;
        MeetingEventAction meetingRemovalAction;
        while (true)
        {
          int num2 = -222704320;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meetingRemovalAction = Engine.Instance.Settings.MeetingRemovalAction;
              num1 = (int) num3 * 543529117 ^ 1062594775;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingRemovalAction;
      }
      set
      {
label_1:
        int num1 = 826784320;
        while (true)
        {
          int num2 = 435303124;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 777516887 ^ -1179762054;
              continue;
            case 2:
              Engine.Instance.Settings.MeetingRemovalAction = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1874048247U));
              num1 = 2068864857;
              continue;
            case 3:
              num1 = (int) num3 * -473072905 ^ 183484804;
              continue;
            case 4:
              int num4 = Engine.Instance.Settings.MeetingRemovalAction == value ? 1910311 : (num4 = 1337511190);
              int num5 = (int) num3 * -607399624;
              num1 = num4 ^ num5;
              continue;
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
    }

    public MeetingEventAction MeetingHoldAction
    {
      get
      {
label_1:
        int num1 = -1574773463;
        MeetingEventAction meetingHoldAction;
        while (true)
        {
          int num2 = -582455469;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 812180594 ^ -166126971;
              continue;
            case 2:
              meetingHoldAction = Engine.Instance.Settings.MeetingHoldAction;
              num1 = (int) num3 * -942119109 ^ 1655381756;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingHoldAction;
      }
      set
      {
label_1:
        int num1 = -1385615545;
        while (true)
        {
          int num2 = -641347958;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = !flag ? 354131714 : (num4 = 2034867079);
              int num5 = (int) num3 * 1257997375;
              num1 = num4 ^ num5;
              continue;
            case 1:
              Engine.Instance.Settings.MeetingHoldAction = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2968147956U));
              num1 = -3283942;
              continue;
            case 2:
              num1 = (int) num3 * -153594404 ^ 1526066890;
              continue;
            case 3:
              num1 = (int) num3 * -1602432838 ^ -1881202456;
              continue;
            case 4:
              flag = Engine.Instance.Settings.MeetingHoldAction == value;
              num1 = (int) num3 * -382793965 ^ -1812584219;
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

    public bool AutoCaptureVideoImages
    {
      get
      {
label_1:
        int num1 = 956024166;
        bool captureVideoImages;
        while (true)
        {
          int num2 = 1328763967;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              captureVideoImages = Engine.Instance.Settings.AutoCaptureVideoImages;
              num1 = (int) num3 * -891434629 ^ -1312848477;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return captureVideoImages;
      }
      set
      {
label_1:
        int num1 = 999334131;
        while (true)
        {
          int num2 = 167056353;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              Engine.Instance.Settings.AutoCaptureVideoImages = value;
              num1 = 36880090;
              continue;
            case 1:
              int num4 = flag ? -1103097772 : (num4 = -2037047710);
              int num5 = (int) num3 * 284973579;
              num1 = num4 ^ num5;
              continue;
            case 2:
              flag = Engine.Instance.Settings.AutoCaptureVideoImages == value;
              num1 = (int) num3 * 1283391775 ^ -1256435082;
              continue;
            case 3:
              num1 = (int) num3 * 751598717 ^ -765219693;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(876226334U));
              num1 = (int) num3 * -1478466682 ^ -1409195741;
              continue;
            case 6:
              num1 = (int) num3 * 1749332517 ^ -1991750445;
              continue;
            case 7:
              goto label_1;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public bool AutoSpotlightEnabled
    {
      get
      {
label_1:
        int num1 = -1908475284;
        bool spotlightEnabled;
        while (true)
        {
          int num2 = -1148587282;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1556250162 ^ 1329972783;
              continue;
            case 2:
              spotlightEnabled = Engine.Instance.Settings.AutoSpotlightEnabled;
              num1 = (int) num3 * -814440260 ^ 1423007131;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return spotlightEnabled;
      }
      set
      {
        bool flag = Engine.Instance.Settings.AutoSpotlightEnabled == value;
label_1:
        int num1 = 208289766;
        while (true)
        {
          int num2 = 1742227138;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              Engine.Instance.Settings.AutoSpotlightEnabled = value;
              num1 = 2032026724;
              continue;
            case 2:
              num1 = (int) num3 * 834636844 ^ 944776234;
              continue;
            case 3:
              num1 = (int) num3 * 774496338 ^ 594821700;
              continue;
            case 4:
              int num4 = !flag ? 1835709611 : (num4 = 573469664);
              int num5 = (int) num3 * 656910362;
              num1 = num4 ^ num5;
              continue;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1788795482U));
              num1 = (int) num3 * -185173557 ^ 2060308038;
              continue;
            case 6:
              num1 = (int) num3 * -1517263904 ^ -1720576761;
              continue;
            case 7:
              goto label_1;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public double AutoSpotlightInterval
    {
      get
      {
label_1:
        int num1 = 1341447318;
        double spotlightInterval;
        while (true)
        {
          int num2 = 1386894885;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              spotlightInterval = Engine.Instance.Settings.AutoSpotlightInterval;
              num1 = (int) num3 * 803551367 ^ 1734842779;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return spotlightInterval;
      }
      set
      {
        bool flag = Engine.Instance.Settings.AutoSpotlightInterval == value;
label_1:
        int num1 = -66971524;
        while (true)
        {
          int num2 = -1841177895;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3373331641U));
              num1 = (int) num3 * 1533290282 ^ 377849065;
              continue;
            case 2:
              int num4 = flag ? 532176499 : (num4 = 1749601833);
              int num5 = (int) num3 * 1501286286;
              num1 = num4 ^ num5;
              continue;
            case 3:
              Engine.Instance.Settings.AutoSpotlightInterval = value;
              num1 = -67240648;
              continue;
            case 4:
              num1 = (int) num3 * -332171586 ^ -366765341;
              continue;
            case 5:
              num1 = (int) num3 * 245316634 ^ 1091777135;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public double AutoCaptureVideoInterval
    {
      get
      {
label_1:
        int num1 = 767515126;
        double captureVideoInterval;
        while (true)
        {
          int num2 = 1445765551;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              captureVideoInterval = Engine.Instance.Settings.AutoCaptureVideoInterval;
              num1 = (int) num3 * 936200614 ^ 1767801720;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return captureVideoInterval;
      }
      set
      {
label_1:
        int num1 = 1449772956;
        while (true)
        {
          int num2 = 24851945;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -671309819 ^ -1922489867;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(436605342U));
              num1 = (int) num3 * -1965382872 ^ -883402686;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 974865073 ^ -1591028946;
              continue;
            case 4:
              goto label_3;
            case 5:
              flag = Engine.Instance.Settings.AutoCaptureVideoInterval == value;
              num1 = (int) num3 * 507184405 ^ 1793806798;
              continue;
            case 6:
              int num4 = !flag ? -1630714364 : (num4 = -2070208741);
              int num5 = (int) num3 * -1494764621;
              num1 = num4 ^ num5;
              continue;
            case 7:
              Engine.Instance.Settings.AutoCaptureVideoInterval = value;
              num1 = 2035138616;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public bool TraceHookEvents
    {
      get
      {
        return Engine.Instance.Settings.TraceHookEvents;
      }
      set
      {
label_1:
        int num1 = -1910582389;
        while (true)
        {
          int num2 = -71272216;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              Engine.Instance.Settings.TraceHookEvents = value;
              num1 = -993155098;
              continue;
            case 3:
              int num4 = Engine.Instance.Settings.TraceHookEvents == value ? -1945647968 : (num4 = -567353327);
              int num5 = (int) num3 * -2098284725;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2173442001U));
              num1 = (int) num3 * 584744830 ^ 956970209;
              continue;
            case 5:
              num1 = (int) num3 * 671905409 ^ -2095833140;
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

    public bool TraceWindowEvents
    {
      get
      {
label_1:
        int num1 = -410796394;
        bool traceWindowEvents;
        while (true)
        {
          int num2 = -1956961335;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1771844034 ^ -1973151824;
              continue;
            case 2:
              goto label_1;
            case 3:
              traceWindowEvents = Engine.Instance.Settings.TraceWindowEvents;
              num1 = (int) num3 * -419202129 ^ -1549331988;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceWindowEvents;
      }
      set
      {
label_1:
        int num1 = -450016429;
        while (true)
        {
          int num2 = -85529748;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(242356148U));
              num1 = (int) num3 * -23184367 ^ 426390874;
              continue;
            case 1:
              num1 = (int) num3 * 418988729 ^ -1815556520;
              continue;
            case 2:
              int num4 = !flag ? 846992281 : (num4 = 306697715);
              int num5 = (int) num3 * -1457072923;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 1539087143 ^ 334913373;
              continue;
            case 4:
              flag = Engine.Instance.Settings.TraceWindowEvents == value;
              num1 = (int) num3 * -1191075630 ^ 33571517;
              continue;
            case 5:
              goto label_1;
            case 6:
              num1 = (int) num3 * 167490345 ^ -926909846;
              continue;
            case 7:
              Engine.Instance.Settings.TraceWindowEvents = value;
              num1 = -856918541;
              continue;
            case 8:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public bool TraceChatEvents
    {
      get
      {
label_1:
        int num1 = 1491968011;
        bool traceChatEvents;
        while (true)
        {
          int num2 = 246255202;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              traceChatEvents = Engine.Instance.Settings.TraceChatEvents;
              num1 = (int) num3 * -978111730 ^ -1918295789;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1524691803 ^ 911590487;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceChatEvents;
      }
      set
      {
        if (Engine.Instance.Settings.TraceChatEvents != value)
          goto label_7;
label_1:
        int num1 = -319158029;
label_2:
        while (true)
        {
          int num2 = -782229800;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_7;
            case 1:
              num1 = (int) num3 * -33524018 ^ -1022626562;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1143477687U));
              num1 = (int) num3 * 1552432510 ^ -583820585;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * -822836626 ^ -1430323918;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:
        return;
label_7:
        Engine.Instance.Settings.TraceChatEvents = value;
        num1 = -1409486089;
        goto label_2;
      }
    }

    public bool TraceActivityEvents
    {
      get
      {
        return Engine.Instance.Settings.TraceActivityEvents;
      }
      set
      {
        bool flag = Engine.Instance.Settings.TraceActivityEvents == value;
label_1:
        int num1 = -701479511;
        while (true)
        {
          int num2 = -4141182;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * 1870139699 ^ 1442963437;
              continue;
            case 1:
              num1 = (int) num3 * 1191915522 ^ 1745146916;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = flag ? 625812287 : (num4 = 358758242);
              int num5 = (int) num3 * 2064176383;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3145512107U));
              num1 = (int) num3 * 1674342197 ^ 1468396784;
              continue;
            case 5:
              Engine.Instance.Settings.TraceActivityEvents = value;
              num1 = -1441702445;
              continue;
            case 6:
              num1 = (int) num3 * -758151440 ^ 1329794293;
              continue;
            case 7:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public bool TraceMeetingEvents
    {
      get
      {
label_1:
        int num1 = 253036605;
        bool traceMeetingEvents;
        while (true)
        {
          int num2 = 149991495;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              traceMeetingEvents = Engine.Instance.Settings.TraceMeetingEvents;
              num1 = (int) num3 * 780430236 ^ -1672699560;
              continue;
            case 3:
              num1 = (int) num3 * 88258456 ^ -1170557258;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceMeetingEvents;
      }
      set
      {
        bool flag = Engine.Instance.Settings.TraceMeetingEvents == value;
label_1:
        int num1 = -2042968108;
        while (true)
        {
          int num2 = -138790686;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 455310911 ^ 1077834525;
              continue;
            case 1:
              int num4 = !flag ? -1057458686 : (num4 = -1703257624);
              int num5 = (int) num3 * -249276670;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 1004930237 ^ 1920854117;
              continue;
            case 4:
              goto label_1;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3625343813U));
              num1 = (int) num3 * 1539195924 ^ 406754603;
              continue;
            case 6:
              Engine.Instance.Settings.TraceMeetingEvents = value;
              num1 = -47957878;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool TraceDataStorage
    {
      get
      {
label_1:
        int num1 = 1004302555;
        bool traceDataStorage;
        while (true)
        {
          int num2 = 977516642;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              traceDataStorage = Engine.Instance.Settings.TraceDataStorage;
              num1 = (int) num3 * 1427599910 ^ -635227701;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 522672586 ^ 609327912;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceDataStorage;
      }
      set
      {
label_1:
        int num1 = -684015825;
        while (true)
        {
          int num2 = -553881747;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3062599088U));
              num1 = (int) num3 * -800712914 ^ 1577137350;
              continue;
            case 2:
              flag = Engine.Instance.Settings.TraceDataStorage == value;
              num1 = (int) num3 * -790341600 ^ 1021188123;
              continue;
            case 3:
              num1 = (int) num3 * -1134141953 ^ -2049470012;
              continue;
            case 4:
              goto label_3;
            case 5:
              num1 = (int) num3 * 691920406 ^ -207456233;
              continue;
            case 6:
              int num4 = flag ? -1912362036 : (num4 = -732223688);
              int num5 = (int) num3 * 1861953027;
              num1 = num4 ^ num5;
              continue;
            case 7:
              Engine.Instance.Settings.TraceDataStorage = value;
              num1 = -1061191876;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public bool TraceLayoutEvents
    {
      get
      {
label_1:
        int num1 = -1575124949;
        bool traceLayoutEvents;
        while (true)
        {
          int num2 = -9370238;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              traceLayoutEvents = Engine.Instance.Settings.TraceLayoutEvents;
              num1 = (int) num3 * 693286266 ^ -1720325769;
              continue;
            case 3:
              num1 = (int) num3 * -640704424 ^ -700099520;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceLayoutEvents;
      }
      set
      {
label_1:
        int num1 = -322963214;
        while (true)
        {
          int num2 = -826361466;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = !flag ? 1751711845 : (num4 = 270521782);
              int num5 = (int) num3 * -248743349;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -1856501586 ^ -1575859713;
              continue;
            case 3:
              goto label_1;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1744479603U));
              num1 = (int) num3 * 1149971153 ^ -1800623731;
              continue;
            case 5:
              Engine.Instance.Settings.TraceLayoutEvents = value;
              num1 = -2030101956;
              continue;
            case 6:
              flag = Engine.Instance.Settings.TraceLayoutEvents == value;
              num1 = (int) num3 * -231657133 ^ -1048711570;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool TraceImageEvents
    {
      get
      {
        return Engine.Instance.Settings.TraceImageEvents;
      }
      set
      {
label_1:
        int num1 = -634370281;
        while (true)
        {
          int num2 = -1272640778;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              Engine.Instance.Settings.TraceImageEvents = value;
              num1 = -269989786;
              continue;
            case 1:
              num1 = (int) num3 * -382833079 ^ 490951702;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              int num4 = flag ? -411982725 : (num4 = -1967329176);
              int num5 = (int) num3 * 1859017946;
              num1 = num4 ^ num5;
              continue;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3403207929U));
              num1 = (int) num3 * -768887106 ^ -2115487991;
              continue;
            case 6:
              num1 = (int) num3 * -630284092 ^ 837953461;
              continue;
            case 7:
              flag = Engine.Instance.Settings.TraceImageEvents == value;
              num1 = (int) num3 * -228232565 ^ 2078297291;
              continue;
            case 8:
              num1 = (int) num3 * -1806970 ^ -414951442;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public bool TraceUserEvents
    {
      get
      {
label_1:
        int num1 = 458588009;
        bool traceUserEvents;
        while (true)
        {
          int num2 = 1497912535;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              traceUserEvents = Engine.Instance.Settings.TraceUserEvents;
              num1 = (int) num3 * 1785297640 ^ 521887133;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceUserEvents;
      }
      set
      {
label_1:
        int num1 = -1320409204;
        while (true)
        {
          int num2 = -377369694;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = flag ? -1853437819 : (num4 = -720810168);
              int num5 = (int) num3 * 1549980653;
              num1 = num4 ^ num5;
              continue;
            case 2:
              flag = Engine.Instance.Settings.TraceUserEvents == value;
              num1 = (int) num3 * 1205356197 ^ 1569074615;
              continue;
            case 3:
              Engine.Instance.Settings.TraceUserEvents = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3190907328U));
              num1 = -709729600;
              continue;
            case 4:
              num1 = (int) num3 * 1445131796 ^ -1061412480;
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

    public bool TraceUserInterfaceEvents
    {
      get
      {
label_1:
        int num1 = 2089668696;
        bool userInterfaceEvents;
        while (true)
        {
          int num2 = 532602217;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              userInterfaceEvents = Engine.Instance.Settings.TraceUserInterfaceEvents;
              num1 = (int) num3 * -1044842290 ^ -2001737584;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return userInterfaceEvents;
      }
      set
      {
        bool flag = Engine.Instance.Settings.TraceUserInterfaceEvents == value;
label_1:
        int num1 = 943247101;
        while (true)
        {
          int num2 = 975493311;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(918824148U));
              num1 = (int) num3 * -1119002044 ^ -1997081772;
              continue;
            case 1:
              num1 = (int) num3 * 185542782 ^ -255279291;
              continue;
            case 2:
              int num4 = flag ? -161539764 : (num4 = -1451261301);
              int num5 = (int) num3 * 2095731376;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
            case 4:
              Engine.Instance.Settings.TraceUserInterfaceEvents = value;
              num1 = 1574813313;
              continue;
            case 5:
              goto label_1;
            case 6:
              num1 = (int) num3 * 1721322524 ^ 1361905419;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool TraceApplicationEvents
    {
      get
      {
label_1:
        int num1 = 1196158635;
        bool applicationEvents;
        while (true)
        {
          int num2 = 1628941364;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              applicationEvents = Engine.Instance.Settings.TraceApplicationEvents;
              num1 = (int) num3 * -246054403 ^ 1627467373;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return applicationEvents;
      }
      set
      {
label_1:
        int num1 = 731336065;
        while (true)
        {
          int num2 = 1614481959;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = flag ? -1301614612 : (num4 = -1591645437);
              int num5 = (int) num3 * 134825912;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag = Engine.Instance.Settings.TraceApplicationEvents == value;
              num1 = (int) num3 * -659522994 ^ 759441306;
              continue;
            case 2:
              num1 = (int) num3 * -1742787497 ^ 636319267;
              continue;
            case 3:
              num1 = (int) num3 * 302476841 ^ -369549316;
              continue;
            case 4:
              Engine.Instance.Settings.TraceApplicationEvents = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1700163724U));
              num1 = 918126219;
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

    public ICommand DeletePatternCommand
    {
      get
      {
        return (ICommand) this.deletePatternCommand;
      }
    }

    public ICommand EditPatternCommand
    {
      get
      {
label_1:
        int num1 = 261998304;
        ICommand editPatternCommand;
        while (true)
        {
          int num2 = 1094588749;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              editPatternCommand = (ICommand) this.editPatternCommand;
              num1 = (int) num3 * 346907752 ^ -1471476962;
              continue;
            case 3:
              num1 = (int) num3 * -1565468937 ^ 1858451854;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return editPatternCommand;
      }
    }

    public ICommand ApplyPatternCommand
    {
      get
      {
label_1:
        int num1 = -1061669917;
        ICommand applyPatternCommand;
        while (true)
        {
          int num2 = -93724443;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              applyPatternCommand = (ICommand) this.applyPatternCommand;
              num1 = (int) num3 * -217209191 ^ 1411496686;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return applyPatternCommand;
      }
    }

    public ICommand CopyPatternCommand
    {
      get
      {
label_1:
        int num1 = -675695712;
        ICommand copyPatternCommand;
        while (true)
        {
          int num2 = -289461790;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -374196521 ^ 1194361765;
              continue;
            case 2:
              copyPatternCommand = (ICommand) this.copyPatternCommand;
              num1 = (int) num3 * 339072451 ^ -344366211;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return copyPatternCommand;
      }
    }

    public List<System.Drawing.Point> ButtonsInEditor
    {
      get
      {
        List<System.Drawing.Point> buttonsInEditor1 = this.ButtonsInEditor1;
label_1:
        int num1 = -2138334210;
        while (true)
        {
          int num2 = -685065885;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1754460430 ^ -469535738;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return buttonsInEditor1;
      }
      set
      {
        this.ButtonsInEditor1 = value;
      }
    }

    public List<System.Drawing.Point> ButtonsInEditor1
    {
      get
      {
        return this.buttonsInEditor;
      }
      set
      {
        this.buttonsInEditor = value;
      }
    }

    public ButtonEditorView ButtonEditorView
    {
      get
      {
label_1:
        int num1 = 1748650815;
        ButtonEditorView buttonEditorView;
        while (true)
        {
          int num2 = 1376306554;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              buttonEditorView = this.buttonEditorView;
              num1 = (int) num3 * 1649206421 ^ -825279157;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return buttonEditorView;
      }
      set
      {
        this.buttonEditorView = value;
      }
    }

    public string AdminRightClickAction
    {
      get
      {
label_1:
        int num1 = -236973120;
        string rightClickAction;
        while (true)
        {
          int num2 = -554892384;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              rightClickAction = this.Engine.Settings.AdminRightClickAction;
              num1 = (int) num3 * 1657895241 ^ 1772689816;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return rightClickAction;
      }
      set
      {
label_1:
        int num1 = -1184783924;
        while (true)
        {
          int num2 = -640246298;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1958383467 ^ -835377662;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3310138513U));
              num1 = (int) num3 * -1448546638 ^ -1514795368;
              continue;
            case 3:
              flag = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.Engine.Settings.AdminRightClickAction, value);
              num1 = (int) num3 * -1397761522 ^ 1370347452;
              continue;
            case 4:
              int num4 = !flag ? -1300304056 : (num4 = -2010100328);
              int num5 = (int) num3 * 1040513959;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 26634519 ^ 1750246660;
              continue;
            case 6:
              goto label_3;
            case 7:
              this.Engine.Settings.AdminRightClickAction = value;
              num1 = -853751648;
              continue;
            case 8:
              num1 = (int) num3 * -420035878 ^ 1376404754;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public string Monitor1
    {
      get
      {
label_1:
        int num1 = -954929833;
        string monitor1;
        while (true)
        {
          int num2 = -1385547440;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              monitor1 = this.monitor1;
              num1 = (int) num3 * 1893193303 ^ -138433754;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return monitor1;
      }
      set
      {
label_1:
        int num1 = 898199802;
        while (true)
        {
          int num2 = 469136659;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(934953681U));
              num1 = (int) num3 * 540874057 ^ -2115511354;
              continue;
            case 1:
              int num4 = !EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.monitor1, value) ? 797804881 : (num4 = 486421616);
              int num5 = (int) num3 * 825185973;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              this.UpdateMonitor(1, this.monitor1);
              num1 = (int) num3 * 1123029734 ^ 1113911776;
              continue;
            case 5:
              num1 = (int) num3 * -2093226138 ^ -1134293311;
              continue;
            case 6:
              num1 = (int) num3 * 1943599697 ^ -1583419914;
              continue;
            case 7:
              this.monitor1 = value;
              num1 = 395271099;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public string Monitor2
    {
      get
      {
        string monitor2 = this.monitor2;
label_1:
        int num1 = 1704508570;
        while (true)
        {
          int num2 = 916778530;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1853162782 ^ 755949577;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return monitor2;
      }
      set
      {
label_1:
        int num1 = -1038859291;
        while (true)
        {
          int num2 = -450538872;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              int num4 = !flag ? 234177298 : (num4 = 4113);
              int num5 = (int) num3 * 1711719785;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.monitor2, value);
              num1 = (int) num3 * 340735635 ^ 4644404;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.UpdateMonitor(2, this.monitor2);
              num1 = (int) num3 * 387275971 ^ -1841913129;
              continue;
            case 4:
              num1 = (int) num3 * -1490205748 ^ -347792457;
              continue;
            case 5:
              num1 = (int) num3 * 1235144635 ^ 501518386;
              continue;
            case 6:
              this.monitor2 = value;
              num1 = -101403805;
              continue;
            case 7:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3490004894U));
              num1 = (int) num3 * 1584336777 ^ 1874303357;
              continue;
            case 8:
              goto label_1;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public string Monitor3
    {
      get
      {
label_1:
        int num1 = -658808528;
        string monitor3;
        while (true)
        {
          int num2 = -1483258371;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              monitor3 = this.monitor3;
              num1 = (int) num3 * -1785635028 ^ -719140050;
              continue;
            case 3:
              num1 = (int) num3 * -130421012 ^ 1442597511;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return monitor3;
      }
      set
      {
        bool flag = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.monitor3, value);
label_1:
        int num1 = 1765359457;
        while (true)
        {
          int num2 = 677907110;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.monitor3 = value;
              num1 = 1073722480;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.UpdateMonitor(3, this.monitor3);
              num1 = (int) num3 * 1836331864 ^ 1049457675;
              continue;
            case 4:
              num1 = (int) num3 * 1503268783 ^ 1311856864;
              continue;
            case 5:
              num1 = (int) num3 * 2001597841 ^ -115289879;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4254128032U));
              num1 = (int) num3 * 878452162 ^ 783628769;
              continue;
            case 7:
              int num4 = flag ? -1845994158 : (num4 = -1040399137);
              int num5 = (int) num3 * 682896912;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public string Monitor4
    {
      get
      {
        string monitor4 = this.monitor4;
label_1:
        int num1 = 1699380737;
        while (true)
        {
          int num2 = 2000602275;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -654217630 ^ 1381209088;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return monitor4;
      }
      set
      {
label_1:
        int num1 = -1086059103;
        while (true)
        {
          int num2 = -2059590654;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.monitor4 = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3145345472U));
              num1 = -1655940465;
              continue;
            case 2:
              goto label_3;
            case 3:
              flag = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.monitor4, value);
              num1 = (int) num3 * 144321891 ^ -1607167963;
              continue;
            case 4:
              num1 = (int) num3 * 111910015 ^ 287947516;
              continue;
            case 5:
              this.UpdateMonitor(4, this.monitor4);
              num1 = (int) num3 * -1645322687 ^ -1108499829;
              continue;
            case 6:
              int num4 = !flag ? -745769819 : (num4 = -612308613);
              int num5 = (int) num3 * -1066694067;
              num1 = num4 ^ num5;
              continue;
            case 7:
              num1 = (int) num3 * -848272866 ^ -873566526;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public string Monitor5
    {
      get
      {
label_1:
        int num1 = 341443626;
        string monitor5;
        while (true)
        {
          int num2 = 667469313;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1485666894 ^ 1248171252;
              continue;
            case 2:
              goto label_1;
            case 3:
              monitor5 = this.monitor5;
              num1 = (int) num3 * 1982396308 ^ -316651779;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return monitor5;
      }
      set
      {
        bool flag = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.monitor5, value);
label_1:
        int num1 = -148919759;
        while (true)
        {
          int num2 = -2009054531;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1175588784 ^ -2136382536;
              continue;
            case 2:
              this.monitor5 = value;
              num1 = -932202273;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2517128577U));
              this.UpdateMonitor(5, this.monitor5);
              num1 = (int) num3 * 1159831640 ^ 1104170570;
              continue;
            case 4:
              num1 = (int) num3 * -814409111 ^ 1965959751;
              continue;
            case 5:
              goto label_3;
            case 6:
              int num4 = flag ? -1453315621 : (num4 = -557798105);
              int num5 = (int) num3 * 1908029320;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public string Monitor6
    {
      get
      {
label_1:
        int num1 = 1289883088;
        string monitor6;
        while (true)
        {
          int num2 = 678174893;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              monitor6 = this.monitor6;
              num1 = (int) num3 * 516099613 ^ 1397569959;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return monitor6;
      }
      set
      {
label_1:
        int num1 = -2002843757;
        while (true)
        {
          int num2 = -875071880;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 178864355 ^ 1561672857;
              continue;
            case 1:
              int num4 = EngineViewModel.\u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮(this.monitor6, value) ? 962897239 : (num4 = 1274426161);
              int num5 = (int) num3 * 292840935;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 144567238 ^ -904121903;
              continue;
            case 4:
              this.monitor6 = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2973967330U));
              this.UpdateMonitor(6, this.monitor6);
              num1 = -583724827;
              continue;
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
    }

    public ObservableCollection<ZoomMonitor> MonitorScreens
    {
      get
      {
label_1:
        int num1 = 1010030234;
        ObservableCollection<ZoomMonitor> monitorScreens;
        while (true)
        {
          int num2 = 1121212807;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              monitorScreens = EngineViewModel.monitorScreens;
              num1 = (int) num3 * -2138653981 ^ 465995886;
              continue;
            case 2:
              num1 = (int) num3 * -1293182494 ^ -1573654924;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return monitorScreens;
      }
      set
      {
label_1:
        int num1 = -1362637179;
        while (true)
        {
          int num2 = -705085522;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              EngineViewModel.monitorScreens = value;
              num1 = (int) num3 * -1928504541 ^ -1696754080;
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

    public event EventHandler OnWindowHighlightStart
    {
      add
      {
        EventHandler eventHandler = this.OnWindowHighlightStart;
label_1:
        int num1 = -1487566776;
        while (true)
        {
          int num2 = -79990619;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              int num4 = eventHandler != comparand ? -544313032 : (num4 = -2141856158);
              int num5 = (int) num3 * -603960526;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightStart, (EventHandler) EngineViewModel.\u200D⁫‬‏‬‍‏⁮‎‮⁬⁬‌‌‬‭⁮‬‏⁮‏‬​‮‫⁪‪⁬‍⁮⁮‫⁭⁬‪​⁮‮​⁮‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = -349956643;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
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
        EventHandler eventHandler = this.OnWindowHighlightStart;
label_1:
        int num1 = -1128757082;
        while (true)
        {
          int num2 = -1561052035;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = eventHandler != comparand ? -1779983493 : (num4 = -598049846);
              int num5 = (int) num3 * -1435417951;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightStart, (EventHandler) EngineViewModel.\u206F⁯⁪⁪⁬‎⁪‎‪⁮‏‏‪‎⁫⁮‬‫‮‪‏‏‎⁮‮⁪⁬‌⁭​‌‌‎‮‎‫‌‮‪‮‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = -1263714368;
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

    public event EventHandler OnWindowHighlightEnd
    {
      add
      {
        EventHandler eventHandler = this.OnWindowHighlightEnd;
label_1:
        int num1 = -860667224;
        while (true)
        {
          int num2 = -913566486;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightEnd, (EventHandler) EngineViewModel.\u200D⁫‬‏‬‍‏⁮‎‮⁬⁬‌‌‬‭⁮‬‏⁮‏‬​‮‫⁪‪⁬‍⁮⁮‫⁭⁬‪​⁮‮​⁮‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = eventHandler == comparand ? -1634516250 : (num4 = -60233452);
              int num5 = (int) num3 * 193995852;
              num1 = num4 ^ num5;
              continue;
            case 2:
              comparand = eventHandler;
              num1 = -197518625;
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
      remove
      {
        EventHandler eventHandler1 = this.OnWindowHighlightEnd;
label_1:
        int num1 = -1035638529;
        while (true)
        {
          int num2 = -1729215485;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightEnd, eventHandler2, comparand);
              num1 = (int) num3 * 1157846884 ^ -356944725;
              continue;
            case 2:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) EngineViewModel.\u206F⁯⁪⁪⁬‎⁪‎‪⁮‏‏‪‎⁫⁮‬‫‮‪‏‏‎⁮‮⁪⁬‌⁭​‌‌‎‮‎‫‌‮‪‮‮((Delegate) comparand, (Delegate) value);
              num1 = -103373865;
              continue;
            case 3:
              goto label_3;
            case 4:
              int num4 = eventHandler1 == comparand ? 1711111166 : (num4 = 21321047);
              int num5 = (int) num3 * 917461435;
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

    public event EventHandler OnWindowHighlightUpdate
    {
      add
      {
        EventHandler eventHandler1 = this.OnWindowHighlightUpdate;
label_1:
        int num1 = 883084083;
        while (true)
        {
          int num2 = 711000310;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler1;
              num1 = 539211447;
              continue;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightUpdate, eventHandler2, comparand);
              num1 = (int) num3 * 678642784 ^ -14601660;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = eventHandler1 == comparand ? 61808202 : (num4 = 363675397);
              int num5 = (int) num3 * 1718842419;
              num1 = num4 ^ num5;
              continue;
            case 5:
              eventHandler2 = (EventHandler) EngineViewModel.\u200D⁫‬‏‬‍‏⁮‎‮⁬⁬‌‌‬‭⁮‬‏⁮‏‬​‮‫⁪‪⁬‍⁮⁮‫⁭⁬‪​⁮‮​⁮‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 59757872 ^ -907341088;
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
        EventHandler eventHandler1 = this.OnWindowHighlightUpdate;
label_1:
        int num1 = -1854648528;
        while (true)
        {
          int num2 = -681278457;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler2 = (EventHandler) EngineViewModel.\u206F⁯⁪⁪⁬‎⁪‎‪⁮‏‏‪‎⁫⁮‬‫‮‪‏‏‎⁮‮⁪⁬‌⁭​‌‌‎‮‎‫‌‮‪‮‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -47308471 ^ -1872600956;
              continue;
            case 1:
              goto label_3;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightUpdate, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? -1684927063 : (num4 = -325103255);
              int num5 = (int) num3 * 1137235909;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            case 4:
              comparand = eventHandler1;
              num1 = -314259759;
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
        EventHandler eventHandler1 = this.OnActivityProgressReport;
label_1:
        int num1 = 1527237714;
        while (true)
        {
          int num2 = 1380931155;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              int num4 = eventHandler1 != comparand ? 1966125458 : (num4 = 214262498);
              int num5 = (int) num3 * -544059222;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) EngineViewModel.\u200D⁫‬‏‬‍‏⁮‎‮⁬⁬‌‌‬‭⁮‬‏⁮‏‬​‮‫⁪‪⁬‍⁮⁮‫⁭⁬‪​⁮‮​⁮‮((Delegate) comparand, (Delegate) value);
              num1 = 1260335470;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityProgressReport, eventHandler2, comparand);
              num1 = (int) num3 * 2128888903 ^ 1355194584;
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
        int num1 = 1739084654;
        while (true)
        {
          int num2 = 966389615;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              int num4 = eventHandler == comparand ? -1647739997 : (num4 = -859081834);
              int num5 = (int) num3 * -2075640346;
              num1 = num4 ^ num5;
              continue;
            case 1:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityProgressReport, (EventHandler) EngineViewModel.\u206F⁯⁪⁪⁬‎⁪‎‪⁮‏‏‪‎⁫⁮‬‫‮‪‏‏‎⁮‮⁪⁬‌⁭​‌‌‎‮‎‫‌‮‪‮‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * 1657163560 ^ 1081809723;
              continue;
            case 2:
              comparand = eventHandler;
              num1 = 1242025815;
              continue;
            case 3:
              goto label_3;
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
    }

    public EngineViewModel()
    {
label_1:
      int num1 = -574611860;
      while (true)
      {
        int num2 = -909569361;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            ((CompositePresentationEvent<Window>) this._eventAggregator.GetEvent<WindowPanelReset>()).Subscribe(new Action<Window>(this.PanelReset), (ThreadOption) 1);
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingPlacedOnHold>()).Subscribe(new Action<ZoomMeeting>(this.PlacedOnHold), (ThreadOption) 1);
            num1 = (int) num3 * -349989505 ^ 552806629;
            continue;
          case 1:
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingRemovedFromHold>()).Subscribe(new Action<ZoomMeeting>(this.RemovedFromHold), (ThreadOption) 1);
            ((CompositePresentationEvent<StatusObject>) this._eventAggregator.GetEvent<StatusEvent>()).Subscribe(new Action<StatusObject>(this.StatusUpdated), (ThreadOption) 1);
            num1 = (int) num3 * -1208830104 ^ -377443923;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.LoadSavedActivities();
            num1 = (int) num3 * 1558968757 ^ -149618749;
            continue;
          case 4:
            num1 = (int) num3 * -655331801 ^ -1334127677;
            continue;
          case 5:
            this.LoadMonitors();
            num1 = (int) num3 * 1368485949 ^ -541479991;
            continue;
          case 6:
            this.Engine = Engine.Instance;
            num1 = (int) num3 * 1134278265 ^ 866574423;
            continue;
          case 7:
            num1 = (int) num3 * -1332469636 ^ -991527932;
            continue;
          case 8:
            goto label_1;
          case 9:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityRequiresAuthorizationEvent>()).Subscribe(new Action<ActivityEventBaseArguments>(this.HandleActivityAuthorization), (ThreadOption) 1, true);
            this.ActivityManagerView = new ActivityManagerView();
            num1 = (int) num3 * -1084926714 ^ -280459611;
            continue;
          case 10:
            num1 = (int) num3 * 1916743020 ^ -213970341;
            continue;
          case 11:
            ((CompositePresentationEvent<string>) this._eventAggregator.GetEvent<MeetingAdded>()).Subscribe(new Action<string>(this.HandleMeetingAdded), (ThreadOption) 1);
            ((CompositePresentationEvent<string>) this._eventAggregator.GetEvent<MeetingDeleted>()).Subscribe(new Action<string>(this.HandleMeetingDeleted), (ThreadOption) 1);
            ((CompositePresentationEvent<MouseEventData>) this._eventAggregator.GetEvent<MouseEvent>()).Subscribe(new Action<MouseEventData>(this.HandleMouseEvent), (ThreadOption) 1);
            num1 = (int) num3 * 1099169857 ^ -1058093487;
            continue;
          case 12:
            this.LoadData();
            this.LoadCommands();
            num1 = (int) num3 * 867248208 ^ -1331579643;
            continue;
          case 13:
            num1 = (int) num3 * -70289688 ^ -699216905;
            continue;
          case 14:
            this.LoadMeetings();
            num1 = (int) num3 * 1939472322 ^ 783256232;
            continue;
          case 15:
            num1 = (int) num3 * -861076616 ^ 1933943970;
            continue;
          case 16:
            EngineViewModel.\u202A‫⁫‭‏‌⁬‌⁪⁮‌⁭‪‍⁫⁯‎⁬‎‌‌‭‪‭‌‪⁯‍‎⁯‏⁭‎‬⁫‬‫‭⁮⁬‮((Window) this.ActivityManagerView, new EventHandler(this.ActivityManagerView_Closed));
            num1 = (int) num3 * -696542796 ^ -965389534;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return;
label_3:;
    }

    ~EngineViewModel()
    {
      try
      {
        bool flag = this.Engine != null;
label_2:
        int num1 = 363004493;
        while (true)
        {
          int num2 = 820003917;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_10;
            case 1:
              this.Engine.QuitApplication = true;
              num1 = (int) num3 * -1880172073 ^ 621421405;
              continue;
            case 2:
              num1 = (int) num3 * -1350883279 ^ 697365526;
              continue;
            case 3:
              int num4 = !flag ? -1500915995 : (num4 = -124879598);
              int num5 = (int) num3 * 509483165;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_2;
            case 5:
              num1 = (int) num3 * 807496764 ^ 1975198130;
              continue;
            case 6:
              num1 = (int) num3 * 2103180902 ^ -1673949576;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_10:;
      }
      finally
      {
        // ISSUE: explicit finalizer call
        // ISSUE: explicit non-virtual call
        __nonvirtual (((object) this).Finalize());
      }
    }

    private void LoadMonitors()
    {
label_1:
      int num1 = -2018100213;
      while (true)
      {
        int num2 = -523443200;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1157426582 ^ -1074139045;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      using (List<ZoomMonitor>.Enumerator enumerator = this.Engine.Settings.Monitors.GetEnumerator())
      {
label_12:
        int num2 = !enumerator.MoveNext() ? -1541984512 : (num2 = -551007980);
        while (true)
        {
          int num3 = -523443200;
          uint num4;
          ZoomMonitor current;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              goto label_15;
            case 1:
              this.RaisePropertyChanged(EngineViewModel.\u206E‍‏‫⁮‮‭‍⁯‏⁯⁪‪​⁮‪⁭‪‮‎‭⁮‪‭‏⁮⁪⁬‫‬‍⁪⁬⁫⁪⁭‫​‎⁯‮(EngineViewModel.\u206B‭‫⁬⁬‫‪⁫‫⁮⁯‭⁭⁬⁪⁬⁯‪‬‫‬⁭⁮​⁪‪‫⁭⁯​‫⁫‭‫‪‎⁭​‬⁭‮((object) current), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1327136697U), ""));
              num2 = (int) num4 * 1178941404 ^ -322909087;
              continue;
            case 2:
              goto label_12;
            case 3:
              num2 = (int) num4 * 403479732 ^ -551075019;
              continue;
            case 4:
              current = enumerator.Current;
              num2 = -2142057473;
              continue;
            case 5:
              num2 = (int) num4 * 263281940 ^ -773425018;
              continue;
            case 6:
              num2 = -551007980;
              continue;
            case 7:
              ((Collection<ZoomMonitor>) this.MonitorScreens).Add(current);
              num2 = (int) num4 * -794375365 ^ -499643898;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_15:;
      }
    }

    private void LoadSavedActivities()
    {
      bool flag1 = this.Engine != null;
label_1:
      int num1 = 224500310;
      object modelLock;
      while (true)
      {
        int num2 = 296217384;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            modelLock = ViewModelBase.modelLock;
            num1 = (int) num3 * 1112440611 ^ 431167184;
            continue;
          case 2:
            if (flag1)
            {
              num1 = (int) num3 * -608922366 ^ 199810845;
              continue;
            }
            goto label_36;
          default:
            goto label_6;
        }
      }
label_36:
      return;
label_6:
      bool flag2 = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag2);
label_8:
        int num2 = 1491763734;
        while (true)
        {
          int num3 = 296217384;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 1:
              num2 = (int) num4 * 469385954 ^ -1482991043;
              continue;
            case 2:
              num2 = (int) num4 * 1563526688 ^ 892489767;
              continue;
            case 3:
              num2 = (int) num4 * -1949133659 ^ -868054120;
              continue;
            case 4:
              goto label_8;
            default:
              goto label_13;
          }
        }
label_13:
        IEnumerator<ActivityBase> enumerator = this.Engine.SavedActivities.GetEnumerator();
        try
        {
label_20:
          int num3 = !EngineViewModel.\u200B‌​⁮‭⁬⁬‫‫‌‍‭‬⁯​‪⁭‭‌⁯‍‫‍‮⁫⁬‍‭‫‍‍‬‪⁬⁮‫‮‍‪‌‮((IEnumerator) enumerator) ? 794957613 : (num3 = 157310454);
          while (true)
          {
            int num4 = 296217384;
            uint num5;
            bool flag3;
            // ISSUE: variable of a compiler-generated type
            EngineViewModel.\u003C\u003Ec__DisplayClass90_0 cDisplayClass900;
            switch ((num5 = (uint) (num3 ^ num4)) % 13U)
            {
              case 0:
                num3 = 157310454;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                ((Collection<StringItem>) this.SavedActivities).Add(new StringItem(cDisplayClass900.savedActivity.Title));
                num3 = (int) num5 * 1363912452 ^ -1859879680;
                continue;
              case 3:
                num3 = 795567586;
                continue;
              case 4:
                num3 = (int) num5 * -699629504 ^ -1323258711;
                continue;
              case 5:
                num3 = (int) num5 * 321246712 ^ 20886180;
                continue;
              case 6:
                // ISSUE: method pointer
                flag3 = !Enumerable.Any<StringItem>((IEnumerable<M0>) this.SavedActivities, (Func<M0, bool>) new Func<StringItem, bool>((object) cDisplayClass900, __methodptr(\u003CLoadSavedActivities\u003Eb__0)));
                num3 = (int) num5 * -284621156 ^ -1158938390;
                continue;
              case 7:
                int num6 = !flag3 ? 395260701 : (num6 = 1190511605);
                int num7 = (int) num5 * -628230621;
                num3 = num6 ^ num7;
                continue;
              case 8:
                num3 = (int) num5 * 1479723418 ^ -1151036677;
                continue;
              case 9:
                goto label_20;
              case 10:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass900.savedActivity = enumerator.Current;
                num3 = (int) num5 * -1532585846 ^ -291546980;
                continue;
              case 11:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass900 = new EngineViewModel.\u003C\u003Ec__DisplayClass90_0();
                num3 = 1010686458;
                continue;
              case 12:
                num3 = (int) num5 * 1775256859 ^ 1399045958;
                continue;
              default:
                goto label_40;
            }
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_29:
            int num3 = 325967547;
            while (true)
            {
              int num4 = 296217384;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 3U)
              {
                case 0:
                  goto label_29;
                case 2:
                  EngineViewModel.\u200B‏​⁫⁬‍‍‮‮‍⁪‪‪⁮‌‌‏‎‬⁪⁭‌​​‌‬‏⁫⁭​‮⁪⁫⁮⁬‮‎⁬⁬⁮‮((IDisposable) enumerator);
                  num3 = (int) num5 * 779958282 ^ -1003947176;
                  continue;
                default:
                  goto label_32;
              }
            }
          }
label_32:;
        }
      }
      finally
      {
        if (flag2)
        {
label_34:
          int num2 = 1965562171;
          while (true)
          {
            int num3 = 296217384;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -1712536978 ^ -553886731;
                continue;
              case 2:
                goto label_34;
              case 3:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num2 = (int) num4 * -266506276 ^ 322871772;
                continue;
              default:
                goto label_39;
            }
          }
        }
label_39:;
      }
label_40:;
    }

    private void HandleActivityAuthorization(ActivityEventBaseArguments obj)
    {
label_1:
      int num1 = -34441820;
      while (true)
      {
        int num2 = -1116123407;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.LaunchActivityManagerView();
            num1 = (int) num3 * 1939148922 ^ -31200499;
            continue;
          case 2:
            num1 = (int) num3 * 1791074533 ^ 141316111;
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

    private void HandleMouseEvent(MouseEventData obj)
    {
      try
      {
label_2:
        int num1 = -457411357;
        ZoomWindow window;
        object modelLock;
        bool flag1;
        while (true)
        {
          int num2 = -321025507;
          uint num3;
          IntPtr windowClicked;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              ViewModelBase.log.Debug((object) string.Format(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1913764647U), (object) obj.X, (object) obj.Y, (object) window.ZoomWindowType, obj.RelativeX, obj.RelativeY));
              num1 = (int) num3 * 82420480 ^ 338160127;
              continue;
            case 1:
              window = this.Engine.GetWindow(obj.WindowClicked, false);
              num1 = (int) num3 * -152233132 ^ 1851557541;
              continue;
            case 3:
              windowClicked = obj.WindowClicked;
              num1 = (int) num3 * 894013484 ^ -1686578351;
              continue;
            case 4:
              num4 = windowClicked.Equals((object) window.Handle) ? 1 : 0;
              break;
            case 5:
              if (flag2)
              {
                num1 = (int) num3 * 473002525 ^ 823249633;
                continue;
              }
              goto label_42;
            case 6:
              num1 = (int) num3 * 1832430633 ^ 1513464706;
              continue;
            case 7:
              goto label_2;
            case 8:
              if (window == null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * -548242049 ^ -1583095898;
              continue;
            case 9:
              flag1 = false;
              num1 = (int) num3 * 1821224722 ^ 1889205904;
              continue;
            case 10:
              flag2 = this.Engine.ActiveActivity == null;
              num1 = (int) num3 * -75586572 ^ 1000455356;
              continue;
            case 11:
              modelLock = ViewModelBase.modelLock;
              num1 = (int) num3 * 244201595 ^ -613681698;
              continue;
            default:
              goto label_19;
          }
          if (num4 != 0)
            num1 = -292443083;
          else
            goto label_62;
        }
label_19:
        bool flag3 = false;
        try
        {
          Monitor.Enter(modelLock, ref flag3);
label_21:
          int num2 = -905444912;
          while (true)
          {
            int num3 = -321025507;
            uint num4;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 12U)
            {
              case 0:
                num2 = -1140201747;
                continue;
              case 1:
                num2 = (int) num4 * -1122772637 ^ 1601513210;
                continue;
              case 2:
                flag2 = this.ButtonEditorView != null;
                num2 = (int) num4 * 1227641163 ^ 759886985;
                continue;
              case 3:
                goto label_21;
              case 4:
                this.ButtonEditorView = new ButtonEditorView();
                num2 = (int) num4 * -465284216 ^ -1088830486;
                continue;
              case 5:
                num2 = -1244661914;
                continue;
              case 6:
                flag1 = true;
                num2 = (int) num4 * 35572251 ^ -2129174970;
                continue;
              case 8:
                num2 = (int) num4 * 1837571404 ^ -238145909;
                continue;
              case 9:
                num2 = (int) num4 * 409261526 ^ 686011433;
                continue;
              case 10:
                int num5 = flag2 ? 558681728 : (num5 = 1322000301);
                int num6 = (int) num4 * -1462097546;
                num2 = num5 ^ num6;
                continue;
              case 11:
                num2 = (int) num4 * 1518919777 ^ 725760375;
                continue;
              default:
                goto label_38;
            }
          }
        }
        finally
        {
          if (flag3)
          {
label_34:
            int num2 = -1329450111;
            while (true)
            {
              int num3 = -321025507;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_34;
                case 2:
                  Monitor.Exit(modelLock);
                  num2 = (int) num4 * -1819021839 ^ -1091590496;
                  continue;
                default:
                  goto label_37;
              }
            }
          }
label_37:;
        }
label_38:
        bool flag4 = !flag1;
label_39:
        int num7 = -480375500;
label_40:
        while (true)
        {
          int num2 = -321025507;
          uint num3;
          ZoomButton zoomButton;
          switch ((num3 = (uint) (num7 ^ num2)) % 23U)
          {
            case 0:
              num7 = (int) num3 * 1160974499 ^ -157082017;
              continue;
            case 1:
              num7 = (int) num3 * -398582710 ^ -864580411;
              continue;
            case 2:
              num7 = (int) num3 * 1108537107 ^ 245524443;
              continue;
            case 3:
              num7 = -819518396;
              continue;
            case 4:
              num7 = (int) num3 * -189913468 ^ -800569847;
              continue;
            case 5:
              num7 = (int) num3 * -1826966955 ^ -1846946661;
              continue;
            case 6:
              int num4 = !flag4 ? 405728330 : (num4 = 470008792);
              int num5 = (int) num3 * 1666423310;
              num7 = num4 ^ num5;
              continue;
            case 7:
              this.ButtonEditorView.Closed += new EventHandler(this.ButtonEditorView_Closed);
              num7 = (int) num3 * -338229748 ^ 1236570151;
              continue;
            case 8:
              this.ButtonEditorView.Button = zoomButton;
              num7 = (int) num3 * -114602976 ^ 1808135395;
              continue;
            case 9:
              int num6 = this.Engine.ActiveMeeting == null ? -282567192 : (num6 = -1772604159);
              int num8 = (int) num3 * 838118321;
              num7 = num6 ^ num8;
              continue;
            case 10:
              this.ButtonEditorView.Show();
              num7 = (int) num3 * -927440894 ^ 396909703;
              continue;
            case 11:
              goto label_62;
            case 12:
              goto label_42;
            case 13:
              this.ButtonEditorView = new ButtonEditorView();
              num7 = -629766199;
              continue;
            case 14:
              zoomButton = new ZoomButton();
              num7 = (int) num3 * -2124466341 ^ -2037808100;
              continue;
            case 15:
              zoomButton.WindowSize = window.Size;
              num7 = (int) num3 * 1924550945 ^ -1399934958;
              continue;
            case 16:
              zoomButton.ButtonLocation = obj.Location;
              num7 = (int) num3 * 304280843 ^ 2107521199;
              continue;
            case 17:
              num7 = (int) num3 * 1889618432 ^ 1730660980;
              continue;
            case 18:
              num7 = (int) num3 * -185803495 ^ -1261433614;
              continue;
            case 19:
              zoomButton.MeetingId = this.Engine.ActiveMeeting.MeetingId;
              num7 = (int) num3 * -1348337826 ^ -1553619430;
              continue;
            case 20:
              goto label_70;
            case 21:
              goto label_39;
            case 22:
              zoomButton.ZoomWindowType = ZoomWindowType.Meeting;
              num7 = (int) num3 * 124767103 ^ -1283335774;
              continue;
            default:
              goto label_67;
          }
        }
label_67:
        return;
label_70:
        return;
label_42:
        num7 = -693292684;
        goto label_40;
label_62:
        num7 = -1692350882;
        goto label_40;
      }
      catch (Exception ex)
      {
label_65:
        int num1 = -1796730444;
        while (true)
        {
          int num2 = -321025507;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_63;
            case 1:
              ViewModelBase.log.Error((object) ex);
              num1 = (int) num3 * -1444536093 ^ 243119149;
              continue;
            case 2:
              goto label_65;
            case 3:
              num1 = (int) num3 * -1520885486 ^ -560026009;
              continue;
            default:
              goto label_41;
          }
        }
label_41:
        return;
label_63:;
      }
    }

    private void ButtonEditorView_Closed(object sender, EventArgs e)
    {
      try
      {
        object modelLock = ViewModelBase.modelLock;
        bool flag = false;
        try
        {
          EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag);
label_3:
          int num1 = 1716081405;
          while (true)
          {
            int num2 = 816723622;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                this.ButtonEditorView = (ButtonEditorView) null;
                num1 = (int) num3 * -141700157 ^ -1895147526;
                continue;
              case 1:
                num1 = (int) num3 * -812735804 ^ 1556543670;
                continue;
              case 2:
                goto label_22;
              case 3:
                num1 = (int) num3 * -1975003573 ^ -1167233482;
                continue;
              case 4:
                goto label_3;
              default:
                goto label_19;
            }
          }
label_19:
          return;
label_22:;
        }
        finally
        {
          if (flag)
          {
label_9:
            int num1 = 931649807;
            while (true)
            {
              int num2 = 816723622;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * 490429891 ^ 174024000;
                  continue;
                case 1:
                  EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                  num1 = (int) num3 * 1936041813 ^ 1476198583;
                  continue;
                case 3:
                  goto label_9;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
      }
      catch (Exception ex)
      {
label_17:
        int num1 = 1408499695;
        while (true)
        {
          int num2 = 816723622;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_17;
            case 1:
              EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * 1653198774 ^ 1943180166;
              continue;
            case 2:
              num1 = (int) num3 * 803775170 ^ 1642478041;
              continue;
            case 3:
              goto label_15;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_15:;
      }
    }

    private void LoadData()
    {
label_1:
      int num1 = 81593223;
      IOrderedEnumerable<Type> orderedEnumerable;
      while (true)
      {
        int num2 = 1573266824;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            this.availableActivityTypes.Add(this.selectedActivityType);
            num1 = (int) num3 * 1827459032 ^ -660888061;
            continue;
          case 1:
            this.availableActivityTypes.Clear();
            num1 = (int) num3 * 1918337825 ^ -2134259727;
            continue;
          case 2:
            this.selectedActivityType = new StringItem("");
            num1 = (int) num3 * 1039997356 ^ 1900497612;
            continue;
          case 3:
            // ISSUE: type reference
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            orderedEnumerable = (IOrderedEnumerable<Type>) Enumerable.OrderBy<Type, string>((IEnumerable<M0>) EngineViewModel.GetDerivedTypesFor(EngineViewModel.\u206E‏‌‏⁮⁪⁯​⁬‮‎⁬⁪‏⁪‬‬⁯‌⁭‪⁭‭⁪‮‌⁬‪‪⁪⁮‎‫⁭​⁭‎‭‌⁯‮(__typeref (ActivityBase))), (Func<M0, M1>) (EngineViewModel.\u003C\u003Ec.\u003C\u003E9__96_0 ?? (EngineViewModel.\u003C\u003Ec.\u003C\u003E9__96_0 = new Func<Type, string>((object) EngineViewModel.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CLoadData\u003Eb__96_0)))));
            num1 = 126739537;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      IEnumerator<Type> enumerator = orderedEnumerable.GetEnumerator();
      try
      {
label_15:
        int num2 = EngineViewModel.\u200B‌​⁮‭⁬⁬‫‫‌‍‭‬⁯​‪⁭‭‌⁯‍‫‍‮⁫⁬‍‭‫‍‍‬‪⁬⁮‫‮‍‪‌‮((IEnumerator) enumerator) ? 1980426012 : (num2 = 1003657784);
        while (true)
        {
          int num3 = 1573266824;
          uint num4;
          Type current;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              this.availableActivityTypes.Add(new StringItem(EngineViewModel.\u202C‪⁮⁫‭⁭‏⁮‏​‭‪‌‏‮⁯⁯‏‍‮⁯⁮‬⁫⁪‪⁭⁮⁬⁫⁭⁭‎‭⁭​‮⁪‪‌‮((MemberInfo) current)));
              num2 = (int) num4 * 1818330356 ^ 1455709906;
              continue;
            case 1:
              num2 = (int) num4 * 227445830 ^ 596891260;
              continue;
            case 2:
              num2 = 1980426012;
              continue;
            case 3:
              current = enumerator.Current;
              num2 = 1271364708;
              continue;
            case 4:
              goto label_20;
            case 5:
              num2 = (int) num4 * 305027982 ^ 955516075;
              continue;
            case 6:
              goto label_15;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_20:;
      }
      finally
      {
        if (enumerator != null)
        {
label_18:
          int num2 = 1810578957;
          while (true)
          {
            int num3 = 1573266824;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 1922123864 ^ 1385539411;
                continue;
              case 1:
                EngineViewModel.\u200B‏​⁫⁬‍‍‮‮‍⁪‪‪⁮‌‌‏‎‬⁪⁭‌​​‌‬‏⁫⁭​‮⁪⁫⁮⁬‮‎⁬⁬⁮‮((IDisposable) enumerator);
                num2 = (int) num4 * 1711050458 ^ -1151075810;
                continue;
              case 2:
                goto label_18;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
    }

    private void WindowTimer_Tick(object sender, EventArgs e)
    {
label_1:
      int num1 = 1668199531;
      while (true)
      {
        int num2 = 1523766126;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.ActivityInProgress = this.Engine.ActiveActivity != null;
            num1 = (int) num3 * -713650767 ^ 1019969717;
            continue;
          case 2:
            num1 = (int) num3 * -990342409 ^ 1613563688;
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

    private bool CanExecuteQuickJoinMeeting()
    {
      bool flag = !EngineViewModel.\u202A⁪⁬‍⁬⁯‭‌⁭‏⁫⁯​‌⁭⁬‫​‮‭‮‫‍⁯⁬​⁪‭‍‮‪‮⁯⁯‪⁪‭‎⁯‬‮(this.SelectedMeetingId);
label_1:
      int num1 = -1424489600;
      while (true)
      {
        int num2 = -905689631;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1475822916 ^ 1174533394;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteQuickJoinMeeting()
    {
label_1:
      int num1 = -1633166445;
      while (true)
      {
        int num2 = -1671025625;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Engine.AddActivity((ActivityBase) new JoinMeeting(this.SelectedMeetingId), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3083557905U));
            num1 = (int) num3 * 47387151 ^ -2008892221;
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

    private void HandleMeetingDeleted(string meetingId)
    {
label_1:
      int num1 = -652679436;
      object modelLock;
      while (true)
      {
        int num2 = -38338299;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            modelLock = ViewModelBase.modelLock;
            num1 = (int) num3 * -1715663273 ^ -2006389694;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag);
label_6:
        int num2 = -149205468;
        while (true)
        {
          int num3 = -38338299;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated method
              this.MeetingIds.RemoveAll((Predicate<StringItem>) (x => EngineViewModel.\u003C\u003Ec__DisplayClass100_0.\u206E‎⁪‮⁪⁮‭‬‏⁮‭‎⁫⁪⁪‭‬⁫‏‭‪⁮⁪⁪⁬‮⁪‍‍⁪‪⁮⁯⁯‍‮⁮⁮‮‮(x.Value, meetingId)));
              num2 = (int) num4 * -1249441512 ^ -549358562;
              continue;
            case 1:
              num2 = (int) num4 * 616748354 ^ 1227917127;
              continue;
            case 2:
              goto label_6;
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
          int num2 = -41443582;
          while (true)
          {
            int num3 = -38338299;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_11;
              case 2:
                num2 = (int) num4 * -1801944141 ^ 1169284914;
                continue;
              case 3:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num2 = (int) num4 * 6776424 ^ -79218273;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_16:
      this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1212976970U));
    }

    private void HandleMeetingAdded(string meetingId)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EngineViewModel.\u003C\u003Ec__DisplayClass101_0 displayClass1010 = new EngineViewModel.\u003C\u003Ec__DisplayClass101_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1010.meetingId = meetingId;
      object modelLock = ViewModelBase.modelLock;
      bool flag1 = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag1);
        // ISSUE: method pointer
        bool flag2 = !Enumerable.Any<StringItem>((IEnumerable<M0>) EngineViewModel.meetingIds, (Func<M0, bool>) new Func<StringItem, bool>((object) displayClass1010, __methodptr(\u003CHandleMeetingAdded\u003Eb__0)));
label_2:
        int num1 = 1873192144;
        while (true)
        {
          int num2 = 773392898;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              EngineViewModel.meetingIds.Add(new StringItem(displayClass1010.meetingId));
              num1 = (int) num3 * 1464041022 ^ 193955763;
              continue;
            case 1:
              num1 = 641543120;
              continue;
            case 3:
              num1 = (int) num3 * -1993158046 ^ -1245070355;
              continue;
            case 4:
              int num4 = flag2 ? 1380424034 : (num4 = 2037077881);
              int num5 = (int) num3 * -1673963881;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_2;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_9:
          int num1 = 822656735;
          while (true)
          {
            int num2 = 773392898;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -1927357356 ^ 1050721173;
                continue;
              case 1:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num1 = (int) num3 * 800021904 ^ 1149381718;
                continue;
              case 2:
                goto label_9;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1212976970U));
label_16:
      int num6 = 53390076;
      while (true)
      {
        int num1 = 773392898;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 0:
            goto label_16;
          case 1:
            num6 = (int) num2 * -623338016 ^ -674867091;
            continue;
          case 2:
            goto label_18;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_18:;
    }

    private void LoadMeetings()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EngineViewModel.\u003C\u003Ec__DisplayClass106_1 displayClass1061 = new EngineViewModel.\u003C\u003Ec__DisplayClass106_1();
label_1:
      int num1 = -2071389142;
      List<ZoomMeeting> list;
      while (true)
      {
        int num2 = -190307232;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomMeeting>) Enumerable.Where<ZoomMeeting>((IEnumerable<M0>) this.Engine.Meetings, (Func<M0, bool>) (EngineViewModel.\u003C\u003Ec.\u003C\u003E9__106_0 ?? (EngineViewModel.\u003C\u003Ec.\u003C\u003E9__106_0 = new Func<ZoomMeeting, bool>((object) EngineViewModel.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CLoadMeetings\u003Eb__106_0)))))).ToList<ZoomMeeting>();
            num1 = -317692872;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      displayClass1061.validMeetingIds = new List<string>();
      using (List<ZoomMeeting>.Enumerator enumerator = list.GetEnumerator())
      {
label_10:
        int num2 = enumerator.MoveNext() ? -80615464 : (num2 = -1142302082);
        while (true)
        {
          int num3 = -190307232;
          uint num4;
          // ISSUE: variable of a compiler-generated type
          EngineViewModel.\u003C\u003Ec__DisplayClass106_0 displayClass1060;
          bool flag;
          switch ((num4 = (uint) (num2 ^ num3)) % 11U)
          {
            case 0:
              // ISSUE: method pointer
              flag = !Enumerable.Any<StringItem>((IEnumerable<M0>) this.MeetingIds, (Func<M0, bool>) new Func<StringItem, bool>((object) displayClass1060, __methodptr(\u003CLoadMeetings\u003Eb__1)));
              num2 = (int) num4 * -608421607 ^ -2068038187;
              continue;
            case 2:
              goto label_10;
            case 3:
              num2 = (int) num4 * 68104514 ^ -1205132374;
              continue;
            case 4:
              num2 = (int) num4 * 370367399 ^ -382523933;
              continue;
            case 5:
              num2 = -1607075738;
              continue;
            case 6:
              num2 = -80615464;
              continue;
            case 7:
              int num5 = !flag ? -1472698284 : (num5 = -1195028324);
              int num6 = (int) num4 * 742364393;
              num2 = num5 ^ num6;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              displayClass1060.meeting = enumerator.Current;
              num2 = (int) num4 * -1706149307 ^ 2016018322;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              EngineViewModel.meetingIds.Add(new StringItem(displayClass1060.meeting.MeetingId));
              num2 = (int) num4 * 158806809 ^ -1755091607;
              continue;
            case 10:
              // ISSUE: object of a compiler-generated type is created
              displayClass1060 = new EngineViewModel.\u003C\u003Ec__DisplayClass106_0();
              num2 = -33173931;
              continue;
            default:
              goto label_19;
          }
        }
      }
label_19:
      // ISSUE: reference to a compiler-generated method
      list.ForEach(new Action<ZoomMeeting>(displayClass1061.\u003CLoadMeetings\u003Eb__2));
      // ISSUE: reference to a compiler-generated method
      EngineViewModel.meetingIds.RemoveAll(new Predicate<StringItem>(displayClass1061.\u003CLoadMeetings\u003Eb__3));
label_20:
      int num7 = -871993067;
      while (true)
      {
        int num2 = -190307232;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            num7 = (int) num3 * 1871840699 ^ -792404597;
            continue;
          case 1:
            this.SelectedMeetingId = this.Engine.Settings.ForceMeeting;
            num7 = (int) num3 * -81889813 ^ -1764273457;
            continue;
          case 2:
            goto label_20;
          case 3:
            goto label_22;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_22:;
    }

    private bool CanQueueFakeAnnouncement()
    {
label_1:
      int num1 = -1525556448;
      bool flag;
      while (true)
      {
        int num2 = -924713747;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            flag = true;
            num1 = (int) num3 * -793262535 ^ -1306860485;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1602812210 ^ 1786761743;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void QueueFakeAnnouncement()
    {
label_1:
      int num1 = -2108009633;
      ActivityEditorView activityEditorView;
      while (true)
      {
        int num2 = -394687034;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            activityEditorView = new ActivityEditorView(this._eventAggregator);
            activityEditorView.Activity = (ActivityBase) new FakeAnnounce();
            num1 = (int) num3 * -1186619081 ^ 1580600754;
            continue;
          case 3:
            num1 = (int) num3 * 78092117 ^ 1785521035;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      EngineViewModel.\u206A‪‮‬​⁭‫⁪⁯‭‏‭⁯‏‌‌⁫‬⁪⁪‫‪⁬‬‍​‏⁯⁫‍⁯‬‫⁭‭⁫‭‭‬‭‮((Window) activityEditorView);
    }

    private bool CanFindUserCommand()
    {
      bool flag = true;
label_1:
      int num1 = 644168530;
      while (true)
      {
        int num2 = 2088657114;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1816104267 ^ 2119983475;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void QueueFindUserCommand()
    {
label_1:
      int num1 = -1945246052;
      while (true)
      {
        int num2 = -1310680983;
        uint num3;
        ActivityEditorView activityEditorView;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * -1332723199 ^ 1183378425;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            EngineViewModel.\u206A‪‮‬​⁭‫⁪⁯‭‏‭⁯‏‌‌⁫‬⁪⁪‫‪⁬‬‍​‏⁯⁫‍⁯‬‫⁭‭⁫‭‭‬‭‮((Window) activityEditorView);
            num1 = (int) num3 * -1082411047 ^ 1693888220;
            continue;
          case 4:
            activityEditorView = new ActivityEditorView(this._eventAggregator);
            activityEditorView.Activity = (ActivityBase) new FakeAnnounce();
            num1 = (int) num3 * 1535430217 ^ -574981943;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private void StatusUpdated(StatusObject obj)
    {
label_1:
      int num1 = 519778209;
      while (true)
      {
        int num2 = 1155876458;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.SetStatus(obj.Status);
            num1 = (int) num3 * -1320146672 ^ -1733186209;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void RemovedFromHold(ZoomMeeting obj)
    {
    }

    private void PlacedOnHold(ZoomMeeting obj)
    {
    }

    private void PanelReset(Window obj)
    {
      try
      {
label_2:
        int num1 = -837314092;
        while (true)
        {
          int num2 = -403678939;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_15;
            case 1:
              this.Engine.Settings.EngineView_DisplayQuickLinkBar = true;
              num1 = (int) num3 * 714100514 ^ -1446529632;
              continue;
            case 2:
              goto label_2;
            case 3:
              num1 = (int) num3 * 1207064108 ^ 2085815297;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_15:;
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -1873254096;
        while (true)
        {
          int num2 = -403678939;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * -862425013 ^ 656369967;
              continue;
            case 1:
              num1 = (int) num3 * 1612771448 ^ 1612188160;
              continue;
            case 2:
              goto label_7;
            case 3:
              goto label_9;
            case 4:
              num1 = (int) num3 * -103875520 ^ -1674379324;
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

    internal void Initialize(EngineView engineView, Engine engine)
    {
      bool flag = !this.Initialized;
label_1:
      int num1 = 126669660;
      while (true)
      {
        int num2 = 173037527;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = (int) num3 * -1121851267 ^ -877394990;
            continue;
          case 1:
            this.ViewHandle = EngineViewModel.\u200D‏‪‎⁯‭⁬⁭‍‪‭⁪‮‮⁫⁭‌‏⁭⁪‎​‎‮‌‌⁪‬‌⁫⁬‭⁮​‎‪⁪⁭⁯‫‮(EngineViewModel.\u206F⁪‌‪⁭‮‍⁬‎⁭⁮⁬‍‌‪‍‮‭‬‏‍⁮⁫‬‏⁬‫‏‌‏⁪‮‏⁫​‎‎‮‌‮‮((Window) engineView));
            this.LoadEventHandlers();
            num1 = (int) num3 * -1661137081 ^ -1425133596;
            continue;
          case 2:
            EngineViewModel.\u206F⁪‍⁮‪‮‎⁪‍⁮⁭⁬‍⁭‭‏‌‪‬‪‎⁬‮⁮‍‭‌‏​‬⁭‪⁯‮‫‫‬‌‏‮‮(this.WindowTimer, new EventHandler(this.WindowTimer_Tick));
            num1 = (int) num3 * -2026896203 ^ -833269268;
            continue;
          case 3:
            this.View = (Window) engineView;
            this.Engine = engine;
            num1 = (int) num3 * -548907414 ^ -403761870;
            continue;
          case 4:
            this.Engine.Settings.EngineView_DisplayQuickLinkBar = true;
            num1 = (int) num3 * 631336158 ^ 867065807;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 846683670 ^ 1188588318;
            continue;
          case 7:
            int num4 = !flag ? 694593301 : (num4 = 508569609);
            int num5 = (int) num3 * 1402167283;
            num1 = num4 ^ num5;
            continue;
          case 8:
            this.LoadMonitors();
            num1 = (int) num3 * -1085140131 ^ -1359149363;
            continue;
          case 9:
            this.LoadViewModels();
            num1 = (int) num3 * 828771436 ^ 75731434;
            continue;
          case 10:
            this.desktopAlertManager = EngineViewModel.\u206E‌⁭‫‮‮‌‭⁫‌⁫⁯⁪⁮⁫‌‭‬‎⁫‬‌‫⁪⁪⁭‍‪⁬⁪‫⁭⁫⁭‍‌‫‍‫‬‮();
            num1 = (int) num3 * -2109769790 ^ 140490047;
            continue;
          case 11:
            this.WindowTimer = EngineViewModel.\u206A‪‏‬⁪‏‭⁪‭‬‭‬‏​‬‭‎‫‮⁫‭⁬‭‏⁪⁫‫⁭​⁭⁫‏​‫⁫​‌‍⁯⁯‮(DispatcherPriority.Normal, EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) engineView));
            EngineViewModel.\u206C‫‌‎‮‌⁪⁯‪⁫⁭‎⁬‍‭‌‌⁫‎⁮‍​‍⁮‭‍‪⁯⁫‫‎‍‫‫‭‮‮‌‭‏‮(this.WindowTimer, TimeSpan.FromSeconds(1.0));
            num1 = (int) num3 * -64240109 ^ 149826514;
            continue;
          case 12:
            goto label_1;
          case 13:
            EngineViewModel.\u202E‪⁫‍‬‭⁫⁯⁪⁫‍⁮‏⁪‏⁮‬​‍‏⁬‌⁭‎⁭‏‎‏‏⁬‎⁮‫‬‍‪‍⁯‬⁪‮(this.WindowTimer);
            this.RaiseAllPropertiesChanged();
            num1 = (int) num3 * -2134541338 ^ 717242871;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    private bool CanOpenImageViewer()
    {
      bool flag = true;
label_1:
      int num1 = -823244476;
      while (true)
      {
        int num2 = -1720231217;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1863212938 ^ -325537155;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void OpenImageViewer()
    {
      this.ImageHistoryViewModel.DisplayView();
    }

    private void LoadViewModels()
    {
label_1:
      int num1 = -1485706882;
      while (true)
      {
        int num2 = -1975826331;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * -1842981663 ^ 1898525662;
            continue;
          case 1:
            this.ImageHistoryViewModel.Initialize((EngineView) this.View);
            num1 = (int) num3 * 1183932517 ^ -1880651580;
            continue;
          case 2:
            this.ImageHistoryViewModel = new ImageHistoryViewModel(ApplicationService.Instance.EventAggregator);
            num1 = (int) num3 * -767286613 ^ -195278026;
            continue;
          case 3:
            goto label_3;
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

    private void LoadEventHandlers()
    {
      this.Engine.PropertyChanged += new PropertyChangedEventHandler(this.ZoomZoom_PropertyChanged);
label_1:
      int num1 = 2084687161;
      while (true)
      {
        int num2 = 239433978;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            this.Engine.OnWindowHighlightEnd += new EventHandler(this.ZoomZoom_OnWindowHighlightEnd);
            num1 = (int) num3 * -727469774 ^ 2076070837;
            continue;
          case 1:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityStartedEvent>()).Subscribe(new Action<ActivityEventBaseArguments>(this.ActivityStarted), (ThreadOption) 1);
            num1 = (int) num3 * 1071118637 ^ -1865044983;
            continue;
          case 2:
            num1 = (int) num3 * 1012315609 ^ 342745276;
            continue;
          case 3:
            goto label_1;
          case 4:
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.PatternChanged), (ThreadOption) 1, false, (Predicate<ObjectChangedEventPayload>) (obj =>
            {
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              bool flag = EngineViewModel.\u003C\u003Ec.\u200F‫⁭​‭⁯‫‫‍⁯⁮‬‬‬⁯⁬⁪‭⁮‪‏‎‭⁯⁯‮‎⁮‍‏‎‬​​​‮⁫‮‎‭‮(obj.ObjectType, EngineViewModel.\u003C\u003Ec.\u206A​⁪⁬‬‮⁪‫⁫​⁭⁭‬‍⁮‮‏‬‭⁫‌⁬​⁫‫⁫⁬‍‏‬‪⁬⁬‏⁬⁪‏‏‬‌‮(__typeref (LayoutPattern)));
label_1:
              int num2 = -1114070368;
              while (true)
              {
                int num3 = -1560570406;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 1:
                    num2 = (int) num4 * 795752309 ^ 861807083;
                    continue;
                  case 2:
                    goto label_1;
                  default:
                    goto label_4;
                }
              }
label_4:
              return flag;
            }));
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityProgressEvent>()).Subscribe(new Action<ActivityEventBaseArguments>(this.ActivityProgressReported), (ThreadOption) 1, true);
            num1 = 541995452;
            continue;
          case 5:
            this.Engine.OnMeetingJoined += new EventHandler(this.ZoomZoom_OnMeetingJoined);
            this.Engine.OnMeetingLeft += new EventHandler(this.ZoomZoom_OnMeetingLeft);
            num1 = (int) num3 * -1497488786 ^ -1313206657;
            continue;
          case 6:
            this.Engine.OnMeetingsChanged += new EventHandler(this.ZoomZoom_OnMeetingsChanged);
            num1 = (int) num3 * 651063944 ^ 433983908;
            continue;
          case 7:
            this.Engine.OnActivityStarted += new EventHandler(this.ZoomZoom_OnActivityStarted);
            this.Engine.OnActivityEnded += new EventHandler(this.ZoomZoom_OnActivityEnded);
            this.Engine.OnActivityProgressReport += new EventHandler(this.ZoomZoom_OnActivityProgressReport);
            num1 = (int) num3 * -1590073576 ^ -1970942150;
            continue;
          case 8:
            goto label_3;
          case 9:
            this.Engine.OnWindowHighlightStart += new EventHandler(this.ZoomZoom_OnWindowHighlightStart);
            num1 = (int) num3 * 1909756461 ^ 2077632502;
            continue;
          case 10:
            this.LoadPatterns();
            num1 = (int) num3 * 650858276 ^ 634149480;
            continue;
          case 11:
            num1 = (int) num3 * -1367353579 ^ -1811458097;
            continue;
          case 12:
            this.Engine.OnLogMessageChanged += new EventHandler(this.ZoomZoom_OnLogMessageChanged);
            num1 = (int) num3 * 180171272 ^ -724042275;
            continue;
          case 13:
            this.Engine.OnWindowHighlightUpdate += new EventHandler(this.ZoomZoom_OnWindowHighlightUpdate);
            ((CompositePresentationEvent<ZoomChat>) this._eventAggregator.GetEvent<ChatReceivedEvent>()).Subscribe(new Action<ZoomChat>(this.ChatReceived), (ThreadOption) 1);
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityEndedEvent>()).Subscribe(new Action<ActivityEventBaseArguments>(this.ActivityEnded), (ThreadOption) 1);
            num1 = (int) num3 * 1770382299 ^ 912022832;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    private void ActivityProgressReported(ActivityEventBaseArguments obj)
    {
      object modelLock = ViewModelBase.modelLock;
      bool flag = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag);
label_2:
        int num1 = -274174453;
        while (true)
        {
          int num2 = -796460897;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_12;
            case 1:
              this.MajorStatus = obj.Status;
              num1 = (int) num3 * 1467542058 ^ 772958904;
              continue;
            case 2:
              num1 = (int) num3 * -42641682 ^ -2114672196;
              continue;
            case 3:
              this.ActivityInProgress = this.Engine.ActiveActivity != null;
              num1 = (int) num3 * 735077798 ^ -797221266;
              continue;
            case 4:
              goto label_2;
            case 5:
              num1 = (int) num3 * 2012668267 ^ 2090958666;
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
          int num1 = -89649554;
          while (true)
          {
            int num2 = -796460897;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num1 = (int) num3 * -1935481370 ^ 217513483;
                continue;
              case 2:
                num1 = (int) num3 * -130914430 ^ 103872439;
                continue;
              case 3:
                goto label_10;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    private void LoadPatterns()
    {
label_1:
      int num1 = 1472423234;
      while (true)
      {
        int num2 = 429153941;
        uint num3;
        int index;
        LayoutPattern pattern;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            goto label_1;
          case 1:
            this.AddPattern(pattern);
            num1 = (int) num3 * 460181380 ^ 1561672829;
            continue;
          case 2:
            index = 0;
            num1 = (int) num3 * 1502836399 ^ 163911283;
            continue;
          case 3:
            num1 = (int) num3 * 1329269973 ^ -872437236;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * 1213201565 ^ -656774194;
            continue;
          case 6:
            this.Patterns = new List<LayoutPattern>();
            num1 = (int) num3 * -109081788 ^ -272817190;
            continue;
          case 7:
            ++index;
            num1 = (int) num3 * 1776053622 ^ -240624253;
            continue;
          case 8:
            num1 = (int) num3 * -1815848233 ^ -1601876583;
            continue;
          case 9:
            int num4;
            num1 = num4 = index < ((Collection<LayoutPattern>) this.Engine.Patterns).Count ? 1259445591 : (num4 = 1646496391);
            continue;
          case 10:
            pattern = ((Collection<LayoutPattern>) this.Engine.Patterns)[index];
            num1 = (int) num3 * 1724631619 ^ -1818709000;
            continue;
          case 11:
            this.SelectedPattern = Engine.Instance.ActivePattern;
            num1 = (int) num3 * 36208456 ^ 2138649699;
            continue;
          case 12:
            num1 = 1754204216;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    private void PatternChanged(ObjectChangedEventPayload obj)
    {
      int num1;
      switch (obj.ChangeType)
      {
        case ChangeType.Updated:
          return;
        case ChangeType.Added:
label_4:
          this.AddPattern((LayoutPattern) obj.ChangedObject);
          num1 = 660469878;
          break;
        case ChangeType.Removed:
label_13:
          this.RemovePattern((LayoutPattern) obj.ChangedObject);
          num1 = 1289331476;
          break;
        case ChangeType.Activated:
label_11:
          this.ActivePattern = (LayoutPattern) obj.ChangedObject;
          num1 = 1085561411;
          break;
        case ChangeType.Deactivated:
label_15:
          this.ActivePattern = this.Engine.ActivePattern;
          num1 = 596071657;
          break;
        case ChangeType.Saved:
          return;
        default:
label_1:
          num1 = 419496572;
          break;
      }
      while (true)
      {
        int num2 = 1755025941;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            goto label_11;
          case 1:
            num1 = (int) num3 * 442131712 ^ 583238971;
            continue;
          case 2:
            goto label_10;
          case 3:
            num1 = (int) num3 * -685056297 ^ -95431906;
            continue;
          case 4:
            num1 = (int) num3 * 1540075792 ^ -311033733;
            continue;
          case 5:
            goto label_15;
          case 6:
            this.AddPattern((LayoutPattern) obj.ChangedObject);
            num1 = (int) num3 * -335615712 ^ 752711663;
            continue;
          case 7:
            goto label_9;
          case 8:
            goto label_4;
          case 9:
            num1 = (int) num3 * 1978506395 ^ -70091548;
            continue;
          case 10:
            num1 = (int) num3 * 643403141 ^ 1547630873;
            continue;
          case 11:
            goto label_13;
          case 12:
            num1 = (int) num3 * -1490732425 ^ -1917640459;
            continue;
          case 13:
            goto label_3;
          case 14:
            goto label_18;
          case 15:
            goto label_1;
          default:
            goto label_20;
        }
      }
label_18:
      return;
label_20:
      return;
label_3:
      return;
label_10:
      return;
label_9:;
    }

    private void RemovePattern(LayoutPattern obj)
    {
      object modelLock = ViewModelBase.modelLock;
      bool flag1 = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag1);
label_2:
        int num1 = 1860863819;
        while (true)
        {
          int num2 = 190908902;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_12;
            case 1:
              int num4 = flag2 ? 1157978590 : (num4 = 579530074);
              int num5 = (int) num3 * -1411549198;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.Patterns.Remove(obj);
              num1 = (int) num3 * -1523593605 ^ -1635722376;
              continue;
            case 3:
              flag2 = this.Patterns.Contains(obj);
              num1 = (int) num3 * -1253725842 ^ -1900619297;
              continue;
            case 4:
              num1 = (int) num3 * -2136729488 ^ 653719010;
              continue;
            case 5:
              goto label_2;
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
        if (flag1)
        {
label_10:
          int num1 = 1624950397;
          while (true)
          {
            int num2 = 190908902;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -1148956831 ^ -1443543021;
                continue;
              case 2:
                goto label_10;
              case 3:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num1 = (int) num3 * 558152367 ^ 1102118211;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    private void AddPattern(LayoutPattern obj)
    {
      object modelLock = ViewModelBase.modelLock;
      bool flag = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag);
label_2:
        int num1 = -215692508;
        while (true)
        {
          int num2 = -1710479177;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * -880875822 ^ -412724016;
              continue;
            case 2:
              goto label_14;
            case 3:
              num1 = (int) num3 * 1338733837 ^ 1441529191;
              continue;
            case 4:
              int num4 = !this.Patterns.Contains(obj) ? 387434505 : (num4 = 701274117);
              int num5 = (int) num3 * 94181822;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * -247080145 ^ 133372214;
              continue;
            case 6:
              this.Patterns.Add(obj);
              num1 = (int) num3 * 1257571169 ^ -1274257984;
              continue;
            case 7:
              num1 = (int) num3 * 1267590265 ^ -73981660;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:;
      }
      finally
      {
        if (flag)
        {
label_12:
          int num1 = -1253533180;
          while (true)
          {
            int num2 = -1710479177;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -1647909809 ^ 1574417690;
                continue;
              case 2:
                goto label_12;
              case 3:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num1 = (int) num3 * -398518050 ^ 1399937161;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    private void ActivityStarted(ActivityEventBaseArguments e)
    {
label_1:
      int num1 = 546086840;
      while (true)
      {
        int num2 = 1553454158;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.SetStatus(e.TargetGuid);
            num1 = (int) num3 * 1422907764 ^ -610047929;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.ActivityInProgress = true;
    }

    private void ActivityEnded(ActivityEventBaseArguments e)
    {
      this.SetStatus("");
label_1:
      int num1 = -637042828;
      while (true)
      {
        int num2 = -2061347130;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1394753232 ^ -48738979;
            continue;
          case 2:
            this.ActivityInProgress = false;
            num1 = (int) num3 * 281037775 ^ -483391571;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void ChatReceived(ZoomChat obj)
    {
label_1:
      int num1 = -1161536455;
      while (true)
      {
        int num2 = -1089242264;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            if (!this.Engine.Settings.DesktopAlert_Enabled)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1907244041 ^ 260181676;
            continue;
          case 2:
            this.DisplayChatAlert((object) obj);
            num1 = (int) num3 * -2025257519 ^ -336197804;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * 1554024740 ^ -1895566131;
            continue;
          case 5:
            num4 = this.Engine.ActiveMeeting != null ? 1 : 0;
            break;
          case 6:
            num1 = -240803362;
            continue;
          case 7:
            int num5 = this.EligibleForDispay(obj) ? -1898784306 : (num5 = -1687124730);
            int num6 = (int) num3 * -58411281;
            num1 = num5 ^ num6;
            continue;
          case 8:
            num1 = (int) num3 * 830038940 ^ 1299163808;
            continue;
          default:
            goto label_14;
        }
        int num7;
        num1 = num7 = num4 != 0 ? -763087842 : (num7 = -240803362);
      }
label_14:
      return;
label_3:;
    }

    private bool EligibleForDispay(ZoomChat chat)
    {
label_1:
      int num1 = -556366230;
      bool flag1;
      while (true)
      {
        int num2 = -444503265;
        uint num3;
        bool flag2;
        bool flag3;
        bool flag4;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            if (this.Engine.Settings.DesktopAlert_Enabled)
            {
              num1 = (int) num3 * 1909084532 ^ 149181243;
              continue;
            }
            num4 = 0;
            goto label_28;
          case 1:
            flag4 = false;
            num1 = (int) num3 * -1821600671 ^ 305691351;
            continue;
          case 2:
            num1 = (int) num3 * -1576000700 ^ -941740285;
            continue;
          case 3:
            if (this.Engine.Settings.DesktopAlert_ShowOnlyIfReceived)
            {
              num1 = (int) num3 * 131845585 ^ -1981624937;
              continue;
            }
            goto label_13;
          case 4:
            int num7 = flag2 ? 789987051 : (num7 = 355904737);
            int num8 = (int) num3 * 494231025;
            num1 = num7 ^ num8;
            continue;
          case 5:
            goto label_1;
          case 6:
            num5 = !chat.WasBlocked ? 1 : 0;
            goto label_14;
          case 7:
            flag4 = true;
            num1 = (int) num3 * 901510510 ^ -1981519887;
            continue;
          case 8:
            num1 = -1280384774;
            continue;
          case 9:
            num1 = (int) num3 * 343309347 ^ -783165925;
            continue;
          case 10:
            num4 = !EngineViewModel.\u202B‬‫‭‬‬‭⁪⁪​⁬⁬​‪⁮​⁮⁮‍⁬⁫‫⁯‌⁭⁮‫⁮⁯‫‮‎‍​⁯‫​‎⁮‏‮(this.Engine.Settings.DesktopAlert_IgnoredUsers, chat.SendingZoomId) ? 1 : 0;
            goto label_28;
          case 11:
            num1 = (int) num3 * 1341089471 ^ -767050609;
            continue;
          case 12:
            if (this.Engine.Settings.DesktopAlert_ShowOnlyIfReceived)
            {
              num6 = 0;
              break;
            }
            num1 = -1910902699;
            continue;
          case 14:
            num6 = !chat.WasBlocked ? 1 : 0;
            break;
          case 15:
            flag4 = true;
            num1 = (int) num3 * -1347560511 ^ -1425756005;
            continue;
          case 16:
            if (chat.WasRecipient)
            {
              num1 = (int) num3 * -1348618392 ^ 1636458048;
              continue;
            }
            goto label_13;
          case 17:
            int num9 = flag3 ? -348376470 : (num9 = -1251238479);
            int num10 = (int) num3 * 1537727896;
            num1 = num9 ^ num10;
            continue;
          case 18:
            flag1 = flag4;
            num1 = -984189832;
            continue;
          default:
            goto label_30;
        }
        int num11;
        num1 = num11 = num6 == 0 ? -1612079489 : (num11 = -1966844562);
        continue;
label_13:
        num5 = 0;
label_14:
        flag3 = num5 != 0;
        num1 = -635248627;
        continue;
label_28:
        flag2 = num4 != 0;
        num1 = -469973548;
      }
label_30:
      return flag1;
    }

    private void ChatsReceived(List<ZoomChat> obj)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EngineViewModel.\u003C\u003Ec__DisplayClass154_0 displayClass1540 = new EngineViewModel.\u003C\u003Ec__DisplayClass154_0();
label_1:
      int num1 = -6386260;
      while (true)
      {
        int num2 = -76721569;
        uint num3;
        AlertValues alertValues;
        List<ZoomChat> list;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1683093394 ^ 945038011;
            continue;
          case 2:
            num1 = (int) num3 * 210678586 ^ -340658469;
            continue;
          case 3:
            this.ShowDesktopAlert((object) alertValues);
            num1 = (int) num3 * 1740757967 ^ -1245509;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            displayClass1540.older = ((IEnumerable<ZoomChat>) Enumerable.Where<ZoomChat>((IEnumerable<M0>) obj, (Func<M0, bool>) (EngineViewModel.\u003C\u003Ec.\u003C\u003E9__154_0 ?? (EngineViewModel.\u003C\u003Ec.\u003C\u003E9__154_0 = new Func<ZoomChat, bool>((object) EngineViewModel.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CChatsReceived\u003Eb__154_0)))))).ToList<ZoomChat>();
            int num4;
            // ISSUE: reference to a compiler-generated field
            num1 = num4 = displayClass1540.older.Count <= 0 ? -17063881 : (num4 = -2068347734);
            continue;
          case 5:
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomChat>) Enumerable.Where<ZoomChat>((IEnumerable<M0>) obj, (Func<M0, bool>) new Func<ZoomChat, bool>((object) displayClass1540, __methodptr(\u003CChatsReceived\u003Eb__1)))).ToList<ZoomChat>();
            num1 = -1342976426;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            displayClass1540.\u003C\u003E4__this = this;
            num1 = (int) num3 * -1070182327 ^ -578944291;
            continue;
          case 7:
            if (flag)
            {
              num1 = (int) num3 * 379633294 ^ 2060184063;
              continue;
            }
            goto label_32;
          case 8:
            // ISSUE: reference to a compiler-generated field
            alertValues = new AlertValues(EngineViewModel.\u200F‍‫‪‌‍⁫‬‮⁮‏⁯​‮⁯‮⁪‭‏⁬‎‮‍‏‎⁮​‌⁭‮⁯‬⁫‍⁬⁯‍⁬‭⁪‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2475083828U), (object) displayClass1540.older.Count), "", new System.Windows.Media.Color?(EngineViewModel.\u200D⁭⁮⁫‎⁫‌‪‫​⁮‭‌‭‎⁮‎‬⁮⁫⁪‎‮⁭‬‭‏‌‬⁮⁮⁬⁫⁮‍⁫‮‍‎⁬‮()));
            num1 = (int) num3 * -486745827 ^ 1385553352;
            continue;
          case 9:
            flag = list.Count < 5;
            num1 = (int) num3 * -1284804941 ^ 389264746;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      List<ZoomChat>.Enumerator enumerator = obj.GetEnumerator();
      try
      {
label_20:
        int num2 = enumerator.MoveNext() ? -818263716 : (num2 = -1901315363);
        while (true)
        {
          int num3 = -76721569;
          uint num4;
          ZoomChat current;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = -818263716;
              continue;
            case 1:
              current = enumerator.Current;
              num2 = -895961585;
              continue;
            case 2:
              num2 = (int) num4 * -408389476 ^ 271907490;
              continue;
            case 3:
              this.DisplayChatAlert((object) current);
              num2 = (int) num4 * 881564101 ^ 1720750685;
              continue;
            case 4:
              goto label_28;
            case 5:
              goto label_20;
            default:
              goto label_25;
          }
        }
label_25:
        return;
label_28:
        return;
      }
      finally
      {
        enumerator.Dispose();
label_23:
        int num2 = -1946182871;
        while (true)
        {
          int num3 = -76721569;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -171050188 ^ -1409033050;
              continue;
            case 2:
              goto label_23;
            default:
              goto label_27;
          }
        }
label_27:;
      }
label_32:
      int num5 = -255691691;
      while (true)
      {
        int num2 = -76721569;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 4U)
        {
          case 0:
            goto label_31;
          case 1:
            goto label_32;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.ShowDesktopAlert((object) new AlertValues(EngineViewModel.\u200F‍‫‪‌‍⁫‬‮⁮‏⁯​‮⁯‮⁪‭‏⁬‎‮‍‏‎⁮​‌⁭‮⁯‬⁫‍⁬⁯‍⁬‭⁪‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(960711972U), (object) displayClass1540.older.Count), "", new System.Windows.Media.Color?(EngineViewModel.\u200D⁭⁮⁫‎⁫‌‪‫​⁮‭‌‭‎⁮‎‬⁮⁫⁪‎‮⁭‬‭‏‌‬⁮⁮⁬⁫⁮‍⁫‮‍‎⁬‮())));
            num5 = (int) num3 * 806740775 ^ -839184415;
            continue;
          case 3:
            num5 = -476606698;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return;
label_31:;
    }

    private void DisplayChatAlert(object e)
    {
      bool flag1 = false;
label_1:
      int num1 = 1782369197;
      while (true)
      {
        int num2 = 1648281911;
        uint num3;
        ZoomChat zoomChat;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        AlertValues alertValues;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 27U)
        {
          case 0:
            num4 = !EngineViewModel.\u202B‬‫‭‬‬‭⁪⁪​⁬⁬​‪⁮​⁮⁮‍⁬⁫‫⁯‌⁭⁮‫⁮⁯‫‮‎‍​⁯‫​‎⁮‏‮(this.Engine.Settings.DesktopAlert_IgnoredUsers, zoomChat.SendingZoomId) ? 1 : 0;
            goto label_35;
          case 1:
            flag5 = flag1;
            num1 = 2090034962;
            continue;
          case 2:
            num5 = !zoomChat.WasBlocked ? 1 : 0;
            goto label_38;
          case 3:
            int num7 = !flag5 ? 469211186 : (num7 = 198952938);
            int num8 = (int) num3 * -1270431172;
            num1 = num7 ^ num8;
            continue;
          case 4:
            zoomChat = e as ZoomChat;
            flag2 = zoomChat != null;
            num1 = (int) num3 * -1230644787 ^ 954538698;
            continue;
          case 5:
            num1 = (int) num3 * -2092874100 ^ -1893935401;
            continue;
          case 6:
            alertValues = new AlertValues(EngineViewModel.\u202C‭‏‬‪⁪‎‎‫‭⁭‫⁮⁮‮‌‍‪‍⁫‪‏‭⁪⁬⁫‮⁬​⁭‮‫⁫‍‭​‏‮‍⁪‮(zoomChat.SendingZoomId, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2738917136U)), zoomChat.ChatContent, new System.Windows.Media.Color?(EngineViewModel.\u206D‬‫⁪⁯​⁪⁪‪‎⁭‭‭‫⁭‎‭‮⁬‫‌⁬‭⁮‏‫⁯⁬⁫‬​‍⁬‭‏​‎⁯‏‫‮()));
            num1 = (int) num3 * 1969288203 ^ 928985838;
            continue;
          case 7:
            num6 = !zoomChat.WasBlocked ? 1 : 0;
            break;
          case 8:
            goto label_3;
          case 9:
            if (this.Engine.Settings.DesktopAlert_Enabled)
            {
              num1 = (int) num3 * 2001835164 ^ -68035205;
              continue;
            }
            num4 = 0;
            goto label_35;
          case 10:
            num1 = 1112384743;
            continue;
          case 11:
            int num9 = flag4 ? -1267523916 : (num9 = -1778884120);
            int num10 = (int) num3 * -1803603500;
            num1 = num9 ^ num10;
            continue;
          case 12:
            int num11 = flag3 ? -420216279 : (num11 = -901679995);
            int num12 = (int) num3 * 738415085;
            num1 = num11 ^ num12;
            continue;
          case 13:
            this.ShowDesktopAlert((object) alertValues);
            num1 = (int) num3 * 1263042157 ^ 1015360940;
            continue;
          case 14:
            num1 = (int) num3 * 834165981 ^ -1589652021;
            continue;
          case 15:
            num1 = (int) num3 * -2145616230 ^ 1119995767;
            continue;
          case 16:
            num1 = (int) num3 * -63482223 ^ -337125051;
            continue;
          case 17:
            flag1 = true;
            num1 = (int) num3 * -1986461882 ^ -1842932808;
            continue;
          case 18:
            flag1 = true;
            num1 = (int) num3 * -974492319 ^ -61771173;
            continue;
          case 19:
            num1 = (int) num3 * 670539284 ^ -1518690582;
            continue;
          case 20:
            num1 = (int) num3 * 495734656 ^ 1845447300;
            continue;
          case 21:
            if (zoomChat.WasRecipient)
            {
              num1 = (int) num3 * 2119140979 ^ 54292365;
              continue;
            }
            goto label_37;
          case 22:
            goto label_1;
          case 23:
            num1 = 1953825216;
            continue;
          case 24:
            if (this.Engine.Settings.DesktopAlert_ShowOnlyIfReceived)
            {
              num1 = (int) num3 * -1449287535 ^ 211684120;
              continue;
            }
            goto label_37;
          case 25:
            int num13 = !flag2 ? 1437652018 : (num13 = 834179376);
            int num14 = (int) num3 * 484145582;
            num1 = num13 ^ num14;
            continue;
          case 26:
            if (this.Engine.Settings.DesktopAlert_ShowOnlyIfReceived)
            {
              num6 = 0;
              break;
            }
            num1 = 1435414518;
            continue;
          default:
            goto label_39;
        }
        flag4 = num6 != 0;
        num1 = 1796270191;
        continue;
label_35:
        int num15;
        num1 = num15 = num4 == 0 ? 1112384743 : (num15 = 1800347079);
        continue;
label_37:
        num5 = 0;
label_38:
        flag3 = num5 != 0;
        num1 = 582378035;
      }
label_39:
      return;
label_3:;
    }

    private void ZoomZoom_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      bool flag = EngineViewModel.\u200E⁮‌⁮⁪‮‍‭‎‭‌⁬‭⁮‍‪‭⁪⁭‌‪‮⁪‬‍‫⁫⁪⁪‮‪⁪‏‮⁮⁯‮‬⁯‍‮(EngineViewModel.\u202A‪⁬⁯⁭‫⁬⁯⁪⁮‎‮⁪‬⁪‌‮‮‍⁮‪⁮⁯‌⁯‏⁯⁯‪⁮‭​⁮‮‪⁮‬⁮⁫‏‮(e), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3555768355U));
label_1:
      int num1 = 595564499;
      while (true)
      {
        int num2 = 1057114580;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1408993374U));
            num1 = (int) num3 * -3528632 ^ -490998347;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            int num4 = !flag ? 402607267 : (num4 = 632409198);
            int num5 = (int) num3 * -1749137830;
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

    private void ZoomZoom_OnWindowHighlightStart(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EngineViewModel.\u003C\u003Ec__DisplayClass157_0 displayClass1570 = new EngineViewModel.\u003C\u003Ec__DisplayClass157_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1570.\u003C\u003E4__this = this;
label_1:
      int num1 = 2042018474;
      while (true)
      {
        int num2 = 346547461;
        uint num3;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            goto label_3;
          case 1:
            num4 = EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()) == null ? 1 : 0;
            break;
          case 2:
            num1 = (int) num3 * -682397228 ^ -1061247043;
            continue;
          case 3:
            // ISSUE: method pointer
            EngineViewModel.\u202B⁭‌​‌⁮‏​⁪‭‪‌​⁭⁭⁭⁮‮⁮⁪⁫‏‭​‭⁭‪‪‮‮​‬‭‫‬‌⁮‭‪‪‮(EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()), new Action((object) displayClass1570, __methodptr(\u003CZoomZoom_OnWindowHighlightStart\u003Eb__0)));
            num1 = 50067660;
            continue;
          case 4:
            int num5 = flag1 ? -1340293464 : (num5 = -109950288);
            int num6 = (int) num3 * -324235220;
            num1 = num5 ^ num6;
            continue;
          case 5:
            int num7 = !flag2 ? -390587701 : (num7 = -211284820);
            int num8 = (int) num3 * -633566433;
            num1 = num7 ^ num8;
            continue;
          case 6:
            num1 = (int) num3 * -849466424 ^ -1455737849;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            displayClass1570.rect = Rectangle.Empty;
            num1 = (int) num3 * -351623365 ^ -834360452;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            displayClass1570.args = e as HighlightEventArg;
            // ISSUE: reference to a compiler-generated field
            flag2 = displayClass1570.args != null;
            num1 = (int) num3 * 2054583536 ^ 253466187;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            displayClass1570.rect = displayClass1570.args.Highlight.Rectangle;
            num1 = (int) num3 * 1010803433 ^ -1844017799;
            continue;
          case 10:
            num1 = (int) num3 * 1613901778 ^ 1345522509;
            continue;
          case 11:
            if (EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮() == null)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * 1655257741 ^ -1702985390;
            continue;
          case 12:
            goto label_1;
          default:
            goto label_18;
        }
        flag1 = num4 != 0;
        num1 = 1936024557;
      }
label_18:
      return;
label_3:;
    }

    private void HighlightWindow_Closed(object sender, EventArgs e)
    {
    }

    private void ZoomZoom_OnWindowHighlightUpdate(object sender, EventArgs e)
    {
      bool flag1 = this.HighlightWindow != null;
label_1:
      int num1 = -1908971455;
      while (true)
      {
        int num2 = -1868408365;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            int num5 = flag2 ? 2097928118 : (num5 = 1320989893);
            int num6 = (int) num3 * 655036982;
            num1 = num5 ^ num6;
            continue;
          case 1:
            num1 = (int) num3 * 439424487 ^ 1485714526;
            continue;
          case 2:
            num1 = (int) num3 * 1636766373 ^ 639849703;
            continue;
          case 3:
            if (EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮() != null)
            {
              num1 = (int) num3 * 1882645112 ^ -1820738122;
              continue;
            }
            num4 = 1;
            break;
          case 4:
            int num7 = !flag1 ? 510072451 : (num7 = 1841639132);
            int num8 = (int) num3 * -592875309;
            num1 = num7 ^ num8;
            continue;
          case 5:
            goto label_1;
          case 6:
            // ISSUE: method pointer
            EngineViewModel.\u202B⁭‌​‌⁮‏​⁪‭‪‌​⁭⁭⁭⁮‮⁮⁪⁫‏‭​‭⁭‪‪‮‮​‬‭‫‬‌⁮‭‪‪‮(EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()), new Action((object) this, __methodptr(\u003CZoomZoom_OnWindowHighlightUpdate\u003Eb__159_0)));
            num1 = -571630055;
            continue;
          case 7:
            num4 = EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()) == null ? 1 : 0;
            break;
          case 8:
            goto label_3;
          case 9:
            num1 = (int) num3 * -2131301160 ^ 451426472;
            continue;
          default:
            goto label_15;
        }
        flag2 = num4 != 0;
        num1 = -1150201897;
      }
label_15:
      return;
label_3:;
    }

    private void ZoomZoom_OnWindowHighlightEnd(object sender, EventArgs e)
    {
      if (this.HighlightWindow == null)
        return;
label_1:
      int num1 = -241773949;
      while (true)
      {
        int num2 = -2026915283;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_15;
          case 2:
            num4 = EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()) == null ? 1 : 0;
            break;
          case 3:
            // ISSUE: method pointer
            EngineViewModel.\u202B⁭‌​‌⁮‏​⁪‭‪‌​⁭⁭⁭⁮‮⁮⁪⁫‏‭​‭⁭‪‪‮‮​‬‭‫‬‌⁮‭‪‪‮(EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()), new Action((object) this, __methodptr(\u003CZoomZoom_OnWindowHighlightEnd\u003Eb__160_0)));
            num1 = -31105818;
            continue;
          case 4:
            int num5 = !flag ? -595173488 : (num5 = -680962422);
            int num6 = (int) num3 * -764997915;
            num1 = num5 ^ num6;
            continue;
          case 5:
            if (EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮() != null)
            {
              num1 = (int) num3 * -98681212 ^ 1440246803;
              continue;
            }
            num4 = 1;
            break;
          case 6:
            num1 = (int) num3 * -1183872273 ^ 852149406;
            continue;
          case 7:
            num1 = (int) num3 * 69639235 ^ -1363965009;
            continue;
          case 8:
            num1 = (int) num3 * 2120715887 ^ 1137838672;
            continue;
          case 9:
            num1 = (int) num3 * 265356039 ^ 401212694;
            continue;
          default:
            goto label_16;
        }
        flag = num4 != 0;
        num1 = -1468118835;
      }
label_16:
      return;
label_15:;
    }

    private void ZoomZoom_OnLogMessageChanged(object sender, EventArgs e)
    {
label_1:
      int num1 = -259223369;
      while (true)
      {
        int num2 = -1705351468;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.SetStatus(((ZoomZoomEventArgs) e).EventDescription);
            num1 = (int) num3 * 246411065 ^ -1949185287;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void ZoomZoom_OnMeetingsChanged(object sender, EventArgs e)
    {
label_1:
      int num1 = 1349541669;
      while (true)
      {
        int num2 = 1392002160;
        uint num3;
        ZoomMeetingEventArgs meetingEventArgs;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            if (meetingEventArgs.ChangedProperty == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1827389180 ^ 414674826;
            continue;
          case 1:
            num1 = (int) num3 * 1956684365 ^ 1871060494;
            continue;
          case 2:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2922421607U));
            num1 = (int) num3 * -5532537 ^ 1411703045;
            continue;
          case 3:
            meetingEventArgs = e as ZoomMeetingEventArgs;
            flag2 = meetingEventArgs != null;
            num1 = (int) num3 * -1255250681 ^ -1593377439;
            continue;
          case 4:
            int num5 = !flag1 ? -1328840735 : (num5 = -1388832093);
            int num6 = (int) num3 * 994633749;
            num1 = num5 ^ num6;
            continue;
          case 5:
            int num7 = flag2 ? -1044005856 : (num7 = -703629926);
            int num8 = (int) num3 * -413608871;
            num1 = num7 ^ num8;
            continue;
          case 6:
            goto label_1;
          case 7:
            num4 = meetingEventArgs.ChangedProperty is ZoomButton ? 1 : 0;
            break;
          case 8:
            goto label_3;
          case 9:
            num1 = 798028392;
            continue;
          case 10:
            num1 = (int) num3 * 1140811299 ^ -1932110527;
            continue;
          default:
            goto label_16;
        }
        flag1 = num4 != 0;
        num1 = 1993065637;
      }
label_16:
      return;
label_3:;
    }

    private void ZoomZoom_OnMeetingJoined(object sender, EventArgs e)
    {
label_1:
      int num1 = 636523488;
      while (true)
      {
        int num2 = 1699412464;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            int num4 = flag ? 1212162697 : (num4 = 599835067);
            int num5 = (int) num3 * -2072626165;
            num1 = num4 ^ num5;
            continue;
          case 1:
            EngineViewModel.\u202C‭‫​⁭​‬‫‏​‮⁯‫‫‮⁮‍⁫⁮​‮‮‫⁫‫⁯​⁪‎‮‫‭​​⁮⁫‮‬⁯⁬‮();
            flag = this.ActiveMeeting != null;
            num1 = (int) num3 * 1463302737 ^ 89106744;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -26973338 ^ 682387827;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * 1554583906 ^ 486429205;
            continue;
          case 6:
            this.SetStatus(EngineViewModel.\u200F‍‫‪‌‍⁫‬‮⁮‏⁯​‮⁯‮⁪‭‏⁬‎‮‍‏‎⁮​‌⁭‮⁯‬⁫‍⁬⁯‍⁬‭⁪‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3532000395U), (object) this.ActiveMeeting));
            num1 = (int) num3 * -220961176 ^ -402707685;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private void ZoomZoom_OnMeetingLeft(object sender, EventArgs e)
    {
      this.Engine.Settings.EngineView_DisplayQuickLinkBar = true;
label_1:
      int num1 = -528589131;
      while (true)
      {
        int num2 = -995626444;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -407751167 ^ -72819045;
            continue;
          case 2:
            this.SetStatus(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3025344063U));
            num1 = (int) num3 * 1646681389 ^ 1781100873;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void ZoomZoom_OnActivityStarted(object sender, EventArgs e)
    {
label_1:
      int num1 = -386789681;
      while (true)
      {
        int num2 = -1569803132;
        uint num3;
        ZoomActivityEventArgs activityEventArgs;
        ActivityBase activity;
        bool flag1;
        bool flag2;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            flag2 = activity != null;
            num1 = -1883965637;
            continue;
          case 1:
            this.SettingsViewModel.ToggleDisplayBars(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3192895207U));
            num1 = (int) num3 * -1959620844 ^ 599977025;
            continue;
          case 2:
            if (!(activity is JoinMeeting))
            {
              num1 = (int) num3 * 1355573728 ^ -1259984894;
              continue;
            }
            break;
          case 3:
            int num5 = flag3 ? -1260499260 : (num5 = -8864670);
            int num6 = (int) num3 * -610352257;
            num1 = num5 ^ num6;
            continue;
          case 4:
            this.SetStatus(activityEventArgs.Status);
            num1 = -2143362623;
            continue;
          case 5:
            goto label_1;
          case 6:
            num4 = activity is PeekMeeting ? 1 : 0;
            goto label_22;
          case 7:
            activityEventArgs = e as ZoomActivityEventArgs;
            num1 = (int) num3 * -1289045185 ^ 719163958;
            continue;
          case 8:
            int num7 = flag1 ? 831470757 : (num7 = 1479437784);
            int num8 = (int) num3 * -1293808031;
            num1 = num7 ^ num8;
            continue;
          case 9:
            goto label_20;
          case 10:
            if (activity != null)
            {
              num1 = (int) num3 * 8881722 ^ -1842915691;
              continue;
            }
            num4 = 0;
            goto label_22;
          case 11:
            num1 = (int) num3 * -846595517 ^ 1005368089;
            continue;
          case 12:
            num1 = (int) num3 * -290245968 ^ -148612395;
            continue;
          case 13:
            activity = activityEventArgs.Activity;
            num1 = (int) num3 * 950510208 ^ 2118304498;
            continue;
          case 14:
            int num9 = flag2 ? -324659375 : (num9 = -697088267);
            int num10 = (int) num3 * 221686246;
            num1 = num9 ^ num10;
            continue;
          case 15:
            if (!(activity is HammerMeeting))
            {
              num1 = (int) num3 * 1766132031 ^ -1341324291;
              continue;
            }
            break;
          case 16:
            this.ActivityInProgress = true;
            num1 = (int) num3 * -868707474 ^ -1296950236;
            continue;
          case 17:
            num1 = (int) num3 * 88607208 ^ 479160212;
            continue;
          case 18:
            flag1 = activityEventArgs != null;
            num1 = (int) num3 * -1605245907 ^ -728988218;
            continue;
          default:
            goto label_3;
        }
        num4 = 1;
label_22:
        flag3 = num4 != 0;
        num1 = -1519247235;
      }
label_3:
      return;
label_20:;
    }

    private void ZoomZoom_OnActivityEnded(object sender, EventArgs e)
    {
label_1:
      int num1 = -1496447549;
      while (true)
      {
        int num2 = -704718152;
        uint num3;
        ZoomActivityEventArgs activityEventArgs;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this.SetStatus(activityEventArgs.Status);
            num1 = (int) num3 * -834569940 ^ -487791260;
            continue;
          case 1:
            goto label_3;
          case 2:
            EngineViewModel.\u200B‮‮⁫‌⁪‬‎‌⁭‭⁪‬⁯‏⁫⁪‎⁭‪‍⁪⁬​‎⁪‪⁮⁯‫‍⁮‎⁪‮⁪⁬‮‎⁭‮(new WaitCallback(this.DelayedStatusUpdate), (object) activityEventArgs.Status);
            num1 = (int) num3 * -2119747840 ^ -511956821;
            continue;
          case 3:
            int num4 = activityEventArgs == null ? 1184065358 : (num4 = 1950716074);
            int num5 = (int) num3 * 1545908382;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * 1258737360 ^ -71331468;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * -1651997342 ^ -1150202592;
            continue;
          case 7:
            this.ActivityInProgress = false;
            num1 = (int) num3 * 990377770 ^ 974077890;
            continue;
          case 8:
            activityEventArgs = e as ZoomActivityEventArgs;
            num1 = (int) num3 * -82582535 ^ 108306684;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void DelayedStatusUpdate(object state)
    {
      try
      {
        EngineViewModel.\u200C⁮⁫‫⁮‭‎⁭‭⁬‮‏‪‫⁮‍‎‫‍⁭‌⁯⁮‏‌‎‎⁪⁮‌‫‎‪⁮‬⁮‪‮‮‭‮(3000);
label_2:
        int num1 = 507087610;
        while (true)
        {
          int num2 = 1092361564;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_17;
            case 1:
              num1 = 2129240752;
              continue;
            case 2:
              int num4 = state is string ? -203848035 : (num4 = -478444979);
              int num5 = (int) num3 * 1434087887;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * -77224862 ^ -222965880;
              continue;
            case 4:
              // ISSUE: method pointer
              EngineViewModel.\u202B⁭‌​‌⁮‏​⁪‭‪‌​⁭⁭⁭⁮‮⁮⁪⁫‏‭​‭⁭‪‪‮‮​‬‭‫‬‌⁮‭‪‪‮(EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()), new Action((object) this, __methodptr(\u003CDelayedStatusUpdate\u003Eb__167_0)));
              num1 = (int) num3 * 4693603 ^ 371626609;
              continue;
            case 5:
              goto label_2;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_17:;
      }
      catch (Exception ex)
      {
label_11:
        int num1 = 1978716840;
        while (true)
        {
          int num2 = 1092361564;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_11;
            case 1:
              goto label_9;
            case 2:
              num1 = (int) num3 * 475127485 ^ -2108692930;
              continue;
            case 3:
              EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * -743686102 ^ -116556405;
              continue;
            case 4:
              num1 = (int) num3 * 2127014537 ^ 1154917039;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_9:;
      }
    }

    private void ZoomZoom_OnActivityProgressReport(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EngineViewModel.\u003C\u003Ec__DisplayClass168_0 displayClass1680 = new EngineViewModel.\u003C\u003Ec__DisplayClass168_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1680.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      displayClass1680.sender = sender;
      // ISSUE: reference to a compiler-generated field
      displayClass1680.e = e;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1680.activityArgs = displayClass1680.e as ZoomActivityEventArgs;
      // ISSUE: reference to a compiler-generated field
      bool flag1 = displayClass1680.activityArgs != null;
label_1:
      int num1 = 414014984;
      while (true)
      {
        int num2 = 751302347;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -552442331 ^ 1311452716;
            continue;
          case 1:
            // ISSUE: method pointer
            EngineViewModel.\u202B⁭‌​‌⁮‏​⁪‭‪‌​⁭⁭⁭⁮‮⁮⁪⁫‏‭​‭⁭‪‪‮‮​‬‭‫‬‌⁮‭‪‪‮(EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()), new Action((object) displayClass1680, __methodptr(\u003CZoomZoom_OnActivityProgressReport\u003Eb__0)));
            num1 = 1297012316;
            continue;
          case 2:
            int num5 = !flag2 ? 1155263124 : (num5 = 1424666917);
            int num6 = (int) num3 * 124683695;
            num1 = num5 ^ num6;
            continue;
          case 3:
            int num7 = flag1 ? 1860149837 : (num7 = 1506238092);
            int num8 = (int) num3 * 1772242672;
            num1 = num7 ^ num8;
            continue;
          case 4:
            num4 = EngineViewModel.\u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮((DispatcherObject) EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()) == null ? 1 : 0;
            break;
          case 5:
            goto label_1;
          case 6:
            if (EngineViewModel.\u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮() == null)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * -743157884 ^ 33399047;
            continue;
          case 7:
            goto label_3;
          default:
            goto label_13;
        }
        flag2 = num4 != 0;
        num1 = 1994224073;
      }
label_13:
      return;
label_3:;
    }

    private void ZoomZoom_OnWindowMoved(object sender, EventArgs e)
    {
      ZoomWindowEventArgs zoomWindowEventArgs = e as ZoomWindowEventArgs;
label_1:
      int num1 = 1643796685;
      while (true)
      {
        int num2 = 1771858572;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            int num4 = flag2 ? 1257027990 : (num4 = 1353385687);
            int num5 = (int) num3 * -1870459659;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * -1617278135 ^ 1032865584;
            continue;
          case 2:
            num1 = (int) num3 * 1503625573 ^ 35599790;
            continue;
          case 3:
            flag2 = zoomWindowEventArgs.ZoomWindowType == ZoomWindowType.ZoomZoomMain;
            num1 = 141571696;
            continue;
          case 4:
            int num6 = zoomWindowEventArgs.ZoomWindowType != ZoomWindowType.Meeting ? -1726791358 : (num6 = -397186621);
            int num7 = (int) num3 * 261345403;
            num1 = num6 ^ num7;
            continue;
          case 5:
            num1 = (int) num3 * -1208049105 ^ 1943714439;
            continue;
          case 6:
            num1 = (int) num3 * -614685142 ^ -218455788;
            continue;
          case 7:
            goto label_1;
          case 8:
            goto label_3;
          case 9:
            num1 = (int) num3 * -828558367 ^ 1747851781;
            continue;
          case 10:
            flag1 = zoomWindowEventArgs != null;
            num1 = (int) num3 * 570023936 ^ -1485413478;
            continue;
          case 11:
            num1 = 1555768235;
            continue;
          case 12:
            int num8 = flag1 ? -632579331 : (num8 = -787638477);
            int num9 = (int) num3 * 7208036;
            num1 = num8 ^ num9;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    private void LoadCommands()
    {
label_1:
      int num1 = -1703002095;
      while (true)
      {
        int num2 = -185895605;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.quickJoinMeetingCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(ExecuteQuickJoinMeeting)), new Func<bool>((object) this, __methodptr(CanExecuteQuickJoinMeeting)));
            num1 = (int) num3 * -1949826333 ^ -1085155875;
            continue;
          case 1:
            goto label_3;
          case 2:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.cancelActivityCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(ExecuteCancelActivity)), new Func<bool>((object) this, __methodptr(CanExecuteCancelActivity)));
            num1 = (int) num3 * -917897055 ^ 13187303;
            continue;
          case 3:
            goto label_1;
          case 4:
            // ISSUE: method pointer
            this.minimizeWindowCommand = EngineViewModel.\u200D‮⁬‭⁭‌⁯⁭‬⁭⁬⁮‏⁮⁮‭‬⁬⁬⁯‮‫‏‫⁬⁮‪‌‍‍‪‬⁮‍⁬‎⁯‭‍‍‮(new Action((object) this, __methodptr(ExecuteMinimizeWindow)));
            num1 = (int) num3 * 2089777886 ^ 651733052;
            continue;
          case 5:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.leaveMeetingCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(ExecuteLeaveMeeting)), new Func<bool>((object) this, __methodptr(CanExecuteLeaveMeeting)));
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.moveNextMeetingCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(ExecuteMoveNextMeeting)), new Func<bool>((object) this, __methodptr(CanExecuteMoveNextMeeting)));
            num1 = (int) num3 * -696905027 ^ -452872588;
            continue;
          case 6:
            int num4 = flag ? -889084474 : (num4 = -1010231452);
            int num5 = (int) num3 * 1326495167;
            num1 = num4 ^ num5;
            continue;
          case 7:
            // ISSUE: method pointer
            this.closeWindowCommand = EngineViewModel.\u200D‮⁬‭⁭‌⁯⁭‬⁭⁬⁮‏⁮⁮‭‬⁬⁬⁯‮‫‏‫⁬⁮‪‌‍‍‪‬⁮‍⁬‎⁯‭‍‍‮(new Action((object) this, __methodptr(ExecuteCloseWindow)));
            num1 = (int) num3 * 1267152208 ^ -335544416;
            continue;
          case 8:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.copyPatternCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(CopyPattern)), new Func<bool>((object) this, __methodptr(CanCopyPattern)));
            num1 = (int) num3 * 673454853 ^ -766434262;
            continue;
          case 9:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.newActivityCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(ExecuteNewActivityCommand)), new Func<bool>((object) this, __methodptr(CanExecuteNewActivityCommand)));
            num1 = (int) num3 * -1980776720 ^ 45746224;
            continue;
          case 10:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.hammerMeetingCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(ExecuteHammerMeeting)), new Func<bool>((object) this, __methodptr(CanExecuteHammerMeeting)));
            num1 = (int) num3 * -1678815360 ^ -997918162;
            continue;
          case 11:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.findUserCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(QueueFindUserCommand)), new Func<bool>((object) this, __methodptr(CanFindUserCommand)));
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.queueActivityCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(QueueActivity)), new Func<bool>((object) this, __methodptr(CanQueueActivity)));
            num1 = (int) num3 * -2035311872 ^ 1555078359;
            continue;
          case 12:
            flag = this.Commands.Count == 0;
            num1 = (int) num3 * -449604911 ^ 299003357;
            continue;
          case 13:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.openImageHistoryViewCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(OpenImageViewer)), new Func<bool>((object) this, __methodptr(CanOpenImageViewer)));
            num1 = (int) num3 * 1680142044 ^ 872894283;
            continue;
          case 14:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.applyPatternCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(ApplyPattern)), new Func<bool>((object) this, __methodptr(CanApplyPattern)));
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.editPatternCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(EditPattern)), new Func<bool>((object) this, __methodptr(CanEditPattern)));
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.deletePatternCommand = EngineViewModel.\u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮(new Action((object) this, __methodptr(DeletePattern)), new Func<bool>((object) this, __methodptr(CanDeletePattern)));
            num1 = (int) num3 * 1667218789 ^ -1459115346;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_3:;
    }

    private void ExecuteHammerMeeting()
    {
label_1:
      int num1 = -1495302384;
      while (true)
      {
        int num2 = -1195824817;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            int num4 = !flag1 ? 1663197193 : (num4 = 22375155);
            int num5 = (int) num3 * 1979115392;
            num1 = num4 ^ num5;
            continue;
          case 1:
            int num6 = flag2 ? -97320938 : (num6 = -516479656);
            int num7 = (int) num3 * 940452975;
            num1 = num6 ^ num7;
            continue;
          case 2:
            num1 = (int) num3 * -1177688727 ^ -1852595666;
            continue;
          case 3:
            goto label_1;
          case 4:
            Engine engine1 = this.Engine;
            HammerMeeting hammerMeeting = new HammerMeeting(this.SelectedMeetingId);
            int num8 = 0;
            hammerMeeting.AutoGenerated = num8 != 0;
            string callerName1 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1555375987U);
            engine1.AddActivity((ActivityBase) hammerMeeting, callerName1);
            num1 = -854794947;
            continue;
          case 5:
            Engine engine2 = this.Engine;
            LeaveMeeting leaveMeeting = new LeaveMeeting();
            int num9 = 0;
            leaveMeeting.AutoGenerated = num9 != 0;
            string callerName2 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1555375987U);
            engine2.AddActivity((ActivityBase) leaveMeeting, callerName2);
            num1 = (int) num3 * 830930004 ^ 705885318;
            continue;
          case 6:
            num1 = (int) num3 * -1892597739 ^ -1276527000;
            continue;
          case 7:
            flag1 = EngineViewModel.\u202A⁪⁬‍⁬⁯‭‌⁭‏⁫⁯​‌⁭⁬‫​‮‭‮‫‍⁯⁬​⁪‭‍‮‪‮⁯⁯‪⁪‭‎⁯‬‮(this.SelectedMeetingId);
            num1 = (int) num3 * 1030890038 ^ -1434685911;
            continue;
          case 8:
            num1 = (int) num3 * -297945917 ^ 1520772312;
            continue;
          case 9:
            num1 = (int) num3 * -1495403211 ^ -417176614;
            continue;
          case 10:
            flag2 = this.Engine.ActiveMeeting != null;
            num1 = -957208558;
            continue;
          case 11:
            goto label_3;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    private bool CanExecuteHammerMeeting()
    {
label_1:
      int num1 = -1442494652;
      bool flag;
      while (true)
      {
        int num2 = -1041837899;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = !EngineViewModel.\u202A⁪⁬‍⁬⁯‭‌⁭‏⁫⁯​‌⁭⁬‫​‮‭‮‫‍⁯⁬​⁪‭‍‮‪‮⁯⁯‪⁪‭‎⁯‬‮(this.SelectedMeetingId);
            num1 = (int) num3 * 1978243565 ^ -1000325366;
            continue;
          case 2:
            num1 = (int) num3 * -1729210530 ^ 757020098;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private bool CanExecuteMoveNextMeeting()
    {
      bool flag = true;
label_1:
      int num1 = 594056683;
      while (true)
      {
        int num2 = 409909813;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -123505103 ^ -1168746819;
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

    private bool CanExecuteLeaveMeeting()
    {
label_1:
      int num1 = -1612635605;
      bool flag;
      while (true)
      {
        int num2 = -1261279556;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.Engine.ActiveMeeting != null;
            num1 = (int) num3 * 417815558 ^ -922718065;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private bool CanExecuteCancelActivity()
    {
label_1:
      int num1 = -650760410;
      bool flag;
      while (true)
      {
        int num2 = -1736167471;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 2088340087 ^ 2097835672;
            continue;
          case 3:
            flag = this.Engine.ActiveActivity != null;
            num1 = (int) num3 * 346316843 ^ 1717002857;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteMinimizeWindow()
    {
label_1:
      int num1 = -1453627494;
      while (true)
      {
        int num2 = -1292814284;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            int num4 = flag ? 2143460075 : (num4 = 1275486862);
            int num5 = (int) num3 * 1644775690;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * 1958446403 ^ 1716069559;
            continue;
          case 2:
            goto label_3;
          case 3:
            EngineViewModel.\u206D‪‮‎⁮‭‫‍‪‪‎‍​⁪‭⁪⁭⁬‍⁮‭‭⁪‫‪‬‭⁫‍⁫‌⁬⁫‮‮​‫⁬⁫⁭‮(this.View, WindowState.Minimized);
            num1 = (int) num3 * -983743538 ^ 546397881;
            continue;
          case 4:
            flag = this.View != null;
            num1 = (int) num3 * 181763813 ^ -129792212;
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

    private void ExecuteCloseWindow()
    {
      ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Publish(new ViewEventPayload(this.ViewHandle, ViewEventType.Close));
    }

    private bool CanExecuteNewActivityCommand()
    {
      bool flag = true;
label_1:
      int num1 = -1407042106;
      while (true)
      {
        int num2 = -1803882739;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1481765471 ^ -1978342962;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteNewActivityCommand()
    {
label_1:
      int num1 = 1362176324;
      while (true)
      {
        int num2 = 702227271;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            if (flag)
            {
              num1 = (int) num3 * 1053358831 ^ 587578871;
              continue;
            }
            goto label_31;
          case 1:
            num4 = !EngineViewModel.\u202A⁪⁬‍⁬⁯‭‌⁭‏⁫⁯​‌⁭⁬‫​‮‭‮‫‍⁯⁬​⁪‭‍‮‪‮⁯⁯‪⁪‭‎⁯‬‮(this.SelectedActivityType.Value) ? 1 : 0;
            break;
          case 2:
            if (this.SelectedActivityType != null)
            {
              num1 = (int) num3 * -605684842 ^ -506565195;
              continue;
            }
            num4 = 0;
            break;
          case 4:
            goto label_1;
          default:
            goto label_10;
        }
        flag = num4 != 0;
        num1 = 1433081497;
      }
label_31:
      return;
label_10:
      try
      {
label_12:
        int num2 = 2132912775;
        while (true)
        {
          int num3 = 702227271;
          uint num4;
          bool flag;
          ActivityEditorView activityEditorView;
          Type type;
          Assembly assembly;
          switch ((num4 = (uint) (num2 ^ num3)) % 13U)
          {
            case 0:
              flag = EngineViewModel.\u200F‮⁯‎‭‫‬​‮⁫‪⁬⁮‍‎⁭⁭⁭‪‮⁬‬‬‎⁪‪​⁫⁪​‌‍‍⁪⁭‭‎⁭⁮‭‮(type, (Type) null);
              num2 = (int) num4 * 1443792301 ^ -1177678421;
              continue;
            case 1:
              EngineViewModel.\u206F‮‪⁯⁮‬‬⁪‭⁭⁭⁯‬⁪‫‫⁬⁪‍⁪⁮‮⁮⁮⁫⁮⁪‪​⁬⁪⁬⁪‪‏⁬⁭⁬⁪‎‮((Window) activityEditorView);
              num2 = (int) num4 * 707792635 ^ 1568423089;
              continue;
            case 3:
              num2 = 1598734220;
              continue;
            case 4:
              num2 = (int) num4 * -167331326 ^ -519903815;
              continue;
            case 5:
              int num5 = flag ? -910747135 : (num5 = -534592790);
              int num6 = (int) num4 * -2059234561;
              num2 = num5 ^ num6;
              continue;
            case 6:
              goto label_12;
            case 7:
              // ISSUE: method pointer
              type = (Type) Enumerable.First<Type>((IEnumerable<M0>) EngineViewModel.\u200B⁯‮⁫​​‎‪⁭​‫‌‍‭‬‎‫‪‮⁪‎‌‏⁫‫​‍⁮⁫⁭⁯‭‭⁮‎‍⁬‪⁬‏‮(assembly), (Func<M0, bool>) new Func<Type, bool>((object) this, __methodptr(\u003CExecuteNewActivityCommand\u003Eb__179_0)));
              num2 = (int) num4 * 657969204 ^ 893998994;
              continue;
            case 8:
              activityEditorView.Activity = (ActivityBase) EngineViewModel.\u206A‭‭⁭⁯‮‫‌‌‌‌‏‍‪⁮⁮‎⁮‍⁯⁬‬‎‌⁪‎⁮⁯⁯‎⁭​⁫⁫‬‪‏‬‏‫‮(type);
              num2 = (int) num4 * -919478381 ^ 402941139;
              continue;
            case 9:
              num2 = (int) num4 * 1705212764 ^ -988109393;
              continue;
            case 10:
              activityEditorView = new ActivityEditorView(this._eventAggregator);
              num2 = (int) num4 * 1595194501 ^ -1065578985;
              continue;
            case 11:
              num2 = (int) num4 * 927655297 ^ -1800339102;
              continue;
            case 12:
              assembly = EngineViewModel.\u200D⁫⁪⁯‮⁫‌‎⁭‌⁪‌⁪⁪⁮⁫‎⁪⁯⁮⁮⁭⁪‮‌⁬⁯‍​‭‏⁫​⁫‮‭‌‌‬⁮‮();
              num2 = (int) num4 * -1447926744 ^ -2009415245;
              continue;
            default:
              goto label_32;
          }
        }
      }
      catch (Exception ex)
      {
label_26:
        int num2 = 926717011;
        while (true)
        {
          int num3 = 702227271;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              this.SetStatus(EngineViewModel.\u202C‭‏‬‪⁪‎‎‫‭⁭‫⁮⁮‮‌‍‪‍⁫‪‏‭⁪⁬⁫‮⁬​⁭‮‫⁫‍‭​‏‮‍⁪‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2384766420U), EngineViewModel.\u200F⁭‮‎‭​‫​‌​‬‍⁮​⁭​⁭⁭⁭‎‭‎‍‫‬‪‎⁯‬⁮‌‌⁮‎​‌‪⁮‍‫‮(ex)));
              num2 = (int) num4 * -1635705345 ^ 1101613302;
              continue;
            case 2:
              num2 = (int) num4 * -1078932228 ^ 509090716;
              continue;
            case 3:
              goto label_26;
            case 4:
              EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
              num2 = (int) num4 * 1176649828 ^ -615262499;
              continue;
            default:
              goto label_32;
          }
        }
      }
label_32:;
    }

    private bool CanCopyPattern()
    {
label_1:
      int num1 = 706274736;
      bool flag;
      while (true)
      {
        int num2 = 1271966273;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.SelectedPattern != null;
            num1 = (int) num3 * -2141844475 ^ -1473192450;
            continue;
          case 2:
            num1 = (int) num3 * -392814064 ^ -553232010;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void CopyPattern()
    {
      try
      {
        this.SelectedPattern = new LayoutPattern(this.SelectedPattern);
label_2:
        int num1 = 1874455338;
        while (true)
        {
          int num2 = 1929401204;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 2050297337 ^ 1684795585;
              continue;
            case 2:
              goto label_8;
            case 3:
              this.EditPattern();
              num1 = (int) num3 * 935281687 ^ -1902149768;
              continue;
            case 4:
              num1 = (int) num3 * 898717680 ^ -1770671168;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
        throw;
      }
    }

    private bool CanDeletePattern()
    {
      if (this.SelectedPattern == null)
        goto label_4;
label_1:
      int num1 = 813848378;
label_2:
      while (true)
      {
        int num2 = 1715267317;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1245952641 ^ -308796056;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_3:
      int num4 = !this.SelectedPattern.AutoGenerated ? 1 : 0;
      goto label_5;
label_7:
      bool flag;
      return flag;
label_4:
      num4 = 0;
label_5:
      flag = num4 != 0;
      num1 = 53785284;
      goto label_2;
    }

    private void DeletePattern()
    {
      LayoutPattern selectedPattern = this.SelectedPattern;
      bool flag = this.Engine.ActivePattern == selectedPattern;
label_1:
      int num1 = -1033255950;
      while (true)
      {
        int num2 = -1917509999;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            this.Engine.RemovePattern(selectedPattern);
            num1 = (int) num3 * -1673320101 ^ 1237775565;
            continue;
          case 1:
            num1 = (int) num3 * 1745841358 ^ -953382350;
            continue;
          case 2:
            goto label_3;
          case 3:
            int num4 = !flag ? -456596972 : (num4 = -2106920945);
            int num5 = (int) num3 * 180444728;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * 33157725 ^ -585405241;
            continue;
          case 5:
            this.SelectedPattern = this.Engine.ActivePattern;
            this.Patterns.Remove(selectedPattern);
            num1 = -2037679983;
            continue;
          case 6:
            this.Engine.ActivePattern = ((Collection<LayoutPattern>) this.Engine.Patterns)[0];
            num1 = (int) num3 * -1409118748 ^ -1768203480;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    private bool CanEditPattern()
    {
      return this.SelectedPattern != null;
    }

    private void EditPattern()
    {
      try
      {
label_2:
        int num1 = -1451387552;
        while (true)
        {
          int num2 = -471037540;
          uint num3;
          LayoutEditorView layoutEditorView;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              layoutEditorView.Layout = this.SelectedPattern;
              num1 = (int) num3 * 1639194294 ^ -1817120390;
              continue;
            case 2:
              EngineViewModel.\u206F‮‪⁯⁮‬‬⁪‭⁭⁭⁯‬⁪‫‫⁬⁪‍⁪⁮‮⁮⁮⁫⁮⁪‪​⁬⁪⁬⁪‪‏⁬⁭⁬⁪‎‮((Window) layoutEditorView);
              num1 = (int) num3 * 624195841 ^ -1267066518;
              continue;
            case 3:
              goto label_14;
            case 4:
              layoutEditorView = new LayoutEditorView();
              num1 = (int) num3 * 305992489 ^ -942015861;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_14:;
      }
      catch (Exception ex)
      {
label_10:
        int num1 = -1084006470;
        while (true)
        {
          int num2 = -471037540;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_10;
            case 1:
              EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * -2103326990 ^ 64635185;
              continue;
            case 2:
              goto label_8;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_8:;
      }
    }

    private bool CanApplyPattern()
    {
label_1:
      int num1 = -897670721;
      bool flag;
      while (true)
      {
        int num2 = -5715874;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 703697949 ^ -195325427;
            continue;
          case 1:
            flag = this.SelectedPattern != null;
            num1 = (int) num3 * 34370274 ^ 582386916;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ApplyPattern()
    {
      bool flag = this.Engine.ActivePattern != this.SelectedPattern;
label_1:
      int num1 = 130501746;
      while (true)
      {
        int num2 = 693076844;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Engine.ActivePattern = this.SelectedPattern;
            num1 = (int) num3 * -150036128 ^ -856575207;
            continue;
          case 2:
            int num4 = !flag ? -1860128190 : (num4 = -1484939254);
            int num5 = (int) num3 * -1162386678;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_1;
          case 4:
            EngineViewModel.\u206C⁮‌⁪‎⁬⁫⁮​⁬‏‮⁮‮‭⁯‬⁫⁮⁭‫‏⁪⁮‭‏‏⁬‌‎⁫‫‌‌‮⁪‏⁬‮‍‮(ViewModelBase.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2612239595U));
            num1 = (int) num3 * 1771593789 ^ -124442719;
            continue;
          case 5:
            this.Engine.ApplyPattern();
            num1 = 843785491;
            continue;
          case 6:
            num1 = (int) num3 * 894503274 ^ -1754451303;
            continue;
          case 7:
            num1 = (int) num3 * -1966912539 ^ 874307560;
            continue;
          case 8:
            num1 = (int) num3 * -1210463915 ^ 659329519;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void QueueActivity()
    {
label_1:
      int num1 = -797823319;
      while (true)
      {
        int num2 = -1769021543;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            if (this.SelectedActivityType != null)
            {
              num1 = (int) num3 * 584823850 ^ -1622239850;
              continue;
            }
            num4 = 0;
            break;
          case 2:
            goto label_1;
          case 3:
            num4 = !EngineViewModel.\u202A⁪⁬‍⁬⁯‭‌⁭‏⁫⁯​‌⁭⁬‫​‮‭‮‫‍⁯⁬​⁪‭‍‮‪‮⁯⁯‪⁪‭‎⁯‬‮(this.SelectedActivityType.Value) ? 1 : 0;
            break;
          case 4:
            if (flag)
            {
              num1 = (int) num3 * -1482823232 ^ 597383334;
              continue;
            }
            goto label_33;
          default:
            goto label_10;
        }
        flag = num4 != 0;
        num1 = -960190579;
      }
label_33:
      return;
label_10:
      try
      {
label_12:
        int num2 = -2046654144;
        while (true)
        {
          int num3 = -1769021543;
          uint num4;
          bool flag1;
          ActivityBase activityBase;
          Type type;
          bool flag2;
          ActivityEditorView activityEditorView;
          switch ((num4 = (uint) (num2 ^ num3)) % 16U)
          {
            case 0:
              EngineViewModel.\u206F‮‪⁯⁮‬‬⁪‭⁭⁭⁯‬⁪‫‫⁬⁪‍⁪⁮‮⁮⁮⁫⁮⁪‪​⁬⁪⁬⁪‪‏⁬⁭⁬⁪‎‮((Window) activityEditorView);
              num2 = (int) num4 * -1958612221 ^ -1661838860;
              continue;
            case 1:
              activityBase.AuthorizationState = AuthorizationStates.Authorized;
              num2 = (int) num4 * 1058836759 ^ -517887187;
              continue;
            case 2:
              int num5 = flag1 ? -1921935120 : (num5 = -1067613772);
              int num6 = (int) num4 * -153981188;
              num2 = num5 ^ num6;
              continue;
            case 3:
              activityBase.RequiresAuthorization = false;
              num2 = (int) num4 * 1962464428 ^ -1171908411;
              continue;
            case 5:
              num2 = -2021934233;
              continue;
            case 6:
              goto label_12;
            case 7:
              activityBase = (ActivityBase) EngineViewModel.\u206A‭‭⁭⁯‮‫‌‌‌‌‏‍‪⁮⁮‎⁮‍⁯⁬‬‎‌⁪‎⁮⁯⁯‎⁭​⁫⁫‬‪‏‬‏‫‮(type);
              num2 = (int) num4 * -2084415783 ^ -1283204790;
              continue;
            case 8:
              activityEditorView = new ActivityEditorView(this._eventAggregator);
              activityEditorView.Activity = activityBase;
              num2 = (int) num4 * -914116269 ^ 774091530;
              continue;
            case 9:
              // ISSUE: method pointer
              type = (Type) Enumerable.First<Type>((IEnumerable<M0>) EngineViewModel.\u200B⁯‮⁫​​‎‪⁭​‫‌‍‭‬‎‫‪‮⁪‎‌‏⁫‫​‍⁮⁫⁭⁯‭‭⁮‎‍⁬‪⁬‏‮(EngineViewModel.\u200D⁫⁪⁯‮⁫‌‎⁭‌⁪‌⁪⁪⁮⁫‎⁪⁯⁮⁮⁭⁪‮‌⁬⁯‍​‭‏⁫​⁫‮‭‌‌‬⁮‮()), (Func<M0, bool>) new Func<Type, bool>((object) this, __methodptr(\u003CQueueActivity\u003Eb__188_0)));
              flag2 = EngineViewModel.\u200F‮⁯‎‭‫‬​‮⁫‪⁬⁮‍‎⁭⁭⁭‪‮⁬‬‬‎⁪‪​⁫⁪​‌‍‍⁪⁭‭‎⁭⁮‭‮(type, (Type) null);
              num2 = (int) num4 * 1388218070 ^ -804788331;
              continue;
            case 10:
              int num7 = !flag2 ? -1445856329 : (num7 = -412247626);
              int num8 = (int) num4 * 849539016;
              num2 = num7 ^ num8;
              continue;
            case 11:
              num2 = (int) num4 * 480252063 ^ -2037249620;
              continue;
            case 12:
              flag1 = activityBase != null;
              num2 = (int) num4 * -45885872 ^ -799505269;
              continue;
            case 13:
              num2 = (int) num4 * 609249364 ^ 907359752;
              continue;
            case 14:
              num2 = -2037506051;
              continue;
            case 15:
              num2 = (int) num4 * 51115925 ^ -337828603;
              continue;
            default:
              goto label_34;
          }
        }
      }
      catch (Exception ex)
      {
label_29:
        int num2 = -1583963081;
        while (true)
        {
          int num3 = -1769021543;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_29;
            case 1:
              EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
              this.SetStatus(EngineViewModel.\u202C‭‏‬‪⁪‎‎‫‭⁭‫⁮⁮‮‌‍‪‍⁫‪‏‭⁪⁬⁫‮⁬​⁭‮‫⁫‍‭​‏‮‍⁪‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2384766420U), EngineViewModel.\u200F⁭‮‎‭​‫​‌​‬‍⁮​⁭​⁭⁭⁭‎‭‎‍‫‬‪‎⁯‬⁮‌‌⁮‎​‌‪⁮‍‫‮(ex)));
              num2 = (int) num4 * 490223068 ^ 837822482;
              continue;
            case 2:
              num2 = (int) num4 * -364449970 ^ 457350256;
              continue;
            default:
              goto label_34;
          }
        }
      }
label_34:;
    }

    private static IEnumerable<Type> GetDerivedTypesFor(Type baseType)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EngineViewModel.\u003C\u003Ec__DisplayClass189_0 displayClass1890 = new EngineViewModel.\u003C\u003Ec__DisplayClass189_0();
label_1:
      int num1 = -104183051;
      IEnumerable<Type> types;
      while (true)
      {
        int num2 = -1752850357;
        uint num3;
        Assembly assembly;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 166500848 ^ 222267291;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass1890.baseType = baseType;
            num1 = (int) num3 * -913858600 ^ 1532300812;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 1737016341 ^ 516122277;
            continue;
          case 5:
            Type[] typeArray = EngineViewModel.\u200B⁯‮⁫​​‎‪⁭​‫‌‍‭‬‎‫‪‮⁪‎‌‏⁫‫​‍⁮⁫⁭⁯‭‭⁮‎‍⁬‪⁬‏‮(assembly);
            // ISSUE: reference to a compiler-generated field
            Type baseType1 = displayClass1890.baseType;
            // ISSUE: virtual method pointer
            IntPtr num4 = __vmethodptr(baseType1, IsAssignableFrom);
            Func<Type, bool> func = new Func<Type, bool>((object) baseType1, num4);
            // ISSUE: method pointer
            types = (IEnumerable<Type>) Enumerable.Where<Type>(Enumerable.Where<Type>((IEnumerable<M0>) typeArray, (Func<M0, bool>) func), (Func<M0, bool>) new Func<Type, bool>((object) displayClass1890, __methodptr(\u003CGetDerivedTypesFor\u003Eb__0)));
            num1 = (int) num3 * 1185982075 ^ 1701962834;
            continue;
          case 6:
            assembly = EngineViewModel.\u200D⁫⁪⁯‮⁫‌‎⁭‌⁪‌⁪⁪⁮⁫‎⁪⁯⁮⁮⁭⁪‮‌⁬⁯‍​‭‏⁫​⁫‮‭‌‌‬⁮‮();
            num1 = (int) num3 * -1895498690 ^ 317797045;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return types;
    }

    private bool CanQueueActivity()
    {
      return this.SelectedActivityType != null;
    }

    public void ExecuteMoveNextMeeting()
    {
      try
      {
label_2:
        int num1 = -1769820233;
        while (true)
        {
          int num2 = -826688213;
          uint num3;
          ZoomMeeting nextMeeting;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 17U)
          {
            case 0:
              num1 = (int) num3 * -1460112271 ^ 96797542;
              continue;
            case 1:
              JoinMeeting joinMeeting = new JoinMeeting(nextMeeting.MeetingId);
              int num5 = 0;
              joinMeeting.AutoGenerated = num5 != 0;
              int num6 = 0;
              joinMeeting.RequiresAuthorization = num6 != 0;
              int num7 = 1;
              joinMeeting.AuthorizationState = (AuthorizationStates) num7;
              this.AddActivity((ActivityBase) joinMeeting);
              num1 = -1338015515;
              continue;
            case 2:
              num1 = (int) num3 * 1874033416 ^ -467070317;
              continue;
            case 3:
              num1 = (int) num3 * 86449891 ^ 371086126;
              continue;
            case 4:
              num1 = (int) num3 * 2003149687 ^ 775807633;
              continue;
            case 5:
              num1 = (int) num3 * 2068474946 ^ 2100226113;
              continue;
            case 6:
              num4 = this.Engine.ActiveMeeting == nextMeeting ? 1 : 0;
              break;
            case 7:
              goto label_29;
            case 8:
              int num8;
              num1 = num8 = this.Engine.ActiveMeeting != null ? -878084235 : (num8 = -1524041088);
              continue;
            case 9:
              num1 = (int) num3 * 982663340 ^ -1478416488;
              continue;
            case 10:
              LeaveMeeting leaveMeeting = new LeaveMeeting();
              int num9 = 0;
              leaveMeeting.AutoGenerated = num9 != 0;
              int num10 = 0;
              leaveMeeting.RequiresAuthorization = num10 != 0;
              int num11 = 1;
              leaveMeeting.AuthorizationState = (AuthorizationStates) num11;
              this.AddActivity((ActivityBase) leaveMeeting);
              num1 = (int) num3 * -54740521 ^ -1853171103;
              continue;
            case 11:
              nextMeeting = this.Engine.NextMeeting;
              num1 = (int) num3 * -1710798779 ^ -334574464;
              continue;
            case 12:
              goto label_2;
            case 13:
              EngineViewModel.\u206C⁮‌⁪‎⁬⁫⁮​⁬‏‮⁮‮‭⁯‬⁫⁮⁭‫‏⁪⁮‭‏‏⁬‌‎⁫‫‌‌‮⁪‏⁬‮‍‮(ViewModelBase.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3170103015U));
              num1 = (int) num3 * -1930012608 ^ -606564761;
              continue;
            case 14:
              int num12 = !flag ? -579656803 : (num12 = -734662824);
              int num13 = (int) num3 * -841566107;
              num1 = num12 ^ num13;
              continue;
            case 15:
              nextMeeting = this.Engine.NextMeeting;
              num1 = (int) num3 * -1444193915 ^ -866284841;
              continue;
            case 16:
              if (this.Engine.ActiveMeeting == null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 778882276 ^ 1820303491;
              continue;
            default:
              goto label_27;
          }
          flag = num4 != 0;
          num1 = -1879866167;
        }
label_27:
        return;
label_29:;
      }
      catch (Exception ex)
      {
        EngineViewModel.\u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮(ViewModelBase.log, (object) ex);
label_25:
        int num1 = -1937160013;
        while (true)
        {
          int num2 = -826688213;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_25;
            case 1:
              num1 = (int) num3 * 1798770577 ^ 848320993;
              continue;
            case 2:
              goto label_23;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_23:;
      }
    }

    public void ExecuteLeaveMeeting()
    {
      if (this.ActiveMeeting == null)
        return;
label_1:
      int num1 = 359068432;
      while (true)
      {
        int num2 = 1577797489;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * 523201985 ^ 1117486174;
            continue;
          case 1:
            num1 = (int) num3 * -1975829525 ^ 1115892646;
            continue;
          case 2:
            goto label_7;
          case 3:
            LeaveMeeting leaveMeeting = new LeaveMeeting();
            int num4 = 0;
            leaveMeeting.AutoGenerated = num4 != 0;
            int num5 = 0;
            leaveMeeting.RequiresAuthorization = num5 != 0;
            int num6 = 1;
            leaveMeeting.AuthorizationState = (AuthorizationStates) num6;
            this.AddActivity((ActivityBase) leaveMeeting);
            num1 = (int) num3 * -2117170621 ^ -1754303867;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_7:;
    }

    public void ExecuteCancelActivity()
    {
label_1:
      int num1 = 1107837468;
      while (true)
      {
        int num2 = 1606826009;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Engine.CancelActivity((ActivityBase) null);
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1633174332U));
            this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2379734542U));
            num1 = (int) num3 * -1325411846 ^ -1214394499;
            continue;
          case 2:
            num1 = (int) num3 * 1177152923 ^ 306967960;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private bool CanCancelActivity()
    {
label_1:
      int num1 = 1037834062;
      bool flag;
      while (true)
      {
        int num2 = 1822840585;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1473418552 ^ -1544380864;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag = this.ActiveActivity != null;
            num1 = (int) num3 * -458642561 ^ -396247380;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void LaunchActivityManagerView()
    {
      bool flag1 = false;
      object modelLock = ViewModelBase.modelLock;
      bool flag2 = false;
      ActivityManagerView activityManagerView;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag2);
label_2:
        int num1 = -1339685682;
        while (true)
        {
          int num2 = -1032848338;
          uint num3;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              activityManagerView = this.ActivityManagerView;
              num1 = -1331181123;
              continue;
            case 1:
              flag1 = true;
              num1 = (int) num3 * 2023401613 ^ -504997680;
              continue;
            case 2:
              num1 = (int) num3 * 1434477893 ^ 518827878;
              continue;
            case 4:
              this.ActivityManagerView = new ActivityManagerView();
              num1 = (int) num3 * 1560776445 ^ -1094727908;
              continue;
            case 5:
              EngineViewModel.\u202A‫⁫‭‏‌⁬‌⁪⁮‌⁭‪‍⁫⁯‎⁬‎‌‌‭‪‭‌‪⁯‍‎⁯‏⁭‎‬⁫‬‫‭⁮⁬‮((Window) this.ActivityManagerView, new EventHandler(this.ActivityManagerView_Closed));
              num1 = (int) num3 * -1527594662 ^ 1290489518;
              continue;
            case 6:
              flag3 = this.ActivityManagerView == null;
              num1 = (int) num3 * 673698952 ^ 1592187768;
              continue;
            case 7:
              int num4 = !flag3 ? 848829234 : (num4 = 2134616187);
              int num5 = (int) num3 * 84763740;
              num1 = num4 ^ num5;
              continue;
            case 8:
              goto label_2;
            case 9:
              num1 = (int) num3 * -1778966556 ^ 890772362;
              continue;
            case 10:
              num1 = (int) num3 * 1177087774 ^ -656221688;
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
label_14:
          int num1 = -1698812848;
          while (true)
          {
            int num2 = -1032848338;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_14;
              case 1:
                num1 = (int) num3 * 1925893878 ^ -1614290997;
                continue;
              case 2:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num1 = (int) num3 * -1642974859 ^ -174126415;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
label_20:
      if (flag1)
        goto label_25;
label_21:
      int num6 = -1513944598;
label_22:
      while (true)
      {
        int num1 = -1032848338;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 5U)
        {
          case 0:
            EngineViewModel.\u206F‮‪⁯⁮‬‬⁪‭⁭⁭⁯‬⁪‫‫⁬⁪‍⁪⁮‮⁮⁮⁫⁮⁪‪​⁬⁪⁬⁪‪‏⁬⁭⁬⁪‎‮((Window) activityManagerView);
            num6 = (int) num2 * 586947326 ^ 1106272994;
            continue;
          case 1:
            goto label_24;
          case 2:
            goto label_21;
          case 3:
            goto label_23;
          case 4:
            num6 = (int) num2 * -1959116339 ^ 1072079580;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_23:
      return;
label_24:
      int num7 = !EngineViewModel.\u202B‍⁫‌⁫‌⁯‌‪​‭‬‍⁪‮‭‍‮‬⁮⁯‍‭‬‏​‍‍​⁫‌‫⁮‪‭‪​​‫⁬‮((UIElement) activityManagerView) ? 1 : 0;
      goto label_26;
label_25:
      num7 = 1;
label_26:
      num6 = num7 != 0 ? -1788422612 : (num6 = -1156863060);
      goto label_22;
    }

    private void ActivityManagerView_Closed(object sender, EventArgs e)
    {
      object modelLock = ViewModelBase.modelLock;
      bool flag = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮(modelLock, ref flag);
label_2:
        int num1 = 717733771;
        while (true)
        {
          int num2 = 1839488926;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              this.ActivityManagerView = (ActivityManagerView) null;
              num1 = (int) num3 * -385284497 ^ 1691745516;
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
          int num1 = 2064329004;
          while (true)
          {
            int num2 = 1839488926;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_7;
              case 1:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮(modelLock);
                num1 = (int) num3 * 42262852 ^ -1775578059;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
    }

    private void LaunchCaptureWindow()
    {
label_1:
      int num1 = -873887683;
      while (true)
      {
        int num2 = -1172660592;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            flag = this.CaptureWindow != null;
            num1 = (int) num3 * -161475479 ^ -510459398;
            continue;
          case 2:
            goto label_1;
          case 3:
            if (flag)
            {
              num1 = (int) num3 * -444884211 ^ -1015105121;
              continue;
            }
            goto label_26;
          default:
            goto label_6;
        }
      }
label_6:
      try
      {
label_8:
        int num2 = -977896241;
        while (true)
        {
          int num3 = -1172660592;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_8;
            case 2:
              num2 = (int) num4 * 478714897 ^ 1845122867;
              continue;
            case 3:
              EngineViewModel.\u200C‌‫⁪⁪​‎⁭​​‌‌⁮‬⁬​⁬⁯⁬⁯‏‬⁯‫‫⁫⁪‬⁫‪⁭‫⁭‬‌‭‍‎‎‮‮((Window) this.CaptureWindow);
              num2 = (int) num4 * -1932180056 ^ 718230858;
              continue;
            default:
              goto label_17;
          }
        }
      }
      catch (Exception ex)
      {
label_13:
        int num2 = -74868711;
        while (true)
        {
          int num3 = -1172660592;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -433648956 ^ -303746569;
              continue;
            case 2:
              goto label_13;
            default:
              goto label_17;
          }
        }
      }
label_17:
      this.CaptureWindow = (CaptureWindowView) null;
label_18:
      int num5 = -1688250223;
label_19:
      while (true)
      {
        int num2 = -1172660592;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 8U)
        {
          case 0:
            EngineViewModel.\u206A‎‌‪‎‍‬⁭‫‪‬⁪⁬‪⁫‏​​⁯⁯‫⁮‮‎‍‎⁬⁬⁫⁫‌‏⁫⁭‎⁭‌‭‪‍‮((Control) this.CaptureWindow, (System.Windows.Media.Brush) EngineViewModel.\u206C‪⁯⁬‫‪⁪​⁮‪‪‫⁬‎⁭‬​⁭‎‍‪‫‭​‏‍‭‍‮⁭⁮‌‎‮‬⁮⁭‭‪‏‮(System.Windows.Media.Color.FromArgb((byte) 1, (byte) 0, (byte) 0, (byte) 0)));
            num5 = (int) num3 * -84923975 ^ -237578068;
            continue;
          case 1:
            num5 = (int) num3 * 1425184030 ^ -1861648805;
            continue;
          case 2:
            goto label_20;
          case 3:
            this.CaptureWindow.WindowSelected += (EventHandler) ((s, e) =>
            {
              ZoomWindow window = this.Engine.GetWindow(this.CaptureWindow.SelectedHWnd, false);
label_1:
              int num2 = 1979357261;
              while (true)
              {
                int num3 = 56141886;
                uint num4;
                string windowTitle;
                int num6;
                switch ((num4 = (uint) (num2 ^ num3)) % 18U)
                {
                  case 0:
                    num2 = (int) num4 * 1034367915 ^ -1629713829;
                    continue;
                  case 1:
                    num6 = window.ZoomWindowType == ZoomWindowType.Video ? 1 : 0;
                    break;
                  case 2:
                    goto label_3;
                  case 3:
                    goto label_1;
                  case 4:
                    num2 = (int) num4 * 618141123 ^ -1171994020;
                    continue;
                  case 5:
                    num2 = (int) num4 * 1730796309 ^ -315498205;
                    continue;
                  case 6:
                    Engine engine = this.Engine;
                    CaptureVideoWindow captureVideoWindow = new CaptureVideoWindow(window);
                    int num7 = 1;
                    captureVideoWindow.AutoGenerated = num7 != 0;
                    string callerName = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(455900891U);
                    engine.AddActivity((ActivityBase) captureVideoWindow, callerName);
                    num2 = (int) num4 * -698662349 ^ -574061300;
                    continue;
                  case 7:
                    EngineViewModel.\u200C‌‫⁪⁪​‎⁭​​‌‌⁮‬⁬​⁬⁯⁬⁯‏‬⁯‫‫⁫⁪‬⁫‪⁭‫⁭‬‌‭‍‎‎‮‮((Window) this.CaptureWindow);
                    num2 = (int) num4 * -1722422983 ^ -1833702918;
                    continue;
                  case 8:
                    this.Engine.CaptureImage(window, Rectangle.Empty, ImageEnums.ImageType.Window, new ImageOptions()
                    {
                      DisplayAfterCapture = true
                    });
                    num2 = (int) num4 * -1720624759 ^ -740803443;
                    continue;
                  case 9:
                    windowTitle = WindowHelper.GetWindowTitle(this.CaptureWindow.SelectedHWnd);
                    num2 = 2102931758;
                    continue;
                  case 10:
                    num2 = (int) num4 * -1562771932 ^ -1881866698;
                    continue;
                  case 11:
                    if (window != null)
                    {
                      num2 = (int) num4 * 821769164 ^ -1132575757;
                      continue;
                    }
                    num6 = 0;
                    break;
                  case 12:
                    int num8;
                    num2 = num8 = window != null ? 1245897588 : (num8 = 917933019);
                    continue;
                  case 13:
                    num2 = (int) num4 * -1062606980 ^ -1487198755;
                    continue;
                  case 14:
                    this.CaptureWindow = (CaptureWindowView) null;
                    num2 = (int) num4 * 35841640 ^ 307553705;
                    continue;
                  case 15:
                    num2 = (int) num4 * 1364226327 ^ -1543590377;
                    continue;
                  case 16:
                    string windowClass = WindowHelper.GetWindowClass(this.CaptureWindow.SelectedHWnd);
                    EngineViewModel.\u206C⁮‌⁪‎⁬⁫⁮​⁬‏‮⁮‮‭⁯‬⁫⁮⁭‫‏⁪⁮‭‏‏⁬‌‎⁫‫‌‌‮⁪‏⁬‮‍‮(ViewModelBase.log, (object) EngineViewModel.\u206E‬⁫⁫‪‮‎‏⁪‎⁯‬⁫⁭‫⁫⁯⁭⁯‪‏‌‎⁫‮‌‌⁪‮⁬⁪‫‬⁮‬⁭‏‪‌‮‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(895306090U), (object) windowTitle, (object) windowClass));
                    this.SetStatus(EngineViewModel.\u206E‬⁫⁫‪‮‎‏⁪‎⁯‬⁫⁭‫⁫⁯⁭⁯‪‏‌‎⁫‮‌‌⁪‮⁬⁪‫‬⁮‬⁭‏‪‌‮‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(895306090U), (object) windowTitle, (object) windowClass));
                    num2 = (int) num4 * 168620042 ^ 2052400012;
                    continue;
                  case 17:
                    num2 = (int) num4 * -1801623597 ^ 120156979;
                    continue;
                  default:
                    goto label_23;
                }
                int num9;
                num2 = num9 = num6 != 0 ? 715030134 : (num9 = 1042674486);
              }
label_23:
              return;
label_3:;
            });
            num5 = (int) num3 * 1308783824 ^ -1825486352;
            continue;
          case 4:
            num5 = (int) num3 * 1339817506 ^ -360805345;
            continue;
          case 5:
            goto label_26;
          case 6:
            goto label_18;
          case 7:
            EngineViewModel.\u206F‮‪⁯⁮‬‬⁪‭⁭⁭⁯‬⁪‫‫⁬⁪‍⁪⁮‮⁮⁮⁫⁮⁪‪​⁬⁪⁬⁪‪‏⁬⁭⁬⁪‎‮((Window) this.CaptureWindow);
            num5 = (int) num3 * 1354424568 ^ 1321138586;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_20:
      return;
label_26:
      this.CaptureWindow = new CaptureWindowView();
      this.CaptureWindow.Canceled += (EventHandler) ((s, e) =>
      {
        EngineViewModel.\u200C‌‫⁪⁪​‎⁭​​‌‌⁮‬⁬​⁬⁯⁬⁯‏‬⁯‫‫⁫⁪‬⁫‪⁭‫⁭‬‌‭‍‎‎‮‮((Window) this.CaptureWindow);
        this.CaptureWindow = (CaptureWindowView) null;
      });
      num5 = -1981400789;
      goto label_19;
    }

    private void OpenLogFile()
    {
      this.ShellCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3392549917U), "");
    }

    private void ShowDesktopAlert(object obj)
    {
label_1:
      int num1 = 601718988;
      while (true)
      {
        int num2 = 2034009768;
        uint num3;
        AlertValues alertValues;
        RadDesktopAlert radDesktopAlert1;
        List<RadDesktopAlert> list;
        bool flag1;
        int index;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            int num4 = flag1 ? 264725208 : (num4 = 58095023);
            int num5 = (int) num3 * -1320344388;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = 242326842;
            continue;
          case 2:
            list = EngineViewModel.\u202D⁭‏‍‬​‬⁪‮‎‪‍‍‪⁪‏⁬‫‌⁫⁭‎‭‏‏‏‬‮‎⁯⁫⁯‭⁯‎⁫⁯‎‫⁬‮(this.desktopAlertManager).ToList<RadDesktopAlert>();
            EngineViewModel.\u200E⁭​‍⁪‌‬⁭‎‮‏‍‏‭⁯‏⁮‍​‪‌​‍‮⁭⁭‏‫⁯⁪‬‬​‮⁯‪⁯‏⁫‎‮(ViewModelBase.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2357230214U), (object) list.Count);
            flag1 = list.Count > 4;
            num1 = (int) num3 * -657499647 ^ 416984650;
            continue;
          case 3:
            num1 = (int) num3 * -1498785749 ^ 218197766;
            continue;
          case 4:
            int num6;
            num1 = num6 = index >= list.Count - 2 ? 1339690817 : (num6 = 1815137379);
            continue;
          case 5:
            index = 0;
            num1 = (int) num3 * -777574697 ^ 1415977024;
            continue;
          case 6:
            ++index;
            num1 = (int) num3 * 505874350 ^ 1213297600;
            continue;
          case 7:
            RadDesktopAlert radDesktopAlert2 = EngineViewModel.\u202A‮⁫‭‎‬⁫⁬⁮⁫⁮⁪‍⁮⁭‏⁫‌​‫⁮‪‫⁭‌⁪⁪‌⁫‬‍‎⁬‮‮⁯​‍⁮‪‮();
            string header = alertValues.Header;
            EngineViewModel.\u206D‎‏‎​‌‏‌‎‎‏‌‬⁭​‭‭‎‪⁭‍⁯‌⁫‫⁫‮⁮‭⁬​‮‏⁬‎⁭‬​‪‌‮((HeaderedContentControl) radDesktopAlert2, (object) header);
            string body = alertValues.Body;
            EngineViewModel.\u200D‪⁭‏⁫‏‭‏‏⁬⁯‌⁯‪‎‬⁮​⁫‭‮‌⁯‮‭‬⁯⁭‫⁫⁫⁫⁪‏‎‮⁪⁪⁬⁮‮((ContentControl) radDesktopAlert2, (object) body);
            SolidColorBrush solidColorBrush = EngineViewModel.\u206C‪⁯⁬‫‪⁪​⁮‪‪‫⁬‎⁭‬​⁭‎‍‪‫‭​‏‍‭‍‮⁭⁮‌‎‮‬⁮⁭‭‪‏‮(alertValues.AlertColor);
            EngineViewModel.\u206A‎‌‪‎‍‬⁭‫‪‬⁪⁬‪⁫‏​​⁯⁯‫⁮‮‎‍‎⁬⁬⁫⁫‌‏⁫⁭‎⁭‌‭‪‍‮((Control) radDesktopAlert2, (System.Windows.Media.Brush) solidColorBrush);
            int num7 = 5000;
            EngineViewModel.\u200C⁫‎‮‫⁭‍‏⁭⁪​‍‏⁭‫⁯​‪​‮‏‎‎⁭‮⁬⁬⁪​⁭⁫⁭⁭⁫‏⁯‭‎‭⁭‮(radDesktopAlert2, num7);
            radDesktopAlert1 = radDesktopAlert2;
            num1 = 981979116;
            continue;
          case 8:
            EngineViewModel.\u206E⁬⁮‪‪‪‬‍‌‫⁮‮⁬‍‏‭‭‫⁫‏‪‭‮‪‮⁯‭‭⁭⁭‬⁮‎‬⁫⁪‌⁫⁪⁪‮(this.desktopAlertManager, radDesktopAlert1, true);
            num1 = (int) num3 * 403977945 ^ 254835051;
            continue;
          case 9:
            goto label_3;
          case 10:
            num1 = (int) num3 * 507169597 ^ -1653735831;
            continue;
          case 11:
            num1 = (int) num3 * -1726482903 ^ 1052408955;
            continue;
          case 12:
            EngineViewModel.\u200D‏‮​⁪‍⁭‭​⁫⁭‬⁯‪⁪‌‭‭‍⁪‮‏‏⁭‫⁫⁯‏⁪⁬‭‫⁯‎⁫⁭⁫‏‪⁭‮(this.desktopAlertManager, list[index], true);
            num1 = (int) num3 * -1573264517 ^ 1105663352;
            continue;
          case 13:
            goto label_1;
          case 14:
            flag2 = alertValues != null;
            num1 = (int) num3 * 2144972692 ^ -1519544337;
            continue;
          case 15:
            num1 = (int) num3 * 29625973 ^ 1838592058;
            continue;
          case 16:
            alertValues = obj as AlertValues;
            num1 = (int) num3 * 746283185 ^ 529146930;
            continue;
          case 17:
            int num8 = flag2 ? 976968108 : (num8 = 1142642763);
            int num9 = (int) num3 * 744259840;
            num1 = num8 ^ num9;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_3:;
    }

    internal void SetStatus(string newstatus)
    {
label_1:
      int num1 = -55257980;
      while (true)
      {
        int num2 = -870940566;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 23U)
        {
          case 0:
            num1 = (int) num3 * 484427206 ^ 336393083;
            continue;
          case 1:
            flag2 = this.ActiveActivity != null;
            num1 = (int) num3 * 43506895 ^ 722299742;
            continue;
          case 2:
            int num4 = flag2 ? -1039548492 : (num4 = -801520172);
            int num5 = (int) num3 * 1912210095;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * -1316369597 ^ -1814334392;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * -1509720707 ^ 2068529183;
            continue;
          case 6:
            num1 = (int) num3 * 316386790 ^ -1588268435;
            continue;
          case 7:
            int num6 = flag3 ? 1450224930 : (num6 = 1386101192);
            int num7 = (int) num3 * -1171919385;
            num1 = num6 ^ num7;
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num3 * -1896895746 ^ -1286094166;
            continue;
          case 10:
            flag1 = !EngineViewModel.\u200E⁮‌⁮⁪‮‍‭‎‭‌⁬‭⁮‍‪‭⁪⁭‌‪‮⁪‬‍‫⁫⁪⁪‮‪⁪‏‮⁮⁯‮‬⁯‍‮(newstatus, string.Empty);
            num1 = -1211299412;
            continue;
          case 11:
            this.UpdateRecentStatuses(newstatus);
            num1 = (int) num3 * -1796205810 ^ 1975409783;
            continue;
          case 12:
            num1 = (int) num3 * -1509220664 ^ -440230502;
            continue;
          case 13:
            int num8 = !flag1 ? 1652128029 : (num8 = 765327661);
            int num9 = (int) num3 * 2146233173;
            num1 = num8 ^ num9;
            continue;
          case 14:
            this.MajorStatus = this.ActiveMeeting.MeetingId;
            num1 = (int) num3 * -1659919140 ^ -1691761757;
            continue;
          case 15:
            num1 = (int) num3 * 822356675 ^ 2131728218;
            continue;
          case 16:
            this.LogMessage = newstatus;
            num1 = (int) num3 * 1712893999 ^ -502272748;
            continue;
          case 17:
            this.MajorStatus = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(620103131U);
            num1 = -1942782824;
            continue;
          case 18:
            num1 = (int) num3 * 1062992377 ^ 60608065;
            continue;
          case 19:
            int num10;
            num1 = num10 = this.ActiveMeeting == null ? -1713853126 : (num10 = -370509620);
            continue;
          case 20:
            num1 = (int) num3 * -1280636234 ^ -300488381;
            continue;
          case 21:
            flag3 = !EngineViewModel.\u200E⁮‌⁮⁪‮‍‭‎‭‌⁬‭⁮‍‪‭⁪⁭‌‪‮⁪‬‍‫⁫⁪⁪‮‪⁪‏‮⁮⁯‮‬⁯‍‮(newstatus, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(907181687U));
            num1 = -2042621898;
            continue;
          case 22:
            this.MajorStatus = this.ActiveActivity.Name;
            num1 = (int) num3 * -312959533 ^ 1316062362;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return;
label_3:;
    }

    private void UpdateRecentStatuses(string newstatus)
    {
      List<string> recentStatuses = this.recentStatuses;
      bool flag = false;
      try
      {
        EngineViewModel.\u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮((object) recentStatuses, ref flag);
label_2:
        int num1 = 1590557682;
        while (true)
        {
          int num2 = 177718580;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              this.recentStatuses.RemoveAt(this.recentStatuses.Count - 1);
              num1 = (int) num3 * 1427115627 ^ 1916633801;
              continue;
            case 1:
              num1 = (int) num3 * -41960988 ^ 608204204;
              continue;
            case 3:
              num1 = (int) num3 * -566271132 ^ 785799514;
              continue;
            case 4:
              num1 = (int) num3 * -838037351 ^ 1293459273;
              continue;
            case 5:
              int num4;
              num1 = num4 = this.recentStatuses.Count >= 10 ? 1348675686 : (num4 = 1136368771);
              continue;
            case 6:
              num1 = (int) num3 * 282228188 ^ 1609490511;
              continue;
            case 7:
              goto label_2;
            case 8:
              num1 = 843490228;
              continue;
            case 9:
              this.recentStatuses.Insert(0, newstatus);
              num1 = (int) num3 * -625789874 ^ -40242891;
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
          int num1 = 1205844886;
          while (true)
          {
            int num2 = 177718580;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_13;
              case 2:
                EngineViewModel.\u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮((object) recentStatuses);
                num1 = (int) num3 * 340596139 ^ 1182386165;
                continue;
              case 3:
                num1 = (int) num3 * -565486562 ^ 217720319;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(466635750U));
    }

    internal void UpdateMonitor(int monitorNumber, string screenDeviceName)
    {
      this.Engine.Settings.SetMonitorScreen(monitorNumber, screenDeviceName);
label_1:
      int num1 = -678719854;
      while (true)
      {
        int num2 = -803424875;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1024389709 ^ -1704248284;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.RaisePropertyChanged(EngineViewModel.\u200F‍‫‪‌‍⁫‬‮⁮‏⁯​‮⁯‮⁪‭‏⁬‎‮‍‏‎⁮​‌⁭‮⁯‬⁫‍⁬⁯‍⁬‭⁪‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2047244567U), (object) monitorNumber));
    }

    static Delegate \u200D⁫‬‏‬‍‏⁮‎‮⁬⁬‌‌‬‭⁮‬‏⁮‏‬​‮‫⁪‪⁬‍⁮⁮‫⁭⁬‪​⁮‮​⁮‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u206F⁯⁪⁪⁬‎⁪‎‪⁮‏‏‪‎⁫⁮‬‫‮‪‏‏‎⁮‮⁪⁬‌⁭​‌‌‎‮‎‫‌‮‪‮‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static bool \u206E‮‫⁪‍‬‏‭‬⁪‌⁫⁫‏⁫⁬⁪‍‮‫​​‮‫‍‏⁫​‏‌⁬‌‎⁬‎‫‍‌‪‬‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static void \u200F⁮⁯⁬⁬⁬‏‮‌⁯⁭‬‬‫⁭⁫‮⁪‍⁯​‏‎‌⁫⁪‭⁫‮⁯‮​⁪⁪‌‬⁭⁭‎⁯‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static string \u200C‍‍⁬‪‬‭⁮⁫⁪‌​⁬‮‪‌‪⁭‏‪​⁬​‪⁬‮‏‎⁯⁪⁭⁫‮‎‪‎‪⁪⁫‌‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0 + obj1 + obj2;
    }

    static void \u200E⁬⁯‬‬‮‮‫⁫‌‪‬‏‪‪⁭‪‍‌⁮⁮‮⁯‮⁯‏⁫‏‮⁮‫‍⁮⁮‎‫‭​⁫‬‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static object \u206C⁮⁫⁬‪⁮‬‭‮⁪‎‬‪‫⁫‍⁫⁯⁯⁪‮‫‎‮‏‮⁬‪⁯‌‭⁮‮‬‭⁯‏​‮‮([In] FrameworkElement obj0, [In] object obj1)
    {
      return obj0.FindResource(obj1);
    }

    static void \u202A‫⁫‭‏‌⁬‌⁪⁮‌⁭‪‍⁫⁯‎⁬‎‌‌‭‪‭‌‪⁯‍‎⁯‏⁭‎‬⁫‬‫‭⁮⁬‮([In] Window obj0, [In] EventHandler obj1)
    {
      obj0.Closed += obj1;
    }

    static string \u206B‭‫⁬⁬‫‪⁫‫⁮⁯‭⁭⁬⁪⁬⁯‪‬‫‬⁭⁮​⁪‪‫⁭⁯​‫⁫‭‫‪‎⁭​‬⁭‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u206E‍‏‫⁮‮‭‍⁯‏⁯⁪‪​⁮‪⁭‪‮‎‭⁮‪‭‏⁮⁪⁬‫‬‍⁪⁬⁫⁪⁭‫​‎⁯‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static bool \u200B‌​⁮‭⁬⁬‫‫‌‍‭‬⁯​‪⁭‭‌⁯‍‫‍‮⁫⁬‍‭‫‍‍‬‪⁬⁮‫‮‍‪‌‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u200B‏​⁫⁬‍‍‮‮‍⁪‪‪⁮‌‌‏‎‬⁪⁭‌​​‌‬‏⁫⁭​‮⁪⁫⁮⁬‮‎⁬⁬⁮‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static void \u202C‬​‭⁬‎‮⁯⁮‌‭⁬‌⁪‎‬⁮‍‍‮⁮‪⁭⁯‌⁫‫‏⁫‫‏​⁫‬⁭‬⁬‍⁬‌‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static Type \u206E‏‌‏⁮⁪⁯​⁬‮‎⁬⁪‏⁪‬‬⁯‌⁭‪⁭‭⁪‮‌⁬‪‪⁪⁮‎‫⁭​⁭‎‭‌⁯‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static string \u202C‪⁮⁫‭⁭‏⁮‏​‭‪‌‏‮⁯⁯‏‍‮⁯⁮‬⁫⁪‪⁭⁮⁬⁫⁭⁭‎‭⁭​‮⁪‪‌‮([In] MemberInfo obj0)
    {
      return obj0.Name;
    }

    static bool \u202A⁪⁬‍⁬⁯‭‌⁭‏⁫⁯​‌⁭⁬‫​‮‭‮‫‍⁯⁬​⁪‭‍‮‪‮⁯⁯‪⁪‭‎⁯‬‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static void \u206E​‍⁬⁫‪‬‮⁮‬⁪‮‌⁮‮⁮​‬‌⁯‭⁫⁭‭⁮‪‮⁮‌‮⁫‎⁯‏​‬⁯‫‪‏‮([In] DelegateCommandBase obj0)
    {
      obj0.RaiseCanExecuteChanged();
    }

    static bool? \u206A‪‮‬​⁭‫⁪⁯‭‏‭⁯‏‌‌⁫‬⁪⁪‫‪⁬‬‍​‏⁯⁫‍⁯‬‫⁭‭⁫‭‭‬‭‮([In] Window obj0)
    {
      return obj0.ShowDialog();
    }

    static WindowInteropHelper \u206F⁪‌‪⁭‮‍⁬‎⁭⁮⁬‍‌‪‍‮‭‬‏‍⁮⁫‬‏⁬‫‏‌‏⁪‮‏⁫​‎‎‮‌‮‮([In] Window obj0)
    {
      return new WindowInteropHelper(obj0);
    }

    static IntPtr \u200D‏‪‎⁯‭⁬⁭‍‪‭⁪‮‮⁫⁭‌‏⁭⁪‎​‎‮‌‌⁪‬‌⁫⁬‭⁮​‎‪⁪⁭⁯‫‮([In] WindowInteropHelper obj0)
    {
      return obj0.Handle;
    }

    static RadDesktopAlertManager \u206E‌⁭‫‮‮‌‭⁫‌⁫⁯⁪⁮⁫‌‭‬‎⁫‬‌‫⁪⁪⁭‍‪⁬⁪‫⁭⁫⁭‍‌‫‍‫‬‮()
    {
      return new RadDesktopAlertManager();
    }

    static Dispatcher \u202A‭‫⁪⁪⁪‬‬⁪‫⁪‌⁮⁯‫⁭⁮⁬‬⁮⁬‫⁬‌⁬⁫‍‭⁬‬‪⁯‏‎‌‬‎‌⁭‪‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static DispatcherTimer \u206A‪‏‬⁪‏‭⁪‭‬‭‬‏​‬‭‎‫‮⁫‭⁬‭‏⁪⁫‫⁭​⁭⁫‏​‫⁫​‌‍⁯⁯‮([In] DispatcherPriority obj0, [In] Dispatcher obj1)
    {
      return new DispatcherTimer(obj0, obj1);
    }

    static void \u206C‫‌‎‮‌⁪⁯‪⁫⁭‎⁬‍‭‌‌⁫‎⁮‍​‍⁮‭‍‪⁯⁫‫‎‍‫‫‭‮‮‌‭‏‮([In] DispatcherTimer obj0, [In] TimeSpan obj1)
    {
      obj0.Interval = obj1;
    }

    static void \u206F⁪‍⁮‪‮‎⁪‍⁮⁭⁬‍⁭‭‏‌‪‬‪‎⁬‮⁮‍‭‌‏​‬⁭‪⁯‮‫‫‬‌‏‮‮([In] DispatcherTimer obj0, [In] EventHandler obj1)
    {
      obj0.Tick += obj1;
    }

    static void \u202E‪⁫‍‬‭⁫⁯⁪⁫‍⁮‏⁪‏⁮‬​‍‏⁬‌⁭‎⁭‏‎‏‏⁬‎⁮‫‬‍‪‍⁯‬⁪‮([In] DispatcherTimer obj0)
    {
      obj0.Start();
    }

    static bool \u202B‬‫‭‬‬‭⁪⁪​⁬⁬​‪⁮​⁮⁮‍⁬⁫‫⁯‌⁭⁮‫⁮⁯‫‮‎‍​⁯‫​‎⁮‏‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static string \u200F‍‫‪‌‍⁫‬‮⁮‏⁯​‮⁯‮⁪‭‏⁬‎‮‍‏‎⁮​‌⁭‮⁯‬⁫‍⁬⁯‍⁬‭⁪‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static System.Windows.Media.Color \u200D⁭⁮⁫‎⁫‌‪‫​⁮‭‌‭‎⁮‎‬⁮⁫⁪‎‮⁭‬‭‏‌‬⁮⁮⁬⁫⁮‍⁫‮‍‎⁬‮()
    {
      return Colors.IndianRed;
    }

    static string \u202C‭‏‬‪⁪‎‎‫‭⁭‫⁮⁮‮‌‍‪‍⁫‪‏‭⁪⁬⁫‮⁬​⁭‮‫⁫‍‭​‏‮‍⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static System.Windows.Media.Color \u206D‬‫⁪⁯​⁪⁪‪‎⁭‭‭‫⁭‎‭‮⁬‫‌⁬‭⁮‏‫⁯⁬⁫‬​‍⁬‭‏​‎⁯‏‫‮()
    {
      return Colors.BlanchedAlmond;
    }

    static string \u202A‪⁬⁯⁭‫⁬⁯⁪⁮‎‮⁪‬⁪‌‮‮‍⁮‪⁮⁯‌⁯‏⁯⁯‪⁮‭​⁮‮‪⁮‬⁮⁫‏‮([In] PropertyChangedEventArgs obj0)
    {
      return obj0.PropertyName;
    }

    static bool \u200E⁮‌⁮⁪‮‍‭‎‭‌⁬‭⁮‍‪‭⁪⁭‌‪‮⁪‬‍‫⁫⁪⁪‮‪⁪‏‮⁮⁯‮‬⁯‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static Application \u200B⁪​‎‏‮⁯‏‏‬‪‫‬‭‪‌​‮⁪⁫⁭⁭‬‬⁬‮‬‬⁪⁯⁬⁫‌‏⁬‮⁮⁬‬‬‮()
    {
      return Application.Current;
    }

    static void \u202B⁭‌​‌⁮‏​⁪‭‪‌​⁭⁭⁭⁮‮⁮⁪⁫‏‭​‭⁭‪‪‮‮​‬‭‫‬‌⁮‭‪‪‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static void \u202C‭‫​⁭​‬‫‏​‮⁯‫‫‮⁮‍⁫⁮​‮‮‫⁫‫⁯​⁪‎‮‫‭​​⁮⁫‮‬⁯⁬‮()
    {
      CommandManager.InvalidateRequerySuggested();
    }

    static bool \u200B‮‮⁫‌⁪‬‎‌⁭‭⁪‬⁯‏⁫⁪‎⁭‪‍⁪⁬​‎⁪‪⁮⁯‫‍⁮‎⁪‮⁪⁬‮‎⁭‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static void \u200C⁮⁫‫⁮‭‎⁭‭⁬‮‏‪‫⁮‍‎‫‍⁭‌⁯⁮‏‌‎‎⁪⁮‌‫‎‪⁮‬⁮‪‮‮‭‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static DelegateCommand \u200D‪‎⁮⁭⁬⁯​‏‬​⁯‍‎‍​⁪⁭⁫⁫‮‏⁭⁮‬⁮‬⁭‭⁯⁮‌‎⁪‌⁫‌‬‪⁬‮([In] Action obj0, [In] Func<bool> obj1)
    {
      return new DelegateCommand(obj0, obj1);
    }

    static DelegateCommand \u200D‮⁬‭⁭‌⁯⁭‬⁭⁬⁮‏⁮⁮‭‬⁬⁬⁯‮‫‏‫⁬⁮‪‌‍‍‪‬⁮‍⁬‎⁯‭‍‍‮([In] Action obj0)
    {
      return new DelegateCommand(obj0);
    }

    static void \u206D‪‮‎⁮‭‫‍‪‪‎‍​⁪‭⁪⁭⁬‍⁮‭‭⁪‫‪‬‭⁫‍⁫‌⁬⁫‮‮​‫⁬⁫⁭‮([In] Window obj0, [In] WindowState obj1)
    {
      obj0.WindowState = obj1;
    }

    static Assembly \u200D⁫⁪⁯‮⁫‌‎⁭‌⁪‌⁪⁪⁮⁫‎⁪⁯⁮⁮⁭⁪‮‌⁬⁯‍​‭‏⁫​⁫‮‭‌‌‬⁮‮()
    {
      return Assembly.GetExecutingAssembly();
    }

    static Type[] \u200B⁯‮⁫​​‎‪⁭​‫‌‍‭‬‎‫‪‮⁪‎‌‏⁫‫​‍⁮⁫⁭⁯‭‭⁮‎‍⁬‪⁬‏‮([In] Assembly obj0)
    {
      return obj0.GetTypes();
    }

    static bool \u200F‮⁯‎‭‫‬​‮⁫‪⁬⁮‍‎⁭⁭⁭‪‮⁬‬‬‎⁪‪​⁫⁪​‌‍‍⁪⁭‭‎⁭⁮‭‮([In] Type obj0, [In] Type obj1)
    {
      return Type.op_Inequality(obj0, obj1);
    }

    static object \u206A‭‭⁭⁯‮‫‌‌‌‌‏‍‪⁮⁮‎⁮‍⁯⁬‬‎‌⁪‎⁮⁯⁯‎⁭​⁫⁫‬‪‏‬‏‫‮([In] Type obj0)
    {
      return Activator.CreateInstance(obj0);
    }

    static void \u206F‮‪⁯⁮‬‬⁪‭⁭⁭⁯‬⁪‫‫⁬⁪‍⁪⁮‮⁮⁮⁫⁮⁪‪​⁬⁪⁬⁪‪‏⁬⁭⁬⁪‎‮([In] Window obj0)
    {
      obj0.Show();
    }

    static string \u200F⁭‮‎‭​‫​‌​‬‍⁮​⁭​⁭⁭⁭‎‭‎‍‫‬‪‎⁯‬⁮‌‌⁮‎​‌‪⁮‍‫‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static void \u206C⁮‌⁪‎⁬⁫⁮​⁬‏‮⁮‮‭⁯‬⁫⁮⁭‫‏⁪⁮‭‏‏⁬‌‎⁫‫‌‌‮⁪‏⁬‮‍‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static bool \u202B‍⁫‌⁫‌⁯‌‪​‭‬‍⁪‮‭‍‮‬⁮⁯‍‭‬‏​‍‍​⁫‌‫⁮‪‭‪​​‫⁬‮([In] UIElement obj0)
    {
      return obj0.IsVisible;
    }

    static void \u200C‌‫⁪⁪​‎⁭​​‌‌⁮‬⁬​⁬⁯⁬⁯‏‬⁯‫‫⁫⁪‬⁫‪⁭‫⁭‬‌‭‍‎‎‮‮([In] Window obj0)
    {
      obj0.Close();
    }

    static SolidColorBrush \u206C‪⁯⁬‫‪⁪​⁮‪‪‫⁬‎⁭‬​⁭‎‍‪‫‭​‏‍‭‍‮⁭⁮‌‎‮‬⁮⁭‭‪‏‮([In] System.Windows.Media.Color obj0)
    {
      return new SolidColorBrush(obj0);
    }

    static void \u206A‎‌‪‎‍‬⁭‫‪‬⁪⁬‪⁫‏​​⁯⁯‫⁮‮‎‍‎⁬⁬⁫⁫‌‏⁫⁭‎⁭‌‭‪‍‮([In] Control obj0, [In] System.Windows.Media.Brush obj1)
    {
      obj0.Background = obj1;
    }

    static IEnumerable<RadDesktopAlert> \u202D⁭‏‍‬​‬⁪‮‎‪‍‍‪⁪‏⁬‫‌⁫⁭‎‭‏‏‏‬‮‎⁯⁫⁯‭⁯‎⁫⁯‎‫⁬‮([In] RadDesktopAlertManager obj0)
    {
      return obj0.GetAllAlerts();
    }

    static void \u200E⁭​‍⁪‌‬⁭‎‮‏‍‏‭⁯‏⁮‍​‪‌​‍‮⁭⁭‏‫⁯⁪‬‬​‮⁯‪⁯‏⁫‎‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u200D‏‮​⁪‍⁭‭​⁫⁭‬⁯‪⁪‌‭‭‍⁪‮‏‏⁭‫⁫⁯‏⁪⁬‭‫⁯‎⁫⁭⁫‏‪⁭‮([In] RadDesktopAlertManager obj0, [In] RadDesktopAlert obj1, [In] bool obj2)
    {
      obj0.CloseAlert(obj1, obj2);
    }

    static RadDesktopAlert \u202A‮⁫‭‎‬⁫⁬⁮⁫⁮⁪‍⁮⁭‏⁫‌​‫⁮‪‫⁭‌⁪⁪‌⁫‬‍‎⁬‮‮⁯​‍⁮‪‮()
    {
      return new RadDesktopAlert();
    }

    static void \u206D‎‏‎​‌‏‌‎‎‏‌‬⁭​‭‭‎‪⁭‍⁯‌⁫‫⁫‮⁮‭⁬​‮‏⁬‎⁭‬​‪‌‮([In] HeaderedContentControl obj0, [In] object obj1)
    {
      obj0.Header = obj1;
    }

    static void \u200D‪⁭‏⁫‏‭‏‏⁬⁯‌⁯‪‎‬⁮​⁫‭‮‌⁯‮‭‬⁯⁭‫⁫⁫⁫⁪‏‎‮⁪⁪⁬⁮‮([In] ContentControl obj0, [In] object obj1)
    {
      obj0.Content = obj1;
    }

    static void \u200C⁫‎‮‫⁭‍‏⁭⁪​‍‏⁭‫⁯​‪​‮‏‎‎⁭‮⁬⁬⁪​⁭⁫⁭⁭⁫‏⁯‭‎‭⁭‮([In] RadDesktopAlert obj0, [In] int obj1)
    {
      obj0.set_ShowDuration(obj1);
    }

    static void \u206E⁬⁮‪‪‪‬‍‌‫⁮‮⁬‍‏‭‭‫⁫‏‪‭‮‪‮⁯‭‭⁭⁭‬⁮‎‬⁫⁪‌⁫⁪⁪‮([In] RadDesktopAlertManager obj0, [In] RadDesktopAlert obj1, [In] bool obj2)
    {
      obj0.ShowAlert(obj1, obj2);
    }

    static string \u206E‬⁫⁫‪‮‎‏⁪‎⁯‬⁫⁭‫⁫⁯⁭⁯‪‏‌‎⁫‮‌‌⁪‮⁬⁪‫‬⁮‬⁭‏‪‌‮‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }
  }
}
