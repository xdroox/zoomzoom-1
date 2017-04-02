// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.ImageCaptureRequest
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Media.Imaging;

namespace ZoomZoom.Models.Images
{
  public class ImageCaptureRequest : CoreObject
  {
    private static readonly object requestLock = ImageCaptureRequest.\u200E‏‌‬⁫‫‪‎⁬⁫⁮‏‮⁬​‮‍‪​⁮​⁭​⁫‏​⁯⁯⁯‍‮⁫⁮‭‎​‫‎‫‪‮();
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
        CaptureState captureState = this.captureState;
label_1:
        int num1 = -195909786;
        while (true)
        {
          int num2 = -1736469585;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 528926048 ^ -320844139;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return captureState;
      }
      set
      {
        this.captureState = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3131432702U));
label_1:
        int num1 = 718330087;
        while (true)
        {
          int num2 = 859349768;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 274415696 ^ 2001062834;
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

    public bool DisplayAfterCapture
    {
      get
      {
label_1:
        int num1 = 267105052;
        bool displayAfterCapture;
        while (true)
        {
          int num2 = 213946099;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              displayAfterCapture = this.displayAfterCapture;
              num1 = (int) num3 * -855042512 ^ -1319333511;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return displayAfterCapture;
      }
      set
      {
label_1:
        int num1 = -1330213984;
        while (true)
        {
          int num2 = -73692820;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.displayAfterCapture = value;
              num1 = (int) num3 * 1614895921 ^ 1378160055;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 572577873 ^ -170661512;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(709971415U));
              num1 = (int) num3 * 1383743222 ^ -881475377;
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

    public bool DisplayHighlightWindow
    {
      get
      {
        return this.displayHighlightWindow;
      }
      set
      {
label_1:
        int num1 = 1493898450;
        while (true)
        {
          int num2 = 887896104;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.displayHighlightWindow = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1645598293U));
              num1 = (int) num3 * -674877829 ^ 1132576573;
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
        int num1 = -25855834;
        bool saveToDisk;
        while (true)
        {
          int num2 = -1985857638;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              saveToDisk = this.saveToDisk;
              num1 = (int) num3 * -1405894216 ^ 1063870094;
              continue;
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
        int num1 = 587120878;
        while (true)
        {
          int num2 = 1517267761;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1924291210U));
              num1 = (int) num3 * -1022400289 ^ 1078738848;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.saveToDisk = value;
              num1 = (int) num3 * -1089468569 ^ -612909835;
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

    public bool MaximizeDisplay
    {
      get
      {
label_1:
        int num1 = -538046110;
        bool maximizeDisplay;
        while (true)
        {
          int num2 = -1807848248;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              maximizeDisplay = this.maximizeDisplay;
              num1 = (int) num3 * -748190820 ^ 452066171;
              continue;
            case 3:
              num1 = (int) num3 * 1177979867 ^ 1593134928;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return maximizeDisplay;
      }
      set
      {
label_1:
        int num1 = -997478183;
        while (true)
        {
          int num2 = -1821180615;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3627802714U));
              num1 = (int) num3 * -1672018707 ^ -953933938;
              continue;
            case 2:
              this.maximizeDisplay = value;
              num1 = (int) num3 * -975046231 ^ -898609922;
              continue;
            case 3:
              num1 = (int) num3 * -557227891 ^ -1387737124;
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

    public BitmapSource BitmapSource
    {
      get
      {
label_1:
        int num1 = -922002728;
        BitmapSource bitmapSource;
        while (true)
        {
          int num2 = -2087392627;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              bitmapSource = this.bitmapSource;
              num1 = (int) num3 * 1402427254 ^ -2091047507;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return bitmapSource;
      }
      set
      {
label_1:
        int num1 = 460664252;
        while (true)
        {
          int num2 = 1983969195;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2370833336U));
              num1 = (int) num3 * -1912467713 ^ -1085281848;
              continue;
            case 3:
              this.bitmapSource = value;
              num1 = (int) num3 * 1543596737 ^ -765501066;
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
        int num1 = -1597067413;
        TraceType traceType;
        while (true)
        {
          int num2 = -886707235;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Image;
              num1 = (int) num3 * -1310671789 ^ 669592639;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public ImageCaptureRequest(ZoomWindow targetWindow, bool forceForeground = true)
    {
      this.Window = targetWindow;
      this.WindowHandle = this.Window.Handle;
      this.ForceForeground = forceForeground;
      this.TargetRegion = this.Window.Rectangle;
    }

    public ImageCaptureRequest(ZoomWindow targetWindow, Rectangle targetRegion, bool forceForeground = true)
    {
      this.Window = targetWindow;
      this.WindowHandle = this.Window.Handle;
      this.ForceForeground = forceForeground;
      System.Drawing.Point location = targetWindow.Location;
      int x = location.X + targetRegion.X;
      location = targetWindow.Location;
      int y = location.Y + targetRegion.Y;
      int width = targetRegion.Width;
      int height = targetRegion.Height;
      this.TargetRegion = new Rectangle(x, y, width, height);
    }

    public ImageCaptureRequest(IntPtr windowHandle, bool forceForeground = true)
    {
label_1:
      int num1 = 1474603397;
      while (true)
      {
        int num2 = 1077399777;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * 1058351379 ^ 1082986169;
            continue;
          case 1:
            num1 = (int) num3 * 1309323708 ^ -1879712114;
            continue;
          case 2:
            this.ForceForeground = forceForeground;
            num1 = (int) num3 * 194099658 ^ 1039339310;
            continue;
          case 3:
            num1 = (int) num3 * -1406813177 ^ 762908626;
            continue;
          case 4:
            this.TargetRegion = this.Window.Rectangle;
            num1 = (int) num3 * 1926336969 ^ -1986873442;
            continue;
          case 5:
            goto label_3;
          case 6:
            this.Window = this.Engine.GetWindow(windowHandle, true);
            num1 = (int) num3 * 1562387554 ^ -2070029318;
            continue;
          case 7:
            goto label_1;
          case 8:
            int num4 = this.Window == null ? 2053698697 : (num4 = 188980608);
            int num5 = (int) num3 * 420574900;
            num1 = num4 ^ num5;
            continue;
          case 9:
            this.TargetRegion = WindowHelper.GetWindowRectangle(windowHandle);
            num1 = (int) num3 * 1568395594 ^ 2017385305;
            continue;
          case 10:
            this.WindowHandle = windowHandle;
            num1 = (int) num3 * 507279555 ^ -473781256;
            continue;
          case 11:
            this.ForceForeground = forceForeground;
            num1 = 508468048;
            continue;
          case 12:
            num1 = (int) num3 * -1722039834 ^ -422426277;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    internal CaptureState SetState(CaptureState newState)
    {
      object requestLock = ImageCaptureRequest.requestLock;
      bool flag = false;
      try
      {
        ImageCaptureRequest.\u206C‪‏⁪​⁬‬⁫‪⁮⁬‍‮‭‍⁯‍‏‎⁬⁮‫​⁫⁭⁬⁮‎‫⁬‭‏​‪⁬‮⁮⁫‬⁯‮(requestLock, ref flag);
        this.CaptureState = newState;
      }
      finally
      {
        if (flag)
        {
label_3:
          int num1 = 1486734548;
          while (true)
          {
            int num2 = 2017614935;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_3;
              case 1:
                num1 = (int) num3 * -2127351160 ^ 1612190477;
                continue;
              case 3:
                ImageCaptureRequest.\u202C‫‭​⁯‌‬‏‮‏‌‭‎‎⁭​​‫⁪⁭⁯⁮‎⁯‪‮​⁫‬‬‭‏​‫⁭‬⁪‏⁭‬‮(requestLock);
                num1 = (int) num3 * 1423190496 ^ -1150840342;
                continue;
              default:
                goto label_7;
            }
          }
        }
label_7:;
      }
      CaptureState captureState = newState;
label_9:
      int num4 = 51066651;
      while (true)
      {
        int num1 = 2017614935;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 1:
            num4 = (int) num2 * -161702962 ^ 1993303051;
            continue;
          case 2:
            goto label_9;
          default:
            goto label_12;
        }
      }
label_12:
      return captureState;
    }

    internal void SetBitmapSource(BitmapSource source)
    {
      object requestLock = ImageCaptureRequest.requestLock;
      bool flag = false;
      try
      {
        ImageCaptureRequest.\u206C‪‏⁪​⁬‬⁫‪⁮⁬‍‮‭‍⁯‍‏‎⁬⁮‫​⁫⁭⁬⁮‎‫⁬‭‏​‪⁬‮⁮⁫‬⁯‮(requestLock, ref flag);
label_2:
        int num1 = -2032904753;
        while (true)
        {
          int num2 = -1467769839;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_11;
            case 1:
              this.BitmapSource = source;
              num1 = (int) num3 * 104272239 ^ -1724358567;
              continue;
            case 2:
              this.CaptureState = CaptureState.Captured;
              num1 = (int) num3 * -1331980272 ^ -1711723756;
              continue;
            case 3:
              num1 = (int) num3 * -1108640168 ^ 1930330062;
              continue;
            case 4:
              goto label_2;
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
          int num1 = -1852114416;
          while (true)
          {
            int num2 = -1467769839;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_9;
              case 2:
                ImageCaptureRequest.\u202C‫‭​⁯‌‬‏‮‏‌‭‎‎⁭​​‫⁪⁭⁯⁮‎⁯‪‮​⁫‬‬‭‏​‫⁭‬⁪‏⁭‬‮(requestLock);
                num1 = (int) num3 * 1850679449 ^ -1462628036;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    internal BitmapImage ToBitmapImage(BitmapSource bitmapSource)
    {
label_1:
      int num1 = -29353397;
      BitmapImage bitmapImage1;
      JpegBitmapEncoder jpegBitmapEncoder;
      while (true)
      {
        int num2 = -1905970749;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            bitmapImage1 = (BitmapImage) null;
            jpegBitmapEncoder = ImageCaptureRequest.\u200F⁪‭‬‍⁪⁯⁬⁯⁪​​⁪‎‍‬⁪​⁯‮⁪⁪‏⁪⁫‪‏‭‍‪‫⁯⁯⁭⁯‪‌‍‏‍‮();
            num1 = (int) num3 * -1761526511 ^ 872584437;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      MemoryStream memoryStream = ImageCaptureRequest.\u206D⁮‍⁮‎⁮‪‫⁬⁮⁫‮‫‪⁬‍⁯‌‫​‌⁮⁯‌⁭‌⁮‏​‍‪‬⁭‏⁭⁬⁭‎⁮‌‮();
      try
      {
label_6:
        int num2 = -84443504;
        while (true)
        {
          int num3 = -1905970749;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 11U)
          {
            case 0:
              num2 = (int) num4 * -791006016 ^ -1833469922;
              continue;
            case 1:
              num2 = (int) num4 * 1142749742 ^ -1350042573;
              continue;
            case 2:
              num2 = (int) num4 * 984925919 ^ -1952889310;
              continue;
            case 3:
              bitmapImage1 = ImageCaptureRequest.\u200C‪‫⁯‏⁪​⁪‭‬‍⁫‮‭⁬‪‍‏‏‏‪‫​‏⁪⁫‎⁮‭‪‌⁬⁮⁫​‪‬‌‮⁬‮();
              ImageCaptureRequest.\u206A‮‫⁮​‪⁭‮‍‏‎‌​‪⁭‏‫‭⁭‫‪‪‫‏‬⁬‍⁫⁮‭‍⁯‌‫‭‬‌⁫‌‎‮((BitmapEncoder) jpegBitmapEncoder).Add(ImageCaptureRequest.\u200B‮⁮‎‌‏⁭⁬⁯‎‭‍‮‭‭‍​‬⁫‫‎‬‮⁮‬⁯⁪‍⁫⁪⁮⁪‌‌⁯​‬‫‮⁮‮(bitmapSource));
              num2 = (int) num4 * 1783793690 ^ -336576677;
              continue;
            case 5:
              ImageCaptureRequest.\u206F⁪⁯‏⁪⁬‌⁯⁫‭‍​⁭‍​⁮⁫‎⁮‬⁯‌‍‮‍‌​‫‏‪⁪‎‭‍⁯⁪⁪⁬​‍‮((BitmapEncoder) jpegBitmapEncoder, (Stream) memoryStream);
              num2 = (int) num4 * -2079303388 ^ 1070224570;
              continue;
            case 6:
              ImageCaptureRequest.\u202C‎​​‬‬‬⁫​⁯⁯‍‍‫‬‏⁯‌⁮​⁯‬‬‪‎⁫‍‎‭‪‭⁫‬‫‏⁭‍‭⁫⁬‮((Stream) memoryStream);
              num2 = (int) num4 * 1363663469 ^ 794145221;
              continue;
            case 7:
              ImageCaptureRequest.\u202C‮⁮‭‌‫⁮⁮‍⁬⁮‌‍‭⁮‬⁭⁬‍‎⁭‭⁫‬⁮⁯‪‏⁮⁪‬‏‌‫‏‮‍‭‎‫‮(bitmapImage1, (Stream) ImageCaptureRequest.\u202B‭‎‪‫⁯⁮‭‭​⁯⁭‮‭‬⁮‮‏⁬‪⁪⁯‌‫‪⁪⁮‫⁮⁫‪⁪⁯⁬⁯‎​⁪⁬‪‮(ImageCaptureRequest.\u202A⁭‏⁯‍⁮⁯‫⁬⁬⁯‫‭‎‬‍‎​⁯‪⁬⁭‮⁮​‮⁫‌‮‍⁮​⁫‪⁪‮‫‭⁪‪‮(memoryStream)));
              num2 = (int) num4 * -754931410 ^ 398604300;
              continue;
            case 8:
              goto label_6;
            case 9:
              ImageCaptureRequest.\u200E⁯‍‍‎⁫⁬‬⁮‍⁫‭⁯‮⁭⁫‪‬⁮⁬‪‬‭⁯​​‭‪⁪⁪⁭‏⁬‪⁪‎‬⁮⁮‎‮(bitmapImage1);
              num2 = (int) num4 * -1175012543 ^ -683550385;
              continue;
            case 10:
              ImageCaptureRequest.\u206F⁯​‬‎‪⁬⁪‬⁭‬‬‍‮‫‭‫⁮⁪⁯⁮‬‭⁬⁫⁫⁭‭⁬​​‭⁭⁮‪⁬​⁬‬‪‮(bitmapImage1);
              num2 = (int) num4 * 1527214294 ^ 1118720207;
              continue;
            default:
              goto label_23;
          }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
label_18:
          int num2 = -61207022;
          while (true)
          {
            int num3 = -1905970749;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 891059579 ^ 2086299601;
                continue;
              case 1:
                ImageCaptureRequest.\u206C⁭‮⁫‮‏‮​⁯‭⁮⁪‫‮‬‪⁬⁭⁪‬⁭⁬‬⁫‪⁮​‏‏‍⁬‭‏⁯‪⁭⁪⁮‬‌‮((IDisposable) memoryStream);
                num2 = (int) num4 * 1371380491 ^ -46359296;
                continue;
              case 3:
                goto label_18;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_23:
      BitmapImage bitmapImage2 = bitmapImage1;
label_24:
      int num5 = -1312405309;
      while (true)
      {
        int num2 = -1905970749;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_24;
          case 2:
            num5 = (int) num3 * -1113415608 ^ 1715405745;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return bitmapImage2;
    }

    static void \u206C‪‏⁪​⁬‬⁫‪⁮⁬‍‮‭‍⁯‍‏‎⁬⁮‫​⁫⁭⁬⁮‎‫⁬‭‏​‪⁬‮⁮⁫‬⁯‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202C‫‭​⁯‌‬‏‮‏‌‭‎‎⁭​​‫⁪⁭⁯⁮‎⁯‪‮​⁫‬‬‭‏​‫⁭‬⁪‏⁭‬‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static JpegBitmapEncoder \u200F⁪‭‬‍⁪⁯⁬⁯⁪​​⁪‎‍‬⁪​⁯‮⁪⁪‏⁪⁫‪‏‭‍‪‫⁯⁯⁭⁯‪‌‍‏‍‮()
    {
      return new JpegBitmapEncoder();
    }

    static MemoryStream \u206D⁮‍⁮‎⁮‪‫⁬⁮⁫‮‫‪⁬‍⁯‌‫​‌⁮⁯‌⁭‌⁮‏​‍‪‬⁭‏⁭⁬⁭‎⁮‌‮()
    {
      return new MemoryStream();
    }

    static BitmapImage \u200C‪‫⁯‏⁪​⁪‭‬‍⁫‮‭⁬‪‍‏‏‏‪‫​‏⁪⁫‎⁮‭‪‌⁬⁮⁫​‪‬‌‮⁬‮()
    {
      return new BitmapImage();
    }

    static IList<BitmapFrame> \u206A‮‫⁮​‪⁭‮‍‏‎‌​‪⁭‏‫‭⁭‫‪‪‫‏‬⁬‍⁫⁮‭‍⁯‌‫‭‬‌⁫‌‎‮([In] BitmapEncoder obj0)
    {
      return obj0.Frames;
    }

    static BitmapFrame \u200B‮⁮‎‌‏⁭⁬⁯‎‭‍‮‭‭‍​‬⁫‫‎‬‮⁮‬⁯⁪‍⁫⁪⁮⁪‌‌⁯​‬‫‮⁮‮([In] BitmapSource obj0)
    {
      return BitmapFrame.Create(obj0);
    }

    static void \u206F⁪⁯‏⁪⁬‌⁯⁫‭‍​⁭‍​⁮⁫‎⁮‬⁯‌‍‮‍‌​‫‏‪⁪‎‭‍⁯⁪⁪⁬​‍‮([In] BitmapEncoder obj0, [In] Stream obj1)
    {
      obj0.Save(obj1);
    }

    static void \u206F⁯​‬‎‪⁬⁪‬⁭‬‬‍‮‫‭‫⁮⁪⁯⁮‬‭⁬⁫⁫⁭‭⁬​​‭⁭⁮‪⁬​⁬‬‪‮([In] BitmapImage obj0)
    {
      obj0.BeginInit();
    }

    static byte[] \u202A⁭‏⁯‍⁮⁯‫⁬⁬⁯‫‭‎‬‍‎​⁯‪⁬⁭‮⁮​‮⁫‌‮‍⁮​⁫‪⁪‮‫‭⁪‪‮([In] MemoryStream obj0)
    {
      return obj0.ToArray();
    }

    static MemoryStream \u202B‭‎‪‫⁯⁮‭‭​⁯⁭‮‭‬⁮‮‏⁬‪⁪⁯‌‫‪⁪⁮‫⁮⁫‪⁪⁯⁬⁯‎​⁪⁬‪‮([In] byte[] obj0)
    {
      return new MemoryStream(obj0);
    }

    static void \u202C‮⁮‭‌‫⁮⁮‍⁬⁮‌‍‭⁮‬⁭⁬‍‎⁭‭⁫‬⁮⁯‪‏⁮⁪‬‏‌‫‏‮‍‭‎‫‮([In] BitmapImage obj0, [In] Stream obj1)
    {
      obj0.StreamSource = obj1;
    }

    static void \u200E⁯‍‍‎⁫⁬‬⁮‍⁫‭⁯‮⁭⁫‪‬⁮⁬‪‬‭⁯​​‭‪⁪⁪⁭‏⁬‪⁪‎‬⁮⁮‎‮([In] BitmapImage obj0)
    {
      obj0.EndInit();
    }

    static void \u202C‎​​‬‬‬⁫​⁯⁯‍‍‫‬‏⁯‌⁮​⁯‬‬‪‎⁫‍‎‭‪‭⁫‬‫‏⁭‍‭⁫⁬‮([In] Stream obj0)
    {
      obj0.Close();
    }

    static void \u206C⁭‮⁫‮‏‮​⁯‭⁮⁪‫‮‬‪⁬⁭⁪‬⁭⁬‬⁫‪⁮​‏‏‍⁬‭‏⁯‪⁭⁪⁮‬‌‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static object \u200E‏‌‬⁫‫‪‎⁬⁫⁮‏‮⁬​‮‍‪​⁮​⁭​⁫‏​⁯⁯⁯‍‮⁫⁮‭‎​‫‎‫‪‮()
    {
      return new object();
    }
  }
}
