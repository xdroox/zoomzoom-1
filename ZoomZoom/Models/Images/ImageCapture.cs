// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.ImageCapture
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ZoomZoom.Models.Images
{
  internal class ImageCapture : CoreObject
  {
    private Rectangle targetRegion = Rectangle.Empty;
    private ImageEnums.ImageType imageType = ImageEnums.ImageType.Undefined;
    private DateTime captureTime = DateTime.MinValue;
    private ZoomImage image = (ZoomImage) null;
    private CaptureState state = CaptureState.Unknown;
    private ZoomWindow zoomWindow;
    private ImageOptions options;
    private string fileName;
    private BitmapSource source;
    private IntPtr windowHandle;
    private string windowTitle;
    private ZoomMeeting meeting;

    internal BitmapSource BitmapSource
    {
      get
      {
label_1:
        int num1 = -1639698171;
        BitmapSource source;
        while (true)
        {
          int num2 = -823821016;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              source = this.source;
              num1 = (int) num3 * 1437653264 ^ -1441078771;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return source;
      }
      set
      {
label_1:
        int num1 = -1743832630;
        while (true)
        {
          int num2 = -255732212;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 218976921 ^ 1554992486;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3485214181U));
              num1 = (int) num3 * 84973400 ^ 870348119;
              continue;
            case 2:
              this.source = value;
              num1 = (int) num3 * -1562056425 ^ 1639810621;
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
    }

    internal IntPtr WindowHandle
    {
      get
      {
label_1:
        int num1 = 1479874304;
        IntPtr windowHandle;
        while (true)
        {
          int num2 = 1569857209;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 665887375 ^ -161350157;
              continue;
            case 1:
              windowHandle = this.windowHandle;
              num1 = (int) num3 * 329368971 ^ 946765706;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return windowHandle;
      }
      set
      {
        this.windowHandle = value;
label_1:
        int num1 = -895096810;
        while (true)
        {
          int num2 = -1516249885;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 88929653 ^ -131485531;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3062201157U));
              num1 = (int) num3 * -681345643 ^ -2079575618;
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

    internal string WindowTitle
    {
      get
      {
        return this.windowTitle;
      }
      set
      {
        this.windowTitle = value;
label_1:
        int num1 = -492069859;
        while (true)
        {
          int num2 = -611067617;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3939561489U));
              num1 = (int) num3 * -8413552 ^ -34985473;
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

    internal ZoomMeeting Meeting
    {
      get
      {
label_1:
        int num1 = 1475818367;
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = 1792006335;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meeting = this.meeting;
              num1 = (int) num3 * -543387421 ^ 2112245608;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meeting;
      }
      set
      {
        this.meeting = value;
label_1:
        int num1 = -2132928298;
        while (true)
        {
          int num2 = -1890001859;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(846979453U));
              num1 = (int) num3 * -46798472 ^ 654942057;
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

    internal DateTime CaptureTime
    {
      get
      {
label_1:
        int num1 = 406483325;
        DateTime captureTime;
        while (true)
        {
          int num2 = 1747628354;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              captureTime = this.CaptureTime;
              num1 = (int) num3 * -791694264 ^ -1587987138;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return captureTime;
      }
      set
      {
label_1:
        int num1 = 491210579;
        while (true)
        {
          int num2 = 1246708877;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              this.captureTime = value;
              num1 = (int) num3 * -1901004983 ^ 377457606;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1643172887U));
      }
    }

    internal ZoomWindow Window
    {
      get
      {
        ZoomWindow zoomWindow = this.zoomWindow;
label_1:
        int num1 = 1792570270;
        while (true)
        {
          int num2 = 1657009456;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 817247997 ^ 551276706;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomWindow;
      }
      set
      {
        this.zoomWindow = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1715552363U));
label_1:
        int num1 = 1022293105;
        while (true)
        {
          int num2 = 730287415;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 934938617 ^ 529950884;
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

    public CaptureState State
    {
      get
      {
        return this.state;
      }
      set
      {
label_1:
        int num1 = -9561613;
        while (true)
        {
          int num2 = -1067528066;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.state = value;
              num1 = (int) num3 * -1749008790 ^ -1732239677;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4196592338U));
              num1 = (int) num3 * 1539576788 ^ 1116102010;
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

    public ZoomImage Image
    {
      get
      {
label_1:
        int num1 = -1819411402;
        ZoomImage image;
        while (true)
        {
          int num2 = -987079625;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 651316774 ^ -631241076;
              continue;
            case 1:
              image = this.image;
              num1 = (int) num3 * -808672073 ^ 979131628;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return image;
      }
      set
      {
        this.image = value;
      }
    }

    public string FileName
    {
      get
      {
        bool flag = ImageCapture.\u206C⁬⁮‮‪⁯‪​‮⁮‫⁪‪‫‮⁪‪‭⁬‌⁯⁯⁪⁯‎⁯⁬‬‭‫‬⁪‭‫‏⁫‮⁬​‏‮(this.fileName);
label_1:
        int num1 = 2116236847;
        string fileName;
        while (true)
        {
          int num2 = 1787594846;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              num1 = (int) num3 * -883773291 ^ -1438997299;
              continue;
            case 1:
              num1 = (int) num3 * -684704410 ^ -508611328;
              continue;
            case 2:
              int num4 = flag ? -1056183908 : (num4 = -1938234868);
              int num5 = (int) num3 * -474032848;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = 691886140;
              continue;
            case 4:
              num1 = 1364176885;
              continue;
            case 5:
              this.fileName = this.Engine.Settings.ImageRoot + (object) this.zoomWindow.ZoomWindowType + \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2656257519U) + DateTime.Now.ToString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2522958625U)) + \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2583919998U);
              num1 = (int) num3 * 1286545802 ^ -1958680741;
              continue;
            case 6:
              num1 = (int) num3 * 472399261 ^ -1728294577;
              continue;
            case 7:
              fileName = this.fileName;
              num1 = 1851377168;
              continue;
            case 9:
              this.fileName = this.Engine.Settings.ImageRoot + \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2666172252U) + DateTime.Now.ToString(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1281275507U)) + \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2623221251U);
              num1 = (int) num3 * 1570926056 ^ 989063848;
              continue;
            case 10:
              goto label_1;
            case 11:
              int num6 = this.zoomWindow != null ? 1536524661 : (num6 = 308470372);
              int num7 = (int) num3 * -709302790;
              num1 = num6 ^ num7;
              continue;
            case 12:
              num1 = (int) num3 * -1476235291 ^ -1102384476;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return fileName;
      }
      set
      {
        this.fileName = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 169874411;
        TraceType traceType;
        while (true)
        {
          int num2 = 1260394491;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Image;
              num1 = (int) num3 * 1216962545 ^ -2100233372;
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

    public Rectangle TargetRegion
    {
      get
      {
        Rectangle targetRegion = this.targetRegion;
label_1:
        int num1 = 1599749930;
        while (true)
        {
          int num2 = 950157305;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 515698162 ^ 472113146;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return targetRegion;
      }
      set
      {
        this.targetRegion = value;
      }
    }

    internal ImageCapture(ZoomWindow window, Rectangle region, ImageEnums.ImageType imageType, ImageOptions options = null)
    {
label_1:
      int num1 = 825023927;
      while (true)
      {
        int num2 = 1824119577;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 23U)
        {
          case 0:
            int num4 = flag2 ? 467071218 : (num4 = 1596826391);
            int num5 = (int) num3 * -49528297;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * -1378726830 ^ -1462532644;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 326879370 ^ 598809911;
            continue;
          case 4:
            num1 = (int) num3 * -624447466 ^ -1567617650;
            continue;
          case 5:
            options = new ImageOptions();
            num1 = (int) num3 * -417238371 ^ -1973034047;
            continue;
          case 6:
            num1 = (int) num3 * 75634732 ^ -1805815581;
            continue;
          case 7:
            num1 = (int) num3 * 786681980 ^ -1456916102;
            continue;
          case 8:
            goto label_3;
          case 9:
            this.Meeting = this.Engine.ActiveMeeting;
            num1 = 421875908;
            continue;
          case 10:
            flag1 = options == null;
            num1 = (int) num3 * 1792822887 ^ -1708356251;
            continue;
          case 11:
            goto label_24;
          case 12:
            this.TargetRegion = region;
            num1 = (int) num3 * -1808855775 ^ 947886405;
            continue;
          case 13:
            this.Window = window;
            num1 = (int) num3 * 1743781892 ^ -494379153;
            continue;
          case 14:
            this.State = CaptureState.Pending;
            num1 = (int) num3 * 1372435395 ^ 309658755;
            continue;
          case 15:
            num1 = (int) num3 * -1038803282 ^ -257315376;
            continue;
          case 16:
            num1 = (int) num3 * 1096378158 ^ -1522833310;
            continue;
          case 17:
            this.WindowHandle = window.Handle;
            num1 = (int) num3 * -1599867635 ^ -625091584;
            continue;
          case 18:
            num1 = (int) num3 * 918658498 ^ -1790081367;
            continue;
          case 19:
            num1 = (int) num3 * -1698849711 ^ 2014829577;
            continue;
          case 20:
            this.WindowTitle = WindowHelper.GetWindowTitle(this.WindowHandle);
            num1 = (int) num3 * -747989284 ^ 1743400376;
            continue;
          case 21:
            int num6 = flag1 ? -2028815004 : (num6 = -2005181193);
            int num7 = (int) num3 * -906791573;
            num1 = num6 ^ num7;
            continue;
          case 22:
            this.imageType = imageType;
            flag2 = this.Window != null;
            num1 = (int) num3 * -1967214755 ^ -1402574520;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return;
label_3:
      return;
label_24:
      throw ImageCapture.\u202A⁪⁫⁯⁫⁬‏⁬⁫⁬⁭‬​⁯⁮⁬‪‮‪‭‌⁫⁯‌⁯‫​‭⁮‮‭⁭‪⁫⁫⁯​⁯‮‏‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1814657193U));
    }

    public override string ToString()
    {
      string str = ImageCapture.\u200D⁪‍‌⁮⁯​⁮⁭‏‬‭‏⁬‍‏‫‍⁯⁯⁫‌‫‮‌⁪‮‬⁪‌‍​⁬⁭‏‪‍⁮⁪⁭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(622519206U), this.BitmapSource == null ? (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1608994172U) : (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1624512430U), (object) this.windowTitle, (object) this.captureTime);
label_1:
      int num1 = 804926249;
      while (true)
      {
        int num2 = 1329168284;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 2016592152 ^ 817259619;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return str;
    }

    public CaptureState Capture()
    {
      try
      {
label_2:
        int num1 = 1418237637;
        while (true)
        {
          int num2 = 1861967932;
          uint num3;
          Rectangle targetArea;
          bool flag1;
          bool flag2;
          bool flag3;
          bool flag4;
          int num4;
          int num5;
          int num6;
          switch ((num3 = (uint) (num1 ^ num2)) % 32U)
          {
            case 0:
              num4 = this.WindowHandle != IntPtr.Zero ? 1 : 0;
              goto label_30;
            case 1:
              num1 = (int) num3 * -942013922 ^ -1026390241;
              continue;
            case 2:
              num1 = (int) num3 * 1982281149 ^ -868449927;
              continue;
            case 3:
              int num7 = !flag3 ? -1269114476 : (num7 = -2060708755);
              int num8 = (int) num3 * 425574000;
              num1 = num7 ^ num8;
              continue;
            case 4:
              num1 = (int) num3 * -40535071 ^ -964942270;
              continue;
            case 5:
              int num9 = !flag1 ? -1856652550 : (num9 = -718641782);
              int num10 = (int) num3 * -2021402696;
              num1 = num9 ^ num10;
              continue;
            case 6:
              targetArea = this.Window.Rectangle;
              num1 = (int) num3 * 117733689 ^ 2130486503;
              continue;
            case 7:
              num1 = (int) num3 * 1910703357 ^ 1401254680;
              continue;
            case 8:
              if (this.WindowHandle == IntPtr.Zero)
              {
                num1 = (int) num3 * -639480064 ^ 1374243535;
                continue;
              }
              break;
            case 9:
              num6 = this.TargetRegion != Rectangle.Empty ? 1 : 0;
              goto label_20;
            case 10:
              int num11 = flag2 ? 1079314485 : (num11 = 1406444750);
              int num12 = (int) num3 * 839406427;
              num1 = num11 ^ num12;
              continue;
            case 11:
              int num13 = flag4 ? 1993436157 : (num13 = 1905073710);
              int num14 = (int) num3 * 632340527;
              num1 = num13 ^ num14;
              continue;
            case 12:
              if (!(targetArea != Rectangle.Empty))
              {
                num6 = 0;
                goto label_20;
              }
              else
              {
                num1 = 603372821;
                continue;
              }
            case 13:
              num1 = (int) num3 * 358748854 ^ 1413496558;
              continue;
            case 14:
              num1 = (int) num3 * 1752567094 ^ -1434109540;
              continue;
            case 15:
              this.source = ImageCapture.CaptureRegion(targetArea, true);
              this.Image = new ZoomImage(this.Window, this.source);
              num1 = (int) num3 * -258896821 ^ 1975776264;
              continue;
            case 16:
              num1 = (int) num3 * 1816664671 ^ -1783678496;
              continue;
            case 17:
              this.State = CaptureState.Captured;
              num1 = (int) num3 * -1476085113 ^ -1635202615;
              continue;
            case 18:
              targetArea.Size = this.TargetRegion.Size;
              num1 = (int) num3 * 1067836517 ^ 369083773;
              continue;
            case 19:
              num5 = this.TargetRegion == Rectangle.Empty ? 1 : 0;
              goto label_17;
            case 20:
              goto label_5;
            case 21:
              goto label_2;
            case 22:
              num1 = (int) num3 * -860120491 ^ 1557486740;
              continue;
            case 23:
              int num15;
              num1 = num15 = this.Window == null ? 1936528528 : (num15 = 1769361450);
              continue;
            case 24:
              flag2 = targetArea != Rectangle.Empty;
              num1 = 1902172246;
              continue;
            case 25:
              targetArea = Rectangle.Empty;
              if (this.Window == null)
              {
                num1 = (int) num3 * -1386744918 ^ 2111528494;
                continue;
              }
              break;
            case 26:
              targetArea = WindowHelper.GetWindowRectangle(this.WindowHandle);
              num1 = (int) num3 * 637992003 ^ -1327939326;
              continue;
            case 27:
              num1 = (int) num3 * 2091262725 ^ -1802628829;
              continue;
            case 29:
              targetArea.Offset(this.TargetRegion.Location);
              num1 = (int) num3 * -1771741607 ^ -2137502149;
              continue;
            case 30:
              if (this.Window != null)
              {
                num4 = 0;
                goto label_30;
              }
              else
              {
                num1 = 1982921404;
                continue;
              }
            case 31:
              num1 = (int) num3 * 825767934 ^ -1684775006;
              continue;
            default:
              goto label_48;
          }
          num5 = 0;
label_17:
          flag1 = num5 != 0;
          num1 = 1757081049;
          continue;
label_20:
          flag3 = num6 != 0;
          num1 = 107226687;
          continue;
label_30:
          flag4 = num4 != 0;
          num1 = 779168951;
        }
label_5:
        return CaptureState.Error;
      }
      catch (Exception ex)
      {
        this.TraceError(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3135048408U), ex);
label_45:
        int num1 = 1984288131;
        while (true)
        {
          int num2 = 1861967932;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1221430082 ^ 1494452828;
              continue;
            case 2:
              goto label_45;
            default:
              goto label_48;
          }
        }
      }
label_48:
      return this.State;
    }

    private static BitmapSource CaptureWindow(IntPtr handle, bool recolorBackground, System.Windows.Media.Color substituteBackgroundColor, bool addToClipboard)
    {
      Rectangle windowRectangle = WindowHelper.GetWindowRectangle(handle);
label_1:
      int num1 = -651781605;
      BitmapSource bitmapSource1;
      while (true)
      {
        int num2 = -779448380;
        uint num3;
        BitmapSource bitmapSource2;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            bitmapSource1 = bitmapSource2;
            num1 = (int) num3 * -2071302956 ^ 1344326978;
            continue;
          case 1:
            User32.SetForegroundWindow(handle);
            num1 = (int) num3 * 1696679807 ^ 1351756085;
            continue;
          case 2:
            bitmapSource2 = ImageHelper.CaptureRegion(handle, windowRectangle.X, windowRectangle.Y, windowRectangle.Width, windowRectangle.Height, true);
            num1 = (int) num3 * -1452300557 ^ 591556692;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1661792810 ^ 825595929;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return bitmapSource1;
    }

    private static BitmapSource CaptureRegion(int x, int y, int width, int height, bool addToClipboard)
    {
label_1:
      int num1 = 1502088057;
      BitmapSource bitmapSource;
      while (true)
      {
        int num2 = 1034889752;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            bitmapSource = ImageHelper.CaptureRegion(User32.GetDesktopWindow(), x, y, width, height, addToClipboard);
            num1 = (int) num3 * -625384065 ^ -570693284;
            continue;
          case 3:
            num1 = (int) num3 * -1815194650 ^ -174590648;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return bitmapSource;
    }

    private static BitmapSource CaptureRegion(Rectangle targetArea, bool copyToClipboard)
    {
label_1:
      int num1 = -1450861730;
      BitmapSource bitmapSource;
      while (true)
      {
        int num2 = -692545691;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            bitmapSource = ImageCapture.CaptureRegion(targetArea.X, targetArea.Y, targetArea.Width, targetArea.Height, copyToClipboard);
            num1 = (int) num3 * 1458477633 ^ -2108331340;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return bitmapSource;
    }

    private static BitmapSource CaptureFullScreen(bool addToClipboard)
    {
label_1:
      int num1 = 1371873598;
      BitmapSource bitmapSource;
      while (true)
      {
        int num2 = 1175991625;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            bitmapSource = ImageHelper.CaptureRegion(User32.GetDesktopWindow(), (int) ImageCapture.\u202A⁬⁪‭⁮‏⁬⁭‪‮‪⁬⁬⁯​⁮⁯​‪‮⁬‌‌​‪⁪‫⁭‫‬‫‏‫⁬‪‫⁮⁬‍⁭‮(), (int) ImageCapture.\u202B‪⁫⁪‬⁭‪‍⁮‌⁮⁪‭‌‮‪‪‮‏‭‪‏‎​‫⁪‬‌⁭‮⁬‫‎​⁬⁬⁯⁫⁫‮(), (int) ImageCapture.\u200D⁫‎⁪⁯‎‎‮‌‌‮⁯‌⁭⁯‪⁬‎‭⁬⁫‬​‮​‪⁯‎‪‮‮‍‌⁫‪‌‍⁬⁫‍‮(), (int) ImageCapture.\u202B⁮‭⁬‌​​‮⁬‫​⁫‏‮⁭‍‌⁯⁮‪‮‫‫‍‍​‎‌⁭​⁮​⁫‍‬⁪‪​‫‮‮(), addToClipboard);
            num1 = (int) num3 * -855618181 ^ 256363620;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return bitmapSource;
    }

    private void SaveClipboardImageToFile(string filePath, bool spawnProcess)
    {
      try
      {
label_2:
        int num1 = -2132515987;
        BitmapSource bitmapSource;
        while (true)
        {
          int num2 = -205506198;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 1:
              num1 = (int) num3 * -1090402105 ^ 204659647;
              continue;
            case 2:
              if (bitmapSource != null)
              {
                num1 = (int) num3 * 1237053192 ^ 908339310;
                continue;
              }
              goto label_26;
            case 3:
              bitmapSource = ImageCapture.\u202E⁮⁮‮⁮⁬⁫‭‭‮‮‫⁯‎‬⁫⁫‌‎⁪⁬‬‎‫‌​⁬⁮‮‭‬⁯‪⁪⁫‍‍‭‏‍‮();
              num1 = (int) num3 * -1635018711 ^ -877643381;
              continue;
            case 4:
              goto label_2;
            default:
              goto label_8;
          }
        }
label_8:
        FileStream fileStream = ImageCapture.\u206B‍⁬​‏⁮‭⁬‌⁭‫‌‌‮⁯⁫‏‭⁬⁫‏⁬‫‮‬⁮‏⁭‬‭‬⁪‌⁫‮​‎‮‭‍‮(filePath, FileMode.Create);
        try
        {
          BitmapEncoder bitmapEncoder = (BitmapEncoder) ImageCapture.\u202A⁬‎‬‏‭‫⁮⁮⁪‏‫‏‬⁫‭⁭​⁪​⁭‌‎‫‮‌‮‬‬‬‬⁯‫‌⁫⁫⁯⁭⁭⁭‮();
label_10:
          int num2 = -1440876145;
          while (true)
          {
            int num3 = -205506198;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                ImageCapture.\u200B‪‎⁮⁮‏‌‌⁭​‮⁬‪⁪‍⁫​⁪‭‭‭‭⁪‌‪​‌‮‌‭⁯​⁮​‍‌⁭⁮⁭⁭‮(bitmapEncoder, (Stream) fileStream);
                num2 = (int) num4 * -2094473310 ^ 243330181;
                continue;
              case 1:
                ImageCapture.\u200F⁯‬⁮‎⁭‍‌‭⁭‍⁫‏⁯⁮⁬⁫‬⁪‮‭‏‎‍‎‌‬‍‎‏‍‎‫‫⁪‫⁭‎⁯⁫‮(bitmapEncoder).Add(ImageCapture.\u200D⁪‌⁪‎⁪⁪⁪​⁫⁮‬‎‍‫‭‏‎⁪‎⁫‎⁮⁯‏⁬⁫⁯‍‭‫‏⁮‍‌​‎‭‭⁭‮(bitmapSource));
                num2 = (int) num4 * 1362002277 ^ -995344177;
                continue;
              case 2:
                goto label_10;
              default:
                goto label_19;
            }
          }
        }
        finally
        {
          if (fileStream != null)
          {
label_15:
            int num2 = -1029162003;
            while (true)
            {
              int num3 = -205506198;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_15;
                case 2:
                  ImageCapture.\u202E⁮‌‍⁬‮‏‌⁪⁮‍‭‫‌⁫‍​​‮‍‎‎​⁫⁮⁬‭​‎‪‎‫​‌⁪⁫⁯⁬‏‌‮((IDisposable) fileStream);
                  num2 = (int) num4 * -1864547826 ^ 452027231;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
label_19:
        bool flag = spawnProcess;
label_20:
        int num5 = -1080670502;
label_21:
        while (true)
        {
          int num2 = -205506198;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 9U)
          {
            case 0:
              goto label_38;
            case 1:
              num5 = (int) num3 * -1672117344 ^ -78733097;
              continue;
            case 2:
              num5 = -419100893;
              continue;
            case 3:
              int num4 = flag ? 1091958620 : (num4 = 1278415800);
              int num6 = (int) num3 * 1927308904;
              num5 = num4 ^ num6;
              continue;
            case 4:
              num5 = (int) num3 * -495649811 ^ -1330494472;
              continue;
            case 5:
              num5 = -2032477305;
              continue;
            case 6:
              ImageCapture.\u206A⁭‬⁪‍⁮‫⁭‬‫⁭⁭‎⁭‎⁬‭‬‌‌‍‪⁯⁯⁯‎‭‬⁫​​‬‏⁯‌⁪‬⁯‭‍‮(filePath);
              num5 = (int) num3 * -390570592 ^ 412009464;
              continue;
            case 7:
              goto label_20;
            case 8:
              goto label_26;
            default:
              goto label_34;
          }
        }
label_34:
        return;
label_38:
        return;
label_26:
        ImageCapture.\u200E‎⁬⁬⁯‍‬⁬‌⁮‪‍‍‏⁯‌⁬⁭‬​⁬‮⁯⁯‫⁮⁮⁬⁪‬⁯‍⁮‪​‮‫‮⁪⁬‮(CoreObject.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3388223828U));
        num5 = -83176319;
        goto label_21;
      }
      catch (Exception ex)
      {
label_32:
        int num1 = -1356690867;
        while (true)
        {
          int num2 = -205506198;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -2137261774 ^ -2143530123;
              continue;
            case 1:
              num1 = (int) num3 * -1742285710 ^ 1966745889;
              continue;
            case 2:
              goto label_30;
            case 3:
              ImageCapture.\u200E‎⁬⁬⁯‍‬⁬‌⁮‪‍‍‏⁯‌⁬⁭‬​⁬‮⁯⁯‫⁮⁮⁬⁪‬⁯‍⁮‪​‮‫‮⁪⁬‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -617704581 ^ -1413672601;
              continue;
            case 4:
              goto label_32;
            default:
              goto label_22;
          }
        }
label_22:
        return;
label_30:;
      }
    }

    static bool \u206C⁬⁮‮‪⁯‪​‮⁮‫⁪‪‫‮⁪‪‭⁬‌⁯⁯⁪⁯‎⁯⁬‬‭‫‬⁪‭‫‏⁫‮⁬​‏‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static Exception \u202A⁪⁫⁯⁫⁬‏⁬⁫⁬⁭‬​⁯⁮⁬‪‮‪‭‌⁫⁯‌⁯‫​‭⁮‮‭⁭‪⁫⁫⁯​⁯‮‏‮([In] string obj0)
    {
      return new Exception(obj0);
    }

    static string \u200D⁪‍‌⁮⁯​⁮⁭‏‬‭‏⁬‍‏‫‍⁯⁯⁫‌‫‮‌⁪‮‬⁪‌‍​⁬⁭‏‪‍⁮⁪⁭‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      return string.Format(obj0, obj1, obj2, obj3);
    }

    static double \u202A⁬⁪‭⁮‏⁬⁭‪‮‪⁬⁬⁯​⁮⁯​‪‮⁬‌‌​‪⁪‫⁭‫‬‫‏‫⁬‪‫⁮⁬‍⁭‮()
    {
      return SystemParameters.VirtualScreenLeft;
    }

    static double \u202B‪⁫⁪‬⁭‪‍⁮‌⁮⁪‭‌‮‪‪‮‏‭‪‏‎​‫⁪‬‌⁭‮⁬‫‎​⁬⁬⁯⁫⁫‮()
    {
      return SystemParameters.VirtualScreenTop;
    }

    static double \u200D⁫‎⁪⁯‎‎‮‌‌‮⁯‌⁭⁯‪⁬‎‭⁬⁫‬​‮​‪⁯‎‪‮‮‍‌⁫‪‌‍⁬⁫‍‮()
    {
      return SystemParameters.VirtualScreenWidth;
    }

    static double \u202B⁮‭⁬‌​​‮⁬‫​⁫‏‮⁭‍‌⁯⁮‪‮‫‫‍‍​‎‌⁭​⁮​⁫‍‬⁪‪​‫‮‮()
    {
      return SystemParameters.VirtualScreenHeight;
    }

    static BitmapSource \u202E⁮⁮‮⁮⁬⁫‭‭‮‮‫⁯‎‬⁫⁫‌‎⁪⁬‬‎‫‌​⁬⁮‮‭‬⁯‪⁪⁫‍‍‭‏‍‮()
    {
      return Clipboard.GetImage();
    }

    static FileStream \u206B‍⁬​‏⁮‭⁬‌⁭‫‌‌‮⁯⁫‏‭⁬⁫‏⁬‫‮‬⁮‏⁭‬‭‬⁪‌⁫‮​‎‮‭‍‮([In] string obj0, [In] FileMode obj1)
    {
      return new FileStream(obj0, obj1);
    }

    static PngBitmapEncoder \u202A⁬‎‬‏‭‫⁮⁮⁪‏‫‏‬⁫‭⁭​⁪​⁭‌‎‫‮‌‮‬‬‬‬⁯‫‌⁫⁫⁯⁭⁭⁭‮()
    {
      return new PngBitmapEncoder();
    }

    static IList<BitmapFrame> \u200F⁯‬⁮‎⁭‍‌‭⁭‍⁫‏⁯⁮⁬⁫‬⁪‮‭‏‎‍‎‌‬‍‎‏‍‎‫‫⁪‫⁭‎⁯⁫‮([In] BitmapEncoder obj0)
    {
      return obj0.Frames;
    }

    static BitmapFrame \u200D⁪‌⁪‎⁪⁪⁪​⁫⁮‬‎‍‫‭‏‎⁪‎⁫‎⁮⁯‏⁬⁫⁯‍‭‫‏⁮‍‌​‎‭‭⁭‮([In] BitmapSource obj0)
    {
      return BitmapFrame.Create(obj0);
    }

    static void \u200B‪‎⁮⁮‏‌‌⁭​‮⁬‪⁪‍⁫​⁪‭‭‭‭⁪‌‪​‌‮‌‭⁯​⁮​‍‌⁭⁮⁭⁭‮([In] BitmapEncoder obj0, [In] Stream obj1)
    {
      obj0.Save(obj1);
    }

    static void \u202E⁮‌‍⁬‮‏‌⁪⁮‍‭‫‌⁫‍​​‮‍‎‎​⁫⁮⁬‭​‎‪‎‫​‌⁪⁫⁯⁬‏‌‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Process \u206A⁭‬⁪‍⁮‫⁭‬‫⁭⁭‎⁭‎⁬‭‬‌‌‍‪⁯⁯⁯‎‭‬⁫​​‬‏⁯‌⁪‬⁯‭‍‮([In] string obj0)
    {
      return Process.Start(obj0);
    }

    static void \u200E‎⁬⁬⁯‍‬⁬‌⁮‪‍‍‏⁯‌⁬⁭‬​⁬‮⁯⁯‫⁮⁮⁬⁪‬⁯‍⁮‪​‮‫‮⁪⁬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }
  }
}
