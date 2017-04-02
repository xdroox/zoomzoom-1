// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.FloodChatOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Chats;

namespace ZoomZoom.Models.Activities
{
  public class FloodChatOptions : CoreObject
  {
    protected new static readonly ILog log = FloodChatOptions.\u206E‏‪⁬‬⁮​‏‍‌⁬‌⁪⁬‮‌‎⁭⁬‌​‍⁬​‭⁫‍⁭⁬⁬‍⁭‏⁭​⁮‍⁪‭‭‮(FloodChatOptions.\u200F‭⁮‎‭‭⁪‪‎‎​‭‬⁮​⁪⁭‏⁮‫⁬⁪⁬⁮​⁪‪‫‮‌⁯‭⁭​‬⁬‮⁭‎‍‮((MemberInfo) FloodChatOptions.\u206B⁮‏⁪‪‫⁪​⁪⁯⁮‌‮‮​‏‏⁭‪‪‌⁬⁮⁭⁯⁮⁬‍‬⁭‏⁪‪‪‪⁫‫‏⁯‮()));
    private bool floodAllPrivately = false;
    private LayoutPattern enforcedPattern = (LayoutPattern) null;
    private string manualMessage;
    private bool randomize;
    private bool verifyTargetUser;
    private MessageCategory sourceCategory;
    private ObservableCollection<MessageCategory> sourceCategories;
    private MessageContent sourceMessage;
    private ObservableCollection<MessageContent> sourceMessages;
    private int messagesToSend;
    private bool breakOnKeypress;
    private ActivityTarget target;

    public string ManualMessage
    {
      get
      {
label_1:
        int num1 = 1319200516;
        string manualMessage;
        while (true)
        {
          int num2 = 1907133719;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 591168678 ^ -1805145521;
              continue;
            case 3:
              manualMessage = this.manualMessage;
              num1 = (int) num3 * -1263841975 ^ -1337344847;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return manualMessage;
      }
      set
      {
label_1:
        int num1 = 1886291825;
        while (true)
        {
          int num2 = 939773380;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              ZoomZoom.Properties.Settings.Default.FloodManualMessage = this.manualMessage;
              num1 = (int) num3 * 2140605642 ^ 908074470;
              continue;
            case 1:
              FloodChatOptions.\u202B‬‪⁭‌‍⁫‫⁬‌⁪​⁯‪⁮⁮‫‌‎⁬‌‫‪‏⁯⁬⁪‫‬‪⁫‎‮‌‍‌​⁪⁬⁫‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.OnPropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3489616365U));
              num1 = (int) num3 * -345628482 ^ -458336249;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 801888517 ^ -480645839;
              continue;
            case 4:
              this.manualMessage = value;
              num1 = (int) num3 * 1557183980 ^ 1941858375;
              continue;
            case 5:
              goto label_1;
            case 6:
              num1 = (int) num3 * -1545167740 ^ 1122097936;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool Randomize
    {
      get
      {
        return this.randomize;
      }
      set
      {
label_1:
        int num1 = 251981832;
        while (true)
        {
          int num2 = 1884484343;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              ZoomZoom.Properties.Settings.Default.FloodRandomize = this.randomize;
              num1 = (int) num3 * -1980239048 ^ 517345312;
              continue;
            case 1:
              num1 = (int) num3 * 1121687991 ^ 1883967506;
              continue;
            case 2:
              goto label_1;
            case 3:
              FloodChatOptions.\u202B‬‪⁭‌‍⁫‫⁬‌⁪​⁯‪⁮⁮‫‌‎⁬‌‫‪‏⁯⁬⁪‫‬‪⁫‎‮‌‍‌​⁪⁬⁫‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              this.OnPropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3190864553U));
              num1 = (int) num3 * -359392077 ^ 1364371475;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.randomize = value;
              num1 = (int) num3 * -1702184882 ^ -373158467;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public bool VerifyTargetUser
    {
      get
      {
        return this.verifyTargetUser;
      }
      set
      {
        this.verifyTargetUser = value;
        this.OnPropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(105479278U));
label_1:
        int num1 = -1556486549;
        while (true)
        {
          int num2 = -641765648;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 335119199 ^ 1725763873;
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

    public int MessagesToSend
    {
      get
      {
label_1:
        int num1 = -758966443;
        int messagesToSend;
        while (true)
        {
          int num2 = -1095734137;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -627817335 ^ -56337647;
              continue;
            case 2:
              messagesToSend = this.messagesToSend;
              num1 = (int) num3 * 1519548980 ^ 1434723894;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return messagesToSend;
      }
      set
      {
label_1:
        int num1 = -560087937;
        while (true)
        {
          int num2 = -304566872;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              this.messagesToSend = value;
              num1 = (int) num3 * 1536886376 ^ 1382332108;
              continue;
            case 2:
              ZoomZoom.Properties.Settings.Default.FloodMessageCount = this.messagesToSend;
              num1 = (int) num3 * -1385074945 ^ 1643469453;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.OnPropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(671870102U));
              num1 = (int) num3 * 2111855713 ^ 1088217215;
              continue;
            case 5:
              FloodChatOptions.\u202B‬‪⁭‌‍⁫‫⁬‌⁪​⁯‪⁮⁮‫‌‎⁬‌‫‪‏⁯⁬⁪‫‬‪⁫‎‮‌‍‌​⁪⁬⁫‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -1044442141 ^ -932642205;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public bool BreakOnKeypress
    {
      get
      {
label_1:
        int num1 = 655827297;
        bool breakOnKeypress;
        while (true)
        {
          int num2 = 1378215666;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -590049729 ^ 679117279;
              continue;
            case 2:
              goto label_1;
            case 3:
              breakOnKeypress = this.breakOnKeypress;
              num1 = (int) num3 * -792025003 ^ 1983742545;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return breakOnKeypress;
      }
      set
      {
label_1:
        int num1 = 43796868;
        while (true)
        {
          int num2 = 1474289608;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1897833879 ^ 659105757;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.OnPropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2451793560U));
              num1 = (int) num3 * 1547616306 ^ -1903017224;
              continue;
            case 4:
              FloodChatOptions.\u202B‬‪⁭‌‍⁫‫⁬‌⁪​⁯‪⁮⁮‫‌‎⁬‌‫‪‏⁯⁬⁪‫‬‪⁫‎‮‌‍‌​⁪⁬⁫‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * 1481120914 ^ -1937106168;
              continue;
            case 5:
              num1 = (int) num3 * -465887092 ^ 761715890;
              continue;
            case 6:
              this.breakOnKeypress = value;
              num1 = (int) num3 * -230119117 ^ -1269802756;
              continue;
            case 7:
              num1 = (int) num3 * 972290882 ^ -316724893;
              continue;
            case 8:
              ZoomZoom.Properties.Settings.Default.FloodBreakOnKeypress = this.breakOnKeypress;
              num1 = (int) num3 * 1829818077 ^ -1933501284;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public bool FloodAllPrivately
    {
      get
      {
        bool floodAllPrivately = this.floodAllPrivately;
label_1:
        int num1 = -1435461470;
        while (true)
        {
          int num2 = -1047002073;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -2091397884 ^ -328622878;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return floodAllPrivately;
      }
      set
      {
label_1:
        int num1 = 2127522298;
        while (true)
        {
          int num2 = 1365261535;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.OnPropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(313073790U));
              num1 = (int) num3 * 1182713821 ^ -2068481495;
              continue;
            case 1:
              num1 = (int) num3 * 97808978 ^ 827827242;
              continue;
            case 2:
              goto label_3;
            case 3:
              FloodChatOptions.\u202B‬‪⁭‌‍⁫‫⁬‌⁪​⁯‪⁮⁮‫‌‎⁬‌‫‪‏⁯⁬⁪‫‬‪⁫‎‮‌‍‌​⁪⁬⁫‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -64591386 ^ 100263069;
              continue;
            case 4:
              this.floodAllPrivately = value;
              ZoomZoom.Properties.Settings.Default.FloodAllUsersPrivately = this.FloodAllPrivately;
              num1 = (int) num3 * 1198417495 ^ -152835173;
              continue;
            case 5:
              num1 = (int) num3 * -1642521940 ^ -1524195152;
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

    public LayoutPattern EnforcedPattern
    {
      get
      {
label_1:
        int num1 = 1520133956;
        LayoutPattern enforcedPattern;
        while (true)
        {
          int num2 = 123071544;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              enforcedPattern = this.enforcedPattern;
              num1 = (int) num3 * 1357072935 ^ 1797821935;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return enforcedPattern;
      }
      set
      {
        this.enforcedPattern = value;
label_1:
        int num1 = 26547840;
        while (true)
        {
          int num2 = 1329803617;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.OnPropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1133674075U));
              num1 = (int) num3 * -1302386414 ^ 877939929;
              continue;
            case 2:
              num1 = (int) num3 * 1541814270 ^ 1156721849;
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

    public ActivityTarget Target
    {
      get
      {
label_1:
        int num1 = 411687021;
        ActivityTarget target;
        while (true)
        {
          int num2 = 1884449854;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              target = this.target;
              num1 = (int) num3 * 975272667 ^ 1967560880;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return target;
      }
      set
      {
        this.target = value;
        this.OnPropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(493099622U));
      }
    }

    public MessageCategory SourceCategory
    {
      get
      {
        MessageCategory sourceCategory = this.sourceCategory;
label_1:
        int num1 = -601528589;
        while (true)
        {
          int num2 = -1276356323;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1280393787 ^ 1286202364;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return sourceCategory;
      }
      set
      {
        this.sourceCategory = value;
label_1:
        int num1 = -975070107;
        while (true)
        {
          int num2 = -775308669;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1301769020U));
              num1 = (int) num3 * -914573113 ^ 921374122;
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

    public ObservableCollection<MessageCategory> SourceCategories
    {
      get
      {
label_1:
        int num1 = -184050004;
        ObservableCollection<MessageCategory> sourceCategories;
        while (true)
        {
          int num2 = -758266950;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              sourceCategories = this.sourceCategories;
              num1 = (int) num3 * 960610777 ^ 44214150;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return sourceCategories;
      }
      set
      {
        this.sourceCategories = value;
label_1:
        int num1 = -2010598086;
        while (true)
        {
          int num2 = -719926340;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1978748702U));
              num1 = (int) num3 * -1631402803 ^ -1458629511;
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

    public MessageContent SourceMessage
    {
      get
      {
        return this.sourceMessage;
      }
      set
      {
label_1:
        int num1 = 412293167;
        while (true)
        {
          int num2 = 1877880442;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3625787415U));
              num1 = (int) num3 * 1231338102 ^ 1991122529;
              continue;
            case 1:
              this.sourceMessage = value;
              num1 = (int) num3 * -620579939 ^ -925127813;
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

    public ObservableCollection<MessageContent> SourceMessages
    {
      get
      {
        return this.sourceMessages;
      }
      set
      {
        this.sourceMessages = value;
label_1:
        int num1 = 1360380217;
        while (true)
        {
          int num2 = 1502296877;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2619778282U));
              num1 = (int) num3 * -2036176720 ^ 1368181520;
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
        int num1 = -1889637371;
        TraceType traceType;
        while (true)
        {
          int num2 = -116085756;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -739754813 ^ -383939795;
              continue;
            case 2:
              num1 = (int) num3 * -1664540530 ^ -344644341;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public new event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;
label_1:
        int num1 = 293700990;
        while (true)
        {
          int num2 = 302582971;
          uint num3;
          PropertyChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              changedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, (PropertyChangedEventHandler) FloodChatOptions.\u202A‌⁯​‫‌⁬‫⁭‬⁭⁮⁪⁯⁪⁫‏⁪⁮‍‏‪‏⁬‪‫‭‏‪⁭⁪⁭‬⁭‏‏‌‎⁭⁭‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = changedEventHandler == comparand ? -1848343843 : (num4 = -1880034346);
              int num5 = (int) num3 * -710740261;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = changedEventHandler;
              num1 = 557599939;
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
      remove
      {
        PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;
label_1:
        int num1 = -1268040162;
        while (true)
        {
          int num2 = -1598765989;
          uint num3;
          PropertyChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = changedEventHandler;
              num1 = -2011650551;
              continue;
            case 2:
              changedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, (PropertyChangedEventHandler) FloodChatOptions.\u206C‎⁫‭⁭⁮⁪⁮‮⁬‫‎‍‫‍⁭‍‌‭‪‬​‫⁪⁬‫⁪‍​​‍​‫​⁬‬⁯‪‭⁬‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = changedEventHandler == comparand ? -584887628 : (num4 = -1594260842);
              int num5 = (int) num3 * 324984996;
              num1 = num4 ^ num5;
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

    public FloodChatOptions(string categoryName = "", string messageContent = "")
    {
label_1:
      int num1 = 1220599118;
      while (true)
      {
        int num2 = 1613280052;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            this.LoadMessageCategories(categoryName);
            this.LoadMessageContent(messageContent);
            num1 = (int) num3 * -1298658517 ^ 1007624013;
            continue;
          case 2:
            num1 = (int) num3 * 1195880882 ^ 2025139107;
            continue;
          case 3:
            this.EnforcedPattern = this.Engine.Settings.FloodEnforcedPattern;
            num1 = (int) num3 * 1693068709 ^ -1341572624;
            continue;
          case 4:
            num1 = (int) num3 * -194267876 ^ -745440163;
            continue;
          case 5:
            this.MessagesToSend = ZoomZoom.Properties.Settings.Default.FloodMessageCount;
            num1 = (int) num3 * -108075988 ^ -47996748;
            continue;
          case 6:
            this.BreakOnKeypress = ZoomZoom.Properties.Settings.Default.FloodBreakOnKeypress;
            num1 = (int) num3 * -1082927709 ^ 632838019;
            continue;
          case 7:
            num1 = (int) num3 * 453390797 ^ 1186305146;
            continue;
          case 8:
            this.ManualMessage = ZoomZoom.Properties.Settings.Default.FloodManualMessage;
            num1 = (int) num3 * 1335308039 ^ -841336902;
            continue;
          case 9:
            goto label_3;
          case 10:
            this.Randomize = ZoomZoom.Properties.Settings.Default.FloodRandomize;
            num1 = (int) num3 * -443777651 ^ -860635935;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    private void Sources_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      this.OnPropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3451671404U));
    }

    private void LoadMessageContent(string messageContent)
    {
label_1:
      int num1 = -1688414237;
      List<MessageContent> messageContents;
      while (true)
      {
        int num2 = -1327787646;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            this.sourceMessages = new ObservableCollection<MessageContent>();
            num1 = (int) num3 * -159325236 ^ 448844750;
            continue;
          case 1:
            if (this.sourceCategory == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -380454630 ^ -896041093;
            continue;
          case 2:
            goto label_1;
          case 3:
            num4 = !FloodChatOptions.\u202E‌‎‎⁪‫⁪⁪⁬‍‍‮⁪⁪⁮‫⁪‎⁭‎⁮‌⁯‌‎‍‮⁭‍⁭‫⁫‍‏​‭⁮⁬⁫⁮‮(this.sourceCategory.CategoryName, string.Empty) ? 1 : 0;
            break;
          case 4:
            messageContents = this.Engine.GetMessageContents(this.sourceCategory);
            num1 = (int) num3 * 1325844382 ^ 1226859949;
            continue;
          case 5:
            if (flag)
            {
              num1 = (int) num3 * -1119119544 ^ 1514760276;
              continue;
            }
            goto label_32;
          case 6:
            num1 = (int) num3 * -800176363 ^ -982769732;
            continue;
          default:
            goto label_13;
        }
        flag = num4 != 0;
        num1 = -98809097;
      }
label_32:
      return;
label_13:
      List<MessageContent>.Enumerator enumerator = messageContents.GetEnumerator();
      try
      {
label_23:
        int num2 = enumerator.MoveNext() ? -1657486983 : (num2 = -872288928);
        while (true)
        {
          int num3 = -1327787646;
          uint num4;
          MessageContent current;
          bool flag;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 11U)
          {
            case 0:
              goto label_23;
            case 2:
              num2 = (int) num4 * -974359176 ^ 448052428;
              continue;
            case 3:
              num2 = -1657486983;
              continue;
            case 4:
              int num6 = !flag ? -298526724 : (num6 = -647659183);
              int num7 = (int) num4 * 413857376;
              num2 = num6 ^ num7;
              continue;
            case 5:
              if (!FloodChatOptions.\u202E‌‎‎⁪‫⁪⁪⁬‍‍‮⁪⁪⁮‫⁪‎⁭‎⁮‌⁯‌‎‍‮⁭‍⁭‫⁫‍‏​‭⁮⁬⁫⁮‮(messageContent, string.Empty))
              {
                num2 = (int) num4 * -430363644 ^ -23837452;
                continue;
              }
              num5 = 0;
              break;
            case 6:
              num5 = FloodChatOptions.\u202E‌‎‎⁪‫⁪⁪⁬‍‍‮⁪⁪⁮‫⁪‎⁭‎⁮‌⁯‌‎‍‮⁭‍⁭‫⁫‍‏​‭⁮⁬⁫⁮‮(current.ContentText, messageContent) ? 1 : 0;
              break;
            case 7:
              current = enumerator.Current;
              num2 = -1894277038;
              continue;
            case 8:
              num2 = -810552002;
              continue;
            case 9:
              ((Collection<MessageContent>) this.sourceMessages).Add(current);
              num2 = (int) num4 * -486634162 ^ 1521492008;
              continue;
            case 10:
              this.sourceMessage = current;
              num2 = (int) num4 * 739597562 ^ -1985036768;
              continue;
            default:
              goto label_35;
          }
          flag = num5 != 0;
          num2 = -1511849528;
        }
      }
      finally
      {
        enumerator.Dispose();
label_30:
        int num2 = -1519384104;
        while (true)
        {
          int num3 = -1327787646;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_30;
            case 2:
              num2 = (int) num4 * 1389595659 ^ -1681371973;
              continue;
            default:
              goto label_34;
          }
        }
label_34:;
      }
label_35:;
    }

    private void LoadMessageCategories(string categoryName)
    {
      this.sourceCategories = new ObservableCollection<MessageCategory>();
      IEnumerator<MessageCategory> enumerator = ((Collection<MessageCategory>) this.Engine.MessageCategories).GetEnumerator();
      try
      {
label_8:
        int num1 = !FloodChatOptions.\u206D‬‮‬⁭‍‌⁭⁯⁮⁬‏‫⁭⁭‍⁭⁯⁯‍⁬​‪⁫⁫‫‬‏‬⁭‭‭⁯⁪⁯⁫⁮⁪⁯‮‮((IEnumerator) enumerator) ? -1224123086 : (num1 = -351271832);
        while (true)
        {
          int num2 = -2145947534;
          uint num3;
          MessageCategory current;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              this.sourceCategory = current;
              num1 = (int) num3 * -1812873887 ^ 513737275;
              continue;
            case 1:
              num1 = -905895980;
              continue;
            case 2:
              ((Collection<MessageCategory>) this.sourceCategories).Add(current);
              if (FloodChatOptions.\u202E‌‎‎⁪‫⁪⁪⁬‍‍‮⁪⁪⁮‫⁪‎⁭‎⁮‌⁯‌‎‍‮⁭‍⁭‫⁫‍‏​‭⁮⁬⁫⁮‮(categoryName, string.Empty))
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 629371700 ^ -255715833;
              continue;
            case 3:
              int num5 = !flag ? 1709850169 : (num5 = 895699682);
              int num6 = (int) num3 * 1643231252;
              num1 = num5 ^ num6;
              continue;
            case 5:
              num4 = FloodChatOptions.\u202E‌‎‎⁪‫⁪⁪⁬‍‍‮⁪⁪⁮‫⁪‎⁭‎⁮‌⁯‌‎‍‮⁭‍⁭‫⁫‍‏​‭⁮⁬⁫⁮‮(current.CategoryName, categoryName) ? 1 : 0;
              break;
            case 6:
              current = enumerator.Current;
              num1 = -1300456012;
              continue;
            case 7:
              num1 = (int) num3 * 578025981 ^ 37165076;
              continue;
            case 8:
              goto label_8;
            case 9:
              num1 = -351271832;
              continue;
            default:
              goto label_22;
          }
          flag = num4 != 0;
          num1 = -1454040361;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_16:
          int num1 = -1986018225;
          while (true)
          {
            int num2 = -2145947534;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * 1640993727 ^ -938049111;
                continue;
              case 1:
                FloodChatOptions.\u202D⁭⁫‌‎‪‭‏⁫⁭‬‫‍⁬‌⁫⁯⁫⁪‮⁮⁬​‏‎‪⁫​​‮⁭⁬⁬‪‍⁫⁫‌‏⁯‮((IDisposable) enumerator);
                num1 = (int) num3 * -388209762 ^ 1459680032;
                continue;
              case 2:
                goto label_16;
              default:
                goto label_21;
            }
          }
        }
label_21:;
      }
label_22:
      if (this.sourceCategory != null)
        goto label_29;
label_23:
      int num7 = -1408518053;
label_24:
      bool flag1;
      while (true)
      {
        int num1 = -2145947534;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 6U)
        {
          case 0:
            goto label_23;
          case 1:
            goto label_28;
          case 2:
            int num3 = !flag1 ? 1950118939 : (num3 = 158566047);
            int num4 = (int) num2 * -1648875590;
            num7 = num3 ^ num4;
            continue;
          case 3:
            goto label_25;
          case 4:
            this.sourceCategory = this.Engine.GetMessageCategory(ZoomZoom.Properties.Settings.Default.FloodSource, false);
            num7 = (int) num2 * -292301574 ^ 1651759263;
            continue;
          case 5:
            num7 = (int) num2 * 1782919600 ^ -786544404;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return;
label_25:
      return;
label_28:
      int num8 = !FloodChatOptions.\u202E‌‎‎⁪‫⁪⁪⁬‍‍‮⁪⁪⁮‫⁪‎⁭‎⁮‌⁯‌‎‍‮⁭‍⁭‫⁫‍‏​‭⁮⁬⁫⁮‮(ZoomZoom.Properties.Settings.Default.FloodSource, string.Empty) ? 1 : 0;
      goto label_30;
label_29:
      num8 = 0;
label_30:
      flag1 = num8 != 0;
      num7 = -2068946058;
      goto label_24;
    }

    protected void OnPropertyChanged(string name)
    {
      // ISSUE: reference to a compiler-generated field
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
label_1:
      int num1 = -1578169622;
      while (true)
      {
        int num2 = -974653089;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            int num4 = propertyChanged != null ? -1837746165 : (num4 = -2005572375);
            int num5 = (int) num3 * 1814344470;
            num1 = num4 ^ num5;
            continue;
          case 2:
            propertyChanged((object) this, FloodChatOptions.\u202A⁬‮‪‮‍⁫⁫⁯‫⁮‫‮⁪⁮‌‬‬⁬⁯‫​⁬​‌‏‪​‬​‭​⁫‬‫⁫⁯⁪‎‎‮(name));
            num1 = (int) num3 * -2100019274 ^ -468413797;
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

    static void \u202B‬‪⁭‌‍⁫‫⁬‌⁪​⁯‪⁮⁮‫‌‎⁬‌‫‪‏⁯⁬⁪‫‬‪⁫‎‮‌‍‌​⁪⁬⁫‮([In] SettingsBase obj0)
    {
      obj0.Save();
    }

    static bool \u202E‌‎‎⁪‫⁪⁪⁬‍‍‮⁪⁪⁮‫⁪‎⁭‎⁮‌⁯‌‎‍‮⁭‍⁭‫⁫‍‏​‭⁮⁬⁫⁮‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u206D‬‮‬⁭‍‌⁭⁯⁮⁬‏‫⁭⁭‍⁭⁯⁯‍⁬​‪⁫⁫‫‬‏‬⁭‭‭⁯⁪⁯⁫⁮⁪⁯‮‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u202D⁭⁫‌‎‪‭‏⁫⁭‬‫‍⁬‌⁫⁯⁫⁪‮⁮⁬​‏‎‪⁫​​‮⁭⁬⁬‪‍⁫⁫‌‏⁯‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Delegate \u202A‌⁯​‫‌⁬‫⁭‬⁭⁮⁪⁯⁪⁫‏⁪⁮‍‏‪‏⁬‪‫‭‏‪⁭⁪⁭‬⁭‏‏‌‎⁭⁭‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u206C‎⁫‭⁭⁮⁪⁮‮⁬‫‎‍‫‍⁭‍‌‭‪‬​‫⁪⁬‫⁪‍​​‍​‫​⁬‬⁯‪‭⁬‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static PropertyChangedEventArgs \u202A⁬‮‪‮‍⁫⁫⁯‫⁮‫‮⁪⁮‌‬‬⁬⁯‫​⁬​‌‏‪​‬​‭​⁫‬‫⁫⁯⁪‎‎‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }

    static MethodBase \u206B⁮‏⁪‪‫⁪​⁪⁯⁮‌‮‮​‏‏⁭‪‪‌⁬⁮⁭⁯⁮⁬‍‬⁭‏⁪‪‪‪⁫‫‏⁯‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200F‭⁮‎‭‭⁪‪‎‎​‭‬⁮​⁪⁭‏⁮‫⁬⁪⁬⁮​⁪‪‫‮‌⁯‭⁭​‬⁬‮⁭‎‍‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206E‏‪⁬‬⁮​‏‍‌⁬‌⁪⁬‮‌‎⁭⁬‌​‍⁬​‭⁫‍⁭⁬⁬‍⁭‏⁭​⁮‍⁪‭‭‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
