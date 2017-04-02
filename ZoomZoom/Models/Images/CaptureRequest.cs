// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.CaptureRequest
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Media.Imaging;

namespace ZoomZoom.Models.Images
{
  public class CaptureRequest : CoreObject
  {
    private static readonly object requestLock = CaptureRequest.\u206E‏‭‬​‍‍‮⁯⁭⁬‭‬‮‎‌‎​‍⁬‏‎‎‮‌⁬⁬‍‌‭⁪‌‍⁫‮‪‌‬‎⁬‮();
    private CaptureState captureState = CaptureState.Pending;
    private bool displayAfterCapture = false;
    private bool displayHighlightWindow = false;
    private bool saveToDisk = false;
    private bool maximizeDisplay = false;
    private BitmapSource bitmapSource = (BitmapSource) null;

    public IntPtr WindowHandle { get; set; }

    public ZoomWindow Window { get; set; }

    public bool ForceForeground { get; set; }

    public Rectangle TargetRegion { get; set; }

    public CaptureState CaptureState
    {
      get
      {
label_1:
        int num1 = -471482074;
        CaptureState captureState;
        while (true)
        {
          int num2 = -1989036508;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1974554442 ^ -724524259;
              continue;
            case 2:
              captureState = this.captureState;
              num1 = (int) num3 * 1858337354 ^ -1259035495;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return captureState;
      }
      set
      {
        this.captureState = value;
label_1:
        int num1 = 535441308;
        while (true)
        {
          int num2 = 909627412;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2904007954U));
              num1 = (int) num3 * -1066509308 ^ 128842089;
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

    public bool DisplayAfterCapture
    {
      get
      {
        bool displayAfterCapture = this.displayAfterCapture;
label_1:
        int num1 = -1835534836;
        while (true)
        {
          int num2 = -2133473166;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1290487933 ^ 1175884675;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return displayAfterCapture;
      }
      set
      {
        this.displayAfterCapture = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1381010092U));
      }
    }

    public bool DisplayHighlightWindow
    {
      get
      {
label_1:
        int num1 = -1747011369;
        bool displayHighlightWindow;
        while (true)
        {
          int num2 = -1250819014;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              displayHighlightWindow = this.displayHighlightWindow;
              num1 = (int) num3 * -730432995 ^ 2047224660;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1291887906 ^ -62239528;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return displayHighlightWindow;
      }
      set
      {
label_1:
        int num1 = 1204215319;
        while (true)
        {
          int num2 = 523316421;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.displayHighlightWindow = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1645598293U));
              num1 = (int) num3 * 1203779463 ^ -1571195414;
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

    public bool SaveToDisk
    {
      get
      {
label_1:
        int num1 = -1495222133;
        bool saveToDisk;
        while (true)
        {
          int num2 = -1439979937;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              saveToDisk = this.saveToDisk;
              num1 = (int) num3 * 854942079 ^ -688750737;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return saveToDisk;
      }
      set
      {
label_1:
        int num1 = -975221096;
        while (true)
        {
          int num2 = -1872306901;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.saveToDisk = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2976387430U));
              num1 = (int) num3 * -1181613913 ^ 1788756027;
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

    public bool MaximizeDisplay
    {
      get
      {
        bool maximizeDisplay = this.maximizeDisplay;
label_1:
        int num1 = -196942141;
        while (true)
        {
          int num2 = -1481340117;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1661196234 ^ 768058640;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return maximizeDisplay;
      }
      set
      {
        this.maximizeDisplay = value;
label_1:
        int num1 = 1229050173;
        while (true)
        {
          int num2 = 1763602742;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1250998671U));
              num1 = (int) num3 * 924369704 ^ 1344864846;
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

    public BitmapSource BitmapSource
    {
      get
      {
label_1:
        int num1 = -668799774;
        BitmapSource bitmapSource;
        while (true)
        {
          int num2 = -722963033;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              bitmapSource = this.bitmapSource;
              num1 = (int) num3 * 1022231279 ^ -107184389;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1633880253 ^ -1849293040;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return bitmapSource;
      }
      set
      {
label_1:
        int num1 = 858565848;
        while (true)
        {
          int num2 = 806411771;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -1632254561 ^ 2120065196;
              continue;
            case 3:
              this.bitmapSource = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3037324012U));
              num1 = (int) num3 * 577818084 ^ 966563233;
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
        TraceType traceType = TraceType.Image;
label_1:
        int num1 = 614197140;
        while (true)
        {
          int num2 = 76947220;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -635372102 ^ 1789699876;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public CaptureRequest(ZoomWindow targetWindow, bool forceForeground = true)
    {
label_1:
      int num1 = -2133736680;
      while (true)
      {
        int num2 = -545492237;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * -1621665507 ^ -1342841789;
            continue;
          case 1:
            num1 = (int) num3 * -1501893859 ^ 1484083316;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.ForceForeground = forceForeground;
            num1 = (int) num3 * -1189472741 ^ -1428519327;
            continue;
          case 4:
            this.WindowHandle = this.Window.Handle;
            num1 = (int) num3 * 1662879771 ^ 1547216860;
            continue;
          case 5:
            num1 = (int) num3 * 428184193 ^ 999459334;
            continue;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num3 * -844446131 ^ -1330332345;
            continue;
          case 8:
            this.Window = targetWindow;
            num1 = (int) num3 * 1365531200 ^ 1866686119;
            continue;
          case 9:
            this.TargetRegion = this.Window.Rectangle;
            num1 = (int) num3 * 601251357 ^ -1640996009;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    public CaptureRequest(ZoomWindow targetWindow, Rectangle targetRegion, bool forceForeground = true)
    {
label_1:
      int num1 = -1645041939;
      while (true)
      {
        int num2 = -372083023;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Window = targetWindow;
            num1 = (int) num3 * -1565961458 ^ -2124097992;
            continue;
          case 3:
            num1 = (int) num3 * -798682562 ^ 1259955100;
            continue;
          case 4:
            this.WindowHandle = this.Window.Handle;
            num1 = (int) num3 * 2109921138 ^ 1967472424;
            continue;
          case 5:
            num1 = (int) num3 * -1927987434 ^ 532454735;
            continue;
          case 6:
            this.ForceForeground = forceForeground;
            System.Drawing.Point location = targetWindow.Location;
            int x = location.X + targetRegion.X;
            location = targetWindow.Location;
            int y = location.Y + targetRegion.Y;
            int width = targetRegion.Width;
            int height = targetRegion.Height;
            this.TargetRegion = new Rectangle(x, y, width, height);
            num1 = (int) num3 * -1256847518 ^ -1819736482;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    public CaptureRequest(IntPtr windowHandle, bool forceForeground = true)
    {
label_1:
      int num1 = 715023758;
      while (true)
      {
        int num2 = 328030152;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num1 = (int) num3 * -1641492588 ^ 1491148918;
            continue;
          case 1:
            num1 = (int) num3 * 1902413006 ^ 2061324694;
            continue;
          case 2:
            num1 = 1486606306;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -667892701 ^ 102559087;
            continue;
          case 5:
            num1 = (int) num3 * -1636744280 ^ -1863679453;
            continue;
          case 6:
            num1 = (int) num3 * 1369084865 ^ 424219800;
            continue;
          case 7:
            num1 = (int) num3 * 628870532 ^ 1175883613;
            continue;
          case 8:
            this.ForceForeground = forceForeground;
            this.TargetRegion = this.Window.Rectangle;
            num1 = (int) num3 * 1504311703 ^ 1004765205;
            continue;
          case 9:
            this.Window = this.Engine.GetWindow(windowHandle, true);
            num1 = (int) num3 * -1116119072 ^ -1945700640;
            continue;
          case 10:
            num1 = (int) num3 * -1570870184 ^ 1564616939;
            continue;
          case 11:
            goto label_3;
          case 12:
            this.ForceForeground = forceForeground;
            num1 = (int) num3 * -598273467 ^ -142152428;
            continue;
          case 13:
            this.TargetRegion = WindowHelper.GetWindowRectangle(windowHandle);
            num1 = (int) num3 * -1429945355 ^ -2007073753;
            continue;
          case 14:
            this.WindowHandle = windowHandle;
            num1 = (int) num3 * 1774752884 ^ 1393099099;
            continue;
          case 15:
            num1 = (int) num3 * -1682803988 ^ 1124883042;
            continue;
          case 16:
            num1 = (int) num3 * -1704047425 ^ 147322885;
            continue;
          case 17:
            int num4 = !flag ? 1926794741 : (num4 = 2012049102);
            int num5 = (int) num3 * 1163163436;
            num1 = num4 ^ num5;
            continue;
          case 18:
            flag = this.Window != null;
            num1 = (int) num3 * 947130733 ^ 1488616006;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return;
label_3:;
    }

    internal CaptureState SetState(CaptureState newState)
    {
      object requestLock = CaptureRequest.requestLock;
      bool flag = false;
      try
      {
        CaptureRequest.\u200E⁬⁪⁭‎‭‎‌​⁭​⁪⁮⁪⁬‍⁪‏⁯‮‍‫‭​⁭‍‌‎​‏‭‍‍⁯‏⁭⁭‌‎⁫‮(requestLock, ref flag);
        this.CaptureState = newState;
label_2:
        int num1 = -1152919784;
        while (true)
        {
          int num2 = -1386243306;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * -1368736631 ^ 829903489;
              continue;
            default:
              goto label_11;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_6:
          int num1 = -1815800420;
          while (true)
          {
            int num2 = -1386243306;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * 1915298095 ^ -49269895;
                continue;
              case 2:
                CaptureRequest.\u206B⁯‎‬‬‫‌‎⁯‏‌⁭‍⁫‭⁪⁯⁬‏⁭⁫⁮⁭‌​⁪‬⁯‫⁯‎⁬‮⁫‍‮‮‭‬‮‮(requestLock);
                num1 = (int) num3 * -1951908889 ^ 1696698917;
                continue;
              case 3:
                goto label_6;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
label_11:
      CaptureState captureState = newState;
label_12:
      int num4 = -2008930255;
      while (true)
      {
        int num1 = -1386243306;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_12;
          case 2:
            num4 = (int) num2 * 964246316 ^ 317485561;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return captureState;
    }

    internal void SetBitmapSource(BitmapSource source)
    {
      object requestLock = CaptureRequest.requestLock;
      bool flag = false;
      try
      {
        CaptureRequest.\u200E⁬⁪⁭‎‭‎‌​⁭​⁪⁮⁪⁬‍⁪‏⁯‮‍‫‭​⁭‍‌‎​‏‭‍‍⁯‏⁭⁭‌‎⁫‮(requestLock, ref flag);
label_2:
        int num1 = 1912340224;
        while (true)
        {
          int num2 = 1361742053;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.BitmapSource = source;
              num1 = (int) num3 * -1964525558 ^ -1057251735;
              continue;
            case 1:
              num1 = (int) num3 * 1113526224 ^ 1700198605;
              continue;
            case 2:
              num1 = (int) num3 * 747534580 ^ -172286084;
              continue;
            case 3:
              goto label_12;
            case 4:
              goto label_2;
            case 5:
              this.CaptureState = CaptureState.Captured;
              num1 = (int) num3 * 1198027058 ^ -1059467136;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_12:;
      }
      finally
      {
        if (flag)
        {
label_10:
          int num1 = 1504834324;
          while (true)
          {
            int num2 = 1361742053;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_10;
              case 1:
                CaptureRequest.\u206B⁯‎‬‬‫‌‎⁯‏‌⁭‍⁫‭⁪⁯⁬‏⁭⁫⁮⁭‌​⁪‬⁯‫⁯‎⁬‮⁫‍‮‮‭‬‮‮(requestLock);
                num1 = (int) num3 * 689200849 ^ 45613403;
                continue;
              case 3:
                num1 = (int) num3 * -979311286 ^ -1152627123;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    static void \u200E⁬⁪⁭‎‭‎‌​⁭​⁪⁮⁪⁬‍⁪‏⁯‮‍‫‭​⁭‍‌‎​‏‭‍‍⁯‏⁭⁭‌‎⁫‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206B⁯‎‬‬‫‌‎⁯‏‌⁭‍⁫‭⁪⁯⁬‏⁭⁫⁮⁭‌​⁪‬⁯‫⁯‎⁬‮⁫‍‮‮‭‬‮‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static object \u206E‏‭‬​‍‍‮⁯⁭⁬‭‬‮‎‌‎​‍⁬‏‎‎‮‌⁬⁬‍‌‭⁪‌‍⁫‮‪‌‬‎⁬‮()
    {
      return new object();
    }
  }
}
