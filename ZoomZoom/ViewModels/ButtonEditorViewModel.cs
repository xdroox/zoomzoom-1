// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ButtonEditorViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using GalaSoft.MvvmLight;
using Microsoft.Practices.Prism.Events;
using System;
using System.Runtime.InteropServices;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  internal class ButtonEditorViewModel : ViewModelBase
  {
    private ZoomButton button;

    public ZoomButton Button
    {
      get
      {
        ZoomButton button = this.button;
label_1:
        int num1 = -1834484287;
        while (true)
        {
          int num2 = -1838362821;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 199196819 ^ -813796437;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return button;
      }
      set
      {
label_1:
        int num1 = 998248215;
        while (true)
        {
          int num2 = 671197564;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 171324861 ^ 260344577;
              continue;
            case 1:
              flag = this.button == value;
              num1 = (int) num3 * 1367394024 ^ 3854424;
              continue;
            case 2:
              int num4 = flag ? 302432440 : (num4 = 1361760339);
              int num5 = (int) num3 * 1688565519;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.button = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3380727959U));
              num1 = 1509083297;
              continue;
            case 4:
              goto label_1;
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

    public ButtonEditorViewModel(ZoomButton button)
    {
label_1:
      int num1 = 425168424;
      while (true)
      {
        int num2 = 2091582366;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            this.Button = button;
            num1 = (int) num3 * 1824552629 ^ -1860462646;
            continue;
          case 1:
            this.LoadCommands();
            num1 = (int) num3 * -1237590838 ^ -1126111733;
            continue;
          case 2:
            num1 = (int) num3 * 1152718020 ^ -546465109;
            continue;
          case 3:
            num1 = (int) num3 * -728689764 ^ -2081081715;
            continue;
          case 4:
            int num4 = ButtonEditorViewModel.\u206D​⁯⁯‮‎‎‬⁫‭​⁫‭‏‬⁫‪​‎‬⁫⁪‌‮⁬‬⁫⁮⁫‭‮‫⁮⁬‬⁯⁪⁫⁭‌‮((ViewModelBase) this) ? -439823412 : (num4 = -1018148577);
            int num5 = (int) num3 * -936751449;
            num1 = num4 ^ num5;
            continue;
          case 5:
            num1 = 1788459914;
            continue;
          case 6:
            num1 = (int) num3 * 1361709931 ^ 1538835683;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num3 * 296494031 ^ -2045363909;
            continue;
          case 9:
            this.Button = new ZoomButton();
            num1 = (int) num3 * 746150442 ^ -175910270;
            continue;
          case 10:
            num1 = (int) num3 * 1566535313 ^ -717488524;
            continue;
          case 11:
            goto label_3;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    public void Initialize(IntPtr handle, ZoomButton button)
    {
label_1:
      int num1 = 975042409;
      while (true)
      {
        int num2 = 1062673104;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.ViewHandle = handle;
            num1 = (int) num3 * 759087212 ^ -317149946;
            continue;
          case 2:
            this.Button = button;
            num1 = (int) num3 * 1916638805 ^ 1608683830;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void LoadCommands()
    {
label_1:
      int num1 = -1699633511;
      while (true)
      {
        int num2 = -1236369048;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4291942519U), (Action<object>) (x => this.SaveButton()), (Predicate<object>) (x => this.CanSaveButton()));
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1586138216U), (Action<object>) (x => this.CloseWindow()));
            num1 = (int) num3 * 618269135 ^ -733661491;
            continue;
          case 2:
            num1 = (int) num3 * -1645837269 ^ -2143864871;
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

    private void CloseWindow()
    {
label_1:
      int num1 = -1062491588;
      while (true)
      {
        int num2 = -856315147;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1545827559 ^ -646605806;
            continue;
          case 1:
            ((CompositePresentationEvent<ViewEventPayload>) this._eventAggregator.GetEvent<WindowEvent>()).Publish(new ViewEventPayload(this.ViewHandle, ViewEventType.Close));
            num1 = (int) num3 * -289552190 ^ -2111630577;
            continue;
          case 2:
            goto label_1;
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

    private bool CanSaveButton()
    {
label_1:
      int num1 = -1482649055;
      bool flag;
      while (true)
      {
        int num2 = -1221423820;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * -2119670421 ^ -1300264972;
            continue;
          case 2:
            num4 = this.Button.IsDirty ? 1 : 0;
            break;
          case 3:
            goto label_1;
          case 4:
            if (this.Button != null)
            {
              num1 = (int) num3 * -607006894 ^ 1379135741;
              continue;
            }
            num4 = 0;
            break;
          default:
            goto label_9;
        }
        flag = num4 != 0;
        num1 = -2061764669;
      }
label_9:
      return flag;
    }

    private void SaveButton()
    {
      if (this.Button == null)
        goto label_9;
label_1:
      int num1 = -144504314;
label_2:
      bool flag;
      while (true)
      {
        int num2 = -1989826631;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            int num4 = !flag ? 577137265 : (num4 = 200733164);
            int num5 = (int) num3 * 362610606;
            num1 = num4 ^ num5;
            continue;
          case 1:
            this.Button.Save();
            num1 = (int) num3 * -474136676 ^ -468735740;
            continue;
          case 2:
            num1 = (int) num3 * -1564495014 ^ 1131595759;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1374184520 ^ -349744141;
            continue;
          case 5:
            goto label_3;
          case 6:
            goto label_8;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:
      return;
label_8:
      int num6 = this.Button.IsDirty ? 1 : 0;
      goto label_10;
label_9:
      num6 = 0;
label_10:
      flag = num6 != 0;
      num1 = -268769118;
      goto label_2;
    }

    static bool \u206D​⁯⁯‮‎‎‬⁫‭​⁫‭‏‬⁫‪​‎‬⁫⁪‌‮⁬‬⁫⁮⁫‭‮‫⁮⁬‬⁯⁪⁫⁭‌‮([In] ViewModelBase obj0)
    {
      return obj0.get_IsInDesignMode();
    }
  }
}
