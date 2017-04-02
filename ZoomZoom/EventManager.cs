// Decompiled with JetBrains decompiler
// Type: ZoomZoom.EventManager
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;
using System.Xml.Serialization;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Core;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Meetings;

namespace ZoomZoom
{
  public class EventManager : ManagerBase
  {
    private static readonly object eventLocker = EventManager.\u202B‎‬⁫⁮‬‬‪‎‌⁬‫‌‫‪‭‮‏⁪⁯⁭⁪‮‌‪⁯‫‬⁯⁬⁮⁯⁬‍⁭‫‮‬‭‏‮();
    private static EventManager instance = (EventManager) null;
    private string previousMeetingId = string.Empty;
    private Engine zoomZoom = Engine.Instance;
    private SharedData sharedData = (SharedData) null;
    private List<ZoomEvent> recentEvents = new List<ZoomEvent>();
    private ZoomMeeting activeMeeting = (ZoomMeeting) null;
    private ZoomWindow activeWindow = (ZoomWindow) null;
    private ZoomWindow buttonBar = (ZoomWindow) null;
    private bool buttonFindStarted = false;
    private bool removedFromMeeting = false;
    private bool holdDetected = false;
    private bool checkRequiredButtons = false;
    private bool forceOpenChatWindow = false;
    private bool userCountRetrieved = false;
    private bool hammerQueued = false;
    private int forceOpenChatWindowCount = 0;
    private bool screenShareHijackStarted = false;
    private bool screenShareHijackRequested = false;
    private bool screenShareHijackInProgress = false;
    private DateTime meetingLastLeft = DateTime.MinValue;
    private bool meetingInitialTasksCompleted = false;
    private bool greetingSentAfterJoined = false;
    private DateTime lastVideoSpotlight = DateTime.MinValue;
    private ZoomWindow lastWindowSpotlighted = (ZoomWindow) null;
    private DispatcherTimer meetingTimer = (DispatcherTimer) null;
    private DispatcherTimer eventTimer = (DispatcherTimer) null;
    private DateTime lastWarCheck = DateTime.MinValue;

    public static EventManager Instance
    {
      get
      {
label_1:
        int num1 = -1914586714;
        object eventLocker;
        while (true)
        {
          int num2 = -59425216;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventLocker = EventManager.eventLocker;
              num1 = (int) num3 * 1291168830 ^ -1039388195;
              continue;
            case 1:
              if (EventManager.instance == null)
              {
                num1 = (int) num3 * -1374137027 ^ -2100005114;
                continue;
              }
              goto label_25;
            case 3:
              num1 = (int) num3 * 691334156 ^ -1661052458;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        bool flag1 = false;
        try
        {
          EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag1);
label_9:
          int num2 = -1212807020;
          while (true)
          {
            int num3 = -59425216;
            uint num4;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                goto label_9;
              case 1:
                EventManager.instance = new EventManager();
                num2 = (int) num4 * -2010647866 ^ 896784569;
                continue;
              case 3:
                flag2 = EventManager.instance == null;
                num2 = (int) num4 * -1955636845 ^ -1587133674;
                continue;
              case 4:
                num2 = (int) num4 * -1479577504 ^ -1177816560;
                continue;
              case 5:
                int num5 = !flag2 ? 823602166 : (num5 = 1412518474);
                int num6 = (int) num4 * -252756771;
                num2 = num5 ^ num6;
                continue;
              case 6:
                num2 = (int) num4 * -216599575 ^ 867619953;
                continue;
              default:
                goto label_22;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_17:
            int num2 = -475631193;
            while (true)
            {
              int num3 = -59425216;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_17;
                case 1:
                  num2 = (int) num4 * -723055842 ^ -1352406772;
                  continue;
                case 3:
                  EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker);
                  num2 = (int) num4 * -1264091480 ^ -960862691;
                  continue;
                default:
                  goto label_21;
              }
            }
          }
label_21:;
        }
label_22:
label_23:
        int num7 = -1928620685;
label_24:
        int num8 = -59425216;
        uint num9;
        EventManager instance;
        switch ((num9 = (uint) (num7 ^ num8)) % 3U)
        {
          case 0:
            goto label_23;
          case 2:
            break;
          default:
            return instance;
        }
label_25:
        instance = EventManager.instance;
        num7 = -819387718;
        goto label_24;
      }
    }

    public ZoomMeeting ActiveMeeting
    {
      get
      {
label_1:
        int num1 = -354942265;
        ZoomMeeting activeMeeting;
        while (true)
        {
          int num2 = -743230363;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1600754434 ^ -1523877268;
              continue;
            case 2:
              activeMeeting = this.activeMeeting;
              num1 = (int) num3 * 1218073022 ^ 95656596;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activeMeeting;
      }
      set
      {
        bool flag = this.activeMeeting != null;
label_1:
        int num1 = -239916267;
        while (true)
        {
          int num2 = -1774519417;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.previousMeetingId = this.activeMeeting.MeetingId;
              num1 = (int) num3 * -1917104361 ^ -695152884;
              continue;
            case 3:
              num1 = (int) num3 * 981915170 ^ 362113479;
              continue;
            case 4:
              int num4 = !flag ? -17164284 : (num4 = -1095075489);
              int num5 = (int) num3 * 1736698964;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        this.activeMeeting = value;
      }
    }

    public ZoomWindow ActiveWindow
    {
      get
      {
        return this.activeWindow;
      }
      set
      {
label_1:
        int num1 = -2065880473;
        while (true)
        {
          int num2 = -1893681811;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.activeWindow = value;
              num1 = (int) num3 * -784595860 ^ -1855212926;
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

    public bool ButtonFindStarted
    {
      get
      {
label_1:
        int num1 = -1130788212;
        bool buttonFindStarted;
        while (true)
        {
          int num2 = -2003931190;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              buttonFindStarted = this.buttonFindStarted;
              num1 = (int) num3 * 1018232469 ^ -1704278393;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return buttonFindStarted;
      }
      set
      {
        object eventLocker = EventManager.eventLocker;
        bool flag = false;
        try
        {
          EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag);
label_2:
          int num1 = -2009883596;
          while (true)
          {
            int num2 = -1019864495;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_10;
              case 1:
                this.buttonFindStarted = value;
                num1 = (int) num3 * 1556816157 ^ -1075873041;
                continue;
              case 2:
                goto label_2;
              case 3:
                num1 = (int) num3 * -2033166435 ^ 1683768866;
                continue;
              default:
                goto label_6;
            }
          }
label_6:
          return;
label_10:;
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = -523270437;
            while (true)
            {
              int num2 = -1019864495;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_8;
                case 1:
                  num1 = (int) num3 * -1688171181 ^ -158795219;
                  continue;
                case 2:
                  EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker);
                  num1 = (int) num3 * 317972521 ^ -2077981366;
                  continue;
                default:
                  goto label_13;
              }
            }
          }
label_13:;
        }
      }
    }

    public bool RemovedFromMeeting
    {
      get
      {
label_1:
        int num1 = -688097536;
        bool removedFromMeeting;
        while (true)
        {
          int num2 = -1186551539;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              removedFromMeeting = this.removedFromMeeting;
              num1 = (int) num3 * 1931028141 ^ 2001584610;
              continue;
            case 2:
              num1 = (int) num3 * 2013252739 ^ -1037432800;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return removedFromMeeting;
      }
      set
      {
label_1:
        int num1 = -827000806;
        while (true)
        {
          int num2 = -602439078;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.removedFromMeeting = value;
              num1 = (int) num3 * -1874970546 ^ -989581829;
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

    public bool HoldDetected
    {
      get
      {
label_1:
        int num1 = -1975223603;
        bool holdDetected;
        while (true)
        {
          int num2 = -1273204544;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -589343931 ^ -2122733237;
              continue;
            case 1:
              holdDetected = this.holdDetected;
              num1 = (int) num3 * -1312769198 ^ 1043540898;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return holdDetected;
      }
      set
      {
        this.holdDetected = value;
      }
    }

    public bool CheckRequiredButtons
    {
      get
      {
        return this.checkRequiredButtons;
      }
      set
      {
label_1:
        int num1 = -823075948;
        while (true)
        {
          int num2 = -457299758;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.checkRequiredButtons = value;
              num1 = (int) num3 * -191367638 ^ -936987602;
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

    public bool ForceOpenChatWindow
    {
      get
      {
label_1:
        int num1 = -1142149533;
        bool forceOpenChatWindow;
        while (true)
        {
          int num2 = -1568380054;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              forceOpenChatWindow = this.forceOpenChatWindow;
              num1 = (int) num3 * -719933102 ^ 206091907;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1380045011 ^ -1810573045;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return forceOpenChatWindow;
      }
      set
      {
        this.forceOpenChatWindow = value;
      }
    }

    public bool ScreenShareHijackStarted
    {
      get
      {
label_1:
        int num1 = -2088506548;
        bool shareHijackStarted;
        while (true)
        {
          int num2 = -601564349;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -480450580 ^ 1160747273;
              continue;
            case 3:
              shareHijackStarted = this.screenShareHijackStarted;
              num1 = (int) num3 * -1665429890 ^ -95574980;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return shareHijackStarted;
      }
      set
      {
        this.screenShareHijackStarted = value;
      }
    }

    public bool ScreenShareHijackRequested
    {
      get
      {
        return this.screenShareHijackRequested;
      }
      set
      {
        this.screenShareHijackRequested = value;
      }
    }

    public bool ScreenShareHijackInProgress
    {
      get
      {
label_1:
        int num1 = 4551756;
        bool hijackInProgress;
        while (true)
        {
          int num2 = 839162889;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 16266722 ^ -94929438;
              continue;
            case 1:
              hijackInProgress = this.screenShareHijackInProgress;
              num1 = (int) num3 * 307896592 ^ 1648210141;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return hijackInProgress;
      }
      set
      {
        this.screenShareHijackInProgress = value;
      }
    }

    public bool HammerQueued
    {
      get
      {
label_1:
        int num1 = -312014821;
        bool hammerQueued;
        while (true)
        {
          int num2 = -93009048;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -279071299 ^ 1523727421;
              continue;
            case 2:
              goto label_1;
            case 3:
              hammerQueued = this.hammerQueued;
              num1 = (int) num3 * -358270468 ^ -1342074600;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return hammerQueued;
      }
      set
      {
        this.hammerQueued = value;
      }
    }

    public DateTime MeetingLastLeft
    {
      get
      {
label_1:
        int num1 = 1000539699;
        DateTime meetingLastLeft;
        while (true)
        {
          int num2 = 898677516;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -577387163 ^ 1246936789;
              continue;
            case 2:
              goto label_1;
            case 3:
              meetingLastLeft = this.meetingLastLeft;
              num1 = (int) num3 * -1034403603 ^ -671459909;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingLastLeft;
      }
      set
      {
label_1:
        int num1 = -1932368174;
        while (true)
        {
          int num2 = -848392562;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.meetingLastLeft = value;
              num1 = (int) num3 * 1195841876 ^ 1305311954;
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

    public int ForceOpenChatWindowCount
    {
      get
      {
label_1:
        int num1 = -52592073;
        int openChatWindowCount;
        while (true)
        {
          int num2 = -956712947;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              openChatWindowCount = this.forceOpenChatWindowCount;
              num1 = (int) num3 * -1613944881 ^ -664163296;
              continue;
            case 3:
              num1 = (int) num3 * -402678913 ^ -906559047;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return openChatWindowCount;
      }
      set
      {
        this.forceOpenChatWindowCount = value;
      }
    }

    public bool UserCountRetrieved
    {
      get
      {
label_1:
        int num1 = -2039177979;
        bool userCountRetrieved;
        while (true)
        {
          int num2 = -1183949370;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -534489288 ^ -1554311557;
              continue;
            case 2:
              goto label_1;
            case 3:
              userCountRetrieved = this.userCountRetrieved;
              num1 = (int) num3 * 1835860706 ^ -2099490536;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return userCountRetrieved;
      }
      set
      {
label_1:
        int num1 = 519754216;
        while (true)
        {
          int num2 = 758317800;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.userCountRetrieved = value;
              num1 = (int) num3 * 614919662 ^ -1986019044;
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

    public bool MeetingInitialTasksCompleted
    {
      get
      {
label_1:
        int num1 = 1405228173;
        bool initialTasksCompleted;
        while (true)
        {
          int num2 = 1380570504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              initialTasksCompleted = this.meetingInitialTasksCompleted;
              num1 = (int) num3 * 898656646 ^ -1774959324;
              continue;
            case 2:
              num1 = (int) num3 * 1449998812 ^ 394575943;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return initialTasksCompleted;
      }
      set
      {
        this.meetingInitialTasksCompleted = value;
      }
    }

    public bool GreetingSentAfterJoined
    {
      get
      {
        bool greetingSentAfterJoined = this.greetingSentAfterJoined;
label_1:
        int num1 = 685231140;
        while (true)
        {
          int num2 = 1213067632;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1421939449 ^ 1684446991;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return greetingSentAfterJoined;
      }
      set
      {
        this.greetingSentAfterJoined = value;
      }
    }

    public ZoomWindow LastWindowSpotlighted1
    {
      get
      {
label_1:
        int num1 = 43468903;
        ZoomWindow windowSpotlighted;
        while (true)
        {
          int num2 = 497365069;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -224622010 ^ -2012707941;
              continue;
            case 2:
              windowSpotlighted = this.lastWindowSpotlighted;
              num1 = (int) num3 * 1681476553 ^ 3986842;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return windowSpotlighted;
      }
      set
      {
label_1:
        int num1 = 1983690370;
        while (true)
        {
          int num2 = 1956810931;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.lastWindowSpotlighted = value;
              num1 = (int) num3 * -863019745 ^ 136600256;
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

    public DispatcherTimer MeetingTimer
    {
      get
      {
        DispatcherTimer meetingTimer = this.meetingTimer;
label_1:
        int num1 = 439259788;
        while (true)
        {
          int num2 = 300744496;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -2002572575 ^ -1598227881;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingTimer;
      }
      set
      {
        this.meetingTimer = value;
      }
    }

    public DispatcherTimer EventTimer
    {
      get
      {
label_1:
        int num1 = -107088017;
        DispatcherTimer eventTimer;
        while (true)
        {
          int num2 = -931979270;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1334893890 ^ -1685472723;
              continue;
            case 1:
              eventTimer = this.eventTimer;
              num1 = (int) num3 * -606283342 ^ 1298612224;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return eventTimer;
      }
      set
      {
label_1:
        int num1 = 544314428;
        while (true)
        {
          int num2 = 679656321;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.eventTimer = value;
              num1 = (int) num3 * -1933906940 ^ 301626181;
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

    internal event EventHandler OnMeetingJoined
    {
      add
      {
        EventHandler eventHandler1 = this.OnMeetingJoined;
label_1:
        int num1 = 1062268844;
        while (true)
        {
          int num2 = 2003646360;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler1;
              num1 = 1455512896;
              continue;
            case 2:
              eventHandler2 = (EventHandler) EventManager.\u202C‮‮‮‬‪‬⁭​‫‍‍⁫⁫⁮⁪‌‮⁪‮⁬⁯⁫‪‎⁮⁯‫‮‌‍‮‍⁭​⁮‏‍⁪⁫‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 197272315 ^ 1786249656;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingJoined, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? -443791108 : (num4 = -1868875557);
              int num5 = (int) num3 * 823343538;
              num1 = num4 ^ num5;
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
      remove
      {
        EventHandler eventHandler1 = this.OnMeetingJoined;
label_1:
        int num1 = -366599782;
        while (true)
        {
          int num2 = -1172125740;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              eventHandler2 = (EventHandler) EventManager.\u206C​⁮​​‮‭‬⁯⁫⁮‪‍‌‎‍​⁫⁪⁪‮⁬⁬⁫‫‌⁫‭‬‪⁬⁫⁬‬⁫​⁪​‫‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1188571955 ^ 179432016;
              continue;
            case 2:
              comparand = eventHandler1;
              num1 = -1508978157;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingJoined, eventHandler2, comparand);
              num1 = (int) num3 * -2076521655 ^ 1243961719;
              continue;
            case 4:
              int num4 = eventHandler1 != comparand ? -914671484 : (num4 = -94487566);
              int num5 = (int) num3 * 896142819;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    internal event EventHandler OnMeetingLeft
    {
      add
      {
        EventHandler eventHandler1 = this.OnMeetingLeft;
label_1:
        int num1 = 1266987598;
        while (true)
        {
          int num2 = 1454442579;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              eventHandler2 = (EventHandler) EventManager.\u202C‮‮‮‬‪‬⁭​‫‍‍⁫⁫⁮⁪‌‮⁪‮⁬⁯⁫‪‎⁮⁯‫‮‌‍‮‍⁭​⁮‏‍⁪⁫‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -904940873 ^ 69242681;
              continue;
            case 2:
              int num4 = eventHandler1 != comparand ? 1030552046 : (num4 = 1930987939);
              int num5 = (int) num3 * 1498626728;
              num1 = num4 ^ num5;
              continue;
            case 3:
              comparand = eventHandler1;
              num1 = 911667286;
              continue;
            case 4:
              goto label_3;
            case 5:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingLeft, eventHandler2, comparand);
              num1 = (int) num3 * -877054054 ^ 343849789;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnMeetingLeft;
label_1:
        int num1 = 1791452947;
        while (true)
        {
          int num2 = 1042652149;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              eventHandler2 = (EventHandler) EventManager.\u206C​⁮​​‮‭‬⁯⁫⁮‪‍‌‎‍​⁫⁪⁪‮⁬⁬⁫‫‌⁫‭‬‪⁬⁫⁬‬⁫​⁪​‫‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 753229732 ^ 578933987;
              continue;
            case 2:
              comparand = eventHandler1;
              num1 = 1629590033;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnMeetingLeft, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? -1731122928 : (num4 = -436076091);
              int num5 = (int) num3 * -677264647;
              num1 = num4 ^ num5;
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
    }

    private EventManager()
    {
label_1:
      int num1 = -1213122794;
      while (true)
      {
        int num2 = -18717832;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 138975011 ^ -1158534156;
            continue;
          case 2:
            num1 = (int) num3 * -1594975800 ^ -888701899;
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

    ~EventManager()
    {
      try
      {
      }
      finally
      {
        // ISSUE: explicit finalizer call
        base.Finalize();
label_3:
        int num1 = 1487486845;
        while (true)
        {
          int num2 = 934949315;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1980971397 ^ -10090626;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:;
      }
    }

    [STAThread]
    internal Task ManageEventsAsync(CancellationToken token)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EventManager.\u003CManageEventsAsync\u003Ed__88 manageEventsAsyncD88 = new EventManager.\u003CManageEventsAsync\u003Ed__88();
      // ISSUE: reference to a compiler-generated field
      manageEventsAsyncD88.\u003C\u003E4__this = this;
label_1:
      int num1 = 2015961087;
      while (true)
      {
        int num2 = 555862773;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            manageEventsAsyncD88.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            // ISSUE: reference to a compiler-generated field
            manageEventsAsyncD88.\u003C\u003E1__state = -1;
            num1 = (int) num3 * -1887775014 ^ -1025751153;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            manageEventsAsyncD88.token = token;
            num1 = (int) num3 * 1197520518 ^ -121518608;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      AsyncTaskMethodBuilder tBuilder = manageEventsAsyncD88.\u003C\u003Et__builder;
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncTaskMethodBuilder) @tBuilder).Start<EventManager.\u003CManageEventsAsync\u003Ed__88>((M0&) @manageEventsAsyncD88);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      return ((AsyncTaskMethodBuilder) @manageEventsAsyncD88.\u003C\u003Et__builder).get_Task();
    }

    [STAThread]
    private void ManageEvents(CancellationToken token)
    {
label_1:
      int num1 = -1305162024;
      while (true)
      {
        int num2 = -614369951;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            this.SharedData = this.Engine.SharedData;
            num1 = (int) num3 * -1940741269 ^ 1457545641;
            continue;
          case 2:
            this.Initialized = true;
            num1 = (int) num3 * 576942520 ^ -867707570;
            continue;
          case 3:
            goto label_39;
          case 4:
            this.Token = token;
            num1 = (int) num3 * -1628022431 ^ -1250541891;
            continue;
          case 5:
            this.StartTime = DateTime.Now;
            num1 = (int) num3 * 748039344 ^ -1649306534;
            continue;
          case 6:
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingRemovedFromHold>()).Subscribe(new Action<ZoomMeeting>(this.HandleRemovedFromHold), (ThreadOption) 0, true);
            num1 = (int) num3 * 518144578 ^ -339425859;
            continue;
          case 7:
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingPlacedOnHold>()).Subscribe(new Action<ZoomMeeting>(this.HandlePlacedOnHold), (ThreadOption) 0, true);
            num1 = (int) num3 * 85743287 ^ 1533274958;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      try
      {
label_11:
        int num2 = -1188901342;
        while (true)
        {
          int num3 = -614369951;
          uint num4;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 14U)
          {
            case 0:
              num2 = (int) num4 * 2000836317 ^ 1061802148;
              continue;
            case 1:
              num2 = (int) num4 * -850002869 ^ -1537065991;
              continue;
            case 2:
              goto label_11;
            case 3:
              num2 = -2078174611;
              continue;
            case 4:
              int num6 = this.StartTime.AddSeconds(10.0) < DateTime.Now ? -760220987 : (num6 = -1171181372);
              int num7 = (int) num4 * -878728586;
              num2 = num6 ^ num7;
              continue;
            case 5:
              num2 = (int) num4 * -180118920 ^ 2014463028;
              continue;
            case 6:
              num5 = this.Engine.WindowManager.Initialized ? 1 : 0;
              break;
            case 7:
              num2 = -1535931751;
              continue;
            case 8:
              this.ExecuteTasks();
              num2 = (int) num4 * 1054731728 ^ 875031557;
              continue;
            case 9:
              num2 = (int) num4 * -1604428036 ^ -1043757601;
              continue;
            case 11:
              if (!this.Engine.HookManager.Initialized)
              {
                num5 = 0;
                break;
              }
              num2 = (int) num4 * 419198574 ^ -1359245429;
              continue;
            case 12:
              this.Engine.RaiseEvent(EngineEvent.Error, new Exception(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(353853090U)), true);
              num2 = (int) num4 * 157212052 ^ -631940880;
              continue;
            case 13:
              CoreObject.log.Debug((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4244326435U));
              Thread.Sleep(100);
              num2 = -1974150662;
              continue;
            default:
              goto label_35;
          }
          int num8;
          num2 = num8 = num5 == 0 ? -1916279476 : (num8 = -856226124);
        }
      }
      catch (Exception ex)
      {
label_29:
        int num2 = -196559794;
        while (true)
        {
          int num3 = -614369951;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              CoreObject.log.Error((object) ex);
              num2 = (int) num4 * 791091288 ^ 488621844;
              continue;
            case 1:
              num2 = (int) num4 * 727760563 ^ -882249900;
              continue;
            case 3:
              num2 = (int) num4 * -1159844180 ^ 1048057695;
              continue;
            case 4:
              goto label_29;
            default:
              goto label_35;
          }
        }
      }
label_35:
label_36:
      int num9 = -1006208952;
label_37:
      bool flag;
      while (true)
      {
        int num2 = -614369951;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 4U)
        {
          case 0:
            goto label_38;
          case 1:
            goto label_39;
          case 2:
            if (!flag)
            {
              num9 = (int) num3 * 1930091924 ^ -467838219;
              continue;
            }
            goto label_9;
          case 3:
            goto label_36;
          default:
            goto label_34;
        }
      }
label_34:
      return;
label_38:
      return;
label_39:
      flag = this.ContinueManagingEvents();
      num9 = -1725205829;
      goto label_37;
    }

    internal void ExecuteTasks()
    {
      this.ProcessPendingWindows();
label_1:
      int num1 = -2118462670;
      while (true)
      {
        int num2 = -350474535;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            this.CheckMeetingInProgress();
            num1 = (int) num3 * -1038413258 ^ -1312609803;
            continue;
          case 2:
            this.CheckWarSettings();
            num1 = (int) num3 * -874030149 ^ 250389078;
            continue;
          case 3:
            num1 = (int) num3 * -624644489 ^ 1629208310;
            continue;
          case 4:
            this.CheckAutoAttendent();
            num1 = (int) num3 * 1643023512 ^ -626178332;
            continue;
          case 5:
            this.CloseExcessWindows();
            this.CheckMeetingAttendence();
            num1 = (int) num3 * 697972994 ^ -1023444469;
            continue;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num3 * 70861514 ^ 999772758;
            continue;
          case 8:
            this.CheckMeetingAttendenceDuration();
            num1 = (int) num3 * 609896608 ^ 154838706;
            continue;
          case 9:
            num1 = (int) num3 * 2001993466 ^ -470683583;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    private void CheckWarSettings()
    {
      if (!this.Engine.Settings.CheckForWar)
      {
label_1:
        uint num;
        switch ((num = (uint) (1090260156 ^ 667073928)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            return;
        }
      }
      WarSettings warSettings = (WarSettings) null;
      try
      {
        if (this.lastWarCheck.AddSeconds(30.0) < DateTime.Now)
        {
label_4:
          int num1 = 20750985;
          Stream responseStream;
          string objectData;
          while (true)
          {
            int num2 = 667073928;
            uint num3;
            WebResponse response;
            string requestUriString;
            WebRequest webRequest;
            switch ((num3 = (uint) (num1 ^ num2)) % 8U)
            {
              case 0:
                webRequest = WebRequest.Create(requestUriString);
                num1 = (int) num3 * -1620433104 ^ 948364483;
                continue;
              case 1:
                this.lastWarCheck = DateTime.Now;
                requestUriString = ZoomZoom.Properties.Settings.Default.URL_WarManifest + \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(576819258U) + Environment.MachineName;
                num1 = (int) num3 * 2129257116 ^ -197886797;
                continue;
              case 2:
                goto label_4;
              case 3:
                response = webRequest.GetResponse();
                num1 = (int) num3 * 979143261 ^ -2098385710;
                continue;
              case 5:
                responseStream = response.GetResponseStream();
                num1 = (int) num3 * -1554237102 ^ -589586716;
                continue;
              case 6:
                objectData = string.Empty;
                num1 = (int) num3 * 1921219419 ^ 633580198;
                continue;
              case 7:
                CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2488087537U), (object) requestUriString);
                num1 = (int) num3 * 2144888992 ^ -1815242432;
                continue;
              default:
                goto label_12;
            }
          }
label_12:
          StreamReader streamReader = new StreamReader(responseStream);
          try
          {
            objectData = streamReader.ReadToEnd();
          }
          finally
          {
            if (streamReader != null)
            {
label_15:
              int num2 = 2031375997;
              while (true)
              {
                int num3 = 667073928;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                {
                  case 0:
                    goto label_15;
                  case 1:
                    streamReader.Dispose();
                    num2 = (int) num4 * -1221904247 ^ -112566186;
                    continue;
                  case 3:
                    num2 = (int) num4 * -599479029 ^ -1324272981;
                    continue;
                  default:
                    goto label_19;
                }
              }
            }
label_19:;
          }
          bool flag1 = !objectData.Contains(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2116604288U));
label_21:
          int num5 = 162640636;
          while (true)
          {
            int num2 = 667073928;
            uint num3;
            bool flag2;
            object obj;
            bool flag3;
            ActivityBase activeActivity;
            bool flag4;
            switch ((num3 = (uint) (num5 ^ num2)) % 31U)
            {
              case 0:
                CoreObject.log.DebugFormat(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1855626391U), new object[0]);
                num5 = (int) num3 * -1821479876 ^ -1509782545;
                continue;
              case 1:
                int num4 = flag2 ? -224306250 : (num4 = -1905088343);
                int num6 = (int) num3 * -1862828235;
                num5 = num4 ^ num6;
                continue;
              case 2:
                this.Engine.Settings.MeetingRemovalAction = warSettings.MeetingRemovalAction;
                num5 = (int) num3 * -327399768 ^ 355732159;
                continue;
              case 3:
                num5 = 829520360;
                continue;
              case 4:
                int num7 = flag4 ? 756741417 : (num7 = 1717012126);
                int num8 = (int) num3 * 2051820629;
                num5 = num7 ^ num8;
                continue;
              case 5:
                CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1890862216U), (object) activeActivity);
                num5 = (int) num3 * -1744219785 ^ 987480988;
                continue;
              case 6:
                num5 = (int) num3 * -700967822 ^ -832056604;
                continue;
              case 7:
                this.Engine.Settings.FloodHostAfterJoin = warSettings.FloodHostAfterJoin;
                num5 = (int) num3 * -523378414 ^ -806925610;
                continue;
              case 8:
                num5 = (int) num3 * 1849660356 ^ -1032461124;
                continue;
              case 9:
                this.Engine.Settings.AutoAttendent = warSettings.AutoAttendent;
                num5 = (int) num3 * 10019717 ^ -896141336;
                continue;
              case 10:
                goto label_21;
              case 11:
                obj = WarSettings.XmlDeserializeFromString(objectData);
                num5 = (int) num3 * -710271617 ^ -273591515;
                continue;
              case 12:
                XmlSerializer xmlSerializer = new XmlSerializer(typeof (WarSettings));
                num5 = (int) num3 * 1701889704 ^ 1454671294;
                continue;
              case 13:
                ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityCanceledEvent>()).Publish(new ActivityEventBaseArguments(activeActivity, ""));
                num5 = (int) num3 * -2054734443 ^ -32410431;
                continue;
              case 14:
                CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(232133890U), new object[0]);
                num5 = (int) num3 * 1486283614 ^ 924125471;
                continue;
              case 16:
                num5 = (int) num3 * -787060329 ^ -791911106;
                continue;
              case 17:
                activeActivity = this.Engine.ActiveActivity;
                num5 = (int) num3 * -1769227375 ^ 568860622;
                continue;
              case 18:
                this.Engine.Settings.WarEnabled = warSettings.WarEnabled;
                num5 = 1757350280;
                continue;
              case 19:
                if (flag3)
                {
                  num5 = (int) num3 * 2032624897 ^ -802465150;
                  continue;
                }
                goto label_72;
              case 20:
                num5 = (int) num3 * -1274519036 ^ -86157456;
                continue;
              case 21:
                this.Engine.Settings.FloodAfterJoin = warSettings.FloodAfterJoin;
                num5 = (int) num3 * 1476604840 ^ -411380096;
                continue;
              case 22:
                flag2 = activeActivity != null;
                num5 = (int) num3 * -1528268815 ^ 1766887126;
                continue;
              case 23:
                this.Engine.Settings.MeetingHoldAction = warSettings.MeetingHoldAction;
                num5 = (int) num3 * 1744843594 ^ -1578554705;
                continue;
              case 24:
                if (flag1)
                {
                  num5 = (int) num3 * -1215762286 ^ 1271827367;
                  continue;
                }
                goto label_75;
              case 25:
                num5 = (int) num3 * -577733621 ^ -167560708;
                continue;
              case 26:
                num5 = (int) num3 * 1078990126 ^ 820391071;
                continue;
              case 27:
                this.Engine.Settings.ForceMeeting = warSettings.ForceMeeting;
                num5 = (int) num3 * -723726688 ^ -667792920;
                continue;
              case 28:
                flag3 = obj != null;
                num5 = (int) num3 * -1851038056 ^ 458484410;
                continue;
              case 29:
                flag4 = this.Engine.Settings.WarEnabled != warSettings.WarEnabled;
                num5 = (int) num3 * 1919523503 ^ -1908602019;
                continue;
              case 30:
                this.Engine.Settings.FindButtonsAfterJoin = warSettings.FindButtonsAfterJoin;
                num5 = (int) num3 * 1250915597 ^ -903206510;
                continue;
              default:
                goto label_54;
            }
          }
label_54:
          List<ZoomButton>.Enumerator enumerator = warSettings.MeetingButtons.GetEnumerator();
          try
          {
label_61:
            int num2 = !enumerator.MoveNext() ? 377221903 : (num2 = 1291221199);
            while (true)
            {
              int num3 = 667073928;
              uint num4;
              ZoomButton current;
              switch ((num4 = (uint) (num2 ^ num3)) % 6U)
              {
                case 0:
                  num2 = 1291221199;
                  continue;
                case 1:
                  current = enumerator.Current;
                  num2 = 1078259100;
                  continue;
                case 2:
                  goto label_61;
                case 4:
                  this.Engine.AddButton(current);
                  num2 = (int) num4 * 338155348 ^ -399795083;
                  continue;
                case 5:
                  num2 = (int) num4 * -2063040618 ^ -1617632984;
                  continue;
                default:
                  goto label_68;
              }
            }
          }
          finally
          {
            enumerator.Dispose();
label_63:
            int num2 = 1007880186;
            while (true)
            {
              int num3 = 667073928;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_63;
                case 2:
                  num2 = (int) num4 * -1949204703 ^ -654320737;
                  continue;
                default:
                  goto label_67;
              }
            }
label_67:;
          }
label_68:
          CoreObject.log.DebugFormat(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2574979139U), new object[0]);
        }
        else
          goto label_74;
label_69:
        int num9 = 1622420324;
label_70:
        while (true)
        {
          int num1 = 667073928;
          uint num2;
          switch ((num2 = (uint) (num9 ^ num1)) % 7U)
          {
            case 0:
              goto label_69;
            case 1:
              goto label_74;
            case 2:
              num9 = (int) num2 * -838603932 ^ 652246621;
              continue;
            case 3:
              num9 = (int) num2 * 1379535754 ^ -205421886;
              continue;
            case 4:
              goto label_72;
            case 5:
              goto label_75;
            case 6:
              goto label_81;
            default:
              goto label_77;
          }
        }
label_77:
        return;
label_81:
        return;
label_72:
        num9 = 1457860695;
        goto label_70;
label_74:
        num9 = 991982880;
        goto label_70;
label_75:
        num9 = 75372886;
        goto label_70;
      }
      catch (Exception ex)
      {
label_79:
        int num1 = 1314451946;
        while (true)
        {
          int num2 = 667073928;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_71;
            case 1:
              num1 = (int) num3 * 670559757 ^ -1988188368;
              continue;
            case 2:
              num1 = (int) num3 * 1529157039 ^ 1708523698;
              continue;
            case 3:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * 824317932 ^ 2025429997;
              continue;
            case 4:
              goto label_79;
            default:
              goto label_65;
          }
        }
label_65:
        return;
label_71:;
      }
    }

    private void HandlePlacedOnHold(ZoomMeeting obj)
    {
      object managerLock = ManagerBase.managerLock;
      bool flag = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(managerLock, ref flag);
label_2:
        int num1 = 1896533631;
        while (true)
        {
          int num2 = 1402555826;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 1699062770 ^ 27399474;
              continue;
            case 2:
              this.HoldDetected = true;
              num1 = (int) num3 * 952918736 ^ 87916591;
              continue;
            case 3:
              num1 = (int) num3 * 1313762452 ^ 169421732;
              continue;
            case 5:
              num1 = (int) num3 * 421647356 ^ 1699180497;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_10:
          int num1 = 1723072848;
          while (true)
          {
            int num2 = 1402555826;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_10;
              case 1:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(managerLock);
                num1 = (int) num3 * -936995583 ^ -921658952;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      ((CompositePresentationEvent<StatusObject>) this._eventAggregator.GetEvent<StatusEvent>()).Publish(new StatusObject()
      {
        Status = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(110039826U),
        Sender = (object) this
      });
label_16:
      int num4 = 1086393077;
      while (true)
      {
        int num1 = 1402555826;
        uint num2;
        ZoomMeeting activeMeeting;
        MeetingEventAction meetingHoldAction;
        switch ((num2 = (uint) (num4 ^ num1)) % 47U)
        {
          case 0:
            num4 = (int) num2 * 1476935037 ^ -1082991049;
            continue;
          case 1:
label_40:
            Engine engine1 = this.Engine;
            LeaveMeeting leaveMeeting1 = new LeaveMeeting();
            int num3 = 1;
            leaveMeeting1.AutoGenerated = num3 != 0;
            string callerName1 = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3014117660U);
            engine1.AddActivity((ActivityBase) leaveMeeting1, callerName1);
            num4 = 1411726040;
            continue;
          case 2:
            num4 = (int) num2 * -1422570911 ^ -1186636006;
            continue;
          case 3:
label_30:
            Engine engine2 = this.Engine;
            LeaveMeeting leaveMeeting2 = new LeaveMeeting();
            int num5 = 1;
            leaveMeeting2.AutoGenerated = num5 != 0;
            string callerName2 = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3014117660U);
            engine2.AddActivity((ActivityBase) leaveMeeting2, callerName2);
            num4 = 1181926431;
            continue;
          case 4:
            num4 = (int) num2 * 727730014 ^ -1907477266;
            continue;
          case 5:
label_59:
            Engine engine3 = this.Engine;
            LeaveMeeting leaveMeeting3 = new LeaveMeeting();
            int num6 = 1;
            leaveMeeting3.AutoGenerated = num6 != 0;
            string callerName3 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1372146684U);
            engine3.AddActivity((ActivityBase) leaveMeeting3, callerName3);
            num4 = 601266939;
            continue;
          case 6:
            num4 = (int) num2 * -655518013 ^ 723439015;
            continue;
          case 7:
            num4 = (int) num2 * 118093441 ^ -440685824;
            continue;
          case 8:
label_43:
            Engine engine4 = this.Engine;
            LeaveMeeting leaveMeeting4 = new LeaveMeeting();
            int num7 = 1;
            leaveMeeting4.AutoGenerated = num7 != 0;
            string callerName4 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4230808224U);
            engine4.AddActivity((ActivityBase) leaveMeeting4, callerName4);
            num4 = 200281600;
            continue;
          case 9:
            num4 = (int) num2 * -59298684 ^ -1883730057;
            continue;
          case 10:
            num4 = (int) num2 * 178716464 ^ 839256775;
            continue;
          case 11:
label_26:
            Engine engine5 = this.Engine;
            LeaveMeeting leaveMeeting5 = new LeaveMeeting();
            int num8 = 1;
            leaveMeeting5.AutoGenerated = num8 != 0;
            string callerName5 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1372146684U);
            engine5.AddActivity((ActivityBase) leaveMeeting5, callerName5);
            num4 = 442623784;
            continue;
          case 12:
            goto label_62;
          case 13:
            Engine engine6 = this.Engine;
            SendChat sendChat1 = new SendChat();
            int num9 = 1;
            sendChat1.AutoGenerated = num9 != 0;
            int num10 = 1;
            sendChat1.RequiresAuthorization = num10 != 0;
            int num11 = 0;
            sendChat1.AuthorizationState = (AuthorizationStates) num11;
            string callerName6 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4230808224U);
            engine6.AddActivity((ActivityBase) sendChat1, callerName6);
            num4 = (int) num2 * 456781039 ^ 581670361;
            continue;
          case 14:
label_29:
            Engine engine7 = this.Engine;
            LeaveMeeting leaveMeeting6 = new LeaveMeeting();
            int num12 = 1;
            leaveMeeting6.AutoGenerated = num12 != 0;
            string callerName7 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2587592700U);
            engine7.AddActivity((ActivityBase) leaveMeeting6, callerName7);
            num4 = 2062118923;
            continue;
          case 15:
            Engine engine8 = this.Engine;
            JoinMeeting joinMeeting1 = new JoinMeeting(this.Engine.NextMeeting.MeetingId);
            int num13 = 1;
            joinMeeting1.AutoGenerated = num13 != 0;
            string callerName8 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1372146684U);
            engine8.AddActivity((ActivityBase) joinMeeting1, callerName8);
            num4 = (int) num2 * 988534250 ^ 588722106;
            continue;
          case 16:
            num4 = (int) num2 * -1679515044 ^ -456777433;
            continue;
          case 17:
label_38:
            Engine engine9 = this.Engine;
            LeaveMeeting leaveMeeting7 = new LeaveMeeting();
            int num14 = 1;
            leaveMeeting7.AutoGenerated = num14 != 0;
            string callerName9 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4230808224U);
            engine9.AddActivity((ActivityBase) leaveMeeting7, callerName9);
            Engine engine10 = this.Engine;
            SendChat sendChat2 = new SendChat();
            int num15 = 1;
            sendChat2.AutoGenerated = num15 != 0;
            int num16 = 1;
            sendChat2.RequiresAuthorization = num16 != 0;
            int num17 = 0;
            sendChat2.AuthorizationState = (AuthorizationStates) num17;
            string callerName10 = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3014117660U);
            engine10.AddActivity((ActivityBase) sendChat2, callerName10);
            num4 = 336248978;
            continue;
          case 18:
            Engine engine11 = this.Engine;
            HammerMeeting hammerMeeting = new HammerMeeting(activeMeeting);
            int num18 = 1;
            hammerMeeting.AutoGenerated = num18 != 0;
            int num19 = 1;
            hammerMeeting.RequiresAuthorization = num19 != 0;
            int num20 = 0;
            hammerMeeting.AuthorizationState = (AuthorizationStates) num20;
            string callerName11 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2587592700U);
            engine11.AddActivity((ActivityBase) hammerMeeting, callerName11);
            num4 = (int) num2 * -786481304 ^ -1203689386;
            continue;
          case 19:
label_39:
            Engine engine12 = this.Engine;
            LeaveMeeting leaveMeeting8 = new LeaveMeeting();
            int num21 = 1;
            leaveMeeting8.AutoGenerated = num21 != 0;
            string callerName12 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4230808224U);
            engine12.AddActivity((ActivityBase) leaveMeeting8, callerName12);
            num4 = 287890246;
            continue;
          case 20:
            activeMeeting = this.Engine.ActiveMeeting;
            meetingHoldAction = this.Engine.Settings.MeetingHoldAction;
            num4 = (int) num2 * 2001943716 ^ 1373213058;
            continue;
          case 21:
            Engine engine13 = this.Engine;
            JoinMeeting joinMeeting2 = new JoinMeeting(activeMeeting.MeetingId);
            int num22 = 1;
            joinMeeting2.AutoGenerated = num22 != 0;
            int num23 = 1;
            joinMeeting2.RequiresAuthorization = num23 != 0;
            int num24 = 0;
            joinMeeting2.AuthorizationState = (AuthorizationStates) num24;
            string callerName13 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4230808224U);
            engine13.AddActivity((ActivityBase) joinMeeting2, callerName13);
            num4 = (int) num2 * -653654740 ^ -1144469380;
            continue;
          case 22:
            num4 = (int) num2 * -1516754876 ^ -738639081;
            continue;
          case 23:
            Engine engine14 = this.Engine;
            FloodChat floodChat1 = new FloodChat();
            int num25 = 1;
            floodChat1.AutoGenerated = num25 != 0;
            int num26 = 1;
            floodChat1.RequiresAuthorization = num26 != 0;
            int num27 = 0;
            floodChat1.AuthorizationState = (AuthorizationStates) num27;
            int num28 = 1;
            floodChat1.FloodHost = num28 != 0;
            string callerName14 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2587592700U);
            engine14.AddActivity((ActivityBase) floodChat1, callerName14);
            num4 = (int) num2 * 1849431163 ^ -2042437902;
            continue;
          case 24:
            num4 = (int) num2 * -412137960 ^ -20591361;
            continue;
          case 25:
            num4 = (int) num2 * 1272746549 ^ 1830967065;
            continue;
          case 26:
            num4 = (int) num2 * 1330397894 ^ -2124362053;
            continue;
          case 27:
            goto label_22;
          case 28:
label_58:
            Engine engine15 = this.Engine;
            LeaveMeeting leaveMeeting9 = new LeaveMeeting();
            int num29 = 1;
            leaveMeeting9.AutoGenerated = num29 != 0;
            string callerName15 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4230808224U);
            engine15.AddActivity((ActivityBase) leaveMeeting9, callerName15);
            Engine engine16 = this.Engine;
            SendChat sendChat3 = new SendChat();
            int num30 = 1;
            sendChat3.AutoGenerated = num30 != 0;
            int num31 = 1;
            sendChat3.RequiresAuthorization = num31 != 0;
            int num32 = 0;
            sendChat3.AuthorizationState = (AuthorizationStates) num32;
            string callerName16 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2587592700U);
            engine16.AddActivity((ActivityBase) sendChat3, callerName16);
            num4 = 1842365530;
            continue;
          case 29:
            goto label_16;
          case 30:
            Engine engine17 = this.Engine;
            FloodChat floodChat2 = new FloodChat();
            int num33 = 1;
            floodChat2.AutoGenerated = num33 != 0;
            int num34 = 1;
            floodChat2.RequiresAuthorization = num34 != 0;
            int num35 = 0;
            floodChat2.AuthorizationState = (AuthorizationStates) num35;
            int num36 = 1;
            floodChat2.FloodCoHost = num36 != 0;
            string callerName17 = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3654417553U);
            engine17.AddActivity((ActivityBase) floodChat2, callerName17);
            num4 = (int) num2 * -1806753567 ^ 195746514;
            continue;
          case 31:
            num4 = (int) num2 * -820057397 ^ 999799220;
            continue;
          case 32:
            num4 = (int) num2 * 1982319137 ^ -935677491;
            continue;
          case 33:
            num4 = (int) num2 * 1199197866 ^ 1671198861;
            continue;
          case 34:
            num4 = (int) num2 * -2125975078 ^ -1746804867;
            continue;
          case 35:
            EventManager.\u200D⁯‪​‬‮‏⁬‬‮‪‮⁬⁭⁮‭‭‍‪‌‎‏⁬‍⁭⁪⁮⁬‭‫‫‎⁯‫‍⁫⁯⁪‮‫‮(CoreObject.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(848539143U));
            num4 = (int) num2 * -2087087763 ^ 263514150;
            continue;
          case 36:
            num4 = (int) num2 * -1524305447 ^ 969758224;
            continue;
          case 37:
            num4 = (int) num2 * 1362026956 ^ -1072590423;
            continue;
          case 38:
            num4 = (int) num2 * -795058382 ^ 199158511;
            continue;
          case 39:
            num4 = (int) num2 * -2022887186 ^ 1836471559;
            continue;
          case 40:
label_31:
            Engine engine18 = this.Engine;
            LeaveMeeting leaveMeeting10 = new LeaveMeeting();
            int num37 = 1;
            leaveMeeting10.AutoGenerated = num37 != 0;
            string callerName18 = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3654417553U);
            engine18.AddActivity((ActivityBase) leaveMeeting10, callerName18);
            num4 = 1050050304;
            continue;
          case 41:
            num4 = (int) num2 * -1711775152 ^ 1991107047;
            continue;
          case 42:
            num4 = (int) num2 * -1001212073 ^ -1249810271;
            continue;
          case 43:
            goto label_18;
          case 44:
            num4 = (int) num2 * 2138821752 ^ 1279842843;
            continue;
          case 45:
            Engine engine19 = this.Engine;
            FloodChat floodChat3 = new FloodChat();
            int num38 = 1;
            floodChat3.AutoGenerated = num38 != 0;
            int num39 = 1;
            floodChat3.RequiresAuthorization = num39 != 0;
            int num40 = 0;
            floodChat3.AuthorizationState = (AuthorizationStates) num40;
            string callerName19 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1372146684U);
            engine19.AddActivity((ActivityBase) floodChat3, callerName19);
            num4 = (int) num2 * -1432855654 ^ -2113716137;
            continue;
          case 46:
            switch (meetingHoldAction)
            {
              case MeetingEventAction.Nothing:
                goto label_8;
              case MeetingEventAction.Leave:
                goto label_40;
              case MeetingEventAction.MoveNext:
                goto label_26;
              case MeetingEventAction.Rejoin:
                goto label_31;
              case MeetingEventAction.Hammer:
                goto label_43;
              case MeetingEventAction.SendChatToMeeting:
                goto label_29;
              case MeetingEventAction.SendChatToHost:
                goto label_38;
              case MeetingEventAction.SendChatToCohost:
                goto label_58;
              case MeetingEventAction.FloodMeeting:
                goto label_39;
              case MeetingEventAction.FloodHost:
                goto label_30;
              case MeetingEventAction.FloodCohost:
                goto label_59;
              default:
                num4 = (int) num2 * -700030242 ^ 1098172189;
                continue;
            }
          default:
            goto label_12;
        }
      }
label_18:
      return;
label_12:
      return;
label_62:
      return;
label_22:
      return;
label_8:;
    }

    private void HandleRemovedFromHold(ZoomMeeting obj)
    {
      object managerLock = ManagerBase.managerLock;
      bool flag1 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(managerLock, ref flag1);
label_2:
        int num1 = 1056410237;
        while (true)
        {
          int num2 = 444809733;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 566236084 ^ 2288483;
              continue;
            case 1:
              this.HoldDetected = false;
              num1 = (int) num3 * -1524100259 ^ 1105213401;
              continue;
            case 2:
              num1 = (int) num3 * 129668266 ^ -768165720;
              continue;
            case 3:
              goto label_2;
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
          int num1 = 948017854;
          while (true)
          {
            int num2 = 444809733;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_8;
              case 1:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(managerLock);
                num1 = (int) num3 * 1403407099 ^ 244127703;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      ((CompositePresentationEvent<StatusObject>) this._eventAggregator.GetEvent<StatusEvent>()).Publish(new StatusObject()
      {
        Status = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3555138738U),
        Sender = (object) this
      });
label_14:
      int num4 = 1041900272;
      while (true)
      {
        int num1 = 444809733;
        uint num2;
        ActivityBase activeActivity;
        bool flag2;
        bool flag3;
        int num3;
        switch ((num2 = (uint) (num4 ^ num1)) % 16U)
        {
          case 0:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) this._eventAggregator.GetEvent<ActivityCanceledEvent>()).Publish(new ActivityEventBaseArguments(activeActivity, ""));
            num4 = (int) num2 * -1762045598 ^ 107638860;
            continue;
          case 1:
            flag2 = this.Engine.Settings.OnHoldAction > OnHoldAction.Nothing;
            num4 = (int) num2 * 32807027 ^ -1566279799;
            continue;
          case 2:
            int num5 = flag3 ? -2002211191 : (num5 = -927668882);
            int num6 = (int) num2 * 191732958;
            num4 = num5 ^ num6;
            continue;
          case 3:
            num4 = (int) num2 * 165276928 ^ -1463293491;
            continue;
          case 4:
            num4 = (int) num2 * -412158699 ^ 1425095862;
            continue;
          case 5:
            num4 = (int) num2 * -1181488345 ^ 34791271;
            continue;
          case 6:
            goto label_14;
          case 7:
            num4 = 865273023;
            continue;
          case 8:
            activeActivity = this.Engine.ActiveActivity;
            num4 = (int) num2 * 1483799442 ^ 929472526;
            continue;
          case 9:
            num4 = (int) num2 * 1350855792 ^ -814798327;
            continue;
          case 10:
            goto label_16;
          case 11:
            if (activeActivity == null)
            {
              num3 = 0;
              break;
            }
            num4 = (int) num2 * -1487639779 ^ -1465690185;
            continue;
          case 12:
            Engine engine = this.Engine;
            SendChat sendChat = new SendChat(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(373873134U), "");
            int num7 = 1;
            sendChat.AutoGenerated = num7 != 0;
            string callerName = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2769554230U);
            engine.AddActivity((ActivityBase) sendChat, callerName);
            num4 = (int) num2 * -1527959421 ^ -307186513;
            continue;
          case 13:
            num3 = activeActivity is FloodChat ? 1 : 0;
            break;
          case 14:
            num4 = (int) num2 * -1792538755 ^ -1064214217;
            continue;
          case 15:
            int num8 = !flag2 ? 1244583954 : (num8 = 2098183259);
            int num9 = (int) num2 * -2043756285;
            num4 = num8 ^ num9;
            continue;
          default:
            goto label_10;
        }
        flag3 = num3 != 0;
        num4 = 1693365767;
      }
label_10:
      return;
label_16:;
    }

    private bool ContinueManagingEvents()
    {
label_1:
      int num1 = -229600984;
      bool flag1;
      while (true)
      {
        int num2 = -1562154414;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            int num5 = flag2 ? -768598771 : (num5 = -1556468816);
            int num6 = (int) num3 * -229292019;
            num1 = num5 ^ num6;
            continue;
          case 1:
            CancellationToken token = this.Token;
            // ISSUE: explicit reference operation
            num4 = ((CancellationToken) @token).get_IsCancellationRequested() ? 1 : 0;
            break;
          case 2:
            if (this.CancelRequested)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * -1640787423 ^ -1180142261;
            continue;
          case 3:
            num1 = (int) num3 * 310358971 ^ -988406729;
            continue;
          case 4:
            num1 = (int) num3 * 530666015 ^ -286939196;
            continue;
          case 5:
            num1 = (int) num3 * -56161327 ^ 1168526882;
            continue;
          case 6:
            flag1 = true;
            num1 = -1434009571;
            continue;
          case 7:
            flag1 = false;
            num1 = (int) num3 * 686185698 ^ -2069134174;
            continue;
          case 9:
            goto label_1;
          default:
            goto label_14;
        }
        flag2 = num4 != 0;
        num1 = -2019023200;
      }
label_14:
      return flag1;
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
      throw EventManager.\u200E‌‍‎‏⁪⁪​⁫⁯⁭⁫⁭⁫‏‎⁭⁪‎‎⁫⁪‌⁭⁬‏‬‎⁯​‏⁪‮⁬⁯​‌⁪⁫⁫‮();
    }

    private void CheckAutoAttendent()
    {
label_1:
      int num1 = -998054179;
      while (true)
      {
        int num2 = -1120654216;
        uint num3;
        bool flag;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            this.Engine.CancelActivity((ActivityBase) null);
            num1 = (int) num3 * -25141533 ^ 1911985699;
            continue;
          case 1:
            if (this.Engine.ActivityManager.ActiveActivity == null)
            {
              num4 = 0;
              goto label_12;
            }
            else
            {
              num1 = (int) num3 * 1559490984 ^ 1482346934;
              continue;
            }
          case 2:
            num4 = this.Engine.ActivityManager.ActiveActivity.StartTime < DateTime.Now.AddSeconds(-60.0) ? 1 : 0;
            goto label_12;
          case 3:
            CoreObject.log.Info((object) (\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3828559150U) + (object) this.Engine.ActiveActivity));
            num1 = (int) num3 * 1530552434 ^ -183260243;
            continue;
          case 4:
            num1 = (int) num3 * -903574251 ^ -1961383043;
            continue;
          case 5:
            num1 = (int) num3 * -477004999 ^ 735242550;
            continue;
          case 6:
            num5 = this.Engine.ActiveMeeting == null ? 1 : 0;
            break;
          case 7:
            num1 = -1683727551;
            continue;
          case 8:
            int num6 = !flag ? -494481426 : (num6 = -1472610999);
            int num7 = (int) num3 * 1605630154;
            num1 = num6 ^ num7;
            continue;
          case 9:
            goto label_1;
          case 10:
            num1 = (int) num3 * -1439693947 ^ 1291978914;
            continue;
          case 11:
            if (!this.Engine.Settings.AutoAttendent)
            {
              num5 = 0;
              break;
            }
            num1 = (int) num3 * 1677373439 ^ 863732977;
            continue;
          case 12:
            goto label_3;
          default:
            goto label_21;
        }
        int num8;
        num1 = num8 = num5 != 0 ? -1277569096 : (num8 = -1683727551);
        continue;
label_12:
        flag = num4 != 0;
        num1 = -889978174;
      }
label_21:
      return;
label_3:;
    }

    private void CloseExcessWindows()
    {
label_1:
      int num1 = -2051673026;
      List<ZoomWindow> list;
      while (true)
      {
        int num2 = -415671874;
        uint num3;
        ActivityBase activeActivity;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            if (this.Engine.ActiveMeeting != null)
            {
              num1 = (int) num3 * -819500735 ^ -661202901;
              continue;
            }
            break;
          case 1:
            if (activeActivity == null)
            {
              num1 = (int) num3 * 1007329091 ^ -1662207789;
              continue;
            }
            break;
          case 2:
            num1 = (int) num3 * -1081562702 ^ 1536559619;
            continue;
          case 3:
            goto label_1;
          case 4:
            activeActivity = this.Engine.ActiveActivity;
            num1 = (int) num3 * -2012786466 ^ -2005387393;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) (EventManager.\u003C\u003Ec.\u003C\u003E9__98_0 ?? (EventManager.\u003C\u003Ec.\u003C\u003E9__98_0 = new Func<ZoomWindow, bool>((object) EventManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCloseExcessWindows\u003Eb__98_0)))))).ToList<ZoomWindow>();
            num1 = -669914110;
            continue;
          case 6:
            num1 = (int) num3 * 933689963 ^ -259424811;
            continue;
          case 8:
            if (flag)
            {
              num1 = (int) num3 * 123728334 ^ -1013204476;
              continue;
            }
            goto label_39;
          case 9:
            num4 = this.Engine.ActivePattern != null ? 1 : 0;
            goto label_9;
          default:
            goto label_16;
        }
        num4 = 0;
label_9:
        flag = num4 != 0;
        num1 = -349568180;
      }
label_39:
      return;
label_16:
      List<ZoomWindow>.Enumerator enumerator = list.GetEnumerator();
      try
      {
label_28:
        int num2 = !enumerator.MoveNext() ? -1602017948 : (num2 = -1036078968);
        while (true)
        {
          int num3 = -415671874;
          uint num4;
          bool flag1;
          ZoomWindow current;
          bool flag2;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 15U)
          {
            case 0:
              num2 = (int) num4 * 846190302 ^ -302596357;
              continue;
            case 1:
              current = enumerator.Current;
              current.Refresh(false, false);
              if (current.IsVisible)
              {
                num2 = -1514856239;
                continue;
              }
              num5 = 0;
              break;
            case 2:
              int num6 = !flag2 ? -1726425102 : (num6 = -2146053396);
              int num7 = (int) num4 * 1530472136;
              num2 = num6 ^ num7;
              continue;
            case 3:
              num5 = current.DefaultVisibility == WindowVisibility.Close ? 1 : 0;
              break;
            case 4:
              int num8 = !flag1 ? -1022199531 : (num8 = -339943517);
              int num9 = (int) num4 * 1170649261;
              num2 = num8 ^ num9;
              continue;
            case 5:
              num2 = (int) num4 * 876529751 ^ 198846777;
              continue;
            case 6:
              EventManager.\u206B‪‌⁭‫‪⁬‏⁫‪‏⁪‎‌⁫‪⁬‏⁬‎​‪⁯‮⁪⁭‏​‍⁫‍⁮‎⁫⁯‮​‭​‮‮(2000);
              num2 = (int) num4 * -584566101 ^ -1645812218;
              continue;
            case 7:
              flag1 = current.ZoomWindowType == ZoomWindowType.RequestRecord;
              num2 = (int) num4 * 1464879162 ^ -1695803003;
              continue;
            case 8:
              num2 = -58539214;
              continue;
            case 9:
              current.Close(false, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4130193775U));
              num2 = (int) num4 * 105329424 ^ -1699818753;
              continue;
            case 10:
              goto label_28;
            case 11:
              num2 = (int) num4 * 936333256 ^ 303012768;
              continue;
            case 12:
              num2 = -1036078968;
              continue;
            case 13:
              num2 = -1625095034;
              continue;
            default:
              goto label_42;
          }
          flag2 = num5 != 0;
          num2 = -1014169114;
        }
      }
      finally
      {
        enumerator.Dispose();
label_37:
        int num2 = -565992561;
        while (true)
        {
          int num3 = -415671874;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -1823441659 ^ -2077046898;
              continue;
            case 2:
              goto label_37;
            default:
              goto label_41;
          }
        }
label_41:;
      }
label_42:;
    }

    private void ProcessPendingWindows()
    {
      using (List<ZoomEvent>.Enumerator enumerator = this.GetEventBatch(250).GetEnumerator())
      {
label_10:
        int num1 = !enumerator.MoveNext() ? 55302681 : (num1 = 1330963549);
        while (true)
        {
          int num2 = 2032621422;
          uint num3;
          ZoomEvent current;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              this.HandleFullMeeting(current);
              num1 = (int) num3 * -668902179 ^ -1289042891;
              continue;
            case 1:
              current = enumerator.Current;
              num1 = 957835856;
              continue;
            case 2:
              num1 = 1330963549;
              continue;
            case 3:
              this.DistributeEvent(current);
              num1 = (int) num3 * -1699233841 ^ -1703756381;
              continue;
            case 4:
              num1 = (int) num3 * -1363943570 ^ -1542911629;
              continue;
            case 5:
              this.HandleInvalidMeeting(current);
              num1 = (int) num3 * -1818217269 ^ 1993661233;
              continue;
            case 6:
              num1 = (int) num3 * 1654464071 ^ -464867059;
              continue;
            case 7:
              num1 = (int) num3 * 1766629706 ^ 247311915;
              continue;
            case 8:
              this.HandleAlertWindow(current);
              num1 = (int) num3 * -1279209908 ^ 1683860094;
              continue;
            case 9:
              goto label_10;
            case 10:
              this.HandleScreenShareHijack(current);
              num1 = (int) num3 * -1409674390 ^ 313232341;
              continue;
            case 11:
              num1 = (int) num3 * 577631170 ^ -158862338;
              continue;
            case 12:
              num1 = (int) num3 * 17898384 ^ 937626858;
              continue;
            case 13:
              goto label_17;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_17:;
      }
    }

    private void HandleAlertWindow(ZoomEvent zoomEvent)
    {
      if (this.Engine.ActiveActivity != null)
        goto label_9;
label_1:
      int num1 = -1676663186;
label_2:
      while (true)
      {
        int num2 = -1922827893;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_3;
          case 1:
            zoomEvent.Window.Close(false, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1735807347U));
            num1 = (int) num3 * -446799818 ^ 617199047;
            continue;
          case 2:
            num1 = (int) num3 * 1419296659 ^ -352668947;
            continue;
          case 3:
            num1 = (int) num3 * -3256453 ^ -1389496069;
            continue;
          case 4:
            goto label_8;
          case 5:
            if (zoomEvent.Window != null)
            {
              num1 = (int) num3 * 118567028 ^ 1172346425;
              continue;
            }
            goto label_9;
          case 6:
            if (zoomEvent.Window.WindowType == WindowType.Alert)
            {
              num1 = (int) num3 * -1206526611 ^ 1206904025;
              continue;
            }
            goto label_9;
          case 7:
            goto label_1;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:
      return;
label_8:
      int num4 = zoomEvent.Window.IsVisible ? 1 : 0;
      goto label_10;
label_9:
      num4 = 0;
label_10:
      num1 = num4 != 0 ? -2045813872 : (num1 = -916108941);
      goto label_2;
    }

    private void HandleInvalidMeeting(ZoomEvent zoomEvent)
    {
      bool flag1 = zoomEvent.Window == null;
label_1:
      int num1 = 962564208;
      while (true)
      {
        int num2 = 192283871;
        uint num3;
        ActivityBase activeActivity;
        bool flag2;
        DateTime meetingLastLeft;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 23U)
        {
          case 0:
            goto label_14;
          case 1:
            num1 = (int) num3 * -2037216568 ^ -1330784483;
            continue;
          case 2:
            num1 = 1148239094;
            continue;
          case 3:
            this.Engine.CancelActivity(activeActivity);
            num1 = (int) num3 * -628450281 ^ -591202138;
            continue;
          case 4:
            if (!zoomEvent.Window.IsVisible)
            {
              num4 = 0;
              goto label_16;
            }
            else
            {
              num1 = 842524015;
              continue;
            }
          case 5:
            num1 = 126404453;
            continue;
          case 6:
            flag2 = meetingLastLeft.AddSeconds(2.0) > DateTime.Now;
            num1 = (int) num3 * 11595223 ^ 26451363;
            continue;
          case 7:
            num1 = (int) num3 * 876016587 ^ 1361079510;
            continue;
          case 8:
            if (zoomEvent.ZoomWindowType == ZoomWindowType.InvalidMeeting)
            {
              num4 = 1;
              goto label_16;
            }
            else
            {
              num1 = (int) num3 * 1981314399 ^ -1179871992;
              continue;
            }
          case 9:
            num1 = (int) num3 * 1615912891 ^ 1089488877;
            continue;
          case 10:
            if (activeActivity == null)
            {
              num5 = 0;
              break;
            }
            num1 = (int) num3 * 653502267 ^ -1134610685;
            continue;
          case 11:
            num1 = (int) num3 * 1333942462 ^ 1090922884;
            continue;
          case 12:
            meetingLastLeft = this.MeetingLastLeft;
            num1 = (int) num3 * -493418835 ^ 1077935117;
            continue;
          case 13:
            activeActivity = this.Engine.ActiveActivity;
            num1 = (int) num3 * 243757412 ^ -1032922119;
            continue;
          case 14:
            num4 = zoomEvent.ZoomWindowType == ZoomWindowType.Locked ? 1 : 0;
            goto label_16;
          case 15:
            int num6 = flag1 ? 14374083 : (num6 = 718070752);
            int num7 = (int) num3 * -224029003;
            num1 = num6 ^ num7;
            continue;
          case 16:
            num1 = 1382307005;
            continue;
          case 17:
            if (activeActivity is HammerMeeting)
            {
              num5 = 0;
              break;
            }
            num1 = (int) num3 * 1731311200 ^ 2058681000;
            continue;
          case 18:
            num5 = !(activeActivity is JoinMeeting) ? 1 : 0;
            break;
          case 19:
            num1 = (int) num3 * -556566273 ^ -1259061274;
            continue;
          case 20:
            zoomEvent.Window.Close(false, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(52364907U));
            num1 = (int) num3 * -1001570832 ^ 2107917924;
            continue;
          case 21:
            goto label_1;
          case 22:
            int num8 = flag2 ? 1475816693 : (num8 = 305779917);
            int num9 = (int) num3 * 597491895;
            num1 = num8 ^ num9;
            continue;
          default:
            goto label_5;
        }
        int num10;
        num1 = num10 = num5 == 0 ? 1698784467 : (num10 = 272016268);
        continue;
label_16:
        int num11;
        num1 = num11 = num4 != 0 ? 1931483534 : (num11 = 126404453);
      }
label_5:
      return;
label_14:;
    }

    private void HandleFullMeeting(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 838581626;
      while (true)
      {
        int num2 = 377081670;
        uint num3;
        List<string> previousZoomRooms;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * -1743129745 ^ -1594262417;
            continue;
          case 1:
            int num5 = flag ? -1755979380 : (num5 = -748358675);
            int num6 = (int) num3 * -1358515935;
            num1 = num5 ^ num6;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 896247807 ^ -738824210;
            continue;
          case 4:
            if (zoomEvent.ZoomWindowType != ZoomWindowType.Full)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1183094954 ^ -1010254192;
            continue;
          case 5:
            previousZoomRooms = this.Engine.ZoomDatabase.GetPreviousZoomRooms();
            num1 = (int) num3 * 1837736681 ^ 1169261532;
            continue;
          case 6:
            num4 = this.Engine.ActiveActivity == null ? 1 : 0;
            break;
          case 7:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4260021063U));
            num1 = (int) num3 * -1729840801 ^ 1056366179;
            continue;
          case 8:
            goto label_1;
          case 9:
            Engine engine = this.Engine;
            HammerMeeting hammerMeeting = new HammerMeeting(previousZoomRooms[0]);
            int num7 = 1;
            hammerMeeting.AutoGenerated = num7 != 0;
            string callerName = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1783666568U);
            engine.AddActivity((ActivityBase) hammerMeeting, callerName);
            num1 = (int) num3 * 2119284088 ^ 187370260;
            continue;
          case 10:
            num1 = (int) num3 * 223983825 ^ -498717697;
            continue;
          case 11:
            num1 = (int) num3 * 567413966 ^ -463282418;
            continue;
          default:
            goto label_17;
        }
        flag = num4 != 0;
        num1 = 894913103;
      }
label_17:
      return;
label_3:;
    }

    private void CheckMeetingInProgress()
    {
      if (this.ActiveMeeting == null)
        goto label_9;
label_1:
      int num1 = 1295662738;
label_2:
      bool flag1;
      while (true)
      {
        int num2 = 1006624919;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 24U)
        {
          case 0:
            num1 = (int) num3 * -457438706 ^ -1732068452;
            continue;
          case 1:
            if (this.Engine.ActivitiesPending.Count == 0)
            {
              num1 = (int) num3 * 1173324227 ^ -1734397645;
              continue;
            }
            goto label_20;
          case 2:
            num4 = !WindowHelper.IsValid(this.Engine.ActiveMeetingWindow.Handle) ? 1 : 0;
            break;
          case 3:
            num1 = (int) num3 * 1480594599 ^ -2008381593;
            continue;
          case 4:
            if (this.Engine.Settings.AutoAttendent)
            {
              num1 = (int) num3 * 72567153 ^ -1657395238;
              continue;
            }
            goto label_20;
          case 5:
            num1 = (int) num3 * -165519507 ^ 522600366;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = 1285180868;
            continue;
          case 8:
            if (this.Engine.ActiveMeetingWindow == null)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * 257488316 ^ -729488067;
            continue;
          case 9:
            goto label_3;
          case 10:
            int num5 = !flag1 ? -1337149376 : (num5 = -2021220680);
            int num6 = (int) num3 * 2130340306;
            num1 = num5 ^ num6;
            continue;
          case 11:
            num1 = 1021589862;
            continue;
          case 12:
            num1 = 1021589862;
            continue;
          case 13:
            int num7 = this.Engine.GetWindow(ZoomWindowType.Meeting) != null ? -622627707 : (num7 = -919844486);
            int num8 = (int) num3 * -940065527;
            num1 = num7 ^ num8;
            continue;
          case 14:
            goto label_9;
          case 15:
            num1 = (int) num3 * -1280190662 ^ -499208875;
            continue;
          case 16:
            num1 = (int) num3 * 982289632 ^ -1255692576;
            continue;
          case 17:
            this.HandleMeetingLeft(new ZoomEvent(this.ActiveWindow)
            {
              EventType = ZoomEventType.Destroy
            });
            num1 = (int) num3 * 150747821 ^ -163849763;
            continue;
          case 18:
            goto label_19;
          case 19:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1742104342U));
            num1 = (int) num3 * -253993457 ^ 1191092590;
            continue;
          case 20:
            Engine engine = this.Engine;
            JoinMeeting joinMeeting = new JoinMeeting(this.Engine.NextMeeting.MeetingId);
            int num9 = 0;
            joinMeeting.AutoGenerated = num9 != 0;
            int num10 = 0;
            joinMeeting.RequiresAuthorization = num10 != 0;
            int num11 = 1;
            joinMeeting.AuthorizationState = (AuthorizationStates) num11;
            string callerName = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1745317294U);
            engine.AddActivity((ActivityBase) joinMeeting, callerName);
            num1 = (int) num3 * -1753276026 ^ -1248578417;
            continue;
          case 21:
            num1 = (int) num3 * 1768034557 ^ 385908615;
            continue;
          case 22:
            int num12 = !flag2 ? 1206759369 : (num12 = 929998464);
            int num13 = (int) num3 * -1584546173;
            num1 = num12 ^ num13;
            continue;
          case 23:
            if (this.Engine.ActiveMeeting == null)
            {
              num1 = (int) num3 * 1468524312 ^ -568532643;
              continue;
            }
            goto label_20;
          default:
            goto label_35;
        }
        flag2 = num4 != 0;
        num1 = 74670921;
      }
label_35:
      return;
label_3:
      return;
label_19:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      int num14 = !Enumerable.Any<ActivityBase>((IEnumerable<M0>) this.Engine.ActivitiesPending, (Func<M0, bool>) (EventManager.\u003C\u003Ec.\u003C\u003E9__103_0 ?? (EventManager.\u003C\u003Ec.\u003C\u003E9__103_0 = new Func<ActivityBase, bool>((object) EventManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCheckMeetingInProgress\u003Eb__103_0))))) ? 1 : 0;
      goto label_21;
label_9:
      if (this.Engine.ActiveActivity == null)
      {
        num1 = 1986925411;
        goto label_2;
      }
label_20:
      num14 = 0;
label_21:
      flag1 = num14 != 0;
      num1 = 327963621;
      goto label_2;
    }

    private void CheckMeetingAttendence()
    {
label_1:
      int num1 = 1920001300;
      while (true)
      {
        int num2 = 1275051468;
        uint num3;
        bool flag1;
        bool flag2;
        ZoomWindow windowViaButton;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            num1 = (int) num3 * 677164400 ^ -1874377642;
            continue;
          case 1:
            int num6 = !flag1 ? -1856423673 : (num6 = -1413599609);
            int num7 = (int) num3 * 411958804;
            num1 = num6 ^ num7;
            continue;
          case 2:
            if (this.ActiveMeeting.UserCountCurrent == 0)
            {
              num1 = (int) num3 * 528870482 ^ 1922658951;
              continue;
            }
            break;
          case 3:
            num1 = (int) num3 * 206018434 ^ 2107472452;
            continue;
          case 4:
            num1 = (int) num3 * -1830109004 ^ -173326129;
            continue;
          case 5:
            num1 = 1729860637;
            continue;
          case 6:
            num5 = this.Engine.ActiveActivity == null ? 1 : 0;
            goto label_28;
          case 7:
            windowViaButton = this.Engine.GetWindowViaButton(ZoomWindowType.Participants);
            flag2 = windowViaButton == null;
            num1 = (int) num3 * -1949160181 ^ -1719551784;
            continue;
          case 8:
            this.CheckMinimumParticipants();
            num1 = (int) num3 * -573066667 ^ -1276261904;
            continue;
          case 9:
            int num8 = flag2 ? -141873953 : (num8 = -1031679435);
            int num9 = (int) num3 * 1382553736;
            num1 = num8 ^ num9;
            continue;
          case 10:
            if (this.ActiveMeeting != null)
            {
              num1 = 2114871930;
              continue;
            }
            num5 = 0;
            goto label_28;
          case 11:
            goto label_1;
          case 12:
            num1 = (int) num3 * -528801383 ^ 1484412742;
            continue;
          case 13:
            num4 = this.Engine.ActiveActivity == null ? 1 : 0;
            goto label_23;
          case 14:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(937188507U));
            num1 = (int) num3 * 764092835 ^ 1635667125;
            continue;
          case 15:
            if (this.ActiveMeeting != null)
            {
              num1 = (int) num3 * -798470105 ^ 630103554;
              continue;
            }
            break;
          case 16:
            num1 = (int) num3 * 300587634 ^ 220066569;
            continue;
          case 17:
            Engine engine = this.Engine;
            FindButtons findButtons = new FindButtons(ZoomWindowType.Participants);
            int num10 = 1;
            findButtons.AutoGenerated = num10 != 0;
            string callerName = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2935932421U);
            engine.AddActivity((ActivityBase) findButtons, callerName);
            num1 = (int) num3 * 1396996282 ^ 706692896;
            continue;
          case 18:
            goto label_3;
          case 19:
            num1 = (int) num3 * 819504860 ^ -1977104672;
            continue;
          case 20:
            this.Engine.ActiveMeeting.SetUserCount(windowViaButton);
            num1 = 1579424878;
            continue;
          default:
            goto label_30;
        }
        num4 = 0;
label_23:
        int num11;
        num1 = num11 = num4 == 0 ? 270394481 : (num11 = 1367349678);
        continue;
label_28:
        flag1 = num5 != 0;
        num1 = 1306635118;
      }
label_30:
      return;
label_3:;
    }

    private void CheckMeetingAttendenceDuration()
    {
      object eventLocker = EventManager.eventLocker;
      bool flag1 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag1);
label_2:
        int num1 = -989912804;
        while (true)
        {
          int num2 = -1252006066;
          uint num3;
          bool flag2;
          TimeSpan remainingTime;
          bool flag3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 22U)
          {
            case 0:
              int num5 = flag2 ? -1506111150 : (num5 = -515830379);
              int num6 = (int) num3 * 2105505898;
              num1 = num5 ^ num6;
              continue;
            case 1:
              goto label_34;
            case 2:
              num1 = (int) num3 * -1138497094 ^ -660952041;
              continue;
            case 3:
              num1 = -280110147;
              continue;
            case 4:
              num1 = (int) num3 * -1828870718 ^ -597986468;
              continue;
            case 5:
              goto label_2;
            case 6:
              if (this.Engine.ActiveActivity != null)
              {
                num1 = (int) num3 * 717968119 ^ -698038710;
                continue;
              }
              num4 = 1;
              goto label_16;
            case 7:
              this.Engine.LogException(string.Format(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1220490640U), (object) remainingTime.Seconds));
              num1 = (int) num3 * 261915544 ^ -230214922;
              continue;
            case 8:
              num1 = (int) num3 * -1684871202 ^ -1315657387;
              continue;
            case 9:
              if (this.ActiveMeeting != null)
              {
                num1 = (int) num3 * 1592544261 ^ -1681273762;
                continue;
              }
              break;
            case 10:
              Engine engine = this.Engine;
              LeaveMeeting leaveMeeting = new LeaveMeeting();
              int num7 = 1;
              leaveMeeting.AutoGenerated = num7 != 0;
              string callerName = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1711572671U);
              engine.AddActivity((ActivityBase) leaveMeeting, callerName);
              num1 = (int) num3 * -869058813 ^ -1621491711;
              continue;
            case 11:
              flag3 = remainingTime.Seconds > 0;
              num1 = (int) num3 * 1902116079 ^ -1229173544;
              continue;
            case 12:
              num1 = (int) num3 * 43164132 ^ 558297611;
              continue;
            case 13:
              int num8 = !flag3 ? 1862782215 : (num8 = 471176998);
              int num9 = (int) num3 * -1191148790;
              num1 = num8 ^ num9;
              continue;
            case 14:
              num4 = !(this.Engine.ActiveActivity is LeaveMeeting) ? 1 : 0;
              goto label_16;
            case 15:
              this.Engine.LogException(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3416642905U));
              num1 = (int) num3 * 1425539845 ^ -962054916;
              continue;
            case 16:
              num1 = (int) num3 * -1031205168 ^ 855527050;
              continue;
            case 17:
              num1 = -841938658;
              continue;
            case 18:
              num1 = (int) num3 * -2073447712 ^ -1896669373;
              continue;
            case 19:
              num1 = (int) num3 * 915047109 ^ -1071562091;
              continue;
            case 20:
              remainingTime = this.ActiveMeeting.RemainingTime;
              num1 = (int) num3 * -702914035 ^ -1689915561;
              continue;
            case 21:
              if (this.Engine.Settings.MaximumAttendenceDuration > 0.0)
              {
                num1 = (int) num3 * 1047972983 ^ 1425814855;
                continue;
              }
              break;
            default:
              goto label_30;
          }
          num4 = 0;
label_16:
          flag2 = num4 != 0;
          num1 = -2095202806;
        }
label_30:
        return;
label_34:;
      }
      finally
      {
        if (flag1)
        {
label_32:
          int num1 = -804998127;
          while (true)
          {
            int num2 = -1252006066;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                Monitor.Exit(eventLocker);
                num1 = (int) num3 * 2115975688 ^ 1394947111;
                continue;
              case 2:
                goto label_32;
              default:
                goto label_36;
            }
          }
        }
label_36:;
      }
    }

    internal override void Cancel()
    {
      object eventLocker = EventManager.eventLocker;
      bool flag = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag);
label_2:
        int num1 = 1471172397;
        while (true)
        {
          int num2 = 1687332686;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.CancelRequested = true;
              num1 = (int) num3 * 988055086 ^ 1077689410;
              continue;
            case 1:
              num1 = (int) num3 * -113171927 ^ 1039197431;
              continue;
            case 2:
              goto label_2;
            case 3:
              num1 = (int) num3 * -1887851196 ^ -749817339;
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
          int num1 = 544671865;
          while (true)
          {
            int num2 = 1687332686;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * 984974433 ^ -603324629;
                continue;
              case 2:
                goto label_9;
              case 3:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker);
                num1 = (int) num3 * -734725524 ^ -1502571170;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    private void DistributeEvent(ZoomEvent zoomEvent)
    {
      object managerLock = ManagerBase.managerLock;
      bool flag = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(managerLock, ref flag);
label_2:
        int num1 = -1264287481;
        while (true)
        {
          int num2 = -1412781278;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              num1 = -961719162;
              continue;
            case 1:
              num1 = (int) num3 * -2109450263 ^ -1815653147;
              continue;
            case 2:
              goto label_2;
            case 4:
              this.recentEvents.RemoveAt(0);
              num1 = (int) num3 * 634123102 ^ -296163539;
              continue;
            case 5:
              int num4;
              num1 = num4 = this.recentEvents.Count <= 10 ? -202757437 : (num4 = -99704006);
              continue;
            case 6:
              num1 = (int) num3 * 15166979 ^ -2129399287;
              continue;
            case 7:
              num1 = (int) num3 * -1641294735 ^ 489395924;
              continue;
            case 8:
              this.recentEvents.Add(zoomEvent);
              num1 = (int) num3 * -1106657740 ^ 1695707789;
              continue;
            case 9:
              num1 = (int) num3 * -1254757485 ^ -2099503874;
              continue;
            case 10:
              num1 = (int) num3 * -1027302540 ^ 1399266770;
              continue;
            case 11:
              num1 = (int) num3 * -1162504662 ^ 967068170;
              continue;
            default:
              goto label_23;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_17:
          int num1 = -2017877012;
          while (true)
          {
            int num2 = -1412781278;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * 964442000 ^ -202720590;
                continue;
              case 2:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(managerLock);
                num1 = (int) num3 * -306840581 ^ -1950219391;
                continue;
              case 3:
                goto label_17;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_23:
      ZoomEventType eventType = zoomEvent.EventType;
label_24:
      int num5 = -640072014;
      while (true)
      {
        int num1 = -1412781278;
        uint num2;
        switch ((num2 = (uint) (num5 ^ num1)) % 20U)
        {
          case 0:
            num5 = (int) num2 * -1525701928 ^ 319260877;
            continue;
          case 1:
            num5 = (int) num2 * 1678306903 ^ 1092860405;
            continue;
          case 2:
            num5 = (int) num2 * 2000554240 ^ -1449863347;
            continue;
          case 3:
label_29:
            this.HandleCreateEvent(zoomEvent);
            num5 = -1256658560;
            continue;
          case 4:
            switch (eventType)
            {
              case ZoomEventType.Other:
                goto label_15;
              case ZoomEventType.Create:
                goto label_29;
              case ZoomEventType.Destroy:
                goto label_44;
              case ZoomEventType.LocationChanged:
                goto label_40;
              case ZoomEventType.Show:
                goto label_42;
              case ZoomEventType.Reorder:
                goto label_4;
              case ZoomEventType.Focus:
                goto label_27;
              case ZoomEventType.MoveSize:
                goto label_46;
              case ZoomEventType.Hide:
                goto label_30;
              case ZoomEventType.StateChange:
                goto label_47;
              case ZoomEventType.NameChange:
                goto label_43;
              case ZoomEventType.ValueChange:
                goto label_48;
              case ZoomEventType.DescriptionChange:
                goto label_49;
              case ZoomEventType.ObjectEnd:
                goto label_50;
              case ZoomEventType.Invoked:
                goto label_51;
              case ZoomEventType.Undefined:
                goto label_52;
              default:
                num5 = (int) num2 * 1069182028 ^ -1295507560;
                continue;
            }
          case 5:
label_44:
            this.HandleDestroyEvent(zoomEvent);
            num5 = -1919460333;
            continue;
          case 6:
label_30:
            this.HandleHideEvent(zoomEvent);
            num5 = -624139955;
            continue;
          case 7:
            goto label_28;
          case 8:
label_43:
            this.HandleNameChangeEvent(zoomEvent);
            num5 = -2043458652;
            continue;
          case 9:
            num5 = (int) num2 * -287259068 ^ 1948208617;
            continue;
          case 10:
            num5 = (int) num2 * 1233945850 ^ -298247406;
            continue;
          case 11:
label_40:
            this.HandleLocationChangedEvent(zoomEvent);
            num5 = -726468843;
            continue;
          case 12:
            goto label_26;
          case 13:
            num5 = (int) num2 * 894040883 ^ 1405763002;
            continue;
          case 14:
label_27:
            this.HandleFocusEvent(zoomEvent);
            num5 = -669929293;
            continue;
          case 15:
            goto label_24;
          case 16:
label_42:
            this.HandleShowEvent(zoomEvent);
            num5 = -315351237;
            continue;
          case 17:
            num5 = (int) num2 * 924996550 ^ -1516735573;
            continue;
          case 18:
            num5 = (int) num2 * 1139070774 ^ 686768163;
            continue;
          case 19:
            num5 = (int) num2 * 681787647 ^ -2076509308;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return;
label_26:
      return;
label_28:
      return;
label_50:
      return;
label_49:
      return;
label_52:
      return;
label_51:
      return;
label_48:
      return;
label_4:
      return;
label_15:
      return;
label_47:
      return;
label_46:;
    }

    private void HandleFocusEvent(ZoomEvent zoomEvent)
    {
      bool flag1 = false;
      ZoomWindowType zoomWindowType = zoomEvent.ZoomWindowType;
label_1:
      int num1 = -963467193;
      object eventLocker;
      while (true)
      {
        int num2 = -436925896;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            int num4 = zoomWindowType == ZoomWindowType.GalleryScrollRight ? 1730604607 : (num4 = 2008810495);
            int num5 = (int) num3 * -450340582;
            num1 = num4 ^ num5;
            continue;
          case 1:
            int num6 = zoomWindowType <= ZoomWindowType.GalleryScrollLeft ? 84382975 : (num6 = 1132910821);
            int num7 = (int) num3 * -1881501903;
            num1 = num6 ^ num7;
            continue;
          case 2:
            num1 = (int) num3 * 1905117864 ^ 1249528457;
            continue;
          case 3:
            flag1 = true;
            num1 = -6912693;
            continue;
          case 4:
            int num8;
            num1 = num8 = zoomWindowType != ZoomWindowType.SpeakerViewScrollLeft ? -504433985 : (num8 = -799041041);
            continue;
          case 5:
          case 10:
            flag2 = flag1;
            num1 = -1509647894;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -196119099 ^ 972073670;
            continue;
          case 8:
            int num9;
            num1 = num9 = zoomWindowType != ZoomWindowType.GalleryScrollLeft ? -588387446 : (num9 = -799041041);
            continue;
          case 9:
            num1 = (int) num3 * 1857345264 ^ 1176152302;
            continue;
          case 11:
            num1 = (int) num3 * 1417266577 ^ -2113124263;
            continue;
          case 13:
            int num10;
            num1 = num10 = zoomWindowType != ZoomWindowType.SpeakerViewScrollRight ? -1110555206 : (num10 = -799041041);
            continue;
          case 14:
            if (flag2)
            {
              num1 = (int) num3 * -293586391 ^ 782798033;
              continue;
            }
            goto label_44;
          case 15:
            num1 = (int) num3 * -304737013 ^ -1593058322;
            continue;
          case 16:
            num1 = (int) num3 * 511423275 ^ -474229441;
            continue;
          case 17:
            this.Engine.LogException(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(281164695U));
            eventLocker = EventManager.eventLocker;
            num1 = (int) num3 * 1668223089 ^ 63040833;
            continue;
          default:
            goto label_19;
        }
      }
label_44:
      return;
label_19:
      bool flag3 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag3);
label_21:
        int num2 = -131904288;
        while (true)
        {
          int num3 = -436925896;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_21;
            case 1:
              num2 = (int) num4 * -662991231 ^ -495779049;
              continue;
            default:
              goto label_24;
          }
        }
label_24:
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: method pointer
        using (List<ZoomWindow>.Enumerator enumerator = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (EventManager.\u003C\u003Ec.\u003C\u003E9__108_0 ?? (EventManager.\u003C\u003Ec.\u003C\u003E9__108_0 = new Func<ZoomWindow, bool>((object) EventManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CHandleFocusEvent\u003Eb__108_0)))))).ToList<ZoomWindow>().GetEnumerator())
        {
label_31:
          int num3 = !enumerator.MoveNext() ? -2015671388 : (num3 = -1866217809);
          while (true)
          {
            int num4 = -436925896;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 6U)
            {
              case 0:
                num3 = (int) num5 * 1893752415 ^ 785970097;
                continue;
              case 1:
                enumerator.Current.Highlighted = false;
                num3 = -1645266552;
                continue;
              case 3:
                num3 = -1866217809;
                continue;
              case 4:
                num3 = (int) num5 * -1803651196 ^ -2075215242;
                continue;
              case 5:
                goto label_31;
              default:
                goto label_41;
            }
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_35:
          int num2 = -135344138;
          while (true)
          {
            int num3 = -436925896;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_35;
              case 2:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker);
                num2 = (int) num4 * -568877734 ^ 973482643;
                continue;
              case 3:
                num2 = (int) num4 * 458112940 ^ -1741893279;
                continue;
              default:
                goto label_40;
            }
          }
        }
label_40:;
      }
label_41:
      this.Engine.LogException(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2970457231U));
label_42:
      int num11 = -611134085;
      while (true)
      {
        int num2 = -436925896;
        uint num3;
        switch ((num3 = (uint) (num11 ^ num2)) % 3U)
        {
          case 0:
            goto label_42;
          case 1:
            goto label_37;
          case 2:
            num11 = (int) num3 * 118485433 ^ 1951694034;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return;
label_37:;
    }

    private void HandleHideEvent(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 700317959;
      while (true)
      {
        int num2 = 977004118;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num4 = zoomEvent.ZoomWindowType == ZoomWindowType.DualVideo ? 1 : 0;
            break;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1776959820 ^ -1189824518;
            continue;
          case 4:
            num1 = (int) num3 * 1711323518 ^ -1030226055;
            continue;
          case 5:
            if (zoomEvent.ZoomWindowType == ZoomWindowType.MeetingButtonBar)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * -794361914 ^ 1617866934;
            continue;
          default:
            goto label_11;
        }
        int num5;
        num1 = num5 = num4 != 0 ? 1719052207 : (num5 = 385183209);
      }
label_11:
      return;
label_3:;
    }

    private void HandleShowEvent(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 1663764748;
      while (true)
      {
        int num2 = 941528803;
        uint num3;
        int index;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        bool flag8;
        int num4;
        int num5;
        int num6;
        int num7;
        int num8;
        int num9;
        switch ((num3 = (uint) (num1 ^ num2)) % 41U)
        {
          case 0:
            num4 = !flag5 ? 1 : 0;
            goto label_34;
          case 1:
            flag3 = true;
            num1 = (int) num3 * 1717041462 ^ 1860983701;
            continue;
          case 2:
            if (this.recentEvents[index].ZoomWindowType == ZoomWindowType.Undefined)
            {
              num1 = (int) num3 * -424634087 ^ 782374432;
              continue;
            }
            goto label_33;
          case 3:
            if (this.recentEvents[index].EventType == ZoomEventType.Create)
            {
              num1 = (int) num3 * 1926071796 ^ -1052276462;
              continue;
            }
            goto label_42;
          case 4:
            flag5 = true;
            num1 = (int) num3 * 1263080507 ^ -695423710;
            continue;
          case 5:
            num6 = !flag6 ? 1 : 0;
            goto label_53;
          case 6:
            int num10;
            num1 = num10 = index < this.recentEvents.Count ? 1937853074 : (num10 = 1213373596);
            continue;
          case 7:
            flag2 = true;
            num1 = (int) num3 * -258817281 ^ 1688121978;
            continue;
          case 8:
            num1 = (int) num3 * -351812088 ^ 1549905853;
            continue;
          case 9:
            num1 = (int) num3 * 1104030567 ^ 2138216584;
            continue;
          case 11:
            num1 = (int) num3 * 970729569 ^ 2010633346;
            continue;
          case 12:
            num1 = (int) num3 * -136035115 ^ 434073317;
            continue;
          case 13:
            num1 = (int) num3 * 735677844 ^ 714893861;
            continue;
          case 14:
            if (this.recentEvents[index].ZoomWindowType != ZoomWindowType.Locked)
            {
              num7 = 0;
              break;
            }
            num1 = 1553855717;
            continue;
          case 15:
            int num11 = flag8 ? -1719508160 : (num11 = -297179621);
            int num12 = (int) num3 * 18369514;
            num1 = num11 ^ num12;
            continue;
          case 16:
            flag1 = zoomEvent.ZoomWindowType == ZoomWindowType.Locked;
            num1 = (int) num3 * 577699755 ^ -1572025926;
            continue;
          case 17:
            if (this.recentEvents[index].EventType == ZoomEventType.Destroy)
            {
              num1 = 1702077425;
              continue;
            }
            goto label_37;
          case 18:
            num1 = (int) num3 * 1161142244 ^ -1116915750;
            continue;
          case 19:
            flag2 = false;
            flag3 = false;
            flag4 = false;
            flag5 = false;
            flag6 = false;
            index = 0;
            num1 = (int) num3 * -638146619 ^ -801148941;
            continue;
          case 20:
            num1 = 927258685;
            continue;
          case 21:
            if (this.recentEvents[index].ZoomWindowType == ZoomWindowType.Undefined)
            {
              num1 = (int) num3 * -1567536360 ^ 452686863;
              continue;
            }
            goto label_37;
          case 22:
            ++index;
            num1 = (int) num3 * 1832094334 ^ -1187218957;
            continue;
          case 23:
            num1 = (int) num3 * -1368125051 ^ 2120457539;
            continue;
          case 24:
            num7 = this.recentEvents[index].EventType == ZoomEventType.NameChange ? 1 : 0;
            break;
          case 25:
            flag7 = flag2 & flag3 & flag4 & flag5 & flag6;
            num1 = (int) num3 * 1099282151 ^ 1213889067;
            continue;
          case 26:
            goto label_1;
          case 27:
            if (flag1)
            {
              num1 = (int) num3 * -1243580703 ^ 2040251097;
              continue;
            }
            goto label_93;
          case 28:
            flag4 = true;
            num1 = (int) num3 * 603533106 ^ 469013407;
            continue;
          case 29:
            num1 = (int) num3 * 549411292 ^ -1954863323;
            continue;
          case 30:
            num5 = !flag2 ? 1 : 0;
            goto label_43;
          case 31:
            num1 = (int) num3 * -1490293599 ^ 2005108508;
            continue;
          case 32:
            if (this.recentEvents[index].ZoomWindowType == ZoomWindowType.Undefined)
            {
              num1 = (int) num3 * 1417390988 ^ -27417436;
              continue;
            }
            goto label_52;
          case 33:
            if (this.recentEvents[index].ZoomWindowType == ZoomWindowType.Locked)
            {
              num1 = (int) num3 * -1168341709 ^ -1930946321;
              continue;
            }
            goto label_42;
          case 34:
            if (this.recentEvents[index].EventType == ZoomEventType.Destroy)
            {
              num1 = 1307645717;
              continue;
            }
            goto label_33;
          case 35:
            if (this.recentEvents[index].EventType == ZoomEventType.Destroy)
            {
              num1 = 2003007758;
              continue;
            }
            goto label_52;
          case 36:
            if (flag7)
            {
              num1 = (int) num3 * -1046241335 ^ -327230043;
              continue;
            }
            goto label_88;
          case 37:
            num8 = !flag3 ? 1 : 0;
            goto label_62;
          case 38:
            flag6 = true;
            num1 = (int) num3 * 1656960116 ^ 1898990209;
            continue;
          case 39:
            num9 = !flag4 ? 1 : 0;
            goto label_38;
          case 40:
            num1 = 160599602;
            continue;
          default:
            goto label_66;
        }
        int num13 = flag2 ? 1 : 0;
        if ((num7 & num13) != 0)
        {
          num1 = 142160981;
          continue;
        }
        num8 = 0;
        goto label_62;
label_33:
        num4 = 0;
label_34:
        int num14;
        num1 = num14 = num4 != 0 ? 674569766 : (num14 = 1271723956);
        continue;
label_37:
        num9 = 0;
label_38:
        int num15;
        num1 = num15 = num9 != 0 ? 947987347 : (num15 = 1556169869);
        continue;
label_42:
        num5 = 0;
label_43:
        flag8 = num5 != 0;
        num1 = 1556502604;
        continue;
label_52:
        num6 = 0;
label_53:
        int num16;
        num1 = num16 = num6 != 0 ? 1098469942 : (num16 = 837902301);
        continue;
label_62:
        int num17;
        num1 = num17 = num8 == 0 ? 512089335 : (num17 = 817045150);
      }
label_66:
      object managerLock = ManagerBase.managerLock;
      bool flag9 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(managerLock, ref flag9);
label_68:
        int num2 = 1873989004;
        while (true)
        {
          int num3 = 941528803;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * 152774667 ^ 1229911443;
              continue;
            case 1:
              this.RemovedFromMeeting = true;
              num2 = (int) num4 * 715162001 ^ -1495598205;
              continue;
            case 2:
              num2 = (int) num4 * 534063999 ^ 1018128860;
              continue;
            case 3:
              goto label_68;
            default:
              goto label_80;
          }
        }
      }
      finally
      {
        if (flag9)
        {
label_74:
          int num2 = 254636917;
          while (true)
          {
            int num3 = 941528803;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_74;
              case 1:
                num2 = (int) num4 * 554192722 ^ 1985036938;
                continue;
              case 2:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(managerLock);
                num2 = (int) num4 * 514849510 ^ -688194362;
                continue;
              default:
                goto label_79;
            }
          }
        }
label_79:;
      }
label_80:
      this.HandleRemovedFromMeeting(zoomEvent);
label_81:
      int num18 = 975312474;
label_82:
      bool flag10;
      while (true)
      {
        int num2 = 941528803;
        uint num3;
        bool flag1;
        switch ((num3 = (uint) (num18 ^ num2)) % 17U)
        {
          case 0:
            num18 = (int) num3 * -141057330 ^ -1030143184;
            continue;
          case 1:
            num18 = (int) num3 * 1672695807 ^ 1662788709;
            continue;
          case 2:
            int num4 = flag10 ? -210985263 : (num4 = -1462144463);
            int num5 = (int) num3 * -636545854;
            num18 = num4 ^ num5;
            continue;
          case 3:
            num18 = (int) num3 * -1477996239 ^ -1507015940;
            continue;
          case 4:
            goto label_93;
          case 5:
            int num6;
            num18 = num6 = zoomEvent.ZoomWindowType != ZoomWindowType.Meeting ? 222005427 : (num6 = 524191483);
            continue;
          case 6:
            flag1 = this.ActiveMeeting == null;
            num18 = (int) num3 * 535534063 ^ 1513243427;
            continue;
          case 7:
            num18 = 222005427;
            continue;
          case 8:
            goto label_81;
          case 9:
            num18 = (int) num3 * 1710546788 ^ 1002648660;
            continue;
          case 10:
            num18 = (int) num3 * -947443848 ^ -215566640;
            continue;
          case 11:
            int num7 = flag1 ? -410062192 : (num7 = -45737895);
            int num8 = (int) num3 * -1065323743;
            num18 = num7 ^ num8;
            continue;
          case 12:
            goto label_85;
          case 13:
            goto label_83;
          case 14:
            this.HandleMeetingJoined(zoomEvent);
            num18 = (int) num3 * -1278426756 ^ 541308423;
            continue;
          case 15:
            num18 = (int) num3 * -1971689696 ^ 1708272841;
            continue;
          case 16:
            goto label_88;
          default:
            goto label_76;
        }
      }
label_76:
      return;
label_83:
      return;
label_85:
      int num19 = zoomEvent.ZoomWindowType == ZoomWindowType.DualVideo ? 1 : 0;
label_87:
      flag10 = num19 != 0;
      num18 = 575029167;
      goto label_82;
label_88:
      num18 = 1992352113;
      goto label_82;
label_93:
      if (zoomEvent.ZoomWindowType == ZoomWindowType.MeetingButtonBar)
      {
        num19 = 1;
        goto label_87;
      }
      else
      {
        num18 = 501502966;
        goto label_82;
      }
    }

    private void HandleLocationChangedEvent(ZoomEvent zoomEvent)
    {
      bool flag1 = zoomEvent.ZoomWindowType == ZoomWindowType.Meeting;
label_1:
      int num1 = -1526831861;
      while (true)
      {
        int num2 = -1389076120;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            int num4 = flag2 ? 1418178014 : (num4 = 1379623129);
            int num5 = (int) num3 * -6396084;
            num1 = num4 ^ num5;
            continue;
          case 1:
            goto label_3;
          case 2:
            flag2 = this.ActiveMeeting == null;
            num1 = (int) num3 * 1196122485 ^ -937277042;
            continue;
          case 3:
            num1 = -218465318;
            continue;
          case 4:
            num1 = (int) num3 * 1528835501 ^ 6075725;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.HandleMeetingJoined(zoomEvent);
            num1 = (int) num3 * 787467576 ^ -232500061;
            continue;
          case 7:
            num1 = (int) num3 * -2105263153 ^ 156714476;
            continue;
          case 8:
            int num6 = !flag1 ? -1574605724 : (num6 = -1340043174);
            int num7 = (int) num3 * 1512798890;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void HandleCreateEvent(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 221746503;
      object eventLocker1;
      while (true)
      {
        int num2 = 558785638;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            int num4 = this.ActiveMeeting == null ? -1249447846 : (num4 = -1685754581);
            int num5 = (int) num3 * 1311164451;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag2 = zoomEvent.ZoomWindowType == ZoomWindowType.Meeting;
            num1 = (int) num3 * 383372109 ^ 1025216346;
            continue;
          case 2:
            num1 = (int) num3 * 1680315284 ^ 631122363;
            continue;
          case 3:
            num1 = (int) num3 * 866055629 ^ -316548675;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = 1227449517;
            continue;
          case 6:
            if (flag1)
            {
              num1 = (int) num3 * -1853577129 ^ 2139014567;
              continue;
            }
            goto label_43;
          case 7:
            eventLocker1 = EventManager.eventLocker;
            num1 = (int) num3 * 1963786610 ^ 154500926;
            continue;
          case 8:
            this.HandleMeetingJoined(zoomEvent);
            num1 = (int) num3 * -491039650 ^ -1202509320;
            continue;
          case 9:
            int num6 = !flag2 ? -1412497914 : (num6 = -1826936478);
            int num7 = (int) num3 * 1317012667;
            num1 = num6 ^ num7;
            continue;
          case 11:
            flag1 = zoomEvent.ZoomWindowType == ZoomWindowType.MeetingButtonBar;
            num1 = 1059708184;
            continue;
          default:
            goto label_14;
        }
      }
label_43:
      return;
label_14:
      bool flag3 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker1, ref flag3);
label_16:
        int num2 = 1494368311;
        while (true)
        {
          int num3 = 558785638;
          uint num4;
          bool flag1;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 1:
              num2 = (int) num4 * 198067723 ^ 252272095;
              continue;
            case 2:
              flag1 = !this.CheckRequiredButtons;
              num2 = (int) num4 * 2037704435 ^ -1284250859;
              continue;
            case 3:
              this.CheckRequiredButtons = true;
              num2 = (int) num4 * -516747936 ^ 655919096;
              continue;
            case 4:
              goto label_16;
            case 5:
              int num5 = !flag1 ? -898351560 : (num5 = -869297593);
              int num6 = (int) num4 * -1873395554;
              num2 = num5 ^ num6;
              continue;
            case 6:
              num2 = (int) num4 * -805253656 ^ 166824574;
              continue;
            case 7:
              num2 = (int) num4 * -109785709 ^ -300785368;
              continue;
            default:
              goto label_30;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_25:
          int num2 = 1696267264;
          while (true)
          {
            int num3 = 558785638;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                num2 = (int) num4 * -2093560772 ^ -381815586;
                continue;
              case 2:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker1);
                num2 = (int) num4 * -1326008000 ^ -1510185893;
                continue;
              case 3:
                goto label_25;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
label_30:
      object eventLocker2 = EventManager.eventLocker;
      bool flag4 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker2, ref flag4);
label_32:
        int num2 = 501047772;
        while (true)
        {
          int num3 = 558785638;
          uint num4;
          bool flag1;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              goto label_32;
            case 1:
              this.buttonBar = zoomEvent.Window;
              num2 = (int) num4 * -268036387 ^ 159712605;
              continue;
            case 2:
              num2 = (int) num4 * -1701464308 ^ 1970222569;
              continue;
            case 4:
              int num5 = flag1 ? -123705081 : (num5 = -96175171);
              int num6 = (int) num4 * -1629511776;
              num2 = num5 ^ num6;
              continue;
            case 5:
              flag1 = this.buttonBar == null;
              num2 = (int) num4 * -466497414 ^ 412851016;
              continue;
            case 6:
              num2 = (int) num4 * -1450139945 ^ 1847764535;
              continue;
            case 7:
              num2 = (int) num4 * -1363028542 ^ 1023879125;
              continue;
            default:
              goto label_47;
          }
        }
      }
      finally
      {
        if (flag4)
        {
label_41:
          int num2 = 1303041867;
          while (true)
          {
            int num3 = 558785638;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker2);
                num2 = (int) num4 * -1902823339 ^ 1256464417;
                continue;
              case 2:
                num2 = (int) num4 * -969433221 ^ -1889979348;
                continue;
              case 3:
                goto label_41;
              default:
                goto label_46;
            }
          }
        }
label_46:;
      }
label_47:;
    }

    private void HandleDestroyEvent(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 1462074489;
      while (true)
      {
        int num2 = 1202318617;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 2053557937 ^ -627553518;
            continue;
          case 1:
            goto label_3;
          case 2:
            int num5 = flag ? -1709599621 : (num5 = -2012445351);
            int num6 = (int) num3 * 2057520888;
            num1 = num5 ^ num6;
            continue;
          case 3:
            this.HandleMeetingLeft(zoomEvent);
            num1 = (int) num3 * -1704503577 ^ 1216670604;
            continue;
          case 4:
            goto label_1;
          case 5:
            num4 = this.ActiveMeeting != null ? 1 : 0;
            break;
          case 6:
            if (zoomEvent.ZoomWindowType != ZoomWindowType.Meeting)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 875635679 ^ -700359266;
            continue;
          default:
            goto label_12;
        }
        flag = num4 != 0;
        num1 = 1821400226;
      }
label_12:
      return;
label_3:;
    }

    private void HandleNameChangeEvent(ZoomEvent zoomEvent)
    {
      if (zoomEvent.ZoomWindowType != ZoomWindowType.Participants)
        goto label_7;
label_1:
      int num1 = -627468211;
label_2:
      object eventLocker;
      while (true)
      {
        int num2 = -1680597598;
        uint num3;
        int userCountCurrent;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            num1 = (int) num3 * -1501710377 ^ -1065519284;
            continue;
          case 1:
            goto label_6;
          case 2:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2451081731U));
            num1 = (int) num3 * -80583295 ^ 1125573088;
            continue;
          case 3:
            eventLocker = EventManager.eventLocker;
            num1 = -648847179;
            continue;
          case 4:
            int num4 = !flag ? 2016006997 : (num4 = 1005642252);
            int num5 = (int) num3 * 837648613;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_1;
          case 6:
            flag = userCountCurrent > this.Engine.ActiveMeeting.UserCountCurrent;
            num1 = -224619066;
            continue;
          case 8:
            int num6 = userCountCurrent < this.Engine.ActiveMeeting.UserCountCurrent ? 19377449 : (num6 = 1302755028);
            int num7 = (int) num3 * -1222172668;
            num1 = num6 ^ num7;
            continue;
          case 9:
            num1 = (int) num3 * 1869413149 ^ -1517667382;
            continue;
          case 10:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1850240281U));
            num1 = (int) num3 * -511616740 ^ -2107316122;
            continue;
          case 11:
            num1 = (int) num3 * -158215126 ^ 1008698878;
            continue;
          case 12:
            num1 = (int) num3 * -132669291 ^ 1785187949;
            continue;
          case 13:
            userCountCurrent = this.Engine.ActiveMeeting.UserCountCurrent;
            this.Engine.ActiveMeeting.SetUserCount(zoomEvent.Window);
            num1 = (int) num3 * -1703178881 ^ -1939620039;
            continue;
          case 14:
            num1 = (int) num3 * -733004406 ^ 829785101;
            continue;
          case 15:
            if (this.Engine.SharedData != null)
            {
              num1 = (int) num3 * 125187625 ^ -198892316;
              continue;
            }
            goto label_7;
          default:
            goto label_21;
        }
      }
label_6:
      int num8 = this.Engine.ActiveMeeting != null ? 1 : 0;
      goto label_8;
label_21:
      bool flag1 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag1);
label_23:
        int num2 = -863959077;
        while (true)
        {
          int num3 = -1680597598;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              num2 = (int) num4 * -553315251 ^ 1126622877;
              continue;
            case 2:
              this.UserCountRetrieved = true;
              num2 = (int) num4 * 275625521 ^ 366774176;
              continue;
            case 3:
              goto label_23;
            default:
              goto label_34;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_29:
          int num2 = -1483348787;
          while (true)
          {
            int num3 = -1680597598;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_29;
              case 2:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker);
                num2 = (int) num4 * -389047630 ^ 1134493411;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
label_34:
      this.CheckMinimumParticipants();
label_35:
      int num9 = -850031032;
      while (true)
      {
        int num2 = -1680597598;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 4U)
        {
          case 0:
            goto label_35;
          case 1:
            goto label_31;
          case 2:
            num9 = (int) num3 * 646414726 ^ -1552235591;
            continue;
          case 3:
            num9 = (int) num3 * -519485126 ^ -2022963847;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return;
label_31:
      return;
label_7:
      num8 = 0;
label_8:
      if (num8 == 0)
        return;
      num1 = -1197624293;
      goto label_2;
    }

    private void CheckMinimumParticipants()
    {
      if (!this.UserCountRetrieved)
        goto label_13;
label_1:
      int num1 = 812248309;
label_2:
      while (true)
      {
        int num2 = 1487671436;
        uint num3;
        int userCountCurrent;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 476263319 ^ 1689597445;
            continue;
          case 2:
            num1 = 1955404832;
            continue;
          case 3:
            if (this.Engine.Settings.MinimumUserEnforced)
            {
              num1 = (int) num3 * -861624508 ^ 585637275;
              continue;
            }
            goto label_13;
          case 4:
            num1 = (int) num3 * -761538647 ^ -526825850;
            continue;
          case 5:
            goto label_12;
          case 6:
            userCountCurrent = this.Engine.ActiveMeeting.UserCountCurrent;
            num1 = (int) num3 * -2015695103 ^ 2010282861;
            continue;
          case 7:
            goto label_3;
          case 8:
            num4 = userCountCurrent < this.Engine.Settings.MinimumUserCount ? 1 : 0;
            break;
          case 9:
            num1 = (int) num3 * 1175311016 ^ 657146623;
            continue;
          case 10:
            this.Engine.LogException(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(326323399U));
            Engine engine = this.Engine;
            LeaveMeeting leaveMeeting = new LeaveMeeting();
            int num5 = 1;
            leaveMeeting.AutoGenerated = num5 != 0;
            string callerName = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3509063290U);
            engine.AddActivity((ActivityBase) leaveMeeting, callerName);
            num1 = (int) num3 * -1291362119 ^ 1877099143;
            continue;
          case 11:
            if (userCountCurrent <= 0)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1446427011 ^ -1194384757;
            continue;
          case 12:
            num1 = (int) num3 * -731682587 ^ -1172217695;
            continue;
          default:
            goto label_21;
        }
        int num6;
        num1 = num6 = num4 == 0 ? 177393956 : (num6 = 2094033955);
      }
label_21:
      return;
label_3:
      return;
label_12:
      int num7 = this.Engine.ActiveActivity == null ? 1 : 0;
      goto label_14;
label_13:
      num7 = 0;
label_14:
      num1 = num7 == 0 ? 1955404832 : (num1 = 1768247946);
      goto label_2;
    }

    private void HandleScreenShareHijack(ZoomEvent zoomEvent)
    {
      if (zoomEvent.ZoomWindowType == ZoomWindowType.ScreenShareOptions)
        goto label_11;
label_1:
      int num1 = -1244564523;
label_2:
      bool flag1;
      bool flag2;
      bool flag3;
      object eventLocker1;
      bool flag4;
      bool flag5;
      while (true)
      {
        int num2 = -632521630;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            if (flag3)
            {
              num1 = (int) num3 * 1186182797 ^ 1446375654;
              continue;
            }
            goto label_174;
          case 1:
            goto label_10;
          case 3:
            flag4 = false;
            num1 = (int) num3 * -106164798 ^ -1450111689;
            continue;
          case 4:
            eventLocker1 = EventManager.eventLocker;
            num1 = (int) num3 * 776772749 ^ -1867086882;
            continue;
          case 5:
            flag2 = false;
            num1 = (int) num3 * 990681653 ^ -1856020173;
            continue;
          case 6:
            num1 = (int) num3 * 631966379 ^ -1980880969;
            continue;
          case 7:
            goto label_1;
          case 8:
            flag1 = false;
            num1 = (int) num3 * -697098875 ^ -1851379861;
            continue;
          case 9:
            flag5 = false;
            num1 = (int) num3 * -2026519999 ^ 1331855485;
            continue;
          default:
            goto label_14;
        }
      }
label_174:
      return;
label_10:
      int num4 = zoomEvent.ZoomWindowType == ZoomWindowType.RequestRemoteControl ? 1 : 0;
      goto label_12;
label_14:
      bool flag6 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker1, ref flag6);
label_16:
        int num2 = -1654295951;
        while (true)
        {
          int num3 = -632521630;
          uint num5;
          bool flag7;
          int num6;
          switch ((num5 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              num2 = -1235436518;
              continue;
            case 1:
              flag4 = this.ScreenShareHijackRequested;
              flag2 = this.ScreenShareHijackInProgress;
              num2 = (int) num5 * 914075193 ^ -704361658;
              continue;
            case 2:
              int num7 = flag7 ? 1323563298 : (num7 = 696840498);
              int num8 = (int) num5 * 1256563284;
              num2 = num7 ^ num8;
              continue;
            case 3:
              num2 = (int) num5 * 1663562985 ^ -285968257;
              continue;
            case 4:
              num6 = zoomEvent.ZoomWindowType == ZoomWindowType.RequestRemoteControl ? 1 : 0;
              break;
            case 5:
              if (zoomEvent.ZoomWindowType == ZoomWindowType.ScreenShareOptions)
              {
                num6 = 1;
                break;
              }
              num2 = (int) num5 * -1194290258 ^ -1139702178;
              continue;
            case 7:
              goto label_16;
            case 8:
              num2 = (int) num5 * -1278742215 ^ -757730765;
              continue;
            case 9:
              flag5 = true;
              flag1 = this.ScreenShareHijackStarted;
              num2 = (int) num5 * -174294553 ^ -1469141508;
              continue;
            default:
              goto label_35;
          }
          flag7 = num6 != 0;
          num2 = -2020654906;
        }
      }
      finally
      {
        if (flag6)
        {
label_30:
          int num2 = -2057271631;
          while (true)
          {
            int num3 = -632521630;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_30;
              case 2:
                num2 = (int) num5 * -1128387093 ^ -981073527;
                continue;
              case 3:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker1);
                num2 = (int) num5 * 1415533346 ^ 41175510;
                continue;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
label_35:
      uint num9;
      if (flag5)
      {
        try
        {
label_37:
          int num2 = -1026626953;
          object eventLocker2;
          while (true)
          {
            int num3 = -632521630;
            uint num5;
            bool flag7;
            int num6;
            switch ((num5 = (uint) (num2 ^ num3)) % 9U)
            {
              case 0:
                num2 = (int) num5 * -204501910 ^ 576413827;
                continue;
              case 1:
                if (zoomEvent.Window.IsVisible)
                {
                  num6 = 0;
                  break;
                }
                num2 = (int) num5 * -1887272234 ^ 648779731;
                continue;
              case 3:
                num6 = flag1 | flag4 | flag2 ? 1 : 0;
                break;
              case 4:
                eventLocker2 = EventManager.eventLocker;
                num2 = (int) num5 * -973192606 ^ 1056482427;
                continue;
              case 5:
                if (flag7)
                {
                  num2 = (int) num5 * -2130056556 ^ -1849604244;
                  continue;
                }
                goto label_140;
              case 6:
                goto label_37;
              case 7:
                flag7 = zoomEvent.ZoomWindowType == ZoomWindowType.ScreenShareOptions;
                num2 = (int) num5 * 1304765036 ^ -1521899312;
                continue;
              case 8:
                num2 = (int) num5 * 388165652 ^ -1505784544;
                continue;
              default:
                goto label_51;
            }
            if (num6 != 0)
              num2 = -1595179235;
            else
              goto label_81;
          }
label_51:
          bool flag8 = false;
          try
          {
            EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker2, ref flag8);
label_53:
            int num3 = -1455530742;
            while (true)
            {
              int num5 = -632521630;
              uint num6;
              switch ((num6 = (uint) (num3 ^ num5)) % 10U)
              {
                case 0:
                  num3 = (int) num6 * -1382180229 ^ 1058729469;
                  continue;
                case 1:
                  this.ScreenShareHijackInProgress = false;
                  num3 = (int) num6 * -1367645133 ^ 1141832457;
                  continue;
                case 2:
                  goto label_53;
                case 4:
                  num3 = (int) num6 * -2138159406 ^ 968476879;
                  continue;
                case 5:
                  this.ScreenShareHijackRequested = false;
                  num3 = (int) num6 * 243276437 ^ 633035115;
                  continue;
                case 6:
                  num3 = (int) num6 * 887002785 ^ 687876201;
                  continue;
                case 7:
                  num3 = (int) num6 * -1271787712 ^ 1093261681;
                  continue;
                case 8:
                  num3 = (int) num6 * -1134602182 ^ 1362637263;
                  continue;
                case 9:
                  this.ScreenShareHijackStarted = false;
                  num3 = (int) num6 * 772100647 ^ -1058993581;
                  continue;
                default:
                  goto label_68;
              }
            }
          }
          finally
          {
            if (flag8)
            {
label_64:
              int num3 = -713275077;
              while (true)
              {
                int num5 = -632521630;
                uint num6;
                switch ((num6 = (uint) (num3 ^ num5)) % 3U)
                {
                  case 1:
                    EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker2);
                    num3 = (int) num6 * 419447153 ^ 7565493;
                    continue;
                  case 2:
                    goto label_64;
                  default:
                    goto label_67;
                }
              }
            }
label_67:;
          }
label_68:
label_69:
          int num7 = -95271817;
label_70:
          bool isVisible;
          while (true)
          {
            int num3 = -632521630;
            uint num5;
            bool flag7;
            int num6;
            switch ((num5 = (uint) (num7 ^ num3)) % 9U)
            {
              case 0:
                if (isVisible)
                {
                  num7 = (int) num5 * -1462614756 ^ 1777053223;
                  continue;
                }
                goto label_128;
              case 1:
                goto label_128;
              case 3:
                if (!flag4)
                {
                  num7 = (int) num5 * 1990107655 ^ -195120360;
                  continue;
                }
                num6 = 0;
                break;
              case 4:
                goto label_69;
              case 5:
                num6 = !flag1 ? 1 : 0;
                break;
              case 6:
                goto label_81;
              case 7:
                num7 = (int) num5 * -1437020111 ^ 1598325382;
                continue;
              case 8:
                if (flag7)
                {
                  num7 = (int) num5 * -1701596180 ^ 1082215342;
                  continue;
                }
                goto label_110;
              default:
                goto label_82;
            }
            flag7 = num6 != 0;
            num7 = -145167689;
          }
label_82:
          object eventLocker3 = EventManager.eventLocker;
          bool flag9 = false;
          try
          {
            EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker3, ref flag9);
label_84:
            int num3 = -906588085;
            while (true)
            {
              int num5 = -632521630;
              uint num6;
              switch ((num6 = (uint) (num3 ^ num5)) % 4U)
              {
                case 0:
                  goto label_84;
                case 1:
                  this.ScreenShareHijackStarted = true;
                  num3 = (int) num6 * 833960260 ^ 390343693;
                  continue;
                case 3:
                  num3 = (int) num6 * 724632006 ^ 2123526554;
                  continue;
                default:
                  goto label_93;
              }
            }
          }
          finally
          {
            if (flag9)
            {
label_89:
              int num3 = -490036176;
              while (true)
              {
                int num5 = -632521630;
                uint num6;
                switch ((num6 = (uint) (num3 ^ num5)) % 3U)
                {
                  case 0:
                    goto label_89;
                  case 2:
                    EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker3);
                    num3 = (int) num6 * 1319102762 ^ -1744330452;
                    continue;
                  default:
                    goto label_92;
                }
              }
            }
label_92:;
          }
label_93:
          zoomEvent.Window.Refresh(true, false);
          zoomEvent.Window.Activate();
label_94:
          int num8 = -1791498796;
label_95:
          while (true)
          {
            int num3 = -632521630;
            uint num5;
            switch ((num5 = (uint) (num8 ^ num3)) % 17U)
            {
              case 0:
                Thread.Sleep(50);
                num8 = (int) num5 * 770958415 ^ -1893721983;
                continue;
              case 1:
                num8 = (int) num5 * 2118263599 ^ 2094483449;
                continue;
              case 2:
                num8 = (int) num5 * 551395439 ^ 61625081;
                continue;
              case 3:
                goto label_104;
              case 5:
                num8 = (int) num5 * -1600862178 ^ -1211963060;
                continue;
              case 6:
                goto label_94;
              case 7:
                num8 = (int) num5 * -1312620153 ^ 1327729473;
                continue;
              case 8:
                zoomEvent.Window.Refresh(true, false);
                num8 = (int) num5 * 2071677519 ^ 73649961;
                continue;
              case 9:
                zoomEvent.Window.Click(new System.Drawing.Point(252, 15), true, true, 50);
                num8 = (int) num5 * -212546177 ^ 1629182707;
                continue;
              case 10:
                num8 = (int) num5 * -2097863269 ^ 680138241;
                continue;
              case 11:
                goto label_110;
              case 12:
                zoomEvent.Window.Click(new System.Drawing.Point(252, 15), true, true, 50);
                Thread.Sleep(50);
                num8 = (int) num5 * -1666224073 ^ -642083743;
                continue;
              case 13:
                zoomEvent.Window.Click(new System.Drawing.Point(252, 66), true, true, 0);
                num8 = (int) num5 * 1449623682 ^ 1725930651;
                continue;
              case 14:
                goto label_138;
              case 15:
                zoomEvent.Window.Activate();
                num8 = (int) num5 * 2133779545 ^ 1323707777;
                continue;
              case 16:
                num8 = (int) num5 * -1458754327 ^ 1529203699;
                continue;
              default:
                goto label_114;
            }
          }
label_104:
          int num10 = !flag2 ? 1 : 0;
          goto label_106;
label_114:
          zoomEvent.Window.Click(new System.Drawing.Point(252, 40), true, true, 0);
          object eventLocker4 = EventManager.eventLocker;
          bool flag10 = false;
          try
          {
            Monitor.Enter(eventLocker4, ref flag10);
            this.ScreenShareHijackInProgress = true;
            goto label_121;
          }
          finally
          {
            if (flag10)
            {
label_117:
              int num3 = -68929247;
              while (true)
              {
                int num5 = -632521630;
                uint num6;
                switch ((num6 = (uint) (num3 ^ num5)) % 3U)
                {
                  case 0:
                    goto label_117;
                  case 1:
                    Monitor.Exit(eventLocker4);
                    num3 = (int) num6 * 1206646036 ^ 2100608953;
                    continue;
                  default:
                    goto label_120;
                }
              }
            }
label_120:;
          }
label_106:
          if (num10 != 0)
          {
            num8 = -1272604604;
            goto label_95;
          }
          else
            goto label_130;
label_110:
          if (!flag4)
          {
            num10 = 0;
            goto label_106;
          }
          else
          {
            num8 = -483774491;
            goto label_95;
          }
label_81:
          isVisible = zoomEvent.Window.IsVisible;
          num7 = -160627613;
          goto label_70;
label_121:
          int num11 = -1882896218;
label_122:
          bool flag11;
          bool flag12;
          while (true)
          {
            int num3 = -632521630;
            uint num5;
            Size size;
            switch ((num5 = (uint) (num11 ^ num3)) % 23U)
            {
              case 0:
                num11 = (int) num5 * 1627353378 ^ -2115254178;
                continue;
              case 1:
                num11 = (int) num5 * 1792883348 ^ -1034869927;
                continue;
              case 2:
                int num6 = flag11 ? -2145502027 : (num6 = -1522375810);
                int num12 = (int) num5 * 707270665;
                num11 = num6 ^ num12;
                continue;
              case 3:
                num11 = (int) num5 * -752607518 ^ -1769698327;
                continue;
              case 4:
                goto label_138;
              case 5:
                goto label_121;
              case 6:
                num11 = (int) num5 * -501234465 ^ -504060069;
                continue;
              case 7:
                goto label_163;
              case 8:
                goto label_128;
              case 9:
                goto label_130;
              case 10:
                int num13 = size.Height < 180 ? -787153365 : (num13 = -619126096);
                int num14 = (int) num5 * -711715735;
                num11 = num13 ^ num14;
                continue;
              case 11:
                size = zoomEvent.Window.Size;
                num11 = (int) num5 * -84331628 ^ 981297081;
                continue;
              case 12:
                zoomEvent.Window.Click(new System.Drawing.Point(280, 180), true, true, 0);
                num11 = (int) num5 * 282263079 ^ -2096895236;
                continue;
              case 13:
                goto label_144;
              case 14:
                num11 = (int) num5 * -2052357297 ^ 1123521511;
                continue;
              case 16:
                num11 = (int) num5 * -931751851 ^ -435556301;
                continue;
              case 17:
                zoomEvent.Window.Click(new System.Drawing.Point(280, 151), true, true, 0);
                num11 = (int) num5 * -1071440927 ^ 1698708291;
                continue;
              case 18:
                num11 = -405919004;
                continue;
              case 19:
                if (flag12)
                {
                  num11 = (int) num5 * 1753839966 ^ 516172784;
                  continue;
                }
                goto label_163;
              case 20:
                goto label_140;
              case 21:
                num11 = (int) num5 * 297533492 ^ 1988690009;
                continue;
              case 22:
                zoomEvent.Window.Refresh(false, false);
                num11 = (int) num5 * 1435742326 ^ 1261730636;
                continue;
              default:
                goto label_147;
            }
          }
label_144:
          int num15 = zoomEvent.Window.IsVisible ? 1 : 0;
          goto label_146;
label_147:
          object eventLocker5 = EventManager.eventLocker;
          bool flag13 = false;
          try
          {
            Monitor.Enter(eventLocker5, ref flag13);
label_149:
            int num3 = -1506204417;
            while (true)
            {
              int num5 = -632521630;
              uint num6;
              switch ((num6 = (uint) (num3 ^ num5)) % 5U)
              {
                case 1:
                  num3 = (int) num6 * 1147363061 ^ -625697398;
                  continue;
                case 2:
                  this.ScreenShareHijackRequested = true;
                  num3 = (int) num6 * -1928890882 ^ -1796846360;
                  continue;
                case 3:
                  goto label_149;
                case 4:
                  num3 = (int) num6 * -69413777 ^ -1558846869;
                  continue;
                default:
                  goto label_160;
              }
            }
          }
          finally
          {
            if (flag13)
            {
label_155:
              int num3 = -17397517;
              while (true)
              {
                int num5 = -632521630;
                uint num6;
                switch ((num6 = (uint) (num3 ^ num5)) % 4U)
                {
                  case 1:
                    Monitor.Exit(eventLocker5);
                    num3 = (int) num6 * 1147604160 ^ -339962379;
                    continue;
                  case 2:
                    goto label_155;
                  case 3:
                    num3 = (int) num6 * 421506451 ^ 2145629067;
                    continue;
                  default:
                    goto label_159;
                }
              }
            }
label_159:;
          }
label_160:
label_161:
          int num16 = -755697572;
label_162:
          int num17 = -632521630;
          switch ((num9 = (uint) (num16 ^ num17)) % 3U)
          {
            case 0:
              goto label_161;
            case 2:
              break;
            default:
              goto label_171;
          }
label_163:
          num16 = -799817250;
          goto label_162;
label_128:
          num11 = -2123268836;
          goto label_122;
label_130:
          flag11 = flag4 & flag2;
          num11 = -916806733;
          goto label_122;
label_138:
          num11 = -1003162673;
          goto label_122;
label_140:
          if (zoomEvent.ZoomWindowType == ZoomWindowType.RequestRemoteControl)
          {
            num11 = -656709488;
            goto label_122;
          }
          else
            num15 = 0;
label_146:
          flag12 = num15 != 0;
          num11 = -1163393575;
          goto label_122;
        }
        catch (Exception ex)
        {
label_165:
          int num2 = -2015488455;
          while (true)
          {
            int num3 = -632521630;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_165;
              case 2:
                num2 = (int) num5 * 1193144798 ^ -896251949;
                continue;
              case 3:
                CoreObject.log.Error((object) ex);
                num2 = (int) num5 * 1522305007 ^ 1332523381;
                continue;
              default:
                goto label_171;
            }
          }
        }
label_171:;
      }
      else
        goto label_175;
label_172:
      int num18 = -1676218742;
label_173:
      int num19 = -632521630;
      switch ((num9 = (uint) (num18 ^ num19)) % 3U)
      {
        case 0:
          return;
        case 1:
          break;
        case 2:
          goto label_172;
        default:
          return;
      }
label_175:
      num18 = -1207505968;
      goto label_173;
label_11:
      num4 = 1;
label_12:
      flag3 = num4 != 0;
      num1 = -1084164186;
      goto label_2;
    }

    private List<ZoomEvent> GetEventBatch(int waitDurationMilliseconds)
    {
label_1:
      int num1 = -685616554;
      List<ZoomEvent> zoomEventList1;
      while (true)
      {
        int num2 = -759899496;
        uint num3;
        ZoomEvent zoomEvent;
        ZoomEventType eventType;
        bool flag;
        List<ZoomEvent> zoomEventList2;
        DateTime now;
        DateTime dateTime;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            now = DateTime.Now;
            num1 = (int) num3 * 144189330 ^ -1372124550;
            continue;
          case 1:
            num1 = -353290790;
            continue;
          case 2:
            int num4;
            num1 = num4 = eventType != ZoomEventType.Undefined ? -881214377 : (num4 = -179264424);
            continue;
          case 3:
            zoomEventList2.Add(zoomEvent);
            num1 = -788850931;
            continue;
          case 4:
            zoomEventList2 = new List<ZoomEvent>();
            num1 = (int) num3 * 2034598195 ^ -564635498;
            continue;
          case 5:
            List<IntPtr> numList = new List<IntPtr>();
            num1 = (int) num3 * 2085178022 ^ 527371282;
            continue;
          case 6:
            num1 = (int) num3 * -179842849 ^ 1906697947;
            continue;
          case 7:
            flag = dateTime > DateTime.Now;
            num1 = -780509908;
            continue;
          case 8:
            int num5 = flag ? 923187407 : (num5 = 919978516);
            int num6 = (int) num3 * -1702070304;
            num1 = num5 ^ num6;
            continue;
          case 9:
          case 15:
            num1 = -1567906408;
            continue;
          case 11:
            num1 = -1685862989;
            continue;
          case 12:
            eventType = zoomEvent.EventType;
            int num7 = eventType == ZoomEventType.Other ? -123153719 : (num7 = -1987161434);
            int num8 = (int) num3 * -1890187869;
            num1 = num7 ^ num8;
            continue;
          case 13:
            num1 = (int) num3 * -1397962665 ^ 1933253502;
            continue;
          case 14:
            num1 = (int) num3 * 2009842847 ^ -1124059787;
            continue;
          case 16:
            goto label_1;
          case 17:
            int num9 = this.Engine.EventQueue.TryDequeue(ref zoomEvent) ? 1054978169 : (num9 = 2087321922);
            int num10 = (int) num3 * 1084979435;
            num1 = num9 ^ num10;
            continue;
          case 18:
            dateTime = now.AddMilliseconds((double) waitDurationMilliseconds);
            num1 = (int) num3 * -1790967015 ^ 937430970;
            continue;
          case 19:
            zoomEvent = (ZoomEvent) null;
            num1 = (int) num3 * 362400044 ^ 606352334;
            continue;
          case 20:
            zoomEventList1 = zoomEventList2;
            num1 = (int) num3 * 383195188 ^ -1735384659;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return zoomEventList1;
    }

    private void HandleMeetingJoined(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 410249374;
      ZoomMeeting meeting;
      object eventLocker;
      while (true)
      {
        int num2 = 871062537;
        uint num3;
        bool flag1;
        string str;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * -1998707287 ^ 1988896007;
            continue;
          case 1:
            flag1 = true;
            str = this.Engine.ActiveMeeting.MeetingId;
            num1 = (int) num3 * 95338541 ^ -1869419089;
            continue;
          case 3:
            int num4 = flag2 ? -1089554053 : (num4 = -1373916516);
            int num5 = (int) num3 * -997747956;
            num1 = num4 ^ num5;
            continue;
          case 4:
            str = string.Empty;
            flag2 = this.Engine.ActiveMeeting != null;
            num1 = (int) num3 * -1504351675 ^ -482083611;
            continue;
          case 5:
            num1 = (int) num3 * -929790337 ^ 1077813434;
            continue;
          case 6:
            meeting = ZoomFactory.CreateMeeting(this.sharedData, zoomEvent);
            eventLocker = EventManager.eventLocker;
            num1 = 2074339780;
            continue;
          case 7:
            flag1 = false;
            num1 = (int) num3 * 1150086753 ^ 1309460160;
            continue;
          case 8:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_10:
      bool flag3 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag3);
        this.ActiveMeeting = meeting;
label_12:
        int num2 = 1169693105;
        while (true)
        {
          int num3 = 871062537;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 1:
              num2 = (int) num4 * -6822858 ^ 1712753669;
              continue;
            case 2:
              goto label_12;
            case 3:
              num2 = (int) num4 * 135877494 ^ -613781576;
              continue;
            case 4:
              this.activeWindow = zoomEvent.Window;
              num2 = (int) num4 * 1295955366 ^ -1524844460;
              continue;
            case 5:
              this.Engine.SetActiveMeeting(this.activeMeeting, this.activeWindow);
              this.activeMeeting.SetStatus(MeetingStatus.Attending);
              num2 = (int) num4 * -297603636 ^ -1499695608;
              continue;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_19:
          int num2 = 397699795;
          while (true)
          {
            int num3 = 871062537;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_19;
              case 1:
                num2 = (int) num4 * 210574911 ^ -1963306643;
                continue;
              case 2:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker);
                num2 = (int) num4 * -363189806 ^ -908779572;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:
      if (this.Engine.ActivePattern == null)
        goto label_28;
label_25:
      int num6 = 1542948514;
label_26:
      List<ZoomButton> list;
      ZoomWindow activeMeetingWindow;
      while (true)
      {
        int num2 = 871062537;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 5U)
        {
          case 0:
            goto label_25;
          case 1:
            goto label_27;
          case 2:
            activeMeetingWindow = this.Engine.ActiveMeetingWindow;
            num6 = (int) num3 * 2126513258 ^ -1346252794;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomButton>) Enumerable.Where<ZoomButton>((IEnumerable<M0>) this.Engine.GetButtons(""), (Func<M0, bool>) (EventManager.\u003C\u003Ec.\u003C\u003E9__118_0 ?? (EventManager.\u003C\u003Ec.\u003C\u003E9__118_0 = new Func<ZoomButton, bool>((object) EventManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CHandleMeetingJoined\u003Eb__118_0)))))).ToList<ZoomButton>();
            num6 = 1050674201;
            continue;
          default:
            goto label_33;
        }
      }
label_27:
      int num7 = EventManager.\u206B⁭‍‏⁯‬‫⁯‎‪⁮⁮‭⁫‎‏⁯​⁮‫⁭⁪⁫‪⁪‬‮‮‮‪‌⁫‫​‌‫‎⁮‮⁬‮(this.Engine.ActivePattern.PatternName, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(765263131U)) ? 1 : 0;
      goto label_29;
label_33:
      using (List<ZoomButton>.Enumerator enumerator = list.GetEnumerator())
      {
label_42:
        int num2 = enumerator.MoveNext() ? 626737379 : (num2 = 1013682510);
        while (true)
        {
          int num3 = 871062537;
          uint num4;
          ZoomButton current;
          bool flag1;
          switch ((num4 = (uint) (num2 ^ num3)) % 13U)
          {
            case 0:
              num2 = 626737379;
              continue;
            case 2:
              num2 = 1736297335;
              continue;
            case 3:
              num2 = (int) num4 * -223872930 ^ -560075091;
              continue;
            case 4:
              goto label_42;
            case 5:
              activeMeetingWindow.Move(new Rectangle(activeMeetingWindow.Location, current.WindowSize));
              num2 = (int) num4 * 1924567376 ^ -421273703;
              continue;
            case 6:
              num2 = (int) num4 * 1620317774 ^ -2008561070;
              continue;
            case 7:
              num2 = (int) num4 * 123434502 ^ 803073309;
              continue;
            case 8:
              activeMeetingWindow.Click(current.ButtonLocation, true, true, 0);
              num2 = (int) num4 * 1820669080 ^ 1673321987;
              continue;
            case 9:
              current = enumerator.Current;
              num2 = 1082192079;
              continue;
            case 10:
              num2 = (int) num4 * 2115248947 ^ 850304996;
              continue;
            case 11:
              flag1 = activeMeetingWindow.Size != current.WindowSize;
              num2 = (int) num4 * 832119389 ^ 1581593650;
              continue;
            case 12:
              int num5 = flag1 ? -1549518165 : (num5 = -521596037);
              int num8 = (int) num4 * 2133168116;
              num2 = num5 ^ num8;
              continue;
            default:
              goto label_50;
          }
        }
      }
label_50:
      goto label_51;
label_28:
      num7 = 0;
label_29:
      if (num7 != 0)
      {
        num6 = 1552182558;
        goto label_26;
      }
      else
        goto label_57;
label_51:
      int num9 = 270610562;
label_52:
      while (true)
      {
        int num2 = 871062537;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 6U)
        {
          case 0:
            num9 = (int) num3 * 1075250799 ^ -952840530;
            continue;
          case 1:
            goto label_57;
          case 2:
            num9 = (int) num3 * 1299544842 ^ -1870185689;
            continue;
          case 3:
            goto label_51;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.OnMeetingJoined((object) this, (EventArgs) new ZoomMeetingEventArgs(this.activeMeeting, MeetingStatus.Attending));
            num9 = (int) num3 * -350825014 ^ 1315382793;
            continue;
          case 5:
            goto label_53;
          default:
            goto label_48;
        }
      }
label_48:
      return;
label_53:
      return;
label_57:
      this.StartMeetingTimer();
      // ISSUE: reference to a compiler-generated field
      num9 = this.OnMeetingJoined == null ? 383606026 : (num9 = 1390449301);
      goto label_52;
    }

    private void HandleMeetingLeft(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = -1432507343;
      string meetingId;
      bool flag1;
      ZoomMeeting activeMeeting;
      while (true)
      {
        int num2 = -318045423;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            EventManager.\u202A‮‪⁫‍​⁭⁭‍‭‏‍‎​⁯‏‮‮⁭⁫‬‪‮‍⁭⁫‫⁫‍⁫⁯⁪​‍‪⁪‫‫⁮‫‮(CoreObject.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2907389426U), (object) zoomEvent);
            num1 = (int) num3 * 1699771843 ^ 2138075321;
            continue;
          case 1:
            flag1 = false;
            num1 = (int) num3 * -2121102295 ^ 565661258;
            continue;
          case 2:
            activeMeeting = this.Engine.ActiveMeeting;
            num1 = (int) num3 * -1186554111 ^ 1884423592;
            continue;
          case 3:
            meetingId = string.Empty;
            num1 = (int) num3 * -1320017756 ^ 1173385010;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      object eventLocker1 = EventManager.eventLocker;
      bool flag2 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker1, ref flag2);
label_9:
        int num2 = -935463592;
        while (true)
        {
          int num3 = -318045423;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 16U)
          {
            case 0:
              this.forceOpenChatWindow = false;
              num2 = (int) num4 * 2114388018 ^ -1796333714;
              continue;
            case 1:
              this.ButtonFindStarted = false;
              num2 = (int) num4 * -1435037673 ^ -696187946;
              continue;
            case 2:
              flag1 = this.RemovedFromMeeting;
              num2 = (int) num4 * -857904242 ^ -1309710221;
              continue;
            case 3:
              this.MeetingLastLeft = DateTime.Now;
              num2 = (int) num4 * 340524850 ^ 1360986685;
              continue;
            case 4:
              this.buttonBar = (ZoomWindow) null;
              num2 = (int) num4 * 750012989 ^ -2126554636;
              continue;
            case 5:
              num2 = (int) num4 * -547497502 ^ -1042260600;
              continue;
            case 7:
              meetingId = this.Engine.ActiveMeeting.MeetingId;
              num2 = (int) num4 * -366925464 ^ -1888694542;
              continue;
            case 8:
              num2 = (int) num4 * 2046012424 ^ -1727263076;
              continue;
            case 9:
              int num5 = this.Engine.ActiveMeeting != null ? -1641748868 : (num5 = -1318566033);
              int num6 = (int) num4 * -490813027;
              num2 = num5 ^ num6;
              continue;
            case 10:
              num2 = (int) num4 * -965070555 ^ 1553632117;
              continue;
            case 11:
              this.activeMeeting = (ZoomMeeting) null;
              this.activeWindow = (ZoomWindow) null;
              num2 = -104573211;
              continue;
            case 12:
              goto label_9;
            case 13:
              activeMeeting = this.Engine.ActiveMeeting;
              num2 = (int) num4 * -1938291311 ^ -1800874405;
              continue;
            case 14:
              this.RemovedFromMeeting = false;
              num2 = (int) num4 * -380940724 ^ -1730912436;
              continue;
            case 15:
              this.holdDetected = false;
              num2 = (int) num4 * -860702250 ^ -45560023;
              continue;
            default:
              goto label_31;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_26:
          int num2 = -1601135146;
          while (true)
          {
            int num3 = -318045423;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_26;
              case 1:
                num2 = (int) num4 * -1166902789 ^ 576314876;
                continue;
              case 3:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker1);
                num2 = (int) num4 * 732378552 ^ -954596416;
                continue;
              default:
                goto label_30;
            }
          }
        }
label_30:;
      }
label_31:
      this.Engine.SetActiveMeeting((ZoomMeeting) null, (ZoomWindow) null);
      if (this.Engine.ActiveActivity == null)
        goto label_45;
label_32:
      int num7 = -1250368526;
label_33:
      object eventLocker2;
      while (true)
      {
        int num2 = -318045423;
        uint num3;
        bool flag3;
        int num4;
        int num5;
        switch ((num3 = (uint) (num7 ^ num2)) % 18U)
        {
          case 0:
            num7 = (int) num3 * 3693494 ^ -1537543600;
            continue;
          case 1:
            this.Engine.CancelActivity((ActivityBase) null);
            num7 = (int) num3 * -844382818 ^ 2037369495;
            continue;
          case 2:
            num4 = activeMeeting != null ? 1 : 0;
            break;
          case 3:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(257891809U));
            num7 = (int) num3 * 1661460723 ^ -629804217;
            continue;
          case 4:
            num7 = (int) num3 * 781881701 ^ 1726789958;
            continue;
          case 5:
            num7 = (int) num3 * 323338822 ^ -1991794438;
            continue;
          case 7:
            goto label_32;
          case 8:
            // ISSUE: reference to a compiler-generated field
            if (this.OnMeetingLeft != null)
            {
              num7 = -1074757519;
              continue;
            }
            num4 = 0;
            break;
          case 9:
            goto label_44;
          case 10:
            num5 = !EventManager.\u206B⁭‍‏⁯‬‫⁯‎‪⁮⁮‭⁫‎‏⁯​⁮‫⁭⁪⁫‪⁪‬‮‮‮‪‌⁫‫​‌‫‎⁮‮⁬‮(meetingId, string.Empty) ? 1 : 0;
            goto label_53;
          case 11:
            num7 = (int) num3 * -975458331 ^ 341816181;
            continue;
          case 12:
            num7 = (int) num3 * 1674553898 ^ 490873133;
            continue;
          case 13:
            if (flag1)
            {
              num7 = -2012084793;
              continue;
            }
            num5 = 0;
            goto label_53;
          case 14:
            num7 = (int) num3 * 257900904 ^ -2000571715;
            continue;
          case 15:
            EventManager.\u200E‬‬⁯​​‌‏⁪⁫⁮⁬‏‮⁮‫⁫⁫‎‎‌⁭⁭⁫‌⁪⁬⁭‪‫‮​⁭‍‍​‌‪‍‏‮(CoreObject.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1157422835U));
            eventLocker2 = EventManager.eventLocker;
            num7 = (int) num3 * 1861797465 ^ -2092020082;
            continue;
          case 16:
            if (flag3)
            {
              num7 = (int) num3 * 2114484770 ^ 1299613864;
              continue;
            }
            goto label_93;
          case 17:
            // ISSUE: reference to a compiler-generated field
            this.OnMeetingLeft((object) this, (EventArgs) new ZoomMeetingEventArgs(activeMeeting, MeetingStatus.NotAttending));
            num7 = (int) num3 * -1917382928 ^ -426272771;
            continue;
          default:
            goto label_59;
        }
        int num6;
        num7 = num6 = num4 == 0 ? -530727694 : (num6 = -130662097);
        continue;
label_53:
        flag3 = num5 != 0;
        num7 = -1633842855;
      }
label_44:
      int num8 = this.Engine.ActiveActivity is FloodChat ? 1 : 0;
      goto label_46;
label_59:
      bool flag4 = false;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker2, ref flag4);
label_61:
        int num2 = -187537004;
        while (true)
        {
          int num3 = -318045423;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 18U)
          {
            case 0:
              goto label_61;
            case 1:
              num2 = (int) num4 * 353618985 ^ 1775911198;
              continue;
            case 2:
              num2 = (int) num4 * -82109658 ^ 1129127616;
              continue;
            case 3:
              this.HammerQueued = true;
              num2 = (int) num4 * 439903441 ^ -597677380;
              continue;
            case 4:
              int num5 = !this.SharedData.Settings.HammerAfterRemoved ? -607349011 : (num5 = -490401547);
              int num6 = (int) num4 * 1270588525;
              num2 = num5 ^ num6;
              continue;
            case 5:
              num2 = (int) num4 * 1943340798 ^ -1874017829;
              continue;
            case 6:
              int num9;
              num2 = num9 = !this.SharedData.Settings.MoveNextAfterRemoved ? -134086741 : (num9 = -1419492002);
              continue;
            case 7:
              num2 = (int) num4 * -228111880 ^ -1915428012;
              continue;
            case 8:
              num2 = (int) num4 * 1384066951 ^ -1575281815;
              continue;
            case 9:
              EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2151745630U));
              num2 = (int) num4 * -1650909457 ^ -1601425561;
              continue;
            case 10:
              Engine engine1 = this.Engine;
              JoinMeeting joinMeeting = new JoinMeeting("");
              int num10 = 1;
              joinMeeting.AutoGenerated = num10 != 0;
              string callerName1 = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2966283412U);
              engine1.AddActivity((ActivityBase) joinMeeting, callerName1);
              num2 = (int) num4 * -670419708 ^ 384858146;
              continue;
            case 11:
              num2 = (int) num4 * 54375940 ^ 589971057;
              continue;
            case 12:
              goto label_87;
            case 13:
              num2 = (int) num4 * -884702238 ^ 1287411316;
              continue;
            case 14:
              this.HammerQueued = false;
              num2 = -1512234288;
              continue;
            case 15:
              int num11 = this.HammerQueued ? 840699697 : (num11 = 1405471882);
              int num12 = (int) num4 * 1507656104;
              num2 = num11 ^ num12;
              continue;
            case 16:
              num2 = -1285353019;
              continue;
            case 17:
              EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3568348494U));
              Engine engine2 = this.Engine;
              HammerMeeting hammerMeeting = new HammerMeeting(meetingId);
              int num13 = 1;
              hammerMeeting.AutoGenerated = num13 != 0;
              string callerName2 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(535488056U);
              engine2.AddActivity((ActivityBase) hammerMeeting, callerName2);
              num2 = (int) num4 * 768273565 ^ -1151683550;
              continue;
            default:
              goto label_83;
          }
        }
label_83:
        return;
label_87:
        return;
      }
      finally
      {
        if (flag4)
        {
label_81:
          int num2 = -507652540;
          while (true)
          {
            int num3 = -318045423;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker2);
                num2 = (int) num4 * 969845897 ^ -1026298501;
                continue;
              case 2:
                goto label_81;
              case 3:
                num2 = (int) num4 * -2025845697 ^ -1422492524;
                continue;
              default:
                goto label_86;
            }
          }
        }
label_86:;
      }
label_93:
      int num14 = !this.SharedData.Settings.AutoAttendent ? -1174438954 : (num14 = -1407165804);
      while (true)
      {
        int num2 = -318045423;
        uint num3;
        switch ((num3 = (uint) (num14 ^ num2)) % 5U)
        {
          case 0:
            num14 = (int) num3 * 1101534141 ^ 1410135709;
            continue;
          case 1:
            goto label_93;
          case 2:
            goto label_90;
          case 3:
            num14 = (int) num3 * 1539842938 ^ 2068833476;
            continue;
          case 4:
            num14 = -1859503978;
            continue;
          default:
            goto label_79;
        }
      }
label_79:
      return;
label_90:
      return;
label_45:
      num8 = 0;
label_46:
      num7 = num8 == 0 ? -877575491 : (num7 = -85285440);
      goto label_33;
    }

    private void HandleRemovedFromMeeting(ZoomEvent zoomEvent)
    {
      this.StopMeetingTimer();
      object eventLocker = EventManager.eventLocker;
      bool flag1 = false;
      string previousMeetingId;
      try
      {
        EventManager.\u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮(eventLocker, ref flag1);
label_2:
        int num1 = -1295087114;
        while (true)
        {
          int num2 = -558634686;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 2:
              previousMeetingId = this.previousMeetingId;
              num1 = (int) num3 * 1903259393 ^ 1016947160;
              continue;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_6:
          int num1 = -822375564;
          while (true)
          {
            int num2 = -558634686;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * 859175247 ^ -1502784491;
                continue;
              case 2:
                EventManager.\u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮(eventLocker);
                num1 = (int) num3 * 1211073759 ^ 681078517;
                continue;
              case 3:
                goto label_6;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
label_12:
      bool flag2 = this.Engine.ActivitiesPending.Count > 0;
label_13:
      int num4 = -689535336;
      while (true)
      {
        int num1 = -558634686;
        uint num2;
        bool hammerAfterRemoved;
        switch ((num2 = (uint) (num4 ^ num1)) % 20U)
        {
          case 0:
            num4 = (int) num2 * 1417306764 ^ -983209761;
            continue;
          case 1:
            num4 = (int) num2 * 458929094 ^ 1839095127;
            continue;
          case 2:
            int num3 = !flag2 ? 1814684435 : (num3 = 1415935611);
            int num5 = (int) num2 * -2061594238;
            num4 = num3 ^ num5;
            continue;
          case 3:
            this.Engine.ActivitiesPending.Take<ActivityBase>(this.Engine.ActivitiesPending.Count);
            num4 = (int) num2 * 103760649 ^ -1124786021;
            continue;
          case 4:
            goto label_13;
          case 5:
            this.Engine.CancelActivity((ActivityBase) null);
            hammerAfterRemoved = this.SharedData.Settings.HammerAfterRemoved;
            num4 = -948524131;
            continue;
          case 6:
            Engine engine1 = this.Engine;
            JoinMeeting joinMeeting = new JoinMeeting("");
            int num6 = 1;
            joinMeeting.AutoGenerated = num6 != 0;
            string callerName1 = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2612440938U);
            engine1.AddActivity((ActivityBase) joinMeeting, callerName1);
            num4 = (int) num2 * -843561148 ^ 1262251870;
            continue;
          case 7:
            Engine engine2 = this.Engine;
            HammerMeeting hammerMeeting = new HammerMeeting(previousMeetingId);
            int num7 = 1;
            hammerMeeting.AutoGenerated = num7 != 0;
            string callerName2 = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3430977227U);
            engine2.AddActivity((ActivityBase) hammerMeeting, callerName2);
            num4 = (int) num2 * 1140111887 ^ 1109054012;
            continue;
          case 8:
            num4 = (int) num2 * -1303074018 ^ -1191581188;
            continue;
          case 9:
            goto label_15;
          case 10:
            num4 = (int) num2 * -503492971 ^ -1883723819;
            continue;
          case 11:
            int num8 = hammerAfterRemoved ? 442090982 : (num8 = 181413383);
            int num9 = (int) num2 * 1001685634;
            num4 = num8 ^ num9;
            continue;
          case 12:
            num4 = (int) num2 * 1292817690 ^ 212175698;
            continue;
          case 13:
            num4 = (int) num2 * 188820163 ^ -441223356;
            continue;
          case 14:
            num4 = (int) num2 * 1031066169 ^ -799395739;
            continue;
          case 15:
            num4 = (int) num2 * 167592536 ^ -160102497;
            continue;
          case 16:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(831121854U));
            num4 = (int) num2 * -603706823 ^ -784372834;
            continue;
          case 17:
            num4 = (int) num2 * -2033213145 ^ -747027609;
            continue;
          case 18:
            EventManager.\u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1861773512U));
            num4 = (int) num2 * -1335639882 ^ -1838664411;
            continue;
          case 19:
            int num10;
            num4 = num10 = this.SharedData.Settings.MoveNextAfterRemoved ? -403407766 : (num10 = -107527549);
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_15:;
    }

    private void StartEventManagerTimer()
    {
      this.EventTimer = EventManager.\u206B‏‬‮⁯‬⁫⁭‭⁬‫⁬⁬‌⁫⁮⁬⁯⁪‌‬​‬⁯‫‌‪⁫⁭⁫‬⁪‭‍⁭‍⁬‭⁪⁬‮(DispatcherPriority.SystemIdle);
label_1:
      int num1 = -237738824;
      while (true)
      {
        int num2 = -1885748491;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -312426294 ^ 701370911;
            continue;
          case 2:
            EventManager.\u202E‎⁬​‏‌‪⁬‮⁫‫‍‭‫‭‍‫‫⁯‪‮‏‫‪​⁬‍⁯‫‭⁪‬‫‬⁪⁫⁮‬‍⁮‮(this.EventTimer, true);
            num1 = (int) num3 * 1706668789 ^ 233863844;
            continue;
          case 3:
            EventManager.\u200F‭​⁭‮‭​‍‏‍‌‎‮⁬⁬⁬‍‫‮‫⁮‫‏‌‮‌‬‭‍‫‬‏‭‬⁫‮‎⁮⁬‮(this.EventTimer, new EventHandler(this.EventTimer_Tick));
            num1 = (int) num3 * 1687848554 ^ 199207915;
            continue;
          case 4:
            goto label_1;
          case 5:
            EventManager.\u202A‪‍⁭⁮‮‪‭⁪‪‫⁬⁬‪‌‫‏⁭⁭‎‎​‭‍⁭‌‫‫⁮​⁯‌⁬‍‎‭‫‮​‌‮(this.EventTimer, TimeSpan.FromMilliseconds(5.0));
            num1 = (int) num3 * -682939401 ^ -220156423;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      EventManager.\u202C‮‮‮‭‏‪⁭‪⁪‭‌​‎‍‭⁯⁬⁮⁮⁫⁬‌‍‭⁫⁭‏⁫‏‮‍‏⁭‪‌⁮‮‬‍‮(this.EventTimer);
    }

    private void EventTimer_Tick(object sender, EventArgs e)
    {
      try
      {
        ZoomEvent zoomEvent = (ZoomEvent) null;
label_2:
        int num1 = -2143946569;
        while (true)
        {
          int num2 = -983782707;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              goto label_2;
            case 1:
              int num4 = !this.Engine.EventQueue.TryDequeue(ref zoomEvent) ? -1125577640 : (num4 = -675024369);
              int num5 = (int) num3 * 1327295770;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.HandleInvalidMeeting(zoomEvent);
              num1 = (int) num3 * -410138386 ^ 924532646;
              continue;
            case 3:
              num1 = (int) num3 * 337954102 ^ -2023723437;
              continue;
            case 4:
              num1 = (int) num3 * -2045185457 ^ 702006355;
              continue;
            case 5:
              num1 = (int) num3 * -1683829906 ^ -606881084;
              continue;
            case 6:
              this.HandleAlertWindow(zoomEvent);
              num1 = (int) num3 * -166510606 ^ -791659548;
              continue;
            case 7:
              num1 = (int) num3 * 1445694587 ^ 1603582662;
              continue;
            case 8:
              num1 = (int) num3 * -268782653 ^ 1552227163;
              continue;
            case 9:
              this.HandleFullMeeting(zoomEvent);
              num1 = (int) num3 * 1252341045 ^ 660231284;
              continue;
            case 10:
              flag = !this.Engine.EventQueue.get_IsEmpty();
              num1 = (int) num3 * -1536137763 ^ 1095082436;
              continue;
            case 11:
              int num6 = flag ? -492616883 : (num6 = -885473871);
              int num7 = (int) num3 * -907231549;
              num1 = num6 ^ num7;
              continue;
            case 12:
              this.HandleScreenShareHijack(zoomEvent);
              num1 = (int) num3 * -354152012 ^ 2078818228;
              continue;
            case 13:
              goto label_25;
            case 14:
              this.DistributeEvent(zoomEvent);
              num1 = (int) num3 * -285272861 ^ 1856968404;
              continue;
            case 15:
              num1 = -1042754336;
              continue;
            default:
              goto label_23;
          }
        }
label_23:
        return;
label_25:;
      }
      catch (Exception ex)
      {
label_21:
        int num1 = -653994240;
        while (true)
        {
          int num2 = -983782707;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_21;
            case 1:
              goto label_19;
            case 2:
              EventManager.\u206A‫‍‫‫‬⁯⁫‫‬‌‪‬‫‬⁫‬‬‌‭⁬‬⁫‎‬⁬⁪‏⁮‮​‪⁯‫⁪⁯⁮⁬⁭‎‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1114843921 ^ 1860930603;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_19:;
      }
    }

    private void StopEventManagerTimer()
    {
label_1:
      int num1 = -264740653;
      while (true)
      {
        int num2 = -1008771166;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            EventManager.\u200B‮⁭⁭‮⁭‫⁪‪‏​​⁮‮‏‪‎‬‫‏‮‪‎⁯⁬​‭‭⁯‏‭‏‭‏⁫‫‏‎‮⁬‮(this.EventTimer);
            num1 = (int) num3 * 2067177226 ^ -366551230;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.EventTimer = (DispatcherTimer) null;
            num1 = (int) num3 * 716351511 ^ -972200159;
            continue;
          case 4:
            num1 = (int) num3 * 1127969213 ^ -11247818;
            continue;
          case 5:
            EventManager.\u202E‎⁬​‏‌‪⁬‮⁫‫‍‭‫‭‍‫‫⁯‪‮‏‫‪​⁬‍⁯‫‭⁪‬‫‬⁪⁫⁮‬‍⁮‮(this.EventTimer, false);
            num1 = (int) num3 * -1333707814 ^ -1616632287;
            continue;
          case 6:
            num1 = (int) num3 * -1904656752 ^ 1614998898;
            continue;
          case 7:
            num1 = (int) num3 * -1871551179 ^ 736466091;
            continue;
          case 8:
            int num4 = this.EventTimer == null ? 1598986335 : (num4 = 430143655);
            int num5 = (int) num3 * 1501734909;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void StartMeetingTimer()
    {
      // ISSUE: method pointer
      EventManager.\u206B⁪‬⁭⁮⁪‏​⁯⁬⁪‮⁭‮‪‌⁬‎⁭‮‫​​‪‪⁮‍​⁭‮⁯​​‍⁮⁪⁪‬‌⁪‮(EventManager.\u206F‍‍‭‏‭‫‭‪⁯‍⁫⁫‎‮‎⁬⁬‮‏⁬‬⁪⁭⁫‬⁮⁯‬‎⁯⁮‪‬‌⁭‬‎‬⁫‮(), new Action((object) this, __methodptr(\u003CStartMeetingTimer\u003Eb__130_0)));
    }

    private void MeetingTimer_Tick(object sender, EventArgs e)
    {
      CancellationToken token = this.Token;
      // ISSUE: explicit reference operation
      bool flag = !((CancellationToken) @token).get_IsCancellationRequested();
label_1:
      int num1 = -1810004908;
      while (true)
      {
        int num2 = -689349269;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            this.CheckMinimumParticipants();
            num1 = (int) num3 * -88913686 ^ 1667055813;
            continue;
          case 1:
            this.CheckMeetingAttendenceDuration();
            num1 = (int) num3 * -2102267606 ^ -1483891932;
            continue;
          case 2:
            num1 = (int) num3 * -57649883 ^ -794789837;
            continue;
          case 3:
            this.CheckMeetingInProgress();
            num1 = (int) num3 * 253986142 ^ -1512136089;
            continue;
          case 4:
            num1 = (int) num3 * -577575435 ^ 1613532047;
            continue;
          case 5:
            goto label_1;
          case 6:
            int num4 = flag ? -365857541 : (num4 = -522452379);
            int num5 = (int) num3 * 657478046;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = (int) num3 * -603622621 ^ -1176776751;
            continue;
          case 8:
            this.CheckMeetingAttendence();
            num1 = (int) num3 * -2095620587 ^ 1071477370;
            continue;
          case 9:
            goto label_3;
          case 10:
            num1 = (int) num3 * 985134452 ^ -871561281;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    private void StopMeetingTimer()
    {
label_1:
      int num1 = -833791409;
      while (true)
      {
        int num2 = -1261964180;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_19;
          case 2:
            goto label_1;
          case 3:
            int num4 = this.MeetingTimer == null ? 1807669135 : (num4 = 2111043198);
            int num5 = (int) num3 * 1807141037;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_5;
        }
      }
label_19:
      return;
label_5:
      try
      {
        EventManager.\u200B‮⁭⁭‮⁭‫⁪‪‏​​⁮‮‏‪‎‬‫‏‮‪‎⁯⁬​‭‭⁯‏‭‏‭‏⁫‫‏‎‮⁬‮(this.MeetingTimer);
        this.MeetingTimer = (DispatcherTimer) null;
label_7:
        int num2 = -1453285294;
        while (true)
        {
          int num3 = -1261964180;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_7;
            case 1:
              num2 = (int) num4 * 1540661220 ^ -1590616477;
              continue;
            case 2:
              num2 = (int) num4 * 541425836 ^ -1377909311;
              continue;
            case 3:
              goto label_16;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_16:;
      }
      catch (Exception ex)
      {
label_14:
        int num2 = -1261666038;
        while (true)
        {
          int num3 = -1261964180;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_9;
            case 1:
              EventManager.\u206A‫‍‫‫‬⁯⁫‫‬‌‪‬‫‬⁫‬‬‌‭⁬‬⁫‎‬⁬⁪‏⁮‮​‪⁯‫⁪⁯⁮⁬⁭‎‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * -1775613357 ^ -2093285817;
              continue;
            case 2:
              num2 = (int) num4 * -386752449 ^ 1353332247;
              continue;
            case 3:
              goto label_14;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_9:;
      }
    }

    static void \u202D‏‎⁮‏‭‫‮⁪‪‭⁫‮⁬‌⁫⁭‍‍‪⁮‌‭‎⁫‍⁭​‫‮⁬‏‭‪‌‬‍⁪⁮‍‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202E‌‪‎‏⁬⁬‭‎⁬⁫​‫‌‍‫‫‪‍⁯‌⁪‮‎‪⁯‎‪​‫⁬⁭‌​‎‎‌⁯⁬‎‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static void \u200D⁯‪​‬‮‏⁬‬‮‪‮⁬⁭⁮‭‭‍‪‌‎‏⁬‍⁭⁪⁮⁬‭‫‫‎⁯‫‍⁫⁯⁪‮‫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Warn(obj1);
    }

    static NotImplementedException \u200E‌‍‎‏⁪⁪​⁫⁯⁭⁫⁭⁫‏‎⁭⁪‎‎⁫⁪‌⁭⁬‏‬‎⁯​‏⁪‮⁬⁯​‌⁪⁫⁫‮()
    {
      return new NotImplementedException();
    }

    static void \u206B‪‌⁭‫‪⁬‏⁫‪‏⁪‎‌⁫‪⁬‏⁬‎​‪⁯‮⁪⁭‏​‍⁫‍⁮‎⁫⁯‮​‭​‮‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static void \u200D‫⁫‌⁪‌‬⁯‍‪‭‏⁯⁮‭⁭‏‭‭‬‎‮⁭‭‭‭⁮⁬‌⁭⁭‪‪‭‌‫‪⁪⁯⁪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static bool \u206B⁭‍‏⁯‬‫⁯‎‪⁮⁮‭⁫‎‏⁯​⁮‫⁭⁪⁫‪⁪‬‮‮‮‪‌⁫‫​‌‫‎⁮‮⁬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u202A‮‪⁫‍​⁭⁭‍‭‏‍‎​⁯‏‮‮⁭⁫‬‪‮‍⁭⁫‫⁫‍⁫⁯⁪​‍‪⁪‫‫⁮‫‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.InfoFormat(obj1, obj2);
    }

    static void \u200E‬‬⁯​​‌‏⁪⁫⁮⁬‏‮⁮‫⁫⁫‎‎‌⁭⁭⁫‌⁪⁬⁭‪‫‮​⁭‍‍​‌‪‍‏‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }

    static Delegate \u202C‮‮‮‬‪‬⁭​‫‍‍⁫⁫⁮⁪‌‮⁪‮⁬⁯⁫‪‎⁮⁯‫‮‌‍‮‍⁭​⁮‏‍⁪⁫‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u206C​⁮​​‮‭‬⁯⁫⁮‪‍‌‎‍​⁫⁪⁪‮⁬⁬⁫‫‌⁫‭‬‪⁬⁫⁬‬⁫​⁪​‫‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static DispatcherTimer \u206B‏‬‮⁯‬⁫⁭‭⁬‫⁬⁬‌⁫⁮⁬⁯⁪‌‬​‬⁯‫‌‪⁫⁭⁫‬⁪‭‍⁭‍⁬‭⁪⁬‮([In] DispatcherPriority obj0)
    {
      return new DispatcherTimer(obj0);
    }

    static void \u202A‪‍⁭⁮‮‪‭⁪‪‫⁬⁬‪‌‫‏⁭⁭‎‎​‭‍⁭‌‫‫⁮​⁯‌⁬‍‎‭‫‮​‌‮([In] DispatcherTimer obj0, [In] TimeSpan obj1)
    {
      obj0.Interval = obj1;
    }

    static void \u200F‭​⁭‮‭​‍‏‍‌‎‮⁬⁬⁬‍‫‮‫⁮‫‏‌‮‌‬‭‍‫‬‏‭‬⁫‮‎⁮⁬‮([In] DispatcherTimer obj0, [In] EventHandler obj1)
    {
      obj0.Tick += obj1;
    }

    static void \u202E‎⁬​‏‌‪⁬‮⁫‫‍‭‫‭‍‫‫⁯‪‮‏‫‪​⁬‍⁯‫‭⁪‬‫‬⁪⁫⁮‬‍⁮‮([In] DispatcherTimer obj0, [In] bool obj1)
    {
      obj0.IsEnabled = obj1;
    }

    static void \u202C‮‮‮‭‏‪⁭‪⁪‭‌​‎‍‭⁯⁬⁮⁮⁫⁬‌‍‭⁫⁭‏⁫‏‮‍‏⁭‪‌⁮‮‬‍‮([In] DispatcherTimer obj0)
    {
      obj0.Start();
    }

    static void \u206A‫‍‫‫‬⁯⁫‫‬‌‪‬‫‬⁫‬‬‌‭⁬‬⁫‎‬⁬⁪‏⁮‮​‪⁯‫⁪⁯⁮⁬⁭‎‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u200B‮⁭⁭‮⁭‫⁪‪‏​​⁮‮‏‪‎‬‫‏‮‪‎⁯⁬​‭‭⁯‏‭‏‭‏⁫‫‏‎‮⁬‮([In] DispatcherTimer obj0)
    {
      obj0.Stop();
    }

    static TaskFactory \u206F‍‍‭‏‭‫‭‪⁯‍⁫⁫‎‮‎⁬⁬‮‏⁬‬⁪⁭⁫‬⁮⁯‬‎⁯⁮‪‬‌⁭‬‎‬⁫‮()
    {
      return Task.get_Factory();
    }

    static Task \u206B⁪‬⁭⁮⁪‏​⁯⁬⁪‮⁭‮‪‌⁬‎⁭‮‫​​‪‪⁮‍​⁭‮⁯​​‍⁮⁪⁪‬‌⁪‮([In] TaskFactory obj0, [In] Action obj1)
    {
      return obj0.StartNew(obj1);
    }

    static object \u202B‎‬⁫⁮‬‬‪‎‌⁬‫‌‫‪‭‮‏⁪⁯⁭⁪‮‌‪⁯‫‬⁯⁬⁮⁯⁬‍⁭‫‮‬‭‏‮()
    {
      return new object();
    }
  }
}
