// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.WindowLayoutViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom.ViewModels
{
  public class WindowLayoutViewModel : ViewModelBase
  {
    private WindowLayout _windowLayout = (WindowLayout) null;
    public const string WindowLayoutPropertyName = "WindowLayout";

    public WindowLayout WindowLayout
    {
      get
      {
label_1:
        int num1 = -454548550;
        WindowLayout windowLayout;
        while (true)
        {
          int num2 = -222306537;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              windowLayout = this._windowLayout;
              num1 = (int) num3 * 294560047 ^ -1689392649;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1208254069 ^ 104954462;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowLayout;
      }
      set
      {
label_1:
        int num1 = 350659975;
        while (true)
        {
          int num2 = 1878699605;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              this._windowLayout = value;
              num1 = 353992762;
              continue;
            case 1:
              goto label_3;
            case 2:
              int num4 = !flag ? -1150209622 : (num4 = -550352404);
              int num5 = (int) num3 * 1472097950;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * -451641260 ^ 1575556538;
              continue;
            case 5:
              num1 = (int) num3 * 1620975155 ^ -1436018887;
              continue;
            case 6:
              flag = this._windowLayout == value;
              num1 = (int) num3 * 1933474302 ^ -1795961011;
              continue;
            case 7:
              num1 = (int) num3 * 1339481570 ^ 1846217660;
              continue;
            case 8:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(209921358U));
              num1 = (int) num3 * 1709820663 ^ -2129961175;
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
  }
}
