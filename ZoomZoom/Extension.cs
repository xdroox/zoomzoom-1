// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Extension
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Data.Common;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public static class Extension
  {
    public static string GetFieldValueString(this SQLiteDataReader value, string columnName)
    {
      string str1 = string.Empty;
      int num1 = Extension.\u206C​‫⁮⁭⁯⁭‫‫‍‭‫‭⁮‭⁭​‎⁪‎⁪‌‌⁫‬‮⁯‍⁪‭⁬⁭‭‮‪‬‬​‍⁪‮((DbDataReader) value, columnName);
      bool flag = !Extension.\u202E‮‎‏⁭‮⁪‫⁭‏⁪⁪​⁮⁭‍‌‬‭⁮‭⁮⁫‭‮​‮‭‪‌​‍‎‫⁫⁬‏⁭⁯‫‮((DbDataReader) value, num1);
label_1:
      int num2 = 1719034408;
      string str2;
      while (true)
      {
        int num3 = 959317950;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 7U)
        {
          case 0:
            str1 = Extension.\u200E‫⁮‬‌‫⁫⁮⁯‍⁫‬‎‎‌‮‎⁪​⁮‮‮⁯‎‏⁪​⁯⁬‬​⁬‫‫⁬​‪‪‫‍‮((DbDataReader) value, num1);
            num2 = (int) num4 * 1537342173 ^ 405153137;
            continue;
          case 2:
            num2 = (int) num4 * -1887032539 ^ -1556884533;
            continue;
          case 3:
            num2 = (int) num4 * 1278971690 ^ -2106857925;
            continue;
          case 4:
            str2 = str1;
            num2 = 1461204930;
            continue;
          case 5:
            goto label_1;
          case 6:
            int num5 = !flag ? -781475892 : (num5 = -905547621);
            int num6 = (int) num4 * 1671230151;
            num2 = num5 ^ num6;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return str2;
    }

    public static long GetFieldValueLong(this SQLiteDataReader value, string columnName)
    {
      long num1 = 0;
      int num2 = Extension.\u206C​‫⁮⁭⁯⁭‫‫‍‭‫‭⁮‭⁭​‎⁪‎⁪‌‌⁫‬‮⁯‍⁪‭⁬⁭‭‮‪‬‬​‍⁪‮((DbDataReader) value, columnName);
label_1:
      int num3 = -839550712;
      long num4;
      while (true)
      {
        int num5 = -89683179;
        uint num6;
        bool flag;
        switch ((num6 = (uint) (num3 ^ num5)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = Extension.\u200C‎⁫⁬⁮⁪⁬‍‬‮‍‮‭‭‏⁪‮‏⁯‎‫⁭⁭⁭‎‮‫‍⁭‍⁮‍⁭‫‍‭‬⁪⁭‮((DbDataReader) value, num2);
            num3 = (int) num6 * -167301633 ^ -1292768739;
            continue;
          case 2:
            num3 = (int) num6 * -994357368 ^ -1365641005;
            continue;
          case 4:
            num4 = num1;
            num3 = -310445070;
            continue;
          case 5:
            flag = !Extension.\u202E‮‎‏⁭‮⁪‫⁭‏⁪⁪​⁮⁭‍‌‬‭⁮‭⁮⁫‭‮​‮‭‪‌​‍‎‫⁫⁬‏⁭⁯‫‮((DbDataReader) value, num2);
            num3 = (int) num6 * -1226724338 ^ -88681389;
            continue;
          case 6:
            int num7 = !flag ? -1037323946 : (num7 = -2088442464);
            int num8 = (int) num6 * -571040854;
            num3 = num7 ^ num8;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return num4;
    }

    public static int GetFieldValueInt(this SQLiteDataReader value, string columnName)
    {
      int num1 = 0;
      int num2 = Extension.\u206C​‫⁮⁭⁯⁭‫‫‍‭‫‭⁮‭⁭​‎⁪‎⁪‌‌⁫‬‮⁯‍⁪‭⁬⁭‭‮‪‬‬​‍⁪‮((DbDataReader) value, columnName);
      if (Extension.\u202E‮‎‏⁭‮⁪‫⁭‏⁪⁪​⁮⁭‍‌‬‭⁮‭⁮⁫‭‮​‮‭‪‌​‍‎‫⁫⁬‏⁭⁯‫‮((DbDataReader) value, num2))
        goto label_5;
label_1:
      int num3 = 947479868;
label_2:
      while (true)
      {
        int num4 = 1027042547;
        uint num5;
        switch ((num5 = (uint) (num3 ^ num4)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            num3 = (int) num5 * 1481307213 ^ 1505587704;
            continue;
          case 2:
            num1 = Extension.\u202D‬⁬‮‭‎⁮⁯⁭⁬⁪‫‬​⁯‪⁮​‫‏⁮⁯‫⁯​⁯‫⁫‬‍‬‏⁪⁪‭‪‮‏‎‫‮((DbDataReader) value, num2);
            num3 = (int) num5 * 1873860271 ^ -1932704291;
            continue;
          case 4:
            goto label_5;
          case 5:
            num3 = (int) num5 * 960629281 ^ 867311303;
            continue;
          case 6:
            num3 = (int) num5 * 429775455 ^ 1545494465;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      int num6;
      return num6;
label_5:
      num6 = num1;
      num3 = 1484649389;
      goto label_2;
    }

    public static object GetFieldValue(this SQLiteDataReader value, string columnName)
    {
label_1:
      int num1 = 845370304;
      object obj1;
      while (true)
      {
        int num2 = 600183141;
        uint num3;
        int num4;
        bool flag;
        object obj2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * -240739099 ^ -506837598;
            continue;
          case 1:
            int num5 = !flag ? -308871191 : (num5 = -1211553926);
            int num6 = (int) num3 * 1442604688;
            num1 = num5 ^ num6;
            continue;
          case 3:
            num4 = Extension.\u206C​‫⁮⁭⁯⁭‫‫‍‭‫‭⁮‭⁭​‎⁪‎⁪‌‌⁫‬‮⁯‍⁪‭⁬⁭‭‮‪‬‬​‍⁪‮((DbDataReader) value, columnName);
            flag = !Extension.\u202E‮‎‏⁭‮⁪‫⁭‏⁪⁪​⁮⁭‍‌‬‭⁮‭⁮⁫‭‮​‮‭‪‌​‍‎‫⁫⁬‏⁭⁯‫‮((DbDataReader) value, num4);
            num1 = (int) num3 * 644473493 ^ -989361185;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * -248449350 ^ -1713646385;
            continue;
          case 6:
            obj2 = Extension.\u202A⁬⁬⁪⁪‮‍⁬‌​‍⁮​‌⁮‮‌⁭‫⁫‪‏⁪‍‮⁫‪‍‎‌⁫⁮‬‌⁫‬​‬‭⁮‮((DbDataReader) value, num4);
            num1 = (int) num3 * -617020489 ^ -585830835;
            continue;
          case 7:
            obj1 = obj2;
            num1 = 745432184;
            continue;
          case 8:
            obj2 = (object) null;
            num1 = (int) num3 * 1736267309 ^ -151567748;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return obj1;
    }

    public static DateTime GetFieldValueDateTime(this SQLiteDataReader value, string columnName)
    {
label_1:
      int num1 = 1131938890;
      DateTime result;
      int num2;
      while (true)
      {
        int num3 = 1789741052;
        uint num4;
        bool flag;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 1:
            if (flag)
            {
              num1 = (int) num4 * -698076920 ^ 121805560;
              continue;
            }
            goto label_19;
          case 2:
            result = DateTime.MinValue;
            num2 = Extension.\u206C​‫⁮⁭⁯⁭‫‫‍‭‫‭⁮‭⁭​‎⁪‎⁪‌‌⁫‬‮⁯‍⁪‭⁬⁭‭‮‪‬‬​‍⁪‮((DbDataReader) value, columnName);
            flag = !Extension.\u202E‮‎‏⁭‮⁪‫⁭‏⁪⁪​⁮⁭‍‌‬‭⁮‭⁮⁫‭‮​‮‭‪‌​‍‎‫⁫⁬‏⁭⁯‫‮((DbDataReader) value, num2);
            num1 = (int) num4 * -1150500823 ^ 765295191;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      try
      {
        string s = Extension.\u200E‫⁮‬‌‫⁫⁮⁯‍⁫‬‎‎‌‮‎⁪​⁮‮‮⁯‎‏⁪​⁯⁬‬​⁬‫‫⁬​‪‪‫‍‮((DbDataReader) value, num2);
label_8:
        int num3 = 521634077;
        while (true)
        {
          int num4 = 1789741052;
          uint num5;
          bool flag;
          switch ((num5 = (uint) (num3 ^ num4)) % 7U)
          {
            case 0:
              flag = !DateTime.TryParse(s, out result);
              num3 = (int) num5 * -562629902 ^ -336709710;
              continue;
            case 1:
              int num6 = s == null ? -271056215 : (num6 = -1726252256);
              int num7 = (int) num5 * -1517153528;
              num3 = num6 ^ num7;
              continue;
            case 2:
              goto label_8;
            case 3:
              result = DateTime.MinValue;
              num3 = (int) num5 * 1541564546 ^ -1455529234;
              continue;
            case 4:
              num3 = 338880673;
              continue;
            case 6:
              int num8 = flag ? -1442315776 : (num8 = -977007712);
              int num9 = (int) num5 * 885094323;
              num3 = num8 ^ num9;
              continue;
            default:
              goto label_16;
          }
        }
      }
      catch (Exception ex)
      {
      }
label_16:
label_17:
      int num10 = 674323404;
label_18:
      int num11 = 1789741052;
      uint num12;
      DateTime dateTime;
      switch ((num12 = (uint) (num10 ^ num11)) % 3U)
      {
        case 1:
          break;
        case 2:
          goto label_17;
        default:
          return dateTime;
      }
label_19:
      dateTime = result;
      num10 = 624265545;
      goto label_18;
    }

    public static byte[] GetFieldValueBytes(this SQLiteDataReader value, string columnName)
    {
      byte[] numArray1 = (byte[]) null;
      int num1 = Extension.\u206C​‫⁮⁭⁯⁭‫‫‍‭‫‭⁮‭⁭​‎⁪‎⁪‌‌⁫‬‮⁯‍⁪‭⁬⁭‭‮‪‬‬​‍⁪‮((DbDataReader) value, columnName);
      if (!Extension.\u202E‮‎‏⁭‮⁪‫⁭‏⁪⁪​⁮⁭‍‌‬‭⁮‭⁮⁫‭‮​‮‭‪‌​‍‎‫⁫⁬‏⁭⁯‫‮((DbDataReader) value, num1))
      {
        try
        {
label_2:
          int num2 = 830672445;
          long length;
          while (true)
          {
            int num3 = 282014630;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                length = Extension.\u202B‬‫‫​‎‬⁫‎‭‬‮⁫⁫⁮‫‏‭‫‬‫‏⁬⁮​‪‎‏‪⁯‌⁭‌‪‌‫‍‌⁭⁬‮((DbDataReader) value, num1, 0L, (byte[]) null, 0, 0);
                numArray1 = new byte[length];
                num2 = (int) num4 * 1291099827 ^ 846153775;
                continue;
              case 2:
                goto label_2;
              default:
                goto label_5;
            }
          }
label_5:
          Extension.\u202B‬‫‫​‎‬⁫‎‭‬‮⁫⁫⁮‫‏‭‫‬‫‏⁬⁮​‪‎‏‪⁯‌⁭‌‪‌‫‍‌⁭⁬‮((DbDataReader) value, num1, 0L, numArray1, 0, Extension.\u200E‌‏⁫⁯‌⁬‎‭‏⁪⁭‎‍‭‮⁬‍⁭⁮⁫⁮‏⁪‪​‌⁯‍⁪‪⁮‌⁯⁮‪‮‬‎⁭‮(length));
        }
        catch (Exception ex)
        {
label_7:
          int num2 = 1808662093;
          while (true)
          {
            int num3 = 282014630;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_7;
              case 1:
                numArray1 = (byte[]) null;
                num2 = (int) num4 * 123459649 ^ 1418231077;
                continue;
              case 3:
                num2 = (int) num4 * 1592557361 ^ 1305507256;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
      else
        goto label_14;
label_12:
      int num5 = 408938032;
label_13:
      while (true)
      {
        int num2 = 282014630;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 4U)
        {
          case 0:
            goto label_12;
          case 1:
            num5 = (int) num3 * -643363624 ^ -412681635;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_16;
        }
      }
label_16:
      byte[] numArray2;
      return numArray2;
label_14:
      numArray2 = numArray1;
      num5 = 429502455;
      goto label_13;
    }

    static int \u206C​‫⁮⁭⁯⁭‫‫‍‭‫‭⁮‭⁭​‎⁪‎⁪‌‌⁫‬‮⁯‍⁪‭⁬⁭‭‮‪‬‬​‍⁪‮([In] DbDataReader obj0, [In] string obj1)
    {
      return obj0.GetOrdinal(obj1);
    }

    static bool \u202E‮‎‏⁭‮⁪‫⁭‏⁪⁪​⁮⁭‍‌‬‭⁮‭⁮⁫‭‮​‮‭‪‌​‍‎‫⁫⁬‏⁭⁯‫‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0.IsDBNull(obj1);
    }

    static string \u200E‫⁮‬‌‫⁫⁮⁯‍⁫‬‎‎‌‮‎⁪​⁮‮‮⁯‎‏⁪​⁯⁬‬​⁬‫‫⁬​‪‪‫‍‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0.GetString(obj1);
    }

    static long \u200C‎⁫⁬⁮⁪⁬‍‬‮‍‮‭‭‏⁪‮‏⁯‎‫⁭⁭⁭‎‮‫‍⁭‍⁮‍⁭‫‍‭‬⁪⁭‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0.GetInt64(obj1);
    }

    static int \u202D‬⁬‮‭‎⁮⁯⁭⁬⁪‫‬​⁯‪⁮​‫‏⁮⁯‫⁯​⁯‫⁫‬‍‬‏⁪⁪‭‪‮‏‎‫‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0.GetInt32(obj1);
    }

    static object \u202A⁬⁬⁪⁪‮‍⁬‌​‍⁮​‌⁮‮‌⁭‫⁫‪‏⁪‍‮⁫‪‍‎‌⁫⁮‬‌⁫‬​‬‭⁮‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0.GetValue(obj1);
    }

    static long \u202B‬‫‫​‎‬⁫‎‭‬‮⁫⁫⁮‫‏‭‫‬‫‏⁬⁮​‪‎‏‪⁯‌⁭‌‪‌‫‍‌⁭⁬‮([In] DbDataReader obj0, [In] int obj1, [In] long obj2, [In] byte[] obj3, [In] int obj4, [In] int obj5)
    {
      return obj0.GetBytes(obj1, obj2, obj3, obj4, obj5);
    }

    static int \u200E‌‏⁫⁯‌⁬‎‭‏⁪⁭‎‍‭‮⁬‍⁭⁮⁫⁮‏⁪‪​‌⁯‍⁪‪⁮‌⁯⁮‪‮‬‎⁭‮([In] long obj0)
    {
      return Convert.ToInt32(obj0);
    }
  }
}
