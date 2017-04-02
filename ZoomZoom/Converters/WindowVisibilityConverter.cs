// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.WindowVisibilityConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  public class WindowVisibilityConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      string str = WindowVisibilityConverter.\u206E‬‪‎‮‫⁭​⁯⁮⁯⁬‮⁮⁯⁬‌‮‌‏‏‍‎⁫‏‪‬⁫‍⁭‏⁪⁪‮‪⁬‎⁮‮‭‮(WindowVisibilityConverter.\u202C‭⁮‭‪⁬​‫‍‍⁫⁭‎‪‍‮‪‬‎‬‏⁯‪⁫‫‌‎⁬⁪⁯‭‫⁭⁪‌‎‮‏⁭‬‮(value));
      if (WindowVisibilityConverter.\u200D‭⁭​⁪‌⁬⁮‌⁬‬⁫​⁭⁯⁬‫​‍⁮‭‬⁯‌‮⁮‌⁮⁮‌‎‍⁮‭‭‮‍‎⁪⁯‮(str, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4034405915U)))
        goto label_7;
label_1:
      int num1 = 1770836958;
label_2:
      object obj;
      while (true)
      {
        int num2 = 1493992320;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            goto label_7;
          case 1:
            obj = (object) WindowVisibility.Move;
            num1 = 1692280697;
            continue;
          case 2:
            obj = (object) WindowVisibility.Ignore;
            num1 = 1473968011;
            continue;
          case 3:
            int num4 = WindowVisibilityConverter.\u200D‭⁭​⁪‌⁬⁮‌⁬‬⁫​⁭⁯⁬‫​‍⁮‭‬⁯‌‮⁮‌⁮⁮‌‎‍⁮‭‭‮‍‎⁪⁯‮(str, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4097979019U)) ? -1611827451 : (num4 = -63006333);
            int num5 = (int) num3 * 1512109010;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * -758032221 ^ -94250281;
            continue;
          case 5:
            obj = (object) WindowVisibility.Hide;
            num1 = 1579834247;
            continue;
          case 6:
            num1 = (int) num3 * -697141238 ^ 1798013542;
            continue;
          case 7:
            num1 = (int) num3 * 2046020006 ^ 2036167156;
            continue;
          case 9:
            obj = (object) WindowVisibility.Close;
            num1 = 2079748316;
            continue;
          case 10:
            int num6 = WindowVisibilityConverter.\u200D‭⁭​⁪‌⁬⁮‌⁬‬⁫​⁭⁯⁬‫​‍⁮‭‬⁯‌‮⁮‌⁮⁮‌‎‍⁮‭‭‮‍‎⁪⁯‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2125986059U)) ? -2108361620 : (num6 = -1775221897);
            int num7 = (int) num3 * 229590339;
            num1 = num6 ^ num7;
            continue;
          case 11:
            num1 = (int) num3 * -1378861088 ^ -1082920843;
            continue;
          case 12:
            int num8 = !WindowVisibilityConverter.\u200D‭⁭​⁪‌⁬⁮‌⁬‬⁫​⁭⁯⁬‫​‍⁮‭‬⁯‌‮⁮‌⁮⁮‌‎‍⁮‭‭‮‍‎⁪⁯‮(str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3818868321U)) ? -610887147 : (num8 = -1955864651);
            int num9 = (int) num3 * 1985385912;
            num1 = num8 ^ num9;
            continue;
          case 13:
            num1 = (int) num3 * 2113587504 ^ 1975547916;
            continue;
          case 14:
            int num10 = !WindowVisibilityConverter.\u200D‭⁭​⁪‌⁬⁮‌⁬‬⁫​⁭⁯⁬‫​‍⁮‭‬⁯‌‮⁮‌⁮⁮‌‎‍⁮‭‭‮‍‎⁪⁯‮(str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3606567720U)) ? 1384532627 : (num10 = 1656606221);
            int num11 = (int) num3 * 1253627160;
            num1 = num10 ^ num11;
            continue;
          case 15:
            num1 = (int) num3 * 629598189 ^ -646110349;
            continue;
          case 16:
            goto label_1;
          default:
            goto label_18;
        }
      }
label_18:
      return obj;
label_7:
      obj = (object) WindowVisibility.Show;
      num1 = 633709497;
      goto label_2;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 1186461840;
      object obj;
      while (true)
      {
        int num2 = 1346721710;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 23U)
        {
          case 0:
            obj = (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4097979019U);
            num1 = (int) num3 * -1186607903 ^ -1143665753;
            continue;
          case 1:
            flag2 = value is WindowVisibility;
            num1 = (int) num3 * -689861874 ^ -633448579;
            continue;
          case 2:
            int num4 = (WindowVisibility) value == WindowVisibility.Close ? 856969560 : (num4 = 973008049);
            int num5 = (int) num3 * 1703698752;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * 1667917787 ^ 131699284;
            continue;
          case 4:
            obj = (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(240289188U);
            num1 = 11651980;
            continue;
          case 5:
            num1 = (int) num3 * 1390518786 ^ -964728274;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -468120751 ^ -1155319957;
            continue;
          case 8:
            int num6;
            num1 = num6 = (WindowVisibility) value != WindowVisibility.Ignore ? 424389931 : (num6 = 1924245808);
            continue;
          case 9:
            obj = (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(240289188U);
            num1 = (int) num3 * -1849125631 ^ 92998442;
            continue;
          case 10:
            obj = (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1836013941U);
            num1 = (int) num3 * 1504693001 ^ -153443572;
            continue;
          case 11:
            obj = (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(155577769U);
            num1 = (int) num3 * 839056023 ^ 2118198361;
            continue;
          case 12:
            flag1 = (WindowVisibility) value == WindowVisibility.Hide;
            num1 = 624416778;
            continue;
          case 13:
            int num7;
            num1 = num7 = (WindowVisibility) value != WindowVisibility.Move ? 1671324336 : (num7 = 830814576);
            continue;
          case 15:
            num1 = (int) num3 * 1887360915 ^ 628024594;
            continue;
          case 16:
            int num8 = flag2 ? -601537900 : (num8 = -112743988);
            int num9 = (int) num3 * -1372272123;
            num1 = num8 ^ num9;
            continue;
          case 17:
            int num10 = flag1 ? -453601039 : (num10 = -1116954279);
            int num11 = (int) num3 * -129394307;
            num1 = num10 ^ num11;
            continue;
          case 18:
            int num12;
            num1 = num12 = (WindowVisibility) value == WindowVisibility.Show ? 1496996055 : (num12 = 1229873097);
            continue;
          case 19:
            num1 = (int) num3 * -1320170804 ^ 1321656894;
            continue;
          case 20:
            obj = (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2514436919U);
            num1 = 1234630943;
            continue;
          case 21:
            obj = (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3779191839U);
            num1 = (int) num3 * -1456793884 ^ 147087104;
            continue;
          case 22:
            num1 = (int) num3 * 170684438 ^ 1705182726;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      return obj;
    }

    static string \u202C‭⁮‭‪⁬​‫‍‍⁫⁭‎‪‍‮‪‬‎‬‏⁯‪⁫‫‌‎⁬⁪⁯‭‫⁭⁪‌‎‮‏⁭‬‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u206E‬‪‎‮‫⁭​⁯⁮⁯⁬‮⁮⁯⁬‌‮‌‏‏‍‎⁫‏‪‬⁫‍⁭‏⁪⁪‮‪⁬‎⁮‮‭‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static bool \u200D‭⁭​⁪‌⁬⁮‌⁬‬⁫​⁭⁯⁬‫​‍⁮‭‬⁯‌‮⁮‌⁮⁮‌‎‍⁮‭‭‮‍‎⁪⁯‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }
  }
}
