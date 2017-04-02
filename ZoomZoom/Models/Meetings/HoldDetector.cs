// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Meetings.HoldDetector
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom.Models.Meetings
{
  internal class HoldDetector : CoreObject
  {
    private static readonly object holdLocker = HoldDetector.\u206C​‭‏⁫‍‌⁬‪‏‍⁫‪​‮‎⁬‏‬​‌‮‏⁯⁭‬⁯​⁭‪⁬‮‫‌‌⁪‭‌⁫‬‮();

    public bool IsOnHold { get; set; }

    public ZoomMeeting Meeting { get; set; }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -1493643206;
        TraceType traceType;
        while (true)
        {
          int num2 = -667062023;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1088448783 ^ 862535516;
              continue;
            case 2:
              goto label_1;
            case 3:
              traceType = TraceType.Meeting;
              num1 = (int) num3 * 1771517348 ^ 1387801561;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public HoldDetector()
    {
      this.IsOnHold = false;
      ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingJoinedEvent>()).Subscribe(new Action<ZoomMeeting>(this.OnMeetingJoined), (ThreadOption) 2, true);
      ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingLeftEvent>()).Subscribe(new Action<ZoomMeeting>(this.OnMeetingLeft), (ThreadOption) 2, true);
    }

    private void OnMeetingLeft(ZoomMeeting meeting)
    {
      object holdLocker = HoldDetector.holdLocker;
      bool flag = false;
      try
      {
        HoldDetector.\u200E‬‌‪⁬‌‎‎‮‭‬‌‭‎‎‫⁫‍‭⁬⁪​‍⁫‪⁬‎⁪‏⁫‏⁮‪‎⁯‫⁬‏⁭⁪‮(holdLocker, ref flag);
label_2:
        int num1 = -1476136279;
        while (true)
        {
          int num2 = -1366781622;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_2;
            case 1:
              this.Meeting = meeting;
              num1 = (int) num3 * -1306485501 ^ -946031125;
              continue;
            case 2:
              num1 = (int) num3 * 54739429 ^ 820613508;
              continue;
            case 3:
              num1 = (int) num3 * 1485028652 ^ -1354547811;
              continue;
            case 4:
              this.IsOnHold = false;
              num1 = (int) num3 * -1247625724 ^ -237569685;
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
          int num1 = -1319745280;
          while (true)
          {
            int num2 = -1366781622;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_10;
              case 2:
                HoldDetector.\u200B‌‎‪⁪‮⁫​‎​‭‍‎⁪‎‭⁬⁬⁮⁫‫⁯‭⁭‎‫‫⁭‪‏⁬​⁫⁭⁬​​‮⁬‮‮(holdLocker);
                num1 = (int) num3 * 87520059 ^ -1737137733;
                continue;
              case 3:
                num1 = (int) num3 * -1552299993 ^ -1027249850;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    private void OnMeetingJoined(ZoomMeeting meeting)
    {
label_1:
      int num1 = 1834918049;
      object holdLocker;
      while (true)
      {
        int num2 = 1427316196;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            holdLocker = HoldDetector.holdLocker;
            num1 = (int) num3 * 267679950 ^ 757095514;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        HoldDetector.\u200E‬‌‪⁬‌‎‎‮‭‬‌‭‎‎‫⁫‍‭⁬⁪​‍⁫‪⁬‎⁪‏⁫‏⁮‪‎⁯‫⁬‏⁭⁪‮(holdLocker, ref flag);
label_6:
        int num2 = 638058013;
        while (true)
        {
          int num3 = 1427316196;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_15;
            case 1:
              num2 = (int) num4 * -1267830688 ^ 1912516668;
              continue;
            case 2:
              goto label_6;
            case 3:
              this.Meeting = meeting;
              num2 = (int) num4 * 69754590 ^ -139217728;
              continue;
            case 4:
              this.IsOnHold = false;
              num2 = (int) num4 * 1814055653 ^ -1650573987;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_15:;
      }
      finally
      {
        if (flag)
        {
label_13:
          int num2 = 1344187761;
          while (true)
          {
            int num3 = 1427316196;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                HoldDetector.\u200B‌‎‪⁪‮⁫​‎​‭‍‎⁪‎‭⁬⁬⁮⁫‫⁯‭⁭‎‫‫⁭‪‏⁬​⁫⁭⁬​​‮⁬‮‮(holdLocker);
                num2 = (int) num4 * -1484969325 ^ -897782376;
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
    }

    internal bool CheckEvent(ZoomEvent zoomEvent)
    {
      bool flag1 = !this.IsOnHold;
label_1:
      int num1 = 1028763422;
      bool isOnHold1;
      while (true)
      {
        int num2 = 155680092;
        uint num3;
        bool flag2;
        bool flag3;
        bool isOnHold2;
        List<ZoomWindow> list1;
        List<ZoomWindow> list2;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 33U)
        {
          case 0:
            if (this.Engine.ActiveMeetingWindow != null)
            {
              num1 = (int) num3 * -859681923 ^ 446878712;
              continue;
            }
            goto label_31;
          case 1:
            num5 = HoldDetector.\u200D‭‮⁬‌‌​​⁫‏⁯‪⁯⁮‭‎‏‮⁬⁭‍⁭‍‍‭‪⁯‌‫‭‬⁮⁮⁪⁮​‌‭⁯‌‮(zoomEvent.WindowClass, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2801244503U)) ? 1 : 0;
            break;
          case 2:
            num1 = 1745914111;
            continue;
          case 3:
            num1 = (int) num3 * -1907434036 ^ 1388623791;
            continue;
          case 4:
            int num7 = zoomEvent.EventType != ZoomEventType.Hide ? 1316570192 : (num7 = 48718970);
            int num8 = (int) num3 * 346480996;
            num1 = num7 ^ num8;
            continue;
          case 5:
            int num9 = !flag2 ? -2146688424 : (num9 = -1262443827);
            int num10 = (int) num3 * -1618154879;
            num1 = num9 ^ num10;
            continue;
          case 6:
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingRemovedFromHold>()).Publish(Engine.Instance.ActiveMeeting);
            num1 = (int) num3 * 1075261844 ^ 1499877329;
            continue;
          case 7:
            goto label_1;
          case 8:
            num6 = HoldDetector.\u200D‭‮⁬‌‌​​⁫‏⁯‪⁯⁮‭‎‏‮⁬⁭‍⁭‍‍‭‪⁯‌‫‭‬⁮⁮⁪⁮​‌‭⁯‌‮(zoomEvent.WindowClass, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(118217023U)) ? 1 : 0;
            goto label_43;
          case 9:
            if (zoomEvent.EventType == ZoomEventType.Show)
            {
              num1 = 2130013859;
              continue;
            }
            num5 = 0;
            break;
          case 10:
            isOnHold1 = this.IsOnHold;
            num1 = 693816777;
            continue;
          case 11:
            num1 = (int) num3 * 990239155 ^ 1566178599;
            continue;
          case 12:
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingPlacedOnHold>()).Publish(Engine.Instance.ActiveMeeting);
            num1 = (int) num3 * -661187690 ^ -561297066;
            continue;
          case 13:
            num4 = this.Engine.ActiveMeetingWindow.IsVisible ? 1 : 0;
            goto label_32;
          case 14:
            num1 = 757310030;
            continue;
          case 15:
            num1 = (int) num3 * -30517977 ^ 784804791;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list1 = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) list2, (Func<M0, bool>) (HoldDetector.\u003C\u003Ec.\u003C\u003E9__14_1 ?? (HoldDetector.\u003C\u003Ec.\u003C\u003E9__14_1 = new Func<ZoomWindow, bool>((object) HoldDetector.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCheckEvent\u003Eb__14_1)))))).ToList<ZoomWindow>();
            num1 = 1164652866;
            continue;
          case 17:
            if (!HoldDetector.\u200D‭‮⁬‌‌​​⁫‏⁯‪⁯⁮‭‎‏‮⁬⁭‍⁭‍‍‭‪⁯‌‫‭‬⁮⁮⁪⁮​‌‭⁯‌‮(zoomEvent.WindowClass, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(422517909U)))
            {
              num1 = (int) num3 * -2032484016 ^ -98562088;
              continue;
            }
            num6 = 1;
            goto label_43;
          case 18:
            int num11 = !flag3 ? 1481919254 : (num11 = 148521951);
            int num12 = (int) num3 * 1931693250;
            num1 = num11 ^ num12;
            continue;
          case 19:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list2 = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.ActiveWindows, (Func<M0, bool>) (HoldDetector.\u003C\u003Ec.\u003C\u003E9__14_0 ?? (HoldDetector.\u003C\u003Ec.\u003C\u003E9__14_0 = new Func<ZoomWindow, bool>((object) HoldDetector.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCheckEvent\u003Eb__14_0)))))).ToList<ZoomWindow>();
            num1 = 1033907094;
            continue;
          case 20:
            num1 = (int) num3 * -99598336 ^ -56611356;
            continue;
          case 21:
            this.IsOnHold = false;
            num1 = (int) num3 * -1001444294 ^ 1797507501;
            continue;
          case 22:
            if (list2.Count > 0)
            {
              num1 = (int) num3 * -300247385 ^ 1879350869;
              continue;
            }
            goto label_31;
          case 23:
            num1 = (int) num3 * -904134314 ^ -307186767;
            continue;
          case 24:
            num1 = (int) num3 * -1784784803 ^ -1290725405;
            continue;
          case 25:
            int num13 = isOnHold2 ? -1987341316 : (num13 = -1219386652);
            int num14 = (int) num3 * -1471307357;
            num1 = num13 ^ num14;
            continue;
          case 26:
            if (list1.Count == 0)
            {
              num1 = (int) num3 * 680160310 ^ -1317242076;
              continue;
            }
            goto label_31;
          case 28:
            num1 = 844564615;
            continue;
          case 29:
            isOnHold2 = this.IsOnHold;
            num1 = 1192265628;
            continue;
          case 30:
            num1 = (int) num3 * -239102751 ^ -286279292;
            continue;
          case 31:
            this.IsOnHold = true;
            num1 = (int) num3 * -1816081388 ^ -721728151;
            continue;
          case 32:
            int num15 = !flag1 ? 515354109 : (num15 = 1032815869);
            int num16 = (int) num3 * 2056930124;
            num1 = num15 ^ num16;
            continue;
          default:
            goto label_45;
        }
        flag2 = num5 != 0;
        num1 = 645817735;
        continue;
label_31:
        num4 = 0;
label_32:
        int num17;
        num1 = num17 = num4 == 0 ? 1544639692 : (num17 = 1558806085);
        continue;
label_43:
        flag3 = num6 != 0;
        num1 = 1023385968;
      }
label_45:
      return isOnHold1;
    }

    static void \u200E‬‌‪⁬‌‎‎‮‭‬‌‭‎‎‫⁫‍‭⁬⁪​‍⁫‪⁬‎⁪‏⁫‏⁮‪‎⁯‫⁬‏⁭⁪‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200B‌‎‪⁪‮⁫​‎​‭‍‎⁪‎‭⁬⁬⁮⁫‫⁯‭⁭‎‫‫⁭‪‏⁬​⁫⁭⁬​​‮⁬‮‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static bool \u200D‭‮⁬‌‌​​⁫‏⁯‪⁯⁮‭‎‏‮⁬⁭‍⁭‍‍‭‪⁯‌‫‭‬⁮⁮⁪⁮​‌‭⁯‌‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static object \u206C​‭‏⁫‍‌⁬‪‏‍⁫‪​‮‎⁬‏‬​‌‮‏⁯⁭‬⁯​⁭‪⁬‮‫‌‌⁪‭‌⁫‬‮()
    {
      return new object();
    }
  }
}
