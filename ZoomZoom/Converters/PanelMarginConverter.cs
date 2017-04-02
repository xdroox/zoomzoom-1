// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.PanelMarginConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  internal class PanelMarginConverter : IValueConverter
  {
    public PanelMarginConverter()
    {
label_1:
      int num1 = 1139694293;
      while (true)
      {
        int num2 = 1157863382;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -204188764 ^ 505222191;
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
      int num1 = 679146189;
      object obj;
      while (true)
      {
        int num2 = 1875680516;
        uint num3;
        double num4;
        Thickness thickness;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 1:
            int num5 = value is double ? -1311250856 : (num5 = -991701022);
            int num6 = (int) num3 * -1935525855;
            num1 = num5 ^ num6;
            continue;
          case 2:
            thickness = new Thickness(0.0, 0.0, num4 * -1.0, 0.0);
            num1 = (int) num3 * 647594849 ^ 168538984;
            continue;
          case 3:
            goto label_1;
          case 4:
            num4 = (double) value;
            num1 = (int) num3 * -1182291868 ^ 1902461430;
            continue;
          case 5:
            num1 = (int) num3 * -595924142 ^ 1172250906;
            continue;
          case 6:
            obj = (object) thickness;
            num1 = (int) num3 * 2026039109 ^ -1391519454;
            continue;
          case 7:
            goto label_5;
          default:
            goto label_9;
        }
      }
label_5:
      throw PanelMarginConverter.\u202D⁮⁫⁫‍‮⁬⁪‍‬⁮⁯‭⁫‏⁯⁮‬​⁬⁪⁭‫⁪‎‎‏⁬‮‪⁯‎‮⁭​⁮⁫⁪⁯‎‮();
label_9:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw PanelMarginConverter.\u202D⁮⁫⁫‍‮⁬⁪‍‬⁮⁯‭⁫‏⁯⁮‬​⁬⁪⁭‫⁪‎‎‏⁬‮‪⁯‎‮⁭​⁮⁫⁪⁯‎‮();
    }

    static NotImplementedException \u202D⁮⁫⁫‍‮⁬⁪‍‬⁮⁯‭⁫‏⁯⁮‬​⁬⁪⁭‫⁪‎‎‏⁬‮‪⁯‎‮⁭​⁮⁫⁪⁯‎‮()
    {
      return new NotImplementedException();
    }
  }
}
