// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.SendChat
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZoomZoom.Common;
using ZoomZoom.Models.Chats;

namespace ZoomZoom.Models.Activities
{
  public class SendChat : ActivityBase
  {
    private static LockedObservableCollection<MessageCategory> sourceCategories = new LockedObservableCollection<MessageCategory>();
    private static LockedObservableCollection<MessageContent> sourceMessages = new LockedObservableCollection<MessageContent>();
    private string meetingId = string.Empty;
    private ZoomWindow chatWindow = (ZoomWindow) null;
    private VideoChatLink videoChatLink = (VideoChatLink) null;
    private ChatOptions chatOptions = (ChatOptions) null;
    private MessageCategory sourceCategory = (MessageCategory) null;
    private MessageContent content = (MessageContent) null;
    private bool randomMessage = false;
    private bool randomMessageSupported = false;
    private string manualMessage = string.Empty;
    private bool manualMessageSupported = false;
    private string message;
    private string userId;

    public string Message
    {
      get
      {
        string message = this.message;
label_1:
        int num1 = 1824515820;
        while (true)
        {
          int num2 = 1120516597;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 71105288 ^ 1854957036;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return message;
      }
      set
      {
        this.message = value;
      }
    }

    public string UserId
    {
      get
      {
label_1:
        int num1 = -1729806359;
        string userId;
        while (true)
        {
          int num2 = -1221383185;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -232823001 ^ -1846814544;
              continue;
            case 2:
              userId = this.userId;
              num1 = (int) num3 * -1645631831 ^ -588285044;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return userId;
      }
      set
      {
label_1:
        int num1 = -467275605;
        while (true)
        {
          int num2 = -1090824961;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.userId = value;
              num1 = (int) num3 * 1491590811 ^ -1139581818;
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

    public string MeetingId
    {
      get
      {
        string meetingId = this.meetingId;
label_1:
        int num1 = 990182418;
        while (true)
        {
          int num2 = 1365856892;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1747449038 ^ -1603212671;
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
        object activityLocker = ActivityBase.activityLocker;
        bool flag = false;
        try
        {
          SendChat.\u200E​‮⁪‎‭⁭⁪⁯⁫⁯⁪‫‍‮‍⁬‎​⁫‮​​⁫‍‪⁪‏‬⁮⁪⁬⁬⁯‌‫⁬‍‎‎‮(activityLocker, ref flag);
label_2:
          int num1 = 724300335;
          while (true)
          {
            int num2 = 1595434592;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_9;
              case 1:
                this.meetingId = value;
                num1 = (int) num3 * -181636052 ^ 1792717052;
                continue;
              case 2:
                goto label_2;
              default:
                goto label_5;
            }
          }
label_5:
          return;
label_9:;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num1 = 1642890118;
            while (true)
            {
              int num2 = 1595434592;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_7;
                case 1:
                  num1 = (int) num3 * 1458029846 ^ -134866343;
                  continue;
                case 2:
                  SendChat.\u206A‫‎⁯⁭⁬⁬‪⁫⁭‌‫‌⁫‪‫⁭‮‮‮‪‏‌‫‎‭‪⁪‍‬‎‍‎⁬‫‮‭‪‭‭‮(activityLocker);
                  num1 = (int) num3 * -836550411 ^ -1303994593;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
      }
    }

    public ZoomWindow ChatWindow
    {
      get
      {
label_1:
        int num1 = 397642267;
        ZoomWindow chatWindow;
        while (true)
        {
          int num2 = 1479309077;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              chatWindow = this.chatWindow;
              num1 = (int) num3 * -1068707864 ^ 1555222240;
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
        object activityLocker = ActivityBase.activityLocker;
        bool flag = false;
        try
        {
          SendChat.\u200E​‮⁪‎‭⁭⁪⁯⁫⁯⁪‫‍‮‍⁬‎​⁫‮​​⁫‍‪⁪‏‬⁮⁪⁬⁬⁯‌‫⁬‍‎‎‮(activityLocker, ref flag);
label_2:
          int num1 = 2080388369;
          while (true)
          {
            int num2 = 2068285312;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                goto label_11;
              case 1:
                num1 = (int) num3 * -199346916 ^ -1387194783;
                continue;
              case 2:
                num1 = (int) num3 * -1964095230 ^ -1605458002;
                continue;
              case 3:
                goto label_2;
              case 4:
                this.chatWindow = value;
                num1 = (int) num3 * 1034746210 ^ -1029770484;
                continue;
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
            int num1 = 71775427;
            while (true)
            {
              int num2 = 2068285312;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 1:
                  SendChat.\u206A‫‎⁯⁭⁬⁬‪⁫⁭‌‫‌⁫‪‫⁭‮‮‮‪‏‌‫‎‭‪⁪‍‬‎‍‎⁬‫‮‭‪‭‭‮(activityLocker);
                  num1 = (int) num3 * -1899165857 ^ -760773018;
                  continue;
                case 2:
                  goto label_9;
                default:
                  goto label_13;
              }
            }
          }
label_13:;
        }
      }
    }

    public VideoChatLink VideoChatLink
    {
      get
      {
label_1:
        int num1 = -587237305;
        VideoChatLink videoChatLink;
        while (true)
        {
          int num2 = -1577688599;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              videoChatLink = this.videoChatLink;
              num1 = (int) num3 * -801770901 ^ 669276228;
              continue;
            case 3:
              num1 = (int) num3 * -1973480777 ^ 2072184349;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return videoChatLink;
      }
      set
      {
label_1:
        int num1 = 816469167;
        while (true)
        {
          int num2 = 2108474484;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.videoChatLink = value;
              num1 = (int) num3 * 533037830 ^ 703192501;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 433318732;
        TraceType traceType;
        while (true)
        {
          int num2 = 1634205233;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1576724539 ^ -903821264;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public ChatOptions ChatOptions
    {
      get
      {
        ChatOptions chatOptions = this.chatOptions;
label_1:
        int num1 = 974204068;
        while (true)
        {
          int num2 = 1269720055;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1692526756 ^ -507565742;
              continue;
            case 2:
              goto label_1;
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
        int num1 = 629858250;
        while (true)
        {
          int num2 = 1753782667;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.chatOptions = value;
              num1 = (int) num3 * 1416713347 ^ 1433399284;
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

    public SendChat()
    {
label_1:
      int num1 = -497267592;
      while (true)
      {
        int num2 = -366517289;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -558400377 ^ 2072857449;
            continue;
          case 2:
            this.ChatOptions = new ChatOptions();
            num1 = (int) num3 * -37489163 ^ -2013995067;
            continue;
          case 3:
            num1 = (int) num3 * 1677660048 ^ -1917211851;
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

    public SendChat(string message, string userId)
    {
      this.Message = message;
      this.UserId = userId;
      this.ChatOptions = new ChatOptions();
      this.ChatOptions.ManualMessage = message;
    }

    public SendChat(ChatOptions options)
    {
      this.ChatOptions = options;
    }

    public SendChat(VideoChatLink videoChatLink)
    {
label_1:
      int num1 = -1340653625;
      while (true)
      {
        int num2 = -485371550;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            this.ChatOptions.ManualMessage = videoChatLink.TrackingMessage;
            num1 = (int) num3 * 423303358 ^ -566426466;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * -1634063203 ^ 67348396;
            continue;
          case 4:
            this.VideoChatLink = videoChatLink;
            this.ChatOptions = new ChatOptions();
            num1 = (int) num3 * -1452831105 ^ 1762423691;
            continue;
          case 5:
            this.Message = videoChatLink.TrackingMessage;
            num1 = (int) num3 * -546856125 ^ 118739503;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    protected override void ExecuteLogic()
    {
      try
      {
        this.ActivityState = ActivityState.InProgress;
label_2:
        int num1 = 927757439;
        while (true)
        {
          int num2 = 1617626466;
          uint num3;
          ZoomWindow window;
          bool flag1;
          bool flag2;
          bool flag3;
          bool flag4;
          ZoomMeeting activeMeeting;
          bool flag5;
          FindUser findUser;
          bool flag6;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 63U)
          {
            case 0:
              num1 = 1014187971;
              continue;
            case 1:
              int num6 = flag5 ? 346704187 : (num6 = 1737342219);
              int num7 = (int) num3 * -1077341646;
              num1 = num6 ^ num7;
              continue;
            case 2:
              num1 = (int) num3 * -1685261554 ^ 1353613877;
              continue;
            case 3:
              int num8 = !flag2 ? -1686892025 : (num8 = -1533996410);
              int num9 = (int) num3 * 876101997;
              num1 = num8 ^ num9;
              continue;
            case 4:
              num1 = 1086663456;
              continue;
            case 5:
              num4 = this.ActivityState == ActivityState.InProgress ? 1 : 0;
              break;
            case 6:
              goto label_2;
            case 7:
              num1 = (int) num3 * -414531329 ^ 884368506;
              continue;
            case 8:
              num1 = (int) num3 * 52151688 ^ 1750635055;
              continue;
            case 9:
              Thread.Sleep(50);
              num1 = (int) num3 * -1005461299 ^ 663544043;
              continue;
            case 10:
              int num10;
              num1 = num10 = !SendChat.\u202E⁯‭‏⁭‎‍‪‬⁯⁯​‎‌⁪‎‬⁮⁫‎‎‬‏‪‬‮‎⁫‮‭⁭⁯⁪​⁭‪‫⁫⁫⁬‮(this.Message) ? 1675431442 : (num10 = 121443916);
              continue;
            case 11:
              Thread.Sleep(50);
              num1 = (int) num3 * -640893343 ^ 1708201294;
              continue;
            case 12:
              ZoomWindow zoomWindow = window;
              Size size = window.Size;
              int x = size.Width - 40;
              size = window.Size;
              int y = size.Height - 40;
              System.Drawing.Point coordinates = new System.Drawing.Point(x, y);
              int num11 = 1;
              int num12 = 1;
              int millisecondDelay = 0;
              zoomWindow.Click(coordinates, num11 != 0, num12 != 0, millisecondDelay);
              num1 = (int) num3 * -705451819 ^ -1439254087;
              continue;
            case 13:
              num1 = (int) num3 * 1003339720 ^ -995049711;
              continue;
            case 14:
              num1 = (int) num3 * 1106326205 ^ 404040715;
              continue;
            case 15:
              num1 = (int) num3 * 1146826047 ^ 1306821475;
              continue;
            case 16:
              num1 = (int) num3 * -1849907211 ^ 327195114;
              continue;
            case 17:
              num1 = (int) num3 * -1774263321 ^ -840081658;
              continue;
            case 18:
              flag2 = flag1;
              num1 = 335811673;
              continue;
            case 19:
              goto label_81;
            case 20:
              num1 = (int) num3 * 1092232729 ^ -2083148822;
              continue;
            case 21:
              int num13 = SendChat.\u202E⁯‭‏⁭‎‍‪‬⁯⁯​‎‌⁪‎‬⁮⁫‎‎‬‏‪‬‮‎⁫‮‭⁭⁯⁪​⁭‪‫⁫⁫⁬‮(this.Message) ? 1557782309 : (num13 = 140044056);
              int num14 = (int) num3 * 1858061303;
              num1 = num13 ^ num14;
              continue;
            case 22:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3171657966U));
              num1 = 1061888551;
              continue;
            case 23:
              int num15 = flag6 ? -1866641964 : (num15 = -93751806);
              int num16 = (int) num3 * -1907466922;
              num1 = num15 ^ num16;
              continue;
            case 24:
              SendChat.\u206C⁯‬‭​⁯⁭⁪‭‮⁬⁬‏⁬⁭‏‬‫‭‎‌⁪‭‏​‪‪⁪‮⁯​‮⁭⁫‌‪⁪‏​‪‮(50);
              num1 = (int) num3 * 242661546 ^ -1260782565;
              continue;
            case 25:
              num1 = (int) num3 * 1723181808 ^ 1040070253;
              continue;
            case 26:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3173592694U));
              num1 = (int) num3 * -672366139 ^ 884142632;
              continue;
            case 27:
              num1 = (int) num3 * 1102802380 ^ 1152848341;
              continue;
            case 28:
              Thread.Sleep(50);
              num1 = (int) num3 * -1748143872 ^ 1918258550;
              continue;
            case 29:
              num1 = (int) num3 * 1629246258 ^ -325326403;
              continue;
            case 30:
              SendKeys.SendWait(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(375947143U));
              num1 = (int) num3 * -1162928373 ^ -1422831399;
              continue;
            case 31:
              findUser = new FindUser(this.UserId, true);
              num1 = (int) num3 * -1145758640 ^ 1564417058;
              continue;
            case 32:
              ZoomZoom.NativeMethods.SetForegroundWindow(window.Handle);
              Thread.Sleep(50);
              num1 = (int) num3 * 748777941 ^ 2018995096;
              continue;
            case 33:
              SendChat.\u200C‎‎​‍⁬‌‭⁯‌‌⁬⁬‬‫‬‏‍‫⁫‍‪‍‌⁬‮⁪‮⁮⁮‍‪⁬‪‭​‬‮⁫⁯‮((object) this.Message, true, 5, 50);
              num1 = (int) num3 * 1893428063 ^ 507051510;
              continue;
            case 34:
              num5 = !window.IsVisible ? 1 : 0;
              goto label_46;
            case 35:
              this.MeetingId = activeMeeting.MeetingId;
              num1 = (int) num3 * -2112044226 ^ -1372858131;
              continue;
            case 36:
              num1 = (int) num3 * -1418941409 ^ -1925078232;
              continue;
            case 37:
              num1 = (int) num3 * -599364184 ^ 827419052;
              continue;
            case 38:
              window.Activate();
              num1 = (int) num3 * 2073293344 ^ -924548305;
              continue;
            case 39:
              num1 = (int) num3 * 1621152395 ^ -439143099;
              continue;
            case 40:
              int num17 = !flag3 ? -1742323656 : (num17 = -69540782);
              int num18 = (int) num3 * 415371684;
              num1 = num17 ^ num18;
              continue;
            case 41:
              SendKeys.SendWait(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4279420196U));
              num1 = (int) num3 * 1067827666 ^ -1589391140;
              continue;
            case 42:
              flag1 = true;
              num1 = (int) num3 * 525900266 ^ -237392681;
              continue;
            case 43:
              num1 = (int) num3 * -17177935 ^ 676863030;
              continue;
            case 44:
              this.ChatWindow = this.Engine.GetWindowViaButton(ZoomWindowType.Chat);
              num1 = (int) num3 * 597574163 ^ -892439140;
              continue;
            case 45:
              int num19 = flag4 ? -1502889095 : (num19 = -518688846);
              int num20 = (int) num3 * -1026678275;
              num1 = num19 ^ num20;
              continue;
            case 46:
              num1 = (int) num3 * 325970479 ^ 1616265822;
              continue;
            case 47:
              flag5 = activeMeeting != null;
              num1 = 1058871809;
              continue;
            case 48:
              this.GetmeetingWindow();
              window = this.Engine.GetWindow(ZoomWindowType.Chat);
              num1 = (int) num3 * -570742806 ^ 1484919538;
              continue;
            case 49:
              flag1 = false;
              int num21 = SendChat.\u202E⁯‭‏⁭‎‍‪‬⁯⁯​‎‌⁪‎‬⁮⁫‎‎‬‏‪‬‮‎⁫‮‭⁭⁯⁪​⁭‪‫⁫⁫⁬‮(this.UserId) ? 438881201 : (num21 = 400238218);
              int num22 = (int) num3 * 205963685;
              num1 = num21 ^ num22;
              continue;
            case 50:
              flag6 = this.ExecuteSubActivity((ActivityBase) findUser, true) == ActivityState.Completed;
              num1 = (int) num3 * -751957568 ^ 1695924805;
              continue;
            case 51:
              this.ActivityState = ActivityState.Completed;
              num1 = (int) num3 * -925297823 ^ 1015931533;
              continue;
            case 52:
              if (window != null)
              {
                num1 = 981473611;
                continue;
              }
              num5 = 1;
              goto label_46;
            case 53:
              flag1 = true;
              num1 = (int) num3 * 1397229228 ^ 1176686472;
              continue;
            case 54:
              num1 = 484852504;
              continue;
            case 55:
              SendChat.\u202A⁫‎‫⁪‍‍‪‫⁭⁫⁫‭‫‍⁯‍​‬⁮‭⁪⁮‭‎⁫‫‮‭‌⁬⁭⁭‌‬⁪⁯⁫‪⁪‮(CoreObject.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2337403511U));
              num1 = (int) num3 * 1354741480 ^ -857409348;
              continue;
            case 56:
              num1 = (int) num3 * -51151490 ^ 1417013613;
              continue;
            case 57:
              this.Message = this.ChatOptions.GetMessage();
              num1 = (int) num3 * 707133101 ^ 1461482334;
              continue;
            case 58:
              activeMeeting = this.Engine.ActiveMeeting;
              num1 = (int) num3 * 1117201486 ^ 211341476;
              continue;
            case 59:
              if (window != null)
              {
                num1 = 2134067515;
                continue;
              }
              num4 = 0;
              break;
            case 60:
              num1 = (int) num3 * -1577743720 ^ 1925348303;
              continue;
            case 61:
              num1 = (int) num3 * -908150289 ^ 1886717322;
              continue;
            case 62:
              num1 = 1575156201;
              continue;
            default:
              goto label_76;
          }
          flag4 = num4 != 0;
          num1 = 849678800;
          continue;
label_46:
          flag3 = num5 != 0;
          num1 = 1571515631;
        }
label_76:
        return;
label_81:;
      }
      catch (Exception ex)
      {
label_74:
        int num1 = 201900358;
        while (true)
        {
          int num2 = 1617626466;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_74;
            case 1:
              num1 = (int) num3 * 1601960705 ^ 667890928;
              continue;
            case 2:
              goto label_72;
            case 3:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * 135026067 ^ -1662016266;
              continue;
            case 4:
              num1 = (int) num3 * -1487829640 ^ 1501392705;
              continue;
            case 5:
              this.SetActivityState(ActivityState.Error, ex.Message);
              num1 = (int) num3 * 1333080300 ^ 223879976;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_72:;
      }
    }

    [DllImport("user32.dll")]
    private static extern IntPtr GetOpenClipboardWindow();

    [DllImport("user32.dll")]
    private static extern int GetWindowText(int hwnd, StringBuilder text, int count);

    private string getOpenClipboardWindowText()
    {
      IntPtr openClipboardWindow = SendChat.GetOpenClipboardWindow();
label_1:
      int num1 = -225280854;
      string str;
      while (true)
      {
        int num2 = -1637169488;
        uint num3;
        StringBuilder text;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            str = text.ToString();
            num1 = (int) num3 * -652508477 ^ -2031462573;
            continue;
          case 2:
            text = SendChat.\u202B‌⁭‎⁫‭​⁭‏⁭⁮⁪‏⁫‎‬‫‏‪‬‪‌‮⁬⁭⁮‫⁬⁪⁬⁮⁬‫‮‬‮‮⁫⁮⁬‮(501);
            SendChat.GetWindowText(openClipboardWindow.ToInt32(), text, 500);
            num1 = (int) num3 * 640419567 ^ -1241509809;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    private void GenerateMessage()
    {
label_1:
      int num1 = 1882984560;
      while (true)
      {
        int num2 = 1704409487;
        uint num3;
        bool flag;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * 1686203258 ^ 1858118611;
            continue;
          case 1:
            int num6 = !flag ? 728121741 : (num6 = 914214256);
            int num7 = (int) num3 * 1782108019;
            num1 = num6 ^ num7;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (SendChat.\u200B⁯⁪⁬‎⁭‫⁭⁬‭‪‏⁭‭⁬⁮‎⁭⁫‮‎‌‭‏⁬‏⁮​‪‪‌⁮‍‏⁮‪⁮​⁫‍‮(this.ChatOptions.SourceCategory.CategoryName, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3245227004U)))
            {
              num1 = (int) num3 * 2072310290 ^ -815763791;
              continue;
            }
            num4 = 0;
            break;
          case 4:
            this.Message = this.Engine.GetMessageContent(this.ChatOptions.SourceCategory).ContentText;
            num1 = (int) num3 * 2080337888 ^ 1822184394;
            continue;
          case 5:
            goto label_1;
          case 6:
            num5 = this.ChatOptions.RandomMessage ? 1 : 0;
            goto label_17;
          case 7:
            if (this.ChatOptions.SourceCategory != null)
            {
              num1 = 554865839;
              continue;
            }
            num5 = 0;
            goto label_17;
          case 8:
            num4 = this.ChatOptions.SourceContent != null ? 1 : 0;
            break;
          case 9:
            num1 = (int) num3 * 88938853 ^ -526968230;
            continue;
          default:
            goto label_18;
        }
        flag = num4 != 0;
        num1 = 576684466;
        continue;
label_17:
        int num8;
        num1 = num8 = num5 == 0 ? 1509238691 : (num8 = 69468857);
      }
label_18:
      return;
label_3:;
    }

    private void OpenChatWindow(ZoomWindow meetingWindow)
    {
      this.ChatWindow = this.Engine.GetWindow(ZoomWindowType.Chat);
label_1:
      int num1 = -1292944773;
      List<ZoomButton> list;
      while (true)
      {
        int num2 = -684917020;
        uint num3;
        FindButtons findButtons1;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            FindButtons findButtons2 = new FindButtons(ZoomWindowType.Undefined);
            findButtons2.ButtonTypesToFind.Add(ZoomWindowType.Chat);
            findButtons2.Options = new ActivityOptions()
            {
              SuppressProgressReports = true
            };
            findButtons1 = findButtons2;
            num1 = (int) num3 * -129093845 ^ -387852205;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomButton>) Enumerable.Where<ZoomButton>((IEnumerable<M0>) this.Engine.ActiveMeeting.MeetingButtons, (Func<M0, bool>) (SendChat.\u003C\u003Ec.\u003C\u003E9__43_0 ?? (SendChat.\u003C\u003Ec.\u003C\u003E9__43_0 = new Func<ZoomButton, bool>((object) SendChat.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003COpenChatWindow\u003Eb__43_0)))))).ToList<ZoomButton>();
            num1 = -85320788;
            continue;
          case 2:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1239080986U));
            num1 = (int) num3 * 1511837500 ^ -1780193887;
            continue;
          case 3:
            num1 = (int) num3 * -1466828752 ^ -677794004;
            continue;
          case 4:
            num1 = -911536450;
            continue;
          case 5:
            goto label_1;
          case 7:
            goto label_43;
          case 8:
            int num4 = list.Count == 0 ? 1215750336 : (num4 = 340423594);
            int num5 = (int) num3 * -1517292440;
            num1 = num4 ^ num5;
            continue;
          case 9:
            int num6 = this.ExecuteSubActivity((ActivityBase) findButtons1, true) == ActivityState.Completed ? 109438123 : (num6 = 1608446665);
            int num7 = (int) num3 * -217963918;
            num1 = num6 ^ num7;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomButton>) Enumerable.Where<ZoomButton>((IEnumerable<M0>) this.Engine.ActiveMeeting.MeetingButtons, (Func<M0, bool>) (SendChat.\u003C\u003Ec.\u003C\u003E9__43_1 ?? (SendChat.\u003C\u003Ec.\u003C\u003E9__43_1 = new Func<ZoomButton, bool>((object) SendChat.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003COpenChatWindow\u003Eb__43_1)))))).ToList<ZoomButton>();
            num1 = -2035027953;
            continue;
          case 11:
            num1 = -1295534358;
            continue;
          case 12:
            int num8;
            num1 = num8 = list.Count == 0 ? -1622331530 : (num8 = -1497692912);
            continue;
          case 13:
            if (this.ChatWindow == null)
            {
              num1 = (int) num3 * -410739108 ^ -2025146517;
              continue;
            }
            goto label_50;
          default:
            goto label_15;
        }
      }
label_43:
      return;
label_15:
      List<ZoomButton>.Enumerator enumerator = list.GetEnumerator();
      try
      {
label_32:
        int num2 = !enumerator.MoveNext() ? -163456312 : (num2 = -1108497127);
        while (true)
        {
          int num3 = -684917020;
          uint num4;
          ZoomWindow zoomWindow;
          // ISSUE: variable of a compiler-generated type
          SendChat.\u003C\u003Ec__DisplayClass43_0 cDisplayClass430;
          switch ((num4 = (uint) (num2 ^ num3)) % 18U)
          {
            case 0:
              int num5 = zoomWindow != null ? 764586971 : (num5 = 941758914);
              int num6 = (int) num4 * -1128687875;
              num2 = num5 ^ num6;
              continue;
            case 1:
              num2 = (int) num4 * -287744160 ^ -1779118360;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              int num7 = (int) zoomWindow.ClickButton(cDisplayClass430.button);
              num2 = -1381511483;
              continue;
            case 3:
              num2 = (int) num4 * -758095830 ^ 969832576;
              continue;
            case 4:
              num2 = (int) num4 * -1483518452 ^ 1641510533;
              continue;
            case 5:
              num2 = (int) num4 * 1619688419 ^ -1081672976;
              continue;
            case 6:
              // ISSUE: method pointer
              zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass430, __methodptr(\u003COpenChatWindow\u003Eb__2)));
              num2 = (int) num4 * -162790211 ^ -1826299108;
              continue;
            case 7:
              num2 = -1108497127;
              continue;
            case 8:
              num2 = -647009196;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              int num8 = zoomWindow.Size.Equals((object) cDisplayClass430.button.WindowSize) ? -1517881044 : (num8 = -1720904714);
              int num9 = (int) num4 * 957759166;
              num2 = num8 ^ num9;
              continue;
            case 10:
              num2 = -342957892;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated field
              zoomWindow.Move(new Rectangle(zoomWindow.Location, cDisplayClass430.button.WindowSize));
              num2 = (int) num4 * -600358674 ^ -1707166857;
              continue;
            case 12:
              goto label_40;
            case 13:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass430.button = enumerator.Current;
              num2 = (int) num4 * 399021364 ^ 378946982;
              continue;
            case 14:
              this.ChatWindow = this.Engine.GetWindow(ZoomWindowType.Chat);
              int num10 = this.ChatWindow == null ? 1653758758 : (num10 = 119152345);
              int num11 = (int) num4 * 603541236;
              num2 = num10 ^ num11;
              continue;
            case 15:
              Thread.Sleep(200);
              num2 = (int) num4 * 1969593670 ^ 164891006;
              continue;
            case 16:
              goto label_32;
            case 17:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass430 = new SendChat.\u003C\u003Ec__DisplayClass43_0();
              num2 = -1042344173;
              continue;
            default:
              goto label_36;
          }
        }
label_36:
        return;
label_40:
        return;
      }
      finally
      {
        enumerator.Dispose();
label_38:
        int num2 = -1305508689;
        while (true)
        {
          int num3 = -684917020;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -1064928479 ^ 1121498823;
              continue;
            case 2:
              goto label_38;
            default:
              goto label_42;
          }
        }
label_42:;
      }
label_50:
      bool flag = !this.ChatWindow.IsVisible;
      int num12 = -763832998;
      while (true)
      {
        int num2 = -684917020;
        uint num3;
        switch ((num3 = (uint) (num12 ^ num2)) % 7U)
        {
          case 0:
            goto label_46;
          case 1:
            goto label_50;
          case 2:
            num12 = (int) num3 * 1363671717 ^ -1562184220;
            continue;
          case 3:
            int num4 = !flag ? -7804049 : (num4 = -773393351);
            int num5 = (int) num3 * -1426586645;
            num12 = num4 ^ num5;
            continue;
          case 4:
            this.ChatWindow.Activate();
            num12 = (int) num3 * 2104797920 ^ 1010654249;
            continue;
          case 5:
            num12 = (int) num3 * -1728889051 ^ -1325168399;
            continue;
          case 6:
            num12 = -2074702200;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return;
label_46:;
    }

    private ZoomWindow GetmeetingWindow()
    {
      ZoomWindow zoomWindow1 = this.Engine.ActiveMeetingWindow;
      if (zoomWindow1 != null)
        goto label_50;
label_1:
      int num1 = -1516630684;
label_2:
      List<Process> processes;
      DateTime now;
      while (true)
      {
        int num2 = -268977371;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            zoomWindow1 = this.Engine.GetWindow(ZoomWindowType.Meeting);
            num1 = (int) num3 * 1434256457 ^ -867971294;
            continue;
          case 1:
            if (zoomWindow1 == null)
            {
              num1 = (int) num3 * -536058185 ^ 885103102;
              continue;
            }
            goto label_41;
          case 2:
            processes = WindowManager.GetProcesses();
            num1 = (int) num3 * 1996588994 ^ 523551684;
            continue;
          case 3:
            goto label_11;
          case 5:
            num1 = (int) num3 * 1336240651 ^ -517646714;
            continue;
          case 6:
            goto label_9;
          case 7:
            goto label_1;
          case 8:
            now = DateTime.Now;
            num1 = (int) num3 * -1931333986 ^ 1481197664;
            continue;
          case 9:
            num1 = (int) num3 * -1208591148 ^ -162661253;
            continue;
          default:
            goto label_12;
        }
      }
label_11:
      DateTime dateTime = now.AddSeconds(5.0);
      goto label_48;
label_12:
      ZoomWindow zoomWindow2;
      using (List<Process>.Enumerator enumerator1 = processes.GetEnumerator())
      {
label_35:
        uint num2;
        if (enumerator1.MoveNext())
        {
label_16:
          Process current1 = enumerator1.Current;
          int num3 = -833576288;
          while (true)
          {
            int num4 = -268977371;
            switch ((num2 = (uint) (num3 ^ num4)) % 3U)
            {
              case 0:
                num3 = -30913287;
                continue;
              case 2:
                goto label_16;
              default:
                goto label_17;
            }
          }
label_17:
          using (List<IntPtr>.Enumerator enumerator2 = WindowManager.GetVisibleWindowHandles(current1.Id).GetEnumerator())
          {
label_23:
            int num4 = enumerator2.MoveNext() ? -2146252380 : (num4 = -293516176);
            while (true)
            {
              int num5 = -268977371;
              uint num6;
              bool flag;
              IntPtr current2;
              switch ((num6 = (uint) (num4 ^ num5)) % 13U)
              {
                case 0:
                  num4 = -2146252380;
                  continue;
                case 1:
                  num4 = (int) num6 * 859207595 ^ 427255943;
                  continue;
                case 2:
                  int num7 = flag ? -2128175845 : (num7 = -1157459612);
                  int num8 = (int) num6 * 93759102;
                  num4 = num7 ^ num8;
                  continue;
                case 3:
                  current2 = enumerator2.Current;
                  num4 = -568376061;
                  continue;
                case 4:
                  goto label_52;
                case 5:
                  num4 = -1015663481;
                  continue;
                case 6:
                  zoomWindow1 = ZoomFactory.CreateWindow(current2);
                  num4 = (int) num6 * -760901353 ^ -459037449;
                  continue;
                case 7:
                  flag = zoomWindow1 != null;
                  num4 = (int) num6 * 1377852915 ^ -1794652444;
                  continue;
                case 8:
                  num4 = -671324705;
                  continue;
                case 9:
                  zoomWindow2 = zoomWindow1;
                  num4 = (int) num6 * -509356605 ^ 592311481;
                  continue;
                case 10:
                  goto label_23;
                case 12:
                  int num9 = WindowHelper.GetWindowTitle(current2).Contains(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3505064265U)) ? -17633441 : (num9 = -344798265);
                  int num10 = (int) num6 * 2075336551;
                  num4 = num9 ^ num10;
                  continue;
                default:
                  goto label_32;
              }
            }
          }
label_32:;
        }
        else
          goto label_36;
label_33:
        int num11 = -431600538;
label_34:
        int num12 = -268977371;
        switch ((num2 = (uint) (num11 ^ num12)) % 3U)
        {
          case 0:
            goto label_33;
          case 2:
            goto label_35;
          default:
            goto label_38;
        }
label_36:
        num11 = -1431326015;
        goto label_34;
      }
label_38:
      goto label_39;
label_9:
      num1 = -1074793371;
      goto label_2;
label_39:
      int num13 = -1367872887;
label_40:
      bool flag1;
      while (true)
      {
        int num2 = -268977371;
        uint num3;
        switch ((num3 = (uint) (num13 ^ num2)) % 9U)
        {
          case 0:
            num13 = (int) num3 * 1843583523 ^ 1830985020;
            continue;
          case 2:
            goto label_50;
          case 3:
            goto label_45;
          case 4:
            num13 = (int) num3 * -481746472 ^ 1832298912;
            continue;
          case 5:
            if (!flag1)
            {
              num13 = (int) num3 * 291198289 ^ -517725131;
              continue;
            }
            goto label_9;
          case 6:
            goto label_41;
          case 7:
            goto label_39;
          case 8:
            goto label_48;
          default:
            goto label_52;
        }
      }
label_45:
      int num14 = zoomWindow1 == null ? 1 : 0;
      goto label_47;
label_41:
      num13 = -1792323053;
      goto label_40;
label_47:
      flag1 = num14 != 0;
      num13 = -499690258;
      goto label_40;
label_48:
      if (!(dateTime > DateTime.Now))
      {
        num14 = 0;
        goto label_47;
      }
      else
      {
        num13 = -635381552;
        goto label_40;
      }
label_50:
      zoomWindow2 = zoomWindow1;
      num13 = -2017876876;
      goto label_40;
label_52:
      return zoomWindow2;
    }

    internal override bool Valid()
    {
      if (!this.ChatOptions.IsValid)
        goto label_7;
label_1:
      int num1 = 1835754269;
label_2:
      bool flag;
      while (true)
      {
        int num2 = 653487860;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            flag = false;
            num1 = (int) num3 * -1716469487 ^ -471416965;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -544867151 ^ -121130437;
            continue;
          case 5:
            num1 = (int) num3 * -110974783 ^ 1606512392;
            continue;
          case 6:
            flag = true;
            num1 = (int) num3 * 62683361 ^ -391424682;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return flag;
label_7:
      num1 = 614080035;
      goto label_2;
    }

    static void \u200E​‮⁪‎‭⁭⁪⁯⁫⁯⁪‫‍‮‍⁬‎​⁫‮​​⁫‍‪⁪‏‬⁮⁪⁬⁬⁯‌‫⁬‍‎‎‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206A‫‎⁯⁭⁬⁬‪⁫⁭‌‫‌⁫‪‫⁭‮‮‮‪‏‌‫‎‭‪⁪‍‬‎‍‎⁬‫‮‭‪‭‭‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static bool \u202E⁯‭‏⁭‎‍‪‬⁯⁯​‎‌⁪‎‬⁮⁫‎‎‬‏‪‬‮‎⁫‮‭⁭⁯⁪​⁭‪‫⁫⁫⁬‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static void \u202A⁫‎‫⁪‍‍‪‫⁭⁫⁫‭‫‍⁯‍​‬⁮‭⁪⁮‭‎⁫‫‮‭‌⁬⁭⁭‌‬⁪⁯⁫‪⁪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static void \u200C‎‎​‍⁬‌‭⁯‌‌⁬⁬‬‫‬‏‍‫⁫‍‪‍‌⁬‮⁪‮⁮⁮‍‪⁬‪‭​‬‮⁫⁯‮([In] object obj0, [In] bool obj1, [In] int obj2, [In] int obj3)
    {
      Clipboard.SetDataObject(obj0, obj1, obj2, obj3);
    }

    static void \u206C⁯‬‭​⁯⁭⁪‭‮⁬⁬‏⁬⁭‏‬‫‭‎‌⁪‭‏​‪‪⁪‮⁯​‮⁭⁫‌‪⁪‏​‪‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static StringBuilder \u202B‌⁭‎⁫‭​⁭‏⁭⁮⁪‏⁫‎‬‫‏‪‬‪‌‮⁬⁭⁮‫⁬⁪⁬⁮⁬‫‮‬‮‮⁫⁮⁬‮([In] int obj0)
    {
      return new StringBuilder(obj0);
    }

    static bool \u200B⁯⁪⁬‎⁭‫⁭⁬‭‪‏⁭‭⁬⁮‎⁭⁫‮‎‌‭‏⁬‏⁮​‪‪‌⁮‍‏⁮‪⁮​⁫‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }
  }
}
