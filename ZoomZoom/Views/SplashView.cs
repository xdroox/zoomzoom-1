// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.SplashView
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
using System.Windows.Threading;
using ZoomZoom.ViewModels;

namespace ZoomZoom.Views
{
  public class SplashView : Window, IComponentConnector
  {
    internal SplashView SplashScreen;
    internal Image LogoImage;
    private bool _contentLoaded;

    public SplashViewModel SplashViewModel
    {
      get
      {
        SplashViewModel splashViewModel = (SplashViewModel) SplashView.\u206B‏​‬‪⁪‌‭‫⁯⁫‮‭‌​⁫⁬‏‪‫⁭‬‭‏⁮⁭⁪‮⁮‬⁪‪‬⁫⁫⁯‬‪‫‍‮(SplashView.\u200F‫⁫‌⁬​​​‪‎⁭‮⁫‎⁮⁪​⁫​‪‮‌​‏⁪⁪‌⁬‎‪‎⁪⁭⁯⁮‮‫⁮‪⁯‮((FrameworkElement) this), (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2972724922U));
label_1:
        int num1 = -70184340;
        while (true)
        {
          int num2 = -689938306;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 657184733 ^ -1870771247;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return splashViewModel;
      }
    }

    public SplashView()
    {
label_1:
      int num1 = 213344210;
      while (true)
      {
        int num2 = 1092544242;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.InitializeComponent();
            num1 = (int) num3 * 826897785 ^ -2052260127;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -255449211 ^ 1444398804;
            continue;
          case 4:
            SplashView.\u206A⁬⁬‪‌⁫⁮​⁫‫‬‫⁪⁪‌‪‭⁭‍‌‍‍‫‍‫⁭‌‫⁬⁭⁮‌⁬⁬‫‮‭‬⁮‌‮((FrameworkElement) this, (object) this);
            num1 = (int) num3 * 307576577 ^ -1119284489;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    internal void UpdateSplashStatus(string status)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      SplashView.\u003C\u003Ec__DisplayClass3_0 cDisplayClass30 = new SplashView.\u003C\u003Ec__DisplayClass3_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.status = status;
label_1:
      int num1 = -1063931880;
      while (true)
      {
        int num2 = -1839610275;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            // ISSUE: method pointer
            SplashView.\u202D‬‌‫⁪‏‎‎‮‮‮‬⁮⁫⁭‮⁭‬⁯⁯⁫‪‏‪‍⁪⁭‮‏⁬⁫‮‭⁭‏⁬‪‪⁪‬‮(SplashView.\u206D‌‏⁯⁬⁮‭⁫‮‮‏​⁮⁮‮‎⁪‮‮‬‏​⁭⁯‮‪‍‭‭‬⁯‫⁪‭⁫‫‎⁯⁮⁭‮((DispatcherObject) SplashView.\u200F⁫‬‭⁮‌⁪‌‭⁬⁯‮‌‮⁮⁯‬‌⁬⁬⁮‮⁬‏⁮⁪‭‍‬‭‍‬⁬‮‏⁭‏‍⁮⁮‮()), new Action((object) cDisplayClass30, __methodptr(\u003CUpdateSplashStatus\u003Eb__0)));
            num1 = (int) num3 * 718197146 ^ 1438057809;
            continue;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1207914605 ^ 145942030;
            continue;
          case 3:
            num1 = (int) num3 * -1378419503 ^ 1610276843;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num4 = this.SplashViewModel == null ? 569532688 : (num4 = 336650591);
            int num5 = (int) num3 * -975700176;
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

    private void SplashScreen_Loaded(object sender, RoutedEventArgs e)
    {
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = 470260421;
      while (true)
      {
        int num2 = 426689275;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 1589475713 ^ -288206465;
            continue;
          case 1:
            num1 = (int) num3 * 1223414096 ^ 1080426450;
            continue;
          case 2:
            num1 = (int) num3 * -1598510923 ^ 2036918598;
            continue;
          case 3:
            this._contentLoaded = true;
            SplashView.\u200D⁭​⁮⁫‎‌⁯‏‎⁭​‎‬‌‫‍‎⁪⁬⁬‌‮‮⁫⁯‌⁭‎‬⁪‫​‮⁯‍⁯​‌‫‮((object) this, SplashView.\u202D⁯⁮‍‍​⁪‭‍‍‎⁯‌‏‪​‬‫‮⁭⁭‌⁬⁬‏‭‫⁬‌‭⁬‪‎‌⁫‎⁯‍‏‭‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1304298768U), UriKind.Relative));
            num1 = 828220630;
            continue;
          case 4:
            goto label_3;
          case 5:
            goto label_1;
          case 6:
            int num4 = !contentLoaded ? -1311332134 : (num4 = -1208753824);
            int num5 = (int) num3 * -195681937;
            num1 = num4 ^ num5;
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
      int num1 = connectionId;
      if (num1 == 1)
        goto label_9;
label_1:
      int num2 = 864780094;
label_2:
      while (true)
      {
        int num3 = 596788898;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 11U)
        {
          case 0:
            int num5;
            num2 = num5 = num1 != 2 ? 22423753 : (num5 = 82999605);
            continue;
          case 1:
            num2 = (int) num4 * 1610869453 ^ -1244316018;
            continue;
          case 2:
            this.LogoImage = (Image) target;
            num2 = 906896382;
            continue;
          case 3:
            goto label_1;
          case 4:
            num2 = (int) num4 * 130526487 ^ 2018145790;
            continue;
          case 5:
            num2 = (int) num4 * 467825648 ^ -528342789;
            continue;
          case 6:
            num2 = (int) num4 * -1746781066 ^ -201966350;
            continue;
          case 7:
            goto label_9;
          case 8:
            SplashView.\u206E‬‮‫‪‍⁫‫‎‭‭⁮‪⁮‬‬‮‭⁮‮‌‌⁮⁫‬‏‭‎‫⁭⁬⁯⁯‮​‌⁭​⁫‍‮((FrameworkElement) this.SplashScreen, new RoutedEventHandler(this.SplashScreen_Loaded));
            num2 = (int) num4 * 45413304 ^ 179486086;
            continue;
          case 9:
            this._contentLoaded = true;
            num2 = 1193442338;
            continue;
          case 10:
            goto label_3;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:
      return;
label_9:
      this.SplashScreen = (SplashView) target;
      num2 = 961689678;
      goto label_2;
    }

    static ResourceDictionary \u200F‫⁫‌⁬​​​‪‎⁭‮⁫‎⁮⁪​⁫​‪‮‌​‏⁪⁪‌⁬‎‪‎⁪⁭⁯⁮‮‫⁮‪⁯‮([In] FrameworkElement obj0)
    {
      return obj0.Resources;
    }

    static object \u206B‏​‬‪⁪‌‭‫⁯⁫‮‭‌​⁫⁬‏‪‫⁭‬‭‏⁮⁭⁪‮⁮‬⁪‪‬⁫⁫⁯‬‪‫‍‮([In] ResourceDictionary obj0, [In] object obj1)
    {
      return obj0[obj1];
    }

    static void \u206A⁬⁬‪‌⁫⁮​⁫‫‬‫⁪⁪‌‪‭⁭‍‌‍‍‫‍‫⁭‌‫⁬⁭⁮‌⁬⁬‫‮‭‬⁮‌‮([In] FrameworkElement obj0, [In] object obj1)
    {
      obj0.DataContext = obj1;
    }

    static Application \u200F⁫‬‭⁮‌⁪‌‭⁬⁯‮‌‮⁮⁯‬‌⁬⁬⁮‮⁬‏⁮⁪‭‍‬‭‍‬⁬‮‏⁭‏‍⁮⁮‮()
    {
      return Application.Current;
    }

    static Dispatcher \u206D‌‏⁯⁬⁮‭⁫‮‮‏​⁮⁮‮‎⁪‮‮‬‏​⁭⁯‮‪‍‭‭‬⁯‫⁪‭⁫‫‎⁯⁮⁭‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u202D‬‌‫⁪‏‎‎‮‮‮‬⁮⁫⁭‮⁭‬⁯⁯⁫‪‏‪‍⁪⁭‮‏⁬⁫‮‭⁭‏⁬‪‪⁪‬‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static Uri \u202D⁯⁮‍‍​⁪‭‍‍‎⁯‌‏‪​‬‫‮⁭⁭‌⁬⁬‏‭‫⁬‌‭⁬‪‎‌⁫‎⁯‍‏‭‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200D⁭​⁮⁫‎‌⁯‏‎⁭​‎‬‌‫‍‎⁪⁬⁬‌‮‮⁫⁯‌⁭‎‬⁪‫​‮⁯‍⁯​‌‫‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206E‬‮‫‪‍⁫‫‎‭‭⁮‪⁮‬‬‮‭⁮‮‌‌⁮⁫‬‏‭‎‫⁭⁬⁯⁯‮​‌⁭​⁫‍‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }
  }
}
