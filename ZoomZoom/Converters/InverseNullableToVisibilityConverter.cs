// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.InverseNullableToVisibilityConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  public class InverseNullableToVisibilityConverter : IValueConverter
  {
    public InverseNullableToVisibilityConverter()
    {
label_1:
      int num1 = -1063110900;
      while (true)
      {
        int num2 = -533463269;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1512348693 ^ -1027629344;
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

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 455513252;
      object obj;
      while (true)
      {
        int num2 = 1042988997;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            int num6 = !flag1 ? -458148589 : (num6 = -1876175508);
            int num7 = (int) num3 * -1992845213;
            num1 = num6 ^ num7;
            continue;
          case 1:
            flag2 = false;
            num1 = (int) num3 * -2120233094 ^ 2124121440;
            continue;
          case 3:
            flag2 = true;
            num1 = (int) num3 * -212403308 ^ 1318177316;
            continue;
          case 4:
            num4 = !InverseNullableToVisibilityConverter.\u206C⁭‮‪⁫‎‪⁪‭⁭‏⁭‪⁭‍‭⁭‫‌‌⁫‏⁭⁭⁯⁬⁫⁬⁬​⁭‌⁭‬‍‬‭⁪‏‪‮((string) value) ? 1 : 0;
            goto label_22;
          case 5:
            num5 = 0;
            break;
          case 6:
            flag2 = value != null;
            num1 = 834661838;
            continue;
          case 7:
            if (flag2)
            {
              num5 = 2;
              break;
            }
            num1 = 1515997184;
            continue;
          case 8:
            goto label_1;
          case 9:
            flag2 = InverseNullableToVisibilityConverter.\u200B‏⁮​⁭‬‌‮⁬‮‏‭‎‌⁪⁭‎⁫⁫⁭⁪⁮⁬⁫‍‏‏⁭‪⁪⁯⁪⁫​⁭‏‏‏​‭‮((ICollection) value) > 0;
            num1 = (int) num3 * 1716776908 ^ 1392064958;
            continue;
          case 10:
            flag1 = value is ICollection;
            num1 = 320219765;
            continue;
          case 11:
            num1 = (int) num3 * 563874759 ^ -193040289;
            continue;
          case 12:
            num1 = (int) num3 * -1794644743 ^ -444370085;
            continue;
          case 13:
            num1 = (int) num3 * 1397732412 ^ -711787234;
            continue;
          case 14:
            int num8 = flag3 ? -1196816914 : (num8 = -73245417);
            int num9 = (int) num3 * 1279015268;
            num1 = num8 ^ num9;
            continue;
          case 15:
            if (value is string)
            {
              num1 = (int) num3 * 2053596058 ^ 149509463;
              continue;
            }
            num4 = 0;
            goto label_22;
          default:
            goto label_23;
        }
        obj = (object) (Visibility) num5;
        num1 = 402456649;
        continue;
label_22:
        flag3 = num4 != 0;
        num1 = 23858683;
      }
label_23:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw InverseNullableToVisibilityConverter.\u206E⁮‌‫⁫​‏‍‏​‍‎⁪‫‏​‮‭‏⁮‍⁫⁫⁬‫⁪‮‏‍‍⁯‌⁭‮‌‮⁮⁮⁪‫‮();
    }

    static bool \u206C⁭‮‪⁫‎‪⁪‭⁭‏⁭‪⁭‍‭⁭‫‌‌⁫‏⁭⁭⁯⁬⁫⁬⁬​⁭‌⁭‬‍‬‭⁪‏‪‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static int \u200B‏⁮​⁭‬‌‮⁬‮‏‭‎‌⁪⁭‎⁫⁫⁭⁪⁮⁬⁫‍‏‏⁭‪⁪⁯⁪⁫​⁭‏‏‏​‭‮([In] ICollection obj0)
    {
      return obj0.Count;
    }

    static NotImplementedException \u206E⁮‌‫⁫​‏‍‏​‍‎⁪‫‏​‮‭‏⁮‍⁫⁫⁬‫⁪‮‏‍‍⁯‌⁭‮‌‮⁮⁮⁪‫‮()
    {
      return new NotImplementedException();
    }
  }
}
