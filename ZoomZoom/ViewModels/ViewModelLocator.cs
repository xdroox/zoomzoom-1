// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ViewModelLocator
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Runtime.InteropServices;
using ZoomZoom.Design;
using ZoomZoom.Models;

namespace ZoomZoom.ViewModels
{
  public class ViewModelLocator
  {
    private DockedEngineViewModel dockedEngineViewModel = (DockedEngineViewModel) null;
    private EngineViewModel engineViewModel = (EngineViewModel) null;
    private WindowManagementViewModel windowManagementViewModel = (WindowManagementViewModel) null;
    private ActivityManagerViewModel activityManagerViewModel;
    private ActivityEditorViewModel activityEditorViewModel;
    private LayoutEditorViewModel layoutEditorViewModel;
    private ChatManagementViewModel chatManagementViewModel;
    private ImageManagementViewModel imageManagementViewModel;

    public ActivityManagerViewModel ActivityManagerViewModel
    {
      get
      {
        return new ActivityManagerViewModel(ApplicationService.Instance.EventAggregator);
      }
    }

    public ActivityEditorViewModel ActivityEditorViewModel
    {
      get
      {
label_1:
        int num1 = 1958532798;
        ActivityEditorViewModel activityEditorViewModel;
        while (true)
        {
          int num2 = 847627082;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.activityEditorViewModel = new ActivityEditorViewModel(ApplicationService.Instance.EventAggregator);
              num1 = (int) num3 * 1958252727 ^ -1436602687;
              continue;
            case 1:
              flag = this.activityEditorViewModel == null;
              num1 = (int) num3 * 1181436053 ^ -211561579;
              continue;
            case 2:
              num1 = (int) num3 * -953297042 ^ 1381679747;
              continue;
            case 3:
              goto label_1;
            case 5:
              int num4 = flag ? -1664714070 : (num4 = -803469900);
              int num5 = (int) num3 * 969564090;
              num1 = num4 ^ num5;
              continue;
            case 6:
              activityEditorViewModel = this.activityEditorViewModel;
              num1 = 1970156966;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return activityEditorViewModel;
      }
      set
      {
        this.activityEditorViewModel = value;
      }
    }

    public LayoutEditorViewModel LayoutEditorViewModel
    {
      get
      {
label_1:
        int num1 = 1232099657;
        LayoutEditorViewModel layoutEditorViewModel;
        while (true)
        {
          int num2 = 1905719;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.layoutEditorViewModel = new LayoutEditorViewModel(ApplicationService.Instance.EventAggregator);
              num1 = (int) num3 * 89014375 ^ -183990355;
              continue;
            case 1:
              num1 = (int) num3 * 939310633 ^ 2138965181;
              continue;
            case 2:
              layoutEditorViewModel = this.layoutEditorViewModel;
              num1 = 800878062;
              continue;
            case 4:
              num1 = (int) num3 * -2007073234 ^ -982240793;
              continue;
            case 5:
              goto label_1;
            case 6:
              flag = this.layoutEditorViewModel == null;
              num1 = (int) num3 * -731346067 ^ 1310321934;
              continue;
            case 7:
              int num4 = !flag ? 346071836 : (num4 = 418547242);
              int num5 = (int) num3 * -624662121;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return layoutEditorViewModel;
      }
      set
      {
label_1:
        int num1 = 2050043254;
        while (true)
        {
          int num2 = 1040463185;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.layoutEditorViewModel = value;
              num1 = (int) num3 * -244666736 ^ 1220766233;
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

    public ChatManagementViewModel ChatManagementViewModel
    {
      get
      {
label_1:
        int num1 = 1087926174;
        ChatManagementViewModel managementViewModel;
        while (true)
        {
          int num2 = 58432998;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.chatManagementViewModel = new ChatManagementViewModel();
              num1 = (int) num3 * 1505523469 ^ 1765109973;
              continue;
            case 1:
              num1 = (int) num3 * -2119521651 ^ 1976943428;
              continue;
            case 2:
              goto label_1;
            case 4:
              int num4 = this.chatManagementViewModel != null ? 1553269175 : (num4 = 2016606220);
              int num5 = (int) num3 * 367602876;
              num1 = num4 ^ num5;
              continue;
            case 5:
              managementViewModel = this.chatManagementViewModel;
              num1 = 1206974401;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return managementViewModel;
      }
      set
      {
        this.chatManagementViewModel = value;
      }
    }

    public DockedEngineViewModel DockedEngineViewModel
    {
      get
      {
        bool flag = this.dockedEngineViewModel == null;
label_1:
        int num1 = 49816605;
        DockedEngineViewModel dockedEngineViewModel;
        while (true)
        {
          int num2 = 771696437;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 1:
              this.dockedEngineViewModel = new DockedEngineViewModel();
              num1 = (int) num3 * 1167784798 ^ -118493526;
              continue;
            case 2:
              num1 = (int) num3 * 1731916813 ^ -634237917;
              continue;
            case 3:
              dockedEngineViewModel = this.dockedEngineViewModel;
              num1 = 1075258407;
              continue;
            case 4:
              int num4 = !flag ? -1727984760 : (num4 = -1110489254);
              int num5 = (int) num3 * 50700500;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return dockedEngineViewModel;
      }
    }

    public EngineViewModel EngineViewModel
    {
      get
      {
label_1:
        int num1 = 1327118254;
        EngineViewModel instance;
        while (true)
        {
          int num2 = 429499011;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -926335274 ^ -2057675229;
              continue;
            case 1:
              instance = (EngineViewModel) ViewModelLocator.\u206C‬‪‪⁭‫⁪‭‫⁪‏‏⁫⁯‏‫​‮⁮‫‏⁯‎⁯‌‫‪⁮‪‌‭‍⁫‮‪‌‌‫​⁯‮().GetInstance<EngineViewModel>();
              num1 = 1277093557;
              continue;
            case 3:
              int num4 = this.engineViewModel != null ? 17729555 : (num4 = 245840547);
              int num5 = (int) num3 * 1075100047;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_1;
            case 5:
              this.engineViewModel = new EngineViewModel();
              num1 = (int) num3 * -1093763983 ^ -312707229;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return instance;
      }
    }

    public ImageHistoryViewModel ImageHistoryViewModel
    {
      get
      {
        ImageHistoryViewModel instance = (ImageHistoryViewModel) ViewModelLocator.\u206C‬‪‪⁭‫⁪‭‫⁪‏‏⁫⁯‏‫​‮⁮‫‏⁯‎⁯‌‫‪⁮‪‌‭‍⁫‮‪‌‌‫​⁯‮().GetInstance<ImageHistoryViewModel>();
label_1:
        int num1 = -863158772;
        while (true)
        {
          int num2 = -1518652401;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 2144254632 ^ 1622165380;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return instance;
      }
    }

    public SettingsViewModel SettingsViewModel
    {
      get
      {
label_1:
        int num1 = 243903321;
        SettingsViewModel instance;
        while (true)
        {
          int num2 = 2039453706;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1354757765 ^ -70700645;
              continue;
            case 3:
              instance = (SettingsViewModel) ViewModelLocator.\u206C‬‪‪⁭‫⁪‭‫⁪‏‏⁫⁯‏‫​‮⁮‫‏⁯‎⁯‌‫‪⁮‪‌‭‍⁫‮‪‌‌‫​⁯‮().GetInstance<SettingsViewModel>();
              num1 = (int) num3 * 586224037 ^ 1085057528;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return instance;
      }
    }

    public WindowManagementViewModel WindowManagementViewModel
    {
      get
      {
label_1:
        int num1 = 5661996;
        WindowManagementViewModel managementViewModel;
        while (true)
        {
          int num2 = 131239459;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              managementViewModel = this.windowManagementViewModel;
              num1 = 1150347734;
              continue;
            case 1:
              int num4 = !flag ? 1139456041 : (num4 = 1024324261);
              int num5 = (int) num3 * 885912466;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            case 4:
              this.windowManagementViewModel = new WindowManagementViewModel();
              num1 = (int) num3 * 2005546753 ^ -712466487;
              continue;
            case 5:
              num1 = (int) num3 * -304489881 ^ -1587509582;
              continue;
            case 6:
              num1 = (int) num3 * -962615545 ^ 762322985;
              continue;
            case 7:
              flag = this.windowManagementViewModel == null;
              num1 = (int) num3 * 1573896894 ^ -1723728648;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return managementViewModel;
      }
      set
      {
        this.windowManagementViewModel = value;
      }
    }

    public ImageManagementViewModel ImageManagementViewModel
    {
      get
      {
        bool flag = this.imageManagementViewModel == null;
label_1:
        int num1 = -1327611333;
        ImageManagementViewModel managementViewModel;
        while (true)
        {
          int num2 = -405018488;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 284646197 ^ -855534637;
              continue;
            case 2:
              this.imageManagementViewModel = new ImageManagementViewModel();
              num1 = (int) num3 * 81008930 ^ -892051912;
              continue;
            case 3:
              int num4 = !flag ? -581893137 : (num4 = -355799824);
              int num5 = (int) num3 * 172728205;
              num1 = num4 ^ num5;
              continue;
            case 4:
              managementViewModel = this.imageManagementViewModel;
              num1 = -766955785;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return managementViewModel;
      }
      set
      {
        this.imageManagementViewModel = value;
      }
    }

    public ActivityEditorViewModel ActivityEditor
    {
      get
      {
        return new ActivityEditorViewModel(ApplicationService.Instance.EventAggregator);
      }
    }

    public ViewModelLocator()
    {
label_1:
      int num1 = 1749005246;
      while (true)
      {
        int num2 = 1827592963;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        bool flag8;
        switch ((num3 = (uint) (num1 ^ num2)) % 62U)
        {
          case 0:
            num1 = (int) num3 * -1867997410 ^ 895842565;
            continue;
          case 1:
            int num4;
            num1 = num4 = ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<ActivityEditorViewModel>() ? 1650151889 : (num4 = 1283212652);
            continue;
          case 2:
            int num5 = !flag6 ? 1433316906 : (num5 = 1521767387);
            int num6 = (int) num3 * -956153212;
            num1 = num5 ^ num6;
            continue;
          case 3:
            flag7 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<ChatManagementViewModel>();
            num1 = 545247082;
            continue;
          case 4:
            int num7;
            num1 = num7 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<WindowManagementViewModel>() ? 1305006513 : (num7 = 2098389793);
            continue;
          case 5:
            flag8 = ViewModelLocator.\u200B‬‏⁫‭‮⁭⁭‍‪‌‌‮​‭‏‍‭‌⁭​⁪⁮‭⁮‍⁯‪‫‮​⁪‌‬⁬⁬‏⁬‍‫‮();
            num1 = (int) num3 * 1540226832 ^ -488454628;
            continue;
          case 6:
            num1 = (int) num3 * -394498248 ^ -916102120;
            continue;
          case 7:
            num1 = (int) num3 * 1734930586 ^ 39727234;
            continue;
          case 8:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<ActivityEditorViewModel>();
            num1 = (int) num3 * -1998346822 ^ -2097441777;
            continue;
          case 9:
            num1 = (int) num3 * 1585163375 ^ -61447916;
            continue;
          case 10:
            num1 = (int) num3 * -1318970847 ^ 106387906;
            continue;
          case 11:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<IDataService, DesignDataService>();
            num1 = (int) num3 * -474994020 ^ -1284478313;
            continue;
          case 12:
            num1 = (int) num3 * -754583131 ^ -1251376586;
            continue;
          case 13:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<ImageHistoryViewModel>();
            num1 = (int) num3 * -1005695404 ^ 290215709;
            continue;
          case 14:
            flag3 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<IEventAggregator>();
            num1 = 1690201507;
            continue;
          case 15:
            num1 = (int) num3 * -633380084 ^ -366087868;
            continue;
          case 16:
            num1 = (int) num3 * -1530620360 ^ 1611592655;
            continue;
          case 17:
            int num8;
            num1 = num8 = ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<ActivityEditorViewModel>() ? 704632230 : (num8 = 348079493);
            continue;
          case 18:
            flag4 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<ImageManagementViewModel>();
            num1 = 1539793854;
            continue;
          case 19:
            int num9 = flag4 ? -1519204160 : (num9 = -1222776929);
            int num10 = (int) num3 * 96347043;
            num1 = num9 ^ num10;
            continue;
          case 20:
            num1 = (int) num3 * 448301512 ^ 273567551;
            continue;
          case 21:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            ViewModelLocator.\u202E‫‮⁫‭⁬‌‫⁫​⁯⁬‬‍‮‬⁪‍‭‭‎‍‫‎⁭‬‮⁮‭‍‫‫‌‮​⁫⁬⁬‍⁯‮(ViewModelLocator.\u003C\u003Ec.\u003C\u003E9__0_0 ?? (ViewModelLocator.\u003C\u003Ec.\u003C\u003E9__0_0 = new ServiceLocatorProvider((object) ViewModelLocator.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003C\u002Ector\u003Eb__0_0))));
            num1 = 1350416638;
            continue;
          case 22:
            num1 = (int) num3 * 363180311 ^ -1947214147;
            continue;
          case 23:
            num1 = (int) num3 * -2042842864 ^ -248769992;
            continue;
          case 24:
            num1 = (int) num3 * -1937990177 ^ -953699625;
            continue;
          case 25:
            flag2 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<DockedEngineViewModel>();
            num1 = 1962256077;
            continue;
          case 26:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<ImageManagementViewModel>();
            num1 = (int) num3 * 1062925944 ^ -1741334916;
            continue;
          case 27:
            num1 = (int) num3 * 1024974999 ^ -663664683;
            continue;
          case 28:
            num1 = (int) num3 * 1366275632 ^ 51211970;
            continue;
          case 29:
            num1 = (int) num3 * -699006994 ^ -1888568057;
            continue;
          case 30:
            goto label_3;
          case 31:
            int num11;
            num1 = num11 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<SettingsViewModel>() ? 1241638755 : (num11 = 602716802);
            continue;
          case 32:
            int num12 = flag2 ? -1839731110 : (num12 = -176661505);
            int num13 = (int) num3 * 387561986;
            num1 = num12 ^ num13;
            continue;
          case 33:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<DockedEngineViewModel>();
            num1 = (int) num3 * 246478018 ^ -1800203911;
            continue;
          case 34:
            num1 = (int) num3 * -1939498516 ^ -1024676582;
            continue;
          case 35:
            int num14 = !flag7 ? -1429270039 : (num14 = -216614451);
            int num15 = (int) num3 * 1593478305;
            num1 = num14 ^ num15;
            continue;
          case 36:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<ActivityEditorViewModel>();
            num1 = (int) num3 * -1327880749 ^ 1571732908;
            continue;
          case 37:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<IEventAggregator>((Func<M0>) (ViewModelLocator.\u003C\u003Ec.\u003C\u003E9__0_1 ?? (ViewModelLocator.\u003C\u003Ec.\u003C\u003E9__0_1 = new Func<IEventAggregator>((object) ViewModelLocator.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003C\u002Ector\u003Eb__0_1)))));
            num1 = 1576783251;
            continue;
          case 38:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<EngineViewModel>();
            num1 = (int) num3 * 744184062 ^ 461520682;
            continue;
          case 39:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<ActivityManagerViewModel>();
            num1 = (int) num3 * 1992237416 ^ 802004332;
            continue;
          case 40:
            int num16;
            num1 = num16 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<ActivityManagerViewModel>() ? 2040024383 : (num16 = 1996232937);
            continue;
          case 41:
            int num17 = flag5 ? 199861623 : (num17 = 1244353470);
            int num18 = (int) num3 * -1581525260;
            num1 = num17 ^ num18;
            continue;
          case 42:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<IDataService, DataService>();
            num1 = 2077578018;
            continue;
          case 43:
            num1 = (int) num3 * 71023733 ^ -632408320;
            continue;
          case 44:
            int num19 = flag3 ? 881890933 : (num19 = 1345536659);
            int num20 = (int) num3 * -427819624;
            num1 = num19 ^ num20;
            continue;
          case 45:
            num1 = (int) num3 * -2107554670 ^ 636875527;
            continue;
          case 46:
            num1 = (int) num3 * 893706833 ^ -1219880464;
            continue;
          case 47:
            num1 = (int) num3 * 1131037236 ^ -1013816662;
            continue;
          case 48:
            int num21 = !flag1 ? -652902975 : (num21 = -20151668);
            int num22 = (int) num3 * 1467472483;
            num1 = num21 ^ num22;
            continue;
          case 49:
            num1 = (int) num3 * 2134432780 ^ -1093789658;
            continue;
          case 50:
            num1 = (int) num3 * 795512541 ^ -1436978046;
            continue;
          case 51:
            flag1 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<ImageHistoryViewModel>();
            num1 = 377776889;
            continue;
          case 52:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<LayoutEditorViewModel>();
            num1 = (int) num3 * -598152212 ^ 1430858295;
            continue;
          case 53:
            num1 = (int) num3 * -1394421034 ^ -883501163;
            continue;
          case 54:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<ChatManagementViewModel>();
            num1 = (int) num3 * -1044867489 ^ -1365488410;
            continue;
          case 55:
            num1 = (int) num3 * 1861584553 ^ -1219602913;
            continue;
          case 56:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<WindowManagementViewModel>();
            num1 = (int) num3 * 39496708 ^ 246804703;
            continue;
          case 57:
            flag5 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<EngineViewModel>();
            num1 = 1961917562;
            continue;
          case 58:
            goto label_1;
          case 59:
            ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().Register<SettingsViewModel>();
            num1 = (int) num3 * 533951802 ^ 387421210;
            continue;
          case 60:
            flag6 = !ViewModelLocator.\u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮().IsRegistered<LayoutEditorViewModel>();
            num1 = 1100803561;
            continue;
          case 61:
            int num23 = !flag8 ? -366551949 : (num23 = -182317902);
            int num24 = (int) num3 * -131762282;
            num1 = num23 ^ num24;
            continue;
          default:
            goto label_64;
        }
      }
label_64:
      return;
label_3:;
    }

    public static void Cleanup()
    {
    }

    static void \u202E‫‮⁫‭⁬‌‫⁫​⁯⁬‬‍‮‬⁪‍‭‭‎‍‫‎⁭‬‮⁮‭‍‫‫‌‮​⁫⁬⁬‍⁯‮([In] ServiceLocatorProvider obj0)
    {
      ServiceLocator.SetLocatorProvider(obj0);
    }

    static bool \u200B‬‏⁫‭‮⁭⁭‍‪‌‌‮​‭‏‍‭‌⁭​⁪⁮‭⁮‍⁯‪‫‮​⁪‌‬⁬⁬‏⁬‍‫‮()
    {
      return ViewModelBase.get_IsInDesignModeStatic();
    }

    static SimpleIoc \u200B‎‌‎⁪‏⁮‏⁪‏⁮‭‏⁯⁮⁫‌⁮‍⁬‌‮⁭⁫⁬⁮⁭⁫‏‏⁫‌‮⁪‭⁪⁬‏⁮‍‮()
    {
      return SimpleIoc.get_Default();
    }

    static IServiceLocator \u206C‬‪‪⁭‫⁪‭‫⁪‏‏⁫⁯‏‫​‮⁮‫‏⁯‎⁯‌‫‪⁮‪‌‭‍⁫‮‪‌‌‫​⁯‮()
    {
      return ServiceLocator.get_Current();
    }
  }
}
