// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.ImageHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Media.Imaging;
using ZoomZoom.Models.Utils;

namespace ZoomZoom.Models.Images
{
  public static class ImageHelper
  {
    public static readonly ILog log = ImageHelper.\u202B‮‮‫⁯‏⁯⁮​⁭​⁬⁫​⁪‎‬⁪​⁫‍⁭‮⁭‬⁮​‪‪​‏​⁬⁬⁪⁭‮‪‍‌‮(ImageHelper.\u206D‌‌​⁭​⁬‎‏‎⁮‍‌‪‎‭‍‍‍⁯​‎⁯‪‪‏⁬​⁪⁫⁮‫‌‭‭​‭‭‏‬‮((MemberInfo) ImageHelper.\u202D⁯⁭‮‬‭⁮‪⁫‏‎⁯⁬‪‭‎⁮‬‍‮⁭⁬⁭‎‬⁮‏‎‍⁭⁯‌⁬‏‏‭⁮‌‮()));

    public static Bitmap GetBitmap(BitmapSource source)
    {
label_1:
      int num1 = -435835232;
      Bitmap bitmap1;
      while (true)
      {
        int num2 = -1119628524;
        uint num3;
        BitmapData bitmapdata;
        Bitmap bitmap2;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            bitmap2 = ImageHelper.\u200F‭‎‍‏‏‫⁫⁪‫⁯‬​⁮​​⁮⁬‪‬‬⁬​‭‫‎‫‍⁫⁪⁫⁭⁫‏‎‏‍‎⁪‮‮(ImageHelper.\u200C⁯‪‭‎⁫‍‪‎⁪⁬‪‭⁬⁮‏‬‭‪‎⁮‬‌‪⁬⁪‫⁯‬⁬‬‮​⁮‌‫⁮‬‫⁮‮(source), ImageHelper.\u200C‮‭⁯⁫​⁭‬⁯⁫⁮‭⁭⁮‫⁪⁬‎‪⁬⁯‌⁫​‬⁬⁬⁫⁭‌‏⁭⁮​‫⁭⁮‍‪‪‮(source), PixelFormat.Format32bppPArgb);
            num1 = (int) num3 * -586046907 ^ 494827438;
            continue;
          case 2:
            bitmap1 = bitmap2;
            num1 = (int) num3 * 2134240702 ^ 1891154430;
            continue;
          case 3:
            bitmap2.UnlockBits(bitmapdata);
            num1 = (int) num3 * 129514854 ^ 614444579;
            continue;
          case 4:
            source.CopyPixels(Int32Rect.Empty, bitmapdata.Scan0, bitmapdata.Height * bitmapdata.Stride, bitmapdata.Stride);
            num1 = (int) num3 * 575296595 ^ 1114542029;
            continue;
          case 5:
            bitmapdata = bitmap2.LockBits(new Rectangle(System.Drawing.Point.Empty, ImageHelper.\u206D⁮‍‎‌‌⁪⁯​‭‏⁪⁪‬‏⁬‫‪⁯⁬‭‍‌⁬⁪⁪‌⁯⁫‎⁪‪⁮‎‭‏⁬‍⁪‌‮((Image) bitmap2)), ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            num1 = (int) num3 * -592187131 ^ 1921675515;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return bitmap1;
    }

    internal static bool ContainsImage(object bitmap, Bitmap exemplar)
    {
      throw ImageHelper.\u206F⁯⁭‮‮⁯‪⁮‍‎⁮⁯⁪⁬‌‬‬‬‬‭‏‪​‎‭⁪‪‍‫​⁯‬⁭‭⁯‮⁬‬⁯‏‮();
    }

    public static bool AllOneColor(BitmapSource bitmapSource)
    {
      bool flag1 = true;
      bool flag2;
      try
      {
        Bitmap bitmap = ImageHelper.GetBitmap(bitmapSource);
        try
        {
          Color color = ImageHelper.\u200E⁮⁫‍‫⁮⁭‭‏⁮⁮‏‫⁮⁭‍‏‏‮‬⁭‎‭⁮‪⁪‏‫⁬‫⁬‎‮‌⁯‍⁪‌‮⁭‮(bitmap, 0, 0);
label_3:
          int num1 = -1568166581;
          while (true)
          {
            int num2 = -832990604;
            uint num3;
            int num4;
            bool flag3;
            int num5;
            switch ((num3 = (uint) (num1 ^ num2)) % 21U)
            {
              case 1:
                num1 = -148532888;
                continue;
              case 2:
                int num6 = ImageHelper.\u200E⁮⁫‍‫⁮⁭‭‏⁮⁮‏‫⁮⁭‍‏‏‮‬⁭‎‭⁮‪⁪‏‫⁬‫⁬‎‮‌⁯‍⁪‌‮⁭‮(bitmap, num4, num5).Equals((object) color) ? -1342989651 : (num6 = -1736409472);
                int num7 = (int) num3 * 1599228950;
                num1 = num6 ^ num7;
                continue;
              case 3:
                num1 = -494293258;
                continue;
              case 4:
                ++num4;
                num1 = (int) num3 * 407976716 ^ -458202990;
                continue;
              case 5:
                int num8;
                num1 = num8 = num4 < ImageHelper.\u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮((Image) bitmap) ? -1084058597 : (num8 = -334671966);
                continue;
              case 6:
                num4 = 0;
                num1 = (int) num3 * 794792009 ^ -1749229730;
                continue;
              case 7:
                flag2 = false;
                num1 = (int) num3 * -393082196 ^ -910319055;
                continue;
              case 8:
                ++num5;
                num1 = -1569341089;
                continue;
              case 9:
                goto label_31;
              case 10:
                flag1 = false;
                num1 = (int) num3 * -667671842 ^ 326553876;
                continue;
              case 11:
                flag3 = num5 < ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) bitmap);
                num1 = -743666850;
                continue;
              case 12:
                num1 = (int) num3 * -845190315 ^ -956568085;
                continue;
              case 13:
                goto label_3;
              case 14:
                num5 = 0;
                num1 = (int) num3 * -1796312033 ^ 1700857809;
                continue;
              case 15:
                int num9 = !flag1 ? 259099501 : (num9 = 2032021006);
                int num10 = (int) num3 * -851625385;
                num1 = num9 ^ num10;
                continue;
              case 16:
                num1 = -850699627;
                continue;
              case 17:
                int num11 = flag3 ? 48702006 : (num11 = 1083598095);
                int num12 = (int) num3 * -1930635275;
                num1 = num11 ^ num12;
                continue;
              case 18:
                num1 = (int) num3 * -659221058 ^ 67305846;
                continue;
              case 19:
                num1 = -1402385041;
                continue;
              case 20:
                num1 = (int) num3 * -2089248462 ^ 1500441931;
                continue;
              default:
                goto label_30;
            }
          }
        }
        finally
        {
          if (bitmap != null)
          {
label_24:
            int num1 = -255146843;
            while (true)
            {
              int num2 = -832990604;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * -96551821 ^ 1072387107;
                  continue;
                case 1:
                  ImageHelper.\u206E⁭⁫⁪‪‍‬⁫‏⁬⁪‫‏‭⁭⁪⁭‌⁬‭‪⁬‎‭⁪‍‭⁮⁫‭⁭⁮‏⁫‪‮‏‮‍‎‮((IDisposable) bitmap);
                  num1 = (int) num3 * -1623245281 ^ -945521405;
                  continue;
                case 2:
                  goto label_24;
                default:
                  goto label_28;
              }
            }
          }
label_28:;
        }
      }
      catch (Exception ex)
      {
        ImageHelper.\u206F‍‮‫‪‏⁫⁯‎⁮‌‎‍‮‭‫‪‍‪‫‍‮⁯⁭‫‍‭‭‫⁫⁫​⁫⁫‮⁬‌⁭‍‍‮(ImageHelper.log, (object) ex);
        throw;
      }
label_30:
      flag2 = flag1;
label_31:
      return flag2;
    }

    public static void SetClipboardImage(BitmapSource source)
    {
label_1:
      int num1 = -178669577;
      while (true)
      {
        int num2 = -2097133837;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ImageHelper.\u200F‏‬‌‫‮‪‮‬‪⁭‫⁪‌‪⁯‎‭​⁯​‪‮⁫⁬‭‏‎‮⁯⁫‪‬‪⁫‭‎‫‮‮((object) source);
            num1 = (int) num3 * -203126680 ^ -2090906433;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public static void SetClipboardImage(Bitmap source)
    {
      ImageHelper.\u200F‏‬‌‫‮‪‮‬‪⁭‫⁪‌‪⁯‎‭​⁯​‪‮⁫⁬‭‏‎‮⁯⁫‪‬‪⁫‭‎‫‮‮((object) source);
label_1:
      int num1 = 1633752811;
      while (true)
      {
        int num2 = 530257983;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1691360092 ^ -9683574;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public static void SetClipboardImage(BitmapImage source)
    {
      ImageHelper.\u200F‏‬‌‫‮‪‮‬‪⁭‫⁪‌‪⁯‎‭​⁯​‪‮⁫⁬‭‏‎‮⁯⁫‪‬‪⁫‭‎‫‮‮((object) source);
    }

    internal static BitmapSource CaptureRegion(IntPtr hWnd, int x, int y, int width, int height, bool addToClipboard)
    {
      IntPtr num1 = IntPtr.Zero;
label_1:
      int num2 = -481775698;
      IntPtr num3;
      IntPtr num4;
      while (true)
      {
        int num5 = -129323782;
        uint num6;
        switch ((num6 = (uint) (num2 ^ num5)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num3 = IntPtr.Zero;
            num4 = IntPtr.Zero;
            num2 = (int) num6 * -587573738 ^ -419688775;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      BitmapSource bitmapSource = (BitmapSource) null;
      try
      {
label_6:
        int num5 = -481201444;
        while (true)
        {
          int num6 = -129323782;
          uint num7;
          switch ((num7 = (uint) (num5 ^ num6)) % 12U)
          {
            case 0:
              num5 = (int) num7 * 574999816 ^ 2137642070;
              continue;
            case 1:
              Gdi32.BitBlt(num3, 0, 0, width, height, num1, x, y, 13369376);
              num5 = (int) num7 * -792944606 ^ -162057479;
              continue;
            case 2:
              num1 = User32.GetDC(User32.GetDesktopWindow());
              num5 = (int) num7 * 540787351 ^ -1673243698;
              continue;
            case 3:
              ImageHelper.\u200F‮⁫‪‪⁭‭‭⁬‏‌‫‌⁮⁯​⁭‌⁬⁬‎‬‌‌⁭‌‫‪‪‬‏‏⁫‫‌⁬​‮⁫⁯‮(bitmapSource);
              num5 = (int) num7 * 107064433 ^ 1159410815;
              continue;
            case 4:
              ImageHelper.\u206E​‏‪‍‏⁯‪​‬‎‫⁮‏‬‏⁫‭‏​‎‍​‏⁬‬⁫‮⁯‭⁭⁬⁮‫‫‮⁮​⁯‮‮((Freezable) bitmapSource);
              num5 = -730803207;
              continue;
            case 5:
              bitmapSource = ImageHelper.\u202B‮⁫‬⁯⁮‭‎​‪⁮‌⁫⁯⁭⁮⁮‎⁬⁮‌‎‪⁪⁫‫⁫‎‪‬⁬‍‭​⁫‍⁫​⁭⁫‮(num4, IntPtr.Zero, Int32Rect.Empty, ImageHelper.\u200F​⁮⁮‭​‫⁫⁫⁬⁪⁫‭⁬‏⁭⁬⁪‬⁭⁯​⁪​⁪‎​‫⁬‮‍‬​‮‬‮‬‏‏⁪‮());
              int num8 = !addToClipboard ? 1182912380 : (num8 = 616482799);
              int num9 = (int) num7 * 1103404154;
              num5 = num8 ^ num9;
              continue;
            case 6:
              num3 = Gdi32.CreateCompatibleDC(num1);
              num4 = Gdi32.CreateCompatibleBitmap(num1, width, height);
              num5 = (int) num7 * 1723290823 ^ 263581065;
              continue;
            case 7:
              num5 = (int) num7 * -1077189660 ^ 280485890;
              continue;
            case 9:
              Gdi32.SelectObject(num3, num4);
              num5 = (int) num7 * 746942090 ^ 1605658797;
              continue;
            case 10:
              num5 = (int) num7 * -2060661843 ^ -261146768;
              continue;
            case 11:
              goto label_6;
            default:
              goto label_25;
          }
        }
      }
      catch (Exception ex)
      {
        ImageHelper.\u206F‍‮‫‪‏⁫⁯‎⁮‌‎‍‮‭‫‪‍‪‫‍‮⁯⁭‫‍‭‭‫⁫⁫​⁫⁫‮⁬‌⁭‍‍‮(ImageHelper.log, (object) ex);
      }
      finally
      {
        Gdi32.DeleteObject(num4);
label_20:
        int num5 = -1170049;
        while (true)
        {
          int num6 = -129323782;
          uint num7;
          switch ((num7 = (uint) (num5 ^ num6)) % 4U)
          {
            case 1:
              User32.ReleaseDC(IntPtr.Zero, num1);
              num5 = (int) num7 * -26451255 ^ 927377793;
              continue;
            case 2:
              User32.ReleaseDC(IntPtr.Zero, num3);
              num5 = (int) num7 * 1612591764 ^ -411918758;
              continue;
            case 3:
              goto label_20;
            default:
              goto label_24;
          }
        }
label_24:;
      }
label_25:
      return bitmapSource;
    }

    internal static bool ContainsImage(Bitmap source, Bitmap whatToFind)
    {
      bool flag = (uint) ImageHelper.searchBitmap(whatToFind, source, 0.1).Width > 0U;
label_1:
      int num1 = 554751529;
      while (true)
      {
        int num2 = 73346225;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 599140710 ^ -469067007;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    internal static unsafe Rectangle searchBitmap(Bitmap smallBmp, Bitmap bigBmp, double tolerance)
    {
      BitmapData bitmapdata1 = smallBmp.LockBits(new Rectangle(0, 0, ImageHelper.\u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮((Image) smallBmp), ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) smallBmp)), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
      BitmapData bitmapdata2 = bigBmp.LockBits(new Rectangle(0, 0, bigBmp.Width, bigBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
      int stride1 = bitmapdata1.Stride;
label_1:
      int num1 = 1381085977;
      Rectangle rectangle;
      while (true)
      {
        int num2 = 1892352585;
        uint num3;
        byte* numPtr1;
        byte* numPtr2;
        byte* numPtr3;
        byte* numPtr4;
        int width;
        int stride2;
        bool flag1;
        int num4;
        int num5;
        int num6;
        bool flag2;
        bool flag3;
        int int32;
        bool flag4;
        bool flag5;
        int num7;
        int num8;
        Rectangle empty;
        bool flag6;
        bool flag7;
        int height;
        int num9;
        int num10;
        int num11;
        bool flag8;
        int num12;
        switch ((num3 = (uint) (num1 ^ num2)) % 64U)
        {
          case 1:
            numPtr2 += num8;
            num1 = 248235445;
            continue;
          case 2:
            flag4 = num4 < height;
            num1 = 1452146566;
            continue;
          case 3:
            num11 = smallBmp.Width * 3;
            num1 = (int) num3 * -1748284083 ^ -1790324107;
            continue;
          case 4:
            num1 = (int) num3 * -917703983 ^ -1011074616;
            continue;
          case 5:
            empty.X = num5;
            num1 = (int) num3 * -1174511886 ^ -1123396236;
            continue;
          case 6:
            int num13 = !flag8 ? 394372302 : (num13 = 2084893949);
            int num14 = (int) num3 * 1740040284;
            num1 = num13 ^ num14;
            continue;
          case 7:
            empty.Y = num9;
            empty.Width = smallBmp.Width;
            empty.Height = smallBmp.Height;
            num1 = (int) num3 * -1881927154 ^ 136232020;
            continue;
          case 8:
            num10 = (int) *numPtr2 - int32;
            num1 = 1583247390;
            continue;
          case 9:
            numPtr1 = numPtr2;
            num1 = (int) num3 * -551888519 ^ -1106547778;
            continue;
          case 10:
            num1 = 671891008;
            continue;
          case 11:
            num1 = (int) num3 * 427337390 ^ 763302963;
            continue;
          case 12:
            num1 = (int) num3 * -1994567275 ^ 591778142;
            continue;
          case 13:
            flag8 = num9 < num7;
            num1 = 1994285711;
            continue;
          case 14:
            byte* numPtr5 = numPtr3;
            byte* numPtr6 = numPtr1;
            numPtr4 = numPtr5 + stride1 * (1 + num4);
            numPtr2 = numPtr6 + stride2 * (1 + num4);
            num1 = 677495776;
            continue;
          case 15:
            int num15 = !flag4 ? 1164846352 : (num15 = 1900409217);
            int num16 = (int) num3 * -1680624227;
            num1 = num15 ^ num16;
            continue;
          case 16:
            stride2 = bitmapdata2.Stride;
            num1 = (int) num3 * 181243804 ^ -359034639;
            continue;
          case 17:
            int num17 = !flag6 ? -1312728789 : (num17 = -264989162);
            int num18 = (int) num3 * 1317476416;
            num1 = num17 ^ num18;
            continue;
          case 18:
            int num19 = !flag7 ? 1742715264 : (num19 = 1351125621);
            int num20 = (int) num3 * 631746755;
            num1 = num19 ^ num20;
            continue;
          case 19:
            int num21;
            num1 = num21 = num6 >= num11 ? 1410525602 : (num21 = 1685223041);
            continue;
          case 20:
            num1 = (int) num3 * 1898794398 ^ 707449206;
            continue;
          case 21:
            ++numPtr4;
            num1 = (int) num3 * -1457943666 ^ -625876037;
            continue;
          case 22:
            int32 = Convert.ToInt32((double) byte.MaxValue * tolerance);
            num1 = (int) num3 * -1528868125 ^ 1803130278;
            continue;
          case 23:
            if ((int) *numPtr2 + int32 >= (int) *numPtr4)
            {
              num1 = (int) num3 * -584014238 ^ 879626404;
              continue;
            }
            num12 = 1;
            break;
          case 24:
            rectangle = empty;
            num1 = (int) num3 * 569560064 ^ -659703038;
            continue;
          case 25:
            goto label_1;
          case 26:
            int num22 = flag3 ? -1204278682 : (num22 = -1149523696);
            int num23 = (int) num3 * -1153783524;
            num1 = num22 ^ num23;
            continue;
          case 27:
            height = smallBmp.Height;
            empty = Rectangle.Empty;
            num1 = (int) num3 * -1949028319 ^ -42618204;
            continue;
          case 28:
            num1 = 1870522344;
            continue;
          case 29:
            bigBmp.UnlockBits(bitmapdata2);
            num1 = (int) num3 * -138887116 ^ -610501811;
            continue;
          case 30:
            flag2 = true;
            num1 = (int) num3 * -2030986231 ^ -1076184650;
            continue;
          case 31:
            num1 = (int) num3 * 1388457077 ^ -356885480;
            continue;
          case 32:
            num1 = (int) num3 * -1916034788 ^ 1063286260;
            continue;
          case 33:
            num5 = 0;
            num1 = (int) num3 * -1781703776 ^ 4796445;
            continue;
          case 34:
            ++numPtr2;
            num1 = 786246620;
            continue;
          case 35:
            num12 = num10 > (int) *numPtr4 ? 1 : 0;
            break;
          case 36:
            numPtr2 += 3;
            num1 = (int) num3 * 1603425367 ^ -626949229;
            continue;
          case 37:
            num1 = (int) num3 * 1418951827 ^ -1513855116;
            continue;
          case 38:
            ++num5;
            num1 = (int) num3 * -968756111 ^ 919368058;
            continue;
          case 39:
            ++num6;
            num1 = (int) num3 * -964167207 ^ -1605744619;
            continue;
          case 40:
            numPtr2 = numPtr1;
            numPtr4 = numPtr3;
            num1 = 508570349;
            continue;
          case 41:
            ++num4;
            num1 = (int) num3 * -142724398 ^ 1974826281;
            continue;
          case 42:
            flag5 = flag2;
            num1 = 142834544;
            continue;
          case 43:
            flag1 = !flag2;
            num1 = 717496379;
            continue;
          case 44:
            num6 = 0;
            num1 = (int) num3 * 1019889777 ^ -1614630597;
            continue;
          case 45:
            numPtr4 = (byte*) (void*) bitmapdata1.Scan0;
            numPtr2 = (byte*) (void*) bitmapdata2.Scan0;
            int num24 = stride1 - smallBmp.Width * 3;
            num8 = stride2 - bigBmp.Width * 3;
            flag2 = true;
            num1 = (int) num3 * 175678423 ^ 428488434;
            continue;
          case 46:
            num1 = (int) num3 * 846461064 ^ -38185069;
            continue;
          case 47:
            num1 = 1869884500;
            continue;
          case 48:
            num9 = 0;
            num1 = (int) num3 * 728021057 ^ -499097590;
            continue;
          case 49:
            num6 = 0;
            num1 = (int) num3 * 2001381409 ^ 594561675;
            continue;
          case 50:
            int num25 = flag1 ? -1817912937 : (num25 = -330724169);
            int num26 = (int) num3 * -2005684936;
            num1 = num25 ^ num26;
            continue;
          case 51:
            num1 = (int) num3 * 1225275659 ^ -33295371;
            continue;
          case 52:
            num1 = (int) num3 * -872574478 ^ 765441748;
            continue;
          case 53:
            flag7 = num5 < width;
            num1 = 1440810331;
            continue;
          case 54:
            numPtr3 = numPtr4;
            num4 = 0;
            num1 = (int) num3 * -1467543386 ^ 1831229736;
            continue;
          case 55:
            num1 = (int) num3 * -1738752329 ^ 943033207;
            continue;
          case 56:
            width = bigBmp.Width;
            num1 = (int) num3 * -1771420671 ^ 1855478223;
            continue;
          case 57:
            int num27 = flag5 ? -75192409 : (num27 = -979630965);
            int num28 = (int) num3 * -889095174;
            num1 = num27 ^ num28;
            continue;
          case 58:
            flag2 = false;
            num1 = (int) num3 * 583518944 ^ 49767045;
            continue;
          case 59:
            num1 = 1408729125;
            continue;
          case 60:
            ++num9;
            num1 = (int) num3 * -1895112951 ^ -107042152;
            continue;
          case 61:
            smallBmp.UnlockBits(bitmapdata1);
            num1 = (int) num3 * 1735696647 ^ 1145599098;
            continue;
          case 62:
            num7 = bigBmp.Height - smallBmp.Height + 1;
            num1 = (int) num3 * -1529322127 ^ -2095842348;
            continue;
          case 63:
            flag3 = flag2;
            num1 = 416452819;
            continue;
          default:
            goto label_68;
        }
        flag6 = num12 != 0;
        num1 = 265448280;
      }
label_68:
      return rectangle;
    }

    internal static bool CompareBitmaps(Image left, Image right)
    {
      if (!ImageHelper.\u202B⁫‭‍‌‮‌​⁪‏‮⁯‭‌‮⁯‏‫‬⁫‬⁪‏‭‭‪⁮⁫‪‫‎⁯⁬‫‮‪‮⁪⁪‏‮((object) left, (object) right))
        goto label_19;
label_1:
      int num1 = -1530054754;
label_2:
      bool flag1;
      bool flag2;
      while (true)
      {
        int num2 = -1440303412;
        uint num3;
        int index;
        int length;
        bool flag3;
        bool flag4;
        Bitmap bitmap1;
        BitmapData bitmapdata1;
        Bitmap bitmap2;
        BitmapData bitmapdata2;
        byte[] destination1;
        byte[] destination2;
        bool flag5;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 36U)
        {
          case 0:
            index = 0;
            num1 = (int) num3 * -1794862325 ^ -965215773;
            continue;
          case 1:
            num1 = -898767434;
            continue;
          case 2:
            flag1 = false;
            num1 = (int) num3 * -226229296 ^ 1542225612;
            continue;
          case 3:
            flag3 = index <= length - 1;
            num1 = -115026661;
            continue;
          case 4:
            bitmap1.UnlockBits(bitmapdata1);
            bitmap2.UnlockBits(bitmapdata2);
            num1 = -137427850;
            continue;
          case 5:
            flag5 = (int) destination1[index] != (int) destination2[index];
            num1 = (int) num3 * -111779227 ^ -933934767;
            continue;
          case 6:
            flag1 = flag4;
            num1 = (int) num3 * -149818887 ^ 1933375154;
            continue;
          case 7:
            goto label_24;
          case 8:
            num1 = (int) num3 * -1315160045 ^ 170931668;
            continue;
          case 9:
            flag1 = true;
            num1 = (int) num3 * 1460147607 ^ -1952055532;
            continue;
          case 10:
            bitmapdata2 = bitmap2.LockBits(new Rectangle(0, 0, bitmap2.Width - 1, bitmap2.Height - 1), ImageLockMode.ReadOnly, bitmap2.PixelFormat);
            Marshal.Copy(bitmapdata1.Scan0, destination1, 0, length);
            num1 = (int) num3 * -309250373 ^ -1922060638;
            continue;
          case 11:
            num1 = -1105465171;
            continue;
          case 12:
            num1 = (int) num3 * -1641924844 ^ -1975706400;
            continue;
          case 13:
            length = ImageHelper.\u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮(left) * ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮(left) * (ImageHelper.\u206A⁯‍‍‭‭⁪⁮‎‏⁬‬​‬⁯⁭‮⁬⁭⁫‎‫‌‪‎‬⁫⁫‫⁬‫‏⁬‎‎‍⁫⁬‪⁭‮(ImageHelper.\u206D⁭‏⁬‮‏⁯⁭‍⁬‍⁯‏‫‬‮⁬‪⁫‏‏‫‌‎‬⁮‪‪‍‎‌‫‪‫‫‍‍‌⁪‫‮(left)) / 8);
            flag4 = true;
            destination1 = new byte[length];
            num1 = -1613648629;
            continue;
          case 14:
            num4 = bitmap2 == null ? 1 : 0;
            break;
          case 15:
            int num6 = !flag3 ? 1710046051 : (num6 = 1384907184);
            int num7 = (int) num3 * -831815711;
            num1 = num6 ^ num7;
            continue;
          case 16:
            int num8 = flag5 ? -989452023 : (num8 = -1268892127);
            int num9 = (int) num3 * -193638933;
            num1 = num8 ^ num9;
            continue;
          case 17:
            flag4 = false;
            num1 = (int) num3 * -251801047 ^ 1204941617;
            continue;
          case 18:
            bitmap1 = left as Bitmap;
            bitmap2 = right as Bitmap;
            num1 = -602138984;
            continue;
          case 19:
            destination2 = new byte[length];
            num1 = (int) num3 * -1081178609 ^ -1722104503;
            continue;
          case 20:
            bitmapdata1 = bitmap1.LockBits(new Rectangle(0, 0, ImageHelper.\u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮((Image) bitmap1) - 1, ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) bitmap1) - 1), ImageLockMode.ReadOnly, bitmap1.PixelFormat);
            num1 = (int) num3 * -1135429412 ^ 1156937558;
            continue;
          case 21:
            goto label_1;
          case 22:
            ++index;
            num1 = (int) num3 * -204690406 ^ 1056841819;
            continue;
          case 23:
            num1 = (int) num3 * 199396569 ^ -1090880361;
            continue;
          case 24:
            if (bitmap1 != null)
            {
              num1 = (int) num3 * 1880320983 ^ -1645768022;
              continue;
            }
            num4 = 1;
            break;
          case 25:
            num1 = (int) num3 * -522560188 ^ 1778466644;
            continue;
          case 26:
            num5 = !ImageHelper.\u206D⁭‏⁬‮‏⁯⁭‍⁬‍⁯‏‫‬‮⁬‪⁫‏‏‫‌‎‬⁮‪‪‍‎‌‫‪‫‫‍‍‌⁪‫‮(left).Equals((object) ImageHelper.\u206D⁭‏⁬‮‏⁯⁭‍⁬‍⁯‏‫‬‮⁬‪⁫‏‏‫‌‎‬⁮‪‪‍‎‌‫‪‫‫‍‍‌⁪‫‮(right)) ? 1 : 0;
            goto label_44;
          case 27:
            flag1 = false;
            num1 = (int) num3 * 593166833 ^ 395074854;
            continue;
          case 29:
            num1 = (int) num3 * -1150772322 ^ 443392063;
            continue;
          case 30:
            num1 = (int) num3 * 1576411812 ^ 2009498374;
            continue;
          case 31:
            goto label_19;
          case 32:
            Marshal.Copy(bitmapdata2.Scan0, destination2, 0, length);
            num1 = (int) num3 * -1244883965 ^ 1042908408;
            continue;
          case 33:
            int num10 = flag2 ? -2086018952 : (num10 = -615513472);
            int num11 = (int) num3 * -1914937157;
            num1 = num10 ^ num11;
            continue;
          case 34:
            flag1 = true;
            num1 = (int) num3 * 1063262699 ^ -277463770;
            continue;
          case 35:
            if (ImageHelper.\u206D⁮‍‎‌‌⁪⁯​‭‏⁪⁪‬‏⁬‫‪⁯⁬‭‍‌⁬⁪⁪‌⁯⁫‎⁪‪⁮‎‭‏⁬‍⁪‌‮(left).Equals((object) ImageHelper.\u206D⁮‍‎‌‌⁪⁯​‭‏⁪⁪‬‏⁬‫‪⁯⁬‭‍‌⁬⁪⁪‌⁯⁫‎⁪‪⁮‎‭‏⁬‍⁪‌‮(right)))
            {
              num1 = -306085830;
              continue;
            }
            num5 = 1;
            goto label_44;
          default:
            goto label_46;
        }
        int num12;
        num1 = num12 = num4 == 0 ? -1142874091 : (num12 = -1443422771);
        continue;
label_44:
        int num13;
        num1 = num13 = num5 == 0 ? -1786714154 : (num13 = -1020467318);
      }
label_24:
      int num14 = right == null ? 1 : 0;
      goto label_26;
label_46:
      return flag1;
label_19:
      if (left != null)
      {
        num1 = -959230173;
        goto label_2;
      }
      else
        num14 = 1;
label_26:
      flag2 = num14 != 0;
      num1 = -2022902107;
      goto label_2;
    }

    public static int[,] isImageThere(Bitmap fullImage, Bitmap smallImage)
    {
      Color[,] array1 = ImageHelper.ImageToArray(fullImage);
label_1:
      int num1 = 1432076546;
      int[,] numArray;
      while (true)
      {
        int num2 = 503534700;
        uint num3;
        int index1;
        int index2;
        int index3;
        int index4;
        bool flag1;
        bool flag2;
        bool flag3;
        Color[,] array2;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 41U)
        {
          case 0:
            flag2 = false;
            num1 = (int) num3 * 414027829 ^ -1346321475;
            continue;
          case 1:
            numArray = new int[1, 2]{ { index1, index2 } };
            num1 = (int) num3 * 610393294 ^ 1885925943;
            continue;
          case 2:
            ++index2;
            num1 = (int) num3 * 43323004 ^ -376320160;
            continue;
          case 3:
            int num4;
            num1 = num4 = index4 < ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) smallImage) ? 289050666 : (num4 = 839237994);
            continue;
          case 4:
            int num5 = flag1 ? -415228266 : (num5 = -2089322155);
            int num6 = (int) num3 * 1229341798;
            num1 = num5 ^ num6;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * -225872137 ^ 966551914;
            continue;
          case 7:
            num1 = (int) num3 * 918735923 ^ 1245149674;
            continue;
          case 8:
            num1 = 822624735;
            continue;
          case 9:
            ++index1;
            num1 = 1247874637;
            continue;
          case 10:
            int num7;
            num1 = num7 = !flag2 ? 1071297991 : (num7 = 1121214684);
            continue;
          case 11:
            num1 = (int) num3 * -113967425 ^ -1668075974;
            continue;
          case 12:
            flag3 = !flag2;
            num1 = 539904289;
            continue;
          case 13:
            num1 = 608542647;
            continue;
          case 14:
            numArray = (int[,]) null;
            num1 = (int) num3 * -155376225 ^ -666616204;
            continue;
          case 15:
            num1 = (int) num3 * -1043426547 ^ 1497171907;
            continue;
          case 16:
            index3 = 0;
            num1 = 608535642;
            continue;
          case 17:
            num1 = (int) num3 * 309581226 ^ -1606355505;
            continue;
          case 18:
            flag4 = array1[index1, index2] == array2[0, 0];
            num1 = (int) num3 * -82859913 ^ 1928062548;
            continue;
          case 19:
            num1 = 54339499;
            continue;
          case 20:
            num1 = (int) num3 * -2070157712 ^ -404229028;
            continue;
          case 21:
            index4 = 0;
            num1 = (int) num3 * 1344804789 ^ -1911560801;
            continue;
          case 22:
            int num8 = flag4 ? -233853501 : (num8 = -1004618992);
            int num9 = (int) num3 * -847449249;
            num1 = num8 ^ num9;
            continue;
          case 23:
            int num10;
            num1 = num10 = index1 >= ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) fullImage) ? 1453020220 : (num10 = 132368435);
            continue;
          case 24:
            flag1 = index2 < ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) fullImage);
            num1 = 1944857292;
            continue;
          case 25:
            num1 = (int) num3 * -1969679623 ^ 612646770;
            continue;
          case 26:
            num1 = (int) num3 * -74172649 ^ 1603264871;
            continue;
          case 27:
            ++index4;
            num1 = (int) num3 * -1326335938 ^ -1811454786;
            continue;
          case 28:
            int num11 = array1[index1 + index3, index2 + index4] != array2[index3, index4] ? -110125472 : (num11 = -1497221215);
            int num12 = (int) num3 * 519522337;
            num1 = num11 ^ num12;
            continue;
          case 29:
            flag2 = true;
            num1 = (int) num3 * -96149480 ^ 781201966;
            continue;
          case 30:
            ++index3;
            num1 = (int) num3 * 1240518495 ^ -748109827;
            continue;
          case 31:
            num1 = 1115419838;
            continue;
          case 32:
            num1 = (int) num3 * 1939376466 ^ -1061706943;
            continue;
          case 33:
            int num13;
            num1 = num13 = index3 >= ImageHelper.\u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮((Image) smallImage) ? 2012752336 : (num13 = 1715759786);
            continue;
          case 34:
            index1 = 0;
            num1 = 1247874637;
            continue;
          case 35:
            num1 = (int) num3 * 1507569302 ^ -251521214;
            continue;
          case 37:
            int num14 = flag3 ? -555384859 : (num14 = -133878495);
            int num15 = (int) num3 * -1036300314;
            num1 = num14 ^ num15;
            continue;
          case 38:
            array2 = ImageHelper.ImageToArray(smallImage);
            index2 = 0;
            num1 = (int) num3 * 818149405 ^ -929041845;
            continue;
          case 39:
            num1 = 273592164;
            continue;
          case 40:
            num1 = (int) num3 * 335018085 ^ -1541638400;
            continue;
          default:
            goto label_42;
        }
      }
label_42:
      return numArray;
    }

    private static Color[,] ImageToArray(Bitmap image)
    {
      Color[,] colorArray1 = new Color[ImageHelper.\u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮((Image) image), ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) image)];
label_1:
      int num1 = 41882446;
      Color[,] colorArray2;
      while (true)
      {
        int num2 = 785687305;
        uint num3;
        int index1;
        int index2;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * 254895740 ^ 642476017;
            continue;
          case 1:
            colorArray1[index2, index1] = ImageHelper.\u200E⁮⁫‍‫⁮⁭‭‏⁮⁮‏‫⁮⁭‍‏‏‮‬⁭‎‭⁮‪⁪‏‫⁬‫⁬‎‮‌⁯‍⁪‌‮⁭‮(image, index2, index1);
            num1 = 1796473827;
            continue;
          case 2:
            index2 = 0;
            num1 = (int) num3 * -1981132001 ^ 1838607217;
            continue;
          case 3:
            int num4;
            num1 = num4 = index1 < ImageHelper.\u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮((Image) image) ? 2058430916 : (num4 = 1644270270);
            continue;
          case 4:
            ++index1;
            num1 = (int) num3 * -1083721052 ^ -1089089168;
            continue;
          case 5:
            num1 = (int) num3 * -1154460228 ^ 1744759615;
            continue;
          case 6:
            num1 = (int) num3 * 888925061 ^ 359216060;
            continue;
          case 8:
            ++index2;
            num1 = (int) num3 * 1898915500 ^ -553817288;
            continue;
          case 9:
            colorArray2 = colorArray1;
            num1 = (int) num3 * -1023267581 ^ 944458393;
            continue;
          case 10:
            index1 = 0;
            num1 = 507342637;
            continue;
          case 11:
            goto label_1;
          case 12:
            int num5;
            num1 = num5 = index2 < ImageHelper.\u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮((Image) image) ? 1531481846 : (num5 = 1889726849);
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return colorArray2;
    }

    public static ImageHelper.CompareResult Compare(Bitmap bmp1, Bitmap bmp2)
    {
label_1:
      int num1 = 728275053;
      ImageHelper.CompareResult compareResult1;
      while (true)
      {
        int num2 = 145675624;
        uint num3;
        int index;
        byte[] numArray1;
        byte[] numArray2;
        bool flag1;
        ImageHelper.CompareResult compareResult2;
        bool flag2;
        ImageConverter imageConverter;
        byte[] numArray3;
        SHA256Managed shA256Managed;
        byte[] numArray4;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 25U)
        {
          case 0:
            shA256Managed = ImageHelper.\u206C⁫‌⁪‎‪‭‪⁬⁫⁪‮‏‎⁫⁬‭⁯‮‭‍‫​⁬‮‭⁪⁪‍‮⁪‮‍⁭‌⁫‭‫‏‪‮();
            numArray2 = ImageHelper.\u206B‬‫‭‍‌‏⁯⁫‮⁯⁮‫⁬‪‏⁭⁯‭‫⁫⁮‌⁫‏⁫‍‎‭⁪⁫⁮‭‫‌⁫‎⁬‬⁫‮((HashAlgorithm) shA256Managed, numArray4);
            num1 = (int) num3 * -1583424621 ^ -1776390617;
            continue;
          case 1:
            num4 = compareResult2 == ImageHelper.CompareResult.ciCompareOk ? 1 : 0;
            goto label_15;
          case 2:
            num1 = (int) num3 * -1906531052 ^ 1304485165;
            continue;
          case 3:
            if (index < numArray1.Length)
            {
              num1 = (int) num3 * -477560418 ^ -1444185707;
              continue;
            }
            break;
          case 4:
            compareResult1 = compareResult2;
            num1 = 511977208;
            continue;
          case 5:
            compareResult2 = ImageHelper.CompareResult.ciCompareOk;
            flag2 = ImageHelper.\u206D⁮‍‎‌‌⁪⁯​‭‏⁪⁪‬‏⁬‫‪⁯⁬‭‍‌⁬⁪⁪‌⁯⁫‎⁪‪⁮‎‭‏⁬‍⁪‌‮((Image) bmp1) != ImageHelper.\u206D⁮‍‎‌‌⁪⁯​‭‏⁪⁪‬‏⁬‫‪⁯⁬‭‍‌⁬⁪⁪‌⁯⁫‎⁪‪⁮‎‭‏⁬‍⁪‌‮((Image) bmp2);
            num1 = (int) num3 * -1989962867 ^ 1325008198;
            continue;
          case 6:
            byte[] numArray5 = new byte[1];
            numArray3 = (byte[]) ImageHelper.\u200B⁮​‬⁬‍‮⁭⁫‭⁬‪‎‮‍⁭⁮⁯‪‪⁫⁯⁫‎⁪⁯‌​‫⁬⁬⁯‌⁫‍⁫‪⁬⁯⁭‮((TypeConverter) imageConverter, (object) bmp2, ImageHelper.\u202A‏⁫⁭‎⁮⁬‮⁮⁮‫‭‮⁭⁫⁫⁪‭‪⁭⁭‫‪‌‌​⁬​‬⁭‎‏‍⁬⁬‫⁫​‫‍‮((object) numArray5));
            num1 = (int) num3 * 1036469643 ^ -260510816;
            continue;
          case 7:
            index = 0;
            num1 = (int) num3 * -2111641727 ^ -1014471188;
            continue;
          case 8:
            compareResult2 = ImageHelper.CompareResult.ciSizeMismatch;
            num1 = (int) num3 * 22288112 ^ -1735725408;
            continue;
          case 9:
            ++index;
            num1 = 111796377;
            continue;
          case 10:
            if (index < numArray2.Length)
            {
              num1 = 535213035;
              continue;
            }
            break;
          case 11:
            int num5 = !flag1 ? 840573320 : (num5 = 1534783948);
            int num6 = (int) num3 * 1558842761;
            num1 = num5 ^ num6;
            continue;
          case 12:
            num1 = (int) num3 * -497932650 ^ 1361447357;
            continue;
          case 13:
            num1 = 1740543208;
            continue;
          case 14:
            num1 = 1232745742;
            continue;
          case 15:
            byte[] numArray6 = new byte[1];
            numArray4 = (byte[]) ImageHelper.\u200B⁮​‬⁬‍‮⁭⁫‭⁬‪‎‮‍⁭⁮⁯‪‪⁫⁯⁫‎⁪⁯‌​‫⁬⁬⁯‌⁫‍⁫‪⁬⁯⁭‮((TypeConverter) imageConverter, (object) bmp1, ImageHelper.\u202A‏⁫⁭‎⁮⁬‮⁮⁮‫‭‮⁭⁫⁫⁪‭‪⁭⁭‫‪‌‌​⁬​‬⁭‎‏‍⁬⁬‫⁫​‫‍‮((object) numArray6));
            num1 = (int) num3 * -1033812645 ^ -1330925449;
            continue;
          case 16:
            num1 = (int) num3 * 1945710281 ^ -211696770;
            continue;
          case 17:
            goto label_1;
          case 18:
            flag1 = (int) numArray2[index] != (int) numArray1[index];
            num1 = (int) num3 * 874475279 ^ 672100689;
            continue;
          case 19:
            int num7 = !flag2 ? -2087037044 : (num7 = -1743893074);
            int num8 = (int) num3 * -96843562;
            num1 = num7 ^ num8;
            continue;
          case 20:
            imageConverter = ImageHelper.\u202A‏‌⁮‮⁭‭⁬‭⁯‬⁯‫‪‮‭⁫‌⁫‫⁮‎‬⁬⁫‮⁫‮⁮⁯⁯​⁭‌​⁯‎​‏‪‮();
            num1 = (int) num3 * -274247173 ^ 1307369107;
            continue;
          case 21:
            numArray1 = ImageHelper.\u206B‬‫‭‍‌‏⁯⁫‮⁯⁮‫⁬‪‏⁭⁯‭‫⁫⁮‌⁫‏⁫‍‎‭⁪⁫⁮‭‫‌⁫‎⁬‬⁫‮((HashAlgorithm) shA256Managed, numArray3);
            num1 = (int) num3 * 786795838 ^ -1484691069;
            continue;
          case 22:
            compareResult2 = ImageHelper.CompareResult.ciPixelMismatch;
            num1 = (int) num3 * -979631724 ^ 474253759;
            continue;
          case 23:
            num1 = (int) num3 * 229794769 ^ 662330325;
            continue;
          default:
            goto label_30;
        }
        num4 = 0;
label_15:
        int num9;
        num1 = num9 = num4 != 0 ? 638308934 : (num9 = 926209608);
      }
label_30:
      return compareResult1;
    }

    static int \u200C⁯‪‭‎⁫‍‪‎⁪⁬‪‭⁬⁮‏‬‭‪‎⁮‬‌‪⁬⁪‫⁯‬⁬‬‮​⁮‌‫⁮‬‫⁮‮([In] BitmapSource obj0)
    {
      return obj0.PixelWidth;
    }

    static int \u200C‮‭⁯⁫​⁭‬⁯⁫⁮‭⁭⁮‫⁪⁬‎‪⁬⁯‌⁫​‬⁬⁬⁫⁭‌‏⁭⁮​‫⁭⁮‍‪‪‮([In] BitmapSource obj0)
    {
      return obj0.PixelHeight;
    }

    static Bitmap \u200F‭‎‍‏‏‫⁫⁪‫⁯‬​⁮​​⁮⁬‪‬‬⁬​‭‫‎‫‍⁫⁪⁫⁭⁫‏‎‏‍‎⁪‮‮([In] int obj0, [In] int obj1, [In] PixelFormat obj2)
    {
      return new Bitmap(obj0, obj1, obj2);
    }

    static System.Drawing.Size \u206D⁮‍‎‌‌⁪⁯​‭‏⁪⁪‬‏⁬‫‪⁯⁬‭‍‌⁬⁪⁪‌⁯⁫‎⁪‪⁮‎‭‏⁬‍⁪‌‮([In] Image obj0)
    {
      return obj0.Size;
    }

    static NotImplementedException \u206F⁯⁭‮‮⁯‪⁮‍‎⁮⁯⁪⁬‌‬‬‬‬‭‏‪​‎‭⁪‪‍‫​⁯‬⁭‭⁯‮⁬‬⁯‏‮()
    {
      return new NotImplementedException();
    }

    static Color \u200E⁮⁫‍‫⁮⁭‭‏⁮⁮‏‫⁮⁭‍‏‏‮‬⁭‎‭⁮‪⁪‏‫⁬‫⁬‎‮‌⁯‍⁪‌‮⁭‮([In] Bitmap obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.GetPixel(obj1, obj2);
    }

    static int \u200B⁯‌⁪‫‮‌‪⁭⁪⁬‭⁯‎⁯‬‌⁮‎⁭​‎‭‪‍⁫‎‫‮⁬⁭⁪⁪‭‌‭‍⁮‪‎‮([In] Image obj0)
    {
      return obj0.Height;
    }

    static int \u206B⁬⁮⁪⁭‏⁬‍‏‍⁫‬‍​‭‮⁮⁪‫⁬‎‪​‭‮‌‭‌⁫‌​‮‎⁮⁭‏⁭⁪⁫‎‮([In] Image obj0)
    {
      return obj0.Width;
    }

    static void \u206E⁭⁫⁪‪‍‬⁫‏⁬⁪‫‏‭⁭⁪⁭‌⁬‭‪⁬‎‭⁪‍‭⁮⁫‭⁭⁮‏⁫‪‮‏‮‍‎‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static void \u206F‍‮‫‪‏⁫⁯‎⁮‌‎‍‮‭‫‪‍‪‫‍‮⁯⁭‫‍‭‭‫⁫⁫​⁫⁫‮⁬‌⁭‍‍‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u200F‏‬‌‫‮‪‮‬‪⁭‫⁪‌‪⁯‎‭​⁯​‪‮⁫⁬‭‏‎‮⁯⁫‪‬‪⁫‭‎‫‮‮([In] object obj0)
    {
      Clipboard.SetDataObject(obj0);
    }

    static BitmapSizeOptions \u200F​⁮⁮‭​‫⁫⁫⁬⁪⁫‭⁬‏⁭⁬⁪‬⁭⁯​⁪​⁪‎​‫⁬‮‍‬​‮‬‮‬‏‏⁪‮()
    {
      return BitmapSizeOptions.FromEmptyOptions();
    }

    static BitmapSource \u202B‮⁫‬⁯⁮‭‎​‪⁮‌⁫⁯⁭⁮⁮‎⁬⁮‌‎‪⁪⁫‫⁫‎‪‬⁬‍‭​⁫‍⁫​⁭⁫‮([In] IntPtr obj0, [In] IntPtr obj1, [In] Int32Rect obj2, [In] BitmapSizeOptions obj3)
    {
      return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(obj0, obj1, obj2, obj3);
    }

    static void \u200F‮⁫‪‪⁭‭‭⁬‏‌‫‌⁮⁯​⁭‌⁬⁬‎‬‌‌⁭‌‫‪‪‬‏‏⁫‫‌⁬​‮⁫⁯‮([In] BitmapSource obj0)
    {
      Clipboard.SetImage(obj0);
    }

    static void \u206E​‏‪‍‏⁯‪​‬‎‫⁮‏‬‏⁫‭‏​‎‍​‏⁬‬⁫‮⁯‭⁭⁬⁮‫‫‮⁮​⁯‮‮([In] Freezable obj0)
    {
      obj0.Freeze();
    }

    static bool \u202B⁫‭‍‌‮‌​⁪‏‮⁯‭‌‮⁯‏‫‬⁫‬⁪‏‭‭‪⁮⁫‪‫‎⁯⁬‫‮‪‮⁪⁪‏‮([In] object obj0, [In] object obj1)
    {
      return object.Equals(obj0, obj1);
    }

    static PixelFormat \u206D⁭‏⁬‮‏⁯⁭‍⁬‍⁯‏‫‬‮⁬‪⁫‏‏‫‌‎‬⁮‪‪‍‎‌‫‪‫‫‍‍‌⁪‫‮([In] Image obj0)
    {
      return obj0.PixelFormat;
    }

    static int \u206A⁯‍‍‭‭⁪⁮‎‏⁬‬​‬⁯⁭‮⁬⁭⁫‎‫‌‪‎‬⁫⁫‫⁬‫‏⁬‎‎‍⁫⁬‪⁭‮([In] PixelFormat obj0)
    {
      return Image.GetPixelFormatSize(obj0);
    }

    static ImageConverter \u202A‏‌⁮‮⁭‭⁬‭⁯‬⁯‫‪‮‭⁫‌⁫‫⁮‎‬⁬⁫‮⁫‮⁮⁯⁯​⁭‌​⁯‎​‏‪‮()
    {
      return new ImageConverter();
    }

    static Type \u202A‏⁫⁭‎⁮⁬‮⁮⁮‫‭‮⁭⁫⁫⁪‭‪⁭⁭‫‪‌‌​⁬​‬⁭‎‏‍⁬⁬‫⁫​‫‍‮([In] object obj0)
    {
      return obj0.GetType();
    }

    static object \u200B⁮​‬⁬‍‮⁭⁫‭⁬‪‎‮‍⁭⁮⁯‪‪⁫⁯⁫‎⁪⁯‌​‫⁬⁬⁯‌⁫‍⁫‪⁬⁯⁭‮([In] TypeConverter obj0, [In] object obj1, [In] Type obj2)
    {
      return obj0.ConvertTo(obj1, obj2);
    }

    static SHA256Managed \u206C⁫‌⁪‎‪‭‪⁬⁫⁪‮‏‎⁫⁬‭⁯‮‭‍‫​⁬‮‭⁪⁪‍‮⁪‮‍⁭‌⁫‭‫‏‪‮()
    {
      return new SHA256Managed();
    }

    static byte[] \u206B‬‫‭‍‌‏⁯⁫‮⁯⁮‫⁬‪‏⁭⁯‭‫⁫⁮‌⁫‏⁫‍‎‭⁪⁫⁮‭‫‌⁫‎⁬‬⁫‮([In] HashAlgorithm obj0, [In] byte[] obj1)
    {
      return obj0.ComputeHash(obj1);
    }

    static MethodBase \u202D⁯⁭‮‬‭⁮‪⁫‏‎⁯⁬‪‭‎⁮‬‍‮⁭⁬⁭‎‬⁮‏‎‍⁭⁯‌⁬‏‏‭⁮‌‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206D‌‌​⁭​⁬‎‏‎⁮‍‌‪‎‭‍‍‍⁯​‎⁯‪‪‏⁬​⁪⁫⁮‫‌‭‭​‭‭‏‬‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202B‮‮‫⁯‏⁯⁮​⁭​⁬⁫​⁪‎‬⁪​⁫‍⁭‮⁭‬⁮​‪‪​‏​⁬⁬⁪⁭‮‪‍‌‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    public enum CompareResult
    {
      ciCompareOk,
      ciPixelMismatch,
      ciSizeMismatch,
    }
  }
}
