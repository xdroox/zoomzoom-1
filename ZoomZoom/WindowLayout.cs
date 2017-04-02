// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WindowLayout
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ZoomZoom.Properties;

namespace ZoomZoom
{
  public class WindowLayout : CoreObject
  {
    private static readonly object layoutLock = WindowLayout.\u200C​‏‬‎​⁮‍⁫⁮⁪‫⁪‌​⁪‪‬‬‍⁬‮‭‌⁭‎​⁮⁬‏⁮‏⁭‍⁬‍‏‭‏⁯‮();
    private string monitor = string.Empty;
    private string targetScreen = "";
    private LayoutPattern pattern;
    private ScreenPlacement vertical;
    private ScreenPlacement horizontal;
    private int x;
    private int y;
    private int width;
    private int height;
    private ScreenStretching stretch;
    private WindowType windowType;
    private ZoomWindowType zoomWindowType;
    private WindowVisibility windowVisibility;
    private Rectangle rectangle;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 1123085960;
        TraceType traceType;
        while (true)
        {
          int num2 = 246471532;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Layout;
              num1 = (int) num3 * -1656380138 ^ 960863570;
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

    [Display(Description = "Specifies the positioning and size for the horizontal axis", GroupName = "Positioning", Name = "Horizontal")]
    public ScreenPlacement Horizontal
    {
      get
      {
label_1:
        int num1 = -1163056547;
        ScreenPlacement horizontal;
        while (true)
        {
          int num2 = -1390353180;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 803333161 ^ 1855032579;
              continue;
            case 1:
              horizontal = this.horizontal;
              num1 = (int) num3 * -973093925 ^ -2125948185;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return horizontal;
      }
      set
      {
label_1:
        int num1 = 730917497;
        while (true)
        {
          int num2 = 434762443;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.horizontal = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(753788883U));
              num1 = (int) num3 * 463527452 ^ -591765512;
              continue;
            case 3:
              num1 = (int) num3 * 831137356 ^ 591537938;
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

    [Display(Description = "Specifies the positioning and size for the vertical axis", GroupName = "Positioning", Name = "Vertical")]
    public ScreenPlacement Vertical
    {
      get
      {
label_1:
        int num1 = 646467421;
        ScreenPlacement vertical;
        while (true)
        {
          int num2 = 947071590;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1723888257 ^ 1224664633;
              continue;
            case 3:
              vertical = this.vertical;
              num1 = (int) num3 * -2077767849 ^ -679260751;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return vertical;
      }
      set
      {
        this.vertical = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2840108404U));
      }
    }

    [Display(Description = "Specifies if the window should be stretched to the edges of the axis", GroupName = "Positioning", Name = "Stretch")]
    public ScreenStretching Stretch
    {
      get
      {
        ScreenStretching stretch = this.stretch;
label_1:
        int num1 = 1616922970;
        while (true)
        {
          int num2 = 1310945998;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 832281628 ^ 109274634;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return stretch;
      }
      set
      {
label_1:
        int num1 = -1378716817;
        while (true)
        {
          int num2 = -617257588;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.stretch = value;
              num1 = (int) num3 * 623404657 ^ 875452826;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(409811684U));
      }
    }

    [Display(Description = "Specifies which monitor the window should appear on", GroupName = "General", Name = "Monitor")]
    public string Monitor
    {
      get
      {
label_1:
        int num1 = 1566424983;
        string monitor;
        while (true)
        {
          int num2 = 440227330;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              monitor = this.monitor;
              num1 = (int) num3 * -1966889935 ^ -591358003;
              continue;
            case 2:
              num1 = (int) num3 * -695714183 ^ 903210984;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return monitor;
      }
      set
      {
        this.monitor = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2726961981U));
      }
    }

    public string TargetScreen
    {
      get
      {
label_1:
        int num1 = -1299029932;
        string targetScreen;
        while (true)
        {
          int num2 = -1519896583;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.targetScreen = this.GetTargetScreen();
              num1 = (int) num3 * -74028738 ^ 2062545012;
              continue;
            case 1:
              flag = WindowLayout.\u200D‌⁯​‍‎⁬⁫‪‮‫‏‫⁪‮‫‭⁮⁪‏‪⁬‪‭⁯‫⁮‌‫‏‮⁭‍⁬⁯⁫​‭⁬‍‮(this.targetScreen, "");
              num1 = (int) num3 * -1013791774 ^ 3409986;
              continue;
            case 2:
              targetScreen = this.targetScreen;
              num1 = -862614241;
              continue;
            case 3:
              num1 = (int) num3 * 1718143757 ^ -900929325;
              continue;
            case 5:
              int num4 = !flag ? -1938361915 : (num4 = -1317554776);
              int num5 = (int) num3 * 428088433;
              num1 = num4 ^ num5;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return targetScreen;
      }
    }

    public WindowType WindowType
    {
      get
      {
label_1:
        int num1 = 2139854349;
        WindowType windowType;
        while (true)
        {
          int num2 = 1392079982;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              windowType = this.windowType;
              num1 = (int) num3 * -1942777859 ^ 763322217;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowType;
      }
      set
      {
label_1:
        int num1 = 1815393110;
        while (true)
        {
          int num2 = 2070275627;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(169513491U));
              num1 = (int) num3 * -667029779 ^ -223583196;
              continue;
            case 1:
              this.windowType = value;
              num1 = (int) num3 * -1971207773 ^ -1783550344;
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

    [Display(Description = "Identifies the type of window", GroupName = "General", Name = "Zoom Window Type")]
    public ZoomWindowType ZoomWindowType
    {
      get
      {
label_1:
        int num1 = -787776830;
        ZoomWindowType zoomWindowType;
        while (true)
        {
          int num2 = -2141336936;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              zoomWindowType = this.zoomWindowType;
              num1 = (int) num3 * -1021066118 ^ 762800535;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomWindowType;
      }
      set
      {
        this.zoomWindowType = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1495333183U));
label_1:
        int num1 = 2046679842;
        while (true)
        {
          int num2 = 1829912846;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -1287721211 ^ 1833922175;
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

    [Display(Description = "Specifies how Zoom Zoom should treat the window when it has been detected", GroupName = "General", Name = "Visibility")]
    public WindowVisibility WindowVisibility
    {
      get
      {
label_1:
        int num1 = -452659773;
        WindowVisibility windowVisibility;
        while (true)
        {
          int num2 = -1764726738;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              windowVisibility = this.windowVisibility;
              num1 = (int) num3 * -1203968960 ^ 1172152973;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -423287748 ^ 1372719926;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowVisibility;
      }
      set
      {
label_1:
        int num1 = -88961776;
        while (true)
        {
          int num2 = -1244411277;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.windowVisibility = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3000142054U));
              num1 = (int) num3 * -1798207723 ^ -2126879456;
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

    [Display(Description = "Runtime value of the windows location and size on the monitor", GroupName = "Runtime", Name = "HasStreteched")]
    public Rectangle Rectangle
    {
      get
      {
label_1:
        int num1 = -50641935;
        Rectangle rectangle;
        while (true)
        {
          int num2 = -907100672;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              this.rectangle = this.CalculateRectangle();
              num1 = (int) num3 * -1979090600 ^ 298960342;
              continue;
            case 2:
              num1 = (int) num3 * 24880396 ^ 696016828;
              continue;
            case 4:
              flag = this.rectangle == Rectangle.Empty;
              num1 = (int) num3 * -1175924290 ^ 926045907;
              continue;
            case 5:
              num1 = (int) num3 * 927973759 ^ 388145175;
              continue;
            case 6:
              num1 = (int) num3 * -600342011 ^ -628159132;
              continue;
            case 7:
              rectangle = this.rectangle;
              num1 = -143592549;
              continue;
            case 8:
              int num4 = !flag ? -2001069058 : (num4 = -432405867);
              int num5 = (int) num3 * 1681681471;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return rectangle;
      }
      set
      {
label_1:
        int num1 = -1576243096;
        while (true)
        {
          int num2 = -126870524;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.rectangle = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3452711166U));
              num1 = (int) num3 * -919174262 ^ -105219175;
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

    public Rectangle UnstretchedRectangle { get; set; }

    [Display(Description = "Runtime value indicating whether stretching has occured", GroupName = "Runtime", Name = "HasStreteched")]
    public bool HasStretched { get; set; }

    [Display(Description = "Runtime value identifying whether the window has been hidden", GroupName = "Runtime", Name = "Hidden")]
    public bool Hidden { get; set; }

    [Display(Description = "Runtime value identifying the objects owning pattern", GroupName = "Runtime", Name = "Pattern")]
    internal LayoutPattern Pattern
    {
      get
      {
label_1:
        int num1 = -433794196;
        LayoutPattern pattern;
        while (true)
        {
          int num2 = -472695761;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1156117246 ^ -1058344982;
              continue;
            case 2:
              goto label_1;
            case 3:
              pattern = this.pattern;
              num1 = (int) num3 * 1965747178 ^ 475958481;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return pattern;
      }
      set
      {
        this.pattern = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1027741621U));
      }
    }

    public int X
    {
      get
      {
        int x = this.x;
label_1:
        int num1 = -192926250;
        while (true)
        {
          int num2 = -403789348;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1641617927 ^ 1192512813;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return x;
      }
      set
      {
label_1:
        int num1 = -482146057;
        while (true)
        {
          int num2 = -1387927503;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(492879570U));
              num1 = (int) num3 * 409508931 ^ 70763606;
              continue;
            case 2:
              this.x = value;
              num1 = (int) num3 * -297257108 ^ 2144174824;
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

    public int Y
    {
      get
      {
label_1:
        int num1 = -1037515115;
        int y;
        while (true)
        {
          int num2 = -456893468;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1345198700 ^ 1124533742;
              continue;
            case 1:
              y = this.y;
              num1 = (int) num3 * 629025289 ^ -902697987;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return y;
      }
      set
      {
        this.y = value;
label_1:
        int num1 = 779189036;
        while (true)
        {
          int num2 = 197448769;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(262531578U));
              num1 = (int) num3 * -65437274 ^ 1388452604;
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

    public int Width
    {
      get
      {
        return this.width;
      }
      set
      {
label_1:
        int num1 = 48553160;
        while (true)
        {
          int num2 = 1135219673;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1215736021U));
              num1 = (int) num3 * 923506839 ^ -2119122657;
              continue;
            case 1:
              this.width = value;
              num1 = (int) num3 * -708908292 ^ 1058142381;
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

    public int Height
    {
      get
      {
        return this.height;
      }
      set
      {
        this.height = value;
label_1:
        int num1 = -258894714;
        while (true)
        {
          int num2 = -1115361085;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 2035473790 ^ -429296184;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2360276698U));
              num1 = (int) num3 * 588123496 ^ -1656645549;
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

    public WindowLayout()
    {
    }

    public WindowLayout(LayoutPattern pattern)
    {
      this.Pattern = pattern;
    }

    public WindowLayout(WindowLayout layout, LayoutPattern pattern)
    {
      this.Pattern = pattern;
      this.Hidden = layout.Hidden;
      this.Horizontal = layout.Horizontal;
      this.Monitor = layout.Monitor;
      this.Rectangle = layout.Rectangle;
      this.Stretch = layout.Stretch;
      this.HasStretched = layout.HasStretched;
      this.Vertical = layout.Vertical;
      this.WindowType = layout.WindowType;
      this.WindowVisibility = layout.WindowVisibility;
      this.ZoomWindowType = layout.ZoomWindowType;
    }

    internal Rectangle CalculateRectangle()
    {
      Rectangle rectangle = Rectangle.Empty;
label_1:
      int num1 = 110730742;
      object layoutLock1;
      while (true)
      {
        int num2 = 985424394;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            layoutLock1 = WindowLayout.layoutLock;
            num1 = (int) num3 * 1298638132 ^ -1539262685;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
        WindowLayout.\u206D⁫‎‭‬‮⁬⁬‏‎‌‫⁪‏‫‎‎⁭⁯‭⁮‏‍⁬‌‭⁫‫‮⁫‎⁬⁪‫⁭⁬⁯⁯⁪‍‮(layoutLock1, ref flag1);
label_6:
        int num2 = 517661738;
        while (true)
        {
          int num3 = 985424394;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              num2 = (int) num4 * -1167377809 ^ -1287539862;
              continue;
            case 1:
              num2 = (int) num4 * 418381332 ^ 1431255143;
              continue;
            case 2:
              goto label_6;
            case 3:
              this.HasStretched = false;
              num2 = (int) num4 * -1279159473 ^ -1803257408;
              continue;
            case 5:
              Rectangle empty1 = Rectangle.Empty;
              num2 = (int) num4 * 1446726370 ^ -495256247;
              continue;
            case 6:
              Rectangle empty2 = Rectangle.Empty;
              this.targetScreen = this.GetTargetScreen();
              num2 = (int) num4 * -1436964505 ^ -1744059011;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_14:
          int num2 = 991836324;
          while (true)
          {
            int num3 = 985424394;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_14;
              case 1:
                WindowLayout.\u206D⁪‮‍⁭⁫⁪‪‏‪⁭‬⁮‎‪⁮⁬⁪​‭‮‮⁪⁭⁫‬‬‭‫​‎⁪‏⁪​‪⁫‪‏‭‮(layoutLock1);
                num2 = (int) num4 * 2111935454 ^ 43603843;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      this.UnstretchedRectangle = this.GetScreenPlacement(this.targetScreen, false);
label_19:
      int num5 = 2116838303;
      object layoutLock2;
      while (true)
      {
        int num2 = 985424394;
        uint num3;
        bool stretchingEnabled;
        switch ((num3 = (uint) (num5 ^ num2)) % 13U)
        {
          case 0:
            rectangle = this.UnstretchedRectangle;
            this.HasStretched = false;
            num5 = (int) num3 * 274336148 ^ -1990461766;
            continue;
          case 1:
            layoutLock2 = WindowLayout.layoutLock;
            num5 = 907726582;
            continue;
          case 2:
            num5 = (int) num3 * -10968357 ^ 1797622891;
            continue;
          case 3:
            goto label_19;
          case 4:
            num5 = (int) num3 * 1783137308 ^ -1303129734;
            continue;
          case 5:
            this.HasStretched = true;
            num5 = (int) num3 * -1199605353 ^ 803409169;
            continue;
          case 6:
            int num4 = !stretchingEnabled ? 633790723 : (num4 = 706258291);
            int num6 = (int) num3 * 1816270764;
            num5 = num4 ^ num6;
            continue;
          case 7:
            num5 = (int) num3 * 1601465813 ^ -1548538746;
            continue;
          case 8:
            stretchingEnabled = this.Pattern.StretchingEnabled;
            num5 = (int) num3 * -118341149 ^ 274645426;
            continue;
          case 10:
            num5 = (int) num3 * 1828383156 ^ 1502150936;
            continue;
          case 11:
            num5 = 780004562;
            continue;
          case 12:
            rectangle = this.GetScreenPlacement(this.targetScreen, true);
            num5 = (int) num3 * 376923351 ^ 713074408;
            continue;
          default:
            goto label_32;
        }
      }
label_32:
      bool flag2 = false;
      try
      {
        WindowLayout.\u206D⁫‎‭‬‮⁬⁬‏‎‌‫⁪‏‫‎‎⁭⁯‭⁮‏‍⁬‌‭⁫‫‮⁫‎⁬⁪‫⁭⁬⁯⁯⁪‍‮(layoutLock2, ref flag2);
label_34:
        int num2 = 1800253460;
        while (true)
        {
          int num3 = 985424394;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_34;
            case 1:
              this.Rectangle = rectangle;
              num2 = (int) num4 * -1494013376 ^ 317284549;
              continue;
            default:
              goto label_42;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_38:
          int num2 = 1194862911;
          while (true)
          {
            int num3 = 985424394;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_38;
              case 1:
                WindowLayout.\u206D⁪‮‍⁭⁫⁪‪‏‪⁭‬⁮‎‪⁮⁬⁪​‭‮‮⁪⁭⁫‬‬‭‫​‎⁪‏⁪​‪⁫‪‏‭‮(layoutLock2);
                num2 = (int) num4 * 1973720163 ^ 414872283;
                continue;
              default:
                goto label_41;
            }
          }
        }
label_41:;
      }
label_42:
      return rectangle;
    }

    private string GetTargetScreen()
    {
label_1:
      int num1 = 508629564;
      string str1;
      while (true)
      {
        int num2 = 1256937690;
        uint num3;
        bool flag1;
        bool flag2;
        string str2;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            int num5 = !flag2 ? -1220602927 : (num5 = -776316);
            int num6 = (int) num3 * 193254319;
            num1 = num5 ^ num6;
            continue;
          case 1:
            str2 = this.Engine.Settings.SecondaryScreen;
            num1 = (int) num3 * 1141757092 ^ 645850145;
            continue;
          case 2:
            num1 = (int) num3 * 372583370 ^ 1909862069;
            continue;
          case 3:
            num1 = (int) num3 * 1615307866 ^ 648214890;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 1034378470 ^ -1253772864;
            continue;
          case 6:
            int num7 = !flag1 ? 1610579357 : (num7 = 1293737585);
            int num8 = (int) num3 * -366303404;
            num1 = num7 ^ num8;
            continue;
          case 7:
            num1 = (int) num3 * 487939981 ^ -1829105120;
            continue;
          case 8:
            num1 = (int) num3 * -1653381774 ^ 428370869;
            continue;
          case 9:
            flag2 = WindowLayout.\u200C⁯‍‍‮⁯‎‎‏‮‭⁪‮‍‮‍‬⁬​⁬⁭‭‬​‎‪⁫‫⁫‬⁭‎⁯‎‎‎⁪‭‫⁪‮(this.Monitor, Resources.PrimaryMonitor);
            num1 = 1724592933;
            continue;
          case 10:
            num4 = WindowLayout.\u200C⁯‍‍‮⁯‎‎‏‮‭⁪‮‍‮‍‬⁬​⁬⁭‭‬​‎‪⁫‫⁫‬⁭‎⁯‎‎‎⁪‭‫⁪‮(this.Monitor, Resources.DisabledMonitor) ? 1 : 0;
            break;
          case 11:
            str1 = str2;
            num1 = 1828458190;
            continue;
          case 12:
            str2 = this.Engine.Settings.PrimaryScreen;
            num1 = (int) num3 * -763823867 ^ -483102829;
            continue;
          case 13:
            flag1 = WindowLayout.\u200C⁯‍‍‮⁯‎‎‏‮‭⁪‮‍‮‍‬⁬​⁬⁭‭‬​‎‪⁫‫⁫‬⁭‎⁯‎‎‎⁪‭‫⁪‮(this.Monitor, Resources.SecondaryMonitor);
            num1 = 1038751956;
            continue;
          case 15:
            num1 = (int) num3 * -1964036071 ^ -1863436401;
            continue;
          case 16:
            if (!WindowLayout.\u200F‌‪‮‬⁯‭‍​⁪⁮‌⁯‍‭⁭⁭⁮‎⁭⁯‬⁭‪⁭⁪‫​⁯‫⁬‬⁫⁫⁭‪⁯⁭‭‏‮(this.Monitor))
            {
              num1 = (int) num3 * -104784365 ^ 328443402;
              continue;
            }
            num4 = 1;
            break;
          case 17:
            int num9 = !flag3 ? -9279316 : (num9 = -1496644825);
            int num10 = (int) num3 * -1769185384;
            num1 = num9 ^ num10;
            continue;
          case 18:
            str2 = this.Engine.Settings.PrimaryScreen;
            num1 = (int) num3 * -1777394564 ^ 41556212;
            continue;
          case 19:
            str2 = this.Monitor;
            num1 = 1784923719;
            continue;
          case 20:
            num1 = (int) num3 * -2072774075 ^ -462658132;
            continue;
          default:
            goto label_25;
        }
        flag3 = num4 != 0;
        num1 = 661722146;
      }
label_25:
      return str1;
    }

    public override string ToString()
    {
      string str = this.ZoomWindowType.ToString();
label_1:
      int num1 = 1416192191;
      while (true)
      {
        int num2 = 230568385;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -388228534 ^ 611456320;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return str;
    }

    public Rectangle GetScreenPlacement(string screenName, bool allowStretching)
    {
label_1:
      int num1 = 1151807587;
      Rectangle screenPlacement;
      while (true)
      {
        int num2 = 377657073;
        uint num3;
        Screen screen;
        bool flag;
        Screen[] screenArray;
        int index;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            num1 = (int) num3 * -2007950605 ^ -1633801955;
            continue;
          case 1:
            num1 = (int) num3 * -1008621778 ^ -897788731;
            continue;
          case 2:
            screenArray = WindowLayout.\u202E⁫‪‪‭‏⁬⁮‭⁮‌⁬⁬⁬⁪‪⁬⁯‭⁭‏‍​‪‬⁬‭‪⁭​‮⁪‮‬‬‪‬‌‫⁯‮();
            num1 = (int) num3 * -470676929 ^ -834670615;
            continue;
          case 3:
            screen = screenArray[index];
            num1 = 1830395724;
            continue;
          case 4:
            goto label_1;
          case 5:
            screenPlacement = this.GetScreenPlacement(WindowLayout.\u200E‌‪⁭⁪‪⁪⁭‬⁯⁯⁮⁫‪⁫‏‫‏‌‬⁭⁪‮‫‪⁭⁫⁬​‎‏⁭‏‪‌‬‏‫⁪⁮‮(), allowStretching);
            num1 = (int) num3 * 216069303 ^ -2131896680;
            continue;
          case 6:
            index = 0;
            num1 = (int) num3 * 1044057255 ^ 661310620;
            continue;
          case 7:
            num1 = (int) num3 * 1127389683 ^ 2028675085;
            continue;
          case 8:
            int num4 = !flag ? 1705066631 : (num4 = 284071529);
            int num5 = (int) num3 * 1539128195;
            num1 = num4 ^ num5;
            continue;
          case 9:
            int num6;
            num1 = num6 = index < screenArray.Length ? 1472701874 : (num6 = 225209588);
            continue;
          case 11:
            ++index;
            num1 = (int) num3 * 367816252 ^ 865129996;
            continue;
          case 12:
            screenPlacement = this.GetScreenPlacement(screen, allowStretching);
            num1 = (int) num3 * -1196278687 ^ -632402164;
            continue;
          case 13:
            num1 = (int) num3 * -1536280823 ^ -2018715557;
            continue;
          case 14:
            num1 = 688473610;
            continue;
          case 15:
            flag = WindowLayout.\u200C⁯‍‍‮⁯‎‎‏‮‭⁪‮‍‮‍‬⁬​⁬⁭‭‬​‎‪⁫‫⁫‬⁭‎⁯‎‎‎⁪‭‫⁪‮(WindowLayout.\u200B⁯⁪⁮⁫⁫‫‮⁭‮‍‪⁭⁬⁬⁫‫‌⁮⁮‪​‪⁬⁮⁭‪‌⁯‪⁯‍‏‎‫‌‎⁯⁫‎‮(WindowLayout.\u202E‮‮‌‮⁭⁯‭⁬‎‎‭​‌⁫​‏‍​⁯⁭⁬‬⁮‪⁮‎⁮‮‏⁭‭‮‮⁫‍‬⁮⁫‍‮(screen)), WindowLayout.\u200B⁯⁪⁮⁫⁫‫‮⁭‮‍‪⁭⁬⁬⁫‫‌⁮⁮‪​‪⁬⁮⁭‪‌⁯‪⁯‍‏‎‫‌‎⁯⁫‎‮(screenName));
            num1 = (int) num3 * -2131774141 ^ 1103433268;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return screenPlacement;
    }

    public Rectangle GetScreenPlacement(Screen screen, bool allowStretching)
    {
label_1:
      int num1 = -1489943407;
      Rectangle rectangle;
      while (true)
      {
        int num2 = -1309422554;
        uint num3;
        Size size;
        Rectangle workingArea;
        System.Drawing.Point location;
        bool flag1;
        ScreenPlacement screenPlacement1;
        bool flag2;
        bool flag3;
        bool flag4;
        ScreenPlacement screenPlacement2;
        ScreenPlacement screenPlacement3;
        ScreenPlacement screenPlacement4;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 170U)
        {
          case 0:
            num1 = (int) num3 * -422745101 ^ 1532872854;
            continue;
          case 1:
            num1 = (int) num3 * -1034432037 ^ -1214975800;
            continue;
          case 2:
            switch (screenPlacement2)
            {
              case ScreenPlacement.Undefined:
                goto label_58;
              case ScreenPlacement.FirstHalf:
                goto label_101;
              case ScreenPlacement.SecondHalf:
                goto label_172;
              case ScreenPlacement.FirstThird:
                goto label_175;
              case ScreenPlacement.FirstTwoThirds:
                goto label_6;
              case ScreenPlacement.SecondThird:
                goto label_36;
              case ScreenPlacement.SecondTwoThirds:
                goto label_163;
              case ScreenPlacement.ThirdThird:
                goto label_34;
              case ScreenPlacement.FirstQuarter:
                goto label_70;
              case ScreenPlacement.SecondQuarter:
                goto label_48;
              case ScreenPlacement.SecondTwoQuarters:
                goto label_97;
              case ScreenPlacement.ThirdQuarter:
                goto label_139;
              case ScreenPlacement.FourthQuarter:
                goto label_50;
              case ScreenPlacement.Full:
                goto label_178;
              case ScreenPlacement.FirstThreeQuarters:
                goto label_11;
              case ScreenPlacement.SecondThreeQuarters:
                goto label_10;
              default:
                num1 = (int) num3 * 117227170 ^ 338880733;
                continue;
            }
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local1 = @location;
            workingArea = screen.WorkingArea;
            int x1 = workingArea.X;
            workingArea = screen.WorkingArea;
            int num6 = workingArea.Width / 4;
            int num7 = x1 + num6;
            // ISSUE: explicit reference operation
            (^local1).X = num7;
            num1 = (int) num3 * -1042607368 ^ 896949860;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local2 = @location;
            workingArea = screen.WorkingArea;
            int y1 = workingArea.Y;
            // ISSUE: explicit reference operation
            (^local2).Y = y1;
            num1 = (int) num3 * 1928308589 ^ 50947659;
            continue;
          case 5:
            num1 = (int) num3 * 384538157 ^ 1579741833;
            continue;
          case 6:
            screenPlacement4 = this.StretchPlacement(this.Horizontal, true);
            num1 = (int) num3 * -1583970251 ^ 1476500130;
            continue;
          case 7:
            flag2 = true;
            num1 = (int) num3 * 601769539 ^ -1851231956;
            continue;
          case 8:
            num1 = (int) num3 * 1089443488 ^ -635639856;
            continue;
          case 9:
            num1 = (int) num3 * 39373710 ^ -114786174;
            continue;
          case 10:
label_8:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local3 = @size;
            workingArea = screen.WorkingArea;
            int num8 = workingArea.Width / 3 * 2;
            // ISSUE: explicit reference operation
            (^local3).Width = num8;
            num1 = -499951136;
            continue;
          case 11:
            if (this.Stretch != ScreenStretching.Horizontal)
            {
              num1 = (int) num3 * 1793768737 ^ -314944201;
              continue;
            }
            num4 = 1;
            goto label_132;
          case 12:
label_11:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local4 = @size;
            workingArea = screen.WorkingArea;
            int num9 = workingArea.Height / 4 * 3;
            // ISSUE: explicit reference operation
            (^local4).Height = num9;
            num1 = -459827630;
            continue;
          case 13:
            num1 = (int) num3 * -470672405 ^ 1819336921;
            continue;
          case 14:
label_175:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local5 = @size;
            workingArea = screen.WorkingArea;
            int num10 = workingArea.Height / 3;
            // ISSUE: explicit reference operation
            (^local5).Height = num10;
            num1 = -526335466;
            continue;
          case 15:
            num1 = (int) num3 * -1760199932 ^ 1289653427;
            continue;
          case 16:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local6 = @location;
            workingArea = screen.WorkingArea;
            int x2 = workingArea.X;
            // ISSUE: explicit reference operation
            (^local6).X = x2;
            num1 = (int) num3 * 1038409712 ^ 1052476938;
            continue;
          case 17:
            num1 = (int) num3 * 1503718080 ^ -1144132113;
            continue;
          case 18:
            location = new System.Drawing.Point();
            num1 = (int) num3 * -1956939495 ^ 2134824981;
            continue;
          case 19:
            flag2 = false;
            num1 = -478437622;
            continue;
          case 20:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local7 = @location;
            workingArea = screen.WorkingArea;
            int num11 = workingArea.Y + size.Height * 3;
            // ISSUE: explicit reference operation
            (^local7).Y = num11;
            num1 = (int) num3 * -1567606068 ^ 1162867975;
            continue;
          case 21:
            num1 = (int) num3 * 1820189069 ^ -1853049148;
            continue;
          case 22:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local8 = @location;
            workingArea = screen.WorkingArea;
            int y2 = workingArea.Y;
            // ISSUE: explicit reference operation
            (^local8).Y = y2;
            num1 = (int) num3 * 1000106764 ^ 1941378407;
            continue;
          case 23:
            num1 = (int) num3 * 1804012682 ^ -947119862;
            continue;
          case 24:
            this.HasStretched = true;
            num1 = (int) num3 * 25193021 ^ 733883570;
            continue;
          case 25:
            flag2 = false;
            num1 = (int) num3 * -2144972005 ^ -1522574683;
            continue;
          case 26:
label_178:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local9 = @size;
            workingArea = screen.WorkingArea;
            int height = workingArea.Height;
            // ISSUE: explicit reference operation
            (^local9).Height = height;
            num1 = -625962091;
            continue;
          case 27:
            int num12 = !flag3 ? 2071399940 : (num12 = 1456199276);
            int num13 = (int) num3 * -117173973;
            num1 = num12 ^ num13;
            continue;
          case 28:
label_78:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local10 = @size;
            workingArea = screen.WorkingArea;
            int num14 = workingArea.Width / 4;
            // ISSUE: explicit reference operation
            (^local10).Width = num14;
            num1 = -493033508;
            continue;
          case 29:
            size.Height = this.Height;
            num1 = (int) num3 * 760530620 ^ 961026343;
            continue;
          case 30:
            switch (screenPlacement3)
            {
              case ScreenPlacement.Undefined:
                goto label_114;
              case ScreenPlacement.FirstHalf:
                goto label_113;
              case ScreenPlacement.SecondHalf:
                goto label_71;
              case ScreenPlacement.FirstThird:
                goto label_112;
              case ScreenPlacement.FirstTwoThirds:
                goto label_86;
              case ScreenPlacement.SecondThird:
                goto label_150;
              case ScreenPlacement.SecondTwoThirds:
                goto label_8;
              case ScreenPlacement.ThirdThird:
                goto label_151;
              case ScreenPlacement.FirstQuarter:
                goto label_19;
              case ScreenPlacement.SecondQuarter:
                goto label_145;
              case ScreenPlacement.SecondTwoQuarters:
                goto label_15;
              case ScreenPlacement.ThirdQuarter:
                goto label_78;
              case ScreenPlacement.FourthQuarter:
                goto label_59;
              case ScreenPlacement.Full:
                goto label_74;
              case ScreenPlacement.FirstThreeQuarters:
                goto label_157;
              case ScreenPlacement.SecondThreeQuarters:
                goto label_3;
              default:
                num1 = (int) num3 * -1513874268 ^ 606067057;
                continue;
            }
          case 31:
label_36:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local11 = @size;
            workingArea = screen.WorkingArea;
            int num15 = workingArea.Height / 3;
            // ISSUE: explicit reference operation
            (^local11).Height = num15;
            num1 = -1660404702;
            continue;
          case 32:
            num1 = (int) num3 * -392839578 ^ -101168394;
            continue;
          case 34:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local12 = @location;
            workingArea = screen.WorkingArea;
            int x3 = workingArea.X;
            workingArea = screen.WorkingArea;
            int num16 = workingArea.Width / 4;
            int num17 = x3 + num16;
            // ISSUE: explicit reference operation
            (^local12).X = num17;
            num1 = (int) num3 * -168477165 ^ 1681199422;
            continue;
          case 35:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local13 = @location;
            workingArea = screen.WorkingArea;
            int x4 = workingArea.X;
            // ISSUE: explicit reference operation
            (^local13).X = x4;
            num1 = (int) num3 * 1645578334 ^ 1209626257;
            continue;
          case 36:
label_34:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local14 = @size;
            workingArea = screen.WorkingArea;
            int num18 = workingArea.Height / 3;
            // ISSUE: explicit reference operation
            (^local14).Height = num18;
            num1 = -886355910;
            continue;
          case 37:
label_74:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local15 = @size;
            workingArea = screen.WorkingArea;
            int width = workingArea.Width;
            // ISSUE: explicit reference operation
            (^local15).Width = width;
            num1 = -71184760;
            continue;
          case 38:
            num1 = -1500024690;
            continue;
          case 39:
label_6:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local16 = @size;
            workingArea = screen.WorkingArea;
            int num19 = workingArea.Height / 3 * 2;
            // ISSUE: explicit reference operation
            (^local16).Height = num19;
            num1 = -1200755800;
            continue;
          case 40:
            num1 = (int) num3 * -69446131 ^ -236384049;
            continue;
          case 41:
label_19:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local17 = @size;
            workingArea = screen.WorkingArea;
            int num20 = workingArea.Width / 4;
            // ISSUE: explicit reference operation
            (^local17).Width = num20;
            num1 = -2053159484;
            continue;
          case 42:
            int num21 = flag1 ? -1711965314 : (num21 = -1595668802);
            int num22 = (int) num3 * 879994958;
            num1 = num21 ^ num22;
            continue;
          case 43:
            num1 = (int) num3 * 773319921 ^ 1681400032;
            continue;
          case 44:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local18 = @location;
            workingArea = screen.WorkingArea;
            int num23 = workingArea.Y + size.Height * 2;
            // ISSUE: explicit reference operation
            (^local18).Y = num23;
            num1 = (int) num3 * -1967893587 ^ 1419090030;
            continue;
          case 45:
label_97:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local19 = @size;
            workingArea = screen.WorkingArea;
            int num24 = workingArea.Height / 2;
            // ISSUE: explicit reference operation
            (^local19).Height = num24;
            num1 = -963596030;
            continue;
          case 46:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local20 = @location;
            workingArea = screen.WorkingArea;
            int y3 = workingArea.Y;
            // ISSUE: explicit reference operation
            (^local20).Y = y3;
            num1 = (int) num3 * -1201879689 ^ 1485971925;
            continue;
          case 47:
            screenPlacement1 = this.StretchPlacement(this.Vertical, false);
            num1 = (int) num3 * 574128260 ^ 904820990;
            continue;
          case 48:
label_15:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local21 = @size;
            workingArea = screen.WorkingArea;
            int num25 = workingArea.Width / 2;
            // ISSUE: explicit reference operation
            (^local21).Width = num25;
            num1 = -2135497894;
            continue;
          case 49:
            num1 = (int) num3 * 1584152153 ^ -539856317;
            continue;
          case 50:
            num1 = (int) num3 * -1688425088 ^ 897844912;
            continue;
          case 51:
            num1 = (int) num3 * 1111369002 ^ 1754819652;
            continue;
          case 52:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local22 = @location;
            workingArea = screen.WorkingArea;
            int y4 = workingArea.Y;
            // ISSUE: explicit reference operation
            (^local22).Y = y4;
            num1 = (int) num3 * 701671980 ^ -804524954;
            continue;
          case 53:
            num1 = (int) num3 * -823544652 ^ 1827691846;
            continue;
          case 54:
            num1 = (int) num3 * -1724476593 ^ -182119002;
            continue;
          case 55:
            num1 = (int) num3 * -390522721 ^ -1480940693;
            continue;
          case 56:
            num1 = (int) num3 * 225896721 ^ 761576912;
            continue;
          case 57:
            num1 = (int) num3 * -132791969 ^ 1713966145;
            continue;
          case 58:
            num5 = this.Stretch == ScreenStretching.Fill ? 1 : 0;
            goto label_28;
          case 59:
label_150:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local23 = @size;
            workingArea = screen.WorkingArea;
            int num26 = workingArea.Width / 3;
            // ISSUE: explicit reference operation
            (^local23).Width = num26;
            num1 = -686310474;
            continue;
          case 60:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local24 = @location;
            workingArea = screen.WorkingArea;
            int y5 = workingArea.Y;
            // ISSUE: explicit reference operation
            (^local24).Y = y5;
            num1 = (int) num3 * 1156046762 ^ 345976098;
            continue;
          case 61:
            num1 = (int) num3 * -37119894 ^ -944044854;
            continue;
          case 62:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local25 = @location;
            workingArea = screen.WorkingArea;
            int num27 = workingArea.X + size.Width * 2;
            // ISSUE: explicit reference operation
            (^local25).X = num27;
            num1 = (int) num3 * 988845400 ^ -1571553030;
            continue;
          case 63:
            num1 = (int) num3 * 1040300356 ^ 461805607;
            continue;
          case 64:
            size.Width = this.Width;
            num1 = (int) num3 * 183893126 ^ -1007027823;
            continue;
          case 65:
label_145:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local26 = @size;
            workingArea = screen.WorkingArea;
            int num28 = workingArea.Width / 4;
            // ISSUE: explicit reference operation
            (^local26).Width = num28;
            num1 = -1819667831;
            continue;
          case 66:
label_157:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local27 = @size;
            workingArea = screen.WorkingArea;
            int num29 = workingArea.Width / 4 * 3;
            // ISSUE: explicit reference operation
            (^local27).Width = num29;
            num1 = -841470963;
            continue;
          case 67:
label_86:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local28 = @size;
            workingArea = screen.WorkingArea;
            int num30 = workingArea.Width / 3 * 2;
            // ISSUE: explicit reference operation
            (^local28).Width = num30;
            num1 = -821042722;
            continue;
          case 68:
            if (this.Stretch == ScreenStretching.Vertical)
            {
              num5 = 1;
              goto label_28;
            }
            else
            {
              num1 = (int) num3 * -27413807 ^ -279556734;
              continue;
            }
          case 69:
            num1 = (int) num3 * -1130604862 ^ 650848559;
            continue;
          case 70:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local29 = @location;
            workingArea = screen.WorkingArea;
            int num31 = workingArea.X + size.Width * 3;
            // ISSUE: explicit reference operation
            (^local29).X = num31;
            num1 = (int) num3 * -1568133786 ^ -1251016578;
            continue;
          case 71:
label_48:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local30 = @size;
            workingArea = screen.WorkingArea;
            int num32 = workingArea.Height / 4;
            // ISSUE: explicit reference operation
            (^local30).Height = num32;
            num1 = -321190689;
            continue;
          case 72:
            rectangle = new Rectangle(location, size);
            num1 = (int) num3 * -1869067750 ^ -399848032;
            continue;
          case 73:
            num1 = (int) num3 * 1368147052 ^ -1767441474;
            continue;
          case 74:
            num1 = -1484566159;
            continue;
          case 75:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local31 = @location;
            workingArea = screen.WorkingArea;
            int x5 = workingArea.X;
            // ISSUE: explicit reference operation
            (^local31).X = x5;
            num1 = (int) num3 * -2335548 ^ -1254286603;
            continue;
          case 76:
            num1 = (int) num3 * 1624792307 ^ 718378601;
            continue;
          case 77:
            num1 = (int) num3 * 562528091 ^ -857749498;
            continue;
          case 78:
            num1 = (int) num3 * -772505761 ^ 875529063;
            continue;
          case 79:
            int num33 = this.Pattern.LayoutMode == LayoutMode.Static ? -868316682 : (num33 = -1663677508);
            int num34 = (int) num3 * -482699432;
            num1 = num33 ^ num34;
            continue;
          case 80:
            num4 = this.Stretch == ScreenStretching.Fill ? 1 : 0;
            goto label_132;
          case 81:
label_70:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local32 = @size;
            workingArea = screen.WorkingArea;
            int num35 = workingArea.Height / 4;
            // ISSUE: explicit reference operation
            (^local32).Height = num35;
            num1 = -1382475896;
            continue;
          case 82:
            num1 = (int) num3 * 677550638 ^ -165097495;
            continue;
          case 83:
            num1 = (int) num3 * -1305997737 ^ -907149106;
            continue;
          case 84:
            flag3 = screenPlacement4 != this.Horizontal;
            num1 = (int) num3 * 963450236 ^ -667222917;
            continue;
          case 85:
label_163:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local33 = @size;
            workingArea = screen.WorkingArea;
            int num36 = workingArea.Height / 3 * 2;
            // ISSUE: explicit reference operation
            (^local33).Height = num36;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local34 = @location;
            workingArea = screen.WorkingArea;
            int y6 = workingArea.Y;
            workingArea = screen.WorkingArea;
            int num37 = workingArea.Height / 3;
            int num38 = y6 + num37;
            // ISSUE: explicit reference operation
            (^local34).Y = num38;
            num1 = -1147591738;
            continue;
          case 86:
            num1 = (int) num3 * -415984883 ^ -876502499;
            continue;
          case 87:
label_71:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local35 = @size;
            workingArea = screen.WorkingArea;
            int num39 = workingArea.Width / 2;
            // ISSUE: explicit reference operation
            (^local35).Width = num39;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local36 = @location;
            workingArea = screen.WorkingArea;
            int num40 = workingArea.X + size.Width;
            // ISSUE: explicit reference operation
            (^local36).X = num40;
            num1 = -1472021420;
            continue;
          case 88:
            num1 = (int) num3 * 1994120667 ^ 149863199;
            continue;
          case 89:
label_59:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local37 = @size;
            workingArea = screen.WorkingArea;
            int num41 = workingArea.Width / 4;
            // ISSUE: explicit reference operation
            (^local37).Width = num41;
            num1 = -465285426;
            continue;
          case 90:
          case 139:
label_114:
            screenPlacement2 = screenPlacement1;
            num1 = -753454694;
            continue;
          case 91:
            num1 = (int) num3 * 1980048605 ^ 749401457;
            continue;
          case 92:
            num1 = (int) num3 * 1924789677 ^ -703006085;
            continue;
          case 93:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local38 = @location;
            workingArea = screen.WorkingArea;
            int num42 = workingArea.X + this.X;
            // ISSUE: explicit reference operation
            (^local38).X = num42;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local39 = @location;
            workingArea = screen.WorkingArea;
            int num43 = workingArea.Y + this.Y;
            // ISSUE: explicit reference operation
            (^local39).Y = num43;
            num1 = (int) num3 * -1897483060 ^ 32586327;
            continue;
          case 94:
label_139:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local40 = @size;
            workingArea = screen.WorkingArea;
            int num44 = workingArea.Height / 4;
            // ISSUE: explicit reference operation
            (^local40).Height = num44;
            num1 = -1365923638;
            continue;
          case 95:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local41 = @location;
            workingArea = screen.WorkingArea;
            int x6 = workingArea.X;
            workingArea = screen.WorkingArea;
            int num45 = workingArea.Width / 3;
            int num46 = x6 + num45;
            // ISSUE: explicit reference operation
            (^local41).X = num46;
            num1 = (int) num3 * 82488137 ^ 689230309;
            continue;
          case 96:
            int num47;
            num1 = num47 = !flag2 ? -1925287552 : (num47 = -1872367180);
            continue;
          case 97:
label_58:
            flag2 = false;
            num1 = -1298424273;
            continue;
          case 98:
            num1 = (int) num3 * 349700846 ^ 1775380042;
            continue;
          case 99:
            num1 = (int) num3 * -254431657 ^ 1235299703;
            continue;
          case 100:
            this.HasStretched = true;
            num1 = (int) num3 * 1223307355 ^ 1711797107;
            continue;
          case 101:
            num1 = (int) num3 * -1566421474 ^ 1926638608;
            continue;
          case 102:
            num1 = (int) num3 * 209832096 ^ -1914426310;
            continue;
          case 103:
            num1 = -1190162582;
            continue;
          case 104:
label_10:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local42 = @size;
            workingArea = screen.WorkingArea;
            int num48 = workingArea.Height / 4 * 3;
            // ISSUE: explicit reference operation
            (^local42).Height = num48;
            num1 = -262487761;
            continue;
          case 105:
            rectangle = Rectangle.Empty;
            num1 = (int) num3 * -1382374723 ^ 430688194;
            continue;
          case 106:
            num1 = (int) num3 * -1359824707 ^ 879638259;
            continue;
          case 107:
            num1 = -421994529;
            continue;
          case 108:
label_50:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local43 = @size;
            workingArea = screen.WorkingArea;
            int num49 = workingArea.Height / 4;
            // ISSUE: explicit reference operation
            (^local43).Height = num49;
            num1 = -642043096;
            continue;
          case 109:
            num1 = (int) num3 * 1946213870 ^ -282454223;
            continue;
          case 110:
            num1 = -1281082549;
            continue;
          case 111:
            num1 = (int) num3 * 1814917325 ^ 1487463060;
            continue;
          case 112:
            num1 = (int) num3 * -557018659 ^ -2056155713;
            continue;
          case 113:
            num1 = -231737302;
            continue;
          case 114:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local44 = @location;
            workingArea = screen.WorkingArea;
            int y7 = workingArea.Y;
            workingArea = screen.WorkingArea;
            int num50 = workingArea.Height / 3;
            int num51 = y7 + num50;
            // ISSUE: explicit reference operation
            (^local44).Y = num51;
            num1 = (int) num3 * -886794710 ^ 1078228787;
            continue;
          case 115:
            num1 = (int) num3 * -2068755404 ^ -972343189;
            continue;
          case 116:
            num1 = (int) num3 * -1616368917 ^ -1665505638;
            continue;
          case 117:
            if (allowStretching)
            {
              num1 = -1230769271;
              continue;
            }
            break;
          case 118:
            num1 = (int) num3 * -556459958 ^ -2123041637;
            continue;
          case 119:
            num1 = (int) num3 * 1325879836 ^ -542404437;
            continue;
          case 120:
            num1 = (int) num3 * 730742396 ^ 864443920;
            continue;
          case 121:
            num1 = (int) num3 * -145014926 ^ 1446435711;
            continue;
          case 122:
            flag1 = screenPlacement1 != this.Vertical;
            num1 = (int) num3 * 250058393 ^ 287784186;
            continue;
          case 123:
            if (allowStretching)
            {
              num1 = (int) num3 * -2024075289 ^ 407549510;
              continue;
            }
            goto label_131;
          case 124:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local45 = @location;
            workingArea = screen.WorkingArea;
            int num52 = workingArea.Y + size.Height / 4;
            // ISSUE: explicit reference operation
            (^local45).Y = num52;
            num1 = (int) num3 * 922682489 ^ -1216493213;
            continue;
          case 125:
            if (this.pattern.StretchingEnabled)
            {
              num1 = (int) num3 * 896972111 ^ 808957494;
              continue;
            }
            goto label_131;
          case 126:
            flag2 = false;
            num1 = -1298424273;
            continue;
          case (uint) sbyte.MaxValue:
            num1 = (int) num3 * 2041772181 ^ 106941248;
            continue;
          case 128:
            num1 = (int) num3 * 1401012845 ^ -910629699;
            continue;
          case 129:
            num1 = (int) num3 * 1691344859 ^ -1476182223;
            continue;
          case 130:
            num1 = (int) num3 * -1178039910 ^ -491931039;
            continue;
          case 131:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local46 = @location;
            workingArea = screen.WorkingArea;
            int x7 = workingArea.X;
            // ISSUE: explicit reference operation
            (^local46).X = x7;
            num1 = (int) num3 * 841545371 ^ 330271386;
            continue;
          case 132:
            num1 = (int) num3 * -788830380 ^ 1882580954;
            continue;
          case 133:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local47 = @location;
            workingArea = screen.WorkingArea;
            int num53 = workingArea.Y + size.Height;
            // ISSUE: explicit reference operation
            (^local47).Y = num53;
            num1 = (int) num3 * 845478402 ^ -529712225;
            continue;
          case 134:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local48 = @size;
            workingArea = screen.WorkingArea;
            int num54 = workingArea.Width / 4 * 3;
            // ISSUE: explicit reference operation
            (^local48).Width = num54;
            num1 = -340536413;
            continue;
          case 135:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local49 = @location;
            workingArea = screen.WorkingArea;
            int y8 = workingArea.Y;
            // ISSUE: explicit reference operation
            (^local49).Y = y8;
            num1 = (int) num3 * -1538165486 ^ -1076096096;
            continue;
          case 136:
            num1 = (int) num3 * 305737042 ^ -373036025;
            continue;
          case 137:
            num1 = (int) num3 * -378197588 ^ 1687766659;
            continue;
          case 138:
            num1 = (int) num3 * -1873083681 ^ -264763271;
            continue;
          case 140:
            flag2 = true;
            screenPlacement3 = screenPlacement4;
            num1 = -761470150;
            continue;
          case 141:
label_113:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local50 = @size;
            workingArea = screen.WorkingArea;
            int num55 = workingArea.Width / 2;
            // ISSUE: explicit reference operation
            (^local50).Width = num55;
            num1 = -438894862;
            continue;
          case 142:
            num1 = (int) num3 * -1057853809 ^ -1170571950;
            continue;
          case 143:
            screenPlacement1 = this.Vertical;
            num1 = (int) num3 * 704844584 ^ 202026235;
            continue;
          case 144:
            num1 = (int) num3 * 392515211 ^ -1529365557;
            continue;
          case 145:
label_101:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local51 = @size;
            workingArea = screen.WorkingArea;
            int num56 = workingArea.Height / 2;
            // ISSUE: explicit reference operation
            (^local51).Height = num56;
            num1 = -2040643018;
            continue;
          case 146:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local52 = @location;
            workingArea = screen.WorkingArea;
            int x8 = workingArea.X;
            // ISSUE: explicit reference operation
            (^local52).X = x8;
            num1 = (int) num3 * 629858211 ^ 623827248;
            continue;
          case 147:
            num1 = (int) num3 * 1390648821 ^ -2112631072;
            continue;
          case 148:
            num1 = (int) num3 * -1927717193 ^ -2116515007;
            continue;
          case 149:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local53 = @location;
            workingArea = screen.WorkingArea;
            int y9 = workingArea.Y;
            workingArea = screen.WorkingArea;
            int num57 = workingArea.Height / 4;
            int num58 = y9 + num57;
            // ISSUE: explicit reference operation
            (^local53).Y = num58;
            num1 = (int) num3 * 1086421663 ^ -158861084;
            continue;
          case 150:
            num1 = (int) num3 * -584346233 ^ -2064131944;
            continue;
          case 151:
            int num59 = flag4 ? 1690404464 : (num59 = 562192613);
            int num60 = (int) num3 * -35765750;
            num1 = num59 ^ num60;
            continue;
          case 152:
            size = new Size();
            num1 = (int) num3 * -883732581 ^ 722904706;
            continue;
          case 153:
label_112:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local54 = @size;
            workingArea = screen.WorkingArea;
            int num61 = workingArea.Width / 3;
            // ISSUE: explicit reference operation
            (^local54).Width = num61;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local55 = @location;
            workingArea = screen.WorkingArea;
            int x9 = workingArea.X;
            // ISSUE: explicit reference operation
            (^local55).X = x9;
            num1 = -1823416282;
            continue;
          case 154:
            num1 = (int) num3 * 934314687 ^ -1358748145;
            continue;
          case 155:
            if (this.pattern.StretchingEnabled)
            {
              num1 = (int) num3 * 747853352 ^ 1080313362;
              continue;
            }
            break;
          case 156:
            num1 = (int) num3 * 1757711906 ^ 795363082;
            continue;
          case 157:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local56 = @location;
            workingArea = screen.WorkingArea;
            int num62 = workingArea.Y + size.Height;
            // ISSUE: explicit reference operation
            (^local56).Y = num62;
            num1 = (int) num3 * 559012790 ^ 2083486249;
            continue;
          case 158:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local57 = @location;
            workingArea = screen.WorkingArea;
            int num63 = workingArea.Y + size.Height * 2;
            // ISSUE: explicit reference operation
            (^local57).Y = num63;
            num1 = (int) num3 * -1532839267 ^ -1910760479;
            continue;
          case 159:
            num1 = (int) num3 * 1475367525 ^ 671944969;
            continue;
          case 160:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local58 = @location;
            workingArea = screen.WorkingArea;
            int num64 = workingArea.X + size.Width * 2;
            // ISSUE: explicit reference operation
            (^local58).X = num64;
            num1 = (int) num3 * 1624379803 ^ -1603787227;
            continue;
          case 161:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local59 = @location;
            workingArea = screen.WorkingArea;
            int num65 = workingArea.X + size.Width;
            // ISSUE: explicit reference operation
            (^local59).X = num65;
            num1 = (int) num3 * -335040271 ^ 1358545965;
            continue;
          case 162:
            num1 = (int) num3 * 292884776 ^ -852359650;
            continue;
          case 163:
            goto label_1;
          case 164:
            num1 = (int) num3 * -1487833538 ^ 2090923727;
            continue;
          case 165:
            screenPlacement4 = this.Horizontal;
            num1 = -1772566885;
            continue;
          case 166:
label_172:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local60 = @size;
            workingArea = screen.WorkingArea;
            int num66 = workingArea.Height / 2;
            // ISSUE: explicit reference operation
            (^local60).Height = num66;
            num1 = -2020101299;
            continue;
          case 167:
label_151:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local61 = @size;
            workingArea = screen.WorkingArea;
            int num67 = workingArea.Width / 3;
            // ISSUE: explicit reference operation
            (^local61).Width = num67;
            num1 = -105786748;
            continue;
          case 168:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local62 = @location;
            workingArea = screen.WorkingArea;
            int num68 = workingArea.X + size.Width;
            // ISSUE: explicit reference operation
            (^local62).X = num68;
            num1 = (int) num3 * -207296799 ^ 445726559;
            continue;
          case 169:
            num1 = (int) num3 * 1956774884 ^ -1803480016;
            continue;
          default:
            goto label_184;
        }
        num5 = 0;
label_28:
        int num69;
        num1 = num69 = num5 != 0 ? -1407629577 : (num69 = -1680546371);
        continue;
label_131:
        num4 = 0;
label_132:
        flag4 = num4 != 0;
        num1 = -1258723819;
      }
label_184:
      return rectangle;
    }

    private bool CheckPlacementExists(ScreenPlacement placement, bool isHorizontal = true)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowLayout.\u003C\u003Ec__DisplayClass75_0 cDisplayClass750 = new WindowLayout.\u003C\u003Ec__DisplayClass75_0();
label_1:
      int num1 = 1708874797;
      bool flag1;
      while (true)
      {
        int num2 = 862014938;
        uint num3;
        bool flag2;
        ZoomWindow zoomWindow;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            flag1 = true;
            num1 = (int) num3 * -2003461472 ^ 1479982830;
            continue;
          case 1:
            num1 = (int) num3 * -1873285947 ^ -2033364348;
            continue;
          case 2:
            if (!zoomWindow.IsVisible)
            {
              num1 = (int) num3 * 1054898700 ^ 1441494736;
              continue;
            }
            num4 = 0;
            break;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass750.placement = placement;
            num1 = (int) num3 * -379923019 ^ 16496961;
            continue;
          case 4:
            num1 = (int) num3 * 197668777 ^ -769684234;
            continue;
          case 5:
            flag1 = false;
            num1 = (int) num3 * -1678204022 ^ 1001633936;
            continue;
          case 6:
            num4 = WindowHelper.IsWindowOverlapped(zoomWindow.Handle, new HashSet<IntPtr>()) ? 1 : 0;
            break;
          case 7:
            if (zoomWindow == null)
            {
              num4 = 0;
              break;
            }
            num1 = 2145747424;
            continue;
          case 8:
            // ISSUE: method pointer
            zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass750, __methodptr(\u003CCheckPlacementExists\u003Eb__0)));
            num1 = (int) num3 * -2068949570 ^ -59945525;
            continue;
          case 9:
            // ISSUE: method pointer
            zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass750, __methodptr(\u003CCheckPlacementExists\u003Eb__1)));
            num1 = 257286821;
            continue;
          case 10:
            if (zoomWindow.IsVisible)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * -14951314 ^ 1618049132;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass750.\u003C\u003E4__this = this;
            num1 = (int) num3 * -1229471006 ^ 1596648951;
            continue;
          case 13:
            goto label_1;
          case 14:
            int num5 = !flag2 ? -328302268 : (num5 = -544246714);
            int num6 = (int) num3 * -421395742;
            num1 = num5 ^ num6;
            continue;
          case 15:
            Engine instance = Engine.Instance;
            num1 = (int) num3 * -802983433 ^ 1675921266;
            continue;
          case 16:
            num1 = (int) num3 * 103190888 ^ -528527883;
            continue;
          case 17:
            int num7 = !isHorizontal ? -35626540 : (num7 = -349247495);
            int num8 = (int) num3 * -429478725;
            num1 = num7 ^ num8;
            continue;
          case 18:
            num1 = 1884053151;
            continue;
          case 19:
            num1 = (int) num3 * -1022868685 ^ 1461092844;
            continue;
          default:
            goto label_28;
        }
        flag2 = num4 != 0;
        num1 = 740639240;
      }
label_28:
      return flag1;
    }

    internal void SetPattern(LayoutPattern layoutPattern)
    {
      this.Pattern = layoutPattern;
    }

    private ScreenPlacement StretchPlacement(ScreenPlacement placement, bool isHorizontal = true)
    {
label_1:
      int num1 = 736122347;
      ScreenPlacement screenPlacement;
      while (true)
      {
        int num2 = 1786429978;
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
        bool flag17;
        bool flag18;
        bool flag19;
        bool flag20;
        bool flag21;
        bool flag22;
        bool flag23;
        bool flag24;
        bool flag25;
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
        int num18;
        int num19;
        int num20;
        switch ((num3 = (uint) (num1 ^ num2)) % 166U)
        {
          case 0:
            num1 = (int) num3 * 965924158 ^ 367675550;
            continue;
          case 1:
            num4 = !flag10 ? 1 : 0;
            goto label_131;
          case 2:
label_103:
            int num21;
            num1 = num21 = !flag3 ? 293264276 : (num21 = 924219416);
            continue;
          case 3:
            num5 = !flag7 ? 1 : 0;
            goto label_23;
          case 4:
            num1 = (int) num3 * -1989506283 ^ 20468965;
            continue;
          case 5:
            num6 = !flag10 ? 1 : 0;
            goto label_56;
          case 6:
            flag15 = !flag12 & flag3;
            num1 = 1011569035;
            continue;
          case 7:
label_141:
            if (!flag21)
            {
              num1 = 1296074240;
              continue;
            }
            goto label_22;
          case 8:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * 868566059 ^ -2066163708;
            continue;
          case 9:
            num7 = !flag12 ? 1 : 0;
            goto label_119;
          case 10:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * 213932656 ^ -703376164;
            continue;
          case 11:
            num8 = !flag7 ? 1 : 0;
            goto label_197;
          case 12:
            if (!flag10)
            {
              num1 = (int) num3 * -112070207 ^ -1775362394;
              continue;
            }
            goto label_18;
          case 13:
            int num22 = !flag17 ? -1039468676 : (num22 = -692471709);
            int num23 = (int) num3 * -1597073182;
            num1 = num22 ^ num23;
            continue;
          case 14:
            int num24 = flag23 ? 1464091900 : (num24 = 245569037);
            int num25 = (int) num3 * -1278413920;
            num1 = num24 ^ num25;
            continue;
          case 15:
            this.CheckPlacementExists(ScreenPlacement.ThirdThreeQuarter, isHorizontal);
            num1 = (int) num3 * -2093265996 ^ 944492204;
            continue;
          case 16:
            int num26 = !flag5 ? -236303273 : (num26 = -1609006630);
            int num27 = (int) num3 * -573926122;
            num1 = num26 ^ num27;
            continue;
          case 17:
            num1 = (int) num3 * -811046627 ^ 824097578;
            continue;
          case 18:
            screenPlacement = placement;
            num1 = 1410319159;
            continue;
          case 19:
            screenPlacement = ScreenPlacement.SecondTwoThirds;
            num1 = (int) num3 * -1574875747 ^ 176795863;
            continue;
          case 20:
            int num28 = !flag1 ? 1771401807 : (num28 = 75632642);
            int num29 = (int) num3 * 1347684174;
            num1 = num28 ^ num29;
            continue;
          case 21:
            num1 = (int) num3 * -1908923519 ^ 1162864888;
            continue;
          case 22:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * -1310252360 ^ 1458054286;
            continue;
          case 23:
label_72:
            screenPlacement = ScreenPlacement.Undefined;
            num1 = 1414503982;
            continue;
          case 24:
            flag12 = this.CheckPlacementExists(ScreenPlacement.SecondThird, isHorizontal);
            num1 = (int) num3 * 1825240501 ^ -1871059829;
            continue;
          case 25:
            num1 = (int) num3 * 639526679 ^ 1723844939;
            continue;
          case 26:
label_120:
            if (!flag6)
            {
              num1 = 470657986;
              continue;
            }
            goto label_196;
          case 27:
label_209:
            int num30;
            num1 = num30 = !flag10 & flag7 ? 1698172152 : (num30 = 1623481785);
            continue;
          case 28:
            int num31 = flag2 ? -1344170279 : (num31 = -306313892);
            int num32 = (int) num3 * 1564513114;
            num1 = num31 ^ num32;
            continue;
          case 29:
            int num33 = !flag20 ? 1343488123 : (num33 = 1117445826);
            int num34 = (int) num3 * 2077860557;
            num1 = num33 ^ num34;
            continue;
          case 30:
            screenPlacement = ScreenPlacement.SecondHalf;
            num1 = (int) num3 * -299430073 ^ 1326895243;
            continue;
          case 31:
            if (flag12)
            {
              num10 = 0;
              goto label_75;
            }
            else
            {
              num1 = 440467934;
              continue;
            }
          case 32:
            num1 = (int) num3 * -966785101 ^ 884522104;
            continue;
          case 33:
            num11 = !flag7 ? 1 : 0;
            goto label_146;
          case 34:
label_14:
            if (!flag6)
            {
              num1 = 2082495699;
              continue;
            }
            goto label_153;
          case 35:
            int num35 = !flag4 ? -1589889461 : (num35 = -1626803550);
            int num36 = (int) num3 * 1925612642;
            num1 = num35 ^ num36;
            continue;
          case 36:
            int num37 = flag13 ? 1103782756 : (num37 = 1334190261);
            int num38 = (int) num3 * -1174518562;
            num1 = num37 ^ num38;
            continue;
          case 37:
            screenPlacement = placement;
            num1 = (int) num3 * 763370979 ^ -1938917957;
            continue;
          case 38:
            if (!flag10)
            {
              num1 = (int) num3 * -321005119 ^ -1736385377;
              continue;
            }
            goto label_22;
          case 39:
            int num39 = !flag15 ? -1407835836 : (num39 = -886275053);
            int num40 = (int) num3 * -1748896439;
            num1 = num39 ^ num40;
            continue;
          case 40:
            num10 = !flag3 ? 1 : 0;
            goto label_75;
          case 41:
            flag23 = !flag18 & flag3;
            num1 = 462778014;
            continue;
          case 42:
            int num41 = !flag25 ? 1215769168 : (num41 = 313944527);
            int num42 = (int) num3 * 1844086765;
            num1 = num41 ^ num42;
            continue;
          case 43:
            screenPlacement = ScreenPlacement.ThreeQuarters;
            num1 = (int) num3 * -1322443256 ^ 775880254;
            continue;
          case 44:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * 591235082 ^ -366887898;
            continue;
          case 45:
            screenPlacement = ScreenPlacement.FirstHalf;
            num1 = (int) num3 * 331343002 ^ -547784688;
            continue;
          case 46:
            this.CheckPlacementExists(ScreenPlacement.FirstTwoThirds, isHorizontal);
            num1 = (int) num3 * 1512514305 ^ 1974793578;
            continue;
          case 47:
            flag13 = !flag6 & flag10;
            num1 = 218910860;
            continue;
          case 48:
            num1 = (int) num3 * -656301816 ^ 919191343;
            continue;
          case 49:
            num1 = (int) num3 * -225557281 ^ -1299616516;
            continue;
          case 50:
            screenPlacement = placement;
            num1 = 1040387977;
            continue;
          case 51:
            int num43 = flag22 ? -662089853 : (num43 = -2059393707);
            int num44 = (int) num3 * -1625973876;
            num1 = num43 ^ num44;
            continue;
          case 52:
label_64:
            if (!flag6)
            {
              num1 = 1240091785;
              continue;
            }
            num11 = 0;
            goto label_146;
          case 53:
label_150:
            screenPlacement = ScreenPlacement.Full;
            num1 = 1212523421;
            continue;
          case 54:
            this.CheckPlacementExists(ScreenPlacement.SecondThreeQuarters, isHorizontal);
            flag10 = this.CheckPlacementExists(ScreenPlacement.ThirdQuarter, isHorizontal);
            num1 = (int) num3 * -11776096 ^ 316744893;
            continue;
          case 55:
            screenPlacement = ScreenPlacement.SecondHalf;
            num1 = (int) num3 * -1231977681 ^ -1290327565;
            continue;
          case 56:
            num13 = !flag7 ? 1 : 0;
            goto label_45;
          case 57:
            num14 = !flag7 ? 1 : 0;
            goto label_30;
          case 58:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * -1505093964 ^ 1545369534;
            continue;
          case 59:
          case 64:
            screenPlacement = ScreenPlacement.Undefined;
            num1 = 1267730022;
            continue;
          case 60:
            if (!flag21)
            {
              num1 = 1229147341;
              continue;
            }
            num15 = 0;
            goto label_217;
          case 61:
            num1 = (int) num3 * -720024280 ^ -1836700146;
            continue;
          case 62:
            goto label_1;
          case 63:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * -118698483 ^ -1014369239;
            continue;
          case 65:
            num1 = (int) num3 * 1557976708 ^ 261718138;
            continue;
          case 66:
            num1 = 211292370;
            continue;
          case 67:
            screenPlacement = ScreenPlacement.SecondThreeQuarters;
            num1 = (int) num3 * -1685239062 ^ -1479398592;
            continue;
          case 68:
label_96:
            flag2 = !flag18;
            num1 = 1572579846;
            continue;
          case 69:
            screenPlacement = placement;
            num1 = (int) num3 * 251986722 ^ 479509157;
            continue;
          case 70:
            num1 = (int) num3 * -1527794105 ^ 154158282;
            continue;
          case 71:
            num15 = !flag10 ? 1 : 0;
            goto label_217;
          case 72:
            screenPlacement = ScreenPlacement.FirstTwoThirds;
            num1 = (int) num3 * 1204981590 ^ 1584048846;
            continue;
          case 73:
            num1 = (int) num3 * 48791793 ^ 2139249018;
            continue;
          case 75:
            int num45;
            num1 = num45 = flag21 ? 197238672 : (num45 = 457788187);
            continue;
          case 76:
            int num46 = flag9 ? 686260876 : (num46 = 2077798695);
            int num47 = (int) num3 * -71856299;
            num1 = num46 ^ num47;
            continue;
          case 77:
            num1 = (int) num3 * 392272545 ^ -1706558870;
            continue;
          case 78:
label_78:
            if (!flag18)
            {
              num1 = 1375630878;
              continue;
            }
            num16 = 0;
            goto label_124;
          case 79:
            int num48 = !flag8 ? -846742853 : (num48 = -713929966);
            int num49 = (int) num3 * 861020452;
            num1 = num48 ^ num49;
            continue;
          case 80:
            num1 = (int) num3 * 2004784036 ^ -1138895856;
            continue;
          case 81:
            flag14 = !flag6 & flag7;
            num1 = 1071994834;
            continue;
          case 82:
label_193:
            if (flag18)
            {
              num17 = 0;
              break;
            }
            num1 = 577369907;
            continue;
          case 83:
            if (flag18)
            {
              num1 = 78847856;
              continue;
            }
            num18 = 0;
            goto label_178;
          case 84:
            num1 = (int) num3 * -257339228 ^ 311739158;
            continue;
          case 85:
            num1 = (int) num3 * -1386614401 ^ 959035603;
            continue;
          case 86:
            num1 = (int) num3 * 660049384 ^ -266225138;
            continue;
          case 87:
            num1 = (int) num3 * 2122371162 ^ -390667572;
            continue;
          case 88:
            screenPlacement = placement;
            num1 = (int) num3 * 891832378 ^ 631480190;
            continue;
          case 89:
            screenPlacement = ScreenPlacement.FirstThird;
            num1 = (int) num3 * 1720226501 ^ 283317325;
            continue;
          case 90:
            num1 = (int) num3 * -1559624885 ^ -1738399044;
            continue;
          case 91:
            num19 = !flag21 ? 1 : 0;
            goto label_205;
          case 92:
            int num50 = flag14 ? 2101673024 : (num50 = 495369587);
            int num51 = (int) num3 * 246939970;
            num1 = num50 ^ num51;
            continue;
          case 93:
label_198:
            if (!flag6)
            {
              num1 = 162697897;
              continue;
            }
            num19 = 0;
            goto label_205;
          case 94:
            num1 = (int) num3 * 1178988934 ^ -1546659766;
            continue;
          case 95:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * -1732227042 ^ 766511600;
            continue;
          case 96:
            num18 = !flag3 ? 1 : 0;
            goto label_178;
          case 97:
            flag18 = this.CheckPlacementExists(ScreenPlacement.FirstThird, isHorizontal);
            num1 = (int) num3 * 477128535 ^ 1216696265;
            continue;
          case 98:
            num1 = (int) num3 * -482840580 ^ -1159101490;
            continue;
          case 99:
            screenPlacement = ScreenPlacement.FirstThreeQuarters;
            num1 = (int) num3 * -923994368 ^ -535827154;
            continue;
          case 100:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * -1166265615 ^ 762193792;
            continue;
          case 101:
            if (!flag6)
            {
              num4 = 0;
              goto label_131;
            }
            else
            {
              num1 = 1914903605;
              continue;
            }
          case 102:
            num1 = 51089571;
            continue;
          case 103:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * 1889466786 ^ -1645313241;
            continue;
          case 104:
            num1 = 1673929471;
            continue;
          case 105:
            screenPlacement = placement;
            num1 = 1782243614;
            continue;
          case 106:
            num20 = !flag7 ? 1 : 0;
            goto label_34;
          case 107:
            screenPlacement = ScreenPlacement.FirstThreeQuarters;
            num1 = (int) num3 * 1561462201 ^ -306142967;
            continue;
          case 108:
            int num52 = flag24 ? 1135940701 : (num52 = 676454876);
            int num53 = (int) num3 * -130461770;
            num1 = num52 ^ num53;
            continue;
          case 109:
            screenPlacement = placement;
            num1 = 1414503982;
            continue;
          case 110:
            num1 = (int) num3 * 469891048 ^ 276783295;
            continue;
          case 111:
            if (flag18)
            {
              num1 = 119815469;
              continue;
            }
            num7 = 0;
            goto label_119;
          case 112:
            if (!flag21)
            {
              num1 = (int) num3 * 874008561 ^ 276681397;
              continue;
            }
            goto label_196;
          case 113:
            num1 = (int) num3 * 716454280 ^ -2005148675;
            continue;
          case 114:
            num1 = (int) num3 * -10003040 ^ 63758446;
            continue;
          case 115:
            num1 = 1647396925;
            continue;
          case 116:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * -149674735 ^ -2062292075;
            continue;
          case 117:
            num1 = (int) num3 * 698335591 ^ 1346565003;
            continue;
          case 118:
            num1 = (int) num3 * 1026318302 ^ 973267996;
            continue;
          case 119:
            if (!flag6)
            {
              num14 = 0;
              goto label_30;
            }
            else
            {
              num1 = 1209073353;
              continue;
            }
          case 120:
label_83:
            if (!flag6)
            {
              num1 = 1828530752;
              continue;
            }
            goto label_18;
          case 121:
            num1 = (int) num3 * 40578323 ^ -806321439;
            continue;
          case 122:
            if (!flag21)
            {
              num6 = 0;
              goto label_56;
            }
            else
            {
              num1 = 1596101391;
              continue;
            }
          case 123:
            int num54 = flag11 ? -1634603760 : (num54 = -982886575);
            int num55 = (int) num3 * -147184015;
            num1 = num54 ^ num55;
            continue;
          case 124:
            screenPlacement = placement;
            num1 = 2097818061;
            continue;
          case 125:
            num1 = (int) num3 * -1693194595 ^ -1194555419;
            continue;
          case 126:
            num1 = (int) num3 * 356424288 ^ 264365230;
            continue;
          case (uint) sbyte.MaxValue:
            num1 = (int) num3 * 611816108 ^ -806549499;
            continue;
          case 128:
            num1 = (int) num3 * 1103947688 ^ 2086882126;
            continue;
          case 129:
            this.CheckPlacementExists(ScreenPlacement.SecondTwoThirds, isHorizontal);
            num1 = (int) num3 * 81447669 ^ 85507197;
            continue;
          case 130:
            num9 = !flag7 ? 1 : 0;
            goto label_19;
          case 131:
            num1 = (int) num3 * 718487761 ^ 1377096873;
            continue;
          case 132:
            int num56 = flag16 ? 1646367878 : (num56 = 1430477158);
            int num57 = (int) num3 * 83665994;
            num1 = num56 ^ num57;
            continue;
          case 133:
            if (!flag21)
            {
              num13 = 0;
              goto label_45;
            }
            else
            {
              num1 = 438445422;
              continue;
            }
          case 134:
            num12 = !flag10 ? 1 : 0;
            goto label_154;
          case 135:
            num1 = (int) num3 * 530840279 ^ -1024873893;
            continue;
          case 136:
            flag7 = this.CheckPlacementExists(ScreenPlacement.FourthQuarter, isHorizontal);
            switch (placement)
            {
              case ScreenPlacement.Undefined:
                goto label_72;
              case ScreenPlacement.FirstHalf:
                goto label_209;
              case ScreenPlacement.SecondHalf:
                goto label_198;
              case ScreenPlacement.FirstThird:
                goto label_49;
              case ScreenPlacement.FirstTwoThirds:
                goto label_103;
              case ScreenPlacement.SecondThird:
                goto label_193;
              case ScreenPlacement.SecondTwoThirds:
                goto label_96;
              case ScreenPlacement.ThirdThird:
                goto label_78;
              case ScreenPlacement.FirstQuarter:
                goto label_141;
              case ScreenPlacement.SecondQuarter:
                goto label_83;
              case ScreenPlacement.SecondTwoQuarters:
                goto label_64;
              case ScreenPlacement.ThirdQuarter:
                goto label_120;
              case ScreenPlacement.FourthQuarter:
                goto label_14;
              case ScreenPlacement.Full:
                goto label_150;
              default:
                num1 = (int) num3 * -1530861571 ^ 522170903;
                continue;
            }
          case 137:
            num1 = (int) num3 * 1091851338 ^ -247869013;
            continue;
          case 138:
            screenPlacement = ScreenPlacement.FirstTwoThirds;
            num1 = (int) num3 * -537851696 ^ -302342962;
            continue;
          case 139:
            num1 = (int) num3 * 2017373269 ^ -1899008897;
            continue;
          case 140:
            flag3 = this.CheckPlacementExists(ScreenPlacement.ThirdThird, isHorizontal);
            flag6 = this.CheckPlacementExists(ScreenPlacement.FirstQuarter, isHorizontal);
            this.CheckPlacementExists(ScreenPlacement.FirstThreeQuarters, isHorizontal);
            flag21 = this.CheckPlacementExists(ScreenPlacement.SecondQuarter, isHorizontal);
            this.CheckPlacementExists(ScreenPlacement.SecondTwoQuarters, isHorizontal);
            num1 = (int) num3 * 797689712 ^ 1954561076;
            continue;
          case 141:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * 1898872755 ^ -2025005002;
            continue;
          case 142:
            int num58 = !flag19 ? 1567936259 : (num58 = 1802910399);
            int num59 = (int) num3 * 1767007600;
            num1 = num58 ^ num59;
            continue;
          case 143:
            num17 = !flag3 ? 1 : 0;
            break;
          case 144:
            num1 = (int) num3 * -1100431612 ^ 191421278;
            continue;
          case 145:
            screenPlacement = ScreenPlacement.SecondTwoQuarters;
            num1 = (int) num3 * -89661309 ^ 1130416609;
            continue;
          case 146:
            screenPlacement = placement;
            num1 = 46739353;
            continue;
          case 147:
            screenPlacement = placement;
            num1 = (int) num3 * 32675075 ^ 1226062597;
            continue;
          case 148:
            num1 = (int) num3 * 1939966783 ^ -536848430;
            continue;
          case 149:
            if (!flag21)
            {
              num1 = (int) num3 * 2002468138 ^ 169358406;
              continue;
            }
            goto label_153;
          case 150:
            screenPlacement = ScreenPlacement.Full;
            num1 = (int) num3 * 1933141752 ^ -184048482;
            continue;
          case 151:
            num1 = (int) num3 * -2132443894 ^ 1540378708;
            continue;
          case 152:
            num1 = (int) num3 * -1696270881 ^ 1500000987;
            continue;
          case 153:
            screenPlacement = ScreenPlacement.SecondTwoThirds;
            num1 = (int) num3 * -258283874 ^ 1269939584;
            continue;
          case 154:
label_49:
            flag11 = flag12 & flag3;
            num1 = 502365839;
            continue;
          case 155:
            if (flag10)
            {
              num20 = 0;
              goto label_34;
            }
            else
            {
              num1 = 95203302;
              continue;
            }
          case 156:
            screenPlacement = ScreenPlacement.SecondTwoQuarters;
            num1 = (int) num3 * 141091951 ^ -1946631702;
            continue;
          case 157:
            flag20 = !flag21;
            num1 = 1814971165;
            continue;
          case 158:
            screenPlacement = placement;
            num1 = 1146388832;
            continue;
          case 159:
            num1 = (int) num3 * 447640070 ^ -1147826400;
            continue;
          case 160:
            int num60;
            num1 = num60 = !flag6 ? 1321314213 : (num60 = 1530639963);
            continue;
          case 161:
            flag8 = !flag21 & flag7;
            num1 = 978730223;
            continue;
          case 162:
            screenPlacement = ScreenPlacement.FirstHalf;
            num1 = (int) num3 * 1240524479 ^ 1995364693;
            continue;
          case 163:
            screenPlacement = ScreenPlacement.SecondThreeQuarters;
            num1 = (int) num3 * -1220507459 ^ -1057519406;
            continue;
          case 164:
            num16 = !flag12 ? 1 : 0;
            goto label_124;
          case 165:
            screenPlacement = ScreenPlacement.FirstThreeQuarters;
            num1 = (int) num3 * 1684158961 ^ -1988111903;
            continue;
          default:
            goto label_222;
        }
        flag4 = num17 != 0;
        num1 = 1057658943;
        continue;
label_18:
        num9 = 0;
label_19:
        flag5 = num9 != 0;
        num1 = 1987755136;
        continue;
label_22:
        num5 = 0;
label_23:
        int num61;
        num1 = num61 = num5 != 0 ? 1193718194 : (num61 = 133374322);
        continue;
label_30:
        int num62;
        num1 = num62 = num14 == 0 ? 565492582 : (num62 = 1253949891);
        continue;
label_34:
        flag9 = num20 != 0;
        num1 = 1612140094;
        continue;
label_45:
        int num63;
        num1 = num63 = num13 != 0 ? 1126850790 : (num63 = 904178341);
        continue;
label_56:
        int num64;
        num1 = num64 = num6 != 0 ? 515894753 : (num64 = 1548232449);
        continue;
label_75:
        flag17 = num10 != 0;
        num1 = 292418057;
        continue;
label_119:
        int num65;
        num1 = num65 = num7 != 0 ? 79045511 : (num65 = 278561522);
        continue;
label_124:
        int num66;
        num1 = num66 = num16 != 0 ? 1847552356 : (num66 = 770021737);
        continue;
label_131:
        int num67 = flag7 ? 1 : 0;
        int num68;
        num1 = num68 = (num4 & num67) == 0 ? 1215051182 : (num68 = 195966918);
        continue;
label_146:
        flag24 = num11 != 0;
        num1 = 1188501688;
        continue;
label_153:
        num12 = 0;
label_154:
        flag25 = num12 != 0;
        num1 = 290676616;
        continue;
label_178:
        flag16 = num18 != 0;
        num1 = 643489656;
        continue;
label_196:
        num8 = 0;
label_197:
        flag22 = num8 != 0;
        num1 = 1553554503;
        continue;
label_205:
        flag1 = num19 != 0;
        num1 = 2094737562;
        continue;
label_217:
        flag19 = num15 != 0;
        num1 = 1786685812;
      }
label_222:
      return screenPlacement;
    }

    static bool \u200D‌⁯​‍‎⁬⁫‪‮‫‏‫⁪‮‫‭⁮⁪‏‪⁬‪‭⁯‫⁮‌‫‏‮⁭‍⁬⁯⁫​‭⁬‍‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static void \u206D⁫‎‭‬‮⁬⁬‏‎‌‫⁪‏‫‎‎⁭⁯‭⁮‏‍⁬‌‭⁫‫‮⁫‎⁬⁪‫⁭⁬⁯⁯⁪‍‮([In] object obj0, [In] ref bool obj1)
    {
      System.Threading.Monitor.Enter(obj0, ref obj1);
    }

    static void \u206D⁪‮‍⁭⁫⁪‪‏‪⁭‬⁮‎‪⁮⁬⁪​‭‮‮⁪⁭⁫‬‬‭‫​‎⁪‏⁪​‪⁫‪‏‭‮([In] object obj0)
    {
      System.Threading.Monitor.Exit(obj0);
    }

    static bool \u200F‌‪‮‬⁯‭‍​⁪⁮‌⁯‍‭⁭⁭⁮‎⁭⁯‬⁭‪⁭⁪‫​⁯‫⁬‬⁫⁫⁭‪⁯⁭‭‏‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static bool \u200C⁯‍‍‮⁯‎‎‏‮‭⁪‮‍‮‍‬⁬​⁬⁭‭‬​‎‪⁫‫⁫‬⁭‎⁯‎‎‎⁪‭‫⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static Screen[] \u202E⁫‪‪‭‏⁬⁮‭⁮‌⁬⁬⁬⁪‪⁬⁯‭⁭‏‍​‪‬⁬‭‪⁭​‮⁪‮‬‬‪‬‌‫⁯‮()
    {
      return Screen.AllScreens;
    }

    static string \u202E‮‮‌‮⁭⁯‭⁬‎‎‭​‌⁫​‏‍​⁯⁭⁬‬⁮‪⁮‎⁮‮‏⁭‭‮‮⁫‍‬⁮⁫‍‮([In] Screen obj0)
    {
      return obj0.DeviceName;
    }

    static string \u200B⁯⁪⁮⁫⁫‫‮⁭‮‍‪⁭⁬⁬⁫‫‌⁮⁮‪​‪⁬⁮⁭‪‌⁯‪⁯‍‏‎‫‌‎⁯⁫‎‮([In] string obj0)
    {
      return obj0.ToUpper();
    }

    static Screen \u200E‌‪⁭⁪‪⁪⁭‬⁯⁯⁮⁫‪⁫‏‫‏‌‬⁭⁪‮‫‪⁭⁫⁬​‎‏⁭‏‪‌‬‏‫⁪⁮‮()
    {
      return Screen.PrimaryScreen;
    }

    static object \u200C​‏‬‎​⁮‍⁫⁮⁪‫⁪‌​⁪‪‬‬‍⁬‮‭‌⁭‎​⁮⁬‏⁮‏⁭‍⁬‍‏‭‏⁯‮()
    {
      return new object();
    }
  }
}
