// Decompiled with JetBrains decompiler
// Type: ZoomZoom.InspectVideoWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Images;
using ZoomZoom.Models.Meetings;

namespace ZoomZoom
{
  public class InspectVideoWindow : ActivityBase
  {
    private VideoChatLink chatLink = (VideoChatLink) null;
    private ZoomWindow chatWindow = (ZoomWindow) null;
    private ZoomImage videoImage = (ZoomImage) null;
    private VideoWindowLinkedObjects linkedObjects = new VideoWindowLinkedObjects();
    private ZoomWindow videoWindow;

    public ZoomWindow VideoWindow
    {
      get
      {
label_1:
        int num1 = 619322004;
        ZoomWindow videoWindow;
        while (true)
        {
          int num2 = 1313802595;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1905197127 ^ 1783005114;
              continue;
            case 2:
              goto label_1;
            case 3:
              videoWindow = this.videoWindow;
              num1 = (int) num3 * -603138888 ^ -1041566177;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return videoWindow;
      }
      set
      {
        this.videoWindow = value;
      }
    }

    public VideoChatLink ChatLink
    {
      get
      {
label_1:
        int num1 = 1133027461;
        VideoChatLink chatLink;
        while (true)
        {
          int num2 = 784764612;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              chatLink = this.chatLink;
              num1 = (int) num3 * 803077821 ^ 724558978;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -292105528 ^ -1935436516;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return chatLink;
      }
      set
      {
        this.chatLink = value;
      }
    }

    public VideoWindowLinkedObjects LinkedObjects
    {
      get
      {
        VideoWindowLinkedObjects linkedObjects = this.linkedObjects;
label_1:
        int num1 = -1526996184;
        while (true)
        {
          int num2 = -1582469080;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1334658477 ^ 1977287813;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return linkedObjects;
      }
      set
      {
        this.linkedObjects = value;
      }
    }

    public ZoomWindow ChatWindow
    {
      get
      {
        bool flag1 = this.chatWindow == null;
label_1:
        int num1 = 990824051;
        while (true)
        {
          int num2 = 1922606856;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 808394873 ^ 710510067;
              continue;
            case 3:
              if (flag1)
              {
                num1 = (int) num3 * 1990063325 ^ 1740393189;
                continue;
              }
              goto label_22;
            default:
              goto label_6;
          }
        }
label_6:
        object activityLocker = ActivityBase.activityLocker;
        bool flag2 = false;
        try
        {
          InspectVideoWindow.\u206C​‎⁮‌‪⁮‏‍‍⁯​‪⁫‫⁪⁪⁭​​‌‭‬⁯‬‏‪⁮‎⁪‮‍⁮‍‭⁭‎⁬⁬⁭‮(activityLocker, ref flag2);
label_8:
          int num2 = 2029402354;
          while (true)
          {
            int num3 = 1922606856;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                this.chatWindow = this.Engine.GetWindow(ZoomWindowType.Chat);
                num2 = (int) num4 * -1560786393 ^ 87787557;
                continue;
              case 2:
                num2 = (int) num4 * -1544926643 ^ -1284835383;
                continue;
              case 3:
                goto label_8;
              case 4:
                num2 = (int) num4 * -239787082 ^ 488773335;
                continue;
              default:
                goto label_19;
            }
          }
        }
        finally
        {
          if (flag2)
          {
label_14:
            int num2 = 2084139563;
            while (true)
            {
              int num3 = 1922606856;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_14;
                case 2:
                  num2 = (int) num4 * 1361408204 ^ 1957510913;
                  continue;
                case 3:
                  InspectVideoWindow.\u200F‪‏⁮‌‬‭‮⁬‫‬​⁮‬⁭‎‬‪⁯⁪‌​‬⁬‏‍⁭‭⁯‏‫⁪⁪​‮⁬⁭‎⁪‪‮(activityLocker);
                  num2 = (int) num4 * 901230074 ^ 1574148940;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
label_19:
label_20:
        int num5 = 1789117196;
label_21:
        int num6 = 1922606856;
        uint num7;
        ZoomWindow chatWindow;
        switch ((num7 = (uint) (num5 ^ num6)) % 3U)
        {
          case 0:
            goto label_20;
          case 1:
            break;
          default:
            return chatWindow;
        }
label_22:
        chatWindow = this.chatWindow;
        num5 = 1125956404;
        goto label_21;
      }
      set
      {
label_1:
        int num1 = -1196406541;
        while (true)
        {
          int num2 = -1434742312;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.chatWindow = value;
              num1 = (int) num3 * -1219461474 ^ 1563583981;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 1755310190;
        TraceType traceType;
        while (true)
        {
          int num2 = 1657581153;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * 1773099832 ^ -112171939;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public ZoomImage VideoImage
    {
      get
      {
        return this.videoImage;
      }
      set
      {
        this.videoImage = value;
      }
    }

    public InspectVideoWindow(ZoomWindow videoWindow)
    {
      this.VideoWindow = videoWindow;
    }

    public InspectVideoWindow()
    {
label_1:
      int num1 = 1330342408;
      while (true)
      {
        int num2 = 574142960;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1981585131 ^ 1439677888;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    internal ActivityState ExecuteInspectWindow()
    {
label_1:
      int num1 = -135324759;
      bool flag1;
      while (true)
      {
        int num2 = -2052844907;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this.LinkedObjects.ChatSelectedUserImage = (ZoomImage) null;
            num1 = (int) num3 * 1916339538 ^ -1951103366;
            continue;
          case 1:
            this.LinkedObjects.ZoomWindow = this.VideoWindow;
            num1 = (int) num3 * 1694363191 ^ 413409256;
            continue;
          case 2:
            num1 = (int) num3 * 2133493246 ^ -56593752;
            continue;
          case 4:
            flag1 = false;
            this.Engine.WindowManager.VideoChatLinkActivityInProgress = true;
            this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1938704075U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(98074592U));
            num1 = (int) num3 * 1630645322 ^ 172934685;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.EndTime = DateTime.Now.AddSeconds(60.0);
            num1 = (int) num3 * 1385314253 ^ -1059598134;
            continue;
          case 7:
            this.LinkedObjects.UserName = string.Empty;
            num1 = (int) num3 * -1931480508 ^ -765678166;
            continue;
          case 8:
            this.LinkedObjects.PinnedImage = (ZoomImage) null;
            num1 = (int) num3 * 131287706 ^ 7152120;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      try
      {
label_12:
        int num2 = -1749088360;
        while (true)
        {
          int num3 = -2052844907;
          uint num4;
          bool flag2;
          bool flag3;
          switch ((num4 = (uint) (num2 ^ num3)) % 24U)
          {
            case 0:
              num2 = (int) num4 * 1691006981 ^ 309929429;
              continue;
            case 1:
              int num5 = flag3 ? 277743570 : (num5 = 1862868697);
              int num6 = (int) num4 * -1492623965;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = (int) num4 * -1810842413 ^ -242987012;
              continue;
            case 3:
              num2 = (int) num4 * 1282458417 ^ -176993601;
              continue;
            case 4:
              flag2 = this.Engine.GetWindow(ZoomWindowType.DualVideo) != null;
              num2 = (int) num4 * 719773149 ^ -486598898;
              continue;
            case 6:
              this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2151962338U));
              num2 = (int) num4 * -527912590 ^ 306720275;
              continue;
            case 7:
              this.Engine.WindowManager.VideoChatLinkActivityInProgress = false;
              num2 = -193971322;
              continue;
            case 8:
              this.CaptureDualVideo(this.VideoWindow);
              num2 = (int) num4 * -1209511489 ^ -589862658;
              continue;
            case 9:
              num2 = (int) num4 * -1047762525 ^ -1525644450;
              continue;
            case 10:
              this.InvokePinPrimary(this.VideoWindow);
              num2 = -1796895101;
              continue;
            case 11:
              num2 = (int) num4 * 265472780 ^ 2007221033;
              continue;
            case 12:
              num2 = (int) num4 * 1647548427 ^ 22467047;
              continue;
            case 13:
              this.InvokeChat(this.VideoWindow);
              num2 = (int) num4 * 1274001096 ^ 359770153;
              continue;
            case 14:
              num2 = (int) num4 * -1950787790 ^ -1682032314;
              continue;
            case 15:
              this.CaptureMainVideo(this.VideoWindow);
              num2 = (int) num4 * -482902705 ^ 2005261287;
              continue;
            case 16:
              flag3 = this.ActivityState == ActivityState.InProgress;
              num2 = -293604772;
              continue;
            case 17:
              num2 = (int) num4 * 112405120 ^ 1595938308;
              continue;
            case 18:
              num2 = (int) num4 * -802389173 ^ 715131478;
              continue;
            case 19:
              this.Engine.WindowManager.VideoChatLinkActivityInProgress = true;
              num2 = (int) num4 * 1490170869 ^ -429661544;
              continue;
            case 20:
              goto label_12;
            case 21:
              num2 = (int) num4 * -1319558355 ^ -1151304999;
              continue;
            case 22:
              this.InvokePinSecondary(this.VideoWindow);
              num2 = (int) num4 * -1611868639 ^ 554413123;
              continue;
            case 23:
              int num7 = !flag2 ? 1559148733 : (num7 = 124070425);
              int num8 = (int) num4 * -1478362250;
              num2 = num7 ^ num8;
              continue;
            default:
              goto label_40;
          }
        }
      }
      catch (Exception ex)
      {
label_37:
        int num2 = -1347198859;
        while (true)
        {
          int num3 = -2052844907;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_37;
            case 1:
              this.HandleException(ex);
              num2 = (int) num4 * 1896522793 ^ -1266028941;
              continue;
            default:
              goto label_40;
          }
        }
      }
label_40:
      bool flag4 = flag1;
label_41:
      int num9 = -1300709872;
      ActivityState activityState;
      while (true)
      {
        int num2 = -2052844907;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 6U)
        {
          case 0:
            goto label_41;
          case 1:
            int num4 = !flag4 ? -235252513 : (num4 = -1615490355);
            int num5 = (int) num3 * -13628430;
            num9 = num4 ^ num5;
            continue;
          case 2:
            activityState = this.ActivityState;
            num9 = -2066780578;
            continue;
          case 3:
            num9 = (int) num3 * -1151608480 ^ -1031668376;
            continue;
          case 4:
            num9 = (int) num3 * 1145079371 ^ 2061847123;
            continue;
          default:
            goto label_47;
        }
      }
label_47:
      return activityState;
    }

    private void CaptureMainVideo(ZoomWindow videoWindow)
    {
    }

    private void CaptureChatWindowUserSelection(ZoomWindow window)
    {
      try
      {
        int num1 = 70;
        int height1 = 16;
        int num2 = 50;
label_2:
        int num3 = -36018820;
        Rectangle region;
        while (true)
        {
          int num4 = -1071790745;
          uint num5;
          int num6;
          switch ((num5 = (uint) (num3 ^ num4)) % 4U)
          {
            case 0:
              // ISSUE: explicit reference operation
              // ISSUE: variable of a reference type
              Rectangle& local = @region;
              int x = window.Location.X + num2;
              int y1 = window.Location.Y;
              Size size1 = window.Size;
              int height2 = size1.Height;
              int y2 = y1 + height2 - num1 - height1;
              System.Drawing.Point location = new System.Drawing.Point(x, y2);
              size1 = window.Size;
              Size size2 = new Size(size1.Width - num2 - num6, height1);
              // ISSUE: explicit reference operation
              ^local = new Rectangle(location, size2);
              num3 = (int) num5 * -768326603 ^ -985722130;
              continue;
            case 2:
              goto label_2;
            case 3:
              num6 = 80;
              num3 = (int) num5 * 1050496219 ^ 585821198;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        ZoomImage zoomImage = this.Engine.CaptureImage(window, region, ImageEnums.ImageType.ChatSelector, new ImageOptions()
        {
          DisplayAfterCapture = false,
          DisplayHighlightWindow = false,
          SaveToDisk = true
        });
        object activityLocker = ActivityBase.activityLocker;
        bool flag = false;
        try
        {
          Monitor.Enter(activityLocker, ref flag);
label_8:
          int num4 = -1159464530;
          while (true)
          {
            int num5 = -1071790745;
            uint num6;
            switch ((num6 = (uint) (num4 ^ num5)) % 3U)
            {
              case 0:
                goto label_8;
              case 1:
                this.LinkedObjects.ChatSelectedUserImage = zoomImage;
                num4 = (int) num6 * 227142926 ^ 544213353;
                continue;
              case 2:
                goto label_26;
              default:
                goto label_22;
            }
          }
label_22:
          return;
label_26:;
        }
        finally
        {
          if (flag)
          {
label_12:
            int num4 = -1546253578;
            while (true)
            {
              int num5 = -1071790745;
              uint num6;
              switch ((num6 = (uint) (num4 ^ num5)) % 4U)
              {
                case 1:
                  Monitor.Exit(activityLocker);
                  num4 = (int) num6 * -676687075 ^ 893069636;
                  continue;
                case 2:
                  num4 = (int) num6 * -1370647691 ^ -308958215;
                  continue;
                case 3:
                  goto label_12;
                default:
                  goto label_17;
              }
            }
          }
label_17:;
        }
      }
      catch (Exception ex)
      {
label_20:
        int num1 = -1694567189;
        while (true)
        {
          int num2 = -1071790745;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * 2056070900 ^ -195977167;
              continue;
            case 1:
              num1 = (int) num3 * -335814306 ^ -488955157;
              continue;
            case 2:
              goto label_18;
            case 3:
              num1 = (int) num3 * 18871224 ^ 48255190;
              continue;
            case 4:
              goto label_20;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_18:;
      }
    }

    private void CaptureDualVideo(ZoomWindow videoWindow)
    {
      try
      {
label_2:
        int num1 = -453232706;
        while (true)
        {
          int num2 = -828245355;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_13;
            case 2:
              num1 = (int) num3 * -1448640787 ^ 2062733770;
              continue;
            case 3:
              this.VideoImage = this.Engine.CaptureImage(videoWindow, Rectangle.Empty, ImageEnums.ImageType.Video, new ImageOptions()
              {
                DisplayAfterCapture = false,
                DisplayHighlightWindow = false,
                SaveToDisk = true
              });
              num1 = (int) num3 * 446757143 ^ 273554022;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_13:;
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -1501168663;
        while (true)
        {
          int num2 = -828245355;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              InspectVideoWindow.\u206D⁬⁮⁭‎⁯‫‫‫‬‬⁯‏‏⁫⁫‫‮‎‍‪‮‪‏⁫‪‮‫‎‌‌⁫⁭⁪⁯‍⁫⁫‎‭‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 1858030999 ^ 1070211413;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_7:;
      }
    }

    private void ZoomZoom_OnChatReceived(object sender, EventArgs e)
    {
label_1:
      int num1 = 2024030740;
      while (true)
      {
        int num2 = 2135755713;
        uint num3;
        bool flag;
        ChatEventArgs chatEventArgs;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            if (this.ChatLink == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1539297443 ^ -1797470846;
            continue;
          case 1:
            chatEventArgs = e as ChatEventArgs;
            num1 = (int) num3 * 1232109539 ^ -1961375280;
            continue;
          case 2:
            num1 = (int) num3 * 1927152858 ^ 891300410;
            continue;
          case 3:
            num4 = InspectVideoWindow.\u200E​⁫‍⁯‍‮‪⁭‎‮⁯⁪‍⁫‍‬‌⁫‭‍⁭‎‏⁭‫‫⁯‌⁯⁫‪⁫⁬‎‫‬‎‬‭‮(this.ChatLink.TrackingMessage, chatEventArgs.Chat.ChatContent) ? 1 : 0;
            break;
          case 4:
            num1 = 198635708;
            continue;
          case 5:
            goto label_3;
          case 6:
            flag = chatEventArgs != null;
            num1 = (int) num3 * -904269425 ^ 7688437;
            continue;
          case 7:
            this.ChatLink.CompleteLink(chatEventArgs.Chat);
            num1 = (int) num3 * -231066439 ^ -186026164;
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num3 * 1755978787 ^ -296439182;
            continue;
          case 10:
            int num5 = !flag ? 39311548 : (num5 = 1165057528);
            int num6 = (int) num3 * -1632396288;
            num1 = num5 ^ num6;
            continue;
          case 11:
            num1 = (int) num3 * -1745209467 ^ -273756150;
            continue;
          default:
            goto label_17;
        }
        int num7;
        num1 = num7 = num4 != 0 ? 62787318 : (num7 = 1962744225);
      }
label_17:
      return;
label_3:;
    }

    public void InvokeChat(ZoomWindow videoWindow)
    {
      System.Drawing.Point pt;
      NativeMethods.GetCursorPos(out pt);
      try
      {
        ZoomWindow window = this.Engine.GetWindow(ZoomWindowType.Meeting);
label_2:
        int num1 = 579190182;
        while (true)
        {
          int num2 = 292090234;
          uint num3;
          int X;
          int Y;
          bool flag1;
          bool flag2;
          System.Drawing.Point location;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 40U)
          {
            case 0:
              Thread.Sleep(40);
              X += 25;
              Y += 25;
              User32.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
              Thread.Sleep(40);
              num1 = (int) num3 * -651490940 ^ 2120707211;
              continue;
            case 1:
              num1 = (int) num3 * 690111603 ^ 1022403738;
              continue;
            case 2:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * -1854424969 ^ -651854919;
              continue;
            case 3:
              num1 = (int) num3 * 788253004 ^ -1432675015;
              continue;
            case 4:
              if (videoWindow != null)
              {
                num1 = (int) num3 * 1992926930 ^ 1456460649;
                continue;
              }
              break;
            case 5:
              Thread.Sleep(100);
              num1 = 1384078123;
              continue;
            case 6:
              this.ChatWindow = this.Engine.GetWindow(ZoomWindowType.Chat);
              num1 = (int) num3 * 1993408739 ^ 823174360;
              continue;
            case 7:
              flag1 = WindowHelper.GetWindowRectangle(videoWindow.Handle).Width <= window.Size.Width - 20;
              num1 = (int) num3 * 964439163 ^ 2018866918;
              continue;
            case 8:
              num1 = 1191011837;
              continue;
            case 9:
              num1 = (int) num3 * 2034271719 ^ -396183155;
              continue;
            case 10:
              Y = location.Y + 25;
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 624359367 ^ -1837689768;
              continue;
            case 11:
              num1 = (int) num3 * 1997158533 ^ -870757339;
              continue;
            case 12:
              num1 = (int) num3 * 448996929 ^ 1507881747;
              continue;
            case 13:
              num1 = (int) num3 * 1191687776 ^ 1877697412;
              continue;
            case 14:
              X = location.X + 25;
              num1 = (int) num3 * -1728762508 ^ -2105922619;
              continue;
            case 15:
              this.ChatWindow.RefreshLocation();
              this.CaptureChatWindowUserSelection(this.ChatWindow);
              num1 = (int) num3 * 76288114 ^ 1568846082;
              continue;
            case 16:
              goto label_2;
            case 17:
              num1 = (int) num3 * 116130777 ^ -2125787095;
              continue;
            case 18:
              num1 = (int) num3 * -184242430 ^ 1280079066;
              continue;
            case 19:
              if (videoWindow.ZoomWindowType == ZoomWindowType.Video)
              {
                num1 = (int) num3 * 9704398 ^ 540421425;
                continue;
              }
              break;
            case 20:
              num1 = (int) num3 * 1653728454 ^ -1517917475;
              continue;
            case 21:
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * 1667285740 ^ -960655532;
              continue;
            case 22:
              num1 = (int) num3 * -1235845510 ^ 229552137;
              continue;
            case 23:
              num1 = 831180489;
              continue;
            case 24:
              int num5;
              num1 = num5 = this.ChatWindow != null ? 488797878 : (num5 = 1512890346);
              continue;
            case 25:
              int num6 = flag1 ? 1536857253 : (num6 = 361384173);
              int num7 = (int) num3 * 196253562;
              num1 = num6 ^ num7;
              continue;
            case 26:
              int num8 = this.ChatWindow != null ? -280801540 : (num8 = -526011751);
              int num9 = (int) num3 * 1665915927;
              num1 = num8 ^ num9;
              continue;
            case 27:
              this.Engine.GetWindow(ZoomWindowType.Chat);
              num1 = (int) num3 * 2061819281 ^ -2008557813;
              continue;
            case 28:
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * 2043611686 ^ -1426814017;
              continue;
            case 29:
              location = videoWindow.Location;
              num1 = (int) num3 * 532881331 ^ -2018892509;
              continue;
            case 30:
              int num10 = flag2 ? 956488925 : (num10 = 1743666349);
              int num11 = (int) num3 * 829864750;
              num1 = num10 ^ num11;
              continue;
            case 31:
              location = videoWindow.Location;
              num1 = (int) num3 * -1742600524 ^ 289074364;
              continue;
            case 32:
              num1 = (int) num3 * -1423555496 ^ -681603151;
              continue;
            case 33:
              num4 = window != null ? 1 : 0;
              goto label_44;
            case 34:
              User32.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -498159294 ^ -1725331537;
              continue;
            case 36:
              num1 = (int) num3 * 737271063 ^ 963412761;
              continue;
            case 37:
              num1 = (int) num3 * -531132886 ^ -1563797418;
              continue;
            case 38:
              Thread.Sleep(40);
              num1 = (int) num3 * 710004815 ^ -1592840510;
              continue;
            case 39:
              CoreObject.log.Debug((object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2251789693U));
              num1 = (int) num3 * -1853409657 ^ -1822767297;
              continue;
            default:
              goto label_50;
          }
          num4 = 0;
label_44:
          flag2 = num4 != 0;
          num1 = 1470188516;
        }
      }
      catch (Exception ex)
      {
label_47:
        int num1 = 764108111;
        while (true)
        {
          int num2 = 292090234;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_47;
            case 2:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * 873891215 ^ -1801347747;
              continue;
            default:
              goto label_50;
          }
        }
      }
label_50:
      User32.SetCursorPos(pt.X, pt.Y);
    }

    public void InvokePinSecondary(ZoomWindow videoWindow)
    {
      System.Drawing.Point pt;
      NativeMethods.GetCursorPos(out pt);
      try
      {
        ZoomWindow window = this.Engine.GetWindow(ZoomWindowType.Chat);
label_2:
        int num1 = 852761538;
        while (true)
        {
          int num2 = 1182747207;
          uint num3;
          System.Drawing.Point location;
          int Y;
          int X;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 28U)
          {
            case 0:
              location = videoWindow.Location;
              X = location.X + 25;
              num1 = (int) num3 * -2121263103 ^ -1148926320;
              continue;
            case 1:
              num1 = (int) num3 * 1611826904 ^ -1828122197;
              continue;
            case 2:
              Thread.Sleep(40);
              User32.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -628008996 ^ -1800821263;
              continue;
            case 3:
              videoWindow.Activate();
              num1 = (int) num3 * -1254129449 ^ -1234907102;
              continue;
            case 4:
              this.ChatWindow.RefreshLocation();
              num1 = (int) num3 * 1123667962 ^ 905065722;
              continue;
            case 5:
              int num5 = window != null ? -2015773700 : (num5 = -903388651);
              int num6 = (int) num3 * 81985107;
              num1 = num5 ^ num6;
              continue;
            case 6:
              flag = this.ChatWindow != null;
              num1 = 239096854;
              continue;
            case 7:
              num1 = (int) num3 * 704956768 ^ -2001367995;
              continue;
            case 8:
              X += 25;
              num1 = (int) num3 * -1295236251 ^ 1128024135;
              continue;
            case 9:
              num1 = (int) num3 * -2042178567 ^ -236419032;
              continue;
            case 10:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * -1539371228 ^ 1698022666;
              continue;
            case 12:
              num1 = (int) num3 * -934150689 ^ -1359300812;
              continue;
            case 13:
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -41746425 ^ 1592068027;
              continue;
            case 14:
              Thread.Sleep(40);
              num1 = (int) num3 * 1533502199 ^ 1120703941;
              continue;
            case 15:
              User32.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * -261026722 ^ -1319413;
              continue;
            case 16:
              this.ChatWindow.RefreshLocation();
              num1 = (int) num3 * 1276537827 ^ -1582613914;
              continue;
            case 17:
              if (videoWindow != null)
              {
                num1 = 1287951916;
                continue;
              }
              num4 = 0;
              break;
            case 18:
              Thread.Sleep(40);
              num1 = (int) num3 * 2128092117 ^ 2095386947;
              continue;
            case 19:
              location = videoWindow.Location;
              num1 = (int) num3 * 71530645 ^ 280482542;
              continue;
            case 20:
              Y += 75;
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 954740937 ^ -1114867300;
              continue;
            case 21:
              int num7 = flag ? 111537898 : (num7 = 380327660);
              int num8 = (int) num3 * -743406988;
              num1 = num7 ^ num8;
              continue;
            case 22:
              Y = location.Y + 25;
              num1 = (int) num3 * 2071555398 ^ -858232312;
              continue;
            case 23:
              User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * -1179473309 ^ -959163452;
              continue;
            case 24:
              goto label_2;
            case 25:
              num1 = (int) num3 * -1076564884 ^ -152556541;
              continue;
            case 26:
              num1 = (int) num3 * -1159474086 ^ 624966294;
              continue;
            case 27:
              num4 = videoWindow.ZoomWindowType == ZoomWindowType.Video ? 1 : 0;
              break;
            default:
              goto label_40;
          }
          int num9;
          num1 = num9 = num4 != 0 ? 516496712 : (num9 = 1011398109);
        }
      }
      catch (Exception ex)
      {
label_34:
        int num1 = 662731054;
        while (true)
        {
          int num2 = 1182747207;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 822949519 ^ -1882010710;
              continue;
            case 1:
              num1 = (int) num3 * 752335661 ^ -1214764545;
              continue;
            case 2:
              goto label_34;
            case 4:
              num1 = (int) num3 * -624618766 ^ -1885891311;
              continue;
            case 5:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * -2112761952 ^ 978517629;
              continue;
            default:
              goto label_40;
          }
        }
      }
label_40:
      User32.SetCursorPos(pt.X, pt.Y);
    }

    public void InvokePinPrimary(ZoomWindow videoWindow)
    {
      System.Drawing.Point pt;
      NativeMethods.GetCursorPos(out pt);
      try
      {
label_2:
        int num1 = 530591176;
        while (true)
        {
          int num2 = 1181189599;
          uint num3;
          int X;
          int Y;
          bool flag;
          System.Drawing.Point location;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 25U)
          {
            case 0:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * -989042558 ^ -1316912870;
              continue;
            case 1:
              X += 25;
              Y += 50;
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * -1429274512 ^ -1448908674;
              continue;
            case 2:
              num1 = (int) num3 * -1313532975 ^ -2130134556;
              continue;
            case 3:
              num1 = (int) num3 * 1058406315 ^ -1600115827;
              continue;
            case 4:
              User32.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * 1904707593 ^ -530057020;
              continue;
            case 5:
              num1 = (int) num3 * 499705376 ^ -575981117;
              continue;
            case 6:
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -1224504191 ^ 221202597;
              continue;
            case 7:
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              Thread.Sleep(40);
              num1 = (int) num3 * 1275365091 ^ -1892484342;
              continue;
            case 8:
              videoWindow.Activate();
              num1 = (int) num3 * -720478867 ^ 725382454;
              continue;
            case 9:
              Thread.Sleep(40);
              num1 = (int) num3 * -99380055 ^ 419462791;
              continue;
            case 10:
              this.ChatWindow.RefreshLocation();
              num1 = (int) num3 * -1322344785 ^ -1694194991;
              continue;
            case 11:
              num1 = (int) num3 * 1193521374 ^ 938480488;
              continue;
            case 12:
              location = videoWindow.Location;
              X = location.X + 25;
              num1 = (int) num3 * -1516130386 ^ 1629860191;
              continue;
            case 13:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * -317799676 ^ 1500944219;
              continue;
            case 14:
              Y = location.Y + 25;
              num1 = (int) num3 * -589074904 ^ 877926900;
              continue;
            case 15:
              num1 = (int) num3 * -1950798741 ^ 1566039350;
              continue;
            case 16:
              User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * 727187855 ^ -887770050;
              continue;
            case 17:
              int num5 = !flag ? -487786813 : (num5 = -2065024376);
              int num6 = (int) num3 * 1359336324;
              num1 = num5 ^ num6;
              continue;
            case 18:
              Thread.Sleep(40);
              num1 = (int) num3 * -816898359 ^ 1995886632;
              continue;
            case 19:
              if (videoWindow != null)
              {
                num1 = (int) num3 * -537745973 ^ -7009045;
                continue;
              }
              num4 = 0;
              break;
            case 20:
              goto label_2;
            case 21:
              location = videoWindow.Location;
              num1 = (int) num3 * 1840666314 ^ -546009427;
              continue;
            case 22:
              flag = this.ChatWindow != null;
              num1 = 700674742;
              continue;
            case 24:
              num4 = videoWindow.ZoomWindowType == ZoomWindowType.Video ? 1 : 0;
              break;
            default:
              goto label_35;
          }
          int num7;
          num1 = num7 = num4 != 0 ? 1708007698 : (num7 = 641595808);
        }
      }
      catch (Exception ex)
      {
label_31:
        int num1 = 52973725;
        while (true)
        {
          int num2 = 1181189599;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1307596059 ^ 1048566174;
              continue;
            case 2:
              CoreObject.log.Error((object) ex);
              num1 = (int) num3 * -1748264327 ^ -261104540;
              continue;
            case 3:
              goto label_31;
            default:
              goto label_35;
          }
        }
      }
label_35:
      User32.SetCursorPos(pt.X, pt.Y);
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = -1292057828;
      while (true)
      {
        int num2 = -1490406330;
        uint num3;
        bool flag1;
        MeetingVideo video;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 26U)
        {
          case 0:
            num1 = (int) num3 * 12121479 ^ -271403734;
            continue;
          case 1:
            num1 = (int) num3 * 1228464004 ^ -278847783;
            continue;
          case 2:
            num1 = (int) num3 * -1199172533 ^ 1531098569;
            continue;
          case 3:
            // ISSUE: method pointer
            video = (MeetingVideo) Enumerable.FirstOrDefault<MeetingVideo>((IEnumerable<M0>) this.Engine.ActiveMeeting.MeetingVideos, (Func<M0, bool>) new Func<MeetingVideo, bool>((object) this, __methodptr(\u003CExecuteLogic\u003Eb__32_1)));
            num1 = (int) num3 * 1229655128 ^ -1345409021;
            continue;
          case 4:
            num1 = (int) num3 * 314314263 ^ -2070060289;
            continue;
          case 5:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2422477094U));
            num1 = (int) num3 * 121162739 ^ -1767481923;
            continue;
          case 6:
            goto label_3;
          case 7:
            int num4 = (int) this.ExecuteInspectWindow();
            num1 = (int) num3 * -2139457630 ^ 1784234794;
            continue;
          case 8:
            num1 = (int) num3 * 563966531 ^ -2097463874;
            continue;
          case 9:
            this.Engine.ActiveMeeting.SetMeetingVideoStarted(video);
            this.VideoWindow = video.VideoWindow;
            num1 = (int) num3 * 1883298093 ^ -652057409;
            continue;
          case 10:
            num1 = (int) num3 * 600388724 ^ 1320219669;
            continue;
          case 11:
            num1 = (int) num3 * -882885830 ^ 1986318844;
            continue;
          case 12:
            video = (MeetingVideo) null;
            num1 = (int) num3 * -503677830 ^ -1980030894;
            continue;
          case 13:
            num1 = (int) num3 * -2112419700 ^ -1956689300;
            continue;
          case 14:
            this.ChatLink = video.ChatLink;
            num1 = (int) num3 * -1456368233 ^ -1443576766;
            continue;
          case 15:
            goto label_1;
          case 16:
            num1 = -1949907751;
            continue;
          case 17:
            num1 = (int) num3 * 167430548 ^ 382981537;
            continue;
          case 18:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            video = (MeetingVideo) Enumerable.FirstOrDefault<MeetingVideo>((IEnumerable<M0>) this.Engine.ActiveMeeting.MeetingVideos, (Func<M0, bool>) (InspectVideoWindow.\u003C\u003Ec.\u003C\u003E9__32_0 ?? (InspectVideoWindow.\u003C\u003Ec.\u003C\u003E9__32_0 = new Func<MeetingVideo, bool>((object) InspectVideoWindow.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CExecuteLogic\u003Eb__32_0)))));
            num1 = -246675383;
            continue;
          case 19:
            int num5;
            num1 = num5 = video == null ? -612436505 : (num5 = -54772331);
            continue;
          case 20:
            int num6 = flag1 ? 553627501 : (num6 = 1415391100);
            int num7 = (int) num3 * -1699066256;
            num1 = num6 ^ num7;
            continue;
          case 21:
            num1 = (int) num3 * 70368935 ^ 1005842117;
            continue;
          case 22:
            int num8 = !flag2 ? 589887567 : (num8 = 293649999);
            int num9 = (int) num3 * 984807511;
            num1 = num8 ^ num9;
            continue;
          case 23:
            num1 = -1749872119;
            continue;
          case 24:
            flag1 = this.VideoWindow == null;
            num1 = (int) num3 * -2067986921 ^ 1531793790;
            continue;
          case 25:
            flag2 = this.videoWindow != null;
            num1 = -1068243022;
            continue;
          default:
            goto label_28;
        }
      }
label_28:
      return;
label_3:;
    }

    internal override bool Valid()
    {
      throw InspectVideoWindow.\u200C⁭‪‮⁮‪⁪⁫⁪‪‎⁬‎‫‍‮‭⁮⁮‏⁯‍‪‬‌⁮‮⁪⁪‪‏​‍‍‌⁭⁫‍‌‫‮();
    }

    static void \u206C​‎⁮‌‪⁮‏‍‍⁯​‪⁫‫⁪⁪⁭​​‌‭‬⁯‬‏‪⁮‎⁪‮‍⁮‍‭⁭‎⁬⁬⁭‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200F‪‏⁮‌‬‭‮⁬‫‬​⁮‬⁭‎‬‪⁯⁪‌​‬⁬‏‍⁭‭⁯‏‫⁪⁪​‮⁬⁭‎⁪‪‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static void \u206D⁬⁮⁭‎⁯‫‫‫‬‬⁯‏‏⁫⁫‫‮‎‍‪‮‪‏⁫‪‮‫‎‌‌⁫⁭⁪⁯‍⁫⁫‎‭‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static bool \u200E​⁫‍⁯‍‮‪⁭‎‮⁯⁪‍⁫‍‬‌⁫‭‍⁭‎‏⁭‫‫⁯‌⁯⁫‪⁫⁬‎‫‬‎‬‭‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static NotImplementedException \u200C⁭‪‮⁮‪⁪⁫⁪‪‎⁬‎‫‍‮‭⁮⁮‏⁯‍‪‬‌⁮‮⁪⁪‪‏​‍‍‌⁭⁫‍‌‫‮()
    {
      return new NotImplementedException();
    }
  }
}
