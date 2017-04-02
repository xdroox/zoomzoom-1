// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ActivityManager
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ZoomZoom.Models.Activities;

namespace ZoomZoom
{
  public class ActivityManager : ManagerBase
  {
    private static ActivityManager instance = (ActivityManager) null;
    private static volatile CancellationTokenSource sourceToken = ActivityManager.\u202C‬‌⁫‌‎⁪‎⁭⁯‌⁭‮⁭⁯⁭⁮‍‪⁮‮‏⁮‏‮⁪‎⁯‌‫‎‎⁭‭⁮‬‫⁫​‌‮();
    private DateTime idleSince = DateTime.MinValue;
    private string activeGuid = "";
    private List<string> queuedActivityStarts = new List<string>();
    private static IntPtr mainWindowHandle;
    private static Process mainProcess;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -1782170819;
        TraceType traceType;
        while (true)
        {
          int num2 = -590994512;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -708288878 ^ 1548423123;
              continue;
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * 2008133338 ^ 1231662586;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public ActivityBase ActiveActivity
    {
      get
      {
label_1:
        int num1 = -1188138506;
        ActivityBase activeActivity;
        while (true)
        {
          int num2 = -1741162060;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              activeActivity = this.Engine.ActiveActivity;
              num1 = (int) num3 * -1314127753 ^ 737010196;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeActivity;
      }
    }

    public static ActivityManager Instance
    {
      get
      {
        if (ActivityManager.instance == null)
        {
          object managerLock = ManagerBase.managerLock;
          bool flag1 = false;
          try
          {
            ActivityManager.\u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮(managerLock, ref flag1);
label_3:
            int num1 = -1890673290;
            while (true)
            {
              int num2 = -2118027021;
              uint num3;
              bool flag2;
              switch ((num3 = (uint) (num1 ^ num2)) % 8U)
              {
                case 0:
                  goto label_3;
                case 1:
                  num1 = (int) num3 * 1505075654 ^ -1712963969;
                  continue;
                case 2:
                  ActivityManager.instance = new ActivityManager();
                  num1 = (int) num3 * -895295197 ^ -1732336086;
                  continue;
                case 3:
                  int num4 = !flag2 ? -316488772 : (num4 = -814117039);
                  int num5 = (int) num3 * -217710055;
                  num1 = num4 ^ num5;
                  continue;
                case 5:
                  num1 = (int) num3 * -557753039 ^ -1112221184;
                  continue;
                case 6:
                  flag2 = ActivityManager.instance == null;
                  num1 = (int) num3 * -129565791 ^ 1093181030;
                  continue;
                case 7:
                  num1 = (int) num3 * -853500302 ^ 1832876441;
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
label_12:
              int num1 = -1251882318;
              while (true)
              {
                int num2 = -2118027021;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 4U)
                {
                  case 0:
                    goto label_12;
                  case 1:
                    ActivityManager.\u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮(managerLock);
                    num1 = (int) num3 * 1652671185 ^ -218312523;
                    continue;
                  case 3:
                    num1 = (int) num3 * -361813442 ^ -1467008293;
                    continue;
                  default:
                    goto label_16;
                }
              }
            }
label_16:;
          }
label_17:;
        }
        else
          goto label_20;
label_18:
        int num6 = -1706407344;
label_19:
        int num7 = -2118027021;
        uint num8;
        ActivityManager instance;
        switch ((num8 = (uint) (num6 ^ num7)) % 3U)
        {
          case 0:
            goto label_18;
          case 1:
            break;
          default:
            return instance;
        }
label_20:
        instance = ActivityManager.instance;
        num6 = -1665595775;
        goto label_19;
      }
    }

    public string ActiveGuid
    {
      get
      {
        string activeGuid = this.activeGuid;
label_1:
        int num1 = 718918598;
        while (true)
        {
          int num2 = 967195141;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1168396412 ^ 911392394;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return activeGuid;
      }
      set
      {
label_1:
        int num1 = -413747676;
        while (true)
        {
          int num2 = -302630184;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.activeGuid = value;
              num1 = (int) num3 * 1019776136 ^ 1203280331;
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

    public event EventHandler OnActivityStarted
    {
      add
      {
        EventHandler eventHandler = this.OnActivityStarted;
label_1:
        int num1 = 1610510;
        while (true)
        {
          int num2 = 1175811637;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              EventHandler comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityStarted, (EventHandler) ActivityManager.\u206F⁪‏‌⁫‌‬‪⁭‍⁫⁪‎‍‏​⁮‭‫‬⁬⁭⁫‎‎‌‪⁯⁪‌⁫‬‍⁯‭‪⁫⁯​⁫‮((Delegate) comparand, (Delegate) value), comparand);
              int num4;
              num1 = num4 = eventHandler == comparand ? 2126989018 : (num4 = 1610510);
              continue;
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
        EventHandler eventHandler1 = this.OnActivityStarted;
label_1:
        int num1 = -140397944;
        while (true)
        {
          int num2 = -659961749;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler2 = (EventHandler) ActivityManager.\u202C‍⁭‏‍⁪‌‪‬⁪‏⁯⁯⁮‭​⁪⁪⁭⁫‏‏‭⁫⁬⁪⁮‫‌‮‏⁯​‎‎‭⁯‏⁪‭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1829257744 ^ 1172781559;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityStarted, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? -250284280 : (num4 = -850660144);
              int num5 = (int) num3 * -310823462;
              num1 = num4 ^ num5;
              continue;
            case 4:
              comparand = eventHandler1;
              num1 = -1703100433;
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
        int num1 = -729799939;
        while (true)
        {
          int num2 = -776306031;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler1;
              num1 = -1626517812;
              continue;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityEnded, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? 793424117 : (num4 = 1825676930);
              int num5 = (int) num3 * -773981994;
              num1 = num4 ^ num5;
              continue;
            case 3:
              eventHandler2 = (EventHandler) ActivityManager.\u206F⁪‏‌⁫‌‬‪⁭‍⁫⁪‎‍‏​⁮‭‫‬⁬⁭⁫‎‎‌‪⁯⁪‌⁫‬‍⁯‭‪⁫⁯​⁫‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -698841525 ^ -306031710;
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
        EventHandler eventHandler = this.OnActivityEnded;
label_1:
        int num1 = 392452042;
        while (true)
        {
          int num2 = 679951127;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityEnded, (EventHandler) ActivityManager.\u202C‍⁭‏‍⁪‌‪‬⁪‏⁯⁯⁮‭​⁪⁪⁭⁫‏‏‭⁫⁬⁪⁮‫‌‮‏⁯​‎‎‭⁯‏⁪‭‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = eventHandler == comparand ? 1911311101 : (num4 = 427238154);
              int num5 = (int) num3 * -1769285016;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = eventHandler;
              num1 = 1894045679;
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

    public event EventHandler OnActivityUpdated
    {
      add
      {
        EventHandler eventHandler = this.OnActivityUpdated;
label_1:
        int num1 = -2082381517;
        while (true)
        {
          int num2 = -920853826;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityUpdated, (EventHandler) ActivityManager.\u206F⁪‏‌⁫‌‬‪⁭‍⁫⁪‎‍‏​⁮‭‫‬⁬⁭⁫‎‎‌‪⁯⁪‌⁫‬‍⁯‭‪⁫⁯​⁫‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = -1972327956;
              continue;
            case 2:
              int num4 = eventHandler == comparand ? -1599012426 : (num4 = -1891959425);
              int num5 = (int) num3 * 290179254;
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
      remove
      {
        EventHandler eventHandler = this.OnActivityUpdated;
label_1:
        int num1 = 992428791;
        while (true)
        {
          int num2 = 509759198;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityUpdated, (EventHandler) ActivityManager.\u202C‍⁭‏‍⁪‌‪‬⁪‏⁯⁯⁮‭​⁪⁪⁭⁫‏‏‭⁫⁬⁪⁮‫‌‮‏⁯​‎‎‭⁯‏⁪‭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = 627214545;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = eventHandler != comparand ? -1884350985 : (num4 = -160496814);
              int num5 = (int) num3 * 2007054592;
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

    public event EventHandler OnActivityProgressReport
    {
      add
      {
        EventHandler eventHandler = this.OnActivityProgressReport;
label_1:
        int num1 = 636683550;
        while (true)
        {
          int num2 = 1500483104;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityProgressReport, (EventHandler) ActivityManager.\u206F⁪‏‌⁫‌‬‪⁭‍⁫⁪‎‍‏​⁮‭‫‬⁬⁭⁫‎‎‌‪⁯⁪‌⁫‬‍⁯‭‪⁫⁯​⁫‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * 1429142656 ^ 60821369;
              continue;
            case 1:
              comparand = eventHandler;
              num1 = 1581282269;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              int num4 = eventHandler == comparand ? -1969387838 : (num4 = -2037606097);
              int num5 = (int) num3 * -896003047;
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
      remove
      {
        EventHandler eventHandler1 = this.OnActivityProgressReport;
label_1:
        int num1 = 1381761495;
        while (true)
        {
          int num2 = 15400402;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnActivityProgressReport, eventHandler2, comparand);
              num1 = (int) num3 * -517376856 ^ 820027185;
              continue;
            case 1:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) ActivityManager.\u202C‍⁭‏‍⁪‌‪‬⁪‏⁯⁯⁮‭​⁪⁪⁭⁫‏‏‭⁫⁬⁪⁮‫‌‮‏⁯​‎‎‭⁯‏⁪‭‮((Delegate) comparand, (Delegate) value);
              num1 = 1302718471;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = eventHandler1 == comparand ? -1353092698 : (num4 = -28910707);
              int num5 = (int) num3 * 1752946190;
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

    static ActivityManager()
    {
label_1:
      int num1 = 1936733049;
      while (true)
      {
        int num2 = 126986381;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            ActivityManager.mainWindowHandle = IntPtr.Zero;
            num1 = (int) num3 * -149151233 ^ -1491995845;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ActivityManager.mainProcess = ActivityManager.\u206B‪⁮‌‮⁪‪‭‬⁯‏⁬⁫‏‍⁯‮⁯‏‎‎⁮⁪⁬‪‫‮‮⁫⁬‌⁯⁭‪‎‪⁯⁭⁫‏‮();
    }

    private ActivityManager()
    {
label_1:
      int num1 = -689005333;
      object managerLock;
      while (true)
      {
        int num2 = -926531761;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            ActivityManager.\u206B‪⁮‌‮⁪‪‭‬⁯‏⁬⁫‏‍⁯‮⁯‏‎‎⁮⁪⁬‪‫‮‮⁫⁬‌⁯⁭‪‎‪⁯⁭⁫‏‮();
            num1 = (int) num3 * 791393348 ^ 1710311621;
            continue;
          case 2:
            managerLock = ManagerBase.managerLock;
            num1 = (int) num3 * -133867055 ^ 415591148;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 804177504 ^ 2066023170;
            continue;
          case 5:
            ActivityManager.\u206A⁫​‪​‍‏‎⁯⁬‭‮⁮‏‌⁪‏‫‍‎‍‭‍‎​‬⁪‪‫‌‬‬⁭‏⁫⁫‪‍‫⁯‮(CoreObject.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3907179133U));
            num1 = (int) num3 * 477377624 ^ 681756033;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      bool flag = false;
      try
      {
        ActivityManager.\u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮(managerLock, ref flag);
        this.ManagerState = ManagerState.Undefined;
      }
      finally
      {
        if (flag)
          ActivityManager.\u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮(managerLock);
      }
    }

    internal Task ManageActivitiesAsync(CancellationToken token)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ActivityManager.\u003CManageActivitiesAsync\u003Ed__28 activitiesAsyncD28 = new ActivityManager.\u003CManageActivitiesAsync\u003Ed__28();
label_1:
      int num1 = -1661379332;
      while (true)
      {
        int num2 = -432265035;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            activitiesAsyncD28.\u003C\u003E4__this = this;
            num1 = (int) num3 * 111453577 ^ -1795222001;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            activitiesAsyncD28.token = token;
            num1 = (int) num3 * 1371096291 ^ 782091152;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      activitiesAsyncD28.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
      // ISSUE: reference to a compiler-generated field
      activitiesAsyncD28.\u003C\u003E1__state = -1;
      // ISSUE: reference to a compiler-generated field
      AsyncTaskMethodBuilder tBuilder = activitiesAsyncD28.\u003C\u003Et__builder;
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncTaskMethodBuilder) @tBuilder).Start<ActivityManager.\u003CManageActivitiesAsync\u003Ed__28>((M0&) @activitiesAsyncD28);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      return ((AsyncTaskMethodBuilder) @activitiesAsyncD28.\u003C\u003Et__builder).get_Task();
    }

    internal void ManageActivities(CancellationToken token)
    {
      ActivityBase activityBase = (ActivityBase) null;
      ActivityManager.sourceToken = ActivityManager.\u202C‬‌⁫‌‎⁪‎⁭⁯‌⁭‮⁭⁯⁭⁮‍‪⁮‮‏⁮‏‮⁪‎⁯‌‫‎‎⁭‭⁮‬‫⁫​‌‮();
      object managerLock1 = ManagerBase.managerLock;
      bool flag1 = false;
      try
      {
        ActivityManager.\u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮(managerLock1, ref flag1);
label_2:
        int num1 = -1975970833;
        while (true)
        {
          int num2 = -765665223;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              this.ManagerState = ManagerState.Running;
              num1 = (int) num3 * -310879082 ^ 124863815;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_38;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_6:
          int num1 = -1375619603;
          while (true)
          {
            int num2 = -765665223;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                ActivityManager.\u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮(managerLock1);
                num1 = (int) num3 * 633364123 ^ 1716509058;
                continue;
              case 2:
                goto label_6;
              default:
                goto label_9;
            }
          }
        }
label_9:;
      }
label_38:
      bool flag2 = this.ContinueManagingActivities();
      int num4 = -1449610074;
      while (true)
      {
        int num1 = -765665223;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 8U)
        {
          case 0:
            num4 = -698194181;
            continue;
          case 1:
            num4 = (int) num2 * 385582299 ^ 187986409;
            continue;
          case 2:
            goto label_38;
          case 3:
            ActivityManager.\u202C‬⁯‏⁬⁮⁪‫⁪⁬⁬‍‬‪⁭⁭⁫​⁮‬⁭⁪⁫‌⁮⁯​‎⁯⁯‮‮‎‪‬‭‎⁫⁪‫‮(ActivityManager.sourceToken);
            num4 = (int) num2 * -1686514881 ^ -433809776;
            continue;
          case 4:
            num4 = (int) num2 * -1832126954 ^ -894677449;
            continue;
          case 5:
            int num3 = this.Engine.ActiveActivity == null ? -612373525 : (num3 = -1042908940);
            int num5 = (int) num2 * 1584711796;
            num4 = num3 ^ num5;
            continue;
          case 7:
            if (flag2)
            {
              try
              {
                this.WaitUntilInitialWindowsLoaded();
label_11:
                int num6 = -467514551;
                while (true)
                {
                  int num7 = -765665223;
                  uint num8;
                  switch ((num8 = (uint) (num6 ^ num7)) % 3U)
                  {
                    case 1:
                      activityBase = this.HandleActiveActivity();
                      num6 = (int) num8 * 1496445974 ^ -846509799;
                      continue;
                    case 2:
                      goto label_11;
                    default:
                      goto label_35;
                  }
                }
              }
              catch (Exception ex)
              {
label_15:
                int num6 = -252256614;
                object managerLock2;
                while (true)
                {
                  int num7 = -765665223;
                  uint num8;
                  switch ((num8 = (uint) (num6 ^ num7)) % 5U)
                  {
                    case 0:
                      goto label_15;
                    case 1:
                      num6 = (int) num8 * 1166022785 ^ -1467919870;
                      continue;
                    case 3:
                      managerLock2 = ManagerBase.managerLock;
                      num6 = (int) num8 * 1309584983 ^ -921521712;
                      continue;
                    case 4:
                      ActivityManager.\u206B‮‮‪‍‫‫‌‍‌​⁮⁯‌‬​​‍​⁭⁭‫⁬‏‪​⁯⁪‎‏⁮⁭‏⁮‍⁯‍‫‎‎‮(CoreObject.log, (object) ex);
                      num6 = (int) num8 * -869469746 ^ 104721151;
                      continue;
                    default:
                      goto label_20;
                  }
                }
label_20:
                bool flag3 = false;
                try
                {
                  ActivityManager.\u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮(managerLock2, ref flag3);
label_22:
                  int num7 = -1504286213;
                  while (true)
                  {
                    int num8 = -765665223;
                    uint num9;
                    switch ((num9 = (uint) (num7 ^ num8)) % 7U)
                    {
                      case 0:
                        goto label_22;
                      case 1:
                        num7 = (int) num9 * -1343396688 ^ 797298791;
                        continue;
                      case 2:
                        num7 = (int) num9 * -1640177585 ^ -1963205289;
                        continue;
                      case 3:
                        num7 = (int) num9 * 1822361044 ^ 439305076;
                        continue;
                      case 5:
                        this.ManagerState = ManagerState.Error;
                        num7 = (int) num9 * 373210442 ^ 1298983732;
                        continue;
                      case 6:
                        num7 = (int) num9 * 545163376 ^ -168715454;
                        continue;
                      default:
                        goto label_35;
                    }
                  }
                }
                finally
                {
                  if (flag3)
                  {
label_30:
                    int num7 = -1414397860;
                    while (true)
                    {
                      int num8 = -765665223;
                      uint num9;
                      switch ((num9 = (uint) (num7 ^ num8)) % 4U)
                      {
                        case 1:
                          ActivityManager.\u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮(managerLock2);
                          num7 = (int) num9 * 503854066 ^ 1690462985;
                          continue;
                        case 2:
                          num7 = (int) num9 * -419601726 ^ 350281037;
                          continue;
                        case 3:
                          goto label_30;
                        default:
                          goto label_34;
                      }
                    }
                  }
label_34:;
                }
              }
label_35:
              goto case 0;
            }
            else
            {
              num4 = (int) num2 * 1004737937 ^ 1525233275;
              continue;
            }
          default:
            goto label_45;
        }
      }
label_45:
      object managerLock3 = ManagerBase.managerLock;
      bool flag4 = false;
      try
      {
        ActivityManager.\u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮(managerLock3, ref flag4);
label_47:
        int num1 = -102823408;
        while (true)
        {
          int num2 = -765665223;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 1522994835 ^ -507954869;
              continue;
            case 1:
              goto label_56;
            case 2:
              goto label_47;
            case 3:
              this.ManagerState = ManagerState.Stopped;
              num1 = (int) num3 * -990438035 ^ -1625836210;
              continue;
            case 4:
              num1 = (int) num3 * -1231527010 ^ -350750106;
              continue;
            default:
              goto label_52;
          }
        }
label_52:
        return;
label_56:;
      }
      finally
      {
        if (flag4)
        {
label_54:
          int num1 = -328060548;
          while (true)
          {
            int num2 = -765665223;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * 260215748 ^ -1976276881;
                continue;
              case 1:
                ActivityManager.\u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮(managerLock3);
                num1 = (int) num3 * 1995570998 ^ 1241850619;
                continue;
              case 3:
                goto label_54;
              default:
                goto label_59;
            }
          }
        }
label_59:;
      }
    }

    internal ActivityBase HandleActiveActivity()
    {
      ActivityBase currentActivity = this.Engine.ActiveActivity;
label_1:
      int num1 = -203795972;
      while (true)
      {
        int num2 = -1083511939;
        uint num3;
        bool flag1;
        ActivityState activityState;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool nextActivity;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 40U)
        {
          case 0:
            flag4 = currentActivity == null;
            num1 = -1594001905;
            continue;
          case 1:
            int num6;
            num1 = num6 = !(currentActivity.EndTime < DateTime.Now) ? -443938862 : (num6 = -147085031);
            continue;
          case 2:
            int num7 = nextActivity ? -902375214 : (num7 = -911994456);
            int num8 = (int) num3 * -24107560;
            num1 = num7 ^ num8;
            continue;
          case 3:
            ActivityManager.\u206A⁫​‪​‍‏‎⁯⁬‭‮⁮‏‌⁪‏‫‍‎‍‭‍‎​‬⁪‪‫‌‬‬⁭‏⁫⁫‪‍‫⁯‮(CoreObject.log, (object) ActivityManager.\u202D​‭‮⁭‌⁮‫‪⁮‍⁭‫‏‫‍‎‏⁬⁬⁪‮⁯‎⁪⁪‪‬‭‪⁭‫⁪⁮⁬‮‌‎‪‌‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(142390471U), (object) currentActivity.Name));
            num1 = (int) num3 * -746224794 ^ -445263062;
            continue;
          case 4:
            num1 = (int) num3 * -426571422 ^ 722666246;
            continue;
          case 5:
            num1 = (int) num3 * 1641158499 ^ -276959062;
            continue;
          case 7:
            ActivityManager.\u206A⁫​‪​‍‏‎⁯⁬‭‮⁮‏‌⁪‏‫‍‎‍‭‍‎​‬⁪‪‫‌‬‬⁭‏⁫⁫‪‍‫⁯‮(CoreObject.log, (object) ActivityManager.\u206C⁫‬‫‭‌⁬‫⁮‎​⁪⁬‍‮‪⁬‌⁫‭⁪⁪‌‍⁮⁭‫‮‎‬‎‎‮‭‭⁯‪⁯‌‭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1080224633U), (object) currentActivity.Name, (object) currentActivity.ActivityState));
            num1 = (int) num3 * -622964360 ^ 1584263481;
            continue;
          case 8:
            num1 = (int) num3 * 1785112220 ^ 393656374;
            continue;
          case 9:
            ActivityManager.\u202A​⁫​‬⁮‍‭⁯‮⁪⁭‪‏‌​​‪‮⁮‮‫⁭⁯‌‏⁭‍‫‪‎⁯⁭​‭‌⁫‏⁭‌‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3179974258U), (object) currentActivity);
            num1 = (int) num3 * 1304314793 ^ 677747178;
            continue;
          case 10:
            if (flag5)
            {
              num1 = (int) num3 * -335239501 ^ -726702550;
              continue;
            }
            goto label_63;
          case 11:
            int num9 = flag1 ? 1320102838 : (num9 = 918547622);
            int num10 = (int) num3 * 641978905;
            num1 = num9 ^ num10;
            continue;
          case 12:
label_12:
            if (currentActivity.AuthorizationState != AuthorizationStates.Authorized)
            {
              num1 = -620512284;
              continue;
            }
            num4 = 1;
            goto label_33;
          case 13:
            num1 = (int) num3 * -1046268950 ^ 175565562;
            continue;
          case 14:
            num1 = (int) num3 * -1114899123 ^ -1096978618;
            continue;
          case 15:
            num1 = -133353419;
            continue;
          case 16:
            num1 = (int) num3 * -546374124 ^ -1720125003;
            continue;
          case 17:
            flag1 = currentActivity != null;
            num1 = (int) num3 * 99692821 ^ -1999034525;
            continue;
          case 18:
            int num11 = flag4 ? -952612092 : (num11 = -1913096393);
            int num12 = (int) num3 * 407542570;
            num1 = num11 ^ num12;
            continue;
          case 19:
            if (currentActivity.ActivityState != ActivityState.Hold)
            {
              num1 = (int) num3 * 643041519 ^ -1660821141;
              continue;
            }
            break;
          case 20:
            num1 = (int) num3 * 234543299 ^ -1682976962;
            continue;
          case 21:
            goto label_1;
          case 22:
          case 36:
            goto label_64;
          case 23:
            num1 = (int) num3 * -28441861 ^ -1831283113;
            continue;
          case 24:
            nextActivity = this.Engine.GetNextActivity(out currentActivity);
            num1 = (int) num3 * -1357427070 ^ -907517793;
            continue;
          case 25:
            ActivityManager.\u200E‪⁪⁫‌⁮‏‫‪‮‏‮⁫​‏⁮‌​‍⁬⁯‫⁪‍⁪⁫‪‪‬⁮⁭⁮‮⁯‬‎‮‪‪‍‮(CoreObject.log, ActivityManager.\u202D​‭‮⁭‌⁮‫‪⁮‍⁭‫‏‫‍‎‏⁬⁬⁪‮⁯‎⁪⁪‪‬‭‪⁭‫⁪⁮⁬‮‌‎‪‌‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(58144173U), (object) currentActivity.Name), new object[0]);
            currentActivity.SetActivityState(ActivityState.InProgress, "");
            num1 = (int) num3 * 934550271 ^ -1665341476;
            continue;
          case 26:
            num1 = (int) num3 * -1819703868 ^ -427767846;
            continue;
          case 27:
            if (flag2)
            {
              num1 = (int) num3 * -1694577366 ^ 1888967267;
              continue;
            }
            goto label_75;
          case 28:
            this.Engine.SetActiveActivity((ActivityBase) null);
            num1 = (int) num3 * 88037703 ^ -887555306;
            continue;
          case 29:
            this.Engine.SetActiveActivity((ActivityBase) null);
            num1 = (int) num3 * -791563899 ^ 810123462;
            continue;
          case 30:
            num5 = currentActivity.ActivityState != ActivityState.Pending ? 1 : 0;
            goto label_25;
          case 31:
            num1 = (int) num3 * 261345352 ^ 825551540;
            continue;
          case 32:
            activityState = currentActivity.ActivityState;
            num1 = (int) num3 * 463333627 ^ -1421375601;
            continue;
          case 33:
            num4 = !currentActivity.RequiresAuthorization ? 1 : 0;
            goto label_33;
          case 34:
            switch (activityState)
            {
              case ActivityState.Undefined:
              case ActivityState.Hold:
              case ActivityState.Completed:
              case ActivityState.Error:
              case ActivityState.Canceled:
              case ActivityState.CancelRequested:
                goto label_71;
              case ActivityState.Pending:
                goto label_12;
              case ActivityState.InProgress:
                goto label_64;
              default:
                num1 = (int) num3 * 1947857283 ^ 1179664493;
                continue;
            }
          case 35:
            if (currentActivity.ActivityState != ActivityState.InProgress)
            {
              num1 = (int) num3 * 924654103 ^ 392243198;
              continue;
            }
            break;
          case 37:
            num1 = -1545622141;
            continue;
          case 38:
            flag2 = currentActivity != null;
            num1 = -1298665026;
            continue;
          case 39:
            int num13 = !flag3 ? 144066810 : (num13 = 1214336735);
            int num14 = (int) num3 * -559038182;
            num1 = num13 ^ num14;
            continue;
          default:
            goto label_49;
        }
        num5 = 0;
label_25:
        flag3 = num5 != 0;
        num1 = -700252990;
        continue;
label_33:
        flag5 = num4 != 0;
        num1 = -425662577;
      }
label_49:
      object managerLock = ManagerBase.managerLock;
      bool flag = false;
      try
      {
        ActivityManager.\u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮(managerLock, ref flag);
label_51:
        int num2 = -1069381186;
        while (true)
        {
          int num3 = -1083511939;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              this.queuedActivityStarts.Add(currentActivity.Guid);
              num2 = (int) num4 * -331156415 ^ -1133873298;
              continue;
            case 2:
              goto label_51;
            default:
              goto label_60;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_55:
          int num2 = -423664657;
          while (true)
          {
            int num3 = -1083511939;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_55;
              case 1:
                num2 = (int) num4 * -680183397 ^ -463243143;
                continue;
              case 2:
                ActivityManager.\u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮(managerLock);
                num2 = (int) num4 * -1953508994 ^ -710914464;
                continue;
              default:
                goto label_59;
            }
          }
        }
label_59:;
      }
label_60:
      this.Engine.SetActiveActivity(currentActivity);
label_61:
      int num15 = -598775303;
label_62:
      ActivityBase activityBase;
      while (true)
      {
        int num2 = -1083511939;
        uint num3;
        switch ((num3 = (uint) (num15 ^ num2)) % 22U)
        {
          case 0:
            num15 = (int) num3 * 1812663589 ^ -682127442;
            continue;
          case 1:
            ActivityManager.\u200E‪⁪⁫‌⁮‏‫‪‮‏‮⁫​‏⁮‌​‍⁬⁯‫⁪‍⁪⁫‪‪‬⁮⁭⁮‮⁯‬‎‮‪‪‍‮(CoreObject.log, ActivityManager.\u202D​‭‮⁭‌⁮‫‪⁮‍⁭‫‏‫‍‎‏⁬⁬⁪‮⁯‎⁪⁪‪‬‭‪⁭‫⁪⁮⁬‮‌‎‪‌‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3019433484U), (object) currentActivity.Name), new object[0]);
            num15 = (int) num3 * -1641080005 ^ 454214429;
            continue;
          case 2:
            goto label_75;
          case 3:
            int num4;
            num15 = num4 = currentActivity.AuthorizationState != AuthorizationStates.Rejected ? -1631790190 : (num4 = -209846697);
            continue;
          case 4:
          case 17:
          case 21:
            goto label_64;
          case 5:
            num15 = (int) num3 * -1279804297 ^ -1077820893;
            continue;
          case 6:
            num15 = (int) num3 * 797519905 ^ -214372781;
            continue;
          case 7:
            goto label_63;
          case 8:
            num15 = (int) num3 * -2041064396 ^ 673440068;
            continue;
          case 9:
            currentActivity = (ActivityBase) null;
            num15 = (int) num3 * 1630789712 ^ 83798306;
            continue;
          case 10:
            num15 = (int) num3 * -43302120 ^ 1305415878;
            continue;
          case 11:
            this.engine.ArchiveActivity(currentActivity);
            num15 = (int) num3 * -505251399 ^ -438478157;
            continue;
          case 12:
            activityBase = currentActivity;
            num15 = -1913682046;
            continue;
          case 14:
            num15 = (int) num3 * 1971826287 ^ 547809368;
            continue;
          case 15:
            ActivityManager.\u206D‪⁫‏‫⁮⁪‭​‭‍⁯‌⁬⁪‌​‌‪‏‬⁬⁫‭​⁪⁯​⁭‎⁭⁪⁫⁭⁬⁫‪⁬⁫‎‮(new WaitCallback(this.QueueStartActivity), (object) currentActivity);
            num15 = (int) num3 * 1508075852 ^ 178276829;
            continue;
          case 16:
            currentActivity = (ActivityBase) null;
            num15 = (int) num3 * -1367420478 ^ -717438576;
            continue;
          case 18:
            goto label_61;
          case 19:
            num15 = (int) num3 * -1162181882 ^ 1711830119;
            continue;
          case 20:
            goto label_71;
          default:
            goto label_81;
        }
      }
label_81:
      return activityBase;
label_63:
      int num16;
      num15 = num16 = currentActivity.AuthorizationState == AuthorizationStates.Pending ? -2068904301 : (num16 = -80181086);
      goto label_62;
label_64:
      num15 = -523751787;
      goto label_62;
label_71:
      this.HandleActivityEnded(currentActivity);
      num15 = -512098670;
      goto label_62;
label_75:
      ZoomEvent zoomEvent;
      this.SharedData.ActivityQueue.TryDequeue(ref zoomEvent);
      num15 = -1459098437;
      goto label_62;
    }

    private void HandleActivityEnded(ActivityBase currentActivity)
    {
      string guid = currentActivity.Guid;
label_1:
      int num1 = 1068258312;
      object managerLock;
      while (true)
      {
        int num2 = 1097811063;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityEndedEvent>()).Publish(new ActivityEventBaseArguments(currentActivity, ""));
            num1 = (int) num3 * 2065890083 ^ -2060531789;
            continue;
          case 1:
            num1 = (int) num3 * 1998029612 ^ 52001811;
            continue;
          case 2:
            this.Engine.SetActiveActivity((ActivityBase) null);
            num1 = (int) num3 * 438251677 ^ 1822315588;
            continue;
          case 4:
            num1 = (int) num3 * -342575447 ^ -1575626387;
            continue;
          case 5:
            goto label_1;
          case 6:
            managerLock = ManagerBase.managerLock;
            num1 = (int) num3 * 1293358867 ^ -470232210;
            continue;
          case 7:
            this.Engine.ArchiveActivity(currentActivity);
            num1 = (int) num3 * -1714745819 ^ -1554980274;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      bool flag = false;
      try
      {
        ActivityManager.\u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮(managerLock, ref flag);
label_11:
        int num2 = 1745295666;
        while (true)
        {
          int num3 = 1097811063;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_11;
            case 1:
              currentActivity = (ActivityBase) null;
              num2 = (int) num4 * 1617772557 ^ -746250268;
              continue;
            case 2:
              goto label_18;
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
          int num2 = 1624300037;
          while (true)
          {
            int num3 = 1097811063;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                ActivityManager.\u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮(managerLock);
                num2 = (int) num4 * 517124436 ^ -499649755;
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
    }

    private void QueueStartActivity(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ActivityManager.\u003CQueueStartActivity\u003Ed__33 startActivityD33 = new ActivityManager.\u003CQueueStartActivity\u003Ed__33();
label_1:
      int num1 = 216085096;
      while (true)
      {
        int num2 = 1853797101;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            startActivityD33.\u003C\u003E4__this = this;
            // ISSUE: reference to a compiler-generated field
            startActivityD33.state = state;
            // ISSUE: reference to a compiler-generated field
            startActivityD33.\u003C\u003Et__builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num3 * 865763514 ^ 490311551;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      startActivityD33.\u003C\u003E1__state = -1;
      // ISSUE: reference to a compiler-generated field
      AsyncVoidMethodBuilder tBuilder = startActivityD33.\u003C\u003Et__builder;
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncVoidMethodBuilder) @tBuilder).Start<ActivityManager.\u003CQueueStartActivity\u003Ed__33>((M0&) @startActivityD33);
    }

    [STAThread]
    internal Task ExecuteActivityAsync(ActivityBase activity)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ActivityManager.\u003CExecuteActivityAsync\u003Ed__34 activityAsyncD34 = new ActivityManager.\u003CExecuteActivityAsync\u003Ed__34();
label_1:
      int num1 = 506257741;
      while (true)
      {
        int num2 = 2121717744;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            activityAsyncD34.activity = activity;
            // ISSUE: reference to a compiler-generated field
            activityAsyncD34.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            // ISSUE: reference to a compiler-generated field
            activityAsyncD34.\u003C\u003E1__state = -1;
            // ISSUE: reference to a compiler-generated field
            AsyncTaskMethodBuilder tBuilder = activityAsyncD34.\u003C\u003Et__builder;
            // ISSUE: explicit reference operation
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            ((AsyncTaskMethodBuilder) @tBuilder).Start<ActivityManager.\u003CExecuteActivityAsync\u003Ed__34>((M0&) @activityAsyncD34);
            num1 = (int) num3 * 1571647592 ^ 1540310066;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            activityAsyncD34.\u003C\u003E4__this = this;
            num1 = (int) num3 * -105459629 ^ 1581346479;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      return ((AsyncTaskMethodBuilder) @activityAsyncD34.\u003C\u003Et__builder).get_Task();
    }

    private bool ContinueManagingActivities()
    {
label_1:
      int num1 = -605899260;
      bool flag1;
      while (true)
      {
        int num2 = -1521395403;
        uint num3;
        bool flag2;
        CancellationToken token;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            if (this.ManagerState != ManagerState.Error)
            {
              num1 = (int) num3 * 1117995185 ^ -246764494;
              continue;
            }
            break;
          case 1:
            if (!this.CancelRequested)
            {
              num1 = (int) num3 * 114582961 ^ 426603988;
              continue;
            }
            break;
          case 2:
            num1 = (int) num3 * 2116322544 ^ 215230355;
            continue;
          case 3:
            num1 = (int) num3 * 1733506697 ^ 2013650048;
            continue;
          case 4:
            token = this.Token;
            num1 = -1567739958;
            continue;
          case 5:
            int num5 = flag2 ? 1277575133 : (num5 = 1717780307);
            int num6 = (int) num3 * -1045992886;
            num1 = num5 ^ num6;
            continue;
          case 7:
            num4 = !this.Engine.IsExecuting ? 1 : 0;
            goto label_7;
          case 8:
            flag1 = true;
            num1 = -1977471188;
            continue;
          case 9:
            num1 = (int) num3 * -732223727 ^ -1738620710;
            continue;
          case 10:
            num1 = (int) num3 * 2126616775 ^ 86105070;
            continue;
          case 11:
            num1 = (int) num3 * 521651904 ^ -1359027149;
            continue;
          case 12:
            goto label_1;
          case 13:
            flag1 = false;
            num1 = (int) num3 * -640584769 ^ 700646212;
            continue;
          case 14:
            flag1 = false;
            num1 = (int) num3 * 522420279 ^ 1836296572;
            continue;
          case 15:
            // ISSUE: explicit reference operation
            int num7 = !((CancellationToken) @token).get_IsCancellationRequested() ? 1916720212 : (num7 = 1654233919);
            int num8 = (int) num3 * 69326071;
            num1 = num7 ^ num8;
            continue;
          default:
            goto label_21;
        }
        num4 = 1;
label_7:
        flag2 = num4 != 0;
        num1 = -1668680768;
      }
label_21:
      return flag1;
    }

    internal override void Cancel()
    {
label_1:
      int num1 = -1126754733;
      while (true)
      {
        int num2 = -352426711;
        uint num3;
        ActivityBase activeActivity;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -1587819269 ^ 515925636;
            continue;
          case 1:
            base.Cancel();
            num1 = (int) num3 * -1506427810 ^ -1388803163;
            continue;
          case 2:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityCanceledEvent>()).Publish(new ActivityEventBaseArguments(activeActivity, ""));
            num1 = (int) num3 * 550953986 ^ -319284531;
            continue;
          case 3:
            num1 = (int) num3 * 1281031437 ^ 377005246;
            continue;
          case 4:
            goto label_3;
          case 5:
            activeActivity = this.ActiveActivity;
            int num4 = activeActivity != null ? -1615487147 : (num4 = -1952888069);
            int num5 = (int) num3 * -1784032333;
            num1 = num4 ^ num5;
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

    private void WaitUntilInitialWindowsLoaded()
    {
label_1:
      int num1 = 543259957;
      while (true)
      {
        int num2 = 888343562;
        uint num3;
        bool initialized;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = (int) num3 * -1473849340 ^ 2059320140;
            continue;
          case 1:
            flag2 = true;
            num1 = (int) num3 * 290374448 ^ 189531500;
            continue;
          case 2:
            num1 = (int) num3 * 1772015486 ^ 1948507393;
            continue;
          case 3:
            goto label_1;
          case 4:
            initialized = this.Engine.HookManager.Initialized;
            num1 = 288217281;
            continue;
          case 5:
            num1 = 787803540;
            continue;
          case 6:
            flag1 = flag2;
            num1 = 1285495606;
            continue;
          case 7:
            flag2 = false;
            num1 = (int) num3 * -681569694 ^ -871280416;
            continue;
          case 8:
            goto label_3;
          case 9:
            num1 = (int) num3 * -1387685714 ^ 863066315;
            continue;
          case 10:
            num1 = (int) num3 * -902675404 ^ -1089986183;
            continue;
          case 11:
            ActivityManager.\u200F⁮‮‫‮​‭​⁮‏‮​‪⁫⁫‏‭‍‪​‍⁯⁭‮‎‪‏⁪‏‪⁯​⁫‬‪⁬‭⁫‪⁬‮(250);
            num1 = 1399998861;
            continue;
          case 12:
            int num4 = flag1 ? -1609095514 : (num4 = -1359541234);
            int num5 = (int) num3 * -1426650819;
            num1 = num4 ^ num5;
            continue;
          case 13:
            int num6 = initialized ? -1064685322 : (num6 = -171333627);
            int num7 = (int) num3 * 1761172226;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    internal void ReportProgress(ActivityBase activity, string status)
    {
      // ISSUE: reference to a compiler-generated field
      bool flag = this.OnActivityProgressReport != null;
label_1:
      int num1 = 415378573;
      while (true)
      {
        int num2 = 798060897;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: reference to a compiler-generated field
            this.OnActivityProgressReport((object) activity, (EventArgs) new ZoomActivityEventArgs(activity, status));
            num1 = (int) num3 * 1194099374 ^ -898714507;
            continue;
          case 2:
            int num4 = !flag ? -1763766281 : (num4 = -1168111358);
            int num5 = (int) num3 * 1198413692;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * 1604605420 ^ -1068079910;
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

    static void \u202A‍⁭⁮⁫‭⁭‏⁪‍⁭⁪‬‭‮‫⁬‎⁮⁭‍⁮‏‍‌‍‏‌⁬⁬⁭⁮⁭⁪⁭⁭‭‍⁬‌‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200C‌⁫‭​‬‬⁫⁮‫⁮​‍‎‭‬‬‎⁯‎‪⁮‪⁭‌⁪‎⁭​⁯‏⁬⁯⁬‌‮⁪‫‬‫‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static void \u206A⁫​‪​‍‏‎⁯⁬‭‮⁮‏‌⁪‏‫‍‎‍‭‍‎​‬⁪‪‫‌‬‬⁭‏⁫⁫‪‍‫⁯‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static Process \u206B‪⁮‌‮⁪‪‭‬⁯‏⁬⁫‏‍⁯‮⁯‏‎‎⁮⁪⁬‪‫‮‮⁫⁬‌⁯⁭‪‎‪⁯⁭⁫‏‮()
    {
      return Process.GetCurrentProcess();
    }

    static Delegate \u206F⁪‏‌⁫‌‬‪⁭‍⁫⁪‎‍‏​⁮‭‫‬⁬⁭⁫‎‎‌‪⁯⁪‌⁫‬‍⁯‭‪⁫⁯​⁫‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u202C‍⁭‏‍⁪‌‪‬⁪‏⁯⁯⁮‭​⁪⁪⁭⁫‏‏‭⁫⁬⁪⁮‫‌‮‏⁯​‎‎‭⁯‏⁪‭‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static CancellationTokenSource \u202C‬‌⁫‌‎⁪‎⁭⁯‌⁭‮⁭⁯⁭⁮‍‪⁮‮‏⁮‏‮⁪‎⁯‌‫‎‎⁭‭⁮‬‫⁫​‌‮()
    {
      return new CancellationTokenSource();
    }

    static void \u206B‮‮‪‍‫‫‌‍‌​⁮⁯‌‬​​‍​⁭⁭‫⁬‏‪​⁯⁪‎‏⁮⁭‏⁮‍⁯‍‫‎‎‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u202C‬⁯‏⁬⁮⁪‫⁪⁬⁬‍‬‪⁭⁭⁫​⁮‬⁭⁪⁫‌⁮⁯​‎⁯⁯‮‮‎‪‬‭‎⁫⁪‫‮([In] CancellationTokenSource obj0)
    {
      obj0.Cancel();
    }

    static string \u206C⁫‬‫‭‌⁬‫⁮‎​⁪⁬‍‮‪⁬‌⁫‭⁪⁪‌‍⁮⁭‫‮‎‬‎‎‮‭‭⁯‪⁯‌‭‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static string \u202D​‭‮⁭‌⁮‫‪⁮‍⁭‫‏‫‍‎‏⁬⁬⁪‮⁯‎⁪⁪‪‬‭‪⁭‫⁪⁮⁬‮‌‎‪‌‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u202A​⁫​‬⁮‍‭⁯‮⁪⁭‪‏‌​​‪‮⁮‮‫⁭⁯‌‏⁭‍‫‪‎⁯⁭​‭‌⁫‏⁭‌‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u200E‪⁪⁫‌⁮‏‫‪‮‏‮⁫​‏⁮‌​‍⁬⁯‫⁪‍⁪⁫‪‪‬⁮⁭⁮‮⁯‬‎‮‪‪‍‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static bool \u206D‪⁫‏‫⁮⁪‭​‭‍⁯‌⁬⁪‌​‌‪‏‬⁬⁫‭​⁪⁯​⁭‎⁭⁪⁫⁭⁬⁫‪⁬⁫‎‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static void \u200F⁮‮‫‮​‭​⁮‏‮​‪⁫⁫‏‭‍‪​‍⁯⁭‮‎‪‏⁪‏‪⁯​⁫‬‪⁬‭⁫‪⁬‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }
  }
}
