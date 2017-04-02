// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomZoomDatabase
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using ZoomZoom.Models.Chats;
using ZoomZoom.Properties;

namespace ZoomZoom
{
  internal class ZoomZoomDatabase : CoreObject
  {
    private new static ILog log = ZoomZoomDatabase.\u202D⁬​⁬‬⁪‮⁭‎‫‭‍‌⁮‏‏‭⁬‮⁪‍‬‬⁬‫⁫⁭⁯‪​⁬‎​‭‫⁬⁭‭‏‫‮(ZoomZoomDatabase.\u202E‍‭⁭‪‍⁪⁪‌‮‮‭‌⁫⁫⁭⁯‮​‪‏‫⁯‏⁭​‌‬‌‫⁫⁭⁪‎⁭​‏‎⁭‭‮((MemberInfo) ZoomZoomDatabase.\u202B‌‍⁭‌‬‭‪‏‭‍⁯‌‎‎‬‬⁬‭‌⁪⁯‬‭⁯‪‬‍‬⁪⁪‏⁬⁮‍‫‭‍⁭‭‮()));
    private static readonly object _locker = ZoomZoomDatabase.\u206D​‫‏‌‏‭⁮​‮‌‌‫‏‌‎⁮‎⁮⁪⁫‮⁮‏‪‍‬‏⁪‬⁮‍⁮⁫‫‍⁬‭‪‎‮();
    private string sDatabasePath = "";
    private SQLiteConnection cDB = (SQLiteConnection) null;
    private string sConnectionString = string.Empty;
    private bool isSchemaValid = false;
    protected TraceType traceType = TraceType.DataStorage;
    private const string sDatabaseName = "zoomZoom_v3.db";

    public string ConnectionString
    {
      get
      {
label_1:
        int num1 = 379887206;
        string str1;
        while (true)
        {
          int num2 = 1881305248;
          uint num3;
          string str2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 1:
              str1 = str2;
              num1 = (int) num3 * 774644808 ^ -1157009883;
              continue;
            case 2:
              str2 = ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2683663716U), (object) this.sDatabasePath);
              num1 = (int) num3 * 1092449216 ^ -900581223;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * 420331108 ^ -1087696751;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return str1;
      }
    }

    public bool IsSchemaValid
    {
      get
      {
        return this.isSchemaValid;
      }
    }

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.DataStorage;
label_1:
        int num1 = 575335296;
        while (true)
        {
          int num2 = 2081673724;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1317125883 ^ -1206598226;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public ZoomZoomDatabase(bool createIfMissing = true)
    {
label_1:
      int num1 = -1038810464;
      while (true)
      {
        int num2 = -938741993;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            this.CreateDatabaseFile();
            num1 = (int) num3 * -50188574 ^ 1422496846;
            continue;
          case 1:
            this.sDatabasePath = ZoomZoomDatabase.\u202A‪‬‎‮‏‬‮‬⁭‌‍‫⁯⁫​‎⁪⁮⁫‌‌⁬⁭‌⁫⁫⁪‭‏‮⁫⁫​‌⁯‮‫‭⁪‮(Resources.DatabaseRoot, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2420091458U));
            num1 = (int) num3 * -369382348 ^ -203608131;
            continue;
          case 2:
            int num4 = flag ? -753403119 : (num4 = -1505955985);
            int num5 = (int) num3 * -867721153;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * 1606380602 ^ 143713863;
            continue;
          case 4:
            goto label_3;
          case 5:
            num1 = (int) num3 * -287729413 ^ 707044149;
            continue;
          case 6:
            flag = createIfMissing;
            num1 = (int) num3 * -1608948034 ^ 2146037013;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num3 * 1957150799 ^ -569151499;
            continue;
          case 9:
            num1 = (int) num3 * -808734822 ^ -1163803414;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    internal List<string> GetAllUserNames()
    {
label_1:
      int num1 = -799248766;
      List<string> stringList1;
      while (true)
      {
        int num2 = -480356822;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            stringList1 = new List<string>();
            num1 = (int) num3 * 1897431496 ^ -1534789903;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_7:
        int num2 = -2036307182;
        while (true)
        {
          int num3 = -480356822;
          uint num4;
          string str;
          SQLiteDataReader sqLiteDataReader;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 12U)
          {
            case 0:
              goto label_7;
            case 1:
              str = ZoomZoomDatabase.\u202E⁯⁪‍⁮‎‎​⁮‫‍⁯⁯‏‮⁬⁭‪‏‏‪​‭⁬‌‌⁪⁫‭‮‎‭⁯⁯‭‭⁫⁪‬‫‮(ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(ZoomZoomDatabase.\u206D‮‍​⁮‪‏‮‭‍‭⁯‌‏‪⁮‮⁪‌⁯‭⁬‏‌⁪​‬‭⁫⁬‭‬‭⁭‎‏⁭‭‏⁫‮((DbDataReader) sqLiteDataReader, 0)));
              if (!ZoomZoomDatabase.\u202E⁬⁫‬​⁫‬⁫⁫⁮‭‎‮⁬⁬⁯‫‭⁬‌‪‭‬⁪‬‪​​⁪​⁭‭‌‪‭‪⁮⁯⁬‏‮(str, string.Empty))
              {
                num2 = (int) num4 * 561712785 ^ -1057440150;
                continue;
              }
              num5 = 0;
              break;
            case 2:
              num2 = (int) num4 * 1098979861 ^ -587880607;
              continue;
            case 3:
              sqLiteDataReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num2 = (int) num4 * 1562546160 ^ 29427665;
              continue;
            case 4:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3235706691U), new object[0]));
              num2 = (int) num4 * 1647034697 ^ -1863696967;
              continue;
            case 5:
              num5 = !stringList1.Contains(str) ? 1 : 0;
              break;
            case 6:
              num2 = -2063284609;
              continue;
            case 7:
              int num6;
              num2 = num6 = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) sqLiteDataReader) ? -1408083544 : (num6 = -974046328);
              continue;
            case 8:
              stringList1.Add(str);
              num2 = (int) num4 * 1997811192 ^ -6782648;
              continue;
            case 9:
              num2 = -831209855;
              continue;
            case 11:
              num2 = (int) num4 * -1008874608 ^ -1024408290;
              continue;
            default:
              goto label_29;
          }
          int num7;
          num2 = num7 = num5 == 0 ? -1094328885 : (num7 = -1640714295);
        }
      }
      catch (Exception ex)
      {
        ZoomZoomDatabase.\u206F​‪⁫​‎​⁫⁫⁫‍‪⁮⁪⁫‭‫‏‮⁮⁭⁭⁮‪​‌⁭‮⁭‌⁭⁪⁬⁯⁭‬‭‮‍⁯‮(ZoomZoomDatabase.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1602722266U), ex);
        throw ex;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_24:
          int num2 = -235752517;
          while (true)
          {
            int num3 = -480356822;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * -811562560 ^ -213614836;
                continue;
              case 2:
                num2 = (int) num4 * 646913421 ^ 667111916;
                continue;
              case 3:
                goto label_24;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
label_29:
      List<string> stringList2 = stringList1;
label_30:
      int num8 = -1795716319;
      while (true)
      {
        int num2 = -480356822;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 3U)
        {
          case 1:
            num8 = (int) num3 * 2017901728 ^ -138466255;
            continue;
          case 2:
            goto label_30;
          default:
            goto label_33;
        }
      }
label_33:
      return stringList2;
    }

    public bool DatabaseExists()
    {
label_1:
      int num1 = -1804380880;
      bool flag;
      while (true)
      {
        int num2 = -1356994992;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = ZoomZoomDatabase.\u202B‪​‬⁯⁬‭‫‪‏‭⁯‪‌‪​⁮​⁬⁫‮⁫⁬⁪‎⁮‬‎‮‌⁮‬⁪⁪‌‌‮​⁪‫‮(this.sDatabasePath);
            num1 = (int) num3 * -717484527 ^ -223362979;
            continue;
          case 2:
            num1 = (int) num3 * 800994463 ^ 1327803230;
            continue;
          case 4:
            this.Trace(this.TraceType, ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1144429503U), this.sDatabasePath));
            num1 = (int) num3 * 790010588 ^ 1340547809;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return flag;
    }

    public List<ZoomMeeting> GetMeetings()
    {
      this.Trace(this.TraceType, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3793237418U));
label_1:
      int num1 = 552169227;
      List<ZoomMeeting> zoomMeetingList1;
      while (true)
      {
        int num2 = 1207207497;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            zoomMeetingList1 = new List<ZoomMeeting>();
            num1 = (int) num3 * 1465813553 ^ -1442784017;
            continue;
          case 2:
            num1 = (int) num3 * -1850361591 ^ -558112258;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
        ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
        ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(420754291U), new object[0]));
label_8:
        int num2 = 18967265;
        while (true)
        {
          int num3 = 1207207497;
          uint num4;
          ZoomMeeting zoomMeeting;
          SQLiteDataReader cReader;
          bool flag;
          switch ((num4 = (uint) (num2 ^ num3)) % 13U)
          {
            case 0:
              num2 = (int) num4 * -655701949 ^ 1832788212;
              continue;
            case 1:
              zoomMeeting = new ZoomMeeting(cReader);
              num2 = 1656539406;
              continue;
            case 3:
              num2 = (int) num4 * -670021652 ^ -1782942950;
              continue;
            case 4:
              num2 = 2058682831;
              continue;
            case 5:
              zoomMeetingList1.Add(zoomMeeting);
              num2 = (int) num4 * -1507011666 ^ 1773162931;
              continue;
            case 6:
              flag = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader);
              num2 = 1005690547;
              continue;
            case 7:
              int num5 = flag ? 144543618 : (num5 = 1615475720);
              int num6 = (int) num4 * 471206381;
              num2 = num5 ^ num6;
              continue;
            case 8:
              int num7 = zoomMeeting == null ? 1181471529 : (num7 = 872775016);
              int num8 = (int) num4 * -1004522481;
              num2 = num7 ^ num8;
              continue;
            case 9:
              goto label_8;
            case 10:
              num2 = (int) num4 * -167903538 ^ -322797718;
              continue;
            case 11:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num2 = (int) num4 * -1140742694 ^ -1848330995;
              continue;
            case 12:
              num2 = (int) num4 * -2114684302 ^ 389244071;
              continue;
            default:
              goto label_27;
          }
        }
      }
      catch (Exception ex)
      {
        this.TraceError(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2070546888U), ex);
        throw ex;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_23:
          int num2 = 1868548790;
          while (true)
          {
            int num3 = 1207207497;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_23;
              case 2:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * -49887516 ^ -506937002;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
label_27:
      List<ZoomMeeting> zoomMeetingList2 = zoomMeetingList1;
label_28:
      int num9 = 994219445;
      while (true)
      {
        int num2 = 1207207497;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 3U)
        {
          case 1:
            num9 = (int) num3 * 564394030 ^ 531077198;
            continue;
          case 2:
            goto label_28;
          default:
            goto label_31;
        }
      }
label_31:
      return zoomMeetingList2;
    }

    public List<ZoomButton> GetButtons()
    {
label_1:
      int num1 = 309463531;
      while (true)
      {
        int num2 = 1789267683;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            this.Trace(this.TraceType, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1876395812U));
            num1 = (int) num3 * -711538124 ^ -1427108752;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      List<ZoomButton> zoomButtonList1 = new List<ZoomButton>();
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_7:
        int num2 = 1656066118;
        while (true)
        {
          int num3 = 1789267683;
          uint num4;
          bool flag;
          SQLiteDataReader cReader;
          switch ((num4 = (uint) (num2 ^ num3)) % 12U)
          {
            case 0:
              zoomButtonList1.Add(ZoomFactory.CreateButton(cReader));
              num2 = (int) num4 * 752646060 ^ -517114125;
              continue;
            case 1:
              int num5 = flag ? 1757695345 : (num5 = 113530422);
              int num6 = (int) num4 * -1148046940;
              num2 = num5 ^ num6;
              continue;
            case 2:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num2 = (int) num4 * 1137105583 ^ -2088462222;
              continue;
            case 3:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1628202522U), new object[0]));
              num2 = (int) num4 * -1581200131 ^ 140245262;
              continue;
            case 4:
              num2 = (int) num4 * 1974327547 ^ -37518779;
              continue;
            case 5:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * -1190582211 ^ -1312421751;
              continue;
            case 6:
              num2 = 596237307;
              continue;
            case 7:
              num2 = (int) num4 * -996554394 ^ -1674445142;
              continue;
            case 8:
              goto label_7;
            case 10:
              flag = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader);
              num2 = 560223714;
              continue;
            case 11:
              num2 = (int) num4 * -1914976195 ^ 108501782;
              continue;
            default:
              goto label_30;
          }
        }
      }
      catch (Exception ex)
      {
        this.TraceError(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(374622511U), ex);
label_20:
        int num2 = 435115621;
        while (true)
        {
          int num3 = 1789267683;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_20;
            case 2:
              num2 = (int) num4 * 124953083 ^ 203005959;
              continue;
            default:
              goto label_23;
          }
        }
label_23:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_25:
          int num2 = 757710456;
          while (true)
          {
            int num3 = 1789267683;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_25;
              case 2:
                num2 = (int) num4 * 130938591 ^ -1344311304;
                continue;
              case 3:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * -163580420 ^ 1311240705;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
label_30:
      this.Trace(this.TraceType, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1824306909U), (object) zoomButtonList1.Count);
label_31:
      int num7 = 1535203983;
      List<ZoomButton> zoomButtonList2;
      while (true)
      {
        int num2 = 1789267683;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 3U)
        {
          case 1:
            zoomButtonList2 = zoomButtonList1;
            num7 = (int) num3 * 1737849600 ^ 1960660498;
            continue;
          case 2:
            goto label_31;
          default:
            goto label_34;
        }
      }
label_34:
      return zoomButtonList2;
    }

    internal string GetSavedXml(int objectType, string objectName)
    {
      string str1 = string.Empty;
label_1:
      int num1 = -1490505475;
      while (true)
      {
        int num2 = -1702066127;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            this.Trace(this.TraceType, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2203151460U));
            num1 = (int) num3 * -1451094343 ^ -1732241860;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
        ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
label_7:
        int num2 = -1038170569;
        while (true)
        {
          int num3 = -1702066127;
          uint num4;
          SQLiteDataReader sqLiteDataReader;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              int num5;
              num2 = num5 = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) sqLiteDataReader) ? -454600648 : (num5 = -1436692016);
              continue;
            case 1:
              num2 = (int) num4 * 343968944 ^ 281279452;
              continue;
            case 2:
              num2 = (int) num4 * 1199973658 ^ 1581662851;
              continue;
            case 3:
              str1 = sqLiteDataReader.GetFieldValueString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2757882853U));
              num2 = (int) num4 * 483885614 ^ 1417438805;
              continue;
            case 4:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2542295906U), (object) objectType, (object) objectName), new object[0]));
              num2 = (int) num4 * 823600306 ^ 1469175777;
              continue;
            case 5:
              num2 = -1568805332;
              continue;
            case 6:
              sqLiteDataReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num2 = (int) num4 * -1872219345 ^ -80018591;
              continue;
            case 7:
              goto label_7;
            case 8:
              num2 = (int) num4 * -1873910829 ^ 1406681339;
              continue;
            default:
              goto label_29;
          }
        }
      }
      catch (Exception ex)
      {
label_18:
        int num2 = -591707670;
        while (true)
        {
          int num3 = -1702066127;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_18;
            case 2:
              this.TraceError(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(51009747U), ex);
              num2 = (int) num4 * -1816401759 ^ -1913796542;
              continue;
            case 3:
              num2 = (int) num4 * -1290792808 ^ 1682387375;
              continue;
            default:
              goto label_22;
          }
        }
label_22:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_24:
          int num2 = -1187614242;
          while (true)
          {
            int num3 = -1702066127;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 962957351 ^ -2075163368;
                continue;
              case 2:
                goto label_24;
              case 3:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * -1690892349 ^ 1865171976;
                continue;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
label_29:
      string str2 = str1;
label_30:
      int num6 = -63984301;
      while (true)
      {
        int num2 = -1702066127;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 3U)
        {
          case 0:
            goto label_30;
          case 1:
            num6 = (int) num3 * -87929653 ^ 603565797;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return str2;
    }

    internal bool SaveXml(int objectType, string objectName, string objectXml)
    {
label_1:
      int num1 = -49090271;
      bool flag1;
      while (true)
      {
        int num2 = -555327377;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            this.Trace(this.TraceType, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(801039614U));
            num1 = (int) num3 * 8870190 ^ -359721179;
            continue;
          case 2:
            flag1 = false;
            num1 = (int) num3 * -517394774 ^ 1160439590;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
        ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
label_8:
        int num2 = -1629151580;
        while (true)
        {
          int num3 = -555327377;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_8;
            case 2:
              ZoomZoomDatabase.\u202A‮⁭⁯‬⁮‌‎‮‬‌‮‏⁬‌⁪⁭​‎‏‪‮‌‏⁯⁬‮⁯⁯‮‭⁭⁬‏⁮‍⁫‫⁪⁬‮(ZoomZoomDatabase.\u206E‬‌‏‌‮​​‪‌‬⁫⁮⁭⁫⁫‪​⁬​‎‎⁪‭⁪‪⁭⁭‍‬‍‍⁮⁬‬‎‫⁯⁪‍‮(sqLiteCommand), ZoomZoomDatabase.\u206A‏‪​‭​⁭‬‬⁭⁪‮⁫‮‌⁯‬‎‌‏‮‪⁫⁯‭​‍‌​⁪‫‬‬⁫⁯​⁭‭‬‌‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(404794006U), (object) objectXml));
              num2 = (int) num4 * 758359851 ^ 1516882564;
              continue;
            case 3:
              num2 = (int) num4 * -1106825275 ^ -1065708462;
              continue;
            case 4:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4261310095U), (object) objectType, (object) objectName), new object[0]));
              num2 = (int) num4 * -1437959675 ^ 505893729;
              continue;
            case 5:
              ZoomZoomDatabase.\u202B‌‪‎⁮⁮⁭‮⁯‏⁬⁭‏‮⁭⁪‌‌‍⁯​‪‏⁮⁪‫⁫‬‌⁯‬‭⁬‎‭‭‍​⁬⁬‮((DbCommand) sqLiteCommand);
              flag1 = true;
              num2 = (int) num4 * -1356086630 ^ -507936036;
              continue;
            default:
              goto label_26;
          }
        }
      }
      catch (Exception ex)
      {
label_15:
        int num2 = -1584040104;
        while (true)
        {
          int num3 = -555327377;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              this.TraceError(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2074843220U), ex);
              num2 = (int) num4 * 2011734454 ^ 59585646;
              continue;
            case 2:
              goto label_15;
            case 3:
              num2 = (int) num4 * 2118248734 ^ 581833289;
              continue;
            default:
              goto label_19;
          }
        }
label_19:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_21:
          int num2 = -965624007;
          while (true)
          {
            int num3 = -555327377;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_21;
              case 2:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * 881566790 ^ 733870044;
                continue;
              case 3:
                num2 = (int) num4 * 921057584 ^ 1428557354;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:
      bool flag2 = flag1;
label_27:
      int num5 = -2079814371;
      while (true)
      {
        int num2 = -555327377;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 1:
            num5 = (int) num3 * 2091887689 ^ 1981053235;
            continue;
          case 2:
            goto label_27;
          default:
            goto label_30;
        }
      }
label_30:
      return flag2;
    }

    public List<ZoomUser> GetUsers()
    {
      this.Trace(this.TraceType, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3991459870U));
      List<ZoomUser> zoomUserList1 = new List<ZoomUser>();
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_3:
        int num1 = -245777382;
        while (true)
        {
          int num2 = -702165660;
          uint num3;
          bool flag1;
          bool flag2;
          SQLiteDataReader cReader;
          ZoomUser zoomUser;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              num1 = (int) num3 * 1726082590 ^ -890085205;
              continue;
            case 1:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2994933213U), new object[0]));
              num1 = (int) num3 * -1012789807 ^ 1230486298;
              continue;
            case 3:
              int num4 = !flag1 ? -823955760 : (num4 = -1856566256);
              int num5 = (int) num3 * -492023204;
              num1 = num4 ^ num5;
              continue;
            case 4:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * -552112457 ^ 945842129;
              continue;
            case 5:
              num1 = (int) num3 * 2033627672 ^ 652924409;
              continue;
            case 6:
              flag2 = zoomUser != null;
              num1 = (int) num3 * -1250697370 ^ 635977108;
              continue;
            case 7:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num1 = (int) num3 * -1287321698 ^ -555777889;
              continue;
            case 8:
              int num6 = !flag2 ? -1383712909 : (num6 = -673007086);
              int num7 = (int) num3 * 1334906973;
              num1 = num6 ^ num7;
              continue;
            case 9:
              goto label_3;
            case 10:
              zoomUserList1.Add(zoomUser);
              num1 = (int) num3 * -1291248014 ^ -151675178;
              continue;
            case 11:
              flag1 = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader);
              num1 = -1906944305;
              continue;
            case 12:
              zoomUser = new ZoomUser(cReader);
              num1 = -2104005994;
              continue;
            case 13:
              num1 = -482954487;
              continue;
            default:
              goto label_29;
          }
        }
      }
      catch (Exception ex)
      {
label_18:
        int num1 = -749297694;
        while (true)
        {
          int num2 = -702165660;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 1:
              num1 = (int) num3 * -1285038357 ^ 1921281791;
              continue;
            case 2:
              this.TraceError(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(314476598U), ex);
              num1 = (int) num3 * 719772213 ^ -1541170914;
              continue;
            case 3:
              goto label_18;
            case 4:
              num1 = (int) num3 * 1436083459 ^ -1747202539;
              continue;
            default:
              goto label_23;
          }
        }
label_23:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_25:
          int num1 = -1762206617;
          while (true)
          {
            int num2 = -702165660;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num1 = (int) num3 * -193034453 ^ -765774876;
                continue;
              case 2:
                goto label_25;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
label_29:
      this.Trace(this.TraceType, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3151715689U), (object) zoomUserList1.Count);
label_30:
      int num8 = -1518604542;
      List<ZoomUser> zoomUserList2;
      while (true)
      {
        int num1 = -702165660;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 4U)
        {
          case 0:
            goto label_30;
          case 2:
            zoomUserList2 = zoomUserList1;
            num8 = (int) num2 * -318932138 ^ -1727532589;
            continue;
          case 3:
            num8 = (int) num2 * -147034406 ^ 1677658635;
            continue;
          default:
            goto label_34;
        }
      }
label_34:
      return zoomUserList2;
    }

    public List<MessageCategory> GetMessageCatories()
    {
      this.Trace(this.TraceType, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2831328289U));
      List<MessageCategory> messageCategoryList1 = new List<MessageCategory>();
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_3:
        int num1 = 1032301855;
        while (true)
        {
          int num2 = 1538410563;
          uint num3;
          MessageCategory messageCategory;
          SQLiteDataReader cReader;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 1:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num1 = (int) num3 * -293917393 ^ -1319446937;
              continue;
            case 2:
              messageCategoryList1.Add(messageCategory);
              num1 = (int) num3 * -240817640 ^ 1881134356;
              continue;
            case 3:
              num1 = 1026093445;
              continue;
            case 4:
              int num4;
              num1 = num4 = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader) ? 651175418 : (num4 = 2045232554);
              continue;
            case 5:
              num1 = (int) num3 * 359498798 ^ -777649638;
              continue;
            case 6:
              int num5 = messageCategory == null ? 1788966932 : (num5 = 1136468739);
              int num6 = (int) num3 * 188387088;
              num1 = num5 ^ num6;
              continue;
            case 7:
              num1 = (int) num3 * -1529041534 ^ 822355809;
              continue;
            case 8:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1527294034U), (object) ZoomZoomDataTable.GetTableName(ObjectDataTable.MessageCategory), (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3407477944U)));
              num1 = (int) num3 * 1403977610 ^ 1777940102;
              continue;
            case 9:
              num1 = (int) num3 * -1921887996 ^ -1130786191;
              continue;
            case 10:
              num1 = (int) num3 * -1342369238 ^ 1365041669;
              continue;
            case 11:
              messageCategory = MessageCategory.Load(cReader);
              num1 = 1276790259;
              continue;
            case 12:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * -1558752128 ^ -2134117075;
              continue;
            case 13:
              goto label_3;
            default:
              goto label_29;
          }
        }
      }
      catch (Exception ex)
      {
label_18:
        int num1 = 194832602;
        while (true)
        {
          int num2 = 1538410563;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 859135624 ^ 1815540888;
              continue;
            case 1:
              ZoomZoomDatabase.\u206F​‪⁫​‎​⁫⁫⁫‍‪⁮⁪⁫‭‫‏‮⁮⁭⁭⁮‪​‌⁭‮⁭‌⁭⁪⁬⁯⁭‬‭‮‍⁯‮(ZoomZoomDatabase.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2938517669U), ex);
              num1 = (int) num3 * -134468077 ^ 1016982176;
              continue;
            case 2:
              goto label_18;
            default:
              goto label_22;
          }
        }
label_22:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_24:
          int num1 = 477274500;
          while (true)
          {
            int num2 = 1538410563;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_24;
              case 2:
                num1 = (int) num3 * 580915253 ^ 1555827208;
                continue;
              case 3:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num1 = (int) num3 * 1797195555 ^ -1862429952;
                continue;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
label_29:
      this.Trace(this.TraceType, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3220338586U), (object) messageCategoryList1.Count);
label_30:
      int num7 = 2126707387;
      List<MessageCategory> messageCategoryList2;
      while (true)
      {
        int num1 = 1538410563;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 3U)
        {
          case 0:
            goto label_30;
          case 2:
            messageCategoryList2 = messageCategoryList1;
            num7 = (int) num2 * 812150431 ^ -173717445;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return messageCategoryList2;
    }

    public List<MessageContent> GetMessageContents(long categoryUri)
    {
      this.Trace(this.TraceType, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3875510449U), (object) categoryUri);
      List<MessageContent> messageContentList1 = new List<MessageContent>();
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_3:
        int num1 = -1091911541;
        while (true)
        {
          int num2 = -1396156002;
          uint num3;
          SQLiteDataReader cReader;
          MessageContent messageContent;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 15U)
          {
            case 0:
              num1 = (int) num3 * 1179959883 ^ -2111968344;
              continue;
            case 1:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * 27866420 ^ 1288637583;
              continue;
            case 2:
              int num4 = flag ? 839738945 : (num4 = 596386861);
              int num5 = (int) num3 * -793344007;
              num1 = num4 ^ num5;
              continue;
            case 3:
              messageContentList1.Add(messageContent);
              num1 = (int) num3 * 910311651 ^ 994818515;
              continue;
            case 4:
              messageContent = MessageContent.Load(cReader);
              flag = messageContent != null;
              num1 = -544238694;
              continue;
            case 5:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num1 = (int) num3 * 1820227393 ^ -2105399063;
              continue;
            case 7:
              num1 = (int) num3 * -1988943843 ^ 96248989;
              continue;
            case 8:
              num1 = -791507752;
              continue;
            case 9:
              num1 = (int) num3 * -1597839269 ^ -1819848912;
              continue;
            case 10:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u202E‬​⁬‬‪‎⁮‪‌‍‪‎⁮⁬‪⁪‫‍‮⁯⁪‌‌‮⁮‏‪‎‎‌‬⁬⁪⁫⁯​‍⁮⁮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(189962936U), (object) ZoomZoomDataTable.GetTableName(ObjectDataTable.MessageContent), (object) categoryUri, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1759587503U)));
              num1 = (int) num3 * -366688026 ^ 548098383;
              continue;
            case 11:
              num1 = (int) num3 * 915779636 ^ 1118354453;
              continue;
            case 12:
              goto label_3;
            case 13:
              int num6;
              num1 = num6 = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader) ? -1993460888 : (num6 = -807276136);
              continue;
            case 14:
              num1 = (int) num3 * 220459237 ^ -1249948590;
              continue;
            default:
              goto label_29;
          }
        }
      }
      catch (Exception ex)
      {
label_19:
        int num1 = -701682249;
        while (true)
        {
          int num2 = -1396156002;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_19;
            case 1:
              num1 = (int) num3 * -954353105 ^ -2038605315;
              continue;
            default:
              goto label_22;
          }
        }
label_22:
        this.TraceError(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2174592763U), ex);
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_24:
          int num1 = -1830443645;
          while (true)
          {
            int num2 = -1396156002;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -2082874967 ^ -1014136356;
                continue;
              case 1:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num1 = (int) num3 * -364743878 ^ -2067422232;
                continue;
              case 3:
                goto label_24;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
label_29:
      this.Trace(this.TraceType, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1662082118U), (object) messageContentList1.Count);
label_30:
      int num7 = -812808809;
      List<MessageContent> messageContentList2;
      while (true)
      {
        int num1 = -1396156002;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 4U)
        {
          case 1:
            messageContentList2 = messageContentList1;
            num7 = (int) num2 * -784004067 ^ -1246543703;
            continue;
          case 2:
            num7 = (int) num2 * 310150676 ^ -675554118;
            continue;
          case 3:
            goto label_30;
          default:
            goto label_34;
        }
      }
label_34:
      return messageContentList2;
    }

    internal List<ZoomChat> GetChats(string SQL)
    {
label_1:
      int num1 = -1496735962;
      List<ZoomChat> zoomChatList;
      while (true)
      {
        int num2 = -721896019;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Trace(this.TraceType, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(780355647U), (object) SQL);
            num1 = (int) num3 * 1664701503 ^ 109308274;
            continue;
          case 2:
            zoomChatList = new List<ZoomChat>();
            num1 = (int) num3 * 1928928795 ^ 722616775;
            continue;
          case 4:
            num1 = (int) num3 * -1646103792 ^ 1664974137;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_9:
        int num2 = -413063233;
        while (true)
        {
          int num3 = -721896019;
          uint num4;
          int num5;
          bool flag;
          ZoomChat zoomChat;
          SQLiteDataReader cReader;
          switch ((num4 = (uint) (num2 ^ num3)) % 17U)
          {
            case 1:
              zoomChatList.Add(zoomChat);
              num2 = (int) num4 * 133127161 ^ -485450341;
              continue;
            case 2:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * -714325390 ^ 788485889;
              continue;
            case 3:
              num2 = (int) num4 * -1737620888 ^ 113053906;
              continue;
            case 4:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(SQL, new object[0]));
              num2 = (int) num4 * -573747676 ^ -165474799;
              continue;
            case 5:
              num2 = -1692356792;
              continue;
            case 6:
              ++num5;
              num2 = -698226732;
              continue;
            case 7:
              flag = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader);
              num2 = -1271123177;
              continue;
            case 8:
              int num6 = !flag ? 1046181759 : (num6 = 1163254559);
              int num7 = (int) num4 * -1607512525;
              num2 = num6 ^ num7;
              continue;
            case 9:
              num2 = (int) num4 * -1523365066 ^ -1809876691;
              continue;
            case 10:
              num2 = (int) num4 * -1702170295 ^ -459320711;
              continue;
            case 11:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num5 = 0;
              num2 = (int) num4 * -471206644 ^ 657057427;
              continue;
            case 12:
              goto label_9;
            case 13:
              num2 = (int) num4 * 1094744646 ^ -1182375985;
              continue;
            case 14:
              num2 = (int) num4 * -1890975955 ^ 522421851;
              continue;
            case 15:
              zoomChat = ZoomChat.Load(cReader);
              int num8 = zoomChat != null ? -2102619252 : (num8 = -286286075);
              int num9 = (int) num4 * -313173944;
              num2 = num8 ^ num9;
              continue;
            case 16:
              num2 = (int) num4 * -1679526006 ^ -462228930;
              continue;
            default:
              goto label_38;
          }
        }
      }
      catch (Exception ex)
      {
label_27:
        int num2 = -1862487862;
        while (true)
        {
          int num3 = -721896019;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_27;
            case 1:
              this.TraceError(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2536490143U), ex);
              num2 = (int) num4 * 71803472 ^ -623408945;
              continue;
            case 3:
              num2 = (int) num4 * 1378184254 ^ -120772494;
              continue;
            default:
              goto label_31;
          }
        }
label_31:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_33:
          int num2 = -1205022268;
          while (true)
          {
            int num3 = -721896019;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * 267848614 ^ -5118499;
                continue;
              case 2:
                num2 = (int) num4 * 709352754 ^ -1230021611;
                continue;
              case 3:
                goto label_33;
              default:
                goto label_37;
            }
          }
        }
label_37:;
      }
label_38:
      this.Trace(this.TraceType, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3016453774U), (object) zoomChatList.Count);
      return zoomChatList;
    }

    internal List<ZoomChat> GetChats(long lUserUri = 0, int iMaxCount = 50)
    {
label_1:
      int num1 = 818630800;
      List<ZoomChat> chats;
      while (true)
      {
        int num2 = 1018160519;
        uint num3;
        string SQL;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            chats = this.GetChats(SQL);
            num1 = (int) num3 * -1784169282 ^ -489847171;
            continue;
          case 1:
            num1 = (int) num3 * -912036509 ^ -1668057033;
            continue;
          case 3:
            SQL = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(SQL, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(ZoomZoomDatabase.\u200B‌⁬‫⁪‮⁬‌‪‮​‌⁯‬‎‬‬‍⁮⁯⁮‏‎​‏‏⁬⁫‪‌‮⁮⁫⁭‮‏‪⁪​⁯‮((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2651963940U), (object) iMaxCount), new object[0]));
            num1 = 1082128087;
            continue;
          case 4:
            num1 = (int) num3 * 460270838 ^ -963824574;
            continue;
          case 5:
            SQL = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(SQL, ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1405465638U), (object) lUserUri));
            num1 = (int) num3 * 376215086 ^ 1829877448;
            continue;
          case 6:
            goto label_1;
          case 7:
            SQL = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2850591292U);
            int num4 = lUserUri <= 0L ? 485182603 : (num4 = 55416220);
            int num5 = (int) num3 * 1920039553;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return chats;
    }

    internal List<ZoomChat> GetChats(ZoomMeeting activeMeeting, int chatCountMax = 0)
    {
label_1:
      int num1 = -332260386;
      List<ZoomChat> zoomChatList1;
      while (true)
      {
        int num2 = -917450691;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            zoomChatList1 = new List<ZoomChat>();
            num1 = (int) num3 * -396986331 ^ -1907772070;
            continue;
          case 3:
            this.Trace(this.TraceType, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3468575316U), (object) activeMeeting);
            num1 = (int) num3 * 1006273346 ^ 528202586;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
        string str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4022380742U);
label_8:
        int num2 = -1763571389;
        while (true)
        {
          int num3 = -917450691;
          uint num4;
          int num5;
          bool flag1;
          SQLiteDataReader cReader;
          ZoomChat zoomChat;
          bool flag2;
          int num6;
          switch ((num4 = (uint) (num2 ^ num3)) % 19U)
          {
            case 0:
              ++num5;
              num2 = -1173135800;
              continue;
            case 1:
              num2 = (int) num4 * -1253058412 ^ 730020121;
              continue;
            case 2:
              int num7 = !flag1 ? 1894722781 : (num7 = 779804478);
              int num8 = (int) num4 * 1308566137;
              num2 = num7 ^ num8;
              continue;
            case 3:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(str, (object) activeMeeting.MeetingId));
              num2 = (int) num4 * 1926740716 ^ 717581666;
              continue;
            case 4:
              zoomChat = ZoomChat.Load(cReader);
              int num9;
              num2 = num9 = zoomChat == null ? -1251995811 : (num9 = -1546684111);
              continue;
            case 5:
              flag2 = chatCountMax > 0;
              num2 = (int) num4 * 2107951896 ^ 657025268;
              continue;
            case 6:
              int num10 = flag2 ? 1665998393 : (num10 = 1145644510);
              int num11 = (int) num4 * 1759586069;
              num2 = num10 ^ num11;
              continue;
            case 7:
              num6 = num5 < chatCountMax ? 1 : 0;
              break;
            case 8:
              if (!ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader))
              {
                num6 = 0;
                break;
              }
              num2 = -349000030;
              continue;
            case 10:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = -104444177;
              continue;
            case 11:
              zoomChatList1.Add(zoomChat);
              num2 = (int) num4 * -1273893951 ^ 625075381;
              continue;
            case 12:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num2 = (int) num4 * 1952029900 ^ 1312085833;
              continue;
            case 13:
              num2 = (int) num4 * -94182377 ^ 20612737;
              continue;
            case 14:
              num2 = (int) num4 * -1926546067 ^ -1225072189;
              continue;
            case 15:
              num5 = 0;
              num2 = (int) num4 * 161099624 ^ 1383129578;
              continue;
            case 16:
              goto label_8;
            case 17:
              str = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(str, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(ZoomZoomDatabase.\u200B‌⁬‫⁪‮⁬‌‪‮​‌⁯‬‎‬‬‍⁮⁯⁮‏‎​‏‏⁬⁫‪‌‮⁮⁫⁭‮‏‪⁪​⁯‮((object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4276704103U), (object) chatCountMax), new object[0]));
              num2 = (int) num4 * -1326065553 ^ 1829828660;
              continue;
            case 18:
              num2 = (int) num4 * 868443440 ^ -2033829693;
              continue;
            default:
              goto label_40;
          }
          flag1 = num6 != 0;
          num2 = -1963909614;
        }
      }
      catch (Exception ex)
      {
        this.TraceError(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2382976282U), ex);
label_31:
        int num2 = -1412181743;
        while (true)
        {
          int num3 = -917450691;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_31;
            case 1:
              num2 = (int) num4 * 1602849174 ^ 573106201;
              continue;
            default:
              goto label_34;
          }
        }
label_34:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_36:
          int num2 = -1107589157;
          while (true)
          {
            int num3 = -917450691;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * -374887464 ^ 1176868578;
                continue;
              case 2:
                goto label_36;
              default:
                goto label_39;
            }
          }
        }
label_39:;
      }
label_40:
      this.Trace(this.TraceType, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(515670578U), (object) zoomChatList1.Count);
label_41:
      int num12 = -293265448;
      List<ZoomChat> zoomChatList2;
      while (true)
      {
        int num2 = -917450691;
        uint num3;
        switch ((num3 = (uint) (num12 ^ num2)) % 3U)
        {
          case 0:
            goto label_41;
          case 1:
            zoomChatList2 = zoomChatList1;
            num12 = (int) num3 * -1789265134 ^ 717414689;
            continue;
          default:
            goto label_44;
        }
      }
label_44:
      return zoomChatList2;
    }

    internal List<ActivityBase> GetSavedActivities(string title = "")
    {
      this.Trace(this.TraceType, ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(147578413U), (object) title));
label_1:
      int num1 = -1667582913;
      List<ActivityBase> activityBaseList1;
      while (true)
      {
        int num2 = -95824334;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            activityBaseList1 = new List<ActivityBase>();
            num1 = (int) num3 * 1152862800 ^ 344891748;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_7:
        int num2 = -332926396;
        while (true)
        {
          int num3 = -95824334;
          uint num4;
          string str;
          ActivityBase activityBase;
          bool flag1;
          SQLiteDataReader cReader;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 18U)
          {
            case 1:
              num2 = (int) num4 * -508001879 ^ -1264929333;
              continue;
            case 2:
              num2 = (int) num4 * 1454827794 ^ -1436203861;
              continue;
            case 3:
              num2 = (int) num4 * -1436441336 ^ 242003308;
              continue;
            case 4:
              num2 = (int) num4 * -1670408664 ^ 764355642;
              continue;
            case 5:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(str, new object[0]));
              num2 = (int) num4 * 1673852762 ^ 271527737;
              continue;
            case 6:
              flag2 = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader);
              num2 = -2073969904;
              continue;
            case 7:
              flag1 = activityBase != null;
              num2 = (int) num4 * 925285200 ^ -1071381378;
              continue;
            case 8:
              int num5 = flag1 ? -1977381585 : (num5 = -481228366);
              int num6 = (int) num4 * -217854286;
              num2 = num5 ^ num6;
              continue;
            case 9:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num2 = (int) num4 * -1894039798 ^ 1309324149;
              continue;
            case 10:
              str = ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3656779888U), (object) title);
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num2 = (int) num4 * 1481875804 ^ 723592446;
              continue;
            case 11:
              num2 = (int) num4 * 1007642666 ^ 553992196;
              continue;
            case 12:
              int num7 = flag2 ? -833272177 : (num7 = -1070295977);
              int num8 = (int) num4 * -1182189119;
              num2 = num7 ^ num8;
              continue;
            case 13:
              num2 = -76545154;
              continue;
            case 14:
              activityBase = ActivityBase.Load(cReader);
              num2 = (int) num4 * 1720248996 ^ -929605987;
              continue;
            case 15:
              activityBaseList1.Add(activityBase);
              num2 = (int) num4 * -278231845 ^ -1473740454;
              continue;
            case 16:
              num2 = -506530044;
              continue;
            case 17:
              goto label_7;
            default:
              goto label_37;
          }
        }
      }
      catch (Exception ex)
      {
label_26:
        int num2 = -1679256679;
        while (true)
        {
          int num3 = -95824334;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_26;
            case 1:
              num2 = (int) num4 * -2117037606 ^ -252434978;
              continue;
            case 3:
              this.TraceError(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1897476446U), ex);
              num2 = (int) num4 * 1117458075 ^ -2133456030;
              continue;
            default:
              goto label_30;
          }
        }
label_30:
        throw;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_32:
          int num2 = -472489655;
          while (true)
          {
            int num3 = -95824334;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_32;
              case 1:
                num2 = (int) num4 * 1637641881 ^ 665369389;
                continue;
              case 3:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * -1132123769 ^ 261233034;
                continue;
              default:
                goto label_36;
            }
          }
        }
label_36:;
      }
label_37:
      this.Trace(this.TraceType, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(515670578U), (object) activityBaseList1.Count);
label_38:
      int num9 = -1538719021;
      List<ActivityBase> activityBaseList2;
      while (true)
      {
        int num2 = -95824334;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 4U)
        {
          case 0:
            num9 = (int) num3 * 2048506179 ^ 823046169;
            continue;
          case 1:
            activityBaseList2 = activityBaseList1;
            num9 = (int) num3 * -1928798218 ^ 1074486996;
            continue;
          case 2:
            goto label_38;
          default:
            goto label_42;
        }
      }
label_42:
      return activityBaseList2;
    }

    internal byte[] GetImageContent(long uri)
    {
label_1:
      int num1 = -766705419;
      byte[] numArray;
      while (true)
      {
        int num2 = -1907836405;
        uint num3;
        byte[] sqlScalarBytes;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * 2035772991 ^ -753746052;
            continue;
          case 1:
            numArray = sqlScalarBytes;
            num1 = -1157176499;
            continue;
          case 2:
            ZoomZoomDatabase.\u206B⁯‍‫‍‪‭‬⁮‫​‬⁮⁯‎⁮‎‭‎⁯‬‎​‪‌⁫⁬‎⁯‪‍⁫⁪⁯‎‎‍‭⁪‌‮(ZoomZoomDatabase.log, ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2145738294U), (object) uri), new object[0]);
            num1 = (int) num3 * 1220594153 ^ 1760666322;
            continue;
          case 3:
            ZoomZoomDatabase.\u206B⁯‍‫‍‪‭‬⁮‫​‬⁮⁯‎⁮‎‭‎⁯‬‎​‪‌⁫⁬‎⁯‪‍⁫⁪⁯‎‎‍‭⁪‌‮(ZoomZoomDatabase.log, ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3187862807U), (object) sqlScalarBytes.Length), new object[0]);
            num1 = (int) num3 * -978831373 ^ -231011363;
            continue;
          case 4:
            sqlScalarBytes = this.GetSQLScalar_Bytes(ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1027591557U), (object) uri));
            num1 = (int) num3 * -248615172 ^ -983768161;
            continue;
          case 5:
            num1 = (int) num3 * 663975802 ^ -1925223779;
            continue;
          case 6:
            int num4 = sqlScalarBytes == null ? 39786530 : (num4 = 1517161752);
            int num5 = (int) num3 * 2085515387;
            num1 = num4 ^ num5;
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num3 * -278902671 ^ -1462915195;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return numArray;
    }

    internal bool SaveObject(ObjectDataTable table, Dictionary<string, object> data)
    {
      bool flag1 = false;
      string sSQL = "";
      try
      {
label_2:
        int num1 = 1997666051;
        string str1;
        List<SQLiteParameter> parameters;
        string str2;
        ZoomZoomDataTable zoomZoomDataTable;
        int num2;
        while (true)
        {
          int num3 = 555250704;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num1 ^ num3)) % 12U)
          {
            case 0:
              num2 = 0;
              num1 = (int) num4 * 704405810 ^ 1377092369;
              continue;
            case 1:
              num1 = (int) num4 * 1860338065 ^ 1801407070;
              continue;
            case 2:
              if (flag2)
              {
                num1 = (int) num4 * 810547897 ^ -172937986;
                continue;
              }
              goto label_55;
            case 4:
              zoomZoomDataTable = new ZoomZoomDataTable(table);
              num1 = (int) num4 * -202163062 ^ -1575308671;
              continue;
            case 5:
              parameters = new List<SQLiteParameter>();
              flag2 = (long) data[\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3666502981U)] == 0L;
              num1 = (int) num4 * 1085646959 ^ 523463057;
              continue;
            case 6:
              str1 = "";
              num1 = (int) num4 * -1796470490 ^ 1912706959;
              continue;
            case 7:
              str2 = "";
              num1 = (int) num4 * -29528400 ^ 584216484;
              continue;
            case 8:
              num1 = (int) num4 * -1698658627 ^ 1241036426;
              continue;
            case 9:
              goto label_2;
            case 10:
              num1 = (int) num4 * -1426502395 ^ 878893518;
              continue;
            case 11:
              this.Trace(this.TraceType, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1298512316U), (object) table, data[\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U)]);
              num1 = (int) num4 * 1199138224 ^ 1751946686;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        IEnumerator enumerator1 = ZoomZoomDatabase.\u206F‌‬‭‍‍‏‏⁪​‮⁬⁭‏⁯⁪‍‌‎⁫⁬‪‬⁭‍⁯​‫‪‏‭‎‪⁭‏⁬‮⁬‮‌‮((InternalDataCollectionBase) ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(zoomZoomDataTable.Table));
        try
        {
label_29:
          int num3 = ZoomZoomDatabase.\u206B‌‌‪‫⁪‪⁯⁪⁫‮‌​‫⁫‮⁬⁫⁯‏⁯‭⁭‍‪‪‌‌‪‫⁭‫​‪‏‬‎‌⁮‮(enumerator1) ? 344404802 : (num3 = 1994943825);
          while (true)
          {
            int num4 = 555250704;
            uint num5;
            bool flag2;
            DataColumn column;
            string str3;
            bool flag3;
            string str4;
            bool flag4;
            bool flag5;
            byte[] numArray;
            string str5;
            string str6;
            switch ((num5 = (uint) (num3 ^ num4)) % 24U)
            {
              case 0:
                num3 = (int) num5 * 841739582 ^ 2089829959;
                continue;
              case 1:
                num3 = (int) num5 * 1319363703 ^ -1196298480;
                continue;
              case 2:
                column = (DataColumn) ZoomZoomDatabase.\u200D‭‪‌‎‌⁯⁮‮⁭‭‌‍⁯⁮‎⁭‬⁮‭⁮‌⁬‏‭‌‌⁫‍‪⁮⁫⁫⁭⁬‬⁫⁭⁬⁯‮(enumerator1);
                num3 = 1406655358;
                continue;
              case 3:
                ++num2;
                num3 = 841922474;
                continue;
              case 4:
                str6 = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3957863824U);
                break;
              case 5:
                str4 = ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2911641294U), (object) parameters.Count);
                num3 = (int) num5 * 1459171287 ^ -1701271692;
                continue;
              case 6:
                if (ZoomZoomDatabase.\u200E⁭‮‏‫‍‍‮‪⁮‍‫‭‮⁮‫⁮‍‮‍‍‍‌‫⁬‎⁯⁬‭⁯⁫⁪‌‌⁫​‮‮⁮‭‮(str1))
                {
                  str6 = "";
                  break;
                }
                num3 = (int) num5 * 2040076711 ^ 1009071086;
                continue;
              case 7:
                parameters.Add(ZoomZoomDatabase.\u206A‏‪​‭​⁭‬‬⁭⁪‮⁫‮‌⁯‬‎‌‏‮‪⁫⁯‭​‍‌​⁪‫‬‬⁫⁯​⁭‭‬‌‮(str4, (object) numArray));
                num3 = (int) num5 * 575166171 ^ 1704880124;
                continue;
              case 8:
                flag2 = !ZoomZoomDatabase.\u206B‭‎⁫‌​⁫‪‭‭‮‎‫‍⁫⁭‭⁮‌⁭‪‭‎‪‎‫‪‎⁮‌⁭‎​​⁪⁭⁮⁫‭⁪‮(column);
                num3 = 1262935556;
                continue;
              case 10:
                goto label_29;
              case 11:
                int num6 = flag4 ? -376200441 : (num6 = -2010181987);
                int num7 = (int) num5 * 561754095;
                num3 = num6 ^ num7;
                continue;
              case 12:
                int num8 = flag2 ? 1528893116 : (num8 = 1209349201);
                int num9 = (int) num5 * 2102928191;
                num3 = num8 ^ num9;
                continue;
              case 13:
                flag5 = !ZoomZoomDatabase.\u200E⁭‮‏‫‍‍‮‪⁮‍‫‭‮⁮‫⁮‍‮‍‍‍‌‫⁬‎⁯⁬‭⁯⁫⁪‌‌⁫​‮‮⁮‭‮(str4);
                num3 = 974799237;
                continue;
              case 14:
                str2 = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(str2, ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3176293901U), (object) str5, (object) str4));
                num3 = (int) num5 * -866354755 ^ 1317948525;
                continue;
              case 15:
                str4 = zoomZoomDataTable.GetColumnValueFormatted(column, data);
                num3 = (int) num5 * 201363053 ^ 1273584694;
                continue;
              case 16:
                num3 = 344404802;
                continue;
              case 17:
                str1 = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(str1, ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3432926559U), (object) str5, (object) str3));
                num3 = (int) num5 * -283462988 ^ 1767593306;
                continue;
              case 18:
                numArray = data[ZoomZoomDatabase.\u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮(column)] as byte[];
                flag3 = numArray != null;
                num3 = (int) num5 * -1725285663 ^ 1278084580;
                continue;
              case 19:
                str3 = ZoomZoomDatabase.\u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮(column);
                num3 = (int) num5 * 341641013 ^ 711043315;
                continue;
              case 20:
                str4 = (string) null;
                flag4 = ZoomZoomDataTable.GetDataType(ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(ZoomZoomDatabase.\u202C‭​‬‫‌‭⁯​⁬‏‬⁬‮‎⁫​⁪‏‪⁮⁮⁯⁮‏⁯‎‬⁬‮⁪‬‬⁪⁯‏⁭‏‌‪‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(column), (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2225497590U)))) == SqlDataType.BLOB;
                num3 = (int) num5 * -1605143588 ^ -265373901;
                continue;
              case 21:
                int num10 = flag5 ? 786399952 : (num10 = 1683301642);
                int num11 = (int) num5 * -292845411;
                num3 = num10 ^ num11;
                continue;
              case 22:
                int num12 = !flag3 ? 1242730371 : (num12 = 1624264817);
                int num13 = (int) num5 * 1459640746;
                num3 = num12 ^ num13;
                continue;
              case 23:
                num3 = 293184189;
                continue;
              default:
                goto label_51;
            }
            str5 = str6;
            num3 = 732514779;
          }
        }
        finally
        {
          IDisposable disposable = enumerator1 as IDisposable;
label_45:
          int num3 = 651167920;
          while (true)
          {
            int num4 = 555250704;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 5U)
            {
              case 0:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮(disposable);
                num3 = (int) num5 * -8529116 ^ 212109836;
                continue;
              case 1:
                int num6 = disposable == null ? 1739511241 : (num6 = 550995319);
                int num7 = (int) num5 * 1459045020;
                num3 = num6 ^ num7;
                continue;
              case 3:
                goto label_45;
              case 4:
                num3 = (int) num5 * 2043081146 ^ -389564535;
                continue;
              default:
                goto label_50;
            }
          }
label_50:;
        }
label_51:
        sSQL = ZoomZoomDatabase.\u202E‬​⁬‬‪‎⁮‪‌‍‪‎⁮⁬‪⁪‫‍‮⁯⁪‌‌‮⁮‏‪‎‎‌‬⁬⁪⁫⁯​‍⁮⁮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1083094860U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(zoomZoomDataTable.Table), (object) str1, (object) str2);
label_52:
        int num14 = 910089809;
label_53:
        while (true)
        {
          int num3 = 555250704;
          uint num4;
          switch ((num4 = (uint) (num14 ^ num3)) % 5U)
          {
            case 0:
              goto label_52;
            case 1:
              num14 = (int) num4 * -2102474987 ^ -323901467;
              continue;
            case 2:
              goto label_55;
            case 4:
              goto label_85;
            default:
              goto label_56;
          }
        }
label_56:
        IEnumerator enumerator2 = ZoomZoomDatabase.\u206F‌‬‭‍‍‏‏⁪​‮⁬⁭‏⁯⁪‍‌‎⁫⁬‪‬⁭‍⁯​‫‪‏‭‎‪⁭‏⁬‮⁬‮‌‮((InternalDataCollectionBase) ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(zoomZoomDataTable.Table));
        string str7;
        try
        {
label_68:
          int num3 = !ZoomZoomDatabase.\u206B‌‌‪‫⁪‪⁯⁪⁫‮‌​‫⁫‮⁬⁫⁯‏⁯‭⁭‍‪‪‌‌‪‫⁭‫​‪‏‬‎‌⁮‮(enumerator2) ? 2127014397 : (num3 = 813659743);
          while (true)
          {
            int num4 = 555250704;
            uint num5;
            DataColumn column;
            bool flag2;
            byte[] numArray;
            SqlDataType dataType;
            switch ((num5 = (uint) (num3 ^ num4)) % 16U)
            {
              case 0:
                parameters.Add(ZoomZoomDatabase.\u206A‏‪​‭​⁭‬‬⁭⁪‮⁫‮‌⁯‬‎‌‏‮‪⁫⁯‭​‍‌​⁪‫‬‬⁫⁯​⁭‭‬‌‮(ZoomZoomDatabase.\u200B‌⁬‫⁪‮⁬‌‪‮​‌⁯‬‎‬‬‍⁮⁯⁮‏‎​‏‏⁬⁫‪‌‮⁮⁫⁭‮‏‪⁪​⁯‮((object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(757387218U), (object) parameters.Count), (object) numArray));
                num3 = (int) num5 * 525861257 ^ -1195618084;
                continue;
              case 1:
                num3 = (int) num5 * -670993046 ^ -1730065551;
                continue;
              case 2:
                num3 = 813659743;
                continue;
              case 3:
                int num6;
                num3 = num6 = !ZoomZoomDatabase.\u206B‭‎⁫‌​⁫‪‭‭‮‎‫‍⁫⁭‭⁮‌⁭‪‭‎‪‎‫‪‎⁮‌⁭‎​​⁪⁭⁮⁫‭⁪‮(column) ? 666073944 : (num6 = 779156923);
                continue;
              case 4:
                int num7 = dataType != SqlDataType.BLOB ? 1200236303 : (num7 = 1265852486);
                int num8 = (int) num5 * -1681891505;
                num3 = num7 ^ num8;
                continue;
              case 5:
                dataType = ZoomZoomDataTable.GetDataType(ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(ZoomZoomDatabase.\u202C‭​‬‫‌‭⁯​⁬‏‬⁬‮‎⁫​⁪‏‪⁮⁮⁯⁮‏⁯‎‬⁬‮⁪‬‬⁪⁯‏⁭‏‌‪‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(column), (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2155820314U))));
                num3 = (int) num5 * 1210023536 ^ -1084246908;
                continue;
              case 6:
                goto label_68;
              case 7:
                int num9 = !flag2 ? 182620214 : (num9 = 295603962);
                int num10 = (int) num5 * 1864179782;
                num3 = num9 ^ num10;
                continue;
              case 8:
                num3 = (int) num5 * 1165305517 ^ 1930970785;
                continue;
              case 9:
                str7 = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(str7, ZoomZoomDatabase.\u202E‬​⁬‬‪‎⁮‪‌‍‪‎⁮⁬‪⁪‫‍‮⁯⁪‌‌‮⁮‏‪‎‎‌‬⁬⁪⁫⁯​‍⁮⁮‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1884931443U), ZoomZoomDatabase.\u202E⁬⁫‬​⁫‬⁫⁫⁮‭‎‮⁬⁬⁯‫‭⁬‌‪‭‬⁪‬‪​​⁪​⁭‭‌‪‭‪⁮⁯⁬‏‮(str7, string.Empty) ? (object) "" : (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3103914425U), (object) ZoomZoomDatabase.\u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮(column), (object) zoomZoomDataTable.GetColumnValueFormatted(column, data)));
                num3 = 1469059118;
                continue;
              case 10:
                numArray = data[ZoomZoomDatabase.\u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮(column)] as byte[];
                flag2 = numArray != null;
                num3 = (int) num5 * 1198251135 ^ 369693249;
                continue;
              case 11:
                num3 = 1515232374;
                continue;
              case 12:
                str7 = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(str7, ZoomZoomDatabase.\u202E‬​⁬‬‪‎⁮‪‌‍‪‎⁮⁬‪⁪‫‍‮⁯⁪‌‌‮⁮‏‪‎‎‌‬⁬⁪⁫⁯​‍⁮⁮‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2166036284U), ZoomZoomDatabase.\u202E⁬⁫‬​⁫‬⁫⁫⁮‭‎‮⁬⁬⁯‫‭⁬‌‪‭‬⁪‬‪​​⁪​⁭‭‌‪‭‪⁮⁯⁬‏‮(str7, string.Empty) ? (object) "" : (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2802938087U), (object) ZoomZoomDatabase.\u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮(column), (object) (parameters.Count - 1)));
                num3 = 424701921;
                continue;
              case 14:
                num3 = (int) num5 * 138242662 ^ -1460707057;
                continue;
              case 15:
                column = (DataColumn) ZoomZoomDatabase.\u200D‭‪‌‎‌⁯⁮‮⁭‭‌‍⁯⁮‎⁭‬⁮‭⁮‌⁬‏‭‌‌⁫‍‪⁮⁫⁫⁭⁬‬⁫⁭⁬⁯‮(enumerator2);
                num3 = 46356981;
                continue;
              default:
                goto label_81;
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator2 as IDisposable;
label_75:
          int num3 = 293383313;
          while (true)
          {
            int num4 = 555250704;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 5U)
            {
              case 0:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮(disposable);
                num3 = (int) num5 * -901326902 ^ 904117726;
                continue;
              case 1:
                num3 = (int) num5 * 879255833 ^ 154641080;
                continue;
              case 2:
                goto label_75;
              case 3:
                int num6 = disposable == null ? 515145998 : (num6 = 1634766536);
                int num7 = (int) num5 * 1165025416;
                num3 = num6 ^ num7;
                continue;
              default:
                goto label_80;
            }
          }
label_80:;
        }
label_81:
        sSQL = ZoomZoomDatabase.\u202E‬​⁬‬‪‎⁮‪‌‍‪‎⁮⁬‪⁪‫‍‮⁯⁪‌‌‮⁮‏‪‎‎‌‬⁬⁪⁫⁯​‍⁮⁮‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(122383238U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(zoomZoomDataTable.Table), (object) str7, (object) ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(data[\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U)]));
label_82:
        int num15 = 155609755;
label_83:
        while (true)
        {
          int num3 = 555250704;
          uint num4;
          int num5;
          switch ((num4 = (uint) (num15 ^ num3)) % 10U)
          {
            case 0:
              goto label_82;
            case 1:
              num15 = 942254110;
              continue;
            case 2:
              goto label_85;
            case 3:
              num15 = (int) num4 * -1188590480 ^ 434042466;
              continue;
            case 4:
              num15 = (int) num4 * 1366623900 ^ 1682635581;
              continue;
            case 5:
              num15 = (int) num4 * 2136947761 ^ -558340549;
              continue;
            case 6:
              num5 = (long) data[\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U)] == 0L ? 1 : 0;
              break;
            case 7:
              if (flag1)
              {
                num15 = (int) num4 * -2046841355 ^ 1806288585;
                continue;
              }
              num5 = 0;
              break;
            case 9:
              data[\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U)] = (object) ZoomZoomDatabase.\u200C‌⁪‏‪‭‮‫⁯‬‬‏‏⁮‫⁯⁭⁭‎‎‭⁪⁯‫​‬‬⁬⁭⁭‏‌‍⁪⁭⁬⁬‍‏⁫‮(this.cDB);
              num15 = (int) num4 * 36208461 ^ -1345927618;
              continue;
            default:
              goto label_102;
          }
          int num6;
          num15 = num6 = num5 != 0 ? 2105977155 : (num6 = 962328965);
        }
label_85:
        flag1 = this.ExecuteSQL(sSQL, parameters);
        num15 = 1173671605;
        goto label_83;
label_55:
        str7 = string.Empty;
        num14 = 1405945177;
        goto label_53;
      }
      catch (Exception ex)
      {
label_96:
        int num1 = 1036145979;
        while (true)
        {
          int num2 = 555250704;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_96;
            case 1:
              num1 = (int) num3 * 725422300 ^ -1288645337;
              continue;
            case 2:
              num1 = (int) num3 * -880441600 ^ -1387650006;
              continue;
            case 3:
              this.TraceError(ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2886930448U), (object) data, (object) sSQL), ex);
              num1 = (int) num3 * 348464762 ^ 2125245569;
              continue;
            case 5:
              num1 = (int) num3 * -93963248 ^ 1393190976;
              continue;
            default:
              goto label_102;
          }
        }
      }
label_102:
      this.Trace(this.TraceType, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3227539289U), (object) flag1);
label_103:
      int num16 = 166127435;
      bool flag6;
      while (true)
      {
        int num1 = 555250704;
        uint num2;
        switch ((num2 = (uint) (num16 ^ num1)) % 3U)
        {
          case 1:
            flag6 = flag1;
            num16 = (int) num2 * -1754404107 ^ 909059753;
            continue;
          case 2:
            goto label_103;
          default:
            goto label_106;
        }
      }
label_106:
      return flag6;
    }

    internal bool DeleteObject(ObjectDataTable table, Dictionary<string, object> data)
    {
label_1:
      int num1 = -1526134583;
      bool flag1;
      while (true)
      {
        int num2 = -2073361921;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag1 = false;
            this.Trace(this.TraceType, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3391473000U), (object) table, data[\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U)]);
            num1 = (int) num3 * -718333279 ^ 415476947;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      string sSQL = "";
      try
      {
label_6:
        int num2 = -85098171;
        while (true)
        {
          int num3 = -2073361921;
          uint num4;
          string tableName;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              num2 = -1500774517;
              continue;
            case 1:
              int num5 = ZoomZoomDatabase.\u200E⁭‮‏‫‍‍‮‪⁮‍‫‭‮⁮‫⁮‍‮‍‍‍‌‫⁬‎⁯⁬‭⁯⁫⁪‌‌⁫​‮‮⁮‭‮(tableName) ? 2116547724 : (num5 = 974977130);
              int num6 = (int) num4 * 841312883;
              num2 = num5 ^ num6;
              continue;
            case 2:
              tableName = ZoomZoomDataTable.GetTableName(table);
              num2 = (int) num4 * 138725874 ^ -344394662;
              continue;
            case 3:
              flag1 = this.ExecuteSQL(sSQL, (List<SQLiteParameter>) null);
              num2 = (int) num4 * 858542942 ^ 815148290;
              continue;
            case 5:
              goto label_6;
            case 6:
              sSQL = ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4183800802U), (object) tableName, data[\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U)]);
              num2 = (int) num4 * 1693303241 ^ 1034052938;
              continue;
            case 7:
              num2 = (int) num4 * -1598794575 ^ -1796303784;
              continue;
            default:
              goto label_19;
          }
        }
      }
      catch (Exception ex)
      {
label_15:
        int num2 = -246168558;
        while (true)
        {
          int num3 = -2073361921;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              num2 = (int) num4 * -1379350756 ^ 1128737948;
              continue;
            case 2:
              goto label_15;
            case 3:
              this.TraceError(ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3348864061U), sSQL), ex);
              num2 = (int) num4 * -153303828 ^ 1921764763;
              continue;
            default:
              goto label_19;
          }
        }
      }
label_19:
      this.Trace(this.TraceType, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3857864202U), (object) flag1);
label_20:
      int num7 = -956199182;
      bool flag2;
      while (true)
      {
        int num2 = -2073361921;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            goto label_20;
          case 1:
            flag2 = true;
            num7 = (int) num3 * -2011571992 ^ 1691227373;
            continue;
          case 2:
            num7 = (int) num3 * -1883261845 ^ -620808810;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      return flag2;
    }

    internal static string FormatSQL(string stringToFormat)
    {
label_1:
      int num1 = -427446881;
      string str;
      while (true)
      {
        int num2 = -1115463456;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1309991821 ^ 1129379627;
            continue;
          case 3:
            str = ZoomZoomDatabase.\u200E‬‬‍⁫​‪‬⁮⁫‍‭‮‏​‪‬⁯⁫⁫‏‭‬⁯⁬⁭‍‮⁪‪‮​‏⁯‮⁮‫‍‌‎‮(stringToFormat, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1706066243U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3109256304U));
            num1 = (int) num3 * -59328454 ^ -190992416;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    internal static string GetSQLDateFormat(DateTime? dateTime)
    {
label_1:
      int num1 = -1232627136;
      string str1;
      while (true)
      {
        int num2 = -311365504;
        uint num3;
        bool hasValue;
        string str2;
        DateTime dateTime1;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = !hasValue ? 1660440834 : (num4 = 1183104961);
            int num5 = (int) num3 * -1003362798;
            num1 = num4 ^ num5;
            continue;
          case 2:
            str2 = dateTime1.ToString(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(77528033U));
            num1 = (int) num3 * -2073314803 ^ -1825844181;
            continue;
          case 3:
            num1 = (int) num3 * -1912222125 ^ -785726740;
            continue;
          case 4:
            hasValue = dateTime.HasValue;
            num1 = (int) num3 * -773917696 ^ 785044147;
            continue;
          case 5:
            dateTime1 = dateTime.Value;
            num1 = (int) num3 * -11565327 ^ -1797049213;
            continue;
          case 6:
            str2 = "";
            num1 = (int) num3 * 1108076690 ^ 1017945998;
            continue;
          case 8:
            str1 = str2;
            num1 = -1591181879;
            continue;
          case 9:
            num1 = (int) num3 * -259074000 ^ 535601988;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return str1;
    }

    internal bool CreateDatabaseFile()
    {
label_1:
      int num1 = 1283984645;
      bool flag1;
      while (true)
      {
        int num2 = 823493175;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            if (flag2)
            {
              num1 = (int) num3 * 1222264986 ^ -1373352958;
              continue;
            }
            goto label_24;
          case 2:
            flag1 = false;
            flag2 = !this.DatabaseExists();
            num1 = (int) num3 * 2019355962 ^ 14141974;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      try
      {
label_8:
        int num2 = 802961349;
        while (true)
        {
          int num3 = 823493175;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              flag1 = true;
              num2 = (int) num4 * -1599924397 ^ -161529460;
              continue;
            case 1:
              num2 = (int) num4 * 161352126 ^ -459277858;
              continue;
            case 2:
              ZoomZoomDatabase.\u206B‭‬‭‍‏⁭⁬‮⁪​‌‪⁭⁬‎‌⁫⁬‫⁪‭‍‎‌​‏‌⁫⁬‏‎⁬‮⁯⁭⁫‭‍⁭‮(this.sDatabasePath);
              num2 = (int) num4 * -531193021 ^ 1019808328;
              continue;
            case 3:
              num2 = (int) num4 * -407973974 ^ -1124331188;
              continue;
            case 5:
              num2 = 1422199555;
              continue;
            case 6:
              goto label_8;
            case 7:
              int num5 = !ZoomZoomDatabase.\u202B‪​‬⁯⁬‭‫‪‏‭⁯‪‌‪​⁮​⁬⁫‮⁫⁬⁪‎⁮‬‎‮‌⁮‬⁪⁪‌‌‮​⁪‫‮(this.sDatabasePath) ? 1989737043 : (num5 = 1163846278);
              int num6 = (int) num4 * -566803833;
              num2 = num5 ^ num6;
              continue;
            default:
              goto label_21;
          }
        }
      }
      catch (Exception ex)
      {
label_17:
        int num2 = 506694858;
        while (true)
        {
          int num3 = 823493175;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_17;
            case 1:
              ZoomZoomDatabase.\u202C‮⁫⁬⁪‍‫‬⁪‏‌⁯‏‬⁫⁪⁬⁭⁮‌‌⁪‭‎‮⁪‫‌⁮⁯‫⁫‫⁪‪⁯‏⁮⁫‌‮(ZoomZoomDatabase.log, (object) ex);
              num2 = (int) num4 * -543627256 ^ 895917847;
              continue;
            default:
              goto label_20;
          }
        }
label_20:
        throw ex;
      }
label_21:
label_22:
      int num7 = 186040086;
label_23:
      while (true)
      {
        int num2 = 823493175;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            num7 = (int) num3 * 1264111179 ^ -1211900231;
            continue;
          case 1:
            goto label_24;
          case 3:
            goto label_22;
          default:
            goto label_26;
        }
      }
label_26:
      bool flag3;
      return flag3;
label_24:
      flag3 = flag1;
      num7 = 554300995;
      goto label_23;
    }

    private bool OpenDBConnection()
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = -1112662618;
        while (true)
        {
          int num2 = -1739893569;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 1771359250 ^ 1309354140;
              continue;
            case 1:
              int num4 = this.cDB == null ? -1404267656 : (num4 = -150020038);
              int num5 = (int) num3 * -602645033;
              num1 = num4 ^ num5;
              continue;
            case 2:
              flag1 = true;
              num1 = (int) num3 * 1482467938 ^ 1723177793;
              continue;
            case 3:
              goto label_2;
            case 5:
              this.cDB = ZoomZoomDatabase.\u206E‮⁪‎‮⁫‭‮⁪‎‪‭‎⁬‮‌⁫‏‭‎⁮⁪‍⁭⁯⁭⁮‭‎​‬‮‎‏‮‌‏​⁭⁮‮(this.ConnectionString);
              ZoomZoomDatabase.\u206B⁭‬‎‪⁭‮‭‭‍‭‎⁫‌⁫‍‏‫⁭⁮‪⁮‭‪‌‮⁬⁮‎⁫‎‏‭⁭⁬‪⁭‎⁭‎‮((DbConnection) this.cDB);
              num1 = (int) num3 * 1605392155 ^ -702682212;
              continue;
            default:
              goto label_9;
          }
        }
      }
      catch (Exception ex)
      {
        ZoomZoomDatabase.\u202C‮⁫⁬⁪‍‫‬⁪‏‌⁯‏‬⁫⁪⁬⁭⁮‌‌⁪‭‎‮⁪‫‌⁮⁯‫⁫‫⁪‪⁯‏⁮⁫‌‮(ZoomZoomDatabase.log, (object) ex);
        throw ex;
      }
label_9:
      bool flag2 = flag1;
label_10:
      int num6 = -969033263;
      while (true)
      {
        int num1 = -1739893569;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 1:
            num6 = (int) num2 * 1322334395 ^ -2004236678;
            continue;
          case 2:
            goto label_10;
          default:
            goto label_13;
        }
      }
label_13:
      return flag2;
    }

    public bool UpgradeDatabaseSchema()
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = -498442461;
        while (true)
        {
          int num2 = -2110803584;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -23507329 ^ -1586422061;
              continue;
            case 1:
              this.Trace(this.TraceType, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3430535528U));
              num1 = (int) num3 * -1268246259 ^ -2091903771;
              continue;
            case 2:
              flag2 = this.OpenDBConnection();
              num1 = (int) num3 * 885165917 ^ -1970169891;
              continue;
            case 3:
              if (flag2)
              {
                num1 = (int) num3 * 540595099 ^ -877722929;
                continue;
              }
              goto label_42;
            case 4:
              goto label_2;
            default:
              goto label_9;
          }
        }
label_9:
        // ISSUE: type reference
        IEnumerator enumerator = ZoomZoomDatabase.\u206D⁫‬‌‮⁮⁫⁮⁪‭⁯‎‌​⁯⁯⁭‫⁭⁮‌‏‪​⁫⁭⁪‬‬‍‍‎⁮‭​⁪⁮⁬⁪‮(ZoomZoomDatabase.\u200B⁫​⁫⁭‭⁬​‌‮‭‮⁬⁯‌​‫⁪‮‏‬⁭‎⁪⁭⁯​⁮‏‎⁫‫⁯‭‪‭‍⁫‏‏‮(ZoomZoomDatabase.\u206F‫⁬⁬‌⁯⁪‮​⁭⁪‎​‬‪⁬‍‬‎​⁫⁫‭‮‭‏⁮‪‫⁯‬‫‏⁬⁭‫⁭⁭‮‪‮(__typeref (ObjectDataTable))));
        try
        {
label_25:
          int num2 = ZoomZoomDatabase.\u206B‌‌‪‫⁪‪⁯⁪⁫‮‌​‫⁫‮⁬⁫⁯‏⁯‭⁭‍‪‪‌‌‪‫⁭‫​‪‏‬‎‌⁮‮(enumerator) ? -868707773 : (num2 = -184267357);
          while (true)
          {
            int num3 = -2110803584;
            uint num4;
            ObjectDataTable zTable;
            DataTable table;
            bool flag2;
            int num5;
            switch ((num4 = (uint) (num2 ^ num3)) % 18U)
            {
              case 0:
                goto label_25;
              case 1:
                if (zTable == ObjectDataTable.Unkonown)
                {
                  num5 = 0;
                  break;
                }
                num2 = (int) num4 * -1460806077 ^ -1797715101;
                continue;
              case 2:
                table = new ZoomZoomDataTable(zTable).Table;
                num2 = (int) num4 * -1027884521 ^ 1862998645;
                continue;
              case 3:
                num2 = (int) num4 * 232022379 ^ 1340247706;
                continue;
              case 4:
                num2 = -953966592;
                continue;
              case 6:
                num2 = -868707773;
                continue;
              case 7:
                zTable = (ObjectDataTable) ZoomZoomDatabase.\u200D‭‪‌‎‌⁯⁮‮⁭‭‌‍⁯⁮‎⁭‬⁮‭⁮‌⁬‏‭‌‌⁫‍‪⁮⁫⁫⁭⁬‬⁫⁭⁬⁯‮(enumerator);
                num2 = -1407966686;
                continue;
              case 8:
                this.CreateTable(table);
                num2 = (int) num4 * 2010057512 ^ 285974675;
                continue;
              case 9:
                num2 = -625265258;
                continue;
              case 10:
                num2 = (int) num4 * -1044814924 ^ 1877814278;
                continue;
              case 11:
                num2 = -1134138855;
                continue;
              case 12:
                this.Trace(this.TraceType, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2616686853U), (object) zTable);
                num2 = (int) num4 * -943231335 ^ 1392721307;
                continue;
              case 13:
                int num6 = !flag2 ? 362239996 : (num6 = 342718815);
                int num7 = (int) num4 * -1825736640;
                num2 = num6 ^ num7;
                continue;
              case 14:
                num5 = zTable != ObjectDataTable.NotSupported ? 1 : 0;
                break;
              case 15:
                flag2 = !this.TableExists(ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(table));
                num2 = (int) num4 * -1289864208 ^ -141304257;
                continue;
              case 16:
                this.Trace(this.TraceType, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(654173786U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(table));
                this.UpdateTableColumns(table);
                num2 = (int) num4 * -802684925 ^ 1754189147;
                continue;
              case 17:
                this.Trace(this.TraceType, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(33592458U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(table));
                num2 = (int) num4 * -570070498 ^ -718881982;
                continue;
              default:
                goto label_37;
            }
            int num8;
            num2 = num8 = num5 == 0 ? -1134138855 : (num8 = -2080212444);
          }
        }
        finally
        {
          IDisposable disposable = enumerator as IDisposable;
          if (disposable != null)
          {
label_33:
            int num2 = -1471585613;
            while (true)
            {
              int num3 = -2110803584;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 1:
                  ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮(disposable);
                  num2 = (int) num4 * 1780702492 ^ 1305129221;
                  continue;
                case 2:
                  goto label_33;
                default:
                  goto label_36;
              }
            }
          }
label_36:;
        }
label_37:
        flag1 = true;
label_38:
        int num9 = -1054546959;
label_39:
        while (true)
        {
          int num2 = -2110803584;
          uint num3;
          switch ((num3 = (uint) (num9 ^ num2)) % 8U)
          {
            case 0:
              goto label_42;
            case 1:
              num9 = (int) num3 * -724063494 ^ 1384972309;
              continue;
            case 2:
              num9 = (int) num3 * 1080571617 ^ 1877131849;
              continue;
            case 4:
              num9 = (int) num3 * 1614537887 ^ 811837494;
              continue;
            case 5:
              goto label_38;
            case 6:
              this.Trace(this.TraceType, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(207530327U));
              num9 = (int) num3 * 764158402 ^ 282195624;
              continue;
            case 7:
              num9 = (int) num3 * -1920963271 ^ -2103099868;
              continue;
            default:
              goto label_53;
          }
        }
label_42:
        num9 = -411878930;
        goto label_39;
      }
      catch (Exception ex)
      {
label_47:
        int num1 = -614857824;
        while (true)
        {
          int num2 = -2110803584;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_47;
            case 1:
              num1 = (int) num3 * 160580403 ^ -527454213;
              continue;
            case 2:
              ZoomZoomDatabase.\u202C‮⁫⁬⁪‍‫‬⁪‏‌⁯‏‬⁫⁪⁬⁭⁮‌‌⁪‭‎‮⁪‫‌⁮⁯‫⁫‫⁪‪⁯‏⁮⁫‌‮(ZoomZoomDatabase.log, (object) ex);
              num1 = (int) num3 * 891839677 ^ 902733994;
              continue;
            case 3:
              this.TraceError(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2631916688U), ex);
              num1 = (int) num3 * 997597158 ^ -727274943;
              continue;
            default:
              goto label_52;
          }
        }
label_52:
        throw ex;
      }
label_53:
      bool flag3 = flag1;
label_54:
      int num10 = -2024653521;
      while (true)
      {
        int num1 = -2110803584;
        uint num2;
        switch ((num2 = (uint) (num10 ^ num1)) % 3U)
        {
          case 1:
            num10 = (int) num2 * -981742960 ^ -78851083;
            continue;
          case 2:
            goto label_54;
          default:
            goto label_57;
        }
      }
label_57:
      return flag3;
    }

    private void CreateTable(DataTable dataTable)
    {
      string str1 = string.Empty;
label_1:
      int num1 = 1747247390;
      while (true)
      {
        int num2 = 101604291;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1516793146 ^ -2127310043;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      IEnumerator enumerator = ZoomZoomDatabase.\u206F‌‬‭‍‍‏‏⁪​‮⁬⁭‏⁯⁪‍‌‎⁫⁬‪‬⁭‍⁯​‫‪‏‭‎‪⁭‏⁬‮⁬‮‌‮((InternalDataCollectionBase) ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable));
      try
      {
label_25:
        int num2 = ZoomZoomDatabase.\u206B‌‌‪‫⁪‪⁯⁪⁫‮‌​‫⁫‮⁬⁫⁯‏⁯‭⁭‍‪‪‌‌‪‫⁭‫​‪‏‬‎‌⁮‮(enumerator) ? 801154659 : (num2 = 1033085935);
        string str2;
        while (true)
        {
          int num3 = 101604291;
          uint num4;
          string str3;
          bool flag1;
          DataColumn dataColumn;
          bool flag2;
          bool flag3;
          switch ((num4 = (uint) (num2 ^ num3)) % 22U)
          {
            case 0:
              flag3 = ZoomZoomDatabase.\u202A‭⁪⁫‬‎‫⁫⁫⁫⁪⁫⁮‬⁪‮‎‎​‏⁪⁬⁫⁭⁭​‬‮⁬‭‪‍‍‎⁪​‍‌‏‌‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), str2)), (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4228246918U));
              num2 = (int) num4 * 584184879 ^ -1321382765;
              continue;
            case 1:
              int num5 = flag1 ? 210942042 : (num5 = 121595622);
              int num6 = (int) num4 * -1798085979;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = (int) num4 * 534573857 ^ 1393981753;
              continue;
            case 3:
              str3 = ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(ZoomZoomDatabase.\u202C‭​‬‫‌‭⁯​⁬‏‬⁬‮‎⁫​⁪‏‪⁮⁮⁯⁮‏⁯‎‬⁬‮⁪‬‬⁪⁯‏⁭‏‌‪‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), str2)), (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4025150799U)));
              num2 = (int) num4 * -1445726529 ^ 866335861;
              continue;
            case 4:
              str1 = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1916700795U));
              num2 = (int) num4 * -821073847 ^ 343736775;
              continue;
            case 5:
              str1 = ZoomZoomDatabase.\u206D‮‪⁪⁯‍‪‪‎⁫⁫‏‬‍‎‮⁪‌‫⁬⁭‪⁯⁮⁪‍‮‍‍‌⁯‭‮⁭‬‫⁪⁯​⁪‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3515778971U), ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(ZoomZoomDatabase.\u202C‭​‬‫‌‭⁯​⁬‏‬⁬‮‎⁫​⁪‏‪⁮⁮⁯⁮‏⁯‎‬⁬‮⁪‬‬⁪⁯‏⁭‏‌‪‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), str2)), (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(442833794U))));
              num2 = (int) num4 * -1959722762 ^ -7900158;
              continue;
            case 6:
              int num7 = flag2 ? -833271369 : (num7 = -728888786);
              int num8 = (int) num4 * -1708317814;
              num2 = num7 ^ num8;
              continue;
            case 7:
              num2 = 937369020;
              continue;
            case 8:
              dataColumn = (DataColumn) ZoomZoomDatabase.\u200D‭‪‌‎‌⁯⁮‮⁭‭‌‍⁯⁮‎⁭‬⁮‭⁮‌⁬‏‭‌‌⁫‍‪⁮⁫⁫⁭⁬‬⁫⁭⁬⁯‮(enumerator);
              num2 = 1276917644;
              continue;
            case 9:
              num2 = 801154659;
              continue;
            case 11:
              str2 = ZoomZoomDatabase.\u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮(dataColumn);
              flag2 = ZoomZoomDatabase.\u202A‭⁪⁫‬‎‫⁫⁫⁫⁪⁫⁮‬⁪‮‎‎​‏⁪⁬⁫⁭⁭​‬‮⁬‭‪‍‍‎⁪​‍‌‏‌‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), str2)), (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4025150799U));
              num2 = (int) num4 * -164509147 ^ -1016563968;
              continue;
            case 12:
              num2 = 58644862;
              continue;
            case 13:
              flag1 = !ZoomZoomDatabase.\u202E⁬⁫‬​⁫‬⁫⁫⁮‭‎‮⁬⁬⁯‫‭⁬‌‪‭‬⁪‬‪​​⁪​⁭‭‌‪‭‪⁮⁯⁬‏‮(str1, string.Empty);
              num2 = (int) num4 * 760551020 ^ 1849665256;
              continue;
            case 14:
              str1 = ZoomZoomDatabase.\u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮(str1, ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2679727913U), (object) str2, (object) str3));
              num2 = 875472303;
              continue;
            case 15:
              num2 = (int) num4 * -806894926 ^ 578675914;
              continue;
            case 16:
              num2 = (int) num4 * 1709019714 ^ 1985937277;
              continue;
            case 17:
              goto label_25;
            case 18:
              num2 = (int) num4 * -1111036106 ^ 401458854;
              continue;
            case 19:
              goto label_9;
            case 20:
              int num9 = flag3 ? 436213634 : (num9 = 1194817904);
              int num10 = (int) num4 * -785632848;
              num2 = num9 ^ num10;
              continue;
            case 21:
              num2 = (int) num4 * -1902237666 ^ 1424956685;
              continue;
            default:
              goto label_34;
          }
        }
label_9:
        throw ZoomZoomDatabase.\u200B‮‫‫⁯‎⁯​⁮​‏​‍​‫‎⁪⁮‫‏‌‬⁯‫⁯​⁭‭⁮‍‏⁮‮‌‌⁫⁯‍⁯‍‮(ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2396532501U), (object) str2));
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
        {
label_29:
          int num2 = 495996424;
          while (true)
          {
            int num3 = 101604291;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 1773760059 ^ 1090240090;
                continue;
              case 2:
                goto label_29;
              case 3:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮(disposable);
                num2 = (int) num4 * -339012668 ^ -301895657;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
label_34:
      string sSQL = ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1402996739U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(dataTable), (object) str1);
      this.Trace(this.TraceType, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2477420682U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(dataTable), (object) sSQL);
label_35:
      int num11 = 1525893178;
      while (true)
      {
        int num2 = 101604291;
        uint num3;
        switch ((num3 = (uint) (num11 ^ num2)) % 3U)
        {
          case 1:
            num11 = (int) num3 * -673740678 ^ -833837500;
            continue;
          case 2:
            goto label_35;
          default:
            goto label_38;
        }
      }
label_38:
      this.ExecuteSQL(sSQL, (List<SQLiteParameter>) null);
    }

    private void UpdateTableColumns(DataTable dataTable)
    {
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      IEnumerator enumerator1 = ZoomZoomDatabase.\u206F‌‬‭‍‍‏‏⁪​‮⁬⁭‏⁯⁪‍‌‎⁫⁬‪‬⁭‍⁯​‫‪‏‭‎‪⁭‏⁬‮⁬‮‌‮((InternalDataCollectionBase) ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable));
      try
      {
label_4:
        int num1 = ZoomZoomDatabase.\u206B‌‌‪‫⁪‪⁯⁪⁫‮‌​‫⁫‮⁬⁫⁯‏⁯‭⁭‍‪‪‌‌‪‫⁭‫​‪‏‬‎‌⁮‮(enumerator1) ? -233948754 : (num1 = -365379863);
        while (true)
        {
          int num2 = -1431974504;
          uint num3;
          DataColumn dataColumn;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = -233948754;
              continue;
            case 1:
              stringList2.Add(ZoomZoomDatabase.\u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮(dataColumn));
              num1 = (int) num3 * -1074396748 ^ -1668942700;
              continue;
            case 2:
              dataColumn = (DataColumn) ZoomZoomDatabase.\u200D‭‪‌‎‌⁯⁮‮⁭‭‌‍⁯⁮‎⁭‬⁮‭⁮‌⁬‏‭‌‌⁫‍‪⁮⁫⁫⁭⁬‬⁫⁭⁬⁯‮(enumerator1);
              num1 = -1443539429;
              continue;
            case 3:
              num1 = (int) num3 * 2070716397 ^ 1289781536;
              continue;
            case 4:
              goto label_4;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        IDisposable disposable = enumerator1 as IDisposable;
label_9:
        int num1 = -1418149802;
        while (true)
        {
          int num2 = -1431974504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_9;
            case 2:
              int num4 = disposable == null ? 537552023 : (num4 = 119748997);
              int num5 = (int) num3 * 1457643371;
              num1 = num4 ^ num5;
              continue;
            case 3:
              ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮(disposable);
              num1 = (int) num3 * 976002084 ^ -1301224591;
              continue;
            default:
              goto label_13;
          }
        }
label_13:;
      }
label_14:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_16:
        int num1 = -1628837005;
        while (true)
        {
          int num2 = -1431974504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num1 = (int) num3 * -1399466508 ^ -1585221363;
              continue;
            case 2:
              goto label_16;
            case 3:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3242867614U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(dataTable)));
              num1 = (int) num3 * -475679773 ^ -62198795;
              continue;
            default:
              goto label_20;
          }
        }
label_20:
        SQLiteDataReader sqLiteDataReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
        try
        {
label_29:
          bool flag1 = ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) sqLiteDataReader);
          int num2 = -984448649;
          while (true)
          {
            int num3 = -1431974504;
            uint num4;
            bool flag2;
            string fieldValueString;
            switch ((num4 = (uint) (num2 ^ num3)) % 10U)
            {
              case 0:
                num2 = (int) num4 * 1136996840 ^ 1391410265;
                continue;
              case 2:
                num2 = -719148053;
                continue;
              case 3:
                int num5 = !flag1 ? 1780755249 : (num5 = 1295347893);
                int num6 = (int) num4 * -1493313918;
                num2 = num5 ^ num6;
                continue;
              case 4:
                stringList1.Add(fieldValueString);
                num2 = -1983335966;
                continue;
              case 5:
                num2 = -76643374;
                continue;
              case 6:
                goto label_29;
              case 7:
                int num7 = !flag2 ? -340732512 : (num7 = -1507774816);
                int num8 = (int) num4 * 9261666;
                num2 = num7 ^ num8;
                continue;
              case 8:
                stringList2.Remove(fieldValueString);
                num2 = (int) num4 * -1794104832 ^ -987596599;
                continue;
              case 9:
                fieldValueString = sqLiteDataReader.GetFieldValueString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3375854762U));
                flag2 = stringList2.Contains(fieldValueString);
                num2 = -241929985;
                continue;
              default:
                goto label_43;
            }
          }
        }
        finally
        {
          if (sqLiteDataReader != null)
          {
label_33:
            int num2 = -54687120;
            while (true)
            {
              int num3 = -1431974504;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_33;
                case 2:
                  ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteDataReader);
                  num2 = (int) num4 * -1206438775 ^ -666604477;
                  continue;
                default:
                  goto label_36;
              }
            }
          }
label_36:;
        }
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_38:
          int num1 = -1422318862;
          while (true)
          {
            int num2 = -1431974504;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_38;
              case 1:
                num1 = (int) num3 * -1295846498 ^ -533262495;
                continue;
              case 2:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num1 = (int) num3 * 1315707922 ^ 987270405;
                continue;
              default:
                goto label_42;
            }
          }
        }
label_42:;
      }
label_43:
      List<string>.Enumerator enumerator2 = stringList2.GetEnumerator();
      try
      {
label_61:
        int num1 = enumerator2.MoveNext() ? -620035757 : (num1 = -1151806151);
        while (true)
        {
          int num2 = -1431974504;
          uint num3;
          string current;
          string str;
          string sSQL;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              num1 = (int) num3 * 1709011426 ^ 1699533304;
              continue;
            case 1:
              current = enumerator2.Current;
              num1 = -1292111024;
              continue;
            case 2:
              num1 = (int) num3 * -796632478 ^ -1849599492;
              continue;
            case 3:
              num1 = (int) num3 * 1850268715 ^ -486439091;
              continue;
            case 4:
              goto label_61;
            case 5:
              str = ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(ZoomZoomDatabase.\u202C‭​‬‫‌‭⁯​⁬‏‬⁬‮‎⁫​⁪‏‪⁮⁮⁯⁮‏⁯‎‬⁬‮⁪‬‬⁪⁯‏⁭‏‌‪‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), current)), (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2225497590U)));
              num1 = (int) num3 * 435987171 ^ 648749274;
              continue;
            case 6:
              num1 = (int) num3 * 1574903940 ^ 1205148449;
              continue;
            case 7:
              int num4 = ZoomZoomDatabase.\u202A‭⁪⁫‬‎‫⁫⁫⁫⁪⁫⁮‬⁪‮‎‎​‏⁪⁬⁫⁭⁭​‬‮⁬‭‪‍‍‎⁪​‍‌‏‌‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), current)), (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(959304018U)) ? 2135424236 : (num4 = 303532412);
              int num5 = (int) num3 * 1088608004;
              num1 = num4 ^ num5;
              continue;
            case 8:
              sSQL = ZoomZoomDatabase.\u206D‮‪⁪⁯‍‪‪‎⁫⁫‏‬‍‎‮⁪‌‫⁬⁭‪⁯⁮⁪‍‮‍‍‌⁯‭‮⁭‬‫⁪⁯​⁪‮(sSQL, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3518570259U), ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(ZoomZoomDatabase.\u202C‭​‬‫‌‭⁯​⁬‏‬⁬‮‎⁫​⁪‏‪⁮⁮⁯⁮‏⁯‎‬⁬‮⁪‬‬⁪⁯‏⁭‏‌‪‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), current)), (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(442833794U))));
              num1 = (int) num3 * -90367069 ^ 1549185656;
              continue;
            case 9:
              sSQL = ZoomZoomDatabase.\u202E‬​⁬‬‪‎⁮‪‌‍‪‎⁮⁬‪⁪‫‍‮⁯⁪‌‌‮⁮‏‪‎‎‌‬⁬⁪⁫⁯​‍⁮⁮‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3839354895U), (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(dataTable), (object) current, (object) str);
              num1 = (int) num3 * 270401902 ^ -1233030107;
              continue;
            case 10:
              this.ExecuteSQL(sSQL, (List<SQLiteParameter>) null);
              num1 = -898286691;
              continue;
            case 12:
              num1 = (int) num3 * -464405953 ^ -1885897865;
              continue;
            case 13:
              num1 = -1359617782;
              continue;
            case 14:
              flag = ZoomZoomDatabase.\u202A‭⁪⁫‬‎‫⁫⁫⁫⁪⁫⁮‬⁪‮‎‎​‏⁪⁬⁫⁭⁭​‬‮⁬‭‪‍‍‎⁪​‍‌‏‌‮((Hashtable) ZoomZoomDatabase.\u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮(ZoomZoomDatabase.\u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮(ZoomZoomDatabase.\u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮(dataTable), current)), (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4025150799U));
              num1 = (int) num3 * 1167046901 ^ -185987731;
              continue;
            case 15:
              ZoomZoomDatabase.\u200B⁮‏⁮⁪‎‮‌⁪⁫‌‬‪⁭‪‌​‭‍‭⁬⁪⁬⁬‭⁬‏‏⁭‎⁯‌‪‏‭‭‭‪‍‪‮(ZoomZoomDatabase.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3960856611U), (object) current, (object) ZoomZoomDatabase.\u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮(dataTable));
              num1 = -1664791726;
              continue;
            case 16:
              num1 = -620035757;
              continue;
            case 17:
              int num6 = flag ? -1863493549 : (num6 = -1694649737);
              int num7 = (int) num3 * 354529436;
              num1 = num6 ^ num7;
              continue;
            default:
              goto label_68;
          }
        }
      }
      finally
      {
        enumerator2.Dispose();
label_64:
        int num1 = -349842563;
        while (true)
        {
          int num2 = -1431974504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_64;
            case 2:
              num1 = (int) num3 * 415684734 ^ 439131088;
              continue;
            default:
              goto label_67;
          }
        }
label_67:;
      }
label_68:
      using (List<string>.Enumerator enumerator3 = stringList1.GetEnumerator())
      {
label_73:
        int num1 = !enumerator3.MoveNext() ? -2135792401 : (num1 = -430943319);
        while (true)
        {
          int num2 = -1431974504;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = -430943319;
              continue;
            case 1:
              num1 = (int) num3 * -1357352785 ^ 2124436991;
              continue;
            case 2:
              num1 = (int) num3 * -754773039 ^ 1310964725;
              continue;
            case 3:
              string current = enumerator3.Current;
              num1 = -452223344;
              continue;
            case 4:
              goto label_73;
            case 5:
              goto label_77;
            default:
              goto label_72;
          }
        }
label_72:
        return;
label_77:;
      }
    }

    private bool TableExists(string tableName)
    {
label_1:
      int num1 = 1318296263;
      bool flag1;
      while (true)
      {
        int num2 = 2103118148;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * 981682432 ^ -1521682293;
            continue;
          case 1:
            flag1 = true;
            num1 = (int) num3 * -1914920908 ^ 785938128;
            continue;
          case 2:
            int num4 = flag2 ? 302992287 : (num4 = 1959235664);
            int num5 = (int) num3 * -904217263;
            num1 = num4 ^ num5;
            continue;
          case 3:
            flag2 = this.GetSQLScalar_Long(ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2242568852U), (object) tableName)) > 0L;
            num1 = (int) num3 * -478376999 ^ 2025448701;
            continue;
          case 4:
            goto label_1;
          case 5:
            flag1 = false;
            num1 = (int) num3 * 2068265138 ^ 1889305393;
            continue;
          case 6:
            num1 = 1110049889;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return flag1;
    }

    internal string GetSQLScalar_String(string sSQL)
    {
label_1:
      int num1 = -830988392;
      string str;
      while (true)
      {
        int num2 = -1488007339;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            str = ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(this.GetSQLScalar_Object(sSQL));
            num1 = (int) num3 * 134409759 ^ 1328963140;
            continue;
          case 2:
            num1 = (int) num3 * 1670460949 ^ 1723232939;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    internal long GetSQLScalar_Long(string sSQL)
    {
label_1:
      int num1 = 645137346;
      long num2;
      while (true)
      {
        int num3 = 122172192;
        uint num4;
        object sqlScalarObject;
        long result;
        bool flag;
        long num5;
        switch ((num4 = (uint) (num1 ^ num3)) % 11U)
        {
          case 0:
            sqlScalarObject = this.GetSQLScalar_Object(sSQL);
            num1 = (int) num4 * -1514068802 ^ 374801090;
            continue;
          case 1:
            num1 = (int) num4 * 877931238 ^ -417399455;
            continue;
          case 2:
            num5 = result;
            num1 = (int) num4 * 1378549769 ^ -1273374698;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num4 * -1273672659 ^ -1837708896;
            continue;
          case 6:
            num1 = (int) num4 * 1566232487 ^ -373974570;
            continue;
          case 7:
            flag = long.TryParse(ZoomZoomDatabase.\u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮(sqlScalarObject), out result);
            num1 = (int) num4 * -261816866 ^ -1720022054;
            continue;
          case 8:
            num5 = 0L;
            result = 0L;
            num1 = (int) num4 * 1934016049 ^ -666912673;
            continue;
          case 9:
            int num6 = !flag ? -1790209869 : (num6 = -250167663);
            int num7 = (int) num4 * -2058293192;
            num1 = num6 ^ num7;
            continue;
          case 10:
            num2 = num5;
            num1 = 124983968;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return num2;
    }

    internal byte[] GetSQLScalar_Bytes(string sSQL)
    {
label_1:
      int num1 = 1207829465;
      byte[] numArray;
      while (true)
      {
        int num2 = 947898802;
        uint num3;
        byte[] sqlScalarObject;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            int num4 = !flag ? -417814351 : (num4 = -235231821);
            int num5 = (int) num3 * 1504204689;
            num1 = num4 ^ num5;
            continue;
          case 1:
            sqlScalarObject = this.GetSQLScalar_Object(sSQL) as byte[];
            num1 = (int) num3 * -573982545 ^ -2147019640;
            continue;
          case 2:
            num1 = 1593389300;
            continue;
          case 3:
            numArray = (byte[]) null;
            num1 = (int) num3 * 973111825 ^ 1111168559;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 1951945857 ^ -1315600627;
            continue;
          case 6:
            flag = sqlScalarObject != null;
            num1 = (int) num3 * -603332227 ^ 365132067;
            continue;
          case 7:
            numArray = sqlScalarObject;
            num1 = (int) num3 * -2061982079 ^ 2092119220;
            continue;
          case 9:
            num1 = (int) num3 * 624956253 ^ -1928169877;
            continue;
          case 10:
            num1 = (int) num3 * -247181699 ^ 1106240954;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return numArray;
    }

    internal object GetSQLScalar_Object(string sSQL)
    {
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      object obj1;
      try
      {
        ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
label_2:
        int num1 = 430260827;
        while (true)
        {
          int num2 = 1746118713;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              obj1 = ZoomZoomDatabase.\u200F⁫‌⁯‎⁫‭‍‮⁪⁬‪⁭‮‪‍‮‫⁯‮‍‫‪‫⁫‎⁪‎⁬⁭‪⁯‪‮⁮‫‫⁪⁭⁯‮((DbCommand) sqLiteCommand);
              num1 = (int) num3 * -598003755 ^ -100018771;
              continue;
            case 2:
              num1 = (int) num3 * 116844228 ^ -95943490;
              continue;
            case 4:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, sSQL);
              num1 = (int) num3 * 407677312 ^ 1138719900;
              continue;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_8:
          int num1 = 404282691;
          while (true)
          {
            int num2 = 1746118713;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_8;
              case 2:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num1 = (int) num3 * 751138403 ^ -1538004356;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
label_12:
      object obj2 = obj1;
label_13:
      int num4 = 736210504;
      while (true)
      {
        int num1 = 1746118713;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_13;
          case 2:
            num4 = (int) num2 * 1511445910 ^ 977944655;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return obj2;
    }

    internal List<ZoomImage> GetImages(string sSQL)
    {
label_1:
      int num1 = 1503148566;
      List<ZoomImage> zoomImageList1;
      while (true)
      {
        int num2 = 1682738751;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Trace(this.TraceType, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1055355530U));
            num1 = (int) num3 * 800891347 ^ -149263154;
            continue;
          case 2:
            zoomImageList1 = new List<ZoomImage>();
            num1 = (int) num3 * -79986275 ^ 1253978754;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
        ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
label_8:
        int num2 = 1592232242;
        while (true)
        {
          int num3 = 1682738751;
          uint num4;
          ZoomImage zoomImage;
          SQLiteDataReader cReader;
          switch ((num4 = (uint) (num2 ^ num3)) % 12U)
          {
            case 0:
              int num5 = zoomImage != null ? -1711600325 : (num5 = -2077686464);
              int num6 = (int) num4 * -405554255;
              num2 = num5 ^ num6;
              continue;
            case 1:
              zoomImageList1.Add(zoomImage);
              num2 = (int) num4 * 784945595 ^ 1913982791;
              continue;
            case 2:
              cReader = ZoomZoomDatabase.\u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮(sqLiteCommand);
              num2 = (int) num4 * 1813146249 ^ 1581672430;
              continue;
            case 3:
              goto label_8;
            case 4:
              num2 = (int) num4 * -837289596 ^ -832729374;
              continue;
            case 5:
              zoomImage = new ZoomImage(cReader, true);
              num2 = 1469211623;
              continue;
            case 6:
              num2 = (int) num4 * -2030414537 ^ 942269635;
              continue;
            case 7:
              num2 = 838120128;
              continue;
            case 9:
              ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, ZoomZoomDatabase.\u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮(sSQL, new object[0]));
              num2 = (int) num4 * 1575954623 ^ -615878462;
              continue;
            case 10:
              num2 = (int) num4 * 471124846 ^ 1707816883;
              continue;
            case 11:
              int num7;
              num2 = num7 = !ZoomZoomDatabase.\u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮((DbDataReader) cReader) ? 558359025 : (num7 = 639378674);
              continue;
            default:
              goto label_26;
          }
        }
      }
      catch (Exception ex)
      {
        this.TraceError(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2070546888U), ex);
        throw ex;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_22:
          int num2 = 1148000864;
          while (true)
          {
            int num3 = 1682738751;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_22;
              case 2:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num2 = (int) num4 * -426644107 ^ 1505184252;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:
      List<ZoomImage> zoomImageList2 = zoomImageList1;
label_27:
      int num8 = 1188969880;
      while (true)
      {
        int num2 = 1682738751;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 3U)
        {
          case 1:
            num8 = (int) num3 * 1487972848 ^ 906205131;
            continue;
          case 2:
            goto label_27;
          default:
            goto label_30;
        }
      }
label_30:
      return zoomImageList2;
    }

    internal SQLiteCommand GetCommand()
    {
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
label_1:
      int num1 = 1896595340;
      while (true)
      {
        int num2 = 668812653;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -788416602 ^ -154448446;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return sqLiteCommand;
    }

    internal bool ExecuteSQL(string sSQL, List<SQLiteParameter> parameters = null)
    {
label_1:
      int num1 = -1934062573;
      int num2;
      while (true)
      {
        int num3 = -1629504648;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            this.Trace(this.TraceType, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4134975763U), (object) (parameters != null ? parameters.Count : 0), (object) sSQL);
            num1 = -370256515;
            continue;
          case 3:
            num2 = 0;
            num1 = (int) num4 * -1448971838 ^ -1062969544;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      SQLiteCommand sqLiteCommand = ZoomZoomDatabase.\u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮(this.cDB);
      try
      {
label_7:
        int num3 = -1814640866;
        while (true)
        {
          int num4 = -1629504648;
          uint num5;
          bool flag;
          switch ((num5 = (uint) (num3 ^ num4)) % 7U)
          {
            case 0:
              goto label_7;
            case 1:
              if (flag)
              {
                num3 = (int) num5 * 415055816 ^ -1746863092;
                continue;
              }
              goto label_28;
            case 3:
              num3 = (int) num5 * -865531254 ^ 550500076;
              continue;
            case 4:
              num3 = (int) num5 * -957794697 ^ -192171218;
              continue;
            case 5:
              flag = parameters != null;
              num3 = (int) num5 * -2058631439 ^ 127604066;
              continue;
            case 6:
              ZoomZoomDatabase.\u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮((DbCommand) sqLiteCommand, CommandType.Text);
              num3 = (int) num5 * -396200783 ^ -394054250;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        using (List<SQLiteParameter>.Enumerator enumerator = parameters.GetEnumerator())
        {
label_20:
          int num4 = enumerator.MoveNext() ? -1552095263 : (num4 = -215831792);
          while (true)
          {
            int num5 = -1629504648;
            uint num6;
            SQLiteParameter current;
            switch ((num6 = (uint) (num4 ^ num5)) % 7U)
            {
              case 0:
                num4 = (int) num6 * -1644914292 ^ -1965314609;
                continue;
              case 1:
                num4 = (int) num6 * -443691569 ^ -1186839727;
                continue;
              case 2:
                num4 = -1552095263;
                continue;
              case 3:
                ZoomZoomDatabase.\u202A‮⁭⁯‬⁮‌‎‮‬‌‮‏⁬‌⁪⁭​‎‏‪‮‌‏⁯⁬‮⁯⁯‮‭⁭⁬‏⁮‍⁫‫⁪⁬‮(ZoomZoomDatabase.\u206E‬‌‏‌‮​​‪‌‬⁫⁮⁭⁫⁫‪​⁬​‎‎⁪‭⁪‪⁭⁭‍‬‍‍⁮⁬‬‎‫⁯⁪‍‮(sqLiteCommand), current);
                num4 = (int) num6 * -893711083 ^ -1082973359;
                continue;
              case 4:
                goto label_20;
              case 5:
                current = enumerator.Current;
                num4 = -732326940;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:
label_26:
        int num7 = -2048120111;
label_27:
        while (true)
        {
          int num4 = -1629504648;
          uint num5;
          switch ((num5 = (uint) (num7 ^ num4)) % 4U)
          {
            case 0:
              num7 = (int) num5 * 957942968 ^ -375932601;
              continue;
            case 1:
              goto label_28;
            case 2:
              goto label_26;
            default:
              goto label_30;
          }
        }
label_30:
        num2 = ZoomZoomDatabase.\u202B‌‪‎⁮⁮⁭‮⁯‏⁬⁭‏‮⁭⁪‌‌‍⁯​‪‏⁮⁪‫⁫‬‌⁯‬‭⁬‎‭‭‍​⁬⁬‮((DbCommand) sqLiteCommand);
        goto label_37;
label_28:
        ZoomZoomDatabase.\u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮((DbCommand) sqLiteCommand, sSQL);
        num7 = -1215699348;
        goto label_27;
      }
      finally
      {
        if (sqLiteCommand != null)
        {
label_32:
          int num3 = -1264740787;
          while (true)
          {
            int num4 = -1629504648;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 4U)
            {
              case 0:
                num3 = (int) num5 * -1397962725 ^ 1658810382;
                continue;
              case 1:
                ZoomZoomDatabase.\u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮((IDisposable) sqLiteCommand);
                num3 = (int) num5 * 1570746644 ^ -1771847668;
                continue;
              case 3:
                goto label_32;
              default:
                goto label_36;
            }
          }
        }
label_36:;
      }
label_37:
      if (num2 > 0)
        goto label_41;
label_38:
      int num8 = -627445038;
label_39:
      while (true)
      {
        int num3 = -1629504648;
        uint num4;
        switch ((num4 = (uint) (num8 ^ num3)) % 4U)
        {
          case 1:
            num8 = (int) num4 * 884283800 ^ 544020576;
            continue;
          case 2:
            goto label_40;
          case 3:
            goto label_38;
          default:
            goto label_44;
        }
      }
label_40:
      int num9 = 0;
      goto label_42;
label_44:
      bool flag1;
      return flag1;
label_41:
      num9 = 1;
label_42:
      flag1 = num9 != 0;
      num8 = -583902183;
      goto label_39;
    }

    internal void MergeMeetings(ZoomMeeting keepThisMeeting, ZoomMeeting deleteThisMeeting)
    {
      ZoomZoomDatabase.\u200B⁮‏⁮⁪‎‮‌⁪⁫‌‬‪⁭‪‌​‭‍‭⁬⁪⁬⁬‭⁬‏‏⁭‎⁯‌‪‏‭‭‭‪‍‪‮(ZoomZoomDatabase.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3235342012U), (object) deleteThisMeeting.Uri, (object) keepThisMeeting.Uri);
label_1:
      int num1 = 662187768;
      string sSQL1;
      while (true)
      {
        int num2 = 559948032;
        uint num3;
        string sSQL2;
        string sSQL3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            this.ExecuteSQL(sSQL2, (List<SQLiteParameter>) null);
            num1 = (int) num3 * 1145220311 ^ -1439848213;
            continue;
          case 1:
            sSQL3 = ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(355369472U), (object) keepThisMeeting.Uri, (object) deleteThisMeeting.Uri);
            sSQL1 = ZoomZoomDatabase.\u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(471363635U), (object) deleteThisMeeting.Uri);
            num1 = (int) num3 * -216367477 ^ -1692606003;
            continue;
          case 2:
            sSQL2 = ZoomZoomDatabase.\u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(709585954U), (object) keepThisMeeting.Uri, (object) deleteThisMeeting.Uri);
            num1 = (int) num3 * -2070771553 ^ -144295751;
            continue;
          case 3:
            goto label_1;
          case 5:
            this.ExecuteSQL(sSQL3, (List<SQLiteParameter>) null);
            num1 = (int) num3 * -724250342 ^ -486407208;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      this.ExecuteSQL(sSQL1, (List<SQLiteParameter>) null);
    }

    static string \u202E‏‮⁪‫⁫‎​‬‮‌‫‭‪⁯‍‌⁫⁮⁪⁪⁯⁫‬‌‭‎‭‏‏⁯‏⁮⁬‮⁮‌⁯⁪⁬‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u202A‪‬‎‮‏‬‮‬⁭‌‍‫⁯⁫​‎⁪⁮⁫‌‌⁬⁭‌⁫⁫⁪‭‏‮⁫⁫​‌⁯‮‫‭⁪‮([In] string obj0, [In] string obj1)
    {
      return Path.Combine(obj0, obj1);
    }

    static SQLiteCommand \u200D⁯⁪‬⁪‎⁪‫‎‫⁬‮‌​‬‭⁪‌‭‮⁯‌⁭⁪‭‌​⁬⁬‭⁪‍‏‏‌‌‌‫‫‭‮([In] SQLiteConnection obj0)
    {
      return obj0.CreateCommand();
    }

    static void \u202B‬‬⁭⁯⁪‍⁭‫‪‬‬‭‬‏‬⁮‏‬‌‏‪‫‮‬‍‎⁮‬⁪‍⁪‮⁭⁮‬‌‭‪⁮‮([In] DbCommand obj0, [In] CommandType obj1)
    {
      obj0.CommandType = obj1;
    }

    static string \u206D⁬‍⁭⁭‬‌‬‪‫⁫​⁭⁫⁫‌‌⁯‫⁫⁭​⁮‬⁮⁮⁮‭‪⁫‌‮‏⁮‎‮⁯‏⁫‭‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u206C‮⁪‮‮‏‎⁪⁭‎⁯‎​‮‍‪‎⁫‬​‪‌‎⁮‬⁬‌⁬⁫‏​⁭⁭‌⁬‫⁯‫‫‮([In] DbCommand obj0, [In] string obj1)
    {
      obj0.CommandText = obj1;
    }

    static SQLiteDataReader \u202E‫⁪​⁮‏‬‎‍‪​‌‎‬​‪⁭​⁮⁮‬‏‪⁮‏‬‏⁯‬‎⁮‌⁯‌⁪⁭‭‏⁮‍‮([In] SQLiteCommand obj0)
    {
      return obj0.ExecuteReader();
    }

    static object \u206D‮‍​⁮‪‏‮‭‍‭⁯‌‏‪⁮‮⁪‌⁯‭⁬‏‌⁪​‬‭⁫⁬‭‬‭⁭‎‏⁭‭‏⁫‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0[obj1];
    }

    static string \u206E⁪⁬‬‮‬‫‮‮​‫⁬‍⁬‌​‬‌‏⁫‭‌⁯‬⁮⁮‮⁭⁭⁯‬⁬⁫‮‮‎‍​‫⁭‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u202E⁯⁪‍⁮‎‎​⁮‫‍⁯⁯‏‮⁬⁭‪‏‏‪​‭⁬‌‌⁪⁫‭‮‎‭⁯⁯‭‭⁫⁪‬‫‮([In] string obj0)
    {
      return obj0.Trim();
    }

    static bool \u202E⁬⁫‬​⁫‬⁫⁫⁮‭‎‮⁬⁬⁯‫‭⁬‌‪‭‬⁪‬‪​​⁪​⁭‭‌‪‭‪⁮⁯⁬‏‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u206B‏⁯‬⁫‏‫‫⁯​​‍‎‌‏⁮‭‬⁫‏​‭‪‫‌‬‏‪‮‬‪‬‏‎‮‏‭‪‫⁬‮([In] DbDataReader obj0)
    {
      return obj0.Read();
    }

    static void \u206F​‪⁫​‎​⁫⁫⁫‍‪⁮⁪⁫‭‫‏‮⁮⁭⁭⁮‪​‌⁭‮⁭‌⁭⁪⁬⁯⁭‬‭‮‍⁯‮([In] ILog obj0, [In] object obj1, [In] Exception obj2)
    {
      obj0.Error(obj1, obj2);
    }

    static void \u200E‎⁬⁯⁪⁯‏‌‭⁮‬‎‭⁪‫⁪‮‭⁯⁯‌⁭⁫‌⁮⁪⁪⁯‎‍​⁯‫‫​‮‬‏‍‎‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static string \u206B‏‮⁮‫⁬‬‪‍‌‍‍‪⁭‭‮‍‭‪⁮‪⁮​‌⁪​⁪⁮‎‏‬⁫‌‪‏‬⁭‍‭‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static bool \u202B‪​‬⁯⁬‭‫‪‏‭⁯‪‌‪​⁮​⁬⁫‮⁫⁬⁪‎⁮‬‎‮‌⁮‬⁪⁪‌‌‮​⁪‫‮([In] string obj0)
    {
      return File.Exists(obj0);
    }

    static string \u206A‫‌⁬‌‪‬⁭⁭‫⁫‮‪⁬‭⁬⁬‭⁬‭‮⁫⁪‎​‬⁯‫‌‮‬⁪⁭⁭‌​‭⁯⁯⁫‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static SQLiteParameterCollection \u206E‬‌‏‌‮​​‪‌‬⁫⁮⁭⁫⁫‪​⁬​‎‎⁪‭⁪‪⁭⁭‍‬‍‍⁮⁬‬‎‫⁯⁪‍‮([In] SQLiteCommand obj0)
    {
      return obj0.get_Parameters();
    }

    static SQLiteParameter \u206A‏‪​‭​⁭‬‬⁭⁪‮⁫‮‌⁯‬‎‌‏‮‪⁫⁯‭​‍‌​⁪‫‬‬⁫⁯​⁭‭‬‌‮([In] string obj0, [In] object obj1)
    {
      return new SQLiteParameter(obj0, obj1);
    }

    static int \u202A‮⁭⁯‬⁮‌‎‮‬‌‮‏⁬‌⁪⁭​‎‏‪‮‌‏⁯⁬‮⁯⁯‮‭⁭⁬‏⁮‍⁫‫⁪⁬‮([In] SQLiteParameterCollection obj0, [In] SQLiteParameter obj1)
    {
      return obj0.Add(obj1);
    }

    static int \u202B‌‪‎⁮⁮⁭‮⁯‏⁬⁭‏‮⁭⁪‌‌‍⁯​‪‏⁮⁪‫⁫‬‌⁯‬‭⁬‎‭‭‍​⁬⁬‮([In] DbCommand obj0)
    {
      return obj0.ExecuteNonQuery();
    }

    static string \u202E‬​⁬‬‪‎⁮‪‌‍‪‎⁮⁬‪⁪‫‍‮⁯⁪‌‌‮⁮‏‪‎‎‌‬⁬⁪⁫⁯​‍⁮⁮‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      return string.Format(obj0, obj1, obj2, obj3);
    }

    static string \u200B‌⁬‫⁪‮⁬‌‪‮​‌⁯‬‎‬‬‍⁮⁯⁮‏‎​‏‏⁬⁫‪‌‮⁮⁫⁭‮‏‪⁪​⁯‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static void \u206B⁯‍‫‍‪‭‬⁮‫​‬⁮⁯‎⁮‎‭‎⁯‬‎​‪‌⁫⁬‎⁯‪‍⁫⁪⁯‎‎‍‭⁪‌‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static DataColumnCollection \u206E‪‫‌⁮‫‍⁫‌‍⁯​‫⁬​‭​‎‪‍⁫‏‫‏‎⁯‍⁯‮‭‬‌‪⁮​‏‭‍‮‫‮([In] DataTable obj0)
    {
      return obj0.Columns;
    }

    static IEnumerator \u206F‌‬‭‍‍‏‏⁪​‮⁬⁭‏⁯⁪‍‌‎⁫⁬‪‬⁭‍⁯​‫‪‏‭‎‪⁭‏⁬‮⁬‮‌‮([In] InternalDataCollectionBase obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u200D‭‪‌‎‌⁯⁮‮⁭‭‌‍⁯⁮‎⁭‬⁮‭⁮‌⁬‏‭‌‌⁫‍‪⁮⁫⁫⁭⁬‬⁫⁭⁬⁯‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static bool \u200E⁭‮‏‫‍‍‮‪⁮‍‫‭‮⁮‫⁮‍‮‍‍‍‌‫⁬‎⁯⁬‭⁯⁫⁪‌‌⁫​‮‮⁮‭‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static string \u200F‫⁬⁬⁬‏​⁪‍⁬⁯‪‏⁯‏​‌​⁫‬‬‭​‮‬⁭⁫​‍‎‮‎⁬⁮‫‏⁮⁬⁮‌‮([In] DataColumn obj0)
    {
      return obj0.ColumnName;
    }

    static PropertyCollection \u206D⁬‮⁮‭‭‌⁮⁭‎‏​‏⁯‍‏⁯‏⁪‭⁫⁬‬⁫⁫‏‏⁯‪‬‭‏‭‬‎⁬⁬‍⁯⁬‮([In] DataColumn obj0)
    {
      return obj0.ExtendedProperties;
    }

    static object \u202C‭​‬‫‌‭⁯​⁬‏‬⁬‮‎⁫​⁪‏‪⁮⁮⁯⁮‏⁯‎‬⁬‮⁪‬‬⁪⁯‏⁭‏‌‪‮([In] Hashtable obj0, [In] object obj1)
    {
      return obj0[obj1];
    }

    static bool \u206B‭‎⁫‌​⁫‪‭‭‮‎‫‍⁫⁭‭⁮‌⁭‪‭‎‪‎‫‪‎⁮‌⁭‎​​⁪⁭⁮⁫‭⁪‮([In] DataColumn obj0)
    {
      return obj0.AutoIncrement;
    }

    static bool \u206B‌‌‪‫⁪‪⁯⁪⁫‮‌​‫⁫‮⁬⁫⁯‏⁯‭⁭‍‪‪‌‌‪‫⁭‫​‪‏‬‎‌⁮‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static string \u206B‎‌‌⁬⁪​⁯⁮⁪‮‫⁯‌⁪​‏​⁫‪‭⁭‬⁮⁬⁫‫‭⁯‏⁭‍‮‏​‏‭‌‬⁬‮([In] DataTable obj0)
    {
      return obj0.TableName;
    }

    static long \u200C‌⁪‏‪‭‮‫⁯‬‬‏‏⁮‫⁯⁭⁭‎‎‭⁪⁯‫​‬‬⁬⁭⁭‏‌‍⁪⁭⁬⁬‍‏⁫‮([In] SQLiteConnection obj0)
    {
      return obj0.get_LastInsertRowId();
    }

    static string \u200E‬‬‍⁫​‪‬⁮⁫‍‭‮‏​‪‬⁯⁫⁫‏‭‬⁯⁬⁭‍‮⁪‪‮​‏⁯‮⁮‫‍‌‎‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static void \u206B‭‬‭‍‏⁭⁬‮⁪​‌‪⁭⁬‎‌⁫⁬‫⁪‭‍‎‌​‏‌⁫⁬‏‎⁬‮⁯⁭⁫‭‍⁭‮([In] string obj0)
    {
      SQLiteConnection.CreateFile(obj0);
    }

    static void \u202C‮⁫⁬⁪‍‫‬⁪‏‌⁯‏‬⁫⁪⁬⁭⁮‌‌⁪‭‎‮⁪‫‌⁮⁯‫⁫‫⁪‪⁯‏⁮⁫‌‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static SQLiteConnection \u206E‮⁪‎‮⁫‭‮⁪‎‪‭‎⁬‮‌⁫‏‭‎⁮⁪‍⁭⁯⁭⁮‭‎​‬‮‎‏‮‌‏​⁭⁮‮([In] string obj0)
    {
      return new SQLiteConnection(obj0);
    }

    static void \u206B⁭‬‎‪⁭‮‭‭‍‭‎⁫‌⁫‍‏‫⁭⁮‪⁮‭‪‌‮⁬⁮‎⁫‎‏‭⁭⁬‪⁭‎⁭‎‮([In] DbConnection obj0)
    {
      obj0.Open();
    }

    static Type \u206F‫⁬⁬‌⁯⁪‮​⁭⁪‎​‬‪⁬‍‬‎​⁫⁫‭‮‭‏⁮‪‫⁯‬‫‏⁬⁭‫⁭⁭‮‪‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static Array \u200B⁫​⁫⁭‭⁬​‌‮‭‮⁬⁯‌​‫⁪‮‏‬⁭‎⁪⁭⁯​⁮‏‎⁫‫⁯‭‪‭‍⁫‏‏‮([In] Type obj0)
    {
      return Enum.GetValues(obj0);
    }

    static IEnumerator \u206D⁫‬‌‮⁮⁫⁮⁪‭⁯‎‌​⁯⁯⁭‫⁭⁮‌‏‪​⁫⁭⁪‬‬‍‍‎⁮‭​⁪⁮⁬⁪‮([In] Array obj0)
    {
      return obj0.GetEnumerator();
    }

    static DataColumn \u202B‎‏‏‎‌‌⁬‭⁮⁫⁫‭⁭⁭‌⁬‍‬‍‏‪‏⁫⁫‍‏⁪​‭‏‮‎‍‬⁫‍‫‍⁫‮([In] DataColumnCollection obj0, [In] string obj1)
    {
      return obj0[obj1];
    }

    static bool \u202A‭⁪⁫‬‎‫⁫⁫⁫⁪⁫⁮‬⁪‮‎‎​‏⁪⁬⁫⁭⁭​‬‮⁬‭‪‍‍‎⁪​‍‌‏‌‮([In] Hashtable obj0, [In] object obj1)
    {
      return obj0.ContainsKey(obj1);
    }

    static string \u206D‮‪⁪⁯‍‪‪‎⁫⁫‏‬‍‎‮⁪‌‫⁬⁭‪⁯⁮⁪‍‮‍‍‌⁯‭‮⁭‬‫⁪⁯​⁪‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0 + obj1 + obj2;
    }

    static Exception \u200B‮‫‫⁯‎⁯​⁮​‏​‍​‫‎⁪⁮‫‏‌‬⁯‫⁯​⁭‭⁮‍‏⁮‮‌‌⁫⁯‍⁯‍‮([In] string obj0)
    {
      return new Exception(obj0);
    }

    static void \u200B⁮‏⁮⁪‎‮‌⁪⁫‌‬‪⁭‪‌​‭‍‭⁬⁪⁬⁬‭⁬‏‏⁭‎⁯‌‪‏‭‭‭‪‍‪‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.DebugFormat(obj1, obj2, obj3);
    }

    static object \u200F⁫‌⁯‎⁫‭‍‮⁪⁬‪⁭‮‪‍‮‫⁯‮‍‫‪‫⁫‎⁪‎⁬⁭‪⁯‪‮⁮‫‫⁪⁭⁯‮([In] DbCommand obj0)
    {
      return obj0.ExecuteScalar();
    }

    static MethodBase \u202B‌‍⁭‌‬‭‪‏‭‍⁯‌‎‎‬‬⁬‭‌⁪⁯‬‭⁯‪‬‍‬⁪⁪‏⁬⁮‍‫‭‍⁭‭‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202E‍‭⁭‪‍⁪⁪‌‮‮‭‌⁫⁫⁭⁯‮​‪‏‫⁯‏⁭​‌‬‌‫⁫⁭⁪‎⁭​‏‎⁭‭‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202D⁬​⁬‬⁪‮⁭‎‫‭‍‌⁮‏‏‭⁬‮⁪‍‬‬⁬‫⁫⁭⁯‪​⁬‎​‭‫⁬⁭‭‏‫‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static object \u206D​‫‏‌‏‭⁮​‮‌‌‫‏‌‎⁮‎⁮⁪⁫‮⁮‏‪‍‬‏⁪‬⁮‍⁮⁫‫‍⁬‭‪‎‮()
    {
      return new object();
    }
  }
}
