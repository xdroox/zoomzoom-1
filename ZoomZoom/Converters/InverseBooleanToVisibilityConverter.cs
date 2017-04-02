// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.InverseBooleanToVisibilityConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  public class InverseBooleanToVisibilityConverter : IValueConverter
  {
    private BooleanToVisibilityConverter _converter = InverseBooleanToVisibilityConverter.\u202C‬⁯‎‭​‫‍‮‬⁬​⁮‮‏‪‌⁯​‫‪‏⁯⁫⁫‮‌‌‏​‪⁫‎‫‏​​‌⁯‮();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      Visibility? nullable = InverseBooleanToVisibilityConverter.\u202B⁬‪‫⁮⁯​‬‪⁫‫‌⁭​‍‬‮⁮‭‍​‌‪​​​‍‭‬‪‍‏⁯⁫‎‮⁯⁪​‪‮(this._converter, value, targetType, parameter, culture) as Visibility?;
label_1:
      int num1 = 583089230;
      object obj;
      while (true)
      {
        int num2 = 494567099;
        uint num3;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num4 = 2;
            break;
          case 1:
            Visibility visibility = Visibility.Collapsed;
            if (nullable.GetValueOrDefault() != visibility)
            {
              num1 = (int) num3 * -360165238 ^ 2115854616;
              continue;
            }
            num5 = nullable.HasValue ? 1 : 0;
            goto label_10;
          case 3:
            goto label_1;
          case 4:
            num5 = 0;
            goto label_10;
          default:
            goto label_12;
        }
label_7:
        obj = (object) (Visibility) num4;
        num1 = 816360863;
        continue;
label_10:
        if (num5 != 0)
        {
          num4 = 0;
          goto label_7;
        }
        else
          num1 = 772636485;
      }
label_12:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      bool? nullable1 = InverseBooleanToVisibilityConverter.\u206F‍​‪⁬⁫‎⁬⁬⁮⁪‏⁮‭‌‍​⁪‏‪​‫⁫‌‏‫‪⁪‪‪⁭‪‮⁮⁬⁫⁫‭⁫‫‮(this._converter, value, targetType, parameter, culture) as bool?;
label_1:
      int num1 = -560942045;
      object obj;
      while (true)
      {
        int num2 = -685721042;
        uint num3;
        bool? nullable2;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 2019971316 ^ 709443334;
            continue;
          case 1:
            num4 = 0;
            break;
          case 2:
            bool flag = true;
            if (nullable2.GetValueOrDefault() == flag)
            {
              num4 = nullable2.HasValue ? 1 : 0;
              break;
            }
            num1 = (int) num3 * -757588502 ^ -1615645538;
            continue;
          case 3:
            nullable2 = nullable1;
            num1 = (int) num3 * -1913559771 ^ -593641372;
            continue;
          case 5:
            goto label_1;
          case 6:
            num5 = 1;
            goto label_13;
          default:
            goto label_14;
        }
        if (num4 == 0)
        {
          num1 = -409509730;
          continue;
        }
        num5 = 0;
label_13:
        obj = (object) (bool) num5;
        num1 = -1889583710;
      }
label_14:
      return obj;
    }

    static object \u202B⁬‪‫⁮⁯​‬‪⁫‫‌⁭​‍‬‮⁮‭‍​‌‪​​​‍‭‬‪‍‏⁯⁫‎‮⁯⁪​‪‮([In] BooleanToVisibilityConverter obj0, [In] object obj1, [In] Type obj2, [In] object obj3, [In] CultureInfo obj4)
    {
      return obj0.Convert(obj1, obj2, obj3, obj4);
    }

    static object \u206F‍​‪⁬⁫‎⁬⁬⁮⁪‏⁮‭‌‍​⁪‏‪​‫⁫‌‏‫‪⁪‪‪⁭‪‮⁮⁬⁫⁫‭⁫‫‮([In] BooleanToVisibilityConverter obj0, [In] object obj1, [In] Type obj2, [In] object obj3, [In] CultureInfo obj4)
    {
      return obj0.ConvertBack(obj1, obj2, obj3, obj4);
    }

    static BooleanToVisibilityConverter \u202C‬⁯‎‭​‫‍‮‬⁬​⁮‮‏‪‌⁯​‫‪‏⁯⁫⁫‮‌‌‏​‪⁫‎‫‏​​‌⁯‮()
    {
      return new BooleanToVisibilityConverter();
    }
  }
}
