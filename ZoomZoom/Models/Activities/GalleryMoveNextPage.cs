// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.GalleryMoveNextPage
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Threading;

namespace ZoomZoom.Models.Activities
{
  public class GalleryMoveNextPage : ActivityBase
  {
    private ZoomMeeting meeting;

    public ZoomMeeting Meeting
    {
      get
      {
        bool flag = this.meeting == null;
label_1:
        int num1 = -1809939327;
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = -439037148;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              meeting = this.meeting;
              num1 = -1792489337;
              continue;
            case 1:
              this.meeting = this.Engine.ActiveMeeting;
              num1 = (int) num3 * -2088438086 ^ 1439716486;
              continue;
            case 2:
              int num4 = !flag ? 246756230 : (num4 = 1559181309);
              int num5 = (int) num3 * 1052177934;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return meeting;
      }
      set
      {
        this.meeting = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 203528794;
        TraceType traceType;
        while (true)
        {
          int num2 = 2060542359;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1770019554 ^ 718172647;
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

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = 1234319951;
      while (true)
      {
        int num2 = 2144208018;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 27U)
        {
          case 0:
            num1 = (int) num3 * 1335874550 ^ 2112825221;
            continue;
          case 1:
            this.Meeting.SetDisplayMode(DisplayMode.GalleryView);
            num1 = (int) num3 * 1477002789 ^ 2138376007;
            continue;
          case 2:
            goto label_3;
          case 3:
            Thread.Sleep(40);
            num1 = (int) num3 * -1911729027 ^ 1627515520;
            continue;
          case 4:
            num1 = (int) num3 * -1227519779 ^ -1597669574;
            continue;
          case 5:
            num1 = 178162493;
            continue;
          case 6:
            int num4 = flag2 ? -2073762039 : (num4 = -1809978068);
            int num5 = (int) num3 * -960004007;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = (int) num3 * 365267149 ^ -150692013;
            continue;
          case 8:
            num1 = (int) num3 * 1322957053 ^ -1287305929;
            continue;
          case 9:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2261462171U));
            num1 = (int) num3 * 1952129433 ^ 650067530;
            continue;
          case 10:
            int num6 = !flag1 ? -263810038 : (num6 = -347984439);
            int num7 = (int) num3 * -1822488445;
            num1 = num6 ^ num7;
            continue;
          case 11:
            int num8;
            num1 = num8 = this.ContinueExecution() ? 130017706 : (num8 = 1031100095);
            continue;
          case 12:
            this.Engine.PurgeActivityQueue();
            num1 = 622460795;
            continue;
          case 13:
            num1 = (int) num3 * -212906834 ^ 7991117;
            continue;
          case 14:
            num1 = (int) num3 * 1549967751 ^ -329799107;
            continue;
          case 15:
            int num9 = this.ClickThenDetectEvent(ZoomWindowType.GalleryScrollRight, new System.Drawing.Point(1, 1), ZoomEventType.LocationChanged, ZoomWindowType.SharedContainer, 500) ? 1787872731 : (num9 = 934174462);
            int num10 = (int) num3 * 1334332677;
            num1 = num9 ^ num10;
            continue;
          case 16:
            flag2 = this.Meeting.DisplayMode != DisplayMode.GalleryView;
            num1 = 225777520;
            continue;
          case 17:
            goto label_1;
          case 18:
            num1 = (int) num3 * 983960286 ^ -1485095901;
            continue;
          case 19:
            num1 = (int) num3 * 978987541 ^ 1913796673;
            continue;
          case 20:
            num1 = (int) num3 * -1179202356 ^ 1015506869;
            continue;
          case 21:
            this.Result = (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(390881236U);
            num1 = 1577795214;
            continue;
          case 22:
            num1 = (int) num3 * -133272433 ^ -922181824;
            continue;
          case 23:
            this.Result = (object) null;
            num1 = (int) num3 * -139997209 ^ -359924490;
            continue;
          case 24:
            this.EndTime = DateTime.Now.AddSeconds(5.0);
            num1 = (int) num3 * -855167583 ^ 835081531;
            continue;
          case 25:
            flag1 = this.Meeting == null;
            num1 = 1129402236;
            continue;
          case 26:
            num1 = (int) num3 * -1705363202 ^ -1283973478;
            continue;
          default:
            goto label_29;
        }
      }
label_29:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 1014964597;
      bool flag;
      while (true)
      {
        int num2 = 1850768483;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = true;
            num1 = (int) num3 * 1578989014 ^ -1987269536;
            continue;
          case 3:
            num1 = (int) num3 * 79510751 ^ -2143202445;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }
  }
}
