// Decompiled with JetBrains decompiler
// Type: ZoomZoom.BooleanToHiddenVisibility
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Data;

namespace ZoomZoom
{
  public class BooleanToHiddenVisibility : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      Visibility visibility = Visibility.Visible;
      try
      {
        bool flag = bool.Parse(BooleanToHiddenVisibility.\u200E⁪⁫⁮⁭‭‍‫⁬‫‍‪⁫‬‬‭‍‫‭⁪​⁮‌‪‎​‬‪⁫‏⁮⁫⁭‮⁬​⁫‌‮⁭‮(value));
label_2:
        int num1 = -770787874;
        while (true)
        {
          int num2 = -791127068;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * -1818764782 ^ 58852823;
              continue;
            case 2:
              num1 = -909140532;
              continue;
            case 3:
              goto label_2;
            case 4:
              num1 = (int) num3 * -1992117438 ^ 1987611953;
              continue;
            case 5:
              num1 = (int) num3 * 1468116139 ^ -542666578;
              continue;
            case 6:
              visibility = Visibility.Visible;
              num1 = (int) num3 * 1256019832 ^ 118031789;
              continue;
            case 7:
              visibility = Visibility.Collapsed;
              num1 = -1800181787;
              continue;
            case 8:
              int num4 = !flag ? 1742756063 : (num4 = 125150161);
              int num5 = (int) num3 * -1624202747;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_12;
          }
        }
      }
      catch (Exception ex)
      {
      }
label_12:
      object obj = (object) visibility;
label_13:
      int num6 = -863840578;
      while (true)
      {
        int num1 = -791127068;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 0:
            goto label_13;
          case 1:
            num6 = (int) num2 * -2090989807 ^ -219839159;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      object obj = value;
label_1:
      int num1 = -787997880;
      while (true)
      {
        int num2 = -121860040;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -2126421754 ^ -1565176458;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return obj;
    }

    static string \u200E⁪⁫⁮⁭‭‍‫⁬‫‍‪⁫‬‬‭‍‫‭⁪​⁮‌‪‎​‬‪⁫‏⁮⁫⁭‮⁬​⁫‌‮⁭‮([In] object obj0)
    {
      return obj0.ToString();
    }
  }
}
