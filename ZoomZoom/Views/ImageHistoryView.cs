// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.ImageHistoryView
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.Windows.Markup;
using Telerik.Windows.Controls;

namespace ZoomZoom.Views
{
  public class ImageHistoryView : Window, IComponentConnector
  {
    protected readonly ILog log = ImageHistoryView.\u202E​⁬‫‪‪‪‭⁫⁬⁪‍⁮⁪‌⁮⁯⁯‍⁮‍⁪‪‏⁬‭⁫‮‌⁯‏‌‫⁪⁭‭​‏‏⁫‮(ImageHistoryView.\u200C⁮‫⁫‎‏‎‏‍‌‎‭⁪⁫‮‬⁮⁪‎‮​‌‮⁭‏‬⁬⁪⁫‪‍⁯‌⁬​⁫⁫⁪‫‭‮((MemberInfo) ImageHistoryView.\u202B‪⁮‬⁯‏‬​⁮⁮‏‌⁯⁮‌⁬‫‎‍‫⁪‪⁪‫⁯‫‭⁫​⁬⁭‎‭⁭⁮⁪‍⁮‪‏‮()));
    internal Grid LayoutRoot;
    internal ComboBox cbImageTypeFilter;
    internal CheckBox cbRequiresId;
    internal ListBox lImages;
    internal ComboBox cmbImageType;
    internal TextBlock txtDate;
    internal RadComboBox cbImageUser;
    internal Image Image;
    private bool _contentLoaded;

    public ImageHistoryView()
    {
label_1:
      int num1 = 1601801204;
      while (true)
      {
        int num2 = 59047563;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.InitializeComponent();
            num1 = (int) num3 * 1249973254 ^ 717970255;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 1378414148 ^ 1588363766;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      if (Engine.Instance.WindowManager == null)
        return;
label_1:
      int num1 = 408426111;
      while (true)
      {
        int num2 = 1835089745;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_7;
          case 1:
            num1 = (int) num3 * -1938742782 ^ -532240805;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -803591237 ^ 317952740;
            continue;
          case 4:
            Engine.Instance.WindowManager.RegisterWindow(ImageHistoryView.\u200D‪‏⁯⁭‍⁮⁮⁮⁮‪‪⁭‭‪⁭‏⁬‭⁬‮​⁯⁫‍‭⁪‫‮‌⁫‮‪‪⁮‭‍⁭‍‮(ImageHistoryView.\u206A⁭‬‫⁮⁭‎​⁫‭⁯⁫⁯​‎‫​‌‭​‏⁭⁬‎⁬‭⁬⁫⁬‫⁪‏⁯⁫⁮‮‌⁫‪‫‮((Window) this)), ZoomWindowType.ImageHistoryView);
            num1 = (int) num3 * 1203054225 ^ -1042488652;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_7:;
    }

    private void Window_Closing(object sender, CancelEventArgs e)
    {
      bool flag = ImageHistoryView.\u202D⁭⁪‫⁪‭‎‎‪‎⁫‫⁮‌‍⁯‮‍‮‌​⁮⁯‏⁬‭⁫‭‭‭​⁪⁬‫⁪‎⁫‏‏‮‮((UIElement) this) == Visibility.Visible;
label_1:
      int num1 = -1685975323;
      while (true)
      {
        int num2 = -497738880;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = flag ? -1877359575 : (num4 = -339763686);
            int num5 = (int) num3 * -1506501509;
            num1 = num4 ^ num5;
            continue;
          case 2:
            ImageHistoryView.\u202A‫‌‏‌‪‫⁬⁭⁬‌⁫⁫⁮⁬​‭‮​⁬‎⁪⁬​‏‎⁬‫⁪​‍‍⁪‬‌⁮‍⁪‌‫‮(e, true);
            num1 = (int) num3 * -62315190 ^ 290289279;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -1273903916 ^ -2079918267;
            continue;
          case 5:
            num1 = (int) num3 * 181962126 ^ 1399426960;
            continue;
          case 6:
            ImageHistoryView.\u202E⁫⁪⁫‭‏⁪‌‎⁫⁬‌⁮‎⁪‌‫‮‎​​‏⁬⁭‌‫⁯⁮⁮‏‭‌‬⁮‮‬‌​⁯⁯‮((Window) this);
            num1 = (int) num3 * -658758962 ^ -1789320681;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private void lImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = 1761003733;
      while (true)
      {
        int num2 = 1600066515;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this._contentLoaded = true;
            ImageHistoryView.\u206F‍‌‎⁫⁯‮⁯​‪⁪⁫⁬‌‮‪⁯​⁪​‏​‍‬‭⁭⁫⁯‭‭‭‫⁪⁬‪‪‏⁯‪‮‮((object) this, ImageHistoryView.\u206C‏⁫⁫‏‎⁫‌‭⁬‏‮⁯‬​‌‬‮‫‏‪‪⁮‫⁮‍⁪‮‫⁬‫‫‏⁬‏‭‏‮‮‮‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1624884134U), UriKind.Relative));
            num1 = 1840112282;
            continue;
          case 1:
            int num4 = contentLoaded ? -1735799489 : (num4 = -217864309);
            int num5 = (int) num3 * 138598030;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * 1743896191 ^ 1339221;
            continue;
          case 3:
            num1 = (int) num3 * -1439166631 ^ 405254711;
            continue;
          case 4:
            num1 = (int) num3 * 1237717854 ^ 1868942910;
            continue;
          case 5:
            goto label_3;
          case 6:
            goto label_1;
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
      int num1 = -1349174230;
      while (true)
      {
        int num2 = -629104565;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            num1 = (int) num3 * 1921382180 ^ -1148227057;
            continue;
          case 1:
            num4 = connectionId;
            num1 = (int) num3 * 1580455093 ^ -286611504;
            continue;
          case 2:
            num1 = (int) num3 * 1576843572 ^ 1133551399;
            continue;
          case 3:
            this._contentLoaded = true;
            num1 = -1231385585;
            continue;
          case 4:
            ImageHistoryView.\u202E‌⁭‮‬‏⁫‮‎‏‏​‪⁪⁯‫⁫⁮‎​⁬⁯‬‮‮⁬⁪⁮‭‏‭⁫‫⁫⁫‏‏‮⁪⁭‮((Window) target, new CancelEventHandler(this.Window_Closing));
            num1 = (int) num3 * 1737556690 ^ -101383921;
            continue;
          case 5:
            num1 = (int) num3 * -1654468497 ^ -286961748;
            continue;
          case 6:
            num1 = (int) num3 * 1887701123 ^ 50789273;
            continue;
          case 7:
label_12:
            this.cbRequiresId = (CheckBox) target;
            num1 = -455994810;
            continue;
          case 8:
label_17:
            this.Image = (Image) target;
            num1 = -1231385585;
            continue;
          case 9:
            num1 = (int) num3 * -928060998 ^ 1735812410;
            continue;
          case 10:
label_18:
            this.txtDate = (TextBlock) target;
            num1 = -1430504839;
            continue;
          case 11:
label_20:
            this.lImages = (ListBox) target;
            ImageHistoryView.\u206A​⁭‭‏‭‌⁮‎⁪‍⁪⁪‭⁫‮⁬⁬⁭‪⁮​⁪‏‬⁮‏‭‏‏‌‭‏⁪‭‪‪‮⁪‫‮((Selector) this.lImages, new SelectionChangedEventHandler(this.lImages_SelectionChanged));
            num1 = -1231385585;
            continue;
          case 12:
label_16:
            this.cbImageTypeFilter = (ComboBox) target;
            num1 = -1718918983;
            continue;
          case 13:
label_13:
            this.cbImageUser = (RadComboBox) target;
            num1 = -238820405;
            continue;
          case 14:
            switch (num4)
            {
              case 1:
                goto label_22;
              case 2:
                goto label_7;
              case 3:
                goto label_16;
              case 4:
                goto label_12;
              case 5:
                goto label_20;
              case 6:
                goto label_8;
              case 7:
                goto label_18;
              case 8:
                goto label_13;
              case 9:
                goto label_17;
              default:
                num1 = (int) num3 * 1443926144 ^ -1479294394;
                continue;
            }
          case 15:
            goto label_1;
          case 16:
            goto label_3;
          case 17:
label_22:
            ImageHistoryView.\u200D‫‎⁪⁬⁪⁮‪⁯⁪‫​‪‎‍‪⁪‪​‬‬‫​⁮⁯⁪⁭‌⁬‭‬‭‌‪⁫‪‮⁫‫‬‮((FrameworkElement) target, new RoutedEventHandler(this.Window_Loaded));
            num1 = -1098194229;
            continue;
          case 18:
label_7:
            this.LayoutRoot = (Grid) target;
            num1 = -1231385585;
            continue;
          case 19:
label_8:
            this.cmbImageType = (ComboBox) target;
            num1 = -1231385585;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return;
label_3:;
    }

    static MethodBase \u202B‪⁮‬⁯‏‬​⁮⁮‏‌⁯⁮‌⁬‫‎‍‫⁪‪⁪‫⁯‫‭⁫​⁬⁭‎‭⁭⁮⁪‍⁮‪‏‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200C⁮‫⁫‎‏‎‏‍‌‎‭⁪⁫‮‬⁮⁪‎‮​‌‮⁭‏‬⁬⁪⁫‪‍⁯‌⁬​⁫⁫⁪‫‭‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202E​⁬‫‪‪‪‭⁫⁬⁪‍⁮⁪‌⁮⁯⁯‍⁮‍⁪‪‏⁬‭⁫‮‌⁯‏‌‫⁪⁭‭​‏‏⁫‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static WindowInteropHelper \u206A⁭‬‫⁮⁭‎​⁫‭⁯⁫⁯​‎‫​‌‭​‏⁭⁬‎⁬‭⁬⁫⁬‫⁪‏⁯⁫⁮‮‌⁫‪‫‮([In] Window obj0)
    {
      return new WindowInteropHelper(obj0);
    }

    static IntPtr \u200D‪‏⁯⁭‍⁮⁮⁮⁮‪‪⁭‭‪⁭‏⁬‭⁬‮​⁯⁫‍‭⁪‫‮‌⁫‮‪‪⁮‭‍⁭‍‮([In] WindowInteropHelper obj0)
    {
      return obj0.Handle;
    }

    static Visibility \u202D⁭⁪‫⁪‭‎‎‪‎⁫‫⁮‌‍⁯‮‍‮‌​⁮⁯‏⁬‭⁫‭‭‭​⁪⁬‫⁪‎⁫‏‏‮‮([In] UIElement obj0)
    {
      return obj0.Visibility;
    }

    static void \u202E⁫⁪⁫‭‏⁪‌‎⁫⁬‌⁮‎⁪‌‫‮‎​​‏⁬⁭‌‫⁯⁮⁮‏‭‌‬⁮‮‬‌​⁯⁯‮([In] Window obj0)
    {
      obj0.Hide();
    }

    static void \u202A‫‌‏‌‪‫⁬⁭⁬‌⁫⁫⁮⁬​‭‮​⁬‎⁪⁬​‏‎⁬‫⁪​‍‍⁪‬‌⁮‍⁪‌‫‮([In] CancelEventArgs obj0, [In] bool obj1)
    {
      obj0.Cancel = obj1;
    }

    static Uri \u206C‏⁫⁫‏‎⁫‌‭⁬‏‮⁯‬​‌‬‮‫‏‪‪⁮‫⁮‍⁪‮‫⁬‫‫‏⁬‏‭‏‮‮‮‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u206F‍‌‎⁫⁯‮⁯​‪⁪⁫⁬‌‮‪⁯​⁪​‏​‍‬‭⁭⁫⁯‭‭‭‫⁪⁬‪‪‏⁯‪‮‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u200D‫‎⁪⁬⁪⁮‪⁯⁪‫​‪‎‍‪⁪‪​‬‬‫​⁮⁯⁪⁭‌⁬‭‬‭‌‪⁫‪‮⁫‫‬‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u202E‌⁭‮‬‏⁫‮‎‏‏​‪⁪⁯‫⁫⁮‎​⁬⁯‬‮‮⁬⁪⁮‭‏‭⁫‫⁫⁫‏‏‮⁪⁭‮([In] Window obj0, [In] CancelEventHandler obj1)
    {
      obj0.Closing += obj1;
    }

    static void \u206A​⁭‭‏‭‌⁮‎⁪‍⁪⁪‭⁫‮⁬⁬⁭‪⁮​⁪‏‬⁮‏‭‏‏‌‭‏⁪‭‪‪‮⁪‫‮([In] Selector obj0, [In] SelectionChangedEventHandler obj1)
    {
      obj0.SelectionChanged += obj1;
    }
  }
}
