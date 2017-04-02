// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MeetingHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  internal static class MeetingHelper
  {
    internal static MeetingStatus GetMeetingStatus(ZoomEvent activityEvent)
    {
label_1:
      int num1 = -1852219666;
      MeetingStatus meetingStatus1;
      while (true)
      {
        int num2 = -867106759;
        uint num3;
        MeetingStatus meetingStatus2;
        ZoomWindowType zoomWindowType;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -266624309 ^ 133946697;
            continue;
          case 2:
            num1 = (int) num3 * -1305880474 ^ 330823243;
            continue;
          case 3:
          case 10:
label_11:
            meetingStatus1 = meetingStatus2;
            num1 = -682963950;
            continue;
          case 4:
label_17:
            meetingStatus2 = MeetingStatus.Password;
            num1 = -512077361;
            continue;
          case 6:
label_9:
            meetingStatus2 = MeetingStatus.Attending;
            num1 = -512077361;
            continue;
          case 7:
            meetingStatus2 = MeetingStatus.Unknown;
            num1 = (int) num3 * -765840908 ^ -966458416;
            continue;
          case 8:
            num1 = (int) num3 * -1057006174 ^ 133231463;
            continue;
          case 9:
            switch (zoomWindowType)
            {
              case ZoomWindowType.Meeting:
              case ZoomWindowType.Chat:
              case ZoomWindowType.Participants:
              case ZoomWindowType.DualVideo:
              case ZoomWindowType.JoinAudio:
              case ZoomWindowType.Settings:
              case ZoomWindowType.Invite:
              case ZoomWindowType.ScreenSharingDisabled:
              case ZoomWindowType.RequestRecord:
              case ZoomWindowType.AudioNotification:
              case ZoomWindowType.AudioError:
              case ZoomWindowType.AudioMenu:
              case ZoomWindowType.Sharing:
                goto label_9;
              case ZoomWindowType.Notification:
              case ZoomWindowType.Video:
              case ZoomWindowType.Container:
              case ZoomWindowType.Other:
              case ZoomWindowType.ManyCamBroadcast:
              case ZoomWindowType.LeaveCurrent:
              case ZoomWindowType.MeetingButtonBar:
              case ZoomWindowType.GalleryScrollRight:
              case ZoomWindowType.GalleryScrollLeft:
              case ZoomWindowType.ToolTip:
              case ZoomWindowType.ScreenShareOptions:
              case ZoomWindowType.RequestRemoteControl:
              case ZoomWindowType.GalleryView:
              case ZoomWindowType.SpeakerViewScrollLeft:
              case ZoomWindowType.SpeakerViewScrollRight:
              case ZoomWindowType.SpeakerView:
              case ZoomWindowType.MeetingViewToggle:
              case ZoomWindowType.ManyCamApp:
                goto label_11;
              case ZoomWindowType.InvalidMeeting:
                goto label_5;
              case ZoomWindowType.WaitingForHost:
                goto label_14;
              case ZoomWindowType.Locked:
                goto label_15;
              case ZoomWindowType.Full:
                goto label_10;
              case ZoomWindowType.EndMeeting:
                goto label_16;
              case ZoomWindowType.Password:
                goto label_17;
              default:
                num1 = (int) num3 * -1616541272 ^ 178697180;
                continue;
            }
          case 11:
            num1 = (int) num3 * -2041216746 ^ 395358746;
            continue;
          case 12:
label_14:
            meetingStatus2 = MeetingStatus.WaitingForHost;
            num1 = -240512151;
            continue;
          case 13:
label_16:
            meetingStatus2 = MeetingStatus.Error;
            num1 = -512077361;
            continue;
          case 14:
label_5:
            meetingStatus2 = MeetingStatus.Invalid;
            num1 = -333162195;
            continue;
          case 15:
label_10:
            meetingStatus2 = MeetingStatus.Full;
            num1 = -1000360789;
            continue;
          case 16:
            num1 = (int) num3 * -282465942 ^ 388210415;
            continue;
          case 17:
            zoomWindowType = activityEvent.ZoomWindowType;
            num1 = (int) num3 * 160036762 ^ -1737707026;
            continue;
          case 18:
            num1 = (int) num3 * 1497424677 ^ -70787371;
            continue;
          case 19:
label_15:
            meetingStatus2 = MeetingStatus.Locked;
            num1 = -2085815537;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return meetingStatus1;
    }

    public static string GetMeetingId(string windowTitle)
    {
label_1:
      int num1 = -1508669175;
      string str1;
      while (true)
      {
        int num2 = -1160454104;
        uint num3;
        string str2;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            str2 = MeetingHelper.\u206C⁮‪‮⁪⁮‫‬‭‍⁭‍⁯‮‮‪‮‬​‫‎⁪⁬‭‬‎‪⁭‌⁬​‬⁬‎⁬⁮⁬‍‬⁪‮(str2, 0, MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(str2, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3515778971U)));
            num1 = (int) num3 * -1739857172 ^ -1361346976;
            continue;
          case 1:
            int num4;
            num1 = num4 = MeetingHelper.\u200F‭‮‭⁬‏‬⁮⁭⁫​‭⁮‌‌‮‮‎⁯⁭‎‭‮​⁪‮‮⁭⁮‏‪‭‏​⁭‬‮‮⁪⁭‮(str2, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(209903335U)) ? -1779491089 : (num4 = -721285241);
            continue;
          case 2:
            str2 = string.Empty;
            flag = MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(windowTitle, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(686362902U)) > 0;
            num1 = (int) num3 * 50536684 ^ -795736420;
            continue;
          case 3:
            int num5 = flag ? -23816314 : (num5 = -236063900);
            int num6 = (int) num3 * 1491994398;
            num1 = num5 ^ num6;
            continue;
          case 5:
            num1 = (int) num3 * -208036827 ^ -216130412;
            continue;
          case 6:
            str2 = MeetingHelper.\u200F⁬​‏⁫⁪‪⁭‫‬⁯‍⁪‍‭​⁭‏⁮⁫​⁯‌⁯‫⁯‍⁫⁫​⁭⁬⁮‎⁪‌‌‎‌⁬‮(MeetingHelper.\u202A‭⁪‭‫⁪‫‍‌⁬⁫⁬⁭⁪‌‬‫‎‏‎⁬⁮‫‌⁭‪‭‌‏‪‬⁯⁪‌⁫⁪‬⁭‫⁯‮(MeetingHelper.\u200C⁫⁫‫‏‮‬‏‬‮‏‎​⁫‭⁬⁮‪‫‬⁭‪‭‍⁪‭‬‌‪‍‬⁮⁪⁫​‪⁬⁯‏‮‮(windowTitle, MeetingHelper.\u200C‪⁬⁫⁯​‫‎⁪‌‭‮‏‫‪⁫⁫‏‫⁮‪‭‭‍⁪⁭⁯‭​‮⁯‫⁭​‬‌‏‎‌‎‮(windowTitle, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1554459379U)) + 3)), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(393582707U), "");
            num1 = (int) num3 * 831577770 ^ 770090599;
            continue;
          case 7:
            str1 = str2;
            num1 = -1623851345;
            continue;
          case 8:
            str2 = windowTitle;
            num1 = -1409034661;
            continue;
          case 9:
            num1 = (int) num3 * 1303839627 ^ 1493314067;
            continue;
          case 10:
            goto label_1;
          default:
            goto label_12;
        }
      }
label_12:
      return str1;
    }

    internal static string GetmeetingWindowCaption(string sFormattedMeetingId)
    {
label_1:
      int num1 = 1183197703;
      string str;
      while (true)
      {
        int num2 = 6924607;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            str = MeetingHelper.\u202C‍⁫⁯⁯⁭‭‍⁭⁮⁭‪​‪‍​⁭‍‎⁯‌‌​‭‏⁯⁮⁮‏⁯⁬⁯‭‬‍‭⁬​⁭‏‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2317486497U), sFormattedMeetingId);
            num1 = (int) num3 * 524087215 ^ -417251410;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return str;
    }

    internal static string GetFormattedMeetingId(string _ID)
    {
label_1:
      int num1 = 919540630;
      string str;
      while (true)
      {
        int num2 = 782964635;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            str = _ID;
            num1 = 1633485878;
            continue;
          case 1:
            int num4 = _ID != null ? 1960786079 : (num4 = 102178532);
            int num5 = (int) num3 * -112359463;
            num1 = num4 ^ num5;
            continue;
          case 2:
            _ID = string.Empty;
            num1 = (int) num3 * 1942110643 ^ -1494480998;
            continue;
          case 3:
            _ID = MeetingHelper.\u200F⁬​‏⁫⁪‪⁭‫‬⁯‍⁪‍‭​⁭‏⁮⁫​⁯‌⁯‫⁯‍⁫⁫​⁭⁬⁮‎⁪‌‌‎‌⁬‮(_ID, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2691421578U), "");
            flag = MeetingHelper.\u202D‌‪​‎⁮⁬⁪⁯‪‮‮‏⁯‬‌‬‎‎‮‏‪‭⁪‌‏‪⁪​‭‏‪‍‮⁪‫⁫‪⁪⁪‮(_ID) > 7;
            num1 = 740221147;
            continue;
          case 4:
            int num6 = flag ? -954508806 : (num6 = -145388427);
            int num7 = (int) num3 * -1022518308;
            num1 = num6 ^ num7;
            continue;
          case 5:
            _ID = MeetingHelper.\u206B⁯‮‫‭‪⁮‭‮⁭‍‬‪‬‌⁮⁪​‪‭‍‍‪‌​‫⁪‍‏‍‏⁬⁪⁭‭‫⁬⁯‭⁮‮(new string[5]
            {
              MeetingHelper.\u206C⁮‪‮⁪⁮‫‬‭‍⁭‍⁯‮‮‪‮‬​‫‎⁪⁬‭‬‎‪⁭‌⁬​‬⁬‎⁬⁮⁬‍‬⁪‮(_ID, 0, 3),
              \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2237685910U),
              MeetingHelper.\u206C⁮‪‮⁪⁮‫‬‭‍⁭‍⁯‮‮‪‮‬​‫‎⁪⁬‭‬‎‪⁭‌⁬​‬⁬‎⁬⁮⁬‍‬⁪‮(_ID, 3, 3),
              \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(767452174U),
              MeetingHelper.\u200C⁫⁫‫‏‮‬‏‬‮‏‎​⁫‭⁬⁮‪‫‬⁭‪‭‍⁪‭‬‌‪‍‬⁮⁪⁫​‪⁬⁯‏‮‮(_ID, 6)
            });
            num1 = (int) num3 * -504851402 ^ -1009333351;
            continue;
          case 6:
            num1 = (int) num3 * 904883302 ^ -425166329;
            continue;
          case 8:
            num1 = (int) num3 * -958296575 ^ -917973759;
            continue;
          case 9:
            goto label_1;
          default:
            goto label_11;
        }
      }
label_11:
      return str;
    }

    internal static string GetMeetingIdFromWindowTitle(string sWindowCaption)
    {
label_1:
      int num1 = 1980584476;
      string str1;
      while (true)
      {
        int num2 = 239828385;
        uint num3;
        bool flag;
        string str2;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            int num4;
            num1 = num4 = !MeetingHelper.\u200F‭‮‭⁬‏‬⁮⁭⁫​‭⁮‌‌‮‮‎⁯⁭‎‭‮​⁪‮‮⁭⁮‏‪‭‏​⁭‬‮‮⁪⁭‮(sWindowCaption, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(324465522U)) ? 921281505 : (num4 = 863928055);
            continue;
          case 1:
            num1 = (int) num3 * 1600496886 ^ -153593627;
            continue;
          case 2:
            int num5 = !flag ? 1821218593 : (num5 = 1304580345);
            int num6 = (int) num3 * 75305561;
            num1 = num5 ^ num6;
            continue;
          case 3:
            str2 = MeetingHelper.\u202A‭⁪‭‫⁪‫‍‌⁬⁫⁬⁭⁪‌‬‫‎‏‎⁬⁮‫‌⁭‪‭‌‏‪‬⁯⁪‌⁫⁪‬⁭‫⁯‮(MeetingHelper.\u206C⁮‪‮⁪⁮‫‬‭‍⁭‍⁯‮‮‪‮‬​‫‎⁪⁬‭‬‎‪⁭‌⁬​‬⁬‎⁬⁮⁬‍‬⁪‮(str2, 0, MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(str2, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(209903335U))));
            num1 = (int) num3 * 1771691912 ^ 594336843;
            continue;
          case 5:
            num1 = (int) num3 * 1269797783 ^ 9906012;
            continue;
          case 6:
            str2 = MeetingHelper.\u202A‭⁪‭‫⁪‫‍‌⁬⁫⁬⁭⁪‌‬‫‎‏‎⁬⁮‫‌⁭‪‭‌‏‪‬⁯⁪‌⁫⁪‬⁭‫⁯‮(MeetingHelper.\u206C⁮‪‮⁪⁮‫‬‭‍⁭‍⁯‮‮‪‮‬​‫‎⁪⁬‭‬‎‪⁭‌⁬​‬⁬‎⁬⁮⁬‍‬⁪‮(str2, 0, MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(str2, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3518570259U))));
            num1 = (int) num3 * -1186074796 ^ 1837735967;
            continue;
          case 7:
            str2 = MeetingHelper.\u200F⁬​‏⁫⁪‪⁭‫‬⁯‍⁪‍‭​⁭‏⁮⁫​⁯‌⁯‫⁯‍⁫⁫​⁭⁬⁮‎⁪‌‌‎‌⁬‮(MeetingHelper.\u200F⁬​‏⁫⁪‪⁭‫‬⁯‍⁪‍‭​⁭‏⁮⁫​⁯‌⁯‫⁯‍⁫⁫​⁭⁬⁮‎⁪‌‌‎‌⁬‮(sWindowCaption, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1837654791U), ""), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3515778971U), "");
            num1 = (int) num3 * -1483354132 ^ 266920417;
            continue;
          case 8:
            num1 = 464886122;
            continue;
          case 9:
            flag = MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(sWindowCaption, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2883877321U)) > 0;
            num1 = 867637089;
            continue;
          case 10:
            str2 = MeetingHelper.\u202A‭⁪‭‫⁪‫‍‌⁬⁫⁬⁭⁪‌‬‫‎‏‎⁬⁮‫‌⁭‪‭‌‏‪‬⁯⁪‌⁫⁪‬⁭‫⁯‮(MeetingHelper.\u200F⁬​‏⁫⁪‪⁭‫‬⁯‍⁪‍‭​⁭‏⁮⁫​⁯‌⁯‫⁯‍⁫⁫​⁭⁬⁮‎⁪‌‌‎‌⁬‮(MeetingHelper.\u200C⁫⁫‫‏‮‬‏‬‮‏‎​⁫‭⁬⁮‪‫‬⁭‪‭‍⁪‭‬‌‪‍‬⁮⁪⁫​‪⁬⁯‏‮‮(sWindowCaption, MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(sWindowCaption, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1357823085U))), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(143516832U), ""));
            num1 = (int) num3 * -804506496 ^ -223386171;
            continue;
          case 11:
            num1 = (int) num3 * -455512364 ^ -1506988564;
            continue;
          case 12:
            num1 = (int) num3 * -638135744 ^ 996241889;
            continue;
          case 13:
            goto label_1;
          case 14:
            str2 = MeetingHelper.\u202A‭⁪‭‫⁪‫‍‌⁬⁫⁬⁭⁪‌‬‫‎‏‎⁬⁮‫‌⁭‪‭‌‏‪‬⁯⁪‌⁫⁪‬⁭‫⁯‮(MeetingHelper.\u200C⁫⁫‫‏‮‬‏‬‮‏‎​⁫‭⁬⁮‪‫‬⁭‪‭‍⁪‭‬‌‪‍‬⁮⁪⁫​‪⁬⁯‏‮‮(sWindowCaption, MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(sWindowCaption, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3632527092U)) + 1));
            num1 = (int) num3 * -1677397379 ^ -817042971;
            continue;
          case 15:
            str1 = str2;
            num1 = 1181139596;
            continue;
          case 16:
            str2 = string.Empty;
            int num7 = MeetingHelper.\u200F‭‮‭⁬‏‬⁮⁭⁫​‭⁮‌‌‮‮‎⁯⁭‎‭‮​⁪‮‮⁭⁮‏‪‭‏​⁭‬‮‮⁪⁭‮(sWindowCaption, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1357823085U)) ? 447005063 : (num7 = 2006922380);
            int num8 = (int) num3 * 262879794;
            num1 = num7 ^ num8;
            continue;
          case 17:
            int num9 = MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(str2, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3515778971U)) > 0 ? -1266641293 : (num9 = -327364704);
            int num10 = (int) num3 * 98638581;
            num1 = num9 ^ num10;
            continue;
          case 18:
            num1 = (int) num3 * -638082614 ^ -860391023;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return str1;
    }

    internal static bool LoadMeetingUsers(ZoomWindow meetingWindow, ref List<ZoomUser> zMeetingUsers)
    {
label_1:
      int num1 = 1556824238;
      bool flag;
      while (true)
      {
        int num2 = 1237549844;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = false;
            num1 = (int) num3 * 1821534487 ^ -1375471327;
            continue;
          case 3:
            num1 = (int) num3 * 1819569539 ^ -766594532;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    internal static string GetMeetingIdFromUrl(string sUrl)
    {
label_1:
      int num1 = 27897947;
      string str1;
      while (true)
      {
        int num2 = 1689692278;
        uint num3;
        bool flag1;
        string str2;
        string str3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = flag2 ? -2074145822 : (num4 = -302787723);
            int num5 = (int) num3 * 932395812;
            num1 = num4 ^ num5;
            continue;
          case 2:
            str2 = MeetingHelper.\u206C⁮‪‮⁪⁮‫‬‭‍⁭‍⁯‮‮‪‮‬​‫‎⁪⁬‭‬‎‪⁭‌⁬​‬⁬‎⁬⁮⁬‍‬⁪‮(str2, 0, MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(str2, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(859380423U)));
            num1 = (int) num3 * 469478324 ^ 1735885874;
            continue;
          case 3:
            num1 = (int) num3 * -948732579 ^ -962982047;
            continue;
          case 4:
            str2 = MeetingHelper.\u200C⁫⁫‫‏‮‬‏‬‮‏‎​⁫‭⁬⁮‪‫‬⁭‪‭‍⁪‭‬‌‪‍‬⁮⁪⁫​‪⁬⁯‏‮‮(str2, MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(str2, str3) + MeetingHelper.\u202D‌‪​‎⁮⁬⁪⁯‪‮‮‏⁯‬‌‬‎‎‮‏‪‭⁪‌‏‪⁪​‭‏‪‍‮⁪‫⁫‪⁪⁪‮(str3));
            num1 = (int) num3 * 490061837 ^ -301337033;
            continue;
          case 5:
            flag2 = MeetingHelper.\u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮(str2, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2280426333U)) > 0;
            num1 = (int) num3 * -1594154569 ^ -1663054960;
            continue;
          case 6:
            str3 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3563674369U);
            num1 = (int) num3 * -458027111 ^ 915727303;
            continue;
          case 8:
            str1 = str2;
            num1 = 1764507537;
            continue;
          case 9:
            num1 = (int) num3 * -417916381 ^ -1976517392;
            continue;
          case 10:
            flag1 = MeetingHelper.\u200F‭‮‭⁬‏‬⁮⁭⁫​‭⁮‌‌‮‮‎⁯⁭‎‭‮​⁪‮‮⁭⁮‏‪‭‏​⁭‬‮‮⁪⁭‮(str2, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1715048345U));
            num1 = (int) num3 * 1919227186 ^ 772833522;
            continue;
          case 11:
            num1 = 375971777;
            continue;
          case 12:
            num1 = (int) num3 * -943920683 ^ 111501491;
            continue;
          case 13:
            int num6 = flag1 ? -1020021567 : (num6 = -1534560342);
            int num7 = (int) num3 * -159960850;
            num1 = num6 ^ num7;
            continue;
          case 14:
            str2 = sUrl;
            num1 = (int) num3 * 705127235 ^ -1942822913;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return str1;
    }

    static int \u206C‫‏‍​‫⁭‫‭‫‭‫​‬​‪‭⁪‬‌‎‍‪‏⁬⁪‮⁬⁯‪‪⁪‎⁫‍‪‌⁭‏‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.IndexOf(obj1);
    }

    static int \u200C‪⁬⁫⁯​‫‎⁪‌‭‮‏‫‪⁫⁫‏‫⁮‪‭‭‍⁪⁭⁯‭​‮⁯‫⁭​‬‌‏‎‌‎‮([In] string obj0, [In] string obj1)
    {
      return obj0.LastIndexOf(obj1);
    }

    static string \u200C⁫⁫‫‏‮‬‏‬‮‏‎​⁫‭⁬⁮‪‫‬⁭‪‭‍⁪‭‬‌‪‍‬⁮⁪⁫​‪⁬⁯‏‮‮([In] string obj0, [In] int obj1)
    {
      return obj0.Substring(obj1);
    }

    static string \u202A‭⁪‭‫⁪‫‍‌⁬⁫⁬⁭⁪‌‬‫‎‏‎⁬⁮‫‌⁭‪‭‌‏‪‬⁯⁪‌⁫⁪‬⁭‫⁯‮([In] string obj0)
    {
      return obj0.Trim();
    }

    static string \u200F⁬​‏⁫⁪‪⁭‫‬⁯‍⁪‍‭​⁭‏⁮⁫​⁯‌⁯‫⁯‍⁫⁫​⁭⁬⁮‎⁪‌‌‎‌⁬‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static bool \u200F‭‮‭⁬‏‬⁮⁭⁫​‭⁮‌‌‮‮‎⁯⁭‎‭‮​⁪‮‮⁭⁮‏‪‭‏​⁭‬‮‮⁪⁭‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static string \u206C⁮‪‮⁪⁮‫‬‭‍⁭‍⁯‮‮‪‮‬​‫‎⁪⁬‭‬‎‪⁭‌⁬​‬⁬‎⁬⁮⁬‍‬⁪‮([In] string obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Substring(obj1, obj2);
    }

    static string \u202C‍⁫⁯⁯⁭‭‍⁭⁮⁭‪​‪‍​⁭‍‎⁯‌‌​‭‏⁯⁮⁮‏⁯⁬⁯‭‬‍‭⁬​⁭‏‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static int \u202D‌‪​‎⁮⁬⁪⁯‪‮‮‏⁯‬‌‬‎‎‮‏‪‭⁪‌‏‪⁪​‭‏‪‍‮⁪‫⁫‪⁪⁪‮([In] string obj0)
    {
      return obj0.Length;
    }

    static string \u206B⁯‮‫‭‪⁮‭‮⁭‍‬‪‬‌⁮⁪​‪‭‍‍‪‌​‫⁪‍‏‍‏⁬⁪⁭‭‫⁬⁯‭⁮‮([In] string[] obj0)
    {
      return string.Concat(obj0);
    }
  }
}
