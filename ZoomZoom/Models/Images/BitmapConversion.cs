// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.BitmapConversion
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ZoomZoom.Models.Images
{
  public static class BitmapConversion
  {
    public static BitmapSource ByteArrayToBitmapSource(byte[] bytes)
    {
label_1:
      int num1 = -674479152;
      BitmapSource bitmapSource;
      while (true)
      {
        int num2 = -1362042821;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            bitmapSource = (BitmapSource) BitmapConversion.\u200B‮⁭⁬‎‬​⁬​⁫⁮‪‎‍​‏‫‪‭⁯‎⁭⁮⁯​⁯‏⁮⁪‍⁫‪‫‪⁪‪⁬⁭⁫‬‮((Stream) BitmapConversion.\u200F⁬‮⁪‮⁯⁬‪‮⁭⁪⁬‬‭⁮‫‍⁫⁮‮⁪⁪‏‎⁫⁪‮⁬‪⁯​⁪‪⁮​⁮‎‏⁬‎‮(bytes));
            num1 = (int) num3 * 655084188 ^ -703595966;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return bitmapSource;
    }

    public static BitmapImage ToWpfBitmapImage(this Bitmap bitmapsource)
    {
      BitmapImage bitmapImage = BitmapConversion.\u206C⁫‍‍‫⁬⁯‮‎‮‪‌⁪‌‫‮​‍‌⁪⁪‎‏⁭‮⁬⁯​⁯⁪‪⁫‭​‮‭⁪‪‫⁬‮();
      MemoryStream memoryStream = BitmapConversion.\u200B‌‮⁪⁯‭⁬‫⁮⁪⁮⁮‭‎​⁭⁫‎‬‪‎⁭⁭⁪⁬⁮‏⁮‫‎⁯‪‫‎‌⁮‎‭‮⁫‮();
      try
      {
        BitmapConversion.\u202D‎‍‫⁫‬‌‎‬⁯‍⁬⁮‪⁭‎​⁯‎‎‪‏⁯‍‎​‪⁬‍‌‮‌‌‭⁮‍⁫⁪‫‍‮((Image) bitmapsource, (Stream) memoryStream, BitmapConversion.\u200D⁫‎⁪‌‎‫⁭⁫⁯‬‫⁮‬‍‭‎​‮​⁪⁬‭‮​​‮​‎‎‮‪‌‪⁮‌⁪⁮‌‪‮());
label_2:
        int num1 = 1858936171;
        while (true)
        {
          int num2 = 1056630638;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 1:
              BitmapConversion.\u202D‪⁫‮⁪⁬‫‎⁮⁪⁪⁫‪‭⁮‫‬⁬‌‫​‌‏⁫‏‌‭‌‌‭⁮⁬⁫⁯‎‪‌‍‮‎‮(bitmapImage);
              num1 = (int) num3 * -49912566 ^ 272664745;
              continue;
            case 2:
              BitmapConversion.\u200B‮⁭‮‮‮‮‫‏⁬‬‎​‌​​‏‫⁮⁪‏⁯⁬​⁬⁪‮‏‍⁫‮⁬⁪⁭⁮⁯‍‍‭⁫‮((Stream) memoryStream, 0L);
              num1 = (int) num3 * 8786679 ^ 1861625000;
              continue;
            case 3:
              num1 = (int) num3 * -104433722 ^ 1637995689;
              continue;
            case 4:
              BitmapConversion.\u200B⁪‍⁬⁫‌⁫‍‬‌⁯‭‏‮⁭‎‫​‫⁯‬‎​‮⁬‭‭‪⁫⁭‎‫‏⁫‮⁯⁫‎‫⁪‮(bitmapImage);
              BitmapConversion.\u206F‏⁬‬⁫⁪​‏⁪‎⁫⁯​‫⁪​‎‍‍⁯‭‏⁫⁮‫‎‮‫‫‮‎⁭⁮⁬⁮‎‮‌​‫‮(bitmapImage, (Stream) memoryStream);
              num1 = (int) num3 * 1183331616 ^ 479823466;
              continue;
            case 5:
              goto label_2;
            case 6:
              BitmapConversion.\u206F‏‍‬‪‏​‪​‬‭‍‭‍‪⁬⁬‍‏⁮​⁯‌‍‪‭⁮⁫⁬⁪​⁬⁯‎‮⁮‬‫‮‎‮(bitmapImage, BitmapCacheOption.OnLoad);
              num1 = (int) num3 * 2040860367 ^ -236968657;
              continue;
            case 7:
              num1 = (int) num3 * -901365931 ^ 515903241;
              continue;
            case 8:
              num1 = (int) num3 * -632926868 ^ -1238783486;
              continue;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
label_12:
          int num1 = 467213631;
          while (true)
          {
            int num2 = 1056630638;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_12;
              case 1:
                BitmapConversion.\u202C‫⁪‌‫‪​‮‏⁮‎⁯⁪⁮‮‭⁬‎‭⁬‍‬‌‫‏‏‪⁮‫‪⁯‪⁭⁮‪‍‍⁪⁪‍‮((IDisposable) memoryStream);
                num1 = (int) num3 * -1849933130 ^ 396730091;
                continue;
              case 3:
                num1 = (int) num3 * -767568186 ^ -699702838;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      return bitmapImage;
    }

    public static Bitmap ToWinFormsBitmap(this BitmapSource bitmapsource)
    {
      MemoryStream memoryStream = BitmapConversion.\u200B‌‮⁪⁯‭⁬‫⁮⁪⁮⁮‭‎​⁭⁫‎‬‪‎⁭⁭⁪⁬⁮‏⁮‫‎⁯‪‫‎‌⁮‎‭‮⁫‮();
      try
      {
label_2:
        int num1 = -424878652;
        while (true)
        {
          int num2 = -960122633;
          uint num3;
          BitmapEncoder bitmapEncoder;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              BitmapConversion.\u202A​‬‬‎⁭‌‭‌‪‍‌‭⁬⁪​⁬‮⁫‍‌⁭⁭‎‏‬‏⁬⁪‎⁬​​⁫⁪⁯⁮‬‪‭‮(bitmapEncoder).Add(BitmapConversion.\u200B‫‪‮‌⁮‎‬⁯​⁯‫‪‍‮⁬⁫‫⁭‬​‪‬‮‏‏‬⁪​​‍‎‎‌‭⁪⁬⁮‏‭‮(bitmapsource));
              num1 = (int) num3 * -989344769 ^ 1071330228;
              continue;
            case 2:
              goto label_2;
            case 3:
              bitmapEncoder = (BitmapEncoder) BitmapConversion.\u206E‌‪‏⁭‬⁭‪‌⁪⁪‪⁬‏‮‬‮‏⁭‎‌‮⁯‮‬⁬⁯⁬‌‪‎‌‏⁯‏‍⁭‫⁭⁭‮();
              num1 = (int) num3 * 1827333278 ^ -667174877;
              continue;
            case 4:
              BitmapConversion.\u202E⁪⁯⁭⁬⁭⁬‫⁬‌⁪​‌‌‫⁭⁪​‏⁭​‭⁫⁬​‪‍⁭​⁭‏⁬‏‌‭‍⁫‮⁪‮‮(bitmapEncoder, (Stream) memoryStream);
              num1 = (int) num3 * 1199093872 ^ -1444063806;
              continue;
            case 5:
              num1 = (int) num3 * 469211150 ^ -497184601;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        Bitmap bitmap = BitmapConversion.\u206E⁬⁪‭⁪‌‮‫‭‏‬⁬‎‌‬⁪‪⁭‫‬⁪‌‪‍‍⁬‪⁯‮⁯‍​‌⁪‍⁭‍‭⁫‮((Stream) memoryStream);
        try
        {
          return BitmapConversion.\u206C​⁬‪‎‎‎‍‎​⁯‬‪‪⁭‬‏‎⁬⁮⁯⁮​‭⁭‮⁬⁫⁭⁬​⁬‏⁭⁮⁮⁭‭‪‪‮((Image) bitmap);
        }
        finally
        {
          if (bitmap != null)
          {
label_11:
            int num2 = -149221620;
            while (true)
            {
              int num3 = -960122633;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_11;
                case 2:
                  BitmapConversion.\u202C‫⁪‌‫‪​‮‏⁮‎⁯⁪⁮‮‭⁬‎‭⁬‍‬‌‫‏‏‪⁮‫‪⁯‪⁭⁮‪‍‍⁪⁪‍‮((IDisposable) bitmap);
                  num2 = (int) num4 * 110062226 ^ 137486675;
                  continue;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
      }
      finally
      {
        if (memoryStream != null)
        {
label_16:
          int num1 = -201701574;
          while (true)
          {
            int num2 = -960122633;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -625437665 ^ 2069647025;
                continue;
              case 1:
                BitmapConversion.\u202C‫⁪‌‫‪​‮‏⁮‎⁯⁪⁮‮‭⁬‎‭⁬‍‬‌‫‏‏‪⁮‫‪⁯‪⁭⁮‪‍‍⁪⁪‍‮((IDisposable) memoryStream);
                num1 = (int) num3 * 2142415751 ^ 139240044;
                continue;
              case 3:
                goto label_16;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    public static BitmapSource ToWpfBitmap(this Bitmap bitmap)
    {
      MemoryStream memoryStream = BitmapConversion.\u200B‌‮⁪⁯‭⁬‫⁮⁪⁮⁮‭‎​⁭⁫‎‬‪‎⁭⁭⁪⁬⁮‏⁮‫‎⁯‪‫‎‌⁮‎‭‮⁫‮();
      try
      {
label_2:
        int num1 = 1380956596;
        BitmapImage bitmapImage;
        while (true)
        {
          int num2 = 845594902;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              BitmapConversion.\u200B‮⁭‮‮‮‮‫‏⁬‬‎​‌​​‏‫⁮⁪‏⁯⁬​⁬⁪‮‏‍⁫‮⁬⁪⁭⁮⁯‍‍‭⁫‮((Stream) memoryStream, 0L);
              num1 = (int) num3 * -189443503 ^ -1302420099;
              continue;
            case 1:
              BitmapConversion.\u202D‎‍‫⁫‬‌‎‬⁯‍⁬⁮‪⁭‎​⁯‎‎‪‏⁯‍‎​‪⁬‍‌‮‌‌‭⁮‍⁫⁪‫‍‮((Image) bitmap, (Stream) memoryStream, BitmapConversion.\u200B‌‍⁪‍⁭‎⁬‌‏⁫‏‭⁬‮‪⁭⁪‬‭‎‫⁪⁯‬⁪‍‌‮⁫⁪​‌‍⁫​‬⁮​⁫‮());
              num1 = (int) num3 * 216483763 ^ 1939527615;
              continue;
            case 2:
              BitmapConversion.\u206F‏⁬‬⁫⁪​‏⁪‎⁫⁯​‫⁪​‎‍‍⁯‭‏⁫⁮‫‎‮‫‫‮‎⁭⁮⁬⁮‎‮‌​‫‮(bitmapImage, (Stream) memoryStream);
              num1 = (int) num3 * 225685497 ^ 492936701;
              continue;
            case 4:
              num1 = (int) num3 * -2086510690 ^ 1757635611;
              continue;
            case 5:
              goto label_2;
            case 6:
              bitmapImage = BitmapConversion.\u206C⁫‍‍‫⁬⁯‮‎‮‪‌⁪‌‫‮​‍‌⁪⁪‎‏⁭‮⁬⁯​⁯⁪‪⁫‭​‮‭⁪‪‫⁬‮();
              BitmapConversion.\u200B⁪‍⁬⁫‌⁫‍‬‌⁯‭‏‮⁭‎‫​‫⁯‬‎​‮⁬‭‭‪⁫⁭‎‫‏⁫‮⁯⁫‎‫⁪‮(bitmapImage);
              BitmapConversion.\u206F‏‍‬‪‏​‪​‬‭‍‭‍‪⁬⁬‍‏⁮​⁯‌‍‪‭⁮⁫⁬⁪​⁬⁯‎‮⁮‬‫‮‎‮(bitmapImage, BitmapCacheOption.OnLoad);
              num1 = (int) num3 * -1367521374 ^ -682624488;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        BitmapConversion.\u202D‪⁫‮⁪⁬‫‎⁮⁪⁪⁫‪‭⁮‫‬⁬‌‫​‌‏⁫‏‌‭‌‌‭⁮⁬⁫⁯‎‪‌‍‮‎‮(bitmapImage);
        BitmapConversion.\u206B⁬​‪⁮⁭‬​⁫⁮⁭‏⁫⁯​‭‎⁪‏‍⁫‏‫​‎‎⁭‮‪‎‏⁭‭‫⁯⁭⁯‬⁭⁮‮((Freezable) bitmapImage);
        return (BitmapSource) bitmapImage;
      }
      finally
      {
        if (memoryStream != null)
        {
label_11:
          int num1 = 1950182629;
          while (true)
          {
            int num2 = 845594902;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                BitmapConversion.\u202C‫⁪‌‫‪​‮‏⁮‎⁯⁪⁮‮‭⁬‎‭⁬‍‬‌‫‏‏‪⁮‫‪⁯‪⁭⁮‪‍‍⁪⁪‍‮((IDisposable) memoryStream);
                num1 = (int) num3 * 1798726627 ^ 1703101472;
                continue;
              case 2:
                goto label_11;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    static MemoryStream \u200F⁬‮⁪‮⁯⁬‪‮⁭⁪⁬‬‭⁮‫‍⁫⁮‮⁪⁪‏‎⁫⁪‮⁬‪⁯​⁪‪⁮​⁮‎‏⁬‎‮([In] byte[] obj0)
    {
      return new MemoryStream(obj0);
    }

    static BitmapFrame \u200B‮⁭⁬‎‬​⁬​⁫⁮‪‎‍​‏‫‪‭⁯‎⁭⁮⁯​⁯‏⁮⁪‍⁫‪‫‪⁪‪⁬⁭⁫‬‮([In] Stream obj0)
    {
      return BitmapFrame.Create(obj0);
    }

    static BitmapImage \u206C⁫‍‍‫⁬⁯‮‎‮‪‌⁪‌‫‮​‍‌⁪⁪‎‏⁭‮⁬⁯​⁯⁪‪⁫‭​‮‭⁪‪‫⁬‮()
    {
      return new BitmapImage();
    }

    static MemoryStream \u200B‌‮⁪⁯‭⁬‫⁮⁪⁮⁮‭‎​⁭⁫‎‬‪‎⁭⁭⁪⁬⁮‏⁮‫‎⁯‪‫‎‌⁮‎‭‮⁫‮()
    {
      return new MemoryStream();
    }

    static ImageFormat \u200D⁫‎⁪‌‎‫⁭⁫⁯‬‫⁮‬‍‭‎​‮​⁪⁬‭‮​​‮​‎‎‮‪‌‪⁮‌⁪⁮‌‪‮()
    {
      return ImageFormat.Png;
    }

    static void \u202D‎‍‫⁫‬‌‎‬⁯‍⁬⁮‪⁭‎​⁯‎‎‪‏⁯‍‎​‪⁬‍‌‮‌‌‭⁮‍⁫⁪‫‍‮([In] Image obj0, [In] Stream obj1, [In] ImageFormat obj2)
    {
      obj0.Save(obj1, obj2);
    }

    static void \u200B‮⁭‮‮‮‮‫‏⁬‬‎​‌​​‏‫⁮⁪‏⁯⁬​⁬⁪‮‏‍⁫‮⁬⁪⁭⁮⁯‍‍‭⁫‮([In] Stream obj0, [In] long obj1)
    {
      obj0.Position = obj1;
    }

    static void \u200B⁪‍⁬⁫‌⁫‍‬‌⁯‭‏‮⁭‎‫​‫⁯‬‎​‮⁬‭‭‪⁫⁭‎‫‏⁫‮⁯⁫‎‫⁪‮([In] BitmapImage obj0)
    {
      obj0.BeginInit();
    }

    static void \u206F‏⁬‬⁫⁪​‏⁪‎⁫⁯​‫⁪​‎‍‍⁯‭‏⁫⁮‫‎‮‫‫‮‎⁭⁮⁬⁮‎‮‌​‫‮([In] BitmapImage obj0, [In] Stream obj1)
    {
      obj0.StreamSource = obj1;
    }

    static void \u206F‏‍‬‪‏​‪​‬‭‍‭‍‪⁬⁬‍‏⁮​⁯‌‍‪‭⁮⁫⁬⁪​⁬⁯‎‮⁮‬‫‮‎‮([In] BitmapImage obj0, [In] BitmapCacheOption obj1)
    {
      obj0.CacheOption = obj1;
    }

    static void \u202D‪⁫‮⁪⁬‫‎⁮⁪⁪⁫‪‭⁮‫‬⁬‌‫​‌‏⁫‏‌‭‌‌‭⁮⁬⁫⁯‎‪‌‍‮‎‮([In] BitmapImage obj0)
    {
      obj0.EndInit();
    }

    static void \u202C‫⁪‌‫‪​‮‏⁮‎⁯⁪⁮‮‭⁬‎‭⁬‍‬‌‫‏‏‪⁮‫‪⁯‪⁭⁮‪‍‍⁪⁪‍‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static BmpBitmapEncoder \u206E‌‪‏⁭‬⁭‪‌⁪⁪‪⁬‏‮‬‮‏⁭‎‌‮⁯‮‬⁬⁯⁬‌‪‎‌‏⁯‏‍⁭‫⁭⁭‮()
    {
      return new BmpBitmapEncoder();
    }

    static IList<BitmapFrame> \u202A​‬‬‎⁭‌‭‌‪‍‌‭⁬⁪​⁬‮⁫‍‌⁭⁭‎‏‬‏⁬⁪‎⁬​​⁫⁪⁯⁮‬‪‭‮([In] BitmapEncoder obj0)
    {
      return obj0.Frames;
    }

    static BitmapFrame \u200B‫‪‮‌⁮‎‬⁯​⁯‫‪‍‮⁬⁫‫⁭‬​‪‬‮‏‏‬⁪​​‍‎‎‌‭⁪⁬⁮‏‭‮([In] BitmapSource obj0)
    {
      return BitmapFrame.Create(obj0);
    }

    static void \u202E⁪⁯⁭⁬⁭⁬‫⁬‌⁪​‌‌‫⁭⁪​‏⁭​‭⁫⁬​‪‍⁭​⁭‏⁬‏‌‭‍⁫‮⁪‮‮([In] BitmapEncoder obj0, [In] Stream obj1)
    {
      obj0.Save(obj1);
    }

    static Bitmap \u206E⁬⁪‭⁪‌‮‫‭‏‬⁬‎‌‬⁪‪⁭‫‬⁪‌‪‍‍⁬‪⁯‮⁯‍​‌⁪‍⁭‍‭⁫‮([In] Stream obj0)
    {
      return new Bitmap(obj0);
    }

    static Bitmap \u206C​⁬‪‎‎‎‍‎​⁯‬‪‪⁭‬‏‎⁬⁮⁯⁮​‭⁭‮⁬⁫⁭⁬​⁬‏⁭⁮⁮⁭‭‪‪‮([In] Image obj0)
    {
      return new Bitmap(obj0);
    }

    static ImageFormat \u200B‌‍⁪‍⁭‎⁬‌‏⁫‏‭⁬‮‪⁭⁪‬‭‎‫⁪⁯‬⁪‍‌‮⁫⁪​‌‍⁫​‬⁮​⁫‮()
    {
      return ImageFormat.Bmp;
    }

    static void \u206B⁬​‪⁮⁭‬​⁫⁮⁭‏⁫⁯​‭‎⁪‏‍⁫‏‫​‎‎⁭‮‪‎‏⁭‭‫⁯⁭⁯‬⁭⁮‮([In] Freezable obj0)
    {
      obj0.Freeze();
    }
  }
}
