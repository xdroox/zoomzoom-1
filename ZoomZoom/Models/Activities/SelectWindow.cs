// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.SelectWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using ZoomZoom.Views;

namespace ZoomZoom.Models.Activities
{
  internal class SelectWindow : ActivityBase
  {
    private ZoomWindow selectedWindow = (ZoomWindow) null;
    private ActivityState selectorStatus = ActivityState.Pending;
    private WindowSelector selectorWindow = (WindowSelector) null;
    private bool highlightingPreviousEnabled = false;
    private EventHandler selectedHandler = (EventHandler) null;
    private EventHandler canceledHandler = (EventHandler) null;
    private ZoomWindow engineView = (ZoomWindow) null;
    private List<ZoomWindowType> selectableTypes = (List<ZoomWindowType>) null;

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Activity;
label_1:
        int num1 = -2117597015;
        while (true)
        {
          int num2 = -977846987;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -2042674547 ^ -1256860975;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public ZoomWindow SelectedWindow
    {
      get
      {
        ZoomWindow selectedWindow = this.selectedWindow;
label_1:
        int num1 = 131576840;
        while (true)
        {
          int num2 = 136169100;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 218593723 ^ 801077514;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedWindow;
      }
      set
      {
label_1:
        int num1 = -1287805534;
        while (true)
        {
          int num2 = -799965383;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.selectedWindow = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(406716241U));
              num1 = (int) num3 * 745044522 ^ 12656833;
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

    public WindowSelector SelectorWindow
    {
      get
      {
label_1:
        int num1 = -1812358080;
        WindowSelector selectorWindow;
        while (true)
        {
          int num2 = -1115420372;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              selectorWindow = this.selectorWindow;
              num1 = (int) num3 * -1283105724 ^ 1883485284;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectorWindow;
      }
      private set
      {
label_1:
        int num1 = -1812346064;
        while (true)
        {
          int num2 = -1571657603;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.selectorWindow = value;
              num1 = (int) num3 * 1822549876 ^ 859871513;
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

    public ActivityState SelectorStatus
    {
      get
      {
        ActivityState selectorStatus = this.selectorStatus;
label_1:
        int num1 = 1026557416;
        while (true)
        {
          int num2 = 1295283521;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1181416054 ^ -1988178232;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return selectorStatus;
      }
      set
      {
        this.selectorStatus = value;
      }
    }

    public bool HighlightingPreviousEnabled
    {
      get
      {
        bool highlightingPreviousEnabled = this.highlightingPreviousEnabled;
label_1:
        int num1 = 2134019522;
        while (true)
        {
          int num2 = 1751781627;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1430021821 ^ 1524203011;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return highlightingPreviousEnabled;
      }
      set
      {
        this.highlightingPreviousEnabled = value;
      }
    }

    public ZoomWindow EngineView
    {
      get
      {
label_1:
        int num1 = 636280573;
        ZoomWindow engineView;
        while (true)
        {
          int num2 = 2057687523;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -719472595 ^ 1826366090;
              continue;
            case 2:
              engineView = this.engineView;
              num1 = (int) num3 * 1261007502 ^ -2051252998;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return engineView;
      }
      set
      {
label_1:
        int num1 = 560447917;
        while (true)
        {
          int num2 = 643958004;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.engineView = value;
              num1 = (int) num3 * -1762641170 ^ -1917500478;
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

    public List<ZoomWindowType> SelectableTypes
    {
      get
      {
label_1:
        int num1 = 393545795;
        List<ZoomWindowType> selectableTypes;
        while (true)
        {
          int num2 = 6739478;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 263761168 ^ 1249992424;
              continue;
            case 1:
              selectableTypes = this.selectableTypes;
              num1 = (int) num3 * 1798583569 ^ 1480125863;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return selectableTypes;
      }
      set
      {
        this.selectableTypes = value;
      }
    }

    public SelectWindow(List<ZoomWindowType> windowTypes = null)
    {
      this.Options.DisableHighlighting = true;
      this.SelectableTypes = windowTypes;
    }

    internal override bool Valid()
    {
      bool flag = true;
label_1:
      int num1 = -199229978;
      while (true)
      {
        int num2 = -1186543407;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -516671174 ^ 812890757;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = -1816164073;
      while (true)
      {
        int num2 = -1180086681;
        uint num3;
        bool isLocked;
        bool disableHighlighting;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 59U)
        {
          case 0:
            this.Result = (object) this.SelectedWindow;
            num1 = (int) num3 * -1791304793 ^ -493334673;
            continue;
          case 1:
            int num6 = this.SelectedWindow == null ? -1235916629 : (num6 = -529346673);
            int num7 = (int) num3 * 1193980415;
            num1 = num6 ^ num7;
            continue;
          case 2:
            num1 = (int) num3 * 905905448 ^ 156795754;
            continue;
          case 3:
            this.Engine.Settings.DisplayHighlightWindows = false;
            num1 = (int) num3 * 309397217 ^ -1168949915;
            continue;
          case 4:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1876184640U));
            num1 = (int) num3 * 1465582512 ^ 1025322774;
            continue;
          case 5:
            int num8 = flag3 ? 990005026 : (num8 = 955570140);
            int num9 = (int) num3 * -875971037;
            num1 = num8 ^ num9;
            continue;
          case 6:
            num1 = (int) num3 * 87414397 ^ -1272378538;
            continue;
          case 7:
            int num10 = !flag5 ? -356027363 : (num10 = -1856566176);
            int num11 = (int) num3 * 1234501331;
            num1 = num10 ^ num11;
            continue;
          case 8:
            num1 = (int) num3 * 1874224190 ^ -1847418722;
            continue;
          case 9:
            isLocked = this.SelectorWindow.IsLocked;
            num1 = -2051816777;
            continue;
          case 10:
            this.Engine.Settings.DisplayHighlightWindows = true;
            num1 = (int) num3 * -78075499 ^ 305095097;
            continue;
          case 11:
            num1 = -35437090;
            continue;
          case 12:
            this.SelectorWindow = this.Engine.SelectorWindow;
            num1 = -428785241;
            continue;
          case 13:
            if (!this.SelectorWindow.IsLocked)
            {
              num4 = 0;
              goto label_26;
            }
            else
            {
              num1 = (int) num3 * -1591247455 ^ 398880437;
              continue;
            }
          case 14:
            num1 = (int) num3 * 662720760 ^ -1528019409;
            continue;
          case 15:
            flag4 = this.SelectorStatus == ActivityState.InProgress;
            num1 = -1200176296;
            continue;
          case 16:
            goto label_1;
          case 17:
            this.canceledHandler = (EventHandler) ((s, fe) =>
            {
label_1:
              int num2 = 562113374;
              object activityLocker;
              while (true)
              {
                int num3 = 334096044;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    activityLocker = ActivityBase.activityLocker;
                    num2 = (int) num4 * -585814388 ^ 2089917512;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_4:
              bool flag = false;
              try
              {
                SelectWindow.\u200D‫‫​‎⁮‎‫⁬‬⁬‬‍‍‫⁬⁬‎⁭‬⁭‏‪‭⁪⁮⁭‌⁬‪⁬‮‪⁫⁪⁭⁭‬‌‮‮(activityLocker, ref flag);
label_6:
                int num3 = 1682740725;
                while (true)
                {
                  int num4 = 334096044;
                  uint num5;
                  switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                  {
                    case 0:
                      goto label_6;
                    case 1:
                      this.SelectorStatus = ActivityState.Canceled;
                      num3 = (int) num5 * 1811274502 ^ -1340188288;
                      continue;
                    case 2:
                      num3 = (int) num5 * 1650355484 ^ -1430472113;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
              finally
              {
                if (flag)
                {
label_11:
                  int num3 = 2046044950;
                  while (true)
                  {
                    int num4 = 334096044;
                    uint num5;
                    switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                    {
                      case 0:
                        goto label_11;
                      case 1:
                        SelectWindow.\u206D‮‫‍⁯⁬​‭⁪‏‫⁫‍‬⁮⁮‎⁪‎⁫‪‎‫‍⁪‍‬‫⁬‫​​‪‌‏‬⁭​‫‪‮(activityLocker);
                        num3 = (int) num5 * -34423053 ^ 774250847;
                        continue;
                      default:
                        goto label_15;
                    }
                  }
                }
label_15:;
              }
label_16:
              this.SelectorWindow.Canceled -= this.canceledHandler;
label_17:
              int num6 = 53476301;
              while (true)
              {
                int num3 = 334096044;
                uint num4;
                switch ((num4 = (uint) (num6 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_19;
                  case 1:
                    this.SelectorWindow.WindowSelected -= this.selectedHandler;
                    num6 = (int) num4 * -1543065178 ^ -454642969;
                    continue;
                  case 2:
                    goto label_17;
                  default:
                    goto label_13;
                }
              }
label_13:
              return;
label_19:;
            });
            int num17 = this.EngineView == null ? -1529908934 : (num17 = -1274577767);
            int num18 = (int) num3 * -799432959;
            num1 = num17 ^ num18;
            continue;
          case 18:
            int num19;
            num1 = num19 = this.EngineView == null ? -641130078 : (num19 = -18106994);
            continue;
          case 19:
            int num20 = flag4 ? -856018626 : (num20 = -2028856887);
            int num21 = (int) num3 * 366655890;
            num1 = num20 ^ num21;
            continue;
          case 20:
            this.highlightingPreviousEnabled = this.Engine.Settings.DisplayHighlightWindows;
            num1 = (int) num3 * -368760869 ^ -21933424;
            continue;
          case 21:
          case 28:
            flag5 = this.ContinueExecution();
            num1 = -2040949817;
            continue;
          case 22:
            num1 = (int) num3 * -382266556 ^ 1608490772;
            continue;
          case 23:
            int num22 = flag1 ? -991521250 : (num22 = -1688636500);
            int num23 = (int) num3 * 1393990086;
            num1 = num22 ^ num23;
            continue;
          case 24:
            num1 = (int) num3 * -1345120224 ^ -903051962;
            continue;
          case 25:
            this.ReportProgress(SelectWindow.\u200F‎⁯‫‎‎⁯⁯‪‌⁭​‫‮​‫‬⁭⁭‪‬⁭⁮⁬‭⁬‪⁭‫⁫‪⁭⁭⁯‎‎⁫‮⁮‏‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(88369313U), (object) this.Name), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3233434380U));
            disableHighlighting = this.Options.DisableHighlighting;
            num1 = (int) num3 * 111083343 ^ -624886646;
            continue;
          case 26:
            this.SelectorStatus = ActivityState.InProgress;
            num1 = (int) num3 * -697071446 ^ 209315738;
            continue;
          case 27:
            this.selectedHandler = (EventHandler) ((s, fe) =>
            {
              object activityLocker = ActivityBase.activityLocker;
              bool flag = false;
              try
              {
                SelectWindow.\u200D‫‫​‎⁮‎‫⁬‬⁬‬‍‍‫⁬⁬‎⁭‬⁭‏‪‭⁪⁮⁭‌⁬‪⁬‮‪⁫⁪⁭⁭‬‌‮‮(activityLocker, ref flag);
label_2:
                int num2 = 915068180;
                while (true)
                {
                  int num3 = 1140669234;
                  uint num4;
                  switch ((num4 = (uint) (num2 ^ num3)) % 5U)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      num2 = (int) num4 * -956081913 ^ 540633190;
                      continue;
                    case 2:
                      num2 = (int) num4 * -23508656 ^ -129084577;
                      continue;
                    case 3:
                      goto label_11;
                    case 4:
                      this.selectedWindow = this.SelectorWindow.SelectedWindow;
                      this.selectorStatus = ActivityState.Completed;
                      num2 = (int) num4 * 654940263 ^ 1815700066;
                      continue;
                    default:
                      goto label_7;
                  }
                }
label_7:
                return;
label_11:;
              }
              finally
              {
                if (flag)
                {
label_9:
                  int num2 = 1869759156;
                  while (true)
                  {
                    int num3 = 1140669234;
                    uint num4;
                    switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                    {
                      case 1:
                        SelectWindow.\u206D‮‫‍⁯⁬​‭⁪‏‫⁫‍‬⁮⁮‎⁪‎⁫‪‎‫‍⁪‍‬‫⁬‫​​‪‌‏‬⁭​‫‪‮(activityLocker);
                        num2 = (int) num4 * -1728804563 ^ 1458943334;
                        continue;
                      case 2:
                        goto label_9;
                      default:
                        goto label_13;
                    }
                  }
                }
label_13:;
              }
            });
            num1 = (int) num3 * -205153215 ^ -1762822557;
            continue;
          case 29:
            num1 = (int) num3 * 1928897891 ^ -847366563;
            continue;
          case 30:
            num1 = (int) num3 * -1901482797 ^ 241028152;
            continue;
          case 31:
            num1 = -975813945;
            continue;
          case 32:
            this.UnlockSelectorWindow();
            num1 = (int) num3 * 1056225390 ^ 287069739;
            continue;
          case 33:
            num1 = (int) num3 * -366681935 ^ 401037835;
            continue;
          case 34:
            num4 = this.SelectorWindow.LockingObject != this ? 1 : 0;
            goto label_26;
          case 35:
            num1 = -1530887420;
            continue;
          case 36:
            WindowHelper.RestoreWindow(this.EngineView.Handle);
            num1 = (int) num3 * -447232576 ^ -1106651390;
            continue;
          case 37:
            num1 = (int) num3 * -1739245408 ^ -880887007;
            continue;
          case 38:
            num1 = (int) num3 * 8204641 ^ 1390133181;
            continue;
          case 39:
            SelectWindow.\u206F‮‪⁬⁬‍⁫⁯⁬‭⁫⁪​⁭‌⁬⁪‮‌‭‎‪​‬⁬⁫‭‏​⁬⁮⁯⁭‬⁫‎‪⁫‏‮(100);
            num1 = (int) num3 * -1839203226 ^ -896443376;
            continue;
          case 40:
            num1 = (int) num3 * -36946181 ^ 359572019;
            continue;
          case 41:
            num1 = (int) num3 * -2018245195 ^ -1320008728;
            continue;
          case 42:
            num5 = this.highlightingPreviousEnabled ? 1 : 0;
            break;
          case 43:
            this.EngineView = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
            num1 = (int) num3 * 231644799 ^ -1318429656;
            continue;
          case 44:
            num1 = (int) num3 * -1468581012 ^ 1864313052;
            continue;
          case 45:
            if (this.Options.DisableHighlighting)
            {
              num1 = -1670234594;
              continue;
            }
            num5 = 0;
            break;
          case 46:
            SelectWindow.\u206C‫‬⁫⁯‍⁮‫⁬⁪⁮‮⁫‭‫‍‭⁯‬⁯‎⁯⁯⁫‎​⁪‭⁭‫⁪​‫⁫‬‫‫⁪‏‪‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1422766334U), new object[0]);
            num1 = (int) num3 * -111755536 ^ -312127732;
            continue;
          case 47:
            int num24 = disableHighlighting ? -1789539970 : (num24 = -1389630256);
            int num25 = (int) num3 * -168956081;
            num1 = num24 ^ num25;
            continue;
          case 48:
            this.SetActivityState(ActivityState.Completed, SelectWindow.\u200F‎⁯‫‎‎⁯⁯‪‌⁭​‫‮​‫‬⁭⁭‪‬⁭⁮⁬‭⁬‪⁭‫⁫‪⁭⁭⁯‎‎⁫‮⁮‏‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3081420434U), this.SelectedWindow != null ? (object) this.SelectedWindow.ZoomWindowType.ToString() : (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2063927607U)));
            num1 = -2068498437;
            continue;
          case 49:
            flag2 = this.SelectorStatus == ActivityState.Completed;
            num1 = -203989536;
            continue;
          case 50:
            int num26 = !isLocked ? 1820314354 : (num26 = 831862071);
            int num27 = (int) num3 * -1810502237;
            num1 = num26 ^ num27;
            continue;
          case 51:
            int num28 = !flag2 ? -1746658727 : (num28 = -243378332);
            int num29 = (int) num3 * 1965820658;
            num1 = num28 ^ num29;
            continue;
          case 52:
            num1 = (int) num3 * 2129930691 ^ 667124727;
            continue;
          case 53:
            // ISSUE: method pointer
            SelectWindow.\u202B‌​⁭‪‮⁮⁫‍‌⁮​‭‎⁯⁫‭‌‎‌‪‎‮‭⁪‌⁫‪‫‬⁪⁪⁬‫⁭⁭‮‪⁯‪‮(SelectWindow.\u202E⁫⁮⁭​⁯‍‍‮‪‪⁬‭‬‬⁮‫⁭⁭‫‪⁫⁯‭⁪‫‬⁪‮‌​‏‍‏‏⁯⁯‮‫‍‮((DispatcherObject) this.SelectorWindow), new Action((object) this, __methodptr(\u003CExecuteLogic\u003Eb__30_2)));
            num1 = (int) num3 * 1422873533 ^ 1543425084;
            continue;
          case 54:
            WindowHelper.MinimizeWindow(this.EngineView.Handle);
            num1 = (int) num3 * 177834030 ^ -2003901886;
            continue;
          case 55:
            num1 = (int) num3 * 1560889922 ^ -772874503;
            continue;
          case 56:
            num1 = (int) num3 * -1688513703 ^ 197818450;
            continue;
          case 57:
            flag3 = this.SelectorStatus == ActivityState.Pending;
            num1 = -1017452939;
            continue;
          case 58:
            goto label_15;
          default:
            goto label_3;
        }
        int num30;
        num1 = num30 = num5 == 0 ? -141858212 : (num30 = -709446437);
        continue;
label_26:
        flag1 = num4 != 0;
        num1 = -721875828;
      }
label_3:
      return;
label_15:;
    }

    private void UnlockSelectorWindow()
    {
      // ISSUE: method pointer
      SelectWindow.\u202B‌​⁭‪‮⁮⁫‍‌⁮​‭‎⁯⁫‭‌‎‌‪‎‮‭⁪‌⁫‪‫‬⁪⁪⁬‫⁭⁭‮‪⁯‪‮(SelectWindow.\u202E⁫⁮⁭​⁯‍‍‮‪‪⁬‭‬‬⁮‫⁭⁭‫‪⁫⁯‭⁪‫‬⁪‮‌​‏‍‏‏⁯⁯‮‫‍‮((DispatcherObject) this.SelectorWindow), new Action((object) this, __methodptr(\u003CUnlockSelectorWindow\u003Eb__31_0)));
    }

    private void DetachEvents()
    {
      this.SelectorWindow.WindowSelected -= new EventHandler(this.SelectorWindow_WindowSelected);
label_1:
      int num1 = -388090823;
      while (true)
      {
        int num2 = -1889723646;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            this.SelectorWindow.Canceled -= new EventHandler(this.SelectorWindow_Canceled);
            num1 = (int) num3 * -1476522291 ^ -2030771013;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -833107172 ^ 919264202;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void SelectorWindow_WindowSelected(object sender, EventArgs e)
    {
label_1:
      int num1 = -1067402448;
      while (true)
      {
        int num2 = -365927325;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = (int) num3 * -812074735 ^ -553615944;
            continue;
          case 1:
            flag = !SelectWindow.\u206E‎⁪‮‎‪‌‪⁬⁫⁪‌⁫‎‫‎‭⁭⁫‭⁯⁪‪‌‮‌‌⁫⁯⁬⁫⁪‏⁪⁫​‌‮⁫‍‮(SelectWindow.\u202E⁫⁮⁭​⁯‍‍‮‪‪⁬‭‬‬⁮‫⁭⁭‫‪⁫⁯‭⁪‫‬⁪‮‌​‏‍‏‏⁯⁯‮‫‍‮((DispatcherObject) SelectWindow.\u200B‍‍⁭⁯‎⁪⁫​⁭‫⁯‮‪‍‍‮⁮‬‌⁬​​‭‬⁭‍‬⁭‮⁯⁫​⁬‌‪⁪‪⁪‮()));
            num1 = (int) num3 * -360992196 ^ -1047124981;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 1098460184 ^ -1825477339;
            continue;
          case 4:
            this.SelectedWindow = this.SelectorWindow.SelectedWindow;
            SelectWindow.\u202A⁬⁭‫‬‭⁪​‪‭‫‍‌‫‏‭⁮‬‏‏⁯⁫⁬‪‫‏⁯⁫‌‌‏⁭​⁫⁮⁫‪‪‏⁯‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(484932172U), (object) this.SelectedWindow);
            num1 = (int) num3 * 2035918590 ^ 975345;
            continue;
          case 5:
            this.UnlockSelectorWindow();
            num1 = (int) num3 * 1720635930 ^ 559807658;
            continue;
          case 6:
            int num4 = flag ? 1292863800 : (num4 = 1960101915);
            int num5 = (int) num3 * 554759806;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = (int) num3 * -1320764653 ^ 1575718761;
            continue;
          case 8:
            num1 = (int) num3 * 900846856 ^ 1859592796;
            continue;
          case 9:
            SelectWindow.\u206B‎‍⁯⁫‎⁪‬‏‏⁭‏⁮⁮⁬⁯⁪⁯⁬‌​⁬⁫‍‫⁫⁮⁭‏‫‬‮⁯‎⁯⁪⁫‌⁫⁪‮(SelectWindow.\u202E⁫⁮⁭​⁯‍‍‮‪‪⁬‭‬‬⁮‫⁭⁭‫‪⁫⁯‭⁪‫‬⁪‮‌​‏‍‏‏⁯⁯‮‫‍‮((DispatcherObject) SelectWindow.\u200B‍‍⁭⁯‎⁪⁫​⁭‫⁯‮‪‍‍‮⁮‬‌⁬​​‭‬⁭‍‬⁭‮⁯⁫​⁬‌‪⁪‪⁪‮()), (Delegate) new SelectWindow.SelectorWindowCallback(this.SelectorWindow_WindowSelected), new object[2]
            {
              sender,
              (object) e
            });
            num1 = (int) num3 * 715304712 ^ -1364373685;
            continue;
          case 10:
            this.SelectorStatus = ActivityState.Completed;
            num1 = -1741834722;
            continue;
          case 11:
            goto label_3;
          case 12:
            num1 = (int) num3 * -1879223403 ^ -2079850964;
            continue;
          case 13:
            this.SetActivityState(ActivityState.Canceled, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(822453702U));
            this.DetachEvents();
            num1 = (int) num3 * -1609950296 ^ 1152725723;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    private void SelectorWindow_Canceled(object sender, EventArgs e)
    {
label_1:
      int num1 = 487581875;
      while (true)
      {
        int num2 = 1376908936;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = 1520838693;
            continue;
          case 1:
            this.SelectorStatus = ActivityState.Canceled;
            num1 = (int) num3 * 409396137 ^ -171630989;
            continue;
          case 2:
            num1 = (int) num3 * 1192219897 ^ 1929003431;
            continue;
          case 3:
            int num4 = SelectWindow.\u206E‎⁪‮‎‪‌‪⁬⁫⁪‌⁫‎‫‎‭⁭⁫‭⁯⁪‪‌‮‌‌⁫⁯⁬⁫⁪‏⁪⁫​‌‮⁫‍‮(SelectWindow.\u202E⁫⁮⁭​⁯‍‍‮‪‪⁬‭‬‬⁮‫⁭⁭‫‪⁫⁯‭⁪‫‬⁪‮‌​‏‍‏‏⁯⁯‮‫‍‮((DispatcherObject) SelectWindow.\u200B‍‍⁭⁯‎⁪⁫​⁭‫⁯‮‪‍‍‮⁮‬‌⁬​​‭‬⁭‍‬⁭‮⁯⁫​⁬‌‪⁪‪⁪‮())) ? -140163176 : (num4 = -574851304);
            int num5 = (int) num3 * 1136036376;
            num1 = num4 ^ num5;
            continue;
          case 4:
            this.SetActivityState(ActivityState.Canceled, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2777227809U));
            num1 = (int) num3 * 807259397 ^ 518900014;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 455191273 ^ -607144077;
            continue;
          case 7:
            goto label_1;
          case 8:
            this.DetachEvents();
            num1 = (int) num3 * -2111912148 ^ -1729885754;
            continue;
          case 9:
            SelectWindow.\u206B‎‍⁯⁫‎⁪‬‏‏⁭‏⁮⁮⁬⁯⁪⁯⁬‌​⁬⁫‍‫⁫⁮⁭‏‫‬‮⁯‎⁯⁪⁫‌⁫⁪‮(SelectWindow.\u202E⁫⁮⁭​⁯‍‍‮‪‪⁬‭‬‬⁮‫⁭⁭‫‪⁫⁯‭⁪‫‬⁪‮‌​‏‍‏‏⁯⁯‮‫‍‮((DispatcherObject) SelectWindow.\u200B‍‍⁭⁯‎⁪⁫​⁭‫⁯‮‪‍‍‮⁮‬‌⁬​​‭‬⁭‍‬⁭‮⁯⁫​⁬‌‪⁪‪⁪‮()), (Delegate) new SelectWindow.SelectorWindowCallback(this.SelectorWindow_Canceled), new object[2]
            {
              sender,
              (object) e
            });
            num1 = (int) num3 * 195705159 ^ 1340544524;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    static string \u200F‎⁯‫‎‎⁯⁯‪‌⁭​‫‮​‫‬⁭⁭‪‬⁭⁮⁬‭⁬‪⁭‫⁫‪⁭⁭⁯‎‎⁫‮⁮‏‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u206C‫‬⁫⁯‍⁮‫⁬⁪⁮‮⁫‭‫‍‭⁯‬⁯‎⁯⁯⁫‎​⁪‭⁭‫⁪​‫⁫‬‫‫⁪‏‪‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.InfoFormat(obj1, obj2);
    }

    static Dispatcher \u202E⁫⁮⁭​⁯‍‍‮‪‪⁬‭‬‬⁮‫⁭⁭‫‪⁫⁯‭⁪‫‬⁪‮‌​‏‍‏‏⁯⁯‮‫‍‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u202B‌​⁭‪‮⁮⁫‍‌⁮​‭‎⁯⁫‭‌‎‌‪‎‮‭⁪‌⁫‪‫‬⁪⁪⁬‫⁭⁭‮‪⁯‪‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static void \u206F‮‪⁬⁬‍⁫⁯⁬‭⁫⁪​⁭‌⁬⁪‮‌‭‎‪​‬⁬⁫‭‏​⁬⁮⁯⁭‬⁫‎‪⁫‏‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static Application \u200B‍‍⁭⁯‎⁪⁫​⁭‫⁯‮‪‍‍‮⁮‬‌⁬​​‭‬⁭‍‬⁭‮⁯⁫​⁬‌‪⁪‪⁪‮()
    {
      return Application.Current;
    }

    static bool \u206E‎⁪‮‎‪‌‪⁬⁫⁪‌⁫‎‫‎‭⁭⁫‭⁯⁪‪‌‮‌‌⁫⁯⁬⁫⁪‏⁪⁫​‌‮⁫‍‮([In] Dispatcher obj0)
    {
      return obj0.CheckAccess();
    }

    static object \u206B‎‍⁯⁫‎⁪‬‏‏⁭‏⁮⁮⁬⁯⁪⁯⁬‌​⁬⁫‍‫⁫⁮⁭‏‫‬‮⁯‎⁯⁪⁫‌⁫⁪‮([In] Dispatcher obj0, [In] Delegate obj1, [In] object[] obj2)
    {
      return obj0.Invoke(obj1, obj2);
    }

    static void \u202A⁬⁭‫‬‭⁪​‪‭‫‍‌‫‏‭⁮‬‏‏⁯⁫⁬‪‫‏⁯⁫‌‌‏⁭​⁫⁮⁫‪‪‏⁯‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u200D‫‫​‎⁮‎‫⁬‬⁬‬‍‍‫⁬⁬‎⁭‬⁭‏‪‭⁪⁮⁭‌⁬‪⁬‮‪⁫⁪⁭⁭‬‌‮‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206D‮‫‍⁯⁬​‭⁪‏‫⁫‍‬⁮⁮‎⁪‎⁫‪‎‫‍⁪‍‬‫⁬‫​​‪‌‏‬⁭​‫‪‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    private delegate void SelectorWindowCallback(object sender, EventArgs e);
  }
}
