// Decompiled with JetBrains decompiler
// Type: flaphx.utils.ImageHelper
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

namespace flaphx.utils
{
  public static class ImageHelper
  {
    public static readonly ILog log = ImageHelper.\u202D⁪‬‫⁯​​⁫‪⁬‎⁬⁮‌‮⁫​‪⁫‏⁯‭⁬‪⁮⁯‍‏⁯​⁮⁬‮⁭⁫‪‬‮⁭‏‮(ImageHelper.\u206D‬‭⁯‍‍‎‏⁭⁮‌⁬‮⁪‏‬⁪‭⁫‍‏‬‫‍⁪⁪⁯‪‏‬‫‫⁯‌‭⁯‭‍‎⁬‮((MemberInfo) ImageHelper.\u200F​‪⁯‪⁮‎⁮‎‭‏‍⁬‌‭⁬​‏⁫⁮⁮⁬‍‏⁭‎⁮‭⁬‮⁭‌‬‌​⁪‬‌‭⁪‮()));

    internal static bool ContainsImage(object bitmap, Bitmap exemplar)
    {
      throw ImageHelper.\u206E‏‏‏‎‪​‏‏‫‏‬‫‭‭⁭‍⁪⁭‎‪‮⁯‎⁫‎⁮‌‬⁬⁯‫‫‭‍⁭‍‫⁭‪‮();
    }

    public static bool AllOneColor(Bitmap bitmapSource)
    {
      bool flag1 = true;
      bool flag2;
      try
      {
label_2:
        int num1 = 2051857529;
        while (true)
        {
          int num2 = 662221761;
          uint num3;
          Color color1;
          Color color2;
          bool flag3;
          int num4;
          bool flag4;
          int num5;
          bool flag5;
          switch ((num3 = (uint) (num1 ^ num2)) % 25U)
          {
            case 0:
              num1 = 511653113;
              continue;
            case 1:
              num1 = 2141152080;
              continue;
            case 2:
              flag3 = !color1.Equals((object) color2);
              num1 = (int) num3 * -1644510248 ^ -212109767;
              continue;
            case 3:
              int num6 = !flag3 ? 1164567092 : (num6 = 1301451399);
              int num7 = (int) num3 * 768052162;
              num1 = num6 ^ num7;
              continue;
            case 4:
              flag1 = false;
              num1 = (int) num3 * -615934081 ^ 1909748781;
              continue;
            case 5:
              ++num5;
              num1 = (int) num3 * -1884465216 ^ -761471960;
              continue;
            case 6:
              ++num4;
              num1 = 1877393749;
              continue;
            case 7:
              num1 = (int) num3 * 1675499167 ^ -695237907;
              continue;
            case 8:
              num1 = (int) num3 * -473871066 ^ -1185560479;
              continue;
            case 9:
              num1 = 1375852945;
              continue;
            case 10:
              color2 = ImageHelper.\u202A‍​‌⁪‎‏⁪‬⁮⁭‫⁬‍⁭⁫⁭‪⁫⁫⁪‫‫⁪‌⁮‫⁪‎‍‍‏⁮‮⁫​‭‬⁭⁪‮(bitmapSource, 0, 0);
              num1 = (int) num3 * 528550683 ^ -1676389834;
              continue;
            case 12:
              int num8 = !flag4 ? 1697295056 : (num8 = 318676017);
              int num9 = (int) num3 * 1189349217;
              num1 = num8 ^ num9;
              continue;
            case 13:
              goto label_2;
            case 14:
              num5 = 0;
              num1 = (int) num3 * 223601590 ^ 1849180624;
              continue;
            case 15:
              int num10 = !flag1 ? -1843749560 : (num10 = -541039330);
              int num11 = (int) num3 * 321830461;
              num1 = num10 ^ num11;
              continue;
            case 16:
              int num12 = !flag5 ? 640383379 : (num12 = 649980629);
              int num13 = (int) num3 * 446550858;
              num1 = num12 ^ num13;
              continue;
            case 17:
              color1 = ImageHelper.\u202A‍​‌⁪‎‏⁪‬⁮⁭‫⁬‍⁭⁫⁭‪⁫⁫⁪‫‫⁪‌⁮‫⁪‎‍‍‏⁮‮⁫​‭‬⁭⁪‮(bitmapSource, num5, num4);
              num1 = (int) num3 * 1376947877 ^ -1406259489;
              continue;
            case 18:
              num1 = (int) num3 * -1570078025 ^ -1082545289;
              continue;
            case 19:
              num4 = 0;
              num1 = (int) num3 * 836631986 ^ -2142235952;
              continue;
            case 20:
              goto label_35;
            case 21:
              num1 = (int) num3 * 74823927 ^ 490830226;
              continue;
            case 22:
              flag4 = num4 < ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) bitmapSource);
              num1 = 1570255129;
              continue;
            case 23:
              flag2 = false;
              num1 = (int) num3 * -679420753 ^ -1320010601;
              continue;
            case 24:
              flag5 = num5 < ImageHelper.\u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮((Image) bitmapSource);
              num1 = 2058968248;
              continue;
            default:
              goto label_31;
          }
        }
      }
      catch (Exception ex)
      {
        ImageHelper.\u206D‍⁬⁮⁬‮⁯⁫‍‮‫⁬⁭⁯‮‎‏⁮‍‍‌⁮‫⁭‫‭⁬⁫⁫‬⁬‍⁬‪⁬⁭‭⁮⁯⁯‮(ImageHelper.log, (object) ex);
label_27:
        int num1 = 745909335;
        while (true)
        {
          int num2 = 662221761;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_27;
            case 1:
              num1 = (int) num3 * -1184287590 ^ -436725318;
              continue;
            default:
              goto label_30;
          }
        }
label_30:
        throw;
      }
label_31:
      flag2 = flag1;
label_32:
      int num14 = 1657786601;
      while (true)
      {
        int num1 = 662221761;
        uint num2;
        switch ((num2 = (uint) (num14 ^ num1)) % 3U)
        {
          case 1:
            num14 = (int) num2 * -2108942612 ^ -1485294827;
            continue;
          case 2:
            goto label_32;
          default:
            goto label_35;
        }
      }
label_35:
      return flag2;
    }

    internal static BitmapSource CaptureRegion(IntPtr hWnd, int x, int y, int width, int height, bool addToClipboard)
    {
      IntPtr num1 = IntPtr.Zero;
      IntPtr num2 = IntPtr.Zero;
      IntPtr num3 = IntPtr.Zero;
      BitmapSource bitmapSource = (BitmapSource) null;
      try
      {
label_2:
        int num4 = 307890089;
        while (true)
        {
          int num5 = 555739636;
          uint num6;
          bool flag;
          switch ((num6 = (uint) (num4 ^ num5)) % 12U)
          {
            case 0:
              bitmapSource = ImageHelper.\u200C​⁬⁭‏⁫⁫‫​‬‏‪⁫‌⁭⁮⁪‫‮‏‎⁬‫‍⁯‭‌‌⁪⁬​‭‪‭​‬‌⁭‪⁮‮(num3, IntPtr.Zero, Int32Rect.Empty, ImageHelper.\u206B⁪⁫⁭⁫‌‌‍⁫‏​‍‍‎​‍⁯⁪⁭⁬‮‬⁭‪‭‍​‮⁬⁯‏⁬‪‌​‎⁬‌‫‌‮());
              num4 = (int) num6 * 1173549106 ^ -1518910574;
              continue;
            case 1:
              num1 = User32.GetDC(User32.GetDesktopWindow());
              num2 = Gdi32.CreateCompatibleDC(num1);
              num4 = (int) num6 * -1425708156 ^ 157881235;
              continue;
            case 2:
              flag = addToClipboard;
              num4 = (int) num6 * -1961562905 ^ 437927322;
              continue;
            case 3:
              goto label_2;
            case 4:
              num4 = (int) num6 * 557444368 ^ -1244318399;
              continue;
            case 5:
              num4 = (int) num6 * -271493397 ^ -707874596;
              continue;
            case 6:
              Gdi32.SelectObject(num2, num3);
              Gdi32.BitBlt(num2, 0, 0, width, height, num1, x, y, 13369376);
              num4 = (int) num6 * -1158265065 ^ 1132831762;
              continue;
            case 8:
              int num7 = flag ? -1483087306 : (num7 = -458550207);
              int num8 = (int) num6 * 150779968;
              num4 = num7 ^ num8;
              continue;
            case 9:
              ImageHelper.\u202B‏‌⁫‏‮‮‫‍⁫‬⁯‮‌​⁭‫‏⁬‬⁫‫‎⁭‌​‍‬‪​‬‫⁪‫‪⁮‍⁮⁭⁬‮((Freezable) bitmapSource);
              num4 = 1805420021;
              continue;
            case 10:
              ImageHelper.\u206B‍‪‭‮‌‮‬‏‍⁮⁮⁮⁬‭‮⁫​‪‮⁮‫‫‫‌⁭‬‫‭⁭‭⁬‎⁪⁯‍‪⁯‏⁭‮(bitmapSource);
              num4 = (int) num6 * 989166261 ^ -1387149538;
              continue;
            case 11:
              num3 = Gdi32.CreateCompatibleBitmap(num1, width, height);
              num4 = (int) num6 * -572644632 ^ -701815170;
              continue;
            default:
              goto label_24;
          }
        }
      }
      catch (Exception ex)
      {
label_15:
        int num4 = 1260667445;
        while (true)
        {
          int num5 = 555739636;
          uint num6;
          switch ((num6 = (uint) (num4 ^ num5)) % 3U)
          {
            case 1:
              ImageHelper.\u206D‍⁬⁮⁬‮⁯⁫‍‮‫⁬⁭⁯‮‎‏⁮‍‍‌⁮‫⁭‫‭⁬⁫⁫‬⁬‍⁬‪⁬⁭‭⁮⁯⁯‮(ImageHelper.log, (object) ex);
              num4 = (int) num6 * -166143421 ^ 1863144587;
              continue;
            case 2:
              goto label_15;
            default:
              goto label_18;
          }
        }
label_18:
        throw ImageHelper.\u206F‬​‪⁪‭⁪‪⁭‌​‎‌‏‮‪‫⁮‌​‎⁮⁬⁫⁫‭‎‬‍​​‪‍‬⁬‪‌‌⁫⁪‮(ImageHelper.\u202E⁯⁪⁭‍‬‪‎⁫‌​‪‍⁬‏⁯⁬​‭​⁭‎‭‌‮‪⁮‌‏‮⁯‮‎‌⁭⁪⁪⁯‭⁬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4274567604U), new object[5]
        {
          (object) x,
          (object) y,
          (object) width,
          (object) height,
          (object) ImageHelper.\u206D‌​⁮‌⁮‎‎‮‪⁪‍⁯⁫‍⁮‭​⁬‭‭⁬⁪⁬⁪‮⁯‏⁮‏‫‎​⁮‍⁪‮‪⁫‍‮(ex)
        }), ex);
      }
      finally
      {
        Gdi32.DeleteObject(num3);
label_20:
        int num4 = 1341207548;
        while (true)
        {
          int num5 = 555739636;
          uint num6;
          switch ((num6 = (uint) (num4 ^ num5)) % 3U)
          {
            case 0:
              goto label_20;
            case 1:
              User32.ReleaseDC(IntPtr.Zero, num1);
              num4 = (int) num6 * 789885708 ^ -1267151856;
              continue;
            default:
              goto label_23;
          }
        }
label_23:
        User32.ReleaseDC(IntPtr.Zero, num2);
      }
label_24:
      return bitmapSource;
    }

    internal static bool ContainsImage(Bitmap source, Bitmap whatToFind)
    {
      bool flag = (uint) ImageHelper.searchBitmap(whatToFind, source, 0.1).Width > 0U;
label_1:
      int num1 = 2138383012;
      while (true)
      {
        int num2 = 139813410;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1299574171 ^ 935542646;
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
label_1:
      int num1 = -928796335;
      Rectangle rectangle;
      while (true)
      {
        int num2 = -1706743245;
        uint num3;
        bool flag1;
        bool flag2;
        Rectangle empty;
        int int32;
        byte* numPtr1;
        int num4;
        bool flag3;
        int num5;
        int num6;
        bool flag4;
        BitmapData bitmapdata1;
        int width;
        bool flag5;
        int stride1;
        int stride2;
        int num7;
        int num8;
        byte* numPtr2;
        byte* numPtr3;
        byte* numPtr4;
        int num9;
        int num10;
        int height;
        bool flag6;
        int num11;
        int num12;
        BitmapData bitmapdata2;
        int num13;
        switch ((num3 = (uint) (num1 ^ num2)) % 64U)
        {
          case 0:
            int num14;
            num1 = num14 = num6 >= num12 ? -177150019 : (num14 = -1489739308);
            continue;
          case 2:
            numPtr3 = numPtr4;
            num1 = -1262065916;
            continue;
          case 3:
            byte* numPtr5 = numPtr2;
            numPtr3 = numPtr4;
            numPtr1 = numPtr5 + 3;
            num1 = (int) num3 * -946154064 ^ 198310046;
            continue;
          case 4:
            flag2 = num8 < num10;
            num1 = -226771121;
            continue;
          case 5:
            num12 = bigBmp.Height - smallBmp.Height + 1;
            num1 = (int) num3 * -688642287 ^ 574565320;
            continue;
          case 6:
            int num15;
            num1 = num15 = !flag1 ? -1560929868 : (num15 = -1822622031);
            continue;
          case 7:
            num1 = (int) num3 * -17540617 ^ -1636044767;
            continue;
          case 8:
            flag5 = num5 < width;
            num1 = -800235133;
            continue;
          case 9:
            flag1 = true;
            num1 = (int) num3 * -109141435 ^ -835237693;
            continue;
          case 10:
            numPtr3 += stride1 * (1 + num9);
            num1 = (int) num3 * 883400095 ^ -1525011192;
            continue;
          case 11:
            bigBmp.UnlockBits(bitmapdata2);
            smallBmp.UnlockBits(bitmapdata1);
            num1 = (int) num3 * -1032411873 ^ 175113503;
            continue;
          case 12:
            num1 = (int) num3 * -183663079 ^ -1689735463;
            continue;
          case 13:
            numPtr1 += stride2 * (1 + num9);
            ++num9;
            num1 = (int) num3 * 262104318 ^ -332818945;
            continue;
          case 14:
            num1 = -260012104;
            continue;
          case 15:
            goto label_1;
          case 16:
            int32 = Convert.ToInt32((double) byte.MaxValue * tolerance);
            num1 = (int) num3 * 160891442 ^ -1729160468;
            continue;
          case 17:
            rectangle = empty;
            num1 = (int) num3 * -2025818208 ^ 1417714642;
            continue;
          case 18:
            int num16 = flag3 ? -1608227812 : (num16 = -1512029616);
            int num17 = (int) num3 * 1340153834;
            num1 = num16 ^ num17;
            continue;
          case 19:
            flag4 = flag1;
            num1 = -421107219;
            continue;
          case 20:
            int num18 = !flag6 ? -149258252 : (num18 = -1026188455);
            int num19 = (int) num3 * 260467121;
            num1 = num18 ^ num19;
            continue;
          case 21:
            flag1 = false;
            num1 = (int) num3 * -2133118146 ^ -218532759;
            continue;
          case 22:
            num11 = (int) *numPtr1 - int32;
            num1 = (int) num3 * 1336286639 ^ 553321292;
            continue;
          case 23:
            ++numPtr1;
            num1 = -987965433;
            continue;
          case 24:
            if (num4 < (int) *numPtr3)
            {
              num13 = 1;
              break;
            }
            num1 = (int) num3 * -400887264 ^ -913420347;
            continue;
          case 25:
            numPtr1 += num7;
            num1 = -861296678;
            continue;
          case 26:
            num1 = -1868575131;
            continue;
          case 27:
            num1 = (int) num3 * 825396184 ^ -1509122706;
            continue;
          case 28:
            empty.Height = smallBmp.Height;
            num1 = (int) num3 * -1424930874 ^ 905787553;
            continue;
          case 29:
            num6 = 0;
            num1 = (int) num3 * -1906511405 ^ -1864707308;
            continue;
          case 30:
            int num20 = flag4 ? -1778866524 : (num20 = -776761614);
            int num21 = (int) num3 * 1565711690;
            num1 = num20 ^ num21;
            continue;
          case 31:
            stride2 = bitmapdata2.Stride;
            width = bigBmp.Width;
            num1 = (int) num3 * 1342289893 ^ -1613402867;
            continue;
          case 32:
            ++num5;
            num1 = (int) num3 * -54659699 ^ 431352795;
            continue;
          case 33:
            ++num8;
            num1 = (int) num3 * 1042520878 ^ 2006370521;
            continue;
          case 34:
            bitmapdata1 = smallBmp.LockBits(new Rectangle(0, 0, ImageHelper.\u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮((Image) smallBmp), ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) smallBmp)), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            num1 = (int) num3 * 276667457 ^ 231038010;
            continue;
          case 35:
            empty = Rectangle.Empty;
            num1 = (int) num3 * 231911258 ^ 1108839085;
            continue;
          case 36:
            int num22;
            num1 = num22 = !flag1 ? -412244374 : (num22 = -1996666789);
            continue;
          case 37:
            int num23 = stride1 - smallBmp.Width * 3;
            num7 = stride2 - bigBmp.Width * 3;
            num1 = (int) num3 * -91137561 ^ 1651120153;
            continue;
          case 38:
            num1 = (int) num3 * -947852002 ^ 1328977763;
            continue;
          case 39:
            num5 = 0;
            num1 = -1438328958;
            continue;
          case 40:
            num1 = (int) num3 * 904437960 ^ 1723664125;
            continue;
          case 41:
            ++num6;
            num1 = (int) num3 * 1962177651 ^ -1103750888;
            continue;
          case 42:
            flag6 = num9 < height;
            num1 = -781665817;
            continue;
          case 43:
            bitmapdata2 = bigBmp.LockBits(new Rectangle(0, 0, bigBmp.Width, bigBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            stride1 = bitmapdata1.Stride;
            num1 = (int) num3 * 901850489 ^ 1679575167;
            continue;
          case 44:
            num1 = (int) num3 * -1823264404 ^ 1509686659;
            continue;
          case 45:
            num1 = -593792208;
            continue;
          case 46:
            num10 = smallBmp.Width * 3;
            height = smallBmp.Height;
            num1 = (int) num3 * 85154309 ^ 591198454;
            continue;
          case 47:
            num8 = 0;
            num1 = (int) num3 * 313845833 ^ -235316400;
            continue;
          case 48:
            int num24 = flag5 ? 1090703851 : (num24 = 515174199);
            int num25 = (int) num3 * 1382634958;
            num1 = num24 ^ num25;
            continue;
          case 49:
            num1 = (int) num3 * -456799228 ^ -677906241;
            continue;
          case 50:
            numPtr1 = (byte*) (void*) bitmapdata2.Scan0;
            num1 = (int) num3 * -277768896 ^ 945493910;
            continue;
          case 51:
            empty.Width = smallBmp.Width;
            num1 = (int) num3 * 1295632924 ^ 952942395;
            continue;
          case 52:
            ++numPtr3;
            num1 = (int) num3 * 661271231 ^ 1142337118;
            continue;
          case 53:
            num4 = (int) *numPtr1 + int32;
            num1 = (int) num3 * 1303855557 ^ -803899870;
            continue;
          case 54:
            num13 = num11 > (int) *numPtr3 ? 1 : 0;
            break;
          case 55:
            numPtr1 = numPtr2;
            num1 = (int) num3 * -121710454 ^ -897109217;
            continue;
          case 56:
            numPtr2 = numPtr1;
            numPtr4 = numPtr3;
            num9 = 0;
            num1 = -290785767;
            continue;
          case 57:
            num1 = (int) num3 * -827849091 ^ -1619651209;
            continue;
          case 58:
            num1 = (int) num3 * -997759308 ^ 89410461;
            continue;
          case 59:
            empty.X = num5;
            empty.Y = num6;
            num1 = (int) num3 * -153301770 ^ 727946738;
            continue;
          case 60:
            int num26 = flag2 ? -132498207 : (num26 = -1874692291);
            int num27 = (int) num3 * -23240994;
            num1 = num26 ^ num27;
            continue;
          case 61:
            num1 = (int) num3 * -799863191 ^ 1102252634;
            continue;
          case 62:
            num8 = 0;
            flag1 = true;
            num1 = -884343524;
            continue;
          case 63:
            numPtr3 = (byte*) (void*) bitmapdata1.Scan0;
            num1 = (int) num3 * -1701012677 ^ -405973372;
            continue;
          default:
            goto label_68;
        }
        flag3 = num13 != 0;
        num1 = -383776031;
      }
label_68:
      return rectangle;
    }

    internal static bool CompareBitmaps(Image left, Image right)
    {
label_1:
      int num1 = 685569801;
      bool flag1;
      while (true)
      {
        int num2 = 745461758;
        uint num3;
        int index;
        int length;
        bool flag2;
        bool flag3;
        Bitmap bitmap1;
        Bitmap bitmap2;
        byte[] destination1;
        byte[] destination2;
        BitmapData bitmapdata1;
        bool flag4;
        PixelFormat pixelFormat;
        bool flag5;
        BitmapData bitmapdata2;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 36U)
        {
          case 0:
            bitmap2.UnlockBits(bitmapdata2);
            flag1 = flag3;
            num1 = (int) num3 * -732357951 ^ -1334637805;
            continue;
          case 1:
            num1 = (int) num3 * 1769383451 ^ -810276508;
            continue;
          case 2:
            num4 = right == null ? 1 : 0;
            break;
          case 3:
            num1 = (int) num3 * 1292920194 ^ -1373319727;
            continue;
          case 4:
            num5 = bitmap2 == null ? 1 : 0;
            goto label_21;
          case 5:
            pixelFormat = ImageHelper.\u202A‫‭​⁫‫‭⁪‌⁯‍‎‪⁮‏⁯⁮⁯‮⁮‪⁪‬‪‎‎‮⁭‌‍‪‭‏⁮‬‫‬⁯‫‮‮(left);
            num1 = (int) num3 * 307875098 ^ -439327292;
            continue;
          case 6:
            flag1 = false;
            num1 = (int) num3 * -879162913 ^ -976065781;
            continue;
          case 7:
            index = 0;
            num1 = (int) num3 * 1804040895 ^ -1990541712;
            continue;
          case 8:
            flag3 = false;
            num1 = (int) num3 * 711207447 ^ -161513659;
            continue;
          case 9:
            num1 = 1499615595;
            continue;
          case 10:
            int num7 = !flag2 ? 1772584210 : (num7 = 1832044765);
            int num8 = (int) num3 * 1801000751;
            num1 = num7 ^ num8;
            continue;
          case 11:
            destination1 = new byte[length];
            destination2 = new byte[length];
            bitmapdata1 = bitmap1.LockBits(new Rectangle(0, 0, ImageHelper.\u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮((Image) bitmap1) - 1, ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) bitmap1) - 1), ImageLockMode.ReadOnly, bitmap1.PixelFormat);
            num1 = (int) num3 * 1166622603 ^ -1290851787;
            continue;
          case 12:
            flag3 = true;
            num1 = (int) num3 * 474678852 ^ -627354323;
            continue;
          case 13:
            flag4 = (int) destination1[index] != (int) destination2[index];
            num1 = (int) num3 * -1265677726 ^ 1364694222;
            continue;
          case 14:
            bitmapdata2 = bitmap2.LockBits(new Rectangle(0, 0, bitmap2.Width - 1, bitmap2.Height - 1), ImageLockMode.ReadOnly, bitmap2.PixelFormat);
            num1 = (int) num3 * -1643498851 ^ -844113680;
            continue;
          case 15:
            flag2 = index <= length - 1;
            num1 = 990514264;
            continue;
          case 16:
            num6 = !pixelFormat.Equals((object) ImageHelper.\u202A‫‭​⁫‫‭⁪‌⁯‍‎‪⁮‏⁯⁮⁯‮⁮‪⁪‬‪‎‎‮⁭‌‍‪‭‏⁮‬‫‬⁯‫‮‮(right)) ? 1 : 0;
            goto label_33;
          case 17:
            bitmap1 = left as Bitmap;
            bitmap2 = right as Bitmap;
            if (bitmap1 != null)
            {
              num1 = 1045778070;
              continue;
            }
            num5 = 1;
            goto label_21;
          case 18:
            bitmap1.UnlockBits(bitmapdata1);
            num1 = 510602115;
            continue;
          case 19:
            ++index;
            num1 = (int) num3 * 835503 ^ 969711148;
            continue;
          case 20:
            Marshal.Copy(bitmapdata1.Scan0, destination1, 0, length);
            num1 = (int) num3 * -1169704459 ^ 1355535604;
            continue;
          case 21:
            int num9 = flag5 ? 77976168 : (num9 = 1791026361);
            int num10 = (int) num3 * -1447376166;
            num1 = num9 ^ num10;
            continue;
          case 22:
            int num11 = !flag4 ? -407985494 : (num11 = -1314311426);
            int num12 = (int) num3 * 1151642848;
            num1 = num11 ^ num12;
            continue;
          case 23:
            int num13 = ImageHelper.\u202C‭⁫‌‌‬⁫‬‌‪⁪‎‫⁫⁬⁭⁬‌‭‏⁪‏‎⁪⁭‏‬⁫‎‭⁪⁬‎⁭​‮⁫‬‏‮‮((object) left, (object) right) ? 681974604 : (num13 = 244491146);
            int num14 = (int) num3 * -128836619;
            num1 = num13 ^ num14;
            continue;
          case 24:
            flag1 = false;
            num1 = (int) num3 * 2068714928 ^ -482747481;
            continue;
          case 25:
            flag1 = true;
            num1 = (int) num3 * 2008453315 ^ -1287793068;
            continue;
          case 26:
            Marshal.Copy(bitmapdata2.Scan0, destination2, 0, length);
            num1 = (int) num3 * -51350575 ^ 1268529115;
            continue;
          case 27:
            if (left != null)
            {
              num1 = 1266761080;
              continue;
            }
            num4 = 1;
            break;
          case 28:
            num1 = 942153969;
            continue;
          case 29:
            num1 = (int) num3 * -5147765 ^ 1844692469;
            continue;
          case 30:
            goto label_1;
          case 31:
            num1 = (int) num3 * 1096302132 ^ 532685972;
            continue;
          case 32:
            flag1 = true;
            num1 = (int) num3 * -1703673981 ^ -304369101;
            continue;
          case 34:
            length = ImageHelper.\u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮(left) * ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮(left) * (ImageHelper.\u202E⁪⁯‎‫‏‍‮​‍‪⁫‫‎⁬‮‮‌‭‭‬⁯‭⁪‪‮⁮​‬‮⁯​‫‭⁭‬⁪‬‪‬‮(ImageHelper.\u202A‫‭​⁫‫‭⁪‌⁯‍‎‪⁮‏⁯⁮⁯‮⁮‪⁪‬‪‎‎‮⁭‌‍‪‭‏⁮‬‫‬⁯‫‮‮(left)) / 8);
            num1 = 889733742;
            continue;
          case 35:
            if (ImageHelper.\u202E‬‏‌‪‍​‬‬⁭‍⁮‭⁮‮⁫‭‏⁭⁮‪‮⁯‎‫⁬‏‫‌‍‫⁬‏​‏​⁪​⁫⁬‮(left).Equals((object) ImageHelper.\u202E‬‏‌‪‍​‬‬⁭‍⁮‭⁮‮⁫‭‏⁭⁮‪‮⁯‎‫⁬‏‫‌‍‫⁬‏​‏​⁪​⁫⁬‮(right)))
            {
              num1 = 1622644575;
              continue;
            }
            num6 = 1;
            goto label_33;
          default:
            goto label_46;
        }
        int num15;
        num1 = num15 = num4 != 0 ? 1787812524 : (num15 = 844141837);
        continue;
label_21:
        int num16;
        num1 = num16 = num5 == 0 ? 1227268128 : (num16 = 556949474);
        continue;
label_33:
        flag5 = num6 != 0;
        num1 = 1226745963;
      }
label_46:
      return flag1;
    }

    public static int[,] isImageThere(Bitmap fullImage, Bitmap smallImage)
    {
label_1:
      int num1 = -617544647;
      int[,] numArray;
      while (true)
      {
        int num2 = -839048215;
        uint num3;
        int index1;
        Color[,] array1;
        int index2;
        int index3;
        bool flag1;
        Color[,] array2;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        int index4;
        bool flag6;
        bool flag7;
        switch ((num3 = (uint) (num1 ^ num2)) % 43U)
        {
          case 0:
            num1 = -1183658328;
            continue;
          case 1:
            numArray = new int[1, 2]{ { index1, index2 } };
            num1 = (int) num3 * -369393110 ^ -78199880;
            continue;
          case 2:
            num1 = -1053563908;
            continue;
          case 3:
            int num4;
            num1 = num4 = index3 >= ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) smallImage) ? -1329302869 : (num4 = -164570290);
            continue;
          case 4:
            ++index3;
            num1 = -382709654;
            continue;
          case 5:
            int num5 = flag2 ? 1118628344 : (num5 = 667823828);
            int num6 = (int) num3 * -1555881114;
            num1 = num5 ^ num6;
            continue;
          case 6:
            flag5 = index1 < ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) fullImage);
            num1 = -1608622456;
            continue;
          case 7:
            ++index1;
            num1 = -541713010;
            continue;
          case 8:
            index4 = 0;
            num1 = (int) num3 * -1647366341 ^ -1855802781;
            continue;
          case 9:
            flag2 = array2[index1, index2] == array1[0, 0];
            num1 = (int) num3 * -1118383425 ^ 1787060198;
            continue;
          case 10:
            num1 = (int) num3 * 711420526 ^ -1692425798;
            continue;
          case 11:
            ++index2;
            num1 = (int) num3 * -1565316937 ^ 394274237;
            continue;
          case 12:
            int num7 = flag5 ? 902299471 : (num7 = 468886697);
            int num8 = (int) num3 * 988985376;
            num1 = num7 ^ num8;
            continue;
          case 13:
            flag7 = index4 < ImageHelper.\u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮((Image) smallImage);
            num1 = -2073835339;
            continue;
          case 14:
            int num9 = !flag7 ? 670970313 : (num9 = 1284956416);
            int num10 = (int) num3 * 365809231;
            num1 = num9 ^ num10;
            continue;
          case 15:
            num1 = -1762770898;
            continue;
          case 17:
            num1 = -1332675468;
            continue;
          case 18:
            int num11 = flag1 ? 145109228 : (num11 = 1473014353);
            int num12 = (int) num3 * -1554319730;
            num1 = num11 ^ num12;
            continue;
          case 19:
            num1 = -181641916;
            continue;
          case 20:
            num1 = -1682905609;
            continue;
          case 21:
            flag4 = array2[index1 + index4, index2 + index3] != array1[index4, index3];
            num1 = (int) num3 * -889981805 ^ -1516271688;
            continue;
          case 22:
            num1 = (int) num3 * 1052316174 ^ -1963373966;
            continue;
          case 23:
            flag1 = index2 < ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) fullImage);
            num1 = -1521829567;
            continue;
          case 24:
            num1 = (int) num3 * 1914937865 ^ 1025459983;
            continue;
          case 25:
            index2 = 0;
            num1 = (int) num3 * -212998321 ^ 1753266525;
            continue;
          case 26:
            numArray = (int[,]) null;
            num1 = (int) num3 * 740935894 ^ -248317848;
            continue;
          case 27:
            int num13;
            num1 = num13 = !flag3 ? -657569440 : (num13 = -853792007);
            continue;
          case 28:
            ++index4;
            num1 = (int) num3 * 429235653 ^ -574513750;
            continue;
          case 29:
            num1 = (int) num3 * -967153248 ^ -155674357;
            continue;
          case 30:
            goto label_1;
          case 31:
            num1 = (int) num3 * 652261027 ^ -397125769;
            continue;
          case 32:
            array1 = ImageHelper.ImageToArray(smallImage);
            num1 = (int) num3 * -1899617970 ^ 424490503;
            continue;
          case 33:
            int num14 = flag4 ? 889560440 : (num14 = 1505251906);
            int num15 = (int) num3 * -2034025380;
            num1 = num14 ^ num15;
            continue;
          case 34:
            num1 = (int) num3 * 821505271 ^ -139226661;
            continue;
          case 35:
            flag6 = !flag3;
            num1 = -278018685;
            continue;
          case 36:
            int num16 = flag6 ? 198404017 : (num16 = 2049550424);
            int num17 = (int) num3 * -1670860963;
            num1 = num16 ^ num17;
            continue;
          case 37:
            index1 = 0;
            num1 = (int) num3 * -1164279109 ^ 705736199;
            continue;
          case 38:
            num1 = (int) num3 * -1271016356 ^ -290414984;
            continue;
          case 39:
            array2 = ImageHelper.ImageToArray(fullImage);
            num1 = (int) num3 * -1603303418 ^ -1500414461;
            continue;
          case 40:
            flag3 = false;
            index3 = 0;
            num1 = (int) num3 * -1478564135 ^ 233862668;
            continue;
          case 41:
            flag3 = true;
            num1 = (int) num3 * -670868006 ^ -1732766159;
            continue;
          case 42:
            num1 = (int) num3 * -666205573 ^ 281474062;
            continue;
          default:
            goto label_44;
        }
      }
label_44:
      return numArray;
    }

    private static Color[,] ImageToArray(Bitmap image)
    {
      Color[,] colorArray1 = new Color[ImageHelper.\u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮((Image) image), ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) image)];
      int index1 = 0;
label_1:
      int num1 = -622556242;
      Color[,] colorArray2;
      while (true)
      {
        int num2 = -632878795;
        uint num3;
        int index2;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = (int) num3 * 1144973994 ^ -1869860131;
            continue;
          case 1:
            int num4 = flag ? -1641806771 : (num4 = -303541828);
            int num5 = (int) num3 * 608194971;
            num1 = num4 ^ num5;
            continue;
          case 2:
            flag = index2 < ImageHelper.\u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮((Image) image);
            num1 = -736985000;
            continue;
          case 3:
            colorArray2 = colorArray1;
            num1 = (int) num3 * 1901824053 ^ -1455563637;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * 10665652 ^ 2074734449;
            continue;
          case 7:
            num1 = (int) num3 * 285500317 ^ 1866494742;
            continue;
          case 8:
            ++index1;
            num1 = (int) num3 * 376766484 ^ 2056931241;
            continue;
          case 9:
            colorArray1[index1, index2] = ImageHelper.\u202A‍​‌⁪‎‏⁪‬⁮⁭‫⁬‍⁭⁫⁭‪⁫⁫⁪‫‫⁪‌⁮‫⁪‎‍‍‏⁮‮⁫​‭‬⁭⁪‮(image, index1, index2);
            num1 = -1890196384;
            continue;
          case 10:
            index2 = 0;
            num1 = -989593729;
            continue;
          case 11:
            num1 = (int) num3 * -1970859018 ^ -953662675;
            continue;
          case 12:
            int num6;
            num1 = num6 = index1 < ImageHelper.\u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮((Image) image) ? -1241120391 : (num6 = -1599110478);
            continue;
          case 13:
            ++index2;
            num1 = (int) num3 * 169416882 ^ -420544797;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return colorArray2;
    }

    public static ImageHelper.CompareResult Compare(Bitmap bmp1, Bitmap bmp2)
    {
      ImageHelper.CompareResult compareResult1 = ImageHelper.CompareResult.ciCompareOk;
      bool flag1 = ImageHelper.\u202E‬‏‌‪‍​‬‬⁭‍⁮‭⁮‮⁫‭‏⁭⁮‪‮⁯‎‫⁬‏‫‌‍‫⁬‏​‏​⁪​⁫⁬‮((Image) bmp1) != ImageHelper.\u202E‬‏‌‪‍​‬‬⁭‍⁮‭⁮‮⁫‭‏⁭⁮‪‮⁯‎‫⁬‏‫‌‍‫⁬‏​‏​⁪​⁫⁬‮((Image) bmp2);
label_1:
      int num1 = 2043227033;
      ImageHelper.CompareResult compareResult2;
      while (true)
      {
        int num2 = 228138154;
        uint num3;
        byte[] numArray1;
        int index;
        byte[] numArray2;
        bool flag2;
        ImageConverter imageConverter;
        byte[] numArray3;
        SHA256Managed shA256Managed;
        byte[] numArray4;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 27U)
        {
          case 0:
            shA256Managed = ImageHelper.\u202D‍‮‭⁫‭⁫‎​⁪‭‭⁫⁬‪‬‌‮‮⁫⁮‏‏⁬‫⁮‎‍‍‪‭​‏‏​‎‫​‏‎‮();
            numArray1 = ImageHelper.\u202D‭‏‏⁫‎⁭‌‎‬⁬‏⁮‍‮‭⁪⁯‎‭⁮‬‮⁪‍‍‬‌‭‮⁯⁫‮⁮‌‎‪‏⁮‬‮((HashAlgorithm) shA256Managed, numArray4);
            num1 = (int) num3 * 456550588 ^ 1425707639;
            continue;
          case 1:
            num1 = (int) num3 * 2072678076 ^ -62471810;
            continue;
          case 2:
            int num5 = !flag1 ? -1555048123 : (num5 = -129656969);
            int num6 = (int) num3 * -254006482;
            num1 = num5 ^ num6;
            continue;
          case 3:
            numArray3 = new byte[1];
            num1 = (int) num3 * 154406466 ^ -565289108;
            continue;
          case 4:
            num1 = (int) num3 * -1100944256 ^ -114379454;
            continue;
          case 5:
            numArray4 = (byte[]) ImageHelper.\u206F​‮⁬‭⁯⁮‏‪⁭‮‫‭⁪‭⁫‪⁪⁬⁪⁭‬⁭‫‎‭⁮‭⁬‍‌⁬⁪‎⁯‮‍‪‭⁭‮((TypeConverter) imageConverter, (object) bmp1, ImageHelper.\u202A‭‫⁪⁮⁫⁪‪‭⁫⁮‌‭‭‮‎⁫⁭⁪‭‫‏‭⁯‪‫⁪‬‍‫‬⁯⁪⁭⁯⁭‭‪‫⁮‮((object) numArray4));
            num1 = (int) num3 * 299682565 ^ 330934536;
            continue;
          case 6:
            num1 = 230734384;
            continue;
          case 7:
            numArray4 = new byte[1];
            num1 = (int) num3 * 726801695 ^ -1513921707;
            continue;
          case 8:
            index = 0;
            num1 = (int) num3 * 1413661713 ^ -358611675;
            continue;
          case 9:
            compareResult1 = ImageHelper.CompareResult.ciPixelMismatch;
            num1 = (int) num3 * 224006922 ^ 1712135878;
            continue;
          case 10:
            ++index;
            num1 = (int) num3 * 17026042 ^ 1134366804;
            continue;
          case 11:
            num1 = (int) num3 * 1481379040 ^ 1884714178;
            continue;
          case 12:
            if (index < numArray2.Length)
            {
              num1 = (int) num3 * -2004040796 ^ -1683299541;
              continue;
            }
            break;
          case 13:
            int num7 = flag2 ? 163670525 : (num7 = 99910122);
            int num8 = (int) num3 * -2046087899;
            num1 = num7 ^ num8;
            continue;
          case 14:
            numArray2 = ImageHelper.\u202D‭‏‏⁫‎⁭‌‎‬⁬‏⁮‍‮‭⁪⁯‎‭⁮‬‮⁪‍‍‬‌‭‮⁯⁫‮⁮‌‎‪‏⁮‬‮((HashAlgorithm) shA256Managed, numArray3);
            num1 = (int) num3 * -1312968968 ^ 1901353278;
            continue;
          case 15:
            num1 = 244397237;
            continue;
          case 16:
            imageConverter = ImageHelper.\u202C⁬‭‮‌‍⁬‎‪⁯‫‫⁭⁮⁯⁯​‌‫⁯‌‎‏⁮⁭‭‪‎⁭​‮‏‪‎‏⁪⁮‬‮‌‮();
            num1 = (int) num3 * 853316577 ^ -1526264493;
            continue;
          case 17:
            goto label_1;
          case 18:
            if (index < numArray1.Length)
            {
              num1 = 196785599;
              continue;
            }
            break;
          case 19:
            flag2 = (int) numArray1[index] != (int) numArray2[index];
            num1 = (int) num3 * -808359283 ^ -10969226;
            continue;
          case 20:
            num1 = 752537809;
            continue;
          case 21:
            num4 = compareResult1 == ImageHelper.CompareResult.ciCompareOk ? 1 : 0;
            goto label_14;
          case 22:
            num1 = (int) num3 * 1930769321 ^ 1211554138;
            continue;
          case 23:
            numArray3 = (byte[]) ImageHelper.\u206F​‮⁬‭⁯⁮‏‪⁭‮‫‭⁪‭⁫‪⁪⁬⁪⁭‬⁭‫‎‭⁮‭⁬‍‌⁬⁪‎⁯‮‍‪‭⁭‮((TypeConverter) imageConverter, (object) bmp2, ImageHelper.\u202A‭‫⁪⁮⁫⁪‪‭⁫⁮‌‭‭‮‎⁫⁭⁪‭‫‏‭⁯‪‫⁪‬‍‫‬⁯⁪⁭⁯⁭‭‪‫⁮‮((object) numArray3));
            num1 = (int) num3 * -614854444 ^ -1475029340;
            continue;
          case 24:
            compareResult2 = compareResult1;
            num1 = 75400093;
            continue;
          case 26:
            compareResult1 = ImageHelper.CompareResult.ciSizeMismatch;
            num1 = (int) num3 * -1558364781 ^ 1915272431;
            continue;
          default:
            goto label_32;
        }
        num4 = 0;
label_14:
        int num9;
        num1 = num9 = num4 != 0 ? 2015717167 : (num9 = 327767293);
      }
label_32:
      return compareResult2;
    }

    static NotImplementedException \u206E‏‏‏‎‪​‏‏‫‏‬‫‭‭⁭‍⁪⁭‎‪‮⁯‎⁫‎⁮‌‬⁬⁯‫‫‭‍⁭‍‫⁭‪‮()
    {
      return new NotImplementedException();
    }

    static Color \u202A‍​‌⁪‎‏⁪‬⁮⁭‫⁬‍⁭⁫⁭‪⁫⁫⁪‫‫⁪‌⁮‫⁪‎‍‍‏⁮‮⁫​‭‬⁭⁪‮([In] Bitmap obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.GetPixel(obj1, obj2);
    }

    static int \u206B‭⁮‪‪​‌‪‭‪⁫‏⁮‍‌​⁪‭‍⁪‪⁫⁯‮​⁫‍‬‮⁮‮‌‎‪‫⁫⁬‪⁪⁭‮([In] Image obj0)
    {
      return obj0.Height;
    }

    static int \u202D‪‬⁮‬‫‬‫⁬‍​‎⁭⁬​⁭⁪⁯⁮⁬‭⁯⁪‫‭‌‍‬⁪⁬⁮‍⁫⁪‏‬‪⁬⁫⁪‮([In] Image obj0)
    {
      return obj0.Width;
    }

    static void \u206D‍⁬⁮⁬‮⁯⁫‍‮‫⁬⁭⁯‮‎‏⁮‍‍‌⁮‫⁭‫‭⁬⁫⁫‬⁬‍⁬‪⁬⁭‭⁮⁯⁯‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static BitmapSizeOptions \u206B⁪⁫⁭⁫‌‌‍⁫‏​‍‍‎​‍⁯⁪⁭⁬‮‬⁭‪‭‍​‮⁬⁯‏⁬‪‌​‎⁬‌‫‌‮()
    {
      return BitmapSizeOptions.FromEmptyOptions();
    }

    static BitmapSource \u200C​⁬⁭‏⁫⁫‫​‬‏‪⁫‌⁭⁮⁪‫‮‏‎⁬‫‍⁯‭‌‌⁪⁬​‭‪‭​‬‌⁭‪⁮‮([In] IntPtr obj0, [In] IntPtr obj1, [In] Int32Rect obj2, [In] BitmapSizeOptions obj3)
    {
      return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(obj0, obj1, obj2, obj3);
    }

    static void \u206B‍‪‭‮‌‮‬‏‍⁮⁮⁮⁬‭‮⁫​‪‮⁮‫‫‫‌⁭‬‫‭⁭‭⁬‎⁪⁯‍‪⁯‏⁭‮([In] BitmapSource obj0)
    {
      Clipboard.SetImage(obj0);
    }

    static void \u202B‏‌⁫‏‮‮‫‍⁫‬⁯‮‌​⁭‫‏⁬‬⁫‫‎⁭‌​‍‬‪​‬‫⁪‫‪⁮‍⁮⁭⁬‮([In] Freezable obj0)
    {
      obj0.Freeze();
    }

    static string \u206D‌​⁮‌⁮‎‎‮‪⁪‍⁯⁫‍⁮‭​⁬‭‭⁬⁪⁬⁪‮⁯‏⁮‏‫‎​⁮‍⁪‮‪⁫‍‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u202E⁯⁪⁭‍‬‪‎⁫‌​‪‍⁬‏⁯⁬​‭​⁭‎‭‌‮‪⁮‌‏‮⁯‮‎‌⁭⁪⁪⁯‭⁬‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static Exception \u206F‬​‪⁪‭⁪‪⁭‌​‎‌‏‮‪‫⁮‌​‎⁮⁬⁫⁫‭‎‬‍​​‪‍‬⁬‪‌‌⁫⁪‮([In] string obj0, [In] Exception obj1)
    {
      return new Exception(obj0, obj1);
    }

    static bool \u202C‭⁫‌‌‬⁫‬‌‪⁪‎‫⁫⁬⁭⁬‌‭‏⁪‏‎⁪⁭‏‬⁫‎‭⁪⁬‎⁭​‮⁫‬‏‮‮([In] object obj0, [In] object obj1)
    {
      return object.Equals(obj0, obj1);
    }

    static System.Drawing.Size \u202E‬‏‌‪‍​‬‬⁭‍⁮‭⁮‮⁫‭‏⁭⁮‪‮⁯‎‫⁬‏‫‌‍‫⁬‏​‏​⁪​⁫⁬‮([In] Image obj0)
    {
      return obj0.Size;
    }

    static PixelFormat \u202A‫‭​⁫‫‭⁪‌⁯‍‎‪⁮‏⁯⁮⁯‮⁮‪⁪‬‪‎‎‮⁭‌‍‪‭‏⁮‬‫‬⁯‫‮‮([In] Image obj0)
    {
      return obj0.PixelFormat;
    }

    static int \u202E⁪⁯‎‫‏‍‮​‍‪⁫‫‎⁬‮‮‌‭‭‬⁯‭⁪‪‮⁮​‬‮⁯​‫‭⁭‬⁪‬‪‬‮([In] PixelFormat obj0)
    {
      return Image.GetPixelFormatSize(obj0);
    }

    static ImageConverter \u202C⁬‭‮‌‍⁬‎‪⁯‫‫⁭⁮⁯⁯​‌‫⁯‌‎‏⁮⁭‭‪‎⁭​‮‏‪‎‏⁪⁮‬‮‌‮()
    {
      return new ImageConverter();
    }

    static Type \u202A‭‫⁪⁮⁫⁪‪‭⁫⁮‌‭‭‮‎⁫⁭⁪‭‫‏‭⁯‪‫⁪‬‍‫‬⁯⁪⁭⁯⁭‭‪‫⁮‮([In] object obj0)
    {
      return obj0.GetType();
    }

    static object \u206F​‮⁬‭⁯⁮‏‪⁭‮‫‭⁪‭⁫‪⁪⁬⁪⁭‬⁭‫‎‭⁮‭⁬‍‌⁬⁪‎⁯‮‍‪‭⁭‮([In] TypeConverter obj0, [In] object obj1, [In] Type obj2)
    {
      return obj0.ConvertTo(obj1, obj2);
    }

    static SHA256Managed \u202D‍‮‭⁫‭⁫‎​⁪‭‭⁫⁬‪‬‌‮‮⁫⁮‏‏⁬‫⁮‎‍‍‪‭​‏‏​‎‫​‏‎‮()
    {
      return new SHA256Managed();
    }

    static byte[] \u202D‭‏‏⁫‎⁭‌‎‬⁬‏⁮‍‮‭⁪⁯‎‭⁮‬‮⁪‍‍‬‌‭‮⁯⁫‮⁮‌‎‪‏⁮‬‮([In] HashAlgorithm obj0, [In] byte[] obj1)
    {
      return obj0.ComputeHash(obj1);
    }

    static MethodBase \u200F​‪⁯‪⁮‎⁮‎‭‏‍⁬‌‭⁬​‏⁫⁮⁮⁬‍‏⁭‎⁮‭⁬‮⁭‌‬‌​⁪‬‌‭⁪‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206D‬‭⁯‍‍‎‏⁭⁮‌⁬‮⁪‏‬⁪‭⁫‍‏‬‫‍⁪⁪⁯‪‏‬‫‫⁯‌‭⁯‭‍‎⁬‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202D⁪‬‫⁯​​⁫‪⁬‎⁬⁮‌‮⁫​‪⁫‏⁯‭⁬‪⁮⁯‍‏⁯​⁮⁬‮⁭⁫‪‬‮⁭‏‮([In] Type obj0)
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
