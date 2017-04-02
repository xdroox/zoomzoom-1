// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WindowManager
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoomZoom.Models.Activities;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Images;
using ZoomZoom.Models.Meetings;
using ZoomZoom.Models.Windows;

namespace ZoomZoom
{
  public class WindowManager : ManagerBase
  {
    private static WindowManager instance = (WindowManager) null;
    private static readonly object windowLock = WindowManager.\u206E‫⁯⁯⁫⁪⁮⁭‎​‍​⁮‍‍‍‎⁪‫‫⁫‌‌​‍‭‫‫‭⁭⁬‫⁫‭⁯⁬⁬‏⁭⁪‮();
    private SharedData sharedData = (SharedData) null;
    private IntPtr mainHandle = IntPtr.Zero;
    private bool mainHandleLoaded = false;
    private DateTime lastWindowHighlighted = DateTime.MinValue;
    private System.Drawing.Point lastClickPosition = System.Drawing.Point.Empty;
    private DateTime lastVideoSpotlight = DateTime.MinValue;
    private volatile ZoomWindow lastWindowSpotlighted = (ZoomWindow) null;
    private List<IntPtr> movementHandles = new List<IntPtr>();
    private List<IntPtr> videoHighlights = new List<IntPtr>();
    private List<IntPtr> windowsImaged = new List<IntPtr>();
    private DateTime windowLastImaged = DateTime.MinValue;
    private static bool videoChatLinkingInitiated;
    private ZoomWindow lastClickWindow;
    private DateTime lastClickTime;
    private static List<UnmappedWindowClick> unmappedWindowClicks;
    private static Dictionary<IntPtr, HighlightInfo> activeHighlights;
    private static Dictionary<IntPtr, VideoChatLink> videoChatLinks;
    private static int videoChatLinksCreated;
    private static volatile bool videoChatLinkActivityInProgress;
    private static CancellationToken token;
    private static HoldDetector holdDetector;
    private static DateTime manyCamBroadLastAttempt;

    public Thread Thread { get; set; }

    public static WindowManager Instance
    {
      get
      {
label_1:
        int num1 = -667284034;
        while (true)
        {
          int num2 = -1083948757;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              if (WindowManager.instance == null)
              {
                num1 = (int) num3 * 219569368 ^ -147339404;
                continue;
              }
              goto label_25;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -2075938530 ^ -1446371655;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        object windowLock = WindowManager.windowLock;
        bool flag1 = false;
        try
        {
          WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag1);
label_8:
          int num2 = -746300507;
          while (true)
          {
            int num3 = -1083948757;
            uint num4;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 0:
                goto label_8;
              case 1:
                num2 = -98831458;
                continue;
              case 2:
                num2 = (int) num4 * 270817094 ^ -1608774098;
                continue;
              case 3:
                num2 = (int) num4 * 1581086294 ^ -1921145563;
                continue;
              case 4:
                WindowManager.instance = new WindowManager();
                num2 = (int) num4 * 662350619 ^ -1300231627;
                continue;
              case 6:
                flag2 = WindowManager.instance == null;
                num2 = (int) num4 * 1572526830 ^ 1410623608;
                continue;
              case 7:
                int num5 = !flag2 ? 135805609 : (num5 = 463786867);
                int num6 = (int) num4 * 1197174237;
                num2 = num5 ^ num6;
                continue;
              default:
                goto label_22;
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_17:
            int num2 = -1804613815;
            while (true)
            {
              int num3 = -1083948757;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_17;
                case 1:
                  num2 = (int) num4 * 72284977 ^ -153178667;
                  continue;
                case 2:
                  WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                  num2 = (int) num4 * 444055553 ^ -241254132;
                  continue;
                default:
                  goto label_21;
              }
            }
          }
label_21:;
        }
label_22:
label_23:
        int num7 = -221411480;
label_24:
        while (true)
        {
          int num2 = -1083948757;
          uint num3;
          switch ((num3 = (uint) (num7 ^ num2)) % 4U)
          {
            case 0:
              goto label_23;
            case 1:
              num7 = (int) num3 * -452065492 ^ -397988775;
              continue;
            case 3:
              goto label_25;
            default:
              goto label_27;
          }
        }
label_27:
        WindowManager instance;
        return instance;
label_25:
        instance = WindowManager.instance;
        num7 = -895330842;
        goto label_24;
      }
    }

    public object WindowLock
    {
      get
      {
label_1:
        int num1 = 854668041;
        object windowLock;
        while (true)
        {
          int num2 = 835066310;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              windowLock = WindowManager.windowLock;
              num1 = (int) num3 * -307257626 ^ -274110464;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowLock;
      }
    }

    public DateTime LastWindowHighlighted
    {
      get
      {
        DateTime windowHighlighted = this.lastWindowHighlighted;
label_1:
        int num1 = -1825585882;
        while (true)
        {
          int num2 = -261147550;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 714631516 ^ 175769051;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return windowHighlighted;
      }
      set
      {
        this.lastWindowHighlighted = value;
      }
    }

    public System.Drawing.Point LastClickPosition
    {
      get
      {
label_1:
        int num1 = -2009919044;
        System.Drawing.Point lastClickPosition;
        while (true)
        {
          int num2 = -413493335;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1163915629 ^ -352640294;
              continue;
            case 1:
              lastClickPosition = this.lastClickPosition;
              num1 = (int) num3 * -453800220 ^ 1261483361;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return lastClickPosition;
      }
      set
      {
label_1:
        int num1 = -1566331300;
        while (true)
        {
          int num2 = -1292770087;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.lastClickPosition = value;
              num1 = (int) num3 * -136552224 ^ 1751846392;
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

    public static Dictionary<IntPtr, HighlightInfo> ActiveHighlights
    {
      get
      {
label_1:
        int num1 = 1872173881;
        Dictionary<IntPtr, HighlightInfo> activeHighlights;
        while (true)
        {
          int num2 = 1383296724;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              activeHighlights = WindowManager.activeHighlights;
              num1 = (int) num3 * -312736251 ^ 919719847;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeHighlights;
      }
      set
      {
        WindowManager.activeHighlights = value;
      }
    }

    public static bool VideoChatLinkingInitiated
    {
      get
      {
label_1:
        int num1 = -882738840;
        bool linkingInitiated;
        while (true)
        {
          int num2 = -804825405;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1379785184 ^ 1273074442;
              continue;
            case 3:
              linkingInitiated = WindowManager.videoChatLinkingInitiated;
              num1 = (int) num3 * -1851202681 ^ -1661571680;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return linkingInitiated;
      }
      set
      {
label_1:
        int num1 = 552614557;
        while (true)
        {
          int num2 = 739322054;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              WindowManager.videoChatLinkingInitiated = value;
              num1 = (int) num3 * -1000792366 ^ -1668551727;
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

    public static int VideoChatLinksCreated
    {
      get
      {
        int chatLinksCreated = WindowManager.videoChatLinksCreated;
label_1:
        int num1 = 1329483845;
        while (true)
        {
          int num2 = 385275325;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1904923703 ^ 742942164;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return chatLinksCreated;
      }
      set
      {
        WindowManager.videoChatLinksCreated = value;
      }
    }

    public bool VideoChatLinkActivityInProgress
    {
      get
      {
        return WindowManager.videoChatLinkActivityInProgress;
      }
      set
      {
label_1:
        int num1 = 1705849456;
        object windowLock;
        while (true)
        {
          int num2 = 1702842878;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              windowLock = WindowManager.windowLock;
              num1 = (int) num3 * 1237024037 ^ 1035704817;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
          WindowManager.videoChatLinkActivityInProgress = value;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num2 = 680596908;
            while (true)
            {
              int num3 = 1702842878;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_7;
                case 1:
                  num2 = (int) num4 * -1936805808 ^ -175790183;
                  continue;
                case 2:
                  WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                  num2 = (int) num4 * -541332777 ^ -1428403155;
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

    public DateTime LastVideoWindowInspectionTime
    {
      get
      {
        DateTime lastVideoSpotlight = this.lastVideoSpotlight;
label_1:
        int num1 = 1916666692;
        while (true)
        {
          int num2 = 318337802;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -672551456 ^ 1131151534;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return lastVideoSpotlight;
      }
      set
      {
label_1:
        int num1 = 68420469;
        while (true)
        {
          int num2 = 80425067;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.lastVideoSpotlight = value;
              num1 = (int) num3 * -814094401 ^ 1055638779;
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

    public ZoomWindow LastWindowSpotlighted
    {
      get
      {
label_1:
        int num1 = -428820275;
        ZoomWindow windowSpotlighted;
        while (true)
        {
          int num2 = -59332849;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              windowSpotlighted = this.lastWindowSpotlighted;
              num1 = (int) num3 * -1034500077 ^ -1958602848;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowSpotlighted;
      }
      set
      {
        this.lastWindowSpotlighted = value;
      }
    }

    internal static HoldDetector HoldDetector
    {
      get
      {
label_1:
        int num1 = -908350227;
        HoldDetector holdDetector;
        while (true)
        {
          int num2 = -252918760;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              holdDetector = WindowManager.holdDetector;
              num1 = (int) num3 * 641076464 ^ 1712679991;
              continue;
            case 3:
              num1 = (int) num3 * -1120829253 ^ -954042917;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return holdDetector;
      }
      set
      {
        WindowManager.holdDetector = value;
      }
    }

    public event EventHandler OnWindowStateChange
    {
      add
      {
        EventHandler eventHandler1 = this.OnWindowStateChange;
label_1:
        int num1 = 57804752;
        while (true)
        {
          int num2 = 1578239363;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler2 = (EventHandler) WindowManager.\u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 678155266 ^ -1434418630;
              continue;
            case 1:
              goto label_3;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowStateChange, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? 1888998606 : (num4 = 1807279326);
              int num5 = (int) num3 * 667903162;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_1;
            case 4:
              comparand = eventHandler1;
              num1 = 447786694;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler = this.OnWindowStateChange;
label_1:
        int num1 = -1113278475;
        while (true)
        {
          int num2 = -1588910005;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              EventHandler comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowStateChange, (EventHandler) WindowManager.\u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮((Delegate) comparand, (Delegate) value), comparand);
              int num4;
              num1 = num4 = eventHandler != comparand ? -1113278475 : (num4 = -398930359);
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

    public event EventHandler OnWindowCreated
    {
      add
      {
        EventHandler eventHandler = this.OnWindowCreated;
label_1:
        int num1 = 80199861;
        while (true)
        {
          int num2 = 1248462670;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              EventHandler comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowCreated, (EventHandler) WindowManager.\u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮((Delegate) comparand, (Delegate) value), comparand);
              int num4;
              num1 = num4 = eventHandler == comparand ? 1055341764 : (num4 = 80199861);
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnWindowCreated;
label_1:
        int num1 = -1109273323;
        while (true)
        {
          int num2 = -224181180;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) WindowManager.\u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮((Delegate) comparand, (Delegate) value);
              num1 = -47948074;
              continue;
            case 2:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowCreated, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? -820617989 : (num4 = -1558645783);
              int num5 = (int) num3 * 2040237454;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public event EventHandler OnWindowDestroyed
    {
      add
      {
        EventHandler eventHandler = this.OnWindowDestroyed;
label_1:
        int num1 = -597494234;
        while (true)
        {
          int num2 = -83111279;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = eventHandler == comparand ? -1068697485 : (num4 = -832121838);
              int num5 = (int) num3 * 802252717;
              num1 = num4 ^ num5;
              continue;
            case 2:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowDestroyed, (EventHandler) WindowManager.\u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -880303076 ^ 2061902813;
              continue;
            case 3:
              comparand = eventHandler;
              num1 = -1597670097;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnWindowDestroyed;
label_1:
        int num1 = 1599245748;
        while (true)
        {
          int num2 = 642585854;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              eventHandler2 = (EventHandler) WindowManager.\u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1934367729 ^ 623649471;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowDestroyed, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? -563863575 : (num4 = -1742837330);
              int num5 = (int) num3 * -1474659210;
              num1 = num4 ^ num5;
              continue;
            case 4:
              comparand = eventHandler1;
              num1 = 497767816;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnWindowMoved
    {
      add
      {
        EventHandler eventHandler = this.OnWindowMoved;
label_1:
        int num1 = 1227226929;
        while (true)
        {
          int num2 = 1985592080;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              int num4 = eventHandler != comparand ? 2090834601 : (num4 = 1536641086);
              int num5 = (int) num3 * 554587797;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowMoved, (EventHandler) WindowManager.\u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = 1631377960;
              continue;
            case 2:
              goto label_3;
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
      remove
      {
        EventHandler eventHandler = this.OnWindowMoved;
label_1:
        int num1 = -2029533381;
        while (true)
        {
          int num2 = -275015144;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowMoved, (EventHandler) WindowManager.\u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -195770113 ^ -2114715173;
              continue;
            case 1:
              int num4 = eventHandler != comparand ? 744143484 : (num4 = 1499033825);
              int num5 = (int) num3 * -1712872147;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              comparand = eventHandler;
              num1 = -2012077288;
              continue;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnWindowHighlightStart
    {
      add
      {
        EventHandler eventHandler = this.OnWindowHighlightStart;
label_1:
        int num1 = 625331829;
        while (true)
        {
          int num2 = 602340540;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightStart, (EventHandler) WindowManager.\u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = 2087377751;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = eventHandler == comparand ? -757350938 : (num4 = -677332363);
              int num5 = (int) num3 * 1332173824;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnWindowHighlightStart;
label_1:
        int num1 = -1875698170;
        while (true)
        {
          int num2 = -970565453;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              eventHandler2 = (EventHandler) WindowManager.\u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 790034911 ^ -1892928979;
              continue;
            case 1:
              comparand = eventHandler1;
              num1 = -918915553;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = eventHandler1 != comparand ? -479664466 : (num4 = -935061412);
              int num5 = (int) num3 * 442285864;
              num1 = num4 ^ num5;
              continue;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightStart, eventHandler2, comparand);
              num1 = (int) num3 * 1165249022 ^ 1205608110;
              continue;
            case 5:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public event EventHandler OnWindowHighlightEnd
    {
      add
      {
        EventHandler eventHandler = this.OnWindowHighlightEnd;
label_1:
        int num1 = -429603829;
        while (true)
        {
          int num2 = -1570953251;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = eventHandler == comparand ? 23882177 : (num4 = 1184300088);
              int num5 = (int) num3 * -720362385;
              num1 = num4 ^ num5;
              continue;
            case 2:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightEnd, (EventHandler) WindowManager.\u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = -1790683744;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
      remove
      {
        EventHandler eventHandler1 = this.OnWindowHighlightEnd;
label_1:
        int num1 = 2001771854;
        while (true)
        {
          int num2 = 2046561734;
          uint num3;
          EventHandler eventHandler2;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler2 = (EventHandler) WindowManager.\u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -670924509 ^ 1417731175;
              continue;
            case 1:
              comparand = eventHandler1;
              num1 = 1209960340;
              continue;
            case 2:
              goto label_1;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightEnd, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? 1410607776 : (num4 = 1574462809);
              int num5 = (int) num3 * 1266305858;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event EventHandler OnWindowHighlightUpdate
    {
      add
      {
        EventHandler eventHandler = this.OnWindowHighlightUpdate;
label_1:
        int num1 = 361958366;
        while (true)
        {
          int num2 = 1274905169;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              EventHandler comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightUpdate, (EventHandler) WindowManager.\u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮((Delegate) comparand, (Delegate) value), comparand);
              int num4;
              num1 = num4 = eventHandler != comparand ? 361958366 : (num4 = 15662849);
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
      remove
      {
        EventHandler eventHandler = this.OnWindowHighlightUpdate;
label_1:
        int num1 = 134665915;
        while (true)
        {
          int num2 = 1443066224;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              int num4 = eventHandler == comparand ? -326308903 : (num4 = -1191611246);
              int num5 = (int) num3 * 1204518653;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_3;
            case 2:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.OnWindowHighlightUpdate, (EventHandler) WindowManager.\u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * 207339354 ^ -2127634851;
              continue;
            case 3:
              goto label_1;
            case 4:
              comparand = eventHandler;
              num1 = 1469246664;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    static WindowManager()
    {
label_1:
      int num1 = -22659993;
      while (true)
      {
        int num2 = -1378314363;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            WindowManager.token = new CancellationToken(false);
            num1 = (int) num3 * -927458367 ^ -1328674100;
            continue;
          case 1:
            goto label_3;
          case 2:
            WindowManager.activeHighlights = new Dictionary<IntPtr, HighlightInfo>();
            num1 = (int) num3 * -1600649634 ^ -1381186459;
            continue;
          case 3:
            WindowManager.videoChatLinksCreated = 0;
            num1 = (int) num3 * 1219259257 ^ -901505331;
            continue;
          case 4:
            goto label_1;
          case 5:
            WindowManager.unmappedWindowClicks = new List<UnmappedWindowClick>();
            num1 = (int) num3 * 371288797 ^ 1492073412;
            continue;
          case 6:
            WindowManager.videoChatLinkingInitiated = false;
            num1 = (int) num3 * -1034115264 ^ 2006838024;
            continue;
          case 7:
            WindowManager.holdDetector = new HoldDetector();
            WindowManager.manyCamBroadLastAttempt = DateTime.MinValue;
            num1 = (int) num3 * -1921262409 ^ -734318101;
            continue;
          case 8:
            WindowManager.videoChatLinks = new Dictionary<IntPtr, VideoChatLink>();
            num1 = (int) num3 * 1936650034 ^ -1886299064;
            continue;
          case 9:
            WindowManager.videoChatLinkActivityInProgress = false;
            num1 = (int) num3 * 1900318283 ^ 651306080;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    private WindowManager()
    {
    }

    internal Task ManageWindowsAsync(CancellationToken token)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003CManageWindowsAsync\u003Ed__55 manageWindowsAsyncD55 = new WindowManager.\u003CManageWindowsAsync\u003Ed__55();
      // ISSUE: reference to a compiler-generated field
      manageWindowsAsyncD55.\u003C\u003E4__this = this;
      // ISSUE: reference to a compiler-generated field
      manageWindowsAsyncD55.token = token;
label_1:
      int num1 = -210227893;
      while (true)
      {
        int num2 = -2000937198;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            manageWindowsAsyncD55.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num1 = (int) num3 * 762336594 ^ -662130893;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            manageWindowsAsyncD55.\u003C\u003E1__state = -1;
            // ISSUE: reference to a compiler-generated field
            AsyncTaskMethodBuilder tBuilder = manageWindowsAsyncD55.\u003C\u003Et__builder;
            // ISSUE: explicit reference operation
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            ((AsyncTaskMethodBuilder) @tBuilder).Start<WindowManager.\u003CManageWindowsAsync\u003Ed__55>((M0&) @manageWindowsAsyncD55);
            num1 = (int) num3 * -1695094723 ^ -782854729;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      return ((AsyncTaskMethodBuilder) @manageWindowsAsyncD55.\u003C\u003Et__builder).get_Task();
    }

    internal void ManageWindows(CancellationToken token)
    {
label_1:
      int num1 = 447731661;
      while (true)
      {
        int num2 = 868970605;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.SharedData = this.Engine.SharedData;
            num1 = (int) num3 * -1499836269 ^ -12612139;
            continue;
          case 1:
            goto label_5;
          case 3:
            this.Token = token;
            num1 = (int) num3 * 1998894020 ^ 270032799;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_5:
      PreviousWindowEvent previousWindowEvent = new PreviousWindowEvent();
      goto label_32;
label_6:
      try
      {
        bool flag = this.DependenciesStarted();
label_8:
        int num2 = 1543366987;
        while (true)
        {
          int num3 = 868970605;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              this.CheckMainWindowHandle();
              num2 = (int) num4 * -1979448160 ^ 200405202;
              continue;
            case 1:
              this.ProcessWindowEvents(ref previousWindowEvent);
              num2 = (int) num4 * 595228401 ^ -2108160136;
              continue;
            case 2:
              num2 = (int) num4 * -446940140 ^ -1630568406;
              continue;
            case 3:
              num2 = (int) num4 * -1852170384 ^ -1091528609;
              continue;
            case 4:
              int num5 = flag ? 1477127674 : (num5 = 1691329111);
              int num6 = (int) num4 * 444333285;
              num2 = num5 ^ num6;
              continue;
            case 5:
              num2 = (int) num4 * -823940730 ^ 361891316;
              continue;
            case 6:
              WindowManager.\u206A‌‎‫‍⁯‬‫⁮‬‪⁮‮‌​‌‌⁮‭​‎⁭​‮⁭‌‏‮‌⁬​‎‏‮⁫‌‍‏‭‍‮(50);
              num2 = 1954833550;
              continue;
            case 8:
              this.InspectVideoWindows();
              num2 = (int) num4 * 1340974701 ^ -2013706423;
              continue;
            case 9:
              goto label_8;
            default:
              goto label_25;
          }
        }
      }
      catch (Exception ex)
      {
label_19:
        int num2 = 1963779353;
        while (true)
        {
          int num3 = 868970605;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_19;
            case 2:
              num2 = (int) num4 * -91426390 ^ 741938915;
              continue;
            case 3:
              WindowManager.\u206C‍⁬‏‌‍‭⁯‪⁭⁮‪⁯⁭‮⁭‮⁭‬⁪‏‌‮⁫‭⁪⁪‫‭⁯⁯⁪‌⁬‮‮‮⁪‪‏‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * 1646772450 ^ -983520460;
              continue;
            case 4:
              num2 = (int) num4 * -1666874009 ^ 754420734;
              continue;
            default:
              goto label_25;
          }
        }
      }
label_25:
label_26:
      int num7 = 657876139;
label_27:
      bool flag1;
      while (true)
      {
        int num2 = 868970605;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 6U)
        {
          case 0:
            num7 = (int) num3 * -1560245153 ^ 849564508;
            continue;
          case 1:
            WindowManager.\u202C⁫⁯⁮‬⁪‫‭‮⁮‏‪​‪⁭⁪‫⁬⁮‎‪⁬‎⁫⁬⁬​⁫‌‮‪‌‏‌‪⁬⁬‮​‮‮(CoreObject.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2372035727U));
            num7 = (int) num3 * -90622662 ^ 1156510621;
            continue;
          case 2:
            goto label_32;
          case 3:
            if (!flag1)
            {
              num7 = (int) num3 * -326985292 ^ 436827612;
              continue;
            }
            goto label_6;
          case 4:
            goto label_26;
          case 5:
            goto label_28;
          default:
            goto label_24;
        }
      }
label_24:
      return;
label_28:
      return;
label_32:
      flag1 = this.ContinueProcessing();
      num7 = 626544436;
      goto label_27;
    }

    private void ProcessWindowEvents(ref PreviousWindowEvent previousWindowEvent)
    {
label_1:
      int num1 = -824816114;
      while (true)
      {
        int num2 = -588205056;
        uint num3;
        ZoomEvent zoomEvent;
        IntPtr handle;
        bool flag1;
        ZoomEventType zoomEventType;
        bool flag2;
        int num4;
        int num5;
        int num6;
        int num7;
        switch ((num3 = (uint) (num1 ^ num2)) % 52U)
        {
          case 0:
            WindowManager.HoldDetector.CheckEvent(zoomEvent);
            this.Engine.EventQueue.Enqueue(zoomEvent);
            num1 = -864270321;
            continue;
          case 1:
            int num8 = this.Engine.Settings.TraceHookEvents ? 1196466688 : (num8 = 924041302);
            int num9 = (int) num3 * -1091980466;
            num1 = num8 ^ num9;
            continue;
          case 2:
            num1 = (int) num3 * 664683042 ^ 1125769061;
            continue;
          case 3:
            num4 = zoomEvent.ZoomWindowType == ZoomWindowType.Chat ? 1 : 0;
            goto label_46;
          case 4:
            num1 = -1436593391;
            continue;
          case 5:
            if (zoomEvent.EventType == ZoomEventType.Destroy)
            {
              num1 = (int) num3 * -987959937 ^ -1796408675;
              continue;
            }
            goto label_53;
          case 6:
            num5 = this.Engine.ActiveActivity != null ? 1 : 0;
            goto label_54;
          case 7:
            num1 = -2070438612;
            continue;
          case 8:
            int num10 = zoomEvent.Window.IsVisible ? -12748695 : (num10 = -671435333);
            int num11 = (int) num3 * -896730931;
            num1 = num10 ^ num11;
            continue;
          case 9:
            num1 = (int) num3 * 636874704 ^ -1013116742;
            continue;
          case 10:
            zoomEvent.Window.RefreshLocationFromEvent(zoomEvent);
            num1 = (int) num3 * 1515093185 ^ 1854013055;
            continue;
          case 11:
            num1 = (int) num3 * -1328358224 ^ -756199837;
            continue;
          case 12:
            if (this.Engine.EventManager.HoldDetected)
            {
              num1 = -893865575;
              continue;
            }
            goto label_53;
          case 13:
            goto label_3;
          case 14:
            num1 = (int) num3 * 1602461520 ^ 1414855564;
            continue;
          case 15:
            previousWindowEvent.ZoomEventType = zoomEvent.EventType;
            previousWindowEvent.Handle = zoomEvent.WindowHandle;
            num1 = (int) num3 * 1492372269 ^ -1826513349;
            continue;
          case 16:
            previousWindowEvent.ZoomWindowType = zoomEvent.ZoomWindowType;
            num1 = (int) num3 * -240046518 ^ 104026607;
            continue;
          case 17:
            num1 = (int) num3 * -1345692784 ^ 18749071;
            continue;
          case 18:
            num1 = (int) num3 * 1001799837 ^ 1359602993;
            continue;
          case 19:
            num1 = (int) num3 * -1813440586 ^ -344524035;
            continue;
          case 20:
            CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1195726343U), (object) zoomEvent);
            num1 = (int) num3 * 1601245819 ^ 1129925775;
            continue;
          case 21:
            if (handle.Equals((object) zoomEvent.WindowHandle))
            {
              num1 = (int) num3 * -480606068 ^ -895102064;
              continue;
            }
            num6 = 1;
            goto label_64;
          case 22:
            num1 = (int) num3 * -1878907583 ^ 1247530303;
            continue;
          case 23:
            if (zoomEvent.Window != null)
            {
              num1 = (int) num3 * 553473444 ^ -1271206792;
              continue;
            }
            num7 = 0;
            break;
          case 24:
            zoomEventType = previousWindowEvent.ZoomEventType;
            num1 = (int) num3 * 1908096390 ^ 1708238784;
            continue;
          case 25:
            num1 = (int) num3 * -643600271 ^ -996144157;
            continue;
          case 26:
            num1 = -2130370407;
            continue;
          case 27:
            previousWindowEvent.ZoomWindowType = zoomEvent.ZoomWindowType;
            num1 = (int) num3 * 1753091961 ^ 668173015;
            continue;
          case 28:
            int num12 = flag2 ? -1198431605 : (num12 = -917542838);
            int num13 = (int) num3 * 1610563299;
            num1 = num12 ^ num13;
            continue;
          case 29:
            if (!this.Engine.EventManager.HoldDetected)
            {
              num4 = 0;
              goto label_46;
            }
            else
            {
              num1 = (int) num3 * -754047688 ^ -710961141;
              continue;
            }
          case 30:
            flag2 = this.SharedData.WindowQueue.TryDequeue(ref zoomEvent);
            num1 = (int) num3 * 838144342 ^ 1116696556;
            continue;
          case 31:
            this.Engine.CancelActivity((ActivityBase) null);
            num1 = (int) num3 * 52715605 ^ -293411122;
            continue;
          case 32:
            num7 = zoomEvent.ZoomWindowType != ZoomWindowType.Ignore ? 1 : 0;
            break;
          case 33:
            if (zoomEvent.ZoomWindowType == ZoomWindowType.InvalidMeeting)
            {
              num1 = (int) num3 * 246029975 ^ 603582782;
              continue;
            }
            goto label_53;
          case 34:
            this.InspectWindows(this.sharedData);
            num1 = -2777878;
            continue;
          case 35:
            num1 = (int) num3 * -171054984 ^ -824270003;
            continue;
          case 36:
            num6 = !zoomEventType.Equals((object) zoomEvent.EventType) ? 1 : 0;
            goto label_64;
          case 37:
            this.AddHighlightWindow(zoomEvent.Window);
            num1 = (int) num3 * 583195805 ^ 1067092726;
            continue;
          case 38:
            num1 = (int) num3 * -1329235320 ^ 1862498373;
            continue;
          case 39:
            this.DistributeZoomEvent(zoomEvent);
            this.DistributeEventsToListeners(zoomEvent);
            num1 = -1653501108;
            continue;
          case 40:
            goto label_1;
          case 41:
            zoomEvent.Window = this.GetWindow(zoomEvent, zoomEvent.EventType != ZoomEventType.Destroy);
            num1 = -1512244507;
            continue;
          case 42:
            int num14 = !flag1 ? -1363166964 : (num14 = -1483800798);
            int num15 = (int) num3 * 153056072;
            num1 = num14 ^ num15;
            continue;
          case 43:
            num1 = -1013673761;
            continue;
          case 44:
            num1 = (int) num3 * 308499248 ^ -629971955;
            continue;
          case 45:
            this.HandleWindowMovements(zoomEvent, previousWindowEvent);
            handle = previousWindowEvent.Handle;
            num1 = (int) num3 * 1560998842 ^ 924021891;
            continue;
          case 46:
            num1 = (int) num3 * -412040210 ^ -1935883172;
            continue;
          case 47:
            num1 = (int) num3 * 1797641441 ^ 2099692379;
            continue;
          case 48:
            num1 = (int) num3 * -108201540 ^ -1033610914;
            continue;
          case 49:
            num1 = (int) num3 * -736236683 ^ 1209310878;
            continue;
          case 50:
            num1 = -1464496982;
            continue;
          case 51:
            num1 = (int) num3 * -694687203 ^ -263788748;
            continue;
          default:
            goto label_68;
        }
        int num16;
        num1 = num16 = num7 != 0 ? -801861394 : (num16 = -2070438612);
        continue;
label_46:
        flag1 = num4 != 0;
        num1 = -1405571318;
        continue;
label_53:
        num5 = 0;
label_54:
        int num17;
        num1 = num17 = num5 != 0 ? -773471629 : (num17 = -940221965);
        continue;
label_64:
        int num18;
        num1 = num18 = num6 == 0 ? -2114599882 : (num18 = -53976230);
      }
label_68:
      return;
label_3:;
    }

    private void HandleWindowMovements(ZoomEvent zoomEvent, PreviousWindowEvent previousWindowEvent)
    {
label_1:
      int num1 = -162030564;
      List<ZoomWindowType> zoomWindowTypeList;
      ZoomWindow zoomWindow;
      while (true)
      {
        int num2 = -1717383451;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            zoomWindowTypeList = new List<ZoomWindowType>()
            {
              ZoomWindowType.Meeting,
              ZoomWindowType.Join,
              ZoomWindowType.AccountPanel,
              ZoomWindowType.ManyCamApp
            };
            num1 = (int) num3 * 96849224 ^ -2056993779;
            continue;
          case 1:
            zoomWindow = (ZoomWindow) null;
            num1 = (int) num3 * 2033410669 ^ 1217275655;
            continue;
          case 2:
            num1 = (int) num3 * 973131066 ^ -1464731567;
            continue;
          case 3:
            goto label_1;
          case 5:
            num4 = zoomEvent.EventType == ZoomEventType.MoveSize ? 1 : 0;
            break;
          case 6:
            if (zoomEvent.EventType != ZoomEventType.LocationChanged)
            {
              num1 = (int) num3 * -486448953 ^ -949438619;
              continue;
            }
            num4 = 1;
            break;
          default:
            goto label_12;
        }
        if (num4 != 0)
          num1 = -983606253;
        else
          break;
      }
      return;
label_12:
      using (List<ZoomWindowType>.Enumerator enumerator = zoomWindowTypeList.GetEnumerator())
      {
label_28:
        int num2 = enumerator.MoveNext() ? -492989633 : (num2 = -832602525);
        while (true)
        {
          int num3 = -1717383451;
          uint num4;
          bool flag1;
          ZoomWindow window;
          ZoomWindowType current;
          bool flag2;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 19U)
          {
            case 0:
              num2 = -492989633;
              continue;
            case 2:
              num2 = (int) num4 * -1619934132 ^ -1526554089;
              continue;
            case 3:
              int num6 = !flag1 ? -1528354876 : (num6 = -210225279);
              int num7 = (int) num4 * -377930579;
              num2 = num6 ^ num7;
              continue;
            case 4:
              num5 = window.ZoomWindowType == ZoomWindowType.Meeting ? 1 : 0;
              break;
            case 5:
              window = this.Engine.GetWindow(current);
              num2 = (int) num4 * -894330047 ^ -1009329123;
              continue;
            case 6:
              num2 = (int) num4 * 1005886524 ^ 881580194;
              continue;
            case 7:
              int num8 = !flag2 ? 238203893 : (num8 = 1706339691);
              int num9 = (int) num4 * 1653262647;
              num2 = num8 ^ num9;
              continue;
            case 8:
              current = enumerator.Current;
              num2 = -92457608;
              continue;
            case 9:
              zoomWindow = window;
              num2 = -1921817622;
              continue;
            case 10:
              flag1 = !this.movementHandles.Contains(window.Handle);
              num2 = (int) num4 * 1423227431 ^ 383241782;
              continue;
            case 11:
              int num10 = window != null ? 1789295101 : (num10 = 383283842);
              int num11 = (int) num4 * -1637948679;
              num2 = num10 ^ num11;
              continue;
            case 12:
              if (!this.movementHandles.Contains(window.Handle))
              {
                num2 = (int) num4 * 1810195051 ^ -1193584936;
                continue;
              }
              num5 = 1;
              break;
            case 13:
              this.movementHandles.Add(window.Handle);
              num2 = (int) num4 * 954630549 ^ -1796540734;
              continue;
            case 14:
              if (window != null)
              {
                num2 = -1488089978;
                continue;
              }
              num5 = 0;
              break;
            case 15:
              num2 = (int) num4 * 991460018 ^ 500161181;
              continue;
            case 16:
              num2 = (int) num4 * 2003642868 ^ -1603505778;
              continue;
            case 17:
              goto label_28;
            case 18:
              num2 = -731744347;
              continue;
            default:
              goto label_40;
          }
          flag2 = num5 != 0;
          num2 = -142407118;
        }
      }
label_40:
      if (zoomWindow == null)
        goto label_63;
label_41:
      int num12 = -837339197;
label_42:
      while (true)
      {
        int num2 = -1717383451;
        uint num3;
        WindowMovementPayload windowMovementPayload;
        Rectangle rectangle;
        ZoomWindow window;
        Rectangle windowRectangle;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num12 ^ num2)) % 29U)
        {
          case 0:
            int num5 = flag ? 1079153798 : (num5 = 385846130);
            int num6 = (int) num3 * -1935779148;
            num12 = num5 ^ num6;
            continue;
          case 1:
            windowMovementPayload.Y = rectangle.Y;
            num12 = (int) num3 * 1651863176 ^ -956387830;
            continue;
          case 2:
            num12 = -206159138;
            continue;
          case 3:
            goto label_43;
          case 4:
            rectangle.X = rectangle.X + 5;
            num12 = (int) num3 * 639934604 ^ 834963191;
            continue;
          case 5:
            rectangle.Height = window.Size.Height;
            num12 = (int) num3 * 1434350077 ^ -771352569;
            continue;
          case 6:
            num12 = (int) num3 * -1489306338 ^ -1667463828;
            continue;
          case 7:
            num12 = -271200209;
            continue;
          case 8:
            window = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
            num12 = (int) num3 * 838521301 ^ -614178577;
            continue;
          case 9:
            windowMovementPayload.X = rectangle.X;
            num12 = (int) num3 * 742732043 ^ -1034746167;
            continue;
          case 10:
            windowMovementPayload = new WindowMovementPayload();
            windowMovementPayload.WindowType = ZoomWindowType.ZoomZoomMain;
            num12 = (int) num3 * 782421119 ^ 735659587;
            continue;
          case 11:
            ((CompositePresentationEvent<WindowMovementPayload>) this._eventAggregator.GetEvent<MoveZoomZoomWindow>()).Publish(windowMovementPayload);
            num12 = (int) num3 * -1971380586 ^ -428137696;
            continue;
          case 12:
            num12 = (int) num3 * 280225445 ^ 1003726567;
            continue;
          case 13:
            window.DefaultRectangle = rectangle;
            num12 = (int) num3 * -1730539614 ^ -900114058;
            continue;
          case 14:
            goto label_41;
          case 15:
            num4 = windowRectangle.Y != rectangle.Y ? 1 : 0;
            break;
          case 16:
            int num7 = window == null ? -615633877 : (num7 = -1269217390);
            int num8 = (int) num3 * -536818907;
            num12 = num7 ^ num8;
            continue;
          case 17:
            num12 = (int) num3 * -1125798623 ^ 570313205;
            continue;
          case 18:
            if (windowRectangle.X == rectangle.X)
            {
              num12 = (int) num3 * -2088091731 ^ -102027007;
              continue;
            }
            num4 = 1;
            break;
          case 19:
            num12 = (int) num3 * -2009808589 ^ -416980015;
            continue;
          case 20:
            rectangle.Width = window.Size.Width;
            num12 = (int) num3 * 1699656128 ^ -1637293175;
            continue;
          case 21:
            windowRectangle = WindowHelper.GetWindowRectangle(window.Handle);
            if (!(windowRectangle != Rectangle.Empty))
            {
              num4 = 0;
              break;
            }
            num12 = (int) num3 * -490466286 ^ -97457374;
            continue;
          case 22:
            goto label_63;
          case 23:
            rectangle = zoomWindow.Rectangle;
            num12 = (int) num3 * -118319774 ^ 1314232792;
            continue;
          case 24:
            rectangle.Y = rectangle.Y + 5;
            num12 = (int) num3 * -1313632909 ^ -334783025;
            continue;
          case 25:
            num12 = (int) num3 * 438044213 ^ 1681021671;
            continue;
          case 26:
            num12 = (int) num3 * -757713948 ^ 539748715;
            continue;
          case 27:
            num12 = (int) num3 * -727268954 ^ 1216517808;
            continue;
          case 28:
            num12 = (int) num3 * -746065269 ^ -2004828568;
            continue;
          default:
            goto label_38;
        }
        flag = num4 != 0;
        num12 = -960700472;
      }
label_38:
      return;
label_43:
      return;
label_63:
      num12 = -808671489;
      goto label_42;
    }

    public void SetMainWindowHandle(IntPtr handle)
    {
      object windowLock = WindowManager.windowLock;
      bool flag = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
label_2:
        int num1 = 1041863928;
        while (true)
        {
          int num2 = 1181813559;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 2:
              num1 = (int) num3 * 1838227659 ^ 1755744292;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        this.mainHandle = handle;
      }
      finally
      {
        if (flag)
        {
label_7:
          int num1 = 1908803727;
          while (true)
          {
            int num2 = 1181813559;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_7;
              case 2:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num1 = (int) num3 * 282974870 ^ 415706280;
                continue;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
    }

    private void ScrollMeetingWindowToEnd()
    {
label_1:
      int num1 = -1500049082;
      while (true)
      {
        int num2 = -502987873;
        uint num3;
        bool flag1;
        ZoomWindow zoomWindow1;
        bool flag2;
        bool flag3;
        int num4;
        bool traceWindowEvents;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 35U)
        {
          case 0:
            int num7 = !traceWindowEvents ? 707041754 : (num7 = 197419291);
            int num8 = (int) num3 * -1903517911;
            num1 = num7 ^ num8;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            zoomWindow1 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__61_0 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__61_0 = new Func<ZoomWindow, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CScrollMeetingWindowToEnd\u003Eb__61_0)))));
            num1 = -1227983806;
            continue;
          case 2:
            int num9 = flag2 ? 869184852 : (num9 = 2053000448);
            int num10 = (int) num3 * 1542835688;
            num1 = num9 ^ num10;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            num5 = num4 > ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__61_1 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__61_1 = new Func<ZoomWindow, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CScrollMeetingWindowToEnd\u003Eb__61_1)))))).ToList<ZoomWindow>().Count ? 1 : 0;
            goto label_19;
          case 4:
            num1 = -741212188;
            continue;
          case 5:
            if (this.Engine.ActiveMeetingWindow.IsVisible)
            {
              num1 = (int) num3 * -1329584194 ^ -1126495272;
              continue;
            }
            break;
          case 6:
            num1 = -30044047;
            continue;
          case 7:
            num1 = (int) num3 * -1743264683 ^ 359266867;
            continue;
          case 8:
            num1 = (int) num3 * 1394686310 ^ 1372363529;
            continue;
          case 9:
            flag3 = false;
            num1 = (int) num3 * 322060315 ^ -123759929;
            continue;
          case 10:
            CoreObject.log.Debug((object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3992915214U));
            num1 = (int) num3 * -554412097 ^ -1412246988;
            continue;
          case 11:
            int num11 = !flag1 ? 167062195 : (num11 = 904621398);
            int num12 = (int) num3 * 845644735;
            num1 = num11 ^ num12;
            continue;
          case 12:
            int num13 = this.Engine.Settings.TraceWindowEvents ? 215928581 : (num13 = 2685378);
            int num14 = (int) num3 * -86624680;
            num1 = num13 ^ num14;
            continue;
          case 13:
            num1 = (int) num3 * -327751664 ^ -316650883;
            continue;
          case 14:
            if (this.Engine.ActiveMeetingWindow != null)
            {
              num1 = (int) num3 * -1528796594 ^ 1218248099;
              continue;
            }
            break;
          case 15:
            num1 = (int) num3 * 63582835 ^ -1267975930;
            continue;
          case 16:
            ZoomWindow zoomWindow2 = zoomWindow1;
            Size size = zoomWindow1.Size;
            int x = size.Width / 2;
            size = zoomWindow1.Size;
            int y = size.Height / 2;
            System.Drawing.Point coordinates = new System.Drawing.Point(x, y);
            int num15 = 1;
            int num16 = 1;
            int millisecondDelay = 0;
            zoomWindow2.Click(coordinates, num15 != 0, num16 != 0, millisecondDelay);
            num1 = -30924826;
            continue;
          case 17:
            goto label_1;
          case 18:
            WindowManager.\u206C‍‭⁯⁫⁫‎⁬‌‬‭‍‎⁯‎⁯‎‌⁫‪⁬‮‏‭‏⁪‎⁮​‭‮‫‭⁪⁪​⁫‍‫‏‮(CoreObject.log, (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1536335184U));
            num1 = (int) num3 * -1792385649 ^ 1952149081;
            continue;
          case 19:
            flag3 = true;
            num4 = 0;
            num1 = (int) num3 * 1954962692 ^ -1207353900;
            continue;
          case 20:
            ++num4;
            num1 = -1652560225;
            continue;
          case 21:
            goto label_3;
          case 22:
            num1 = (int) num3 * -1955546739 ^ -771041320;
            continue;
          case 23:
            num1 = (int) num3 * -2046295622 ^ 79662423;
            continue;
          case 24:
            num1 = (int) num3 * 1386633347 ^ 343136184;
            continue;
          case 25:
            num6 = zoomWindow1.IsVisible ? 1 : 0;
            goto label_25;
          case 26:
            int num17;
            num1 = num17 = !flag3 ? -220063932 : (num17 = -1645731354);
            continue;
          case 27:
            num1 = (int) num3 * 2018677268 ^ -1862827148;
            continue;
          case 28:
            num1 = -798242103;
            continue;
          case 29:
            num1 = (int) num3 * -1175174717 ^ -1540264679;
            continue;
          case 30:
            traceWindowEvents = this.Engine.Settings.TraceWindowEvents;
            num1 = (int) num3 * 165561217 ^ 1423599687;
            continue;
          case 31:
            if (this.Engine.ActiveMeeting != null)
            {
              num1 = (int) num3 * -1270158018 ^ -1830373066;
              continue;
            }
            break;
          case 32:
            if (zoomWindow1 == null)
            {
              num6 = 0;
              goto label_25;
            }
            else
            {
              num1 = (int) num3 * 1617572511 ^ 561429708;
              continue;
            }
          case 33:
            flag3 = false;
            num1 = -360145985;
            continue;
          case 34:
            Thread.Sleep(150);
            num1 = -1027609594;
            continue;
          default:
            goto label_45;
        }
        num5 = 1;
label_19:
        flag2 = num5 != 0;
        num1 = -1224567018;
        continue;
label_25:
        flag1 = num6 != 0;
        num1 = -708917526;
      }
label_45:
      return;
label_3:;
    }

    private void InspectVideoWindows()
    {
      try
      {
label_2:
        int num1 = 1655158019;
        ZoomWindow window;
        while (true)
        {
          int num2 = 877691890;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              flag2 = window != null;
              num1 = (int) num3 * -844284622 ^ 439230185;
              continue;
            case 1:
              if (flag2)
              {
                num1 = (int) num3 * 2021064021 ^ -578883996;
                continue;
              }
              goto label_48;
            case 2:
              num4 = this.windowLastImaged.AddSeconds(this.Engine.Settings.AutoSpotlightInterval) < DateTime.Now ? 1 : 0;
              break;
            case 3:
              num1 = (int) num3 * -417839429 ^ -166788071;
              continue;
            case 4:
              if (this.Engine.Settings.AutoCaptureVideoImages)
              {
                num1 = (int) num3 * 1476504587 ^ -1817734041;
                continue;
              }
              num4 = 0;
              break;
            case 5:
              if (flag1)
              {
                num1 = (int) num3 * 1500846361 ^ -2125718958;
                continue;
              }
              goto label_71;
            case 6:
              // ISSUE: method pointer
              window = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.GetVideoWindows(), (Func<M0, bool>) new Func<ZoomWindow, bool>((object) this, __methodptr(\u003CInspectVideoWindows\u003Eb__65_0)));
              num1 = (int) num3 * 1157166916 ^ 1775631879;
              continue;
            case 8:
              goto label_2;
            default:
              goto label_16;
          }
          flag1 = num4 != 0;
          num1 = 1210335873;
        }
label_16:
        object managerLock1 = ManagerBase.managerLock;
        bool flag3 = false;
        try
        {
          Monitor.Enter(managerLock1, ref flag3);
label_18:
          int num2 = 1020343233;
          while (true)
          {
            int num3 = 877691890;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                num2 = (int) num4 * -1851872486 ^ -578354160;
                continue;
              case 1:
                num2 = (int) num4 * 1741153514 ^ -894630355;
                continue;
              case 2:
                this.windowLastImaged = DateTime.Now;
                num2 = (int) num4 * 256025828 ^ -569085152;
                continue;
              case 3:
                goto label_18;
              case 5:
                this.windowsImaged.Add(window.Handle);
                num2 = (int) num4 * 544026516 ^ 411520062;
                continue;
              default:
                goto label_30;
            }
          }
        }
        finally
        {
          if (flag3)
          {
label_25:
            int num2 = 250407199;
            while (true)
            {
              int num3 = 877691890;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  Monitor.Exit(managerLock1);
                  num2 = (int) num4 * -560008324 ^ -179375147;
                  continue;
                case 2:
                  goto label_25;
                case 3:
                  num2 = (int) num4 * 1276318826 ^ 2034846640;
                  continue;
                default:
                  goto label_29;
              }
            }
          }
label_29:;
        }
label_30:
        window.WindowInspected = DateTime.Now;
        try
        {
          CaptureVideoWindow captureVideoWindow = new CaptureVideoWindow(window);
label_32:
          int num2 = 801647820;
          while (true)
          {
            int num3 = 877691890;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 0:
                captureVideoWindow.DetectUserNameViaChat = false;
                num2 = (int) num4 * -195530861 ^ -329662677;
                continue;
              case 1:
                int num5 = (int) captureVideoWindow.Execute(this.Engine.Token);
                num2 = (int) num4 * 1749346703 ^ -1137565410;
                continue;
              case 2:
                captureVideoWindow.Options.SuppressProgressReports = true;
                num2 = (int) num4 * -733626254 ^ 422827318;
                continue;
              case 4:
                num2 = (int) num4 * 1536678194 ^ -6021059;
                continue;
              case 5:
                goto label_32;
              case 6:
                captureVideoWindow.Options.MinimizeEngineView = false;
                num2 = (int) num4 * 215082750 ^ -352036182;
                continue;
              case 7:
                captureVideoWindow.Options.MinimizeOverlappedWindows = true;
                num2 = (int) num4 * -1347717969 ^ -1876974447;
                continue;
              default:
                goto label_41;
            }
          }
        }
        catch (Exception ex)
        {
          CoreObject.log.Error((object) ex);
        }
label_41:
label_42:
        int num6 = 777723910;
label_43:
        object managerLock2;
        bool flag4;
        while (true)
        {
          int num2 = 877691890;
          uint num3;
          switch ((num3 = (uint) (num6 ^ num2)) % 7U)
          {
            case 0:
              num6 = (int) num3 * 446868738 ^ 1894920601;
              continue;
            case 2:
              if (flag4)
              {
                num6 = (int) num3 * 1678163512 ^ 1029327787;
                continue;
              }
              goto label_100;
            case 3:
              managerLock2 = ManagerBase.managerLock;
              num6 = (int) num3 * -1556221142 ^ 472648810;
              continue;
            case 4:
              goto label_50;
            case 5:
              goto label_42;
            case 6:
              goto label_48;
            default:
              goto label_53;
          }
        }
label_50:
        int num7 = this.windowsImaged.Count > 0 ? 1 : 0;
        goto label_52;
label_53:
        bool flag5 = false;
        try
        {
          Monitor.Enter(managerLock2, ref flag5);
label_55:
          int num2 = 79151172;
          while (true)
          {
            int num3 = 877691890;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_55;
              case 1:
                num2 = (int) num4 * -229547372 ^ 723477705;
                continue;
              case 2:
                this.windowsImaged.Clear();
                num2 = (int) num4 * -1111835693 ^ -491647807;
                continue;
              default:
                goto label_65;
            }
          }
        }
        finally
        {
          if (flag5)
          {
label_60:
            int num2 = 289748939;
            while (true)
            {
              int num3 = 877691890;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_60;
                case 1:
                  Monitor.Exit(managerLock2);
                  num2 = (int) num4 * 922999069 ^ -636433804;
                  continue;
                case 3:
                  num2 = (int) num4 * -1607708418 ^ -1253698378;
                  continue;
                default:
                  goto label_64;
              }
            }
          }
label_64:;
        }
label_65:
        GalleryMoveNextPage galleryMoveNextPage = new GalleryMoveNextPage();
        galleryMoveNextPage.Options.SuppressProgressReports = true;
        goto label_66;
label_48:
        if (window == null)
        {
          num6 = 899367959;
          goto label_43;
        }
        else
          num7 = 0;
label_52:
        flag4 = num7 != 0;
        num6 = 1728956181;
        goto label_43;
label_66:
        int num8 = 96832952;
label_67:
        ZoomWindow videoWindow;
        DateTime dateTime;
        object windowLock;
        while (true)
        {
          int num2 = 877691890;
          uint num3;
          List<ZoomWindow> list;
          bool flag1;
          // ISSUE: variable of a compiler-generated type
          WindowManager.\u003C\u003Ec__DisplayClass65_0 cDisplayClass650;
          int num4;
          int num5;
          switch ((num3 = (uint) (num8 ^ num2)) % 33U)
          {
            case 0:
              if (dateTime.AddSeconds(5.0) < DateTime.Now)
              {
                num8 = (int) num3 * 2069615189 ^ -148971350;
                continue;
              }
              num4 = 0;
              break;
            case 1:
              galleryMoveNextPage.Options.MinimizeOverlappedWindows = true;
              num8 = (int) num3 * 795634459 ^ 278613432;
              continue;
            case 2:
              dateTime = this.Engine.HookManager.LastKeyPress;
              num8 = (int) num3 * 826092774 ^ 963247318;
              continue;
            case 3:
              num4 = dateTime.AddSeconds(5.0) < DateTime.Now ? 1 : 0;
              break;
            case 4:
              goto label_100;
            case 5:
              InspectVideoWindow inspectVideoWindow = new InspectVideoWindow(videoWindow);
              inspectVideoWindow.Options = new ActivityOptions()
              {
                SuppressProgressReports = true
              };
              if (inspectVideoWindow.Execute(WindowManager.token) == ActivityState.Completed)
              {
                num8 = (int) num3 * -678505200 ^ -141401270;
                continue;
              }
              goto label_133;
            case 6:
              if (dateTime.AddSeconds(this.Engine.Settings.AutoSpotlightInterval) < DateTime.Now)
              {
                num8 = (int) num3 * -1894261023 ^ 797369340;
                continue;
              }
              goto label_130;
            case 7:
              num8 = (int) num3 * -1146364284 ^ -1984919773;
              continue;
            case 8:
              if (this.Engine.ActiveActivity == null)
              {
                num8 = (int) num3 * -1912149283 ^ 1008027717;
                continue;
              }
              goto label_104;
            case 9:
              num8 = (int) num3 * 1146883125 ^ 1531633435;
              continue;
            case 10:
              windowLock = WindowManager.windowLock;
              num8 = 1598784904;
              continue;
            case 11:
              dateTime = this.Engine.HookManager.LastMouseMovement;
              num8 = (int) num3 * -1818245934 ^ 924294502;
              continue;
            case 12:
              num8 = (int) num3 * 17621310 ^ 1203219101;
              continue;
            case 13:
              this.videoHighlights.Add(videoWindow.Handle);
              num8 = (int) num3 * -1480043653 ^ 207830752;
              continue;
            case 14:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass650.lastWindow = this.LastWindowSpotlighted != null ? this.LastWindowSpotlighted.Handle : IntPtr.Zero;
              // ISSUE: method pointer
              list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.GetVideoWindows(), (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass650, __methodptr(\u003CInspectVideoWindows\u003Eb__1)))).ToList<ZoomWindow>();
              num8 = 667846293;
              continue;
            case 15:
              int num9 = (int) galleryMoveNextPage.Execute(this.Engine.Token);
              num8 = (int) num3 * -1174832861 ^ -1743402395;
              continue;
            case 17:
              goto label_66;
            case 18:
              if (list.Count > 0)
              {
                num8 = (int) num3 * 464574230 ^ -396759360;
                continue;
              }
              goto label_131;
            case 19:
              num8 = (int) num3 * -45636964 ^ -268732856;
              continue;
            case 20:
              num8 = (int) num3 * 1838976380 ^ -2040868042;
              continue;
            case 21:
              num5 = this.Engine.ActiveMeeting != null ? 1 : 0;
              goto label_105;
            case 22:
              if (flag1)
              {
                num8 = (int) num3 * -1783816172 ^ -1117013171;
                continue;
              }
              goto label_128;
            case 23:
              goto label_71;
            case 24:
              int num10 = this.Engine.Settings.TraceWindowEvents ? 548135142 : (num10 = 107876367);
              int num11 = (int) num3 * 1794457820;
              num8 = num10 ^ num11;
              continue;
            case 25:
              num8 = (int) num3 * -13730438 ^ 299344103;
              continue;
            case 26:
              num8 = (int) num3 * -795128896 ^ 1130016161;
              continue;
            case 27:
              num8 = (int) num3 * -138158135 ^ -1841079630;
              continue;
            case 28:
              CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3575348833U), (object) videoWindow.ZoomWindowType);
              num8 = (int) num3 * -1033778969 ^ -129062975;
              continue;
            case 29:
              if (this.Engine.Settings.AutoSpotlightEnabled)
              {
                num8 = (int) num3 * -642250394 ^ 1187859016;
                continue;
              }
              goto label_104;
            case 30:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass650 = new WindowManager.\u003C\u003Ec__DisplayClass65_0();
              // ISSUE: reference to a compiler-generated field
              cDisplayClass650.\u003C\u003E4__this = this;
              num8 = (int) num3 * 1531421971 ^ -465212792;
              continue;
            case 31:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: method pointer
              videoWindow = ((IEnumerable<ZoomWindow>) Enumerable.OrderBy<ZoomWindow, DateTime>((IEnumerable<M0>) list, (Func<M0, M1>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__65_2 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__65_2 = new Func<ZoomWindow, DateTime>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CInspectVideoWindows\u003Eb__65_2)))))).First<ZoomWindow>();
              if (videoWindow != null)
              {
                num8 = 1848207723;
                continue;
              }
              goto label_132;
            case 32:
              num8 = (int) num3 * 1664807816 ^ 906181939;
              continue;
            default:
              goto label_112;
          }
          if (num4 != 0)
          {
            num8 = 160782153;
            continue;
          }
          goto label_129;
label_104:
          num5 = 0;
label_105:
          flag1 = num5 != 0;
          num8 = 1652481256;
        }
label_112:
        bool flag6 = false;
        try
        {
          Monitor.Enter(windowLock, ref flag6);
label_114:
          int num2 = 1287621278;
          while (true)
          {
            int num3 = 877691890;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                goto label_114;
              case 1:
                num2 = (int) num4 * -965906205 ^ 1479067948;
                continue;
              case 2:
                num2 = (int) num4 * -1404103796 ^ 91356457;
                continue;
              case 3:
                videoWindow.WindowSpotlighted = DateTime.Now;
                num2 = (int) num4 * -945428375 ^ 1810439437;
                continue;
              default:
                goto label_119;
            }
          }
label_119:
          this.LastVideoWindowInspectionTime = DateTime.Now;
          this.LastWindowSpotlighted = videoWindow;
        }
        finally
        {
          if (flag6)
          {
label_121:
            int num2 = 2130153716;
            while (true)
            {
              int num3 = 877691890;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_121;
                case 2:
                  Monitor.Exit(windowLock);
                  num2 = (int) num4 * -2029433558 ^ 207865410;
                  continue;
                default:
                  goto label_124;
              }
            }
          }
label_124:;
        }
label_125:
        int num12 = 56933301;
label_126:
        while (true)
        {
          int num2 = 877691890;
          uint num3;
          switch ((num3 = (uint) (num12 ^ num2)) % 11U)
          {
            case 0:
              goto label_143;
            case 1:
              num12 = (int) num3 * -1211598278 ^ 1196054522;
              continue;
            case 2:
              this.videoHighlights.Clear();
              num12 = (int) num3 * 1724693976 ^ -162927908;
              continue;
            case 3:
              goto label_133;
            case 4:
              num12 = 2002241995;
              continue;
            case 5:
              goto label_125;
            case 6:
              goto label_129;
            case 7:
              goto label_128;
            case 8:
              goto label_131;
            case 9:
              goto label_130;
            case 10:
              goto label_132;
            default:
              goto label_141;
          }
        }
label_141:
        return;
label_143:
        return;
label_128:
        num12 = 410944217;
        goto label_126;
label_129:
        num12 = 475495339;
        goto label_126;
label_130:
        num12 = 1155594975;
        goto label_126;
label_131:
        num12 = 784855618;
        goto label_126;
label_132:
        num12 = 2080829789;
        goto label_126;
label_133:
        num12 = 1719724598;
        goto label_126;
label_71:
        dateTime = this.LastVideoWindowInspectionTime;
        num8 = 1518814048;
        goto label_67;
label_100:
        num8 = 9015264;
        goto label_67;
      }
      catch (Exception ex)
      {
        CoreObject.log.Error((object) ex);
label_139:
        int num1 = 1650090855;
        while (true)
        {
          int num2 = 877691890;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_139;
            case 1:
              num1 = (int) num3 * -1394201573 ^ -1347461313;
              continue;
            case 2:
              goto label_137;
            default:
              goto label_127;
          }
        }
label_127:
        return;
label_137:;
      }
    }

    private void CaptureImage(object state)
    {
      try
      {
label_2:
        int num1 = 1834327619;
        while (true)
        {
          int num2 = 733640867;
          uint num3;
          Thread thread;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_19;
            case 1:
              num1 = (int) num3 * 53094677 ^ -1538799241;
              continue;
            case 2:
              WindowManager.\u200F‫‭‮‎⁭‬⁯‎⁯‌‎‏⁯⁮‎‬⁫‫‌‭‮‪⁫‫‪‫‬⁭‬‏‭⁪⁬‍​‫‬‬‏‮(thread);
              num1 = (int) num3 * 1996202997 ^ -412486771;
              continue;
            case 3:
              num1 = (int) num3 * 1570418736 ^ 459067625;
              continue;
            case 4:
              num1 = (int) num3 * 469666643 ^ -1148039845;
              continue;
            case 5:
              thread = WindowManager.\u206D‭‌‮⁭​‏‌⁯‭‫⁭‭‫‮⁯‫⁫‍‭⁫⁭‪‌⁪‎‏‎⁮‫‪‫‌‎⁯​‏‏⁫‌‮((ThreadStart) (() =>
              {
                try
                {
                  ZoomWindow window = state as ZoomWindow;
label_2:
                  int num1 = -1238608801;
                  while (true)
                  {
                    int num2 = -209913842;
                    uint num3;
                    bool flag;
                    ZoomImage zoomImage;
                    switch ((num3 = (uint) (num1 ^ num2)) % 8U)
                    {
                      case 0:
                        ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<ImageCapturedEvent>()).Publish(zoomImage);
                        num1 = (int) num3 * -308673769 ^ -637226296;
                        continue;
                      case 1:
                        flag = window != null;
                        num1 = (int) num3 * 2003499941 ^ 964949024;
                        continue;
                      case 2:
                        goto label_19;
                      case 3:
                        int num4 = !flag ? -1818030141 : (num4 = -762793306);
                        int num5 = (int) num3 * 319702853;
                        num1 = num4 ^ num5;
                        continue;
                      case 4:
                        goto label_2;
                      case 5:
                        zoomImage.SaveDatabaseObject();
                        num1 = (int) num3 * 39702384 ^ 1057956342;
                        continue;
                      case 6:
                        num1 = (int) num3 * 188673516 ^ 13443500;
                        continue;
                      case 7:
                        zoomImage = this.Engine.CaptureImage(window, Rectangle.Empty, ImageEnums.ImageType.Video, new ImageOptions()
                        {
                          DisplayAfterCapture = true,
                          DisplayHighlightWindow = true,
                          SaveToDisk = true
                        });
                        num1 = (int) num3 * 1246182324 ^ -1113238321;
                        continue;
                      default:
                        goto label_15;
                    }
                  }
label_15:
                  return;
label_19:;
                }
                catch (Exception ex)
                {
label_13:
                  int num1 = -2112999082;
                  while (true)
                  {
                    int num2 = -209913842;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 5U)
                    {
                      case 0:
                        goto label_13;
                      case 1:
                        num1 = (int) num3 * -503485245 ^ -775516723;
                        continue;
                      case 2:
                        goto label_11;
                      case 3:
                        num1 = (int) num3 * -512373838 ^ -1555559105;
                        continue;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        WindowManager.\u003C\u003Ec__DisplayClass66_0.\u206C⁭‫‬‭‫⁮⁯⁫‏‏⁬⁮‫‫⁮‍‪‮‌‬‌‏‭‎‎⁬⁯‮⁮⁪‏⁪⁯‮‪‍‮‪‌‮(CoreObject.log, (object) ex);
                        num1 = (int) num3 * 447130546 ^ -375934836;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  return;
label_11:;
                }
              }));
              WindowManager.\u206F‍‌‍‪⁯​⁯‮‪‎‌​‫‏‌⁯⁯​⁫‏‏‏⁫⁬​‌⁮⁫‌‪⁬⁪‬‎⁫‬‏⁬‮‮(thread, ApartmentState.STA);
              num1 = (int) num3 * 289601134 ^ 777119885;
              continue;
            case 6:
              goto label_2;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_19:;
      }
      catch (Exception ex)
      {
label_12:
        int num1 = 1021439582;
        while (true)
        {
          int num2 = 733640867;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_10;
            case 1:
              num1 = (int) num3 * -1407333349 ^ -365070729;
              continue;
            case 2:
              num1 = (int) num3 * 1857251759 ^ 1471206449;
              continue;
            case 3:
              num1 = (int) num3 * -1262468020 ^ 897055575;
              continue;
            case 4:
              goto label_12;
            case 5:
              WindowManager.\u206C‍⁬‏‌‍‭⁯‪⁭⁮‪⁯⁭‮⁭‮⁭‬⁪‏‌‮⁫‭⁪⁪‫‭⁯⁯⁪‌⁬‮‮‮⁪‪‏‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 680937353 ^ -962373625;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_10:;
      }
    }

    private bool ContinueProcessing()
    {
label_1:
      int num1 = 1890068031;
      bool flag1;
      object windowLock;
      while (true)
      {
        int num2 = 1641626737;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            flag1 = false;
            num1 = (int) num3 * -1979325999 ^ 1862441836;
            continue;
          case 3:
            windowLock = WindowManager.windowLock;
            num1 = (int) num3 * -1559548375 ^ 1078756527;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag2 = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag2);
label_7:
        int num2 = 1176952208;
        while (true)
        {
          int num3 = 1641626737;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              num2 = (int) num4 * -1937958875 ^ 517571230;
              continue;
            case 2:
              flag1 = this.CancelRequested;
              num2 = (int) num4 * 285778757 ^ 674315139;
              continue;
            case 3:
              goto label_7;
            default:
              goto label_16;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_12:
          int num2 = 1412724721;
          while (true)
          {
            int num3 = 1641626737;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_12;
              case 1:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num2 = (int) num4 * -1735562553 ^ -290962218;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_16:
      if (!flag1)
        goto label_19;
label_17:
      int num5 = 474357412;
label_18:
      bool flag3;
      while (true)
      {
        int num2 = 1641626737;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 7U)
        {
          case 0:
            goto label_19;
          case 1:
            num5 = (int) num3 * -1528028312 ^ 1657600806;
            continue;
          case 2:
            flag3 = false;
            num5 = (int) num3 * 542444531 ^ -314854831;
            continue;
          case 3:
            flag3 = true;
            num5 = (int) num3 * 402956993 ^ 30930807;
            continue;
          case 4:
            num5 = (int) num3 * 1131257297 ^ 2119572816;
            continue;
          case 6:
            goto label_17;
          default:
            goto label_24;
        }
      }
label_24:
      return flag3;
label_19:
      num5 = 1255819035;
      goto label_18;
    }

    private bool DependenciesStarted()
    {
label_1:
      int num1 = -1956059243;
      object windowLock;
      while (true)
      {
        int num2 = -1999731642;
        uint num3;
        bool initialized;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            windowLock = WindowManager.windowLock;
            num1 = (int) num3 * -244018150 ^ 1006439688;
            continue;
          case 3:
            if (initialized)
            {
              num1 = (int) num3 * -1080986343 ^ 1347108081;
              continue;
            }
            goto label_29;
          case 4:
            num1 = (int) num3 * -1533398299 ^ 255233675;
            continue;
          case 5:
            initialized = this.Engine.HookManager.Initialized;
            num1 = (int) num3 * -591921876 ^ 471925805;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      bool flag1 = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag1);
label_10:
        int num2 = -248780849;
        while (true)
        {
          int num3 = -1999731642;
          uint num4;
          DateTime startTime;
          switch ((num4 = (uint) (num2 ^ num3)) % 9U)
          {
            case 0:
              num2 = (int) num4 * -1905565791 ^ -2052588966;
              continue;
            case 1:
              num2 = (int) num4 * 329827017 ^ -1104167865;
              continue;
            case 2:
              goto label_10;
            case 3:
              int num5 = !startTime.Equals(DateTime.MinValue) ? -1384081332 : (num5 = -1739389030);
              int num6 = (int) num4 * 8180782;
              num2 = num5 ^ num6;
              continue;
            case 4:
              this.StartTime = DateTime.Now;
              num2 = (int) num4 * 2084715073 ^ 607380451;
              continue;
            case 5:
              num2 = (int) num4 * 752587257 ^ -247507584;
              continue;
            case 6:
              num2 = -1388611175;
              continue;
            case 7:
              startTime = this.StartTime;
              num2 = (int) num4 * 753714044 ^ -1509788807;
              continue;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_20:
          int num2 = -1241303457;
          while (true)
          {
            int num3 = -1999731642;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_20;
              case 2:
                Monitor.Exit(windowLock);
                num2 = (int) num4 * -1935732659 ^ -1586750868;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:
      bool flag2 = true;
label_25:
      int num7 = -506983939;
label_26:
      while (true)
      {
        int num2 = -1999731642;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 6U)
        {
          case 0:
            goto label_29;
          case 1:
            num7 = (int) num3 * -1799644378 ^ -590226419;
            continue;
          case 2:
            num7 = (int) num3 * -265001393 ^ 1468535105;
            continue;
          case 4:
            goto label_25;
          case 5:
            flag2 = false;
            num7 = (int) num3 * -1594619548 ^ 1583466136;
            continue;
          default:
            goto label_31;
        }
      }
label_31:
      return flag2;
label_29:
      num7 = -1778071251;
      goto label_26;
    }

    private void CheckManyCamBroadcast()
    {
label_1:
      int num1 = -1512590266;
      object windowLock1;
      ZoomWindow zoomWindow;
      DateTime dateTime;
      while (true)
      {
        int num2 = -367328934;
        uint num3;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            flag1 = this.Engine.ActiveActivity == null;
            num1 = (int) num3 * 2060869598 ^ -1944507853;
            continue;
          case 2:
            if (flag2)
            {
              num1 = (int) num3 * -403357020 ^ 375491758;
              continue;
            }
            goto label_93;
          case 3:
            if (flag1)
            {
              num1 = (int) num3 * -1770431580 ^ -656695170;
              continue;
            }
            goto label_94;
          case 4:
            windowLock1 = WindowManager.windowLock;
            num1 = (int) num3 * 291251836 ^ -1075257818;
            continue;
          case 5:
            num4 = WindowManager.manyCamBroadLastAttempt.AddSeconds(5.0) < DateTime.Now ? 1 : 0;
            break;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -1820762196 ^ 623583736;
            continue;
          case 8:
            zoomWindow = (ZoomWindow) null;
            dateTime = DateTime.MinValue;
            num1 = (int) num3 * -2126441068 ^ -959299726;
            continue;
          case 9:
            num1 = (int) num3 * 1499996720 ^ -1767853961;
            continue;
          case 10:
            if (this.Engine.Settings.OpenManyCamBroadcastWhenNotOpen)
            {
              num1 = (int) num3 * 1749330581 ^ -1032254616;
              continue;
            }
            num4 = 0;
            break;
          default:
            goto label_17;
        }
        flag2 = num4 != 0;
        num1 = -814014606;
      }
label_93:
      return;
label_17:
      bool flag3 = false;
      try
      {
        Monitor.Enter(windowLock1, ref flag3);
label_19:
        int num2 = -165812985;
        while (true)
        {
          int num3 = -367328934;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 1:
              num2 = (int) num4 * 909892721 ^ 404349990;
              continue;
            case 2:
              num2 = (int) num4 * 564194066 ^ 2043526606;
              continue;
            case 3:
              goto label_19;
            case 4:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: method pointer
              zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__70_0 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__70_0 = new Func<ZoomWindow, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CCheckManyCamBroadcast\u003Eb__70_0)))));
              num2 = -106965836;
              continue;
            case 5:
              num2 = (int) num4 * -1556857849 ^ 996958721;
              continue;
            default:
              goto label_30;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_26:
          int num2 = -1701166839;
          while (true)
          {
            int num3 = -367328934;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_26;
              case 1:
                Monitor.Exit(windowLock1);
                num2 = (int) num4 * -1424707189 ^ 360255630;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
label_30:
      IntPtr window = WindowHelper.FindWindow(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2730031228U), "", 0);
label_31:
      int num5 = -1681327200;
      while (true)
      {
        int num2 = -367328934;
        uint num3;
        IntPtr processWindow;
        Rectangle rectangle;
        bool flag1;
        DateTime now;
        bool traceWindowEvents;
        Rectangle windowRectangle1;
        Rectangle windowRectangle2;
        int num4;
        switch ((num3 = (uint) (num5 ^ num2)) % 41U)
        {
          case 0:
            num5 = -290894068;
            continue;
          case 1:
            if (zoomWindow != null)
            {
              num5 = (int) num3 * 382458950 ^ -646845899;
              continue;
            }
            num4 = 0;
            break;
          case 2:
            num5 = (int) num3 * -1752862211 ^ -821114529;
            continue;
          case 3:
            CoreObject.log.Debug((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4059449170U));
            num5 = (int) num3 * -172790286 ^ -887662076;
            continue;
          case 4:
            flag1 = rectangle.IntersectsWith(windowRectangle1);
            num5 = (int) num3 * -2079799242 ^ -556111198;
            continue;
          case 5:
            num5 = (int) num3 * 1814480111 ^ 857210473;
            continue;
          case 6:
            windowRectangle1 = WindowHelper.GetWindowRectangle(this.Engine.MainProcessWindow);
            rectangle = new Rectangle(new System.Drawing.Point(0, 200), windowRectangle2.Size);
            num5 = (int) num3 * -1885374954 ^ 282312005;
            continue;
          case 7:
            WindowHelper.Move(processWindow, rectangle, true);
            num5 = -519093930;
            continue;
          case 8:
            int num6 = !traceWindowEvents ? -1770204138 : (num6 = -1912099723);
            int num7 = (int) num3 * 1698048495;
            num5 = num6 ^ num7;
            continue;
          case 9:
            CoreObject.log.Debug((object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1308749371U));
            num5 = (int) num3 * -1874170150 ^ -1079673760;
            continue;
          case 10:
            num5 = (int) num3 * -1816029357 ^ -1575217283;
            continue;
          case 11:
            num5 = -1456022270;
            continue;
          case 12:
            traceWindowEvents = this.Engine.Settings.TraceWindowEvents;
            num5 = (int) num3 * 498754905 ^ 913872252;
            continue;
          case 13:
            MouseHelper.ClickWindowPosition(processWindow, 7, 7, true, 0, true);
            num5 = (int) num3 * 995123766 ^ 116199757;
            continue;
          case 14:
            num5 = (int) num3 * 40843568 ^ 1189465906;
            continue;
          case 15:
            dateTime = now.AddSeconds(10.0);
            num5 = (int) num3 * 1675455252 ^ 201348339;
            continue;
          case 16:
            rectangle = windowRectangle1;
            rectangle.Location = new System.Drawing.Point(rectangle.X, rectangle.Bottom + 5);
            num5 = (int) num3 * 434723953 ^ -535765092;
            continue;
          case 17:
            num4 = zoomWindow.IsVisible ? 1 : 0;
            break;
          case 18:
            num5 = (int) num3 * -260978891 ^ 907460298;
            continue;
          case 19:
            WindowManager.manyCamBroadLastAttempt = DateTime.Now;
            num5 = (int) num3 * 1494453476 ^ -834102968;
            continue;
          case 20:
            num5 = (int) num3 * -2119500071 ^ -1899799851;
            continue;
          case 21:
            goto label_31;
          case 22:
            WindowHelper.Move(processWindow, windowRectangle2, true);
            num5 = (int) num3 * -1795578657 ^ 582070;
            continue;
          case 23:
            num5 = (int) num3 * -179095199 ^ -1052528738;
            continue;
          case 25:
            int num8 = processWindow.Equals((object) IntPtr.Zero) ? -1970013480 : (num8 = -582460162);
            int num9 = (int) num3 * 341416703;
            num5 = num8 ^ num9;
            continue;
          case 26:
            num5 = (int) num3 * -1573669495 ^ 601851964;
            continue;
          case 27:
            num5 = -600617223;
            continue;
          case 28:
            MouseHelper.ClickWindowPosition(processWindow, 58, 111, true, 150, true);
            num5 = (int) num3 * -318938922 ^ -579457190;
            continue;
          case 29:
            num5 = -40204458;
            continue;
          case 30:
            now = DateTime.Now;
            num5 = (int) num3 * -1237581422 ^ 151785844;
            continue;
          case 31:
            num5 = (int) num3 * 1215204978 ^ 2060216655;
            continue;
          case 32:
            now = DateTime.Now;
            dateTime = now.AddSeconds(5.0);
            num5 = (int) num3 * -480193025 ^ 1466191870;
            continue;
          case 33:
            if (window.Equals((object) IntPtr.Zero))
            {
              num5 = (int) num3 * 1654628532 ^ -904198856;
              continue;
            }
            num4 = 1;
            break;
          case 34:
            int num10 = this.Engine.Settings.TraceWindowEvents ? -1930317881 : (num10 = -1401552382);
            int num11 = (int) num3 * -1484848041;
            num5 = num10 ^ num11;
            continue;
          case 35:
            num5 = (int) num3 * 1979524589 ^ -1017458090;
            continue;
          case 36:
            processWindow = WindowHelper.GetProcessWindow(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2385537588U));
            num5 = (int) num3 * 1874437857 ^ 984100335;
            continue;
          case 37:
            int num12 = !flag1 ? -720480433 : (num12 = -485215194);
            int num13 = (int) num3 * 2134050259;
            num5 = num12 ^ num13;
            continue;
          case 38:
            num5 = (int) num3 * 386544773 ^ -393155083;
            continue;
          case 39:
            windowRectangle2 = WindowHelper.GetWindowRectangle(processWindow);
            num5 = -291894467;
            continue;
          case 40:
            Thread.Sleep(150);
            num5 = (int) num3 * -1597477350 ^ -2143850667;
            continue;
          default:
            goto label_77;
        }
        int num14;
        num5 = num14 = num4 != 0 ? -1274006700 : (num14 = -1451323818);
      }
label_77:
      object windowLock2 = WindowManager.windowLock;
      bool flag4 = false;
      try
      {
        Monitor.Enter(windowLock2, ref flag4);
label_79:
        int num2 = -1959184385;
        while (true)
        {
          int num3 = -367328934;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_79;
            case 2:
              num2 = (int) num4 * 727283532 ^ -1626925913;
              continue;
            default:
              goto label_83;
          }
        }
label_83:
        WindowManager.manyCamBroadLastAttempt = dateTime;
      }
      finally
      {
        if (flag4)
        {
label_85:
          int num2 = -1193658537;
          while (true)
          {
            int num3 = -367328934;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                Monitor.Exit(windowLock2);
                num2 = (int) num4 * -1564684026 ^ 612629623;
                continue;
              case 2:
                goto label_85;
              case 3:
                num2 = (int) num4 * 126486990 ^ 1508195852;
                continue;
              default:
                goto label_90;
            }
          }
        }
label_90:;
      }
label_91:
      int num15 = -2014344511;
label_92:
      int num16 = -367328934;
      uint num17;
      switch ((num17 = (uint) (num15 ^ num16)) % 3U)
      {
        case 0:
          goto label_91;
        case 1:
          return;
        case 2:
          break;
        default:
          return;
      }
label_94:
      num15 = -1459315190;
      goto label_92;
    }

    private void InspectWindows(SharedData sharedData)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003C\u003Ec__DisplayClass71_0 cDisplayClass710 = new WindowManager.\u003C\u003Ec__DisplayClass71_0();
label_1:
      int num1 = 1970285863;
      List<ZoomWindow> list1;
      while (true)
      {
        int num2 = 163014447;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 1:
            num4 = this.Engine.ActiveActivity == null ? 1 : 0;
            break;
          case 2:
            num1 = (int) num3 * 543774887 ^ 1103571477;
            continue;
          case 3:
            num1 = (int) num3 * -610275699 ^ -577727074;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            list1 = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__71_0 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__71_0 = new Func<ZoomWindow, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CInspectWindows\u003Eb__71_0)))))).ToList<ZoomWindow>();
            num1 = 1751180033;
            continue;
          case 5:
            goto label_1;
          case 6:
            if (this.Engine.ActiveMeeting == null)
            {
              num1 = (int) num3 * 1036341277 ^ -1484338212;
              continue;
            }
            num4 = 0;
            break;
          case 7:
            num1 = (int) num3 * 2009704009 ^ -1945389191;
            continue;
          case 8:
            if (flag)
            {
              num1 = (int) num3 * -304646548 ^ -702123073;
              continue;
            }
            goto label_46;
          default:
            goto label_14;
        }
        flag = num4 != 0;
        num1 = 1324959778;
      }
label_14:
      List<ZoomWindow>.Enumerator enumerator1 = list1.GetEnumerator();
      try
      {
label_18:
        int num2 = !enumerator1.MoveNext() ? 835518622 : (num2 = 2042967457);
        while (true)
        {
          int num3 = 163014447;
          uint num4;
          DateTime instantiated;
          bool flag;
          ZoomWindow current;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 14U)
          {
            case 0:
              num2 = 2042967457;
              continue;
            case 1:
              if (current.ZoomWindowType != ZoomWindowType.WaitingForHost)
              {
                num5 = 1;
                break;
              }
              num2 = (int) num4 * -479311737 ^ 655955563;
              continue;
            case 2:
              int num6 = current.IsVisible ? 753698196 : (num6 = 220030054);
              int num7 = (int) num4 * 781705847;
              num2 = num6 ^ num7;
              continue;
            case 3:
              current.Refresh(false, false);
              num2 = (int) num4 * -1587302934 ^ 33075751;
              continue;
            case 4:
              num5 = instantiated.AddSeconds(5.0) < DateTime.Now ? 1 : 0;
              break;
            case 5:
              current.Close(false, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3943910135U));
              num2 = (int) num4 * 937333748 ^ 541273375;
              continue;
            case 6:
              int num8 = !flag ? -651660427 : (num8 = -187060748);
              int num9 = (int) num4 * -672508170;
              num2 = num8 ^ num9;
              continue;
            case 8:
              num2 = (int) num4 * 1424586412 ^ 627870217;
              continue;
            case 9:
              if (current.ZoomWindowType != ZoomWindowType.WaitingForHost)
              {
                num5 = 0;
                break;
              }
              num2 = 877086892;
              continue;
            case 10:
              num2 = 1780875580;
              continue;
            case 11:
              goto label_18;
            case 12:
              current = enumerator1.Current;
              num2 = 1736996080;
              continue;
            case 13:
              instantiated = current.Instantiated;
              num2 = (int) num4 * -859877364 ^ -1348661909;
              continue;
            default:
              goto label_40;
          }
          flag = num5 != 0;
          num2 = 532264717;
        }
      }
      finally
      {
        enumerator1.Dispose();
label_36:
        int num2 = 713062246;
        while (true)
        {
          int num3 = 163014447;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_36;
            case 2:
              num2 = (int) num4 * 519885077 ^ 732332346;
              continue;
            default:
              goto label_39;
          }
        }
label_39:;
      }
label_40:
label_41:
      int num10 = 1280814153;
label_42:
      List<ZoomWindow> list2;
      while (true)
      {
        int num2 = 163014447;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num10 ^ num2)) % 17U)
        {
          case 0:
            int num4 = !flag2 ? 684992967 : (num4 = 263361806);
            int num5 = (int) num3 * 2064748760;
            num10 = num4 ^ num5;
            continue;
          case 1:
            num10 = (int) num3 * -105027833 ^ -829041949;
            continue;
          case 2:
            num10 = (int) num3 * -286802940 ^ 129201971;
            continue;
          case 3:
            goto label_46;
          case 4:
            goto label_53;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass710.staleInspections = DateTime.Now.AddSeconds(-2.0);
            num10 = (int) num3 * 2097753620 ^ 531285050;
            continue;
          case 7:
            if (flag1)
            {
              num10 = (int) num3 * -27623758 ^ -1862985112;
              continue;
            }
            goto label_72;
          case 8:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass710.staleInspections = DateTime.MinValue;
            num10 = 1173236183;
            continue;
          case 9:
            goto label_41;
          case 10:
            // ISSUE: method pointer
            list2 = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass710, __methodptr(\u003CInspectWindows\u003Eb__1)))).ToList<ZoomWindow>();
            flag1 = list2.Count > 0;
            num10 = 663382569;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass710.staleInspections = DateTime.Now.AddSeconds(-5.0);
            num10 = (int) num3 * 1820154685 ^ 1063399969;
            continue;
          case 12:
            num10 = (int) num3 * 175270352 ^ 1416288942;
            continue;
          case 13:
            num10 = (int) num3 * 1393275547 ^ 843595873;
            continue;
          case 14:
            num10 = (int) num3 * 917422874 ^ 1490587165;
            continue;
          case 15:
            num10 = (int) num3 * -535322287 ^ 469240335;
            continue;
          case 16:
            flag2 = this.Engine.ActiveActivity == null;
            num10 = 622881074;
            continue;
          default:
            goto label_62;
        }
      }
label_53:
      int num11 = this.Engine.ActiveActivity == null ? 1 : 0;
      goto label_55;
label_62:
      using (List<ZoomWindow>.Enumerator enumerator2 = list2.GetEnumerator())
      {
label_67:
        int num2 = !enumerator2.MoveNext() ? 1943961641 : (num2 = 38182746);
        while (true)
        {
          int num3 = 163014447;
          uint num4;
          ZoomWindow current;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = 38182746;
              continue;
            case 1:
              goto label_67;
            case 3:
              num2 = (int) num4 * 1265190564 ^ -1382458123;
              continue;
            case 4:
              current.RefreshLocation();
              num2 = (int) num4 * 1711337828 ^ -593727862;
              continue;
            case 5:
              current = enumerator2.Current;
              num2 = 78161288;
              continue;
            default:
              goto label_71;
          }
        }
      }
label_71:
label_72:
      ZoomWindow zoomWindow = (ZoomWindow) null;
      object windowLock = WindowManager.windowLock;
      bool flag3 = false;
      try
      {
        Monitor.Enter(windowLock, ref flag3);
label_74:
        int num2 = 1385617394;
        while (true)
        {
          int num3 = 163014447;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              zoomWindow = this.Engine.ActiveMeetingWindow;
              num2 = (int) num4 * -477918168 ^ -937164634;
              continue;
            case 1:
              num2 = (int) num4 * -238762944 ^ 1043725255;
              continue;
            case 2:
              goto label_74;
            case 3:
              num2 = (int) num4 * -952657136 ^ 1889138165;
              continue;
            default:
              goto label_86;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_80:
          int num2 = 154383862;
          while (true)
          {
            int num3 = 163014447;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_80;
              case 1:
                Monitor.Exit(windowLock);
                num2 = (int) num4 * -1212969215 ^ -1768494703;
                continue;
              case 3:
                num2 = (int) num4 * -596042278 ^ 1439767895;
                continue;
              default:
                goto label_85;
            }
          }
        }
label_85:;
      }
label_86:
      bool flag4 = zoomWindow != null;
label_87:
      int num12 = 949382024;
      while (true)
      {
        int num2 = 163014447;
        uint num3;
        switch ((num3 = (uint) (num12 ^ num2)) % 5U)
        {
          case 0:
            num12 = (int) num3 * 834211317 ^ 299087920;
            continue;
          case 1:
            int num4 = !flag4 ? -11902426 : (num4 = -609225888);
            int num5 = (int) num3 * -2582825;
            num12 = num4 ^ num5;
            continue;
          case 2:
            goto label_89;
          case 3:
            goto label_87;
          case 4:
            this.CreateChildWindows(zoomWindow.Handle);
            num12 = (int) num3 * 1060147940 ^ 1346518732;
            continue;
          default:
            goto label_82;
        }
      }
label_82:
      return;
label_89:
      return;
label_46:
      if (this.Engine.ActiveMeeting != null)
      {
        num10 = 1160678268;
        goto label_42;
      }
      else
        num11 = 0;
label_55:
      int num13;
      num10 = num13 = num11 != 0 ? 1618666562 : (num13 = 1889748693);
      goto label_42;
    }

    private void CreateChildWindows(IntPtr windowHandle)
    {
label_1:
      int num1 = 607295666;
      List<IntPtr> childWindows;
      while (true)
      {
        int num2 = 2029505351;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            childWindows = WindowHelper.GetChildWindows(windowHandle);
            num1 = (int) num3 * 1509206489 ^ 1244535456;
            continue;
          case 2:
            num1 = (int) num3 * 1465000651 ^ 1334331949;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      List<IntPtr>.Enumerator enumerator = childWindows.GetEnumerator();
      try
      {
label_20:
        int num2 = enumerator.MoveNext() ? 1472500997 : (num2 = 60805822);
        while (true)
        {
          int num3 = 2029505351;
          uint num4;
          // ISSUE: variable of a compiler-generated type
          WindowManager.\u003C\u003Ec__DisplayClass72_0 cDisplayClass720;
          ZoomWindow window;
          switch ((num4 = (uint) (num2 ^ num3)) % 17U)
          {
            case 0:
              num2 = 1472500997;
              continue;
            case 1:
              num2 = (int) num4 * -1947430507 ^ -30055762;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              this.CreateChildWindows(cDisplayClass720.child);
              num2 = (int) num4 * 516155820 ^ 247046048;
              continue;
            case 3:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass720 = new WindowManager.\u003C\u003Ec__DisplayClass72_0();
              num2 = 2071105426;
              continue;
            case 4:
              num2 = 1327433049;
              continue;
            case 5:
              this.SharedData.ActiveWindows.Add(window);
              num2 = (int) num4 * -120135060 ^ 1567756636;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              window = ZoomFactory.CreateWindow(cDisplayClass720.child);
              num2 = (int) num4 * 508802161 ^ 167720442;
              continue;
            case 7:
              num2 = (int) num4 * 1694934375 ^ -83186750;
              continue;
            case 8:
              goto label_28;
            case 9:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass720.child = enumerator.Current;
              int num5 = WindowHelper.IsValid(windowHandle) ? -756218218 : (num5 = -218360551);
              int num6 = (int) num4 * -1031947911;
              num2 = num5 ^ num6;
              continue;
            case 10:
              num2 = (int) num4 * -1535183408 ^ -249113023;
              continue;
            case 11:
              int num7 = window != null ? -1242069815 : (num7 = -1518372775);
              int num8 = (int) num4 * 1255382920;
              num2 = num7 ^ num8;
              continue;
            case 12:
              num2 = 1677956472;
              continue;
            case 13:
              goto label_20;
            case 14:
              int num9;
              // ISSUE: method pointer
              num2 = num9 = !Enumerable.Any<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass720, __methodptr(\u003CCreateChildWindows\u003Eb__0))) ? 540214506 : (num9 = 1677956472);
              continue;
            case 15:
              goto label_24;
            case 16:
              num2 = (int) num4 * -1580921128 ^ -849429514;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_24:
        return;
label_28:;
      }
      finally
      {
        enumerator.Dispose();
label_26:
        int num2 = 1530299479;
        while (true)
        {
          int num3 = 2029505351;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_26;
            case 2:
              num2 = (int) num4 * -1402346097 ^ 1176597809;
              continue;
            default:
              goto label_30;
          }
        }
label_30:;
      }
    }

    internal List<ZoomWindow> GetVideoWindows()
    {
label_1:
      int num1 = -382021267;
      object windowLock;
      while (true)
      {
        int num2 = -400847237;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            windowLock = this.WindowLock;
            num1 = (int) num3 * -2001944133 ^ 342041156;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      List<ZoomWindow> list;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
label_6:
        int num2 = -1891648406;
        while (true)
        {
          int num3 = -400847237;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_6;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: method pointer
              list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__73_0 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__73_0 = new Func<ZoomWindow, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CGetVideoWindows\u003Eb__73_0)))))).ToList<ZoomWindow>();
              num2 = -224346453;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_10:
          int num2 = -637189346;
          while (true)
          {
            int num3 = -400847237;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_10;
              case 1:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num2 = (int) num4 * -1041984384 ^ 1594080364;
                continue;
              case 3:
                num2 = (int) num4 * -612183481 ^ -454579280;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      return list;
    }

    private void ManageWindowLayouts(ZoomEvent zoomEvent)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003C\u003Ec__DisplayClass74_0 cDisplayClass740 = new WindowManager.\u003C\u003Ec__DisplayClass74_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass740.zoomEvent = zoomEvent;
      if (this.Engine.ActivePattern == null)
        return;
label_1:
      int num1 = 2018894161;
      List<ZoomWindow> list;
      while (true)
      {
        int num2 = 1892843048;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            int num4 = !flag ? -714107676 : (num4 = -112229819);
            int num5 = (int) num3 * 1702358596;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * -43705207 ^ -1308465184;
            continue;
          case 2:
            num1 = (int) num3 * -1136200857 ^ -1550641967;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass740.zoomEvent.Window.RefreshLocation();
            num1 = (int) num3 * 784432058 ^ 868590338;
            continue;
          case 5:
            num1 = (int) num3 * 1775258610 ^ 1995122900;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass740.zoomEvent.Window.Pattern = this.Engine.ActivePattern;
            num1 = (int) num3 * -919597663 ^ -107263357;
            continue;
          case 7:
            // ISSUE: method pointer
            list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass740, __methodptr(\u003CManageWindowLayouts\u003Eb__0)))).ToList<ZoomWindow>();
            num1 = 1135663379;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            flag = cDisplayClass740.zoomEvent.Window != null;
            num1 = (int) num3 * 45858769 ^ 738325685;
            continue;
          case 9:
            num1 = (int) num3 * -947426015 ^ -87180427;
            continue;
          case 10:
            num1 = (int) num3 * 785705119 ^ -1460028796;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass740.zoomEvent.Window.SetWindowTypes(true);
            num1 = (int) num3 * -676920465 ^ -1984815424;
            continue;
          case 12:
            goto label_1;
          default:
            goto label_14;
        }
      }
label_14:
      List<ZoomWindow>.Enumerator enumerator = list.GetEnumerator();
      try
      {
label_18:
        int num2 = enumerator.MoveNext() ? 371040494 : (num2 = 1471872946);
        while (true)
        {
          int num3 = 1892843048;
          uint num4;
          ZoomWindow current;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              num2 = 371040494;
              continue;
            case 1:
              goto label_18;
            case 3:
              current.RefreshLocation();
              num2 = (int) num4 * 888414895 ^ -864457552;
              continue;
            case 4:
              current.Pattern = this.Engine.ActivePattern;
              num2 = (int) num4 * 1218193828 ^ -145343141;
              continue;
            case 5:
              num2 = (int) num4 * -1593492428 ^ -2036778499;
              continue;
            case 6:
              current = enumerator.Current;
              num2 = 690899359;
              continue;
            case 7:
              current.SetWindowTypes(true);
              num2 = (int) num4 * 969608093 ^ -169027129;
              continue;
            default:
              goto label_30;
          }
        }
      }
      finally
      {
        enumerator.Dispose();
label_25:
        int num2 = 1416071375;
        while (true)
        {
          int num3 = 1892843048;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_25;
            case 1:
              num2 = (int) num4 * -1815405066 ^ 1912744475;
              continue;
            default:
              goto label_29;
          }
        }
label_29:;
      }
label_30:;
    }

    private void KeyboardHookManager_MouseClick(object sender, MouseEventArgs e)
    {
label_1:
      int num1 = -1576695407;
      while (true)
      {
        int num2 = -1709170246;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            this.lastClickPosition = WindowManager.\u202D​⁭‏‍‪‍⁬⁮‎‬⁯​‫‫​⁮‍‏‌‍‪‬‫‭‬⁬‍‮‭⁭‏⁯⁭‎‪​‫‎⁭‮(e);
            num1 = (int) num3 * 962572232 ^ 1030852268;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      WindowManager.\u206B⁮‮⁯⁭⁬⁬⁭‌‎⁪‬⁬‪⁬⁭‌⁯⁮‌⁮⁫⁪⁮⁪‌⁮‮‏‎⁪‎⁭‮‮⁬⁪‮⁮⁮‮(new WaitCallback(this.CaptureLastWindowClick), (object) WindowManager.\u202D​⁭‏‍‪‍⁬⁮‎‬⁯​‫‫​⁮‍‏‌‍‪‬‫‭‬⁬‍‮‭⁭‏⁯⁭‎‪​‫‎⁭‮(e));
    }

    private void CaptureLastWindowClick(object clickPoint)
    {
      POINT lpPoint = new POINT();
      lpPoint.x = this.lastClickPosition.X;
label_1:
      int num1 = -1687136163;
      ZoomWindow window;
      object windowLock;
      while (true)
      {
        int num2 = -399925770;
        uint num3;
        bool flag1;
        IntPtr handle;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 1:
            handle = User32.WindowFromPoint(lpPoint);
            num1 = (int) num3 * -241407096 ^ -465008269;
            continue;
          case 2:
            window = ZoomFactory.CreateWindow(handle);
            flag1 = window != null;
            num1 = (int) num3 * -53421214 ^ 417757576;
            continue;
          case 3:
            goto label_1;
          case 4:
            lpPoint.y = this.lastClickPosition.Y;
            num1 = (int) num3 * 2093787773 ^ -1531600023;
            continue;
          case 5:
            if (flag1)
            {
              num1 = (int) num3 * 307201949 ^ -1465557142;
              continue;
            }
            goto label_32;
          case 6:
            if (flag2)
            {
              num1 = (int) num3 * 265566318 ^ 988729543;
              continue;
            }
            goto label_31;
          case 7:
            num1 = (int) num3 * 1272647626 ^ 1207549244;
            continue;
          case 8:
            flag2 = !handle.Equals((object) new IntPtr(0));
            num1 = (int) num3 * -1800436746 ^ 262365200;
            continue;
          case 9:
            windowLock = WindowManager.windowLock;
            num1 = (int) num3 * 1157132512 ^ -1701672450;
            continue;
          case 10:
            num1 = (int) num3 * 1455155561 ^ -1054289965;
            continue;
          default:
            goto label_14;
        }
      }
label_31:
      return;
label_14:
      bool flag = false;
      try
      {
        Monitor.Enter(windowLock, ref flag);
label_16:
        int num2 = -1411313695;
        while (true)
        {
          int num3 = -399925770;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              this.lastClickWindow = window;
              this.lastClickTime = DateTime.Now;
              num2 = (int) num4 * 64510936 ^ 121501279;
              continue;
            case 1:
              num2 = (int) num4 * -1119201025 ^ 1731950003;
              continue;
            case 3:
              goto label_16;
            case 4:
              num2 = (int) num4 * -1835080953 ^ -1806563402;
              continue;
            default:
              goto label_28;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_23:
          int num2 = -644464673;
          while (true)
          {
            int num3 = -399925770;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_23;
              case 2:
                Monitor.Exit(windowLock);
                num2 = (int) num4 * -811020110 ^ 1611387363;
                continue;
              default:
                goto label_27;
            }
          }
        }
label_27:;
      }
label_28:
label_29:
      int num5 = -306680990;
label_30:
      int num6 = -399925770;
      uint num7;
      switch ((num7 = (uint) (num5 ^ num6)) % 3U)
      {
        case 0:
          return;
        case 1:
          break;
        case 2:
          goto label_29;
        default:
          return;
      }
label_32:
      num5 = -1509061289;
      goto label_30;
    }

    private void CheckMainWindowHandle()
    {
      if (this.mainHandle.Equals((object) IntPtr.Zero))
        goto label_4;
label_1:
      int num1 = -193982883;
label_2:
      bool flag1;
      object windowLock1;
      while (true)
      {
        int num2 = -1361221789;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 1278848211 ^ -386219226;
            continue;
          case 1:
            windowLock1 = WindowManager.windowLock;
            num1 = (int) num3 * 2087147817 ^ 975441489;
            continue;
          case 2:
            goto label_1;
          case 4:
            goto label_3;
          case 5:
            if (flag1)
            {
              num1 = (int) num3 * 342806511 ^ 1119634092;
              continue;
            }
            goto label_34;
          default:
            goto label_10;
        }
      }
label_3:
      int num4 = !this.mainHandleLoaded ? 1 : 0;
      goto label_5;
label_10:
      bool flag2 = false;
      try
      {
        Monitor.Enter(windowLock1, ref flag2);
label_12:
        int num2 = -537574715;
        while (true)
        {
          int num3 = -1361221789;
          uint num5;
          bool flag3;
          ZoomWindow window;
          bool flag4;
          switch ((num5 = (uint) (num2 ^ num3)) % 15U)
          {
            case 0:
              int num6 = flag4 ? -829145304 : (num6 = -1356907288);
              int num7 = (int) num5 * -2062923636;
              num2 = num6 ^ num7;
              continue;
            case 1:
              num2 = (int) num5 * 1039056740 ^ 392717932;
              continue;
            case 2:
              window = ZoomFactory.CreateWindow(this.mainHandle);
              num2 = (int) num5 * 1796132750 ^ 1572800947;
              continue;
            case 3:
              this.SharedData.ActiveWindows.Add(window);
              num2 = (int) num5 * 1209852346 ^ -75913493;
              continue;
            case 4:
              this.mainHandleLoaded = true;
              num2 = -1132134773;
              continue;
            case 5:
              num2 = -1132134773;
              continue;
            case 6:
              num2 = (int) num5 * 372771136 ^ -845553637;
              continue;
            case 7:
              flag3 = window != null;
              num2 = (int) num5 * 842615986 ^ -1925884955;
              continue;
            case 8:
              num2 = (int) num5 * 912835156 ^ 11929736;
              continue;
            case 9:
              this.mainHandleLoaded = true;
              num2 = (int) num5 * 1966108385 ^ -363439976;
              continue;
            case 10:
              int num8 = !flag3 ? 2109076436 : (num8 = 188013285);
              int num9 = (int) num5 * -1550865966;
              num2 = num8 ^ num9;
              continue;
            case 11:
              num2 = (int) num5 * 1857462089 ^ -316019634;
              continue;
            case 13:
              // ISSUE: method pointer
              flag4 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) this, __methodptr(\u003CCheckMainWindowHandle\u003Eb__77_0))) == null;
              num2 = (int) num5 * 1922490593 ^ 1245269277;
              continue;
            case 14:
              goto label_12;
            default:
              goto label_33;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_28:
          int num2 = -1218273991;
          while (true)
          {
            int num3 = -1361221789;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_28;
              case 2:
                Monitor.Exit(windowLock1);
                num2 = (int) num5 * -822574908 ^ 1100878732;
                continue;
              case 3:
                num2 = (int) num5 * 2036341346 ^ 828016428;
                continue;
              default:
                goto label_32;
            }
          }
        }
label_32:;
      }
label_33:
label_34:
      object windowLock2 = WindowManager.windowLock;
      bool flag5 = false;
      try
      {
        Monitor.Enter(windowLock2, ref flag5);
label_36:
        int num2 = -1620953993;
        while (true)
        {
          int num3 = -1361221789;
          uint num5;
          switch ((num5 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_36;
            case 1:
              goto label_46;
            case 2:
              this.Initialized = true;
              num2 = (int) num5 * 98856271 ^ 35858690;
              continue;
            case 3:
              num2 = (int) num5 * -738974938 ^ -1517269872;
              continue;
            case 4:
              num2 = (int) num5 * -538342860 ^ -620588699;
              continue;
            case 5:
              num2 = (int) num5 * 1822829035 ^ 201666413;
              continue;
            default:
              goto label_42;
          }
        }
label_42:
        return;
label_46:
        return;
      }
      finally
      {
        if (flag5)
        {
label_44:
          int num2 = -1751884931;
          while (true)
          {
            int num3 = -1361221789;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_44;
              case 1:
                num2 = (int) num5 * -1036572352 ^ 2008182872;
                continue;
              case 2:
                Monitor.Exit(windowLock2);
                num2 = (int) num5 * 282782819 ^ 884889276;
                continue;
              default:
                goto label_49;
            }
          }
        }
label_49:;
      }
label_4:
      num4 = 0;
label_5:
      flag1 = num4 != 0;
      num1 = -2056302534;
      goto label_2;
    }

    private void LoadMainApplicationWindow()
    {
      object windowLock = WindowManager.windowLock;
      bool flag = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
label_2:
        int num1 = -77525022;
        while (true)
        {
          int num2 = -346755818;
          uint num3;
          ZoomWindow window;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * -1065354253 ^ 1967894973;
              continue;
            case 1:
              this.SharedData.ActiveWindows.Add(window);
              num1 = (int) num3 * 1181154498 ^ -1527363718;
              continue;
            case 2:
              window = ZoomFactory.CreateWindow(this.Engine.MainProcessWindow);
              int num4 = window == null ? -1898430834 : (num4 = -380050421);
              int num5 = (int) num3 * -1358213228;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 2022220753 ^ 179249317;
              continue;
            case 4:
              num1 = -699989691;
              continue;
            case 5:
              num1 = (int) num3 * -143722495 ^ -1719314640;
              continue;
            case 6:
              goto label_15;
            case 7:
              num1 = (int) num3 * -1300342262 ^ -2126386003;
              continue;
            case 8:
              goto label_2;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_15:;
      }
      finally
      {
        if (flag)
        {
label_13:
          int num1 = -1636352790;
          while (true)
          {
            int num2 = -346755818;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num1 = (int) num3 * 295715265 ^ -119525474;
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
    }

    internal void RegisterWindow(IntPtr handle, ZoomWindowType windowType)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003C\u003Ec__DisplayClass79_0 cDisplayClass790 = new WindowManager.\u003C\u003Ec__DisplayClass79_0();
label_1:
      int num1 = -1072105300;
      while (true)
      {
        int num2 = -1489701187;
        uint num3;
        bool flag;
        ZoomWindow zoomWindow;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 621932307 ^ -131474531;
            continue;
          case 1:
            // ISSUE: method pointer
            zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass790, __methodptr(\u003CRegisterWindow\u003Eb__0)));
            num1 = (int) num3 * -1020088575 ^ 2069574988;
            continue;
          case 2:
            goto label_1;
          case 3:
            if (zoomWindow == null)
            {
              num1 = (int) num3 * -144525248 ^ -1394407206;
              continue;
            }
            goto label_35;
          case 4:
            if (flag)
            {
              num1 = (int) num3 * -544677173 ^ 304791695;
              continue;
            }
            goto label_34;
          case 6:
            num1 = (int) num3 * -1298704602 ^ 136969771;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass790.handle = handle;
            num1 = (int) num3 * -2002512606 ^ -1519115464;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            flag = !cDisplayClass790.handle.Equals((object) IntPtr.Zero);
            num1 = (int) num3 * -300382326 ^ 422604310;
            continue;
          default:
            goto label_12;
        }
      }
label_34:
      return;
label_12:
      object windowLock = WindowManager.windowLock;
      bool flag1 = false;
      try
      {
        Monitor.Enter(windowLock, ref flag1);
label_14:
        int num2 = -40771011;
        while (true)
        {
          int num3 = -1489701187;
          uint num4;
          ZoomWindow window;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              goto label_14;
            case 1:
              this.SharedData.ActiveWindows.Add(window);
              num2 = (int) num4 * -1311166416 ^ -1737609230;
              continue;
            case 2:
              int num5 = flag2 ? 325503806 : (num5 = 759602842);
              int num6 = (int) num4 * -962644921;
              num2 = num5 ^ num6;
              continue;
            case 3:
              flag2 = window != null;
              num2 = (int) num4 * 86107510 ^ 1164204161;
              continue;
            case 4:
              num2 = (int) num4 * 1676478754 ^ -212875164;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              window = ZoomFactory.CreateWindow(cDisplayClass790.handle);
              num2 = (int) num4 * 799257431 ^ -27073294;
              continue;
            case 7:
              num2 = (int) num4 * 150650207 ^ -1173251261;
              continue;
            case 8:
              num2 = (int) num4 * -35281726 ^ -126196021;
              continue;
            case 9:
              num2 = (int) num4 * 614498837 ^ 888044182;
              continue;
            default:
              goto label_31;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_26:
          int num2 = -1568907798;
          while (true)
          {
            int num3 = -1489701187;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_26;
              case 2:
                Monitor.Exit(windowLock);
                num2 = (int) num4 * -1523339445 ^ -2030938708;
                continue;
              default:
                goto label_30;
            }
          }
        }
label_30:;
      }
label_31:
label_32:
      int num7 = -236843376;
label_33:
      int num8 = -1489701187;
      uint num9;
      switch ((num9 = (uint) (num7 ^ num8)) % 3U)
      {
        case 0:
          goto label_32;
        case 1:
          return;
        case 2:
          break;
        default:
          return;
      }
label_35:
      num7 = -597515211;
      goto label_33;
    }

    private void DistributeEventsToListeners(ZoomEvent windowEvent)
    {
      try
      {
        ZoomWindowEventArgs zoomWindowEventArgs = new ZoomWindowEventArgs(windowEvent.Window);
label_2:
        int num1 = -781478501;
        while (true)
        {
          int num2 = -542054169;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          int num5;
          int num6;
          int num7;
          switch ((num3 = (uint) (num1 ^ num2)) % 31U)
          {
            case 0:
              num1 = (int) num3 * 801775835 ^ 1705222166;
              continue;
            case 1:
              if (windowEvent.EventType != ZoomEventType.LocationChanged)
              {
                num4 = 0;
                goto label_45;
              }
              else
              {
                num1 = (int) num3 * 1803742946 ^ 1235167687;
                continue;
              }
            case 2:
              if (windowEvent.EventType != ZoomEventType.Show)
              {
                num1 = (int) num3 * 1338202717 ^ 623860156;
                continue;
              }
              num5 = 1;
              goto label_37;
            case 3:
              num1 = (int) num3 * -107428295 ^ 38893846;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              this.OnWindowDestroyed((object) this, (EventArgs) zoomWindowEventArgs);
              num1 = (int) num3 * 1523273341 ^ -1706614141;
              continue;
            case 5:
              num1 = (int) num3 * 240772490 ^ 88917752;
              continue;
            case 6:
              int num8 = !flag1 ? 1564098686 : (num8 = 1087007772);
              int num9 = (int) num3 * -2067892197;
              num1 = num8 ^ num9;
              continue;
            case 7:
              num1 = (int) num3 * 300823340 ^ -477686877;
              continue;
            case 8:
              int num10;
              num1 = num10 = windowEvent.EventType != ZoomEventType.MoveSize ? -1771525568 : (num10 = -1389416279);
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              flag1 = this.OnWindowStateChange != null;
              num1 = -722377284;
              continue;
            case 10:
              if (windowEvent.EventType == ZoomEventType.Destroy)
              {
                num1 = -1061531723;
                continue;
              }
              num6 = 0;
              goto label_50;
            case 11:
              // ISSUE: reference to a compiler-generated field
              num4 = this.OnWindowMoved != null ? 1 : 0;
              goto label_45;
            case 12:
              // ISSUE: reference to a compiler-generated field
              num6 = this.OnWindowDestroyed != null ? 1 : 0;
              goto label_50;
            case 13:
              // ISSUE: reference to a compiler-generated field
              this.OnWindowCreated((object) this, (EventArgs) zoomWindowEventArgs);
              num1 = (int) num3 * -44617778 ^ -548820830;
              continue;
            case 14:
              num1 = -494087961;
              continue;
            case 15:
              num1 = (int) num3 * -51453515 ^ 28710128;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              this.OnWindowStateChange((object) this, (EventArgs) zoomWindowEventArgs);
              num1 = (int) num3 * 865386153 ^ 660674659;
              continue;
            case 17:
              // ISSUE: reference to a compiler-generated field
              num7 = this.OnWindowCreated != null ? 1 : 0;
              break;
            case 18:
              num1 = (int) num3 * 1384714947 ^ 1240450863;
              continue;
            case 19:
              if (windowEvent.EventType != ZoomEventType.Create)
              {
                num7 = 0;
                break;
              }
              num1 = (int) num3 * -524530002 ^ 1872058640;
              continue;
            case 20:
              goto label_2;
            case 21:
              if (windowEvent.ZoomWindowType == ZoomWindowType.WaitingForHost)
              {
                num1 = (int) num3 * -775334587 ^ 1924226778;
                continue;
              }
              num5 = 0;
              goto label_37;
            case 22:
              num5 = windowEvent.EventType == ZoomEventType.Hide ? 1 : 0;
              goto label_37;
            case 23:
              num1 = (int) num3 * 71422677 ^ 111757899;
              continue;
            case 24:
              num1 = (int) num3 * 306472544 ^ 1931551230;
              continue;
            case 25:
              num1 = -181333688;
              continue;
            case 26:
              int num11 = flag2 ? -1983165116 : (num11 = -683367807);
              int num12 = (int) num3 * -1172338856;
              num1 = num11 ^ num12;
              continue;
            case 27:
              // ISSUE: reference to a compiler-generated field
              this.OnWindowMoved((object) this, (EventArgs) zoomWindowEventArgs);
              num1 = (int) num3 * -2042363770 ^ 476461607;
              continue;
            case 28:
              goto label_35;
            case 29:
              if (windowEvent.ZoomWindowType == ZoomWindowType.WaitingForHost)
              {
                num1 = (int) num3 * 605002001 ^ 196938548;
                continue;
              }
              num5 = 1;
              goto label_37;
            case 30:
              num1 = (int) num3 * 2060950824 ^ -1397636633;
              continue;
            default:
              goto label_33;
          }
          int num13;
          num1 = num13 = num7 != 0 ? -8674058 : (num13 = -1054477562);
          continue;
label_37:
          int num14;
          num1 = num14 = num5 != 0 ? -102316956 : (num14 = -12711625);
          continue;
label_45:
          int num15;
          num1 = num15 = num4 == 0 ? -569059536 : (num15 = -1000384637);
          continue;
label_50:
          flag2 = num6 != 0;
          num1 = -1174558785;
        }
label_33:
        return;
label_35:;
      }
      catch (Exception ex)
      {
        WindowManager.\u206C‍⁬‏‌‍‭⁯‪⁭⁮‪⁯⁭‮⁭‮⁭‬⁪‏‌‮⁫‭⁪⁪‫‭⁯⁯⁪‌⁬‮‮‮⁪‪‏‮(CoreObject.log, (object) ex);
      }
    }

    private void DistributeZoomEvent(ZoomEvent windowEvent)
    {
label_1:
      int num1 = -308584979;
      while (true)
      {
        int num2 = -772865349;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            windowEvent.Window.ProcessEvent(windowEvent);
            num1 = (int) num3 * 668660260 ^ -1795791065;
            continue;
          case 1:
            num1 = (int) num3 * -1509410735 ^ 37041032;
            continue;
          case 2:
            int num5 = flag ? 1331924843 : (num5 = 1478891055);
            int num6 = (int) num3 * 720130916;
            num1 = num5 ^ num6;
            continue;
          case 3:
            flag = windowEvent.Window != null;
            num1 = -1046541750;
            continue;
          case 4:
            this.Initialized = true;
            num1 = (int) num3 * 510627163 ^ 39509778;
            continue;
          case 5:
            num1 = (int) num3 * 1122142898 ^ 1972118211;
            continue;
          case 6:
            num1 = (int) num3 * 513421151 ^ -736886449;
            continue;
          case 7:
            num1 = (int) num3 * 2022390838 ^ -1302502167;
            continue;
          case 8:
            num4 = windowEvent.ZoomWindowType == ZoomWindowType.Video ? 1 : 0;
            break;
          case 9:
            goto label_1;
          case 11:
            num1 = (int) num3 * 1851984081 ^ 451017844;
            continue;
          case 12:
            int num7 = !this.Initialized ? -527985513 : (num7 = -446916270);
            int num8 = (int) num3 * -580426835;
            num1 = num7 ^ num8;
            continue;
          case 13:
            this.Engine.ActiveMeeting.UpdateMeetingVideo(windowEvent);
            num1 = (int) num3 * 1015832137 ^ 1950861076;
            continue;
          case 14:
            if (this.Engine.ActiveMeeting == null)
            {
              num4 = 0;
              break;
            }
            num1 = -157142670;
            continue;
          default:
            goto label_19;
        }
        int num9;
        num1 = num9 = num4 == 0 ? -621683255 : (num9 = -149112791);
      }
label_19:
      try
      {
label_21:
        int num2 = -2146762078;
        while (true)
        {
          int num3 = -772865349;
          uint num4;
          ZoomEventType eventType;
          switch ((num4 = (uint) (num2 ^ num3)) % 24U)
          {
            case 0:
              num2 = (int) num4 * 808356739 ^ 1252459431;
              continue;
            case 1:
              eventType = windowEvent.EventType;
              num2 = (int) num4 * 1774587669 ^ -706858848;
              continue;
            case 2:
              num2 = (int) num4 * -1936439619 ^ 664066253;
              continue;
            case 3:
label_34:
              this.DestroyWindow(windowEvent);
              num2 = -1594139383;
              continue;
            case 4:
            case 8:
            case 20:
label_26:
              num2 = -934608208;
              continue;
            case 5:
              num2 = (int) num4 * 1804242335 ^ 289036852;
              continue;
            case 6:
              num2 = (int) num4 * 1914136940 ^ -618499561;
              continue;
            case 7:
label_25:
              this.CreateWindow(windowEvent);
              num2 = -1217227396;
              continue;
            case 9:
label_32:
              this.StateChangeWindow(windowEvent);
              num2 = -366929938;
              continue;
            case 10:
              num2 = (int) num4 * -705648028 ^ 988908797;
              continue;
            case 12:
              num2 = (int) num4 * -34591565 ^ -917236613;
              continue;
            case 13:
label_38:
              this.ReorderWindow(windowEvent);
              num2 = -1539662431;
              continue;
            case 14:
              switch (eventType)
              {
                case ZoomEventType.Other:
                case ZoomEventType.Hide:
                  goto label_26;
                case ZoomEventType.Create:
                  goto label_25;
                case ZoomEventType.Destroy:
                  goto label_34;
                case ZoomEventType.LocationChanged:
                  goto label_43;
                case ZoomEventType.Show:
                  goto label_40;
                case ZoomEventType.Reorder:
                  goto label_38;
                case ZoomEventType.Focus:
                  goto label_39;
                case ZoomEventType.MoveSize:
                  goto label_30;
                case ZoomEventType.StateChange:
                  goto label_32;
                default:
                  num2 = (int) num4 * 1162747422 ^ -69888694;
                  continue;
              }
            case 15:
              num2 = (int) num4 * 766848310 ^ 628690221;
              continue;
            case 16:
label_30:
              this.MoveSizeWindow(windowEvent);
              num2 = -1762288781;
              continue;
            case 17:
label_40:
              this.ShowWindow(windowEvent);
              num2 = -1129624833;
              continue;
            case 18:
label_43:
              this.MoveWindow(windowEvent);
              num2 = -1129624833;
              continue;
            case 19:
              num2 = (int) num4 * -1299194621 ^ 570408590;
              continue;
            case 21:
              num2 = (int) num4 * -1984695252 ^ -778710781;
              continue;
            case 22:
label_39:
              this.FocusWindow(windowEvent);
              num2 = -913117504;
              continue;
            case 23:
              goto label_21;
            default:
              goto label_49;
          }
        }
      }
      catch (Exception ex)
      {
label_45:
        int num2 = -303002106;
        while (true)
        {
          int num3 = -772865349;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_45;
            case 1:
              num2 = (int) num4 * -1634258933 ^ -617479414;
              continue;
            case 2:
              WindowManager.\u206C‍⁬‏‌‍‭⁯‪⁭⁮‪⁯⁭‮⁭‮⁭‬⁪‏‌‮⁫‭⁪⁪‫‭⁯⁯⁪‌⁬‮‮‮⁪‪‏‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * -553840535 ^ -1202569970;
              continue;
            default:
              goto label_49;
          }
        }
      }
label_49:
      this.UpdateActivityQueue(windowEvent);
    }

    internal void HandleNewMeetingAttendee()
    {
label_1:
      int num1 = 485255046;
      object windowLock;
      while (true)
      {
        int num2 = 298595443;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            windowLock = WindowManager.windowLock;
            num1 = (int) num3 * -105954060 ^ -1445638579;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
label_6:
        int num2 = 976924144;
        while (true)
        {
          int num3 = 298595443;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_14;
            case 2:
              num2 = (int) num4 * -756134172 ^ 1421460946;
              continue;
            case 3:
              num2 = (int) num4 * -449386440 ^ -1529611435;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:;
      }
      finally
      {
        if (flag)
        {
label_12:
          int num2 = 1051947616;
          while (true)
          {
            int num3 = 298595443;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_12;
              case 2:
                num2 = (int) num4 * -1538757688 ^ -1925004542;
                continue;
              case 3:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num2 = (int) num4 * 2070828736 ^ -1913455279;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    internal override void Cancel()
    {
      object windowLock = this.WindowLock;
      bool flag = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
label_2:
        int num1 = 1591589187;
        while (true)
        {
          int num2 = 1937092946;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              this.CancelRequested = true;
              num1 = (int) num3 * 1904687698 ^ -1094157277;
              continue;
            case 2:
              num1 = (int) num3 * -1851515929 ^ 739017982;
              continue;
            case 3:
              num1 = (int) num3 * 323351957 ^ -1679880888;
              continue;
            case 4:
              goto label_11;
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
          int num1 = 1442354775;
          while (true)
          {
            int num2 = 1937092946;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num1 = (int) num3 * -1607395053 ^ 490699293;
                continue;
              case 2:
                goto label_9;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    public void UpdateActiveWindows()
    {
label_1:
      int num1 = -1012047064;
      object windowLock;
      while (true)
      {
        int num2 = -2121278975;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 1:
            num1 = (int) num3 * -926080225 ^ 159821820;
            continue;
          case 2:
            num4 = this.SharedData.ActiveWindows != null ? 1 : 0;
            break;
          case 3:
            goto label_1;
          case 4:
            windowLock = WindowManager.windowLock;
            num1 = (int) num3 * 254565106 ^ -1003379412;
            continue;
          case 5:
            if (this.sharedData != null)
            {
              num1 = (int) num3 * -1925695859 ^ 253949671;
              continue;
            }
            num4 = 0;
            break;
          case 6:
            if (flag)
            {
              num1 = (int) num3 * 1777223908 ^ -1354461094;
              continue;
            }
            goto label_35;
          default:
            goto label_12;
        }
        flag = num4 != 0;
        num1 = -278571827;
      }
label_35:
      return;
label_12:
      bool flag1 = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag1);
label_14:
        int num2 = -629648384;
        while (true)
        {
          int num3 = -2121278975;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_14;
            case 1:
              num2 = (int) num4 * 1685234736 ^ -946863748;
              continue;
            case 3:
              num2 = (int) num4 * 1699787944 ^ 1592016982;
              continue;
            case 4:
              num2 = (int) num4 * 368449517 ^ 183490554;
              continue;
            default:
              goto label_19;
          }
        }
label_19:
        IEnumerator<ZoomWindow> enumerator = this.SharedData.ActiveWindows.GetEnumerator();
        try
        {
label_24:
          int num3 = !WindowManager.\u202D‭​‏‍⁭‬⁭‪⁯⁯​‮⁯‭⁬⁮‬‌⁭⁪‮‭⁬​⁯‭​‏⁫⁭⁪⁮‍⁭⁫⁯‭‭‏‮((IEnumerator) enumerator) ? -972803585 : (num3 = -662160187);
          while (true)
          {
            int num4 = -2121278975;
            uint num5;
            ZoomWindow current;
            switch ((num5 = (uint) (num3 ^ num4)) % 5U)
            {
              case 0:
                num3 = -662160187;
                continue;
              case 1:
                current.Refresh(false, false);
                num3 = (int) num5 * 1757590805 ^ 873229207;
                continue;
              case 2:
                current = enumerator.Current;
                num3 = -1142954427;
                continue;
              case 3:
                goto label_24;
              default:
                goto label_39;
            }
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_27:
            int num3 = -496228588;
            while (true)
            {
              int num4 = -2121278975;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 0:
                  num3 = (int) num5 * 1960484213 ^ -394053534;
                  continue;
                case 1:
                  WindowManager.\u202E‪⁮‪⁮‎⁪⁫⁬‫⁯‏‬‪‫⁯⁪⁭‎⁭​‎⁫⁪‭⁫‎‌⁪⁭​‮‏⁫‎‏⁮‬⁯⁯‮((IDisposable) enumerator);
                  num3 = (int) num5 * -1244893828 ^ 444079949;
                  continue;
                case 2:
                  goto label_27;
                default:
                  goto label_31;
              }
            }
          }
label_31:;
        }
      }
      finally
      {
        if (flag1)
        {
label_33:
          int num2 = -1228237665;
          while (true)
          {
            int num3 = -2121278975;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_33;
              case 2:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num2 = (int) num4 * -327808821 ^ 717747684;
                continue;
              case 3:
                num2 = (int) num4 * 770441919 ^ -943452579;
                continue;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
label_39:;
    }

    public void SetPatternMonitors(string primaryScreen, string secondaryScreen)
    {
      if (this.sharedData == null)
        goto label_6;
label_1:
      int num1 = 1335688071;
label_2:
      while (true)
      {
        int num2 = 907739517;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Engine.ActivePattern.SecondaryMonitor = secondaryScreen;
            num1 = (int) num3 * 2127385918 ^ -804990556;
            continue;
          case 2:
            goto label_5;
          case 3:
            num1 = (int) num3 * 1127804407 ^ 129483189;
            continue;
          case 5:
            this.Engine.ActivePattern.PrimaryMonitor = primaryScreen;
            num1 = (int) num3 * -296046843 ^ 1280959546;
            continue;
          case 6:
            num1 = (int) num3 * 966241609 ^ 964132402;
            continue;
          case 7:
            num1 = (int) num3 * 540310748 ^ -79846723;
            continue;
          default:
            goto label_12;
        }
      }
label_5:
      int num4 = this.Engine.ActivePattern != null ? 1 : 0;
      goto label_7;
label_12:
      object windowLock = this.WindowLock;
      bool flag = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
        IEnumerator<ZoomWindow> enumerator = this.SharedData.ActiveWindows.GetEnumerator();
        try
        {
label_20:
          int num2 = !WindowManager.\u202D‭​‏‍⁭‬⁭‪⁯⁯​‮⁯‭⁬⁮‬‌⁭⁪‮‭⁬​⁯‭​‏⁫⁭⁪⁮‍⁭⁫⁯‭‭‏‮((IEnumerator) enumerator) ? 1183984290 : (num2 = 2144987804);
          while (true)
          {
            int num3 = 907739517;
            uint num5;
            ZoomWindow current;
            switch ((num5 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                num2 = 2144987804;
                continue;
              case 1:
                current = enumerator.Current;
                num2 = 1649589744;
                continue;
              case 2:
                num2 = (int) num5 * -595882875 ^ 1626748201;
                continue;
              case 3:
                this.Engine.ActivePattern.ApplyTo(current);
                num2 = (int) num5 * -407548606 ^ 230272639;
                continue;
              case 4:
                goto label_20;
              default:
                goto label_34;
            }
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_22:
            int num2 = 828505298;
            while (true)
            {
              int num3 = 907739517;
              uint num5;
              switch ((num5 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_22;
                case 1:
                  num2 = (int) num5 * -1599778514 ^ -1529654451;
                  continue;
                case 3:
                  WindowManager.\u202E‪⁮‪⁮‎⁪⁫⁬‫⁯‏‬‪‫⁯⁪⁭‎⁭​‎⁫⁪‭⁫‎‌⁪⁭​‮‏⁫‎‏⁮‬⁯⁯‮((IDisposable) enumerator);
                  num2 = (int) num5 * 81421494 ^ 379601230;
                  continue;
                default:
                  goto label_26;
              }
            }
          }
label_26:;
        }
      }
      finally
      {
        if (flag)
        {
label_28:
          int num2 = 54199900;
          while (true)
          {
            int num3 = 907739517;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_28;
              case 1:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num2 = (int) num5 * 1717286572 ^ 532312922;
                continue;
              case 3:
                num2 = (int) num5 * -399291943 ^ 972773616;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
label_34:
      return;
label_6:
      num4 = 0;
label_7:
      if (num4 == 0)
        return;
      num1 = 225988782;
      goto label_2;
    }

    private ZoomWindow GetWindow(ZoomEvent windowEvent, bool createWindowIfNotFound = true)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003C\u003Ec__DisplayClass86_0 cDisplayClass860 = new WindowManager.\u003C\u003Ec__DisplayClass86_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass860.windowEvent = windowEvent;
label_1:
      int num1 = -1384155082;
      ZoomWindow zoomWindow1;
      object windowLock;
      while (true)
      {
        int num2 = -789605956;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            zoomWindow1 = (ZoomWindow) null;
            num1 = (int) num3 * -1699102722 ^ -1941425085;
            continue;
          case 3:
            windowLock = this.WindowLock;
            num1 = (int) num3 * -1143440874 ^ 47508235;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
label_7:
        int num2 = -769890113;
        while (true)
        {
          int num3 = -789605956;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 14U)
          {
            case 0:
              num2 = (int) num4 * -1347300745 ^ -1084959229;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated field
              this.CheckWindowTypes(cDisplayClass860.windowEvent);
              num2 = (int) num4 * 1759125168 ^ 1438850763;
              continue;
            case 2:
              num2 = (int) num4 * -329193512 ^ -667847283;
              continue;
            case 3:
              num2 = (int) num4 * -354275385 ^ 1517830789;
              continue;
            case 4:
              // ISSUE: method pointer
              zoomWindow1 = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass860, __methodptr(\u003CGetWindow\u003Eb__0)));
              // ISSUE: reference to a compiler-generated field
              cDisplayClass860.windowEvent.Window = zoomWindow1;
              int num5 = zoomWindow1 == null & createWindowIfNotFound ? -1709974204 : (num5 = -1768287100);
              int num6 = (int) num4 * -170334686;
              num2 = num5 ^ num6;
              continue;
            case 5:
              num2 = -35086956;
              continue;
            case 6:
              goto label_7;
            case 7:
              // ISSUE: reference to a compiler-generated field
              zoomWindow1 = ZoomFactory.CreateWindow(cDisplayClass860.windowEvent.WindowHandle);
              num2 = (int) num4 * -1418606009 ^ -112623067;
              continue;
            case 8:
              int num7 = zoomWindow1 != null ? 501022195 : (num7 = 616295367);
              int num8 = (int) num4 * 1386967324;
              num2 = num7 ^ num8;
              continue;
            case 9:
              this.SharedData.ActiveWindows.Add(zoomWindow1);
              num2 = (int) num4 * 983121707 ^ 1970408161;
              continue;
            case 10:
              num2 = (int) num4 * 1271780129 ^ 1602679423;
              continue;
            case 11:
              num2 = -1050842871;
              continue;
            case 12:
              num2 = -1389144877;
              continue;
            default:
              goto label_27;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_22:
          int num2 = -59345130;
          while (true)
          {
            int num3 = -789605956;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                num2 = (int) num4 * 241147379 ^ -190510785;
                continue;
              case 2:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num2 = (int) num4 * 881121938 ^ 2004631185;
                continue;
              case 3:
                goto label_22;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
label_27:
      ZoomWindow zoomWindow2 = zoomWindow1;
label_28:
      int num9 = -940578512;
      while (true)
      {
        int num2 = -789605956;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 3U)
        {
          case 0:
            goto label_28;
          case 1:
            num9 = (int) num3 * -1827235718 ^ 1736325841;
            continue;
          default:
            goto label_31;
        }
      }
label_31:
      return zoomWindow2;
    }

    private void CreateWindow(ZoomEvent windowEvent)
    {
      if (windowEvent.ZoomWindowType == ZoomWindowType.Meeting)
        goto label_4;
label_1:
      int num1 = 864968400;
label_2:
      bool flag1;
      object managerLock;
      while (true)
      {
        int num2 = 1803563491;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_3;
          case 2:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Join)
            {
              num1 = (int) num3 * -3800092 ^ 901569184;
              continue;
            }
            goto label_4;
          case 3:
            if (flag1)
            {
              num1 = (int) num3 * 232866705 ^ -1965175228;
              continue;
            }
            goto label_38;
          case 4:
            goto label_1;
          case 5:
            managerLock = ManagerBase.managerLock;
            num1 = (int) num3 * 1869160855 ^ 34445125;
            continue;
          case 6:
            if (windowEvent.ZoomWindowType != ZoomWindowType.AccountPanel)
            {
              num1 = (int) num3 * 1479871436 ^ -1184092261;
              continue;
            }
            goto label_4;
          default:
            goto label_13;
        }
      }
label_3:
      int num4 = windowEvent.ZoomWindowType == ZoomWindowType.ManyCamBroadcast ? 1 : 0;
      goto label_5;
label_13:
      bool flag2 = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(managerLock, ref flag2);
label_15:
        int num2 = 1039268445;
        while (true)
        {
          int num3 = 1803563491;
          uint num5;
          bool flag3;
          switch ((num5 = (uint) (num2 ^ num3)) % 9U)
          {
            case 1:
              num2 = (int) num5 * 827403651 ^ -1865128527;
              continue;
            case 2:
              flag3 = !this.movementHandles.Contains(windowEvent.WindowHandle);
              num2 = (int) num5 * -200973194 ^ -9314382;
              continue;
            case 3:
              this.movementHandles.Add(windowEvent.WindowHandle);
              num2 = (int) num5 * 75688427 ^ -772228448;
              continue;
            case 4:
              num2 = (int) num5 * 1267433031 ^ -967475821;
              continue;
            case 5:
              num2 = (int) num5 * 1840769769 ^ 931249750;
              continue;
            case 6:
              int num6 = !flag3 ? 1540747897 : (num6 = 1164611389);
              int num7 = (int) num5 * 1402346467;
              num2 = num6 ^ num7;
              continue;
            case 7:
              num2 = (int) num5 * -1458097333 ^ -1648149710;
              continue;
            case 8:
              goto label_15;
            default:
              goto label_31;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_25:
          int num2 = 672450528;
          while (true)
          {
            int num3 = 1803563491;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_25;
              case 1:
                num2 = (int) num5 * 970188931 ^ -464523670;
                continue;
              case 3:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(managerLock);
                num2 = (int) num5 * 540026307 ^ -667510249;
                continue;
              default:
                goto label_30;
            }
          }
        }
label_30:;
      }
label_31:
label_32:
      int num8 = 1814630442;
label_33:
      while (true)
      {
        int num2 = 1803563491;
        uint num3;
        bool highlightSupported;
        bool flag3;
        bool flag4;
        int num5;
        switch ((num3 = (uint) (num8 ^ num2)) % 23U)
        {
          case 0:
            int num6 = !flag4 ? -1424837823 : (num6 = -1035254724);
            int num7 = (int) num3 * -1120266911;
            num8 = num6 ^ num7;
            continue;
          case 1:
            goto label_34;
          case 2:
            goto label_32;
          case 3:
            this.AddHighlightWindow(windowEvent.Window);
            num8 = (int) num3 * -1891100209 ^ 1433198801;
            continue;
          case 4:
            this.CreateRelatedWindows(windowEvent.Window);
            num8 = (int) num3 * 24821087 ^ 1282453131;
            continue;
          case 5:
            num8 = (int) num3 * 293240776 ^ 2126750941;
            continue;
          case 6:
            num8 = (int) num3 * -630987045 ^ 334723201;
            continue;
          case 7:
            int num9 = windowEvent.ZoomWindowType != ZoomWindowType.Meeting ? -1479058797 : (num9 = -463828877);
            int num10 = (int) num3 * 969200178;
            num8 = num9 ^ num10;
            continue;
          case 8:
            windowEvent.Window.WindowInspected = DateTime.MinValue;
            num8 = (int) num3 * 1235279653 ^ 1677985120;
            continue;
          case 9:
            goto label_38;
          case 10:
            this.HandleNewButton(windowEvent);
            num8 = (int) num3 * 95427557 ^ 1154564656;
            continue;
          case 11:
            num8 = (int) num3 * 1778659797 ^ 1444688667;
            continue;
          case 12:
            int num11 = !flag3 ? -749484714 : (num11 = -1959317791);
            int num12 = (int) num3 * 852052227;
            num8 = num11 ^ num12;
            continue;
          case 13:
            flag4 = windowEvent.Window != null;
            num8 = 1251517512;
            continue;
          case 14:
            num8 = (int) num3 * -1674336338 ^ 1714822870;
            continue;
          case 15:
            int num13 = !highlightSupported ? -848282720 : (num13 = -1229970390);
            int num14 = (int) num3 * -791148345;
            num8 = num13 ^ num14;
            continue;
          case 16:
            num8 = (int) num3 * -127263811 ^ 2028715580;
            continue;
          case 17:
            num8 = (int) num3 * 46525902 ^ -747734129;
            continue;
          case 18:
            num5 = ZoomZoom.Properties.Settings.Default._App_DestroyVideoWindows ? 1 : 0;
            break;
          case 19:
            num8 = 491196298;
            continue;
          case 20:
            highlightSupported = windowEvent.Window.DrawHighlightSupported;
            num8 = 945207319;
            continue;
          case 21:
            num8 = (int) num3 * -39191810 ^ -1924470587;
            continue;
          case 22:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Video)
            {
              num5 = 0;
              break;
            }
            num8 = 988494731;
            continue;
          default:
            goto label_27;
        }
        flag3 = num5 != 0;
        num8 = 283712621;
      }
label_27:
      return;
label_34:
      return;
label_38:
      int num15;
      num8 = num15 = this.lastClickTime >= DateTime.Now.AddSeconds(-1.0) ? 1111748277 : (num15 = 661093631);
      goto label_33;
label_4:
      num4 = 1;
label_5:
      flag1 = num4 != 0;
      num1 = 1969173142;
      goto label_2;
    }

    private void UpdateActivityQueue(ZoomEvent windowEvent)
    {
label_1:
      int num1 = -1468948689;
      while (true)
      {
        int num2 = -454656951;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Engine.AddActivityQueue(windowEvent);
            num1 = (int) num3 * -44213894 ^ 1338397919;
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

    private void HandleNewButton(ZoomEvent windowEvent)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003C\u003Ec__DisplayClass89_0 cDisplayClass890 = new WindowManager.\u003C\u003Ec__DisplayClass89_0();
label_1:
      int num1 = -2081061787;
      while (true)
      {
        int num2 = -118364595;
        uint num3;
        bool flag1;
        bool flag2;
        ZoomButton zoomButton1;
        bool flag3;
        ZoomWindow lastClickWindow;
        ZoomButton zoomButton2;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 27U)
        {
          case 0:
            num1 = -124073633;
            continue;
          case 1:
            num1 = -1993819936;
            continue;
          case 2:
            num1 = (int) num3 * 2111755049 ^ 837235038;
            continue;
          case 3:
            flag2 = this.Engine.ActiveMeeting != null;
            num1 = (int) num3 * 2101983941 ^ 877443083;
            continue;
          case 4:
            num1 = (int) num3 * 1821526268 ^ -90050738;
            continue;
          case 5:
            int num4 = !flag1 ? -945302650 : (num4 = -1347537056);
            int num5 = (int) num3 * 305818824;
            num1 = num4 ^ num5;
            continue;
          case 6:
            num1 = -200379847;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass890.windowEvent = windowEvent;
            num1 = (int) num3 * 1799183583 ^ 976066567;
            continue;
          case 8:
            num1 = (int) num3 * -1207821814 ^ -1900634599;
            continue;
          case 9:
            zoomButton2.WindowWidth = lastClickWindow.Size.Width;
            num1 = (int) num3 * -1601964618 ^ 1541542486;
            continue;
          case 10:
            flag4 = this.lastClickWindow != null;
            num1 = (int) num3 * -1490450394 ^ 1309018803;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            WindowManager.\u200F‎⁯‍⁯‌‪‭⁬⁮⁬‍⁪⁮‫‍⁪‏‪‮‫​‎⁯‏‭⁭​​‪⁫⁪‍‬‎‪‎‬⁫⁯‮(WindowManager.\u206A‬‪⁭‫‏​⁭‪‪⁪‪‭‎‫⁯‎⁭‪⁪‌‭‎‎​‭‭‬‍⁪⁪‫‌⁬​‭​‬⁭‬‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2527307271U), (object) cDisplayClass890.windowEvent.Window.Title, (object) cDisplayClass890.windowEvent.Window.ClassName));
            num1 = (int) num3 * 1858848018 ^ 252333468;
            continue;
          case 12:
            goto label_1;
          case 13:
            int num6 = flag3 ? -1407155461 : (num6 = -789736445);
            int num7 = (int) num3 * 140762111;
            num1 = num6 ^ num7;
            continue;
          case 14:
            flag3 = zoomButton1 == null;
            num1 = (int) num3 * -1951741262 ^ -1219914548;
            continue;
          case 15:
            this.Engine.LogException(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4234312386U));
            num1 = (int) num3 * 1836891083 ^ -1145701179;
            continue;
          case 16:
            num1 = (int) num3 * 1702624903 ^ 204572985;
            continue;
          case 17:
            lastClickWindow = this.lastClickWindow;
            num1 = (int) num3 * 2022500025 ^ -762393379;
            continue;
          case 18:
            int num8 = flag4 ? -1505108210 : (num8 = -137329879);
            int num9 = (int) num3 * 730602709;
            num1 = num8 ^ num9;
            continue;
          case 19:
            num1 = (int) num3 * 791465192 ^ -1227077304;
            continue;
          case 20:
            // ISSUE: method pointer
            zoomButton1 = (ZoomButton) Enumerable.FirstOrDefault<ZoomButton>((IEnumerable<M0>) this.Engine.SharedData.MeetingButtons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) cDisplayClass890, __methodptr(\u003CHandleNewButton\u003Eb__0)));
            num1 = (int) num3 * 1034735891 ^ 349487936;
            continue;
          case 21:
            num1 = -1515203821;
            continue;
          case 22:
            goto label_3;
          case 23:
            num1 = (int) num3 * 1982195924 ^ 1876992728;
            continue;
          case 24:
            // ISSUE: reference to a compiler-generated field
            flag1 = cDisplayClass890.windowEvent.ZoomWindowType == ZoomWindowType.Undefined;
            num1 = (int) num3 * 37777757 ^ 6680404;
            continue;
          case 25:
            zoomButton2 = new ZoomButton();
            zoomButton2.WindowHeight = lastClickWindow.Size.Height;
            num1 = (int) num3 * 1136582538 ^ -1987442730;
            continue;
          case 26:
            int num10 = !flag2 ? 1251403919 : (num10 = 491547470);
            int num11 = (int) num3 * -445328152;
            num1 = num10 ^ num11;
            continue;
          default:
            goto label_29;
        }
      }
label_29:
      return;
label_3:;
    }

    private void CreateRelatedWindows(ZoomWindow window)
    {
label_1:
      int num1 = 534676201;
      while (true)
      {
        int num2 = 963422900;
        uint num3;
        IntPtr num4;
        bool flag1;
        ZoomWindow window1;
        ZoomWindow window2;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num4 = window.Child;
            flag2 = !num4.Equals((object) IntPtr.Zero);
            num1 = (int) num3 * -1688396713 ^ 1129599773;
            continue;
          case 1:
            flag1 = !num4.Equals((object) IntPtr.Zero);
            num1 = (int) num3 * -1152701225 ^ 1044541862;
            continue;
          case 2:
            window2 = ZoomFactory.CreateWindow(window.Child);
            num1 = (int) num3 * 145496228 ^ -370494847;
            continue;
          case 3:
            num1 = (int) num3 * -1891140849 ^ 1735147330;
            continue;
          case 4:
            num1 = (int) num3 * 1773467503 ^ -1007036640;
            continue;
          case 5:
            this.CreateRelatedWindows(window1);
            num1 = (int) num3 * 298048687 ^ 196653616;
            continue;
          case 6:
            num1 = (int) num3 * -348947541 ^ 1687113899;
            continue;
          case 7:
            num4 = window.Next;
            num1 = 1846928956;
            continue;
          case 8:
            num1 = (int) num3 * 1972828654 ^ -1501900251;
            continue;
          case 9:
            num1 = (int) num3 * 1694851987 ^ 1738953966;
            continue;
          case 10:
            num1 = 508384485;
            continue;
          case 11:
            window1 = ZoomFactory.CreateWindow(window.Next);
            num1 = (int) num3 * -1057608123 ^ 1943322298;
            continue;
          case 12:
            goto label_3;
          case 13:
            int num5 = window == null ? -275494680 : (num5 = -1382500171);
            int num6 = (int) num3 * 1037682545;
            num1 = num5 ^ num6;
            continue;
          case 14:
            num1 = (int) num3 * -1897998036 ^ -1967675271;
            continue;
          case 15:
            this.CreateRelatedWindows(window2);
            num1 = (int) num3 * 258861512 ^ -1269039787;
            continue;
          case 16:
            goto label_1;
          case 17:
            int num7 = flag2 ? 277223814 : (num7 = 874880285);
            int num8 = (int) num3 * -1751607146;
            num1 = num7 ^ num8;
            continue;
          case 18:
            int num9 = flag1 ? -2057676077 : (num9 = -562757433);
            int num10 = (int) num3 * -2086662839;
            num1 = num9 ^ num10;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return;
label_3:;
    }

    private void DestroyWindow(ZoomEvent windowEvent)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003C\u003Ec__DisplayClass91_0 cDisplayClass910 = new WindowManager.\u003C\u003Ec__DisplayClass91_0();
label_1:
      int num1 = 410210065;
      object managerLock;
      while (true)
      {
        int num2 = 600907438;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass910.windowEvent = windowEvent;
            num1 = (int) num3 * 1097349369 ^ 1476265360;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            flag = !WindowHelper.IsValid(cDisplayClass910.windowEvent.Window.Handle);
            num1 = (int) num3 * -425042009 ^ 1066816891;
            continue;
          case 4:
            if (flag)
            {
              num1 = (int) num3 * 1826867385 ^ -229755155;
              continue;
            }
            goto label_56;
          case 5:
            managerLock = ManagerBase.managerLock;
            num1 = (int) num3 * 652328604 ^ -773589392;
            continue;
          default:
            goto label_8;
        }
      }
label_56:
      return;
label_8:
      bool flag1 = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(managerLock, ref flag1);
label_10:
        int num2 = 2115306812;
        while (true)
        {
          int num3 = 600907438;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              int num5 = !flag2 ? 969545815 : (num5 = 1037166272);
              int num6 = (int) num4 * 572862982;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = (int) num4 * 338567257 ^ 1440753393;
              continue;
            case 3:
              num2 = (int) num4 * -1416884038 ^ 282022745;
              continue;
            case 4:
              goto label_10;
            case 5:
              num2 = (int) num4 * 1751208926 ^ -292024017;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              this.movementHandles.Remove(cDisplayClass910.windowEvent.WindowHandle);
              num2 = (int) num4 * 549343602 ^ 702008881;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              flag2 = this.movementHandles.Contains(cDisplayClass910.windowEvent.WindowHandle);
              num2 = (int) num4 * 1281540495 ^ 1849234807;
              continue;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_19:
          int num2 = 287472973;
          while (true)
          {
            int num3 = 600907438;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -197912376 ^ 678879251;
                continue;
              case 2:
                goto label_19;
              case 3:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(managerLock);
                num2 = (int) num4 * 1927831878 ^ -883742764;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:
      object windowLock = this.WindowLock;
      bool flag3 = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag3);
label_26:
        int num2 = 1854474108;
        List<ZoomWindow> list;
        while (true)
        {
          int num3 = 600907438;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              goto label_26;
            case 1:
              num2 = (int) num4 * -1520617452 ^ 2016226237;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              WindowManager.videoChatLinks.Remove(cDisplayClass910.windowEvent.WindowHandle);
              num2 = (int) num4 * -828266933 ^ -416053579;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              int num5 = !WindowManager.videoChatLinks.ContainsKey(cDisplayClass910.windowEvent.WindowHandle) ? -598504115 : (num5 = -1069024237);
              int num6 = (int) num4 * -975906547;
              num2 = num5 ^ num6;
              continue;
            case 4:
              num2 = (int) num4 * -1765105871 ^ 1693933321;
              continue;
            case 5:
              // ISSUE: method pointer
              list = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.SharedData.ActiveWindows, (Func<M0, bool>) new Func<ZoomWindow, bool>((object) cDisplayClass910, __methodptr(\u003CDestroyWindow\u003Eb__0)))).ToList<ZoomWindow>();
              num2 = 426986996;
              continue;
            default:
              goto label_33;
          }
        }
label_33:
        List<ZoomWindow> zoomWindowList = new List<ZoomWindow>();
        using (List<ZoomWindow>.Enumerator enumerator = list.GetEnumerator())
        {
label_43:
          int num3 = enumerator.MoveNext() ? 804839706 : (num3 = 383135605);
          while (true)
          {
            int num4 = 600907438;
            uint num5;
            IntPtr handle;
            ZoomWindow current;
            switch ((num5 = (uint) (num3 ^ num4)) % 13U)
            {
              case 0:
                num3 = (int) num5 * 1623329813 ^ 1582018935;
                continue;
              case 1:
                num3 = (int) num5 * 1133871694 ^ 2041623959;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass910.windowEvent.Window = current;
                num3 = (int) num5 * 573127372 ^ 2111790352;
                continue;
              case 3:
                num3 = (int) num5 * -1778628069 ^ 1780943787;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                int num6 = !handle.Equals((object) cDisplayClass910.windowEvent.WindowHandle) ? -674982429 : (num6 = -1631372272);
                int num7 = (int) num5 * 1028068431;
                num3 = num6 ^ num7;
                continue;
              case 5:
                zoomWindowList.Add(current);
                handle = current.Handle;
                num3 = (int) num5 * -481277605 ^ -1779126979;
                continue;
              case 7:
                num3 = 518734652;
                continue;
              case 8:
                num3 = 1375927480;
                continue;
              case 9:
                goto label_43;
              case 10:
                current = enumerator.Current;
                num3 = 139116792;
                continue;
              case 11:
                num3 = 804839706;
                continue;
              case 12:
                num3 = (int) num5 * -730634559 ^ -857238333;
                continue;
              default:
                goto label_49;
            }
          }
        }
label_49:
        this.SharedData.ActiveWindows = new ConcurrentBag<ZoomWindow>(((IEnumerable<ZoomWindow>) this.SharedData.ActiveWindows).Except<ZoomWindow>((IEnumerable<ZoomWindow>) zoomWindowList));
label_50:
        int num8 = 32097557;
        while (true)
        {
          int num3 = 600907438;
          uint num4;
          switch ((num4 = (uint) (num8 ^ num3)) % 3U)
          {
            case 1:
              num8 = (int) num4 * 502175356 ^ 630690658;
              continue;
            case 2:
              goto label_50;
            default:
              goto label_60;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_54:
          int num2 = 1305648407;
          while (true)
          {
            int num3 = 600907438;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 1272372771 ^ -893023540;
                continue;
              case 1:
                Monitor.Exit(windowLock);
                num2 = (int) num4 * -1995640474 ^ 1779406360;
                continue;
              case 3:
                goto label_54;
              default:
                goto label_59;
            }
          }
        }
label_59:;
      }
label_60:;
    }

    private void MoveWindow(ZoomEvent windowEvent)
    {
      if (windowEvent.ZoomWindowType == ZoomWindowType.SpeakerViewScrollLeft)
        goto label_6;
label_1:
      int num1 = -1841508114;
label_2:
      while (true)
      {
        int num2 = -1734632172;
        uint num3;
        ZoomWindow window;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 26U)
        {
          case 0:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Join)
            {
              num1 = (int) num3 * -1114889382 ^ 1232027090;
              continue;
            }
            break;
          case 1:
            this.ResetWindowTrackingTimes();
            num1 = (int) num3 * 1328696657 ^ -547189405;
            continue;
          case 2:
            goto label_5;
          case 3:
            num1 = (int) num3 * -209541662 ^ -950418470;
            continue;
          case 4:
            this.HandleMeetingViewChanges(windowEvent);
            num1 = -261735523;
            continue;
          case 5:
            goto label_1;
          case 6:
            if (windowEvent.ZoomWindowType != ZoomWindowType.GalleryScrollLeft)
            {
              num1 = (int) num3 * 1247576983 ^ -1169570460;
              continue;
            }
            goto label_6;
          case 7:
            int num5 = !flag1 ? -678097462 : (num5 = -2049675863);
            int num6 = (int) num3 * -1443323606;
            num1 = num5 ^ num6;
            continue;
          case 8:
            num1 = -744985271;
            continue;
          case 9:
            num1 = (int) num3 * -1387082692 ^ -1539544432;
            continue;
          case 10:
            num4 = windowEvent.ZoomWindowType == ZoomWindowType.AccountPanel ? 1 : 0;
            goto label_18;
          case 11:
            num1 = (int) num3 * -578403855 ^ 232648062;
            continue;
          case 12:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Meeting)
            {
              num1 = -753777016;
              continue;
            }
            break;
          case 13:
            num1 = (int) num3 * 1764802337 ^ 434837856;
            continue;
          case 14:
            num1 = (int) num3 * 589557535 ^ 681088134;
            continue;
          case 15:
            goto label_3;
          case 16:
            num1 = (int) num3 * -1305688946 ^ -591735308;
            continue;
          case 17:
            num1 = (int) num3 * 491838024 ^ 528144658;
            continue;
          case 18:
            num1 = (int) num3 * 2039054462 ^ 714799906;
            continue;
          case 19:
            int num7 = flag2 ? 1053528620 : (num7 = 1829692498);
            int num8 = (int) num3 * 251033160;
            num1 = num7 ^ num8;
            continue;
          case 20:
            window.RefreshLocation();
            num1 = (int) num3 * -1635291066 ^ 1439223611;
            continue;
          case 21:
            window = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
            num1 = (int) num3 * 1065323248 ^ 837162629;
            continue;
          case 22:
            num1 = (int) num3 * -790911218 ^ 1090876009;
            continue;
          case 23:
            flag2 = windowEvent.ZoomWindowType == ZoomWindowType.ZoomMenu;
            num1 = -2063976175;
            continue;
          case 24:
            if (windowEvent.ZoomWindowType != ZoomWindowType.SpeakerViewScrollRight)
            {
              num1 = (int) num3 * 681481600 ^ 738533624;
              continue;
            }
            goto label_6;
          case 25:
            flag1 = window != null;
            num1 = (int) num3 * -346548927 ^ -1247510826;
            continue;
          default:
            goto label_36;
        }
        num4 = 1;
label_18:
        int num9;
        num1 = num9 = num4 != 0 ? -400608291 : (num9 = -744985271);
      }
label_36:
      return;
label_3:
      return;
label_5:
      int num10 = windowEvent.ZoomWindowType != ZoomWindowType.GalleryScrollRight ? 1 : 0;
      goto label_7;
label_6:
      num10 = 0;
label_7:
      num1 = num10 != 0 ? -2044137545 : (num1 = -122742330);
      goto label_2;
    }

    private void ResetWindowTrackingTimes()
    {
      object windowLock = WindowManager.windowLock;
      bool flag = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(windowLock, ref flag);
label_2:
        int num1 = -1004665975;
        while (true)
        {
          int num2 = -54433738;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 1459320453 ^ -912433469;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        IEnumerator<ZoomWindow> enumerator = this.Engine.SharedData.ActiveWindows.GetEnumerator();
        try
        {
label_13:
          int num2 = WindowManager.\u202D‭​‏‍⁭‬⁭‪⁯⁯​‮⁯‭⁬⁮‬‌⁭⁪‮‭⁬​⁯‭​‏⁫⁭⁪⁮‍⁭⁫⁯‭‭‏‮((IEnumerator) enumerator) ? -2020769006 : (num2 = -1001871903);
          while (true)
          {
            int num3 = -54433738;
            uint num4;
            ZoomWindow current;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                goto label_23;
              case 1:
                goto label_13;
              case 2:
                current.WindowInspected = DateTime.MinValue;
                num2 = (int) num4 * -546482831 ^ -1951520633;
                continue;
              case 3:
                num2 = (int) num4 * -48962173 ^ -429690461;
                continue;
              case 4:
                num2 = -2020769006;
                continue;
              case 5:
                current = enumerator.Current;
                num2 = -1415497243;
                continue;
              case 6:
                current.WindowSpotlighted = DateTime.MinValue;
                num2 = (int) num4 * -588762545 ^ 1888210719;
                continue;
              default:
                goto label_19;
            }
          }
label_19:
          return;
label_23:;
        }
        finally
        {
          if (enumerator != null)
          {
label_15:
            int num2 = -2078771149;
            while (true)
            {
              int num3 = -54433738;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_15;
                case 1:
                  WindowManager.\u202E‪⁮‪⁮‎⁪⁫⁬‫⁯‏‬‪‫⁯⁪⁭‎⁭​‎⁫⁪‭⁫‎‌⁪⁭​‮‏⁫‎‏⁮‬⁯⁯‮((IDisposable) enumerator);
                  num2 = (int) num4 * 1232169836 ^ -147932152;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
      }
      finally
      {
        if (flag)
        {
label_21:
          int num1 = -10814180;
          while (true)
          {
            int num2 = -54433738;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(windowLock);
                num1 = (int) num3 * -1338985519 ^ 1406627863;
                continue;
              case 2:
                goto label_21;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
    }

    private void HandleMeetingViewChanges(ZoomEvent windowEvent)
    {
      if (windowEvent.ZoomWindowType == ZoomWindowType.SpeakerViewScrollLeft)
        goto label_10;
label_1:
      int num1 = -1369323423;
label_2:
      bool flag;
      while (true)
      {
        int num2 = -1952505861;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_9;
          case 2:
            if (windowEvent.ZoomWindowType != ZoomWindowType.SpeakerViewScrollRight)
            {
              num1 = (int) num3 * 920709835 ^ -396185002;
              continue;
            }
            goto label_10;
          case 3:
            if (windowEvent.ZoomWindowType != ZoomWindowType.GalleryScrollLeft)
            {
              num1 = (int) num3 * 1707748024 ^ -2089863942;
              continue;
            }
            goto label_10;
          case 4:
            this.CreateRelatedWindows(this.Engine.ActiveMeetingWindow);
            num1 = (int) num3 * 141438230 ^ 157838797;
            continue;
          case 5:
            int num4 = flag ? 814478856 : (num4 = 1936333596);
            int num5 = (int) num3 * 1442253771;
            num1 = num4 ^ num5;
            continue;
          case 6:
            num1 = (int) num3 * 702763037 ^ -1237134091;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:
      return;
label_9:
      int num6 = windowEvent.ZoomWindowType == ZoomWindowType.GalleryScrollRight ? 1 : 0;
      goto label_11;
label_10:
      num6 = 1;
label_11:
      flag = num6 != 0;
      num1 = -345165130;
      goto label_2;
    }

    private void MoveSizeWindow(ZoomEvent windowEvent)
    {
      bool highlightSupported = windowEvent.Window.DrawHighlightSupported;
label_1:
      int num1 = 1230065559;
      while (true)
      {
        int num2 = 1790297350;
        uint num3;
        ZoomWindow window;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            num1 = (int) num3 * -1246607884 ^ 775833932;
            continue;
          case 1:
            window = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
            num1 = (int) num3 * 105896079 ^ 1981691891;
            continue;
          case 2:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Join)
            {
              num1 = (int) num3 * -1212936800 ^ -731128647;
              continue;
            }
            break;
          case 3:
            window.RefreshLocation();
            num1 = (int) num3 * 1467240660 ^ -889622351;
            continue;
          case 4:
            num1 = (int) num3 * 2088108454 ^ -1780974083;
            continue;
          case 5:
            num1 = (int) num3 * 434524897 ^ -1889494522;
            continue;
          case 6:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Meeting)
            {
              num1 = 269685694;
              continue;
            }
            break;
          case 7:
            num4 = windowEvent.ZoomWindowType == ZoomWindowType.AccountPanel ? 1 : 0;
            goto label_13;
          case 8:
            flag2 = window != null;
            num1 = (int) num3 * 153999214 ^ 1902290512;
            continue;
          case 9:
            goto label_3;
          case 10:
            this.AddHighlightWindow(windowEvent.Window);
            num1 = (int) num3 * 729155787 ^ 588995634;
            continue;
          case 11:
            goto label_1;
          case 12:
            num1 = (int) num3 * -213552210 ^ -613533883;
            continue;
          case 13:
            num1 = (int) num3 * -1168377890 ^ 585784828;
            continue;
          case 14:
            int num5 = !flag2 ? 265207941 : (num5 = 839779822);
            int num6 = (int) num3 * 20671988;
            num1 = num5 ^ num6;
            continue;
          case 15:
            int num7 = highlightSupported ? -916239992 : (num7 = -499051772);
            int num8 = (int) num3 * 1257074256;
            num1 = num7 ^ num8;
            continue;
          case 16:
            int num9 = !flag1 ? 499992423 : (num9 = 1404164441);
            int num10 = (int) num3 * 2063145184;
            num1 = num9 ^ num10;
            continue;
          case 17:
            num1 = 131346983;
            continue;
          default:
            goto label_24;
        }
        num4 = 1;
label_13:
        flag1 = num4 != 0;
        num1 = 532280320;
      }
label_24:
      return;
label_3:;
    }

    private void ReorderWindow(ZoomEvent windowEvent)
    {
    }

    private void FocusWindow(ZoomEvent windowEvent)
    {
label_1:
      int num1 = 1452393679;
      while (true)
      {
        int num2 = 1015638567;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 59278553 ^ -956488207;
            continue;
          case 2:
            if (windowEvent.ZoomWindowType != ZoomWindowType.GalleryScrollLeft)
            {
              num1 = (int) num3 * 1148071148 ^ -793371200;
              continue;
            }
            num4 = 1;
            break;
          case 4:
            if (flag)
            {
              num1 = (int) num3 * -1838975396 ^ 267890354;
              continue;
            }
            goto label_20;
          case 5:
            num4 = windowEvent.ZoomWindowType == ZoomWindowType.GalleryScrollRight ? 1 : 0;
            break;
          default:
            goto label_11;
        }
        flag = num4 != 0;
        num1 = 1255167287;
      }
label_20:
      return;
label_11:
      object managerLock = ManagerBase.managerLock;
      bool flag1 = false;
      try
      {
        WindowManager.\u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮(managerLock, ref flag1);
label_13:
        int num2 = 899026961;
        while (true)
        {
          int num3 = 1015638567;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              num2 = (int) num4 * -272283991 ^ 200098390;
              continue;
            case 2:
              this.windowsImaged.Clear();
              num2 = (int) num4 * -618819693 ^ -2085250704;
              continue;
            case 3:
              goto label_13;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_18:
          int num2 = 309257784;
          while (true)
          {
            int num3 = 1015638567;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_18;
              case 1:
                num2 = (int) num4 * -2007860414 ^ 1255910239;
                continue;
              case 3:
                WindowManager.\u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮(managerLock);
                num2 = (int) num4 * -2085277213 ^ -1809372249;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:;
    }

    private void StateChangeWindow(ZoomEvent windowEvent)
    {
label_1:
      int num1 = 1984866679;
      while (true)
      {
        int num2 = 1163773906;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            int num4 = flag ? 325160570 : (num4 = 1325368151);
            int num5 = (int) num3 * -820197297;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * -1512533436 ^ 130654375;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag = windowEvent.ZoomWindowType == ZoomWindowType.Video;
            num1 = (int) num3 * 1730621641 ^ -1615341141;
            continue;
          case 4:
            num1 = (int) num3 * -777823912 ^ -1401218227;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void ShowWindow(ZoomEvent windowEvent)
    {
label_1:
      int num1 = -194771413;
      while (true)
      {
        int num2 = -1791524675;
        uint num3;
        ZoomWindow window;
        bool flag1;
        bool highlightSupported;
        bool flag2;
        bool flag3;
        bool flag4;
        ActivityBase activeActivity;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 37U)
        {
          case 0:
            num1 = (int) num3 * -850562575 ^ -496215183;
            continue;
          case 1:
            if (!WindowManager.\u200B⁭‪⁫⁪‫⁪⁭‮⁪‌‪‭​⁯‏‌‎‬‬‎⁯‮‫⁭‎⁯⁪⁯‪‍‫⁬⁬‬‎‍​‬‪‮(activeActivity.Name, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(907712784U)))
            {
              num1 = (int) num3 * 1895686795 ^ -1516930036;
              continue;
            }
            break;
          case 2:
            this.Engine.CancelActivity((ActivityBase) null);
            num1 = (int) num3 * -569509374 ^ 1195421307;
            continue;
          case 3:
            num1 = (int) num3 * 2044409878 ^ -2142350429;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = -490543440;
            continue;
          case 6:
            flag4 = window != null;
            num1 = (int) num3 * -1463117500 ^ -692330770;
            continue;
          case 7:
            num1 = (int) num3 * 682789464 ^ -247826691;
            continue;
          case 8:
            this.AddHighlightWindow(windowEvent.Window);
            num1 = (int) num3 * -668300871 ^ -292681228;
            continue;
          case 9:
            num1 = (int) num3 * -2014370286 ^ -1526833025;
            continue;
          case 10:
            int num6 = flag1 ? -979109941 : (num6 = -2078436130);
            int num7 = (int) num3 * -1465318063;
            num1 = num6 ^ num7;
            continue;
          case 11:
            num5 = windowEvent.ZoomWindowType == ZoomWindowType.AccountPanel ? 1 : 0;
            goto label_44;
          case 12:
            num1 = (int) num3 * -459125470 ^ 754995139;
            continue;
          case 13:
            num1 = (int) num3 * -1871471458 ^ 1542767920;
            continue;
          case 14:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Join)
            {
              num1 = (int) num3 * -1820879052 ^ 1339805476;
              continue;
            }
            goto label_43;
          case 15:
            num1 = -1654215599;
            continue;
          case 16:
            num1 = (int) num3 * -1205827483 ^ 2146185222;
            continue;
          case 17:
            int num8 = !highlightSupported ? -1014574449 : (num8 = -237105697);
            int num9 = (int) num3 * 2145266012;
            num1 = num8 ^ num9;
            continue;
          case 18:
            num1 = (int) num3 * 371469494 ^ 414727261;
            continue;
          case 19:
            flag3 = windowEvent.ZoomWindowType == ZoomWindowType.Meeting;
            num1 = -2050075094;
            continue;
          case 20:
            activeActivity = this.Engine.ActiveActivity;
            if (activeActivity != null)
            {
              num1 = (int) num3 * 1500718396 ^ 1877512777;
              continue;
            }
            break;
          case 21:
            highlightSupported = windowEvent.Window.DrawHighlightSupported;
            num1 = (int) num3 * 1218521917 ^ 1162227756;
            continue;
          case 22:
            flag2 = windowEvent.Window != null;
            num1 = (int) num3 * -556375737 ^ -460754595;
            continue;
          case 23:
            int num10 = !flag3 ? 1885187850 : (num10 = 1530684079);
            int num11 = (int) num3 * -523647658;
            num1 = num10 ^ num11;
            continue;
          case 24:
            int num12 = !flag2 ? -1643773677 : (num12 = -1694959372);
            int num13 = (int) num3 * -358818213;
            num1 = num12 ^ num13;
            continue;
          case 25:
            goto label_3;
          case 26:
            num1 = (int) num3 * 599882726 ^ 564129885;
            continue;
          case 27:
            num1 = (int) num3 * -1442755862 ^ -1299339033;
            continue;
          case 28:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            num4 = Enumerable.Any<ActivityBase>((IEnumerable<M0>) this.Engine.ActivitiesPending, (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__99_0 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__99_0 = new Func<ActivityBase, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CShowWindow\u003Eb__99_0))))) ? 1 : 0;
            goto label_18;
          case 29:
            if (windowEvent.ZoomWindowType != ZoomWindowType.Meeting)
            {
              num1 = -71024148;
              continue;
            }
            goto label_43;
          case 30:
            window.RefreshLocation();
            num1 = (int) num3 * -2111907720 ^ 2043882614;
            continue;
          case 31:
            int num14;
            num1 = num14 = windowEvent.ZoomWindowType != ZoomWindowType.ZoomMenu ? -1652933855 : (num14 = -1728681835);
            continue;
          case 32:
            window = this.Engine.GetWindow(ZoomWindowType.ZoomZoomMain);
            num1 = (int) num3 * -1324300358 ^ -2012014398;
            continue;
          case 33:
            num1 = (int) num3 * 42046959 ^ -2092309009;
            continue;
          case 34:
            int num15 = flag4 ? -292880036 : (num15 = -2111314729);
            int num16 = (int) num3 * -714901418;
            num1 = num15 ^ num16;
            continue;
          case 35:
            num1 = -1871069619;
            continue;
          case 36:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            this.Engine.SetActiveActivity((ActivityBase) Enumerable.FirstOrDefault<ActivityBase>((IEnumerable<M0>) this.Engine.ActivitiesPending, (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__99_1 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__99_1 = new Func<ActivityBase, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CShowWindow\u003Eb__99_1))))));
            num1 = -1721920249;
            continue;
          default:
            goto label_47;
        }
        num4 = 0;
label_18:
        flag1 = num4 != 0;
        num1 = -2063794625;
        continue;
label_43:
        num5 = 1;
label_44:
        int num17;
        num1 = num17 = num5 == 0 ? -1654215599 : (num17 = -1874122581);
      }
label_47:
      return;
label_3:;
    }

    private void CheckWindowTypes(ZoomEvent windowEvent)
    {
label_1:
      int num1 = -1464955833;
      while (true)
      {
        int num2 = -1345888091;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            windowEvent.Window.Refresh(true, false);
            num1 = (int) num3 * -827445371 ^ 1946756867;
            continue;
          case 1:
            if (windowEvent.ZoomWindowType == ZoomWindowType.DualVideo)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * -650194668 ^ -983361462;
            continue;
          case 2:
            if (windowEvent.Window == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1038305495 ^ 1196073522;
            continue;
          case 3:
            num4 = windowEvent.ZoomWindowType == ZoomWindowType.Meeting ? 1 : 0;
            break;
          case 4:
            num1 = (int) num3 * -1956451215 ^ 1455710977;
            continue;
          case 5:
            goto label_7;
          case 6:
            num1 = (int) num3 * 1376042474 ^ -391948532;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_3;
        }
        int num5;
        num1 = num5 = num4 != 0 ? -1347723087 : (num5 = -132287472);
      }
label_3:
      return;
label_7:;
    }

    internal static List<Process> GetProcesses()
    {
      List<Process> processList1 = new List<Process>();
      try
      {
        using (List<Process>.Enumerator enumerator = ((IEnumerable<Process>) WindowManager.\u206B‌⁫‏‍‎‌‎⁮​‌⁯​‫‏‍⁫⁯⁭⁯‪‭‏​‫‏‭‫‮‎‏‌⁭‭‪⁬‫‭⁬⁯‮()).ToList<Process>().GetEnumerator())
        {
label_26:
          if (enumerator.MoveNext())
          {
label_5:
            int num1 = -1441796744;
            Process pProcess;
            while (true)
            {
              int num2 = -1128959200;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  pProcess = enumerator.Current;
                  num1 = (int) num3 * -1948410469 ^ 442007511;
                  continue;
                case 1:
                  goto label_5;
                case 2:
                  num1 = -356560951;
                  continue;
                default:
                  goto label_7;
              }
            }
label_7:
            try
            {
label_9:
              int num2 = -1163106517;
              while (true)
              {
                int num3 = -1128959200;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 9U)
                {
                  case 0:
                    goto label_9;
                  case 1:
                    processList1.Add(pProcess);
                    num2 = (int) num4 * -1921893394 ^ -682081062;
                    continue;
                  case 2:
                    int num5 = !WindowManager.\u200C⁪⁮‫⁬⁯‌‪‫‌⁬⁫⁪⁬‏‭​‍⁬‬‍‭‍⁬⁫⁮‍⁫⁬⁬⁮‭⁮‏‫‎⁭⁭⁯⁪‮(WindowManager.\u206D‍‬‮⁭‭‪‍​‍‏‎⁮​‭‏​⁪⁫‬‍⁮‫‭‌⁮⁯⁪‏⁭‫⁯⁫‬⁭‍‬⁫‍⁯‮(WindowManager.\u206F‬‮‌‮⁪⁭⁯‫⁪⁯‎‮⁭‏‬‬‍‌⁫‭‎‬‮⁭​‌‪‫‍‭‬‮⁫⁮‭⁫‌⁮‮‮(pProcess)), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1377095228U)) ? -395983805 : (num5 = -157205421);
                    int num6 = (int) num4 * 692789097;
                    num2 = num5 ^ num6;
                    continue;
                  case 4:
                    num2 = -1014347328;
                    continue;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    int num7 = !processList1.Exists((Predicate<Process>) (zp => WindowManager.\u003C\u003Ec__DisplayClass122_0.\u206D‌‭‭‮‍​​‫⁫⁮⁯‮‏‍⁪‬‮‌⁫‬​⁮⁫‮⁫‮⁬‎⁬⁫‪‮⁭⁭‏‫‏‫⁫‮(zp).Equals(WindowManager.\u003C\u003Ec__DisplayClass122_0.\u206D‌‭‭‮‍​​‫⁫⁮⁯‮‏‍⁪‬‮‌⁫‬​⁮⁫‮⁫‮⁬‎⁬⁫‪‮⁭⁭‏‫‏‫⁫‮(pProcess)))) ? -1365408214 : (num7 = -1718548406);
                    int num8 = (int) num4 * -1372301263;
                    num2 = num7 ^ num8;
                    continue;
                  case 6:
                    num2 = (int) num4 * 961869179 ^ 448412764;
                    continue;
                  case 7:
                    num2 = -2044875205;
                    continue;
                  case 8:
                    num2 = (int) num4 * 300499234 ^ -1548650292;
                    continue;
                  default:
                    goto label_23;
                }
              }
            }
            catch (Exception ex)
            {
label_19:
              int num2 = -1191161743;
              while (true)
              {
                int num3 = -1128959200;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                {
                  case 1:
                    num2 = (int) num4 * -933524705 ^ 74497953;
                    continue;
                  case 2:
                    num2 = (int) num4 * 472663759 ^ 152380242;
                    continue;
                  case 3:
                    goto label_19;
                  default:
                    goto label_23;
                }
              }
            }
label_23:;
          }
          else
            goto label_27;
label_24:
          int num9 = -1271705100;
label_25:
          int num10 = -1128959200;
          uint num11;
          switch ((num11 = (uint) (num9 ^ num10)) % 3U)
          {
            case 0:
              goto label_24;
            case 1:
              goto label_26;
            default:
              goto label_33;
          }
label_27:
          num9 = -1699636651;
          goto label_25;
        }
      }
      catch (Exception ex)
      {
label_30:
        int num1 = -1643925949;
        while (true)
        {
          int num2 = -1128959200;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_30;
            case 2:
              num1 = (int) num3 * -2099146162 ^ 858271858;
              continue;
            default:
              goto label_33;
          }
        }
      }
label_33:
      List<Process> processList2 = processList1;
label_34:
      int num12 = -1386314302;
      while (true)
      {
        int num1 = -1128959200;
        uint num2;
        switch ((num2 = (uint) (num12 ^ num1)) % 3U)
        {
          case 0:
            goto label_34;
          case 1:
            num12 = (int) num2 * -1276954977 ^ 576478575;
            continue;
          default:
            goto label_37;
        }
      }
label_37:
      return processList2;
    }

    internal static List<IntPtr> GetVisibleWindowHandles(int processId)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowManager.\u003C\u003Ec__DisplayClass123_0 displayClass1230 = new WindowManager.\u003C\u003Ec__DisplayClass123_0();
label_1:
      int num1 = 2033005110;
      while (true)
      {
        int num2 = 2118290240;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            displayClass1230.processId = processId;
            num1 = (int) num3 * 576946753 ^ 910359962;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      List<Process> processList = new List<Process>();
      List<IntPtr> numList = new List<IntPtr>();
      try
      {
label_6:
        int num2 = 313077690;
        while (true)
        {
          int num3 = 2118290240;
          uint num4;
          bool flag;
          Process process;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 16U)
          {
            case 0:
              num2 = (int) num4 * -841432680 ^ 1607053266;
              continue;
            case 1:
              num2 = (int) num4 * 960910463 ^ -1068991975;
              continue;
            case 2:
              num2 = 476859271;
              continue;
            case 3:
              goto label_6;
            case 4:
              // ISSUE: method pointer
              process = (Process) Enumerable.FirstOrDefault<Process>((IEnumerable<M0>) ((IEnumerable<Process>) Process.GetProcesses()).ToList<Process>(), (Func<M0, bool>) new Func<Process, bool>((object) displayClass1230, __methodptr(\u003CGetVisibleWindowHandles\u003Eb__0)));
              num2 = 1330532171;
              continue;
            case 5:
              num2 = (int) num4 * 678000836 ^ -1686556886;
              continue;
            case 6:
              num2 = (int) num4 * 756168442 ^ 375774165;
              continue;
            case 8:
              num2 = (int) num4 * 216970319 ^ 1827699172;
              continue;
            case 9:
              num2 = 1767877970;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated field
              flag = displayClass1230.processId.Equals(0);
              num2 = (int) num4 * 18010845 ^ -906487635;
              continue;
            case 11:
              if (process == null)
              {
                num5 = 0;
                break;
              }
              num2 = (int) num4 * 394677734 ^ -479679953;
              continue;
            case 12:
              // ISSUE: reference to a compiler-generated field
              processList.Add(Process.GetProcessById(displayClass1230.processId));
              num2 = (int) num4 * 1358699449 ^ -493876371;
              continue;
            case 13:
              num5 = !process.HasExited ? 1 : 0;
              break;
            case 14:
              processList.AddRange((IEnumerable<Process>) ((IEnumerable<Process>) Process.GetProcessesByName(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(183836725U))).ToList<Process>());
              num2 = (int) num4 * 1457788527 ^ 1158701650;
              continue;
            case 15:
              int num6 = !flag ? 102975893 : (num6 = 308724804);
              int num7 = (int) num4 * 2134700223;
              num2 = num6 ^ num7;
              continue;
            default:
              goto label_25;
          }
          int num8;
          num2 = num8 = num5 != 0 ? 872033672 : (num8 = 1492905833);
        }
label_25:
        using (List<Process>.Enumerator enumerator = processList.GetEnumerator())
        {
label_30:
          int num3 = !enumerator.MoveNext() ? 2028832576 : (num3 = 710959345);
          while (true)
          {
            int num4 = 2118290240;
            uint num5;
            Process current;
            switch ((num5 = (uint) (num3 ^ num4)) % 8U)
            {
              case 1:
                current = enumerator.Current;
                num3 = 1853049103;
                continue;
              case 2:
                num3 = (int) num5 * 1954447413 ^ -1673942594;
                continue;
              case 3:
                num3 = (int) num5 * 617336712 ^ 1337459850;
                continue;
              case 4:
                goto label_30;
              case 5:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: method pointer
                numList.AddRange((IEnumerable<IntPtr>) ((IEnumerable<IntPtr>) Enumerable.Where<IntPtr>((IEnumerable<M0>) WindowHelper.EnumerateProcessWindowHandles(current), (Func<M0, bool>) (WindowManager.\u003C\u003Ec.\u003C\u003E9__123_1 ?? (WindowManager.\u003C\u003Ec.\u003C\u003E9__123_1 = new Func<IntPtr, bool>((object) WindowManager.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CGetVisibleWindowHandles\u003Eb__123_1)))))).ToList<IntPtr>());
                num3 = 32479299;
                continue;
              case 6:
                num3 = 710959345;
                continue;
              case 7:
                num3 = (int) num5 * -372753568 ^ 139263261;
                continue;
              default:
                goto label_40;
            }
          }
        }
      }
      catch (Exception ex)
      {
        CoreObject.log.Error((object) ex);
label_37:
        int num2 = 876099317;
        while (true)
        {
          int num3 = 2118290240;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_37;
            case 2:
              num2 = (int) num4 * 773769905 ^ 1574019026;
              continue;
            default:
              goto label_40;
          }
        }
      }
label_40:
      return numList;
    }

    internal void UpdateVideoUserName()
    {
    }

    internal void AddHighlightRegion(Rectangle region, int durationInSeconds)
    {
label_1:
      int num1 = 2005290696;
      HighlightInfo highlightInfo;
      object windowLock;
      while (true)
      {
        int num2 = 1137476680;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(539268021U), (object) region.Location);
            num1 = (int) num3 * 480951573 ^ -363317358;
            continue;
          case 2:
            windowLock = WindowManager.windowLock;
            num1 = (int) num3 * 323426025 ^ 2102077068;
            continue;
          case 3:
            highlightInfo = new HighlightInfo(region, durationInSeconds);
            num1 = (int) num3 * 543383316 ^ 243241597;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      bool flag1 = false;
      try
      {
        Monitor.Enter(windowLock, ref flag1);
label_8:
        int num2 = 655924011;
        DateTime dateTime;
        while (true)
        {
          int num3 = 1137476680;
          uint num4;
          DateTime now;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              now = DateTime.Now;
              num2 = (int) num4 * -2053039438 ^ -1577605456;
              continue;
            case 1:
              num2 = (int) num4 * 697784763 ^ -2130482099;
              continue;
            case 3:
              goto label_8;
            case 4:
              dateTime = now.AddSeconds(-1.0);
              num2 = (int) num4 * -893806149 ^ 2078345555;
              continue;
            case 5:
              num2 = (int) num4 * -470020252 ^ 846324896;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        Dictionary<IntPtr, HighlightInfo>.KeyCollection.Enumerator enumerator = WindowManager.ActiveHighlights.Keys.GetEnumerator();
        try
        {
label_20:
          int num3 = enumerator.MoveNext() ? 166839084 : (num3 = 1758220187);
          while (true)
          {
            int num4 = 1137476680;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 5U)
            {
              case 0:
                num3 = 166839084;
                continue;
              case 1:
                WindowManager.ActiveHighlights[enumerator.Current].Expires = dateTime;
                num3 = 1917320042;
                continue;
              case 3:
                goto label_20;
              case 4:
                num3 = (int) num5 * 930039539 ^ -1186495899;
                continue;
              default:
                goto label_26;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
label_22:
          int num3 = 1456264025;
          while (true)
          {
            int num4 = 1137476680;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 3U)
            {
              case 0:
                goto label_22;
              case 2:
                num3 = (int) num5 * 698049723 ^ -490713830;
                continue;
              default:
                goto label_25;
            }
          }
label_25:;
        }
label_26:
        bool flag2 = !WindowManager.ActiveHighlights.ContainsKey(IntPtr.Zero);
label_27:
        int num6 = 412850792;
        while (true)
        {
          int num3 = 1137476680;
          uint num4;
          switch ((num4 = (uint) (num6 ^ num3)) % 7U)
          {
            case 0:
              num6 = (int) num4 * 1256967002 ^ 1630418674;
              continue;
            case 1:
              num6 = 1462941246;
              continue;
            case 2:
              goto label_27;
            case 3:
              WindowManager.ActiveHighlights.Add(IntPtr.Zero, highlightInfo);
              num6 = (int) num4 * -1166777690 ^ -1386994283;
              continue;
            case 4:
              int num5 = !flag2 ? 992573066 : (num5 = 1191461444);
              int num7 = (int) num4 * 2068302731;
              num6 = num5 ^ num7;
              continue;
            case 5:
              num6 = (int) num4 * 1289527643 ^ -1029843999;
              continue;
            case 6:
              goto label_38;
            default:
              goto label_34;
          }
        }
label_34:
        return;
label_38:;
      }
      finally
      {
        if (flag1)
        {
label_36:
          int num2 = 1903369343;
          while (true)
          {
            int num3 = 1137476680;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                Monitor.Exit(windowLock);
                num2 = (int) num4 * -1969257367 ^ -2065653597;
                continue;
              case 2:
                goto label_36;
              default:
                goto label_40;
            }
          }
        }
label_40:;
      }
    }

    private void AddHighlightWindow(ZoomWindow window)
    {
      if (!this.Engine.Settings.DisplayHighlightWindows)
        goto label_8;
label_1:
      int num1 = 2084734083;
label_2:
      bool flag;
      while (true)
      {
        int num2 = 899561861;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 1779334918 ^ -585139344;
            continue;
          case 1:
            int num4 = flag ? 682810997 : (num4 = 1587885238);
            int num5 = (int) num3 * 697755958;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 147772222 ^ -1778649039;
            continue;
          case 4:
            this.Engine.TrackingWindow.SetTrackingTarget(window);
            num1 = (int) num3 * 2086180603 ^ -1089952064;
            continue;
          case 5:
            goto label_1;
          case 6:
            WindowManager.\u202B‮​⁪⁪‫⁬⁪‮⁭‮‍‮⁭‭⁮⁮‌‭​‪‏⁪⁫⁬​‫⁬‭⁮‍‍‭‫‫⁭⁪⁯⁫‌‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2424825486U), (object) window.ZoomWindowType, (object) window.Location);
            num1 = (int) num3 * 610123517 ^ 750424824;
            continue;
          case 7:
            num1 = (int) num3 * 168834907 ^ -1519302671;
            continue;
          case 8:
            goto label_7;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:
      return;
label_7:
      int num6 = this.Engine.TrackingWindow != null ? 1 : 0;
      goto label_9;
label_8:
      num6 = 0;
label_9:
      flag = num6 != 0;
      num1 = 414112544;
      goto label_2;
    }

    internal ZoomWindow OpenChatWindow()
    {
label_1:
      int num1 = 1398526093;
      ZoomWindow zoomWindow1;
      while (true)
      {
        int num2 = 1214113574;
        uint num3;
        ZoomWindow window;
        bool flag1;
        bool flag2;
        ZoomWindow zoomWindow2;
        ZoomMeeting activeMeeting;
        ZoomButton button;
        switch ((num3 = (uint) (num1 ^ num2)) % 22U)
        {
          case 0:
            num1 = (int) num3 * 924754237 ^ -1095795210;
            continue;
          case 1:
            activeMeeting = this.Engine.ActiveMeeting;
            int num4 = activeMeeting != null ? 727956998 : (num4 = 242129955);
            int num5 = (int) num3 * 158804927;
            num1 = num4 ^ num5;
            continue;
          case 2:
            int num6 = !flag2 ? -873781489 : (num6 = -157068749);
            int num7 = (int) num3 * -503452449;
            num1 = num6 ^ num7;
            continue;
          case 3:
            window = this.Engine.GetWindow(ZoomWindowType.Meeting);
            num1 = (int) num3 * 1427975129 ^ 773134988;
            continue;
          case 4:
            num1 = 280432310;
            continue;
          case 5:
            int num8;
            num1 = num8 = zoomWindow2.IsVisible ? 2043195652 : (num8 = 1518159580);
            continue;
          case 6:
            zoomWindow2.Activate();
            num1 = (int) num3 * -618964161 ^ -514203822;
            continue;
          case 7:
            num1 = 1365128824;
            continue;
          case 8:
            zoomWindow1 = zoomWindow2;
            num1 = 853993228;
            continue;
          case 9:
            goto label_1;
          case 10:
            num1 = (int) num3 * -648421001 ^ 549603170;
            continue;
          case 11:
            num1 = (int) num3 * 1442815561 ^ -1845117926;
            continue;
          case 12:
            num1 = (int) num3 * 1914179549 ^ -231497644;
            continue;
          case 13:
            button = activeMeeting.GetButton(ZoomWindowType.Chat);
            flag2 = button != null;
            num1 = (int) num3 * 871205170 ^ -319855506;
            continue;
          case 14:
            num1 = (int) num3 * -513363463 ^ -513184168;
            continue;
          case 15:
            zoomWindow2 = window.ClickButtonAwaitResult(button, this.Token, false);
            num1 = (int) num3 * 1269187707 ^ 831310724;
            continue;
          case 16:
            int num9 = flag1 ? -2079528099 : (num9 = -871655603);
            int num10 = (int) num3 * -1869758572;
            num1 = num9 ^ num10;
            continue;
          case 17:
            num1 = 1524444925;
            continue;
          case 19:
            zoomWindow2 = this.Engine.GetWindow(ZoomWindowType.Chat);
            num1 = (int) num3 * 1248573799 ^ 908175779;
            continue;
          case 20:
            int num11 = zoomWindow2 == null ? -1631316497 : (num11 = -541379489);
            int num12 = (int) num3 * -2130169357;
            num1 = num11 ^ num12;
            continue;
          case 21:
            flag1 = window != null;
            num1 = (int) num3 * 602264439 ^ -100019489;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return zoomWindow1;
    }

    internal ZoomWindow OpenParticipantsWindow()
    {
label_1:
      int num1 = -1350048606;
      ZoomWindow zoomWindow1;
      while (true)
      {
        int num2 = -527249827;
        uint num3;
        ZoomWindow zoomWindow2;
        ZoomMeeting activeMeeting;
        bool flag1;
        ZoomWindow window;
        bool flag2;
        ZoomButton button;
        switch ((num3 = (uint) (num1 ^ num2)) % 25U)
        {
          case 0:
            num1 = (int) num3 * 1000922715 ^ 1413456955;
            continue;
          case 1:
            num1 = (int) num3 * 631573248 ^ 1804614533;
            continue;
          case 2:
            zoomWindow2 = this.Engine.GetWindow(ZoomWindowType.Participants);
            flag2 = zoomWindow2 == null;
            num1 = (int) num3 * -1995003670 ^ -319573437;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 1569427366 ^ 681519041;
            continue;
          case 5:
            button = activeMeeting.GetButton(ZoomWindowType.Participants);
            num1 = (int) num3 * -1377981531 ^ -1178405496;
            continue;
          case 6:
            num1 = (int) num3 * -767278534 ^ -1946744755;
            continue;
          case 7:
            window = this.Engine.GetWindow(ZoomWindowType.Meeting);
            int num4 = window != null ? 1846837851 : (num4 = 1052116391);
            int num5 = (int) num3 * 2145471390;
            num1 = num4 ^ num5;
            continue;
          case 9:
            num1 = -1058100804;
            continue;
          case 10:
            zoomWindow1 = zoomWindow2;
            num1 = -830869663;
            continue;
          case 11:
            num1 = (int) num3 * -130874402 ^ -1050984223;
            continue;
          case 12:
            zoomWindow2 = window.ClickButtonAwaitResult(button, this.Token, false);
            num1 = (int) num3 * 2002428027 ^ -2104206325;
            continue;
          case 13:
            num1 = (int) num3 * 2123158250 ^ 845154673;
            continue;
          case 14:
            int num6 = button != null ? -1901794719 : (num6 = -464543564);
            int num7 = (int) num3 * -826995537;
            num1 = num6 ^ num7;
            continue;
          case 15:
            flag1 = activeMeeting != null;
            num1 = (int) num3 * -1382264643 ^ 928743828;
            continue;
          case 16:
            zoomWindow2.Activate();
            num1 = (int) num3 * -1700610011 ^ -248858492;
            continue;
          case 17:
            num1 = (int) num3 * -428026896 ^ 1844100469;
            continue;
          case 18:
            num1 = -1813657145;
            continue;
          case 19:
            num1 = (int) num3 * 24162583 ^ -486725406;
            continue;
          case 20:
            num1 = -1476412597;
            continue;
          case 21:
            int num8 = !flag1 ? -157948479 : (num8 = -2124941359);
            int num9 = (int) num3 * 802599395;
            num1 = num8 ^ num9;
            continue;
          case 22:
            int num10 = flag2 ? 2132700291 : (num10 = 277121255);
            int num11 = (int) num3 * 990354765;
            num1 = num10 ^ num11;
            continue;
          case 23:
            activeMeeting = this.Engine.ActiveMeeting;
            num1 = (int) num3 * 685791702 ^ 1681412518;
            continue;
          case 24:
            int num12;
            num1 = num12 = zoomWindow2.IsVisible ? -1600991531 : (num12 = -137912587);
            continue;
          default:
            goto label_26;
        }
      }
label_26:
      return zoomWindow1;
    }

    static void \u206C‎⁭‌⁮⁯⁯‮⁪‭‪⁪‍⁯‎‬⁬‎‪‍⁭⁮‪‎‪⁮​⁭⁭⁬​⁬‎‎‪⁮​‮⁪‌‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202E​‭‌​‮‮‪⁬‏⁬⁬‮⁫⁫⁯‏⁯⁫‪⁮⁪‌‍‎‮‬⁫⁪⁮‪​‬‎‬‪⁯⁯‏⁭‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static void \u206A‌‎‫‍⁯‬‫⁮‬‪⁮‮‌​‌‌⁮‭​‎⁭​‮⁭‌‏‮‌⁬​‎‏‮⁫‌‍‏‭‍‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }

    static void \u206C‍⁬‏‌‍‭⁯‪⁭⁮‪⁯⁭‮⁭‮⁭‬⁪‏‌‮⁫‭⁪⁪‫‭⁯⁯⁪‌⁬‮‮‮⁪‪‏‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u202C⁫⁯⁮‬⁪‫‭‮⁮‏‪​‪⁭⁪‫⁬⁮‎‪⁬‎⁫⁬⁬​⁫‌‮‪‌‏‌‪⁬⁬‮​‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }

    static void \u206C‍‭⁯⁫⁫‎⁬‌‬‭‍‎⁯‎⁯‎‌⁫‪⁬‮‏‭‏⁪‎⁮​‭‮‫‭⁪⁪​⁫‍‫‏‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static Thread \u206D‭‌‮⁭​‏‌⁯‭‫⁭‭‫‮⁯‫⁫‍‭⁫⁭‪‌⁪‎‏‎⁮‫‪‫‌‎⁯​‏‏⁫‌‮([In] ThreadStart obj0)
    {
      return new Thread(obj0);
    }

    static void \u206F‍‌‍‪⁯​⁯‮‪‎‌​‫‏‌⁯⁯​⁫‏‏‏⁫⁬​‌⁮⁫‌‪⁬⁪‬‎⁫‬‏⁬‮‮([In] Thread obj0, [In] ApartmentState obj1)
    {
      obj0.SetApartmentState(obj1);
    }

    static void \u200F‫‭‮‎⁭‬⁯‎⁯‌‎‏⁯⁮‎‬⁫‫‌‭‮‪⁫‫‪‫‬⁭‬‏‭⁪⁬‍​‫‬‬‏‮([In] Thread obj0)
    {
      obj0.Start();
    }

    static System.Drawing.Point \u202D​⁭‏‍‪‍⁬⁮‎‬⁯​‫‫​⁮‍‏‌‍‪‬‫‭‬⁬‍‮‭⁭‏⁯⁭‎‪​‫‎⁭‮([In] MouseEventArgs obj0)
    {
      return obj0.Location;
    }

    static bool \u206B⁮‮⁯⁭⁬⁬⁭‌‎⁪‬⁬‪⁬⁭‌⁯⁮‌⁮⁫⁪⁮⁪‌⁮‮‏‎⁪‎⁭‮‮⁬⁪‮⁮⁮‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static bool \u202D‭​‏‍⁭‬⁭‪⁯⁯​‮⁯‭⁬⁮‬‌⁭⁪‮‭⁬​⁯‭​‏⁫⁭⁪⁮‍⁭⁫⁯‭‭‏‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u202E‪⁮‪⁮‎⁪⁫⁬‫⁯‏‬‪‫⁯⁪⁭‎⁭​‎⁫⁪‭⁫‎‌⁪⁭​‮‏⁫‎‏⁮‬⁯⁯‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static string \u206A‬‪⁭‫‏​⁭‪‪⁪‪‭‎‫⁯‎⁭‪⁪‌‭‎‎​‭‭‬‍⁪⁪‫‌⁬​‭​‬⁭‬‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static void \u200F‎⁯‍⁯‌‪‭⁬⁮⁬‍⁪⁮‫‍⁪‏‪‮‫​‎⁯‏‭⁭​​‪⁫⁪‍‬‎‪‎‬⁫⁯‮([In] string obj0)
    {
      Clipboard.SetText(obj0);
    }

    static bool \u200B⁭‪⁫⁪‫⁪⁭‮⁪‌‪‭​⁯‏‌‎‬‬‎⁯‮‫⁭‎⁯⁪⁯‪‍‫⁬⁬‬‎‍​‬‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static Delegate \u200B‏‫‫‫‍‬⁮‌‮‪‪⁭‌‌‪​‌‭​‫⁬‏‮‌‭​‎⁪⁫‪⁫‎⁬‎‏⁬‎‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u200F‍⁭⁮‫‏⁭‭​‍‍⁫‬‌‫‪⁫‪‬⁭‌⁮⁬⁮‎‮‏‮‮⁬‍‮⁫⁪⁪‭‍‏‭‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static Process[] \u206B‌⁫‏‍‎‌‎⁮​‌⁯​‫‏‍⁫⁯⁭⁯‪‭‏​‫‏‭‫‮‎‏‌⁭‭‪⁬‫‭⁬⁯‮()
    {
      return Process.GetProcesses();
    }

    static string \u206F‬‮‌‮⁪⁭⁯‫⁪⁯‎‮⁭‏‬‬‍‌⁫‭‎‬‮⁭​‌‪‫‍‭‬‮⁫⁮‭⁫‌⁮‮‮([In] Process obj0)
    {
      return obj0.ProcessName;
    }

    static string \u206D‍‬‮⁭‭‪‍​‍‏‎⁮​‭‏​⁪⁫‬‍⁮‫‭‌⁮⁯⁪‏⁭‫⁯⁫‬⁭‍‬⁫‍⁯‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static bool \u200C⁪⁮‫⁬⁯‌‪‫‌⁬⁫⁪⁬‏‭​‍⁬‬‍‭‍⁬⁫⁮‍⁫⁬⁬⁮‭⁮‏‫‎⁭⁭⁯⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u202B‮​⁪⁪‫⁬⁪‮⁭‮‍‮⁭‭⁮⁮‌‭​‪‏⁪⁫⁬​‫⁬‭⁮‍‍‭‫‫⁭⁪⁯⁫‌‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.DebugFormat(obj1, obj2, obj3);
    }

    static object \u206E‫⁯⁯⁫⁪⁮⁭‎​‍​⁮‍‍‍‎⁪‫‫⁫‌‌​‍‭‫‫‭⁭⁬‫⁫‭⁯⁬⁬‏⁭⁪‮()
    {
      return new object();
    }
  }
}
