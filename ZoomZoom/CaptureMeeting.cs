// Decompiled with JetBrains decompiler
// Type: ZoomZoom.CaptureMeeting
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Images;

namespace ZoomZoom
{
  public class CaptureMeeting : ActivityBase
  {
    private static List<ZoomImage> meetingImages = new List<ZoomImage>();
    private bool justLoaded = false;
    private bool justScrolledRight = false;
    private ZoomImage meetingImage = (ZoomImage) null;
    private ZoomMeeting meeting;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 1824927017;
        TraceType traceType;
        while (true)
        {
          int num2 = 413964937;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -2128677581 ^ 305248412;
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

    public List<ZoomImage> MeetingImages
    {
      get
      {
        return CaptureMeeting.meetingImages;
      }
      set
      {
label_1:
        int num1 = 1599523491;
        while (true)
        {
          int num2 = 507784459;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              CaptureMeeting.meetingImages = value;
              num1 = (int) num3 * 2058015279 ^ 479121524;
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

    public bool JustScrolled
    {
      get
      {
        return this.justScrolledRight;
      }
      set
      {
label_1:
        int num1 = -1320503009;
        while (true)
        {
          int num2 = -770257471;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.justScrolledRight = value;
              num1 = (int) num3 * 1517999925 ^ 1754961866;
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

    public bool JustLoaded
    {
      get
      {
label_1:
        int num1 = -2076904670;
        bool justLoaded;
        while (true)
        {
          int num2 = -1786647071;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -626227020 ^ 1220281051;
              continue;
            case 3:
              justLoaded = this.justLoaded;
              num1 = (int) num3 * 1044102261 ^ -391870421;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return justLoaded;
      }
      set
      {
label_1:
        int num1 = -231833599;
        while (true)
        {
          int num2 = -587201344;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.justLoaded = value;
              num1 = (int) num3 * 1252323186 ^ -1987594149;
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

    public ZoomImage MeetingImage
    {
      get
      {
label_1:
        int num1 = -1766256753;
        ZoomImage meetingImage;
        while (true)
        {
          int num2 = -54742514;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              meetingImage = this.meetingImage;
              num1 = (int) num3 * 1813622345 ^ -1308370508;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 2035777920 ^ 1037739842;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingImage;
      }
      set
      {
        this.meetingImage = value;
      }
    }

    public ZoomMeeting Meeting
    {
      get
      {
label_1:
        int num1 = 1033944239;
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = 1283772793;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 50221502 ^ 2147309807;
              continue;
            case 2:
              meeting = this.meeting;
              num1 = (int) num3 * 1901913307 ^ 857724298;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return meeting;
      }
      set
      {
        this.meeting = value;
      }
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = -1971824825;
      while (true)
      {
        int num2 = -1995959788;
        uint num3;
        bool flag1;
        bool flag2;
        GalleryMoveFirstPage galleryMoveFirstPage;
        bool flag3;
        GalleryMoveNextPage galleryMoveNextPage;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 41U)
        {
          case 0:
            ++num4;
            num1 = -1515384927;
            continue;
          case 1:
            num5 = galleryMoveNextPage.Result != null ? 1 : 0;
            break;
          case 2:
            this.SetGalleryMode(true);
            num1 = (int) num3 * -401211276 ^ -734749267;
            continue;
          case 3:
            int num6 = flag1 ? 1735259155 : (num6 = 446780518);
            int num7 = (int) num3 * -1524233559;
            num1 = num6 ^ num7;
            continue;
          case 4:
            num1 = (int) num3 * 932046368 ^ -34325990;
            continue;
          case 5:
            int num8 = !flag2 ? -119231711 : (num8 = -1676709374);
            int num9 = (int) num3 * -142620539;
            num1 = num8 ^ num9;
            continue;
          case 6:
            galleryMoveNextPage = new GalleryMoveNextPage();
            num1 = (int) num3 * -960159009 ^ 1592275808;
            continue;
          case 7:
            this.MinimizeWindows(this.MeetingWindow);
            num1 = (int) num3 * 555727642 ^ 1679396546;
            continue;
          case 8:
            this.JustLoaded = true;
            num1 = (int) num3 * 31781045 ^ 607575979;
            continue;
          case 9:
            this.EndTime = DateTime.Now.AddSeconds(10.0);
            num1 = (int) num3 * -49125027 ^ 1976848099;
            continue;
          case 10:
            num1 = (int) num3 * -1640021497 ^ 2093176093;
            continue;
          case 11:
            num4 = 0;
            num1 = (int) num3 * 1056722862 ^ -1401186059;
            continue;
          case 12:
            num1 = (int) num3 * -769366186 ^ -731506207;
            continue;
          case 13:
            num1 = (int) num3 * -461173646 ^ 28151445;
            continue;
          case 14:
            num1 = (int) num3 * -784109948 ^ -1749296556;
            continue;
          case 15:
            flag1 = this.ContinueExecution();
            num1 = -1845279038;
            continue;
          case 16:
            this.DisplayImageHistoryView();
            num1 = (int) num3 * 918827547 ^ -2131594754;
            continue;
          case 17:
            this.SetActivityState(ActivityState.InProgress, "");
            num1 = (int) num3 * -1283991669 ^ 1246629568;
            continue;
          case 18:
            int num10 = !flag3 ? 119692885 : (num10 = 592773983);
            int num11 = (int) num3 * -471513346;
            num1 = num10 ^ num11;
            continue;
          case 19:
            this.MinimizeWindows(this.MeetingWindow);
            num1 = (int) num3 * -531330270 ^ -1961662262;
            continue;
          case 20:
            if (this.ExecuteSubActivity((ActivityBase) galleryMoveNextPage, true) == ActivityState.Completed)
            {
              num1 = (int) num3 * -323110068 ^ -1050666840;
              continue;
            }
            num5 = 0;
            break;
          case 21:
            num1 = -215628579;
            continue;
          case 22:
            flag2 = num4 > 5;
            num1 = -849510821;
            continue;
          case 23:
            num1 = (int) num3 * -408421405 ^ 1267508988;
            continue;
          case 24:
            galleryMoveFirstPage = new GalleryMoveFirstPage();
            num1 = (int) num3 * -1024331682 ^ -1611056220;
            continue;
          case 25:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(722167517U));
            num1 = (int) num3 * -1700372548 ^ 992244326;
            continue;
          case 26:
            num1 = (int) num3 * -563608129 ^ -1806429998;
            continue;
          case 27:
            num1 = (int) num3 * -1348728845 ^ 332938384;
            continue;
          case 28:
            num1 = -178142488;
            continue;
          case 29:
            int num12 = this.ExecuteSubActivity((ActivityBase) galleryMoveFirstPage, true) == ActivityState.Completed ? -464256404 : (num12 = -478447087);
            int num13 = (int) num3 * 1800442174;
            num1 = num12 ^ num13;
            continue;
          case 30:
            num1 = (int) num3 * 1594918537 ^ 2103061172;
            continue;
          case 31:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(685977779U));
            num1 = (int) num3 * 772688653 ^ -1944474129;
            continue;
          case 32:
            this.RestoreWindows();
            num1 = -1979112609;
            continue;
          case 33:
            Thread.Sleep(40);
            num1 = (int) num3 * 1685281762 ^ -1924324888;
            continue;
          case 34:
            num1 = (int) num3 * 1183462878 ^ -709289798;
            continue;
          case 35:
            num1 = (int) num3 * 1462665568 ^ 1336366163;
            continue;
          case 36:
            goto label_1;
          case 37:
            this.CaptureMeetingImage();
            num1 = (int) num3 * -572295407 ^ 947973213;
            continue;
          case 38:
            goto label_3;
          case 39:
            num1 = (int) num3 * 1373737683 ^ -1397811344;
            continue;
          case 40:
            num1 = (int) num3 * 1148689853 ^ 1430513246;
            continue;
          default:
            goto label_46;
        }
        flag3 = num5 != 0;
        num1 = -1029598044;
      }
label_46:
      return;
label_3:;
    }

    private void CaptureMeetingImage()
    {
      IEnumerator<ZoomWindow> enumerator = this.Engine.SharedData.ActiveWindows.GetEnumerator();
      try
      {
label_5:
        int num1 = CaptureMeeting.\u206C‌⁭‪⁪‎‎⁯⁭⁪⁭⁭‏⁭⁮‏‮‫⁭⁪‎​⁪‮⁫‎⁫‮​⁭‬​‫‫‍⁪​‍⁯‮‮((IEnumerator) enumerator) ? -498900196 : (num1 = -705252263);
        while (true)
        {
          int num2 = -1715069420;
          uint num3;
          ZoomWindow current;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -619209924 ^ 1377728642;
              continue;
            case 1:
              current = enumerator.Current;
              num1 = -676030609;
              continue;
            case 2:
              goto label_5;
            case 3:
              num1 = -498900196;
              continue;
            case 4:
              CaptureMeeting.\u206E‮⁬‏‍​‮⁪‬‌⁫‭⁪‮‏‍⁭⁬⁪‬⁫‏‌‭‎‮‍‏‬‬‮‪‪‍⁯⁮⁮⁬⁯‪‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2232715622U), (object) current);
              num1 = (int) num3 * 1460687105 ^ 1121440406;
              continue;
            case 6:
              num1 = (int) num3 * -891119342 ^ -1039885894;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_10:
          int num1 = -101335134;
          while (true)
          {
            int num2 = -1715069420;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_10;
              case 1:
                CaptureMeeting.\u202E⁪‌⁫‫‬⁫‪‬⁪⁬⁫‍‮‮‫‭‎‌‪‍⁮⁯⁫⁬‎‫⁮⁫‍⁭​⁮‏⁮‭⁯‫⁬⁯‮((IDisposable) enumerator);
                num1 = (int) num3 * 831011993 ^ -1579625198;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      this.MeetingImage = this.Engine.CaptureImage(this.MeetingWindow, Rectangle.Empty, ImageEnums.ImageType.Meeting, (ImageOptions) null);
label_16:
      int num4 = -414234776;
      while (true)
      {
        int num1 = -1715069420;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 10U)
        {
          case 0:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1170263474U));
            num4 = -1072916050;
            continue;
          case 1:
            num4 = (int) num2 * -1307689333 ^ 1718125670;
            continue;
          case 2:
            goto label_18;
          case 3:
            goto label_16;
          case 4:
            this.ReportProgress(CaptureMeeting.\u202D⁮⁯⁮‎‬‬‮‎‌‏⁫‬‬​⁮‍⁪‮‭⁬‎⁮‬‬‏‬⁬‫‭⁫‬⁭‮⁫‫⁮⁯‌⁭‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4133843460U), (object) this.MeetingWindow.ZoomWindowType), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3848973196U));
            num4 = (int) num2 * 2139362855 ^ -1463112097;
            continue;
          case 5:
            this.MeetingImages.Add(this.MeetingImage);
            num4 = (int) num2 * 63731772 ^ -435858622;
            continue;
          case 6:
            int num3 = this.MeetingImage != null ? 1073830797 : (num3 = 2112672272);
            int num5 = (int) num2 * 1877939240;
            num4 = num3 ^ num5;
            continue;
          case 7:
            num4 = (int) num2 * -1149595407 ^ -1248685155;
            continue;
          case 8:
            num4 = (int) num2 * -314673767 ^ -205481395;
            continue;
          case 9:
            num4 = (int) num2 * -1939511599 ^ -1267779801;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_18:;
    }

    private void SetGalleryMode(bool initialSet)
    {
label_1:
      int num1 = -335104133;
      while (true)
      {
        int num2 = -737613191;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            num1 = -532121747;
            continue;
          case 1:
            int num4 = initialSet ? 2094457855 : (num4 = 215675588);
            int num5 = (int) num3 * 811449325;
            num1 = num4 ^ num5;
            continue;
          case 2:
            this.Meeting.SetDisplayMode(DisplayMode.GalleryView);
            num1 = (int) num3 * -78714833 ^ -1146208385;
            continue;
          case 3:
            num1 = (int) num3 * 1937410274 ^ -973202446;
            continue;
          case 4:
            int num6 = !flag ? -1587241837 : (num6 = -1857225931);
            int num7 = (int) num3 * -1715816202;
            num1 = num6 ^ num7;
            continue;
          case 5:
            flag = this.Meeting != null;
            num1 = (int) num3 * -1939252619 ^ 302874846;
            continue;
          case 6:
            goto label_1;
          case 7:
            goto label_3;
          case 8:
            num1 = (int) num3 * 598331754 ^ -144635817;
            continue;
          case 9:
            num1 = (int) num3 * -964850010 ^ -917301621;
            continue;
          case 10:
            this.ScrollLeft();
            num1 = (int) num3 * 2098695842 ^ -1071413195;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    private bool ScrollLeft()
    {
      bool flag1 = false;
label_1:
      int num1 = -1845690685;
      bool flag2;
      while (true)
      {
        int num2 = -376677682;
        uint num3;
        ZoomWindow window;
        bool flag3;
        ZoomEvent zoomEvent;
        DateTime dateTime;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 24U)
        {
          case 0:
            goto label_1;
          case 1:
            flag2 = flag1;
            num1 = -1898557420;
            continue;
          case 2:
            int num4 = flag3 ? 1266086911 : (num4 = 1575350315);
            int num5 = (int) num3 * 313766242;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * 1412515182 ^ 1333941576;
            continue;
          case 4:
            int num6 = flag4 ? -1247282461 : (num6 = -1861757574);
            int num7 = (int) num3 * 2034284397;
            num1 = num6 ^ num7;
            continue;
          case 5:
            num1 = (int) num3 * 1392911245 ^ -619769355;
            continue;
          case 6:
            num1 = -689864458;
            continue;
          case 7:
            num1 = (int) num3 * -1887313028 ^ -247160420;
            continue;
          case 8:
            num1 = -1177133710;
            continue;
          case 10:
            num1 = (int) num3 * 457446289 ^ -1917969235;
            continue;
          case 11:
            dateTime = DateTime.Now.AddMilliseconds((double) this.Engine.Settings.CaptureMeeting_PauseInterval);
            num1 = (int) num3 * -123839952 ^ 2000454566;
            continue;
          case 12:
            flag1 = true;
            num1 = (int) num3 * -121780628 ^ -952638975;
            continue;
          case 13:
            window = this.Engine.GetWindow(ZoomWindowType.GalleryScrollLeft);
            flag3 = window != null;
            num1 = (int) num3 * -417652097 ^ 283945679;
            continue;
          case 14:
            flag1 = false;
            num1 = (int) num3 * -1117956986 ^ -576034591;
            continue;
          case 15:
            num1 = (int) num3 * -1679652573 ^ 654888826;
            continue;
          case 16:
            window.Click(new System.Drawing.Point(1, 1), true, true, 0);
            num1 = (int) num3 * 934683934 ^ -1144781576;
            continue;
          case 17:
            num1 = (int) num3 * -1676724713 ^ -423238905;
            continue;
          case 18:
            this.Engine.PurgeActivityQueue();
            num1 = (int) num3 * 379370524 ^ -1723291467;
            continue;
          case 19:
            num1 = -1792816903;
            continue;
          case 20:
            int num8;
            num1 = num8 = !(dateTime > DateTime.Now) ? -2011528247 : (num8 = -1074542307);
            continue;
          case 21:
            num1 = (int) num3 * -1081869601 ^ 1463054057;
            continue;
          case 22:
            int num9 = zoomEvent.EventType == ZoomEventType.Reorder ? -1446074311 : (num9 = -167940390);
            int num10 = (int) num3 * -1633583233;
            num1 = num9 ^ num10;
            continue;
          case 23:
            flag4 = this.Engine.ActivityQueue.TryDequeue(ref zoomEvent);
            num1 = (int) num3 * 2006429469 ^ 2040384457;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return flag2;
    }

    private void SetGalleryMode()
    {
label_1:
      int num1 = 182495913;
      while (true)
      {
        int num2 = 1208986496;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this.Meeting.SetDisplayMode(DisplayMode.GalleryView);
            CaptureMeeting.\u200F​‫⁬‍‭‌⁪⁯⁬⁪⁬‪‫‭‌⁮‪‪⁯⁪‌⁬⁪‌‏⁬‎⁬​‍⁭⁭‎​‫‌‪‎⁯‮(this.Engine.Settings.CaptureMeeting_PauseInterval);
            num1 = (int) num3 * -936856215 ^ -1580060801;
            continue;
          case 1:
            flag = this.Meeting.DisplayMode != DisplayMode.GalleryView;
            num1 = (int) num3 * -1883946329 ^ 14035490;
            continue;
          case 2:
            num1 = (int) num3 * -554187498 ^ 1548633223;
            continue;
          case 3:
            int num4 = flag ? 611925316 : (num4 = 1207779285);
            int num5 = (int) num3 * 2027619114;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 1788061891 ^ -141746659;
            continue;
          case 6:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private void GalleryScrollRight()
    {
label_1:
      int num1 = -377709066;
      while (true)
      {
        int num2 = -602942253;
        uint num3;
        bool flag1;
        ZoomWindow window;
        ZoomEvent zoomEvent;
        bool flag2;
        DateTime now;
        DateTime dateTime;
        bool flag3;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 29U)
        {
          case 0:
            now = DateTime.Now;
            num1 = (int) num3 * 148773220 ^ 1983361460;
            continue;
          case 1:
            num1 = -542644761;
            continue;
          case 2:
            this.JustScrolled = true;
            num1 = (int) num3 * 1875049117 ^ -7615282;
            continue;
          case 3:
            num1 = (int) num3 * 2053427144 ^ -1395728417;
            continue;
          case 4:
            num1 = -1986936620;
            continue;
          case 5:
            flag1 = true;
            num1 = (int) num3 * -1288934081 ^ -652837242;
            continue;
          case 6:
            int num4 = zoomEvent.EventType == ZoomEventType.Reorder ? -1168354043 : (num4 = -2141443405);
            int num5 = (int) num3 * -1161428164;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = -1822569681;
            continue;
          case 8:
            num1 = (int) num3 * 1674821749 ^ -2071735710;
            continue;
          case 9:
            int num6 = !flag4 ? -137308963 : (num6 = -1495262427);
            int num7 = (int) num3 * 872395974;
            num1 = num6 ^ num7;
            continue;
          case 10:
            num1 = (int) num3 * -185233247 ^ -1555767152;
            continue;
          case 11:
            flag1 = false;
            window = this.Engine.GetWindow(ZoomWindowType.GalleryScrollRight);
            int num8 = window != null ? -16458291 : (num8 = -814130316);
            int num9 = (int) num3 * -1517374408;
            num1 = num8 ^ num9;
            continue;
          case 12:
            int num10 = flag3 ? -1823896699 : (num10 = -2014911083);
            int num11 = (int) num3 * 183459157;
            num1 = num10 ^ num11;
            continue;
          case 13:
            num1 = (int) num3 * 840627477 ^ 803455932;
            continue;
          case 14:
            num1 = (int) num3 * -1477371236 ^ -1516058140;
            continue;
          case 15:
            flag2 = dateTime > DateTime.Now;
            num1 = -1562922851;
            continue;
          case 16:
            int num12 = flag2 ? -308339214 : (num12 = -1718355143);
            int num13 = (int) num3 * 1865963672;
            num1 = num12 ^ num13;
            continue;
          case 17:
            num1 = (int) num3 * 121200062 ^ 1201345328;
            continue;
          case 18:
            flag3 = this.Engine.ActivityQueue.TryDequeue(ref zoomEvent);
            num1 = (int) num3 * -631331345 ^ -462942224;
            continue;
          case 19:
            flag4 = flag1;
            num1 = -1947296158;
            continue;
          case 20:
            num1 = (int) num3 * -1434191695 ^ 441046854;
            continue;
          case 21:
            goto label_1;
          case 22:
            num1 = (int) num3 * 1361045955 ^ -1609366848;
            continue;
          case 23:
            dateTime = now.AddMilliseconds((double) this.Engine.Settings.CaptureMeeting_PauseInterval);
            num1 = (int) num3 * -1917261622 ^ -1778251363;
            continue;
          case 24:
            flag1 = false;
            num1 = (int) num3 * 465027100 ^ -1023198127;
            continue;
          case 25:
            num1 = (int) num3 * -2016793999 ^ 332261494;
            continue;
          case 26:
            window.Click(new System.Drawing.Point(1, 1), true, true, 0);
            num1 = (int) num3 * -385812428 ^ 769296062;
            continue;
          case 27:
            this.Engine.PurgeActivityQueue();
            num1 = (int) num3 * -122788424 ^ 340407764;
            continue;
          case 28:
            goto label_3;
          default:
            goto label_31;
        }
      }
label_31:
      return;
label_3:;
    }

    private void DisplayImageHistoryView()
    {
label_1:
      int num1 = -1455750334;
      while (true)
      {
        int num2 = -1408425878;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            int num4 = !flag ? 325119533 : (num4 = 1546077927);
            int num5 = (int) num3 * 192555362;
            num1 = num4 ^ num5;
            continue;
          case 3:
            this.Engine.DisplayImages(this.MeetingImages);
            num1 = (int) num3 * -2048205419 ^ 569554996;
            continue;
          case 4:
            flag = this.Engine != null;
            num1 = (int) num3 * -1518170119 ^ 1387864651;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 1264597030;
      bool flag;
      while (true)
      {
        int num2 = 333481604;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -415174231 ^ 1508682954;
            continue;
          case 2:
            flag = true;
            num1 = (int) num3 * 1545139435 ^ 366412495;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    static void \u206E‮⁬‏‍​‮⁪‬‌⁫‭⁪‮‏‍⁭⁬⁪‬⁫‏‌‭‎‮‍‏‬‬‮‪‪‍⁯⁮⁮⁬⁯‪‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static bool \u206C‌⁭‪⁪‎‎⁯⁭⁪⁭⁭‏⁭⁮‏‮‫⁭⁪‎​⁪‮⁫‎⁫‮​⁭‬​‫‫‍⁪​‍⁯‮‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u202E⁪‌⁫‫‬⁫‪‬⁪⁬⁫‍‮‮‫‭‎‌‪‍⁮⁯⁫⁬‎‫⁮⁫‍⁭​⁮‏⁮‭⁯‫⁬⁯‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static string \u202D⁮⁯⁮‎‬‬‮‎‌‏⁫‬‬​⁮‍⁪‮‭⁬‎⁮‬‬‏‬⁬‫‭⁫‬⁭‮⁫‫⁮⁯‌⁭‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u200F​‫⁬‍‭‌⁪⁯⁬⁪⁬‪‫‭‌⁮‪‪⁯⁪‌⁬⁪‌‏⁬‎⁬​‍⁭⁭‎​‫‌‪‎⁯‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }
  }
}
