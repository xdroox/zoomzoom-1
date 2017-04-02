// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomMeeting
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ZoomZoom.Common;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Images;
using ZoomZoom.Models.Meetings;
using ZoomZoom.Models.Utils;
using ZoomZoom.Properties;

namespace ZoomZoom
{
  public class ZoomMeeting : ZoomZoom.Models.Data.DataObject
  {
    private static readonly object meetingLock = ZoomMeeting.\u200C‬‍⁪‍⁭⁬‏⁮⁫⁪⁫⁫⁭⁬‌‏‫‫‮‎‏‍‫‫‪‏‬‍⁬‬‬‏‍‪⁫‎⁬‎‏‮();
    private string _actionCurrent = string.Empty;
    private string _actionPrevious = string.Empty;
    private int _activeChats = 0;
    private DateTime dateCreated = DateTime.MinValue;
    private DateTime dateModified = DateTime.MinValue;
    private bool trackChats = false;
    private bool trackUsers = false;
    private bool recordingEnabled = false;
    private MeetingPriority joinPriority = MeetingPriority.Medium;
    private DateTime lastInspection = DateTime.MinValue;
    private DateTime lastJoinAttempt = DateTime.MinValue;
    private DateTime lastJoined = DateTime.MinValue;
    private string meetingId = string.Empty;
    private string notes = string.Empty;
    private string password = string.Empty;
    private string _meetingRoomType = string.Empty;
    private MeetingStatus meetingStatus = MeetingStatus.Unknown;
    private IntPtr _meetingWindowHandle = IntPtr.Zero;
    private long _uri = 0;
    private int userCountCurrent = 0;
    private int userCountPrevious = 0;
    private int userCountThreshhold = 0;
    private bool isFavorite = false;
    private bool requiresLogin = false;
    private int _chatButtonClickAttemptsCurrent = 0;
    private int _chatButtonClickAttemptsMaximum = 5;
    private List<DateTime> dtHoldsDetected = new List<DateTime>();
    private List<VideoChatLink> chatLinks = new List<VideoChatLink>();
    private LockedObservableCollection<ZoomImage> videoImages = new LockedObservableCollection<ZoomImage>();
    private LockedObservableCollection<ZoomChat> currentChats = new LockedObservableCollection<ZoomChat>();
    private ZoomWindow meetingWindow = (ZoomWindow) null;
    private bool suspendMeetingActivities = false;
    private MeetingCapabilities capabilities = new MeetingCapabilities();
    private MessageMonitor monitor = (MessageMonitor) null;
    private static ConcurrentQueue<ActivityBase> initialActivities;
    private static LockedObservableCollection<ZoomButton> meetingButtons;
    private static ConcurrentBag<MeetingVideo> meetingVideos;

    public LockedObservableCollection<ZoomImage> VideoImages
    {
      get
      {
        LockedObservableCollection<ZoomImage> videoImages = this.videoImages;
label_1:
        int num1 = 2051084429;
        while (true)
        {
          int num2 = 1181967325;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1539796055 ^ 1983844774;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return videoImages;
      }
      set
      {
        this.videoImages = value;
      }
    }

    public DisplayMode DisplayMode
    {
      get
      {
label_1:
        int num1 = 1034619837;
        DisplayMode displayMode;
        while (true)
        {
          int num2 = 721964833;
          uint num3;
          ZoomWindow zoomWindow;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1856605367 ^ 1505363276;
              continue;
            case 2:
              displayMode = DisplayMode.SpeakerView;
              num1 = (int) num3 * -1750370459 ^ 1525488784;
              continue;
            case 3:
              num1 = (int) num3 * 1583062855 ^ -351855698;
              continue;
            case 4:
              num1 = 284319796;
              continue;
            case 5:
              displayMode = DisplayMode.GalleryView;
              num1 = (int) num3 * -206019711 ^ -1982040105;
              continue;
            case 6:
              num1 = (int) num3 * 1914942798 ^ -204954073;
              continue;
            case 7:
              num1 = 878565996;
              continue;
            case 8:
              num1 = (int) num3 * 1691221591 ^ -567903146;
              continue;
            case 9:
              int num4 = zoomWindow == null ? -1825799519 : (num4 = -871643469);
              int num5 = (int) num3 * -760214204;
              num1 = num4 ^ num5;
              continue;
            case 11:
              num1 = (int) num3 * 575058583 ^ -1006576922;
              continue;
            case 12:
              flag = this.Engine.ActiveMeetingWindow != null;
              num1 = (int) num3 * -1856919117 ^ -1793112709;
              continue;
            case 13:
              displayMode = DisplayMode.Closed;
              num1 = (int) num3 * -1321466702 ^ 1818876298;
              continue;
            case 14:
              int num6 = !flag ? -1319118530 : (num6 = -334937983);
              int num7 = (int) num3 * 1584089804;
              num1 = num6 ^ num7;
              continue;
            case 15:
              zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (ZoomMeeting.\u003C\u003Ec.\u003C\u003E9__42_0 ?? (ZoomMeeting.\u003C\u003Ec.\u003C\u003E9__42_0 = new Func<ZoomWindow, bool>((object) ZoomMeeting.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003Cget_DisplayMode\u003Eb__42_0)))));
              num1 = 1018157272;
              continue;
            default:
              goto label_17;
          }
        }
label_17:
        return displayMode;
      }
    }

    internal int ChatButtonClickAttemptsCurrent
    {
      get
      {
label_1:
        int num1 = -1317371604;
        int clickAttemptsCurrent;
        while (true)
        {
          int num2 = -2103826658;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 460543436 ^ 2126633766;
              continue;
            case 2:
              clickAttemptsCurrent = this._chatButtonClickAttemptsCurrent;
              num1 = (int) num3 * 1878972712 ^ -1258965801;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return clickAttemptsCurrent;
      }
      set
      {
label_1:
        int num1 = -1969484913;
        while (true)
        {
          int num2 = -1037815879;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this._chatButtonClickAttemptsCurrent = value;
              num1 = (int) num3 * -84803507 ^ 1975293934;
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

    internal int ChatButtonClickAttemptsMaximum
    {
      get
      {
label_1:
        int num1 = -950868110;
        int clickAttemptsMaximum;
        while (true)
        {
          int num2 = -1381389532;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1399363000 ^ 1209905480;
              continue;
            case 2:
              clickAttemptsMaximum = this._chatButtonClickAttemptsMaximum;
              num1 = (int) num3 * -736327097 ^ 1358861515;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return clickAttemptsMaximum;
      }
      set
      {
        this._chatButtonClickAttemptsMaximum = value;
      }
    }

    public string ActionCurrent
    {
      get
      {
label_1:
        int num1 = 1587174711;
        string actionCurrent;
        while (true)
        {
          int num2 = 35919882;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1606093584 ^ 1190051633;
              continue;
            case 1:
              actionCurrent = this._actionCurrent;
              num1 = (int) num3 * 1972529225 ^ 1596399443;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return actionCurrent;
      }
      set
      {
label_1:
        int num1 = -151169597;
        while (true)
        {
          int num2 = -55384149;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this._actionCurrent = value;
              num1 = (int) num3 * -826473507 ^ -277429745;
              continue;
            case 2:
              num1 = (int) num3 * 656410473 ^ 326367094;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3525833686U));
              num1 = (int) num3 * -1502148772 ^ -1867622939;
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

    public int ActiveChatCount
    {
      get
      {
        int activeChats = this._activeChats;
label_1:
        int num1 = -797350611;
        while (true)
        {
          int num2 = -1248531743;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 919973545 ^ -1205306505;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeChats;
      }
    }

    public DateTime DateCreated
    {
      get
      {
label_1:
        int num1 = -1378512786;
        DateTime dateCreated;
        while (true)
        {
          int num2 = -1212347747;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 671355956 ^ 1038482447;
              continue;
            case 3:
              dateCreated = this.dateCreated;
              num1 = (int) num3 * 1461187091 ^ -869782451;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return dateCreated;
      }
      set
      {
label_1:
        int num1 = 1567139230;
        while (true)
        {
          int num2 = 1380128027;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.dateCreated = value;
              num1 = (int) num3 * 133331102 ^ 1851966313;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(327274448U));
      }
    }

    public DateTime DateModified
    {
      get
      {
        DateTime dateModified = this.dateModified;
label_1:
        int num1 = -1016612475;
        while (true)
        {
          int num2 = -1866826837;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1927742735 ^ 1214283326;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return dateModified;
      }
      set
      {
        this.dateModified = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2430253183U));
label_1:
        int num1 = 756584780;
        while (true)
        {
          int num2 = 205735324;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1033194156 ^ -1113283423;
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

    public string FormattedId
    {
      get
      {
label_1:
        int num1 = -18177275;
        string formattedMeetingId;
        while (true)
        {
          int num2 = -1181551793;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -622939649 ^ -1645019408;
              continue;
            case 2:
              formattedMeetingId = MeetingHelper.GetFormattedMeetingId(this.meetingId);
              num1 = (int) num3 * -347272569 ^ -1341520704;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return formattedMeetingId;
      }
    }

    public bool InitialInspectionPerformed { get; set; }

    public bool TrackChats
    {
      get
      {
        return this.trackChats;
      }
      set
      {
        this.trackChats = value;
label_1:
        int num1 = 1374900911;
        while (true)
        {
          int num2 = 1623606806;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3130816930U));
              num1 = (int) num3 * -1633470282 ^ -339621633;
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

    public bool TrackUsers
    {
      get
      {
        bool trackUsers = this.trackUsers;
label_1:
        int num1 = -1204459998;
        while (true)
        {
          int num2 = -349684994;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 245169203 ^ -2027187230;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return trackUsers;
      }
      set
      {
label_1:
        int num1 = -996849102;
        while (true)
        {
          int num2 = -1715720988;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.trackUsers = value;
              num1 = (int) num3 * -128281488 ^ -148348493;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1042454519U));
              num1 = (int) num3 * 257118833 ^ 1016272678;
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

    public bool IsRecordingEnabled
    {
      get
      {
        return this.recordingEnabled;
      }
      set
      {
label_1:
        int num1 = 2075636374;
        while (true)
        {
          int num2 = 1434256612;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.recordingEnabled = value;
              num1 = (int) num3 * 420892978 ^ 1003834230;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2084605229U));
      }
    }

    public bool IsFavorite
    {
      get
      {
label_1:
        int num1 = -2110003015;
        bool isFavorite;
        while (true)
        {
          int num2 = -917665835;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              isFavorite = this.isFavorite;
              num1 = (int) num3 * 2026631024 ^ 1590420305;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return isFavorite;
      }
      set
      {
label_1:
        int num1 = -1274399612;
        while (true)
        {
          int num2 = -1086308100;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.isFavorite = value;
              num1 = (int) num3 * 1628267533 ^ -1502150415;
              continue;
            case 2:
              num1 = (int) num3 * -1632033859 ^ 6217263;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3743333555U));
              num1 = (int) num3 * -475462556 ^ -1017468525;
              continue;
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
    }

    public MeetingPriority JoinPriority
    {
      get
      {
        MeetingPriority joinPriority = this.joinPriority;
label_1:
        int num1 = -1339170431;
        while (true)
        {
          int num2 = -180052961;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1280954067 ^ 889658927;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return joinPriority;
      }
      set
      {
        this.joinPriority = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2272253675U));
      }
    }

    public DateTime LastInspection
    {
      get
      {
label_1:
        int num1 = -1734221282;
        DateTime lastInspection;
        while (true)
        {
          int num2 = -1066213189;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -261250297 ^ 329423136;
              continue;
            case 1:
              lastInspection = this.lastInspection;
              num1 = (int) num3 * 1752168512 ^ 2018517415;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return lastInspection;
      }
      set
      {
        this.lastInspection = value;
label_1:
        int num1 = -258948574;
        while (true)
        {
          int num2 = -1141947564;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1660004027U));
              num1 = (int) num3 * 1101272327 ^ -1883286334;
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

    public DateTime LastJoinAttempt
    {
      get
      {
label_1:
        int num1 = -508958858;
        DateTime lastJoinAttempt1;
        while (true)
        {
          int num2 = -1522567008;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              DateTime lastJoinAttempt2 = this.lastJoinAttempt;
              num1 = (int) num3 * 167141737 ^ -691281079;
              continue;
            case 3:
              lastJoinAttempt1 = this.lastJoinAttempt;
              num1 = (int) num3 * 1769337693 ^ 1163210878;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return lastJoinAttempt1;
      }
      set
      {
        this.lastJoinAttempt = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1986219702U));
      }
    }

    public DateTime LastJoined
    {
      get
      {
label_1:
        int num1 = 798463518;
        DateTime lastJoined;
        while (true)
        {
          int num2 = 462767287;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1433940877 ^ -849122223;
              continue;
            case 1:
              lastJoined = this.lastJoined;
              num1 = (int) num3 * 1781760532 ^ 1352717195;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return lastJoined;
      }
      set
      {
        this.lastJoined = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1477219561U));
      }
    }

    public string MeetingActionPrevious
    {
      get
      {
label_1:
        int num1 = 1053596929;
        string actionPrevious;
        while (true)
        {
          int num2 = 386290337;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              actionPrevious = this._actionPrevious;
              num1 = (int) num3 * 2008465159 ^ 2062651422;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return actionPrevious;
      }
      set
      {
        this._actionPrevious = value;
label_1:
        int num1 = 762611198;
        while (true)
        {
          int num2 = 918519628;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -404932488 ^ 1827130175;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3524089518U));
              num1 = (int) num3 * -2139781592 ^ -472805459;
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

    public string MeetingId
    {
      get
      {
label_1:
        int num1 = -1570119031;
        string meetingId;
        while (true)
        {
          int num2 = -1452370396;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingId = this.meetingId;
              num1 = (int) num3 * -374509254 ^ -1361693803;
              continue;
            case 3:
              num1 = (int) num3 * -81267650 ^ -1726149376;
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
        int num1 = -294648961;
        while (true)
        {
          int num2 = -625975291;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(578348558U));
              num1 = (int) num3 * -136474801 ^ -654347715;
              continue;
            case 2:
              this.meetingId = value;
              num1 = (int) num3 * 958844179 ^ 1875890150;
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

    public string Notes
    {
      get
      {
label_1:
        int num1 = -368712012;
        string notes;
        while (true)
        {
          int num2 = -615627568;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              notes = this.notes;
              num1 = (int) num3 * -1581203344 ^ 1938457997;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return notes;
      }
      set
      {
label_1:
        int num1 = -1376985700;
        while (true)
        {
          int num2 = -1509014419;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -806249061 ^ 91620777;
              continue;
            case 1:
              this.notes = value;
              num1 = (int) num3 * -969089342 ^ 1396187614;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1514587844U));
              num1 = (int) num3 * -900902197 ^ 1480384286;
              continue;
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
    }

    public string Password
    {
      get
      {
        return this.password;
      }
      set
      {
label_1:
        int num1 = 728125285;
        while (true)
        {
          int num2 = 849384969;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1184551984 ^ -399449419;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.password = value;
              num1 = (int) num3 * -525668078 ^ -2071445325;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2756026694U));
              num1 = (int) num3 * -1169540180 ^ 1756022588;
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

    public string MeetingRoomType
    {
      get
      {
label_1:
        int num1 = 667600033;
        string meetingRoomType;
        while (true)
        {
          int num2 = 1471564902;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1048168693 ^ -712199161;
              continue;
            case 3:
              meetingRoomType = this._meetingRoomType;
              num1 = (int) num3 * -1971451935 ^ -1719337208;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingRoomType;
      }
      set
      {
label_1:
        int num1 = -528779731;
        while (true)
        {
          int num2 = -937256378;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 692396162 ^ -1296208476;
              continue;
            case 2:
              this._meetingRoomType = value;
              num1 = (int) num3 * -561389874 ^ 2042553624;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(558540164U));
              num1 = (int) num3 * -274756500 ^ -641312547;
              continue;
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
    }

    public MeetingStatus MeetingStatus
    {
      get
      {
label_1:
        int num1 = 1692802372;
        MeetingStatus meetingStatus;
        while (true)
        {
          int num2 = 1884800029;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              meetingStatus = this.meetingStatus;
              num1 = (int) num3 * 1674584157 ^ -1893365754;
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
label_1:
        int num1 = -1358988340;
        while (true)
        {
          int num2 = -170653599;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.meetingStatus = value;
              num1 = (int) num3 * -272394361 ^ -1022443312;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3274416474U));
              num1 = (int) num3 * -1070867253 ^ -2129846249;
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

    public int UserCountCurrent
    {
      get
      {
label_1:
        int num1 = 826812045;
        int userCountCurrent;
        while (true)
        {
          int num2 = 993469216;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              userCountCurrent = this.userCountCurrent;
              num1 = (int) num3 * -602037548 ^ 1534137026;
              continue;
            case 2:
              num1 = (int) num3 * 536607100 ^ -1541981236;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return userCountCurrent;
      }
      set
      {
        this.userCountCurrent = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2564426106U));
label_1:
        int num1 = -819675311;
        while (true)
        {
          int num2 = -1457252077;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1439071712 ^ -899017403;
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

    public int UserCountPrevious
    {
      get
      {
        return this.userCountPrevious;
      }
      set
      {
        this.userCountPrevious = value;
label_1:
        int num1 = 1631372185;
        while (true)
        {
          int num2 = 815995890;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1634180134 ^ -875776697;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1832822992U));
              num1 = (int) num3 * 496672638 ^ -40079308;
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

    public int UserCountTreshold
    {
      get
      {
label_1:
        int num1 = -1241856523;
        int userCountThreshhold;
        while (true)
        {
          int num2 = -222269188;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              userCountThreshhold = this.userCountThreshhold;
              num1 = (int) num3 * 1505882115 ^ -1984385589;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return userCountThreshhold;
      }
      set
      {
label_1:
        int num1 = 260441145;
        while (true)
        {
          int num2 = 559844716;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2978992862U));
              num1 = (int) num3 * 1703038254 ^ 821449019;
              continue;
            case 1:
              this.userCountThreshhold = value;
              num1 = (int) num3 * -638419861 ^ 1266305227;
              continue;
            case 2:
              goto label_1;
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

    protected internal string ExpectedWindowCaption
    {
      get
      {
        return MeetingHelper.GetmeetingWindowCaption(this.FormattedId);
      }
    }

    public TimeSpan RemainingTime
    {
      get
      {
label_1:
        int num1 = 1297082475;
        TimeSpan timeSpan;
        while (true)
        {
          int num2 = 2012430004;
          uint num3;
          DateTime lastJoined;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              timeSpan = lastJoined.AddSeconds(this.Engine.Settings.MaximumAttendenceDuration) - DateTime.Now;
              num1 = (int) num3 * -1396166209 ^ -631647467;
              continue;
            case 1:
              num4 = this.MeetingStatus == MeetingStatus.Attending ? 1 : 0;
              break;
            case 3:
              if (this.Engine.Settings.MaximumAttendenceDuration > 0.0)
              {
                num1 = (int) num3 * -1350275463 ^ 1964752126;
                continue;
              }
              num4 = 0;
              break;
            case 4:
              num1 = (int) num3 * 1418895844 ^ -1410357634;
              continue;
            case 5:
              num1 = (int) num3 * -1622869351 ^ 492799455;
              continue;
            case 6:
              lastJoined = this.LastJoined;
              num1 = (int) num3 * 1620532788 ^ -128664146;
              continue;
            case 7:
              goto label_1;
            case 8:
              timeSpan = TimeSpan.MaxValue;
              num1 = 587339451;
              continue;
            case 9:
              num1 = (int) num3 * -1092438527 ^ 50787207;
              continue;
            default:
              goto label_14;
          }
          int num5;
          num1 = num5 = num4 == 0 ? 1485832056 : (num5 = 1153137638);
        }
label_14:
        return timeSpan;
      }
    }

    public ConcurrentQueue<ActivityBase> InitialActivities
    {
      get
      {
label_1:
        int num1 = 677470502;
        ConcurrentQueue<ActivityBase> initialActivities;
        while (true)
        {
          int num2 = 1873555700;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -513474322 ^ -2091701498;
              continue;
            case 2:
              initialActivities = ZoomMeeting.initialActivities;
              num1 = (int) num3 * 12583308 ^ 17112185;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return initialActivities;
      }
      set
      {
        ZoomMeeting.initialActivities = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(253252784U));
      }
    }

    public List<VideoChatLink> ChatLinks
    {
      get
      {
label_1:
        int num1 = -661767550;
        List<VideoChatLink> chatLinks;
        while (true)
        {
          int num2 = -1947504461;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              chatLinks = this.chatLinks;
              num1 = (int) num3 * 246464022 ^ -1649791334;
              continue;
            case 3:
              num1 = (int) num3 * 932875144 ^ 214816721;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return chatLinks;
      }
      set
      {
label_1:
        int num1 = -465356626;
        while (true)
        {
          int num2 = -806514749;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.chatLinks = value;
              num1 = (int) num3 * -875079564 ^ -1505408964;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1029896946U));
              num1 = (int) num3 * -1960277206 ^ -482069049;
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

    public LockedObservableCollection<ZoomButton> MeetingButtons
    {
      get
      {
label_1:
        int num1 = 1120743610;
        LockedObservableCollection<ZoomButton> meetingButtons;
        while (true)
        {
          int num2 = 1784682237;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meetingButtons = ZoomMeeting.meetingButtons;
              num1 = (int) num3 * 1465884823 ^ -1369608873;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingButtons;
      }
      set
      {
        ZoomMeeting.meetingButtons = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3017799994U));
label_1:
        int num1 = -828809077;
        while (true)
        {
          int num2 = -1650151734;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -923055235 ^ 456722584;
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

    public bool HasPendingActivity
    {
      get
      {
label_1:
        int num1 = 127923670;
        bool flag;
        while (true)
        {
          int num2 = 871477874;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              flag = this.InitialActivities.get_Count() > 0;
              num1 = (int) num3 * -1811623369 ^ -433942440;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return flag;
      }
    }

    public ConcurrentBag<MeetingVideo> MeetingVideos
    {
      get
      {
        ConcurrentBag<MeetingVideo> meetingVideos = ZoomMeeting.meetingVideos;
label_1:
        int num1 = 2020086778;
        while (true)
        {
          int num2 = 453668049;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1139645191 ^ 175799160;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingVideos;
      }
    }

    public ZoomWindow MeetingWindow
    {
      get
      {
label_1:
        int num1 = -710397280;
        ZoomWindow meetingWindow;
        while (true)
        {
          int num2 = -491061942;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1702251121 ^ -452872600;
              continue;
            case 2:
              meetingWindow = this.meetingWindow;
              num1 = (int) num3 * -413410757 ^ 1707506933;
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
        this.meetingWindow = value;
label_1:
        int num1 = 1016738715;
        while (true)
        {
          int num2 = 402976920;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1789639959U));
              num1 = (int) num3 * -1202932989 ^ 280926214;
              continue;
            case 3:
              num1 = (int) num3 * 1263751732 ^ -923093187;
              continue;
            case 4:
              this.MeetingWindow.PropertyChanged += new PropertyChangedEventHandler(this.MeetingWindow_PropertyChanged);
              num1 = (int) num3 * -1241446723 ^ 1503101047;
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

    public LockedObservableCollection<ZoomChat> CurrentChats
    {
      get
      {
label_1:
        int num1 = 1159484456;
        LockedObservableCollection<ZoomChat> currentChats;
        while (true)
        {
          int num2 = 1754555194;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              currentChats = this.currentChats;
              num1 = (int) num3 * -429673288 ^ -1069088743;
              continue;
            case 3:
              num1 = (int) num3 * 372125997 ^ -1456949344;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return currentChats;
      }
      set
      {
label_1:
        int num1 = 1698544035;
        while (true)
        {
          int num2 = 1162811502;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -2055224333 ^ 1209850912;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3710959171U));
              num1 = (int) num3 * 335249990 ^ -1090693181;
              continue;
            case 2:
              this.currentChats = value;
              num1 = (int) num3 * -393932159 ^ 1518897008;
              continue;
            case 3:
              goto label_1;
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
    }

    public bool SuspendMeetingActivities
    {
      get
      {
        return this.suspendMeetingActivities;
      }
      set
      {
label_1:
        int num1 = -1181412628;
        while (true)
        {
          int num2 = -1522372343;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -1752453704 ^ -612270734;
              continue;
            case 1:
              this.suspendMeetingActivities = value;
              num1 = (int) num3 * 1539908638 ^ 2082548855;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2973484115U));
              num1 = (int) num3 * -472360452 ^ -1071765690;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -1062341905;
        TraceType traceType;
        while (true)
        {
          int num2 = -2120753626;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1172336475 ^ -1182390140;
              continue;
            case 1:
              traceType = TraceType.Meeting;
              num1 = (int) num3 * -1669183061 ^ -263632799;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public override ObjectDataTable ZoomZoomTable
    {
      get
      {
label_1:
        int num1 = -2018280263;
        ObjectDataTable objectDataTable;
        while (true)
        {
          int num2 = -1668145603;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              objectDataTable = ObjectDataTable.Meetings;
              num1 = (int) num3 * -1035392503 ^ 2094550602;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return objectDataTable;
      }
    }

    internal MessageMonitor Monitor
    {
      get
      {
        MessageMonitor monitor = this.monitor;
label_1:
        int num1 = 1474483809;
        while (true)
        {
          int num2 = 109805364;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1327401397 ^ -915185158;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return monitor;
      }
      set
      {
        this.monitor = value;
      }
    }

    public bool RequiresLogin
    {
      get
      {
        return this.requiresLogin;
      }
      set
      {
label_1:
        int num1 = 1823017600;
        while (true)
        {
          int num2 = 1080175013;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.requiresLogin = value;
              num1 = (int) num3 * 88650053 ^ 1354180526;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3075823420U));
              num1 = (int) num3 * 1833848447 ^ -1159132893;
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

    static ZoomMeeting()
    {
label_1:
      int num1 = 485170510;
      while (true)
      {
        int num2 = 74269034;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ZoomMeeting.initialActivities = new ConcurrentQueue<ActivityBase>();
            num1 = (int) num3 * 2059193935 ^ -1796304120;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ZoomMeeting.meetingButtons = new LockedObservableCollection<ZoomButton>();
      ZoomMeeting.meetingVideos = new ConcurrentBag<MeetingVideo>();
    }

    protected ZoomMeeting()
    {
      this.Initialize();
    }

    public ZoomMeeting(string meetingId)
    {
label_1:
      int num1 = -1609871201;
      while (true)
      {
        int num2 = -313235988;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Initialize();
            num1 = (int) num3 * -14324659 ^ -1307971973;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.meetingId = meetingId;
            num1 = (int) num3 * 1330943563 ^ -979663368;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public ZoomMeeting(string meetingId, ZoomWindow window)
    {
label_1:
      int num1 = -632408591;
      while (true)
      {
        int num2 = -1720637417;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.meetingId = meetingId;
            this.Initialize();
            num1 = (int) num3 * 1586113537 ^ -2121219550;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 1016494624 ^ 300072068;
            continue;
          case 4:
            num1 = (int) num3 * -1137722797 ^ -979305754;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    public ZoomMeeting(SQLiteDataReader cReader)
    {
      this.LoadDataObject(cReader);
      this.Initialize();
    }

    internal void AddChat(ZoomChat chat)
    {
      if (this.CurrentChats == null)
        goto label_5;
label_1:
      int num1 = -947785857;
label_2:
      bool flag;
      while (true)
      {
        int num2 = -355476486;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            int num4 = flag ? 701838127 : (num4 = 578770157);
            int num5 = (int) num3 * 133828388;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * 1412140795 ^ -1502037184;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_4;
          case 4:
            num1 = (int) num3 * 179047048 ^ 1588494153;
            continue;
          case 5:
            ((Collection<ZoomChat>) this.CurrentChats).Add(chat);
            num1 = (int) num3 * 1256147863 ^ 1324693972;
            continue;
          case 6:
            goto label_1;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:
      return;
label_4:
      int num6 = !((Collection<ZoomChat>) this.CurrentChats).Contains(chat) ? 1 : 0;
      goto label_6;
label_5:
      num6 = 0;
label_6:
      flag = num6 != 0;
      num1 = -1975436835;
      goto label_2;
    }

    internal MeetingVideo FindChatLink(ZoomChat chat)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ZoomMeeting.\u003C\u003Ec__DisplayClass94_0 cDisplayClass940 = new ZoomMeeting.\u003C\u003Ec__DisplayClass94_0();
label_1:
      int num1 = -949968962;
      MeetingVideo meetingVideo;
      while (true)
      {
        int num2 = -1268334976;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass940.chat = chat;
            num1 = (int) num3 * -1696701013 ^ -49458540;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: method pointer
            meetingVideo = (MeetingVideo) Enumerable.FirstOrDefault<MeetingVideo>((IEnumerable<M0>) this.MeetingVideos, (Func<M0, bool>) new Func<MeetingVideo, bool>((object) cDisplayClass940, __methodptr(\u003CFindChatLink\u003Eb__0)));
            num1 = (int) num3 * -77556978 ^ -1999542238;
            continue;
          case 4:
            num1 = (int) num3 * 797779551 ^ -2085597550;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return meetingVideo;
    }

    internal void AddVideoImage(ZoomImage zoomImage)
    {
      try
      {
        ZoomMeeting.\u202E​⁫⁮‌‪‬⁬⁬‫‎‌‬‏‭‍‫⁬‫‭‭⁪⁯‎‍‏⁬‌⁭‪‪⁫‌‪⁭‭​‫‌⁮‮(CoreObject.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3962211771U));
label_2:
        int num1 = 135691813;
        object meetingLock;
        while (true)
        {
          int num2 = 572280434;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_2;
            case 2:
              meetingLock = ZoomMeeting.meetingLock;
              num1 = (int) num3 * -547819943 ^ -2000260995;
              continue;
            case 3:
              num1 = (int) num3 * 591496010 ^ -687944662;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        bool flag = false;
        try
        {
          ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag);
label_8:
          int num2 = 1184191249;
          while (true)
          {
            int num3 = 572280434;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -968139911 ^ -481824129;
                continue;
              case 1:
                goto label_25;
              case 2:
                goto label_8;
              case 3:
                ((Collection<ZoomImage>) this.VideoImages).Add(zoomImage);
                num2 = (int) num4 * 1350792177 ^ 201683621;
                continue;
              default:
                goto label_23;
            }
          }
label_23:
          return;
label_25:;
        }
        finally
        {
          if (flag)
          {
label_13:
            int num2 = 620257808;
            while (true)
            {
              int num3 = 572280434;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  num2 = (int) num4 * -1048458071 ^ -327421417;
                  continue;
                case 2:
                  ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                  num2 = (int) num4 * -1317256460 ^ -2006336737;
                  continue;
                case 3:
                  goto label_13;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
      }
      catch (Exception ex)
      {
label_21:
        int num1 = 647279406;
        while (true)
        {
          int num2 = 572280434;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_21;
            case 1:
              goto label_19;
            case 2:
              ZoomMeeting.\u206A​‬⁪‪⁪⁭‌⁮⁬‫‌‬‪⁪⁮‌⁯‭⁪​‎‮⁯‪⁯‍‏‎⁮‫‪⁬​​‍⁪‎‌‎‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 945154057 ^ -352951788;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_19:;
      }
    }

    private void MeetingWindow_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      try
      {
label_2:
        int num1 = -413908840;
        while (true)
        {
          int num2 = -1064538658;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * -1794508923 ^ 336234902;
              continue;
            case 2:
              goto label_4;
            case 3:
              this.LoadMeetingButtons();
              num1 = (int) num3 * -1569592824 ^ -1172157085;
              continue;
            case 4:
              int num4 = !ZoomMeeting.\u206F⁯⁬⁪‪‮‭⁭⁬‭‮‏⁪‪‪‫⁯⁯⁪⁮‬‫‭⁯⁯⁫​‪‍⁪​⁬‭⁫‪⁭⁮‌‪‪‮(ZoomMeeting.\u202C‪‭‬‌⁬⁬⁮‌‮⁬⁪⁯⁯‌‭⁫‎⁫‌⁬‬‬​‭​‬‏⁯‮‍‌⁬⁯‮⁪‭⁫⁭⁯‮(e), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1314755789U)) ? -438208260 : (num4 = -1526892593);
              int num5 = (int) num3 * -770046103;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 440579445 ^ 655878371;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_4:;
      }
      catch (Exception ex)
      {
        ZoomMeeting.\u206A​‬⁪‪⁪⁭‌⁮⁬‫‌‬‪⁪⁮‌⁯‭⁪​‎‮⁯‪⁯‍‏‎⁮‫‪⁬​​‍⁪‎‌‎‮(CoreObject.log, (object) ex);
      }
    }

    private void Initialize()
    {
label_1:
      int num1 = -440027921;
      while (true)
      {
        int num2 = -1839887538;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.meetingStatus = MeetingStatus.Unknown;
            num1 = (int) num3 * -130620915 ^ 1891975544;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.monitor = new MessageMonitor(this);
            num1 = (int) num3 * 839819784 ^ -630385770;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public new string ToString()
    {
label_1:
      int num1 = -667359980;
      string str;
      while (true)
      {
        int num2 = -874372343;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            str = ZoomMeeting.\u206F‭‌‌⁮⁭‌⁫⁭‌‮‎‭⁭‍‮⁯‬⁭⁯‭‪⁪⁮​​⁫⁭‪‭‍⁯‪‪⁬⁪‪⁫⁭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3314092956U), (object) this.MeetingId, (object) this.MeetingStatus);
            num1 = (int) num3 * -1090867655 ^ -856126894;
            continue;
          case 2:
            num1 = (int) num3 * -1931038703 ^ -1716284048;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    public override bool Equals(object obj)
    {
      ZoomMeeting zoomMeeting = obj as ZoomMeeting;
      bool flag1 = zoomMeeting != null;
label_1:
      int num1 = 528312883;
      bool flag2;
      while (true)
      {
        int num2 = 444823434;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 1:
            num1 = (int) num3 * -112870013 ^ 32396730;
            continue;
          case 2:
            int num4 = flag1 ? 1224996245 : (num4 = 1008187900);
            int num5 = (int) num3 * -33451742;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_1;
          case 4:
            flag2 = ZoomMeeting.\u206F⁯⁬⁪‪‮‭⁭⁬‭‮‏⁪‪‪‫⁯⁯⁪⁮‬‫‭⁯⁯⁫​‪‍⁪​⁬‭⁫‪⁭⁮‌‪‪‮(this.MeetingId, zoomMeeting.MeetingId);
            num1 = (int) num3 * 2145708786 ^ -1747507483;
            continue;
          case 5:
            num1 = (int) num3 * 1485063516 ^ 1654660535;
            continue;
          case 6:
            flag2 = this.\u200F‌‮⁭‍‪‬​⁪‫‏⁬‪‍‏⁭‫‏‮‭⁫⁮⁬‪⁯‏⁯⁬‪‭‍‍‪​‮‬⁭⁯‍‭‮(obj);
            num1 = 1603085623;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return flag2;
    }

    public override int GetHashCode()
    {
      if (ZoomMeeting.\u202D⁪‪⁪⁮‬⁭​‌‪⁫⁪⁬‌‫‍‬‏‍‌​‎⁪‪‌‌‫⁫‭⁭⁫‫⁪​‏‭‎⁯‪‍‮(this.MeetingId))
        goto label_3;
label_1:
      int num1 = -954971948;
label_2:
      int num2;
      while (true)
      {
        int num3 = -1254838657;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            num2 = ZoomMeeting.\u202D⁮⁮⁯‏⁪‏‌‏‎‮‏⁯‮‍⁫‭‌‍‍‏‫‭‬⁯‍⁫‭⁬⁮‭‬⁮⁯⁪⁬⁪‭⁯‬‮((object) this.MeetingId);
            num1 = (int) num4 * -1194073176 ^ 1294279506;
            continue;
          case 2:
            num1 = (int) num4 * -1010250077 ^ 952042328;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return num2;
label_3:
      num2 = this.\u200C⁮‬‪‌⁫⁫‎‍‭⁮‏⁬‌⁮‌‏⁮‏‎​⁬‍⁭⁬​⁯‎‭‏⁬⁪‎​‌‎‪⁯⁬⁫‮();
      num1 = -379455326;
      goto label_2;
    }

    public override bool LoadDataObject(SQLiteDataReader cReader)
    {
      bool flag1 = false;
      object meetingLock = ZoomMeeting.meetingLock;
      bool flag2 = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag2);
label_2:
        int num1 = 216081428;
        while (true)
        {
          int num2 = 1217744345;
          uint num3;
          DateTime dateTime;
          bool flag3;
          bool flag4;
          switch ((num3 = (uint) (num1 ^ num2)) % 40U)
          {
            case 0:
              this.UserCountTreshold = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1974517224U));
              num1 = (int) num3 * -868527719 ^ -1901376790;
              continue;
            case 1:
              dateTime = this.DateModified;
              num1 = 1666582326;
              continue;
            case 2:
              this.MeetingId = cReader.GetFieldValueString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1465017654U));
              num1 = (int) num3 * -103770797 ^ -640738518;
              continue;
            case 3:
              goto label_2;
            case 4:
              num1 = (int) num3 * 2000962972 ^ 843753044;
              continue;
            case 5:
              this.Notes = cReader.GetFieldValueString(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3546223336U));
              num1 = (int) num3 * 1625711915 ^ -2026881991;
              continue;
            case 6:
              this.Uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U));
              num1 = (int) num3 * 237353631 ^ 241280337;
              continue;
            case 7:
              num1 = (int) num3 * -1351696052 ^ 519247819;
              continue;
            case 8:
              int num4 = !flag4 ? -901667200 : (num4 = -1350323989);
              int num5 = (int) num3 * -1268195195;
              num1 = num4 ^ num5;
              continue;
            case 9:
              this.IsRecordingEnabled = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(413833566U)) == 1;
              num1 = 438706189;
              continue;
            case 10:
              this.UserCountPrevious = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3181102583U));
              num1 = (int) num3 * 676201361 ^ -350615901;
              continue;
            case 11:
              num1 = (int) num3 * 1870001521 ^ -126473901;
              continue;
            case 12:
              num1 = (int) num3 * -114984949 ^ -845591883;
              continue;
            case 13:
              this.UserCountCurrent = cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2901412641U));
              num1 = (int) num3 * 2129592576 ^ 1874628561;
              continue;
            case 14:
              int num6 = !flag3 ? -1658015956 : (num6 = -619194934);
              int num7 = (int) num3 * -672587294;
              num1 = num6 ^ num7;
              continue;
            case 15:
              this.Password = cReader.GetFieldValueString(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(771323941U));
              this.IsFavorite = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3458759975U)) == 1;
              num1 = 556545893;
              continue;
            case 16:
              flag3 = dateTime.Equals(DateTime.MinValue);
              num1 = (int) num3 * -1954254930 ^ 1703199679;
              continue;
            case 17:
              this.JoinPriority = (MeetingPriority) cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3372572099U));
              num1 = (int) num3 * 86894158 ^ -471513261;
              continue;
            case 18:
              num1 = (int) num3 * 704763432 ^ 693111543;
              continue;
            case 19:
              dateTime = this.DateCreated;
              num1 = (int) num3 * -509820969 ^ 1777623748;
              continue;
            case 20:
              this.RequiresLogin = cReader.GetFieldValueInt(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3313891930U)) == 1;
              num1 = 821890302;
              continue;
            case 21:
              this.LastInspection = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(24504480U));
              num1 = (int) num3 * 1027718850 ^ -1669637601;
              continue;
            case 22:
              this.DateCreated = DateTime.Now;
              num1 = (int) num3 * -1048938982 ^ -1992607940;
              continue;
            case 23:
              num1 = (int) num3 * 1915796632 ^ -41510614;
              continue;
            case 24:
              num1 = (int) num3 * 258245130 ^ 2077889211;
              continue;
            case 25:
              flag1 = true;
              num1 = 1902202883;
              continue;
            case 26:
              num1 = (int) num3 * -1242589993 ^ -25897882;
              continue;
            case 27:
              this.LastJoined = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1819168370U));
              num1 = (int) num3 * -1325324969 ^ 409069254;
              continue;
            case 28:
              num1 = (int) num3 * 934957346 ^ 1888688896;
              continue;
            case 29:
              num1 = (int) num3 * -1414615149 ^ -1125510688;
              continue;
            case 31:
              flag4 = dateTime.Equals(DateTime.MinValue);
              num1 = (int) num3 * -1626755583 ^ -1287779162;
              continue;
            case 32:
              this.TrackUsers = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2021248547U)) == 1;
              num1 = 1228400838;
              continue;
            case 33:
              this.DateModified = DateTime.Now;
              num1 = (int) num3 * -313672738 ^ -1275011666;
              continue;
            case 34:
              this.LastJoinAttempt = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3125955770U));
              num1 = (int) num3 * -1726761827 ^ -94014281;
              continue;
            case 35:
              this.DateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1679528045U));
              num1 = (int) num3 * -169284068 ^ 982299483;
              continue;
            case 36:
              num1 = (int) num3 * -893655625 ^ -388409480;
              continue;
            case 37:
              num1 = (int) num3 * -899081517 ^ -783565483;
              continue;
            case 38:
              this.DateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3397799221U));
              num1 = (int) num3 * 390354561 ^ 28519068;
              continue;
            case 39:
              this.TrackChats = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1196293930U)) == 1;
              num1 = 1857616156;
              continue;
            default:
              goto label_47;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_43:
          int num1 = 1841156537;
          while (true)
          {
            int num2 = 1217744345;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_43;
              case 2:
                System.Threading.Monitor.Exit(meetingLock);
                num1 = (int) num3 * -1913887201 ^ -465746842;
                continue;
              default:
                goto label_46;
            }
          }
        }
label_46:;
      }
label_47:
      bool flag5 = flag1;
label_48:
      int num8 = 1017285623;
      while (true)
      {
        int num1 = 1217744345;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 1:
            num8 = (int) num2 * -1956261624 ^ 1897963864;
            continue;
          case 2:
            goto label_48;
          default:
            goto label_51;
        }
      }
label_51:
      return flag5;
    }

    public override Dictionary<string, object> GetDataDictionary()
    {
label_1:
      int num1 = 1348369312;
      Dictionary<string, object> dictionary1;
      while (true)
      {
        int num2 = 146534289;
        uint num3;
        Dictionary<string, object> dictionary2;
        switch ((num3 = (uint) (num1 ^ num2)) % 27U)
        {
          case 0:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2322180906U), (object) this.MeetingId);
            num1 = (int) num3 * -779401838 ^ -1129349636;
            continue;
          case 1:
            dictionary2 = new Dictionary<string, object>();
            num1 = (int) num3 * -995116206 ^ -1642118930;
            continue;
          case 2:
            goto label_1;
          case 3:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1257971364U), (object) this.Notes);
            num1 = (int) num3 * 1902978750 ^ -892368267;
            continue;
          case 4:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3397799221U), (object) this.DateModified);
            num1 = (int) num3 * -1955892639 ^ 2142626786;
            continue;
          case 5:
            num1 = (int) num3 * -749907202 ^ -782351846;
            continue;
          case 7:
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3181102583U), (object) this.UserCountPrevious);
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(317092681U), (object) this.UserCountTreshold);
            num1 = (int) num3 * 2020644482 ^ -193053273;
            continue;
          case 8:
            num1 = (int) num3 * 1418399298 ^ 662712585;
            continue;
          case 9:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2182723723U), (object) this.DateCreated);
            num1 = (int) num3 * 1396116735 ^ -1250488701;
            continue;
          case 10:
            num1 = (int) num3 * 403359336 ^ -5528234;
            continue;
          case 11:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U), (object) this.Uri);
            num1 = (int) num3 * -247422691 ^ 236923050;
            continue;
          case 12:
            num1 = (int) num3 * 891688696 ^ 2109387359;
            continue;
          case 13:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3121440192U), (object) this.LastInspection);
            num1 = (int) num3 * -228026238 ^ 1398113437;
            continue;
          case 14:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3125955770U), (object) this.LastJoinAttempt);
            num1 = (int) num3 * 12686356 ^ 258964632;
            continue;
          case 15:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3313891930U), (object) this.RequiresLogin);
            num1 = (int) num3 * 821334236 ^ -1021630946;
            continue;
          case 16:
            num1 = (int) num3 * 940284584 ^ -2094555112;
            continue;
          case 17:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1263419802U), (object) this.UserCountCurrent);
            num1 = (int) num3 * -458766089 ^ -864807840;
            continue;
          case 18:
            dictionary1 = dictionary2;
            num1 = (int) num3 * 1076661992 ^ -1407352656;
            continue;
          case 19:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3934014715U), (object) this.LastJoined);
            num1 = (int) num3 * 442815372 ^ 661815737;
            continue;
          case 20:
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1196293930U), (object) this.TrackChats);
            num1 = (int) num3 * -1061663219 ^ -1784273629;
            continue;
          case 21:
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3280929938U), (object) this.MeetingStatus);
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3380757293U), (object) this.IsRecordingEnabled);
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(388165143U), (object) this.TrackUsers);
            num1 = (int) num3 * -1726607537 ^ 712752450;
            continue;
          case 22:
            num1 = (int) num3 * -584951101 ^ 821699328;
            continue;
          case 23:
            num1 = (int) num3 * -1306935408 ^ 1177779818;
            continue;
          case 24:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2507611555U), (object) this.Password);
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3458759975U), (object) this.IsFavorite);
            num1 = (int) num3 * 187496196 ^ -241623719;
            continue;
          case 25:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2725569793U), (object) this.JoinPriority);
            num1 = (int) num3 * -592131475 ^ 1500365716;
            continue;
          case 26:
            num1 = (int) num3 * 268725789 ^ -152140359;
            continue;
          default:
            goto label_28;
        }
      }
label_28:
      return dictionary1;
    }

    internal void SetStatus(MeetingStatus newStatus)
    {
      MeetingStatus meetingStatus = this.MeetingStatus;
      object meetingLock = ZoomMeeting.meetingLock;
      bool flag1 = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag1);
label_2:
        int num1 = -405871433;
        while (true)
        {
          int num2 = -96465328;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 748403712 ^ -84720504;
              continue;
            case 1:
              num1 = (int) num3 * 1522656593 ^ 824159514;
              continue;
            case 2:
              goto label_2;
            case 3:
              this.MeetingStatus = newStatus;
              num1 = (int) num3 * 1502934002 ^ 1177172549;
              continue;
            default:
              goto label_13;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_8:
          int num1 = -1779938722;
          while (true)
          {
            int num2 = -96465328;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                num1 = (int) num3 * -274491972 ^ -913214927;
                continue;
              case 2:
                goto label_8;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      bool flag2 = newStatus == MeetingStatus.Attending;
label_14:
      int num4 = -1330003319;
      while (true)
      {
        int num1 = -96465328;
        uint num2;
        bool flag3;
        switch ((num2 = (uint) (num4 ^ num1)) % 12U)
        {
          case 0:
            goto label_14;
          case 1:
            this.HandleMeetingJoined();
            num4 = (int) num2 * -817049912 ^ 44912762;
            continue;
          case 2:
            num4 = (int) num2 * 417397191 ^ 1486991464;
            continue;
          case 3:
            num4 = (int) num2 * 1623631896 ^ -2052188027;
            continue;
          case 4:
            num4 = (int) num2 * -1293830874 ^ -1643986602;
            continue;
          case 5:
            flag3 = meetingStatus == MeetingStatus.Attending;
            num4 = -1518851656;
            continue;
          case 6:
            num4 = (int) num2 * 1570260827 ^ -1833681884;
            continue;
          case 7:
            this.HandleMeetingLeft();
            num4 = (int) num2 * -454673530 ^ -933890503;
            continue;
          case 8:
            int num3 = flag3 ? 1172625051 : (num3 = 1912967126);
            int num5 = (int) num2 * -35319210;
            num4 = num3 ^ num5;
            continue;
          case 9:
            int num6 = !flag2 ? -1965793742 : (num6 = -631218660);
            int num7 = (int) num2 * -325588893;
            num4 = num6 ^ num7;
            continue;
          case 10:
            goto label_16;
          case 11:
            num4 = (int) num2 * 2062570273 ^ -1241297197;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_16:;
    }

    private void HandleMeetingJoined()
    {
label_1:
      int num1 = 1495313947;
      while (true)
      {
        int num2 = 1793430274;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            this.capabilities.Subscribe();
            num1 = (int) num3 * -2129214573 ^ 497993316;
            continue;
          case 1:
            this.LoadMeetingButtons();
            num1 = (int) num3 * 402569753 ^ 821474846;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            ((CompositePresentationEvent<ZoomChat>) this._eventAggregator.GetEvent<ChatReceivedEvent>()).Subscribe(new Action<ZoomChat>(this.ChatReceived), (ThreadOption) 2);
            ((CompositePresentationEvent<ZoomChat>) this._eventAggregator.GetEvent<ChatReceivedEvent>()).Subscribe(new Action<ZoomChat>(this.ChatSent), (ThreadOption) 2);
            num1 = (int) num3 * -1776971376 ^ 1490324050;
            continue;
          case 5:
            this.MeetingWindow = this.Engine.GetWindow(ZoomWindowType.Meeting);
            num1 = (int) num3 * 194049902 ^ -868882133;
            continue;
          case 6:
            ((Collection<ZoomChat>) this.CurrentChats).Clear();
            num1 = (int) num3 * 1219192954 ^ -1306659398;
            continue;
          case 7:
            this.ChatButtonClickAttemptsCurrent = 0;
            num1 = (int) num3 * -1812683995 ^ 463295148;
            continue;
          case 8:
            this.CheckVideoEnabled();
            num1 = (int) num3 * -72582977 ^ 575945827;
            continue;
          case 9:
            this.ResetInitialActivities();
            num1 = (int) num3 * -2094113040 ^ 1590140018;
            continue;
          case 10:
            this.LoadMeetingVideos();
            num1 = (int) num3 * 1339710397 ^ 1471453364;
            continue;
          case 11:
            this.LastJoined = DateTime.Now;
            num1 = (int) num3 * 2074900492 ^ -1854686204;
            continue;
          case 12:
            num1 = (int) num3 * -929572511 ^ 196773104;
            continue;
          case 13:
            num1 = (int) num3 * 169315003 ^ 423720655;
            continue;
          case 14:
            this.UserCountCurrent = 0;
            num1 = (int) num3 * -1587754672 ^ -1503988804;
            continue;
          case 15:
            this.InitialInspectionPerformed = false;
            num1 = (int) num3 * -832942866 ^ -1715609636;
            continue;
          case 16:
            num1 = (int) num3 * -1015639064 ^ 948226382;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return;
label_3:;
    }

    private void HandleMeetingLeft()
    {
      try
      {
label_2:
        int num1 = 940538955;
        object meetingLock;
        while (true)
        {
          int num2 = 562210703;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 2:
              meetingLock = ZoomMeeting.meetingLock;
              num1 = (int) num3 * 133964703 ^ -1559065433;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        bool flag = false;
        try
        {
          ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag);
label_7:
          int num2 = 490217402;
          while (true)
          {
            int num3 = 562210703;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 12U)
            {
              case 0:
                int num5;
                num2 = num5 = this.MeetingVideos.get_IsEmpty() ? 382174520 : (num5 = 1449140368);
                continue;
              case 1:
                this.capabilities.Unsubscribe();
                num2 = (int) num4 * 1694493409 ^ 1022505154;
                continue;
              case 2:
                goto label_7;
              case 3:
                ((Collection<ZoomButton>) this.MeetingButtons).Clear();
                num2 = (int) num4 * 1507308745 ^ 1158161692;
                continue;
              case 4:
                num2 = (int) num4 * 626753809 ^ 1602558541;
                continue;
              case 5:
                ((Collection<ZoomChat>) this.CurrentChats).Clear();
                num2 = (int) num4 * -1695906643 ^ -20216669;
                continue;
              case 7:
                MeetingVideo meetingVideo;
                this.MeetingVideos.TryTake(ref meetingVideo);
                num2 = 1863904113;
                continue;
              case 8:
                num2 = (int) num4 * 2067620602 ^ -1444685957;
                continue;
              case 9:
                num2 = (int) num4 * -826625256 ^ -1371588348;
                continue;
              case 10:
                num2 = (int) num4 * -1768521210 ^ 1091539583;
                continue;
              case 11:
                this.MeetingWindow = (ZoomWindow) null;
                num2 = (int) num4 * 1870756487 ^ -433881733;
                continue;
              default:
                goto label_25;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_20:
            int num2 = 2033607820;
            while (true)
            {
              int num3 = 562210703;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_20;
                case 2:
                  num2 = (int) num4 * 2095381607 ^ 1231645140;
                  continue;
                case 3:
                  ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                  num2 = (int) num4 * 414482312 ^ 673785909;
                  continue;
                default:
                  goto label_24;
              }
            }
          }
label_24:;
        }
label_25:
        ((CompositePresentationEvent<ZoomChat>) this._eventAggregator.GetEvent<ChatReceivedEvent>()).Unsubscribe(new Action<ZoomChat>(this.ChatReceived));
label_26:
        int num6 = 29594726;
        while (true)
        {
          int num2 = 562210703;
          uint num3;
          switch ((num3 = (uint) (num6 ^ num2)) % 4U)
          {
            case 0:
              goto label_37;
            case 1:
              ((CompositePresentationEvent<ZoomChat>) this._eventAggregator.GetEvent<ChatReceivedEvent>()).Unsubscribe(new Action<ZoomChat>(this.ChatSent));
              num6 = (int) num3 * -515022377 ^ 465770259;
              continue;
            case 2:
              goto label_26;
            case 3:
              num6 = (int) num3 * 389877811 ^ 341121650;
              continue;
            default:
              goto label_35;
          }
        }
label_35:
        return;
label_37:;
      }
      catch (Exception ex)
      {
label_33:
        int num1 = 1976328390;
        while (true)
        {
          int num2 = 562210703;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_33;
            case 1:
              goto label_31;
            case 2:
              ZoomMeeting.\u206A​‬⁪‪⁪⁭‌⁮⁬‫‌‬‪⁪⁮‌⁯‭⁪​‎‮⁯‪⁯‍‏‎⁮‫‪⁬​​‍⁪‎‌‎‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -240816708 ^ -1765184397;
              continue;
            default:
              goto label_28;
          }
        }
label_28:
        return;
label_31:;
      }
    }

    private void CheckVideoEnabled()
    {
      if (this.Engine.Settings.StartVideoAfterJoining)
        goto label_4;
label_1:
      int num1 = 24090557;
label_2:
      bool flag1;
      while (true)
      {
        int num2 = 381870986;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            if (flag1)
            {
              num1 = (int) num3 * 681110672 ^ -464784644;
              continue;
            }
            goto label_60;
          case 3:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_3:
      int num4 = this.Engine.Settings.StopVideoAfterJoining ? 1 : 0;
      goto label_5;
label_60:
      return;
label_8:
      try
      {
label_10:
        int num2 = 1376226393;
        ZoomWindow window;
        while (true)
        {
          int num3 = 381870986;
          uint num5;
          bool flag2;
          switch ((num5 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              if (flag2)
              {
                num2 = (int) num5 * 382905473 ^ -1242531009;
                continue;
              }
              goto label_51;
            case 2:
              goto label_10;
            case 3:
              num2 = (int) num5 * 1394811175 ^ -1725770294;
              continue;
            case 4:
              flag2 = window != null;
              num2 = (int) num5 * 1419844887 ^ 1972316028;
              continue;
            case 5:
              window = this.Engine.GetWindow(ZoomWindowType.MeetingButtonBar);
              num2 = (int) num5 * -150767576 ^ 1355664280;
              continue;
            default:
              goto label_17;
          }
        }
label_17:
        Bitmap windowSectionAsBitmap = window.GetWindowSectionAsBitmap(0, 0, 200, window.Size.Height);
        try
        {
          bool flag2 = windowSectionAsBitmap != null;
label_19:
          int num3 = 1352740897;
          while (true)
          {
            int num5 = 381870986;
            uint num6;
            bool flag3;
            switch ((num6 = (uint) (num3 ^ num5)) % 22U)
            {
              case 0:
                num3 = 1749284442;
                continue;
              case 1:
                num3 = (int) num6 * 569251868 ^ -618113009;
                continue;
              case 2:
                num3 = (int) num6 * 974003680 ^ -1314116399;
                continue;
              case 3:
                CoreObject.log.Error((object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1923151897U));
                num3 = (int) num6 * 1940599740 ^ -212516992;
                continue;
              case 4:
                goto label_19;
              case 5:
                num3 = 491639223;
                continue;
              case 6:
                num3 = (int) num6 * -1547670261 ^ -304939252;
                continue;
              case 7:
                num3 = (int) num6 * 333601547 ^ 856540912;
                continue;
              case 8:
                num3 = (int) num6 * -51704488 ^ 1582030471;
                continue;
              case 9:
                num3 = (int) num6 * -453183662 ^ -2024365147;
                continue;
              case 10:
                num3 = (int) num6 * -11029161 ^ 580444531;
                continue;
              case 11:
                num3 = 894790393;
                continue;
              case 12:
                CoreObject.log.Debug((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(424944930U));
                num3 = (int) num6 * 244219166 ^ 1635141072;
                continue;
              case 14:
                num3 = (int) num6 * 1682972471 ^ 1715688474;
                continue;
              case 15:
                num3 = 2021145865;
                continue;
              case 16:
                CoreObject.log.Debug((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2049317313U));
                num3 = (int) num6 * 1723967872 ^ -501208430;
                continue;
              case 17:
                flag3 = ImageHelper.isImageThere(windowSectionAsBitmap, Resources.VideoStarted) != null;
                num3 = (int) num6 * 1734556412 ^ 1357957657;
                continue;
              case 18:
                MouseHelper.ClickWindowPosition(window.Handle, 145, 30, true, 0, true);
                num3 = (int) num6 * -2026620410 ^ 1844872187;
                continue;
              case 19:
                int num7 = !flag3 ? -2048153386 : (num7 = -603392016);
                int num8 = (int) num6 * 134001818;
                num3 = num7 ^ num8;
                continue;
              case 20:
                num3 = (int) num6 * 1438194811 ^ -1824104668;
                continue;
              case 21:
                int num9 = !flag2 ? 632287511 : (num9 = 1113877550);
                int num10 = (int) num6 * 656990094;
                num3 = num9 ^ num10;
                continue;
              default:
                goto label_47;
            }
          }
        }
        finally
        {
          if (windowSectionAsBitmap != null)
          {
label_42:
            int num3 = 1271033631;
            while (true)
            {
              int num5 = 381870986;
              uint num6;
              switch ((num6 = (uint) (num3 ^ num5)) % 4U)
              {
                case 0:
                  num3 = (int) num6 * -1408878877 ^ 1940682921;
                  continue;
                case 1:
                  windowSectionAsBitmap.Dispose();
                  num3 = (int) num6 * -1422427703 ^ 422921195;
                  continue;
                case 2:
                  goto label_42;
                default:
                  goto label_46;
              }
            }
          }
label_46:;
        }
label_47:
label_48:
        int num11 = 737248147;
label_49:
        while (true)
        {
          int num3 = 381870986;
          uint num5;
          switch ((num5 = (uint) (num11 ^ num3)) % 8U)
          {
            case 0:
              num11 = 1112716420;
              continue;
            case 1:
              num11 = (int) num5 * -309768106 ^ 1894437284;
              continue;
            case 2:
              CoreObject.log.Warn((object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3527934915U));
              num11 = (int) num5 * -1517289457 ^ -434526136;
              continue;
            case 3:
              goto label_48;
            case 4:
              num11 = (int) num5 * -458727414 ^ 1510333037;
              continue;
            case 5:
              goto label_51;
            case 7:
              num11 = (int) num5 * 451085124 ^ 70403262;
              continue;
            default:
              goto label_61;
          }
        }
label_51:
        num11 = 1924899136;
        goto label_49;
      }
      catch (Exception ex)
      {
        CoreObject.log.Error((object) ex);
label_57:
        int num2 = 1035175492;
        while (true)
        {
          int num3 = 381870986;
          uint num5;
          switch ((num5 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_57;
            case 1:
              num2 = (int) num5 * -1709491927 ^ -1652780733;
              continue;
            default:
              goto label_61;
          }
        }
      }
label_61:
      return;
label_4:
      num4 = 1;
label_5:
      flag1 = num4 != 0;
      num1 = 1129462891;
      goto label_2;
    }

    internal void LoadMeetingButtons()
    {
      bool flag = this.MeetingWindow != null;
label_1:
      int num1 = -1910342034;
      List<ZoomButton> buttons;
      while (true)
      {
        int num2 = -4813518;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            ZoomMeeting.\u202E​⁫⁮‌‪‬⁬⁬‫‎‌‬‏‭‍‫⁬‫‭‭⁪⁯‎‍‏⁬‌⁭‪‪⁫‌‪⁭‭​‫‌⁮‮(CoreObject.log, (object) ZoomMeeting.\u206C‌⁪‌⁭⁮‪‪​⁯⁭⁪‪‍‭⁪‏⁫‏‌‌‌‌‌⁮⁪‬⁮⁫‌⁪‬‬‎‭‭⁭‏⁪‫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4154982996U), (object) buttons.Count));
            num1 = (int) num3 * -183556386 ^ -923612666;
            continue;
          case 2:
            buttons = this.Engine.GetButtons("");
            num1 = (int) num3 * -221463923 ^ 126316901;
            continue;
          case 3:
            if (flag)
            {
              num1 = (int) num3 * 20608081 ^ 2141510819;
              continue;
            }
            goto label_40;
          case 4:
            num4 = ZoomMeeting.\u206F⁯⁬⁪‪‮‭⁭⁬‭‮‏⁪‪‪‫⁯⁯⁪⁮‬‫‭⁯⁯⁫​‪‍⁪​⁬‭⁫‪⁭⁮‌‪‪‮(this.Engine.ActivePattern.PatternName, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(765263131U)) ? 1 : 0;
            break;
          case 6:
            if (this.Engine.ActivePattern != null)
            {
              num1 = (int) num3 * 1855963955 ^ 1085064989;
              continue;
            }
            num4 = 0;
            break;
          default:
            goto label_13;
        }
        if (num4 != 0)
          num1 = -657404092;
        else
          goto label_41;
      }
label_40:
      return;
label_13:
      ZoomWindow window = this.Engine.GetWindow(ZoomWindowType.MeetingButtonBar);
      using (List<ZoomButton>.Enumerator enumerator = buttons.GetEnumerator())
      {
label_25:
        int num2 = enumerator.MoveNext() ? -1747415897 : (num2 = -140849075);
        while (true)
        {
          int num3 = -4813518;
          uint num4;
          ZoomButton current;
          switch ((num4 = (uint) (num2 ^ num3)) % 19U)
          {
            case 0:
              num2 = (int) num4 * -1111592074 ^ 1103890277;
              continue;
            case 1:
              num2 = (int) num4 * -1083212007 ^ -1497628228;
              continue;
            case 2:
              window.Click(new System.Drawing.Point(current.ButtonX, 5), true, true, 0);
              num2 = (int) num4 * 402573215 ^ 554797232;
              continue;
            case 3:
              ZoomMeeting.\u202E​⁫⁮‌‪‬⁬⁬‫‎‌‬‏‭‍‫⁬‫‭‭⁪⁯‎‍‏⁬‌⁭‪‪⁫‌‪⁭‭​‫‌⁮‮(CoreObject.log, (object) ZoomMeeting.\u200E‎⁭⁫‏‪‫​‮‮⁯‌‍‏‌‌‏‏​⁯‏⁪‌⁮‫‬​‏‬‬‍‪‮‪⁫‌⁭‫‭⁯‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3238417011U), (object) current.ResultingWindowType, (object) current.ButtonLocation, (object) window.Rectangle));
              num2 = (int) num4 * -56099484 ^ -1729868675;
              continue;
            case 4:
              window.Click(new System.Drawing.Point(current.ButtonX, 5), true, true, 0);
              num2 = (int) num4 * 1474906070 ^ -592949534;
              continue;
            case 6:
              num2 = (int) num4 * -243765193 ^ -1927699317;
              continue;
            case 7:
              num2 = (int) num4 * -1529935952 ^ 1511895105;
              continue;
            case 8:
              num2 = (int) num4 * 2044022408 ^ 835017324;
              continue;
            case 9:
              num2 = (int) num4 * -1895171716 ^ -792493695;
              continue;
            case 10:
              int num5 = window != null ? -575179625 : (num5 = -1881334981);
              int num6 = (int) num4 * 1405869695;
              num2 = num5 ^ num6;
              continue;
            case 11:
              current = enumerator.Current;
              num2 = -37391169;
              continue;
            case 12:
              goto label_25;
            case 13:
              num2 = -1526153880;
              continue;
            case 14:
              num2 = -1747415897;
              continue;
            case 15:
              num2 = (int) num4 * -677827169 ^ 1954678311;
              continue;
            case 16:
              Thread.Sleep(50);
              num2 = (int) num4 * 2058686606 ^ -1508079241;
              continue;
            case 17:
              num2 = (int) num4 * 1282915276 ^ -1411162152;
              continue;
            case 18:
              window.Activate();
              num2 = (int) num4 * -885810776 ^ 2118584405;
              continue;
            default:
              goto label_37;
          }
        }
      }
label_37:
label_38:
      int num7 = -1593502385;
label_39:
      while (true)
      {
        int num2 = -4813518;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            num7 = (int) num3 * 713241436 ^ 294417532;
            continue;
          case 1:
            goto label_41;
          case 2:
            goto label_35;
          case 3:
            goto label_38;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_35:
      return;
label_41:
      // ISSUE: method pointer
      System.Windows.Application.Current.Dispatcher.Invoke(new Action((object) this, __methodptr(\u003CLoadMeetingButtons\u003Eb__165_0)));
      num7 = -1840337498;
      goto label_39;
    }

    private void LoadMeetingVideos()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      IEnumerator<ZoomWindow> enumerator = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (ZoomMeeting.\u003C\u003Ec.\u003C\u003E9__166_0 ?? (ZoomMeeting.\u003C\u003Ec.\u003C\u003E9__166_0 = new Func<ZoomWindow, bool>((object) ZoomMeeting.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CLoadMeetingVideos\u003Eb__166_0)))))).GetEnumerator();
      try
      {
label_9:
        int num1 = !ZoomMeeting.\u206E⁮‪‭‪⁯‎⁬‎‎‌⁭‎⁭‭‭‫‬‏‮‍⁭⁮​‬⁯‮‫‌‌‌‎‬‮‫⁫⁮⁮​‭‮((IEnumerator) enumerator) ? -1180250636 : (num1 = -195845778);
        while (true)
        {
          int num2 = -572961633;
          uint num3;
          ZoomWindow current;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.UpdateMeetingVideo(current);
              num1 = (int) num3 * -1636070332 ^ -1943367351;
              continue;
            case 1:
              current = enumerator.Current;
              num1 = -1858496901;
              continue;
            case 2:
              num1 = (int) num3 * 1931453182 ^ 1083413116;
              continue;
            case 4:
              num1 = (int) num3 * -1504597402 ^ -1394222593;
              continue;
            case 5:
              num1 = -195845778;
              continue;
            case 6:
              num1 = (int) num3 * -1107435209 ^ 1718144975;
              continue;
            case 7:
              goto label_9;
            default:
              goto label_16;
          }
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_11:
          int num1 = -105875570;
          while (true)
          {
            int num2 = -572961633;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * 971668989 ^ 402312033;
                continue;
              case 1:
                ZoomMeeting.\u200C‬⁯‏‭‌⁬‬⁬⁬‭‌‏‭⁪‫‭‮⁫⁭⁮‬‍‫‮⁪⁪‌⁯‬‏⁯⁪‭‌‎‭⁮‫‪‮((IDisposable) enumerator);
                num1 = (int) num3 * -1848748877 ^ -372729524;
                continue;
              case 3:
                goto label_11;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_16:
      object meetingLock = ZoomMeeting.meetingLock;
      bool flag = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag);
label_18:
        int num1 = -1334507504;
        while (true)
        {
          int num2 = -572961633;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              num1 = (int) num3 * 1350637839 ^ 129168844;
              continue;
            case 1:
              num1 = (int) num3 * 2010059887 ^ 1828297055;
              continue;
            case 2:
              num1 = (int) num3 * -199318538 ^ 738649335;
              continue;
            case 3:
              int num4 = this.VideoImages == null ? -1970684302 : (num4 = -733602483);
              int num5 = (int) num3 * 1496196256;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.VideoImages = new LockedObservableCollection<ZoomImage>();
              num1 = (int) num3 * -719986016 ^ 1226005388;
              continue;
            case 5:
              goto label_33;
            case 6:
              num1 = (int) num3 * 1421134694 ^ 1720810155;
              continue;
            case 7:
              goto label_18;
            case 8:
              num1 = (int) num3 * -370575595 ^ 1336018268;
              continue;
            case 9:
              num1 = (int) num3 * 2096422013 ^ -2003261849;
              continue;
            case 10:
              ((Collection<ZoomImage>) this.VideoImages).Clear();
              num1 = -818154285;
              continue;
            default:
              goto label_29;
          }
        }
label_29:
        return;
label_33:;
      }
      finally
      {
        if (flag)
        {
label_31:
          int num1 = -1645138022;
          while (true)
          {
            int num2 = -572961633;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                num1 = (int) num3 * -1732754611 ^ -1042291994;
                continue;
              case 2:
                goto label_31;
              default:
                goto label_35;
            }
          }
        }
label_35:;
      }
    }

    internal void UpdateMeetingVideo(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 99133435;
      while (true)
      {
        int num2 = 1198346112;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1769980524 ^ 2141186158;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.UpdateMeetingVideo(zoomEvent.Window);
            num1 = (int) num3 * 349430911 ^ 701027760;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    internal void UpdateMeetingVideo(ZoomWindow videoWindow)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ZoomMeeting.\u003C\u003Ec__DisplayClass168_0 displayClass1680 = new ZoomMeeting.\u003C\u003Ec__DisplayClass168_0();
label_1:
      int num1 = -2008074892;
      MeetingVideo meetingVideo1;
      object meetingLock;
      while (true)
      {
        int num2 = -37781873;
        uint num3;
        MeetingVideo meetingVideo2;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * 2029016126 ^ -1314916707;
            continue;
          case 1:
            if (flag)
            {
              num1 = (int) num3 * -7034930 ^ -1925589191;
              continue;
            }
            goto label_18;
          case 2:
            // ISSUE: reference to a compiler-generated field
            meetingVideo1 = new MeetingVideo(displayClass1680.videoWindow);
            meetingLock = ZoomMeeting.meetingLock;
            num1 = (int) num3 * 1555162373 ^ 592633530;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            displayClass1680.videoWindow = videoWindow;
            num1 = (int) num3 * -416943810 ^ -689347919;
            continue;
          case 4:
            // ISSUE: method pointer
            meetingVideo2 = (MeetingVideo) Enumerable.FirstOrDefault<MeetingVideo>((IEnumerable<M0>) this.MeetingVideos, (Func<M0, bool>) new Func<MeetingVideo, bool>((object) displayClass1680, __methodptr(\u003CUpdateMeetingVideo\u003Eb__0)));
            num1 = (int) num3 * 1963161498 ^ -719742751;
            continue;
          case 5:
            goto label_1;
          case 6:
            flag = meetingVideo2 == null;
            num1 = (int) num3 * -571274061 ^ 365399460;
            continue;
          default:
            goto label_10;
        }
      }
label_18:
      return;
label_10:
      bool flag1 = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag1);
label_12:
        int num2 = -416791073;
        while (true)
        {
          int num3 = -37781873;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              this.MeetingVideos.Add(meetingVideo1);
              num2 = (int) num4 * -264350084 ^ -691102393;
              continue;
            case 2:
              goto label_12;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_16:
          int num2 = -1392432568;
          while (true)
          {
            int num3 = -37781873;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                num2 = (int) num4 * -1616564826 ^ -1957414351;
                continue;
              case 2:
                goto label_16;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:;
    }

    internal void AddButton(ZoomButton button)
    {
      try
      {
label_2:
        int num1 = -1110008980;
        while (true)
        {
          int num2 = -119213331;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 1352519277 ^ 1207788890;
              continue;
            case 2:
              ((Collection<ZoomButton>) this.MeetingButtons).Add(button);
              num1 = (int) num3 * -1191194900 ^ -723285232;
              continue;
            case 3:
              goto label_17;
            case 4:
              int num4 = ((Collection<ZoomButton>) this.MeetingButtons).Contains(button) ? 74301687 : (num4 = 1763366958);
              int num5 = (int) num3 * -737717994;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = -1671295949;
              continue;
            case 6:
              num1 = (int) num3 * -568471062 ^ 1272732133;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_17:;
      }
      catch (Exception ex)
      {
label_12:
        int num1 = -1046165822;
        while (true)
        {
          int num2 = -119213331;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1995846673 ^ 291118720;
              continue;
            case 1:
              goto label_10;
            case 2:
              goto label_12;
            case 3:
              ZoomMeeting.\u206A​‬⁪‪⁪⁭‌⁮⁬‫‌‬‪⁪⁮‌⁯‭⁪​‎‮⁯‪⁯‍‏‎⁮‫‪⁬​​‍⁪‎‌‎‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -229277372 ^ -1620799771;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_10:;
      }
    }

    internal void RemoveButton(ZoomButton button)
    {
      try
      {
label_2:
        int num1 = -1750648631;
        while (true)
        {
          int num2 = -1897016120;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_22;
            case 1:
              num1 = -1820820317;
              continue;
            case 2:
              num4 = ((Collection<ZoomButton>) this.MeetingButtons).Contains(button) ? 1 : 0;
              break;
            case 3:
              goto label_2;
            case 4:
              ((Collection<ZoomButton>) this.MeetingButtons).Remove(button);
              num1 = (int) num3 * 1330369916 ^ 100637523;
              continue;
            case 5:
              if (!button.AutoGenerated)
              {
                num1 = (int) num3 * -1512273213 ^ -746434258;
                continue;
              }
              num4 = 0;
              break;
            case 6:
              int num5 = !flag ? -1235332989 : (num5 = -269524173);
              int num6 = (int) num3 * 1266180446;
              num1 = num5 ^ num6;
              continue;
            default:
              goto label_17;
          }
          flag = num4 != 0;
          num1 = -132701090;
        }
label_17:
        return;
label_22:;
      }
      catch (Exception ex)
      {
label_15:
        int num1 = -784324548;
        while (true)
        {
          int num2 = -1897016120;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_15;
            case 1:
              num1 = (int) num3 * -1482726912 ^ -443331275;
              continue;
            case 2:
              num1 = (int) num3 * 860770380 ^ -966738193;
              continue;
            case 3:
              num1 = (int) num3 * 1086505190 ^ 315958898;
              continue;
            case 4:
              goto label_13;
            case 5:
              ZoomMeeting.\u206A​‬⁪‪⁪⁭‌⁮⁬‫‌‬‪⁪⁮‌⁯‭⁪​‎‮⁯‪⁯‍‏‎⁮‫‪⁬​​‍⁪‎‌‎‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 424038341 ^ -1837731212;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_13:;
      }
    }

    internal void SetUserCount()
    {
label_1:
      int num1 = -313036187;
      while (true)
      {
        int num2 = -283475629;
        uint num3;
        ZoomWindow window;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -265027476 ^ -1032470982;
            continue;
          case 2:
            num1 = (int) num3 * 1201519584 ^ 930543914;
            continue;
          case 3:
            flag = window != null;
            num1 = (int) num3 * -2040539001 ^ 279684193;
            continue;
          case 4:
            this.SetUserCount(window);
            num1 = (int) num3 * -455179686 ^ 386627529;
            continue;
          case 5:
            goto label_3;
          case 6:
            window = this.Engine.GetWindow(ZoomWindowType.Participants);
            num1 = (int) num3 * 286898363 ^ -290353062;
            continue;
          case 7:
            int num4 = flag ? 2106364342 : (num4 = 225191455);
            int num5 = (int) num3 * 1770243175;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    internal void SetUserCount(ZoomWindow window)
    {
label_1:
      int num1 = 296993408;
      object meetingLock;
      int result;
      while (true)
      {
        int num2 = 148809609;
        uint num3;
        bool flag1;
        string s;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            this.Engine.WindowManager.HandleNewMeetingAttendee();
            num1 = (int) num3 * -400747895 ^ 1822888968;
            continue;
          case 1:
            num1 = (int) num3 * -247883303 ^ -1752748100;
            continue;
          case 2:
            num1 = (int) num3 * -1957071741 ^ 421505029;
            continue;
          case 3:
            result = 0;
            flag1 = int.TryParse(s, out result);
            num1 = (int) num3 * -1449377995 ^ -231400912;
            continue;
          case 5:
            num1 = (int) num3 * 799731658 ^ 1849053248;
            continue;
          case 6:
            if (flag1)
            {
              num1 = (int) num3 * 710459803 ^ 1033055881;
              continue;
            }
            goto label_38;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num3 * -105371317 ^ 1387222348;
            continue;
          case 9:
            if (ZoomMeeting.\u200D⁮‫‬⁭⁫⁮‌‌‫‍​‬⁮‬⁭⁪⁪⁪⁭⁪​⁭⁫‫⁫‬‌‏‬⁯‎‭⁬‎⁮​​⁯‍‮(window.Title, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1682258277U)))
            {
              num1 = (int) num3 * 1624670022 ^ 1108771191;
              continue;
            }
            goto label_35;
          case 10:
            flag2 = result > this.UserCountCurrent;
            num1 = (int) num3 * 2093693672 ^ -501269545;
            continue;
          case 11:
            meetingLock = ZoomMeeting.meetingLock;
            num1 = (int) num3 * -888289148 ^ 155307249;
            continue;
          case 12:
            if (result != this.UserCountCurrent)
            {
              num1 = 1373594844;
              continue;
            }
            goto label_36;
          case 13:
            s = window.Title;
            num1 = (int) num3 * -1814179664 ^ -511392906;
            continue;
          case 14:
            int num4 = !flag2 ? 562646577 : (num4 = 786577277);
            int num5 = (int) num3 * -1120618626;
            num1 = num4 ^ num5;
            continue;
          case 15:
            s = ZoomMeeting.\u206A‪⁬‌⁫‫‮​‬‌‌‌‏‪⁮‫‫⁮‮⁮‮‭⁫‪⁪⁯⁬‏‌‌⁯‎‎⁬‍‍⁯‬‫‏‮(ZoomMeeting.\u206A‪⁬‌⁫‫‮​‬‌‌‌‏‪⁮‫‫⁮‮⁮‮‭⁫‪⁪⁯⁬‏‌‌⁯‎‎⁬‍‍⁯‬‫‏‮(s, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1682258277U), ""), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2702267255U), "");
            num1 = (int) num3 * 601136699 ^ 1894874783;
            continue;
          default:
            goto label_20;
        }
      }
label_35:
      return;
label_20:
      bool flag = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag);
label_22:
        int num2 = 1995692503;
        while (true)
        {
          int num3 = 148809609;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_22;
            case 1:
              this.UserCountCurrent = result;
              num2 = (int) num4 * 116979298 ^ -1810575689;
              continue;
            default:
              goto label_32;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_27:
          int num2 = 1779655940;
          while (true)
          {
            int num3 = 148809609;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_27;
              case 2:
                ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                num2 = (int) num4 * 201158023 ^ 1672374155;
                continue;
              default:
                goto label_31;
            }
          }
        }
label_31:;
      }
label_32:
label_33:
      int num6 = 1624367586;
label_34:
      while (true)
      {
        int num2 = 148809609;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 6U)
        {
          case 0:
            num6 = (int) num3 * -727468629 ^ -761008465;
            continue;
          case 1:
            goto label_38;
          case 2:
            goto label_33;
          case 3:
            goto label_29;
          case 4:
            num6 = 1370923564;
            continue;
          case 5:
            goto label_36;
          default:
            goto label_25;
        }
      }
label_25:
      return;
label_29:
      return;
label_36:
      num6 = 1756294013;
      goto label_34;
label_38:
      num6 = 845415507;
      goto label_34;
    }

    internal void ResetInitialActivities()
    {
      object meetingLock = ZoomMeeting.meetingLock;
      bool flag1 = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag1);
label_2:
        int num1 = -1955266967;
        while (true)
        {
          int num2 = -1809802353;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              ZoomMeeting.initialActivities = new ConcurrentQueue<ActivityBase>();
              num1 = (int) num3 * -1772938009 ^ -195606203;
              continue;
            case 1:
              num1 = (int) num3 * 1009938423 ^ 251157813;
              continue;
            case 2:
              goto label_2;
            case 4:
              num1 = (int) num3 * 1764215969 ^ -809383801;
              continue;
            default:
              goto label_13;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_8:
          int num1 = -1787140178;
          while (true)
          {
            int num2 = -1809802353;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                num1 = (int) num3 * -144902138 ^ 1192754887;
                continue;
              case 2:
                num1 = (int) num3 * -1936188988 ^ -264668709;
                continue;
              case 3:
                goto label_8;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      if (this.SuspendMeetingActivities)
        goto label_47;
label_14:
      int num4 = -1359220457;
label_15:
      bool flag2;
      while (true)
      {
        int num1 = -1809802353;
        uint num2;
        FindButtons findButtons;
        bool flag3;
        bool meetingAfterJoin;
        FloodChat floodChat1;
        FloodChat floodChat2;
        bool flag4;
        bool flag5;
        FloodChat floodChat3;
        int num3;
        int num5;
        int num6;
        int num7;
        switch ((num2 = (uint) (num4 ^ num1)) % 39U)
        {
          case 1:
            goto label_46;
          case 2:
            int num8;
            num4 = num8 = !this.Engine.Settings.FindButtonsAfterJoin ? -1168472574 : (num8 = -888487690);
            continue;
          case 3:
            goto label_14;
          case 4:
            num4 = (int) num2 * 1704992736 ^ -762318390;
            continue;
          case 5:
            num4 = (int) num2 * -1399645475 ^ -632404878;
            continue;
          case 6:
            floodChat3 = new FloodChat(this.Engine.Settings.FloodOptions_MessageContent, 0, "");
            num4 = (int) num2 * 472988692 ^ -773945216;
            continue;
          case 7:
            num4 = (int) num2 * 1623142240 ^ -1147998933;
            continue;
          case 8:
            if (!this.Engine.Settings.FloodHostAfterJoin)
            {
              num3 = 0;
              goto label_44;
            }
            else
            {
              num4 = -515864390;
              continue;
            }
          case 9:
            int num9 = !meetingAfterJoin ? -745164401 : (num9 = -1768371060);
            int num10 = (int) num2 * 344831987;
            num4 = num9 ^ num10;
            continue;
          case 10:
            meetingAfterJoin = this.Engine.Settings.CaptureMeeting_AfterJoin;
            num4 = (int) num2 * 76272149 ^ 1886322229;
            continue;
          case 11:
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) findButtons);
            num4 = (int) num2 * -1917919268 ^ -354321942;
            continue;
          case 12:
            CaptureMeeting captureMeeting = new CaptureMeeting();
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) captureMeeting);
            num4 = (int) num2 * 649534209 ^ -280857872;
            continue;
          case 13:
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) floodChat3);
            num4 = (int) num2 * -1551062541 ^ -992674431;
            continue;
          case 14:
            num4 = (int) num2 * 1095219452 ^ -80213646;
            continue;
          case 15:
            num4 = (int) num2 * 416554327 ^ -1263464852;
            continue;
          case 16:
            if (flag2)
            {
              num4 = (int) num2 * 313538836 ^ 674927061;
              continue;
            }
            goto label_152;
          case 17:
            num4 = (int) num2 * -2138406871 ^ -1960797899;
            continue;
          case 18:
            num3 = !ZoomMeeting.\u202C‎‬⁮‫‍⁮⁫⁯‭‮‭⁪⁮‪‎‭‎⁮⁭‎‮‍⁬⁫⁬⁬​‪⁪⁪⁮⁯⁯⁯‌‭⁯‏⁬‮(this.Engine.Settings.FloodOptions_MessageContent) ? 1 : 0;
            goto label_44;
          case 19:
            floodChat2 = new FloodChat(this.Engine.Settings.FloodOptions_MessageContent, 0, "")
            {
              FloodHost = true
            };
            num4 = (int) num2 * -660823505 ^ -2062421103;
            continue;
          case 20:
            findButtons = new FindButtons(ZoomWindowType.Undefined);
            num4 = (int) num2 * -1968678674 ^ -448803003;
            continue;
          case 21:
            num5 = !ZoomMeeting.\u202C‎‬⁮‫‍⁮⁫⁯‭‮‭⁪⁮‪‎‭‎⁮⁭‎‮‍⁬⁫⁬⁬​‪⁪⁪⁮⁯⁯⁯‌‭⁯‏⁬‮(this.Engine.Settings.FloodOptions_MessageContent) ? 1 : 0;
            break;
          case 22:
            ZoomMeeting.\u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(312853996U));
            num4 = (int) num2 * -1821554409 ^ -1154773371;
            continue;
          case 23:
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) floodChat2);
            num4 = (int) num2 * 1096100228 ^ 25318124;
            continue;
          case 24:
            if (ZoomZoom.Properties.Settings.Default.FloodTargetsAfterJoin)
            {
              num4 = -384119129;
              continue;
            }
            num6 = 0;
            goto label_63;
          case 25:
            num7 = !ZoomMeeting.\u202C‎‬⁮‫‍⁮⁫⁯‭‮‭⁪⁮‪‎‭‎⁮⁭‎‮‍⁬⁫⁬⁬​‪⁪⁪⁮⁯⁯⁯‌‭⁯‏⁬‮(this.Engine.Settings.FloodOptions_MessageContent) ? 1 : 0;
            goto label_58;
          case 26:
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) floodChat1);
            num4 = (int) num2 * 11733535 ^ 750255147;
            continue;
          case 27:
            int num11 = !flag3 ? 476346971 : (num11 = 3781599);
            int num12 = (int) num2 * -309015083;
            num4 = num11 ^ num12;
            continue;
          case 28:
            ZoomMeeting.\u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1742603843U));
            num4 = (int) num2 * -812783299 ^ 1259399932;
            continue;
          case 29:
            if (!this.Engine.Settings.FloodAfterJoin)
            {
              num5 = 0;
              break;
            }
            num4 = -1243300996;
            continue;
          case 30:
            ZoomMeeting.\u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4031685197U));
            floodChat1 = new FloodChat(this.Engine.Settings.FloodOptions_MessageContent, 0, "")
            {
              FloodAllPrivately = true
            };
            num4 = (int) num2 * 1954144534 ^ -2020416170;
            continue;
          case 31:
            ZoomMeeting.\u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3465294373U));
            num4 = (int) num2 * -932980283 ^ -1627107058;
            continue;
          case 32:
            ZoomMeeting.\u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3518461905U));
            num4 = (int) num2 * -1854418522 ^ 748654860;
            continue;
          case 33:
            num4 = (int) num2 * -1167896329 ^ 1512752355;
            continue;
          case 34:
            num4 = (int) num2 * -476236133 ^ 233070518;
            continue;
          case 35:
            int num13 = !flag4 ? 640722996 : (num13 = 755510960);
            int num14 = (int) num2 * -1116655621;
            num4 = num13 ^ num14;
            continue;
          case 36:
            if (this.Engine.Settings.FloodPrivatelyAfterJoin)
            {
              num4 = -406649325;
              continue;
            }
            num7 = 0;
            goto label_58;
          case 37:
            if (flag5)
            {
              num4 = (int) num2 * -1612780081 ^ -832365803;
              continue;
            }
            goto label_112;
          case 38:
            num6 = !ZoomMeeting.\u202C‎‬⁮‫‍⁮⁫⁯‭‮‭⁪⁮‪‎‭‎⁮⁭‎‮‍⁬⁫⁬⁬​‪⁪⁪⁮⁯⁯⁯‌‭⁯‏⁬‮(this.Engine.Settings.FloodOptions_MessageContent) ? 1 : 0;
            goto label_63;
          default:
            goto label_69;
        }
        flag3 = num5 != 0;
        num4 = -293391743;
        continue;
label_44:
        flag4 = num3 != 0;
        num4 = -881674984;
        continue;
label_58:
        int num15;
        num4 = num15 = num7 != 0 ? -151270832 : (num15 = -5903612);
        continue;
label_63:
        flag5 = num6 != 0;
        num4 = -1848026756;
      }
label_152:
      return;
label_46:
      int num16 = !this.Engine.Settings.WarEnabled ? 1 : 0;
      goto label_48;
label_69:
      List<string>.Enumerator enumerator1 = this.Engine.Settings.FloodTargets.GetEnumerator();
      try
      {
label_78:
        int num1 = !enumerator1.MoveNext() ? -1372075293 : (num1 = -1782604800);
        while (true)
        {
          int num2 = -1809802353;
          uint num3;
          bool flag3;
          string current;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 1:
              flag3 = !ZoomMeeting.\u202C‎‬⁮‫‍⁮⁫⁯‭‮‭⁪⁮‪‎‭‎⁮⁭‎‮‍⁬⁫⁬⁬​‪⁪⁪⁮⁯⁯⁯‌‭⁯‏⁬‮(current);
              num1 = (int) num3 * 1719421070 ^ 1533309142;
              continue;
            case 2:
              FloodChat floodChat = new FloodChat(this.Engine.Settings.FloodOptions_MessageContent, 0, current);
              ZoomMeeting.initialActivities.Enqueue((ActivityBase) floodChat);
              num1 = (int) num3 * -1235241700 ^ 160396782;
              continue;
            case 3:
              int num5 = flag3 ? -1876927749 : (num5 = -595872066);
              int num6 = (int) num3 * 1509137224;
              num1 = num5 ^ num6;
              continue;
            case 4:
              num1 = -1782604800;
              continue;
            case 5:
              current = enumerator1.Current;
              num1 = -1518095970;
              continue;
            case 6:
              goto label_78;
            case 7:
              num1 = (int) num3 * -1093819722 ^ -262837936;
              continue;
            case 8:
              num1 = (int) num3 * 1665474993 ^ -365638185;
              continue;
            case 9:
              num1 = -1477858519;
              continue;
            default:
              goto label_86;
          }
        }
      }
      finally
      {
        enumerator1.Dispose();
label_82:
        int num1 = -2095331917;
        while (true)
        {
          int num2 = -1809802353;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_82;
            case 2:
              num1 = (int) num3 * -1089435405 ^ -645705141;
              continue;
            default:
              goto label_85;
          }
        }
label_85:;
      }
label_86:
label_87:
      int num17 = -1065800230;
label_88:
      bool capabilitiesAfterJoin;
      while (true)
      {
        int num1 = -1809802353;
        uint num2;
        bool flag3;
        List<MessageContent> messageContents;
        Random random;
        MessageContent messageContent;
        MessageCategory messageCategory;
        DateTime now;
        SendChat sendChat;
        bool flag4;
        switch ((num2 = (uint) (num17 ^ num1)) % 39U)
        {
          case 0:
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) sendChat);
            num17 = (int) num2 * -603903253 ^ 408302443;
            continue;
          case 1:
            InspectVideoWindow inspectVideoWindow = new InspectVideoWindow();
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) inspectVideoWindow);
            num17 = (int) num2 * -1149585483 ^ -1350174956;
            continue;
          case 2:
            num17 = -57133940;
            continue;
          case 3:
            messageContents.RemoveAll((Predicate<MessageContent>) (o => this.Monitor.HasBeenRecentlySent(o.ContentText)));
            num17 = (int) num2 * -1720800091 ^ 1591866150;
            continue;
          case 4:
            int num3 = !capabilitiesAfterJoin ? -1378797918 : (num3 = -1526968508);
            int num5 = (int) num2 * 1324172348;
            num17 = num3 ^ num5;
            continue;
          case 5:
            num17 = (int) num2 * 1056425699 ^ 1871386827;
            continue;
          case 6:
            flag4 = messageContents.Count > 0;
            num17 = (int) num2 * 1634067010 ^ -720995285;
            continue;
          case 7:
            sendChat = new SendChat(messageContent.ContentText, "");
            num17 = (int) num2 * 1459410118 ^ 571665227;
            continue;
          case 8:
            int num6;
            num17 = num6 = !this.Engine.Settings.VideoChatLinkAutoInitiate ? -817259354 : (num6 = -607449335);
            continue;
          case 9:
            ZoomMeeting.\u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(869499549U));
            num17 = (int) num2 * -2087281468 ^ 30225605;
            continue;
          case 10:
            num17 = (int) num2 * -506538442 ^ -612446445;
            continue;
          case 11:
            messageCategory = this.Engine.GetMessageCategory(this.Engine.Settings.ChatSource, false);
            num17 = (int) num2 * -2087494140 ^ 823508706;
            continue;
          case 12:
            num17 = (int) num2 * -460771191 ^ -748027861;
            continue;
          case 13:
            num17 = (int) num2 * 1065618031 ^ -1415076241;
            continue;
          case 14:
            num17 = (int) num2 * -865947208 ^ 659373349;
            continue;
          case 15:
            num17 = (int) num2 * 174002869 ^ 1259953112;
            continue;
          case 16:
            flag3 = this.Engine.Settings.MeetingAutoFindUsers != null;
            num17 = -2129059860;
            continue;
          case 17:
            CoreObject.log.Info((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2493871932U));
            num17 = (int) num2 * -2085474030 ^ 1298037251;
            continue;
          case 18:
            random = new Random(now.Millisecond);
            num17 = (int) num2 * 1962561770 ^ -951028259;
            continue;
          case 19:
            int num7 = flag4 ? -562226350 : (num7 = -772783746);
            int num8 = (int) num2 * 788028643;
            num17 = num7 ^ num8;
            continue;
          case 20:
            goto label_112;
          case 21:
            num17 = -449039752;
            continue;
          case 22:
            goto label_87;
          case 23:
            int num9;
            num17 = num9 = !this.Engine.Settings.SendGreetingAfterJoin ? -1657719940 : (num9 = -334651788);
            continue;
          case 25:
            ZoomMeeting.\u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1734717594U));
            FindMeetingCapabilities meetingCapabilities = new FindMeetingCapabilities();
            ZoomMeeting.initialActivities.Enqueue((ActivityBase) meetingCapabilities);
            num17 = (int) num2 * -1781901801 ^ -1066226670;
            continue;
          case 26:
            num17 = (int) num2 * 603373117 ^ 62791255;
            continue;
          case 27:
            int num10 = messageCategory == null ? -1045204000 : (num10 = -587917615);
            int num11 = (int) num2 * 704871224;
            num17 = num10 ^ num11;
            continue;
          case 28:
            messageContents = this.Engine.GetMessageContents(messageCategory);
            num17 = (int) num2 * 1451983026 ^ -2047611766;
            continue;
          case 29:
            num17 = (int) num2 * -225782368 ^ -711797683;
            continue;
          case 30:
            int num12 = ZoomMeeting.\u202D⁪‪⁪⁮‬⁭​‌‪⁫⁪⁬‌‫‍‬‏‍‌​‎⁪‪‌‌‫⁫‭⁭⁫‫⁪​‏‭‎⁯‪‍‮(this.Engine.Settings.ChatSource) ? -1944680268 : (num12 = -2061470907);
            int num13 = (int) num2 * -486663284;
            num17 = num12 ^ num13;
            continue;
          case 31:
            num17 = (int) num2 * 410114387 ^ -1657186310;
            continue;
          case 32:
            messageContent = messageContents[random.Next(messageContents.Count - 1)];
            num17 = (int) num2 * 192449433 ^ 1691192313;
            continue;
          case 33:
            now = DateTime.Now;
            num17 = (int) num2 * 1748760809 ^ -686315260;
            continue;
          case 34:
            num17 = (int) num2 * 1834737582 ^ -814205152;
            continue;
          case 35:
            num17 = (int) num2 * -611173945 ^ -1269909990;
            continue;
          case 36:
            if (flag3)
            {
              num17 = (int) num2 * 850793705 ^ -706019441;
              continue;
            }
            goto label_153;
          case 37:
            num17 = -1657719940;
            continue;
          case 38:
            num17 = (int) num2 * 294808975 ^ 2147043719;
            continue;
          default:
            goto label_127;
        }
      }
label_127:
      IEnumerator<StringItem> enumerator2 = ((Collection<StringItem>) this.Engine.Settings.MeetingAutoFindUsers).GetEnumerator();
      try
      {
label_137:
        int num1 = !enumerator2.MoveNext() ? -2043829630 : (num1 = -843736030);
        while (true)
        {
          int num2 = -1809802353;
          uint num3;
          bool flag3;
          string userName;
          StringItem current;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              flag3 = !string.IsNullOrWhiteSpace(userName);
              num1 = (int) num3 * -1819533100 ^ -2134741127;
              continue;
            case 1:
              current = enumerator2.Current;
              num1 = -530051247;
              continue;
            case 2:
              num1 = -1779030770;
              continue;
            case 3:
              FindUser findUser = new FindUser(userName, true);
              int num5 = 1;
              findUser.AutoGenerated = num5 != 0;
              this.Engine.AddActivity((ActivityBase) findUser, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1927481108U));
              num1 = (int) num3 * 1571555628 ^ 1834603240;
              continue;
            case 4:
              CoreObject.log.DebugFormat(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3858243973U), (object) userName);
              num1 = (int) num3 * 1118904008 ^ 1133390908;
              continue;
            case 6:
              userName = current.Value;
              num1 = (int) num3 * -279242411 ^ 385441585;
              continue;
            case 7:
              num1 = -843736030;
              continue;
            case 8:
              num1 = (int) num3 * 1589427407 ^ 504372823;
              continue;
            case 9:
              goto label_137;
            case 10:
              int num6 = flag3 ? 133726247 : (num6 = 2032505489);
              int num7 = (int) num3 * 1689554640;
              num1 = num6 ^ num7;
              continue;
            case 11:
              num1 = (int) num3 * 1579372662 ^ 1414049875;
              continue;
            default:
              goto label_149;
          }
        }
      }
      finally
      {
        if (enumerator2 != null)
        {
label_143:
          int num1 = -178563646;
          while (true)
          {
            int num2 = -1809802353;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                enumerator2.Dispose();
                num1 = (int) num3 * -1137046490 ^ 234466335;
                continue;
              case 2:
                num1 = (int) num3 * -1395694810 ^ -499920501;
                continue;
              case 3:
                goto label_143;
              default:
                goto label_148;
            }
          }
        }
label_148:;
      }
label_149:
label_150:
      int num18 = -236831187;
label_151:
      int num19 = -1809802353;
      uint num20;
      switch ((num20 = (uint) (num18 ^ num19)) % 3U)
      {
        case 0:
          return;
        case 1:
          break;
        case 2:
          goto label_150;
        default:
          return;
      }
label_153:
      num18 = -622421851;
      goto label_151;
label_112:
      capabilitiesAfterJoin = this.Engine.Settings.CheckCapabilitiesAfterJoin;
      num17 = -115491410;
      goto label_88;
label_47:
      num16 = 0;
label_48:
      flag2 = num16 != 0;
      num4 = -725979878;
      goto label_15;
    }

    internal void SetMeetingVideoStarted(MeetingVideo video)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ZoomMeeting.\u003C\u003Ec__DisplayClass174_0 displayClass1740 = new ZoomMeeting.\u003C\u003Ec__DisplayClass174_0();
label_1:
      int num1 = -1652873145;
      while (true)
      {
        int num2 = -1382867827;
        uint num3;
        MeetingVideo meetingVideo;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * -253601816 ^ -2048967817;
            continue;
          case 1:
            ZoomMeeting.\u202E​⁫⁮‌‪‬⁬⁬‫‎‌‬‏‭‍‫⁬‫‭‭⁪⁯‎‍‏⁬‌⁭‪‪⁫‌‪⁭‭​‫‌⁮‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2253964016U));
            num1 = (int) num3 * -1385439325 ^ -705507146;
            continue;
          case 2:
            num1 = (int) num3 * -1863529471 ^ -1523113720;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 516666145 ^ 1299594028;
            continue;
          case 5:
            meetingVideo.ChatLinkStarted = true;
            num1 = (int) num3 * 1758108678 ^ 612792998;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            displayClass1740.video = video;
            num1 = (int) num3 * -1396879077 ^ -2043360001;
            continue;
          case 7:
            num1 = -1621895664;
            continue;
          case 8:
            // ISSUE: method pointer
            meetingVideo = (MeetingVideo) Enumerable.FirstOrDefault<MeetingVideo>((IEnumerable<M0>) this.MeetingVideos, (Func<M0, bool>) new Func<MeetingVideo, bool>((object) displayClass1740, __methodptr(\u003CSetMeetingVideoStarted\u003Eb__0)));
            int num4 = meetingVideo == null ? -1511983410 : (num4 = -1203337135);
            int num5 = (int) num3 * -1237624024;
            num1 = num4 ^ num5;
            continue;
          case 9:
            num1 = (int) num3 * -744116349 ^ 352346104;
            continue;
          case 10:
            num1 = (int) num3 * -741390565 ^ 2083789772;
            continue;
          case 11:
            goto label_3;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    public void SetDisplayMode(DisplayMode displayMode)
    {
label_1:
      int num1 = -637280891;
      while (true)
      {
        int num2 = -609341887;
        uint num3;
        ZoomWindow activeMeetingWindow;
        string str;
        DisplayMode displayMode1;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 215788600 ^ 1302834386;
            continue;
          case 2:
            num1 = -1485684119;
            continue;
          case 3:
          case 10:
label_8:
            activeMeetingWindow.Activate();
            num1 = -1430825732;
            continue;
          case 4:
            activeMeetingWindow = this.Engine.ActiveMeetingWindow;
            str = "";
            int num4 = activeMeetingWindow != null ? 1374644652 : (num4 = 33893125);
            int num5 = (int) num3 * 1457994763;
            num1 = num4 ^ num5;
            continue;
          case 5:
            switch (displayMode1)
            {
              case DisplayMode.Unknown:
                goto label_8;
              case DisplayMode.Closed:
                goto label_10;
              case DisplayMode.GalleryView:
                goto label_6;
              case DisplayMode.SpeakerView:
                goto label_7;
              default:
                num1 = (int) num3 * 307686354 ^ 1238187045;
                continue;
            }
          case 6:
label_10:
            activeMeetingWindow.Close(false, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3736730756U));
            num1 = -1387854467;
            continue;
          case 7:
label_7:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3456319387U);
            num1 = -1745243966;
            continue;
          case 8:
            goto label_5;
          case 9:
            ZoomMeeting.\u202E‫‍‬‫‭​‎‭‪⁬⁭‫‬‎‪⁮⁬‍‮⁮⁫‬‫‫‭‎​⁭‬‫‍‎⁬‮⁯⁫⁪‌‍‮(str);
            num1 = (int) num3 * 717689563 ^ 2046563456;
            continue;
          case 11:
            displayMode1 = displayMode;
            num1 = (int) num3 * 579465421 ^ 1460921003;
            continue;
          case 12:
            num1 = (int) num3 * -810695519 ^ -1372036395;
            continue;
          case 13:
            int num6 = !ZoomMeeting.\u202D⁪‪⁪⁮‬⁭​‌‪⁫⁪⁬‌‫‍‬‏‍‌​‎⁪‪‌‌‫⁫‭⁭⁫‫⁪​‏‭‎⁯‪‍‮(str) ? -355578411 : (num6 = -453057554);
            int num7 = (int) num3 * -1601791183;
            num1 = num6 ^ num7;
            continue;
          case 14:
            num1 = (int) num3 * -735774231 ^ -245564331;
            continue;
          case 15:
label_6:
            str = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1561436558U);
            num1 = -1745243966;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return;
label_5:;
    }

    internal ZoomButton GetButton(ZoomWindowType windowType)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ZoomMeeting.\u003C\u003Ec__DisplayClass176_0 displayClass1760 = new ZoomMeeting.\u003C\u003Ec__DisplayClass176_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1760.\u003C\u003E4__this = this;
label_1:
      int num1 = 594145385;
      ZoomButton zoomButton;
      while (true)
      {
        int num2 = 445062666;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * 535046620 ^ 1839307101;
            continue;
          case 1:
            zoomButton = (ZoomButton) null;
            num1 = (int) num3 * -1004759405 ^ -1123075823;
            continue;
          case 2:
            int num4 = !flag ? -466527105 : (num4 = -728210580);
            int num5 = (int) num3 * 576038138;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * -954664201 ^ 235527829;
            continue;
          case 5:
            goto label_1;
          case 6:
            // ISSUE: method pointer
            zoomButton = (ZoomButton) Enumerable.FirstOrDefault<ZoomButton>((IEnumerable<M0>) this.Engine.Buttons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) displayClass1760, __methodptr(\u003CGetButton\u003Eb__0)));
            num1 = (int) num3 * -1896888066 ^ -184390970;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            displayClass1760.windowType = windowType;
            num1 = (int) num3 * -1883918978 ^ -977853122;
            continue;
          case 8:
            flag = this.Engine.ActiveMeeting != null;
            num1 = (int) num3 * 1876851137 ^ 1286410008;
            continue;
          case 9:
            num1 = 1142929727;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return zoomButton;
    }

    private void ChatSent(ZoomChat obj)
    {
label_1:
      int num1 = -513736222;
      object meetingLock;
      while (true)
      {
        int num2 = -1653171997;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            meetingLock = ZoomMeeting.meetingLock;
            num1 = (int) num3 * -1349134548 ^ 185716185;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag);
label_6:
        int num2 = -514605289;
        while (true)
        {
          int num3 = -1653171997;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * -1467976417 ^ -107961048;
              continue;
            case 1:
              goto label_15;
            case 2:
              goto label_6;
            case 3:
              ((Collection<ZoomChat>) this.CurrentChats).Add(obj);
              num2 = (int) num4 * -178525016 ^ 831985273;
              continue;
            case 4:
              num2 = (int) num4 * -900219656 ^ 1586142672;
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
          int num2 = -67948480;
          while (true)
          {
            int num3 = -1653171997;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_13;
              case 2:
                ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                num2 = (int) num4 * -1579428953 ^ 1701806061;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    private void ChatReceived(ZoomChat obj)
    {
      object meetingLock = ZoomMeeting.meetingLock;
      bool flag = false;
      try
      {
        ZoomMeeting.\u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮(meetingLock, ref flag);
        ((Collection<ZoomChat>) this.CurrentChats).Add(obj);
      }
      finally
      {
        if (flag)
        {
label_3:
          int num1 = -909425006;
          while (true)
          {
            int num2 = -2117126640;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_3;
              case 2:
                ZoomMeeting.\u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮(meetingLock);
                num1 = (int) num3 * -309629781 ^ -1953526215;
                continue;
              case 3:
                num1 = (int) num3 * 699040496 ^ -885768675;
                continue;
              default:
                goto label_7;
            }
          }
        }
label_7:;
      }
    }

    static void \u202E​⁫⁮‌‪‬⁬⁬‫‎‌‬‏‭‍‫⁬‫‭‭⁪⁯‎‍‏⁬‌⁭‪‪⁫‌‪⁭‭​‫‌⁮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static void \u206D‮‪‮‭⁭⁯‬​‪‏‌‌‪⁯⁯⁫‏‭‎‏⁪⁪⁮‬‪‭​⁬‎‭‏‎‮​‏⁮‮‮⁫‮([In] object obj0, [In] ref bool obj1)
    {
      System.Threading.Monitor.Enter(obj0, ref obj1);
    }

    static void \u200F‭⁪​‬⁫‮‪‍⁫⁫‪‬⁯‍​‏⁭⁬‮‌⁪⁮​‫‎⁫⁬‭‪‍⁫‌‪‌‮‭‍⁭⁮‮([In] object obj0)
    {
      System.Threading.Monitor.Exit(obj0);
    }

    static void \u206A​‬⁪‪⁪⁭‌⁮⁬‫‌‬‪⁪⁮‌⁯‭⁪​‎‮⁯‪⁯‍‏‎⁮‫‪⁬​​‍⁪‎‌‎‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static string \u202C‪‭‬‌⁬⁬⁮‌‮⁬⁪⁯⁯‌‭⁫‎⁫‌⁬‬‬​‭​‬‏⁯‮‍‌⁬⁯‮⁪‭⁫⁭⁯‮([In] PropertyChangedEventArgs obj0)
    {
      return obj0.PropertyName;
    }

    static bool \u206F⁯⁬⁪‪‮‭⁭⁬‭‮‏⁪‪‪‫⁯⁯⁪⁮‬‫‭⁯⁯⁫​‪‍⁪​⁬‭⁫‪⁭⁮‌‪‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static string \u206F‭‌‌⁮⁭‌⁫⁭‌‮‎‭⁭‍‮⁯‬⁭⁯‭‪⁪⁮​​⁫⁭‪‭‍⁯‪‪⁬⁪‪⁫⁭‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    bool \u200F‌‮⁭‍‪‬​⁪‫‏⁬‪‍‏⁭‫‏‮‭⁫⁮⁬‪⁯‏⁯⁬‪‭‍‍‪​‮‬⁭⁯‍‭‮([In] object obj0)
    {
      return base.Equals(obj0);
    }

    static bool \u202D⁪‪⁪⁮‬⁭​‌‪⁫⁪⁬‌‫‍‬‏‍‌​‎⁪‪‌‌‫⁫‭⁭⁫‫⁪​‏‭‎⁯‪‍‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static int \u202D⁮⁮⁯‏⁪‏‌‏‎‮‏⁯‮‍⁫‭‌‍‍‏‫‭‬⁯‍⁫‭⁬⁮‭‬⁮⁯⁪⁬⁪‭⁯‬‮([In] object obj0)
    {
      return obj0.GetHashCode();
    }

    int \u200C⁮‬‪‌⁫⁫‎‍‭⁮‏⁬‌⁮‌‏⁮‏‎​⁬‍⁭⁬​⁯‎‭‏⁬⁪‎​‌‎‪⁯⁬⁫‮()
    {
      return base.GetHashCode();
    }

    static string \u206C‌⁪‌⁭⁮‪‪​⁯⁭⁪‪‍‭⁪‏⁫‏‌‌‌‌‌⁮⁪‬⁮⁫‌⁪‬‬‎‭‭⁭‏⁪‫‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u200E‎⁭⁫‏‪‫​‮‮⁯‌‍‏‌‌‏‏​⁯‏⁪‌⁮‫‬​‏‬‬‍‪‮‪⁫‌⁭‫‭⁯‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      return string.Format(obj0, obj1, obj2, obj3);
    }

    static bool \u206E⁮‪‭‪⁯‎⁬‎‎‌⁭‎⁭‭‭‫‬‏‮‍⁭⁮​‬⁯‮‫‌‌‌‎‬‮‫⁫⁮⁮​‭‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u200C‬⁯‏‭‌⁬‬⁬⁬‭‌‏‭⁪‫‭‮⁫⁭⁮‬‍‫‮⁪⁪‌⁯‬‏⁯⁪‭‌‎‭⁮‫‪‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static bool \u200D⁮‫‬⁭⁫⁮‌‌‫‍​‬⁮‬⁭⁪⁪⁪⁭⁪​⁭⁫‫⁫‬‌‏‬⁯‎‭⁬‎⁮​​⁯‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static string \u206A‪⁬‌⁫‫‮​‬‌‌‌‏‪⁮‫‫⁮‮⁮‮‭⁫‪⁪⁯⁬‏‌‌⁯‎‎⁬‍‍⁯‬‫‏‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static bool \u202C‎‬⁮‫‍⁮⁫⁯‭‮‭⁪⁮‪‎‭‎⁮⁭‎‮‍⁬⁫⁬⁬​‪⁪⁪⁮⁯⁯⁯‌‭⁯‏⁬‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static void \u206A⁮⁭‬⁫‬​⁯⁯​‫‮‭⁯⁫⁪⁮⁬⁪‌⁯⁫⁭‭⁭‭⁬‫‬‮‏‭⁯‎⁪‎‏‌‍⁪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }

    static void \u202E‫‍‬‫‭​‎‭‪⁬⁭‫‬‎‪⁮⁬‍‮⁮⁫‬‫‫‭‎​⁭‬‫‍‎⁬‮⁯⁫⁪‌‍‮([In] string obj0)
    {
      SendKeys.SendWait(obj0);
    }

    static object \u200C‬‍⁪‍⁭⁬‏⁮⁫⁪⁫⁫⁭⁬‌‏‫‫‮‎‏‍‫‫‪‏‬‍⁬‬‬‏‍‪⁫‎⁬‎‏‮()
    {
      return new object();
    }
  }
}
