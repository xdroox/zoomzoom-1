// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ImageManagementViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.ViewModels
{
  public class ImageManagementViewModel : ViewModelBase
  {
    private ImageHistoryViewModel imageHistoryViewModel;

    public ImageHistoryViewModel ImageHistoryViewModel
    {
      get
      {
label_1:
        int num1 = 1948612475;
        ImageHistoryViewModel historyViewModel;
        while (true)
        {
          int num2 = 726790216;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -391154418 ^ -1450222528;
              continue;
            case 3:
              historyViewModel = this.imageHistoryViewModel;
              num1 = (int) num3 * -451805287 ^ -699906270;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return historyViewModel;
      }
      set
      {
        this.imageHistoryViewModel = value;
      }
    }

    public ImageManagementViewModel()
    {
      this.Engine = Engine.Instance;
      this.ImageHistoryViewModel = new ImageHistoryViewModel(ApplicationService.Instance.EventAggregator);
      this.LoadCommands();
    }

    public void LoadCommands()
    {
label_1:
      int num1 = 15136006;
      while (true)
      {
        int num2 = 1980559376;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -390302020 ^ -2014820315;
            continue;
          case 1:
            num1 = (int) num3 * 177120504 ^ -595505111;
            continue;
          case 2:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3021671017U), (Action<object>) (x => this.ExecuteOpenHistoryView()), (Predicate<object>) (x => this.CanExecuteOpenHistoryView()));
            num1 = (int) num3 * 1850618279 ^ 278435365;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_3;
          case 5:
            flag = this.Commands.Count == 0;
            num1 = (int) num3 * -577977314 ^ -35299403;
            continue;
          case 6:
            int num4 = flag ? 443017547 : (num4 = 845603678);
            int num5 = (int) num3 * -489034537;
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

    private bool CanExecuteOpenHistoryView()
    {
label_1:
      int num1 = -1991532446;
      bool flag;
      while (true)
      {
        int num2 = -1560989356;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -338661832 ^ 80879255;
            continue;
          case 2:
            flag = true;
            num1 = (int) num3 * 1950139246 ^ -1401180735;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteOpenHistoryView()
    {
      this.ImageHistoryViewModel.DisplayView();
    }
  }
}
