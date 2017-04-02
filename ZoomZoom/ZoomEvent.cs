// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomEvent
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZoomZoom
{
  public class ZoomEvent : CoreObject
  {
    private List<Keys> keysDown;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -512942127;
        TraceType traceType;
        while (true)
        {
          int num2 = -801095899;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Application;
              num1 = (int) num3 * -1591533755 ^ 817052936;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public string WindowClass { get; set; }

    public string WindowTitle { get; set; }

    public DateTime EventDate { get; set; }

    public IntPtr WindowHandle { get; set; }

    public IntPtr HookHandle { get; set; }

    public int ProcessId { get; set; }

    public int ThreadId { get; set; }

    public ZoomWindow Window { get; set; }

    public ZoomWindowType ZoomWindowType
    {
      get
      {
label_1:
        int num1 = -1818526116;
        ZoomWindowType zoomWindowType;
        while (true)
        {
          int num2 = -91830489;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              zoomWindowType = ZoomWindowType.Undefined;
              num1 = -74464496;
              continue;
            case 2:
              num1 = (int) num3 * 1758137577 ^ 301820907;
              continue;
            case 3:
              int num4 = !flag ? 2015245294 : (num4 = 255451991);
              int num5 = (int) num3 * -1172072918;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag = this.Window != null;
              num1 = (int) num3 * 1210127105 ^ -1796934047;
              continue;
            case 5:
              zoomWindowType = this.Window.ZoomWindowType;
              num1 = (int) num3 * 853759869 ^ 1833960134;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return zoomWindowType;
      }
    }

    public List<Keys> KeysDown
    {
      get
      {
label_1:
        int num1 = 405069252;
        List<Keys> keysDown;
        while (true)
        {
          int num2 = 1016268929;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              keysDown = this.keysDown;
              num1 = (int) num3 * 2036518872 ^ -1217126950;
              continue;
            case 3:
              num1 = (int) num3 * 1958953038 ^ 1514309909;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return keysDown;
      }
      set
      {
label_1:
        int num1 = 919514112;
        while (true)
        {
          int num2 = 353426724;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.keysDown = value;
              num1 = (int) num3 * -2128343200 ^ -617069015;
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

    public ZoomEventType EventType { get; set; }

    public ZoomEvent(IntPtr hookHandle, IntPtr winHandle, uint eventType, int procId, uint threadId, uint eventTime)
    {
label_1:
      int num1 = -2011297199;
      while (true)
      {
        int num2 = -2023152675;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            this.EventDate = DateTime.Now;
            this.ProcessId = procId;
            this.ThreadId = ZoomEvent.\u202A‭‌⁪‭‬‍‏⁮‪⁭‪‫⁪⁫‬⁬‫⁪⁮⁮‎⁭‌⁫‏​‭​‎‫‮‭⁪‬‬‫‌⁮‮‮(threadId);
            num1 = (int) num3 * -1394848249 ^ -1568595988;
            continue;
          case 1:
            this.WindowClass = WindowHelper.GetWindowClass(this.WindowHandle);
            num1 = (int) num3 * 298766708 ^ 2075167011;
            continue;
          case 2:
            num1 = (int) num3 * 1165383232 ^ -980188280;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -833443332 ^ 26479909;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.WindowTitle = WindowHelper.GetWindowTitle(this.WindowHandle);
            num1 = (int) num3 * -1814587379 ^ -246360676;
            continue;
          case 7:
            num1 = (int) num3 * 727217391 ^ -1325899519;
            continue;
          case 8:
            this.HookHandle = hookHandle;
            num1 = (int) num3 * -750951904 ^ 1150136458;
            continue;
          case 9:
            this.EventType = ZoomEvent.GetZoomEventType(eventType);
            num1 = (int) num3 * -1503722025 ^ 724575248;
            continue;
          case 10:
            this.WindowHandle = winHandle;
            num1 = (int) num3 * -714360931 ^ 1802990222;
            continue;
          case 11:
            num1 = (int) num3 * 366774097 ^ -1584498352;
            continue;
          case 12:
            this.KeysDown = this.Engine.HookManager.GetKeysDown();
            num1 = (int) num3 * -1243127691 ^ -527059927;
            continue;
          case 13:
            num1 = (int) num3 * -626176953 ^ -520200806;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    public ZoomEvent(IntPtr hookHandle, IntPtr winHandle, ZoomEventType eventType, int procId, uint threadId, uint eventTime)
    {
label_1:
      int num1 = 536070786;
      while (true)
      {
        int num2 = 631821908;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            this.WindowTitle = WindowHelper.GetWindowTitle(this.WindowHandle);
            num1 = (int) num3 * -793104490 ^ 338520449;
            continue;
          case 1:
            this.WindowClass = WindowHelper.GetWindowClass(this.WindowHandle);
            num1 = (int) num3 * -1967081795 ^ 445134580;
            continue;
          case 2:
            this.KeysDown = this.Engine.HookManager.GetKeysDown();
            num1 = (int) num3 * -1044013644 ^ -361990709;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -641282941 ^ -1383885390;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * 1175277403 ^ -1805342294;
            continue;
          case 7:
            this.ThreadId = ZoomEvent.\u202A‭‌⁪‭‬‍‏⁮‪⁭‪‫⁪⁫‬⁬‫⁪⁮⁮‎⁭‌⁫‏​‭​‎‫‮‭⁪‬‬‫‌⁮‮‮(threadId);
            num1 = (int) num3 * 1937663369 ^ 509325003;
            continue;
          case 8:
            this.EventType = eventType;
            num1 = (int) num3 * 233657022 ^ -1172135392;
            continue;
          case 9:
            this.ProcessId = procId;
            num1 = (int) num3 * 507961616 ^ -1382505643;
            continue;
          case 10:
            num1 = (int) num3 * -1272443781 ^ -1115294983;
            continue;
          case 11:
            num1 = (int) num3 * 1357230567 ^ 694256689;
            continue;
          case 12:
            this.HookHandle = hookHandle;
            num1 = (int) num3 * -1013193039 ^ -211494474;
            continue;
          case 13:
            this.WindowHandle = winHandle;
            this.EventDate = DateTime.Now;
            num1 = (int) num3 * -1526180728 ^ 1544171213;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    public ZoomEvent(ZoomWindow window)
    {
label_1:
      int num1 = -312311275;
      while (true)
      {
        int num2 = -1445545548;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            this.HookHandle = new IntPtr(0);
            num1 = (int) num3 * -1685218354 ^ 590968739;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.EventDate = DateTime.Now;
            num1 = (int) num3 * -1670542156 ^ 859891814;
            continue;
          case 3:
            this.ThreadId = this.ThreadId;
            num1 = (int) num3 * -1976338354 ^ 558055422;
            continue;
          case 4:
            this.KeysDown = this.Engine.HookManager.GetKeysDown();
            num1 = (int) num3 * -349370014 ^ 1300938673;
            continue;
          case 5:
            this.WindowHandle = window.Handle;
            num1 = (int) num3 * 1688497370 ^ -919138526;
            continue;
          case 6:
            this.WindowClass = WindowHelper.GetWindowClass(this.WindowHandle);
            num1 = (int) num3 * 605995114 ^ -1788065440;
            continue;
          case 7:
            this.Window = window;
            num1 = (int) num3 * 299133261 ^ 1984263912;
            continue;
          case 8:
            this.EventType = ZoomEventType.Show;
            num1 = (int) num3 * -797354212 ^ 1328218645;
            continue;
          case 9:
            num1 = (int) num3 * -1839948209 ^ -2115641465;
            continue;
          case 10:
            goto label_1;
          case 11:
            this.WindowTitle = WindowHelper.GetWindowTitle(this.WindowHandle);
            num1 = (int) num3 * 1966865505 ^ -173136105;
            continue;
          case 12:
            this.ProcessId = this.ProcessId;
            num1 = (int) num3 * -330925377 ^ 1092576991;
            continue;
          case 13:
            num1 = (int) num3 * -521394514 ^ -580592939;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    public static ZoomEventType GetZoomEventType(uint eventId)
    {
      uint num1 = eventId;
label_1:
      int num2 = 1321204392;
      ZoomEventType zoomEventType;
      while (true)
      {
        int num3 = 1112837453;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 31U)
        {
          case 0:
            goto label_1;
          case 1:
            zoomEventType = ZoomEventType.ObjectEnd;
            num2 = 120736613;
            continue;
          case 2:
label_22:
            zoomEventType = ZoomEventType.Destroy;
            num2 = 120736613;
            continue;
          case 3:
label_30:
            zoomEventType = ZoomEventType.NameChange;
            num2 = 49745890;
            continue;
          case 4:
label_5:
            zoomEventType = ZoomEventType.Hide;
            num2 = 120736613;
            continue;
          case 5:
label_27:
            zoomEventType = ZoomEventType.Other;
            num2 = 120736613;
            continue;
          case 6:
            num2 = (int) num4 * -1893735088 ^ -1997821983;
            continue;
          case 7:
            num2 = (int) num4 * -1754216100 ^ 1727439189;
            continue;
          case 8:
label_18:
            zoomEventType = ZoomEventType.Focus;
            num2 = 1762320172;
            continue;
          case 9:
            int num5;
            num2 = num5 = (int) num1 == 33023 ? 9173755 : (num5 = 800436894);
            continue;
          case 10:
label_11:
            zoomEventType = ZoomEventType.Invoked;
            num2 = 120736613;
            continue;
          case 11:
            zoomEventType = ZoomEventType.MoveSize;
            num2 = 120736613;
            continue;
          case 12:
            switch (num1)
            {
              case 32768:
                goto label_29;
              case 32769:
                goto label_22;
              case 32770:
                goto label_31;
              case 32771:
                goto label_5;
              case 32772:
                goto label_6;
              case 32773:
                goto label_18;
              case 32774:
              case 32775:
              case 32776:
              case 32777:
              case 32783:
              case 32784:
              case 32785:
              case 32786:
                goto label_27;
              case 32778:
                goto label_15;
              case 32779:
                goto label_13;
              case 32780:
                goto label_30;
              case 32781:
                goto label_26;
              case 32782:
                goto label_28;
              case 32787:
                goto label_11;
              default:
                num2 = 1311092861;
                continue;
            }
          case 13:
label_15:
            zoomEventType = ZoomEventType.StateChange;
            num2 = 1871514944;
            continue;
          case 14:
            int num6 = (int) num1 != 10 ? -19647210 : (num6 = -1667661632);
            int num7 = (int) num4 * -2052568440;
            num2 = num6 ^ num7;
            continue;
          case 15:
label_28:
            zoomEventType = ZoomEventType.ValueChange;
            num2 = 171405238;
            continue;
          case 16:
label_13:
            zoomEventType = ZoomEventType.LocationChanged;
            num2 = 120736613;
            continue;
          case 17:
            num2 = (int) num4 * -484951172 ^ 2113276569;
            continue;
          case 19:
            num2 = (int) num4 * -1490706649 ^ 1199518453;
            continue;
          case 20:
            num2 = (int) num4 * -2084177971 ^ -1634299639;
            continue;
          case 21:
            num2 = (int) num4 * 1933569984 ^ -856856667;
            continue;
          case 22:
            num2 = (int) num4 * 1623613090 ^ 66332151;
            continue;
          case 23:
            num2 = (int) num4 * -386514913 ^ -409937836;
            continue;
          case 24:
            num2 = (int) num4 * 738290879 ^ -148059008;
            continue;
          case 25:
label_31:
            zoomEventType = ZoomEventType.Show;
            num2 = 1091845821;
            continue;
          case 26:
            num2 = (int) num4 * 1767034682 ^ 1233819304;
            continue;
          case 27:
label_29:
            zoomEventType = ZoomEventType.Create;
            num2 = 277165876;
            continue;
          case 28:
label_6:
            zoomEventType = ZoomEventType.Reorder;
            num2 = 551570769;
            continue;
          case 29:
label_26:
            zoomEventType = ZoomEventType.DescriptionChange;
            num2 = 1804318489;
            continue;
          case 30:
            num2 = (int) num4 * -868227690 ^ -1553674889;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return zoomEventType;
    }

    public static uint GetEventType(ZoomEventType eventType)
    {
      ZoomEventType zoomEventType = eventType;
label_1:
      int num1 = -1334756921;
      uint num2;
      while (true)
      {
        int num3 = -1665074737;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 28U)
        {
          case 0:
label_18:
            num2 = 32770U;
            num1 = -630045103;
            continue;
          case 1:
label_29:
            num2 = 32768U;
            num1 = -684031736;
            continue;
          case 2:
label_12:
            num2 = 32780U;
            num1 = -630045103;
            continue;
          case 3:
label_27:
            num2 = 32787U;
            num1 = -191057268;
            continue;
          case 4:
            num1 = (int) num4 * 942386283 ^ 1123805025;
            continue;
          case 5:
label_25:
            num2 = 32769U;
            num1 = -1419449278;
            continue;
          case 6:
            num2 = 32778U;
            num1 = -235492846;
            continue;
          case 7:
label_5:
            num2 = 32771U;
            num1 = -630045103;
            continue;
          case 8:
label_20:
            num2 = 32787U;
            num1 = -112925287;
            continue;
          case 9:
            num1 = (int) num4 * -1678416834 ^ 460254407;
            continue;
          case 10:
            num1 = (int) num4 * -977942153 ^ -83560533;
            continue;
          case 11:
            num1 = (int) num4 * -539769988 ^ -449627355;
            continue;
          case 12:
            switch (zoomEventType)
            {
              case ZoomEventType.Other:
                goto label_20;
              case ZoomEventType.Create:
                goto label_29;
              case ZoomEventType.Destroy:
                goto label_25;
              case ZoomEventType.LocationChanged:
                goto label_17;
              case ZoomEventType.Show:
                goto label_18;
              case ZoomEventType.Reorder:
                goto label_22;
              case ZoomEventType.Focus:
                goto label_26;
              case ZoomEventType.MoveSize:
                goto label_15;
              case ZoomEventType.Hide:
                goto label_5;
              case ZoomEventType.StateChange:
                goto label_11;
              case ZoomEventType.NameChange:
                goto label_12;
              case ZoomEventType.ValueChange:
                goto label_4;
              case ZoomEventType.DescriptionChange:
                goto label_16;
              case ZoomEventType.ObjectEnd:
                goto label_10;
              case ZoomEventType.Invoked:
                goto label_27;
              default:
                num1 = (int) num4 * 957831439 ^ -1906005717;
                continue;
            }
          case 13:
            num1 = (int) num4 * 169074356 ^ 1609837429;
            continue;
          case 14:
label_10:
            num2 = 33023U;
            num1 = -630045103;
            continue;
          case 15:
            num1 = (int) num4 * 1735551256 ^ 1859172345;
            continue;
          case 16:
label_16:
            num2 = 32781U;
            num1 = -630045103;
            continue;
          case 17:
label_22:
            num2 = 32772U;
            num1 = -84683169;
            continue;
          case 19:
label_26:
            num2 = 32773U;
            num1 = -630045103;
            continue;
          case 20:
            num1 = (int) num4 * 189732303 ^ -934189571;
            continue;
          case 21:
            num1 = (int) num4 * -902918910 ^ -534698261;
            continue;
          case 22:
label_15:
            num2 = 10U;
            num1 = -1245353707;
            continue;
          case 23:
label_4:
            num2 = 32782U;
            num1 = -630045103;
            continue;
          case 24:
label_11:
            num2 = 32778U;
            num1 = -630045103;
            continue;
          case 25:
label_17:
            num2 = 32779U;
            num1 = -1049471334;
            continue;
          case 26:
            num1 = (int) num4 * 1074594894 ^ -1418343363;
            continue;
          case 27:
            goto label_1;
          default:
            goto label_30;
        }
      }
label_30:
      return num2;
    }

    public override string ToString()
    {
label_1:
      int num1 = -1594963014;
      string str;
      while (true)
      {
        int num2 = -1125532251;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 197696432 ^ -717216321;
            continue;
          case 3:
            str = ZoomEvent.\u202E‬‌‬‬‭​‏⁫⁭​⁫⁫‎‏‫​‮‪‭⁪‬‫⁭‬‬⁮‌‭‭⁮‌‎‎‮‌⁭​‪‌‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(138482319U), new object[6]
            {
              (object) this.EventType,
              (object) this.WindowHandle,
              (object) this.ZoomWindowType,
              (object) this.WindowTitle,
              (object) this.WindowClass,
              (object) string.Join<Keys>(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(200411411U), (IEnumerable<M0>) this.KeysDown.ToArray())
            });
            num1 = (int) num3 * -780101915 ^ 902742119;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = 210436308;
      bool flag1;
      while (true)
      {
        int num2 = 1111057834;
        uint num3;
        ZoomEvent zoomEvent;
        bool flag2;
        IntPtr windowHandle;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            if (this.EventType != zoomEvent.EventType)
            {
              num4 = 0;
              break;
            }
            num1 = 1827539267;
            continue;
          case 1:
            zoomEvent = obj as ZoomEvent;
            num1 = (int) num3 * -1977345881 ^ 546172757;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag2 = zoomEvent == null;
            num1 = (int) num3 * 742361118 ^ 1537657082;
            continue;
          case 4:
            num1 = (int) num3 * 482036030 ^ 700340157;
            continue;
          case 5:
            windowHandle = this.WindowHandle;
            num1 = (int) num3 * -2112061565 ^ 2005027206;
            continue;
          case 6:
            int num5 = !flag2 ? -1697105034 : (num5 = -2004170355);
            int num6 = (int) num3 * -376842478;
            num1 = num5 ^ num6;
            continue;
          case 7:
            num1 = (int) num3 * 713918618 ^ -900291089;
            continue;
          case 9:
            num4 = windowHandle.Equals((object) zoomEvent.WindowHandle) ? 1 : 0;
            break;
          case 10:
            flag1 = false;
            num1 = (int) num3 * -371550035 ^ 245635296;
            continue;
          default:
            goto label_15;
        }
        flag1 = num4 != 0;
        num1 = 1330010896;
      }
label_15:
      return flag1;
    }

    public override int GetHashCode()
    {
      return ZoomEvent.\u200C‏‏⁫‬⁬‫‭⁯‪‪⁮‬⁭⁪‬⁬‪⁮‬‎‌⁪⁬‬‎⁪‪‬‬⁪‌‬‭‪‭⁬⁪‭⁫‮((object) ZoomEvent.\u206D‫‪​‏⁫⁯‭⁪​⁫⁭​‫⁬‪‎‬‭‏‏‫⁬‮‌‫⁯​‏⁮​‏⁬​⁯⁪⁫‬‎⁭‮((object) this));
    }

    static int \u202A‭‌⁪‭‬‍‏⁮‪⁭‪‫⁪⁫‬⁬‫⁪⁮⁮‎⁭‌⁫‏​‭​‎‫‮‭⁪‬‬‫‌⁮‮‮([In] uint obj0)
    {
      return Convert.ToInt32(obj0);
    }

    static string \u202E‬‌‬‬‭​‏⁫⁭​⁫⁫‎‏‫​‮‪‭⁪‬‫⁭‬‬⁮‌‭‭⁮‌‎‎‮‌⁭​‪‌‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u206D‫‪​‏⁫⁯‭⁪​⁫⁭​‫⁬‪‎‬‭‏‏‫⁬‮‌‫⁯​‏⁮​‏⁬​⁯⁪⁫‬‎⁭‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static int \u200C‏‏⁫‬⁬‫‭⁯‪‪⁮‬⁭⁪‬⁬‪⁮‬‎‌⁪⁬‬‎⁪‪‬‬⁪‌‬‭‪‭⁬⁪‭⁫‮([In] object obj0)
    {
      return obj0.GetHashCode();
    }
  }
}
