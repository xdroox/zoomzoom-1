// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.PeekMeeting
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Activities
{
  public class PeekMeeting : ActivityBase
  {
    private MeetingStatus meetingStatus = MeetingStatus.Unknown;
    private LayoutPattern startingPattern = (LayoutPattern) null;
    private LayoutPattern peekPattern = (LayoutPattern) null;
    private bool startingSuspendMeetingActivitiesValue = false;
    private ZoomMeeting meeting;
    private ZoomWindow meetingWindow;
    private PeekOptions peekOptions;

    public ZoomMeeting Meeting
    {
      get
      {
label_1:
        int num1 = -18191255;
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = -1937457764;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              meeting = this.meeting;
              num1 = (int) num3 * -1416959189 ^ 1564571496;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -2097613203 ^ 369864871;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meeting;
      }
      set
      {
        this.meeting = value;
label_1:
        int num1 = -2038126869;
        while (true)
        {
          int num2 = -1588414444;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3414529975U));
              num1 = (int) num3 * -608984816 ^ 850234975;
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

    public MeetingStatus MeetingStatus
    {
      get
      {
        MeetingStatus meetingStatus = this.meetingStatus;
label_1:
        int num1 = 1954007561;
        while (true)
        {
          int num2 = 689094960;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1268524397 ^ 1738441562;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingStatus;
      }
      set
      {
label_1:
        int num1 = 91430760;
        while (true)
        {
          int num2 = 2015445999;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(993446542U));
              num1 = (int) num3 * 723120318 ^ 1431615863;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.meetingStatus = value;
              num1 = (int) num3 * 1440250243 ^ -341851941;
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

    public new ZoomWindow MeetingWindow
    {
      get
      {
label_1:
        int num1 = 1413966158;
        ZoomWindow meetingWindow;
        while (true)
        {
          int num2 = 1908533249;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1281589387 ^ 820819468;
              continue;
            case 2:
              goto label_1;
            case 3:
              meetingWindow = this.meetingWindow;
              num1 = (int) num3 * 1597298959 ^ -143968604;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingWindow;
      }
      set
      {
label_1:
        int num1 = 538995554;
        while (true)
        {
          int num2 = 1417041937;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              this.meetingWindow = value;
              num1 = (int) num3 * -2026868675 ^ -1464278300;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2592807490U));
      }
    }

    public PeekOptions PeekOptions
    {
      get
      {
label_1:
        int num1 = -708209492;
        PeekOptions peekOptions;
        while (true)
        {
          int num2 = -2140920981;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -8757012 ^ 1238715754;
              continue;
            case 2:
              goto label_1;
            case 3:
              peekOptions = this.peekOptions;
              num1 = (int) num3 * 1099861681 ^ -2036232336;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return peekOptions;
      }
      set
      {
        this.peekOptions = value;
label_1:
        int num1 = -1338857431;
        while (true)
        {
          int num2 = -1479245131;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3191245312U));
              num1 = (int) num3 * 1092784772 ^ 814189791;
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

    public LayoutPattern StartingPattern
    {
      get
      {
        return this.startingPattern;
      }
      set
      {
label_1:
        int num1 = -2037599159;
        while (true)
        {
          int num2 = -1321264259;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.startingPattern = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4221160368U));
              num1 = (int) num3 * -694567666 ^ 1638379762;
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

    public LayoutPattern PeekPattern
    {
      get
      {
label_1:
        int num1 = 623119905;
        LayoutPattern peekPattern;
        while (true)
        {
          int num2 = 268167132;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1000126953 ^ -522033494;
              continue;
            case 1:
              peekPattern = this.peekPattern;
              num1 = (int) num3 * 1125313589 ^ -1882073139;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return peekPattern;
      }
      set
      {
label_1:
        int num1 = 1231744058;
        while (true)
        {
          int num2 = 111788456;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1904335925 ^ 1208825150;
              continue;
            case 2:
              this.peekPattern = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2164151065U));
              num1 = (int) num3 * -414722929 ^ -794700101;
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

    public bool StartingSuspendMeetingActivitiesValue
    {
      get
      {
        return this.startingSuspendMeetingActivitiesValue;
      }
      set
      {
label_1:
        int num1 = -1422353636;
        while (true)
        {
          int num2 = -1291606008;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.startingSuspendMeetingActivitiesValue = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2236530541U));
              num1 = (int) num3 * 597295798 ^ -922127147;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 493612318;
        TraceType traceType;
        while (true)
        {
          int num2 = 24811276;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1168899743 ^ -603369359;
              continue;
            case 3:
              num1 = (int) num3 * 1784071460 ^ -1300212327;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public PeekMeeting(ZoomMeeting meeting)
    {
label_1:
      int num1 = 1130735667;
      while (true)
      {
        int num2 = 2042859534;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.Meeting = meeting;
            num1 = (int) num3 * -2030090 ^ -1161363232;
            continue;
          case 1:
            num1 = (int) num3 * -2015495028 ^ 1248908857;
            continue;
          case 2:
            goto label_1;
          case 4:
            num1 = (int) num3 * 755882296 ^ -1295969700;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      this.PeekOptions = new PeekOptions();
    }

    internal override void SetActivityState(ActivityState state, string newStatusMessage = "")
    {
label_1:
      int num1 = 1119599732;
      while (true)
      {
        int num2 = 208451977;
        uint num3;
        bool flag1;
        bool specializedPattern;
        bool flag2;
        bool flag3;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 35U)
        {
          case 0:
            int num7 = !flag3 ? -1612544104 : (num7 = -1419642765);
            int num8 = (int) num3 * -301741879;
            num1 = num7 ^ num8;
            continue;
          case 1:
            int num9 = flag1 ? -809606692 : (num9 = -671813835);
            int num10 = (int) num3 * 1645637841;
            num1 = num9 ^ num10;
            continue;
          case 2:
            int num11;
            num1 = num11 = this.StartingPattern != null ? 2134264430 : (num11 = 105040917);
            continue;
          case 3:
            num4 = this.Meeting.MeetingStatus == MeetingStatus.Attending ? 1 : 0;
            goto label_43;
          case 4:
            num1 = (int) num3 * -1346372929 ^ 934496170;
            continue;
          case 5:
            num1 = (int) num3 * -1911165766 ^ -1932536803;
            continue;
          case 6:
            num1 = (int) num3 * 1597955778 ^ -1269385245;
            continue;
          case 7:
            num1 = (int) num3 * 1767832407 ^ -1145210218;
            continue;
          case 8:
            this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2815597193U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2703915874U));
            int num12 = (int) this.ExecuteSubActivity((ActivityBase) new LeaveMeeting(), true);
            num1 = (int) num3 * 2044804075 ^ -1083326984;
            continue;
          case 9:
            num1 = 1083858335;
            continue;
          case 10:
            int num13 = specializedPattern ? 114533128 : (num13 = 1740814151);
            int num14 = (int) num3 * -415507923;
            num1 = num13 ^ num14;
            continue;
          case 11:
            base.SetActivityState(state, newStatusMessage);
            num1 = (int) num3 * 2127525520 ^ -602791872;
            continue;
          case 12:
            num1 = (int) num3 * -940336074 ^ 154855338;
            continue;
          case 13:
            goto label_1;
          case 14:
            this.Engine.ActivePattern = this.StartingPattern;
            num1 = (int) num3 * -1145321464 ^ -1916857415;
            continue;
          case 15:
            if (this.PeekOptions.LeaveMeetingOnceCompleted)
            {
              num1 = (int) num3 * -1731988308 ^ 988105644;
              continue;
            }
            num4 = 0;
            goto label_43;
          case 16:
            num1 = (int) num3 * 486233284 ^ 2106378585;
            continue;
          case 17:
            num1 = (int) num3 * -620271542 ^ -762242368;
            continue;
          case 18:
            num5 = this.Meeting.SuspendMeetingActivities != this.StartingSuspendMeetingActivitiesValue ? 1 : 0;
            break;
          case 19:
            if (this.Meeting == null)
            {
              num5 = 0;
              break;
            }
            num1 = 425611366;
            continue;
          case 20:
            this.StartingPattern = this.Engine.ActivePattern;
            num1 = (int) num3 * -1338512630 ^ 779432393;
            continue;
          case 21:
            goto label_3;
          case 22:
            num1 = 687210457;
            continue;
          case 23:
            num1 = (int) num3 * -1110079759 ^ -885497926;
            continue;
          case 24:
            this.Meeting.SuspendMeetingActivities = this.StartingSuspendMeetingActivitiesValue;
            num1 = (int) num3 * -925769154 ^ 908189641;
            continue;
          case 25:
            num1 = 1272004329;
            continue;
          case 26:
            num1 = (int) num3 * -1174147580 ^ -52254667;
            continue;
          case 27:
            specializedPattern = this.PeekOptions.UseSpecializedPattern;
            num1 = (int) num3 * -1943016498 ^ -1372834483;
            continue;
          case 28:
            this.PeekPattern = this.Engine.GetPattern(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(144685666U));
            num1 = (int) num3 * -551285894 ^ -759558952;
            continue;
          case 29:
            int num15 = flag2 ? 1360914556 : (num15 = 1542347502);
            int num16 = (int) num3 * -592465229;
            num1 = num15 ^ num16;
            continue;
          case 30:
            flag1 = this.PeekPattern != null;
            num1 = (int) num3 * -1998182426 ^ -1299430216;
            continue;
          case 31:
            int num17 = state != ActivityState.InProgress ? 2111836317 : (num17 = 1924254559);
            int num18 = (int) num3 * -1714351534;
            num1 = num17 ^ num18;
            continue;
          case 32:
            if (state == ActivityState.Pending)
            {
              num6 = 0;
              goto label_18;
            }
            else
            {
              num1 = 1826702197;
              continue;
            }
          case 33:
            this.Engine.ActivePattern = this.PeekPattern;
            num1 = (int) num3 * 2037631169 ^ -2138954413;
            continue;
          case 34:
            num6 = state != ActivityState.InProgress ? 1 : 0;
            goto label_18;
          default:
            goto label_46;
        }
        int num19;
        num1 = num19 = num5 == 0 ? 1284813879 : (num19 = 218324314);
        continue;
label_18:
        flag2 = num6 != 0;
        num1 = 870554324;
        continue;
label_43:
        flag3 = num4 != 0;
        num1 = 583055014;
      }
label_46:
      return;
label_3:;
    }

    private MeetingStatus ExecuteJoinMeeting()
    {
label_1:
      int num1 = -1009735216;
      MeetingStatus meetingStatus;
      while (true)
      {
        int num2 = -1571259832;
        uint num3;
        JoinMeeting joinMeeting1;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            meetingStatus = this.MeetingStatus;
            num1 = (int) num3 * -1415941413 ^ -551822748;
            continue;
          case 1:
            JoinMeeting joinMeeting2 = new JoinMeeting(this.Meeting.MeetingId);
            joinMeeting2.Options = new ActivityOptions()
            {
              SuppressProgressReports = true
            };
            joinMeeting1 = joinMeeting2;
            num1 = (int) num3 * 1895119091 ^ -1822725334;
            continue;
          case 2:
            this.ReportProgress(PeekMeeting.\u206A⁬‏⁭‌​‎‬‍​‭⁮‮‭‌‭‮‪‪‎‎‬⁪‍⁮⁬⁮⁭⁮‍⁭‪‬‏‏⁪‫‏‫⁪‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3699838875U), (object) this.Meeting.MeetingId), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1528598119U));
            num1 = (int) num3 * -218534857 ^ -1370009170;
            continue;
          case 4:
            this.MeetingStatus = joinMeeting1.MeetingStatus;
            num1 = (int) num3 * 132412687 ^ -742744897;
            continue;
          case 5:
            num1 = (int) num3 * -1985521846 ^ -827340693;
            continue;
          case 6:
            goto label_1;
          case 7:
            int num4 = (int) this.ExecuteSubActivity((ActivityBase) joinMeeting1, true);
            this.Status = joinMeeting1.Status;
            num1 = (int) num3 * -1693894413 ^ 1371928681;
            continue;
          case 8:
            num1 = (int) num3 * 569943110 ^ 1072339779;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return meetingStatus;
    }

    private void ExecuteCaptureMeeting()
    {
label_1:
      int num1 = 80200673;
      while (true)
      {
        int num2 = 1098543758;
        uint num3;
        CaptureMeeting captureMeeting;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            captureMeeting = new CaptureMeeting();
            num1 = (int) num3 * 351817307 ^ 1293354059;
            continue;
          case 2:
            this.SetActivityState(captureMeeting.ActivityState, PeekMeeting.\u206A⁬‏⁭‌​‎‬‍​‭⁮‮‭‌‭‮‪‪‎‎‬⁪‍⁮⁬⁮⁭⁮‍⁭‪‬‏‏⁪‫‏‫⁪‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4293081832U), (object) captureMeeting.ActivityState));
            num1 = (int) num3 * -16029332 ^ -1553986501;
            continue;
          case 3:
            int num4 = (int) this.ExecuteSubActivity((ActivityBase) captureMeeting, true);
            num1 = (int) num3 * -1209647465 ^ -574335976;
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

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = -2031924094;
      while (true)
      {
        int num2 = -558161397;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * -969049868 ^ 1631512595;
            continue;
          case 1:
            num1 = (int) num3 * -211293868 ^ -2018862388;
            continue;
          case 2:
            int num4;
            num1 = num4 = this.ExecuteJoinMeeting() != MeetingStatus.Attending ? -365465965 : (num4 = -1374360942);
            continue;
          case 3:
            this.ExecuteCaptureMeeting();
            num1 = (int) num3 * 1282163602 ^ -2012996380;
            continue;
          case 4:
            num1 = (int) num3 * 2026068393 ^ -2145555091;
            continue;
          case 5:
            this.Meeting.SuspendMeetingActivities = true;
            num1 = (int) num3 * -446210759 ^ -2077146245;
            continue;
          case 6:
            goto label_1;
          case 7:
            goto label_3;
          case 8:
            this.SetActivityState(ActivityState.Completed, PeekMeeting.\u206A⁬‏⁭‌​‎‬‍​‭⁮‮‭‌‭‮‪‪‎‎‬⁪‍⁮⁬⁮⁭⁮‍⁭‪‬‏‏⁪‫‏‫⁪‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1517511982U), (object) this.MeetingStatus));
            num1 = -106556830;
            continue;
          case 9:
            num1 = (int) num3 * -1487953071 ^ -1769047635;
            continue;
          case 10:
            int num5 = this.PeekOptions.SuspendInitialMeetingActivities ? -202181277 : (num5 = -44606820);
            int num6 = (int) num3 * 1413198676;
            num1 = num5 ^ num6;
            continue;
          case 11:
            num1 = (int) num3 * -878221761 ^ -1582289302;
            continue;
          case 12:
            this.StartingSuspendMeetingActivitiesValue = this.Meeting.SuspendMeetingActivities;
            num1 = (int) num3 * -1811958375 ^ 1755356092;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 1733476272;
      bool flag;
      while (true)
      {
        int num2 = 1053982223;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1753699597 ^ -1348170722;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag = true;
            num1 = (int) num3 * 689154199 ^ 615159666;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    static string \u206A⁬‏⁭‌​‎‬‍​‭⁮‮‭‌‭‮‪‪‎‎‬⁪‍⁮⁬⁮⁭⁮‍⁭‪‬‏‏⁪‫‏‫⁪‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }
  }
}
