// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Settings
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Utils;
using ZoomZoom.Models.Windows;
using ZoomZoom.Properties;
using ZoomZoomLicense;

namespace ZoomZoom
{
  public class Settings : CoreObject
  {
    private static readonly object settingsLock = Settings.\u206A​‭⁪⁭‭‬​⁭⁬‬‭⁭‌‌‮‮⁭‏‍‬⁬⁪‮‌⁫‎‮​⁭⁮‮‭‪‌⁫‌‪⁮‮();
    private SharedData sharedData = (SharedData) null;
    private string userName = string.Empty;
    private List<string> names = new List<string>();
    private MessageCategory staticCategory = (MessageCategory) null;
    private MessageContent dateTimeContent = (MessageContent) null;
    private MessageContent guidContent = (MessageContent) null;
    private MessageContent randomTextContent = (MessageContent) null;
    private MessageContent previousChatContent = (MessageContent) null;
    private Dictionary<int, string> monitorScreenDictionary = new Dictionary<int, string>();
    private string primaryScreen = string.Empty;
    private string secondaryScreen = string.Empty;
    private static readonly List<string> lineart;
    private string zoomExePath;
    private static List<ZoomMonitor> monitors;
    private static List<MessageContent> greetings;
    private static List<MessageCategory> staticMessageSources;
    private static ObservableCollection<StringItem> joinUserNames;
    private static ObservableCollection<StringItem> meetingAutoFindUsers;
    private List<string> availableMonitors;
    private bool checkForWar;
    private List<string> predefinedMonitors;

    public string ZoomExePath
    {
      get
      {
label_1:
        int num1 = -114130015;
        string zoomExePath;
        while (true)
        {
          int num2 = -1753265348;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -520127955 ^ 1862765338;
              continue;
            case 1:
              zoomExePath = this.zoomExePath;
              num1 = (int) num3 * 425595366 ^ -1107827058;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return zoomExePath;
      }
      set
      {
        this.zoomExePath = value;
      }
    }

    public string ZoomZoomRoot
    {
      get
      {
        string zoomZoomRoot = Resources.ZoomZoomRoot;
label_1:
        int num1 = -753012434;
        while (true)
        {
          int num2 = -1289632890;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -327440625 ^ -97626444;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomZoomRoot;
      }
    }

    public string ButtonRoot
    {
      get
      {
        return Settings.\u200E‏‬‪⁪‫‌‪⁯‮​⁬⁯‫‪⁮⁯⁯‌⁭⁫‪‫‏‪‪‌⁮‬⁮‏‍‪​⁯⁫⁯​⁯‫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3286739789U), (object) Resources.ZoomZoomRoot, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(533672781U));
      }
    }

    public string MeetingsRoot
    {
      get
      {
label_1:
        int num1 = 302995224;
        string str;
        while (true)
        {
          int num2 = 337599733;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1089241851 ^ -1388627658;
              continue;
            case 1:
              str = Settings.\u200E‏‬‪⁪‫‌‪⁯‮​⁬⁯‫‪⁮⁯⁯‌⁭⁫‪‫‏‪‪‌⁮‬⁮‏‍‪​⁯⁫⁯​⁯‫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3286739789U), (object) Resources.ZoomZoomRoot, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1532898753U));
              num1 = (int) num3 * -1571380070 ^ -740126101;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return str;
      }
    }

    public string WindowsRoot
    {
      get
      {
label_1:
        int num1 = -1370643783;
        string str;
        while (true)
        {
          int num2 = -172967741;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              str = Settings.\u200E‏‬‪⁪‫‌‪⁯‮​⁬⁯‫‪⁮⁯⁯‌⁭⁫‪‫‏‪‪‌⁮‬⁮‏‍‪​⁯⁫⁯​⁯‫‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1579082841U), (object) Resources.ZoomZoomRoot, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2192393157U));
              num1 = (int) num3 * 2128760562 ^ -280207408;
              continue;
            case 3:
              num1 = (int) num3 * -73317484 ^ -1516809170;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return str;
      }
    }

    public string LayoutsRoot
    {
      get
      {
label_1:
        int num1 = 630217687;
        string str;
        while (true)
        {
          int num2 = 212330189;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              str = Settings.\u200E‏‬‪⁪‫‌‪⁯‮​⁬⁯‫‪⁮⁯⁯‌⁭⁫‪‫‏‪‪‌⁮‬⁮‏‍‪​⁯⁫⁯​⁯‫‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(24001649U), (object) Resources.ZoomZoomRoot, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2337353918U));
              num1 = (int) num3 * 2037145349 ^ -457090250;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return str;
      }
    }

    public string LicenseRoot
    {
      get
      {
        string str = Settings.\u200E‏‬‪⁪‫‌‪⁯‮​⁬⁯‫‪⁮⁯⁯‌⁭⁫‪‫‏‪‪‌⁮‬⁮‏‍‪​⁯⁫⁯​⁯‫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3099078699U), (object) Resources.ZoomZoomRoot, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2480803136U));
label_1:
        int num1 = -1815500175;
        while (true)
        {
          int num2 = -1589671080;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1791837943 ^ -1039834318;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return str;
      }
    }

    public string ImageRoot
    {
      get
      {
        string str = Settings.\u200E‏‬‪⁪‫‌‪⁯‮​⁬⁯‫‪⁮⁯⁯‌⁭⁫‪‫‏‪‪‌⁮‬⁮‏‍‪​⁯⁫⁯​⁯‫‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1579082841U), (object) Resources.ZoomZoomRoot, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1816094165U));
label_1:
        int num1 = -1176333762;
        while (true)
        {
          int num2 = -499614309;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1585403735 ^ 1415198375;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return str;
      }
    }

    public string URL_LicenseRoot
    {
      get
      {
label_1:
        int num1 = -686512219;
        string urlLicenseRoot;
        while (true)
        {
          int num2 = -2006518914;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              urlLicenseRoot = ZoomZoom.Properties.Settings.Default.URL_LicenseRoot;
              num1 = (int) num3 * -1700991011 ^ 1274712164;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return urlLicenseRoot;
      }
    }

    public License License
    {
      get
      {
        License zoomZoomLicense = ZoomZoom.Properties.Settings.Default.ZoomZoomLicense;
label_1:
        int num1 = 1931685939;
        while (true)
        {
          int num2 = 403927167;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1646724968 ^ -329331703;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomZoomLicense;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.ZoomZoomLicense = value;
label_1:
        int num1 = 624637918;
        while (true)
        {
          int num2 = 1181809792;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -1719514796 ^ -1808725303;
              continue;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -279108899 ^ -204680849;
              continue;
            case 3:
              num1 = (int) num3 * 165739335 ^ 320654042;
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
    }

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Application;
label_1:
        int num1 = 1972578467;
        while (true)
        {
          int num2 = 1517682016;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -663840466 ^ -890048551;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public List<string> Screens
    {
      get
      {
label_1:
        int num1 = 1356137889;
        List<string> availableMonitors;
        while (true)
        {
          int num2 = 1898740189;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              availableMonitors = this.availableMonitors;
              num1 = (int) num3 * 263199033 ^ -399440399;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return availableMonitors;
      }
      set
      {
label_1:
        int num1 = 220417868;
        while (true)
        {
          int num2 = 514408361;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * 1906075931 ^ 748821702;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3201152552U));
              num1 = (int) num3 * 33217566 ^ 1656247625;
              continue;
            case 2:
              this.availableMonitors = value;
              num1 = 948267504;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = flag ? 479682645 : (num4 = 185883223);
              int num5 = (int) num3 * 1977906439;
              num1 = num4 ^ num5;
              continue;
            case 5:
              flag = this.availableMonitors == value;
              num1 = (int) num3 * 226687594 ^ 1260993639;
              continue;
            case 6:
              num1 = (int) num3 * 1175595603 ^ 1569075492;
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

    public bool TraceHookEvents
    {
      get
      {
label_1:
        int num1 = -112399258;
        bool traceHookEvents;
        while (true)
        {
          int num2 = -1216021524;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceHookEvents = ZoomZoom.Properties.Settings.Default.TraceHookEvents;
              num1 = (int) num3 * -749425858 ^ -1376983457;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceHookEvents;
      }
      set
      {
label_1:
        int num1 = -143104326;
        while (true)
        {
          int num2 = -1805133751;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -495576222 ^ 1107982672;
              continue;
            case 3:
              ZoomZoom.Properties.Settings.Default.TraceHookEvents = value;
              num1 = (int) num3 * 728442380 ^ 95850515;
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

    public bool TraceWindowEvents
    {
      get
      {
        bool traceWindowEvents = ZoomZoom.Properties.Settings.Default.TraceWindowEvents;
label_1:
        int num1 = 174002954;
        while (true)
        {
          int num2 = 459226379;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 629756087 ^ -1161496424;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceWindowEvents;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.TraceWindowEvents = value;
label_1:
        int num1 = -1808601553;
        while (true)
        {
          int num2 = -2135118406;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -2099763545 ^ -1541297845;
              continue;
            case 2:
              num1 = (int) num3 * -870937541 ^ -1899642161;
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
    }

    public bool TraceLayoutEvents
    {
      get
      {
label_1:
        int num1 = -1389920039;
        bool traceLayoutEvents;
        while (true)
        {
          int num2 = -1100742790;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              traceLayoutEvents = ZoomZoom.Properties.Settings.Default.TraceLayoutEvents;
              num1 = (int) num3 * -572705734 ^ -1820964732;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceLayoutEvents;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.TraceLayoutEvents = value;
label_1:
        int num1 = 451192262;
        while (true)
        {
          int num2 = 672758205;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1114605147 ^ -1307830308;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -818883631 ^ -1496385146;
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

    public bool TraceApplicationEvents
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.TraceApplicationEvents;
      }
      set
      {
label_1:
        int num1 = -191036712;
        while (true)
        {
          int num2 = -582137189;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              ZoomZoom.Properties.Settings.Default.TraceApplicationEvents = value;
              num1 = (int) num3 * 1701884334 ^ -1640138561;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
      }
    }

    public bool TraceUserInterfaceEvents
    {
      get
      {
        bool userInterfaceEvents = ZoomZoom.Properties.Settings.Default.TraceUserInterfaceEvents;
label_1:
        int num1 = 24259900;
        while (true)
        {
          int num2 = 1001094012;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 2034650353 ^ -188010476;
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
        ZoomZoom.Properties.Settings.Default.TraceUserInterfaceEvents = value;
label_1:
        int num1 = -1011294989;
        while (true)
        {
          int num2 = -1585429279;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1363989992 ^ 486202754;
              continue;
            case 3:
              num1 = (int) num3 * -1619455219 ^ 1274634591;
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

    public bool TraceUserEvents
    {
      get
      {
label_1:
        int num1 = 758416571;
        bool traceUserEvents;
        while (true)
        {
          int num2 = 2013348661;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              traceUserEvents = ZoomZoom.Properties.Settings.Default.TraceUserEvents;
              num1 = (int) num3 * -839693056 ^ 1242218024;
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
        ZoomZoom.Properties.Settings.Default.TraceUserEvents = value;
label_1:
        int num1 = 2048679390;
        while (true)
        {
          int num2 = 1913741748;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -616301613 ^ 523287296;
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

    public bool TraceImageEvents
    {
      get
      {
label_1:
        int num1 = 946182971;
        bool traceImageEvents;
        while (true)
        {
          int num2 = 1332926549;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceImageEvents = ZoomZoom.Properties.Settings.Default.TraceImageEvents;
              num1 = (int) num3 * -242532909 ^ -1942418209;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceImageEvents;
      }
      set
      {
label_1:
        int num1 = -113269055;
        while (true)
        {
          int num2 = -192742559;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -1823629226 ^ -489945739;
              continue;
            case 2:
              ZoomZoom.Properties.Settings.Default.TraceImageEvents = value;
              num1 = (int) num3 * -1475041506 ^ -1460365945;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * 1401014532 ^ -1385258988;
              continue;
            case 5:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 55355063 ^ 1332279309;
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

    public bool TraceChatEvents
    {
      get
      {
label_1:
        int num1 = -1085829124;
        bool traceChatEvents;
        while (true)
        {
          int num2 = -1151996919;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              traceChatEvents = ZoomZoom.Properties.Settings.Default.TraceChatEvents;
              num1 = (int) num3 * 1600852170 ^ -184371524;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1650617079 ^ 325317798;
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
        ZoomZoom.Properties.Settings.Default.TraceChatEvents = value;
label_1:
        int num1 = -929158363;
        while (true)
        {
          int num2 = -535116492;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -207527413 ^ -469967222;
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

    public bool TraceDataStorage
    {
      get
      {
        bool traceDataStorage = ZoomZoom.Properties.Settings.Default.TraceDataStorage;
label_1:
        int num1 = -1805896125;
        while (true)
        {
          int num2 = -684351075;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1815873500 ^ 859281750;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceDataStorage;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.TraceDataStorage = value;
label_1:
        int num1 = -349120766;
        while (true)
        {
          int num2 = -1843053829;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 56032521 ^ 1815493020;
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

    public bool TraceActivityEvents
    {
      get
      {
label_1:
        int num1 = 1852090319;
        bool traceActivityEvents;
        while (true)
        {
          int num2 = 1019014164;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -568547896 ^ 1613880433;
              continue;
            case 3:
              traceActivityEvents = ZoomZoom.Properties.Settings.Default.TraceActivityEvents;
              num1 = (int) num3 * 1357315883 ^ -906778285;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceActivityEvents;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.TraceActivityEvents = value;
label_1:
        int num1 = 871897816;
        while (true)
        {
          int num2 = 1891258926;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 608569258 ^ -696885237;
              continue;
            case 2:
              num1 = (int) num3 * 1709522314 ^ 690004779;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3145512107U));
      }
    }

    public bool TraceMeetingEvents
    {
      get
      {
        bool traceMeetingEvents = ZoomZoom.Properties.Settings.Default.TraceMeetingEvents;
label_1:
        int num1 = 705326600;
        while (true)
        {
          int num2 = 355781883;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1991369762 ^ -1693902161;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceMeetingEvents;
      }
      set
      {
label_1:
        int num1 = 1124803459;
        while (true)
        {
          int num2 = 2136667109;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1013853907 ^ 668097923;
              continue;
            case 2:
              num1 = (int) num3 * 695402371 ^ 1576235813;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2247061808U));
              num1 = (int) num3 * -1446043041 ^ 1531382460;
              continue;
            case 4:
              ZoomZoom.Properties.Settings.Default.TraceMeetingEvents = value;
              num1 = (int) num3 * -963741332 ^ -1298665690;
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

    public bool CheckCapabilitiesAfterJoin
    {
      get
      {
label_1:
        int num1 = -1829797692;
        bool capabilitiesAfterJoin;
        while (true)
        {
          int num2 = -1471446142;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              capabilitiesAfterJoin = ZoomZoom.Properties.Settings.Default.CheckCapabilitiesAfterJoin;
              num1 = (int) num3 * 1578223207 ^ -89709795;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return capabilitiesAfterJoin;
      }
      set
      {
label_1:
        int num1 = -32587604;
        while (true)
        {
          int num2 = -1651938244;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              ZoomZoom.Properties.Settings.Default.CheckCapabilitiesAfterJoin = value;
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 993575677 ^ -542614005;
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

    public bool FindButtonsAfterJoin
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.FindButtonsAfterJoin;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.FindButtonsAfterJoin = value;
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
      }
    }

    public bool VideoChatLinkAutoInitiate
    {
      get
      {
label_1:
        int num1 = 53238304;
        bool linkAutoInitiate;
        while (true)
        {
          int num2 = 1973973911;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 163786912 ^ 240630605;
              continue;
            case 3:
              linkAutoInitiate = ZoomZoom.Properties.Settings.Default.VideoChatLinkAutoInitiate;
              num1 = (int) num3 * -888891667 ^ -850894055;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return linkAutoInitiate;
      }
      set
      {
label_1:
        int num1 = -1787032891;
        while (true)
        {
          int num2 = -178453789;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 325765652 ^ -1479112668;
              continue;
            case 2:
              ZoomZoom.Properties.Settings.Default.VideoChatLinkAutoInitiate = value;
              num1 = (int) num3 * -425770323 ^ 1344519300;
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
    }

    public bool AutoAttendent
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.AutoAttendent;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.AutoAttendent = value;
label_1:
        int num1 = -2061795112;
        while (true)
        {
          int num2 = -1191339485;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3863319382U));
              num1 = (int) num3 * -1141851609 ^ -887607597;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 857652306 ^ 1553902120;
              continue;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -198923125 ^ -788546573;
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

    public bool FloodAfterHold
    {
      get
      {
label_1:
        int num1 = 1020404534;
        bool floodAfterHold;
        while (true)
        {
          int num2 = 1222095684;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 31890306 ^ -1340801579;
              continue;
            case 2:
              floodAfterHold = ZoomZoom.Properties.Settings.Default.FloodAfterHold;
              num1 = (int) num3 * 783030845 ^ -1723143429;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return floodAfterHold;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.FloodAfterHold = value;
label_1:
        int num1 = 1131988966;
        while (true)
        {
          int num2 = 221735771;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -80462483 ^ -496004083;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 716247015 ^ -926496436;
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

    public bool HammerAfterHold
    {
      get
      {
label_1:
        int num1 = -1974219948;
        bool hammerAfterHold;
        while (true)
        {
          int num2 = -236756941;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1019647082 ^ 208670226;
              continue;
            case 2:
              goto label_1;
            case 3:
              hammerAfterHold = ZoomZoom.Properties.Settings.Default.HammerAfterHold;
              num1 = (int) num3 * 778053052 ^ -1024987273;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return hammerAfterHold;
      }
      set
      {
label_1:
        int num1 = -782900853;
        while (true)
        {
          int num2 = -1150283384;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              ZoomZoom.Properties.Settings.Default.HammerAfterHold = value;
              num1 = (int) num3 * -248938059 ^ -138701501;
              continue;
            case 2:
              num1 = (int) num3 * -986074484 ^ 963839977;
              continue;
            case 3:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 2121059718 ^ 774671657;
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

    public bool MoveNextAfterHold
    {
      get
      {
        bool moveNextAfterHold = ZoomZoom.Properties.Settings.Default.MoveNextAfterHold;
label_1:
        int num1 = 109604719;
        while (true)
        {
          int num2 = 1648199106;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1660211693 ^ 979478183;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return moveNextAfterHold;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.MoveNextAfterHold = value;
label_1:
        int num1 = 1596651722;
        while (true)
        {
          int num2 = 229162924;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1675280076 ^ -1099790797;
              continue;
            case 3:
              num1 = (int) num3 * -2109188852 ^ 1882085289;
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

    public OnHoldAction OnHoldAction
    {
      get
      {
        return (OnHoldAction) ZoomZoom.Properties.Settings.Default.OnHold_Action;
      }
      set
      {
label_1:
        int num1 = 1411670394;
        while (true)
        {
          int num2 = 1162327369;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 51881434 ^ -2076529438;
              continue;
            case 2:
              num1 = (int) num3 * 337395013 ^ 471862067;
              continue;
            case 3:
              goto label_3;
            case 4:
              ZoomZoom.Properties.Settings.Default.OnHold_Action = (int) value;
              num1 = (int) num3 * -694874867 ^ 1220243934;
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

    public bool MoveNextAfterRemoved
    {
      get
      {
        bool nextAfterRemoved = ZoomZoom.Properties.Settings.Default.MoveNextAfterRemoved;
label_1:
        int num1 = -1454765014;
        while (true)
        {
          int num2 = -252198926;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 662961270 ^ -198803973;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return nextAfterRemoved;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.MoveNextAfterRemoved = value;
label_1:
        int num1 = -743743188;
        while (true)
        {
          int num2 = -1110247757;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -816426648 ^ 730830664;
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

    public bool HammerAfterRemoved
    {
      get
      {
label_1:
        int num1 = 1193486726;
        bool hammerAfterRemoved;
        while (true)
        {
          int num2 = 646877137;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 695486982 ^ -482973504;
              continue;
            case 3:
              hammerAfterRemoved = ZoomZoom.Properties.Settings.Default.HammerAfterRemoved;
              num1 = (int) num3 * 1638100661 ^ -591084612;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return hammerAfterRemoved;
      }
      set
      {
label_1:
        int num1 = 723229045;
        while (true)
        {
          int num2 = 1758860678;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 584847738 ^ -1036490396;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.HammerAfterRemoved = value;
              num1 = (int) num3 * -393654760 ^ -688273895;
              continue;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -942260051 ^ 1366280352;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              num1 = (int) num3 * -1840638370 ^ 99279134;
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

    public bool JoinDynamicUserName
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.JoinDynamicUserName;
      }
      set
      {
label_1:
        int num1 = -2132002121;
        while (true)
        {
          int num2 = -251922754;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1436440702 ^ -663190895;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.JoinDynamicUserName = value;
              num1 = (int) num3 * 706627340 ^ -417967562;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
      }
    }

    public bool MeetingAutoFindUsersEnabled
    {
      get
      {
label_1:
        int num1 = -767022827;
        bool findUsersEnabled;
        while (true)
        {
          int num2 = -665474056;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              findUsersEnabled = ZoomZoom.Properties.Settings.Default.MeetingAutoFindUsersEnabled;
              num1 = (int) num3 * -1411226709 ^ -376231399;
              continue;
            case 2:
              num1 = (int) num3 * 1388148950 ^ 1670345480;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return findUsersEnabled;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.MeetingAutoFindUsersEnabled = value;
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
      }
    }

    public bool AutoCaptureVideoImages
    {
      get
      {
label_1:
        int num1 = 1863710644;
        bool captureVideoImages;
        while (true)
        {
          int num2 = 849599914;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1134888465 ^ 2066396844;
              continue;
            case 2:
              captureVideoImages = ZoomZoom.Properties.Settings.Default.AutoCaptureVideoImages;
              num1 = (int) num3 * -1765136144 ^ 817555503;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return captureVideoImages;
      }
      set
      {
label_1:
        int num1 = -87777006;
        while (true)
        {
          int num2 = -810683373;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ZoomZoom.Properties.Settings.Default.AutoCaptureVideoImages = value;
              num1 = (int) num3 * 755734618 ^ -1784977101;
              continue;
            case 2:
              num1 = (int) num3 * 203377483 ^ 1185273202;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
      }
    }

    public bool AutoSpotlightEnabled
    {
      get
      {
        bool spotlightEnabled = ZoomZoom.Properties.Settings.Default.AutoSpotlightEnabled;
label_1:
        int num1 = 1929561672;
        while (true)
        {
          int num2 = 579828906;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1351338819 ^ 1820171806;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return spotlightEnabled;
      }
      set
      {
label_1:
        int num1 = 4115173;
        while (true)
        {
          int num2 = 1551603307;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1860368906 ^ -1538226214;
              continue;
            case 2:
              ZoomZoom.Properties.Settings.Default.AutoSpotlightEnabled = value;
              num1 = (int) num3 * -663006810 ^ 1518422330;
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
    }

    public double AutoSpotlightInterval
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.AutoSpotlightInterval;
      }
      set
      {
label_1:
        int num1 = -764129407;
        while (true)
        {
          int num2 = -1963275118;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 1986310278 ^ 904397304;
              continue;
            case 1:
              goto label_3;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -376436783 ^ -980749199;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(95996501U));
              num1 = (int) num3 * -1461076678 ^ 394290421;
              continue;
            case 4:
              goto label_1;
            case 5:
              ZoomZoom.Properties.Settings.Default.AutoSpotlightInterval = value;
              num1 = (int) num3 * 2091164869 ^ 293470101;
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

    public double AutoCaptureVideoInterval
    {
      get
      {
        double captureVideoInterval = ZoomZoom.Properties.Settings.Default.AutoCaptureVideoInterval;
label_1:
        int num1 = 994589341;
        while (true)
        {
          int num2 = 1608219752;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -362395491 ^ 629940049;
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
        int num1 = 1936541404;
        while (true)
        {
          int num2 = 703407513;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -98985143 ^ -1106564312;
              continue;
            case 1:
              num1 = (int) num3 * -1119090585 ^ -60172602;
              continue;
            case 3:
              num1 = (int) num3 * -1933611007 ^ 378092004;
              continue;
            case 4:
              goto label_1;
            case 5:
              ZoomZoom.Properties.Settings.Default.AutoCaptureVideoInterval = value;
              num1 = (int) num3 * -284126848 ^ -262496112;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(436605342U));
      }
    }

    public string LastActivePatternName
    {
      get
      {
label_1:
        int num1 = 1644528224;
        string activePatternName;
        while (true)
        {
          int num2 = 1465376069;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              activePatternName = ZoomZoom.Properties.Settings.Default.LastActivePatternName;
              num1 = (int) num3 * 815812327 ^ -1366682647;
              continue;
            case 3:
              num1 = (int) num3 * -806303965 ^ 422329938;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activePatternName;
      }
      set
      {
label_1:
        int num1 = 982088754;
        while (true)
        {
          int num2 = 2110583051;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -342537710 ^ 1078435084;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(734594548U));
              num1 = (int) num3 * -1695080815 ^ 2019366910;
              continue;
            case 2:
              goto label_1;
            case 3:
              ZoomZoom.Properties.Settings.Default.LastActivePatternName = value;
              num1 = (int) num3 * 680628298 ^ -1169226447;
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

    public string LastFindUserName
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.LastFindUserName;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.LastFindUserName = value;
label_1:
        int num1 = -1084942784;
        while (true)
        {
          int num2 = -1446676860;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1305674359 ^ -38415546;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4070093008U));
              num1 = (int) num3 * 1868442870 ^ 2021115583;
              continue;
            case 3:
              num1 = (int) num3 * 168381470 ^ 938951778;
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
    }

    public int MinimumUserCount
    {
      get
      {
label_1:
        int num1 = 841295700;
        int minimumUserCount;
        while (true)
        {
          int num2 = 1965195605;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              minimumUserCount = ZoomZoom.Properties.Settings.Default.MinimumUserCount;
              num1 = (int) num3 * 1123098487 ^ 1793195113;
              continue;
            case 3:
              num1 = (int) num3 * 1143181480 ^ 1883290291;
              continue;
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
        int num1 = 1439611372;
        while (true)
        {
          int num2 = 839872533;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              ZoomZoom.Properties.Settings.Default.MinimumUserCount = value;
              num1 = (int) num3 * -590393334 ^ -1355114497;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2286515375U));
      }
    }

    public bool MinimumUserEnforced
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.MinimumUserEnforced;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.MinimumUserEnforced = value;
label_1:
        int num1 = 974909213;
        while (true)
        {
          int num2 = 457385267;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1076524226U));
              num1 = (int) num3 * 1915494360 ^ -770632956;
              continue;
            case 1:
              num1 = (int) num3 * -821522758 ^ -2068087662;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -599228775 ^ 1369789960;
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

    public bool AutoOpenManyCamBroadcast
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.AutoOpenManyCamBroadcast;
      }
      set
      {
label_1:
        int num1 = -1726362021;
        while (true)
        {
          int num2 = -679037051;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 872045928 ^ -1842288954;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3360718080U));
              num1 = (int) num3 * 1897735607 ^ -472093685;
              continue;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 51296557 ^ -1441664259;
              continue;
            case 3:
              goto label_1;
            case 4:
              ZoomZoom.Properties.Settings.Default.AutoOpenManyCamBroadcast = value;
              num1 = (int) num3 * -1761084016 ^ -595647615;
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

    public bool DisplayHighlightWindows
    {
      get
      {
label_1:
        int num1 = -2082755458;
        bool highlightWindows;
        while (true)
        {
          int num2 = -958453572;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1558316276 ^ 981339327;
              continue;
            case 2:
              highlightWindows = ZoomZoom.Properties.Settings.Default.DisplayHighlightWindows;
              num1 = (int) num3 * -1843719027 ^ -64049705;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return highlightWindows;
      }
      set
      {
        bool flag = ZoomZoom.Properties.Settings.Default.DisplayHighlightWindows == value;
label_1:
        int num1 = 445541809;
        while (true)
        {
          int num2 = 1076454997;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              ZoomZoom.Properties.Settings.Default.DisplayHighlightWindows = value;
              num1 = 2140529860;
              continue;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -68248615 ^ -1370593441;
              continue;
            case 2:
              num1 = (int) num3 * 1435997520 ^ 461475075;
              continue;
            case 3:
              num1 = (int) num3 * 1458868870 ^ -1164045840;
              continue;
            case 4:
              int num4 = flag ? -2092950301 : (num4 = -1894281287);
              int num5 = (int) num3 * 783118259;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            case 7:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(648035430U));
              num1 = (int) num3 * -2027848530 ^ 68664769;
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

    public bool FloodEnabled
    {
      get
      {
label_1:
        int num1 = 113719767;
        bool floodEnabled;
        while (true)
        {
          int num2 = 965275451;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              floodEnabled = ZoomZoom.Properties.Settings.Default.FloodEnabled;
              num1 = (int) num3 * 75982428 ^ -1225966745;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return floodEnabled;
      }
      set
      {
label_1:
        int num1 = 484563523;
        while (true)
        {
          int num2 = 1091866252;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              ZoomZoom.Properties.Settings.Default.FloodEnabled = value;
              num1 = 771316103;
              continue;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 388444885 ^ -1651046578;
              continue;
            case 2:
              flag = ZoomZoom.Properties.Settings.Default.FloodEnabled == value;
              num1 = (int) num3 * 1191989810 ^ 307221399;
              continue;
            case 3:
              num1 = (int) num3 * -50221561 ^ -1083424327;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            case 6:
              num1 = (int) num3 * 512290381 ^ 1249276480;
              continue;
            case 7:
              int num4 = !flag ? 1487729958 : (num4 = 890731623);
              int num5 = (int) num3 * -1081726753;
              num1 = num4 ^ num5;
              continue;
            case 8:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(962143874U));
              num1 = (int) num3 * -1283101161 ^ -352943398;
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

    public bool RemoveUsersFlooding
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.RemoveUsersFlooding;
      }
      set
      {
label_1:
        int num1 = -708579428;
        while (true)
        {
          int num2 = -1670969768;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -833328308 ^ -1124529209;
              continue;
            case 1:
              num1 = (int) num3 * 855744510 ^ 792468894;
              continue;
            case 2:
              num1 = (int) num3 * 769112467 ^ 240309002;
              continue;
            case 3:
              int num4 = flag ? 1480343171 : (num4 = 361816454);
              int num5 = (int) num3 * -326966449;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3035434931U));
              num1 = (int) num3 * -1070871505 ^ 207048418;
              continue;
            case 5:
              ZoomZoom.Properties.Settings.Default.RemoveUsersFlooding = value;
              num1 = -1935603929;
              continue;
            case 6:
              goto label_1;
            case 7:
              num1 = (int) num3 * 498146237 ^ -943569110;
              continue;
            case 8:
              flag = ZoomZoom.Properties.Settings.Default.RemoveUsersFlooding == value;
              num1 = (int) num3 * 1939025271 ^ 33652967;
              continue;
            case 9:
              num1 = (int) num3 * 1349371456 ^ 1121167208;
              continue;
            case 10:
              goto label_3;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_3:;
      }
    }

    public bool AutoResponderEnabled
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.AutoResponderEnabled;
      }
      set
      {
label_1:
        int num1 = 1641278615;
        while (true)
        {
          int num2 = 490504085;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -356613757 ^ -122652627;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.AutoResponderEnabled = value;
              num1 = 301909339;
              continue;
            case 2:
              flag = ZoomZoom.Properties.Settings.Default.AutoResponderEnabled == value;
              num1 = (int) num3 * -186466259 ^ 2073237203;
              continue;
            case 3:
              num1 = (int) num3 * 1728105906 ^ -1842561532;
              continue;
            case 4:
              num1 = (int) num3 * -1013733050 ^ -1422599448;
              continue;
            case 5:
              goto label_3;
            case 6:
              goto label_1;
            case 7:
              num1 = (int) num3 * 392206881 ^ 1982014859;
              continue;
            case 8:
              int num4 = !flag ? -217049848 : (num4 = -330353781);
              int num5 = (int) num3 * 225437312;
              num1 = num4 ^ num5;
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

    public bool WarEnabled
    {
      get
      {
        bool warEnabled = ZoomZoom.Properties.Settings.Default.WarEnabled;
label_1:
        int num1 = -1055880806;
        while (true)
        {
          int num2 = -1037270656;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -973816755 ^ 1996206792;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return warEnabled;
      }
      set
      {
        bool flag = ZoomZoom.Properties.Settings.Default.WarEnabled == value;
label_1:
        int num1 = -2029602465;
        while (true)
        {
          int num2 = -937602341;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -2068409870 ^ 607644192;
              continue;
            case 2:
              int num4 = flag ? 145054896 : (num4 = 1706544953);
              int num5 = (int) num3 * 1571261867;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 1867008239 ^ -1625929985;
              continue;
            case 4:
              ZoomZoom.Properties.Settings.Default.WarEnabled = value;
              num1 = -1714139336;
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

    public string AutoResponderMessage
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.AutoResponderMessage;
      }
      set
      {
label_1:
        int num1 = 1229815718;
        while (true)
        {
          int num2 = 1491878375;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              flag = Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(ZoomZoom.Properties.Settings.Default.AutoResponderMessage, value);
              num1 = (int) num3 * -1069961035 ^ -1127035808;
              continue;
            case 2:
              int num4 = flag ? -905087570 : (num4 = -2104732672);
              int num5 = (int) num3 * -2131799507;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * -1655072265 ^ -427363126;
              continue;
            case 4:
              num1 = (int) num3 * -245596242 ^ 270970023;
              continue;
            case 5:
              ZoomZoom.Properties.Settings.Default.AutoResponderMessage = value;
              num1 = 448878217;
              continue;
            case 6:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1931583145 ^ -1958821947;
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

    public bool AutoRespondBlockedUser
    {
      get
      {
label_1:
        int num1 = 420068329;
        bool respondBlockedUser;
        while (true)
        {
          int num2 = 207053975;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1548178340 ^ 1716209507;
              continue;
            case 2:
              respondBlockedUser = ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUser;
              num1 = (int) num3 * -1855826028 ^ -59011838;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return respondBlockedUser;
      }
      set
      {
label_1:
        int num1 = 105368210;
        while (true)
        {
          int num2 = 781662463;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUser = value;
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = 2147391337;
              continue;
            case 3:
              num1 = (int) num3 * 1380803482 ^ 2076601263;
              continue;
            case 4:
              int num4 = ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUser != value ? -1959483556 : (num4 = -1329604120);
              int num5 = (int) num3 * 464219864;
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

    public string AutoRespondBlockedUserList
    {
      get
      {
        string respondBlockedUserList = ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUserList;
label_1:
        int num1 = 54893192;
        while (true)
        {
          int num2 = 938643100;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1022135679 ^ -232400577;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return respondBlockedUserList;
      }
      set
      {
        if (!Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUserList, value))
          goto label_6;
label_1:
        int num1 = -641690672;
label_2:
        while (true)
        {
          int num2 = -1960425670;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_6;
            case 2:
              num1 = (int) num3 * 1049900487 ^ 2073655427;
              continue;
            case 3:
              goto label_3;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1169902139 ^ 573265315;
              continue;
            case 5:
              num1 = (int) num3 * -1776904147 ^ 173059719;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:
        return;
label_6:
        ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUserList = Settings.\u202B⁫‫‪⁭⁮‮‮⁭‏‍⁬​⁮‎⁫⁭⁬⁬‏​‍‭‍‫‍‏⁯‌​‎​‬⁫‮⁮⁯‭‎‪‮(value);
        num1 = -1762966427;
        goto label_2;
      }
    }

    public string AutoRespondBlockedUserMessage
    {
      get
      {
        string blockedUserMessage = ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUserMessage;
label_1:
        int num1 = 1481010693;
        while (true)
        {
          int num2 = 1633579215;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1375640209 ^ -314778778;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return blockedUserMessage;
      }
      set
      {
        bool flag = Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUserMessage, value);
label_1:
        int num1 = -1960185033;
        while (true)
        {
          int num2 = -186699183;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -2087134868 ^ -1073564427;
              continue;
            case 1:
              num1 = (int) num3 * 1768679414 ^ 1290421725;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 1851165169 ^ 1894042376;
              continue;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -943435536 ^ 931597248;
              continue;
            case 5:
              ZoomZoom.Properties.Settings.Default.AutoRespondBlockedUserMessage = value;
              num1 = -1865864703;
              continue;
            case 6:
              int num4 = flag ? -1364640340 : (num4 = -195713598);
              int num5 = (int) num3 * -527794307;
              num1 = num4 ^ num5;
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

    public bool AutoLayoutsDefaultStretchingEnabled
    {
      get
      {
        bool stretchingEnabled = ZoomZoom.Properties.Settings.Default.AutoLayoutsDefaultStretchingEnabled;
label_1:
        int num1 = -799364537;
        while (true)
        {
          int num2 = -1503808139;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1978514846 ^ 1522899148;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return stretchingEnabled;
      }
      set
      {
label_1:
        int num1 = 893585019;
        while (true)
        {
          int num2 = 860227219;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              int num4 = flag ? -1275109247 : (num4 = -1779351463);
              int num5 = (int) num3 * 275795639;
              num1 = num4 ^ num5;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1472136570U));
              num1 = (int) num3 * 1881385243 ^ 220972163;
              continue;
            case 2:
              ZoomZoom.Properties.Settings.Default.AutoLayoutsDefaultStretchingEnabled = value;
              num1 = 2001183128;
              continue;
            case 3:
              goto label_1;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1808646297 ^ -401782036;
              continue;
            case 5:
              num1 = (int) num3 * -1220888368 ^ -1898123366;
              continue;
            case 6:
              num1 = (int) num3 * 853479103 ^ 1442038228;
              continue;
            case 7:
              num1 = (int) num3 * 271939878 ^ 1091204173;
              continue;
            case 8:
              flag = ZoomZoom.Properties.Settings.Default.AutoLayoutsDefaultStretchingEnabled == value;
              num1 = (int) num3 * -955722594 ^ 1674721745;
              continue;
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

    public bool ActivitiesEnabled
    {
      get
      {
label_1:
        int num1 = -1912716282;
        bool activitiesEnabled;
        while (true)
        {
          int num2 = -981424499;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -562404867 ^ -1246859464;
              continue;
            case 2:
              goto label_1;
            case 3:
              activitiesEnabled = ZoomZoom.Properties.Settings.Default.ActivitiesEnabled;
              num1 = (int) num3 * -536557403 ^ -949271274;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activitiesEnabled;
      }
      set
      {
label_1:
        int num1 = 1977923287;
        while (true)
        {
          int num2 = 38125293;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1349704082 ^ 851718515;
              continue;
            case 2:
              flag = ZoomZoom.Properties.Settings.Default.ActivitiesEnabled == value;
              num1 = (int) num3 * 1108256490 ^ 1305769510;
              continue;
            case 3:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 157367171 ^ -83399006;
              continue;
            case 4:
              goto label_3;
            case 5:
              ZoomZoom.Properties.Settings.Default.ActivitiesEnabled = value;
              num1 = 766381606;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(491677280U));
              num1 = (int) num3 * -1659583506 ^ -2120736875;
              continue;
            case 7:
              int num4 = flag ? 160230986 : (num4 = 1746741198);
              int num5 = (int) num3 * 120896370;
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

    public List<string> Lineart
    {
      get
      {
        List<string> lineart = Settings.lineart;
label_1:
        int num1 = 752666609;
        while (true)
        {
          int num2 = 2007489365;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1597224689 ^ -1040906850;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return lineart;
      }
    }

    public string ZoomName
    {
      get
      {
label_1:
        int num1 = 348022939;
        string userName;
        while (true)
        {
          int num2 = 1819657341;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              this.GetZoomNames();
              num1 = (int) num3 * 201011505 ^ -1682449895;
              continue;
            case 1:
              num1 = (int) num3 * -657923348 ^ 556077389;
              continue;
            case 2:
              int num4 = !Settings.\u206C‫‎‌‏‮⁪‫‍‮‏‭⁬‭‪⁯‫‎‎‬‏‬‌‏⁯⁯‬‪⁬​​‮⁮‫⁪‎‮‪‏⁭‮(this.userName, string.Empty) ? -808984815 : (num4 = -179950256);
              int num5 = (int) num3 * 1992678747;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            case 4:
              userName = this.userName;
              num1 = 52665940;
              continue;
            case 6:
              num1 = (int) num3 * -1700856035 ^ -48752041;
              continue;
            case 7:
              num1 = (int) num3 * -1390371915 ^ -1706925605;
              continue;
            case 8:
              num1 = (int) num3 * 1983512572 ^ 1738081931;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return userName;
      }
      internal set
      {
        this.userName = value;
      }
    }

    public string PrimaryScreen
    {
      get
      {
label_1:
        int num1 = 146612257;
        string appPrimaryMonitor;
        while (true)
        {
          int num2 = 393419696;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              appPrimaryMonitor = ZoomZoom.Properties.Settings.Default._App_PrimaryMonitor;
              num1 = (int) num3 * -1008230311 ^ 1985160638;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1544853584 ^ 109891808;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return appPrimaryMonitor;
      }
      set
      {
label_1:
        int num1 = -788111829;
        object settingsLock;
        while (true)
        {
          int num2 = -1774953990;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              settingsLock = Settings.settingsLock;
              num1 = (int) num3 * 1352656211 ^ -218160066;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag1 = false;
        try
        {
          Settings.\u200E‌‎⁪⁬⁪⁪‮‍‬‭‮‫‪⁫⁯⁯‭‫⁮⁬‫⁬‌‫​‌​‍‏‫‍​​⁪⁪‌‬⁮⁬‮(settingsLock, ref flag1);
label_6:
          int num2 = -591583651;
          while (true)
          {
            int num3 = -1774953990;
            uint num4;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 11U)
            {
              case 0:
                this.Engine.ActivePattern.PrimaryMonitor = this.primaryScreen;
                num2 = (int) num4 * -1240880760 ^ -1601395711;
                continue;
              case 1:
                int num5 = !flag2 ? -347983825 : (num5 = -1575175450);
                int num6 = (int) num4 * -837412701;
                num2 = num5 ^ num6;
                continue;
              case 2:
                flag2 = this.Engine.ActivePattern != null;
                num2 = (int) num4 * -218470931 ^ 1573575667;
                continue;
              case 3:
                goto label_6;
              case 4:
                ZoomZoom.Properties.Settings.Default._App_PrimaryMonitor = value;
                num2 = (int) num4 * -893987852 ^ 1832730649;
                continue;
              case 5:
                Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
                num2 = (int) num4 * -918554286 ^ 907086402;
                continue;
              case 6:
                num2 = (int) num4 * -301301294 ^ 153386259;
                continue;
              case 7:
                num2 = (int) num4 * -223019734 ^ -684496152;
                continue;
              case 9:
                num2 = (int) num4 * -680398097 ^ 2020455647;
                continue;
              case 10:
                num2 = (int) num4 * 2063132438 ^ 599121051;
                continue;
              default:
                goto label_23;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_18:
            int num2 = -1400337336;
            while (true)
            {
              int num3 = -1774953990;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_18;
                case 1:
                  num2 = (int) num4 * -2101807315 ^ 1890114908;
                  continue;
                case 2:
                  Settings.\u206D‫⁪⁯⁬‍⁭⁫⁪⁬‪‬⁮⁯⁬⁬‮‍‍‎​⁯‮⁭‌‎⁪‏⁪‫⁭‬⁫‬​‮⁫​‪‫‮(settingsLock);
                  num2 = (int) num4 * -1148034062 ^ -1407453605;
                  continue;
                default:
                  goto label_22;
              }
            }
          }
label_22:;
        }
label_23:
        this.Engine.WindowManager.UpdateActiveWindows();
      }
    }

    public string SecondaryScreen
    {
      get
      {
        string secondaryMonitor = ZoomZoom.Properties.Settings.Default._App_SecondaryMonitor;
label_1:
        int num1 = 1054433779;
        while (true)
        {
          int num2 = 307590278;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 173743102 ^ 462375254;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return secondaryMonitor;
      }
      set
      {
label_1:
        int num1 = 994421933;
        object settingsLock;
        while (true)
        {
          int num2 = 1450950191;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_15;
            case 1:
              settingsLock = Settings.settingsLock;
              num1 = 1228761768;
              continue;
            case 2:
              goto label_1;
            case 4:
              int num4 = !Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(this.secondaryScreen, value) ? -1324857166 : (num4 = -909647680);
              int num5 = (int) num3 * 1738141553;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_5;
          }
        }
label_15:
        return;
label_5:
        bool flag = false;
        try
        {
          Settings.\u200E‌‎⁪⁬⁪⁪‮‍‬‭‮‫‪⁫⁯⁯‭‫⁮⁬‫⁬‌‫​‌​‍‏‫‍​​⁪⁪‌‬⁮⁬‮(settingsLock, ref flag);
          ZoomZoom.Properties.Settings.Default._App_SecondaryMonitor = value;
label_7:
          int num2 = 175632730;
          while (true)
          {
            int num3 = 1450950191;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 0:
                goto label_7;
              case 2:
                num2 = 349807342;
                continue;
              case 3:
                num2 = (int) num4 * -156312913 ^ -1251678360;
                continue;
              case 4:
                num2 = (int) num4 * -441024944 ^ 1649166601;
                continue;
              case 5:
                Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
                num2 = (int) num4 * -1048162096 ^ 84582744;
                continue;
              case 6:
                this.Engine.ActivePattern.SecondaryMonitor = this.secondaryScreen;
                num2 = (int) num4 * 560708168 ^ 1411097772;
                continue;
              case 7:
                int num5 = this.Engine.ActivePattern != null ? 1157566822 : (num5 = 89948360);
                int num6 = (int) num4 * 1898041467;
                num2 = num5 ^ num6;
                continue;
              default:
                goto label_21;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_17:
            int num2 = 1971059183;
            while (true)
            {
              int num3 = 1450950191;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_17;
                case 1:
                  Settings.\u206D‫⁪⁯⁬‍⁭⁫⁪⁬‪‬⁮⁯⁬⁬‮‍‍‎​⁯‮⁭‌‎⁪‏⁪‫⁭‬⁫‬​‮⁫​‪‫‮(settingsLock);
                  num2 = (int) num4 * -2034502031 ^ -617100658;
                  continue;
                default:
                  goto label_20;
              }
            }
          }
label_20:;
        }
label_21:
        this.Engine.WindowManager.UpdateActiveWindows();
      }
    }

    public bool ApplyLayoutPattern
    {
      get
      {
        bool applyLayoutPattern = ZoomZoom.Properties.Settings.Default.ApplyLayoutPattern;
label_1:
        int num1 = 1087850199;
        while (true)
        {
          int num2 = 772865050;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 481627137 ^ 1986757007;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return applyLayoutPattern;
      }
      set
      {
        if (ZoomZoom.Properties.Settings.Default.ApplyLayoutPattern != value)
          goto label_9;
label_1:
        int num1 = 2066865355;
label_2:
        while (true)
        {
          int num2 = 1191159857;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 463492119 ^ 2085438113;
              continue;
            case 2:
              num1 = (int) num3 * 722639137 ^ -1548446577;
              continue;
            case 3:
              goto label_9;
            case 4:
              goto label_3;
            case 5:
              this.Engine.WindowManager.UpdateActiveWindows();
              num1 = (int) num3 * 808430697 ^ 1811255000;
              continue;
            case 6:
              num1 = (int) num3 * -2081582696 ^ 586550352;
              continue;
            case 7:
              num1 = (int) num3 * -1110433042 ^ 1018181878;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:
        return;
label_9:
        ZoomZoom.Properties.Settings.Default.ApplyLayoutPattern = value;
        num1 = 243287551;
        goto label_2;
      }
    }

    public string LastMeetingId
    {
      get
      {
label_1:
        int num1 = 977806086;
        string lastActiveMeeting;
        while (true)
        {
          int num2 = 1644294151;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              lastActiveMeeting = ZoomZoom.Properties.Settings.Default.LastActiveMeeting;
              num1 = (int) num3 * -841131070 ^ 980424226;
              continue;
            case 3:
              num1 = (int) num3 * -1004831283 ^ -1903466054;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return lastActiveMeeting;
      }
      set
      {
label_1:
        int num1 = -552415587;
        while (true)
        {
          int num2 = -1475224540;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              ZoomZoom.Properties.Settings.Default.LastActiveMeeting = value;
              num1 = -1546746240;
              continue;
            case 1:
              flag = Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(ZoomZoom.Properties.Settings.Default.LastActiveMeeting, value);
              num1 = (int) num3 * -1369204037 ^ 317423973;
              continue;
            case 2:
              int num4 = flag ? -1881562953 : (num4 = -665444742);
              int num5 = (int) num3 * 1812394495;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * 1499839206 ^ 1548454059;
              continue;
            case 5:
              num1 = (int) num3 * 1373074133 ^ 607421550;
              continue;
            case 6:
              goto label_1;
            case 7:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1060716450 ^ 1594741069;
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

    public string VideoChatLinkMessageSource
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.VideoChatLinkMessageSource;
      }
      set
      {
label_1:
        int num1 = -630613993;
        while (true)
        {
          int num2 = -837524086;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 403749135 ^ 1277020960;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.VideoChatLinkMessageSource = value;
              num1 = (int) num3 * 1276134930 ^ -2107685948;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(243003813U));
      }
    }

    public string ChatSource
    {
      get
      {
label_1:
        int num1 = -1253120659;
        string chatSource;
        while (true)
        {
          int num2 = -1538609511;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              chatSource = ZoomZoom.Properties.Settings.Default.ChatSource;
              num1 = (int) num3 * -1126512649 ^ 486928279;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return chatSource;
      }
      set
      {
label_1:
        int num1 = -432812027;
        while (true)
        {
          int num2 = -271311152;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -1353078944 ^ 372485163;
              continue;
            case 1:
              num1 = (int) num3 * -1667991246 ^ -308784949;
              continue;
            case 2:
              goto label_1;
            case 3:
              ZoomZoom.Properties.Settings.Default.ChatSource = value;
              num1 = (int) num3 * -231770110 ^ -1298409506;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(438268440U));
              num1 = (int) num3 * 1394410870 ^ 1627187618;
              continue;
            case 6:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1887076661 ^ -1495058465;
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

    public List<MessageContent> Greetings
    {
      get
      {
label_1:
        int num1 = 1960379858;
        List<MessageContent> greetings;
        while (true)
        {
          int num2 = 53015337;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              greetings = Settings.greetings;
              num1 = (int) num3 * -1279270461 ^ -790764031;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return greetings;
      }
      set
      {
        Settings.greetings = value;
      }
    }

    public string Information
    {
      get
      {
label_1:
        int num1 = -1977456420;
        string str1;
        while (true)
        {
          int num2 = -649330919;
          uint num3;
          bool flag;
          Version version;
          string str2;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              str2 += string.Format(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3121916628U), (object) this.License.Licensee, (object) this.License.Node, (object) this.License.DateExpires.ToShortDateString());
              num1 = (int) num3 * -842099777 ^ 642235566;
              continue;
            case 1:
              num1 = (int) num3 * 1037036917 ^ 1073917136;
              continue;
            case 2:
              str1 = str2;
              num1 = -1001346445;
              continue;
            case 4:
              num1 = (int) num3 * -1378483654 ^ 1790464534;
              continue;
            case 5:
              num1 = (int) num3 * -1197748625 ^ -197987979;
              continue;
            case 6:
              int num4 = flag ? -301711773 : (num4 = -1988612060);
              int num5 = (int) num3 * -112553807;
              num1 = num4 ^ num5;
              continue;
            case 7:
              goto label_1;
            case 8:
              str2 = string.Empty;
              version = Settings.\u202A‫‍⁫‏‎⁯‪‌⁬‬⁬‌‬‭⁪​‎⁫⁭⁮‍‌⁪‏​‌‭‪‫‎⁫⁫⁮​‭‮‎⁬‪‮(Settings.\u206D‏‌⁭⁫‍⁬‫‍‭⁭‍‍‎‮⁮‌⁭‌⁭‮‮⁪‮‍​‎​‌‪‪⁫⁭⁮‫‪‪‏‎⁭‮((object) Settings.\u206F‍‬‬​⁬‍‌‏‌‏‫⁫‮‭⁯‮​‫‭​‎⁯‬⁮‮‌⁬‍‮‭‏⁯⁫⁬‎⁫⁭⁯‬‮(Settings.\u206B‬​‪‏‮‭‮‪⁪⁬‌‏‭⁪‌⁯‫‍​‌⁫‮⁪⁭‍‪‌‌⁪‎‍‏‫‭⁬‫‌‎‫‮(Settings.\u200D‍‭‎‫‪‌⁭‌⁭‍‏‫​‍‪⁭‮​‪⁯‫‏⁯‎‫‪⁪⁪‮⁭‍‎‫​‌⁮‏‏⁭‮(Settings.\u206E‏⁬‮⁫‎‪‫⁮‌​⁭⁮⁫⁭‫‏‌​‭⁯⁬‪‭‭⁬⁯⁪⁫‭⁮​⁪‏‎​‎‍​‬‮())))));
              num1 = (int) num3 * 1930030600 ^ 29049574;
              continue;
            case 9:
              str2 = Settings.\u206D‏‌⁭⁫‍⁬‫‍‭⁭‍‍‎‮⁮‌⁭‌⁭‮‮⁪‮‍​‎​‌‪‪⁫⁭⁮‫‪‪‏‎⁭‮((object) version);
              num1 = (int) num3 * -2071170681 ^ -1537797596;
              continue;
            case 10:
              str2 = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(str2, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(163026150U));
              flag = this.License != null;
              num1 = (int) num3 * 82312192 ^ 539281281;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return str1;
      }
    }

    public bool SendGreetingAfterJoin
    {
      get
      {
label_1:
        int num1 = 890633721;
        bool greetingAfterJoin;
        while (true)
        {
          int num2 = 1931919143;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              greetingAfterJoin = ZoomZoom.Properties.Settings.Default.SendGreetingAfterJoin;
              num1 = (int) num3 * -1357261465 ^ 536239809;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return greetingAfterJoin;
      }
      set
      {
label_1:
        int num1 = 843236269;
        while (true)
        {
          int num2 = 1078556060;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              int num4 = !flag ? -2117167573 : (num4 = -1331723455);
              int num5 = (int) num3 * 1933684533;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag = ZoomZoom.Properties.Settings.Default.SendGreetingAfterJoin == value;
              num1 = (int) num3 * -1807133958 ^ 881841838;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1751182693 ^ -1878461039;
              continue;
            case 4:
              goto label_3;
            case 5:
              num1 = (int) num3 * 1184659001 ^ 469143013;
              continue;
            case 6:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1792498956 ^ -345995153;
              continue;
            case 7:
              ZoomZoom.Properties.Settings.Default.SendGreetingAfterJoin = value;
              num1 = 2062483154;
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

    public bool FloodAfterJoin
    {
      get
      {
label_1:
        int num1 = 2062553534;
        bool floodAfterJoin;
        while (true)
        {
          int num2 = 623766292;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              floodAfterJoin = ZoomZoom.Properties.Settings.Default.FloodAfterJoin;
              num1 = (int) num3 * -656744031 ^ 1248385821;
              continue;
            case 3:
              num1 = (int) num3 * -517287011 ^ 1137657994;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return floodAfterJoin;
      }
      set
      {
label_1:
        int num1 = -879512606;
        while (true)
        {
          int num2 = -677555322;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -1615239173 ^ 497660869;
              continue;
            case 1:
              num1 = (int) num3 * 219527596 ^ 174112509;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              flag = ZoomZoom.Properties.Settings.Default.FloodAfterJoin == value;
              num1 = (int) num3 * -712834092 ^ -217774248;
              continue;
            case 5:
              ZoomZoom.Properties.Settings.Default.FloodAfterJoin = value;
              num1 = -1002965201;
              continue;
            case 6:
              int num4 = !flag ? 1679741391 : (num4 = 1969014330);
              int num5 = (int) num3 * 2107084042;
              num1 = num4 ^ num5;
              continue;
            case 7:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -88108539 ^ -1886057978;
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

    public bool FloodPrivatelyAfterJoin
    {
      get
      {
label_1:
        int num1 = 160730237;
        bool privatelyAfterJoin;
        while (true)
        {
          int num2 = 1201848167;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              privatelyAfterJoin = ZoomZoom.Properties.Settings.Default.FloodPrivatelyAfterJoin;
              num1 = (int) num3 * -2059544026 ^ 420812387;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return privatelyAfterJoin;
      }
      set
      {
label_1:
        int num1 = 1476852174;
        while (true)
        {
          int num2 = 78376600;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1911414404 ^ -79367233;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -406595940 ^ -2035780596;
              continue;
            case 4:
              int num4 = !flag ? -500351385 : (num4 = -13007659);
              int num5 = (int) num3 * 1554988698;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 103877460 ^ -510438020;
              continue;
            case 6:
              flag = ZoomZoom.Properties.Settings.Default.FloodPrivatelyAfterJoin == value;
              num1 = (int) num3 * -657846162 ^ -983513912;
              continue;
            case 7:
              ZoomZoom.Properties.Settings.Default.FloodPrivatelyAfterJoin = value;
              num1 = 1397381369;
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

    public double MaximumAttendenceDuration
    {
      get
      {
        double attendenceMaxDuration = ZoomZoom.Properties.Settings.Default.AutoAttendenceMaxDuration;
label_1:
        int num1 = 539773374;
        while (true)
        {
          int num2 = 1271918641;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 111915314 ^ -518457870;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return attendenceMaxDuration;
      }
      set
      {
        if (ZoomZoom.Properties.Settings.Default.AutoAttendenceMaxDuration != value)
          goto label_5;
label_1:
        int num1 = -2090843375;
label_2:
        while (true)
        {
          int num2 = -559374457;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_5;
            case 2:
              num1 = (int) num3 * 1116862078 ^ 373168492;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:
        return;
label_5:
        ZoomZoom.Properties.Settings.Default.AutoAttendenceMaxDuration = value;
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
        num1 = -537613128;
        goto label_2;
      }
    }

    public bool AutoattendentMaximumDurationEnforced
    {
      get
      {
label_1:
        int num1 = 429786308;
        bool durationEnforced;
        while (true)
        {
          int num2 = 1720690138;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              durationEnforced = ZoomZoom.Properties.Settings.Default.AutoattendentMaximumDurationEnforced;
              num1 = (int) num3 * -1608483675 ^ 473719495;
              continue;
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
        int num1 = -1215105785;
        while (true)
        {
          int num2 = -1996768648;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * -889284144 ^ 837137807;
              continue;
            case 1:
              num1 = (int) num3 * -843746412 ^ -1885710495;
              continue;
            case 2:
              num1 = (int) num3 * -1098069016 ^ -2133093207;
              continue;
            case 3:
              goto label_3;
            case 4:
              ZoomZoom.Properties.Settings.Default.AutoattendentMaximumDurationEnforced = value;
              num1 = -1423413794;
              continue;
            case 5:
              goto label_1;
            case 6:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -66003495 ^ -1805077233;
              continue;
            case 7:
              int num4 = flag ? -1718392813 : (num4 = -400804821);
              int num5 = (int) num3 * 2114090539;
              num1 = num4 ^ num5;
              continue;
            case 8:
              flag = ZoomZoom.Properties.Settings.Default.AutoattendentMaximumDurationEnforced == value;
              num1 = (int) num3 * -1975437768 ^ 115630526;
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

    public static string ExceptionFile
    {
      get
      {
label_1:
        int num1 = 64668229;
        string str;
        while (true)
        {
          int num2 = 655406664;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1194818140 ^ -1300241990;
              continue;
            case 1:
              str = Settings.\u200B​⁫‌‏‪⁭⁭⁯‮⁬⁯‏⁪⁪‫‌‫‎‭‫‪‭⁭⁫‬⁭‬‌‍‫‍‌‎‮​⁭⁪‍‎‮(Settings.\u202B‭‪⁭‪‍‭⁯‏‬⁫‍⁪‬⁮⁯‫⁮‎‭‫‍‫⁪‪​⁬‍‏⁫⁪‏​⁪⁫‎‎⁫⁭‌‮(), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3959821256U));
              num1 = (int) num3 * 1100494874 ^ 1140761918;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return str;
      }
    }

    public bool OpenManyCamBroadCast
    {
      get
      {
label_1:
        int num1 = -1996716434;
        bool manyCamBroadCast;
        while (true)
        {
          int num2 = -1553297026;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              manyCamBroadCast = ZoomZoom.Properties.Settings.Default.OpenManyCamBroadCast;
              num1 = (int) num3 * 1631164601 ^ 1431212619;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return manyCamBroadCast;
      }
      internal set
      {
        ZoomZoom.Properties.Settings.Default.OpenManyCamBroadCast = value;
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
      }
    }

    public bool StartVideoAfterJoining
    {
      get
      {
label_1:
        int num1 = 208070497;
        bool videoAfterJoining;
        while (true)
        {
          int num2 = 1096281135;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              videoAfterJoining = ZoomZoom.Properties.Settings.Default.StartVideoAfterJoining;
              num1 = (int) num3 * 1927975196 ^ 1775316866;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return videoAfterJoining;
      }
      internal set
      {
label_1:
        int num1 = 947486440;
        while (true)
        {
          int num2 = 861507431;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              ZoomZoom.Properties.Settings.Default.StartVideoAfterJoining = value;
              num1 = (int) num3 * -689186444 ^ 1507700638;
              continue;
            case 2:
              num1 = (int) num3 * 712666274 ^ -712867298;
              continue;
            case 3:
              num1 = (int) num3 * 532669732 ^ -346594521;
              continue;
            case 4:
              this.StopVideoAfterJoining = false;
              num1 = (int) num3 * -476220975 ^ -914862573;
              continue;
            case 5:
              int num4 = !value ? -91297017 : (num4 = -1331871795);
              int num5 = (int) num3 * -1832287208;
              num1 = num4 ^ num5;
              continue;
            case 6:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1546230714 ^ -1726417446;
              continue;
            case 7:
              num1 = (int) num3 * 1821176546 ^ -1895855779;
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

    public bool StopVideoAfterJoining
    {
      get
      {
label_1:
        int num1 = -1774773906;
        bool videoAfterJoining;
        while (true)
        {
          int num2 = -123922654;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              videoAfterJoining = ZoomZoom.Properties.Settings.Default.StopVideoAfterJoining;
              num1 = (int) num3 * 1207621873 ^ 1971401007;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return videoAfterJoining;
      }
      internal set
      {
        ZoomZoom.Properties.Settings.Default.StopVideoAfterJoining = value;
label_1:
        int num1 = 252170326;
        while (true)
        {
          int num2 = 512611965;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              int num4 = !flag ? 749315919 : (num4 = 1932938892);
              int num5 = (int) num3 * 1977845778;
              num1 = num4 ^ num5;
              continue;
            case 1:
              this.StartVideoAfterJoining = false;
              num1 = (int) num3 * 1961774482 ^ 1226174819;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * -1175569438 ^ 532657669;
              continue;
            case 4:
              num1 = (int) num3 * 2091818298 ^ 186865623;
              continue;
            case 5:
              flag = value;
              num1 = (int) num3 * 1727447873 ^ 1379540136;
              continue;
            case 6:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 149418092 ^ 1613744304;
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

    public bool OpenManyCamBroadcastWhenNotOpen
    {
      get
      {
label_1:
        int num1 = 1683157736;
        bool broadcastWhenNotOpen;
        while (true)
        {
          int num2 = 1410838061;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 991486025 ^ -705143650;
              continue;
            case 1:
              broadcastWhenNotOpen = ZoomZoom.Properties.Settings.Default.OpenManyCamBroadcastWhenNotOpen;
              num1 = (int) num3 * 745592074 ^ 355641763;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return broadcastWhenNotOpen;
      }
      internal set
      {
label_1:
        int num1 = -1462777603;
        while (true)
        {
          int num2 = -1054212141;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              ZoomZoom.Properties.Settings.Default.OpenManyCamBroadcastWhenNotOpen = value;
              num1 = (int) num3 * 1578724196 ^ 1293381674;
              continue;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 156269231 ^ -1047428818;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -18137088 ^ -1608166642;
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

    public bool OpenManyCamWhenNotOpen
    {
      get
      {
        bool manyCamWhenNotOpen = ZoomZoom.Properties.Settings.Default.OpenManyCamWhenNotOpen;
label_1:
        int num1 = -1254799148;
        while (true)
        {
          int num2 = -1052149711;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 17628806 ^ -900563487;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return manyCamWhenNotOpen;
      }
      internal set
      {
        ZoomZoom.Properties.Settings.Default.OpenManyCamWhenNotOpen = value;
label_1:
        int num1 = -2078840087;
        while (true)
        {
          int num2 = -1407575426;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 253108508 ^ 861286921;
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

    public LayoutPattern FloodEnforcedPattern
    {
      get
      {
label_1:
        int num1 = 27905381;
        LayoutPattern layoutPattern;
        while (true)
        {
          int num2 = 1370256339;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1621074917 ^ 942170017;
              continue;
            case 2:
              layoutPattern = (LayoutPattern) Enumerable.FirstOrDefault<LayoutPattern>((IEnumerable<M0>) this.Engine.Patterns, (Func<M0, bool>) (Settings.\u003C\u003Ec.\u003C\u003E9__259_0 ?? (Settings.\u003C\u003Ec.\u003C\u003E9__259_0 = new Func<LayoutPattern, bool>((object) Settings.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003Cget_FloodEnforcedPattern\u003Eb__259_0)))));
              num1 = 1023796170;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return layoutPattern;
      }
      internal set
      {
        ZoomZoom.Properties.Settings.Default.FloodEnforcedPattern = value != null ? value.PatternName : string.Empty;
      }
    }

    public ObservableCollection<StringItem> MeetingAutoFindUsers
    {
      get
      {
label_1:
        int num1 = -260947643;
        ObservableCollection<StringItem> meetingAutoFindUsers;
        while (true)
        {
          int num2 = -1665831209;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              meetingAutoFindUsers = Settings.meetingAutoFindUsers;
              num1 = (int) num3 * 879115053 ^ 487264686;
              continue;
            case 3:
              num1 = (int) num3 * -1392738047 ^ 368791613;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingAutoFindUsers;
      }
      set
      {
label_1:
        int num1 = -496277990;
        string str;
        while (true)
        {
          int num2 = -969104246;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              Settings.meetingAutoFindUsers = value;
              str = "";
              num1 = (int) num3 * 1688999846 ^ -810782355;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        IEnumerator<StringItem> enumerator = ((Collection<StringItem>) Settings.meetingAutoFindUsers).GetEnumerator();
        try
        {
label_13:
          int num2 = !Settings.\u206B⁯‭‬‏⁫⁮‍‌‏⁪⁯‏⁯⁪‍‏‮⁭‭‪​⁫⁯‎⁯‫⁫⁮‎⁭‭‎‌⁬‌⁯⁯⁫⁪‮((IEnumerator) enumerator) ? -2094359743 : (num2 = -579183891);
          while (true)
          {
            int num3 = -969104246;
            uint num4;
            StringItem current;
            bool flag;
            switch ((num4 = (uint) (num2 ^ num3)) % 12U)
            {
              case 0:
                str = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1162138903U));
                num2 = (int) num4 * 1406927852 ^ -239954698;
                continue;
              case 1:
                int num5 = flag ? -894519099 : (num5 = -2100053468);
                int num6 = (int) num4 * -360542077;
                num2 = num5 ^ num6;
                continue;
              case 2:
                num2 = (int) num4 * -1274838788 ^ -170772636;
                continue;
              case 4:
                num2 = (int) num4 * -534882565 ^ -189723485;
                continue;
              case 5:
                str = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(str, current.Value);
                num2 = -514315251;
                continue;
              case 6:
                goto label_13;
              case 7:
                current = enumerator.Current;
                num2 = -1302980716;
                continue;
              case 8:
                num2 = (int) num4 * -910950343 ^ 699536066;
                continue;
              case 9:
                num2 = -579183891;
                continue;
              case 10:
                flag = !Settings.\u200C​‌‏⁬⁫‌‍​⁯⁭‬⁫⁬⁮‭‪‬‎⁭⁬‮‏‎⁭‎‎⁪​⁪‎‪⁯⁬‌⁫⁮⁫⁭‪‮(str);
                num2 = (int) num4 * -1899616413 ^ -1265512839;
                continue;
              case 11:
                num2 = (int) num4 * -131563525 ^ 920701153;
                continue;
              default:
                goto label_24;
            }
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_19:
            int num2 = -380907789;
            while (true)
            {
              int num3 = -969104246;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  Settings.\u200B‍‏‬⁭‌⁪‏‏⁮‎⁭‏‭‭‭‏‭‬‏‫​⁫‪⁬‍‪⁮‫‏⁬⁪‫‍‍‮‎‭⁭⁪‮((IDisposable) enumerator);
                  num2 = (int) num4 * -998137064 ^ 1761756349;
                  continue;
                case 2:
                  goto label_19;
                case 3:
                  num2 = (int) num4 * 1042838565 ^ -897370899;
                  continue;
                default:
                  goto label_23;
              }
            }
          }
label_23:;
        }
label_24:
        ZoomZoom.Properties.Settings.Default.MeetingAutoFindUsers = str;
label_25:
        int num7 = -1633547119;
        while (true)
        {
          int num2 = -969104246;
          uint num3;
          switch ((num3 = (uint) (num7 ^ num2)) % 4U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num7 = (int) num3 * 1837196393 ^ 1127225215;
              continue;
            case 2:
              goto label_25;
            case 3:
              num7 = (int) num3 * 635124196 ^ 235765750;
              continue;
            default:
              goto label_29;
          }
        }
label_29:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763423012U));
      }
    }

    public ObservableCollection<StringItem> JoinUserNames
    {
      get
      {
        ObservableCollection<StringItem> joinUserNames = Settings.joinUserNames;
label_1:
        int num1 = -47721350;
        while (true)
        {
          int num2 = -933487297;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 510177228 ^ -236847115;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return joinUserNames;
      }
      set
      {
        Settings.joinUserNames = value;
label_1:
        int num1 = 1571252671;
        string str;
        while (true)
        {
          int num2 = 1836445313;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              str = "";
              num1 = (int) num3 * -134072326 ^ 794817402;
              continue;
            case 3:
              num1 = (int) num3 * 644293529 ^ -936100589;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        IEnumerator<StringItem> enumerator = ((Collection<StringItem>) Settings.joinUserNames).GetEnumerator();
        try
        {
label_17:
          int num2 = !Settings.\u206B⁯‭‬‏⁫⁮‍‌‏⁪⁯‏⁯⁪‍‏‮⁭‭‪​⁫⁯‎⁯‫⁫⁮‎⁭‭‎‌⁬‌⁯⁯⁫⁪‮((IEnumerator) enumerator) ? 387535255 : (num2 = 2126431542);
          while (true)
          {
            int num3 = 1836445313;
            uint num4;
            StringItem current;
            bool flag;
            switch ((num4 = (uint) (num2 ^ num3)) % 11U)
            {
              case 0:
                num2 = (int) num4 * 883353192 ^ -1567588230;
                continue;
              case 1:
                current = enumerator.Current;
                num2 = 1551345534;
                continue;
              case 2:
                int num5 = flag ? 480748090 : (num5 = 744838470);
                int num6 = (int) num4 * -460354165;
                num2 = num5 ^ num6;
                continue;
              case 3:
                str = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(str, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(750811209U));
                num2 = (int) num4 * 437555993 ^ 1823306770;
                continue;
              case 4:
                num2 = 2126431542;
                continue;
              case 5:
                goto label_17;
              case 6:
                str = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(str, current.Value);
                num2 = 1699598218;
                continue;
              case 7:
                num2 = (int) num4 * -369331400 ^ -261426334;
                continue;
              case 8:
                num2 = (int) num4 * 1130230871 ^ -1584623192;
                continue;
              case 9:
                flag = !Settings.\u200C​‌‏⁬⁫‌‍​⁯⁭‬⁫⁬⁮‭‪‬‎⁭⁬‮‏‎⁭‎‎⁪​⁪‎‪⁯⁬‌⁫⁮⁫⁭‪‮(str);
                num2 = (int) num4 * -716966363 ^ 1231986858;
                continue;
              default:
                goto label_25;
            }
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_19:
            int num2 = 1131898640;
            while (true)
            {
              int num3 = 1836445313;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  num2 = (int) num4 * 695399089 ^ 1652455051;
                  continue;
                case 1:
                  Settings.\u200B‍‏‬⁭‌⁪‏‏⁮‎⁭‏‭‭‭‏‭‬‏‫​⁫‪⁬‍‪⁮‫‏⁬⁪‫‍‍‮‎‭⁭⁪‮((IDisposable) enumerator);
                  num2 = (int) num4 * 729676894 ^ -1579968657;
                  continue;
                case 3:
                  goto label_19;
                default:
                  goto label_24;
              }
            }
          }
label_24:;
        }
label_25:
        ZoomZoom.Properties.Settings.Default.JoinUserNames = str;
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
label_26:
        int num7 = 45510348;
        while (true)
        {
          int num2 = 1836445313;
          uint num3;
          switch ((num3 = (uint) (num7 ^ num2)) % 3U)
          {
            case 0:
              goto label_28;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4171419030U));
              num7 = (int) num3 * 1113522101 ^ -551486186;
              continue;
            case 2:
              goto label_26;
            default:
              goto label_21;
          }
        }
label_21:
        return;
label_28:;
      }
    }

    public long LastMeetingUri
    {
      get
      {
label_1:
        int num1 = 1373777502;
        long num2;
        while (true)
        {
          int num3 = 1585426575;
          uint num4;
          ZoomMeeting meeting;
          bool flag;
          switch ((num4 = (uint) (num1 ^ num3)) % 11U)
          {
            case 0:
              num2 = 0L;
              num1 = (int) num4 * 1130259677 ^ -1665673057;
              continue;
            case 1:
              num1 = (int) num4 * -1090863890 ^ 1201576134;
              continue;
            case 2:
              num1 = (int) num4 * -1619040276 ^ 553811229;
              continue;
            case 3:
              flag = meeting != null;
              num1 = (int) num4 * 320051818 ^ 130359854;
              continue;
            case 4:
              meeting = this.Engine.GetMeeting(this.LastMeetingId, false);
              num1 = (int) num4 * 3838157 ^ 1991812893;
              continue;
            case 6:
              goto label_1;
            case 7:
              num2 = meeting.Uri;
              num1 = (int) num4 * 1946910111 ^ 924640416;
              continue;
            case 8:
              num1 = 93052890;
              continue;
            case 9:
              int num5 = !flag ? 735802576 : (num5 = 1408777931);
              int num6 = (int) num4 * -127747809;
              num1 = num5 ^ num6;
              continue;
            case 10:
              num1 = (int) num4 * 1194780881 ^ 1651203781;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return num2;
      }
    }

    public bool HookEventsViaMessagePump
    {
      get
      {
        bool eventsViaMessagePump = ZoomZoom.Properties.Settings.Default.HookEventsViaMessagePump;
label_1:
        int num1 = 73498690;
        while (true)
        {
          int num2 = 737152254;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -442913536 ^ -576838196;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return eventsViaMessagePump;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.HookEventsViaMessagePump = value;
label_1:
        int num1 = 1935024033;
        while (true)
        {
          int num2 = 875078410;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 168541289 ^ 525164937;
              continue;
            case 2:
              num1 = (int) num3 * 949664748 ^ -809890151;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -546016087 ^ -997509249;
              continue;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3042446624U));
              num1 = (int) num3 * -1517002936 ^ -590526608;
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

    public int CaptureMeeting_PauseInterval
    {
      get
      {
label_1:
        int num1 = 843076858;
        int meetingPauseInterval;
        while (true)
        {
          int num2 = 1638630913;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1201793510 ^ 664933757;
              continue;
            case 3:
              meetingPauseInterval = ZoomZoom.Properties.Settings.Default.CaptureMeeting_PauseInterval;
              num1 = (int) num3 * 1005462536 ^ -618584952;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingPauseInterval;
      }
      set
      {
label_1:
        int num1 = 1221277669;
        while (true)
        {
          int num2 = 705749540;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2138987939U));
              num1 = (int) num3 * -2046573589 ^ -1732392720;
              continue;
            case 2:
              num1 = (int) num3 * -1397023497 ^ 374871275;
              continue;
            case 3:
              ZoomZoom.Properties.Settings.Default.CaptureMeeting_PauseInterval = value;
              num1 = (int) num3 * 618857139 ^ -13279344;
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

    public bool CaptureMeeting_AfterJoin
    {
      get
      {
        bool meetingAfterJoin = ZoomZoom.Properties.Settings.Default.CaptureMeeting_AfterJoin;
label_1:
        int num1 = -74972724;
        while (true)
        {
          int num2 = -982079872;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -416716968 ^ -1918140225;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingAfterJoin;
      }
      set
      {
label_1:
        int num1 = -1397475044;
        while (true)
        {
          int num2 = -1099029835;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1103955811 ^ 1632613609;
              continue;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -589086992 ^ -1528752371;
              continue;
            case 3:
              num1 = (int) num3 * -868673284 ^ 174815246;
              continue;
            case 4:
              goto label_1;
            case 5:
              ZoomZoom.Properties.Settings.Default.CaptureMeeting_AfterJoin = value;
              num1 = (int) num3 * 694518092 ^ -1342104296;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1957035513U));
      }
    }

    public bool CaptureMeeting_DisplayImagesWhenCompleted
    {
      get
      {
label_1:
        int num1 = -1984505662;
        bool imagesWhenCompleted;
        while (true)
        {
          int num2 = -44042675;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -927514605 ^ 647562888;
              continue;
            case 2:
              goto label_1;
            case 3:
              imagesWhenCompleted = ZoomZoom.Properties.Settings.Default.CaptureMeeting_DisplayImagesWhenCompleted;
              num1 = (int) num3 * -1690159671 ^ 952723406;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return imagesWhenCompleted;
      }
      set
      {
label_1:
        int num1 = -1174806485;
        while (true)
        {
          int num2 = -1891224800;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -757323671 ^ 1995945923;
              continue;
            case 3:
              ZoomZoom.Properties.Settings.Default.CaptureMeeting_DisplayImagesWhenCompleted = value;
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -873397297 ^ 1221024215;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1644514242U));
      }
    }

    public string FloodOptions_MessageCategory
    {
      get
      {
label_1:
        int num1 = 1318082185;
        string floodMessageCategory;
        while (true)
        {
          int num2 = 330464605;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              floodMessageCategory = ZoomZoom.Properties.Settings.Default.Flood_MessageCategory;
              num1 = (int) num3 * -1861720547 ^ -48538177;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return floodMessageCategory;
      }
      set
      {
label_1:
        int num1 = 1387278564;
        while (true)
        {
          int num2 = 899060572;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1206031469 ^ -2058147340;
              continue;
            case 2:
              goto label_3;
            case 3:
              ZoomZoom.Properties.Settings.Default.Flood_MessageCategory = value;
              num1 = (int) num3 * -432257286 ^ -1364167783;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3014610242U));
              num1 = (int) num3 * 1934534318 ^ -744024874;
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

    public string FloodOptions_MessageContent
    {
      get
      {
label_1:
        int num1 = -773008257;
        string str;
        while (true)
        {
          int num2 = -2061132732;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -743354610 ^ 91985596;
              continue;
            case 3:
              str = Settings.\u206B‮⁬‪⁪‎‫‎‍‍⁬‌‬⁬⁬‍⁬​⁫‬‫‬‭‍⁪‏‎‍⁪⁪⁭‫‬⁯⁫⁬‪⁭⁬⁭‮(Settings.\u206B‮⁬‪⁪‎‫‎‍‍⁬‌‬⁬⁬‍⁬​⁫‬‫‬‭‍⁪‏‎‍⁪⁪⁭‫‬⁯⁫⁬‪⁭⁬⁭‮(ZoomZoom.Properties.Settings.Default.FloodOptions_MessageContent, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(624824706U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2376480551U)), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2624673841U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1371093830U));
              num1 = (int) num3 * -2011993182 ^ -1235651341;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return str;
      }
      set
      {
label_1:
        int num1 = -331470716;
        while (true)
        {
          int num2 = -624909260;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(154358112U));
              num1 = (int) num3 * 382550521 ^ 1000727861;
              continue;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 351143299 ^ 15057999;
              continue;
            case 3:
              goto label_3;
            case 4:
              ZoomZoom.Properties.Settings.Default.FloodOptions_MessageContent = Settings.\u206B‮⁬‪⁪‎‫‎‍‍⁬‌‬⁬⁬‍⁬​⁫‬‫‬‭‍⁪‏‎‍⁪⁪⁭‫‬⁯⁫⁬‪⁭⁬⁭‮(Settings.\u206B‮⁬‪⁪‎‫‎‍‍⁬‌‬⁬⁬‍⁬​⁫‬‫‬‭‍⁪‏‎‍⁪⁪⁭‫‬⁯⁫⁬‪⁭⁬⁭‮(value, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1709284188U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(624824706U)), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1371093830U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3418797081U));
              num1 = (int) num3 * 1770714040 ^ -166891985;
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

    public bool PeekOptions_SuspendInitialMeetingActivities
    {
      get
      {
label_1:
        int num1 = 1160815314;
        bool meetingActivities;
        while (true)
        {
          int num2 = 620978039;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingActivities = ZoomZoom.Properties.Settings.Default.Peek_SuspendInitialMeetingActivities;
              num1 = (int) num3 * 396807966 ^ -312960326;
              continue;
            case 3:
              num1 = (int) num3 * 152540777 ^ 153599538;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingActivities;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.Peek_SuspendInitialMeetingActivities = value;
label_1:
        int num1 = -2071560951;
        while (true)
        {
          int num2 = -829788237;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 209290722 ^ -272603692;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2389094112U));
      }
    }

    public bool PeekOptions_UseSpecializedPattern
    {
      get
      {
label_1:
        int num1 = 1060097124;
        bool specializedPattern;
        while (true)
        {
          int num2 = 1144080797;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              specializedPattern = ZoomZoom.Properties.Settings.Default.Peek_UseSpecializedPattern;
              num1 = (int) num3 * -108338614 ^ -1455463068;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 68731719 ^ -1336504056;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return specializedPattern;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.Peek_UseSpecializedPattern = value;
label_1:
        int num1 = -1222510157;
        while (true)
        {
          int num2 = -1926343278;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1843805688 ^ -1437679347;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3876529337U));
              num1 = (int) num3 * -2136227288 ^ 678475522;
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

    public bool PeekOptions_MaximizeImageViewerAfterCapture
    {
      get
      {
label_1:
        int num1 = 226469674;
        bool viewerAfterCapture;
        while (true)
        {
          int num2 = 2099514944;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              viewerAfterCapture = ZoomZoom.Properties.Settings.Default.Peek_MaximizeImageViewerAfterCapture;
              num1 = (int) num3 * -1128989240 ^ 1398302723;
              continue;
            case 3:
              num1 = (int) num3 * -1572132433 ^ 1587178168;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return viewerAfterCapture;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.Peek_MaximizeImageViewerAfterCapture = value;
label_1:
        int num1 = -185892589;
        while (true)
        {
          int num2 = -331448407;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -476060345 ^ 681249313;
              continue;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2748407722U));
              num1 = (int) num3 * 1309751446 ^ 1286081004;
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
    }

    public bool PeekOptions_LeaveMeetingOnceCompleted
    {
      get
      {
label_1:
        int num1 = 670770035;
        bool meetingOnceCompleted;
        while (true)
        {
          int num2 = 1694101755;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              meetingOnceCompleted = ZoomZoom.Properties.Settings.Default.Peek_LeaveMeetingOnceCompleted;
              num1 = (int) num3 * -2140835781 ^ 681953489;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingOnceCompleted;
      }
      set
      {
label_1:
        int num1 = 1884004642;
        while (true)
        {
          int num2 = 252102282;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -172882779 ^ 105515107;
              continue;
            case 1:
              num1 = (int) num3 * 1550517112 ^ 1835121451;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(749597306U));
              num1 = (int) num3 * 691745802 ^ -1830551356;
              continue;
            case 4:
              ZoomZoom.Properties.Settings.Default.Peek_LeaveMeetingOnceCompleted = value;
              num1 = (int) num3 * 238650681 ^ -943928328;
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

    public bool DesktopAlert_Enabled
    {
      get
      {
label_1:
        int num1 = -532075754;
        bool desktopAlertEnabled;
        while (true)
        {
          int num2 = -1849675087;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              desktopAlertEnabled = ZoomZoom.Properties.Settings.Default.DesktopAlert_Enabled;
              num1 = (int) num3 * -657541423 ^ 1377789348;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return desktopAlertEnabled;
      }
      set
      {
label_1:
        int num1 = 590037122;
        while (true)
        {
          int num2 = 19582495;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              ZoomZoom.Properties.Settings.Default.DesktopAlert_Enabled = value;
              num1 = (int) num3 * 1918822875 ^ -1693720071;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1736167239U));
              num1 = (int) num3 * 1124746434 ^ -99756981;
              continue;
            case 3:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1992731411 ^ -613314265;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * -1635141318 ^ 1622739399;
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

    public bool DesktopAlert_ShowOnlyIfReceived
    {
      get
      {
        bool showOnlyIfReceived = ZoomZoom.Properties.Settings.Default.DesktopAlert_ShowOnlyIfReceived;
label_1:
        int num1 = 359533863;
        while (true)
        {
          int num2 = 1267623864;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1612663121 ^ -430203633;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return showOnlyIfReceived;
      }
      set
      {
label_1:
        int num1 = 642326832;
        while (true)
        {
          int num2 = 122826283;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1704711083U));
              num1 = (int) num3 * -130429172 ^ 105341231;
              continue;
            case 2:
              goto label_3;
            case 3:
              ZoomZoom.Properties.Settings.Default.DesktopAlert_ShowOnlyIfReceived = value;
              num1 = (int) num3 * -1199695964 ^ 721366912;
              continue;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -942701139 ^ -1405929456;
              continue;
            case 5:
              num1 = (int) num3 * -1912405404 ^ 1063084999;
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

    public string DesktopAlert_IgnoredUsers
    {
      get
      {
label_1:
        int num1 = 537128384;
        string alertIgnoredUsers;
        while (true)
        {
          int num2 = 943082011;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              alertIgnoredUsers = ZoomZoom.Properties.Settings.Default.DesktopAlert_IgnoredUsers;
              num1 = (int) num3 * 1163471078 ^ -1535610697;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return alertIgnoredUsers;
      }
      set
      {
label_1:
        int num1 = 383393840;
        while (true)
        {
          int num2 = 184329286;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4288413848U));
              num1 = (int) num3 * 1800388299 ^ -1953376151;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.DesktopAlert_IgnoredUsers = value;
              num1 = (int) num3 * -1805991890 ^ -1459057550;
              continue;
            case 2:
              num1 = (int) num3 * -1390213035 ^ 371326514;
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

    public string AdminRightClickAction
    {
      get
      {
label_1:
        int num1 = 72311518;
        string rightClickAction;
        while (true)
        {
          int num2 = 544086008;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1163152851 ^ 628687025;
              continue;
            case 2:
              rightClickAction = ZoomZoom.Properties.Settings.Default.AdminRightClickAction;
              num1 = (int) num3 * 1006956972 ^ -1918316411;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return rightClickAction;
      }
      set
      {
label_1:
        int num1 = 120390067;
        while (true)
        {
          int num2 = 638683965;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -1932431098 ^ -1553269908;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2205084320U));
              num1 = (int) num3 * -2083751905 ^ -1355798778;
              continue;
            case 2:
              goto label_3;
            case 3:
              ZoomZoom.Properties.Settings.Default.AdminRightClickAction = value;
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1076462413 ^ 998611094;
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
    }

    public bool ZoomZoomDockingEnabled
    {
      get
      {
        bool zoomDockingEnabled = ZoomZoom.Properties.Settings.Default.ZoomZoomDockingEnabled;
label_1:
        int num1 = -1392022401;
        while (true)
        {
          int num2 = -1593444931;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1558452534 ^ -1048545208;
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
        ZoomZoom.Properties.Settings.Default.ZoomZoomDockingEnabled = value;
label_1:
        int num1 = -1982336423;
        while (true)
        {
          int num2 = -922819479;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 170872113 ^ 820928121;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(926641317U));
              num1 = (int) num3 * -1427674147 ^ 836824803;
              continue;
            case 4:
              num1 = (int) num3 * 1108024005 ^ -1517602968;
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

    public bool DisplayedDockWindow
    {
      get
      {
label_1:
        int num1 = -1690432639;
        bool displayedDockWindow;
        while (true)
        {
          int num2 = -1060158444;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -116445355 ^ 328972146;
              continue;
            case 1:
              displayedDockWindow = ZoomZoom.Properties.Settings.Default.DisplayedDockWindow;
              num1 = (int) num3 * 1540948426 ^ 1214849306;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return displayedDockWindow;
      }
      set
      {
label_1:
        int num1 = -1096810984;
        while (true)
        {
          int num2 = -1818357247;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 2063159418 ^ -1271774006;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.DisplayedDockWindow = value;
              num1 = (int) num3 * -1244232022 ^ 1453969430;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1543605754U));
              num1 = (int) num3 * 338622380 ^ 382205451;
              continue;
            case 4:
              goto label_3;
            case 5:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 539547646 ^ -1417886145;
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

    public bool EngineView_DisplayQuickLinkBar
    {
      get
      {
label_1:
        int num1 = -212883967;
        bool displayQuickLinkBar;
        while (true)
        {
          int num2 = -236193230;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 2097870409 ^ -1248077815;
              continue;
            case 3:
              displayQuickLinkBar = ZoomZoom.Properties.Settings.Default.EngineView_DisplayQuickLinkBar;
              num1 = (int) num3 * -69624263 ^ -1392326965;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return displayQuickLinkBar;
      }
      set
      {
label_1:
        int num1 = -1437498751;
        while (true)
        {
          int num2 = -290904593;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 933458356 ^ 255268533;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3827799608U));
              num1 = (int) num3 * 2138231498 ^ -969624842;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -130937268 ^ 1083747727;
              continue;
            case 4:
              num1 = (int) num3 * 114728456 ^ -43878943;
              continue;
            case 5:
              ZoomZoom.Properties.Settings.Default.EngineView_DisplayQuickLinkBar = value;
              num1 = (int) num3 * 1528646916 ^ 1082551896;
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
    }

    public bool EngineView_DisplayMeetingBar
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.EngineView_DisplayMeetingBar;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.EngineView_DisplayMeetingBar = value;
label_1:
        int num1 = 402939204;
        while (true)
        {
          int num2 = 297537660;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2822412887U));
              num1 = (int) num3 * 1100792264 ^ -1357416369;
              continue;
            case 1:
              num1 = (int) num3 * 1321912216 ^ -551766398;
              continue;
            case 2:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -59234941 ^ -1845836911;
              continue;
            case 3:
              num1 = (int) num3 * -389862585 ^ -2017667842;
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

    public bool EngineView_DisplayChatBar
    {
      get
      {
        bool viewDisplayChatBar = ZoomZoom.Properties.Settings.Default.EngineView_DisplayChatBar;
label_1:
        int num1 = -1359495669;
        while (true)
        {
          int num2 = -570578651;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 688598455 ^ -1057039032;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return viewDisplayChatBar;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.EngineView_DisplayChatBar = value;
label_1:
        int num1 = 1507619533;
        while (true)
        {
          int num2 = 2012551691;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(293311301U));
              num1 = (int) num3 * 618184618 ^ 1536780738;
              continue;
            case 1:
              num1 = (int) num3 * -1548871560 ^ 718435581;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1809017313 ^ -800825502;
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

    public bool EngineView_DisplayActivityBar
    {
      get
      {
        bool displayActivityBar = ZoomZoom.Properties.Settings.Default.EngineView_DisplayActivityBar;
label_1:
        int num1 = 543980795;
        while (true)
        {
          int num2 = 498749542;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1743033591 ^ -1097933188;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return displayActivityBar;
      }
      set
      {
label_1:
        int num1 = -39028721;
        while (true)
        {
          int num2 = -1315451182;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 668644562 ^ -1826032411;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.EngineView_DisplayActivityBar = value;
              num1 = (int) num3 * -1375930880 ^ 28822716;
              continue;
            case 2:
              num1 = (int) num3 * 1662335805 ^ -492678896;
              continue;
            case 3:
              goto label_3;
            case 4:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3482975679U));
              num1 = (int) num3 * 1666033628 ^ 666290542;
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

    public bool EngineView_DisplayLayoutBar
    {
      get
      {
label_1:
        int num1 = -638746005;
        bool displayLayoutBar;
        while (true)
        {
          int num2 = -2061497932;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              displayLayoutBar = ZoomZoom.Properties.Settings.Default.EngineView_DisplayLayoutBar;
              num1 = (int) num3 * -1053870969 ^ -410649332;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return displayLayoutBar;
      }
      set
      {
label_1:
        int num1 = 300410583;
        while (true)
        {
          int num2 = 974607217;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1868127941 ^ -472005607;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 584901625 ^ 750980159;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4246283867U));
              num1 = (int) num3 * 1041189714 ^ 1981798386;
              continue;
            case 5:
              num1 = (int) num3 * -232959879 ^ -801278902;
              continue;
            case 6:
              ZoomZoom.Properties.Settings.Default.EngineView_DisplayLayoutBar = value;
              num1 = (int) num3 * -1654891547 ^ -1605590391;
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

    public bool EngineView_DisplaySettingsBar
    {
      get
      {
label_1:
        int num1 = 1143912422;
        bool displaySettingsBar;
        while (true)
        {
          int num2 = 1791540071;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              displaySettingsBar = ZoomZoom.Properties.Settings.Default.EngineView_DisplaySettingsBar;
              num1 = (int) num3 * -1074476644 ^ 1316259149;
              continue;
            case 2:
              num1 = (int) num3 * -25719957 ^ 1883207230;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return displaySettingsBar;
      }
      set
      {
label_1:
        int num1 = 874727328;
        while (true)
        {
          int num2 = 1745551780;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              ZoomZoom.Properties.Settings.Default.EngineView_DisplaySettingsBar = value;
              num1 = (int) num3 * 227570518 ^ -410105962;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1205697718 ^ -548641620;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2386510342U));
              num1 = (int) num3 * 318631666 ^ 276026038;
              continue;
            case 5:
              num1 = (int) num3 * 935330146 ^ -1635093899;
              continue;
            case 6:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -760405220 ^ -1177062589;
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

    public bool EngineView_DisplayImageBar
    {
      get
      {
label_1:
        int num1 = -290359768;
        bool viewDisplayImageBar;
        while (true)
        {
          int num2 = -906037163;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              viewDisplayImageBar = ZoomZoom.Properties.Settings.Default.EngineView_DisplayImageBar;
              num1 = (int) num3 * -1591682979 ^ 1188587583;
              continue;
            case 3:
              num1 = (int) num3 * 921553370 ^ -189396647;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return viewDisplayImageBar;
      }
      set
      {
label_1:
        int num1 = -1737560015;
        while (true)
        {
          int num2 = -703590748;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              ZoomZoom.Properties.Settings.Default.EngineView_DisplayImageBar = value;
              num1 = (int) num3 * -1291414963 ^ -850394586;
              continue;
            case 2:
              goto label_1;
            case 3:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(984151369U));
              num1 = (int) num3 * -1388570785 ^ -1416095535;
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

    public MessageContent DateTimeContent
    {
      get
      {
        MessageContent dateTimeContent = this.dateTimeContent;
label_1:
        int num1 = -392213765;
        while (true)
        {
          int num2 = -1518507352;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 2032740292 ^ -1740270825;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dateTimeContent;
      }
      set
      {
label_1:
        int num1 = 1338953755;
        while (true)
        {
          int num2 = 1305772714;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.dateTimeContent = value;
              num1 = (int) num3 * -1456896023 ^ -1087917319;
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

    public MessageContent GuidContent
    {
      get
      {
label_1:
        int num1 = 808623313;
        MessageContent guidContent;
        while (true)
        {
          int num2 = 475788276;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              guidContent = this.guidContent;
              num1 = (int) num3 * -1843094334 ^ -1604848864;
              continue;
            case 2:
              num1 = (int) num3 * 2057721170 ^ -1752081373;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return guidContent;
      }
      set
      {
label_1:
        int num1 = -303778641;
        while (true)
        {
          int num2 = -1789426531;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.guidContent = value;
              num1 = (int) num3 * -357645374 ^ -955596893;
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

    public MessageContent RandomTextContent
    {
      get
      {
label_1:
        int num1 = 1022826208;
        MessageContent randomTextContent;
        while (true)
        {
          int num2 = 60810293;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1170094506 ^ -1930137701;
              continue;
            case 1:
              randomTextContent = this.randomTextContent;
              num1 = (int) num3 * 1507298635 ^ 1735896410;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return randomTextContent;
      }
      set
      {
        this.randomTextContent = value;
      }
    }

    public MessageContent PreviousChatContent
    {
      get
      {
        return this.previousChatContent;
      }
      set
      {
        this.previousChatContent = value;
      }
    }

    public MessageCategory StaticCategory_AutoGenerated
    {
      get
      {
        MessageCategory staticCategory = this.staticCategory;
label_1:
        int num1 = 1683050648;
        while (true)
        {
          int num2 = 1293112029;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 586749684 ^ 1974264751;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return staticCategory;
      }
      set
      {
        this.staticCategory = value;
      }
    }

    public bool FloodHostAfterJoin
    {
      get
      {
label_1:
        int num1 = 630763475;
        bool floodHostAfterJoin;
        while (true)
        {
          int num2 = 752664222;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              floodHostAfterJoin = ZoomZoom.Properties.Settings.Default.FloodHostAfterJoin;
              num1 = (int) num3 * 344161402 ^ 97162895;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1851636735 ^ 601438797;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return floodHostAfterJoin;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.FloodHostAfterJoin = value;
label_1:
        int num1 = 1827198346;
        while (true)
        {
          int num2 = 1182177677;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3516538513U));
              num1 = (int) num3 * -1447975264 ^ 1607516672;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1547968995 ^ 35843718;
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

    public bool FloodTargetsAfterJoin
    {
      get
      {
        return ZoomZoom.Properties.Settings.Default.FloodTargetsAfterJoin;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.FloodTargetsAfterJoin = value;
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
label_1:
        int num1 = -100623271;
        while (true)
        {
          int num2 = -9973762;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1505765071U));
              num1 = (int) num3 * -1080424953 ^ -1470395416;
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

    public List<string> FloodTargets
    {
      get
      {
label_1:
        int num1 = -836240756;
        List<string> list;
        while (true)
        {
          int num2 = -640530957;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1834687083 ^ 989727732;
              continue;
            case 3:
              list = ((IEnumerable<string>) Settings.\u206C‫‭‭‪⁪⁭‫‬⁯‌⁪‭‪‮‪‮⁭‫‬⁭⁯⁮‎‌⁪⁪‎‍⁮‫‮⁭‬‭‍⁮⁯⁫⁫‮(ZoomZoom.Properties.Settings.Default.FloodTargets, new char[1]
              {
                '|'
              })).ToList<string>();
              num1 = (int) num3 * 900953216 ^ 301700881;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return list;
      }
      set
      {
label_1:
        int num1 = 411480354;
        while (true)
        {
          int num2 = 1285240790;
          uint num3;
          string flatten;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 216425492 ^ 842551466;
              continue;
            case 1:
              flatten = "";
              value.ForEach((Action<string>) (o => flatten = Settings.\u003C\u003Ec__DisplayClass364_0.\u200D‌​⁬‏‎⁪‎‎⁪‎⁭⁮⁪‏‮​‫‍‌‎⁬​‬‫⁫‫⁭‌‎‪​⁭⁭‌‍‪⁬‎⁫‮(flatten, Settings.\u003C\u003Ec__DisplayClass364_0.\u206B⁬⁭‬⁬‍‪‭‏‫‏‏‪‬‍⁪‮⁪‌‭‬‏⁫‏‪‍‬‬⁭⁬⁮‫‏‫​​‬⁬‍‮‮(flatten, "") ? "" : Settings.\u003C\u003Ec__DisplayClass364_0.\u200D‌​⁬‏‎⁪‎‎⁪‎⁭⁮⁪‏‮​‫‍‌‎⁬​‬‫⁫‫⁭‌‎‪​⁭⁭‌‍‪⁬‎⁫‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1683746435U), o))));
              num1 = (int) num3 * 1291100207 ^ -147140686;
              continue;
            case 3:
              ZoomZoom.Properties.Settings.Default.FloodTargets = flatten;
              num1 = (int) num3 * 652193780 ^ -751680244;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2696711573U));
      }
    }

    public string ForceMeeting
    {
      get
      {
        string forceMeeting = ZoomZoom.Properties.Settings.Default.ForceMeeting;
label_1:
        int num1 = 421256996;
        while (true)
        {
          int num2 = 1376767572;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 2110363939 ^ -832261398;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return forceMeeting;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.ForceMeeting = value;
label_1:
        int num1 = -1503568401;
        while (true)
        {
          int num2 = -1619795700;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1435234880U));
              num1 = (int) num3 * 1967883816 ^ 1413863641;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1480031154 ^ -62815902;
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

    public string FloodTargetNames
    {
      get
      {
label_1:
        int num1 = -1131021925;
        string floodTargets;
        while (true)
        {
          int num2 = -2131877050;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -2068068310 ^ 2103913081;
              continue;
            case 1:
              floodTargets = ZoomZoom.Properties.Settings.Default.FloodTargets;
              num1 = (int) num3 * -208090431 ^ -235761141;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return floodTargets;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.FloodTargets = value;
label_1:
        int num1 = 1294141031;
        while (true)
        {
          int num2 = 73833771;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1479091391 ^ -655075030;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2734117960U));
      }
    }

    public string JoinNameCategory
    {
      get
      {
        string urlLicenseCheck = ZoomZoom.Properties.Settings.Default.URL_LicenseCheck;
label_1:
        int num1 = 2107967176;
        while (true)
        {
          int num2 = 1428371204;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 898506042 ^ 168989562;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return urlLicenseCheck;
      }
      set
      {
label_1:
        int num1 = 1736187498;
        while (true)
        {
          int num2 = 1155688413;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              ZoomZoom.Properties.Settings.Default.URL_LicenseCheck = value;
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1621904691U));
              num1 = (int) num3 * 1681569085 ^ -1244639264;
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

    public string URL_LicenseCheck
    {
      get
      {
        string urlLicenseCheck = ZoomZoom.Properties.Settings.Default.URL_LicenseCheck;
label_1:
        int num1 = -1704569143;
        while (true)
        {
          int num2 = -930186827;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -340136601 ^ -1085642156;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return urlLicenseCheck;
      }
      set
      {
        ZoomZoom.Properties.Settings.Default.URL_LicenseCheck = value;
label_1:
        int num1 = -1670760988;
        while (true)
        {
          int num2 = -1720165492;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1219731098U));
              num1 = (int) num3 * 494257647 ^ 432218140;
              continue;
            case 1:
              Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1184441462 ^ 788859974;
              continue;
            case 2:
              num1 = (int) num3 * 1170295252 ^ 1411622254;
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

    public List<string> Names
    {
      get
      {
        List<string> names = this.names;
label_1:
        int num1 = -199077423;
        while (true)
        {
          int num2 = -1492707037;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1815707539 ^ 1243379846;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return names;
      }
      set
      {
        this.names = value;
      }
    }

    public bool CheckForWar
    {
      get
      {
        return this.checkForWar;
      }
      set
      {
        this.checkForWar = value;
      }
    }

    internal MeetingEventAction MeetingHoldAction
    {
      get
      {
label_1:
        int num1 = 59000173;
        MeetingEventAction meetingHoldAction;
        while (true)
        {
          int num2 = 1951112208;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingHoldAction = (MeetingEventAction) ZoomZoom.Properties.Settings.Default.MeetingHoldAction;
              num1 = (int) num3 * 1076811539 ^ -1163812443;
              continue;
            case 2:
              num1 = (int) num3 * 1253239925 ^ -1871713763;
              continue;
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
        int num1 = 47650793;
        while (true)
        {
          int num2 = 1176327954;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1951697407U));
              num1 = (int) num3 * 1664374271 ^ 229277777;
              continue;
            case 1:
              ZoomZoom.Properties.Settings.Default.MeetingHoldAction = (int) value;
              num1 = 601720268;
              continue;
            case 2:
              num1 = (int) num3 * -436645191 ^ -1311414155;
              continue;
            case 3:
              goto label_3;
            case 4:
              int num4 = flag ? -1482903828 : (num4 = -1389974400);
              int num5 = (int) num3 * -2072789895;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_1;
            case 6:
              flag = (MeetingEventAction) ZoomZoom.Properties.Settings.Default.MeetingHoldAction == value;
              num1 = (int) num3 * -795025630 ^ -911504052;
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

    internal MeetingEventAction MeetingRemovalAction
    {
      get
      {
label_1:
        int num1 = -510844262;
        MeetingEventAction meetingRemovalAction;
        while (true)
        {
          int num2 = -1723027745;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1626462379 ^ -1354840555;
              continue;
            case 1:
              meetingRemovalAction = (MeetingEventAction) ZoomZoom.Properties.Settings.Default.MeetingRemovalAction;
              num1 = (int) num3 * 195307136 ^ 1067831787;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingRemovalAction;
      }
      set
      {
label_1:
        int num1 = 1512229600;
        while (true)
        {
          int num2 = 308127734;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -569020047 ^ -1022871633;
              continue;
            case 2:
              num1 = (int) num3 * 1957892805 ^ -1453789812;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(816890665U));
              num1 = (int) num3 * -2038330829 ^ 429552365;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * 977454081 ^ -1802658424;
              continue;
            case 6:
              int num4 = (MeetingEventAction) ZoomZoom.Properties.Settings.Default.MeetingRemovalAction != value ? -482399497 : (num4 = -1371839895);
              int num5 = (int) num3 * 451081229;
              num1 = num4 ^ num5;
              continue;
            case 7:
              ZoomZoom.Properties.Settings.Default.MeetingRemovalAction = (int) value;
              num1 = 893556995;
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

    public List<string> PredefinedMonitors
    {
      get
      {
label_1:
        int num1 = -644744907;
        List<string> predefinedMonitors;
        while (true)
        {
          int num2 = -1438855854;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 210301632 ^ 666908267;
              continue;
            case 3:
              predefinedMonitors = this.PredefinedMonitors;
              num1 = (int) num3 * -1806469812 ^ -1109629228;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return predefinedMonitors;
      }
      set
      {
label_1:
        int num1 = 2012749462;
        while (true)
        {
          int num2 = 1393837038;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2736634459U));
              num1 = (int) num3 * 166179203 ^ 781862422;
              continue;
            case 2:
              num1 = (int) num3 * 1083230941 ^ 32717417;
              continue;
            case 3:
              this.predefinedMonitors = new List<string>();
              num1 = 1440825040;
              continue;
            case 4:
              int num4 = flag ? -361981839 : (num4 = -1266748808);
              int num5 = (int) num3 * -508715658;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_3;
            case 6:
              flag = this.predefinedMonitors == value;
              num1 = (int) num3 * 213060089 ^ 1424879079;
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

    public List<ZoomMonitor> Monitors
    {
      get
      {
label_1:
        int num1 = -821570200;
        List<ZoomMonitor> monitors;
        while (true)
        {
          int num2 = -15315218;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1947932514 ^ 332054200;
              continue;
            case 2:
              monitors = Settings.monitors;
              num1 = (int) num3 * -368125008 ^ -2021195561;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return monitors;
      }
      set
      {
label_1:
        int num1 = 8444052;
        while (true)
        {
          int num2 = 600092218;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 1436618686 ^ -331469255;
              continue;
            case 3:
              Settings.monitors = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1512150867U));
              num1 = 366349779;
              continue;
            case 4:
              num1 = (int) num3 * 1441413161 ^ 548870737;
              continue;
            case 5:
              flag = Settings.monitors == value;
              num1 = (int) num3 * -1430910676 ^ 1557378849;
              continue;
            case 6:
              int num4 = flag ? -523762070 : (num4 = -434255064);
              int num5 = (int) num3 * 1513180706;
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

    public Dictionary<int, string> MonitorScreenDictionary
    {
      get
      {
label_1:
        int num1 = 1207388716;
        Dictionary<int, string> screenDictionary;
        while (true)
        {
          int num2 = 557165545;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              screenDictionary = this.monitorScreenDictionary;
              num1 = (int) num3 * -1678648392 ^ 1226115812;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return screenDictionary;
      }
      set
      {
        this.monitorScreenDictionary = value;
      }
    }

    static Settings()
    {
label_1:
      int num1 = 1182750020;
      while (true)
      {
        int num2 = 1439077873;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            Settings.lineart = new List<string>();
            Settings.monitors = new List<ZoomMonitor>();
            Settings.greetings = new List<MessageContent>();
            num1 = (int) num3 * -1462745902 ^ -295860610;
            continue;
          case 3:
            Settings.meetingAutoFindUsers = new ObservableCollection<StringItem>();
            num1 = (int) num3 * -1932844597 ^ -671555287;
            continue;
          case 4:
            Settings.staticMessageSources = new List<MessageCategory>();
            Settings.joinUserNames = new ObservableCollection<StringItem>();
            num1 = (int) num3 * 2089469680 ^ 1563215158;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    public Settings()
    {
label_1:
      int num1 = 450528093;
      while (true)
      {
        int num2 = 2065793075;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1046558715 ^ 1263453497;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        this.zoomExePath = RegistryHelper.GetRegistryKeyValue(Registry.CurrentUser, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2960634842U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2692558989U));
        Settings.\u200D‍⁬‫‬‮⁮​‫‎⁪⁮‌‌‎‭⁫‭⁭‫⁭‎‎⁬‭‮‍​‏‎‍⁮‫⁫⁫‬⁯‮‫⁮‮(CoreObject.log, Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2480258388U), this.zoomExePath), new object[0]);
        string meetingAutoFindUsers = ZoomZoom.Properties.Settings.Default.MeetingAutoFindUsers;
        char[] chArray1 = new char[1]{ '|' };
        foreach (string str in Settings.\u206C‫‭‭‪⁪⁭‫‬⁯‌⁪‭‪‮‪‮⁭‫‬⁭⁯⁮‎‌⁪⁪‎‍⁮‫‮⁭‬‭‍⁮⁯⁫⁫‮(meetingAutoFindUsers, chArray1))
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          Settings.\u003C\u003Ec__DisplayClass41_0 cDisplayClass410 = new Settings.\u003C\u003Ec__DisplayClass41_0();
          // ISSUE: reference to a compiler-generated field
          cDisplayClass410.name = str;
          // ISSUE: method pointer
          if (!Enumerable.Any<StringItem>((IEnumerable<M0>) this.MeetingAutoFindUsers, (Func<M0, bool>) new Func<StringItem, bool>((object) cDisplayClass410, __methodptr(\u003C\u002Ector\u003Eb__0))))
          {
            // ISSUE: reference to a compiler-generated field
            ((Collection<StringItem>) this.MeetingAutoFindUsers).Add(new StringItem(cDisplayClass410.name));
          }
        }
        // ISSUE: method pointer
        this.MeetingAutoFindUsers.add_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(MeetingAutoFindUsers_CollectionChanged)));
        string joinUserNames = ZoomZoom.Properties.Settings.Default.JoinUserNames;
        char[] chArray2 = new char[1]{ '|' };
        foreach (string str in Settings.\u206C‫‭‭‪⁪⁭‫‬⁯‌⁪‭‪‮‪‮⁭‫‬⁭⁯⁮‎‌⁪⁪‎‍⁮‫‮⁭‬‭‍⁮⁯⁫⁫‮(joinUserNames, chArray2))
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          Settings.\u003C\u003Ec__DisplayClass41_1 cDisplayClass411 = new Settings.\u003C\u003Ec__DisplayClass41_1();
          // ISSUE: reference to a compiler-generated field
          cDisplayClass411.name = str;
          // ISSUE: method pointer
          if (!Enumerable.Any<StringItem>((IEnumerable<M0>) this.JoinUserNames, (Func<M0, bool>) new Func<StringItem, bool>((object) cDisplayClass411, __methodptr(\u003C\u002Ector\u003Eb__1))))
          {
            // ISSUE: reference to a compiler-generated field
            ((Collection<StringItem>) this.JoinUserNames).Add(new StringItem(cDisplayClass411.name));
          }
        }
        // ISSUE: method pointer
        this.JoinUserNames.add_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(JoinUserNames_CollectionChanged)));
      }
      catch (Exception ex)
      {
        Settings.\u202D⁮‪⁪‫‌‎‫‎⁭‫‮‏‮‏‌‭⁪‮⁬‎​‏‌‪‭​‬⁯‬⁫‪⁭‬‫‌⁬⁯‫⁫‮(CoreObject.log, (object) ex);
        throw ex;
      }
    }

    ~Settings()
    {
label_2:
      int num1 = 1543377627;
      while (true)
      {
        int num2 = 785304998;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            int num4 = !flag ? -1917910007 : (num4 = -337783997);
            int num5 = (int) num3 * 2033635027;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * 1857368420 ^ -1089286679;
            continue;
          case 2:
            goto label_12;
          case 3:
            flag = this.MeetingAutoFindUsers != null;
            num1 = (int) num3 * -1751754286 ^ -1097361146;
            continue;
          case 4:
            // ISSUE: method pointer
            this.JoinUserNames.remove_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(JoinUserNames_CollectionChanged)));
            num1 = (int) num3 * 3754092 ^ 550822761;
            continue;
          case 5:
            int num6;
            num1 = num6 = this.JoinUserNames == null ? 356972999 : (num6 = 1600489624);
            continue;
          case 6:
            // ISSUE: method pointer
            this.MeetingAutoFindUsers.remove_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(MeetingAutoFindUsers_CollectionChanged)));
            num1 = (int) num3 * 592383525 ^ -1114836144;
            continue;
          case 7:
            goto label_2;
          case 8:
            num1 = (int) num3 * 1543569201 ^ -535349044;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return;
label_12:;
    }

    internal bool IsTracingEnabled(TraceType traceType)
    {
label_1:
      int num1 = -1003167730;
      bool flag;
      while (true)
      {
        int num2 = -2005267471;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            num1 = (int) num3 * 1501849790 ^ -1116978493;
            continue;
          case 1:
label_7:
            flag = this.TraceUserEvents;
            num1 = -1441999437;
            continue;
          case 2:
label_18:
            flag = this.TraceDataStorage;
            num1 = -938920966;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 1433582728 ^ -1740811693;
            continue;
          case 5:
            num1 = (int) num3 * -440414526 ^ 1749360185;
            continue;
          case 6:
label_17:
            flag = this.TraceActivityEvents;
            num1 = -1373802291;
            continue;
          case 7:
          case 9:
label_15:
            flag = false;
            num1 = -1441999437;
            continue;
          case 8:
label_20:
            flag = this.TraceWindowEvents;
            num1 = -461765447;
            continue;
          case 11:
            num1 = (int) num3 * -2040919780 ^ 628904327;
            continue;
          case 12:
            num1 = (int) num3 * 1787475870 ^ -208140598;
            continue;
          case 13:
label_10:
            flag = this.TraceApplicationEvents;
            num1 = -1441999437;
            continue;
          case 14:
label_19:
            flag = this.TraceImageEvents;
            num1 = -1441999437;
            continue;
          case 15:
label_9:
            flag = this.TraceUserInterfaceEvents;
            num1 = -1441999437;
            continue;
          case 16:
label_6:
            flag = this.TraceChatEvents;
            num1 = -8100076;
            continue;
          case 17:
label_3:
            flag = this.TraceMeetingEvents;
            num1 = -1441999437;
            continue;
          case 18:
label_14:
            flag = this.TraceLayoutEvents;
            num1 = -1441999437;
            continue;
          case 19:
            switch (traceType)
            {
              case TraceType.Undefined:
              case TraceType.Other:
                goto label_15;
              case TraceType.Window:
                goto label_20;
              case TraceType.Layout:
                goto label_14;
              case TraceType.Meeting:
                goto label_3;
              case TraceType.Chat:
                goto label_6;
              case TraceType.Image:
                goto label_19;
              case TraceType.User:
                goto label_7;
              case TraceType.Activity:
                goto label_17;
              case TraceType.DataStorage:
                goto label_18;
              case TraceType.UserInterface:
                goto label_9;
              case TraceType.Application:
                goto label_10;
              default:
                num1 = (int) num3 * 2084880333 ^ -107097046;
                continue;
            }
          default:
            goto label_21;
        }
      }
label_21:
      return flag;
    }

    private void MeetingAutoFindUsers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
label_1:
      int num1 = -1756855931;
      string str;
      while (true)
      {
        int num2 = -1394237273;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * 178484987 ^ 1090936292;
            continue;
          case 2:
            str = string.Empty;
            num1 = (int) num3 * -105619330 ^ 1900760698;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      IEnumerator<StringItem> enumerator = ((Collection<StringItem>) this.MeetingAutoFindUsers).GetEnumerator();
      try
      {
label_10:
        int num2 = Settings.\u206B⁯‭‬‏⁫⁮‍‌‏⁪⁯‏⁯⁪‍‏‮⁭‭‪​⁫⁯‎⁯‫⁫⁮‎⁭‭‎‌⁬‌⁯⁯⁫⁪‮((IEnumerator) enumerator) ? -647495391 : (num2 = -1951602715);
        while (true)
        {
          int num3 = -1394237273;
          uint num4;
          StringItem current;
          switch ((num4 = (uint) (num2 ^ num3)) % 9U)
          {
            case 1:
              current = enumerator.Current;
              num2 = -1449408959;
              continue;
            case 2:
              num2 = -647495391;
              continue;
            case 3:
              int num5 = Settings.\u206C‫‎‌‏‮⁪‫‍‮‏‭⁬‭‪⁯‫‎‎‬‏‬‌‏⁯⁯‬‪⁬​​‮⁮‫⁪‎‮‪‏⁭‮(str, string.Empty) ? -2126656374 : (num5 = -978552459);
              int num6 = (int) num4 * 1261114860;
              num2 = num5 ^ num6;
              continue;
            case 4:
              num2 = (int) num4 * 1993314106 ^ -1497715271;
              continue;
            case 5:
              goto label_10;
            case 6:
              str = Settings.\u206D‪‫⁪⁭‎​‭‏‪⁭⁯‫‬⁪‫⁫⁯⁬⁯‭‫⁬⁬‮⁬⁫‎⁪‌​‪‎‭‏‮⁮‎‍‭‮((object) str, (object) current);
              num2 = -1997856045;
              continue;
            case 7:
              num2 = (int) num4 * 193139944 ^ -1453520246;
              continue;
            case 8:
              str = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1683746435U));
              num2 = (int) num4 * -702256985 ^ -615067242;
              continue;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_17:
          int num2 = -1285810485;
          while (true)
          {
            int num3 = -1394237273;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_17;
              case 2:
                Settings.\u200B‍‏‬⁭‌⁪‏‏⁮‎⁭‏‭‭‭‏‭‬‏‫​⁫‪⁬‍‪⁮‫‏⁬⁪‫‍‍‮‎‭⁭⁪‮((IDisposable) enumerator);
                num2 = (int) num4 * -1213117785 ^ 1378793401;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:
      ZoomZoom.Properties.Settings.Default.MeetingAutoFindUsers = str;
      Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
    }

    private void JoinUserNames_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      string str = string.Empty;
      IEnumerator<StringItem> enumerator = ((Collection<StringItem>) this.JoinUserNames).GetEnumerator();
      try
      {
label_8:
        int num1 = Settings.\u206B⁯‭‬‏⁫⁮‍‌‏⁪⁯‏⁯⁪‍‏‮⁭‭‪​⁫⁯‎⁯‫⁫⁮‎⁭‭‎‌⁬‌⁯⁯⁫⁪‮((IEnumerator) enumerator) ? -1196563374 : (num1 = -2098971096);
        while (true)
        {
          int num2 = -2033734385;
          uint num3;
          StringItem current;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              int num4 = !Settings.\u206C‫‎‌‏‮⁪‫‍‮‏‭⁬‭‪⁯‫‎‎‬‏‬‌‏⁯⁯‬‪⁬​​‮⁮‫⁪‎‮‪‏⁭‮(str, string.Empty) ? 874793323 : (num4 = 1313552308);
              int num5 = (int) num3 * 140023822;
              num1 = num4 ^ num5;
              continue;
            case 1:
              num1 = (int) num3 * 101437801 ^ -839737600;
              continue;
            case 2:
              num1 = -1196563374;
              continue;
            case 3:
              str = Settings.\u206D‪‫⁪⁭‎​‭‏‪⁭⁯‫‬⁪‫⁫⁯⁬⁯‭‫⁬⁬‮⁬⁫‎⁪‌​‪‎‭‏‮⁮‎‍‭‮((object) str, (object) current);
              num1 = -1825640154;
              continue;
            case 4:
              str = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(str, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(643205451U));
              num1 = (int) num3 * 1465105425 ^ -140335088;
              continue;
            case 5:
              current = enumerator.Current;
              num1 = -586065993;
              continue;
            case 6:
              goto label_8;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_11:
          int num1 = -1786174306;
          while (true)
          {
            int num2 = -2033734385;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_11;
              case 1:
                Settings.\u200B‍‏‬⁭‌⁪‏‏⁮‎⁭‏‭‭‭‏‭‬‏‫​⁫‪⁬‍‪⁮‫‏⁬⁪‫‍‍‮‎‭⁭⁪‮((IDisposable) enumerator);
                num1 = (int) num3 * -1046356093 ^ -298290493;
                continue;
              case 3:
                num1 = (int) num3 * 1948668570 ^ 620087579;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      ZoomZoom.Properties.Settings.Default.JoinUserNames = str;
label_18:
      int num6 = -496769974;
      while (true)
      {
        int num1 = -2033734385;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 4U)
        {
          case 0:
            goto label_20;
          case 1:
            Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
            num6 = (int) num2 * 1410315680 ^ 699526317;
            continue;
          case 2:
            num6 = (int) num2 * -467616549 ^ -216145075;
            continue;
          case 3:
            goto label_18;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_20:;
    }

    internal void Initialize(SharedData sharedData)
    {
      object settingsLock = Settings.settingsLock;
      bool flag = false;
      try
      {
        Settings.\u200E‌‎⁪⁬⁪⁪‮‍‬‭‮‫‪⁫⁯⁯‭‫⁮⁬‫⁬‌‫​‌​‍‏‫‍​​⁪⁪‌‬⁮⁬‮(settingsLock, ref flag);
label_2:
        int num1 = 1381102977;
        while (true)
        {
          int num2 = 1564026031;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              this.sharedData = sharedData;
              num1 = (int) num3 * -590784165 ^ 1120635454;
              continue;
            case 1:
              this.LoadMonitors();
              num1 = (int) num3 * 1474188652 ^ 1432985172;
              continue;
            case 2:
              num1 = (int) num3 * 1535535538 ^ 609229973;
              continue;
            case 3:
              num1 = (int) num3 * -361509441 ^ -275004628;
              continue;
            case 4:
              num1 = (int) num3 * 1836397500 ^ 1242637915;
              continue;
            case 5:
              goto label_2;
            case 7:
              this.LoadLineArt();
              num1 = (int) num3 * -1179595227 ^ 640033413;
              continue;
            case 8:
              this.LoadGreetings();
              num1 = (int) num3 * 18203554 ^ 404881686;
              continue;
            case 9:
              this.LoadPatterns();
              num1 = (int) num3 * -1567478600 ^ -822620795;
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
          int num1 = 454748786;
          while (true)
          {
            int num2 = 1564026031;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_13;
              case 1:
                Settings.\u206D‫⁪⁯⁬‍⁭⁫⁪⁬‪‬⁮⁯⁬⁬‮‍‍‎​⁯‮⁭‌‎⁪‏⁪‫⁭‬⁫‬​‮⁫​‪‫‮(settingsLock);
                num1 = (int) num3 * 1700258330 ^ 2121494758;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      this.EngineView_DisplayActivityBar = false;
label_19:
      int num4 = 498416416;
      while (true)
      {
        int num1 = 1564026031;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 11U)
        {
          case 0:
            goto label_21;
          case 1:
            this.EngineView_DisplayChatBar = false;
            num4 = (int) num2 * 1932936458 ^ 1618711507;
            continue;
          case 2:
            this.EngineView_DisplayMeetingBar = false;
            num4 = (int) num2 * -742510639 ^ 956120776;
            continue;
          case 3:
            this.EngineView_DisplayQuickLinkBar = true;
            num4 = (int) num2 * 815762184 ^ -1003930479;
            continue;
          case 4:
            this.EngineView_DisplaySettingsBar = false;
            num4 = (int) num2 * -1968072357 ^ -27383533;
            continue;
          case 5:
            num4 = (int) num2 * 504601711 ^ -1629635797;
            continue;
          case 6:
            this.EngineView_DisplayImageBar = false;
            num4 = (int) num2 * -1445347198 ^ 1281426202;
            continue;
          case 7:
            num4 = (int) num2 * -972374260 ^ -2106695296;
            continue;
          case 8:
            this.EngineView_DisplayLayoutBar = false;
            num4 = (int) num2 * 325866771 ^ -1290078941;
            continue;
          case 9:
            goto label_19;
          case 10:
            num4 = (int) num2 * 1798199096 ^ -1680019051;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_21:;
    }

    private void LoadMonitors()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Settings.\u003C\u003Ec__DisplayClass47_0 cDisplayClass470 = new Settings.\u003C\u003Ec__DisplayClass47_0();
label_1:
      int num1 = -911131418;
      while (true)
      {
        int num2 = -1734148766;
        uint num3;
        Screen[] screenArray;
        int index;
        ZoomMonitor zoomMonitor;
        bool flag1;
        List<string> list;
        string str;
        bool flag2;
        bool flag3;
        // ISSUE: variable of a compiler-generated type
        Settings.\u003C\u003Ec__DisplayClass47_1 cDisplayClass471;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 29U)
        {
          case 0:
            num1 = (int) num3 * 1112747881 ^ 1030569444;
            continue;
          case 1:
            this.Monitors.Add(zoomMonitor);
            num1 = -2114873472;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass471.existingScreen = Settings.\u202A⁫⁭‫⁬⁬‍⁪‏⁭⁯‌‌‮‎‬‭‍‎⁭​‪‮​‪⁪⁬‎⁪‌‭‌‮​‏⁪⁯‮⁭‪‮(str, Settings.\u206B⁮‫⁭‪‭‮⁪‎⁪‬⁬‬⁪⁫⁭⁭⁬‫​‌‬‎⁯⁫‎⁪‮‍⁭‌‏‏‭‏​‮‫‌⁪‮(str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1715048345U)) + 1);
            // ISSUE: method pointer
            flag1 = Enumerable.Any<Screen>((IEnumerable<M0>) Settings.\u206F‭‭​​⁮‮⁭‮⁬‫‮‏‍‬‭‍‪⁯⁪‬⁫​​⁬‏‭‌‌‌‌‫‏‬‫‬‬⁫‭⁬‮(), (Func<M0, bool>) new Func<Screen, bool>((object) cDisplayClass471, __methodptr(\u003CLoadMonitors\u003Eb__1)));
            num1 = (int) num3 * -1403954992 ^ 1950657318;
            continue;
          case 3:
            index = 0;
            num1 = (int) num3 * -173986791 ^ 1685463897;
            continue;
          case 4:
            num1 = -1780825578;
            continue;
          case 5:
            num4 = Settings.\u206C⁬‎‌⁯⁫⁮⁪‪‍⁬⁬‪⁯‭​⁬⁫‏‏‪⁯⁭⁭‭‭‎⁪‏‬‌‭⁭‬⁬‏⁮​‪‬‮(str, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1661205733U)) ? 1 : 0;
            break;
          case 6:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass471 = new Settings.\u003C\u003Ec__DisplayClass47_1();
            num1 = (int) num3 * 749987985 ^ 1633430567;
            continue;
          case 7:
            Screen screen = screenArray[index];
            // ISSUE: reference to a compiler-generated field
            int x = cDisplayClass470.x;
            // ISSUE: reference to a compiler-generated field
            cDisplayClass470.x = x + 1;
            // ISSUE: reference to a compiler-generated field
            zoomMonitor = new ZoomMonitor(cDisplayClass470.x, "");
            num1 = -536036076;
            continue;
          case 8:
            zoomMonitor.ScreenName = Settings.\u202B​⁭‍‌‬⁪⁪⁫‌‬⁭⁬‭‭‬‌‫⁫‪‪‍‪⁪‭⁯‎⁪⁮⁬⁫⁫⁯‬⁪⁯‎⁭⁯‫‮(Settings.\u202A⁭‏​‎⁮‬‏‏​⁪⁯​‪‭‫‪‭⁯‫⁬‫‪‭‎‪‏⁬‌⁬‏‫​‫‭⁪⁭‭‏⁭‮());
            num1 = (int) num3 * 1369871636 ^ -1170123813;
            continue;
          case 9:
            num1 = (int) num3 * 847577734 ^ 1983122081;
            continue;
          case 10:
            num1 = (int) num3 * 357894688 ^ -973593160;
            continue;
          case 11:
            num1 = (int) num3 * -1752943294 ^ -1513104564;
            continue;
          case 12:
            num1 = (int) num3 * -1290539850 ^ -2079370590;
            continue;
          case 13:
            int num5 = !flag2 ? -387685749 : (num5 = -1798983051);
            int num6 = (int) num3 * 564174277;
            num1 = num5 ^ num6;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass470.x = 0;
            num1 = (int) num3 * -847758237 ^ 1560994414;
            continue;
          case 15:
            this.Monitors = new List<ZoomMonitor>();
            num1 = (int) num3 * -2126795819 ^ 1636032542;
            continue;
          case 16:
            flag3 = Settings.\u200C​‌‏⁬⁫‌‍​⁯⁭‬⁫⁬⁮‭‪‬‎⁭⁬‮‏‎⁭‎‎⁪​⁪‎‪⁯⁬‌⁫⁮⁫⁭‪‮(zoomMonitor.ScreenName);
            num1 = -1657203690;
            continue;
          case 17:
            int num7;
            num1 = num7 = index >= screenArray.Length ? -1122758853 : (num7 = -870561633);
            continue;
          case 18:
            ++index;
            num1 = (int) num3 * 2081417431 ^ -391618702;
            continue;
          case 19:
            goto label_1;
          case 20:
            list = ((IEnumerable<string>) Settings.\u206C‫‭‭‪⁪⁭‫‬⁯‌⁪‭‪‮‪‮⁭‫‬⁭⁯⁮‎‌⁪⁪‎‍⁮‫‮⁭‬‭‍⁮⁯⁫⁫‮(ZoomZoom.Properties.Settings.Default.MonitorScreenAssignments, new char[1]
            {
              '|'
            })).ToList<string>();
            screenArray = Settings.\u206F‭‭​​⁮‮⁭‮⁬‫‮‏‍‬‭‍‪⁯⁪‬⁫​​⁬‏‭‌‌‌‌‫‏‬‫‬‬⁫‭⁬‮();
            num1 = (int) num3 * 1742541987 ^ -392676546;
            continue;
          case 21:
            num1 = (int) num3 * 891208329 ^ 1010760766;
            continue;
          case 22:
            goto label_3;
          case 23:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            str = (string) Enumerable.FirstOrDefault<string>((IEnumerable<M0>) list, (Func<M0, bool>) (cDisplayClass470.\u003C\u003E9__0 ?? (cDisplayClass470.\u003C\u003E9__0 = new Func<string, bool>((object) cDisplayClass470, __methodptr(\u003CLoadMonitors\u003Eb__0)))));
            if (!Settings.\u200C​‌‏⁬⁫‌‍​⁯⁭‬⁫⁬⁮‭‪‬‎⁭⁬‮‏‎⁭‎‎⁪​⁪‎‪⁯⁬‌⁫⁮⁫⁭‪‮(str))
            {
              num1 = -448494026;
              continue;
            }
            num4 = 0;
            break;
          case 24:
            this.Screens = new List<string>();
            num1 = (int) num3 * 1967007826 ^ -434237109;
            continue;
          case 25:
            num1 = (int) num3 * 1220819790 ^ -43973019;
            continue;
          case 26:
            int num8 = !flag3 ? 1234082074 : (num8 = 1701570856);
            int num9 = (int) num3 * -508987455;
            num1 = num8 ^ num9;
            continue;
          case 27:
            // ISSUE: reference to a compiler-generated field
            zoomMonitor.ScreenName = cDisplayClass471.existingScreen;
            num1 = (int) num3 * 1564611684 ^ -1310808798;
            continue;
          case 28:
            int num10 = flag1 ? 1042878316 : (num10 = 2089363101);
            int num11 = (int) num3 * -1650022862;
            num1 = num10 ^ num11;
            continue;
          default:
            goto label_34;
        }
        flag2 = num4 != 0;
        num1 = -2110930533;
      }
label_34:
      return;
label_3:;
    }

    internal void SetMonitorScreen(int monitorNumber, string screenName)
    {
      if (monitorNumber > this.Monitors.Count)
        return;
label_1:
      int num1 = 1330212293;
      while (true)
      {
        int num2 = 1982261261;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * -1437892714 ^ -517671053;
            continue;
          case 1:
            this.Monitors[monitorNumber].ScreenName = screenName;
            num1 = (int) num3 * 1275959854 ^ -1828009141;
            continue;
          case 2:
            goto label_7;
          case 3:
            num1 = (int) num3 * -1154668095 ^ -136099152;
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

    internal void SaveMonitors()
    {
label_1:
      int num1 = -888401596;
      while (true)
      {
        int num2 = -694359146;
        uint num3;
        string monitorScreens;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            Settings.\u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
            num1 = (int) num3 * -2122212699 ^ 1326393211;
            continue;
          case 1:
            ZoomZoom.Properties.Settings.Default.MonitorScreenAssignments = monitorScreens;
            num1 = -1447732806;
            continue;
          case 2:
            goto label_3;
          case 3:
            monitorScreens = "";
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this.Monitors.ForEach((Action<ZoomMonitor>) (o => monitorScreens = Settings.\u003C\u003Ec__DisplayClass49_0.\u202C⁮‬‭⁯‎‌‪‪‭‫⁫‫⁪‎‏‭⁬‫‏‎‫‫⁭‬‬‎‏‬‪‌⁭‏⁯‫‍‫‭‎‮(monitorScreens, Settings.\u003C\u003Ec__DisplayClass49_0.\u200E⁪‮‫‫⁪‫‭⁭‎⁪⁮⁮⁪‪‫‫⁫⁭‫‌⁫‭⁭⁪​‎​​‪‌‮‏⁭‬‏‏⁯⁪‭‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3786298598U), (object) (o.MonitorNumber - 1), (object) o.ScreenName))));
            num1 = (int) num3 * 1096534345 ^ 42675646;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num4 = !Settings.\u206F⁮⁪‭⁬⁬⁫‎⁭‎‬⁪⁫‫‏⁭‌‏⁮‌‫‌⁭‬‎‭‮⁬​⁬‮⁪⁭‬‌‎‫⁮‏‌‮(monitorScreens, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(750811209U)) ? 1959390903 : (num4 = 1425652460);
            int num5 = (int) num3 * -1493750813;
            num1 = num4 ^ num5;
            continue;
          case 6:
            num1 = (int) num3 * 1201722302 ^ -980570235;
            continue;
          case 7:
            monitorScreens = Settings.\u206A⁫‎⁮‬‏⁮‬‏⁭⁮‏‏⁯‎‪⁭⁭‌‍‌⁯⁬⁬‫​⁭⁫⁪⁯‮‮⁮‭‎‏‏⁬‍‪‮(monitorScreens, 0, Settings.\u206D‎⁬⁭‫⁭‪‫‍⁯‪‬⁯​‎‍⁯‭⁯‪‫‪‭⁫‌‏⁭‌⁭‮⁫⁪⁪⁮‮‬‫⁪‬‮‮(monitorScreens) - 1);
            num1 = (int) num3 * 1961264633 ^ -68096940;
            continue;
          case 8:
            num1 = (int) num3 * 1862562049 ^ -1105769089;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void LoadLineArt()
    {
      try
      {
        string str1 = Settings.\u200B​⁫‌‏‪⁭⁭⁯‮⁬⁯‏⁪⁪‫‌‫‎‭‫‪‭⁭⁫‬⁭‬‌‍‫‍‌‎‮​⁭⁪‍‎‮(this.ZoomZoomRoot, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(823190685U));
        if (!Settings.\u206F⁬⁭⁯‎⁮⁫‭‮⁫​‎‭‭‏⁪⁪‭‎‪‍⁭‪⁪‮‍‍‬‬⁫⁫‌‬⁬⁮‭⁪‌‭‮‮(str1))
          goto label_6;
label_2:
        int num1 = 1451501551;
label_3:
        while (true)
        {
          int num2 = 1490118640;
          uint num3;
          string str2;
          int index;
          string[] strArray1;
          string[] strArray2;
          switch ((num3 = (uint) (num1 ^ num2)) % 20U)
          {
            case 0:
              num1 = (int) num3 * -295843156 ^ -1419173914;
              continue;
            case 1:
              num1 = (int) num3 * -439692538 ^ -1369542404;
              continue;
            case 2:
              num1 = (int) num3 * 218317048 ^ -26193848;
              continue;
            case 3:
              Settings.\u206F⁪⁭‬‬⁬​⁬‌​⁭‬⁮⁬‮‪⁫‌‌⁯⁫‮‬‭‍⁬‫⁮‮⁪‎‭‬‪‬‮⁭​‍‭‮(CoreObject.log, (object) Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3175592595U), str1));
              num1 = (int) num3 * 1816201323 ^ 810675372;
              continue;
            case 4:
              index = 0;
              num1 = (int) num3 * 1795123158 ^ 836040480;
              continue;
            case 5:
              goto label_31;
            case 6:
              goto label_2;
            case 7:
              num1 = (int) num3 * 2054350119 ^ 1998092524;
              continue;
            case 8:
              num1 = (int) num3 * 1844362484 ^ 1661274713;
              continue;
            case 9:
              num1 = (int) num3 * -228379968 ^ 867002540;
              continue;
            case 10:
              goto label_6;
            case 11:
              num1 = (int) num3 * -902824443 ^ -1435573720;
              continue;
            case 12:
              strArray2 = Settings.\u206E‭⁮‏⁯⁯‎⁪‎‬⁫‌⁪⁫⁫​‫​​‪⁯⁯⁫‮‌‎⁪⁬‮‭⁬⁯‍​​⁪‌‬‪‭‮(str1);
              num1 = (int) num3 * 1455988087 ^ -1568438309;
              continue;
            case 13:
              int num4;
              num1 = num4 = index < strArray1.Length ? 2046296765 : (num4 = 1042021299);
              continue;
            case 14:
              num1 = (int) num3 * -924901001 ^ -1731326945;
              continue;
            case 15:
              strArray1 = strArray2;
              num1 = (int) num3 * -38581312 ^ 664224152;
              continue;
            case 16:
              this.Lineart.Add(str2);
              num1 = (int) num3 * 189274450 ^ 1360109870;
              continue;
            case 17:
              str2 = strArray1[index];
              num1 = 1002334053;
              continue;
            case 18:
              ++index;
              num1 = (int) num3 * -510745187 ^ -1689182457;
              continue;
            case 19:
              num1 = (int) num3 * -1760279707 ^ 337132447;
              continue;
            default:
              goto label_27;
          }
        }
label_27:
        return;
label_31:
        return;
label_6:
        num1 = 800218775;
        goto label_3;
      }
      catch (Exception ex)
      {
label_25:
        int num1 = 2089559201;
        while (true)
        {
          int num2 = 1490118640;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_25;
            case 1:
              Settings.\u202D⁮‪⁪‫‌‎‫‎⁭‫‮‏‮‏‌‭⁪‮⁬‎​‏‌‪‭​‬⁯‬⁫‪⁭‬‫‌⁬⁯‫⁫‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 2050160536 ^ -1766381192;
              continue;
            case 2:
              num1 = (int) num3 * 2058466971 ^ 1043455733;
              continue;
            case 3:
              goto label_23;
            case 4:
              num1 = (int) num3 * -861381833 ^ 1993840591;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_23:;
      }
    }

    internal string GetMessageText(string source)
    {
      string str1 = source;
      if (Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(917438053U)))
        goto label_7;
label_1:
      int num1 = -744703583;
label_2:
      string str2;
      while (true)
      {
        int num2 = -1084129060;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * -333544233 ^ 1600731835;
            continue;
          case 1:
            num1 = (int) num3 * 886813822 ^ -1679987603;
            continue;
          case 2:
            int num4 = Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2435942509U)) ? 1710320923 : (num4 = 1157596436);
            int num5 = (int) num3 * -1420035967;
            num1 = num4 ^ num5;
            continue;
          case 3:
          case 12:
            str2 = string.Empty;
            num1 = -884733579;
            continue;
          case 4:
            num1 = (int) num3 * 1167079520 ^ 66545767;
            continue;
          case 5:
            str2 = this.GetRandomText();
            num1 = -1066857853;
            continue;
          case 6:
            num1 = (int) num3 * 971798887 ^ 534604862;
            continue;
          case 7:
            goto label_1;
          case 8:
            goto label_7;
          case 10:
            int num6 = Settings.\u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2567362254U)) ? 591690774 : (num6 = 360772322);
            int num7 = (int) num3 * -357787689;
            num1 = num6 ^ num7;
            continue;
          case 11:
            str2 = this.GetRandomGreeting();
            num1 = -1258572680;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return str2;
label_7:
      str2 = this.GetRandomGuid();
      num1 = -1011351801;
      goto label_2;
    }

    private string GetRandomGuid()
    {
      return Guid.NewGuid().ToString();
    }

    internal string GetRandomText()
    {
label_1:
      int num1 = 731225767;
      string str1;
      while (true)
      {
        int num2 = 2124382108;
        uint num3;
        string str2;
        Random random;
        int num4;
        int num5;
        bool flag;
        char[] chArray;
        int num6;
        int num7;
        string str3;
        int num8;
        switch ((num3 = (uint) (num1 ^ num2)) % 24U)
        {
          case 0:
            num1 = 338518944;
            continue;
          case 1:
            num1 = 2117093078;
            continue;
          case 2:
            str2 = str2.TrimStart();
            str1 = str2;
            num1 = (int) num3 * 1598301674 ^ -451598951;
            continue;
          case 3:
            goto label_1;
          case 4:
            int index = Settings.\u202B‎‪⁬⁫‪‌‭⁬⁭⁭‌⁯⁬‌⁮⁬‌‫‍‌‮‎‪‌‪‌⁮‭​⁯‬⁪⁯‬⁯⁭⁮⁫⁮‮(random, 0, chArray.Length - 1);
            str3 += chArray[index].ToString();
            num1 = (int) num3 * 507547207 ^ -340795561;
            continue;
          case 5:
            int num9;
            num1 = num9 = num6 >= num7 ? 1238272342 : (num9 = 380292084);
            continue;
          case 7:
            random = Settings.\u202D⁯⁬‪‪‪‫⁪‍​‎⁭⁫⁫‏‏‭‎‌‏⁮‭‭‭​⁯⁬⁪‬​‫​‬⁭⁯⁫⁪‏‎‫‮();
            num1 = (int) num3 * 499750194 ^ 1413020993;
            continue;
          case 8:
            str2 = str2 + \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3515778971U) + str3;
            num1 = (int) num3 * -123558194 ^ 54578908;
            continue;
          case 9:
            num1 = (int) num3 * -894598638 ^ -1384500160;
            continue;
          case 10:
            num1 = (int) num3 * -684245843 ^ 2034582275;
            continue;
          case 11:
            num7 = Settings.\u202B‎‪⁬⁫‪‌‭⁬⁭⁭‌⁯⁬‌⁮⁬‌‫‍‌‮‎‪‌‪‌⁮‭​⁯‬⁪⁯‬⁯⁭⁮⁫⁮‮(random, 80, 100);
            num6 = 0;
            num1 = (int) num3 * -1529621308 ^ -1787078430;
            continue;
          case 12:
            str3 = "";
            num1 = (int) num3 * -1698587265 ^ -1660879978;
            continue;
          case 13:
            num1 = 1656773360;
            continue;
          case 14:
            num5 = Settings.\u202B‎‪⁬⁫‪‌‭⁬⁭⁭‌⁯⁬‌⁮⁬‌‫‍‌‮‎‪‌‪‌⁮‭​⁯‬⁪⁯‬⁯⁭⁮⁫⁮‮(random, 3, 15);
            num4 = 1;
            num1 = (int) num3 * 861122786 ^ 90993270;
            continue;
          case 15:
            chArray = Settings.\u202C‭‮⁪‭​‭‌⁬⁯‮⁯⁬‌​‍‪‮‪⁭‫‎‭‭‮‍⁬⁫‪‮‌​⁪‪⁮⁭‫​⁫‌‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2401557814U));
            num1 = (int) num3 * 181950602 ^ -1580024307;
            continue;
          case 16:
            ++num6;
            num1 = (int) num3 * 155912152 ^ 903314889;
            continue;
          case 17:
            str3 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(693138702U);
            num1 = (int) num3 * 1541046910 ^ -919937141;
            continue;
          case 18:
            ++num4;
            num1 = (int) num3 * 218626016 ^ -333171862;
            continue;
          case 19:
            str2 = string.Empty;
            num1 = (int) num3 * -2141896050 ^ 1112376049;
            continue;
          case 20:
            num8 = num4 % 2 == 0 ? 1 : 0;
            break;
          case 21:
            int num10 = !flag ? -214470542 : (num10 = -1858369022);
            int num11 = (int) num3 * 1600311923;
            num1 = num10 ^ num11;
            continue;
          case 22:
            int num12;
            num1 = num12 = num4 <= num5 ? 946209545 : (num12 = 2131187476);
            continue;
          case 23:
            if (num6 % 2 != 0)
            {
              num8 = 0;
              break;
            }
            num1 = (int) num3 * 1274280828 ^ -1385680060;
            continue;
          default:
            goto label_28;
        }
        flag = num8 != 0;
        num1 = 729565393;
      }
label_28:
      return str1;
    }

    private void LoadPatterns()
    {
      object settingsLock = Settings.settingsLock;
      bool flag1 = false;
      try
      {
        Settings.\u200E‌‎⁪⁬⁪⁪‮‍‬‭‮‫‪⁫⁯⁯‭‫⁮⁬‫⁬‌‫​‌​‍‏‫‍​​⁪⁪‌‬⁮⁬‮(settingsLock, ref flag1);
        bool flag2 = !Settings.\u206B​‬‏‍⁯‏‫‏​⁯​‎⁮⁮‍‭​⁭⁪⁭‏⁭⁫⁯‪‮‮⁮‎‌⁭‪⁯‫‬‌‫⁮‮‮(this.LayoutsRoot);
label_2:
        int num1 = 1368166364;
        while (true)
        {
          int num2 = 154088637;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1731095855 ^ 294144225;
              continue;
            case 2:
              goto label_2;
            case 3:
              this.LoadDefaultPatterns();
              num1 = 1726929749;
              continue;
            case 4:
              Settings.\u206B⁭‌‍‌‪​‏⁬‌‌⁮‏⁭‎‎⁬‏‍‎‫‬‎‍‭⁫⁪‫‪‫​‏⁫‮‌‏‎‮‌‮(this.LayoutsRoot);
              num1 = (int) num3 * 1790952288 ^ 565007702;
              continue;
            case 5:
              num1 = (int) num3 * 1598558605 ^ -1711737504;
              continue;
            case 6:
              int num4 = flag2 ? 216993649 : (num4 = 1810121451);
              int num5 = (int) num3 * -1191744337;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        using (List<string>.Enumerator enumerator = ((IEnumerable<string>) Settings.\u206C⁭‪⁪‏‎​⁬‭⁪⁫⁭⁪‏⁪‏​‏‎‮​‌⁬⁯⁭‎⁬‏⁫‍‍⁭‎‮⁯‏‪‌⁮‪‮(this.LayoutsRoot, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2923417178U), SearchOption.AllDirectories)).ToList<string>().GetEnumerator())
        {
label_15:
          int num2 = !enumerator.MoveNext() ? 21247839 : (num2 = 1988449024);
          while (true)
          {
            int num3 = 154088637;
            uint num4;
            // ISSUE: variable of a compiler-generated type
            Settings.\u003C\u003Ec__DisplayClass187_0 displayClass1870;
            bool flag3;
            LayoutPattern pattern;
            switch ((num4 = (uint) (num2 ^ num3)) % 17U)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                displayClass1870.layoutFilePath = enumerator.Current;
                num2 = (int) num4 * -814264193 ^ 874322920;
                continue;
              case 1:
                num2 = (int) num4 * -1088594470 ^ -1156727777;
                continue;
              case 2:
                int num5 = flag3 ? -1733056522 : (num5 = -1634598511);
                int num6 = (int) num4 * -205758103;
                num2 = num5 ^ num6;
                continue;
              case 3:
                num2 = 1371778059;
                continue;
              case 5:
                this.Engine.AddPattern(pattern, false);
                num2 = (int) num4 * -589950554 ^ 1804485366;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                Settings.\u202D⁮‪⁪‫‌‎‫‎⁭‫‮‏‮‏‌‭⁪‮⁬‎​‏‌‪‭​‬⁯‬⁫‪⁭‬‫‌⁬⁯‫⁫‮(CoreObject.log, (object) Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(168203724U), displayClass1870.layoutFilePath));
                num2 = 1495251737;
                continue;
              case 7:
                num2 = (int) num4 * -1893289758 ^ -707880417;
                continue;
              case 8:
                // ISSUE: method pointer
                flag3 = !Enumerable.Any<LayoutPattern>((IEnumerable<M0>) this.Engine.Patterns, (Func<M0, bool>) new Func<LayoutPattern, bool>((object) displayClass1870, __methodptr(\u003CLoadPatterns\u003Eb__0)));
                num2 = (int) num4 * 1909535170 ^ -608865480;
                continue;
              case 9:
                num2 = 1672697576;
                continue;
              case 10:
                // ISSUE: reference to a compiler-generated field
                CoreUtils.DeleteFile(displayClass1870.layoutFilePath);
                num2 = (int) num4 * -1294990138 ^ -682625799;
                continue;
              case 11:
                // ISSUE: object of a compiler-generated type is created
                displayClass1870 = new Settings.\u003C\u003Ec__DisplayClass187_0();
                num2 = 529166044;
                continue;
              case 12:
                goto label_15;
              case 13:
                num2 = (int) num4 * 2041810189 ^ -531346844;
                continue;
              case 14:
                num2 = 1988449024;
                continue;
              case 15:
                int num7 = pattern != null ? 1353667187 : (num7 = 1513836177);
                int num8 = (int) num4 * -302015223;
                num2 = num7 ^ num8;
                continue;
              case 16:
                // ISSUE: reference to a compiler-generated field
                pattern = LayoutPattern.LoadPattern(displayClass1870.layoutFilePath);
                num2 = (int) num4 * -1272125900 ^ 716074;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:
        if (this.Engine.ActivePattern != null)
          return;
label_30:
        int num9 = 855694932;
        while (true)
        {
          int num2 = 154088637;
          uint num3;
          switch ((num3 = (uint) (num9 ^ num2)) % 4U)
          {
            case 0:
              goto label_30;
            case 1:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: method pointer
              this.Engine.ActivePattern = (LayoutPattern) Enumerable.FirstOrDefault<LayoutPattern>((IEnumerable<M0>) this.Engine.Patterns, (Func<M0, bool>) (Settings.\u003C\u003Ec.\u003C\u003E9__187_1 ?? (Settings.\u003C\u003Ec.\u003C\u003E9__187_1 = new Func<LayoutPattern, bool>((object) Settings.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CLoadPatterns\u003Eb__187_1)))));
              num9 = 1618191387;
              continue;
            case 2:
              num9 = (int) num3 * 1913684975 ^ -2071327824;
              continue;
            case 3:
              goto label_35;
            default:
              goto label_32;
          }
        }
label_32:
        return;
label_35:;
      }
      finally
      {
        if (flag1)
        {
label_37:
          int num1 = 570377784;
          while (true)
          {
            int num2 = 154088637;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_37;
              case 1:
                Settings.\u206D‫⁪⁯⁬‍⁭⁫⁪⁬‪‬⁮⁯⁬⁬‮‍‍‎​⁯‮⁭‌‎⁪‏⁪‫⁭‬⁫‬​‮⁫​‪‫‮(settingsLock);
                num1 = (int) num3 * -738639212 ^ 382345267;
                continue;
              case 2:
                num1 = (int) num3 * 42321813 ^ -1426347212;
                continue;
              default:
                goto label_42;
            }
          }
        }
label_42:;
      }
    }

    private void LoadDefaultPatterns()
    {
label_1:
      int num1 = -1228670056;
      while (true)
      {
        int num2 = -361553715;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            this.CreateAutoPatternMinimized();
            num1 = (int) num3 * -1166944368 ^ -2033276292;
            continue;
          case 1:
            num1 = (int) num3 * -66566410 ^ -1942417906;
            continue;
          case 2:
            flag = Settings.\u206F‭‭​​⁮‮⁭‮⁬‫‮‏‍‬‭‍‪⁯⁪‬⁫​​⁬‏‭‌‌‌‌‫‏‬‫‬‬⁫‭⁬‮().Length > 2;
            num1 = -1307316871;
            continue;
          case 3:
            num1 = (int) num3 * 1399652510 ^ -459782163;
            continue;
          case 4:
            num1 = (int) num3 * 155481132 ^ -1822540436;
            continue;
          case 5:
            this.CreateAutoPatternPeek();
            num1 = (int) num3 * -295084684 ^ -1051241497;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * 316466080 ^ 956147009;
            continue;
          case 8:
            num1 = (int) num3 * -202970596 ^ -1121036133;
            continue;
          case 9:
            this.CreateAutoPatternFlood();
            num1 = (int) num3 * 268981043 ^ -44352998;
            continue;
          case 10:
            int num4 = Settings.\u206F‭‭​​⁮‮⁭‮⁬‫‮‏‍‬‭‍‪⁯⁪‬⁫​​⁬‏‭‌‌‌‌‫‏‬‫‬‬⁫‭⁬‮().Length <= 1 ? -286674253 : (num4 = -796851174);
            int num5 = (int) num3 * 319853637;
            num1 = num4 ^ num5;
            continue;
          case 11:
            this.CreateAutoPattern2Monitor();
            num1 = (int) num3 * 1414842972 ^ -17065213;
            continue;
          case 12:
            goto label_3;
          case 13:
            this.CreateAutoPatternDocked1Monitor();
            num1 = (int) num3 * 128794011 ^ 936271013;
            continue;
          case 14:
            int num6 = flag ? 1734896646 : (num6 = 1629183635);
            int num7 = (int) num3 * -506898326;
            num1 = num6 ^ num7;
            continue;
          case 15:
            this.CreateAutoPattern3Monitor();
            num1 = (int) num3 * -705671562 ^ -1633429425;
            continue;
          case 16:
            num1 = (int) num3 * -2089599524 ^ -1109749126;
            continue;
          case 17:
            this.CreateAutoPattern1Monitor();
            num1 = (int) num3 * 734131189 ^ -829001349;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_3:;
    }

    private void CreateAutoPatternMinimized()
    {
label_1:
      int num1 = -1205689150;
      while (true)
      {
        int num2 = -111947402;
        uint num3;
        LayoutPattern pattern;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 25U)
        {
          case 0:
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamApp, WindowVisibility.Hide);
            flag = this.Engine.AddPattern(pattern, false);
            num1 = (int) num3 * 82202749 ^ 2114289274;
            continue;
          case 1:
            pattern.AddWindowLayout(ZoomWindowType.ScreenSharingDisabled, WindowVisibility.Close);
            num1 = (int) num3 * -699067763 ^ 875406734;
            continue;
          case 2:
            pattern.Save("");
            num1 = (int) num3 * 1844309350 ^ -144952112;
            continue;
          case 3:
            pattern.PatternName = Resources.AutoPattern1Monitor;
            num1 = (int) num3 * -1797118960 ^ -447828341;
            continue;
          case 4:
            pattern.AddWindowLayout(ZoomWindowType.ManyCamBroadcast, WindowVisibility.Hide);
            num1 = (int) num3 * -83694776 ^ 933313487;
            continue;
          case 5:
            num1 = (int) num3 * -2130993914 ^ 2052727870;
            continue;
          case 6:
            num1 = (int) num3 * 1570574678 ^ 968559154;
            continue;
          case 7:
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamApp, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            num1 = (int) num3 * -1178094363 ^ 1534521506;
            continue;
          case 8:
            pattern.LayoutMode = LayoutMode.Dynamic;
            num1 = (int) num3 * 549485940 ^ -1012374839;
            continue;
          case 9:
            pattern.AddWindowLayout(ZoomWindowType.Sharing, WindowVisibility.Close);
            num1 = (int) num3 * -1217084848 ^ -1829735731;
            continue;
          case 10:
            pattern.StretchingEnabled = this.Engine.Settings.AutoLayoutsDefaultStretchingEnabled;
            num1 = (int) num3 * -931058443 ^ 421647902;
            continue;
          case 11:
            pattern.SecondaryMonitor = Resources.SecondaryMonitor;
            num1 = (int) num3 * -2027903840 ^ 688427459;
            continue;
          case 12:
            pattern.AddWindowLayout(ZoomWindowType.JoinAudio, WindowVisibility.Close);
            num1 = (int) num3 * 1907307587 ^ -1918482513;
            continue;
          case 13:
            pattern.AddWindowLayout(ZoomWindowType.Meeting, WindowVisibility.Hide);
            num1 = (int) num3 * 2030801913 ^ 2026215057;
            continue;
          case 14:
            pattern.AddWindowLayout(ZoomWindowType.Chat, Resources.PrimaryMonitor, ScreenPlacement.SecondTwoQuarters, ScreenPlacement.SecondTwoQuarters, ScreenStretching.Undefined);
            num1 = (int) num3 * -2090028632 ^ 997613278;
            continue;
          case 15:
            pattern = new LayoutPattern();
            pattern.AutoGenerated = true;
            num1 = (int) num3 * 960508447 ^ 1339029107;
            continue;
          case 16:
            goto label_1;
          case 17:
            pattern.AddWindowLayout(ZoomWindowType.ImageHistoryView, WindowVisibility.Close);
            num1 = (int) num3 * 598174784 ^ -2013920431;
            continue;
          case 18:
            int num4 = !flag ? 1103228548 : (num4 = 2062293047);
            int num5 = (int) num3 * 328550122;
            num1 = num4 ^ num5;
            continue;
          case 19:
            pattern.AddWindowLayout(ZoomWindowType.ZoomZoomMain, WindowVisibility.Hide);
            num1 = (int) num3 * -221562296 ^ -1134505893;
            continue;
          case 20:
            pattern.AddWindowLayout(ZoomWindowType.Participants, WindowVisibility.Hide);
            num1 = (int) num3 * 1975885254 ^ 1791525210;
            continue;
          case 21:
            goto label_3;
          case 22:
            pattern.AddWindowLayout(ZoomWindowType.ToolTip, WindowVisibility.Close);
            num1 = (int) num3 * 1330544745 ^ 2022512415;
            continue;
          case 23:
            pattern.PrimaryMonitor = Resources.PrimaryMonitor;
            num1 = (int) num3 * -968697233 ^ -2112390661;
            continue;
          case 24:
            pattern.AddWindowLayout(ZoomWindowType.RequestRecord, WindowVisibility.Close);
            num1 = (int) num3 * 388125561 ^ -1900751450;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return;
label_3:;
    }

    private void CreateAutoPatternDocked1Monitor()
    {
label_1:
      int num1 = -1438397967;
      while (true)
      {
        int num2 = -761140031;
        uint num3;
        LayoutPattern pattern;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            pattern.Save("");
            num1 = (int) num3 * 689843578 ^ 390546377;
            continue;
          case 1:
            pattern.AddWindowLayout(ZoomWindowType.ToolTip, WindowVisibility.Close);
            num1 = (int) num3 * 616743590 ^ 1276231695;
            continue;
          case 2:
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamApp, WindowVisibility.Ignore);
            flag = this.Engine.AddPattern(pattern, false);
            num1 = (int) num3 * 116720781 ^ -190799293;
            continue;
          case 3:
            goto label_1;
          case 4:
            pattern.AddWindowLayout(ZoomWindowType.RequestRecord, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.ScreenSharingDisabled, WindowVisibility.Close);
            num1 = (int) num3 * -912838717 ^ 1042763047;
            continue;
          case 5:
            pattern = new LayoutPattern();
            pattern.AutoGenerated = true;
            num1 = (int) num3 * -1205233123 ^ -605312238;
            continue;
          case 6:
            pattern.AddWindowLayout(ZoomWindowType.Chat, Resources.PrimaryMonitor, ScreenPlacement.FourthQuarter, ScreenPlacement.FourthQuarter, ScreenStretching.Vertical);
            num1 = (int) num3 * -693886100 ^ -1074205213;
            continue;
          case 7:
            int num4 = flag ? -1411139808 : (num4 = -1254295124);
            int num5 = (int) num3 * -1632828707;
            num1 = num4 ^ num5;
            continue;
          case 8:
            pattern.AddWindowLayout(ZoomWindowType.ManyCamApp, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            num1 = (int) num3 * -924833343 ^ 911685838;
            continue;
          case 9:
            goto label_3;
          case 10:
            pattern.AddWindowLayout(ZoomWindowType.JoinAudio, WindowVisibility.Close);
            num1 = (int) num3 * 2099996976 ^ -677729862;
            continue;
          case 11:
            pattern.PrimaryMonitor = Resources.PrimaryMonitor;
            pattern.SecondaryMonitor = Resources.SecondaryMonitor;
            num1 = (int) num3 * 555297863 ^ -466453053;
            continue;
          case 12:
            pattern.AddWindowLayout(ZoomWindowType.Meeting, Resources.PrimaryMonitor, ScreenPlacement.FirstThreeQuarters, ScreenPlacement.Full, ScreenStretching.Horizontal);
            num1 = (int) num3 * -247565189 ^ -1922015224;
            continue;
          case 13:
            pattern.AddWindowLayout(ZoomWindowType.Participants, WindowVisibility.Ignore);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamBroadcast, WindowVisibility.Ignore);
            num1 = (int) num3 * -880079774 ^ -388088920;
            continue;
          case 14:
            pattern.AddWindowLayout(ZoomWindowType.Sharing, WindowVisibility.Close);
            num1 = (int) num3 * -1362408483 ^ -1566955739;
            continue;
          case 15:
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            num1 = (int) num3 * 316952548 ^ -159792550;
            continue;
          case 16:
            num1 = (int) num3 * -1942373929 ^ 1905026458;
            continue;
          case 17:
            num1 = (int) num3 * 906428414 ^ -1030372839;
            continue;
          case 18:
            num1 = (int) num3 * 1280089435 ^ 1599223387;
            continue;
          case 19:
            pattern.LayoutMode = LayoutMode.Dynamic;
            pattern.StretchingEnabled = this.Engine.Settings.AutoLayoutsDefaultStretchingEnabled;
            num1 = (int) num3 * -1104671062 ^ 18005672;
            continue;
          case 20:
            pattern.PatternName = Settings.\u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮(Resources.AutoPattern1Monitor, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3339055056U));
            num1 = (int) num3 * -1944883122 ^ 2071486423;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return;
label_3:;
    }

    private void CreateAutoPattern3Monitor()
    {
label_1:
      int num1 = 1824996347;
      while (true)
      {
        int num2 = 1431161454;
        uint num3;
        LayoutPattern pattern;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            pattern.LayoutMode = LayoutMode.Dynamic;
            num1 = (int) num3 * 135243838 ^ 1184095328;
            continue;
          case 1:
            num1 = (int) num3 * 987857770 ^ -287374239;
            continue;
          case 2:
            pattern.AddWindowLayout(ZoomWindowType.Meeting, Resources.PrimaryMonitor, ScreenPlacement.Full, ScreenPlacement.Full, ScreenStretching.Undefined);
            num1 = (int) num3 * 1064135290 ^ 1876956451;
            continue;
          case 3:
            pattern.PrimaryMonitor = Resources.PrimaryMonitor;
            pattern.SecondaryMonitor = Resources.SecondaryMonitor;
            num1 = (int) num3 * -1586926429 ^ 1570966623;
            continue;
          case 4:
            pattern.AddWindowLayout(ZoomWindowType.ManyCamBroadcast, Resources.SecondaryMonitor, ScreenPlacement.SecondHalf, ScreenPlacement.SecondHalf, ScreenStretching.Vertical);
            num1 = (int) num3 * 528055433 ^ -2076834892;
            continue;
          case 5:
            pattern.AddWindowLayout(ZoomWindowType.ScreenSharingDisabled, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Sharing, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Participants, WindowVisibility.Ignore);
            pattern.Save("");
            this.Engine.AddPattern(pattern, false);
            num1 = (int) num3 * -351324520 ^ 2229038;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -2124619066 ^ -1928269385;
            continue;
          case 8:
            pattern.StretchingEnabled = this.Engine.Settings.AutoLayoutsDefaultStretchingEnabled;
            num1 = (int) num3 * 589492882 ^ 1355440089;
            continue;
          case 9:
            pattern.PatternName = Resources.AutoPattern3Monitors;
            num1 = (int) num3 * -1115368254 ^ 694491081;
            continue;
          case 10:
            goto label_3;
          case 11:
            pattern = new LayoutPattern();
            pattern.AutoGenerated = true;
            num1 = (int) num3 * 1826530272 ^ 1668242694;
            continue;
          case 12:
            pattern.AddWindowLayout(ZoomWindowType.ImageHistoryView, Resources.ThirdMonitor, ScreenPlacement.Full, ScreenPlacement.Full, ScreenStretching.Undefined);
            pattern.AddWindowLayout(ZoomWindowType.ToolTip, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.JoinAudio, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.RequestRecord, WindowVisibility.Close);
            num1 = (int) num3 * 1710254822 ^ -2076881057;
            continue;
          case 13:
            pattern.AddWindowLayout(ZoomWindowType.Chat, Resources.SecondaryMonitor, ScreenPlacement.FirstHalf, ScreenPlacement.Full, ScreenStretching.Undefined);
            pattern.AddWindowLayout(ZoomWindowType.DualVideo, Resources.SecondaryMonitor, ScreenPlacement.SecondHalf, ScreenPlacement.FirstHalf, ScreenStretching.Vertical);
            num1 = (int) num3 * 2139819198 ^ 1521156464;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    private void CreateAutoPattern2Monitor()
    {
      LayoutPattern pattern = new LayoutPattern();
label_1:
      int num1 = 810943142;
      while (true)
      {
        int num2 = 1898318781;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            pattern.AddWindowLayout(ZoomWindowType.DualVideo, Resources.SecondaryMonitor, ScreenPlacement.SecondHalf, ScreenPlacement.FirstHalf, ScreenStretching.Vertical);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamBroadcast, Resources.SecondaryMonitor, ScreenPlacement.SecondHalf, ScreenPlacement.SecondHalf, ScreenStretching.Vertical);
            num1 = (int) num3 * 477644112 ^ -70904621;
            continue;
          case 1:
            pattern.LayoutMode = LayoutMode.Dynamic;
            num1 = (int) num3 * 424332588 ^ -1353142482;
            continue;
          case 2:
            pattern.PatternName = Resources.AutoPattern2Monitors;
            num1 = (int) num3 * 837128337 ^ -1576780337;
            continue;
          case 3:
            pattern.AutoGenerated = true;
            num1 = (int) num3 * 587625328 ^ -2114237440;
            continue;
          case 4:
            pattern.AddWindowLayout(ZoomWindowType.ToolTip, WindowVisibility.Close);
            num1 = (int) num3 * -1401977082 ^ -1867099705;
            continue;
          case 5:
            pattern.SecondaryMonitor = Resources.SecondaryMonitor;
            num1 = (int) num3 * 204764206 ^ 663310635;
            continue;
          case 6:
            pattern.AddWindowLayout(ZoomWindowType.ScreenSharingDisabled, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Sharing, WindowVisibility.Close);
            num1 = (int) num3 * -955104361 ^ 2034421752;
            continue;
          case 7:
            pattern.AddWindowLayout(ZoomWindowType.ManyCamApp, WindowVisibility.Ignore);
            pattern.AddWindowLayout(ZoomWindowType.ImageHistoryView, WindowVisibility.Ignore);
            pattern.Save("");
            this.Engine.AddPattern(pattern, false);
            num1 = (int) num3 * 481564742 ^ 1464848356;
            continue;
          case 8:
            pattern.AddWindowLayout(ZoomWindowType.JoinAudio, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.RequestRecord, WindowVisibility.Close);
            num1 = (int) num3 * 1329767165 ^ -20207619;
            continue;
          case 9:
            pattern.PrimaryMonitor = Resources.PrimaryMonitor;
            num1 = (int) num3 * 1278612069 ^ 1293778417;
            continue;
          case 10:
            goto label_1;
          case 11:
            pattern.StretchingEnabled = this.Engine.Settings.AutoLayoutsDefaultStretchingEnabled;
            num1 = (int) num3 * 1635815727 ^ 1281600008;
            continue;
          case 12:
            num1 = (int) num3 * -1702026132 ^ 1941702506;
            continue;
          case 13:
            pattern.AddWindowLayout(ZoomWindowType.Meeting, Resources.PrimaryMonitor, ScreenPlacement.Full, ScreenPlacement.Full, ScreenStretching.Undefined);
            pattern.AddWindowLayout(ZoomWindowType.Chat, Resources.SecondaryMonitor, ScreenPlacement.FirstHalf, ScreenPlacement.Full, ScreenStretching.Undefined);
            num1 = (int) num3 * -396541395 ^ 925673276;
            continue;
          case 14:
            num1 = (int) num3 * 1945894182 ^ -1799868970;
            continue;
          case 15:
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            num1 = (int) num3 * -1702773019 ^ -1860111118;
            continue;
          case 16:
            pattern.AddWindowLayout(ZoomWindowType.Participants, WindowVisibility.Ignore);
            num1 = (int) num3 * -112553826 ^ 386455304;
            continue;
          case 17:
            goto label_3;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_3:;
    }

    private void CreateAutoPatternPeek()
    {
label_1:
      int num1 = -1049078302;
      while (true)
      {
        int num2 = -5417786;
        uint num3;
        LayoutPattern pattern;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            pattern.AddWindowLayout(ZoomWindowType.Participants, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.JoinAudio, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Sharing, WindowVisibility.Close);
            num1 = (int) num3 * 1951955851 ^ -2051630916;
            continue;
          case 1:
            pattern.Save("");
            this.Engine.AddPattern(pattern, false);
            num1 = (int) num3 * 181225341 ^ 886374300;
            continue;
          case 2:
            pattern.AddWindowLayout(ZoomWindowType.Chat, WindowVisibility.Close);
            num1 = (int) num3 * -475046924 ^ 1370304562;
            continue;
          case 3:
            goto label_1;
          case 4:
            pattern = new LayoutPattern();
            pattern.AutoGenerated = true;
            pattern.LayoutMode = LayoutMode.Dynamic;
            num1 = (int) num3 * -1982001503 ^ -689200473;
            continue;
          case 5:
            pattern.PatternName = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3303702501U);
            pattern.PrimaryMonitor = Resources.PrimaryMonitor;
            num1 = (int) num3 * -169897884 ^ 1542789818;
            continue;
          case 6:
            pattern.AddWindowLayout(ZoomWindowType.RequestRemoteControl, WindowVisibility.Close);
            num1 = (int) num3 * 1707168205 ^ -461699741;
            continue;
          case 7:
            goto label_3;
          case 8:
            num1 = (int) num3 * -930746647 ^ 1790514656;
            continue;
          case 9:
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            num1 = (int) num3 * 1340709562 ^ 1207839020;
            continue;
          case 10:
            pattern.AddWindowLayout(ZoomWindowType.ScreenShareOptions, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.RequestRecord, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Rename, WindowVisibility.Close);
            num1 = (int) num3 * -1197075619 ^ 1631801922;
            continue;
          case 11:
            pattern.AddWindowLayout(ZoomWindowType.Settings, WindowVisibility.Close);
            num1 = (int) num3 * -202229643 ^ -1087456848;
            continue;
          case 12:
            pattern.AddWindowLayout(ZoomWindowType.AudioNotification, WindowVisibility.Close);
            num1 = (int) num3 * -636322299 ^ -377474137;
            continue;
          case 13:
            pattern.AddWindowLayout(ZoomWindowType.DualVideo, WindowVisibility.Hide);
            num1 = (int) num3 * 871636332 ^ -1369891885;
            continue;
          case 14:
            pattern.StretchingEnabled = this.Engine.Settings.AutoLayoutsDefaultStretchingEnabled;
            num1 = (int) num3 * -1891309623 ^ 683760023;
            continue;
          case 15:
            pattern.AddWindowLayout(ZoomWindowType.Meeting, Resources.PrimaryMonitor, ScreenPlacement.Full, ScreenPlacement.Full, ScreenStretching.Undefined);
            num1 = (int) num3 * -1973287213 ^ 816032489;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return;
label_3:;
    }

    private void CreateAutoPatternFlood()
    {
      LayoutPattern pattern = new LayoutPattern();
label_1:
      int num1 = -2060560456;
      while (true)
      {
        int num2 = -423128649;
        uint num3;
        ZoomButton button1;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            ZoomButton button2 = new ZoomButton();
            int num4 = 1;
            button2.AutoGenerated = num4 != 0;
            int num5 = 460;
            button2.ButtonX = num5;
            int num6 = 575;
            button2.ButtonY = num6;
            int num7 = 610;
            button2.WindowHeight = num7;
            int num8 = 600;
            button2.WindowWidth = num8;
            int num9 = 5;
            button2.ResultingWindowType = (ZoomWindowType) num9;
            string str1 = "";
            button2.MeetingId = str1;
            this.Engine.AddButton(button2);
            num1 = (int) num3 * 1765010612 ^ 1006600823;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.Engine.AddPattern(pattern, false);
            num1 = (int) num3 * 827028388 ^ 685038074;
            continue;
          case 3:
            pattern.PatternName = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1282045753U);
            num1 = (int) num3 * 1992426436 ^ 1867724435;
            continue;
          case 4:
            pattern.AddWindowLayout(ZoomWindowType.Participants, Resources.PrimaryMonitor, 605, 405, 300, 300);
            pattern.AddWindowLayout(ZoomWindowType.JoinAudio, WindowVisibility.Close);
            num1 = (int) num3 * 1971221764 ^ 2102733486;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.Engine.AddButton(button1);
            num1 = (int) num3 * -1241780945 ^ 1738614117;
            continue;
          case 7:
            pattern.AddWindowLayout(ZoomWindowType.RequestRecord, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Rename, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.RequestRemoteControl, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.Settings, WindowVisibility.Close);
            num1 = (int) num3 * -1160016154 ^ 397429650;
            continue;
          case 8:
            pattern.PrimaryMonitor = Resources.PrimaryMonitor;
            num1 = (int) num3 * -1462767026 ^ -145392679;
            continue;
          case 9:
            pattern.AddWindowLayout(ZoomWindowType.DualVideo, WindowVisibility.Hide);
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            num1 = (int) num3 * 829630994 ^ 1102808695;
            continue;
          case 10:
            pattern.StretchingEnabled = false;
            num1 = (int) num3 * 1851829569 ^ 2067147237;
            continue;
          case 11:
            ZoomButton zoomButton = new ZoomButton();
            int num10 = 1;
            zoomButton.AutoGenerated = num10 != 0;
            int num11 = 300;
            zoomButton.ButtonX = num11;
            int num12 = 575;
            zoomButton.ButtonY = num12;
            int num13 = 610;
            zoomButton.WindowHeight = num13;
            int num14 = 600;
            zoomButton.WindowWidth = num14;
            int num15 = 6;
            zoomButton.ResultingWindowType = (ZoomWindowType) num15;
            string str2 = "";
            zoomButton.MeetingId = str2;
            button1 = zoomButton;
            num1 = (int) num3 * 1017892594 ^ -1478311481;
            continue;
          case 12:
            pattern.AddWindowLayout(ZoomWindowType.Meeting, Resources.PrimaryMonitor, 0, 0, 600, 610);
            pattern.AddWindowLayout(ZoomWindowType.Chat, Resources.PrimaryMonitor, 605, 0, 300, 400);
            pattern.AddWindowLayout(ZoomWindowType.AudioNotification, WindowVisibility.Close);
            num1 = (int) num3 * 633745065 ^ -1903793096;
            continue;
          case 13:
            pattern.LayoutMode = LayoutMode.Static;
            num1 = (int) num3 * 837661267 ^ -654305623;
            continue;
          case 14:
            pattern.Save("");
            num1 = (int) num3 * 36711764 ^ -499251459;
            continue;
          case 15:
            pattern.AddWindowLayout(ZoomWindowType.Sharing, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.ScreenShareOptions, WindowVisibility.Close);
            num1 = (int) num3 * -1461478451 ^ -1028284181;
            continue;
          case 16:
            num1 = (int) num3 * -1791932668 ^ 702947107;
            continue;
          case 17:
            pattern.AutoGenerated = true;
            num1 = (int) num3 * -1626910512 ^ 694590036;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_3:;
    }

    private void CreateAutoPattern1Monitor()
    {
      LayoutPattern pattern = new LayoutPattern();
label_1:
      int num1 = -2071973805;
      while (true)
      {
        int num2 = -1624122586;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 29U)
        {
          case 0:
            pattern.LayoutMode = LayoutMode.Dynamic;
            num1 = (int) num3 * -2016501387 ^ 1167064093;
            continue;
          case 1:
            pattern.SecondaryMonitor = Resources.SecondaryMonitor;
            num1 = (int) num3 * -973943231 ^ 1326630147;
            continue;
          case 2:
            num1 = (int) num3 * 1710489746 ^ -799780014;
            continue;
          case 3:
            pattern.PatternName = Resources.AutoPattern1Monitor;
            num1 = (int) num3 * -1379524593 ^ -15043129;
            continue;
          case 4:
            pattern.Save("");
            num1 = (int) num3 * -399717319 ^ -981577164;
            continue;
          case 5:
            pattern.AddWindowLayout(ZoomWindowType.Sharing, WindowVisibility.Close);
            num1 = (int) num3 * -993353605 ^ 1408758891;
            continue;
          case 6:
            pattern.PrimaryMonitor = Resources.PrimaryMonitor;
            num1 = (int) num3 * -257673200 ^ -258509135;
            continue;
          case 7:
            pattern.AddWindowLayout(ZoomWindowType.ZoomZoomMain, Resources.PrimaryMonitor, ScreenPlacement.Full, ScreenPlacement.Full, ScreenStretching.Fill);
            num1 = (int) num3 * -1054331450 ^ -576430987;
            continue;
          case 8:
            num1 = (int) num3 * -220593800 ^ 2054082854;
            continue;
          case 9:
            pattern.DockEngineView = true;
            num1 = (int) num3 * 2145912023 ^ 1529990303;
            continue;
          case 10:
            pattern.AddWindowLayout(ZoomWindowType.Invite, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamApp, WindowVisibility.Close);
            num1 = (int) num3 * 1311342455 ^ -797934768;
            continue;
          case 11:
            pattern.AddWindowLayout(ZoomWindowType.Rename, WindowVisibility.Close);
            pattern.AddWindowLayout(ZoomWindowType.ToolTip, WindowVisibility.Close);
            num1 = (int) num3 * 832865773 ^ -161015700;
            continue;
          case 12:
            pattern.AddWindowLayout(ZoomWindowType.Participants, Resources.PrimaryMonitor, ScreenPlacement.ThirdThird, ScreenPlacement.SecondThird, ScreenStretching.Vertical);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamBroadcast, WindowVisibility.Ignore);
            num1 = (int) num3 * -1834354761 ^ 467207323;
            continue;
          case 13:
            pattern.DockEdge = WindowEdge.Top;
            num1 = (int) num3 * 918337241 ^ -911983974;
            continue;
          case 14:
            pattern.AddWindowLayout(ZoomWindowType.JoinAudio, WindowVisibility.Close);
            num1 = (int) num3 * -785017846 ^ -1682651029;
            continue;
          case 15:
            int num4 = !this.Engine.AddPattern(pattern, false) ? 346918753 : (num4 = 1408868829);
            int num5 = (int) num3 * -1221945425;
            num1 = num4 ^ num5;
            continue;
          case 16:
            num1 = (int) num3 * 361481486 ^ 1416186607;
            continue;
          case 17:
            pattern.AddWindowLayout(ZoomWindowType.ScreenSharingDisabled, WindowVisibility.Close);
            num1 = (int) num3 * -1963299708 ^ 640314405;
            continue;
          case 18:
            goto label_1;
          case 19:
            num1 = (int) num3 * -1277261572 ^ -1363537915;
            continue;
          case 20:
            goto label_3;
          case 21:
            pattern.AutoGenerated = true;
            num1 = (int) num3 * 969315944 ^ 231439023;
            continue;
          case 22:
            pattern.AddWindowLayout(ZoomWindowType.ImageHistoryView, Resources.PrimaryMonitor, ScreenPlacement.ThirdThird, ScreenPlacement.ThirdThird, ScreenStretching.Vertical);
            pattern.AddWindowLayout(ZoomWindowType.ManyCamApp, WindowVisibility.Ignore);
            num1 = (int) num3 * -1965556216 ^ -1006565121;
            continue;
          case 23:
            pattern.AddWindowLayout(ZoomWindowType.Chat, Resources.PrimaryMonitor, ScreenPlacement.ThirdThird, ScreenPlacement.FirstThird, ScreenStretching.Vertical);
            num1 = (int) num3 * -2098280108 ^ -207273707;
            continue;
          case 24:
            pattern.StretchingEnabled = this.Engine.Settings.AutoLayoutsDefaultStretchingEnabled;
            num1 = (int) num3 * -466257583 ^ 1312040922;
            continue;
          case 25:
            pattern.AddWindowLayout(ZoomWindowType.Meeting, Resources.PrimaryMonitor, ScreenPlacement.FirstTwoThirds, ScreenPlacement.Full, ScreenStretching.Horizontal);
            num1 = (int) num3 * 2087834317 ^ 946207670;
            continue;
          case 26:
            pattern.AddWindowLayout(ZoomWindowType.RequestRecord, WindowVisibility.Close);
            num1 = (int) num3 * 461314555 ^ 1773415753;
            continue;
          case 27:
            pattern.DockTarget = ZoomWindowType.Meeting;
            num1 = (int) num3 * 152313305 ^ -606469625;
            continue;
          case 28:
            num1 = (int) num3 * 1778040422 ^ -503270666;
            continue;
          default:
            goto label_31;
        }
      }
label_31:
      return;
label_3:;
    }

    private void GetZoomNames()
    {
label_1:
      int num1 = 110993214;
      while (true)
      {
        int num2 = 483210431;
        uint num3;
        string sZoomName;
        string sZoomEmail;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            ZoomZoom.Properties.Settings.Default._App_ZoomUName = sZoomName;
            ZoomZoom.Properties.Settings.Default._App_ZoomEName = sZoomEmail;
            this.userName = sZoomName;
            num1 = (int) num3 * 1481127120 ^ 503261888;
            continue;
          case 1:
            sZoomName = string.Empty;
            num1 = (int) num3 * -75498355 ^ 1923446996;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            sZoomEmail = string.Empty;
            int num4 = this.Engine.ZoomDatabase.GetZoomNames(out sZoomName, out sZoomEmail) ? -1620877324 : (num4 = -1796732636);
            int num5 = (int) num3 * 1660521198;
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

    private void LoadGreetings()
    {
label_1:
      int num1 = -1184554092;
      while (true)
      {
        int num2 = -1826863062;
        uint num3;
        MessageCategory category;
        switch ((num3 = (uint) (num1 ^ num2)) % 32U)
        {
          case 0:
            num1 = (int) num3 * 1978858283 ^ 1327081694;
            continue;
          case 1:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2630403314U)));
            num1 = (int) num3 * -1507535092 ^ -1588562431;
            continue;
          case 2:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1955775337U)));
            num1 = (int) num3 * 1390861614 ^ 606098731;
            continue;
          case 3:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2618644285U)));
            num1 = (int) num3 * -1661363212 ^ 482126100;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * -1141679283 ^ -285730432;
            continue;
          case 6:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3554789639U)));
            num1 = (int) num3 * -1187525758 ^ -814136888;
            continue;
          case 7:
            num1 = (int) num3 * -223932884 ^ 109947734;
            continue;
          case 8:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1965694343U)));
            num1 = (int) num3 * -315366969 ^ -1849262210;
            continue;
          case 9:
            num1 = (int) num3 * -1358286768 ^ -373142167;
            continue;
          case 10:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4165613267U)));
            num1 = (int) num3 * 1244609556 ^ 2042089625;
            continue;
          case 11:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(899934372U)));
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(403547792U)));
            num1 = (int) num3 * -1021376438 ^ -210226933;
            continue;
          case 12:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1092064733U)));
            num1 = (int) num3 * -1691092553 ^ 412491908;
            continue;
          case 13:
            num1 = (int) num3 * -1074422740 ^ -1933116537;
            continue;
          case 14:
            num1 = (int) num3 * 60599532 ^ -1857923898;
            continue;
          case 15:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2572682683U)));
            num1 = (int) num3 * -1407252287 ^ -69829030;
            continue;
          case 16:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3161517051U)));
            num1 = (int) num3 * -227435996 ^ 2140117558;
            continue;
          case 17:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2018877257U)));
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(142740941U)));
            num1 = (int) num3 * 2182102 ^ 1170057753;
            continue;
          case 18:
            goto label_1;
          case 19:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2064935980U)));
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1110921115U)));
            num1 = (int) num3 * -62826318 ^ 1026682060;
            continue;
          case 20:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(963002177U)));
            num1 = (int) num3 * -1260733062 ^ -1385096277;
            continue;
          case 21:
            Settings.greetings = new List<MessageContent>();
            num1 = (int) num3 * -1773632220 ^ 882804415;
            continue;
          case 22:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(38959020U)));
            num1 = (int) num3 * -1051650875 ^ 1441236349;
            continue;
          case 23:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2064035961U)));
            num1 = (int) num3 * 2025609183 ^ 524196091;
            continue;
          case 24:
            num1 = (int) num3 * 928077792 ^ -2134012064;
            continue;
          case 25:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1655216594U)));
            num1 = (int) num3 * -17705705 ^ -356833291;
            continue;
          case 26:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3849744080U)));
            num1 = (int) num3 * 880499723 ^ 1003991491;
            continue;
          case 27:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(699317461U)));
            num1 = (int) num3 * -1548577446 ^ -222160201;
            continue;
          case 28:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1640334778U)));
            num1 = (int) num3 * 834097173 ^ -1378486837;
            continue;
          case 29:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3479989550U)));
            num1 = (int) num3 * -963595322 ^ -320214926;
            continue;
          case 30:
            category = new MessageCategory(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1104349078U));
            num1 = (int) num3 * 871178665 ^ -359628815;
            continue;
          case 31:
            Settings.greetings.Add(new MessageContent(category, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1510230535U)));
            num1 = (int) num3 * -2119383956 ^ -347639944;
            continue;
          default:
            goto label_34;
        }
      }
label_34:
      return;
label_3:;
    }

    internal string GetRandomGreeting()
    {
label_1:
      int num1 = -1906641753;
      object settingsLock;
      string str1;
      Random random;
      while (true)
      {
        int num2 = -1933809921;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            settingsLock = Settings.settingsLock;
            num1 = (int) num3 * -236584287 ^ -1395405659;
            continue;
          case 1:
            random = new Random(DateTime.Now.Millisecond);
            num1 = (int) num3 * -304357989 ^ -289821119;
            continue;
          case 2:
            goto label_1;
          case 4:
            str1 = string.Empty;
            num1 = (int) num3 * -27746495 ^ -428835822;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag = false;
      try
      {
        Monitor.Enter(settingsLock, ref flag);
        str1 = Settings.greetings[random.Next(0, Settings.greetings.Count - 1)].ContentText;
      }
      finally
      {
        if (flag)
        {
label_9:
          int num2 = -1470833010;
          while (true)
          {
            int num3 = -1933809921;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_9;
              case 1:
                Monitor.Exit(settingsLock);
                num2 = (int) num4 * 1008547844 ^ 2101802904;
                continue;
              case 3:
                num2 = (int) num4 * -1443609838 ^ -1931945597;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
      string str2 = str1;
label_15:
      int num5 = -489511896;
      while (true)
      {
        int num2 = -1933809921;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_15;
          case 2:
            num5 = (int) num3 * -1399083799 ^ -746989826;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return str2;
    }

    internal void AddName(string name)
    {
label_1:
      int num1 = -366190614;
      object settingsLock;
      while (true)
      {
        int num2 = -1665364037;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            settingsLock = Settings.settingsLock;
            num1 = (int) num3 * -2009970998 ^ 1581360355;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
        Settings.\u200E‌‎⁪⁬⁪⁪‮‍‬‭‮‫‪⁫⁯⁯‭‫⁮⁬‫⁬‌‫​‌​‍‏‫‍​​⁪⁪‌‬⁮⁬‮(settingsLock, ref flag1);
label_6:
        int num2 = -1309909030;
        while (true)
        {
          int num3 = -1665364037;
          uint num4;
          bool flag2;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              goto label_6;
            case 1:
              num2 = (int) num4 * 16829165 ^ -390555419;
              continue;
            case 2:
              num2 = (int) num4 * 1095066196 ^ 2144686108;
              continue;
            case 3:
              if (this.Names.Contains(name))
              {
                num5 = 0;
                break;
              }
              num2 = (int) num4 * -236367326 ^ 1832787;
              continue;
            case 4:
              num2 = (int) num4 * 304579838 ^ -1956838871;
              continue;
            case 5:
              int num6 = flag2 ? 572738786 : (num6 = 1237438969);
              int num7 = (int) num4 * -41136671;
              num2 = num6 ^ num7;
              continue;
            case 6:
              num5 = !Settings.\u206C⁬‎‌⁯⁫⁮⁪‪‍⁬⁬‪⁯‭​⁬⁫‏‏‪⁯⁭⁭‭‭‎⁪‏‬‌‭⁭‬⁬‏⁮​‪‬‮(Settings.\u202B⁫‫‪⁭⁮‮‮⁭‏‍⁬​⁮‎⁫⁭⁬⁬‏​‍‭‍‫‍‏⁯‌​‎​‬⁫‮⁮⁯‭‎‪‮(name), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3474248529U)) ? 1 : 0;
              break;
            case 7:
              goto label_21;
            default:
              goto label_17;
          }
          flag2 = num5 != 0;
          num2 = -726611978;
        }
label_17:
        return;
label_21:;
      }
      finally
      {
        if (flag1)
        {
label_19:
          int num2 = -433582719;
          while (true)
          {
            int num3 = -1665364037;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_19;
              case 2:
                Settings.\u206D‫⁪⁯⁬‍⁭⁫⁪⁬‪‬⁮⁯⁬⁬‮‍‍‎​⁯‮⁭‌‎⁪‏⁪‫⁭‬⁫‬​‮⁫​‪‫‮(settingsLock);
                num2 = (int) num4 * -25284204 ^ 1769015516;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
    }

    internal string GetRandomName()
    {
      if (this.Names.Count != 0)
        goto label_7;
label_1:
      int num1 = -367127461;
label_2:
      string name;
      DateTime now;
      while (true)
      {
        int num2 = -441210616;
        uint num3;
        Random random;
        int index;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            index = random.Next(this.Names.Count);
            num1 = (int) num3 * -2125265921 ^ -749215113;
            continue;
          case 2:
            num1 = (int) num3 * 1114770845 ^ 729448724;
            continue;
          case 3:
            name = this.Names[index];
            num1 = (int) num3 * 1714759263 ^ 1554817705;
            continue;
          case 4:
            this.Names.AddRange((IEnumerable<string>) new List<string>()
            {
              \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2709038486U),
              \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2237731380U),
              \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3814857370U),
              \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3373179573U),
              \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2496737885U),
              \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1823607279U)
            });
            num1 = (int) num3 * -1183374557 ^ 1428379419;
            continue;
          case 5:
            num1 = (int) num3 * -1439901099 ^ -1045962659;
            continue;
          case 6:
            random = new Random(now.Millisecond);
            num1 = (int) num3 * 467025598 ^ 1469535958;
            continue;
          case 7:
            goto label_7;
          default:
            goto label_10;
        }
      }
label_10:
      return name;
label_7:
      now = DateTime.Now;
      num1 = -625886580;
      goto label_2;
    }

    static string \u200E‏‬‪⁪‫‌‪⁯‮​⁬⁯‫‪⁮⁯⁯‌⁭⁫‪‫‏‪‪‌⁮‬⁮‏‍‪​⁯⁫⁯​⁯‫‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static void \u200F‬⁬‏⁭⁭⁪⁮‪‎‪‏⁫‍‎⁬⁯⁫‌‎‭‮‮‫⁮‌‎‎‮‫⁯‏⁫⁮⁮⁪⁭‏⁫‏‮([In] SettingsBase obj0)
    {
      obj0.Save();
    }

    static string \u200E‎‎‭‍‮‮‍⁯‪⁪⁪‍​‏⁪‪‮‌⁬‎⁭‌‏⁫⁪‎‬‭‏⁮‮⁫‭‎⁮‪‍⁬⁫‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static void \u200D‍⁬‫‬‮⁮​‫‎⁪⁮‌‌‎‭⁫‭⁭‫⁭‎‎⁬‭‮‍​‏‎‍⁮‫⁫⁫‬⁯‮‫⁮‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static string[] \u206C‫‭‭‪⁪⁭‫‬⁯‌⁪‭‪‮‪‮⁭‫‬⁭⁯⁮‎‌⁪⁪‎‍⁮‫‮⁭‬‭‍⁮⁯⁫⁫‮([In] string obj0, [In] char[] obj1)
    {
      return obj0.Split(obj1);
    }

    static void \u202D⁮‪⁪‫‌‎‫‎⁭‫‮‏‮‏‌‭⁪‮⁬‎​‏‌‪‭​‬⁯‬⁫‪⁭‬‫‌⁬⁯‫⁫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static bool \u206C‫‎‌‏‮⁪‫‍‮‏‭⁬‭‪⁯‫‎‎‬‏‬‌‏⁯⁯‬‪⁬​​‮⁮‫⁪‎‮‪‏⁭‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static string \u206D‪‫⁪⁭‎​‭‏‪⁭⁯‫‬⁪‫⁫⁯⁬⁯‭‫⁬⁬‮⁬⁫‎⁪‌​‪‎‭‏‮⁮‎‍‭‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static bool \u206B⁯‭‬‏⁫⁮‍‌‏⁪⁯‏⁯⁪‍‏‮⁭‭‪​⁫⁯‎⁯‫⁫⁮‎⁭‭‎‌⁬‌⁯⁯⁫⁪‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u200B‍‏‬⁭‌⁪‏‏⁮‎⁭‏‭‭‭‏‭‬‏‫​⁫‪⁬‍‪⁮‫‏⁬⁪‫‍‍‮‎‭⁭⁪‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static void \u200E‌‎⁪⁬⁪⁪‮‍‬‭‮‫‪⁫⁯⁯‭‫⁮⁬‫⁬‌‫​‌​‍‏‫‍​​⁪⁪‌‬⁮⁬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206D‫⁪⁯⁬‍⁭⁫⁪⁬‪‬⁮⁯⁬⁬‮‍‍‎​⁯‮⁭‌‎⁪‏⁪‫⁭‬⁫‬​‮⁫​‪‫‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static Screen[] \u206F‭‭​​⁮‮⁭‮⁬‫‮‏‍‬‭‍‪⁯⁪‬⁫​​⁬‏‭‌‌‌‌‫‏‬‫‬‬⁫‭⁬‮()
    {
      return Screen.AllScreens;
    }

    static bool \u200C​‌‏⁬⁫‌‍​⁯⁭‬⁫⁬⁮‭‪‬‎⁭⁬‮‏‎⁭‎‎⁪​⁪‎‪⁯⁬‌⁫⁮⁫⁭‪‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static bool \u206C⁬‎‌⁯⁫⁮⁪‪‍⁬⁬‪⁯‭​⁬⁫‏‏‪⁯⁭⁭‭‭‎⁪‏‬‌‭⁭‬⁬‏⁮​‪‬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static int \u206B⁮‫⁭‪‭‮⁪‎⁪‬⁬‬⁪⁫⁭⁭⁬‫​‌‬‎⁯⁫‎⁪‮‍⁭‌‏‏‭‏​‮‫‌⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0.IndexOf(obj1);
    }

    static string \u202A⁫⁭‫⁬⁬‍⁪‏⁭⁯‌‌‮‎‬‭‍‎⁭​‪‮​‪⁪⁬‎⁪‌‭‌‮​‏⁪⁯‮⁭‪‮([In] string obj0, [In] int obj1)
    {
      return obj0.Substring(obj1);
    }

    static Screen \u202A⁭‏​‎⁮‬‏‏​⁪⁯​‪‭‫‪‭⁯‫⁬‫‪‭‎‪‏⁬‌⁬‏‫​‫‭⁪⁭‭‏⁭‮()
    {
      return Screen.PrimaryScreen;
    }

    static string \u202B​⁭‍‌‬⁪⁪⁫‌‬⁭⁬‭‭‬‌‫⁫‪‪‍‪⁪‭⁯‎⁪⁮⁬⁫⁫⁯‬⁪⁯‎⁭⁯‫‮([In] Screen obj0)
    {
      return obj0.DeviceName;
    }

    static bool \u206F⁮⁪‭⁬⁬⁫‎⁭‎‬⁪⁫‫‏⁭‌‏⁮‌‫‌⁭‬‎‭‮⁬​⁬‮⁪⁭‬‌‎‫⁮‏‌‮([In] string obj0, [In] string obj1)
    {
      return obj0.EndsWith(obj1);
    }

    static int \u206D‎⁬⁭‫⁭‪‫‍⁯‪‬⁯​‎‍⁯‭⁯‪‫‪‭⁫‌‏⁭‌⁭‮⁫⁪⁪⁮‮‬‫⁪‬‮‮([In] string obj0)
    {
      return obj0.Length;
    }

    static string \u206A⁫‎⁮‬‏⁮‬‏⁭⁮‏‏⁯‎‪⁭⁭‌‍‌⁯⁬⁬‫​⁭⁫⁪⁯‮‮⁮‭‎‏‏⁬‍‪‮([In] string obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Substring(obj1, obj2);
    }

    static string \u200B​⁫‌‏‪⁭⁭⁯‮⁬⁯‏⁪⁪‫‌‫‎‭‫‪‭⁭⁫‬⁭‬‌‍‫‍‌‎‮​⁭⁪‍‎‮([In] string obj0, [In] string obj1)
    {
      return Path.Combine(obj0, obj1);
    }

    static bool \u206F⁬⁭⁯‎⁮⁫‭‮⁫​‎‭‭‏⁪⁪‭‎‪‍⁭‪⁪‮‍‍‬‬⁫⁫‌‬⁬⁮‭⁪‌‭‮‮([In] string obj0)
    {
      return File.Exists(obj0);
    }

    static string[] \u206E‭⁮‏⁯⁯‎⁪‎‬⁫‌⁪⁫⁫​‫​​‪⁯⁯⁫‮‌‎⁪⁬‮‭⁬⁯‍​​⁪‌‬‪‭‮([In] string obj0)
    {
      return File.ReadAllLines(obj0);
    }

    static void \u206F⁪⁭‬‬⁬​⁬‌​⁭‬⁮⁬‮‪⁫‌‌⁯⁫‮‬‭‍⁬‫⁮‮⁪‎‭‬‪‬‮⁭​‍‭‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Warn(obj1);
    }

    static bool \u202D‍‫‍‮‪⁫‮‌‏‍⁪⁭⁯‏⁬‏‌‍⁪‍‮⁫‮⁮⁫‬‫‮⁫‍⁫‪⁪​‭⁬‎⁮‏‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static char[] \u202C‭‮⁪‭​‭‌⁬⁯‮⁯⁬‌​‍‪‮‪⁭‫‎‭‭‮‍⁬⁫‪‮‌​⁪‪⁮⁭‫​⁫‌‮([In] string obj0)
    {
      return obj0.ToCharArray();
    }

    static Random \u202D⁯⁬‪‪‪‫⁪‍​‎⁭⁫⁫‏‏‭‎‌‏⁮‭‭‭​⁯⁬⁪‬​‫​‬⁭⁯⁫⁪‏‎‫‮()
    {
      return new Random();
    }

    static int \u202B‎‪⁬⁫‪‌‭⁬⁭⁭‌⁯⁬‌⁮⁬‌‫‍‌‮‎‪‌‪‌⁮‭​⁯‬⁪⁯‬⁯⁭⁮⁫⁮‮([In] Random obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Next(obj1, obj2);
    }

    static string \u202B⁫‫‪⁭⁮‮‮⁭‏‍⁬​⁮‎⁫⁭⁬⁬‏​‍‭‍‫‍‏⁯‌​‎​‬⁫‮⁮⁯‭‎‪‮([In] string obj0)
    {
      return obj0.ToUpper();
    }

    static bool \u206B​‬‏‍⁯‏‫‏​⁯​‎⁮⁮‍‭​⁭⁪⁭‏⁭⁫⁯‪‮‮⁮‎‌⁭‪⁯‫‬‌‫⁮‮‮([In] string obj0)
    {
      return Directory.Exists(obj0);
    }

    static DirectoryInfo \u206B⁭‌‍‌‪​‏⁬‌‌⁮‏⁭‎‎⁬‏‍‎‫‬‎‍‭⁫⁪‫‪‫​‏⁫‮‌‏‎‮‌‮([In] string obj0)
    {
      return Directory.CreateDirectory(obj0);
    }

    static string[] \u206C⁭‪⁪‏‎​⁬‭⁪⁫⁭⁪‏⁪‏​‏‎‮​‌⁬⁯⁭‎⁬‏⁫‍‍⁭‎‮⁯‏‪‌⁮‪‮([In] string obj0, [In] string obj1, [In] SearchOption obj2)
    {
      return Directory.GetFiles(obj0, obj1, obj2);
    }

    static Assembly \u206E‏⁬‮⁫‎‪‫⁮‌​⁭⁮⁫⁭‫‏‌​‭⁯⁬‪‭‭⁬⁯⁪⁫‭⁮​⁪‏‎​‎‍​‬‮()
    {
      return Assembly.GetCallingAssembly();
    }

    static string \u200D‍‭‎‫‪‌⁭‌⁭‍‏‫​‍‪⁭‮​‪⁯‫‏⁯‎‫‪⁪⁪‮⁭‍‎‫​‌⁮‏‏⁭‮([In] Assembly obj0)
    {
      return obj0.Location;
    }

    static FileVersionInfo \u206B‬​‪‏‮‭‮‪⁪⁬‌‏‭⁪‌⁯‫‍​‌⁫‮⁪⁭‍‪‌‌⁪‎‍‏‫‭⁬‫‌‎‫‮([In] string obj0)
    {
      return FileVersionInfo.GetVersionInfo(obj0);
    }

    static string \u206F‍‬‬​⁬‍‌‏‌‏‫⁫‮‭⁯‮​‫‭​‎⁯‬⁮‮‌⁬‍‮‭‏⁯⁫⁬‎⁫⁭⁯‬‮([In] FileVersionInfo obj0)
    {
      return obj0.ProductVersion;
    }

    static string \u206D‏‌⁭⁫‍⁬‫‍‭⁭‍‍‎‮⁮‌⁭‌⁭‮‮⁪‮‍​‎​‌‪‪⁫⁭⁮‫‪‪‏‎⁭‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static Version \u202A‫‍⁫‏‎⁯‪‌⁬‬⁬‌‬‭⁪​‎⁫⁭⁮‍‌⁪‏​‌‭‪‫‎⁫⁫⁮​‭‮‎⁬‪‮([In] string obj0)
    {
      return new Version(obj0);
    }

    static string \u202B‭‪⁭‪‍‭⁯‏‬⁫‍⁪‬⁮⁯‫⁮‎‭‫‍‫⁪‪​⁬‍‏⁫⁪‏​⁪⁫‎‎⁫⁭‌‮()
    {
      return Path.GetTempPath();
    }

    static string \u206B‮⁬‪⁪‎‫‎‍‍⁬‌‬⁬⁬‍⁬​⁫‬‫‬‭‍⁪‏‎‍⁪⁪⁭‫‬⁯⁫⁬‪⁭⁬⁭‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static object \u206A​‭⁪⁭‭‬​⁭⁬‬‭⁭‌‌‮‮⁭‏‍‬⁬⁪‮‌⁫‎‮​⁭⁮‮‭‪‌⁫‌‪⁮‮()
    {
      return new object();
    }
  }
}
