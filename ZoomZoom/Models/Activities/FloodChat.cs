// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.FloodChat
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ZoomZoom.Models.Chats;

namespace ZoomZoom.Models.Activities
{
  public class FloodChat : ActivityBase
  {
    private bool randomMessage = false;
    private bool breakOnKeypress = true;
    private bool floodAllPrivately = false;
    private string manualMessage = string.Empty;
    private ChatOptions chatOptions = new ChatOptions();
    private ZoomWindow chatWindow = (ZoomWindow) null;
    private bool escapePressedDown = false;
    private ZoomWindow meetingWindow = (ZoomWindow) null;
    private int chatCount = 0;
    private int messagesToSend = 0;
    private bool floodHost = false;
    private bool floodCoHost = false;
    private string targetUser;

    public new ZoomWindow MeetingWindow
    {
      get
      {
        ZoomWindow meetingWindow = this.meetingWindow;
label_1:
        int num1 = -83298257;
        while (true)
        {
          int num2 = -1914197559;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 28273008 ^ -2103049875;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingWindow;
      }
      set
      {
label_1:
        int num1 = 1093836741;
        while (true)
        {
          int num2 = 958381091;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.meetingWindow = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2845809230U));
              num1 = (int) num3 * -1916867444 ^ -894754365;
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

    public ChatOptions ChatOptions
    {
      get
      {
        ChatOptions chatOptions = this.chatOptions;
label_1:
        int num1 = -164170979;
        while (true)
        {
          int num2 = -1374016575;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1073492112 ^ 196824345;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chatOptions;
      }
      set
      {
label_1:
        int num1 = 1070753126;
        while (true)
        {
          int num2 = 2038082709;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.chatOptions = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2523138334U));
              num1 = (int) num3 * 443093774 ^ -804959673;
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

    public ZoomWindow ChatWindow
    {
      get
      {
        ZoomWindow chatWindow = this.chatWindow;
label_1:
        int num1 = -1489449043;
        while (true)
        {
          int num2 = -942053326;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -2066686766 ^ 160402908;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chatWindow;
      }
      set
      {
        this.chatWindow = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2958385227U));
label_1:
        int num1 = 1932598743;
        while (true)
        {
          int num2 = 821154884;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 961263253 ^ 444298857;
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

    public int ChatCount
    {
      get
      {
label_1:
        int num1 = 2100206255;
        int chatCount;
        while (true)
        {
          int num2 = 1755167332;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1007935003 ^ 1778799347;
              continue;
            case 3:
              chatCount = this.chatCount;
              num1 = (int) num3 * 13543961 ^ 1705746386;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return chatCount;
      }
      private set
      {
label_1:
        int num1 = 427692254;
        while (true)
        {
          int num2 = 100329592;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.chatCount = value;
              num1 = (int) num3 * -1483498228 ^ -780783769;
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
        int messagesToSend = this.messagesToSend;
label_1:
        int num1 = 1832406849;
        while (true)
        {
          int num2 = 713376010;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 67352270 ^ 1603318563;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return messagesToSend;
      }
      set
      {
        this.messagesToSend = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(329093669U));
      }
    }

    public bool BreakOnKeypress
    {
      get
      {
label_1:
        int num1 = 1285509949;
        bool breakOnKeypress;
        while (true)
        {
          int num2 = 844924966;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1478032425 ^ -635030285;
              continue;
            case 2:
              goto label_1;
            case 3:
              breakOnKeypress = this.breakOnKeypress;
              num1 = (int) num3 * 347626714 ^ -1998976576;
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
        int num1 = -1317157650;
        while (true)
        {
          int num2 = -817717822;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1689091252U));
              num1 = (int) num3 * -733460256 ^ 1318258090;
              continue;
            case 2:
              this.breakOnKeypress = value;
              num1 = (int) num3 * -2004751383 ^ -504034609;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * -1864076421 ^ -1808243179;
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

    public bool EscapePressedDown
    {
      get
      {
label_1:
        int num1 = 1208361060;
        bool escapePressedDown;
        while (true)
        {
          int num2 = 754278536;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              escapePressedDown = this.escapePressedDown;
              num1 = (int) num3 * 696245027 ^ -1980479768;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return escapePressedDown;
      }
      set
      {
label_1:
        int num1 = -638910954;
        while (true)
        {
          int num2 = -38793542;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.escapePressedDown = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4183637713U));
              num1 = (int) num3 * 976654031 ^ 749278617;
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

    public bool FloodHost
    {
      get
      {
label_1:
        int num1 = -1885114848;
        bool floodHost;
        while (true)
        {
          int num2 = -287268470;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              floodHost = this.floodHost;
              num1 = (int) num3 * -751065476 ^ -938080637;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return floodHost;
      }
      set
      {
        if (this.floodHost != value)
          goto label_5;
label_1:
        int num1 = -1509367298;
label_2:
        while (true)
        {
          int num2 = -1587428960;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 286628245 ^ -1855117330;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -513280006 ^ -756802644;
              continue;
            case 4:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        this.floodHost = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3700460516U));
        num1 = -71380362;
        goto label_2;
      }
    }

    public bool FloodCoHost
    {
      get
      {
        return this.floodCoHost;
      }
      set
      {
        if (this.floodCoHost != value)
          goto label_5;
label_1:
        int num1 = -770122766;
label_2:
        while (true)
        {
          int num2 = -380321473;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_5;
            case 1:
              num1 = (int) num3 * 1597164628 ^ -385933615;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2563335267U));
              num1 = (int) num3 * 2095514131 ^ 728008123;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        this.floodCoHost = value;
        num1 = -605165083;
        goto label_2;
      }
    }

    public bool FloodAllPrivately
    {
      get
      {
        return this.floodAllPrivately;
      }
      set
      {
        this.floodAllPrivately = value;
label_1:
        int num1 = -257513622;
        while (true)
        {
          int num2 = -1141959517;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1500883119U));
              num1 = (int) num3 * 132889556 ^ 1158068136;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 2064219503 ^ 1332187008;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 871158525;
        TraceType traceType;
        while (true)
        {
          int num2 = 852407050;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * 620817491 ^ -1229481622;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public bool RandomMessage
    {
      get
      {
label_1:
        int num1 = 885524048;
        bool randomMessage;
        while (true)
        {
          int num2 = 1253642287;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              randomMessage = this.randomMessage;
              num1 = (int) num3 * 642870770 ^ -1267741389;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return randomMessage;
      }
      set
      {
        this.randomMessage = value;
label_1:
        int num1 = 83573910;
        while (true)
        {
          int num2 = 594096638;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.ChatOptions.RandomMessage = true;
              num1 = (int) num3 * 526039128 ^ -1231366505;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3543811712U));
              num1 = (int) num3 * -696576273 ^ -2016935831;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -573852182 ^ -397123410;
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

    public string TargetUser
    {
      get
      {
label_1:
        int num1 = 1962432600;
        string targetUser;
        while (true)
        {
          int num2 = 1551991247;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -160279423 ^ -730584352;
              continue;
            case 3:
              targetUser = this.targetUser;
              num1 = (int) num3 * 813086203 ^ 21594348;
              continue;
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
      }
    }

    public FloodChat(string messageContent, int chatCountMax, string targetUser = "")
    {
label_1:
      int num1 = 839442406;
      while (true)
      {
        int num2 = 1344144231;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 514890195 ^ 1374200386;
            continue;
          case 1:
            num1 = (int) num3 * -41968264 ^ -439521875;
            continue;
          case 2:
            this.RequiresAuthorization = true;
            num1 = (int) num3 * -877595775 ^ -1815860538;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -1117010444 ^ 1316771774;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.TargetUser = targetUser;
            num1 = (int) num3 * -614594119 ^ -449997921;
            continue;
          case 7:
            this.MessagesToSend = chatCountMax;
            num1 = (int) num3 * 443275729 ^ -1593123571;
            continue;
          case 8:
            this.ChatOptions = new ChatOptions(messageContent);
            num1 = (int) num3 * 782512807 ^ 434945774;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    public FloodChat()
    {
      this.ChatOptions = new ChatOptions();
      this.RequiresAuthorization = true;
    }

    protected override void ExecuteLogic()
    {
      this.meetingWindow = this.Engine.ActiveMeetingWindow;
      try
      {
        if (!this.BreakOnKeypress)
          goto label_53;
label_2:
        int num1 = -705750972;
label_3:
        while (true)
        {
          int num2 = -1006046844;
          uint num3;
          FindUser findUser;
          ZoomWindow window;
          System.Drawing.Point location;
          bool floodHost;
          string message;
          ZoomWindow windowViaButton;
          bool flag;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 57U)
          {
            case 0:
              num1 = (int) num3 * 1762997548 ^ -1615282089;
              continue;
            case 1:
              windowViaButton.Activate();
              windowViaButton.Click(new System.Drawing.Point(windowViaButton.Size.Width - 40, windowViaButton.Size.Height - 40), true, true, 0);
              num1 = (int) num3 * 1052555196 ^ -951927669;
              continue;
            case 2:
              num1 = (int) num3 * -1970476970 ^ 22581660;
              continue;
            case 3:
              num1 = -1999999757;
              continue;
            case 4:
              SendKeys.SendWait(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4279420196U));
              num1 = (int) num3 * 85421914 ^ 1349265960;
              continue;
            case 5:
              num1 = (int) num3 * 1685684077 ^ -608283943;
              continue;
            case 6:
              num4 = this.FloodAllPrivately ? 1 : 0;
              goto label_47;
            case 7:
              num1 = -1884558780;
              continue;
            case 8:
              int num6 = !flag ? 2002083839 : (num6 = 682143923);
              int num7 = (int) num3 * -1446405272;
              num1 = num6 ^ num7;
              continue;
            case 9:
              int num8 = FloodChat.\u202E‪‪‌‎⁮‭​⁭‍⁪⁬‏‌‌⁪​⁫‭‪‮‏‬⁭‮‌‏‌‮‭⁭‬‎‎⁭‭‪⁮‬⁪‮(this.TargetUser) ? -333366098 : (num8 = -1351951689);
              int num9 = (int) num3 * -1374076490;
              num1 = num8 ^ num9;
              continue;
            case 10:
              KeyboardHookManager.KeyDown += new KeyEventHandler(this.KeyboardHookManager_KeyDown);
              num1 = (int) num3 * 2090171421 ^ -1385678552;
              continue;
            case 11:
              goto label_65;
            case 12:
              message = this.ChatOptions.GetMessage();
              num1 = -1573224070;
              continue;
            case 13:
              num1 = (int) num3 * 323609006 ^ -256433553;
              continue;
            case 14:
              num1 = (int) num3 * 46938011 ^ 780744770;
              continue;
            case 15:
              this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1246559758U));
              num1 = (int) num3 * -1394469801 ^ 1497954522;
              continue;
            case 16:
              int num10 = !floodHost ? 1366882721 : (num10 = 2031585831);
              int num11 = (int) num3 * 116793359;
              num1 = num10 ^ num11;
              continue;
            case 17:
              int X = location.X + 30;
              location = window.Location;
              int Y = location.Y + 130;
              ZoomZoom.NativeMethods.SetCursorPos(X, Y);
              num1 = (int) num3 * 1810384221 ^ 251794518;
              continue;
            case 18:
              Thread.Sleep(40);
              num1 = (int) num3 * 2059234592 ^ -317874355;
              continue;
            case 20:
              num1 = (int) num3 * -1991944967 ^ 1184533411;
              continue;
            case 21:
              num1 = -370130358;
              continue;
            case 22:
              goto label_2;
            case 23:
              window.Click(new System.Drawing.Point(30, 130), true, true, 0);
              num1 = (int) num3 * -801583429 ^ 386743031;
              continue;
            case 24:
              num1 = (int) num3 * -1841158783 ^ 1961408065;
              continue;
            case 25:
              num1 = -161209225;
              continue;
            case 26:
              if (this.ChatOptions == null)
              {
                num4 = 0;
                goto label_47;
              }
              else
              {
                num1 = (int) num3 * -733076714 ^ -1691341274;
                continue;
              }
            case 27:
              findUser = new FindUser(this.TargetUser, true);
              if (this.ExecuteSubActivity((ActivityBase) findUser, true) == ActivityState.Completed)
              {
                num1 = (int) num3 * 1687112979 ^ -657748747;
                continue;
              }
              num5 = 0;
              break;
            case 28:
              num1 = (int) num3 * 574208666 ^ 544765708;
              continue;
            case 29:
              int num12 = this.ContinueFlood() ? -309178105 : (num12 = -1531503716);
              int num13 = (int) num3 * -1818985013;
              num1 = num12 ^ num13;
              continue;
            case 30:
              goto label_53;
            case 31:
              this.ChatOptions.UserName = this.TargetUser;
              num1 = (int) num3 * 1480902357 ^ 1423854601;
              continue;
            case 32:
              num5 = findUser.UserFound ? 1 : 0;
              break;
            case 33:
              floodHost = this.FloodHost;
              num1 = -373190134;
              continue;
            case 34:
              windowViaButton.Activate();
              num1 = (int) num3 * 704300640 ^ -1470954562;
              continue;
            case 35:
              SendKeys.SendWait(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1740965029U));
              num1 = (int) num3 * -845414073 ^ -1246760473;
              continue;
            case 36:
              location = window.Location;
              num1 = (int) num3 * -370090877 ^ -1873508695;
              continue;
            case 37:
              int num14 = window == null ? -1208959875 : (num14 = -1230358010);
              int num15 = (int) num3 * 495546973;
              num1 = num14 ^ num15;
              continue;
            case 38:
              num1 = (int) num3 * -1328860391 ^ 1528448536;
              continue;
            case 39:
              this.ExecuteFloodUserLogic();
              num1 = (int) num3 * -826918163 ^ 1893865755;
              continue;
            case 40:
              num1 = (int) num3 * 221336066 ^ 1015592646;
              continue;
            case 41:
              System.Windows.Clipboard.SetText(message);
              num1 = (int) num3 * 1453510861 ^ 991203488;
              continue;
            case 42:
              num1 = -986303099;
              continue;
            case 43:
              goto label_40;
            case 44:
              window.Click(new System.Drawing.Point(30, 130), true, true, 0);
              num1 = (int) num3 * -395441782 ^ -1413354311;
              continue;
            case 45:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2065253303U));
              num1 = (int) num3 * 899197590 ^ 1386551133;
              continue;
            case 46:
              int num16 = windowViaButton == null ? 1126062413 : (num16 = 106039270);
              int num17 = (int) num3 * -606630644;
              num1 = num16 ^ num17;
              continue;
            case 47:
              KeyboardHookManager.KeyUp += new KeyEventHandler(this.KeyboardHookManager_KeyUp);
              num1 = (int) num3 * -1644525778 ^ 1011823091;
              continue;
            case 48:
              Thread.Sleep(25);
              num1 = (int) num3 * 474446994 ^ 476254703;
              continue;
            case 49:
              num1 = -1999999757;
              continue;
            case 50:
              num1 = (int) num3 * 2093452900 ^ 2133246482;
              continue;
            case 51:
              windowViaButton = this.Engine.GetWindowViaButton(ZoomWindowType.Chat);
              num1 = -316594542;
              continue;
            case 52:
              num1 = (int) num3 * -1281727845 ^ -122339940;
              continue;
            case 53:
              window = this.Engine.GetWindow(ZoomWindowType.Participants);
              num1 = (int) num3 * 881108337 ^ 1941028438;
              continue;
            case 54:
              num1 = (int) num3 * -2013081639 ^ -1761036737;
              continue;
            case 55:
              flag = windowViaButton == null;
              num1 = (int) num3 * 1702067179 ^ -1742860110;
              continue;
            case 56:
              Thread.Sleep(25);
              num1 = (int) num3 * -2081487343 ^ 143301683;
              continue;
            default:
              goto label_67;
          }
          int num18;
          num1 = num18 = num5 == 0 ? -110735382 : (num18 = -969032371);
          continue;
label_47:
          int num19;
          num1 = num19 = num4 == 0 ? -602297987 : (num19 = -1365511255);
        }
label_40:
        return;
label_65:
        return;
label_53:
        this.ReportProgress(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3117140693U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2468418288U));
        num1 = -1542982424;
        goto label_3;
      }
      catch (Exception ex)
      {
        this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2506275585U) + ex.Message);
      }
label_67:
      bool breakOnKeypress = this.BreakOnKeypress;
label_68:
      int num20 = -206770965;
      while (true)
      {
        int num1 = -1006046844;
        uint num2;
        switch ((num2 = (uint) (num20 ^ num1)) % 8U)
        {
          case 0:
            KeyboardHookManager.KeyUp -= new KeyEventHandler(this.KeyboardHookManager_KeyUp);
            num20 = (int) num2 * 895405010 ^ -411083185;
            continue;
          case 1:
            num20 = (int) num2 * -1685555248 ^ 1706942332;
            continue;
          case 2:
            num20 = (int) num2 * -486527432 ^ -1186332168;
            continue;
          case 3:
            num20 = (int) num2 * -1527431778 ^ 1040025072;
            continue;
          case 4:
            KeyboardHookManager.KeyDown -= new KeyEventHandler(this.KeyboardHookManager_KeyDown);
            num20 = (int) num2 * -11230764 ^ 1804212893;
            continue;
          case 5:
            goto label_68;
          case 6:
            goto label_70;
          case 7:
            int num3 = breakOnKeypress ? 1441303165 : (num3 = 393990377);
            int num4 = (int) num2 * -790898435;
            num20 = num3 ^ num4;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return;
label_70:;
    }

    private void ExecuteFloodUserLogic()
    {
      if (this.ChatWindow != null)
        goto label_39;
label_1:
      int num1 = -358613655;
label_2:
      ZoomWindow zoomWindow1;
      bool flag1;
      while (true)
      {
        int num2 = -23369191;
        uint num3;
        int num4;
        string message;
        int num5;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        string text;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 46U)
        {
          case 0:
            num1 = (int) num3 * -2082252518 ^ -2069253336;
            continue;
          case 1:
            this.MinimizeWindows(this.ChatWindow);
            num1 = (int) num3 * -1520955139 ^ -1502246616;
            continue;
          case 2:
            zoomWindow1.Activate();
            zoomWindow1.Click(new System.Drawing.Point(zoomWindow1.Size.Width - 40, zoomWindow1.Size.Height - 40), true, true, 0);
            num1 = (int) num3 * 1465286467 ^ -233967269;
            continue;
          case 3:
            int num7 = flag1 ? -1728409344 : (num7 = -1897499086);
            int num8 = (int) num3 * -896363559;
            num1 = num7 ^ num8;
            continue;
          case 4:
            num1 = (int) num3 * 2001247711 ^ -1643399355;
            continue;
          case 5:
            num6 = num5 == 0 ? 1 : 0;
            break;
          case 6:
            num1 = (int) num3 * -776836770 ^ -1733976796;
            continue;
          case 7:
            int num9 = !flag3 ? 1961026173 : (num9 = 330489673);
            int num10 = (int) num3 * 1742668895;
            num1 = num9 ^ num10;
            continue;
          case 8:
            flag4 = zoomWindow1 != null;
            num1 = -1701241517;
            continue;
          case 9:
            CoreObject.log.Debug((object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1899443859U));
            num1 = (int) num3 * -1391566469 ^ 1665130487;
            continue;
          case 10:
            ++num5;
            num1 = (int) num3 * 1556081550 ^ -950652493;
            continue;
          case 11:
            num1 = (int) num3 * 1499368700 ^ 912362790;
            continue;
          case 12:
            Thread.Sleep(25);
            num1 = (int) num3 * -2038850863 ^ -1120879152;
            continue;
          case 13:
            SendKeys.SendWait(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1399620133U));
            num1 = -46835817;
            continue;
          case 14:
            goto label_38;
          case 15:
            Thread.Sleep(25);
            num1 = (int) num3 * -858807110 ^ -278426906;
            continue;
          case 16:
            zoomWindow1 = this.Engine.GetWindowViaButton(ZoomWindowType.Chat);
            num1 = (int) num3 * 636239897 ^ 225017275;
            continue;
          case 17:
            SendKeys.SendWait(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1012711769U));
            Thread.Sleep(25);
            num1 = (int) num3 * -1605902320 ^ -295003711;
            continue;
          case 18:
            flag5 = this.ContinueFlood();
            num1 = (int) num3 * 637166804 ^ -457940183;
            continue;
          case 19:
            num1 = (int) num3 * -190012000 ^ -1058100987;
            continue;
          case 20:
            CoreObject.log.Debug((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2544160810U));
            num1 = (int) num3 * -669237694 ^ 968150194;
            continue;
          case 21:
            num1 = (int) num3 * -1492106970 ^ 423349815;
            continue;
          case 22:
            int num11 = flag5 ? -652649097 : (num11 = -16400873);
            int num12 = (int) num3 * 663442770;
            num1 = num11 ^ num12;
            continue;
          case 23:
            text = FloodChat.\u200E​‫‫⁮⁪⁯‍‌​‌⁬‍‪‍‮‌‎⁯⁮‫‎‍‭⁪⁪‍⁮‮‪‎⁪⁭⁫⁪⁭‭⁯‎‬‮();
            num5 = 0;
            num1 = (int) num3 * -800338290 ^ 770434491;
            continue;
          case 24:
            int num13 = flag2 ? -2020087394 : (num13 = -335047672);
            int num14 = (int) num3 * -1885394832;
            num1 = num13 ^ num14;
            continue;
          case 25:
            num1 = (int) num3 * 2135120939 ^ -2036185238;
            continue;
          case 26:
            num1 = (int) num3 * -766201474 ^ 375846752;
            continue;
          case 27:
            FloodChat.\u206C⁮⁫​‌‍⁮⁬‪‮⁫‍‮‭‌‫⁭‮⁫‪‎‪‏⁭‌⁭‫‌‫⁬‮‎⁮⁮‫‪⁭⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2762989977U));
            num1 = (int) num3 * -44358719 ^ -242489587;
            continue;
          case 28:
            Thread.Sleep(25);
            SendKeys.SendWait(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3712219545U));
            num1 = (int) num3 * 952965050 ^ -808740995;
            continue;
          case 29:
            if (num5 >= this.Engine.ActiveMeeting.UserCountCurrent - 1)
            {
              num6 = 1;
              break;
            }
            num1 = (int) num3 * 104442157 ^ -272837645;
            continue;
          case 30:
            System.Windows.Clipboard.SetText(text);
            num1 = (int) num3 * 960996808 ^ -383822507;
            continue;
          case 31:
            flag3 = num4 < num5 - 1;
            num1 = -2129171020;
            continue;
          case 32:
            message = this.ChatOptions.GetMessage();
            num1 = (int) num3 * -1873251597 ^ 626858415;
            continue;
          case 33:
            num4 = 0;
            num1 = (int) num3 * -1838961192 ^ 1011896852;
            continue;
          case 34:
            SendKeys.SendWait(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(992236397U));
            num1 = (int) num3 * 278710899 ^ -1480257574;
            continue;
          case 35:
            num5 = 1;
            SendKeys.SendWait(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2064329104U));
            SendKeys.SendWait(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3126650640U));
            num1 = (int) num3 * 1507349916 ^ 1057058054;
            continue;
          case 36:
            FloodChat.\u200D⁭⁯⁭‫⁪⁬⁮⁪‪⁫‏⁫⁬‏⁯‌⁭‮‌‬‌‬⁭⁫‬⁮‪⁪⁬⁭‬‌‍‮​‫‌‌‏‮(message);
            num1 = (int) num3 * 583504955 ^ -323459812;
            continue;
          case 37:
            goto label_1;
          case 38:
            num1 = -1842277973;
            continue;
          case 39:
            SendKeys.SendWait(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(375947143U));
            num1 = (int) num3 * -1463508333 ^ -163362288;
            continue;
          case 40:
            num1 = (int) num3 * -1135417319 ^ -965909780;
            continue;
          case 41:
            goto label_3;
          case 42:
            num1 = (int) num3 * -1376865857 ^ 994375996;
            continue;
          case 43:
            ++num4;
            num1 = (int) num3 * -1431492990 ^ 622681994;
            continue;
          case 44:
            int num15 = flag4 ? 121203489 : (num15 = 686459556);
            int num16 = (int) num3 * 250625790;
            num1 = num15 ^ num16;
            continue;
          case 45:
            SendKeys.SendWait(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(649987832U));
            SendKeys.SendWait(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1399620133U));
            num1 = -1042524870;
            continue;
          default:
            goto label_53;
        }
        flag2 = num6 != 0;
        num1 = -1301858411;
      }
label_53:
      return;
label_3:
      return;
label_38:
      ZoomWindow zoomWindow2 = this.Engine.WindowManager.OpenChatWindow();
      goto label_40;
label_39:
      zoomWindow2 = this.ChatWindow;
label_40:
      zoomWindow1 = zoomWindow2;
      flag1 = zoomWindow1 == null;
      num1 = -1395551998;
      goto label_2;
    }

    private void ProcessChatActivityState(SendChat chat, ActivityState chatState)
    {
      if (chatState != ActivityState.Error)
        goto label_3;
label_1:
      int num1 = -796993173;
label_2:
      while (true)
      {
        int num2 = -1151425094;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 44534214 ^ 274883046;
            continue;
          case 1:
            num1 = (int) num3 * 1216205182 ^ 407306636;
            continue;
          case 2:
            this.SetActivityState(ActivityState.Error, chat.Status);
            num1 = (int) num3 * -692784154 ^ -1750101906;
            continue;
          case 4:
            goto label_24;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * -1765600638 ^ -1051675099;
            continue;
          case 7:
            num1 = (int) num3 * -1511951265 ^ 2066999512;
            continue;
          case 8:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_24:
      return;
label_10:
      object activityLocker = ActivityBase.activityLocker;
      bool flag1 = false;
      try
      {
        FloodChat.\u202A‪‌⁬⁯⁪‬⁪‭‮‭⁫‎⁪⁮⁬‭‬‎⁬‬⁪‪‌‬⁭‪‫⁯⁭⁬⁭⁬‌‏‭‮⁬⁭⁬‮(activityLocker, ref flag1);
label_12:
        int num2 = -1081239772;
        while (true)
        {
          int num3 = -1151425094;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 1:
              this.Status = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2347524516U);
              num2 = (int) num4 * -344350348 ^ -1097150051;
              continue;
            case 2:
              num2 = (int) num4 * 166796009 ^ -2055392536;
              continue;
            case 3:
              num2 = (int) num4 * 1050287913 ^ 697326611;
              continue;
            case 4:
              num2 = (int) num4 * -469799624 ^ -1856187739;
              continue;
            case 5:
              goto label_12;
            case 6:
              num2 = (int) num4 * -1687028153 ^ 1137490692;
              continue;
            case 7:
              this.chatCount = this.chatCount + 1;
              this.ActivityState = ActivityState.InProgress;
              num2 = (int) num4 * 1101206089 ^ 239368628;
              continue;
            default:
              goto label_28;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_22:
          int num2 = -845833015;
          while (true)
          {
            int num3 = -1151425094;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_22;
              case 2:
                num2 = (int) num4 * -1392503338 ^ 255938043;
                continue;
              case 3:
                FloodChat.\u200D‏⁪‌⁮⁯‬⁮⁪⁬⁫⁬​⁮‍‫‍⁯⁬‍⁮‏​‍‮​⁬‫⁫⁮⁭⁭‏⁭⁭‪⁯⁪‌⁪‮(activityLocker);
                num2 = (int) num4 * -818338836 ^ -615192508;
                continue;
              default:
                goto label_27;
            }
          }
        }
label_27:;
      }
label_28:
      goto label_29;
label_3:
      if (chatState == ActivityState.Completed)
      {
        num1 = -1746105314;
        goto label_2;
      }
      else
        goto label_33;
label_29:
      int num5 = -844614950;
label_30:
      bool flag2;
      while (true)
      {
        int num2 = -1151425094;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 10U)
        {
          case 0:
            goto label_33;
          case 1:
            num5 = (int) num3 * 674519693 ^ 1108234219;
            continue;
          case 2:
            this.SetActivityState(ActivityState.Error, FloodChat.\u202E⁯‪⁭‫‍⁪‮⁭‭​‎‌⁪‪⁫⁭​‍‏‫‬⁯‏‪‎⁫⁪⁯‭‪⁬⁯⁯⁬‭‫⁮⁬‌‮((object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2787763004U), (object) chatState));
            num5 = -953812814;
            continue;
          case 3:
            num5 = (int) num3 * -995921801 ^ 1674747738;
            continue;
          case 4:
            int num4 = flag2 ? -1487607189 : (num4 = -641959730);
            int num6 = (int) num3 * -1507746866;
            num5 = num4 ^ num6;
            continue;
          case 5:
            this.SetActivityState(ActivityState.Canceled, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3873578752U));
            num5 = (int) num3 * -1079745716 ^ -1413972403;
            continue;
          case 6:
            num5 = (int) num3 * -931403211 ^ 95350354;
            continue;
          case 7:
            num5 = (int) num3 * -1864115087 ^ -1335932994;
            continue;
          case 8:
            goto label_31;
          case 9:
            goto label_29;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_31:
      return;
label_33:
      flag2 = chatState == ActivityState.Canceled;
      num5 = -443653878;
      goto label_30;
    }

    private void KeyboardHookManager_KeyUp(object sender, KeyEventArgs e)
    {
label_1:
      int num1 = 449049743;
      while (true)
      {
        int num2 = 995564465;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -2045436505 ^ 2098977730;
            continue;
          case 1:
            this.EscapePressedDown = false;
            num1 = (int) num3 * 1764847305 ^ -1573101970;
            continue;
          case 2:
            int num4 = FloodChat.\u206B⁮‬‭‮​⁮‫‍‎‏‎⁪⁪⁪‪‌⁯‬‎‍⁪‪‭‭⁭‍⁯⁯​‪‫‎⁪‮‬‎‭‬‮‮(e) == Keys.Escape ? -1511301602 : (num4 = -1672373278);
            int num5 = (int) num3 * -1715169454;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * -1747036031 ^ -788980415;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void KeyboardHookManager_KeyDown(object sender, KeyEventArgs e)
    {
      bool flag = FloodChat.\u206B⁮‬‭‮​⁮‫‍‎‏‎⁪⁪⁪‪‌⁯‬‎‍⁪‪‭‭⁭‍⁯⁯​‪‫‎⁪‮‬‎‭‬‮‮(e) == Keys.Escape;
label_1:
      int num1 = -1839703656;
      while (true)
      {
        int num2 = -492268202;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1263762164 ^ -49227371;
            continue;
          case 2:
            int num4 = flag ? -1778528289 : (num4 = -1814180559);
            int num5 = (int) num3 * -2086555914;
            num1 = num4 ^ num5;
            continue;
          case 3:
            this.EscapePressedDown = true;
            num1 = (int) num3 * 1517616831 ^ 1803806961;
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

    private bool ContinueFlood()
    {
label_1:
      int num1 = 1702069746;
      bool flag1;
      object activityLocker;
      while (true)
      {
        int num2 = 964616583;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            flag1 = false;
            num1 = (int) num3 * -1870358303 ^ 756607724;
            continue;
          case 2:
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * 1108074212 ^ -2124271344;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag2 = false;
      try
      {
        FloodChat.\u202A‪‌⁬⁯⁪‬⁪‭‮‭⁫‎⁪⁮⁬‭‬‎⁬‬⁪‪‌‬⁭‪‫⁯⁭⁬⁭⁬‌‏‭‮⁬⁭⁬‮(activityLocker, ref flag2);
        bool flag3 = this.ContinueExecution();
label_7:
        int num2 = 1511461883;
        while (true)
        {
          int num3 = 964616583;
          uint num4;
          bool flag4;
          bool flag5;
          int num5;
          int num6;
          switch ((num4 = (uint) (num2 ^ num3)) % 17U)
          {
            case 0:
              num2 = (int) num4 * -1553056476 ^ 1679296970;
              continue;
            case 1:
              if (this.MessagesToSend != 0)
              {
                num2 = (int) num4 * -932253936 ^ 2100771331;
                continue;
              }
              num5 = 1;
              goto label_23;
            case 2:
              num2 = (int) num4 * -1754747403 ^ 1392451696;
              continue;
            case 3:
              num6 = this.ActivityState != ActivityState.CancelRequested ? 1 : 0;
              goto label_11;
            case 5:
              num2 = 1659498387;
              continue;
            case 6:
              if (this.ActivityState != ActivityState.Completed)
              {
                num2 = (int) num4 * -71095925 ^ 1096706275;
                continue;
              }
              break;
            case 7:
              int num7 = flag4 ? 1496326442 : (num7 = 821963430);
              int num8 = (int) num4 * -807958936;
              num2 = num7 ^ num8;
              continue;
            case 8:
              flag1 = true;
              num2 = (int) num4 * 1969659598 ^ 1305948255;
              continue;
            case 9:
              int num9 = flag3 ? -1849967987 : (num9 = -481843229);
              int num10 = (int) num4 * -2086757276;
              num2 = num9 ^ num10;
              continue;
            case 10:
              goto label_7;
            case 11:
              if (this.ActivityState != ActivityState.Canceled)
              {
                num2 = (int) num4 * -511369456 ^ 2122560985;
                continue;
              }
              break;
            case 12:
              num5 = this.ChatCount < this.MessagesToSend ? 1 : 0;
              goto label_23;
            case 13:
              int num11 = flag5 ? 79200845 : (num11 = 98562906);
              int num12 = (int) num4 * 1519971621;
              num2 = num11 ^ num12;
              continue;
            case 14:
              num2 = 277929590;
              continue;
            case 15:
              if (this.ActivityState != ActivityState.Error)
              {
                num2 = (int) num4 * -213846335 ^ 244927156;
                continue;
              }
              break;
            case 16:
              if (!this.CancelRequested)
              {
                num2 = (int) num4 * -239108378 ^ -1324474333;
                continue;
              }
              break;
            default:
              goto label_39;
          }
          num6 = 0;
label_11:
          flag4 = num6 != 0;
          num2 = 1551700101;
          continue;
label_23:
          flag5 = num5 != 0;
          num2 = 1786451197;
        }
      }
      finally
      {
        if (flag2)
        {
label_34:
          int num2 = 357640494;
          while (true)
          {
            int num3 = 964616583;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                FloodChat.\u200D‏⁪‌⁮⁯‬⁮⁪⁬⁫⁬​⁮‍‫‍⁯⁬‍⁮‏​‍‮​⁬‫⁫⁮⁭⁭‏⁭⁭‪⁯⁪‌⁪‮(activityLocker);
                num2 = (int) num4 * 505419849 ^ -1912398220;
                continue;
              case 2:
                num2 = (int) num4 * 1722816602 ^ 199372115;
                continue;
              case 3:
                goto label_34;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
label_39:
      bool flag6 = flag1;
label_40:
      int num13 = 903339826;
      while (true)
      {
        int num2 = 964616583;
        uint num3;
        switch ((num3 = (uint) (num13 ^ num2)) % 3U)
        {
          case 1:
            num13 = (int) num3 * 1693524295 ^ 1842758260;
            continue;
          case 2:
            goto label_40;
          default:
            goto label_43;
        }
      }
label_43:
      return flag6;
    }

    private string GetRandomText()
    {
label_1:
      int num1 = 1257975807;
      string str1;
      while (true)
      {
        int num2 = 614395245;
        uint num3;
        bool flag1;
        string str2;
        Random random;
        int num4;
        string str3;
        int num5;
        int num6;
        bool flag2;
        int num7;
        char[] chArray;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            str3 = str3.TrimStart();
            str1 = str3;
            num1 = (int) num3 * -1263021909 ^ 1136483806;
            continue;
          case 1:
            num5 = 0;
            num1 = (int) num3 * 1548084715 ^ -280315376;
            continue;
          case 2:
            random = FloodChat.\u206E⁪⁮⁪‬‎‬​‫‌‭⁬‮‎⁬⁮‌⁭⁯‭‌‮‏‮‪⁯​‫‫⁮‪‌‏⁬​‮⁮‎‭‏‮();
            str3 = string.Empty;
            chArray = FloodChat.\u206F‍⁬‫⁮‍‫‮⁮⁫​⁬‮‌​‏‎‎⁯‬⁪‌​‬‮‏‬‏‪‮⁫‎⁮‎‌⁮‏‮​‌‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1120454426U));
            num1 = (int) num3 * -1316462129 ^ 125058816;
            continue;
          case 3:
            num7 = FloodChat.\u200E⁯‌⁮⁪‌‏‪‏‌⁮⁬‬⁪⁫⁫‍‫‌⁫​‬‌‭⁮‮‍⁯⁮⁭⁯‏⁮‏​⁫‌​‎⁮‮(random, 80, 100);
            num1 = (int) num3 * -1767504891 ^ 2135495419;
            continue;
          case 4:
            num6 = 1;
            num1 = (int) num3 * -1482737139 ^ 1317167822;
            continue;
          case 5:
            str3 = str3 + \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(209903335U) + str2;
            ++num5;
            num1 = (int) num3 * -1160657693 ^ -2042757406;
            continue;
          case 6:
            int index = FloodChat.\u200E⁯‌⁮⁪‌‏‪‏‌⁮⁬‬⁪⁫⁫‍‫‌⁫​‬‌‭⁮‮‍⁯⁮⁭⁯‏⁮‏​⁫‌​‎⁮‮(random, 0, chArray.Length - 1);
            str2 += chArray[index].ToString();
            ++num6;
            num1 = 762266206;
            continue;
          case 7:
            num1 = 1474996891;
            continue;
          case 8:
            str2 = "";
            num4 = FloodChat.\u200E⁯‌⁮⁪‌‏‪‏‌⁮⁬‬⁪⁫⁫‍‫‌⁫​‬‌‭⁮‮‍⁯⁮⁭⁯‏⁮‏​⁫‌​‎⁮‮(random, 3, 15);
            num1 = (int) num3 * -1912863055 ^ -827020473;
            continue;
          case 9:
            num1 = (int) num3 * 1703426745 ^ 368473532;
            continue;
          case 10:
            num1 = (int) num3 * 1347997354 ^ 1919132477;
            continue;
          case 11:
            int num8 = flag1 ? -391378812 : (num8 = -392823037);
            int num9 = (int) num3 * 1024116885;
            num1 = num8 ^ num9;
            continue;
          case 12:
            int num10 = !flag2 ? -1400387581 : (num10 = -628652412);
            int num11 = (int) num3 * 1422549220;
            num1 = num10 ^ num11;
            continue;
          case 13:
            num1 = (int) num3 * -596040147 ^ -1742330979;
            continue;
          case 15:
            goto label_1;
          case 16:
            flag2 = num5 < num7;
            num1 = 1898562209;
            continue;
          case 17:
            flag1 = num6 <= num4;
            num1 = 148904686;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return str1;
    }

    internal override bool Valid()
    {
      bool flag = true;
label_1:
      int num1 = 1051495197;
      while (true)
      {
        int num2 = 519658697;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * 49592757 ^ 1301062017;
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

    static bool \u202E‪‪‌‎⁮‭​⁭‍⁪⁬‏‌‌⁪​⁫‭‪‮‏‬⁭‮‌‏‌‮‭⁭‬‎‎⁭‭‪⁮‬⁪‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static void \u206C⁮⁫​‌‍⁮⁬‪‮⁫‍‮‭‌‫⁭‮⁫‪‎‪‏⁭‌⁭‫‌‫⁬‮‎⁮⁮‫‪⁭⁪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static string \u200E​‫‫⁮⁪⁯‍‌​‌⁬‍‪‍‮‌‎⁯⁮‫‎‍‭⁪⁪‍⁮‮‪‎⁪⁭⁫⁪⁭‭⁯‎‬‮()
    {
      return System.Windows.Clipboard.GetText();
    }

    static void \u200D⁭⁯⁭‫⁪⁬⁮⁪‪⁫‏⁫⁬‏⁯‌⁭‮‌‬‌‬⁭⁫‬⁮‪⁪⁬⁭‬‌‍‮​‫‌‌‏‮([In] string obj0)
    {
      System.Windows.Clipboard.SetText(obj0);
    }

    static void \u202A‪‌⁬⁯⁪‬⁪‭‮‭⁫‎⁪⁮⁬‭‬‎⁬‬⁪‪‌‬⁭‪‫⁯⁭⁬⁭⁬‌‏‭‮⁬⁭⁬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200D‏⁪‌⁮⁯‬⁮⁪⁬⁫⁬​⁮‍‫‍⁯⁬‍⁮‏​‍‮​⁬‫⁫⁮⁭⁭‏⁭⁭‪⁯⁪‌⁪‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static string \u202E⁯‪⁭‫‍⁪‮⁭‭​‎‌⁪‪⁫⁭​‍‏‫‬⁯‏‪‎⁫⁪⁯‭‪⁬⁯⁯⁬‭‫⁮⁬‌‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static Keys \u206B⁮‬‭‮​⁮‫‍‎‏‎⁪⁪⁪‪‌⁯‬‎‍⁪‪‭‭⁭‍⁯⁯​‪‫‎⁪‮‬‎‭‬‮‮([In] KeyEventArgs obj0)
    {
      return obj0.KeyCode;
    }

    static Random \u206E⁪⁮⁪‬‎‬​‫‌‭⁬‮‎⁬⁮‌⁭⁯‭‌‮‏‮‪⁯​‫‫⁮‪‌‏⁬​‮⁮‎‭‏‮()
    {
      return new Random();
    }

    static char[] \u206F‍⁬‫⁮‍‫‮⁮⁫​⁬‮‌​‏‎‎⁯‬⁪‌​‬‮‏‬‏‪‮⁫‎⁮‎‌⁮‏‮​‌‮([In] string obj0)
    {
      return obj0.ToCharArray();
    }

    static int \u200E⁯‌⁮⁪‌‏‪‏‌⁮⁬‬⁪⁫⁫‍‫‌⁫​‬‌‭⁮‮‍⁯⁮⁭⁯‏⁮‏​⁫‌​‎⁮‮([In] Random obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Next(obj1, obj2);
    }
  }
}
