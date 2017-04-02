// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.FakeAnnounce
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Activities
{
  public class FakeAnnounce : ActivityBase
  {
    private string announcementText = "";
    private string targetUserName = string.Empty;
    private string targetMeetingId = string.Empty;
    private ZoomUser targetUser = (ZoomUser) null;
    private ZoomMeeting targetMeeting = (ZoomMeeting) null;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 353855408;
        TraceType traceType;
        while (true)
        {
          int num2 = 1256312755;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1860223480 ^ -1026372730;
              continue;
            case 2:
              goto label_1;
            case 3:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -260802709 ^ -394444834;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public string AnnouncementText
    {
      get
      {
label_1:
        int num1 = 261811156;
        string announcementText;
        while (true)
        {
          int num2 = 431765665;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              announcementText = this.announcementText;
              num1 = (int) num3 * -2003058512 ^ -1517052133;
              continue;
            case 2:
              num1 = (int) num3 * 1081716707 ^ 1996945271;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return announcementText;
      }
      set
      {
label_1:
        int num1 = 582107383;
        while (true)
        {
          int num2 = 1797602;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.announcementText = value;
              num1 = (int) num3 * -940753666 ^ 1205950390;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1310304651U));
              num1 = (int) num3 * -37141336 ^ 172469093;
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

    public ZoomUser TargetUser
    {
      get
      {
label_1:
        int num1 = -1930295541;
        ZoomUser targetUser;
        while (true)
        {
          int num2 = -823487958;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 162700125 ^ -172180103;
              continue;
            case 1:
              targetUser = this.targetUser;
              num1 = (int) num3 * 881454267 ^ -912941335;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return targetUser;
      }
      set
      {
        this.targetUser = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3921418270U));
label_1:
        int num1 = 1669877848;
        while (true)
        {
          int num2 = 1187694874;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 1247897499 ^ -189702326;
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

    public ZoomMeeting TargetMeeting
    {
      get
      {
label_1:
        int num1 = -1889069500;
        ZoomMeeting targetMeeting;
        while (true)
        {
          int num2 = -998167077;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              targetMeeting = this.targetMeeting;
              num1 = (int) num3 * 1366018756 ^ -1565396662;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return targetMeeting;
      }
      set
      {
        this.targetMeeting = value;
label_1:
        int num1 = -387498216;
        while (true)
        {
          int num2 = -1643370611;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 673005959 ^ 395952419;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2406448230U));
              num1 = (int) num3 * -1132764497 ^ 1340454678;
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

    public string TargetUserName
    {
      get
      {
        string targetUserName = this.targetUserName;
label_1:
        int num1 = -2021508423;
        while (true)
        {
          int num2 = -922159848;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 841793336 ^ 1593722968;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return targetUserName;
      }
      set
      {
label_1:
        int num1 = -1580770351;
        while (true)
        {
          int num2 = -1647843698;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(420684578U));
              num1 = (int) num3 * -268877101 ^ 17522131;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.targetUserName = value;
              num1 = (int) num3 * 2115703152 ^ -1736092446;
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

    public string TargetMeetingId
    {
      get
      {
label_1:
        int num1 = 293160011;
        string targetMeetingId;
        while (true)
        {
          int num2 = 1915883729;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              targetMeetingId = this.targetMeetingId;
              num1 = (int) num3 * 1111729633 ^ -1108315875;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return targetMeetingId;
      }
      set
      {
        this.targetMeetingId = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2482697784U));
      }
    }

    public FakeAnnounce()
    {
label_1:
      int num1 = -990977447;
      while (true)
      {
        int num2 = -671246187;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this.Options.MinimizeEngineView = false;
            num1 = (int) num3 * -964977945 ^ -987133236;
            continue;
          case 1:
            this.Options.SaveAfterCapture = false;
            num1 = (int) num3 * -78455452 ^ 1986109289;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            this.Options.DisplayAfterCapture = false;
            num1 = (int) num3 * -537412071 ^ -686422998;
            continue;
          case 5:
            num1 = (int) num3 * -896613006 ^ -935986805;
            continue;
          case 6:
            num1 = (int) num3 * -993489785 ^ 220631053;
            continue;
          case 7:
            this.Options.DisableApplyLayout = false;
            num1 = (int) num3 * -777215487 ^ -673712806;
            continue;
          case 8:
            num1 = (int) num3 * 1546962111 ^ -449892169;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    protected override void ExecuteLogic()
    {
      string currentName = this.Engine.CurrentName;
      try
      {
        if (this.TargetUser != null)
          goto label_29;
label_2:
        int num1 = 138723057;
label_3:
        while (true)
        {
          int num2 = 1359723763;
          uint num3;
          bool isValid;
          JoinMeeting joinMeeting;
          bool flag1;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 33U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 259464882 ^ -404344150;
              continue;
            case 2:
              if (this.TargetMeeting != null)
              {
                num4 = 0;
                break;
              }
              num1 = 1182937731;
              continue;
            case 3:
              num1 = (int) num3 * -1348893715 ^ 2002928155;
              continue;
            case 4:
              this.Engine.KillZoomProcesses();
              num1 = (int) num3 * 957529439 ^ 1515492350;
              continue;
            case 5:
              num1 = (int) num3 * 1029924127 ^ -14768185;
              continue;
            case 6:
              num1 = 1093098838;
              continue;
            case 7:
              num1 = (int) num3 * 1461596617 ^ 1544069050;
              continue;
            case 8:
              this.Engine.ZoomDatabase.RestoreLogin();
              num1 = 1292473229;
              continue;
            case 9:
              num1 = (int) num3 * 1028609142 ^ -1656068941;
              continue;
            case 10:
              this.TargetMeeting.SuspendMeetingActivities = true;
              num1 = (int) num3 * 1400041932 ^ -1135334827;
              continue;
            case 11:
              this.TargetUser = this.Engine.GetUser(this.TargetUserName, true);
              num1 = (int) num3 * -1497758926 ^ -1720702694;
              continue;
            case 12:
              flag2 = this.ExecuteSubActivity((ActivityBase) new SendChat(this.AnnouncementText, ""), true) == ActivityState.Completed;
              num1 = (int) num3 * -720925202 ^ 830131605;
              continue;
            case 13:
              this.Engine.ZoomDatabase.Logout(true);
              num1 = (int) num3 * 892683995 ^ -43901110;
              continue;
            case 14:
              this.TargetMeeting = this.Engine.GetMeeting(this.TargetMeetingId, true);
              num1 = (int) num3 * -716351584 ^ -1845021353;
              continue;
            case 15:
              int num5 = isValid ? 202290693 : (num5 = 1449892771);
              int num6 = (int) num3 * -1962535308;
              num1 = num5 ^ num6;
              continue;
            case 16:
              num1 = (int) num3 * -1437468855 ^ 761616428;
              continue;
            case 17:
              int num7 = flag1 ? -66472696 : (num7 = -1680752909);
              int num8 = (int) num3 * -177353220;
              num1 = num7 ^ num8;
              continue;
            case 19:
              int num9 = (int) this.ExecuteSubActivity((ActivityBase) new LeaveMeeting(), true);
              num1 = 1090581234;
              continue;
            case 20:
              num1 = (int) num3 * 5756456 ^ -1062614122;
              continue;
            case 21:
              isValid = this.IsValid;
              num1 = 1064394506;
              continue;
            case 22:
              int num10 = !flag2 ? -1327626567 : (num10 = -1430284406);
              int num11 = (int) num3 * 1046890383;
              num1 = num10 ^ num11;
              continue;
            case 23:
              num1 = (int) num3 * -2139330349 ^ -952449631;
              continue;
            case 24:
              num1 = (int) num3 * -618722864 ^ 952267409;
              continue;
            case 25:
              this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2426570520U));
              num1 = (int) num3 * -2084965183 ^ 1466191773;
              continue;
            case 26:
              this.Engine.ZoomDatabase.SetZoomUserNameForJoin(this.TargetUser.UserName, true);
              num1 = (int) num3 * 1045261301 ^ -410096885;
              continue;
            case 27:
              num4 = !FakeAnnounce.\u206D⁬⁯‎‌⁭⁫⁪⁪‬‌⁪‫⁯⁬‬⁭⁯⁪⁪⁬‏⁭‫‭‬‌⁭⁯‪‬⁪⁪⁯‬⁯‭‮‬‫‮(this.TargetMeetingId) ? 1 : 0;
              break;
            case 28:
              joinMeeting = new JoinMeeting(this.TargetMeeting.MeetingId);
              num1 = (int) num3 * 836331870 ^ -1487677874;
              continue;
            case 29:
              this.TargetMeeting.SuspendMeetingActivities = false;
              num1 = (int) num3 * 67120846 ^ -1361863772;
              continue;
            case 30:
              num1 = (int) num3 * -679886679 ^ 1143692996;
              continue;
            case 31:
              goto label_28;
            case 32:
              int num12 = this.ExecuteSubActivity((ActivityBase) joinMeeting, true) == ActivityState.Completed ? 969724331 : (num12 = 1931955401);
              int num13 = (int) num3 * -1016091154;
              num1 = num12 ^ num13;
              continue;
            default:
              goto label_48;
          }
          flag1 = num4 != 0;
          num1 = 1234485177;
        }
label_28:
        int num14 = !FakeAnnounce.\u206D⁬⁯‎‌⁭⁫⁪⁪‬‌⁪‫⁯⁬‬⁭⁯⁪⁪⁬‏⁭‫‭‬‌⁭⁯‪‬⁪⁪⁯‬⁯‭‮‬‫‮(this.TargetUserName) ? 1 : 0;
        goto label_30;
label_29:
        num14 = 0;
label_30:
        num1 = num14 != 0 ? 1507282594 : (num1 = 2141745096);
        goto label_3;
      }
      catch (Exception ex)
      {
label_41:
        int num1 = 207347983;
        while (true)
        {
          int num2 = 1359723763;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_41;
            case 1:
              num1 = (int) num3 * 1963222833 ^ -1739258509;
              continue;
            case 2:
              num1 = (int) num3 * -356036540 ^ 781419162;
              continue;
            case 3:
              FakeAnnounce.\u206F‭⁪‮‬‮‮‎‪‫‏⁪‌​‭⁫‫‏‬‫‭‮‎⁮⁬⁭⁬‍​‫⁭‌‎‪⁫⁪⁪‮⁯⁯‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -150826685 ^ -599000216;
              continue;
            case 4:
              this.SetActivityState(ActivityState.Error, FakeAnnounce.\u202A‫‎‎‌‎⁯‪‍‬⁬​⁮‭⁯‪⁭⁪⁭⁭‭‎‫‭⁪‎‫⁬‌‎‬⁫‎⁯⁫⁬‍⁬‪‌‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2506275585U), FakeAnnounce.\u202C‏‍​‮​‮⁭⁪‪⁪​⁮‏‍​‎⁮⁪‮‏‫⁬⁯⁬⁫‮⁪‫⁪⁮​⁯⁭‭‎⁭‏‫‍‮(ex)));
              num1 = (int) num3 * -958402719 ^ 2068001648;
              continue;
            default:
              goto label_48;
          }
        }
      }
label_48:
      bool flag = FakeAnnounce.\u206E‭‍‎​⁪⁮⁪‎⁮​‭​⁬⁯⁫⁪⁪⁫⁮‍‭⁫⁮‎‪⁪⁫⁭⁬⁪⁮​‍​⁫‮‬⁬⁭‮(this.Engine.CurrentName, currentName);
label_49:
      int num15 = 2092199383;
      while (true)
      {
        int num1 = 1359723763;
        uint num2;
        switch ((num2 = (uint) (num15 ^ num1)) % 6U)
        {
          case 0:
            num15 = (int) num2 * 867965115 ^ -1866549736;
            continue;
          case 1:
            goto label_51;
          case 2:
            goto label_49;
          case 3:
            this.Engine.ZoomDatabase.SetZoomUserNameForJoin(currentName, true);
            num15 = (int) num2 * -1616885957 ^ -892135715;
            continue;
          case 4:
            int num3 = !flag ? -1430865032 : (num3 = -1986454871);
            int num4 = (int) num2 * 1546071320;
            num15 = num3 ^ num4;
            continue;
          case 5:
            num15 = (int) num2 * -242910290 ^ 1307361510;
            continue;
          default:
            goto label_47;
        }
      }
label_47:
      return;
label_51:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 827047860;
      bool flag;
      while (true)
      {
        int num2 = 1078003014;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            int num5;
            num1 = num5 = this.TargetMeeting == null ? 1841868629 : (num5 = 1936191024);
            continue;
          case 1:
            if (!FakeAnnounce.\u206D⁬⁯‎‌⁭⁫⁪⁪‬‌⁪‫⁯⁬‬⁭⁯⁪⁪⁬‏⁭‫‭‬‌⁭⁯‪‬⁪⁪⁯‬⁯‭‮‬‫‮(this.TargetUserName))
            {
              num1 = (int) num3 * -1566313196 ^ 418585602;
              continue;
            }
            break;
          case 2:
            int num6 = this.TargetUser != null ? -595855342 : (num6 = -1606930389);
            int num7 = (int) num3 * 255629922;
            num1 = num6 ^ num7;
            continue;
          case 3:
            flag = false;
            num1 = (int) num3 * -389216119 ^ 535282212;
            continue;
          case 5:
            num1 = (int) num3 * 1935496633 ^ 1711327;
            continue;
          case 6:
            flag = true;
            num1 = (int) num3 * -237072834 ^ 1681114385;
            continue;
          case 7:
            num1 = (int) num3 * -10404807 ^ 321856565;
            continue;
          case 8:
            num1 = 1078075557;
            continue;
          case 9:
            goto label_1;
          case 10:
            num4 = !FakeAnnounce.\u206D⁬⁯‎‌⁭⁫⁪⁪‬‌⁪‫⁯⁬‬⁭⁯⁪⁪⁬‏⁭‫‭‬‌⁭⁯‪‬⁪⁪⁯‬⁯‭‮‬‫‮(this.AnnouncementText) ? 1 : 0;
            goto label_9;
          case 11:
            if (!FakeAnnounce.\u206D⁬⁯‎‌⁭⁫⁪⁪‬‌⁪‫⁯⁬‬⁭⁯⁪⁪⁬‏⁭‫‭‬‌⁭⁯‪‬⁪⁪⁯‬⁯‭‮‬‫‮(this.TargetMeetingId))
            {
              num1 = (int) num3 * -2125850730 ^ -1173835246;
              continue;
            }
            break;
          default:
            goto label_17;
        }
        num4 = 0;
label_9:
        int num8;
        num1 = num8 = num4 != 0 ? 1457517368 : (num8 = 1379564334);
      }
label_17:
      return flag;
    }

    static bool \u206D⁬⁯‎‌⁭⁫⁪⁪‬‌⁪‫⁯⁬‬⁭⁯⁪⁪⁬‏⁭‫‭‬‌⁭⁯‪‬⁪⁪⁯‬⁯‭‮‬‫‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static void \u206F‭⁪‮‬‮‮‎‪‫‏⁪‌​‭⁫‫‏‬‫‭‮‎⁮⁬⁭⁬‍​‫⁭‌‎‪⁫⁪⁪‮⁯⁯‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static string \u202C‏‍​‮​‮⁭⁪‪⁪​⁮‏‍​‎⁮⁪‮‏‫⁬⁯⁬⁫‮⁪‫⁪⁮​⁯⁭‭‎⁭‏‫‍‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u202A‫‎‎‌‎⁯‪‍‬⁬​⁮‭⁯‪⁭⁪⁭⁭‭‎‫‭⁪‎‫⁬‌‎‬⁫‎⁯⁫⁬‍⁬‪‌‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static bool \u206E‭‍‎​⁪⁮⁪‎⁮​‭​⁬⁯⁫⁪⁪⁫⁮‍‭⁫⁮‎‪⁪⁫⁭⁬⁪⁮​‍​⁫‮‬⁬⁭‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }
  }
}
