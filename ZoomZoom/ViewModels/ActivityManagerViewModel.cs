// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ActivityManagerViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Activities;
using ZoomZoom.Properties;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  public class ActivityManagerViewModel : ViewModelBase
  {
    private DelegateCommand authorizeActivityCommand = (DelegateCommand) null;
    private DelegateCommand rejectActivityCommand = (DelegateCommand) null;
    private ActivityBase selectedPendingActivity = (ActivityBase) null;
    private IEventAggregator eventAggregator;
    private string activityManagerAuthorizationInstruction;
    private ObservableCollection<ActivityBase> pendingActivities;

    public string ActivityManagerAuthorizationInstruction
    {
      get
      {
        string authorizationInstruction = this.activityManagerAuthorizationInstruction;
label_1:
        int num1 = -2091995703;
        while (true)
        {
          int num2 = -1000927;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 553731465 ^ 1140596994;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return authorizationInstruction;
      }
      set
      {
label_1:
        int num1 = 508685889;
        while (true)
        {
          int num2 = 1453593787;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.activityManagerAuthorizationInstruction = value;
              num1 = 2098263504;
              continue;
            case 2:
              flag = ActivityManagerViewModel.\u206A‭⁬‎⁫‮⁯‎‬⁫‍⁬⁬‮⁭‏⁯‭‎⁮‪‏‍⁪⁯⁪‫⁭⁯‬‍⁫⁬‎⁮‏‭‪‌‭‮(this.activityManagerAuthorizationInstruction, value);
              num1 = (int) num3 * 1686951224 ^ -900930067;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2406177345U));
              num1 = (int) num3 * 1085959375 ^ 304457674;
              continue;
            case 4:
              num1 = (int) num3 * 1311262572 ^ -1747441274;
              continue;
            case 5:
              goto label_3;
            case 6:
              int num4 = flag ? -1952151804 : (num4 = -517196694);
              int num5 = (int) num3 * -2091755456;
              num1 = num4 ^ num5;
              continue;
            case 7:
              num1 = (int) num3 * 245844908 ^ 438907938;
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

    public ObservableCollection<ActivityBase> PendingActivities
    {
      get
      {
label_1:
        int num1 = 1127771583;
        ObservableCollection<ActivityBase> pendingActivities;
        while (true)
        {
          int num2 = 1617302337;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              pendingActivities = this.pendingActivities;
              num1 = (int) num3 * -691911742 ^ 27514786;
              continue;
            case 3:
              num1 = (int) num3 * 499502675 ^ 1017249389;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return pendingActivities;
      }
      set
      {
        bool flag = this.pendingActivities == value;
label_1:
        int num1 = -431933876;
        while (true)
        {
          int num2 = -1122101235;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1410402888 ^ -686834080;
              continue;
            case 1:
              goto label_3;
            case 2:
              this.pendingActivities = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3768111558U));
              num1 = -1939875521;
              continue;
            case 3:
              int num4 = flag ? 1624752977 : (num4 = 434383530);
              int num5 = (int) num3 * 1189769555;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * 1896112916 ^ -1902385988;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public DelegateCommand AuthorizeActivityCommand
    {
      get
      {
        DelegateCommand authorizeActivityCommand = this.authorizeActivityCommand;
label_1:
        int num1 = -65646076;
        while (true)
        {
          int num2 = -1455602212;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1139189851 ^ 1896447758;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return authorizeActivityCommand;
      }
    }

    public DelegateCommand RejectActivityCommand
    {
      get
      {
label_1:
        int num1 = 1269915314;
        DelegateCommand rejectActivityCommand;
        while (true)
        {
          int num2 = 1204914379;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              rejectActivityCommand = this.rejectActivityCommand;
              num1 = (int) num3 * -1649470879 ^ 1456590817;
              continue;
            case 3:
              num1 = (int) num3 * -1723721218 ^ 876290543;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return rejectActivityCommand;
      }
    }

    public ActivityBase SelectedPendingActivity
    {
      get
      {
label_1:
        int num1 = 609456526;
        ActivityBase selectedPendingActivity;
        while (true)
        {
          int num2 = 1580474924;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              selectedPendingActivity = this.selectedPendingActivity;
              num1 = (int) num3 * -1438777740 ^ -771143358;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedPendingActivity;
      }
      set
      {
        bool flag = this.selectedPendingActivity == value;
label_1:
        int num1 = -1444616035;
        while (true)
        {
          int num2 = -1137158211;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              num1 = (int) num3 * 1117634808 ^ 921691161;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(188784441U));
              num1 = (int) num3 * -1587448862 ^ -1241475382;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -392870385 ^ 654798676;
              continue;
            case 5:
              this.selectedPendingActivity = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1797703268U));
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(281273049U));
              num1 = -295191074;
              continue;
            case 6:
              int num4 = !flag ? 1449662207 : (num4 = 14489215);
              int num5 = (int) num3 * 1043192933;
              num1 = num4 ^ num5;
              continue;
            case 7:
              num1 = (int) num3 * 1064597321 ^ 1094788779;
              continue;
            case 8:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(347490369U));
              num1 = (int) num3 * -279997988 ^ 1644363335;
              continue;
            case 9:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2705659410U));
              num1 = (int) num3 * 1578149153 ^ -2089493186;
              continue;
            case 10:
              num1 = (int) num3 * -474259016 ^ -1048914245;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_3:;
      }
    }

    public ActivityManagerViewModel(IEventAggregator eventAggregator)
    {
label_1:
      int num1 = -256003110;
      while (true)
      {
        int num2 = -228001416;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.authorizeActivityCommand = ActivityManagerViewModel.\u206E⁭‮⁬‍⁪⁯⁬‏‫⁬⁯⁮⁪‮‪‮‌‮‮‪‬⁫​‌​‏⁬‫⁭‬​‫⁭⁬‮‬‌⁫‮(new Action((object) this, __methodptr(AuthorizeActivity)), new Func<bool>((object) this, __methodptr(CanAuthorizeActivity)));
            // ISSUE: method pointer
            // ISSUE: method pointer
            this.rejectActivityCommand = ActivityManagerViewModel.\u206E⁭‮⁬‍⁪⁯⁬‏‫⁬⁯⁮⁪‮‪‮‌‮‮‪‬⁫​‌​‏⁬‫⁭‬​‫⁭⁬‮‬‌⁫‮(new Action((object) this, __methodptr(RejectActivity)), new Func<bool>((object) this, __methodptr(CanRejectActivity)));
            num1 = (int) num3 * 163996414 ^ 1479191960;
            continue;
          case 1:
            this.eventAggregator = eventAggregator;
            this.ActivityManagerAuthorizationInstruction = Resources.ActivityManagerAuthorizationInstruction;
            num1 = (int) num3 * 757129865 ^ 883634037;
            continue;
          case 2:
            ((CompositePresentationEvent<ActivityEventBaseArguments>) eventAggregator.GetEvent<ActivityRequiresAuthorizationEvent>()).Subscribe(new Action<ActivityEventBaseArguments>(this.HandleActivityAuthorizationRequired), (ThreadOption) 1, true);
            num1 = (int) num3 * -1649378030 ^ -57436906;
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

    internal void Initialize(IntPtr handle)
    {
      object modelLock = ViewModelBase.modelLock;
      bool flag = false;
      try
      {
        ActivityManagerViewModel.\u202B‎‌‌⁬‪‏​⁫⁭‍‌‍⁭‭‮⁬⁪​‏⁭⁬‏​‭‌‭⁫⁮‬​‪⁭⁬⁯‎‮‏⁫⁬‮(modelLock, ref flag);
label_2:
        int num1 = 660390072;
        while (true)
        {
          int num2 = 1778576980;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 1:
              num1 = (int) num3 * 1203762004 ^ 1265513304;
              continue;
            case 2:
              this.ViewHandle = handle;
              num1 = (int) num3 * 324274272 ^ 1762019202;
              continue;
            case 3:
              num1 = (int) num3 * 781196035 ^ -183361157;
              continue;
            case 4:
              goto label_2;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_8:
          int num1 = 1420381225;
          while (true)
          {
            int num2 = 1778576980;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_8;
              case 1:
                ActivityManagerViewModel.\u206C⁫‮‏‍‍⁮⁯‏‎​⁮⁬‪‮‎⁬‬‎‌‏‭⁯‫⁬‪⁯​⁯‬‍⁯‭⁮‪​‍‭⁮‌‮(modelLock);
                num1 = (int) num3 * -1355421364 ^ -637190774;
                continue;
              case 2:
                num1 = (int) num3 * -1656071944 ^ 1070996251;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_14:
      this.RaiseAllPropertiesChanged();
label_15:
      int num4 = 576898378;
      while (true)
      {
        int num1 = 1778576980;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_15;
          case 1:
            num4 = (int) num2 * 654756322 ^ -514053259;
            continue;
          case 2:
            goto label_17;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_17:;
    }

    private void HandleActivityAuthorizationRequired(ActivityEventBaseArguments obj)
    {
      ActivityBase activeActivity = this.Engine.ActiveActivity;
      if (activeActivity == null)
        goto label_9;
label_1:
      int num1 = 806477923;
label_2:
      bool flag;
      while (true)
      {
        int num2 = 1431198640;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -386966218 ^ -1787231294;
            continue;
          case 2:
            ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Publish(new ViewEventPayload(this.ViewHandle, ViewEventType.Open));
            num1 = (int) num3 * 2085686653 ^ 1036762601;
            continue;
          case 3:
            this.RaiseAllPropertiesChanged();
            num1 = (int) num3 * 945186232 ^ 787196583;
            continue;
          case 4:
            num1 = (int) num3 * -1152104448 ^ -1220758736;
            continue;
          case 5:
            this.SelectedPendingActivity = activeActivity;
            num1 = (int) num3 * 1894855545 ^ -90034223;
            continue;
          case 6:
            goto label_8;
          case 7:
            int num4 = !flag ? -803974650 : (num4 = -91432519);
            int num5 = (int) num3 * 1497077575;
            num1 = num4 ^ num5;
            continue;
          case 8:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:
      return;
label_8:
      int num6 = activeActivity != this.SelectedPendingActivity ? 1 : 0;
      goto label_10;
label_9:
      num6 = 0;
label_10:
      flag = num6 != 0;
      num1 = 747814826;
      goto label_2;
    }

    private void RejectActivity()
    {
label_1:
      int num1 = -1551359205;
      while (true)
      {
        int num2 = -2129729940;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.SelectedPendingActivity != null;
            num1 = (int) num3 * -325588418 ^ 849946410;
            continue;
          case 2:
            this.SelectedPendingActivity.Reject();
            num1 = (int) num3 * -117503666 ^ 1792777409;
            continue;
          case 3:
            ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Publish(new ViewEventPayload(this.ViewHandle, ViewEventType.Close));
            num1 = (int) num3 * -1739074016 ^ -1492535981;
            continue;
          case 4:
            int num4 = flag ? 1258310662 : (num4 = 497236047);
            int num5 = (int) num3 * -1930259357;
            num1 = num4 ^ num5;
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

    private bool CanRejectActivity()
    {
      bool flag = this.SelectedPendingActivity != null;
label_1:
      int num1 = -1787694618;
      while (true)
      {
        int num2 = -1693029006;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -956884484 ^ 2015604385;
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

    private bool CanAuthorizeActivity()
    {
label_1:
      int num1 = -687890047;
      bool flag;
      while (true)
      {
        int num2 = -935692752;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 529544914 ^ 566219854;
            continue;
          case 1:
            flag = this.SelectedPendingActivity != null;
            num1 = (int) num3 * 922276186 ^ 28263634;
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

    private void AuthorizeActivity()
    {
label_1:
      int num1 = -1826083015;
      while (true)
      {
        int num2 = -1735868387;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_3;
          case 1:
            int num4 = !flag ? -313425258 : (num4 = -432129664);
            int num5 = (int) num3 * 1086464499;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * 1229663824 ^ 211434749;
            continue;
          case 3:
            this.SelectedPendingActivity.Authorize();
            ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Publish(new ViewEventPayload(this.ViewHandle, ViewEventType.Close));
            num1 = (int) num3 * 1733849417 ^ 1061699289;
            continue;
          case 4:
            flag = this.SelectedPendingActivity != null;
            num1 = (int) num3 * -792587546 ^ -1671045620;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * 1696119131 ^ 646862140;
            continue;
          case 7:
            num1 = (int) num3 * -1611931764 ^ -1225525069;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    static bool \u206A‭⁬‎⁫‮⁯‎‬⁫‍⁬⁬‮⁭‏⁯‭‎⁮‪‏‍⁪⁯⁪‫⁭⁯‬‍⁫⁬‎⁮‏‭‪‌‭‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static void \u202B‎‌‌⁬‪‏​⁫⁭‍‌‍⁭‭‮⁬⁪​‏⁭⁬‏​‭‌‭⁫⁮‬​‪⁭⁬⁯‎‮‏⁫⁬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206C⁫‮‏‍‍⁮⁯‏‎​⁮⁬‪‮‎⁬‬‎‌‏‭⁯‫⁬‪⁯​⁯‬‍⁯‭⁮‪​‍‭⁮‌‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static DelegateCommand \u206E⁭‮⁬‍⁪⁯⁬‏‫⁬⁯⁮⁪‮‪‮‌‮‮‪‬⁫​‌​‏⁬‫⁭‬​‫⁭⁬‮‬‌⁫‮([In] Action obj0, [In] Func<bool> obj1)
    {
      return new DelegateCommand(obj0, obj1);
    }
  }
}
