// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.EngineView
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Telerik.Windows.Controls;
using ZoomZoom.Models.Windows;
using ZoomZoom.ViewModels;

namespace ZoomZoom.Views
{
  public class EngineView : Window, IComponentConnector
  {
    private static readonly object viewLock = EngineView.\u200D‎‍​‪​‭⁫‏⁪‪⁬⁫‬‎‌⁮⁪⁭‏‌‭‍⁫⁫‌‬⁬⁫⁮‬⁪​‬⁮⁫⁯‭⁫⁮‮();
    private ILog log = EngineView.\u206C‏⁯⁪‎‌⁫‪‪‪⁮‮⁬⁪⁪⁯⁭⁯‏​‬⁫‮‌​‎‎⁮‌‫⁫‍⁯⁭⁯‮⁯⁪⁬‌‮(EngineView.\u202B‭⁭‬⁬⁬⁫⁭‏‎‭‮⁭‎⁮⁯⁮‎‎‮‫⁪‏‏‬⁫⁪​‍⁬⁫‍⁬‎‏‭‏‮‏‏‮((MemberInfo) EngineView.\u200B⁭⁭⁮‌⁯⁬‌‭​‏⁪‬‎‬⁭‪‍‎‫‪‭‏‭⁭​‬‎‭‫​‍‮‌⁭⁯‏‍‮‍‮()));
    private DispatcherTimer windowTimer = (DispatcherTimer) null;
    private DateTime lastMovement = DateTime.MinValue;
    private DateTime mouseLeft = DateTime.MaxValue;
    private Engine engine;
    protected readonly IEventAggregator _eventAggregator;
    private SubscriptionToken token;
    private IntPtr handle;
    internal EngineView ZoomZoom;
    internal Grid MainGrid;
    internal ColumnDefinition RightColumn;
    internal RowDefinition StatusRow;
    internal RowDefinition BottomRow;
    internal System.Windows.Controls.Image ZoomZoomLogoImage;
    internal RadDropDownButton ddbMain;
    internal RadDropDownButton ddbMeetings;
    internal CheckBox cbAutoattendentMinimumParticipantsEnforced;
    internal TextBox tbAutoattendentMinimumParticipants;
    internal CheckBox cbAutoattendentMaximumDuration;
    internal TextBox tbAutoattendentMaximumDuration;
    internal ComboBox cbOnHoldAction;
    internal ComboBox cbOnRemovalAction;
    internal RadDropDownButton ddbWindows;
    internal CheckBox cbAutoCaptureVideoImages;
    internal RadNumericUpDown nudAutoCaptureVideoInterval;
    internal CheckBox cbAutoSpotlightEnabled;
    internal RadNumericUpDown nudAutoSpotlightInterval;
    internal Label lPrimaryMonitor;
    internal ComboBox cbPrimaryMonitor;
    internal Label lAction;
    internal ComboBox cbPatterns;
    internal Button btnApplyPattern;
    internal Button btnEditPattern;
    internal Button btnCopyPattern;
    internal Button btnDeletePattern;
    internal Label lAutoCaptureVideoWindows;
    internal RadDropDownButton ddbHostActions;
    internal RadDropDownButton ddbLogging;
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
    internal RadDropDownButton ddbQuick;
    internal Button btnOpenImageHistoryViewCommand;
    internal ComboBox cbNewActivity;
    private bool _contentLoaded;

    internal EngineViewModel ViewModel
    {
      get
      {
label_1:
        int num1 = -1596585761;
        EngineViewModel engineViewModel;
        while (true)
        {
          int num2 = -1461055178;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -705558674 ^ 1467629548;
              continue;
            case 1:
              engineViewModel = ((ViewModelLocator) EngineView.\u202E⁭⁫‬‭⁯‍⁮‎⁪‍‭‌⁭‏‫⁫‍‫⁪⁭⁭⁮‌⁯‬‪⁯‌‭‍​⁭‪⁫⁪‍⁭⁬⁬‮((FrameworkElement) this, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3860284910U))).EngineViewModel;
              num1 = (int) num3 * -755446525 ^ -1224477103;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return engineViewModel;
      }
    }

    public Engine Engine
    {
      get
      {
label_1:
        int num1 = -2034410040;
        Engine engine;
        while (true)
        {
          int num2 = -90755374;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              engine = this.engine;
              num1 = (int) num3 * -1867998596 ^ 350558906;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return engine;
      }
      set
      {
        this.engine = value;
      }
    }

    public DispatcherTimer WindowTimer
    {
      get
      {
        DispatcherTimer windowTimer = this.windowTimer;
label_1:
        int num1 = -2031795660;
        while (true)
        {
          int num2 = -756439837;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 597322661 ^ 1415593048;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowTimer;
      }
      set
      {
label_1:
        int num1 = 250292977;
        while (true)
        {
          int num2 = 1800844260;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.windowTimer = value;
              num1 = (int) num3 * 688471122 ^ -363346510;
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

    public IntPtr Handle
    {
      get
      {
label_1:
        int num1 = 550368715;
        IntPtr handle;
        while (true)
        {
          int num2 = 1955127063;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              handle = this.handle;
              num1 = (int) num3 * -29957812 ^ 1402184870;
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

    public EngineView()
    {
label_1:
      int num1 = -303476466;
      while (true)
      {
        int num2 = -227258191;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -1797929684 ^ 256065740;
            continue;
          case 1:
            ((CompositePresentationEvent<WindowMovementPayload>) this._eventAggregator.GetEvent<MoveZoomZoomWindow>()).Subscribe(new Action<WindowMovementPayload>(this.OnMoveWindow), (ThreadOption) 1, true, (Predicate<WindowMovementPayload>) (obj =>
            {
label_1:
              int num2 = -1683762980;
              bool flag;
              while (true)
              {
                int num3 = -849463393;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 1:
                    flag = obj.WindowType == ZoomWindowType.ZoomZoomMain;
                    num2 = (int) num4 * 38747818 ^ -904353116;
                    continue;
                  case 2:
                    goto label_1;
                  default:
                    goto label_4;
                }
              }
label_4:
              return flag;
            }));
            num1 = -219837677;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.InitializeComponent();
            this._eventAggregator = ApplicationService.Instance.EventAggregator;
            this.token = ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Subscribe(new Action<ViewEventPayload>(this.HandleWindowEvent), (ThreadOption) 1);
            num1 = (int) num3 * 1775672792 ^ -635905382;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * 826966279 ^ -326699400;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void HandleWindowEvent(ViewEventPayload obj)
    {
label_1:
      int num1 = 303028382;
      while (true)
      {
        int num2 = 335575265;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 1992750884 ^ -1308355452;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.Close();
            num1 = (int) num3 * 801012164 ^ -371123111;
            continue;
          case 3:
            goto label_1;
          case 4:
            num4 = !this.Handle.Equals((object) IntPtr.Zero) ? 1 : 0;
            break;
          case 5:
            if (!(obj.Handle == this.Handle))
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -78211874 ^ -1341281939;
            continue;
          default:
            goto label_11;
        }
        int num5;
        num1 = num5 = num4 != 0 ? 2056038967 : (num5 = 510801156);
      }
label_11:
      return;
label_3:;
    }

    private void OnMoveWindow(WindowMovementPayload obj)
    {
      bool flag1 = this.lastMovement.AddSeconds(1.0) < DateTime.Now;
label_1:
      int num1 = -1354838770;
      object viewLock;
      while (true)
      {
        int num2 = -703651076;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * -1447197644 ^ -1646620492;
            continue;
          case 1:
            if (flag1)
            {
              num1 = (int) num3 * 360301380 ^ -1711136627;
              continue;
            }
            goto label_20;
          case 3:
            viewLock = EngineView.viewLock;
            num1 = (int) num3 * -1492218878 ^ -1464938505;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_20:
      return;
label_7:
      bool flag2 = false;
      try
      {
        Monitor.Enter(viewLock, ref flag2);
label_9:
        int num2 = -308035134;
        while (true)
        {
          int num3 = -703651076;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              this.Top = (double) obj.Y;
              num2 = (int) num4 * 633239290 ^ -1485627255;
              continue;
            case 2:
              this.lastMovement = DateTime.Now;
              num2 = (int) num4 * 833081873 ^ -1472433114;
              continue;
            case 3:
              goto label_9;
            case 4:
              this.Left = (double) obj.X;
              num2 = (int) num4 * -618477092 ^ 251299883;
              continue;
            case 5:
              num2 = (int) num4 * 61254939 ^ 1269012983;
              continue;
            case 6:
              num2 = (int) num4 * 1215671670 ^ 1451706818;
              continue;
            case 7:
              this.Activate();
              num2 = (int) num4 * -113421642 ^ 1085607159;
              continue;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_18:
          int num2 = -62445441;
          while (true)
          {
            int num3 = -703651076;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 1942903441 ^ 1461036525;
                continue;
              case 2:
                goto label_18;
              case 3:
                Monitor.Exit(viewLock);
                num2 = (int) num4 * -921417000 ^ -1363305704;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:;
    }

    public void Initialize(Engine engine)
    {
      try
      {
label_2:
        int num1 = -2006456142;
        while (true)
        {
          int num2 = -431858669;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 988596179 ^ 1982587009;
              continue;
            case 1:
              this.ViewModel.Initialize(this, engine);
              num1 = (int) num3 * -1851683723 ^ 422567986;
              continue;
            case 2:
              goto label_14;
            case 3:
              goto label_2;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_14:;
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -1024038947;
        while (true)
        {
          int num2 = -431858669;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_7;
            case 1:
              EngineView.\u206E⁭⁬⁫‎‏‍‍‮⁪⁯⁮‍⁬⁫⁬⁬‫‍​​⁫‬⁯‏‬‬‮‪⁬⁮​​‮⁮‬⁪‬‪‫‮(this.log, (object) ex);
              num1 = (int) num3 * -855647589 ^ -612941688;
              continue;
            case 2:
              num1 = (int) num3 * 685441669 ^ 1314867452;
              continue;
            case 3:
              goto label_9;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_7:;
      }
    }

    private void Window_Unloaded(object sender, RoutedEventArgs e)
    {
      try
      {
label_2:
        int num1 = 398792042;
        while (true)
        {
          int num2 = 645225608;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 624852806 ^ 281736951;
              continue;
            case 1:
              EngineView.\u202B⁬⁫‪‮‏‪⁪⁫‮‮⁫‭‎⁯‍⁮‮​‭‍‏⁪‍‪​‏⁭​⁪‍‪⁯⁮‭⁪‏‬‌‏‮(EngineView.\u202C‎‮‬⁪⁪​‮⁮​⁭⁪‮‎‮⁫‭‮⁫‮⁪‮‏⁪⁪⁬‮‫⁯‏⁭‏‍‏⁪⁮‫‎‮‫‮());
              num1 = (int) num3 * -1015212525 ^ -693438843;
              continue;
            case 2:
              EngineView.\u202D‪​‮⁭‌‌‪‫‬‌‭⁫‏⁭‬⁯⁯⁪‌‬‏⁭⁬⁫‏‪‌⁮⁫⁯‏‬‎⁫⁫‌‬⁭⁫‮(this.WindowTimer);
              num1 = (int) num3 * 1511191483 ^ 611385113;
              continue;
            case 3:
              num1 = (int) num3 * -1770095012 ^ -1578384242;
              continue;
            case 4:
              goto label_15;
            case 5:
              goto label_2;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_15:;
      }
      catch (Exception ex)
      {
label_11:
        int num1 = 482021833;
        while (true)
        {
          int num2 = 645225608;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_11;
            case 1:
              num1 = (int) num3 * -511436829 ^ -1468587265;
              continue;
            case 2:
              goto label_9;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_9:;
      }
    }

    private void ZoomZoom_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
label_1:
      int num1 = 1879871820;
      while (true)
      {
        int num2 = 389772769;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            EngineView.\u206D⁬‭‮‪⁭⁪​‬⁮⁭‎⁬‫⁮‮‬‍‌​⁪‫‪⁮​⁫⁮⁪⁬‌⁮‌‫⁯⁭⁭⁪‍‪⁪‮((Window) this);
            num1 = (int) num3 * -986155724 ^ -927237757;
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

    private void ZoomZoom_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      this.ClosePanels();
label_1:
      int num1 = -722465499;
      while (true)
      {
        int num2 = -571881701;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            DoubleAnimation doubleAnimation1 = EngineView.\u206A‏⁯⁬‮‬‪‍‪‍⁭‎‬‪‮⁪‌‎⁬⁯​⁮⁯⁭‬⁮⁪⁮⁪⁪‍‪⁬‭‭⁪​‪‫‎‮();
            double? nullable1 = new double?(EngineView.\u206E​‍⁯‫‍⁭‮‎‪‪‬⁭‍‫‫‍‮⁯‌‮⁪⁯‫⁬‬⁭‌⁭‌⁬‪​‫‮‪⁯⁮‮((UIElement) this) ? 0.0 : 1.0);
            EngineView.\u202E⁭‪​‍⁮‪‪‎‪‫⁫⁮‫‌⁫‭‫⁪‪‏⁪‭‬⁬⁮‬‏⁯⁪⁯‬‫⁭‍‍‭⁪‌‭‮(doubleAnimation1, nullable1);
            double? nullable2 = new double?(EngineView.\u206E​‍⁯‫‍⁭‮‎‪‪‬⁭‍‫‫‍‮⁯‌‮⁪⁯‫⁬‬⁭‌⁭‌⁬‪​‫‮‪⁯⁮‮((UIElement) this) ? 1.0 : 0.0);
            EngineView.\u206D‍⁭⁭‫⁮​⁭‍⁭⁪‍‬⁯⁫‍⁪‬⁫‮⁬‌⁬‎‬‫⁮‪‪‍‪‎⁬‬⁪‌⁭‎⁮‪‮(doubleAnimation1, nullable2);
            Duration duration = (Duration) TimeSpan.FromSeconds(0.5);
            EngineView.\u206F⁪⁪​‎⁭⁭⁬‬‪⁫‫⁭‮⁭‎⁪‭⁮‎‏⁫⁪⁫‪⁪​‭⁮‏‍‌​‏‫‍‭‭‌⁬‮((Timeline) doubleAnimation1, duration);
            DoubleAnimation doubleAnimation2 = doubleAnimation1;
            this.\u202A‭‌⁬‫‌‭‌‭⁪‫⁫‎‎‬‎‏‏⁫⁮⁯‮⁮‫‮⁮‮‮‎⁯‎⁫‭⁬‏‌⁬⁮⁯‫‮(UIElement.OpacityProperty, (AnimationTimeline) doubleAnimation2);
            num1 = -225209168;
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

    private void ClosePanels()
    {
label_1:
      int num1 = 1746927655;
      while (true)
      {
        int num2 = 899472708;
        uint num3;
        ViewModelLocator viewModelLocator;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            int num4 = viewModelLocator != null ? 1988619199 : (num4 = 53266192);
            int num5 = (int) num3 * -390078481;
            num1 = num4 ^ num5;
            continue;
          case 1:
            viewModelLocator = EngineView.\u206A‬​​‎⁯‫⁮⁮​⁭⁭⁪‌‌⁬‍⁯‎​‪‮⁬‍⁬⁪‫​‭⁭⁯​​‮‫⁪⁮​⁮⁭‮(EngineView.\u200D⁫​⁫⁪‫⁮⁬‬⁬⁬⁪‌‍‪‏‫‭⁯⁭​‫⁭⁪⁯‪‭⁯⁭‬‏‍‏‮‫​⁭⁬⁯‭‮((FrameworkElement) this), (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(219485482U)) as ViewModelLocator;
            num1 = (int) num3 * -1895109462 ^ 963148248;
            continue;
          case 2:
            goto label_1;
          case 3:
            viewModelLocator.SettingsViewModel.EngineView_DisplayQuickLinkBar = true;
            num1 = (int) num3 * 1566182586 ^ -664753268;
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

    private void ZoomZoom_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = -1270300440;
      while (true)
      {
        int num2 = -1724632473;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            this.ViewModel.ViewHandle = this.Handle;
            num1 = (int) num3 * 975294153 ^ 447743796;
            continue;
          case 1:
            this.ViewModel.SettingsViewModel = ((ViewModelLocator) EngineView.\u206A‬​​‎⁯‫⁮⁮​⁭⁭⁪‌‌⁬‍⁯‎​‪‮⁬‍⁬⁪‫​‭⁭⁯​​‮‫⁪⁮​⁮⁭‮(EngineView.\u200D⁫​⁫⁪‫⁮⁬‬⁬⁬⁪‌‍‪‏‫‭⁯⁭​‫⁭⁪⁯‪‭⁯⁭‬‏‍‏‮‫​⁭⁬⁯‭‮((FrameworkElement) this), (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(219485482U))).SettingsViewModel;
            num1 = (int) num3 * -869204568 ^ 896571435;
            continue;
          case 2:
            goto label_3;
          case 3:
            EngineView.\u202C⁭‫‍‌‪‭‏​⁮‫⁯⁮‫⁬⁯‮⁭‪‭⁫‏⁭‬⁯⁭⁭⁫⁫‎⁭⁮‏‌‪⁫⁫‌‭‎‮(this.WindowTimer, new EventHandler(this.WindowTimer_Tick));
            num1 = (int) num3 * -697108364 ^ 1422055321;
            continue;
          case 4:
            int num5 = !flag ? -219387387 : (num5 = -2053601692);
            int num6 = (int) num3 * -1525273707;
            num1 = num5 ^ num6;
            continue;
          case 5:
            this.Handle = EngineView.\u200F⁫⁫‬‎‏‎‌‬⁯‎⁫⁯‏‫‍⁮‏‏‭‎​‎⁭⁮‮‫⁪‏‭‬⁮‌‏⁭⁪‮‪‎‌‮(EngineView.\u202C‏​‏‬‍⁫‎⁪⁯‫⁭‎⁫‍⁫⁯‍‫‫‌‍‮‫‪​‫⁭‏‎⁫⁭‮‭⁫‍‍​​‪‮((Window) this));
            num1 = (int) num3 * -1569222535 ^ 1831193763;
            continue;
          case 6:
            num4 = this.Engine.WindowManager != null ? 1 : 0;
            break;
          case 7:
            num1 = (int) num3 * -179105640 ^ -2014346287;
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num3 * 484720243 ^ 1979566111;
            continue;
          case 10:
            if (this.Engine != null)
            {
              num1 = (int) num3 * 413808154 ^ 1466034741;
              continue;
            }
            num4 = 0;
            break;
          case 11:
            this.Engine = Engine.Instance;
            num1 = (int) num3 * 1673253943 ^ 1500231658;
            continue;
          case 12:
            this.Engine.WindowManager.RegisterWindow(this.Handle, ZoomWindowType.ZoomZoomMain);
            num1 = (int) num3 * -562699247 ^ 308996904;
            continue;
          case 13:
            this.WindowTimer = EngineView.\u200D‌⁮‮⁫⁮‎‫‭‍⁬‌‬‎‭‏​⁮‭⁪‬‎⁬‌‪⁭⁯⁫‎‬‫‫⁪‬‬⁮‭‏⁪‬‮(DispatcherPriority.Normal);
            num1 = (int) num3 * -671183801 ^ -1058653179;
            continue;
          default:
            goto label_19;
        }
        flag = num4 != 0;
        num1 = -1815764385;
      }
label_19:
      return;
label_3:;
    }

    private void WindowTimer_Tick(object sender, EventArgs e)
    {
      try
      {
label_2:
        int num1 = 1897868161;
        while (true)
        {
          int num2 = 1925190431;
          uint num3;
          ZoomWindow window;
          Rectangle defaultRectangle;
          bool flag1;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              num1 = (int) num3 * 800696462 ^ -1275848027;
              continue;
            case 1:
              if ((double) defaultRectangle.Top != this.Top)
              {
                num4 = 1;
                break;
              }
              num1 = (int) num3 * -768267974 ^ 1016897312;
              continue;
            case 2:
              window = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
              flag2 = window != null;
              num1 = (int) num3 * -74339736 ^ -1248958016;
              continue;
            case 3:
              num1 = 190399338;
              continue;
            case 4:
              window.Refresh(true, false);
              window.ApplyLayoutPattern((object) null);
              this.Activate();
              num1 = (int) num3 * -1350530278 ^ 379084567;
              continue;
            case 5:
              defaultRectangle = window.DefaultRectangle;
              num4 = (double) defaultRectangle.Left != this.Left ? 1 : 0;
              break;
            case 6:
              goto label_2;
            case 7:
              defaultRectangle = window.DefaultRectangle;
              num1 = (int) num3 * 61778524 ^ -1173415510;
              continue;
            case 8:
              int num5 = flag1 ? 529579527 : (num5 = 889097781);
              int num6 = (int) num3 * -175163358;
              num1 = num5 ^ num6;
              continue;
            case 9:
              goto label_26;
            case 10:
              num1 = 1282088920;
              continue;
            case 11:
              int num7 = !flag2 ? 1616712786 : (num7 = 519730770);
              int num8 = (int) num3 * -171827946;
              num1 = num7 ^ num8;
              continue;
            default:
              goto label_22;
          }
          flag1 = num4 != 0;
          num1 = 1957921823;
        }
label_22:
        return;
label_26:;
      }
      catch (Exception ex)
      {
label_20:
        int num1 = 957603659;
        while (true)
        {
          int num2 = 1925190431;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 453720847 ^ -1668284972;
              continue;
            case 1:
              this.log.Error((object) ex);
              num1 = (int) num3 * -1732595652 ^ 1876611352;
              continue;
            case 2:
              goto label_18;
            case 3:
              goto label_20;
            case 4:
              num1 = (int) num3 * 489173471 ^ 1406177894;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_18:;
      }
    }

    private void ZoomZoom_Closing(object sender, CancelEventArgs e)
    {
      bool flag = this.Engine != null;
label_1:
      int num1 = -673523491;
      while (true)
      {
        int num2 = -919674158;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -793863719 ^ 1953166537;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * -436497499 ^ -318987423;
            continue;
          case 4:
            this.Engine.CancelExecution();
            num1 = (int) num3 * 83253108 ^ 405485597;
            continue;
          case 5:
            int num4 = !flag ? 1352472144 : (num4 = 1366682679);
            int num5 = (int) num3 * -1404491518;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void ZoomZoom_MouseEnter(object sender, MouseEventArgs e)
    {
      this.mouseLeft = DateTime.MaxValue;
      this.BottomRow.Height = new GridLength(25.0);
label_1:
      int num1 = -1109694464;
      while (true)
      {
        int num2 = -662945754;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -294967636 ^ -948336917;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      this.RightColumn.Width = new GridLength(50.0);
    }

    private void ZoomZoom_MouseLeave(object sender, MouseEventArgs e)
    {
label_1:
      int num1 = -1045908882;
      while (true)
      {
        int num2 = -760376584;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * -3694806 ^ 1859980402;
            continue;
          case 1:
            this.mouseLeft = DateTime.Now;
            num1 = (int) num3 * -902364070 ^ -1142680896;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.BottomRow.Height = new GridLength(0.0);
            this.RightColumn.Width = new GridLength(0.0);
            num1 = (int) num3 * 879431776 ^ -1635395013;
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

    private void ZoomZoom_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
    }

    private void ZoomZoom_Unloaded(object sender, RoutedEventArgs e)
    {
    }

    private void ZoomZoom_LocationChanged(object sender, EventArgs e)
    {
label_1:
      int num1 = -1963704464;
      List<ZoomWindowType> zoomWindowTypeList;
      while (true)
      {
        int num2 = -535686164;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            zoomWindowTypeList = new List<ZoomWindowType>()
            {
              ZoomWindowType.Meeting,
              ZoomWindowType.Join,
              ZoomWindowType.AccountPanel,
              ZoomWindowType.ManyCamBroadcast
            };
            num1 = (int) num3 * -1535535932 ^ 1721991919;
            continue;
          case 2:
            if (!(this.lastMovement.AddSeconds(1.0) < DateTime.Now))
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 624317429 ^ 305684821;
            continue;
          case 3:
            goto label_1;
          case 4:
            if (flag)
            {
              num1 = (int) num3 * -1952010254 ^ -936066814;
              continue;
            }
            goto label_47;
          case 5:
            num4 = this.Engine != null ? 1 : 0;
            break;
          default:
            goto label_11;
        }
        flag = num4 != 0;
        num1 = -307349436;
      }
label_47:
      return;
label_11:
      using (List<ZoomWindowType>.Enumerator enumerator = zoomWindowTypeList.GetEnumerator())
      {
label_16:
        int num2 = !enumerator.MoveNext() ? -239514123 : (num2 = -695797566);
        while (true)
        {
          int num3 = -535686164;
          uint num4;
          ZoomWindowType current;
          ZoomWindow window;
          bool flag1;
          System.Drawing.Point location;
          bool flag2;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 21U)
          {
            case 0:
              window = this.Engine.GetWindow(current);
              flag1 = window != null;
              num2 = (int) num4 * 1465758393 ^ -516935194;
              continue;
            case 1:
              int num6 = flag1 ? 424569557 : (num6 = 1048981499);
              int num7 = (int) num4 * 799096665;
              num2 = num6 ^ num7;
              continue;
            case 2:
              num2 = -728467981;
              continue;
            case 5:
              num2 = (int) num4 * 1552791407 ^ 2031676902;
              continue;
            case 6:
              current = enumerator.Current;
              num2 = -294628710;
              continue;
            case 7:
              num2 = (int) num4 * -915556919 ^ -520521812;
              continue;
            case 8:
              int num8 = flag2 ? -1164088261 : (num8 = -1957562859);
              int num9 = (int) num4 * -1607980599;
              num2 = num8 ^ num9;
              continue;
            case 9:
              num5 = (double) (location.Y + 5) != this.Top ? 1 : 0;
              break;
            case 10:
              goto label_16;
            case 11:
              location = window.Location;
              num2 = (int) num4 * 1424945035 ^ 1788880268;
              continue;
            case 12:
              location = window.Location;
              this.Left = (double) location.X;
              num2 = (int) num4 * 2094694670 ^ -1013298310;
              continue;
            case 13:
              num2 = -695797566;
              continue;
            case 14:
              num2 = (int) num4 * -1522610095 ^ 2088854403;
              continue;
            case 15:
              location = window.Location;
              num2 = (int) num4 * 814291580 ^ 289001050;
              continue;
            case 16:
              num2 = (int) num4 * -1704925972 ^ -684416830;
              continue;
            case 17:
              location = window.Location;
              this.Top = (double) location.Y;
              num2 = (int) num4 * -962771145 ^ -365940010;
              continue;
            case 18:
              num2 = (int) num4 * 1429789904 ^ -1362197762;
              continue;
            case 19:
              if ((double) location.X != this.Left + 5.0)
              {
                num5 = 1;
                break;
              }
              num2 = (int) num4 * 1010083117 ^ -1582394099;
              continue;
            case 20:
              num2 = (int) num4 * -1273464612 ^ -856112895;
              continue;
            default:
              goto label_37;
          }
          flag2 = num5 != 0;
          num2 = -262494021;
        }
      }
label_37:
      object viewLock = EngineView.viewLock;
      bool flag3 = false;
      try
      {
        Monitor.Enter(viewLock, ref flag3);
label_39:
        int num2 = -1464246895;
        while (true)
        {
          int num3 = -535686164;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              this.lastMovement = DateTime.Now;
              num2 = (int) num4 * 1609529 ^ -1741460427;
              continue;
            case 1:
              num2 = (int) num4 * -239360356 ^ -879553308;
              continue;
            case 2:
              goto label_39;
            case 3:
              num2 = (int) num4 * 1647314930 ^ -2067133158;
              continue;
            default:
              goto label_51;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_45:
          int num2 = -1093398186;
          while (true)
          {
            int num3 = -535686164;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                num2 = (int) num4 * -2081214041 ^ 2080396303;
                continue;
              case 2:
                Monitor.Exit(viewLock);
                num2 = (int) num4 * -1266851066 ^ 783385101;
                continue;
              case 3:
                goto label_45;
              default:
                goto label_50;
            }
          }
        }
label_50:;
      }
label_51:;
    }

    private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
      Regex regex = EngineView.\u200F‍‌⁬‪⁫⁬⁮‫‪‭‬‌⁭‍⁪‎⁮‮⁪‮⁬⁭⁫‎‮‪‭⁯‍​⁭​‎​⁮‌‏‏‍‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3437918530U));
label_1:
      int num1 = 2103322602;
      while (true)
      {
        int num2 = 7599892;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            EngineView.\u202E‌⁪⁫⁯‬‍‫⁫‏‮‫‍‎⁭‏‪​‍‬‎‍⁪​⁪⁪‬⁮⁪⁬‮‭‎​‎‭⁫⁫‭⁪‮((RoutedEventArgs) e, EngineView.\u206F⁬‫⁮‌‍‬⁬⁮​‮‌​‫​‫‏‌‎⁬‫​‪‭⁯⁮⁫​⁫⁬⁪‭⁮⁪⁬⁮‍⁫⁫‮‮(regex, EngineView.\u206F‭‌⁪⁯⁪‎⁮⁯‬⁪‭⁭‍⁭‫‭‬‫‪‪‏‎‍‏‬‏‪⁮⁪⁬⁫‬‬⁮‎⁭​‌⁯‮(e)));
            num1 = (int) num3 * -1835870801 ^ -1183587339;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
label_1:
      int num1 = -167130947;
      while (true)
      {
        int num2 = -2080796495;
        uint num3;
        bool contentLoaded;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 543221174 ^ -2123030817;
            continue;
          case 2:
            int num4 = !contentLoaded ? -710435044 : (num4 = -1381451406);
            int num5 = (int) num3 * -203445734;
            num1 = num4 ^ num5;
            continue;
          case 3:
            this._contentLoaded = true;
            EngineView.\u206C‍⁮‮‎‎⁭‎‭‫⁬‍​‪‍‏⁮‌‪‬‬‎⁮‍‏⁮‎‬⁯⁯‭‌⁬⁭⁮‮‭⁪⁫‫‮((object) this, EngineView.\u206C‪‌‮‮⁫⁬‏⁮⁫​‎‌‫‮⁭‭⁬‮⁫⁪⁫⁬‭⁭‫‌⁪⁭‏‌‎‬⁬⁪⁯⁮⁮⁬‮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4229861783U), UriKind.Relative));
            num1 = -1566592691;
            continue;
          case 4:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * 1729830482 ^ -627682515;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      int num1 = connectionId;
label_1:
      int num2 = 760105865;
      while (true)
      {
        int num3 = 781678163;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 87U)
        {
          case 0:
label_68:
            this.StatusRow = (RowDefinition) target;
            num2 = 730375995;
            continue;
          case 1:
label_28:
            this.cbTraceLayoutEvents = (CheckBox) target;
            num2 = 730375995;
            continue;
          case 2:
label_65:
            this.ddbMeetings = (RadDropDownButton) target;
            num2 = 1379739944;
            continue;
          case 3:
            num2 = (int) num4 * 1668832858 ^ 937982237;
            continue;
          case 4:
            switch (num1)
            {
              case 1:
                goto label_59;
              case 2:
                goto label_85;
              case 3:
                goto label_47;
              case 4:
                goto label_68;
              case 5:
                goto label_16;
              case 6:
                goto label_40;
              case 7:
                goto label_80;
              case 8:
                goto label_65;
              case 9:
                goto label_58;
              case 10:
                goto label_27;
              case 11:
                goto label_33;
              case 12:
                goto label_55;
              case 13:
                goto label_10;
              case 14:
                goto label_84;
              case 15:
                goto label_88;
              case 16:
                goto label_54;
              case 17:
                goto label_6;
              case 18:
                goto label_73;
              case 19:
                goto label_66;
              case 20:
                goto label_52;
              case 21:
                goto label_78;
              case 22:
                goto label_22;
              case 23:
                goto label_69;
              case 24:
                goto label_36;
              case 25:
                goto label_71;
              case 26:
                goto label_13;
              case 27:
                goto label_45;
              case 28:
                goto label_11;
              case 29:
                goto label_48;
              case 30:
                goto label_57;
              case 31:
                goto label_25;
              case 32:
                goto label_41;
              case 33:
                goto label_74;
              case 34:
                goto label_9;
              case 35:
                goto label_87;
              case 36:
                goto label_21;
              case 37:
                goto label_28;
              case 38:
                goto label_67;
              case 39:
                goto label_44;
              case 40:
                goto label_46;
              case 41:
                goto label_83;
              case 42:
                goto label_42;
              case 43:
                goto label_35;
              case 44:
                goto label_61;
              default:
                num2 = (int) num4 * -1061948563 ^ -1238627223;
                continue;
            }
          case 5:
label_40:
            this.ZoomZoomLogoImage = (System.Windows.Controls.Image) target;
            num2 = 1023016893;
            continue;
          case 6:
            num2 = (int) num4 * -844001249 ^ 1706890609;
            continue;
          case 7:
label_6:
            this.nudAutoCaptureVideoInterval = (RadNumericUpDown) target;
            num2 = 1133085568;
            continue;
          case 8:
label_48:
            this.ddbHostActions = (RadDropDownButton) target;
            num2 = 800899759;
            continue;
          case 9:
            num2 = (int) num4 * -999057894 ^ 1577247627;
            continue;
          case 10:
            num2 = (int) num4 * 51214496 ^ 586895515;
            continue;
          case 11:
label_41:
            this.cbTraceWindowEvents = (CheckBox) target;
            num2 = 1515827272;
            continue;
          case 12:
label_83:
            this.cbTraceApplicationEvents = (CheckBox) target;
            num2 = 730375995;
            continue;
          case 13:
label_67:
            this.cbTraceImageEvents = (CheckBox) target;
            num2 = 193883744;
            continue;
          case 14:
label_78:
            this.cbPrimaryMonitor = (ComboBox) target;
            num2 = 730375995;
            continue;
          case 15:
            EngineView.\u202D‌​​⁭‍‫‫‬‌‍‮‌‫‏⁮⁫‮‭⁪‬‏⁭⁪‫‭‌⁪‬⁫⁫‌​‮⁫⁭‮⁯‌⁫‮((UIElement) this.ZoomZoom, new MouseButtonEventHandler(this.ZoomZoom_MouseLeftButtonDown));
            num2 = (int) num4 * 2111284856 ^ 744337164;
            continue;
          case 16:
label_57:
            this.ddbLogging = (RadDropDownButton) target;
            num2 = 730375995;
            continue;
          case 17:
label_9:
            this.cbTraceActivityEvents = (CheckBox) target;
            num2 = 1714968086;
            continue;
          case 18:
label_73:
            this.cbAutoSpotlightEnabled = (CheckBox) target;
            num2 = 1038984945;
            continue;
          case 19:
            num2 = (int) num4 * -1050841283 ^ 575698606;
            continue;
          case 20:
            num2 = (int) num4 * -1909852658 ^ 1698952177;
            continue;
          case 21:
            EngineView.\u202B⁬‍‎⁭⁪‏‭‍‮‮⁫‍⁯‬‫⁬‬⁫‮‏⁫⁫‏‭‫⁮⁮​⁪⁬‏⁮⁮⁯‎⁬‫‭‏‮((UIElement) this.ZoomZoom, new MouseEventHandler(this.ZoomZoom_MouseEnter));
            num2 = (int) num4 * -1141211498 ^ 1898635060;
            continue;
          case 22:
            num2 = (int) num4 * 949227373 ^ 437174931;
            continue;
          case 23:
label_46:
            this.cbTraceUserInterfaceEvents = (CheckBox) target;
            num2 = 156593292;
            continue;
          case 24:
label_88:
            this.ddbWindows = (RadDropDownButton) target;
            num2 = 708986539;
            continue;
          case 25:
            num2 = (int) num4 * -568476280 ^ -198694144;
            continue;
          case 26:
label_58:
            this.cbAutoattendentMinimumParticipantsEnforced = (CheckBox) target;
            num2 = 116619333;
            continue;
          case 27:
            num2 = (int) num4 * -231667465 ^ -1033866971;
            continue;
          case 28:
label_35:
            this.btnOpenImageHistoryViewCommand = (Button) target;
            num2 = 468595119;
            continue;
          case 29:
            num2 = (int) num4 * 1324782002 ^ -1708579519;
            continue;
          case 30:
label_22:
            this.lAction = (Label) target;
            num2 = 359308571;
            continue;
          case 31:
            num2 = (int) num4 * -1157446904 ^ 559268003;
            continue;
          case 32:
            num2 = (int) num4 * -1002601423 ^ -1062183154;
            continue;
          case 33:
label_84:
            this.cbOnRemovalAction = (ComboBox) target;
            num2 = 94976051;
            continue;
          case 34:
            num2 = (int) num4 * 240639989 ^ -1314431030;
            continue;
          case 35:
label_16:
            this.BottomRow = (RowDefinition) target;
            num2 = 2050837029;
            continue;
          case 36:
            num2 = (int) num4 * 881738905 ^ 1313626539;
            continue;
          case 37:
label_10:
            this.cbOnHoldAction = (ComboBox) target;
            num2 = 408946888;
            continue;
          case 38:
            num2 = (int) num4 * -1559534915 ^ 1482963511;
            continue;
          case 39:
label_21:
            this.cbTraceDataStorage = (CheckBox) target;
            num2 = 397524426;
            continue;
          case 40:
            num2 = (int) num4 * 2105841385 ^ -423983192;
            continue;
          case 41:
            num2 = (int) num4 * 967211868 ^ -929384021;
            continue;
          case 42:
label_61:
            this.cbNewActivity = (ComboBox) target;
            num2 = 1314875242;
            continue;
          case 43:
label_54:
            this.cbAutoCaptureVideoImages = (CheckBox) target;
            num2 = 730375995;
            continue;
          case 44:
label_36:
            this.btnApplyPattern = (Button) target;
            num2 = 1515554871;
            continue;
          case 45:
            num2 = (int) num4 * 15338099 ^ -11160027;
            continue;
          case 46:
label_80:
            this.ddbMain = (RadDropDownButton) target;
            num2 = 1160055619;
            continue;
          case 47:
label_27:
            this.tbAutoattendentMinimumParticipants = (TextBox) target;
            EngineView.\u206C⁯‍‮‌​‫‏‭‬⁫‪‬‭‪‫⁫‭⁪⁫⁮‎‭‏​‬‮⁬​‌​⁮⁯‌‮⁬‫⁯‮‪‮((UIElement) this.tbAutoattendentMinimumParticipants, new TextCompositionEventHandler(this.TextBox_PreviewTextInput));
            num2 = 320772055;
            continue;
          case 48:
            num2 = (int) num4 * -1305590189 ^ 848959315;
            continue;
          case 49:
label_47:
            this.RightColumn = (ColumnDefinition) target;
            num2 = 730375995;
            continue;
          case 50:
label_13:
            this.btnCopyPattern = (Button) target;
            num2 = 730375995;
            continue;
          case 51:
            EngineView.\u202E⁪​‪⁮⁪‏⁮⁪‫⁫⁯‏‎⁫‬⁬‏‏⁭‫⁫‍‭⁫⁪⁪⁪⁭⁮⁯⁪‭⁪‮⁭⁮‌⁪⁬‮((UIElement) this.ZoomZoom, new DependencyPropertyChangedEventHandler(this.ZoomZoom_IsMouseDirectlyOverChanged));
            EngineView.\u200D​‭⁮‍⁮‎‎⁮‍‭‬​⁬⁭‭‭‬⁫⁬⁮⁫‏‭​‍⁭⁬⁪‫‏‪‪​⁭‍‍⁯​‬‮((Window) this.ZoomZoom, new CancelEventHandler(this.ZoomZoom_Closing));
            EngineView.\u206F‬⁬⁯‭‌‫‫⁫‫⁪‏⁫⁯⁯‍⁯‫⁭‫⁯⁮‎‪⁬‫‭⁬‮⁬‫⁯⁫‭‪‪⁫‭‌‍‮((Window) this.ZoomZoom, new EventHandler(this.ZoomZoom_LocationChanged));
            num2 = (int) num4 * -551220322 ^ 1246563763;
            continue;
          case 52:
            num2 = (int) num4 * -324128238 ^ 1003472013;
            continue;
          case 53:
            num2 = (int) num4 * -2058968190 ^ 813708263;
            continue;
          case 54:
label_87:
            this.cbTraceMeetingEvents = (CheckBox) target;
            num2 = 1478142806;
            continue;
          case 55:
            num2 = (int) num4 * 1503466053 ^ -565362737;
            continue;
          case 56:
            num2 = (int) num4 * 951011939 ^ -1994793558;
            continue;
          case 57:
            num2 = (int) num4 * 2098287890 ^ -447756805;
            continue;
          case 58:
            num2 = (int) num4 * -2057205397 ^ 1054163597;
            continue;
          case 59:
label_71:
            this.btnEditPattern = (Button) target;
            num2 = 269097657;
            continue;
          case 60:
            EngineView.\u206B‍‬⁪⁫⁭‏​‪⁪⁬⁬⁯‭‍⁫⁫‮⁮⁫​‪‬‫‭‮⁫‬‎‎‏⁯‪‪​‭‏‮‍‎‮((FrameworkElement) this.ZoomZoom, new RoutedEventHandler(this.ZoomZoom_Loaded));
            num2 = (int) num4 * 427171167 ^ 1937401087;
            continue;
          case 61:
label_69:
            this.cbPatterns = (ComboBox) target;
            num2 = 730375995;
            continue;
          case 62:
            num2 = (int) num4 * 1447750972 ^ -1521415149;
            continue;
          case 63:
            EngineView.\u202D⁫‎‌‍‍⁮‮‎⁪⁫‭‭⁪‫‎⁮‌⁮⁫⁮‏‌​‌‮‌⁭‪‌⁯‌‬‌‏⁪⁮‪⁬‏‮((UIElement) this.ZoomZoom, new DependencyPropertyChangedEventHandler(this.ZoomZoom_IsVisibleChanged));
            num2 = (int) num4 * -586010347 ^ -313968390;
            continue;
          case 64:
label_52:
            this.lPrimaryMonitor = (Label) target;
            num2 = 730375995;
            continue;
          case 65:
label_45:
            this.btnDeletePattern = (Button) target;
            num2 = 887215760;
            continue;
          case 66:
label_55:
            this.tbAutoattendentMaximumDuration = (TextBox) target;
            EngineView.\u206C⁯‍‮‌​‫‏‭‬⁫‪‬‭‪‫⁫‭⁪⁫⁮‎‭‏​‬‮⁬​‌​⁮⁯‌‮⁬‫⁯‮‪‮((UIElement) this.tbAutoattendentMaximumDuration, new TextCompositionEventHandler(this.TextBox_PreviewTextInput));
            num2 = 771802091;
            continue;
          case 67:
label_25:
            this.cbTraceHookEvents = (CheckBox) target;
            num2 = 1171818860;
            continue;
          case 68:
            num2 = (int) num4 * -1564519979 ^ -2098639440;
            continue;
          case 69:
            num2 = (int) num4 * 1281315444 ^ 1455627903;
            continue;
          case 70:
label_11:
            this.lAutoCaptureVideoWindows = (Label) target;
            num2 = 730375995;
            continue;
          case 71:
label_44:
            this.cbTraceUserEvents = (CheckBox) target;
            num2 = 697944741;
            continue;
          case 72:
label_74:
            this.cbTraceChatEvents = (CheckBox) target;
            num2 = 12432862;
            continue;
          case 73:
label_33:
            this.cbAutoattendentMaximumDuration = (CheckBox) target;
            num2 = 1587362417;
            continue;
          case 74:
            EngineView.\u206D‎‬⁭⁯⁬‭​⁪⁭⁫​‭‌‎‬‪‬‏‎‮‍‪‮⁮⁫‌‮​‫‌‍‬⁯‫⁭‎⁯​‌‮((UIElement) this.ZoomZoom, new MouseEventHandler(this.ZoomZoom_MouseLeave));
            num2 = (int) num4 * -1267734553 ^ -1690348743;
            continue;
          case 75:
label_66:
            this.nudAutoSpotlightInterval = (RadNumericUpDown) target;
            num2 = 730375995;
            continue;
          case 76:
            goto label_1;
          case 77:
label_42:
            this.ddbQuick = (RadDropDownButton) target;
            num2 = 730375995;
            continue;
          case 78:
            this._contentLoaded = true;
            num2 = 730375995;
            continue;
          case 79:
            goto label_3;
          case 80:
label_59:
            this.ZoomZoom = (EngineView) target;
            EngineView.\u200F⁭‪‮⁯⁮⁫​⁫‌​‭⁮⁯‌‬‬⁪⁭⁬⁯⁭⁮⁫‬‪​‍‭‏‌‎‬‫⁮‌⁯⁮‎‍‮((FrameworkElement) this.ZoomZoom, new RoutedEventHandler(this.Window_Unloaded));
            num2 = 127668803;
            continue;
          case 81:
            num2 = (int) num4 * 873112092 ^ 615860687;
            continue;
          case 82:
label_85:
            this.MainGrid = (Grid) target;
            num2 = 730375995;
            continue;
          case 83:
            num2 = (int) num4 * -2012898414 ^ 1156308005;
            continue;
          case 84:
            num2 = (int) num4 * 159335957 ^ -331766967;
            continue;
          case 85:
            num2 = (int) num4 * 1978544605 ^ 681221217;
            continue;
          case 86:
            num2 = (int) num4 * 982959112 ^ -556885877;
            continue;
          default:
            goto label_90;
        }
      }
label_90:
      return;
label_3:;
    }

    static object \u202E⁭⁫‬‭⁯‍⁮‎⁪‍‭‌⁭‏‫⁫‍‫⁪⁭⁭⁮‌⁯‬‪⁯‌‭‍​⁭‪⁫⁪‍⁭⁬⁬‮([In] FrameworkElement obj0, [In] object obj1)
    {
      return obj0.FindResource(obj1);
    }

    static MethodBase \u200B⁭⁭⁮‌⁯⁬‌‭​‏⁪‬‎‬⁭‪‍‎‫‪‭‏‭⁭​‬‎‭‫​‍‮‌⁭⁯‏‍‮‍‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202B‭⁭‬⁬⁬⁫⁭‏‎‭‮⁭‎⁮⁯⁮‎‎‮‫⁪‏‏‬⁫⁪​‍⁬⁫‍⁬‎‏‭‏‮‏‏‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206C‏⁯⁪‎‌⁫‪‪‪⁮‮⁬⁪⁪⁯⁭⁯‏​‬⁫‮‌​‎‎⁮‌‫⁫‍⁯⁭⁯‮⁯⁪⁬‌‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static void \u206E⁭⁬⁫‎‏‍‍‮⁪⁯⁮‍⁬⁫⁬⁬‫‍​​⁫‬⁯‏‬‬‮‪⁬⁮​​‮⁮‬⁪‬‪‫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u202D‪​‮⁭‌‌‪‫‬‌‭⁫‏⁭‬⁯⁯⁪‌‬‏⁭⁬⁫‏‪‌⁮⁫⁯‏‬‎⁫⁫‌‬⁭⁫‮([In] DispatcherTimer obj0)
    {
      obj0.Stop();
    }

    static Application \u202C‎‮‬⁪⁪​‮⁮​⁭⁪‮‎‮⁫‭‮⁫‮⁪‮‏⁪⁪⁬‮‫⁯‏⁭‏‍‏⁪⁮‫‎‮‫‮()
    {
      return Application.Current;
    }

    static void \u202B⁬⁫‪‮‏‪⁪⁫‮‮⁫‭‎⁯‍⁮‮​‭‍‏⁪‍‪​‏⁭​⁪‍‪⁯⁮‭⁪‏‬‌‏‮([In] Application obj0)
    {
      obj0.Shutdown();
    }

    static void \u206D⁬‭‮‪⁭⁪​‬⁮⁭‎⁬‫⁮‮‬‍‌​⁪‫‪⁮​⁫⁮⁪⁬‌⁮‌‫⁯⁭⁭⁪‍‪⁪‮([In] Window obj0)
    {
      obj0.DragMove();
    }

    static DoubleAnimation \u206A‏⁯⁬‮‬‪‍‪‍⁭‎‬‪‮⁪‌‎⁬⁯​⁮⁯⁭‬⁮⁪⁮⁪⁪‍‪⁬‭‭⁪​‪‫‎‮()
    {
      return new DoubleAnimation();
    }

    static bool \u206E​‍⁯‫‍⁭‮‎‪‪‬⁭‍‫‫‍‮⁯‌‮⁪⁯‫⁬‬⁭‌⁭‌⁬‪​‫‮‪⁯⁮‮([In] UIElement obj0)
    {
      return obj0.IsVisible;
    }

    static void \u202E⁭‪​‍⁮‪‪‎‪‫⁫⁮‫‌⁫‭‫⁪‪‏⁪‭‬⁬⁮‬‏⁯⁪⁯‬‫⁭‍‍‭⁪‌‭‮([In] DoubleAnimation obj0, [In] double? obj1)
    {
      obj0.From = obj1;
    }

    static void \u206D‍⁭⁭‫⁮​⁭‍⁭⁪‍‬⁯⁫‍⁪‬⁫‮⁬‌⁬‎‬‫⁮‪‪‍‪‎⁬‬⁪‌⁭‎⁮‪‮([In] DoubleAnimation obj0, [In] double? obj1)
    {
      obj0.To = obj1;
    }

    static void \u206F⁪⁪​‎⁭⁭⁬‬‪⁫‫⁭‮⁭‎⁪‭⁮‎‏⁫⁪⁫‪⁪​‭⁮‏‍‌​‏‫‍‭‭‌⁬‮([In] Timeline obj0, [In] Duration obj1)
    {
      obj0.Duration = obj1;
    }

    void \u202A‭‌⁬‫‌‭‌‭⁪‫⁫‎‎‬‎‏‏⁫⁮⁯‮⁮‫‮⁮‮‮‎⁯‎⁫‭⁬‏‌⁬⁮⁯‫‮([In] DependencyProperty obj0, [In] AnimationTimeline obj1)
    {
      this.BeginAnimation(obj0, obj1);
    }

    static ResourceDictionary \u200D⁫​⁫⁪‫⁮⁬‬⁬⁬⁪‌‍‪‏‫‭⁯⁭​‫⁭⁪⁯‪‭⁯⁭‬‏‍‏‮‫​⁭⁬⁯‭‮([In] FrameworkElement obj0)
    {
      return obj0.Resources;
    }

    static object \u206A‬​​‎⁯‫⁮⁮​⁭⁭⁪‌‌⁬‍⁯‎​‪‮⁬‍⁬⁪‫​‭⁭⁯​​‮‫⁪⁮​⁮⁭‮([In] ResourceDictionary obj0, [In] object obj1)
    {
      return obj0[obj1];
    }

    static WindowInteropHelper \u202C‏​‏‬‍⁫‎⁪⁯‫⁭‎⁫‍⁫⁯‍‫‫‌‍‮‫‪​‫⁭‏‎⁫⁭‮‭⁫‍‍​​‪‮([In] Window obj0)
    {
      return new WindowInteropHelper(obj0);
    }

    static IntPtr \u200F⁫⁫‬‎‏‎‌‬⁯‎⁫⁯‏‫‍⁮‏‏‭‎​‎⁭⁮‮‫⁪‏‭‬⁮‌‏⁭⁪‮‪‎‌‮([In] WindowInteropHelper obj0)
    {
      return obj0.Handle;
    }

    static DispatcherTimer \u200D‌⁮‮⁫⁮‎‫‭‍⁬‌‬‎‭‏​⁮‭⁪‬‎⁬‌‪⁭⁯⁫‎‬‫‫⁪‬‬⁮‭‏⁪‬‮([In] DispatcherPriority obj0)
    {
      return new DispatcherTimer(obj0);
    }

    static void \u202C⁭‫‍‌‪‭‏​⁮‫⁯⁮‫⁬⁯‮⁭‪‭⁫‏⁭‬⁯⁭⁭⁫⁫‎⁭⁮‏‌‪⁫⁫‌‭‎‮([In] DispatcherTimer obj0, [In] EventHandler obj1)
    {
      obj0.Tick += obj1;
    }

    static Regex \u200F‍‌⁬‪⁫⁬⁮‫‪‭‬‌⁭‍⁪‎⁮‮⁪‮⁬⁭⁫‎‮‪‭⁯‍​⁭​‎​⁮‌‏‏‍‮([In] string obj0)
    {
      return new Regex(obj0);
    }

    static string \u206F‭‌⁪⁯⁪‎⁮⁯‬⁪‭⁭‍⁭‫‭‬‫‪‪‏‎‍‏‬‏‪⁮⁪⁬⁫‬‬⁮‎⁭​‌⁯‮([In] TextCompositionEventArgs obj0)
    {
      return obj0.Text;
    }

    static bool \u206F⁬‫⁮‌‍‬⁬⁮​‮‌​‫​‫‏‌‎⁬‫​‪‭⁯⁮⁫​⁫⁬⁪‭⁮⁪⁬⁮‍⁫⁫‮‮([In] Regex obj0, [In] string obj1)
    {
      return obj0.IsMatch(obj1);
    }

    static void \u202E‌⁪⁫⁯‬‍‫⁫‏‮‫‍‎⁭‏‪​‍‬‎‍⁪​⁪⁪‬⁮⁪⁬‮‭‎​‎‭⁫⁫‭⁪‮([In] RoutedEventArgs obj0, [In] bool obj1)
    {
      obj0.Handled = obj1;
    }

    static Uri \u206C‪‌‮‮⁫⁬‏⁮⁫​‎‌‫‮⁭‭⁬‮⁫⁪⁫⁬‭⁭‫‌⁪⁭‏‌‎‬⁬⁪⁯⁮⁮⁬‮‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u206C‍⁮‮‎‎⁭‎‭‫⁬‍​‪‍‏⁮‌‪‬‬‎⁮‍‏⁮‎‬⁯⁯‭‌⁬⁭⁮‮‭⁪⁫‫‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u200F⁭‪‮⁯⁮⁫​⁫‌​‭⁮⁯‌‬‬⁪⁭⁬⁯⁭⁮⁫‬‪​‍‭‏‌‎‬‫⁮‌⁯⁮‎‍‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Unloaded += obj1;
    }

    static void \u206B‍‬⁪⁫⁭‏​‪⁪⁬⁬⁯‭‍⁫⁫‮⁮⁫​‪‬‫‭‮⁫‬‎‎‏⁯‪‪​‭‏‮‍‎‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u202D⁫‎‌‍‍⁮‮‎⁪⁫‭‭⁪‫‎⁮‌⁮⁫⁮‏‌​‌‮‌⁭‪‌⁯‌‬‌‏⁪⁮‪⁬‏‮([In] UIElement obj0, [In] DependencyPropertyChangedEventHandler obj1)
    {
      obj0.IsVisibleChanged += obj1;
    }

    static void \u202D‌​​⁭‍‫‫‬‌‍‮‌‫‏⁮⁫‮‭⁪‬‏⁭⁪‫‭‌⁪‬⁫⁫‌​‮⁫⁭‮⁯‌⁫‮([In] UIElement obj0, [In] MouseButtonEventHandler obj1)
    {
      obj0.MouseLeftButtonDown += obj1;
    }

    static void \u202B⁬‍‎⁭⁪‏‭‍‮‮⁫‍⁯‬‫⁬‬⁫‮‏⁫⁫‏‭‫⁮⁮​⁪⁬‏⁮⁮⁯‎⁬‫‭‏‮([In] UIElement obj0, [In] MouseEventHandler obj1)
    {
      obj0.MouseEnter += obj1;
    }

    static void \u206D‎‬⁭⁯⁬‭​⁪⁭⁫​‭‌‎‬‪‬‏‎‮‍‪‮⁮⁫‌‮​‫‌‍‬⁯‫⁭‎⁯​‌‮([In] UIElement obj0, [In] MouseEventHandler obj1)
    {
      obj0.MouseLeave += obj1;
    }

    static void \u202E⁪​‪⁮⁪‏⁮⁪‫⁫⁯‏‎⁫‬⁬‏‏⁭‫⁫‍‭⁫⁪⁪⁪⁭⁮⁯⁪‭⁪‮⁭⁮‌⁪⁬‮([In] UIElement obj0, [In] DependencyPropertyChangedEventHandler obj1)
    {
      obj0.IsMouseDirectlyOverChanged += obj1;
    }

    static void \u200D​‭⁮‍⁮‎‎⁮‍‭‬​⁬⁭‭‭‬⁫⁬⁮⁫‏‭​‍⁭⁬⁪‫‏‪‪​⁭‍‍⁯​‬‮([In] Window obj0, [In] CancelEventHandler obj1)
    {
      obj0.Closing += obj1;
    }

    static void \u206F‬⁬⁯‭‌‫‫⁫‫⁪‏⁫⁯⁯‍⁯‫⁭‫⁯⁮‎‪⁬‫‭⁬‮⁬‫⁯⁫‭‪‪⁫‭‌‍‮([In] Window obj0, [In] EventHandler obj1)
    {
      obj0.LocationChanged += obj1;
    }

    static void \u206C⁯‍‮‌​‫‏‭‬⁫‪‬‭‪‫⁫‭⁪⁫⁮‎‭‏​‬‮⁬​‌​⁮⁯‌‮⁬‫⁯‮‪‮([In] UIElement obj0, [In] TextCompositionEventHandler obj1)
    {
      obj0.PreviewTextInput += obj1;
    }

    static object \u200D‎‍​‪​‭⁫‏⁪‪⁬⁫‬‎‌⁮⁪⁭‏‌‭‍⁫⁫‌‬⁬⁫⁮‬⁪​‬⁮⁫⁯‭⁫⁮‮()
    {
      return new object();
    }
  }
}
