// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.WindowManagementViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using Telerik.Windows.Controls;
using ZoomZoom.Common;
using ZoomZoom.Models.Events;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  public class WindowManagementViewModel : ViewModelBase
  {
    private LayoutEditorView layoutEditorView = (LayoutEditorView) null;
    private LockedObservableCollection<LayoutPattern> patterns = (LockedObservableCollection<LayoutPattern>) null;
    private bool hasSecondMonitor = false;
    private LockedObservableCollection<ZoomWindow> windows = (LockedObservableCollection<ZoomWindow>) null;
    private ZoomWindow selectedWindow = (ZoomWindow) null;
    private LayoutPattern activePattern = (LayoutPattern) null;
    private HighlightInfo highlightTarget = (HighlightInfo) null;
    private LayoutPattern selectedPattern;

    public bool OpenManyCamWhenNotOpen
    {
      get
      {
label_1:
        int num1 = -1718347046;
        bool manyCamWhenNotOpen;
        while (true)
        {
          int num2 = -87529513;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 333295504 ^ 1557702064;
              continue;
            case 1:
              manyCamWhenNotOpen = Engine.Instance.Settings.OpenManyCamWhenNotOpen;
              num1 = (int) num3 * -1940803513 ^ 162748156;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return manyCamWhenNotOpen;
      }
      set
      {
        bool flag = Engine.Instance.Settings.OpenManyCamWhenNotOpen == value;
label_1:
        int num1 = -965755269;
        while (true)
        {
          int num2 = -894727977;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = flag ? -1021140286 : (num4 = -1794026133);
              int num5 = (int) num3 * 1575434275;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * -404001358 ^ -1397818305;
              continue;
            case 3:
              Engine.Instance.Settings.OpenManyCamWhenNotOpen = value;
              num1 = -356770614;
              continue;
            case 4:
              num1 = (int) num3 * 826763991 ^ 1291426080;
              continue;
            case 5:
              goto label_3;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4149115418U));
              num1 = (int) num3 * -1463946902 ^ 318650158;
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

    public bool OpenManyCamBroadcastWhenNotOpen
    {
      get
      {
label_1:
        int num1 = 570794386;
        bool broadcastWhenNotOpen;
        while (true)
        {
          int num2 = 509643891;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1578642624 ^ -85028684;
              continue;
            case 1:
              broadcastWhenNotOpen = Engine.Instance.Settings.OpenManyCamBroadcastWhenNotOpen;
              num1 = (int) num3 * -1043671080 ^ -1677969449;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return broadcastWhenNotOpen;
      }
      set
      {
label_1:
        int num1 = -1251823066;
        while (true)
        {
          int num2 = -461745060;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = flag ? 662751760 : (num4 = 2035395509);
              int num5 = (int) num3 * -1530545718;
              num1 = num4 ^ num5;
              continue;
            case 2:
              flag = Engine.Instance.Settings.OpenManyCamBroadcastWhenNotOpen == value;
              num1 = (int) num3 * 724873392 ^ -1701297571;
              continue;
            case 3:
              Engine.Instance.Settings.OpenManyCamBroadcastWhenNotOpen = value;
              num1 = -599286605;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * 1810989096 ^ -763161116;
              continue;
            case 6:
              num1 = (int) num3 * 363588115 ^ -989566690;
              continue;
            case 7:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2895535407U));
              num1 = (int) num3 * -944875919 ^ 606514582;
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

    public string PrimaryScreen
    {
      get
      {
        string primaryScreen = Engine.Instance.Settings.PrimaryScreen;
label_1:
        int num1 = 1975315008;
        while (true)
        {
          int num2 = 524915162;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 814059961 ^ 139687293;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return primaryScreen;
      }
      set
      {
label_1:
        int num1 = 22183092;
        while (true)
        {
          int num2 = 1643781302;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -23835019 ^ 640763979;
              continue;
            case 2:
              int num4 = WindowManagementViewModel.\u200B⁯⁬‎​⁪⁫‏⁮⁫‏⁭‬⁯‌⁫‫‬‌‬‍‭‭‮⁭⁬⁪⁯‪⁭⁮⁫‍‭‬⁫‪​​‪‮(Engine.Instance.Settings.PrimaryScreen, value) ? -407374343 : (num4 = -1753497354);
              int num5 = (int) num3 * 1130747491;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(623955114U));
              num1 = (int) num3 * 423061991 ^ -1719651217;
              continue;
            case 4:
              Engine.Instance.Settings.PrimaryScreen = value;
              num1 = 1458812905;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public string SecondaryScreen
    {
      get
      {
label_1:
        int num1 = -576686317;
        string secondaryScreen;
        while (true)
        {
          int num2 = -325510395;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              secondaryScreen = Engine.Instance.Settings.SecondaryScreen;
              num1 = (int) num3 * 1207724781 ^ 953057864;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return secondaryScreen;
      }
      set
      {
label_1:
        int num1 = -2105206115;
        while (true)
        {
          int num2 = -267689719;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * 1686881805 ^ 1915288136;
              continue;
            case 1:
              goto label_3;
            case 2:
              Engine.Instance.Settings.SecondaryScreen = value;
              num1 = -1103617402;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(187806918U));
              num1 = (int) num3 * 1536452912 ^ 1186893840;
              continue;
            case 4:
              flag = WindowManagementViewModel.\u200B⁯⁬‎​⁪⁫‏⁮⁫‏⁭‬⁯‌⁫‫‬‌‬‍‭‭‮⁭⁬⁪⁯‪⁭⁮⁫‍‭‬⁫‪​​‪‮(Engine.Instance.Settings.SecondaryScreen, value);
              num1 = (int) num3 * 1328055972 ^ 84978900;
              continue;
            case 5:
              int num4 = !flag ? 1895643617 : (num4 = 1895914427);
              int num5 = (int) num3 * -1110614590;
              num1 = num4 ^ num5;
              continue;
            case 6:
              goto label_1;
            case 7:
              num1 = (int) num3 * -1710318108 ^ 711024862;
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

    public bool EnableStretching
    {
      get
      {
        bool flag1 = this.Engine.ActivePattern != null;
label_1:
        int num1 = -641453485;
        bool flag2;
        while (true)
        {
          int num2 = -1422620758;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1104719329 ^ 1247659585;
              continue;
            case 2:
              flag2 = this.Engine.ActivePattern.StretchingEnabled;
              num1 = (int) num3 * -261713836 ^ 1938968381;
              continue;
            case 4:
              num1 = (int) num3 * -1335720258 ^ -1802344655;
              continue;
            case 5:
              flag2 = false;
              num1 = -1329881080;
              continue;
            case 6:
              int num4 = !flag1 ? -1404957825 : (num4 = -1433426273);
              int num5 = (int) num3 * 1009443741;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return flag2;
      }
      set
      {
label_1:
        int num1 = -77046116;
        while (true)
        {
          int num2 = -767672920;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2857694724U));
              num1 = -908006849;
              continue;
            case 2:
              this.Engine.ActivePattern.StretchingEnabled = value;
              num1 = (int) num3 * -1440115870 ^ 114266352;
              continue;
            case 3:
              int num4 = this.Engine.ActivePattern != null ? 585550319 : (num4 = 2010745666);
              int num5 = (int) num3 * 1401483681;
              num1 = num4 ^ num5;
              continue;
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

    public bool ApplyLayoutPattern
    {
      get
      {
label_1:
        int num1 = -620998960;
        bool applyLayoutPattern;
        while (true)
        {
          int num2 = -1805027093;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 508428914 ^ -1514618769;
              continue;
            case 3:
              applyLayoutPattern = Engine.Instance.Settings.ApplyLayoutPattern;
              num1 = (int) num3 * -1144625219 ^ -941095231;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return applyLayoutPattern;
      }
      set
      {
label_1:
        int num1 = -277203038;
        while (true)
        {
          int num2 = -1671274940;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              Engine.Instance.Settings.ApplyLayoutPattern = value;
              num1 = -1833154042;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3134813295U));
              num1 = (int) num3 * -77105300 ^ -1316245095;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -974127939 ^ -1305888483;
              continue;
            case 5:
              num1 = (int) num3 * 589743587 ^ -630120758;
              continue;
            case 6:
              flag = Engine.Instance.Settings.ApplyLayoutPattern == value;
              num1 = (int) num3 * 1223248507 ^ -1407733540;
              continue;
            case 7:
              int num4 = !flag ? -2088503997 : (num4 = -29671043);
              int num5 = (int) num3 * 1792427513;
              num1 = num4 ^ num5;
              continue;
            case 8:
              num1 = (int) num3 * 375797030 ^ -2050932493;
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

    public LayoutPattern ActivePattern
    {
      get
      {
label_1:
        int num1 = -871967296;
        LayoutPattern activePattern;
        while (true)
        {
          int num2 = -375215566;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              activePattern = this.activePattern;
              num1 = (int) num3 * -77838481 ^ -94625261;
              continue;
            case 3:
              num1 = (int) num3 * -1880737030 ^ 1061939301;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activePattern;
      }
      set
      {
label_1:
        int num1 = 1102453609;
        while (true)
        {
          int num2 = 789525047;
          uint num3;
          bool flag1;
          bool flag2;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 17U)
          {
            case 0:
              this.activePattern.PropertyChanged -= new PropertyChangedEventHandler(this.ActivePattern_PropertyChanged);
              num1 = (int) num3 * 46733584 ^ -1580687565;
              continue;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -486392552 ^ -243982581;
              continue;
            case 3:
              this.activePattern = value;
              flag1 = this.activePattern != null;
              num1 = 1261373926;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(623854669U));
              num1 = 40612474;
              continue;
            case 5:
              flag3 = this.activePattern == value;
              num1 = (int) num3 * -185614690 ^ -1078251430;
              continue;
            case 6:
              num1 = (int) num3 * -1118042990 ^ -1211060547;
              continue;
            case 7:
              goto label_1;
            case 8:
              int num4 = flag3 ? -1616561476 : (num4 = -1886857934);
              int num5 = (int) num3 * 1004788492;
              num1 = num4 ^ num5;
              continue;
            case 9:
              int num6 = !flag1 ? 1537483346 : (num6 = 586825601);
              int num7 = (int) num3 * -1526458745;
              num1 = num6 ^ num7;
              continue;
            case 10:
              num1 = (int) num3 * 433980744 ^ -1280379900;
              continue;
            case 11:
              flag2 = this.activePattern != null;
              num1 = 1729555190;
              continue;
            case 12:
              num1 = (int) num3 * 253919233 ^ 2108724683;
              continue;
            case 13:
              int num8 = flag2 ? 1143858090 : (num8 = 396517379);
              int num9 = (int) num3 * 2027678051;
              num1 = num8 ^ num9;
              continue;
            case 14:
              num1 = (int) num3 * 1788754820 ^ 1207778454;
              continue;
            case 15:
              this.activePattern.PropertyChanged -= new PropertyChangedEventHandler(this.ActivePattern_PropertyChanged);
              num1 = (int) num3 * 798284406 ^ 250505459;
              continue;
            case 16:
              num1 = (int) num3 * -1814006457 ^ -1528577620;
              continue;
            default:
              goto label_19;
          }
        }
label_19:
        return;
label_3:;
      }
    }

    public LayoutPattern SelectedPattern
    {
      get
      {
label_1:
        int num1 = 152447551;
        LayoutPattern selectedPattern;
        while (true)
        {
          int num2 = 1924669278;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              selectedPattern = this.selectedPattern;
              num1 = (int) num3 * 2086063488 ^ 1813177908;
              continue;
            case 2:
              num1 = (int) num3 * -102210502 ^ 1553731338;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return selectedPattern;
      }
      set
      {
label_1:
        int num1 = 609288482;
        while (true)
        {
          int num2 = 1943825155;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -480576822 ^ 1360521407;
              continue;
            case 1:
              int num4 = this.selectedPattern == value ? 2058263628 : (num4 = 1496543801);
              int num5 = (int) num3 * -423884601;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 329951190 ^ 1182163463;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.selectedPattern = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1615543007U));
              num1 = 109072640;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1900141010U));
              num1 = (int) num3 * -1323821622 ^ -1099550720;
              continue;
            case 7:
              num1 = (int) num3 * 735972667 ^ -1411096406;
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

    public LayoutEditorView LayoutEditorView
    {
      get
      {
label_1:
        int num1 = -718017280;
        LayoutEditorView layoutEditorView;
        while (true)
        {
          int num2 = -1989765755;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              layoutEditorView = this.layoutEditorView;
              num1 = (int) num3 * 1708276273 ^ -1388957522;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return layoutEditorView;
      }
      set
      {
label_1:
        int num1 = 2139164238;
        while (true)
        {
          int num2 = 1377503056;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.layoutEditorView = value;
              num1 = (int) num3 * -1475475003 ^ -613042095;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(298147027U));
              num1 = (int) num3 * 1451432915 ^ 293767288;
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

    public LockedObservableCollection<LayoutPattern> Patterns
    {
      get
      {
        LockedObservableCollection<LayoutPattern> patterns = this.patterns;
label_1:
        int num1 = -1188400674;
        while (true)
        {
          int num2 = -1911458733;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1558139079 ^ -2062204084;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return patterns;
      }
      set
      {
label_1:
        int num1 = 1267323400;
        while (true)
        {
          int num2 = 1946683111;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.patterns = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2388334570U));
              num1 = (int) num3 * -175495444 ^ 1317149465;
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

    public bool HasSecondMonitor
    {
      get
      {
        bool hasSecondMonitor = this.hasSecondMonitor;
label_1:
        int num1 = -2010879403;
        while (true)
        {
          int num2 = -154502443;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 643533822 ^ -1818279691;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return hasSecondMonitor;
      }
      set
      {
label_1:
        int num1 = -609659406;
        while (true)
        {
          int num2 = -1761273331;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.hasSecondMonitor = value;
              num1 = (int) num3 * 1818540716 ^ 1754152687;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2463725544U));
              num1 = (int) num3 * 800430195 ^ -1967345546;
              continue;
            case 4:
              num1 = (int) num3 * 621295354 ^ 1221240969;
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

    public LockedObservableCollection<ZoomWindow> Windows
    {
      get
      {
        LockedObservableCollection<ZoomWindow> windows = this.windows;
label_1:
        int num1 = 812600190;
        while (true)
        {
          int num2 = 751198071;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 539589870 ^ -826396433;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windows;
      }
      set
      {
label_1:
        int num1 = 2139027297;
        while (true)
        {
          int num2 = 1494942572;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.windows = value;
              num1 = (int) num3 * 1666702581 ^ 1283817067;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 979785120 ^ 1839032372;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3983670365U));
              num1 = (int) num3 * 889080813 ^ -327739785;
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

    public ZoomWindow SelectedWindow
    {
      get
      {
        ZoomWindow selectedWindow = this.selectedWindow;
label_1:
        int num1 = -1226562171;
        while (true)
        {
          int num2 = -34849713;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1308701223 ^ 1597180784;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedWindow;
      }
      set
      {
        this.selectedWindow = value;
label_1:
        int num1 = 469057854;
        while (true)
        {
          int num2 = 796934910;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1234029448U));
              num1 = (int) num3 * 1925711323 ^ -1486880161;
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

    public HighlightInfo HighlightTarget
    {
      get
      {
        HighlightInfo highlightTarget = this.highlightTarget;
label_1:
        int num1 = -483040787;
        while (true)
        {
          int num2 = -786314782;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 230200755 ^ 9716996;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return highlightTarget;
      }
      set
      {
label_1:
        int num1 = 318438295;
        while (true)
        {
          int num2 = 177347626;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.highlightTarget = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4082347520U));
              num1 = (int) num3 * -1100863995 ^ 1912612165;
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

    public WindowManagementViewModel()
    {
      this.Engine = Engine.Instance;
      this.Engine.OnPatternChanged += new EventHandler(this.Engine_OnPatternChanged);
      this.Windows = new LockedObservableCollection<ZoomWindow>();
      this.LoadCommands();
      this.LoadPatterns();
      this.LoadWindows();
      if (this.Engine.Settings.Screens.Count <= 1)
        return;
      this.HasSecondMonitor = true;
    }

    ~WindowManagementViewModel()
    {
      try
      {
        object modelLock = ViewModelBase.modelLock;
        bool flag = false;
        Engine engine;
        try
        {
          WindowManagementViewModel.\u206B‪‬⁬‮⁫‫‫‍‌‮‭‫‎‍‭‍‌‌⁯⁯‫‬⁪‎‫​‎‭⁬‮‬⁬‏‏‌‪‮‍⁮‮(modelLock, ref flag);
          engine = this.Engine;
label_3:
          int num1 = -437514037;
          while (true)
          {
            int num2 = -1072113571;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_3;
              case 1:
                num1 = (int) num3 * 1038912292 ^ 1868359552;
                continue;
              default:
                goto label_13;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_7:
            int num1 = -1025513178;
            while (true)
            {
              int num2 = -1072113571;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_7;
                case 1:
                  num1 = (int) num3 * -556666376 ^ 570375979;
                  continue;
                case 3:
                  WindowManagementViewModel.\u206D‍‭‎‌⁫⁬​⁬​‍‏⁪⁫‫⁪⁫‍⁫​‪​‭⁯‫⁫⁯‫‮‎​⁭‬⁪‬​⁮‏⁯‌‮(modelLock);
                  num1 = (int) num3 * 314257160 ^ -1824548360;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
label_13:
        if (engine == null)
          return;
label_14:
        int num4 = -968883995;
        while (true)
        {
          int num1 = -1072113571;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 5U)
          {
            case 0:
              goto label_14;
            case 1:
              num4 = (int) num2 * 1057848695 ^ 2061792074;
              continue;
            case 2:
              goto label_16;
            case 3:
              num4 = (int) num2 * 1035487362 ^ 1888847293;
              continue;
            case 4:
              engine.OnPatternChanged -= new EventHandler(this.Engine_OnPatternChanged);
              num4 = (int) num2 * 2003446299 ^ 2058765553;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_16:;
      }
      finally
      {
        // ISSUE: explicit finalizer call
        // ISSUE: explicit non-virtual call
        __nonvirtual (((object) this).Finalize());
      }
    }

    private void WindowChanged(ObjectChangedEventPayload obj)
    {
label_1:
      int num1 = -1216401344;
      while (true)
      {
        int num2 = -2057265389;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1705248834 ^ 1767427099;
            continue;
          case 2:
label_6:
            this.HandleAddWindow((ZoomWindow) obj.ChangedObject);
            num1 = -432873508;
            continue;
          case 3:
            switch (obj.ChangeType)
            {
              case ChangeType.Updated:
                goto label_12;
              case ChangeType.Added:
                goto label_6;
              case ChangeType.Removed:
                goto label_9;
              case ChangeType.Activated:
                goto label_13;
              case ChangeType.Deactivated:
                goto label_14;
              case ChangeType.Saved:
                goto label_15;
              default:
                num1 = (int) num3 * 882190174 ^ -675082464;
                continue;
            }
          case 4:
label_9:
            this.HandleRemoveWindow((ZoomWindow) obj.ChangedObject);
            num1 = -1723225186;
            continue;
          case 5:
            goto label_10;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num3 * 1761136640 ^ 746167198;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:
      return;
label_10:
      return;
label_14:
      return;
label_15:
      return;
label_12:
      return;
label_13:;
    }

    private void HandleRemoveWindow(ZoomWindow changedObject)
    {
      try
      {
        bool flag = !((Collection<ZoomWindow>) this.Windows).Contains(changedObject);
label_2:
        int num1 = 1372692900;
        while (true)
        {
          int num2 = 1535637775;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -1232950329 ^ -1700868070;
              continue;
            case 2:
              goto label_2;
            case 3:
              int num4 = !flag ? 172875745 : (num4 = 551559667);
              int num5 = (int) num3 * 1693852822;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = 2034104094;
              continue;
            case 5:
              num1 = (int) num3 * 807355786 ^ -1112108175;
              continue;
            case 6:
              num1 = (int) num3 * 868602148 ^ -2003246904;
              continue;
            case 7:
              ((Collection<ZoomWindow>) this.Windows).Add(changedObject);
              num1 = (int) num3 * -138813999 ^ -2098224936;
              continue;
            default:
              goto label_15;
          }
        }
      }
      catch (Exception ex)
      {
label_11:
        int num1 = 262145138;
        while (true)
        {
          int num2 = 1535637775;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1721460230 ^ -1111141564;
              continue;
            case 1:
              WindowManagementViewModel.\u202D‮‬‭‏​⁯‎‏‬⁬⁮⁮⁬⁫⁫‫‍‭‏‮​⁬⁪‭⁫‬‍‮‍‮‬‪⁪⁪⁯‬‬⁪‪‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * 1364150974 ^ -868693779;
              continue;
            case 2:
              goto label_11;
            default:
              goto label_15;
          }
        }
      }
label_15:
      this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1772168936U));
    }

    private void HandleAddWindow(ZoomWindow changedObject)
    {
label_1:
      int num1 = 292425295;
      while (true)
      {
        int num2 = 296150239;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            int num4 = flag2 ? -1499367104 : (num4 = -154811764);
            int num5 = (int) num3 * 114403517;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag1 = ((Collection<ZoomWindow>) this.Windows).Contains(changedObject);
            num1 = 1447693535;
            continue;
          case 2:
            num1 = (int) num3 * -1874628671 ^ -1090889575;
            continue;
          case 3:
            num1 = (int) num3 * 885313870 ^ 365341624;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * -1913016433 ^ 853094013;
            continue;
          case 6:
            ((Collection<ZoomWindow>) this.Windows).Remove(changedObject);
            num1 = (int) num3 * 900305594 ^ 644773948;
            continue;
          case 7:
            ((Collection<ZoomWindow>) this.Windows).Remove(changedObject);
            num1 = (int) num3 * 667549375 ^ -1241718499;
            continue;
          case 8:
            int num6 = flag1 ? 2067697305 : (num6 = 946454337);
            int num7 = (int) num3 * -1526495112;
            num1 = num6 ^ num7;
            continue;
          case 9:
            num1 = (int) num3 * 1054467570 ^ 213154007;
            continue;
          case 10:
            flag2 = ((Collection<ZoomWindow>) this.Windows).Contains(changedObject);
            num1 = (int) num3 * -772355479 ^ -1309658427;
            continue;
          case 11:
            goto label_3;
          case 12:
            this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1772168936U));
            num1 = 1246983048;
            continue;
          case 13:
            num1 = (int) num3 * 1858550289 ^ 1936931635;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    public void Load()
    {
label_1:
      int num1 = -609832849;
      while (true)
      {
        int num2 = -2000210473;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this.UserControl = this.UserControl;
            num1 = (int) num3 * 626459090 ^ 7392411;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(14434886U));
            num1 = (int) num3 * 291833453 ^ 660296718;
            continue;
          case 4:
            this.Initialized = true;
            num1 = (int) num3 * 701206492 ^ -1192321591;
            continue;
          case 5:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(187806918U));
            num1 = (int) num3 * -1516869037 ^ -708403401;
            continue;
          case 6:
            int num4 = this.Initialized ? -1313785598 : (num4 = -2031033865);
            int num5 = (int) num3 * 1352008167;
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

    private void LoadCommands()
    {
label_1:
      int num1 = 1260450893;
      while (true)
      {
        int num2 = 18503357;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * -856157359 ^ 1635526079;
            continue;
          case 1:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1330694301U), (Action<object>) (x => this.ExecuteApplyPattern()), (Predicate<object>) (x => this.CanApplyPattern()));
            num1 = (int) num3 * -1203754502 ^ -1116931007;
            continue;
          case 2:
            goto label_3;
          case 3:
            int num4 = !flag ? -60405964 : (num4 = -847353279);
            int num5 = (int) num3 * 1130049203;
            num1 = num4 ^ num5;
            continue;
          case 4:
            flag = this.Commands.Count == 0;
            num1 = (int) num3 * 1885163285 ^ 1206691320;
            continue;
          case 5:
            this.Commands.AddCommand(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3296089518U), (Action<object>) (x =>
            {
              this.ExecuteEditPattern();
label_1:
              int num2 = -505086141;
              while (true)
              {
                int num3 = -2055905782;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num2 = (int) num4 * -1081883485 ^ 223871044;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanEditPattern()));
            num1 = (int) num3 * -1944229015 ^ 1006855037;
            continue;
          case 6:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1338435989U), (Action<object>) (x =>
            {
              this.ExecuteSaveWindows();
label_1:
              int num2 = -1215181318;
              while (true)
              {
                int num3 = -905461846;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    num2 = (int) num4 * -1293225198 ^ 1812221039;
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
            }), (Predicate<object>) (x => this.CanSaveWindows()));
            num1 = (int) num3 * -1149362994 ^ 749676251;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num3 * -1736461027 ^ 1155085675;
            continue;
          case 9:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2336081022U), (Action<object>) (x =>
            {
              this.ExecuteCopyPattern();
label_1:
              int num2 = -1596649628;
              while (true)
              {
                int num3 = -1567372391;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num2 = (int) num4 * -18156406 ^ 1174677748;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanCopyPattern()));
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1069887450U), (Action<object>) (x => this.ExecuteDeletePattern()), (Predicate<object>) (x => this.CanDeletePattern()));
            num1 = (int) num3 * 1582581393 ^ 578653261;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    private bool CanSaveWindows()
    {
label_1:
      int num1 = 1072802057;
      bool flag;
      while (true)
      {
        int num2 = 87317720;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            flag = true;
            num1 = (int) num3 * -236409095 ^ 181093249;
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

    private void ExecuteSaveWindows()
    {
      string contents = string.Empty;
label_1:
      int num1 = -200225120;
      while (true)
      {
        int num2 = -625523083;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -1987230254 ^ 859263303;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      IEnumerator<ZoomWindow> enumerator = this.Engine.ActiveWindows.GetEnumerator();
      try
      {
label_12:
        int num2 = WindowManagementViewModel.\u206C​‭⁪‭‎​⁭‬‏‭‎‎⁭‎‎‎‍⁭‮⁯‬​⁭⁪⁮⁪‏⁭​⁬‮‭⁯⁭⁭⁯‮‪‬‮((IEnumerator) enumerator) ? -1757484721 : (num2 = -1407680873);
        while (true)
        {
          int num3 = -625523083;
          uint num4;
          ZoomWindow current;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              num2 = (int) num4 * 1349442741 ^ 1862526432;
              continue;
            case 2:
              goto label_12;
            case 3:
              current = enumerator.Current;
              num2 = -89165590;
              continue;
            case 4:
              num2 = (int) num4 * 625352527 ^ 1511996153;
              continue;
            case 5:
              num2 = -1757484721;
              continue;
            case 6:
              current.Refresh(false, false);
              contents = WindowManagementViewModel.\u200D‬‌⁫‬‏⁭‮‪‍‏⁭⁪‍⁫​⁬‪‫‍⁭⁭⁬‬‮‪‮‬‪⁪​‪⁪‏‎‬⁫⁭​‭‮(contents, WindowManagementViewModel.\u200E⁭‬​‬‍⁬‍⁭‫‭‪‏⁯‪‬‫‍⁭‮‭⁮‪​‭‍⁬‪​⁬⁫⁮‍‌⁬‏‌‌‬‏‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(949562311U), new object[7]
              {
                (object) current.Handle,
                (object) current.ZoomWindowType,
                (object) current.Title,
                (object) current.ClassName,
                (object) current.IsVisible,
                (object) current.Size,
                (object) current.Location
              }));
              num2 = (int) num4 * 639300234 ^ 223370973;
              continue;
            default:
              goto label_19;
          }
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_14:
          int num2 = -523932060;
          while (true)
          {
            int num3 = -625523083;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                WindowManagementViewModel.\u200E​​⁬⁫‫⁪⁬⁯‬⁯‎​‏⁮‫‌‎⁫⁪‌‫⁯⁫‌​⁮‌‬‮‍⁭‪‫⁬⁪‫⁪⁪‭‮((IDisposable) enumerator);
                num2 = (int) num4 * -811188157 ^ 2051602723;
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
label_19:
      string str = string.Format(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4169757832U), (object) DateTime.Now.ToString(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(453356568U)));
label_20:
      int num5 = -625374826;
      while (true)
      {
        int num2 = -625523083;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 4U)
        {
          case 0:
            goto label_20;
          case 1:
            Process.Start(str);
            num5 = (int) num3 * 116181592 ^ 1232698815;
            continue;
          case 2:
            goto label_22;
          case 3:
            File.WriteAllText(str, contents);
            num5 = (int) num3 * -884748162 ^ -1840858482;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_22:;
    }

    private void LoadPatterns()
    {
label_1:
      int num1 = -30060834;
      while (true)
      {
        int num2 = -1454444683;
        uint num3;
        int index;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            ++index;
            num1 = (int) num3 * 756326136 ^ 646560185;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = -1942940211;
            continue;
          case 4:
            LayoutPattern pattern = ((Collection<LayoutPattern>) this.Engine.Patterns)[index];
            num1 = (int) num3 * 61952898 ^ -688046489;
            continue;
          case 5:
            num1 = (int) num3 * -676124388 ^ -490349675;
            continue;
          case 6:
            num1 = (int) num3 * 672697399 ^ 968007086;
            continue;
          case 7:
            this.SelectedPattern = Engine.Instance.ActivePattern;
            num1 = (int) num3 * -1652352900 ^ -899284061;
            continue;
          case 8:
            int num4;
            num1 = num4 = index < ((Collection<LayoutPattern>) this.Engine.Patterns).Count ? -739659818 : (num4 = -1338306498);
            continue;
          case 9:
            index = 0;
            num1 = (int) num3 * -1536541826 ^ 724340022;
            continue;
          case 10:
            num1 = (int) num3 * -1037259046 ^ 1251711101;
            continue;
          case 11:
            this.Patterns = new LockedObservableCollection<LayoutPattern>();
            num1 = (int) num3 * -344486518 ^ -1908823370;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      // ISSUE: type reference
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.PatternChange), (ThreadOption) 1, false, (Predicate<ObjectChangedEventPayload>) (obj => WindowManagementViewModel.\u003C\u003Ec.\u206C‮‎‪‬‬‫‪⁯‏⁫‍‎⁮‪⁫⁯​⁯‪‪⁯‏⁭⁭⁫‪⁬⁮⁭⁭⁭‍‏⁭‌​‫‏‭‮(obj.ObjectType, WindowManagementViewModel.\u003C\u003Ec.\u206F‫‍‎‭⁭‭⁮‍‍⁫‬​‏‫‫⁬⁪​‭‎‫‍⁭‭‍‎‭⁭⁫‪‮⁬‌⁮⁫⁭⁭‬⁪‮(__typeref (LayoutPattern)))));
    }

    private void PatternChange(ObjectChangedEventPayload obj)
    {
      int num1;
      switch (obj.ChangeType)
      {
        case ChangeType.Updated:
          return;
        case ChangeType.Added:
label_15:
          this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3555768355U));
          num1 = -579270202;
          break;
        case ChangeType.Removed:
label_10:
          this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3555768355U));
          num1 = -21254302;
          break;
        case ChangeType.Activated:
label_25:
          this.ActivePattern = this.Engine.ActivePattern;
          num1 = -1470957611;
          break;
        case ChangeType.Deactivated:
label_11:
          this.ActivePattern = this.Engine.ActivePattern;
          num1 = -6473204;
          break;
        default:
label_1:
          num1 = -1341507134;
          break;
      }
      while (true)
      {
        int num2 = -1748934913;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 25U)
        {
          case 0:
            int num4 = this.SelectedPattern == (LayoutPattern) obj.ChangedObject ? -1709067162 : (num4 = -963948093);
            int num5 = (int) num3 * 2129902156;
            num1 = num4 ^ num5;
            continue;
          case 1:
            this.SelectedPattern = (LayoutPattern) null;
            num1 = (int) num3 * 559095730 ^ -1374816505;
            continue;
          case 2:
            flag = this.ActivePattern == (LayoutPattern) obj.ChangedObject;
            num1 = -2123654050;
            continue;
          case 3:
            num1 = (int) num3 * -1159775984 ^ -647280886;
            continue;
          case 4:
            goto label_15;
          case 5:
            num1 = (int) num3 * 326265645 ^ 1129991497;
            continue;
          case 6:
            this.SelectedPattern = this.Engine.ActivePattern;
            num1 = (int) num3 * 135965331 ^ -168065494;
            continue;
          case 7:
            num1 = (int) num3 * 1588344501 ^ 863907857;
            continue;
          case 8:
            goto label_20;
          case 9:
            num1 = (int) num3 * -842884760 ^ -1211765673;
            continue;
          case 10:
            num1 = (int) num3 * -1695440093 ^ -1590938715;
            continue;
          case 11:
            num1 = (int) num3 * -1427411764 ^ 694888685;
            continue;
          case 12:
            num1 = (int) num3 * 1535148251 ^ 2080886499;
            continue;
          case 13:
            goto label_25;
          case 14:
            num1 = (int) num3 * -809451124 ^ -710417677;
            continue;
          case 15:
            goto label_11;
          case 16:
            this.ActivePattern = this.Engine.ActivePattern;
            num1 = (int) num3 * 1785675639 ^ 1598361394;
            continue;
          case 17:
            num1 = (int) num3 * 980101865 ^ 1531891038;
            continue;
          case 18:
            goto label_10;
          case 19:
            num1 = (int) num3 * 1708551370 ^ 164920542;
            continue;
          case 20:
            goto label_1;
          case 21:
            goto label_18;
          case 22:
            int num6 = flag ? 684608672 : (num6 = 338906969);
            int num7 = (int) num3 * 587734424;
            num1 = num6 ^ num7;
            continue;
          case 23:
            goto label_5;
          case 24:
            goto label_3;
          default:
            goto label_28;
        }
      }
label_3:
      return;
label_28:
      return;
label_5:
      return;
label_20:
      return;
label_18:;
    }

    private void LoadWindows()
    {
      this.Windows = new LockedObservableCollection<ZoomWindow>((Collection<ZoomWindow>) this.Engine.Windows, false);
label_1:
      int num1 = 1950395007;
      while (true)
      {
        int num2 = 654555759;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(146227152U));
            num1 = (int) num3 * -104079056 ^ -151361419;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void Engine_OnPatternChanged(object sender, EventArgs e)
    {
label_1:
      int num1 = -1394709669;
      while (true)
      {
        int num2 = -1676641261;
        uint num3;
        ZoomLayoutPatternEventArgs patternEventArgs;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            int num4 = flag ? 2127369244 : (num4 = 352314097);
            int num5 = (int) num3 * 1649124586;
            num1 = num4 ^ num5;
            continue;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 648643945 ^ 1327400007;
            continue;
          case 3:
            flag = this.SelectedPattern == null;
            num1 = (int) num3 * -1398968431 ^ 1005068256;
            continue;
          case 4:
            patternEventArgs = e as ZoomLayoutPatternEventArgs;
            num1 = (int) num3 * -1132661363 ^ -557686535;
            continue;
          case 5:
            num1 = (int) num3 * 54485329 ^ -826050330;
            continue;
          case 6:
            num1 = -1510365630;
            continue;
          case 7:
            goto label_1;
          case 8:
            this.ActivePattern = patternEventArgs.Pattern;
            num1 = (int) num3 * 884477805 ^ 992832718;
            continue;
          case 9:
            num1 = (int) num3 * 1315979510 ^ 1783810114;
            continue;
          case 10:
            int num6 = patternEventArgs != null ? 951848780 : (num6 = 1134999676);
            int num7 = (int) num3 * -202515905;
            num1 = num6 ^ num7;
            continue;
          case 11:
            this.SelectedPattern = this.ActivePattern;
            num1 = (int) num3 * -1514503940 ^ -164600263;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    private void ActivePattern_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      LayoutPattern layoutPattern = sender as LayoutPattern;
label_1:
      int num1 = -1438825799;
      while (true)
      {
        int num2 = -850937064;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 807167938 ^ -1565618215;
            continue;
          case 2:
            num4 = layoutPattern != null ? 1 : 0;
            break;
          case 3:
            goto label_3;
          case 4:
            int num5 = !flag ? -629525969 : (num5 = -829291768);
            int num6 = (int) num3 * -353709114;
            num1 = num5 ^ num6;
            continue;
          case 5:
            this.EnableStretching = layoutPattern.StretchingEnabled;
            num1 = (int) num3 * 1964330280 ^ 1035179543;
            continue;
          case 6:
            if (WindowManagementViewModel.\u200B⁯⁬‎​⁪⁫‏⁮⁫‏⁭‬⁯‌⁫‫‬‌‬‍‭‭‮⁭⁬⁪⁯‪⁭⁮⁫‍‭‬⁫‪​​‪‮(WindowManagementViewModel.\u200C‭⁫‌⁪​‍‭​⁯⁮⁭​‭⁪‭⁬⁪‏⁭⁯‫​​​⁮‎‍‫​‪‏‌⁯⁪‮⁭⁯​‬‮(e), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(34947618U)))
            {
              num1 = (int) num3 * -1556419347 ^ -684375451;
              continue;
            }
            num4 = 0;
            break;
          default:
            goto label_12;
        }
        flag = num4 != 0;
        num1 = -1156325948;
      }
label_12:
      return;
label_3:;
    }

    private bool CanApplyPattern()
    {
      bool flag = this.SelectedPattern != null;
label_1:
      int num1 = -1521651554;
      while (true)
      {
        int num2 = -1178832794;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1839952904 ^ 753324112;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteApplyPattern()
    {
      bool flag = this.Engine.ActivePattern != this.SelectedPattern;
label_1:
      int num1 = -1838677217;
      while (true)
      {
        int num2 = -1248817368;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            WindowManagementViewModel.\u200E⁫‫‎​⁪⁬⁯‮‮‫‬‌‏⁭⁭‎⁯⁮‮⁯⁫‪‌⁪‭⁯‮​‭⁬‮‬‎⁯⁪‭⁭‏‮(ViewModelBase.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(39273607U));
            num1 = (int) num3 * -305332901 ^ -1433000818;
            continue;
          case 2:
            this.Engine.ActivePattern = this.SelectedPattern;
            num1 = (int) num3 * -2122660351 ^ -178032455;
            continue;
          case 3:
            num1 = (int) num3 * -1342783428 ^ -1389823771;
            continue;
          case 4:
            num1 = (int) num3 * -1389660956 ^ -160522994;
            continue;
          case 5:
            num1 = (int) num3 * 693470645 ^ -264672619;
            continue;
          case 6:
            goto label_3;
          case 7:
            int num4 = !flag ? -1110030732 : (num4 = -801280184);
            int num5 = (int) num3 * -303347162;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    private bool CanDeletePattern()
    {
label_1:
      int num1 = -86033425;
      bool flag;
      while (true)
      {
        int num2 = -358213980;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 2136949697 ^ 1065707371;
            continue;
          case 3:
            flag = this.SelectedPattern != null;
            num1 = (int) num3 * -324998984 ^ -2077177835;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteDeletePattern()
    {
label_1:
      int num1 = -1543207399;
      while (true)
      {
        int num2 = -801409347;
        uint num3;
        bool flag1;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -256174967 ^ 504015920;
            continue;
          case 2:
            goto label_1;
          case 3:
            ConfirmationWindow.Confirm(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1197084714U), (EventHandler<WindowClosedEventArgs>) ((windowSender, args) =>
            {
label_1:
              int num2 = 2086002084;
              while (true)
              {
                int num3 = 1618184424;
                uint num4;
                bool? nullable;
                bool flag1;
                bool flag2;
                int num5;
                switch ((num4 = (uint) (num2 ^ num3)) % 18U)
                {
                  case 0:
                    int num6 = flag2 ? -620578285 : (num6 = -1682179627);
                    int num7 = (int) num4 * 412100467;
                    num2 = num6 ^ num7;
                    continue;
                  case 1:
                    int num8 = ((Collection<LayoutPattern>) this.Engine.Patterns).Count <= 0 ? -1024892511 : (num8 = -136684080);
                    int num9 = (int) num4 * -504554849;
                    num2 = num8 ^ num9;
                    continue;
                  case 2:
                    num2 = 152634223;
                    continue;
                  case 3:
                    this.SelectedPattern = ((Collection<LayoutPattern>) this.Engine.Patterns)[0];
                    num2 = (int) num4 * -1533736536 ^ 617459070;
                    continue;
                  case 4:
                    flag1 = true;
                    num2 = (int) num4 * 1213024212 ^ -701981519;
                    continue;
                  case 5:
                    num2 = (int) num4 * 1361129272 ^ 488756985;
                    continue;
                  case 6:
                    goto label_1;
                  case 7:
                    num2 = (int) num4 * 693645523 ^ 776150291;
                    continue;
                  case 8:
                    nullable = WindowManagementViewModel.\u202A‌⁫‬‭⁬‌‪‌‫⁬⁭‫‫⁫‬‍⁮⁪‌⁬‌​‫​‌⁫⁬‭‌‌‮‏‬⁮‮‫‫​⁯‮(args);
                    num2 = (int) num4 * 1246351722 ^ 1868577842;
                    continue;
                  case 9:
                    num5 = 0;
                    break;
                  case 10:
                    this.Engine.RemovePattern(this.SelectedPattern);
                    num2 = (int) num4 * -970157307 ^ 866069385;
                    continue;
                  case 11:
                    num2 = (int) num4 * -1639784361 ^ 1049122374;
                    continue;
                  case 12:
                    num2 = (int) num4 * 1159932976 ^ 1935597967;
                    continue;
                  case 13:
                    num2 = (int) num4 * -1575278370 ^ 1915066772;
                    continue;
                  case 14:
                    num2 = (int) num4 * -1961940942 ^ 1574066382;
                    continue;
                  case 15:
                    if (nullable.GetValueOrDefault() != flag1)
                    {
                      num2 = (int) num4 * 1103713135 ^ 194108736;
                      continue;
                    }
                    num5 = nullable.HasValue ? 1 : 0;
                    break;
                  case 16:
                    this.SelectedPattern = (LayoutPattern) null;
                    num2 = 25362540;
                    continue;
                  case 17:
                    goto label_3;
                  default:
                    goto label_23;
                }
                flag2 = num5 != 0;
                num2 = 1403744054;
              }
label_23:
              return;
label_3:;
            }), 400);
            num1 = (int) num3 * 617238736 ^ 1901653806;
            continue;
          case 4:
            flag1 = this.SelectedPattern != null;
            num1 = (int) num3 * 703469084 ^ -1307095142;
            continue;
          case 5:
            int num12 = flag1 ? -514282386 : (num12 = -757586793);
            int num13 = (int) num3 * -679053116;
            num1 = num12 ^ num13;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private bool CanCopyPattern()
    {
label_1:
      int num1 = 2045663286;
      bool flag;
      while (true)
      {
        int num2 = 1478394447;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 344804992 ^ -825740844;
            continue;
          case 1:
            flag = this.SelectedPattern != null;
            num1 = (int) num3 * -1843150945 ^ -750484320;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteCopyPattern()
    {
      if (this.SelectedPattern == null)
        return;
label_1:
      int num1 = -1002316341;
      while (true)
      {
        int num2 = -345495749;
        uint num3;
        LayoutPattern layoutPattern;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this.SelectedPattern = layoutPattern;
            num1 = (int) num3 * -842547632 ^ 1013336316;
            continue;
          case 1:
            goto label_11;
          case 2:
            this.ExecuteEditPattern();
            num1 = (int) num3 * -782410772 ^ -505315248;
            continue;
          case 3:
            num1 = (int) num3 * -2110988321 ^ 1925086451;
            continue;
          case 4:
            num1 = (int) num3 * -1354169205 ^ 1956503883;
            continue;
          case 5:
            goto label_1;
          case 6:
            layoutPattern = new LayoutPattern(this.SelectedPattern);
            num1 = (int) num3 * -1305452420 ^ -2114614381;
            continue;
          case 7:
            num1 = (int) num3 * -756199960 ^ -1077263270;
            continue;
          case 8:
            num1 = (int) num3 * 607440004 ^ -1390674672;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_11:;
    }

    private bool CanEditPattern()
    {
label_1:
      int num1 = 1408490669;
      bool flag;
      while (true)
      {
        int num2 = 1334011630;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 492690647 ^ -84604223;
            continue;
          case 3:
            flag = this.SelectedPattern != null;
            num1 = (int) num3 * -776114066 ^ -1904031978;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteEditPattern()
    {
      bool flag1 = this.SelectedPattern != null;
label_1:
      int num1 = -1234203262;
      while (true)
      {
        int num2 = -1235291116;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.LayoutEditorView = new LayoutEditorView();
            flag2 = this.View != null;
            num1 = (int) num3 * 1484077518 ^ 1520359785;
            continue;
          case 3:
            WindowManagementViewModel.\u200D⁭⁫⁬‫‎‏‮‫‪‫⁫​​‍⁭‪‏⁪‪⁬​‪‏‏⁪‫‫‎‮‪⁫‮‎⁬​⁯‏⁪‎‮((Window) this.LayoutEditorView, WindowManagementViewModel.\u200E‬‮⁫‮⁯⁬​‬‍⁯‬⁭‏‫⁪⁫‭‪⁬‫⁫‍​⁮‍‬⁯‮⁪‮⁬‏‬⁯‌⁪‭‬‬‮(this.View) + WindowManagementViewModel.\u200E‬⁭⁬⁮‬‌⁭‎‌⁪‪‏‍‪‮⁭​⁪⁪‫​‫⁭‪‭​‫⁮‏⁬⁬‪⁭​‏‭⁫‎‪‮((FrameworkElement) this.View) + 5.0);
            num1 = (int) num3 * -2147218940 ^ -2043558411;
            continue;
          case 4:
            WindowManagementViewModel.\u206A‎​‎‎‪‭‍‎⁮‎‭⁫‪‫⁫‎‎⁫⁭⁯‮‌‪‌⁫‭‬‍​⁫‭​‌⁬‮⁪‬⁪⁪‮((Window) this.LayoutEditorView, new EventHandler(this.Editor_Closed));
            num1 = (int) num3 * -1481709746 ^ -867969208;
            continue;
          case 5:
            num1 = (int) num3 * 193607800 ^ 61634050;
            continue;
          case 6:
            this.LayoutEditorView.Layout = this.SelectedPattern;
            num1 = (int) num3 * -540604721 ^ -507135527;
            continue;
          case 7:
            WindowManagementViewModel.\u202B⁬⁭⁭⁭⁫​‮‫‮‮‭⁫‬⁫‍⁮⁮‫‭⁭‫‌⁯⁪​‬‪​⁯‍‬‏⁬⁭⁮⁮​⁯‭‮((Window) this.LayoutEditorView);
            num1 = (int) num3 * 1379840611 ^ -1184465017;
            continue;
          case 8:
            int num4 = flag1 ? 93097360 : (num4 = 119215492);
            int num5 = (int) num3 * 1552548141;
            num1 = num4 ^ num5;
            continue;
          case 9:
            WindowManagementViewModel.\u206E⁯‮​‫‬⁭‏‬‫⁯‫​‫‫⁬‎⁫‬⁪‮‏⁪​⁮⁯⁮⁯⁫‮‏⁫‬⁫⁪⁯⁬⁯‍‬‮((Window) this.LayoutEditorView, true);
            num1 = -1084115768;
            continue;
          case 10:
            num1 = (int) num3 * -1261874419 ^ -279117900;
            continue;
          case 11:
            int num6 = flag2 ? -709132729 : (num6 = -1578856565);
            int num7 = (int) num3 * -1299756383;
            num1 = num6 ^ num7;
            continue;
          case 12:
            num1 = (int) num3 * 972890744 ^ 452785426;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    private void Editor_Closed(object sender, EventArgs e)
    {
label_1:
      int num1 = 1151093287;
      while (true)
      {
        int num2 = 695455560;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2322062035U));
            num1 = (int) num3 * -1281202517 ^ -292396837;
            continue;
          case 1:
            this.LayoutEditorView = (LayoutEditorView) null;
            num1 = (int) num3 * 62533454 ^ -413173981;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.Engine.AddPattern(this.SelectedPattern, false);
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3555768355U));
            num1 = (int) num3 * -375539953 ^ 405376051;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * 304766484 ^ -1119296968;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    static bool \u200B⁯⁬‎​⁪⁫‏⁮⁫‏⁭‬⁯‌⁫‫‬‌‬‍‭‭‮⁭⁬⁪⁯‪⁭⁮⁫‍‭‬⁫‪​​‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u202D‮‬‭‏​⁯‎‏‬⁬⁮⁮⁬⁫⁫‫‍‭‏‮​⁬⁪‭⁫‬‍‮‍‮‬‪⁪⁪⁯‬‬⁪‪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u206B‪‬⁬‮⁫‫‫‍‌‮‭‫‎‍‭‍‌‌⁯⁯‫‬⁪‎‫​‎‭⁬‮‬⁬‏‏‌‪‮‍⁮‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206D‍‭‎‌⁫⁬​⁬​‍‏⁪⁫‫⁪⁫‍⁫​‪​‭⁯‫⁫⁯‫‮‎​⁭‬⁪‬​⁮‏⁯‌‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static string \u200E⁭‬​‬‍⁬‍⁭‫‭‪‏⁯‪‬‫‍⁭‮‭⁮‪​‭‍⁬‪​⁬⁫⁮‍‌⁬‏‌‌‬‏‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u200D‬‌⁫‬‏⁭‮‪‍‏⁭⁪‍⁫​⁬‪‫‍⁭⁭⁬‬‮‪‮‬‪⁪​‪⁪‏‎‬⁫⁭​‭‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static bool \u206C​‭⁪‭‎​⁭‬‏‭‎‎⁭‎‎‎‍⁭‮⁯‬​⁭⁪⁮⁪‏⁭​⁬‮‭⁯⁭⁭⁯‮‪‬‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u200E​​⁬⁫‫⁪⁬⁯‬⁯‎​‏⁮‫‌‎⁫⁪‌‫⁯⁫‌​⁮‌‬‮‍⁭‪‫⁬⁪‫⁪⁪‭‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static string \u200C‭⁫‌⁪​‍‭​⁯⁮⁭​‭⁪‭⁬⁪‏⁭⁯‫​​​⁮‎‍‫​‪‏‌⁯⁪‮⁭⁯​‬‮([In] PropertyChangedEventArgs obj0)
    {
      return obj0.PropertyName;
    }

    static void \u200E⁫‫‎​⁪⁬⁯‮‮‫‬‌‏⁭⁭‎⁯⁮‮⁯⁫‪‌⁪‭⁯‮​‭⁬‮‬‎⁯⁪‭⁭‏‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static double \u200E‬‮⁫‮⁯⁬​‬‍⁯‬⁭‏‫⁪⁫‭‪⁬‫⁫‍​⁮‍‬⁯‮⁪‮⁬‏‬⁯‌⁪‭‬‬‮([In] Window obj0)
    {
      return obj0.Top;
    }

    static double \u200E‬⁭⁬⁮‬‌⁭‎‌⁪‪‏‍‪‮⁭​⁪⁪‫​‫⁭‪‭​‫⁮‏⁬⁬‪⁭​‏‭⁫‎‪‮([In] FrameworkElement obj0)
    {
      return obj0.Height;
    }

    static void \u200D⁭⁫⁬‫‎‏‮‫‪‫⁫​​‍⁭‪‏⁪‪⁬​‪‏‏⁪‫‫‎‮‪⁫‮‎⁬​⁯‏⁪‎‮([In] Window obj0, [In] double obj1)
    {
      obj0.Top = obj1;
    }

    static void \u206E⁯‮​‫‬⁭‏‬‫⁯‫​‫‫⁬‎⁫‬⁪‮‏⁪​⁮⁯⁮⁯⁫‮‏⁫‬⁫⁪⁯⁬⁯‍‬‮([In] Window obj0, [In] bool obj1)
    {
      obj0.Topmost = obj1;
    }

    static void \u202B⁬⁭⁭⁭⁫​‮‫‮‮‭⁫‬⁫‍⁮⁮‫‭⁭‫‌⁯⁪​‬‪​⁯‍‬‏⁬⁭⁮⁮​⁯‭‮([In] Window obj0)
    {
      obj0.Show();
    }

    static void \u206A‎​‎‎‪‭‍‎⁮‎‭⁫‪‫⁫‎‎⁫⁭⁯‮‌‪‌⁫‭‬‍​⁫‭​‌⁬‮⁪‬⁪⁪‮([In] Window obj0, [In] EventHandler obj1)
    {
      obj0.Closed += obj1;
    }

    static bool? \u202A‌⁫‬‭⁬‌‪‌‫⁬⁭‫‫⁫‬‍⁮⁪‌⁬‌​‫​‌⁫⁬‭‌‌‮‏‬⁮‮‫‫​⁯‮([In] WindowClosedEventArgs obj0)
    {
      return obj0.get_DialogResult();
    }
  }
}
