// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Windows;

namespace ZoomZoom
{
  public class ZoomWindow : CoreObject
  {
    private static BaseWindow window = new BaseWindow();
    private IntPtr handle = IntPtr.Zero;
    private DateTime windowSpotlighted = DateTime.Now;
    private Rectangle rectangle = Rectangle.Empty;
    private Rectangle defaultRectangle = Rectangle.Empty;
    private int threadId = 0;
    private bool applyWindowLayout = false;
    private WindowVisibility defaultVisibility = WindowVisibility.Ignore;
    private IntPtr parent = IntPtr.Zero;
    private IntPtr owner = IntPtr.Zero;
    private IntPtr child = IntPtr.Zero;
    private IntPtr previous = IntPtr.Zero;
    private IntPtr next = IntPtr.Zero;
    private LayoutPattern pattern = (LayoutPattern) null;
    private WindowLayout windowLayout = (WindowLayout) null;
    private bool highlighted = false;
    private DateTime windowMoved = DateTime.MinValue;
    private new readonly IEventAggregator _eventAggregator = (IEventAggregator) null;
    private static readonly object windowLocker;
    private DateTime windowDetected;
    private DateTime windowInspected;
    private DateTime windowChanged;
    private string title;
    private string className;
    private string styles;
    private string extendedStyles;
    private bool isVisible;
    private int processId;
    private WindowType windowType;
    private ZoomWindowType zoomWindowType;
    private string itemType;
    private string[] itemStrings;
    private string[] itemStyles;
    private IntPtr itemHandle;
    private static List<ZoomEvent> windowEvents;

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Window;
label_1:
        int num1 = 1606259471;
        while (true)
        {
          int num2 = 1682029262;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 109753177 ^ 939564724;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public DateTime WindowMoved
    {
      get
      {
        return this.windowMoved;
      }
      set
      {
label_1:
        int num1 = -1308946423;
        while (true)
        {
          int num2 = -2098496460;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.windowMoved = value;
              num1 = (int) num3 * 1229500715 ^ 1604072961;
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

    public DateTime WindowDetected
    {
      get
      {
label_1:
        int num1 = -871016028;
        DateTime windowDetected;
        while (true)
        {
          int num2 = -636952993;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 205063797 ^ -1621767464;
              continue;
            case 3:
              windowDetected = this.windowDetected;
              num1 = (int) num3 * -1720930927 ^ 544607541;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowDetected;
      }
      set
      {
label_1:
        int num1 = -1372806635;
        while (true)
        {
          int num2 = -392232039;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.windowDetected = value;
              num1 = (int) num3 * 1921178178 ^ 1602910867;
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

    public DateTime WindowInspected
    {
      get
      {
        return this.windowInspected;
      }
      set
      {
        object windowLocker = ZoomWindow.windowLocker;
        bool flag = false;
        try
        {
          ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_2:
          int num1 = 992940923;
          while (true)
          {
            int num2 = 1805386819;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                goto label_11;
              case 1:
                num1 = (int) num3 * 1486880067 ^ -669379098;
                continue;
              case 2:
                goto label_2;
              case 3:
                num1 = (int) num3 * -2096119067 ^ -1824273491;
                continue;
              case 4:
                this.windowInspected = value;
                num1 = (int) num3 * -882497478 ^ -641670231;
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
            int num1 = 1782819516;
            while (true)
            {
              int num2 = 1805386819;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_9;
                case 2:
                  num1 = (int) num3 * 58748831 ^ -584474792;
                  continue;
                case 3:
                  ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                  num1 = (int) num3 * -234009032 ^ -378043015;
                  continue;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
      }
    }

    public DateTime WindowSpotlighted
    {
      get
      {
        return this.windowSpotlighted;
      }
      set
      {
        object windowLocker = ZoomWindow.windowLocker;
        bool flag = false;
        try
        {
          ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_2:
          int num1 = 1796582764;
          while (true)
          {
            int num2 = 828799807;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                this.windowSpotlighted = value;
                num1 = (int) num3 * -1261498639 ^ 1204911748;
                continue;
              case 2:
                goto label_9;
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
            int num1 = 795226125;
            while (true)
            {
              int num2 = 828799807;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_7;
                case 2:
                  ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                  num1 = (int) num3 * -92777936 ^ -283416559;
                  continue;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
      }
    }

    public DateTime WindowChanged
    {
      get
      {
label_1:
        int num1 = 137527924;
        DateTime windowChanged;
        while (true)
        {
          int num2 = 341997203;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -935145900 ^ -1742499371;
              continue;
            case 3:
              windowChanged = this.windowChanged;
              num1 = (int) num3 * 924528121 ^ 1810110969;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowChanged;
      }
    }

    public IntPtr Handle
    {
      get
      {
label_1:
        int num1 = -995210505;
        IntPtr handle;
        while (true)
        {
          int num2 = -1371509868;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              handle = this.handle;
              num1 = (int) num3 * -1182357386 ^ 1966515209;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return handle;
      }
      set
      {
        this.handle = value;
      }
    }

    public string Title
    {
      get
      {
label_1:
        int num1 = 1431947738;
        string title;
        while (true)
        {
          int num2 = 100911068;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              title = this.title;
              num1 = (int) num3 * -2121479796 ^ -556018405;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return title;
      }
      private set
      {
label_1:
        int num1 = 148391633;
        while (true)
        {
          int num2 = 108881374;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.title = value;
              num1 = (int) num3 * 1863496688 ^ 1442269005;
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

    public string ClassName
    {
      get
      {
        return this.className;
      }
      internal set
      {
label_1:
        int num1 = 845063915;
        while (true)
        {
          int num2 = 778143851;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.className = value;
              num1 = (int) num3 * 2142111930 ^ -680851928;
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

    public Size Size
    {
      get
      {
label_1:
        int num1 = 1411356182;
        Size size;
        while (true)
        {
          int num2 = 705100652;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1633926814 ^ -1566859958;
              continue;
            case 2:
              size = this.rectangle.Size;
              num1 = (int) num3 * -311367019 ^ 501291043;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return size;
      }
    }

    public System.Drawing.Point Location
    {
      get
      {
label_1:
        int num1 = 835462314;
        System.Drawing.Point location;
        while (true)
        {
          int num2 = 1313839165;
          uint num3;
          Rectangle rectangle;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1503360810 ^ -396149540;
              continue;
            case 2:
              rectangle = this.Rectangle;
              num1 = (int) num3 * -830519022 ^ -539665179;
              continue;
            case 3:
              location = rectangle.Location;
              num1 = (int) num3 * -28644882 ^ 1808482986;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return location;
      }
      set
      {
        this.rectangle.Location = value;
label_1:
        int num1 = 1702544322;
        while (true)
        {
          int num2 = 294475232;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 88793984 ^ 1293060784;
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

    public bool IsVisible
    {
      get
      {
        bool isVisible = this.isVisible;
label_1:
        int num1 = -629306175;
        while (true)
        {
          int num2 = -577573099;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1034396692 ^ -366370194;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return isVisible;
      }
      internal set
      {
label_1:
        int num1 = -860228404;
        while (true)
        {
          int num2 = -1337818539;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.isVisible = value;
              num1 = (int) num3 * -1814639826 ^ 357488043;
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

    public int ProcessId
    {
      get
      {
        bool flag = this.processId.Equals(0);
label_1:
        int num1 = -1480900552;
        int processId1;
        while (true)
        {
          int num2 = -538384067;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -854674295 ^ -1461695281;
              continue;
            case 1:
              num1 = (int) num3 * -73376182 ^ 811016403;
              continue;
            case 2:
              processId1 = this.processId;
              num1 = -1747135157;
              continue;
            case 3:
              goto label_1;
            case 4:
              uint processId2;
              int windowThreadProcessId = (int) NativeMethods.GetWindowThreadProcessId(this.Handle, out processId2);
              this.processId = Convert.ToInt32(processId2);
              num1 = (int) num3 * 732892032 ^ 592211261;
              continue;
            case 5:
              int num4 = !flag ? 828692204 : (num4 = 81614351);
              int num5 = (int) num3 * 169544967;
              num1 = num4 ^ num5;
              continue;
            case 6:
              num1 = (int) num3 * 9626708 ^ 762765642;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return processId1;
      }
    }

    public int ThreadId
    {
      get
      {
label_1:
        int num1 = -1075847458;
        int threadId;
        while (true)
        {
          int num2 = -1815878663;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1376494963 ^ 2134421538;
              continue;
            case 3:
              threadId = this.threadId;
              num1 = (int) num3 * 27522332 ^ 47344235;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return threadId;
      }
    }

    public WindowType WindowType
    {
      get
      {
label_1:
        int num1 = 421829004;
        WindowType windowType;
        while (true)
        {
          int num2 = 1866844910;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              windowType = this.windowType;
              num1 = (int) num3 * 398720155 ^ -900261385;
              continue;
            case 3:
              num1 = (int) num3 * 586433073 ^ -1036168216;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowType;
      }
    }

    public ZoomWindowType ZoomWindowType
    {
      get
      {
label_1:
        int num1 = -1249123977;
        ZoomWindowType zoomWindowType;
        while (true)
        {
          int num2 = -2128491350;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              zoomWindowType = this.zoomWindowType;
              num1 = (int) num3 * 1297633992 ^ 875649840;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomWindowType;
      }
    }

    public Rectangle DefaultRectangle
    {
      get
      {
label_1:
        int num1 = -1002016868;
        Rectangle defaultRectangle;
        while (true)
        {
          int num2 = -911502397;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1930774274 ^ 1942657055;
              continue;
            case 3:
              defaultRectangle = this.defaultRectangle;
              num1 = (int) num3 * -521707951 ^ 1948928133;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return defaultRectangle;
      }
      set
      {
label_1:
        int num1 = 1839543419;
        while (true)
        {
          int num2 = 39730384;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.defaultRectangle = value;
              num1 = (int) num3 * 861715393 ^ -934470607;
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

    public LayoutPattern Pattern
    {
      get
      {
        LayoutPattern pattern = this.pattern;
label_1:
        int num1 = -2113318769;
        while (true)
        {
          int num2 = -1706084791;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1718641547 ^ -64421428;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return pattern;
      }
      internal set
      {
label_1:
        int num1 = -268240165;
        while (true)
        {
          int num2 = -60650009;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1278313587 ^ 1193038725;
              continue;
            case 2:
              this.pattern = value;
              num1 = (int) num3 * 1221701604 ^ -1672803776;
              continue;
            case 3:
              int num4 = (uint) this.ZoomWindowType <= 0U ? -705315874 : (num4 = -452763147);
              int num5 = (int) num3 * -1363024496;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.WindowLayout = this.pattern.GetWindowLayout(this.ZoomWindowType, false);
              num1 = (int) num3 * -919709405 ^ 2119121430;
              continue;
            case 5:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public bool ApplyWindowLayout
    {
      get
      {
        bool applyWindowLayout = this.applyWindowLayout;
label_1:
        int num1 = -1336613765;
        while (true)
        {
          int num2 = -852418596;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1411975928 ^ -597067838;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return applyWindowLayout;
      }
      set
      {
label_1:
        int num1 = -1055515746;
        while (true)
        {
          int num2 = -864131584;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.applyWindowLayout = value;
              num1 = (int) num3 * 125671585 ^ -1760732537;
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

    public bool IsClosable
    {
      get
      {
        if (this.Engine.SharedData == null)
          goto label_10;
label_1:
        int num1 = -1838984914;
label_2:
        bool flag1;
        while (true)
        {
          int num2 = -1165519925;
          uint num3;
          bool flag2;
          bool flag3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              num1 = (int) num3 * 1006769777 ^ -117902174;
              continue;
            case 1:
              num1 = (int) num3 * -523225076 ^ 1487995268;
              continue;
            case 2:
              goto label_10;
            case 3:
              num1 = (int) num3 * 2051899869 ^ 247931637;
              continue;
            case 4:
              num1 = -821408906;
              continue;
            case 5:
              num4 = this.ZoomWindowType == ZoomWindowType.WaitingForHost ? 1 : 0;
              break;
            case 6:
              num1 = (int) num3 * 1967749942 ^ 1212025387;
              continue;
            case 7:
              flag1 = true;
              num1 = (int) num3 * 24529709 ^ 1000303195;
              continue;
            case 8:
              if (this.ZoomWindowType == ZoomWindowType.LeaveCurrent)
              {
                num4 = 1;
                break;
              }
              num1 = (int) num3 * 349092562 ^ 1439327316;
              continue;
            case 9:
              int num5 = flag2 ? 1970720517 : (num5 = 16498011);
              int num6 = (int) num3 * 490138862;
              num1 = num5 ^ num6;
              continue;
            case 10:
              flag1 = this.DefaultVisibility == WindowVisibility.Close;
              num1 = (int) num3 * 1768899994 ^ -1366851803;
              continue;
            case 12:
              num1 = -2100809173;
              continue;
            case 13:
              flag2 = this.Engine.ActiveMeeting == null;
              num1 = (int) num3 * -1868014314 ^ -1999658152;
              continue;
            case 14:
              goto label_1;
            case 15:
              flag1 = this.DefaultVisibility == WindowVisibility.Close;
              num1 = (int) num3 * -1722788836 ^ -2005435477;
              continue;
            case 16:
              num1 = (int) num3 * -1940076683 ^ 946012624;
              continue;
            case 17:
              int num7 = flag3 ? 2010601239 : (num7 = 1712127444);
              int num8 = (int) num3 * 1485803883;
              num1 = num7 ^ num8;
              continue;
            default:
              goto label_22;
          }
          flag3 = num4 != 0;
          num1 = -1531092000;
        }
label_22:
        return flag1;
label_10:
        flag1 = this.DefaultVisibility == WindowVisibility.Close;
        num1 = -735948634;
        goto label_2;
      }
    }

    public bool IsMinimizable
    {
      get
      {
        bool flag;
        int num1;
        switch (this.ZoomWindowType)
        {
          case ZoomWindowType.Undefined:
          case ZoomWindowType.ZoomZoomMain:
          case ZoomWindowType.AccountPanel:
          case ZoomWindowType.Join:
          case ZoomWindowType.Notification:
          case ZoomWindowType.InvalidMeeting:
          case ZoomWindowType.ManyCamBroadcast:
          case ZoomWindowType.JoinAudio:
          case ZoomWindowType.Invite:
          case ZoomWindowType.ScreenSharingDisabled:
          case ZoomWindowType.WaitingForHost:
          case ZoomWindowType.LeaveCurrent:
          case ZoomWindowType.RequestRecord:
          case ZoomWindowType.AudioNotification:
          case ZoomWindowType.Sharing:
          case ZoomWindowType.Locked:
          case ZoomWindowType.Full:
          case ZoomWindowType.EndMeeting:
          case ZoomWindowType.ScreenShareOptions:
          case ZoomWindowType.RequestRemoteControl:
          case ZoomWindowType.ManyCamApp:
          case ZoomWindowType.Password:
          case ZoomWindowType.ImageHistoryView:
          case ZoomWindowType.Rename:
          case ZoomWindowType.RemoveUserConfirmation:
label_4:
            flag = true;
            num1 = -1578382666;
            break;
          case ZoomWindowType.Meeting:
          case ZoomWindowType.Chat:
          case ZoomWindowType.Participants:
          case ZoomWindowType.DualVideo:
          case ZoomWindowType.Video:
          case ZoomWindowType.Container:
          case ZoomWindowType.Other:
          case ZoomWindowType.Settings:
          case ZoomWindowType.AudioError:
          case ZoomWindowType.AudioMenu:
          case ZoomWindowType.MeetingButtonBar:
          case ZoomWindowType.GalleryScrollRight:
          case ZoomWindowType.GalleryScrollLeft:
          case ZoomWindowType.ToolTip:
          case ZoomWindowType.GalleryView:
          case ZoomWindowType.SpeakerViewScrollLeft:
          case ZoomWindowType.SpeakerViewScrollRight:
          case ZoomWindowType.SpeakerView:
          case ZoomWindowType.MeetingViewToggle:
          case ZoomWindowType.ZoomMenu:
label_6:
            flag = false;
            num1 = -1637650075;
            break;
          default:
label_1:
            num1 = -176013537;
            break;
        }
        while (true)
        {
          int num2 = -1726074742;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1364983181 ^ 1492142357;
              continue;
            case 1:
            case 4:
              goto label_6;
            case 2:
              goto label_4;
            case 5:
              goto label_1;
            case 6:
              num1 = (int) num3 * 1341588166 ^ -1048309039;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return flag;
      }
    }

    public Rectangle Rectangle
    {
      get
      {
        return this.rectangle;
      }
      set
      {
label_1:
        int num1 = -1175795413;
        while (true)
        {
          int num2 = -2021708406;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1817837160 ^ 818245435;
              continue;
            case 2:
              this.rectangle = value;
              num1 = -1768831552;
              continue;
            case 3:
              num1 = (int) num3 * 1875809486 ^ -656036443;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4069984654U));
              num1 = (int) num3 * 809673915 ^ 2042764553;
              continue;
            case 5:
              int num4 = !(this.rectangle == value) ? 972902874 : (num4 = 301826563);
              int num5 = (int) num3 * 1247013958;
              num1 = num4 ^ num5;
              continue;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public string Styles
    {
      get
      {
label_1:
        int num1 = -1412864222;
        string styles;
        while (true)
        {
          int num2 = -1348215164;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1362343370 ^ 1684976425;
              continue;
            case 2:
              styles = this.styles;
              num1 = (int) num3 * 755325577 ^ 1859640535;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return styles;
      }
      private set
      {
        this.styles = value;
      }
    }

    public WindowVisibility DefaultVisibility
    {
      get
      {
label_1:
        int num1 = -1897459761;
        WindowVisibility defaultVisibility;
        while (true)
        {
          int num2 = -930125371;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              defaultVisibility = this.defaultVisibility;
              num1 = (int) num3 * 434335176 ^ 134881562;
              continue;
            case 3:
              num1 = (int) num3 * -952488406 ^ 2056911330;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return defaultVisibility;
      }
      set
      {
label_1:
        int num1 = -456222903;
        while (true)
        {
          int num2 = -1584657659;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.defaultVisibility = value;
              num1 = (int) num3 * -2003938751 ^ 1829659821;
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

    public string ExtendedStyles
    {
      get
      {
        return this.extendedStyles;
      }
      set
      {
label_1:
        int num1 = -1402183202;
        while (true)
        {
          int num2 = -410460577;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.extendedStyles = value;
              num1 = (int) num3 * 1976376565 ^ 1419746132;
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

    public IntPtr Parent
    {
      get
      {
        IntPtr parent = this.parent;
label_1:
        int num1 = -2094996283;
        while (true)
        {
          int num2 = -602473342;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 491848193 ^ 525800321;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return parent;
      }
      set
      {
        this.parent = value;
      }
    }

    public IntPtr Owner
    {
      get
      {
label_1:
        int num1 = -694916405;
        IntPtr owner;
        while (true)
        {
          int num2 = -1889525896;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 432528551 ^ 956536369;
              continue;
            case 2:
              goto label_1;
            case 3:
              owner = this.owner;
              num1 = (int) num3 * -272427503 ^ 2121688955;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return owner;
      }
      set
      {
label_1:
        int num1 = 1647082484;
        while (true)
        {
          int num2 = 22119364;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.owner = value;
              num1 = (int) num3 * 1894065915 ^ 164197084;
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

    public IntPtr Child
    {
      get
      {
        IntPtr child = this.child;
label_1:
        int num1 = -872890157;
        while (true)
        {
          int num2 = -1953472886;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -2113186830 ^ 839491621;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return child;
      }
      set
      {
label_1:
        int num1 = -1122327340;
        while (true)
        {
          int num2 = -1225084106;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.child = value;
              num1 = (int) num3 * 1446405642 ^ 1536706748;
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

    public IntPtr Previous
    {
      get
      {
label_1:
        int num1 = -1765535100;
        IntPtr previous;
        while (true)
        {
          int num2 = -765250623;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              previous = this.previous;
              num1 = (int) num3 * 2098478657 ^ -1769694560;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return previous;
      }
      set
      {
label_1:
        int num1 = 676996352;
        while (true)
        {
          int num2 = 628645827;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.previous = value;
              num1 = (int) num3 * 733236495 ^ 1178704775;
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

    public IntPtr Next
    {
      get
      {
        IntPtr next = this.next;
label_1:
        int num1 = -580120662;
        while (true)
        {
          int num2 = -353567342;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 51069732 ^ 1245189032;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return next;
      }
      set
      {
        this.next = value;
      }
    }

    public string ItemType
    {
      get
      {
label_1:
        int num1 = -1961782387;
        string itemType;
        while (true)
        {
          int num2 = -146149178;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1508626496 ^ -422486729;
              continue;
            case 3:
              itemType = this.itemType;
              num1 = (int) num3 * 1119314198 ^ -1717476042;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return itemType;
      }
      set
      {
        this.itemType = value;
      }
    }

    public string[] ItemStrings
    {
      get
      {
        return this.itemStrings;
      }
      set
      {
label_1:
        int num1 = -832036866;
        while (true)
        {
          int num2 = -1650318757;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.itemStrings = value;
              num1 = (int) num3 * -1628414131 ^ 63764324;
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

    public string[] ItemStyles
    {
      get
      {
        return this.itemStyles;
      }
      set
      {
        this.itemStyles = value;
      }
    }

    public IntPtr ItemHandle
    {
      get
      {
        IntPtr itemHandle = this.itemHandle;
label_1:
        int num1 = -814301752;
        while (true)
        {
          int num2 = -461053775;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -2075393507 ^ -145954642;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return itemHandle;
      }
      set
      {
        this.itemHandle = value;
      }
    }

    public bool RequiresMovement
    {
      get
      {
label_1:
        int num1 = -1302312602;
        bool flag;
        while (true)
        {
          int num2 = -1329546988;
          uint num3;
          Rectangle rectangle;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 22U)
          {
            case 0:
              num1 = (int) num3 * 984355860 ^ 1244724705;
              continue;
            case 1:
            case 5:
              flag = false;
              num1 = -1091467802;
              continue;
            case 2:
              num1 = (int) num3 * -245210068 ^ 1544549527;
              continue;
            case 3:
              num1 = (int) num3 * -73894668 ^ -631835779;
              continue;
            case 4:
label_4:
              this.Rectangle = WindowHelper.GetWindowRectangle(this.Handle);
              num1 = -516561025;
              continue;
            case 6:
              num1 = (int) num3 * 1909765089 ^ 1288798081;
              continue;
            case 7:
              if (this.IsVisible)
              {
                num1 = (int) num3 * 742851058 ^ -537226640;
                continue;
              }
              num4 = 0;
              break;
            case 8:
              rectangle = this.Rectangle;
              num4 = !rectangle.Equals((object) this.DefaultRectangle) ? 1 : 0;
              break;
            case 10:
              flag = false;
              num1 = (int) num3 * -1753295986 ^ -68421975;
              continue;
            case 11:
label_3:
              flag = this.IsVisible;
              num1 = -1587950456;
              continue;
            case 12:
label_9:
              flag = false;
              num1 = -1670032541;
              continue;
            case 13:
              flag = this.IsVisible;
              num1 = (int) num3 * 819476189 ^ -948502947;
              continue;
            case 14:
              flag = !rectangle.Equals((object) this.DefaultRectangle);
              num1 = (int) num3 * 2035719040 ^ 415102739;
              continue;
            case 15:
              goto label_1;
            case 16:
label_16:
              int num5;
              num1 = num5 = !WindowHelper.IsValid(this.Handle) ? -386429807 : (num5 = -1587125639);
              continue;
            case 17:
              num1 = -710785680;
              continue;
            case 18:
              switch (this.DefaultVisibility)
              {
                case WindowVisibility.Ignore:
                  goto label_9;
                case WindowVisibility.Show:
                  goto label_4;
                case WindowVisibility.Move:
                  goto label_18;
                case WindowVisibility.Hide:
                  goto label_3;
                case WindowVisibility.Close:
                  goto label_16;
                default:
                  num1 = (int) num3 * 2129317595 ^ 1572872402;
                  continue;
              }
            case 19:
              num1 = (int) num3 * -2090521650 ^ 494548243;
              continue;
            case 20:
              num1 = (int) num3 * 1776323870 ^ -1378094195;
              continue;
            case 21:
label_18:
              rectangle = this.Rectangle;
              num1 = -645142926;
              continue;
            default:
              goto label_26;
          }
          flag = num4 != 0;
          num1 = -204628527;
        }
label_26:
        return flag;
      }
    }

    public WindowLayout WindowLayout
    {
      get
      {
label_1:
        int num1 = 2101329285;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = 160064048;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              windowLayout = this.windowLayout;
              num1 = (int) num3 * -280591908 ^ 1385259470;
              continue;
            case 2:
              num1 = (int) num3 * 1864356841 ^ -588432795;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowLayout;
      }
      private set
      {
        this.windowLayout = value;
label_1:
        int num1 = -310624129;
        while (true)
        {
          int num2 = -1283345854;
          uint num3;
          bool flag;
          bool zoomDockingEnabled;
          switch ((num3 = (uint) (num1 ^ num2)) % 26U)
          {
            case 0:
              this.defaultVisibility = this.windowLayout.WindowVisibility;
              num1 = (int) num3 * 1128216423 ^ -665133377;
              continue;
            case 1:
              zoomDockingEnabled = this.Engine.Settings.ZoomZoomDockingEnabled;
              num1 = (int) num3 * -239125894 ^ -2090033950;
              continue;
            case 2:
              this.ApplyWindowLayout = this.Pattern.DockEngineView;
              num1 = (int) num3 * 1377976972 ^ 619393377;
              continue;
            case 3:
              int num4 = flag ? 72550160 : (num4 = 1258150336);
              int num5 = (int) num3 * 1616857441;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * -258598598 ^ -1241201114;
              continue;
            case 5:
              num1 = (int) num3 * 2131355490 ^ -2110584282;
              continue;
            case 6:
              this.defaultVisibility = WindowVisibility.Show;
              num1 = (int) num3 * 1194465480 ^ -1087269109;
              continue;
            case 7:
              num1 = (int) num3 * 497921539 ^ 2040459669;
              continue;
            case 8:
              num1 = (int) num3 * 105693259 ^ -1608883975;
              continue;
            case 9:
              this.defaultRectangle = this.Rectangle;
              num1 = -897028646;
              continue;
            case 10:
              num1 = (int) num3 * -73753813 ^ 1348683315;
              continue;
            case 11:
              flag = this.windowLayout != null;
              num1 = (int) num3 * -470219311 ^ -2010277536;
              continue;
            case 12:
              this.defaultRectangle = this.windowLayout.Rectangle;
              num1 = (int) num3 * -1775384343 ^ 512009332;
              continue;
            case 13:
              int num6;
              num1 = num6 = this.ZoomWindowType == ZoomWindowType.ZoomZoomMain ? -1233796092 : (num6 = -1248521211);
              continue;
            case 14:
              this.defaultRectangle = Rectangle.Empty;
              this.defaultVisibility = WindowVisibility.Ignore;
              num1 = (int) num3 * 970007678 ^ -1101506662;
              continue;
            case 15:
              this.ApplyWindowLayout = false;
              num1 = -1727727499;
              continue;
            case 16:
              num1 = (int) num3 * -1536100245 ^ 1411048535;
              continue;
            case 17:
              this.ApplyWindowLayout = true;
              this.windowLayout.CalculateRectangle();
              num1 = (int) num3 * 2128206638 ^ 511984924;
              continue;
            case 18:
              num1 = (int) num3 * 2067503610 ^ 1056824658;
              continue;
            case 19:
              int num7;
              num1 = num7 = (uint) this.ZoomWindowType > 0U ? -1939390214 : (num7 = -277329498);
              continue;
            case 20:
              int num8 = zoomDockingEnabled ? -1935007776 : (num8 = -2004548921);
              int num9 = (int) num3 * 304509964;
              num1 = num8 ^ num9;
              continue;
            case 21:
              num1 = (int) num3 * -1747365705 ^ 1195107887;
              continue;
            case 22:
              num1 = (int) num3 * -2135880827 ^ -2062667484;
              continue;
            case 23:
              goto label_1;
            case 24:
              goto label_3;
            case 25:
              this.ApplyWindowLayout = false;
              num1 = (int) num3 * 211721930 ^ 546050632;
              continue;
            default:
              goto label_28;
          }
        }
label_28:
        return;
label_3:;
      }
    }

    public bool Highlighted
    {
      get
      {
label_1:
        int num1 = 1005171918;
        bool highlighted;
        while (true)
        {
          int num2 = 967883961;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1423742920 ^ -858890956;
              continue;
            case 2:
              goto label_1;
            case 3:
              highlighted = this.highlighted;
              num1 = (int) num3 * 1246569611 ^ -2073316604;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return highlighted;
      }
      set
      {
        object windowLocker = ZoomWindow.windowLocker;
        bool flag = false;
        try
        {
          ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
          this.highlighted = value;
        }
        finally
        {
          if (flag)
          {
label_3:
            int num1 = 767827885;
            while (true)
            {
              int num2 = 80644911;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_3;
                case 2:
                  ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                  num1 = (int) num3 * -1094174606 ^ 780133701;
                  continue;
                default:
                  goto label_6;
              }
            }
          }
label_6:;
        }
      }
    }

    public bool DrawHighlightSupported
    {
      get
      {
        bool flag1 = !this.IsVisible;
label_1:
        int num1 = 1130863448;
        bool flag2;
        while (true)
        {
          int num2 = 1785457745;
          uint num3;
          ZoomWindowType zoomWindowType;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              switch (zoomWindowType)
              {
                case ZoomWindowType.Undefined:
                case ZoomWindowType.AccountPanel:
                case ZoomWindowType.Join:
                case ZoomWindowType.Meeting:
                case ZoomWindowType.Participants:
                case ZoomWindowType.DualVideo:
                case ZoomWindowType.Video:
                case ZoomWindowType.ScreenSharingDisabled:
                case ZoomWindowType.WaitingForHost:
                  goto label_4;
                case ZoomWindowType.ZoomZoomMain:
                case ZoomWindowType.Chat:
                case ZoomWindowType.Notification:
                case ZoomWindowType.Container:
                case ZoomWindowType.Other:
                case ZoomWindowType.InvalidMeeting:
                case ZoomWindowType.ManyCamBroadcast:
                case ZoomWindowType.JoinAudio:
                case ZoomWindowType.Settings:
                case ZoomWindowType.Invite:
                case ZoomWindowType.LeaveCurrent:
                case ZoomWindowType.RequestRecord:
                case ZoomWindowType.AudioNotification:
                case ZoomWindowType.AudioError:
                case ZoomWindowType.AudioMenu:
                case ZoomWindowType.Sharing:
                case ZoomWindowType.Locked:
                case ZoomWindowType.Full:
                case ZoomWindowType.EndMeeting:
                case ZoomWindowType.MeetingButtonBar:
                case ZoomWindowType.GalleryScrollRight:
                case ZoomWindowType.GalleryScrollLeft:
                case ZoomWindowType.ToolTip:
                case ZoomWindowType.ScreenShareOptions:
                case ZoomWindowType.RequestRemoteControl:
                case ZoomWindowType.GalleryView:
                case ZoomWindowType.SpeakerViewScrollLeft:
                case ZoomWindowType.SpeakerViewScrollRight:
                case ZoomWindowType.SpeakerView:
                case ZoomWindowType.MeetingViewToggle:
                  goto label_5;
                default:
                  num1 = (int) num3 * 1648981385 ^ -1072069026;
                  continue;
              }
            case 1:
              int num4 = flag1 ? -154668482 : (num4 = -1410950097);
              int num5 = (int) num3 * -35247574;
              num1 = num4 ^ num5;
              continue;
            case 2:
            case 3:
label_5:
              flag2 = false;
              num1 = 188526445;
              continue;
            case 4:
label_4:
              flag2 = true;
              num1 = 188526445;
              continue;
            case 5:
              goto label_1;
            case 7:
              num1 = (int) num3 * 1468538457 ^ -944559903;
              continue;
            case 8:
              zoomWindowType = this.ZoomWindowType;
              num1 = 1135658593;
              continue;
            case 9:
              flag2 = false;
              num1 = (int) num3 * 1063348216 ^ -45080523;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return flag2;
      }
    }

    public bool ForceRefreshOtherWindows
    {
      get
      {
label_1:
        int num1 = -19388421;
        bool flag1;
        while (true)
        {
          int num2 = -1738664898;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -1756413507 ^ -1930510434;
              continue;
            case 1:
              flag2 = this.windowLayout != null;
              num1 = (int) num3 * -1673215923 ^ -1982664644;
              continue;
            case 2:
              goto label_1;
            case 3:
              flag1 = false;
              num1 = -406421206;
              continue;
            case 5:
              int num4 = !flag2 ? -1566518907 : (num4 = -130169817);
              int num5 = (int) num3 * -1565145134;
              num1 = num4 ^ num5;
              continue;
            case 6:
              flag1 = this.windowLayout.HasStretched;
              num1 = (int) num3 * 992142683 ^ -1214249941;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return flag1;
      }
    }

    public static List<ZoomWindowType> ButtonPossibleResultingZoomWindowTypes
    {
      get
      {
        List<ZoomWindowType> zoomWindowTypeList = new List<ZoomWindowType>()
        {
          ZoomWindowType.AudioMenu,
          ZoomWindowType.JoinAudio,
          ZoomWindowType.Invite,
          ZoomWindowType.Participants,
          ZoomWindowType.Sharing,
          ZoomWindowType.Chat,
          ZoomWindowType.RequestRecord
        };
label_1:
        int num1 = 1592625639;
        while (true)
        {
          int num2 = 624382800;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -589320224 ^ -1282272025;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomWindowTypeList;
      }
    }

    public static List<ZoomEvent> WindowEvents
    {
      get
      {
label_1:
        int num1 = -769477127;
        List<ZoomEvent> windowEvents;
        while (true)
        {
          int num2 = -1567514528;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              windowEvents = ZoomWindow.windowEvents;
              num1 = (int) num3 * 634117360 ^ 299511623;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -80316774 ^ 1423522810;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowEvents;
      }
      set
      {
        ZoomWindow.windowEvents = value;
      }
    }

    static ZoomWindow()
    {
label_1:
      int num1 = 1428854406;
      while (true)
      {
        int num2 = 803214622;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            ZoomWindow.windowLocker = ZoomWindow.\u202A⁭​⁮‫‪⁭⁬‌⁮⁯⁪⁭‌‍‪‌‌⁯‭⁭⁮⁭‭⁭‏‫‮⁮⁮‫‪‭​‎⁭⁯​⁭‪‮();
            ZoomWindow.windowEvents = new List<ZoomEvent>();
            num1 = (int) num3 * 1065877599 ^ -1704241024;
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

    private ZoomWindow(IntPtr handle)
    {
label_1:
      int num1 = -1276433218;
      while (true)
      {
        int num2 = -905162302;
        uint num3;
        uint processId;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            this.previous = User32.GetWindow(handle, GW.HWNDPREV);
            this.next = User32.GetWindow(handle, GW.HWNDNEXT);
            num1 = (int) num3 * -904758760 ^ 462202327;
            continue;
          case 2:
            this.className = WindowHelper.GetWindowClass(handle);
            int windowThreadProcessId = (int) NativeMethods.GetWindowThreadProcessId(handle, out processId);
            num1 = (int) num3 * -2777363 ^ 1569232933;
            continue;
          case 3:
            this.processId = ZoomWindow.\u202A‍‫⁪‎‍‍‏‏‌⁮‬⁭​⁮⁫‎‏‏‮⁭⁯‫‏‏​⁪‭‪‬‮‍‍⁭‮⁯‏‎‫‪‮(processId);
            num1 = (int) num3 * 2093463447 ^ -857045974;
            continue;
          case 4:
            goto label_3;
          case 5:
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.OnPatternChange), (ThreadOption) 2, false, (Predicate<ObjectChangedEventPayload>) (x =>
            {
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (ZoomWindow.\u003C\u003Ec.\u206D‎​‍⁮⁯⁪‎‭⁭‍‍‮⁪⁬‫‫‫⁭‌‌‮⁮‎⁭‍⁭‎‌⁬⁮‬⁯⁫‏‫‮‏‎⁪‮(x.ObjectType, ZoomWindow.\u003C\u003Ec.\u202D‪‍‭⁮‬‎⁯‏‍‌‏‮⁫⁮⁮‮⁬‌‫⁯‍​⁪⁭‬⁪‍‪⁪‏‬‏‫‌‪‍‫‫⁫‮(__typeref (LayoutPattern))))
                return x.ChangeType == ChangeType.Activated;
              return false;
            }));
            num1 = -1005011450;
            continue;
          case 6:
            num1 = (int) num3 * -868814995 ^ -1860142567;
            continue;
          case 7:
            processId = 0U;
            this.title = WindowHelper.GetWindowTitle(handle);
            num1 = (int) num3 * 1046923431 ^ -19619375;
            continue;
          case 8:
            this.handle = handle;
            this.parent = User32.GetParent(handle);
            this.owner = User32.GetAncestor(handle, 3U);
            this.child = User32.GetWindow(handle, GW.CHILD);
            num1 = (int) num3 * 1425022750 ^ -204073687;
            continue;
          case 9:
            this._eventAggregator = ApplicationService.Instance.EventAggregator;
            num1 = (int) num3 * 1951702955 ^ -1425602241;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    private void OnPatternChange(ObjectChangedEventPayload obj)
    {
      try
      {
label_2:
        int num1 = -722669660;
        object windowLocker;
        while (true)
        {
          int num2 = -23028376;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              windowLocker = ZoomWindow.windowLocker;
              num1 = (int) num3 * 2133259325 ^ -807373919;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        bool flag = false;
        try
        {
          ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_7:
          int num2 = -422181883;
          while (true)
          {
            int num3 = -23028376;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_25;
              case 1:
                num2 = (int) num4 * 657536194 ^ 1532672137;
                continue;
              case 2:
                goto label_7;
              case 3:
                this.Pattern = (LayoutPattern) obj.ChangedObject;
                num2 = (int) num4 * -598361983 ^ 869994931;
                continue;
              default:
                goto label_22;
            }
          }
label_22:
          return;
label_25:;
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = -2090311418;
            while (true)
            {
              int num3 = -23028376;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_12;
                case 1:
                  num2 = (int) num4 * 1861599675 ^ 2136232604;
                  continue;
                case 2:
                  ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                  num2 = (int) num4 * -320719804 ^ -749131435;
                  continue;
                default:
                  goto label_17;
              }
            }
          }
label_17:;
        }
      }
      catch (Exception ex)
      {
label_20:
        int num1 = -17676961;
        while (true)
        {
          int num2 = -23028376;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_20;
            case 1:
              num1 = (int) num3 * 1305184534 ^ -942778308;
              continue;
            case 2:
              goto label_18;
            case 3:
              ZoomWindow.\u200F‌‏⁬⁮⁭⁭‮⁪⁪​‬⁯‌⁪‭⁯‎‪‭‮⁫⁫‬‎‍‮‮‍‭‪⁮​⁮⁫⁫‌⁭‍‪‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1276112939 ^ -1794548070;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_18:;
      }
    }

    public static ZoomWindow New(IntPtr handle)
    {
      ZoomWindow zoomWindow1 = (ZoomWindow) null;
      ZoomWindow zoomWindow2;
      try
      {
label_2:
        int num1 = -618144193;
        while (true)
        {
          int num2 = -2067003247;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_2;
            case 1:
              zoomWindow1.Refresh(true, false);
              num1 = (int) num3 * -1105777519 ^ 1227077819;
              continue;
            case 2:
              goto label_19;
            case 4:
              zoomWindow2 = (ZoomWindow) null;
              num1 = (int) num3 * -1315723836 ^ -1249685021;
              continue;
            case 5:
              zoomWindow1 = new ZoomWindow(handle);
              num1 = -1391806848;
              continue;
            case 6:
              flag = handle == IntPtr.Zero;
              num1 = (int) num3 * 1611102589 ^ -1595396464;
              continue;
            case 7:
              int num4 = !flag ? 458209435 : (num4 = 1946157378);
              int num5 = (int) num3 * -2141019599;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_15;
          }
        }
      }
      catch (Exception ex)
      {
label_10:
        int num1 = -2146207287;
        while (true)
        {
          int num2 = -2067003247;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_10;
            case 1:
              ZoomWindow.\u200F‌‏⁬⁮⁭⁭‮⁪⁪​‬⁯‌⁪‭⁯‎‪‭‮⁫⁫‬‎‍‮‮‍‭‪⁮​⁮⁫⁫‌⁭‍‪‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1275853031 ^ -1126208250;
              continue;
            case 2:
              num1 = (int) num3 * -1419695432 ^ -1456996260;
              continue;
            case 3:
              num1 = (int) num3 * -187023341 ^ 770645001;
              continue;
            default:
              goto label_15;
          }
        }
      }
label_15:
      zoomWindow2 = zoomWindow1;
label_16:
      int num6 = -523272576;
      while (true)
      {
        int num1 = -2067003247;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 0:
            goto label_16;
          case 1:
            num6 = (int) num2 * -405180648 ^ -859355321;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return zoomWindow2;
    }

    internal void Hide()
    {
      NativeMethods.ShowWindow(this.Handle, WindowShowStyle.Hide);
    }

    public void SetWindowTypes(WindowType windowType, ZoomWindowType zoomWindowType)
    {
      object windowLocker = ZoomWindow.windowLocker;
      bool flag = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_2:
        int num1 = 197365677;
        while (true)
        {
          int num2 = 562841222;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -2036330879 ^ 193628784;
              continue;
            case 1:
              this.zoomWindowType = zoomWindowType;
              num1 = (int) num3 * 1436674966 ^ 1690488940;
              continue;
            case 2:
              this.windowType = windowType;
              num1 = (int) num3 * -1842652916 ^ 1472006079;
              continue;
            case 3:
              num1 = (int) num3 * -1296458227 ^ -158376589;
              continue;
            case 4:
              this.Pattern = this.Engine.ActivePattern;
              num1 = (int) num3 * 1568094946 ^ 132417129;
              continue;
            case 5:
              goto label_2;
            case 6:
              goto label_14;
            case 7:
              num1 = (int) num3 * 1397303595 ^ 1996532147;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:;
      }
      finally
      {
        if (flag)
        {
label_12:
          int num1 = 687708575;
          while (true)
          {
            int num2 = 562841222;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_12;
              case 1:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                num1 = (int) num3 * 829027688 ^ 672656541;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    public override string ToString()
    {
      return string.Format(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2994603009U), (object) this.windowType, (object) this.zoomWindowType, (object) (this.isVisible ? \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3892006726U) : \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1019231467U)), (object) this.Rectangle.X, (object) this.Rectangle.Y, (object) this.Rectangle.Size, (object) this.Rectangle.Height, (object) this.Handle);
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = -1449031682;
      bool flag1;
      while (true)
      {
        int num2 = -556537949;
        uint num3;
        IntPtr handle;
        ZoomWindow zoomWindow;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            if (handle.Equals((object) IntPtr.Zero))
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1394410432 ^ 900786821;
            continue;
          case 1:
            num4 = handle.Equals((object) zoomWindow.Handle) ? 1 : 0;
            break;
          case 3:
            int num5 = flag2 ? -80282847 : (num5 = -1003467897);
            int num6 = (int) num3 * 1678004166;
            num1 = num5 ^ num6;
            continue;
          case 4:
            flag1 = false;
            num1 = (int) num3 * 701306785 ^ -1970744905;
            continue;
          case 5:
            num1 = (int) num3 * -1543276813 ^ -1545037364;
            continue;
          case 6:
            handle = this.Handle;
            num1 = -1913663845;
            continue;
          case 7:
            zoomWindow = obj as ZoomWindow;
            flag2 = (ZoomWindow) obj == null;
            num1 = (int) num3 * -109483544 ^ -682100302;
            continue;
          case 8:
            handle = this.Handle;
            num1 = (int) num3 * 1768015734 ^ 1106196672;
            continue;
          case 9:
            goto label_1;
          default:
            goto label_14;
        }
        flag1 = num4 != 0;
        num1 = -140605706;
      }
label_14:
      return flag1;
    }

    public override int GetHashCode()
    {
label_1:
      int num1 = 459677786;
      int hashCode;
      while (true)
      {
        int num2 = 1575872896;
        uint num3;
        IntPtr handle;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            hashCode = handle.GetHashCode();
            num1 = (int) num3 * 2072807408 ^ -732163927;
            continue;
          case 1:
            num1 = (int) num3 * -1411516458 ^ 1452847112;
            continue;
          case 3:
            handle = this.Handle;
            num1 = (int) num3 * -644673177 ^ 1217700164;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return hashCode;
    }

    internal void RefreshLocationFromEvent(ZoomEvent zoomEvent)
    {
label_1:
      int num1 = 445017353;
      Rectangle windowRectangle;
      bool flag1;
      bool flag2;
      while (true)
      {
        int num2 = 1256912442;
        uint num3;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 1:
            windowRectangle = WindowHelper.GetWindowRectangle(this.handle);
            num1 = (int) num3 * 51707092 ^ 951370055;
            continue;
          case 2:
            if (flag3)
            {
              num1 = (int) num3 * 249379380 ^ 600970255;
              continue;
            }
            goto label_26;
          case 3:
            num4 = flag1 != this.IsVisible ? 1 : 0;
            break;
          case 4:
            goto label_1;
          case 5:
            flag1 = WindowHelper.IsWindowVisible(this.handle);
            flag2 = false;
            num1 = (int) num3 * 1288930022 ^ 590917506;
            continue;
          case 6:
            if (!(windowRectangle != this.Rectangle))
            {
              num1 = (int) num3 * -636158464 ^ -109927709;
              continue;
            }
            num4 = 1;
            break;
          default:
            goto label_12;
        }
        flag3 = num4 != 0;
        num1 = 426542517;
      }
label_12:
      object windowLocker = ZoomWindow.windowLocker;
      bool flag4 = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag4);
label_14:
        int num2 = 341322856;
        while (true)
        {
          int num3 = 1256912442;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_14;
            case 1:
              this.isVisible = flag1;
              flag2 = true;
              num2 = (int) num4 * -94998908 ^ 1252286046;
              continue;
            case 2:
              num2 = (int) num4 * -1779380943 ^ -28612380;
              continue;
            case 4:
              this.Rectangle = windowRectangle;
              num2 = (int) num4 * 571110046 ^ -2135093205;
              continue;
            default:
              goto label_26;
          }
        }
      }
      finally
      {
        if (flag4)
        {
label_20:
          int num2 = 1516512759;
          while (true)
          {
            int num3 = 1256912442;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                num2 = (int) num4 * 1789533886 ^ -1379240858;
                continue;
              case 2:
                num2 = (int) num4 * -138192169 ^ -1441641384;
                continue;
              case 3:
                goto label_20;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:
      if (!this.ApplyWindowLayout)
        goto label_44;
label_27:
      int num5 = 937730875;
label_28:
      bool flag5;
      while (true)
      {
        int num2 = 1256912442;
        uint num3;
        bool flag3;
        ZoomWindow window;
        bool flag6;
        int num4;
        switch ((num3 = (uint) (num5 ^ num2)) % 18U)
        {
          case 0:
            int num6 = flag3 ? 144030569 : (num6 = 539237901);
            int num7 = (int) num3 * -731412274;
            num5 = num6 ^ num7;
            continue;
          case 1:
            num5 = 1221603505;
            continue;
          case 2:
            int num8 = flag6 ? -994827991 : (num8 = -739696173);
            int num9 = (int) num3 * -1834088530;
            num5 = num8 ^ num9;
            continue;
          case 3:
            num5 = (int) num3 * -854047470 ^ 1450271253;
            continue;
          case 4:
            int num10 = !flag5 ? -576578683 : (num10 = -1449509808);
            int num11 = (int) num3 * -343385784;
            num5 = num10 ^ num11;
            continue;
          case 5:
            window.RefreshLocationFromEvent(zoomEvent);
            num5 = (int) num3 * 233925434 ^ 1154303577;
            continue;
          case 6:
            this.ApplyLayoutPattern((object) null);
            num5 = (int) num3 * 1309959166 ^ 300749668;
            continue;
          case 7:
            goto label_29;
          case 8:
            if (this.ZoomWindowType != ZoomWindowType.AccountPanel)
            {
              num5 = (int) num3 * -13872820 ^ -25568765;
              continue;
            }
            break;
          case 9:
            if (this.ZoomWindowType != ZoomWindowType.Meeting)
            {
              num5 = 1945817694;
              continue;
            }
            break;
          case 10:
            flag6 = window != null;
            num5 = (int) num3 * -1165665248 ^ 448745424;
            continue;
          case 11:
            if (this.ZoomWindowType != ZoomWindowType.Join)
            {
              num5 = (int) num3 * 543912429 ^ -1234847999;
              continue;
            }
            break;
          case 12:
            num5 = (int) num3 * -903537848 ^ 7786325;
            continue;
          case 13:
            goto label_27;
          case 14:
            num5 = (int) num3 * 541877018 ^ 437145600;
            continue;
          case 15:
            goto label_43;
          case 16:
            num4 = this.ZoomWindowType == ZoomWindowType.ManyCamApp ? 1 : 0;
            goto label_32;
          case 17:
            window = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
            num5 = (int) num3 * 2032655396 ^ 2085804536;
            continue;
          default:
            goto label_22;
        }
        num4 = 1;
label_32:
        flag3 = num4 != 0;
        num5 = 1460114632;
      }
label_22:
      return;
label_29:
      return;
label_43:
      int num12 = (uint) this.DefaultVisibility > 0U ? 1 : 0;
      goto label_45;
label_44:
      num12 = 0;
label_45:
      flag5 = num12 != 0;
      num5 = 262366666;
      goto label_28;
    }

    public void RefreshLocation()
    {
    }

    public bool Refresh(bool extendedRefresh = false, bool locationOnly = false)
    {
      this.RefreshLocation();
label_1:
      int num1 = 1855652160;
      bool flag1;
      bool flag2;
      string windowTitle;
      string windowClass;
      object windowLocker;
      while (true)
      {
        int num2 = 2132290016;
        uint num3;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            int num4 = locationOnly ? -861679853 : (num4 = -1712786595);
            int num5 = (int) num3 * -62348980;
            num1 = num4 ^ num5;
            continue;
          case 2:
            int num6 = flag3 ? -1385759235 : (num6 = -1407963122);
            int num7 = (int) num3 * 692266889;
            num1 = num6 ^ num7;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 309871376 ^ -1973876880;
            continue;
          case 5:
            flag1 = false;
            flag3 = this.ZoomWindowType == ZoomWindowType.Undefined;
            num1 = (int) num3 * 184754732 ^ -1360480930;
            continue;
          case 6:
            flag2 = true;
            num1 = (int) num3 * -186381976 ^ 1951748674;
            continue;
          case 7:
            windowTitle = WindowHelper.GetWindowTitle(this.handle);
            windowClass = WindowHelper.GetWindowClass(this.handle);
            num1 = 1829974576;
            continue;
          case 8:
            flag1 = true;
            num1 = (int) num3 * 2062153863 ^ 403411141;
            continue;
          case 9:
            goto label_66;
          case 10:
            windowLocker = ZoomWindow.windowLocker;
            num1 = 1059314334;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      bool flag4 = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag4);
label_13:
        int num2 = 475691896;
        while (true)
        {
          int num3 = 2132290016;
          uint num4;
          bool flag3;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 11U)
          {
            case 0:
              goto label_13;
            case 1:
              num2 = (int) num4 * -668160116 ^ 1519158322;
              continue;
            case 2:
              num2 = (int) num4 * 1685558783 ^ 559472667;
              continue;
            case 3:
              flag1 = true;
              num2 = (int) num4 * 355532394 ^ 1907982115;
              continue;
            case 4:
              this.Title = windowTitle;
              num2 = 1870216781;
              continue;
            case 6:
              int num6 = !flag3 ? -1967534536 : (num6 = -354392665);
              int num7 = (int) num4 * -25110619;
              num2 = num6 ^ num7;
              continue;
            case 7:
              this.ClassName = windowClass;
              num2 = (int) num4 * 972831036 ^ 1078135309;
              continue;
            case 8:
              num5 = !ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, windowClass) ? 1 : 0;
              break;
            case 9:
              if (!ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, windowTitle))
              {
                num5 = 1;
                break;
              }
              num2 = (int) num4 * 718269512 ^ -1594835209;
              continue;
            case 10:
              num2 = (int) num4 * -1644883259 ^ 272301338;
              continue;
            default:
              goto label_33;
          }
          flag3 = num5 != 0;
          num2 = 748228727;
        }
      }
      finally
      {
        if (flag4)
        {
label_28:
          int num2 = 993317363;
          while (true)
          {
            int num3 = 2132290016;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_28;
              case 1:
                num2 = (int) num4 * 1679176718 ^ 1833476644;
                continue;
              case 3:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                num2 = (int) num4 * 1946088097 ^ 547636934;
                continue;
              default:
                goto label_32;
            }
          }
        }
label_32:;
      }
label_33:
      if (extendedRefresh)
        goto label_38;
label_34:
      int num8 = 1606193505;
label_35:
      while (true)
      {
        int num2 = 2132290016;
        uint num3;
        bool flag3;
        switch ((num3 = (uint) (num8 ^ num2)) % 11U)
        {
          case 0:
            this.Pattern = this.Engine.ActivePattern;
            num8 = (int) num3 * -1929372951 ^ -771534346;
            continue;
          case 1:
            flag3 = this.Pattern != this.Engine.ActivePattern;
            num8 = 1148394777;
            continue;
          case 2:
            int num4 = !flag3 ? -31946184 : (num4 = -1870723301);
            int num5 = (int) num3 * -860024898;
            num8 = num4 ^ num5;
            continue;
          case 3:
            goto label_34;
          case 4:
            num8 = (int) num3 * -1834739086 ^ -482151772;
            continue;
          case 5:
            num8 = (int) num3 * -1085029646 ^ -244715706;
            continue;
          case 7:
            goto label_36;
          case 8:
            num8 = (int) num3 * -726787278 ^ -1830991473;
            continue;
          case 9:
            this.SetWindowTypes(false);
            num8 = (int) num3 * -2200014 ^ -593528059;
            continue;
          case 10:
            goto label_38;
          default:
            goto label_45;
        }
      }
label_36:
      flag2 = true;
      goto label_66;
label_45:
      try
      {
label_47:
        int num2 = 1192477111;
        while (true)
        {
          int num3 = 2132290016;
          uint num4;
          string windowExtendedStyles;
          string[] itemStrings;
          string[] itemStyles;
          IntPtr itemHandle;
          switch ((num4 = (uint) (num2 ^ num3)) % 17U)
          {
            case 0:
              num2 = (int) num4 * 1298145212 ^ -1218832352;
              continue;
            case 1:
              this.ItemStyles = itemStrings;
              num2 = (int) num4 * -1679686731 ^ -188669746;
              continue;
            case 2:
              num2 = (int) num4 * -769639098 ^ 865516653;
              continue;
            case 3:
              this.ItemStrings = itemStyles;
              num2 = (int) num4 * 252015658 ^ 1247506828;
              continue;
            case 4:
              this.ItemHandle = itemHandle;
              num2 = (int) num4 * 1215406850 ^ 1862345770;
              continue;
            case 5:
              this.Child = User32.GetWindow(this.handle, GW.CHILD);
              num2 = (int) num4 * 1393419406 ^ 1189197623;
              continue;
            case 6:
              this.Parent = User32.GetParent(this.handle);
              num2 = (int) num4 * 842565775 ^ 1330184477;
              continue;
            case 7:
              num2 = (int) num4 * -61665958 ^ -195761521;
              continue;
            case 8:
              this.Owner = User32.GetAncestor(this.handle, 3U);
              num2 = (int) num4 * -1987098991 ^ 1690682965;
              continue;
            case 9:
              this.Previous = User32.GetWindow(this.handle, GW.HWNDPREV);
              num2 = (int) num4 * 216995740 ^ 1532968605;
              continue;
            case 11:
              num2 = (int) num4 * 1714969965 ^ -2085771314;
              continue;
            case 12:
              string windowStyles = WindowHelper.GetWindowStyles(this.handle);
              windowExtendedStyles = WindowHelper.GetWindowExtendedStyles(this.handle);
              this.Styles = windowStyles;
              num2 = (int) num4 * 1610710424 ^ -1730359530;
              continue;
            case 13:
              string itemType;
              WindowHelper.GetWindowItemInformation(this.handle, out itemType, out itemStrings, out itemStyles, out itemHandle);
              this.ItemType = itemType;
              num2 = (int) num4 * -713286604 ^ 717901805;
              continue;
            case 14:
              goto label_47;
            case 15:
              this.ExtendedStyles = windowExtendedStyles;
              num2 = (int) num4 * 1045099543 ^ -1445932292;
              continue;
            case 16:
              this.Next = User32.GetWindow(this.handle, GW.HWNDNEXT);
              num2 = (int) num4 * -1865698553 ^ 127278236;
              continue;
            default:
              goto label_65;
          }
        }
      }
      catch (Exception ex)
      {
      }
label_65:
      flag2 = true;
      goto label_66;
label_38:
      num8 = !flag1 ? 163741443 : (num8 = 1248859898);
      goto label_35;
label_66:
      return flag2;
    }

    internal void ApplyLayoutPattern(object state = null)
    {
label_1:
      int num1 = 901076359;
      WindowMovementPayload windowMovementPayload1;
      List<ZoomWindowType> zoomWindowTypeList;
      while (true)
      {
        int num2 = 727161245;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            if (!this.Engine.Settings.ZoomZoomDockingEnabled)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 2032886154 ^ -1000254745;
            continue;
          case 1:
            zoomWindowTypeList = new List<ZoomWindowType>()
            {
              ZoomWindowType.Meeting,
              ZoomWindowType.Join,
              ZoomWindowType.AccountPanel,
              ZoomWindowType.ManyCamBroadcast
            };
            num1 = (int) num3 * 453079434 ^ -603330052;
            continue;
          case 3:
            windowMovementPayload1 = new WindowMovementPayload();
            num1 = (int) num3 * -1732912430 ^ -844937142;
            continue;
          case 4:
            goto label_1;
          case 5:
            num4 = this.ApplyWindowLayout ? 1 : 0;
            break;
          case 6:
            if (this.ZoomWindowType == ZoomWindowType.ZoomZoomMain)
            {
              num1 = (int) num3 * -431805700 ^ 855104549;
              continue;
            }
            goto label_48;
          case 7:
            num1 = (int) num3 * -723474999 ^ -34362020;
            continue;
          case 8:
            num1 = (int) num3 * -642135755 ^ 1925472959;
            continue;
          default:
            goto label_15;
        }
        if (num4 != 0)
          num1 = 153204161;
        else
          goto label_63;
      }
label_15:
      List<ZoomWindowType>.Enumerator enumerator1 = zoomWindowTypeList.GetEnumerator();
      try
      {
label_21:
        int num2 = enumerator1.MoveNext() ? 1402270905 : (num2 = 1491448330);
        while (true)
        {
          int num3 = 727161245;
          uint num4;
          ZoomWindowType current;
          ZoomWindow window;
          System.Drawing.Point location;
          bool flag;
          switch ((num4 = (uint) (num2 ^ num3)) % 19U)
          {
            case 0:
              num2 = 1159177693;
              continue;
            case 1:
              current = enumerator1.Current;
              num2 = 365792279;
              continue;
            case 2:
              num2 = (int) num4 * -1641723320 ^ 988327692;
              continue;
            case 3:
              goto label_21;
            case 4:
              num2 = (int) num4 * 1691165156 ^ 503765806;
              continue;
            case 5:
              flag = window != null;
              num2 = (int) num4 * 593503449 ^ 2131410786;
              continue;
            case 6:
              location = this.Location;
              num2 = (int) num4 * 167849315 ^ -1231267155;
              continue;
            case 7:
              windowMovementPayload1.WindowType = ZoomWindowType.ZoomZoomMain;
              num2 = (int) num4 * 878577432 ^ -370099676;
              continue;
            case 8:
              int num5 = flag ? 1879616460 : (num5 = 359639230);
              int num6 = (int) num4 * 552742084;
              num2 = num5 ^ num6;
              continue;
            case 9:
              WindowMovementPayload windowMovementPayload2 = windowMovementPayload1;
              location = window.Location;
              int num7 = location.X + 5;
              windowMovementPayload2.X = num7;
              num2 = (int) num4 * 678671836 ^ 1139725396;
              continue;
            case 11:
              num2 = (int) num4 * 2123224892 ^ -2135270007;
              continue;
            case 12:
              num2 = (int) num4 * 1390339970 ^ -314103417;
              continue;
            case 13:
              num2 = 1402270905;
              continue;
            case 14:
              num2 = (int) num4 * 1844386267 ^ 911119907;
              continue;
            case 15:
              int num8 = location.Equals((object) new System.Drawing.Point(window.Location.X + 5, window.Location.Y + 5)) ? -657486210 : (num8 = -480596479);
              int num9 = (int) num4 * -1006675629;
              num2 = num8 ^ num9;
              continue;
            case 16:
              num2 = 1274333478;
              continue;
            case 17:
              window = this.Engine.GetWindow(current);
              num2 = (int) num4 * -1175919403 ^ -1629757120;
              continue;
            case 18:
              WindowMovementPayload windowMovementPayload3 = windowMovementPayload1;
              location = window.Location;
              int num10 = location.Y + 5;
              windowMovementPayload3.Y = num10;
              num2 = (int) num4 * -2136339966 ^ -1239323433;
              continue;
            default:
              goto label_41;
          }
        }
      }
      finally
      {
        enumerator1.Dispose();
label_37:
        int num2 = 1801343959;
        while (true)
        {
          int num3 = 727161245;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * 1008502435 ^ 21487769;
              continue;
            case 2:
              goto label_37;
            default:
              goto label_40;
          }
        }
label_40:;
      }
label_41:
      if (!windowMovementPayload1.Changed)
        goto label_70;
label_42:
      int num11 = 917677296;
label_43:
      bool flag1;
      List<ZoomWindow> list;
      bool flag2;
      while (true)
      {
        int num2 = 727161245;
        uint num3;
        bool hasStretched;
        switch ((num3 = (uint) (num11 ^ num2)) % 23U)
        {
          case 0:
            goto label_48;
          case 1:
            num11 = (int) num3 * -2089819917 ^ 913646976;
            continue;
          case 2:
            if (this.RequiresMovement)
            {
              num11 = (int) num3 * -7413518 ^ 848554765;
              continue;
            }
            goto label_102;
          case 3:
            flag2 = true;
            hasStretched = this.WindowLayout.HasStretched;
            num11 = (int) num3 * -1397803093 ^ -935632102;
            continue;
          case 4:
            goto label_128;
          case 5:
            flag2 = false;
            num11 = (int) num3 * 545908081 ^ 1501146327;
            continue;
          case 6:
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.GetOverlappedWindows(this), (Func<M0, bool>) new Func<ZoomWindow, bool>((object) this, __methodptr(\u003CApplyLayoutPattern\u003Eb__156_0)))).ToList<ZoomWindow>();
            num11 = (int) num3 * -1419933919 ^ 1157862872;
            continue;
          case 7:
            if (flag1)
            {
              num11 = (int) num3 * 99095869 ^ -193444317;
              continue;
            }
            goto label_128;
          case 8:
            ((CompositePresentationEvent<WindowMovementPayload>) this._eventAggregator.GetEvent<MoveZoomZoomWindow>()).Publish(windowMovementPayload1);
            num11 = (int) num3 * -1767558025 ^ -1848042985;
            continue;
          case 9:
            num11 = (int) num3 * -1253354624 ^ 1213206622;
            continue;
          case 10:
            if (hasStretched)
            {
              num11 = (int) num3 * 428662304 ^ 402985316;
              continue;
            }
            goto label_116;
          case 11:
            num11 = (int) num3 * -2022115198 ^ -1054120402;
            continue;
          case 12:
            if (this.ApplyWindowLayout)
            {
              num11 = (int) num3 * 1512672298 ^ 41789770;
              continue;
            }
            goto label_60;
          case 13:
            this.Move(this.DefaultRectangle);
            num11 = (int) num3 * 1850397516 ^ -2007148841;
            continue;
          case 14:
            if (this.IsVisible)
            {
              num11 = (int) num3 * 1758742577 ^ 961018595;
              continue;
            }
            goto label_118;
          case 15:
            goto label_59;
          case 16:
            goto label_63;
          case 17:
            num11 = (int) num3 * -117600646 ^ 315312533;
            continue;
          case 18:
            num11 = (int) num3 * 795741779 ^ 600397579;
            continue;
          case 19:
            goto label_70;
          case 20:
            goto label_42;
          case 22:
            num11 = (int) num3 * -1389469617 ^ -422752640;
            continue;
          default:
            goto label_72;
        }
      }
label_59:
      int num12 = (uint) this.DefaultVisibility > 0U ? 1 : 0;
      goto label_61;
label_72:
      List<ZoomWindow>.Enumerator enumerator2 = list.GetEnumerator();
      try
      {
label_79:
        int num2 = !enumerator2.MoveNext() ? 1817750654 : (num2 = 1786503876);
        while (true)
        {
          int num3 = 727161245;
          uint num4;
          ZoomWindow current;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              this.Engine.WindowQueue.Enqueue(new ZoomEvent(current)
              {
                EventType = ZoomEventType.MoveSize
              });
              num2 = (int) num4 * -1447736946 ^ -260371301;
              continue;
            case 2:
              num2 = (int) num4 * 1038300496 ^ -694009976;
              continue;
            case 3:
              num2 = (int) num4 * -1200486249 ^ 849038133;
              continue;
            case 4:
              num2 = 1786503876;
              continue;
            case 5:
              goto label_79;
            case 6:
              current = enumerator2.Current;
              num2 = 2694680;
              continue;
            default:
              goto label_86;
          }
        }
      }
      finally
      {
        enumerator2.Dispose();
label_82:
        int num2 = 1693922086;
        while (true)
        {
          int num3 = 727161245;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_82;
            case 2:
              num2 = (int) num4 * 1683374220 ^ 1758729759;
              continue;
            default:
              goto label_85;
          }
        }
label_85:;
      }
label_86:
label_87:
      int num13 = 1467785877;
label_88:
      bool flag3;
      while (true)
      {
        int num2 = 727161245;
        uint num3;
        ZoomWindow window;
        bool flag4;
        bool flag5;
        int num4;
        int num5;
        switch ((num3 = (uint) (num13 ^ num2)) % 30U)
        {
          case 0:
            if (this.DefaultVisibility == WindowVisibility.Hide)
            {
              num13 = 759177452;
              continue;
            }
            num4 = 0;
            goto label_126;
          case 1:
            num13 = (int) num3 * -1756272049 ^ -2013952457;
            continue;
          case 2:
            goto label_102;
          case 4:
            this.Hide();
            num13 = (int) num3 * 1866178628 ^ -2030606637;
            continue;
          case 5:
            goto label_118;
          case 6:
            int num6 = !flag3 ? -1967812245 : (num6 = -1022018947);
            int num7 = (int) num3 * 1458535933;
            num13 = num6 ^ num7;
            continue;
          case 7:
            num5 = this.ZoomWindowType == ZoomWindowType.ManyCamApp ? 1 : 0;
            goto label_121;
          case 8:
            num13 = 1043769354;
            continue;
          case 9:
            this.Close(false, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3134813295U));
            flag2 = true;
            num13 = (int) num3 * -300287872 ^ 68071077;
            continue;
          case 10:
            if (this.ZoomWindowType != ZoomWindowType.Join)
            {
              num13 = (int) num3 * 256449820 ^ -1531674854;
              continue;
            }
            break;
          case 11:
            if (this.ZoomWindowType != ZoomWindowType.Meeting)
            {
              num13 = 1988992065;
              continue;
            }
            break;
          case 12:
            num13 = (int) num3 * 545471703 ^ 311100382;
            continue;
          case 13:
            num13 = (int) num3 * 1208298911 ^ -788248247;
            continue;
          case 14:
            flag2 = true;
            num13 = (int) num3 * -29652383 ^ 362082326;
            continue;
          case 15:
            window.ApplyLayoutPattern((object) null);
            num13 = (int) num3 * 90437822 ^ -1140730861;
            continue;
          case 16:
            goto label_97;
          case 17:
            num13 = (int) num3 * -305858439 ^ 1118738959;
            continue;
          case 18:
            num13 = (int) num3 * 1434655682 ^ 792373358;
            continue;
          case 19:
            window = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
            flag4 = window != null;
            num13 = (int) num3 * 1623646246 ^ 741471392;
            continue;
          case 20:
            num13 = (int) num3 * -927639319 ^ 1666450744;
            continue;
          case 21:
            goto label_87;
          case 22:
            num13 = (int) num3 * 250635574 ^ -138513114;
            continue;
          case 23:
            num13 = 1466570271;
            continue;
          case 24:
            goto label_116;
          case 25:
            num13 = (int) num3 * 1063467839 ^ 2030230487;
            continue;
          case 26:
            if (this.ZoomWindowType != ZoomWindowType.AccountPanel)
            {
              num13 = (int) num3 * 709800154 ^ -1589420991;
              continue;
            }
            break;
          case 27:
            num4 = this.IsVisible ? 1 : 0;
            goto label_126;
          case 28:
            int num8 = flag5 ? 1159183747 : (num8 = 698079113);
            int num9 = (int) num3 * -926214865;
            num13 = num8 ^ num9;
            continue;
          case 29:
            int num10 = !flag4 ? 602766067 : (num10 = 1646668709);
            int num14 = (int) num3 * -1000381095;
            num13 = num10 ^ num14;
            continue;
          default:
            goto label_128;
        }
        num5 = 1;
label_121:
        flag5 = num5 != 0;
        num13 = 2034264023;
        continue;
label_126:
        int num15;
        num13 = num15 = num4 == 0 ? 433732754 : (num15 = 155463917);
      }
label_97:
      int num16 = this.IsVisible ? 1 : 0;
label_99:
      flag3 = num16 != 0;
      num13 = 752145947;
      goto label_88;
label_102:
      if (this.DefaultVisibility != WindowVisibility.Close)
      {
        num16 = 0;
        goto label_99;
      }
      else
      {
        num13 = 1026471301;
        goto label_88;
      }
label_116:
      num13 = 1165859504;
      goto label_88;
label_118:
      num13 = 433732754;
      goto label_88;
label_128:
      this.WindowInspected = DateTime.Now;
      return;
label_48:
      if (this.Engine.Settings.ApplyLayoutPattern)
      {
        num11 = 1083292700;
        goto label_43;
      }
label_60:
      num12 = 0;
label_61:
      flag1 = num12 != 0;
      num11 = 781540058;
      goto label_43;
label_63:
      num11 = 1587139852;
      goto label_43;
label_70:
      num11 = 1288069617;
      goto label_43;
    }

    public void SetVisibility(bool isVisible)
    {
      object windowLocker = ZoomWindow.windowLocker;
      bool flag = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_2:
        int num1 = -387482149;
        while (true)
        {
          int num2 = -1558889862;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_10;
            case 1:
              num1 = (int) num3 * 1534358747 ^ -1114253289;
              continue;
            case 2:
              this.isVisible = isVisible;
              num1 = (int) num3 * -388049283 ^ -372490672;
              continue;
            case 3:
              goto label_2;
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
          int num1 = -1747989541;
          while (true)
          {
            int num2 = -1558889862;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                num1 = (int) num3 * 1369152781 ^ -1157966975;
                continue;
              case 2:
                num1 = (int) num3 * 310494686 ^ -2054570418;
                continue;
              case 3:
                goto label_8;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    private void ImplementWindowLayout(WindowLayout layout)
    {
label_1:
      int num1 = -1726317667;
      object windowLocker;
      while (true)
      {
        int num2 = -1480644367;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            windowLocker = ZoomWindow.windowLocker;
            num1 = (int) num3 * -1025259550 ^ 111200813;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_6:
        int num2 = -688983060;
        while (true)
        {
          int num3 = -1480644367;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              this.defaultVisibility = layout.WindowVisibility;
              num2 = (int) num4 * 180589199 ^ 786665059;
              continue;
            case 1:
              this.applyWindowLayout = this.Engine.Settings.ApplyLayoutPattern;
              num2 = (int) num4 * -1050680438 ^ 970667423;
              continue;
            case 2:
              this.windowLayout = layout;
              num2 = (int) num4 * 1187068584 ^ 596624908;
              continue;
            case 3:
              this.defaultRectangle = layout.Rectangle;
              num2 = (int) num4 * -1698890767 ^ 275775064;
              continue;
            case 4:
              goto label_16;
            case 5:
              goto label_6;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_16:;
      }
      finally
      {
        if (flag)
        {
label_14:
          int num2 = -1469090797;
          while (true)
          {
            int num3 = -1480644367;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                num2 = (int) num4 * 658635603 ^ -69065699;
                continue;
              case 2:
                goto label_14;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
    }

    public static ZoomButtonType InitiatingButtonType(ZoomWindowType windowType)
    {
      ZoomWindowType zoomWindowType = windowType;
      if (zoomWindowType == ZoomWindowType.Chat)
        goto label_6;
label_1:
      int num1 = -837738377;
label_2:
      ZoomButtonType zoomButtonType;
      while (true)
      {
        int num2 = -711183684;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 26U)
        {
          case 0:
label_12:
            zoomButtonType = ZoomButtonType.Invite;
            num1 = -207975197;
            continue;
          case 1:
            num1 = (int) num3 * -774448967 ^ 1434518926;
            continue;
          case 2:
label_20:
            zoomButtonType = ZoomButtonType.ShareScreen;
            num1 = -1865283950;
            continue;
          case 3:
            num1 = (int) num3 * 1141226755 ^ 1938741738;
            continue;
          case 4:
            goto label_6;
          case 5:
            num1 = (int) num3 * -1540927427 ^ 1383448038;
            continue;
          case 6:
            zoomButtonType = ZoomButtonType.Participants;
            num1 = -437553749;
            continue;
          case 7:
            num1 = (int) num3 * -2076091053 ^ 1259646576;
            continue;
          case 8:
            num1 = (int) num3 * -857710782 ^ 1045251813;
            continue;
          case 9:
            num1 = (int) num3 * 2144994829 ^ -150312787;
            continue;
          case 10:
          case 18:
label_9:
            zoomButtonType = ZoomButtonType.Unknown;
            num1 = -1947811311;
            continue;
          case 12:
label_11:
            zoomButtonType = ZoomButtonType.ToggleAudio;
            num1 = -1935149803;
            continue;
          case 13:
label_7:
            zoomButtonType = ZoomButtonType.ToggleAudio;
            num1 = -1843678465;
            continue;
          case 14:
            int num4;
            num1 = num4 = zoomWindowType == ZoomWindowType.Participants ? -1849852250 : (num4 = -1815002023);
            continue;
          case 15:
            num1 = (int) num3 * 2079683148 ^ -1420357595;
            continue;
          case 16:
            switch (zoomWindowType)
            {
              case ZoomWindowType.Settings:
                goto label_8;
              case ZoomWindowType.Invite:
                goto label_12;
              case ZoomWindowType.ScreenSharingDisabled:
              case ZoomWindowType.WaitingForHost:
              case ZoomWindowType.LeaveCurrent:
                goto label_9;
              case ZoomWindowType.RequestRecord:
                goto label_5;
              case ZoomWindowType.AudioNotification:
                goto label_7;
              case ZoomWindowType.AudioError:
                goto label_21;
              case ZoomWindowType.AudioMenu:
                goto label_11;
              case ZoomWindowType.Sharing:
                goto label_20;
              default:
                num1 = -1272340459;
                continue;
            }
          case 17:
            num1 = (int) num3 * 1033264770 ^ -1667512290;
            continue;
          case 19:
            num1 = (int) num3 * 1138588451 ^ -745121489;
            continue;
          case 20:
label_8:
            zoomButtonType = ZoomButtonType.ToggleVideo;
            num1 = -2145987001;
            continue;
          case 21:
label_21:
            zoomButtonType = ZoomButtonType.Record;
            num1 = -2005153146;
            continue;
          case 22:
            num1 = (int) num3 * -746144911 ^ -920870067;
            continue;
          case 23:
            goto label_1;
          case 24:
            num1 = (int) num3 * 320857694 ^ -87245067;
            continue;
          case 25:
label_5:
            zoomButtonType = ZoomButtonType.Record;
            num1 = -1947811311;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return zoomButtonType;
label_6:
      zoomButtonType = ZoomButtonType.Chat;
      num1 = -796048480;
      goto label_2;
    }

    public ClickState ClickButton(ZoomButton button)
    {
      bool flag1 = false;
      try
      {
        object windowLocker = ZoomWindow.windowLocker;
        bool flag2 = false;
        try
        {
          ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag2);
label_3:
          int num1 = 1371077872;
          while (true)
          {
            int num2 = 1293087281;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 7U)
            {
              case 1:
                num1 = (int) num3 * -552438499 ^ 870850499;
                continue;
              case 2:
                WindowHelper.ForceForeground(this.Handle);
                button.ClickState = ClickState.Clicking;
                num1 = (int) num3 * 71445872 ^ 1040467756;
                continue;
              case 3:
                flag1 = MouseHelper.ClickWindowPosition(this.Handle, button.ButtonX, button.ButtonY, !button.RequiresRightClick, 0, true);
                button.ClickState = ClickState.Clicked;
                num1 = (int) num3 * 450841975 ^ 279261259;
                continue;
              case 4:
                ZoomWindow.\u200D‪‬‏⁬⁯⁮‬‎‪⁫⁫‭​⁬⁮⁮‎⁬‪⁯‎‏⁮⁭‎⁬⁯⁮‭‬‭‬‬⁭‮⁮‌⁫‬‮(CoreObject.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2886620005U), new object[4]
                {
                  (object) button.ResultingWindowType,
                  (object) button.ButtonX,
                  (object) button.ButtonY,
                  (object) this.ZoomWindowType
                });
                num1 = (int) num3 * 965386756 ^ -2070180721;
                continue;
              case 5:
                goto label_3;
              case 6:
                num1 = (int) num3 * 1818563768 ^ -1563571896;
                continue;
              default:
                goto label_22;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_11:
            int num1 = 1814395647;
            while (true)
            {
              int num2 = 1293087281;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 1:
                  ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                  num1 = (int) num3 * 1376526015 ^ -1118497706;
                  continue;
                case 2:
                  goto label_11;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
      }
      catch (Exception ex)
      {
label_16:
        int num1 = 850825792;
        while (true)
        {
          int num2 = 1293087281;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_16;
            case 2:
              num1 = (int) num3 * -1897158190 ^ 943532226;
              continue;
            case 3:
              ZoomWindow.\u200F‌‏⁬⁮⁭⁭‮⁪⁪​‬⁯‌⁪‭⁯‎‪‭‮⁫⁫‬‎‍‮‮‍‭‪⁮​⁮⁫⁫‌⁭‍‪‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 2124847795 ^ -996804056;
              continue;
            case 4:
              num1 = (int) num3 * -96944240 ^ 1558617691;
              continue;
            case 5:
              num1 = (int) num3 * 1188026151 ^ 132024761;
              continue;
            default:
              goto label_22;
          }
        }
      }
label_22:
      return button.ClickState;
    }

    public ZoomWindow ClickButtonAwaitResult(ZoomButton button, CancellationToken token, bool closeIfAlreadyOpen = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ZoomWindow.\u003C\u003Ec__DisplayClass161_0 displayClass1610 = new ZoomWindow.\u003C\u003Ec__DisplayClass161_0();
label_1:
      int num1 = -1018998502;
      ZoomWindow zoomWindow1;
      while (true)
      {
        int num2 = -1047178901;
        uint num3;
        bool flag1;
        bool flag2;
        DateTime dateTime;
        ZoomEvent zoomEvent;
        ZoomWindow zoomWindow2;
        ZoomWindow window1;
        ZoomWindow zoomWindow3;
        bool flag3;
        bool flag4;
        bool flag5;
        List<IntPtr> list;
        bool flag6;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 44U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list = ((IEnumerable<IntPtr>) Enumerable.Where<IntPtr>((IEnumerable<M0>) WindowManager.GetVisibleWindowHandles(this.ProcessId), (Func<M0, bool>) (displayClass1610.\u003C\u003E9__1 ?? (displayClass1610.\u003C\u003E9__1 = new Func<IntPtr, bool>((object) displayClass1610, __methodptr(\u003CClickButtonAwaitResult\u003Eb__1)))))).ToList<IntPtr>();
            num1 = -1178977844;
            continue;
          case 1:
label_107:
            flag6 = zoomWindow2 != null;
            num4 = -1121489539;
            goto label_70;
          case 2:
            flag3 = this.ZoomWindowType == ZoomWindowType.Meeting;
            num1 = -1149133551;
            continue;
          case 3:
label_102:
            if (!(dateTime > DateTime.Now))
            {
              num5 = 0;
              goto label_100;
            }
            else
            {
              num4 = -1484582124;
              goto label_70;
            }
          case 4:
            goto label_1;
          case 5:
            flag2 = this.Engine.SharedData.ActivityQueue.TryDequeue(ref zoomEvent);
            num1 = -1136287378;
            continue;
          case 6:
            int num7 = flag3 ? -849040142 : (num7 = -824012626);
            int num8 = (int) num3 * 1767190806;
            num1 = num7 ^ num8;
            continue;
          case 7:
            num1 = -257868449;
            continue;
          case 8:
            num1 = -159429124;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            displayClass1610.existingWindows = WindowManager.GetVisibleWindowHandles(this.ProcessId);
            num1 = -1314829720;
            continue;
          case 10:
            num1 = (int) num3 * -823159480 ^ 58782248;
            continue;
          case 11:
            num1 = (int) num3 * 41348768 ^ -742496034;
            continue;
          case 12:
            window1 = this.Engine.GetWindow(button.ResultingWindowType);
            num1 = (int) num3 * 363508478 ^ 1570275311;
            continue;
          case 13:
            num1 = (int) num3 * -1017736507 ^ 202090200;
            continue;
          case 14:
            num1 = (int) num3 * -1108833118 ^ 1693206702;
            continue;
          case 15:
            zoomWindow3.Activate();
            num1 = (int) num3 * 900375955 ^ 817037365;
            continue;
          case 16:
            num1 = (int) num3 * -425752702 ^ 727876095;
            continue;
          case 17:
            num1 = -742961635;
            continue;
          case 18:
            if (this.Engine.ActiveActivity != null)
            {
              num1 = (int) num3 * -1354957808 ^ 67155860;
              continue;
            }
            num6 = 0;
            break;
          case 19:
            int num9 = flag4 ? 651969221 : (num9 = 1385184954);
            int num10 = (int) num3 * 965340354;
            num1 = num9 ^ num10;
            continue;
          case 20:
            zoomWindow2 = zoomEvent.Window;
            num1 = (int) num3 * 152378047 ^ 653135143;
            continue;
          case 21:
            int num11 = !flag2 ? 225778436 : (num11 = 572619666);
            int num12 = (int) num3 * 1967341577;
            num1 = num11 ^ num12;
            continue;
          case 22:
            int num13 = ZoomWindow.ButtonPossibleResultingZoomWindowTypes.Contains(zoomEvent.ZoomWindowType) ? -451639635 : (num13 = -886811623);
            int num14 = (int) num3 * 2098118413;
            num1 = num13 ^ num14;
            continue;
          case 23:
            num1 = (int) num3 * -2113198088 ^ -609989618;
            continue;
          case 24:
            num1 = -780551134;
            continue;
          case 25:
            zoomWindow2 = (ZoomWindow) null;
            int num15 = (uint) button.ResultingWindowType > 0U ? 859945892 : (num15 = 184106886);
            int num16 = (int) num3 * -1956013877;
            num1 = num15 ^ num16;
            continue;
          case 26:
            num1 = -1450410798;
            continue;
          case 27:
            num6 = this.Engine.ActiveActivity is FindButtons ? 1 : 0;
            break;
          case 28:
            num1 = (int) num3 * -1830164249 ^ -295952759;
            continue;
          case 29:
            num1 = (int) num3 * 1733416492 ^ -533717654;
            continue;
          case 30:
            dateTime = DateTime.Now.AddSeconds(1.0);
            num1 = (int) num3 * 936186463 ^ -16351658;
            continue;
          case 31:
            num1 = -1271664330;
            continue;
          case 32:
            int num17 = !flag5 ? 1258262842 : (num17 = 1056300288);
            int num18 = (int) num3 * -1890858368;
            num1 = num17 ^ num18;
            continue;
          case 33:
            int num19 = flag1 ? 968883159 : (num19 = 697235272);
            int num20 = (int) num3 * -1278232340;
            num1 = num19 ^ num20;
            continue;
          case 34:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            zoomWindow3 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (ZoomWindow.\u003C\u003Ec.\u003C\u003E9__161_0 ?? (ZoomWindow.\u003C\u003Ec.\u003C\u003E9__161_0 = new Func<ZoomWindow, bool>((object) ZoomWindow.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CClickButtonAwaitResult\u003Eb__161_0)))));
            num1 = -470114800;
            continue;
          case 35:
            window1.Close(false, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4011434338U));
            num1 = (int) num3 * -1598940864 ^ -2070256895;
            continue;
          case 36:
            flag5 = window1 != null;
            num1 = (int) num3 * 1280015787 ^ -1618098145;
            continue;
          case 37:
            num1 = (int) num3 * -1911779228 ^ -805518063;
            continue;
          case 38:
            int num21 = (int) this.ClickButton(button);
            num1 = (int) num3 * 1786300649 ^ 360990183;
            continue;
          case 40:
            num1 = (int) num3 * 1103772263 ^ 1688771621;
            continue;
          case 41:
label_43:
            num1 = -655744591;
            continue;
          case 42:
            flag4 = this.Engine.SharedData.ActivityQueue.TryDequeue(ref zoomEvent);
            num1 = (int) num3 * 961710850 ^ 1775889236;
            continue;
          case 43:
            int num22 = zoomWindow3 == null ? -943916 : (num22 = -706690464);
            int num23 = (int) num3 * -2122773117;
            num1 = num22 ^ num23;
            continue;
          default:
            List<IntPtr>.Enumerator enumerator = list.GetEnumerator();
            try
            {
label_60:
              int num24 = !enumerator.MoveNext() ? -458405752 : (num24 = -1744610350);
              while (true)
              {
                int num25 = -1047178901;
                uint num26;
                ZoomWindow window2;
                bool flag7;
                IntPtr current;
                int num27;
                switch ((num26 = (uint) (num24 ^ num25)) % 12U)
                {
                  case 0:
                    goto label_60;
                  case 1:
                    if (window2 == null)
                    {
                      num27 = 0;
                      break;
                    }
                    num24 = (int) num26 * -25525317 ^ -1755243701;
                    continue;
                  case 2:
                    num24 = -896386749;
                    continue;
                  case 4:
                    num24 = (int) num26 * 345738340 ^ 1959922696;
                    continue;
                  case 5:
                    current = enumerator.Current;
                    num24 = -2128652195;
                    continue;
                  case 6:
                    int num28 = flag7 ? 1317685427 : (num28 = 35689537);
                    int num29 = (int) num26 * 1785168120;
                    num24 = num28 ^ num29;
                    continue;
                  case 7:
                    num24 = -1744610350;
                    continue;
                  case 8:
                    num24 = (int) num26 * 1836398098 ^ 1462368898;
                    continue;
                  case 9:
                    zoomWindow2 = window2;
                    num24 = (int) num26 * 233603680 ^ -972679125;
                    continue;
                  case 10:
                    window2 = ZoomFactory.CreateWindow(current);
                    num24 = (int) num26 * 973772641 ^ -1436664568;
                    continue;
                  case 11:
                    num27 = ZoomWindow.ButtonPossibleResultingZoomWindowTypes.Contains(window2.ZoomWindowType) ? 1 : 0;
                    break;
                  default:
                    goto label_68;
                }
                flag7 = num27 != 0;
                num24 = -1640336207;
              }
            }
            finally
            {
              enumerator.Dispose();
label_64:
              int num24 = -436197487;
              while (true)
              {
                int num25 = -1047178901;
                uint num26;
                switch ((num26 = (uint) (num24 ^ num25)) % 3U)
                {
                  case 0:
                    goto label_64;
                  case 1:
                    num24 = (int) num26 * -1358450446 ^ -1839351374;
                    continue;
                  default:
                    goto label_67;
                }
              }
label_67:;
            }
label_68:
            goto label_69;
        }
        flag1 = num6 != 0;
        num1 = -1878925374;
        continue;
label_69:
        num4 = -2109608788;
label_70:
        bool flag8;
        while (true)
        {
          int num24 = -1047178901;
          uint num25;
          bool flag7;
          bool flag9;
          bool flag10;
          int num26;
          int num27;
          switch ((num25 = (uint) (num4 ^ num24)) % 45U)
          {
            case 0:
              num4 = (int) num25 * 1373964732 ^ 185948389;
              continue;
            case 1:
              num4 = (int) num25 * 169260282 ^ -618173880;
              continue;
            case 2:
              num4 = (int) num25 * -1720501821 ^ -533530767;
              continue;
            case 3:
              num4 = (int) num25 * -1711089769 ^ -2067615473;
              continue;
            case 4:
              flag9 = button.ResultingWindowType == ZoomWindowType.Undefined;
              num4 = -890781674;
              continue;
            case 5:
              button.ResultingWindowType = zoomWindow2.ZoomWindowType;
              num4 = (int) num25 * -1970180402 ^ 1272093454;
              continue;
            case 6:
              num4 = (int) num25 * -1013926972 ^ -711662773;
              continue;
            case 7:
              int num28 = button.ClickState != ClickState.Clicked ? -269214933 : (num28 = -702786347);
              int num29 = (int) num25 * -431553456;
              num4 = num28 ^ num29;
              continue;
            case 8:
              button.ClickState = ClickState.Verified;
              num4 = (int) num25 * 440059700 ^ 1277974124;
              continue;
            case 9:
              zoomWindow1 = zoomWindow2;
              num4 = -140288444;
              continue;
            case 10:
              num26 = (uint) zoomWindow2.ZoomWindowType > 0U ? 1 : 0;
              break;
            case 11:
              CoreObject.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1447702560U), (object) zoomWindow2.ZoomWindowType, (object) button.ResultingWindowType);
              num4 = (int) num25 * 318591880 ^ 1716433242;
              continue;
            case 12:
              CoreObject.log.DebugFormat(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(329005739U), (object) zoomWindow2.ZoomWindowType);
              num4 = (int) num25 * 419846917 ^ 818398906;
              continue;
            case 13:
              int num30 = flag10 ? -1493001395 : (num30 = -2143706041);
              int num31 = (int) num25 * 744068526;
              num4 = num30 ^ num31;
              continue;
            case 14:
              int num32 = !flag7 ? 908416899 : (num32 = 1349182972);
              int num33 = (int) num25 * 1490041905;
              num4 = num32 ^ num33;
              continue;
            case 15:
              goto label_102;
            case 16:
              num4 = -1262952684;
              continue;
            case 17:
              goto label_98;
            case 18:
              num4 = (int) num25 * 441649672 ^ 1605398236;
              continue;
            case 19:
              if (button.ResultingWindowType != ZoomWindowType.Undefined)
              {
                num4 = (int) num25 * 274414559 ^ -1329789556;
                continue;
              }
              num27 = 0;
              goto label_121;
            case 20:
              int num34 = !flag9 ? -28201747 : (num34 = -753133871);
              int num35 = (int) num25 * 1740358700;
              num4 = num34 ^ num35;
              continue;
            case 21:
              num4 = -794031912;
              continue;
            case 22:
              goto label_107;
            case 23:
              num4 = (int) num25 * -2062243341 ^ -813826969;
              continue;
            case 24:
              num4 = (int) num25 * -1542629830 ^ -1381031530;
              continue;
            case 25:
              button.ClickState = ClickState.Invalid;
              num4 = (int) num25 * -131561217 ^ -1555424855;
              continue;
            case 26:
              num27 = button.ResultingWindowType == zoomWindow2.ZoomWindowType ? 1 : 0;
              goto label_121;
            case 27:
              num4 = (int) num25 * -183698673 ^ 1743607620;
              continue;
            case 28:
              CoreObject.log.DebugFormat(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3071745490U), (object) zoomWindow2.ZoomWindowType);
              num4 = (int) num25 * -304447912 ^ -1780230867;
              continue;
            case 29:
              CoreObject.log.DebugFormat(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(761389930U), (object) zoomWindow2.ZoomWindowType);
              num4 = (int) num25 * -58021691 ^ -178281807;
              continue;
            case 30:
              if (!flag8)
              {
                num4 = (int) num25 * -1256605692 ^ -1707884132;
                continue;
              }
              goto label_43;
            case 31:
              num4 = (int) num25 * 1912322142 ^ 930709764;
              continue;
            case 32:
              num4 = (int) num25 * -1669194761 ^ 1255266975;
              continue;
            case 33:
              num4 = (int) num25 * -540207257 ^ -1699586415;
              continue;
            case 34:
              num4 = (int) num25 * 495520650 ^ 64474542;
              continue;
            case 36:
              CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(906634084U), (object) button.ButtonX, (object) button.ButtonY);
              num4 = (int) num25 * -810532694 ^ -2005919883;
              continue;
            case 37:
              num4 = (int) num25 * -876080475 ^ 1885556553;
              continue;
            case 38:
              goto label_69;
            case 39:
              int num36 = flag6 ? -971484266 : (num36 = -413432430);
              int num37 = (int) num25 * 1595902991;
              num4 = num36 ^ num37;
              continue;
            case 40:
              button.ClickState = ClickState.Verified;
              num4 = (int) num25 * -1487849779 ^ -326943106;
              continue;
            case 41:
              num4 = (int) num25 * -1314785626 ^ -1365930808;
              continue;
            case 42:
              num4 = -1051625912;
              continue;
            case 43:
              if (button.ResultingWindowType != ZoomWindowType.Undefined)
              {
                num26 = 0;
                break;
              }
              num4 = -1505145666;
              continue;
            case 44:
              num4 = (int) num25 * -963822222 ^ -1551261554;
              continue;
            default:
              goto label_124;
          }
          flag7 = num26 != 0;
          num4 = -1859909377;
          continue;
label_121:
          flag10 = num27 != 0;
          num4 = -856138021;
        }
label_98:
        num5 = button.ClickState == ClickState.Clicked ? 1 : 0;
label_100:
        flag8 = num5 != 0;
        num4 = -2094037763;
        goto label_70;
      }
label_124:
      return zoomWindow1;
    }

    public void Click(System.Drawing.Point coordinates, bool leftClick = true, bool moveMouse = true, int millisecondDelay = 0)
    {
      WindowHelper.ForceForeground(this.Handle);
label_1:
      int num1 = -1411976798;
      object windowLocker;
      while (true)
      {
        int num2 = -768873664;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            windowLocker = ZoomWindow.windowLocker;
            num1 = (int) num3 * -1684010943 ^ 455107409;
            continue;
          case 2:
            ZoomWindow.\u200B⁯⁪‫‏‮⁬‭⁫‍‬‭⁮‎⁫‬‏⁭‮⁫​‎⁮‫‭‪‌‬⁮​⁭‌‭⁯‌‌⁮‭‎⁭‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(970554587U), (object) this.ZoomWindowType, (object) coordinates.ToString());
            num1 = (int) num3 * -31708253 ^ -1379238433;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag1 = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag1);
label_7:
        int num2 = -669711882;
        while (true)
        {
          int num3 = -768873664;
          uint num4;
          bool flag2;
          IntPtr num5;
          IntPtr owner;
          bool flag3;
          Rectangle windowRectangle1;
          switch ((num4 = (uint) (num2 ^ num3)) % 20U)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_31;
            case 2:
              NativeMethods.PostMessageSafe(this.Handle, 513U, 1, NativeMethods.MAKELPARAM(coordinates.X, coordinates.Y));
              num2 = (int) num4 * 1075649664 ^ 1165274079;
              continue;
            case 3:
              num2 = -1599618146;
              continue;
            case 4:
              Thread.Sleep(100);
              NativeMethods.PostMessageSafe(this.Handle, 514U, 0, NativeMethods.MAKELPARAM(coordinates.X, coordinates.Y));
              num2 = (int) num4 * 1204807762 ^ -1702540821;
              continue;
            case 5:
              int num6 = flag3 ? 1444652516 : (num6 = 1655810206);
              int num7 = (int) num4 * 2034132080;
              num2 = num6 ^ num7;
              continue;
            case 6:
              num2 = -2128681591;
              continue;
            case 7:
              num2 = (int) num4 * -1240112205 ^ 1179243217;
              continue;
            case 8:
              flag2 = !moveMouse;
              num2 = (int) num4 * -396987481 ^ -863122347;
              continue;
            case 9:
              owner = this.Owner;
              num2 = (int) num4 * -1697261763 ^ -708219336;
              continue;
            case 10:
              num5 = this.Owner;
              Rectangle windowRectangle2 = WindowHelper.GetWindowRectangle(this.Owner);
              coordinates = new System.Drawing.Point(windowRectangle1.X - windowRectangle2.X + windowRectangle2.X + coordinates.X, windowRectangle1.Y - windowRectangle2.Y + windowRectangle2.Y + coordinates.Y);
              MouseHelper.ClickScreenPosition(num5, coordinates.X, coordinates.Y, leftClick, millisecondDelay);
              num2 = (int) num4 * 2122887758 ^ 343189147;
              continue;
            case 11:
              num2 = (int) num4 * -340029122 ^ 84949252;
              continue;
            case 12:
              windowRectangle1 = WindowHelper.GetWindowRectangle(num5);
              num2 = (int) num4 * 1541728173 ^ 1724333290;
              continue;
            case 13:
              flag3 = !owner.Equals((object) this.Handle);
              num2 = (int) num4 * 863472107 ^ -172580130;
              continue;
            case 14:
              num2 = -1959565773;
              continue;
            case 15:
              num2 = (int) num4 * 1206738587 ^ 1271064954;
              continue;
            case 16:
              num5 = this.Handle;
              num2 = -1696833291;
              continue;
            case 17:
              int num8 = !flag2 ? -1529814122 : (num8 = -995340488);
              int num9 = (int) num4 * -1114809850;
              num2 = num8 ^ num9;
              continue;
            case 18:
              num2 = (int) num4 * 1015406385 ^ -548267586;
              continue;
            case 19:
              MouseHelper.ClickWindowPosition(num5, coordinates.X, coordinates.Y, leftClick, millisecondDelay, true);
              num2 = (int) num4 * -261217395 ^ -1144113112;
              continue;
            default:
              goto label_27;
          }
        }
label_27:
        return;
label_31:;
      }
      finally
      {
        if (flag1)
        {
label_29:
          int num2 = -365601019;
          while (true)
          {
            int num3 = -768873664;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_29;
              case 1:
                Monitor.Exit(windowLocker);
                num2 = (int) num4 * -1953691584 ^ 1662596594;
                continue;
              case 2:
                num2 = (int) num4 * 1002085676 ^ 1491013511;
                continue;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
    }

    private void SaveWindowBitmap(string filePath, bool spawnProcess = false)
    {
label_1:
      int num1 = -964289326;
      while (true)
      {
        int num2 = -215656568;
        uint num3;
        string str;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            flag = !ZoomWindow.\u206A⁫‭‬‪‏⁯⁯‬​‌⁬⁫⁬‍‬​‫⁯‏⁮⁭‮‭⁯‍‏‮‮‏​⁪‫‮‏‫‏‮‏‬‮(str);
            num1 = (int) num3 * 1862142120 ^ -774836099;
            continue;
          case 1:
            ZoomWindow.\u202E⁭‬⁯⁫​⁮⁮‍‪‏⁫⁯​⁬‏‫‪⁭⁬‏​⁯‪⁫⁪‪‬‎‏‪‪⁪⁫‫⁪‎⁮‍⁯‮(str);
            num1 = (int) num3 * 467819958 ^ -92165559;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num4 = !flag ? -2054764611 : (num4 = -2104148071);
            int num5 = (int) num3 * 1338565725;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * 979765190 ^ -646210230;
            continue;
          case 6:
            str = ZoomWindow.\u206D​‭‮‌‍⁪‎‍​‌‫⁭‏‫​‍‫‪‏‪‏​‮‭‭‏⁫⁬⁪‎‌⁮‫⁮⁯‏‮‪⁯‮(filePath);
            num1 = (int) num3 * 1572966114 ^ -1071499226;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      Bitmap windowAsBitmap = this.GetWindowAsBitmap();
      try
      {
        ZoomWindow.\u206D⁫‪⁯​⁮⁬‮⁯⁫‎‎‪‎⁬‎⁪‫‌‮‍⁬‫⁭⁭⁮⁪‏‭‮⁮‬⁪⁫​⁮‫⁭‎⁬‮((Image) windowAsBitmap, filePath);
      }
      finally
      {
        if (windowAsBitmap != null)
        {
label_11:
          int num2 = -600682927;
          while (true)
          {
            int num3 = -215656568;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 2084276597 ^ -170881406;
                continue;
              case 1:
                ZoomWindow.\u200F‬‌‌⁬⁮‭⁪⁪⁭⁬​‫‮‮‎⁭‮‍‏‮‎​⁭‌⁭⁪⁪‏⁮‫‭‭‭⁯⁮‫‍‍‮‮((IDisposable) windowAsBitmap);
                num2 = (int) num4 * 295068735 ^ -1977598549;
                continue;
              case 3:
                goto label_11;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
      bool flag1 = spawnProcess;
label_18:
      int num6 = -1292554510;
      while (true)
      {
        int num2 = -215656568;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 5U)
        {
          case 0:
            num6 = (int) num3 * 85587364 ^ 2012936829;
            continue;
          case 1:
            int num4 = flag1 ? -904642873 : (num4 = -1735672877);
            int num5 = (int) num3 * -1431348141;
            num6 = num4 ^ num5;
            continue;
          case 2:
            goto label_20;
          case 3:
            goto label_18;
          case 4:
            ZoomWindow.\u200E‌‪⁬⁪‭⁫⁪‫⁭⁫‪‮‫‍‏‏‪‌‫‪‮‌‏‭⁭‪⁬⁪‬​‬⁯⁬⁭‭⁯⁬‏⁭‮(filePath);
            num6 = (int) num3 * 1011791619 ^ -2047409597;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_20:;
    }

    internal Bitmap GetWindowAsBitmap()
    {
      Bitmap bitmap1 = (Bitmap) null;
      try
      {
        Rectangle windowRectangle = WindowHelper.GetWindowRectangle(this.Handle);
        bitmap1 = new Bitmap(windowRectangle.Width, windowRectangle.Height, PixelFormat.Format32bppPArgb);
        Graphics graphics = Graphics.FromImage((Image) bitmap1);
        try
        {
label_3:
          int num1 = 1000973758;
          while (true)
          {
            int num2 = 2008714987;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                graphics.CopyFromScreen(windowRectangle.X, windowRectangle.Y, 0, 0, windowRectangle.Size, CopyPixelOperation.SourceCopy);
                num1 = (int) num3 * -78160516 ^ -1486906041;
                continue;
              case 2:
                goto label_3;
              default:
                goto label_16;
            }
          }
        }
        finally
        {
          if (graphics != null)
          {
label_7:
            int num1 = 1048186921;
            while (true)
            {
              int num2 = 2008714987;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_7;
                case 1:
                  num1 = (int) num3 * -705695848 ^ -2058435476;
                  continue;
                case 2:
                  graphics.Dispose();
                  num1 = (int) num3 * -1335001839 ^ -402538556;
                  continue;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
      }
      catch (Exception ex)
      {
label_13:
        int num1 = 2055469282;
        while (true)
        {
          int num2 = 2008714987;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_13;
            case 2:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * 2015826034 ^ -1431456827;
              continue;
            default:
              goto label_16;
          }
        }
      }
label_16:
      Bitmap bitmap2 = bitmap1;
label_17:
      int num4 = 2102964076;
      while (true)
      {
        int num1 = 2008714987;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_17;
          case 2:
            num4 = (int) num2 * 1272399462 ^ -1880466628;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return bitmap2;
    }

    internal Bitmap GetWindowSectionAsBitmap(int fromTop, int fromLeft, int width, int height)
    {
      Bitmap bitmap1 = (Bitmap) null;
      try
      {
        Rectangle windowRectangle = WindowHelper.GetWindowRectangle(this.Handle);
        bitmap1 = ZoomWindow.\u200F‫⁪‬⁮⁫‍‬⁮⁯‭⁯‍​‬‮‍‮‭‎‫‌‫⁪⁬⁪‮‍‎⁬‭⁬⁮⁮‪‪⁯‪⁯⁪‮(width, height, PixelFormat.Format32bppPArgb);
        Graphics graphics = ZoomWindow.\u206E‬‍‎⁮‏‮⁭‮‪⁪⁭‎⁬⁮‭‪‏⁪‪‍‬‏⁭‎⁮‪‎‬‮⁬⁯‏⁪⁬⁮‎‌‍‌‮((Image) bitmap1);
        try
        {
label_3:
          int num1 = 1688726259;
          while (true)
          {
            int num2 = 799836630;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                goto label_3;
              case 1:
                num1 = (int) num3 * 1390251005 ^ 1371553249;
                continue;
              case 2:
                graphics.CopyFromScreen(windowRectangle.X + fromLeft, windowRectangle.Y + fromTop, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                num1 = (int) num3 * 1003983264 ^ 1541431317;
                continue;
              case 3:
                num1 = (int) num3 * 2013539742 ^ 183193714;
                continue;
              default:
                goto label_21;
            }
          }
        }
        finally
        {
          if (graphics != null)
          {
label_9:
            int num1 = 1260799363;
            while (true)
            {
              int num2 = 799836630;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * -1379887792 ^ -6348068;
                  continue;
                case 1:
                  graphics.Dispose();
                  num1 = (int) num3 * 1589616802 ^ 116691540;
                  continue;
                case 3:
                  goto label_9;
                default:
                  goto label_13;
              }
            }
          }
label_13:;
        }
      }
      catch (Exception ex)
      {
label_15:
        int num1 = 723601991;
        while (true)
        {
          int num2 = 799836630;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_15;
            case 2:
              num1 = (int) num3 * 24285765 ^ -1712096627;
              continue;
            case 3:
              num1 = (int) num3 * 1623399187 ^ 299799048;
              continue;
            case 4:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * 274751435 ^ -572698328;
              continue;
            case 5:
              num1 = (int) num3 * -1076640281 ^ -1446952433;
              continue;
            default:
              goto label_21;
          }
        }
      }
label_21:
      Bitmap bitmap2 = bitmap1;
label_22:
      int num4 = 257780992;
      while (true)
      {
        int num1 = 799836630;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 1:
            num4 = (int) num2 * 924152016 ^ 34216912;
            continue;
          case 2:
            goto label_22;
          default:
            goto label_25;
        }
      }
label_25:
      return bitmap2;
    }

    private bool IsPixelColorMatching(int _x, int _y, int _R, int _B, int _G)
    {
      bool flag1 = false;
label_1:
      int num1 = -575867291;
      bool flag2;
      while (true)
      {
        int num2 = -1268944696;
        uint num3;
        NativeMethods.RECT lpRect;
        bool windowRect;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            flag2 = flag1;
            num1 = -1566540197;
            continue;
          case 1:
            num1 = (int) num3 * 1113967428 ^ 1389150796;
            continue;
          case 2:
            flag1 = WindowHelper.IsPixelColorMatching(this.Handle, lpRect.left + _x, lpRect.top + _y, _R, _B, _G);
            num1 = (int) num3 * 1555815368 ^ 1727594009;
            continue;
          case 4:
            goto label_1;
          case 5:
            windowRect = NativeMethods.GetWindowRect(this.Handle, out lpRect);
            num1 = (int) num3 * -644769118 ^ -611544699;
            continue;
          case 6:
            num1 = (int) num3 * 2062443634 ^ -983718242;
            continue;
          case 7:
            int num4 = windowRect ? -598908648 : (num4 = -2095430050);
            int num5 = (int) num3 * 450542170;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return flag2;
    }

    internal void ProcessEvent(ZoomEvent detectedEvent)
    {
      object windowLocker1 = ZoomWindow.windowLocker;
      bool flag1 = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker1, ref flag1);
label_2:
        int num1 = 1528696072;
        while (true)
        {
          int num2 = 1080659330;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              ZoomWindow.WindowEvents.Add(detectedEvent);
              num1 = (int) num3 * -225064498 ^ 522046492;
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
          int num1 = 5327064;
          while (true)
          {
            int num2 = 1080659330;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_8;
              case 2:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker1);
                num1 = (int) num3 * -1979819516 ^ -1791744964;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      ZoomEventType eventType = detectedEvent.EventType;
label_14:
      int num4 = 627843073;
      object windowLocker2;
      while (true)
      {
        int num1 = 1080659330;
        uint num2;
        bool flag2;
        bool flag3;
        ActivityBase activeActivity;
        int num3;
        switch ((num2 = (uint) (num4 ^ num1)) % 18U)
        {
          case 0:
label_36:
            flag2 = this.ZoomWindowType == ZoomWindowType.Meeting;
            num4 = 1562294905;
            continue;
          case 1:
            int num5 = flag2 ? -145564091 : (num5 = -353896965);
            int num6 = (int) num2 * -2051495739;
            num4 = num5 ^ num6;
            continue;
          case 2:
label_18:
            windowLocker2 = ZoomWindow.windowLocker;
            num4 = 342974941;
            continue;
          case 3:
            goto label_99;
          case 4:
            num4 = (int) num2 * -124322710 ^ 1385917693;
            continue;
          case 5:
            switch (eventType)
            {
              case ZoomEventType.Other:
                goto label_98;
              case ZoomEventType.Create:
                goto label_36;
              case ZoomEventType.Destroy:
                goto label_18;
              case ZoomEventType.LocationChanged:
                goto label_59;
              case ZoomEventType.Show:
                goto label_67;
              case ZoomEventType.Reorder:
                goto label_89;
              case ZoomEventType.Focus:
                goto label_87;
              case ZoomEventType.MoveSize:
                goto label_92;
              case ZoomEventType.Hide:
                goto label_100;
              case ZoomEventType.StateChange:
                goto label_79;
              case ZoomEventType.NameChange:
                goto label_72;
              case ZoomEventType.ValueChange:
                goto label_54;
              case ZoomEventType.DescriptionChange:
                goto label_21;
              case ZoomEventType.ObjectEnd:
                goto label_16;
              case ZoomEventType.Invoked:
                goto label_6;
              case ZoomEventType.Undefined:
                goto label_102;
              default:
                num4 = (int) num2 * 2083365190 ^ 976086831;
                continue;
            }
          case 6:
            goto label_97;
          case 7:
            activeActivity = this.Engine.ActiveActivity;
            if (activeActivity != null)
            {
              num4 = (int) num2 * 496184984 ^ -1581219014;
              continue;
            }
            num3 = 0;
            break;
          case 8:
            num4 = (int) num2 * 1247157470 ^ 877015991;
            continue;
          case 9:
            WindowHelper.CloseWindowByCommand(this.Handle);
            num4 = (int) num2 * 1661050287 ^ -447789290;
            continue;
          case 10:
            int num7 = !flag3 ? -1741684990 : (num7 = -586621446);
            int num8 = (int) num2 * -1959617645;
            num4 = num7 ^ num8;
            continue;
          case 11:
            goto label_24;
          case 12:
            num4 = 1711618524;
            continue;
          case 14:
            num3 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(activeActivity.Name, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(935807808U)) ? 1 : 0;
            break;
          case 15:
            NativeMethods.DestroyWindow(this.Handle);
            num4 = (int) num2 * -1805451363 ^ -2077204442;
            continue;
          case 16:
            goto label_14;
          case 17:
            num4 = (int) num2 * -1276192368 ^ 30777840;
            continue;
          default:
            goto label_37;
        }
        flag3 = num3 != 0;
        num4 = 169914068;
      }
label_24:
      return;
label_97:
      return;
label_99:
      return;
label_79:
      return;
label_72:
      return;
label_89:
      return;
label_87:
      return;
label_16:
      return;
label_6:
      return;
label_54:
      return;
label_21:
      return;
label_98:
      return;
label_102:
      return;
label_37:
      bool flag4 = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker2, ref flag4);
label_39:
        int num1 = 300209053;
        while (true)
        {
          int num2 = 1080659330;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.isVisible = false;
              num1 = (int) num3 * -2079064597 ^ -775471829;
              continue;
            case 1:
              goto label_96;
            case 2:
              goto label_39;
            case 3:
              num1 = (int) num3 * -1838712381 ^ 2049586067;
              continue;
            default:
              goto label_93;
          }
        }
label_93:
        return;
label_96:
        return;
      }
      finally
      {
        if (flag4)
        {
label_46:
          int num1 = 1367066764;
          while (true)
          {
            int num2 = 1080659330;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_46;
              case 1:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker2);
                num1 = (int) num3 * -1429673203 ^ -1040746613;
                continue;
              default:
                goto label_50;
            }
          }
        }
label_50:;
      }
label_53:
      int num9;
      while (true)
      {
        int num1 = 1080659330;
        uint num2;
        bool flag2;
        int num3;
        switch ((num2 = (uint) (num9 ^ num1)) % 11U)
        {
          case 0:
            num3 = ZoomZoom.Properties.Settings.Default._App_DestroyVideoWindows ? 1 : 0;
            break;
          case 2:
            num9 = (int) num2 * -178746912 ^ 547756134;
            continue;
          case 3:
            goto label_59;
          case 4:
            goto label_67;
          case 5:
            if (this.ZoomWindowType != ZoomWindowType.Video)
            {
              num3 = 0;
              break;
            }
            num9 = (int) num2 * -1961971803 ^ 955592282;
            continue;
          case 6:
            goto label_91;
          case 7:
            num9 = (int) num2 * -244851103 ^ 1183407789;
            continue;
          case 8:
            num9 = (int) num2 * -1578992506 ^ -815364685;
            continue;
          case 9:
            num9 = 232118131;
            continue;
          case 10:
            if (flag2)
            {
              num9 = (int) num2 * 1703337094 ^ -1421372867;
              continue;
            }
            goto label_48;
          default:
            goto label_68;
        }
        flag2 = num3 != 0;
        num9 = 1877133643;
      }
label_91:
      return;
label_48:
      return;
label_68:
      object windowLocker3 = ZoomWindow.windowLocker;
      bool flag5 = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker3, ref flag5);
label_70:
        int num1 = 1514774001;
        while (true)
        {
          int num2 = 1080659330;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 610191827 ^ -360163425;
              continue;
            case 2:
              goto label_70;
            case 3:
              this.WindowInspected = DateTime.MinValue;
              num1 = (int) num3 * 1986420956 ^ 1231833950;
              continue;
            default:
              goto label_83;
          }
        }
      }
      finally
      {
        if (flag5)
        {
label_77:
          int num1 = 2093052816;
          while (true)
          {
            int num2 = 1080659330;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * 289532784 ^ -2005225910;
                continue;
              case 2:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker3);
                num1 = (int) num3 * -629157138 ^ 678860739;
                continue;
              case 3:
                goto label_77;
              default:
                goto label_82;
            }
          }
        }
label_82:;
      }
label_83:
      goto label_84;
label_59:
      this.RefreshLocation();
      num9 = 604303472;
      goto label_53;
label_67:
      this.RefreshLocation();
      num9 = 1304817237;
      goto label_53;
label_84:
      int num10 = 799345802;
label_85:
      while (true)
      {
        int num1 = 1080659330;
        uint num2;
        switch ((num2 = (uint) (num10 ^ num1)) % 17U)
        {
          case 0:
            goto label_101;
          case 1:
            goto label_90;
          case 2:
            goto label_88;
          case 3:
            goto label_86;
          case 4:
            goto label_75;
          case 5:
            goto label_61;
          case 6:
            goto label_51;
          case 7:
            goto label_44;
          case 8:
            goto label_84;
          case 9:
            goto label_41;
          case 10:
            goto label_20;
          case 11:
            goto label_10;
          case 12:
            num10 = (int) num2 * 1708838972 ^ -1886179137;
            continue;
          case 13:
            num10 = (int) num2 * -1477898409 ^ -1949560876;
            continue;
          case 14:
            goto label_92;
          case 15:
            goto label_100;
          case 16:
            goto label_4;
          default:
            goto label_103;
        }
      }
label_20:
      return;
label_41:
      return;
label_44:
      return;
label_103:
      return;
label_4:
      return;
label_10:
      return;
label_51:
      return;
label_88:
      return;
label_90:
      return;
label_101:
      return;
label_61:
      return;
label_75:
      return;
label_86:
      return;
label_92:
      this.RefreshLocation();
      num10 = 973376981;
      goto label_85;
label_100:
      this.RefreshLocation();
      num10 = 264960651;
      goto label_85;
    }

    public void Activate()
    {
      if (!(this.Handle == NativeMethods.GetForegroundWindow()))
        goto label_3;
label_1:
      int num1 = -1976423053;
label_2:
      int num2 = -377670871;
      uint num3;
      object windowLocker;
      switch ((num3 = (uint) (num1 ^ num2)) % 4U)
      {
        case 0:
          goto label_1;
        case 2:
          return;
        case 3:
          break;
        default:
          bool flag = false;
          try
          {
            ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_6:
            int num4 = -1669769938;
            while (true)
            {
              int num5 = -377670871;
              uint num6;
              IntPtr windowThreadProcessId1;
              IntPtr windowThreadProcessId2;
              switch ((num6 = (uint) (num4 ^ num5)) % 17U)
              {
                case 0:
                  NativeMethods.AttachThreadInput(windowThreadProcessId1, windowThreadProcessId2, 1);
                  num4 = (int) num6 * -763483340 ^ -549321696;
                  continue;
                case 1:
                  num4 = (int) num6 * -448794788 ^ -1285417545;
                  continue;
                case 2:
                  int num7;
                  num4 = num7 = !NativeMethods.IsIconic(this.Handle) ? -756418197 : (num7 = -786907716);
                  continue;
                case 3:
                  NativeMethods.SetForegroundWindow(this.Handle);
                  num4 = -614475564;
                  continue;
                case 4:
                  goto label_24;
                case 5:
                  NativeMethods.SetForegroundWindow(this.Handle);
                  NativeMethods.AttachThreadInput(windowThreadProcessId1, windowThreadProcessId2, 0);
                  num4 = (int) num6 * -296507407 ^ 261826974;
                  continue;
                case 6:
                  NativeMethods.ShowWindowAsync(this.Handle, 9);
                  num4 = (int) num6 * -641500503 ^ 278180266;
                  continue;
                case 7:
                  NativeMethods.ShowWindowAsync(this.Handle, 1);
                  num4 = (int) num6 * -130770867 ^ -414991762;
                  continue;
                case 8:
                  num4 = (int) num6 * 1679872761 ^ -281706298;
                  continue;
                case 9:
                  num4 = (int) num6 * 742282419 ^ -1324385890;
                  continue;
                case 10:
                  windowThreadProcessId2 = NativeMethods.GetWindowThreadProcessId(this.Handle, IntPtr.Zero);
                  num4 = (int) num6 * 1491416443 ^ 1770387378;
                  continue;
                case 11:
                  num4 = (int) num6 * 324598671 ^ -1942166260;
                  continue;
                case 12:
                  goto label_6;
                case 13:
                  num4 = -1008567986;
                  continue;
                case 14:
                  int num8 = windowThreadProcessId1 != windowThreadProcessId2 ? -1838798986 : (num8 = -1872116265);
                  int num9 = (int) num6 * -1846934955;
                  num4 = num8 ^ num9;
                  continue;
                case 15:
                  windowThreadProcessId1 = NativeMethods.GetWindowThreadProcessId(NativeMethods.GetForegroundWindow(), IntPtr.Zero);
                  num4 = (int) num6 * 941654222 ^ -1060754366;
                  continue;
                case 16:
                  num4 = -1037185196;
                  continue;
                default:
                  goto label_8;
              }
            }
label_8:
            return;
label_24:
            return;
          }
          finally
          {
            if (flag)
            {
label_26:
              int num4 = -1949191578;
              while (true)
              {
                int num5 = -377670871;
                uint num6;
                switch ((num6 = (uint) (num4 ^ num5)) % 3U)
                {
                  case 0:
                    goto label_26;
                  case 1:
                    ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                    num4 = (int) num6 * 1660252474 ^ -2007331251;
                    continue;
                  default:
                    goto label_30;
                }
              }
            }
label_30:;
          }
      }
label_3:
      windowLocker = ZoomWindow.windowLocker;
      num1 = -807322152;
      goto label_2;
    }

    internal void Move(int X, int Y)
    {
label_1:
      int num1 = -598216608;
      while (true)
      {
        int num2 = -1588808836;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            int x = X;
            int y = Y;
            Size size = this.Size;
            int width = size.Width;
            size = this.Size;
            int height = size.Height;
            this.Move(new Rectangle(x, y, width, height));
            num1 = (int) num3 * 500391380 ^ 1672000673;
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

    internal void Move(Rectangle rectangle)
    {
label_1:
      int num1 = 478055414;
      object windowLocker;
      while (true)
      {
        int num2 = 2004389379;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 2:
            windowLocker = ZoomWindow.windowLocker;
            num1 = 883641027;
            continue;
          case 3:
            int num4 = !(rectangle == Rectangle.Empty) ? 1140186315 : (num4 = 1529453589);
            int num5 = (int) num3 * -1783449703;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_18;
          default:
            goto label_5;
        }
      }
label_18:
      return;
label_5:
      bool flag = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag);
label_7:
        int num2 = 314389848;
        while (true)
        {
          int num3 = 2004389379;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = (int) num4 * -260529798 ^ 289168904;
              continue;
            case 1:
              goto label_14;
            case 2:
              goto label_7;
            case 3:
              num2 = (int) num4 * 2067925811 ^ -1495074238;
              continue;
            case 4:
              num2 = (int) num4 * -594493895 ^ 70039040;
              continue;
            case 5:
              WindowHelper.Move(this.Handle, rectangle, true);
              num2 = (int) num4 * -1767366251 ^ 1951719186;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_14:;
      }
      finally
      {
        if (flag)
        {
label_16:
          int num2 = 1136889778;
          while (true)
          {
            int num3 = 2004389379;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -1392630432 ^ 1299346592;
                continue;
              case 1:
                ZoomWindow.\u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮(windowLocker);
                num2 = (int) num4 * 1480054440 ^ 1458112183;
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
    }

    internal void Close(bool ignoreActiveActivity = false, [CallerMemberName] string callingMethod = "")
    {
label_1:
      int num1 = -297797784;
      object windowLocker;
      bool flag1;
      while (true)
      {
        int num2 = -757835086;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            if (this.Engine.ActiveActivity != null)
            {
              num1 = (int) num3 * -295333273 ^ 587065308;
              continue;
            }
            break;
          case 1:
            num1 = (int) num3 * -1664746101 ^ 1057211939;
            continue;
          case 2:
            int num5 = flag2 ? -80540492 : (num5 = -65958932);
            int num6 = (int) num3 * -807449882;
            num1 = num5 ^ num6;
            continue;
          case 3:
            goto label_61;
          case 4:
            windowLocker = ZoomWindow.windowLocker;
            num1 = -1883098962;
            continue;
          case 5:
            flag1 = false;
            if (!ignoreActiveActivity)
            {
              num1 = (int) num3 * -1330764053 ^ 427645166;
              continue;
            }
            break;
          case 7:
            goto label_1;
          case 8:
            num4 = this.Engine.ActiveActivity is FindButtons ? 1 : 0;
            goto label_12;
          default:
            goto label_13;
        }
        num4 = 0;
label_12:
        flag2 = num4 != 0;
        num1 = -777211749;
      }
label_61:
      return;
label_13:
      bool flag3 = false;
      try
      {
        ZoomWindow.\u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮(windowLocker, ref flag3);
label_15:
        int num2 = -71799791;
        List<IntPtr> visibleWindowHandles;
        while (true)
        {
          int num3 = -757835086;
          uint num4;
          IntPtr window;
          bool flag2;
          ZoomWindowType zoomWindowType;
          switch ((num4 = (uint) (num2 ^ num3)) % 18U)
          {
            case 0:
              zoomWindowType = this.ZoomWindowType;
              num2 = (int) num4 * 2133606538 ^ 1692730733;
              continue;
            case 1:
              switch (zoomWindowType)
              {
                case ZoomWindowType.Undefined:
                case ZoomWindowType.ZoomZoomMain:
                case ZoomWindowType.Join:
                case ZoomWindowType.Chat:
                case ZoomWindowType.Participants:
                case ZoomWindowType.Notification:
                case ZoomWindowType.Video:
                case ZoomWindowType.Container:
                case ZoomWindowType.Other:
                case ZoomWindowType.InvalidMeeting:
                case ZoomWindowType.ManyCamBroadcast:
                case ZoomWindowType.JoinAudio:
                case ZoomWindowType.Settings:
                case ZoomWindowType.Invite:
                case ZoomWindowType.ScreenSharingDisabled:
                case ZoomWindowType.AudioNotification:
                case ZoomWindowType.AudioError:
                case ZoomWindowType.AudioMenu:
                case ZoomWindowType.Sharing:
                case ZoomWindowType.Locked:
                case ZoomWindowType.Full:
                  goto label_60;
                case ZoomWindowType.AccountPanel:
                  goto label_49;
                case ZoomWindowType.Meeting:
                case ZoomWindowType.DualVideo:
                case ZoomWindowType.MeetingButtonBar:
                  goto label_53;
                case ZoomWindowType.WaitingForHost:
                  goto label_27;
                case ZoomWindowType.LeaveCurrent:
                  goto label_47;
                case ZoomWindowType.RequestRecord:
                  goto label_26;
                case ZoomWindowType.EndMeeting:
                  goto label_51;
                default:
                  num2 = (int) num4 * -59239651 ^ -909923204;
                  continue;
              }
            case 2:
              goto label_15;
            case 3:
              num2 = (int) num4 * -863010212 ^ -1633184286;
              continue;
            case 4:
              int num5 = flag2 ? -1172715199 : (num5 = -1059783420);
              int num6 = (int) num4 * 424112987;
              num2 = num5 ^ num6;
              continue;
            case 5:
label_27:
              WindowHelper.CloseWindowByCommand(this.Handle);
              num2 = -1225670058;
              continue;
            case 6:
              window = WindowHelper.FindWindow(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(253324373U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1270036652U), 1000);
              flag2 = !window.Equals((object) new IntPtr(0));
              num2 = (int) num4 * -165683180 ^ -1675521280;
              continue;
            case 7:
              num2 = (int) num4 * -1886560318 ^ -1641856463;
              continue;
            case 8:
              goto label_29;
            case 9:
              goto label_49;
            case 10:
              visibleWindowHandles = WindowManager.GetVisibleWindowHandles(this.ProcessId);
              num2 = -576341736;
              continue;
            case 11:
              ZoomWindow.\u206A‌⁫‭⁭⁬⁯‏⁫‏‌‏‏‬⁯‫‫⁭‬‏⁬⁪‪‪⁫‎‬⁫⁫‏‏‌⁭‪⁬‌⁫​‬⁫‮(50);
              num2 = (int) num4 * 844351603 ^ -2063517516;
              continue;
            case 13:
              MouseHelper.ClickWindowPosition(window, 240, 130, true, 0, true);
              num2 = (int) num4 * -523623953 ^ -703324562;
              continue;
            case 14:
label_26:
              MouseHelper.ClickWindowPosition(this.Handle, 300, 150, true, 40, true);
              num2 = -1288801469;
              continue;
            case 15:
              ZoomWindow.\u202C‌‫⁭⁫​⁯⁮⁯‬‮⁭‍‫‫⁭‍⁭‬⁮‬‌⁭‪‬​⁮‭​⁫‭‭⁯⁭‌⁮‎⁭‌‮‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3494768303U), (object) this.ZoomWindowType, (object) this.Handle, (object) callingMethod);
              num2 = (int) num4 * -403406919 ^ 467911535;
              continue;
            case 16:
              Engine instance = Engine.Instance;
              num2 = (int) num4 * 879940808 ^ 287960682;
              continue;
            case 17:
              goto label_60;
            default:
              goto label_32;
          }
        }
label_29:
        WindowHelper.CloseWindowByCommand(this.Handle);
        goto label_49;
label_32:
        using (List<IntPtr>.Enumerator enumerator = visibleWindowHandles.GetEnumerator())
        {
label_37:
          int num3 = !enumerator.MoveNext() ? -1875146661 : (num3 = -688029947);
          while (true)
          {
            int num4 = -757835086;
            uint num5;
            IntPtr current;
            bool flag2;
            switch ((num5 = (uint) (num3 ^ num4)) % 9U)
            {
              case 0:
                MouseHelper.ClickWindowPosition(current, 240, 125, true, 0, true);
                num3 = (int) num5 * -1211424629 ^ 1853759123;
                continue;
              case 1:
                current = enumerator.Current;
                num3 = -1755796177;
                continue;
              case 2:
                goto label_37;
              case 3:
                num3 = -688029947;
                continue;
              case 5:
                int num6 = !flag2 ? -286067833 : (num6 = -1620923521);
                int num7 = (int) num5 * -1250646676;
                num3 = num6 ^ num7;
                continue;
              case 6:
                num3 = (int) num5 * 1789029217 ^ 1220627595;
                continue;
              case 7:
                flag2 = WindowHelper.GetWindowTitle(current).Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3051770926U));
                num3 = (int) num5 * -983549451 ^ 201648020;
                continue;
              case 8:
                num3 = -414302338;
                continue;
              default:
                goto label_44;
            }
          }
        }
label_44:
label_45:
        int num8 = -2068619409;
label_46:
        ZoomWindow window1;
        while (true)
        {
          int num3 = -757835086;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num8 ^ num3)) % 17U)
          {
            case 0:
              flag1 = true;
              num8 = (int) num4 * 1307078493 ^ 1175009871;
              continue;
            case 1:
              IntPtr handle = this.Handle;
              Size size = this.Size;
              int iButtonX = size.Width - 138;
              size = this.Size;
              int iButtonY = size.Height - 16;
              int num5 = 1;
              int millisecondDelay = 0;
              int num6 = 1;
              MouseHelper.ClickWindowPosition(handle, iButtonX, iButtonY, num5 != 0, millisecondDelay, num6 != 0);
              num8 = -1847008127;
              continue;
            case 2:
              goto label_53;
            case 3:
              num8 = (int) num4 * 1672097095 ^ -1684549243;
              continue;
            case 4:
              goto label_47;
            case 5:
              num8 = (int) num4 * -1171176586 ^ 1002332567;
              continue;
            case 6:
              goto label_51;
            case 7:
            case 9:
            case 11:
              goto label_49;
            case 8:
              goto label_60;
            case 10:
              flag2 = window1 != null;
              num8 = (int) num4 * -1239311046 ^ -1120079003;
              continue;
            case 12:
              goto label_45;
            case 13:
              int num7 = flag2 ? -65488075 : (num7 = -81971146);
              int num9 = (int) num4 * 1080672426;
              num8 = num7 ^ num9;
              continue;
            case 14:
              window1.Close(false, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2455209461U));
              num8 = (int) num4 * 438894180 ^ 1705073812;
              continue;
            case 16:
              num8 = (int) num4 * -583159866 ^ -1097358903;
              continue;
            default:
              goto label_69;
          }
        }
label_47:
        window1 = this.Engine.GetWindow(ZoomWindowType.Join);
        num8 = -49836558;
        goto label_46;
label_49:
        num8 = -1423226058;
        goto label_46;
label_51:
        MouseHelper.ClickWindowPosition(this.Handle, 330, 145, true, 0, true);
        num8 = -1847008127;
        goto label_46;
label_53:
        CoreUtils.LogStackTrace(5);
        num8 = -1589518865;
        goto label_46;
label_60:
        flag1 = true;
        num8 = -1754368061;
        goto label_46;
      }
      finally
      {
        if (flag3)
        {
label_63:
          int num2 = -159980113;
          while (true)
          {
            int num3 = -757835086;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Monitor.Exit(windowLocker);
                num2 = (int) num4 * -941262090 ^ -1361935929;
                continue;
              case 2:
                goto label_63;
              case 3:
                num2 = (int) num4 * -134062206 ^ -538405072;
                continue;
              default:
                goto label_68;
            }
          }
        }
label_68:;
      }
label_69:
      if (!flag1)
        return;
label_70:
      int num10 = -1866525804;
      while (true)
      {
        int num2 = -757835086;
        uint num3;
        switch ((num3 = (uint) (num10 ^ num2)) % 4U)
        {
          case 0:
            goto label_70;
          case 1:
            goto label_65;
          case 2:
            WindowHelper.CloseWindowByCommand(this.Handle);
            this.Refresh(false, false);
            num10 = (int) num3 * 696338957 ^ -615005485;
            continue;
          case 3:
            num10 = (int) num3 * -698753112 ^ 753569127;
            continue;
          default:
            goto label_58;
        }
      }
label_58:
      return;
label_65:;
    }

    public bool SetWindowTypes(bool refresh = true)
    {
      if (ZoomWindow.window == null)
        goto label_31;
label_1:
      int num1 = -1156241308;
label_2:
      List<IntPtr> childWindows;
      while (true)
      {
        int num2 = -611498231;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        bool flag8;
        bool flag9;
        bool flag10;
        bool flag11;
        bool flag12;
        bool flag13;
        bool flag14;
        bool flag15;
        bool flag16;
        int num4;
        int num5;
        int num6;
        int num7;
        int num8;
        int num9;
        int num10;
        int num11;
        int num12;
        int num13;
        int num14;
        int num15;
        int num16;
        int num17;
        switch ((num3 = (uint) (num1 ^ num2)) % 141U)
        {
          case 0:
            num1 = (int) num3 * -1638635742 ^ 458040366;
            continue;
          case 1:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.RequestRecord);
            num1 = (int) num3 * 940741296 ^ -491046418;
            continue;
          case 2:
            int num18;
            num1 = num18 = !ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(13115801U)) ? -1788312335 : (num18 = -119513627);
            continue;
          case 3:
            this.title = WindowHelper.GetWindowTitle(this.Handle);
            num1 = (int) num3 * -149831057 ^ 51421336;
            continue;
          case 4:
            int num19 = !flag4 ? -1381260663 : (num19 = -1987532984);
            int num20 = (int) num3 * -457902538;
            num1 = num19 ^ num20;
            continue;
          case 5:
          case 13:
          case 15:
          case 18:
          case 27:
          case 34:
          case 35:
          case 40:
          case 68:
          case 71:
          case 75:
          case 85:
          case 89:
          case 93:
          case 97:
          case 118:
          case 120:
          case (uint) sbyte.MaxValue:
          case 135:
            goto label_338;
          case 6:
            num1 = (int) num3 * 978868896 ^ 1254312695;
            continue;
          case 7:
            num1 = (int) num3 * 1319205224 ^ -61816375;
            continue;
          case 8:
            num1 = (int) num3 * -1571558863 ^ 1489649644;
            continue;
          case 9:
            int num21 = !flag15 ? 908506787 : (num21 = 123766737);
            int num22 = (int) num3 * 1819243132;
            num1 = num21 ^ num22;
            continue;
          case 10:
            num1 = (int) num3 * -765821510 ^ 638857343;
            continue;
          case 11:
            num1 = (int) num3 * -1585824702 ^ 1116013439;
            continue;
          case 12:
            if (!ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(132875343U)))
            {
              num4 = 0;
              break;
            }
            num1 = -1751447792;
            continue;
          case 14:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Chat);
            num1 = (int) num3 * 1879317473 ^ 1319067806;
            continue;
          case 16:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.Locked);
            num1 = -1411307920;
            continue;
          case 17:
            num1 = (int) num3 * -1339299800 ^ 353194878;
            continue;
          case 19:
            int num23 = flag9 ? -1076989714 : (num23 = -1329590200);
            int num24 = (int) num3 * 613394518;
            num1 = num23 ^ num24;
            continue;
          case 20:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.LeaveCurrent);
            num1 = (int) num3 * 568642330 ^ -2058887527;
            continue;
          case 21:
            if (ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(253324373U)))
            {
              num1 = -299137975;
              continue;
            }
            num5 = 0;
            goto label_96;
          case 22:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.ScreenSharingDisabled);
            num1 = (int) num3 * -503744945 ^ 120144314;
            continue;
          case 23:
            if (ZoomWindow.\u206B​‏‏‬‍⁮‫‎‏‪‮⁯‪⁫‌‬‪‬⁪⁬⁭‮‍⁯‬‭‮⁭⁭‌⁭‍‭⁭⁫​‍⁫‮(this.Title, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(52792283U)))
            {
              num1 = -1272235481;
              continue;
            }
            num6 = 0;
            goto label_142;
          case 24:
            int num25 = !flag10 ? 406466875 : (num25 = 2022761276);
            int num26 = (int) num3 * 1980806237;
            num1 = num25 ^ num26;
            continue;
          case 25:
            goto label_111;
          case 26:
            int num27 = !flag1 ? -932436630 : (num27 = -2019705017);
            int num28 = (int) num3 * -147670168;
            num1 = num27 ^ num28;
            continue;
          case 28:
            int num29 = !flag13 ? 1318806019 : (num29 = 286861899);
            int num30 = (int) num3 * 1051186235;
            num1 = num29 ^ num30;
            continue;
          case 29:
            int num31 = flag12 ? 670210035 : (num31 = 343770711);
            int num32 = (int) num3 * 1220664350;
            num1 = num31 ^ num32;
            continue;
          case 30:
            num1 = (int) num3 * -193036434 ^ -129400518;
            continue;
          case 32:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.DualVideo);
            num1 = (int) num3 * -435395397 ^ -1066380050;
            continue;
          case 33:
            num1 = (int) num3 * -1638046970 ^ -31087696;
            continue;
          case 36:
            if (!ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3598545818U)))
            {
              num7 = 0;
              goto label_48;
            }
            else
            {
              num1 = -1877776710;
              continue;
            }
          case 37:
            num4 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3472476436U)) ? 1 : 0;
            break;
          case 38:
            num1 = (int) num3 * 1715665801 ^ 1761004171;
            continue;
          case 39:
            num1 = (int) num3 * 467516491 ^ 1554562666;
            continue;
          case 41:
            if (!ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1994378595U)))
            {
              num8 = 0;
              goto label_80;
            }
            else
            {
              num1 = -1097396053;
              continue;
            }
          case 42:
            if (ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, ""))
            {
              num1 = -1529161980;
              continue;
            }
            num9 = 0;
            goto label_134;
          case 43:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.ManyCamApp);
            num1 = (int) num3 * 1335490160 ^ -799637614;
            continue;
          case 44:
            num1 = (int) num3 * -1440423697 ^ -217392922;
            continue;
          case 45:
            num1 = (int) num3 * 1245909711 ^ -537801347;
            continue;
          case 46:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.InvalidMeeting);
            num1 = (int) num3 * 936268879 ^ 858816189;
            continue;
          case 47:
            num10 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1286919407U)) ? 1 : 0;
            goto label_19;
          case 48:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Meeting);
            num1 = (int) num3 * 52344250 ^ 1410346202;
            continue;
          case 49:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Settings);
            num1 = (int) num3 * 1544495208 ^ 598263134;
            continue;
          case 50:
            num1 = (int) num3 * -1783841507 ^ 264462953;
            continue;
          case 51:
            num1 = (int) num3 * -1924879990 ^ 1539524726;
            continue;
          case 52:
            num1 = (int) num3 * -825534515 ^ 934217910;
            continue;
          case 53:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Invite);
            num1 = (int) num3 * -2038757531 ^ -970892322;
            continue;
          case 54:
            num1 = (int) num3 * -92535841 ^ 1461981091;
            continue;
          case 55:
            num1 = (int) num3 * -1706879853 ^ -703623616;
            continue;
          case 56:
            flag13 = this.IsPixelColorMatching(245, this.Size.Height - 23, 45, 158, (int) byte.MaxValue);
            num1 = (int) num3 * 1251931332 ^ -1054684076;
            continue;
          case 57:
            goto label_30;
          case 58:
            int num33 = flag6 ? 983482397 : (num33 = 30976464);
            int num34 = (int) num3 * 887609383;
            num1 = num33 ^ num34;
            continue;
          case 59:
            if (ZoomWindow.\u202B‮‏‬⁮⁫‭​‭‭‬‫⁮⁭⁮⁪‪⁮‌‏⁪‏‫‪‭‪⁭⁫‫⁬‪⁮‬‍⁯‫‪⁯⁫‎‮(this.Title, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3505064265U)))
            {
              num11 = 1;
              goto label_10;
            }
            else
            {
              num1 = -1348505408;
              continue;
            }
          case 60:
            num12 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2123696056U)) ? 1 : 0;
            goto label_146;
          case 61:
            num1 = (int) num3 * 732477350 ^ 1238139882;
            continue;
          case 62:
            flag7 = childWindows.Count > 0;
            num1 = (int) num3 * 854544313 ^ -1558137784;
            continue;
          case 63:
            num1 = (int) num3 * -859999767 ^ 1783672732;
            continue;
          case 64:
            num1 = (int) num3 * -1542954881 ^ 1185364231;
            continue;
          case 65:
            int num35 = flag16 ? 537931181 : (num35 = 1153677223);
            int num36 = (int) num3 * -710776935;
            num1 = num35 ^ num36;
            continue;
          case 66:
            num1 = (int) num3 * -1483734110 ^ -783304975;
            continue;
          case 67:
            goto label_1;
          case 69:
            num13 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3244257414U)) ? 1 : 0;
            goto label_25;
          case 70:
            if (ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3217131437U)))
            {
              num1 = -1174226867;
              continue;
            }
            num14 = 0;
            goto label_104;
          case 72:
            num15 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3621412037U)) ? 1 : 0;
            goto label_161;
          case 73:
            if (ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2925676055U)))
            {
              num1 = -2110039121;
              continue;
            }
            num15 = 0;
            goto label_161;
          case 74:
            if (!this.Title.Equals(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2143805729U)))
            {
              num16 = 0;
              goto label_91;
            }
            else
            {
              num1 = -1560316042;
              continue;
            }
          case 76:
            flag6 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(66686753U));
            num1 = -457991670;
            continue;
          case 77:
            flag16 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(925395883U));
            num1 = -1699825041;
            continue;
          case 78:
            num1 = (int) num3 * 492387995 ^ -1214413684;
            continue;
          case 79:
            if (!ZoomWindow.\u206B​‏‏‬‍⁮‫‎‏‪‮⁯‪⁫‌‬‪‬⁪⁬⁭‮‍⁯‬‭‮⁭⁭‌⁭‍‭⁭⁫​‍⁫‮(this.Title, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3740643994U)))
            {
              num13 = 0;
              goto label_25;
            }
            else
            {
              num1 = -1322150748;
              continue;
            }
          case 80:
            if (ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4198233496U)))
            {
              num1 = -1286936360;
              continue;
            }
            num12 = 0;
            goto label_146;
          case 81:
            num1 = (int) num3 * -1687613792 ^ -1483249809;
            continue;
          case 82:
            num1 = (int) num3 * -1697278905 ^ 572845911;
            continue;
          case 83:
            num1 = (int) num3 * 1144298716 ^ -500469164;
            continue;
          case 84:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.ZoomZoomMain);
            num1 = (int) num3 * 2127281082 ^ -978065763;
            continue;
          case 86:
            num1 = (int) num3 * 484187362 ^ -1076992648;
            continue;
          case 87:
            num1 = -2055585280;
            continue;
          case 88:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.ActivityManagerView);
            num1 = (int) num3 * -98983703 ^ 1365391282;
            continue;
          case 90:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.LeaveCurrent);
            num1 = (int) num3 * -1416458425 ^ 1017522671;
            continue;
          case 91:
            num17 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2818305923U)) ? 1 : 0;
            goto label_77;
          case 92:
            num16 = this.ClassName.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1734112013U)) ? 1 : 0;
            goto label_91;
          case 94:
            num1 = (int) num3 * 782662289 ^ 843541773;
            continue;
          case 95:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.JoinAudio);
            num1 = (int) num3 * 2123736075 ^ -766293621;
            continue;
          case 96:
            num1 = (int) num3 * 1764557300 ^ -1633151608;
            continue;
          case 98:
            num1 = (int) num3 * -884564496 ^ 1575265239;
            continue;
          case 99:
            int num37 = flag8 ? 1360322252 : (num37 = 1585695583);
            int num38 = (int) num3 * 43092498;
            num1 = num37 ^ num38;
            continue;
          case 100:
            num6 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(243973990U)) ? 1 : 0;
            goto label_142;
          case 101:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Ignore);
            num1 = (int) num3 * 1994191423 ^ -645980302;
            continue;
          case 102:
            flag9 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(ZoomWindow.\u200B⁬‎⁭‌‭‪‎‮‏‎‏⁬‪⁫⁪⁭‎⁫⁮⁯⁫‏‍⁮‏⁮‏‬‍⁭‎‫⁪‮‪‮‫​⁪‮(this.Title), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(899050727U));
            num1 = -1323617098;
            continue;
          case 103:
            int num39 = !flag11 ? 1159496207 : (num39 = 1599925650);
            int num40 = (int) num3 * 2047453300;
            num1 = num39 ^ num40;
            continue;
          case 104:
            int num41 = !flag14 ? 2101328910 : (num41 = 553453857);
            int num42 = (int) num3 * -561216280;
            num1 = num41 ^ num42;
            continue;
          case 105:
            if (flag7)
            {
              num1 = (int) num3 * -388959115 ^ 332380443;
              continue;
            }
            goto label_227;
          case 106:
            num7 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2061408244U)) ? 1 : 0;
            goto label_48;
          case 107:
            num14 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1736024055U)) ? 1 : 0;
            goto label_104;
          case 108:
            num1 = (int) num3 * -203273372 ^ -1754455169;
            continue;
          case 109:
            num5 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(664371425U)) ? 1 : 0;
            goto label_96;
          case 110:
            num9 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2818305923U)) ? 1 : 0;
            goto label_134;
          case 111:
            int num43 = !flag2 ? 571752810 : (num43 = 848145423);
            int num44 = (int) num3 * 241345280;
            num1 = num43 ^ num44;
            continue;
          case 112:
            if (!ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.Title, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2605038892U)))
            {
              num10 = 0;
              goto label_19;
            }
            else
            {
              num1 = -2128534670;
              continue;
            }
          case 113:
            flag11 = ZoomWindow.\u202B‮‏‬⁮⁫‭​‭‭‬‫⁮⁭⁮⁪‪⁮‌‏⁪‏‫‪‭‪⁭⁫‫⁬‪⁮‬‍⁯‫‪⁯⁫‎‮(this.Title, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3114811986U));
            num1 = -1134412914;
            continue;
          case 114:
            int num45;
            num1 = num45 = !ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3173198458U)) ? -5443529 : (num45 = -1049830467);
            continue;
          case 115:
            flag3 = ZoomWindow.\u206B​‏‏‬‍⁮‫‎‏‪‮⁯‪⁫‌‬‪‬⁪⁬⁭‮‍⁯‬‭‮⁭⁭‌⁭‍‭⁭⁫​‍⁫‮(this.Title, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1230762249U));
            num1 = (int) num3 * -1209354036 ^ 354816758;
            continue;
          case 116:
            childWindows = WindowHelper.GetChildWindows(this.Handle);
            num1 = (int) num3 * 2030623379 ^ -918799055;
            continue;
          case 117:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.AccountPanel);
            num1 = (int) num3 * -1198604523 ^ 635893204;
            continue;
          case 119:
            int num46 = !flag5 ? -1296079063 : (num46 = -923683573);
            int num47 = (int) num3 * 2116192153;
            num1 = num46 ^ num47;
            continue;
          case 121:
            num8 = ZoomWindow.\u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮(this.ClassName, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3791279986U)) ? 1 : 0;
            goto label_80;
          case 122:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.Notification);
            num1 = (int) num3 * 1567091672 ^ 1309386480;
            continue;
          case 123:
            int num48 = flag3 ? 822839075 : (num48 = 453440949);
            int num49 = (int) num3 * -536280688;
            num1 = num48 ^ num49;
            continue;
          case 124:
            this.SaveWindowBitmap(ZoomWindow.\u206A⁮‭⁯‬‭‬‌​⁫‍⁭‬⁮‍​‬​⁫⁬‫⁫​⁮⁪‫⁯⁯‭‭⁯⁫‪‬⁭‫⁬‍‮‭‮((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2143389545U), (object) this.ZoomWindowType, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1942747366U)), false);
            num1 = -1201217162;
            continue;
          case 125:
            num1 = (int) num3 * -118232697 ^ 1072579033;
            continue;
          case 126:
            num11 = ZoomWindow.\u202B‮‏‬⁮⁫‭​‭‭‬‫⁮⁭⁮⁪‪⁮‌‏⁪‏‫‪‭‪⁭⁫‫⁬‪⁮‬‍⁯‫‪⁯⁫‎‮(this.Title, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3278376376U)) ? 1 : 0;
            goto label_10;
          case 128:
            num1 = (int) num3 * -1176179644 ^ -10544816;
            continue;
          case 129:
            num1 = (int) num3 * -1285954455 ^ 1375165012;
            continue;
          case 130:
            if (ZoomWindow.\u202B‮‏‬⁮⁫‭​‭‭‬‫⁮⁭⁮⁪‪⁮‌‏⁪‏‫‪‭‪⁭⁫‫⁬‪⁮‬‍⁯‫‪⁯⁫‎‮(this.Title, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2969996753U)))
            {
              num1 = -40730404;
              continue;
            }
            num17 = 0;
            goto label_77;
          case 131:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Participants);
            num1 = (int) num3 * -705840151 ^ -1327898446;
            continue;
          case 132:
            WindowHelper.ForceForeground(this.Handle);
            flag1 = this.IsPixelColorMatching(398, 57, 51, 51, 51);
            num1 = (int) num3 * 863871992 ^ 1702852168;
            continue;
          case 133:
            num1 = (int) num3 * 1275913219 ^ 2104221970;
            continue;
          case 134:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.ManyCamBroadcast);
            num1 = (int) num3 * 1958009629 ^ -996860030;
            continue;
          case 136:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.JoinAudio);
            num1 = (int) num3 * 1495691701 ^ -1578391304;
            continue;
          case 137:
            num1 = (int) num3 * 1748667873 ^ -45852730;
            continue;
          case 138:
            num1 = (int) num3 * 1943655761 ^ -319193483;
            continue;
          case 139:
            num1 = (int) num3 * -1301842931 ^ -1813759451;
            continue;
          case 140:
            num1 = (int) num3 * -305207895 ^ -454210361;
            continue;
          default:
            goto label_170;
        }
        int num50;
        num1 = num50 = num4 == 0 ? -1869844357 : (num50 = -619129245);
        continue;
label_10:
        flag2 = num11 != 0;
        num1 = -126936777;
        continue;
label_19:
        int num51;
        num1 = num51 = num10 == 0 ? -2081992562 : (num51 = -775575711);
        continue;
label_25:
        flag4 = num13 != 0;
        num1 = -355710577;
        continue;
label_48:
        flag8 = num7 != 0;
        num1 = -395783470;
        continue;
label_77:
        flag5 = num17 != 0;
        num1 = -79949065;
        continue;
label_80:
        int num52;
        num1 = num52 = num8 == 0 ? -1384651077 : (num52 = -2047520364);
        continue;
label_91:
        if (num16 != 0)
        {
          num1 = -1393516876;
          continue;
        }
        goto label_223;
label_96:
        flag10 = num5 != 0;
        num1 = -2020012888;
        continue;
label_104:
        flag12 = num14 != 0;
        num1 = -4206467;
        continue;
label_134:
        flag14 = num9 != 0;
        num1 = -626587095;
        continue;
label_142:
        int num53;
        num1 = num53 = num6 == 0 ? -475167224 : (num53 = -119122012);
        continue;
label_146:
        int num54;
        num1 = num54 = num12 != 0 ? -424377732 : (num54 = -217709108);
        continue;
label_161:
        flag15 = num15 != 0;
        num1 = -1978543399;
      }
label_30:
      int num55 = NativeMethods.IsWindow(this.Handle) ? 1 : 0;
      goto label_32;
label_111:
      this.SetWindowTypes(WindowType.Interface, ZoomWindowType.WaitingForHost);
      goto label_338;
label_170:
      using (List<IntPtr>.Enumerator enumerator = childWindows.GetEnumerator())
      {
label_182:
        int num2 = !enumerator.MoveNext() ? -1152190717 : (num2 = -2005252679);
        while (true)
        {
          int num3 = -611498231;
          uint num4;
          bool flag;
          string windowClass;
          switch ((num4 = (uint) (num2 ^ num3)) % 15U)
          {
            case 0:
              num2 = (int) num4 * 261231975 ^ -226478398;
              continue;
            case 1:
              flag = windowClass.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3386248369U));
              num2 = (int) num4 * 351475109 ^ -984959182;
              continue;
            case 2:
              WindowHelper.GetWindowTitle(this.child);
              num2 = (int) num4 * -115893379 ^ -1769433686;
              continue;
            case 3:
              num2 = -2005252679;
              continue;
            case 4:
              this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Join);
              num2 = (int) num4 * -119191410 ^ -1342210076;
              continue;
            case 5:
              windowClass = WindowHelper.GetWindowClass(this.child);
              num2 = (int) num4 * 1479641341 ^ -969752935;
              continue;
            case 6:
              this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Password);
              num2 = -451530677;
              continue;
            case 7:
              goto label_182;
            case 8:
              num2 = (int) num4 * -1056809877 ^ 1583741893;
              continue;
            case 9:
              int num5 = !flag ? -1257303672 : (num5 = -1884142433);
              int num6 = (int) num4 * 380615439;
              num2 = num5 ^ num6;
              continue;
            case 11:
              num2 = (int) num4 * 1743829442 ^ -360200703;
              continue;
            case 12:
              num2 = (int) num4 * 1202449405 ^ 1352546962;
              continue;
            case 13:
              IntPtr current = enumerator.Current;
              num2 = -1275951092;
              continue;
            case 14:
              num2 = (int) num4 * 487295873 ^ 1708630065;
              continue;
            default:
              goto label_188;
          }
        }
      }
label_188:
      goto label_189;
label_31:
      num55 = 0;
label_32:
      if (num55 != 0)
      {
        num1 = -424238894;
        goto label_2;
      }
      else
        goto label_307;
label_189:
      int num56 = -1806087615;
label_190:
      bool flag17;
      bool flag18;
      while (true)
      {
        int num2 = -611498231;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        System.Drawing.Point location;
        ZoomWindow window;
        bool flag7;
        bool flag8;
        bool flag9;
        bool flag10;
        int num4;
        int num5;
        int num6;
        int num7;
        int num8;
        int num9;
        int num10;
        int num11;
        int num12;
        int num13;
        int num14;
        int num15;
        switch ((num3 = (uint) (num56 ^ num2)) % 121U)
        {
          case 0:
            num4 = this.ClassName.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2906416663U)) ? 1 : 0;
            goto label_244;
          case 1:
            if (!this.Title.Equals(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4282324806U)))
            {
              num5 = 0;
              goto label_263;
            }
            else
            {
              num56 = -1789101730;
              continue;
            }
          case 2:
            num56 = (int) num3 * 1742113352 ^ -2004792174;
            continue;
          case 3:
            num56 = (int) num3 * -212899305 ^ -787832883;
            continue;
          case 4:
            num56 = (int) num3 * 254337104 ^ -2031779396;
            continue;
          case 5:
            num56 = (int) num3 * -321167137 ^ 1644641213;
            continue;
          case 6:
            flag17 = true;
            num56 = -1231470109;
            continue;
          case 7:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.RequestRemoteControl);
            num56 = (int) num3 * 1712419893 ^ -436261357;
            continue;
          case 8:
            num56 = (int) num3 * 115129803 ^ -751263804;
            continue;
          case 9:
            num56 = (int) num3 * -1343782730 ^ -1818194000;
            continue;
          case 10:
            int num16 = !flag4 ? 257796024 : (num16 = 1967317418);
            int num17 = (int) num3 * 1727574042;
            num56 = num16 ^ num17;
            continue;
          case 11:
            flag5 = this.ClassName.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(314209156U));
            num56 = -2143960170;
            continue;
          case 12:
            num56 = (int) num3 * -434128294 ^ 733363614;
            continue;
          case 13:
            goto label_338;
          case 14:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.MeetingViewToggle);
            num56 = (int) num3 * -1466414195 ^ 208599063;
            continue;
          case 15:
            num56 = (int) num3 * -1067704001 ^ 2135042254;
            continue;
          case 16:
            if (this.Title.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(324040722U)))
            {
              num56 = -131361763;
              continue;
            }
            num6 = 0;
            goto label_273;
          case 17:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.ToolTip);
            num56 = (int) num3 * -1604371884 ^ 1575810934;
            continue;
          case 18:
            num56 = (int) num3 * 322803559 ^ 1832889708;
            continue;
          case 19:
            goto label_223;
          case 20:
            num56 = (int) num3 * 1854376997 ^ -1916786215;
            continue;
          case 21:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Join);
            num56 = (int) num3 * 2045377087 ^ -1449163222;
            continue;
          case 22:
            num56 = (int) num3 * -1683703620 ^ -409372172;
            continue;
          case 23:
            num6 = this.ClassName.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3910706586U)) ? 1 : 0;
            goto label_273;
          case 24:
            num56 = (int) num3 * -1815388845 ^ -573544098;
            continue;
          case 25:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Rename);
            num56 = (int) num3 * 461517338 ^ -419445248;
            continue;
          case 26:
            num56 = (int) num3 * -1833287922 ^ -718501772;
            continue;
          case 27:
            flag10 = this.Title.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2485593436U));
            num56 = -1933173526;
            continue;
          case 28:
            num56 = (int) num3 * 789262524 ^ 360236544;
            continue;
          case 29:
            num56 = (int) num3 * -1839458068 ^ 1219247044;
            continue;
          case 30:
            num7 = this.ClassName.Equals(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4199189891U)) ? 1 : 0;
            goto label_289;
          case 31:
            if (this.Title.Equals(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2112735083U)))
            {
              num56 = -19176187;
              continue;
            }
            num8 = 0;
            goto label_310;
          case 32:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.WaitingForHost);
            num56 = (int) num3 * -1938714882 ^ 610342321;
            continue;
          case 33:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.Sharing);
            num56 = (int) num3 * -60213673 ^ -508611770;
            continue;
          case 34:
            num56 = (int) num3 * -1233231747 ^ 1259543025;
            continue;
          case 35:
            num9 = this.ClassName.StartsWith(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1541721634U)) ? 1 : 0;
            goto label_301;
          case 36:
            num5 = this.ClassName.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(609532823U)) ? 1 : 0;
            goto label_263;
          case 37:
            int num18 = !flag5 ? -2024941329 : (num18 = -1131555837);
            int num19 = (int) num3 * -1725917971;
            num56 = num18 ^ num19;
            continue;
          case 38:
            goto label_189;
          case 39:
            num56 = -1030064627;
            continue;
          case 40:
            num10 = this.ClassName.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(24558657U)) ? 1 : 0;
            break;
          case 41:
            this.SetWindowTypes(WindowType.Alert, ZoomWindowType.EndMeeting);
            num56 = (int) num3 * 503196047 ^ 753336540;
            continue;
          case 42:
            if (!this.title.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1141679456U)))
            {
              num11 = 0;
              goto label_260;
            }
            else
            {
              num56 = -1137543200;
              continue;
            }
          case 43:
            num56 = (int) num3 * -201873938 ^ 656256720;
            continue;
          case 44:
            int num20 = flag3 ? -609856982 : (num20 = -189317843);
            int num21 = (int) num3 * -958358387;
            num56 = num20 ^ num21;
            continue;
          case 45:
            num56 = (int) num3 * 1736715 ^ -72457363;
            continue;
          case 46:
            num56 = (int) num3 * -1086112213 ^ -475842276;
            continue;
          case 47:
            if (this.Title.Equals(""))
            {
              num56 = -1257770895;
              continue;
            }
            num7 = 0;
            goto label_289;
          case 48:
            num56 = (int) num3 * -1812904136 ^ 16037500;
            continue;
          case 49:
            int num22 = !flag18 ? 1779287515 : (num22 = 234103181);
            int num23 = (int) num3 * -1021456179;
            num56 = num22 ^ num23;
            continue;
          case 50:
            num8 = this.ClassName.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(725849527U)) ? 1 : 0;
            goto label_310;
          case 51:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.ZoomMenu);
            num56 = (int) num3 * -1605050511 ^ -806473741;
            continue;
          case 52:
            if (this.Title.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3565479813U)))
            {
              num56 = -129576220;
              continue;
            }
            num12 = 0;
            goto label_276;
          case 53:
            num56 = (int) num3 * 595928588 ^ 1100989877;
            continue;
          case 54:
            num56 = (int) num3 * -1105625018 ^ 1092236887;
            continue;
          case 55:
            num56 = (int) num3 * -1783906978 ^ -1326762764;
            continue;
          case 56:
            int num24;
            num56 = num24 = this.Title.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2206430605U)) ? -1573367609 : (num24 = -1521662246);
            continue;
          case 57:
            if (!this.Title.Equals(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4186576330U)))
            {
              num13 = 0;
              goto label_241;
            }
            else
            {
              num56 = -1802700746;
              continue;
            }
          case 58:
            num56 = (int) num3 * 1248817335 ^ -1628726773;
            continue;
          case 59:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.ScreenShareOptions);
            num56 = (int) num3 * -1755039620 ^ 893298578;
            continue;
          case 60:
            num56 = (int) num3 * 71565542 ^ 471385560;
            continue;
          case 61:
            if (!this.Title.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(488046675U)))
            {
              num14 = 0;
              goto label_251;
            }
            else
            {
              num56 = -1000429398;
              continue;
            }
          case 62:
            num56 = -70851028;
            continue;
          case 63:
            int num25 = flag9 ? -2112703327 : (num25 = -573618014);
            int num26 = (int) num3 * -495394529;
            num56 = num25 ^ num26;
            continue;
          case 64:
            num56 = (int) num3 * 1421802499 ^ -60553098;
            continue;
          case 65:
            num56 = (int) num3 * 637999714 ^ 1320527975;
            continue;
          case 66:
            int num27 = !flag2 ? -2127307107 : (num27 = -538049353);
            int num28 = (int) num3 * -1483996493;
            num56 = num27 ^ num28;
            continue;
          case 67:
            this.SetWindowTypes(WindowType.Interface, ZoomWindowType.ImageHistoryView);
            num56 = (int) num3 * -587395843 ^ -25215804;
            continue;
          case 68:
            if (this.Title.Equals(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3366315094U)))
            {
              num56 = -296800792;
              continue;
            }
            num9 = 0;
            goto label_301;
          case 69:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.Video);
            num56 = (int) num3 * 1050978951 ^ 9495572;
            continue;
          case 70:
            num56 = (int) num3 * -1552570002 ^ 1527156198;
            continue;
          case 71:
            goto label_227;
          case 72:
            num56 = (int) num3 * 1199918553 ^ 806830935;
            continue;
          case 73:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.Undefined);
            num56 = -1765210783;
            continue;
          case 74:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.MeetingButtonBar);
            num56 = (int) num3 * -1800678563 ^ -466596675;
            continue;
          case 75:
            int num29 = flag8 ? -1071510023 : (num29 = -340436002);
            int num30 = (int) num3 * 1635532055;
            num56 = num29 ^ num30;
            continue;
          case 76:
            int num31 = !flag7 ? -482965049 : (num31 = -1178498908);
            int num32 = (int) num3 * 1449136425;
            num56 = num31 ^ num32;
            continue;
          case 77:
            num56 = (int) num3 * -21726599 ^ 5833037;
            continue;
          case 78:
            num56 = (int) num3 * 472878038 ^ -1736158385;
            continue;
          case 79:
            num56 = -437017166;
            continue;
          case 80:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.GalleryScrollRight);
            num56 = (int) num3 * -2054507087 ^ 1418124981;
            continue;
          case 81:
            num11 = this.ClassName.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(692135398U)) ? 1 : 0;
            goto label_260;
          case 82:
            if (this.Title.Equals(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4173962769U)))
            {
              num56 = -1107727462;
              continue;
            }
            num10 = 0;
            break;
          case 83:
            flag4 = window != null;
            num56 = (int) num3 * -936015356 ^ 1482911962;
            continue;
          case 84:
            num56 = (int) num3 * -666052061 ^ 101865660;
            continue;
          case 85:
            num56 = (int) num3 * 869229928 ^ 2017257196;
            continue;
          case 86:
            num15 = this.ClassName.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4155520000U)) ? 1 : 0;
            goto label_248;
          case 87:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.SharedContainer);
            num56 = (int) num3 * 2127656070 ^ -1749366214;
            continue;
          case 88:
            window = this.Engine.GetWindow(ZoomWindowType.Meeting);
            num56 = (int) num3 * 1153607183 ^ 1960921539;
            continue;
          case 89:
            num56 = (int) num3 * -1560939388 ^ -1122498304;
            continue;
          case 90:
            num12 = this.ClassName.Equals(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3002750444U)) ? 1 : 0;
            goto label_276;
          case 91:
            if (this.Title.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3565479813U)))
            {
              num56 = -1460976722;
              continue;
            }
            num4 = 0;
            goto label_244;
          case 92:
            goto label_307;
          case 93:
            num56 = (int) num3 * 1729668424 ^ -554630458;
            continue;
          case 94:
            num13 = this.ClassName.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3621412037U)) ? 1 : 0;
            goto label_241;
          case 95:
            num56 = -1718231576;
            continue;
          case 96:
            num14 = this.ClassName.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2081700555U)) ? 1 : 0;
            goto label_251;
          case 97:
            num56 = (int) num3 * -1819597356 ^ -741636085;
            continue;
          case 98:
            this.SetWindowTypes(WindowType.Unknown, ZoomWindowType.Undefined);
            num56 = (int) num3 * -953230510 ^ 1358069450;
            continue;
          case 99:
            num56 = (int) num3 * -728274818 ^ -1023234561;
            continue;
          case 100:
            num56 = (int) num3 * -1800424221 ^ -88611835;
            continue;
          case 101:
            num56 = (int) num3 * 1049365991 ^ 985853940;
            continue;
          case 102:
            location = this.Location;
            num56 = (int) num3 * -474181817 ^ -2014017967;
            continue;
          case 103:
            int num33 = !flag10 ? 529467155 : (num33 = 1756178525);
            int num34 = (int) num3 * 1055783078;
            num56 = num33 ^ num34;
            continue;
          case 104:
            num56 = (int) num3 * 550101357 ^ -71517081;
            continue;
          case 105:
            num56 = (int) num3 * 1668113226 ^ -2124348556;
            continue;
          case 106:
            int num35 = flag6 ? 256180369 : (num35 = 1575829225);
            int num36 = (int) num3 * 370747749;
            num56 = num35 ^ num36;
            continue;
          case 107:
            int num37 = flag1 ? 2143276774 : (num37 = 578419008);
            int num38 = (int) num3 * 1778252378;
            num56 = num37 ^ num38;
            continue;
          case 109:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.GalleryScrollLeft);
            num56 = (int) num3 * -2019209977 ^ -747218653;
            continue;
          case 110:
            num56 = (int) num3 * -369847846 ^ 631140993;
            continue;
          case 111:
            num56 = (int) num3 * -1077365401 ^ -792604646;
            continue;
          case 112:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.GalleryView);
            num56 = (int) num3 * 2021901818 ^ -137606910;
            continue;
          case 113:
            num56 = (int) num3 * 1943147377 ^ -288866252;
            continue;
          case 114:
            this.SetWindowTypes(WindowType.Control, ZoomWindowType.Video);
            num56 = (int) num3 * 4179055 ^ -1194511080;
            continue;
          case 115:
            int x = location.X;
            location = window.Location;
            int num39 = location.X + window.Size.Width / 2;
            int num40 = x > num39 ? 562554527 : (num40 = 288224711);
            int num41 = (int) num3 * -1158190007;
            num56 = num40 ^ num41;
            continue;
          case 116:
            num56 = (int) num3 * 163896391 ^ -1563434787;
            continue;
          case 117:
            if (!this.Title.Equals(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(668575192U)))
            {
              num15 = 0;
              goto label_248;
            }
            else
            {
              num56 = -90161225;
              continue;
            }
          case 118:
            num56 = -665654846;
            continue;
          case 119:
            num56 = (int) num3 * -1529941130 ^ -2060559330;
            continue;
          case 120:
            num56 = (int) num3 * 1596232764 ^ 226218516;
            continue;
          default:
            goto label_346;
        }
        flag3 = num10 != 0;
        num56 = -374555399;
        continue;
label_241:
        flag6 = num13 != 0;
        num56 = -2132812364;
        continue;
label_244:
        int num42;
        num56 = num42 = num4 == 0 ? -27775084 : (num42 = -1329038751);
        continue;
label_248:
        int num43;
        num56 = num43 = num15 == 0 ? -1083496207 : (num43 = -121780532);
        continue;
label_251:
        int num44;
        num56 = num44 = num14 != 0 ? -147361937 : (num44 = -549708340);
        continue;
label_260:
        flag7 = num11 != 0;
        num56 = -49127317;
        continue;
label_263:
        int num45;
        num56 = num45 = num5 != 0 ? -1778940964 : (num45 = -663377659);
        continue;
label_273:
        flag8 = num6 != 0;
        num56 = -53677443;
        continue;
label_276:
        int num46;
        num56 = num46 = num12 == 0 ? -1866090800 : (num46 = -97949845);
        continue;
label_289:
        flag9 = num7 != 0;
        num56 = -50727059;
        continue;
label_301:
        flag2 = num9 != 0;
        num56 = -1730044275;
        continue;
label_310:
        flag1 = num8 != 0;
        num56 = -732373796;
      }
label_346:
      return flag17;
label_223:
      flag18 = this.Title.StartsWith(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4121511514U));
      num56 = -634153385;
      goto label_190;
label_227:
      num56 = -2144268037;
      goto label_190;
label_307:
      this.SetWindowTypes(WindowType.Invalid, ZoomWindowType.Undefined);
      num56 = -509351540;
      goto label_190;
label_338:
      num56 = -509351540;
      goto label_190;
    }

    static void \u200C‬‌⁭‍‏‭​‮⁮‏‏⁯‫⁬‏‮⁭‍‬⁭‭‬⁬‏‫‬‮‌⁭‎‮⁯⁫‪⁫⁪⁭‮⁮‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200D⁮‎⁯‪⁬‌⁮‪​‎⁬‏‬‭‏⁭⁮‬‍‍‮⁮‫‎‏⁭​‏​⁫‮‪‍⁫‏‎⁯⁫⁭‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static int \u202A‍‫⁪‎‍‍‏‏‌⁮‬⁭​⁮⁫‎‏‏‮⁭⁯‫‏‏​⁪‭‪‬‮‍‍⁭‮⁯‏‎‫‪‮([In] uint obj0)
    {
      return Convert.ToInt32(obj0);
    }

    static void \u200F‌‏⁬⁮⁭⁭‮⁪⁪​‬⁯‌⁪‭⁯‎‪‭‮⁫⁫‬‎‍‮‮‍‭‪⁮​⁮⁫⁫‌⁭‍‪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static bool \u206E‮​⁭⁭‪‪‍⁮⁬⁭‎⁪⁮‎​‎‏‏‌‌‪⁬​⁯⁫‌‍‫‌⁮‪‬‭⁮⁪⁫⁮⁬⁮‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u200D‪‬‏⁬⁯⁮‬‎‪⁫⁫‭​⁬⁮⁮‎⁬‪⁯‎‏⁮⁭‎⁬⁯⁮‭‬‭‬‬⁭‮⁮‌⁫‬‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u200B⁯⁪‫‏‮⁬‭⁫‍‬‭⁮‎⁫‬‏⁭‮⁫​‎⁮‫‭‪‌‬⁮​⁭‌‭⁯‌‌⁮‭‎⁭‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.DebugFormat(obj1, obj2, obj3);
    }

    static string \u206D​‭‮‌‍⁪‎‍​‌‫⁭‏‫​‍‫‪‏‪‏​‮‭‭‏⁫⁬⁪‎‌⁮‫⁮⁯‏‮‪⁯‮([In] string obj0)
    {
      return Path.GetDirectoryName(obj0);
    }

    static bool \u206A⁫‭‬‪‏⁯⁯‬​‌⁬⁫⁬‍‬​‫⁯‏⁮⁭‮‭⁯‍‏‮‮‏​⁪‫‮‏‫‏‮‏‬‮([In] string obj0)
    {
      return Directory.Exists(obj0);
    }

    static DirectoryInfo \u202E⁭‬⁯⁫​⁮⁮‍‪‏⁫⁯​⁬‏‫‪⁭⁬‏​⁯‪⁫⁪‪‬‎‏‪‪⁪⁫‫⁪‎⁮‍⁯‮([In] string obj0)
    {
      return Directory.CreateDirectory(obj0);
    }

    static void \u206D⁫‪⁯​⁮⁬‮⁯⁫‎‎‪‎⁬‎⁪‫‌‮‍⁬‫⁭⁭⁮⁪‏‭‮⁮‬⁪⁫​⁮‫⁭‎⁬‮([In] Image obj0, [In] string obj1)
    {
      obj0.Save(obj1);
    }

    static void \u200F‬‌‌⁬⁮‭⁪⁪⁭⁬​‫‮‮‎⁭‮‍‏‮‎​⁭‌⁭⁪⁪‏⁮‫‭‭‭⁯⁮‫‍‍‮‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Process \u200E‌‪⁬⁪‭⁫⁪‫⁭⁫‪‮‫‍‏‏‪‌‫‪‮‌‏‭⁭‪⁬⁪‬​‬⁯⁬⁭‭⁯⁬‏⁭‮([In] string obj0)
    {
      return Process.Start(obj0);
    }

    static Bitmap \u200F‫⁪‬⁮⁫‍‬⁮⁯‭⁯‍​‬‮‍‮‭‎‫‌‫⁪⁬⁪‮‍‎⁬‭⁬⁮⁮‪‪⁯‪⁯⁪‮([In] int obj0, [In] int obj1, [In] PixelFormat obj2)
    {
      return new Bitmap(obj0, obj1, obj2);
    }

    static Graphics \u206E‬‍‎⁮‏‮⁭‮‪⁪⁭‎⁬⁮‭‪‏⁪‪‍‬‏⁭‎⁮‪‎‬‮⁬⁯‏⁪⁬⁮‎‌‍‌‮([In] Image obj0)
    {
      return Graphics.FromImage(obj0);
    }

    static void \u202C‌‫⁭⁫​⁯⁮⁯‬‮⁭‍‫‫⁭‍⁭‬⁮‬‌⁭‪‬​⁮‭​⁫‭‭⁯⁭‌⁮‎⁭‌‮‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3, [In] object obj4)
    {
      obj0.DebugFormat(obj1, obj2, obj3, obj4);
    }

    static void \u206A‌⁫‭⁭⁬⁯‏⁫‏‌‏‏‬⁯‫‫⁭‬‏⁬⁪‪‪⁫‎‬⁫⁫‏‏‌⁭‪⁬‌⁫​‬⁫‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static bool \u206B​‏‏‬‍⁮‫‎‏‪‮⁯‪⁫‌‬‪‬⁪⁬⁭‮‍⁯‬‭‮⁭⁭‌⁭‍‭⁭⁫​‍⁫‮([In] string obj0, [In] string obj1)
    {
      return obj0.StartsWith(obj1);
    }

    static bool \u202B‮‏‬⁮⁫‭​‭‭‬‫⁮⁭⁮⁪‪⁮‌‏⁪‏‫‪‭‪⁭⁫‫⁬‪⁮‬‍⁯‫‪⁯⁫‎‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static string \u200B⁬‎⁭‌‭‪‎‮‏‎‏⁬‪⁫⁪⁭‎⁫⁮⁯⁫‏‍⁮‏⁮‏‬‍⁭‎‫⁪‮‪‮‫​⁪‮([In] string obj0)
    {
      return obj0.ToUpper();
    }

    static string \u206A⁮‭⁯‬‭‬‌​⁫‍⁭‬⁮‍​‬​⁫⁬‫⁫​⁮⁪‫⁯⁯‭‭⁯⁫‪‬⁭‫⁬‍‮‭‮([In] object obj0, [In] object obj1, [In] object obj2)
    {
      return obj0.ToString() + obj1 + obj2;
    }

    static object \u202A⁭​⁮‫‪⁭⁬‌⁮⁯⁪⁭‌‍‪‌‌⁯‭⁭⁮⁭‭⁭‏‫‮⁮⁮‫‪‭​‎⁭⁯​⁭‪‮()
    {
      return new object();
    }
  }
}
