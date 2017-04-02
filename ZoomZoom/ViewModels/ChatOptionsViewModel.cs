// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ChatOptionsViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Windows.Controls;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Chats;
using ZoomZoom.UserControls;

namespace ZoomZoom.ViewModels
{
  public class ChatOptionsViewModel : ViewModelBase
  {
    private ActivityBase activity = (ActivityBase) null;
    private ChatOptions chatOptions;

    public ChatOptions ChatOptions
    {
      get
      {
        ChatOptions chatOptions = this.chatOptions;
label_1:
        int num1 = -1030492627;
        while (true)
        {
          int num2 = -1269523509;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -276146129 ^ 1574293991;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chatOptions;
      }
      set
      {
        this.chatOptions = value;
label_1:
        int num1 = -322918801;
        while (true)
        {
          int num2 = -1692450330;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2523138334U));
              num1 = (int) num3 * -930529094 ^ -683496919;
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

    public ActivityBase Activity
    {
      get
      {
label_1:
        int num1 = -2057125219;
        ActivityBase activity;
        while (true)
        {
          int num2 = -860768744;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              activity = this.activity;
              num1 = (int) num3 * 1617643580 ^ -602815314;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activity;
      }
      set
      {
        this.activity = value;
label_1:
        int num1 = 732302993;
        while (true)
        {
          int num2 = 162949072;
          uint num3;
          bool flag1;
          bool flag2;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 19U)
          {
            case 0:
              num1 = (int) num3 * -805273164 ^ 653547664;
              continue;
            case 1:
              flag1 = this.activity is SendChat;
              num1 = 766344912;
              continue;
            case 2:
              num1 = (int) num3 * -198415395 ^ 1909188847;
              continue;
            case 3:
              this.ChatOptions = ((SendChat) this.activity).ChatOptions;
              num1 = (int) num3 * -1256680217 ^ -1903050595;
              continue;
            case 4:
              int num4 = !flag1 ? -734274923 : (num4 = -352484236);
              int num5 = (int) num3 * 202729604;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_3;
            case 6:
              num1 = (int) num3 * -1043185099 ^ -703679652;
              continue;
            case 7:
              num1 = (int) num3 * 1105454975 ^ -1706836419;
              continue;
            case 8:
              num1 = (int) num3 * 166628462 ^ -2075672636;
              continue;
            case 9:
              goto label_1;
            case 10:
              int num6 = !flag2 ? -1433209941 : (num6 = -722305245);
              int num7 = (int) num3 * 1014908428;
              num1 = num6 ^ num7;
              continue;
            case 11:
              num1 = 1231840223;
              continue;
            case 12:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1273552450U));
              num1 = 1307186167;
              continue;
            case 13:
              flag3 = this.activity is FloodChat;
              num1 = (int) num3 * -1427859314 ^ -1630472827;
              continue;
            case 14:
              num1 = (int) num3 * -1782459699 ^ -57522747;
              continue;
            case 15:
              int num8 = !flag3 ? 274942627 : (num8 = 369958932);
              int num9 = (int) num3 * 266031682;
              num1 = num8 ^ num9;
              continue;
            case 16:
              num1 = (int) num3 * -1391436066 ^ -940636301;
              continue;
            case 17:
              flag2 = this.activity != null;
              num1 = (int) num3 * 1045474993 ^ 225359358;
              continue;
            case 18:
              this.ChatOptions = ((FloodChat) this.activity).ChatOptions;
              num1 = (int) num3 * 1637017213 ^ -1284215043;
              continue;
            default:
              goto label_21;
          }
        }
label_21:
        return;
label_3:;
      }
    }

    public ChatOptionsViewModel()
    {
      this.Engine = Engine.Instance;
      this.LoadCommands();
    }

    internal void Load(ChatOptionsUserControl chatOptionsUserControl, ActivityBase activity)
    {
label_1:
      int num1 = -454699294;
      while (true)
      {
        int num2 = -455215444;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = (int) num3 * 1161413624 ^ 126211128;
            continue;
          case 1:
            this.Activity = activity;
            num1 = (int) num3 * 1394546310 ^ -1993557793;
            continue;
          case 2:
            int num4;
            num1 = num4 = activity != this.Activity ? -2014604771 : (num4 = -1731532971);
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -833284698 ^ 1239881101;
            continue;
          case 5:
            this.Initialized = true;
            num1 = (int) num3 * -187880811 ^ 2003828249;
            continue;
          case 6:
            int num5 = flag ? -2141800316 : (num5 = -658444920);
            int num6 = (int) num3 * -1971492704;
            num1 = num5 ^ num6;
            continue;
          case 7:
            num1 = (int) num3 * 2080293199 ^ 1409047798;
            continue;
          case 8:
            num1 = (int) num3 * -235208399 ^ -1211567735;
            continue;
          case 9:
            num1 = (int) num3 * 942847206 ^ 1988401374;
            continue;
          case 10:
            flag = !this.Initialized;
            num1 = (int) num3 * 1389355410 ^ 1687700760;
            continue;
          case 11:
            goto label_3;
          case 12:
            num1 = (int) num3 * 1349792062 ^ -1426563558;
            continue;
          case 13:
            this.UserControl = (UserControl) chatOptionsUserControl;
            num1 = (int) num3 * -1226591075 ^ -619826038;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    private void LoadCommands()
    {
label_1:
      int num1 = 2034929597;
      while (true)
      {
        int num2 = 810188092;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            goto label_3;
          case 1:
            flag = this.Commands.Count == 0;
            num1 = (int) num3 * 2007852218 ^ 1135182295;
            continue;
          case 2:
            num1 = (int) num3 * -105898015 ^ 1340662134;
            continue;
          case 3:
            num1 = (int) num3 * -1297970954 ^ -1825839166;
            continue;
          case 4:
            num1 = (int) num3 * 1117486057 ^ 1507015811;
            continue;
          case 5:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(445279002U), (Action<object>) (x => this.ExecuteEditContent()), (Predicate<object>) (x => this.CanExecuteEditContent()));
            num1 = (int) num3 * 783544546 ^ 1936927024;
            continue;
          case 6:
            num1 = (int) num3 * 2141169450 ^ -857244943;
            continue;
          case 7:
            int num4 = flag ? 624650215 : (num4 = 628543364);
            int num5 = (int) num3 * 1182451900;
            num1 = num4 ^ num5;
            continue;
          case 8:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4243347719U), (Action<object>) (x =>
            {
              this.ExecuteEditCategory();
label_1:
              int num2 = 1839960266;
              while (true)
              {
                int num3 = 1318897717;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    num2 = (int) num4 * 638313416 ^ 660607371;
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
            }), (Predicate<object>) (x => this.CanExecuteEditCategory()));
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4168547630U), (Action<object>) (x => this.ExecuteDeleteCategory()), (Predicate<object>) (x => this.CanExecuteDeleteCategory()));
            num1 = (int) num3 * 1832111020 ^ 2098575163;
            continue;
          case 9:
            goto label_1;
          case 10:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2082527138U), (Action<object>) (x =>
            {
              this.ExecuteDeleteContent();
label_1:
              int num2 = 853319062;
              while (true)
              {
                int num3 = 1454583470;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num2 = (int) num4 * 307049039 ^ -1316890673;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanExecuteDeleteContent()));
            num1 = (int) num3 * -1038783662 ^ 1778107500;
            continue;
          case 11:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3368802138U), (Action<object>) (x => this.ExecuteNewContent()), (Predicate<object>) (x => this.CanExecuteNewContent()));
            num1 = (int) num3 * 1013560725 ^ -707919891;
            continue;
          case 12:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(156775746U), (Action<object>) (x => this.ExecuteNewCategory()), (Predicate<object>) (x => this.CanExecuteNewCategory()));
            num1 = (int) num3 * -1223706445 ^ 1477236955;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:;
    }

    private bool CanExecuteDeleteContent()
    {
label_1:
      int num1 = -1783592480;
      bool flag;
      while (true)
      {
        int num2 = -1763363783;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = false;
            num1 = (int) num3 * -1545373533 ^ 723591212;
            continue;
          case 2:
            num1 = (int) num3 * -1495457435 ^ -1763736768;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteDeleteContent()
    {
    }

    private bool CanExecuteEditContent()
    {
      bool flag = false;
label_1:
      int num1 = -762124532;
      while (true)
      {
        int num2 = -2059164726;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -1277922297 ^ 264254425;
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

    private void ExecuteEditContent()
    {
    }

    private bool CanExecuteNewContent()
    {
label_1:
      int num1 = 1756048162;
      bool flag;
      while (true)
      {
        int num2 = 30925015;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -2056638696 ^ -333584835;
            continue;
          case 1:
            flag = false;
            num1 = (int) num3 * 1015206774 ^ 1341881681;
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

    private void ExecuteNewContent()
    {
    }

    private bool CanExecuteDeleteCategory()
    {
label_1:
      int num1 = -493893633;
      bool flag;
      while (true)
      {
        int num2 = -306188491;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = false;
            num1 = (int) num3 * 751843521 ^ 1601713825;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteDeleteCategory()
    {
    }

    private bool CanExecuteEditCategory()
    {
label_1:
      int num1 = 900891109;
      bool flag;
      while (true)
      {
        int num2 = 546790137;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = false;
            num1 = (int) num3 * -91434470 ^ 1094832577;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteEditCategory()
    {
    }

    private bool CanExecuteNewCategory()
    {
label_1:
      int num1 = -294174725;
      bool flag;
      while (true)
      {
        int num2 = -893819183;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            flag = false;
            num1 = (int) num3 * -564524262 ^ -40528513;
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

    private void ExecuteNewCategory()
    {
    }
  }
}
