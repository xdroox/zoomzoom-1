// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.ButtonEditorView
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using ZoomZoom.ViewModels;

namespace ZoomZoom.Views
{
  public class ButtonEditorView : Window, IComponentConnector
  {
    public static readonly DependencyProperty ButtonProperty = ButtonEditorView.\u202A‍⁭‏‏⁬‏​‌‮⁭⁮⁭⁮⁭‌⁭⁪⁭‍⁪⁭⁫⁬‬​‍‍‫‮‍‬‌‪⁬⁬⁬‏‮‎‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3059864303U), ButtonEditorView.\u206B‍⁮‌​⁭‏⁯⁪​‍⁯‎‎‏​⁬⁯‎⁯⁫⁮‭‮‍​‍​‬⁯⁯⁪‫⁫‪‫⁯‎⁭‬‮(__typeref (ZoomButton)), ButtonEditorView.\u206B‍⁮‌​⁭‏⁯⁪​‍⁯‎‎‏​⁬⁯‎⁯⁫⁮‭‮‍​‍​‬⁯⁯⁪‫⁫‪‫⁯‎⁭‬‮(__typeref (ButtonEditorView)), ButtonEditorView.\u202D⁪‭‏⁯‎⁫⁭‌‫⁯⁪‭⁭‭‏​‮‌‬‪‭‭‎‎⁯‭⁫‎⁭‌⁯‏‎‎‬‭⁪⁮‎‮((object) null, new PropertyChangedCallback(ButtonEditorView.OnButtonChanged)));
    private ButtonEditorViewModel viewModel = (ButtonEditorViewModel) null;
    protected readonly IEventAggregator _eventAggregator;
    private SubscriptionToken token;
    private IntPtr handle;
    internal RowDefinition MeetingIdRow;
    private bool _contentLoaded;

    public ZoomButton Button
    {
      get
      {
        return (ZoomButton) ButtonEditorView.\u202A‏‍‍‫‎‫⁫‍⁯‫‏⁪‪‍⁪⁪⁮‍⁫⁫​‎‎‏‬⁬⁪‬‍⁭⁬​⁬‏⁯‮‫⁭‏‮((DependencyObject) this, ButtonEditorView.ButtonProperty);
      }
      set
      {
        ButtonEditorView.\u202B‏‪‍‍⁫‫⁭⁭​​‬⁭‮​⁮‏⁯‮‏⁪⁭⁯⁭​‮‍‭‌‎‏‍⁬⁮‌‌⁯‌‌⁬‮((DependencyObject) this, ButtonEditorView.ButtonProperty, (object) value);
label_1:
        int num1 = 944954105;
        while (true)
        {
          int num2 = 1212917875;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -1148442909 ^ -1470720231;
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

    public System.Drawing.Point ButtonLocation { get; internal set; }

    internal ButtonEditorViewModel ViewModel
    {
      get
      {
label_1:
        int num1 = -1150856360;
        ButtonEditorViewModel viewModel;
        while (true)
        {
          int num2 = -2099476767;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1000501251 ^ 145132150;
              continue;
            case 1:
              viewModel = this.viewModel;
              num1 = (int) num3 * -55695380 ^ -902877659;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return viewModel;
      }
      set
      {
label_1:
        int num1 = 961978351;
        while (true)
        {
          int num2 = 1848911865;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.viewModel = value;
              num1 = (int) num3 * -1637760686 ^ -1589797466;
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

    public ButtonEditorView()
    {
label_1:
      int num1 = 1220129879;
      while (true)
      {
        int num2 = 399883858;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.InitializeComponent();
            num1 = (int) num3 * 2053671032 ^ -1903587335;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 379652970 ^ -1636831762;
            continue;
          case 4:
            num1 = (int) num3 * 1777765534 ^ -2125579608;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      this._eventAggregator = ApplicationService.Instance.EventAggregator;
    }

    private static void OnButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      ((ButtonEditorView) d).Button = (ZoomButton) e.NewValue;
    }

    private void HandleViewEvent(ViewEventPayload payload)
    {
label_1:
      int num1 = -842274814;
      while (true)
      {
        int num2 = -1262992213;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            if (payload.Handle == this.handle)
            {
              num1 = (int) num3 * -2027590883 ^ -1547670856;
              continue;
            }
            num4 = 0;
            break;
          case 2:
            num4 = payload.ViewEventType == ViewEventType.Close ? 1 : 0;
            break;
          case 3:
            num1 = (int) num3 * 1170615050 ^ 1786877933;
            continue;
          case 4:
            goto label_3;
          case 5:
            ButtonEditorView.\u200E⁫⁬⁪⁭⁮‭‏‬‮⁯⁭⁭⁪⁯‏⁬⁬⁭⁯‮‏⁭​⁭‪‪‮‫⁪‏‌‬​‫‍⁭⁬⁬‮‮((Window) this);
            num1 = (int) num3 * 790718115 ^ 1994504453;
            continue;
          default:
            goto label_11;
        }
        int num5;
        num1 = num5 = num4 != 0 ? -926054336 : (num5 = -1133242757);
      }
label_11:
      return;
label_3:;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      this.handle = ButtonEditorView.\u206C‍⁭⁪‪‫‌‪​‬⁫‍⁭‭⁯⁬​⁪⁮⁭‮‭⁬‎‭‫‏‭‬‬⁯‬‎‭‪​​‎‎‫‮(ButtonEditorView.\u206B⁮‭⁭‮⁯​‍‍⁯‏‭‭‭‬⁪‎​‭⁪‮⁫⁬‎‮‪⁪‎‌⁭⁪‏⁯‭‫‪⁭⁯‍⁪‮((Window) this));
label_1:
      int num1 = -94515066;
      while (true)
      {
        int num2 = -1702399283;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            this.token = ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Subscribe(new Action<ViewEventPayload>(this.HandleViewEvent), (ThreadOption) 1, false, (Predicate<ViewEventPayload>) (x => x.Handle == this.handle));
            this.ViewModel = new ButtonEditorViewModel(this.Button);
            num1 = (int) num3 * -937174596 ^ -496749845;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -865611663 ^ 1439661197;
            continue;
          case 4:
            this.ViewModel.Initialize(this.handle, this.Button);
            num1 = (int) num3 * -2018048811 ^ 1672456367;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
label_1:
      int num1 = -1828833508;
      while (true)
      {
        int num2 = -157152769;
        uint num3;
        bool contentLoaded;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            uri = ButtonEditorView.\u200C‏‏‏‏⁮‪‌⁭‏‏‭‌⁫⁬‌‫‎‬​‪‍⁫⁮⁪⁪‬​⁬⁫‭⁭‏⁪‭‍⁮‌⁫⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(383917684U), UriKind.Relative);
            num1 = (int) num3 * -533692424 ^ 1552454435;
            continue;
          case 1:
            this._contentLoaded = true;
            num1 = -2138588369;
            continue;
          case 2:
            goto label_1;
          case 3:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * 531757718 ^ 10355616;
            continue;
          case 4:
            ButtonEditorView.\u206A‮‬‮‌‏‫‬‌‬‍​‌‎‍⁬‏‫⁫‪‎‭‪‬​⁮‮⁮​‏‬​‎‫⁫⁯‪‮‏‎‮((object) this, uri);
            num1 = (int) num3 * 1106051549 ^ -770303595;
            continue;
          case 5:
            int num4 = contentLoaded ? -456252025 : (num4 = -1080430111);
            int num5 = (int) num3 * 1707511763;
            num1 = num4 ^ num5;
            continue;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num3 * 527170913 ^ -847332730;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = 881922536;
      while (true)
      {
        int num2 = 1660390893;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            num1 = (int) num3 * -288391950 ^ 638681099;
            continue;
          case 1:
            num1 = (int) num3 * -1899874961 ^ 2040419671;
            continue;
          case 2:
            goto label_1;
          case 3:
            this._contentLoaded = true;
            num1 = 2100641941;
            continue;
          case 4:
            ButtonEditorView.\u206C‎‌‭⁯‎‏‭‎⁭‍‭⁭‫⁭‎‎‬⁮⁬‬‪⁯‍⁭⁭⁬‎⁭⁭​​⁯‬⁪‫‪‮‍‏‮((FrameworkElement) target, new RoutedEventHandler(this.Window_Loaded));
            num1 = 1255665589;
            continue;
          case 5:
            num1 = (int) num3 * 1303882837 ^ -1666589457;
            continue;
          case 6:
            num4 = connectionId;
            int num5 = num4 != 1 ? 2133766241 : (num5 = 1963077790);
            int num6 = (int) num3 * -2013579874;
            num1 = num5 ^ num6;
            continue;
          case 7:
            goto label_3;
          case 8:
            num1 = (int) num3 * -181338109 ^ 958445600;
            continue;
          case 9:
            this.MeetingIdRow = (RowDefinition) target;
            num1 = 2100641941;
            continue;
          case 10:
            int num7;
            num1 = num7 = num4 != 2 ? 1199971854 : (num7 = 444252321);
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    static object \u202A‏‍‍‫‎‫⁫‍⁯‫‏⁪‪‍⁪⁪⁮‍⁫⁫​‎‎‏‬⁬⁪‬‍⁭⁬​⁬‏⁯‮‫⁭‏‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u202B‏‪‍‍⁫‫⁭⁭​​‬⁭‮​⁮‏⁯‮‏⁪⁭⁯⁭​‮‍‭‌‎‏‍⁬⁮‌‌⁯‌‌⁬‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static void \u200E⁫⁬⁪⁭⁮‭‏‬‮⁯⁭⁭⁪⁯‏⁬⁬⁭⁯‮‏⁭​⁭‪‪‮‫⁪‏‌‬​‫‍⁭⁬⁬‮‮([In] Window obj0)
    {
      obj0.Close();
    }

    static WindowInteropHelper \u206B⁮‭⁭‮⁯​‍‍⁯‏‭‭‭‬⁪‎​‭⁪‮⁫⁬‎‮‪⁪‎‌⁭⁪‏⁯‭‫‪⁭⁯‍⁪‮([In] Window obj0)
    {
      return new WindowInteropHelper(obj0);
    }

    static IntPtr \u206C‍⁭⁪‪‫‌‪​‬⁫‍⁭‭⁯⁬​⁪⁮⁭‮‭⁬‎‭‫‏‭‬‬⁯‬‎‭‪​​‎‎‫‮([In] WindowInteropHelper obj0)
    {
      return obj0.Handle;
    }

    static Uri \u200C‏‏‏‏⁮‪‌⁭‏‏‭‌⁫⁬‌‫‎‬​‪‍⁫⁮⁪⁪‬​⁬⁫‭⁭‏⁪‭‍⁮‌⁫⁬‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u206A‮‬‮‌‏‫‬‌‬‍​‌‎‍⁬‏‫⁫‪‎‭‪‬​⁮‮⁮​‏‬​‎‫⁫⁯‪‮‏‎‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206C‎‌‭⁯‎‏‭‎⁭‍‭⁭‫⁭‎‎‬⁮⁬‬‪⁯‍⁭⁭⁬‎⁭⁭​​⁯‬⁪‫‪‮‍‏‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static Type \u206B‍⁮‌​⁭‏⁯⁪​‍⁯‎‎‏​⁬⁯‎⁯⁫⁮‭‮‍​‍​‬⁯⁯⁪‫⁫‪‫⁯‎⁭‬‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static PropertyMetadata \u202D⁪‭‏⁯‎⁫⁭‌‫⁯⁪‭⁭‭‏​‮‌‬‪‭‭‎‎⁯‭⁫‎⁭‌⁯‏‎‎‬‭⁪⁮‎‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new PropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u202A‍⁭‏‏⁬‏​‌‮⁭⁮⁭⁮⁭‌⁭⁪⁭‍⁪⁭⁫⁬‬​‍‍‫‮‍‬‌‪⁬⁬⁬‏‮‎‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.Register(obj0, obj1, obj2, obj3);
    }
  }
}
