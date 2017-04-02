// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ChatEventArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public class ChatEventArgs : ZoomZoomEventArgs
  {
    private string currentName = string.Empty;
    private List<ZoomChat> chats = new List<ZoomChat>();
    private int chatsImported;
    private int chatsReceived;
    private ZoomChat chat;

    public int ChatsImported
    {
      get
      {
        int chatsImported = this.chatsImported;
label_1:
        int num1 = 654361791;
        while (true)
        {
          int num2 = 293138810;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -2083203378 ^ -1229616376;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return chatsImported;
      }
      set
      {
label_1:
        int num1 = -953117183;
        while (true)
        {
          int num2 = -698776332;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.chatsImported = value;
              num1 = (int) num3 * 282861698 ^ 1988727603;
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

    public int ChatsReceived
    {
      get
      {
        return this.chatsReceived;
      }
      set
      {
        this.chatsReceived = value;
      }
    }

    public List<ZoomChat> Chats
    {
      get
      {
label_1:
        int num1 = -540149903;
        List<ZoomChat> chats;
        while (true)
        {
          int num2 = -1647485378;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -779895841 ^ 1523428707;
              continue;
            case 3:
              chats = this.chats;
              num1 = (int) num3 * 1733657585 ^ -458992432;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return chats;
      }
      set
      {
        this.chats = value;
      }
    }

    public string CurrentName
    {
      get
      {
label_1:
        int num1 = -1596498608;
        string currentName;
        while (true)
        {
          int num2 = -1851576403;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              currentName = this.currentName;
              num1 = (int) num3 * -2072814838 ^ -663248436;
              continue;
            case 3:
              num1 = (int) num3 * 959045370 ^ 1328488065;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return currentName;
      }
      set
      {
label_1:
        int num1 = -1780178930;
        while (true)
        {
          int num2 = -1934354507;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.currentName = value;
              num1 = (int) num3 * 1751100176 ^ 1112968292;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public ZoomChat Chat
    {
      get
      {
label_1:
        int num1 = 46173227;
        ZoomChat chat;
        while (true)
        {
          int num2 = 1855232943;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              chat = this.chat;
              num1 = 891572752;
              continue;
            case 1:
              num4 = this.chats.Count > 0 ? 1 : 0;
              break;
            case 2:
              int num5 = !flag ? 793044671 : (num5 = 796976164);
              int num6 = (int) num3 * -1448042552;
              num1 = num5 ^ num6;
              continue;
            case 3:
              chat = this.chats[0];
              num1 = (int) num3 * 915996882 ^ -1796893393;
              continue;
            case 4:
              if (this.chat != null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 943459197 ^ -47344214;
              continue;
            case 5:
              goto label_1;
            case 7:
              num1 = (int) num3 * 1101576282 ^ 1965395759;
              continue;
            default:
              goto label_12;
          }
          flag = num4 != 0;
          num1 = 724820957;
        }
label_12:
        return chat;
      }
      set
      {
        this.chat = value;
      }
    }

    public ChatEventArgs()
    {
    }

    public ChatEventArgs(List<ZoomChat> lChats)
    {
      foreach (ZoomChat lChat in lChats)
      {
        this.chats.Add(lChat);
        if (!ChatEventArgs.\u200C‍‫‍‭​​‌⁯⁪‫⁯‭‍⁯‬⁮⁪‌⁬‏⁮⁯⁮‪⁯‪‬‮⁫‮⁭‮‫‌‌‍⁪‍⁫‮(lChat.ReceivingZoomId, lChat.CurrentName))
          ;
      }
      this.chats.AddRange((IEnumerable<ZoomChat>) lChats);
    }

    public ChatEventArgs(ZoomChat chat)
    {
label_1:
      int num1 = 139045945;
      while (true)
      {
        int num2 = 1519698818;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this.ChatsReceived = 1;
            num1 = (int) num3 * -328582336 ^ 704129521;
            continue;
          case 1:
            num1 = (int) num3 * -2017909884 ^ 479407931;
            continue;
          case 2:
            num1 = (int) num3 * 2137338063 ^ 654807454;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.Chat = chat;
            int num4 = ChatEventArgs.\u200C‍‫‍‭​​‌⁯⁪‫⁯‭‍⁯‬⁮⁪‌⁬‏⁮⁯⁮‪⁯‪‬‮⁫‮⁭‮‫‌‌‍⁪‍⁫‮(this.Chat.CurrentName, chat.ReceivingZoomId) ? -1023183212 : (num4 = -1805087093);
            int num5 = (int) num3 * 556407315;
            num1 = num4 ^ num5;
            continue;
          case 5:
            num1 = (int) num3 * 276023754 ^ -129389152;
            continue;
          case 6:
            num1 = (int) num3 * -1546912694 ^ 1257656123;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num3 * -1073666653 ^ -412581821;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    static bool \u200C‍‫‍‭​​‌⁯⁪‫⁯‭‍⁯‬⁮⁪‌⁬‏⁮⁯⁮‪⁯‪‬‮⁫‮⁭‮‫‌‌‍⁪‍⁫‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }
  }
}
