// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ActivityBase
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Serialization;
using ZoomZoom.Common;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Data;

namespace ZoomZoom
{
  public abstract class ActivityBase : DataObject
  {
    protected static readonly object activityLocker = ActivityBase.\u202E‭⁮⁪‏‌‏‪⁭⁮‍⁪‏‪‫‍​​​⁯⁬‌⁫‫⁪‬⁭‪‭⁮⁫‬‮‮‭​⁯‏‪⁯‮();
    protected static DateTime startTime = DateTime.MinValue;
    protected static DateTime endTime = DateTime.MinValue;
    protected static ActivityState activityState = ActivityState.Undefined;
    private ActivityBase parentActivity = (ActivityBase) null;
    private string guid = string.Empty;
    private bool cancelRequested = false;
    private bool isValid = false;
    private bool requiresAuthorization = false;
    protected string name = "";
    private string status = "";
    private List<ZoomWindow> minimizedWindows = new List<ZoomWindow>();
    protected ActivityOptions options = new ActivityOptions();
    private string callerMemberName = string.Empty;
    private List<string> progressReports = new List<string>();
    private MeetingOptions meetingOptions = (MeetingOptions) null;
    private string description = "";
    private AuthorizationStates authorizationStates = AuthorizationStates.Pending;
    private string title = "";
    protected static ConcurrentQueue<ZoomEvent> pendingEvents;
    private static List<ZoomEvent> processedEvents;
    private CancellationToken token;
    protected static object result;
    private static bool suppressProgressReports;

    [XmlIgnore]
    public bool HasMinimizedWindows
    {
      get
      {
label_1:
        int num1 = -332572699;
        bool flag;
        while (true)
        {
          int num2 = -946646144;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              flag = this.MinimizedWindows.Count > 0;
              num1 = (int) num3 * -444871146 ^ -903324427;
              continue;
            case 3:
              num1 = (int) num3 * -1333351952 ^ 1688660358;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return flag;
      }
    }

    [XmlIgnore]
    public ZoomWindow MeetingWindow
    {
      get
      {
        ZoomWindow activeMeetingWindow = this.Engine.ActiveMeetingWindow;
label_1:
        int num1 = -938113641;
        while (true)
        {
          int num2 = -1737898962;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1523853180 ^ -826640558;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return activeMeetingWindow;
      }
    }

    [XmlIgnore]
    public List<ZoomWindow> MinimizedWindows
    {
      get
      {
label_1:
        int num1 = 1112984031;
        List<ZoomWindow> minimizedWindows;
        while (true)
        {
          int num2 = 585720862;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              minimizedWindows = this.minimizedWindows;
              num1 = (int) num3 * 1128632744 ^ 1508034437;
              continue;
            case 3:
              num1 = (int) num3 * 660070458 ^ -1430740474;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return minimizedWindows;
      }
      set
      {
        if (this.minimizedWindows != value)
          goto label_5;
label_1:
        int num1 = 575556980;
label_2:
        while (true)
        {
          int num2 = 965493765;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(633725912U));
              num1 = (int) num3 * 1115460965 ^ -894948361;
              continue;
            case 2:
              goto label_5;
            case 3:
              num1 = (int) num3 * 1328720633 ^ -1248138617;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        this.minimizedWindows = value;
        num1 = 562626080;
        goto label_2;
      }
    }

    public ActivityState ActivityState
    {
      get
      {
label_1:
        int num1 = 1011223210;
        ActivityState activityState;
        while (true)
        {
          int num2 = 952470347;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1020374607 ^ -267852116;
              continue;
            case 1:
              activityState = ActivityBase.activityState;
              num1 = (int) num3 * 1996428363 ^ -1399435368;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return activityState;
      }
      set
      {
        bool flag = ActivityBase.activityState == value;
label_1:
        int num1 = -1891666919;
        while (true)
        {
          int num2 = -307454250;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1791288462 ^ 962883255;
              continue;
            case 1:
              goto label_3;
            case 2:
              ActivityBase.activityState = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3860802819U));
              num1 = -346843224;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * 572883225 ^ -262957081;
              continue;
            case 5:
              int num4 = flag ? 673114432 : (num4 = 921820202);
              int num5 = (int) num3 * 461649958;
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

    public ConcurrentQueue<ZoomEvent> PendingEvents
    {
      get
      {
label_1:
        int num1 = -12735220;
        ConcurrentQueue<ZoomEvent> pendingEvents;
        while (true)
        {
          int num2 = -1122389446;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              pendingEvents = ActivityBase.pendingEvents;
              num1 = (int) num3 * -801695318 ^ -1561885200;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return pendingEvents;
      }
      set
      {
label_1:
        int num1 = -1054872825;
        while (true)
        {
          int num2 = -971181705;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              int num4 = !flag ? 2122739180 : (num4 = 1035845520);
              int num5 = (int) num3 * 1572536434;
              num1 = num4 ^ num5;
              continue;
            case 1:
              num1 = (int) num3 * -433780918 ^ -1574773855;
              continue;
            case 2:
              goto label_3;
            case 3:
              ActivityBase.pendingEvents = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2785228123U));
              num1 = -1494025081;
              continue;
            case 4:
              flag = ActivityBase.pendingEvents == value;
              num1 = (int) num3 * -889482881 ^ 1617856831;
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

    public DateTime StartTime
    {
      get
      {
        DateTime startTime = ActivityBase.startTime;
label_1:
        int num1 = -1779933057;
        while (true)
        {
          int num2 = -748729399;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -372104373 ^ -1584867053;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return startTime;
      }
      set
      {
label_1:
        int num1 = -2144325730;
        while (true)
        {
          int num2 = -1869370685;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              int num4 = !flag ? 486063322 : (num4 = 2109901181);
              int num5 = (int) num3 * 1776963453;
              num1 = num4 ^ num5;
              continue;
            case 1:
              ActivityBase.startTime = value;
              num1 = -1604722897;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3116222949U));
              num1 = (int) num3 * -1278543575 ^ 983443280;
              continue;
            case 5:
              flag = ActivityBase.startTime == value;
              num1 = (int) num3 * 1586361683 ^ -562131436;
              continue;
            case 6:
              num1 = (int) num3 * -2104857371 ^ -787922266;
              continue;
            case 7:
              num1 = (int) num3 * 1879778706 ^ -904499570;
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

    public DateTime EndTime
    {
      get
      {
label_1:
        int num1 = 127053643;
        DateTime endTime;
        while (true)
        {
          int num2 = 410317693;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              endTime = ActivityBase.endTime;
              num1 = (int) num3 * 1399937689 ^ 642330956;
              continue;
            case 3:
              num1 = (int) num3 * -789819224 ^ 495190164;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return endTime;
      }
      set
      {
        bool flag = ActivityBase.endTime == value;
label_1:
        int num1 = -987754109;
        while (true)
        {
          int num2 = -958242102;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1011969635 ^ -28607988;
              continue;
            case 1:
              int num4 = flag ? -582537055 : (num4 = -1974140696);
              int num5 = (int) num3 * -954043509;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              ActivityBase.endTime = value;
              num1 = -1850558839;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2618355739U));
              num1 = (int) num3 * -1231888120 ^ -1925107524;
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

    public string Status
    {
      get
      {
label_1:
        int num1 = 939913485;
        string status;
        while (true)
        {
          int num2 = 90521670;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1702369966 ^ -1408459133;
              continue;
            case 3:
              status = this.status;
              num1 = (int) num3 * 653711343 ^ 2126863345;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return status;
      }
      set
      {
        this.status = value;
      }
    }

    public object Result
    {
      get
      {
        return ActivityBase.result;
      }
      internal set
      {
label_1:
        int num1 = -1688018859;
        while (true)
        {
          int num2 = -1410194993;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              flag = ActivityBase.result == value;
              num1 = (int) num3 * 670714554 ^ 1442179992;
              continue;
            case 3:
              ActivityBase.result = value;
              num1 = -395010904;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3135889702U));
              num1 = (int) num3 * 1146944239 ^ -1446848162;
              continue;
            case 5:
              num1 = (int) num3 * -1809438307 ^ -763672610;
              continue;
            case 6:
              int num4 = flag ? 672576393 : (num4 = 249556070);
              int num5 = (int) num3 * -166181543;
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

    public string Guid
    {
      get
      {
label_1:
        int num1 = 1734328751;
        string guid;
        while (true)
        {
          int num2 = 1736597701;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1538319236 ^ 1645279534;
              continue;
            case 2:
              guid = this.guid;
              num1 = (int) num3 * 1987622679 ^ 241492690;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return guid;
      }
      set
      {
        if (!ActivityBase.\u206D⁯‌‎‭‮‎‮⁭‎‍‪‍⁫‫⁪⁬‎‎‭⁯‭‎⁬‌​‭​‫⁮⁭‪‏‏‌‮‏​‍‮(this.guid, value))
          goto label_6;
label_1:
        int num1 = -1119517758;
label_2:
        while (true)
        {
          int num2 = -1808419931;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -1957813578 ^ 450150506;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * 1001469679 ^ 2139282621;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_6:
        this.guid = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(917438053U));
        num1 = -1770840056;
        goto label_2;
      }
    }

    [XmlIgnore]
    protected CancellationToken Token
    {
      get
      {
label_1:
        int num1 = 1381113561;
        CancellationToken token;
        while (true)
        {
          int num2 = 151633536;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1640780939 ^ -2084963285;
              continue;
            case 1:
              token = this.token;
              num1 = (int) num3 * -1970423727 ^ 1985906921;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return token;
      }
      set
      {
        bool flag = CancellationToken.op_Equality(this.token, value);
label_1:
        int num1 = 2131284990;
        while (true)
        {
          int num2 = 350380814;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.token = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(130550371U));
              num1 = 376833720;
              continue;
            case 1:
              num1 = (int) num3 * 2128046840 ^ -902462040;
              continue;
            case 2:
              int num4 = !flag ? 60573066 : (num4 = 1341804432);
              int num5 = (int) num3 * 1815529340;
              num1 = num4 ^ num5;
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

    public string Name
    {
      get
      {
label_1:
        int num1 = -177641020;
        string name;
        while (true)
        {
          int num2 = -1371793485;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1218044978 ^ -269462581;
              continue;
            case 3:
              name = this.name;
              num1 = (int) num3 * -770294711 ^ 1728679705;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return name;
      }
      set
      {
        this.name = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4283083687U));
      }
    }

    protected bool CancelRequested
    {
      get
      {
label_1:
        int num1 = -236460034;
        bool cancelRequested;
        while (true)
        {
          int num2 = -1364359390;
          uint num3;
          bool cancellationRequested;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = cancellationRequested ? 236398573 : (num4 = 1848723053);
              int num5 = (int) num3 * 1802731497;
              num1 = num4 ^ num5;
              continue;
            case 2:
              CancellationToken token1 = this.Token;
              num1 = (int) num3 * -1739986758 ^ 1700559474;
              continue;
            case 3:
              num1 = (int) num3 * -2089101641 ^ 896406940;
              continue;
            case 4:
              CancellationToken token2 = this.Token;
              cancellationRequested = ((CancellationToken) @token2).get_IsCancellationRequested();
              num1 = (int) num3 * 1962427600 ^ 731341619;
              continue;
            case 5:
              cancelRequested = this.cancelRequested;
              num1 = -1176546806;
              continue;
            case 7:
              this.cancelRequested = true;
              num1 = (int) num3 * -1940014855 ^ -774946941;
              continue;
            case 8:
              num1 = (int) num3 * 1884708326 ^ 57554078;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return cancelRequested;
      }
      set
      {
label_1:
        int num1 = -1103241045;
        while (true)
        {
          int num2 = -451778344;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1026007267U));
              num1 = (int) num3 * -786857421 ^ -1949770806;
              continue;
            case 1:
              num1 = (int) num3 * -1651102618 ^ 1577765939;
              continue;
            case 2:
              num1 = (int) num3 * 119259306 ^ -1305296191;
              continue;
            case 3:
              flag = this.cancelRequested == value;
              num1 = (int) num3 * -160794094 ^ -602775878;
              continue;
            case 4:
              int num4 = !flag ? 36000251 : (num4 = 1508547317);
              int num5 = (int) num3 * 5807407;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_3;
            case 6:
              goto label_1;
            case 7:
              this.cancelRequested = value;
              num1 = -342234904;
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

    public virtual bool IsValid
    {
      get
      {
label_1:
        int num1 = -915218680;
        bool flag;
        while (true)
        {
          int num2 = -611466849;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              flag = this.Valid();
              num1 = (int) num3 * -2074491615 ^ -1680151769;
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
    }

    public ActivityOptions Options
    {
      get
      {
label_1:
        int num1 = 1517540133;
        ActivityOptions options;
        while (true)
        {
          int num2 = 926167250;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1875661692 ^ -753560693;
              continue;
            case 2:
              goto label_1;
            case 3:
              options = this.options;
              num1 = (int) num3 * -856134381 ^ 1849681975;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return options;
      }
      set
      {
label_1:
        int num1 = 90950472;
        while (true)
        {
          int num2 = 394454324;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              flag = this.options == value;
              num1 = (int) num3 * 1070068022 ^ 937757368;
              continue;
            case 2:
              int num4 = !flag ? -1902792814 : (num4 = -1057071389);
              int num5 = (int) num3 * -1888861280;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * 820847618 ^ -2107164820;
              continue;
            case 5:
              this.options = value;
              num1 = 2126278253;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3721373477U));
              num1 = (int) num3 * -293729065 ^ -1616065923;
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

    public MeetingOptions MeetingOptions
    {
      get
      {
        MeetingOptions meetingOptions = this.meetingOptions;
label_1:
        int num1 = -780543887;
        while (true)
        {
          int num2 = -1491086495;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -956179903 ^ -1287359332;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingOptions;
      }
      set
      {
label_1:
        int num1 = 825075662;
        while (true)
        {
          int num2 = 1389399520;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3944018489U));
              num1 = (int) num3 * 1735943928 ^ 300115739;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 639333765 ^ -1221291379;
              continue;
            case 4:
              int num4 = !flag ? 1421920863 : (num4 = 1815547669);
              int num5 = (int) num3 * 1028452216;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 538542945 ^ -219900745;
              continue;
            case 6:
              flag = this.meetingOptions == value;
              num1 = (int) num3 * 1290082522 ^ 1142592184;
              continue;
            case 7:
              this.meetingOptions = value;
              num1 = 360947865;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -1258639279;
        TraceType traceType;
        while (true)
        {
          int num2 = -2043473798;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -340590384 ^ -853456304;
              continue;
            case 3:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1643391277 ^ 2008940786;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public List<string> ProgressReports
    {
      get
      {
label_1:
        int num1 = 1472027828;
        List<string> progressReports;
        while (true)
        {
          int num2 = 2022314565;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              progressReports = this.progressReports;
              num1 = (int) num3 * 1164926707 ^ 383015372;
              continue;
            case 2:
              num1 = (int) num3 * -1427831069 ^ -1503401953;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return progressReports;
      }
      set
      {
        this.progressReports = value;
label_1:
        int num1 = -1254299259;
        while (true)
        {
          int num2 = -772926849;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3709262900U));
              num1 = (int) num3 * 1413027767 ^ -37604098;
              continue;
            case 3:
              num1 = (int) num3 * -1744089988 ^ 591317366;
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

    public ActivityBase ParentActivity
    {
      get
      {
        return this.parentActivity;
      }
      internal set
      {
        bool flag = this.parentActivity == value;
label_1:
        int num1 = 753697006;
        while (true)
        {
          int num2 = 302372375;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              this.parentActivity = value;
              num1 = 44914759;
              continue;
            case 2:
              num1 = (int) num3 * -1144569346 ^ 1472030555;
              continue;
            case 3:
              int num4 = !flag ? -319304540 : (num4 = -2095521249);
              int num5 = (int) num3 * 1640359070;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(558608683U));
              num1 = (int) num3 * -794747095 ^ -1864409793;
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

    public List<ZoomEvent> ProcessedEvents
    {
      get
      {
label_1:
        int num1 = -1392509112;
        List<ZoomEvent> processedEvents;
        while (true)
        {
          int num2 = -993694883;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              processedEvents = ActivityBase.processedEvents;
              num1 = (int) num3 * 1716293314 ^ 1289482791;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return processedEvents;
      }
      set
      {
label_1:
        int num1 = 863207099;
        while (true)
        {
          int num2 = 861835827;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3848189258U));
              num1 = (int) num3 * -735906665 ^ 1144751118;
              continue;
            case 1:
              int num4 = ActivityBase.processedEvents != value ? -1446475423 : (num4 = -436528146);
              int num5 = (int) num3 * -161199223;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              ActivityBase.processedEvents = value;
              num1 = 1004346901;
              continue;
            case 4:
              num1 = (int) num3 * -1661646689 ^ -142323496;
              continue;
            case 5:
              goto label_3;
            case 6:
              num1 = (int) num3 * 556198364 ^ -85440233;
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

    protected virtual string Description
    {
      get
      {
label_1:
        int num1 = -1322062081;
        string description;
        while (true)
        {
          int num2 = -297655886;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              description = this.description;
              num1 = (int) num3 * 820504626 ^ -1721974799;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return description;
      }
      set
      {
label_1:
        int num1 = 2131328526;
        while (true)
        {
          int num2 = 39072288;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 1740397492 ^ 1641673034;
              continue;
            case 2:
              this.description = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1029768141U));
              num1 = 2126166342;
              continue;
            case 3:
              int num4 = !flag ? 1987376641 : (num4 = 1945368622);
              int num5 = (int) num3 * 507459051;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag = ActivityBase.\u206D⁯‌‎‭‮‎‮⁭‎‍‪‍⁫‫⁪⁬‎‎‭⁯‭‎⁬‌​‭​‫⁮⁭‪‏‏‌‮‏​‍‮(this.description, value);
              num1 = (int) num3 * 1973259272 ^ -346743821;
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

    public AuthorizationStates AuthorizationState
    {
      get
      {
label_1:
        int num1 = 1394261729;
        AuthorizationStates authorizationStates;
        while (true)
        {
          int num2 = 51010438;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -587321848 ^ 444340455;
              continue;
            case 3:
              authorizationStates = this.authorizationStates;
              num1 = (int) num3 * -1431925579 ^ 718881251;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return authorizationStates;
      }
      set
      {
label_1:
        int num1 = 489604263;
        while (true)
        {
          int num2 = 1347400856;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = this.authorizationStates != value ? 81049986 : (num4 = 94103771);
              int num5 = (int) num3 * 306536369;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1536960406 ^ 1752856362;
              continue;
            case 4:
              num1 = (int) num3 * -1269088019 ^ -965840824;
              continue;
            case 5:
              this.authorizationStates = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4058541865U));
              num1 = 1390123227;
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

    public bool RequiresAuthorization
    {
      get
      {
label_1:
        int num1 = 211895203;
        bool requiresAuthorization;
        while (true)
        {
          int num2 = 1148875813;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              requiresAuthorization = this.requiresAuthorization;
              num1 = (int) num3 * 1116533488 ^ 1365035486;
              continue;
            case 3:
              num1 = (int) num3 * -1519646981 ^ -1248506671;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return requiresAuthorization;
      }
      set
      {
label_1:
        int num1 = 1442190385;
        while (true)
        {
          int num2 = 1424784674;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.requiresAuthorization = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3112037579U));
              num1 = 445668135;
              continue;
            case 1:
              flag = this.requiresAuthorization == value;
              num1 = (int) num3 * 582500989 ^ 2008083863;
              continue;
            case 2:
              int num4 = !flag ? 254179276 : (num4 = 1299598971);
              int num5 = (int) num3 * 533379151;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * -1455590004 ^ 128646451;
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

    public string Title
    {
      get
      {
label_1:
        int num1 = -469646248;
        string title;
        while (true)
        {
          int num2 = -656820243;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -940548460 ^ -1613840234;
              continue;
            case 1:
              title = this.title;
              num1 = (int) num3 * -909090661 ^ -1360365530;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return title;
      }
      set
      {
label_1:
        int num1 = 897700247;
        while (true)
        {
          int num2 = 259922180;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * 1086450229 ^ -1027820040;
              continue;
            case 1:
              int num4 = flag ? 304136224 : (num4 = 1544012487);
              int num5 = (int) num3 * -1497488754;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * 1705208407 ^ -527390058;
              continue;
            case 3:
              flag = ActivityBase.\u206D⁯‌‎‭‮‎‮⁭‎‍‪‍⁫‫⁪⁬‎‎‭⁯‭‎⁬‌​‭​‫⁮⁭‪‏‏‌‮‏​‍‮(this.title, value);
              num1 = (int) num3 * 71759082 ^ -1461997085;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.title = value;
              num1 = 691131051;
              continue;
            case 6:
              goto label_1;
            case 7:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3822962136U));
              num1 = (int) num3 * -527235312 ^ -1496556532;
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

    public override ObjectDataTable ZoomZoomTable
    {
      get
      {
label_1:
        int num1 = -1962820719;
        ObjectDataTable objectDataTable;
        while (true)
        {
          int num2 = -557604692;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              objectDataTable = ObjectDataTable.Activities;
              num1 = (int) num3 * 2081174848 ^ -1014584985;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return objectDataTable;
      }
    }

    static ActivityBase()
    {
label_1:
      int num1 = -149444967;
      while (true)
      {
        int num2 = -1139896282;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            ActivityBase.processedEvents = new List<ZoomEvent>();
            ActivityBase.result = ActivityBase.\u202E‭⁮⁪‏‌‏‪⁭⁮‍⁪‏‪‫‍​​​⁯⁬‌⁫‫⁪‬⁭‪‭⁮⁫‬‮‮‭​⁯‏‪⁯‮();
            num1 = (int) num3 * -1786513776 ^ -684632308;
            continue;
          case 3:
            ActivityBase.pendingEvents = new ConcurrentQueue<ZoomEvent>();
            num1 = (int) num3 * 224545369 ^ -169775944;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      ActivityBase.suppressProgressReports = false;
    }

    public ActivityBase()
    {
label_1:
      int num1 = -833666404;
      while (true)
      {
        int num2 = -2058340773;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            ActivityBase.startTime = DateTime.MinValue;
            num1 = (int) num3 * -1016415769 ^ 1095491435;
            continue;
          case 2:
            num1 = (int) num3 * -1099119592 ^ -1184789024;
            continue;
          case 3:
            ActivityBase.activityState = ActivityState.Pending;
            num1 = (int) num3 * -622687946 ^ -109230006;
            continue;
          case 5:
            this.guid = System.Guid.NewGuid().ToString();
            num1 = (int) num3 * 1485447073 ^ -469016906;
            continue;
          case 6:
            ActivityBase.endTime = DateTime.MinValue;
            this.name = StringHelper.AddSpacesToSentence(ActivityBase.\u202E‫‪‮⁯⁯‏⁫‪‏‭⁬⁫‏⁪⁮⁬⁫⁯‬‪‫‏‪​⁭⁪‌⁫⁮‭‎‌‭‍⁫⁪⁮⁭‫‮((object) ActivityBase.\u206E‬⁪⁫⁭‏‎⁬⁪‎⁮‮​‬⁪⁬‫⁭⁪‎⁮⁪⁪⁮‌‍‎‭⁬‍‪‫⁬⁮‪⁭​‭⁮‏‮((MemberInfo) ActivityBase.\u200F‫‫⁮‮⁯⁫‎​‌‮⁪⁯‏⁮⁬​‏⁮‏‍⁭‍‍⁬‭⁮⁪‬‍‍​⁭‌⁬‫‭‏‭‮‮((object) this))), false);
            num1 = (int) num3 * 1783083211 ^ 2144998398;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityCanceledEvent>()).Subscribe(new Action<ActivityEventBaseArguments>(this.OnCancelActivity), (ThreadOption) 2, false, (Predicate<ActivityEventBaseArguments>) (x =>
      {
label_1:
        int num2 = -125586949;
        bool flag;
        while (true)
        {
          int num3 = -1542488140;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              flag = ActivityBase.\u202E‏⁮‪‮‬⁬‮‌‎‬‭‮‬​⁯‎‭⁫⁮‎⁫‬⁯‬‪‪‬‭⁯⁫‮‍‫​‮‭‮​‬‮(x.TargetGuid, this.Guid);
              num2 = (int) num4 * -444254968 ^ 914517394;
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
    }

    private void OnCancelActivity(ActivityEventBaseArguments obj)
    {
      object activityLocker = ActivityBase.activityLocker;
      bool flag = false;
      try
      {
        ActivityBase.\u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮(activityLocker, ref flag);
label_2:
        int num1 = 1467935254;
        while (true)
        {
          int num2 = 536615047;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              this.CancelRequested = true;
              num1 = (int) num3 * -777728666 ^ -974336176;
              continue;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_6:
          int num1 = 307914050;
          while (true)
          {
            int num2 = 536615047;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                ActivityBase.\u202D‌‭​‌‬⁯⁭‍‎⁮⁫⁯‌‌⁬⁫⁯‭⁮⁯‌⁪‭‭⁯‎‭​‪‬⁯⁬‫‮​⁬‫‬⁪‮(activityLocker);
                num1 = (int) num3 * -2083241744 ^ 73248369;
                continue;
              case 2:
                num1 = (int) num3 * 1292454760 ^ 1629352243;
                continue;
              case 3:
                goto label_6;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
label_12:
      CancellationToken token = this.Token;
label_13:
      int num4 = 638309754;
      while (true)
      {
        int num1 = 536615047;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 4U)
        {
          case 0:
            goto label_13;
          case 1:
            // ISSUE: explicit reference operation
            ((CancellationToken) @token).ThrowIfCancellationRequested();
            num4 = (int) num2 * 1967467913 ^ -724394491;
            continue;
          case 2:
            goto label_15;
          case 3:
            num4 = (int) num2 * 729865505 ^ 696779286;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_15:;
    }

    protected abstract void ExecuteLogic();

    internal abstract bool Valid();

    internal virtual void ResetProperties()
    {
label_1:
      int num1 = 1011464498;
      while (true)
      {
        int num2 = 232092409;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Options = new ActivityOptions();
            num1 = (int) num3 * -737781612 ^ 2096340567;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = -2087273904;
      bool flag1;
      while (true)
      {
        int num2 = -1908142470;
        uint num3;
        ActivityBase activityBase;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            int num4 = flag2 ? -709193225 : (num4 = -1120188247);
            int num5 = (int) num3 * 1075368905;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag1 = ActivityBase.\u202E‏⁮‪‮‬⁬‮‌‎‬‭‮‬​⁯‎‭⁫⁮‎⁫‬⁯‬‪‪‬‭⁯⁫‮‍‫​‮‭‮​‬‮(activityBase.Guid, this.Guid);
            num1 = (int) num3 * -322541643 ^ 2007474358;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag1 = this.\u202C⁫‪⁮‭​​⁪‌‍⁬‬​⁯⁯⁯​⁬⁪‍⁪⁮‌‏⁮​⁭‌‎‫​⁪‪‏​‪‎‫⁯‬‮(obj);
            num1 = (int) num3 * 1764973744 ^ -1042883753;
            continue;
          case 4:
            activityBase = obj as ActivityBase;
            flag2 = activityBase != null;
            num1 = (int) num3 * -295409396 ^ -945334482;
            continue;
          case 5:
            num1 = (int) num3 * -1848600694 ^ -1086268019;
            continue;
          case 7:
            num1 = (int) num3 * -270525551 ^ -410080566;
            continue;
          case 8:
            num1 = -468473110;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag1;
    }

    public override int GetHashCode()
    {
label_1:
      int num1 = 352847851;
      int num2;
      while (true)
      {
        int num3 = 1231511942;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 1:
            num2 = ActivityBase.\u202C⁪⁭⁮​⁭⁭‮‭⁫‭‬‌‍⁯‎​‪​⁭⁫‪⁭‮⁪⁮⁯‏‬‏⁭‪‎⁪⁭‬‌⁫‭‫‮((object) this.Guid);
            num1 = (int) num4 * -1237177271 ^ 555363229;
            continue;
          case 2:
            num1 = (int) num4 * -2048889401 ^ 1506051988;
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

    internal ZoomEvent GetPendingEvent()
    {
      ZoomEvent zoomEvent1;
      if (!this.PendingEvents.TryDequeue(ref zoomEvent1))
        goto label_4;
label_1:
      int num1 = 1321820872;
label_2:
      ZoomEvent zoomEvent2;
      while (true)
      {
        int num2 = 370563427;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            num1 = (int) num3 * -172151047 ^ 1716289803;
            continue;
          case 2:
            this.ProcessedEvents.Add(zoomEvent1);
            zoomEvent2 = zoomEvent1;
            num1 = (int) num3 * 564133298 ^ -140186481;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_4;
          default:
            goto label_6;
        }
      }
label_6:
      return zoomEvent2;
label_4:
      zoomEvent2 = (ZoomEvent) null;
      num1 = 1008849545;
      goto label_2;
    }

    internal virtual void SetActivityState(ActivityState state, string newStatusMessage = "")
    {
      object activityLocker = ActivityBase.activityLocker;
      bool flag1 = false;
      try
      {
        ActivityBase.\u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮(activityLocker, ref flag1);
label_2:
        int num1 = -1963493863;
        while (true)
        {
          int num2 = -1563447416;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              flag2 = !ActivityBase.\u206A⁬‫‏‮‫‌‎​⁮‬⁮‮‬‬⁫⁪‎⁮‍‍‍‭‍‎‪‏​‬‎⁭​⁭‍​‏‎‪⁬⁭‮(newStatusMessage);
              num1 = (int) num3 * 525480628 ^ 1355727247;
              continue;
            case 2:
              this.Status = this.Guid;
              num1 = -1411075408;
              continue;
            case 3:
              num1 = (int) num3 * 1834425424 ^ -2007816067;
              continue;
            case 4:
              this.ActivityState = state;
              num1 = (int) num3 * -876750165 ^ -1058015636;
              continue;
            case 5:
              num1 = (int) num3 * 2142980773 ^ -1258381897;
              continue;
            case 6:
              num1 = (int) num3 * 195904095 ^ 526588222;
              continue;
            case 7:
              int num4 = !flag2 ? -1682114290 : (num4 = -94931674);
              int num5 = (int) num3 * -1697429980;
              num1 = num4 ^ num5;
              continue;
            case 8:
              num1 = (int) num3 * -1733139865 ^ 126266181;
              continue;
            case 9:
              goto label_2;
            case 10:
              this.Status = newStatusMessage;
              num1 = (int) num3 * -1392172670 ^ -689380113;
              continue;
            case 11:
              num1 = (int) num3 * 991207073 ^ 1152511108;
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
          int num1 = -1442135603;
          while (true)
          {
            int num2 = -1563447416;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                ActivityBase.\u202D‌‭​‌‬⁯⁭‍‎⁮⁫⁯‌‌⁬⁫⁯‭⁮⁯‌⁪‭‭⁯‎‭​‪‬⁯⁬‫‮​⁬‫‬⁪‮(activityLocker);
                num1 = (int) num3 * -1108673437 ^ -1699315599;
                continue;
              case 2:
                num1 = (int) num3 * -1432545346 ^ -1935573412;
                continue;
              case 3:
                goto label_15;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:
      if (ActivityBase.\u206A⁬‫‏‮‫‌‎​⁮‬⁮‮‬‬⁫⁪‎⁮‍‍‍‭‍‎‪‏​‬‎⁭​⁭‍​‏‎‪⁬⁭‮(newStatusMessage))
        goto label_34;
label_22:
      int num6 = -560877037;
label_23:
      bool flag3;
      while (true)
      {
        int num1 = -1563447416;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 11U)
        {
          case 0:
            goto label_22;
          case 1:
            num6 = (int) num2 * 1279542286 ^ -258119222;
            continue;
          case 2:
            num6 = (int) num2 * 881813810 ^ -978855923;
            continue;
          case 3:
            goto label_33;
          case 4:
            ActivityBase.\u206F​⁬‪⁯⁯‎‎⁭‪⁫​‪‪⁮⁭‎⁪⁮⁫⁪⁫⁪⁯‬‎⁪‎‌⁬‪‭⁯‪‫‎‭‌‪⁪‮(CoreObject.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(533381561U), (object) this.Name, (object) newStatusMessage);
            this.ReportProgress(newStatusMessage, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2593985254U));
            num6 = (int) num2 * 2045335273 ^ 1005803436;
            continue;
          case 5:
            ActivityBase.\u200B‍‍‫​⁯⁯‎⁫‌‏‌‎⁯‬⁯‍​‭‫‏‌⁯‪‌‭‮⁫‭‭⁪‭‬‪‍⁬⁯⁯‍‫‮(CoreObject.log, ActivityBase.\u202A‎⁯‏⁯⁪⁪‎⁭‏‫‭‍‎​‎⁬‪‍‎‮⁮​⁫‫‌‪​‌⁯‮⁯‏⁪⁬‮⁬​‍⁯‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2442258850U), (object) this.Name, (object) this.ActivityState, (object) this.Guid), new object[0]);
            num6 = (int) num2 * 594912407 ^ -1716557273;
            continue;
          case 6:
            int num3 = !flag3 ? -373927398 : (num3 = -1452385809);
            int num4 = (int) num2 * -509912063;
            num6 = num3 ^ num4;
            continue;
          case 7:
            num6 = (int) num2 * 102742989 ^ 1592084594;
            continue;
          case 8:
            num6 = (int) num2 * 592072965 ^ 60347063;
            continue;
          case 9:
            num6 = -1370248463;
            continue;
          case 10:
            goto label_24;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_24:
      return;
label_33:
      int num7 = !ActivityBase.\u202E‏⁮‪‮‬⁬‮‌‎‬‭‮‬​⁯‎‭⁫⁮‎⁫‬⁯‬‪‪‬‭⁯⁫‮‍‫​‮‭‮​‬‮(this.Status, this.Guid) ? 1 : 0;
      goto label_35;
label_34:
      num7 = 0;
label_35:
      flag3 = num7 != 0;
      num6 = -529712618;
      goto label_23;
    }

    protected void CheckCancellationToken()
    {
label_1:
      int num1 = -1902871062;
      while (true)
      {
        int num2 = -1220705332;
        uint num3;
        CancellationToken token1;
        bool cancellationRequested;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * 692566286 ^ 1315540175;
            continue;
          case 1:
            goto label_10;
          case 2:
            // ISSUE: explicit reference operation
            ((CancellationToken) @token1).ThrowIfCancellationRequested();
            num1 = (int) num3 * 692237988 ^ -1186501727;
            continue;
          case 3:
            int num4;
            num1 = num4 = !this.CancelRequested ? -1514786919 : (num4 = -1003087780);
            continue;
          case 4:
            num1 = (int) num3 * -126556988 ^ -1158164791;
            continue;
          case 5:
            token1 = this.Token;
            num1 = (int) num3 * -1333451723 ^ -874161901;
            continue;
          case 6:
            goto label_1;
          case 7:
            int num5 = !cancellationRequested ? -2027492245 : (num5 = -1734538372);
            int num6 = (int) num3 * 141846730;
            num1 = num5 ^ num6;
            continue;
          case 8:
            CancellationToken token2 = this.Token;
            token1 = this.Token;
            // ISSUE: explicit reference operation
            cancellationRequested = ((CancellationToken) @token1).get_IsCancellationRequested();
            num1 = (int) num3 * -1390784383 ^ 719651861;
            continue;
          case 9:
            goto label_3;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:
      return;
label_10:
      throw new Exception(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2832224114U));
    }

    protected virtual bool ContinueExecution()
    {
label_1:
      int num1 = -710174143;
      bool flag1;
      while (true)
      {
        int num2 = -1753446769;
        uint num3;
        bool flag2;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3347445390U));
            num1 = (int) num3 * -1537654676 ^ 415596639;
            continue;
          case 1:
            num1 = -121457365;
            continue;
          case 2:
            int num4 = flag3 ? -2098751459 : (num4 = -2088108497);
            int num5 = (int) num3 * 93835692;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * 1307138658 ^ 681273275;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num6 = this.CancelRequested ? -1384499648 : (num6 = -962046098);
            int num7 = (int) num3 * 377254040;
            num1 = num6 ^ num7;
            continue;
          case 6:
            flag1 = true;
            num1 = (int) num3 * -9460081 ^ 1638160517;
            continue;
          case 7:
            this.SetActivityState(ActivityState.Canceled, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2721119190U));
            num1 = (int) num3 * -874875191 ^ 1385314827;
            continue;
          case 8:
            flag1 = false;
            num1 = (int) num3 * -943650225 ^ -1330796136;
            continue;
          case 9:
            num1 = (int) num3 * 438917607 ^ -1887635076;
            continue;
          case 10:
            flag3 = this.ActivityState != ActivityState.InProgress;
            num1 = -905464697;
            continue;
          case 12:
            int num8 = flag2 ? -602423910 : (num8 = -922516766);
            int num9 = (int) num3 * -951481115;
            num1 = num8 ^ num9;
            continue;
          case 13:
            this.SetActivityState(ActivityState.Canceled, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4251508498U));
            num1 = (int) num3 * -123936435 ^ 717194413;
            continue;
          case 14:
            flag2 = this.EndTime < DateTime.Now;
            num1 = -809835950;
            continue;
          case 15:
            flag1 = false;
            num1 = (int) num3 * -842424130 ^ 898991815;
            continue;
          case 16:
            ActivityBase.\u206A‎‪‏⁬‪⁪‪‭⁮⁮⁯‭⁫⁭‮‪‭‬‍⁭‭‫⁭‍⁬‫‌‬⁬‏‭​‎⁫⁬‭‮⁪‌‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(823231674U), (object) this.ActivityState);
            flag1 = false;
            num1 = (int) num3 * -452260645 ^ -1747406807;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return flag1;
    }

    protected void Start(CancellationToken token)
    {
label_1:
      int num1 = 214897989;
      object activityLocker;
      while (true)
      {
        int num2 = 74537558;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * 736334475 ^ -1758478789;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        ActivityBase.\u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮(activityLocker, ref flag);
label_6:
        int num2 = 249041289;
        while (true)
        {
          int num3 = 74537558;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 9U)
          {
            case 0:
              this.StartTime = DateTime.Now;
              num2 = (int) num4 * 1564348388 ^ 1134037696;
              continue;
            case 1:
              num2 = (int) num4 * -1130112178 ^ 510751451;
              continue;
            case 2:
              this.Token = token;
              num2 = (int) num4 * -1664007250 ^ -591695240;
              continue;
            case 3:
              this.EndTime = this.StartTime.AddSeconds(30.0);
              num2 = (int) num4 * 1799274326 ^ 761009427;
              continue;
            case 4:
              goto label_19;
            case 5:
              num2 = (int) num4 * 1237498679 ^ -63066791;
              continue;
            case 6:
              num2 = (int) num4 * -2070248892 ^ 1677081270;
              continue;
            case 7:
              this.ActivityState = ActivityState.InProgress;
              num2 = (int) num4 * -709247596 ^ 152507695;
              continue;
            case 8:
              goto label_6;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_19:;
      }
      finally
      {
        if (flag)
        {
label_17:
          int num2 = 791860953;
          while (true)
          {
            int num3 = 74537558;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -876161090 ^ -1775661517;
                continue;
              case 2:
                goto label_17;
              case 3:
                Monitor.Exit(activityLocker);
                num2 = (int) num4 * -285911571 ^ -880890923;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
    }

    protected void End()
    {
      object activityLocker = ActivityBase.activityLocker;
      bool flag = false;
      try
      {
        ActivityBase.\u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮(activityLocker, ref flag);
label_2:
        int num1 = 915930127;
        while (true)
        {
          int num2 = 923154517;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 955771722 ^ -731597189;
              continue;
            case 1:
              this.EndTime = DateTime.Now;
              num1 = (int) num3 * -1115351096 ^ 1886797604;
              continue;
            case 2:
              num1 = (int) num3 * -1319619552 ^ -577950936;
              continue;
            case 3:
              goto label_2;
            case 4:
              goto label_11;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_11:;
      }
      finally
      {
        if (flag)
        {
label_9:
          int num1 = 92262648;
          while (true)
          {
            int num2 = 923154517;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_9;
              case 1:
                ActivityBase.\u202D‌‭​‌‬⁯⁭‍‎⁮⁫⁯‌‌⁬⁫⁯‭⁮⁯‌⁪‭‭⁯‎‭​‪‬⁯⁬‫‮​⁬‫‬⁪‮(activityLocker);
                num1 = (int) num3 * -716566246 ^ 1984215917;
                continue;
              case 2:
                num1 = (int) num3 * 126330387 ^ -884507024;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    public virtual ActivityState Execute(CancellationToken token)
    {
label_1:
      int num1 = 1246650555;
      ActivityState activityState;
      while (true)
      {
        int num2 = 1342979714;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            this.End();
            activityState = this.ActivityState;
            num1 = (int) num3 * 2051278704 ^ 850851769;
            continue;
          case 1:
            this.Start(token);
            this.ExecuteLogic();
            num1 = (int) num3 * 1526285415 ^ -325802299;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return activityState;
    }

    public void HandleException(Exception ex)
    {
label_1:
      int num1 = 1307138283;
      while (true)
      {
        int num2 = 73560357;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.SetActivityState(ActivityState.Error, ActivityBase.\u206D‫‏‮​‭⁬⁯‎‌‪‭⁮‪⁫‏⁭‪⁭‏⁪‮‍‏⁬‮⁮‮⁭⁬‏⁭‎⁬‍⁯⁭‏⁯⁪‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2639143958U), (object) ActivityBase.\u206A‍‪‍⁫‭⁯⁯⁮‭⁮‌⁫‎⁭‍‭‪⁪‪‍⁬‍​‎⁫⁯‬‭‫​‮‫⁬‫⁭‬‮‍‍‮(ex)));
            num1 = (int) num3 * 1830447299 ^ -1597393343;
            continue;
          case 2:
            ActivityBase.\u200E‬‍‫‎‪⁪‬‭⁫‫⁬‎⁫‏‏‌​‬‏‮⁫‮⁬⁫‍​⁬‎⁪‌⁭⁬‎‫​⁬‮‎‏‮(CoreObject.log, (object) ex);
            num1 = (int) num3 * -2002413408 ^ -1456153612;
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

    internal void ChangeUserName(List<string> userNameList, bool v)
    {
label_1:
      int num1 = 531958150;
      while (true)
      {
        int num2 = 1536846601;
        uint num3;
        Random random;
        bool flag;
        DateTime now;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            num1 = (int) num3 * 928266442 ^ -484469290;
            continue;
          case 1:
            now = DateTime.Now;
            num1 = (int) num3 * 452533807 ^ -1951062279;
            continue;
          case 2:
            num1 = 1883840918;
            continue;
          case 3:
            goto label_1;
          case 4:
            this.options.ExecuteAs = this.Options.UserNameList[random.Next(0, this.Options.UserNameList.Count - 1)];
            num1 = (int) num3 * 338418889 ^ 1745392944;
            continue;
          case 5:
            num1 = (int) num3 * -302535305 ^ -1318798382;
            continue;
          case 6:
            random = new Random(now.Millisecond);
            num1 = (int) num3 * -2078969636 ^ -1585376119;
            continue;
          case 7:
            this.options.ExecuteAs = this.Engine.Settings.GetRandomName();
            num1 = (int) num3 * -722759230 ^ 1435630067;
            continue;
          case 8:
            num1 = (int) num3 * -1144449123 ^ -1600384767;
            continue;
          case 9:
            num1 = (int) num3 * 1143432425 ^ -2111560886;
            continue;
          case 10:
            goto label_3;
          case 11:
            if (this.Options.UserNameList == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 81730958 ^ 1220417908;
            continue;
          case 12:
            num4 = this.Options.UserNameList.Count > 0 ? 1 : 0;
            break;
          case 13:
            int num5 = flag ? 688472010 : (num5 = 1384927140);
            int num6 = (int) num3 * 1619012335;
            num1 = num5 ^ num6;
            continue;
          case 14:
            num1 = (int) num3 * 1479770913 ^ 434583309;
            continue;
          default:
            goto label_20;
        }
        flag = num4 != 0;
        num1 = 2023970609;
      }
label_20:
      return;
label_3:;
    }

    internal string ReportProgress(string status, [CallerMemberName] string reportInitiator = "")
    {
      ActivityBase.\u200E⁬⁬‭‏‬‪⁫‎‬​‬​⁫⁯⁭⁭‭⁫⁯⁪‭‮⁬⁮⁫⁪‪‫⁯‍‪‏‭⁪⁮‭‌⁯‮(CoreObject.log, (object) status);
label_1:
      int num1 = 1365532132;
      object activityLocker;
      while (true)
      {
        int num2 = 489791876;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * 747373068 ^ -698588757;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
        ActivityBase.\u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮(activityLocker, ref flag1);
        this.ProgressReports.Add(status);
label_6:
        int num2 = 587301931;
        while (true)
        {
          int num3 = 489791876;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -56879325 ^ 1086249873;
              continue;
            case 2:
              goto label_6;
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
          int num2 = 1279060092;
          while (true)
          {
            int num3 = 489791876;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                ActivityBase.\u202D‌‭​‌‬⁯⁭‍‎⁮⁫⁯‌‌⁬⁫⁯‭⁮⁯‌⁪‭‭⁯‎‭​‪‬⁯⁬‫‮​⁬‫‬⁪‮(activityLocker);
                num2 = (int) num4 * 476769286 ^ -1311973437;
                continue;
              case 2:
                goto label_10;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_14:
      bool flag2 = !this.Options.SuppressProgressReports;
label_15:
      int num5 = 1716327155;
      string str;
      while (true)
      {
        int num2 = 489791876;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 7U)
        {
          case 0:
            goto label_15;
          case 1:
            num5 = (int) num3 * 184033566 ^ -140931381;
            continue;
          case 2:
            int num4 = !flag2 ? -218095888 : (num4 = -531026853);
            int num6 = (int) num3 * 1237335405;
            num5 = num4 ^ num6;
            continue;
          case 3:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityProgressEvent>()).Publish(new ActivityEventBaseArguments(this, status));
            num5 = (int) num3 * -1512699203 ^ 2105530846;
            continue;
          case 5:
            num5 = (int) num3 * -450500419 ^ 1599062314;
            continue;
          case 6:
            str = status;
            num5 = 1235397447;
            continue;
          default:
            goto label_22;
        }
      }
label_22:
      return str;
    }

    protected virtual int MinimizeWindows(ZoomWindow targetWindow = null)
    {
      List<ZoomWindow> zoomWindowList = (List<ZoomWindow>) null;
      try
      {
        bool flag1 = targetWindow != null;
label_2:
        int num1 = 1082993382;
        while (true)
        {
          int num2 = 1234339176;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              num1 = (int) num3 * -498365190 ^ -2069400513;
              continue;
            case 1:
              int num4 = flag1 ? 1408587762 : (num4 = 1406164235);
              int num5 = (int) num3 * -1755691690;
              num1 = num4 ^ num5;
              continue;
            case 2:
              ActivityBase.\u206D‪‭⁬‍‍‪⁪‌⁯⁬⁯⁮​⁫‮⁯‮‎⁫‏‬⁯‮⁭‬‪⁬​‭​​‪‍‮‮​‫‮‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(766873338U), (object) zoomWindowList.Count);
              num1 = (int) num3 * -519961982 ^ -1733636117;
              continue;
            case 3:
              ActivityBase.\u202E‍⁪‮‎‪‭⁪‪‮‍​⁯‮⁯‪⁮‮‌⁫‏‍‏‌‎‏​‏​​‏⁮‮⁫‌⁭‭⁮⁪⁬‮(CoreObject.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(991927458U), (object) zoomWindowList.Count, (object) targetWindow.ZoomWindowType);
              num1 = (int) num3 * 675324442 ^ 657090779;
              continue;
            case 4:
              num1 = 509937741;
              continue;
            case 6:
              num1 = (int) num3 * -1172658110 ^ -890954477;
              continue;
            case 7:
              num1 = (int) num3 * -65724349 ^ -1083375900;
              continue;
            case 8:
              goto label_2;
            case 9:
              zoomWindowList = this.Engine.GetOverlappedWindows((ZoomWindow) null);
              num1 = 965000543;
              continue;
            case 10:
              zoomWindowList = this.Engine.GetOverlappedWindows(targetWindow);
              num1 = (int) num3 * -42876252 ^ 752755375;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        List<ZoomWindow>.Enumerator enumerator = zoomWindowList.GetEnumerator();
        try
        {
label_25:
          int num2 = !enumerator.MoveNext() ? 1332259534 : (num2 = 1649925856);
          while (true)
          {
            int num3 = 1234339176;
            uint num4;
            ZoomWindow current;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 12U)
            {
              case 0:
                ActivityBase.\u206F​⁬‪⁯⁯‎‎⁭‪⁫​‪‪⁮⁭‎⁪⁮⁫⁪⁫⁪⁯‬‎⁪‎‌⁬‪‭⁯‪‫‎‭‌‪⁪‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2548826550U), (object) current.ZoomWindowType, (object) current.Location);
                WindowHelper.MinimizeWindow(current.Handle);
                flag2 = !this.MinimizedWindows.Contains(current);
                num2 = (int) num4 * -1102863386 ^ 11773971;
                continue;
              case 1:
                num2 = 1575086098;
                continue;
              case 2:
                num2 = (int) num4 * -724015068 ^ 39964993;
                continue;
              case 3:
                num2 = 1649925856;
                continue;
              case 4:
                num2 = 1837474301;
                continue;
              case 5:
                int num5 = !current.IsMinimizable ? -625227999 : (num5 = -1929922208);
                int num6 = (int) num4 * -205431572;
                num2 = num5 ^ num6;
                continue;
              case 6:
                goto label_25;
              case 7:
                num2 = (int) num4 * -1042433780 ^ -1529539764;
                continue;
              case 8:
                current = enumerator.Current;
                num2 = 1178235613;
                continue;
              case 9:
                this.MinimizedWindows.Add(current);
                num2 = (int) num4 * 19192188 ^ 771984939;
                continue;
              case 11:
                int num7 = !flag2 ? -721923884 : (num7 = -1387598622);
                int num8 = (int) num4 * 873506596;
                num2 = num7 ^ num8;
                continue;
              default:
                goto label_36;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
label_28:
          int num2 = 835826505;
          while (true)
          {
            int num3 = 1234339176;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_28;
              case 1:
                num2 = (int) num4 * -161094910 ^ -1663258903;
                continue;
              default:
                goto label_31;
            }
          }
label_31:;
        }
      }
      catch (Exception ex)
      {
label_33:
        int num1 = 336631875;
        while (true)
        {
          int num2 = 1234339176;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              ActivityBase.\u200E‬‍‫‎‪⁪‬‭⁫‫⁬‎⁫‏‏‌​‬‏‮⁫‮⁬⁫‍​⁬‎⁪‌⁭⁬‎‫​⁬‮‎‏‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 1355271479 ^ 1736573044;
              continue;
            case 2:
              goto label_33;
            default:
              goto label_36;
          }
        }
      }
label_36:
      int count = this.MinimizedWindows.Count;
label_37:
      int num9 = 119170680;
      while (true)
      {
        int num1 = 1234339176;
        uint num2;
        switch ((num2 = (uint) (num9 ^ num1)) % 3U)
        {
          case 1:
            num9 = (int) num2 * -1178188439 ^ 2053372449;
            continue;
          case 2:
            goto label_37;
          default:
            goto label_40;
        }
      }
label_40:
      return count;
    }

    protected virtual void RestoreWindows()
    {
      try
      {
label_2:
        int num1 = 1348747037;
        while (true)
        {
          int num2 = 305679504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1066882308 ^ -1478229609;
              continue;
            case 1:
              ActivityBase.\u206D‪‭⁬‍‍‪⁪‌⁯⁬⁯⁮​⁫‮⁯‮‎⁫‏‬⁯‮⁭‬‪⁬​‭​​‪‍‮‮​‫‮‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(235661626U), (object) this.MinimizedWindows.Count);
              num1 = (int) num3 * 604364054 ^ -1910223722;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_6;
          }
        }
label_6:
        using (List<ZoomWindow>.Enumerator enumerator = this.MinimizedWindows.GetEnumerator())
        {
label_12:
          int num2 = enumerator.MoveNext() ? 2044628157 : (num2 = 1406567207);
          while (true)
          {
            int num3 = 305679504;
            uint num4;
            ZoomWindow current;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                num2 = (int) num4 * 429397992 ^ -1686541016;
                continue;
              case 1:
                current = enumerator.Current;
                num2 = 930379378;
                continue;
              case 2:
                num2 = 2044628157;
                continue;
              case 3:
                num2 = (int) num4 * -81381923 ^ 348729947;
                continue;
              case 4:
                WindowHelper.RestoreWindow(current.Handle);
                num2 = (int) num4 * -2122776215 ^ 1982199574;
                continue;
              case 5:
                goto label_23;
              case 6:
                goto label_12;
              default:
                goto label_21;
            }
          }
label_21:
          return;
label_23:;
        }
      }
      catch (Exception ex)
      {
label_19:
        int num1 = 1566808787;
        while (true)
        {
          int num2 = 305679504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_17;
            case 1:
              ActivityBase.\u200E‬‍‫‎‪⁪‬‭⁫‫⁬‎⁫‏‏‌​‬‏‮⁫‮⁬⁫‍​⁬‎⁪‌⁭⁬‎‫​⁬‮‎‏‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 397883948 ^ -1761878449;
              continue;
            case 2:
              goto label_19;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_17:;
      }
    }

    protected bool ClickThenDetectEvent(ZoomWindowType typeWindow, System.Drawing.Point whereToClick, ZoomEventType eventTypeToDetect, ZoomWindowType windowTypeToDetect, int millisecondsToWait = 500)
    {
      ZoomWindow window = this.Engine.GetWindow(typeWindow);
label_1:
      int num1 = -1023548854;
      bool flag1;
      while (true)
      {
        int num2 = -245521349;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            flag2 = window != null;
            num1 = (int) num3 * -643774995 ^ 1797600505;
            continue;
          case 3:
            flag1 = false;
            num1 = -535904661;
            continue;
          case 4:
            window.Refresh(false, true);
            flag1 = this.ClickThenDetectEvent(window, whereToClick, eventTypeToDetect, windowTypeToDetect, millisecondsToWait, true);
            num1 = (int) num3 * -1148539158 ^ 87635819;
            continue;
          case 5:
            int num4 = flag2 ? -247709094 : (num4 = -275273167);
            int num5 = (int) num3 * -1091557441;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return flag1;
    }

    protected bool ClickThenDetectEvent(ZoomWindow windowToClick, System.Drawing.Point whereToClick, ZoomEventType eventTypeToDetect, ZoomWindowType windowTypeToDetect, int millisecondsToWait = 500, bool isLeftClick = true)
    {
label_1:
      int num1 = 599195064;
      bool flag1;
      while (true)
      {
        int num2 = 378469618;
        uint num3;
        bool flag2;
        bool flag3;
        ZoomEvent zoomEvent;
        bool flag4;
        bool flag5;
        DateTime dateTime;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 31U)
        {
          case 0:
            dateTime = DateTime.Now.AddMilliseconds((double) millisecondsToWait);
            num1 = (int) num3 * 255896349 ^ -2021016505;
            continue;
          case 1:
            num1 = 1616200910;
            continue;
          case 2:
            flag2 = this.Engine.ActivityQueue.TryDequeue(ref zoomEvent);
            num1 = 303888366;
            continue;
          case 3:
            flag1 = flag3;
            num1 = 1831618187;
            continue;
          case 5:
            if (!(dateTime >= DateTime.Now))
            {
              num4 = 0;
              break;
            }
            num1 = 80050731;
            continue;
          case 6:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(956555790U), (object) zoomEvent);
            num1 = (int) num3 * -1633301587 ^ 1443193442;
            continue;
          case 7:
            int num6 = flag2 ? -1801437517 : (num6 = -1969577534);
            int num7 = (int) num3 * -383264347;
            num1 = num6 ^ num7;
            continue;
          case 8:
            WindowHelper.ForceForeground(this.MeetingWindow.Handle);
            num1 = (int) num3 * -746915932 ^ -456659139;
            continue;
          case 9:
            flag4 = !flag3;
            num1 = (int) num3 * 1847587853 ^ 1066196077;
            continue;
          case 10:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1686029112U));
            num1 = (int) num3 * 2100677131 ^ -1312083060;
            continue;
          case 11:
            goto label_1;
          case 12:
            flag3 = true;
            num1 = (int) num3 * -54285873 ^ -8717496;
            continue;
          case 13:
            num1 = (int) num3 * -1051372535 ^ 443916181;
            continue;
          case 14:
            num1 = 1118551146;
            continue;
          case 15:
            num5 = zoomEvent.ZoomWindowType == windowTypeToDetect ? 1 : 0;
            goto label_40;
          case 16:
            int num8 = flag5 ? -978504135 : (num8 = -801467727);
            int num9 = (int) num3 * -1950955346;
            num1 = num8 ^ num9;
            continue;
          case 17:
            windowToClick.Click(whereToClick, isLeftClick, true, 0);
            num1 = (int) num3 * -142646290 ^ 1863675527;
            continue;
          case 18:
            int num10 = flag4 ? 850348750 : (num10 = 1865742978);
            int num11 = (int) num3 * 45141302;
            num1 = num10 ^ num11;
            continue;
          case 19:
            flag3 = false;
            num1 = (int) num3 * 1719091075 ^ 808803338;
            continue;
          case 20:
            ActivityBase.\u206F‏⁪‍⁬‎⁬‌‍⁫‏‏‮‭‏⁯⁮⁫⁪‍⁮​‭⁯‬⁮⁫‍‌‮‏‏‬⁮‍‍⁬⁬‮⁪‮(40);
            num1 = (int) num3 * 1932213192 ^ -1947748261;
            continue;
          case 21:
            num1 = (int) num3 * -1954798602 ^ -1114268881;
            continue;
          case 22:
            num4 = !flag3 ? 1 : 0;
            break;
          case 23:
            num1 = (int) num3 * 754790458 ^ 713813345;
            continue;
          case 24:
            num1 = (int) num3 * -1628142205 ^ 435231861;
            continue;
          case 25:
            if (eventTypeToDetect == ZoomEventType.Undefined)
            {
              num1 = (int) num3 * 296214856 ^ -1063124393;
              continue;
            }
            goto label_39;
          case 26:
            num1 = (int) num3 * -1879434053 ^ -1597610310;
            continue;
          case 27:
            this.Engine.PurgeActivityQueue();
            num1 = (int) num3 * -1890052360 ^ 1561892337;
            continue;
          case 28:
            if (zoomEvent.ZoomWindowType == windowTypeToDetect)
            {
              num1 = (int) num3 * -1192264634 ^ 300272172;
              continue;
            }
            goto label_39;
          case 29:
            if (zoomEvent.EventType == eventTypeToDetect)
            {
              num1 = (int) num3 * -1994698767 ^ 530677078;
              continue;
            }
            num5 = 0;
            goto label_40;
          case 30:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2823882641U), (object) windowToClick, (object) whereToClick, (object) millisecondsToWait);
            num1 = (int) num3 * -1991196243 ^ 1143360449;
            continue;
          default:
            goto label_41;
        }
        int num12;
        num1 = num12 = num4 != 0 ? 167906181 : (num12 = 1227738547);
        continue;
label_39:
        num5 = 0;
label_40:
        flag5 = num5 != 0;
        num1 = 1312425081;
      }
label_41:
      return flag1;
    }

    internal void WaitForEvent(ZoomEventType show, ZoomWindowType join, double secondsToWait)
    {
label_1:
      int num1 = -1595846882;
      while (true)
      {
        int num2 = -1835354351;
        uint num3;
        bool flag;
        ZoomEvent pendingEvent;
        DateTime now;
        DateTime dateTime;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            num1 = (int) num3 * 1682552794 ^ -1953098397;
            continue;
          case 1:
            now = DateTime.Now;
            num1 = (int) num3 * 169162217 ^ 2108037031;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            num1 = -1826112038;
            continue;
          case 5:
            num4 = pendingEvent.ZoomWindowType == join ? 1 : 0;
            goto label_8;
          case 6:
            Thread.Sleep(40);
            num1 = (int) num3 * 1558312947 ^ 297786949;
            continue;
          case 7:
            int num5 = flag ? -670247879 : (num5 = -1186313576);
            int num6 = (int) num3 * 1165711531;
            num1 = num5 ^ num6;
            continue;
          case 8:
            pendingEvent = this.GetPendingEvent();
            if (pendingEvent != null)
            {
              num1 = -1980442561;
              continue;
            }
            break;
          case 9:
            if (pendingEvent.EventType == show)
            {
              num1 = (int) num3 * -1194065378 ^ -402359892;
              continue;
            }
            break;
          case 10:
            num1 = (int) num3 * 430777365 ^ -1713091626;
            continue;
          case 11:
            dateTime = now.AddSeconds(secondsToWait);
            num1 = (int) num3 * 860004415 ^ -810758042;
            continue;
          case 12:
            num1 = (int) num3 * -325006561 ^ 1398711332;
            continue;
          case 13:
            int num7 = !(dateTime > DateTime.Now) ? 687488210 : (num7 = 292082006);
            int num8 = (int) num3 * -1122475907;
            num1 = num7 ^ num8;
            continue;
          case 14:
            flag = this.PendingEvents.get_Count() == 0;
            num1 = -1914806417;
            continue;
          default:
            goto label_21;
        }
        num4 = 0;
label_8:
        int num9;
        num1 = num9 = num4 == 0 ? -1691122753 : (num9 = -2046314421);
      }
label_21:
      return;
label_3:;
    }

    protected bool ChangeUserName(string desiredName, bool restoreAfterEnd)
    {
      bool flag1 = false;
label_1:
      int num1 = 1185217985;
      bool flag2;
      while (true)
      {
        int num2 = 354373473;
        uint num3;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            flag2 = flag1;
            num1 = 1123767915;
            continue;
          case 1:
            ActivityBase.\u200B‍‍‫​⁯⁯‎⁫‌‏‌‎⁯‬⁯‍​‭‫‏‌⁯‪‌‭‮⁫‭‭⁪‭‬‪‍⁬⁯⁯‍‫‮(CoreObject.log, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2910331527U), new object[0]);
            num1 = (int) num3 * -1533073556 ^ -1555692258;
            continue;
          case 2:
            ActivityBase.\u206A‎‪‏⁬‪⁪‪‭⁮⁮⁯‭⁫⁭‮‪‭‬‍⁭‭‫⁭‍⁬‫‌‬⁬‏‭​‎⁫⁬‭‮⁪‌‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(147029868U), (object) desiredName);
            num1 = 339428465;
            continue;
          case 3:
            ActivityBase.\u200B‍‍‫​⁯⁯‎⁫‌‏‌‎⁯‬⁯‍​‭‫‏‌⁯‪‌‭‮⁫‭‭⁪‭‬‪‍⁬⁯⁯‍‫‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2230359396U), new object[0]);
            num1 = (int) num3 * -1031111674 ^ -1662390869;
            continue;
          case 4:
            this.Engine.ZoomDatabase.SetZoomUserNameForJoin(desiredName, restoreAfterEnd);
            int num4 = flag3 ? -1836993196 : (num4 = -1297165995);
            int num5 = (int) num3 * -660951568;
            num1 = num4 ^ num5;
            continue;
          case 5:
            num1 = (int) num3 * -880484884 ^ -27054453;
            continue;
          case 6:
            this.Engine.KillZoomProcesses();
            num1 = (int) num3 * 264432978 ^ 853123691;
            continue;
          case 7:
            this.Engine.ZoomDatabase.Logout(restoreAfterEnd);
            num1 = (int) num3 * -1649248054 ^ -1844835218;
            continue;
          case 8:
            flag3 = false;
            num1 = (int) num3 * 896673164 ^ -1954826500;
            continue;
          case 9:
            num1 = (int) num3 * -1377604324 ^ -269835433;
            continue;
          case 10:
            num1 = (int) num3 * -1731389156 ^ -1398320518;
            continue;
          case 11:
            num1 = (int) num3 * 454084004 ^ -1798869520;
            continue;
          case 12:
            num1 = (int) num3 * 776008274 ^ -1160466134;
            continue;
          case 13:
            int num6 = !this.Engine.ZoomDatabase.IsLoggedIn() ? -987007896 : (num6 = -906698199);
            int num7 = (int) num3 * -757734437;
            num1 = num6 ^ num7;
            continue;
          case 14:
            flag3 = true;
            num1 = (int) num3 * 1471919681 ^ -1134491822;
            continue;
          case 15:
            num1 = (int) num3 * -576940891 ^ -52289603;
            continue;
          case 16:
            goto label_1;
          case 17:
            ActivityBase.\u200B‍‍‫​⁯⁯‎⁫‌‏‌‎⁯‬⁯‍​‭‫‏‌⁯‪‌‭‮⁫‭‭⁪‭‬‪‍⁬⁯⁯‍‫‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2358667636U), new object[0]);
            num1 = (int) num3 * -527146574 ^ -472086431;
            continue;
          case 18:
            num1 = (int) num3 * 1792918962 ^ -119797239;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return flag2;
    }

    protected bool RestoreUserName()
    {
      ActivityBase.\u200E⁬⁬‭‏‬‪⁫‎‬​‬​⁫⁯⁭⁭‭⁫⁯⁪‭‮⁬⁮⁫⁪‪‫⁯‍‪‏‭⁪⁮‭‌⁯‮(CoreObject.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3448633236U));
      bool flag1 = this.Engine.ZoomDatabase.IsLoginBackedup();
label_1:
      int num1 = -63664253;
      bool flag2;
      while (true)
      {
        int num2 = -1794984237;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * 1091407021 ^ 753580415;
            continue;
          case 1:
            num1 = (int) num3 * -1889846660 ^ -253170813;
            continue;
          case 2:
            num1 = (int) num3 * 1779808441 ^ -746210348;
            continue;
          case 3:
            num1 = (int) num3 * 296694138 ^ -1219270568;
            continue;
          case 5:
            flag2 = true;
            num1 = (int) num3 * -312586411 ^ 1305352722;
            continue;
          case 6:
            flag2 = false;
            num1 = (int) num3 * -1926905948 ^ -239928902;
            continue;
          case 7:
            ActivityBase.\u200E⁬⁬‭‏‬‪⁫‎‬​‬​⁫⁯⁭⁭‭⁫⁯⁪‭‮⁬⁮⁫⁪‪‫⁯‍‪‏‭⁪⁮‭‌⁯‮(CoreObject.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2317226309U));
            this.Engine.ZoomDatabase.RestoreLogin();
            num1 = (int) num3 * 1063105382 ^ 1866627227;
            continue;
          case 8:
            int num4 = flag1 ? -1554890376 : (num4 = -1985592923);
            int num5 = (int) num3 * -1234398841;
            num1 = num4 ^ num5;
            continue;
          case 9:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2957645917U));
            num1 = (int) num3 * -340801792 ^ -1219546972;
            continue;
          case 10:
            ActivityBase.\u200E⁬⁬‭‏‬‪⁫‎‬​‬​⁫⁯⁭⁭‭⁫⁯⁪‭‮⁬⁮⁫⁪‪‫⁯‍‪‏‭⁪⁮‭‌⁯‮(CoreObject.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2867261199U));
            num1 = -265942055;
            continue;
          case 11:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_13:
      return flag2;
    }

    protected ActivityState ExecuteSubActivity(ActivityBase subActivity, bool suppressReports = true)
    {
      ActivityState activityState1 = ActivityState.InProgress;
      this.Trace(TraceType.Activity, ActivityBase.\u206E‫‎⁬⁯⁬‏‭​‭⁪⁭​⁪⁬‭‌⁭⁪⁮‮‭‏⁬‬‮‍⁬‬‏‎‎⁫⁭⁭⁭‏⁭⁫‭‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3411623988U), subActivity.Name));
label_1:
      int num1 = -899819;
      ActivityState activityState2;
      while (true)
      {
        int num2 = -1190924247;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1070980849 ^ 682383057;
            continue;
          case 2:
            num1 = (int) num3 * -1736573533 ^ 1801984009;
            continue;
          case 3:
            activityState2 = activityState1;
            num1 = (int) num3 * -1873561276 ^ -1092408244;
            continue;
          case 4:
            activityState1 = subActivity.Execute(this.Token);
            num1 = -215903193;
            continue;
          case 5:
            int num5 = flag ? 1801029398 : (num5 = 1807630516);
            int num6 = (int) num3 * 230412605;
            num1 = num5 ^ num6;
            continue;
          case 6:
            if (!suppressReports)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -187589178 ^ -1598527114;
            continue;
          case 8:
            subActivity.Options.SuppressProgressReports = true;
            num1 = (int) num3 * -132665290 ^ 1368718489;
            continue;
          case 9:
            num1 = (int) num3 * 824205456 ^ -1786336487;
            continue;
          case 10:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(732914266U), (object) activityState1);
            num1 = (int) num3 * 843661650 ^ 745693668;
            continue;
          case 11:
            num1 = (int) num3 * 1534154990 ^ -415964374;
            continue;
          case 12:
            subActivity.ParentActivity = this;
            num1 = (int) num3 * 1519753245 ^ -1673728054;
            continue;
          case 13:
            num4 = !subActivity.Options.SuppressProgressReports ? 1 : 0;
            break;
          default:
            goto label_18;
        }
        flag = num4 != 0;
        num1 = -1237728888;
      }
label_18:
      return activityState2;
    }

    internal void Reject()
    {
      object activityLocker = ActivityBase.activityLocker;
      bool flag = false;
      try
      {
        ActivityBase.\u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮(activityLocker, ref flag);
label_2:
        int num1 = 2018004396;
        while (true)
        {
          int num2 = 140563894;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_10;
            case 2:
              num1 = (int) num3 * 1306056793 ^ 706676991;
              continue;
            case 3:
              this.AuthorizationState = AuthorizationStates.Rejected;
              num1 = (int) num3 * 496335354 ^ -1991903935;
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
          int num1 = 8867483;
          while (true)
          {
            int num2 = 140563894;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -1039476046 ^ 241973349;
                continue;
              case 1:
                ActivityBase.\u202D‌‭​‌‬⁯⁭‍‎⁮⁫⁯‌‌⁬⁫⁯‭⁮⁯‌⁪‭‭⁯‎‭​‪‬⁯⁬‫‮​⁬‫‬⁪‮(activityLocker);
                num1 = (int) num3 * -586566767 ^ 100014043;
                continue;
              case 2:
                goto label_8;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    internal void Authorize()
    {
      object activityLocker = ActivityBase.activityLocker;
      bool flag = false;
      try
      {
        ActivityBase.\u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮(activityLocker, ref flag);
label_2:
        int num1 = 596205908;
        while (true)
        {
          int num2 = 765274133;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.AuthorizationState = AuthorizationStates.Authorized;
              num1 = (int) num3 * -1792701691 ^ -736206594;
              continue;
            case 1:
              num1 = (int) num3 * 55026431 ^ -2013710312;
              continue;
            case 2:
              goto label_2;
            case 3:
              num1 = (int) num3 * 778541842 ^ -1980476486;
              continue;
            case 4:
              num1 = (int) num3 * -124277550 ^ 1130176145;
              continue;
            case 5:
              goto label_12;
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
          int num1 = 976179520;
          while (true)
          {
            int num2 = 765274133;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                ActivityBase.\u202D‌‭​‌‬⁯⁭‍‎⁮⁫⁯‌‌⁬⁫⁯‭⁮⁯‌⁪‭‭⁯‎‭​‪‬⁯⁬‫‮​⁬‫‬⁪‮(activityLocker);
                num1 = (int) num3 * 1617687889 ^ -375672526;
                continue;
              case 2:
                num1 = (int) num3 * -424408701 ^ 1673539011;
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

    public override Dictionary<string, object> GetDataDictionary()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
label_1:
      int num1 = 1538049540;
      Dictionary<string, object> dictionary2;
      while (true)
      {
        int num2 = 1412056187;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * 1395354854 ^ -1553718968;
            continue;
          case 2:
            num1 = (int) num3 * 1554928184 ^ 2086846378;
            continue;
          case 3:
            dictionary1.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3375854762U), (object) this.name);
            num1 = (int) num3 * 701827728 ^ 513309263;
            continue;
          case 4:
            dictionary1.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3675457296U), (object) this.title);
            dictionary1.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(833447051U), (object) this.GetXmlContent(this));
            num1 = (int) num3 * 1164208546 ^ 21292757;
            continue;
          case 5:
            goto label_1;
          case 6:
            dictionary2 = dictionary1;
            num1 = (int) num3 * 2074952236 ^ -1692794623;
            continue;
          case 7:
            dictionary1.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809658423U), (object) this.Uri);
            num1 = (int) num3 * 1856477394 ^ 1110259125;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return dictionary2;
    }

    public override bool LoadDataObject(SQLiteDataReader cReader)
    {
      bool flag = false;
label_1:
      int num1 = 725765316;
      while (true)
      {
        int num2 = 1528536352;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1898637965 ^ 2139036970;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    public static ActivityBase Load(SQLiteDataReader cReader)
    {
      bool flag1 = false;
      ActivityBase activityBase1 = (ActivityBase) null;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ActivityBase.\u003C\u003Ec__DisplayClass123_0 displayClass1230 = new ActivityBase.\u003C\u003Ec__DisplayClass123_0();
label_2:
        int num1 = -19781635;
        while (true)
        {
          int num2 = -1931649723;
          uint num3;
          Type type;
          XmlSerializer xmlSerializer;
          Assembly assembly;
          bool flag2;
          object obj;
          string fieldValueString;
          TextReader textReader;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              num1 = (int) num3 * -948774353 ^ 1499614233;
              continue;
            case 1:
              flag1 = true;
              num1 = (int) num3 * -230122499 ^ -284935248;
              continue;
            case 2:
              fieldValueString = cReader.GetFieldValueString(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3921276970U));
              assembly = ActivityBase.\u200B‪‍‬⁭⁫‬‌‮‌⁭‎‍⁪⁬⁬⁭‫‏⁪⁬‬‎⁮⁭‏⁮⁮‎‎‭‪‪‎⁯‮‌⁪‫⁯‮();
              num1 = (int) num3 * 1811408814 ^ -234614330;
              continue;
            case 3:
              // ISSUE: method pointer
              type = (Type) Enumerable.First<Type>((IEnumerable<M0>) ActivityBase.\u206E‏​⁫‎⁬‭‏‮‍‪⁮‏‫‏​⁫‬⁪‫​‪‌‪‎⁭‪⁮‭‍⁫⁯‬⁮⁫‎‮‬‭‫‮(assembly), (Func<M0, bool>) new Func<Type, bool>((object) displayClass1230, __methodptr(\u003CLoad\u003Eb__0)));
              flag2 = ActivityBase.\u206D​‪⁭⁮‏‪⁪⁫⁬‮⁮⁫‏‏⁭‌‍‏‌⁬‏‎‮‏‬‌‌‍⁫​‭⁬⁪⁯⁪​‬‎⁮‮(type, (Type) null);
              num1 = (int) num3 * 2088834932 ^ 283862659;
              continue;
            case 4:
              int num4 = !flag2 ? 541652993 : (num4 = 2073901563);
              int num5 = (int) num3 * 199631756;
              num1 = num4 ^ num5;
              continue;
            case 5:
              activityBase1 = (ActivityBase) obj;
              num1 = (int) num3 * 800424834 ^ -1035374473;
              continue;
            case 6:
              num1 = (int) num3 * -471455941 ^ 1822699504;
              continue;
            case 7:
              goto label_2;
            case 8:
              ActivityBase.\u202A‍‏‏⁭⁮⁯⁭⁬⁪‎‭⁭‪‍‫‎⁫⁪⁫⁬‪⁪⁫⁫‮‪‍⁬‮⁭⁮‎⁯​‌⁮‍⁬‪‮(textReader);
              num1 = (int) num3 * -1237457964 ^ 1208838930;
              continue;
            case 10:
              xmlSerializer = ActivityBase.\u200C‌‮⁯‎‏‫⁬‏⁯‏⁭⁯‍‫‬⁮‮‍‏‌‍⁬‎‍⁭‍‫⁮‭‍‬⁪⁪‎‭‫⁫⁪‎‮(type);
              num1 = (int) num3 * -1565679093 ^ 1791754710;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated field
              displayClass1230.name = cReader.GetFieldValueString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1705049006U));
              num1 = (int) num3 * 1698892090 ^ -984175756;
              continue;
            case 12:
              textReader = (TextReader) ActivityBase.\u200B‮‮‭⁪‭‏⁪‎‏‎⁪​​​‬‏‏⁮‫⁪⁬‬‬‭‫‫⁯​⁪‍‪⁪​‭‏‭‭‬‌‮(fieldValueString);
              obj = ActivityBase.\u200D⁫‭​‮‏‬‭‪‫⁬‮⁮‏⁯⁪⁬‪⁪‭‬‎‫‬‌⁫⁮‪⁭‏⁯⁫‫⁯‏⁪‌‎‍⁫‮(xmlSerializer, textReader);
              num1 = (int) num3 * -498772549 ^ 1538743705;
              continue;
            default:
              goto label_19;
          }
        }
      }
      catch (Exception ex)
      {
label_16:
        int num1 = -76753607;
        while (true)
        {
          int num2 = -1931649723;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              ActivityBase.\u200E‬‍‫‎‪⁪‬‭⁫‫⁬‎⁫‏‏‌​‬‏‮⁫‮⁬⁫‍​⁬‎⁪‌⁭⁬‎‫​⁬‮‎‏‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 507393871 ^ 1917956925;
              continue;
            case 2:
              goto label_16;
            default:
              goto label_19;
          }
        }
      }
label_19:
      ActivityBase activityBase2 = activityBase1;
label_20:
      int num6 = -780504290;
      while (true)
      {
        int num1 = -1931649723;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 1:
            num6 = (int) num2 * -1535122920 ^ 1872625258;
            continue;
          case 2:
            goto label_20;
          default:
            goto label_23;
        }
      }
label_23:
      return activityBase2;
    }

    public string GetXmlContent(ActivityBase activity)
    {
      string str = string.Empty;
label_1:
      int num1 = 1830129294;
      XmlSerializer xmlSerializer;
      while (true)
      {
        int num2 = 810176564;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            xmlSerializer = ActivityBase.\u200C‌‮⁯‎‏‫⁬‏⁯‏⁭⁯‍‫‬⁮‮‍‏‌‍⁬‎‍⁭‍‫⁮‭‍‬⁪⁪‎‭‫⁫⁪‎‮(ActivityBase.\u206B‍‭‎‪⁮‏‎‏‭⁪⁪‎⁬⁪⁭‍‍⁭‌‎⁭‌⁯⁮‪‏‮‏⁮‫‎⁭‎​‌‍‭‬‬‮((object) activity));
            num1 = (int) num3 * 763435448 ^ 2103796602;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      StringWriter stringWriter = ActivityBase.\u200F⁯⁮⁫‏‏‎⁮⁫‌⁯​⁪⁭‭‎‎‎‬‌‭‏⁫​‎⁮‪⁮‬‫‌​‌⁮‮⁭‌​⁬‭‮();
      try
      {
        ActivityBase.\u200F⁬‍⁬⁬‏​⁫​‫‍‬‭‫‪‪⁪⁭‌‍‏⁪⁪⁪‏⁯‬‎‎⁮⁬‮⁪⁬‍⁭‭‍‫⁮‮(xmlSerializer, (TextWriter) stringWriter, (object) activity);
label_6:
        int num2 = 1386331035;
        while (true)
        {
          int num3 = 810176564;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_6;
            case 2:
              num2 = (int) num4 * -307435854 ^ 1142242669;
              continue;
            case 3:
              str = ActivityBase.\u202E‫‪‮⁯⁯‏⁫‪‏‭⁬⁫‏⁪⁮⁬⁫⁯‬‪‫‏‪​⁭⁪‌⁫⁮‭‎‌‭‍⁫⁪⁮⁭‫‮((object) stringWriter);
              num2 = (int) num4 * -365630379 ^ 1357450461;
              continue;
            default:
              goto label_16;
          }
        }
      }
      finally
      {
        if (stringWriter != null)
        {
label_11:
          int num2 = 560837229;
          while (true)
          {
            int num3 = 810176564;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                ActivityBase.\u200C⁭‌‌​‭‫‮‬‫⁭⁭‪‌‍⁭⁪‪‍‭‌⁫⁬‌⁫⁬⁮‭⁫‫‫​⁯‎‎⁯‬‎⁮⁪‮((IDisposable) stringWriter);
                num2 = (int) num4 * -1521603546 ^ -1533603788;
                continue;
              case 2:
                num2 = (int) num4 * 400291229 ^ 1935761138;
                continue;
              case 3:
                goto label_11;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_16:
      return str;
    }

    static bool \u206D⁯‌‎‭‮‎‮⁭‎‍‪‍⁫‫⁪⁬‎‎‭⁯‭‎⁬‌​‭​‫⁮⁭‪‏‏‌‮‏​‍‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static Type \u200F‫‫⁮‮⁯⁫‎​‌‮⁪⁯‏⁮⁬​‏⁮‏‍⁭‍‍⁬‭⁮⁪‬‍‍​⁭‌⁬‫‭‏‭‮‮([In] object obj0)
    {
      return obj0.GetType();
    }

    static string \u206E‬⁪⁫⁭‏‎⁬⁪‎⁮‮​‬⁪⁬‫⁭⁪‎⁮⁪⁪⁮‌‍‎‭⁬‍‪‫⁬⁮‪⁭​‭⁮‏‮([In] MemberInfo obj0)
    {
      return obj0.Name;
    }

    static string \u202E‫‪‮⁯⁯‏⁫‪‏‭⁬⁫‏⁪⁮⁬⁫⁯‬‪‫‏‪​⁭⁪‌⁫⁮‭‎‌‭‍⁫⁪⁮⁭‫‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static void \u200B‫‬‬‍‫⁫‍⁬‬‭‮⁬‏‍⁭‏‮‏‫‎‭‏⁮‎⁮‬⁪⁭⁯⁪⁭⁬⁭⁪‫‌‍‏⁮‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202D‌‭​‌‬⁯⁭‍‎⁮⁫⁯‌‌⁬⁫⁯‭⁮⁯‌⁪‭‭⁯‎‭​‪‬⁯⁬‫‮​⁬‫‬⁪‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static bool \u202E‏⁮‪‮‬⁬‮‌‎‬‭‮‬​⁯‎‭⁫⁮‎⁫‬⁯‬‪‪‬‭⁯⁫‮‍‫​‮‭‮​‬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    bool \u202C⁫‪⁮‭​​⁪‌‍⁬‬​⁯⁯⁯​⁬⁪‍⁪⁮‌‏⁮​⁭‌‎‫​⁪‪‏​‪‎‫⁯‬‮([In] object obj0)
    {
      return base.Equals(obj0);
    }

    static int \u202C⁪⁭⁮​⁭⁭‮‭⁫‭‬‌‍⁯‎​‪​⁭⁫‪⁭‮⁪⁮⁯‏‬‏⁭‪‎⁪⁭‬‌⁫‭‫‮([In] object obj0)
    {
      return obj0.GetHashCode();
    }

    static bool \u206A⁬‫‏‮‫‌‎​⁮‬⁮‮‬‬⁫⁪‎⁮‍‍‍‭‍‎‪‏​‬‎⁭​⁭‍​‏‎‪⁬⁭‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static void \u206F​⁬‪⁯⁯‎‎⁭‪⁫​‪‪⁮⁭‎⁪⁮⁫⁪⁫⁪⁯‬‎⁪‎‌⁬‪‭⁯‪‫‎‭‌‪⁪‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.DebugFormat(obj1, obj2, obj3);
    }

    static string \u202A‎⁯‏⁯⁪⁪‎⁭‏‫‭‍‎​‎⁬‪‍‎‮⁮​⁫‫‌‪​‌⁯‮⁯‏⁪⁬‮⁬​‍⁯‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      return string.Format(obj0, obj1, obj2, obj3);
    }

    static void \u200B‍‍‫​⁯⁯‎⁫‌‏‌‎⁯‬⁯‍​‭‫‏‌⁯‪‌‭‮⁫‭‭⁪‭‬‪‍⁬⁯⁯‍‫‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u206A‎‪‏⁬‪⁪‪‭⁮⁮⁯‭⁫⁭‮‪‭‬‍⁭‭‫⁭‍⁬‫‌‬⁬‏‭​‎⁫⁬‭‮⁪‌‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u200E‬‍‫‎‪⁪‬‭⁫‫⁬‎⁫‏‏‌​‬‏‮⁫‮⁬⁫‍​⁬‎⁪‌⁭⁬‎‫​⁬‮‎‏‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static string \u206A‍‪‍⁫‭⁯⁯⁮‭⁮‌⁫‎⁭‍‭‪⁪‪‍⁬‍​‎⁫⁯‬‭‫​‮‫⁬‫⁭‬‮‍‍‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u206D‫‏‮​‭⁬⁯‎‌‪‭⁮‪⁫‏⁭‪⁭‏⁪‮‍‏⁬‮⁮‮⁭⁬‏⁭‎⁬‍⁯⁭‏⁯⁪‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u200E⁬⁬‭‏‬‪⁫‎‬​‬​⁫⁯⁭⁭‭⁫⁯⁪‭‮⁬⁮⁫⁪‪‫⁯‍‪‏‭⁪⁮‭‌⁯‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static void \u202E‍⁪‮‎‪‭⁪‪‮‍​⁯‮⁯‪⁮‮‌⁫‏‍‏‌‎‏​‏​​‏⁮‮⁫‌⁭‭⁮⁪⁬‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.InfoFormat(obj1, obj2, obj3);
    }

    static void \u206D‪‭⁬‍‍‪⁪‌⁯⁬⁯⁮​⁫‮⁯‮‎⁫‏‬⁯‮⁭‬‪⁬​‭​​‪‍‮‮​‫‮‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.InfoFormat(obj1, obj2);
    }

    static void \u206F‏⁪‍⁬‎⁬‌‍⁫‏‏‮‭‏⁯⁮⁫⁪‍⁮​‭⁯‬⁮⁫‍‌‮‏‏‬⁮‍‍⁬⁬‮⁪‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static string \u206E‫‎⁬⁯⁬‏‭​‭⁪⁭​⁪⁬‭‌⁭⁪⁮‮‭‏⁬‬‮‍⁬‬‏‎‎⁫⁭⁭⁭‏⁭⁫‭‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static Assembly \u200B‪‍‬⁭⁫‬‌‮‌⁭‎‍⁪⁬⁬⁭‫‏⁪⁬‬‎⁮⁭‏⁮⁮‎‎‭‪‪‎⁯‮‌⁪‫⁯‮()
    {
      return Assembly.GetExecutingAssembly();
    }

    static Type[] \u206E‏​⁫‎⁬‭‏‮‍‪⁮‏‫‏​⁫‬⁪‫​‪‌‪‎⁭‪⁮‭‍⁫⁯‬⁮⁫‎‮‬‭‫‮([In] Assembly obj0)
    {
      return obj0.GetTypes();
    }

    static bool \u206D​‪⁭⁮‏‪⁪⁫⁬‮⁮⁫‏‏⁭‌‍‏‌⁬‏‎‮‏‬‌‌‍⁫​‭⁬⁪⁯⁪​‬‎⁮‮([In] Type obj0, [In] Type obj1)
    {
      return Type.op_Inequality(obj0, obj1);
    }

    static XmlSerializer \u200C‌‮⁯‎‏‫⁬‏⁯‏⁭⁯‍‫‬⁮‮‍‏‌‍⁬‎‍⁭‍‫⁮‭‍‬⁪⁪‎‭‫⁫⁪‎‮([In] Type obj0)
    {
      return new XmlSerializer(obj0);
    }

    static StreamReader \u200B‮‮‭⁪‭‏⁪‎‏‎⁪​​​‬‏‏⁮‫⁪⁬‬‬‭‫‫⁯​⁪‍‪⁪​‭‏‭‭‬‌‮([In] string obj0)
    {
      return new StreamReader(obj0);
    }

    static object \u200D⁫‭​‮‏‬‭‪‫⁬‮⁮‏⁯⁪⁬‪⁪‭‬‎‫‬‌⁫⁮‪⁭‏⁯⁫‫⁯‏⁪‌‎‍⁫‮([In] XmlSerializer obj0, [In] TextReader obj1)
    {
      return obj0.Deserialize(obj1);
    }

    static void \u202A‍‏‏⁭⁮⁯⁭⁬⁪‎‭⁭‪‍‫‎⁫⁪⁫⁬‪⁪⁫⁫‮‪‍⁬‮⁭⁮‎⁯​‌⁮‍⁬‪‮([In] TextReader obj0)
    {
      obj0.Close();
    }

    static Type \u206B‍‭‎‪⁮‏‎‏‭⁪⁪‎⁬⁪⁭‍‍⁭‌‎⁭‌⁯⁮‪‏‮‏⁮‫‎⁭‎​‌‍‭‬‬‮([In] object obj0)
    {
      return obj0.GetType();
    }

    static StringWriter \u200F⁯⁮⁫‏‏‎⁮⁫‌⁯​⁪⁭‭‎‎‎‬‌‭‏⁫​‎⁮‪⁮‬‫‌​‌⁮‮⁭‌​⁬‭‮()
    {
      return new StringWriter();
    }

    static void \u200F⁬‍⁬⁬‏​⁫​‫‍‬‭‫‪‪⁪⁭‌‍‏⁪⁪⁪‏⁯‬‎‎⁮⁬‮⁪⁬‍⁭‭‍‫⁮‮([In] XmlSerializer obj0, [In] TextWriter obj1, [In] object obj2)
    {
      obj0.Serialize(obj1, obj2);
    }

    static void \u200C⁭‌‌​‭‫‮‬‫⁭⁭‪‌‍⁭⁪‪‍‭‌⁫⁬‌⁫⁬⁮‭⁫‫‫​⁯‎‎⁯‬‎⁮⁪‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static object \u202E‭⁮⁪‏‌‏‪⁭⁮‍⁪‏‪‫‍​​​⁯⁬‌⁫‫⁪‬⁭‪‭⁮⁫‬‮‮‭​⁯‏‪⁯‮()
    {
      return new object();
    }
  }
}
