// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.PhotoSizeConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace ZoomZoom.Converters
{
  public class PhotoSizeConverter : IMultiValueConverter
  {
    public PhotoSizeConverter()
    {
label_1:
      int num1 = 1113405038;
      while (true)
      {
        int num2 = 2041393385;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1234069917 ^ -1323666269;
            continue;
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
label_1:
      int num1 = -1900222919;
      object obj;
      while (true)
      {
        int num2 = -623957922;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 30785056 ^ 1169504;
            continue;
          case 2:
            num1 = (int) num3 * -1163271970 ^ 837040310;
            continue;
          case 3:
            int num5 = flag ? 1046597818 : (num5 = 737170668);
            int num6 = (int) num3 * 470887763;
            num1 = num5 ^ num6;
            continue;
          case 4:
            num4 = values[1] == null ? 1 : 0;
            break;
          case 6:
            obj = (object) string.Empty;
            num1 = (int) num3 * 1407554225 ^ 2083236383;
            continue;
          case 7:
            if (values[0] == null)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * 333564109 ^ -176620796;
            continue;
          case 8:
            obj = (object) PhotoSizeConverter.\u202D‍‭⁪‭‫⁪‌‎‏‍⁬⁫‎‭‮⁬‌⁪⁯‌‪‌‪‍‏‮‌‬‮​‌​⁭​‏‭‌​‌‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(930652268U), values[0], values[1]);
            num1 = -352270144;
            continue;
          default:
            goto label_13;
        }
        flag = num4 != 0;
        num1 = -1061045412;
      }
label_13:
      return obj;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = -524819919;
      object[] objArray1;
      while (true)
      {
        int num2 = -1731485640;
        uint num3;
        object[] objArray2;
        string[] strArray1;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            objArray2 = new object[2]
            {
              (object) uint.Parse(strArray1[0]),
              null
            };
            num1 = (int) num3 * 1900269404 ^ 738237357;
            continue;
          case 1:
            flag = PhotoSizeConverter.\u200D⁮‫⁪⁫‌‍‪‫‭⁮‏‏⁮⁫⁫⁫‍‏‬⁬​‏‪‏‍‫‮‪⁮⁪‭‬‪⁪⁯⁮⁭⁯‮‮((string) value, string.Empty);
            num1 = (int) num3 * -1166977456 ^ -1608925502;
            continue;
          case 2:
            int num4 = !flag ? -91909511 : (num4 = -1994986902);
            int num5 = (int) num3 * 500941927;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * 1992361784 ^ 367713084;
            continue;
          case 4:
            num1 = (int) num3 * -1989135962 ^ -1346535666;
            continue;
          case 5:
            objArray2[1] = (object) uint.Parse(strArray1[1]);
            objArray1 = objArray2;
            num1 = (int) num3 * 330514612 ^ 1293069689;
            continue;
          case 6:
            string[] strArray2 = new string[2];
            strArray1 = PhotoSizeConverter.\u200E‏​‌‮⁫⁯⁬⁬‮⁬‭‮⁮‮‌‪​⁫‎​‫‫⁪⁮⁫⁮‬‭‎‎⁫⁬⁬⁯‭⁫⁮⁭⁭‮((string) value, new char[1]
            {
              'x'
            });
            num1 = (int) num3 * 839815205 ^ -149938874;
            continue;
          case 7:
            goto label_1;
          case 9:
            num1 = (int) num3 * 1888591862 ^ 1623309594;
            continue;
          case 10:
            objArray1 = new object[2];
            num1 = (int) num3 * 1030326037 ^ 868771349;
            continue;
          case 11:
            num1 = -1908820470;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return objArray1;
    }

    static string \u202D‍‭⁪‭‫⁪‌‎‏‍⁬⁫‎‭‮⁬‌⁪⁯‌‪‌‪‍‏‮‌‬‮​‌​⁭​‏‭‌​‌‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static bool \u200D⁮‫⁪⁫‌‍‪‫‭⁮‏‏⁮⁫⁫⁫‍‏‬⁬​‏‪‏‍‫‮‪⁮⁪‭‬‪⁪⁯⁮⁭⁯‮‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static string[] \u200E‏​‌‮⁫⁯⁬⁬‮⁬‭‮⁮‮‌‪​⁫‎​‫‫⁪⁮⁫⁮‬‭‎‎⁫⁬⁬⁯‭⁫⁮⁭⁭‮([In] string obj0, [In] char[] obj1)
    {
      return obj0.Split(obj1);
    }
  }
}
