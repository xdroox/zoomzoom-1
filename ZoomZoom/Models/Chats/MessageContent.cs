// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Chats.MessageContent
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using ZoomZoom.Models.Data;

namespace ZoomZoom.Models.Chats
{
  public class MessageContent : DataObject
  {
    private MessageCategory category = (MessageCategory) null;
    private string contentText = string.Empty;
    private DateTime dateCreated = DateTime.MinValue;
    private DateTime dateModified = DateTime.MinValue;

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Chat;
label_1:
        int num1 = 1748301651;
        while (true)
        {
          int num2 = 1918059009;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 425167824 ^ 1220804084;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public MessageCategory Category
    {
      get
      {
label_1:
        int num1 = -1952221539;
        MessageCategory category;
        while (true)
        {
          int num2 = -1460240272;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              category = this.category;
              num1 = (int) num3 * 1819088853 ^ -1668713398;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 419830675 ^ 188806889;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return category;
      }
      set
      {
label_1:
        int num1 = -415429119;
        while (true)
        {
          int num2 = -1786649104;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.category = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1760314917U));
              num1 = (int) num3 * 2620378 ^ 2010504884;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public string ContentText
    {
      get
      {
label_1:
        int num1 = 675820284;
        string contentText;
        while (true)
        {
          int num2 = 299175757;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              contentText = this.contentText;
              num1 = (int) num3 * -548728292 ^ -1545777156;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return contentText;
      }
      set
      {
        this.contentText = value;
label_1:
        int num1 = -1542144036;
        while (true)
        {
          int num2 = -621294018;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -1876929062 ^ -1140200828;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1490279198U));
              num1 = (int) num3 * -1458781867 ^ -1481591347;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public DateTime DateCreated
    {
      get
      {
        return this.dateCreated;
      }
      set
      {
        this.dateCreated = value;
      }
    }

    public DateTime DateModified
    {
      get
      {
label_1:
        int num1 = -973875383;
        DateTime dateModified;
        while (true)
        {
          int num2 = -1353256538;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              dateModified = this.dateModified;
              num1 = (int) num3 * 922713941 ^ 1127922661;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return dateModified;
      }
      set
      {
        this.dateModified = value;
      }
    }

    public override ObjectDataTable ZoomZoomTable
    {
      get
      {
label_1:
        int num1 = -1504109262;
        ObjectDataTable objectDataTable;
        while (true)
        {
          int num2 = -1653444666;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              objectDataTable = ObjectDataTable.MessageContent;
              num1 = (int) num3 * -931295202 ^ -1649032450;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return objectDataTable;
      }
    }

    private MessageContent()
    {
label_1:
      int num1 = -277574819;
      while (true)
      {
        int num2 = -1471329041;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -94943748 ^ -1574226145;
            continue;
          case 2:
            num1 = (int) num3 * -1967862906 ^ -1743310318;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public MessageContent(MessageCategory category, string content)
    {
label_1:
      int num1 = 920129102;
      while (true)
      {
        int num2 = 498139655;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Category = category;
            num1 = (int) num3 * 1165573404 ^ 603429885;
            continue;
          case 2:
            this.ContentText = content;
            num1 = (int) num3 * -1710616324 ^ -989172077;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public static MessageContent Load(SQLiteDataReader cReader)
    {
label_1:
      int num1 = -273284426;
      MessageContent messageContent1;
      while (true)
      {
        int num2 = -186299165;
        uint num3;
        bool flag;
        MessageContent messageContent2;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            num1 = -1519390014;
            continue;
          case 1:
            num1 = (int) num3 * 1047118770 ^ 355721839;
            continue;
          case 2:
            messageContent2 = new MessageContent();
            num1 = (int) num3 * 800689370 ^ -562617812;
            continue;
          case 4:
            num1 = (int) num3 * 674684226 ^ -980129371;
            continue;
          case 5:
            messageContent1 = messageContent2;
            num1 = (int) num3 * 1843887498 ^ -977281169;
            continue;
          case 6:
            messageContent1 = (MessageContent) null;
            num1 = (int) num3 * -76870709 ^ -608235511;
            continue;
          case 7:
            int num4 = flag ? 476133902 : (num4 = 578806652);
            int num5 = (int) num3 * 426212759;
            num1 = num4 ^ num5;
            continue;
          case 8:
            flag = messageContent2.LoadDataObject(cReader);
            num1 = (int) num3 * 1324438526 ^ -521386472;
            continue;
          case 9:
            goto label_1;
          case 10:
            num1 = (int) num3 * 1558101987 ^ 52246341;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return messageContent1;
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = 407107462;
      bool flag1;
      while (true)
      {
        int num2 = 206403992;
        uint num3;
        MessageContent messageContent;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -2026098629 ^ -241787416;
            continue;
          case 1:
            int num4 = !flag2 ? 2034136617 : (num4 = 932433529);
            int num5 = (int) num3 * 1485058310;
            num1 = num4 ^ num5;
            continue;
          case 2:
            messageContent = obj as MessageContent;
            flag2 = messageContent != null;
            num1 = (int) num3 * -332041000 ^ -1702793004;
            continue;
          case 3:
            flag1 = this.\u200E‌⁭‏‫⁬⁮‫‭‍‫‫​​⁬‮‏⁬‪⁪⁬⁮⁫‎⁮‎⁫​‌‬‭‭‍⁫‬‮​​‌⁪‮(obj);
            num1 = 363385402;
            continue;
          case 4:
            flag1 = messageContent.Uri == this.Uri;
            num1 = (int) num3 * 1233933487 ^ -1268410583;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_8:
      return flag1;
    }

    public override int GetHashCode()
    {
      if (MessageContent.\u206F‌⁫‌‍⁬⁯⁬⁭‍‭⁫‪⁫‎‭‎⁪⁯‪⁭‫‬​‌‫⁪​‬⁬⁯⁫‪⁫⁯‫‌‪‬⁮‮(this.contentText))
        goto label_9;
label_1:
      int num1 = -1823776164;
label_2:
      int hashCode;
      while (true)
      {
        int num2 = -759116042;
        uint num3;
        int num4;
        bool flag;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            num1 = (int) num3 * 1883129580 ^ 1462145780;
            continue;
          case 1:
            if (this.Category != null)
            {
              num1 = (int) num3 * -751529308 ^ 1620847453;
              continue;
            }
            num5 = 0;
            break;
          case 2:
            int num6 = !flag ? -1449682337 : (num6 = -1824914413);
            int num7 = (int) num3 * -1305778053;
            num1 = num6 ^ num7;
            continue;
          case 3:
            hashCode = num4.GetHashCode();
            num1 = (int) num3 * 2039524451 ^ 1866093896;
            continue;
          case 4:
            num5 = !MessageContent.\u206F‌⁫‌‍⁬⁯⁬⁭‍‭⁫‪⁫‎‭‎⁪⁯‪⁭‫‬​‌‫⁪​‬⁬⁯⁫‪⁫⁯‫‌‪‬⁮‮(this.Category.CategoryName) ? 1 : 0;
            break;
          case 5:
            goto label_1;
          case 6:
            num4 = MessageContent.\u200E‪‬‬‬⁯⁭‏⁭‭‫‭⁪⁪⁯​⁫⁫‌‮‭‍‍⁪⁪​⁭‏‌​⁮⁫‬⁪‬‌‍⁯‏‎‮((object) this.Category.CategoryName) + MessageContent.\u200E‪‬‬‬⁯⁭‏⁭‭‫‭⁪⁪⁯​⁫⁫‌‮‭‍‍⁪⁪​⁭‏‌​⁮⁫‬⁪‬‌‍⁯‏‎‮((object) this.contentText);
            num1 = (int) num3 * 534530829 ^ 526446514;
            continue;
          case 7:
            num1 = (int) num3 * 1032090182 ^ 1116582374;
            continue;
          case 8:
            goto label_9;
          case 10:
            num1 = -1202700392;
            continue;
          default:
            goto label_15;
        }
        flag = num5 != 0;
        num1 = -1682159957;
      }
label_15:
      return hashCode;
label_9:
      hashCode = base.GetHashCode();
      num1 = -2036807638;
      goto label_2;
    }

    public override ObjectDataTable GetTableName()
    {
      return ObjectDataTable.MessageContent;
    }

    public override Dictionary<string, object> GetDataDictionary()
    {
label_1:
      int num1 = 1823820010;
      Dictionary<string, object> dictionary1;
      while (true)
      {
        int num2 = 1016747679;
        uint num3;
        Dictionary<string, object> dictionary2;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(179000486U), (object) this.ContentText);
            num1 = (int) num3 * -764553607 ^ 722920956;
            continue;
          case 1:
            num1 = (int) num3 * 2135627666 ^ 668646693;
            continue;
          case 2:
            goto label_1;
          case 3:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1679528045U), (object) this.DateCreated);
            num1 = (int) num3 * -1702017877 ^ -1588225424;
            continue;
          case 5:
            dictionary2 = new Dictionary<string, object>();
            num1 = (int) num3 * -1283203923 ^ 979162097;
            continue;
          case 6:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2223083214U), (object) this.DateModified);
            dictionary1 = dictionary2;
            num1 = (int) num3 * 371389647 ^ 162311089;
            continue;
          case 7:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3666502981U), (object) this.Uri);
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1880473742U), (object) this.Category.Uri);
            num1 = (int) num3 * -192396753 ^ -1782976521;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return dictionary1;
    }

    public override bool LoadDataObject(SQLiteDataReader cReader)
    {
      bool flag = false;
      try
      {
label_2:
        int num1 = 1742009672;
        while (true)
        {
          int num2 = 881201521;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_2;
            case 1:
              this.dateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2182723723U));
              num1 = (int) num3 * -52005150 ^ -584008552;
              continue;
            case 2:
              this.category = this.Engine.GetMessageCategory(cReader.GetFieldValueLong(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2439380894U)));
              num1 = (int) num3 * -593929974 ^ -494300906;
              continue;
            case 3:
              this.dateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3397799221U));
              num1 = (int) num3 * -979738438 ^ -1011906367;
              continue;
            case 5:
              this.uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U));
              num1 = (int) num3 * 1927650999 ^ 1935603511;
              continue;
            case 6:
              this.contentText = cReader.GetFieldValueString(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1759587503U));
              num1 = (int) num3 * 593193370 ^ 1054492019;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        flag = true;
      }
      catch (Exception ex)
      {
label_11:
        int num1 = 2036052780;
        while (true)
        {
          int num2 = 881201521;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_11;
            case 1:
              MessageContent.\u200C‌‎‎​‬‎​⁬‍‬‍‫​‍​⁪‎‍‪‍‮‎⁯‌‎‫⁯‫​‭⁫‌⁫‍‌‏‪‭‏‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -2118669167 ^ -201964734;
              continue;
            default:
              goto label_14;
          }
        }
      }
label_14:
      return flag;
    }

    bool \u200E‌⁭‏‫⁬⁮‫‭‍‫‫​​⁬‮‏⁬‪⁪⁬⁮⁫‎⁮‎⁫​‌‬‭‭‍⁫‬‮​​‌⁪‮([In] object obj0)
    {
      return base.Equals(obj0);
    }

    static bool \u206F‌⁫‌‍⁬⁯⁬⁭‍‭⁫‪⁫‎‭‎⁪⁯‪⁭‫‬​‌‫⁪​‬⁬⁯⁫‪⁫⁯‫‌‪‬⁮‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static int \u200E‪‬‬‬⁯⁭‏⁭‭‫‭⁪⁪⁯​⁫⁫‌‮‭‍‍⁪⁪​⁭‏‌​⁮⁫‬⁪‬‌‍⁯‏‎‮([In] object obj0)
    {
      return obj0.GetHashCode();
    }

    static void \u200C‌‎‎​‬‎​⁬‍‬‍‫​‍​⁪‎‍‪‍‮‎⁯‌‎‫⁯‫​‭⁫‌⁫‍‌‏‪‭‏‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }
  }
}
