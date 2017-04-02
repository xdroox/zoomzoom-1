// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.TargetTypeConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  [ValueConversion(typeof (TargetType), typeof (bool))]
  public class TargetTypeConverter : IValueConverter
  {
    public TargetTypeConverter()
    {
label_1:
      int num1 = -1746500099;
      while (true)
      {
        int num2 = -834753430;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -832105598 ^ 2103922805;
            continue;
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
      int num1 = -933338251;
      object obj;
      while (true)
      {
        int num2 = -900000407;
        uint num3;
        bool flag;
        string str1;
        string str2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num4 = parameter == null ? 1 : 0;
            break;
          case 1:
            flag = TargetTypeConverter.\u206A⁮‭‎⁪‎‮‭‪‮⁯‎⁭⁯‏‫⁯‎​⁫‭‫‭‮‮‮‭⁮⁫‬⁬‪‬‪⁫‍‎‍⁫‪‮(str1, str2, StringComparison.InvariantCultureIgnoreCase);
            num1 = (int) num3 * 175720090 ^ 1429482336;
            continue;
          case 3:
            num1 = (int) num3 * 204598617 ^ 1134156764;
            continue;
          case 4:
            str1 = TargetTypeConverter.\u206D⁬⁪‬​‭⁭⁫⁯⁭‬‭⁭⁬‮‌‌⁮⁪⁯‏‬⁪‮​⁬‪‬‮⁬‮‮​‮‌‎‭​‎‎‮(value);
            str2 = TargetTypeConverter.\u206D⁬⁪‬​‭⁭⁫⁯⁭‬‭⁭⁬‮‌‌⁮⁪⁯‏‬⁪‮​⁬‪‬‮⁬‮‮​‮‌‎‭​‎‎‮(parameter);
            num1 = -1997249794;
            continue;
          case 5:
            obj = (object) flag;
            num1 = (int) num3 * 1618000517 ^ 1311273598;
            continue;
          case 6:
            if (value != null)
            {
              num1 = (int) num3 * -1177551097 ^ -1228832020;
              continue;
            }
            num4 = 1;
            break;
          case 7:
            obj = (object) false;
            num1 = (int) num3 * 1570699594 ^ -940087560;
            continue;
          case 8:
            goto label_1;
          default:
            goto label_13;
        }
        int num5;
        num1 = num5 = num4 == 0 ? -1523241240 : (num5 = -1919499907);
      }
label_13:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 1709448373;
      object obj;
      while (true)
      {
        int num2 = 104491721;
        uint num3;
        string str;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 1:
            bool flag = (bool) value;
            str = TargetTypeConverter.\u206D⁬⁪‬​‭⁭⁫⁯⁭‬‭⁭⁬‮‌‌⁮⁪⁯‏‬⁪‮​⁬‪‬‮⁬‮‮​‮‌‎‭​‎‎‮(parameter);
            int num5;
            num1 = num5 = !flag ? 1968666750 : (num5 = 1755314891);
            continue;
          case 2:
            obj = TargetTypeConverter.\u202A‫⁫‭‫‏​‍⁪⁬‫⁭‪‍⁬‫⁯‎‬‎‫⁬‪‌‌‌‎⁬‍⁬‪‪⁭‌‎‪⁬‎⁭‎‮(targetType, str);
            num1 = (int) num3 * 1070250417 ^ 1703306067;
            continue;
          case 3:
            num4 = parameter == null ? 1 : 0;
            break;
          case 4:
            if (value != null)
            {
              num1 = (int) num3 * 904023127 ^ 1881964998;
              continue;
            }
            num4 = 1;
            break;
          case 5:
            goto label_1;
          case 6:
            obj = (object) null;
            num1 = (int) num3 * 2006646708 ^ -1322637783;
            continue;
          case 7:
            obj = (object) null;
            num1 = 546857009;
            continue;
          default:
            goto label_12;
        }
        int num6;
        num1 = num6 = num4 != 0 ? 825753623 : (num6 = 998295480);
      }
label_12:
      return obj;
    }

    static string \u206D⁬⁪‬​‭⁭⁫⁯⁭‬‭⁭⁬‮‌‌⁮⁪⁯‏‬⁪‮​⁬‪‬‮⁬‮‮​‮‌‎‭​‎‎‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static bool \u206A⁮‭‎⁪‎‮‭‪‮⁯‎⁭⁯‏‫⁯‎​⁫‭‫‭‮‮‮‭⁮⁫‬⁬‪‬‪⁫‍‎‍⁫‪‮([In] string obj0, [In] string obj1, [In] StringComparison obj2)
    {
      return obj0.Equals(obj1, obj2);
    }

    static object \u202A‫⁫‭‫‏​‍⁪⁬‫⁭‪‍⁬‫⁯‎‬‎‫⁬‪‌‌‌‎⁬‍⁬‪‪⁭‌‎‪⁬‎⁭‎‮([In] Type obj0, [In] string obj1)
    {
      return Enum.Parse(obj0, obj1);
    }
  }
}
