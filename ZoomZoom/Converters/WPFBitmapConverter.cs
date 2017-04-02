// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.WPFBitmapConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

namespace ZoomZoom.Converters
{
  internal class WPFBitmapConverter
  {
    public WPFBitmapConverter()
    {
label_1:
      int num1 = 1675639815;
      while (true)
      {
        int num2 = 269742296;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -911523893 ^ -569609468;
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
      MemoryStream memoryStream = WPFBitmapConverter.\u202B‫‮⁫‫⁪⁬‮‪‌⁪‬⁬​‍⁮‍‎⁬‍‏‬⁮‍‭‭⁯‏‌‎‬⁭​‍‭‫​⁬‎‎‮();
label_1:
      int num1 = 1833652651;
      object obj;
      while (true)
      {
        int num2 = 1582486697;
        uint num3;
        BitmapImage bitmapImage;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            WPFBitmapConverter.\u206C‬‮‫‮⁬⁮‍⁭⁫⁮‌⁫‪⁯‪⁪‭‍⁪⁫‫⁪‫‍‏‪‫‭​‭​‬⁪‌⁭⁮‫‍‏‮(bitmapImage, (Stream) memoryStream);
            num1 = (int) num3 * 581241250 ^ -1375369941;
            continue;
          case 1:
            bitmapImage = WPFBitmapConverter.\u200B‮‬‍‪⁯‫‍‫‪⁫⁪⁫⁭⁮⁮⁪‫‎⁮‫⁪‍⁬⁭⁯‫‫‭⁫‎‍‫‫⁬‬⁭‍‮⁮‮();
            WPFBitmapConverter.\u200B‍‮⁮‬⁫‭‪‍‍⁬⁯⁫⁭⁭⁭⁫⁮⁮⁮‌‮‪⁪​‌⁬⁬​⁯‮‍‮‪⁭‭‬⁬‪‮(bitmapImage);
            num1 = (int) num3 * -856371349 ^ -1919136592;
            continue;
          case 2:
            WPFBitmapConverter.\u200F‬⁯‭​​‭⁮⁭‪‮‮⁯‮‬‍‏‫‫⁫⁬‎⁯‍⁪⁪⁯⁪⁮‏‍‍‫‌​‮‍⁬‎‬‮((Stream) memoryStream, 0L, SeekOrigin.Begin);
            num1 = (int) num3 * 294509063 ^ -380093449;
            continue;
          case 3:
            num1 = (int) num3 * 1591915429 ^ -262994041;
            continue;
          case 4:
            num1 = (int) num3 * -1485539192 ^ -794225792;
            continue;
          case 5:
            obj = (object) bitmapImage;
            num1 = (int) num3 * -702686638 ^ -23837389;
            continue;
          case 6:
            num1 = (int) num3 * -818763187 ^ -1531881076;
            continue;
          case 7:
            WPFBitmapConverter.\u206D‫⁪⁫⁬‎⁮‬‌‭‌‌⁫‫​⁬‫‪‪⁮⁯‌‮‪‏‎‎‪⁯‌‪‪​‍‎⁯‎‮⁮⁫‮(bitmapImage);
            num1 = (int) num3 * 831944025 ^ -394175119;
            continue;
          case 8:
            goto label_1;
          case 10:
            WPFBitmapConverter.\u200C‬‭‎⁪‮‭‏⁭‮‎‏‭‎‭‍‭⁬⁭‮‫‪‮⁬‎​‫⁮‮⁫‫⁪⁮‍⁫‎⁪‬⁬⁮‮((Image) value, (Stream) memoryStream, WPFBitmapConverter.\u206A‎⁯⁮⁬⁪⁭‫‫⁮⁬‌⁫​‬‫‬‎⁮‫⁭‫‍‏‎‬⁪‪⁪⁫⁯⁮⁭‎‍⁮‮⁮⁫⁮‮());
            num1 = (int) num3 * 1773813254 ^ -1782788290;
            continue;
          case 11:
            num1 = (int) num3 * 1126078628 ^ 896775144;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw WPFBitmapConverter.\u200D‫⁭‏‪‍​‬‬‌‮⁭⁯‪‌⁫‭​​⁭‍⁯​​‌⁯⁯‭‭‌‏⁯‭⁭‏‮‭‭‌‮‮();
    }

    static MemoryStream \u202B‫‮⁫‫⁪⁬‮‪‌⁪‬⁬​‍⁮‍‎⁬‍‏‬⁮‍‭‭⁯‏‌‎‬⁭​‍‭‫​⁬‎‎‮()
    {
      return new MemoryStream();
    }

    static ImageFormat \u206A‎⁯⁮⁬⁪⁭‫‫⁮⁬‌⁫​‬‫‬‎⁮‫⁭‫‍‏‎‬⁪‪⁪⁫⁯⁮⁭‎‍⁮‮⁮⁫⁮‮()
    {
      return ImageFormat.Bmp;
    }

    static void \u200C‬‭‎⁪‮‭‏⁭‮‎‏‭‎‭‍‭⁬⁭‮‫‪‮⁬‎​‫⁮‮⁫‫⁪⁮‍⁫‎⁪‬⁬⁮‮([In] Image obj0, [In] Stream obj1, [In] ImageFormat obj2)
    {
      obj0.Save(obj1, obj2);
    }

    static BitmapImage \u200B‮‬‍‪⁯‫‍‫‪⁫⁪⁫⁭⁮⁮⁪‫‎⁮‫⁪‍⁬⁭⁯‫‫‭⁫‎‍‫‫⁬‬⁭‍‮⁮‮()
    {
      return new BitmapImage();
    }

    static void \u200B‍‮⁮‬⁫‭‪‍‍⁬⁯⁫⁭⁭⁭⁫⁮⁮⁮‌‮‪⁪​‌⁬⁬​⁯‮‍‮‪⁭‭‬⁬‪‮([In] BitmapImage obj0)
    {
      obj0.BeginInit();
    }

    static long \u200F‬⁯‭​​‭⁮⁭‪‮‮⁯‮‬‍‏‫‫⁫⁬‎⁯‍⁪⁪⁯⁪⁮‏‍‍‫‌​‮‍⁬‎‬‮([In] Stream obj0, [In] long obj1, [In] SeekOrigin obj2)
    {
      return obj0.Seek(obj1, obj2);
    }

    static void \u206C‬‮‫‮⁬⁮‍⁭⁫⁮‌⁫‪⁯‪⁪‭‍⁪⁫‫⁪‫‍‏‪‫‭​‭​‬⁪‌⁭⁮‫‍‏‮([In] BitmapImage obj0, [In] Stream obj1)
    {
      obj0.StreamSource = obj1;
    }

    static void \u206D‫⁪⁫⁬‎⁮‬‌‭‌‌⁫‫​⁬‫‪‪⁮⁯‌‮‪‏‎‎‪⁯‌‪‪​‍‎⁯‎‮⁮⁫‮([In] BitmapImage obj0)
    {
      obj0.EndInit();
    }

    static NotImplementedException \u200D‫⁭‏‪‍​‬‬‌‮⁭⁯‪‌⁫‭​​⁭‍⁯​​‌⁯⁯‭‭‌‏⁯‭⁭‏‮‭‭‌‮‮()
    {
      return new NotImplementedException();
    }
  }
}
