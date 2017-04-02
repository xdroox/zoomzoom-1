// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.StringHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ZoomZoom.Common
{
  public class StringHelper
  {
    public StringHelper()
    {
label_1:
      int num1 = 82331186;
      while (true)
      {
        int num2 = 1316996533;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -2048335983 ^ -862584377;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public static string AddSpacesToSentence(string text, bool preserveAcronyms)
    {
label_1:
      int num1 = 1154147944;
      string str;
      while (true)
      {
        int num2 = 401792711;
        uint num3;
        int num4;
        StringBuilder stringBuilder;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            int num6 = (int) StringHelper.\u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮(text, num4 - 1) != 32 ? -1972021813 : (num6 = -698614745);
            int num7 = (int) num3 * 1691175794;
            num1 = num6 ^ num7;
            continue;
          case 1:
            int num8;
            num1 = num8 = num4 < StringHelper.\u202D‫​⁫⁯‌‏⁬‎⁫​⁮⁭⁯‬‏‏⁪⁪⁭‪‎⁫⁫‍‭⁮⁮⁬‌‎‍‌‍‪‬‎⁪‎⁬‮(text) ? 1010775385 : (num8 = 1973746547);
            continue;
          case 2:
            num1 = (int) num3 * -989531827 ^ -1243817318;
            continue;
          case 3:
            str = string.Empty;
            num1 = (int) num3 * 177202333 ^ -1589323424;
            continue;
          case 4:
            ++num4;
            num1 = (int) num3 * 371156381 ^ -2049290941;
            continue;
          case 6:
            if (preserveAcronyms)
            {
              num1 = 1145168146;
              continue;
            }
            break;
          case 7:
            stringBuilder = StringHelper.\u202E‫‍‎‫‎⁪⁮⁭​‏‪‪‎⁯⁬⁪⁫‮‬‬⁬‮⁭‎‎⁫‍⁮​​‌⁯​‌‪‌⁪⁯⁯‮(StringHelper.\u202D‫​⁫⁯‌‏⁬‎⁫​⁮⁭⁯‬‏‏⁪⁪⁭‪‎⁫⁫‍‭⁮⁮⁬‌‎‍‌‍‪‬‎⁪‎⁬‮(text) * 2);
            StringHelper.\u202E⁮⁮‍​⁭‮‍⁫​‪‭‪⁪⁫​⁯⁮‪⁯‪‭‏⁮⁫⁭‏⁮‮⁮⁯⁮‎‮⁯‮‭‭⁬‪‮(stringBuilder, StringHelper.\u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮(text, 0));
            num1 = 819776381;
            continue;
          case 8:
            StringHelper.\u202E⁮⁮‍​⁭‮‍⁫​‪‭‪⁪⁫​⁯⁮‪⁯‪‭‏⁮⁫⁭‏⁮‮⁮⁯⁮‎‮⁯‮‭‭⁬‪‮(stringBuilder, StringHelper.\u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮(text, num4));
            num1 = 367696941;
            continue;
          case 9:
            num1 = (int) num3 * 253574373 ^ -306937547;
            continue;
          case 10:
            if (char.IsUpper(StringHelper.\u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮(text, num4 - 1)))
            {
              num1 = (int) num3 * -2125486646 ^ -215966956;
              continue;
            }
            break;
          case 11:
            int num9;
            num1 = num9 = char.IsUpper(StringHelper.\u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮(text, num4)) ? 1672309840 : (num9 = 118703774);
            continue;
          case 12:
            goto label_1;
          case 13:
            int num10 = StringHelper.\u206D‌⁯⁯‏⁮‏‍‭⁬‏‍‏‍‬⁭‭‬‭‫⁮‏⁫‪⁭‎⁫‌⁮‭‪‮⁭⁭‮​‌​‏‮‮(text) ? -1705393267 : (num10 = -910977627);
            int num11 = (int) num3 * -1438616671;
            num1 = num10 ^ num11;
            continue;
          case 14:
            if (char.IsUpper(StringHelper.\u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮(text, num4 - 1)))
            {
              num1 = (int) num3 * -1275057400 ^ 62318473;
              continue;
            }
            num5 = 1;
            goto label_15;
          case 15:
            num5 = !char.IsUpper(StringHelper.\u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮(text, num4 + 1)) ? 1 : 0;
            goto label_15;
          case 16:
            num4 = 1;
            num1 = (int) num3 * -1746205347 ^ -1311898488;
            continue;
          case 17:
            str = StringHelper.\u200D‮⁮‫‭⁫⁬‌⁭‭‭‮⁪‮⁭‭⁯⁯‎​⁪⁮​​​‎⁬‪‍‍‫‏⁭⁬‪‪‎⁮⁭‫‮((object) stringBuilder);
            num1 = (int) num3 * -1445858226 ^ -1511735893;
            continue;
          case 18:
            num1 = (int) num3 * 169901109 ^ 956792609;
            continue;
          case 19:
            if (num4 < StringHelper.\u202D‫​⁫⁯‌‏⁬‎⁫​⁮⁭⁯‬‏‏⁪⁪⁭‪‎⁫⁫‍‭⁮⁮⁬‌‎‍‌‍‪‬‎⁪‎⁬‮(text) - 1)
            {
              num1 = (int) num3 * -1293823600 ^ 900603803;
              continue;
            }
            break;
          case 20:
            StringHelper.\u202E⁮⁮‍​⁭‮‍⁫​‪‭‪⁪⁫​⁯⁮‪⁯‪‭‏⁮⁫⁭‏⁮‮⁮⁯⁮‎‮⁯‮‭‭⁬‪‮(stringBuilder, ' ');
            num1 = (int) num3 * 1933617640 ^ 1050651366;
            continue;
          default:
            goto label_29;
        }
        num5 = 0;
label_15:
        int num12;
        num1 = num12 = num5 == 0 ? 118703774 : (num12 = 717945980);
      }
label_29:
      return str;
    }

    public static DateTime UnixTimeStampToDateTime(string unixTimeStamp)
    {
      DateTime dateTime1 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
label_1:
      int num1 = 1092206728;
      DateTime dateTime2;
      while (true)
      {
        int num2 = 460990134;
        uint num3;
        DateTime dateTime3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            dateTime3 = dateTime1.AddSeconds(StringHelper.\u200C‭‮⁭‏‪⁪‏⁫‭⁮‪​​‭‏‎‌‌‮‫⁯⁬⁪‌‮⁯⁪‎‍‍‏⁭⁫‬⁮‭⁬​‭‮(unixTimeStamp));
            num1 = (int) num3 * 1339336971 ^ -1330155237;
            continue;
          case 2:
            dateTime1 = dateTime3.ToLocalTime();
            dateTime2 = dateTime1;
            num1 = (int) num3 * 660536328 ^ 1670529691;
            continue;
          case 3:
            num1 = (int) num3 * -170669320 ^ 823285730;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return dateTime2;
    }

    static bool \u206D‌⁯⁯‏⁮‏‍‭⁬‏‍‏‍‬⁭‭‬‭‫⁮‏⁫‪⁭‎⁫‌⁮‭‪‮⁭⁭‮​‌​‏‮‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static int \u202D‫​⁫⁯‌‏⁬‎⁫​⁮⁭⁯‬‏‏⁪⁪⁭‪‎⁫⁫‍‭⁮⁮⁬‌‎‍‌‍‪‬‎⁪‎⁬‮([In] string obj0)
    {
      return obj0.Length;
    }

    static StringBuilder \u202E‫‍‎‫‎⁪⁮⁭​‏‪‪‎⁯⁬⁪⁫‮‬‬⁬‮⁭‎‎⁫‍⁮​​‌⁯​‌‪‌⁪⁯⁯‮([In] int obj0)
    {
      return new StringBuilder(obj0);
    }

    static char \u200E‫‎⁯‌​‍‌‌⁫‏‎‪‎⁭⁪‍⁪⁬‬‪⁮‌‎‍‪⁯‫⁭​⁮‫‎‭‮‮⁪⁭⁮‪‮([In] string obj0, [In] int obj1)
    {
      return obj0[obj1];
    }

    static StringBuilder \u202E⁮⁮‍​⁭‮‍⁫​‪‭‪⁪⁫​⁯⁮‪⁯‪‭‏⁮⁫⁭‏⁮‮⁮⁯⁮‎‮⁯‮‭‭⁬‪‮([In] StringBuilder obj0, [In] char obj1)
    {
      return obj0.Append(obj1);
    }

    static string \u200D‮⁮‫‭⁫⁬‌⁭‭‭‮⁪‮⁭‭⁯⁯‎​⁪⁮​​​‎⁬‪‍‍‫‏⁭⁬‪‪‎⁮⁭‫‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static double \u200C‭‮⁭‏‪⁪‏⁫‭⁮‪​​‭‏‎‌‌‮‫⁯⁬⁪‌‮⁯⁪‎‍‍‏⁭⁫‬⁮‭⁬​‭‮([In] string obj0)
    {
      return Convert.ToDouble(obj0);
    }
  }
}
