// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.RequestCameraControl
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ZoomZoom.Models.Activities
{
  public class RequestCameraControl : ActivityBase
  {
    private int requestCount = 0;
    private int executionCount = 0;
    private int pauseDuration = 0;
    private ZoomWindow videoWindow = (ZoomWindow) null;
    private DateTime lastRequest = DateTime.MinValue;
    private bool requestSupportChecked = false;
    private bool attached = false;
    private SelectWindow selectWindow = new SelectWindow(new List<ZoomWindowType>()
    {
      ZoomWindowType.Video
    });
    private int _menuPositionX = -1;
    private int _menuPositionY = -1;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 186226098;
        TraceType traceType;
        while (true)
        {
          int num2 = 631783489;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -176366104 ^ 655099376;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public int RequestCount
    {
      get
      {
label_1:
        int num1 = -1199929055;
        int requestCount;
        while (true)
        {
          int num2 = -395268602;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 735433438 ^ -513243329;
              continue;
            case 2:
              goto label_1;
            case 3:
              requestCount = this.requestCount;
              num1 = (int) num3 * 1420772479 ^ 479491959;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return requestCount;
      }
      set
      {
label_1:
        int num1 = 107765486;
        while (true)
        {
          int num2 = 1440139896;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.requestCount = value;
              num1 = (int) num3 * 1575432081 ^ 1896804116;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4287102199U));
              num1 = (int) num3 * -1856918750 ^ 465412895;
              continue;
            case 4:
              num1 = (int) num3 * 120562751 ^ -304564546;
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

    public int PauseDuration
    {
      get
      {
        int pauseDuration = this.pauseDuration;
label_1:
        int num1 = -1290817606;
        while (true)
        {
          int num2 = -438224968;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 217617227 ^ 1900389374;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return pauseDuration;
      }
      set
      {
        this.pauseDuration = value;
label_1:
        int num1 = 315327979;
        while (true)
        {
          int num2 = 1263120824;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 2021756269 ^ -2003701759;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3785011306U));
              num1 = (int) num3 * -679197930 ^ 1745163946;
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

    public ZoomWindow VideoWindow
    {
      get
      {
label_1:
        int num1 = -553849509;
        ZoomWindow videoWindow;
        while (true)
        {
          int num2 = -518694079;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -977222619 ^ -1775268161;
              continue;
            case 2:
              videoWindow = this.videoWindow;
              num1 = (int) num3 * -1136808591 ^ 191850670;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return videoWindow;
      }
      set
      {
        this.videoWindow = value;
label_1:
        int num1 = 275279992;
        while (true)
        {
          int num2 = 1744958233;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1753149205 ^ -997266393;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1690990761U));
              num1 = (int) num3 * 1883053829 ^ -1038013760;
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

    public int ExecutionCount
    {
      get
      {
        int executionCount = this.executionCount;
label_1:
        int num1 = 2126670960;
        while (true)
        {
          int num2 = 792453456;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1111587045 ^ -687204938;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return executionCount;
      }
      set
      {
        this.executionCount = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(940039286U));
      }
    }

    internal SelectWindow SelectWindow
    {
      get
      {
label_1:
        int num1 = 1287595229;
        SelectWindow selectWindow;
        while (true)
        {
          int num2 = 1990033199;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              selectWindow = this.selectWindow;
              num1 = (int) num3 * -1150740997 ^ 1530300814;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectWindow;
      }
      set
      {
        this.selectWindow = value;
      }
    }

    public RequestCameraControl()
    {
      this.RequestCount = 100;
    }

    public RequestCameraControl(int requestCount)
    {
label_1:
      int num1 = -1496874874;
      while (true)
      {
        int num2 = -1306893897;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.RequestCount = requestCount;
            num1 = (int) num3 * 743751987 ^ 632783946;
            continue;
          case 2:
            num1 = (int) num3 * -446055199 ^ -1705479374;
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

    protected override void ExecuteLogic()
    {
      if (this.ExecuteSubActivity((ActivityBase) this.SelectWindow, true) != ActivityState.Completed)
        goto label_27;
label_1:
      int num1 = -456629848;
label_2:
      while (true)
      {
        int num2 = -1939912340;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 30U)
        {
          case 0:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3634404102U));
            num1 = -1947898389;
            continue;
          case 1:
            int num5 = !flag1 ? -2004257865 : (num5 = -615040472);
            int num6 = (int) num3 * 1471308166;
            num1 = num5 ^ num6;
            continue;
          case 2:
            this.EndTime = DateTime.Now.AddSeconds(30.0);
            num1 = -756592267;
            continue;
          case 3:
            this.RequestCount = 100;
            num1 = (int) num3 * -1961431220 ^ -956806462;
            continue;
          case 4:
            num1 = (int) num3 * 1554539264 ^ 1050783605;
            continue;
          case 5:
            num1 = (int) num3 * 327648655 ^ 1487488917;
            continue;
          case 6:
            this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2847607081U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2468418288U));
            this.ActivityState = ActivityState.InProgress;
            num1 = (int) num3 * -903449814 ^ -1744050643;
            continue;
          case 7:
            num1 = (int) num3 * -1569315720 ^ 259506320;
            continue;
          case 8:
            flag2 = this.RequestCount == 0;
            num1 = -1172778704;
            continue;
          case 9:
            num1 = (int) num3 * -628338722 ^ 1133171861;
            continue;
          case 10:
            num1 = -1415207050;
            continue;
          case 11:
            num1 = (int) num3 * -18107908 ^ -170997690;
            continue;
          case 12:
            goto label_1;
          case 13:
            Thread.Sleep(50);
            num1 = (int) num3 * 903540690 ^ -216919520;
            continue;
          case 14:
            num1 = -1475611746;
            continue;
          case 15:
            this.ReportProgress(string.Format(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3882486040U), (object) this.ExecutionCount), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2005217345U));
            num1 = (int) num3 * 1429240230 ^ 1202642861;
            continue;
          case 16:
            num1 = (int) num3 * 1697677833 ^ -1606128138;
            continue;
          case 17:
            int num7 = !flag3 ? 119106019 : (num7 = 1470711552);
            int num8 = (int) num3 * -831163833;
            num1 = num7 ^ num8;
            continue;
          case 18:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3634404102U));
            num1 = (int) num3 * 1303084446 ^ -1659177311;
            continue;
          case 19:
            num1 = (int) num3 * 54916187 ^ 2093686018;
            continue;
          case 20:
            num4 = this.SelectWindow.Result is ZoomWindow ? 1 : 0;
            break;
          case 21:
            goto label_3;
          case 22:
            num1 = (int) num3 * -1649404563 ^ 228707466;
            continue;
          case 23:
            goto label_27;
          case 24:
            int num9 = flag2 ? 1299160903 : (num9 = 1150457970);
            int num10 = (int) num3 * -1642589609;
            num1 = num9 ^ num10;
            continue;
          case 25:
            if (this.SelectWindow.Result == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 913414081 ^ -1916497159;
            continue;
          case 26:
            num1 = (int) num3 * -553306230 ^ -1540358877;
            continue;
          case 27:
            flag1 = this.ContinueExecution();
            num1 = -1248176377;
            continue;
          case 28:
            this.InvokeRequestControl();
            num1 = (int) num3 * 807903049 ^ -1238220515;
            continue;
          case 29:
            this.VideoWindow = (ZoomWindow) this.SelectWindow.Result;
            num1 = (int) num3 * 1691552363 ^ 1582005473;
            continue;
          default:
            goto label_35;
        }
        flag3 = num4 != 0;
        num1 = -784761331;
      }
label_35:
      return;
label_3:
      return;
label_27:
      num1 = -1673245540;
      goto label_2;
    }

    internal override bool Valid()
    {
      bool flag = true;
label_1:
      int num1 = -126580769;
      while (true)
      {
        int num2 = -582584820;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1977824168 ^ 657721579;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private bool ValidVideoWindow()
    {
      bool flag1 = this.VideoWindow != null;
label_1:
      int num1 = -1716417734;
      bool flag2;
      while (true)
      {
        int num2 = -1323093610;
        uint num3;
        bool attached;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            num1 = (int) num3 * 1706692239 ^ -2079351752;
            continue;
          case 1:
            num1 = (int) num3 * 687731956 ^ -1928720296;
            continue;
          case 2:
            num1 = (int) num3 * 959546672 ^ 578680979;
            continue;
          case 3:
            num1 = (int) num3 * 969542703 ^ 1389441926;
            continue;
          case 4:
            int num5 = !flag1 ? 1115283013 : (num5 = 102517981);
            int num6 = (int) num3 * 213134255;
            num1 = num5 ^ num6;
            continue;
          case 5:
            int num7 = !flag3 ? -301898997 : (num7 = -986773887);
            int num8 = (int) num3 * 1548961976;
            num1 = num7 ^ num8;
            continue;
          case 6:
            num1 = -253648431;
            continue;
          case 7:
            if (WindowHelper.IsValid(this.VideoWindow.Handle))
            {
              num1 = (int) num3 * 1735349169 ^ -1929799717;
              continue;
            }
            num4 = 0;
            break;
          case 8:
            num1 = (int) num3 * 1318548805 ^ -382448923;
            continue;
          case 9:
            flag2 = true;
            num1 = (int) num3 * 1155880298 ^ 1187494176;
            continue;
          case 10:
            num4 = this.VideoWindow.IsVisible ? 1 : 0;
            break;
          case 11:
            num1 = (int) num3 * -34547564 ^ 2095096262;
            continue;
          case 12:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3142561522U));
            num1 = -1024741152;
            continue;
          case 13:
            attached = this.attached;
            num1 = -1286659600;
            continue;
          case 14:
            goto label_1;
          case 15:
            this.VideoWindow = (ZoomWindow) null;
            num1 = (int) num3 * 104669053 ^ -375949479;
            continue;
          case 17:
            num1 = (int) num3 * 1605345845 ^ -1132452085;
            continue;
          case 18:
            int num9 = attached ? -934443333 : (num9 = -1483090192);
            int num10 = (int) num3 * 61644431;
            num1 = num9 ^ num10;
            continue;
          case 19:
            flag2 = false;
            num1 = -2111096789;
            continue;
          default:
            goto label_24;
        }
        flag3 = num4 != 0;
        num1 = -352590997;
      }
label_24:
      return flag2;
    }

    private void InvokeRequestControl()
    {
      this.Engine.PurgeActivityQueue();
label_1:
      int num1 = 391709413;
      while (true)
      {
        int num2 = 1161222630;
        uint num3;
        System.Drawing.Point location;
        int Y;
        int X;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            Thread.Sleep(40);
            User32.SetCursorPos(X, Y);
            User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
            num1 = (int) num3 * 155511630 ^ -1304322357;
            continue;
          case 1:
            Y = location.Y + 25;
            User32.SetCursorPos(X, Y);
            User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
            num1 = (int) num3 * -1931694618 ^ -1210894308;
            continue;
          case 2:
            int num4 = !(this.lastRequest.AddMilliseconds(100.0) < DateTime.Now) ? 1363181611 : (num4 = 1583073455);
            int num5 = (int) num3 * 262103654;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_3;
          case 4:
            SendKeys.SendWait(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1505611004U));
            num1 = (int) num3 * -821153947 ^ 67159993;
            continue;
          case 5:
            this.lastRequest = DateTime.Now;
            num1 = (int) num3 * 279127908 ^ -890148102;
            continue;
          case 6:
            this.VideoWindow.Refresh(false, true);
            num1 = (int) num3 * -1639774487 ^ 359601924;
            continue;
          case 7:
            num1 = (int) num3 * 317849215 ^ 691470683;
            continue;
          case 8:
            num1 = (int) num3 * -808791300 ^ 1781912075;
            continue;
          case 9:
            num1 = (int) num3 * -190613394 ^ 1160078314;
            continue;
          case 10:
            num1 = (int) num3 * 858732588 ^ 1120945890;
            continue;
          case 11:
            Thread.Sleep(40);
            num1 = (int) num3 * 114471022 ^ -1537421042;
            continue;
          case 12:
            location = this.VideoWindow.Location;
            X = location.X + 25;
            location = this.VideoWindow.Location;
            num1 = (int) num3 * 2145356626 ^ 1972551677;
            continue;
          case 13:
            goto label_1;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    protected override bool ContinueExecution()
    {
label_1:
      int num1 = -2035637372;
      bool flag1;
      while (true)
      {
        int num2 = -1918109115;
        uint num3;
        bool flag2;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num1 = -1485315351;
            continue;
          case 1:
            this.SetActivityState(ActivityState.Completed, RequestCameraControl.\u206E⁬‎⁫‪‎⁬⁬‍‌⁪⁬⁫​‏‍⁪‌⁫​‌‌‪‎‮‍⁬⁭‏‍⁭​‎⁭‬‬‍⁬‍⁪‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(52179575U), (object) this.ExecutionCount));
            num1 = (int) num3 * -2103158511 ^ 1223781183;
            continue;
          case 2:
            int num4 = !flag2 ? 1268531277 : (num4 = 75030549);
            int num5 = (int) num3 * -471367896;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * -770088376 ^ -246881664;
            continue;
          case 5:
            flag1 = false;
            num1 = (int) num3 * -1493423581 ^ 1683201661;
            continue;
          case 6:
            num1 = (int) num3 * -1547071156 ^ 1818194846;
            continue;
          case 7:
            num1 = (int) num3 * -1658850624 ^ 402732537;
            continue;
          case 8:
            int num6 = flag3 ? -1240859907 : (num6 = -911875823);
            int num7 = (int) num3 * 1897647052;
            num1 = num6 ^ num7;
            continue;
          case 9:
            num1 = (int) num3 * -981748440 ^ 661902255;
            continue;
          case 10:
            int num8;
            num1 = num8 = this.ExecutionCount >= this.RequestCount ? -857653107 : (num8 = -795640852);
            continue;
          case 11:
            flag1 = false;
            num1 = (int) num3 * 1329108597 ^ -765871140;
            continue;
          case 12:
            flag3 = !base.ContinueExecution();
            num1 = (int) num3 * -1778091514 ^ -681161278;
            continue;
          case 13:
            num1 = (int) num3 * -1263140771 ^ -353314147;
            continue;
          case 14:
            goto label_1;
          case 15:
            flag1 = true;
            num1 = (int) num3 * -1816938726 ^ 370164104;
            continue;
          case 16:
            flag1 = false;
            num1 = (int) num3 * 834125495 ^ -358923785;
            continue;
          case 17:
            flag2 = !this.ValidVideoWindow();
            num1 = -501596727;
            continue;
          case 18:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3186047176U));
            num1 = (int) num3 * -802150736 ^ -1872319038;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return flag1;
    }

    internal override void ResetProperties()
    {
label_1:
      int num1 = -2025559007;
      while (true)
      {
        int num2 = -387995527;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.RequestCount = 100;
            num1 = (int) num3 * 2028635194 ^ -540077972;
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

    static string \u206E⁬‎⁫‪‎⁬⁬‍‌⁪⁬⁫​‏‍⁪‌⁫​‌‌‪‎‮‍⁬⁭‏‍⁭​‎⁭‬‬‍⁬‍⁪‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }
  }
}
