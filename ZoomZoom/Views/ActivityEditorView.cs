// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.ActivityEditorView
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using ZoomZoom.Models.Windows;
using ZoomZoom.ViewModels;

namespace ZoomZoom.Views
{
  public class ActivityEditorView : Window, IComponentConnector, IStyleConnector
  {
    public static readonly DependencyProperty ActivityProperty = ActivityEditorView.\u202B‌⁯⁫‪⁫⁯⁫‭‮‎⁭‌⁫⁪‌‪‏‫‌‍‫‌‫‌⁭‭‌‍‭‬‪‎⁭⁫‫‏‌‮⁫‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1273552450U), ActivityEditorView.\u200F‍⁬⁪‎‭⁮⁮‫​⁮‌​‏‮‌⁮‍⁪‌‪⁭‪⁯⁫⁬⁪‫‍‏⁪​‫‬⁬‌⁮‌‫‍‮(__typeref (ActivityBase)), ActivityEditorView.\u200F‍⁬⁪‎‭⁮⁮‫​⁮‌​‏‮‌⁮‍⁪‌‪⁭‪⁯⁫⁬⁪‫‍‏⁪​‫‬⁬‌⁮‌‫‍‮(__typeref (ActivityEditorView)), ActivityEditorView.\u202B‬⁯‎⁪‏‎​‬‍‮‪‭​‭‭‏‎⁯⁯‬⁪⁮‭⁭‏‍⁬​‫‭‭⁮‪‫‬‬‮‮‍‮((object) null, new PropertyChangedCallback(ActivityEditorView.OnActivityChanged)));
    private ILog log = ActivityEditorView.\u206D⁮⁮⁭‎‍‭‎‬‭‬⁬‭‪​‪‬‪​⁫‬⁭‪‬‫⁬‍‍​‫​‭‮⁬‭‍‏‪⁬⁫‮(ActivityEditorView.\u206F‬⁭⁯‮‍‭‌‬⁪‏⁮​​⁬‪⁬‌‏‪⁮‭‏⁪‫⁯‭⁫‮‌⁬‍‮‍‫‌⁯⁮⁪‫‮((MemberInfo) ActivityEditorView.\u200F⁮⁬​⁭‪‫‮‬⁭‎⁫‭‪⁭⁬⁯⁭‭‏⁪⁯⁫‍‍⁯‌‫‎⁭⁯‏‭‬‌⁪‌‌‮‭‮()));
    private ActivityEditorViewModel viewModel = (ActivityEditorViewModel) null;
    private IntPtr _handle = IntPtr.Zero;
    private readonly IEventAggregator _eventAggregator;
    private bool _contentLoaded;

    public ActivityBase Activity
    {
      get
      {
label_1:
        int num1 = -463745345;
        ActivityBase activityBase;
        while (true)
        {
          int num2 = -1524041007;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 756265560 ^ -1098737399;
              continue;
            case 2:
              activityBase = (ActivityBase) ActivityEditorView.\u200B⁯⁬⁪​‍‬‌‌‫‌‍‏‎‏‪⁯‏⁫⁫‭⁫‎‍‏⁬‎⁬⁮‭‎‭⁭‎‪‭⁯⁮‍⁯‮((DependencyObject) this, ActivityEditorView.ActivityProperty);
              num1 = (int) num3 * 1585141207 ^ 833090618;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return activityBase;
      }
      set
      {
label_1:
        int num1 = 496177260;
        while (true)
        {
          int num2 = 1760851650;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              ActivityEditorView.\u202D‌‪‪‍⁫⁫⁫‮‫‏‍⁪⁬⁫⁫‍⁯‭‪⁪⁮⁮‪‍​‭⁭‬​⁬⁯⁮‎‎⁪⁪‬‌‎‮((DependencyObject) this, ActivityEditorView.ActivityProperty, (object) value);
              num1 = (int) num3 * 864468763 ^ -816405552;
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

    public ActivityEditorViewModel ViewModel
    {
      get
      {
label_1:
        int num1 = -280587678;
        ActivityEditorViewModel viewModel;
        while (true)
        {
          int num2 = -58081901;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              viewModel = this.viewModel;
              num1 = (int) num3 * -725735388 ^ -1172459415;
              continue;
            case 2:
              num1 = (int) num3 * -272362299 ^ -1865502218;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return viewModel;
      }
      set
      {
        this.viewModel = value;
      }
    }

    public event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;
label_1:
        int num1 = 109996065;
        while (true)
        {
          int num2 = 1720900539;
          uint num3;
          PropertyChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = changedEventHandler == comparand ? -1558320027 : (num4 = -1556504508);
              int num5 = (int) num3 * -374959367;
              num1 = num4 ^ num5;
              continue;
            case 2:
              comparand = changedEventHandler;
              changedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, (PropertyChangedEventHandler) ActivityEditorView.\u202D​‮‭‎⁭‍⁭⁭‫‌‫‎‬⁯‏⁭⁮‫‍‮⁭‫⁭‫⁯⁪‮‭⁯⁫‭‪‮‬‌⁮‏⁭‍‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = 1514230902;
              continue;
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
      remove
      {
        PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;
label_1:
        int num1 = -809675321;
        while (true)
        {
          int num2 = -13833476;
          uint num3;
          PropertyChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = changedEventHandler != comparand ? 2104189417 : (num4 = 1576915187);
              int num5 = (int) num3 * -2132002118;
              num1 = num4 ^ num5;
              continue;
            case 2:
              changedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, (PropertyChangedEventHandler) ActivityEditorView.\u206F‎‪‪⁮‮⁪⁫‮⁮‫⁫‬​‏‏⁭‭‍‭‬⁪‍⁫​‬⁪‏⁯‮⁭‭⁭⁭​‬‌⁮‏⁪‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -1734219975 ^ 1303717467;
              continue;
            case 3:
              comparand = changedEventHandler;
              num1 = -637551304;
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

    public ActivityEditorView(IEventAggregator eventAggregator)
    {
label_1:
      int num1 = -362582913;
      while (true)
      {
        int num2 = -770659680;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -609842586 ^ -827840167;
            continue;
          case 3:
            num1 = (int) num3 * 1757905525 ^ 1682964537;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      this._eventAggregator = eventAggregator;
      this.InitializeComponent();
    }

    private static void OnActivityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
    }

    private void CloseWindow(IntPtr obj)
    {
      ActivityEditorView.\u206B‌‎⁮‫‫‬⁯‮‪‪⁮⁯‏‌‮‭‪‬‫‍‏‌⁫‪⁯‏‫⁬‌⁮‪‭‪‌‮‭‮⁮⁫‮((Window) this);
    }

    public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    {
label_1:
      int num1 = -170573784;
      while (true)
      {
        int num2 = -1684759526;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.RaisePropertyChanged(ActivityEditorView.\u202B⁬⁭‮‎‌⁫‪‮⁬‭‏‪‮⁮‎‪⁬​‍‮⁯⁭‌‬‪‍⁫⁫⁯‭‬‍⁬‭⁭‪⁯​‌‮(propertyName));
            num1 = (int) num3 * 1572755802 ^ -620505217;
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

    protected virtual void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
label_1:
      int num1 = 1882444619;
      while (true)
      {
        int num2 = 1586878001;
        uint num3;
        PropertyChangedEventHandler propertyChanged;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = propertyChanged != null ? 1886955529 : (num4 = 2007599011);
            int num5 = (int) num3 * -1793058116;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_3;
          case 3:
            propertyChanged((object) this, args);
            num1 = (int) num3 * 1550558925 ^ 1778539947;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            propertyChanged = this.PropertyChanged;
            num1 = (int) num3 * -201445175 ^ -1245158006;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      this._handle = ActivityEditorView.\u200C​‍​‍‭​⁪⁮‍​‌‍⁫⁮‏⁯‎‭‎⁯‎‭⁭‍‮⁭‪⁬​‌​‬⁭‌​‬⁮​‬‮(ActivityEditorView.\u206E‌‮⁫‌⁪‬‌⁮‭⁬⁮‬⁪⁬⁬⁯⁬‭‍‪‮‬‬⁬‪⁯‭⁯‌‫⁬‪⁭‫⁫⁬⁪‫⁮‮((Window) this));
label_1:
      int num1 = -493181255;
      while (true)
      {
        int num2 = -808376207;
        uint num3;
        ViewModelLocator viewModelLocator;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            this.ViewModel = viewModelLocator.ActivityEditorViewModel;
            num1 = (int) num3 * -939102200 ^ -561100959;
            continue;
          case 1:
            ActivityEditorView.\u206E‬⁪‏‪⁭⁮​​​‍‏‬⁬⁭⁬‌‌‫⁭‪⁯‎⁪‪⁯⁯‮⁫​⁭​​‬‍​‬⁯⁮⁮‮((FrameworkElement) this, (object) this.ViewModel);
            num1 = (int) num3 * 526968272 ^ 1901376858;
            continue;
          case 2:
            ((CompositePresentationEvent<IntPtr>) this._eventAggregator.GetEvent<CloseZoomZoomWindow>()).Subscribe(new Action<IntPtr>(this.CloseWindow), (ThreadOption) 1, false, new Predicate<IntPtr>(this.FilterCloseWindowEvent));
            num1 = (int) num3 * 1502741333 ^ -1658037578;
            continue;
          case 3:
            num1 = (int) num3 * -1990948829 ^ -1437518054;
            continue;
          case 4:
            this.ViewModel.ViewHandle = this._handle;
            num1 = (int) num3 * -1967816656 ^ -772171590;
            continue;
          case 5:
            num1 = (int) num3 * -2108403131 ^ -315347852;
            continue;
          case 6:
            viewModelLocator = ActivityEditorView.\u202D‌⁪⁪⁫‫‪‮‭‭‭⁮‬‌⁪⁪⁫‌‏‫⁯‍‏‍‎‬‏⁫⁬‎‭‮⁭‍‮‎‍⁭‬‌‮((FrameworkElement) this, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3873770166U)) as ViewModelLocator;
            num1 = (int) num3 * 1839031247 ^ 863058689;
            continue;
          case 7:
            goto label_1;
          case 8:
            flag = viewModelLocator != null;
            num1 = (int) num3 * 1748675841 ^ -536828856;
            continue;
          case 9:
            num1 = (int) num3 * 32886399 ^ -1092552093;
            continue;
          case 10:
            num1 = (int) num3 * -1748254230 ^ 227371978;
            continue;
          case 11:
            int num4 = flag ? 1336191022 : (num4 = 689101153);
            int num5 = (int) num3 * -342887457;
            num1 = num4 ^ num5;
            continue;
          case 12:
            num1 = (int) num3 * -180996113 ^ -385627168;
            continue;
          case 13:
            goto label_3;
          case 14:
            num1 = (int) num3 * -1085446377 ^ -512734181;
            continue;
          case 15:
            this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1708191649U));
            num1 = -1588143701;
            continue;
          case 16:
            num1 = (int) num3 * 2146636130 ^ 487576713;
            continue;
          case 17:
            this.ViewModel.Activity = this.Activity;
            num1 = (int) num3 * 569008329 ^ 929922031;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_3:;
    }

    private bool FilterCloseWindowEvent(IntPtr obj)
    {
label_1:
      int num1 = -1080230270;
      bool flag;
      while (true)
      {
        int num2 = -1789425872;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * 639515556 ^ -383316660;
            continue;
          case 2:
            flag = obj.Equals((object) this._handle);
            num1 = (int) num3 * -1041966221 ^ 2014251335;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void tbCameraRequestCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
label_1:
      int num1 = 1948055098;
      Regex regex;
      while (true)
      {
        int num2 = 1307128829;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            regex = ActivityEditorView.\u200D​‭⁮‌⁮‪⁪‍​‭‏⁭⁭‏‫‬​⁭‌‎‪⁫⁭‬‪⁯​‪‏⁪⁮⁬⁫‪⁬⁯⁭⁫‏‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2024820539U));
            num1 = (int) num3 * 974958125 ^ -1526997082;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ActivityEditorView.\u202A⁪⁪‪‭‭⁯‏⁯‬‫⁮‎⁮⁬‌⁬‮‏⁮‮‮‫‫‎⁮⁫‎⁬⁫‍‪‎⁫⁪‪⁮‮‮‭‮((RoutedEventArgs) e, ActivityEditorView.\u200C⁬⁬‭‬⁮⁯⁪‫‍⁫‍⁭‬​‎⁫‬​⁮‪‎‭⁪⁭‪‫‏⁭⁯​‬‫​‬‫⁮‮‪‪‮(regex, ActivityEditorView.\u206A⁪‬‫‬​‫‭‭⁪⁮‫⁫‫‍‬‍‭⁮‏​‮⁭⁭‌⁮⁪‬‌⁭​‏‪⁭‍⁯‭⁪‮‮(e)));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
label_1:
      int num1 = 1062784334;
      while (true)
      {
        int num2 = 913722209;
        uint num3;
        bool contentLoaded;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 2016306289 ^ 1814388288;
            continue;
          case 2:
            int num4 = contentLoaded ? 343105459 : (num4 = 1355399096);
            int num5 = (int) num3 * -1990163318;
            num1 = num4 ^ num5;
            continue;
          case 3:
            ActivityEditorView.\u200C‪‪⁬‮‍⁮​​‪⁭‮⁯⁯‫⁯‬⁪‭⁮⁭​‬⁭⁫‮‌⁫⁬‌⁫⁫‎‪⁬‍‭‫⁯‫‮((object) this, uri);
            num1 = (int) num3 * 1199233590 ^ -1025437670;
            continue;
          case 4:
            this._contentLoaded = true;
            num1 = 1715426326;
            continue;
          case 5:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * -1258801375 ^ 346618440;
            continue;
          case 6:
            uri = ActivityEditorView.\u206C​⁪⁪‍‎‫‍⁮⁭‏‮‪‎⁫⁭⁮‍‪‮‫‏‎‎⁪​‪‬⁯⁯‌⁪‌‭​⁫​⁭‍‍‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3169361216U), UriKind.Relative);
            num1 = (int) num3 * 1475307258 ^ 981453600;
            continue;
          case 7:
            goto label_3;
          case 8:
            num1 = (int) num3 * -327541846 ^ -486257994;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = -822266539;
      while (true)
      {
        int num2 = -125196708;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            num4 = connectionId;
            num1 = (int) num3 * 472199828 ^ -1930265573;
            continue;
          case 2:
            num1 = (int) num3 * -1158160524 ^ 1333928872;
            continue;
          case 3:
            int num5 = num4 == 1 ? -1892178425 : (num5 = -983455530);
            int num6 = (int) num3 * -741718449;
            num1 = num5 ^ num6;
            continue;
          case 4:
            goto label_3;
          case 5:
            this._contentLoaded = true;
            num1 = -2146944192;
            continue;
          case 6:
            ActivityEditorView.\u200B‮‬⁬‬‮‭‭‏‍‪​‏⁭‬⁫‬‍‮‫‮‬‏‭‮⁫‫‌‮⁬‬⁬‬‌‎‮‮⁮‭‎‮((FrameworkElement) target, new RoutedEventHandler(this.Window_Loaded));
            num1 = -470323490;
            continue;
          case 7:
            num1 = (int) num3 * 1269777445 ^ 1099349474;
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
    void IStyleConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = -1257497428;
      while (true)
      {
        int num2 = -1972777820;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 1296839903 ^ -1002458565;
            continue;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1898594842 ^ -856311388;
            continue;
          case 3:
            int num5 = num4 == 2 ? -2141871214 : (num5 = -710944359);
            int num6 = (int) num3 * -43977446;
            num1 = num5 ^ num6;
            continue;
          case 4:
            goto label_1;
          case 5:
            ActivityEditorView.\u202D‫‌⁯⁬‮‭‎‌‬⁬‍‏‪‍​⁬‮‮⁫‍‭‬‏⁯‍‮⁮‭‍‮‪⁯⁮⁪⁮‫⁭⁯‏‮((UIElement) target, new TextCompositionEventHandler(this.tbCameraRequestCount_PreviewTextInput));
            num1 = -1291624700;
            continue;
          case 6:
            num4 = connectionId;
            num1 = (int) num3 * 180551026 ^ 1723627042;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    static object \u200B⁯⁬⁪​‍‬‌‌‫‌‍‏‎‏‪⁯‏⁫⁫‭⁫‎‍‏⁬‎⁬⁮‭‎‭⁭‎‪‭⁯⁮‍⁯‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u202D‌‪‪‍⁫⁫⁫‮‫‏‍⁪⁬⁫⁫‍⁯‭‪⁪⁮⁮‪‍​‭⁭‬​⁬⁯⁮‎‎⁪⁪‬‌‎‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static MethodBase \u200F⁮⁬​⁭‪‫‮‬⁭‎⁫‭‪⁭⁬⁯⁭‭‏⁪⁯⁫‍‍⁯‌‫‎⁭⁯‏‭‬‌⁪‌‌‮‭‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206F‬⁭⁯‮‍‭‌‬⁪‏⁮​​⁬‪⁬‌‏‪⁮‭‏⁪‫⁯‭⁫‮‌⁬‍‮‍‫‌⁯⁮⁪‫‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206D⁮⁮⁭‎‍‭‎‬‭‬⁬‭‪​‪‬‪​⁫‬⁭‪‬‫⁬‍‍​‫​‭‮⁬‭‍‏‪⁬⁫‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static void \u206B‌‎⁮‫‫‬⁯‮‪‪⁮⁯‏‌‮‭‪‬‫‍‏‌⁫‪⁯‏‫⁬‌⁮‪‭‪‌‮‭‮⁮⁫‮([In] Window obj0)
    {
      obj0.Close();
    }

    static Delegate \u202D​‮‭‎⁭‍⁭⁭‫‌‫‎‬⁯‏⁭⁮‫‍‮⁭‫⁭‫⁯⁪‮‭⁯⁫‭‪‮‬‌⁮‏⁭‍‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u206F‎‪‪⁮‮⁪⁫‮⁮‫⁫‬​‏‏⁭‭‍‭‬⁪‍⁫​‬⁪‏⁯‮⁭‭⁭⁭​‬‌⁮‏⁪‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static PropertyChangedEventArgs \u202B⁬⁭‮‎‌⁫‪‮⁬‭‏‪‮⁮‎‪⁬​‍‮⁯⁭‌‬‪‍⁫⁫⁯‭‬‍⁬‭⁭‪⁯​‌‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }

    static WindowInteropHelper \u206E‌‮⁫‌⁪‬‌⁮‭⁬⁮‬⁪⁬⁬⁯⁬‭‍‪‮‬‬⁬‪⁯‭⁯‌‫⁬‪⁭‫⁫⁬⁪‫⁮‮([In] Window obj0)
    {
      return new WindowInteropHelper(obj0);
    }

    static IntPtr \u200C​‍​‍‭​⁪⁮‍​‌‍⁫⁮‏⁯‎‭‎⁯‎‭⁭‍‮⁭‪⁬​‌​‬⁭‌​‬⁮​‬‮([In] WindowInteropHelper obj0)
    {
      return obj0.Handle;
    }

    static object \u202D‌⁪⁪⁫‫‪‮‭‭‭⁮‬‌⁪⁪⁫‌‏‫⁯‍‏‍‎‬‏⁫⁬‎‭‮⁭‍‮‎‍⁭‬‌‮([In] FrameworkElement obj0, [In] object obj1)
    {
      return obj0.FindResource(obj1);
    }

    static void \u206E‬⁪‏‪⁭⁮​​​‍‏‬⁬⁭⁬‌‌‫⁭‪⁯‎⁪‪⁯⁯‮⁫​⁭​​‬‍​‬⁯⁮⁮‮([In] FrameworkElement obj0, [In] object obj1)
    {
      obj0.DataContext = obj1;
    }

    static Regex \u200D​‭⁮‌⁮‪⁪‍​‭‏⁭⁭‏‫‬​⁭‌‎‪⁫⁭‬‪⁯​‪‏⁪⁮⁬⁫‪⁬⁯⁭⁫‏‮([In] string obj0)
    {
      return new Regex(obj0);
    }

    static string \u206A⁪‬‫‬​‫‭‭⁪⁮‫⁫‫‍‬‍‭⁮‏​‮⁭⁭‌⁮⁪‬‌⁭​‏‪⁭‍⁯‭⁪‮‮([In] TextCompositionEventArgs obj0)
    {
      return obj0.Text;
    }

    static bool \u200C⁬⁬‭‬⁮⁯⁪‫‍⁫‍⁭‬​‎⁫‬​⁮‪‎‭⁪⁭‪‫‏⁭⁯​‬‫​‬‫⁮‮‪‪‮([In] Regex obj0, [In] string obj1)
    {
      return obj0.IsMatch(obj1);
    }

    static void \u202A⁪⁪‪‭‭⁯‏⁯‬‫⁮‎⁮⁬‌⁬‮‏⁮‮‮‫‫‎⁮⁫‎⁬⁫‍‪‎⁫⁪‪⁮‮‮‭‮([In] RoutedEventArgs obj0, [In] bool obj1)
    {
      obj0.Handled = obj1;
    }

    static Uri \u206C​⁪⁪‍‎‫‍⁮⁭‏‮‪‎⁫⁭⁮‍‪‮‫‏‎‎⁪​‪‬⁯⁯‌⁪‌‭​⁫​⁭‍‍‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200C‪‪⁬‮‍⁮​​‪⁭‮⁯⁯‫⁯‬⁪‭⁮⁭​‬⁭⁫‮‌⁫⁬‌⁫⁫‎‪⁬‍‭‫⁯‫‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u200B‮‬⁬‬‮‭‭‏‍‪​‏⁭‬⁫‬‍‮‫‮‬‏‭‮⁫‫‌‮⁬‬⁬‬‌‎‮‮⁮‭‎‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u202D‫‌⁯⁬‮‭‎‌‬⁬‍‏‪‍​⁬‮‮⁫‍‭‬‏⁯‍‮⁮‭‍‮‪⁯⁮⁪⁮‫⁭⁯‏‮([In] UIElement obj0, [In] TextCompositionEventHandler obj1)
    {
      obj0.PreviewTextInput += obj1;
    }

    static Type \u200F‍⁬⁪‎‭⁮⁮‫​⁮‌​‏‮‌⁮‍⁪‌‪⁭‪⁯⁫⁬⁪‫‍‏⁪​‫‬⁬‌⁮‌‫‍‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static PropertyMetadata \u202B‬⁯‎⁪‏‎​‬‍‮‪‭​‭‭‏‎⁯⁯‬⁪⁮‭⁭‏‍⁬​‫‭‭⁮‪‫‬‬‮‮‍‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new PropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u202B‌⁯⁫‪⁫⁯⁫‭‮‎⁭‌⁫⁪‌‪‏‫‌‍‫‌‫‌⁭‭‌‍‭‬‪‎⁭⁫‫‏‌‮⁫‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.Register(obj0, obj1, obj2, obj3);
    }
  }
}
