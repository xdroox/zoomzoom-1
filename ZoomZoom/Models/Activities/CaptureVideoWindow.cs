// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.CaptureVideoWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Images;

namespace ZoomZoom.Models.Activities
{
  public class CaptureVideoWindow : ActivityBase
  {
    private ZoomWindow window = (ZoomWindow) null;
    private ZoomWindow chatwindow = (ZoomWindow) null;
    private string userName = "";
    private ZoomImage videoImage = (ZoomImage) null;
    private ZoomImage chatImage = (ZoomImage) null;
    private ZoomUser user = (ZoomUser) null;
    private ZoomChat chat = (ZoomChat) null;
    private string message = "";
    private bool detectUserNameViaChat = true;
    private const string ImageNotAcquired = "Image not acquired";
    private const string ImageAcquired = "Image acquired";
    private const string WindowNotVisible = "Window not visible";
    private const string WindowVisible = "Window visible";
    private const string WindowNotNull = "Window is not null";
    private const string WindowNull = "Window is null";

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -1271890107;
        TraceType traceType;
        while (true)
        {
          int num2 = -736641318;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1376791305 ^ 1056227582;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public ZoomWindow Window
    {
      get
      {
        ZoomWindow window = this.window;
label_1:
        int num1 = 625126633;
        while (true)
        {
          int num2 = 486376876;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1791614733 ^ -1687266562;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return window;
      }
      set
      {
        this.window = value;
label_1:
        int num1 = -505028285;
        while (true)
        {
          int num2 = -669424507;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 1223045059 ^ -1764967370;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3231260057U));
              num1 = (int) num3 * -1921301089 ^ -361890166;
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

    public string UserName
    {
      get
      {
label_1:
        int num1 = -170119618;
        string userName;
        while (true)
        {
          int num2 = -765010965;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              userName = this.userName;
              num1 = (int) num3 * 459003394 ^ -515299661;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return userName;
      }
      set
      {
        this.userName = value;
label_1:
        int num1 = -334892645;
        while (true)
        {
          int num2 = -1774001623;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1959159945U));
              num1 = (int) num3 * -2020474581 ^ 745903928;
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

    public ZoomImage VideoImage
    {
      get
      {
label_1:
        int num1 = 776488472;
        ZoomImage videoImage;
        while (true)
        {
          int num2 = 884196482;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1004754977 ^ -937166014;
              continue;
            case 2:
              videoImage = this.videoImage;
              num1 = (int) num3 * 1998021906 ^ 244795979;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return videoImage;
      }
      set
      {
label_1:
        int num1 = 1389786196;
        while (true)
        {
          int num2 = 2115365327;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2858089447U));
              num1 = (int) num3 * 648733624 ^ 973526062;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.videoImage = value;
              num1 = (int) num3 * -1424134208 ^ -1898183353;
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

    public ZoomImage ChatImage
    {
      get
      {
label_1:
        int num1 = -1468016632;
        ZoomImage chatImage;
        while (true)
        {
          int num2 = -1247282509;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              chatImage = this.chatImage;
              num1 = (int) num3 * -508722127 ^ 481710341;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return chatImage;
      }
      set
      {
        this.chatImage = value;
label_1:
        int num1 = 1764297391;
        while (true)
        {
          int num2 = 442893653;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 193192032 ^ -589734267;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3465626473U));
              num1 = (int) num3 * 989690187 ^ -1848262678;
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

    public ZoomUser User
    {
      get
      {
label_1:
        int num1 = -810106067;
        ZoomUser user;
        while (true)
        {
          int num2 = -680982845;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              user = this.user;
              num1 = (int) num3 * 560769483 ^ 1265994427;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return user;
      }
      set
      {
label_1:
        int num1 = -1224608046;
        while (true)
        {
          int num2 = -473307946;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -1284961291 ^ -877710239;
              continue;
            case 1:
              this.user = value;
              num1 = (int) num3 * -720496470 ^ -1540782612;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1909431601U));
              num1 = (int) num3 * -338306233 ^ -1338698547;
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

    public string Message
    {
      get
      {
        return this.message;
      }
      set
      {
        this.message = value;
      }
    }

    public ZoomChat Chat
    {
      get
      {
label_1:
        int num1 = 404384698;
        ZoomChat chat;
        while (true)
        {
          int num2 = 366736332;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              chat = this.chat;
              num1 = (int) num3 * -845320898 ^ -1499546640;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chat;
      }
      set
      {
label_1:
        int num1 = -878102479;
        while (true)
        {
          int num2 = -1440931832;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.chat = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3289301095U));
              num1 = (int) num3 * -64843756 ^ -448280913;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * -686468790 ^ -2060841632;
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

    public ZoomWindow Chatwindow
    {
      get
      {
label_1:
        int num1 = -2122306645;
        ZoomWindow chatwindow;
        while (true)
        {
          int num2 = -1434676002;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              chatwindow = this.chatwindow;
              num1 = (int) num3 * -1255143126 ^ 111516758;
              continue;
            case 2:
              num1 = (int) num3 * 2066805418 ^ 315359357;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return chatwindow;
      }
      set
      {
        this.chatwindow = value;
      }
    }

    public bool DetectUserNameViaChat
    {
      get
      {
label_1:
        int num1 = -1556721162;
        bool detectUserNameViaChat;
        while (true)
        {
          int num2 = -1713737685;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              detectUserNameViaChat = this.detectUserNameViaChat;
              num1 = (int) num3 * -60762245 ^ 249144886;
              continue;
            case 2:
              num1 = (int) num3 * -1147568771 ^ -1606989290;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return detectUserNameViaChat;
      }
      set
      {
        this.detectUserNameViaChat = value;
label_1:
        int num1 = 1114799085;
        while (true)
        {
          int num2 = 1281356680;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1175360223 ^ -1049890754;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2301467116U));
              num1 = (int) num3 * 1718281590 ^ -1209032622;
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

    public CaptureVideoWindow()
    {
label_1:
      int num1 = 548720258;
      while (true)
      {
        int num2 = 141504699;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 713705969 ^ -784904571;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 534568891 ^ 323674522;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public CaptureVideoWindow(ZoomWindow window)
    {
      this.Window = window;
    }

    protected new void SetActivityState(ActivityState state, string newStatusMessage = "")
    {
label_1:
      int num1 = 2040365576;
      while (true)
      {
        int num2 = 2083227860;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            this.DisplayImageHistoryView();
            num1 = (int) num3 * -1884751530 ^ -1529979691;
            continue;
          case 2:
            num1 = (int) num3 * -1548789633 ^ -499150697;
            continue;
          case 3:
            goto label_3;
          case 4:
            if (this.ActivityState != ActivityState.Hold)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 2003784892 ^ -1706881038;
            continue;
          case 5:
            base.SetActivityState(state, newStatusMessage);
            num1 = 2028202663;
            continue;
          case 6:
            num4 = state == ActivityState.Completed ? 1 : 0;
            break;
          case 7:
            num1 = (int) num3 * 1490963312 ^ 1422624966;
            continue;
          default:
            goto label_13;
        }
        int num5;
        num1 = num5 = num4 != 0 ? 1803842317 : (num5 = 326278761);
      }
label_13:
      return;
label_3:;
    }

    private bool CaptureImage()
    {
      bool flag1 = this.VideoImage != null;
label_1:
      int num1 = -501681781;
      bool flag2;
      while (true)
      {
        int num2 = -971733347;
        uint num3;
        bool isVisible;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 28U)
        {
          case 0:
            num1 = (int) num3 * -112474421 ^ 1506408781;
            continue;
          case 1:
            flag2 = true;
            num1 = (int) num3 * 335411603 ^ -1303618615;
            continue;
          case 2:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1865925124U));
            num1 = (int) num3 * 2115583055 ^ 1648783557;
            continue;
          case 3:
            int num4 = !isVisible ? -192115474 : (num4 = -250409086);
            int num5 = (int) num3 * -1542414580;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 940661910 ^ 371366460;
            continue;
          case 6:
            num1 = (int) num3 * -1456392755 ^ 751816020;
            continue;
          case 7:
            flag2 = true;
            num1 = (int) num3 * -365911142 ^ -1049184931;
            continue;
          case 8:
            int num6;
            num1 = num6 = this.Window != null ? -203077800 : (num6 = -445208412);
            continue;
          case 9:
            this.Window.Refresh(false, true);
            num1 = (int) num3 * -271257019 ^ -1390592333;
            continue;
          case 10:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2313226145U));
            num1 = (int) num3 * 1416676596 ^ 169927579;
            continue;
          case 11:
            this.VideoImage = this.Engine.CaptureImage(this.Window, Rectangle.Empty, ImageEnums.ImageType.Video, (ImageOptions) null);
            num1 = (int) num3 * 27246491 ^ 231539672;
            continue;
          case 12:
            num1 = -429117041;
            continue;
          case 13:
            num1 = (int) num3 * 895123355 ^ 643380551;
            continue;
          case 14:
            num1 = (int) num3 * -620006772 ^ 523078177;
            continue;
          case 15:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2664793150U));
            num1 = -881291131;
            continue;
          case 16:
            flag2 = false;
            num1 = -913149904;
            continue;
          case 17:
            num1 = -955456021;
            continue;
          case 18:
            num1 = (int) num3 * -105894005 ^ 1789992419;
            continue;
          case 20:
            num1 = (int) num3 * -837689082 ^ 291319697;
            continue;
          case 21:
            int num7 = flag3 ? -2126947290 : (num7 = -105971984);
            int num8 = (int) num3 * -107615050;
            num1 = num7 ^ num8;
            continue;
          case 22:
            num1 = (int) num3 * 422322664 ^ -171887671;
            continue;
          case 23:
            isVisible = this.Window.IsVisible;
            num1 = (int) num3 * -778382968 ^ -940324514;
            continue;
          case 24:
            flag3 = this.VideoImage != null;
            num1 = (int) num3 * 2046318742 ^ -1442694316;
            continue;
          case 25:
            num1 = (int) num3 * 821144319 ^ -1369946681;
            continue;
          case 26:
            int num9 = !flag1 ? 20757761 : (num9 = 2071544238);
            int num10 = (int) num3 * -1543678776;
            num1 = num9 ^ num10;
            continue;
          case 27:
            num1 = -871192853;
            continue;
          default:
            goto label_29;
        }
      }
label_29:
      return flag2;
    }

    private bool InitiateChat()
    {
label_1:
      int num1 = 1410131763;
      bool flag1;
      while (true)
      {
        int num2 = 903144501;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            goto label_54;
          case 2:
            int num4 = CaptureVideoWindow.\u202B⁫‮‮⁯⁪⁭‎‬⁫⁬‍‮​‬‌‬​‫‏‮‬⁫⁯‌‪‬⁫‬‭⁬⁪‎​⁯‍⁯‎‭⁯‮(this.Message) ? -334914325 : (num4 = -87382331);
            int num5 = (int) num3 * -612388198;
            num1 = num4 ^ num5;
            continue;
          case 3:
            flag1 = true;
            num1 = (int) num3 * 238879043 ^ -779831546;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag2 = false;
      System.Drawing.Point pt;
      ZoomZoom.NativeMethods.GetCursorPos(out pt);
      try
      {
label_7:
        int num2 = 1452030557;
        while (true)
        {
          int num3 = 903144501;
          uint num4;
          int X;
          int Y;
          Size size;
          ZoomWindow window;
          System.Drawing.Point location;
          bool flag3;
          switch ((num4 = (uint) (num2 ^ num3)) % 39U)
          {
            case 0:
              Thread.Sleep(40);
              num2 = (int) num4 * 1792129398 ^ -855915970;
              continue;
            case 2:
              Thread.Sleep(40);
              num2 = (int) num4 * 964561720 ^ -1356080372;
              continue;
            case 3:
              int width = size.Width;
              size = window.Size;
              int num5 = size.Width - 20;
              int num6 = width <= num5 ? -1577385748 : (num6 = -788772956);
              int num7 = (int) num4 * 851661040;
              num2 = num6 ^ num7;
              continue;
            case 4:
              X += 25;
              num2 = (int) num4 * 555066078 ^ 409283767;
              continue;
            case 5:
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              num2 = (int) num4 * -1409283194 ^ 854595365;
              continue;
            case 6:
              num2 = (int) num4 * -594345892 ^ 1596672554;
              continue;
            case 7:
              num2 = (int) num4 * 816480808 ^ 1301753809;
              continue;
            case 8:
              location = this.Window.Location;
              num2 = (int) num4 * 268311110 ^ 363706512;
              continue;
            case 9:
              Thread.Sleep(40);
              User32.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num2 = (int) num4 * -2070961454 ^ -1418802537;
              continue;
            case 10:
              flag2 = true;
              num2 = (int) num4 * 943438466 ^ -1542636730;
              continue;
            case 11:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2596421557U));
              num2 = (int) num4 * -342681000 ^ 537464121;
              continue;
            case 12:
              goto label_54;
            case 13:
              num2 = (int) num4 * 1242689173 ^ 172111288;
              continue;
            case 14:
              num2 = (int) num4 * 1148473140 ^ -1916205598;
              continue;
            case 15:
              flag2 = false;
              num2 = (int) num4 * 278445684 ^ -1603644773;
              continue;
            case 16:
              Y += 25;
              User32.SetCursorPos(X, Y);
              num2 = (int) num4 * 113878929 ^ -1463185837;
              continue;
            case 17:
              X = location.X + 25;
              num2 = (int) num4 * 502120852 ^ -1286032293;
              continue;
            case 18:
              this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1245502818U));
              num2 = (int) num4 * -230786450 ^ -1669901861;
              continue;
            case 19:
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              num2 = (int) num4 * 484272364 ^ 1053150257;
              continue;
            case 20:
              num2 = (int) num4 * 556808079 ^ 662600644;
              continue;
            case 21:
              window = this.Engine.GetWindow(ZoomWindowType.Meeting);
              int num8 = window == null ? -1768970107 : (num8 = -1293615864);
              int num9 = (int) num4 * -1985826803;
              num2 = num8 ^ num9;
              continue;
            case 22:
              location = this.Window.Location;
              num2 = (int) num4 * -1783851669 ^ -313378072;
              continue;
            case 23:
              flag1 = false;
              num2 = (int) num4 * -782170407 ^ 684811245;
              continue;
            case 24:
              num2 = (int) num4 * 1008594302 ^ 244995153;
              continue;
            case 25:
              num2 = (int) num4 * -1796232769 ^ 1372312308;
              continue;
            case 26:
              Y = location.Y + 25;
              num2 = (int) num4 * 456533374 ^ 530850533;
              continue;
            case 27:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(24883719U));
              num2 = (int) num4 * -1965765990 ^ 2001244743;
              continue;
            case 28:
              Thread.Sleep(40);
              num2 = (int) num4 * 1551343669 ^ 1093815249;
              continue;
            case 29:
              num2 = (int) num4 * -1938734900 ^ -767384567;
              continue;
            case 30:
              goto label_7;
            case 31:
              User32.SetCursorPos(X, Y);
              num2 = (int) num4 * -1549562320 ^ 1488399715;
              continue;
            case 32:
              User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
              num2 = (int) num4 * 1289796243 ^ -1523782824;
              continue;
            case 33:
              num2 = 337604733;
              continue;
            case 34:
              User32.SetCursorPos(X, Y);
              num2 = (int) num4 * 1226815439 ^ -189618651;
              continue;
            case 35:
              flag3 = this.Engine.GetWindow(ZoomWindowType.Chat) == null;
              num2 = 1416126673;
              continue;
            case 36:
              int num10 = flag3 ? 333792798 : (num10 = 474173852);
              int num11 = (int) num4 * 344533233;
              num2 = num10 ^ num11;
              continue;
            case 37:
              size = this.Window.Size;
              num2 = 1451385676;
              continue;
            case 38:
              goto label_22;
            default:
              goto label_50;
          }
        }
label_22:
        flag1 = false;
        goto label_54;
      }
      catch (Exception ex)
      {
label_46:
        int num2 = 1463394554;
        while (true)
        {
          int num3 = 903144501;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              num2 = (int) num4 * -1827182909 ^ -818167244;
              continue;
            case 2:
              goto label_46;
            case 3:
              CoreObject.log.Error((object) ex);
              num2 = (int) num4 * 1416970734 ^ -472257165;
              continue;
            default:
              goto label_50;
          }
        }
      }
label_50:
      User32.SetCursorPos(pt.X, pt.Y);
label_51:
      int num12 = 209392542;
      while (true)
      {
        int num2 = 903144501;
        uint num3;
        switch ((num3 = (uint) (num12 ^ num2)) % 3U)
        {
          case 0:
            goto label_51;
          case 2:
            flag1 = flag2;
            num12 = (int) num3 * -2143924676 ^ -16754751;
            continue;
          default:
            goto label_54;
        }
      }
label_54:
      return flag1;
    }

    private bool CaptureChat()
    {
label_1:
      int num1 = -1984508961;
      bool flag1;
      while (true)
      {
        int num2 = -622575803;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            flag1 = true;
            num1 = (int) num3 * 1771203886 ^ -1899167433;
            continue;
          case 2:
            int num5 = !flag2 ? 1594975399 : (num5 = 1058855844);
            int num6 = (int) num3 * 1909079063;
            num1 = num5 ^ num6;
            continue;
          case 3:
            goto label_31;
          case 5:
            if (this.ChatImage == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1891401023 ^ 724274619;
            continue;
          case 6:
            num4 = !CaptureVideoWindow.\u202B⁫‮‮⁯⁪⁭‎‬⁫⁬‍‮​‬‌‬​‫‏‮‬⁫⁯‌‪‬⁫‬‭⁬⁪‎​⁯‍⁯‎‭⁯‮(this.Message) ? 1 : 0;
            break;
          default:
            goto label_10;
        }
        flag2 = num4 != 0;
        num1 = -483010133;
      }
label_10:
      bool flag3 = false;
      try
      {
        int num2 = 70;
        int height = 16;
        int x = 50;
label_12:
        int num3 = -295434793;
        while (true)
        {
          int num4 = -622575803;
          uint num5;
          int num6;
          Rectangle region;
          switch ((num5 = (uint) (num3 ^ num4)) % 11U)
          {
            case 0:
              region = new Rectangle(new System.Drawing.Point(x, this.window.Size.Height - num2 - height), new Size(this.window.Size.Width - x - num6, height));
              this.Chatwindow = this.Engine.GetWindow(ZoomWindowType.Chat);
              num3 = (int) num5 * 1654302689 ^ -491186495;
              continue;
            case 1:
              this.MinimizeWindows(this.Chatwindow);
              num3 = (int) num5 * -1062638718 ^ 1341427470;
              continue;
            case 2:
              num3 = (int) num5 * 1895402310 ^ -1565729525;
              continue;
            case 3:
              this.ChatImage = this.Engine.CaptureImage(this.Chatwindow, region, ImageEnums.ImageType.ChatSelector, new ImageOptions()
              {
                DisplayAfterCapture = false,
                SaveToDisk = true,
                DisplayHighlightWindow = true
              });
              num3 = (int) num5 * 370818276 ^ -1695260820;
              continue;
            case 4:
              num3 = (int) num5 * 1314549841 ^ 369109309;
              continue;
            case 5:
              num6 = 80;
              num3 = (int) num5 * -1791270014 ^ 2084006950;
              continue;
            case 6:
              num3 = (int) num5 * 1169542055 ^ 82578519;
              continue;
            case 7:
              goto label_12;
            case 8:
              this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1033202217U));
              num3 = (int) num5 * -849700104 ^ -449712437;
              continue;
            case 9:
              this.Chatwindow.RefreshLocation();
              num3 = (int) num5 * -551229663 ^ -634151784;
              continue;
            default:
              goto label_27;
          }
        }
      }
      catch (Exception ex)
      {
label_24:
        int num2 = -956154099;
        while (true)
        {
          int num3 = -622575803;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_24;
            case 1:
              CoreObject.log.Error((object) ex);
              num2 = (int) num4 * -1224458000 ^ -570823637;
              continue;
            default:
              goto label_27;
          }
        }
      }
label_27:
      flag1 = flag3;
label_28:
      int num7 = -1468763037;
      while (true)
      {
        int num2 = -622575803;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 3U)
        {
          case 0:
            goto label_28;
          case 2:
            num7 = (int) num3 * -316452324 ^ -1284801677;
            continue;
          default:
            goto label_31;
        }
      }
label_31:
      return flag1;
    }

    private bool SaveResults()
    {
label_1:
      int num1 = 1527039198;
      bool flag1;
      while (true)
      {
        int num2 = 1380627031;
        uint num3;
        bool flag2;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            goto label_1;
          case 1:
            this.SetActivityState(ActivityState.Hold, CaptureVideoWindow.\u200C⁫‌‪‮⁮⁯⁮‎‌​‎‍‪⁫‫‪​⁬‌‌‬⁬⁯‬‫‮‫‍‍‫‪‎​‮⁮‫‎⁫⁬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2271365119U), new object[0]));
            num1 = (int) num3 * 587378620 ^ -408764912;
            continue;
          case 2:
            num1 = (int) num3 * 1356594053 ^ -1163381605;
            continue;
          case 3:
            this.User = this.Engine.GetUser(this.UserName, true);
            this.VideoImage.User = this.User;
            num1 = (int) num3 * 1336521670 ^ -1574680723;
            continue;
          case 4:
            this.Engine.HoldActivity(this.Message, (ActivityBase) this);
            num1 = 708758178;
            continue;
          case 5:
            int num4 = !flag3 ? -302361631 : (num4 = -2034149962);
            int num5 = (int) num3 * -526669242;
            num1 = num4 ^ num5;
            continue;
          case 6:
            this.VideoImage.SaveDatabaseObject();
            this.DisplayImageHistoryView();
            num1 = (int) num3 * -388921188 ^ -1336515468;
            continue;
          case 7:
            flag1 = flag2;
            num1 = 789440809;
            continue;
          case 8:
            num1 = (int) num3 * -1408014314 ^ -956451095;
            continue;
          case 9:
            flag2 = false;
            flag3 = !CaptureVideoWindow.\u202B⁫‮‮⁯⁪⁭‎‬⁫⁬‍‮​‬‌‬​‫‏‮‬⁫⁯‌‪‬⁫‬‭⁬⁪‎​⁯‍⁯‎‭⁯‮(this.UserName);
            num1 = (int) num3 * 719439595 ^ -106858895;
            continue;
          case 11:
            num1 = (int) num3 * -1532071017 ^ 47906401;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return flag1;
    }

    private void DisplayImageHistoryView()
    {
label_1:
      int num1 = 257429777;
      while (true)
      {
        int num2 = 1009877632;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            int num4 = this.Engine != null ? -257865160 : (num4 = -132939453);
            int num5 = (int) num3 * -1840547813;
            num1 = num4 ^ num5;
            continue;
          case 2:
            this.Engine.DisplayImages(new List<ZoomImage>()
            {
              this.VideoImage,
              this.ChatImage
            });
            num1 = (int) num3 * 364916395 ^ 78182132;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1185191930 ^ 1307263132;
            continue;
          case 5:
            num1 = (int) num3 * -458502587 ^ -1015402959;
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
label_1:
      int num1 = 289259013;
      while (true)
      {
        int num2 = 1881478643;
        uint num3;
        bool flag1;
        bool flag2;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 34U)
        {
          case 0:
            num4 = this.Engine.GetOverlappedWindows(this.Window).Count == 0 ? 1 : 0;
            goto label_37;
          case 1:
            num1 = (int) num3 * 1490994874 ^ 995076038;
            continue;
          case 2:
            this.SetActivityState(ActivityState.Completed, CaptureVideoWindow.\u206D⁪‌⁪⁪‭‫⁭‫‮⁬⁬‍⁬‏⁬​⁭⁭‍‏⁪‫⁬⁯‪‪‮‎⁭‬⁬‌⁮‫⁮⁬‎⁪‭‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(771170762U), (object) this.UserName));
            num1 = (int) num3 * 1697229335 ^ 725269509;
            continue;
          case 3:
            num1 = 481510248;
            continue;
          case 4:
            num1 = (int) num3 * 279614027 ^ 935112643;
            continue;
          case 5:
            int num6 = !flag2 ? 1454941751 : (num6 = 164425336);
            int num7 = (int) num3 * 463026737;
            num1 = num6 ^ num7;
            continue;
          case 6:
            goto label_3;
          case 7:
            this.RestoreWindows();
            num1 = 1539544825;
            continue;
          case 8:
            this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1895456783U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3233434380U));
            num1 = (int) num3 * 984967984 ^ -947830225;
            continue;
          case 9:
            this.SetActivityState(ActivityState.Hold, CaptureVideoWindow.\u200C⁫‌‪‮⁮⁯⁮‎‌​‎‍‪⁫‫‪​⁬‌‌‬⁬⁯‬‫‮‫‍‍‫‪‎​‮⁮‫‎⁫⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(119792445U), new object[0]));
            num1 = (int) num3 * -1536893422 ^ 1538157023;
            continue;
          case 10:
            num1 = (int) num3 * 1201937485 ^ -1276252412;
            continue;
          case 11:
            goto label_1;
          case 12:
            num1 = (int) num3 * -1235170343 ^ 475663506;
            continue;
          case 13:
            this.MinimizeWindows(this.Window);
            num1 = (int) num3 * -909794864 ^ -78101595;
            continue;
          case 14:
            this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1608952185U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3233434380U));
            num1 = (int) num3 * -292507723 ^ 1907655950;
            continue;
          case 15:
            this.SetActivityState(ActivityState.Completed, CaptureVideoWindow.\u200C⁫‌‪‮⁮⁯⁮‎‌​‎‍‪⁫‫‪​⁬‌‌‬⁬⁯‬‫‮‫‍‍‫‪‎​‮⁮‫‎⁫⁬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(139683934U), new object[0]));
            num1 = 329601110;
            continue;
          case 16:
            num1 = 535036067;
            continue;
          case 17:
            this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(839145193U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2005217345U));
            flag1 = this.CaptureChat();
            num1 = (int) num3 * -53860719 ^ 618622295;
            continue;
          case 18:
            num1 = (int) num3 * 102897709 ^ -613385658;
            continue;
          case 19:
            num1 = (int) num3 * -1386748884 ^ -839337708;
            continue;
          case 20:
            num1 = (int) num3 * -1396112894 ^ 409858847;
            continue;
          case 21:
            flag2 = this.SaveResults();
            num1 = (int) num3 * -1744757936 ^ 1253673054;
            continue;
          case 22:
            if (this.DetectUserNameViaChat)
            {
              num1 = (int) num3 * 1559139697 ^ -854669589;
              continue;
            }
            num5 = 0;
            break;
          case 23:
            num1 = 236962119;
            continue;
          case 24:
            num1 = (int) num3 * 1583111245 ^ 417919945;
            continue;
          case 25:
            this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1894986158U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2005217345U));
            int num8;
            num1 = num8 = !this.CaptureImage() ? 329042604 : (num8 = 1571205430);
            continue;
          case 26:
            num5 = this.InitiateChat() ? 1 : 0;
            break;
          case 27:
            num1 = (int) num3 * 913363403 ^ 570210950;
            continue;
          case 28:
            if (!this.Options.MinimizeOverlappedWindows)
            {
              num1 = (int) num3 * 900845145 ^ 781526839;
              continue;
            }
            num4 = 1;
            goto label_37;
          case 29:
            num1 = 329042604;
            continue;
          case 30:
            num1 = (int) num3 * 1012187052 ^ -1534319272;
            continue;
          case 31:
            num1 = 1239242056;
            continue;
          case 32:
            num1 = (int) num3 * 633567025 ^ -561427900;
            continue;
          case 33:
            int num9 = flag1 ? -708517561 : (num9 = -2129243153);
            int num10 = (int) num3 * -353993586;
            num1 = num9 ^ num10;
            continue;
          default:
            goto label_42;
        }
        int num11;
        num1 = num11 = num5 != 0 ? 1414209532 : (num11 = 1938314444);
        continue;
label_37:
        int num12;
        num1 = num12 = num4 != 0 ? 1592367006 : (num12 = 741847944);
      }
label_42:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 987897772;
      bool flag;
      while (true)
      {
        int num2 = 1916752696;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            flag = true;
            num1 = (int) num3 * -552034381 ^ 2051814304;
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

    static bool \u202B⁫‮‮⁯⁪⁭‎‬⁫⁬‍‮​‬‌‬​‫‏‮‬⁫⁯‌‪‬⁫‬‭⁬⁪‎​⁯‍⁯‎‭⁯‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static string \u200C⁫‌‪‮⁮⁯⁮‎‌​‎‍‪⁫‫‪​⁬‌‌‬⁬⁯‬‫‮‫‍‍‫‪‎​‮⁮‫‎⁫⁬‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u206D⁪‌⁪⁪‭‫⁭‫‮⁬⁬‍⁬‏⁬​⁭⁭‍‏⁪‫⁬⁯‪‪‮‎⁭‬⁬‌⁮‫⁮⁬‎⁪‭‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }
  }
}
