// Decompiled with JetBrains decompiler
// Type: ZoomZoom.App
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Threading;
using log4net;
using log4net.Config;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using ZoomZoom.Models.Core;
using ZoomZoom.Views;

namespace ZoomZoom
{
  public class App : Application
  {
    private static readonly ILog log = App.\u206E‍‬‭‍‮‬​‌‍‏‎‫​​​‌⁮⁮⁯⁫‬‏⁮‍⁬‎‍⁪⁯‍⁪‭⁯‬‍‎⁪‌‍‮(App.\u206B‫⁬‎⁮⁫⁪‫⁫⁬⁪‍‭‍⁫⁫‬‭⁮‮​⁭⁫‎‍⁪‮⁬⁪‮⁯‬⁯⁪⁭⁫⁯‫‬‮‮((MemberInfo) App.\u206F⁭‫⁫⁮‎‬⁫⁫⁭‏​‬‫‭‮⁮⁬‭⁫⁮‭‪⁯‭‪⁪​‭‭⁬‏‮⁮⁭‏⁯‭‍‫‮()));
    private bool messageBoxDisplayed = false;
    private Engine engine = (Engine) null;
    private SplashView splashView = (SplashView) null;
    private EngineView engineView = (EngineView) null;
    private TrackingWindow trackingWindow = (TrackingWindow) null;
    private WindowSelector selectorWindow = (WindowSelector) null;
    private CancellationTokenSource tokenSource = (CancellationTokenSource) null;
    private List<Window> applicationWindows = new List<Window>();
    private const string FATAL_ERROR_LOG = "C:\\zoomZoom\\fatalError.txt";
    private static readonly object applicationLock;
    private Thread engineThread;
    private Thread trackingThread;
    private Thread selectorThread;
    private CancellationToken token;
    private bool _contentLoaded;

    public Engine Engine
    {
      get
      {
        return this.engine;
      }
      internal set
      {
label_1:
        int num1 = -2086709943;
        while (true)
        {
          int num2 = -1923159559;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.engine = value;
              num1 = (int) num3 * 1171061402 ^ 1172083205;
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

    public CancellationToken Token
    {
      get
      {
label_1:
        int num1 = -1902074233;
        CancellationToken token;
        while (true)
        {
          int num2 = -966193586;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              token = this.token;
              num1 = (int) num3 * 1440017399 ^ 1450959626;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1349560560 ^ 257998138;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return token;
      }
      private set
      {
label_1:
        int num1 = 599981738;
        while (true)
        {
          int num2 = 326348438;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.token = value;
              num1 = (int) num3 * 1292274825 ^ -2113832778;
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

    public EngineView EngineView
    {
      get
      {
label_1:
        int num1 = 1751765371;
        EngineView engineView;
        while (true)
        {
          int num2 = 2111410502;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              engineView = this.engineView;
              num1 = (int) num3 * 245089687 ^ -1123026249;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return engineView;
      }
      private set
      {
label_1:
        int num1 = 675698172;
        while (true)
        {
          int num2 = 132595338;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.engineView = value;
              num1 = (int) num3 * -1929666294 ^ 1547118324;
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

    public SplashView SplashView
    {
      get
      {
label_1:
        int num1 = 269421662;
        SplashView splashView;
        while (true)
        {
          int num2 = 1646593120;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              splashView = this.splashView;
              num1 = (int) num3 * -1925529890 ^ 1572436911;
              continue;
            case 3:
              num1 = (int) num3 * 997616561 ^ -505980506;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return splashView;
      }
      set
      {
        this.splashView = value;
      }
    }

    public TrackingWindow TrackingWindow
    {
      get
      {
label_1:
        int num1 = 1971945759;
        TrackingWindow trackingWindow;
        while (true)
        {
          int num2 = 897704744;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -252435773 ^ -982938389;
              continue;
            case 3:
              trackingWindow = this.trackingWindow;
              num1 = (int) num3 * 1979854072 ^ -394995682;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return trackingWindow;
      }
      set
      {
        this.trackingWindow = value;
      }
    }

    public CancellationTokenSource TokenSource
    {
      get
      {
        return this.tokenSource;
      }
      set
      {
label_1:
        int num1 = 1993016253;
        while (true)
        {
          int num2 = 1231824876;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.tokenSource = value;
              num1 = (int) num3 * 1188286021 ^ -37561059;
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

    public WindowSelector SelectorWindow
    {
      get
      {
        return this.selectorWindow;
      }
      set
      {
        this.selectorWindow = value;
      }
    }

    public Thread SelectorThread
    {
      get
      {
        Thread selectorThread = this.selectorThread;
label_1:
        int num1 = 272158469;
        while (true)
        {
          int num2 = 1807643245;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1395870841 ^ 20703167;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectorThread;
      }
      set
      {
label_1:
        int num1 = -2136604730;
        while (true)
        {
          int num2 = -1150645223;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.selectorThread = value;
              num1 = (int) num3 * -533334258 ^ 1725063711;
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

    public bool MessageBoxDisplayed
    {
      get
      {
        bool messageBoxDisplayed = this.messageBoxDisplayed;
label_1:
        int num1 = -1897437291;
        while (true)
        {
          int num2 = -884988803;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1037764447 ^ 265123960;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return messageBoxDisplayed;
      }
      set
      {
        this.messageBoxDisplayed = value;
      }
    }

    public List<Window> ApplicationWindows
    {
      get
      {
label_1:
        int num1 = -380291515;
        List<Window> applicationWindows;
        while (true)
        {
          int num2 = -1288515552;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              applicationWindows = this.applicationWindows;
              num1 = (int) num3 * 1181977426 ^ -583611852;
              continue;
            case 2:
              num1 = (int) num3 * -457312256 ^ -1715880076;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return applicationWindows;
      }
      set
      {
        this.applicationWindows = value;
      }
    }

    static App()
    {
label_1:
      int num1 = -1304814317;
      while (true)
      {
        int num2 = -715289657;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            App.applicationLock = App.\u200B‏​⁬‭⁮⁮⁫‬⁫⁫‬‍‫‪​⁫⁯‭‫‍⁬⁭‎‬⁯⁮‬⁬‮‮‍‬‍‬‍‮⁬⁮‪‮();
            num1 = (int) num3 * 362545100 ^ -291157696;
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

    public App()
    {
      App.\u200D‌⁫⁫​⁯‍⁮‮⁪‏​⁪‎‭⁫⁭⁪‬‫⁫‮‏‍​⁪‬‭​‍‍‭‏‌⁯‮‭‍‭⁪‮();
      App.\u206E‎⁯‏‪‏⁯‪⁯⁫‮⁮​‪‭⁮‍​​‌​⁮⁮‪‪⁫‪‫‏‍‏⁭‮‫‬‮‌‮‌‬‮();
    }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
      try
      {
        App.\u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮(App.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(678820416U));
label_2:
        int num1 = 949704156;
        while (true)
        {
          int num2 = 1187760303;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              goto label_28;
            case 1:
              num1 = (int) num3 * -1806284070 ^ 807311213;
              continue;
            case 2:
              num1 = (int) num3 * 774710595 ^ 1879433353;
              continue;
            case 3:
              num1 = (int) num3 * 529313574 ^ -90090302;
              continue;
            case 4:
              this.InitializeEngineView();
              num1 = (int) num3 * -1114998484 ^ 776147266;
              continue;
            case 5:
              num1 = (int) num3 * 1195170872 ^ -1801792799;
              continue;
            case 6:
              int num4 = !App.\u200F‪⁯‏⁮⁫‭⁪‫‭⁮​‪‌‏⁬‭⁯‮‎‫​‏​​⁮‫⁮‎‏‪‭‎‪‬‭⁭‎‭‮‮() ? -368978241 : (num4 = -466041173);
              int num5 = (int) num3 * -297469854;
              num1 = num4 ^ num5;
              continue;
            case 7:
              num1 = (int) num3 * 2103662280 ^ -272759805;
              continue;
            case 8:
              num1 = (int) num3 * 1589552141 ^ -939730747;
              continue;
            case 9:
              goto label_2;
            case 10:
              this.InitializeTrackingThread();
              num1 = (int) num3 * -1582261743 ^ -1530828122;
              continue;
            case 11:
              this.UpdateSplashStatus(EngineEvent.Starting, "");
              this.InitializeEngineThread();
              num1 = (int) num3 * -1065142310 ^ -1308577904;
              continue;
            case 12:
              this.Token = App.\u202A‭⁪⁪⁯⁮‭⁫‪‎‮⁪‍‬⁪⁭‌‬⁮⁯‌⁪⁭‬⁭‍‍‮⁯‎​‍⁭⁯⁫⁮‭⁪‮‎‮(this.TokenSource);
              num1 = (int) num3 * -730052917 ^ 1111995194;
              continue;
            case 13:
              this.InitializeSelectorThread();
              num1 = (int) num3 * 647431646 ^ 1296489268;
              continue;
            case 14:
              this.TokenSource = App.\u202A​⁭⁪⁯‬‫‌‎‏‭‬‌‭‬⁭‪​‪‎‏‮​‮⁪‫‎‎‌‬‭‌‮‎⁭⁮‮⁪‬⁬‮();
              num1 = (int) num3 * -1144064322 ^ 1202369725;
              continue;
            case 15:
              num1 = (int) num3 * 1037626306 ^ -1940825655;
              continue;
            case 16:
              App.\u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮(App.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2066047641U));
              num1 = 1700973303;
              continue;
            case 17:
              num1 = (int) num3 * -976874575 ^ -1980049509;
              continue;
            default:
              goto label_25;
          }
        }
label_25:
        return;
label_28:;
      }
      catch (Exception ex)
      {
label_23:
        int num1 = 1226025374;
        while (true)
        {
          int num2 = 1187760303;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_21;
            case 1:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * 1236466788 ^ -1715883427;
              continue;
            case 2:
              num1 = (int) num3 * -2076437301 ^ -1388661315;
              continue;
            case 3:
              goto label_23;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_21:;
      }
    }

    private void Application_Exit(object sender, ExitEventArgs e)
    {
      try
      {
        if (this.tokenSource == null)
          goto label_6;
label_2:
        int num1 = -1090640427;
label_3:
        while (true)
        {
          int num2 = -709826314;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              num1 = (int) num3 * 400719681 ^ -1645805731;
              continue;
            case 1:
              CoreUtils.LogStackTrace(5);
              num1 = (int) num3 * 523759431 ^ -602865929;
              continue;
            case 2:
              num1 = (int) num3 * -1330103263 ^ -1942317440;
              continue;
            case 3:
              App.\u206B‫‎​⁪‏‍‫‏⁭‪⁭‏‏‪⁬‬‌‍‬‫‭‍‏‮⁮​⁭‍⁮‮‫‫‭⁬⁬⁮‬‪⁭‮(this.tokenSource);
              num1 = (int) num3 * 1087115303 ^ 1504369547;
              continue;
            case 4:
              goto label_20;
            case 5:
              num1 = (int) num3 * -1760037478 ^ -1397381503;
              continue;
            case 6:
              num1 = (int) num3 * -703832422 ^ -1625434781;
              continue;
            case 7:
              goto label_6;
            case 8:
              num1 = (int) num3 * 1297038541 ^ -1282795516;
              continue;
            case 9:
              goto label_2;
            default:
              goto label_17;
          }
        }
label_17:
        return;
label_20:
        return;
label_6:
        this.CloseWindows();
        num1 = -1508987160;
        goto label_3;
      }
      catch (Exception ex)
      {
label_15:
        int num1 = -750843127;
        while (true)
        {
          int num2 = -709826314;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_15;
            case 1:
              goto label_13;
            case 2:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * 1474682558 ^ -2110649381;
              continue;
            case 3:
              num1 = (int) num3 * 2136591894 ^ -533478570;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_13:;
      }
    }

    private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
label_1:
      int num1 = 357227776;
      while (true)
      {
        int num2 = 1473094979;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            App.\u200B‎‎⁭⁫‌⁬⁫‬​⁬‬‪‫‌⁬⁭‍‪‪‭⁮‌‪‌⁭‮‌⁬‪‎‌‌‍⁫‫‫⁯‬‭‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2835879290U), App.\u202C⁫‪⁫⁯‌⁯‬‮⁯‫⁪‪‍⁬‎‎⁪‬‪⁫⁭⁪‍​⁯⁪⁫‬⁫⁮⁯‍⁬‍‌‏​‪‎‮((object) App.\u202C⁪‬‫‏‌‬⁭⁭⁪⁬‌​⁯⁮‍⁬⁬‭‮‌‭​⁪⁯⁯‏⁭⁭⁭⁪‏‌‬⁫​‌⁪‫‮‮(e)));
            num1 = (int) num3 * -643004218 ^ 1202279292;
            continue;
          case 2:
            int num4 = flag ? -321980737 : (num4 = -377323852);
            int num5 = (int) num3 * 935581049;
            num1 = num4 ^ num5;
            continue;
          case 3:
            flag = !App.\u200C‭‏​‮​‌‍⁫‌‪‫‍⁯⁬‪‬‪‏⁮⁮⁬⁭‎⁯‫‏⁯‎​‏⁫⁫​​⁫‪⁮‍‬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1893423522U));
            num1 = (int) num3 * -776877065 ^ 87940484;
            continue;
          case 4:
            goto label_1;
          case 5:
            App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) e);
            num1 = 494336778;
            continue;
          case 6:
            num1 = (int) num3 * -444843574 ^ -248306433;
            continue;
          case 7:
            num1 = (int) num3 * -820404464 ^ 589202710;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      try
      {
        bool flag = !this.MessageBoxDisplayed;
label_11:
        int num2 = 1279317864;
        while (true)
        {
          int num3 = 1473094979;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              goto label_11;
            case 1:
              this.MessageBoxDisplayed = false;
              num2 = (int) num4 * -1518220015 ^ 1414212598;
              continue;
            case 2:
              num2 = (int) num4 * 370906178 ^ 1727774569;
              continue;
            case 3:
              int num5 = flag ? -2045305152 : (num5 = -904879118);
              int num6 = (int) num4 * 801370394;
              num2 = num5 ^ num6;
              continue;
            case 4:
              num2 = (int) num4 * -610442273 ^ -892800168;
              continue;
            case 5:
              this.MessageBoxDisplayed = true;
              num2 = (int) num4 * 1005265558 ^ -1430151873;
              continue;
            case 6:
              int num7 = (int) App.\u206A‭‏‫‮‎‬‎⁯‍‬⁯‎‫‌⁪‍⁮​⁭‍⁯⁯‌‪⁪⁮⁬‎⁫⁪‪⁪⁮‬‌‫‫‌‌‮(App.\u206A‮‍⁪⁯⁮⁪⁪⁭​‏⁭⁯‫‪​‎‏‮⁮‏‫⁮‮‬‮‎‪‎‍‫‬⁬‭⁯⁫⁭⁪​⁭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4105061290U), App.\u200E⁫‎‎⁪‮‬‏‫‭‎⁪⁬‎‮‮​‌⁪‫‍⁬‮⁮⁭⁭⁯‎‮‪‍⁫‍⁬⁯‭‎⁭‮‏‮(App.\u202C⁪‬‫‏‌‬⁭⁭⁪⁬‌​⁯⁮‍⁬⁬‭‮‌‭​⁪⁯⁯‏⁭⁭⁭⁪‏‌‬⁫​‌⁪‫‮‮(e)), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(337076045U), App.\u206D‪⁮‪⁫‎⁭‪‫‪‪‏‌‪⁪⁬‭‮‪‮​⁮⁪⁪‪⁯⁪‬‬⁭⁯‪⁪⁭‪‎‏⁭‬‮(App.\u202C⁪‬‫‏‌‬⁭⁭⁪⁬‌​⁯⁮‍⁬⁬‭‮‌‭​⁪⁯⁯‏⁭⁭⁭⁪‏‌‬⁫​‌⁪‫‮‮(e))), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(299700687U), MessageBoxButton.OK, MessageBoxImage.Exclamation);
              num2 = (int) num4 * -297016429 ^ 545208320;
              continue;
            default:
              goto label_24;
          }
        }
      }
      catch (Exception ex)
      {
        App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
        App.\u206A‍‬‮⁬​‮⁯​‎‫⁫⁯⁭‏‏‎‭‌⁫⁭⁪‭‭‍⁮⁫⁭‏‍​⁬⁫‭​⁮‪‌⁭⁯‮(1);
label_20:
        int num2 = 1028505528;
        while (true)
        {
          int num3 = 1473094979;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * 235120329 ^ -2070989647;
              continue;
            case 2:
              goto label_20;
            default:
              goto label_23;
          }
        }
label_23:
        throw;
      }
label_24:
      App.\u202B⁪‌⁫⁬‎‎‮‏‭⁪‫‮‭⁯​‭‎‍‏‏‭‪⁯⁬‭‏‬‏⁫‌‮‪​‪⁪‪‭‫‮‮(e, true);
    }

    private void DisplayErrorNotice(EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      App.\u003C\u003Ec__DisplayClass49_0 cDisplayClass490 = new App.\u003C\u003Ec__DisplayClass49_0();
label_1:
      int num1 = -1065672501;
      while (true)
      {
        int num2 = -938384094;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass490.e = e;
            num1 = (int) num3 * -1739870942 ^ 1153747599;
            continue;
          case 1:
            int num4 = App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮() != null ? 1483736046 : (num4 = 1655543511);
            int num5 = (int) num3 * -1231231277;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_1;
          case 4:
            goto label_20;
          case 5:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass490.\u003C\u003E4__this = this;
            num1 = (int) num3 * -849948221 ^ -1380500205;
            continue;
          default:
            goto label_7;
        }
      }
label_20:
      return;
label_7:
      try
      {
        // ISSUE: method pointer
        App.\u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮(App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮()), new Action((object) cDisplayClass490, __methodptr(\u003CDisplayErrorNotice\u003Eb__0)));
label_9:
        int num2 = -600820981;
        while (true)
        {
          int num3 = -938384094;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              num2 = (int) num4 * -523814716 ^ 1483924841;
              continue;
            case 1:
              num2 = (int) num4 * -2043226303 ^ 565021215;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_18;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_18:;
      }
      catch (Exception ex)
      {
label_16:
        int num2 = -1162490021;
        while (true)
        {
          int num3 = -938384094;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_16;
            case 1:
              goto label_11;
            case 2:
              num2 = (int) num4 * -798782006 ^ -2124238336;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_11:;
      }
    }

    private void RegisterWindow(Window window)
    {
      object applicationLock = App.applicationLock;
      bool flag = false;
      try
      {
        App.\u202C⁯‫​⁪‎​‫‬‍​⁪‭‏‍​‭‌⁬‏‭‎⁮‮‪‮⁪‪⁫⁭​⁪‏‭​⁯⁭‪‍‎‮(applicationLock, ref flag);
label_2:
        int num1 = 908886162;
        while (true)
        {
          int num2 = 1247642040;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = 1590313702;
              continue;
            case 1:
              num1 = (int) num3 * -2040661152 ^ -536548105;
              continue;
            case 2:
              num1 = (int) num3 * 323656696 ^ 1197142593;
              continue;
            case 3:
              goto label_2;
            case 4:
              this.ApplicationWindows.Add(window);
              num1 = (int) num3 * 323750349 ^ -1585856876;
              continue;
            case 5:
              num1 = (int) num3 * -1333136229 ^ -1188159645;
              continue;
            case 6:
              goto label_14;
            case 7:
              int num4 = !this.ApplicationWindows.Contains(window) ? -1667421334 : (num4 = -2142952785);
              int num5 = (int) num3 * -1598289783;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:;
      }
      finally
      {
        if (flag)
        {
label_12:
          int num1 = 1747239096;
          while (true)
          {
            int num2 = 1247642040;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                App.\u202A‏‍⁪‪‌‎⁭⁯‎⁮⁪‭‭‭‎⁮‫‬⁭⁬‪‭⁪‌‬⁯⁮‍‏‪‍⁫‭‎⁮‌‮‭‫‮(applicationLock);
                num1 = (int) num3 * 1006190341 ^ -1870663639;
                continue;
              case 2:
                goto label_12;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    private void UnregisterWindow(Window window)
    {
label_1:
      int num1 = -226660574;
      object applicationLock;
      while (true)
      {
        int num2 = -555768266;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            applicationLock = App.applicationLock;
            num1 = (int) num3 * -2141217935 ^ 238160443;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        App.\u202C⁯‫​⁪‎​‫‬‍​⁪‭‏‍​‭‌⁬‏‭‎⁮‮‪‮⁪‪⁫⁭​⁪‏‭​⁯⁭‪‍‎‮(applicationLock, ref flag);
label_6:
        int num2 = -1347371809;
        while (true)
        {
          int num3 = -555768266;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_14;
            case 1:
              this.ApplicationWindows.Remove(window);
              num2 = (int) num4 * 716175239 ^ 475140423;
              continue;
            case 2:
              num2 = (int) num4 * 983170805 ^ 439111952;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:;
      }
      finally
      {
        if (flag)
        {
label_12:
          int num2 = -1923615318;
          while (true)
          {
            int num3 = -555768266;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_12;
              case 2:
                App.\u202A‏‍⁪‪‌‎⁭⁯‎⁮⁪‭‭‭‎⁮‫‬⁭⁬‪‭⁪‌‬⁯⁮‍‏‪‍⁫‭‎⁮‌‮‭‫‮(applicationLock);
                num2 = (int) num4 * -1141110221 ^ -1926721047;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    private void CloseWindows()
    {
label_1:
      int num1 = -1727384176;
      while (true)
      {
        int num2 = -1086825481;
        uint num3;
        Window[] windowArray;
        int index;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            flag = index < windowArray.Length;
            num1 = -1743569992;
            continue;
          case 1:
            windowArray = new Window[this.applicationWindows.Count];
            index = 0;
            num1 = (int) num3 * 1455863959 ^ 69199727;
            continue;
          case 2:
            num1 = -160376985;
            continue;
          case 3:
            num1 = (int) num3 * 87993594 ^ 2073506589;
            continue;
          case 4:
            this.CloseWindow(windowArray[index]);
            num1 = (int) num3 * -1733399261 ^ 852005492;
            continue;
          case 5:
            num1 = (int) num3 * -6066114 ^ -237327841;
            continue;
          case 6:
            goto label_1;
          case 7:
            int num4 = flag ? -611454578 : (num4 = -30018623);
            int num5 = (int) num3 * -149856213;
            num1 = num4 ^ num5;
            continue;
          case 8:
            ++index;
            num1 = (int) num3 * 1816203669 ^ 547982189;
            continue;
          case 9:
            goto label_3;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    private void CloseWindow(Window window)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      App.\u003C\u003Ec__DisplayClass53_0 cDisplayClass530 = new App.\u003C\u003Ec__DisplayClass53_0();
label_1:
      int num1 = 267424792;
      while (true)
      {
        int num2 = 99720053;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            this.UnregisterWindow(cDisplayClass530.window);
            num1 = (int) num3 * -828540013 ^ -853339619;
            continue;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 662270400 ^ 1183264404;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass530.window = (Window) null;
            num1 = (int) num3 * 1780817517 ^ 2017666053;
            continue;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: reference to a compiler-generated field
            int num4 = cDisplayClass530.window != null ? 1182844844 : (num4 = 1229072176);
            int num5 = (int) num3 * -415542625;
            num1 = num4 ^ num5;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass530.window = window;
            num1 = (int) num3 * -389177404 ^ 677607972;
            continue;
          case 7:
            num1 = (int) num3 * 1667679341 ^ 749159794;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            App.\u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮(App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) cDisplayClass530.window), new Action((object) cDisplayClass530, __methodptr(\u003CCloseWindow\u003Eb__0)));
            num1 = (int) num3 * 1046812975 ^ 689116702;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void InitializeEngineThread()
    {
      try
      {
label_2:
        int num1 = -2030917062;
        while (true)
        {
          int num2 = -211098562;
          uint num3;
          Dispatcher currentDispatcher;
          App app;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              goto label_2;
            case 1:
              this.engineThread = App.\u200F‍⁯‏⁬‫‪⁮‌‭​‍⁭⁫‏​⁫‏‌⁯⁫‍⁪‫⁯‮‌‮‎⁫‫⁮‮⁯⁮⁫‮‬‮‫‮((ThreadStart) (() =>
              {
                try
                {
                  Engine instance = Engine.Instance;
label_2:
                  int num1 = 954673749;
                  while (true)
                  {
                    int num2 = 36853766;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 4U)
                    {
                      case 0:
                        num1 = (int) num3 * -1283597524 ^ -1780041901;
                        continue;
                      case 1:
                        goto label_14;
                      case 2:
                        goto label_2;
                      case 3:
                        instance.OnEngineEvent += new EventHandler(app.Engine_OnEngineEvent);
                        instance.Execute(currentDispatcher, app.Token);
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        App.\u003C\u003Ec__DisplayClass54_0.\u200C‪⁪⁯⁫‌⁬‎⁯‭‌⁭⁫⁬⁪⁫​‍​‏⁬⁯‫‮​⁫‮⁭‪‪⁭‬⁮​⁪‭‪‫⁬‍‮(App.\u003C\u003Ec__DisplayClass54_0.\u206C‪‍⁫⁭⁬⁯‭‍‏⁮‭⁪⁫‎​‍‪⁫‬‍⁮⁪‏‭‎‌⁬⁮‭‭⁪​‬⁫‫⁫⁮‮‪‮((DispatcherObject) app));
                        num1 = (int) num3 * 1276572710 ^ -1904425228;
                        continue;
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
                  int num1 = 1693991091;
                  while (true)
                  {
                    int num2 = 36853766;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 4U)
                    {
                      case 0:
                        goto label_7;
                      case 1:
                        num1 = (int) num3 * 1880329783 ^ 1193327015;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        App.\u003C\u003Ec__DisplayClass54_0.\u206D‍‌⁭‮‍‭‬‭‫⁯​‬⁫⁫‎‍‎⁫‫‏​‍‏⁬‍⁫⁫​‌‍‎⁭⁬‏‏‍‮⁬⁪‮(App.log, (object) ex);
                        num1 = (int) num3 * -176703881 ^ -1588361040;
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
              }));
              App.\u206B‏‌⁯‍⁭‮‏⁪⁫⁫⁭‏‏‌⁮‎​⁬‮⁫‬‭⁬⁯‪‭⁭‎​⁮‬⁮‎‮⁬‌‍‪‮(this.engineThread, ApartmentState.STA);
              App.\u200B‫⁫‍‫‮⁮‍⁯⁯⁭⁫⁮⁮‫‎‍‮‪‫​‭⁫‎‌⁮⁬‍‏‌⁮⁯⁪‬‎‎⁫⁮⁬⁫‮(this.engineThread, true);
              num1 = (int) num3 * 343500354 ^ 1817749698;
              continue;
            case 2:
              App.\u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮(App.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(453162345U));
              num1 = (int) num3 * 298351438 ^ -357396374;
              continue;
            case 3:
              app = this;
              num1 = (int) num3 * 573215816 ^ -842670718;
              continue;
            case 4:
              App.\u202A‏‏​⁫‪⁮⁪⁭⁯‍‬‌‭⁪‮‫‌​‭‫⁮‎‏⁫‌‌‍⁮​⁬⁭‮⁫‪‏‬⁪‫‍‮(this.engineThread);
              num1 = (int) num3 * 753639005 ^ 1929254596;
              continue;
            case 5:
              goto label_19;
            case 6:
              currentDispatcher = App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮());
              num1 = (int) num3 * -425614997 ^ 1232817832;
              continue;
            case 7:
              num1 = (int) num3 * 1281753122 ^ 1961522987;
              continue;
            case 8:
              num1 = (int) num3 * -2059240290 ^ -752544443;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_19:;
      }
      catch (Exception ex)
      {
label_14:
        int num1 = -618706972;
        while (true)
        {
          int num2 = -211098562;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_12;
            case 1:
              num1 = (int) num3 * 477494283 ^ 56856293;
              continue;
            case 2:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * -1962228078 ^ 1835360611;
              continue;
            case 3:
              goto label_14;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_12:;
      }
    }

    private void Engine_OnEngineEvent(object sender, EventArgs e)
    {
label_1:
      int num1 = -181842934;
      while (true)
      {
        int num2 = -1138744679;
        uint num3;
        bool flag;
        EngineEventArgs engineEventArgs;
        switch ((num3 = (uint) (num1 ^ num2)) % 22U)
        {
          case 0:
label_18:
            this.UpdateSplashStatus(engineEventArgs.EngineEvent, engineEventArgs.StatusMessage);
            num1 = -690566955;
            continue;
          case 1:
label_24:
            this.HandleEngineStopping(sender, e);
            num1 = -1718938080;
            continue;
          case 2:
            num1 = -494389761;
            continue;
          case 3:
            num1 = (int) num3 * -3475120 ^ -706516091;
            continue;
          case 4:
label_14:
            this.HandleEngineStarting(sender, e);
            num1 = -1250946005;
            continue;
          case 5:
            num1 = (int) num3 * -2090347532 ^ 1949691633;
            continue;
          case 6:
label_15:
            this.HandleEngineStopped(sender, e);
            num1 = -664980887;
            continue;
          case 7:
label_10:
            CoreUtils.LogStackTrace(5);
            num1 = -86188791;
            continue;
          case 8:
            goto label_3;
          case 9:
            int num4 = flag ? -1971025695 : (num4 = -475510517);
            int num5 = (int) num3 * 551375452;
            num1 = num4 ^ num5;
            continue;
          case 10:
            num1 = (int) num3 * 871571 ^ 1741762821;
            continue;
          case 11:
            num1 = (int) num3 * 21907875 ^ 381042536;
            continue;
          case 12:
            num1 = (int) num3 * -224276845 ^ -349790392;
            continue;
          case 13:
            goto label_1;
          case 14:
            num1 = (int) num3 * 876540451 ^ 2066949791;
            continue;
          case 15:
label_8:
            this.HandleEngineStarted(sender, e);
            num1 = -905410889;
            continue;
          case 16:
            num1 = (int) num3 * -811767988 ^ 1412239885;
            continue;
          case 17:
            App.\u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮(App.log, (object) App.\u200F‏‬‬‪⁭‎‮‫⁯‏⁮⁬‮‏‮‌⁭​⁮‪‏‌‭‪‬‫‮⁭⁮⁪‬‏‫‪‎‎‎⁮‮‮((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4003921224U), (object) engineEventArgs.EngineEvent));
            num1 = (int) num3 * -1733321723 ^ -2792303;
            continue;
          case 18:
            this.DisplayErrorNotice(e);
            num1 = (int) num3 * 1930801908 ^ -277643883;
            continue;
          case 19:
            num1 = (int) num3 * -221420769 ^ 1420564447;
            continue;
          case 20:
            switch (engineEventArgs.EngineEvent)
            {
              case EngineEvent.Undefined:
              case EngineEvent.Configuring:
              case EngineEvent.CheckingLicense:
              case EngineEvent.CheckingVersion:
              case EngineEvent.ValidatingSchema:
              case EngineEvent.LoadingData:
                goto label_18;
              case EngineEvent.Starting:
                goto label_14;
              case EngineEvent.Started:
                goto label_8;
              case EngineEvent.Stopping:
                goto label_24;
              case EngineEvent.Stopped:
                goto label_15;
              case EngineEvent.Error:
                goto label_10;
              default:
                num1 = (int) num3 * 884376196 ^ -1192865502;
                continue;
            }
          case 21:
            engineEventArgs = e as EngineEventArgs;
            flag = engineEventArgs != null;
            num1 = (int) num3 * 1176824749 ^ 847563141;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return;
label_3:;
    }

    private void HandleEngineStarting(object sender, EventArgs e)
    {
    }

    private void HandleEngineStarted(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      App.\u003C\u003Ec__DisplayClass57_0 cDisplayClass570 = new App.\u003C\u003Ec__DisplayClass57_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass570.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass570.sender = sender;
      try
      {
label_2:
        int num1 = -57457455;
        while (true)
        {
          int num2 = -1808802051;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_18;
            case 1:
              num1 = (int) num3 * 1046954144 ^ 423279474;
              continue;
            case 2:
              // ISSUE: method pointer
              App.\u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮(App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮()), new Action((object) cDisplayClass570, __methodptr(\u003CHandleEngineStarted\u003Eb__0)));
              num1 = -1325064097;
              continue;
            case 3:
              goto label_2;
            case 4:
              num1 = (int) num3 * 449504599 ^ -1076262238;
              continue;
            case 5:
              goto label_14;
            case 6:
              int num4 = App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮() == null ? 224061923 : (num4 = 53253430);
              int num5 = (int) num3 * 907807626;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:
        return;
label_18:;
      }
      catch (Exception ex)
      {
label_12:
        int num1 = -1741193763;
        while (true)
        {
          int num2 = -1808802051;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -1975933336 ^ -317013911;
              continue;
            case 1:
              num1 = (int) num3 * -1317992077 ^ -1593997071;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_12;
            case 4:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * 361525230 ^ -530162784;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_8:;
      }
    }

    private void HandleEngineStopped(object sender, EventArgs e)
    {
      try
      {
label_2:
        int num1 = 1126266048;
        while (true)
        {
          int num2 = 279509367;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          int num5;
          int num6;
          switch ((num3 = (uint) (num1 ^ num2)) % 19U)
          {
            case 0:
              if (this.trackingThread != null)
              {
                num1 = 2066971619;
                continue;
              }
              goto label_10;
            case 1:
              if (this.selectorThread != null)
              {
                num1 = (int) num3 * -1121547663 ^ 602824813;
                continue;
              }
              break;
            case 2:
              num1 = (int) num3 * 1683538704 ^ 1704499502;
              continue;
            case 3:
              if (App.\u200D​‏‮‭‮‪⁮‬‬‭‫⁮‏‎​⁪⁫⁯‫⁫⁪‮‮⁭‌⁯‍⁫‬⁮⁪‏‍⁫‭‬⁯‭⁬‮(this.engineThread))
              {
                num1 = (int) num3 * -1241615856 ^ -829685068;
                continue;
              }
              goto label_29;
            case 4:
              if (this.engineThread != null)
              {
                num1 = 1929264943;
                continue;
              }
              goto label_29;
            case 5:
              int num7 = flag2 ? 387753486 : (num7 = 216982014);
              int num8 = (int) num3 * -572002688;
              num1 = num7 ^ num8;
              continue;
            case 6:
              int num9 = !flag1 ? -1579440079 : (num9 = -1607333495);
              int num10 = (int) num3 * 1190703354;
              num1 = num9 ^ num10;
              continue;
            case 7:
              if (App.\u200D​‏‮‭‮‪⁮‬‬‭‫⁮‏‎​⁪⁫⁯‫⁫⁪‮‮⁭‌⁯‍⁫‬⁮⁪‏‍⁫‭‬⁯‭⁬‮(this.selectorThread))
              {
                num1 = (int) num3 * 865241000 ^ 1590864382;
                continue;
              }
              break;
            case 8:
              num1 = (int) num3 * 65584505 ^ 375673877;
              continue;
            case 9:
              App.\u202E‭⁮‏‫‪⁫‬​⁭⁬‪‫⁮​⁯‎‬⁭‫‮‫‫‪‌⁯‮‬⁫‍‮‬‍‌‎‌‫⁪‍‍‮(this.selectorThread);
              num1 = (int) num3 * -363556637 ^ 1068718392;
              continue;
            case 10:
              App.\u202E‭⁮‏‫‪⁫‬​⁭⁬‪‫⁮​⁯‎‬⁭‫‮‫‫‪‌⁯‮‬⁫‍‮‬‍‌‎‌‫⁪‍‍‮(this.trackingThread);
              num1 = (int) num3 * 616896860 ^ -1307396404;
              continue;
            case 11:
              if (App.\u200D​‏‮‭‮‪⁮‬‬‭‫⁮‏‎​⁪⁫⁯‫⁫⁪‮‮⁭‌⁯‍⁫‬⁮⁪‏‍⁫‭‬⁯‭⁬‮(this.trackingThread))
              {
                num1 = (int) num3 * 2089240721 ^ 210557874;
                continue;
              }
              goto label_10;
            case 12:
              goto label_40;
            case 13:
              num1 = (int) num3 * -696378984 ^ 797247789;
              continue;
            case 14:
              App.\u202E‭⁮‏‫‪⁫‬​⁭⁬‪‫⁮​⁯‎‬⁭‫‮‫‫‪‌⁯‮‬⁫‍‮‬‍‌‎‌‫⁪‍‍‮(this.engineThread);
              num1 = (int) num3 * -1499713415 ^ -944684677;
              continue;
            case 15:
              num4 = App.\u202B‮‪⁯‬‭⁭‏‫⁯⁬‭⁫‏‏‮‭⁫‍‬⁭​⁭‏‪‏⁫‫⁫⁬‪‎‪‬⁯⁯‮‬‪‏‮(this.trackingThread) == System.Threading.ThreadState.Running ? 1 : 0;
              goto label_11;
            case 16:
              goto label_2;
            case 17:
              num5 = App.\u202B‮‪⁯‬‭⁭‏‫⁯⁬‭⁫‏‏‮‭⁫‍‬⁭​⁭‏‪‏⁫‫⁫⁬‪‎‪‬⁯⁯‮‬‪‏‮(this.selectorThread) == System.Threading.ThreadState.Running ? 1 : 0;
              goto label_8;
            case 18:
              num6 = App.\u202B‮‪⁯‬‭⁭‏‫⁯⁬‭⁫‏‏‮‭⁫‍‬⁭​⁭‏‪‏⁫‫⁫⁬‪‎‪‬⁯⁯‮‬‪‏‮(this.engineThread) == System.Threading.ThreadState.Running ? 1 : 0;
              goto label_30;
            default:
              goto label_38;
          }
          num5 = 0;
label_8:
          int num11;
          num1 = num11 = num5 != 0 ? 483348750 : (num11 = 245032177);
          continue;
label_10:
          num4 = 0;
label_11:
          flag1 = num4 != 0;
          num1 = 2063908933;
          continue;
label_29:
          num6 = 0;
label_30:
          flag2 = num6 != 0;
          num1 = 971886947;
        }
label_38:
        return;
label_40:;
      }
      catch (Exception ex)
      {
label_36:
        int num1 = 622559094;
        while (true)
        {
          int num2 = 279509367;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_34;
            case 1:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * 180016999 ^ -2109493479;
              continue;
            case 2:
              goto label_36;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_34:;
      }
    }

    private void HandleEngineStopping(object sender, EventArgs e)
    {
      this.CloseWindows();
    }

    private void InitializeEngineView()
    {
label_1:
      int num1 = -696851829;
      while (true)
      {
        int num2 = -520475975;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * 398422600 ^ -2074828052;
            continue;
          case 1:
            goto label_3;
          case 2:
            App.\u202D⁬‮‭‏‬‌⁬⁫‮⁫⁭‏‍‬‌‍‏‫⁫‫‎⁬⁯‏‪‎⁮‎‭‬⁫​⁫‎‍‪‏‪‮((Window) this.EngineView, new EventHandler(this.EngineView_Closed));
            num1 = (int) num3 * 1431540183 ^ 8512858;
            continue;
          case 3:
            goto label_1;
          case 4:
            this.EngineView = new EngineView();
            this.RegisterWindow((Window) this.EngineView);
            num1 = (int) num3 * 189699245 ^ -168091211;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private void EngineView_Closed(object sender, EventArgs e)
    {
      try
      {
label_2:
        int num1 = -587387785;
        while (true)
        {
          int num2 = -1085582682;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 15U)
          {
            case 0:
              this.Engine.CancelExecution();
              num1 = (int) num3 * 1604773726 ^ 74662762;
              continue;
            case 1:
              flag = this.Engine != null;
              num1 = (int) num3 * -705126313 ^ 2064500596;
              continue;
            case 2:
              int num4 = App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮() != null ? -333264547 : (num4 = -163388554);
              int num5 = (int) num3 * -2093733035;
              num1 = num4 ^ num5;
              continue;
            case 3:
              // ISSUE: method pointer
              App.\u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮(App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮()), new Action((object) this, __methodptr(\u003CEngineView_Closed\u003Eb__61_0)));
              num1 = -1268673448;
              continue;
            case 4:
              num1 = (int) num3 * -325765433 ^ 1041843080;
              continue;
            case 5:
              num1 = (int) num3 * -631970892 ^ 1209971665;
              continue;
            case 6:
              App.\u206B‫‎​⁪‏‍‫‏⁭‪⁭‏‏‪⁬‬‌‍‬‫‭‍‏‮⁮​⁭‍⁮‮‫‫‭⁬⁬⁮‬‪⁭‮(this.TokenSource);
              num1 = -883771750;
              continue;
            case 7:
              goto label_2;
            case 8:
              int num6 = flag ? 1859513847 : (num6 = 440083245);
              int num7 = (int) num3 * -928250142;
              num1 = num6 ^ num7;
              continue;
            case 9:
              num1 = (int) num3 * -1408054411 ^ 441465748;
              continue;
            case 10:
              num1 = (int) num3 * -1934087124 ^ -1249351773;
              continue;
            case 11:
              goto label_13;
            case 12:
              goto label_4;
            case 13:
              num1 = (int) num3 * -1132060289 ^ -935130921;
              continue;
            case 14:
              num1 = (int) num3 * -1318757844 ^ 495031043;
              continue;
            default:
              goto label_19;
          }
        }
label_19:
        return;
label_4:
        return;
label_13:;
      }
      catch (Exception ex)
      {
        App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
      }
    }

    private void InitializeTrackingThread()
    {
      try
      {
label_2:
        int num1 = 1621568915;
        while (true)
        {
          int num2 = 1950112224;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              this.trackingThread = App.\u200F‍⁯‏⁬‫‪⁮‌‭​‍⁭⁫‏​⁫‏‌⁯⁫‍⁪‫⁯‮‌‮‎⁫‫⁮‮⁯⁮⁫‮‬‮‫‮((ThreadStart) (() =>
              {
                try
                {
label_2:
                  int num1 = -1205480372;
                  while (true)
                  {
                    int num2 = -2033880514;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 10U)
                    {
                      case 0:
                        this.Engine.SetTrackingWindow(this.TrackingWindow);
                        num1 = (int) num3 * 2088545584 ^ 982200366;
                        continue;
                      case 1:
                        App.\u202D⁬‮‭‏‬‌⁬⁫‮⁫⁭‏‍‬‌‍‏‫⁫‫‎⁬⁯‏‪‎⁮‎‭‬⁫​⁫‎‍‪‏‪‮((Window) this.TrackingWindow, new EventHandler(this.TrackingView_Closed));
                        num1 = (int) num3 * -764208082 ^ 124525458;
                        continue;
                      case 2:
                        goto label_2;
                      case 3:
                        goto label_19;
                      case 4:
                        App.\u206D‫​⁯‮​‬‪⁮⁯‎⁬‏‎⁮⁮‏‎‮‎‎‮‮⁪‭‏⁫‮‮⁪⁪‫‪⁮‭‭‌​​⁬‮((Window) this.TrackingWindow);
                        num1 = (int) num3 * 1897733197 ^ 1582308841;
                        continue;
                      case 5:
                        num1 = (int) num3 * -94263465 ^ -1712548908;
                        continue;
                      case 6:
                        this.TrackingWindow = new TrackingWindow();
                        num1 = (int) num3 * -139569297 ^ 555605598;
                        continue;
                      case 7:
                        this.TrackingWindow.Token = this.Token;
                        num1 = (int) num3 * 772329402 ^ 415218993;
                        continue;
                      case 8:
                        this.RegisterWindow((Window) this.TrackingWindow);
                        num1 = (int) num3 * -101319617 ^ -1850023777;
                        continue;
                      case 9:
                        App.\u202E‬⁮⁬‫‍‬⁫⁫⁯⁮‏‍​‫⁫⁬‌⁯‭‮‪‌⁮‮‌‏​‌⁫⁫‎‭⁬⁭‏⁮‪‪⁬‮();
                        num1 = (int) num3 * 1297865192 ^ 719105865;
                        continue;
                      default:
                        goto label_17;
                    }
                  }
label_17:
                  return;
label_19:;
                }
                catch (Exception ex)
                {
label_15:
                  int num1 = -916082849;
                  while (true)
                  {
                    int num2 = -2033880514;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                    {
                      case 0:
                        goto label_15;
                      case 1:
                        goto label_13;
                      case 2:
                        App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
                        num1 = (int) num3 * 163753825 ^ -659344328;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  return;
label_13:;
                }
              }));
              num1 = (int) num3 * 1966938078 ^ -1573254913;
              continue;
            case 1:
              App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮());
              num1 = (int) num3 * -1660536618 ^ 191767863;
              continue;
            case 2:
              goto label_20;
            case 3:
              goto label_2;
            case 4:
              num1 = (int) num3 * 2113261082 ^ -1768541544;
              continue;
            case 5:
              App.\u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮(App.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3328474411U));
              num1 = (int) num3 * -974755608 ^ 1775594881;
              continue;
            case 6:
              App.\u200B‫⁫‍‫‮⁮‍⁯⁯⁭⁫⁮⁮‫‎‍‮‪‫​‭⁫‎‌⁮⁬‍‏‌⁮⁯⁪‬‎‎⁫⁮⁬⁫‮(this.trackingThread, true);
              num1 = (int) num3 * -485735525 ^ -774297681;
              continue;
            case 7:
              App.\u206B‏‌⁯‍⁭‮‏⁪⁫⁫⁭‏‏‌⁮‎​⁬‮⁫‬‭⁬⁯‪‭⁭‎​⁮‬⁮‎‮⁬‌‍‪‮(this.trackingThread, ApartmentState.STA);
              num1 = (int) num3 * -1405932837 ^ -1614318066;
              continue;
            case 8:
              num1 = (int) num3 * -1708180901 ^ -740163817;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_20:;
      }
      catch (Exception ex)
      {
label_14:
        int num1 = 1746597817;
        while (true)
        {
          int num2 = 1950112224;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_14;
            case 1:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * -1969866535 ^ 1501792446;
              continue;
            case 2:
              goto label_12;
            case 3:
              num1 = (int) num3 * 2065351177 ^ -1094320936;
              continue;
            case 4:
              num1 = (int) num3 * 56418410 ^ 1973208474;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_12:;
      }
    }

    private void StartTrackingThread()
    {
      try
      {
        App.\u202A‏‏​⁫‪⁮⁪⁭⁯‍‬‌‭⁪‮‫‌​‭‫⁮‎‏⁫‌‌‍⁮​⁬⁭‮⁫‪‏‬⁪‫‍‮(this.trackingThread);
label_2:
        int num1 = -2087566077;
        while (true)
        {
          int num2 = -1224212693;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 1698755544 ^ 1688578199;
              continue;
            case 2:
              goto label_4;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_4:;
      }
      catch (Exception ex)
      {
        App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
      }
    }

    private void TrackingView_Closed(object sender, EventArgs e)
    {
label_1:
      int num1 = -1889454180;
      while (true)
      {
        int num2 = -148240667;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            goto label_3;
          case 1:
            App.\u206D‮‭‫‮⁫‎⁫‎⁯‌‏‎⁮⁯‎‎‌‍‌‌⁫​⁪⁯‮​‍‮⁪‎⁪‫​‮‏‎‫⁯‎‮(App.\u200D‫⁫‎‌‍⁯‬⁪‭⁮‬‭⁯⁮‬⁮‌‏‮‌‭⁫‎‏‍⁪⁮‎‮‏‭‮⁯⁭‮‌⁮‏‌‮((DispatcherObject) this), (Delegate) new App.EventDelegate(this.TrackingView_Closed), new object[2]
            {
              sender,
              (object) e
            });
            num1 = (int) num3 * -761678575 ^ 91823109;
            continue;
          case 2:
            this.UnregisterWindow((Window) this.TrackingWindow);
            num1 = (int) num3 * 652228695 ^ -1000573847;
            continue;
          case 3:
            num1 = -1425520775;
            continue;
          case 4:
            this.TrackingWindow = (TrackingWindow) null;
            num1 = (int) num3 * 230705782 ^ -1781515862;
            continue;
          case 5:
            if (this.TrackingWindow == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 908125928 ^ -1346561085;
            continue;
          case 6:
            num1 = (int) num3 * 1841337675 ^ 380863373;
            continue;
          case 7:
            num1 = (int) num3 * -1093298610 ^ 1498475119;
            continue;
          case 8:
            num1 = -166826105;
            continue;
          case 9:
            num1 = (int) num3 * -1714001515 ^ -1396521748;
            continue;
          case 10:
            num4 = App.\u200D‫⁫‎‌‍⁯‬⁪‭⁮‬‭⁯⁮‬⁮‌‏‮‌‭⁫‎‏‍⁪⁮‎‮‏‭‮⁯⁭‮‌⁮‏‌‮((DispatcherObject) this) != null ? 1 : 0;
            break;
          case 11:
            goto label_1;
          case 12:
            flag = !App.\u206D⁯‮⁫⁭⁪⁯⁮‍‍⁮⁬​‭‌​⁭‍‮⁭⁯‌‎‮⁮⁬‪‏‪⁪‫⁫⁭‎‪‍‎‭‭‫‮(App.\u200D‫⁫‎‌‍⁯‬⁪‭⁮‬‭⁯⁮‬⁮‌‏‮‌‭⁫‎‏‍⁪⁮‎‮‏‭‮⁯⁭‮‌⁮‏‌‮((DispatcherObject) this));
            num1 = (int) num3 * -1122604839 ^ -1702918494;
            continue;
          case 13:
            num1 = (int) num3 * -874495815 ^ -1330589952;
            continue;
          case 14:
            int num5 = !flag ? 1018448586 : (num5 = 2058740881);
            int num6 = (int) num3 * 495808152;
            num1 = num5 ^ num6;
            continue;
          default:
            goto label_20;
        }
        int num7;
        num1 = num7 = num4 != 0 ? -852633614 : (num7 = -166826105);
      }
label_20:
      return;
label_3:;
    }

    private void SplashScreen_Closed(object sender, EventArgs e)
    {
label_1:
      int num1 = 952956113;
      while (true)
      {
        int num2 = 1565327531;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_11;
          case 2:
            int num4 = App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮() != null ? -2087251798 : (num4 = -1104810252);
            int num5 = (int) num3 * 2084705803;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_6;
        }
      }
label_11:
      return;
label_6:
      try
      {
        // ISSUE: method pointer
        App.\u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮(App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮()), new Action((object) this, __methodptr(\u003CSplashScreen_Closed\u003Eb__66_0)));
      }
      catch (Exception ex)
      {
label_9:
        int num2 = 1197474537;
        while (true)
        {
          int num3 = 1565327531;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_9;
            case 1:
              num2 = (int) num4 * -1834270318 ^ 697426434;
              continue;
            case 2:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num2 = (int) num4 * -1147416837 ^ 2145860956;
              continue;
            case 3:
              goto label_5;
            default:
              goto label_3;
          }
        }
label_3:
        return;
label_5:;
      }
    }

    private string GetSplashMessage(EngineEvent engineEvent, string statusMessage)
    {
label_1:
      int num1 = -1580361349;
      string str;
      while (true)
      {
        int num2 = -1436107408;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
          case 4:
label_6:
            str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3642145393U);
            num1 = -267253130;
            continue;
          case 1:
            num1 = (int) num3 * -1074883174 ^ -810886979;
            continue;
          case 2:
            num1 = (int) num3 * -157318611 ^ -1594327283;
            continue;
          case 3:
            num1 = (int) num3 * -694236086 ^ -1313375890;
            continue;
          case 5:
label_14:
            str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1176957105U);
            num1 = -44301246;
            continue;
          case 6:
            num1 = (int) num3 * 152286945 ^ -541675903;
            continue;
          case 8:
label_8:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1192053376U);
            num1 = -1718382905;
            continue;
          case 9:
            goto label_1;
          case 10:
label_10:
            str = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1246767193U);
            num1 = -2078376127;
            continue;
          case 11:
            switch (engineEvent)
            {
              case EngineEvent.Starting:
                goto label_14;
              case EngineEvent.Started:
              case EngineEvent.Stopping:
              case EngineEvent.Stopped:
              case EngineEvent.Error:
                goto label_6;
              case EngineEvent.Configuring:
                goto label_10;
              case EngineEvent.CheckingLicense:
                goto label_8;
              case EngineEvent.CheckingVersion:
                goto label_16;
              case EngineEvent.ValidatingSchema:
                goto label_7;
              case EngineEvent.LoadingData:
                goto label_3;
              default:
                num1 = (int) num3 * 235036443 ^ 1664356234;
                continue;
            }
          case 12:
label_3:
            str = App.\u202A⁮⁯⁫‌‌​‮‌‫⁬‎‫‍‎⁫‬‪⁮⁭‪‫‭⁭⁬‍‌⁫⁯‏⁬‫‫⁬‌‎‮‍‪‏‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3342535622U), statusMessage);
            num1 = -1718382905;
            continue;
          case 13:
label_7:
            str = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3303247289U);
            num1 = -1872210098;
            continue;
          case 14:
            num1 = (int) num3 * -276917983 ^ -2104573639;
            continue;
          case 15:
label_16:
            str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(642542681U);
            num1 = -1718382905;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return str;
    }

    private void UpdateSplashStatus(EngineEvent engineEvent, string statusMessage)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      App.\u003C\u003Ec__DisplayClass68_0 cDisplayClass680 = new App.\u003C\u003Ec__DisplayClass68_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass680.\u003C\u003E4__this = this;
label_1:
      int num1 = -903777941;
      while (true)
      {
        int num2 = -1150938044;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass680.engineEvent = engineEvent;
            // ISSUE: reference to a compiler-generated field
            cDisplayClass680.statusMessage = statusMessage;
            num1 = (int) num3 * -620889188 ^ -1406850390;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        bool flag = App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮() == null;
label_6:
        int num2 = -1378051639;
        while (true)
        {
          int num3 = -1150938044;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = (int) num4 * -625168375 ^ 944940028;
              continue;
            case 1:
              int num5 = !flag ? -155470454 : (num5 = -1212424139);
              int num6 = (int) num4 * 1173346795;
              num2 = num5 ^ num6;
              continue;
            case 2:
              goto label_21;
            case 3:
              goto label_6;
            case 4:
              goto label_17;
            case 5:
              // ISSUE: method pointer
              App.\u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮(App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮()), new Action((object) cDisplayClass680, __methodptr(\u003CUpdateSplashStatus\u003Eb__0)));
              num2 = -301758254;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_17:
        return;
label_21:;
      }
      catch (Exception ex)
      {
label_15:
        int num2 = -723732278;
        while (true)
        {
          int num3 = -1150938044;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_15;
            case 1:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num2 = (int) num4 * -1180597171 ^ 508370823;
              continue;
            case 2:
              goto label_10;
            case 3:
              num2 = (int) num4 * 1150478413 ^ 1734271553;
              continue;
            case 4:
              num2 = (int) num4 * 20272352 ^ 1758832611;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_10:;
      }
    }

    private void HideSplashScreen()
    {
      App.\u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮(App.log, (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1786376888U));
      // ISSUE: method pointer
      App.\u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮(App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮()), new Action((object) this, __methodptr(\u003CHideSplashScreen\u003Eb__69_0)));
    }

    private void InitializeSelectorThread()
    {
      try
      {
label_2:
        int num1 = -359958105;
        while (true)
        {
          int num2 = -62409257;
          uint num3;
          Dispatcher currentDispatcher;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 91519931 ^ 1143666600;
              continue;
            case 2:
              currentDispatcher = App.\u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮((DispatcherObject) App.\u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮());
              App.\u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮(App.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3204638303U));
              num1 = (int) num3 * -15983614 ^ 1245317742;
              continue;
            case 3:
              this.SelectorThread = App.\u200F‍⁯‏⁬‫‪⁮‌‭​‍⁭⁫‏​⁫‏‌⁯⁫‍⁪‫⁯‮‌‮‎⁫‫⁮‮⁯⁮⁫‮‬‮‫‮((ThreadStart) (() =>
              {
                try
                {
                  this.SelectorWindow = new WindowSelector();
                  this.RegisterWindow((Window) this.SelectorWindow);
label_2:
                  int num1 = -127358213;
                  while (true)
                  {
                    int num2 = -1522170422;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 9U)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        num1 = (int) num3 * -1588356191 ^ -1423305202;
                        continue;
                      case 2:
                        this.SelectorWindow.Token = this.Token;
                        num1 = (int) num3 * 361284352 ^ -1313932331;
                        continue;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        App.\u003C\u003Ec__DisplayClass70_0.\u200B‭⁫⁯‪‬‮⁮‌⁪⁮‍‌⁭‫‮⁬‪‮‮‪‌‬‌⁭‭‍⁭⁯‬‍⁬‍‏‫‍⁬‬⁬‪‮((Window) this.SelectorWindow);
                        num1 = (int) num3 * -52424575 ^ -1973269920;
                        continue;
                      case 4:
                        this.Engine.SetSelectorWindow(this.SelectorWindow);
                        this.SelectorWindow.MainDispatcher = currentDispatcher;
                        num1 = (int) num3 * 1743244634 ^ -891788867;
                        continue;
                      case 5:
                        num1 = (int) num3 * -653228861 ^ -1317549274;
                        continue;
                      case 6:
                        num1 = (int) num3 * -1182402909 ^ 1675391149;
                        continue;
                      case 7:
                        // ISSUE: reference to a compiler-generated method
                        App.\u003C\u003Ec__DisplayClass70_0.\u202E‪‮‌‍‪⁪‭‫⁪‭‪‎⁯⁭⁮⁪⁭⁮⁯‭‎‌‪⁮⁫‭‭⁯‎‌‪⁯⁮‮⁮⁫‪‮‪‮((Window) this.SelectorWindow, new EventHandler(this.SelectorWindow_Closed));
                        num1 = (int) num3 * -933206366 ^ -947927063;
                        continue;
                      default:
                        goto label_16;
                    }
                  }
                }
                catch (Exception ex)
                {
label_12:
                  int num1 = -2036746848;
                  while (true)
                  {
                    int num2 = -1522170422;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        App.\u003C\u003Ec__DisplayClass70_0.\u200C‫‫‌⁯⁯‌‎‮‎⁬‭⁭‪‫‫‍‍⁭‮‮‮‪⁫​‫​⁬‎‮⁮‫‍‪⁮‪‏‫‮‬‮(App.log, (object) ex);
                        num1 = (int) num3 * -366156408 ^ -912314856;
                        continue;
                      case 2:
                        goto label_12;
                      default:
                        goto label_16;
                    }
                  }
                }
label_16:
                // ISSUE: reference to a compiler-generated method
                App.\u003C\u003Ec__DisplayClass70_0.\u200D‪‫‫‬‫​⁫‏⁭‮⁭‍‎‮‭⁮⁫‍‭⁯‫‏⁬‌‫‮‫‎⁫‪⁫‭‌‭⁮‏‏‌⁭‮();
label_17:
                int num4 = -845905850;
                while (true)
                {
                  int num1 = -1522170422;
                  uint num2;
                  switch ((num2 = (uint) (num4 ^ num1)) % 3U)
                  {
                    case 0:
                      goto label_17;
                    case 1:
                      goto label_19;
                    case 2:
                      num4 = (int) num2 * 410169547 ^ -668514591;
                      continue;
                    default:
                      goto label_15;
                  }
                }
label_15:
                return;
label_19:;
              }));
              num1 = (int) num3 * -871714553 ^ -1780885191;
              continue;
            case 4:
              goto label_17;
            case 5:
              App.\u206B‏‌⁯‍⁭‮‏⁪⁫⁫⁭‏‏‌⁮‎​⁬‮⁫‬‭⁬⁯‪‭⁭‎​⁮‬⁮‎‮⁬‌‍‪‮(this.SelectorThread, ApartmentState.STA);
              App.\u200B‫⁫‍‫‮⁮‍⁯⁯⁭⁫⁮⁮‫‎‍‮‪‫​‭⁫‎‌⁮⁬‍‏‌⁮⁯⁪‬‎‎⁫⁮⁬⁫‮(this.SelectorThread, true);
              num1 = (int) num3 * -1986218623 ^ -1569479549;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_17:;
      }
      catch (Exception ex)
      {
label_11:
        int num1 = -1690968595;
        while (true)
        {
          int num2 = -62409257;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 1041399064 ^ -808215351;
              continue;
            case 1:
              goto label_9;
            case 2:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * 1221478210 ^ -1291665924;
              continue;
            case 3:
              goto label_11;
            case 4:
              num1 = (int) num3 * -1585211079 ^ -299597015;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_9:;
      }
    }

    private void StartSelectorThread()
    {
      try
      {
label_2:
        int num1 = 1683890275;
        while (true)
        {
          int num2 = 2012475597;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_14;
            case 1:
              App.\u202A‏‏​⁫‪⁮⁪⁭⁯‍‬‌‭⁪‮‫‌​‭‫⁮‎‏⁫‌‌‍⁮​⁬⁭‮⁫‪‏‬⁪‫‍‮(this.SelectorThread);
              num1 = (int) num3 * -153866502 ^ 1601606788;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:;
      }
      catch (Exception ex)
      {
label_8:
        int num1 = 448009792;
        while (true)
        {
          int num2 = 2012475597;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              App.\u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮(App.log, (object) ex);
              num1 = (int) num3 * -767519929 ^ -895746863;
              continue;
            case 1:
              num1 = (int) num3 * 716335192 ^ 1391414937;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_8;
            case 4:
              num1 = (int) num3 * -1560172828 ^ 248347906;
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

    private void SelectorWindow_Closed(object sender, EventArgs e)
    {
label_1:
      int num1 = -1705202510;
      while (true)
      {
        int num2 = -20322666;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * 1144249239 ^ -1293128024;
            continue;
          case 1:
            int num5 = !flag ? -1489600316 : (num5 = -1579551578);
            int num6 = (int) num3 * 1292079241;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num4 = App.\u200D‫⁫‎‌‍⁯‬⁪‭⁮‬‭⁯⁮‬⁮‌‏‮‌‭⁫‎‏‍⁪⁮‎‮‏‭‮⁯⁭‮‌⁮‏‌‮((DispatcherObject) this) != null ? 1 : 0;
            break;
          case 3:
            goto label_3;
          case 4:
            this.UnregisterWindow((Window) this.SelectorWindow);
            num1 = -925374929;
            continue;
          case 5:
            this.SelectorWindow = (WindowSelector) null;
            num1 = (int) num3 * -949560566 ^ 1182899240;
            continue;
          case 6:
            num1 = -482741967;
            continue;
          case 7:
            goto label_1;
          case 8:
            if (this.SelectorWindow != null)
            {
              num1 = (int) num3 * 993982559 ^ -172085268;
              continue;
            }
            num4 = 0;
            break;
          case 9:
            int num7 = !App.\u206D⁯‮⁫⁭⁪⁯⁮‍‍⁮⁬​‭‌​⁭‍‮⁭⁯‌‎‮⁮⁬‪‏‪⁪‫⁫⁭‎‪‍‎‭‭‫‮(App.\u200D‫⁫‎‌‍⁯‬⁪‭⁮‬‭⁯⁮‬⁮‌‏‮‌‭⁫‎‏‍⁪⁮‎‮‏‭‮⁯⁭‮‌⁮‏‌‮((DispatcherObject) this)) ? -1030284487 : (num7 = -1518942926);
            int num8 = (int) num3 * 185281348;
            num1 = num7 ^ num8;
            continue;
          case 10:
            num1 = (int) num3 * 720649126 ^ -1035990232;
            continue;
          case 11:
            App.\u206D‮‭‫‮⁫‎⁫‎⁯‌‏‎⁮⁯‎‎‌‍‌‌⁫​⁪⁯‮​‍‮⁪‎⁪‫​‮‏‎‫⁯‎‮(App.\u200D‫⁫‎‌‍⁯‬⁪‭⁮‬‭⁯⁮‬⁮‌‏‮‌‭⁫‎‏‍⁪⁮‎‮‏‭‮⁯⁭‮‌⁮‏‌‮((DispatcherObject) this), (Delegate) new App.EventDelegate(this.SelectorWindow_Closed), new object[2]
            {
              sender,
              (object) e
            });
            num1 = (int) num3 * -1445214988 ^ -738878480;
            continue;
          default:
            goto label_17;
        }
        flag = num4 != 0;
        num1 = -1860541029;
      }
label_17:
      return;
label_3:;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
label_1:
      int num1 = 943678325;
      while (true)
      {
        int num2 = 305343893;
        uint num3;
        bool contentLoaded;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * 814458070 ^ 1366938580;
            continue;
          case 1:
            num1 = (int) num3 * -817478474 ^ -283996594;
            continue;
          case 2:
            int num4 = contentLoaded ? -148642099 : (num4 = -1162294090);
            int num5 = (int) num3 * -1109583106;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -1351740491 ^ -1597003142;
            continue;
          case 5:
            App.\u200C‍⁫​‪‎‫‏⁬⁯‍‍‎​⁬‎‌⁬‍‍‫‭​⁯‭⁬‍‌⁬⁪‌‮⁭‏⁬‍‭⁬‭‮‮((object) this, App.\u200C‍⁬‭⁭⁪‌⁮⁯⁬‎‏⁭⁯⁬‏‏‮‌⁬⁮‫‬​⁯‭​‮⁭‏‫⁯‮⁫‪‌⁮‏‎⁫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3909240186U), UriKind.Relative));
            num1 = (int) num3 * 689491267 ^ -1359803562;
            continue;
          case 6:
            goto label_1;
          case 7:
            App.\u206F⁪‎⁫‎‌⁪‏⁬⁫‍‮‪‮‌⁫⁪‪‭⁫‪⁫‎​⁪‌⁬‍‫​​⁮⁪‪⁫‬‏⁭⁫‎‮((Application) this, new DispatcherUnhandledExceptionEventHandler(this.Application_DispatcherUnhandledException));
            num1 = (int) num3 * 117645175 ^ -452406466;
            continue;
          case 8:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * 1887600475 ^ 1516506807;
            continue;
          case 9:
            num1 = (int) num3 * 328302009 ^ -1186124729;
            continue;
          case 10:
            App.\u202A‏‫​‏‎⁯‏‬‍‏​‏‍‬‍‪‭‌⁬⁫​‪⁪‏‫⁬‏‫‌‍‌⁬⁭⁬‬‬⁯​‪‮((Application) this, new ExitEventHandler(this.Application_Exit));
            num1 = (int) num3 * -1273879181 ^ -1269730634;
            continue;
          case 11:
            this._contentLoaded = true;
            App.\u206B‎‫‭⁯‭⁫‍‭⁫‎‪‪‬‭‪‏‍⁬‌‏‪‮⁮‪⁬⁬⁪‬⁭‮‫⁪‍⁮⁬​⁯​‏‮((Application) this, new StartupEventHandler(this.Application_Startup));
            num1 = 1201060906;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    [STAThread]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public static void Main()
    {
label_1:
      int num1 = 253539835;
      App app;
      while (true)
      {
        int num2 = 1925277125;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            app = new App();
            app.InitializeComponent();
            num1 = (int) num3 * -54560757 ^ -1114997537;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      App.\u206D⁮​⁯⁭⁯‪‬​⁯⁬‫‭‪⁭⁯‏‏‌‪⁯​‫‭‮⁯⁪‏⁭‪‌‌‏⁪⁮⁫​​‬⁬‮((Application) app);
    }

    static ICollection \u200D‌⁫⁫​⁯‍⁮‮⁪‏​⁪‎‭⁫⁭⁪‬‫⁫‮‏‍​⁪‬‭​‍‍‭‏‌⁯‮‭‍‭⁪‮()
    {
      return XmlConfigurator.Configure();
    }

    static void \u206E‎⁯‏‪‏⁯‪⁯⁫‮⁮​‪‭⁮‍​​‌​⁮⁮‪‪⁫‪‫‏‍‏⁭‮‫‬‮‌‮‌‬‮()
    {
      DispatcherHelper.Initialize();
    }

    static void \u202B‮‪‏⁬​⁬⁪‬⁪⁫⁯⁬‍‬‌⁯⁪⁭‏⁬‎‍‭⁯‬⁪​‌‪‪‏‍‬‍⁬‎‎‮⁬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }

    static bool \u200F‪⁯‏⁮⁫‭⁪‫‭⁮​‪‌‏⁬‭⁯‮‎‫​‏​​⁮‫⁮‎‏‪‭‎‪‬‭⁭‎‭‮‮()
    {
      return ViewModelBase.get_IsInDesignModeStatic();
    }

    static CancellationTokenSource \u202A​⁭⁪⁯‬‫‌‎‏‭‬‌‭‬⁭‪​‪‎‏‮​‮⁪‫‎‎‌‬‭‌‮‎⁭⁮‮⁪‬⁬‮()
    {
      return new CancellationTokenSource();
    }

    static CancellationToken \u202A‭⁪⁪⁯⁮‭⁫‪‎‮⁪‍‬⁪⁭‌‬⁮⁯‌⁪⁭‬⁭‍‍‮⁯‎​‍⁭⁯⁫⁮‭⁪‮‎‮([In] CancellationTokenSource obj0)
    {
      return obj0.get_Token();
    }

    static void \u202A‎⁭⁬‮‭⁬‍‪⁭‪‮‏‌‭‪‍‫‪⁮⁬‬​⁯⁯⁮‫​‌⁪⁬‪‎‌‍‌‌‭⁯‎‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u206B‫‎​⁪‏‍‫‏⁭‪⁭‏‏‪⁬‬‌‍‬‫‭‍‏‮⁮​⁭‍⁮‮‫‫‭⁬⁬⁮‬‪⁭‮([In] CancellationTokenSource obj0)
    {
      obj0.Cancel();
    }

    static bool \u200C‭‏​‮​‌‍⁫‌‪‫‍⁯⁬‪‬‪‏⁮⁮⁬⁭‎⁯‫‏⁯‎​‏⁫⁫​​⁫‪⁮‍‬‮([In] string obj0)
    {
      return File.Exists(obj0);
    }

    static Exception \u202C⁪‬‫‏‌‬⁭⁭⁪⁬‌​⁯⁮‍⁬⁬‭‮‌‭​⁪⁯⁯‏⁭⁭⁭⁪‏‌‬⁫​‌⁪‫‮‮([In] DispatcherUnhandledExceptionEventArgs obj0)
    {
      return obj0.Exception;
    }

    static string \u202C⁫‪⁫⁯‌⁯‬‮⁯‫⁪‪‍⁬‎‎⁪‬‪⁫⁭⁪‍​⁯⁪⁫‬⁫⁮⁯‍⁬‍‌‏​‪‎‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static void \u200B‎‎⁭⁫‌⁬⁫‬​⁬‬‪‫‌⁬⁭‍‪‪‭⁮‌‪‌⁭‮‌⁬‪‎‌‌‍⁫‫‫⁯‬‭‮([In] string obj0, [In] string obj1)
    {
      File.WriteAllText(obj0, obj1);
    }

    static string \u200E⁫‎‎⁪‮‬‏‫‭‎⁪⁬‎‮‮​‌⁪‫‍⁬‮⁮⁭⁭⁯‎‮‪‍⁫‍⁬⁯‭‎⁭‮‏‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u206D‪⁮‪⁫‎⁭‪‫‪‪‏‌‪⁪⁬‭‮‪‮​⁮⁪⁪‪⁯⁪‬‬⁭⁯‪⁪⁭‪‎‏⁭‬‮([In] Exception obj0)
    {
      return obj0.StackTrace;
    }

    static string \u206A‮‍⁪⁯⁮⁪⁪⁭​‏⁭⁯‫‪​‎‏‮⁮‏‫⁮‮‬‮‎‪‎‍‫‬⁬‭⁯⁫⁭⁪​⁭‮([In] string obj0, [In] string obj1, [In] string obj2, [In] string obj3)
    {
      return obj0 + obj1 + obj2 + obj3;
    }

    static MessageBoxResult \u206A‭‏‫‮‎‬‎⁯‍‬⁯‎‫‌⁪‍⁮​⁭‍⁯⁯‌‪⁪⁮⁬‎⁫⁪‪⁪⁮‬‌‫‫‌‌‮([In] string obj0, [In] string obj1, [In] MessageBoxButton obj2, [In] MessageBoxImage obj3)
    {
      return MessageBox.Show(obj0, obj1, obj2, obj3);
    }

    static void \u206A‍‬‮⁬​‮⁯​‎‫⁫⁯⁭‏‏‎‭‌⁫⁭⁪‭‭‍⁮⁫⁭‏‍​⁬⁫‭​⁮‪‌⁭⁯‮([In] int obj0)
    {
      Environment.Exit(obj0);
    }

    static void \u202B⁪‌⁫⁬‎‎‮‏‭⁪‫‮‭⁯​‭‎‍‏‏‭‪⁯⁬‭‏‬‏⁫‌‮‪​‪⁪‪‭‫‮‮([In] DispatcherUnhandledExceptionEventArgs obj0, [In] bool obj1)
    {
      obj0.Handled = obj1;
    }

    static Application \u200F‮⁭‎⁮‪⁭‌‍‭‍‫‪‎‭⁪⁫‪‍‭‭‫‬‬⁪‮‌‫‮⁪⁮⁫‫⁬⁯‎⁮‎‫‭‮()
    {
      return Application.Current;
    }

    static Dispatcher \u200F​‫⁮‎‪‎‌‎‪‬⁯‭‮‪‫‌⁬‌‏⁮‮​‏‬​​⁯⁭‪⁭‫‬‭‎⁯‌⁪‏⁫‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u200D‌‮⁭‬⁮⁮‬‏‫⁭⁬‍⁫‫⁫‪‍‪‪‫⁮‫⁪‮‏‎‪‌​⁭⁫‬‭‫⁯‬⁯⁯⁮‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static void \u202C⁯‫​⁪‎​‫‬‍​⁪‭‏‍​‭‌⁬‏‭‎⁮‮‪‮⁪‪⁫⁭​⁪‏‭​⁯⁭‪‍‎‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202A‏‍⁪‪‌‎⁭⁯‎⁮⁪‭‭‭‎⁮‫‬⁭⁬‪‭⁪‌‬⁯⁮‍‏‪‍⁫‭‎⁮‌‮‭‫‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static Thread \u200F‍⁯‏⁬‫‪⁮‌‭​‍⁭⁫‏​⁫‏‌⁯⁫‍⁪‫⁯‮‌‮‎⁫‫⁮‮⁯⁮⁫‮‬‮‫‮([In] ThreadStart obj0)
    {
      return new Thread(obj0);
    }

    static void \u206B‏‌⁯‍⁭‮‏⁪⁫⁫⁭‏‏‌⁮‎​⁬‮⁫‬‭⁬⁯‪‭⁭‎​⁮‬⁮‎‮⁬‌‍‪‮([In] Thread obj0, [In] ApartmentState obj1)
    {
      obj0.SetApartmentState(obj1);
    }

    static void \u200B‫⁫‍‫‮⁮‍⁯⁯⁭⁫⁮⁮‫‎‍‮‪‫​‭⁫‎‌⁮⁬‍‏‌⁮⁯⁪‬‎‎⁫⁮⁬⁫‮([In] Thread obj0, [In] bool obj1)
    {
      obj0.IsBackground = obj1;
    }

    static void \u202A‏‏​⁫‪⁮⁪⁭⁯‍‬‌‭⁪‮‫‌​‭‫⁮‎‏⁫‌‌‍⁮​⁬⁭‮⁫‪‏‬⁪‫‍‮([In] Thread obj0)
    {
      obj0.Start();
    }

    static string \u200F‏‬‬‪⁭‎‮‫⁯‏⁮⁬‮‏‮‌⁭​⁮‪‏‌‭‪‬‫‮⁭⁮⁪‬‏‫‪‎‎‎⁮‮‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static bool \u200D​‏‮‭‮‪⁮‬‬‭‫⁮‏‎​⁪⁫⁯‫⁫⁪‮‮⁭‌⁯‍⁫‬⁮⁪‏‍⁫‭‬⁯‭⁬‮([In] Thread obj0)
    {
      return obj0.IsAlive;
    }

    static System.Threading.ThreadState \u202B‮‪⁯‬‭⁭‏‫⁯⁬‭⁫‏‏‮‭⁫‍‬⁭​⁭‏‪‏⁫‫⁫⁬‪‎‪‬⁯⁯‮‬‪‏‮([In] Thread obj0)
    {
      return obj0.ThreadState;
    }

    static void \u202E‭⁮‏‫‪⁫‬​⁭⁬‪‫⁮​⁯‎‬⁭‫‮‫‫‪‌⁯‮‬⁫‍‮‬‍‌‎‌‫⁪‍‍‮([In] Thread obj0)
    {
      obj0.Abort();
    }

    static void \u202D⁬‮‭‏‬‌⁬⁫‮⁫⁭‏‍‬‌‍‏‫⁫‫‎⁬⁯‏‪‎⁮‎‭‬⁫​⁫‎‍‪‏‪‮([In] Window obj0, [In] EventHandler obj1)
    {
      obj0.Closed += obj1;
    }

    static Dispatcher \u200D‫⁫‎‌‍⁯‬⁪‭⁮‬‭⁯⁮‬⁮‌‏‮‌‭⁫‎‏‍⁪⁮‎‮‏‭‮⁯⁭‮‌⁮‏‌‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static bool \u206D⁯‮⁫⁭⁪⁯⁮‍‍⁮⁬​‭‌​⁭‍‮⁭⁯‌‎‮⁮⁬‪‏‪⁪‫⁫⁭‎‪‍‎‭‭‫‮([In] Dispatcher obj0)
    {
      return obj0.CheckAccess();
    }

    static object \u206D‮‭‫‮⁫‎⁫‎⁯‌‏‎⁮⁯‎‎‌‍‌‌⁫​⁪⁯‮​‍‮⁪‎⁪‫​‮‏‎‫⁯‎‮([In] Dispatcher obj0, [In] Delegate obj1, [In] object[] obj2)
    {
      return obj0.Invoke(obj1, obj2);
    }

    static string \u202A⁮⁯⁫‌‌​‮‌‫⁬‎‫‍‎⁫‬‪⁮⁭‪‫‭⁭⁬‍‌⁫⁯‏⁬‫‫⁬‌‎‮‍‪‏‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static void \u206B‎‫‭⁯‭⁫‍‭⁫‎‪‪‬‭‪‏‍⁬‌‏‪‮⁮‪⁬⁬⁪‬⁭‮‫⁪‍⁮⁬​⁯​‏‮([In] Application obj0, [In] StartupEventHandler obj1)
    {
      obj0.Startup += obj1;
    }

    static void \u206F⁪‎⁫‎‌⁪‏⁬⁫‍‮‪‮‌⁫⁪‪‭⁫‪⁫‎​⁪‌⁬‍‫​​⁮⁪‪⁫‬‏⁭⁫‎‮([In] Application obj0, [In] DispatcherUnhandledExceptionEventHandler obj1)
    {
      obj0.DispatcherUnhandledException += obj1;
    }

    static void \u202A‏‫​‏‎⁯‏‬‍‏​‏‍‬‍‪‭‌⁬⁫​‪⁪‏‫⁬‏‫‌‍‌⁬⁭⁬‬‬⁯​‪‮([In] Application obj0, [In] ExitEventHandler obj1)
    {
      obj0.Exit += obj1;
    }

    static Uri \u200C‍⁬‭⁭⁪‌⁮⁯⁬‎‏⁭⁯⁬‏‏‮‌⁬⁮‫‬​⁯‭​‮⁭‏‫⁯‮⁫‪‌⁮‏‎⁫‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200C‍⁫​‪‎‫‏⁬⁯‍‍‎​⁬‎‌⁬‍‍‫‭​⁯‭⁬‍‌⁬⁪‌‮⁭‏⁬‍‭⁬‭‮‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static int \u206D⁮​⁯⁭⁯‪‬​⁯⁬‫‭‪⁭⁯‏‏‌‪⁯​‫‭‮⁯⁪‏⁭‪‌‌‏⁪⁮⁫​​‬⁬‮([In] Application obj0)
    {
      return obj0.Run();
    }

    static MethodBase \u206F⁭‫⁫⁮‎‬⁫⁫⁭‏​‬‫‭‮⁮⁬‭⁫⁮‭‪⁯‭‪⁪​‭‭⁬‏‮⁮⁭‏⁯‭‍‫‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206B‫⁬‎⁮⁫⁪‫⁫⁬⁪‍‭‍⁫⁫‬‭⁮‮​⁭⁫‎‍⁪‮⁬⁪‮⁯‬⁯⁪⁭⁫⁯‫‬‮‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206E‍‬‭‍‮‬​‌‍‏‎‫​​​‌⁮⁮⁯⁫‬‏⁮‍⁬‎‍⁪⁯‍⁪‭⁯‬‍‎⁪‌‍‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static object \u200B‏​⁬‭⁮⁮⁫‬⁫⁫‬‍‫‪​⁫⁯‭‫‍⁬⁭‎‬⁯⁮‬⁬‮‮‍‬‍‬‍‮⁬⁮‪‮()
    {
      return new object();
    }

    static void \u206D‫​⁯‮​‬‪⁮⁯‎⁬‏‎⁮⁮‏‎‮‎‎‮‮⁪‭‏⁫‮‮⁪⁪‫‪⁮‭‭‌​​⁬‮([In] Window obj0)
    {
      obj0.Show();
    }

    static void \u202E‬⁮⁬‫‍‬⁫⁫⁯⁮‏‍​‫⁫⁬‌⁯‭‮‪‌⁮‮‌‏​‌⁫⁫‎‭⁬⁭‏⁮‪‪⁬‮()
    {
      Dispatcher.Run();
    }

    static void \u206F‭​‎⁬‌‏⁫​‬⁬⁭‮⁫‏‌⁮⁭‭⁪‬‍⁫‌⁯‪‌‍‭⁮⁯⁫⁪‭⁯⁭‌‬⁭‫‮([In] Window obj0)
    {
      obj0.Close();
    }

    private delegate void EventDelegate(object sender, EventArgs e);
  }
}
