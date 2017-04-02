// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.CaptureWindowView
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ZoomZoom.Views
{
  public class CaptureWindowView : Window, IComponentConnector
  {
    private IntPtr _selectedHWnd = IntPtr.Zero;
    private IntPtr _hoveredHWnd = IntPtr.Zero;
    private System.Windows.Point _mouseDown;
    internal Rectangle WindowHighlight;
    private bool _contentLoaded;

    public IntPtr SelectedHWnd
    {
      get
      {
        return this._selectedHWnd;
      }
      private set
      {
label_1:
        int num1 = 389941334;
        while (true)
        {
          int num2 = 483665405;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this._selectedHWnd = value;
              num1 = (int) num3 * 654547550 ^ -116449285;
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

    public event EventHandler WindowSelected
    {
      add
      {
        EventHandler eventHandler = this.WindowSelected;
label_1:
        int num1 = 1059395686;
        while (true)
        {
          int num2 = 444553059;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler;
              num1 = 1243196700;
              continue;
            case 2:
              goto label_1;
            case 3:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.WindowSelected, (EventHandler) CaptureWindowView.\u200B‍‭⁪‎‍‌⁫⁪⁪⁭‏⁬⁮‮⁫‭⁮⁬⁮‮‏‮‌⁪‍⁫‭⁯​‪‫⁫‌‎‎‏⁪‪‌‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = eventHandler != comparand ? -320303244 : (num4 = -949676739);
              int num5 = (int) num3 * -242037778;
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
      remove
      {
        EventHandler eventHandler1 = this.WindowSelected;
label_1:
        int num1 = -19929363;
        while (true)
        {
          int num2 = -1428313247;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler2 = (EventHandler) CaptureWindowView.\u206A‪⁬​‮‏⁬⁪‮​​‬​‌‌‌‬‫⁪‮‎⁭⁫‌‏⁪‪​⁪⁮‬‭​‌‏‪⁯⁯‍‍‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1002621364 ^ -674929262;
              continue;
            case 1:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.WindowSelected, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? 278985017 : (num4 = 1702576226);
              int num5 = (int) num3 * 182503821;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              comparand = eventHandler1;
              num1 = -663589237;
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

    public event EventHandler Canceled
    {
      add
      {
        EventHandler eventHandler1 = this.Canceled;
label_1:
        int num1 = -811120653;
        while (true)
        {
          int num2 = -606813563;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = eventHandler1 == comparand ? -1506712121 : (num4 = -68259247);
              int num5 = (int) num3 * 206365874;
              num1 = num4 ^ num5;
              continue;
            case 2:
              comparand = eventHandler1;
              num1 = -1479837649;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.Canceled, eventHandler2, comparand);
              num1 = (int) num3 * -625167511 ^ -1624704669;
              continue;
            case 4:
              eventHandler2 = (EventHandler) CaptureWindowView.\u200B‍‭⁪‎‍‌⁫⁪⁪⁭‏⁬⁮‮⁫‭⁮⁬⁮‮‏‮‌⁪‍⁫‭⁯​‪‫⁫‌‎‎‏⁪‪‌‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1249549408 ^ -228000318;
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
      remove
      {
        EventHandler eventHandler = this.Canceled;
label_1:
        int num1 = -746701450;
        while (true)
        {
          int num2 = -426505823;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              int num4 = eventHandler == comparand ? 1535167797 : (num4 = 1485465092);
              int num5 = (int) num3 * -1814732043;
              num1 = num4 ^ num5;
              continue;
            case 1:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.Canceled, (EventHandler) CaptureWindowView.\u206A‪⁬​‮‏⁬⁪‮​​‬​‌‌‌‬‫⁪‮‎⁭⁫‌‏⁪‪​⁪⁮‬‭​‌‏‪⁯⁯‍‍‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * 610323834 ^ -1746823105;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              comparand = eventHandler;
              num1 = -1795724509;
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

    public CaptureWindowView()
    {
label_1:
      int num1 = 1092960904;
      while (true)
      {
        int num2 = 1661855928;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            this.\u200D‍‪‏‎‪⁮‪‎⁪‌‬⁯‍‌​‫⁯⁯‏​‍⁭⁯‮‮​‍⁯‪⁯‮‭‎⁫‎‫‏‪‫‮(new MouseEventHandler(this.CaptureWindow_MouseMove));
            num1 = (int) num3 * -1557537809 ^ -549277950;
            continue;
          case 1:
            num1 = (int) num3 * -228039966 ^ 1767315352;
            continue;
          case 2:
            num1 = (int) num3 * -614286041 ^ 1520681005;
            continue;
          case 3:
            this.\u202A⁪⁫‮‏​​⁪‏​‍​⁭‎‭‎‪⁪⁬⁪‏⁭‮‮‎⁮⁭‭⁯⁭‍⁬‭⁭​‏‏‬⁬‮‮(new MouseButtonEventHandler(this.CaptureWindow_MouseLeftButtonUp));
            num1 = (int) num3 * -1494632291 ^ 935665639;
            continue;
          case 4:
            num1 = (int) num3 * -1458629920 ^ 2069865096;
            continue;
          case 5:
            this.InitializeComponent();
            CaptureWindowView.\u206B‭‏‎​⁫‏‫⁮‪‮⁮​‭⁭‮‪⁬⁪⁯‬⁬⁯⁫‮‫‌‬⁭‎⁬⁪⁬⁭‎‭‏‭‮‬‮((Window) this, CaptureWindowView.\u200D⁯⁬‏⁪‫‬‍​​⁯⁭‍‪‮⁫‎‭⁭‭⁭‌⁯⁭‮⁭‫‎⁭‭⁭⁮⁭​‮⁭‍‎‫⁭‮());
            num1 = (int) num3 * 1025531256 ^ -1036197221;
            continue;
          case 6:
            num1 = (int) num3 * 1961843643 ^ 817697267;
            continue;
          case 7:
            num1 = (int) num3 * -2021506798 ^ 1321552913;
            continue;
          case 8:
            this.\u206B⁭‬‌‍⁬‏‮⁮‌‍​​‮‮‬⁭‌⁯‎⁯‬‫‎​‎‏​‪⁯‌⁯⁭‎‫‎​⁮‍‫‮(new KeyEventHandler(this.CaptureWindow_KeyUp));
            num1 = (int) num3 * 403369869 ^ 2113005993;
            continue;
          case 9:
            CaptureWindowView.\u200F‭⁮‏⁫‏⁬‎‫⁯‭‪‬​⁯‮⁫‮‮‮⁫‫​‌⁯‪‏⁬‬‬‭⁪​⁯‪‮‍⁯‬‍‮((Window) this, CaptureWindowView.\u206B⁯⁬‪⁮‬⁭‬‍‍⁭​⁪⁫⁯⁮‏‫‭⁫‪‎⁪⁪⁯‏⁮⁫⁫‪⁮‭⁪‎‎⁯​⁪‮‏‮());
            num1 = (int) num3 * 1194677325 ^ -1194867797;
            continue;
          case 10:
            this.\u206E‌‌​‎‬⁪​‫‏‫‬‪‎‏‫⁬‮⁫⁯‌‫‎⁬⁫‏⁮‮‪‮‍⁬⁪‭⁮‭‪‪‫‫‮(new MouseButtonEventHandler(this.CaptureWindow_MouseLeftButtonDown));
            num1 = (int) num3 * 258622296 ^ -1795709648;
            continue;
          case 11:
            this.\u206E⁪⁯‬⁭⁪⁭⁯⁬‏‌​‮‮⁯‫‭‪‫⁫⁭‮‌⁬⁭‌⁮⁯‍‫⁪‎​‏‬⁪‬⁯‫⁭‮(CaptureWindowView.\u200B⁫‍‪⁪⁮‫⁫‬⁪‫​‏⁬⁯‪⁪‍‏‍⁭⁯⁪‭‫‌⁬​⁬⁬⁬⁬⁪⁫‮‪⁯‏‭‌‮());
            num1 = (int) num3 * 1064096003 ^ 332101989;
            continue;
          case 12:
            goto label_3;
          case 13:
            CaptureWindowView.\u200B‍⁭⁭⁮‫‏‍‎⁫‌⁫⁯‫‮‍‪⁯‮⁫‪‬⁪‏⁮‌⁭‮‏‏‌‭​​⁫‮⁭‭‌⁭‮((Window) this, new CancelEventHandler(this.CaptureWindow_Closing));
            num1 = (int) num3 * 1751476921 ^ -1409751614;
            continue;
          case 14:
            this.\u206C⁭‌‫‪‍‮⁯‏‎‍⁪‌‌⁭‮‪⁭​‭‍⁪⁭⁪‮⁯‮⁫‫⁯⁬⁬‫‍⁮‫‏‮‫⁮‮(CaptureWindowView.\u202E⁮​‪⁫‎‫‍​⁫⁬⁭‪‮‭⁮‎​⁫⁪‭⁫⁭‍⁬⁮​‏⁫‏‬⁮‌‏⁭⁯​‪⁮⁫‮());
            num1 = (int) num3 * -2114346277 ^ 700420104;
            continue;
          case 15:
            num1 = (int) num3 * 937103840 ^ 1859936033;
            continue;
          case 16:
            num1 = (int) num3 * -1696292797 ^ -1923952227;
            continue;
          case 17:
            goto label_1;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_3:;
    }

    protected void OnWindowSelected()
    {
label_1:
      int num1 = 1959066916;
      while (true)
      {
        int num2 = 189130222;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            this.WindowSelected((object) this, EventArgs.Empty);
            num1 = (int) num3 * 424518495 ^ -1149443879;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            flag = this.WindowSelected != null;
            num1 = (int) num3 * 317558945 ^ -1282614733;
            continue;
          case 3:
            int num4 = !flag ? 753549780 : (num4 = 528933560);
            int num5 = (int) num3 * 41796999;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * 121114393 ^ -725716069;
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

    protected void OnCanceled()
    {
label_1:
      int num1 = 55623176;
      while (true)
      {
        int num2 = 921136674;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            this.Canceled((object) this, EventArgs.Empty);
            num1 = (int) num3 * 950006376 ^ 276669051;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            flag = this.Canceled != null;
            num1 = (int) num3 * -1801793547 ^ -1866459783;
            continue;
          case 2:
            int num4 = !flag ? 1418878021 : (num4 = 1215921553);
            int num5 = (int) num3 * 1370415046;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_1;
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

    private void CaptureWindow_Closing(object sender, CancelEventArgs e)
    {
label_1:
      int num1 = -1616622516;
      while (true)
      {
        int num2 = -2097564439;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            CaptureWindowView.\u200C‏‭‭‮‍​‮‌‫‪⁪⁪‮⁬‬‭⁯⁪‬⁯‌⁮‌​‌​⁫⁯‌⁪⁬‏‎​‏‌​⁪‏‮((UIElement) this.WindowHighlight, Visibility.Collapsed);
            num1 = (int) num3 * -1466711990 ^ -825335223;
            continue;
          case 2:
            num1 = (int) num3 * -2101589079 ^ -1555252964;
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

    private void CaptureWindow_KeyUp(object sender, KeyEventArgs e)
    {
      bool flag = CaptureWindowView.\u200B​‬⁭‏‬‪⁪⁫‬‬‬‭‬​⁮‮‬⁫‌‪⁭⁪⁭⁪⁯‬⁯‎⁮‎‫⁮‬‬‪⁮‎‬⁮‮(e) == Key.Escape;
label_1:
      int num1 = 971643120;
      while (true)
      {
        int num2 = 1730224431;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -1049466001 ^ -827402757;
            continue;
          case 1:
            num1 = (int) num3 * -735249035 ^ 1211478951;
            continue;
          case 2:
            this.OnCanceled();
            num1 = (int) num3 * 1165700501 ^ 1908899963;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_3;
          case 5:
            this.SelectedHWnd = IntPtr.Zero;
            num1 = (int) num3 * -1740959942 ^ -1064589345;
            continue;
          case 6:
            num1 = (int) num3 * -2139200945 ^ 233757597;
            continue;
          case 7:
            int num4 = flag ? 1626049046 : (num4 = 1559075907);
            int num5 = (int) num3 * -652074568;
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

    private void CaptureWindow_MouseMove(object sender, MouseEventArgs e)
    {
      CaptureWindowView.\u202D‫‍⁫‍⁬​⁯⁭⁪‫‫‭⁬‌‎⁬‌‏⁯‫⁪‍⁬‫‏⁬‏⁭⁫‏‭‫‬‍‬‭⁬‮⁯‮(new WaitCallback(this.HandleMouseMove), (object) e);
    }

    private void CaptureWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      this._mouseDown = CaptureWindowView.\u206C‬‬⁮‌⁪⁮⁭‬⁭⁯⁪⁬‪‏‏⁭⁭‬⁭‍‫‭⁯‎‌⁫‍‪⁮‭⁯‮‮​⁯‍⁪⁯⁫‮((MouseEventArgs) e, (IInputElement) this);
    }

    private void CaptureWindow_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
label_1:
      int num1 = 1594349441;
      while (true)
      {
        int num2 = 1226157421;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            CaptureWindowView.\u202D‫‍⁫‍⁬​⁯⁭⁪‫‫‭⁬‌‎⁬‌‏⁯‫⁪‍⁬‫‏⁬‏⁭⁫‏‭‫‬‍‬‭⁬‮⁯‮(new WaitCallback(this.HandleLeftButtonUp), (object) e);
            num1 = (int) num3 * -201014136 ^ -215819574;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void HandleMouseMove(object param)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CaptureWindowView.\u003C\u003Ec__DisplayClass20_0 cDisplayClass200 = new CaptureWindowView.\u003C\u003Ec__DisplayClass20_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass200.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass200.param = param;
label_1:
      int num1 = -755802641;
      while (true)
      {
        int num2 = -1651217542;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            // ISSUE: method pointer
            CaptureWindowView.\u202B​‎⁫⁫​⁫‍‍⁯‪‫‬‏⁭‍‮‌‎⁯‮‍‌⁭⁪‭⁪‍‫‭⁬‍‭⁯‍‪⁬‌⁬⁬‮(CaptureWindowView.\u206A‎‌⁮‌‬⁪‏‫⁭‬⁭‌​‫‭⁯‍‌⁫‫‪‭‍⁫‮⁭‌⁮​⁪⁫⁯‭‭‎‮⁬⁪⁪‮((DispatcherObject) CaptureWindowView.\u200F​‎‍⁫⁫‎‍⁪‏⁯‎⁭​‍‏‌‪⁬‌‌‭​⁬‪⁫⁮⁪‮⁫‫⁫‪​⁮⁯‪⁫‮‍‮()), new Action((object) cDisplayClass200, __methodptr(\u003CHandleMouseMove\u003Eb__0)));
            num1 = (int) num3 * 1872125221 ^ -807515252;
            continue;
          case 1:
            num1 = (int) num3 * -1715926269 ^ 251208577;
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

    private void HandleLeftButtonUp(object parameter)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CaptureWindowView.\u003C\u003Ec__DisplayClass21_0 cDisplayClass210 = new CaptureWindowView.\u003C\u003Ec__DisplayClass21_0();
label_1:
      int num1 = 1708173354;
      while (true)
      {
        int num2 = 1479348087;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            // ISSUE: method pointer
            CaptureWindowView.\u202B​‎⁫⁫​⁫‍‍⁯‪‫‬‏⁭‍‮‌‎⁯‮‍‌⁭⁪‭⁪‍‫‭⁬‍‭⁯‍‪⁬‌⁬⁬‮(CaptureWindowView.\u206A‎‌⁮‌‬⁪‏‫⁭‬⁭‌​‫‭⁯‍‌⁫‫‪‭‍⁫‮⁭‌⁮​⁪⁫⁯‭‭‎‮⁬⁪⁪‮((DispatcherObject) CaptureWindowView.\u200F​‎‍⁫⁫‎‍⁪‏⁯‎⁭​‍‏‌‪⁬‌‌‭​⁬‪⁫⁮⁪‮⁫‫⁫‪​⁮⁯‪⁫‮‍‮()), new Action((object) cDisplayClass210, __methodptr(\u003CHandleLeftButtonUp\u003Eb__0)));
            num1 = (int) num3 * 522290867 ^ -1880917061;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass210.parameter = parameter;
            num1 = (int) num3 * -1347215131 ^ 1391750522;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass210.\u003C\u003E4__this = this;
            num1 = (int) num3 * 1581236680 ^ -1998058136;
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
      int num1 = 1576123462;
      while (true)
      {
        int num2 = 411956742;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this._contentLoaded = true;
            num1 = 1816984291;
            continue;
          case 1:
            num1 = (int) num3 * -1422499176 ^ -1366300774;
            continue;
          case 2:
            CaptureWindowView.\u200F‭‮‪‌‌⁭⁪‪⁭‎‫‪‏‎‏‌‬⁮‭⁫‪⁫⁭‌⁭⁯‌‌‌⁬‭‍‮⁬‬‮⁬‮⁬‮((object) this, CaptureWindowView.\u202D‎⁬‌‫‬‭‬⁪⁪‮‏⁪‌‫‌⁪​‭⁯​‪‪⁪‬⁮‫​‌⁪⁮‮⁬‍‫⁪⁫‎⁮‍‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(97883711U), UriKind.Relative));
            num1 = (int) num3 * -382243662 ^ -934462616;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_1;
          case 5:
            int num4 = this._contentLoaded ? -1025493664 : (num4 = -241440543);
            int num5 = (int) num3 * -1562281827;
            num1 = num4 ^ num5;
            continue;
          case 6:
            num1 = (int) num3 * 1802801519 ^ -1754792577;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      if (connectionId == 1)
        goto label_7;
label_1:
      int num1 = 946327227;
label_2:
      while (true)
      {
        int num2 = 1801421406;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -511161020 ^ 1968124659;
            continue;
          case 2:
            goto label_7;
          case 3:
            num1 = (int) num3 * -963369581 ^ 830687213;
            continue;
          case 4:
            this._contentLoaded = true;
            num1 = 119814535;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:
      return;
label_7:
      this.WindowHighlight = (Rectangle) target;
      num1 = 222583187;
      goto label_2;
    }

    static Delegate \u200B‍‭⁪‎‍‌⁫⁪⁪⁭‏⁬⁮‮⁫‭⁮⁬⁮‮‏‮‌⁪‍⁫‭⁯​‪‫⁫‌‎‎‏⁪‪‌‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u206A‪⁬​‮‏⁬⁪‮​​‬​‌‌‌‬‫⁪‮‎⁭⁫‌‏⁪‪​⁪⁮‬‭​‌‏‪⁯⁯‍‍‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static double \u200D⁯⁬‏⁪‫‬‍​​⁯⁭‍‪‮⁫‎‭⁭‭⁭‌⁯⁭‮⁭‫‎⁭‭⁭⁮⁭​‮⁭‍‎‫⁭‮()
    {
      return SystemParameters.VirtualScreenLeft;
    }

    static void \u206B‭‏‎​⁫‏‫⁮‪‮⁮​‭⁭‮‪⁬⁪⁯‬⁬⁯⁫‮‫‌‬⁭‎⁬⁪⁬⁭‎‭‏‭‮‬‮([In] Window obj0, [In] double obj1)
    {
      obj0.Left = obj1;
    }

    static double \u206B⁯⁬‪⁮‬⁭‬‍‍⁭​⁪⁫⁯⁮‏‫‭⁫‪‎⁪⁪⁯‏⁮⁫⁫‪⁮‭⁪‎‎⁯​⁪‮‏‮()
    {
      return SystemParameters.VirtualScreenTop;
    }

    static void \u200F‭⁮‏⁫‏⁬‎‫⁯‭‪‬​⁯‮⁫‮‮‮⁫‫​‌⁯‪‏⁬‬‬‭⁪​⁯‪‮‍⁯‬‍‮([In] Window obj0, [In] double obj1)
    {
      obj0.Top = obj1;
    }

    static double \u202E⁮​‪⁫‎‫‍​⁫⁬⁭‪‮‭⁮‎​⁫⁪‭⁫⁭‍⁬⁮​‏⁫‏‬⁮‌‏⁭⁯​‪⁮⁫‮()
    {
      return SystemParameters.VirtualScreenWidth;
    }

    void \u206C⁭‌‫‪‍‮⁯‏‎‍⁪‌‌⁭‮‪⁭​‭‍⁪⁭⁪‮⁯‮⁫‫⁯⁬⁬‫‍⁮‫‏‮‫⁮‮([In] double obj0)
    {
      this.Width = obj0;
    }

    static double \u200B⁫‍‪⁪⁮‫⁫‬⁪‫​‏⁬⁯‪⁪‍‏‍⁭⁯⁪‭‫‌⁬​⁬⁬⁬⁬⁪⁫‮‪⁯‏‭‌‮()
    {
      return SystemParameters.VirtualScreenHeight;
    }

    void \u206E⁪⁯‬⁭⁪⁭⁯⁬‏‌​‮‮⁯‫‭‪‫⁫⁭‮‌⁬⁭‌⁮⁯‍‫⁪‎​‏‬⁪‬⁯‫⁭‮([In] double obj0)
    {
      this.Height = obj0;
    }

    void \u202A⁪⁫‮‏​​⁪‏​‍​⁭‎‭‎‪⁪⁬⁪‏⁭‮‮‎⁮⁭‭⁯⁭‍⁬‭⁭​‏‏‬⁬‮‮([In] MouseButtonEventHandler obj0)
    {
      this.MouseLeftButtonUp += obj0;
    }

    void \u206E‌‌​‎‬⁪​‫‏‫‬‪‎‏‫⁬‮⁫⁯‌‫‎⁬⁫‏⁮‮‪‮‍⁬⁪‭⁮‭‪‪‫‫‮([In] MouseButtonEventHandler obj0)
    {
      this.MouseLeftButtonDown += obj0;
    }

    void \u200D‍‪‏‎‪⁮‪‎⁪‌‬⁯‍‌​‫⁯⁯‏​‍⁭⁯‮‮​‍⁯‪⁯‮‭‎⁫‎‫‏‪‫‮([In] MouseEventHandler obj0)
    {
      this.MouseMove += obj0;
    }

    void \u206B⁭‬‌‍⁬‏‮⁮‌‍​​‮‮‬⁭‌⁯‎⁯‬‫‎​‎‏​‪⁯‌⁯⁭‎‫‎​⁮‍‫‮([In] KeyEventHandler obj0)
    {
      this.KeyUp += obj0;
    }

    static void \u200B‍⁭⁭⁮‫‏‍‎⁫‌⁫⁯‫‮‍‪⁯‮⁫‪‬⁪‏⁮‌⁭‮‏‏‌‭​​⁫‮⁭‭‌⁭‮([In] Window obj0, [In] CancelEventHandler obj1)
    {
      obj0.Closing += obj1;
    }

    static void \u200C‏‭‭‮‍​‮‌‫‪⁪⁪‮⁬‬‭⁯⁪‬⁯‌⁮‌​‌​⁫⁯‌⁪⁬‏‎​‏‌​⁪‏‮([In] UIElement obj0, [In] Visibility obj1)
    {
      obj0.Visibility = obj1;
    }

    static Key \u200B​‬⁭‏‬‪⁪⁫‬‬‬‭‬​⁮‮‬⁫‌‪⁭⁪⁭⁪⁯‬⁯‎⁮‎‫⁮‬‬‪⁮‎‬⁮‮([In] KeyEventArgs obj0)
    {
      return obj0.Key;
    }

    static bool \u202D‫‍⁫‍⁬​⁯⁭⁪‫‫‭⁬‌‎⁬‌‏⁯‫⁪‍⁬‫‏⁬‏⁭⁫‏‭‫‬‍‬‭⁬‮⁯‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static System.Windows.Point \u206C‬‬⁮‌⁪⁮⁭‬⁭⁯⁪⁬‪‏‏⁭⁭‬⁭‍‫‭⁯‎‌⁫‍‪⁮‭⁯‮‮​⁯‍⁪⁯⁫‮([In] MouseEventArgs obj0, [In] IInputElement obj1)
    {
      return obj0.GetPosition(obj1);
    }

    static Application \u200F​‎‍⁫⁫‎‍⁪‏⁯‎⁭​‍‏‌‪⁬‌‌‭​⁬‪⁫⁮⁪‮⁫‫⁫‪​⁮⁯‪⁫‮‍‮()
    {
      return Application.Current;
    }

    static Dispatcher \u206A‎‌⁮‌‬⁪‏‫⁭‬⁭‌​‫‭⁯‍‌⁫‫‪‭‍⁫‮⁭‌⁮​⁪⁫⁯‭‭‎‮⁬⁪⁪‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u202B​‎⁫⁫​⁫‍‍⁯‪‫‬‏⁭‍‮‌‎⁯‮‍‌⁭⁪‭⁪‍‫‭⁬‍‭⁯‍‪⁬‌⁬⁬‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static Uri \u202D‎⁬‌‫‬‭‬⁪⁪‮‏⁪‌‫‌⁪​‭⁯​‪‪⁪‬⁮‫​‌⁪⁮‮⁬‍‫⁪⁫‎⁮‍‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200F‭‮‪‌‌⁭⁪‪⁭‎‫‪‏‎‏‌‬⁮‭⁫‪⁫⁭‌⁭⁯‌‌‌⁬‭‍‮⁬‬‮⁬‮⁬‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }
  }
}
