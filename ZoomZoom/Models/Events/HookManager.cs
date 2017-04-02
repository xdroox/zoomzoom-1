// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Events.HookManager
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace ZoomZoom.Models.Events
{
  internal class HookManager
  {
    private static readonly ILog log = HookManager.\u206A⁫⁪‏​‬⁪‍‍‭‍‬⁫‍⁫‍⁯‏‭‍‫‬‏⁭‎⁬‪‭‬‪⁭​⁪⁪⁬⁯⁬‭‎⁯‮(HookManager.\u202D⁮‍‭‮‏‮‭‌‎⁯⁮⁯‏‎⁪‫‮‏‎‮‭‏‫⁮‌⁪⁮‏⁮⁯‫‏​⁮⁯‫⁬‫⁪‮((MemberInfo) HookManager.\u200C‎​‏‬‮⁬⁫⁫‎⁪‍​‪⁯⁭⁫‪⁮⁪‌⁫‫⁫⁫‫‭‎‬‭‮‏‏‎‎‭⁪‌​‎‮()));
    private IntPtr hookHandle = IntPtr.Zero;
    private bool eventsHooked = false;
    private bool dispatcherCaptured = false;
    public const uint WINEVENT_OUTOFCONTEXT = 0;
    public const uint WINEVENT_SKIPOWNTHREAD = 1;
    public const uint WINEVENT_SKIPOWNPROCESS = 2;
    public const uint WINEVENT_INCONTEXT = 4;
    public const uint EVENT_MIN = 1;
    public const uint EVENT_MAX = 2147483647;
    private static HookManager.WinEventDelegate eventHandler;
    private static List<int> processIds;
    private static Dictionary<int, IntPtr> processHooks;
    private static Dictionary<int, IntPtr> processHookExs;
    private static readonly object hookLocker;
    private static ConcurrentQueue<ZoomEvent> hookQueue;
    private static Dispatcher dispatcher;

    public ConcurrentQueue<ZoomEvent> HookQueue
    {
      get
      {
        if (!this.eventsHooked)
          goto label_4;
label_1:
        int num1 = 142807935;
label_2:
        ConcurrentQueue<ZoomEvent> concurrentQueue;
        while (true)
        {
          int num2 = 2006026310;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_4;
            case 2:
              concurrentQueue = HookManager.hookQueue;
              num1 = (int) num3 * 587670518 ^ -1152078438;
              continue;
            case 3:
              num1 = (int) num3 * 188928478 ^ -1832820116;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return concurrentQueue;
label_4:
        concurrentQueue = (ConcurrentQueue<ZoomEvent>) null;
        num1 = 1904183008;
        goto label_2;
      }
    }

    public bool EventsHooked
    {
      get
      {
        bool eventsHooked = this.eventsHooked;
label_1:
        int num1 = 1553928973;
        while (true)
        {
          int num2 = 176422297;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1362318701 ^ 1359514074;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return eventsHooked;
      }
      private set
      {
        this.eventsHooked = value;
      }
    }

    public Dispatcher Dispatcher
    {
      get
      {
        return HookManager.dispatcher;
      }
      set
      {
label_1:
        int num1 = 1430277731;
        while (true)
        {
          int num2 = 1000494359;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              HookManager.dispatcher = value;
              num1 = (int) num3 * -681367466 ^ -2051487866;
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

    public bool DispatcherCaptured
    {
      get
      {
label_1:
        int num1 = -955888346;
        bool dispatcherCaptured;
        while (true)
        {
          int num2 = -1502771455;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 13538730 ^ 951616353;
              continue;
            case 3:
              dispatcherCaptured = this.dispatcherCaptured;
              num1 = (int) num3 * -985125251 ^ 298857167;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return dispatcherCaptured;
      }
      set
      {
label_1:
        int num1 = 195177476;
        while (true)
        {
          int num2 = 865640797;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.dispatcherCaptured = value;
              num1 = (int) num3 * -1611844596 ^ -193535554;
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

    static HookManager()
    {
label_1:
      int num1 = -75407970;
      while (true)
      {
        int num2 = -303532395;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            HookManager.hookQueue = new ConcurrentQueue<ZoomEvent>();
            HookManager.dispatcher = HookManager.\u206D‮​⁬‍⁪‎‌‫‭‭‬‬‪⁭⁯⁮⁭‮⁬‪⁯‬⁬​⁯‪‫‭‫‍​‭‌⁫⁮‌‪​‫‮((DispatcherObject) HookManager.\u202B⁮⁫‮‮‪‬‌⁮⁫‌‮⁭‍‍⁪⁬‌‏‏​⁯‬‬‮⁯⁯‎⁮‏‮‫‮⁪⁯⁬‮⁬‏⁬‮());
            num1 = (int) num3 * 235522609 ^ 869527012;
            continue;
          case 1:
            HookManager.eventHandler = new HookManager.WinEventDelegate(HookManager.WindowEventCallback);
            num1 = (int) num3 * -642584739 ^ 988186944;
            continue;
          case 2:
            HookManager.processIds = new List<int>();
            num1 = (int) num3 * 2113927599 ^ -1819671931;
            continue;
          case 3:
            goto label_3;
          case 4:
            HookManager.processHooks = new Dictionary<int, IntPtr>();
            HookManager.processHookExs = new Dictionary<int, IntPtr>();
            HookManager.hookLocker = HookManager.\u200D⁬⁫‌⁫‎‍‪‬⁫⁪⁮⁪‪⁬‌‏⁬‬‫‪⁮⁯⁪⁮‎⁫⁮‫⁭‫‫⁯‭​‪⁯‍⁮‫‮();
            num1 = (int) num3 * 586645316 ^ -895010633;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    public HookManager()
    {
label_1:
      int num1 = -1898483259;
      while (true)
      {
        int num2 = -11654053;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 321443329 ^ -1974173046;
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

    [DllImport("user32.dll")]
    private static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, HookManager.WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

    private void AttachHooks(Dispatcher dispatcher)
    {
label_1:
      int num1 = -1258500712;
      while (true)
      {
        int num2 = -1056149620;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 2087645879 ^ 766064603;
            continue;
          case 2:
            flag = this.Dispatcher != null;
            num1 = (int) num3 * -1209314319 ^ 123888676;
            continue;
          case 3:
            // ISSUE: method pointer
            HookManager.\u206A‌‎‍‌⁬‮⁬‫‍‬‍‮⁮‎‍⁫‬‌⁮‫​⁮‏⁪⁭⁮​‌⁮⁮‎⁮​‪‭⁭⁬‬‬‮(this.Dispatcher, new Action((object) this, __methodptr(\u003CAttachHooks\u003Eb__30_0)));
            num1 = (int) num3 * -178678497 ^ 1466645880;
            continue;
          case 4:
            num1 = (int) num3 * -133482093 ^ 264438465;
            continue;
          case 5:
            this.DispatcherCaptured = true;
            num1 = (int) num3 * 122988079 ^ -770793611;
            continue;
          case 6:
            goto label_3;
          case 7:
            int num4 = !flag ? -16965520 : (num4 = -333351258);
            int num5 = (int) num3 * 361160417;
            num1 = num4 ^ num5;
            continue;
          case 8:
            this.Dispatcher = dispatcher;
            num1 = (int) num3 * -1979408371 ^ 349291312;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      this.LoadProcesses();
label_1:
      int num1 = -771847636;
      while (true)
      {
        int num2 = -862516774;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1093720561 ^ 267516223;
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

    public void AttachHook(int processId, ZoomEventType zoomEventType)
    {
      bool flag1 = zoomEventType == ZoomEventType.Other;
label_1:
      int num1 = -185628562;
      IntPtr hmodWinEventProc;
      object hookLocker1;
      while (true)
      {
        int num2 = -313234430;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            hmodWinEventProc = IntPtr.Zero;
            num1 = -673193577;
            continue;
          case 1:
            hookLocker1 = HookManager.hookLocker;
            num1 = (int) num3 * -431802231 ^ -688924251;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_63;
          case 4:
            int num4 = flag1 ? 1372808417 : (num4 = 65425930);
            int num5 = (int) num3 * -1287855606;
            num1 = num4 ^ num5;
            continue;
          case 5:
            flag2 = HookManager.processHooks.ContainsKey(processId);
            num1 = (int) num3 * 1981207591 ^ -915294610;
            continue;
          case 7:
            if (flag2)
            {
              num1 = (int) num3 * 1057739000 ^ -746856461;
              continue;
            }
            goto label_26;
          default:
            goto label_9;
        }
      }
label_63:
      return;
label_9:
      bool flag3 = false;
      try
      {
        HookManager.\u206B⁭⁬⁮‌​⁫⁮‌‎‌⁮‍‍‫‪‍⁮⁪‍‮‏‪⁬⁭​⁬​‮‬‏‎⁯⁫‫‌‎‭‏‫‮(hookLocker1, ref flag3);
label_11:
        int num2 = -86272064;
        while (true)
        {
          int num3 = -313234430;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_11;
            case 1:
              num2 = (int) num4 * -1304470484 ^ -2099157477;
              continue;
            case 2:
              num2 = (int) num4 * -1741564109 ^ 33854682;
              continue;
            case 4:
              num2 = (int) num4 * -2011608800 ^ -1806528943;
              continue;
            case 5:
              hmodWinEventProc = HookManager.processHooks[processId];
              num2 = (int) num4 * -502308940 ^ 732669117;
              continue;
            default:
              goto label_23;
          }
        }
      }
      finally
      {
        if (flag3)
        {
label_18:
          int num2 = -1156269857;
          while (true)
          {
            int num3 = -313234430;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_18;
              case 1:
                HookManager.\u202A⁯⁬⁮‍⁬⁭‭⁭⁯⁮⁭⁬⁯‫‭​‍‫‍⁫‌‬⁪​‭⁫‪‭​‭‮‎‪⁫‌‌‮⁯‮(hookLocker1);
                num2 = (int) num4 * -1089658945 ^ 441210198;
                continue;
              case 3:
                num2 = (int) num4 * -925158341 ^ -1638230003;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_23:
label_24:
      int num6 = -891142001;
label_25:
      object hookLocker2;
      while (true)
      {
        int num2 = -313234430;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 4U)
        {
          case 1:
            goto label_26;
          case 2:
            hookLocker2 = HookManager.hookLocker;
            num6 = (int) num3 * 1846670525 ^ 1652304896;
            continue;
          case 3:
            goto label_24;
          default:
            goto label_28;
        }
      }
label_28:
      bool flag4 = false;
      uint eventType;
      try
      {
        HookManager.\u206B⁭⁬⁮‌​⁫⁮‌‎‌⁮‍‍‫‪‍⁮⁪‍‮‏‪⁬⁭​⁬​‮‬‏‎⁯⁫‫‌‎‭‏‫‮(hookLocker2, ref flag4);
label_30:
        int num2 = -1421867030;
        while (true)
        {
          int num3 = -313234430;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              hmodWinEventProc = HookManager.SetWinEventHook(eventType, eventType, hmodWinEventProc, HookManager.eventHandler, HookManager.\u202D‮​⁬‭‪‬⁬‍⁯‎‪⁫‫‭⁪⁯​‬‌‫‫⁫‭‏⁮‎‫‏‭‍⁫⁪‮⁭⁯⁭‫‍‮‮(processId), 0U, 2U);
              num2 = (int) num4 * -1686746304 ^ 976960716;
              continue;
            case 2:
              num2 = (int) num4 * 1042642645 ^ -1016467397;
              continue;
            case 3:
              goto label_30;
            case 4:
              num2 = (int) num4 * 142732665 ^ 456231279;
              continue;
            default:
              goto label_40;
          }
        }
      }
      finally
      {
        if (flag4)
        {
label_36:
          int num2 = -979931499;
          while (true)
          {
            int num3 = -313234430;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                HookManager.\u202A⁯⁬⁮‍⁬⁭‭⁭⁯⁮⁭⁬⁯‫‭​‍‫‍⁫‌‬⁪​‭⁫‪‭​‭‮‎‪⁫‌‌‮⁯‮(hookLocker2);
                num2 = (int) num4 * -2038564988 ^ -2006679181;
                continue;
              case 2:
                goto label_36;
              default:
                goto label_39;
            }
          }
        }
label_39:;
      }
label_40:
      bool flag5 = hmodWinEventProc == IntPtr.Zero;
label_41:
      int num7 = -193871203;
      object hookLocker3;
      while (true)
      {
        int num2 = -313234430;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num7 ^ num2)) % 10U)
        {
          case 0:
            flag2 = !HookManager.processHooks.ContainsKey(processId);
            num7 = (int) num3 * 1695798862 ^ -1454071604;
            continue;
          case 2:
            hookLocker3 = HookManager.hookLocker;
            num7 = (int) num3 * -81741239 ^ 1574270867;
            continue;
          case 3:
            num7 = (int) num3 * -37919572 ^ 282852624;
            continue;
          case 4:
            goto label_59;
          case 5:
            int num4 = flag5 ? 305265572 : (num4 = 971222882);
            int num5 = (int) num3 * -2134208257;
            num7 = num4 ^ num5;
            continue;
          case 6:
            if (flag2)
            {
              num7 = (int) num3 * -158464190 ^ 1304892206;
              continue;
            }
            goto label_71;
          case 7:
            goto label_41;
          case 8:
            num7 = (int) num3 * -1811283974 ^ -1576531522;
            continue;
          case 9:
            num7 = -1235575660;
            continue;
          default:
            goto label_51;
        }
      }
label_59:
      return;
label_51:
      bool flag6 = false;
      try
      {
        HookManager.\u206B⁭⁬⁮‌​⁫⁮‌‎‌⁮‍‍‫‪‍⁮⁪‍‮‏‪⁬⁭​⁬​‮‬‏‎⁯⁫‫‌‎‭‏‫‮(hookLocker3, ref flag6);
label_53:
        int num2 = -1986873168;
        while (true)
        {
          int num3 = -313234430;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_53;
            case 1:
              num2 = (int) num4 * -582891356 ^ -525162397;
              continue;
            case 3:
              num2 = (int) num4 * -1441507234 ^ -1313388344;
              continue;
            case 4:
              HookManager.processHooks.Add(processId, hmodWinEventProc);
              num2 = (int) num4 * -1968595993 ^ -1344071090;
              continue;
            default:
              goto label_67;
          }
        }
      }
      finally
      {
        if (flag6)
        {
label_61:
          int num2 = -1720646564;
          while (true)
          {
            int num3 = -313234430;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_61;
              case 1:
                num2 = (int) num4 * 722369885 ^ -2075364900;
                continue;
              case 2:
                HookManager.\u202A⁯⁬⁮‍⁬⁭‭⁭⁯⁮⁭⁬⁯‫‭​‍‫‍⁫‌‬⁪​‭⁫‪‭​‭‮‎‪⁫‌‌‮⁯‮(hookLocker3);
                num2 = (int) num4 * 325823151 ^ 1911721701;
                continue;
              default:
                goto label_66;
            }
          }
        }
label_66:;
      }
label_67:
label_68:
      int num8 = -2110729341;
label_69:
      while (true)
      {
        int num2 = -313234430;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 8U)
        {
          case 0:
            num8 = -749683543;
            continue;
          case 1:
            goto label_71;
          case 2:
            num8 = (int) num3 * -1408025970 ^ 1731909446;
            continue;
          case 3:
            goto label_70;
          case 4:
            num8 = (int) num3 * -1776422279 ^ 1093087497;
            continue;
          case 5:
            num8 = (int) num3 * 828574942 ^ 1617735670;
            continue;
          case 6:
            goto label_68;
          case 7:
            this.CreateExistingWindowEvents(processId);
            num8 = (int) num3 * -1448396686 ^ 717262425;
            continue;
          default:
            goto label_55;
        }
      }
label_55:
      return;
label_70:
      return;
label_71:
      int num9;
      num8 = num9 = zoomEventType == ZoomEventType.Create ? -235814362 : (num9 = -925757094);
      goto label_69;
label_26:
      eventType = ZoomEvent.GetEventType(zoomEventType);
      GCHandle.Alloc((object) HookManager.eventHandler);
      num6 = -847073292;
      goto label_25;
    }

    internal void DetachHooks()
    {
label_1:
      int num1 = 122482078;
      while (true)
      {
        int num2 = 1562001010;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            HookManager.processHooks.Keys.ToList<int>().ForEach((Action<int>) (o => this.DetachHook(o, HookManager.processHooks[o])));
            num1 = (int) num3 * 558147914 ^ 2063064197;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void DetachHook(List<int> processesNotRunning)
    {
label_1:
      int num1 = -283058338;
      while (true)
      {
        int num2 = -495753939;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1643876241 ^ 2023668683;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      using (List<int>.Enumerator enumerator = processesNotRunning.GetEnumerator())
      {
label_10:
        int num2 = !enumerator.MoveNext() ? -1366703776 : (num2 = -538251989);
        while (true)
        {
          int num3 = -495753939;
          uint num4;
          int current;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_10;
            case 1:
              this.DetachHook(current, IntPtr.Zero);
              num2 = (int) num4 * 1277029386 ^ 1988343651;
              continue;
            case 2:
              current = enumerator.Current;
              num2 = -552966748;
              continue;
            case 3:
              goto label_13;
            case 4:
              num2 = (int) num4 * 2141271708 ^ -1194642803;
              continue;
            case 5:
              num2 = -538251989;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_13:;
      }
    }

    internal bool DetachHook(int processId, IntPtr hookHandle)
    {
label_1:
      int num1 = 338200765;
      object hookLocker;
      while (true)
      {
        int num2 = 383434736;
        uint num3;
        bool flag;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 1:
            if (!hookHandle.Equals((object) IntPtr.Zero))
            {
              num4 = 0;
              goto label_11;
            }
            else
            {
              num1 = (int) num3 * -2056190575 ^ -1179570943;
              continue;
            }
          case 2:
            hookHandle = HookManager.processHooks[processId];
            num1 = (int) num3 * -200162707 ^ 1527406817;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1755655246 ^ 1154995104;
            continue;
          case 5:
            num5 = ZoomZoom.NativeMethods.UnhookWinEvent(hookHandle) ? 1 : 0;
            break;
          case 6:
            num4 = HookManager.processHooks.ContainsKey(processId) ? 1 : 0;
            goto label_11;
          case 7:
            if (hookHandle.Equals((object) IntPtr.Zero))
            {
              num5 = 0;
              break;
            }
            num1 = 251312215;
            continue;
          case 8:
            hookLocker = HookManager.hookLocker;
            num1 = (int) num3 * -1751992075 ^ 740474702;
            continue;
          case 9:
            int num6 = flag ? -658753773 : (num6 = -28521406);
            int num7 = (int) num3 * 1534342455;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_18;
        }
        if (num5 != 0)
        {
          num1 = 220808612;
          continue;
        }
        goto label_35;
label_11:
        flag = num4 != 0;
        num1 = 710280725;
      }
label_18:
      bool flag1 = false;
      try
      {
        Monitor.Enter(hookLocker, ref flag1);
label_20:
        int num2 = 1571720126;
        while (true)
        {
          int num3 = 383434736;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_20;
            case 2:
              num2 = (int) num4 * -472023186 ^ 1345584319;
              continue;
            case 3:
              HookManager.processHooks.Remove(processId);
              num2 = (int) num4 * 2145929224 ^ 233346945;
              continue;
            default:
              goto label_30;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_25:
          int num2 = 1446752930;
          while (true)
          {
            int num3 = 383434736;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                num2 = (int) num4 * 1310159596 ^ 1568685896;
                continue;
              case 2:
                Monitor.Exit(hookLocker);
                num2 = (int) num4 * 1827757604 ^ -903279687;
                continue;
              case 3:
                goto label_25;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
label_30:
      bool flag2 = true;
label_31:
      int num8 = 1230741418;
label_32:
      while (true)
      {
        int num2 = 383434736;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 5U)
        {
          case 0:
            goto label_35;
          case 1:
            num8 = (int) num3 * -344190921 ^ -1783900938;
            continue;
          case 2:
            goto label_31;
          case 3:
            flag2 = false;
            num8 = (int) num3 * 1015998408 ^ -961443816;
            continue;
          default:
            goto label_36;
        }
      }
label_36:
      return flag2;
label_35:
      num8 = 1090225567;
      goto label_32;
    }

    private void LoadProcesses()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      HookManager.\u003C\u003Ec__DisplayClass36_0 cDisplayClass360 = new HookManager.\u003C\u003Ec__DisplayClass36_0();
label_1:
      int num1 = 958320079;
      List<int> list;
      while (true)
      {
        int num2 = 1565411424;
        uint num3;
        Process[] processArray1;
        int index;
        Process process;
        Process[] processArray2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
label_42:
            if (index >= processArray1.Length)
            {
              num4 = 105774146;
              goto label_38;
            }
            else
              goto case 5;
          case 1:
            processArray2 = HookManager.\u206F‍‌​‫‬⁯‍‭​‌‎‮‎‭‌⁫‍⁬‌‮​⁭‮⁭‮​⁫⁪‭​‎⁯‎‬⁮⁪‫⁫⁬‮();
            num1 = (int) num3 * 1477266203 ^ 1148514346;
            continue;
          case 2:
            goto label_1;
          case 3:
            index = 0;
            num1 = (int) num3 * -410440284 ^ -612497971;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass360.foundProcesses = new List<int>();
            processArray1 = processArray2;
            num1 = (int) num3 * -1654831344 ^ -797502954;
            continue;
          case 5:
            process = processArray1[index];
            num1 = 757500092;
            continue;
          default:
            try
            {
              // ISSUE: reference to a compiler-generated field
              cDisplayClass360.foundProcesses.Add(HookManager.\u206A‮‍‎‪‬‌⁭‌‪‎‍⁫‎‌⁭‪​⁯‪‮‌⁭⁪⁯‎‪‍​‏‏⁬‫⁮‏⁪⁮⁬⁭⁭‮(process));
              string str = HookManager.\u200F‮​‌‮‭⁪‪‏‬‌‍‮‫‮⁯⁫‍‮⁭‪‫‫‭​‫​‏⁪‎‌‭‍‭‬‬⁭‎⁭‭‮(HookManager.\u202B⁫⁬‍​‌⁬⁫⁪⁬‎⁪⁬‌‬‍‍‎⁮‮‎⁬⁮‏‭‭⁪⁭​‏⁪⁮‫‭⁮​⁪‬‬⁪‮(process));
label_9:
              int num5 = 1853312473;
              object hookLocker;
              while (true)
              {
                int num6 = 1565411424;
                uint num7;
                bool flag;
                int num8;
                switch ((num7 = (uint) (num5 ^ num6)) % 8U)
                {
                  case 0:
                    num8 = !HookManager.processIds.Contains(HookManager.\u206A‮‍‎‪‬‌⁭‌‪‎‍⁫‎‌⁭‪​⁯‪‮‌⁭⁪⁯‎‪‍​‏‏⁬‫⁮‏⁪⁮⁬⁭⁭‮(process)) ? 1 : 0;
                    break;
                  case 1:
                    int num9 = HookManager.\u202A‎⁮‎‫‪‌​⁬⁮‪‌‏‌⁬⁮‎⁫‌⁮‬⁯‮‪‫‎‮‫⁯‌‬⁭‫⁬⁯⁪‍‭⁮‮‮(str, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1680903117U)) ? 497378699 : (num9 = 1897376944);
                    int num10 = (int) num7 * 710333843;
                    num5 = num9 ^ num10;
                    continue;
                  case 2:
                    num5 = (int) num7 * -505422206 ^ 1627712233;
                    continue;
                  case 3:
                    if (HookManager.\u202A‎⁮‎‫‪‌​⁬⁮‪‌‏‌⁬⁮‎⁫‌⁮‬⁯‮‪‫‎‮‫⁯‌‬⁭‫⁬⁯⁪‍‭⁮‮‮(str, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2140122346U)))
                    {
                      num5 = (int) num7 * -953966209 ^ -1959576027;
                      continue;
                    }
                    num8 = 0;
                    break;
                  case 4:
                    goto label_9;
                  case 5:
                    hookLocker = HookManager.hookLocker;
                    num5 = (int) num7 * -1199529171 ^ 125755751;
                    continue;
                  case 7:
                    if (flag)
                    {
                      num5 = (int) num7 * -699132226 ^ -1956398824;
                      continue;
                    }
                    goto label_36;
                  default:
                    goto label_21;
                }
                flag = num8 != 0;
                num5 = 1508466607;
              }
label_21:
              bool flag1 = false;
              try
              {
                HookManager.\u206B⁭⁬⁮‌​⁫⁮‌‎‌⁮‍‍‫‪‍⁮⁪‍‮‏‪⁬⁭​⁬​‮‬‏‎⁯⁫‫‌‎‭‏‫‮(hookLocker, ref flag1);
label_23:
                int num6 = 1910523519;
                while (true)
                {
                  int num7 = 1565411424;
                  uint num8;
                  switch ((num8 = (uint) (num6 ^ num7)) % 6U)
                  {
                    case 0:
                      HookManager.processIds.Add(HookManager.\u206A‮‍‎‪‬‌⁭‌‪‎‍⁫‎‌⁭‪​⁯‪‮‌⁭⁪⁯‎‪‍​‏‏⁬‫⁮‏⁪⁮⁬⁭⁭‮(process));
                      num6 = (int) num8 * 1986113770 ^ -1240350568;
                      continue;
                    case 1:
                      num6 = (int) num8 * -1115099502 ^ -349846183;
                      continue;
                    case 2:
                      goto label_23;
                    case 4:
                      num6 = (int) num8 * 1218721833 ^ 845898873;
                      continue;
                    case 5:
                      num6 = (int) num8 * 1158447710 ^ -2050130016;
                      continue;
                    default:
                      goto label_34;
                  }
                }
              }
              finally
              {
                if (flag1)
                {
label_30:
                  int num6 = 755076745;
                  while (true)
                  {
                    int num7 = 1565411424;
                    uint num8;
                    switch ((num8 = (uint) (num6 ^ num7)) % 3U)
                    {
                      case 1:
                        HookManager.\u202A⁯⁬⁮‍⁬⁭‭⁭⁯⁮⁭⁬⁯‫‭​‍‫‍⁫‌‬⁪​‭⁫‪‭​‭‮‎‪⁫‌‌‮⁯‮(hookLocker);
                        num6 = (int) num8 * -1998119693 ^ -1527046051;
                        continue;
                      case 2:
                        goto label_30;
                      default:
                        goto label_33;
                    }
                  }
                }
label_33:;
              }
label_34:;
            }
            catch (Exception ex)
            {
              HookManager.\u206B⁪​⁬‮‮‎‪‪⁪‭‍‏⁭‭⁭⁬‏⁪⁪‮​‭‌‭‏‫‍⁫‌⁬‭‎⁬​‌⁮‭‮‎‮(HookManager.log, (object) ex);
            }
label_36:
            break;
        }
label_37:
        num4 = 1551262301;
label_38:
        while (true)
        {
          int num5 = 1565411424;
          uint num6;
          switch ((num6 = (uint) (num4 ^ num5)) % 6U)
          {
            case 0:
              goto label_37;
            case 1:
              ++index;
              num4 = (int) num6 * -947745840 ^ 1949262773;
              continue;
            case 2:
              // ISSUE: method pointer
              list = ((IEnumerable<int>) Enumerable.Where<int>((IEnumerable<M0>) HookManager.processIds, (Func<M0, bool>) new Func<int, bool>((object) cDisplayClass360, __methodptr(\u003CLoadProcesses\u003Eb__0)))).ToList<int>();
              num4 = (int) num6 * -325139820 ^ -34323394;
              continue;
            case 4:
              num4 = (int) num6 * -1885949499 ^ 1430620665;
              continue;
            case 5:
              goto label_42;
            default:
              goto label_44;
          }
        }
      }
label_44:
      using (List<int>.Enumerator enumerator = list.GetEnumerator())
      {
label_50:
        int num2 = enumerator.MoveNext() ? 1370022949 : (num2 = 1295532572);
        while (true)
        {
          int num3 = 1565411424;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = 1370022949;
              continue;
            case 1:
              goto label_50;
            case 2:
              this.DetachHook(list);
              num2 = (int) num4 * 2140381862 ^ -535027547;
              continue;
            case 3:
              int current = enumerator.Current;
              num2 = 969544869;
              continue;
            case 5:
              num2 = (int) num4 * 2071444980 ^ 879263962;
              continue;
            default:
              goto label_53;
          }
        }
      }
label_53:
      using (List<int>.Enumerator enumerator1 = HookManager.processIds.GetEnumerator())
      {
label_87:
        if (enumerator1.MoveNext())
        {
label_57:
          int current = enumerator1.Current;
          int num2 = 2088557549;
          while (true)
          {
            int num3 = 1565411424;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = 909317642;
                continue;
              case 1:
                if (!HookManager.processHooks.ContainsKey(current))
                {
                  num2 = (int) num4 * -1843122297 ^ -1802669432;
                  continue;
                }
                goto label_86;
              case 2:
                goto label_57;
              default:
                goto label_60;
            }
          }
label_60:
          // ISSUE: type reference
          IEnumerator enumerator2 = HookManager.\u202C‬⁮​‮⁪‌⁪⁯⁫⁯‮⁬‫‭⁮‌‫⁬⁬‬⁫‮⁭⁭⁮⁬⁮‬⁯‭⁮‌⁬⁫‏‫‍‎‬‮(HookManager.\u200D⁯⁫⁭⁭‮‎‌‪⁬‎⁮‎‮‎⁯‮⁯⁪‫‮⁬‮‎‫‫⁯⁯‭‌‏⁫‌‏‫​​‪⁬⁪‮(HookManager.\u200C‏⁪⁯⁯‮‍‮⁭⁮‍‏​‫‏⁬‪‎‫‮‎‮⁭‍‫⁭⁫‬⁪⁫⁫‍‪‪‍‫⁫‌‮⁪‮(__typeref (ZoomEventType))));
          try
          {
label_64:
            int num3 = !HookManager.\u206A⁫‫‮⁫‎⁯⁪⁯⁯‪‍⁪‬⁮⁯‭⁭‬⁮‮‭‏‌‍⁮‎‬‪‌⁫⁮‌⁮‎⁫⁬‭‎‍‮(enumerator2) ? 757218699 : (num3 = 1950677797);
            while (true)
            {
              int num4 = 1565411424;
              uint num5;
              ZoomEventType zoomEventType;
              bool flag;
              int num6;
              switch ((num5 = (uint) (num3 ^ num4)) % 10U)
              {
                case 0:
                  num3 = 1950677797;
                  continue;
                case 1:
                  if (zoomEventType != ZoomEventType.Other)
                  {
                    num3 = (int) num5 * 1938733204 ^ -2051103343;
                    continue;
                  }
                  num6 = 0;
                  break;
                case 2:
                  num3 = (int) num5 * 1633033531 ^ 1630622339;
                  continue;
                case 3:
                  num3 = 1423129978;
                  continue;
                case 4:
                  goto label_64;
                case 5:
                  num6 = zoomEventType != ZoomEventType.Undefined ? 1 : 0;
                  break;
                case 6:
                  int num7 = !flag ? 1314411627 : (num7 = 2069231996);
                  int num8 = (int) num5 * -2103356397;
                  num3 = num7 ^ num8;
                  continue;
                case 8:
                  this.AttachHook(current, zoomEventType);
                  num3 = (int) num5 * -795816722 ^ 2032195592;
                  continue;
                case 9:
                  zoomEventType = (ZoomEventType) HookManager.\u202B‌⁫‍‪⁪‬‍‏‍⁪⁪⁭‏‍‌⁬‮‪​‭‌‬​⁪⁮⁭‎‌⁫⁬⁪‍⁬‮‭⁬‌‪‪‮(enumerator2);
                  num3 = 1059606527;
                  continue;
                default:
                  goto label_82;
              }
              flag = num6 != 0;
              num3 = 1034528488;
            }
          }
          finally
          {
            IDisposable disposable = enumerator2 as IDisposable;
label_76:
            int num3 = 520644625;
            while (true)
            {
              int num4 = 1565411424;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 5U)
              {
                case 0:
                  HookManager.\u206E⁪⁭⁬⁭‌‮⁪‌‮‬‏⁪‮⁫⁭‪‭‮⁯⁯‍‍‎⁪‫‫⁯⁭⁫⁪‬‫‍⁪‍‎⁯‭‏‮(disposable);
                  num3 = (int) num5 * -2104567654 ^ 1681520944;
                  continue;
                case 1:
                  int num6 = disposable == null ? -1824067873 : (num6 = -543536606);
                  int num7 = (int) num5 * 2025013722;
                  num3 = num6 ^ num7;
                  continue;
                case 3:
                  num3 = (int) num5 * 1071274720 ^ 620202981;
                  continue;
                case 4:
                  goto label_76;
                default:
                  goto label_81;
              }
            }
label_81:;
          }
label_82:;
        }
        else
          goto label_88;
label_83:
        int num9 = 1059542426;
label_84:
        int num10 = 1565411424;
        uint num11;
        switch ((num11 = (uint) (num9 ^ num10)) % 4U)
        {
          case 0:
            goto label_83;
          case 1:
            return;
          case 2:
            break;
          case 3:
            goto label_87;
          default:
            return;
        }
label_86:
        num9 = 1926487551;
        goto label_84;
label_88:
        num9 = 1831718377;
        goto label_84;
      }
    }

    private Process GetProcByID(int id)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      HookManager.\u003C\u003Ec__DisplayClass37_0 cDisplayClass370 = new HookManager.\u003C\u003Ec__DisplayClass37_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass370.id = id;
label_1:
      int num1 = -2000260363;
      Process process;
      while (true)
      {
        int num2 = -1079395085;
        uint num3;
        Process[] processArray;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            processArray = HookManager.\u206F‍‌​‫‬⁯‍‭​‌‎‮‎‭‌⁫‍⁬‌‮​⁭‮⁭‮​⁫⁪‭​‎⁯‎‬⁮⁪‫⁫⁬‮();
            num1 = (int) num3 * 473141639 ^ -1403811430;
            continue;
          case 3:
            // ISSUE: method pointer
            process = (Process) Enumerable.FirstOrDefault<Process>((IEnumerable<M0>) processArray, (Func<M0, bool>) new Func<Process, bool>((object) cDisplayClass370, __methodptr(\u003CGetProcByID\u003Eb__0)));
            num1 = (int) num3 * 944812301 ^ 1872706261;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return process;
    }

    private void CreateExistingWindowEvents(int processId)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      HookManager.\u003C\u003Ec__DisplayClass38_0 cDisplayClass380 = new HookManager.\u003C\u003Ec__DisplayClass38_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass380.processId = processId;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        HookManager.\u003C\u003Ec__DisplayClass38_1 cDisplayClass381 = new HookManager.\u003C\u003Ec__DisplayClass38_1();
label_2:
        int num1 = -1657794010;
        Process process;
        while (true)
        {
          int num2 = -1350795801;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_2;
            case 1:
              List<IntPtr> numList = new List<IntPtr>();
              // ISSUE: method pointer
              process = (Process) Enumerable.FirstOrDefault<Process>((IEnumerable<M0>) ((IEnumerable<Process>) HookManager.\u206F‍‌​‫‬⁯‍‭​‌‎‮‎‭‌⁫‍⁬‌‮​⁭‮⁭‮​⁫⁪‭​‎⁯‎‬⁮⁪‫⁫⁬‮()).ToList<Process>(), (Func<M0, bool>) new Func<Process, bool>((object) cDisplayClass380, __methodptr(\u003CCreateExistingWindowEvents\u003Eb__0)));
              num1 = (int) num3 * 1384797653 ^ -1070904554;
              continue;
            case 2:
              if (flag)
              {
                num1 = (int) num3 * 433225157 ^ -921668622;
                continue;
              }
              goto label_45;
            case 3:
              num4 = !HookManager.\u202E⁮‭⁪‎⁮‭‫‭‭⁯‌‏‌⁬⁫⁯‌⁫‫‎⁮‬‫‍‏‍⁭‪⁭‏⁪⁪‭‭⁬‌‪⁯‍‮(process) ? 1 : 0;
              break;
            case 4:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass381.handleThreads = new Dictionary<IntPtr, int>();
              num1 = (int) num3 * -1247849222 ^ -845225311;
              continue;
            case 6:
              if (process != null)
              {
                num1 = (int) num3 * -678534155 ^ 1670155002;
                continue;
              }
              num4 = 0;
              break;
            case 7:
              num1 = (int) num3 * -101850650 ^ 469414944;
              continue;
            default:
              goto label_14;
          }
          flag = num4 != 0;
          num1 = -1636290331;
        }
label_45:
        return;
label_14:
        IEnumerator enumerator1 = HookManager.\u206A⁯‍​⁬‎‭‌⁪‍‍⁮‪⁭‌‬‍​‭⁭‭⁯‫⁮‪⁮‪‏⁭⁬⁭⁮‮‫⁪‭‫‪‬‮‮((ReadOnlyCollectionBase) HookManager.\u200C‏‪‪​‭⁮‎‮⁫⁭⁬⁮‫‫‏‌⁪‏⁪‭⁭‬⁮‭‮⁯⁪​‮⁪‮⁫‭⁭⁮⁮⁫‭⁪‮(process));
        try
        {
label_20:
          int num2 = HookManager.\u206A⁫‫‮⁫‎⁯⁪⁯⁯‪‍⁪‬⁮⁯‭⁭‬⁮‮‭‏‌‍⁮‎‬‪‌⁫⁮‌⁮‎⁫⁬‭‎‍‮(enumerator1) ? -613046979 : (num2 = -868054431);
          while (true)
          {
            int num3 = -1350795801;
            uint num4;
            // ISSUE: variable of a compiler-generated type
            HookManager.\u003C\u003Ec__DisplayClass38_2 cDisplayClass382;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                num2 = -613046979;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass382.CS\u0024\u003C\u003E8__locals1 = cDisplayClass381;
                // ISSUE: reference to a compiler-generated field
                cDisplayClass382.thread = (ProcessThread) HookManager.\u202B‌⁫‍‪⁪‬‍‏‍⁪⁪⁭‏‍‌⁬‮‪​‭‌‬​⁪⁮⁭‎‌⁫⁬⁪‍⁬‮‭⁬‌‪‪‮(enumerator1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ZoomZoom.NativeMethods.EnumThreadWindows(HookManager.\u202D‮​⁬‭‪‬⁬‍⁯‎‪⁫‫‭⁪⁯​‬‌‫‫⁫‭‏⁮‎‫‏‭‍⁫⁪‮⁭⁯⁭‫‍‮‮(HookManager.\u206B‏​⁮‌‎‬‬‏‮‪​‬⁭​⁪‌‬⁯‫⁫‮⁬‬⁭⁮‌​‌⁯⁯‍‍⁪​‪‏‌⁪‮‮(cDisplayClass382.thread)), new ZoomZoom.NativeMethods.EnumThreadWindowsProc(cDisplayClass382.\u003CCreateExistingWindowEvents\u003Eb__1), 0);
                num2 = (int) num4 * -2086390572 ^ -1979680154;
                continue;
              case 3:
                goto label_20;
              case 4:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass382 = new HookManager.\u003C\u003Ec__DisplayClass38_2();
                num2 = -1245157037;
                continue;
              default:
                goto label_27;
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator1 as IDisposable;
label_22:
          int num2 = -1145923898;
          while (true)
          {
            int num3 = -1350795801;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                HookManager.\u206E⁪⁭⁬⁭‌‮⁪‌‮‬‏⁪‮⁫⁭‪‭‮⁯⁯‍‍‎⁪‫‫⁯⁭⁫⁪‬‫‍⁪‍‎⁯‭‏‮(disposable);
                num2 = (int) num4 * -1468040221 ^ -524681787;
                continue;
              case 1:
                int num5 = disposable == null ? -898227907 : (num5 = -183007529);
                int num6 = (int) num4 * 175387244;
                num2 = num5 ^ num6;
                continue;
              case 3:
                goto label_22;
              default:
                goto label_26;
            }
          }
label_26:;
        }
label_27:
        // ISSUE: reference to a compiler-generated field
        using (Dictionary<IntPtr, int>.KeyCollection.Enumerator enumerator2 = cDisplayClass381.handleThreads.Keys.GetEnumerator())
        {
label_34:
          int num2 = enumerator2.MoveNext() ? -1765165497 : (num2 = -553789582);
          while (true)
          {
            int num3 = -1350795801;
            uint num4;
            IntPtr current;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                num2 = (int) num4 * 859768964 ^ -2028141333;
                continue;
              case 1:
                goto label_34;
              case 2:
                num2 = -1765165497;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.CreateExistingWindowEvent(this.hookHandle, current, cDisplayClass380.processId, cDisplayClass381.handleThreads[current]);
                num2 = (int) num4 * -2032993547 ^ 1227467282;
                continue;
              case 5:
                current = enumerator2.Current;
                num2 = -1973299748;
                continue;
              case 6:
                num2 = (int) num4 * 65481829 ^ 1116241247;
                continue;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
      catch (Exception ex)
      {
label_41:
        int num1 = -463241903;
        while (true)
        {
          int num2 = -1350795801;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_39;
            case 1:
              HookManager.\u206B⁪​⁬‮‮‎‪‪⁪‭‍‏⁭‭⁭⁬‏⁪⁪‮​‭‌‭‏‫‍⁫‌⁬‭‎⁬​‌⁮‭‮‎‮(HookManager.log, (object) ex);
              num1 = (int) num3 * -348425207 ^ -625973918;
              continue;
            case 2:
              num1 = (int) num3 * -1193712965 ^ -1099086620;
              continue;
            case 3:
              goto label_41;
            default:
              goto label_36;
          }
        }
label_36:
        return;
label_39:;
      }
    }

    private void CreateExistingWindowEvent(IntPtr hookHandle, IntPtr windowHandle, int processId, int threadId)
    {
      try
      {
label_2:
        int num1 = 967861108;
        ZoomEvent zoomEvent;
        while (true)
        {
          int num2 = 683949081;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              zoomEvent = new ZoomEvent(hookHandle, windowHandle, ZoomEventType.Create, processId, HookManager.\u202D‮​⁬‭‪‬⁬‍⁯‎‪⁫‫‭⁪⁯​‬‌‫‫⁫‭‏⁮‎‫‏‭‍⁫⁪‮⁭⁯⁭‫‍‮‮(threadId), 0U);
              num1 = (int) num3 * -2129491160 ^ -1232237482;
              continue;
            case 2:
              goto label_2;
            case 3:
              if (zoomEvent != null)
              {
                num1 = (int) num3 * -786713884 ^ -1719189403;
                continue;
              }
              goto label_19;
            default:
              goto label_7;
          }
        }
label_19:
        return;
label_7:
        object hookLocker = HookManager.hookLocker;
        bool flag = false;
        try
        {
          HookManager.\u206B⁭⁬⁮‌​⁫⁮‌‎‌⁮‍‍‫‪‍⁮⁪‍‮‏‪⁬⁭​⁬​‮‬‏‎⁯⁫‫‌‎‭‏‫‮(hookLocker, ref flag);
label_9:
          int num2 = 1777027518;
          while (true)
          {
            int num3 = 683949081;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                goto label_9;
              case 1:
                HookManager.hookQueue.Enqueue(zoomEvent);
                num2 = (int) num4 * 1898789299 ^ 1388752738;
                continue;
              case 2:
                num2 = (int) num4 * 2147273287 ^ -1154417351;
                continue;
              case 3:
                num2 = (int) num4 * 647500343 ^ -1208383379;
                continue;
              case 5:
                num2 = (int) num4 * 1004365555 ^ -467549579;
                continue;
              case 6:
                num2 = (int) num4 * 1399982672 ^ 709584762;
                continue;
              default:
                goto label_23;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_17:
            int num2 = 2037958680;
            while (true)
            {
              int num3 = 683949081;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  num2 = (int) num4 * 861426283 ^ -141592474;
                  continue;
                case 1:
                  HookManager.\u202A⁯⁬⁮‍⁬⁭‭⁭⁯⁮⁭⁬⁯‫‭​‍‫‍⁫‌‬⁪​‭⁫‪‭​‭‮‎‪⁫‌‌‮⁯‮(hookLocker);
                  num2 = (int) num4 * 44066271 ^ 1071260142;
                  continue;
                case 2:
                  goto label_17;
                default:
                  goto label_22;
              }
            }
          }
label_22:;
        }
label_23:;
      }
      catch (Exception ex)
      {
      }
    }

    private static void WindowEventCallback(IntPtr winEventHookHandle, uint eventType, IntPtr windowHandle, int idObject, int idChild, uint eventThreadId, uint eventTimeInMilliseconds)
    {
label_1:
      int num1 = 391221731;
      while (true)
      {
        int num2 = 2103659556;
        uint num3;
        object[] objArray;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            int num4 = !flag ? -1552518326 : (num4 = -1721236842);
            int num5 = (int) num3 * -1159853051;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag = !windowHandle.Equals((object) IntPtr.Zero);
            num1 = (int) num3 * -278191102 ^ 2121185023;
            continue;
          case 2:
            goto label_1;
          case 3:
            objArray = new object[7]
            {
              (object) winEventHookHandle,
              (object) eventType,
              (object) windowHandle,
              (object) idObject,
              (object) idChild,
              (object) eventThreadId,
              (object) eventTimeInMilliseconds
            };
            num1 = (int) num3 * -2141591303 ^ -351687809;
            continue;
          case 4:
            ThreadPool.QueueUserWorkItem(new WaitCallback(HookManager.WindowEventCallback), (object) objArray);
            num1 = (int) num3 * -528574077 ^ -1087322946;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 1513987750 ^ -826070065;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private static void WindowEventCallback(object arg)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      HookManager.\u003C\u003Ec__DisplayClass41_0 cDisplayClass410 = new HookManager.\u003C\u003Ec__DisplayClass41_0();
label_1:
      int num1 = -1905748753;
      while (true)
      {
        int num2 = -911830758;
        uint num3;
        bool flag1;
        object[] objArray;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            int num4 = flag1 ? 1255470825 : (num4 = 192989716);
            int num5 = (int) num3 * -73885333;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag1 = HookManager.dispatcher != null;
            num1 = (int) num3 * -78323621 ^ -1776380459;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            HookManager.hookQueue.Enqueue(cDisplayClass410.message);
            num1 = -69985717;
            continue;
          case 3:
            // ISSUE: method pointer
            HookManager.\u206A‌‎‍‌⁬‮⁬‫‍‬‍‮⁮‎‍⁫‬‌⁮‫​⁮‏⁪⁭⁮​‌⁮⁮‎⁮​‪‭⁭⁬‬‬‮(HookManager.dispatcher, new Action((object) cDisplayClass410, __methodptr(\u003CWindowEventCallback\u003Eb__0)));
            num1 = (int) num3 * 714282441 ^ -1411587363;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass410.message = new ZoomEvent((IntPtr) objArray[0], (IntPtr) objArray[2], (uint) objArray[1], 0, (uint) objArray[5], (uint) objArray[5]);
            num1 = (int) num3 * -2133385101 ^ 531664668;
            continue;
          case 5:
            objArray = arg as object[];
            num1 = (int) num3 * -111109767 ^ 2115190675;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            flag2 = cDisplayClass410.message != null;
            num1 = (int) num3 * 227251527 ^ -1734848409;
            continue;
          case 7:
            goto label_3;
          case 8:
            num1 = (int) num3 * 623700285 ^ -988093896;
            continue;
          case 9:
            num1 = (int) num3 * -1665014067 ^ 588194212;
            continue;
          case 10:
            goto label_1;
          case 11:
            int num6 = !flag2 ? -1744605291 : (num6 = -1338985281);
            int num7 = (int) num3 * -1335371516;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    static void \u206A‌‎‍‌⁬‮⁬‫‍‬‍‮⁮‎‍⁫‬‌⁮‫​⁮‏⁪⁭⁮​‌⁮⁮‎⁮​‪‭⁭⁬‬‬‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static void \u206B⁭⁬⁮‌​⁫⁮‌‎‌⁮‍‍‫‪‍⁮⁪‍‮‏‪⁬⁭​⁬​‮‬‏‎⁯⁫‫‌‎‭‏‫‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202A⁯⁬⁮‍⁬⁭‭⁭⁯⁮⁭⁬⁯‫‭​‍‫‍⁫‌‬⁪​‭⁫‪‭​‭‮‎‪⁫‌‌‮⁯‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static uint \u202D‮​⁬‭‪‬⁬‍⁯‎‪⁫‫‭⁪⁯​‬‌‫‫⁫‭‏⁮‎‫‏‭‍⁫⁪‮⁭⁯⁭‫‍‮‮([In] int obj0)
    {
      return Convert.ToUInt32(obj0);
    }

    static Process[] \u206F‍‌​‫‬⁯‍‭​‌‎‮‎‭‌⁫‍⁬‌‮​⁭‮⁭‮​⁫⁪‭​‎⁯‎‬⁮⁪‫⁫⁬‮()
    {
      return Process.GetProcesses();
    }

    static int \u206A‮‍‎‪‬‌⁭‌‪‎‍⁫‎‌⁭‪​⁯‪‮‌⁭⁪⁯‎‪‍​‏‏⁬‫⁮‏⁪⁮⁬⁭⁭‮([In] Process obj0)
    {
      return obj0.Id;
    }

    static string \u202B⁫⁬‍​‌⁬⁫⁪⁬‎⁪⁬‌‬‍‍‎⁮‮‎⁬⁮‏‭‭⁪⁭​‏⁪⁮‫‭⁮​⁪‬‬⁪‮([In] Process obj0)
    {
      return obj0.ProcessName;
    }

    static string \u200F‮​‌‮‭⁪‪‏‬‌‍‮‫‮⁯⁫‍‮⁭‪‫‫‭​‫​‏⁪‎‌‭‍‭‬‬⁭‎⁭‭‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static bool \u202A‎⁮‎‫‪‌​⁬⁮‪‌‏‌⁬⁮‎⁫‌⁮‬⁯‮‪‫‎‮‫⁯‌‬⁭‫⁬⁯⁪‍‭⁮‮‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u206B⁪​⁬‮‮‎‪‪⁪‭‍‏⁭‭⁭⁬‏⁪⁪‮​‭‌‭‏‫‍⁫‌⁬‭‎⁬​‌⁮‭‮‎‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static Type \u200C‏⁪⁯⁯‮‍‮⁭⁮‍‏​‫‏⁬‪‎‫‮‎‮⁭‍‫⁭⁫‬⁪⁫⁫‍‪‪‍‫⁫‌‮⁪‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static Array \u200D⁯⁫⁭⁭‮‎‌‪⁬‎⁮‎‮‎⁯‮⁯⁪‫‮⁬‮‎‫‫⁯⁯‭‌‏⁫‌‏‫​​‪⁬⁪‮([In] Type obj0)
    {
      return Enum.GetValues(obj0);
    }

    static IEnumerator \u202C‬⁮​‮⁪‌⁪⁯⁫⁯‮⁬‫‭⁮‌‫⁬⁬‬⁫‮⁭⁭⁮⁬⁮‬⁯‭⁮‌⁬⁫‏‫‍‎‬‮([In] Array obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u202B‌⁫‍‪⁪‬‍‏‍⁪⁪⁭‏‍‌⁬‮‪​‭‌‬​⁪⁮⁭‎‌⁫⁬⁪‍⁬‮‭⁬‌‪‪‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static bool \u206A⁫‫‮⁫‎⁯⁪⁯⁯‪‍⁪‬⁮⁯‭⁭‬⁮‮‭‏‌‍⁮‎‬‪‌⁫⁮‌⁮‎⁫⁬‭‎‍‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u206E⁪⁭⁬⁭‌‮⁪‌‮‬‏⁪‮⁫⁭‪‭‮⁯⁯‍‍‎⁪‫‫⁯⁭⁫⁪‬‫‍⁪‍‎⁯‭‏‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static bool \u202E⁮‭⁪‎⁮‭‫‭‭⁯‌‏‌⁬⁫⁯‌⁫‫‎⁮‬‫‍‏‍⁭‪⁭‏⁪⁪‭‭⁬‌‪⁯‍‮([In] Process obj0)
    {
      return obj0.HasExited;
    }

    static ProcessThreadCollection \u200C‏‪‪​‭⁮‎‮⁫⁭⁬⁮‫‫‏‌⁪‏⁪‭⁭‬⁮‭‮⁯⁪​‮⁪‮⁫‭⁭⁮⁮⁫‭⁪‮([In] Process obj0)
    {
      return obj0.Threads;
    }

    static IEnumerator \u206A⁯‍​⁬‎‭‌⁪‍‍⁮‪⁭‌‬‍​‭⁭‭⁯‫⁮‪⁮‪‏⁭⁬⁭⁮‮‫⁪‭‫‪‬‮‮([In] ReadOnlyCollectionBase obj0)
    {
      return obj0.GetEnumerator();
    }

    static int \u206B‏​⁮‌‎‬‬‏‮‪​‬⁭​⁪‌‬⁯‫⁫‮⁬‬⁭⁮‌​‌⁯⁯‍‍⁪​‪‏‌⁪‮‮([In] ProcessThread obj0)
    {
      return obj0.Id;
    }

    static MethodBase \u200C‎​‏‬‮⁬⁫⁫‎⁪‍​‪⁯⁭⁫‪⁮⁪‌⁫‫⁫⁫‫‭‎‬‭‮‏‏‎‎‭⁪‌​‎‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202D⁮‍‭‮‏‮‭‌‎⁯⁮⁯‏‎⁪‫‮‏‎‮‭‏‫⁮‌⁪⁮‏⁮⁯‫‏​⁮⁯‫⁬‫⁪‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206A⁫⁪‏​‬⁪‍‍‭‍‬⁫‍⁫‍⁯‏‭‍‫‬‏⁭‎⁬‪‭‬‪⁭​⁪⁪⁬⁯⁬‭‎⁯‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static object \u200D⁬⁫‌⁫‎‍‪‬⁫⁪⁮⁪‪⁬‌‏⁬‬‫‪⁮⁯⁪⁮‎⁫⁮‫⁭‫‫⁯‭​‪⁯‍⁮‫‮()
    {
      return new object();
    }

    static Application \u202B⁮⁫‮‮‪‬‌⁮⁫‌‮⁭‍‍⁪⁬‌‏‏​⁯‬‬‮⁯⁯‎⁮‏‮‫‮⁪⁯⁬‮⁬‏⁬‮()
    {
      return Application.Current;
    }

    static Dispatcher \u206D‮​⁬‍⁪‎‌‫‭‭‬‬‪⁭⁯⁮⁭‮⁬‪⁯‬⁬​⁯‪‫‭‫‍​‭‌⁫⁮‌‪​‫‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static DispatcherTimer \u200B⁮‬​‍⁮⁬‪⁪⁫⁪‍⁫⁮⁪⁪⁯​​‪⁮⁬⁪⁬⁪‮‬‮‫‭​​​⁬‭⁪‏‪​‬‮()
    {
      return new DispatcherTimer();
    }

    static void \u202B‮‮⁫‬​⁭‌⁮⁬⁮⁭‬⁬⁪‌‎⁫‏‮‪⁬⁪‬⁭⁬​⁯⁭‍‭​⁮⁯⁪⁫​‭‍‮‮([In] DispatcherTimer obj0, [In] TimeSpan obj1)
    {
      obj0.Interval = obj1;
    }

    static void \u200D‮‌⁬‪‍​⁬‏‌⁭⁮‭‭‍‏⁪​‍‫‮‏⁭‫‎‮‬‮‭‍‏‮⁪⁪‍‫‭​​‪‮([In] DispatcherTimer obj0, [In] EventHandler obj1)
    {
      obj0.Tick += obj1;
    }

    static void \u200F​⁫⁮⁯‮⁮⁭⁫‬‪‍‬⁭‬⁯‍‮⁫⁮‌‭‏‫⁬‭‍⁯‌‭⁪‭‎‍‪‬⁪‌⁭⁯‮([In] DispatcherTimer obj0)
    {
      obj0.Start();
    }

    private delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);
  }
}
