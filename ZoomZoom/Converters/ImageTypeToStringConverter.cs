// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.ImageTypeToStringConverter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Data;
using ZoomZoom.Models.Images;

namespace ZoomZoom.Converters
{
  public class ImageTypeToStringConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = -2021618202;
      object obj;
      while (true)
      {
        int num2 = -1346365261;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 25U)
        {
          case 0:
          case 22:
            num1 = -1966940831;
            continue;
          case 1:
            num4 = value is ImageEnums.ImageType ? 1 : 0;
            break;
          case 2:
            switch ((ImageEnums.ImageType) value)
            {
              case ImageEnums.ImageType.Undefined:
                goto label_10;
              case ImageEnums.ImageType.Meeting:
                goto label_7;
              case ImageEnums.ImageType.Video:
                goto label_13;
              case ImageEnums.ImageType.ChatSelector:
                goto label_8;
              case ImageEnums.ImageType.Window:
                goto label_15;
              case ImageEnums.ImageType.Region:
                goto label_24;
              case ImageEnums.ImageType.Debug:
                goto label_4;
              case ImageEnums.ImageType.Menu:
                goto label_9;
              case ImageEnums.ImageType.All:
                goto label_20;
              default:
                num1 = (int) num3 * -1104381062 ^ -835543347;
                continue;
            }
          case 3:
            num1 = (int) num3 * 1737186287 ^ 1039510834;
            continue;
          case 4:
label_20:
            obj = (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2204455874U);
            num1 = -1128405356;
            continue;
          case 5:
            num1 = (int) num3 * 601332235 ^ -1802342338;
            continue;
          case 6:
            obj = (object) ImageEnums.ImageType.Undefined;
            num1 = -1221552119;
            continue;
          case 7:
label_4:
            obj = (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(310073775U);
            num1 = -1722221965;
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num3 * 1257568236 ^ -905597036;
            continue;
          case 10:
label_10:
            obj = (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3744888011U);
            num1 = -1142023018;
            continue;
          case 11:
label_8:
            obj = (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2534805426U);
            num1 = -1822259634;
            continue;
          case 12:
            num1 = (int) num3 * 1215637505 ^ 755051185;
            continue;
          case 13:
label_15:
            obj = (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(666835085U);
            num1 = -1583497075;
            continue;
          case 14:
label_7:
            obj = (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(846979453U);
            num1 = -1128405356;
            continue;
          case 15:
            num1 = (int) num3 * -65948459 ^ -1266615510;
            continue;
          case 16:
label_24:
            obj = (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1735467566U);
            num1 = -1128405356;
            continue;
          case 18:
            num1 = (int) num3 * 142441236 ^ -736289712;
            continue;
          case 19:
            num1 = (int) num3 * 54373652 ^ -1683201260;
            continue;
          case 20:
label_9:
            obj = (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3796912284U);
            num1 = -1128405356;
            continue;
          case 21:
label_13:
            obj = (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(165442225U);
            num1 = -767403693;
            continue;
          case 23:
            if (value != null)
            {
              num1 = (int) num3 * -1417034881 ^ 1947924085;
              continue;
            }
            num4 = 0;
            break;
          case 24:
            int num5 = !flag ? 1238285321 : (num5 = 1845558787);
            int num6 = (int) num3 * -1904605094;
            num1 = num5 ^ num6;
            continue;
          default:
            goto label_29;
        }
        flag = num4 != 0;
        num1 = -1706116937;
      }
label_29:
      return obj;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 1119370839;
      object obj;
      while (true)
      {
        int num2 = 663997950;
        uint num3;
        string s;
        uint stringHash;
        switch ((num3 = (uint) (num1 ^ num2)) % 59U)
        {
          case 0:
            num1 = (int) num3 * -606451867 ^ 1410558118;
            continue;
          case 1:
            int num4;
            num1 = num4 = stringHash <= 2606869827U ? 1406574152 : (num4 = 138295338);
            continue;
          case 2:
            obj = (object) ImageEnums.ImageType.All;
            num1 = 1354461618;
            continue;
          case 3:
            obj = (object) ImageEnums.ImageType.Meeting;
            num1 = 7267306;
            continue;
          case 4:
            obj = (object) ImageEnums.ImageType.Debug;
            num1 = 2134001010;
            continue;
          case 5:
            int num5;
            num1 = num5 = !ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(183240021U)) ? 202467396 : (num5 = 786327635);
            continue;
          case 6:
            obj = (object) ImageEnums.ImageType.Region;
            num1 = 869192276;
            continue;
          case 7:
            num1 = (int) num3 * 1279101901 ^ -231873045;
            continue;
          case 8:
            int num6;
            num1 = num6 = (int) stringHash != 227248186 ? 9927007 : (num6 = 1460308567);
            continue;
          case 9:
            int num7;
            num1 = num7 = (int) stringHash == -1150734950 ? 717013690 : (num7 = 387448129);
            continue;
          case 10:
            int num8;
            num1 = num8 = (int) stringHash != 1483009432 ? 1987496063 : (num8 = 1680415730);
            continue;
          case 11:
            num1 = (int) num3 * -1623835344 ^ 426994246;
            continue;
          case 12:
            num1 = (int) num3 * 2059943110 ^ -1628758534;
            continue;
          case 13:
            num1 = (int) num3 * 722725667 ^ -1878091009;
            continue;
          case 14:
            obj = (object) ImageEnums.ImageType.Video;
            num1 = 1765531219;
            continue;
          case 15:
            obj = (object) ImageEnums.ImageType.ChatSelector;
            num1 = 1400698405;
            continue;
          case 16:
            int num9;
            num1 = num9 = (int) stringHash == -1688097469 ? 1012411319 : (num9 = 933195243);
            continue;
          case 17:
            num1 = (int) num3 * -2055420088 ^ 1086964277;
            continue;
          case 18:
            num1 = (int) num3 * 2131798941 ^ -688843634;
            continue;
          case 19:
            num1 = (int) num3 * 480242561 ^ 251127206;
            continue;
          case 20:
            int num10;
            num1 = num10 = !ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2673372955U)) ? 426089880 : (num10 = 295572834);
            continue;
          case 21:
            int num11;
            num1 = num11 = (int) stringHash != 321211332 ? 1564587945 : (num11 = 1646436897);
            continue;
          case 22:
            int num12 = (int) stringHash != 52100733 ? -67016427 : (num12 = -1144614017);
            int num13 = (int) num3 * 448272576;
            num1 = num12 ^ num13;
            continue;
          case 23:
            int num14 = stringHash > 227248186U ? -1492607150 : (num14 = -18879389);
            int num15 = (int) num3 * 1148177183;
            num1 = num14 ^ num15;
            continue;
          case 24:
            int num16;
            num1 = num16 = (int) stringHash == -1586317347 ? 1041587171 : (num16 = 591199494);
            continue;
          case 25:
            num1 = (int) num3 * 7655623 ^ -367141527;
            continue;
          case 26:
            num1 = (int) num3 * -1436585267 ^ -1204942606;
            continue;
          case 27:
            num1 = (int) num3 * -1726685328 ^ -954324878;
            continue;
          case 28:
            num1 = (int) num3 * 357359006 ^ 326844605;
            continue;
          case 29:
            int num17;
            num1 = num17 = !ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1905017136U)) ? 777764925 : (num17 = 738467527);
            continue;
          case 30:
            int num18;
            num1 = num18 = !ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1672007988U)) ? 1320591279 : (num18 = 35516865);
            continue;
          case 31:
            num1 = (int) num3 * 490937011 ^ 543895737;
            continue;
          case 32:
            obj = (object) ImageEnums.ImageType.Undefined;
            num1 = 1641065914;
            continue;
          case 33:
            num1 = (int) num3 * -686189777 ^ 1724871666;
            continue;
          case 34:
            goto label_1;
          case 35:
            int num19;
            num1 = num19 = !ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3075274547U)) ? 704004886 : (num19 = 2021429679);
            continue;
          case 36:
            int num20;
            num1 = num20 = ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(461735187U)) ? 2098492626 : (num20 = 1650690646);
            continue;
          case 37:
            num1 = (int) num3 * 734014084 ^ -1574963578;
            continue;
          case 38:
            int num21;
            num1 = num21 = ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2332764114U)) ? 1869923010 : (num21 = 1025495012);
            continue;
          case 39:
            int num22;
            num1 = num22 = !ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3863184200U)) ? 704893306 : (num22 = 750035070);
            continue;
          case 40:
            s = ImageTypeToStringConverter.\u206A‎‭​‎‭‫‭‏‬‫⁬‭​⁪​‫‏‬‏⁬​‌​‫⁬‬⁯‫⁫⁪‫​‫⁮⁬​⁬‌‮‮(ImageTypeToStringConverter.\u206E‭‮‭‫‬‌‭‎⁬⁬⁯⁫‌‌⁪‎‌‫‪⁬‬‌‍⁬‬⁭‪‭‌​⁮‌‭‌‪‬‬​‌‮(value));
            num1 = (int) num3 * -839829850 ^ -1438289337;
            continue;
          case 41:
            num1 = (int) num3 * -1097216987 ^ -1636988959;
            continue;
          case 42:
            num1 = (int) num3 * 1006367574 ^ -772251013;
            continue;
          case 43:
            int num23;
            num1 = num23 = !ImageTypeToStringConverter.\u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮(s, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2120463513U)) ? 1149780618 : (num23 = 2124028284);
            continue;
          case 44:
            obj = (object) ImageEnums.ImageType.Undefined;
            num1 = 904790455;
            continue;
          case 45:
            num1 = (int) num3 * 104441402 ^ 1488984374;
            continue;
          case 46:
            int num24;
            num1 = num24 = (int) stringHash != -822539412 ? 375146241 : (num24 = 1892865143);
            continue;
          case 48:
            // ISSUE: reference to a compiler-generated method
            stringHash = \u003CPrivateImplementationDetails\u003E.ComputeStringHash(s);
            int num25 = stringHash <= 1483009432U ? -312739108 : (num25 = -1308927341);
            int num26 = (int) num3 * -947467383;
            num1 = num25 ^ num26;
            continue;
          case 49:
            int num27 = (int) stringHash == -1713054406 ? 1224912504 : (num27 = 297182200);
            int num28 = (int) num3 * -606445145;
            num1 = num27 ^ num28;
            continue;
          case 50:
            num1 = (int) num3 * 1065335153 ^ 2137379488;
            continue;
          case 51:
            num1 = (int) num3 * -130390378 ^ -585161248;
            continue;
          case 52:
            obj = (object) ImageEnums.ImageType.Menu;
            num1 = 1354461618;
            continue;
          case 53:
            num1 = (int) num3 * 1035125372 ^ 1305910563;
            continue;
          case 54:
            obj = (object) ImageEnums.ImageType.Window;
            num1 = 1354461618;
            continue;
          case 55:
            num1 = (int) num3 * -435132776 ^ -1863089133;
            continue;
          case 56:
            num1 = (int) num3 * 1863290562 ^ -1479917353;
            continue;
          case 57:
            num1 = (int) num3 * -374534806 ^ 381137331;
            continue;
          case 58:
            num1 = (int) num3 * -572971723 ^ -1699902852;
            continue;
          default:
            goto label_60;
        }
      }
label_60:
      return obj;
    }

    static string \u206E‭‮‭‫‬‌‭‎⁬⁬⁯⁫‌‌⁪‎‌‫‪⁬‬‌‍⁬‬⁭‪‭‌​⁮‌‭‌‪‬‬​‌‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u206A‎‭​‎‭‫‭‏‬‫⁬‭​⁪​‫‏‬‏⁬​‌​‫⁬‬⁯‫⁫⁪‫​‫⁮⁬​⁬‌‮‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static bool \u206F⁬‭‎‫⁭‮‫⁯‬‏⁬‌⁯⁫⁬‌⁬⁫⁪⁪⁮​⁫‍‫⁫‏‏‭‎⁬⁬‮‫‎⁭⁪‬‬‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }
  }
}
