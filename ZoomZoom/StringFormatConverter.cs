// Decompiled with JetBrains decompiler
// Type: ZoomZoom.StringFormatConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace ZoomZoom
{
  public class StringFormatConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      string str = (string) parameter;
label_1:
      int num1 = -664434948;
      object obj;
      while (true)
      {
        int num2 = -722872981;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = !flag ? 1400708050 : (num4 = 1990124184);
            int num5 = (int) num3 * -1838020282;
            num1 = num4 ^ num5;
            continue;
          case 2:
            obj = (object) StringFormatConverter.\u206F⁪⁭‬‪‫⁮‪⁭⁫⁪‭‬⁯⁬‭‏⁪‪⁬‬‮‌‎⁫⁯⁮‬‮⁬‬⁮‎‌‌‎‌⁮‎‌‮(str, value);
            num1 = (int) num3 * -1753296498 ^ 1086371715;
            continue;
          case 4:
            num1 = -929037919;
            continue;
          case 5:
            obj = (object) StringFormatConverter.\u200F⁫⁭​⁪‏‏⁮‪‌‍​‬‭‮⁬‍⁯⁫‫‮‌‏​‫⁬‍‎‪‏⁮‭‫‭‪‌⁫‬‫‬‮((IFormatProvider) culture, StringFormatConverter.\u206C‬​⁯‌⁪‌‌‫⁫⁭‏‪​⁬⁫‪‌‫‏⁮⁭⁭⁯‬‬‎‏⁪‮‬⁫‬‮‫‎‪‪‎⁫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1124057297U), str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1676966739U)), new object[1]
            {
              value
            });
            num1 = (int) num3 * -1591711547 ^ -446102870;
            continue;
          case 6:
            num1 = (int) num3 * -599652395 ^ -1676839710;
            continue;
          case 7:
            num1 = (int) num3 * 1045098590 ^ -1410477258;
            continue;
          case 8:
            flag = StringFormatConverter.\u206F‌‮‍⁬⁪‮⁯‬​⁫‏‏‌⁮​‏‬⁭‪⁯‍⁯⁭‍‌‬⁫‏​‭⁯‪⁫​⁪‮⁬⁪⁬‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(806602811U));
            num1 = (int) num3 * -252000669 ^ 421899241;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw StringFormatConverter.\u206A⁫‎‪‎⁪‫⁪‍​⁬⁫‍​‌⁪‎‎⁫‬‍⁯⁯‎‍‌⁪⁭‫⁮‌‬⁯⁯‮‫‪​‍‭‮();
    }

    static bool \u206F‌‮‍⁬⁪‮⁯‬​⁫‏‏‌⁮​‏‬⁭‪⁯‍⁯⁭‍‌‬⁫‏​‭⁯‪⁫​⁪‮⁬⁪⁬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static string \u206F⁪⁭‬‪‫⁮‪⁭⁫⁪‭‬⁯⁬‭‏⁪‪⁬‬‮‌‎⁫⁯⁮‬‮⁬‬⁮‎‌‌‎‌⁮‎‌‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u206C‬​⁯‌⁪‌‌‫⁫⁭‏‪​⁬⁫‪‌‫‏⁮⁭⁭⁯‬‬‎‏⁪‮‬⁫‬‮‫‎‪‪‎⁫‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0 + obj1 + obj2;
    }

    static string \u200F⁫⁭​⁪‏‏⁮‪‌‍​‬‭‮⁬‍⁯⁫‫‮‌‏​‫⁬‍‎‪‏⁮‭‫‭‪‌⁫‬‫‬‮([In] IFormatProvider obj0, [In] string obj1, [In] object[] obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static NotImplementedException \u206A⁫‎‪‎⁪‫⁪‍​⁬⁫‍​‌⁪‎‎⁫‬‍⁯⁯‎‍‌⁪⁭‫⁮‌‬⁯⁯‮‫‪​‍‭‮()
    {
      return new NotImplementedException();
    }
  }
}
