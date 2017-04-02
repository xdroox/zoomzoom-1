// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WindowHighlight
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace ZoomZoom
{
  public class WindowHighlight : Window, IComponentConnector
  {
    private static IntPtr targetHandle;
    private static Rectangle targetRectangle;
    internal WindowHighlight GlowWindow;
    private bool _contentLoaded;

    public IntPtr TargetHandle
    {
      get
      {
label_1:
        int num1 = -263101685;
        IntPtr targetHandle;
        while (true)
        {
          int num2 = -997448862;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              targetHandle = WindowHighlight.targetHandle;
              num1 = (int) num3 * -2088012432 ^ 794958930;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return targetHandle;
      }
      set
      {
label_1:
        int num1 = 496960144;
        while (true)
        {
          int num2 = 1072490244;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              WindowHighlight.targetHandle = value;
              num1 = (int) num3 * -1058008233 ^ -852278494;
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

    public Rectangle TargetRectangle
    {
      get
      {
        Rectangle targetRectangle = WindowHighlight.targetRectangle;
label_1:
        int num1 = 1344262022;
        while (true)
        {
          int num2 = 569009801;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 149943873 ^ 1412368787;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return targetRectangle;
      }
      set
      {
        WindowHighlight.targetRectangle = value;
      }
    }

    public WindowHighlight(IntPtr targetHandle)
    {
label_1:
      int num1 = 1534038656;
      while (true)
      {
        int num2 = 1634656747;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            this.TargetRectangle = WindowHelper.GetWindowRectangle(targetHandle);
            num1 = (int) num3 * 2052236516 ^ -652523869;
            continue;
          case 1:
            this.InitializeComponent();
            num1 = (int) num3 * -1921967330 ^ 1350398825;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            this.TargetHandle = targetHandle;
            num1 = (int) num3 * -1278321095 ^ -2098343855;
            continue;
          case 5:
            num1 = (int) num3 * 720627093 ^ 60212827;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    public WindowHighlight(Rectangle region)
    {
      this.InitializeComponent();
      this.TargetHandle = IntPtr.Zero;
      this.TargetRectangle = region;
    }

    private void GlowWindow_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = 2069071848;
      while (true)
      {
        int num2 = 931363870;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            WindowHighlight.\u206A‎‫⁭‭‏‭⁬‬‏⁪⁮‬⁬‏‭⁫‎​⁯‬​​⁬⁬‍‮⁯‬⁮‌⁬‫‮‫⁬‌‫‫⁭‮(new WaitCallback(this.UpdateLocation));
            num1 = (int) num3 * 1042012633 ^ 1093735854;
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

    public void UpdateLocationQueued()
    {
label_1:
      int num1 = 474112070;
      while (true)
      {
        int num2 = 1342651949;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            WindowHighlight.\u206A‎‫⁭‭‏‭⁬‬‏⁪⁮‬⁬‏‭⁫‎​⁯‬​​⁬⁬‍‮⁯‬⁮‌⁬‫‮‫⁬‌‫‫⁭‮(new WaitCallback(this.UpdateLocation));
            num1 = (int) num3 * -1387684070 ^ 1508791154;
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

    public void UpdateLocation(object state)
    {
      IntPtr targetHandle = this.TargetHandle;
label_1:
      int num1 = 1811097696;
      while (true)
      {
        int num2 = 456491524;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            int num4 = !flag ? -1108720755 : (num4 = -1695850940);
            int num5 = (int) num3 * -1399498185;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * 2055000319 ^ -935656936;
            continue;
          case 3:
            // ISSUE: method pointer
            Application.Current.Dispatcher.Invoke(new Action((object) this, __methodptr(\u003CUpdateLocation\u003Eb__13_0)));
            num1 = (int) num3 * -86681753 ^ -1914264913;
            continue;
          case 4:
            flag = !targetHandle.Equals((object) IntPtr.Zero);
            num1 = (int) num3 * 664293639 ^ 1687271599;
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

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
label_1:
      int num1 = 118828209;
      while (true)
      {
        int num2 = 629016968;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -1883724169 ^ 1321404719;
            continue;
          case 1:
            int num4 = !this._contentLoaded ? -286426288 : (num4 = -1912839967);
            int num5 = (int) num3 * 1172296938;
            num1 = num4 ^ num5;
            continue;
          case 2:
            this._contentLoaded = true;
            num1 = 1760468148;
            continue;
          case 3:
            num1 = (int) num3 * 1079030370 ^ 1984871862;
            continue;
          case 4:
            WindowHighlight.\u202E‌⁭‫⁭‮‎​‍⁪‬‏⁫⁪‪⁮⁪⁫⁬‭‫‎‮⁯‏⁬⁭‎⁭‬​​‪⁬‏⁪​‌⁭⁯‮((object) this, WindowHighlight.\u206A⁪‮‍⁬⁬⁭‫‬‌‏‏‭⁮⁯‌​‬⁪‍⁬⁮‭‏‌‮⁫‭⁭‏‫⁫‍‭‌​‌⁫⁮‎‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1172529358U), UriKind.Relative));
            num1 = (int) num3 * 291332211 ^ 698275810;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * -1751762452 ^ -851716977;
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
      int num1 = -82814837;
      while (true)
      {
        int num2 = -727618329;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this._contentLoaded = true;
            num1 = -1723314719;
            continue;
          case 1:
            num1 = (int) num3 * -1409728411 ^ -1809886551;
            continue;
          case 2:
            goto label_3;
          case 3:
            int num4 = connectionId != 1 ? 1152400389 : (num4 = 1014330979);
            int num5 = (int) num3 * -959692353;
            num1 = num4 ^ num5;
            continue;
          case 4:
            this.GlowWindow = (WindowHighlight) target;
            WindowHighlight.\u206A‮⁯‏‎⁮​‮‫‪‭⁯‎‫⁮⁮​⁯‍⁫‬‮⁬⁪​‬‪‫⁪‫⁬‮⁭⁭‏⁭⁭‮⁭⁬‮((FrameworkElement) this.GlowWindow, new RoutedEventHandler(this.GlowWindow_Loaded));
            num1 = -2061615652;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * 842596778 ^ 1036542415;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    static bool \u206A‎‫⁭‭‏‭⁬‬‏⁪⁮‬⁬‏‭⁫‎​⁯‬​​⁬⁬‍‮⁯‬⁮‌⁬‫‮‫⁬‌‫‫⁭‮([In] WaitCallback obj0)
    {
      return ThreadPool.QueueUserWorkItem(obj0);
    }

    static Uri \u206A⁪‮‍⁬⁬⁭‫‬‌‏‏‭⁮⁯‌​‬⁪‍⁬⁮‭‏‌‮⁫‭⁭‏‫⁫‍‭‌​‌⁫⁮‎‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u202E‌⁭‫⁭‮‎​‍⁪‬‏⁫⁪‪⁮⁪⁫⁬‭‫‎‮⁯‏⁬⁭‎⁭‬​​‪⁬‏⁪​‌⁭⁯‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206A‮⁯‏‎⁮​‮‫‪‭⁯‎‫⁮⁮​⁯‍⁫‬‮⁬⁪​‬‪‫⁪‫⁬‮⁭⁭‏⁭⁭‮⁭⁬‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    private delegate void Execute();
  }
}
