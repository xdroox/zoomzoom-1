// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.ActivityNameConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  public class ActivityNameConverter : IMultiValueConverter
  {
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 399036688;
      object obj;
      while (true)
      {
        int num2 = 757426137;
        uint num3;
        object[] objArray;
        int index;
        double num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            num4 = 0.0;
            objArray = values;
            num1 = (int) num3 * 2098372986 ^ -365474136;
            continue;
          case 2:
            double num5 = (double) objArray[index];
            num4 += num5;
            ++index;
            num1 = 1118388871;
            continue;
          case 3:
            index = 0;
            num1 = (int) num3 * -1431233419 ^ -1620928272;
            continue;
          case 4:
            obj = (object) num4.ToString();
            num1 = (int) num3 * -1114778146 ^ -1093246228;
            continue;
          case 5:
            num1 = (int) num3 * -1093917814 ^ -1914754748;
            continue;
          case 6:
            int num6;
            num1 = num6 = index < objArray.Length ? 997821571 : (num6 = 286520613);
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return obj;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
      throw ActivityNameConverter.\u202C⁯⁭⁬‎‍⁯⁯⁭‏⁮‮‭‌‎⁪⁭‭‫⁭‫⁭‍‏‏​​‌‌‎‪⁯⁫⁯⁬⁫‬‌⁮⁯‮();
    }

    static NotImplementedException \u202C⁯⁭⁬‎‍⁯⁯⁭‏⁮‮‭‌‎⁪⁭‭‫⁭‫⁭‍‏‏​​‌‌‎‪⁯⁫⁯⁬⁫‬‌⁮⁯‮()
    {
      return new NotImplementedException();
    }
  }
}
