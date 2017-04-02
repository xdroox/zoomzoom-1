// Decompiled with JetBrains decompiler
// Type: ZoomZoom.FindButtons
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ZoomZoom
{
  public class FindButtons : ActivityBase
  {
    private static List<ZoomWindowType> buttonTypesToFind = new List<ZoomWindowType>();
    private static List<ZoomWindowType> buttonTypesRemainingToBeFound = new List<ZoomWindowType>();
    private static List<ZoomButton> buttons = new List<ZoomButton>();
    private static List<ZoomWindowType> validZoomWindowTypes = new List<ZoomWindowType>();
    private int clickStepValue = 50;
    private ZoomMeeting activeMeeting = (ZoomMeeting) null;
    private ZoomWindow meetingWindow = (ZoomWindow) null;
    private ZoomWindow meetingButtons = (ZoomWindow) null;
    private string meetingId = string.Empty;
    private ZoomMeeting meeting = (ZoomMeeting) null;
    private const int maxButtonBarWidth = 550;
    private const int leaveButtonWidth = 130;
    private const int audioVideoButtonWidth = 170;
    private int nextX;
    private int lastY;
    private int leftBoundary;
    private int rightBoundary;

    public List<ZoomWindowType> ButtonTypesToFind
    {
      get
      {
label_1:
        int num1 = 921310596;
        List<ZoomWindowType> buttonTypesToFind;
        while (true)
        {
          int num2 = 624019544;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              buttonTypesToFind = FindButtons.buttonTypesToFind;
              num1 = (int) num3 * 275309176 ^ 2110853475;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return buttonTypesToFind;
      }
      set
      {
label_1:
        int num1 = 421658280;
        while (true)
        {
          int num2 = 453890079;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              FindButtons.buttonTypesToFind = value;
              num1 = (int) num3 * 536838174 ^ 1514850205;
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

    public static List<ZoomButton> Buttons
    {
      get
      {
label_1:
        int num1 = -625357297;
        List<ZoomButton> buttons;
        while (true)
        {
          int num2 = -290769386;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              buttons = FindButtons.buttons;
              num1 = (int) num3 * -2062602535 ^ -432140873;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return buttons;
      }
      set
      {
label_1:
        int num1 = -1106073894;
        while (true)
        {
          int num2 = -1540736249;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              FindButtons.buttons = value;
              num1 = (int) num3 * -1261026286 ^ -1336232633;
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

    public DateTime WaitUtil { get; private set; }

    public ZoomMeeting ActiveMeeting
    {
      get
      {
label_1:
        int num1 = 1231436548;
        ZoomMeeting activeMeeting;
        while (true)
        {
          int num2 = 1331343582;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1096684170 ^ 1267980340;
              continue;
            case 2:
              activeMeeting = this.activeMeeting;
              num1 = (int) num3 * -495169087 ^ 772156149;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return activeMeeting;
      }
      set
      {
label_1:
        int num1 = -545245902;
        while (true)
        {
          int num2 = -372075332;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.activeMeeting = value;
              num1 = (int) num3 * 254957842 ^ -1457719975;
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

    public string MeetingId
    {
      get
      {
label_1:
        int num1 = 292211140;
        string meetingId;
        while (true)
        {
          int num2 = 752433290;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              meetingId = this.meetingId;
              num1 = (int) num3 * -1124908234 ^ 1584176562;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingId;
      }
      set
      {
        this.meetingId = value;
      }
    }

    public ZoomWindow MeetingButtonBar
    {
      get
      {
        return this.meetingButtons;
      }
      set
      {
        this.meetingButtons = value;
      }
    }

    public ZoomMeeting Meeting
    {
      get
      {
        ZoomMeeting activeMeeting = this.Engine.ActiveMeeting;
label_1:
        int num1 = -812997422;
        while (true)
        {
          int num2 = -1004267030;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1458549274 ^ -774075942;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeMeeting;
      }
    }

    public new ZoomWindow MeetingWindow
    {
      get
      {
label_1:
        int num1 = -419287590;
        ZoomWindow activeMeetingWindow;
        while (true)
        {
          int num2 = -582139676;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              activeMeetingWindow = this.Engine.ActiveMeetingWindow;
              num1 = (int) num3 * 724088538 ^ 1941787207;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeMeetingWindow;
      }
    }

    public int NextX
    {
      get
      {
label_1:
        int num1 = 1854749888;
        int nextX;
        while (true)
        {
          int num2 = 1562879537;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              nextX = this.nextX;
              num1 = (int) num3 * -1553870890 ^ 1015054636;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1056096044 ^ -1246341607;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return nextX;
      }
      set
      {
        this.nextX = value;
      }
    }

    public List<ZoomWindowType> ButtonTypesRemainingToBeFound
    {
      get
      {
        List<ZoomWindowType> remainingToBeFound = FindButtons.buttonTypesRemainingToBeFound;
label_1:
        int num1 = 120546187;
        while (true)
        {
          int num2 = 89258882;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1499370997 ^ -674827699;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return remainingToBeFound;
      }
    }

    public string RemainingTypes
    {
      get
      {
label_1:
        int num1 = -2097501816;
        string str;
        while (true)
        {
          int num2 = -735618807;
          uint num3;
          string remainingTypes;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.ButtonTypesRemainingToBeFound.ForEach((Action<ZoomWindowType>) (o => remainingTypes = FindButtons.\u003C\u003Ec__DisplayClass46_0.\u202C⁬​‌⁭‮‬‫‏‎⁫‍‍‬⁪⁯‮‪‪‍‫‭‭​⁫⁭‌‏‏‮⁪⁫⁮⁯⁬⁬⁪‬‭⁯‮(remainingTypes, o.ToString(), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3515778971U))));
              num1 = (int) num3 * 1920518817 ^ -1843078663;
              continue;
            case 1:
              num1 = (int) num3 * 1304596432 ^ 435304686;
              continue;
            case 3:
              remainingTypes = string.Empty;
              num1 = (int) num3 * 1715209164 ^ -757460603;
              continue;
            case 4:
              str = remainingTypes;
              num1 = (int) num3 * 407218715 ^ -247768933;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return str;
      }
    }

    public List<ZoomWindowType> ValidZoomWindowTypes
    {
      get
      {
label_1:
        int num1 = 1566493944;
        List<ZoomWindowType> validZoomWindowTypes;
        while (true)
        {
          int num2 = 515649273;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              validZoomWindowTypes = FindButtons.validZoomWindowTypes;
              num1 = (int) num3 * 189578999 ^ 1590442502;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return validZoomWindowTypes;
      }
      set
      {
        FindButtons.validZoomWindowTypes = value;
label_1:
        int num1 = 1500661554;
        while (true)
        {
          int num2 = 630525259;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4151291421U));
              num1 = (int) num3 * 108424571 ^ -1949548614;
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
        TraceType traceType = TraceType.Activity;
label_1:
        int num1 = -1912355849;
        while (true)
        {
          int num2 = -1059150835;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1901124250 ^ 714529547;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public FindButtons(ZoomWindowType desiredWindowType = ZoomWindowType.Undefined)
    {
      this.ButtonTypesToFind.Clear();
      this.ButtonTypesRemainingToBeFound.Clear();
      FindButtons.Buttons.Clear();
      if ((uint) desiredWindowType > 0U)
      {
        this.AddRequiredZoomWindowType(desiredWindowType);
      }
      else
      {
        this.AddRequiredZoomWindowType(ZoomWindowType.Participants);
        this.AddRequiredZoomWindowType(ZoomWindowType.Chat);
      }
    }

    public override string ToString()
    {
label_1:
      int num1 = -540017185;
      string str;
      while (true)
      {
        int num2 = -1079394096;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -1064339710 ^ -106161023;
            continue;
          case 3:
            str = FindButtons.\u202B‏​⁬⁫‫‎‮‎​‬⁫⁮‭‬‭⁬⁮‮‭⁭‬‪‎‌⁯⁭⁯⁭⁮‫⁫‌‬‌‎‫⁭⁭⁬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2595132687U), new object[0]);
            num1 = (int) num3 * 1646657527 ^ -734220733;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    private void CloseButtonWindows()
    {
label_1:
      int num1 = 240177261;
      while (true)
      {
        int num2 = 385254928;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -9062362 ^ 1889869673;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      List<ZoomWindowType>.Enumerator enumerator = ZoomWindow.ButtonPossibleResultingZoomWindowTypes.GetEnumerator();
      try
      {
label_18:
        int num2 = enumerator.MoveNext() ? 1276664511 : (num2 = 1052763142);
        while (true)
        {
          int num3 = 385254928;
          uint num4;
          ZoomWindow window;
          ZoomWindowType current;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 11U)
          {
            case 0:
              num2 = 231911754;
              continue;
            case 1:
              num5 = window.IsVisible ? 1 : 0;
              break;
            case 2:
              window = this.Engine.GetWindow(current);
              if (window == null)
              {
                num5 = 0;
                break;
              }
              num2 = (int) num4 * -289163544 ^ -2138151642;
              continue;
            case 3:
              window.Close(true, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3984318030U));
              num2 = (int) num4 * -1740818211 ^ -1212766609;
              continue;
            case 4:
              num2 = 1276664511;
              continue;
            case 5:
              num2 = (int) num4 * -1226764009 ^ -611321888;
              continue;
            case 6:
              current = enumerator.Current;
              num2 = 1605404852;
              continue;
            case 7:
              goto label_24;
            case 8:
              num2 = (int) num4 * 1888845027 ^ -1799673062;
              continue;
            case 9:
              num2 = (int) num4 * -273622278 ^ 421959907;
              continue;
            case 10:
              goto label_18;
            default:
              goto label_20;
          }
          int num6;
          num2 = num6 = num5 != 0 ? 190086599 : (num6 = 1727239581);
        }
label_20:
        return;
label_24:;
      }
      finally
      {
        enumerator.Dispose();
label_22:
        int num2 = 995062506;
        while (true)
        {
          int num3 = 385254928;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_22;
            case 1:
              num2 = (int) num4 * 505399057 ^ -310602087;
              continue;
            default:
              goto label_26;
          }
        }
label_26:;
      }
    }

    private void UpdateProperties()
    {
      object activityLocker = ActivityBase.activityLocker;
      bool flag1 = false;
      try
      {
        FindButtons.\u202B‬⁬‌‎‏‮‏⁬‬‪‬‮⁯⁪‬‫‫⁫‫‪⁫⁭‫‮‮‌⁬‎​​‏‪‮⁯‪⁫⁪‏‭‮(activityLocker, ref flag1);
label_2:
        int num1 = 933580332;
        while (true)
        {
          int num2 = 498307420;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              goto label_2;
            case 1:
              this.EndTime = DateTime.Now.AddSeconds(60.0);
              num1 = (int) num3 * 1457650024 ^ 385241299;
              continue;
            case 2:
              flag2 = this.Meeting != null;
              num1 = (int) num3 * -912801509 ^ -1099989661;
              continue;
            case 3:
              num1 = (int) num3 * 1750457751 ^ -1769780273;
              continue;
            case 4:
              this.MeetingId = this.Meeting.MeetingId;
              num1 = (int) num3 * -64509181 ^ -1403787734;
              continue;
            case 5:
              int num4 = !flag2 ? 137484233 : (num4 = 1099667552);
              int num5 = (int) num3 * -1693701313;
              num1 = num4 ^ num5;
              continue;
            case 6:
              this.MeetingButtonBar = this.Engine.GetWindow(ZoomWindowType.MeetingButtonBar);
              num1 = 248637981;
              continue;
            case 7:
              num1 = (int) num3 * 64065910 ^ 1649629255;
              continue;
            case 8:
              num1 = (int) num3 * -1461041622 ^ -1150839023;
              continue;
            case 9:
              num1 = (int) num3 * 1786776335 ^ -1625634922;
              continue;
            case 10:
              goto label_17;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_17:;
      }
      finally
      {
        if (flag1)
        {
label_15:
          int num1 = 1832837705;
          while (true)
          {
            int num2 = 498307420;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                Monitor.Exit(activityLocker);
                num1 = (int) num3 * -806532714 ^ -1662251679;
                continue;
              case 2:
                goto label_15;
              case 3:
                num1 = (int) num3 * 433289709 ^ -384573937;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    private bool WaitForButtonResult()
    {
      this.CheckCancellationToken();
label_1:
      int num1 = 1285857087;
      bool flag1;
      while (true)
      {
        int num2 = 798667950;
        uint num3;
        bool flag2;
        bool flag3;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            FindButtons.\u202E⁯‍​‏​‮‎‮⁮‎⁬⁪‌⁪‏‮⁯‬⁫​⁬‮‮⁬‬⁫⁭‭⁭⁫‬⁮‍​‮‫‌‌⁫‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(176226004U), (object) flag2, (object) flag3);
            num1 = (int) num3 * 2028364389 ^ 1265633237;
            continue;
          case 1:
            num1 = (int) num3 * -367981760 ^ -898243535;
            continue;
          case 2:
            num1 = (int) num3 * -1921018980 ^ -1477887568;
            continue;
          case 3:
            num1 = (int) num3 * -560607574 ^ -1491653305;
            continue;
          case 4:
            num1 = 295647118;
            continue;
          case 5:
            flag1 = true;
            num1 = (int) num3 * 646655845 ^ 1035589760;
            continue;
          case 6:
            flag1 = false;
            num1 = 38454445;
            continue;
          case 8:
            goto label_1;
          case 9:
            int num4 = !flag4 ? -71985484 : (num4 = -1225144483);
            int num5 = (int) num3 * -1966901010;
            num1 = num4 ^ num5;
            continue;
          case 10:
            num1 = (int) num3 * -558571351 ^ 324241462;
            continue;
          case 11:
            num1 = (int) num3 * 372611331 ^ -1942225087;
            continue;
          case 12:
            flag4 = !flag2;
            num1 = 1847386455;
            continue;
          case 13:
            this.SetActivityState(ActivityState.Canceled, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1025690211U));
            num1 = (int) num3 * 527191786 ^ -1845172474;
            continue;
          case 14:
            num1 = (int) num3 * 918123770 ^ 702966916;
            continue;
          case 15:
            flag2 = WindowHelper.IsValid(this.MeetingWindow.Handle);
            flag3 = this.WaitUtil > DateTime.Now;
            int num6 = !(flag3 & flag2) ? -373432077 : (num6 = -1880396518);
            int num7 = (int) num3 * 1336666159;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return flag1;
    }

    internal void AddRequiredZoomWindowType(ZoomWindowType zoomWindowType)
    {
      object activityLocker = ActivityBase.activityLocker;
      bool flag1 = false;
      try
      {
        FindButtons.\u202B‬⁬‌‎‏‮‏⁬‬‪‬‮⁯⁪‬‫‫⁫‫‪⁫⁭‫‮‮‌⁬‎​​‏‪‮⁯‪⁫⁪‏‭‮(activityLocker, ref flag1);
label_2:
        int num1 = 897373789;
        while (true)
        {
          int num2 = 806245967;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1697670286 ^ -1707088829;
              continue;
            case 1:
              int num4 = !flag2 ? 1817179722 : (num4 = 2085669735);
              int num5 = (int) num3 * 111067596;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.ButtonTypesToFind.Add(zoomWindowType);
              num1 = (int) num3 * -1659486709 ^ 378015410;
              continue;
            case 3:
              goto label_12;
            case 4:
              flag2 = !this.ButtonTypesToFind.Contains(zoomWindowType);
              num1 = (int) num3 * -755207499 ^ -283629674;
              continue;
            case 5:
              goto label_2;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_12:;
      }
      finally
      {
        if (flag1)
        {
label_10:
          int num1 = 2081245934;
          while (true)
          {
            int num2 = 806245967;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_10;
              case 1:
                FindButtons.\u200E⁬‭‎⁪‫⁯⁪‪⁭⁬‍‍‭‏⁪‫‬⁭​⁫⁭‪⁫‮‎‬‫‬‌‫‎‭‏​⁭‬⁬‪‮(activityLocker);
                num1 = (int) num3 * 1661687687 ^ -985855686;
                continue;
              case 2:
                num1 = (int) num3 * -1151694657 ^ -736373914;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    private ZoomButton GetExistingButton(System.Drawing.Point clickPoint)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      FindButtons.\u003C\u003Ec__DisplayClass58_0 cDisplayClass580 = new FindButtons.\u003C\u003Ec__DisplayClass58_0();
label_1:
      int num1 = 1428637749;
      ZoomButton zoomButton1;
      while (true)
      {
        int num2 = 1044960175;
        uint num3;
        ZoomButton zoomButton2;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            num1 = (int) num3 * 1555504935 ^ -1000388377;
            continue;
          case 1:
            num1 = (int) num3 * -1917315524 ^ -1509843089;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass580.clickPoint = clickPoint;
            // ISSUE: method pointer
            zoomButton2 = (ZoomButton) Enumerable.FirstOrDefault<ZoomButton>((IEnumerable<M0>) FindButtons.Buttons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) cDisplayClass580, __methodptr(\u003CGetExistingButton\u003Eb__0)));
            num1 = (int) num3 * 247569484 ^ -46828884;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            zoomButton2.ButtonX = cDisplayClass580.clickPoint.X;
            // ISSUE: reference to a compiler-generated field
            zoomButton2.ButtonY = cDisplayClass580.clickPoint.Y;
            num1 = (int) num3 * 1676585532 ^ -1782860177;
            continue;
          case 4:
            zoomButton2 = new ZoomButton();
            zoomButton2.ResultingWindowType = ZoomWindowType.Undefined;
            zoomButton2.MeetingId = this.MeetingId;
            num1 = (int) num3 * 744850302 ^ 1986936994;
            continue;
          case 5:
            goto label_1;
          case 6:
            int num4 = flag ? 1706038922 : (num4 = 696820513);
            int num5 = (int) num3 * 2021890558;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = (int) num3 * -235052055 ^ 645062189;
            continue;
          case 8:
            num1 = (int) num3 * -853663931 ^ 959701064;
            continue;
          case 9:
            zoomButton2.WindowHeight = this.MeetingWindow.Size.Height;
            num1 = (int) num3 * -1564892881 ^ -1190533088;
            continue;
          case 11:
            flag = zoomButton2 == null;
            num1 = (int) num3 * -1597263080 ^ -1068213154;
            continue;
          case 12:
            zoomButton2.ZoomWindowType = this.MeetingWindow.ZoomWindowType;
            num1 = (int) num3 * 1183341641 ^ -366259001;
            continue;
          case 13:
            zoomButton1 = zoomButton2;
            num1 = 584072563;
            continue;
          case 14:
            zoomButton2.WindowWidth = this.MeetingWindow.Size.Width;
            num1 = (int) num3 * -1191879493 ^ -1973833123;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return zoomButton1;
    }

    private System.Drawing.Point IncrementClickPoint()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      ZoomButton zoomButton = (ZoomButton) Enumerable.FirstOrDefault<ZoomButton>((IEnumerable<M0>) FindButtons.Buttons, (Func<M0, bool>) (FindButtons.\u003C\u003Ec.\u003C\u003E9__59_0 ?? (FindButtons.\u003C\u003Ec.\u003C\u003E9__59_0 = new Func<ZoomButton, bool>((object) FindButtons.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CIncrementClickPoint\u003Eb__59_0)))));
label_1:
      int num1 = 627393011;
      object activityLocker;
      while (true)
      {
        int num2 = 1350271800;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * -1731064565 ^ -130110838;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
        FindButtons.\u202B‬⁬‌‎‏‮‏⁬‬‪‬‮⁯⁪‬‫‫⁫‫‪⁫⁭‫‮‮‌⁬‎​​‏‪‮⁯‪⁫⁪‏‭‮(activityLocker, ref flag1);
label_6:
        int num2 = 347195865;
        while (true)
        {
          int num3 = 1350271800;
          uint num4;
          bool flag2;
          int num5;
          switch ((num4 = (uint) (num2 ^ num3)) % 13U)
          {
            case 0:
              num2 = 1965783526;
              continue;
            case 1:
              num2 = (int) num4 * 1392611972 ^ 2120286295;
              continue;
            case 2:
              goto label_6;
            case 3:
              int num6 = flag2 ? -1456230585 : (num6 = -1646698502);
              int num7 = (int) num4 * -1509351796;
              num2 = num6 ^ num7;
              continue;
            case 4:
              this.NextX = zoomButton.ButtonX + this.clickStepValue;
              num2 = (int) num4 * -451378559 ^ 133780130;
              continue;
            case 5:
              if (zoomButton == null)
              {
                num5 = 0;
                break;
              }
              num2 = (int) num4 * 2057165024 ^ 1184529761;
              continue;
            case 7:
              this.NextX = this.NextX + this.clickStepValue;
              num2 = 30194651;
              continue;
            case 8:
              num2 = (int) num4 * -555321704 ^ 200775246;
              continue;
            case 9:
              num2 = (int) num4 * 1043386741 ^ -1007687359;
              continue;
            case 10:
              num2 = (int) num4 * -916777531 ^ 1214230658;
              continue;
            case 11:
              num2 = (int) num4 * 278632333 ^ 2034373690;
              continue;
            case 12:
              num5 = this.NextX < zoomButton.ButtonX ? 1 : 0;
              break;
            default:
              goto label_28;
          }
          flag2 = num5 != 0;
          num2 = 452599101;
        }
      }
      finally
      {
        if (flag1)
        {
label_23:
          int num2 = 1279623298;
          while (true)
          {
            int num3 = 1350271800;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_23;
              case 2:
                FindButtons.\u200E⁬‭‎⁪‫⁯⁪‪⁭⁬‍‍‭‏⁪‫‬⁭​⁫⁭‪⁫‮‎‬‫‬‌‫‎‭‏​⁭‬⁬‪‮(activityLocker);
                num2 = (int) num4 * -99858544 ^ -347528761;
                continue;
              case 3:
                num2 = (int) num4 * -180634033 ^ -1104552736;
                continue;
              default:
                goto label_27;
            }
          }
        }
label_27:;
      }
label_28:
      return new System.Drawing.Point(this.NextX, this.lastY);
    }

    private new bool ContinueExecution()
    {
label_1:
      int num1 = -3173607;
      bool flag1;
      while (true)
      {
        int num2 = -1712406232;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 539624494 ^ -995777405;
            continue;
          case 2:
            flag1 = true;
            num1 = (int) num3 * 1135302057 ^ 395526302;
            continue;
          case 3:
            int num5 = flag2 ? -1780207893 : (num5 = -1958674064);
            int num6 = (int) num3 * 929718419;
            num1 = num5 ^ num6;
            continue;
          case 4:
            flag1 = false;
            num1 = (int) num3 * 1079379884 ^ -1093879453;
            continue;
          case 5:
            if (this.MeetingWindow != null)
            {
              num1 = (int) num3 * -103160962 ^ 298773827;
              continue;
            }
            break;
          case 7:
            num4 = this.EndTime > DateTime.Now ? 1 : 0;
            goto label_22;
          case 8:
            if (this.Meeting != null)
            {
              num1 = (int) num3 * 615612592 ^ -2025562892;
              continue;
            }
            break;
          case 9:
            if (WindowHelper.IsValid(this.Engine.ActiveMeetingWindow.Handle))
            {
              num1 = (int) num3 * -1391588278 ^ -400125844;
              continue;
            }
            break;
          case 10:
            num1 = -2142654168;
            continue;
          case 11:
            if (!this.CancelRequested)
            {
              num1 = (int) num3 * -768687099 ^ -1905555581;
              continue;
            }
            break;
          case 12:
            num1 = (int) num3 * 623760449 ^ 1414491795;
            continue;
          case 13:
            if (this.ButtonTypesRemainingToBeFound.Count > 0)
            {
              num1 = (int) num3 * -155020901 ^ 1665877227;
              continue;
            }
            break;
          case 14:
            if (this.ActivityState == ActivityState.InProgress)
            {
              num1 = (int) num3 * 790493416 ^ 936344282;
              continue;
            }
            break;
          default:
            goto label_24;
        }
        num4 = 0;
label_22:
        flag2 = num4 != 0;
        num1 = -1590325235;
      }
label_24:
      return flag1;
    }

    private void VerifyListRequiredButtons()
    {
label_1:
      int num1 = -2111099343;
      string str;
      while (true)
      {
        int num2 = -1349835180;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            goto label_31;
          case 1:
            if (this.ButtonTypesToFind != null)
            {
              num1 = (int) num3 * -899263823 ^ 2000471762;
              continue;
            }
            num4 = 1;
            break;
          case 2:
            num1 = (int) num3 * -1752263095 ^ 1745883865;
            continue;
          case 4:
            num1 = (int) num3 * -1249575084 ^ -1094706096;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.ButtonTypesToFind.Add(ZoomWindowType.Participants);
            this.ButtonTypesToFind.Add(ZoomWindowType.Chat);
            num1 = (int) num3 * -1497479548 ^ -1259808780;
            continue;
          case 7:
            num1 = -630505184;
            continue;
          case 8:
            str = string.Empty;
            num1 = (int) num3 * 112329349 ^ 39103451;
            continue;
          case 9:
            FindButtons.\u206F‫⁮​⁫‫⁭‮‎‭⁯⁭‬⁫‮⁬⁪⁫⁯‬⁪‎⁯‬​⁪⁮‍‬‪‌⁯‭‌⁯⁪‭⁯‎⁫‮(CoreObject.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763043241U), new object[0]);
            num1 = (int) num3 * -1931050895 ^ 741025565;
            continue;
          case 10:
            num1 = (int) num3 * 705089519 ^ 1089987160;
            continue;
          case 11:
            num4 = this.ButtonTypesToFind.Count == 0 ? 1 : 0;
            break;
          case 12:
            int num5 = !flag ? -135250995 : (num5 = -1600455243);
            int num6 = (int) num3 * -2130124190;
            num1 = num5 ^ num6;
            continue;
          case 13:
            this.ButtonTypesToFind = new List<ZoomWindowType>();
            num1 = (int) num3 * -984896456 ^ -100627226;
            continue;
          default:
            goto label_17;
        }
        flag = num4 != 0;
        num1 = -458123124;
      }
label_17:
      using (List<ZoomWindowType>.Enumerator enumerator = this.ButtonTypesToFind.GetEnumerator())
      {
label_22:
        int num2 = enumerator.MoveNext() ? -1864425807 : (num2 = -689359811);
        while (true)
        {
          int num3 = -1349835180;
          uint num4;
          ZoomWindowType current;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              str = FindButtons.\u202C⁫‪​‭⁪‮‏‍⁬‮‬⁫⁮⁯⁭⁪⁬‌⁭⁯‍⁫‪‭‪‬‎‫‮⁫​‬‍‏​⁫⁬‮(str, current.ToString());
              num2 = (int) num4 * -2080317512 ^ 1611872069;
              continue;
            case 1:
              goto label_22;
            case 2:
              num2 = -1864425807;
              continue;
            case 3:
              num2 = (int) num4 * 872802962 ^ -72433166;
              continue;
            case 5:
              current = enumerator.Current;
              num2 = -1225230087;
              continue;
            case 6:
              num2 = (int) num4 * 1086169504 ^ 1564148831;
              continue;
            default:
              goto label_27;
          }
        }
      }
label_27:
      FindButtons.\u206D⁫⁬‌‏‎‏‬⁮‪‭‌‬‏⁯⁯‎⁬‫‮‫⁮‫‮‪‭‮‏‫⁮‌⁬⁮‌⁭‮‪⁫⁫‫‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2884650591U), (object) str);
label_28:
      int num7 = -1684624707;
      while (true)
      {
        int num2 = -1349835180;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 3U)
        {
          case 1:
            num7 = (int) num3 * -1494725437 ^ -2075565788;
            continue;
          case 2:
            goto label_28;
          default:
            goto label_31;
        }
      }
label_31:
      this.ButtonTypesToFind.ForEach((Action<ZoomWindowType>) (o => this.ButtonTypesRemainingToBeFound.Add(o)));
    }

    private void LoadExistingButtons()
    {
      bool flag1 = this.MeetingWindow != null;
label_1:
      int num1 = 1043423765;
      List<ZoomButton> list1;
      while (true)
      {
        int num2 = 919488365;
        uint num3;
        List<ZoomButton> buttons;
        List<ZoomButton> list2;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = (int) num3 * -1973490489 ^ 899495018;
            continue;
          case 1:
            num1 = (int) num3 * 1987758680 ^ 370662803;
            continue;
          case 2:
            if (flag1)
            {
              num1 = (int) num3 * -1174126990 ^ -170805632;
              continue;
            }
            goto label_76;
          case 3:
            num1 = (int) num3 * 93416825 ^ -1683161323;
            continue;
          case 4:
            this.MeetingWindow.RefreshLocation();
            num1 = (int) num3 * -551304654 ^ 530307625;
            continue;
          case 5:
            buttons = this.Engine.GetButtons(this.MeetingId);
            FindButtons.\u206D⁫⁬‌‏‎‏‬⁮‪‭‌‬‏⁯⁯‎⁬‫‮‫⁮‫‮‪‭‮‏‫⁮‌⁬⁮‌⁭‮‪⁫⁫‫‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3029409543U), (object) buttons.Count);
            num1 = (int) num3 * 289901377 ^ 658191958;
            continue;
          case 6:
            // ISSUE: method pointer
            list2 = ((IEnumerable<ZoomButton>) Enumerable.Where<ZoomButton>((IEnumerable<M0>) buttons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) this, __methodptr(\u003CLoadExistingButtons\u003Eb__62_0)))).ToList<ZoomButton>();
            FindButtons.\u206D⁫⁬‌‏‎‏‬⁮‪‭‌‬‏⁯⁯‎⁬‫‮‫⁮‫‮‪‭‮‏‫⁮‌⁬⁮‌⁭‮‪⁫⁫‫‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1306443425U), (object) list2.Count);
            num1 = (int) num3 * -490841845 ^ 189128102;
            continue;
          case 7:
            num1 = (int) num3 * 1673346073 ^ 257693573;
            continue;
          case 9:
            // ISSUE: method pointer
            list1 = ((IEnumerable<ZoomButton>) Enumerable.Where<ZoomButton>((IEnumerable<M0>) list2, (Func<M0, bool>) new Func<ZoomButton, bool>((object) this, __methodptr(\u003CLoadExistingButtons\u003Eb__62_1)))).ToList<ZoomButton>();
            num1 = (int) num3 * -839957688 ^ 1785062466;
            continue;
          case 10:
            num1 = (int) num3 * 1088342144 ^ -839819681;
            continue;
          case 11:
            num1 = (int) num3 * 124609172 ^ 695163367;
            continue;
          case 12:
            goto label_1;
          case 13:
            FindButtons.\u206D⁫⁬‌‏‎‏‬⁮‪‭‌‬‏⁯⁯‎⁬‫‮‫⁮‫‮‪‭‮‏‫⁮‌⁬⁮‌⁭‮‪⁫⁫‫‮(CoreObject.log, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3394409148U), (object) list1.Count);
            num1 = (int) num3 * -710860675 ^ -1384204641;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      List<ZoomButton>.Enumerator enumerator = list1.GetEnumerator();
      try
      {
label_53:
        int num2 = enumerator.MoveNext() ? 618743230 : (num2 = 701750539);
        while (true)
        {
          int num3 = 919488365;
          uint num4;
          // ISSUE: variable of a compiler-generated type
          FindButtons.\u003C\u003Ec__DisplayClass62_0 cDisplayClass620;
          bool flag2;
          bool flag3;
          bool flag4;
          int num5;
          int num6;
          switch ((num4 = (uint) (num2 ^ num3)) % 39U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass620.button = enumerator.Current;
              num2 = (int) num4 * -1073091819 ^ -1595008768;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass620.button.Delete();
              num2 = (int) num4 * 1400826410 ^ -1786268631;
              continue;
            case 2:
              int num7 = flag4 ? -1806399732 : (num7 = -848506321);
              int num8 = (int) num4 * -1549949771;
              num2 = num7 ^ num8;
              continue;
            case 3:
              num2 = 1468416163;
              continue;
            case 4:
              num2 = 1629702506;
              continue;
            case 5:
              num2 = (int) num4 * 468969962 ^ -400663889;
              continue;
            case 6:
              num2 = (int) num4 * -1327175180 ^ -2015071372;
              continue;
            case 8:
              num2 = (int) num4 * -1830329600 ^ 972443420;
              continue;
            case 9:
              num2 = (int) num4 * 1118474845 ^ 1955674820;
              continue;
            case 10:
              num2 = 606421459;
              continue;
            case 11:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass620 = new FindButtons.\u003C\u003Ec__DisplayClass62_0();
              num2 = 1204628471;
              continue;
            case 12:
              // ISSUE: reference to a compiler-generated field
              num5 = ZoomWindow.ButtonPossibleResultingZoomWindowTypes.Contains(cDisplayClass620.button.ResultingWindowType) ? 1 : 0;
              break;
            case 13:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass620.button.ClickState == ClickState.Verified)
              {
                num2 = (int) num4 * -1598987586 ^ 948624071;
                continue;
              }
              num5 = 0;
              break;
            case 14:
              flag3 = this.MeetingWindow != null;
              num2 = (int) num4 * -630387069 ^ 1611493862;
              continue;
            case 15:
              // ISSUE: reference to a compiler-generated field
              this.ValidateButton(cDisplayClass620.button);
              num2 = (int) num4 * 2126872913 ^ -1693417250;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              num6 = cDisplayClass620.button.ButtonX > this.leftBoundary ? 1 : 0;
              goto label_64;
            case 17:
              num2 = (int) num4 * 1990367625 ^ 1164528617;
              continue;
            case 18:
              // ISSUE: reference to a compiler-generated field
              if (this.ButtonTypesRemainingToBeFound.Contains(cDisplayClass620.button.ResultingWindowType))
              {
                num5 = 1;
                break;
              }
              num2 = (int) num4 * 1587320739 ^ 1700727837;
              continue;
            case 19:
              // ISSUE: method pointer
              flag4 = !Enumerable.Any<ZoomButton>((IEnumerable<M0>) FindButtons.Buttons, (Func<M0, bool>) new Func<ZoomButton, bool>((object) cDisplayClass620, __methodptr(\u003CLoadExistingButtons\u003Eb__2)));
              num2 = (int) num4 * 140000584 ^ -1094171057;
              continue;
            case 20:
              num2 = 1040425705;
              continue;
            case 21:
              // ISSUE: reference to a compiler-generated field
              FindButtons.\u200B⁮‏‬​⁬‍⁮⁬⁬‪⁫⁫⁫⁭‏‫⁯⁭‏⁯‌⁪‪⁫‪‪‫⁬‫‍⁫⁭⁪⁯⁬​⁮‭‫‮(CoreObject.log, (object) FindButtons.\u202E‫‏⁫⁪‍‎⁪‭⁭⁭⁫⁫‍‏‏​‍‫⁪‌‭⁫‌​⁮⁮‮⁫‭‮⁬‫‭⁮‬‫⁫‭⁮‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(428859794U), (object) cDisplayClass620.button));
              num2 = (int) num4 * 1758025175 ^ 1047570619;
              continue;
            case 22:
              // ISSUE: reference to a compiler-generated field
              this.MeetingWindow.ClickButtonAwaitResult(cDisplayClass620.button, this.Token, true);
              num2 = (int) num4 * -306372342 ^ 1395106773;
              continue;
            case 23:
              num2 = (int) num4 * 1263684801 ^ 560838301;
              continue;
            case 24:
              num2 = (int) num4 * -1323310382 ^ -613747267;
              continue;
            case 25:
              num2 = (int) num4 * -2018404268 ^ -1849403065;
              continue;
            case 26:
              num2 = 864461952;
              continue;
            case 27:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass620.button.ButtonX < this.rightBoundary)
              {
                num2 = (int) num4 * 434249315 ^ -617806058;
                continue;
              }
              num6 = 0;
              goto label_64;
            case 28:
              int num9 = !flag2 ? 1626588064 : (num9 = 788058723);
              int num10 = (int) num4 * -1833534777;
              num2 = num9 ^ num10;
              continue;
            case 29:
              num2 = 618743230;
              continue;
            case 30:
              num2 = (int) num4 * 1707822756 ^ 1681796148;
              continue;
            case 31:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass620.button.DeleteDatabaseObject();
              num2 = (int) num4 * 1919216738 ^ -515129884;
              continue;
            case 32:
              num2 = 1661917143;
              continue;
            case 33:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass620.button.ClickState = ClickState.Unknown;
              num2 = (int) num4 * -179853233 ^ -1322590340;
              continue;
            case 34:
              num2 = (int) num4 * 1128342262 ^ -1887480380;
              continue;
            case 35:
              int num11 = !flag3 ? -2069137725 : (num11 = -754614489);
              int num12 = (int) num4 * -139976636;
              num2 = num11 ^ num12;
              continue;
            case 36:
              num2 = 1235127926;
              continue;
            case 37:
              goto label_53;
            case 38:
              num2 = 701750539;
              continue;
            default:
              goto label_71;
          }
          int num13;
          num2 = num13 = num5 != 0 ? 1795701070 : (num13 = 1086311798);
          continue;
label_64:
          flag2 = num6 != 0;
          num2 = 1877320274;
        }
      }
      finally
      {
        enumerator.Dispose();
label_66:
        int num2 = 1425365612;
        while (true)
        {
          int num3 = 919488365;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -1981157372 ^ -173269875;
              continue;
            case 2:
              goto label_66;
            default:
              goto label_70;
          }
        }
label_70:;
      }
label_71:
      this.ReportProgress(FindButtons.\u206E‎⁭‮​⁮‎‮⁬‏⁪‬‎‭⁪‪⁬‭⁬‮⁪⁬⁪⁭⁮‎​‍⁪‭‪⁮‫⁮‍‏‏⁭‭‫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1328491857U), (object) FindButtons.Buttons.Count, (object) this.MeetingWindow.ZoomWindowType, (object) this.MeetingWindow.Size), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2496254670U));
label_72:
      int num14 = 730780683;
label_73:
      while (true)
      {
        int num2 = 919488365;
        uint num3;
        switch ((num3 = (uint) (num14 ^ num2)) % 4U)
        {
          case 0:
            goto label_72;
          case 1:
            goto label_76;
          case 2:
            num14 = (int) num3 * 1180388734 ^ 26744634;
            continue;
          case 3:
            goto label_74;
          default:
            goto label_68;
        }
      }
label_68:
      return;
label_74:
      return;
label_76:
      this.ReportProgress(FindButtons.\u202E‫‏⁫⁪‍‎⁪‭⁭⁭⁫⁫‍‏‏​‍‫⁪‌‭⁫‌​⁮⁮‮⁫‭‮⁬‫‭⁮‬‫⁫‭⁮‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4255754413U), (object) FindButtons.Buttons.Count), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(958707786U));
      num14 = 452472078;
      goto label_73;
    }

    private void CalculateBoundary()
    {
label_1:
      int num1 = 633690243;
      while (true)
      {
        int num2 = 1060890393;
        uint num3;
        Screen screen;
        Rectangle screenNonWorkingArea;
        Size size;
        Rectangle rectangle;
        bool requiresMovement;
        switch ((num3 = (uint) (num1 ^ num2)) % 31U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = 2103927220;
            continue;
          case 2:
            int num4 = this.MeetingWindow == null ? -612586146 : (num4 = -731812220);
            int num5 = (int) num3 * 824644541;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * -1219542078 ^ 800634688;
            continue;
          case 4:
            int num6 = !rectangle.IntersectsWith(screenNonWorkingArea) ? 758491779 : (num6 = 541503619);
            int num7 = (int) num3 * -1781908540;
            num1 = num6 ^ num7;
            continue;
          case 5:
            goto label_3;
          case 6:
            screen = WindowHelper.GetScreen(this.MeetingWindow);
            num1 = 649442760;
            continue;
          case 7:
            this.leftBoundary = 175;
            size = this.MeetingWindow.Size;
            this.rightBoundary = size.Width - 130 - 5;
            num1 = (int) num3 * 724177870 ^ 1276943487;
            continue;
          case 8:
            num1 = (int) num3 * -176639290 ^ 203998674;
            continue;
          case 9:
            size = this.MeetingWindow.Size;
            this.rightBoundary = size.Width / 2 + 275 - this.clickStepValue;
            num1 = (int) num3 * -1810723314 ^ -1417176634;
            continue;
          case 10:
            this.MeetingWindow.RefreshLocation();
            num1 = (int) num3 * -241843485 ^ -1412835752;
            continue;
          case 11:
            num1 = (int) num3 * -1261809617 ^ -468575872;
            continue;
          case 12:
            this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3495009550U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1512513212U));
            requiresMovement = this.MeetingWindow.RequiresMovement;
            num1 = (int) num3 * 1599280068 ^ 1591954351;
            continue;
          case 13:
            this.MeetingWindow.Refresh(true, true);
            num1 = (int) num3 * -1572543955 ^ 149182783;
            continue;
          case 14:
            size = this.MeetingWindow.Size;
            this.leftBoundary = size.Width / 2 - 275 - this.clickStepValue;
            num1 = (int) num3 * 892964093 ^ -448766329;
            continue;
          case 15:
            size = this.MeetingWindow.Size;
            this.lastY = size.Height - 35;
            num1 = 2008888704;
            continue;
          case 16:
            num1 = 1166475094;
            continue;
          case 17:
            num1 = (int) num3 * 121125415 ^ 1309678947;
            continue;
          case 18:
            rectangle = this.MeetingWindow.Rectangle;
            num1 = (int) num3 * 2091647260 ^ 926567206;
            continue;
          case 19:
            int num8 = !requiresMovement ? -380391818 : (num8 = -1012786758);
            int num9 = (int) num3 * 1607308873;
            num1 = num8 ^ num9;
            continue;
          case 20:
            this.MeetingWindow.Move(screen.WorkingArea);
            num1 = (int) num3 * -1410973921 ^ 1467174782;
            continue;
          case 21:
            this.NextX = this.leftBoundary + this.clickStepValue;
            num1 = (int) num3 * 190807752 ^ 377746483;
            continue;
          case 22:
            num1 = (int) num3 * -435066043 ^ -1691043167;
            continue;
          case 23:
            num1 = (int) num3 * 1231787012 ^ 78283554;
            continue;
          case 24:
            num1 = (int) num3 * 43756467 ^ -45269514;
            continue;
          case 25:
            num1 = 890113499;
            continue;
          case 26:
            num1 = (int) num3 * -1351063663 ^ -22861712;
            continue;
          case 27:
            size = this.MeetingWindow.Size;
            this.NextX = size.Width / 2 - 275 - this.clickStepValue;
            num1 = (int) num3 * -1947554658 ^ 1885938228;
            continue;
          case 28:
            this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1180127883U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3177472352U));
            num1 = (int) num3 * 1602858993 ^ 1883005111;
            continue;
          case 29:
            int num10 = 850;
            size = this.MeetingWindow.Size;
            int num11 = size.Width + 100;
            int num12 = num10 < num11 ? -1993726101 : (num12 = -495707677);
            int num13 = (int) num3 * -1715827561;
            num1 = num12 ^ num13;
            continue;
          case 30:
            screenNonWorkingArea = WindowHelper.GetScreenNonWorkingArea(screen);
            num1 = (int) num3 * 837147342 ^ -141565502;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return;
label_3:;
    }

    private void ValidateButton(ZoomButton button)
    {
      this.ReportProgress(FindButtons.\u206E‎⁭‮​⁮‎‮⁬‏⁪‬‎‭⁪‪⁬‭⁬‮⁪⁬⁪⁭⁮‎​‍⁪‭‪⁮‫⁮‍‏‏⁭‭‫‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2422986707U), (object) button.ResultingWindowType, (object) button.ButtonX, (object) button.ButtonY), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2451782146U));
label_1:
      int num1 = 1084786106;
      object activityLocker;
      while (true)
      {
        int num2 = 1589005932;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            button.Save();
            num1 = (int) num3 * -1131774326 ^ 1707014851;
            continue;
          case 3:
            this.Engine.AddButton(button);
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * -445890645 ^ 1480567980;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag1 = false;
      try
      {
        FindButtons.\u202B‬⁬‌‎‏‮‏⁬‬‪‬‮⁯⁪‬‫‫⁫‫‪⁫⁭‫‮‮‌⁬‎​​‏‪‮⁯‪⁫⁪‏‭‮(activityLocker, ref flag1);
label_7:
        int num2 = 1867712697;
        while (true)
        {
          int num3 = 1589005932;
          uint num4;
          bool flag2;
          bool flag3;
          switch ((num4 = (uint) (num2 ^ num3)) % 12U)
          {
            case 0:
              num2 = (int) num4 * 1204791276 ^ 1377803907;
              continue;
            case 1:
              int num5 = !flag2 ? 1956005716 : (num5 = 1506517041);
              int num6 = (int) num4 * 706058239;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = (int) num4 * -411027824 ^ 868602428;
              continue;
            case 3:
              flag3 = this.ButtonTypesRemainingToBeFound.Contains(button.ResultingWindowType);
              num2 = 1817824614;
              continue;
            case 4:
              goto label_23;
            case 5:
              goto label_7;
            case 6:
              num2 = (int) num4 * 1276174583 ^ -1862212750;
              continue;
            case 7:
              this.ButtonTypesRemainingToBeFound.Remove(button.ResultingWindowType);
              num2 = (int) num4 * 798837157 ^ -60915691;
              continue;
            case 8:
              FindButtons.Buttons.Add(button);
              num2 = (int) num4 * 1128723424 ^ -1568586748;
              continue;
            case 9:
              num2 = (int) num4 * -729278880 ^ 1226551351;
              continue;
            case 10:
              int num7 = !flag3 ? -1253879878 : (num7 = -1775194659);
              int num8 = (int) num4 * 482173365;
              num2 = num7 ^ num8;
              continue;
            case 11:
              flag2 = !FindButtons.Buttons.Contains(button);
              num2 = (int) num4 * -147775857 ^ 1806866640;
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
        if (flag1)
        {
label_21:
          int num2 = 451950096;
          while (true)
          {
            int num3 = 1589005932;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_21;
              case 1:
                FindButtons.\u200E⁬‭‎⁪‫⁯⁪‪⁭⁬‍‍‭‏⁪‫‬⁭​⁫⁭‪⁫‮‎‬‫‬‌‫‎‭‏​⁭‬⁬‪‮(activityLocker);
                num2 = (int) num4 * -450809528 ^ 1061839822;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
    }

    private void InvalidateButton(ZoomButton button)
    {
label_1:
      int num1 = 759677915;
      object activityLocker;
      while (true)
      {
        int num2 = 1181398957;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            activityLocker = ActivityBase.activityLocker;
            num1 = (int) num3 * -1453831120 ^ -19014493;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag1 = false;
      try
      {
        FindButtons.\u202B‬⁬‌‎‏‮‏⁬‬‪‬‮⁯⁪‬‫‫⁫‫‪⁫⁭‫‮‮‌⁬‎​​‏‪‮⁯‪⁫⁪‏‭‮(activityLocker, ref flag1);
label_6:
        int num2 = 1690797157;
        while (true)
        {
          int num3 = 1181398957;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 9U)
          {
            case 0:
              goto label_6;
            case 1:
              int num5 = !flag2 ? 1454199355 : (num5 = 1786502944);
              int num6 = (int) num4 * -177128479;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = (int) num4 * -143683492 ^ 1412906245;
              continue;
            case 3:
              num2 = (int) num4 * 1934218816 ^ 367964510;
              continue;
            case 4:
              flag2 = FindButtons.Buttons.Contains(button);
              num2 = (int) num4 * -1826765074 ^ 105100450;
              continue;
            case 5:
              FindButtons.Buttons.Remove(button);
              num2 = (int) num4 * -7244753 ^ 168420204;
              continue;
            case 6:
              num2 = (int) num4 * -2122104545 ^ -998948875;
              continue;
            case 7:
              this.ReportProgress(FindButtons.\u206E‎⁭‮​⁮‎‮⁬‏⁪‬‎‭⁪‪⁬‭⁬‮⁪⁬⁪⁭⁮‎​‍⁪‭‪⁮‫⁮‍‏‏⁭‭‫‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2712588997U), (object) button.ResultingWindowType, (object) button.ButtonX, (object) button.ButtonY), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1475082324U));
              num2 = (int) num4 * 1658654397 ^ 637185826;
              continue;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_16:
          int num2 = 287988255;
          while (true)
          {
            int num3 = 1181398957;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                num2 = (int) num4 * -1195724760 ^ -1084510003;
                continue;
              case 2:
                FindButtons.\u200E⁬‭‎⁪‫⁯⁪‪⁭⁬‍‍‭‏⁪‫‬⁭​⁫⁭‪⁫‮‎‬‫‬‌‫‎‭‏​⁭‬⁬‪‮(activityLocker);
                num2 = (int) num4 * 276000464 ^ -1349635288;
                continue;
              case 3:
                goto label_16;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:
      button.Delete();
    }

    protected override void ExecuteLogic()
    {
      FindButtons.\u202D‪‭‭⁯‬‭⁫‮⁯‎‫⁯‫⁭⁮‭⁪‍⁫⁪⁯‌‪⁪‫⁫‍‪‬‭⁭‮⁭‏‪‫‌​‬‮(CoreObject.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1976001230U));
      try
      {
        this.UpdateProperties();
        bool flag1 = this.Meeting == null;
label_2:
        int num1 = -619714033;
        while (true)
        {
          int num2 = -412945091;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              this.LoadExistingButtons();
              num1 = -649783594;
              continue;
            case 1:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(452601624U));
              num1 = (int) num3 * 1108856095 ^ 1060773874;
              continue;
            case 2:
              this.VerifyListRequiredButtons();
              num1 = -1574767427;
              continue;
            case 3:
              goto label_10;
            case 4:
              num1 = (int) num3 * -1070816453 ^ -1434409153;
              continue;
            case 5:
              flag2 = this.MeetingWindow == null;
              num1 = -1619542020;
              continue;
            case 6:
              num1 = (int) num3 * -783370318 ^ 2126125841;
              continue;
            case 7:
              num1 = (int) num3 * 1082455998 ^ -2078054738;
              continue;
            case 8:
              num1 = (int) num3 * -1093225658 ^ -2078432197;
              continue;
            case 9:
              int num4 = flag2 ? 896207522 : (num4 = 1610681259);
              int num5 = (int) num3 * 1879686112;
              num1 = num4 ^ num5;
              continue;
            case 10:
              num1 = (int) num3 * -610864141 ^ 2118361589;
              continue;
            case 11:
              this.CalculateBoundary();
              num1 = (int) num3 * 2023389293 ^ -310135841;
              continue;
            case 12:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2697896138U));
              num1 = (int) num3 * -1577986828 ^ 1888137491;
              continue;
            case 13:
              goto label_2;
            case 14:
              num1 = (int) num3 * 1231587034 ^ 1631746760;
              continue;
            case 16:
              int num6 = !flag1 ? 2039145202 : (num6 = 676115345);
              int num7 = (int) num3 * 746389940;
              num1 = num6 ^ num7;
              continue;
            case 17:
              num1 = (int) num3 * 22081705 ^ -200651900;
              continue;
            default:
              goto label_20;
          }
        }
label_10:
        this.MinimizeWindows(this.MeetingWindow);
        goto label_84;
label_20:
        try
        {
label_22:
          int num2 = -1098747367;
          while (true)
          {
            int num3 = -412945091;
            uint num4;
            ZoomButton existingButton;
            bool flag2;
            bool flag3;
            bool flag4;
            System.Drawing.Point clickPoint;
            bool flag5;
            int num5;
            int num6;
            switch ((num4 = (uint) (num2 ^ num3)) % 31U)
            {
              case 0:
                num2 = -1146662468;
                continue;
              case 1:
                num2 = (int) num4 * 1125982831 ^ 2073117409;
                continue;
              case 2:
                this.MeetingWindow.ClickButtonAwaitResult(existingButton, this.Token, true);
                num2 = (int) num4 * -918043809 ^ -1092527754;
                continue;
              case 3:
                if (!this.ButtonTypesRemainingToBeFound.Contains(existingButton.ResultingWindowType))
                {
                  num2 = (int) num4 * -956572832 ^ -1574505685;
                  continue;
                }
                num5 = 1;
                goto label_50;
              case 4:
                flag2 = this.NextX + this.clickStepValue >= this.rightBoundary;
                num2 = -922236558;
                continue;
              case 5:
                num2 = -1577631974;
                continue;
              case 6:
                num2 = (int) num4 * 1433659456 ^ -225844336;
                continue;
              case 7:
                existingButton = this.GetExistingButton(clickPoint);
                num2 = (int) num4 * 338879283 ^ 1589404271;
                continue;
              case 8:
                int num7 = flag5 ? 1128316466 : (num7 = 441075056);
                int num8 = (int) num4 * 369849567;
                num2 = num7 ^ num8;
                continue;
              case 9:
                int num9 = flag2 ? -1381311868 : (num9 = -1253032436);
                int num10 = (int) num4 * 1405575046;
                num2 = num9 ^ num10;
                continue;
              case 10:
                this.InvalidateButton(existingButton);
                num2 = (int) num4 * 638259899 ^ 1699074136;
                continue;
              case 11:
                num2 = -308814762;
                continue;
              case 12:
                this.CloseButtonWindows();
                num2 = (int) num4 * -1884315016 ^ 2020198366;
                continue;
              case 13:
                this.clickStepValue = 10;
                num2 = (int) num4 * -2081489811 ^ -1688379530;
                continue;
              case 14:
                num2 = (int) num4 * -1404143885 ^ 955863180;
                continue;
              case 15:
                flag3 = this.NextX + 10 < this.rightBoundary;
                num2 = (int) num4 * -762920715 ^ -928641411;
                continue;
              case 16:
                goto label_45;
              case 17:
                int num11 = flag4 ? -99798017 : (num11 = -1577308490);
                int num12 = (int) num4 * 1694562116;
                num2 = num11 ^ num12;
                continue;
              case 18:
                goto label_22;
              case 19:
                num2 = -1177887732;
                continue;
              case 20:
                num6 = clickPoint.X < this.rightBoundary ? 1 : 0;
                break;
              case 22:
                num2 = (int) num4 * 920853788 ^ -188597506;
                continue;
              case 23:
                num2 = -978454867;
                continue;
              case 24:
                num5 = ZoomWindow.ButtonPossibleResultingZoomWindowTypes.Contains(existingButton.ResultingWindowType) ? 1 : 0;
                goto label_50;
              case 25:
                this.ValidateButton(existingButton);
                num2 = (int) num4 * 699353608 ^ 558814114;
                continue;
              case 26:
                clickPoint = this.IncrementClickPoint();
                if (clickPoint.X <= this.leftBoundary)
                {
                  num6 = 0;
                  break;
                }
                num2 = (int) num4 * -10548603 ^ -422730069;
                continue;
              case 27:
                int num13 = !flag3 ? 1552824456 : (num13 = 101465289);
                int num14 = (int) num4 * 2076215413;
                num2 = num13 ^ num14;
                continue;
              case 28:
                if (existingButton.ClickState == ClickState.Verified)
                {
                  num2 = (int) num4 * 1504670320 ^ -662592769;
                  continue;
                }
                num5 = 0;
                goto label_50;
              case 29:
                num2 = (int) num4 * 1998002788 ^ -1470189498;
                continue;
              case 30:
                num2 = (int) num4 * 1596337707 ^ -1251764500;
                continue;
              default:
                goto label_67;
            }
            flag4 = num6 != 0;
            num2 = -1570655162;
            continue;
label_50:
            flag5 = num5 != 0;
            num2 = -859545837;
          }
label_45:
          CoreObject.log.InfoFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(785645787U), new object[0]);
          goto label_71;
        }
        catch (Exception ex)
        {
label_62:
          int num2 = -1917527976;
          while (true)
          {
            int num3 = -412945091;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                goto label_62;
              case 1:
                this.HandleException(ex);
                num2 = (int) num4 * -1436667752 ^ -1922343026;
                continue;
              case 2:
                num2 = (int) num4 * -897486225 ^ -1901184104;
                continue;
              case 3:
                num2 = (int) num4 * -379920564 ^ 2104153515;
                continue;
              default:
                goto label_67;
            }
          }
        }
label_67:
label_68:
        int num15 = -262112941;
label_69:
        bool flag6;
        while (true)
        {
          int num2 = -412945091;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num15 ^ num2)) % 16U)
          {
            case 0:
              num15 = (int) num3 * 1068960566 ^ -451723644;
              continue;
            case 1:
              num15 = (int) num3 * 112380536 ^ 1662670718;
              continue;
            case 2:
              flag2 = this.ActivityState != ActivityState.Error;
              num15 = (int) num3 * -131474081 ^ 1468299541;
              continue;
            case 3:
              num15 = (int) num3 * -843477351 ^ -342200167;
              continue;
            case 4:
              num15 = (int) num3 * 48798189 ^ 774023160;
              continue;
            case 5:
              goto label_68;
            case 6:
              int num4 = !flag2 ? 138047520 : (num4 = 1625832022);
              int num5 = (int) num3 * -964619383;
              num15 = num4 ^ num5;
              continue;
            case 7:
              if (!flag6)
              {
                num15 = (int) num3 * -77822579 ^ -1964109186;
                continue;
              }
              goto label_20;
            case 8:
              goto label_71;
            case 9:
              this.ReportProgress(string.Format(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1322686094U), !string.IsNullOrEmpty(this.Status) ? (object) (\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1242190227U) + this.Status) : (object) ""), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2005217345U));
              num15 = -990566049;
              continue;
            case 10:
              this.SetActivityState(ActivityState.Completed, this.Status);
              num15 = (int) num3 * -1306216974 ^ 1256889853;
              continue;
            case 11:
              num15 = -1046785279;
              continue;
            case 12:
              goto label_93;
            case 13:
              num15 = (int) num3 * 1891203292 ^ 924465195;
              continue;
            case 14:
              goto label_84;
            case 15:
              this.ExportButtons();
              num15 = (int) num3 * -319046977 ^ 1686038364;
              continue;
            default:
              goto label_90;
          }
        }
label_90:
        return;
label_93:
        return;
label_71:
        this.RestoreWindows();
        num15 = -1940873842;
        goto label_69;
label_84:
        flag6 = this.ContinueExecution();
        num15 = -220600518;
        goto label_69;
      }
      catch (Exception ex)
      {
        CoreObject.log.Error((object) ex);
label_88:
        int num1 = -1669185604;
        while (true)
        {
          int num2 = -412945091;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_88;
            case 1:
              this.HandleException(ex);
              num1 = (int) num3 * -70156924 ^ -943971422;
              continue;
            case 2:
              goto label_86;
            case 3:
              num1 = (int) num3 * -1016355047 ^ 600113028;
              continue;
            default:
              goto label_70;
          }
        }
label_70:
        return;
label_86:;
      }
    }

    private void ExportButtons()
    {
      string contents = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(924598976U);
      using (List<ZoomButton>.Enumerator enumerator = FindButtons.Buttons.GetEnumerator())
      {
label_5:
        int num1 = enumerator.MoveNext() ? 2102504956 : (num1 = 690412702);
        while (true)
        {
          int num2 = 1303559723;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_5;
            case 2:
              num1 = 2102504956;
              continue;
            case 3:
              ZoomButton current = enumerator.Current;
              contents = FindButtons.\u202C⁫‪​‭⁪‮‏‍⁬‮‬⁫⁮⁯⁭⁪⁬‌⁭⁯‍⁫‪‭‪‬‎‫‮⁫​‬‍‏​⁫⁬‮(contents, FindButtons.\u202B‏​⁬⁫‫‎‮‎​‬⁫⁮‭‬‭⁬⁮‮‭⁭‬‪‎‌⁯⁭⁯⁭⁮‫⁫‌‬‌‎‫⁭⁭⁬‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4207739581U), new object[4]
              {
                (object) current.ResultingWindowType,
                (object) current.ButtonLocation,
                (object) current.WindowSize,
                (object) current.ClickState
              }));
              num1 = 443041099;
              continue;
            default:
              goto label_8;
          }
        }
      }
label_8:
      File.WriteAllText(string.Format(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(553073482U), (object) this.MeetingId, (object) DateTime.Now.ToString(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4264436771U))), contents);
label_9:
      int num4 = 860467476;
      while (true)
      {
        int num1 = 1303559723;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_9;
          case 1:
            goto label_11;
          case 2:
            num4 = (int) num2 * -220402476 ^ 1397128936;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_11:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = -266422678;
      bool flag;
      while (true)
      {
        int num2 = -696930455;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = true;
            num1 = (int) num3 * -1274543971 ^ -773760614;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    static string \u202B‏​⁬⁫‫‎‮‎​‬⁫⁮‭‬‭⁬⁮‮‭⁭‬‪‎‌⁯⁭⁯⁭⁮‫⁫‌‬‌‎‫⁭⁭⁬‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u202B‬⁬‌‎‏‮‏⁬‬‪‬‮⁯⁪‬‫‫⁫‫‪⁫⁭‫‮‮‌⁬‎​​‏‪‮⁯‪⁫⁪‏‭‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202E⁯‍​‏​‮‎‮⁮‎⁬⁪‌⁪‏‮⁯‬⁫​⁬‮‮⁬‬⁫⁭‭⁭⁫‬⁮‍​‮‫‌‌⁫‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.DebugFormat(obj1, obj2, obj3);
    }

    static void \u200E⁬‭‎⁪‫⁯⁪‪⁭⁬‍‍‭‏⁪‫‬⁭​⁫⁭‪⁫‮‎‬‫‬‌‫‎‭‏​⁭‬⁬‪‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static void \u206F‫⁮​⁫‫⁭‮‎‭⁯⁭‬⁫‮⁬⁪⁫⁯‬⁪‎⁯‬​⁪⁮‍‬‪‌⁯‭‌⁯⁪‭⁯‎⁫‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static string \u202C⁫‪​‭⁪‮‏‍⁬‮‬⁫⁮⁯⁭⁪⁬‌⁭⁯‍⁫‪‭‪‬‎‫‮⁫​‬‍‏​⁫⁬‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static void \u206D⁫⁬‌‏‎‏‬⁮‪‭‌‬‏⁯⁯‎⁬‫‮‫⁮‫‮‪‭‮‏‫⁮‌⁬⁮‌⁭‮‪⁫⁫‫‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static string \u202E‫‏⁫⁪‍‎⁪‭⁭⁭⁫⁫‍‏‏​‍‫⁪‌‭⁫‌​⁮⁮‮⁫‭‮⁬‫‭⁮‬‫⁫‭⁮‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u200B⁮‏‬​⁬‍⁮⁬⁬‪⁫⁫⁫⁭‏‫⁯⁭‏⁯‌⁪‪⁫‪‪‫⁬‫‍⁫⁭⁪⁯⁬​⁮‭‫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static string \u206E‎⁭‮​⁮‎‮⁬‏⁪‬‎‭⁪‪⁬‭⁬‮⁪⁬⁪⁭⁮‎​‍⁪‭‪⁮‫⁮‍‏‏⁭‭‫‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      return string.Format(obj0, obj1, obj2, obj3);
    }

    static void \u202D‪‭‭⁯‬‭⁫‮⁯‎‫⁯‫⁭⁮‭⁪‍⁫⁪⁯‌‪⁪‫⁫‍‪‬‭⁭‮⁭‏‪‫‌​‬‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Info(obj1);
    }
  }
}
