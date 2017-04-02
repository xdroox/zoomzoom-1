// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.WindowSelector
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ZoomZoom.Views
{
  public class WindowSelector : Window, IComponentConnector
  {
    private static readonly object selectorLock = WindowSelector.\u200B⁪⁯‬‭​‪⁫‭‫‭‪⁪‬‪​⁭⁯‬⁪‬⁫‪⁮‮⁭‏⁪‎⁮‫‍​⁫⁪⁪⁫⁬‪‮‮();
    private IntPtr _selectedHWnd = IntPtr.Zero;
    private IntPtr _hoveredHWnd = IntPtr.Zero;
    private Dispatcher mainDispatcher = (Dispatcher) null;
    private object lockingObject = (object) null;
    private ZoomWindow selectedWindow = (ZoomWindow) null;
    private List<ZoomWindowType> selectableTypes = new List<ZoomWindowType>();
    private Engine engine = (Engine) null;
    private System.Windows.Point _mouseDown;
    private CancellationToken cancellationToken;
    private DispatcherTimer timer;
    protected readonly IEventAggregator _eventAggregator;
    private SubscriptionToken eventToken;
    internal Rectangle SelectorRectangle;
    private bool _contentLoaded;

    public IntPtr SelectedHWnd
    {
      get
      {
label_1:
        int num1 = -73242659;
        IntPtr selectedHwnd;
        while (true)
        {
          int num2 = -402086424;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              selectedHwnd = this._selectedHWnd;
              num1 = (int) num3 * 2024152395 ^ 1789951224;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedHwnd;
      }
      private set
      {
label_1:
        int num1 = -1910421635;
        object selectorLock;
        while (true)
        {
          int num2 = -1556033514;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              selectorLock = WindowSelector.selectorLock;
              num1 = (int) num3 * 2134706128 ^ 2004698789;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock, ref flag);
label_6:
          int num2 = -1641161690;
          while (true)
          {
            int num3 = -1556033514;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_6;
              case 2:
                num2 = (int) num4 * -1154738692 ^ 1229573950;
                continue;
              default:
                goto label_9;
            }
          }
label_9:
          this._selectedHWnd = value;
        }
        finally
        {
          if (flag)
          {
label_11:
            int num2 = -1626350731;
            while (true)
            {
              int num3 = -1556033514;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_11;
                case 2:
                  num2 = (int) num4 * -135410802 ^ 309595779;
                  continue;
                case 3:
                  WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock);
                  num2 = (int) num4 * -26587867 ^ -1117590185;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
      }
    }

    public CancellationToken Token
    {
      get
      {
        return this.cancellationToken;
      }
      set
      {
label_1:
        int num1 = 1802365278;
        object selectorLock;
        while (true)
        {
          int num2 = 502498025;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              selectorLock = WindowSelector.selectorLock;
              num1 = (int) num3 * 976553156 ^ 176535862;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock, ref flag);
label_6:
          int num2 = 56483830;
          while (true)
          {
            int num3 = 502498025;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_6;
              case 1:
                this.cancellationToken = value;
                num2 = (int) num4 * 1819764240 ^ -1674839228;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_9;
            }
          }
label_9:
          return;
label_13:;
        }
        finally
        {
          if (flag)
          {
label_11:
            int num2 = 472459043;
            while (true)
            {
              int num3 = 502498025;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_11;
                case 2:
                  WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock);
                  num2 = (int) num4 * 1247475913 ^ -1940210508;
                  continue;
                case 3:
                  num2 = (int) num4 * -101791229 ^ 1759484049;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
    }

    public Dispatcher MainDispatcher
    {
      get
      {
        Dispatcher mainDispatcher = this.mainDispatcher;
label_1:
        int num1 = 406886819;
        while (true)
        {
          int num2 = 1291627955;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 782472635 ^ 1323751664;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return mainDispatcher;
      }
      set
      {
label_1:
        int num1 = -182870866;
        object selectorLock;
        while (true)
        {
          int num2 = -1132067549;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              selectorLock = WindowSelector.selectorLock;
              num1 = (int) num3 * 1907910694 ^ -1457319656;
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
          WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock, ref flag);
label_6:
          int num2 = -1374732880;
          while (true)
          {
            int num3 = -1132067549;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_6;
              case 1:
                this.mainDispatcher = value;
                num2 = (int) num4 * 1048372058 ^ -1629602171;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_9;
            }
          }
label_9:
          return;
label_13:;
        }
        finally
        {
          if (flag)
          {
label_11:
            int num2 = -1313650944;
            while (true)
            {
              int num3 = -1132067549;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_11;
                case 2:
                  WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock);
                  num2 = (int) num4 * 1615556335 ^ 1391636363;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
      }
    }

    public object LockingObject
    {
      get
      {
label_1:
        int num1 = 273497071;
        object lockingObject;
        while (true)
        {
          int num2 = 871520863;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              lockingObject = this.lockingObject;
              num1 = (int) num3 * -393588938 ^ -566944811;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return lockingObject;
      }
      private set
      {
        object selectorLock = WindowSelector.selectorLock;
        bool flag = false;
        try
        {
          WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock, ref flag);
label_2:
          int num1 = 585183851;
          while (true)
          {
            int num2 = 1471064054;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                this.lockingObject = value;
                num1 = (int) num3 * 90251740 ^ -561604196;
                continue;
              case 2:
                goto label_9;
              default:
                goto label_5;
            }
          }
label_5:
          return;
label_9:;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num1 = 652006389;
            while (true)
            {
              int num2 = 1471064054;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 1:
                  WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock);
                  num1 = (int) num3 * 283458129 ^ -205608435;
                  continue;
                case 2:
                  goto label_7;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
      }
    }

    public bool IsLocked
    {
      get
      {
        bool flag = this.LockingObject != null;
label_1:
        int num1 = 222750491;
        while (true)
        {
          int num2 = 308917907;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 81723749 ^ -1957623878;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return flag;
      }
    }

    public ZoomWindow SelectedWindow
    {
      get
      {
        ZoomWindow selectedWindow = this.selectedWindow;
label_1:
        int num1 = -321584357;
        while (true)
        {
          int num2 = -1260692580;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -198175445 ^ -1651167302;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedWindow;
      }
      set
      {
label_1:
        int num1 = 1455457031;
        object selectorLock;
        while (true)
        {
          int num2 = 2009802256;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              selectorLock = WindowSelector.selectorLock;
              num1 = (int) num3 * 1998184895 ^ -1141984342;
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
          WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock, ref flag);
label_6:
          int num2 = 1722783115;
          while (true)
          {
            int num3 = 2009802256;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_6;
              case 1:
                goto label_14;
              case 2:
                this.selectedWindow = value;
                num2 = (int) num4 * 1657319858 ^ -437322007;
                continue;
              case 3:
                num2 = (int) num4 * 1903879397 ^ 364688021;
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
            int num2 = 1432640133;
            while (true)
            {
              int num3 = 2009802256;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock);
                  num2 = (int) num4 * 433918386 ^ -1294557540;
                  continue;
                case 2:
                  num2 = (int) num4 * -490379680 ^ 2080609340;
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
    }

    public DispatcherTimer Timer
    {
      get
      {
label_1:
        int num1 = 88859912;
        DispatcherTimer timer;
        while (true)
        {
          int num2 = 861185117;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1912261141 ^ -1912491762;
              continue;
            case 1:
              timer = this.timer;
              num1 = (int) num3 * -813173721 ^ 1179304774;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return timer;
      }
      set
      {
        this.timer = value;
      }
    }

    public Engine Engine
    {
      get
      {
label_1:
        int num1 = 229789547;
        Engine engine;
        while (true)
        {
          int num2 = 1723035326;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              engine = this.engine;
              num1 = (int) num3 * -1435593762 ^ 890679602;
              continue;
            case 2:
              num1 = (int) num3 * 419017807 ^ -672192441;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return engine;
      }
      set
      {
        this.engine = value;
      }
    }

    public SubscriptionToken EventToken
    {
      get
      {
        return this.eventToken;
      }
      set
      {
        this.eventToken = value;
      }
    }

    public event EventHandler WindowSelected
    {
      add
      {
        EventHandler eventHandler = this.WindowSelected;
label_1:
        int num1 = -693741523;
        while (true)
        {
          int num2 = -1087197386;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              EventHandler comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.WindowSelected, (EventHandler) WindowSelector.\u202D⁭‍‫‬‏‌‬⁫‮⁮⁭⁯‭‮‌‭‏‏‫‍⁫⁮⁯‫⁫⁬‎‎‏‏‎⁪‫‬⁮⁪‍‪‬‮((Delegate) comparand, (Delegate) value), comparand);
              int num4;
              num1 = num4 = eventHandler == comparand ? -671243552 : (num4 = -693741523);
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
        EventHandler eventHandler1 = this.WindowSelected;
label_1:
        int num1 = 92257550;
        while (true)
        {
          int num2 = 1778425759;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.WindowSelected, eventHandler2, comparand);
              int num4 = eventHandler1 == comparand ? 699449646 : (num4 = 1937747302);
              int num5 = (int) num3 * -497192152;
              num1 = num4 ^ num5;
              continue;
            case 2:
              comparand = eventHandler1;
              num1 = 641747798;
              continue;
            case 3:
              eventHandler2 = (EventHandler) WindowSelector.\u200B‭‮‍‍‮‍​‫‍‎⁪‮⁯‬‭‭‫‍‪‏⁮‎⁫‪⁮‍⁯⁭‎⁫⁭⁬‬‫‭⁪​‍‫‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -813027427 ^ -1498747053;
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

    public event EventHandler Canceled
    {
      add
      {
        EventHandler eventHandler1 = this.Canceled;
label_1:
        int num1 = -1645815383;
        while (true)
        {
          int num2 = -37081448;
          uint num3;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) WindowSelector.\u202D⁭‍‫‬‏‌‬⁫‮⁮⁭⁯‭‮‌‭‏‏‫‍⁫⁮⁯‫⁫⁬‎‎‏‏‎⁪‫‬⁮⁪‍‪‬‮((Delegate) comparand, (Delegate) value);
              num1 = -84654841;
              continue;
            case 2:
              goto label_1;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.Canceled, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? -2000446164 : (num4 = -1165947439);
              int num5 = (int) num3 * 968629595;
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
        EventHandler eventHandler = this.Canceled;
label_1:
        int num1 = -1608384388;
        while (true)
        {
          int num2 = -2102411202;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.Canceled, (EventHandler) WindowSelector.\u200B‭‮‍‍‮‍​‫‍‎⁪‮⁯‬‭‭‫‍‪‏⁮‎⁫‪⁮‍⁯⁭‎⁫⁭⁬‬‫‭⁪​‍‫‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * 1155219117 ^ -1200501475;
              continue;
            case 1:
              int num4 = eventHandler == comparand ? 1118468927 : (num4 = 783976546);
              int num5 = (int) num3 * 2000109993;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = eventHandler;
              num1 = -1597929825;
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
    }

    public event EventHandler LockChanged
    {
      add
      {
        EventHandler eventHandler1 = this.LockChanged;
label_1:
        int num1 = 795296536;
        while (true)
        {
          int num2 = 914321830;
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
              int num4 = eventHandler1 != comparand ? 1600579027 : (num4 = 1078590446);
              int num5 = (int) num3 * 465705685;
              num1 = num4 ^ num5;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.LockChanged, eventHandler2, comparand);
              num1 = (int) num3 * -458303011 ^ -958998986;
              continue;
            case 4:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler) WindowSelector.\u202D⁭‍‫‬‏‌‬⁫‮⁮⁭⁯‭‮‌‭‏‏‫‍⁫⁮⁯‫⁫⁬‎‎‏‏‎⁪‫‬⁮⁪‍‪‬‮((Delegate) comparand, (Delegate) value);
              num1 = 387401469;
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
        EventHandler eventHandler = this.LockChanged;
label_1:
        int num1 = 1562799638;
        while (true)
        {
          int num2 = 1359208603;
          uint num3;
          EventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = eventHandler;
              eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.LockChanged, (EventHandler) WindowSelector.\u200B‭‮‍‍‮‍​‫‍‎⁪‮⁯‬‭‭‫‍‪‏⁮‎⁫‪⁮‍⁯⁭‎⁫⁭⁬‬‫‭⁪​‍‫‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = 859569824;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = eventHandler != comparand ? -1086199980 : (num4 = -1225688655);
              int num5 = (int) num3 * 1511120294;
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
    }

    public WindowSelector()
    {
label_1:
      int num1 = 10720502;
      while (true)
      {
        int num2 = 320270757;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 26U)
        {
          case 0:
            num1 = (int) num3 * -792156298 ^ -1636083156;
            continue;
          case 1:
            WindowSelector.\u206D‪‭​‭‏‏‬⁪‬‎‪‏‬‏⁭⁮⁭​‭⁯‮⁭⁪​​⁫⁭⁯⁭⁬⁬​‮⁮‍⁯⁪‬⁮‮(this.Timer, new EventHandler(this.Timer_Tick));
            num1 = (int) num3 * -733874051 ^ -1676053656;
            continue;
          case 2:
            num1 = (int) num3 * -1523751170 ^ -1695439678;
            continue;
          case 3:
            this.\u206E‫‮‏‮⁬‏‪‮⁮⁬⁯⁯⁭‮‪⁯‍‫‌⁬‮‮‮‎‍‍‏⁪⁫‭‬‭‬‪⁬⁪‪‌‮‮(WindowSelector.\u202C​⁬⁫⁪‬‏⁪⁯‎‫‌⁭⁪​‍⁯‪⁯⁭⁫‮‮‮‏‮⁮⁫‬‌‬‪⁮⁪‭‮‭⁭‏‪‮());
            num1 = (int) num3 * -2013821637 ^ -1131889834;
            continue;
          case 4:
            this.\u202C‌⁯‎‎‌​⁭‏⁬⁬⁮‌‎‎‎‌‌⁭‮‏⁮‮‏⁬‭‪⁮‪‬‏‪‭‍‬⁪‬‫‫‭‮(new MouseEventHandler(this.CaptureWindow_MouseMove));
            num1 = (int) num3 * -1448768325 ^ -2051035886;
            continue;
          case 5:
            goto label_1;
          case 6:
            WindowSelector.\u206B⁪‪⁯‭⁬‮‏‎‎‮⁬⁫‮‫‌‎‬‭‎‎‪‫‮⁮‮⁪‭‌‪⁮⁮⁮‍⁫‪‍⁬⁫⁮‮((Window) this, WindowSelector.\u206B⁫‬‏‫​⁯⁮⁬‍‍⁮‌⁯‬‌⁮⁯⁮⁯‍⁫‬‌⁬​‏⁫⁫‏‪⁪‪⁫​⁪‮‌‎‬‮());
            this.\u202C‎⁯⁪‬⁭​⁪​⁯‍​‭​⁫‍⁮‮⁯⁪‬⁫‮‍‬‬‫⁭⁭‎‮⁯⁪‬⁭‭‪‏‬‮(WindowSelector.\u206E⁭⁯‍⁪‏‌‪‭‏⁬⁪​‎‪⁭‌‪‏‍⁭⁫‪‮‭‏⁬‭‌‮‬‭‬‫‮‮‭‏⁭⁪‮());
            num1 = (int) num3 * -598321718 ^ 1354835100;
            continue;
          case 7:
            num1 = (int) num3 * 725303677 ^ -338675654;
            continue;
          case 8:
            this.\u200F⁬‬‬‌⁫‌‪‎​⁯⁬⁫‫⁭‎⁪⁯⁯⁭​​‎‭⁯‬⁫⁫​‭‮⁪⁬‫‮‍‮⁪‏‪‮(new KeyEventHandler(this.CaptureWindow_KeyUp));
            num1 = (int) num3 * -1427428968 ^ 535604710;
            continue;
          case 9:
            this.\u206D‫⁪⁫‫‬‍⁫‎‪‭⁪⁪‫‪‎‭‍‫‭‬⁯‮‎‬‍‌‭‍‬⁯⁭‏‎‎​‏​​‏‮(new MouseButtonEventHandler(this.CaptureWindow_MouseLeftButtonDown));
            num1 = (int) num3 * 1242146744 ^ -2129124969;
            continue;
          case 10:
            goto label_3;
          case 11:
            WindowSelector.\u206F​⁭⁬‌⁬‪‎⁬‫⁫⁮‫‫⁯⁮‌⁯⁯⁪‮‭‌⁬⁫⁪‏‌​⁭‍⁯‎⁮‪‌‫‬‫‍‮((UIElement) this, new DependencyPropertyChangedEventHandler(this.WindowSelector_IsVisibleChanged));
            num1 = (int) num3 * 1509740502 ^ -733848313;
            continue;
          case 12:
            num1 = (int) num3 * -147518643 ^ -1022035693;
            continue;
          case 13:
            num1 = (int) num3 * -635902864 ^ -1476731171;
            continue;
          case 14:
            this._eventAggregator = ApplicationService.Instance.EventAggregator;
            this.EventToken = ((CompositePresentationEvent<SubscriptionToken>) this._eventAggregator.GetEvent<ViewEvent>()).Subscribe(new Action<SubscriptionToken>(this.ViewExit), (ThreadOption) 1);
            num1 = (int) num3 * -202567602 ^ -1485978005;
            continue;
          case 15:
            this.\u200B‌‮‍⁯‫⁯‏⁫‬⁭‭‫‏‪‪‫⁯⁪‌⁭⁮​‌‮‮‮‪‪⁭⁬⁭‭‎⁯‏⁮⁫⁫⁪‮(new MouseButtonEventHandler(this.CaptureWindow_MouseLeftButtonUp));
            num1 = (int) num3 * 455446998 ^ -1852152994;
            continue;
          case 16:
            WindowSelector.\u206E⁯⁮‭‌​‮‪‫‪​‬‪⁫‌⁭⁭‪‫⁫⁫​⁫‬‮⁫‎‮⁫‬‪​‭‪‭⁮‪‭⁬‎‮((Control) this, (Brush) WindowSelector.\u202E‬⁭‌​⁮‎⁬‏‍‌‭‬‭‎​‭‬‎‍⁯⁭​‪‎⁭‎⁮⁪‮​⁮‫⁫‍‍⁫‍‮⁭‮(Color.FromArgb((byte) 1, (byte) 0, (byte) 0, (byte) 0)));
            num1 = (int) num3 * -980369426 ^ 1943820951;
            continue;
          case 17:
            WindowSelector.\u200C‎‎‮‬⁪‭⁭⁭⁪⁭‏‮‮‏‭‎⁫‮‌​‍⁪⁫‎‭⁬‮‎‎‌⁮​⁫‪⁫‮⁬‫‭‮((Window) this, new CancelEventHandler(this.CaptureWindow_Closing));
            num1 = (int) num3 * -1446556056 ^ 1135703786;
            continue;
          case 18:
            num1 = (int) num3 * -1305273697 ^ 1705716520;
            continue;
          case 19:
            this.Timer = WindowSelector.\u200F‮‎‬‌‮⁫‎‮‪⁬⁬​⁭‌⁬⁬​⁭⁯⁬‭‎‭‫‏‫‌‎⁯‭⁯⁬⁫‬⁪⁪‮‬‎‮(DispatcherPriority.Normal, WindowSelector.\u202A‪⁬‎‪‪‏⁫⁮‫⁬‫⁭‪⁮⁮‬⁮​⁫‪‏⁪‭‮⁭‎‫‎⁮⁬‬‏‮‪‍‌‎‌‮((DispatcherObject) this));
            num1 = (int) num3 * 100419267 ^ -976156975;
            continue;
          case 20:
            WindowSelector.\u206F​‌‮‍‪‭‪‮⁭⁮‍⁬⁭‏‫‏‭‏‫‮‭⁮‍‫‪⁬‮‌‏⁫‪​​⁬‪⁯‎‍‮‮((Window) this, WindowSelector.\u202C⁫‪‍⁭‫⁭‮‪‭‪‬‏‫⁯‫⁯⁯⁫‬‮‏⁮​⁮⁮⁬⁫⁬‍‪‪⁬‎‌⁯⁭⁫​‏‮());
            num1 = (int) num3 * -1687787879 ^ 715994029;
            continue;
          case 21:
            this.InitializeComponent();
            num1 = (int) num3 * -592505574 ^ 1757921089;
            continue;
          case 22:
            num1 = (int) num3 * 1769858123 ^ -1371963005;
            continue;
          case 23:
            num1 = (int) num3 * 1598186502 ^ 364601939;
            continue;
          case 24:
            WindowSelector.\u200B‫‌‮‫‫⁪‌⁭‌⁫‪‌‭⁬⁪⁬‌⁬⁯⁬‎⁫‮‭‌‎​⁭‫‮‬‫‭⁫⁮⁯‎‍⁫‮(this.Timer, TimeSpan.FromMilliseconds(100.0));
            num1 = (int) num3 * 1170668431 ^ 1173211202;
            continue;
          case 25:
            WindowSelector.\u202B⁭‎⁭⁯⁪‫⁪‫​⁪‮⁪‫‮‎‌‭⁮⁬⁬⁯⁬⁫⁪​⁭‪‍‎⁬‌‏‏‮‬‭‭⁫⁬‮((FrameworkElement) this, (RoutedEventHandler) ((s, e) =>
            {
label_1:
              int num2 = -343906653;
              while (true)
              {
                int num3 = -427882393;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    WindowSelector.\u202C⁯⁭‏‎‌‪⁯‭‌‫​⁯‭⁫⁪‮‬‍⁯⁭⁫‭⁯‏‭‌⁭⁭‮‪‌‏‍⁯‮​‏‎⁫‮((Window) this);
                    num2 = (int) num4 * 1045660735 ^ 386931321;
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
            }));
            num1 = (int) num3 * -130103936 ^ 1513534574;
            continue;
          default:
            goto label_28;
        }
      }
label_28:
      return;
label_3:;
    }

    protected void OnWindowSelected()
    {
label_1:
      int num1 = -1068792403;
      while (true)
      {
        int num2 = -1774866591;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 2056989837 ^ 902376616;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            flag = this.WindowSelected != null;
            num1 = (int) num3 * -702975205 ^ 2087712070;
            continue;
          case 3:
            int num4 = flag ? -826295348 : (num4 = -1988386536);
            int num5 = (int) num3 * 1627604515;
            num1 = num4 ^ num5;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.WindowSelected((object) this, EventArgs.Empty);
            num1 = (int) num3 * 1197962772 ^ -446846548;
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

    protected void OnCanceled()
    {
label_1:
      int num1 = 433925940;
      while (true)
      {
        int num2 = 1961900438;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -1726892420 ^ -1777214423;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            int num4 = this.Canceled == null ? -1549958123 : (num4 = -335792518);
            int num5 = (int) num3 * 2084994588;
            num1 = num4 ^ num5;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.Canceled((object) this, EventArgs.Empty);
            num1 = (int) num3 * 95624122 ^ 710496865;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    protected void OnLockChanged()
    {
label_1:
      int num1 = -1350299252;
      while (true)
      {
        int num2 = -1019685048;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated field
            flag = this.LockChanged != null;
            num1 = (int) num3 * -1115304543 ^ 1770290467;
            continue;
          case 3:
            num1 = (int) num3 * 21309142 ^ 888617410;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.LockChanged((object) this, EventArgs.Empty);
            num1 = (int) num3 * -1222487619 ^ 96612902;
            continue;
          case 5:
            num1 = (int) num3 * -991372332 ^ 1966495306;
            continue;
          case 6:
            int num4 = flag ? -1864753227 : (num4 = -1260167977);
            int num5 = (int) num3 * 1077626723;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private void ViewExit(SubscriptionToken obj)
    {
label_1:
      int num1 = 147972572;
      while (true)
      {
        int num2 = 869711146;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * 1120883017 ^ -2076397603;
            continue;
          case 1:
            num4 = this.EventToken != obj ? 1 : 0;
            break;
          case 2:
            // ISSUE: method pointer
            WindowSelector.\u202A⁬⁪​⁫‍⁭‬‎‍⁬‏‭⁮‎⁪​‮⁮‫⁪‫‎‏⁯‌‭⁮⁮‬‍‏​⁭‍‎‌⁭⁮‮‮(WindowSelector.\u206E‬‎‫‪⁭⁫⁭⁯⁯⁮‍‏⁮​‭‎⁮‎⁭⁬​‎⁬​⁬⁮​‬⁬‭‮⁫‬‌⁪‬⁬‪‌‮(this.timer), new Action((object) this, __methodptr(\u003CViewExit\u003Eb__52_0)));
            num1 = (int) num3 * -1598924872 ^ -1028427246;
            continue;
          case 3:
            goto label_3;
          case 4:
            int num5 = !flag ? -1958616051 : (num5 = -1861157604);
            int num6 = (int) num3 * -593093141;
            num1 = num5 ^ num6;
            continue;
          case 5:
            goto label_1;
          case 6:
            if (obj == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 63580391 ^ -1095590639;
            continue;
          case 7:
            num1 = (int) num3 * -1395362677 ^ -1863756292;
            continue;
          default:
            goto label_13;
        }
        flag = num4 != 0;
        num1 = 292614566;
      }
label_13:
      return;
label_3:;
    }

    private void WindowSelector_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      CancellationToken token = this.Token;
label_1:
      int num1 = 1082670757;
      while (true)
      {
        int num2 = 1640329938;
        uint num3;
        bool flag;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            goto label_1;
          case 1:
            if (this.IsLocked)
            {
              num4 = 0;
              break;
            }
            num1 = 1532691372;
            continue;
          case 2:
            num1 = (int) num3 * -272238175 ^ 162380534;
            continue;
          case 3:
            num5 = this.Engine.EngineState != EngineState.Executing ? 1 : 0;
            goto label_18;
          case 4:
            this.Hide();
            num1 = (int) num3 * -441034012 ^ -1495481318;
            continue;
          case 5:
            num1 = (int) num3 * -967400694 ^ -1861034206;
            continue;
          case 6:
            goto label_3;
          case 7:
            // ISSUE: explicit reference operation
            if (!((CancellationToken) @token).get_IsCancellationRequested())
            {
              num1 = (int) num3 * -1332523394 ^ -923754822;
              continue;
            }
            goto label_17;
          case 8:
            num1 = (int) num3 * -333765009 ^ 892957254;
            continue;
          case 9:
            this.Close();
            num1 = (int) num3 * -892139152 ^ 1090195559;
            continue;
          case 10:
            if (this.Engine != null)
            {
              num1 = (int) num3 * 987773743 ^ -260898809;
              continue;
            }
            goto label_17;
          case 11:
            num1 = (int) num3 * 1631459602 ^ -2081009024;
            continue;
          case 12:
            num1 = (int) num3 * 2145110689 ^ -1002352376;
            continue;
          case 13:
            this.Timer.Stop();
            num1 = (int) num3 * -1987339544 ^ 256162307;
            continue;
          case 14:
            num4 = this.Visibility == Visibility.Visible ? 1 : 0;
            break;
          case 15:
            int num6 = !flag ? -1731899362 : (num6 = -173834654);
            int num7 = (int) num3 * -969914045;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_25;
        }
        int num8;
        num1 = num8 = num4 != 0 ? 479617081 : (num8 = 1014573940);
        continue;
label_17:
        num5 = 1;
label_18:
        flag = num5 != 0;
        num1 = 436871357;
      }
label_25:
      return;
label_3:;
    }

    internal bool Lock(object requestingLocker, EventHandler selectedHandler, EventHandler canceledHandler, List<ZoomWindowType> windowTypes = null)
    {
      object selectorLock1 = WindowSelector.selectorLock;
      bool flag1 = false;
      object lockingObject;
      try
      {
        WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock1, ref flag1);
        lockingObject = this.LockingObject;
      }
      finally
      {
        if (flag1)
        {
label_3:
          int num1 = 227149522;
          while (true)
          {
            int num2 = 2100656388;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_3;
              case 2:
                WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock1);
                num1 = (int) num3 * -1186969497 ^ -886689671;
                continue;
              default:
                goto label_6;
            }
          }
        }
label_6:;
      }
      if (lockingObject == null)
        goto label_14;
label_8:
      int num4 = 1178148685;
label_9:
      bool flag2;
      while (true)
      {
        int num1 = 2100656388;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 5U)
        {
          case 1:
            goto label_13;
          case 2:
            num4 = (int) num2 * -599927245 ^ -204843436;
            continue;
          case 3:
            goto label_8;
          case 4:
            if (flag2)
            {
              num4 = (int) num2 * 520019915 ^ 693425095;
              continue;
            }
            goto label_40;
          default:
            goto label_16;
        }
      }
label_13:
      int num5 = lockingObject == requestingLocker ? 1 : 0;
      goto label_15;
label_16:
      object selectorLock2 = WindowSelector.selectorLock;
      bool flag3 = false;
      try
      {
        WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock2, ref flag3);
        this.LockingObject = requestingLocker;
      }
      finally
      {
        if (flag3)
        {
label_19:
          int num1 = 869664091;
          while (true)
          {
            int num2 = 2100656388;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_19;
              case 2:
                WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock2);
                num1 = (int) num3 * -307942942 ^ 1934527422;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
      object selectorLock3 = WindowSelector.selectorLock;
      bool flag4 = false;
      try
      {
        WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock3, ref flag4);
label_25:
        int num1 = 482627730;
        while (true)
        {
          int num2 = 2100656388;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1154129201 ^ -318170820;
              continue;
            case 2:
              goto label_25;
            default:
              goto label_28;
          }
        }
label_28:
        this.selectableTypes = windowTypes;
      }
      finally
      {
        if (flag4)
        {
label_30:
          int num1 = 968950837;
          while (true)
          {
            int num2 = 2100656388;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock3);
                num1 = (int) num3 * 537719957 ^ 1202718227;
                continue;
              case 2:
                num1 = (int) num3 * 801794504 ^ -237135296;
                continue;
              case 3:
                goto label_30;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
      this.Canceled += canceledHandler;
label_36:
      int num6 = 1640390185;
label_37:
      bool flag5;
      while (true)
      {
        int num1 = 2100656388;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 9U)
        {
          case 1:
            flag5 = true;
            num6 = (int) num2 * -1467684660 ^ -224603353;
            continue;
          case 2:
            goto label_40;
          case 3:
            goto label_36;
          case 4:
            this.WindowSelected += selectedHandler;
            num6 = (int) num2 * 1102491147 ^ -2005429556;
            continue;
          case 5:
            num6 = (int) num2 * 1327811362 ^ 204502273;
            continue;
          case 6:
            WindowSelector.\u206F‏‍⁫‌⁫‮‏⁮⁪​‏‫​‍‌​⁯‍⁮‫‎‬‎‬⁪⁯⁮‫⁬⁮‮⁮‎⁫‮⁬⁮‬⁭‮((Window) this);
            num6 = (int) num2 * -1380647349 ^ 1945726044;
            continue;
          case 7:
            num6 = (int) num2 * 2089656191 ^ 549309888;
            continue;
          case 8:
            num6 = (int) num2 * -200959675 ^ -1371116484;
            continue;
          default:
            goto label_45;
        }
      }
label_45:
      return flag5;
label_40:
      flag5 = false;
      num6 = 1223897292;
      goto label_37;
label_14:
      num5 = 1;
label_15:
      flag2 = num5 != 0;
      num4 = 125954926;
      goto label_9;
    }

    internal bool Unlock(object requestingLocker)
    {
      object selectorLock1 = WindowSelector.selectorLock;
      bool flag1 = false;
      object lockingObject;
      try
      {
        WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock1, ref flag1);
label_2:
        int num1 = 1283270043;
        while (true)
        {
          int num2 = 1299183228;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 2:
              num1 = (int) num3 * 1841005338 ^ -1135581855;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        lockingObject = this.LockingObject;
      }
      finally
      {
        if (flag1)
        {
label_7:
          int num1 = 345999023;
          while (true)
          {
            int num2 = 1299183228;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * 642699706 ^ -676043307;
                continue;
              case 2:
                goto label_7;
              case 3:
                WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock1);
                num1 = (int) num3 * -263692920 ^ -567017304;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
      if (lockingObject == null)
        goto label_16;
label_13:
      int num4 = 810275948;
label_14:
      object selectorLock2;
      while (true)
      {
        int num1 = 1299183228;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 5U)
        {
          case 0:
            goto label_13;
          case 1:
            goto label_15;
          case 2:
            selectorLock2 = WindowSelector.selectorLock;
            num4 = (int) num2 * -1903481378 ^ -1517483499;
            continue;
          case 4:
            num4 = (int) num2 * -833832609 ^ -973732564;
            continue;
          default:
            goto label_21;
        }
      }
label_15:
      int num5 = lockingObject == requestingLocker ? 1 : 0;
      goto label_17;
label_21:
      bool flag2 = false;
      try
      {
        WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock2, ref flag2);
label_23:
        int num1 = 2121721586;
        while (true)
        {
          int num2 = 1299183228;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -272120942 ^ 575617874;
              continue;
            case 2:
              this.LockingObject = (object) null;
              num1 = (int) num3 * 1546879291 ^ -1880994521;
              continue;
            case 3:
              goto label_23;
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
          int num1 = 1339097330;
          while (true)
          {
            int num2 = 1299183228;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * 454777528 ^ -1185338188;
                continue;
              case 2:
                WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock2);
                num1 = (int) num3 * 851601933 ^ -1823861341;
                continue;
              case 3:
                goto label_28;
              default:
                goto label_32;
            }
          }
        }
label_32:;
      }
label_33:
      object selectorLock3 = WindowSelector.selectorLock;
      bool flag3 = false;
      try
      {
        WindowSelector.\u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮(selectorLock3, ref flag3);
        this.selectableTypes = (List<ZoomWindowType>) null;
      }
      finally
      {
        if (flag3)
        {
label_36:
          int num1 = 843100993;
          while (true)
          {
            int num2 = 1299183228;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_36;
              case 1:
                WindowSelector.\u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮(selectorLock3);
                num1 = (int) num3 * 1058260459 ^ 922297861;
                continue;
              case 2:
                num1 = (int) num3 * -1819164428 ^ 943273423;
                continue;
              default:
                goto label_40;
            }
          }
        }
label_40:;
      }
      WindowSelector.\u202C⁯⁭‏‎‌‪⁯‭‌‫​⁯‭⁫⁪‮‬‍⁯⁭⁫‭⁯‏‭‌⁭⁭‮‪‌‏‍⁯‮​‏‎⁫‮((Window) this);
      goto label_42;
label_16:
      num5 = 1;
label_17:
      if (num5 != 0)
      {
        num4 = 809910139;
        goto label_14;
      }
      else
        goto label_44;
label_42:
      int num6 = 1158592735;
label_43:
      bool flag4;
      while (true)
      {
        int num1 = 1299183228;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 8U)
        {
          case 0:
            num6 = (int) num2 * 29618783 ^ 1575694429;
            continue;
          case 2:
            goto label_42;
          case 3:
            num6 = (int) num2 * -1749275342 ^ -953017932;
            continue;
          case 4:
            goto label_44;
          case 5:
            num6 = (int) num2 * 333825271 ^ -1127586858;
            continue;
          case 6:
            flag4 = true;
            num6 = (int) num2 * 1527966102 ^ -109716939;
            continue;
          case 7:
            flag4 = false;
            num6 = (int) num2 * -426280573 ^ -461123775;
            continue;
          default:
            goto label_50;
        }
      }
label_50:
      return flag4;
label_44:
      num6 = 284080691;
      goto label_43;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = -223293222;
      while (true)
      {
        int num2 = -1485268214;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * 620561581 ^ -1628211662;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.Engine = Engine.Instance;
            num1 = (int) num3 * 1245338051 ^ -2146393117;
            continue;
          case 4:
            WindowSelector.\u202D⁭‬‪‍​‭‬⁯⁫‭⁮‪‍​⁫⁪⁮‎‫‭⁪⁫⁯‮‪⁭⁯‮‎‫‬‬​‪‫‎⁭‪‏‮(this.Timer);
            num1 = (int) num3 * 1202222900 ^ 1267287300;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private void CaptureWindow_Closing(object sender, CancelEventArgs e)
    {
      WindowSelector.\u202A‮⁫‮‮‭‮⁪‭‎‬⁮⁯⁬⁪‪⁭‮⁯⁫​⁫‮‪⁭⁪‎⁭⁪‬​⁫‮‭‫‬⁯‮‪⁫‮((UIElement) this.SelectorRectangle, Visibility.Collapsed);
label_1:
      int num1 = 732610834;
      while (true)
      {
        int num2 = 194813091;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1956062180 ^ 1319180091;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void CaptureWindow_KeyUp(object sender, KeyEventArgs e)
    {
      bool flag = WindowSelector.\u206C‫‎‌‍‌⁫‎‪‌​‭⁯⁪‮‌⁮⁮⁮⁫‬‬⁪‌‍‭‭​‮‪⁪‎‪⁬⁭‪⁪⁭‮‍‮(e) == Key.Escape;
label_1:
      int num1 = 615381839;
      while (true)
      {
        int num2 = 1824782899;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 753400962 ^ 1737523531;
            continue;
          case 2:
            int num4 = flag ? 428244075 : (num4 = 1149484655);
            int num5 = (int) num3 * 857604175;
            num1 = num4 ^ num5;
            continue;
          case 3:
            this.SelectedHWnd = IntPtr.Zero;
            this.OnCanceled();
            num1 = (int) num3 * -1777140273 ^ -854885209;
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

    private void CaptureWindow_MouseMove(object sender, MouseEventArgs e)
    {
label_1:
      int num1 = 493272426;
      while (true)
      {
        int num2 = 580674615;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            WindowSelector.\u206B​⁬⁪⁫‍​⁯‏⁭‍⁪⁭⁬⁭‫‌‮​‭⁬‪‬‫‏‍‪‪⁯​​​⁬⁭‌‍⁪⁪⁯‪‮(new WaitCallback(this.HandleMouseMove), (object) e);
            num1 = (int) num3 * -511911171 ^ -542521948;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void CaptureWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      this._mouseDown = WindowSelector.\u200E‏‌‮⁭‫‪⁫⁫‫⁮​‮⁭‌⁭‪⁫‭‌‪⁯⁪⁬‮‌‮‬‎‭⁪‏‌‌⁪⁪⁬‬‎‪‮((MouseEventArgs) e, (IInputElement) this);
    }

    private void CaptureWindow_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
label_1:
      int num1 = -1591813061;
      while (true)
      {
        int num2 = -1486649458;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            WindowSelector.\u206B​⁬⁪⁫‍​⁯‏⁭‍⁪⁭⁬⁭‫‌‮​‭⁬‪‬‫‏‍‪‪⁯​​​⁬⁭‌‍⁪⁪⁯‪‮(new WaitCallback(this.HandleLeftButtonUp), (object) e);
            num1 = (int) num3 * -1950054119 ^ -355810565;
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

    private void HandleMouseMove(object param)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowSelector.\u003C\u003Ec__DisplayClass64_0 cDisplayClass640 = new WindowSelector.\u003C\u003Ec__DisplayClass64_0();
label_1:
      int num1 = -1375803850;
      while (true)
      {
        int num2 = -459541099;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            // ISSUE: method pointer
            WindowSelector.\u202A⁬⁪​⁫‍⁭‬‎‍⁬‏‭⁮‎⁪​‮⁮‫⁪‫‎‏⁯‌‭⁮⁮‬‍‏​⁭‍‎‌⁭⁮‮‮(WindowSelector.\u202A‪⁬‎‪‪‏⁫⁮‫⁬‫⁭‪⁮⁮‬⁮​⁫‪‏⁪‭‮⁭‎‫‎⁮⁬‬‏‮‪‍‌‎‌‮((DispatcherObject) this), new Action((object) cDisplayClass640, __methodptr(\u003CHandleMouseMove\u003Eb__0)));
            num1 = (int) num3 * -1835496136 ^ -179701056;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass640.\u003C\u003E4__this = this;
            // ISSUE: reference to a compiler-generated field
            cDisplayClass640.param = param;
            num1 = (int) num3 * 189516082 ^ -1444217907;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void HandleLeftButtonUp(object parameter)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowSelector.\u003C\u003Ec__DisplayClass65_0 cDisplayClass650 = new WindowSelector.\u003C\u003Ec__DisplayClass65_0();
label_1:
      int num1 = -831864344;
      while (true)
      {
        int num2 = -286562284;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: method pointer
            WindowSelector.\u202A⁬⁪​⁫‍⁭‬‎‍⁬‏‭⁮‎⁪​‮⁮‫⁪‫‎‏⁯‌‭⁮⁮‬‍‏​⁭‍‎‌⁭⁮‮‮(WindowSelector.\u202A‪⁬‎‪‪‏⁫⁮‫⁬‫⁭‪⁮⁮‬⁮​⁫‪‏⁪‭‮⁭‎‫‎⁮⁬‬‏‮‪‍‌‎‌‮((DispatcherObject) this), new Action((object) cDisplayClass650, __methodptr(\u003CHandleLeftButtonUp\u003Eb__0)));
            num1 = (int) num3 * -383708983 ^ 1270590136;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass650.\u003C\u003E4__this = this;
            // ISSUE: reference to a compiler-generated field
            cDisplayClass650.parameter = parameter;
            num1 = (int) num3 * 269857844 ^ -1858225404;
            continue;
          case 3:
            num1 = (int) num3 * 1103207173 ^ -722661266;
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

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = -375724748;
      while (true)
      {
        int num2 = -1595756496;
        uint num3;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 1132776696 ^ -1396016576;
            continue;
          case 1:
            WindowSelector.\u200B‪‎‫​‌⁬⁮‏⁫⁭​‭‏‍⁮‫‌‬‌‬⁬⁪⁮‮‭‫⁮‍‭‭‬​‍‭‍‏⁯⁪‪‮((object) this, uri);
            num1 = (int) num3 * -602569359 ^ -1703682885;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * 493487869 ^ 1953790773;
            continue;
          case 5:
            uri = WindowSelector.\u206E‏⁯⁬‭‮‍‎⁭‫⁫⁪‏⁭‮⁮⁫‫‮‪‍⁯⁮‌‌⁪‭⁭‮⁬‍‪‪‌‬​​‌⁯‮‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(792009337U), UriKind.Relative);
            num1 = (int) num3 * 122786050 ^ 660636467;
            continue;
          case 6:
            int num4 = !contentLoaded ? -131763618 : (num4 = -1472506934);
            int num5 = (int) num3 * 1750918792;
            num1 = num4 ^ num5;
            continue;
          case 7:
            this._contentLoaded = true;
            num1 = -125024325;
            continue;
          case 8:
            num1 = (int) num3 * -103990451 ^ 1013351595;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = 1861035804;
      while (true)
      {
        int num2 = 359128977;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            this._contentLoaded = true;
            num1 = 952493814;
            continue;
          case 1:
            num1 = (int) num3 * -1822014441 ^ 108267318;
            continue;
          case 2:
            int num5;
            num1 = num5 = num4 != 2 ? 1166255080 : (num5 = 171418032);
            continue;
          case 3:
            WindowSelector.\u202B‏‌⁫⁯⁭⁯‬‍‬​‍‮⁭‍‏‮⁮‪‬⁫‍‭⁪‌‬⁫‫⁮‎‎⁮‬​⁭‬⁮‫‭⁪‮((FrameworkElement) target, new RoutedEventHandler(this.Window_Loaded));
            num1 = 1646182061;
            continue;
          case 4:
            num1 = (int) num3 * -347191370 ^ 1984897630;
            continue;
          case 5:
            num4 = connectionId;
            num1 = (int) num3 * 1088317106 ^ 1179956185;
            continue;
          case 6:
            int num6 = num4 == 1 ? 1376849438 : (num6 = 1571135678);
            int num7 = (int) num3 * -819225020;
            num1 = num6 ^ num7;
            continue;
          case 7:
            goto label_3;
          case 8:
            num1 = (int) num3 * 1224227066 ^ 1599869574;
            continue;
          case 9:
            this.SelectorRectangle = (Rectangle) target;
            num1 = 947818249;
            continue;
          case 10:
            goto label_1;
          case 11:
            num1 = (int) num3 * 1837364797 ^ 208150780;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    static void \u206B‫‮‪‌‮⁮​⁭‎‪⁭‫⁯‭​‌‫⁫​⁭‮‮‮‬‬‭‬⁬​⁪‌​‏‫‌‪⁬‮‌‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202E⁮⁫⁬⁬‮‮‏⁪‍⁪⁬‌⁪‫‪‌‏⁪‌⁯‪⁯‏​‍​⁫‌⁮⁯‪⁯⁯‎‍‭‌‏‏‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static Delegate \u202D⁭‍‫‬‏‌‬⁫‮⁮⁭⁯‭‮‌‭‏‏‫‍⁫⁮⁯‫⁫⁬‎‎‏‏‎⁪‫‬⁮⁪‍‪‬‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u200B‭‮‍‍‮‍​‫‍‎⁪‮⁯‬‭‭‫‍‪‏⁮‎⁫‪⁮‍⁯⁭‎⁫⁭⁬‬‫‭⁪​‍‫‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static double \u202C⁫‪‍⁭‫⁭‮‪‭‪‬‏‫⁯‫⁯⁯⁫‬‮‏⁮​⁮⁮⁬⁫⁬‍‪‪⁬‎‌⁯⁭⁫​‏‮()
    {
      return SystemParameters.VirtualScreenLeft;
    }

    static void \u206F​‌‮‍‪‭‪‮⁭⁮‍⁬⁭‏‫‏‭‏‫‮‭⁮‍‫‪⁬‮‌‏⁫‪​​⁬‪⁯‎‍‮‮([In] Window obj0, [In] double obj1)
    {
      obj0.Left = obj1;
    }

    static double \u206B⁫‬‏‫​⁯⁮⁬‍‍⁮‌⁯‬‌⁮⁯⁮⁯‍⁫‬‌⁬​‏⁫⁫‏‪⁪‪⁫​⁪‮‌‎‬‮()
    {
      return SystemParameters.VirtualScreenTop;
    }

    static void \u206B⁪‪⁯‭⁬‮‏‎‎‮⁬⁫‮‫‌‎‬‭‎‎‪‫‮⁮‮⁪‭‌‪⁮⁮⁮‍⁫‪‍⁬⁫⁮‮([In] Window obj0, [In] double obj1)
    {
      obj0.Top = obj1;
    }

    static double \u206E⁭⁯‍⁪‏‌‪‭‏⁬⁪​‎‪⁭‌‪‏‍⁭⁫‪‮‭‏⁬‭‌‮‬‭‬‫‮‮‭‏⁭⁪‮()
    {
      return SystemParameters.VirtualScreenWidth;
    }

    void \u202C‎⁯⁪‬⁭​⁪​⁯‍​‭​⁫‍⁮‮⁯⁪‬⁫‮‍‬‬‫⁭⁭‎‮⁯⁪‬⁭‭‪‏‬‮([In] double obj0)
    {
      this.Width = obj0;
    }

    static double \u202C​⁬⁫⁪‬‏⁪⁯‎‫‌⁭⁪​‍⁯‪⁯⁭⁫‮‮‮‏‮⁮⁫‬‌‬‪⁮⁪‭‮‭⁭‏‪‮()
    {
      return SystemParameters.VirtualScreenHeight;
    }

    void \u206E‫‮‏‮⁬‏‪‮⁮⁬⁯⁯⁭‮‪⁯‍‫‌⁬‮‮‮‎‍‍‏⁪⁫‭‬‭‬‪⁬⁪‪‌‮‮([In] double obj0)
    {
      this.Height = obj0;
    }

    static void \u202B⁭‎⁭⁯⁪‫⁪‫​⁪‮⁪‫‮‎‌‭⁮⁬⁬⁯⁬⁫⁪​⁭‪‍‎⁬‌‏‏‮‬‭‭⁫⁬‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    void \u200B‌‮‍⁯‫⁯‏⁫‬⁭‭‫‏‪‪‫⁯⁪‌⁭⁮​‌‮‮‮‪‪⁭⁬⁭‭‎⁯‏⁮⁫⁫⁪‮([In] MouseButtonEventHandler obj0)
    {
      this.MouseLeftButtonUp += obj0;
    }

    void \u206D‫⁪⁫‫‬‍⁫‎‪‭⁪⁪‫‪‎‭‍‫‭‬⁯‮‎‬‍‌‭‍‬⁯⁭‏‎‎​‏​​‏‮([In] MouseButtonEventHandler obj0)
    {
      this.MouseLeftButtonDown += obj0;
    }

    void \u202C‌⁯‎‎‌​⁭‏⁬⁬⁮‌‎‎‎‌‌⁭‮‏⁮‮‏⁬‭‪⁮‪‬‏‪‭‍‬⁪‬‫‫‭‮([In] MouseEventHandler obj0)
    {
      this.MouseMove += obj0;
    }

    void \u200F⁬‬‬‌⁫‌‪‎​⁯⁬⁫‫⁭‎⁪⁯⁯⁭​​‎‭⁯‬⁫⁫​‭‮⁪⁬‫‮‍‮⁪‏‪‮([In] KeyEventHandler obj0)
    {
      this.KeyUp += obj0;
    }

    static void \u200C‎‎‮‬⁪‭⁭⁭⁪⁭‏‮‮‏‭‎⁫‮‌​‍⁪⁫‎‭⁬‮‎‎‌⁮​⁫‪⁫‮⁬‫‭‮([In] Window obj0, [In] CancelEventHandler obj1)
    {
      obj0.Closing += obj1;
    }

    static void \u206F​⁭⁬‌⁬‪‎⁬‫⁫⁮‫‫⁯⁮‌⁯⁯⁪‮‭‌⁬⁫⁪‏‌​⁭‍⁯‎⁮‪‌‫‬‫‍‮([In] UIElement obj0, [In] DependencyPropertyChangedEventHandler obj1)
    {
      obj0.IsVisibleChanged += obj1;
    }

    static SolidColorBrush \u202E‬⁭‌​⁮‎⁬‏‍‌‭‬‭‎​‭‬‎‍⁯⁭​‪‎⁭‎⁮⁪‮​⁮‫⁫‍‍⁫‍‮⁭‮([In] Color obj0)
    {
      return new SolidColorBrush(obj0);
    }

    static void \u206E⁯⁮‭‌​‮‪‫‪​‬‪⁫‌⁭⁭‪‫⁫⁫​⁫‬‮⁫‎‮⁫‬‪​‭‪‭⁮‪‭⁬‎‮([In] Control obj0, [In] Brush obj1)
    {
      obj0.Background = obj1;
    }

    static Dispatcher \u202A‪⁬‎‪‪‏⁫⁮‫⁬‫⁭‪⁮⁮‬⁮​⁫‪‏⁪‭‮⁭‎‫‎⁮⁬‬‏‮‪‍‌‎‌‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static DispatcherTimer \u200F‮‎‬‌‮⁫‎‮‪⁬⁬​⁭‌⁬⁬​⁭⁯⁬‭‎‭‫‏‫‌‎⁯‭⁯⁬⁫‬⁪⁪‮‬‎‮([In] DispatcherPriority obj0, [In] Dispatcher obj1)
    {
      return new DispatcherTimer(obj0, obj1);
    }

    static void \u200B‫‌‮‫‫⁪‌⁭‌⁫‪‌‭⁬⁪⁬‌⁬⁯⁬‎⁫‮‭‌‎​⁭‫‮‬‫‭⁫⁮⁯‎‍⁫‮([In] DispatcherTimer obj0, [In] TimeSpan obj1)
    {
      obj0.Interval = obj1;
    }

    static void \u206D‪‭​‭‏‏‬⁪‬‎‪‏‬‏⁭⁮⁭​‭⁯‮⁭⁪​​⁫⁭⁯⁭⁬⁬​‮⁮‍⁯⁪‬⁮‮([In] DispatcherTimer obj0, [In] EventHandler obj1)
    {
      obj0.Tick += obj1;
    }

    static Dispatcher \u206E‬‎‫‪⁭⁫⁭⁯⁯⁮‍‏⁮​‭‎⁮‎⁭⁬​‎⁬​⁬⁮​‬⁬‭‮⁫‬‌⁪‬⁬‪‌‮([In] DispatcherTimer obj0)
    {
      return obj0.Dispatcher;
    }

    static void \u202A⁬⁪​⁫‍⁭‬‎‍⁬‏‭⁮‎⁪​‮⁮‫⁪‫‎‏⁯‌‭⁮⁮‬‍‏​⁭‍‎‌⁭⁮‮‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static void \u206F‏‍⁫‌⁫‮‏⁮⁪​‏‫​‍‌​⁯‍⁮‫‎‬‎‬⁪⁯⁮‫⁬⁮‮⁮‎⁫‮⁬⁮‬⁭‮([In] Window obj0)
    {
      obj0.Show();
    }

    static void \u202C⁯⁭‏‎‌‪⁯‭‌‫​⁯‭⁫⁪‮‬‍⁯⁭⁫‭⁯‏‭‌⁭⁭‮‪‌‏‍⁯‮​‏‎⁫‮([In] Window obj0)
    {
      obj0.Hide();
    }

    static void \u202D⁭‬‪‍​‭‬⁯⁫‭⁮‪‍​⁫⁪⁮‎‫‭⁪⁫⁯‮‪⁭⁯‮‎‫‬‬​‪‫‎⁭‪‏‮([In] DispatcherTimer obj0)
    {
      obj0.Start();
    }

    static void \u202A‮⁫‮‮‭‮⁪‭‎‬⁮⁯⁬⁪‪⁭‮⁯⁫​⁫‮‪⁭⁪‎⁭⁪‬​⁫‮‭‫‬⁯‮‪⁫‮([In] UIElement obj0, [In] Visibility obj1)
    {
      obj0.Visibility = obj1;
    }

    static Key \u206C‫‎‌‍‌⁫‎‪‌​‭⁯⁪‮‌⁮⁮⁮⁫‬‬⁪‌‍‭‭​‮‪⁪‎‪⁬⁭‪⁪⁭‮‍‮([In] KeyEventArgs obj0)
    {
      return obj0.Key;
    }

    static bool \u206B​⁬⁪⁫‍​⁯‏⁭‍⁪⁭⁬⁭‫‌‮​‭⁬‪‬‫‏‍‪‪⁯​​​⁬⁭‌‍⁪⁪⁯‪‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static System.Windows.Point \u200E‏‌‮⁭‫‪⁫⁫‫⁮​‮⁭‌⁭‪⁫‭‌‪⁯⁪⁬‮‌‮‬‎‭⁪‏‌‌⁪⁪⁬‬‎‪‮([In] MouseEventArgs obj0, [In] IInputElement obj1)
    {
      return obj0.GetPosition(obj1);
    }

    static Uri \u206E‏⁯⁬‭‮‍‎⁭‫⁫⁪‏⁭‮⁮⁫‫‮‪‍⁯⁮‌‌⁪‭⁭‮⁬‍‪‪‌‬​​‌⁯‮‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200B‪‎‫​‌⁬⁮‏⁫⁭​‭‏‍⁮‫‌‬‌‬⁬⁪⁮‮‭‫⁮‍‭‭‬​‍‭‍‏⁯⁪‪‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u202B‏‌⁫⁯⁭⁯‬‍‬​‍‮⁭‍‏‮⁮‪‬⁫‍‭⁪‌‬⁫‫⁮‎‎⁮‬​⁭‬⁮‫‭⁪‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static object \u200B⁪⁯‬‭​‪⁫‭‫‭‪⁪‬‪​⁭⁯‬⁪‬⁫‪⁮‮⁭‏⁪‎⁮‫‍​⁫⁪⁪⁫⁬‪‮‮()
    {
      return new object();
    }

    static void \u206B⁮⁫⁪⁮⁭‌‍⁬‬‌​​‭​⁯‭⁭⁯‫⁬‍‎‌⁯‍⁫‭⁮⁫​​‮‏⁬‬‫‪‬‍‮([In] Window obj0)
    {
      obj0.Close();
    }

    private delegate void LockCallback(object requestingLocker);
  }
}
