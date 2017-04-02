// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.SplashViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom.ViewModels
{
  public class SplashViewModel : ViewModelBase
  {
    private string statusMessage = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4147299078U);

    public string StatusMessage
    {
      get
      {
label_1:
        int num1 = -915216516;
        string statusMessage;
        while (true)
        {
          int num2 = -171664606;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              statusMessage = this.statusMessage;
              num1 = (int) num3 * 5563286 ^ -2002535793;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return statusMessage;
      }
      set
      {
        this.statusMessage = value;
label_1:
        int num1 = -1536348064;
        while (true)
        {
          int num2 = -1382243885;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1045564335 ^ 78424784;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(577865343U));
              num1 = (int) num3 * 1488941744 ^ 327132734;
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
  }
}
