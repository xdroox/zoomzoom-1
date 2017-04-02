// Decompiled with JetBrains decompiler
// Type: Core.WindowHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using flaphx.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Core
{
  public static class WindowHelper
  {
    public static string GetWindowTitle(IntPtr handle)
    {
label_1:
      int num1 = -2045388832;
      string str;
      while (true)
      {
        int num2 = -504163173;
        uint num3;
        int num4;
        StringBuilder lpString;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * 1943858871 ^ 1561865080;
            continue;
          case 1:
            num4 = (int) User32.SendMessage(handle, 14U, 0U, 0U);
            num1 = (int) num3 * 1828979092 ^ -1752650991;
            continue;
          case 2:
            str = WindowHelper.\u206E‪‌‌‮⁬‍‍⁯⁯⁫⁭⁬⁮‭‍‎⁪‎⁯⁯‫‪‮‮‪‫‬‍‍⁫⁫⁪‪⁪‍⁪‏⁯‪‮((object) lpString);
            num1 = (int) num3 * 502421074 ^ 1734945989;
            continue;
          case 4:
            goto label_1;
          case 5:
            StringBuilder lParam = WindowHelper.\u202E⁫‫⁮‍‮⁪‫⁯‌⁬‭‭‌⁯⁮⁪‍‮⁪⁮‏⁫⁬⁮‪‮‪‫‭‏‌‫⁫⁭⁮⁪‎⁮‏‮(128);
            num4 = (int) User32.SendMessage(handle, 13U, (uint) WindowHelper.\u206F‍‏‌​‍⁮⁯‏‮⁯‍‏‪‬‌⁬‎​‍‭​‍‮‭⁪‌⁯‪⁬‌‏‭‭⁯​‌‎⁯⁫‮(lParam), lParam);
            str = WindowHelper.\u206E‪‌‌‮⁬‍‍⁯⁯⁫⁭⁬⁮‭‍‎⁪‎⁯⁯‫‪‮‮‪‫‬‍‍⁫⁫⁪‪⁪‍⁪‏⁯‪‮((object) lParam);
            num1 = (int) num3 * -1964689626 ^ -16215296;
            continue;
          case 6:
            int num5 = num4 > 0 ? 169309190 : (num5 = 1514383346);
            int num6 = (int) num3 * 446842284;
            num1 = num5 ^ num6;
            continue;
          case 7:
            num1 = (int) num3 * -2037405904 ^ 789140442;
            continue;
          case 8:
            flaphx.utils.NativeMethods.GetWindowText(handle, lpString, WindowHelper.\u206F‍‏‌​‍⁮⁯‏‮⁯‍‏‪‬‌⁬‎​‍‭​‍‮‭⁪‌⁯‪⁬‌‏‭‭⁯​‌‎⁯⁫‮(lpString));
            num1 = (int) num3 * -1054838578 ^ 990166205;
            continue;
          case 9:
            lpString = WindowHelper.\u202E⁫‫⁮‍‮⁪‫⁯‌⁬‭‭‌⁯⁮⁪‍‮⁪⁮‏⁫⁬⁮‪‮‪‫‭‏‌‫⁫⁭⁮⁪‎⁮‏‮(flaphx.utils.NativeMethods.GetWindowTextLength(handle) * 2);
            num1 = -485643477;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return str;
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, StringBuilder lParam);

    public static string GetWindowTextRaw(IntPtr handle)
    {
      int wMsg = 14;
      int num1 = WindowHelper.SendMessage(handle, wMsg, 0, (StringBuilder) null);
label_1:
      int num2 = -1159772208;
      string str;
      while (true)
      {
        int num3 = -939776888;
        uint num4;
        bool flag;
        StringBuilder lParam;
        switch ((num4 = (uint) (num2 ^ num3)) % 9U)
        {
          case 0:
            str = WindowHelper.\u206E‪‌‌‮⁬‍‍⁯⁯⁫⁭⁬⁮‭‍‎⁪‎⁯⁯‫‪‮‮‪‫‬‍‍⁫⁫⁪‪⁪‍⁪‏⁯‪‮((object) lParam);
            num2 = (int) num4 * 2129517940 ^ -1178568622;
            continue;
          case 2:
            int num5 = flag ? -1098888011 : (num5 = -1204391125);
            int num6 = (int) num4 * 2127654844;
            num2 = num5 ^ num6;
            continue;
          case 3:
            str = string.Empty;
            num2 = -548824257;
            continue;
          case 4:
            lParam = WindowHelper.\u202E⁫‫⁮‍‮⁪‫⁯‌⁬‭‭‌⁯⁮⁪‍‮⁪⁮‏⁫⁬⁮‪‮‪‫‭‏‌‫⁫⁭⁮⁪‎⁮‏‮(num1);
            WindowHelper.SendMessage(handle, 13, num1 + 1, lParam);
            num2 = (int) num4 * 1779339132 ^ 351769995;
            continue;
          case 5:
            num2 = (int) num4 * -395438603 ^ -1873573821;
            continue;
          case 6:
            num2 = (int) num4 * 1800231117 ^ -347085306;
            continue;
          case 7:
            goto label_1;
          case 8:
            flag = (uint) num1 > 0U;
            num2 = (int) num4 * 944049621 ^ 1554171447;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return str;
    }

    public static Screen GetScreen(Rectangle rectangle)
    {
      Screen[] screenArray = WindowHelper.\u202D‪‮‪‭⁭‪‎‭‫​‮⁪‫‎‎‫‬‍‮⁫⁫‫‎⁪‪‪⁬‏⁮⁪⁪‪‌⁬‭‭⁪‫‭‮();
      int index1 = 0;
label_1:
      int num1 = 482690513;
      Screen screen1;
      while (true)
      {
        int num2 = 239372203;
        uint num3;
        Screen screen2;
        Rectangle rectangle1;
        Screen screen3;
        Screen[] allScreens;
        int index2;
        switch ((num3 = (uint) (num1 ^ num2)) % 24U)
        {
          case 0:
            num1 = (int) num3 * -1010791081 ^ 899912733;
            continue;
          case 1:
            index2 = 0;
            num1 = (int) num3 * -399551421 ^ 1214812660;
            continue;
          case 2:
            num1 = (int) num3 * -1806641146 ^ -116345453;
            continue;
          case 3:
            int num4 = !rectangle1.IntersectsWith(rectangle) ? 1798716157 : (num4 = 577180095);
            int num5 = (int) num3 * 1083113290;
            num1 = num4 ^ num5;
            continue;
          case 4:
            allScreens = Screen.AllScreens;
            num1 = (int) num3 * 2118815767 ^ 1198270006;
            continue;
          case 5:
            screen2 = screenArray[index1];
            rectangle1 = WindowHelper.\u200F⁬‏‫⁬⁭⁫‫⁪⁭‪⁮‎‭⁮‌‎⁫‎‌⁮‮⁪‍⁬⁪‪⁭‏⁬‭‭⁯⁭⁫‫‭‪⁯⁭‮(screen2);
            int num6;
            num1 = num6 = rectangle1.Contains(new Point(rectangle.X, rectangle.Y)) ? 1129789643 : (num6 = 549933432);
            continue;
          case 6:
            screen1 = screen2;
            num1 = (int) num3 * -1776822092 ^ -2136312876;
            continue;
          case 7:
            num1 = (int) num3 * 155114750 ^ -321964217;
            continue;
          case 8:
            num1 = (int) num3 * 728249301 ^ -1494436003;
            continue;
          case 9:
            screen1 = (Screen) null;
            num1 = (int) num3 * 861656165 ^ -2000268856;
            continue;
          case 10:
            num1 = (int) num3 * 855320748 ^ 617825127;
            continue;
          case 11:
            num1 = 1207319700;
            continue;
          case 12:
            int num7;
            num1 = num7 = index1 < screenArray.Length ? 1890626030 : (num7 = 177769929);
            continue;
          case 13:
            screen1 = screen3;
            num1 = (int) num3 * 1764259841 ^ -1197041322;
            continue;
          case 14:
            rectangle1 = screen3.Bounds;
            num1 = (int) num3 * -1535169699 ^ -176348842;
            continue;
          case 15:
            ++index1;
            num1 = (int) num3 * 1626396280 ^ 211981591;
            continue;
          case 16:
            num1 = 1391136724;
            continue;
          case 17:
            num1 = (int) num3 * -213205869 ^ -1428983170;
            continue;
          case 18:
            num1 = (int) num3 * -1063993570 ^ 1979536642;
            continue;
          case 19:
            goto label_1;
          case 20:
            int num8;
            num1 = num8 = index2 >= allScreens.Length ? 1623056274 : (num8 = 1267374686);
            continue;
          case 21:
            screen3 = allScreens[index2];
            num1 = 270651282;
            continue;
          case 23:
            ++index2;
            num1 = (int) num3 * -983106203 ^ 2071325948;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return screen1;
    }

    public static Rectangle GetWindowRectangle(IntPtr handle)
    {
      User32.RECT lprect;
      User32.GetWindowRect(handle, out lprect);
label_1:
      int num1 = 1141269239;
      Rectangle rectangle;
      while (true)
      {
        int num2 = 1140710690;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            rectangle = new Rectangle(lprect.X, lprect.Y, lprect.Width, lprect.Height);
            num1 = (int) num3 * -1707704184 ^ -1539140699;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -570737336 ^ -1036759746;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return rectangle;
    }

    public static string GetWindowClass(IntPtr handle)
    {
label_1:
      int num1 = -1745674822;
      string str;
      while (true)
      {
        int num2 = -107707462;
        uint num3;
        StringBuilder lpClassName;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            lpClassName = WindowHelper.\u202E⁫‫⁮‍‮⁪‫⁯‌⁬‭‭‌⁯⁮⁪‍‮⁪⁮‏⁫⁬⁮‪‮‪‫‭‏‌‫⁫⁭⁮⁪‎⁮‏‮(128);
            num1 = (int) num3 * 479752314 ^ 1963129388;
            continue;
          case 3:
            str = WindowHelper.\u206E‪‌‌‮⁬‍‍⁯⁯⁫⁭⁬⁮‭‍‎⁪‎⁯⁯‫‪‮‮‪‫‬‍‍⁫⁫⁪‪⁪‍⁪‏⁯‪‮((object) lpClassName);
            num1 = (int) num3 * 1252582909 ^ 1722199102;
            continue;
          case 4:
            User32.GetClassName(handle, lpClassName, WindowHelper.\u206F‍‏‌​‍⁮⁯‏‮⁯‍‏‪‬‌⁬‎​‍‭​‍‮‭⁪‌⁯‪⁬‌‏‭‭⁯​‌‎⁯⁫‮(lpClassName));
            num1 = (int) num3 * -235004050 ^ 1016447028;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return str;
    }

    public static IntPtr FindWindow(string windowTitle, string className = "", int millisecondsWait = 0)
    {
label_1:
      int num1 = 1922050071;
      IntPtr num2;
      while (true)
      {
        int num3 = 2097031586;
        uint num4;
        DateTime now;
        bool flag1;
        bool flag2;
        IntPtr num5;
        bool flag3;
        DateTime dateTime;
        int num6;
        int num7;
        int num8;
        switch ((num4 = (uint) (num1 ^ num3)) % 22U)
        {
          case 0:
            int num9 = flag2 ? -753441984 : (num9 = -283648428);
            int num10 = (int) num4 * -1084296439;
            num1 = num9 ^ num10;
            continue;
          case 1:
            now = DateTime.Now;
            num1 = (int) num4 * 272849977 ^ -1022909818;
            continue;
          case 2:
            if (windowTitle.Equals(string.Empty))
            {
              num6 = 0;
              break;
            }
            num1 = 712120374;
            continue;
          case 3:
            goto label_1;
          case 4:
            num7 = num5.Equals((object) IntPtr.Zero) ? 1 : 0;
            goto label_21;
          case 5:
            num5 = flaphx.utils.NativeMethods.FindWindow(className, windowTitle);
            num1 = (int) num4 * 760716968 ^ 1374542086;
            continue;
          case 6:
            num1 = (int) num4 * -2011834655 ^ 1296026269;
            continue;
          case 7:
            dateTime = now.AddMilliseconds((double) millisecondsWait);
            num5 = IntPtr.Zero;
            num1 = (int) num4 * -432207601 ^ -349902477;
            continue;
          case 8:
            num8 = !windowTitle.Equals(string.Empty) ? 1 : 0;
            goto label_12;
          case 9:
            if (!num5.Equals((object) IntPtr.Zero))
            {
              num8 = 0;
              goto label_12;
            }
            else
            {
              num1 = 664327784;
              continue;
            }
          case 10:
            num2 = new IntPtr(0);
            num1 = (int) num4 * -35664808 ^ -1703762228;
            continue;
          case 11:
            num1 = 1043523782;
            continue;
          case 12:
            num1 = (int) num4 * -829898563 ^ -1644036227;
            continue;
          case 13:
            int num11 = !flag1 ? 1935698056 : (num11 = 289681164);
            int num12 = (int) num4 * -1664132781;
            num1 = num11 ^ num12;
            continue;
          case 14:
            num1 = (int) num4 * -1504927678 ^ -1596963269;
            continue;
          case 15:
            num5 = flaphx.utils.NativeMethods.FindWindowByCaption(new IntPtr(0), windowTitle);
            num1 = (int) num4 * -397558405 ^ 941164038;
            continue;
          case 16:
            num6 = !className.Equals(string.Empty) ? 1 : 0;
            break;
          case 17:
            flag2 = num5.Equals((object) IntPtr.Zero);
            num1 = (int) num4 * 1149753690 ^ -59204504;
            continue;
          case 18:
            if (!(dateTime > DateTime.Now))
            {
              num7 = 0;
              goto label_21;
            }
            else
            {
              num1 = (int) num4 * -177442519 ^ 1691355736;
              continue;
            }
          case 20:
            num2 = num5;
            num1 = 86884536;
            continue;
          case 21:
            int num13 = !flag3 ? -885653266 : (num13 = -546289488);
            int num14 = (int) num4 * -1268687011;
            num1 = num13 ^ num14;
            continue;
          default:
            goto label_32;
        }
        flag1 = num6 != 0;
        num1 = 771198817;
        continue;
label_12:
        flag3 = num8 != 0;
        num1 = 836791213;
        continue;
label_21:
        int num15;
        num1 = num15 = num7 != 0 ? 1660803156 : (num15 = 34268441);
      }
label_32:
      return num2;
    }

    public static bool CloseWindowByCommand(IntPtr iHandle)
    {
      if (flaphx.utils.NativeMethods.SendMessage(iHandle, flaphx.utils.NativeMethods.WMConstants.WM_CLOSE, IntPtr.Zero, IntPtr.Zero) > 0)
        goto label_4;
label_1:
      int num1 = -2023886724;
label_2:
      while (true)
      {
        int num2 = -957746041;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1880118899 ^ -843061970;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_3:
      int num4 = 0;
      goto label_5;
label_7:
      bool flag;
      return flag;
label_4:
      num4 = 1;
label_5:
      flag = num4 != 0;
      num1 = -981193593;
      goto label_2;
    }

    public static List<IntPtr> GetChildWindows(IntPtr parent)
    {
label_1:
      int num1 = 208478978;
      List<IntPtr> numList1;
      while (true)
      {
        int num2 = 1644280060;
        uint num3;
        List<IntPtr> numList2;
        IntPtr num4;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            numList2.Add(num4);
            numList2.AddRange((IEnumerable<IntPtr>) WindowHelper.GetChildWindows(num4));
            num4 = flaphx.utils.NativeMethods.FindWindowEx(parent, num4, (string) null, (string) null);
            num1 = (int) num3 * -115244594 ^ -592853694;
            continue;
          case 2:
            num4 = flaphx.utils.NativeMethods.GetWindow(parent, flaphx.utils.NativeMethods.GetWindow_Cmd.GW_CHILD);
            num1 = (int) num3 * 517304164 ^ 73934716;
            continue;
          case 3:
            numList2 = new List<IntPtr>();
            num1 = (int) num3 * -1834855756 ^ 515604769;
            continue;
          case 5:
            num1 = 269947311;
            continue;
          case 6:
            numList1 = numList2;
            num1 = (int) num3 * 2081079104 ^ -37276155;
            continue;
          case 7:
            int num5 = !flag ? 493303303 : (num5 = 368379632);
            int num6 = (int) num3 * 803007095;
            num1 = num5 ^ num6;
            continue;
          case 8:
            flag = num4 != IntPtr.Zero;
            num1 = 2080196668;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return numList1;
    }

    public static WinPosition GetWindowPosition(IntPtr targetHandle)
    {
label_1:
      int num1 = -1144786170;
      WinPosition winPosition1;
      while (true)
      {
        int num2 = -1013030503;
        uint num3;
        flaphx.utils.NativeMethods.TITLEBARINFO pti;
        WinPosition winPosition2;
        bool titleBarInfo;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -822885364 ^ -1338112751;
            continue;
          case 2:
            int num4 = !titleBarInfo ? -1565675352 : (num4 = -2001071109);
            int num5 = (int) num3 * -2032257890;
            num1 = num4 ^ num5;
            continue;
          case 4:
            winPosition1 = winPosition2;
            num1 = -1823104326;
            continue;
          case 5:
            winPosition2 = new WinPosition();
            num1 = -937090371;
            continue;
          case 6:
            winPosition2 = new WinPosition(pti);
            num1 = (int) num3 * 648435788 ^ 572204936;
            continue;
          case 7:
            pti = new flaphx.utils.NativeMethods.TITLEBARINFO();
            pti.cbSize = (uint) Marshal.SizeOf<flaphx.utils.NativeMethods.TITLEBARINFO>((M0) pti);
            titleBarInfo = flaphx.utils.NativeMethods.GetTitleBarInfo(targetHandle, ref pti);
            num1 = (int) num3 * -1854016466 ^ -2095073559;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return winPosition1;
    }

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EnumThreadWindows(uint threadId, WindowHelper.EnumThreadWindowsProc callback, int param);

    public static List<IntPtr> EnumerateProcessWindowHandles(Process processToInspect)
    {
label_1:
      int num1 = -422932459;
      while (true)
      {
        int num2 = -569842406;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * 2029713496 ^ -1640728725;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      List<IntPtr> handles = new List<IntPtr>();
      try
      {
label_6:
        int num2 = -1365276612;
        while (true)
        {
          int num3 = -569842406;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_6;
            case 2:
              if (!WindowHelper.\u202A⁭⁬⁯‬​​⁫​‍⁮​⁫‎‎‫‪⁪‌⁮‭‭‬⁪‍⁫‫⁫‌‌​⁯⁬‫‍⁯​⁯‫‭‮(processToInspect))
              {
                num2 = (int) num4 * -308010628 ^ -864095387;
                continue;
              }
              goto label_26;
            case 3:
              num2 = (int) num4 * -205340480 ^ 123662459;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        IEnumerator enumerator = WindowHelper.\u200F​‪⁫⁪‮‪‎⁬‏⁪⁮​‭​‌⁬‫‏‫⁯‪⁮‍‏‏‬‭‪⁭⁬‎⁮⁫⁬​​‍⁯‭‮((ReadOnlyCollectionBase) WindowHelper.\u206E‏‎⁮⁬⁬⁯‭⁭⁯⁭⁫‮⁫​⁫‍‭⁫‫‭‪‮⁯‏⁪‫⁯‎‌⁫‪⁭​⁮‎‬‌‫⁬‮(processToInspect));
        uint num5;
        try
        {
label_16:
          int num3 = !WindowHelper.\u206B‮‍⁯⁮‭⁯‮⁯⁬‫‫⁫‮‍‪⁬‮⁫⁮⁪⁪⁪‪⁮⁫⁬​‪‮‍‍‍‍⁯‌⁯⁮​‍‮(enumerator) ? -430988608 : (num3 = -800979939);
          while (true)
          {
            int num4 = -569842406;
            switch ((num5 = (uint) (num3 ^ num4)) % 4U)
            {
              case 0:
                num3 = -800979939;
                continue;
              case 1:
                goto label_16;
              case 3:
                flaphx.utils.NativeMethods.EnumThreadWindows(WindowHelper.\u206C‪⁫‬⁯‬‬‭‏​‏‭⁮‭⁮‌⁪‫⁪⁮⁯‏‮​⁮‫‭‏⁫‮‏‫⁯‌‍‎‎⁮‬⁪‮(WindowHelper.\u206B‬‌⁪‌​‮‌⁫⁬⁫⁫⁯‏​⁫⁪‮⁭‮​‭‬‍⁮‌‭‌‮‮⁪‫‫⁪‫⁬‭‫⁪‍‮((ProcessThread) WindowHelper.\u200D‫⁭⁫‭‬⁪‌‭‍⁬​​‮⁬‌⁬‪⁫‎‏‎​⁭‌‭‎‍⁫⁬‬⁪⁮‌​‏‪‭⁯‏‮(enumerator))), (flaphx.utils.NativeMethods.EnumThreadWindowsProc) ((hWnd, lParam) =>
                {
                  handles.Add(hWnd);
label_1:
                  int num2 = -1558559543;
                  bool flag;
                  while (true)
                  {
                    int num3 = -184528302;
                    uint num4;
                    switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                    {
                      case 0:
                        goto label_1;
                      case 1:
                        num2 = (int) num4 * -61435225 ^ 1524413651;
                        continue;
                      case 3:
                        flag = true;
                        num2 = (int) num4 * 1959339294 ^ 829508641;
                        continue;
                      default:
                        goto label_5;
                    }
                  }
label_5:
                  return flag;
                }), 0);
                num3 = -101935961;
                continue;
              default:
                goto label_23;
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator as IDisposable;
          if (disposable != null)
          {
label_18:
            int num3 = -1455790548;
            while (true)
            {
              int num4 = -569842406;
              uint num6;
              switch ((num6 = (uint) (num3 ^ num4)) % 4U)
              {
                case 1:
                  num3 = (int) num6 * -1837417599 ^ 84534159;
                  continue;
                case 2:
                  WindowHelper.\u206F⁯​⁫‎‪‮‮⁭‪‭‮⁪‭‎‪‮⁪​⁯​‌‫‫‭⁯‍‪‭‫‏‭⁯‬‎⁪‍‭⁬‎‮(disposable);
                  num3 = (int) num6 * 1337883979 ^ 115789609;
                  continue;
                case 3:
                  goto label_18;
                default:
                  goto label_22;
              }
            }
          }
label_22:;
        }
label_23:
label_24:
        int num9 = -1566479851;
label_25:
        int num10 = -569842406;
        switch ((num5 = (uint) (num9 ^ num10)) % 3U)
        {
          case 1:
            break;
          case 2:
            goto label_24;
          default:
            goto label_28;
        }
label_26:
        num9 = -1819849192;
        goto label_25;
      }
      catch (Exception ex)
      {
      }
label_28:
      return handles;
    }

    public static void Move(IntPtr handle, Rectangle rectangle, bool repaint = true)
    {
label_1:
      int num1 = -1961231509;
      while (true)
      {
        int num2 = -1285680428;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = WindowHelper.IsMinimized(handle);
            num1 = (int) num3 * -315384170 ^ 283773186;
            continue;
          case 2:
            int num4 = !flaphx.utils.NativeMethods.IsWindow(handle) ? -1763830914 : (num4 = -1029473474);
            int num5 = (int) num3 * -1250990017;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -534462276 ^ 830055449;
            continue;
          case 5:
            WindowHelper.RestoreWindow(handle);
            num1 = (int) num3 * 1959599183 ^ -1885928568;
            continue;
          case 6:
            flaphx.utils.NativeMethods.MoveWindow(handle, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, repaint);
            num1 = -475591297;
            continue;
          case 7:
            int num6 = !flag ? 1626765689 : (num6 = 624807677);
            int num7 = (int) num3 * 92369360;
            num1 = num6 ^ num7;
            continue;
          case 8:
            num1 = (int) num3 * 1145878515 ^ -1367530269;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    internal static void RestoreWindow(IntPtr handle)
    {
      bool flag = WindowHelper.IsValid(handle);
label_1:
      int num1 = -1538866228;
      while (true)
      {
        int num2 = -245184867;
        uint num3;
        flaphx.utils.NativeMethods.WINDOWPLACEMENT lpwndpl;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * -206484969 ^ -570372531;
            continue;
          case 1:
            flaphx.utils.NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            int num4 = (lpwndpl.showCmd & 9) != 9 ? 1467793495 : (num4 = 1232741796);
            int num5 = (int) num3 * 98251438;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 1867124481 ^ -977682253;
            continue;
          case 4:
            lpwndpl.showCmd = 9;
            lpwndpl.length = Marshal.SizeOf<flaphx.utils.NativeMethods.WINDOWPLACEMENT>((M0) lpwndpl);
            flaphx.utils.NativeMethods.SetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * -1063223991 ^ 624292917;
            continue;
          case 5:
            num1 = -339252429;
            continue;
          case 6:
            num1 = (int) num3 * 602513615 ^ 1218630790;
            continue;
          case 7:
            int num6 = flag ? 1095641275 : (num6 = 1024432438);
            int num7 = (int) num3 * -1491516299;
            num1 = num6 ^ num7;
            continue;
          case 8:
            goto label_3;
          case 9:
            lpwndpl = new flaphx.utils.NativeMethods.WINDOWPLACEMENT();
            num1 = (int) num3 * 1147147454 ^ -1996491212;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    internal static void MinimizeWindow(IntPtr handle)
    {
label_1:
      int num1 = -528907798;
      while (true)
      {
        int num2 = -1228777330;
        uint num3;
        flaphx.utils.NativeMethods.WINDOWPLACEMENT lpwndpl;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * 1366905349 ^ -1464787915;
            continue;
          case 1:
            lpwndpl = new flaphx.utils.NativeMethods.WINDOWPLACEMENT();
            flaphx.utils.NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * -1393782983 ^ -1377458018;
            continue;
          case 2:
            goto label_1;
          case 3:
            flaphx.utils.NativeMethods.SetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * 932455291 ^ 926024995;
            continue;
          case 4:
            num1 = (int) num3 * -765160192 ^ -1599025101;
            continue;
          case 5:
            int num4 = (lpwndpl.showCmd & 2) != 2 ? -2052625011 : (num4 = -1754380633);
            int num5 = (int) num3 * -1124039278;
            num1 = num4 ^ num5;
            continue;
          case 6:
            lpwndpl.length = Marshal.SizeOf<flaphx.utils.NativeMethods.WINDOWPLACEMENT>((M0) lpwndpl);
            num1 = (int) num3 * -418798577 ^ 1270552899;
            continue;
          case 7:
            num1 = -224540332;
            continue;
          case 8:
            int num6 = !WindowHelper.IsValid(handle) ? -2122627340 : (num6 = -710396858);
            int num7 = (int) num3 * -1673292248;
            num1 = num6 ^ num7;
            continue;
          case 9:
            num1 = (int) num3 * 1797324148 ^ 1400687641;
            continue;
          case 10:
            goto label_3;
          case 11:
            lpwndpl.showCmd = 2;
            num1 = (int) num3 * 1688016061 ^ -495350697;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    private static bool IsMinimized(IntPtr handle)
    {
      flaphx.utils.NativeMethods.WINDOWPLACEMENT lpwndpl = new flaphx.utils.NativeMethods.WINDOWPLACEMENT();
label_1:
      int num1 = 135519427;
      bool flag1;
      while (true)
      {
        int num2 = 1392953453;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 2128573457 ^ 1987527156;
            continue;
          case 1:
            num1 = (int) num3 * -1117077089 ^ 1580172780;
            continue;
          case 2:
            num1 = 1106055321;
            continue;
          case 3:
            flag1 = true;
            num1 = (int) num3 * 1365886186 ^ 770728062;
            continue;
          case 4:
            int num4 = flag2 ? -1245748709 : (num4 = -1453915319);
            int num5 = (int) num3 * -721839068;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_1;
          case 6:
            flaphx.utils.NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            flag2 = (lpwndpl.showCmd & 2) == 2;
            num1 = (int) num3 * -2065231954 ^ -282846186;
            continue;
          case 8:
            flag1 = false;
            num1 = (int) num3 * 1920045801 ^ 444805336;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag1;
    }

    public static bool IsValid(IntPtr handle)
    {
      bool flag1 = flaphx.utils.NativeMethods.IsWindow(handle);
label_1:
      int num1 = -1938069880;
      bool flag2;
      while (true)
      {
        int num2 = -1292266387;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            flag2 = true;
            num1 = (int) num3 * -1218376370 ^ -432643293;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num4 = flag1 ? 156628252 : (num4 = 1081122688);
            int num5 = (int) num3 * -1091560024;
            num1 = num4 ^ num5;
            continue;
          case 4:
            flag2 = false;
            num1 = -1547040387;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return flag2;
    }

    public static flaphx.utils.NativeMethods.WINDOWPLACEMENT GetPlacement(IntPtr handle)
    {
label_1:
      int num1 = 1241070434;
      flaphx.utils.NativeMethods.WINDOWPLACEMENT windowplacement;
      while (true)
      {
        int num2 = 254601423;
        uint num3;
        flaphx.utils.NativeMethods.WINDOWPLACEMENT lpwndpl;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            lpwndpl = new flaphx.utils.NativeMethods.WINDOWPLACEMENT();
            num1 = (int) num3 * -1388149092 ^ -667198481;
            continue;
          case 2:
            windowplacement = lpwndpl;
            num1 = (int) num3 * 1926104530 ^ 1900825246;
            continue;
          case 3:
            num1 = (int) num3 * 1032104335 ^ -1003229291;
            continue;
          case 4:
            lpwndpl.length = Marshal.SizeOf<flaphx.utils.NativeMethods.WINDOWPLACEMENT>((M0) lpwndpl);
            num1 = (int) num3 * 1622858270 ^ 828506426;
            continue;
          case 6:
            flaphx.utils.NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * 1410430983 ^ -214429012;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return windowplacement;
    }

    public static int SetWindowLong(IntPtr windowHandle, flaphx.utils.NativeMethods.GWLParameter nIndex, int dwNewLong)
    {
label_1:
      int num1 = 1567307218;
      int num2;
      while (true)
      {
        int num3 = 1136169693;
        uint num4;
        bool flag;
        switch ((num4 = (uint) (num1 ^ num3)) % 9U)
        {
          case 0:
            num2 = (int) flaphx.utils.NativeMethods.SetWindowLongPtr64(windowHandle, nIndex, new IntPtr(dwNewLong));
            num1 = (int) num4 * -1827275860 ^ 1104248599;
            continue;
          case 2:
            int num5 = !flag ? 82138495 : (num5 = 1624481950);
            int num6 = (int) num4 * 2105469143;
            num1 = num5 ^ num6;
            continue;
          case 3:
            flag = IntPtr.Size == 8;
            num1 = (int) num4 * -1501804751 ^ 69567746;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num4 * 1724607691 ^ 1526960543;
            continue;
          case 6:
            num1 = (int) num4 * 1670865029 ^ 162254460;
            continue;
          case 7:
            num2 = flaphx.utils.NativeMethods.SetWindowLong32(windowHandle, nIndex, dwNewLong);
            num1 = 1226916054;
            continue;
          case 8:
            num1 = (int) num4 * 240814315 ^ 1416672337;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return num2;
    }

    public static Rectangle GetScreenPlacement(Screen screen, ScreenPlacement horizontal, ScreenPlacement vertical)
    {
label_1:
      int num1 = 2090086716;
      Rectangle rectangle1;
      while (true)
      {
        int num2 = 1940639624;
        uint num3;
        bool flag;
        Point location;
        Rectangle rectangle2;
        Size size;
        switch ((num3 = (uint) (num1 ^ num2)) % 123U)
        {
          case 0:
            num1 = (int) num3 * 2013066641 ^ -268177836;
            continue;
          case 2:
            num1 = (int) num3 * -918295348 ^ 2115433249;
            continue;
          case 3:
            num1 = (int) num3 * 1065228997 ^ -2142849223;
            continue;
          case 4:
label_20:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local1 = @size;
            rectangle2 = screen.WorkingArea;
            int num4 = rectangle2.Height / 3;
            // ISSUE: explicit reference operation
            (^local1).Height = num4;
            num1 = 1588678863;
            continue;
          case 5:
            num1 = (int) num3 * 372776774 ^ -2038389274;
            continue;
          case 6:
            num1 = (int) num3 * -1290767696 ^ -501285466;
            continue;
          case 7:
            num1 = (int) num3 * 1298809891 ^ 1294263952;
            continue;
          case 8:
label_34:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local2 = @size;
            rectangle2 = screen.WorkingArea;
            int num5 = rectangle2.Height / 2;
            // ISSUE: explicit reference operation
            (^local2).Height = num5;
            num1 = 1880169064;
            continue;
          case 9:
          case 55:
          case 75:
label_38:
            int num6;
            num1 = num6 = flag ? 1945364874 : (num6 = 1842299274);
            continue;
          case 10:
            goto label_1;
          case 11:
label_57:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local3 = @size;
            rectangle2 = screen.WorkingArea;
            int num7 = rectangle2.Height / 3;
            // ISSUE: explicit reference operation
            (^local3).Height = num7;
            num1 = 1834382124;
            continue;
          case 12:
            flag = true;
            num1 = (int) num3 * -1200291991 ^ 1452639337;
            continue;
          case 13:
            num1 = (int) num3 * 1845675969 ^ -2102005612;
            continue;
          case 14:
            num1 = (int) num3 * 914121709 ^ 1935888858;
            continue;
          case 15:
label_27:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local4 = @size;
            rectangle2 = screen.WorkingArea;
            int num8 = rectangle2.Width / 3;
            // ISSUE: explicit reference operation
            (^local4).Width = num8;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local5 = @location;
            rectangle2 = screen.WorkingArea;
            int num9 = rectangle2.X + size.Width;
            // ISSUE: explicit reference operation
            (^local5).X = num9;
            num1 = 542881707;
            continue;
          case 16:
label_88:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local6 = @size;
            rectangle2 = screen.WorkingArea;
            int num10 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local6).Width = num10;
            num1 = 1352833231;
            continue;
          case 17:
            num1 = (int) num3 * 14062023 ^ 212764361;
            continue;
          case 18:
            num1 = (int) num3 * -1895780266 ^ 621132354;
            continue;
          case 19:
            flag = true;
            num1 = (int) num3 * 1169900761 ^ -931718412;
            continue;
          case 20:
            flag = true;
            num1 = (int) num3 * -60245631 ^ -874404939;
            continue;
          case 21:
            num1 = (int) num3 * -1458267374 ^ -693507975;
            continue;
          case 22:
label_111:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local7 = @size;
            rectangle2 = screen.WorkingArea;
            int num11 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local7).Width = num11;
            num1 = 959286658;
            continue;
          case 23:
label_49:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local8 = @size;
            rectangle2 = screen.WorkingArea;
            int num12 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local8).Height = num12;
            num1 = 2079600010;
            continue;
          case 24:
            num1 = (int) num3 * 426554425 ^ -1390436401;
            continue;
          case 25:
label_44:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local9 = @size;
            rectangle2 = screen.WorkingArea;
            int width = rectangle2.Width;
            // ISSUE: explicit reference operation
            (^local9).Width = width;
            num1 = 1171921912;
            continue;
          case 26:
            num1 = (int) num3 * -555708527 ^ -1716500856;
            continue;
          case 27:
label_116:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local10 = @size;
            rectangle2 = screen.WorkingArea;
            int num13 = rectangle2.Height / 2;
            // ISSUE: explicit reference operation
            (^local10).Height = num13;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local11 = @location;
            rectangle2 = screen.WorkingArea;
            int num14 = rectangle2.Y + size.Height / 4;
            // ISSUE: explicit reference operation
            (^local11).Y = num14;
            num1 = 562876843;
            continue;
          case 28:
            flag = true;
            num1 = (int) num3 * 1736518576 ^ -725399584;
            continue;
          case 29:
            num1 = (int) num3 * 1818318505 ^ 597364354;
            continue;
          case 30:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local12 = @location;
            rectangle2 = screen.WorkingArea;
            int y1 = rectangle2.Y;
            rectangle2 = screen.WorkingArea;
            int num15 = rectangle2.Height / 3;
            int num16 = y1 + num15;
            // ISSUE: explicit reference operation
            (^local12).Y = num16;
            flag = true;
            num1 = (int) num3 * -833695222 ^ 904361949;
            continue;
          case 31:
            flag = true;
            num1 = (int) num3 * -1308720116 ^ 952892920;
            continue;
          case 32:
            num1 = (int) num3 * -158770156 ^ 824665894;
            continue;
          case 33:
label_106:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local13 = @size;
            rectangle2 = screen.WorkingArea;
            int num17 = rectangle2.Width / 3 * 2;
            // ISSUE: explicit reference operation
            (^local13).Width = num17;
            num1 = 1134772216;
            continue;
          case 34:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local14 = @location;
            rectangle2 = screen.WorkingArea;
            int x1 = rectangle2.X;
            rectangle2 = screen.WorkingArea;
            int num18 = rectangle2.Width / 4;
            int num19 = x1 + num18;
            // ISSUE: explicit reference operation
            (^local14).X = num19;
            num1 = (int) num3 * 645971251 ^ 550718358;
            continue;
          case 35:
            flag = false;
            num1 = (int) num3 * 139319221 ^ -335346214;
            continue;
          case 36:
            num1 = (int) num3 * 2090572569 ^ 469113223;
            continue;
          case 37:
            num1 = (int) num3 * 282947916 ^ -1432027624;
            continue;
          case 38:
            flag = true;
            num1 = (int) num3 * 878389180 ^ 1741714910;
            continue;
          case 39:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local15 = @location;
            rectangle2 = screen.WorkingArea;
            int x2 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local15).X = x2;
            flag = true;
            num1 = (int) num3 * -1793207841 ^ -93940277;
            continue;
          case 40:
            rectangle1 = Rectangle.Empty;
            num1 = (int) num3 * 107331588 ^ -1454237094;
            continue;
          case 41:
            num1 = (int) num3 * 314613816 ^ -335155163;
            continue;
          case 42:
label_62:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local16 = @size;
            rectangle2 = screen.WorkingArea;
            int num20 = rectangle2.Height / 3 * 2;
            // ISSUE: explicit reference operation
            (^local16).Height = num20;
            num1 = 200940021;
            continue;
          case 43:
          case 62:
          case 70:
label_18:
            switch (vertical)
            {
              case ScreenPlacement.Undefined:
                goto label_38;
              case ScreenPlacement.FirstHalf:
                goto label_11;
              case ScreenPlacement.SecondHalf:
                goto label_34;
              case ScreenPlacement.FirstThird:
                goto label_75;
              case ScreenPlacement.FirstTwoThirds:
                goto label_62;
              case ScreenPlacement.SecondThird:
                goto label_57;
              case ScreenPlacement.SecondTwoThirds:
                goto label_48;
              case ScreenPlacement.ThirdThird:
                goto label_20;
              case ScreenPlacement.FirstQuarter:
                goto label_92;
              case ScreenPlacement.SecondQuarter:
                goto label_8;
              case ScreenPlacement.SecondTwoQuarters:
                goto label_116;
              case ScreenPlacement.ThirdQuarter:
                goto label_49;
              case ScreenPlacement.FourthQuarter:
                goto label_31;
              case ScreenPlacement.Full:
                goto label_33;
              default:
                num1 = 71350884;
                continue;
            }
          case 44:
            num1 = (int) num3 * -936414597 ^ -1774508318;
            continue;
          case 45:
label_75:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local17 = @size;
            rectangle2 = screen.WorkingArea;
            int num21 = rectangle2.Height / 3;
            // ISSUE: explicit reference operation
            (^local17).Height = num21;
            num1 = 1375649552;
            continue;
          case 46:
label_86:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local18 = @size;
            rectangle2 = screen.WorkingArea;
            int num22 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local18).Width = num22;
            num1 = 363942205;
            continue;
          case 47:
            num1 = (int) num3 * 1231557645 ^ -868009682;
            continue;
          case 48:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local19 = @location;
            rectangle2 = screen.WorkingArea;
            int y2 = rectangle2.Y;
            rectangle2 = screen.WorkingArea;
            int num23 = rectangle2.Height / 3;
            int num24 = y2 + num23;
            // ISSUE: explicit reference operation
            (^local19).Y = num24;
            flag = true;
            num1 = (int) num3 * -726076479 ^ -713319577;
            continue;
          case 49:
            num1 = (int) num3 * 112087845 ^ -1678339565;
            continue;
          case 50:
            num1 = (int) num3 * 871532884 ^ -1085270474;
            continue;
          case 51:
            num1 = (int) num3 * 1043203717 ^ 1976503357;
            continue;
          case 52:
            flag = true;
            num1 = (int) num3 * -960058277 ^ 573192168;
            continue;
          case 53:
            flag = true;
            num1 = (int) num3 * 2102916961 ^ -19090740;
            continue;
          case 54:
label_26:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local20 = @size;
            rectangle2 = WindowHelper.\u206C⁯⁫‫⁯‏‪‌⁯‪‫⁪‎⁭‌‪‮‏⁬‭‎⁭⁭‌‬‎⁮‭‫​‪⁬‫‪‏‌‭‪‌‍‮(screen);
            int num25 = rectangle2.Width / 2;
            // ISSUE: explicit reference operation
            (^local20).Width = num25;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local21 = @location;
            rectangle2 = screen.WorkingArea;
            int x3 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local21).X = x3;
            num1 = 872111753;
            continue;
          case 56:
            flag = true;
            num1 = (int) num3 * 753494865 ^ -1757558805;
            continue;
          case 57:
            flag = true;
            num1 = (int) num3 * -1508828615 ^ -804023838;
            continue;
          case 58:
            flag = true;
            num1 = (int) num3 * 392747930 ^ 891348966;
            continue;
          case 59:
            flag = true;
            num1 = (int) num3 * 1112144630 ^ -1479953469;
            continue;
          case 60:
label_21:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local22 = @size;
            rectangle2 = screen.WorkingArea;
            int num26 = rectangle2.Width / 3 * 2;
            // ISSUE: explicit reference operation
            (^local22).Width = num26;
            num1 = 917225178;
            continue;
          case 61:
            num1 = (int) num3 * -970341029 ^ -503151862;
            continue;
          case 63:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local23 = @location;
            rectangle2 = screen.WorkingArea;
            int x4 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local23).X = x4;
            num1 = (int) num3 * 142308133 ^ 1735228371;
            continue;
          case 64:
            num1 = (int) num3 * 800373372 ^ 1275611455;
            continue;
          case 65:
label_92:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local24 = @size;
            rectangle2 = screen.WorkingArea;
            int num27 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local24).Height = num27;
            num1 = 640697438;
            continue;
          case 66:
label_8:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local25 = @size;
            rectangle2 = screen.WorkingArea;
            int num28 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local25).Height = num28;
            num1 = 61690402;
            continue;
          case 67:
            flag = true;
            num1 = (int) num3 * 244252102 ^ -842751151;
            continue;
          case 68:
label_71:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local26 = @size;
            rectangle2 = screen.WorkingArea;
            int num29 = rectangle2.Width / 2;
            // ISSUE: explicit reference operation
            (^local26).Width = num29;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local27 = @location;
            rectangle2 = screen.WorkingArea;
            int num30 = rectangle2.X + size.Width;
            // ISSUE: explicit reference operation
            (^local27).X = num30;
            num1 = 556199054;
            continue;
          case 69:
            num1 = (int) num3 * -207327935 ^ 1282860835;
            continue;
          case 71:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local28 = @location;
            rectangle2 = screen.WorkingArea;
            int num31 = rectangle2.Y + size.Height * 2;
            // ISSUE: explicit reference operation
            (^local28).Y = num31;
            num1 = (int) num3 * -154989442 ^ 1726820351;
            continue;
          case 72:
            flag = true;
            num1 = (int) num3 * -689506597 ^ -342154832;
            continue;
          case 73:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local29 = @location;
            rectangle2 = screen.WorkingArea;
            int num32 = rectangle2.Y + size.Height;
            // ISSUE: explicit reference operation
            (^local29).Y = num32;
            num1 = (int) num3 * -337326030 ^ -1424358987;
            continue;
          case 74:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local30 = @location;
            rectangle2 = screen.WorkingArea;
            int num33 = rectangle2.Y + size.Height * 3;
            // ISSUE: explicit reference operation
            (^local30).Y = num33;
            num1 = (int) num3 * 1361992709 ^ -1798822445;
            continue;
          case 76:
            num1 = (int) num3 * -1262733282 ^ -1415826556;
            continue;
          case 77:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local31 = @location;
            rectangle2 = screen.WorkingArea;
            int y3 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local31).Y = y3;
            num1 = (int) num3 * -499895476 ^ 1189648747;
            continue;
          case 78:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local32 = @location;
            rectangle2 = screen.WorkingArea;
            int x5 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local32).X = x5;
            num1 = (int) num3 * -2138016654 ^ 1894743099;
            continue;
          case 79:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local33 = @location;
            rectangle2 = screen.WorkingArea;
            int num34 = rectangle2.X + size.Width * 3;
            // ISSUE: explicit reference operation
            (^local33).X = num34;
            num1 = (int) num3 * -1302881436 ^ 294387778;
            continue;
          case 80:
            rectangle1 = new Rectangle(location, size);
            num1 = (int) num3 * -827901512 ^ 1245804252;
            continue;
          case 81:
label_53:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local34 = @size;
            rectangle2 = screen.WorkingArea;
            int num35 = rectangle2.Width / 3;
            // ISSUE: explicit reference operation
            (^local34).Width = num35;
            num1 = 1056550610;
            continue;
          case 82:
            num1 = (int) num3 * -1907970791 ^ -654258305;
            continue;
          case 83:
label_31:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local35 = @size;
            rectangle2 = screen.WorkingArea;
            int num36 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local35).Height = num36;
            num1 = 9739344;
            continue;
          case 84:
            num1 = (int) num3 * -239741258 ^ 964669679;
            continue;
          case 85:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local36 = @location;
            rectangle2 = screen.WorkingArea;
            int num37 = rectangle2.Y + size.Height * 2;
            // ISSUE: explicit reference operation
            (^local36).Y = num37;
            num1 = (int) num3 * 1887238384 ^ -1874352870;
            continue;
          case 86:
            num1 = (int) num3 * 123050631 ^ 875779613;
            continue;
          case 87:
            num1 = (int) num3 * 1404455950 ^ 938928634;
            continue;
          case 88:
            flag = true;
            num1 = (int) num3 * -1079805923 ^ 1690159426;
            continue;
          case 89:
            num1 = (int) num3 * 438460088 ^ -105126812;
            continue;
          case 90:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local37 = @location;
            rectangle2 = screen.WorkingArea;
            int num38 = rectangle2.X + size.Width * 2;
            // ISSUE: explicit reference operation
            (^local37).X = num38;
            num1 = (int) num3 * -1135661179 ^ 699313094;
            continue;
          case 91:
label_91:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local38 = @size;
            rectangle2 = screen.WorkingArea;
            int num39 = rectangle2.Width / 2;
            // ISSUE: explicit reference operation
            (^local38).Width = num39;
            num1 = 2068460421;
            continue;
          case 92:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local39 = @location;
            rectangle2 = screen.WorkingArea;
            int num40 = rectangle2.Y + size.Height;
            // ISSUE: explicit reference operation
            (^local39).Y = num40;
            num1 = (int) num3 * -2129209954 ^ 1104361052;
            continue;
          case 93:
            num1 = (int) num3 * 471024892 ^ -1816393696;
            continue;
          case 94:
            num1 = 1568251106;
            continue;
          case 95:
            num1 = (int) num3 * -1231720018 ^ -1190532915;
            continue;
          case 96:
            num1 = (int) num3 * 20738734 ^ -1478492409;
            continue;
          case 97:
            num1 = (int) num3 * 918638368 ^ 500571856;
            continue;
          case 98:
            num1 = (int) num3 * 19360430 ^ -1072763384;
            continue;
          case 99:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local40 = @location;
            rectangle2 = screen.WorkingArea;
            int num41 = rectangle2.X + size.Width * 2;
            // ISSUE: explicit reference operation
            (^local40).X = num41;
            num1 = (int) num3 * 2004703171 ^ -616974256;
            continue;
          case 100:
            size = new Size();
            location = new Point();
            switch (horizontal)
            {
              case ScreenPlacement.Undefined:
                goto label_18;
              case ScreenPlacement.FirstHalf:
                goto label_26;
              case ScreenPlacement.SecondHalf:
                goto label_71;
              case ScreenPlacement.FirstThird:
                goto label_53;
              case ScreenPlacement.FirstTwoThirds:
                goto label_106;
              case ScreenPlacement.SecondThird:
                goto label_27;
              case ScreenPlacement.SecondTwoThirds:
                goto label_21;
              case ScreenPlacement.ThirdThird:
                goto label_119;
              case ScreenPlacement.FirstQuarter:
                goto label_88;
              case ScreenPlacement.SecondQuarter:
                goto label_111;
              case ScreenPlacement.SecondTwoQuarters:
                goto label_91;
              case ScreenPlacement.ThirdQuarter:
                goto label_15;
              case ScreenPlacement.FourthQuarter:
                goto label_86;
              case ScreenPlacement.Full:
                goto label_44;
              default:
                num1 = (int) num3 * -259191520 ^ 1083626889;
                continue;
            }
          case 101:
            num1 = (int) num3 * -215768501 ^ -1160494536;
            continue;
          case 102:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local41 = @location;
            rectangle2 = screen.WorkingArea;
            int x6 = rectangle2.X;
            rectangle2 = screen.WorkingArea;
            int num42 = rectangle2.Width / 3;
            int num43 = x6 + num42;
            // ISSUE: explicit reference operation
            (^local41).X = num43;
            num1 = (int) num3 * 763306541 ^ -666708824;
            continue;
          case 103:
label_33:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local42 = @size;
            rectangle2 = screen.WorkingArea;
            int height = rectangle2.Height;
            // ISSUE: explicit reference operation
            (^local42).Height = height;
            num1 = 1721259788;
            continue;
          case 104:
label_48:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local43 = @size;
            rectangle2 = screen.WorkingArea;
            int num44 = rectangle2.Height / 3 * 2;
            // ISSUE: explicit reference operation
            (^local43).Height = num44;
            num1 = 1176584395;
            continue;
          case 105:
            flag = true;
            num1 = (int) num3 * 1039277211 ^ -82984791;
            continue;
          case 106:
            num1 = (int) num3 * 375276657 ^ 1342450452;
            continue;
          case 107:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local44 = @location;
            rectangle2 = screen.WorkingArea;
            int y4 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local44).Y = y4;
            num1 = (int) num3 * -353837848 ^ -798360345;
            continue;
          case 108:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local45 = @location;
            rectangle2 = screen.WorkingArea;
            int y5 = rectangle2.Y;
            rectangle2 = screen.WorkingArea;
            int num45 = rectangle2.Height / 3;
            int num46 = y5 + num45;
            // ISSUE: explicit reference operation
            (^local45).Y = num46;
            flag = true;
            num1 = (int) num3 * 1257800016 ^ -273041118;
            continue;
          case 109:
label_119:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local46 = @size;
            rectangle2 = screen.WorkingArea;
            int num47 = rectangle2.Width / 3;
            // ISSUE: explicit reference operation
            (^local46).Width = num47;
            num1 = 1633925250;
            continue;
          case 110:
label_11:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local47 = @size;
            rectangle2 = screen.WorkingArea;
            int num48 = rectangle2.Height / 2;
            // ISSUE: explicit reference operation
            (^local47).Height = num48;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local48 = @location;
            rectangle2 = screen.WorkingArea;
            int y6 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local48).Y = y6;
            num1 = 766506216;
            continue;
          case 111:
            flag = true;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local49 = @location;
            rectangle2 = screen.WorkingArea;
            int y7 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local49).Y = y7;
            num1 = (int) num3 * 1115354879 ^ -1033492791;
            continue;
          case 112:
            num1 = (int) num3 * -1948965398 ^ -505705887;
            continue;
          case 113:
            flag = true;
            num1 = (int) num3 * 1316645208 ^ -1168541330;
            continue;
          case 114:
            num1 = (int) num3 * -219899206 ^ 1877570176;
            continue;
          case 115:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local50 = @location;
            rectangle2 = screen.WorkingArea;
            int x7 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local50).X = x7;
            flag = true;
            num1 = (int) num3 * -823218920 ^ -105718761;
            continue;
          case 116:
            num1 = (int) num3 * -1763152644 ^ -1409421752;
            continue;
          case 117:
            flag = true;
            num1 = (int) num3 * 1867336291 ^ 2037269273;
            continue;
          case 118:
            flag = true;
            num1 = (int) num3 * -606253411 ^ 2071154789;
            continue;
          case 119:
            num1 = (int) num3 * 1285855204 ^ 1271374008;
            continue;
          case 120:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Point& local51 = @location;
            rectangle2 = screen.WorkingArea;
            int num49 = rectangle2.X + size.Width;
            // ISSUE: explicit reference operation
            (^local51).X = num49;
            flag = true;
            num1 = (int) num3 * 1626272699 ^ 558369069;
            continue;
          case 121:
label_15:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local52 = @size;
            rectangle2 = screen.WorkingArea;
            int num50 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local52).Width = num50;
            num1 = 774214341;
            continue;
          case 122:
            flag = true;
            num1 = (int) num3 * 26814002 ^ 1063733252;
            continue;
          default:
            goto label_122;
        }
      }
label_122:
      return rectangle1;
    }

    internal static IntPtr GetProcessWindow(string appName)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowHelper.\u003C\u003Ec__DisplayClass21_0 cDisplayClass210 = new WindowHelper.\u003C\u003Ec__DisplayClass21_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass210.appName = appName;
      try
      {
label_2:
        int num1 = -2000390780;
        Process process;
        while (true)
        {
          int num2 = -393642263;
          uint num3;
          List<Process> list;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1378319354 ^ 1711759620;
              continue;
            case 2:
              // ISSUE: method pointer
              process = (Process) Enumerable.FirstOrDefault<Process>((IEnumerable<M0>) list, (Func<M0, bool>) new Func<Process, bool>((object) cDisplayClass210, __methodptr(\u003CGetProcessWindow\u003Eb__0)));
              int num4 = process != null ? 1264301421 : (num4 = 494827272);
              int num5 = (int) num3 * -2102586453;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_2;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass210.appName = WindowHelper.\u206B‪‌‏⁫‏‍‍⁪‍⁮‍‫‮‫‭⁮⁮‫‭‬⁭​⁭‏‎‪‮⁯‮⁫‌⁯⁪‌‎⁯‬‫‮(cDisplayClass210.appName);
              list = ((IEnumerable<Process>) WindowHelper.\u206E‌‬⁯‪⁭‬⁪⁯‫⁮​⁭⁭‪‍⁬‫⁮‬⁯‮‌‮‮⁪‍⁫‭‌‍⁭‭⁪​⁭⁯⁮⁯⁬‮()).ToList<Process>();
              num1 = (int) num3 * -347818399 ^ -480099320;
              continue;
            default:
              goto label_12;
          }
        }
label_5:
        return WindowHelper.\u202D‫‌⁫⁬‌‏‬‮⁫‭‬‪‬⁪​‏⁪‍⁬‍⁫‭‫⁮⁬⁮‌‌‮‬‪‏‮‏‌‬‭‫⁪‮(process);
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -1549694634;
        while (true)
        {
          int num2 = -393642263;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              num1 = (int) num3 * -675776928 ^ 2130526131;
              continue;
            default:
              goto label_12;
          }
        }
      }
label_12:
      return IntPtr.Zero;
    }

    public static void ForceForeground(IntPtr handle)
    {
label_1:
      int num1 = -1557827290;
      while (true)
      {
        int num2 = -1652874084;
        uint num3;
        IntPtr windowThreadProcessId;
        IntPtr idAttachTo;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = -1452885234;
            continue;
          case 2:
            flaphx.utils.NativeMethods.AttachThreadInput(new IntPtr(6), idAttachTo, 1);
            num1 = (int) num3 * 2075202349 ^ -2137936913;
            continue;
          case 3:
            num1 = (int) num3 * 1503306607 ^ -1643776959;
            continue;
          case 4:
            flaphx.utils.NativeMethods.AttachThreadInput(windowThreadProcessId, idAttachTo, 0);
            num1 = (int) num3 * 752241435 ^ 667100451;
            continue;
          case 5:
            flaphx.utils.NativeMethods.BringWindowToTop(handle);
            flaphx.utils.NativeMethods.ShowWindow(handle, WindowShowStyle.Show);
            num1 = (int) num3 * 761092929 ^ 1629729729;
            continue;
          case 6:
            windowThreadProcessId = flaphx.utils.NativeMethods.GetWindowThreadProcessId(flaphx.utils.NativeMethods.GetForegroundWindow(), IntPtr.Zero);
            idAttachTo = new IntPtr((long) flaphx.utils.NativeMethods.GetCurrentThreadId());
            num1 = (int) num3 * 193979606 ^ -1278248591;
            continue;
          case 7:
            flag = windowThreadProcessId != idAttachTo;
            num1 = (int) num3 * -389469857 ^ 1132284102;
            continue;
          case 8:
            flaphx.utils.NativeMethods.ShowWindow(handle, WindowShowStyle.Show);
            num1 = (int) num3 * -660601414 ^ 1031260849;
            continue;
          case 9:
            num1 = (int) num3 * -1148094360 ^ -1769062938;
            continue;
          case 10:
            flaphx.utils.NativeMethods.BringWindowToTop(handle);
            num1 = (int) num3 * -732011736 ^ -475933542;
            continue;
          case 11:
            num1 = (int) num3 * 1373338701 ^ 1985924981;
            continue;
          case 12:
            goto label_1;
          case 13:
            int num4 = !flag ? -2092156447 : (num4 = -217379449);
            int num5 = (int) num3 * -1101348884;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
    {
label_1:
      int num1 = 5700897;
      IntPtr num2;
      while (true)
      {
        int num3 = 278834566;
        uint num4;
        bool flag;
        switch ((num4 = (uint) (num1 ^ num3)) % 8U)
        {
          case 0:
            num1 = (int) num4 * 2030129670 ^ 1478428813;
            continue;
          case 1:
            num1 = (int) num4 * -1104950496 ^ -1361229941;
            continue;
          case 2:
            goto label_1;
          case 3:
            num2 = flaphx.utils.NativeMethods.SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            num1 = (int) num4 * 2014412103 ^ -1273877002;
            continue;
          case 4:
            int num5 = flag ? 633544758 : (num5 = 2019587712);
            int num6 = (int) num4 * 392586738;
            num1 = num5 ^ num6;
            continue;
          case 6:
            num2 = new IntPtr(flaphx.utils.NativeMethods.SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
            num1 = 1993405415;
            continue;
          case 7:
            flag = IntPtr.Size == 8;
            num1 = (int) num4 * -1324572647 ^ 1991413941;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return num2;
    }

    internal static unsafe void GetWindowItemInformation(IntPtr handle, out string itemType, out string[] itemStrings, out string[] itemStyles, out IntPtr itemHandle)
    {
      string str = string.Empty;
      string[] strArray1 = new string[0];
label_1:
      int num1 = 1025642236;
      while (true)
      {
        int num2 = 1955568959;
        uint num3;
        string empty;
        flaphx.utils.TBBUTTONINFO* tbbuttoninfoPtr;
        bool flag1;
        IntPtr num4;
        IntPtr num5;
        bool flag2;
        IntPtr hMenu;
        uint uIDItem;
        StringBuilder lpString;
        int length;
        int lpNumberOfBytesWritten;
        bool flag3;
        string[] strArray2;
        bool flag4;
        byte* numPtr;
        flaphx.utils.TBBUTTON* tbbuttonPtr;
        long int64;
        int index;
        int num6;
        IntPtr lpBuffer;
        IntPtr lpNumberOfBytesRead;
        bool flag5;
        bool flag6;
        uint lpdwProcessId;
        IntPtr num7;
        int num8;
        switch ((num3 = (uint) (num1 ^ num2)) % 78U)
        {
          case 0:
            User32.GetWindowThreadProcessId(handle, out lpdwProcessId);
            num1 = (int) num3 * -1407877042 ^ -263818401;
            continue;
          case 1:
            num1 = 189272647;
            continue;
          case 2:
            num1 = (int) num3 * 76707393 ^ 1828655082;
            continue;
          case 3:
            flag4 = (long) uIDItem < (long) lpNumberOfBytesWritten;
            num1 = 1989381792;
            continue;
          case 4:
            lpString = new StringBuilder(128);
            num1 = (int) num3 * -602030239 ^ -1784241503;
            continue;
          case 5:
            tbbuttonPtr = (flaphx.utils.TBBUTTON*) numPtr;
            num1 = (int) num3 * -1945484102 ^ -1591027699;
            continue;
          case 6:
            int64 = User32.SendMessage(handle, 1087U, (IntPtr) num6, num5).ToInt64();
            num1 = (int) num3 * 1047164914 ^ -1076431301;
            continue;
          case 7:
            num1 = (int) num3 * -326495607 ^ -936285624;
            continue;
          case 8:
            strArray2 = new string[lpNumberOfBytesWritten];
            uIDItem = 0U;
            num1 = (int) num3 * -1625811718 ^ 912051299;
            continue;
          case 9:
            num1 = (int) num3 * 2133197203 ^ 2056682234;
            continue;
          case 10:
            num4 = Kernel32.OpenProcess(2035711U, false, lpdwProcessId);
            num1 = (int) num3 * 217984404 ^ -1285722953;
            continue;
          case 11:
            int num9;
            num1 = num9 = ((uint) tbbuttoninfoPtr->fsStyle & 128U) > 0U ? 2072207966 : (num9 = 2044820428);
            continue;
          case 12:
            empty += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3333634416U);
            num1 = (int) num3 * 1601133140 ^ 811007530;
            continue;
          case 13:
            int num10 = !flag4 ? -815115447 : (num10 = -1511671356);
            int num11 = (int) num3 * 223869979;
            num1 = num10 ^ num11;
            continue;
          case 14:
            strArray2[index] = empty.Substring(2);
            num1 = (int) num3 * -1686941314 ^ -727400096;
            continue;
          case 15:
            lpNumberOfBytesWritten = (int) User32.SendMessage(handle, 1047U, (IntPtr) index, num5);
            num1 = 1410189626;
            continue;
          case 16:
            itemHandle = num7;
            num1 = (int) num3 * -406370603 ^ -149593645;
            continue;
          case 17:
            int num12;
            num1 = num12 = empty.Length > 2 ? 1078055873 : (num12 = 1577582180);
            continue;
          case 18:
            strArray1 = new string[length];
            num1 = (int) num3 * -1686458772 ^ -1871650078;
            continue;
          case 19:
            num1 = (int) num3 * 1156522907 ^ -1994595023;
            continue;
          case 20:
            int num13 = flag1 ? 1444159935 : (num13 = 1325969976);
            int num14 = (int) num3 * -920216701;
            num1 = num13 ^ num14;
            continue;
          case 21:
            flag5 = Kernel32.WriteProcessMemory(num4, num5, lpBuffer, (uint) sizeof (flaphx.utils.TBBUTTONINFO), out lpNumberOfBytesWritten);
            num1 = (int) num3 * 1256498946 ^ -1679745755;
            continue;
          case 22:
            empty += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1567693563U);
            num1 = (int) num3 * -1839602235 ^ 1746962068;
            continue;
          case 23:
            goto label_1;
          case 24:
            num1 = (int) num3 * -1370115893 ^ 736156222;
            continue;
          case 25:
            empty += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3586962582U);
            num1 = (int) num3 * 948469583 ^ -2099603933;
            continue;
          case 26:
            itemStrings = strArray1;
            num1 = (int) num3 * -1230895889 ^ -1723840635;
            continue;
          case 27:
            tbbuttoninfoPtr->dwMask = 72U;
            num1 = (int) num3 * 561900710 ^ -285491858;
            continue;
          case 28:
            itemType = str;
            num1 = 1575734904;
            continue;
          case 29:
            empty = string.Empty;
            num1 = (int) num3 * 673912939 ^ -1201480371;
            continue;
          case 30:
            int num15 = int64 == -1L ? -397056368 : (num15 = -1628248824);
            int num16 = (int) num3 * -987086737;
            num1 = num15 ^ num16;
            continue;
          case 31:
            flag3 = index < length;
            num1 = 495663797;
            continue;
          case 32:
            tbbuttoninfoPtr->cbSize = (uint) Marshal.SizeOf(typeof (flaphx.utils.TBBUTTONINFO));
            num1 = (int) num3 * -1606398752 ^ -559321750;
            continue;
          case 33:
            int num17;
            num1 = num17 = ((uint) tbbuttoninfoPtr->fsStyle & 16U) > 0U ? 72204109 : (num17 = 66518318);
            continue;
          case 34:
            hMenu = User32.SendMessage(handle, 481U, IntPtr.Zero, IntPtr.Zero);
            int num18 = User32.IsMenu(hMenu) ? -1670388378 : (num18 = -491693494);
            int num19 = (int) num3 * 733604915;
            num1 = num18 ^ num19;
            continue;
          case 35:
            flag6 = lpNumberOfBytesWritten < 4096;
            num1 = 511111068;
            continue;
          case 36:
            numPtr[lpNumberOfBytesWritten] = (byte) 0;
            ++lpNumberOfBytesWritten;
            num1 = 1805471024;
            continue;
          case 37:
            flag5 = Kernel32.ReadProcessMemory(num4, num5, lpBuffer, (uint) sizeof (flaphx.utils.TBBUTTON), lpNumberOfBytesRead);
            num1 = 1456601320;
            continue;
          case 38:
            num7 = IntPtr.Zero;
            num1 = (int) num3 * 797833123 ^ -1442802207;
            continue;
          case 39:
            flag2 = length > 0;
            num1 = (int) num3 * -1789895909 ^ -1892972853;
            continue;
          case 40:
            int menuString = (int) User32.GetMenuString(hMenu, uIDItem, lpString, lpString.Capacity, 1024U);
            num1 = (int) num3 * 949657127 ^ -634454306;
            continue;
          case 41:
            num1 = 1445275108;
            continue;
          case 42:
            int num20 = !flag3 ? 1215226923 : (num20 = 1632685038);
            int num21 = (int) num3 * -194505267;
            num1 = num20 ^ num21;
            continue;
          case 43:
            lpNumberOfBytesRead = new IntPtr(num8);
            num1 = (int) num3 * -261350630 ^ 114572355;
            continue;
          case 44:
            num1 = (int) num3 * -2033256386 ^ 1108459679;
            continue;
          case 45:
            int num22 = ((uint) tbbuttoninfoPtr->fsStyle & 1U) > 0U ? -25323807 : (num22 = -2016818843);
            int num23 = (int) num3 * 270094472;
            num1 = num22 ^ num23;
            continue;
          case 46:
            length = (int) User32.SendMessage(handle, 1048U, 0U, 0U);
            num1 = (int) num3 * 1458848867 ^ 1135401006;
            continue;
          case 47:
            strArray2[(int) uIDItem] = lpString.ToString();
            num1 = (int) num3 * 330490600 ^ 430557870;
            continue;
          case 48:
            Kernel32.VirtualFreeEx(num4, num5, UIntPtr.Zero, 32768U);
            num1 = (int) num3 * -2004353955 ^ 1971154347;
            continue;
          case 49:
            int num24 = !flag2 ? -159308805 : (num24 = -1952362072);
            int num25 = (int) num3 * -1002689392;
            num1 = num24 ^ num25;
            continue;
          case 50:
            goto label_3;
          case 51:
            int num26 = lpNumberOfBytesWritten == -1 ? -37337410 : (num26 = -2000839990);
            int num27 = (int) num3 * 1107984601;
            num1 = num26 ^ num27;
            continue;
          case 52:
            num1 = 715699817;
            continue;
          case 53:
            int num28 = !flag6 ? 597382919 : (num28 = 178801679);
            int num29 = (int) num3 * -294058736;
            num1 = num28 ^ num29;
            continue;
          case 54:
            flag1 = ((uint) tbbuttoninfoPtr->fsStyle & 8U) > 0U;
            num1 = 1545648865;
            continue;
          case 55:
            lpdwProcessId = 0U;
            num1 = (int) num3 * -247132477 ^ -2077657714;
            continue;
          case 56:
            flag5 = Kernel32.ReadProcessMemory(num4, num5, lpBuffer, 4096U, lpNumberOfBytesRead);
            num1 = (int) num3 * -557882599 ^ 532284684;
            continue;
          case 57:
            strArray1[index] = Marshal.PtrToStringUni((IntPtr) ((void*) numPtr), lpNumberOfBytesWritten);
            num1 = (int) num3 * 919248673 ^ -1261432132;
            continue;
          case 58:
            numPtr = stackalloc byte[4096];
            lpBuffer = new IntPtr((void*) numPtr);
            num8 = 0;
            num1 = (int) num3 * 639332766 ^ -1775990084;
            continue;
          case 59:
            num1 = (int) num3 * 38368559 ^ -731048779;
            continue;
          case 60:
            num1 = 332279863;
            continue;
          case 61:
            ++uIDItem;
            num1 = (int) num3 * 587742281 ^ 2099788475;
            continue;
          case 62:
            empty += \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1327079104U);
            num1 = (int) num3 * 1247966218 ^ 1489825025;
            continue;
          case 63:
            num1 = 1031869883;
            continue;
          case 64:
            ++index;
            num1 = 510368982;
            continue;
          case 65:
            int num30 = lpNumberOfBytesWritten == 0 ? -773671228 : (num30 = -1442557900);
            int num31 = (int) num3 * 1979135804;
            num1 = num30 ^ num31;
            continue;
          case 66:
            lpNumberOfBytesWritten = 0;
            num1 = 1805471024;
            continue;
          case 67:
            itemStyles = strArray2;
            num1 = (int) num3 * -888161196 ^ 213768387;
            continue;
          case 68:
            num5 = Kernel32.VirtualAllocEx(num4, IntPtr.Zero, new UIntPtr(4096U), 4096U, 4U);
            num1 = (int) num3 * -1135866420 ^ 156842698;
            continue;
          case 69:
            strArray2 = new string[0];
            num1 = (int) num3 * 508750650 ^ 686341981;
            continue;
          case 70:
            tbbuttoninfoPtr = (flaphx.utils.TBBUTTONINFO*) numPtr;
            num6 = 0;
            num1 = (int) num3 * 963226801 ^ 1914769783;
            continue;
          case 71:
            str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3044116512U);
            num7 = hMenu;
            lpNumberOfBytesWritten = (int) User32.GetMenuItemCount(hMenu);
            num1 = (int) num3 * -1592504393 ^ 1338636612;
            continue;
          case 72:
            Kernel32.CloseHandle(num4);
            num1 = (int) num3 * -833993636 ^ 564316579;
            continue;
          case 73:
            strArray2 = new string[length];
            num1 = (int) num3 * -961272657 ^ -2127576006;
            continue;
          case 74:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2092289147U);
            num1 = (int) num3 * -331123758 ^ 851847083;
            continue;
          case 75:
            num6 = tbbuttonPtr->idCommand;
            lpNumberOfBytesWritten = (int) User32.SendMessage(handle, 1099U, (IntPtr) num6, num5);
            num1 = (int) num3 * 771290205 ^ -1024636459;
            continue;
          case 76:
            index = 0;
            num1 = (int) num3 * 1838828779 ^ -621398194;
            continue;
          case 77:
            flag5 = Kernel32.ReadProcessMemory(num4, num5, lpBuffer, (uint) sizeof (flaphx.utils.TBBUTTONINFO), lpNumberOfBytesRead);
            num1 = (int) num3 * -1370050903 ^ -201196781;
            continue;
          default:
            goto label_80;
        }
      }
label_80:
      return;
label_3:;
    }

    public static IntPtr Find(string ModuleName, string MainWindowTitle)
    {
label_1:
      int num1 = -112627194;
      IntPtr num2;
      while (true)
      {
        int num3 = -1971426374;
        uint num4;
        bool flag1;
        IntPtr ZeroOnly;
        bool flag2;
        bool flag3;
        switch ((num4 = (uint) (num1 ^ num3)) % 16U)
        {
          case 0:
            flag3 = !string.IsNullOrEmpty(MainWindowTitle);
            num1 = (int) num4 * 886005105 ^ -73514463;
            continue;
          case 1:
            num1 = -2076169721;
            continue;
          case 2:
            int num5 = flag1 ? 1257767163 : (num5 = 1377980090);
            int num6 = (int) num4 * -750319244;
            num1 = num5 ^ num6;
            continue;
          case 3:
            flag1 = ZeroOnly.Equals((object) IntPtr.Zero);
            num1 = (int) num4 * 1182658661 ^ 1270650087;
            continue;
          case 4:
            int num7 = flag2 ? -49910667 : (num7 = -1284763961);
            int num8 = (int) num4 * 694535152;
            num1 = num7 ^ num8;
            continue;
          case 5:
            num1 = (int) num4 * 1030294082 ^ 1625667546;
            continue;
          case 6:
            num1 = (int) num4 * 1157545218 ^ 1635063164;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = -970270213;
            continue;
          case 9:
            num2 = new IntPtr(0);
            num1 = (int) num4 * 1408342004 ^ 1624913995;
            continue;
          case 11:
            int num9 = !flag3 ? -225594061 : (num9 = -1906848516);
            int num10 = (int) num4 * 1840431576;
            num1 = num9 ^ num10;
            continue;
          case 12:
            ZeroOnly = flaphx.utils.NativeMethods.FindWindow(ModuleName, MainWindowTitle);
            flag2 = ZeroOnly.Equals((object) IntPtr.Zero);
            num1 = (int) num4 * 661466396 ^ 975318430;
            continue;
          case 13:
            num2 = ZeroOnly;
            num1 = -191979924;
            continue;
          case 14:
            ZeroOnly = flaphx.utils.NativeMethods.FindWindowByCaption(ZeroOnly, MainWindowTitle);
            num1 = (int) num4 * -1460635104 ^ -1191225719;
            continue;
          case 15:
            num1 = (int) num4 * 1140070245 ^ -1366004239;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return num2;
    }

    public static bool IsWindowVisible(IntPtr handle)
    {
      if (!WindowHelper.IsMinimized(handle))
        goto label_6;
label_1:
      int num1 = 1114049957;
label_2:
      bool flag;
      while (true)
      {
        int num2 = 1254919095;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_6;
          case 1:
            num1 = (int) num3 * -365621840 ^ -1699931464;
            continue;
          case 2:
            num1 = (int) num3 * -689455952 ^ 1374444378;
            continue;
          case 3:
            flag = flaphx.utils.NativeMethods.IsWindowVisible(handle);
            num1 = (int) num3 * 580445660 ^ -210959578;
            continue;
          case 4:
            goto label_1;
          case 5:
            flag = false;
            num1 = (int) num3 * 1773000108 ^ 1769864705;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return flag;
label_6:
      num1 = 1922638214;
      goto label_2;
    }

    public static bool SetForegroundWindow(IntPtr handle)
    {
label_1:
      int num1 = 1511797199;
      bool flag1;
      while (true)
      {
        int num2 = 1016567585;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = 609410951;
            continue;
          case 2:
            num1 = (int) num3 * -1364279137 ^ -1089174929;
            continue;
          case 3:
            flag1 = false;
            num1 = (int) num3 * -194433620 ^ 849924640;
            continue;
          case 4:
            num1 = (int) num3 * 1825296821 ^ -640645412;
            continue;
          case 5:
            int num4 = flag2 ? 1577244665 : (num4 = 1644225904);
            int num5 = (int) num3 * 157471585;
            num1 = num4 ^ num5;
            continue;
          case 6:
            flag2 = flaphx.utils.NativeMethods.IsWindow(handle);
            num1 = (int) num3 * -1214623314 ^ 1880470632;
            continue;
          case 7:
            flag1 = flaphx.utils.NativeMethods.SetForegroundWindow(handle);
            num1 = (int) num3 * -182463696 ^ 498257477;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag1;
    }

    internal static string GetWindowStyles(IntPtr handle)
    {
      string str1 = string.Empty;
label_1:
      int num1 = -1851329958;
      string str2;
      while (true)
      {
        int num2 = -1520656359;
        uint num3;
        bool flag1;
        long int64;
        bool flag2;
        IntPtr windowLongPtr;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        bool flag8;
        bool flag9;
        bool flag10;
        switch ((num3 = (uint) (num1 ^ num2)) % 55U)
        {
          case 0:
            flag2 = ((ulong) int64 & 1048576UL) > 0UL;
            num1 = -1391707451;
            continue;
          case 1:
            int num4;
            num1 = num4 = ((ulong) int64 & 4194304UL) <= 0UL ? -2083688686 : (num4 = -1442974794);
            continue;
          case 2:
            str2 = str1;
            num1 = -1606529566;
            continue;
          case 3:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1487957778U);
            num1 = (int) num3 * -1408663424 ^ -445731071;
            continue;
          case 4:
            int num5 = flag7 ? 1884494454 : (num5 = 614423691);
            int num6 = (int) num3 * 783220437;
            num1 = num5 ^ num6;
            continue;
          case 5:
            int num7 = flag5 ? 693517584 : (num7 = 339671164);
            int num8 = (int) num3 * -1978711292;
            num1 = num7 ^ num8;
            continue;
          case 6:
            int num9;
            num1 = num9 = ((ulong) int64 & 16777216UL) <= 0UL ? -196437759 : (num9 = -1196235659);
            continue;
          case 7:
            flag8 = ((ulong) int64 & 2147483648UL) > 0UL;
            num1 = (int) num3 * 512392246 ^ -742724284;
            continue;
          case 8:
            int num10 = flag1 ? 1587691068 : (num10 = 967601564);
            int num11 = (int) num3 * 470905096;
            num1 = num10 ^ num11;
            continue;
          case 9:
            str1 += \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3359346368U);
            num1 = (int) num3 * -2004770678 ^ 1730120435;
            continue;
          case 10:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2392701228U);
            num1 = (int) num3 * 212638398 ^ -1883584363;
            continue;
          case 11:
            flag5 = ((ulong) int64 & 134217728UL) > 0UL;
            num1 = -1700479242;
            continue;
          case 12:
            int num12 = flag2 ? 232432717 : (num12 = 339204413);
            int num13 = (int) num3 * -1979003199;
            num1 = num12 ^ num13;
            continue;
          case 13:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4268761841U);
            num1 = (int) num3 * -848376534 ^ -745088696;
            continue;
          case 14:
            flag1 = ((ulong) int64 & 65536UL) > 0UL;
            num1 = -513858843;
            continue;
          case 15:
            flag7 = ((ulong) int64 & 262144UL) > 0UL;
            num1 = -424082322;
            continue;
          case 16:
            int num14 = !flag4 ? -1940880495 : (num14 = -1535191759);
            int num15 = (int) num3 * -1369984442;
            num1 = num14 ^ num15;
            continue;
          case 17:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4124002889U);
            num1 = (int) num3 * -1449614761 ^ -1395848631;
            continue;
          case 18:
            int num16 = !flag6 ? 1955219493 : (num16 = 466122045);
            int num17 = (int) num3 * -1759341349;
            num1 = num16 ^ num17;
            continue;
          case 19:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4196382365U);
            num1 = (int) num3 * 1064315179 ^ -264970515;
            continue;
          case 20:
            str1 += \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(344929063U);
            num1 = (int) num3 * -292265310 ^ -671680950;
            continue;
          case 21:
            num1 = (int) num3 * 346949165 ^ 1949780289;
            continue;
          case 22:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2320321752U);
            num1 = (int) num3 * 351770178 ^ -1904998415;
            continue;
          case 23:
            str1 += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1306886712U);
            num1 = (int) num3 * -328875708 ^ 587404788;
            continue;
          case 24:
            str1 = str1.Remove(0, 2);
            num1 = (int) num3 * 2090666954 ^ 42601023;
            continue;
          case 25:
            flag10 = ((ulong) int64 & 67108864UL) > 0UL;
            num1 = -2089049817;
            continue;
          case 26:
            int num18;
            num1 = num18 = ((ulong) int64 & 2097152UL) <= 0UL ? -2113305874 : (num18 = -346293496);
            continue;
          case 27:
            num1 = (int) num3 * 136361401 ^ 1351611344;
            continue;
          case 28:
            str1 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2683642777U);
            num1 = (int) num3 * -1792886571 ^ -1327661109;
            continue;
          case 29:
            str1 += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4062240024U);
            num1 = (int) num3 * 78251492 ^ 69590456;
            continue;
          case 30:
            flag4 = ((ulong) int64 & 65536UL) > 0UL;
            num1 = -405769752;
            continue;
          case 31:
            goto label_1;
          case 32:
            int num19;
            num1 = num19 = ((ulong) int64 & 1073741824UL) > 0UL ? -69841772 : (num19 = -2099826959);
            continue;
          case 34:
            str1 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4186178955U);
            num1 = (int) num3 * -700040882 ^ 1735045498;
            continue;
          case 35:
            int num20;
            num1 = num20 = ((ulong) int64 & 131072UL) > 0UL ? -627049374 : (num20 = -1958786684);
            continue;
          case 36:
            int num21 = !flag9 ? 1137398363 : (num21 = 359135675);
            int num22 = (int) num3 * -1561670715;
            num1 = num21 ^ num22;
            continue;
          case 37:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3762105509U);
            num1 = (int) num3 * -2049043611 ^ -561255720;
            continue;
          case 38:
            str1 += \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3713497084U);
            num1 = (int) num3 * -334184914 ^ 891555240;
            continue;
          case 39:
            int num23;
            num1 = num23 = ((ulong) int64 & 8388608UL) > 0UL ? -1177147965 : (num23 = -413297952);
            continue;
          case 40:
            int num24 = !flag3 ? 853606959 : (num24 = 402343362);
            int num25 = (int) num3 * -1068500897;
            num1 = num24 ^ num25;
            continue;
          case 41:
            str1 += \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1752598741U);
            num1 = (int) num3 * -2034049353 ^ 1901067019;
            continue;
          case 42:
            int num26;
            num1 = num26 = ((ulong) int64 & 268435456UL) > 0UL ? -1102061013 : (num26 = -1554695838);
            continue;
          case 43:
            str1 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3116495988U);
            num1 = (int) num3 * -1289051677 ^ 259612603;
            continue;
          case 44:
            int num27 = !flag8 ? 920157129 : (num27 = 2026073087);
            int num28 = (int) num3 * 2120831424;
            num1 = num27 ^ num28;
            continue;
          case 45:
            int num29 = !flag10 ? -60051432 : (num29 = -1724308634);
            int num30 = (int) num3 * -1738960602;
            num1 = num29 ^ num30;
            continue;
          case 46:
            str1 += \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3069374250U);
            num1 = (int) num3 * -1871928570 ^ -65049618;
            continue;
          case 47:
            flag6 = ((ulong) int64 & 536870912UL) > 0UL;
            num1 = -1813591012;
            continue;
          case 48:
            str1 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4284497102U);
            num1 = -2058867471;
            continue;
          case 49:
            int64 = windowLongPtr.ToInt64();
            flag3 = (ulong) int64 > 0UL;
            num1 = (int) num3 * 311053289 ^ -612464287;
            continue;
          case 50:
            flag9 = ((ulong) int64 & 524288UL) > 0UL;
            num1 = -1225316665;
            continue;
          case 51:
            windowLongPtr = User32.GetWindowLongPtr(handle, -16);
            num1 = (int) num3 * 859811896 ^ -1845293303;
            continue;
          case 52:
            str1 += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(549693281U);
            num1 = (int) num3 * -1301162153 ^ 1441399286;
            continue;
          case 53:
            int num31;
            num1 = num31 = ((ulong) int64 & 131072UL) > 0UL ? -232602246 : (num31 = -1159712650);
            continue;
          case 54:
            int num32;
            num1 = num32 = ((ulong) int64 & 33554432UL) > 0UL ? -394863911 : (num32 = -795848972);
            continue;
          default:
            goto label_56;
        }
      }
label_56:
      return str2;
    }

    internal static string GetWindowExtendedStyles(IntPtr handle)
    {
      string str1 = string.Empty;
label_1:
      int num1 = 393653643;
      string str2;
      while (true)
      {
        int num2 = 493922106;
        uint num3;
        int windowLongPtr;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        bool flag8;
        switch ((num3 = (uint) (num1 ^ num2)) % 62U)
        {
          case 0:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2526529485U));
            num1 = (int) num3 * -1543936776 ^ 1142501004;
            continue;
          case 1:
            flag5 = ((ulong) windowLongPtr & 8192UL) > 0UL;
            num1 = 297829907;
            continue;
          case 2:
            str1 = WindowHelper.\u202E‭‮⁬‪‎‫⁬‮‮⁭⁪‌‪⁭‏⁫⁭⁪‌‬‍‏⁬‭‍‍‬​⁮‍⁭‫⁪‍⁭‎​‪‎‮(str1, 0, 2);
            num1 = 1743892453;
            continue;
          case 3:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(872080214U));
            num1 = (int) num3 * 837863348 ^ -699833274;
            continue;
          case 4:
            int num4;
            num1 = num4 = ((ulong) windowLongPtr & 256UL) > 0UL ? 1635442817 : (num4 = 897614586);
            continue;
          case 5:
            int num5;
            num1 = num5 = ((ulong) windowLongPtr & 0UL) > 0UL ? 650564273 : (num5 = 796067005);
            continue;
          case 6:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(599829185U));
            num1 = (int) num3 * 581465837 ^ 1482639207;
            continue;
          case 7:
            int num6 = flag6 ? 1691830505 : (num6 = 273877542);
            int num7 = (int) num3 * -2088223840;
            num1 = num6 ^ num7;
            continue;
          case 9:
            int num8 = ((ulong) windowLongPtr & 1UL) > 0UL ? 1829503016 : (num8 = 221845793);
            int num9 = (int) num3 * 951659151;
            num1 = num8 ^ num9;
            continue;
          case 10:
            int num10;
            num1 = num10 = ((ulong) windowLongPtr & 262144UL) <= 0UL ? 1355926477 : (num10 = 1231428849);
            continue;
          case 11:
            int num11;
            num1 = num11 = ((ulong) windowLongPtr & 33554432UL) > 0UL ? 772943554 : (num11 = 462137036);
            continue;
          case 12:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(751934160U));
            num1 = (int) num3 * 253774713 ^ 1567347784;
            continue;
          case 13:
            flag3 = ((ulong) windowLongPtr & 65536UL) > 0UL;
            num1 = 365053596;
            continue;
          case 14:
            int num12;
            num1 = num12 = ((ulong) windowLongPtr & 32UL) > 0UL ? 1001259199 : (num12 = 1141507232);
            continue;
          case 15:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(945111708U));
            num1 = (int) num3 * -1341008630 ^ 774956927;
            continue;
          case 16:
            int num13 = flag8 ? -848097486 : (num13 = -77085134);
            int num14 = (int) num3 * 977023069;
            num1 = num13 ^ num14;
            continue;
          case 17:
            str2 = str1;
            num1 = 921277632;
            continue;
          case 18:
            int num15 = !flag1 ? 1518976604 : (num15 = 1255914478);
            int num16 = (int) num3 * -545087146;
            num1 = num15 ^ num16;
            continue;
          case 19:
            int num17;
            num1 = num17 = ((ulong) windowLongPtr & 131072UL) > 0UL ? 170964693 : (num17 = 1615069514);
            continue;
          case 20:
            int num18 = !flag2 ? -662766179 : (num18 = -786961999);
            int num19 = (int) num3 * -2141846864;
            num1 = num18 ^ num19;
            continue;
          case 21:
            flag8 = ((ulong) windowLongPtr & 1024UL) > 0UL;
            num1 = 715889342;
            continue;
          case 22:
            int num20;
            num1 = num20 = ((ulong) windowLongPtr & 4194304UL) > 0UL ? 825483404 : (num20 = 1824136923);
            continue;
          case 23:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2822169805U));
            num1 = (int) num3 * 1861360544 ^ 1416613629;
            continue;
          case 24:
            int num21;
            num1 = num21 = ((ulong) windowLongPtr & 0UL) > 0UL ? 1359005685 : (num21 = 1790520275);
            continue;
          case 25:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4042671038U));
            num1 = (int) num3 * 1832065167 ^ -1600256553;
            continue;
          case 26:
            int num22;
            num1 = num22 = ((ulong) windowLongPtr & 64UL) > 0UL ? 1001548590 : (num22 = 1161503836);
            continue;
          case 27:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(162750820U));
            num1 = (int) num3 * 163468631 ^ 792731008;
            continue;
          case 28:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2358184421U));
            num1 = (int) num3 * 428486452 ^ 2008192210;
            continue;
          case 29:
            flag7 = ((ulong) windowLongPtr & 8UL) > 0UL;
            num1 = 19218346;
            continue;
          case 30:
            flag1 = ((ulong) windowLongPtr & 4096UL) > 0UL;
            num1 = 1931868968;
            continue;
          case 31:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2093733895U));
            num1 = (int) num3 * -185161835 ^ 637025837;
            continue;
          case 32:
            int num23 = flag3 ? 1938146336 : (num23 = 993616265);
            int num24 = (int) num3 * 641126979;
            num1 = num23 ^ num24;
            continue;
          case 33:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2211318593U));
            num1 = (int) num3 * 1921196342 ^ 1932106628;
            continue;
          case 34:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3006361191U));
            num1 = (int) num3 * -1845192349 ^ 1690439934;
            continue;
          case 35:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2734924808U));
            num1 = (int) num3 * -1482619677 ^ -14760266;
            continue;
          case 36:
            flag6 = ((ulong) windowLongPtr & 16UL) > 0UL;
            num1 = 1235780253;
            continue;
          case 37:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(983012056U));
            num1 = (int) num3 * 1437149072 ^ 1413829422;
            continue;
          case 38:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(507120746U));
            num1 = (int) num3 * 1130951566 ^ 1122604591;
            continue;
          case 39:
            int num25;
            num1 = num25 = ((ulong) windowLongPtr & 16384UL) <= 0UL ? 1102431175 : (num25 = 348854177);
            continue;
          case 40:
            num1 = (int) num3 * 621062336 ^ 1984757714;
            continue;
          case 41:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3870046919U));
            num1 = (int) num3 * -1790836741 ^ -1829060921;
            continue;
          case 42:
            int num26;
            num1 = num26 = ((ulong) windowLongPtr & 128UL) <= 0UL ? 496952158 : (num26 = 1751907909);
            continue;
          case 43:
            int num27 = flag5 ? 754544388 : (num27 = 1861464612);
            int num28 = (int) num3 * -1332518107;
            num1 = num27 ^ num28;
            continue;
          case 44:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3436397867U));
            num1 = (int) num3 * 1190451618 ^ -462865164;
            continue;
          case 45:
            flag4 = ((ulong) windowLongPtr & 1048576UL) > 0UL;
            num1 = 1147439640;
            continue;
          case 46:
            int num29;
            num1 = num29 = ((ulong) windowLongPtr & 134217728UL) > 0UL ? 494780104 : (num29 = 563657320);
            continue;
          case 47:
            flag2 = ((ulong) windowLongPtr & 0UL) > 0UL;
            num1 = 1405923938;
            continue;
          case 48:
            int num30;
            num1 = num30 = ((ulong) windowLongPtr & 4UL) > 0UL ? 1208290656 : (num30 = 1104901685);
            continue;
          case 49:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4009627912U));
            num1 = (int) num3 * 289963986 ^ -583660981;
            continue;
          case 50:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3216751666U));
            num1 = (int) num3 * -850713966 ^ -935478914;
            continue;
          case 51:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1897097601U));
            num1 = (int) num3 * 105605676 ^ 1354379358;
            continue;
          case 52:
            goto label_1;
          case 53:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1403717270U));
            num1 = (int) num3 * 934670364 ^ -1805925321;
            continue;
          case 54:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2278326251U));
            num1 = (int) num3 * -1228795591 ^ -817132589;
            continue;
          case 55:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1156444373U));
            num1 = (int) num3 * 625431441 ^ 2076740170;
            continue;
          case 56:
            int num31 = !flag7 ? 853740148 : (num31 = 375529687);
            int num32 = (int) num3 * 644758486;
            num1 = num31 ^ num32;
            continue;
          case 57:
            windowLongPtr = (int) User32.GetWindowLongPtr(handle, -20);
            int num33 = (uint) windowLongPtr <= 0U ? -2087021576 : (num33 = -86154022);
            int num34 = (int) num3 * -1154364627;
            num1 = num33 ^ num34;
            continue;
          case 58:
            int num35;
            num1 = num35 = ((ulong) windowLongPtr & 512UL) > 0UL ? 643572505 : (num35 = 506572577);
            continue;
          case 59:
            str1 = WindowHelper.\u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(925675160U));
            num1 = (int) num3 * -1755135152 ^ -811547037;
            continue;
          case 60:
            int num36 = flag4 ? 168513540 : (num36 = 223201628);
            int num37 = (int) num3 * -141630281;
            num1 = num36 ^ num37;
            continue;
          case 61:
            int num38;
            num1 = num38 = ((ulong) windowLongPtr & 524288UL) <= 0UL ? 47396563 : (num38 = 1906931205);
            continue;
          default:
            goto label_63;
        }
      }
label_63:
      return str2;
    }

    public static Screen GetScreen(string name)
    {
label_1:
      int num1 = -652421884;
      Screen screen1;
      while (true)
      {
        int num2 = -1530893255;
        uint num3;
        Screen[] screenArray;
        int index;
        Screen screen2;
        string str;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num1 = -414778781;
            continue;
          case 1:
            str = name;
            num1 = (int) num3 * 329052591 ^ -1955931662;
            continue;
          case 2:
            num1 = (int) num3 * -483418228 ^ -158624392;
            continue;
          case 3:
            num1 = (int) num3 * -1920518200 ^ -1681671064;
            continue;
          case 4:
            screenArray = WindowHelper.\u202D‪‮‪‭⁭‪‎‭‫​‮⁪‫‎‎‫‬‍‮⁫⁫‫‎⁪‪‪⁬‏⁮⁪⁪‪‌⁬‭‭⁪‫‭‮();
            num1 = (int) num3 * 1536049179 ^ -2020496294;
            continue;
          case 5:
            screen2 = screenArray[index];
            flag = WindowHelper.\u206C‮‮⁪‏‌⁬‪‫‫‬‮‎​‮⁭⁬‬‏‌‎‍⁯‬​‮‌‭‫⁮⁮‌‎⁫⁬‎⁫⁬⁯‪‮(WindowHelper.\u200B‌‪‭‬‭‮‎‏‭⁬‎‬⁭⁭⁮‍‎‍‮‮⁯‎‌‬‭‌⁮⁯‏⁮‎⁮‌⁮⁮‍‍⁪⁫‮(screen2), str);
            num1 = -533093971;
            continue;
          case 6:
            screen1 = WindowHelper.\u200D​​⁮‌‬​‮‍⁯⁮‮‏⁯‍​‫⁪‏‎⁬‭⁭⁫‪‫⁮⁪​‎‮⁭‎⁮​⁪‫‌⁬‭‮();
            num1 = (int) num3 * 1561726757 ^ -1927916971;
            continue;
          case 8:
            int num4 = !flag ? 1751141085 : (num4 = 1029811345);
            int num5 = (int) num3 * 795239383;
            num1 = num4 ^ num5;
            continue;
          case 9:
            goto label_1;
          case 10:
            ++index;
            num1 = (int) num3 * -1573384956 ^ 1958482560;
            continue;
          case 11:
            index = 0;
            num1 = (int) num3 * 2110869841 ^ -470575405;
            continue;
          case 12:
            screen1 = screen2;
            num1 = (int) num3 * -16152787 ^ -2095282572;
            continue;
          case 13:
            int num6;
            num1 = num6 = index >= screenArray.Length ? -90693937 : (num6 = -38724118);
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return screen1;
    }

    public static Bitmap CaptureWindow(IntPtr hwnd)
    {
label_1:
      int num1 = 1166798700;
      Bitmap bitmap1;
      while (true)
      {
        int num2 = 119388037;
        uint num3;
        Rectangle windowRectangle;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            windowRectangle = WindowHelper.GetWindowRectangle(hwnd);
            num1 = (int) num3 * -281360717 ^ -1833494451;
            continue;
          case 2:
            goto label_1;
          case 3:
            bitmap1 = new Bitmap(windowRectangle.Width, windowRectangle.Height);
            num1 = (int) num3 * 1037268588 ^ -1255410475;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      Graphics graphics = Graphics.FromImage((Image) bitmap1);
      try
      {
        IntPtr hdc = graphics.GetHdc();
        try
        {
label_8:
          int num2 = 463764334;
          while (true)
          {
            int num3 = 119388037;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_8;
              case 1:
                Win32.PrintWindow(hwnd, hdc, 0U);
                num2 = (int) num4 * 92057004 ^ -2006235613;
                continue;
              default:
                goto label_23;
            }
          }
        }
        finally
        {
label_12:
          int num2 = 1302279215;
          while (true)
          {
            int num3 = 119388037;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_12;
              case 1:
                num2 = (int) num4 * 1051240248 ^ -964598906;
                continue;
              case 2:
                graphics.ReleaseHdc(hdc);
                num2 = (int) num4 * 1575539696 ^ -944099884;
                continue;
              default:
                goto label_16;
            }
          }
label_16:;
        }
      }
      finally
      {
        if (graphics != null)
        {
label_18:
          int num2 = 1672942112;
          while (true)
          {
            int num3 = 119388037;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                graphics.Dispose();
                num2 = (int) num4 * 1496489030 ^ 1827886360;
                continue;
              case 2:
                goto label_18;
              case 3:
                num2 = (int) num4 * 1180655280 ^ 1020508721;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_23:
      Bitmap bitmap2 = bitmap1;
label_24:
      int num5 = 1185928298;
      while (true)
      {
        int num2 = 119388037;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_24;
          case 2:
            num5 = (int) num3 * 1014409241 ^ -1691506338;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return bitmap2;
    }

    public static Bitmap GetWindowAsBitmap(IntPtr _handle, bool bBringForeground = true, int _leftPixel = 0, int _topPixel = 0, int _height = 0, int _width = 0)
    {
      Bitmap bitmap = (Bitmap) null;
      try
      {
label_2:
        int num1 = 1541534307;
        while (true)
        {
          int num2 = 237423384;
          uint num3;
          Rectangle windowRectangle;
          bool flag1;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              num1 = (int) num3 * -571812645 ^ 1639186349;
              continue;
            case 1:
              flaphx.utils.NativeMethods.SetForegroundWindow(_handle);
              num1 = (int) num3 * 551907014 ^ 542344860;
              continue;
            case 2:
              num1 = (int) num3 * -1781789362 ^ -372554933;
              continue;
            case 3:
              bitmap.Tag = (object) _handle.ToString();
              num1 = (int) num3 * 164604689 ^ -1278753285;
              continue;
            case 4:
              num1 = (int) num3 * 966812908 ^ 315070782;
              continue;
            case 5:
              num1 = 972586465;
              continue;
            case 6:
              flag1 = bBringForeground;
              num1 = (int) num3 * 194311883 ^ 1458356711;
              continue;
            case 7:
              int num4 = flag2 ? -1825537892 : (num4 = -1791816243);
              int num5 = (int) num3 * -1677557264;
              num1 = num4 ^ num5;
              continue;
            case 8:
              num1 = (int) num3 * -1833862642 ^ -1984683957;
              continue;
            case 10:
              flag2 = windowRectangle != Rectangle.Empty;
              num1 = (int) num3 * -32278719 ^ 1783209413;
              continue;
            case 11:
              windowRectangle = WindowHelper.GetWindowRectangle(_handle);
              num1 = (int) num3 * -905513492 ^ 2009999718;
              continue;
            case 12:
              Graphics.FromImage((Image) bitmap).CopyFromScreen(windowRectangle.X, windowRectangle.Y, 0, 0, windowRectangle.Size, CopyPixelOperation.SourceCopy);
              num1 = (int) num3 * 853331216 ^ -1198600896;
              continue;
            case 13:
              int num6 = !flag1 ? 872720602 : (num6 = 2110266772);
              int num7 = (int) num3 * -1872597055;
              num1 = num6 ^ num7;
              continue;
            case 14:
              goto label_2;
            case 15:
              bitmap = new Bitmap(windowRectangle.Width, windowRectangle.Height, PixelFormat.Format32bppArgb);
              num1 = 844794260;
              continue;
            default:
              goto label_23;
          }
        }
      }
      catch (Exception ex)
      {
label_19:
        int num1 = 1903511214;
        while (true)
        {
          int num2 = 237423384;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -982717118 ^ 613279682;
              continue;
            case 2:
              num1 = (int) num3 * -1297075071 ^ 998774255;
              continue;
            case 3:
              goto label_19;
            default:
              goto label_23;
          }
        }
      }
label_23:
      return bitmap;
    }

    public static bool IsWindowOverlapped(IntPtr hWnd, HashSet<IntPtr> ignoreHandles)
    {
      bool flag1 = hWnd == IntPtr.Zero;
label_1:
      int num1 = -940584134;
      bool flag2;
      while (true)
      {
        int num2 = -747821853;
        uint num3;
        flaphx.utils.NativeMethods.RECT lprcDst;
        flaphx.utils.NativeMethods.RECT lpRect1;
        flaphx.utils.NativeMethods.RECT lpRect2;
        bool flag3;
        HashSet<IntPtr> numSet;
        bool flag4;
        bool flag5;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 28U)
        {
          case 0:
            int num7 = flag3 ? 1021314466 : (num7 = 1235060939);
            int num8 = (int) num3 * 2084375142;
            num1 = num7 ^ num8;
            continue;
          case 1:
            int num9 = !flag1 ? -1833127174 : (num9 = -1842927186);
            int num10 = (int) num3 * 1277413182;
            num1 = num9 ^ num10;
            continue;
          case 2:
            num1 = (int) num3 * -746581723 ^ 60215932;
            continue;
          case 3:
            numSet = new HashSet<IntPtr>() { hWnd };
            lpRect1 = new flaphx.utils.NativeMethods.RECT();
            num1 = -862462115;
            continue;
          case 4:
            num1 = (int) num3 * 709113111 ^ 53000650;
            continue;
          case 5:
            if (!((hWnd = flaphx.utils.NativeMethods.GetWindow(hWnd, flaphx.utils.NativeMethods.GetWindow_Cmd.GW_HWNDPREV)) != IntPtr.Zero))
            {
              num4 = 0;
              goto label_23;
            }
            else
            {
              num1 = -287331955;
              continue;
            }
          case 6:
            num4 = !numSet.Contains(hWnd) ? 1 : 0;
            goto label_23;
          case 7:
            flag2 = false;
            num1 = (int) num3 * 1548030368 ^ -33151636;
            continue;
          case 8:
            if (WindowHelper.IsWindowVisible(hWnd))
            {
              num1 = (int) num3 * -195196187 ^ 1281720181;
              continue;
            }
            break;
          case 10:
            flaphx.utils.NativeMethods.GetWindowRect(hWnd, out lpRect1);
            num1 = (int) num3 * -1543117886 ^ -673548679;
            continue;
          case 11:
            num1 = (int) num3 * -663999103 ^ -1952704711;
            continue;
          case 12:
            lprcDst = new flaphx.utils.NativeMethods.RECT();
            lpRect2 = lprcDst;
            num1 = -1436129817;
            continue;
          case 13:
            flag2 = true;
            num1 = (int) num3 * -989578879 ^ -309820385;
            continue;
          case 14:
            if (flaphx.utils.NativeMethods.GetWindowRect(hWnd, out lpRect2))
            {
              num1 = (int) num3 * -1503761148 ^ 721924194;
              continue;
            }
            break;
          case 15:
            flag2 = false;
            num1 = (int) num3 * -503954952 ^ 331265630;
            continue;
          case 16:
            num6 = ignoreHandles.Contains(hWnd) ? 1 : 0;
            goto label_14;
          case 17:
            num5 = flaphx.utils.NativeMethods.IntersectRect(out lprcDst, ref lpRect1, ref lpRect2) ? 1 : 0;
            goto label_5;
          case 18:
            goto label_1;
          case 19:
            flag5 = !WindowHelper.IsWindowVisible(hWnd);
            num1 = -1391932202;
            continue;
          case 20:
            num1 = -1380659264;
            continue;
          case 21:
            int num11 = flag5 ? -1456096383 : (num11 = -510423611);
            int num12 = (int) num3 * -1228444935;
            num1 = num11 ^ num12;
            continue;
          case 22:
            num1 = (int) num3 * 371340575 ^ -1695805308;
            continue;
          case 23:
            numSet.Add(hWnd);
            if (ignoreHandles != null)
            {
              num1 = (int) num3 * -917318334 ^ 1212043185;
              continue;
            }
            num6 = 0;
            goto label_14;
          case 24:
            num1 = -850769982;
            continue;
          case 25:
            num1 = (int) num3 * -1243875995 ^ 426935383;
            continue;
          case 26:
            int num13 = !flag4 ? -1282479624 : (num13 = -1421795413);
            int num14 = (int) num3 * 1665324402;
            num1 = num13 ^ num14;
            continue;
          case 27:
            flag2 = false;
            num1 = (int) num3 * -92287091 ^ 1067466958;
            continue;
          default:
            goto label_39;
        }
        num5 = 0;
label_5:
        flag3 = num5 != 0;
        num1 = -609914469;
        continue;
label_14:
        int num15;
        num1 = num15 = num6 != 0 ? -2137037861 : (num15 = -2040990433);
        continue;
label_23:
        flag4 = num4 != 0;
        num1 = -1766244295;
      }
label_39:
      return flag2;
    }

    internal static bool IsPixelColorMatching(IntPtr iHandle, int _x, int _y, int _R, int _B, int _G)
    {
      bool flag1 = false;
label_1:
      int num1 = -1198304320;
      bool flag2;
      while (true)
      {
        int num2 = -744776266;
        uint num3;
        bool flag3;
        Color pixelColor;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 1:
            flag2 = flag1;
            num1 = -813040778;
            continue;
          case 2:
            if ((int) pixelColor.R == _R)
            {
              num1 = (int) num3 * -2054216663 ^ -1834215616;
              continue;
            }
            break;
          case 3:
            num1 = (int) num3 * -447102364 ^ 1350120309;
            continue;
          case 4:
            pixelColor = flaphx.utils.NativeMethods.GetPixelColor(_x, _y);
            num1 = (int) num3 * -394509964 ^ 46825370;
            continue;
          case 5:
            goto label_1;
          case 6:
            num4 = (int) pixelColor.B == _B ? 1 : 0;
            goto label_6;
          case 7:
            int num5 = !flag3 ? 1689944307 : (num5 = 1148965365);
            int num6 = (int) num3 * 623318930;
            num1 = num5 ^ num6;
            continue;
          case 8:
            if ((int) pixelColor.G == _G)
            {
              num1 = (int) num3 * -782490804 ^ -907376606;
              continue;
            }
            break;
          case 9:
            flag1 = true;
            num1 = (int) num3 * -69893494 ^ -961436301;
            continue;
          default:
            goto label_15;
        }
        num4 = 0;
label_6:
        flag3 = num4 != 0;
        num1 = -1192787507;
      }
label_15:
      return flag2;
    }

    internal static Rectangle GetScreenNonWorkingArea(Screen screen)
    {
label_1:
      int num1 = 1632351387;
      Rectangle rectangle1;
      while (true)
      {
        int num2 = 953107012;
        uint num3;
        Rectangle rectangle2;
        Rectangle rectangle3;
        bool flag1;
        int num4;
        bool flag2;
        int num5;
        bool flag3;
        int num6;
        int num7;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 61U)
        {
          case 0:
            num1 = (int) num3 * -2143547624 ^ -1517119570;
            continue;
          case 1:
            num1 = (int) num3 * -1762748119 ^ 938222799;
            continue;
          case 2:
            int num8 = flag2 ? -1238606035 : (num8 = -1076013736);
            int num9 = (int) num3 * -1569583757;
            num1 = num8 ^ num9;
            continue;
          case 3:
            int num10 = !flag4 ? -2084479865 : (num10 = -728264412);
            int num11 = (int) num3 * -2029753335;
            num1 = num10 ^ num11;
            continue;
          case 4:
            int num12 = !flag1 ? 1516513354 : (num12 = 920416221);
            int num13 = (int) num3 * 2116689343;
            num1 = num12 ^ num13;
            continue;
          case 5:
            int num14 = rectangle3.Height - num5;
            rectangle3 = screen.WorkingArea;
            int height1 = rectangle3.Height;
            num7 = num14 - height1;
            num1 = (int) num3 * 981195802 ^ -1655424066;
            continue;
          case 6:
            rectangle2 = Rectangle.Empty;
            num1 = (int) num3 * 574515059 ^ -409747510;
            continue;
          case 7:
            num1 = (int) num3 * 1260496537 ^ -1562288578;
            continue;
          case 8:
            rectangle1 = rectangle2;
            num1 = 193142468;
            continue;
          case 9:
            num1 = (int) num3 * -167955385 ^ 1109467082;
            continue;
          case 10:
            num1 = (int) num3 * -1081612446 ^ 1595050579;
            continue;
          case 11:
            num1 = (int) num3 * -789095661 ^ -469691812;
            continue;
          case 12:
            num1 = (int) num3 * -1114375352 ^ -1250210852;
            continue;
          case 13:
            rectangle2 = Rectangle.Empty;
            num1 = (int) num3 * 1037669976 ^ -113229020;
            continue;
          case 14:
            rectangle3 = screen.Bounds;
            num1 = (int) num3 * -915199048 ^ -1499988692;
            continue;
          case 15:
            flag4 = num6 > 0;
            num1 = 734500250;
            continue;
          case 16:
            num1 = (int) num3 * -2046891073 ^ 1272100750;
            continue;
          case 18:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local1 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int width1 = rectangle3.Width;
            // ISSUE: explicit reference operation
            (^local1).Width = width1;
            num1 = (int) num3 * -471481810 ^ -1002336697;
            continue;
          case 19:
            goto label_1;
          case 20:
            num1 = (int) num3 * 858452075 ^ -440072402;
            continue;
          case 21:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local2 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int right = rectangle3.Right;
            // ISSUE: explicit reference operation
            (^local2).X = right;
            num1 = (int) num3 * -1633655573 ^ 1058765540;
            continue;
          case 22:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local3 = @rectangle2;
            rectangle3 = screen.Bounds;
            int top1 = rectangle3.Top;
            // ISSUE: explicit reference operation
            (^local3).Y = top1;
            num1 = (int) num3 * 1439107598 ^ -290813599;
            continue;
          case 23:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local4 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int left1 = rectangle3.Left;
            // ISSUE: explicit reference operation
            (^local4).X = left1;
            num1 = (int) num3 * 1626873847 ^ -1260049942;
            continue;
          case 24:
            num1 = (int) num3 * -1123821170 ^ -33575482;
            continue;
          case 25:
            num1 = 458252323;
            continue;
          case 26:
            rectangle2.Width = num4;
            num1 = (int) num3 * 344815390 ^ -1985886995;
            continue;
          case 27:
            rectangle2.Height = num5;
            num1 = (int) num3 * 1985386309 ^ -220766334;
            continue;
          case 28:
            int num15;
            num1 = num15 = num5 > 0 ? 187891016 : (num15 = 768468005);
            continue;
          case 29:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local5 = @rectangle2;
            rectangle3 = screen.Bounds;
            int top2 = rectangle3.Top;
            // ISSUE: explicit reference operation
            (^local5).Y = top2;
            num1 = (int) num3 * -1325784447 ^ 1833543212;
            continue;
          case 30:
            num1 = (int) num3 * 1180541604 ^ -855271068;
            continue;
          case 31:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local6 = @rectangle2;
            rectangle3 = screen.Bounds;
            int top3 = rectangle3.Top;
            // ISSUE: explicit reference operation
            (^local6).Y = top3;
            rectangle2.Width = num6;
            num1 = (int) num3 * -1585692713 ^ 1401682329;
            continue;
          case 32:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local7 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int width2 = rectangle3.Width;
            // ISSUE: explicit reference operation
            (^local7).Width = width2;
            num1 = (int) num3 * -514931242 ^ -413916588;
            continue;
          case 33:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local8 = @rectangle2;
            rectangle3 = screen.Bounds;
            int height2 = rectangle3.Height;
            // ISSUE: explicit reference operation
            (^local8).Height = height2;
            num1 = (int) num3 * -842174030 ^ 246703273;
            continue;
          case 34:
            num1 = (int) num3 * -1446043036 ^ 683719093;
            continue;
          case 35:
            rectangle2 = new Rectangle();
            num1 = (int) num3 * -687768851 ^ 2058233136;
            continue;
          case 36:
            num1 = 1251790927;
            continue;
          case 37:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local9 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int bottom = rectangle3.Bottom;
            // ISSUE: explicit reference operation
            (^local9).Y = bottom;
            num1 = (int) num3 * 1033463448 ^ 1798477784;
            continue;
          case 38:
            num1 = (int) num3 * -953809430 ^ 1670477101;
            continue;
          case 39:
            num1 = (int) num3 * 258513908 ^ 1597495593;
            continue;
          case 40:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local10 = @rectangle2;
            rectangle3 = screen.Bounds;
            int left2 = rectangle3.Left;
            // ISSUE: explicit reference operation
            (^local10).X = left2;
            num1 = (int) num3 * -1277899075 ^ -947920174;
            continue;
          case 41:
            num1 = (int) num3 * -622394560 ^ -1225904876;
            continue;
          case 42:
            num1 = (int) num3 * 2017694568 ^ 2112476566;
            continue;
          case 43:
            num1 = 51512148;
            continue;
          case 44:
            num1 = (int) num3 * -1284292416 ^ 741034721;
            continue;
          case 45:
            num1 = (int) num3 * -1247718149 ^ -637898835;
            continue;
          case 46:
            num1 = (int) num3 * -1030260963 ^ -1315651576;
            continue;
          case 47:
            num1 = (int) num3 * -1835887122 ^ 443469735;
            continue;
          case 48:
            int num16 = !flag3 ? 600998054 : (num16 = 1132252633);
            int num17 = (int) num3 * 71385126;
            num1 = num16 ^ num17;
            continue;
          case 49:
            int num18 = Math.Abs(rectangle3.Left);
            rectangle3 = screen.WorkingArea;
            int num19 = Math.Abs(rectangle3.Left);
            num4 = Math.Abs(num18 - num19);
            rectangle3 = screen.Bounds;
            num1 = (int) num3 * -938955026 ^ -484522091;
            continue;
          case 50:
            int num20 = Math.Abs(rectangle3.Top);
            rectangle3 = screen.WorkingArea;
            int num21 = Math.Abs(rectangle3.Top);
            num5 = Math.Abs(num20 - num21);
            rectangle3 = screen.Bounds;
            int num22 = rectangle3.Width - num4;
            rectangle3 = screen.WorkingArea;
            int width3 = rectangle3.Width;
            num6 = num22 - width3;
            num1 = (int) num3 * 1235572693 ^ 1509578194;
            continue;
          case 51:
            rectangle3 = WindowHelper.\u200F⁬‏‫⁬⁭⁫‫⁪⁭‪⁮‎‭⁮‌‎⁫‎‌⁮‮⁪‍⁬⁪‪⁭‏⁬‭‭⁯⁭⁫‫‭‪⁯⁭‮(screen);
            flag1 = !rectangle3.Equals((object) WindowHelper.\u206C⁯⁫‫⁯‏‪‌⁯‪‫⁪‎⁭‌‪‮‏⁬‭‎⁭⁭‌‬‎⁮‭‫​‪⁬‫‪‏‌‭‪‌‍‮(screen));
            num1 = (int) num3 * -2039171061 ^ 2049574034;
            continue;
          case 52:
            flag3 = num7 > 0;
            num1 = 494056021;
            continue;
          case 53:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local11 = @rectangle2;
            rectangle3 = screen.Bounds;
            int height3 = rectangle3.Height;
            // ISSUE: explicit reference operation
            (^local11).Height = height3;
            num1 = (int) num3 * -1093362552 ^ 824571573;
            continue;
          case 54:
            num1 = (int) num3 * 913388775 ^ 1310302860;
            continue;
          case 55:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local12 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int left3 = rectangle3.Left;
            // ISSUE: explicit reference operation
            (^local12).X = left3;
            num1 = (int) num3 * -312755650 ^ -1956807864;
            continue;
          case 56:
            num1 = (int) num3 * 191081 ^ 196150619;
            continue;
          case 57:
            num1 = (int) num3 * 1953109654 ^ -960748561;
            continue;
          case 58:
            rectangle3 = WindowHelper.\u200F⁬‏‫⁬⁭⁫‫⁪⁭‪⁮‎‭⁮‌‎⁫‎‌⁮‮⁪‍⁬⁪‪⁭‏⁬‭‭⁯⁭⁫‫‭‪⁯⁭‮(screen);
            num1 = (int) num3 * -38426421 ^ -2031175134;
            continue;
          case 59:
            flag2 = num4 > 0;
            num1 = (int) num3 * -497301931 ^ -920113575;
            continue;
          case 60:
            rectangle2.Height = num7;
            num1 = (int) num3 * -1257788784 ^ -874363481;
            continue;
          default:
            goto label_62;
        }
      }
label_62:
      return rectangle1;
    }

    public static List<Rectangle> FindDockedTaskBars()
    {
label_1:
      int num1 = 1583162706;
      List<Rectangle> rectangleList1;
      while (true)
      {
        int num2 = 2134313152;
        uint num3;
        List<Rectangle> rectangleList2;
        bool flag;
        Screen[] screenArray;
        int index;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            num1 = (int) num3 * 1844083058 ^ 398337500;
            continue;
          case 1:
            ++index;
            num1 = (int) num3 * -1296405629 ^ -71333089;
            continue;
          case 2:
            rectangleList2 = new List<Rectangle>();
            num1 = (int) num3 * -145050054 ^ -897736567;
            continue;
          case 3:
            flag = rectangleList2.Count == 0;
            num1 = (int) num3 * -1392142516 ^ 985786559;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 1715176327 ^ -1312428437;
            continue;
          case 6:
            Screen screen = screenArray[index];
            num1 = 1814937847;
            continue;
          case 7:
            num1 = (int) num3 * 1329625293 ^ -889144766;
            continue;
          case 8:
            rectangleList1 = rectangleList2;
            num1 = 1142955482;
            continue;
          case 9:
            num1 = (int) num3 * -1549559208 ^ -661220071;
            continue;
          case 10:
            num1 = (int) num3 * -1850851547 ^ 759212269;
            continue;
          case 11:
            int num4 = flag ? -185097148 : (num4 = -1652976279);
            int num5 = (int) num3 * 461754883;
            num1 = num4 ^ num5;
            continue;
          case 12:
            int num6;
            num1 = num6 = index >= screenArray.Length ? 423817571 : (num6 = 255477126);
            continue;
          case 13:
            screenArray = WindowHelper.\u202D‪‮‪‭⁭‪‎‭‫​‮⁪‫‎‎‫‬‍‮⁫⁫‫‎⁪‪‪⁬‏⁮⁪⁪‪‌⁬‭‭⁪‫‭‮();
            num1 = (int) num3 * -51824445 ^ 101333081;
            continue;
          case 14:
            index = 0;
            num1 = (int) num3 * 186985199 ^ 846251666;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return rectangleList1;
    }

    static StringBuilder \u202E⁫‫⁮‍‮⁪‫⁯‌⁬‭‭‌⁯⁮⁪‍‮⁪⁮‏⁫⁬⁮‪‮‪‫‭‏‌‫⁫⁭⁮⁪‎⁮‏‮([In] int obj0)
    {
      return new StringBuilder(obj0);
    }

    static int \u206F‍‏‌​‍⁮⁯‏‮⁯‍‏‪‬‌⁬‎​‍‭​‍‮‭⁪‌⁯‪⁬‌‏‭‭⁯​‌‎⁯⁫‮([In] StringBuilder obj0)
    {
      return obj0.Capacity;
    }

    static string \u206E‪‌‌‮⁬‍‍⁯⁯⁫⁭⁬⁮‭‍‎⁪‎⁯⁯‫‪‮‮‪‫‬‍‍⁫⁫⁪‪⁪‍⁪‏⁯‪‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static Screen[] \u202D‪‮‪‭⁭‪‎‭‫​‮⁪‫‎‎‫‬‍‮⁫⁫‫‎⁪‪‪⁬‏⁮⁪⁪‪‌⁬‭‭⁪‫‭‮()
    {
      return Screen.AllScreens;
    }

    static Rectangle \u200F⁬‏‫⁬⁭⁫‫⁪⁭‪⁮‎‭⁮‌‎⁫‎‌⁮‮⁪‍⁬⁪‪⁭‏⁬‭‭⁯⁭⁫‫‭‪⁯⁭‮([In] Screen obj0)
    {
      return obj0.Bounds;
    }

    static bool \u202A⁭⁬⁯‬​​⁫​‍⁮​⁫‎‎‫‪⁪‌⁮‭‭‬⁪‍⁫‫⁫‌‌​⁯⁬‫‍⁯​⁯‫‭‮([In] Process obj0)
    {
      return obj0.HasExited;
    }

    static ProcessThreadCollection \u206E‏‎⁮⁬⁬⁯‭⁭⁯⁭⁫‮⁫​⁫‍‭⁫‫‭‪‮⁯‏⁪‫⁯‎‌⁫‪⁭​⁮‎‬‌‫⁬‮([In] Process obj0)
    {
      return obj0.Threads;
    }

    static IEnumerator \u200F​‪⁫⁪‮‪‎⁬‏⁪⁮​‭​‌⁬‫‏‫⁯‪⁮‍‏‏‬‭‪⁭⁬‎⁮⁫⁬​​‍⁯‭‮([In] ReadOnlyCollectionBase obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u200D‫⁭⁫‭‬⁪‌‭‍⁬​​‮⁬‌⁬‪⁫‎‏‎​⁭‌‭‎‍⁫⁬‬⁪⁮‌​‏‪‭⁯‏‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static int \u206B‬‌⁪‌​‮‌⁫⁬⁫⁫⁯‏​⁫⁪‮⁭‮​‭‬‍⁮‌‭‌‮‮⁪‫‫⁪‫⁬‭‫⁪‍‮([In] ProcessThread obj0)
    {
      return obj0.Id;
    }

    static uint \u206C‪⁫‬⁯‬‬‭‏​‏‭⁮‭⁮‌⁪‫⁪⁮⁯‏‮​⁮‫‭‏⁫‮‏‫⁯‌‍‎‎⁮‬⁪‮([In] int obj0)
    {
      return Convert.ToUInt32(obj0);
    }

    static bool \u206B‮‍⁯⁮‭⁯‮⁯⁬‫‫⁫‮‍‪⁬‮⁫⁮⁪⁪⁪‪⁮⁫⁬​‪‮‍‍‍‍⁯‌⁯⁮​‍‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u206F⁯​⁫‎‪‮‮⁭‪‭‮⁪‭‎‪‮⁪​⁯​‌‫‫‭⁯‍‪‭‫‏‭⁯‬‎⁪‍‭⁬‎‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Rectangle \u206C⁯⁫‫⁯‏‪‌⁯‪‫⁪‎⁭‌‪‮‏⁬‭‎⁭⁭‌‬‎⁮‭‫​‪⁬‫‪‏‌‭‪‌‍‮([In] Screen obj0)
    {
      return obj0.WorkingArea;
    }

    static string \u206B‪‌‏⁫‏‍‍⁪‍⁮‍‫‮‫‭⁮⁮‫‭‬⁭​⁭‏‎‪‮⁯‮⁫‌⁯⁪‌‎⁯‬‫‮([In] string obj0)
    {
      return obj0.ToUpper();
    }

    static Process[] \u206E‌‬⁯‪⁭‬⁪⁯‫⁮​⁭⁭‪‍⁬‫⁮‬⁯‮‌‮‮⁪‍⁫‭‌‍⁭‭⁪​⁭⁯⁮⁯⁬‮()
    {
      return Process.GetProcesses();
    }

    static IntPtr \u202D‫‌⁫⁬‌‏‬‮⁫‭‬‪‬⁪​‏⁪‍⁬‍⁫‭‫⁮⁬⁮‌‌‮‬‪‏‮‏‌‬‭‫⁪‮([In] Process obj0)
    {
      return obj0.MainWindowHandle;
    }

    static string \u206C‭‫⁫‬⁪​⁭⁮‪‫⁯⁭⁯‌‫‪⁬⁮‮​​⁯‭​‭‌⁬⁬⁪‌‪⁫‍‭‫‮⁫⁫⁭‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static string \u202E‭‮⁬‪‎‫⁬‮‮⁭⁪‌‪⁭‏⁫⁭⁪‌‬‍‏⁬‭‍‍‬​⁮‍⁭‫⁪‍⁭‎​‪‎‮([In] string obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Remove(obj1, obj2);
    }

    static string \u200B‌‪‭‬‭‮‎‏‭⁬‎‬⁭⁭⁮‍‎‍‮‮⁯‎‌‬‭‌⁮⁯‏⁮‎⁮‌⁮⁮‍‍⁪⁫‮([In] Screen obj0)
    {
      return obj0.DeviceName;
    }

    static bool \u206C‮‮⁪‏‌⁬‪‫‫‬‮‎​‮⁭⁬‬‏‌‎‍⁯‬​‮‌‭‫⁮⁮‌‎⁫⁬‎⁫⁬⁯‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static Screen \u200D​​⁮‌‬​‮‍⁯⁮‮‏⁯‍​‫⁪‏‎⁬‭⁭⁫‪‫⁮⁪​‎‮⁭‎⁮​⁪‫‌⁬‭‮()
    {
      return Screen.PrimaryScreen;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool EnumThreadWindowsProc(IntPtr handle, int param);

    public enum GWLParameter
    {
      GWL_USERDATA = -21,
      GWL_EXSTYLE = -20,
      GWL_STYLE = -16,
      GWL_ID = -12,
      GWL_HWNDPARENT = -8,
      GWL_HINSTANCE = -6,
      GWL_WNDPROC = -4,
    }

    private class GDI32
    {
      public const int SRCCOPY = 13369376;

      [DllImport("gdi32.dll")]
      public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

      [DllImport("gdi32.dll")]
      public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

      [DllImport("gdi32.dll")]
      public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

      [DllImport("gdi32.dll")]
      public static extern bool DeleteDC(IntPtr hDC);

      [DllImport("gdi32.dll")]
      public static extern bool DeleteObject(IntPtr hObject);

      [DllImport("gdi32.dll")]
      public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
    }
  }
}
