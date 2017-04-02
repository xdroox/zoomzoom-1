// Decompiled with JetBrains decompiler
// Type: ZoomZoom.VideoChatLink
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Activities;

namespace ZoomZoom
{
  public class VideoChatLink : CoreObject
  {
    private static readonly object linkLock = VideoChatLink.\u200F‪‪⁬⁯⁮⁪⁭​‫⁯‪‭‌‌‭‪⁪​‌​‭‮‫‬‬​‎⁯‎‫‭‪‫‍⁭⁪‍​⁮‮();
    private static bool videoRightClicked = false;
    private static bool videoChatMenuItemClicked = false;
    private ZoomWindow videoWindow = (ZoomWindow) null;
    private ZoomWindow chatWindow = (ZoomWindow) null;
    private IntPtr handle = IntPtr.Zero;
    private string trackingMessage = string.Empty;
    private string userName = string.Empty;
    private bool pictureCaptured = false;
    private string pictureFileName = string.Empty;
    private Bitmap chatSelectorPicture = (Bitmap) null;
    private Bitmap windowImage = (Bitmap) null;
    private bool chatSelectPictureCaptured = false;
    private static bool chatSent;
    private static bool chatLinked;
    private DateTime dtCreated;
    private DateTime dtFinalized;
    private InspectVideoWindow linkActivity;

    public bool VideoRightClicked
    {
      get
      {
label_1:
        int num1 = -1598348069;
        bool videoRightClicked;
        while (true)
        {
          int num2 = -660509562;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1756889837 ^ -1244737079;
              continue;
            case 1:
              videoRightClicked = VideoChatLink.videoRightClicked;
              num1 = (int) num3 * -93924680 ^ 383395050;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return videoRightClicked;
      }
      set
      {
label_1:
        int num1 = 322234765;
        while (true)
        {
          int num2 = 1341224222;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = !flag ? 2053809783 : (num4 = 1242031557);
              int num5 = (int) num3 * 282280937;
              num1 = num4 ^ num5;
              continue;
            case 1:
              num1 = (int) num3 * 2114747550 ^ 1564785536;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              flag = VideoChatLink.videoRightClicked == value;
              num1 = (int) num3 * -2076493228 ^ 161823195;
              continue;
            case 5:
              VideoChatLink.videoRightClicked = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3534560690U));
              num1 = 840908613;
              continue;
            case 6:
              num1 = (int) num3 * 100889643 ^ 1638859476;
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

    public ZoomWindow VideoWindow
    {
      get
      {
        ZoomWindow videoWindow = this.videoWindow;
label_1:
        int num1 = -216248794;
        while (true)
        {
          int num2 = -1072531807;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1336816572 ^ -473738771;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return videoWindow;
      }
      set
      {
label_1:
        int num1 = -1406773743;
        while (true)
        {
          int num2 = -1827547340;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = flag ? 1446249242 : (num4 = 1403426523);
              int num5 = (int) num3 * 894381488;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1480411732U));
              num1 = (int) num3 * 1990763909 ^ -1839650973;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.videoWindow = value;
              num1 = -1403757840;
              continue;
            case 5:
              flag = this.videoWindow == value;
              num1 = (int) num3 * 1746493164 ^ -311613070;
              continue;
            case 6:
              num1 = (int) num3 * -1673048255 ^ 449649913;
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

    public IntPtr Handle
    {
      get
      {
        return this.handle;
      }
      set
      {
label_1:
        int num1 = 295223172;
        while (true)
        {
          int num2 = 1507905434;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 129790233 ^ -2059908961;
              continue;
            case 2:
              num1 = (int) num3 * 18332705 ^ 671996760;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = this.handle == value ? 1551750240 : (num4 = 2022159629);
              int num5 = (int) num3 * -611001757;
              num1 = num4 ^ num5;
              continue;
            case 5:
              this.handle = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1552791208U));
              num1 = 1476166949;
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

    public string TrackingMessage
    {
      get
      {
label_1:
        int num1 = -1515142372;
        string trackingMessage;
        while (true)
        {
          int num2 = -1020009652;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1740596879 ^ -1905840832;
              continue;
            case 1:
              trackingMessage = this.trackingMessage;
              num1 = -829653880;
              continue;
            case 2:
              num1 = (int) num3 * 82176147 ^ 172981652;
              continue;
            case 4:
              this.trackingMessage = this.Engine.Settings.GetMessageText(this.Engine.Settings.VideoChatLinkMessageSource);
              num1 = (int) num3 * -1639085374 ^ 1826816517;
              continue;
            case 5:
              int num4 = !VideoChatLink.\u206B⁫‌⁭⁮⁬‫⁪‍⁫‮⁯‭‮⁯‮⁬‏‮‫‫‭⁮‎⁫‮‎⁬⁪‏‫‭‮⁪‎⁫‪‪⁮‍‮(this.trackingMessage, string.Empty) ? -801922175 : (num4 = -2046353113);
              int num5 = (int) num3 * 10139187;
              num1 = num4 ^ num5;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return trackingMessage;
      }
      set
      {
label_1:
        int num1 = 211175489;
        while (true)
        {
          int num2 = 1507547016;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = VideoChatLink.\u200E⁪⁭‭⁪‍⁬‍‫‬‍‎⁬‫‏‭‫‭‫‮⁮‌⁮‌​‪‎‎​‏⁭‭⁫⁬‫⁬‎‏‫‭‮(this.trackingMessage, value) ? -806913692 : (num4 = -1658897988);
              int num5 = (int) num3 * -174430959;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(133111677U));
              num1 = (int) num3 * -551836670 ^ 785175686;
              continue;
            case 3:
              num1 = (int) num3 * 1112936236 ^ 1604861998;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.trackingMessage = value;
              num1 = 1031782098;
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

    public string UserName
    {
      get
      {
label_1:
        int num1 = -1030645804;
        string userName;
        while (true)
        {
          int num2 = -1033549731;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              userName = this.userName;
              num1 = (int) num3 * 2073782711 ^ -1338915023;
              continue;
            case 3:
              num1 = (int) num3 * -2109444455 ^ 1040122996;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return userName;
      }
      set
      {
label_1:
        int num1 = 1648157626;
        while (true)
        {
          int num2 = 1604986660;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1280408212 ^ -759171405;
              continue;
            case 1:
              flag = VideoChatLink.\u200E⁪⁭‭⁪‍⁬‍‫‬‍‎⁬‫‏‭‫‭‫‮⁮‌⁮‌​‪‎‎​‏⁭‭⁫⁬‫⁬‎‏‫‭‮(this.userName, value);
              num1 = (int) num3 * -1493727844 ^ 1283282211;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.userName = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2587971764U));
              num1 = 559398212;
              continue;
            case 4:
              goto label_3;
            case 5:
              num1 = (int) num3 * 1142731929 ^ -1973771705;
              continue;
            case 6:
              int num4 = flag ? -1511650803 : (num4 = -2062007743);
              int num5 = (int) num3 * -1707408077;
              num1 = num4 ^ num5;
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

    public DateTime DateCreated
    {
      get
      {
        DateTime dtCreated = this.dtCreated;
label_1:
        int num1 = -1915056953;
        while (true)
        {
          int num2 = -1418619201;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1733314821 ^ 1719420182;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dtCreated;
      }
      set
      {
        bool flag = this.dtCreated == value;
label_1:
        int num1 = 1395938526;
        while (true)
        {
          int num2 = 92390739;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 327961774 ^ 1074606675;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num4 = !flag ? 104623031 : (num4 = 1390916618);
              int num5 = (int) num3 * -1905571479;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.dtCreated = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(534032679U));
              num1 = 874959227;
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

    public DateTime DateFinalized
    {
      get
      {
        return this.dtFinalized;
      }
      set
      {
        if (!(this.dtFinalized == value))
          goto label_5;
label_1:
        int num1 = -1333141917;
label_2:
        while (true)
        {
          int num2 = -1474399000;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -556299777 ^ -1870886794;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -610689299 ^ -2066533632;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        this.dtFinalized = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2276585968U));
        num1 = -502162737;
        goto label_2;
      }
    }

    public bool VideoChatMenuItemClicked
    {
      get
      {
label_1:
        int num1 = -229408670;
        bool chatMenuItemClicked;
        while (true)
        {
          int num2 = -477939751;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1724309039 ^ 2084029438;
              continue;
            case 3:
              chatMenuItemClicked = VideoChatLink.videoChatMenuItemClicked;
              num1 = (int) num3 * 686589637 ^ 842274000;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return chatMenuItemClicked;
      }
      set
      {
label_1:
        int num1 = 1562879749;
        while (true)
        {
          int num2 = 949970173;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1614639198 ^ -1284020059;
              continue;
            case 1:
              num1 = (int) num3 * -443160312 ^ 19332245;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(521147771U));
              num1 = (int) num3 * 357562547 ^ -1521137750;
              continue;
            case 4:
              goto label_1;
            case 5:
              VideoChatLink.videoChatMenuItemClicked = value;
              num1 = 16977204;
              continue;
            case 6:
              int num4 = VideoChatLink.videoChatMenuItemClicked != value ? 1816683317 : (num4 = 1625465762);
              int num5 = (int) num3 * 1137009476;
              num1 = num4 ^ num5;
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

    public bool ChatSent
    {
      get
      {
        return VideoChatLink.chatSent;
      }
      set
      {
        if (VideoChatLink.chatSent != value)
          goto label_6;
label_1:
        int num1 = -1123038682;
label_2:
        while (true)
        {
          int num2 = -688342580;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 665228342 ^ -1130709817;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1801067937U));
              num1 = (int) num3 * -1686906758 ^ 815515923;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -1522034695 ^ 1712810839;
              continue;
            case 5:
              goto label_6;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:
        return;
label_6:
        VideoChatLink.chatSent = value;
        num1 = -713346100;
        goto label_2;
      }
    }

    public bool ChatLinked
    {
      get
      {
label_1:
        int num1 = 488572677;
        bool chatLinked;
        while (true)
        {
          int num2 = 1308372052;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1934201653 ^ 2022419686;
              continue;
            case 1:
              chatLinked = VideoChatLink.chatLinked;
              num1 = (int) num3 * -443979544 ^ 1998399112;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return chatLinked;
      }
      set
      {
        bool flag = VideoChatLink.chatLinked == value;
label_1:
        int num1 = -357897681;
        while (true)
        {
          int num2 = -145498411;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              VideoChatLink.chatLinked = value;
              num1 = -1808289151;
              continue;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -360967244 ^ 2025521739;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(459890966U));
              num1 = (int) num3 * -638819109 ^ -746345009;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num4 = flag ? 721338698 : (num4 = 451746092);
              int num5 = (int) num3 * 1303739224;
              num1 = num4 ^ num5;
              continue;
            case 6:
              num1 = (int) num3 * -1797482166 ^ 1517924453;
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

    public bool VideoPictureCaptured
    {
      get
      {
label_1:
        int num1 = -1274100632;
        bool pictureCaptured;
        while (true)
        {
          int num2 = -641696059;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1800669663 ^ 1595306067;
              continue;
            case 1:
              pictureCaptured = this.pictureCaptured;
              num1 = (int) num3 * 1244910316 ^ -363427551;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return pictureCaptured;
      }
      set
      {
label_1:
        int num1 = -1767916194;
        while (true)
        {
          int num2 = -1784404773;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1985945202U));
              num1 = (int) num3 * -77237002 ^ 1399476788;
              continue;
            case 2:
              num1 = (int) num3 * 2083545115 ^ 949699317;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.pictureCaptured = value;
              num1 = -1929827683;
              continue;
            case 5:
              int num4 = this.pictureCaptured == value ? 1109423269 : (num4 = 152172418);
              int num5 = (int) num3 * 1835035378;
              num1 = num4 ^ num5;
              continue;
            case 6:
              num1 = (int) num3 * -246866105 ^ -819831244;
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

    public InspectVideoWindow LinkActivity
    {
      get
      {
        bool flag = this.linkActivity == null;
label_1:
        int num1 = 948315110;
        InspectVideoWindow linkActivity;
        while (true)
        {
          int num2 = 1828948003;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              linkActivity = this.linkActivity;
              num1 = 1842592520;
              continue;
            case 1:
              int num4 = flag ? 292052807 : (num4 = 2075791407);
              int num5 = (int) num3 * 2125914510;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            case 4:
              this.linkActivity = new InspectVideoWindow(this.VideoWindow);
              num1 = (int) num3 * -1858571929 ^ -1182519097;
              continue;
            case 5:
              num1 = (int) num3 * -1389417450 ^ 203619191;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return linkActivity;
      }
      set
      {
label_1:
        int num1 = 1351266226;
        while (true)
        {
          int num2 = 1278319965;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2438237U));
              num1 = (int) num3 * -1794305978 ^ -1502873841;
              continue;
            case 1:
              flag = this.linkActivity == value;
              num1 = (int) num3 * -652795023 ^ 934417965;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = !flag ? -878768060 : (num4 = -34551749);
              int num5 = (int) num3 * 1605214357;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * 1156062901 ^ 1871634502;
              continue;
            case 5:
              this.linkActivity = value;
              num1 = 1306220529;
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

    public bool ChatSelectPictureCaptured
    {
      get
      {
label_1:
        int num1 = -382981261;
        bool selectPictureCaptured;
        while (true)
        {
          int num2 = -1961327558;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              selectPictureCaptured = this.chatSelectPictureCaptured;
              num1 = (int) num3 * 785102657 ^ 1364034572;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1789548677 ^ 1676188951;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return selectPictureCaptured;
      }
      set
      {
label_1:
        int num1 = 693782556;
        while (true)
        {
          int num2 = 1841177196;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.chatSelectPictureCaptured = value;
              num1 = 1822086195;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              flag = this.chatSelectPictureCaptured == value;
              num1 = (int) num3 * 1268016070 ^ -1530713798;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3991831144U));
              num1 = (int) num3 * 1040217391 ^ 1475163497;
              continue;
            case 5:
              int num4 = flag ? 500165918 : (num4 = 161494888);
              int num5 = (int) num3 * 483561251;
              num1 = num4 ^ num5;
              continue;
            case 6:
              num1 = (int) num3 * -1214070074 ^ 396813816;
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

    public Bitmap ChatSelectorPicture
    {
      get
      {
label_1:
        int num1 = 2042752342;
        Bitmap chatSelectorPicture;
        while (true)
        {
          int num2 = 1721692469;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              chatSelectorPicture = this.chatSelectorPicture;
              num1 = (int) num3 * -703361789 ^ -1838136391;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return chatSelectorPicture;
      }
      set
      {
label_1:
        int num1 = 1440769704;
        while (true)
        {
          int num2 = 1801777969;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              flag = this.chatSelectorPicture == value;
              num1 = (int) num3 * 874266977 ^ -241589868;
              continue;
            case 2:
              num1 = (int) num3 * -792710033 ^ 957464719;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = flag ? 132842776 : (num4 = 492880362);
              int num5 = (int) num3 * 143273045;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * -1214052237 ^ -229875034;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2777436537U));
              num1 = (int) num3 * 1847783985 ^ -1733155451;
              continue;
            case 7:
              this.chatSelectorPicture = value;
              num1 = 226319055;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public ZoomWindow ChatWindow
    {
      get
      {
label_1:
        int num1 = -2105518625;
        ZoomWindow chatWindow;
        while (true)
        {
          int num2 = -54123199;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              chatWindow = this.chatWindow;
              num1 = (int) num3 * 1783399681 ^ 1201894263;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return chatWindow;
      }
      set
      {
label_1:
        int num1 = 82670119;
        while (true)
        {
          int num2 = 1276439124;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 1027227687 ^ -540257912;
              continue;
            case 1:
              this.chatWindow = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3857257194U));
              num1 = 1266373387;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = this.chatWindow == value ? 909368583 : (num4 = 1588512962);
              int num5 = (int) num3 * 1025828869;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_3;
            case 5:
              num1 = (int) num3 * 1387995850 ^ -631283702;
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

    public Bitmap WindowImage
    {
      get
      {
label_1:
        int num1 = -1830213235;
        Bitmap windowImage;
        while (true)
        {
          int num2 = -1735446349;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              windowImage = this.windowImage;
              num1 = (int) num3 * -1493374955 ^ -615253913;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowImage;
      }
      set
      {
        bool flag = this.windowImage == value;
label_1:
        int num1 = 245316382;
        while (true)
        {
          int num2 = 878288730;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -1883876316 ^ 974186594;
              continue;
            case 2:
              int num4 = !flag ? -1596541843 : (num4 = -473910003);
              int num5 = (int) num3 * 896625622;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.windowImage = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(786492977U));
              num1 = 1935127959;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * -422637649 ^ 1849865565;
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

    public override TraceType TraceType
    {
      get
      {
        return TraceType.Chat;
      }
    }

    static VideoChatLink()
    {
label_1:
      int num1 = 1568611302;
      while (true)
      {
        int num2 = 2012209923;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            VideoChatLink.chatSent = false;
            num1 = (int) num3 * -2052420361 ^ -1772846542;
            continue;
          case 2:
            VideoChatLink.chatLinked = false;
            num1 = (int) num3 * 489580540 ^ -2120507165;
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

    public VideoChatLink(ZoomWindow videoWindow)
    {
      this.videoWindow = videoWindow;
      this.Handle = videoWindow.Handle;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      this.ChatWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (VideoChatLink.\u003C\u003Ec.\u003C\u003E9__66_0 ?? (VideoChatLink.\u003C\u003Ec.\u003C\u003E9__66_0 = new Func<ZoomWindow, bool>((object) VideoChatLink.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003C\u002Ector\u003Eb__66_0)))));
    }

    internal void InvokeChat()
    {
      object linkLock = VideoChatLink.linkLock;
      bool flag = false;
      try
      {
        VideoChatLink.\u202D⁫​‫⁯‬‬‎‫⁪​⁯⁪⁪​⁪‬‪​‫⁯‬​⁫‫⁭‭‫‏⁭⁬​⁪‬‍‭⁫‮‎⁯‮(linkLock, ref flag);
label_2:
        int num1 = -1195450983;
        while (true)
        {
          int num2 = -2125686314;
          uint num3;
          int X;
          int Y;
          System.Drawing.Point location;
          switch ((num3 = (uint) (num1 ^ num2)) % 36U)
          {
            case 0:
              num1 = (int) num3 * 692517159 ^ 1558821825;
              continue;
            case 1:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * -1700937963 ^ -591965374;
              continue;
            case 2:
              num1 = (int) num3 * -133525448 ^ 834653403;
              continue;
            case 3:
              this.Engine.GetWindow(ZoomWindowType.Chat);
              num1 = (int) num3 * 1959051590 ^ -316482092;
              continue;
            case 4:
              this.videoWindow.Activate();
              this.videoWindow.Refresh(false, true);
              int num4 = this.videoWindow.IsVisible ? -1153387062 : (num4 = -922060602);
              int num5 = (int) num3 * 1657701214;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 752819368 ^ 1702744251;
              continue;
            case 6:
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              Thread.Sleep(40);
              num1 = (int) num3 * 1511064873 ^ 210208278;
              continue;
            case 7:
              Y += 25;
              num1 = (int) num3 * 1058665875 ^ -2126563902;
              continue;
            case 8:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 837661243 ^ -243825931;
              continue;
            case 9:
              this.Engine.ActiveMeetingWindow.Activate();
              num1 = (int) num3 * 1103732153 ^ 1246278296;
              continue;
            case 10:
              num1 = -694106257;
              continue;
            case 11:
              Y = location.Y + 25;
              User32.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * 1064996338 ^ -1579289766;
              continue;
            case 12:
              goto label_42;
            case 13:
              int num6 = new SendChat(this).Execute(this.Engine.Token) != ActivityState.Completed ? -1416191742 : (num6 = -2130974303);
              int num7 = (int) num3 * 1662010146;
              num1 = num6 ^ num7;
              continue;
            case 14:
              num1 = (int) num3 * 1796749898 ^ 709642175;
              continue;
            case 15:
              Thread.Sleep(40);
              num1 = (int) num3 * 1289274088 ^ -589555336;
              continue;
            case 16:
              num1 = (int) num3 * 752046517 ^ 974020485;
              continue;
            case 17:
              this.CaptureChatSelectorPicture();
              num1 = (int) num3 * 1906983547 ^ -595848464;
              continue;
            case 18:
              num1 = (int) num3 * 1216211709 ^ 2135958188;
              continue;
            case 19:
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -142883706 ^ -202860444;
              continue;
            case 20:
              num1 = -1515430748;
              continue;
            case 21:
              num1 = -787537618;
              continue;
            case 22:
              goto label_14;
            case 23:
              num1 = (int) num3 * -1078319777 ^ -1745320370;
              continue;
            case 24:
              location = this.videoWindow.Location;
              X = location.X + 25;
              num1 = (int) num3 * 463170067 ^ -609526336;
              continue;
            case 25:
              this.ChatSent = true;
              num1 = (int) num3 * -938812112 ^ -1547496066;
              continue;
            case 26:
              location = this.videoWindow.Location;
              num1 = (int) num3 * 1033049900 ^ 750391525;
              continue;
            case 27:
              this.CaptureVideoPicture();
              num1 = (int) num3 * -1376693793 ^ -1489255745;
              continue;
            case 28:
              this.VideoChatMenuItemClicked = true;
              num1 = (int) num3 * -1587931184 ^ 169355628;
              continue;
            case 29:
              User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * 907956409 ^ -1435214261;
              continue;
            case 30:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 547707960 ^ -446152804;
              continue;
            case 31:
              goto label_2;
            case 32:
              num1 = (int) num3 * 143472309 ^ -1559930936;
              continue;
            case 33:
              this.VideoRightClicked = true;
              num1 = (int) num3 * -1651154614 ^ -163571469;
              continue;
            case 34:
              Thread.Sleep(40);
              num1 = (int) num3 * -1299096069 ^ -1177356022;
              continue;
            case 35:
              X += 25;
              num1 = (int) num3 * -1872504261 ^ 809966712;
              continue;
            default:
              goto label_38;
          }
        }
label_38:
        return;
label_42:
        return;
label_14:
        throw new Exception(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4098622849U));
      }
      finally
      {
        if (flag)
        {
label_40:
          int num1 = -1914250110;
          while (true)
          {
            int num2 = -2125686314;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_40;
              case 2:
                Monitor.Exit(linkLock);
                num1 = (int) num3 * -640677535 ^ -1783230752;
                continue;
              default:
                goto label_44;
            }
          }
        }
label_44:;
      }
    }

    private static string CleanFileName(string fileName)
    {
label_1:
      int num1 = 1692425372;
      string str;
      while (true)
      {
        int num2 = 1666052202;
        uint num3;
        char[] chArray1;
        int index;
        char ch;
        char[] chArray2;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            ++index;
            num1 = (int) num3 * -1289495485 ^ 407182293;
            continue;
          case 1:
            ch = chArray1[index];
            num1 = 1434140288;
            continue;
          case 2:
            int num4 = !fileName.Contains<char>(ch) ? 984982391 : (num4 = 107447365);
            int num5 = (int) num3 * -965704050;
            num1 = num4 ^ num5;
            continue;
          case 3:
            fileName = fileName.Replace(ch.ToString(), "");
            num1 = (int) num3 * 1656004315 ^ 491901322;
            continue;
          case 5:
            num1 = (int) num3 * -719372277 ^ -876312431;
            continue;
          case 6:
            chArray1 = chArray2;
            index = 0;
            num1 = (int) num3 * 1478835237 ^ 374882115;
            continue;
          case 7:
            int num6;
            num1 = num6 = index >= chArray1.Length ? 1895670498 : (num6 = 1798602755);
            continue;
          case 8:
            str = fileName;
            num1 = (int) num3 * -288134931 ^ 1615394927;
            continue;
          case 9:
            num1 = 1314726006;
            continue;
          case 10:
            chArray2 = VideoChatLink.\u200F‎‏​‫⁯‫‫⁭⁪‬⁬​‌‭‮‬‍‫⁬‬⁪‪‮‭‫‌‫⁯⁪‪‮⁮⁯⁮‏​⁬‮‎‮();
            num1 = (int) num3 * -1008041146 ^ 1616393524;
            continue;
          case 11:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_13:
      return str;
    }

    internal void CaptureVideoPicture()
    {
      try
      {
label_2:
        int num1 = 870386443;
        while (true)
        {
          int num2 = 2050874364;
          uint num3;
          bool flag;
          Bitmap windowAsBitmap;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * 1378785704 ^ 614358734;
              continue;
            case 1:
              flag = this.VideoWindow != null;
              num1 = (int) num3 * -1811693337 ^ -993564812;
              continue;
            case 2:
              WindowHelper.ForceForeground(this.VideoWindow.Owner);
              num1 = (int) num3 * -665994834 ^ -659548182;
              continue;
            case 3:
              int num4 = flag ? -274641793 : (num4 = -1268500797);
              int num5 = (int) num3 * 225769752;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_2;
            case 5:
              VideoChatLink.\u202A‫‭‪‍‪‌⁭‌‫‏⁭‭‍‌‏​‫‭⁫⁮⁪⁪⁪‭‫⁭‮‮‏‪⁭⁪‏‍⁮‫⁭‌‬‮((Image) this.WindowImage, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3549921495U));
              num1 = (int) num3 * -242360285 ^ -1851589355;
              continue;
            case 6:
              windowAsBitmap = this.VideoWindow.GetWindowAsBitmap();
              num1 = (int) num3 * -1865358185 ^ 420561134;
              continue;
            case 7:
              this.WindowImage = (Bitmap) VideoChatLink.\u202E⁬⁯​‮⁪‏⁮⁫‌⁪‮‍‏‬⁬⁫‮⁯⁪‮‭‏‎‪‫​‍⁪​‮​‎‪⁬⁮‏‭‭⁪‮((Image) windowAsBitmap);
              VideoChatLink.\u202E‭‏​​⁪⁮‬⁫⁯‫‏​‫‎⁯‫⁪⁬‎‬‪‭⁪‍⁯⁫‏⁭‫‌⁮‎‫⁭⁯⁮‭⁫‍‮((Image) windowAsBitmap);
              num1 = (int) num3 * -33717117 ^ 1552196143;
              continue;
            case 8:
              goto label_19;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_19:;
      }
      catch (Exception ex)
      {
label_14:
        int num1 = 74252357;
        while (true)
        {
          int num2 = 2050874364;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_12;
            case 1:
              this.Engine.LogException(VideoChatLink.\u202D‪‎⁪‏‪⁭‬‏⁭⁯‬⁪⁪⁭‏‪​⁬‪‌‭‬‌⁭⁪⁫⁯‫⁪‭​‮⁭‮⁫⁯‍⁯⁪‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1764812134U), VideoChatLink.\u202C⁮⁯⁪‎⁫‮⁪⁬⁬‫⁮⁫‏​‏⁪⁭⁮‬⁮⁯​⁮⁫‫‮⁮‬⁯‮‮‍‪⁬‍‭​‍‫‮(ex)));
              num1 = (int) num3 * 1387289099 ^ 72582736;
              continue;
            case 2:
              goto label_14;
            case 3:
              num1 = (int) num3 * 1531783282 ^ -937714322;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_12:;
      }
    }

    internal void CaptureChatSelectorPicture()
    {
      try
      {
        bool flag1 = this.ChatWindow == null;
label_2:
        int num1 = -1625694901;
        while (true)
        {
          int num2 = -1343348138;
          uint num3;
          Bitmap windowSectionAsBitmap;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              windowSectionAsBitmap.Dispose();
              num1 = (int) num3 * 1818722288 ^ 1962835886;
              continue;
            case 1:
              num1 = (int) num3 * 1046322061 ^ -359777971;
              continue;
            case 2:
              goto label_4;
            case 3:
              WindowHelper.ForceForeground(this.ChatWindow.Owner);
              num1 = (int) num3 * 1152451010 ^ -367873234;
              continue;
            case 4:
              num1 = (int) num3 * 1237499371 ^ -1222013990;
              continue;
            case 5:
              this.ChatSelectorPicture = (Bitmap) windowSectionAsBitmap.Clone();
              num1 = (int) num3 * 118153708 ^ 1443656302;
              continue;
            case 6:
              num1 = -642224492;
              continue;
            case 7:
              num1 = (int) num3 * 5029423 ^ 537894165;
              continue;
            case 8:
              this.ChatSelectorPicture.Save(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3166115467U));
              num1 = (int) num3 * -1961420035 ^ 717652895;
              continue;
            case 9:
              num1 = (int) num3 * 891289965 ^ 1245862468;
              continue;
            case 10:
              flag2 = this.ChatWindow != null;
              num1 = -1395641302;
              continue;
            case 11:
              this.ChatWindow = this.Engine.GetWindow(ZoomWindowType.Chat);
              num1 = (int) num3 * 688696393 ^ 1959545644;
              continue;
            case 12:
              int num4 = !flag2 ? 1742204796 : (num4 = 512458073);
              int num5 = (int) num3 * 612898389;
              num1 = num4 ^ num5;
              continue;
            case 13:
              int num6 = flag1 ? 1451084837 : (num6 = 507693108);
              int num7 = (int) num3 * -474885416;
              num1 = num6 ^ num7;
              continue;
            case 14:
              windowSectionAsBitmap = this.ChatWindow.GetWindowSectionAsBitmap(this.ChatWindow.Size.Height - 95, 15, 300, 20);
              num1 = (int) num3 * -237409797 ^ 1644643129;
              continue;
            case 15:
              goto label_2;
            default:
              goto label_20;
          }
        }
label_20:
        return;
label_4:;
      }
      catch (Exception ex)
      {
        this.Engine.LogException(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3320282607U) + ex.Message);
      }
    }

    internal void CompleteLink(ZoomChat chat)
    {
      object linkLock = VideoChatLink.linkLock;
      bool flag1 = false;
      try
      {
        VideoChatLink.\u202D⁫​‫⁯‬‬‎‫⁪​⁯⁪⁪​⁪‬‪​‫⁯‬​⁫‫⁭‭‫‏⁭⁬​⁪‬‍‭⁫‮‎⁯‮(linkLock, ref flag1);
label_2:
        int num1 = -177577534;
        while (true)
        {
          int num2 = -1203527522;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              this.DateFinalized = DateTime.Now;
              flag2 = !this.VideoPictureCaptured;
              num1 = (int) num3 * 2088233313 ^ -466192231;
              continue;
            case 1:
              this.UserName = chat.ReceivingZoomId;
              num1 = (int) num3 * 496225344 ^ 1413193507;
              continue;
            case 2:
              this.CaptureVideoPicture();
              num1 = (int) num3 * 1581664824 ^ 479468236;
              continue;
            case 3:
              num1 = (int) num3 * 118183427 ^ -1471637659;
              continue;
            case 4:
              num1 = (int) num3 * 1896801239 ^ -1189342561;
              continue;
            case 5:
              goto label_2;
            case 6:
              num1 = (int) num3 * -556722835 ^ -1649280998;
              continue;
            case 7:
              int num4 = flag2 ? 475530741 : (num4 = 1371228760);
              int num5 = (int) num3 * -1510910680;
              num1 = num4 ^ num5;
              continue;
            case 8:
              goto label_18;
            case 9:
              this.ChatLinked = true;
              num1 = (int) num3 * -1911030070 ^ 878793147;
              continue;
            case 10:
              num1 = -42221018;
              continue;
            case 11:
              num1 = (int) num3 * 510490179 ^ -1855483657;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_18:;
      }
      finally
      {
        if (flag1)
        {
label_16:
          int num1 = -1656639857;
          while (true)
          {
            int num2 = -1203527522;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_16;
              case 1:
                VideoChatLink.\u202E⁬‬‭‪⁪‎‭‏‬‏⁬‫‍‍‫‭⁭⁯‮‬⁫​⁫⁯‎⁫⁮‏‭⁪⁫‭‪‏‪⁬​‫‏‮(linkLock);
                num1 = (int) num3 * -768337212 ^ -1567594628;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    internal void Reset()
    {
      object linkLock = VideoChatLink.linkLock;
      bool flag = false;
      try
      {
        VideoChatLink.\u202D⁫​‫⁯‬‬‎‫⁪​⁯⁪⁪​⁪‬‪​‫⁯‬​⁫‫⁭‭‫‏⁭⁬​⁪‬‍‭⁫‮‎⁯‮(linkLock, ref flag);
label_2:
        int num1 = -1034947969;
        while (true)
        {
          int num2 = -281100367;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 19U)
          {
            case 0:
              this.VideoRightClicked = false;
              num1 = (int) num3 * 1056405119 ^ 488663949;
              continue;
            case 1:
              this.DateFinalized = DateTime.MinValue;
              num1 = (int) num3 * -495239881 ^ -1878540558;
              continue;
            case 2:
              goto label_25;
            case 3:
              num1 = (int) num3 * 895687946 ^ -1520968542;
              continue;
            case 4:
              this.TrackingMessage = this.Engine.Settings.GetRandomGreeting();
              num1 = (int) num3 * -571105600 ^ -1457770614;
              continue;
            case 5:
              this.ChatLinked = false;
              this.ChatSent = false;
              num1 = (int) num3 * -420854086 ^ 534054670;
              continue;
            case 6:
              num1 = (int) num3 * 2036130164 ^ 634490858;
              continue;
            case 7:
              this.VideoChatMenuItemClicked = false;
              num1 = (int) num3 * -56676483 ^ 1532826390;
              continue;
            case 8:
              num1 = (int) num3 * -427681869 ^ 7640822;
              continue;
            case 9:
              this.VideoPictureCaptured = false;
              this.ChatSelectPictureCaptured = false;
              num1 = (int) num3 * 584679201 ^ -1546709432;
              continue;
            case 10:
              num1 = (int) num3 * -2094633073 ^ 1911442160;
              continue;
            case 11:
              goto label_2;
            case 12:
              num1 = (int) num3 * 1553983411 ^ -1673380871;
              continue;
            case 13:
              num1 = (int) num3 * -1572505073 ^ -1755730516;
              continue;
            case 14:
              num1 = (int) num3 * -819931330 ^ 568153027;
              continue;
            case 15:
              this.DateCreated = DateTime.Now;
              num1 = (int) num3 * -2032584281 ^ -563805691;
              continue;
            case 16:
              this.UserName = string.Empty;
              num1 = (int) num3 * 267221897 ^ -925048362;
              continue;
            case 17:
              num1 = (int) num3 * 622850949 ^ -1356064091;
              continue;
            case 18:
              num1 = (int) num3 * 78665056 ^ -1047747514;
              continue;
            default:
              goto label_21;
          }
        }
label_21:
        return;
label_25:;
      }
      finally
      {
        if (flag)
        {
label_23:
          int num1 = -1125972812;
          while (true)
          {
            int num2 = -281100367;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                VideoChatLink.\u202E⁬‬‭‪⁪‎‭‏‬‏⁬‫‍‍‫‭⁭⁯‮‬⁫​⁫⁯‎⁫⁮‏‭⁪⁫‭‪‏‪⁬​‫‏‮(linkLock);
                num1 = (int) num3 * 655063178 ^ 313703441;
                continue;
              case 2:
                num1 = (int) num3 * 1910223295 ^ -1705038601;
                continue;
              case 3:
                goto label_23;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
    }

    static bool \u206B⁫‌⁭⁮⁬‫⁪‍⁫‮⁯‭‮⁯‮⁬‏‮‫‫‭⁮‎⁫‮‎⁬⁪‏‫‭‮⁪‎⁫‪‪⁮‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u200E⁪⁭‭⁪‍⁬‍‫‬‍‎⁬‫‏‭‫‭‫‮⁮‌⁮‌​‪‎‎​‏⁭‭⁫⁬‫⁬‎‏‫‭‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static void \u202D⁫​‫⁯‬‬‎‫⁪​⁯⁪⁪​⁪‬‪​‫⁯‬​⁫‫⁭‭‫‏⁭⁬​⁪‬‍‭⁫‮‎⁯‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static char[] \u200F‎‏​‫⁯‫‫⁭⁪‬⁬​‌‭‮‬‍‫⁬‬⁪‪‮‭‫‌‫⁯⁪‪‮⁮⁯⁮‏​⁬‮‎‮()
    {
      return Path.GetInvalidFileNameChars();
    }

    static object \u202E⁬⁯​‮⁪‏⁮⁫‌⁪‮‍‏‬⁬⁫‮⁯⁪‮‭‏‎‪‫​‍⁪​‮​‎‪⁬⁮‏‭‭⁪‮([In] Image obj0)
    {
      return obj0.Clone();
    }

    static void \u202E‭‏​​⁪⁮‬⁫⁯‫‏​‫‎⁯‫⁪⁬‎‬‪‭⁪‍⁯⁫‏⁭‫‌⁮‎‫⁭⁯⁮‭⁫‍‮([In] Image obj0)
    {
      obj0.Dispose();
    }

    static void \u202A‫‭‪‍‪‌⁭‌‫‏⁭‭‍‌‏​‫‭⁫⁮⁪⁪⁪‭‫⁭‮‮‏‪⁭⁪‏‍⁮‫⁭‌‬‮([In] Image obj0, [In] string obj1)
    {
      obj0.Save(obj1);
    }

    static string \u202C⁮⁯⁪‎⁫‮⁪⁬⁬‫⁮⁫‏​‏⁪⁭⁮‬⁮⁯​⁮⁫‫‮⁮‬⁯‮‮‍‪⁬‍‭​‍‫‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u202D‪‎⁪‏‪⁭‬‏⁭⁯‬⁪⁪⁭‏‪​⁬‪‌‭‬‌⁭⁪⁫⁯‫⁪‭​‮⁭‮⁫⁯‍⁯⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static void \u202E⁬‬‭‪⁪‎‭‏‬‏⁬‫‍‍‫‭⁭⁯‮‬⁫​⁫⁯‎⁫⁮‏‭⁪⁫‭‪‏‪⁬​‫‏‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static object \u200F‪‪⁬⁯⁮⁪⁭​‫⁯‪‭‌‌‭‪⁪​‌​‭‮‫‬‬​‎⁯‎‫‭‪‫‍⁭⁪‍​⁮‮()
    {
      return new object();
    }
  }
}
