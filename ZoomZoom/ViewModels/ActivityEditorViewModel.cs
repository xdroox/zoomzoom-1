// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ActivityEditorViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows.Input;
using ZoomZoom.Models.Windows;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  public class ActivityEditorViewModel : ViewModelBase
  {
    private ObservableCollection<ZoomWindow> windows = (ObservableCollection<ZoomWindow>) null;
    private ActivityBase activity = (ActivityBase) null;
    private string userName = "";
    private ZoomWindow selectedWindow = (ZoomWindow) null;
    private DelegateCommand<object> activityCommand;
    private DelegateCommand executeActivityCommand;

    public ActivityBase Activity
    {
      get
      {
label_1:
        int num1 = 1211962865;
        ActivityBase activity;
        while (true)
        {
          int num2 = 1723475584;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              activity = this.activity;
              num1 = (int) num3 * -1217972705 ^ -1025380243;
              continue;
            case 2:
              num1 = (int) num3 * -759501538 ^ 1278062291;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activity;
      }
      set
      {
        bool flag = this.activity == value;
label_1:
        int num1 = -2098985382;
        while (true)
        {
          int num2 = -292566610;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = !flag ? -1693105888 : (num4 = -1675951182);
              int num5 = (int) num3 * 1884405889;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.activity = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1273552450U));
              num1 = -2067597199;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * 1880540170 ^ 1054031713;
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

    public ObservableCollection<ZoomWindow> Windows
    {
      get
      {
        return this.windows;
      }
      set
      {
label_1:
        int num1 = -354248009;
        while (true)
        {
          int num2 = -567928736;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              int num4 = flag ? -1381904535 : (num4 = -1315317259);
              int num5 = (int) num3 * 614552484;
              num1 = num4 ^ num5;
              continue;
            case 1:
              num1 = (int) num3 * -2110670768 ^ 1539681491;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4276758280U));
              num1 = (int) num3 * 990583758 ^ 814998186;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              this.windows = value;
              num1 = -171595710;
              continue;
            case 6:
              num1 = (int) num3 * 1847486014 ^ -236924841;
              continue;
            case 7:
              flag = this.windows == value;
              num1 = (int) num3 * -903653327 ^ -1408158825;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public string UserName
    {
      get
      {
label_1:
        int num1 = -143593144;
        string userName;
        while (true)
        {
          int num2 = -354260931;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 811576513 ^ 2062969242;
              continue;
            case 1:
              userName = this.userName;
              num1 = (int) num3 * -488024160 ^ -2129954727;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return userName;
      }
      set
      {
label_1:
        int num1 = -1241746043;
        while (true)
        {
          int num2 = -1628269266;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1959159945U));
              num1 = (int) num3 * 1343903818 ^ -145136333;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              flag = ActivityEditorViewModel.\u206C⁯⁯‫‮⁬‭‬⁫‮‪‏‬⁬⁫⁬⁮‌⁭‬‪‌‏⁫‎⁮‍‪‪‏‬‮⁫‪‏⁫‍⁯‮‮(this.userName, value);
              num1 = (int) num3 * 1744113715 ^ -543914655;
              continue;
            case 4:
              num1 = (int) num3 * 2036492443 ^ 202434275;
              continue;
            case 5:
              num1 = (int) num3 * 1610233302 ^ -917551199;
              continue;
            case 6:
              int num4 = flag ? -114372130 : (num4 = -299171835);
              int num5 = (int) num3 * 1625493694;
              num1 = num4 ^ num5;
              continue;
            case 7:
              this.userName = value;
              num1 = -793047634;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public ICommand ActivityCommand
    {
      get
      {
label_1:
        int num1 = -1240345066;
        ICommand activityCommand;
        while (true)
        {
          int num2 = -1530443783;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              activityCommand = (ICommand) this.activityCommand;
              num1 = (int) num3 * -1984356836 ^ 1870413716;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return activityCommand;
      }
    }

    public ActivityEditorViewModel(IEventAggregator eventAggregator)
    {
label_1:
      int num1 = -197246532;
      while (true)
      {
        int num2 = -1423646843;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            this.Windows = new ObservableCollection<ZoomWindow>();
            num1 = (int) num3 * -151890115 ^ -365968262;
            continue;
          case 2:
            this.selectedWindow = (ZoomWindow) null;
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.executeActivityCommand = ActivityEditorViewModel.\u206C⁯‏​⁭‎‮⁪‬‫⁯‪‪⁬⁯‌‌‎​⁮‫‫‌‪⁯‌‎⁫​⁮⁪‭‪‬‏‭‎⁫⁯‌‮(new Action((object) this, __methodptr(ExecuteActivity)), new Func<bool>((object) this, __methodptr(CanExecuteActivity)));
            num1 = (int) num3 * 648542634 ^ -672060411;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: method pointer
      this.activityCommand = new DelegateCommand<object>(new Action<object>(this.ExecuteActivityCommand), new Func<object, bool>((object) this, __methodptr(CanExecuteActivityCommand)));
    }

    private void ExecuteActivityCommand(object obj)
    {
label_1:
      int num1 = 90465571;
      while (true)
      {
        int num2 = 1102438102;
        uint num3;
        bool flag1;
        string str;
        bool flag2;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 28U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -259063403 ^ -188923929;
            continue;
          case 2:
            num1 = (int) num3 * -1471843075 ^ 690496228;
            continue;
          case 3:
            int num4 = !flag1 ? -1525889711 : (num4 = -82990408);
            int num5 = (int) num3 * -1523144095;
            num1 = num4 ^ num5;
            continue;
          case 4:
            int num6 = flag2 ? 1775228504 : (num6 = 1323107523);
            int num7 = (int) num3 * -1519617348;
            num1 = num6 ^ num7;
            continue;
          case 5:
            flag2 = str != null;
            num1 = (int) num3 * 1886903409 ^ 1047915235;
            continue;
          case 6:
            str = ActivityEditorViewModel.\u206F⁭‭​⁪‪‬‮⁬‍‭⁪⁮⁮‍⁬⁭‏​‬⁫‬‬⁭‏‮⁭⁭⁪‎⁮⁮​⁫‭⁮‎⁪‪‬‮(str);
            num1 = (int) num3 * 908269098 ^ 1066955112;
            continue;
          case 7:
            num1 = (int) num3 * -1268269991 ^ 713023012;
            continue;
          case 8:
            flag3 = ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1578572972U));
            num1 = 250307217;
            continue;
          case 9:
            str = obj as string;
            num1 = (int) num3 * 1786358984 ^ -605164601;
            continue;
          case 10:
            num1 = (int) num3 * 498532918 ^ 497798756;
            continue;
          case 11:
            num1 = (int) num3 * 872830432 ^ 1500431594;
            continue;
          case 12:
            num1 = (int) num3 * 942697240 ^ 977527472;
            continue;
          case 13:
            this.ResetActivity();
            num1 = (int) num3 * 1683123615 ^ -2038557646;
            continue;
          case 14:
            num1 = (int) num3 * 1270666552 ^ 1068085688;
            continue;
          case 15:
            num1 = (int) num3 * 1387247315 ^ 568936060;
            continue;
          case 16:
            num1 = 909560659;
            continue;
          case 17:
            goto label_3;
          case 18:
            this.ExecuteActivity();
            num1 = (int) num3 * -724312823 ^ 1607055591;
            continue;
          case 19:
            int num8 = flag3 ? 1186076324 : (num8 = 2091408490);
            int num9 = (int) num3 * 1792411976;
            num1 = num8 ^ num9;
            continue;
          case 20:
            num1 = (int) num3 * -479866011 ^ -2047923915;
            continue;
          case 21:
            flag1 = ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2384185145U));
            num1 = 842949253;
            continue;
          case 22:
            int num10 = ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2420374883U)) ? -144306726 : (num10 = -60815615);
            int num11 = (int) num3 * 1152976147;
            num1 = num10 ^ num11;
            continue;
          case 23:
            num1 = (int) num3 * -953846992 ^ 434035610;
            continue;
          case 24:
            int num12;
            num1 = num12 = !ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1014975505U)) ? 1461108170 : (num12 = 844788917);
            continue;
          case 25:
            this.CancelActivity();
            num1 = (int) num3 * 1310455739 ^ -1513086739;
            continue;
          case 26:
            this.SaveActivity();
            num1 = (int) num3 * 1644345469 ^ -2133109716;
            continue;
          case 27:
            num1 = (int) num3 * 1504568437 ^ -589766832;
            continue;
          default:
            goto label_30;
        }
      }
label_30:
      return;
label_3:;
    }

    private bool CanExecuteActivityCommand(object arg)
    {
      bool flag1 = false;
      string str = arg as string;
label_1:
      int num1 = -621358030;
      bool flag2;
      while (true)
      {
        int num2 = -874977316;
        uint num3;
        bool flag3;
        bool flag4;
        bool flag5;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 28U)
        {
          case 0:
            num1 = (int) num3 * 166454519 ^ 540056099;
            continue;
          case 1:
            num1 = (int) num3 * 2105774077 ^ 770559853;
            continue;
          case 3:
            int num5;
            num1 = num5 = !ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(9588784U)) ? -1077297311 : (num5 = -795892161);
            continue;
          case 4:
            flag1 = true;
            num1 = (int) num3 * 186787835 ^ -2013270755;
            continue;
          case 5:
            flag4 = ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2076102570U));
            num1 = -1322253949;
            continue;
          case 6:
            num1 = (int) num3 * -1477902835 ^ -1495855668;
            continue;
          case 7:
            int num6 = flag5 ? 666058517 : (num6 = 895827841);
            int num7 = (int) num3 * 628971325;
            num1 = num6 ^ num7;
            continue;
          case 8:
            num1 = (int) num3 * -432910360 ^ 457874447;
            continue;
          case 9:
            num1 = (int) num3 * -709112027 ^ -2096335906;
            continue;
          case 10:
            flag1 = this.Activity.IsDirty;
            num1 = (int) num3 * -1389158344 ^ -578758723;
            continue;
          case 11:
            flag5 = ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3822780209U));
            num1 = (int) num3 * 452115308 ^ -337149765;
            continue;
          case 12:
            num1 = (int) num3 * 775663404 ^ -304394087;
            continue;
          case 13:
            flag1 = true;
            num1 = (int) num3 * 478753205 ^ 1314309208;
            continue;
          case 14:
            flag3 = ActivityEditorViewModel.\u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮(str, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1263168795U));
            num1 = -1919926090;
            continue;
          case 15:
            num1 = -624529131;
            continue;
          case 16:
            goto label_1;
          case 17:
            flag2 = flag1;
            num1 = -1994386986;
            continue;
          case 18:
            num1 = (int) num3 * 2068083677 ^ 439270465;
            continue;
          case 19:
            int num8 = flag4 ? -1729981349 : (num8 = -1176262868);
            int num9 = (int) num3 * 1353194685;
            num1 = num8 ^ num9;
            continue;
          case 20:
            num4 = this.Activity != null ? 1 : 0;
            break;
          case 21:
            num1 = (int) num3 * 953726359 ^ -1559030811;
            continue;
          case 22:
            int num10 = flag3 ? 834125809 : (num10 = 1428352287);
            int num11 = (int) num3 * 1442076112;
            num1 = num10 ^ num11;
            continue;
          case 23:
            flag1 = this.Activity.IsValid;
            num1 = (int) num3 * 1862499942 ^ -1954829706;
            continue;
          case 24:
            num1 = (int) num3 * -181506777 ^ 234691028;
            continue;
          case 25:
            num1 = (int) num3 * 1965610521 ^ 1832408481;
            continue;
          case 26:
            if (str != null)
            {
              num1 = (int) num3 * -1075277491 ^ 1746862698;
              continue;
            }
            num4 = 0;
            break;
          case 27:
            str = ActivityEditorViewModel.\u206F⁭‭​⁪‪‬‮⁬‍‭⁪⁮⁮‍⁬⁭‏​‬⁫‬‬⁭‏‮⁭⁭⁪‎⁮⁮​⁫‭⁮‎⁪‪‬‮(str);
            num1 = (int) num3 * 355131983 ^ 1629694742;
            continue;
          default:
            goto label_32;
        }
        int num12;
        num1 = num12 = num4 != 0 ? -1076255845 : (num12 = -624529131);
      }
label_32:
      return flag2;
    }

    private void CancelActivity()
    {
      ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Publish(new ViewEventPayload(this.ViewHandle, ViewEventType.Close));
label_1:
      int num1 = -429928682;
      while (true)
      {
        int num2 = -547603928;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 402426561 ^ -863803301;
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

    private void SaveActivity()
    {
      bool flag = this.Activity != null;
label_1:
      int num1 = -348128889;
      while (true)
      {
        int num2 = -1788143745;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            this.Activity = (ActivityBase) null;
            num1 = (int) num3 * -2172297 ^ 1440498820;
            continue;
          case 1:
            this.CancelActivity();
            num1 = (int) num3 * -681335900 ^ -688818145;
            continue;
          case 2:
            num1 = -1893964470;
            continue;
          case 3:
            num1 = (int) num3 * -1776772968 ^ 204935754;
            continue;
          case 4:
            num1 = (int) num3 * 867636497 ^ 1147661569;
            continue;
          case 5:
            goto label_1;
          case 6:
            int num4 = flag ? -801846049 : (num4 = -352351942);
            int num5 = (int) num3 * -2118428622;
            num1 = num4 ^ num5;
            continue;
          case 7:
            goto label_3;
          case 8:
            int num6 = !this.Engine.SaveActivity(this.Activity) ? 1569675269 : (num6 = 895031450);
            int num7 = (int) num3 * 1360553751;
            num1 = num6 ^ num7;
            continue;
          case 9:
            num1 = (int) num3 * -449426942 ^ -1520941947;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    private void ResetActivity()
    {
      throw ActivityEditorViewModel.\u202C​‍‮⁭‪⁮‮‪‏‫‏‎⁪‭⁬‏⁯‫⁬⁬⁮​⁯‍⁮‎‬‏‫⁯‍​‫‭⁬‮‮⁫⁭‮();
    }

    private void ExecuteActivity()
    {
      if (this.Activity == null)
        goto label_5;
label_1:
      int num1 = -1565327178;
label_2:
      while (true)
      {
        int num2 = -615186821;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -1517056530 ^ -58942926;
            continue;
          case 1:
            goto label_4;
          case 2:
            this.Engine.AddActivity(this.Activity, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3237301298U));
            this.CloseView();
            num1 = (int) num3 * -978955690 ^ 156627493;
            continue;
          case 3:
            num1 = (int) num3 * 1247222598 ^ 1272135746;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:
      return;
label_4:
      int num4 = this.Activity.IsValid ? 1 : 0;
      goto label_6;
label_5:
      num4 = 0;
label_6:
      num1 = num4 == 0 ? -118164404 : (num1 = -712669757);
      goto label_2;
    }

    private bool CanExecuteActivity()
    {
      bool flag = true;
label_1:
      int num1 = 504083333;
      while (true)
      {
        int num2 = 690688899;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * 947707501 ^ -1224049522;
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

    private void LoadCommands()
    {
      bool flag = this.Commands.Count == 0;
label_1:
      int num1 = -730203690;
      while (true)
      {
        int num2 = -1274310189;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = flag ? -1130902289 : (num4 = -2139757778);
            int num5 = (int) num3 * -41554902;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * 1170831473 ^ -1382476302;
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

    private void CancelEdit()
    {
label_1:
      int num1 = 548855406;
      while (true)
      {
        int num2 = 1893090382;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.CloseView();
            num1 = (int) num3 * 1770787953 ^ 1801755656;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void CloseView()
    {
      bool flag = !this.ViewHandle.Equals((object) IntPtr.Zero);
label_1:
      int num1 = -1810702520;
      while (true)
      {
        int num2 = -1250325507;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            ((CompositePresentationEvent<IntPtr>) this._eventAggregator.GetEvent<CloseZoomZoomWindow>()).Publish(this.ViewHandle);
            num1 = (int) num3 * 1036979384 ^ 383637215;
            continue;
          case 2:
            num1 = (int) num3 * 751438086 ^ -2113938026;
            continue;
          case 3:
            int num4 = flag ? -511545444 : (num4 = -413904173);
            int num5 = (int) num3 * 1931556876;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * -1081591150 ^ 1936484081;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private bool CanSaveEdit()
    {
label_1:
      int num1 = -1515922189;
      bool flag;
      while (true)
      {
        int num2 = -276195911;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = true;
            num1 = (int) num3 * -1382237095 ^ -1758904379;
            continue;
          case 2:
            if (this.Activity != null)
            {
              num1 = (int) num3 * 1964976027 ^ 1384717673;
              continue;
            }
            num4 = 0;
            break;
          case 3:
            flag = false;
            num1 = -1394521091;
            continue;
          case 4:
            num1 = (int) num3 * 401620158 ^ -1275543964;
            continue;
          case 6:
            num4 = this.Activity.IsDirty ? 1 : 0;
            break;
          case 7:
            num1 = (int) num3 * -1828011781 ^ 814610757;
            continue;
          default:
            goto label_12;
        }
        int num5;
        num1 = num5 = num4 == 0 ? -1971895270 : (num5 = -1985302946);
      }
label_12:
      return flag;
    }

    private void SaveEdit()
    {
      if (this.Activity == null)
        goto label_8;
label_1:
      int num1 = 1721368118;
label_2:
      bool flag;
      while (true)
      {
        int num2 = 1754356627;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_7;
          case 2:
            num1 = (int) num3 * -336728822 ^ 1095278767;
            continue;
          case 3:
            num1 = (int) num3 * 295049946 ^ -790948363;
            continue;
          case 4:
            int num4 = flag ? -219476568 : (num4 = -1569248433);
            int num5 = (int) num3 * 56173672;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:
      return;
label_7:
      int num6 = this.Activity.IsDirty ? 1 : 0;
      goto label_9;
label_8:
      num6 = 0;
label_9:
      flag = num6 != 0;
      num1 = 45265729;
      goto label_2;
    }

    static bool \u206C⁯⁯‫‮⁬‭‬⁫‮‪‏‬⁬⁫⁬⁮‌⁭‬‪‌‏⁫‎⁮‍‪‪‏‬‮⁫‪‏⁫‍⁯‮‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static DelegateCommand \u206C⁯‏​⁭‎‮⁪‬‫⁯‪‪⁬⁯‌‌‎​⁮‫‫‌‪⁯‌‎⁫​⁮⁪‭‪‬‏‭‎⁫⁯‌‮([In] Action obj0, [In] Func<bool> obj1)
    {
      return new DelegateCommand(obj0, obj1);
    }

    static string \u206F⁭‭​⁪‪‬‮⁬‍‭⁪⁮⁮‍⁬⁭‏​‬⁫‬‬⁭‏‮⁭⁭⁪‎⁮⁮​⁫‭⁮‎⁪‪‬‮([In] string obj0)
    {
      return obj0.ToUpper();
    }

    static bool \u200F‪⁮⁭‎‏‪​⁪⁯‍​⁯⁮⁯‬⁭‬‫‭‌⁪⁭‪‏‫‪‏​‍‭‍‍‍​‬⁬⁮⁬‮‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static NotImplementedException \u202C​‍‮⁭‪⁮‮‪‏‫‏‎⁪‭⁬‏⁯‫⁬⁬⁮​⁯‍⁮‎‬‏‫⁯‍​‫‭⁬‮‮⁫⁭‮()
    {
      return new NotImplementedException();
    }
  }
}
