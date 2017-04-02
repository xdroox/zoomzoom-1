// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.ActivityManagerView
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Threading;
using ZoomZoom.ViewModels;

namespace ZoomZoom.Views
{
  public class ActivityManagerView : Window, IComponentConnector
  {
    private ILog log = ActivityManagerView.\u202C‫‫‭‬‮‭⁮⁭‏​⁯‍‫‭⁫‏‪‌⁯⁪‮‏​⁫‎‌‍⁪‎‬⁯‮‍‮‏‏⁬⁬‮‮(ActivityManagerView.\u202C⁮‫⁬⁫​‬‪⁭‍⁮‭⁯​‬‬⁪‍⁯⁮⁫⁯‭‍‮⁯⁬‍⁬⁬‮‏⁭‪⁪⁪​⁮‪‪‮((MemberInfo) ActivityManagerView.\u202E⁮‮⁬‎‌⁬⁬‏‌⁯‌‫‮‏⁪‎‍⁫‭⁮‍‏‮‫‮‎‫⁪‮⁬⁬‬⁬⁫⁪⁯‮⁫‫‮()));
    private IntPtr handle = IntPtr.Zero;
    private bool allowClosure = false;
    protected readonly IEventAggregator _eventAggregator;
    private SubscriptionToken token;
    private ActivityManagerViewModel activityManagerViewModel;
    private bool _contentLoaded;

    public ActivityManagerViewModel ActivityManagerViewModel
    {
      get
      {
label_1:
        int num1 = 1459568140;
        ActivityManagerViewModel managerViewModel;
        while (true)
        {
          int num2 = 1377253400;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              managerViewModel = this.activityManagerViewModel;
              num1 = (int) num3 * -1650759630 ^ 401509944;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return managerViewModel;
      }
      set
      {
label_1:
        int num1 = 1409489605;
        while (true)
        {
          int num2 = 812578904;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.activityManagerViewModel = value;
              num1 = (int) num3 * 793993841 ^ -1438090142;
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

    public ActivityManagerView()
    {
label_1:
      int num1 = -463572616;
      while (true)
      {
        int num2 = -836715939;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 1759770552 ^ 78074550;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1060619832 ^ 1991883693;
            continue;
          case 4:
            this.InitializeComponent();
            num1 = (int) num3 * -1992696945 ^ -2030230938;
            continue;
          case 5:
            this._eventAggregator = ApplicationService.Instance.EventAggregator;
            num1 = (int) num3 * 1888697424 ^ 1544667379;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void ViewExit(SubscriptionToken obj)
    {
      try
      {
label_2:
        int num1 = 290441425;
        while (true)
        {
          int num2 = 1639406464;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1020473667 ^ -1879382961;
              continue;
            case 1:
              // ISSUE: method pointer
              ActivityManagerView.\u200C‫⁭⁬⁫⁯‪​‬⁯‮‍‍‮‮⁪‍‎‪⁪⁮‪‪⁬‪‪‌‭‮‪​‭​‭‭‍⁭‎‫⁯‮(ActivityManagerView.\u206C⁭‪‫‫‌⁬​⁯⁮⁪⁭‎‬‍‭‫⁫‮⁯⁭‫‍⁬⁮‪⁮‪⁬‬‪‬‬⁭⁯‫‌‭‍⁪‮((DispatcherObject) this), new Action((object) this, __methodptr(\u003CViewExit\u003Eb__8_0)));
              num1 = (int) num3 * 2123492510 ^ 1616748510;
              continue;
            case 2:
              goto label_2;
            case 3:
              goto label_13;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_13:;
      }
      catch (Exception ex)
      {
label_9:
        int num1 = 446487308;
        while (true)
        {
          int num2 = 1639406464;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_7;
            case 2:
              ActivityManagerView.\u200C‪⁪‮⁮⁬‬‏⁫‪⁮‭‪⁬​‭‭‫‍⁪‎⁫‍⁭‭⁬‌⁭⁬⁯⁮‫‏‏‪‌‎‌⁬‮‮(this.log, (object) ex);
              num1 = (int) num3 * -550535522 ^ -1071369504;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_7:;
      }
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = 1680181257;
      while (true)
      {
        int num2 = 619834280;
        uint num3;
        ViewModelLocator resource;
        IntPtr handle;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 1:
            num1 = (int) num3 * 1218502537 ^ -2137448489;
            continue;
          case 2:
            this.ActivityManagerViewModel = resource.ActivityManagerViewModel;
            num1 = (int) num3 * 34181886 ^ -31606464;
            continue;
          case 3:
            if (Engine.Instance != null)
            {
              num1 = (int) num3 * 2102737957 ^ -534574551;
              continue;
            }
            break;
          case 4:
            num1 = (int) num3 * 970065938 ^ -488794897;
            continue;
          case 5:
            this.ActivityManagerViewModel.Initialize(this.handle);
            Engine.Instance.WindowManager.RegisterWindow(this.handle, ZoomWindowType.ActivityManagerView);
            num1 = (int) num3 * 2034907060 ^ -705725140;
            continue;
          case 6:
            this.allowClosure = true;
            this.Close();
            num1 = (int) num3 * -1959902820 ^ -1525370599;
            continue;
          case 7:
            resource = this.FindResource((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1458429715U)) as ViewModelLocator;
            num1 = 30780770;
            continue;
          case 8:
            int num5 = !flag2 ? 927616230 : (num5 = 1392889582);
            int num6 = (int) num3 * -1188019441;
            num1 = num5 ^ num6;
            continue;
          case 9:
            int num7 = !flag1 ? -1311739019 : (num7 = -338824106);
            int num8 = (int) num3 * 1004114609;
            num1 = num7 ^ num8;
            continue;
          case 10:
            flag2 = this.ActivityManagerViewModel != null;
            num1 = (int) num3 * 471431380 ^ 1226715095;
            continue;
          case 11:
            this.DataContext = (object) this.ActivityManagerViewModel;
            num1 = 1304162328;
            continue;
          case 12:
            num1 = (int) num3 * -2044529437 ^ 578658132;
            continue;
          case 13:
            goto label_1;
          case 14:
            this.handle = ActivityManagerView.\u202B‪⁫‫‪⁪‍⁬⁭⁯⁭‮‮⁪‮​‍‎⁮‪‫⁭‪‮‫‬‬‭‬‬⁬‮⁯‌‮‮‬‭‍⁯‮(ActivityManagerView.\u202B‌⁫⁭​⁯⁮⁭‌‭⁫‫​⁯⁮‎‌‪‎⁮‮⁬‍‫‮​‭‮‍⁯⁮​⁪⁬‪‫‬‪‬⁫‮((Window) this));
            if (!this.handle.Equals((object) IntPtr.Zero))
            {
              num1 = (int) num3 * -1959792005 ^ -1339940758;
              continue;
            }
            break;
          case 15:
            num1 = (int) num3 * -504770240 ^ 1137637287;
            continue;
          case 16:
            handle = Engine.Instance.GetWindow(ZoomWindowType.ActivityManagerView).Handle;
            num1 = (int) num3 * 1929518856 ^ 2052192304;
            continue;
          case 17:
            flag1 = resource != null;
            num1 = (int) num3 * 1576701699 ^ 215185410;
            continue;
          case 18:
            num4 = handle.Equals((object) this.handle) ? 1 : 0;
            goto label_6;
          default:
            goto label_24;
        }
        num4 = 0;
label_6:
        int num9;
        num1 = num9 = num4 != 0 ? 1879386269 : (num9 = 1613355093);
      }
label_24:
      ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Subscribe(new Action<ViewEventPayload>(this.HandleWindowEvent), (ThreadOption) 1, false);
    }

    private void HandleWindowEvent(ViewEventPayload obj)
    {
label_1:
      int num1 = -905386334;
      while (true)
      {
        int num2 = -1835146565;
        uint num3;
        bool flag;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            num4 = obj.ViewEventType == ViewEventType.Open ? 1 : 0;
            break;
          case 1:
            ActivityManagerView.\u202A‍‮‎‪⁪‮‏‎⁭‬⁪‌‍⁫⁭⁬⁯⁮‎‍⁭⁫‪‏‏‭‭⁪‬‮‍⁮‬‫⁯‪⁪‍‭‮((Window) this);
            num1 = (int) num3 * -1918151024 ^ -603254605;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = -2025195501;
            continue;
          case 4:
            num1 = (int) num3 * -1587852578 ^ 1239643971;
            continue;
          case 5:
            this.allowClosure = true;
            ActivityManagerView.\u206C⁮⁫‭⁮‪‭⁪⁫‌‭‬‫⁬‎⁫‫‬⁬⁮‭⁪​‌⁭‪‭⁪‏‭‌​‏⁬​‏⁯‌‪‍‮((Window) this);
            num1 = (int) num3 * 1464849945 ^ 825008604;
            continue;
          case 6:
            if (obj.Handle == this.handle)
            {
              num1 = -744282630;
              continue;
            }
            num4 = 0;
            break;
          case 7:
            num5 = obj.ViewEventType == ViewEventType.Close ? 1 : 0;
            goto label_19;
          case 8:
            int num6 = !flag ? 465858622 : (num6 = 1889582874);
            int num7 = (int) num3 * 1488630202;
            num1 = num6 ^ num7;
            continue;
          case 9:
            num1 = (int) num3 * -1792200061 ^ -502137382;
            continue;
          case 10:
            num1 = (int) num3 * 1181232988 ^ -1802753137;
            continue;
          case 11:
            if (!(obj.Handle == this.handle))
            {
              num5 = 0;
              goto label_19;
            }
            else
            {
              num1 = (int) num3 * 517971985 ^ 675154428;
              continue;
            }
          case 12:
            num1 = (int) num3 * 212571850 ^ -1216692966;
            continue;
          case 13:
            num1 = (int) num3 * 1898940368 ^ 203572906;
            continue;
          case 14:
            goto label_1;
          case 15:
            num1 = (int) num3 * 670759181 ^ 1862977348;
            continue;
          case 16:
            int num8 = (uint) ActivityManagerView.\u206E‫⁬‭‎⁬⁯‭‪‍‍‬⁭⁮‍‍⁫‍​‫⁬⁯⁫⁫‬‎​‍‍⁯⁮⁯​​⁬‎‍⁬​⁫‮((UIElement) this) > 0U ? 1587475207 : (num8 = 367505129);
            int num9 = (int) num3 * -1125009975;
            num1 = num8 ^ num9;
            continue;
          default:
            goto label_25;
        }
        int num10;
        num1 = num10 = num4 != 0 ? -803336547 : (num10 = -2025195501);
        continue;
label_19:
        flag = num5 != 0;
        num1 = -1078614653;
      }
label_25:
      return;
label_3:;
    }

    private void Window_Closing(object sender, CancelEventArgs e)
    {
label_1:
      int num1 = 1375895818;
      while (true)
      {
        int num2 = 924430403;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = this.allowClosure ? -1585312564 : (num4 = -572416334);
            int num5 = (int) num3 * -1932779439;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * -556309971 ^ 1725248248;
            continue;
          case 3:
            ActivityManagerView.\u206C⁯‍⁮‍⁯⁯‏⁬⁪‍⁮⁬⁮⁮⁬‮⁫⁫‎‮‮‭‎‫‍‪‏⁫‭⁭‪‫‬‏‮⁪⁪‍‮‮((Window) this);
            num1 = (int) num3 * 1654458468 ^ 687741202;
            continue;
          case 4:
            num1 = 1009533928;
            continue;
          case 5:
            num1 = (int) num3 * 1505328760 ^ 1323930048;
            continue;
          case 6:
            ActivityManagerView.\u206C‏‏‏⁫‪​‎‭‬⁪⁬⁭‌‍‏⁬‪‬⁪⁮​​⁮​‮​‮​⁫‬‏⁫‫‫‮⁬‏‫⁯‮(e, false);
            num1 = (int) num3 * 1550433342 ^ -1485287113;
            continue;
          case 7:
            ActivityManagerView.\u206C‏‏‏⁫‪​‎‭‬⁪⁬⁭‌‍‏⁬‪‬⁪⁮​​⁮​‮​‮​⁫‬‏⁫‫‫‮⁬‏‫⁯‮(e, true);
            num1 = (int) num3 * 1342206181 ^ 759257003;
            continue;
          case 8:
            num1 = (int) num3 * 374006457 ^ -1038574003;
            continue;
          case 9:
            num1 = (int) num3 * -606681812 ^ 707981617;
            continue;
          case 10:
            goto label_3;
          case 11:
            num1 = (int) num3 * -1947592531 ^ 1074112562;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
label_1:
      int num1 = -1974257982;
      while (true)
      {
        int num2 = -1991201687;
        uint num3;
        bool contentLoaded;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            int num4 = !contentLoaded ? -408929235 : (num4 = -876935369);
            int num5 = (int) num3 * 243029463;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * 784811874 ^ 542810356;
            continue;
          case 2:
            goto label_1;
          case 3:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * 1048821318 ^ -1396223589;
            continue;
          case 4:
            this._contentLoaded = true;
            uri = ActivityManagerView.\u200B‮‎⁮⁬‬​⁮‪‌‌​‭⁬‏‏‌‬⁯⁬⁯⁪‬‎⁬⁬‍‬⁭‫⁪⁮‪⁪‬‎‭‍‬‬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(632110974U), UriKind.Relative);
            num1 = -836688180;
            continue;
          case 5:
            ActivityManagerView.\u206D⁪‬⁯⁬‍‬‭​‎‍‎‬‫‭‭‬‮​‍‏‭⁮​‏⁮⁬‭⁭‏⁯​⁭⁬⁮‎⁫‪‮⁫‮((object) this, uri);
            num1 = (int) num3 * 2134117685 ^ 589791385;
            continue;
          case 6:
            num1 = (int) num3 * 1447505240 ^ 569798198;
            continue;
          case 7:
            goto label_3;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = -500919271;
      while (true)
      {
        int num2 = -909537637;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * -1736821324 ^ -1847021772;
            continue;
          case 1:
            int num4 = connectionId == 1 ? -1955469120 : (num4 = -801881233);
            int num5 = (int) num3 * 722608694;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_3;
          case 3:
            this._contentLoaded = true;
            num1 = -39872147;
            continue;
          case 4:
            num1 = (int) num3 * 125116146 ^ 748071111;
            continue;
          case 5:
            goto label_1;
          case 6:
            ActivityManagerView.\u202E⁯‪‏⁪‭‪⁯‮⁫‫⁫​‍‬‫‭⁬⁫‏⁯‏‭‭‫⁮‫‍‌‬‬⁪‭‎⁫‮⁭⁪‮‎‮((FrameworkElement) target, new RoutedEventHandler(this.Window_Loaded));
            num1 = -997581590;
            continue;
          case 7:
            num1 = (int) num3 * -1939295799 ^ -13449629;
            continue;
          case 8:
            ActivityManagerView.\u206E⁭⁬‮‭⁫‎⁭‬‪‬‌⁮‬⁪‫⁫‫⁫​‎⁫⁫‭‍‭⁫⁬⁭‍‪⁫‮⁭‭‭⁮‬⁫‭‮((Window) target, new CancelEventHandler(this.Window_Closing));
            num1 = (int) num3 * -359722089 ^ 454722187;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    static MethodBase \u202E⁮‮⁬‎‌⁬⁬‏‌⁯‌‫‮‏⁪‎‍⁫‭⁮‍‏‮‫‮‎‫⁪‮⁬⁬‬⁬⁫⁪⁯‮⁫‫‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202C⁮‫⁬⁫​‬‪⁭‍⁮‭⁯​‬‬⁪‍⁯⁮⁫⁯‭‍‮⁯⁬‍⁬⁬‮‏⁭‪⁪⁪​⁮‪‪‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202C‫‫‭‬‮‭⁮⁭‏​⁯‍‫‭⁫‏‪‌⁯⁪‮‏​⁫‎‌‍⁪‎‬⁯‮‍‮‏‏⁬⁬‮‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static Dispatcher \u206C⁭‪‫‫‌⁬​⁯⁮⁪⁭‎‬‍‭‫⁫‮⁯⁭‫‍⁬⁮‪⁮‪⁬‬‪‬‬⁭⁯‫‌‭‍⁪‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u200C‫⁭⁬⁫⁯‪​‬⁯‮‍‍‮‮⁪‍‎‪⁪⁮‪‪⁬‪‪‌‭‮‪​‭​‭‭‍⁭‎‫⁯‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static void \u200C‪⁪‮⁮⁬‬‏⁫‪⁮‭‪⁬​‭‭‫‍⁪‎⁫‍⁭‭⁬‌⁭⁬⁯⁮‫‏‏‪‌‎‌⁬‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static WindowInteropHelper \u202B‌⁫⁭​⁯⁮⁭‌‭⁫‫​⁯⁮‎‌‪‎⁮‮⁬‍‫‮​‭‮‍⁯⁮​⁪⁬‪‫‬‪‬⁫‮([In] Window obj0)
    {
      return new WindowInteropHelper(obj0);
    }

    static IntPtr \u202B‪⁫‫‪⁪‍⁬⁭⁯⁭‮‮⁪‮​‍‎⁮‪‫⁭‪‮‫‬‬‭‬‬⁬‮⁯‌‮‮‬‭‍⁯‮([In] WindowInteropHelper obj0)
    {
      return obj0.Handle;
    }

    static void \u206C⁮⁫‭⁮‪‭⁪⁫‌‭‬‫⁬‎⁫‫‬⁬⁮‭⁪​‌⁭‪‭⁪‏‭‌​‏⁬​‏⁯‌‪‍‮([In] Window obj0)
    {
      obj0.Close();
    }

    static Visibility \u206E‫⁬‭‎⁬⁯‭‪‍‍‬⁭⁮‍‍⁫‍​‫⁬⁯⁫⁫‬‎​‍‍⁯⁮⁯​​⁬‎‍⁬​⁫‮([In] UIElement obj0)
    {
      return obj0.Visibility;
    }

    static void \u202A‍‮‎‪⁪‮‏‎⁭‬⁪‌‍⁫⁭⁬⁯⁮‎‍⁭⁫‪‏‏‭‭⁪‬‮‍⁮‬‫⁯‪⁪‍‭‮([In] Window obj0)
    {
      obj0.Show();
    }

    static void \u206C‏‏‏⁫‪​‎‭‬⁪⁬⁭‌‍‏⁬‪‬⁪⁮​​⁮​‮​‮​⁫‬‏⁫‫‫‮⁬‏‫⁯‮([In] CancelEventArgs obj0, [In] bool obj1)
    {
      obj0.Cancel = obj1;
    }

    static void \u206C⁯‍⁮‍⁯⁯‏⁬⁪‍⁮⁬⁮⁮⁬‮⁫⁫‎‮‮‭‎‫‍‪‏⁫‭⁭‪‫‬‏‮⁪⁪‍‮‮([In] Window obj0)
    {
      obj0.Hide();
    }

    static Uri \u200B‮‎⁮⁬‬​⁮‪‌‌​‭⁬‏‏‌‬⁯⁬⁯⁪‬‎⁬⁬‍‬⁭‫⁪⁮‪⁪‬‎‭‍‬‬‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u206D⁪‬⁯⁬‍‬‭​‎‍‎‬‫‭‭‬‮​‍‏‭⁮​‏⁮⁬‭⁭‏⁯​⁭⁬⁮‎⁫‪‮⁫‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u202E⁯‪‏⁪‭‪⁯‮⁫‫⁫​‍‬‫‭⁬⁫‏⁯‏‭‭‫⁮‫‍‌‬‬⁪‭‎⁫‮⁭⁪‮‎‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u206E⁭⁬‮‭⁫‎⁭‬‪‬‌⁮‬⁪‫⁫‫⁫​‎⁫⁫‭‍‭⁫⁬⁭‍‪⁫‮⁭‭‭⁮‬⁫‭‮([In] Window obj0, [In] CancelEventHandler obj1)
    {
      obj0.Closing += obj1;
    }
  }
}
