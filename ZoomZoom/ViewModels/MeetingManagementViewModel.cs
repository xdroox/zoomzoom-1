// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.MeetingManagementViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Common;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Utils;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  public class MeetingManagementViewModel : ViewModelBase
  {
    private bool meetingInProgress = false;
    private string selectedMeetingIdText = string.Empty;
    private LockedObservableCollection<StringItem> meetingAutoFindUsers = new LockedObservableCollection<StringItem>();
    private LockedObservableCollection<StringItem> joinUserNames = new LockedObservableCollection<StringItem>();
    private LockedObservableCollection<ZoomButton> meetingButtons = new LockedObservableCollection<ZoomButton>();
    private StringItem selectedMeetingAutoFindUsers = (StringItem) null;
    private string meetingStatusMessage = (string) null;
    private EngineViewModel engineViewModel = (EngineViewModel) null;
    private EngineView engineView = (EngineView) null;
    private bool newMeetingIdInProgress = false;
    private string newMeetingId = "";
    private const string warFile = "c:\\zoomZoom\\war.xml";
    private ZoomMeeting selectedMeeting;
    private ZoomMeeting activeMeeting;
    private ZoomMeeting newMeeting;
    private ZoomMeeting editMeeting;
    private LockedObservableCollection<ZoomMeeting> meetings;
    private ObservableCollection<StringItem> floodActivities;
    private StringItem floodActivitiesSelectedItem;
    private StringItem selectedJoinName;
    private bool dynamicUserName;

    public StringItem SelectedJoinName
    {
      get
      {
        return this.selectedJoinName;
      }
      set
      {
label_1:
        int num1 = 241036729;
        while (true)
        {
          int num2 = 2126289598;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3605424005U));
              num1 = (int) num3 * 129206610 ^ 887216287;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.selectedJoinName = value;
              num1 = (int) num3 * -1419221952 ^ 209516670;
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

    public ZoomMeeting SelectedMeeting
    {
      get
      {
label_1:
        int num1 = 1055528173;
        ZoomMeeting selectedMeeting;
        while (true)
        {
          int num2 = 550507411;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              selectedMeeting = this.selectedMeeting;
              num1 = (int) num3 * 1124553754 ^ 1119760276;
              continue;
            case 3:
              num1 = (int) num3 * 1721119854 ^ 1697810536;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return selectedMeeting;
      }
      set
      {
label_1:
        int num1 = 1172447611;
        while (true)
        {
          int num2 = 2068493371;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 188018641 ^ 1393942622;
              continue;
            case 1:
              flag = this.selectedMeeting == value;
              num1 = (int) num3 * 685272338 ^ 401262992;
              continue;
            case 2:
              int num4 = flag ? 1468748454 : (num4 = 245781210);
              int num5 = (int) num3 * -404024586;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 1183681822 ^ -1235652489;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.selectedMeeting = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4039671299U));
              num1 = 2079507038;
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
    }

    public bool MeetingAutoFindUsersEnabled
    {
      get
      {
        bool findUsersEnabled = Engine.Instance.Settings.MeetingAutoFindUsersEnabled;
label_1:
        int num1 = 431006097;
        while (true)
        {
          int num2 = 173430022;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 523607656 ^ -1754535185;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return findUsersEnabled;
      }
      set
      {
        Engine.Instance.Settings.MeetingAutoFindUsersEnabled = value;
      }
    }

    public LockedObservableCollection<ZoomButton> MeetingButtons
    {
      get
      {
label_1:
        int num1 = 1591234460;
        LockedObservableCollection<ZoomButton> meetingButtons;
        while (true)
        {
          int num2 = 964750257;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingButtons = this.meetingButtons;
              num1 = (int) num3 * -1202738778 ^ -1880733028;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingButtons;
      }
      private set
      {
label_1:
        int num1 = -1043690695;
        while (true)
        {
          int num2 = -650901015;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.meetingButtons = value;
              num1 = (int) num3 * -1472960519 ^ 1072327181;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1724253778U));
      }
    }

    public LockedObservableCollection<ZoomMeeting> Meetings
    {
      get
      {
        LockedObservableCollection<ZoomMeeting> meetings = this.meetings;
label_1:
        int num1 = 1382231314;
        while (true)
        {
          int num2 = 531384670;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -428008260 ^ 119086427;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetings;
      }
      set
      {
label_1:
        int num1 = 1091187916;
        while (true)
        {
          int num2 = 2122615460;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.meetings = value;
              num1 = (int) num3 * 1614523985 ^ 785823783;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(626564989U));
      }
    }

    public bool MeetingInProgress
    {
      get
      {
label_1:
        int num1 = -878115772;
        bool meetingInProgress;
        while (true)
        {
          int num2 = -234377873;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 2064759213 ^ 311174608;
              continue;
            case 3:
              meetingInProgress = this.meetingInProgress;
              num1 = (int) num3 * 214810341 ^ 1891819193;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingInProgress;
      }
      set
      {
        this.meetingInProgress = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3034284578U));
      }
    }

    public StringItem SelectedMeetingAutoFindUsers
    {
      get
      {
label_1:
        int num1 = -1750576860;
        StringItem meetingAutoFindUsers;
        while (true)
        {
          int num2 = -1337907549;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meetingAutoFindUsers = this.selectedMeetingAutoFindUsers;
              num1 = (int) num3 * -961530983 ^ 940420377;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingAutoFindUsers;
      }
      set
      {
        this.selectedMeetingAutoFindUsers = value;
label_1:
        int num1 = 425305115;
        while (true)
        {
          int num2 = 1835675726;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1119706357U));
              num1 = (int) num3 * 1320886521 ^ -372300749;
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

    public LockedObservableCollection<StringItem> MeetingAutoFindUsers
    {
      get
      {
        LockedObservableCollection<StringItem> meetingAutoFindUsers = this.meetingAutoFindUsers;
label_1:
        int num1 = 2080944566;
        while (true)
        {
          int num2 = 190446337;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1725171908 ^ 1375476489;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingAutoFindUsers;
      }
      set
      {
        this.meetingAutoFindUsers = value;
label_1:
        int num1 = -1493107163;
        while (true)
        {
          int num2 = -6799694;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1728966536U));
              num1 = (int) num3 * 1572978473 ^ -1774087414;
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

    public LockedObservableCollection<StringItem> JoinUserNames
    {
      get
      {
label_1:
        int num1 = 917782264;
        LockedObservableCollection<StringItem> joinUserNames;
        while (true)
        {
          int num2 = 803167212;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              joinUserNames = this.joinUserNames;
              num1 = (int) num3 * -1007319362 ^ 590671392;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return joinUserNames;
      }
      set
      {
        this.joinUserNames = value;
      }
    }

    public bool DynamicUserName
    {
      get
      {
label_1:
        int num1 = 2138792960;
        bool joinDynamicUserName;
        while (true)
        {
          int num2 = 167098913;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              joinDynamicUserName = this.Engine.Settings.JoinDynamicUserName;
              num1 = (int) num3 * -1101010379 ^ 1264786231;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return joinDynamicUserName;
      }
      set
      {
        this.Engine.Settings.JoinDynamicUserName = value;
label_1:
        int num1 = 2146522134;
        while (true)
        {
          int num2 = 291998856;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -2044546004 ^ -668289016;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(476670312U));
              num1 = (int) num3 * -1383132968 ^ -790726595;
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
    }

    public new ZoomMeeting ActiveMeeting
    {
      get
      {
label_1:
        int num1 = -406630227;
        ZoomMeeting activeMeeting;
        while (true)
        {
          int num2 = -351623224;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 393264961 ^ -1610406461;
              continue;
            case 1:
              activeMeeting = this.activeMeeting;
              num1 = (int) num3 * 1674351902 ^ -1231609794;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return activeMeeting;
      }
      set
      {
        this.activeMeeting = value;
      }
    }

    public ZoomMeeting NewMeeting
    {
      get
      {
label_1:
        int num1 = -295290176;
        ZoomMeeting newMeeting;
        while (true)
        {
          int num2 = -1790732134;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1875494701 ^ -1947064229;
              continue;
            case 2:
              newMeeting = this.newMeeting;
              num1 = (int) num3 * 2135791316 ^ 238689027;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return newMeeting;
      }
      set
      {
label_1:
        int num1 = 405882961;
        while (true)
        {
          int num2 = 932323691;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              this.newMeeting = value;
              num1 = (int) num3 * 2039735585 ^ 458061529;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2582030099U));
      }
    }

    public ZoomMeeting EditMeeting
    {
      get
      {
        ZoomMeeting editMeeting = this.editMeeting;
label_1:
        int num1 = 1058278004;
        while (true)
        {
          int num2 = 162189581;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -209948447 ^ -75415220;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return editMeeting;
      }
      set
      {
        this.editMeeting = value;
      }
    }

    public string SelectedMeetingIdText
    {
      get
      {
        return this.selectedMeetingIdText;
      }
      set
      {
        this.selectedMeetingIdText = value;
label_1:
        int num1 = -593915359;
        while (true)
        {
          int num2 = -900872818;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -1902422394 ^ 1943326995;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4098069517U));
              num1 = (int) num3 * 929306382 ^ -2066791138;
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

    public string MeetingStatusMessage
    {
      get
      {
        string meetingStatusMessage = this.meetingStatusMessage;
label_1:
        int num1 = 1783142495;
        while (true)
        {
          int num2 = 1135110095;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -750624297 ^ -1809728835;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingStatusMessage;
      }
      set
      {
label_1:
        int num1 = -607804855;
        while (true)
        {
          int num2 = -779456310;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.meetingStatusMessage = value;
              num1 = (int) num3 * -1976198506 ^ -319790379;
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

    public EngineViewModel EngineViewModel
    {
      get
      {
label_1:
        int num1 = -1972717982;
        EngineViewModel engineViewModel;
        while (true)
        {
          int num2 = -1742408327;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -792074987 ^ 628640076;
              continue;
            case 2:
              goto label_1;
            case 3:
              engineViewModel = this.engineViewModel;
              num1 = (int) num3 * 1824519404 ^ 1016682953;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return engineViewModel;
      }
      set
      {
        this.engineViewModel = value;
      }
    }

    public EngineView EngineView
    {
      get
      {
        EngineView engineView = this.engineView;
label_1:
        int num1 = -1477135968;
        while (true)
        {
          int num2 = -414763511;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -2124497741 ^ -1641789306;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return engineView;
      }
      set
      {
        this.engineView = value;
      }
    }

    public bool NewMeetingIdInProgress
    {
      get
      {
label_1:
        int num1 = -667501541;
        bool meetingIdInProgress;
        while (true)
        {
          int num2 = -1606358385;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meetingIdInProgress = this.newMeetingIdInProgress;
              num1 = (int) num3 * 1696894037 ^ -1542094030;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingIdInProgress;
      }
      set
      {
label_1:
        int num1 = -833082186;
        while (true)
        {
          int num2 = -2117878513;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.newMeetingIdInProgress = value;
              num1 = (int) num3 * 1559760965 ^ 1303954736;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1498214144U));
              num1 = (int) num3 * -284975898 ^ -1603557313;
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
    }

    public string ForceMeeting
    {
      get
      {
label_1:
        int num1 = 1860584468;
        string forceMeeting;
        while (true)
        {
          int num2 = 1770092713;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              forceMeeting = this.Engine.Settings.ForceMeeting;
              num1 = (int) num3 * 1149120948 ^ 314474611;
              continue;
            case 2:
              num1 = (int) num3 * -722229717 ^ 2020168999;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return forceMeeting;
      }
      set
      {
label_1:
        int num1 = 675287056;
        while (true)
        {
          int num2 = 1750462588;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.Engine.Settings.ForceMeeting = value;
              num1 = (int) num3 * 922797692 ^ 263643768;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1435234880U));
              num1 = (int) num3 * 526821471 ^ 935378632;
              continue;
            case 4:
              num1 = (int) num3 * 7537925 ^ 1068359460;
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

    public string NewMeetingId
    {
      get
      {
        return this.newMeetingId;
      }
      set
      {
label_1:
        int num1 = 962331284;
        while (true)
        {
          int num2 = 1873484954;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.newMeetingId = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3844741351U));
              num1 = (int) num3 * -192260218 ^ 1832051808;
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

    public ObservableCollection<StringItem> FloodActivities
    {
      get
      {
        bool flag = this.floodActivities == null;
label_1:
        int num1 = 314035896;
        ObservableCollection<StringItem> floodActivities;
        while (true)
        {
          int num2 = 1848765561;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              num1 = (int) num3 * 1569364811 ^ 1508763506;
              continue;
            case 1:
              ((Collection<StringItem>) this.floodActivities).Add(new StringItem(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(234843034U)));
              num1 = (int) num3 * -588332399 ^ -368807912;
              continue;
            case 2:
              num1 = (int) num3 * 437234513 ^ 1639281967;
              continue;
            case 3:
              floodActivities = this.floodActivities;
              num1 = 626185276;
              continue;
            case 4:
              this.floodActivities = new ObservableCollection<StringItem>();
              num1 = (int) num3 * 603367441 ^ 1091526724;
              continue;
            case 5:
              int num4 = flag ? 533957862 : (num4 = 1611982793);
              int num5 = (int) num3 * -1954147921;
              num1 = num4 ^ num5;
              continue;
            case 6:
              goto label_1;
            case 7:
              this.floodActivitiesSelectedItem = ((Collection<StringItem>) this.floodActivities)[0];
              num1 = (int) num3 * 341199124 ^ 794530769;
              continue;
            case 8:
              ((Collection<StringItem>) this.floodActivities).Add(new StringItem(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2402957594U)));
              num1 = (int) num3 * -1650358471 ^ 1080523282;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return floodActivities;
      }
    }

    public StringItem FloodActivitiesSelectedItem
    {
      get
      {
label_1:
        int num1 = 768234962;
        StringItem activitiesSelectedItem;
        while (true)
        {
          int num2 = 617495394;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              activitiesSelectedItem = this.floodActivitiesSelectedItem;
              num1 = (int) num3 * 282906981 ^ 2032830778;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activitiesSelectedItem;
      }
      set
      {
        this.floodActivitiesSelectedItem = value;
      }
    }

    public MeetingManagementViewModel()
    {
      this.LoadCommands();
      this.Meetings = new LockedObservableCollection<ZoomMeeting>((Collection<ZoomMeeting>) this.Engine.Meetings, true);
      if (this.Engine == null)
        return;
      this.Meetings.SetSourceCollection((Collection<ZoomMeeting>) this.Engine.Meetings, true);
      this.MeetingInProgress = this.Engine.ActiveMeeting != null;
      this.Engine.OnMeetingJoined += new EventHandler(this.Engine_OnMeetingJoined);
      this.Engine.OnMeetingLeft += new EventHandler(this.Engine_OnMeetingLeft);
      this.LoadJoinNames();
      this.LoadAutoFindUserNames();
    }

    private void LoadAutoFindUserNames()
    {
label_1:
      int num1 = -1275748075;
      while (true)
      {
        int num2 = -792797220;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.MeetingAutoFindUsers.SetSourceCollection((Collection<StringItem>) this.Engine.Settings.MeetingAutoFindUsers, true);
            num1 = (int) num3 * 788618481 ^ -1499748812;
            continue;
          case 2:
            num1 = (int) num3 * 235622452 ^ 1332013432;
            continue;
          case 4:
            num1 = (int) num3 * -1198819337 ^ 136016719;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      IEnumerator<StringItem> enumerator = ((Collection<StringItem>) this.MeetingAutoFindUsers).GetEnumerator();
      try
      {
label_11:
        int num2 = !MeetingManagementViewModel.\u202B‏‭​‮⁭‭‍‮‬⁯‏⁫‎⁪⁬​‭​⁪⁪‍⁯⁭‏​‬‌‌⁯⁭⁫​​⁫⁯‬‎⁬‎‮((IEnumerator) enumerator) ? -847652032 : (num2 = -515265502);
        while (true)
        {
          int num3 = -792797220;
          uint num4;
          StringItem current;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              num2 = (int) num4 * 1949158704 ^ -1460245251;
              continue;
            case 1:
              goto label_11;
            case 2:
              num2 = (int) num4 * -1707338351 ^ -383482898;
              continue;
            case 3:
              num2 = -515265502;
              continue;
            case 4:
              goto label_20;
            case 5:
              num2 = (int) num4 * 323637383 ^ 1685419992;
              continue;
            case 6:
              current = enumerator.Current;
              num2 = -1281542607;
              continue;
            case 7:
              current.PropertyChanged += new PropertyChangedEventHandler(this.FindUsers_PropertyChanged);
              num2 = (int) num4 * 1751323532 ^ 191048730;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_20:;
      }
      finally
      {
        if (enumerator != null)
        {
label_18:
          int num2 = -511362543;
          while (true)
          {
            int num3 = -792797220;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_18;
              case 1:
                MeetingManagementViewModel.\u202A‮⁪‫‌​⁯‎‎‏‬⁪⁭⁪‏‎‎‪‎‬⁪⁬‭‬⁫⁫⁪‮‫‍‎‭‭‮‬‭⁭‪‌‍‮((IDisposable) enumerator);
                num2 = (int) num4 * 1163601748 ^ -1993614121;
                continue;
              case 3:
                num2 = (int) num4 * 1575207756 ^ -756888350;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
    }

    private void LoadJoinNames()
    {
label_1:
      int num1 = -919392936;
      while (true)
      {
        int num2 = -643392719;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            this.JoinUserNames.SetSourceCollection((Collection<StringItem>) this.Engine.Settings.JoinUserNames, true);
            num1 = (int) num3 * -885890177 ^ -453106323;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -858178675 ^ -390904618;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      IEnumerator<StringItem> enumerator = ((Collection<StringItem>) this.JoinUserNames).GetEnumerator();
      try
      {
label_10:
        int num2 = !MeetingManagementViewModel.\u202B‏‭​‮⁭‭‍‮‬⁯‏⁫‎⁪⁬​‭​⁪⁪‍⁯⁭‏​‬‌‌⁯⁭⁫​​⁫⁯‬‎⁬‎‮((IEnumerator) enumerator) ? -38844067 : (num2 = -830447924);
        while (true)
        {
          int num3 = -643392719;
          uint num4;
          StringItem current;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_17;
            case 1:
              current = enumerator.Current;
              num2 = -1544766340;
              continue;
            case 2:
              num2 = -830447924;
              continue;
            case 3:
              num2 = (int) num4 * 1869111820 ^ -769980865;
              continue;
            case 4:
              current.PropertyChanged += new PropertyChangedEventHandler(this.JoinUserName_PropertyChanged);
              num2 = (int) num4 * 1368488672 ^ 251851312;
              continue;
            case 5:
              goto label_10;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_17:;
      }
      finally
      {
        if (enumerator != null)
        {
label_15:
          int num2 = -634885308;
          while (true)
          {
            int num3 = -643392719;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_15;
              case 1:
                MeetingManagementViewModel.\u202A‮⁪‫‌​⁯‎‎‏‬⁪⁭⁪‏‎‎‪‎‬⁪⁬‭‬⁫⁫⁪‮‫‍‎‭‭‮‬‭⁭‪‌‍‮((IDisposable) enumerator);
                num2 = (int) num4 * -1845980452 ^ 10966973;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    private void JoinUserName_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      this.Engine.Settings.JoinUserNames = (ObservableCollection<StringItem>) this.JoinUserNames;
    }

    private void FindUsers_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      this.Engine.Settings.JoinUserNames = (ObservableCollection<StringItem>) this.MeetingAutoFindUsers;
    }

    internal void Unload()
    {
      bool initialized = this.Initialized;
label_1:
      int num1 = 976063332;
      while (true)
      {
        int num2 = 1898040195;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            MeetingManagementViewModel.\u202D‍‮⁪‪‬⁬⁮‏‏‪‍⁮⁮‭‎​​‪⁮⁬‪⁭⁫‮‭‌‪⁬⁫⁫‬⁫‬⁬​‌‎‭‪‮(ViewModelBase.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2938930245U));
            num1 = (int) num3 * -1703583657 ^ 829240880;
            continue;
          case 3:
            int num4 = initialized ? -201734092 : (num4 = -296410965);
            int num5 = (int) num3 * 1810381327;
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

    private void Engine_OnMeetingLeft(object sender, EventArgs e)
    {
label_1:
      int num1 = -949329167;
      while (true)
      {
        int num2 = -311543118;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1177590244 ^ 1170819168;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.MeetingInProgress = false;
            num1 = (int) num3 * 1169693231 ^ 1025720714;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void Engine_OnMeetingJoined(object sender, EventArgs e)
    {
      this.MeetingInProgress = true;
    }

    private void LoadCommands()
    {
      this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1221250182U), (Action<object>) (x =>
      {
        this.ExecuteJoinMeeting();
label_1:
        int num1 = -793435059;
        while (true)
        {
          int num2 = -1542403780;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 286527342 ^ 1723769860;
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
      }), (Predicate<object>) (x => this.CanJoinMeeting()));
      this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4250023906U), (Action<object>) (x => this.ExecuteJoinAttackMeeting()), (Predicate<object>) (x => this.CanJoinAttackMeeting()));
label_1:
      int num4 = 905971327;
      while (true)
      {
        int num1 = 2016256566;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 16U)
        {
          case 0:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(190636339U), (Action<object>) (x =>
            {
              this.ExecuteNewJoinUserName();
label_1:
              int num1 = -1296024991;
              while (true)
              {
                int num2 = -712894353;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    num1 = (int) num3 * -1742254675 ^ -905172717;
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
            }), (Predicate<object>) (x => this.CanNewJoinUserName()));
            num4 = (int) num2 * -958138756 ^ 874409339;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.Commands.AddCommand(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1282045753U), (Action<object>) (x => this.ExecuteFloodSelection()), (Predicate<object>) (x => this.CanFloodSelection()));
            num4 = (int) num2 * 1904600910 ^ -1467598084;
            continue;
          case 3:
            this.Commands.AddCommand(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3012377377U), (Action<object>) (x => this.ExecuteDeleteMeeting()), (Predicate<object>) (x => this.CanDeleteMeeting()));
            num4 = (int) num2 * -371020146 ^ -2124538237;
            continue;
          case 4:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1435234880U), (Action<object>) (x => this.ExecuteForceMeeting()), (Predicate<object>) (x => this.CanForceMeeting()));
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3046119591U), (Action<object>) (x =>
            {
              this.ExecuteWarMeeting();
label_1:
              int num1 = 463649093;
              while (true)
              {
                int num2 = 2088452678;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    num1 = (int) num3 * -107782287 ^ -1219452794;
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
            }), (Predicate<object>) (x => this.CanWarMeeting()));
            num4 = (int) num2 * -730440050 ^ -1515239044;
            continue;
          case 5:
            goto label_1;
          case 6:
            num4 = (int) num2 * 1764022488 ^ -1849348963;
            continue;
          case 7:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(509403423U), (Action<object>) (x =>
            {
              this.ExecuteEditMeeting();
label_1:
              int num1 = 1189648491;
              while (true)
              {
                int num2 = 1275216962;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    num1 = (int) num3 * -1475747670 ^ 1782791700;
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
            }), (Predicate<object>) (x => this.CanEditMeeting()));
            num4 = (int) num2 * -24029333 ^ -476661224;
            continue;
          case 8:
            num4 = (int) num2 * -1684551039 ^ -1517004144;
            continue;
          case 9:
            num4 = (int) num2 * 436710446 ^ -950402190;
            continue;
          case 10:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4061737653U), (Action<object>) (x =>
            {
              this.ExecuteHammerMeeting();
label_1:
              int num1 = 1410946273;
              while (true)
              {
                int num2 = 863413996;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    num1 = (int) num3 * 1834692307 ^ -1755914701;
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
            }), (Predicate<object>) (x => this.CanHammerMeeting()));
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1918887371U), (Action<object>) (x =>
            {
              this.ExecuteFloodMeeting();
label_1:
              int num1 = 919616779;
              while (true)
              {
                int num2 = 2012900204;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num1 = (int) num3 * -604514345 ^ -1093783415;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanFloodMeeting()));
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1217704855U), (Action<object>) (x => this.ExecutePeekMeeting()), (Predicate<object>) (x => this.CanPeekMeeting()));
            num4 = (int) num2 * -2023017654 ^ -297938154;
            continue;
          case 11:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2240728976U), (Action<object>) (x =>
            {
              this.ExecuteNewMeeting();
label_1:
              int num1 = 1025474344;
              while (true)
              {
                int num2 = 1149128353;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num1 = (int) num3 * -1275571486 ^ 1215056999;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanNewMeeting()));
            num4 = (int) num2 * -1489845609 ^ -850832452;
            continue;
          case 12:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4195896642U), (Action<object>) (x => this.ExecuteDeleteJoinUserName()), (Predicate<object>) (x => this.CanDeleteJoinUserName()));
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2685182800U), (Action<object>) (x => this.ExecuteNewFindUserName()), (Predicate<object>) (x => this.CanNewFindUserName()));
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2176182659U), (Action<object>) (x => this.ExecuteDeleteFindUserName()), (Predicate<object>) (x => this.CanDeleteFindUserName()));
            num4 = (int) num2 * -415295261 ^ 1632426371;
            continue;
          case 13:
            num4 = (int) num2 * 211601616 ^ 506821994;
            continue;
          case 14:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3727337273U), (Action<object>) (x => this.ExecuteNewMeetingIdCancel()), (Predicate<object>) (x => this.CanNewMeetingIdCancel()));
            num4 = (int) num2 * 630735214 ^ -1555426590;
            continue;
          case 15:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2710409922U), (Action<object>) (x =>
            {
              this.ExecuteNewMeetingIdSave();
label_1:
              int num1 = -1142609289;
              while (true)
              {
                int num2 = -253296630;
                uint num3;
                switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    num1 = (int) num3 * -1818044354 ^ 1419752322;
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
            }), (Predicate<object>) (x => this.CanNewMeetingIdSave()));
            num4 = (int) num2 * 733456485 ^ -434527611;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return;
label_3:;
    }

    private bool CanJoinAttackMeeting()
    {
label_1:
      int num1 = 1630104389;
      bool flag;
      while (true)
      {
        int num2 = 1652259768;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            if (this.SelectedMeeting != null)
            {
              num1 = (int) num3 * 1576941553 ^ -1738552882;
              continue;
            }
            num4 = 0;
            break;
          case 2:
            goto label_1;
          case 3:
            num4 = this.Engine.ActiveActivity == null ? 1 : 0;
            break;
          default:
            goto label_8;
        }
        flag = num4 != 0;
        num1 = 1397583944;
      }
label_8:
      return flag;
    }

    private void ExecuteJoinAttackMeeting()
    {
      try
      {
label_2:
        int num1 = 1613624479;
        while (true)
        {
          int num2 = 416546377;
          uint num3;
          JoinAttack joinAttack;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_14;
            case 2:
              num1 = (int) num3 * -1831834571 ^ -1649380683;
              continue;
            case 3:
              joinAttack = new JoinAttack(this.SelectedMeeting);
              num1 = (int) num3 * 1061799829 ^ -199924214;
              continue;
            case 4:
              this.AddActivity((ActivityBase) joinAttack);
              num1 = (int) num3 * 1738246574 ^ 1437045207;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_14:;
      }
      catch (Exception ex)
      {
label_10:
        int num1 = 669227754;
        while (true)
        {
          int num2 = 416546377;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_10;
            case 1:
              goto label_8;
            case 2:
              MeetingManagementViewModel.\u200E⁫⁪⁫⁯‬‏‌‏⁯‍‭‌​‭‍⁭‫‍‭‫‮⁬⁭‮​‌⁭‭‮‎⁬‪⁯‏‌‪⁮‮⁯‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * 808468226 ^ -1947528238;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_8:;
      }
    }

    private bool CanDeleteFindUserName()
    {
label_1:
      int num1 = -610543209;
      bool flag;
      while (true)
      {
        int num2 = -1526784609;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = this.SelectedMeetingAutoFindUsers != null;
            num1 = (int) num3 * -1076117850 ^ -726572652;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteDeleteFindUserName()
    {
      bool flag = this.SelectedMeetingAutoFindUsers != null;
label_1:
      int num1 = 1789989917;
      while (true)
      {
        int num2 = 480495894;
        uint num3;
        int index;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1728966536U));
            num1 = (int) num3 * 1820363847 ^ -323075798;
            continue;
          case 1:
            int num4 = !flag ? 1603427628 : (num4 = 1786590720);
            int num5 = (int) num3 * -584388997;
            num1 = num4 ^ num5;
            continue;
          case 2:
            index = ((Collection<StringItem>) this.MeetingAutoFindUsers).IndexOf(this.SelectedMeetingAutoFindUsers);
            num1 = (int) num3 * -1893115795 ^ 1635030472;
            continue;
          case 3:
            ((Collection<StringItem>) this.MeetingAutoFindUsers).Remove(this.SelectedMeetingAutoFindUsers);
            this.Engine.Settings.MeetingAutoFindUsers = (ObservableCollection<StringItem>) this.MeetingAutoFindUsers;
            num1 = (int) num3 * 593321339 ^ -245227837;
            continue;
          case 4:
            num1 = 1489777509;
            continue;
          case 5:
            int num6 = index < ((Collection<StringItem>) this.MeetingAutoFindUsers).Count ? 1780649557 : (num6 = 124152389);
            int num7 = (int) num3 * -974557535;
            num1 = num6 ^ num7;
            continue;
          case 6:
            this.Engine.Settings.MeetingAutoFindUsers = (ObservableCollection<StringItem>) this.MeetingAutoFindUsers;
            this.SelectedMeetingAutoFindUsers = (StringItem) null;
            num1 = (int) num3 * -1242215511 ^ -1794092557;
            continue;
          case 7:
            this.SelectedMeetingAutoFindUsers = ((Collection<StringItem>) this.MeetingAutoFindUsers)[index];
            num1 = (int) num3 * 711080882 ^ -758107568;
            continue;
          case 8:
            ((Collection<StringItem>) this.MeetingAutoFindUsers).Remove(this.SelectedMeetingAutoFindUsers);
            num1 = (int) num3 * 2016916430 ^ -1769691758;
            continue;
          case 9:
            num1 = (int) num3 * 1840036479 ^ 1379153257;
            continue;
          case 10:
            goto label_3;
          case 11:
            goto label_1;
          case 12:
            num1 = (int) num3 * -1799690480 ^ -844617709;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    private bool CanNewFindUserName()
    {
label_1:
      int num1 = -1323873609;
      bool flag;
      while (true)
      {
        int num2 = -449313102;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 936323243 ^ 1145043157;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            flag = !Enumerable.Any<StringItem>((IEnumerable<M0>) this.MeetingAutoFindUsers, (Func<M0, bool>) (MeetingManagementViewModel.\u003C\u003Ec.\u003C\u003E9__99_0 ?? (MeetingManagementViewModel.\u003C\u003Ec.\u003C\u003E9__99_0 = new Func<StringItem, bool>((object) MeetingManagementViewModel.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCanNewFindUserName\u003Eb__99_0)))));
            num1 = -196598742;
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

    private void ExecuteNewFindUserName()
    {
      StringItem stringItem = new StringItem(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3941573281U));
label_1:
      int num1 = -497151109;
      while (true)
      {
        int num2 = -127004439;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 799560490 ^ 1005361805;
            continue;
          case 2:
            ((Collection<StringItem>) this.MeetingAutoFindUsers).Add(stringItem);
            num1 = (int) num3 * -471831751 ^ -326160470;
            continue;
          case 3:
            goto label_3;
          case 4:
            stringItem.PropertyChanged += new PropertyChangedEventHandler(this.FindUsers_PropertyChanged);
            num1 = (int) num3 * -67598469 ^ 959420796;
            continue;
          case 5:
            this.SelectedJoinName = stringItem;
            num1 = (int) num3 * 818076704 ^ 1434536360;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private bool CanDeleteJoinUserName()
    {
label_1:
      int num1 = 1896093058;
      bool flag;
      while (true)
      {
        int num2 = 1469307832;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * 1972252594 ^ 1036243150;
            continue;
          case 2:
            flag = this.SelectedJoinName != null;
            num1 = (int) num3 * -440069338 ^ -1842955451;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteDeleteJoinUserName()
    {
label_1:
      int num1 = 1015139084;
      while (true)
      {
        int num2 = 1471953680;
        uint num3;
        int index;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            num1 = 1071924001;
            continue;
          case 1:
            this.SelectedJoinName = ((Collection<StringItem>) this.JoinUserNames)[index];
            num1 = (int) num3 * 272640015 ^ -2056851263;
            continue;
          case 2:
            num1 = (int) num3 * 521330669 ^ 176690086;
            continue;
          case 3:
            this.Engine.Settings.JoinUserNames = (ObservableCollection<StringItem>) this.JoinUserNames;
            this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2515229722U));
            num1 = (int) num3 * 1441915549 ^ 597874058;
            continue;
          case 4:
            int num4 = index < ((Collection<StringItem>) this.JoinUserNames).Count ? -579713017 : (num4 = -979133000);
            int num5 = (int) num3 * 1966989816;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_3;
          case 6:
            int num6 = this.SelectedJoinName == null ? -48726159 : (num6 = -1904571939);
            int num7 = (int) num3 * 1157798732;
            num1 = num6 ^ num7;
            continue;
          case 7:
            index = ((Collection<StringItem>) this.JoinUserNames).IndexOf(this.SelectedJoinName);
            num1 = (int) num3 * -577025026 ^ -1064375380;
            continue;
          case 8:
            num1 = (int) num3 * 1261314033 ^ 2076094341;
            continue;
          case 9:
            ((Collection<StringItem>) this.JoinUserNames).Remove(this.SelectedJoinName);
            num1 = (int) num3 * 1424697520 ^ -6050090;
            continue;
          case 10:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    private bool CanNewJoinUserName()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      bool flag = !Enumerable.Any<StringItem>((IEnumerable<M0>) this.JoinUserNames, (Func<M0, bool>) (MeetingManagementViewModel.\u003C\u003Ec.\u003C\u003E9__103_0 ?? (MeetingManagementViewModel.\u003C\u003Ec.\u003C\u003E9__103_0 = new Func<StringItem, bool>((object) MeetingManagementViewModel.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCanNewJoinUserName\u003Eb__103_0)))));
label_1:
      int num1 = 642990592;
      while (true)
      {
        int num2 = 489331451;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1039843420 ^ -1948707403;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteNewJoinUserName()
    {
label_1:
      int num1 = -61248520;
      while (true)
      {
        int num2 = -1245302043;
        uint num3;
        StringItem stringItem;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            ((Collection<StringItem>) this.JoinUserNames).Add(stringItem);
            num1 = (int) num3 * -973902096 ^ -1679365825;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.SelectedJoinName = stringItem;
            num1 = (int) num3 * -1847743404 ^ 1670922556;
            continue;
          case 4:
            stringItem.PropertyChanged += new PropertyChangedEventHandler(this.JoinUserName_PropertyChanged);
            num1 = (int) num3 * 2045697521 ^ 1189804743;
            continue;
          case 5:
            num1 = (int) num3 * 1761966882 ^ -873013622;
            continue;
          case 6:
            stringItem = new StringItem(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1927989369U));
            num1 = (int) num3 * -1302576897 ^ -335311026;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private bool CanFloodSelection()
    {
label_1:
      int num1 = -1681489269;
      bool flag;
      while (true)
      {
        int num2 = -1847529648;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.SelectedMeeting != null;
            num1 = (int) num3 * -576313001 ^ 1770849339;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteFloodSelection()
    {
label_1:
      int num1 = -525507530;
      while (true)
      {
        int num2 = -396343037;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            this.Engine.AddActivity((ActivityBase) new FloodChat(this.Engine.Settings.FloodOptions_MessageContent, 0, ""), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1599691866U));
            num1 = (int) num3 * -299526060 ^ -1660501864;
            continue;
          case 1:
            int num4 = flag ? -789346049 : (num4 = -269935222);
            int num5 = (int) num3 * -279154773;
            num1 = num4 ^ num5;
            continue;
          case 2:
            flag = MeetingManagementViewModel.\u200D⁫‪‬⁭⁪⁮​‪‬⁯‏‬‪‏⁬‮⁫⁭‫‫‪‏⁮‭‌‏‌⁬⁮‎‍‍‪⁫​‏⁭⁮‪‮(this.FloodActivitiesSelectedItem.Value, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(556953158U));
            num1 = -503709838;
            continue;
          case 3:
            num1 = (int) num3 * 1161042132 ^ 146914463;
            continue;
          case 4:
            goto label_3;
          case 5:
            int num6 = !MeetingManagementViewModel.\u200D⁫‪‬⁭⁪⁮​‪‬⁯‏‬‪‏⁬‮⁫⁭‫‫‪‏⁮‭‌‏‌⁬⁮‎‍‍‪⁫​‏⁭⁮‪‮(this.FloodActivitiesSelectedItem.Value, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(234843034U)) ? 731800693 : (num6 = 547686967);
            int num7 = (int) num3 * 1683714232;
            num1 = num6 ^ num7;
            continue;
          case 6:
            num1 = -888659055;
            continue;
          case 7:
            num1 = (int) num3 * -10706374 ^ -729538735;
            continue;
          case 8:
            num1 = (int) num3 * 330041110 ^ -1546075153;
            continue;
          case 9:
            goto label_1;
          case 10:
            num1 = (int) num3 * 1715998319 ^ -1392842975;
            continue;
          case 11:
            num1 = (int) num3 * 1199881456 ^ -2075536408;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    private void CreateActivityView_Closed(object sender, EventArgs e)
    {
    }

    private bool CanWarMeeting()
    {
label_1:
      int num1 = 1760350244;
      bool flag;
      while (true)
      {
        int num2 = 520309025;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.SelectedMeeting != null;
            num1 = (int) num3 * 1421908935 ^ -456410863;
            continue;
          case 3:
            num1 = (int) num3 * 1739884469 ^ 353209316;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteWarMeeting()
    {
      WarSettings warSettings = new WarSettings();
label_1:
      int num1 = -477236153;
      while (true)
      {
        int num2 = -592148195;
        uint num3;
        string str;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            warSettings.FloodHostAfterJoin = false;
            num1 = (int) num3 * 425874253 ^ -772097117;
            continue;
          case 1:
            warSettings.FloodAfterJoin = false;
            num1 = (int) num3 * -574978249 ^ -1732069353;
            continue;
          case 2:
            num1 = (int) num3 * 2054763770 ^ -47507155;
            continue;
          case 3:
            warSettings.FindButtonsAfterJoin = true;
            num1 = (int) num3 * -1878724185 ^ -578133063;
            continue;
          case 4:
            str = WarSettings.XmlSerializeToString((object) warSettings);
            CoreUtils.DeleteFile(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3301895281U));
            num1 = (int) num3 * 733264322 ^ -743957844;
            continue;
          case 6:
            warSettings.MeetingHoldAction = this.Engine.Settings.MeetingHoldAction;
            num1 = (int) num3 * 2022888648 ^ 1179307553;
            continue;
          case 7:
            num1 = (int) num3 * -2082485694 ^ 2126845094;
            continue;
          case 8:
            num1 = (int) num3 * -1622663666 ^ 1114625675;
            continue;
          case 9:
            MeetingManagementViewModel.\u200D⁫‍‏⁪‌‫⁯‏‍⁬⁫⁬‏⁭⁫⁫‪⁭‍⁯⁫‭‍⁪‭⁬⁮‪⁯⁬⁯⁯⁪‪‬⁫‫‌‍‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(908712843U), str);
            num1 = (int) num3 * -1236296977 ^ -1029294291;
            continue;
          case 10:
            warSettings.AutoAttendent = true;
            num1 = (int) num3 * -1864137186 ^ -527015086;
            continue;
          case 11:
            warSettings.MeetingRemovalAction = this.Engine.Settings.MeetingRemovalAction;
            warSettings.WarEnabled = true;
            num1 = (int) num3 * 1852569171 ^ -197770018;
            continue;
          case 12:
            num1 = (int) num3 * 1589314666 ^ 1598049262;
            continue;
          case 13:
            num1 = (int) num3 * 1821037537 ^ 1016137520;
            continue;
          case 14:
            warSettings.ForceMeeting = this.SelectedMeeting.MeetingId;
            num1 = (int) num3 * 50832541 ^ 718704051;
            continue;
          case 15:
            goto label_1;
          default:
            goto label_17;
        }
      }
label_17:
      MeetingManagementViewModel.\u202D⁫‮‪‫‪‌​‌⁯⁬‌‏​⁫‫​⁯⁮⁮⁫‬⁭‮‭⁬⁯​‬⁪‎⁫‌⁯‮‮‌‏​⁮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3301895281U));
    }

    private bool CanForceMeeting()
    {
      bool flag = this.SelectedMeeting != null;
label_1:
      int num1 = -1895385299;
      while (true)
      {
        int num2 = -132300950;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1035789131 ^ 514917580;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteForceMeeting()
    {
label_1:
      int num1 = 438768624;
      while (true)
      {
        int num2 = 15342224;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 828074896 ^ 344087587;
            continue;
          case 1:
            flag = this.SelectedMeeting != null;
            num1 = (int) num3 * 1143405324 ^ 636405713;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -949458177 ^ -1366112061;
            continue;
          case 4:
            this.Engine.Settings.ForceMeeting = this.SelectedMeeting.MeetingId;
            this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(613213180U));
            num1 = (int) num3 * 1167496698 ^ 1618488734;
            continue;
          case 5:
            int num4 = !flag ? -873976299 : (num4 = -789541882);
            int num5 = (int) num3 * -1960725722;
            num1 = num4 ^ num5;
            continue;
          case 6:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private bool CanNewMeetingIdCancel()
    {
      return this.NewMeetingIdInProgress;
    }

    private void ExecuteNewMeetingIdCancel()
    {
label_1:
      int num1 = 1400147854;
      while (true)
      {
        int num2 = 1060447381;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * 982584338 ^ 281963836;
            continue;
          case 1:
            this.NewMeetingId = "";
            num1 = (int) num3 * 1183134228 ^ -1684329211;
            continue;
          case 2:
            this.NewMeetingIdInProgress = false;
            num1 = (int) num3 * 1739122083 ^ -531504944;
            continue;
          case 3:
            goto label_3;
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

    private bool CanNewMeetingIdSave()
    {
      if (MeetingManagementViewModel.\u206E⁫⁪⁪‌⁪​‍‭‫​‭‌⁭⁯‎​‌⁫‎‌‪‫‌‍⁬‎‍⁮‮‏‏⁯⁫‮⁪‮‬⁬⁭‮(this.NewMeetingId) <= 7)
        goto label_4;
label_1:
      int num1 = -1748813464;
label_2:
      while (true)
      {
        int num2 = -1325284571;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1850348438 ^ -297418830;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      int num4 = MeetingManagementViewModel.\u206E⁫⁪⁪‌⁪​‍‭‫​‭‌⁭⁯‎​‌⁫‎‌‪‫‌‍⁬‎‍⁮‮‏‏⁯⁫‮⁪‮‬⁬⁭‮(this.NewMeetingId) < 12 ? 1 : 0;
      goto label_5;
label_7:
      bool flag;
      return flag;
label_4:
      num4 = 0;
label_5:
      flag = num4 != 0;
      num1 = -1119157189;
      goto label_2;
    }

    private void ExecuteNewMeetingIdSave()
    {
      ZoomMeeting meeting = this.Engine.GetMeeting(this.NewMeetingId, true);
label_1:
      int num1 = 1041458475;
      while (true)
      {
        int num2 = 560127538;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            int num4 = !flag ? -1709074405 : (num4 = -290183793);
            int num5 = (int) num3 * 800067395;
            num1 = num4 ^ num5;
            continue;
          case 3:
            this.NewMeetingIdInProgress = false;
            num1 = (int) num3 * -1930150405 ^ 694152479;
            continue;
          case 4:
            num1 = (int) num3 * 1174271610 ^ 616059999;
            continue;
          case 5:
            this.AddMeeting(meeting);
            this.NewMeetingId = "";
            num1 = (int) num3 * -1786602926 ^ -920382210;
            continue;
          case 6:
            this.SelectedMeeting = meeting;
            num1 = (int) num3 * 1030231385 ^ 2100431327;
            continue;
          case 7:
            num1 = (int) num3 * 1547569250 ^ -369676664;
            continue;
          case 8:
            num1 = (int) num3 * -186152992 ^ -2129893623;
            continue;
          case 9:
            flag = meeting != null;
            num1 = (int) num3 * 500342000 ^ 1886045117;
            continue;
          case 10:
            num1 = (int) num3 * -1338461639 ^ -729338890;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    private bool CanPeekMeeting()
    {
label_1:
      int num1 = 733597303;
      bool flag;
      while (true)
      {
        int num2 = 2137886660;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1939728868 ^ 1246813281;
            continue;
          case 3:
            flag = this.SelectedMeeting != null;
            num1 = (int) num3 * 211788955 ^ -844701589;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecutePeekMeeting()
    {
label_1:
      int num1 = 1197777622;
      while (true)
      {
        int num2 = 904718449;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1794909985 ^ -1814106114;
            continue;
          case 3:
            Engine.Instance.AddActivity((ActivityBase) new PeekMeeting(this.SelectedMeeting), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3066797154U));
            num1 = (int) num3 * -1676953152 ^ 1024506415;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private bool CanNewMeeting()
    {
label_1:
      int num1 = -1918694603;
      bool flag1;
      while (true)
      {
        int num2 = -2117497194;
        uint num3;
        bool flag2;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            num1 = (int) num3 * -946761404 ^ 612978291;
            continue;
          case 1:
            num1 = (int) num3 * -462519985 ^ -1526956497;
            continue;
          case 2:
            flag2 = MeetingManagementViewModel.\u206E⁫⁪⁪‌⁪​‍‭‫​‭‌⁭⁯‎​‌⁫‎‌‪‫‌‍⁬‎‍⁮‮‏‏⁯⁫‮⁪‮‬⁬⁭‮(this.SelectedMeetingIdText) < 7;
            num1 = (int) num3 * -148276723 ^ -1633648833;
            continue;
          case 3:
            num4 = !MeetingManagementViewModel.\u200C‏⁭‭‫‪‎⁮‎‏⁭‌‍⁬‎​‫‮‏‬⁬‎‬⁫⁪‎‪⁭⁭⁬‍⁭‌⁪‍⁯‬⁪‮‎‮(this.SelectedMeetingIdText) ? 1 : 0;
            break;
          case 4:
            flag1 = true;
            num1 = (int) num3 * 666167409 ^ -1513680366;
            continue;
          case 5:
            num1 = -1703850960;
            continue;
          case 6:
            flag1 = false;
            num1 = -519269604;
            continue;
          case 7:
            int num5 = flag2 ? -1717437592 : (num5 = -1876706971);
            int num6 = (int) num3 * 514167105;
            num1 = num5 ^ num6;
            continue;
          case 8:
            flag3 = MeetingManagementViewModel.\u206E⁫⁪⁪‌⁪​‍‭‫​‭‌⁭⁯‎​‌⁫‎‌‪‫‌‍⁬‎‍⁮‮‏‏⁯⁫‮⁪‮‬⁬⁭‮(this.SelectedMeetingIdText) <= 10;
            num1 = -1047448569;
            continue;
          case 9:
            if (this.SelectedMeeting != null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1126425823 ^ -1226157092;
            continue;
          case 10:
            num1 = (int) num3 * -400284545 ^ 855274696;
            continue;
          case 11:
            this.MeetingStatusMessage = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(777715800U);
            num1 = (int) num3 * 1170098787 ^ -803493738;
            continue;
          case 13:
            int num7 = !flag3 ? -1870106793 : (num7 = -764365366);
            int num8 = (int) num3 * -805205513;
            num1 = num7 ^ num8;
            continue;
          case 14:
            num1 = (int) num3 * -327107139 ^ 403609428;
            continue;
          case 15:
            num1 = (int) num3 * -853154955 ^ 1979435752;
            continue;
          case 16:
            goto label_1;
          case 17:
            this.MeetingStatusMessage = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3546628860U);
            num1 = (int) num3 * -1215974458 ^ -1831147825;
            continue;
          case 18:
            num1 = -1751288582;
            continue;
          case 19:
            this.MeetingStatusMessage = (string) null;
            num1 = (int) num3 * 1840887394 ^ -1670819567;
            continue;
          default:
            goto label_24;
        }
        int num9;
        num1 = num9 = num4 == 0 ? -1703850960 : (num9 = -1613267016);
      }
label_24:
      return flag1;
    }

    private void ExecuteNewMeeting()
    {
label_1:
      int num1 = 1757978448;
      while (true)
      {
        int num2 = 2131410800;
        uint num3;
        ZoomMeeting meeting;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            num1 = (int) num3 * 240701871 ^ -874680800;
            continue;
          case 1:
            num1 = (int) num3 * 1912558359 ^ -895932366;
            continue;
          case 2:
            int num5 = this.Engine == null ? 2113474513 : (num5 = 1528362178);
            int num6 = (int) num3 * 1852535312;
            num1 = num5 ^ num6;
            continue;
          case 3:
            goto label_1;
          case 4:
            if (MeetingManagementViewModel.\u206E⁫⁪⁪‌⁪​‍‭‫​‭‌⁭⁯‎​‌⁫‎‌‪‫‌‍⁬‎‍⁮‮‏‏⁯⁫‮⁪‮‬⁬⁭‮(this.SelectedMeetingIdText) > 7)
            {
              num1 = (int) num3 * 2091251828 ^ 1949910384;
              continue;
            }
            break;
          case 5:
            int num7 = !flag1 ? -164589378 : (num7 = -1285712590);
            int num8 = (int) num3 * 1897698276;
            num1 = num7 ^ num8;
            continue;
          case 6:
            if (this.SelectedMeeting == null)
            {
              num1 = 488995979;
              continue;
            }
            break;
          case 7:
            meeting = this.Engine.GetMeeting(this.SelectedMeetingIdText, true);
            flag1 = meeting != null;
            num1 = (int) num3 * 208771999 ^ -2052181642;
            continue;
          case 8:
            num1 = 789878721;
            continue;
          case 9:
            if (!MeetingManagementViewModel.\u200C‏⁭‭‫‪‎⁮‎‏⁭‌‍⁬‎​‫‮‏‬⁬‎‬⁫⁪‎‪⁭⁭⁬‍⁭‌⁪‍⁯‬⁪‮‎‮(this.SelectedMeetingIdText))
            {
              num1 = (int) num3 * 934449429 ^ 1083644107;
              continue;
            }
            break;
          case 10:
            this.AddMeeting(meeting);
            num1 = (int) num3 * 1671420342 ^ -1863424615;
            continue;
          case 11:
            num1 = (int) num3 * 826651279 ^ -1708544602;
            continue;
          case 12:
            int num9 = flag2 ? 2079810635 : (num9 = 394768437);
            int num10 = (int) num3 * 2002115742;
            num1 = num9 ^ num10;
            continue;
          case 13:
            num1 = (int) num3 * 1989602387 ^ -2051112462;
            continue;
          case 14:
            num4 = MeetingManagementViewModel.\u206E⁫⁪⁪‌⁪​‍‭‫​‭‌⁭⁯‎​‌⁫‎‌‪‫‌‍⁬‎‍⁮‮‏‏⁯⁫‮⁪‮‬⁬⁭‮(this.SelectedMeetingIdText) <= 10 ? 1 : 0;
            goto label_21;
          case 15:
            goto label_3;
          case 16:
            num1 = (int) num3 * 543632702 ^ 1675736746;
            continue;
          case 17:
            this.SelectedMeeting = meeting;
            num1 = (int) num3 * 1574447713 ^ 742542365;
            continue;
          default:
            goto label_25;
        }
        num4 = 0;
label_21:
        flag2 = num4 != 0;
        num1 = 1217988758;
      }
label_25:
      return;
label_3:;
    }

    private void AddMeeting(ZoomMeeting newMeeting)
    {
      object modelLock = ViewModelBase.modelLock;
      bool flag = false;
      try
      {
        MeetingManagementViewModel.\u202B⁫‮⁫‏‏⁮⁮‭‬⁯‭⁬‏‫‏‍‏‌‏‏‬⁬⁭‭‬‪‬‮​⁮‪⁫‌‪⁪⁪‍‎⁫‮(modelLock, ref flag);
label_2:
        int num1 = 411160562;
        while (true)
        {
          int num2 = 971704059;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 1944202125 ^ -1009007249;
              continue;
            case 2:
              int num4 = !((Collection<ZoomMeeting>) this.Meetings).Contains(newMeeting) ? -1189819509 : (num4 = -2001673405);
              int num5 = (int) num3 * -1856518716;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 2048793922 ^ 883945611;
              continue;
            case 4:
              ((Collection<ZoomMeeting>) this.Meetings).Add(newMeeting);
              num1 = (int) num3 * -788896779 ^ -82481665;
              continue;
            case 5:
              num1 = 692785240;
              continue;
            case 6:
              goto label_13;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_13:;
      }
      finally
      {
        if (flag)
        {
label_11:
          int num1 = 1433599706;
          while (true)
          {
            int num2 = 971704059;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * 514882876 ^ -1614602852;
                continue;
              case 1:
                MeetingManagementViewModel.\u200C⁮⁮​​⁫‍⁬⁬‮‍​⁭‏⁮⁫‪⁫‎⁮‭‎‍‭‭⁬⁬‌‬‍‮⁪⁫⁮⁬⁪‬‍⁫‭‮(modelLock);
                num1 = (int) num3 * -1629369000 ^ 915711443;
                continue;
              case 2:
                goto label_11;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    private bool CanEditMeeting()
    {
label_1:
      int num1 = -2046789257;
      bool flag;
      while (true)
      {
        int num2 = -766382751;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = false;
            num1 = (int) num3 * 40042960 ^ -1312320320;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteEditMeeting()
    {
      this.EditMeeting = this.SelectedMeeting;
    }

    private bool CanDeleteMeeting()
    {
      if (this.SelectedMeeting == null)
        goto label_4;
label_1:
      int num1 = 504277688;
label_2:
      while (true)
      {
        int num2 = 1796937261;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1363665354 ^ 1530895958;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      int num4 = this.NewMeeting == null ? 1 : 0;
      goto label_5;
label_7:
      bool flag;
      return flag;
label_4:
      num4 = 0;
label_5:
      flag = num4 != 0;
      num1 = 56329659;
      goto label_2;
    }

    private void ExecuteDeleteMeeting()
    {
label_1:
      int num1 = -942348703;
      while (true)
      {
        int num2 = -119547156;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num4 = this.Engine != null ? 1 : 0;
            break;
          case 1:
            num1 = (int) num3 * 1023401551 ^ -1705446798;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.Engine.RemoveMeeting(this.SelectedMeeting.MeetingId);
            num1 = (int) num3 * 14500366 ^ -1355481848;
            continue;
          case 4:
            int num5 = flag ? 69930150 : (num5 = 764088903);
            int num6 = (int) num3 * 1827154824;
            num1 = num5 ^ num6;
            continue;
          case 5:
            num1 = (int) num3 * -1587811816 ^ 141438215;
            continue;
          case 6:
            goto label_3;
          case 7:
            this.SelectedMeeting = (ZoomMeeting) null;
            num1 = (int) num3 * 2073855553 ^ 1143886375;
            continue;
          case 8:
            if (this.SelectedMeeting != null)
            {
              num1 = (int) num3 * 2132493218 ^ -514788818;
              continue;
            }
            num4 = 0;
            break;
          default:
            goto label_14;
        }
        flag = num4 != 0;
        num1 = -861020611;
      }
label_14:
      return;
label_3:;
    }

    private bool CanFloodMeeting()
    {
label_1:
      int num1 = 1402330215;
      bool flag;
      while (true)
      {
        int num2 = 2100325546;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            flag = true;
            num1 = (int) num3 * 1384253094 ^ -223036862;
            continue;
          case 2:
            num1 = (int) num3 * 136991583 ^ -1757711428;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteFloodMeeting()
    {
      this.SelectedMeeting.SuspendMeetingActivities = true;
label_1:
      int num1 = 632559898;
      while (true)
      {
        int num2 = 1011621103;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 937828737 ^ -1583668496;
            continue;
          case 2:
            this.AddActivity((ActivityBase) new HammerMeeting(this.SelectedMeeting.MeetingId));
            num1 = (int) num3 * -1233582922 ^ -1929946765;
            continue;
          case 3:
            num1 = (int) num3 * -665975516 ^ 1891062904;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      this.AddActivity((ActivityBase) new FloodChat(this.Engine.Settings.FloodOptions_MessageContent, 0, ""));
    }

    private bool CanHammerMeeting()
    {
label_1:
      int num1 = -108120449;
      bool flag;
      while (true)
      {
        int num2 = -1323515930;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            flag = this.SelectedMeeting != null;
            num1 = (int) num3 * -1850896626 ^ -1756097245;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1519295901 ^ 494370619;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteHammerMeeting()
    {
label_1:
      int num1 = 1902618354;
      while (true)
      {
        int num2 = 911531134;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num4 = this.Engine != null ? 1 : 0;
            break;
          case 1:
            num1 = (int) num3 * 1976540451 ^ 678908411;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            if (this.SelectedMeeting != null)
            {
              num1 = (int) num3 * 1801332226 ^ -585902778;
              continue;
            }
            num4 = 0;
            break;
          case 5:
            int num5 = flag ? -1337851588 : (num5 = -485549106);
            int num6 = (int) num3 * 1718415487;
            num1 = num5 ^ num6;
            continue;
          case 6:
            this.Engine.AddActivity((ActivityBase) new HammerMeeting(this.SelectedMeeting.MeetingId), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1555375987U));
            num1 = (int) num3 * -173351840 ^ -1020457271;
            continue;
          case 7:
            num1 = (int) num3 * -930142983 ^ -490875710;
            continue;
          default:
            goto label_13;
        }
        flag = num4 != 0;
        num1 = 839664947;
      }
label_13:
      return;
label_3:;
    }

    private bool CanJoinMeeting()
    {
      bool flag = this.SelectedMeeting != null;
label_1:
      int num1 = -214667899;
      while (true)
      {
        int num2 = -287830620;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * 481597005 ^ 1062792563;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteJoinMeeting()
    {
label_1:
      int num1 = -370935607;
      while (true)
      {
        int num2 = -1086431803;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_3;
          case 1:
            if (this.SelectedMeeting == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 389807728 ^ -1354494584;
            continue;
          case 2:
            num1 = (int) num3 * -1885595847 ^ -311722896;
            continue;
          case 3:
            Engine engine = this.Engine;
            JoinMeeting joinMeeting = new JoinMeeting(this.SelectedMeeting.MeetingId);
            joinMeeting.LeaveCurrentMeeting = true;
            string callerName = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2788803725U);
            engine.AddActivity((ActivityBase) joinMeeting, callerName);
            num1 = (int) num3 * -540504646 ^ -1371861456;
            continue;
          case 4:
            num4 = this.Engine != null ? 1 : 0;
            break;
          case 5:
            int num5 = !flag ? -1946927632 : (num5 = -703354613);
            int num6 = (int) num3 * -1876694158;
            num1 = num5 ^ num6;
            continue;
          case 6:
            num1 = (int) num3 * 770894802 ^ -676773182;
            continue;
          case 7:
            num1 = (int) num3 * 1960627174 ^ -131953054;
            continue;
          case 8:
            goto label_1;
          default:
            goto label_14;
        }
        flag = num4 != 0;
        num1 = -934167745;
      }
label_14:
      return;
label_3:;
    }

    static bool \u202B‏‭​‮⁭‭‍‮‬⁯‏⁫‎⁪⁬​‭​⁪⁪‍⁯⁭‏​‬‌‌⁯⁭⁫​​⁫⁯‬‎⁬‎‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u202A‮⁪‫‌​⁯‎‎‏‬⁪⁭⁪‏‎‎‪‎‬⁪⁬‭‬⁫⁫⁪‮‫‍‎‭‭‮‬‭⁭‪‌‍‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static void \u202D‍‮⁪‪‬⁬⁮‏‏‪‍⁮⁮‭‎​​‪⁮⁬‪⁭⁫‮‭‌‪⁬⁫⁫‬⁫‬⁬​‌‎‭‪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static void \u200E⁫⁪⁫⁯‬‏‌‏⁯‍‭‌​‭‍⁭‫‍‭‫‮⁬⁭‮​‌⁭‭‮‎⁬‪⁯‏‌‪⁮‮⁯‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static bool \u200D⁫‪‬⁭⁪⁮​‪‬⁯‏‬‪‏⁬‮⁫⁭‫‫‪‏⁮‭‌‏‌⁬⁮‎‍‍‪⁫​‏⁭⁮‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u200D⁫‍‏⁪‌‫⁯‏‍⁬⁫⁬‏⁭⁫⁫‪⁭‍⁯⁫‭‍⁪‭⁬⁮‪⁯⁬⁯⁯⁪‪‬⁫‫‌‍‮([In] string obj0, [In] string obj1)
    {
      File.WriteAllText(obj0, obj1);
    }

    static Process \u202D⁫‮‪‫‪‌​‌⁯⁬‌‏​⁫‫​⁯⁮⁮⁫‬⁭‮‭⁬⁯​‬⁪‎⁫‌⁯‮‮‌‏​⁮‮([In] string obj0)
    {
      return Process.Start(obj0);
    }

    static int \u206E⁫⁪⁪‌⁪​‍‭‫​‭‌⁭⁯‎​‌⁫‎‌‪‫‌‍⁬‎‍⁮‮‏‏⁯⁫‮⁪‮‬⁬⁭‮([In] string obj0)
    {
      return obj0.Length;
    }

    static bool \u200C‏⁭‭‫‪‎⁮‎‏⁭‌‍⁬‎​‫‮‏‬⁬‎‬⁫⁪‎‪⁭⁭⁬‍⁭‌⁪‍⁯‬⁪‮‎‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static void \u202B⁫‮⁫‏‏⁮⁮‭‬⁯‭⁬‏‫‏‍‏‌‏‏‬⁬⁭‭‬‪‬‮​⁮‪⁫‌‪⁪⁪‍‎⁫‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200C⁮⁮​​⁫‍⁬⁬‮‍​⁭‏⁮⁫‪⁫‎⁮‭‎‍‭‭⁬⁬‌‬‍‮⁪⁫⁮⁬⁪‬‍⁫‭‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }
  }
}
