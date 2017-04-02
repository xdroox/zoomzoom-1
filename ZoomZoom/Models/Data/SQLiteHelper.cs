// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Data.SQLiteHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Data
{
  public static class SQLiteHelper
  {
    public static bool TableExists(SQLiteConnection cDB, string tableName)
    {
      bool flag1 = false;
      SQLiteCommand sqLiteCommand = SQLiteHelper.\u206D​‎‪‬‭⁫‍‍‬‮‭​‮‫‍‪⁯‏‫⁬‪⁬‮⁫‮‌‪‫⁫‭‏⁬‎⁯⁯‭‪⁮‫‮(cDB);
      try
      {
label_2:
        int num1 = -1263570929;
        while (true)
        {
          int num2 = -1751015724;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              SQLiteHelper.\u206D⁭‭‍‪⁪‎‭‮‍‭‮‍‌⁭⁯‫‍⁫⁪⁮⁯‫‌‪⁭⁫‫⁬⁯‭⁭‮‫⁮⁮‫‫⁬‪‮((DbCommand) sqLiteCommand, SQLiteHelper.\u206F‫⁬‭‌⁭‍‫‬⁯‮‫‍‍​‪‭⁬​‭‎‫⁪‬‪‎​‎‮‮⁯⁪‌⁯‍⁯⁫‬⁭‎‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3626382200U), (object) tableName));
              num1 = (int) num3 * 1772743916 ^ -1004685376;
              continue;
            case 1:
              num1 = (int) num3 * -651833357 ^ -1253239707;
              continue;
            case 2:
              SQLiteHelper.\u202C‏​⁪⁯‮⁯⁪‭‍‌​‭⁯⁭‏‌‍⁯⁫‭‏‫‫‍‪⁬⁯⁭‌‌‮⁬‏⁭‭​⁫‫‎‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * 2035913898 ^ -779349621;
              continue;
            case 3:
              int num4 = flag2 ? 331282195 : (num4 = 2101598805);
              int num5 = (int) num3 * -1363019893;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag1 = true;
              num1 = (int) num3 * -1507057124 ^ -1151463305;
              continue;
            case 6:
              num1 = (int) num3 * 1249646767 ^ 305775086;
              continue;
            case 7:
              goto label_2;
            case 8:
              num1 = (int) num3 * -1047660314 ^ 1941495774;
              continue;
            case 9:
              num1 = (int) num3 * -1960389132 ^ -1951678382;
              continue;
            case 10:
              flag2 = (int) SQLiteHelper.\u200D‎‪⁮‫​​⁫⁯‪⁫⁭​‎⁪⁪‫‍‮‌‬‌⁭‎⁫‮‫⁮⁫⁭⁯‬‍⁭‪‬⁫‮⁮⁯‮(sqLiteCommand, CommandBehavior.SingleRow) > 0;
              num1 = (int) num3 * -163837019 ^ 521634721;
              continue;
            default:
              goto label_19;
          }
        }
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_14:
          int num1 = -1723132073;
          while (true)
          {
            int num2 = -1751015724;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_14;
              case 2:
                num1 = (int) num3 * -417675583 ^ -952191405;
                continue;
              case 3:
                SQLiteHelper.\u200F⁬‍‮⁭‮‌‪⁮‪‎⁪‬‌⁭⁫‏‏‫‫⁫‫‎⁪‫⁪‪‭‌‭‌‍‮⁪‬​‫⁮‌‏‮((IDisposable) sqLiteCommand);
                num1 = (int) num3 * -541135097 ^ 1479870187;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
label_19:
      bool flag3 = flag1;
label_20:
      int num6 = -607276604;
      while (true)
      {
        int num1 = -1751015724;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 1:
            num6 = (int) num2 * 507095120 ^ -1149386333;
            continue;
          case 2:
            goto label_20;
          default:
            goto label_23;
        }
      }
label_23:
      return flag3;
    }

    static SQLiteCommand \u206D​‎‪‬‭⁫‍‍‬‮‭​‮‫‍‪⁯‏‫⁬‪⁬‮⁫‮‌‪‫⁫‭‏⁬‎⁯⁯‭‪⁮‫‮([In] SQLiteConnection obj0)
    {
      return obj0.CreateCommand();
    }

    static void \u202C‏​⁪⁯‮⁯⁪‭‍‌​‭⁯⁭‏‌‍⁯⁫‭‏‫‫‍‪⁬⁯⁭‌‌‮⁬‏⁭‭​⁫‫‎‮([In] DbCommand obj0, [In] CommandType obj1)
    {
      obj0.CommandType = obj1;
    }

    static string \u206F‫⁬‭‌⁭‍‫‬⁯‮‫‍‍​‪‭⁬​‭‎‫⁪‬‪‎​‎‮‮⁯⁪‌⁯‍⁯⁫‬⁭‎‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u206D⁭‭‍‪⁪‎‭‮‍‭‮‍‌⁭⁯‫‍⁫⁪⁮⁯‫‌‪⁭⁫‫⁬⁯‭⁭‮‫⁮⁮‫‫⁬‪‮([In] DbCommand obj0, [In] string obj1)
    {
      obj0.CommandText = obj1;
    }

    static object \u200D‎‪⁮‫​​⁫⁯‪⁫⁭​‎⁪⁪‫‍‮‌‬‌⁭‎⁫‮‫⁮⁫⁭⁯‬‍⁭‪‬⁫‮⁮⁯‮([In] SQLiteCommand obj0, [In] CommandBehavior obj1)
    {
      return obj0.ExecuteScalar(obj1);
    }

    static void \u200F⁬‍‮⁭‮‌‪⁮‪‎⁪‬‌⁭⁫‏‏‫‫⁫‫‎⁪‫⁪‪‭‌‭‌‍‮⁪‬​‫⁮‌‏‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }
  }
}
