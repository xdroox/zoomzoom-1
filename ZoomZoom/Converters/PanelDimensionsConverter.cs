// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.PanelDimensionsConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  internal class PanelDimensionsConverter : IMultiValueConverter
  {
    public PanelDimensionsConverter()
    {
label_1:
      int num1 = -1437060772;
      while (true)
      {
        int num2 = -752972355;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 11794450 ^ -1869967624;
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

    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
      double? nullable1 = new double?(0.0);
label_1:
      int num1 = -665898770;
      object obj1;
      while (true)
      {
        int num2 = -549585863;
        uint num3;
        object[] objArray;
        int index;
        object obj2;
        double? nullable2;
        double? nullable3;
        double num4;
        bool flag;
        int result;
        double? nullable4;
        double? nullable5;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = int.TryParse(PanelDimensionsConverter.\u200D​‎‬‫‪‌‪⁯⁭‏‭⁫‎‍⁯‫‍⁬‪‮⁬‏⁪‮⁭⁬‭⁪‫‬⁮‭⁯⁭⁭‬‎‍‏‮(obj2), out result);
            num1 = (int) num3 * -602435154 ^ -881710436;
            continue;
          case 3:
            objArray = values;
            num1 = (int) num3 * 646045257 ^ -1280745314;
            continue;
          case 4:
            obj2 = objArray[index];
            num1 = -1400971279;
            continue;
          case 5:
            nullable3 = new double?();
            nullable4 = nullable3;
            goto label_23;
          case 6:
            if (!nullable2.HasValue)
            {
              num1 = (int) num3 * 85200334 ^ 1384727682;
              continue;
            }
            nullable4 = new double?(nullable2.GetValueOrDefault() + num4);
            goto label_23;
          case 7:
            index = 0;
            num1 = (int) num3 * 2123442182 ^ 401645465;
            continue;
          case 8:
            num4 = (double) result;
            num1 = (int) num3 * -2087068358 ^ 949293872;
            continue;
          case 9:
            nullable3 = new double?();
            num1 = (int) num3 * -1342092026 ^ 1227999740;
            continue;
          case 10:
            num1 = (int) num3 * -2500678 ^ 479082423;
            continue;
          case 11:
            nullable2 = nullable1;
            num4 = -1.0;
            if (nullable2.HasValue)
            {
              nullable5 = new double?(nullable2.GetValueOrDefault() * num4);
              break;
            }
            num1 = (int) num3 * -2053500765 ^ 1974988624;
            continue;
          case 12:
            nullable5 = nullable3;
            break;
          case 13:
            int num5;
            num1 = num5 = index >= objArray.Length ? -1182318050 : (num5 = -1131427807);
            continue;
          case 14:
            num1 = (int) num3 * 279217985 ^ -2049629667;
            continue;
          case 15:
            int num6 = !flag ? 1762295543 : (num6 = 607628183);
            int num7 = (int) num3 * 1863241155;
            num1 = num6 ^ num7;
            continue;
          case 16:
            num1 = -1759609702;
            continue;
          case 17:
            nullable2 = nullable1;
            num1 = (int) num3 * -1064100895 ^ -1396343374;
            continue;
          case 18:
            ++index;
            num1 = (int) num3 * 1667923270 ^ -725775055;
            continue;
          default:
            goto label_26;
        }
        nullable1 = nullable5;
        obj1 = (object) nullable1;
        num1 = -1272207115;
        continue;
label_23:
        nullable1 = nullable4;
        num1 = -1227489208;
      }
label_26:
      return obj1;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
      throw PanelDimensionsConverter.\u200D‪‍‭⁫‮‌‍‫‏‏⁯‏⁯‌⁭‍‎‭⁪​⁬‮‬⁮⁯⁭⁮⁭⁭‫‏‬‌‬⁪‏⁭‫⁪‮();
    }

    static string \u200D​‎‬‫‪‌‪⁯⁭‏‭⁫‎‍⁯‫‍⁬‪‮⁬‏⁪‮⁭⁬‭⁪‫‬⁮‭⁯⁭⁭‬‎‍‏‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static NotImplementedException \u200D‪‍‭⁫‮‌‍‫‏‏⁯‏⁯‌⁭‍‎‭⁪​⁬‮‬⁮⁯⁭⁮⁭⁭‫‏‬‌‬⁪‏⁭‫⁪‮()
    {
      return new NotImplementedException();
    }
  }
}
