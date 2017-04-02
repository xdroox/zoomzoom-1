// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomFactory
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Chats;
using ZoomZoom.Common;

namespace ZoomZoom
{
  public static class ZoomFactory
  {
    private static readonly ILog log = ZoomFactory.\u206C⁫‎⁯​‪⁯⁭‪⁯‫‫‌‏⁫⁬‪⁬⁬‏‬‏⁪⁫‎​⁫‌⁭⁫‮⁬‍‬‪⁪⁬⁮⁬‫‮(ZoomFactory.\u202A⁭‍⁪‮⁬⁪⁬⁫⁬‪⁮‬‭⁮‪⁪⁬‮⁬‎‮‏⁪‫⁬⁪⁬‬‍⁭​‎‮⁮‫⁮‬‫‬‮((MemberInfo) ZoomFactory.\u206B⁫⁮‮‎​⁪‌⁬⁭‏⁭⁬‫‬⁮‎⁪‎‪‭‫‍‪‬‏⁯‭‬‮‫⁯⁮‪⁬⁪⁯⁪⁬⁭‮()));
    private static readonly object windowLock = ZoomFactory.\u206C‪​⁫‭‭‮⁮⁭‏‪‭⁬‮‪​⁮‍‏‭‫​‪‮‮​‏‫‍⁬‮⁫‍⁬⁫​​​⁪⁪‮();
    private static readonly object meetingLock;

    private static Engine Engine
    {
      get
      {
label_1:
        int num1 = -1904238494;
        Engine instance;
        while (true)
        {
          int num2 = -2120070533;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 974568614 ^ -2009499339;
              continue;
            case 1:
              instance = Engine.Instance;
              num1 = (int) num3 * 1849339351 ^ -1961921368;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return instance;
      }
    }

    static ZoomFactory()
    {
label_1:
      int num1 = 1059116103;
      while (true)
      {
        int num2 = 1613307904;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ZoomFactory.meetingLock = ZoomFactory.\u206C‪​⁫‭‭‮⁮⁭‏‪‭⁬‮‪​⁮‍‏‭‫​‪‮‮​‏‫‍⁬‮⁫‍⁬⁫​​​⁪⁪‮();
            num1 = (int) num3 * -364571783 ^ 796274959;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public static ZoomWindow CreateWindow(IntPtr handle)
    {
label_1:
      int num1 = -1459512476;
      object windowLock;
      while (true)
      {
        int num2 = -63972959;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            Engine instance = Engine.Instance;
            num1 = (int) num3 * -1820361914 ^ 1057907516;
            continue;
          case 3:
            windowLock = ZoomFactory.windowLock;
            num1 = (int) num3 * -1039938373 ^ -1833872478;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag1 = false;
      ZoomWindow zoomWindow1;
      try
      {
        ZoomFactory.\u206D‍‬​‪‏‬‌​⁪‪​⁫‎‭‬​‬⁯‮⁪‬⁬‌‍‍‎⁬‌⁭‏‫⁭⁮‏‌‎‏‬⁫‮(windowLock, ref flag1);
label_7:
        int num2 = -491891838;
        ZoomWindow zoomWindow2;
        while (true)
        {
          int num3 = -63972959;
          uint num4;
          bool flag2;
          bool flag3;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 13U)
          {
            case 0:
              flag2 = zoomWindow2 != null;
              num2 = (int) num4 * 1259960492 ^ -1980908033;
              continue;
            case 1:
              if (zoomWindow2.WindowType != WindowType.Invalid)
              {
                num2 = (int) num4 * 1581623504 ^ 648728802;
                continue;
              }
              break;
            case 3:
              int num6 = flag2 ? -1128306597 : (num6 = -1972581589);
              int num7 = (int) num4 * 1714398498;
              num2 = num6 ^ num7;
              continue;
            case 4:
              zoomWindow2 = ZoomWindow.New(handle);
              num2 = (int) num4 * -404801919 ^ 1748540984;
              continue;
            case 5:
              if (zoomWindow2.WindowType != WindowType.Other)
              {
                num2 = (int) num4 * -389760811 ^ 756789440;
                continue;
              }
              break;
            case 6:
              num2 = (int) num4 * -1967912559 ^ -717838262;
              continue;
            case 7:
              goto label_20;
            case 8:
              num5 = (uint) zoomWindow2.WindowType > 0U ? 1 : 0;
              goto label_19;
            case 9:
              int num8 = flag3 ? 1817699267 : (num8 = 1652683785);
              int num9 = (int) num4 * -1640512314;
              num2 = num8 ^ num9;
              continue;
            case 10:
              goto label_7;
            case 11:
              zoomWindow2.Refresh(false, false);
              num2 = (int) num4 * -59297130 ^ 598694273;
              continue;
            case 12:
              num2 = -1965530329;
              continue;
            default:
              goto label_30;
          }
          num5 = 0;
label_19:
          flag3 = num5 != 0;
          num2 = -870378604;
        }
label_20:
        zoomWindow1 = zoomWindow2;
        goto label_34;
      }
      finally
      {
        if (flag1)
        {
label_25:
          int num2 = -1473116332;
          while (true)
          {
            int num3 = -63972959;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_25;
              case 1:
                ZoomFactory.\u200B‏‍‌‏⁭⁮⁭⁯⁫‮⁬⁭⁭‪‭‪‭‬‏‎‭⁬⁬‫‬⁯‬‪⁭⁪‎‫‭‌‬‬‏‭‮‮(windowLock);
                num2 = (int) num4 * 813516823 ^ 428494393;
                continue;
              case 3:
                num2 = (int) num4 * -1669098602 ^ 85053565;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
label_30:
      zoomWindow1 = (ZoomWindow) null;
label_31:
      int num10 = -342799551;
      while (true)
      {
        int num2 = -63972959;
        uint num3;
        switch ((num3 = (uint) (num10 ^ num2)) % 3U)
        {
          case 1:
            num10 = (int) num3 * -819505513 ^ 185603953;
            continue;
          case 2:
            goto label_31;
          default:
            goto label_34;
        }
      }
label_34:
      return zoomWindow1;
    }

    internal static ZoomMeeting CreateMeeting(SharedData sharedData, ZoomEvent zoomEvent)
    {
label_1:
      int num1 = -861884473;
      ZoomMeeting zoomMeeting1;
      while (true)
      {
        int num2 = -1525751682;
        uint num3;
        // ISSUE: variable of a compiler-generated type
        ZoomFactory.\u003C\u003Ec__DisplayClass7_0 cDisplayClass70;
        ZoomMeeting meeting;
        ZoomMeeting zoomMeeting2;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num1 = (int) num3 * -125655202 ^ 1308101219;
            continue;
          case 1:
            num1 = (int) num3 * -157833053 ^ -1318619265;
            continue;
          case 2:
            flag1 = zoomMeeting2 == null;
            num1 = (int) num3 * 364624421 ^ -129366512;
            continue;
          case 3:
            num1 = -219942319;
            continue;
          case 4:
            ZoomFactory.Engine.AddMeeting(meeting);
            num1 = (int) num3 * 1388653764 ^ 1130222007;
            continue;
          case 5:
            num1 = (int) num3 * 464674994 ^ -1385216633;
            continue;
          case 6:
            int num4 = flag2 ? 2119542646 : (num4 = 113453885);
            int num5 = (int) num3 * 648048827;
            num1 = num4 ^ num5;
            continue;
          case 7:
            int num6 = !flag1 ? -456688871 : (num6 = -689005855);
            int num7 = (int) num3 * 912150115;
            num1 = num6 ^ num7;
            continue;
          case 8:
            zoomMeeting1 = meeting;
            num1 = -75720103;
            continue;
          case 10:
            num1 = (int) num3 * 954464147 ^ 320339067;
            continue;
          case 11:
            num1 = (int) num3 * 1521877506 ^ -609085097;
            continue;
          case 12:
            meeting = (ZoomMeeting) null;
            flag2 = zoomEvent.ZoomWindowType == ZoomWindowType.Meeting;
            num1 = (int) num3 * 1965103502 ^ -528108956;
            continue;
          case 13:
            goto label_1;
          case 14:
            // ISSUE: reference to a compiler-generated field
            meeting = new ZoomMeeting(cDisplayClass70.meetingId, zoomEvent.Window);
            num1 = (int) num3 * -735738899 ^ -584300918;
            continue;
          case 15:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass70 = new ZoomFactory.\u003C\u003Ec__DisplayClass7_0();
            num1 = (int) num3 * 980739715 ^ 1849251880;
            continue;
          case 16:
            ZoomFactory.Engine.SaveMeetings();
            num1 = (int) num3 * -422386060 ^ 849759059;
            continue;
          case 17:
            meeting = zoomMeeting2;
            num1 = -247606021;
            continue;
          case 18:
            Engine instance = Engine.Instance;
            // ISSUE: reference to a compiler-generated field
            cDisplayClass70.meetingId = MeetingHelper.GetMeetingId(zoomEvent.Window.Title);
            // ISSUE: method pointer
            zoomMeeting2 = (ZoomMeeting) Enumerable.FirstOrDefault<ZoomMeeting>((IEnumerable<M0>) ZoomFactory.Engine.Meetings, (Func<M0, bool>) new Func<ZoomMeeting, bool>((object) cDisplayClass70, __methodptr(\u003CCreateMeeting\u003Eb__0)));
            num1 = (int) num3 * -334952858 ^ -1578082535;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return zoomMeeting1;
    }

    public static ZoomMeeting Create(string sMeetingID)
    {
      ZoomMeeting zoomMeeting1 = new ZoomMeeting(sMeetingID, (ZoomWindow) null);
label_1:
      int num1 = 1927027161;
      ZoomMeeting zoomMeeting2;
      while (true)
      {
        int num2 = 1697611326;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 348419092 ^ -1215143089;
            continue;
          case 3:
            zoomMeeting2 = zoomMeeting1;
            num1 = (int) num3 * 1310578160 ^ 181907700;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return zoomMeeting2;
    }

    internal static ZoomMeeting CreateMeeting(SQLiteDataReader cReader)
    {
label_1:
      int num1 = -107527035;
      ZoomMeeting zoomMeeting1;
      while (true)
      {
        int num2 = -1451381399;
        uint num3;
        ZoomMeeting zoomMeeting2;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            zoomMeeting1 = zoomMeeting2;
            num1 = (int) num3 * -1479194898 ^ -46409495;
            continue;
          case 1:
            zoomMeeting2 = new ZoomMeeting(cReader.GetFieldValueString(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3805456170U)), (ZoomWindow) null);
            zoomMeeting2.Uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U));
            zoomMeeting2.MeetingId = cReader.GetFieldValueString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(914318002U));
            num1 = (int) num3 * -981008598 ^ -1775285761;
            continue;
          case 2:
            zoomMeeting2.DateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2131605649U));
            zoomMeeting2.DateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2223083214U));
            num1 = (int) num3 * -2027298118 ^ -1955499805;
            continue;
          case 3:
            num1 = (int) num3 * 1840191073 ^ 919705498;
            continue;
          case 4:
            num1 = (int) num3 * 1184732868 ^ 178832053;
            continue;
          case 5:
            zoomMeeting2.LastJoined = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1819168370U));
            num1 = (int) num3 * 1364740479 ^ 866669049;
            continue;
          case 7:
            zoomMeeting2.LastJoinAttempt = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(756716222U));
            num1 = (int) num3 * -1704455986 ^ 1625399531;
            continue;
          case 8:
            zoomMeeting2.JoinPriority = (MeetingPriority) cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3372572099U));
            zoomMeeting2.MeetingStatus = (MeetingStatus) cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(315515419U));
            zoomMeeting2.IsRecordingEnabled = cReader.GetFieldValueInt(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2399862151U)) == 1;
            num1 = -1250087083;
            continue;
          case 9:
            num1 = (int) num3 * -1166592411 ^ -1120755835;
            continue;
          case 10:
            goto label_1;
          case 11:
            num1 = (int) num3 * -352982468 ^ 1696642564;
            continue;
          case 12:
            zoomMeeting2.UserCountPrevious = cReader.GetFieldValueInt(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2508431365U));
            num1 = (int) num3 * -730818971 ^ 160431802;
            continue;
          case 13:
            num1 = (int) num3 * 1693982746 ^ -756332583;
            continue;
          case 14:
            zoomMeeting2.IsFavorite = cReader.GetFieldValueInt(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2436051889U)) == 1;
            zoomMeeting2.Password = cReader.GetFieldValueString(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(771323941U));
            num1 = -1961559466;
            continue;
          case 15:
            zoomMeeting2.UserCountCurrent = cReader.GetFieldValueInt(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1893205819U));
            num1 = (int) num3 * -1779447425 ^ -396766431;
            continue;
          case 16:
            zoomMeeting2.UserCountTreshold = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(502392861U));
            num1 = (int) num3 * -1524231209 ^ -457467170;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return zoomMeeting1;
    }

    internal static ZoomChat CreateChat(ZoomChatStruct _chatstruct)
    {
      ZoomChat zoomChat1 = (ZoomChat) null;
      ZoomUser zoomUser1 = (ZoomUser) null;
      ZoomUser zoomUser2 = (ZoomUser) null;
      try
      {
        zoomUser1 = Engine.Instance.GetUser(_chatstruct.senderName, true);
        if (!zoomUser1.NeverChatted)
          goto label_55;
label_2:
        int num1 = 221240047;
label_3:
        while (true)
        {
          int num2 = 767103008;
          uint num3;
          bool flag1;
          bool flag2;
          bool neverChatted;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 47U)
          {
            case 0:
              num1 = 550822523;
              continue;
            case 1:
              goto label_54;
            case 2:
              zoomUser1.BlockUser();
              num1 = (int) num3 * -2039271084 ^ 565952544;
              continue;
            case 3:
              zoomUser1.NeverChatted = false;
              num1 = (int) num3 * 972172909 ^ 817780425;
              continue;
            case 4:
              num1 = 721544009;
              continue;
            case 5:
              zoomChat1 = new ZoomChat();
              num1 = 180612212;
              continue;
            case 6:
              num1 = (int) num3 * -1931849114 ^ 91393350;
              continue;
            case 7:
              num1 = (int) num3 * 1702363803 ^ -354043368;
              continue;
            case 8:
              num1 = (int) num3 * -99633620 ^ -184157904;
              continue;
            case 9:
              zoomChat1.DateModified = StringHelper.UnixTimeStampToDateTime(_chatstruct.time);
              num1 = (int) num3 * -883984991 ^ 1748488468;
              continue;
            case 10:
              zoomChat1.ReceivingUserId = _chatstruct.receiverId;
              num1 = (int) num3 * -2128021783 ^ 1903196104;
              continue;
            case 11:
              num1 = (int) num3 * -1206688901 ^ 1649636199;
              continue;
            case 12:
              num1 = (int) num3 * -128479376 ^ -623901928;
              continue;
            case 13:
              zoomUser2.NeverChatted = false;
              num1 = (int) num3 * -1330467055 ^ 1288221450;
              continue;
            case 14:
              zoomUser2 = ZoomFactory.Engine.GetUser(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2295310954U), true);
              num1 = 1316477305;
              continue;
            case 15:
              int num6 = flag2 ? -1429483226 : (num6 = -704116549);
              int num7 = (int) num3 * -62347207;
              num1 = num6 ^ num7;
              continue;
            case 16:
              int num8 = flag1 ? -1753411417 : (num8 = -2050245738);
              int num9 = (int) num3 * 613355183;
              num1 = num8 ^ num9;
              continue;
            case 17:
              num1 = (int) num3 * -1614519495 ^ -1075723254;
              continue;
            case 18:
              zoomChat1.WasPublic = ZoomFactory.\u200B⁫⁭‏⁬‏‎‭⁬‎‍‌⁭‎⁭⁪‪‎⁮‮‏⁮⁪‮‮‮‫‪‍‬‌‮​‎‌‌‬⁫⁯‭‮(_chatstruct.receiverName);
              flag2 = ZoomFactory.Engine != null;
              num1 = 2090011129;
              continue;
            case 19:
              zoomUser2.NeverChatted = false;
              num1 = (int) num3 * 184026523 ^ 157375897;
              continue;
            case 20:
              goto label_2;
            case 21:
              num1 = 1289936976;
              continue;
            case 22:
              if (!ZoomFactory.\u206F‍‍‭‮‮⁪‫⁯⁬⁫‪⁭⁪⁬‬‫‭‫‎‍⁮⁬‍​‪‎⁯‫⁮⁯⁬⁪⁫⁬‭⁯‌⁫⁬‮(_chatstruct.receiverId, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2838344836U)))
              {
                num1 = (int) num3 * -2012750976 ^ -337086178;
                continue;
              }
              goto label_55;
            case 23:
              num1 = (int) num3 * -966406023 ^ 181243747;
              continue;
            case 24:
              num1 = (int) num3 * -1808395327 ^ 188245617;
              continue;
            case 25:
              int num10;
              num1 = num10 = ZoomFactory.\u206E‌⁮⁬⁯⁭‍‬​⁯⁭⁬‮⁭⁭⁬‬⁮⁭‍⁯‭⁮‪​⁭‏‭⁫⁬⁭‬​​‭⁯‎‍‬‬‮(Engine.Instance.Settings.DesktopAlert_IgnoredUsers, _chatstruct.senderName) ? 165872160 : (num10 = 1025856024);
              continue;
            case 26:
              zoomUser2 = Engine.Instance.GetUser(_chatstruct.receiverName, false);
              if (zoomUser2 == null)
              {
                num1 = (int) num3 * 1887472709 ^ 1284366148;
                continue;
              }
              num4 = 0;
              break;
            case 27:
              int num11 = neverChatted ? -1211695728 : (num11 = -1095342093);
              int num12 = (int) num3 * 1692856451;
              num1 = num11 ^ num12;
              continue;
            case 29:
              zoomChat1.ReceivingZoomId = _chatstruct.receiverName;
              zoomChat1.ChatContent = _chatstruct.content;
              num1 = (int) num3 * -1135034857 ^ -1299950297;
              continue;
            case 30:
              zoomUser2 = Engine.Instance.GetUser(_chatstruct.receiverName, false);
              num1 = (int) num3 * -1842537938 ^ -774235042;
              continue;
            case 31:
              if (!ZoomFactory.\u206F‍‍‭‮‮⁪‫⁯⁬⁫‪⁭⁪⁬‬‫‭‫‎‍⁮⁬‍​‪‎⁯‫⁮⁯⁬⁪⁫⁬‭⁯‌⁫⁬‮(_chatstruct.receiverId, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2973092196U)))
              {
                num1 = 94323727;
                continue;
              }
              num5 = 0;
              goto label_49;
            case 32:
              zoomChat1.MeetingUri = ZoomFactory.Engine.ActiveMeeting != null ? ZoomFactory.Engine.ActiveMeeting.Uri : ZoomFactory.Engine.Settings.LastMeetingUri;
              num1 = 1335450738;
              continue;
            case 33:
              num1 = (int) num3 * 65588293 ^ -346933088;
              continue;
            case 34:
              zoomChat1.SendingUserId = _chatstruct.senderId;
              zoomChat1.SendingZoomId = _chatstruct.senderName;
              num1 = (int) num3 * -361656682 ^ 1435070949;
              continue;
            case 35:
              num1 = (int) num3 * -130945907 ^ 355777884;
              continue;
            case 36:
              zoomChat1.CurrentName = !ZoomFactory.\u206F‍‍‭‮‮⁪‫⁯⁬⁫‪⁭⁪⁬‬‫‭‫‎‍⁮⁬‍​‪‎⁯‫⁮⁯⁬⁪⁫⁬‭⁯‌⁫⁬‮(_chatstruct.receiverId, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1742401512U)) ? _chatstruct.receiverName : ZoomFactory.Engine.CurrentName;
              num1 = 974394082;
              continue;
            case 37:
              num5 = !ZoomFactory.\u206F‍‍‭‮‮⁪‫⁯⁬⁫‪⁭⁪⁬‬‫‭‫‎‍⁮⁬‍​‪‎⁯‫⁮⁯⁬⁪⁫⁬‭⁯‌⁫⁬‮(_chatstruct.receiverName, "") ? 1 : 0;
              goto label_49;
            case 38:
              neverChatted = zoomUser2.NeverChatted;
              num1 = (int) num3 * 801851432 ^ -1068002121;
              continue;
            case 39:
              num1 = (int) num3 * 408730823 ^ -550514722;
              continue;
            case 40:
              num1 = (int) num3 * 2019405576 ^ 2044622739;
              continue;
            case 41:
              int num13;
              num1 = num13 = zoomUser2.NeverChatted ? 108295594 : (num13 = 260657429);
              continue;
            case 42:
              num1 = (int) num3 * -135149787 ^ -242223680;
              continue;
            case 43:
              num1 = (int) num3 * 1071512233 ^ 972797562;
              continue;
            case 44:
              num1 = (int) num3 * 1212478639 ^ -1080721520;
              continue;
            case 45:
              zoomChat1.DateCreated = StringHelper.UnixTimeStampToDateTime(_chatstruct.time);
              num1 = (int) num3 * 3602347 ^ -1847933663;
              continue;
            case 46:
              num4 = Engine.Instance.NewUser(_chatstruct.receiverName) ? 1 : 0;
              break;
            default:
              goto label_87;
          }
          int num14;
          num1 = num14 = num4 != 0 ? 1283757135 : (num14 = 1218656917);
          continue;
label_49:
          flag1 = num5 != 0;
          num1 = 910553383;
        }
label_54:
        int num15 = !ZoomFactory.\u206F‍‍‭‮‮⁪‫⁯⁬⁫‪⁭⁪⁬‬‫‭‫‎‍⁮⁬‍​‪‎⁯‫⁮⁯⁬⁪⁫⁬‭⁯‌⁫⁬‮(_chatstruct.receiverId, string.Empty) ? 1 : 0;
        goto label_56;
label_55:
        num15 = 0;
label_56:
        num1 = num15 == 0 ? 701179504 : (num1 = 1816875120);
        goto label_3;
      }
      catch (Exception ex)
      {
label_59:
        int num1 = 1954021052;
        while (true)
        {
          int num2 = 767103008;
          uint num3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num4 = zoomChat1.IsDirty ? 1 : 0;
              break;
            case 1:
              zoomChat1 = (ZoomChat) null;
              num1 = (int) num3 * 359370206 ^ -1542061312;
              continue;
            case 2:
              ZoomFactory.\u206F‬⁫‪‏⁫⁯‍⁭⁭‭⁮⁯‭‍‪​‌‪‏‫‎‮⁬‌‎‭⁪‬‌​‍⁭⁭‬‎‎‍‬‪‮(ZoomFactory.log, (object) ex);
              num1 = (int) num3 * 1323423099 ^ -1872298057;
              continue;
            case 3:
              goto label_59;
            case 5:
              if (zoomChat1 == null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 1731611028 ^ 1482114390;
              continue;
            default:
              goto label_87;
          }
          int num5;
          num1 = num5 = num4 == 0 ? 1447833378 : (num5 = 359391967);
        }
      }
      finally
      {
label_69:
        int num1 = 733793238;
        while (true)
        {
          int num2 = 767103008;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              int num6 = flag1 ? -1872734146 : (num6 = -639436553);
              int num7 = (int) num3 * -1064217135;
              num1 = num6 ^ num7;
              continue;
            case 1:
              num1 = 1766137705;
              continue;
            case 2:
              num4 = zoomUser2.IsDirty ? 1 : 0;
              goto label_83;
            case 3:
              zoomUser1.SaveDatabaseObject();
              num1 = (int) num3 * 1490419944 ^ 43697490;
              continue;
            case 4:
              zoomUser2.SaveDatabaseObject();
              num1 = (int) num3 * -887682673 ^ -863347415;
              continue;
            case 5:
              int num8 = flag2 ? -365534147 : (num8 = -233030886);
              int num9 = (int) num3 * -1510158024;
              num1 = num8 ^ num9;
              continue;
            case 6:
              num5 = zoomUser1.IsDirty ? 1 : 0;
              break;
            case 7:
              goto label_69;
            case 8:
              if (zoomUser2 != null)
              {
                num1 = 142631529;
                continue;
              }
              num4 = 0;
              goto label_83;
            case 10:
              if (zoomUser1 != null)
              {
                num1 = (int) num3 * -1192742205 ^ -366550199;
                continue;
              }
              num5 = 0;
              break;
            default:
              goto label_86;
          }
          flag2 = num5 != 0;
          num1 = 214470560;
          continue;
label_83:
          flag1 = num4 != 0;
          num1 = 1826573310;
        }
label_86:;
      }
label_87:
      ZoomChat zoomChat2 = zoomChat1;
label_88:
      int num16 = 1898623021;
      while (true)
      {
        int num1 = 767103008;
        uint num2;
        switch ((num2 = (uint) (num16 ^ num1)) % 3U)
        {
          case 0:
            goto label_88;
          case 1:
            num16 = (int) num2 * -71884511 ^ 536657816;
            continue;
          default:
            goto label_91;
        }
      }
label_91:
      return zoomChat2;
    }

    internal static ZoomButton CreateButton(SQLiteDataReader cReader)
    {
label_1:
      int num1 = -2120293011;
      ZoomButton zoomButton1;
      while (true)
      {
        int num2 = -1704603019;
        uint num3;
        ZoomButton zoomButton2;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            goto label_1;
          case 1:
            zoomButton2.ButtonX = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(240715330U));
            num1 = (int) num3 * 186380617 ^ -606682920;
            continue;
          case 2:
            num1 = (int) num3 * -1941207105 ^ 879425159;
            continue;
          case 3:
            zoomButton2.WindowWidth = cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3435639904U));
            num1 = (int) num3 * -774111270 ^ -54198022;
            continue;
          case 4:
            zoomButton2.ButtonY = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2263636494U));
            zoomButton2.RequiresRightClick = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(720547036U)) == 1;
            num1 = -1571677933;
            continue;
          case 5:
            zoomButton2.MeetingId = cReader.GetFieldValueString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3041963409U));
            num1 = (int) num3 * 20485245 ^ 1979446061;
            continue;
          case 6:
            zoomButton2.ZoomWindowType = (ZoomWindowType) cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3071765281U));
            zoomButton2.WindowHeight = cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2169446332U));
            num1 = (int) num3 * 1101611712 ^ -241432053;
            continue;
          case 7:
            zoomButton2.ResultingWindowType = (ZoomWindowType) cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3645992511U));
            num1 = (int) num3 * 1322781875 ^ -97070848;
            continue;
          case 8:
            num1 = (int) num3 * -931489166 ^ 1625892635;
            continue;
          case 9:
            num1 = (int) num3 * 657690541 ^ 1596414237;
            continue;
          case 11:
            zoomButton2.DateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3397799221U));
            zoomButton2.DateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3689749305U));
            zoomButton1 = zoomButton2;
            num1 = (int) num3 * -1163412607 ^ -1110236795;
            continue;
          case 12:
            zoomButton2 = new ZoomButton();
            zoomButton2.Uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3666502981U));
            num1 = (int) num3 * 1608300731 ^ -782701900;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return zoomButton1;
    }

    static MethodBase \u206B⁫⁮‮‎​⁪‌⁬⁭‏⁭⁬‫‬⁮‎⁪‎‪‭‫‍‪‬‏⁯‭‬‮‫⁯⁮‪⁬⁪⁯⁪⁬⁭‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202A⁭‍⁪‮⁬⁪⁬⁫⁬‪⁮‬‭⁮‪⁪⁬‮⁬‎‮‏⁪‫⁬⁪⁬‬‍⁭​‎‮⁮‫⁮‬‫‬‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206C⁫‎⁯​‪⁯⁭‪⁯‫‫‌‏⁫⁬‪⁬⁬‏‬‏⁪⁫‎​⁫‌⁭⁫‮⁬‍‬‪⁪⁬⁮⁬‫‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static object \u206C‪​⁫‭‭‮⁮⁭‏‪‭⁬‮‪​⁮‍‏‭‫​‪‮‮​‏‫‍⁬‮⁫‍⁬⁫​​​⁪⁪‮()
    {
      return new object();
    }

    static void \u206D‍‬​‪‏‬‌​⁪‪​⁫‎‭‬​‬⁯‮⁪‬⁬‌‍‍‎⁬‌⁭‏‫⁭⁮‏‌‎‏‬⁫‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200B‏‍‌‏⁭⁮⁭⁯⁫‮⁬⁭⁭‪‭‪‭‬‏‎‭⁬⁬‫‬⁯‬‪⁭⁪‎‫‭‌‬‬‏‭‮‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static bool \u206F‍‍‭‮‮⁪‫⁯⁬⁫‪⁭⁪⁬‬‫‭‫‎‍⁮⁬‍​‪‎⁯‫⁮⁯⁬⁪⁫⁬‭⁯‌⁫⁬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u206E‌⁮⁬⁯⁭‍‬​⁯⁭⁬‮⁭⁭⁬‬⁮⁭‍⁯‭⁮‪​⁭‏‭⁫⁬⁭‬​​‭⁯‎‍‬‬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static bool \u200B⁫⁭‏⁬‏‎‭⁬‎‍‌⁭‎⁭⁪‪‎⁮‮‏⁮⁪‮‮‮‫‪‍‬‌‮​‎‌‌‬⁫⁯‭‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static void \u206F‬⁫‪‏⁫⁯‍⁭⁭‭⁮⁯‭‍‪​‌‪‏‫‎‮⁬‌‎‭⁪‬‌​‍⁭⁭‬‎‎‍‬‪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }
  }
}
