// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MouseTracker
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ZoomZoom
{
  public static class MouseTracker
  {
    private static readonly ILog log = MouseTracker.\u206F‮⁭⁮⁯⁬​⁪‬⁮‮​⁯‎⁭‮‌‪‌‎⁭‌⁮‌‮‬⁬‪‏‮⁬‍‪​‏‬⁮⁬‎⁭‮(MouseTracker.\u206B⁭⁯‮⁬⁭‍‪⁯⁫⁮‍‮‭⁮‍‮⁪‎‮‎‫⁬⁪‮​‭‫⁪‏‍‫⁭⁪‏‎⁯‭‫⁫‮((MemberInfo) MouseTracker.\u200D⁫‪‭‭⁯‭‏⁮​‫‬‭‪⁯⁯⁯‪⁬​‌‍⁬‍‮‬⁬‫‫‪‮⁪‪‌‮‪⁬‎‎‏‮()));

    public static IntPtr getRootOwner(POINT point, out IntPtr hWnd)
    {
label_1:
      int num1 = 71922074;
      IntPtr num2;
      while (true)
      {
        int num3 = 818108980;
        uint num4;
        IntPtr ancestor;
        switch ((num4 = (uint) (num1 ^ num3)) % 6U)
        {
          case 0:
            num2 = ancestor;
            num1 = (int) num4 * -1091746833 ^ -170392401;
            continue;
          case 1:
            num1 = (int) num4 * 1373692848 ^ -99614382;
            continue;
          case 2:
            hWnd = User32.WindowFromPoint(point);
            num1 = (int) num4 * 1645327216 ^ 585814153;
            continue;
          case 3:
            goto label_1;
          case 5:
            ancestor = User32.GetAncestor(hWnd, 3U);
            num1 = (int) num4 * 1584321494 ^ 11266790;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return num2;
    }

    public static IntPtr getOwner(POINT pt)
    {
      try
      {
label_2:
        int num1 = 457266223;
        IntPtr hWnd;
        while (true)
        {
          int num2 = 1967887981;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 2:
              hWnd = User32.WindowFromPoint(pt);
              num1 = (int) num3 * 1143040879 ^ -1571466948;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return User32.GetAncestor(hWnd, 3U);
      }
      catch
      {
label_7:
        int num1 = 1137042468;
        while (true)
        {
          int num2 = 1967887981;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_7;
            case 2:
              num1 = (int) num3 * -792478277 ^ 53742010;
              continue;
            default:
              goto label_10;
          }
        }
      }
label_10:
      return IntPtr.Zero;
    }

    public static unsafe BaseWindow getWindow(IntPtr hWnd, POINT pt)
    {
      BaseWindow baseWindow1 = (BaseWindow) null;
      BaseWindow baseWindow2;
      try
      {
label_2:
        int num1 = 1761944296;
        while (true)
        {
          int num2 = 93445549;
          uint num3;
          int lpNumberOfBytesWritten;
          bool flag1;
          bool flag2;
          bool flag3;
          int index;
          IntPtr num4;
          string empty;
          TBBUTTONINFO* tbbuttoninfoPtr;
          StringBuilder stringBuilder;
          bool flag4;
          bool flag5;
          bool flag6;
          uint uIDItem;
          IntPtr num5;
          IntPtr lpBuffer;
          IntPtr lpNumberOfBytesRead;
          byte* numPtr;
          bool flag7;
          bool flag8;
          bool flag9;
          bool flag10;
          bool flag11;
          bool flag12;
          bool flag13;
          bool flag14;
          bool flag15;
          int num6;
          int num7;
          bool flag16;
          bool flag17;
          bool flag18;
          bool flag19;
          bool flag20;
          bool flag21;
          bool flag22;
          bool flag23;
          TBBUTTON* tbbuttonPtr;
          bool flag24;
          int length;
          bool flag25;
          bool flag26;
          IntPtr hMenu;
          bool flag27;
          bool flag28;
          bool flag29;
          bool flag30;
          bool flag31;
          bool flag32;
          bool flag33;
          bool flag34;
          bool flag35;
          bool flag36;
          bool flag37;
          switch ((num3 = (uint) (num1 ^ num2)) % 215U)
          {
            case 0:
              num1 = (int) num3 * -737923317 ^ 1636052951;
              continue;
            case 1:
              BaseWindow baseWindow3 = baseWindow1;
              string str1 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow3.extendedStyles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1503825013U));
              baseWindow3.extendedStyles = str1;
              num1 = (int) num3 * 1460186458 ^ 193632135;
              continue;
            case 2:
              int num8;
              num1 = num8 = ((ulong) lpNumberOfBytesWritten & 4096UL) > 0UL ? 2034521889 : (num8 = 1310749720);
              continue;
            case 3:
              flag5 = User32.GetWindowRect(hWnd, out baseWindow1.rect);
              num1 = (int) num3 * -1144282308 ^ -1999354816;
              continue;
            case 4:
              int num9 = flag34 ? 2024272937 : (num9 = 1352393378);
              int num10 = (int) num3 * -1392808421;
              num1 = num9 ^ num10;
              continue;
            case 5:
              int num11 = flag12 ? -27070471 : (num11 = -1188947575);
              int num12 = (int) num3 * 1299147098;
              num1 = num11 ^ num12;
              continue;
            case 6:
              flag14 = (uint) (lpNumberOfBytesWritten & 131072) > 0U;
              num1 = 400393027;
              continue;
            case 7:
              empty += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2076693704U);
              num1 = (int) num3 * 1755772176 ^ 1070046386;
              continue;
            case 8:
              num1 = (int) num3 * -1835398577 ^ -1307897529;
              continue;
            case 9:
              num7 = 0;
              num1 = (int) num3 * 1404399142 ^ 1788608186;
              continue;
            case 10:
              BaseWindow baseWindow4 = baseWindow1;
              string str2 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow4.styles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2290370189U));
              baseWindow4.styles = str2;
              num1 = (int) num3 * 536977434 ^ 996223164;
              continue;
            case 11:
              flag23 = (uint) (lpNumberOfBytesWritten & 1048576) > 0U;
              num1 = 1766298973;
              continue;
            case 12:
              int num13 = !flag1 ? 1868557843 : (num13 = 1250371994);
              int num14 = (int) num3 * -1286648205;
              num1 = num13 ^ num14;
              continue;
            case 13:
              int num15 = flag7 ? -563158354 : (num15 = -528498334);
              int num16 = (int) num3 * -1718804098;
              num1 = num15 ^ num16;
              continue;
            case 14:
              int num17 = flag17 ? -1950175895 : (num17 = -1362724977);
              int num18 = (int) num3 * 819119437;
              num1 = num17 ^ num18;
              continue;
            case 15:
              num1 = (int) num3 * 748494555 ^ 813646731;
              continue;
            case 16:
              uint lpdwProcessId = 0;
              User32.GetWindowThreadProcessId(hWnd, out lpdwProcessId);
              num5 = Kernel32.OpenProcess(2035711U, false, lpdwProcessId);
              numPtr = stackalloc byte[4096];
              num1 = (int) num3 * -1821178256 ^ -977952225;
              continue;
            case 17:
              num6 = tbbuttonPtr->idCommand;
              num1 = (int) num3 * 473390718 ^ 1001083559;
              continue;
            case 18:
              BaseWindow baseWindow5 = baseWindow1;
              string str3 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow5.extendedStyles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(734818766U));
              baseWindow5.extendedStyles = str3;
              num1 = (int) num3 * -1213057751 ^ 1238154247;
              continue;
            case 19:
              baseWindow1.className = MouseTracker.\u202D‬‏⁫‬‏‪​⁫⁯‍‎⁮‮‏‮⁭‫‏‮‮‪‌‫‮‬⁯⁭‍‪⁯​‪‭​⁫⁮⁭‎‮((object) stringBuilder);
              num1 = (int) num3 * 673299574 ^ 1003698690;
              continue;
            case 20:
              num1 = (int) num3 * 706127626 ^ 1353955510;
              continue;
            case 21:
              int num19 = !flag25 ? 679406597 : (num19 = 752927460);
              int num20 = (int) num3 * -428827225;
              num1 = num19 ^ num20;
              continue;
            case 22:
              int num21 = !flag26 ? -593914536 : (num21 = -1715441004);
              int num22 = (int) num3 * 433709936;
              num1 = num21 ^ num22;
              continue;
            case 23:
              num1 = (int) num3 * -1537812152 ^ -779434620;
              continue;
            case 24:
              numPtr[lpNumberOfBytesWritten] = (byte) 0;
              num1 = 1207735661;
              continue;
            case 25:
              BaseWindow baseWindow6 = baseWindow1;
              string str4 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow6.extendedStyles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1205978224U));
              baseWindow6.extendedStyles = str4;
              num1 = (int) num3 * -555340161 ^ 1622972268;
              continue;
            case 26:
              flag8 = lpNumberOfBytesWritten < 4096;
              num1 = 1099916749;
              continue;
            case 27:
              baseWindow1.itemStrings[(int) uIDItem] = stringBuilder.ToString();
              num1 = (int) num3 * -580723542 ^ 524522397;
              continue;
            case 28:
              flag10 = (uint) (lpNumberOfBytesWritten & 134217728) > 0U;
              num1 = 1699511484;
              continue;
            case 29:
              int num23;
              num1 = num23 = (long) uIDItem < (long) lpNumberOfBytesWritten ? 1332723516 : (num23 = 1773965319);
              continue;
            case 30:
              int num24 = flag18 ? 1848017201 : (num24 = 82126842);
              int num25 = (int) num3 * 541549016;
              num1 = num24 ^ num25;
              continue;
            case 31:
              baseWindow1.styles = MouseTracker.\u202E⁮‪⁮⁯‮⁪⁪‫⁭​⁬‏⁭‍⁫‪‮⁫‭⁭⁬‫⁫‬‭‫‮‎‎⁯⁪⁯‌‪⁪⁯‬‪⁬‮(baseWindow1.styles, 0, 2);
              num1 = (int) num3 * 533821241 ^ -6701625;
              continue;
            case 32:
              hWnd = User32.WindowFromPoint(pt);
              num1 = (int) num3 * -1582531733 ^ 826246867;
              continue;
            case 33:
              int num26 = !flag16 ? -1860857874 : (num26 = -1328639410);
              int num27 = (int) num3 * 330308888;
              num1 = num26 ^ num27;
              continue;
            case 34:
              flag20 = ((uint) tbbuttoninfoPtr->fsStyle & 16U) > 0U;
              num1 = 242044594;
              continue;
            case 35:
              int num28;
              num1 = num28 = ((ulong) lpNumberOfBytesWritten & 0UL) > 0UL ? 1825540332 : (num28 = 36296142);
              continue;
            case 36:
              BaseWindow baseWindow7 = baseWindow1;
              string str5 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow7.styles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(862634100U));
              baseWindow7.styles = str5;
              num1 = (int) num3 * 1057504194 ^ -299564294;
              continue;
            case 37:
              int num29;
              num1 = num29 = ((ulong) lpNumberOfBytesWritten & 0UL) <= 0UL ? 1019396375 : (num29 = 922783181);
              continue;
            case 38:
              BaseWindow baseWindow8 = baseWindow1;
              string str6 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow8.styles, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4196382365U));
              baseWindow8.styles = str6;
              num1 = (int) num3 * 1927834372 ^ 10807839;
              continue;
            case 39:
              BaseWindow baseWindow9 = baseWindow1;
              string str7 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow9.styles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2966838189U));
              baseWindow9.styles = str7;
              num1 = (int) num3 * 1081410510 ^ 1267511937;
              continue;
            case 40:
              flag27 = (uint) (lpNumberOfBytesWritten & 268435456) > 0U;
              num1 = 1646238712;
              continue;
            case 41:
              num1 = 1390820586;
              continue;
            case 42:
              int num30 = !flag29 ? -1610120544 : (num30 = -1329679080);
              int num31 = (int) num3 * -1361121114;
              num1 = num30 ^ num31;
              continue;
            case 43:
              int num32 = flag22 ? -1190897555 : (num32 = -33877583);
              int num33 = (int) num3 * 1051066090;
              num1 = num32 ^ num33;
              continue;
            case 44:
              BaseWindow baseWindow10 = baseWindow1;
              string str8 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow10.styles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(126831220U));
              baseWindow10.styles = str8;
              num1 = (int) num3 * 1522405667 ^ 636194333;
              continue;
            case 45:
              BaseWindow baseWindow11 = baseWindow1;
              string str9 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow11.styles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4112694268U));
              baseWindow11.styles = str9;
              num1 = (int) num3 * 792702084 ^ 1232935278;
              continue;
            case 46:
              baseWindow1.itemType = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2047973268U);
              baseWindow1.hMenu = hMenu;
              lpNumberOfBytesWritten = (int) User32.GetMenuItemCount(hMenu);
              num1 = (int) num3 * 394363273 ^ 1901181543;
              continue;
            case 47:
              int num34 = flag15 ? 1462209139 : (num34 = 226912449);
              int num35 = (int) num3 * 1799460016;
              num1 = num34 ^ num35;
              continue;
            case 48:
              int num36;
              num1 = num36 = (uint) (lpNumberOfBytesWritten & 65536) > 0U ? 131564554 : (num36 = 223271299);
              continue;
            case 49:
              flag17 = ((ulong) lpNumberOfBytesWritten & 8192UL) > 0UL;
              num1 = 802022290;
              continue;
            case 50:
              int num37 = !flag2 ? 1226999009 : (num37 = 894018167);
              int num38 = (int) num3 * -966627604;
              num1 = num37 ^ num38;
              continue;
            case 51:
              flag5 = Kernel32.WriteProcessMemory(num5, num4, lpBuffer, (uint) sizeof (TBBUTTONINFO), out lpNumberOfBytesWritten);
              num1 = (int) num3 * -1219255082 ^ 943248180;
              continue;
            case 52:
              num1 = (int) num3 * 2064233419 ^ 1488585820;
              continue;
            case 53:
              tbbuttoninfoPtr->cbSize = (uint) Marshal.SizeOf(typeof (TBBUTTONINFO));
              num1 = (int) num3 * 435287788 ^ -723663587;
              continue;
            case 54:
              BaseWindow baseWindow12 = baseWindow1;
              string str10 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow12.extendedStyles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1153634611U));
              baseWindow12.extendedStyles = str10;
              num1 = (int) num3 * -574248166 ^ 1624023113;
              continue;
            case 55:
              BaseWindow baseWindow13 = baseWindow1;
              string str11 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow13.extendedStyles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2698793262U));
              baseWindow13.extendedStyles = str11;
              num1 = (int) num3 * 1637810005 ^ 1500213589;
              continue;
            case 56:
              int num39 = !flag6 ? 1508857208 : (num39 = 2056414386);
              int num40 = (int) num3 * 1850393979;
              num1 = num39 ^ num40;
              continue;
            case 57:
              lpBuffer = new IntPtr((void*) numPtr);
              num1 = (int) num3 * 1626501124 ^ -1772158289;
              continue;
            case 58:
              flag15 = (uint) (lpNumberOfBytesWritten & 8388608) > 0U;
              num1 = 763591831;
              continue;
            case 59:
              num1 = (int) num3 * -1539800919 ^ -1624537622;
              continue;
            case 60:
              User32.GetClassName(hWnd, stringBuilder, MouseTracker.\u200E‪⁪⁭‌‫‭⁬⁭⁭‪⁬‏⁯‭‪‭⁬‭‏⁭⁫‪‮⁯​⁮‏‬⁬⁮‬⁮⁭‎‌‏⁯⁭⁭‮(stringBuilder));
              num1 = (int) num3 * 1323327651 ^ 386809941;
              continue;
            case 61:
              flag4 = (uint) (lpNumberOfBytesWritten & 536870912) > 0U;
              num1 = 1075093830;
              continue;
            case 62:
              num1 = (int) num3 * 1270045396 ^ 917210404;
              continue;
            case 63:
              BaseWindow baseWindow14 = baseWindow1;
              string str12 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow14.styles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2770201895U));
              baseWindow14.styles = str12;
              num1 = (int) num3 * 948384389 ^ 1154089718;
              continue;
            case 64:
              length = (int) User32.SendMessage(hWnd, 1048U, 0U, 0U);
              num1 = (int) num3 * -1595248846 ^ -15474490;
              continue;
            case 65:
              int num41 = flag36 ? 241385009 : (num41 = 1123914730);
              int num42 = (int) num3 * 1907346279;
              num1 = num41 ^ num42;
              continue;
            case 66:
              goto label_2;
            case 67:
              int num43;
              num1 = num43 = (uint) (lpNumberOfBytesWritten & 524288) > 0U ? 374730573 : (num43 = 1093605275);
              continue;
            case 68:
              hMenu = User32.SendMessage(hWnd, 481U, IntPtr.Zero, IntPtr.Zero);
              num1 = (int) num3 * -1815476944 ^ 722938189;
              continue;
            case 69:
              BaseWindow baseWindow15 = baseWindow1;
              string str13 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow15.styles, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2784982583U));
              baseWindow15.styles = str13;
              num1 = 840995487;
              continue;
            case 70:
              baseWindow1.parent = User32.GetParent(hWnd);
              baseWindow1.owner = User32.GetAncestor(hWnd, 3U);
              baseWindow1.child = User32.GetWindow(hWnd, GW.CHILD);
              num1 = 1887593811;
              continue;
            case 71:
              empty += \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2705713587U);
              num1 = (int) num3 * -813965492 ^ 590507491;
              continue;
            case 72:
              tbbuttoninfoPtr->dwMask = 72U;
              num1 = (int) num3 * -572410970 ^ 477731169;
              continue;
            case 73:
              BaseWindow baseWindow16 = baseWindow1;
              string str14 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow16.extendedStyles, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(396459875U));
              baseWindow16.extendedStyles = str14;
              num1 = (int) num3 * 1146575892 ^ -1128016641;
              continue;
            case 74:
              baseWindow1.styles = string.Empty;
              num1 = 765199262;
              continue;
            case 75:
              baseWindow1.itemStrings = new string[lpNumberOfBytesWritten];
              uIDItem = 0U;
              num1 = (int) num3 * -1580416060 ^ -1026059623;
              continue;
            case 76:
              ++uIDItem;
              num1 = (int) num3 * -1772649300 ^ -480111075;
              continue;
            case 77:
              flag5 = Kernel32.ReadProcessMemory(num5, num4, lpBuffer, (uint) sizeof (TBBUTTON), lpNumberOfBytesRead);
              num1 = 423725774;
              continue;
            case 78:
              int num44 = flag8 ? 1542650345 : (num44 = 686926285);
              int num45 = (int) num3 * -1579412930;
              num1 = num44 ^ num45;
              continue;
            case 79:
              flag30 = ((ulong) lpNumberOfBytesWritten & 1024UL) > 0UL;
              num1 = 1521590894;
              continue;
            case 80:
              flag25 = length > 0;
              num1 = (int) num3 * 199995114 ^ -2119359772;
              continue;
            case 81:
              int num46 = flag14 ? 1123479041 : (num46 = 454035241);
              int num47 = (int) num3 * -1338522265;
              num1 = num46 ^ num47;
              continue;
            case 82:
              flag22 = lpNumberOfBytesWritten > 0;
              num1 = (int) num3 * 1255850405 ^ -1995315703;
              continue;
            case 83:
              BaseWindow baseWindow17 = baseWindow1;
              string str15 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow17.extendedStyles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2116259404U));
              baseWindow17.extendedStyles = str15;
              num1 = (int) num3 * -1086347821 ^ -2139538148;
              continue;
            case 84:
              int num48;
              num1 = num48 = (uint) (lpNumberOfBytesWritten & 1073741824) <= 0U ? 1015807261 : (num48 = 1941555177);
              continue;
            case 85:
              int num49 = !flag11 ? -1760785220 : (num49 = -2117961917);
              int num50 = (int) num3 * -814317278;
              num1 = num49 ^ num50;
              continue;
            case 86:
              baseWindow1 = new BaseWindow();
              baseWindow1.hWnd = hWnd;
              num1 = 1505843184;
              continue;
            case 87:
              num1 = 1128737058;
              continue;
            case 88:
              BaseWindow baseWindow18 = baseWindow1;
              string str16 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow18.extendedStyles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(851761515U));
              baseWindow18.extendedStyles = str16;
              num1 = (int) num3 * 1915874583 ^ 352454568;
              continue;
            case 89:
              BaseWindow baseWindow19 = baseWindow1;
              string str17 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow19.styles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1790659731U));
              baseWindow19.styles = str17;
              num1 = (int) num3 * 734679375 ^ -595944679;
              continue;
            case 90:
              BaseWindow baseWindow20 = baseWindow1;
              string str18 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow20.styles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1529852880U));
              baseWindow20.styles = str18;
              num1 = (int) num3 * 1528253713 ^ 1055611941;
              continue;
            case 91:
              int num51 = flag37 ? -1066570599 : (num51 = -453137050);
              int num52 = (int) num3 * 1734650636;
              num1 = num51 ^ num52;
              continue;
            case 92:
              BaseWindow baseWindow21 = baseWindow1;
              string str19 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow21.styles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1267665717U));
              baseWindow21.styles = str19;
              num1 = (int) num3 * 575824344 ^ 1763315837;
              continue;
            case 93:
              int num53;
              num1 = num53 = ((ulong) lpNumberOfBytesWritten & 8UL) > 0UL ? 356462494 : (num53 = 1682131748);
              continue;
            case 94:
              baseWindow1.itemStyles = new string[length];
              num1 = (int) num3 * -674075074 ^ 1672047163;
              continue;
            case 95:
              num1 = (int) num3 * -2084936444 ^ -1464446069;
              continue;
            case 96:
              int num54 = flag4 ? 1505496612 : (num54 = 1035089351);
              int num55 = (int) num3 * 1494528059;
              num1 = num54 ^ num55;
              continue;
            case 97:
              BaseWindow baseWindow22 = baseWindow1;
              string str20 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow22.extendedStyles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(62554292U));
              baseWindow22.extendedStyles = str20;
              num1 = (int) num3 * -859839518 ^ -333792316;
              continue;
            case 98:
              num1 = 2055103448;
              continue;
            case 99:
              baseWindow1.next = User32.GetWindow(hWnd, GW.HWNDNEXT);
              num1 = (int) num3 * -1608053198 ^ 1487302754;
              continue;
            case 100:
              int num56;
              num1 = num56 = index >= length ? 417073373 : (num56 = 767917992);
              continue;
            case 101:
              flag29 = ((uint) tbbuttoninfoPtr->fsStyle & 8U) > 0U;
              num1 = 1220979782;
              continue;
            case 102:
              flag12 = hWnd == IntPtr.Zero;
              num1 = 32977303;
              continue;
            case 103:
              num1 = (int) num3 * 1962067996 ^ -1288540650;
              continue;
            case 104:
              baseWindow1.extendedStyles = MouseTracker.\u202E⁮‪⁮⁯‮⁪⁪‫⁭​⁬‏⁭‍⁫‪‮⁫‭⁭⁬‫⁫‬‭‫‮‎‎⁯⁪⁯‌‪⁪⁯‬‪⁬‮(baseWindow1.extendedStyles, 0, 2);
              num1 = 1459164396;
              continue;
            case 105:
              int num57 = flag3 ? -1175697162 : (num57 = -1688305168);
              int num58 = (int) num3 * 596538111;
              num1 = num57 ^ num58;
              continue;
            case 106:
              Kernel32.VirtualFreeEx(num5, num4, UIntPtr.Zero, 32768U);
              num1 = (int) num3 * 773509847 ^ 267007741;
              continue;
            case 107:
              tbbuttoninfoPtr = (TBBUTTONINFO*) numPtr;
              num6 = 0;
              num1 = (int) num3 * -90684741 ^ 1483464886;
              continue;
            case 108:
              BaseWindow baseWindow23 = baseWindow1;
              string str21 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow23.extendedStyles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4105544505U));
              baseWindow23.extendedStyles = str21;
              num1 = (int) num3 * 814982297 ^ 1565483852;
              continue;
            case 109:
              num1 = 56310844;
              continue;
            case 110:
              int num59 = flag28 ? -355399113 : (num59 = -1465547706);
              int num60 = (int) num3 * 1378196547;
              num1 = num59 ^ num60;
              continue;
            case 111:
              int num61 = flag31 ? 563140899 : (num61 = 149536250);
              int num62 = (int) num3 * -1654177741;
              num1 = num61 ^ num62;
              continue;
            case 112:
              BaseWindow baseWindow24 = baseWindow1;
              string str22 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow24.extendedStyles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3750978929U));
              baseWindow24.extendedStyles = str22;
              num1 = (int) num3 * 915243656 ^ 2139328611;
              continue;
            case 113:
              empty += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3586962582U);
              num1 = (int) num3 * 728190435 ^ 980496211;
              continue;
            case 114:
              int num63 = flag35 ? 548176043 : (num63 = 1735722476);
              int num64 = (int) num3 * 1746497497;
              num1 = num63 ^ num64;
              continue;
            case 115:
              int num65;
              num1 = num65 = (uint) (lpNumberOfBytesWritten & 67108864) <= 0U ? 1367915506 : (num65 = 1399827250);
              continue;
            case 116:
              BaseWindow baseWindow25 = baseWindow1;
              string str23 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow25.extendedStyles, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1663100705U));
              baseWindow25.extendedStyles = str23;
              num1 = (int) num3 * -55956440 ^ -58208745;
              continue;
            case 117:
              int num66;
              num1 = num66 = ((uint) tbbuttoninfoPtr->fsStyle & 128U) > 0U ? 1813245204 : (num66 = 1593243224);
              continue;
            case 118:
              int num67;
              num1 = num67 = ((ulong) lpNumberOfBytesWritten & 65536UL) > 0UL ? 1333127373 : (num67 = 233325910);
              continue;
            case 119:
              BaseWindow baseWindow26 = baseWindow1;
              string str24 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow26.extendedStyles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4272738073U));
              baseWindow26.extendedStyles = str24;
              num1 = (int) num3 * 924955142 ^ 33023048;
              continue;
            case 120:
              lpNumberOfBytesWritten = (int) User32.SendMessage(hWnd, 1099U, (IntPtr) num6, num4);
              num1 = (int) num3 * -734512355 ^ 258554959;
              continue;
            case 121:
              flag32 = ((ulong) lpNumberOfBytesWritten & 0UL) > 0UL;
              num1 = 1990638580;
              continue;
            case 122:
              BaseWindow baseWindow27 = baseWindow1;
              string str25 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow27.styles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3317660154U));
              baseWindow27.styles = str25;
              num1 = (int) num3 * 740963737 ^ 657550325;
              continue;
            case 123:
              flag35 = ((ulong) lpNumberOfBytesWritten & 524288UL) > 0UL;
              num1 = 654483992;
              continue;
            case 124:
              flag2 = (uint) (lpNumberOfBytesWritten & 262144) > 0U;
              num1 = 989993550;
              continue;
            case 125:
              BaseWindow baseWindow28 = baseWindow1;
              string str26 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow28.extendedStyles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2161418108U));
              baseWindow28.extendedStyles = str26;
              num1 = (int) num3 * -898976431 ^ -703824220;
              continue;
            case 126:
              lpNumberOfBytesWritten = (int) User32.SendMessage(hWnd, 13U, (uint) MouseTracker.\u200E‪⁪⁭‌‫‭⁬⁭⁭‪⁬‏⁯‭‪‭⁬‭‏⁭⁫‪‮⁯​⁮‏‬⁬⁮‬⁮⁭‎‌‏⁯⁭⁭‮(stringBuilder), stringBuilder);
              num1 = (int) num3 * 1829111589 ^ 451980958;
              continue;
            case (uint) sbyte.MaxValue:
              int num68;
              num1 = num68 = (uint) (lpNumberOfBytesWritten & 4194304) <= 0U ? 1029366427 : (num68 = 408173514);
              continue;
            case 128:
              Kernel32.CloseHandle(num5);
              num1 = (int) num3 * 1644806349 ^ -262641652;
              continue;
            case 129:
              num1 = (int) num3 * -1149617924 ^ 1803946708;
              continue;
            case 130:
              BaseWindow baseWindow29 = baseWindow1;
              string str27 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow29.extendedStyles, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2453469178U));
              baseWindow29.extendedStyles = str27;
              num1 = (int) num3 * 681204979 ^ 1305974032;
              continue;
            case 131:
              int num69 = !flag32 ? -772769972 : (num69 = -63468651);
              int num70 = (int) num3 * 695298843;
              num1 = num69 ^ num70;
              continue;
            case 132:
              lpNumberOfBytesWritten = (int) User32.SendMessage(hWnd, 1047U, (IntPtr) index, num4);
              int num71 = lpNumberOfBytesWritten != 0 ? 151786053 : (num71 = 1571050618);
              int num72 = (int) num3 * -37993876;
              num1 = num71 ^ num72;
              continue;
            case 133:
              int num73;
              num1 = num73 = ((ulong) lpNumberOfBytesWritten & 32UL) > 0UL ? 17967181 : (num73 = 1355757705);
              continue;
            case 134:
              int num74;
              num1 = num74 = ((ulong) lpNumberOfBytesWritten & 64UL) <= 0UL ? 1484713163 : (num74 = 1092617128);
              continue;
            case 135:
              lpNumberOfBytesRead = new IntPtr(num7);
              num4 = Kernel32.VirtualAllocEx(num5, IntPtr.Zero, new UIntPtr(4096U), 4096U, 4U);
              num1 = (int) num3 * 1635314349 ^ 970989931;
              continue;
            case 136:
              flag31 = (uint) (lpNumberOfBytesWritten & 33554432) > 0U;
              num1 = 1501527583;
              continue;
            case 137:
              num1 = (int) num3 * -69803704 ^ 1154246760;
              continue;
            case 138:
              lpNumberOfBytesWritten = (int) User32.SendMessage(hWnd, 14U, 0U, 0U);
              num1 = (int) num3 * -855029816 ^ -354518874;
              continue;
            case 139:
              flag26 = ((ulong) lpNumberOfBytesWritten & 4UL) > 0UL;
              num1 = 797398625;
              continue;
            case 140:
              stringBuilder = MouseTracker.\u206E​‪‮⁯‮‌‍​‬⁫⁬⁫‭‬⁫⁪‌‫‬‏⁮⁭⁪‌⁬⁫‌⁯​⁭‌‍‏⁮‏‎⁫‪‏‮(128);
              num1 = (int) num3 * -1886826765 ^ -109451985;
              continue;
            case 141:
              int num75 = flag20 ? 1095404670 : (num75 = 1450335450);
              int num76 = (int) num3 * -1727648001;
              num1 = num75 ^ num76;
              continue;
            case 142:
              BaseWindow baseWindow30 = baseWindow1;
              string str28 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow30.extendedStyles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(872080214U));
              baseWindow30.extendedStyles = str28;
              num1 = (int) num3 * -1347954699 ^ 1937437654;
              continue;
            case 143:
              flag3 = ((ulong) lpNumberOfBytesWritten & 1048576UL) > 0UL;
              num1 = 588132364;
              continue;
            case 144:
              baseWindow1.previous = User32.GetWindow(hWnd, GW.HWNDPREV);
              num1 = (int) num3 * -1586973547 ^ -61286419;
              continue;
            case 145:
              BaseWindow baseWindow31 = baseWindow1;
              string str29 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow31.styles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2660554883U));
              baseWindow31.styles = str29;
              num1 = (int) num3 * -358870116 ^ -227149365;
              continue;
            case 146:
              empty = string.Empty;
              flag28 = ((uint) tbbuttoninfoPtr->fsStyle & 1U) > 0U;
              num1 = (int) num3 * -1668147112 ^ -1619939278;
              continue;
            case 147:
              flag34 = lpNumberOfBytesWritten != -1;
              num1 = (int) num3 * 520998297 ^ -1348277531;
              continue;
            case 148:
              BaseWindow baseWindow32 = baseWindow1;
              string str30 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow32.styles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(549693281U));
              baseWindow32.styles = str30;
              num1 = (int) num3 * 1968888190 ^ 1183099813;
              continue;
            case 149:
              num1 = (int) num3 * -751250493 ^ -797969557;
              continue;
            case 150:
              int num77 = !flag13 ? -383777651 : (num77 = -295807418);
              int num78 = (int) num3 * -782927995;
              num1 = num77 ^ num78;
              continue;
            case 151:
              lpNumberOfBytesWritten = (int) User32.GetWindowLongPtr(hWnd, -16);
              num1 = 1175657325;
              continue;
            case 152:
              flag36 = ((ulong) lpNumberOfBytesWritten & 131072UL) > 0UL;
              num1 = 1385552913;
              continue;
            case 153:
              baseWindow1.itemType = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3380727959U);
              baseWindow1.itemStrings = new string[length];
              num1 = (int) num3 * 2096246007 ^ -1644513065;
              continue;
            case 154:
              BaseWindow baseWindow33 = baseWindow1;
              string str31 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow33.styles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3926501601U));
              baseWindow33.styles = str31;
              num1 = (int) num3 * 1295918613 ^ 835353595;
              continue;
            case 155:
              int num79 = flag10 ? -1617991854 : (num79 = -1798762950);
              int num80 = (int) num3 * 177749860;
              num1 = num79 ^ num80;
              continue;
            case 156:
              lpNumberOfBytesWritten = (int) User32.GetWindowLongPtr(hWnd, -20);
              num1 = 919924655;
              continue;
            case 157:
              int num81 = (uint) lpNumberOfBytesWritten <= 0U ? 322444242 : (num81 = 1185223677);
              int num82 = (int) num3 * -1866623309;
              num1 = num81 ^ num82;
              continue;
            case 158:
              baseWindow1.itemStyles[index] = empty.Substring(2);
              num1 = (int) num3 * -1025923300 ^ 2121048345;
              continue;
            case 159:
              flag11 = ((ulong) lpNumberOfBytesWritten & 16UL) > 0UL;
              num1 = 2146170270;
              continue;
            case 160:
              BaseWindow baseWindow34 = baseWindow1;
              string str32 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow34.extendedStyles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3528012761U));
              baseWindow34.extendedStyles = str32;
              num1 = (int) num3 * 1377711031 ^ 1963239271;
              continue;
            case 161:
              flag5 = Kernel32.ReadProcessMemory(num5, num4, lpBuffer, (uint) sizeof (TBBUTTONINFO), lpNumberOfBytesRead);
              num1 = (int) num3 * -360699300 ^ 644875342;
              continue;
            case 162:
              lpNumberOfBytesWritten = (int) User32.SendMessage(hWnd, 1087U, (IntPtr) num6, num4);
              flag7 = lpNumberOfBytesWritten != -1;
              num1 = (int) num3 * -1506845746 ^ 1674139491;
              continue;
            case 163:
              int num83;
              num1 = num83 = ((ulong) lpNumberOfBytesWritten & 33554432UL) > 0UL ? 998725714 : (num83 = 435082202);
              continue;
            case 164:
              ++index;
              num1 = 552612255;
              continue;
            case 165:
              tbbuttonPtr = (TBBUTTON*) numPtr;
              num1 = (int) num3 * 1595482307 ^ 820105894;
              continue;
            case 166:
              num1 = 79943510;
              continue;
            case 167:
              flag24 = (uint) lpNumberOfBytesWritten > 0U;
              num1 = (int) num3 * -1891188641 ^ -401891108;
              continue;
            case 168:
              int num84 = !flag9 ? -1854531727 : (num84 = -1730316349);
              int num85 = (int) num3 * 681259824;
              num1 = num84 ^ num85;
              continue;
            case 169:
              int num86 = flag30 ? 805521834 : (num86 = 1856349873);
              int num87 = (int) num3 * -1620395047;
              num1 = num86 ^ num87;
              continue;
            case 170:
              flag6 = ((ulong) lpNumberOfBytesWritten & 256UL) > 0UL;
              num1 = 972505660;
              continue;
            case 171:
              int num88 = !flag21 ? 875705381 : (num88 = 1024507686);
              int num89 = (int) num3 * 133581425;
              num1 = num88 ^ num89;
              continue;
            case 172:
              int num90 = flag33 ? -698960137 : (num90 = -35326537);
              int num91 = (int) num3 * -1242667256;
              num1 = num90 ^ num91;
              continue;
            case 173:
              int num92;
              num1 = num92 = ((ulong) lpNumberOfBytesWritten & 128UL) <= 0UL ? 403291090 : (num92 = 660425563);
              continue;
            case 174:
              int num93 = flag23 ? -1546382297 : (num93 = -1928230577);
              int num94 = (int) num3 * 322700950;
              num1 = num93 ^ num94;
              continue;
            case 175:
              flag33 = ((ulong) lpNumberOfBytesWritten & 4194304UL) > 0UL;
              num1 = 1487078541;
              continue;
            case 176:
              int num95;
              num1 = num95 = (uint) (lpNumberOfBytesWritten & 131072) <= 0U ? 934256839 : (num95 = 423543272);
              continue;
            case 177:
              flag1 = ((ulong) lpNumberOfBytesWritten & 512UL) > 0UL;
              num1 = 20490760;
              continue;
            case 178:
              BaseWindow baseWindow35 = baseWindow1;
              string str33 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow35.extendedStyles, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(402265638U));
              baseWindow35.extendedStyles = str33;
              num1 = (int) num3 * 1609478274 ^ -1282980158;
              continue;
            case 179:
              index = 0;
              num1 = (int) num3 * 807584530 ^ 663380078;
              continue;
            case 180:
              BaseWindow baseWindow36 = baseWindow1;
              string str34 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow36.extendedStyles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2211318593U));
              baseWindow36.extendedStyles = str34;
              num1 = (int) num3 * -1935277602 ^ -1879760438;
              continue;
            case 181:
              BaseWindow baseWindow37 = baseWindow1;
              string str35 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow37.extendedStyles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(839116042U));
              baseWindow37.extendedStyles = str35;
              num1 = (int) num3 * 2036624495 ^ -182459914;
              continue;
            case 182:
              flag21 = ((ulong) lpNumberOfBytesWritten & 16384UL) > 0UL;
              num1 = 161293061;
              continue;
            case 183:
              BaseWindow baseWindow38 = baseWindow1;
              string str36 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow38.extendedStyles, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2833242955U));
              baseWindow38.extendedStyles = str36;
              num1 = (int) num3 * -1943852058 ^ 533382578;
              continue;
            case 184:
              lpNumberOfBytesWritten = 0;
              num1 = 455896891;
              continue;
            case 185:
              BaseWindow baseWindow39 = baseWindow1;
              string str37 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow39.extendedStyles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1721282618U));
              baseWindow39.extendedStyles = str37;
              num1 = (int) num3 * -83456110 ^ -1308201040;
              continue;
            case 186:
              int num96;
              num1 = num96 = (uint) (lpNumberOfBytesWritten & 65536) > 0U ? 839919316 : (num96 = 308328208);
              continue;
            case 187:
              flag9 = empty.Length > 2;
              num1 = 999809255;
              continue;
            case 188:
              flag19 = ((ulong) lpNumberOfBytesWritten & 2147483648UL) > 0UL;
              num1 = (int) num3 * 1304596568 ^ 877109822;
              continue;
            case 189:
              BaseWindow baseWindow40 = baseWindow1;
              string str38 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow40.extendedStyles, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(983012056U));
              baseWindow40.extendedStyles = str38;
              num1 = (int) num3 * -941116398 ^ -1501024610;
              continue;
            case 190:
              int num97 = !(hWnd == IntPtr.Zero) ? 1252400310 : (num97 = 884199322);
              int num98 = (int) num3 * 2068971004;
              num1 = num97 ^ num98;
              continue;
            case 191:
              flag13 = ((ulong) lpNumberOfBytesWritten & 1UL) > 0UL;
              num1 = (int) num3 * 1195339794 ^ 308793897;
              continue;
            case 192:
              baseWindow1.text = MouseTracker.\u202D‬‏⁫‬‏‪​⁫⁯‍‎⁮‮‏‮⁭‫‏‮‮‪‌‫‮‬⁯⁭‍‪⁯​‪‭​⁫⁮⁭‎‮((object) stringBuilder);
              num1 = (int) num3 * 612000243 ^ -644397203;
              continue;
            case 193:
              num1 = 1277371097;
              continue;
            case 194:
              int num99 = !flag24 ? -58373061 : (num99 = -1743071331);
              int num100 = (int) num3 * -1041675251;
              num1 = num99 ^ num100;
              continue;
            case 195:
              flag37 = User32.IsMenu(hMenu);
              num1 = (int) num3 * 513873507 ^ 424338434;
              continue;
            case 196:
              empty += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1357340956U);
              num1 = (int) num3 * -316391023 ^ -2042208692;
              continue;
            case 197:
              num1 = (int) num3 * -313407269 ^ -1819896075;
              continue;
            case 198:
              flag18 = (uint) (lpNumberOfBytesWritten & 16777216) > 0U;
              num1 = 1152921120;
              continue;
            case 199:
              BaseWindow baseWindow41 = baseWindow1;
              string str39 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow41.styles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2724551553U));
              baseWindow41.styles = str39;
              num1 = (int) num3 * -1185776857 ^ -410160086;
              continue;
            case 200:
              flag5 = Kernel32.ReadProcessMemory(num5, num4, lpBuffer, 4096U, lpNumberOfBytesRead);
              baseWindow1.itemStrings[index] = Marshal.PtrToStringUni((IntPtr) ((void*) numPtr), lpNumberOfBytesWritten);
              num1 = (int) num3 * -1546983811 ^ -1159557526;
              continue;
            case 201:
              int menuString = (int) User32.GetMenuString(hMenu, uIDItem, stringBuilder, stringBuilder.Capacity, 1024U);
              num1 = 863041254;
              continue;
            case 202:
              int num101;
              num1 = num101 = ((ulong) lpNumberOfBytesWritten & 262144UL) > 0UL ? 1133012796 : (num101 = 674038909);
              continue;
            case 203:
              flag16 = ((ulong) lpNumberOfBytesWritten & 134217728UL) > 0UL;
              num1 = 923291664;
              continue;
            case 204:
              BaseWindow baseWindow42 = baseWindow1;
              string str40 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow42.styles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(344929063U));
              baseWindow42.styles = str40;
              num1 = (int) num3 * -1897340549 ^ -833724377;
              continue;
            case 205:
              int num102 = !flag27 ? -2030608344 : (num102 = -906999180);
              int num103 = (int) num3 * -90775712;
              num1 = num102 ^ num103;
              continue;
            case 206:
              int num104;
              num1 = num104 = (uint) (lpNumberOfBytesWritten & 2097152) > 0U ? 1236227683 : (num104 = 85302316);
              continue;
            case 208:
              goto label_23;
            case 209:
              baseWindow1.extendedStyles = string.Empty;
              num1 = 2093145488;
              continue;
            case 210:
              BaseWindow baseWindow43 = baseWindow1;
              string str41 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow43.extendedStyles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1205912231U));
              baseWindow43.extendedStyles = str41;
              num1 = (int) num3 * 929578711 ^ -1220378291;
              continue;
            case 211:
              BaseWindow baseWindow44 = baseWindow1;
              string str42 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow44.styles, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(854152546U));
              baseWindow44.styles = str42;
              num1 = (int) num3 * -401016791 ^ 413583729;
              continue;
            case 212:
              int num105 = flag19 ? 359071713 : (num105 = 191365973);
              int num106 = (int) num3 * -221297398;
              num1 = num105 ^ num106;
              continue;
            case 213:
              BaseWindow baseWindow45 = baseWindow1;
              string str43 = MouseTracker.\u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮(baseWindow45.styles, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2512250952U));
              baseWindow45.styles = str43;
              num1 = (int) num3 * 1628936093 ^ 1094820730;
              continue;
            case 214:
              ++lpNumberOfBytesWritten;
              num1 = (int) num3 * 1250685581 ^ -534910098;
              continue;
            default:
              goto label_222;
          }
        }
label_23:
        baseWindow2 = (BaseWindow) null;
        goto label_226;
      }
      catch (Exception ex)
      {
label_218:
        int num1 = 129865040;
        while (true)
        {
          int num2 = 93445549;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              MouseTracker.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1785021728U), (object) ex.Message);
              num1 = (int) num3 * 2106283399 ^ 1486042852;
              continue;
            case 2:
              num1 = (int) num3 * -22816841 ^ -2116888265;
              continue;
            case 3:
              goto label_218;
            default:
              goto label_222;
          }
        }
      }
label_222:
      baseWindow2 = baseWindow1;
label_223:
      int num107 = 321209277;
      while (true)
      {
        int num1 = 93445549;
        uint num2;
        switch ((num2 = (uint) (num107 ^ num1)) % 3U)
        {
          case 1:
            num107 = (int) num2 * -1591456689 ^ -745582482;
            continue;
          case 2:
            goto label_223;
          default:
            goto label_226;
        }
      }
label_226:
      return baseWindow2;
    }

    static StringBuilder \u206E​‪‮⁯‮‌‍​‬⁫⁬⁫‭‬⁫⁪‌‫‬‏⁮⁭⁪‌⁬⁫‌⁯​⁭‌‍‏⁮‏‎⁫‪‏‮([In] int obj0)
    {
      return new StringBuilder(obj0);
    }

    static int \u200E‪⁪⁭‌‫‭⁬⁭⁭‪⁬‏⁯‭‪‭⁬‭‏⁭⁫‪‮⁯​⁮‏‬⁬⁮‬⁮⁭‎‌‏⁯⁭⁭‮([In] StringBuilder obj0)
    {
      return obj0.Capacity;
    }

    static string \u202D‬‏⁫‬‏‪​⁫⁯‍‎⁮‮‏‮⁭‫‏‮‮‪‌‫‮‬⁯⁭‍‪⁯​‪‭​⁫⁮⁭‎‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u202D‌⁭‮‌‎‫⁫⁬⁪‍‍⁪‬‎⁪‍‮‫⁫‭‎‫‎⁯‌⁯​⁮‮‏⁯⁫⁭⁯‮‍⁫⁬‎‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static string \u202E⁮‪⁮⁯‮⁪⁪‫⁭​⁬‏⁭‍⁫‪‮⁫‭⁭⁬‫⁫‬‭‫‮‎‎⁯⁪⁯‌‪⁪⁯‬‪⁬‮([In] string obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Remove(obj1, obj2);
    }

    static MethodBase \u200D⁫‪‭‭⁯‭‏⁮​‫‬‭‪⁯⁯⁯‪⁬​‌‍⁬‍‮‬⁬‫‫‪‮⁪‪‌‮‪⁬‎‎‏‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206B⁭⁯‮⁬⁭‍‪⁯⁫⁮‍‮‭⁮‍‮⁪‎‮‎‫⁬⁪‮​‭‫⁪‏‍‫⁭⁪‏‎⁯‭‫⁫‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206F‮⁭⁮⁯⁬​⁪‬⁮‮​⁯‎⁭‮‌‪‌‎⁭‌⁮‌‮‬⁬‪‏‮⁬‍‪​‏‬⁮⁬‎⁭‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
