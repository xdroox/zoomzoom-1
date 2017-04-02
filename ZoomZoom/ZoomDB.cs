// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomDB
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using ZoomZoom.Chats;
using ZoomZoom.Models.Data;
using ZoomZoom.Properties;

namespace ZoomZoom
{
  public class ZoomDB : CoreObject
  {
    private static readonly object _locker = ZoomDB.\u202C‎‌‍‎‭‏⁮‍‫​‌‫⁭‎‎‮‍‏‫⁮⁫⁬⁬‬‬‪⁫⁫⁮‌‎‫‭‏⁫⁫‮​‬‮();
    private SQLiteConnection cDB = (SQLiteConnection) null;
    private SQLiteConnection cChat = (SQLiteConnection) null;
    private string sDBConnectionString = string.Empty;
    private string sChatConnectionString = string.Empty;
    private bool isGeneration2Style = false;
    private const string S_DB_DATABASE_NAME = "zoomus.db";
    private const string S_CHAT_DATABASE_NAME = "zoommeeting.db";

    public override TraceType TraceType
    {
      get
      {
        return TraceType.DataStorage;
      }
    }

    public static string DBConnectionString
    {
      get
      {
label_1:
        int num1 = -679253636;
        string str1;
        while (true)
        {
          int num2 = -1696637949;
          uint num3;
          string str2;
          string str3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              str3 = ZoomDB.\u202A​‪⁪⁯⁪‍‎⁮‫‏‭‪‍‏‏⁬‏⁬⁪‫⁫‫‪⁮⁪⁬‭‪‮‫⁬⁪⁪⁫‏‍‮⁯‎‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(494189337U), (object) str2);
              num1 = (int) num3 * 1964741175 ^ -192489475;
              continue;
            case 3:
              str1 = str3;
              num1 = (int) num3 * 1935924104 ^ -743045089;
              continue;
            case 4:
              str2 = ZoomDB.\u200F⁮‭⁮⁮‏‎‌‍‍⁬‎‮⁬‫‫⁮‮‌‌‎​‫‫⁪⁮‮‭⁯⁭‪⁪⁬‎⁬‫⁯⁯‪⁮‮(ZoomDB.\u202E‎⁬​⁬‪‫⁪⁮⁯‍⁬​⁬‫‬⁮⁬‮​‪‫‍⁯⁯‭‍‍⁭⁭‪⁯‎⁪⁬⁫⁮⁫⁮‬‮(Engine.Instance.Settings.ZoomExePath), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2582138453U));
              num1 = (int) num3 * 1421437845 ^ 1974799411;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return str1;
      }
    }

    public static string ChatConnectionString
    {
      get
      {
label_1:
        int num1 = -1572526896;
        string str1;
        while (true)
        {
          int num2 = -180209840;
          uint num3;
          string str2;
          string str3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              str3 = ZoomDB.\u202A​‪⁪⁯⁪‍‎⁮‫‏‭‪‍‏‏⁬‏⁬⁪‫⁫‫‪⁮⁪⁬‭‪‮‫⁬⁪⁪⁫‏‍‮⁯‎‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(494189337U), (object) str2);
              num1 = (int) num3 * -2026439432 ^ -1387905921;
              continue;
            case 1:
              num1 = (int) num3 * 1978745494 ^ 1025257472;
              continue;
            case 3:
              str1 = str3;
              num1 = (int) num3 * 876079492 ^ -185036817;
              continue;
            case 4:
              str2 = ZoomDB.\u200F⁮‭⁮⁮‏‎‌‍‍⁬‎‮⁬‫‫⁮‮‌‌‎​‫‫⁪⁮‮‭⁯⁭‪⁪⁬‎⁬‫⁯⁯‪⁮‮(ZoomDB.\u202E‎⁬​⁬‪‫⁪⁮⁯‍⁬​⁬‫‬⁮⁬‮​‪‫‍⁯⁯‭‍‍⁭⁭‪⁯‎⁪⁬⁫⁮⁫⁮‬‮(Engine.Instance.Settings.ZoomExePath), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2018807199U));
              num1 = (int) num3 * 799021478 ^ 1058565588;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return str1;
      }
    }

    public bool IsGeneration2Style
    {
      get
      {
        bool generation2Style = this.isGeneration2Style;
label_1:
        int num1 = -1213858267;
        while (true)
        {
          int num2 = -502383527;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1145143040 ^ -1402658226;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return generation2Style;
      }
      set
      {
label_1:
        int num1 = -519738014;
        while (true)
        {
          int num2 = -2051973586;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.isGeneration2Style = value;
              num1 = (int) num3 * -2090300294 ^ -338077935;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    private bool OpenDBConnection()
    {
      bool flag = false;
      try
      {
        if (this.cDB != null)
          goto label_8;
label_2:
        int num1 = -107930829;
label_3:
        while (true)
        {
          int num2 = -71789171;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 17U)
          {
            case 0:
              ZoomDB.\u200C⁪‎⁯​⁭⁬⁬‏‌‍‫⁭⁭⁪‎⁪⁫‎‍‏⁪‭⁭‬‮‮‏​⁮‫‌‪‌‭⁫⁬‫⁪‬‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1783519613U));
              num1 = (int) num3 * -973713669 ^ -840592529;
              continue;
            case 1:
              num1 = (int) num3 * -1218842483 ^ 37733749;
              continue;
            case 2:
              num1 = -740291213;
              continue;
            case 3:
              this.cDB = ZoomDB.\u206E‪⁭⁬⁯⁫⁯⁪​‍​⁭‪‫‮‍‌⁬‮⁫‌‎‌⁫‬‏‏‪⁫⁭​‪⁯⁫‬⁪⁬⁭⁮‪‮(ZoomDB.DBConnectionString);
              ZoomDB.\u202C⁪‍⁯⁪⁯‌‮‏‍⁬​‫⁫⁫‮‫‬⁬‭‬⁫‫‪⁫⁭‭‪⁯‬‌⁫⁫⁬‎⁫‏⁫⁪⁫‮((DbConnection) this.cDB);
              num1 = (int) num3 * -318638886 ^ 1851451160;
              continue;
            case 4:
              ZoomDB.\u202D‫‍‌‍⁮⁯⁮‌⁭‫​​‏‮⁯‬‮‏‮‬‌⁪⁯‍⁫‮‭‮‌‎‪‫‬‍‌⁪‪‏‏‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2054996937U), (object) ZoomDB.DBConnectionString);
              num1 = (int) num3 * -1616572419 ^ -1063453179;
              continue;
            case 5:
              goto label_16;
            case 6:
              this.ExecuteSQL(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4187488722U));
              num1 = (int) num3 * -1665975485 ^ -1616010403;
              continue;
            case 7:
              goto label_8;
            case 8:
              num1 = (int) num3 * -995324572 ^ -1261909199;
              continue;
            case 9:
              num1 = (int) num3 * 1362488663 ^ 225381551;
              continue;
            case 11:
              num1 = (int) num3 * -2016105359 ^ -1331241070;
              continue;
            case 12:
              num1 = (int) num3 * -1774436402 ^ -918576967;
              continue;
            case 13:
              goto label_2;
            case 14:
              flag = true;
              num1 = (int) num3 * 726043478 ^ -1129256522;
              continue;
            case 15:
              int num4 = !this.TableExists(this.cDB, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2410243304U)) ? 1798215872 : (num4 = 1428825769);
              int num5 = (int) num3 * 675873623;
              num1 = num4 ^ num5;
              continue;
            case 16:
              num1 = (int) num3 * -552412912 ^ 281522943;
              continue;
            default:
              goto label_28;
          }
        }
label_16:
        int num6 = ZoomDB.\u206A⁫⁬‭⁪‍⁬‍‫‭⁬‎‭‪‍‏⁯‪‪⁯‌‌‎⁭‌‮⁬‭‪‫‏⁬⁬‮‎⁫‬​⁭⁪‮((DbConnection) this.cDB) == ConnectionState.Open ? 1 : 0;
        goto label_18;
label_8:
        if (this.cDB != null)
        {
          num1 = -940869067;
          goto label_3;
        }
        else
          num6 = 0;
label_18:
        num1 = num6 != 0 ? -969547090 : (num1 = -1433563723);
        goto label_3;
      }
      catch (Exception ex)
      {
        ZoomDB.\u202D‫‍‌‍⁮⁯⁮‌⁭‫​​‏‮⁯‬‮‏‮‬‌⁪⁯‍⁫‮‭‮‌‎‪‫‬‍‌⁪‪‏‏‮(CoreObject.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3403016464U), (object) ZoomDB.DBConnectionString);
label_23:
        int num1 = -378088497;
        while (true)
        {
          int num2 = -71789171;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_23;
            case 2:
              num1 = (int) num3 * -662485735 ^ -135847508;
              continue;
            case 3:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 492946733 ^ -1110517205;
              continue;
            default:
              goto label_27;
          }
        }
label_27:
        throw ex;
      }
label_28:
      return flag;
    }

    private bool OpenChatConnection()
    {
      bool flag1 = false;
      try
      {
        bool flag2 = this.cChat == null;
label_2:
        int num1 = -788451934;
        while (true)
        {
          int num2 = -1101404876;
          uint num3;
          bool flag3;
          bool flag4;
          switch ((num3 = (uint) (num1 ^ num2)) % 29U)
          {
            case 0:
              goto label_2;
            case 1:
              ZoomDB.\u202C⁪‍⁯⁪⁯‌‮‏‍⁬​‫⁫⁫‮‫‬⁬‭‬⁫‫‪⁫⁭‭‪⁯‬‌⁫⁫⁬‎⁫‏⁫⁪⁫‮((DbConnection) this.cChat);
              num1 = (int) num3 * -1559543814 ^ 159161825;
              continue;
            case 2:
              num1 = (int) num3 * -2038178594 ^ -373316996;
              continue;
            case 3:
              int num4 = !flag2 ? -762219652 : (num4 = -234142393);
              int num5 = (int) num3 * 877284109;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag3 = ZoomDB.\u206A⁫⁬‭⁪‍⁬‍‫‭⁬‎‭‪‍‏⁯‪‪⁯‌‌‎⁭‌‮⁬‭‪‫‏⁬⁬‮‎⁫‬​⁭⁪‮((DbConnection) this.cChat) == ConnectionState.Closed;
              num1 = -419893067;
              continue;
            case 5:
              this.cChat = ZoomDB.\u206E‪⁭⁬⁯⁫⁯⁪​‍​⁭‪‫‮‍‌⁬‮⁫‌‎‌⁫‬‏‏‪⁫⁭​‪⁯⁫‬⁪⁬⁭⁮‪‮(ZoomDB.ChatConnectionString);
              num1 = (int) num3 * 785207468 ^ -522463455;
              continue;
            case 6:
              num1 = -1961234315;
              continue;
            case 7:
              int num6 = !flag4 ? -1015511721 : (num6 = -235937501);
              int num7 = (int) num3 * -889216366;
              num1 = num6 ^ num7;
              continue;
            case 8:
              num1 = (int) num3 * -1462861383 ^ 954995493;
              continue;
            case 9:
              int num8 = flag3 ? 1008540039 : (num8 = 654767680);
              int num9 = (int) num3 * -756630729;
              num1 = num8 ^ num9;
              continue;
            case 10:
              num1 = (int) num3 * 679511146 ^ 766823235;
              continue;
            case 11:
              flag1 = true;
              num1 = (int) num3 * 1844561271 ^ 1612299987;
              continue;
            case 12:
              num1 = (int) num3 * -1134730965 ^ 1367173189;
              continue;
            case 13:
              ZoomDB.\u202D‫‍‌‍⁮⁯⁮‌⁭‫​​‏‮⁯‬‮‏‮‬‌⁪⁯‍⁫‮‭‮‌‎‪‫‬‍‌⁪‪‏‏‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1728850962U), (object) ZoomDB.ChatConnectionString);
              num1 = (int) num3 * 1121595654 ^ -1837048397;
              continue;
            case 15:
              this.IsGeneration2Style = true;
              num1 = (int) num3 * -954058612 ^ -1611224145;
              continue;
            case 16:
              int num10;
              num1 = num10 = ZoomDB.\u206A⁫⁬‭⁪‍⁬‍‫‭⁬‎‭‪‍‏⁯‪‪⁯‌‌‎⁭‌‮⁬‭‪‫‏⁬⁬‮‎⁫‬​⁭⁪‮((DbConnection) this.cChat) == ConnectionState.Open ? -2125325820 : (num10 = -229991511);
              continue;
            case 17:
              num1 = (int) num3 * -797069011 ^ 703794088;
              continue;
            case 18:
              num1 = (int) num3 * 1773569281 ^ 1937981258;
              continue;
            case 19:
              flag4 = this.TableExists(this.cChat, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(845402198U));
              num1 = (int) num3 * 1189490513 ^ 1182723413;
              continue;
            case 20:
              num1 = (int) num3 * -896068892 ^ 1635254832;
              continue;
            case 21:
              ZoomDB.\u202C⁪‍⁯⁪⁯‌‮‏‍⁬​‫⁫⁫‮‫‬⁬‭‬⁫‫‪⁫⁭‭‪⁯‬‌⁫⁫⁬‎⁫‏⁫⁪⁫‮((DbConnection) this.cChat);
              num1 = (int) num3 * 2016426141 ^ 1114009306;
              continue;
            case 22:
              num1 = (int) num3 * -403105297 ^ -1489818669;
              continue;
            case 23:
              num1 = (int) num3 * 1468737433 ^ 1338626859;
              continue;
            case 24:
              flag1 = true;
              num1 = (int) num3 * 1835190980 ^ 1647107081;
              continue;
            case 25:
              num1 = (int) num3 * -569328959 ^ -1424777887;
              continue;
            case 26:
              num1 = (int) num3 * 381645155 ^ 1628651309;
              continue;
            case 27:
              num1 = (int) num3 * -1089715909 ^ 1076195665;
              continue;
            case 28:
              this.IsGeneration2Style = false;
              num1 = -1742376930;
              continue;
            default:
              goto label_39;
          }
        }
      }
      catch (Exception ex)
      {
label_32:
        int num1 = -761380067;
        while (true)
        {
          int num2 = -1101404876;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1849505201 ^ 609972345;
              continue;
            case 1:
              ZoomDB.\u202D‫‍‌‍⁮⁯⁮‌⁭‫​​‏‮⁯‬‮‏‮‬‌⁪⁯‍⁫‮‭‮‌‎‪‫‬‍‌⁪‪‏‏‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4053409968U), (object) ZoomDB.ChatConnectionString);
              num1 = (int) num3 * -918975452 ^ 1566715425;
              continue;
            case 2:
              goto label_32;
            case 3:
              num1 = (int) num3 * 717196683 ^ -1826267763;
              continue;
            case 4:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -402460282 ^ -1284715322;
              continue;
            default:
              goto label_38;
          }
        }
label_38:
        throw ex;
      }
label_39:
      bool flag5 = flag1;
label_40:
      int num11 = -2078103799;
      while (true)
      {
        int num1 = -1101404876;
        uint num2;
        switch ((num2 = (uint) (num11 ^ num1)) % 3U)
        {
          case 0:
            goto label_40;
          case 2:
            num11 = (int) num2 * 1245268644 ^ -1585677697;
            continue;
          default:
            goto label_43;
        }
      }
label_43:
      return flag5;
    }

    private bool TableExists(SQLiteConnection conn, string tableName)
    {
      string str = ZoomDB.\u202A​‪⁪⁯⁪‍‎⁮‫‏‭‪‍‏‏⁬‏⁬⁪‫⁫‫‪⁮⁪⁬‭‪‮‫⁬⁪⁪⁫‏‍‮⁯‎‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1578724580U), (object) tableName);
      bool flag1 = false;
      try
      {
        SQLiteCommand sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(conn);
        try
        {
label_3:
          int num1 = 1498324618;
          while (true)
          {
            int num2 = 426376488;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                num1 = (int) num3 * -204683888 ^ 1584219034;
                continue;
              case 1:
                ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str);
                num1 = (int) num3 * 1859223117 ^ -152227530;
                continue;
              case 2:
                goto label_3;
              case 4:
                ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
                num1 = (int) num3 * -2022489735 ^ -890823393;
                continue;
              default:
                goto label_8;
            }
          }
label_8:
          SQLiteDataReader sqLiteDataReader = ZoomDB.\u200E‭‫⁫‭⁯⁯‬‭​‮‎‎‍⁫‬‏⁯‍‪‭‮⁪‍⁬⁪‍‎‮⁪‮‏‎‬‌‏⁪‪⁪⁭‮(sqLiteCommand);
          try
          {
label_10:
            int num2 = 371568780;
            while (true)
            {
              int num3 = 426376488;
              uint num4;
              bool flag2;
              switch ((num4 = (uint) (num2 ^ num3)) % 7U)
              {
                case 0:
                  goto label_10;
                case 1:
                  flag1 = true;
                  num2 = 786622726;
                  continue;
                case 2:
                  num2 = (int) num4 * -1768286403 ^ 1543803531;
                  continue;
                case 3:
                  int num5 = !flag2 ? -510253260 : (num5 = -1497000466);
                  int num6 = (int) num4 * -1011125833;
                  num2 = num5 ^ num6;
                  continue;
                case 4:
                  num2 = (int) num4 * -1344070009 ^ -39082275;
                  continue;
                case 6:
                  flag2 = ZoomDB.\u206F‫‍‬⁮‫‍⁭‮‍‪⁯​⁯‮‌‪⁭⁪‮⁫⁯⁭⁮⁫‌​‎‪⁬⁯⁮‪‎⁪‍‪‮‌‍‮((DbDataReader) sqLiteDataReader);
                  num2 = 807230202;
                  continue;
                default:
                  goto label_34;
              }
            }
          }
          finally
          {
            if (sqLiteDataReader != null)
            {
label_18:
              int num2 = 753194193;
              while (true)
              {
                int num3 = 426376488;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 1:
                    ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) sqLiteDataReader);
                    num2 = (int) num4 * 2072219792 ^ -127910923;
                    continue;
                  case 2:
                    goto label_18;
                  default:
                    goto label_21;
                }
              }
            }
label_21:;
          }
        }
        finally
        {
          if (sqLiteCommand != null)
          {
label_23:
            int num1 = 1507631894;
            while (true)
            {
              int num2 = 426376488;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_23;
                case 2:
                  ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) sqLiteCommand);
                  num1 = (int) num3 * 340767155 ^ -1257458607;
                  continue;
                case 3:
                  num1 = (int) num3 * 1793269495 ^ 1111712996;
                  continue;
                default:
                  goto label_27;
              }
            }
          }
label_27:;
        }
      }
      catch (Exception ex)
      {
label_29:
        int num1 = 1658505873;
        while (true)
        {
          int num2 = 426376488;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1715337116 ^ 940601638;
              continue;
            case 2:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1516579087 ^ 972710570;
              continue;
            case 3:
              goto label_29;
            default:
              goto label_33;
          }
        }
label_33:
        throw;
      }
label_34:
      return flag1;
    }

    internal bool ScrubMeetings()
    {
label_1:
      int num1 = 2105767288;
      string str1;
      SQLiteCommand sqLiteCommand;
      while (true)
      {
        int num2 = 738095079;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            str1 = string.Empty;
            num1 = (int) num3 * 1268946349 ^ -1673136665;
            continue;
          case 1:
            List<string> stringList = new List<string>();
            num1 = (int) num3 * 1261341953 ^ -858048953;
            continue;
          case 2:
            goto label_1;
          case 3:
            sqLiteCommand = (SQLiteCommand) null;
            num1 = (int) num3 * 745227411 ^ 2036729242;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag1 = false;
      try
      {
        bool flag2 = this.OpenDBConnection();
label_8:
        int num2 = 1961840657;
        while (true)
        {
          int num3 = 738095079;
          uint num4;
          int index;
          string[] strArray1;
          object obj;
          bool flag3;
          string str2;
          string[] strArray2;
          switch ((num4 = (uint) (num2 ^ num3)) % 28U)
          {
            case 0:
              num2 = (int) num4 * -1259122915 ^ -2043422576;
              continue;
            case 1:
              num2 = 507079823;
              continue;
            case 2:
              num2 = (int) num4 * 929509032 ^ -1579931489;
              continue;
            case 3:
              int num5;
              num2 = num5 = index >= strArray1.Length ? 91289814 : (num5 = 1912165758);
              continue;
            case 5:
              obj = ZoomDB.\u206D‍‎⁪⁪⁮​‎​‎‌‭⁯⁯‭‭‎‭‬‍‍⁫⁪⁪‮‎‬⁫⁭‭‏⁬‬⁮⁮‍⁭​⁬‬‮(sqLiteCommand, CommandBehavior.Default);
              flag3 = obj != null;
              num2 = (int) num4 * 1354116033 ^ 196298496;
              continue;
            case 6:
              goto label_8;
            case 7:
              num2 = (int) num4 * 837849757 ^ 134624128;
              continue;
            case 8:
              strArray2 = ZoomDB.\u206A⁮⁬⁮⁫‬‭⁭‎⁯‫‭‫‏​‬⁭⁫⁮⁪‎⁫‭​⁬⁪‌‍‫⁯‮‬‮‫⁭⁪‌‎‏⁭‮(str1, new char[1]
              {
                ';'
              });
              num2 = (int) num4 * -1498808892 ^ 1964111524;
              continue;
            case 9:
              str1 = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(obj);
              num2 = (int) num4 * -2053330556 ^ 2053439235;
              continue;
            case 10:
              num2 = 1686715473;
              continue;
            case 11:
              num2 = (int) num4 * 922268345 ^ 990012918;
              continue;
            case 12:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              num2 = (int) num4 * -894560701 ^ -101767821;
              continue;
            case 13:
              int num6;
              num2 = num6 = this.Engine.GetMeeting(strArray1[index], false).MeetingStatus != MeetingStatus.Invalid ? 1348914589 : (num6 = 781267890);
              continue;
            case 14:
              str1 = ZoomDB.\u206C⁫​‌‌⁭⁬‭‌⁮‏‪‮‪‮⁫⁮‍‬‪‫‏⁫‭⁮⁫​‮‌‌⁯​​⁯‪‎‭⁫⁭⁬‮((object) str1, (object) strArray2, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2791357287U));
              num2 = (int) num4 * -1507233925 ^ -270507720;
              continue;
            case 15:
              strArray1 = strArray2;
              num2 = (int) num4 * -480417975 ^ 863489565;
              continue;
            case 16:
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3660790839U));
              num2 = (int) num4 * -761469152 ^ 1736605956;
              continue;
            case 17:
              str2 = ZoomDB.\u202E‫‫‪⁯⁬⁭‭⁯‮​‎‏‌‌⁭‏‌⁬‬‌​‬‌⁭⁪‬‪‏‭‏‪⁮⁮‪‏‭‏‫‮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2230139864U), str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3961441525U));
              num2 = (int) num4 * -333665817 ^ -999442668;
              continue;
            case 18:
              int num7 = !flag2 ? 1028182525 : (num7 = 1522964065);
              int num8 = (int) num4 * -1824256350;
              num2 = num7 ^ num8;
              continue;
            case 19:
              num2 = (int) num4 * -1180997305 ^ -1903260379;
              continue;
            case 20:
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str2);
              ZoomDB.\u200B⁯‫⁪‪‏‌⁪‌‮‏⁭‍⁫⁯‮‍‭⁯​⁯⁫‭⁪‍⁭‌‎‭‏⁯‫⁯‮⁬‎​‪⁭‫‮((DbCommand) sqLiteCommand);
              flag1 = true;
              num2 = (int) num4 * 1523919195 ^ 2079404308;
              continue;
            case 21:
              index = 0;
              num2 = (int) num4 * 887856841 ^ 1608645345;
              continue;
            case 22:
              int num9 = !flag3 ? 2048008525 : (num9 = 629366298);
              int num10 = (int) num4 * 380157966;
              num2 = num9 ^ num10;
              continue;
            case 23:
              ++index;
              num2 = (int) num4 * 1010892683 ^ -1489945035;
              continue;
            case 24:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * -1815208853 ^ -404495950;
              continue;
            case 25:
              num2 = (int) num4 * -1857695941 ^ 342881865;
              continue;
            case 26:
              num2 = 1872487471;
              continue;
            case 27:
              num2 = (int) num4 * 861727323 ^ 987829001;
              continue;
            default:
              goto label_41;
          }
        }
      }
      catch (Exception ex)
      {
label_37:
        int num2 = 961835976;
        while (true)
        {
          int num3 = 738095079;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * 846474866 ^ 264050534;
              continue;
            case 2:
              goto label_37;
            case 3:
              num2 = (int) num4 * -1790746862 ^ 1546347789;
              continue;
            default:
              goto label_41;
          }
        }
      }
label_41:
      bool flag4 = flag1;
label_42:
      int num11 = 1593300149;
      while (true)
      {
        int num2 = 738095079;
        uint num3;
        switch ((num3 = (uint) (num11 ^ num2)) % 3U)
        {
          case 0:
            goto label_42;
          case 2:
            num11 = (int) num3 * 1506677461 ^ 1223122686;
            continue;
          default:
            goto label_45;
        }
      }
label_45:
      return flag4;
    }

    internal void DeleteChat(ZoomChatStruct rawChatsToDelete)
    {
      try
      {
label_2:
        int num1 = -1683929352;
        while (true)
        {
          int num2 = -1724648757;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              if (flag)
              {
                num1 = (int) num3 * -586888616 ^ -1981433158;
                continue;
              }
              goto label_31;
            case 2:
              goto label_2;
            case 3:
              flag = this.OpenChatConnection();
              num1 = (int) num3 * -415187134 ^ -1913745639;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        SQLiteCommand cChatCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cChat);
        try
        {
label_9:
          int num2 = -1479142842;
          while (true)
          {
            int num3 = -1724648757;
            uint num4;
            string str1;
            string sSQL;
            string str2;
            switch ((num4 = (uint) (num2 ^ num3)) % 10U)
            {
              case 0:
                goto label_9;
              case 1:
                ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) cChatCommand, CommandType.Text);
                num2 = (int) num4 * -698414464 ^ 889862133;
                continue;
              case 2:
                ZoomDB.ExecuteCommndSQL(cChatCommand, sSQL);
                num2 = (int) num4 * -787329956 ^ 1961283533;
                continue;
              case 3:
                str2 = Resources.Generation1Style;
                break;
              case 4:
                num2 = (int) num4 * 1288398896 ^ 1981976454;
                continue;
              case 5:
                if (!this.IsGeneration2Style)
                {
                  num2 = (int) num4 * 872003056 ^ 157282930;
                  continue;
                }
                str2 = Resources.Generation2Style;
                break;
              case 6:
                num2 = (int) num4 * -514435487 ^ -1984222784;
                continue;
              case 7:
                sSQL = ZoomDB.\u206C⁬⁬⁭‮​‏⁪‍‎‎​‎‌⁮‌‬⁯⁪⁬⁫‪‏‪⁪‪‮⁪⁯⁯⁭‌​⁮‮‫‎⁮‍‬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1360521313U), (object) str1, (object) rawChatsToDelete.guid);
                num2 = (int) num4 * 861512702 ^ -196717373;
                continue;
              case 8:
                num2 = (int) num4 * -492050469 ^ -377958981;
                continue;
              default:
                goto label_28;
            }
            str1 = str2;
            num2 = -961681174;
          }
        }
        finally
        {
          if (cChatCommand != null)
          {
label_23:
            int num2 = -262578962;
            while (true)
            {
              int num3 = -1724648757;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  num2 = (int) num4 * -932612439 ^ 1307724860;
                  continue;
                case 1:
                  ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) cChatCommand);
                  num2 = (int) num4 * 507752562 ^ -1275356103;
                  continue;
                case 2:
                  goto label_23;
                default:
                  goto label_27;
              }
            }
          }
label_27:;
        }
label_28:
label_29:
        int num5 = -1375350834;
label_30:
        int num6 = -1724648757;
        uint num7;
        switch ((num7 = (uint) (num5 ^ num6)) % 3U)
        {
          case 0:
            return;
          case 1:
            break;
          case 2:
            goto label_29;
          default:
            return;
        }
label_31:
        num5 = -345639841;
        goto label_30;
      }
      catch (Exception ex)
      {
label_34:
        int num1 = -1283440333;
        while (true)
        {
          int num2 = -1724648757;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1359557244 ^ -763952930;
              continue;
            case 1:
              num1 = (int) num3 * -1049710786 ^ 985892392;
              continue;
            case 2:
              goto label_34;
            case 3:
              num1 = (int) num3 * 2030466214 ^ 618740069;
              continue;
            default:
              goto label_40;
          }
        }
label_40:
        throw ex;
      }
    }

    internal void DeleteChats(List<ZoomChatStruct> rawChatsToDelete)
    {
      using (List<ZoomChatStruct>.Enumerator enumerator = rawChatsToDelete.GetEnumerator())
      {
label_8:
        int num1 = enumerator.MoveNext() ? 1144459927 : (num1 = 1418302031);
        while (true)
        {
          int num2 = 548384172;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1477166161 ^ 227837283;
              continue;
            case 1:
              this.DeleteChat(enumerator.Current);
              num1 = 1742616898;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_9;
            case 4:
              num1 = 1144459927;
              continue;
            case 5:
              num1 = (int) num3 * -1455232268 ^ 50588164;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_9:;
      }
    }

    private static void ExecuteCommndSQL(SQLiteCommand cChatCommand, string sSQL)
    {
      try
      {
        ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) cChatCommand, sSQL);
label_2:
        int num1 = -650129504;
        while (true)
        {
          int num2 = -292281813;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_10;
            case 2:
              num1 = (int) num3 * 431888540 ^ -958787990;
              continue;
            case 3:
              ZoomDB.\u200B⁯‫⁪‪‏‌⁪‌‮‏⁭‍⁫⁯‮‍‭⁯​⁯⁫‭⁪‍⁭‌‎‭‏⁯‫⁯‮⁬‎​‪⁭‫‮((DbCommand) cChatCommand);
              num1 = (int) num3 * 2089470459 ^ 1450804212;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_10:;
      }
      catch (Exception ex)
      {
label_8:
        int num1 = -1153128818;
        while (true)
        {
          int num2 = -292281813;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1001670144 ^ -646070956;
              continue;
            case 1:
              ZoomDB.\u206F⁭⁪⁮⁬⁯‮‫⁬‭‫‪‎⁬⁯⁮⁭⁯‭⁮‭‫⁯⁮‫‮‭‌‎⁫⁯‭⁯⁬​⁫‭⁭⁯‪‮(CoreObject.log, (object) ZoomDB.\u202E‫‫‪⁯⁬⁭‭⁯‮​‎‏‌‌⁭‏‌⁬‬‌​‬‌⁭⁪‬‪‏‭‏‪⁮⁮‪‏‭‏‫‮‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4125068523U), sSQL, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(58755584U)), ex);
              num1 = (int) num3 * -743886045 ^ 1926585148;
              continue;
            case 2:
              goto label_8;
            default:
              goto label_13;
          }
        }
label_13:
        throw ex;
      }
    }

    public List<ZoomChatStruct> GetNewChats()
    {
label_1:
      int num1 = -952138523;
      List<ZoomChatStruct> zoomChatStructList1;
      while (true)
      {
        int num2 = -32020646;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            zoomChatStructList1 = new List<ZoomChatStruct>();
            num1 = (int) num3 * -1303482598 ^ 1282116971;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        bool flag1 = this.OpenChatConnection();
label_6:
        int num2 = -1385446561;
        while (true)
        {
          int num3 = -32020646;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_6;
            case 1:
              if (flag1)
              {
                num2 = (int) num4 * 515002401 ^ -2030359604;
                continue;
              }
              goto label_43;
            case 3:
              num2 = (int) num4 * -270900636 ^ -2028142224;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        SQLiteCommand sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cChat);
        try
        {
label_13:
          int num3 = -299123129;
          while (true)
          {
            int num4 = -32020646;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 3U)
            {
              case 1:
                ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
                ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, ZoomDB.\u202A​‪⁪⁯⁪‍‎⁮‫‏‭‪‍‏‏⁬‏⁬⁪‫⁫‫‪⁮⁪⁬‭‪‮‫⁬⁪⁪⁫‏‍‮⁯‎‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1100103163U), this.IsGeneration2Style ? (object) Resources.Generation2Style : (object) Resources.Generation1Style));
                num3 = -797020969;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_16;
            }
          }
label_16:
          SQLiteDataReader _reader;
          SQLiteDataReader sqLiteDataReader = _reader = ZoomDB.\u200E‭‫⁫‭⁯⁯‬‭​‮‎‎‍⁫‬‏⁯‍‪‭‮⁪‍⁬⁪‍‎‮⁪‮‏‎‬‌‏⁪‪⁪⁭‮(sqLiteCommand);
          try
          {
label_18:
            int num4 = -1217057050;
            while (true)
            {
              int num5 = -32020646;
              uint num6;
              bool flag2;
              switch ((num6 = (uint) (num4 ^ num5)) % 8U)
              {
                case 0:
                  goto label_18;
                case 2:
                  zoomChatStructList1.Add(new ZoomChatStruct(_reader));
                  num4 = -197902164;
                  continue;
                case 3:
                  flag2 = ZoomDB.\u206F‫‍‬⁮‫‍⁭‮‍‪⁯​⁯‮‌‪⁭⁪‮⁫⁯⁭⁮⁫‌​‎‪⁬⁯⁮‪‎⁪‍‪‮‌‍‮((DbDataReader) _reader);
                  num4 = -1463326363;
                  continue;
                case 4:
                  num4 = (int) num6 * 208811093 ^ 1264846869;
                  continue;
                case 5:
                  num4 = (int) num6 * 918653192 ^ -930699119;
                  continue;
                case 6:
                  num4 = (int) num6 * -1962769486 ^ 391550091;
                  continue;
                case 7:
                  int num7 = !flag2 ? 1401169914 : (num7 = 632378641);
                  int num8 = (int) num6 * -1252981529;
                  num4 = num7 ^ num8;
                  continue;
                default:
                  goto label_37;
              }
            }
          }
          finally
          {
            if (sqLiteDataReader != null)
            {
label_27:
              int num4 = -1343015263;
              while (true)
              {
                int num5 = -32020646;
                uint num6;
                switch ((num6 = (uint) (num4 ^ num5)) % 3U)
                {
                  case 0:
                    goto label_27;
                  case 2:
                    ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) sqLiteDataReader);
                    num4 = (int) num6 * 1218408849 ^ 2060136466;
                    continue;
                  default:
                    goto label_30;
                }
              }
            }
label_30:;
          }
        }
        finally
        {
          if (sqLiteCommand != null)
          {
label_32:
            int num3 = -1150762077;
            while (true)
            {
              int num4 = -32020646;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 0:
                  goto label_32;
                case 1:
                  ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) sqLiteCommand);
                  num3 = (int) num5 * 1611432734 ^ 1460839067;
                  continue;
                case 3:
                  num3 = (int) num5 * 1813361293 ^ -2101600237;
                  continue;
                default:
                  goto label_36;
              }
            }
          }
label_36:;
        }
label_37:;
      }
      catch (Exception ex)
      {
        ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
label_39:
        int num2 = -1746466260;
        while (true)
        {
          int num3 = -32020646;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_39;
            case 2:
              num2 = (int) num4 * -329308220 ^ -284205331;
              continue;
            default:
              goto label_42;
          }
        }
label_42:
        throw;
      }
label_43:
      List<ZoomChatStruct> zoomChatStructList2 = zoomChatStructList1;
label_44:
      int num9 = -951751639;
      while (true)
      {
        int num2 = -32020646;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 3U)
        {
          case 0:
            goto label_44;
          case 1:
            num9 = (int) num3 * 1490629692 ^ -412409170;
            continue;
          default:
            goto label_47;
        }
      }
label_47:
      return zoomChatStructList2;
    }

    internal List<string> GetPreviousZoomRooms()
    {
label_1:
      int num1 = 1407720457;
      List<string> stringList1;
      while (true)
      {
        int num2 = 951835683;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            stringList1 = new List<string>();
            num1 = (int) num3 * 1816675332 ^ -934996265;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      SQLiteCommand sqLiteCommand = (SQLiteCommand) null;
      try
      {
        bool flag1 = this.OpenDBConnection();
label_6:
        int num2 = 1646018404;
        while (true)
        {
          int num3 = 951835683;
          uint num4;
          string str;
          string[] strArray1;
          string[] strArray2;
          int index;
          object obj;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 27U)
          {
            case 0:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3597579840U));
              num2 = (int) num4 * -1536439622 ^ 891288206;
              continue;
            case 1:
              index = 0;
              num2 = (int) num4 * 1701861684 ^ 641890655;
              continue;
            case 2:
              num2 = 1477822566;
              continue;
            case 3:
              num2 = (int) num4 * -1881707882 ^ 810583914;
              continue;
            case 4:
              num2 = (int) num4 * 369830408 ^ -1455825352;
              continue;
            case 5:
              num2 = (int) num4 * -987853841 ^ 1775153516;
              continue;
            case 6:
              num2 = (int) num4 * -1056004990 ^ -1342975275;
              continue;
            case 7:
              int num5;
              num2 = num5 = index >= strArray2.Length ? 929218095 : (num5 = 1887986163);
              continue;
            case 9:
              strArray2 = strArray1;
              num2 = (int) num4 * 2011030027 ^ 1294017033;
              continue;
            case 10:
              num2 = (int) num4 * 841523576 ^ 1357184313;
              continue;
            case 11:
              num2 = 538093580;
              continue;
            case 12:
              num2 = (int) num4 * -1336183676 ^ -1371223437;
              continue;
            case 13:
              goto label_6;
            case 14:
              ++index;
              num2 = (int) num4 * 858740662 ^ -945033980;
              continue;
            case 15:
              int num6 = !flag1 ? -298590242 : (num6 = -34383846);
              int num7 = (int) num4 * 1321746078;
              num2 = num6 ^ num7;
              continue;
            case 16:
              str = strArray2[index];
              flag2 = ZoomDB.\u206F‌‫⁭‭‫‏‍‪‭⁪⁫⁪‌‮⁬‍‫‬‭‭‪⁮‭⁬⁪‍‬‪‎⁫‪⁮‬⁬⁪‮‏⁪‪‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1683746435U)) > 0;
              num2 = 29626362;
              continue;
            case 17:
              num2 = (int) num4 * -742922407 ^ -815907466;
              continue;
            case 18:
              int num8 = flag2 ? -493022852 : (num8 = -599211811);
              int num9 = (int) num4 * 2064695359;
              num2 = num8 ^ num9;
              continue;
            case 19:
              num2 = 23332128;
              continue;
            case 20:
              int num10 = obj != null ? 131930869 : (num10 = 450388070);
              int num11 = (int) num4 * -507770391;
              num2 = num10 ^ num11;
              continue;
            case 21:
              obj = ZoomDB.\u206D‍‎⁪⁪⁮​‎​‎‌‭⁯⁯‭‭‎‭‬‍‍⁫⁪⁪‮‎‬⁫⁭‭‏⁬‬⁮⁮‍⁭​⁬‬‮(sqLiteCommand, CommandBehavior.SingleRow);
              num2 = (int) num4 * -515764366 ^ -1108908966;
              continue;
            case 22:
              strArray1 = ZoomDB.\u206A⁮⁬⁮⁫‬‭⁭‎⁯‫‭‫‏​‬⁭⁫⁮⁪‎⁫‭​⁬⁪‌‍‫⁯‮‬‮‫⁭⁪‌‎‏⁭‮(ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(obj), new char[1]
              {
                ';'
              });
              num2 = (int) num4 * 1134420258 ^ -959350355;
              continue;
            case 23:
              stringList1.Add(str);
              num2 = (int) num4 * -1122986917 ^ 324494404;
              continue;
            case 24:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * 777747150 ^ -591734053;
              continue;
            case 25:
              stringList1.Add(ZoomDB.\u202D⁯‭‮‎‭‌‌⁫⁮⁫‍‭⁫‏⁪⁫‮‪‎⁬‫‭‏⁮‎‏‭‪‮⁪⁬⁮‪‭⁫⁮‍‫‭‮(str, 0, ZoomDB.\u206F‌‫⁭‭‫‏‍‪‭⁪⁫⁪‌‮⁬‍‫‬‭‭‪⁮‭⁬⁪‍‬‪‎⁫‪⁮‬⁬⁪‮‏⁪‪‮(str, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3157271136U))));
              num2 = (int) num4 * 1212486569 ^ 1688210544;
              continue;
            case 26:
              num2 = (int) num4 * -1801796497 ^ 617342098;
              continue;
            default:
              goto label_38;
          }
        }
      }
      catch (Exception ex)
      {
label_34:
        int num2 = 1393502110;
        while (true)
        {
          int num3 = 951835683;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_34;
            case 1:
              num2 = (int) num4 * 1358534874 ^ 102522622;
              continue;
            case 3:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * -564657301 ^ 6610688;
              continue;
            default:
              goto label_38;
          }
        }
      }
label_38:
      List<string> stringList2 = stringList1;
label_39:
      int num12 = 2130562108;
      while (true)
      {
        int num2 = 951835683;
        uint num3;
        switch ((num3 = (uint) (num12 ^ num2)) % 3U)
        {
          case 0:
            goto label_39;
          case 1:
            num12 = (int) num3 * 419602259 ^ 1717683236;
            continue;
          default:
            goto label_42;
        }
      }
label_42:
      return stringList2;
    }

    internal string GetZoomClientGUID()
    {
      string str = string.Empty;
      SQLiteCommand sqLiteCommand = (SQLiteCommand) null;
      try
      {
        bool flag = this.OpenDBConnection();
label_2:
        int num1 = -2141337843;
        while (true)
        {
          int num2 = -1415120487;
          uint num3;
          object obj;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = -503915627;
              continue;
            case 2:
              num1 = (int) num3 * 1816737847 ^ -903228486;
              continue;
            case 3:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2301676282U));
              num1 = (int) num3 * 508572378 ^ 1146030885;
              continue;
            case 4:
              int num4 = !flag ? 10026096 : (num4 = 2032791814);
              int num5 = (int) num3 * 1943390715;
              num1 = num4 ^ num5;
              continue;
            case 5:
              ZoomDB.\u200F‭‬‮‌‮​‮⁬‏‎‌⁪⁪‪‪‌‮‭⁭⁭⁮‭‍‬⁪‫⁮‮‍⁯‫‮‪‬‪⁫​‍‬‮(CoreObject.log, (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4071914968U));
              num1 = -1056557208;
              continue;
            case 6:
              num1 = (int) num3 * -1384558699 ^ -1858656234;
              continue;
            case 7:
              str = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(obj);
              num1 = (int) num3 * 1426546711 ^ -1771007022;
              continue;
            case 8:
              num1 = (int) num3 * 38414437 ^ 1973875416;
              continue;
            case 9:
              ZoomDB.\u202D‫‍‌‍⁮⁯⁮‌⁭‫​​‏‮⁯‬‮‏‮‬‌⁪⁯‍⁫‮‭‮‌‎‪‫‬‍‌⁪‪‏‏‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1180637462U), (object) str);
              num1 = (int) num3 * -1198790619 ^ 104995999;
              continue;
            case 10:
              num1 = (int) num3 * 681124329 ^ -143155075;
              continue;
            case 11:
              num1 = (int) num3 * 777702531 ^ 624478479;
              continue;
            case 13:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              obj = ZoomDB.\u200C‎‮⁬​⁬⁭⁪⁫⁭‫‭‌‏⁯⁫‮⁯⁮‭‪⁫‏⁪⁪‫‍‭⁯​​​⁯‪‍​⁭‮⁯‍‮((DbCommand) sqLiteCommand);
              num1 = (int) num3 * -765499642 ^ 1940457816;
              continue;
            case 14:
              num1 = -871545953;
              continue;
            case 15:
              int num6 = obj == null ? 1280252961 : (num6 = 1135986599);
              int num7 = (int) num3 * 1692945834;
              num1 = num6 ^ num7;
              continue;
            default:
              goto label_22;
          }
        }
      }
      catch (Exception ex)
      {
        ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
label_19:
        int num1 = -528644125;
        while (true)
        {
          int num2 = -1415120487;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_19;
            case 2:
              num1 = (int) num3 * 306328550 ^ -439911480;
              continue;
            default:
              goto label_22;
          }
        }
      }
label_22:
      return str;
    }

    internal bool SetZoomClientGUID(string sGUID)
    {
      bool flag1 = false;
      SQLiteCommand sqLiteCommand = (SQLiteCommand) null;
      try
      {
label_2:
        int num1 = 1125099868;
        while (true)
        {
          int num2 = 12648697;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 15U)
          {
            case 0:
              int num4 = !flag2 ? -985385882 : (num4 = -1506056906);
              int num5 = (int) num3 * 1569130897;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag1 = true;
              num1 = (int) num3 * -43060564 ^ 243155245;
              continue;
            case 3:
              num1 = 1567031790;
              continue;
            case 4:
              num1 = (int) num3 * -1103039137 ^ -767044366;
              continue;
            case 5:
              int num6 = ZoomDB.\u200B⁯‫⁪‪‏‌⁪‌‮‏⁭‍⁫⁯‮‍‭⁯​⁯⁫‭⁪‍⁭‌‎‭‏⁯‫⁯‮⁬‎​‪⁭‫‮((DbCommand) sqLiteCommand) <= 0 ? -1828995993 : (num6 = -81363973);
              int num7 = (int) num3 * -1923989891;
              num1 = num6 ^ num7;
              continue;
            case 6:
              num1 = (int) num3 * 1979423599 ^ 1239237194;
              continue;
            case 7:
              flag2 = this.OpenDBConnection();
              num1 = (int) num3 * -2026814682 ^ -1976138609;
              continue;
            case 8:
              goto label_2;
            case 9:
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, ZoomDB.\u202A​‪⁪⁯⁪‍‎⁮‫‏‭‪‍‏‏⁬‏⁬⁪‫⁫‫‪⁮⁪⁬‭‪‮‫⁬⁪⁪⁫‏‍‮⁯‎‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2948128861U), (object) sGUID));
              num1 = (int) num3 * -937154382 ^ -1269740434;
              continue;
            case 10:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              num1 = (int) num3 * 381951823 ^ 1898842665;
              continue;
            case 11:
              num1 = (int) num3 * 2141524852 ^ -276094380;
              continue;
            case 12:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * 849089516 ^ 1769012381;
              continue;
            case 13:
              num1 = 937584346;
              continue;
            case 14:
              num1 = (int) num3 * -733549154 ^ 1123888529;
              continue;
            default:
              goto label_23;
          }
        }
      }
      catch (Exception ex)
      {
label_18:
        int num1 = 86364142;
        while (true)
        {
          int num2 = 12648697;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_18;
            case 1:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 97767800 ^ -34693983;
              continue;
            case 2:
              num1 = (int) num3 * -2010067631 ^ -1346256576;
              continue;
            case 3:
              num1 = (int) num3 * 1395046847 ^ -1308449649;
              continue;
            default:
              goto label_23;
          }
        }
      }
label_23:
      return flag1;
    }

    internal bool ScrubMeeting(string meetingId)
    {
label_1:
      int num1 = -361664227;
      SQLiteCommand sqLiteCommand;
      string str1;
      while (true)
      {
        int num2 = -1865065969;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            List<string> stringList = new List<string>();
            sqLiteCommand = (SQLiteCommand) null;
            str1 = string.Empty;
            num1 = (int) num3 * 1164728031 ^ -1185889765;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
label_6:
        int num2 = -1928223906;
        while (true)
        {
          int num3 = -1865065969;
          uint num4;
          bool flag2;
          string str2;
          bool flag3;
          bool flag4;
          object obj;
          switch ((num4 = (uint) (num2 ^ num3)) % 22U)
          {
            case 0:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(476254051U));
              num2 = (int) num4 * 1463452979 ^ -2004496280;
              continue;
            case 1:
              int num5 = flag4 ? 1597822951 : (num5 = 2127105154);
              int num6 = (int) num4 * 1401049415;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = -1321588527;
              continue;
            case 3:
              flag3 = obj != null;
              num2 = (int) num4 * -1546371778 ^ -709566919;
              continue;
            case 4:
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str2);
              ZoomDB.\u200B⁯‫⁪‪‏‌⁪‌‮‏⁭‍⁫⁯‮‍‭⁯​⁯⁫‭⁪‍⁭‌‎‭‏⁯‫⁯‮⁬‎​‪⁭‫‮((DbCommand) sqLiteCommand);
              num2 = (int) num4 * 1863285698 ^ -1334990924;
              continue;
            case 5:
              str2 = ZoomDB.\u202E‫‫‪⁯⁬⁭‭⁯‮​‎‏‌‌⁭‏‌⁬‬‌​‬‌⁭⁪‬‪‏‭‏‪⁮⁮‪‏‭‏‫‮‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4029396714U), str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3630352769U));
              num2 = -1673631151;
              continue;
            case 6:
              str1 = ZoomDB.\u206B‬⁬‍‭⁫⁮⁮⁬‌‪⁫‮⁭​⁭‍‮‬‍‬‭⁭‏⁮‫‪‫‬⁭‎​⁫‮⁪‎⁭‪‭‍‮(ZoomDB.\u206B‬⁬‍‭⁫⁮⁮⁬‌‪⁫‮⁭​⁭‍‮‬‍‬‭⁭‏⁮‫‪‫‬⁭‎​⁫‮⁪‎⁭‪‭‍‮(str1, meetingId, ""), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2791357287U), "");
              num2 = (int) num4 * 869133571 ^ -1511841390;
              continue;
            case 7:
              num2 = (int) num4 * -5730180 ^ 1774865279;
              continue;
            case 8:
              int num7 = !flag3 ? -1494406769 : (num7 = -596064299);
              int num8 = (int) num4 * 1508676620;
              num2 = num7 ^ num8;
              continue;
            case 9:
              flag4 = this.OpenDBConnection();
              num2 = (int) num4 * 105382979 ^ 638804575;
              continue;
            case 10:
              num2 = (int) num4 * 86406187 ^ -763566853;
              continue;
            case 11:
              flag1 = true;
              num2 = (int) num4 * 1147483587 ^ 831894710;
              continue;
            case 12:
              str1 = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(obj);
              num2 = (int) num4 * -262509229 ^ -1398654195;
              continue;
            case 13:
              int num9 = !flag2 ? -496721743 : (num9 = -444052777);
              int num10 = (int) num4 * 1700732635;
              num2 = num9 ^ num10;
              continue;
            case 14:
              num2 = -315580681;
              continue;
            case 15:
              num2 = (int) num4 * 303378754 ^ -943533034;
              continue;
            case 16:
              flag2 = ZoomDB.\u202A⁬⁬‎⁭‭⁮‎‎⁭‪‎‍⁬⁪‬‌⁮​‏‎‏⁫⁯⁬‮‍‫⁪‌‬‬⁮⁬⁯⁫‮‫⁬‪‮(str1, meetingId);
              num2 = (int) num4 * 273078893 ^ 1820077416;
              continue;
            case 17:
              num2 = (int) num4 * 1251640153 ^ -1554846808;
              continue;
            case 18:
              goto label_6;
            case 19:
              obj = ZoomDB.\u206D‍‎⁪⁪⁮​‎​‎‌‭⁯⁯‭‭‎‭‬‍‍⁫⁪⁪‮‎‬⁫⁭‭‏⁬‬⁮⁮‍⁭​⁬‬‮(sqLiteCommand, CommandBehavior.Default);
              num2 = (int) num4 * -1377571740 ^ -1345408872;
              continue;
            case 21:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * 1387007034 ^ 1400351934;
              continue;
            default:
              goto label_32;
          }
        }
      }
      catch (Exception ex)
      {
label_29:
        int num2 = -806621199;
        while (true)
        {
          int num3 = -1865065969;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * 1063303102 ^ -1169929744;
              continue;
            case 2:
              goto label_29;
            default:
              goto label_32;
          }
        }
      }
label_32:
      return flag1;
    }

    internal bool SetZoomUserNameForJoin(string sUserName, bool forceLogout = true)
    {
label_1:
      int num1 = 1948433420;
      bool flag1;
      while (true)
      {
        int num2 = 127111320;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            flag1 = false;
            num1 = (int) num3 * -948782449 ^ 649502091;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      SQLiteCommand sqLiteCommand = (SQLiteCommand) null;
      try
      {
label_6:
        int num2 = 1497813376;
        while (true)
        {
          int num3 = 127111320;
          uint num4;
          bool flag2;
          int num5;
          bool flag3;
          switch ((num4 = (uint) (num2 ^ num3)) % 16U)
          {
            case 0:
              num2 = (int) num4 * -2033406298 ^ -667409541;
              continue;
            case 2:
              num2 = (int) num4 * 1936531682 ^ 178900176;
              continue;
            case 3:
              flag1 = true;
              num2 = (int) num4 * 1188297207 ^ -1941348481;
              continue;
            case 4:
              num2 = 1421507961;
              continue;
            case 5:
              flag3 = num5 > 0;
              num2 = (int) num4 * -1702382970 ^ -1417237640;
              continue;
            case 6:
              flag2 = this.OpenDBConnection();
              num2 = 915299921;
              continue;
            case 7:
              num2 = (int) num4 * 639910388 ^ -1581113237;
              continue;
            case 8:
              int num6 = this.IsLoggedIn() & forceLogout ? -1614790965 : (num6 = -1979421978);
              int num7 = (int) num4 * 1633960351;
              num2 = num6 ^ num7;
              continue;
            case 9:
              int num8 = !flag2 ? -404154056 : (num8 = -150795621);
              int num9 = (int) num4 * -330926012;
              num2 = num8 ^ num9;
              continue;
            case 10:
              goto label_6;
            case 11:
              num2 = (int) num4 * 698091962 ^ 1736030160;
              continue;
            case 12:
              num2 = 1009138780;
              continue;
            case 13:
              num5 = ZoomDB.\u200B⁯‫⁪‪‏‌⁪‌‮‏⁭‍⁫⁯‮‍‭⁯​⁯⁫‭⁪‍⁭‌‎‭‏⁯‫⁯‮⁬‎​‪⁭‫‮((DbCommand) sqLiteCommand);
              num2 = (int) num4 * 1749855751 ^ -495353562;
              continue;
            case 14:
              int num10 = flag3 ? -228191926 : (num10 = -951046794);
              int num11 = (int) num4 * 1624445823;
              num2 = num10 ^ num11;
              continue;
            case 15:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, ZoomDB.\u202A​‪⁪⁯⁪‍‎⁮‫‏‭‪‍‏‏⁬‏⁬⁪‫⁫‫‪⁮⁪⁬‭‪‮‫⁬⁪⁪⁫‏‍‮⁯‎‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3830007479U), (object) sUserName));
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * 459935382 ^ -1697482865;
              continue;
            default:
              goto label_27;
          }
        }
      }
      catch (Exception ex)
      {
label_23:
        int num2 = 1514210798;
        while (true)
        {
          int num3 = 127111320;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * -2113673894 ^ 463767522;
              continue;
            case 2:
              num2 = (int) num4 * 1667821087 ^ 398171795;
              continue;
            case 3:
              goto label_23;
            default:
              goto label_27;
          }
        }
      }
label_27:
      bool flag4 = flag1;
label_28:
      int num12 = 576360831;
      while (true)
      {
        int num2 = 127111320;
        uint num3;
        switch ((num3 = (uint) (num12 ^ num2)) % 3U)
        {
          case 0:
            goto label_28;
          case 2:
            num12 = (int) num3 * 1916174335 ^ -898778238;
            continue;
          default:
            goto label_31;
        }
      }
label_31:
      return flag4;
    }

    internal bool IsLoggedIn()
    {
label_1:
      int num1 = -1695679772;
      SQLiteCommand sqLiteCommand;
      while (true)
      {
        int num2 = -457493470;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            sqLiteCommand = (SQLiteCommand) null;
            num1 = (int) num3 * 899734828 ^ 1439947377;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = true;
      try
      {
label_6:
        int num2 = -326168300;
        while (true)
        {
          int num3 = -457493470;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              num2 = (int) num4 * 1953246253 ^ 1554350484;
              continue;
            case 2:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * -1948248971 ^ -16534519;
              continue;
            case 3:
              string str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3919446024U);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str);
              num2 = (int) num4 * 1187997369 ^ 63230622;
              continue;
            case 4:
              num2 = (int) num4 * 1088825470 ^ -1399411519;
              continue;
            case 5:
              goto label_6;
            case 6:
              if (this.OpenDBConnection())
              {
                num2 = (int) num4 * -836103867 ^ -1146256229;
                continue;
              }
              goto label_35;
            default:
              goto label_14;
          }
        }
label_14:
        SQLiteDataReader sqLiteDataReader1;
        SQLiteDataReader sqLiteDataReader2 = sqLiteDataReader1 = ZoomDB.\u200E‭‫⁫‭⁯⁯‬‭​‮‎‎‍⁫‬‏⁯‍‪‭‮⁪‍⁬⁪‍‎‮⁪‮‏‎‬‌‏⁪‪⁪⁭‮(sqLiteCommand);
        try
        {
          bool flag2 = ZoomDB.\u200D‎‌‍‌⁬⁯‬‎‍⁭⁮⁪‬⁯⁬⁫⁮⁮​‌⁬⁯⁪‮‮⁮‮⁪⁭‪⁯‮‎⁯⁮‬‬⁬⁪‮((DbDataReader) sqLiteDataReader1);
label_16:
          int num3 = -777856488;
          while (true)
          {
            int num4 = -457493470;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 10U)
            {
              case 0:
                flag1 = false;
                num3 = (int) num5 * -1788785692 ^ -543226088;
                continue;
              case 1:
                num3 = -172171814;
                continue;
              case 2:
                num3 = -1220138545;
                continue;
              case 3:
                goto label_16;
              case 4:
                int num6 = !flag2 ? -1635661033 : (num6 = -1055474470);
                int num7 = (int) num5 * 1259666254;
                num3 = num6 ^ num7;
                continue;
              case 5:
                num3 = (int) num5 * 1128941976 ^ -1446340740;
                continue;
              case 6:
                num3 = (int) num5 * 98675602 ^ -1886830512;
                continue;
              case 8:
                flag1 = true;
                num3 = (int) num5 * -1225787454 ^ 1552177075;
                continue;
              case 9:
                num3 = (int) num5 * -1439367645 ^ 570759356;
                continue;
              default:
                goto label_32;
            }
          }
        }
        finally
        {
          if (sqLiteDataReader2 != null)
          {
label_27:
            int num3 = -179899403;
            while (true)
            {
              int num4 = -457493470;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 0:
                  goto label_27;
                case 1:
                  num3 = (int) num5 * 2049994701 ^ 1630214961;
                  continue;
                case 3:
                  ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) sqLiteDataReader2);
                  num3 = (int) num5 * -852149319 ^ -1281274316;
                  continue;
                default:
                  goto label_31;
              }
            }
          }
label_31:;
        }
label_32:
label_33:
        int num8 = -1853080274;
label_34:
        int num9 = -457493470;
        uint num10;
        switch ((num10 = (uint) (num8 ^ num9)) % 3U)
        {
          case 1:
            break;
          case 2:
            goto label_33;
          default:
            goto label_42;
        }
label_35:
        num8 = -1238835699;
        goto label_34;
      }
      catch (Exception ex)
      {
label_37:
        int num2 = -1028927650;
        while (true)
        {
          int num3 = -457493470;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * 2042036677 ^ -313612480;
              continue;
            case 1:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * 1116483212 ^ -1991484462;
              continue;
            case 3:
              goto label_37;
            case 4:
              num2 = (int) num4 * 8389162 ^ -1675365687;
              continue;
            default:
              goto label_42;
          }
        }
      }
label_42:
      bool flag3 = flag1;
label_43:
      int num11 = -1218420722;
      while (true)
      {
        int num2 = -457493470;
        uint num3;
        switch ((num3 = (uint) (num11 ^ num2)) % 3U)
        {
          case 0:
            goto label_43;
          case 1:
            num11 = (int) num3 * -1586052200 ^ -1780615265;
            continue;
          default:
            goto label_46;
        }
      }
label_46:
      return flag3;
    }

    internal bool IsLoginBackedup()
    {
label_1:
      int num1 = -259888126;
      SQLiteCommand sqLiteCommand;
      while (true)
      {
        int num2 = -51943107;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            sqLiteCommand = (SQLiteCommand) null;
            num1 = (int) num3 * 1420940738 ^ 889851015;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = true;
      try
      {
label_6:
        int num2 = -7343175;
        while (true)
        {
          int num3 = -51943107;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 9U)
          {
            case 0:
              goto label_6;
            case 1:
              if (flag2)
              {
                num2 = (int) num4 * 1145119934 ^ 1625332052;
                continue;
              }
              goto label_37;
            case 2:
              num2 = (int) num4 * -637017843 ^ 64151027;
              continue;
            case 3:
              flag2 = this.OpenDBConnection();
              num2 = (int) num4 * -2140454232 ^ 47612133;
              continue;
            case 4:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * 1182303825 ^ -455425439;
              continue;
            case 5:
              num2 = (int) num4 * -1537685851 ^ -232607219;
              continue;
            case 6:
              string str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4093840787U);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str);
              num2 = (int) num4 * 1680033644 ^ 990839955;
              continue;
            case 7:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              num2 = (int) num4 * 300712478 ^ 988828670;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        SQLiteDataReader sqLiteDataReader1;
        SQLiteDataReader sqLiteDataReader2 = sqLiteDataReader1 = ZoomDB.\u200E‭‫⁫‭⁯⁯‬‭​‮‎‎‍⁫‬‏⁯‍‪‭‮⁪‍⁬⁪‍‎‮⁪‮‏‎‬‌‏⁪‪⁪⁭‮(sqLiteCommand);
        try
        {
label_18:
          int num3 = -1451121394;
          while (true)
          {
            int num4 = -51943107;
            uint num5;
            bool flag2;
            switch ((num5 = (uint) (num3 ^ num4)) % 10U)
            {
              case 0:
                num3 = (int) num5 * -489207780 ^ 995798643;
                continue;
              case 1:
                flag1 = false;
                num3 = -2126266560;
                continue;
              case 2:
                goto label_18;
              case 3:
                num3 = -1097277012;
                continue;
              case 4:
                num3 = (int) num5 * 842597301 ^ 277267942;
                continue;
              case 5:
                num3 = (int) num5 * -1102664131 ^ 2056230718;
                continue;
              case 6:
                flag1 = true;
                num3 = (int) num5 * 1661965453 ^ -240740235;
                continue;
              case 7:
                flag2 = ZoomDB.\u200D‎‌‍‌⁬⁯‬‎‍⁭⁮⁪‬⁯⁬⁫⁮⁮​‌⁬⁯⁪‮‮⁮‮⁪⁭‪⁯‮‎⁯⁮‬‬⁬⁪‮((DbDataReader) sqLiteDataReader1);
                num3 = (int) num5 * -1870222521 ^ 739900308;
                continue;
              case 8:
                int num6 = !flag2 ? -240442618 : (num6 = -345678330);
                int num7 = (int) num5 * -39994035;
                num3 = num6 ^ num7;
                continue;
              default:
                goto label_34;
            }
          }
        }
        finally
        {
          if (sqLiteDataReader2 != null)
          {
label_29:
            int num3 = -724770376;
            while (true)
            {
              int num4 = -51943107;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 1:
                  ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) sqLiteDataReader2);
                  num3 = (int) num5 * 561433242 ^ 1738273797;
                  continue;
                case 2:
                  num3 = (int) num5 * 1940897830 ^ 812930765;
                  continue;
                case 3:
                  goto label_29;
                default:
                  goto label_33;
              }
            }
          }
label_33:;
        }
label_34:
label_35:
        int num8 = -488553445;
label_36:
        int num9 = -51943107;
        uint num10;
        switch ((num10 = (uint) (num8 ^ num9)) % 3U)
        {
          case 0:
            goto label_35;
          case 2:
            break;
          default:
            goto label_39;
        }
label_37:
        num8 = -2111535504;
        goto label_36;
      }
      catch (Exception ex)
      {
        ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
      }
label_39:
      bool flag3 = flag1;
label_40:
      int num11 = -1991112948;
      while (true)
      {
        int num2 = -51943107;
        uint num3;
        switch ((num3 = (uint) (num11 ^ num2)) % 3U)
        {
          case 0:
            goto label_40;
          case 1:
            num11 = (int) num3 * 20554357 ^ -1237382717;
            continue;
          default:
            goto label_43;
        }
      }
label_43:
      return flag3;
    }

    internal void ExecuteSQL(string SQL)
    {
      SQLiteCommand sqLiteCommand = (SQLiteCommand) null;
      try
      {
label_2:
        int num1 = -1896919614;
        while (true)
        {
          int num2 = -760673330;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, SQL);
              num1 = (int) num3 * -1027893147 ^ 1837877916;
              continue;
            case 1:
              flag = this.OpenDBConnection();
              num1 = (int) num3 * -1570038373 ^ 1094943749;
              continue;
            case 2:
              int num4 = flag ? -485762305 : (num4 = -13320857);
              int num5 = (int) num3 * -906357505;
              num1 = num4 ^ num5;
              continue;
            case 3:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * -245092042 ^ -1633145334;
              continue;
            case 4:
              goto label_2;
            case 5:
              ZoomDB.\u200B⁯‫⁪‪‏‌⁪‌‮‏⁭‍⁫⁯‮‍‭⁯​⁯⁫‭⁪‍⁭‌‎‭‏⁯‫⁯‮⁬‎​‪⁭‫‮((DbCommand) sqLiteCommand);
              num1 = (int) num3 * 1837418169 ^ 355613647;
              continue;
            case 6:
              goto label_12;
            case 7:
              num1 = (int) num3 * -245322399 ^ 1062018367;
              continue;
            case 8:
              num1 = -1859274702;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_12:;
      }
      catch (Exception ex)
      {
        ZoomDB.\u206F⁭⁪⁮⁬⁯‮‫⁬‭‫‪‎⁬⁯⁮⁭⁯‭⁮‭‫⁯⁮‫‮‭‌‎⁫⁯‭⁯⁬​⁫‭⁭⁯‪‮(CoreObject.log, (object) ZoomDB.\u200F⁮‭⁮⁮‏‎‌‍‍⁬‎‮⁬‫‫⁮‮‌‌‎​‫‫⁪⁮‮‭⁯⁭‪⁪⁬‎⁬‫⁯⁯‪⁮‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(152198780U), SQL), ex);
        throw;
      }
    }

    internal void Logout(bool backupAccount = true)
    {
      if (!backupAccount)
        goto label_7;
label_1:
      int num1 = 1361920341;
label_2:
      while (true)
      {
        int num2 = 1199080874;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this.ExecuteSQL(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4231813331U));
            num1 = 227859112;
            continue;
          case 1:
            this.ExecuteSQL(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3583999181U));
            num1 = (int) num3 * -898843481 ^ 1519036180;
            continue;
          case 2:
            num1 = (int) num3 * -299503804 ^ 37299138;
            continue;
          case 3:
            this.ExecuteSQL(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3624365097U));
            num1 = (int) num3 * -1452781811 ^ 1413866864;
            continue;
          case 4:
            goto label_3;
          case 5:
            goto label_1;
          case 6:
            goto label_6;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:
      return;
label_6:
      int num4 = this.IsLoggedIn() ? 1 : 0;
      goto label_8;
label_7:
      num4 = 0;
label_8:
      num1 = num4 == 0 ? 289390846 : (num1 = 446659339);
      goto label_2;
    }

    internal void RestoreLogin()
    {
label_1:
      int num1 = -295417182;
      while (true)
      {
        int num2 = -2105883658;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -505926833 ^ -2035390020;
            continue;
          case 2:
            this.ExecuteSQL(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2277928503U));
            num1 = (int) num3 * 152831636 ^ -1001440388;
            continue;
          case 4:
            this.ExecuteSQL(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1624295722U));
            num1 = (int) num3 * 774933505 ^ 1219635129;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      this.ExecuteSQL(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2566383538U));
    }

    internal bool GetZoomNames(out string sZoomName, out string sZoomEmail)
    {
      SQLiteCommand sqLiteCommand = (SQLiteCommand) null;
      string str1 = "";
      string str2 = "";
      bool flag1 = false;
      try
      {
label_2:
        int num1 = 753395996;
        while (true)
        {
          int num2 = 919607185;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_2;
            case 1:
              if (this.OpenDBConnection())
              {
                num1 = (int) num3 * -803741840 ^ -432967838;
                continue;
              }
              goto label_42;
            case 3:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              string str3 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2995739882U);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str3);
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * -1022441020 ^ -640883493;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        SQLiteDataReader sqLiteDataReader1;
        SQLiteDataReader sqLiteDataReader2 = sqLiteDataReader1 = ZoomDB.\u200E‭‫⁫‭⁯⁯‬‭​‮‎‎‍⁫‬‏⁯‍‪‭‮⁪‍⁬⁪‍‎‮⁪‮‏‎‬‌‏⁪‪⁪⁭‮(sqLiteCommand);
        try
        {
label_9:
          int num2 = 2077596445;
          while (true)
          {
            int num3 = 919607185;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 12U)
            {
              case 0:
                goto label_9;
              case 1:
                num2 = (int) num4 * 42760601 ^ 1652903907;
                continue;
              case 2:
                int num5 = ZoomDB.\u200F‌⁬⁯‪⁮‏⁪⁯​‬⁭‍​‎‬​⁯‎‪⁮‎‏‮⁮‮⁫‮‎‬⁭‍‎‪‏⁬‍⁪​‏‮(str1, string.Empty) ? -362146070 : (num5 = -979651346);
                int num6 = (int) num4 * -1045103780;
                num2 = num5 ^ num6;
                continue;
              case 3:
                num2 = 1058724491;
                continue;
              case 4:
                flag1 = true;
                num2 = (int) num4 * -1709938562 ^ 1849097848;
                continue;
              case 5:
                int num7;
                num2 = num7 = ZoomDB.\u206F‫‍‬⁮‫‍⁭‮‍‪⁯​⁯‮‌‪⁭⁪‮⁫⁯⁭⁮⁫‌​‎‪⁬⁯⁮‪‎⁪‍‪‮‌‍‮((DbDataReader) sqLiteDataReader1) ? 992647307 : (num7 = 1389203898);
                continue;
              case 6:
                num2 = 926334448;
                continue;
              case 7:
                num2 = (int) num4 * 291908940 ^ -1548992535;
                continue;
              case 8:
                num2 = (int) num4 * 1550616670 ^ -1429170160;
                continue;
              case 9:
                str1 = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(ZoomDB.\u206E⁭⁪⁭‬‪‭⁪‍⁯‎‫‎⁪⁬⁭‭​⁬⁪‫⁪‭‏⁮⁭⁯⁭⁯⁯‎​‫‌‭‌⁯‬⁫‫‮((DbDataReader) sqLiteDataReader1, 0));
                sZoomEmail = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(ZoomDB.\u206E⁭⁪⁭‬‪‭⁪‍⁯‎‫‎⁪⁬⁭‭​⁬⁪‫⁪‭‏⁮⁭⁯⁭⁯⁯‎​‫‌‭‌⁯‬⁫‫‮((DbDataReader) sqLiteDataReader1, 1));
                num2 = (int) num4 * -902856880 ^ -1610019181;
                continue;
              case 11:
                num2 = 2131977080;
                continue;
              default:
                goto label_26;
            }
          }
        }
        finally
        {
          if (sqLiteDataReader2 != null)
          {
label_22:
            int num2 = 1120442764;
            while (true)
            {
              int num3 = 919607185;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_22;
                case 2:
                  ZoomDB.\u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮((IDisposable) sqLiteDataReader2);
                  num2 = (int) num4 * -66037392 ^ -133982936;
                  continue;
                default:
                  goto label_25;
              }
            }
          }
label_25:;
        }
label_26:
        if (flag1)
          goto label_29;
label_27:
        int num8 = 1548079763;
label_28:
        while (true)
        {
          int num2 = 919607185;
          uint num3;
          object obj;
          bool flag2;
          switch ((num3 = (uint) (num8 ^ num2)) % 10U)
          {
            case 0:
              goto label_27;
            case 1:
              num8 = 949670415;
              continue;
            case 3:
              str1 = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(obj);
              num8 = (int) num3 * 1348329016 ^ 1841054438;
              continue;
            case 4:
              string str3 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1375551531U);
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str3);
              obj = ZoomDB.\u206D‍‎⁪⁪⁮​‎​‎‌‭⁯⁯‭‭‎‭‬‍‍⁫⁪⁪‮‎‬⁫⁭‭‏⁬‬⁮⁮‍⁭​⁬‬‮(sqLiteCommand, CommandBehavior.Default);
              num8 = (int) num3 * 1368504008 ^ -971280736;
              continue;
            case 5:
              flag2 = obj != null;
              num8 = (int) num3 * -181768483 ^ -1408000853;
              continue;
            case 6:
              num8 = (int) num3 * 1005352633 ^ 1429753144;
              continue;
            case 7:
              int num4 = !flag2 ? -672914749 : (num4 = -1041786185);
              int num5 = (int) num3 * -1179443937;
              num8 = num4 ^ num5;
              continue;
            case 8:
              goto label_29;
            case 9:
              flag1 = true;
              num8 = (int) num3 * -1973402116 ^ 2011857255;
              continue;
            default:
              goto label_42;
          }
        }
label_29:
        num8 = 876193107;
        goto label_28;
      }
      catch (Exception ex)
      {
label_38:
        int num1 = 1180072608;
        while (true)
        {
          int num2 = 919607185;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_38;
            case 1:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 2055859044 ^ 1628826278;
              continue;
            case 3:
              num1 = (int) num3 * 16746662 ^ -524143519;
              continue;
            default:
              goto label_42;
          }
        }
      }
label_42:
      sZoomName = str1;
      sZoomEmail = str2;
      return flag1;
    }

    internal string GetZoomUserName(bool includeBackedUpValue = true)
    {
label_1:
      int num1 = 1159613558;
      SQLiteCommand sqLiteCommand;
      while (true)
      {
        int num2 = 1751538005;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -2095581262 ^ 1798947476;
            continue;
          case 2:
            goto label_1;
          case 3:
            sqLiteCommand = (SQLiteCommand) null;
            num1 = (int) num3 * 229909194 ^ 205269807;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      string str1 = (string) null;
      try
      {
label_7:
        int num2 = 1914789073;
        while (true)
        {
          int num3 = 1751538005;
          uint num4;
          object obj;
          string str2;
          bool flag1;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 23U)
          {
            case 0:
              int num5 = !flag1 ? 1358683136 : (num5 = 1283549875);
              int num6 = (int) num4 * -2080839503;
              num2 = num5 ^ num6;
              continue;
            case 1:
              num2 = (int) num4 * -1658686737 ^ -366690567;
              continue;
            case 2:
              goto label_7;
            case 3:
              num2 = (int) num4 * -1401647063 ^ -202290774;
              continue;
            case 4:
              num2 = (int) num4 * -1918927284 ^ 776247648;
              continue;
            case 5:
              num2 = (int) num4 * -227428568 ^ 883841831;
              continue;
            case 6:
              sqLiteCommand = ZoomDB.\u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮(this.cDB);
              num2 = (int) num4 * 1510548642 ^ 1867803654;
              continue;
            case 7:
              str1 = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(obj);
              num2 = (int) num4 * -1327665216 ^ -100847586;
              continue;
            case 8:
              str2 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2864711271U);
              num2 = (int) num4 * 1986049146 ^ 154227625;
              continue;
            case 9:
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, str2);
              num2 = (int) num4 * 1586609567 ^ 1408342229;
              continue;
            case 10:
              obj = ZoomDB.\u206D‍‎⁪⁪⁮​‎​‎‌‭⁯⁯‭‭‎‭‬‍‍⁫⁪⁪‮‎‬⁫⁭‭‏⁬‬⁮⁮‍⁭​⁬‬‮(sqLiteCommand, CommandBehavior.SingleRow);
              flag2 = obj != null;
              num2 = (int) num4 * -426304633 ^ 1366464176;
              continue;
            case 11:
              int num7 = !flag2 ? 950914323 : (num7 = 1131813552);
              int num8 = (int) num4 * -930653243;
              num2 = num7 ^ num8;
              continue;
            case 12:
              ZoomDB.\u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮((DbCommand) sqLiteCommand, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(853937829U));
              num2 = (int) num4 * 430184726 ^ 2037990532;
              continue;
            case 13:
              num2 = 69811904;
              continue;
            case 15:
              str1 = ZoomDB.\u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮(obj);
              num2 = (int) num4 * 1155877974 ^ -1293467037;
              continue;
            case 16:
              flag1 = this.OpenDBConnection();
              num2 = (int) num4 * 1058358036 ^ -881451579;
              continue;
            case 17:
              ZoomDB.\u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * -459367709 ^ -315884278;
              continue;
            case 18:
              int num9;
              num2 = num9 = ZoomDB.\u206D⁬‍‍‎​‫‎‌​⁮‌⁪‮‌‬​⁬⁫⁭⁮​⁮‫‍⁯⁬⁫‪‪‪⁯⁬‍‎‪⁫‫‏‮‮(str1) ? 1732332135 : (num9 = 103536734);
              continue;
            case 19:
              int num10 = obj != null ? -1771484327 : (num10 = -272590848);
              int num11 = (int) num4 * 1449480579;
              num2 = num10 ^ num11;
              continue;
            case 20:
              num2 = (int) num4 * 1532064256 ^ -1169757202;
              continue;
            case 21:
              num2 = 103536734;
              continue;
            case 22:
              obj = ZoomDB.\u206D‍‎⁪⁪⁮​‎​‎‌‭⁯⁯‭‭‎‭‬‍‍⁫⁪⁪‮‎‬⁫⁭‭‏⁬‬⁮⁮‍⁭​⁬‬‮(sqLiteCommand, CommandBehavior.SingleRow);
              num2 = (int) num4 * -748790027 ^ 1941024525;
              continue;
            default:
              goto label_34;
          }
        }
      }
      catch (Exception ex)
      {
label_31:
        int num2 = 1675488361;
        while (true)
        {
          int num3 = 1751538005;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_31;
            case 1:
              ZoomDB.\u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * -82604400 ^ -1732738610;
              continue;
            default:
              goto label_34;
          }
        }
      }
label_34:
      return str1;
    }

    internal bool HasAccountBackupTable()
    {
label_1:
      int num1 = -1236088983;
      bool flag;
      while (true)
      {
        int num2 = -2020425345;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 1:
            flag = false;
            num1 = -539339608;
            continue;
          case 2:
            int num4 = this.OpenDBConnection() ? 284302964 : (num4 = 1594710394);
            int num5 = (int) num3 * 383285824;
            num1 = num4 ^ num5;
            continue;
          case 3:
            flag = SQLiteHelper.TableExists(this.cDB, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1233698397U));
            num1 = (int) num3 * -654116337 ^ -2062352974;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * -211531390 ^ -312585287;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return flag;
    }

    static string \u202E‎⁬​⁬‪‫⁪⁮⁯‍⁬​⁬‫‬⁮⁬‮​‪‫‍⁯⁯‭‍‍⁭⁭‪⁯‎⁪⁬⁫⁮⁫⁮‬‮([In] string obj0)
    {
      return Path.GetDirectoryName(obj0);
    }

    static string \u200F⁮‭⁮⁮‏‎‌‍‍⁬‎‮⁬‫‫⁮‮‌‌‎​‫‫⁪⁮‮‭⁯⁭‪⁪⁬‎⁬‫⁯⁯‪⁮‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static string \u202A​‪⁪⁯⁪‍‎⁮‫‏‭‪‍‏‏⁬‏⁬⁪‫⁫‫‪⁮⁪⁬‭‪‮‫⁬⁪⁪⁫‏‍‮⁯‎‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u202D‫‍‌‍⁮⁯⁮‌⁭‫​​‏‮⁯‬‮‏‮‬‌⁪⁯‍⁫‮‭‮‌‎‪‫‬‍‌⁪‪‏‏‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static SQLiteConnection \u206E‪⁭⁬⁯⁫⁯⁪​‍​⁭‪‫‮‍‌⁬‮⁫‌‎‌⁫‬‏‏‪⁫⁭​‪⁯⁫‬⁪⁬⁭⁮‪‮([In] string obj0)
    {
      return new SQLiteConnection(obj0);
    }

    static void \u202C⁪‍⁯⁪⁯‌‮‏‍⁬​‫⁫⁫‮‫‬⁬‭‬⁫‫‪⁫⁭‭‪⁯‬‌⁫⁫⁬‎⁫‏⁫⁪⁫‮([In] DbConnection obj0)
    {
      obj0.Open();
    }

    static void \u200C⁪‎⁯​⁭⁬⁬‏‌‍‫⁭⁭⁪‎⁪⁫‎‍‏⁪‭⁭‬‮‮‏​⁮‫‌‪‌‭⁫⁬‫⁪‬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static ConnectionState \u206A⁫⁬‭⁪‍⁬‍‫‭⁬‎‭‪‍‏⁯‪‪⁯‌‌‎⁭‌‮⁬‭‪‫‏⁬⁬‮‎⁫‬​⁭⁪‮([In] DbConnection obj0)
    {
      return obj0.State;
    }

    static void \u200F​⁪‏‭⁬‌‫⁮‍‮⁬⁫‏‬‬‮⁫‏⁪‮‭​⁯‫‎‏⁮‏‭⁫‫⁬‍⁫‏‌⁫⁮‬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static SQLiteCommand \u202C⁬‎‌‏⁯‮‬⁬‎⁯‎⁪⁯‪‬‌‏⁭‪⁪⁯‮‫‮‫⁭‮‪⁪‪⁬‫⁫‬‬‎⁮‪⁬‮([In] SQLiteConnection obj0)
    {
      return obj0.CreateCommand();
    }

    static void \u202A⁮‏‭‏⁯⁫‮‪‪‍‪​⁫⁬‌‬‪​‬​‎‏⁭‌‮‭‮⁯​‫​‪‪⁪⁭‌⁪‬‍‮([In] DbCommand obj0, [In] CommandType obj1)
    {
      obj0.CommandType = obj1;
    }

    static void \u206A⁭‏‮​⁪‎⁬‌‫‬⁭‎‪‍⁫‭‫‫⁫⁬⁬‬⁮⁪‮​‫‮‬⁯‭‬‮‮‍‌‍‌‮‮([In] DbCommand obj0, [In] string obj1)
    {
      obj0.CommandText = obj1;
    }

    static SQLiteDataReader \u200E‭‫⁫‭⁯⁯‬‭​‮‎‎‍⁫‬‏⁯‍‪‭‮⁪‍⁬⁪‍‎‮⁪‮‏‎‬‌‏⁪‪⁪⁭‮([In] SQLiteCommand obj0)
    {
      return obj0.ExecuteReader();
    }

    static bool \u206F‫‍‬⁮‫‍⁭‮‍‪⁯​⁯‮‌‪⁭⁪‮⁫⁯⁭⁮⁫‌​‎‪⁬⁯⁮‪‎⁪‍‪‮‌‍‮([In] DbDataReader obj0)
    {
      return obj0.Read();
    }

    static void \u202D⁪⁭⁫‎‭⁬‮⁫‮‏⁬⁮⁫‏‮‮‌⁬‭⁪⁬⁬⁯‌⁬‮‎⁮‫⁮⁯‬⁪‏‏⁫⁬‏‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static object \u206D‍‎⁪⁪⁮​‎​‎‌‭⁯⁯‭‭‎‭‬‍‍⁫⁪⁪‮‎‬⁫⁭‭‏⁬‬⁮⁮‍⁭​⁬‬‮([In] SQLiteCommand obj0, [In] CommandBehavior obj1)
    {
      return obj0.ExecuteScalar(obj1);
    }

    static string \u200B⁯⁫‫⁪‫‪‏‭​‬‬⁫‏‌‮⁯‬‏‪⁮‪‪‬​⁭‎‌‪⁪⁫‌⁯​⁬⁯⁯‪‏⁭‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string[] \u206A⁮⁬⁮⁫‬‭⁭‎⁯‫‭‫‏​‬⁭⁫⁮⁪‎⁫‭​⁬⁪‌‍‫⁯‮‬‮‫⁭⁪‌‎‏⁭‮([In] string obj0, [In] char[] obj1)
    {
      return obj0.Split(obj1);
    }

    static string \u206C⁫​‌‌⁭⁬‭‌⁮‏‪‮‪‮⁫⁮‍‬‪‫‏⁫‭⁮⁫​‮‌‌⁯​​⁯‪‎‭⁫⁭⁬‮([In] object obj0, [In] object obj1, [In] object obj2)
    {
      return obj0.ToString() + obj1 + obj2;
    }

    static string \u202E‫‫‪⁯⁬⁭‭⁯‮​‎‏‌‌⁭‏‌⁬‬‌​‬‌⁭⁪‬‪‏‭‏‪⁮⁮‪‏‭‏‫‮‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0 + obj1 + obj2;
    }

    static int \u200B⁯‫⁪‪‏‌⁪‌‮‏⁭‍⁫⁯‮‍‭⁯​⁯⁫‭⁪‍⁭‌‎‭‏⁯‫⁯‮⁬‎​‪⁭‫‮([In] DbCommand obj0)
    {
      return obj0.ExecuteNonQuery();
    }

    static string \u206C⁬⁬⁭‮​‏⁪‍‎‎​‎‌⁮‌‬⁯⁪⁬⁫‪‏‪⁪‪‮⁪⁯⁯⁭‌​⁮‮‫‎⁮‍‬‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static void \u206F⁭⁪⁮⁬⁯‮‫⁬‭‫‪‎⁬⁯⁮⁭⁯‭⁮‭‫⁯⁮‫‮‭‌‎⁫⁯‭⁯⁬​⁫‭⁭⁯‪‮([In] ILog obj0, [In] object obj1, [In] Exception obj2)
    {
      obj0.Error(obj1, obj2);
    }

    static int \u206F‌‫⁭‭‫‏‍‪‭⁪⁫⁪‌‮⁬‍‫‬‭‭‪⁮‭⁬⁪‍‬‪‎⁫‪⁮‬⁬⁪‮‏⁪‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.IndexOf(obj1);
    }

    static string \u202D⁯‭‮‎‭‌‌⁫⁮⁫‍‭⁫‏⁪⁫‮‪‎⁬‫‭‏⁮‎‏‭‪‮⁪⁬⁮‪‭⁫⁮‍‫‭‮([In] string obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Substring(obj1, obj2);
    }

    static object \u200C‎‮⁬​⁬⁭⁪⁫⁭‫‭‌‏⁯⁫‮⁯⁮‭‪⁫‏⁪⁪‫‍‭⁯​​​⁯‪‍​⁭‮⁯‍‮([In] DbCommand obj0)
    {
      return obj0.ExecuteScalar();
    }

    static void \u200F‭‬‮‌‮​‮⁬‏‎‌⁪⁪‪‪‌‮‭⁭⁭⁮‭‍‬⁪‫⁮‮‍⁯‫‮‪‬‪⁫​‍‬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }

    static bool \u202A⁬⁬‎⁭‭⁮‎‎⁭‪‎‍⁬⁪‬‌⁮​‏‎‏⁫⁯⁬‮‍‫⁪‌‬‬⁮⁬⁯⁫‮‫⁬‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static string \u206B‬⁬‍‭⁫⁮⁮⁬‌‪⁫‮⁭​⁭‍‮‬‍‬‭⁭‏⁮‫‪‫‬⁭‎​⁫‮⁪‎⁭‪‭‍‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static bool \u200D‎‌‍‌⁬⁯‬‎‍⁭⁮⁪‬⁯⁬⁫⁮⁮​‌⁬⁯⁪‮‮⁮‮⁪⁭‪⁯‮‎⁯⁮‬‬⁬⁪‮([In] DbDataReader obj0)
    {
      return obj0.HasRows;
    }

    static object \u206E⁭⁪⁭‬‪‭⁪‍⁯‎‫‎⁪⁬⁭‭​⁬⁪‫⁪‭‏⁮⁭⁯⁭⁯⁯‎​‫‌‭‌⁯‬⁫‫‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0.GetValue(obj1);
    }

    static bool \u200F‌⁬⁯‪⁮‏⁪⁯​‬⁭‍​‎‬​⁯‎‪⁮‎‏‮⁮‮⁫‮‎‬⁭‍‎‪‏⁬‍⁪​‏‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u206D⁬‍‍‎​‫‎‌​⁮‌⁪‮‌‬​⁬⁫⁭⁮​⁮‫‍⁯⁬⁫‪‪‪⁯⁬‍‎‪⁫‫‏‮‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static object \u202C‎‌‍‎‭‏⁮‍‫​‌‫⁭‎‎‮‍‏‫⁮⁫⁬⁬‬‬‪⁫⁫⁮‌‎‫‭‏⁫⁫‮​‬‮()
    {
      return new object();
    }
  }
}
