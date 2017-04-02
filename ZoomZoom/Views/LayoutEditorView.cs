// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.LayoutEditorView
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
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Threading;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Data.PropertyGrid;
using ZoomZoom.ViewModels;

namespace ZoomZoom.Views
{
  public class LayoutEditorView : Window, INotifyPropertyChanged, IComponentConnector
  {
    public static readonly DependencyProperty LayoutProperty = LayoutEditorView.\u200B‎⁮‍‫‮‫⁮‍‎‭‭​⁪‎‎‎‭‬⁪‍‮‍⁭‪⁬‍⁫⁮‫⁯‎⁫​⁯‭⁮⁮⁬‍‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(948207151U), LayoutEditorView.\u206D‏⁬⁭‭‮⁬‭‭‏‏​⁪‏‏‪⁬‮‍‪‭‮‪‍⁯⁪‪‬‭‬‌​‬‏‫​‎⁮⁯‮‮(__typeref (LayoutPattern)), LayoutEditorView.\u206D‏⁬⁭‭‮⁬‭‭‏‏​⁪‏‏‪⁬‮‍‪‭‮‪‍⁯⁪‪‬‭‬‌​‬‏‫​‎⁮⁯‮‮(__typeref (LayoutEditorView)), LayoutEditorView.\u202B⁯‬⁯‫⁬‎⁬‭‬⁯⁯‮⁭‭⁪‏‭⁬​⁮‪‬⁭‫⁪‌‌⁯‎⁮‎‌⁬‏‪​‬⁬⁪‮((object) null, new PropertyChangedCallback(LayoutEditorView.OnLayoutPatternChanged)));
    private ILog log = LayoutEditorView.\u206A⁮‮‬⁮‭​‬‎‏‮⁭‌‮⁮‮​⁭​‌‬‮‏‌⁪⁭‪⁬‫⁬⁭‏‫⁫‭‏⁯⁪​⁫‮(LayoutEditorView.\u200B⁯‬‏⁭⁫‬‬⁭​‎​‭⁫⁮⁯‍‮‪‪⁯‮‎⁭‏‌‌⁯‮‭‪‎​‏‎⁬⁫‎‌‏‮((MemberInfo) LayoutEditorView.\u200F‍‌⁬‎‪‏⁫⁮‭⁭​‪‏‍⁭⁪‬‏⁯‪⁫‎⁬⁯⁭‭‍‬​‍⁭‫‮‭⁯⁯‭‬‮()));
    protected readonly IEventAggregator _eventAggregator;
    private SubscriptionToken token;
    internal RadPropertyGrid pgPattern;
    internal Button btnDeletePattern;
    internal Button btnApplyLayout;
    internal Button btnSavePattern;
    private bool _contentLoaded;

    internal LayoutEditorViewModel ViewModel
    {
      get
      {
        return (LayoutEditorViewModel) LayoutEditorView.\u200F⁪‭‭⁫‮⁪‭‬‬‭⁭‫⁫⁬⁬⁭‏⁪‏‎‫‭‪⁪⁯‭⁬‭⁬⁯‮⁭‎‪‏⁪‮⁪‏‮(LayoutEditorView.\u206C‎‎‮‌‪‪‮⁫⁯⁫‪⁫⁭⁯⁬‎‮‌⁫‬⁯⁭‍‫‏‌‍‏‌⁫‍‪⁭⁫⁪‮⁫‮‏‮((FrameworkElement) this), (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(296791867U));
      }
    }

    public LayoutPattern Layout
    {
      get
      {
label_1:
        int num1 = -1768970620;
        LayoutPattern layoutPattern;
        while (true)
        {
          int num2 = -103409604;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              layoutPattern = (LayoutPattern) LayoutEditorView.\u202E⁭​⁫⁯‫⁬⁭‪‮⁭⁬⁮⁪‏⁮⁭⁭‎‪‌‮‏⁬‬‌⁯⁬⁬⁪​‫​‫⁮‍⁫‪‭⁬‮((DependencyObject) this, LayoutEditorView.LayoutProperty);
              num1 = (int) num3 * 156787857 ^ -1568240276;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return layoutPattern;
      }
      set
      {
        LayoutEditorView.\u200B⁬‬​⁬‫⁭‪⁮‎‎‪‬‬⁭⁭‎⁬​⁯⁮‏‪‍⁪⁭⁭​‌⁭‏⁬⁯‏⁪⁭⁯‏‪‭‮((DependencyObject) this, LayoutEditorView.LayoutProperty, (object) value);
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(948207151U));
label_1:
        int num1 = 1756941209;
        while (true)
        {
          int num2 = 660349501;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 2132541988 ^ -585999083;
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

    public event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_1:
        int num1 = -538952948;
        while (true)
        {
          int num2 = -655644219;
          uint num3;
          PropertyChangedEventHandler comparand;
          PropertyChangedEventHandler changedEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
              int num4 = changedEventHandler1 == comparand ? 909036826 : (num4 = 1920421620);
              int num5 = (int) num3 * -693957582;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = changedEventHandler1;
              changedEventHandler2 = (PropertyChangedEventHandler) LayoutEditorView.\u206C‌⁭‫‬⁬‫⁪‭⁫⁫‌‬‏⁮⁫‌⁯‏⁫‍‫⁬‮‌‎‎‬‫⁫‪⁮⁯‭⁬‭‫‬​‫‮((Delegate) comparand, (Delegate) value);
              num1 = -2015186023;
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
      remove
      {
        PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;
label_1:
        int num1 = 161417404;
        while (true)
        {
          int num2 = 739221358;
          uint num3;
          PropertyChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              comparand = changedEventHandler;
              changedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, (PropertyChangedEventHandler) LayoutEditorView.\u206A‌‮‬‬‏‪‎‭⁬⁪‎‮‏‌‎⁯⁬‫‍‌‮‎⁭‏‌⁪‌​⁬⁬​‏‪⁯‏⁯‫​‬‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = 2110617173;
              continue;
            case 3:
              int num4 = changedEventHandler == comparand ? 1930585050 : (num4 = 171024377);
              int num5 = (int) num3 * -1086293633;
              num1 = num4 ^ num5;
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

    public LayoutEditorView()
    {
      this.InitializeComponent();
      this._eventAggregator = ApplicationService.Instance.EventAggregator;
      this.token = ((CompositePresentationEvent<SubscriptionToken>) this._eventAggregator.GetEvent<ViewEvent>()).Subscribe(new Action<SubscriptionToken>(this.ViewExit), (ThreadOption) 1);
    }

    private void ViewExit(SubscriptionToken obj)
    {
      try
      {
        // ISSUE: method pointer
        LayoutEditorView.\u202C‬‮‪‌⁭‬‍⁯⁯⁭‫‮⁮‌⁫‏⁫​⁬​⁫‬‌‫‬‪⁯⁭‏‫⁭‬‭‎⁭⁭⁪​‫‮(LayoutEditorView.\u206F‏‏⁪‭​⁯⁯‪⁪‏‏⁭‏​⁭⁭‬‮‎⁪‫‭​⁯‮⁬‌‌‭⁫⁪‏⁪⁫⁭‌‬‪⁭‮((DispatcherObject) this), new Action((object) this, __methodptr(\u003CViewExit\u003Eb__4_0)));
label_2:
        int num1 = -326648770;
        while (true)
        {
          int num2 = -1097225941;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_12;
            case 1:
              num1 = (int) num3 * -1318573606 ^ 648070256;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_12:;
      }
      catch (Exception ex)
      {
label_8:
        int num1 = -1738532621;
        while (true)
        {
          int num2 = -1097225941;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_8;
            case 1:
              goto label_6;
            case 2:
              LayoutEditorView.\u200D‪⁮​⁬⁭‮‭‏‍​⁬⁫‍‬‭⁪⁫‪‮‪‫⁫‌‮⁬​‏‎⁬‍⁭⁫‏‭‎‫‎⁬‬‮(this.log, (object) ex);
              num1 = (int) num3 * -1743547398 ^ 603002821;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_6:;
      }
    }

    public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    {
label_1:
      int num1 = 30600563;
      while (true)
      {
        int num2 = 2079856528;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1121788324 ^ -910856383;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.RaisePropertyChanged(LayoutEditorView.\u206A‎‫⁭⁯⁮⁭‭‏‫⁭⁪‍‎‪‏‪⁮⁯⁯‭⁪‎⁪⁮​‌⁯⁪‌​‬​⁮⁪⁯‬⁯⁮‏‮(propertyName));
            num1 = (int) num3 * -127670183 ^ 477003299;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    protected virtual void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
label_1:
      int num1 = 1635852285;
      while (true)
      {
        int num2 = 9497088;
        uint num3;
        PropertyChangedEventHandler propertyChanged;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            propertyChanged = this.PropertyChanged;
            int num4 = propertyChanged == null ? -164465957 : (num4 = -950674334);
            int num5 = (int) num3 * 1001529432;
            num1 = num4 ^ num5;
            continue;
          case 2:
            propertyChanged((object) this, args);
            num1 = (int) num3 * 611032128 ^ 465937059;
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

    private static void OnLayoutPatternChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
label_1:
      int num1 = -1237614487;
      while (true)
      {
        int num2 = -771519762;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ((LayoutEditorView) d).Layout = (LayoutPattern) e.NewValue;
            num1 = (int) num3 * -2028068339 ^ 1247507440;
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

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = -289030006;
      while (true)
      {
        int num2 = -1048457660;
        uint num3;
        ViewModelLocator viewModelLocator;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            LayoutEditorView.\u200D⁫‫‫‫‬‬‫⁮‬‫‏‏⁮⁯⁪‪⁮⁭‮⁮‎‮‬‎⁪‍⁯⁪⁮‫‫‍‎⁭‏‌‪‫⁭‮((FrameworkElement) this, (object) viewModelLocator.LayoutEditorViewModel);
            num1 = (int) num3 * -500199531 ^ 196632176;
            continue;
          case 1:
            flag = viewModelLocator != null;
            num1 = (int) num3 * 109140929 ^ -790834334;
            continue;
          case 2:
            viewModelLocator = LayoutEditorView.\u200D‭⁫‬⁮‎‭‫‭‎​‌‌‪‬‫‫‍‭‎​⁪‍⁭⁬⁫‏⁪⁭⁮‮‌‪‫⁮‪⁯‫‌⁭‮((FrameworkElement) this, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3873770166U)) as ViewModelLocator;
            num1 = (int) num3 * -1898698533 ^ 389288599;
            continue;
          case 3:
            int num4 = flag ? -762747674 : (num4 = -42638800);
            int num5 = (int) num3 * 1922409887;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * -1773208474 ^ 524579829;
            continue;
          case 5:
            num1 = (int) num3 * 2008455435 ^ 1083579714;
            continue;
          case 6:
            num1 = (int) num3 * -1786995389 ^ 1688776386;
            continue;
          case 7:
            goto label_1;
          case 8:
            viewModelLocator.LayoutEditorViewModel.Pattern = this.Layout;
            num1 = (int) num3 * 1543056732 ^ -808378138;
            continue;
          case 9:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2602970392U));
            num1 = -1078347930;
            continue;
          case 10:
            goto label_3;
          case 11:
            num1 = (int) num3 * -1034793144 ^ 899904924;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = -1054511954;
      while (true)
      {
        int num2 = -1755680228;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            LayoutEditorView.\u206E‭‫‫‭‭⁪‭‪‍‏⁭⁯‌‎⁪‬⁮‮‌‬‬‫⁬⁯⁬⁪⁮‫⁬‎⁫‬‏‎​‎⁭‭⁫‮((Window) this);
            num1 = (int) num3 * -1143812302 ^ 238796436;
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

    private void btnCancelLayout_Click(object sender, RoutedEventArgs e)
    {
    }

    private void Window_Closing(object sender, CancelEventArgs e)
    {
    }

    private void RadPropertyGrid_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = 1130894502;
      while (true)
      {
        int num2 = 875911956;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            LayoutEditorView.\u206E⁯‬‏⁪⁯‎⁯‬⁯‭‌‭​⁭​‬⁮‍⁫‪‮‫​⁮‪‮‬⁮⁯‍⁭⁮⁮‌‪⁬⁯‎‮((Window) this, LayoutEditorView.\u202B‭⁭‫‮‭‌‏⁬‬‫⁮‏‌‬‬‬‍‍⁮‭‎⁬‎⁭⁯⁬‌⁭‏⁬⁯‍⁫⁮⁫‬‫⁯‮(LayoutEditorView.\u202C⁬‫‮‍​‮⁬‌‍‍‌‪‎‏⁬‌‮‌​‭​⁪‭⁮⁫‬‎‬⁫⁯‫‬‏‌‪‌‬‮‪‮((Window) this)) + LayoutEditorView.\u200F‭⁬⁮⁯⁫⁯‌⁬⁭‍​⁭‭⁫⁯‌‬​⁪⁮‌‫‎‏‬‮‌​​⁮​‪‌⁮⁪​⁮⁬⁯‮((FrameworkElement) LayoutEditorView.\u202C⁬‫‮‍​‮⁬‌‍‍‌‪‎‏⁬‌‮‌​‭​⁪‭⁮⁫‬‎‬⁫⁯‫‬‏‌‪‌‬‮‪‮((Window) this)) + 5.0);
            num1 = (int) num3 * -1648863877 ^ 1995834064;
            continue;
          case 1:
            int num4 = LayoutEditorView.\u202C⁬‫‮‍​‮⁬‌‍‍‌‪‎‏⁬‌‮‌​‭​⁪‭⁮⁫‬‎‬⁫⁯‫‬‏‌‪‌‬‮‪‮((Window) this) == null ? 937549332 : (num4 = 2137193597);
            int num5 = (int) num3 * -2143799050;
            num1 = num4 ^ num5;
            continue;
          case 2:
            LayoutEditorView.\u206D‎‌⁮⁯⁪‫‪​‍‫⁮⁫‍‌​‍‎‫‪‍⁭‌‌⁮‫⁪‫‮‍‫⁭‫⁭‏‏⁫‍⁮⁪‮((Window) this, true);
            num1 = (int) num3 * -82209431 ^ -1087768955;
            continue;
          case 3:
            num1 = (int) num3 * 386290914 ^ 1085416299;
            continue;
          case 4:
            num1 = (int) num3 * -33928764 ^ -2001918654;
            continue;
          case 5:
            goto label_1;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num3 * -1388175333 ^ -668747903;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    private void RadPropertyGrid_AutoGeneratingPropertyDefinition(object sender, AutoGeneratingPropertyDefinitionEventArgs e)
    {
label_1:
      int num1 = 997835520;
      while (true)
      {
        int num2 = 670112882;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -806871124 ^ 547411925;
            continue;
          case 3:
            num1 = (int) num3 * -292476176 ^ 1444422854;
            continue;
          case 4:
            num1 = (int) num3 * 1192580278 ^ 219320881;
            continue;
          case 5:
            num1 = (int) num3 * 1119204335 ^ 1105421375;
            continue;
          case 6:
            int num4 = LayoutEditorView.\u206B‍⁬‌​‮‍⁬⁬​‍⁫‎‭⁮‌‌‫⁫⁮⁪‍‪‍⁫‎⁯⁬⁮⁫‌⁪‌​⁪⁮⁯‏⁭⁪‮(LayoutEditorView.\u206E‎⁭⁫⁭‫‮⁮⁫⁬‌‮⁭‫‫‮⁫‎‍‍‫‬‎⁭‫​⁯​‭‎‭‭⁭⁫‮⁯⁯⁭‭‍‮(LayoutEditorView.\u206B‏‎​‬‭‎‫‮​⁬⁮‍‮‬‌‭⁯⁯‭‌‭‫‍⁬⁪⁯‫‌⁭‪‮‍⁫‍⁭‌‮​⁮‮(LayoutEditorView.\u202B⁪‮‍⁫‌⁬⁬​‍⁯⁪‍⁫​⁭⁮⁯‪⁬‏⁬⁮⁯‪‎‮​‍‬‎‮⁯⁭‌‪⁮‎⁬‪‮(e))), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3353321762U)) ? 1121915693 : (num4 = 1106151161);
            int num5 = (int) num3 * -291016170;
            num1 = num4 ^ num5;
            continue;
          case 7:
            int num6 = flag ? -115194088 : (num6 = -1027844014);
            int num7 = (int) num3 * -465606063;
            num1 = num6 ^ num7;
            continue;
          case 8:
            num1 = (int) num3 * -1638296754 ^ 428004940;
            continue;
          case 9:
            flag = LayoutEditorView.\u206B‍⁬‌​‮‍⁬⁬​‍⁫‎‭⁮‌‌‫⁫⁮⁪‍‪‍⁫‎⁯⁬⁮⁫‌⁪‌​⁪⁮⁯‏⁭⁪‮(LayoutEditorView.\u206E‎⁭⁫⁭‫‮⁮⁫⁬‌‮⁭‫‫‮⁫‎‍‍‫‬‎⁭‫​⁯​‭‎‭‭⁭⁫‮⁯⁯⁭‭‍‮(LayoutEditorView.\u206B‏‎​‬‭‎‫‮​⁬⁮‍‮‬‌‭⁯⁯‭‌‭‫‍⁬⁪⁯‫‌⁭‪‮‍⁫‍⁭‌‮​⁮‮(LayoutEditorView.\u202B⁪‮‍⁫‌⁬⁬​‍⁯⁪‍⁫​⁭⁮⁯‪⁬‏⁬⁮⁯‪‎‮​‍‬‎‮⁯⁭‌‪⁮‎⁬‪‮(e))), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3572104350U));
            num1 = 1410722677;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
label_1:
      int num1 = 989034930;
      while (true)
      {
        int num2 = 816600003;
        uint num3;
        bool contentLoaded;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            int num4 = !contentLoaded ? -1860958943 : (num4 = -1447717952);
            int num5 = (int) num3 * -1623896371;
            num1 = num4 ^ num5;
            continue;
          case 1:
            this._contentLoaded = true;
            LayoutEditorView.\u202D‫⁫‪‫⁭‬⁮‪⁬⁮‪⁫⁮⁮‍⁬‭‏‬⁫‎⁬‏‬⁪‏‫‬⁪​‍‫⁫⁪‮‮‏‏⁮‮((object) this, LayoutEditorView.\u202B‬​​‬‭⁮⁬‭‎‏‮‭⁮‌⁭⁫‬⁪‬‮​‫‫‬⁮‏‮‏‎​⁭‍⁯‮‪‍‫⁮⁮‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3760992642U), UriKind.Relative));
            num1 = 2059401369;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -1503579720 ^ 1031842377;
            continue;
          case 5:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * -1872624932 ^ 69507060;
            continue;
          case 6:
            num1 = (int) num3 * 1113301046 ^ 1014466609;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = 1402657126;
      while (true)
      {
        int num2 = 1851158300;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = (int) num3 * 479486523 ^ -873196720;
            continue;
          case 1:
            num1 = (int) num3 * 237433668 ^ 399688574;
            continue;
          case 2:
label_8:
            this.btnDeletePattern = (Button) target;
            num1 = 470470550;
            continue;
          case 3:
label_7:
            this.btnSavePattern = (Button) target;
            num1 = 470470550;
            continue;
          case 4:
            this._contentLoaded = true;
            num1 = 470470550;
            continue;
          case 5:
            switch (num4)
            {
              case 1:
                goto label_9;
              case 2:
                goto label_13;
              case 3:
                goto label_8;
              case 4:
                goto label_14;
              case 5:
                goto label_7;
              default:
                num1 = (int) num3 * 963732435 ^ -526187628;
                continue;
            }
          case 6:
            LayoutEditorView.\u206F​‫⁬‬⁭‫⁬‮​⁭‪‍‌‎⁭‍‪⁫‮⁮‮‍⁫‮‬⁪‬⁭‍‭⁪⁬‎⁯⁯⁯‏⁯‭‮((Window) target, new CancelEventHandler(this.Window_Closing));
            num1 = (int) num3 * -1780773712 ^ -1064233586;
            continue;
          case 7:
label_9:
            LayoutEditorView.\u206C⁫‌‏‭‏‌⁫‮‪⁬‬⁯⁮‫​‏‮‌⁪‬‮‏⁬⁮‍‪‮‎‫‏‮⁪‬‎⁭‪⁯‍⁬‮((FrameworkElement) target, new RoutedEventHandler(this.Window_Loaded));
            num1 = 2026052126;
            continue;
          case 8:
            goto label_1;
          case 9:
label_14:
            this.btnApplyLayout = (Button) target;
            num1 = 912043287;
            continue;
          case 10:
            num4 = connectionId;
            num1 = (int) num3 * -1556186719 ^ 1679043455;
            continue;
          case 11:
label_13:
            this.pgPattern = (RadPropertyGrid) target;
            num1 = 470470550;
            continue;
          case 12:
            goto label_3;
          case 13:
            num1 = (int) num3 * 744155634 ^ 1018150640;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_3:;
    }

    static MethodBase \u200F‍‌⁬‎‪‏⁫⁮‭⁭​‪‏‍⁭⁪‬‏⁯‪⁫‎⁬⁯⁭‭‍‬​‍⁭‫‮‭⁯⁯‭‬‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200B⁯‬‏⁭⁫‬‬⁭​‎​‭⁫⁮⁯‍‮‪‪⁯‮‎⁭‏‌‌⁯‮‭‪‎​‏‎⁬⁫‎‌‏‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206A⁮‮‬⁮‭​‬‎‏‮⁭‌‮⁮‮​⁭​‌‬‮‏‌⁪⁭‪⁬‫⁬⁭‏‫⁫‭‏⁯⁪​⁫‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static Dispatcher \u206F‏‏⁪‭​⁯⁯‪⁪‏‏⁭‏​⁭⁭‬‮‎⁪‫‭​⁯‮⁬‌‌‭⁫⁪‏⁪⁫⁭‌‬‪⁭‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u202C‬‮‪‌⁭‬‍⁯⁯⁭‫‮⁮‌⁫‏⁫​⁬​⁫‬‌‫‬‪⁯⁭‏‫⁭‬‭‎⁭⁭⁪​‫‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static void \u200D‪⁮​⁬⁭‮‭‏‍​⁬⁫‍‬‭⁪⁫‪‮‪‫⁫‌‮⁬​‏‎⁬‍⁭⁫‏‭‎‫‎⁬‬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static ResourceDictionary \u206C‎‎‮‌‪‪‮⁫⁯⁫‪⁫⁭⁯⁬‎‮‌⁫‬⁯⁭‍‫‏‌‍‏‌⁫‍‪⁭⁫⁪‮⁫‮‏‮([In] FrameworkElement obj0)
    {
      return obj0.Resources;
    }

    static object \u200F⁪‭‭⁫‮⁪‭‬‬‭⁭‫⁫⁬⁬⁭‏⁪‏‎‫‭‪⁪⁯‭⁬‭⁬⁯‮⁭‎‪‏⁪‮⁪‏‮([In] ResourceDictionary obj0, [In] object obj1)
    {
      return obj0[obj1];
    }

    static Delegate \u206C‌⁭‫‬⁬‫⁪‭⁫⁫‌‬‏⁮⁫‌⁯‏⁫‍‫⁬‮‌‎‎‬‫⁫‪⁮⁯‭⁬‭‫‬​‫‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u206A‌‮‬‬‏‪‎‭⁬⁪‎‮‏‌‎⁯⁬‫‍‌‮‎⁭‏‌⁪‌​⁬⁬​‏‪⁯‏⁯‫​‬‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static PropertyChangedEventArgs \u206A‎‫⁭⁯⁮⁭‭‏‫⁭⁪‍‎‪‏‪⁮⁯⁯‭⁪‎⁪⁮​‌⁯⁪‌​‬​⁮⁪⁯‬⁯⁮‏‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }

    static object \u202E⁭​⁫⁯‫⁬⁭‪‮⁭⁬⁮⁪‏⁮⁭⁭‎‪‌‮‏⁬‬‌⁯⁬⁬⁪​‫​‫⁮‍⁫‪‭⁬‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u200B⁬‬​⁬‫⁭‪⁮‎‎‪‬‬⁭⁭‎⁬​⁯⁮‏‪‍⁪⁭⁭​‌⁭‏⁬⁯‏⁪⁭⁯‏‪‭‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static object \u200D‭⁫‬⁮‎‭‫‭‎​‌‌‪‬‫‫‍‭‎​⁪‍⁭⁬⁫‏⁪⁭⁮‮‌‪‫⁮‪⁯‫‌⁭‮([In] FrameworkElement obj0, [In] object obj1)
    {
      return obj0.FindResource(obj1);
    }

    static void \u200D⁫‫‫‫‬‬‫⁮‬‫‏‏⁮⁯⁪‪⁮⁭‮⁮‎‮‬‎⁪‍⁯⁪⁮‫‫‍‎⁭‏‌‪‫⁭‮([In] FrameworkElement obj0, [In] object obj1)
    {
      obj0.DataContext = obj1;
    }

    static void \u206E‭‫‫‭‭⁪‭‪‍‏⁭⁯‌‎⁪‬⁮‮‌‬‬‫⁬⁯⁬⁪⁮‫⁬‎⁫‬‏‎​‎⁭‭⁫‮([In] Window obj0)
    {
      obj0.Close();
    }

    static void \u206D‎‌⁮⁯⁪‫‪​‍‫⁮⁫‍‌​‍‎‫‪‍⁭‌‌⁮‫⁪‫‮‍‫⁭‫⁭‏‏⁫‍⁮⁪‮([In] Window obj0, [In] bool obj1)
    {
      obj0.Topmost = obj1;
    }

    static Window \u202C⁬‫‮‍​‮⁬‌‍‍‌‪‎‏⁬‌‮‌​‭​⁪‭⁮⁫‬‎‬⁫⁯‫‬‏‌‪‌‬‮‪‮([In] Window obj0)
    {
      return obj0.Owner;
    }

    static double \u202B‭⁭‫‮‭‌‏⁬‬‫⁮‏‌‬‬‬‍‍⁮‭‎⁬‎⁭⁯⁬‌⁭‏⁬⁯‍⁫⁮⁫‬‫⁯‮([In] Window obj0)
    {
      return obj0.Top;
    }

    static double \u200F‭⁬⁮⁯⁫⁯‌⁬⁭‍​⁭‭⁫⁯‌‬​⁪⁮‌‫‎‏‬‮‌​​⁮​‪‌⁮⁪​⁮⁬⁯‮([In] FrameworkElement obj0)
    {
      return obj0.ActualHeight;
    }

    static void \u206E⁯‬‏⁪⁯‎⁯‬⁯‭‌‭​⁭​‬⁮‍⁫‪‮‫​⁮‪‮‬⁮⁯‍⁭⁮⁮‌‪⁬⁯‎‮([In] Window obj0, [In] double obj1)
    {
      obj0.Top = obj1;
    }

    static PropertyDefinition \u202B⁪‮‍⁫‌⁬⁬​‍⁯⁪‍⁫​⁭⁮⁯‪⁬‏⁬⁮⁯‪‎‮​‍‬‎‮⁯⁭‌‪⁮‎⁬‪‮([In] AutoGeneratingPropertyDefinitionEventArgs obj0)
    {
      return obj0.get_PropertyDefinition();
    }

    static ItemPropertyInfo \u206B‏‎​‬‭‎‫‮​⁬⁮‍‮‬‌‭⁯⁯‭‌‭‫‍⁬⁪⁯‫‌⁭‪‮‍⁫‍⁭‌‮​⁮‮([In] PropertyDefinition obj0)
    {
      return obj0.get_SourceProperty();
    }

    static string \u206E‎⁭⁫⁭‫‮⁮⁫⁬‌‮⁭‫‫‮⁫‎‍‍‫‬‎⁭‫​⁯​‭‎‭‭⁭⁫‮⁯⁯⁭‭‍‮([In] ItemPropertyInfo obj0)
    {
      return obj0.Name;
    }

    static bool \u206B‍⁬‌​‮‍⁬⁬​‍⁫‎‭⁮‌‌‫⁫⁮⁪‍‪‍⁫‎⁯⁬⁮⁫‌⁪‌​⁪⁮⁯‏⁭⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static Uri \u202B‬​​‬‭⁮⁬‭‎‏‮‭⁮‌⁭⁫‬⁪‬‮​‫‫‬⁮‏‮‏‎​⁭‍⁯‮‪‍‫⁮⁮‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u202D‫⁫‪‫⁭‬⁮‪⁬⁮‪⁫⁮⁮‍⁬‭‏‬⁫‎⁬‏‬⁪‏‫‬⁪​‍‫⁫⁪‮‮‏‏⁮‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206C⁫‌‏‭‏‌⁫‮‪⁬‬⁯⁮‫​‏‮‌⁪‬‮‏⁬⁮‍‪‮‎‫‏‮⁪‬‎⁭‪⁯‍⁬‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u206F​‫⁬‬⁭‫⁬‮​⁭‪‍‌‎⁭‍‪⁫‮⁮‮‍⁫‮‬⁪‬⁭‍‭⁪⁬‎⁯⁯⁯‏⁯‭‮([In] Window obj0, [In] CancelEventHandler obj1)
    {
      obj0.Closing += obj1;
    }

    static Type \u206D‏⁬⁭‭‮⁬‭‭‏‏​⁪‏‏‪⁬‮‍‪‭‮‪‍⁯⁪‪‬‭‬‌​‬‏‫​‎⁮⁯‮‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static PropertyMetadata \u202B⁯‬⁯‫⁬‎⁬‭‬⁯⁯‮⁭‭⁪‏‭⁬​⁮‪‬⁭‫⁪‌‌⁯‎⁮‎‌⁬‏‪​‬⁬⁪‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new PropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u200B‎⁮‍‫‮‫⁮‍‎‭‭​⁪‎‎‎‭‬⁪‍‮‍⁭‪⁬‍⁫⁮‫⁯‎⁫​⁯‭⁮⁮⁬‍‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.Register(obj0, obj1, obj2, obj3);
    }
  }
}
