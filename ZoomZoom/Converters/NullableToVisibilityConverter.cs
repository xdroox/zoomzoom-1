// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.NullableToVisibilityConverter
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
  public class NullableToVisibilityConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = -344421425;
      object obj;
      while (true)
      {
        int num2 = -2032111810;
        uint num3;
        bool flag1;
        bool flag2;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num1 = (int) num3 * 818700845 ^ 1525176561;
            continue;
          case 1:
            flag1 = true;
            num1 = (int) num3 * 1995054978 ^ -1095778200;
            continue;
          case 2:
            num1 = (int) num3 * 1800937296 ^ 975863340;
            continue;
          case 3:
            flag1 = value != null;
            num1 = (int) num3 * -2089671457 ^ -1466794410;
            continue;
          case 4:
            flag1 = NullableToVisibilityConverter.\u200E⁯⁭​‭‏‌⁭⁯‫‬‭⁮‬⁮⁫⁯‭‬⁮⁮⁫⁮‏​‎‬‬‫‎⁭‏‌⁫​⁪‪‎⁭⁫‮((ICollection) value) > 0;
            num1 = (int) num3 * -203759494 ^ 889175561;
            continue;
          case 5:
            num4 = !NullableToVisibilityConverter.\u202A⁪‭⁫⁮‎​‎‏‪⁬⁫‌‭‍⁪‎‏‫⁭​‮‮‫‭‌⁪‮‎⁯⁭⁫‌‪‌‎‮‭⁮⁬‮((string) value) ? 1 : 0;
            goto label_18;
          case 6:
            num1 = (int) num3 * -1835207303 ^ -356084029;
            continue;
          case 7:
            num5 = 2;
            break;
          case 8:
            num1 = (int) num3 * 1934381326 ^ 1645880054;
            continue;
          case 9:
            int num6 = !flag2 ? -1532715214 : (num6 = -452079677);
            int num7 = (int) num3 * 902617398;
            num1 = num6 ^ num7;
            continue;
          case 11:
            flag2 = value is ICollection;
            num1 = -277734726;
            continue;
          case 12:
            num1 = -578395228;
            continue;
          case 13:
            goto label_1;
          case 14:
            if (!flag1)
            {
              num1 = -1738597910;
              continue;
            }
            num5 = 0;
            break;
          case 15:
            num1 = (int) num3 * 1546852792 ^ 2045161009;
            continue;
          case 16:
            flag1 = false;
            if (!(value is string))
            {
              num4 = 0;
              goto label_18;
            }
            else
            {
              num1 = (int) num3 * -169221429 ^ 451164669;
              continue;
            }
          case 17:
            num1 = (int) num3 * 811394638 ^ -1890717224;
            continue;
          case 18:
            num1 = (int) num3 * -1858792017 ^ 928794888;
            continue;
          default:
            goto label_26;
        }
        obj = (object) (Visibility) num5;
        num1 = -1079573892;
        continue;
label_18:
        int num8;
        num1 = num8 = num4 == 0 ? -691301916 : (num8 = -1444340071);
      }
label_26:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw NullableToVisibilityConverter.\u200F⁯‬‭⁬​‫‬⁭‫‭​‪‌⁬‌⁫⁪⁬​‬‎⁬‍⁯‏‍⁯‬‫​​⁮‌‬‫‎‪⁬‮‮();
    }

    static bool \u202A⁪‭⁫⁮‎​‎‏‪⁬⁫‌‭‍⁪‎‏‫⁭​‮‮‫‭‌⁪‮‎⁯⁭⁫‌‪‌‎‮‭⁮⁬‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static int \u200E⁯⁭​‭‏‌⁭⁯‫‬‭⁮‬⁮⁫⁯‭‬⁮⁮⁫⁮‏​‎‬‬‫‎⁭‏‌⁫​⁪‪‎⁭⁫‮([In] ICollection obj0)
    {
      return obj0.Count;
    }

    static NotImplementedException \u200F⁯‬‭⁬​‫‬⁭‫‭​‪‌⁬‌⁫⁪⁬​‬‎⁬‍⁯‏‍⁯‬‫​​⁮‌‬‫‎‪⁬‮‮()
    {
      return new NotImplementedException();
    }
  }
}
