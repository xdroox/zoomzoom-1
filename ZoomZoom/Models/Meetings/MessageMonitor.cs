// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Meetings.MessageMonitor
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Chats;

namespace ZoomZoom.Models.Meetings
{
  internal class MessageMonitor : CoreObject
  {
    private static readonly object monitorLock = MessageMonitor.\u206B‌⁯⁯⁬‪‪‌‮‫‮‏‏‎‫‫‭⁭‮‮‭​‬‬‭​‭‪‬‎‍⁮‍‬‌‌⁮⁪‎‭‮();
    private ZoomMeeting meeting;
    private List<string> recentMessages;

    public ZoomMeeting Meeting
    {
      get
      {
        ZoomMeeting meeting = this.meeting;
label_1:
        int num1 = 301760107;
        while (true)
        {
          int num2 = 1935023725;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -414701694 ^ 434012033;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meeting;
      }
      set
      {
label_1:
        int num1 = 340671893;
        while (true)
        {
          int num2 = 616138894;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.meeting = value;
              num1 = (int) num3 * 584223728 ^ -822465713;
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

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Meeting;
label_1:
        int num1 = -552428558;
        while (true)
        {
          int num2 = -1638320494;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1649079295 ^ -144011557;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public List<string> RecentMessages
    {
      get
      {
        List<string> recentMessages = this.recentMessages;
label_1:
        int num1 = 382342871;
        while (true)
        {
          int num2 = 1250631533;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -114659514 ^ -1445290397;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return recentMessages;
      }
      set
      {
        this.recentMessages = value;
      }
    }

    public MessageMonitor(ZoomMeeting meeting)
    {
      this.Meeting = meeting;
      this.recentMessages = new List<string>();
      ((CompositePresentationEvent<ZoomChat>) this._eventAggregator.GetEvent<ChatSentEvent>()).Subscribe(new Action<ZoomChat>(this.OnMessageSent), (ThreadOption) 2, true, (Predicate<ZoomChat>) (obj =>
      {
label_1:
        int num1 = 940587768;
        bool flag;
        while (true)
        {
          int num2 = 1302366665;
          uint num3;
          long meetingUri;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingUri = obj.MeetingUri;
              num1 = (int) num3 * 1089112752 ^ 1351079062;
              continue;
            case 3:
              flag = meetingUri.Equals(this.Meeting.Uri);
              num1 = (int) num3 * -2115965717 ^ 417708486;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return flag;
      }));
    }

    private void OnMessageSent(ZoomChat obj)
    {
label_1:
      int num1 = 1208843968;
      object monitorLock;
      while (true)
      {
        int num2 = 1732609663;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1601323302 ^ 2002125384;
            continue;
          case 3:
            this.Trace(this.TraceType, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3146807437U));
            num1 = (int) num3 * 47082167 ^ -640172055;
            continue;
          case 4:
            monitorLock = MessageMonitor.monitorLock;
            num1 = (int) num3 * -162450116 ^ 455984951;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag1 = false;
      try
      {
        MessageMonitor.\u206B‌⁫⁮⁭‮⁬‎‫⁫‏⁭‫⁬‏⁫‌‮⁬‏⁪‏‍‌‮‎‪‌⁫⁮‎⁯‍‎‭‬⁯‌‪⁯‮(monitorLock, ref flag1);
label_8:
        int num2 = 2101069397;
        while (true)
        {
          int num3 = 1732609663;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              int num5 = !flag2 ? 1390997588 : (num5 = 1498456040);
              int num6 = (int) num4 * 353481229;
              num2 = num5 ^ num6;
              continue;
            case 1:
              flag2 = !this.recentMessages.Contains(obj.ChatContent);
              num2 = (int) num4 * -911828195 ^ 827544114;
              continue;
            case 2:
              num2 = (int) num4 * -1855157844 ^ 500504678;
              continue;
            case 3:
              goto label_20;
            case 4:
              num2 = (int) num4 * -593582040 ^ 925508210;
              continue;
            case 5:
              num2 = (int) num4 * -1795209467 ^ 148626181;
              continue;
            case 6:
              goto label_8;
            case 7:
              this.recentMessages.Add(obj.ChatContent);
              num2 = (int) num4 * 977878096 ^ -374873301;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_20:;
      }
      finally
      {
        if (flag1)
        {
label_18:
          int num2 = 1609280033;
          while (true)
          {
            int num3 = 1732609663;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_18;
              case 2:
                MessageMonitor.\u200C‬‬⁮‫⁪‬‬‌⁮​‪‮⁯‬‬⁮‌‬​‎‫‬​⁭‏​‭‎‍‌⁫⁬‬⁯‎‏‏‏‍‮(monitorLock);
                num2 = (int) num4 * -1895900327 ^ -1951644984;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
    }

    internal bool HasBeenRecentlySent(string messageText)
    {
label_1:
      int num1 = -230931595;
      bool flag1;
      object monitorLock;
      while (true)
      {
        int num2 = -579084127;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            flag1 = false;
            monitorLock = MessageMonitor.monitorLock;
            num1 = (int) num3 * 2115993343 ^ 1138878956;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag2 = false;
      try
      {
        MessageMonitor.\u206B‌⁫⁮⁭‮⁬‎‫⁫‏⁭‫⁬‏⁫‌‮⁬‏⁪‏‍‌‮‎‪‌⁫⁮‎⁯‍‎‭‬⁯‌‪⁯‮(monitorLock, ref flag2);
label_6:
        int num2 = -93122690;
        while (true)
        {
          int num3 = -579084127;
          uint num4;
          bool flag3;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              flag1 = true;
              num2 = (int) num4 * 1829745339 ^ 1341882088;
              continue;
            case 2:
              int num5 = !flag3 ? -1786016940 : (num5 = -1764970507);
              int num6 = (int) num4 * 1171329885;
              num2 = num5 ^ num6;
              continue;
            case 3:
              flag3 = this.RecentMessages.Contains(messageText);
              num2 = (int) num4 * 964473216 ^ 1714998833;
              continue;
            case 4:
              goto label_6;
            case 5:
              num2 = (int) num4 * 1368347143 ^ -998538847;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_13:
          int num2 = -1642505452;
          while (true)
          {
            int num3 = -579084127;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -1433833813 ^ 2081466058;
                continue;
              case 1:
                MessageMonitor.\u200C‬‬⁮‫⁪‬‬‌⁮​‪‮⁯‬‬⁮‌‬​‎‫‬​⁭‏​‭‎‍‌⁫⁬‬⁯‎‏‏‏‍‮(monitorLock);
                num2 = (int) num4 * -1526403607 ^ -59169424;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      return flag1;
    }

    static void \u206B‌⁫⁮⁭‮⁬‎‫⁫‏⁭‫⁬‏⁫‌‮⁬‏⁪‏‍‌‮‎‪‌⁫⁮‎⁯‍‎‭‬⁯‌‪⁯‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200C‬‬⁮‫⁪‬‬‌⁮​‪‮⁯‬‬⁮‌‬​‎‫‬​⁭‏​‭‎‍‌⁫⁬‬⁯‎‏‏‏‍‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static object \u206B‌⁯⁯⁬‪‪‌‮‫‮‏‏‎‫‫‭⁭‮‮‭​‬‬‭​‭‪‬‎‍⁮‍‬‌‌⁮⁪‎‭‮()
    {
      return new object();
    }
  }
}
