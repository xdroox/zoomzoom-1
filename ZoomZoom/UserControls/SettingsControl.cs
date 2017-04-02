// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.SettingsControl
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Telerik.Windows.Controls;
using ZoomZoom.ViewModels;

namespace ZoomZoom.UserControls
{
  public class SettingsControl : UserControl, IComponentConnector
  {
    public static readonly DependencyProperty EngineViewModelProperty = SettingsControl.\u206E‌‌⁭⁯⁯‏‮​‮‎⁮‍⁭‌⁯‮⁭‎⁯​‭⁪⁯⁯⁫‍‍⁭⁬​⁯⁪⁬‮‎‍‍⁪‮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4168708710U), SettingsControl.\u200C‏⁮‮⁪⁫‮‪⁪‫‫‎​​⁬‍⁬‪‍⁯‍‌‎⁮‍‬​⁬‪⁬⁪⁭⁬⁭‮​⁮⁯‬‭‮(__typeref (EngineViewModel)), SettingsControl.\u200C‏⁮‮⁪⁫‮‪⁪‫‫‎​​⁬‍⁬‪‍⁯‍‌‎⁮‍‬​⁬‪⁬⁪⁭⁬⁭‮​⁮⁯‬‭‮(__typeref (SettingsControl)), SettingsControl.\u206C‬‫⁫‪‌‬⁭‪⁭​‍⁫‪‮⁮‏‎⁫‏‭⁪⁪‭‏⁫⁬‭‫‪‫⁪‭⁯⁯‭‍⁭‪‌‮((object) null, new PropertyChangedCallback(SettingsControl.OnEngineViewModelChanged)));
    public static readonly DependencyProperty SettingsViewModelProperty;
    internal CheckBox cbDisplayHighlightWindows;
    internal CheckBox cbEnabledVideoToChatLinking;
    internal CheckBox cbAutoLayoutsDefaultStretchingEnabled;
    internal CheckBox cbAutoAttendence;
    internal CheckBox cbMinimumUserEnforced;
    internal RadNumericUpDown nudMinimumUserCount;
    internal CheckBox cbMaximumAttendenceDuration;
    internal RadNumericUpDown nudMaximumAttendenceDuration;
    internal CheckBox cbCheckCapabilitiesAfterJoin;
    internal CheckBox cbFindButtonsAfterJoin;
    internal CheckBox cbMoveNextAfterRemoved;
    internal CheckBox cbHammerAfterRemoved;
    internal ComboBox cbOnHoldAction;
    internal CheckBox cbTraceHookEvents;
    internal CheckBox cbTraceWindowEvents;
    internal CheckBox cbTraceChatEvents;
    internal CheckBox cbTraceActivityEvents;
    internal CheckBox cbTraceMeetingEvents;
    internal CheckBox cbTraceDataStorage;
    internal CheckBox cbTraceLayoutEvents;
    internal CheckBox cbTraceImageEvents;
    internal CheckBox cbTraceUserEvents;
    internal CheckBox cbTraceUserInterfaceEvents;
    internal CheckBox cbTraceApplicationEvents;
    private bool _contentLoaded;

    public EngineViewModel EngineViewModel
    {
      get
      {
label_1:
        int num1 = 1423409888;
        EngineViewModel engineViewModel;
        while (true)
        {
          int num2 = 221925967;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              engineViewModel = (EngineViewModel) SettingsControl.\u200D‏‎‪⁭⁬‪⁭‬‎‬‬‎‫‪‏⁮‏⁭‪⁫‫⁮⁫⁯‬‭​‮⁭‍⁫⁪⁫‫⁭‏‪‏‪‮((DependencyObject) this, SettingsControl.EngineViewModelProperty);
              num1 = (int) num3 * 1905307116 ^ 616829413;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return engineViewModel;
      }
      set
      {
        SettingsControl.\u206E‏‪‌⁭⁪‏⁫​⁪‌⁮‎⁭‫‏‬​‌‬‎‪​‏⁪‫⁯‮‌‫⁪⁯‪‪‭⁫‫‏‪⁮‮((DependencyObject) this, SettingsControl.EngineViewModelProperty, (object) value);
label_1:
        int num1 = -162663494;
        while (true)
        {
          int num2 = -2032752724;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 788993744 ^ -682481244;
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

    public SettingsViewModel SettingsViewModel
    {
      get
      {
label_1:
        int num1 = -434001636;
        SettingsViewModel settingsViewModel;
        while (true)
        {
          int num2 = -678253083;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              settingsViewModel = (SettingsViewModel) SettingsControl.\u200D‏‎‪⁭⁬‪⁭‬‎‬‬‎‫‪‏⁮‏⁭‪⁫‫⁮⁫⁯‬‭​‮⁭‍⁫⁪⁫‫⁭‏‪‏‪‮((DependencyObject) this, SettingsControl.SettingsViewModelProperty);
              num1 = (int) num3 * 959368807 ^ -51263408;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return settingsViewModel;
      }
      set
      {
label_1:
        int num1 = 358878926;
        while (true)
        {
          int num2 = 1195424773;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              SettingsControl.\u206E‏‪‌⁭⁪‏⁫​⁪‌⁮‎⁭‫‏‬​‌‬‎‪​‏⁪‫⁯‮‌‫⁪⁯‪‪‭⁫‫‏‪⁮‮((DependencyObject) this, SettingsControl.SettingsViewModelProperty, (object) value);
              num1 = (int) num3 * -121192409 ^ -1240571696;
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

    public SettingsViewModel ViewModel
    {
      get
      {
label_1:
        int num1 = 720082968;
        SettingsViewModel settingsViewModel;
        while (true)
        {
          int num2 = 1175220125;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1490570358 ^ 1467014146;
              continue;
            case 1:
              settingsViewModel = (SettingsViewModel) SettingsControl.\u206C‮⁮⁬‮⁭‌⁯⁯⁪⁫‭‭⁮⁯⁫⁪‪‪⁬⁬⁬⁯⁮⁯⁮‫⁮⁪⁬⁬‮​‪⁬⁮‌⁮‌‌‮(SettingsControl.\u200D‮⁬‎⁫‪⁯⁮⁭⁮⁫‌⁪‮‭⁯‬⁭‫‭‮‌‫⁯‍⁪‫‪‏⁪⁯‮‭⁮⁭⁬⁬⁪⁮‬‮((FrameworkElement) this), (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1336606281U));
              num1 = (int) num3 * -658501207 ^ 958763704;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return settingsViewModel;
      }
    }

    static SettingsControl()
    {
label_1:
      int num1 = -1465816035;
      while (true)
      {
        int num2 = -1791363064;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: type reference
            // ISSUE: type reference
            SettingsControl.SettingsViewModelProperty = SettingsControl.\u206E‌‌⁭⁯⁯‏‮​‮‎⁮‍⁭‌⁯‮⁭‎⁯​‭⁪⁯⁯⁫‍‍⁭⁬​⁯⁪⁬‮‎‍‍⁪‮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2059832663U), SettingsControl.\u200C‏⁮‮⁪⁫‮‪⁪‫‫‎​​⁬‍⁬‪‍⁯‍‌‎⁮‍‬​⁬‪⁬⁪⁭⁬⁭‮​⁮⁯‬‭‮(__typeref (SettingsViewModel)), SettingsControl.\u200C‏⁮‮⁪⁫‮‪⁪‫‫‎​​⁬‍⁬‪‍⁯‍‌‎⁮‍‬​⁬‪⁬⁪⁭⁬⁭‮​⁮⁯‬‭‮(__typeref (SettingsControl)), SettingsControl.\u206C‬‫⁫‪‌‬⁭‪⁭​‍⁫‪‮⁮‏‎⁫‏‭⁪⁪‭‏⁫⁬‭‫‪‫⁪‭⁯⁯‭‍⁭‪‌‮((object) null, new PropertyChangedCallback(SettingsControl.OnSettingsViewModelChanged)));
            num1 = (int) num3 * -1126407708 ^ -124581335;
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

    public SettingsControl()
    {
label_1:
      int num1 = 527481268;
      while (true)
      {
        int num2 = 922136015;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 1841418610 ^ -315492875;
            continue;
          case 1:
            num1 = (int) num3 * -965876493 ^ -1859684606;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * -325099961 ^ -544649474;
            continue;
          case 4:
            this.InitializeComponent();
            num1 = (int) num3 * -1826575233 ^ 244691850;
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

    private static void OnEngineViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
label_1:
      int num1 = -1534452031;
      while (true)
      {
        int num2 = -166062860;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1244766953 ^ 947751282;
            continue;
          case 1:
            ((SettingsControl) d).EngineViewModel = (EngineViewModel) e.NewValue;
            num1 = (int) num3 * 1617902710 ^ -1245103750;
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

    private static void OnSettingsViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
label_1:
      int num1 = -282600599;
      while (true)
      {
        int num2 = -1774295372;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            ((SettingsControl) d).SettingsViewModel = (SettingsViewModel) e.NewValue;
            num1 = (int) num3 * -1706295349 ^ -845913076;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * -700642870 ^ -71583616;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = -304082228;
      while (true)
      {
        int num2 = -1448922517;
        uint num3;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -906394695 ^ 409655815;
            continue;
          case 1:
            this._contentLoaded = true;
            num1 = -646073087;
            continue;
          case 2:
            uri = SettingsControl.\u202E‪⁪⁯‪‎‪⁯‬⁪​‮⁭⁭⁭⁮⁬⁮‬⁫⁬‭‎‎⁫⁬⁬‪‭⁫⁪‌‪‏‭⁮⁫⁭‍‌‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2925220230U), UriKind.Relative);
            num1 = (int) num3 * -1712429395 ^ -27344921;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -2086074461 ^ -546594820;
            continue;
          case 5:
            goto label_1;
          case 6:
            SettingsControl.\u200F‏‬‫⁫⁭⁮⁮‭⁫⁮‫⁮⁭‍‪⁯‌‮⁫⁬‪‎‫⁯⁫‮⁬‍⁬‍‏‍‫⁯⁭‮‎⁮‍‮((object) this, uri);
            num1 = (int) num3 * -1181541408 ^ 1369278792;
            continue;
          case 7:
            int num4 = !contentLoaded ? -2109970110 : (num4 = -1078535541);
            int num5 = (int) num3 * -317461488;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      int num1 = connectionId;
label_1:
      int num2 = 429600572;
      while (true)
      {
        int num3 = 1382891384;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 51U)
        {
          case 0:
label_6:
            this.cbTraceWindowEvents = (CheckBox) target;
            num2 = 419668234;
            continue;
          case 1:
label_10:
            this.cbTraceActivityEvents = (CheckBox) target;
            num2 = 2033304098;
            continue;
          case 2:
            num2 = (int) num4 * 1744519222 ^ 979686193;
            continue;
          case 3:
            num2 = (int) num4 * 994445811 ^ -77658749;
            continue;
          case 4:
            num2 = (int) num4 * -436618530 ^ -392227786;
            continue;
          case 5:
            goto label_3;
          case 6:
label_39:
            this.cbAutoLayoutsDefaultStretchingEnabled = (CheckBox) target;
            num2 = 792223346;
            continue;
          case 7:
            num2 = (int) num4 * -1575930965 ^ -220103484;
            continue;
          case 8:
label_19:
            this.cbOnHoldAction = (ComboBox) target;
            num2 = 356975739;
            continue;
          case 9:
label_12:
            this.nudMinimumUserCount = (RadNumericUpDown) target;
            num2 = 203952805;
            continue;
          case 10:
label_30:
            this.cbTraceLayoutEvents = (CheckBox) target;
            num2 = 1311491623;
            continue;
          case 11:
            num2 = (int) num4 * 975832450 ^ 1640741652;
            continue;
          case 12:
            num2 = (int) num4 * -1043496613 ^ -1053373003;
            continue;
          case 13:
label_14:
            this.cbDisplayHighlightWindows = (CheckBox) target;
            num2 = 1341574999;
            continue;
          case 14:
            num2 = (int) num4 * 166490357 ^ -1363060605;
            continue;
          case 15:
            num2 = (int) num4 * 2141568272 ^ -2124467376;
            continue;
          case 16:
label_26:
            this.cbHammerAfterRemoved = (CheckBox) target;
            num2 = 506446336;
            continue;
          case 17:
            num2 = (int) num4 * 1275732532 ^ 1018569192;
            continue;
          case 18:
label_53:
            this.cbTraceUserInterfaceEvents = (CheckBox) target;
            num2 = 1762212733;
            continue;
          case 19:
            num2 = (int) num4 * -205803669 ^ 837003422;
            continue;
          case 20:
            goto label_1;
          case 21:
            num2 = (int) num4 * 2054156587 ^ 884015903;
            continue;
          case 22:
            num2 = (int) num4 * -1493406778 ^ -1536678062;
            continue;
          case 23:
            num2 = (int) num4 * -405603139 ^ 1071941969;
            continue;
          case 24:
            num2 = (int) num4 * 1183022939 ^ -1545436206;
            continue;
          case 25:
            num2 = (int) num4 * 1766249601 ^ -287881056;
            continue;
          case 26:
label_8:
            SettingsControl.\u206B‏⁫‮⁬‭‏‍‎⁯‌‫‪‏‬​‫‪​‌‏‎‍‮‫⁯‮⁫⁪‍‫⁬‍‫‭⁯⁯⁪⁮⁫‮((FrameworkElement) target, new RoutedEventHandler(this.UserControl_Loaded));
            num2 = 1280878585;
            continue;
          case 27:
label_24:
            this.cbMoveNextAfterRemoved = (CheckBox) target;
            num2 = 674005018;
            continue;
          case 28:
            num2 = (int) num4 * 1267778348 ^ 1768425540;
            continue;
          case 29:
label_4:
            this.cbTraceImageEvents = (CheckBox) target;
            num2 = 1361891182;
            continue;
          case 30:
label_38:
            this.cbCheckCapabilitiesAfterJoin = (CheckBox) target;
            num2 = 952839005;
            continue;
          case 31:
label_7:
            this.cbEnabledVideoToChatLinking = (CheckBox) target;
            num2 = 1025738200;
            continue;
          case 32:
label_35:
            this.cbTraceChatEvents = (CheckBox) target;
            num2 = 1799790409;
            continue;
          case 33:
label_22:
            this.cbFindButtonsAfterJoin = (CheckBox) target;
            num2 = 738932203;
            continue;
          case 34:
            num2 = (int) num4 * 912542135 ^ -119825431;
            continue;
          case 35:
label_37:
            this.cbTraceHookEvents = (CheckBox) target;
            num2 = 506446336;
            continue;
          case 36:
            num2 = (int) num4 * 1446674836 ^ -1887821572;
            continue;
          case 37:
label_50:
            this.nudMaximumAttendenceDuration = (RadNumericUpDown) target;
            num2 = 506446336;
            continue;
          case 38:
label_16:
            this.cbTraceUserEvents = (CheckBox) target;
            num2 = 1460382;
            continue;
          case 39:
label_11:
            this.cbTraceMeetingEvents = (CheckBox) target;
            num2 = 215865478;
            continue;
          case 40:
label_33:
            this.cbMinimumUserEnforced = (CheckBox) target;
            num2 = 506446336;
            continue;
          case 41:
            num2 = (int) num4 * -1403807120 ^ -1503557344;
            continue;
          case 42:
label_13:
            this.cbAutoAttendence = (CheckBox) target;
            num2 = 367423597;
            continue;
          case 43:
label_25:
            this.cbTraceDataStorage = (CheckBox) target;
            num2 = 161163051;
            continue;
          case 44:
            num2 = (int) num4 * -779956749 ^ -852607150;
            continue;
          case 45:
label_51:
            this.cbTraceApplicationEvents = (CheckBox) target;
            num2 = 1160258102;
            continue;
          case 46:
            num2 = (int) num4 * -2051876445 ^ 1396376746;
            continue;
          case 47:
label_20:
            this.cbMaximumAttendenceDuration = (CheckBox) target;
            num2 = 506446336;
            continue;
          case 48:
            switch (num1)
            {
              case 1:
                goto label_8;
              case 2:
                goto label_14;
              case 3:
                goto label_7;
              case 4:
                goto label_39;
              case 5:
                goto label_13;
              case 6:
                goto label_33;
              case 7:
                goto label_12;
              case 8:
                goto label_20;
              case 9:
                goto label_50;
              case 10:
                goto label_38;
              case 11:
                goto label_22;
              case 12:
                goto label_24;
              case 13:
                goto label_26;
              case 14:
                goto label_19;
              case 15:
                goto label_37;
              case 16:
                goto label_6;
              case 17:
                goto label_35;
              case 18:
                goto label_10;
              case 19:
                goto label_11;
              case 20:
                goto label_25;
              case 21:
                goto label_30;
              case 22:
                goto label_4;
              case 23:
                goto label_16;
              case 24:
                goto label_53;
              case 25:
                goto label_51;
              default:
                num2 = (int) num4 * 61456887 ^ 776601015;
                continue;
            }
          case 49:
            num2 = (int) num4 * 392503612 ^ -1350822216;
            continue;
          case 50:
            this._contentLoaded = true;
            num2 = 506446336;
            continue;
          default:
            goto label_54;
        }
      }
label_54:
      return;
label_3:;
    }

    static object \u200D‏‎‪⁭⁬‪⁭‬‎‬‬‎‫‪‏⁮‏⁭‪⁫‫⁮⁫⁯‬‭​‮⁭‍⁫⁪⁫‫⁭‏‪‏‪‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u206E‏‪‌⁭⁪‏⁫​⁪‌⁮‎⁭‫‏‬​‌‬‎‪​‏⁪‫⁯‮‌‫⁪⁯‪‪‭⁫‫‏‪⁮‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static ResourceDictionary \u200D‮⁬‎⁫‪⁯⁮⁭⁮⁫‌⁪‮‭⁯‬⁭‫‭‮‌‫⁯‍⁪‫‪‏⁪⁯‮‭⁮⁭⁬⁬⁪⁮‬‮([In] FrameworkElement obj0)
    {
      return obj0.Resources;
    }

    static object \u206C‮⁮⁬‮⁭‌⁯⁯⁪⁫‭‭⁮⁯⁫⁪‪‪⁬⁬⁬⁯⁮⁯⁮‫⁮⁪⁬⁬‮​‪⁬⁮‌⁮‌‌‮([In] ResourceDictionary obj0, [In] object obj1)
    {
      return obj0[obj1];
    }

    static Uri \u202E‪⁪⁯‪‎‪⁯‬⁪​‮⁭⁭⁭⁮⁬⁮‬⁫⁬‭‎‎⁫⁬⁬‪‭⁫⁪‌‪‏‭⁮⁫⁭‍‌‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200F‏‬‫⁫⁭⁮⁮‭⁫⁮‫⁮⁭‍‪⁯‌‮⁫⁬‪‎‫⁯⁫‮⁬‍⁬‍‏‍‫⁯⁭‮‎⁮‍‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206B‏⁫‮⁬‭‏‍‎⁯‌‫‪‏‬​‫‪​‌‏‎‍‮‫⁯‮⁫⁪‍‫⁬‍‫‭⁯⁯⁪⁮⁫‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static Type \u200C‏⁮‮⁪⁫‮‪⁪‫‫‎​​⁬‍⁬‪‍⁯‍‌‎⁮‍‬​⁬‪⁬⁪⁭⁬⁭‮​⁮⁯‬‭‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static PropertyMetadata \u206C‬‫⁫‪‌‬⁭‪⁭​‍⁫‪‮⁮‏‎⁫‏‭⁪⁪‭‏⁫⁬‭‫‪‫⁪‭⁯⁯‭‍⁭‪‌‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new PropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u206E‌‌⁭⁯⁯‏‮​‮‎⁮‍⁭‌⁯‮⁭‎⁯​‭⁪⁯⁯⁫‍‍⁭⁬​⁯⁪⁬‮‎‍‍⁪‮‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.Register(obj0, obj1, obj2, obj3);
    }
  }
}
