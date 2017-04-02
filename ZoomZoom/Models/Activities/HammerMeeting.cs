// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.HammerMeeting
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom.Models.Activities
{
  public class HammerMeeting : ActivityBase
  {
    private string meetingId = string.Empty;
    protected int waitDurationSeconds = 10;
    protected int timesTried = 0;
    protected MeetingStatus meetingStatus = MeetingStatus.Unknown;
    private ZoomMeeting meeting;

    public MeetingStatus MeetingStatus
    {
      get
      {
        return this.meetingStatus;
      }
      set
      {
        this.meetingStatus = value;
      }
    }

    protected string MeetingId
    {
      get
      {
label_1:
        int num1 = 178816139;
        string meetingId;
        while (true)
        {
          int num2 = 1031542524;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meetingId = this.meetingId;
              num1 = (int) num3 * -1069973742 ^ 910732485;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingId;
      }
      set
      {
        this.meetingId = value;
      }
    }

    public ZoomMeeting Meeting
    {
      get
      {
        return this.meeting;
      }
      set
      {
label_1:
        int num1 = -1351241899;
        while (true)
        {
          int num2 = -1723370733;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.meeting = value;
              num1 = (int) num3 * 998642848 ^ -1372971351;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 726529280;
        TraceType traceType;
        while (true)
        {
          int num2 = 367549073;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1969258546 ^ -1753988562;
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

    public HammerMeeting(string meetingId)
    {
label_1:
      int num1 = -903432357;
      while (true)
      {
        int num2 = -1987170570;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1865578519 ^ -1034930771;
            continue;
          case 1:
            this.MeetingId = meetingId;
            num1 = (int) num3 * -592682126 ^ -910732524;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      this.RequiresAuthorization = true;
    }

    public HammerMeeting(ZoomMeeting meeting)
    {
label_1:
      int num1 = 570358387;
      while (true)
      {
        int num2 = 1476390954;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -2111208285 ^ -949753277;
            continue;
          case 2:
            num1 = (int) num3 * -850837632 ^ -1161590706;
            continue;
          case 3:
            this.RequiresAuthorization = true;
            num1 = (int) num3 * 1208290474 ^ 1031894531;
            continue;
          case 4:
            this.MeetingId = meeting.MeetingId;
            num1 = (int) num3 * 186203593 ^ -741243197;
            continue;
          case 5:
            this.Meeting = meeting;
            num1 = (int) num3 * -630101444 ^ 1537851325;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -825927702 ^ 1897715268;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    public override string ToString()
    {
      return HammerMeeting.\u202B⁯‮​⁫‍‏⁯‎‭‫​⁫⁮‭‫‮⁪⁯⁯⁮‭‌⁮⁭⁯​⁪‏​⁯‭⁬⁫⁯‪⁫​⁬⁯‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3023992516U), (object) this.MeetingId, (object) (this.timesTried + 1));
    }

    public ActivityState Hammer()
    {
label_69:
      bool flag1 = this.ContinueExecution();
      int num1 = -1701967320;
      ActivityState activityState;
      while (true)
      {
        int num2 = -1091218568;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -1808974005 ^ -102419435;
            continue;
          case 1:
            activityState = this.ActivityState;
            num1 = (int) num3 * -895149321 ^ -1863827649;
            continue;
          case 2:
label_70:
            this.ReportProgress(HammerMeeting.\u202B⁯‮​⁫‍‏⁯‎‭‫​⁫⁮‭‫‮⁪⁯⁯⁮‭‌⁮⁭⁯​⁪‏​⁯‭⁬⁫⁯‪⁫​⁬⁯‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3533555346U), (object) this.MeetingId, (object) this.MeetingStatus), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(46240467U));
            num1 = -1477311501;
            continue;
          case 4:
            if (flag1)
            {
              try
              {
label_2:
                int num4 = -1867743527;
                JoinMeeting joinMeeting1;
                object activityLocker1;
                while (true)
                {
                  int num5 = -1091218568;
                  uint num6;
                  switch ((num6 = (uint) (num4 ^ num5)) % 6U)
                  {
                    case 0:
                      HammerMeeting.\u200F‬⁮⁫‌⁮‫⁯⁮‬‪‭‎⁪⁮‌⁮⁭‫‏‍⁬⁫‪‪‬‍‮⁭‬‍⁯⁯‏⁯​⁪⁮‫‏‮(CoreObject.log, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4266851340U), new object[0]);
                      num4 = (int) num6 * 71510343 ^ -1877759082;
                      continue;
                    case 2:
                      int num7 = (int) this.ExecuteSubActivity((ActivityBase) joinMeeting1, true);
                      activityLocker1 = ActivityBase.activityLocker;
                      num4 = (int) num6 * 1636112061 ^ 1768534997;
                      continue;
                    case 3:
                      goto label_2;
                    case 4:
                      JoinMeeting joinMeeting2 = new JoinMeeting(this.MeetingId);
                      ActivityOptions activityOptions = new ActivityOptions();
                      joinMeeting2.Options = activityOptions;
                      joinMeeting1 = joinMeeting2;
                      joinMeeting1.Options.SuppressProgressReports = true;
                      num4 = (int) num6 * -436753848 ^ -1415666406;
                      continue;
                    case 5:
                      if (this.Engine.ActiveMeeting == null)
                      {
                        num4 = (int) num6 * 1320503474 ^ 878211364;
                        continue;
                      }
                      goto label_38;
                    default:
                      goto label_9;
                  }
                }
label_9:
                bool flag2 = false;
                try
                {
                  HammerMeeting.\u206E‌‪⁫‍⁬‮‭‍⁭‎⁪⁯⁫⁭‍‭⁬‭⁬⁭‪​⁭⁬⁭⁭‪‍‪⁪‏‬‎⁪⁬‌⁭​‎‮(activityLocker1, ref flag2);
label_11:
                  int num5 = -1009452769;
                  while (true)
                  {
                    int num6 = -1091218568;
                    uint num7;
                    switch ((num7 = (uint) (num5 ^ num6)) % 3U)
                    {
                      case 0:
                        goto label_11;
                      case 2:
                        this.Status = joinMeeting1.Status;
                        num5 = (int) num7 * -1536395795 ^ -2108265688;
                        continue;
                      default:
                        goto label_14;
                    }
                  }
label_14:
                  this.MeetingStatus = joinMeeting1.MeetingStatus;
                }
                finally
                {
                  if (flag2)
                  {
label_16:
                    int num5 = -1225439223;
                    while (true)
                    {
                      int num6 = -1091218568;
                      uint num7;
                      switch ((num7 = (uint) (num5 ^ num6)) % 3U)
                      {
                        case 0:
                          goto label_16;
                        case 1:
                          HammerMeeting.\u200C‏‎⁭⁯‌⁭‎⁪‮‬‌⁮‪⁪‍⁬‪⁯⁫⁯⁮⁫‭‬‪‮⁬⁪​​‭‏‫⁪‌⁯‎⁫‍‮(activityLocker1);
                          num5 = (int) num7 * 268096835 ^ 195065992;
                          continue;
                        default:
                          goto label_19;
                      }
                    }
                  }
label_19:;
                }
                MeetingStatus meetingStatus = this.MeetingStatus;
label_21:
                int num8 = -1734087353;
label_22:
                object activityLocker2;
                while (true)
                {
                  int num5 = -1091218568;
                  uint num6;
                  bool flag3;
                  switch ((num6 = (uint) (num8 ^ num5)) % 19U)
                  {
                    case 0:
                      this.SetActivityState(ActivityState.Completed, "");
                      num8 = (int) num6 * -2019080901 ^ 1505126027;
                      continue;
                    case 1:
                      this.SetActivityState(ActivityState.InProgress, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3847149496U));
                      num8 = (int) num6 * 1366362207 ^ -71109009;
                      continue;
                    case 2:
                      num8 = -247880085;
                      continue;
                    case 3:
                      flag3 = this.ActivityState == ActivityState.Error;
                      num8 = -96310031;
                      continue;
                    case 4:
                      goto label_38;
                    case 5:
                      int num7 = !flag3 ? -2128934281 : (num7 = -871603268);
                      int num9 = (int) num6 * -1454926258;
                      num8 = num7 ^ num9;
                      continue;
                    case 6:
                      num8 = (int) num6 * -261964762 ^ -1767279241;
                      continue;
                    case 7:
                      goto label_70;
                    case 8:
                      this.Status = joinMeeting1.Status;
                      num8 = (int) num6 * 1350024597 ^ 825194885;
                      continue;
                    case 9:
                      num8 = (int) num6 * 1976424214 ^ -1979958741;
                      continue;
                    case 10:
label_34:
                      this.ReportProgress(HammerMeeting.\u206B⁪‭‏⁪‫‫⁪​‍‍‫‭‏‬‬‫‪⁬‎⁬⁮‬⁬‏‌‎‫⁯‏‭⁬‬‮⁮‎⁫⁪⁪‌‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1314762352U), (object) this.MeetingStatus), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(711393104U));
                      num8 = -237599814;
                      continue;
                    case 11:
                      goto label_21;
                    case 12:
                      num8 = (int) num6 * -2123805537 ^ 1315816936;
                      continue;
                    case 13:
                      num8 = (int) num6 * -885225167 ^ -1386739168;
                      continue;
                    case 14:
                      activityLocker2 = ActivityBase.activityLocker;
                      num8 = (int) num6 * 499178308 ^ 209545045;
                      continue;
                    case 16:
                      goto label_53;
                    case 17:
label_35:
                      this.ReportProgress(HammerMeeting.\u206D⁪⁮‬⁭‮​​‬​⁭‍‪⁪‎‭‪‬‬‮‫⁮‍‏‌‪‏‌​‌‮‬⁮​⁭‭‭‬‍⁬‮((object) this.MeetingStatus, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(298389862U)), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(711393104U));
                      num8 = -388630195;
                      continue;
                    case 18:
                      switch (meetingStatus)
                      {
                        case MeetingStatus.Unknown:
                        case MeetingStatus.Joining:
                        case MeetingStatus.Leaving:
                        case MeetingStatus.Hold:
                        case MeetingStatus.WaitingForHost:
                        case MeetingStatus.Full:
                        case MeetingStatus.NotAttending:
                        case MeetingStatus.Locked:
                          goto label_34;
                        case MeetingStatus.Attending:
                        case MeetingStatus.Invalid:
                        case MeetingStatus.Password:
                        case MeetingStatus.Error:
                          goto label_35;
                        default:
                          num8 = (int) num6 * 1355339163 ^ 2102366632;
                          continue;
                      }
                    default:
                      goto label_39;
                  }
                }
label_39:
                bool flag4 = false;
                try
                {
                  HammerMeeting.\u206E‌‪⁫‍⁬‮‭‍⁭‎⁪⁯⁫⁭‍‭⁬‭⁬⁭‪​⁭⁬⁭⁭‪‍‪⁪‏‬‎⁪⁬‌⁭​‎‮(activityLocker2, ref flag4);
label_41:
                  int num5 = -1746317992;
                  while (true)
                  {
                    int num6 = -1091218568;
                    uint num7;
                    switch ((num7 = (uint) (num5 ^ num6)) % 5U)
                    {
                      case 0:
                        this.Status = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2524572053U);
                        num5 = (int) num7 * 2144832410 ^ -1097466501;
                        continue;
                      case 1:
                        num5 = (int) num7 * -1764936929 ^ -1804952923;
                        continue;
                      case 2:
                        num5 = (int) num7 * 1979283830 ^ -1726159317;
                        continue;
                      case 4:
                        goto label_41;
                      default:
                        goto label_46;
                    }
                  }
label_46:
                  this.MeetingStatus = MeetingStatus.Attending;
                }
                finally
                {
                  if (flag4)
                  {
label_48:
                    int num5 = -603074381;
                    while (true)
                    {
                      int num6 = -1091218568;
                      uint num7;
                      switch ((num7 = (uint) (num5 ^ num6)) % 4U)
                      {
                        case 0:
                          goto label_48;
                        case 2:
                          num5 = (int) num7 * 1389115406 ^ 129327761;
                          continue;
                        case 3:
                          HammerMeeting.\u200C‏‎⁭⁯‌⁭‎⁪‮‬‌⁮‪⁪‍⁬‪⁯⁫⁯⁮⁫‭‬‪‮⁬⁪​​‭‏‫⁪‌⁯‎⁫‍‮(activityLocker2);
                          num5 = (int) num7 * 43070910 ^ -1722513064;
                          continue;
                        default:
                          goto label_52;
                      }
                    }
                  }
label_52:;
                }
label_53:
                this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2524572053U));
                goto label_62;
label_38:
                this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2524572053U));
                num8 = -1817797536;
                goto label_22;
              }
              catch (Exception ex)
              {
label_55:
                int num4 = -1516805753;
                while (true)
                {
                  int num5 = -1091218568;
                  uint num6;
                  switch ((num6 = (uint) (num4 ^ num5)) % 6U)
                  {
                    case 0:
                      this.HandleException(ex);
                      num4 = (int) num6 * 533936870 ^ 29199551;
                      continue;
                    case 1:
                      num4 = (int) num6 * 1898171722 ^ -1850161942;
                      continue;
                    case 3:
                      goto label_55;
                    case 4:
                      num4 = (int) num6 * -298769566 ^ -1439667882;
                      continue;
                    case 5:
                      num4 = (int) num6 * -41240828 ^ 1223987420;
                      continue;
                    default:
                      goto label_62;
                  }
                }
              }
              finally
              {
              }
label_62:
              goto case 5;
            }
            else
            {
              num1 = (int) num3 * -1269073262 ^ 1452007523;
              continue;
            }
          case 5:
            num1 = -1332303721;
            continue;
          case 6:
            goto label_69;
          default:
            goto label_71;
        }
      }
label_71:
      return activityState;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 816602858;
      bool flag;
      while (true)
      {
        int num2 = 134262984;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = true;
            num1 = (int) num3 * -1531970744 ^ 2034912338;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = -1373917607;
      object activityLocker;
      while (true)
      {
        int num2 = -1034019521;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * 225964534 ^ -79935181;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        HammerMeeting.\u206E‌‪⁫‍⁬‮‭‍⁭‎⁪⁯⁫⁭‍‭⁬‭⁬⁭‪​⁭⁬⁭⁭‪‍‪⁪‏‬‎⁪⁬‌⁭​‎‮(activityLocker, ref flag);
        ActivityBase.endTime = DateTime.MaxValue;
        this.meetingStatus = MeetingStatus.Joining;
      }
      finally
      {
        if (flag)
        {
label_7:
          int num2 = -341217938;
          while (true)
          {
            int num3 = -1034019521;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                HammerMeeting.\u200C‏‎⁭⁯‌⁭‎⁪‮‬‌⁮‪⁪‍⁬‪⁯⁫⁯⁮⁫‭‬‪‮⁬⁪​​‭‏‫⁪‌⁯‎⁫‍‮(activityLocker);
                num2 = (int) num4 * 326464665 ^ 1085797552;
                continue;
              case 2:
                num2 = (int) num4 * -496613697 ^ 360470913;
                continue;
              case 3:
                goto label_7;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
      int num5 = (int) this.Hammer();
    }

    static string \u202B⁯‮​⁫‍‏⁯‎‭‫​⁫⁮‭‫‮⁪⁯⁯⁮‭‌⁮⁭⁯​⁪‏​⁯‭⁬⁫⁯‪⁫​⁬⁯‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static void \u200F‬⁮⁫‌⁮‫⁯⁮‬‪‭‎⁪⁮‌⁮⁭‫‏‍⁬⁫‪‪‬‍‮⁭‬‍⁯⁯‏⁯​⁪⁮‫‏‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u206E‌‪⁫‍⁬‮‭‍⁭‎⁪⁯⁫⁭‍‭⁬‭⁬⁭‪​⁭⁬⁭⁭‪‍‪⁪‏‬‎⁪⁬‌⁭​‎‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200C‏‎⁭⁯‌⁭‎⁪‮‬‌⁮‪⁪‍⁬‪⁯⁫⁯⁮⁫‭‬‪‮⁬⁪​​‭‏‫⁪‌⁯‎⁫‍‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static string \u206D⁪⁮‬⁭‮​​‬​⁭‍‪⁪‎‭‪‬‬‮‫⁮‍‏‌‪‏‌​‌‮‬⁮​⁭‭‭‬‍⁬‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static string \u206B⁪‭‏⁪‫‫⁪​‍‍‫‭‏‬‬‫‪⁬‎⁬⁮‬⁬‏‌‎‫⁯‏‭⁬‬‮⁮‎⁫⁪⁪‌‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }
  }
}
