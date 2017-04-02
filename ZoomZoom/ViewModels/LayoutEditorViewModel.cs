// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.LayoutEditorViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using GalaSoft.MvvmLight;
using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Controls;
using ZoomZoom.Models.Windows;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  public class LayoutEditorViewModel : ViewModelBase
  {
    private List<WindowLayout> windowLayouts = new List<WindowLayout>();
    private bool hasSecondMonitor = false;
    private Dictionary<Color, WindowLayout> overlayPanels = new Dictionary<Color, WindowLayout>();
    private LayoutPattern pattern;

    public List<WindowLayout> WindowLayouts
    {
      get
      {
        List<WindowLayout> windowLayouts = this.windowLayouts;
label_1:
        int num1 = 2095754925;
        while (true)
        {
          int num2 = 1901259862;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -937006027 ^ -1339751727;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowLayouts;
      }
      set
      {
label_1:
        int num1 = -1072413679;
        while (true)
        {
          int num2 = -1469773964;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.windowLayouts = value;
              num1 = (int) num3 * 1221713506 ^ 1402701649;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3302252856U));
              num1 = (int) num3 * 1879987278 ^ 2043599184;
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

    public string PatternName
    {
      get
      {
label_1:
        int num1 = 1919927512;
        string str;
        while (true)
        {
          int num2 = 1497874042;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              LayoutPattern pattern = this.Pattern;
              str = pattern != null ? pattern.PatternName : (string) null;
              num1 = 1777403260;
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
      set
      {
label_1:
        int num1 = 108992439;
        while (true)
        {
          int num2 = 1822720601;
          uint num3;
          bool flag1;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(324548038U));
              num1 = 1928499591;
              continue;
            case 1:
              num1 = (int) num3 * 1988953270 ^ -350883788;
              continue;
            case 2:
              flag2 = LayoutEditorViewModel.\u200E‍‏‬​‫⁮‮‌‭⁮‪⁮‍‫⁮‫‬⁮‍⁫⁭‪⁮‭‍⁭‎⁮‌⁭‬‎‌‏‍⁬‪‮‭‮(this.Pattern.PatternName, value);
              num1 = (int) num3 * -1451522985 ^ -478643661;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = !flag1 ? 1262795500 : (num4 = 645256623);
              int num5 = (int) num3 * -953950919;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 119829396 ^ 1744418712;
              continue;
            case 6:
              num1 = (int) num3 * 1246869567 ^ 419791414;
              continue;
            case 7:
              this.Pattern.Save("");
              num1 = (int) num3 * 1594214254 ^ 873674634;
              continue;
            case 8:
              goto label_3;
            case 9:
              this.Pattern.PatternName = value;
              num1 = (int) num3 * 1113210114 ^ 2059594059;
              continue;
            case 10:
              num1 = (int) num3 * 517713538 ^ 1487031110;
              continue;
            case 11:
              int num6 = flag2 ? 733467243 : (num6 = 1386296131);
              int num7 = (int) num3 * 143701703;
              num1 = num6 ^ num7;
              continue;
            case 12:
              flag1 = this.Pattern != null;
              num1 = 2112407011;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_3:;
      }
    }

    public LayoutPattern Pattern
    {
      get
      {
label_1:
        int num1 = -994193506;
        LayoutPattern pattern;
        while (true)
        {
          int num2 = -1108000940;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              pattern = this.pattern;
              num1 = (int) num3 * -1030240254 ^ -398848601;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return pattern;
      }
      set
      {
        this.pattern = value;
label_1:
        int num1 = -460381239;
        while (true)
        {
          int num2 = -2017936064;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1027741621U));
              num1 = (int) num3 * -1256512855 ^ -732081320;
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

    public List<ZoomMonitor> Monitors
    {
      get
      {
label_1:
        int num1 = 1754894849;
        List<ZoomMonitor> monitors;
        while (true)
        {
          int num2 = 1687512624;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              monitors = this.Engine.Settings.Monitors;
              num1 = (int) num3 * 175176837 ^ -1166414258;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1419601805 ^ -1570285637;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return monitors;
      }
    }

    public WindowLayout MeetingWindowLayout
    {
      get
      {
label_1:
        int num1 = -2146043566;
        WindowLayout windowLayout1;
        while (true)
        {
          int num2 = -1248860537;
          uint num3;
          WindowLayout windowLayout2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              windowLayout1 = windowLayout2;
              num1 = (int) num3 * -1370095099 ^ -512321973;
              continue;
            case 1:
              windowLayout2 = this.GetWindowLayout(ZoomWindowType.Meeting, true);
              num1 = (int) num3 * 825795692 ^ -93449878;
              continue;
            case 2:
              num1 = (int) num3 * 699823115 ^ -1289212315;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return windowLayout1;
      }
    }

    public WindowLayout DualVideoWindowLayout
    {
      get
      {
        WindowLayout windowLayout1 = this.GetWindowLayout(ZoomWindowType.DualVideo, true);
label_1:
        int num1 = -522977653;
        WindowLayout windowLayout2;
        while (true)
        {
          int num2 = -1570987198;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -2145931688 ^ -817978135;
              continue;
            case 1:
              windowLayout2 = windowLayout1;
              num1 = (int) num3 * 206474955 ^ -145586703;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return windowLayout2;
      }
    }

    public WindowLayout ParticipantWindowLayout
    {
      get
      {
label_1:
        int num1 = 1026138603;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = 839995306;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              windowLayout = this.GetWindowLayout(ZoomWindowType.Participants, true);
              num1 = (int) num3 * 1685426592 ^ 1073928801;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1630240255 ^ -524313549;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowLayout;
      }
    }

    public WindowLayout ChatWindowLayout
    {
      get
      {
label_1:
        int num1 = 1667167488;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = 1653425033;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              windowLayout = this.GetWindowLayout(ZoomWindowType.Chat, true);
              num1 = (int) num3 * 2053488155 ^ -981140176;
              continue;
            case 2:
              num1 = (int) num3 * 494126681 ^ 745947716;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowLayout;
      }
    }

    public WindowLayout ManyCamBroadcastWindowLayout
    {
      get
      {
label_1:
        int num1 = 634941165;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = 1713086311;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              windowLayout = this.GetWindowLayout(ZoomWindowType.ManyCamBroadcast, true);
              num1 = (int) num3 * -840475917 ^ -1149570174;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowLayout;
      }
    }

    public WindowLayout ManyCamAppWindowLayout
    {
      get
      {
        WindowLayout windowLayout = this.GetWindowLayout(ZoomWindowType.ManyCamApp, true);
label_1:
        int num1 = 471970734;
        while (true)
        {
          int num2 = 1648049971;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1015886891 ^ -106996368;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowLayout;
      }
    }

    public WindowLayout JoinAudioWindowLayout
    {
      get
      {
label_1:
        int num1 = 1670000935;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = 1496463794;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 27120326 ^ 604717704;
              continue;
            case 1:
              windowLayout = this.GetWindowLayout(ZoomWindowType.JoinAudio, true);
              num1 = (int) num3 * -1859330635 ^ 1137667963;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return windowLayout;
      }
    }

    public WindowLayout InviteWindowLayout
    {
      get
      {
        WindowLayout windowLayout = this.GetWindowLayout(ZoomWindowType.Invite, true);
label_1:
        int num1 = -268591917;
        while (true)
        {
          int num2 = -1796828867;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -244130684 ^ 590787444;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowLayout;
      }
    }

    public WindowLayout RequestRecordWindowLayout
    {
      get
      {
        WindowLayout windowLayout = this.GetWindowLayout(ZoomWindowType.RequestRecord, true);
label_1:
        int num1 = 306158863;
        while (true)
        {
          int num2 = 1557696931;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1146657030 ^ -1963069848;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowLayout;
      }
    }

    public WindowLayout SharingWindowLayout
    {
      get
      {
label_1:
        int num1 = -519175222;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = -1043664976;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              windowLayout = this.GetWindowLayout(ZoomWindowType.Sharing, true);
              num1 = (int) num3 * -775926120 ^ -430496131;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowLayout;
      }
    }

    public WindowLayout VideoHistoryViewWindowLayout
    {
      get
      {
        return this.GetWindowLayout(ZoomWindowType.ImageHistoryView, true);
      }
    }

    public WindowLayout RenameWindowLayout
    {
      get
      {
label_1:
        int num1 = -713979142;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = -740611929;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1483154961 ^ 2064239665;
              continue;
            case 1:
              windowLayout = this.GetWindowLayout(ZoomWindowType.Rename, true);
              num1 = (int) num3 * -1638641933 ^ 2076576708;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return windowLayout;
      }
    }

    public bool HasSecondMonitor
    {
      get
      {
label_1:
        int num1 = -964672304;
        bool hasSecondMonitor;
        while (true)
        {
          int num2 = -425573323;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              hasSecondMonitor = this.hasSecondMonitor;
              num1 = (int) num3 * 2130458615 ^ 1348675191;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return hasSecondMonitor;
      }
      set
      {
        this.hasSecondMonitor = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2463725544U));
      }
    }

    public LayoutEditorViewModel(IEventAggregator eventAggregator)
    {
label_1:
      int num1 = -955482391;
      while (true)
      {
        int num2 = -685954451;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * -43715327 ^ -1750037825;
            continue;
          case 1:
            num1 = (int) num3 * -2146344305 ^ 559371616;
            continue;
          case 2:
            int num4 = flag ? -855015473 : (num4 = -418975873);
            int num5 = (int) num3 * -640734352;
            num1 = num4 ^ num5;
            continue;
          case 3:
            this.LoadCommands();
            num1 = -1547615424;
            continue;
          case 4:
            this.Pattern = new LayoutPattern();
            num1 = (int) num3 * 140043839 ^ -1598681443;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * -1074953805 ^ 727338699;
            continue;
          case 7:
            num1 = -666421729;
            continue;
          case 8:
            flag = LayoutEditorViewModel.\u200F‭⁭‭⁭‍⁬‍⁫⁬‬‍‬‮⁪‏⁮‬‌‍‬​‪⁭‌‎⁮⁮​‍‭​⁯‭⁫‎‬‫​‌‮((ViewModelBase) this);
            num1 = (int) num3 * -2101111948 ^ 272844597;
            continue;
          case 9:
            this.Pattern.PatternName = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2299176897U);
            num1 = (int) num3 * 1687062051 ^ 467858433;
            continue;
          case 10:
            num1 = (int) num3 * 132124566 ^ 102058748;
            continue;
          case 11:
            num1 = (int) num3 * -312616392 ^ -922351933;
            continue;
          case 12:
            goto label_1;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    private void LoadCommands()
    {
label_1:
      int num1 = -297419680;
      while (true)
      {
        int num2 = -1171857963;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3080660892U), (Action<object>) (x => this.DeletePattern()), (Predicate<object>) (x => this.CanDeletePattern()));
            num1 = (int) num3 * -1729958761 ^ 289971098;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3800013640U), (Action<object>) (x => this.SavePattern()), (Predicate<object>) (x => this.CanSavePattern()));
            num1 = (int) num3 * 1989814291 ^ 1686935584;
            continue;
          case 4:
            this.Commands.AddCommand(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1305653928U), (Action<object>) (x => this.ApplyPattern()), (Predicate<object>) (x => this.CanApplyPattern()));
            num1 = (int) num3 * 376193330 ^ -1017711647;
            continue;
          case 5:
            num1 = (int) num3 * 981057155 ^ -920457822;
            continue;
          case 6:
            num1 = (int) num3 * -1182001163 ^ -1985037263;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    public void Initialize(LayoutEditorView view, LayoutPattern pattern)
    {
label_1:
      int num1 = -541126080;
      while (true)
      {
        int num2 = -1980269823;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 606447693 ^ 2131026100;
            continue;
          case 1:
            this.View = (Window) view;
            num1 = (int) num3 * -1465593818 ^ 7024611;
            continue;
          case 2:
            num1 = (int) num3 * 1779913917 ^ -42664494;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_1;
          case 5:
            this.Pattern = pattern;
            num1 = (int) num3 * -400510196 ^ -1967744957;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private bool CanApplyPattern()
    {
      bool flag = this.Pattern != null;
label_1:
      int num1 = -1520454543;
      while (true)
      {
        int num2 = -549961279;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1735416049 ^ -975422254;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private bool CanDeletePattern()
    {
label_1:
      int num1 = -1305154028;
      bool flag;
      while (true)
      {
        int num2 = -648141204;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num4 = !this.Pattern.AutoGenerated ? 1 : 0;
            break;
          case 3:
            if (this.Pattern != null)
            {
              num1 = (int) num3 * -17400480 ^ -1819262925;
              continue;
            }
            num4 = 0;
            break;
          case 4:
            num1 = (int) num3 * -1094483839 ^ -96685931;
            continue;
          default:
            goto label_9;
        }
        flag = num4 != 0;
        num1 = -1919009796;
      }
label_9:
      return flag;
    }

    private bool CanSavePattern()
    {
label_1:
      int num1 = -133351848;
      bool flag;
      while (true)
      {
        int num2 = -1251767365;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num4 = this.Pattern.IsDirty ? 1 : 0;
            break;
          case 3:
            if (this.Pattern != null)
            {
              num1 = (int) num3 * 1654689919 ^ -564328589;
              continue;
            }
            num4 = 0;
            break;
          default:
            goto label_8;
        }
        flag = num4 != 0;
        num1 = -846716207;
      }
label_8:
      return flag;
    }

    public void SavePattern()
    {
      if (this.Pattern == null)
        return;
label_1:
      int num1 = 482040132;
      while (true)
      {
        int num2 = 1600770177;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_10;
          case 1:
            num1 = 334552889;
            continue;
          case 2:
            LayoutEditorViewModel.\u206B⁮⁬‫‍‎​‮‬‍‭⁯‭⁪‭‫⁪‭‎⁫⁮‎‬⁯⁬‭‫‬‪‮‪‌‪‪‬⁬‏‪‫‌‮(this.View);
            num1 = (int) num3 * 1523450932 ^ 2146197743;
            continue;
          case 3:
            int num4 = this.View != null ? 627562361 : (num4 = 1729555962);
            int num5 = (int) num3 * -2121503154;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 1233656256 ^ -1547757554;
            continue;
          case 6:
            num1 = (int) num3 * -507745689 ^ -816291574;
            continue;
          case 7:
            this.Pattern.Save("");
            num1 = (int) num3 * 291398037 ^ 989372881;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_10:;
    }

    internal void DeletePattern()
    {
      ConfirmationWindow.Confirm(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(782746678U), (EventHandler<WindowClosedEventArgs>) ((windowSender, args) =>
      {
        bool? nullable = LayoutEditorViewModel.\u202E‏‬‮⁭⁮⁬‭‎⁫‌⁮‮‭‎‎​‫⁬‪⁭‌‫‪‏‏​⁭⁮‬‭‬‌⁮‬⁬‌⁯⁯‌‮(args);
label_1:
        int num1 = 432217700;
        while (true)
        {
          int num2 = 62327845;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              num4 = this.View is LayoutEditorView ? 1 : 0;
              goto label_16;
            case 1:
              num1 = (int) num3 * 899776043 ^ 1707084181;
              continue;
            case 2:
              int num6 = !flag1 ? -2019159653 : (num6 = -1965400082);
              int num7 = (int) num3 * 722040888;
              num1 = num6 ^ num7;
              continue;
            case 3:
              flag2 = true;
              num1 = (int) num3 * -1969208802 ^ 1352022135;
              continue;
            case 4:
              num5 = 0;
              break;
            case 5:
              num1 = (int) num3 * -89386269 ^ -792696650;
              continue;
            case 6:
              if (nullable.GetValueOrDefault() == flag2)
              {
                num5 = nullable.HasValue ? 1 : 0;
                break;
              }
              num1 = (int) num3 * 956485048 ^ -136728119;
              continue;
            case 7:
              LayoutEditorViewModel.\u206B⁮⁬‫‍‎​‮‬‍‭⁯‭⁪‭‫⁪‭‎⁫⁮‎‬⁯⁬‭‫‬‪‮‪‌‪‪‬⁬‏‪‫‌‮(this.View);
              num1 = (int) num3 * -909168828 ^ -221513866;
              continue;
            case 8:
              num1 = 635991835;
              continue;
            case 9:
              this.Pattern.Delete("");
              num1 = (int) num3 * -434036564 ^ 771102297;
              continue;
            case 10:
              num1 = (int) num3 * 363829336 ^ -245232924;
              continue;
            case 11:
              goto label_1;
            case 12:
              goto label_3;
            case 13:
              if (this.View != null)
              {
                num1 = (int) num3 * -1785316941 ^ 457674242;
                continue;
              }
              num4 = 0;
              goto label_16;
            default:
              goto label_22;
          }
          int num8;
          num1 = num8 = num5 != 0 ? 119165344 : (num8 = 635991835);
          continue;
label_16:
          flag1 = num4 != 0;
          num1 = 1764024463;
        }
label_22:
        return;
label_3:;
      }), 400);
    }

    internal void ApplyPattern()
    {
label_1:
      int num1 = 1754051099;
      while (true)
      {
        int num2 = 1495299277;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -1843622112 ^ 324889960;
            continue;
          case 1:
            num1 = (int) num3 * -1647476912 ^ 1472521032;
            continue;
          case 2:
            goto label_1;
          case 4:
            num1 = (int) num3 * 17173739 ^ 1558346319;
            continue;
          case 5:
            this.Engine.ActivePattern = this.pattern;
            num1 = (int) num3 * 190123113 ^ -375687618;
            continue;
          case 6:
            LayoutEditorViewModel.\u206A‌‭‮‏‎‍⁭⁫⁪⁭‫⁪‏⁫⁯‮⁫⁬‍​‫⁯‬⁭‬⁬⁫‬‏‍‫‮⁫‎⁮‮⁪⁪‭‮(ViewModelBase.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(840756860U));
            num1 = (int) num3 * -861706646 ^ -1682201740;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      IEnumerator<ZoomWindow> enumerator = this.Engine.SharedData.ActiveWindows.GetEnumerator();
      try
      {
label_12:
        int num2 = !LayoutEditorViewModel.\u206F​‏⁯⁯‎‮‮⁭‪‪​‍‬⁭‭⁫⁯‬⁫⁬‮‮⁫⁭‫⁭‪⁯​​‏⁪⁪‪⁫‍‎‪⁯‮((IEnumerator) enumerator) ? 103098590 : (num2 = 1598253786);
        while (true)
        {
          int num3 = 1495299277;
          uint num4;
          ZoomWindow current;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = 1598253786;
              continue;
            case 1:
              goto label_19;
            case 2:
              goto label_12;
            case 3:
              current = enumerator.Current;
              num2 = 11013717;
              continue;
            case 4:
              current.Refresh(true, false);
              num2 = (int) num4 * 1686689017 ^ -1399521604;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_19:;
      }
      finally
      {
        if (enumerator != null)
        {
label_17:
          int num2 = 1715368298;
          while (true)
          {
            int num3 = 1495299277;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_17;
              case 1:
                num2 = (int) num4 * 453982476 ^ 358784343;
                continue;
              case 3:
                LayoutEditorViewModel.\u206F⁬‏‮‪‌‎‬​​⁮⁫‍⁬⁮⁮‏⁬​‬‫⁪‪‬‌‏‌‏⁪‭⁬⁪‬‮‬‌‮⁬‮‎‮((IDisposable) enumerator);
                num2 = (int) num4 * -1638718586 ^ 1702373750;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
    }

    private WindowLayout GetWindowLayout(ZoomWindowType windowType, bool createWhenMissing)
    {
label_1:
      int num1 = -1458955800;
      WindowLayout windowLayout;
      while (true)
      {
        int num2 = -1699647271;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 1:
            flag = this.Pattern != null;
            num1 = (int) num3 * 1022663823 ^ 1696642200;
            continue;
          case 2:
            goto label_1;
          case 3:
            windowLayout = (WindowLayout) null;
            num1 = -1194092943;
            continue;
          case 4:
            num1 = (int) num3 * 1920909900 ^ 1679343041;
            continue;
          case 5:
            windowLayout = this.Pattern.GetWindowLayout(windowType, createWhenMissing);
            num1 = (int) num3 * -1989679802 ^ 1644384931;
            continue;
          case 6:
            int num4 = !flag ? -967970256 : (num4 = -648003268);
            int num5 = (int) num3 * 587213615;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = (int) num3 * 712240858 ^ -1687973878;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return windowLayout;
    }

    static bool \u200E‍‏‬​‫⁮‮‌‭⁮‪⁮‍‫⁮‫‬⁮‍⁫⁭‪⁮‭‍⁭‎⁮‌⁭‬‎‌‏‍⁬‪‮‭‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static bool \u200F‭⁭‭⁭‍⁬‍⁫⁬‬‍‬‮⁪‏⁮‬‌‍‬​‪⁭‌‎⁮⁮​‍‭​⁯‭⁫‎‬‫​‌‮([In] ViewModelBase obj0)
    {
      return obj0.get_IsInDesignMode();
    }

    static void \u206B⁮⁬‫‍‎​‮‬‍‭⁯‭⁪‭‫⁪‭‎⁫⁮‎‬⁯⁬‭‫‬‪‮‪‌‪‪‬⁬‏‪‫‌‮([In] Window obj0)
    {
      obj0.Close();
    }

    static void \u206A‌‭‮‏‎‍⁭⁫⁪⁭‫⁪‏⁫⁯‮⁫⁬‍​‫⁯‬⁭‬⁬⁫‬‏‍‫‮⁫‎⁮‮⁪⁪‭‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static bool \u206F​‏⁯⁯‎‮‮⁭‪‪​‍‬⁭‭⁫⁯‬⁫⁬‮‮⁫⁭‫⁭‪⁯​​‏⁪⁪‪⁫‍‎‪⁯‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u206F⁬‏‮‪‌‎‬​​⁮⁫‍⁬⁮⁮‏⁬​‬‫⁪‪‬‌‏‌‏⁪‭⁬⁪‬‮‬‌‮⁬‮‎‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static bool? \u202E‏‬‮⁭⁮⁬‭‎⁫‌⁮‮‭‎‎​‫⁬‪⁭‌‫‪‏‏​⁭⁮‬‭‬‌⁮‬⁬‌⁯⁯‌‮([In] WindowClosedEventArgs obj0)
    {
      return obj0.get_DialogResult();
    }
  }
}
