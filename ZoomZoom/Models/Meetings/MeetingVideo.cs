// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Meetings.MeetingVideo
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom.Models.Meetings
{
  public class MeetingVideo
  {
    private static readonly object _locker = MeetingVideo.\u202D‫‎‌⁬‏‎‪‌‍‫⁭​⁯⁫⁭‬⁬‬‌⁯⁮⁯⁯⁭‬‪‏‬‌⁬⁯‪‬⁮‎‫‭‎⁫‮();
    private bool chatLinkStarted = false;
    private ZoomWindow videoWindow;
    private VideoChatLink chatLink;

    public ZoomWindow VideoWindow
    {
      get
      {
label_1:
        int num1 = 1076364556;
        ZoomWindow videoWindow;
        while (true)
        {
          int num2 = 357871131;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              videoWindow = this.videoWindow;
              num1 = (int) num3 * 1867597413 ^ -1469480248;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return videoWindow;
      }
      set
      {
        object locker = MeetingVideo._locker;
        bool flag = false;
        try
        {
          MeetingVideo.\u202E⁮‏‎‮‭‮‎⁯‭⁭‎‮⁯⁯‮‌⁭⁬‬‌‭‮‮‪⁪‏‪​‌⁮‏‍‪‍⁯​‬‌⁫‮(locker, ref flag);
label_2:
          int num1 = -99807040;
          while (true)
          {
            int num2 = -643841868;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                num1 = (int) num3 * -708332436 ^ 1226560226;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          this.videoWindow = value;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num1 = -145657842;
            while (true)
            {
              int num2 = -643841868;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_7;
                case 2:
                  MeetingVideo.\u200D⁬‬⁬‫​⁬‌‪⁭⁮⁮‭‌‫‬‍‌‎‫‬⁪⁮‎⁬‬‎‭‌‭‌‮‬⁪‌‬‮‪‏‫‮(locker);
                  num1 = (int) num3 * -411930857 ^ -105165655;
                  continue;
                case 3:
                  num1 = (int) num3 * -424907144 ^ 1998614281;
                  continue;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
      }
    }

    public IntPtr Handle
    {
      get
      {
label_1:
        int num1 = 826978802;
        IntPtr num2;
        while (true)
        {
          int num3 = 1209563607;
          uint num4;
          switch ((num4 = (uint) (num1 ^ num3)) % 7U)
          {
            case 0:
              num2 = IntPtr.Zero;
              num1 = 1185688142;
              continue;
            case 1:
              num1 = (int) num4 * 1624310540 ^ 477834603;
              continue;
            case 2:
              int num5 = this.VideoWindow == null ? -1215749881 : (num5 = -1542361116);
              int num6 = (int) num4 * 1275689637;
              num1 = num5 ^ num6;
              continue;
            case 3:
              num1 = (int) num4 * -342342920 ^ -334236698;
              continue;
            case 4:
              num2 = this.VideoWindow.Handle;
              num1 = (int) num4 * 1914737828 ^ -163785044;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return num2;
      }
    }

    public bool ChatLinked
    {
      get
      {
label_1:
        int num1 = 531971143;
        bool flag1;
        while (true)
        {
          int num2 = 154050272;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              flag1 = false;
              num1 = 734103817;
              continue;
            case 2:
              flag1 = this.ChatLink.ChatLinked;
              num1 = (int) num3 * -4729201 ^ -1297566530;
              continue;
            case 3:
              int num4 = flag2 ? -1828452529 : (num4 = -930148509);
              int num5 = (int) num3 * 299882498;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 1373490502 ^ -1828157921;
              continue;
            case 6:
              flag2 = this.ChatLink != null;
              num1 = (int) num3 * -597060347 ^ 2129450172;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return flag1;
      }
    }

    public VideoChatLink ChatLink
    {
      get
      {
        VideoChatLink chatLink = this.chatLink;
label_1:
        int num1 = 64224927;
        while (true)
        {
          int num2 = 942246885;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1147826936 ^ -1951246427;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chatLink;
      }
      set
      {
        object locker = MeetingVideo._locker;
        bool flag = false;
        try
        {
          MeetingVideo.\u202E⁮‏‎‮‭‮‎⁯‭⁭‎‮⁯⁯‮‌⁭⁬‬‌‭‮‮‪⁪‏‪​‌⁮‏‍‪‍⁯​‬‌⁫‮(locker, ref flag);
label_2:
          int num1 = -2097033154;
          while (true)
          {
            int num2 = -1019149360;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                goto label_11;
              case 1:
                num1 = (int) num3 * -1402402114 ^ -126847766;
                continue;
              case 2:
                num1 = (int) num3 * 2138983172 ^ -80081186;
                continue;
              case 3:
                this.chatLink = value;
                num1 = (int) num3 * 1779158763 ^ -986951920;
                continue;
              case 4:
                goto label_2;
              default:
                goto label_7;
            }
          }
label_7:
          return;
label_11:;
        }
        finally
        {
          if (flag)
          {
label_9:
            int num1 = -1458874858;
            while (true)
            {
              int num2 = -1019149360;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 1:
                  num1 = (int) num3 * -2020091721 ^ -163370089;
                  continue;
                case 2:
                  MeetingVideo.\u200D⁬‬⁬‫​⁬‌‪⁭⁮⁮‭‌‫‬‍‌‎‫‬⁪⁮‎⁬‬‎‭‌‭‌‮‬⁪‌‬‮‪‏‫‮(locker);
                  num1 = (int) num3 * 1522267113 ^ 1678941675;
                  continue;
                case 3:
                  goto label_9;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
      }
    }

    public object TrackingMessage
    {
      get
      {
label_1:
        int num1 = -2117331815;
        object obj;
        while (true)
        {
          int num2 = -2131826436;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 1:
              num1 = (int) num3 * -1386397046 ^ -2073661861;
              continue;
            case 2:
              int num4 = this.ChatLink == null ? 224521688 : (num4 = 565047974);
              int num5 = (int) num3 * 112105226;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 1851328896 ^ 1850575321;
              continue;
            case 4:
              obj = (object) string.Empty;
              num1 = -635917479;
              continue;
            case 5:
              obj = (object) this.ChatLink.TrackingMessage;
              num1 = (int) num3 * 1746710510 ^ -440946279;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return obj;
      }
    }

    public bool ChatLinkStarted
    {
      get
      {
label_1:
        int num1 = -1682362362;
        bool chatLinkStarted;
        while (true)
        {
          int num2 = -1359203301;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              chatLinkStarted = this.chatLinkStarted;
              num1 = (int) num3 * 999766722 ^ -1367855567;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chatLinkStarted;
      }
      set
      {
        object locker = MeetingVideo._locker;
        bool flag = false;
        try
        {
          MeetingVideo.\u202E⁮‏‎‮‭‮‎⁯‭⁭‎‮⁯⁯‮‌⁭⁬‬‌‭‮‮‪⁪‏‪​‌⁮‏‍‪‍⁯​‬‌⁫‮(locker, ref flag);
label_2:
          int num1 = 1086629836;
          while (true)
          {
            int num2 = 1897627675;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                num1 = (int) num3 * -1618175398 ^ 1261066300;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          this.chatLinkStarted = value;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num1 = 1594477726;
            while (true)
            {
              int num2 = 1897627675;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_7;
                case 1:
                  MeetingVideo.\u200D⁬‬⁬‫​⁬‌‪⁭⁮⁮‭‌‫‬‍‌‎‫‬⁪⁮‎⁬‬‎‭‌‭‌‮‬⁪‌‬‮‪‏‫‮(locker);
                  num1 = (int) num3 * 1269596528 ^ -1082442755;
                  continue;
                case 2:
                  num1 = (int) num3 * 1067445302 ^ -811511184;
                  continue;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
      }
    }

    public bool VideoWindowClickable
    {
      get
      {
        if (this.VideoWindow == null)
          goto label_6;
label_1:
        int num1 = 1198628642;
label_2:
        Size size;
        bool flag1;
        bool flag2;
        while (true)
        {
          int num2 = 902250197;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              size = this.VideoWindow.Size;
              num1 = (int) num3 * 1350312274 ^ -2040082157;
              continue;
            case 2:
              num1 = 274143492;
              continue;
            case 3:
              num1 = (int) num3 * 1175989370 ^ -270780138;
              continue;
            case 4:
              goto label_1;
            case 5:
              flag2 = true;
              num1 = (int) num3 * -1476189827 ^ -617746817;
              continue;
            case 6:
              goto label_5;
            case 7:
              num1 = (int) num3 * 609719363 ^ 1513364581;
              continue;
            case 8:
              num1 = (int) num3 * -1888474039 ^ 1889647204;
              continue;
            case 9:
              flag2 = false;
              num1 = (int) num3 * 695374101 ^ -699140941;
              continue;
            case 10:
              int num4 = flag1 ? -912109883 : (num4 = -2088384109);
              int num5 = (int) num3 * 2038350404;
              num1 = num4 ^ num5;
              continue;
            case 11:
              if (this.VideoWindow.IsVisible)
              {
                num1 = (int) num3 * -73235181 ^ 1413915112;
                continue;
              }
              goto label_6;
            default:
              goto label_16;
          }
        }
label_5:
        int num6 = size.Height > 0 ? 1 : 0;
        goto label_7;
label_16:
        return flag2;
label_6:
        num6 = 0;
label_7:
        flag1 = num6 != 0;
        num1 = 58702891;
        goto label_2;
      }
    }

    public MeetingVideo(ZoomWindow videoWindow)
    {
label_1:
      int num1 = 1055219219;
      while (true)
      {
        int num2 = 515277000;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 1059032548 ^ -758639986;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 1363503700 ^ 1161738177;
            continue;
          case 4:
            this.videoWindow = videoWindow;
            this.chatLink = new VideoChatLink(videoWindow);
            num1 = (int) num3 * -1487329229 ^ 1814044044;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    internal void CompleteLink(ZoomChat chat)
    {
      if (this.ChatLink == null)
        return;
label_1:
      int num1 = 1135183107;
      while (true)
      {
        int num2 = 922260408;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -586241968 ^ -1749664446;
            continue;
          case 2:
            goto label_6;
          case 3:
            this.ChatLink.CompleteLink(chat);
            num1 = (int) num3 * -2076614106 ^ -1917159181;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_6:;
    }

    static void \u202E⁮‏‎‮‭‮‎⁯‭⁭‎‮⁯⁯‮‌⁭⁬‬‌‭‮‮‪⁪‏‪​‌⁮‏‍‪‍⁯​‬‌⁫‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200D⁬‬⁬‫​⁬‌‪⁭⁮⁮‭‌‫‬‍‌‎‫‬⁪⁮‎⁬‬‎‭‌‭‌‮‬⁪‌‬‮‪‏‫‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static object \u202D‫‎‌⁬‏‎‪‌‍‫⁭​⁯⁫⁭‬⁬‬‌⁯⁮⁯⁯⁭‬‪‏‬‌⁬⁯‪‬⁮‎‫‭‎⁫‮()
    {
      return new object();
    }
  }
}
