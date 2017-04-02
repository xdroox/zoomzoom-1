// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.PanelWidthConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  internal class PanelWidthConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 1283040489;
      object obj;
      while (true)
      {
        int num2 = 1435092566;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            obj = (object) num4;
            num1 = (int) num3 * -1593934266 ^ -965900633;
            continue;
          case 3:
            num4 = (int) value * -1;
            num1 = (int) num3 * 819082090 ^ 952618166;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw PanelWidthConverter.\u200B‎‭‭⁪⁬‎‪‬‬‪⁪⁭‏⁭​⁫‏‮⁮⁮‪‮⁫⁯⁪‌⁫‫⁪‌⁮⁪‪⁪⁭‎‌⁪⁫‮();
    }

    static NotImplementedException \u200B‎‭‭⁪⁬‎‪‬‬‪⁪⁭‏⁭​⁫‏‮⁮⁮‪‮⁫⁯⁪‌⁫‫⁪‌⁮⁪‪⁪⁭‎‌⁪⁫‮()
    {
      return new NotImplementedException();
    }
  }
}
