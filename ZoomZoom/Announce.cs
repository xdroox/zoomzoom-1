// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Announce
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Activities;

namespace ZoomZoom
{
  public class Announce : ActivityBase
  {
    private string meetingId;
    private string message;

    public string MeetingId
    {
      get
      {
label_1:
        int num1 = 316868600;
        string meetingId;
        while (true)
        {
          int num2 = 915512250;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1372331072 ^ -1719450847;
              continue;
            case 2:
              meetingId = this.meetingId;
              num1 = (int) num3 * -427967897 ^ -851678811;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingId;
      }
      set
      {
label_1:
        int num1 = -1053103918;
        while (true)
        {
          int num2 = -779190268;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.meetingId = value;
              num1 = (int) num3 * 675857792 ^ -1573375110;
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

    public string Message
    {
      get
      {
label_1:
        int num1 = -879102454;
        string message;
        while (true)
        {
          int num2 = -246684401;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -2145335346 ^ -318451328;
              continue;
            case 1:
              message = this.message;
              num1 = (int) num3 * 1110264699 ^ -383771592;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return message;
      }
      set
      {
        this.message = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Activity;
label_1:
        int num1 = 1763818935;
        while (true)
        {
          int num2 = 2101384151;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -552888882 ^ -258053127;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public Announce(SharedData sharedData, string meetingId, string message)
    {
label_1:
      int num1 = 2034768034;
      while (true)
      {
        int num2 = 370844301;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.message = message;
            num1 = (int) num3 * -994259246 ^ 1689061925;
            continue;
          case 3:
            this.meetingId = meetingId;
            num1 = (int) num3 * 449221766 ^ -509432594;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      this.ActivityState = ActivityState.Pending;
    }

    public override string ToString()
    {
      string str = Announce.\u202D⁮​‌‫‫⁭⁫⁫​‭‫⁮⁭‮‮⁮‎‌‪‫⁮⁫‎⁬‌⁪‎​‬⁪‍‎‌⁬⁯⁬⁬‏‭‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3996077059U), (object) this.MeetingId, (object) this.Message);
label_1:
      int num1 = 480940364;
      while (true)
      {
        int num2 = 2044924041;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 572748013 ^ -302122731;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return str;
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = -597601468;
      while (true)
      {
        int num2 = -970769528;
        uint num3;
        bool flag1;
        ZoomMeeting meeting;
        bool flag2;
        bool flag3;
        bool flag4;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 32U)
        {
          case 0:
            num1 = (int) num3 * 264497181 ^ 1438133879;
            continue;
          case 1:
            int num5 = !flag1 ? 1680997069 : (num5 = 616840567);
            int num6 = (int) num3 * 1984730050;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num1 = (int) num3 * 995680440 ^ 991512511;
            continue;
          case 3:
            Announce.\u200E⁮⁬‭⁯‬‎‫⁬‪⁫‪⁬⁬⁪​‌⁮⁭‎‍⁫​‏‍⁬​⁪‌⁪​⁫‎‏⁯‫⁪‬‌⁪‮(250);
            num1 = (int) num3 * -1074311190 ^ -2044741964;
            continue;
          case 4:
            flag2 = this.ExecuteSubActivity((ActivityBase) new SendChat(this.Message, ""), true) == ActivityState.Completed;
            num1 = (int) num3 * 214110921 ^ -585818975;
            continue;
          case 5:
            int num7 = (int) this.ExecuteSubActivity((ActivityBase) new LeaveMeeting(), true);
            num1 = (int) num3 * -522035804 ^ 1743092745;
            continue;
          case 6:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3570690916U));
            num1 = (int) num3 * 1718679283 ^ 565212720;
            continue;
          case 7:
            num1 = -1304752304;
            continue;
          case 8:
            int num8 = flag3 ? 236063772 : (num8 = 1989863192);
            int num9 = (int) num3 * -1725431187;
            num1 = num8 ^ num9;
            continue;
          case 9:
            num1 = -1358244610;
            continue;
          case 10:
            num1 = (int) num3 * -2011441068 ^ -1246942405;
            continue;
          case 11:
            flag4 = meeting != null;
            num1 = (int) num3 * -1589660852 ^ -873542852;
            continue;
          case 12:
            ActivityState activityState = ActivityBase.activityState;
            flag3 = this.Engine.ActiveMeeting == null;
            num1 = (int) num3 * 1828529538 ^ 338203768;
            continue;
          case 13:
            int num10 = !flag2 ? 26227343 : (num10 = 1689030471);
            int num11 = (int) num3 * -1428872596;
            num1 = num10 ^ num11;
            continue;
          case 14:
            meeting = this.Engine.GetMeeting(this.MeetingId, false);
            num1 = (int) num3 * 721104437 ^ -1964815291;
            continue;
          case 15:
            num1 = (int) num3 * -2011498030 ^ -214696873;
            continue;
          case 16:
            int num12 = !flag4 ? -1751512726 : (num12 = -1099143944);
            int num13 = (int) num3 * 1053284621;
            num1 = num12 ^ num13;
            continue;
          case 17:
            goto label_3;
          case 18:
            flag1 = this.ExecuteSubActivity((ActivityBase) new JoinMeeting(this.MeetingId), true) == ActivityState.Completed;
            num1 = -1891466071;
            continue;
          case 19:
            num1 = (int) num3 * 301208630 ^ 1593698732;
            continue;
          case 20:
            num1 = (int) num3 * 1247877267 ^ -1312057488;
            continue;
          case 21:
            num1 = -1196565049;
            continue;
          case 22:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4127044336U));
            num1 = (int) num3 * -1031956688 ^ 348897209;
            continue;
          case 23:
            num1 = (int) num3 * 1462944620 ^ -1285211794;
            continue;
          case 24:
            if (this.Engine.ActiveMeeting != null)
            {
              num1 = -1693615375;
              continue;
            }
            num4 = 0;
            break;
          case 25:
            num4 = Announce.\u200B⁬⁯‍‌⁫‬‌​​‍‮⁬‬⁮⁯⁫‮‮‍⁪‫⁪‎‮​‮​⁫‪​​‬⁪‭‌⁪‬⁬⁫‮(this.Engine.ActiveMeeting.MeetingId, this.MeetingId) ? 1 : 0;
            break;
          case 26:
            num1 = (int) num3 * -22114705 ^ -1516202599;
            continue;
          case 27:
            int num14;
            num1 = num14 = this.Engine.ActiveMeeting == null ? -821949763 : (num14 = -1980296147);
            continue;
          case 28:
            num1 = (int) num3 * -162243695 ^ -2047761542;
            continue;
          case 29:
            num1 = (int) num3 * -1169083324 ^ -1448956065;
            continue;
          case 30:
            goto label_1;
          case 31:
            meeting.SuspendMeetingActivities = true;
            num1 = (int) num3 * 567253724 ^ 927645590;
            continue;
          default:
            goto label_37;
        }
        int num15;
        num1 = num15 = num4 != 0 ? -1839188836 : (num15 = -1138537919);
      }
label_37:
      return;
label_3:;
    }

    internal override bool Valid()
    {
      if (Announce.\u200B‮⁯‎‫⁯‏‮‌‍‬‬‪⁬‬​⁪‬‬⁭⁪‮⁯‬‪‎⁭‬‎‎‍‍⁭‭‬⁪‭‫⁮⁪‮(this.MeetingId))
        goto label_4;
label_1:
      int num1 = 1412892663;
label_2:
      while (true)
      {
        int num2 = 653487273;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * -1546731449 ^ 1593586841;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      int num4 = !Announce.\u200B‮⁯‎‫⁯‏‮‌‍‬‬‪⁬‬​⁪‬‬⁭⁪‮⁯‬‪‎⁭‬‎‎‍‍⁭‭‬⁪‭‫⁮⁪‮(this.Message) ? 1 : 0;
      goto label_5;
label_7:
      bool flag;
      return flag;
label_4:
      num4 = 0;
label_5:
      flag = num4 != 0;
      num1 = 1028777034;
      goto label_2;
    }

    static string \u202D⁮​‌‫‫⁭⁫⁫​‭‫⁮⁭‮‮⁮‎‌‪‫⁮⁫‎⁬‌⁪‎​‬⁪‍‎‌⁬⁯⁬⁬‏‭‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static void \u200E⁮⁬‭⁯‬‎‫⁬‪⁫‪⁬⁬⁪​‌⁮⁭‎‍⁫​‏‍⁬​⁪‌⁪​⁫‎‏⁯‫⁪‬‌⁪‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static bool \u200B⁬⁯‍‌⁫‬‌​​‍‮⁬‬⁮⁯⁫‮‮‍⁪‫⁪‎‮​‮​⁫‪​​‬⁪‭‌⁪‬⁬⁫‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u200B‮⁯‎‫⁯‏‮‌‍‬‬‪⁬‬​⁪‬‬⁭⁪‮⁯‬‪‎⁭‬‎‎‍‍⁭‭‬⁪‭‫⁮⁪‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }
  }
}
