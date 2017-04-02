// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.SettingsViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZoomZoom.Common;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Utils;
using ZoomZoom.UserControls;

namespace ZoomZoom.ViewModels
{
  public class SettingsViewModel : ViewModelBase
  {
    private bool initialized = false;
    private SettingsControl userControl = (SettingsControl) null;
    private MessageCategory selectedChatCategory = (MessageCategory) null;
    private LockedObservableCollection<MessageCategory> chatCategories = (LockedObservableCollection<MessageCategory>) null;
    private bool engineView_DisplayLayoutBar = false;
    private bool engineView_DisplayMeetingBar = false;
    private bool engineView_DisplayActivityBar = false;
    private bool engineView_DisplaySettingsBar = false;
    private bool engineView_DisplayChatBar = false;
    private bool engineView_DisplayImageBar = false;
    private bool engineView_DisplayQuickLinkBar = false;
    private List<StringItem> floodTargets = (List<StringItem>) null;
    private List<string> onHoldActions = new List<string>();

    public new bool Initialized
    {
      get
      {
label_1:
        int num1 = 364357045;
        bool initialized;
        while (true)
        {
          int num2 = 2007860282;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 990405072 ^ 1444190135;
              continue;
            case 3:
              initialized = this.initialized;
              num1 = (int) num3 * -47183645 ^ 913252993;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return initialized;
      }
      private set
      {
label_1:
        int num1 = -1717319841;
        while (true)
        {
          int num2 = -851447889;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.initialized = value;
              num1 = (int) num3 * -1969721704 ^ -1101361989;
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

    public SettingsControl UserControl
    {
      get
      {
label_1:
        int num1 = -1985306759;
        SettingsControl userControl;
        while (true)
        {
          int num2 = -1692009652;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              userControl = this.userControl;
              num1 = (int) num3 * -871318339 ^ 958198326;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return userControl;
      }
      set
      {
        this.userControl = value;
      }
    }

    public bool AutoCaptureVideoImages
    {
      get
      {
        bool captureVideoImages = Engine.Instance.Settings.AutoCaptureVideoImages;
label_1:
        int num1 = 835816188;
        while (true)
        {
          int num2 = 938164568;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -905369521 ^ -1361764287;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return captureVideoImages;
      }
      set
      {
label_1:
        int num1 = 1988557762;
        while (true)
        {
          int num2 = 1606200960;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = flag ? 2047309202 : (num4 = 2062168256);
              int num5 = (int) num3 * -72183839;
              num1 = num4 ^ num5;
              continue;
            case 1:
              num1 = (int) num3 * 1822929086 ^ -525302910;
              continue;
            case 2:
              Engine.Instance.Settings.AutoCaptureVideoImages = value;
              num1 = 768320571;
              continue;
            case 3:
              flag = Engine.Instance.Settings.AutoCaptureVideoImages == value;
              num1 = (int) num3 * 1417361916 ^ 63050183;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(576833591U));
              num1 = (int) num3 * 1441435703 ^ 1213856137;
              continue;
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
    }

    public bool FloodEnabled
    {
      get
      {
        bool floodEnabled = Engine.Instance.Settings.FloodEnabled;
label_1:
        int num1 = 1512990757;
        while (true)
        {
          int num2 = 2069366670;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1041023880 ^ -596371033;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return floodEnabled;
      }
      set
      {
label_1:
        int num1 = 1707051060;
        while (true)
        {
          int num2 = 1320117312;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 373447319 ^ -349454772;
              continue;
            case 1:
              int num4 = Engine.Instance.Settings.FloodEnabled != value ? -1607828451 : (num4 = -1013022683);
              int num5 = (int) num3 * -1715934072;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2795108938U));
              num1 = (int) num3 * 1966506245 ^ 1489754468;
              continue;
            case 3:
              num1 = (int) num3 * 610121822 ^ 1275846188;
              continue;
            case 4:
              goto label_1;
            case 5:
              Engine.Instance.Settings.FloodEnabled = value;
              num1 = 542660422;
              continue;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool RemoveUsersFlooding
    {
      get
      {
        bool removeUsersFlooding = Engine.Instance.Settings.RemoveUsersFlooding;
label_1:
        int num1 = 1105378853;
        while (true)
        {
          int num2 = 1719079315;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 746958827 ^ 214554550;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return removeUsersFlooding;
      }
      set
      {
label_1:
        int num1 = -2118727390;
        while (true)
        {
          int num2 = -1488349756;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -48019397 ^ -1984556928;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3035434931U));
              num1 = (int) num3 * 1364833342 ^ -1151416353;
              continue;
            case 3:
              int num4 = flag ? -1979378578 : (num4 = -1722281446);
              int num5 = (int) num3 * 596942169;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * 1443747465 ^ 183000954;
              continue;
            case 5:
              Engine.Instance.Settings.RemoveUsersFlooding = value;
              num1 = -1217571776;
              continue;
            case 6:
              flag = Engine.Instance.Settings.RemoveUsersFlooding == value;
              num1 = (int) num3 * 1317654518 ^ 1289963163;
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
    }

    public bool FloodAfterHold
    {
      get
      {
label_1:
        int num1 = 2115833109;
        bool floodAfterHold;
        while (true)
        {
          int num2 = 353787176;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              floodAfterHold = Engine.Instance.Settings.FloodAfterHold;
              num1 = (int) num3 * 2054432019 ^ 229157126;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return floodAfterHold;
      }
      set
      {
        if (Engine.Instance.Settings.FloodAfterHold != value)
          goto label_21;
label_1:
        int num1 = -1914194232;
label_2:
        while (true)
        {
          int num2 = -1703604605;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              if (this.FloodAfterHold)
              {
                num1 = -589873511;
                continue;
              }
              num4 = 0;
              goto label_19;
            case 1:
              if (!this.FloodAfterHold)
              {
                num5 = 0;
                break;
              }
              num1 = (int) num3 * -1349541369 ^ 1190290715;
              continue;
            case 2:
              this.MoveNextAfterHold = false;
              num1 = (int) num3 * 1735325258 ^ 982247477;
              continue;
            case 3:
              this.HammerAfterHold = false;
              num1 = (int) num3 * -1925365182 ^ 472641961;
              continue;
            case 4:
              num1 = (int) num3 * -1823437112 ^ 589543925;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            case 7:
              int num6 = !flag1 ? 375509767 : (num6 = 593295939);
              int num7 = (int) num3 * 1264877890;
              num1 = num6 ^ num7;
              continue;
            case 8:
              int num8 = !flag2 ? 2021270691 : (num8 = 1496452406);
              int num9 = (int) num3 * -2045370100;
              num1 = num8 ^ num9;
              continue;
            case 9:
              goto label_21;
            case 10:
              num4 = this.HammerAfterHold ? 1 : 0;
              goto label_19;
            case 11:
              num5 = this.MoveNextAfterHold ? 1 : 0;
              break;
            case 12:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3147806627U));
              num1 = (int) num3 * -1345800746 ^ 1706679908;
              continue;
            case 13:
              num1 = (int) num3 * 255263213 ^ -868172756;
              continue;
            default:
              goto label_22;
          }
          flag1 = num5 != 0;
          num1 = -1128721436;
          continue;
label_19:
          flag2 = num4 != 0;
          num1 = -133831189;
        }
label_22:
        return;
label_3:
        return;
label_21:
        Engine.Instance.Settings.FloodAfterHold = value;
        num1 = -1654392267;
        goto label_2;
      }
    }

    public bool HammerAfterHold
    {
      get
      {
label_1:
        int num1 = 1880040939;
        bool hammerAfterHold;
        while (true)
        {
          int num2 = 1041363536;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1328657517 ^ 1268323321;
              continue;
            case 2:
              goto label_1;
            case 3:
              hammerAfterHold = Engine.Instance.Settings.HammerAfterHold;
              num1 = (int) num3 * -1032049735 ^ -1570157409;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return hammerAfterHold;
      }
      set
      {
label_1:
        int num1 = 1821363846;
        while (true)
        {
          int num2 = 1087852954;
          uint num3;
          bool flag1;
          bool flag2;
          bool flag3;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 19U)
          {
            case 0:
              if (!this.HammerAfterHold)
              {
                num4 = 0;
                break;
              }
              num1 = 184479468;
              continue;
            case 1:
              int num6 = !flag2 ? -1646405023 : (num6 = -1057079654);
              int num7 = (int) num3 * -100454849;
              num1 = num6 ^ num7;
              continue;
            case 2:
              num1 = (int) num3 * 37372036 ^ 128239162;
              continue;
            case 3:
              flag2 = Engine.Instance.Settings.HammerAfterHold == value;
              num1 = (int) num3 * -839517605 ^ 489203337;
              continue;
            case 4:
              this.FloodAfterHold = false;
              num1 = (int) num3 * 1988210935 ^ 1017158118;
              continue;
            case 5:
              if (!this.HammerAfterHold)
              {
                num5 = 0;
                goto label_21;
              }
              else
              {
                num1 = (int) num3 * -733597518 ^ 1386219157;
                continue;
              }
            case 6:
              int num8 = flag1 ? -1572174423 : (num8 = -597463970);
              int num9 = (int) num3 * -249996905;
              num1 = num8 ^ num9;
              continue;
            case 7:
              num1 = (int) num3 * 22415602 ^ -884836641;
              continue;
            case 8:
              num5 = this.MoveNextAfterHold ? 1 : 0;
              goto label_21;
            case 9:
              Engine.Instance.Settings.HammerAfterHold = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(786030910U));
              num1 = 1403199541;
              continue;
            case 10:
              num1 = (int) num3 * -611343962 ^ -1791032526;
              continue;
            case 11:
              int num10 = !flag3 ? 1590114006 : (num10 = 183736479);
              int num11 = (int) num3 * 1031215296;
              num1 = num10 ^ num11;
              continue;
            case 12:
              num1 = (int) num3 * -79669903 ^ 600579392;
              continue;
            case 13:
              num1 = (int) num3 * -1629001417 ^ -104505016;
              continue;
            case 14:
              num4 = this.FloodAfterHold ? 1 : 0;
              break;
            case 15:
              num1 = (int) num3 * -696630515 ^ 1287796741;
              continue;
            case 16:
              this.MoveNextAfterHold = false;
              num1 = (int) num3 * -1515492463 ^ 2095901844;
              continue;
            case 17:
              goto label_3;
            case 18:
              goto label_1;
            default:
              goto label_27;
          }
          flag1 = num4 != 0;
          num1 = 591724314;
          continue;
label_21:
          flag3 = num5 != 0;
          num1 = 1811549781;
        }
label_27:
        return;
label_3:;
      }
    }

    public bool MoveNextAfterHold
    {
      get
      {
label_1:
        int num1 = -925581771;
        bool moveNextAfterHold;
        while (true)
        {
          int num2 = -1593609494;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -610446028 ^ -1826607652;
              continue;
            case 3:
              moveNextAfterHold = Engine.Instance.Settings.MoveNextAfterHold;
              num1 = (int) num3 * -1934537640 ^ -709013889;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return moveNextAfterHold;
      }
      set
      {
        if (Engine.Instance.Settings.MoveNextAfterHold != value)
          goto label_5;
label_1:
        int num1 = 748686816;
label_2:
        while (true)
        {
          int num2 = 349153082;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              this.FloodAfterHold = false;
              num1 = (int) num3 * 2138629080 ^ -745075389;
              continue;
            case 1:
              num1 = (int) num3 * -503423659 ^ -2147472710;
              continue;
            case 2:
              if (this.MoveNextAfterHold)
              {
                num1 = (int) num3 * 1817539296 ^ 1601221921;
                continue;
              }
              num4 = 0;
              goto label_23;
            case 3:
              int num6 = flag1 ? 2137663499 : (num6 = 480674612);
              int num7 = (int) num3 * -1848451491;
              num1 = num6 ^ num7;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1674405433U));
              num1 = (int) num3 * -1991578644 ^ 1721363272;
              continue;
            case 5:
              if (!this.MoveNextAfterHold)
              {
                num5 = 0;
                break;
              }
              num1 = 16705093;
              continue;
            case 6:
              num1 = (int) num3 * 670346196 ^ 71137778;
              continue;
            case 7:
              int num8 = !flag2 ? 987706514 : (num8 = 3134699);
              int num9 = (int) num3 * 1809194315;
              num1 = num8 ^ num9;
              continue;
            case 8:
              goto label_5;
            case 9:
              goto label_3;
            case 10:
              num1 = (int) num3 * 1056628956 ^ -2090582373;
              continue;
            case 11:
              num4 = this.HammerAfterHold ? 1 : 0;
              goto label_23;
            case 12:
              num1 = (int) num3 * 2113974549 ^ 857622232;
              continue;
            case 13:
              goto label_1;
            case 14:
              this.HammerAfterHold = false;
              num1 = (int) num3 * 923665986 ^ -25808793;
              continue;
            case 15:
              num5 = this.FloodAfterHold ? 1 : 0;
              break;
            default:
              goto label_24;
          }
          flag1 = num5 != 0;
          num1 = 1989231193;
          continue;
label_23:
          flag2 = num4 != 0;
          num1 = 254659085;
        }
label_24:
        return;
label_3:
        return;
label_5:
        Engine.Instance.Settings.MoveNextAfterHold = value;
        num1 = 783380398;
        goto label_2;
      }
    }

    public bool HammerAfterRemoved
    {
      get
      {
label_1:
        int num1 = -1446936281;
        bool hammerAfterRemoved;
        while (true)
        {
          int num2 = -184068845;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              hammerAfterRemoved = Engine.Instance.Settings.HammerAfterRemoved;
              num1 = (int) num3 * 1550927154 ^ -2115804750;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return hammerAfterRemoved;
      }
      set
      {
label_1:
        int num1 = 1586848266;
        while (true)
        {
          int num2 = 1817550391;
          uint num3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 2134572527 ^ 853534834;
              continue;
            case 2:
              num4 = this.MoveNextAfterRemoved ? 1 : 0;
              break;
            case 3:
              this.MoveNextAfterRemoved = false;
              num1 = (int) num3 * -478779636 ^ 971545763;
              continue;
            case 4:
              if (!this.HammerAfterRemoved)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * -2032973473 ^ -1262580083;
              continue;
            case 5:
              int num5 = Engine.Instance.Settings.HammerAfterRemoved != value ? -939265732 : (num5 = -1864290616);
              int num6 = (int) num3 * 484976071;
              num1 = num5 ^ num6;
              continue;
            case 6:
              num1 = (int) num3 * 1094375834 ^ -276143089;
              continue;
            case 7:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(637760619U));
              num1 = (int) num3 * 959426340 ^ -2086773160;
              continue;
            case 8:
              Engine.Instance.Settings.HammerAfterRemoved = value;
              num1 = 1642909516;
              continue;
            case 9:
              goto label_1;
            default:
              goto label_15;
          }
          int num7;
          num1 = num7 = num4 != 0 ? 382875988 : (num7 = 2059284743);
        }
label_15:
        return;
label_3:;
      }
    }

    public bool MoveNextAfterRemoved
    {
      get
      {
label_1:
        int num1 = -238260909;
        bool nextAfterRemoved;
        while (true)
        {
          int num2 = -1803466270;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              nextAfterRemoved = Engine.Instance.Settings.MoveNextAfterRemoved;
              num1 = (int) num3 * -1275745583 ^ 254844477;
              continue;
            case 2:
              num1 = (int) num3 * 2105739934 ^ 11885113;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return nextAfterRemoved;
      }
      set
      {
label_1:
        int num1 = -1312560704;
        while (true)
        {
          int num2 = -1446030060;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              num1 = (int) num3 * -497590495 ^ -443135718;
              continue;
            case 1:
              int num5 = Engine.Instance.Settings.MoveNextAfterRemoved != value ? 1874105915 : (num5 = 672132994);
              int num6 = (int) num3 * -563487015;
              num1 = num5 ^ num6;
              continue;
            case 2:
              if (!this.MoveNextAfterRemoved)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 326280999 ^ 40760560;
              continue;
            case 3:
              goto label_1;
            case 4:
              num4 = this.HammerAfterRemoved ? 1 : 0;
              break;
            case 5:
              num1 = (int) num3 * 1224511040 ^ 902293856;
              continue;
            case 6:
              goto label_3;
            case 7:
              Engine.Instance.Settings.MoveNextAfterRemoved = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(183661829U));
              num1 = -1985481022;
              continue;
            case 8:
              num1 = (int) num3 * -371962892 ^ -696645448;
              continue;
            case 9:
              int num7 = flag ? 420447424 : (num7 = 586207060);
              int num8 = (int) num3 * 847273211;
              num1 = num7 ^ num8;
              continue;
            case 10:
              num1 = (int) num3 * 806814881 ^ 211589435;
              continue;
            case 11:
              num1 = (int) num3 * -762715859 ^ 1009485692;
              continue;
            case 12:
              this.HammerAfterRemoved = false;
              num1 = (int) num3 * 1350868907 ^ -2033011962;
              continue;
            default:
              goto label_18;
          }
          flag = num4 != 0;
          num1 = -800901944;
        }
label_18:
        return;
label_3:;
      }
    }

    public bool DisplayHighlightWindows
    {
      get
      {
label_1:
        int num1 = 1447382334;
        bool highlightWindows;
        while (true)
        {
          int num2 = 880525628;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              highlightWindows = Engine.Instance.Settings.DisplayHighlightWindows;
              num1 = (int) num3 * -2047775847 ^ -1446990943;
              continue;
            case 3:
              num1 = (int) num3 * 1924897119 ^ 437552040;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return highlightWindows;
      }
      set
      {
label_1:
        int num1 = 75784858;
        while (true)
        {
          int num2 = 697675245;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 1011148504 ^ 83126152;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = flag ? 1434937327 : (num4 = 802517210);
              int num5 = (int) num3 * 1194757276;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag = Engine.Instance.Settings.DisplayHighlightWindows == value;
              num1 = (int) num3 * 881439427 ^ -505782772;
              continue;
            case 5:
              Engine.Instance.Settings.DisplayHighlightWindows = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2454500097U));
              num1 = 214219027;
              continue;
            case 6:
              num1 = (int) num3 * -1238470650 ^ 165194100;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool JoinDynamicUserName
    {
      get
      {
        return Engine.Instance.Settings.JoinDynamicUserName;
      }
      set
      {
label_1:
        int num1 = -1347561099;
        while (true)
        {
          int num2 = -98110510;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              Engine.Instance.Settings.JoinDynamicUserName = value;
              num1 = -364610355;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1842390155U));
              num1 = (int) num3 * 1682369088 ^ -1434698550;
              continue;
            case 4:
              num1 = (int) num3 * 1714804682 ^ -698437334;
              continue;
            case 5:
              flag = Engine.Instance.Settings.JoinDynamicUserName == value;
              num1 = (int) num3 * -1354310893 ^ -266070751;
              continue;
            case 6:
              int num4 = !flag ? -1456295257 : (num4 = -1730691504);
              int num5 = (int) num3 * -1971906341;
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
    }

    public bool MeetingAutoFindUsersEnabled
    {
      get
      {
        bool findUsersEnabled = Engine.Instance.Settings.MeetingAutoFindUsersEnabled;
label_1:
        int num1 = 639044093;
        while (true)
        {
          int num2 = 1398860316;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -796590199 ^ -1040708384;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return findUsersEnabled;
      }
      set
      {
label_1:
        int num1 = 1753199338;
        while (true)
        {
          int num2 = 2065732866;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2201205974U));
              num1 = (int) num3 * 1473806565 ^ -1750143102;
              continue;
            case 1:
              flag = Engine.Instance.Settings.MeetingAutoFindUsersEnabled == value;
              num1 = (int) num3 * 1149942155 ^ 1308378577;
              continue;
            case 2:
              Engine.Instance.Settings.MeetingAutoFindUsersEnabled = value;
              num1 = 327307727;
              continue;
            case 3:
              num1 = (int) num3 * -2007477690 ^ 1715928182;
              continue;
            case 4:
              num1 = (int) num3 * -1888033480 ^ -350530084;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            case 7:
              int num4 = !flag ? -446858630 : (num4 = -311756408);
              int num5 = (int) num3 * -1512441673;
              num1 = num4 ^ num5;
              continue;
            case 8:
              num1 = (int) num3 * 1847977767 ^ -1875421522;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public bool CheckCapabilitiesAfterJoin
    {
      get
      {
label_1:
        int num1 = 1960998669;
        bool capabilitiesAfterJoin;
        while (true)
        {
          int num2 = 1485310250;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 2013809973 ^ -620633047;
              continue;
            case 3:
              capabilitiesAfterJoin = Engine.Instance.Settings.CheckCapabilitiesAfterJoin;
              num1 = (int) num3 * 155145889 ^ 1258602803;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return capabilitiesAfterJoin;
      }
      set
      {
label_1:
        int num1 = 386069403;
        while (true)
        {
          int num2 = 1821511584;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = flag ? 637266028 : (num4 = 2066409326);
              int num5 = (int) num3 * 2107580637;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag = Engine.Instance.Settings.CheckCapabilitiesAfterJoin == value;
              num1 = (int) num3 * -2025664242 ^ 2054741630;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1766403989 ^ -116360475;
              continue;
            case 4:
              Engine.Instance.Settings.CheckCapabilitiesAfterJoin = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1417788953U));
              num1 = 164483202;
              continue;
            case 5:
              goto label_3;
            case 6:
              num1 = (int) num3 * -592822864 ^ -305915507;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool FindButtonsAfterJoin
    {
      get
      {
        bool buttonsAfterJoin = Engine.Instance.Settings.FindButtonsAfterJoin;
label_1:
        int num1 = 1063052354;
        while (true)
        {
          int num2 = 269187855;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1392410346 ^ -1197455776;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return buttonsAfterJoin;
      }
      set
      {
label_1:
        int num1 = 230020779;
        while (true)
        {
          int num2 = 1077768881;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * 2080226917 ^ 1439060465;
              continue;
            case 1:
              flag = Engine.Instance.Settings.FindButtonsAfterJoin == value;
              num1 = (int) num3 * 343049244 ^ 708142472;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809550069U));
              num1 = (int) num3 * -569667726 ^ 1707140781;
              continue;
            case 3:
              Engine.Instance.Settings.FindButtonsAfterJoin = value;
              num1 = 904046820;
              continue;
            case 4:
              int num4 = !flag ? -988666209 : (num4 = -689526932);
              int num5 = (int) num3 * 1814266819;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_3;
            case 6:
              num1 = (int) num3 * -564922658 ^ -1675137269;
              continue;
            case 7:
              num1 = (int) num3 * -843245275 ^ 262911171;
              continue;
            case 8:
              goto label_1;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public bool MinimumUserEnforced
    {
      get
      {
        bool minimumUserEnforced = Engine.Instance.Settings.MinimumUserEnforced;
label_1:
        int num1 = -461009435;
        while (true)
        {
          int num2 = -1965175004;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 2000754734 ^ 1232229493;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return minimumUserEnforced;
      }
      set
      {
        bool flag = Engine.Instance.Settings.MinimumUserEnforced == value;
label_1:
        int num1 = 1628089313;
        while (true)
        {
          int num2 = 278080573;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              Engine.Instance.Settings.MinimumUserEnforced = value;
              num1 = 814290427;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = flag ? -1968515709 : (num4 = -1959026721);
              int num5 = (int) num3 * 2085156815;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * 1314930259 ^ -2015532880;
              continue;
            case 5:
              num1 = (int) num3 * 210234759 ^ -1648981298;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2074214774U));
              num1 = (int) num3 * 589000501 ^ 955246323;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public int MinimumUserCount
    {
      get
      {
label_1:
        int num1 = -811228665;
        int minimumUserCount;
        while (true)
        {
          int num2 = -650577141;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              minimumUserCount = Engine.Instance.Settings.MinimumUserCount;
              num1 = (int) num3 * -1260910654 ^ -546999597;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return minimumUserCount;
      }
      set
      {
        bool flag = Engine.Instance.Settings.MinimumUserCount == value;
label_1:
        int num1 = -1245365736;
        while (true)
        {
          int num2 = -170397922;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2081910947U));
              num1 = (int) num3 * 1295099656 ^ 1504931651;
              continue;
            case 2:
              num1 = (int) num3 * -703313455 ^ 333809383;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -1108829735 ^ -577174541;
              continue;
            case 5:
              num1 = (int) num3 * -1528941138 ^ 554328747;
              continue;
            case 6:
              int num4 = !flag ? 879642149 : (num4 = 344967448);
              int num5 = (int) num3 * -1671350574;
              num1 = num4 ^ num5;
              continue;
            case 7:
              Engine.Instance.Settings.MinimumUserCount = value;
              num1 = -533488998;
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

    public double MaximumAttendenceDuration
    {
      get
      {
label_1:
        int num1 = -193343886;
        double attendenceDuration;
        while (true)
        {
          int num2 = -1917558237;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              attendenceDuration = Engine.Instance.Settings.MaximumAttendenceDuration;
              num1 = (int) num3 * -160420886 ^ -165271102;
              continue;
            case 3:
              num1 = (int) num3 * -1782186042 ^ -297871053;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return attendenceDuration;
      }
      set
      {
label_1:
        int num1 = 1135305627;
        while (true)
        {
          int num2 = 586316626;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -551997477 ^ 1376294786;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1831158811U));
              num1 = (int) num3 * 2030063976 ^ -485150219;
              continue;
            case 2:
              goto label_3;
            case 3:
              Engine.Instance.Settings.MaximumAttendenceDuration = value;
              num1 = 1661440844;
              continue;
            case 4:
              int num4 = flag ? 1046861159 : (num4 = 1599158420);
              int num5 = (int) num3 * 211368139;
              num1 = num4 ^ num5;
              continue;
            case 5:
              flag = Engine.Instance.Settings.MaximumAttendenceDuration == value;
              num1 = (int) num3 * 776363164 ^ 2075322558;
              continue;
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
    }

    public bool MaximumAttendenceEnforced
    {
      get
      {
label_1:
        int num1 = -1139020707;
        bool flag;
        while (true)
        {
          int num2 = -1500357152;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -2027401017 ^ -56275266;
              continue;
            case 1:
              flag = this.MaximumAttendenceDuration > 0.0;
              num1 = (int) num3 * -770897894 ^ -1927964754;
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
      set
      {
        if (!value)
          goto label_7;
label_1:
        int num1 = 429734844;
label_2:
        bool flag1;
        while (true)
        {
          int num2 = 1838091157;
          uint num3;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              num1 = (int) num3 * -958945031 ^ -684779044;
              continue;
            case 1:
              if (!value)
              {
                num1 = 531086809;
                continue;
              }
              num4 = 0;
              break;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1335822720 ^ 1778908070;
              continue;
            case 4:
              num1 = (int) num3 * -2114519031 ^ 1145670153;
              continue;
            case 5:
              int num5 = !flag2 ? -1305953023 : (num5 = -1599692287);
              int num6 = (int) num3 * -897158434;
              num1 = num5 ^ num6;
              continue;
            case 6:
              num1 = 391882875;
              continue;
            case 7:
              goto label_6;
            case 8:
              int num7 = flag1 ? 1772472682 : (num7 = 1828549142);
              int num8 = (int) num3 * -697912381;
              num1 = num7 ^ num8;
              continue;
            case 9:
              flag2 = value;
              num1 = 29533698;
              continue;
            case 10:
              num4 = this.MaximumAttendenceDuration == 0.0 ? 1 : 0;
              break;
            case 11:
              num1 = (int) num3 * 1930643797 ^ 657575423;
              continue;
            case 12:
              this.MaximumAttendenceDuration = 0.0;
              num1 = (int) num3 * -1304901043 ^ 908832890;
              continue;
            case 13:
              goto label_3;
            case 14:
              num1 = (int) num3 * -1759468450 ^ -51513666;
              continue;
            case 15:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(68578659U));
              num1 = 1303267380;
              continue;
            case 16:
              this.MaximumAttendenceDuration = 120.0;
              num1 = (int) num3 * 1357033772 ^ -532685561;
              continue;
            case 17:
              num1 = (int) num3 * 497726405 ^ 863592643;
              continue;
            default:
              goto label_25;
          }
          int num9;
          num1 = num9 = num4 != 0 ? 463716063 : (num9 = 32874368);
        }
label_25:
        return;
label_3:
        return;
label_6:
        int num10 = this.MaximumAttendenceDuration > 0.0 ? 1 : 0;
        goto label_8;
label_7:
        num10 = 0;
label_8:
        flag1 = num10 != 0;
        num1 = 312316021;
        goto label_2;
      }
    }

    public bool AutoOpenManyCamBroadcast
    {
      get
      {
label_1:
        int num1 = 413390488;
        bool manyCamBroadcast;
        while (true)
        {
          int num2 = 36921469;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              manyCamBroadcast = Engine.Instance.Settings.AutoOpenManyCamBroadcast;
              num1 = (int) num3 * 209811353 ^ 1679700928;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return manyCamBroadcast;
      }
      set
      {
label_1:
        int num1 = -1905598063;
        while (true)
        {
          int num2 = -934831645;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * 307027709 ^ 1838496463;
              continue;
            case 1:
              Engine.Instance.Settings.AutoOpenManyCamBroadcast = value;
              num1 = -520634379;
              continue;
            case 2:
              flag = Engine.Instance.Settings.AutoOpenManyCamBroadcast == value;
              num1 = (int) num3 * -2040171673 ^ 368259586;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              num1 = (int) num3 * -321731062 ^ -935167387;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3405189461U));
              num1 = (int) num3 * -422276234 ^ -870396182;
              continue;
            case 7:
              int num4 = !flag ? 1830466253 : (num4 = 2007769612);
              int num5 = (int) num3 * -1916893735;
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
    }

    public bool AutoResponderEnabled
    {
      get
      {
        bool responderEnabled = Engine.Instance.Settings.AutoResponderEnabled;
label_1:
        int num1 = 628953413;
        while (true)
        {
          int num2 = 1307467217;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 878320444 ^ 1535900318;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return responderEnabled;
      }
      set
      {
label_1:
        int num1 = 1657855291;
        while (true)
        {
          int num2 = 917233248;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = Engine.Instance.Settings.AutoResponderEnabled == value ? 1595224305 : (num4 = 1916260958);
              int num5 = (int) num3 * -562211199;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * -392067005 ^ 662735682;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2600965803U));
              num1 = (int) num3 * 912017241 ^ 446982489;
              continue;
            case 4:
              goto label_1;
            case 5:
              Engine.Instance.Settings.AutoResponderEnabled = value;
              num1 = 2082915757;
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

    public string AutoResponderMessage
    {
      get
      {
label_1:
        int num1 = 66108431;
        string responderMessage;
        while (true)
        {
          int num2 = 577224734;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              responderMessage = Engine.Instance.Settings.AutoResponderMessage;
              num1 = (int) num3 * 1400460140 ^ 1709351835;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return responderMessage;
      }
      set
      {
label_1:
        int num1 = -862845812;
        while (true)
        {
          int num2 = -1737392946;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -924904274 ^ 340960117;
              continue;
            case 1:
              num1 = (int) num3 * 862129582 ^ -493773164;
              continue;
            case 2:
              goto label_3;
            case 3:
              Engine.Instance.Settings.AutoResponderMessage = value;
              num1 = -483714328;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1938296763U));
              num1 = (int) num3 * 1749534687 ^ -405274633;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(Engine.Instance.Settings.AutoResponderMessage, value) ? 1316013703 : (num4 = 2053105384);
              int num5 = (int) num3 * -1510237797;
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
    }

    public bool AutoRespondBlockedUser
    {
      get
      {
label_1:
        int num1 = -381241189;
        bool respondBlockedUser;
        while (true)
        {
          int num2 = -1563597624;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1330989240 ^ -1741438347;
              continue;
            case 2:
              goto label_1;
            case 3:
              respondBlockedUser = Engine.Instance.Settings.AutoRespondBlockedUser;
              num1 = (int) num3 * 1168609313 ^ 1352222535;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return respondBlockedUser;
      }
      set
      {
        if (Engine.Instance.Settings.AutoRespondBlockedUser != value)
          goto label_6;
label_1:
        int num1 = 637890538;
label_2:
        while (true)
        {
          int num2 = 828969360;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_6;
            case 1:
              num1 = (int) num3 * -1308162632 ^ -1216646649;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * 705702034 ^ 1334656587;
              continue;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2553522309U));
              num1 = (int) num3 * -215515178 ^ -388282721;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:
        return;
label_6:
        Engine.Instance.Settings.AutoRespondBlockedUser = value;
        num1 = 172061771;
        goto label_2;
      }
    }

    public string AutoRespondBlockedUserMessage
    {
      get
      {
label_1:
        int num1 = 302790525;
        string blockedUserMessage;
        while (true)
        {
          int num2 = 1555524186;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              blockedUserMessage = Engine.Instance.Settings.AutoRespondBlockedUserMessage;
              num1 = (int) num3 * -76102330 ^ -1345411917;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return blockedUserMessage;
      }
      set
      {
label_1:
        int num1 = -2124819439;
        while (true)
        {
          int num2 = -1531122579;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -663581993 ^ -1703699752;
              continue;
            case 1:
              Engine.Instance.Settings.AutoRespondBlockedUserMessage = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3332932112U));
              num1 = -19354974;
              continue;
            case 2:
              num1 = (int) num3 * 451571029 ^ -1559392747;
              continue;
            case 3:
              flag = SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(Engine.Instance.Settings.AutoRespondBlockedUserMessage, value);
              num1 = (int) num3 * -904770492 ^ 1192984514;
              continue;
            case 4:
              int num4 = !flag ? 171884227 : (num4 = 1202738013);
              int num5 = (int) num3 * -331879284;
              num1 = num4 ^ num5;
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
    }

    public string AutoRespondBlockedUserList
    {
      get
      {
label_1:
        int num1 = 266560220;
        string respondBlockedUserList;
        while (true)
        {
          int num2 = 106659257;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              respondBlockedUserList = Engine.Instance.Settings.AutoRespondBlockedUserList;
              num1 = (int) num3 * -1091813832 ^ -896305346;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 32192196 ^ -678992095;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return respondBlockedUserList;
      }
      set
      {
label_1:
        int num1 = -822515501;
        while (true)
        {
          int num2 = -610923634;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 1783863407 ^ 1503544462;
              continue;
            case 1:
              int num4 = !flag ? 807792991 : (num4 = 1464559986);
              int num5 = (int) num3 * 865038353;
              num1 = num4 ^ num5;
              continue;
            case 2:
              Engine.Instance.Settings.AutoRespondBlockedUserList = value;
              num1 = -1544747174;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3540794963U));
              num1 = (int) num3 * -959577286 ^ -1543485033;
              continue;
            case 4:
              flag = SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(Engine.Instance.Settings.AutoRespondBlockedUserList, value);
              num1 = (int) num3 * -1849891603 ^ 774813124;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool SendGreetingAfterJoin
    {
      get
      {
        return Engine.Instance.Settings.SendGreetingAfterJoin;
      }
      set
      {
        if (Engine.Instance.Settings.SendGreetingAfterJoin != value)
          goto label_5;
label_1:
        int num1 = 1920444816;
label_2:
        while (true)
        {
          int num2 = 353000949;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1457465435U));
              num1 = (int) num3 * -538760123 ^ 1388895469;
              continue;
            case 2:
              goto label_5;
            case 3:
              num1 = (int) num3 * -1345114527 ^ 746979037;
              continue;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        Engine.Instance.Settings.SendGreetingAfterJoin = value;
        num1 = 1780426116;
        goto label_2;
      }
    }

    public bool FloodAfterJoin
    {
      get
      {
label_1:
        int num1 = -1640716139;
        bool floodAfterJoin;
        while (true)
        {
          int num2 = -942240118;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 2855964 ^ 1821714823;
              continue;
            case 3:
              floodAfterJoin = Engine.Instance.Settings.FloodAfterJoin;
              num1 = (int) num3 * 810720288 ^ -1669621980;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return floodAfterJoin;
      }
      set
      {
label_1:
        int num1 = 876444256;
        while (true)
        {
          int num2 = 774912448;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              int num4 = flag ? 1358848778 : (num4 = 1859336246);
              int num5 = (int) num3 * 922127284;
              num1 = num4 ^ num5;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1284841316U));
              num1 = (int) num3 * -95540281 ^ 2119534498;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -568039128 ^ 1850663214;
              continue;
            case 4:
              num1 = (int) num3 * -1582047343 ^ -952474700;
              continue;
            case 5:
              flag = Engine.Instance.Settings.FloodAfterJoin == value;
              num1 = (int) num3 * -2016456091 ^ -380109122;
              continue;
            case 6:
              Engine.Instance.Settings.FloodAfterJoin = value;
              num1 = 633655695;
              continue;
            case 7:
              goto label_3;
            case 8:
              num1 = (int) num3 * -79151978 ^ 1267214839;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public bool FloodPrivatelyAfterJoin
    {
      get
      {
        return Engine.Instance.Settings.FloodPrivatelyAfterJoin;
      }
      set
      {
        if (Engine.Instance.Settings.FloodPrivatelyAfterJoin != value)
          goto label_6;
label_1:
        int num1 = 1222785851;
label_2:
        while (true)
        {
          int num2 = 1637942620;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_6;
            case 1:
              num1 = (int) num3 * 657876620 ^ -37557305;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 763532964 ^ -1669015065;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_6:
        Engine.Instance.Settings.FloodPrivatelyAfterJoin = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3046898139U));
        num1 = 43949633;
        goto label_2;
      }
    }

    public bool VideoChatLinkAutoInitiate
    {
      get
      {
label_1:
        int num1 = 740463663;
        bool linkAutoInitiate;
        while (true)
        {
          int num2 = 709791825;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              linkAutoInitiate = Engine.Instance.Settings.VideoChatLinkAutoInitiate;
              num1 = (int) num3 * -735321148 ^ -1132043991;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return linkAutoInitiate;
      }
      set
      {
label_1:
        int num1 = -1111119793;
        while (true)
        {
          int num2 = -1121092495;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num4 = Engine.Instance.Settings.VideoChatLinkAutoInitiate == value ? 1822765729 : (num4 = 1940296229);
              int num5 = (int) num3 * -60282067;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(527124556U));
              num1 = (int) num3 * 1061864030 ^ -66976965;
              continue;
            case 4:
              num1 = (int) num3 * 1337274810 ^ -312401894;
              continue;
            case 5:
              num1 = (int) num3 * 1796462249 ^ 154761700;
              continue;
            case 6:
              Engine.Instance.Settings.VideoChatLinkAutoInitiate = value;
              num1 = -705270988;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool AutoLayoutsDefaultStretchingEnabled
    {
      get
      {
label_1:
        int num1 = 547476504;
        bool stretchingEnabled;
        while (true)
        {
          int num2 = 1775066190;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              stretchingEnabled = Engine.Instance.Settings.AutoLayoutsDefaultStretchingEnabled;
              num1 = (int) num3 * 2029229393 ^ 391657158;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return stretchingEnabled;
      }
      set
      {
        if (Engine.Instance.Settings.AutoLayoutsDefaultStretchingEnabled != value)
          goto label_5;
label_1:
        int num1 = -1879201793;
label_2:
        while (true)
        {
          int num2 = -580593747;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              goto label_5;
            case 3:
              num1 = (int) num3 * -877762013 ^ -1703213829;
              continue;
            case 4:
              num1 = (int) num3 * 575796936 ^ -1714384771;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        Engine.Instance.Settings.AutoLayoutsDefaultStretchingEnabled = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1706451366U));
        num1 = -733646625;
        goto label_2;
      }
    }

    public LockedObservableCollection<MessageCategory> ChatCategories
    {
      get
      {
label_1:
        int num1 = 1926836686;
        LockedObservableCollection<MessageCategory> chatCategories;
        while (true)
        {
          int num2 = 1700107664;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 756103024 ^ 1018254564;
              continue;
            case 2:
              chatCategories = this.chatCategories;
              num1 = (int) num3 * 1853145174 ^ 278658565;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return chatCategories;
      }
      set
      {
        this.chatCategories = value;
      }
    }

    public List<StringItem> FloodTargets
    {
      get
      {
        List<StringItem> floodTargets = this.floodTargets;
label_1:
        int num1 = -1816021783;
        while (true)
        {
          int num2 = -2075258251;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -595844196 ^ 2000298193;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return floodTargets;
      }
      set
      {
label_1:
        int num1 = -1726425675;
        while (true)
        {
          int num2 = -807061057;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.floodTargets = new List<StringItem>();
              num1 = (int) num3 * -217553522 ^ -587074532;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2696711573U));
              num1 = (int) num3 * 1611382860 ^ 2021592374;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public string ForceMeeting
    {
      get
      {
        string forceMeeting = this.Engine.Settings.ForceMeeting;
label_1:
        int num1 = 615277263;
        while (true)
        {
          int num2 = 563537220;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 135188726 ^ 1869678469;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return forceMeeting;
      }
      set
      {
label_1:
        int num1 = -1482366928;
        while (true)
        {
          int num2 = -1782362824;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4222765809U));
              num1 = (int) num3 * -372455656 ^ 411096901;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -463835327 ^ 206103335;
              continue;
            case 4:
              this.Engine.Settings.ForceMeeting = value;
              num1 = (int) num3 * 1826895318 ^ -1649490796;
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

    public string FloodOptions_MessageContent
    {
      get
      {
label_1:
        int num1 = -1256996455;
        string optionsMessageContent;
        while (true)
        {
          int num2 = -1248628590;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              optionsMessageContent = this.Engine.Settings.FloodOptions_MessageContent;
              num1 = (int) num3 * 1962366310 ^ 1283202397;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return optionsMessageContent;
      }
      set
      {
        this.Engine.Settings.FloodOptions_MessageContent = value;
label_1:
        int num1 = -381888818;
        while (true)
        {
          int num2 = -1273939820;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * 414286015 ^ -32659165;
              continue;
            case 1:
              num1 = (int) num3 * -1305020165 ^ 532432177;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1894161453U));
              num1 = (int) num3 * 936793866 ^ 891014712;
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

    public string FloodTargetNames
    {
      get
      {
        string floodTargetNames = this.Engine.Settings.FloodTargetNames;
label_1:
        int num1 = -690519663;
        while (true)
        {
          int num2 = -1809562686;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -365908988 ^ -911149158;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return floodTargetNames;
      }
      set
      {
label_1:
        int num1 = -421551704;
        while (true)
        {
          int num2 = -892578083;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.Engine.Settings.FloodTargetNames = value;
              num1 = (int) num3 * -1742384507 ^ 808764762;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(105474472U));
      }
    }

    public MessageCategory SelectedChatCategory
    {
      get
      {
label_1:
        int num1 = 578733905;
        MessageCategory selectedChatCategory;
        while (true)
        {
          int num2 = 392652406;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              selectedChatCategory = this.selectedChatCategory;
              num1 = (int) num3 * -615748981 ^ -1479792379;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedChatCategory;
      }
      set
      {
        this.selectedChatCategory = value;
        if (this.selectedChatCategory == null)
          goto label_8;
label_1:
        int num1 = -801173237;
label_2:
        while (true)
        {
          int num2 = -1725411482;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 165899873 ^ 810669448;
              continue;
            case 2:
              ZoomZoom.Properties.Settings.Default.ChatSource = this.selectedChatCategory.CategoryName;
              num1 = (int) num3 * 1973254613 ^ -1572540913;
              continue;
            case 3:
              SettingsViewModel.\u200E‏⁮​​⁭‏⁮⁫‭‬⁫‍‮‮‮‍‭⁪‮‫‬⁫⁪‫⁫⁮‎‌​⁬‭‍​⁫‌‏⁮‭‎‮((SettingsBase) ZoomZoom.Properties.Settings.Default);
              num1 = (int) num3 * -569867135 ^ -2084791831;
              continue;
            case 4:
              num1 = (int) num3 * -2139136199 ^ -1534036348;
              continue;
            case 5:
              num1 = (int) num3 * -265930547 ^ 82208701;
              continue;
            case 6:
              goto label_8;
            case 7:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:
        return;
label_8:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3059511700U));
        num1 = -665937481;
        goto label_2;
      }
    }

    public bool FloodTargetsAfterJoin
    {
      get
      {
label_1:
        int num1 = -1904802427;
        bool targetsAfterJoin;
        while (true)
        {
          int num2 = -431995944;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              targetsAfterJoin = this.Engine.Settings.FloodTargetsAfterJoin;
              num1 = (int) num3 * -1443051973 ^ -256178710;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return targetsAfterJoin;
      }
      set
      {
label_1:
        int num1 = -2067826567;
        while (true)
        {
          int num2 = -379018376;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              this.Engine.Settings.FloodTargetsAfterJoin = value;
              num1 = (int) num3 * 1536993011 ^ -372049877;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1505765071U));
              num1 = (int) num3 * -1955557291 ^ -1545174117;
              continue;
            case 3:
              num1 = (int) num3 * 695123550 ^ -677713581;
              continue;
            case 4:
              num1 = (int) num3 * 2052535563 ^ 853666748;
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
    }

    public bool FloodHostAfterJoin
    {
      get
      {
label_1:
        int num1 = 1837853444;
        bool floodHostAfterJoin;
        while (true)
        {
          int num2 = 1275215061;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              floodHostAfterJoin = this.Engine.Settings.FloodHostAfterJoin;
              num1 = (int) num3 * -426547984 ^ 497569324;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return floodHostAfterJoin;
      }
      set
      {
label_1:
        int num1 = -1226107665;
        while (true)
        {
          int num2 = -484484533;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.Engine.Settings.FloodHostAfterJoin = value;
              num1 = (int) num3 * -644478904 ^ 1100859091;
              continue;
            case 2:
              num1 = (int) num3 * -1680410709 ^ -1554333739;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3104499339U));
              num1 = (int) num3 * 765581574 ^ -1490319242;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public bool EngineView_DisplayQuickLinkBar
    {
      get
      {
        bool displayQuickLinkBar = this.engineView_DisplayQuickLinkBar;
label_1:
        int num1 = 122611574;
        while (true)
        {
          int num2 = 507882164;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1904706018 ^ 583879043;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return displayQuickLinkBar;
      }
      set
      {
        this.engineView_DisplayQuickLinkBar = value;
label_1:
        int num1 = -1168486257;
        while (true)
        {
          int num2 = -503229291;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              int num4 = !value ? 1637314598 : (num4 = 639903904);
              int num5 = (int) num3 * 1814485800;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.ToggleDisplayBars(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(150633176U));
              num1 = (int) num3 * -113611438 ^ 719616052;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(150633176U));
              num1 = (int) num3 * 1076368923 ^ -1431402000;
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

    public bool EngineView_DisplayMeetingBar
    {
      get
      {
label_1:
        int num1 = 435045872;
        bool displayMeetingBar;
        while (true)
        {
          int num2 = 141438555;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 771285547 ^ -2001975002;
              continue;
            case 2:
              goto label_1;
            case 3:
              displayMeetingBar = this.engineView_DisplayMeetingBar;
              num1 = (int) num3 * -71239563 ^ -1810199688;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return displayMeetingBar;
      }
      set
      {
label_1:
        int num1 = -1022738553;
        while (true)
        {
          int num2 = -1574961301;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = flag ? 1932040885 : (num4 = 1187968442);
              int num5 = (int) num3 * 50729994;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag = value;
              num1 = (int) num3 * -293827721 ^ -2033005587;
              continue;
            case 2:
              this.engineView_DisplayMeetingBar = value;
              num1 = (int) num3 * -2031009083 ^ -120336826;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              this.ToggleDisplayBars(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3864483837U));
              num1 = (int) num3 * -338952666 ^ 256151540;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(136193836U));
              num1 = (int) num3 * 1451900479 ^ 577563391;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool EngineView_DisplayChatBar
    {
      get
      {
        return this.engineView_DisplayChatBar;
      }
      set
      {
label_1:
        int num1 = -647997194;
        while (true)
        {
          int num2 = -1761613249;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.engineView_DisplayChatBar = value;
              num1 = (int) num3 * -1112815613 ^ 429583249;
              continue;
            case 2:
              num1 = (int) num3 * -213725298 ^ 170125711;
              continue;
            case 3:
              this.ToggleDisplayBars(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2275572063U));
              num1 = (int) num3 * -1439209897 ^ -1746782907;
              continue;
            case 4:
              int num4 = value ? -1752394444 : (num4 = -1203181079);
              int num5 = (int) num3 * 130863700;
              num1 = num4 ^ num5;
              continue;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2275572063U));
              num1 = (int) num3 * 507844963 ^ -428134022;
              continue;
            case 6:
              goto label_3;
            case 7:
              num1 = (int) num3 * 583248163 ^ 1198363804;
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

    public bool EngineView_DisplayActivityBar
    {
      get
      {
label_1:
        int num1 = 350311638;
        bool displayActivityBar;
        while (true)
        {
          int num2 = 1878744471;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              displayActivityBar = this.engineView_DisplayActivityBar;
              num1 = (int) num3 * 607360970 ^ 1478486470;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1092929405 ^ -1215795366;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return displayActivityBar;
      }
      set
      {
        this.engineView_DisplayActivityBar = value;
label_1:
        int num1 = -453737199;
        while (true)
        {
          int num2 = -309913795;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              flag = value;
              num1 = (int) num3 * -501770264 ^ -1922740407;
              continue;
            case 1:
              this.ToggleDisplayBars(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2328753163U));
              num1 = (int) num3 * 1726785755 ^ 1711330783;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -653370478 ^ -1165910624;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = flag ? -781770660 : (num4 = -1067816286);
              int num5 = (int) num3 * -344168208;
              num1 = num4 ^ num5;
              continue;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(512991911U));
              num1 = (int) num3 * -1329592731 ^ -1456216827;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool EngineView_DisplayImageBar
    {
      get
      {
        return this.engineView_DisplayImageBar;
      }
      set
      {
label_1:
        int num1 = 1485907862;
        while (true)
        {
          int num2 = 1738877327;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              this.engineView_DisplayImageBar = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2484702129U));
              num1 = (int) num3 * 1703299784 ^ -1305330306;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.ToggleDisplayBars(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(413408357U));
              num1 = (int) num3 * -973914697 ^ -1377614576;
              continue;
            case 4:
              num1 = (int) num3 * 563916999 ^ 694314529;
              continue;
            case 5:
              int num4 = !value ? -446053998 : (num4 = -1297609815);
              int num5 = (int) num3 * -64960403;
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
    }

    public bool EngineView_DisplayLayoutBar
    {
      get
      {
        bool displayLayoutBar = this.engineView_DisplayLayoutBar;
label_1:
        int num1 = 1846345754;
        while (true)
        {
          int num2 = 746966829;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1676459148 ^ 1495549235;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return displayLayoutBar;
      }
      set
      {
        this.engineView_DisplayLayoutBar = value;
label_1:
        int num1 = -1670497972;
        while (true)
        {
          int num2 = -328755487;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.ToggleDisplayBars(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4246283867U));
              num1 = (int) num3 * 1740045547 ^ 1452884694;
              continue;
            case 3:
              int num4 = !flag ? -1128523990 : (num4 = -1790484081);
              int num5 = (int) num3 * 792461703;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2536378914U));
              flag = value;
              num1 = (int) num3 * 1920324687 ^ 332429681;
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

    public bool EngineView_DisplaySettingsBar
    {
      get
      {
        return this.engineView_DisplaySettingsBar;
      }
      set
      {
        this.engineView_DisplaySettingsBar = value;
label_1:
        int num1 = 1164229396;
        while (true)
        {
          int num2 = 741591323;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = !value ? -1857305056 : (num4 = -316564023);
              int num5 = (int) num3 * 1841318919;
              num1 = num4 ^ num5;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3582803034U));
              num1 = (int) num3 * 211263910 ^ 1833962380;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.ToggleDisplayBars(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1194175395U));
              num1 = (int) num3 * 673053763 ^ -524434368;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * -1203198234 ^ -1531894593;
              continue;
            case 6:
              num1 = (int) num3 * 906961250 ^ 1307028576;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool DesktopAlert_Enabled
    {
      get
      {
label_1:
        int num1 = 113673158;
        bool desktopAlertEnabled;
        while (true)
        {
          int num2 = 272236083;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1114247417 ^ 1794970180;
              continue;
            case 1:
              desktopAlertEnabled = this.Engine.Settings.DesktopAlert_Enabled;
              num1 = (int) num3 * -1566975973 ^ 1805622928;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return desktopAlertEnabled;
      }
      set
      {
label_1:
        int num1 = 1213822833;
        while (true)
        {
          int num2 = 1441376916;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.Engine.Settings.DesktopAlert_Enabled = value;
              num1 = (int) num3 * -1768037764 ^ -2136050690;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3173983667U));
              num1 = (int) num3 * -1036862596 ^ -1889924929;
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
    }

    public bool DesktopAlert_ShowOnlyIfReceived
    {
      get
      {
label_1:
        int num1 = -1367928967;
        bool showOnlyIfReceived;
        while (true)
        {
          int num2 = -1539819483;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              showOnlyIfReceived = this.Engine.Settings.DesktopAlert_ShowOnlyIfReceived;
              num1 = (int) num3 * 1057947258 ^ -97444109;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return showOnlyIfReceived;
      }
      set
      {
        this.Engine.Settings.DesktopAlert_ShowOnlyIfReceived = value;
label_1:
        int num1 = 157460446;
        while (true)
        {
          int num2 = 1950862132;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 2031466313 ^ 307962775;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3840413169U));
              num1 = (int) num3 * 1859384920 ^ -1087111010;
              continue;
            case 4:
              num1 = (int) num3 * 1119380179 ^ 473698363;
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

    public string DesktopAlert_IgnoredUsers
    {
      get
      {
label_1:
        int num1 = 945391046;
        string alertIgnoredUsers;
        while (true)
        {
          int num2 = 582946028;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1114498016 ^ -240321237;
              continue;
            case 2:
              alertIgnoredUsers = this.Engine.Settings.DesktopAlert_IgnoredUsers;
              num1 = (int) num3 * 1732279413 ^ 2090537447;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return alertIgnoredUsers;
      }
      set
      {
        this.Engine.Settings.DesktopAlert_IgnoredUsers = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2067279689U));
label_1:
        int num1 = -752560431;
        while (true)
        {
          int num2 = -662753400;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -951933453 ^ 722792547;
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

    public List<string> OnHoldActions
    {
      get
      {
        if (this.onHoldActions == null)
          goto label_7;
label_1:
        int num1 = -241166574;
label_2:
        bool flag;
        List<string> onHoldActions;
        while (true)
        {
          int num2 = -1958644165;
          uint num3;
          int index;
          string str;
          string[] strArray;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              goto label_1;
            case 1:
              index = 0;
              num1 = (int) num3 * 106775794 ^ 1992053086;
              continue;
            case 3:
              str = strArray[index];
              num1 = -588705727;
              continue;
            case 4:
              int num4 = !flag ? 883337389 : (num4 = 1787760635);
              int num5 = (int) num3 * -1609040552;
              num1 = num4 ^ num5;
              continue;
            case 5:
              int num6;
              num1 = num6 = index >= strArray.Length ? -1843497988 : (num6 = -165155391);
              continue;
            case 6:
              num1 = (int) num3 * 480816482 ^ -640798333;
              continue;
            case 7:
              strArray = SettingsViewModel.\u200B‭‎‌‌‌⁬⁭‫⁯‪⁫‏​‫‬‌‫‫‮‪‏‏‪‏⁪‍‭‎‮⁯⁫⁫‏​⁯‪‮‌⁬‮(SettingsViewModel.\u202B⁪‏‪‍‏‏⁪‫‪‍‫‮⁮⁫‭⁮‍‮‌‍‎⁫‏‪‬‬‍​⁮‏⁭​​‭‮‭⁬‫‮(__typeref (OnHoldAction)));
              num1 = (int) num3 * 1311281149 ^ -207219700;
              continue;
            case 8:
              goto label_6;
            case 9:
              onHoldActions = this.onHoldActions;
              num1 = -440201913;
              continue;
            case 10:
              this.onHoldActions.Add(str);
              ++index;
              num1 = (int) num3 * -944094566 ^ -2003002044;
              continue;
            default:
              goto label_14;
          }
        }
label_6:
        int num7 = this.onHoldActions.Count == 0 ? 1 : 0;
        goto label_8;
label_14:
        return onHoldActions;
label_7:
        num7 = 1;
label_8:
        flag = num7 != 0;
        num1 = -294463173;
        goto label_2;
      }
      set
      {
label_1:
        int num1 = 1346727537;
        while (true)
        {
          int num2 = 473633504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.onHoldActions = value;
              num1 = (int) num3 * 2119151736 ^ -763275485;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4177696766U));
              num1 = (int) num3 * -966609465 ^ 931600329;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public OnHoldAction OnHoldAction
    {
      get
      {
label_1:
        int num1 = 588918282;
        OnHoldAction onHoldAction;
        while (true)
        {
          int num2 = 1304122580;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1284367158 ^ -1862769939;
              continue;
            case 2:
              onHoldAction = this.Engine.Settings.OnHoldAction;
              num1 = (int) num3 * -120613532 ^ -1869956591;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return onHoldAction;
      }
      set
      {
        this.Engine.Settings.OnHoldAction = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(347788501U));
      }
    }

    public bool AutoAttendent
    {
      get
      {
label_1:
        int num1 = 152214482;
        bool autoAttendent;
        while (true)
        {
          int num2 = 2043324199;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              autoAttendent = Engine.Instance.Settings.AutoAttendent;
              num1 = (int) num3 * -1895887129 ^ 1559966178;
              continue;
            case 2:
              num1 = (int) num3 * -1296819337 ^ 1683390633;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return autoAttendent;
      }
      set
      {
        if (Engine.Instance.Settings.AutoAttendent != value)
          goto label_5;
label_1:
        int num1 = -1062297979;
label_2:
        while (true)
        {
          int num2 = -1774361585;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -244194197 ^ -1367053446;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1685938634U));
              num1 = (int) num3 * 1755946368 ^ 1795736660;
              continue;
            case 4:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:
        return;
label_5:
        Engine.Instance.Settings.AutoAttendent = value;
        num1 = -1845501668;
        goto label_2;
      }
    }

    public SettingsViewModel()
    {
label_1:
      int num1 = 1711133132;
      while (true)
      {
        int num2 = 710308704;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 37490517 ^ -323800783;
            continue;
          case 3:
            this.Engine = Engine.Instance;
            num1 = (int) num3 * -404276340 ^ -311616376;
            continue;
          case 4:
            this.LoadCollections();
            num1 = (int) num3 * 1919744509 ^ -949406429;
            continue;
          case 5:
            this.ChatCategories = new LockedObservableCollection<MessageCategory>((Collection<MessageCategory>) this.Engine.MessageCategories, false);
            num1 = (int) num3 * 1264337339 ^ -1702182966;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void LoadCollections()
    {
      ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.CategoriesChanged), (ThreadOption) 1, false, (Predicate<ObjectChangedEventPayload>) (obj =>
      {
label_1:
        int num1 = 1377279087;
        bool flag;
        while (true)
        {
          int num2 = 1777334325;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              flag = SettingsViewModel.\u003C\u003Ec.\u200F‮‫⁫⁪⁬‏‌⁪‎⁬‏⁫‪⁪⁬⁯‮⁪‏⁮‌​​⁬⁮‫⁪‍⁭‬‌⁪‌⁬‫⁮​‎‎‮(obj.ObjectType, SettingsViewModel.\u003C\u003Ec.\u202D‮‫‌‏⁯‭⁪‫‫‍⁯​⁯‪‎⁪‮‫‍‭‫‭⁬‮‏⁯‎‌​​​⁪‌‪⁭‪⁬‫⁬‮(__typeref (MessageCategory)));
              num1 = (int) num3 * 650019416 ^ -882804714;
              continue;
            case 3:
              num1 = (int) num3 * 1002988669 ^ 1006743075;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return flag;
      }));
    }

    private void CategoriesChanged(ObjectChangedEventPayload obj)
    {
label_1:
      int num1 = -280001193;
      while (true)
      {
        int num2 = -41377724;
        uint num3;
        ChangeType changeType;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            ((Collection<MessageCategory>) this.ChatCategories).Add((MessageCategory) obj.ChangedObject);
            num1 = (int) num3 * -2068337526 ^ -44076734;
            continue;
          case 1:
            num1 = (int) num3 * 1862137827 ^ -1462829700;
            continue;
          case 2:
            goto label_16;
          case 3:
            changeType = obj.ChangeType;
            num1 = (int) num3 * -1977177783 ^ 316380115;
            continue;
          case 4:
            num1 = (int) num3 * -1336144679 ^ 1839434732;
            continue;
          case 5:
            goto label_1;
          case 6:
            ((Collection<MessageCategory>) this.ChatCategories).Remove((MessageCategory) obj.ChangedObject);
            num1 = (int) num3 * 1192044602 ^ 51169955;
            continue;
          case 7:
label_17:
            int num4;
            num1 = num4 = ((Collection<MessageCategory>) this.ChatCategories).Contains((MessageCategory) obj.ChangedObject) ? -269491392 : (num4 = -2097045047);
            continue;
          case 8:
            goto label_15;
          case 9:
            num1 = (int) num3 * 2034678957 ^ -954907162;
            continue;
          case 10:
            goto label_5;
          case 11:
label_13:
            int num5;
            num1 = num5 = ((Collection<MessageCategory>) this.ChatCategories).Contains((MessageCategory) obj.ChangedObject) ? -912407574 : (num5 = -1594277417);
            continue;
          case 12:
            goto label_4;
          case 13:
            goto label_21;
          case 14:
            switch (changeType)
            {
              case ChangeType.Updated:
                goto label_3;
              case ChangeType.Added:
                goto label_17;
              case ChangeType.Removed:
                goto label_13;
              case ChangeType.Activated:
                goto label_18;
              case ChangeType.Deactivated:
                goto label_19;
              case ChangeType.Saved:
                goto label_20;
              default:
                num1 = (int) num3 * 2133064380 ^ 122443162;
                continue;
            }
          default:
            goto label_22;
        }
      }
label_4:
      return;
label_21:
      return;
label_22:
      return;
label_16:
      return;
label_15:
      return;
label_5:
      return;
label_19:
      return;
label_20:
      return;
label_3:
      return;
label_18:;
    }

    internal void ToggleDisplayBars([CallerMemberName] string barName = null)
    {
      string[] strArray = new string[8]
      {
        \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3827799608U),
        \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(117115395U),
        \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(413408357U),
        \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2713677883U),
        \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2275572063U),
        \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3482975679U),
        \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3222271446U),
        \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1194175395U)
      };
label_1:
      int num1 = -140813959;
      while (true)
      {
        int num2 = -1531271626;
        uint num3;
        uint stringHash;
        int index;
        string str;
        string s;
        switch ((num3 = (uint) (num1 ^ num2)) % 60U)
        {
          case 0:
            num1 = (int) num3 * -1359663732 ^ 1867026158;
            continue;
          case 1:
          case 49:
            num1 = -1256212663;
            continue;
          case 2:
            int num4;
            num1 = num4 = !SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(s, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2536378914U)) ? -1966966159 : (num4 = -300551724);
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1702915435 ^ 34674938;
            continue;
          case 5:
            this.EngineView_DisplayActivityBar = false;
            num1 = -200880560;
            continue;
          case 6:
            num1 = (int) num3 * 1302704036 ^ 1181865979;
            continue;
          case 7:
            num1 = (int) num3 * -929522738 ^ 1924852129;
            continue;
          case 8:
            goto label_54;
          case 9:
            int num5;
            num1 = num5 = !SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(s, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3298379484U)) ? -1255318785 : (num5 = -29617897);
            continue;
          case 10:
            this.EngineView_DisplaySettingsBar = false;
            num1 = -1971271751;
            continue;
          case 11:
            num1 = -1396516731;
            continue;
          case 12:
            int num6;
            num1 = num6 = SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(s, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(136193836U)) ? -82072414 : (num6 = -1259954803);
            continue;
          case 13:
            int num7 = (int) stringHash == 1528889255 ? 2002789864 : (num7 = 337253047);
            int num8 = (int) num3 * 423591310;
            num1 = num7 ^ num8;
            continue;
          case 14:
            int num9 = stringHash > 1277057143U ? 1280176025 : (num9 = 1621071381);
            int num10 = (int) num3 * -1967865865;
            num1 = num9 ^ num10;
            continue;
          case 15:
            index = 0;
            num1 = (int) num3 * 95860162 ^ -510887463;
            continue;
          case 16:
            this.EngineView_DisplayImageBar = false;
            num1 = -1472685797;
            continue;
          case 17:
            str = strArray[index];
            num1 = -1313438216;
            continue;
          case 18:
            int num11;
            num1 = num11 = SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(s, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2055520660U)) ? -182111407 : (num11 = -1443085053);
            continue;
          case 19:
            num1 = (int) num3 * -1449932890 ^ 959860890;
            continue;
          case 20:
            num1 = (int) num3 * 637430543 ^ 1759257773;
            continue;
          case 21:
            num1 = (int) num3 * 648140449 ^ 1212012522;
            continue;
          case 22:
            this.EngineView_DisplayLayoutBar = false;
            num1 = -270677706;
            continue;
          case 23:
            num1 = (int) num3 * -1735734639 ^ -619965724;
            continue;
          case 24:
            this.EngineView_DisplayMeetingBar = false;
            num1 = -327643763;
            continue;
          case 25:
            num1 = (int) num3 * 581687716 ^ 770708171;
            continue;
          case 26:
            num1 = (int) num3 * 60128657 ^ -1520888987;
            continue;
          case 27:
            this.EngineView_DisplayChatBar = false;
            num1 = -82070937;
            continue;
          case 28:
            int num12;
            num1 = num12 = !SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(s, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1194175395U)) ? -566641036 : (num12 = -1438486208);
            continue;
          case 29:
            this.EngineView_DisplayQuickLinkBar = false;
            num1 = -979104771;
            continue;
          case 30:
            num1 = (int) num3 * 159258665 ^ -1155394195;
            continue;
          case 31:
            num1 = (int) num3 * 397964308 ^ 864862064;
            continue;
          case 32:
            int num13;
            num1 = num13 = (int) stringHash != -207329395 ? -547038898 : (num13 = -1251443650);
            continue;
          case 33:
            num1 = (int) num3 * 1452153145 ^ 271324238;
            continue;
          case 34:
            int num14 = !SettingsViewModel.\u200D⁭‫‏‪‭‍⁯⁫⁪⁯‎‏⁬⁭⁫‮⁭‬⁪⁪‪⁫⁯‭⁫‬‎‎‪‪‫‌‍⁭‎⁯⁪⁬‍‮(str, barName) ? -1866528126 : (num14 = -815105431);
            int num15 = (int) num3 * -1271057680;
            num1 = num14 ^ num15;
            continue;
          case 35:
            int num16;
            num1 = num16 = (int) stringHash == 1277057143 ? -1171806028 : (num16 = -857133943);
            continue;
          case 36:
            s = str;
            num1 = (int) num3 * 1096764798 ^ -153061898;
            continue;
          case 37:
            int num17;
            num1 = num17 = (int) stringHash != -1928805454 ? -1233122855 : (num17 = -1598205536);
            continue;
          case 38:
            num1 = (int) num3 * 391590216 ^ -834161105;
            continue;
          case 39:
            num1 = (int) num3 * -2046691863 ^ -526023760;
            continue;
          case 40:
            num1 = (int) num3 * 935935335 ^ 735993355;
            continue;
          case 41:
            int num18;
            num1 = num18 = index >= strArray.Length ? -1404405754 : (num18 = -436885025);
            continue;
          case 42:
            int num19;
            num1 = num19 = (int) stringHash == 1962657323 ? -276433329 : (num19 = -1431673080);
            continue;
          case 43:
            ++index;
            num1 = (int) num3 * -815724459 ^ -1523153816;
            continue;
          case 44:
            num1 = (int) num3 * 1975825974 ^ -201368181;
            continue;
          case 45:
            int num20;
            num1 = num20 = stringHash <= 1962657323U ? -1599401233 : (num20 = -626018633);
            continue;
          case 46:
            int num21;
            num1 = num21 = SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(s, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(150633176U)) ? -1891170813 : (num21 = -2109792902);
            continue;
          case 47:
            int num22;
            num1 = num22 = (int) stringHash == 1167887702 ? -310961788 : (num22 = -558922614);
            continue;
          case 48:
            int num23;
            num1 = num23 = !SettingsViewModel.\u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮(s, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(789143778U)) ? -707480488 : (num23 = -2120562394);
            continue;
          case 50:
            num1 = (int) num3 * -2082833653 ^ -1331420389;
            continue;
          case 51:
            num1 = (int) num3 * -746208984 ^ 1821408091;
            continue;
          case 52:
            num1 = (int) num3 * 744786689 ^ 327577851;
            continue;
          case 53:
            int num24 = (int) stringHash != 247231825 ? 1726311386 : (num24 = 1777860820);
            int num25 = (int) num3 * 717547574;
            num1 = num24 ^ num25;
            continue;
          case 54:
            num1 = (int) num3 * 1794518218 ^ 291727203;
            continue;
          case 55:
            num1 = (int) num3 * 1203416770 ^ 1910294408;
            continue;
          case 56:
            // ISSUE: reference to a compiler-generated method
            stringHash = \u003CPrivateImplementationDetails\u003E.ComputeStringHash(s);
            num1 = (int) num3 * -1743847511 ^ 355772876;
            continue;
          case 57:
            num1 = (int) num3 * 2106497063 ^ -1048264489;
            continue;
          case 58:
            num1 = (int) num3 * -892510888 ^ -1681357005;
            continue;
          case 59:
            num1 = (int) num3 * 416675395 ^ 1929215346;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return;
label_54:;
    }

    private void Engine_OnSettingChanged(object sender, PropertyChangedEventArgs e)
    {
      bool flag = SettingsViewModel.\u200D⁭‫‏‪‭‍⁯⁫⁪⁯‎‏⁬⁭⁫‮⁭‬⁪⁪‪⁫⁯‭⁫‬‎‎‪‪‫‌‍⁭‎⁯⁪⁬‍‮(SettingsViewModel.\u202B⁭⁯‌​⁭​⁬⁯⁯⁪⁮⁯⁭‎⁮‏⁪⁭‌‫‭‎‎​⁭⁮‪⁯​‍‎⁮‮‎‫‭‏⁭‌‮(e), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1414115986U));
label_1:
      int num1 = -336867091;
      while (true)
      {
        int num2 = -1322663168;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -2132436422 ^ -2139053222;
            continue;
          case 2:
            num1 = (int) num3 * -596503278 ^ -886362031;
            continue;
          case 3:
            int num4 = flag ? -1688775633 : (num4 = -1076599355);
            int num5 = (int) num3 * -907650140;
            num1 = num4 ^ num5;
            continue;
          case 4:
            this.AutoAttendent = this.Engine.Settings.AutoAttendent;
            num1 = (int) num3 * -1091626052 ^ 1222560080;
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

    static bool \u202D‍‏⁫‏‭​‏‭⁬‬‮​⁭⁬‏⁭‭‮⁪‏⁬‍‎‭‎⁯‬​‏⁯‌‎‍‮⁬‮​‎⁭‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static void \u200E‏⁮​​⁭‏⁮⁫‭‬⁫‍‮‮‮‍‭⁪‮‫‬⁫⁪‫⁫⁮‎‌​⁬‭‍​⁫‌‏⁮‭‎‮([In] SettingsBase obj0)
    {
      obj0.Save();
    }

    static bool \u200D⁭‫‏‪‭‍⁯⁫⁪⁯‎‏⁬⁭⁫‮⁭‬⁪⁪‪⁫⁯‭⁫‬‎‎‪‪‫‌‍⁭‎⁯⁪⁬‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static Type \u202B⁪‏‪‍‏‏⁪‫‪‍‫‮⁮⁫‭⁮‍‮‌‍‎⁫‏‪‬‬‍​⁮‏⁭​​‭‮‭⁬‫‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static string[] \u200B‭‎‌‌‌⁬⁭‫⁯‪⁫‏​‫‬‌‫‫‮‪‏‏‪‏⁪‍‭‎‮⁯⁫⁫‏​⁯‪‮‌⁬‮([In] Type obj0)
    {
      return Enum.GetNames(obj0);
    }

    static string \u202B⁭⁯‌​⁭​⁬⁯⁯⁪⁮⁯⁭‎⁮‏⁪⁭‌‫‭‎‎​⁭⁮‪⁯​‍‎⁮‮‎‫‭‏⁭‌‮([In] PropertyChangedEventArgs obj0)
    {
      return obj0.PropertyName;
    }
  }
}
