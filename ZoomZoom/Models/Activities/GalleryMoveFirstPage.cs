// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.GalleryMoveFirstPage
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom.Models.Activities
{
  public class GalleryMoveFirstPage : ActivityBase
  {
    private ZoomMeeting meeting;

    public ZoomMeeting Meeting
    {
      get
      {
        ZoomMeeting meeting = this.meeting;
label_1:
        int num1 = -1022027052;
        while (true)
        {
          int num2 = -1691581293;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 819605196 ^ 368251289;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
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
        TraceType traceType = TraceType.Activity;
label_1:
        int num1 = 1844881094;
        while (true)
        {
          int num2 = 1808936352;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -394696627 ^ 442124132;
              continue;
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
      this.EndTime = DateTime.Now.AddSeconds(10.0);
label_1:
      int num1 = 2062397442;
      while (true)
      {
        int num2 = 733447912;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
          case 9:
            flag2 = this.ContinueExecution();
            num1 = 830441132;
            continue;
          case 1:
            Thread.Sleep(40);
            num1 = (int) num3 * 1135959484 ^ 1402715013;
            continue;
          case 2:
            num1 = (int) num3 * -1073227806 ^ -327357486;
            continue;
          case 3:
            num1 = 408853045;
            continue;
          case 4:
            int num4;
            num1 = num4 = this.Meeting.DisplayMode == DisplayMode.GalleryView ? 1384956755 : (num4 = 1876156609);
            continue;
          case 5:
            flag1 = !this.ClickThenDetectEvent(ZoomWindowType.GalleryScrollLeft, new System.Drawing.Point(1, 1), ZoomEventType.LocationChanged, ZoomWindowType.SharedContainer, 500);
            num1 = (int) num3 * 1643874397 ^ 1569266132;
            continue;
          case 6:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2218175197U));
            num1 = (int) num3 * -1084676622 ^ -210514966;
            continue;
          case 7:
            int num5 = !flag1 ? -67687595 : (num5 = -958608712);
            int num6 = (int) num3 * -1235099786;
            num1 = num5 ^ num6;
            continue;
          case 8:
            int num7 = this.Meeting != null ? 1845791536 : (num7 = 141967957);
            int num8 = (int) num3 * -2087622267;
            num1 = num7 ^ num8;
            continue;
          case 10:
            goto label_1;
          case 11:
            goto label_17;
          case 12:
            this.Engine.PurgeActivityQueue();
            num1 = 1605412676;
            continue;
          case 13:
            num1 = (int) num3 * -1513519043 ^ -290898845;
            continue;
          case 14:
            this.Meeting = this.Engine.ActiveMeeting;
            num1 = (int) num3 * 1342020243 ^ -354421409;
            continue;
          case 15:
            int num9 = flag2 ? -942229469 : (num9 = -1113942952);
            int num10 = (int) num3 * 1125279112;
            num1 = num9 ^ num10;
            continue;
          case 16:
            this.Meeting.SetDisplayMode(DisplayMode.GalleryView);
            num1 = (int) num3 * 1615209763 ^ 958205241;
            continue;
          case 17:
            num1 = (int) num3 * -283244621 ^ 1619852401;
            continue;
          case 18:
            num1 = (int) num3 * 755276825 ^ 1162124562;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return;
label_17:;
    }

    private new bool ClickThenDetectEvent(ZoomWindowType windowToClick, System.Drawing.Point whereToClick, ZoomEventType eventTypeToDetect, ZoomWindowType windowTypeToDetect, int millisecondsToWait = 500)
    {
label_1:
      int num1 = 9819152;
      bool flag1;
      while (true)
      {
        int num2 = 33214538;
        uint num3;
        DateTime dateTime;
        ZoomWindow window;
        bool flag2;
        bool flag3;
        ZoomEvent zoomEvent;
        bool flag4;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 36U)
        {
          case 1:
            num1 = (int) num3 * -1718785416 ^ -505455158;
            continue;
          case 2:
            flag3 = false;
            num1 = (int) num3 * 1472580387 ^ 1848441531;
            continue;
          case 3:
            num1 = 913480897;
            continue;
          case 4:
            num1 = (int) num3 * -2083235473 ^ 1996052164;
            continue;
          case 5:
            this.Engine.PurgeActivityQueue();
            num1 = (int) num3 * -745065826 ^ 167819453;
            continue;
          case 6:
            num1 = (int) num3 * 888879195 ^ -1963980300;
            continue;
          case 7:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(609491144U), (object) windowToClick, (object) whereToClick, (object) millisecondsToWait);
            num1 = (int) num3 * -1841781536 ^ 1413947511;
            continue;
          case 8:
            num1 = (int) num3 * -388767698 ^ -682445587;
            continue;
          case 9:
            num4 = !flag3 ? 1 : 0;
            break;
          case 10:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3079520462U));
            num1 = (int) num3 * 739092399 ^ 683929586;
            continue;
          case 11:
            window = this.Engine.GetWindow(windowToClick);
            flag4 = window != null;
            num1 = (int) num3 * -589686225 ^ 136485789;
            continue;
          case 12:
            flag3 = true;
            num1 = (int) num3 * 434577537 ^ 1526279434;
            continue;
          case 13:
            int num6 = flag2 ? -1223984701 : (num6 = -1164283149);
            int num7 = (int) num3 * -1713369342;
            num1 = num6 ^ num7;
            continue;
          case 14:
            goto label_1;
          case 15:
            num1 = (int) num3 * 1825025636 ^ -1090459505;
            continue;
          case 16:
            num1 = (int) num3 * -2028154608 ^ -1142775289;
            continue;
          case 17:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1686029112U));
            num1 = (int) num3 * 1954416974 ^ -760823539;
            continue;
          case 18:
            int num8 = !flag4 ? -539521437 : (num8 = -726233546);
            int num9 = (int) num3 * -194143724;
            num1 = num8 ^ num9;
            continue;
          case 19:
            num1 = (int) num3 * 868501995 ^ 954555727;
            continue;
          case 20:
            num1 = (int) num3 * 660977740 ^ -2045317615;
            continue;
          case 21:
            window.Click(whereToClick, true, true, 0);
            num1 = (int) num3 * -1648056974 ^ -2001878146;
            continue;
          case 22:
            int num10;
            num1 = num10 = this.Engine.ActivityQueue.TryDequeue(ref zoomEvent) ? 1363671470 : (num10 = 911632677);
            continue;
          case 23:
            num1 = (int) num3 * -1712088030 ^ -1725024927;
            continue;
          case 24:
            if (!(dateTime >= DateTime.Now))
            {
              num4 = 0;
              break;
            }
            num1 = 1116395663;
            continue;
          case 25:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1563047574U), (object) zoomEvent);
            num1 = (int) num3 * -1959081931 ^ 23549635;
            continue;
          case 26:
            GalleryMoveFirstPage.\u200C‬‏‭⁪‪⁬‍⁬​‬‫‭‬‭‮‌⁪‫‭‫⁬‫⁫⁪⁫‏‮‫‏‏⁫‏‭‏⁯⁬​‍‮‮(40);
            num1 = (int) num3 * 1228556992 ^ -1371053471;
            continue;
          case 27:
            num1 = (int) num3 * 499161008 ^ 1041244154;
            continue;
          case 28:
            flag1 = flag3;
            num1 = 656622365;
            continue;
          case 29:
            num1 = 911632677;
            continue;
          case 30:
            if (zoomEvent.EventType != eventTypeToDetect)
            {
              num5 = 0;
              goto label_20;
            }
            else
            {
              num1 = (int) num3 * 2031427859 ^ -2029943616;
              continue;
            }
          case 31:
            num1 = 1059108686;
            continue;
          case 32:
            num5 = zoomEvent.ZoomWindowType == windowTypeToDetect ? 1 : 0;
            goto label_20;
          case 33:
            num1 = 860896744;
            continue;
          case 34:
            flag2 = !flag3;
            num1 = (int) num3 * -1548462641 ^ 1570030893;
            continue;
          case 35:
            dateTime = DateTime.Now.AddMilliseconds((double) millisecondsToWait);
            num1 = (int) num3 * -2134994787 ^ -1644524143;
            continue;
          default:
            goto label_43;
        }
        int num11;
        num1 = num11 = num4 == 0 ? 757985552 : (num11 = 1976158244);
        continue;
label_20:
        int num12;
        num1 = num12 = num5 == 0 ? 1719191815 : (num12 = 138177813);
      }
label_43:
      return flag1;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = -1244738565;
      bool flag;
      while (true)
      {
        int num2 = -630865278;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1956816880 ^ -1507702775;
            continue;
          case 1:
            flag = true;
            num1 = (int) num3 * 615519076 ^ 240374914;
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

    static void \u200C‬‏‭⁪‪⁬‍⁬​‬‫‭‬‭‮‌⁪‫‭‫⁬‫⁫⁪⁫‏‮‫‏‏⁫‏‭‏⁯⁬​‍‮‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }
  }
}
