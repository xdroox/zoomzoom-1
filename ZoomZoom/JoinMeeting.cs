// Decompiled with JetBrains decompiler
// Type: ZoomZoom.JoinMeeting
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Utils;

namespace ZoomZoom
{
  public class JoinMeeting : ActivityBase
  {
    private string meetingId = string.Empty;
    protected int waitDurationSeconds = 60;
    protected MeetingStatus meetingStatus = MeetingStatus.Unknown;
    protected List<ZoomEvent> processedEvents = new List<ZoomEvent>();
    protected List<IntPtr> startingWindowHandles = new List<IntPtr>();
    protected bool leaveCurrentMeeting = false;
    private DateTime joinInitiated = DateTime.MinValue;
    private List<ZoomEvent> joinEvents = new List<ZoomEvent>();
    private DateTime lastEventDetected = DateTime.MinValue;
    private MeetingOptions meetingOptions;
    private bool NameChanged;

    public bool LeaveCurrentMeeting
    {
      get
      {
        return this.leaveCurrentMeeting;
      }
      set
      {
        object activityLocker = ActivityBase.activityLocker;
        bool flag = false;
        try
        {
          JoinMeeting.\u206E⁭‏‫⁫‮‎⁯⁬⁪‍⁬‬‏‍‫⁫⁮⁬⁮‫⁭‏‬‎⁬‏‍‏​⁭⁫⁪‏‬⁭⁮‎⁯⁯‮(activityLocker, ref flag);
label_2:
          int num1 = -466885623;
          while (true)
          {
            int num2 = -1345873018;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                this.leaveCurrentMeeting = value;
                num1 = (int) num3 * -670227423 ^ -480851556;
                continue;
              case 1:
                num1 = (int) num3 * -1240518540 ^ 1427373441;
                continue;
              case 2:
                goto label_2;
              case 3:
                num1 = (int) num3 * -830387232 ^ 1925106053;
                continue;
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
            int num1 = -148839008;
            while (true)
            {
              int num2 = -1345873018;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_9;
                case 2:
                  JoinMeeting.\u202D⁬⁮‪⁭⁬⁬‬⁪​⁯‬‌‍‌‌‏‬‌‮‫‍‪‪⁯‌⁪‪​‏‪⁫⁭⁪‎⁯‏‌‫⁭‮(activityLocker);
                  num1 = (int) num3 * 1388460687 ^ 1303121955;
                  continue;
                case 3:
                  num1 = (int) num3 * -2058224250 ^ -2114172651;
                  continue;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
      }
    }

    public new MeetingOptions MeetingOptions
    {
      get
      {
        MeetingOptions meetingOptions = this.meetingOptions;
label_1:
        int num1 = 653900070;
        while (true)
        {
          int num2 = 666230280;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1264738478 ^ -1156702679;
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
        this.meetingOptions = value;
label_1:
        int num1 = -269621224;
        while (true)
        {
          int num2 = -950801008;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3835575697U));
              num1 = (int) num3 * -966318866 ^ -1917419473;
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

    public MeetingStatus MeetingStatus
    {
      get
      {
        MeetingStatus meetingStatus = this.meetingStatus;
label_1:
        int num1 = 1998396309;
        while (true)
        {
          int num2 = 629071785;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 15912727 ^ -1032134167;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingStatus;
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
        int num1 = 891485123;
        string meetingId;
        while (true)
        {
          int num2 = 93094237;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingId = this.meetingId;
              num1 = (int) num3 * -16133126 ^ 795678961;
              continue;
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

    public DateTime JoinInitiated
    {
      get
      {
label_1:
        int num1 = -182885911;
        DateTime joinInitiated;
        while (true)
        {
          int num2 = -816633808;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1921573845 ^ 893869515;
              continue;
            case 1:
              joinInitiated = this.joinInitiated;
              num1 = (int) num3 * 1746552993 ^ -229901235;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return joinInitiated;
      }
      set
      {
        this.joinInitiated = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -301587641;
        TraceType traceType;
        while (true)
        {
          int num2 = -1582875547;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              traceType = TraceType.Activity;
              num1 = (int) num3 * 102765819 ^ -1854140025;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public List<ZoomEvent> JoinEvents
    {
      get
      {
        List<ZoomEvent> joinEvents = this.joinEvents;
label_1:
        int num1 = 257675401;
        while (true)
        {
          int num2 = 1019273997;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1125213324 ^ 1544465405;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return joinEvents;
      }
      set
      {
        this.joinEvents = value;
      }
    }

    public JoinMeeting(string meetingId)
    {
label_1:
      int num1 = -2101375787;
      while (true)
      {
        int num2 = -821508816;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            this.ActivityState = ActivityState.Pending;
            num1 = (int) num3 * 1258329648 ^ 554399201;
            continue;
          case 1:
            int num4 = flag ? 1262896252 : (num4 = 506241621);
            int num5 = (int) num3 * 1825658350;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.MeetingId = JoinMeeting.\u202D‪‪‍‎‌‌​‫⁯‌‬‪⁯‬‎‭⁯⁯⁭⁭‌‪⁪​‏‍⁮‬‌⁫⁫‫⁪‫‭⁬⁮‮⁬‮(JoinMeeting.\u202D‪‪‍‎‌‌​‫⁯‌‬‪⁯‬‎‭⁯⁯⁭⁭‌‪⁪​‏‍⁮‬‌⁫⁫‫⁪‫‭⁬⁮‮⁬‮(meetingId, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3518570259U), ""), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2691421578U), "");
            num1 = -1629990294;
            continue;
          case 4:
            num1 = (int) num3 * 1567867272 ^ -1199612546;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * -570799060 ^ 1630423315;
            continue;
          case 7:
            flag = JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(meetingId, string.Empty);
            num1 = (int) num3 * 1971452492 ^ 1396833869;
            continue;
          case 8:
            meetingId = this.Engine.NextMeeting.MeetingId;
            num1 = (int) num3 * 1439917285 ^ -1747261404;
            continue;
          case 9:
            this.RequiresAuthorization = true;
            num1 = (int) num3 * 1319199241 ^ -1836077199;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    public JoinMeeting(ZoomMeeting meeting)
    {
label_1:
      int num1 = -549531391;
      while (true)
      {
        int num2 = -455203529;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this.RequiresAuthorization = true;
            num1 = (int) num3 * 812068137 ^ 1319453071;
            continue;
          case 1:
            num1 = (int) num3 * -1563893215 ^ 420888485;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 1244936422 ^ 1006012849;
            continue;
          case 4:
            num1 = (int) num3 * 427150488 ^ 321384954;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.MeetingId = meeting.MeetingId;
            this.ActivityState = ActivityState.Pending;
            num1 = (int) num3 * -700409076 ^ -174194700;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    public override string ToString()
    {
      return JoinMeeting.\u202A⁯⁫‍‬‬‪‮⁫⁪‫‫‬⁭⁭‏‮⁪⁮‎‬⁮‮‪⁯‫‭‏‎‍‎‎⁯⁮‍⁬⁬‮‎⁭‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4151294493U), (object) this.MeetingId);
    }

    protected override void ExecuteLogic()
    {
      try
      {
label_2:
        int num1 = -1925304823;
        while (true)
        {
          int num2 = -279128096;
          uint num3;
          ZoomWindow window;
          bool flag1;
          bool flag2;
          bool flag3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 22U)
          {
            case 0:
              num1 = (int) num3 * 1288219370 ^ 561261002;
              continue;
            case 1:
              this.RevertZoomIdentity();
              flag3 = this.MeetingStatus == MeetingStatus.Joining;
              num1 = (int) num3 * 674147682 ^ -1727542732;
              continue;
            case 3:
              int num5 = !flag2 ? -7247520 : (num5 = -600984645);
              int num6 = (int) num3 * 371494002;
              num1 = num5 ^ num6;
              continue;
            case 4:
              flag1 = !JoinMeeting.\u200E⁪⁭⁫‫‏‭⁫‮⁫⁪‭‌⁬‬⁪‫‭⁮‫⁪‍‌‎⁪‮‮⁯⁯⁬‬‭​⁯‬‌‍‍‎‎‮(ZoomZoom.Properties.Settings.Default.ForceMeeting);
              num1 = (int) num3 * -347222505 ^ 1331476648;
              continue;
            case 5:
              goto label_2;
            case 6:
              num1 = -1721162297;
              continue;
            case 7:
              window = this.Engine.GetWindow(ZoomWindowType.Meeting);
              num1 = (int) num3 * -1916879530 ^ 2012193914;
              continue;
            case 8:
              if (window != null)
              {
                num1 = (int) num3 * -1745276492 ^ 959786153;
                continue;
              }
              num4 = 0;
              break;
            case 9:
              this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3248076169U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1431255308U));
              num1 = (int) num3 * -303222545 ^ -607192543;
              continue;
            case 10:
              int num7 = flag3 ? -575516897 : (num7 = -479584529);
              int num8 = (int) num3 * -965144964;
              num1 = num7 ^ num8;
              continue;
            case 11:
              this.ActivityState = this.Join();
              num1 = -177067132;
              continue;
            case 12:
              int num9 = !flag1 ? 1798467791 : (num9 = 36555211);
              int num10 = (int) num3 * -1444290475;
              num1 = num9 ^ num10;
              continue;
            case 13:
              num4 = window.IsVisible ? 1 : 0;
              break;
            case 14:
              this.SetActivityState(this.ActivityState, JoinMeeting.\u206D‍‭⁯‏‪‏⁯‫‎⁬‍‏⁭‪‌‬⁪‫​⁯‏⁪⁯⁪​​⁬⁯⁮⁬⁯‌​​⁭‭⁪‬‏‮((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(195967697U), (object) this.MeetingStatus));
              num1 = (int) num3 * -1191457107 ^ 1452526329;
              continue;
            case 15:
              this.MeetingId = ZoomZoom.Properties.Settings.Default.ForceMeeting;
              num1 = (int) num3 * -423645227 ^ -846721473;
              continue;
            case 16:
              num1 = (int) num3 * -892381277 ^ -816286164;
              continue;
            case 17:
              num1 = -856628106;
              continue;
            case 18:
              num1 = (int) num3 * 442415875 ^ -1873664647;
              continue;
            case 19:
              this.Engine.SetMeetingStatus(this.MeetingId, this.MeetingStatus);
              num1 = (int) num3 * -711765814 ^ -1124891837;
              continue;
            case 20:
              this.SetJoinIdentity();
              num1 = (int) num3 * 1067498538 ^ -523092548;
              continue;
            case 21:
              this.SetJoinState(this.ActivityState, MeetingStatus.Attending, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4150900469U));
              num1 = (int) num3 * 1331777176 ^ -892107914;
              continue;
            default:
              goto label_34;
          }
          flag2 = num4 != 0;
          num1 = -775939653;
        }
      }
      catch (Exception ex)
      {
label_28:
        int num1 = -1248621945;
        while (true)
        {
          int num2 = -279128096;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -935039527 ^ 277614315;
              continue;
            case 1:
              JoinMeeting.\u200F‫‍⁭‭‭‭‪‎‪‫⁭⁯⁮⁬‍⁭⁭‍⁯​​‬⁪‪‮⁮⁬‏⁪‭⁬‮⁭‏⁬‫⁯⁮‍‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -729025841 ^ -1478694919;
              continue;
            case 2:
              goto label_28;
            case 4:
              this.SetActivityState(ActivityState.Error, JoinMeeting.\u202A‌‌⁭‪‍⁬‫‏‎‮⁭⁬⁭‌‫​‬​‭‬⁭⁮‏‬‎​⁮‮‬‎‌‮⁪‮‮⁭⁫‮⁯‮(ex));
              num1 = (int) num3 * -2004218789 ^ 1632008131;
              continue;
            case 5:
              num1 = (int) num3 * 1153753125 ^ -298113635;
              continue;
            default:
              goto label_34;
          }
        }
      }
label_34:
      JoinMeeting.\u200C⁯‬⁮⁬‍‪‌⁭‭‏⁯⁪‪‎⁮⁯‌‭‌‫‎‏‍‏‎‭‭‎‫⁭‫‎‌‮⁯⁮⁬‫⁯‮(CoreObject.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3617067230U));
    }

    private void RevertZoomIdentity()
    {
label_1:
      int num1 = 111747606;
      while (true)
      {
        int num2 = 1133122219;
        uint num3;
        bool nameChanged;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -1990596393 ^ 1024894936;
            continue;
          case 1:
            goto label_3;
          case 2:
            int num4 = nameChanged ? 1399750076 : (num4 = 778925890);
            int num5 = (int) num3 * 1003952185;
            num1 = num4 ^ num5;
            continue;
          case 3:
            this.RestoreUserName();
            num1 = (int) num3 * 992647218 ^ -213148155;
            continue;
          case 4:
            goto label_1;
          case 5:
            nameChanged = this.NameChanged;
            num1 = (int) num3 * -750973823 ^ -87427672;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void SetJoinIdentity()
    {
label_1:
      int num1 = 633398508;
      List<string> stringList;
      while (true)
      {
        int num2 = 1808116697;
        uint num3;
        bool joinDynamicUserName;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            if (flag)
            {
              num1 = (int) num3 * -778125469 ^ -801286140;
              continue;
            }
            goto label_35;
          case 1:
            flag = ((Collection<StringItem>) this.Engine.Settings.JoinUserNames).Count > 0;
            num1 = (int) num3 * -1378728032 ^ -345666828;
            continue;
          case 2:
            num1 = (int) num3 * -446272919 ^ 1472651929;
            continue;
          case 3:
            goto label_1;
          case 4:
            stringList = new List<string>();
            num1 = (int) num3 * 551923749 ^ 1439753759;
            continue;
          case 5:
            num1 = (int) num3 * -1263923607 ^ -2094996353;
            continue;
          case 7:
            num1 = (int) num3 * -1226454591 ^ 669029245;
            continue;
          case 8:
            joinDynamicUserName = this.Engine.Settings.JoinDynamicUserName;
            num1 = (int) num3 * -233521119 ^ -1910005881;
            continue;
          case 9:
            if (joinDynamicUserName)
            {
              num1 = (int) num3 * -436528088 ^ 1060952056;
              continue;
            }
            goto label_37;
          case 10:
            if (this.Engine.Settings.JoinDynamicUserName)
            {
              num1 = (int) num3 * -686937509 ^ 1926152107;
              continue;
            }
            goto label_34;
          default:
            goto label_15;
        }
      }
label_34:
      return;
label_15:
      IEnumerator<StringItem> enumerator = ((Collection<StringItem>) this.Engine.Settings.JoinUserNames).GetEnumerator();
      try
      {
label_20:
        int num2 = JoinMeeting.\u206C‭​‎⁯⁭⁯‍⁯⁬‌‪‎‫‏‫‭‮‎‭⁯⁮⁪‮‎⁭‏⁪‎‎‌​‪​‮‍‌‮‍‭‮((IEnumerator) enumerator) ? 869263048 : (num2 = 2099767433);
        while (true)
        {
          int num3 = 1808116697;
          uint num4;
          StringItem current;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = 869263048;
              continue;
            case 1:
              goto label_20;
            case 3:
              current = enumerator.Current;
              num2 = 2142047764;
              continue;
            case 4:
              stringList.Add(current.Value);
              num2 = (int) num4 * -694506390 ^ 360929608;
              continue;
            case 5:
              num2 = (int) num4 * 1166843480 ^ -231064873;
              continue;
            default:
              goto label_31;
          }
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_25:
          int num2 = 232005120;
          while (true)
          {
            int num3 = 1808116697;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_25;
              case 1:
                JoinMeeting.\u206B‌‪‍‏‍⁬‬‪‍⁭‌‪⁫⁬⁭⁮‌‏⁪‍‭‮​‍‬⁬⁬⁮‏⁯‎⁪⁮‍⁭‭⁫‭‭‮((IDisposable) enumerator);
                num2 = (int) num4 * 1040004688 ^ 1413951090;
                continue;
              case 3:
                num2 = (int) num4 * -629795436 ^ -1979907781;
                continue;
              default:
                goto label_30;
            }
          }
        }
label_30:;
      }
label_31:
      this.Options.UserNameList = stringList;
label_32:
      int num5 = 705282844;
label_33:
      while (true)
      {
        int num2 = 1808116697;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 7U)
        {
          case 0:
            num5 = (int) num3 * 1160606069 ^ -716399818;
            continue;
          case 1:
            this.ChangeUserName(this.Options.UserNameList, true);
            num5 = (int) num3 * 228482248 ^ -924099747;
            continue;
          case 2:
            goto label_27;
          case 3:
            goto label_37;
          case 4:
            num5 = (int) num3 * -1264037943 ^ -288479336;
            continue;
          case 5:
            goto label_35;
          case 6:
            goto label_32;
          default:
            goto label_23;
        }
      }
label_23:
      return;
label_27:
      return;
label_35:
      num5 = 1869458906;
      goto label_33;
label_37:
      num5 = 257207313;
      goto label_33;
    }

    internal ActivityState Join()
    {
label_1:
      int num1 = 115692344;
      MeetingStatus meetStatus;
      ActivityState state;
      while (true)
      {
        int num2 = 1455962845;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            meetStatus = MeetingStatus.Joining;
            num1 = (int) num3 * -1585302496 ^ 170854842;
            continue;
          case 2:
            goto label_1;
          case 3:
            state = ActivityState.InProgress;
            num1 = (int) num3 * 1493476797 ^ 185204598;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      string empty = string.Empty;
      try
      {
label_7:
        int num2 = 1023141629;
        while (true)
        {
          int num3 = 1455962845;
          uint num4;
          bool flag1;
          bool flag2;
          bool flag3;
          DateTime joinEndTime;
          bool flag4;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 35U)
          {
            case 1:
              num2 = (int) num4 * 1911512880 ^ 818572573;
              continue;
            case 2:
              this.ReportProgress(string.Format(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2655900637U), (object) this.MeetingId), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2325646536U));
              int num6 = (int) this.CheckJoinResults(joinEndTime);
              num2 = (int) num4 * -1121055640 ^ 362074873;
              continue;
            case 3:
              int num7 = !flag4 ? -1723976243 : (num7 = -1062579982);
              int num8 = (int) num4 * 1589308349;
              num2 = num7 ^ num8;
              continue;
            case 4:
              if (this.Engine.ActiveMeeting != null)
              {
                num2 = (int) num4 * 370622699 ^ -276635891;
                continue;
              }
              break;
            case 5:
              JoinMeeting.\u200F‬‭‭⁪⁮⁬‬⁪‭‭⁯‏⁮‎‪⁮‍⁮⁬‬⁬‪⁫⁮⁯‍‬‭⁮‍‮‭⁫‫⁪‏⁪‭‭‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1968295615U), new object[0]);
              num2 = (int) num4 * 380471183 ^ -1780612915;
              continue;
            case 6:
              this.ReportProgress(string.Format(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3814806276U), (object) this.MeetingStatus), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2676079492U));
              num2 = 2068377257;
              continue;
            case 7:
              this.StartJoin(this.MeetingId);
              num2 = (int) num4 * -1779612807 ^ 1409473930;
              continue;
            case 8:
              this.SetJoinState(ActivityState.Completed, MeetingStatus.NotAttending, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3617830699U));
              this.ReportProgress(string.Format(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(811259674U), (object) this.Engine.ActiveMeeting.MeetingId), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2676079492U));
              num2 = (int) num4 * -1181324849 ^ -255365467;
              continue;
            case 9:
              num2 = (int) num4 * 541530208 ^ -970112997;
              continue;
            case 10:
              int num9 = !flag3 ? -1262630690 : (num9 = -733871690);
              int num10 = (int) num4 * 1282736302;
              num2 = num9 ^ num10;
              continue;
            case 11:
              int num11 = (int) this.ExecuteSubActivity((ActivityBase) new LeaveMeeting(), true);
              num2 = (int) num4 * -674701758 ^ -1829998750;
              continue;
            case 12:
              num2 = (int) num4 * -1141184407 ^ -48671210;
              continue;
            case 13:
              flag3 = this.MeetingInAttendance();
              num2 = (int) num4 * 1203478667 ^ 208990953;
              continue;
            case 14:
              if (this.LeaveCurrentMeeting)
              {
                num2 = (int) num4 * 1676672 ^ -1048096250;
                continue;
              }
              break;
            case 15:
              joinEndTime = DateTime.Now.AddSeconds((double) this.waitDurationSeconds);
              num2 = 1385078134;
              continue;
            case 16:
              flag1 = this.OtherMeetingInAttendance();
              num2 = 1161878857;
              continue;
            case 17:
              this.LoadStartingWindowHandles();
              this.SetJoinState(state, meetStatus, "");
              num2 = (int) num4 * -1200792507 ^ -1983407677;
              continue;
            case 18:
              num2 = (int) num4 * -1565194133 ^ -938356813;
              continue;
            case 19:
              int num12 = !flag1 ? -263421065 : (num12 = -388271207);
              int num13 = (int) num4 * -1749126557;
              num2 = num12 ^ num13;
              continue;
            case 20:
              this.SetJoinState(ActivityState.Completed, MeetingStatus.Attending, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4242443346U));
              this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2461530993U) + this.MeetingId, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2325646536U));
              num2 = (int) num4 * -216220971 ^ 310321070;
              continue;
            case 21:
              this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1829259956U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2325646536U));
              num2 = (int) num4 * 779563241 ^ -1648271559;
              continue;
            case 22:
              this.JoinEvents.Clear();
              num2 = (int) num4 * -144406645 ^ -2042410352;
              continue;
            case 23:
              num2 = 798781755;
              continue;
            case 24:
              this.ReportProgress(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1866553570U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2125823528U));
              num2 = (int) num4 * -1185271026 ^ 1363347116;
              continue;
            case 25:
              num2 = (int) num4 * 1788396393 ^ -1303766952;
              continue;
            case 26:
              this.SetJoinState(this.ActivityState, this.MeetingStatus, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(436551003U) + (object) this.MeetingStatus);
              num2 = (int) num4 * -232815005 ^ 1301027603;
              continue;
            case 27:
              int num14 = !flag2 ? -1662143712 : (num14 = -785373702);
              int num15 = (int) num4 * -792555333;
              num2 = num14 ^ num15;
              continue;
            case 28:
              num2 = 341126520;
              continue;
            case 29:
              flag2 = this.MeetingStatus == MeetingStatus.Invalid;
              num2 = (int) num4 * 2112297391 ^ 796889911;
              continue;
            case 30:
              goto label_7;
            case 31:
              num5 = !JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(this.Engine.ActiveMeeting.MeetingId, this.MeetingId) ? 1 : 0;
              goto label_40;
            case 32:
              num2 = (int) num4 * 379527993 ^ 1526121846;
              continue;
            case 33:
              num2 = (int) num4 * -331774834 ^ -1775670406;
              continue;
            case 34:
              this.Engine.RemoveMeeting(this.MeetingId);
              num2 = (int) num4 * -130512107 ^ -1766879250;
              continue;
            default:
              goto label_47;
          }
          num5 = 0;
label_40:
          flag4 = num5 != 0;
          num2 = 402036646;
        }
      }
      catch (Exception ex)
      {
        this.SetJoinState(ActivityState.Error, MeetingStatus.Error, ex.Message);
      }
label_47:
      bool flag = this.ActivityState == ActivityState.InProgress;
label_48:
      int num16 = 205846627;
      ActivityState activityState;
      while (true)
      {
        int num2 = 1455962845;
        uint num3;
        switch ((num3 = (uint) (num16 ^ num2)) % 8U)
        {
          case 0:
            goto label_48;
          case 1:
            this.SetJoinState(ActivityState.Error, MeetingStatus.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3594312641U));
            num16 = (int) num3 * -487173631 ^ 1556207968;
            continue;
          case 3:
            num16 = (int) num3 * -1698469908 ^ -889828668;
            continue;
          case 4:
            num16 = (int) num3 * 1367984307 ^ 643134522;
            continue;
          case 5:
            activityState = this.ActivityState;
            num16 = 66414167;
            continue;
          case 6:
            int num4 = !flag ? -460000642 : (num4 = -192397500);
            int num5 = (int) num3 * -1653707487;
            num16 = num4 ^ num5;
            continue;
          case 7:
            num16 = (int) num3 * 2059034264 ^ -1535868156;
            continue;
          default:
            goto label_56;
        }
      }
label_56:
      return activityState;
    }

    private MeetingStatus CheckJoinResults(DateTime joinEndTime)
    {
label_1:
      int num1 = -3854547;
      MeetingStatus meetingStatus;
      while (true)
      {
        int num2 = -38850888;
        uint num3;
        ZoomEvent pendingEvent;
        bool flag1;
        DateTime WaitUntil;
        DateTime now;
        bool flag2;
        bool flag3;
        List<ZoomEvent> zoomEventList;
        bool flag4;
        bool flag5;
        bool flag6;
        int num4;
        int num5;
        int num6;
        int num7;
        switch ((num3 = (uint) (num1 ^ num2)) % 74U)
        {
          case 0:
            num1 = (int) num3 * -1919645337 ^ -503591152;
            continue;
          case 1:
            this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(251805289U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3653590136U));
            num1 = (int) num3 * -764653612 ^ -137757634;
            continue;
          case 2:
            if (pendingEvent.EventType != ZoomEventType.Show)
            {
              num4 = 0;
              goto label_28;
            }
            else
            {
              num1 = (int) num3 * -1440456924 ^ 723406070;
              continue;
            }
          case 3:
            num5 = pendingEvent.ZoomWindowType == ZoomWindowType.WaitingForHost ? 1 : 0;
            goto label_43;
          case 4:
            num1 = (int) num3 * -1744839065 ^ -2047284155;
            continue;
          case 5:
            num1 = (int) num3 * 525568621 ^ 503420557;
            continue;
          case 6:
            num1 = (int) num3 * 121528755 ^ -202804764;
            continue;
          case 7:
            num1 = (int) num3 * -351063863 ^ -145169791;
            continue;
          case 8:
            num1 = (int) num3 * 161668150 ^ 1344072911;
            continue;
          case 9:
            pendingEvent = this.GetPendingEvent();
            num1 = (int) num3 * -1826569172 ^ 1630894153;
            continue;
          case 10:
            num4 = pendingEvent.ZoomWindowType == ZoomWindowType.WaitingForHost ? 1 : 0;
            goto label_28;
          case 11:
            num1 = (int) num3 * -692797149 ^ -1511384992;
            continue;
          case 12:
            flag4 = this.ContinueExecution(WaitUntil);
            num1 = -906411756;
            continue;
          case 13:
            int num8;
            num1 = num8 = zoomEventList != null ? -1133864666 : (num8 = -848916067);
            continue;
          case 14:
            flag6 = this.MeetingStatus == MeetingStatus.Joining;
            num1 = (int) num3 * 326043120 ^ -705729873;
            continue;
          case 15:
            num1 = (int) num3 * -887706538 ^ -1164767617;
            continue;
          case 16:
            num1 = (int) num3 * -1684729312 ^ -1523081940;
            continue;
          case 17:
            num1 = (int) num3 * -1076919407 ^ -244563558;
            continue;
          case 18:
            zoomEventList = new List<ZoomEvent>();
            zoomEventList.Add(pendingEvent);
            num1 = (int) num3 * 1593335456 ^ 825513718;
            continue;
          case 19:
            int num9 = !flag6 ? -1359299904 : (num9 = -1065076404);
            int num10 = (int) num3 * 1936033469;
            num1 = num9 ^ num10;
            continue;
          case 20:
            num1 = -706312984;
            continue;
          case 21:
            int num11 = pendingEvent == null ? -117871999 : (num11 = -1649590143);
            int num12 = (int) num3 * -954121227;
            num1 = num11 ^ num12;
            continue;
          case 22:
            flag3 = this.ActivityState != ActivityState.InProgress;
            num1 = -621900516;
            continue;
          case 23:
            int num13 = !flag5 ? -1422026183 : (num13 = -1264316438);
            int num14 = (int) num3 * -268831879;
            num1 = num13 ^ num14;
            continue;
          case 24:
            WaitUntil.AddSeconds(5.0);
            num1 = (int) num3 * 691038152 ^ 461491778;
            continue;
          case 25:
            int num15 = !flag1 ? 713832387 : (num15 = 1381206568);
            int num16 = (int) num3 * 671222623;
            num1 = num15 ^ num16;
            continue;
          case 26:
            num1 = -760043670;
            continue;
          case 27:
            joinEndTime = now.AddSeconds(60.0);
            this.EndTime = joinEndTime;
            num1 = (int) num3 * 218198548 ^ 1757631760;
            continue;
          case 28:
            DateTime minValue1 = DateTime.MinValue;
            zoomEventList = (List<ZoomEvent>) null;
            now = DateTime.Now;
            num1 = (int) num3 * -1619873125 ^ -32636790;
            continue;
          case 29:
            int num17 = !flag2 ? 600597084 : (num17 = 1052137092);
            int num18 = (int) num3 * -492140504;
            num1 = num17 ^ num18;
            continue;
          case 30:
            this.lastEventDetected = DateTime.Now;
            this.JoinEvents.Add(pendingEvent);
            num1 = (int) num3 * 1004944146 ^ 877264008;
            continue;
          case 31:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3609274257U));
            num1 = (int) num3 * 1469774412 ^ -1682154762;
            continue;
          case 32:
            num1 = -488241622;
            continue;
          case 33:
            num1 = (int) num3 * -414358280 ^ 1300793805;
            continue;
          case 34:
            zoomEventList.Add(pendingEvent);
            num1 = (int) num3 * 1650422208 ^ -293967912;
            continue;
          case 35:
            this.MeetingStatus = MeetingStatus.NotAttending;
            num1 = (int) num3 * 1343273209 ^ 2138437235;
            continue;
          case 36:
            num1 = (int) num3 * 1314045198 ^ -174234611;
            continue;
          case 37:
            meetingStatus = this.MeetingStatus;
            num1 = -1578818924;
            continue;
          case 38:
            num1 = (int) num3 * 224499226 ^ 1953304411;
            continue;
          case 39:
            num6 = this.lastEventDetected.AddSeconds(10.0) < DateTime.Now ? 1 : 0;
            goto label_51;
          case 41:
            num1 = (int) num3 * 464954144 ^ -1911834075;
            continue;
          case 42:
            this.ProcessZoomEvent(pendingEvent);
            flag2 = WaitUntil.AddSeconds(-5.0) < DateTime.Now;
            num1 = -12169923;
            continue;
          case 43:
            this.LoadStartingWindowHandles();
            num1 = (int) num3 * 651023050 ^ -500183441;
            continue;
          case 44:
            this.SetMeetingStatus(pendingEvent);
            num1 = (int) num3 * 1719968738 ^ 460834664;
            continue;
          case 45:
            this.SetJoinState(ActivityState.Completed, this.MeetingStatus, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3951245759U));
            num1 = -252527689;
            continue;
          case 46:
            num1 = (int) num3 * 894286771 ^ 767588939;
            continue;
          case 47:
            DateTime minValue2 = DateTime.MinValue;
            List<IntPtr> numList = new List<IntPtr>();
            num1 = (int) num3 * -1869558381 ^ 859286782;
            continue;
          case 48:
            WaitUntil = now.AddSeconds(60.0);
            num1 = (int) num3 * -1516644574 ^ 1113649650;
            continue;
          case 49:
            if (!this.TimeLimitReached())
            {
              num7 = 0;
              break;
            }
            num1 = (int) num3 * 1480526827 ^ 1811115833;
            continue;
          case 50:
            num1 = (int) num3 * 1341226678 ^ 1302242999;
            continue;
          case 51:
            flag5 = pendingEvent.ZoomWindowType == ZoomWindowType.LeaveCurrent;
            num1 = -1446011747;
            continue;
          case 52:
            num1 = (int) num3 * 2025492233 ^ 1578950307;
            continue;
          case 53:
            num1 = (int) num3 * -809731649 ^ -801347904;
            continue;
          case 54:
            num7 = this.ActivityState != ActivityState.Completed ? 1 : 0;
            break;
          case 55:
            now = DateTime.Now;
            num1 = (int) num3 * -1577578245 ^ -1175754134;
            continue;
          case 56:
            num1 = (int) num3 * 2009995159 ^ -156469739;
            continue;
          case 57:
            this.CheckCancellationToken();
            num1 = -1094957633;
            continue;
          case 58:
            int num19 = flag3 ? -557624506 : (num19 = -632733366);
            int num20 = (int) num3 * -108230952;
            num1 = num19 ^ num20;
            continue;
          case 59:
            num1 = -1300847608;
            continue;
          case 60:
            int num21 = flag4 ? 523186035 : (num21 = 1880097983);
            int num22 = (int) num3 * 785509453;
            num1 = num21 ^ num22;
            continue;
          case 61:
            num1 = (int) num3 * -607953821 ^ 1482968360;
            continue;
          case 62:
            num1 = (int) num3 * -196303424 ^ -886735866;
            continue;
          case 63:
            num1 = (int) num3 * 1651566793 ^ -723057736;
            continue;
          case 64:
            if (!this.lastEventDetected.Equals(DateTime.MinValue))
            {
              num1 = -1076184153;
              continue;
            }
            num6 = 0;
            goto label_51;
          case 65:
            goto label_1;
          case 66:
            num1 = (int) num3 * 479830592 ^ -249455337;
            continue;
          case 67:
            num1 = (int) num3 * -871476739 ^ -255808129;
            continue;
          case 68:
            CoreObject.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3554838324U), new object[0]);
            num1 = (int) num3 * -889627436 ^ 1407804380;
            continue;
          case 69:
            this.SetActivityState(ActivityState.Canceled, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2335470651U));
            num1 = (int) num3 * 504775102 ^ -2128203033;
            continue;
          case 70:
            num1 = (int) num3 * 1460712489 ^ -1838036098;
            continue;
          case 71:
            if (pendingEvent.EventType != ZoomEventType.Show)
            {
              num5 = 0;
              goto label_43;
            }
            else
            {
              num1 = (int) num3 * 1161758045 ^ 692610186;
              continue;
            }
          case 72:
            num1 = -1407696891;
            continue;
          case 73:
            pendingEvent.Window.Close(true, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3653590136U));
            num1 = (int) num3 * 1233356629 ^ -1347443453;
            continue;
          default:
            goto label_87;
        }
        flag1 = num7 != 0;
        num1 = -1284277263;
        continue;
label_28:
        int num23;
        num1 = num23 = num4 == 0 ? -1470274185 : (num23 = -1502526607);
        continue;
label_43:
        int num24;
        num1 = num24 = num5 != 0 ? -1126276128 : (num24 = -826784344);
        continue;
label_51:
        int num25;
        num1 = num25 = num6 == 0 ? -1407696891 : (num25 = -506384477);
      }
label_87:
      return meetingStatus;
    }

    private bool ContinueExecution(DateTime WaitUntil)
    {
      bool flag1 = false;
label_1:
      int num1 = -572586941;
      bool flag2;
      while (true)
      {
        int num2 = -232456050;
        uint num3;
        bool flag3;
        bool flag4;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            if (this.MeetingStatus != MeetingStatus.Joining)
            {
              num1 = -1785425876;
              continue;
            }
            num4 = 0;
            break;
          case 1:
            int num5 = this.ContinueExecution() ? -1689701143 : (num5 = -536990138);
            int num6 = (int) num3 * 1626785837;
            num1 = num5 ^ num6;
            continue;
          case 2:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1899844594 ^ 573940711;
            continue;
          case 5:
            num1 = (int) num3 * -1320625293 ^ -285195168;
            continue;
          case 6:
            num4 = (uint) this.MeetingStatus > 0U ? 1 : 0;
            break;
          case 7:
            num1 = (int) num3 * 1950699970 ^ -1819218841;
            continue;
          case 8:
            int num7 = !flag4 ? 2019772075 : (num7 = 908076937);
            int num8 = (int) num3 * -1043222257;
            num1 = num7 ^ num8;
            continue;
          case 9:
            int num9 = flag3 ? -2053621471 : (num9 = -1585038689);
            int num10 = (int) num3 * 1303793873;
            num1 = num9 ^ num10;
            continue;
          case 10:
            JoinMeeting.\u206A‪⁬‎⁮‍​⁬‭⁯​‭‬⁯‪⁫‭‏‏‬​‪‪​‮‎‪⁪‏⁭‭⁬⁮‌‬‭​‭‭‮‮(CoreObject.log, (object) JoinMeeting.\u202A⁯⁫‍‬‬‪‮⁫⁪‫‫‬⁭⁭‏‮⁪⁮‎‬⁮‮‪⁯‫‭‏‎‍‎‎⁯⁮‍⁬⁬‮‎⁭‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3007158601U), (object) this.MeetingStatus));
            num1 = (int) num3 * 219692412 ^ 60331257;
            continue;
          case 11:
            flag1 = true;
            num1 = (int) num3 * 954225967 ^ -1425564150;
            continue;
          case 12:
            num1 = (int) num3 * 338317464 ^ 1021901905;
            continue;
          case 13:
            num1 = (int) num3 * 1335530350 ^ 488050547;
            continue;
          case 14:
            flag3 = WaitUntil < DateTime.Now;
            num1 = -427623837;
            continue;
          case 15:
            flag1 = true;
            num1 = (int) num3 * 1763901553 ^ -1520418479;
            continue;
          case 16:
            num1 = (int) num3 * 1216005754 ^ -605220837;
            continue;
          case 17:
            flag2 = !flag1;
            num1 = -567573866;
            continue;
          case 18:
            JoinMeeting.\u206A‪⁬‎⁮‍​⁬‭⁯​‭‬⁯‪⁫‭‏‏‬​‪‪​‮‎‪⁪‏⁭‭⁬⁮‌‬‭​‭‭‮‮(CoreObject.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3184673055U));
            flag1 = true;
            num1 = (int) num3 * 928413169 ^ 137634520;
            continue;
          case 19:
            num1 = (int) num3 * 788221208 ^ 2120499520;
            continue;
          default:
            goto label_24;
        }
        flag4 = num4 != 0;
        num1 = -290354458;
      }
label_24:
      return flag2;
    }

    private void ProcessZoomEvent(ZoomEvent activityEvent)
    {
      JoinMeeting.\u206A‪⁬‎⁮‍​⁬‭⁯​‭‬⁯‪⁫‭‏‏‬​‪‪​‮‎‪⁪‏⁭‭⁬⁮‌‬‭​‭‭‮‮(CoreObject.log, (object) JoinMeeting.\u202A⁯⁫‍‬‬‪‮⁫⁪‫‫‬⁭⁭‏‮⁪⁮‎‬⁮‮‪⁯‫‭‏‎‍‎‎⁯⁮‍⁬⁬‮‎⁭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(928719408U), (object) activityEvent));
label_1:
      int num1 = 1744181291;
      while (true)
      {
        int num2 = 1124819027;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 29U)
        {
          case 0:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2524572053U));
            num1 = (int) num3 * -1519162069 ^ -757516283;
            continue;
          case 1:
            int num6 = activityEvent.Window.IsClosable ? -181114883 : (num6 = -286588948);
            int num7 = (int) num3 * 661750147;
            num1 = num6 ^ num7;
            continue;
          case 2:
            goto label_1;
          case 3:
            if (this.MeetingStatus != MeetingStatus.Unknown)
            {
              num1 = (int) num3 * -1099866758 ^ -1288548172;
              continue;
            }
            break;
          case 4:
            activityEvent.Window.Close(false, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2426253906U));
            num1 = (int) num3 * 429215935 ^ -2050714560;
            continue;
          case 5:
            int num8 = !flag3 ? 1111735136 : (num8 = 1291956806);
            int num9 = (int) num3 * -2103859519;
            num1 = num8 ^ num9;
            continue;
          case 6:
            num1 = 682888331;
            continue;
          case 7:
            num1 = (int) num3 * 82424870 ^ -1914434488;
            continue;
          case 8:
            goto label_3;
          case 9:
            num1 = 330153720;
            continue;
          case 10:
            this.MeetingStatus = MeetingStatus.Attending;
            num1 = (int) num3 * 1628606139 ^ -102559614;
            continue;
          case 11:
            flag2 = this.RelevantZoomEvent(activityEvent);
            num1 = (int) num3 * 118911830 ^ -1355998850;
            continue;
          case 12:
            flag1 = JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(this.Engine.ActiveMeeting.MeetingId, this.MeetingId);
            num1 = (int) num3 * -1506413616 ^ 2077138939;
            continue;
          case 13:
            int num10 = flag2 ? -769958685 : (num10 = -1979003278);
            int num11 = (int) num3 * -427192487;
            num1 = num10 ^ num11;
            continue;
          case 14:
            num1 = (int) num3 * 1065154983 ^ 106344492;
            continue;
          case 15:
            num1 = 1316168523;
            continue;
          case 16:
            this.SetMeetingStatus(activityEvent);
            num1 = (int) num3 * -1838702900 ^ 1353089624;
            continue;
          case 17:
            if (this.Engine.ActiveMeeting != null)
            {
              num1 = 493319898;
              continue;
            }
            num5 = 0;
            goto label_34;
          case 18:
            num4 = this.MeetingStatus != MeetingStatus.Joining ? 1 : 0;
            goto label_29;
          case 19:
            num1 = (int) num3 * 1143754947 ^ 1149551204;
            continue;
          case 20:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(828067913U));
            num1 = (int) num3 * -1650495421 ^ -384907598;
            continue;
          case 21:
            num1 = (int) num3 * 1526524038 ^ 346748399;
            continue;
          case 22:
            int num12 = flag1 ? 582436999 : (num12 = 890015246);
            int num13 = (int) num3 * -1664957637;
            num1 = num12 ^ num13;
            continue;
          case 23:
            if (this.MeetingStatus != MeetingStatus.Attending)
            {
              num1 = (int) num3 * -348160319 ^ 849384688;
              continue;
            }
            break;
          case 24:
            num1 = (int) num3 * -2119854782 ^ -402942012;
            continue;
          case 25:
            num5 = this.MeetingStatus == MeetingStatus.Joining ? 1 : 0;
            goto label_34;
          case 26:
            num1 = 637952263;
            continue;
          case 27:
            num1 = (int) num3 * -1943607372 ^ -849017383;
            continue;
          case 28:
            num1 = (int) num3 * 1756193674 ^ -1865741637;
            continue;
          default:
            goto label_38;
        }
        num4 = 0;
label_29:
        int num14;
        num1 = num14 = num4 != 0 ? 432156804 : (num14 = 330153720);
        continue;
label_34:
        flag3 = num5 != 0;
        num1 = 839710200;
      }
label_38:
      return;
label_3:;
    }

    private bool TimeLimitReached()
    {
      if (!(this.EndTime < DateTime.Now))
        goto label_7;
label_1:
      int num1 = 1268594827;
label_2:
      bool flag1;
      bool flag2;
      while (true)
      {
        int num2 = 1122494635;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            flag1 = false;
            num1 = (int) num3 * -260663456 ^ 1370814588;
            continue;
          case 1:
            num1 = 829105003;
            continue;
          case 2:
            flag1 = true;
            num1 = (int) num3 * 1166615473 ^ -755436988;
            continue;
          case 3:
            num1 = (int) num3 * 1715011789 ^ 1594174461;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num4 = flag2 ? -149248164 : (num4 = -1708618229);
            int num5 = (int) num3 * 959866573;
            num1 = num4 ^ num5;
            continue;
          case 6:
            if (this.ActivityState == ActivityState.InProgress)
            {
              num1 = (int) num3 * 793103770 ^ 1261257092;
              continue;
            }
            goto label_7;
          case 8:
            num1 = (int) num3 * -900055135 ^ 177852251;
            continue;
          case 9:
            goto label_6;
          default:
            goto label_14;
        }
      }
label_6:
      int num6 = !this.MeetingInAttendance() ? 1 : 0;
      goto label_8;
label_14:
      return flag1;
label_7:
      num6 = 0;
label_8:
      flag2 = num6 != 0;
      num1 = 1185506530;
      goto label_2;
    }

    private void LoadStartingWindowHandles()
    {
      try
      {
        using (List<Process>.Enumerator enumerator = WindowManager.GetProcesses().GetEnumerator())
        {
label_8:
          int num1 = !enumerator.MoveNext() ? 951475046 : (num1 = 889896299);
          while (true)
          {
            int num2 = 1180212286;
            uint num3;
            Process current;
            bool flag;
            switch ((num3 = (uint) (num1 ^ num2)) % 11U)
            {
              case 0:
                num1 = (int) num3 * 1912566503 ^ 1585597675;
                continue;
              case 1:
                current = enumerator.Current;
                num1 = 377757218;
                continue;
              case 2:
                this.startingWindowHandles.AddRange((IEnumerable<IntPtr>) WindowManager.GetVisibleWindowHandles(JoinMeeting.\u200C⁪‌‎‏⁪‭‌⁫‫‍‏‫⁫‏‎‌‮‭‎‭‏⁭‭‌⁫⁪‭‬⁮‏‏⁫⁭‫⁬‎⁪‬‎‮(current)));
                num1 = (int) num3 * -1656130281 ^ 917109543;
                continue;
              case 3:
                goto label_23;
              case 4:
                num1 = (int) num3 * 1645989447 ^ 1173104839;
                continue;
              case 5:
                goto label_8;
              case 6:
                flag = !JoinMeeting.\u206F‫‎‪‪‬‪⁫​⁮​⁫‌​​⁫⁫⁮‭⁭‪‎‏⁮‬‮⁭‪​⁮‭‫⁪‮⁯‎⁮‭⁭‪‮(current);
                num1 = (int) num3 * -445203343 ^ 191221912;
                continue;
              case 7:
                num1 = (int) num3 * -2017957081 ^ -1687901611;
                continue;
              case 8:
                int num4 = !flag ? 1486514238 : (num4 = 190149007);
                int num5 = (int) num3 * -722039515;
                num1 = num4 ^ num5;
                continue;
              case 9:
                num1 = 889896299;
                continue;
              case 10:
                num1 = 1904058055;
                continue;
              default:
                goto label_20;
            }
          }
label_20:
          return;
label_23:;
        }
      }
      catch (Exception ex)
      {
label_18:
        int num1 = 1114448093;
        while (true)
        {
          int num2 = 1180212286;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1636007937 ^ -538596809;
              continue;
            case 1:
              goto label_16;
            case 2:
              goto label_18;
            case 3:
              JoinMeeting.\u200F‫‍⁭‭‭‭‪‎‪‫⁭⁯⁮⁬‍⁭⁭‍⁯​​‬⁪‪‮⁮⁬‏⁪‭⁬‮⁭‏⁬‫⁯⁮‍‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1841800948 ^ -1632143482;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_16:;
      }
    }

    private bool OtherMeetingInAttendance()
    {
label_1:
      int num1 = -292259303;
      bool flag1;
      while (true)
      {
        int num2 = -463559821;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 1:
            num1 = (int) num3 * 417665825 ^ -1230530942;
            continue;
          case 2:
            if (this.Engine.ActiveMeeting == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 593922084 ^ -1859190370;
            continue;
          case 3:
            goto label_1;
          case 4:
            flag1 = true;
            num1 = (int) num3 * -1151041353 ^ -1031077737;
            continue;
          case 5:
            num4 = !JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(this.Engine.ActiveMeeting.MeetingId, this.MeetingId) ? 1 : 0;
            break;
          case 6:
            flag1 = false;
            num1 = -1150451478;
            continue;
          case 7:
            int num5 = flag2 ? -180328754 : (num5 = -187889700);
            int num6 = (int) num3 * -888975753;
            num1 = num5 ^ num6;
            continue;
          default:
            goto label_12;
        }
        flag2 = num4 != 0;
        num1 = -652217844;
      }
label_12:
      return flag1;
    }

    private bool MeetingInAttendance()
    {
label_1:
      int num1 = -1015062984;
      bool flag;
      while (true)
      {
        int num2 = -1613509260;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            flag = true;
            num1 = (int) num3 * 752217834 ^ -98282062;
            continue;
          case 1:
            if (this.Engine.ActiveMeeting != null)
            {
              num1 = (int) num3 * 817685137 ^ -1545111010;
              continue;
            }
            num4 = 0;
            break;
          case 3:
            num1 = -1624510211;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_31;
          case 6:
            num4 = JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(this.Engine.ActiveMeeting.MeetingId, this.MeetingId) ? 1 : 0;
            break;
          default:
            goto label_10;
        }
        int num5;
        num1 = num5 = num4 == 0 ? -1598176073 : (num5 = -257798345);
      }
label_10:
      using (List<IntPtr>.Enumerator enumerator = this.startingWindowHandles.GetEnumerator())
      {
label_16:
        int num2 = !enumerator.MoveNext() ? -2090055681 : (num2 = -723931138);
        while (true)
        {
          int num3 = -1613509260;
          uint num4;
          string windowClass;
          IntPtr current;
          string str;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              num2 = -1995817387;
              continue;
            case 2:
              windowClass = WindowHelper.GetWindowClass(current);
              str = JoinMeeting.\u202D‪‪‍‎‌‌​‫⁯‌‬‪⁯‬‎‭⁯⁯⁭⁭‌‪⁪​‏‍⁮‬‌⁫⁫‫⁪‫‭⁬⁮‮⁬‮(WindowHelper.GetWindowTitle(current), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2237685910U), "");
              num2 = (int) num4 * -1852235443 ^ 973615244;
              continue;
            case 3:
              num5 = JoinMeeting.\u200E‮⁮⁭⁫‍⁭⁯⁬⁯‬‫⁭⁭‮⁪‫‬‎‌​⁭⁯‎‍‌​⁮‎​‭⁯​⁮⁪⁭​⁮‭‪‮(str, this.MeetingId) ? 1 : 0;
              break;
            case 4:
              goto label_15;
            case 5:
              goto label_16;
            case 6:
              current = enumerator.Current;
              num2 = -956883829;
              continue;
            case 7:
              num2 = -723931138;
              continue;
            case 8:
              if (JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(windowClass, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1736024055U)))
              {
                num2 = (int) num4 * 27025386 ^ 1265088249;
                continue;
              }
              num5 = 0;
              break;
            case 9:
              num2 = (int) num4 * -133635571 ^ 1155657179;
              continue;
            default:
              goto label_26;
          }
          int num6;
          num2 = num6 = num5 == 0 ? -1736495310 : (num6 = -2091035374);
        }
label_15:
        flag = true;
        goto label_31;
      }
label_26:
label_27:
      int num7 = -296328053;
      while (true)
      {
        int num2 = -1613509260;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            goto label_27;
          case 2:
            num7 = (int) num3 * 946160531 ^ -988292009;
            continue;
          case 3:
            flag = false;
            num7 = (int) num3 * 288717448 ^ -1554278734;
            continue;
          default:
            goto label_31;
        }
      }
label_31:
      return flag;
    }

    private DateTime CheckActiveWindows(DateTime nextActiveWindowCheck, List<ZoomEvent> zoomEvents)
    {
      if (zoomEvents.Count != 0)
        goto label_11;
label_1:
      int num1 = -1224139296;
label_2:
      while (true)
      {
        int num2 = -1334810539;
        uint num3;
        DateTime now;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            now = DateTime.Now;
            num1 = (int) num3 * 1580390660 ^ -1504900851;
            continue;
          case 1:
            num1 = (int) num3 * 392549187 ^ 1119578860;
            continue;
          case 2:
            nextActiveWindowCheck = now.AddSeconds(2.0);
            zoomEvents.AddRange((IEnumerable<ZoomEvent>) this.ConvertActiveWindowsToEvents());
            num1 = (int) num3 * 1537303183 ^ 704370612;
            continue;
          case 3:
            num1 = (int) num3 * 941707854 ^ -2077995258;
            continue;
          case 4:
            goto label_1;
          case 5:
            num4 = nextActiveWindowCheck < DateTime.Now ? 1 : 0;
            break;
          case 6:
            if (nextActiveWindowCheck.Equals(DateTime.MaxValue))
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * 772738853 ^ 1947708230;
            continue;
          case 7:
            goto label_11;
          case 9:
            num1 = -478949035;
            continue;
          case 10:
            num1 = (int) num3 * -1453605885 ^ 1169689651;
            continue;
          default:
            goto label_15;
        }
        int num5;
        num1 = num5 = num4 != 0 ? -2108087739 : (num5 = -442040817);
      }
label_15:
      DateTime dateTime;
      return dateTime;
label_11:
      dateTime = nextActiveWindowCheck;
      num1 = -925137842;
      goto label_2;
    }

    private void CloseExistingWindows()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      using (List<ZoomWindow>.Enumerator enumerator = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.ActiveWindows, (Func<M0, bool>) (JoinMeeting.\u003C\u003Ec.\u003C\u003E9__46_0 ?? (JoinMeeting.\u003C\u003Ec.\u003C\u003E9__46_0 = new Func<ZoomWindow, bool>((object) JoinMeeting.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCloseExistingWindows\u003Eb__46_0)))))).ToList<ZoomWindow>().GetEnumerator())
      {
label_5:
        int num1 = enumerator.MoveNext() ? -1344378054 : (num1 = -1649602447);
        while (true)
        {
          int num2 = -1158966173;
          uint num3;
          ZoomWindow current;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = -1344378054;
              continue;
            case 1:
              current.Close(false, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3861251340U));
              num1 = (int) num3 * 1894786707 ^ 261770115;
              continue;
            case 2:
              goto label_5;
            case 3:
              current = enumerator.Current;
              num1 = -1322285354;
              continue;
            case 4:
              goto label_8;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_8:;
      }
    }

    private List<ZoomEvent> ConvertActiveWindowsToEvents()
    {
label_1:
      int num1 = -635655194;
      List<ZoomEvent> zoomEventList;
      List<ZoomWindow> list;
      while (true)
      {
        int num2 = -1594488643;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            zoomEventList = new List<ZoomEvent>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.ActiveWindows, (Func<M0, bool>) (JoinMeeting.\u003C\u003Ec.\u003C\u003E9__47_0 ?? (JoinMeeting.\u003C\u003Ec.\u003C\u003E9__47_0 = new Func<ZoomWindow, bool>((object) JoinMeeting.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CConvertActiveWindowsToEvents\u003Eb__47_0)))))).ToList<ZoomWindow>();
            num1 = -487125997;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      List<ZoomWindow>.Enumerator enumerator = list.GetEnumerator();
      try
      {
label_8:
        int num2 = enumerator.MoveNext() ? -1499667984 : (num2 = -2088648314);
        while (true)
        {
          int num3 = -1594488643;
          uint num4;
          ZoomWindow current;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_8;
            case 1:
              num2 = (int) num4 * 345451012 ^ 1963400179;
              continue;
            case 2:
              num2 = -1499667984;
              continue;
            case 4:
              zoomEventList.Add(new ZoomEvent(current));
              num2 = (int) num4 * -1040499036 ^ 1706277088;
              continue;
            case 5:
              current = enumerator.Current;
              num2 = -1184361157;
              continue;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        enumerator.Dispose();
label_13:
        int num2 = -2146322352;
        while (true)
        {
          int num3 = -1594488643;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_13;
            case 1:
              num2 = (int) num4 * -558743734 ^ -2110789107;
              continue;
            default:
              goto label_16;
          }
        }
label_16:;
      }
label_17:
      return zoomEventList;
    }

    private void StartJoin(string meetingId)
    {
      bool flag1 = false;
      bool flag2 = false;
label_1:
      int num1 = -733817548;
      object activityLocker;
      while (true)
      {
        int num2 = -2110410933;
        uint num3;
        bool flag3;
        ZoomWindow window1;
        bool flag4;
        ZoomWindow window2;
        DateTime now;
        bool flag5;
        DateTime dateTime;
        bool flag6;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 62U)
        {
          case 0:
            window1 = this.Engine.GetWindow(ZoomWindowType.Join);
            num1 = -548074585;
            continue;
          case 2:
            num1 = (int) num3 * 1353360648 ^ -1714419779;
            continue;
          case 3:
            int num6 = !window1.IsVisible ? 907370781 : (num6 = 708308451);
            int num7 = (int) num3 * -1783885045;
            num1 = num6 ^ num7;
            continue;
          case 4:
            Thread.Sleep(80);
            num1 = (int) num3 * 660455843 ^ -1517927852;
            continue;
          case 5:
            num1 = (int) num3 * -1006468149 ^ 131468759;
            continue;
          case 6:
            Thread.Sleep(40);
            num1 = (int) num3 * 1240918349 ^ 1072526021;
            continue;
          case 7:
            int num8 = !flag4 ? -943169296 : (num8 = -399556313);
            int num9 = (int) num3 * 1725593246;
            num1 = num8 ^ num9;
            continue;
          case 8:
            now = DateTime.Now;
            num1 = -854559301;
            continue;
          case 9:
            this.JoinInitiated = DateTime.Now;
            num1 = (int) num3 * 783417332 ^ -513573335;
            continue;
          case 10:
            activityLocker = ActivityBase.activityLocker;
            num1 = -1327883766;
            continue;
          case 11:
            int num10 = window1 == null ? 321422470 : (num10 = 904277319);
            int num11 = (int) num3 * 1407318856;
            num1 = num10 ^ num11;
            continue;
          case 12:
            flag2 = true;
            num1 = (int) num3 * -648852734 ^ 1780542328;
            continue;
          case 13:
            num1 = (int) num3 * -919954588 ^ 65729503;
            continue;
          case 14:
            window1.Move(0, 0);
            num1 = (int) num3 * -274296661 ^ -798908277;
            continue;
          case 15:
            num1 = (int) num3 * -52154381 ^ -2141881119;
            continue;
          case 16:
            SendKeys.SendWait(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2721208347U));
            num1 = (int) num3 * -1973558384 ^ 1774920578;
            continue;
          case 17:
            if (window1 != null)
            {
              num4 = 0;
              goto label_29;
            }
            else
            {
              num1 = (int) num3 * -37989671 ^ -2011690773;
              continue;
            }
          case 18:
            goto label_1;
          case 19:
            num1 = (int) num3 * -1010609041 ^ 175399459;
            continue;
          case 20:
            SendKeys.SendWait(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1195154111U));
            num1 = (int) num3 * -226871605 ^ -604188360;
            continue;
          case 21:
            Thread.Sleep(40);
            num1 = (int) num3 * 1960919572 ^ 1124307639;
            continue;
          case 22:
            num1 = -1051246863;
            continue;
          case 23:
            num1 = -746271847;
            continue;
          case 24:
            Thread.Sleep(80);
            num1 = (int) num3 * -976957709 ^ 63152597;
            continue;
          case 25:
            window2.Click(new System.Drawing.Point(115, 332), true, true, 0);
            num1 = (int) num3 * -731510939 ^ -614046932;
            continue;
          case 26:
            now = DateTime.Now;
            this.EndTime = now.AddSeconds(30.0);
            num1 = (int) num3 * -900864489 ^ 88889173;
            continue;
          case 27:
            window2 = this.Engine.GetWindow(ZoomWindowType.AccountPanel);
            num1 = (int) num3 * 2023074852 ^ 1945307110;
            continue;
          case 28:
            window1.Activate();
            num1 = (int) num3 * -533142822 ^ -1344905681;
            continue;
          case 29:
            num1 = (int) num3 * 1397393821 ^ 2109414316;
            continue;
          case 30:
            num1 = (int) num3 * -716185153 ^ -1650661625;
            continue;
          case 31:
            num1 = (int) num3 * 580259751 ^ -1764853496;
            continue;
          case 32:
            int num12 = flag3 ? -705933568 : (num12 = -1174859727);
            int num13 = (int) num3 * -1715380278;
            num1 = num12 ^ num13;
            continue;
          case 33:
            num5 = window1 == null ? 1 : 0;
            break;
          case 34:
            if (!(dateTime > DateTime.Now))
            {
              num5 = 0;
              break;
            }
            num1 = -1213498154;
            continue;
          case 35:
            num1 = -1681632537;
            continue;
          case 36:
            dateTime = now.AddSeconds(3.0);
            window1 = this.Engine.GetWindow(ZoomWindowType.Join);
            num1 = (int) num3 * 1756717403 ^ 741440563;
            continue;
          case 37:
            window1.Click(new System.Drawing.Point(60, 80), true, true, 0);
            num1 = (int) num3 * -823465660 ^ -645127789;
            continue;
          case 38:
            num1 = (int) num3 * 328585933 ^ 745371081;
            continue;
          case 39:
            num1 = (int) num3 * -1697976150 ^ -1500526984;
            continue;
          case 40:
            num1 = (int) num3 * -1583548 ^ -1965312125;
            continue;
          case 41:
            num4 = window2 != null ? 1 : 0;
            goto label_29;
          case 42:
            Thread.Sleep(40);
            num1 = (int) num3 * -447299153 ^ -1651341704;
            continue;
          case 43:
            num1 = (int) num3 * -1029610427 ^ 1161756763;
            continue;
          case 44:
            int num14 = flag6 ? 2079603231 : (num14 = 1626881704);
            int num15 = (int) num3 * 1398229377;
            num1 = num14 ^ num15;
            continue;
          case 45:
            num1 = (int) num3 * -44970549 ^ -297938286;
            continue;
          case 46:
            SendKeys.SendWait(this.MeetingId);
            num1 = (int) num3 * 780410189 ^ -1687799020;
            continue;
          case 47:
            flag6 = !string.IsNullOrWhiteSpace(this.Options.ExecuteAs);
            num1 = (int) num3 * 1830552753 ^ 897710380;
            continue;
          case 48:
            Thread.Sleep(40);
            this.WaitForEvent(ZoomEventType.Show, ZoomWindowType.Join, 10.0);
            num1 = (int) num3 * 1921507252 ^ 1829421499;
            continue;
          case 49:
            window1 = this.Engine.GetWindow(ZoomWindowType.Join);
            num1 = (int) num3 * 545049635 ^ -1520210797;
            continue;
          case 50:
            num1 = (int) num3 * 299448288 ^ 1551171231;
            continue;
          case 51:
            flag3 = this.Engine.ZoomDatabase.IsLoggedIn();
            num1 = (int) num3 * 857378327 ^ 398352322;
            continue;
          case 52:
            num1 = (int) num3 * -2020385259 ^ -1643845054;
            continue;
          case 53:
            SendKeys.SendWait(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2819526494U));
            num1 = -1298673958;
            continue;
          case 54:
            window2.Click(new System.Drawing.Point(50, window2.Size.Height - 50), true, true, 0);
            num1 = (int) num3 * -831686313 ^ 316728488;
            continue;
          case 55:
            int num16 = flag5 ? 76432324 : (num16 = 1495271482);
            int num17 = (int) num3 * -1132867023;
            num1 = num16 ^ num17;
            continue;
          case 56:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3964067171U));
            num1 = (int) num3 * -1703695286 ^ -1995922809;
            continue;
          case 57:
            num1 = (int) num3 * 1358701177 ^ -1152781615;
            continue;
          case 58:
            SendKeys.SendWait(this.Options.ExecuteAs);
            num1 = (int) num3 * 1654960562 ^ 1285546872;
            continue;
          case 59:
            Thread.Sleep(40);
            num1 = (int) num3 * -943143182 ^ 488885918;
            continue;
          case 60:
            flag1 = true;
            num1 = (int) num3 * 869525230 ^ 144232774;
            continue;
          case 61:
            Thread.Sleep(40);
            num1 = (int) num3 * -1562759363 ^ -1120071339;
            continue;
          default:
            goto label_69;
        }
        flag4 = num5 != 0;
        num1 = -334945838;
        continue;
label_29:
        flag5 = num4 != 0;
        num1 = -1835044718;
      }
label_69:
      bool flag7 = false;
      try
      {
        Monitor.Enter(activityLocker, ref flag7);
label_71:
        int num2 = -1641909843;
        while (true)
        {
          int num3 = -2110410933;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_71;
            case 1:
              num2 = (int) num4 * -1707069304 ^ 1584463773;
              continue;
            case 3:
              num2 = (int) num4 * -1726880493 ^ 881525582;
              continue;
            case 4:
              this.JoinInitiated = DateTime.Now;
              num2 = (int) num4 * -1355063900 ^ 393745541;
              continue;
            default:
              goto label_83;
          }
        }
      }
      finally
      {
        if (flag7)
        {
label_77:
          int num2 = -1523683966;
          while (true)
          {
            int num3 = -2110410933;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_77;
              case 1:
                Monitor.Exit(activityLocker);
                num2 = (int) num4 * -1700087282 ^ 474940606;
                continue;
              case 3:
                num2 = (int) num4 * -1524225944 ^ -1274118847;
                continue;
              default:
                goto label_82;
            }
          }
        }
label_82:;
      }
label_83:
      this.EndTime = DateTime.Now.AddSeconds(30.0);
label_84:
      int num18 = -753786122;
      while (true)
      {
        int num2 = -2110410933;
        uint num3;
        switch ((num3 = (uint) (num18 ^ num2)) % 4U)
        {
          case 0:
            goto label_84;
          case 1:
            Thread.Sleep(ZoomZoom.Properties.Settings.Default.JoinPauseDuration);
            num18 = (int) num3 * -36814286 ^ 2134172247;
            continue;
          case 2:
            num18 = (int) num3 * 906197301 ^ 1932127706;
            continue;
          case 3:
            goto label_86;
          default:
            goto label_79;
        }
      }
label_79:
      return;
label_86:;
    }

    private void ExecuteViaWindowsCommand(string meetingId)
    {
label_1:
      int num1 = 944180177;
      while (true)
      {
        int num2 = 1593315208;
        uint num3;
        ProcessStartInfo processStartInfo1;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            JoinMeeting.\u206D‪​‬⁬⁮‍‍⁬‎‎⁪​‍‌⁮⁭⁪‪⁬⁮⁮‪⁯⁯‬‌​​⁭⁯‪⁭‫‍‎⁬‬‏‫‮(this.Engine.Settings.ZoomExePath, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3078565967U));
            num1 = (int) num3 * -74319790 ^ -1911847363;
            continue;
          case 2:
            goto label_3;
          case 3:
            string str1 = JoinMeeting.\u202A⁯⁫‍‬‬‪‮⁫⁪‫‫‬⁭⁭‏‮⁪⁮‎‬⁮‮‪⁯‫‭‏‎‍‎‎⁯⁮‍⁬⁬‮‎⁭‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4222897929U), (object) meetingId);
            ProcessStartInfo processStartInfo2 = JoinMeeting.\u206D‌‮‎​‫‪‍⁪‌‭‭⁮‏​‍‌⁫⁪‏⁬‬⁯‫⁯⁭⁮‪‍⁮‮‭⁬‮‫‭‌⁭‬‪‮();
            string str2 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3204904539U);
            JoinMeeting.\u206A⁫‪‬‫​⁪‫⁫‮​‍‍‍‬‬‌⁯⁮‏‎⁪⁬​⁯‌‏‌⁪⁪‭‎⁭‌‫‪‬‫‮‎‮(processStartInfo2, str2);
            string str3 = JoinMeeting.\u202A⁯⁫‍‬‬‪‮⁫⁪‫‫‬⁭⁭‏‮⁪⁮‎‬⁮‮‪⁯‫‭‏‎‍‎‎⁯⁮‍⁬⁬‮‎⁭‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4223744525U), (object) str1);
            JoinMeeting.\u206F⁭⁫‏⁬‭⁯⁯‪‎⁪⁬⁮‪‬​‮‫⁪‫‭‪⁭‎⁮‍‌​‫⁯⁮⁮‪⁬⁭‌⁮⁫⁬‍‮(processStartInfo2, str3);
            int num4 = 1;
            JoinMeeting.\u200D‭‭‬⁯‬‫⁭‪‌‏‍⁮‬‮‬⁬⁮⁪⁬⁪⁫⁪‍⁫​‏‏‮⁯⁬‫‎‍⁬‏⁫‪‪⁮‮(processStartInfo2, (ProcessWindowStyle) num4);
            int num5 = 0;
            JoinMeeting.\u200B‮‫⁭⁭⁬⁫‌‮⁯⁬⁬‎‌⁭⁭‎‏‫⁮‏⁪⁭⁮⁪‍‭⁯⁮⁭‎⁬⁭‍‪‪‫‬‍‍‮(processStartInfo2, num5 != 0);
            processStartInfo1 = processStartInfo2;
            num1 = (int) num3 * 723419448 ^ 979597480;
            continue;
          case 4:
            this.Engine.PurgeActivityQueue();
            JoinMeeting.\u206F‌‍⁭‫⁯‫‮⁬⁮‭‫‎‏‭⁮⁯​‮⁬‌⁪‎‍‎‍⁯‬‌⁯‫​‬‏‎‎⁪‍‍‍‮(processStartInfo1);
            num1 = (int) num3 * 644293385 ^ 1364487898;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private void SetMeetingStatus(ZoomEvent activityEvent)
    {
label_1:
      int num1 = -1959732759;
      object activityLocker;
      MeetingStatus meetingStatus;
      string statusMessage;
      while (true)
      {
        int num2 = -635936249;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            statusMessage = this.GetStatusMessage(meetingStatus);
            num1 = (int) num3 * -147548735 ^ 1300046689;
            continue;
          case 2:
            if (flag)
            {
              num1 = (int) num3 * -1742478746 ^ -1027230416;
              continue;
            }
            goto label_23;
          case 3:
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * 1619738251 ^ 285449699;
            continue;
          case 4:
            goto label_1;
          case 5:
            flag = (uint) meetingStatus > 0U;
            num1 = (int) num3 * 641107009 ^ -2054519025;
            continue;
          case 6:
            meetingStatus = this.GetMeetingStatus(activityEvent);
            num1 = (int) num3 * 980621427 ^ 178745910;
            continue;
          default:
            goto label_9;
        }
      }
label_23:
      return;
label_9:
      bool flag1 = false;
      try
      {
        JoinMeeting.\u206E⁭‏‫⁫‮‎⁯⁬⁪‍⁬‬‏‍‫⁫⁮⁬⁮‫⁭‏‬‎⁬‏‍‏​⁭⁫⁪‏‬⁭⁮‎⁯⁯‮(activityLocker, ref flag1);
label_11:
        int num2 = -1775918467;
        while (true)
        {
          int num3 = -635936249;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 9U)
          {
            case 0:
              this.MeetingStatus = meetingStatus;
              num2 = (int) num4 * -1013565619 ^ -167119941;
              continue;
            case 1:
              this.ActivityState = ActivityState.Completed;
              num2 = (int) num4 * 1669989898 ^ 663142538;
              continue;
            case 2:
              num2 = (int) num4 * -2074966189 ^ -525305171;
              continue;
            case 3:
              goto label_11;
            case 4:
              this.Status = statusMessage;
              num2 = (int) num4 * -314424474 ^ 1882303712;
              continue;
            case 6:
              num2 = (int) num4 * -1282649786 ^ -2004180260;
              continue;
            case 7:
              num2 = (int) num4 * 661080656 ^ 1183157724;
              continue;
            case 8:
              num2 = (int) num4 * -12527007 ^ 299379052;
              continue;
            default:
              goto label_26;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_21:
          int num2 = -2062340469;
          while (true)
          {
            int num3 = -635936249;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                JoinMeeting.\u202D⁬⁮‪⁭⁬⁬‬⁪​⁯‬‌‍‌‌‏‬‌‮‫‍‪‪⁯‌⁪‪​‏‪⁫⁭⁪‎⁯‏‌‫⁭‮(activityLocker);
                num2 = (int) num4 * 2139037893 ^ 1511967480;
                continue;
              case 2:
                goto label_21;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:;
    }

    private string GetStatusMessage(MeetingStatus meetingStatus)
    {
label_1:
      int num1 = -725508699;
      string str;
      while (true)
      {
        int num2 = -1627404264;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = !flag ? 2051703018 : (num4 = 1057137204);
            int num5 = (int) num3 * -1587452492;
            num1 = num4 ^ num5;
            continue;
          case 2:
            flag = meetingStatus == MeetingStatus.NotAttending;
            num1 = (int) num3 * -603483844 ^ -1953456426;
            continue;
          case 3:
            str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1334323604U);
            num1 = (int) num3 * -347425209 ^ -555886045;
            continue;
          case 4:
            num1 = (int) num3 * 296668869 ^ 1693299585;
            continue;
          case 5:
            str = meetingStatus.ToString();
            num1 = -1903565530;
            continue;
          case 6:
            num1 = (int) num3 * -714241876 ^ 947843903;
            continue;
          case 7:
            num1 = (int) num3 * 409424891 ^ -800998519;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return str;
    }

    private MeetingStatus GetMeetingStatus(ZoomEvent activityEvent)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      JoinMeeting.\u003C\u003Ec__DisplayClass52_0 cDisplayClass520 = new JoinMeeting.\u003C\u003Ec__DisplayClass52_0();
label_1:
      int num1 = 391056828;
      MeetingStatus meetingStatus1;
      while (true)
      {
        int num2 = 837610251;
        uint num3;
        MeetingStatus meetingStatus2;
        ZoomWindow zoomWindow;
        Rectangle rectangle1;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 22U)
        {
          case 0:
            num1 = (int) num3 * -671823390 ^ 2142544600;
            continue;
          case 1:
            meetingStatus2 = MeetingStatus.NotAttending;
            num1 = (int) num3 * 1312271757 ^ 1636653523;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass520.activityEvent.Window.Click(new System.Drawing.Point(280, 146), true, true, 0);
            num1 = (int) num3 * -381712685 ^ -431284788;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            if (JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(cDisplayClass520.activityEvent.Window.Title, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1715737907U)))
            {
              num1 = (int) num3 * -883962384 ^ -379308657;
              continue;
            }
            goto label_11;
          case 4:
            Rectangle rectangle2 = JoinMeeting.\u200D⁪‫⁯‍⁯‬‮⁯⁬​⁫‬‍⁫‭⁬⁭‎‫⁫‮⁯​​‭‪‍‎​⁭⁯‎‮⁯‏‭⁮⁮‮(JoinMeeting.\u206B‍⁫‮‮⁮‪‫⁫⁫‭‎⁯‪‍‎⁮‍⁯⁬‍​‬‏⁮‬‎⁪‮⁪‍‬⁮⁬‏⁪‍‭‬‌‮());
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local = @rectangle1;
            int num6 = rectangle2.Width - 50;
            // ISSUE: reference to a compiler-generated field
            Size size1 = cDisplayClass520.activityEvent.Window.Size;
            int width = size1.Width;
            int x = num6 - width;
            int num7 = rectangle2.Height - 50;
            // ISSUE: reference to a compiler-generated field
            size1 = cDisplayClass520.activityEvent.Window.Size;
            int height = size1.Height;
            int y = num7 - height;
            System.Drawing.Point location = new System.Drawing.Point(x, y);
            // ISSUE: reference to a compiler-generated field
            Size size2 = cDisplayClass520.activityEvent.Window.Size;
            // ISSUE: explicit reference operation
            ^local = new Rectangle(location, size2);
            // ISSUE: method pointer
            zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass520, __methodptr(\u003CGetMeetingStatus\u003Eb__0)));
            num1 = (int) num3 * 417667094 ^ -1406359886;
            continue;
          case 5:
            num5 = this.OtherMeetingInAttendance() ? 1 : 0;
            break;
          case 6:
            num1 = (int) num3 * -969318575 ^ -1454465484;
            continue;
          case 7:
            int num8 = zoomWindow == null ? 135183422 : (num8 = 570435356);
            int num9 = (int) num3 * -1729679890;
            num1 = num8 ^ num9;
            continue;
          case 9:
            meetingStatus1 = meetingStatus2;
            num1 = 1026055769;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass520.activityEvent.Window.IsVisible)
            {
              num1 = (int) num3 * -169924193 ^ 349979054;
              continue;
            }
            goto label_11;
          case 11:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass520.activityEvent = activityEvent;
            num1 = (int) num3 * 1672905524 ^ -1805191081;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            num4 = JoinMeeting.\u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮(cDisplayClass520.activityEvent.Window.ClassName, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3621412037U)) ? 1 : 0;
            goto label_12;
          case 13:
            num1 = 846062077;
            continue;
          case 14:
            if (meetingStatus2 != MeetingStatus.Attending)
            {
              num5 = 0;
              break;
            }
            num1 = 1961886714;
            continue;
          case 15:
            num1 = (int) num3 * 1952163358 ^ -887992445;
            continue;
          case 16:
            num1 = (int) num3 * 1627730226 ^ 541563772;
            continue;
          case 17:
            goto label_1;
          case 18:
            num1 = (int) num3 * -1756432830 ^ -1405660655;
            continue;
          case 19:
            zoomWindow.Move(0, 0);
            num1 = (int) num3 * -634736564 ^ 1200649331;
            continue;
          case 20:
            // ISSUE: reference to a compiler-generated field
            meetingStatus2 = MeetingHelper.GetMeetingStatus(cDisplayClass520.activityEvent);
            int num10 = meetingStatus2 != MeetingStatus.Unknown ? -618011443 : (num10 = -505596628);
            int num11 = (int) num3 * 1466473095;
            num1 = num10 ^ num11;
            continue;
          case 21:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass520.activityEvent.Window.Move(rectangle1);
            num1 = 861215109;
            continue;
          default:
            goto label_30;
        }
        int num12;
        num1 = num12 = num5 != 0 ? 1025217025 : (num12 = 172650996);
        continue;
label_11:
        num4 = 0;
label_12:
        int num13;
        num1 = num13 = num4 != 0 ? 1769413267 : (num13 = 1700799174);
      }
label_30:
      return meetingStatus1;
    }

    private bool RelevantZoomEvent(ZoomEvent activityEvent)
    {
label_1:
      int num1 = -2001979654;
      bool flag1;
      while (true)
      {
        int num2 = -1757644458;
        uint num3;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            int num6 = !flag3 ? -2080335417 : (num6 = -1812844928);
            int num7 = (int) num3 * -393450845;
            num1 = num6 ^ num7;
            continue;
          case 1:
            flag6 = flag4 & flag5 & flag2;
            num1 = -1716535516;
            continue;
          case 2:
            int num8 = !flag6 ? 1134999894 : (num8 = 1539972599);
            int num9 = (int) num3 * -113575833;
            num1 = num8 ^ num9;
            continue;
          case 3:
            num4 = (uint) activityEvent.ZoomWindowType > 0U ? 1 : 0;
            goto label_5;
          case 4:
            if (activityEvent.ZoomWindowType != ZoomWindowType.WaitingForHost)
            {
              num5 = 0;
              goto label_8;
            }
            else
            {
              num1 = (int) num3 * 1058561412 ^ -819193455;
              continue;
            }
          case 5:
            goto label_1;
          case 6:
            flag2 = false;
            num1 = (int) num3 * 1460984476 ^ 349777301;
            continue;
          case 7:
            num5 = this.JoinInitiated.AddSeconds(5.0) > DateTime.Now ? 1 : 0;
            goto label_8;
          case 8:
            CoreObject.log.Debug((object) (\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3952308142U) + (object) activityEvent));
            num1 = (int) num3 * -1423368047 ^ -1875318348;
            continue;
          case 10:
            flag1 = true;
            num1 = (int) num3 * -453328494 ^ 1989806171;
            continue;
          case 11:
            num1 = (int) num3 * -1032745280 ^ -127350841;
            continue;
          case 12:
            flag4 = activityEvent.Window != null;
            flag5 = WindowHelper.IsWindowVisible(activityEvent.Window.Handle);
            if (activityEvent.ZoomWindowType != ZoomWindowType.AccountPanel)
            {
              num1 = (int) num3 * -418064328 ^ -776083765;
              continue;
            }
            break;
          case 13:
            if (activityEvent.ZoomWindowType != ZoomWindowType.DualVideo)
            {
              num1 = (int) num3 * 314329039 ^ -1035954266;
              continue;
            }
            break;
          case 14:
            flag1 = false;
            num1 = -1830131697;
            continue;
          case 15:
            num1 = (int) num3 * -1614813165 ^ -1207986557;
            continue;
          default:
            goto label_24;
        }
        num4 = 0;
label_5:
        flag2 = num4 != 0;
        num1 = -2081593758;
        continue;
label_8:
        flag3 = num5 != 0;
        num1 = -1657809002;
      }
label_24:
      return flag1;
    }

    private void SetJoinState(ActivityState state, MeetingStatus meetStatus, string newMessage = "")
    {
label_1:
      int num1 = -1097005978;
      while (true)
      {
        int num2 = -1481162184;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -224170405 ^ -1783170813;
            continue;
          case 1:
            num1 = (int) num3 * 2129078730 ^ -965164792;
            continue;
          case 2:
            this.ActivityState = state;
            num1 = (int) num3 * 653080499 ^ -950579042;
            continue;
          case 3:
            this.Status = newMessage;
            num1 = (int) num3 * -272735170 ^ -130417449;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 1250769204 ^ -1504326213;
            continue;
          case 6:
            this.MeetingStatus = meetStatus;
            num1 = (int) num3 * 1945336967 ^ 1657581731;
            continue;
          case 7:
            goto label_3;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    internal override bool Valid()
    {
      return true;
    }

    internal override void ResetProperties()
    {
label_1:
      int num1 = -868961811;
      while (true)
      {
        int num2 = -804928580;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 1886620291 ^ -1226803761;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.MeetingOptions = new MeetingOptions();
            num1 = (int) num3 * -1694310404 ^ -1229810960;
            continue;
          case 4:
            this.Options = new ActivityOptions();
            num1 = (int) num3 * 1426701674 ^ -1436096325;
            continue;
          case 5:
            this.MeetingId = "";
            num1 = (int) num3 * -1196989086 ^ -977877234;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    static void \u206E⁭‏‫⁫‮‎⁯⁬⁪‍⁬‬‏‍‫⁫⁮⁬⁮‫⁭‏‬‎⁬‏‍‏​⁭⁫⁪‏‬⁭⁮‎⁯⁯‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202D⁬⁮‪⁭⁬⁬‬⁪​⁯‬‌‍‌‌‏‬‌‮‫‍‪‪⁯‌⁪‪​‏‪⁫⁭⁪‎⁯‏‌‫⁭‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static bool \u202D‏‌‪‪‬‫⁯​‪‮​‏⁬‮⁭⁮​‭‌⁪‭‏⁫‭‫‪‭‍‎‬​‌‌⁯​‬⁪‏‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static string \u202D‪‪‍‎‌‌​‫⁯‌‬‪⁯‬‎‭⁯⁯⁭⁭‌‪⁪​‏‍⁮‬‌⁫⁫‫⁪‫‭⁬⁮‮⁬‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static string \u202A⁯⁫‍‬‬‪‮⁫⁪‫‫‬⁭⁭‏‮⁪⁮‎‬⁮‮‪⁯‫‭‏‎‍‎‎⁯⁮‍⁬⁬‮‎⁭‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static bool \u200E⁪⁭⁫‫‏‭⁫‮⁫⁪‭‌⁬‬⁪‫‭⁮‫⁪‍‌‎⁪‮‮⁯⁯⁬‬‭​⁯‬‌‍‍‎‎‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static string \u206D‍‭⁯‏‪‏⁯‫‎⁬‍‏⁭‪‌‬⁪‫​⁯‏⁪⁯⁪​​⁬⁯⁮⁬⁯‌​​⁭‭⁪‬‏‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static void \u200F‫‍⁭‭‭‭‪‎‪‫⁭⁯⁮⁬‍⁭⁭‍⁯​​‬⁪‪‮⁮⁬‏⁪‭⁬‮⁭‏⁬‫⁯⁮‍‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static string \u202A‌‌⁭‪‍⁬‫‏‎‮⁭⁬⁭‌‫​‬​‭‬⁭⁮‏‬‎​⁮‮‬‎‌‮⁪‮‮⁭⁫‮⁯‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static void \u200C⁯‬⁮⁬‍‪‌⁭‭‏⁯⁪‪‎⁮⁯‌‭‌‫‎‏‍‏‎‭‭‎‫⁭‫‎‌‮⁯⁮⁬‫⁯‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }

    static bool \u206C‭​‎⁯⁭⁯‍⁯⁬‌‪‎‫‏‫‭‮‎‭⁯⁮⁪‮‎⁭‏⁪‎‎‌​‪​‮‍‌‮‍‭‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u206B‌‪‍‏‍⁬‬‪‍⁭‌‪⁫⁬⁭⁮‌‏⁪‍‭‮​‍‬⁬⁬⁮‏⁯‎⁪⁮‍⁭‭⁫‭‭‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static void \u200F‬‭‭⁪⁮⁬‬⁪‭‭⁯‏⁮‎‪⁮‍⁮⁬‬⁬‪⁫⁮⁯‍‬‭⁮‍‮‭⁫‫⁪‏⁪‭‭‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u206A‪⁬‎⁮‍​⁬‭⁯​‭‬⁯‪⁫‭‏‏‬​‪‪​‮‎‪⁪‏⁭‭⁬⁮‌‬‭​‭‭‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static bool \u206F‫‎‪‪‬‪⁫​⁮​⁫‌​​⁫⁫⁮‭⁭‪‎‏⁮‬‮⁭‪​⁮‭‫⁪‮⁯‎⁮‭⁭‪‮([In] Process obj0)
    {
      return obj0.HasExited;
    }

    static int \u200C⁪‌‎‏⁪‭‌⁫‫‍‏‫⁫‏‎‌‮‭‎‭‏⁭‭‌⁫⁪‭‬⁮‏‏⁫⁭‫⁬‎⁪‬‎‮([In] Process obj0)
    {
      return obj0.Id;
    }

    static bool \u200E‮⁮⁭⁫‍⁭⁯⁬⁯‬‫⁭⁭‮⁪‫‬‎‌​⁭⁯‎‍‌​⁮‎​‭⁯​⁮⁪⁭​⁮‭‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.EndsWith(obj1);
    }

    static string \u206D‪​‬⁬⁮‍‍⁬‎‎⁪​‍‌⁮⁭⁪‪⁬⁮⁮‪⁯⁯‬‌​​⁭⁯‪⁭‫‍‎⁬‬‏‫‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static ProcessStartInfo \u206D‌‮‎​‫‪‍⁪‌‭‭⁮‏​‍‌⁫⁪‏⁬‬⁯‫⁯⁭⁮‪‍⁮‮‭⁬‮‫‭‌⁭‬‪‮()
    {
      return new ProcessStartInfo();
    }

    static void \u206A⁫‪‬‫​⁪‫⁫‮​‍‍‍‬‬‌⁯⁮‏‎⁪⁬​⁯‌‏‌⁪⁪‭‎⁭‌‫‪‬‫‮‎‮([In] ProcessStartInfo obj0, [In] string obj1)
    {
      obj0.FileName = obj1;
    }

    static void \u206F⁭⁫‏⁬‭⁯⁯‪‎⁪⁬⁮‪‬​‮‫⁪‫‭‪⁭‎⁮‍‌​‫⁯⁮⁮‪⁬⁭‌⁮⁫⁬‍‮([In] ProcessStartInfo obj0, [In] string obj1)
    {
      obj0.Arguments = obj1;
    }

    static void \u200D‭‭‬⁯‬‫⁭‪‌‏‍⁮‬‮‬⁬⁮⁪⁬⁪⁫⁪‍⁫​‏‏‮⁯⁬‫‎‍⁬‏⁫‪‪⁮‮([In] ProcessStartInfo obj0, [In] ProcessWindowStyle obj1)
    {
      obj0.WindowStyle = obj1;
    }

    static void \u200B‮‫⁭⁭⁬⁫‌‮⁯⁬⁬‎‌⁭⁭‎‏‫⁮‏⁪⁭⁮⁪‍‭⁯⁮⁭‎⁬⁭‍‪‪‫‬‍‍‮([In] ProcessStartInfo obj0, [In] bool obj1)
    {
      obj0.UseShellExecute = obj1;
    }

    static Process \u206F‌‍⁭‫⁯‫‮⁬⁮‭‫‎‏‭⁮⁯​‮⁬‌⁪‎‍‎‍⁯‬‌⁯‫​‬‏‎‎⁪‍‍‍‮([In] ProcessStartInfo obj0)
    {
      return Process.Start(obj0);
    }

    static Screen \u206B‍⁫‮‮⁮‪‫⁫⁫‭‎⁯‪‍‎⁮‍⁯⁬‍​‬‏⁮‬‎⁪‮⁪‍‬⁮⁬‏⁪‍‭‬‌‮()
    {
      return Screen.PrimaryScreen;
    }

    static Rectangle \u200D⁪‫⁯‍⁯‬‮⁯⁬​⁫‬‍⁫‭⁬⁭‎‫⁫‮⁯​​‭‪‍‎​⁭⁯‎‮⁯‏‭⁮⁮‮([In] Screen obj0)
    {
      return obj0.WorkingArea;
    }
  }
}
