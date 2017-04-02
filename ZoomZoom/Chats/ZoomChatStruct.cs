// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Chats.ZoomChatStruct
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Data.Common;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace ZoomZoom.Chats
{
  public class ZoomChatStruct
  {
    public string currentName = string.Empty;
    public string guid;
    public string confID;
    public string senderId;
    public string senderName;
    public string receiverId;
    public string receiverName;
    public string content;
    public string time;

    public ZoomChatStruct()
    {
label_1:
      int num1 = 1115466984;
      while (true)
      {
        int num2 = 2025111979;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 936252652 ^ -2080955650;
            continue;
          case 3:
            num1 = (int) num3 * -842499627 ^ -740775946;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public ZoomChatStruct(SQLiteDataReader _reader)
    {
label_1:
      int num1 = 262893430;
      while (true)
      {
        int num2 = 1636523614;
        uint num3;
        bool flag1;
        bool flag2;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            this.receiverName = "";
            num1 = (int) num3 * 1781536469 ^ 273996594;
            continue;
          case 1:
            Engine.Instance.CurrentName = this.currentName;
            num1 = (int) num3 * 837194855 ^ 104499046;
            continue;
          case 2:
            num4 = !ZoomChatStruct.\u202E⁯⁯​⁬‪⁯‮‌‎‏⁯‏‫‌‍⁫⁯​⁮⁮‪‍‏​‭⁯‎⁪‬⁭‌⁯‬⁪⁮‬⁯‫‍‮(this.receiverName, string.Empty) ? 1 : 0;
            break;
          case 3:
            goto label_3;
          case 4:
            this.senderName = ZoomChatStruct.\u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮(ZoomChatStruct.\u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮((DbDataReader) _reader, ZoomChatStruct.\u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮((DbDataReader) _reader, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(927786914U))));
            this.receiverName = ZoomChatStruct.\u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮(ZoomChatStruct.\u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮((DbDataReader) _reader, ZoomChatStruct.\u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮((DbDataReader) _reader, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4227342775U))));
            if (!ZoomChatStruct.\u202E⁯⁯​⁬‪⁯‮‌‎‏⁯‏‫‌‍⁫⁯​⁮⁮‪‍‏​‭⁯‎⁪‬⁭‌⁯‬⁪⁮‬⁯‫‍‮(this.receiverId, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1534856185U)))
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1006462727 ^ -796834912;
            continue;
          case 5:
            num1 = (int) num3 * 641368633 ^ 1938014612;
            continue;
          case 6:
            int num6 = !flag1 ? 1191546402 : (num6 = 328343169);
            int num7 = (int) num3 * 2146089714;
            num1 = num6 ^ num7;
            continue;
          case 7:
            this.receiverId = ZoomChatStruct.\u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮(ZoomChatStruct.\u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮((DbDataReader) _reader, ZoomChatStruct.\u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮((DbDataReader) _reader, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2413857185U))));
            num1 = (int) num3 * -1060588085 ^ -1854742167;
            continue;
          case 8:
            this.content = ZoomChatStruct.\u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮(ZoomChatStruct.\u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮((DbDataReader) _reader, ZoomChatStruct.\u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮((DbDataReader) _reader, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3083401693U))));
            this.senderId = ZoomChatStruct.\u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮(ZoomChatStruct.\u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮((DbDataReader) _reader, ZoomChatStruct.\u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮((DbDataReader) _reader, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(990202652U))));
            num1 = (int) num3 * 2034521168 ^ 475867909;
            continue;
          case 9:
            goto label_1;
          case 10:
            int num8 = flag2 ? 1327545433 : (num8 = 1796209809);
            int num9 = (int) num3 * -200684105;
            num1 = num8 ^ num9;
            continue;
          case 11:
            this.currentName = this.receiverName;
            num1 = (int) num3 * -1308171918 ^ 1798041072;
            continue;
          case 12:
            this.guid = ZoomChatStruct.\u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮(ZoomChatStruct.\u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮((DbDataReader) _reader, ZoomChatStruct.\u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮((DbDataReader) _reader, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(705061922U))));
            num1 = (int) num3 * 1838844823 ^ 295685129;
            continue;
          case 13:
            num1 = (int) num3 * -79096507 ^ 421908218;
            continue;
          case 14:
            num5 = !ZoomChatStruct.\u202E⁯⁯​⁬‪⁯‮‌‎‏⁯‏‫‌‍⁫⁯​⁮⁮‪‍‏​‭⁯‎⁪‬⁭‌⁯‬⁪⁮‬⁯‫‍‮(Engine.Instance.CurrentName, this.currentName) ? 1 : 0;
            goto label_19;
          case 15:
            num1 = (int) num3 * 1541505949 ^ 1474665046;
            continue;
          case 16:
            if (!ZoomChatStruct.\u202E⁯⁯​⁬‪⁯‮‌‎‏⁯‏‫‌‍⁫⁯​⁮⁮‪‍‏​‭⁯‎⁪‬⁭‌⁯‬⁪⁮‬⁯‫‍‮(this.currentName, string.Empty))
            {
              num1 = 234638358;
              continue;
            }
            num5 = 0;
            goto label_19;
          case 17:
            this.time = ZoomChatStruct.\u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮(ZoomChatStruct.\u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮((DbDataReader) _reader, ZoomChatStruct.\u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮((DbDataReader) _reader, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(943372069U))));
            num1 = (int) num3 * -1129851729 ^ 1275050051;
            continue;
          default:
            goto label_26;
        }
        flag1 = num4 != 0;
        num1 = 411959766;
        continue;
label_19:
        flag2 = num5 != 0;
        num1 = 1746994504;
      }
label_26:
      return;
label_3:;
    }

    static int \u202E‪⁮‬⁯⁯‪‍⁬‏‪⁯‫‏⁮‏‎⁬⁮‏‭⁬⁬‏⁯⁪‮‏‬⁫‎‮⁪⁭⁬‪⁮⁯⁮‭‮([In] DbDataReader obj0, [In] string obj1)
    {
      return obj0.GetOrdinal(obj1);
    }

    static object \u202C⁭‪⁫‏⁪‏‫‎‌⁯‍‭‎‮‎​‏‏⁬‭⁭⁭⁮⁬‪‏‪‎‪‪‫⁭⁬​​⁮‭‭⁪‮([In] DbDataReader obj0, [In] int obj1)
    {
      return obj0.GetValue(obj1);
    }

    static string \u202D⁪‏⁯⁮‍‏‌‬‭‎⁫‎​‏‬‪​‭‬‍⁫⁪‫‍⁮‎⁪‫‪⁫⁫‬‮‎⁮‍‫⁯‎‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static bool \u202E⁯⁯​⁬‪⁯‮‌‎‏⁯‏‫‌‍⁫⁯​⁮⁮‪‍‏​‭⁯‎⁪‬⁭‌⁯‬⁪⁮‬⁯‫‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }
  }
}
