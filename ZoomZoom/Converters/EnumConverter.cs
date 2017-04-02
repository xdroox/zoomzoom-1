// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.EnumConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  internal class EnumConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 556950205;
      object obj;
      while (true)
      {
        int num2 = 632350537;
        uint num3;
        Enum @enum;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 2:
            obj = (object) @enum;
            num1 = 229994526;
            continue;
          case 3:
            int num4 = flag ? -204409231 : (num4 = -514850555);
            int num5 = (int) num3 * 68971786;
            num1 = num4 ^ num5;
            continue;
          case 4:
            @enum = (Enum) null;
            flag = parameter is Type;
            num1 = (int) num3 * 1516128296 ^ 2011155474;
            continue;
          case 5:
            num1 = (int) num3 * -1538295682 ^ 1020752445;
            continue;
          case 6:
            @enum = (Enum) EnumConverter.\u200F⁮⁭⁫‭⁬⁮⁬‫‬⁯‎⁮‏⁫‎‮⁪⁮‮⁫⁫‫​​‬⁯​‮‪⁬‍⁬⁯⁭⁯⁭⁬⁭‎‮((Type) parameter, EnumConverter.\u206B‌⁭​‫‭‪‏‎⁯‪‬⁯​⁭‬⁬⁪‪⁮⁬‫⁮‬‬⁮‬​‬⁬‫⁪⁪⁮​‌⁬​⁬‎‮(value));
            num1 = (int) num3 * -2003678959 ^ 21304538;
            continue;
          case 7:
            num1 = (int) num3 * -443763607 ^ -732252177;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 963112009;
      object obj;
      while (true)
      {
        int num2 = 710049339;
        uint num3;
        int num4;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * 109250741 ^ 2136883893;
            continue;
          case 1:
            int num5 = flag ? -1557097215 : (num5 = -347223726);
            int num6 = (int) num3 * 1464714878;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num4 = 0;
            flag = parameter is Type;
            num1 = (int) num3 * -434051976 ^ 278266626;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -740519137 ^ -1051626014;
            continue;
          case 5:
            num4 = (int) EnumConverter.\u200F⁮⁭⁫‭⁬⁮⁬‫‬⁯‎⁮‏⁫‎‮⁪⁮‮⁫⁫‫​​‬⁯​‮‪⁬‍⁬⁯⁭⁯⁭⁬⁭‎‮((Type) parameter, EnumConverter.\u206B‌⁭​‫‭‪‏‎⁯‪‬⁯​⁭‬⁬⁪‪⁮⁬‫⁮‬‬⁮‬​‬⁬‫⁪⁪⁮​‌⁬​⁬‎‮(value));
            num1 = (int) num3 * -301535405 ^ -1423718317;
            continue;
          case 7:
            obj = (object) num4;
            num1 = 2108234531;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return obj;
    }

    static string \u206B‌⁭​‫‭‪‏‎⁯‪‬⁯​⁭‬⁬⁪‪⁮⁬‫⁮‬‬⁮‬​‬⁬‫⁪⁪⁮​‌⁬​⁬‎‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static object \u200F⁮⁭⁫‭⁬⁮⁬‫‬⁯‎⁮‏⁫‎‮⁪⁮‮⁫⁫‫​​‬⁯​‮‪⁬‍⁬⁯⁭⁯⁭⁬⁭‎‮([In] Type obj0, [In] string obj1)
    {
      return Enum.Parse(obj0, obj1);
    }
  }
}
