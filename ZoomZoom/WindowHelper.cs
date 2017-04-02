// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WindowHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

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

namespace ZoomZoom
{
  public static class WindowHelper
  {
    public static string GetWindowTitle(IntPtr handle)
    {
      bool flag = (int) User32.SendMessage(handle, 14U, 0U, 0U) > 0;
label_1:
      int num1 = -246385603;
      string str;
      while (true)
      {
        int num2 = -1392368480;
        uint num3;
        StringBuilder lpString;
        int num4;
        StringBuilder lParam;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            lpString = WindowHelper.\u206B‫‬⁯‫‬⁭‎‌⁮⁯‍‍⁯‬‬⁬⁪⁬‪‭‌‫‌‬⁮‭‌‮⁫‬‍⁭​‎‍‭‫‏⁫‮(num4);
            NativeMethods.GetWindowText(handle, lpString, WindowHelper.\u202E⁮⁪‮‪‎‏⁪⁫⁫⁯⁫‪‫‭⁪⁭⁭⁭⁯⁯⁫‍‌⁭‌‎⁮‬⁭⁪‬‎‏​‪⁯‫‪‍‮(lpString));
            num1 = (int) num3 * 422625060 ^ 1209806453;
            continue;
          case 1:
            int num5 = !flag ? -1475244978 : (num5 = -948503184);
            int num6 = (int) num3 * 1572993994;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num4 = NativeMethods.GetWindowTextLength(handle) * 2;
            num1 = -2111310204;
            continue;
          case 3:
            num1 = (int) num3 * -892923878 ^ -1925915237;
            continue;
          case 4:
            num1 = (int) num3 * 1724094420 ^ -529953579;
            continue;
          case 5:
            str = WindowHelper.\u202B⁮⁫⁫​​‪‭⁪⁫‬‬‪⁫‌⁫‬‮⁬​‬‏‬⁫‪‎‮‎‮⁯‫⁪‪⁬⁭‬⁮‪⁫‎‮((object) lpString);
            num1 = (int) num3 * -1087865950 ^ -244533729;
            continue;
          case 6:
            str = WindowHelper.\u202B⁮⁫⁫​​‪‭⁪⁫‬‬‪⁫‌⁫‬‮⁬​‬‏‬⁫‪‎‮‎‮⁯‫⁪‪⁬⁭‬⁮‪⁫‎‮((object) lParam);
            num1 = (int) num3 * -1581174914 ^ 1703637483;
            continue;
          case 8:
            goto label_1;
          case 9:
            lParam = WindowHelper.\u206B‫‬⁯‫‬⁭‎‌⁮⁯‍‍⁯‬‬⁬⁪⁬‪‭‌‫‌‬⁮‭‌‮⁫‬‍⁭​‎‍‭‫‏⁫‮(128);
            int num7 = (int) User32.SendMessage(handle, 13U, (uint) WindowHelper.\u202E⁮⁪‮‪‎‏⁪⁫⁫⁯⁫‪‫‭⁪⁭⁭⁭⁯⁯⁫‍‌⁭‌‎⁮‬⁭⁪‬‎‏​‪⁯‫‪‍‮(lParam), lParam);
            num1 = (int) num3 * -628832873 ^ 555169727;
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
label_1:
      int num1 = -928393064;
      string str;
      while (true)
      {
        int num2 = -1683904714;
        uint num3;
        int num4;
        StringBuilder lParam;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 1:
            num1 = (int) num3 * 872196388 ^ 1755877746;
            continue;
          case 2:
            num4 = WindowHelper.SendMessage(handle, wMsg, 0, (StringBuilder) null);
            int num5 = (uint) num4 > 0U ? -1787674033 : (num5 = -853296700);
            int num6 = (int) num3 * 1211258705;
            num1 = num5 ^ num6;
            continue;
          case 3:
            WindowHelper.SendMessage(handle, 13, num4 + 1, lParam);
            str = WindowHelper.\u202B⁮⁫⁫​​‪‭⁪⁫‬‬‪⁫‌⁫‬‮⁬​‬‏‬⁫‪‎‮‎‮⁯‫⁪‪⁬⁭‬⁮‪⁫‎‮((object) lParam);
            num1 = (int) num3 * 838048292 ^ -787689654;
            continue;
          case 4:
            num1 = (int) num3 * -1126287784 ^ -1243349257;
            continue;
          case 5:
            num1 = (int) num3 * 2123415352 ^ -35482521;
            continue;
          case 6:
            goto label_1;
          case 7:
            str = string.Empty;
            num1 = -601943140;
            continue;
          case 8:
            lParam = WindowHelper.\u206B‫‬⁯‫‬⁭‎‌⁮⁯‍‍⁯‬‬⁬⁪⁬‪‭‌‫‌‬⁮‭‌‮⁫‬‍⁭​‎‍‭‫‏⁫‮(num4);
            num1 = (int) num3 * 2032153384 ^ 486329518;
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
label_1:
      int num1 = 433117167;
      Screen screen1;
      while (true)
      {
        int num2 = 2097506972;
        uint num3;
        int index;
        Screen[] screenArray;
        Screen screen2;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            screen1 = (Screen) null;
            num1 = (int) num3 * 1640558269 ^ 538239044;
            continue;
          case 2:
            int num4;
            num1 = num4 = index < screenArray.Length ? 505492539 : (num4 = 1063086308);
            continue;
          case 3:
            int num5 = WindowHelper.\u200F‍‮‫⁬‫⁭⁭‪‎‍⁯‫​‎‌‍⁯‎‪⁫‭⁪⁫⁪​‫⁫‌‮⁬‮‭⁭‫⁯⁮⁪‫‬‮(screen2).Contains(new System.Drawing.Point(rectangle.X, rectangle.Y)) ? 641352803 : (num5 = 359517102);
            int num6 = (int) num3 * -1123512691;
            num1 = num5 ^ num6;
            continue;
          case 4:
            num1 = (int) num3 * 1910739771 ^ -160303858;
            continue;
          case 5:
            screen1 = screen2;
            num1 = (int) num3 * -1369396040 ^ 1780387656;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -342365980 ^ -1398846913;
            continue;
          case 8:
            num1 = (int) num3 * -1005292146 ^ -1712749584;
            continue;
          case 9:
            screenArray = WindowHelper.\u200B‬⁫⁫⁬‌‮‍⁮⁭‏⁫‫‬⁫⁮‏‬⁭⁪⁬‎‌‬‏​‬‎‎⁯⁯‮‬‎‮‍⁮⁬⁭⁭‮();
            num1 = (int) num3 * -1709221616 ^ 1817481131;
            continue;
          case 10:
            ++index;
            num1 = 1631769316;
            continue;
          case 11:
            screen2 = screenArray[index];
            num1 = 380261954;
            continue;
          case 12:
            index = 0;
            num1 = (int) num3 * -783673830 ^ 1247516882;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return screen1;
    }

    internal static Screen GetScreen(ZoomWindow meetingWindow)
    {
label_1:
      int num1 = 84132560;
      Screen screen;
      while (true)
      {
        int num2 = 1513217371;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1784834848 ^ -1887980242;
            continue;
          case 2:
            goto label_1;
          case 3:
            screen = WindowHelper.GetScreen(meetingWindow.Rectangle);
            num1 = (int) num3 * 1394790900 ^ -2093996037;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return screen;
    }

    public static Rectangle GetWindowRectangle(IntPtr handle)
    {
label_1:
      int num1 = -633663200;
      Rectangle rectangle;
      while (true)
      {
        int num2 = -1784608734;
        uint num3;
        User32.RECT lprect;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            rectangle = new Rectangle(lprect.X, lprect.Y, lprect.Width, lprect.Height);
            num1 = (int) num3 * -1198790139 ^ 1785052635;
            continue;
          case 2:
            User32.GetWindowRect(handle, out lprect);
            num1 = (int) num3 * -267385911 ^ 2030969513;
            continue;
          case 3:
            goto label_1;
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
      int num1 = -1692922456;
      string str;
      while (true)
      {
        int num2 = -101772554;
        uint num3;
        StringBuilder lpClassName;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 1:
            User32.GetClassName(handle, lpClassName, WindowHelper.\u202E⁮⁪‮‪‎‏⁪⁫⁫⁯⁫‪‫‭⁪⁭⁭⁭⁯⁯⁫‍‌⁭‌‎⁮‬⁭⁪‬‎‏​‪⁯‫‪‍‮(lpClassName));
            num1 = (int) num3 * -1238605344 ^ -2000479237;
            continue;
          case 2:
            lpClassName = WindowHelper.\u206B‫‬⁯‫‬⁭‎‌⁮⁯‍‍⁯‬‬⁬⁪⁬‪‭‌‫‌‬⁮‭‌‮⁫‬‍⁭​‎‍‭‫‏⁫‮(128);
            num1 = (int) num3 * -1222135005 ^ -1020634793;
            continue;
          case 3:
            num1 = (int) num3 * 867984468 ^ 871712922;
            continue;
          case 4:
            goto label_1;
          case 5:
            str = WindowHelper.\u202B⁮⁫⁫​​‪‭⁪⁫‬‬‪⁫‌⁫‬‮⁬​‬‏‬⁫‪‎‮‎‮⁯‫⁪‪⁬⁭‬⁮‪⁫‎‮((object) lpClassName);
            num1 = (int) num3 * -440266895 ^ 1795716286;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return str;
    }

    public static IntPtr FindWindow(string windowTitle, string className = "", int millisecondsWait = 0)
    {
      DateTime dateTime = DateTime.Now.AddMilliseconds((double) millisecondsWait);
label_1:
      int num1 = -1936686587;
      IntPtr num2;
      while (true)
      {
        int num3 = -1359508347;
        uint num4;
        IntPtr num5;
        bool flag1;
        bool flag2;
        bool flag3;
        int num6;
        int num7;
        int num8;
        switch ((num4 = (uint) (num1 ^ num3)) % 22U)
        {
          case 0:
            num1 = (int) num4 * -1335473867 ^ -2121544737;
            continue;
          case 1:
            if (!num5.Equals((object) IntPtr.Zero))
            {
              num6 = 0;
              goto label_17;
            }
            else
            {
              num1 = -1965486342;
              continue;
            }
          case 2:
            num5 = IntPtr.Zero;
            num1 = (int) num4 * -12154986 ^ 962585482;
            continue;
          case 3:
            num1 = -2084284301;
            continue;
          case 4:
            if (!windowTitle.Equals(string.Empty))
            {
              num1 = (int) num4 * -485035754 ^ -1297072029;
              continue;
            }
            num7 = 0;
            goto label_28;
          case 5:
            num5 = NativeMethods.FindWindowByCaption(new IntPtr(0), windowTitle);
            num1 = (int) num4 * 1496450697 ^ 1047636754;
            continue;
          case 6:
            num1 = (int) num4 * 144363386 ^ 1774865634;
            continue;
          case 7:
            int num9 = !flag1 ? -731551880 : (num9 = -1245819018);
            int num10 = (int) num4 * 1107361844;
            num1 = num9 ^ num10;
            continue;
          case 9:
            if (dateTime > DateTime.Now)
            {
              num1 = -1363458244;
              continue;
            }
            num8 = 0;
            break;
          case 10:
            num1 = (int) num4 * 1776630706 ^ -1227094044;
            continue;
          case 11:
            num6 = !windowTitle.Equals(string.Empty) ? 1 : 0;
            goto label_17;
          case 12:
            num1 = (int) num4 * -305694753 ^ 1763372091;
            continue;
          case 13:
            num2 = num5;
            num1 = -1151431515;
            continue;
          case 14:
            int num11 = !flag3 ? -13310132 : (num11 = -1886726090);
            int num12 = (int) num4 * -681132857;
            num1 = num11 ^ num12;
            continue;
          case 15:
            num8 = num5.Equals((object) IntPtr.Zero) ? 1 : 0;
            break;
          case 16:
            num2 = new IntPtr(0);
            num1 = (int) num4 * -390891933 ^ -1318511797;
            continue;
          case 17:
            flag2 = num5.Equals((object) IntPtr.Zero);
            num1 = (int) num4 * 1822490078 ^ -472047493;
            continue;
          case 18:
            num7 = !className.Equals(string.Empty) ? 1 : 0;
            goto label_28;
          case 19:
            num5 = NativeMethods.FindWindow(className, windowTitle);
            num1 = (int) num4 * 1378312180 ^ 1002508006;
            continue;
          case 20:
            int num13 = !flag2 ? -1212361068 : (num13 = -1084588557);
            int num14 = (int) num4 * -1045915146;
            num1 = num13 ^ num14;
            continue;
          case 21:
            goto label_1;
          default:
            goto label_32;
        }
        flag1 = num8 != 0;
        num1 = -1088940354;
        continue;
label_17:
        int num15;
        num1 = num15 = num6 == 0 ? -1988290642 : (num15 = -2119371147);
        continue;
label_28:
        flag3 = num7 != 0;
        num1 = -671850105;
      }
label_32:
      return num2;
    }

    public static bool CloseWindowByCommand(IntPtr iHandle)
    {
      if (NativeMethods.SendMessage(iHandle, NativeMethods.WMConstants.WM_CLOSE, IntPtr.Zero, IntPtr.Zero) > 0)
        goto label_4;
label_1:
      int num1 = -679949711;
label_2:
      while (true)
      {
        int num2 = -361236342;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1911206086 ^ 552455487;
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
      num1 = -1423410114;
      goto label_2;
    }

    public static List<IntPtr> GetChildWindows(IntPtr parent)
    {
      List<IntPtr> numList1 = new List<IntPtr>();
label_1:
      int num1 = 35393536;
      List<IntPtr> numList2;
      while (true)
      {
        int num2 = 1389707016;
        uint num3;
        IntPtr num4;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * 176310226 ^ 915892528;
            continue;
          case 1:
            num1 = 1673768428;
            continue;
          case 2:
            flag = num4 != IntPtr.Zero;
            num1 = 1712318873;
            continue;
          case 3:
            num1 = (int) num3 * 203942405 ^ -236169934;
            continue;
          case 4:
            goto label_1;
          case 5:
            numList2 = numList1;
            num1 = (int) num3 * -1731609361 ^ -333412783;
            continue;
          case 6:
            numList1.Add(num4);
            num1 = (int) num3 * -1774574499 ^ -1069846459;
            continue;
          case 7:
            num1 = (int) num3 * 361275473 ^ 48918379;
            continue;
          case 8:
            int num5 = !flag ? 1913830565 : (num5 = 640855992);
            int num6 = (int) num3 * 2013014586;
            num1 = num5 ^ num6;
            continue;
          case 9:
            num4 = NativeMethods.GetWindow(parent, NativeMethods.GetWindow_Cmd.GW_CHILD);
            num1 = (int) num3 * -1359659874 ^ 1962284277;
            continue;
          case 10:
            num4 = NativeMethods.FindWindowEx(parent, num4, (string) null, (string) null);
            num1 = (int) num3 * -1216259199 ^ 156618616;
            continue;
          case 11:
            numList1.AddRange((IEnumerable<IntPtr>) WindowHelper.GetChildWindows(num4));
            num1 = (int) num3 * -1934168543 ^ 440865434;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return numList2;
    }

    public static WinPosition GetWindowPosition(IntPtr targetHandle)
    {
label_1:
      int num1 = -2135831161;
      WinPosition winPosition1;
      while (true)
      {
        int num2 = -405816824;
        uint num3;
        WinPosition winPosition2;
        NativeMethods.TITLEBARINFO pti;
        bool titleBarInfo;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            titleBarInfo = NativeMethods.GetTitleBarInfo(targetHandle, ref pti);
            num1 = (int) num3 * -414876967 ^ 903962687;
            continue;
          case 1:
            pti = new NativeMethods.TITLEBARINFO();
            num1 = (int) num3 * -308589994 ^ -139969982;
            continue;
          case 2:
            pti.cbSize = (uint) Marshal.SizeOf<NativeMethods.TITLEBARINFO>((M0) pti);
            num1 = (int) num3 * 855674519 ^ 2029357662;
            continue;
          case 3:
            int num4 = titleBarInfo ? 1265637605 : (num4 = 1349064192);
            int num5 = (int) num3 * 243544560;
            num1 = num4 ^ num5;
            continue;
          case 4:
            winPosition2 = new WinPosition();
            num1 = -1278875675;
            continue;
          case 5:
            winPosition2 = new WinPosition(pti);
            num1 = (int) num3 * 1270182610 ^ -1961483729;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num3 * -341166799 ^ -538185882;
            continue;
          case 9:
            winPosition1 = winPosition2;
            num1 = -780895146;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return winPosition1;
    }

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EnumThreadWindows(uint threadId, WindowHelper.EnumThreadWindowsProc callback, int param);

    public static List<IntPtr> EnumerateProcessWindowHandles(Process processToInspect)
    {
      List<IntPtr> handles = new List<IntPtr>();
      try
      {
        bool flag1 = !WindowHelper.\u206F⁮‪‭​‮‫‫⁫‭‬⁯‌⁭⁫‏‪⁫‏‬​‬‮‬‌‮⁫‮⁯‌‏‏⁪‍‭‮⁭​‏‎‮(processToInspect);
label_2:
        int num1 = -1573093904;
        while (true)
        {
          int num2 = -675277639;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 2:
              if (flag1)
              {
                num1 = (int) num3 * 589446634 ^ 115030748;
                continue;
              }
              goto label_22;
            case 3:
              num1 = (int) num3 * 535898145 ^ 323176463;
              continue;
            case 4:
              num1 = (int) num3 * 156673886 ^ -1664466211;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        IEnumerator enumerator = WindowHelper.\u206E‏‭‮‪​⁬‌‍⁫‮⁪⁯⁪‏‏​⁮‏‌⁮⁯‭​⁪⁯⁬‪⁬⁭‪⁭‭⁭‫‬⁮⁭‫‮((ReadOnlyCollectionBase) WindowHelper.\u200B​‍‮‮‫‎‪‬⁭‬‫‮‪‭‏‌‌⁭‍‍⁫⁭⁬‎‬⁭‮‎‌⁪⁬⁮⁭‍‭‭‮‍⁪‮(processToInspect));
        try
        {
label_12:
          int num2 = !WindowHelper.\u206A⁯⁮​‪‪‫‍‫‏‮⁫​‮​​​‌⁫⁮‌​⁬⁮‎⁬‌‎⁭‎⁯⁫⁭‍⁫‮⁪⁯‬‪‮(enumerator) ? -212127515 : (num2 = -1784964384);
          while (true)
          {
            int num3 = -675277639;
            uint num4;
            ProcessThread processThread;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                NativeMethods.EnumThreadWindows(WindowHelper.\u206F⁭‏‮⁭‎‍‪⁬​‪‬‌‬⁮⁪‌⁫‬⁮‫‌‫‫⁯‭⁭‬‏⁫‮‫‍⁬‌‌‬​​⁯‮(WindowHelper.\u200F‬⁪⁬‍⁭‮‭‌‌⁪⁬‫⁬‍⁬⁯‍⁯‫‎⁬‫‏‫‮⁬‭‌‪‌​⁪‍⁬‮⁮⁫‭⁮‮(processThread)), (NativeMethods.EnumThreadWindowsProc) ((hWnd, lParam) =>
                {
                  handles.Add(hWnd);
label_1:
                  int num1 = 20360049;
                  bool flag;
                  while (true)
                  {
                    int num2 = 2012029817;
                    uint num3;
                    switch ((num3 = (uint) (num1 ^ num2)) % 3U)
                    {
                      case 0:
                        goto label_1;
                      case 1:
                        flag = true;
                        num1 = (int) num3 * -1262061403 ^ 2023173095;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  return flag;
                }), 0);
                num2 = -956135953;
                continue;
              case 1:
                goto label_12;
              case 2:
                num2 = -1784964384;
                continue;
              case 3:
                processThread = (ProcessThread) WindowHelper.\u202C‍‏‪‎‍‬‫‌⁬‍⁬⁫⁭‮⁫‏‭‍⁬⁯⁪​⁮‬‎‮⁮⁫‭‎‫‭⁬⁯‍‪‪‍‎‮(enumerator);
                num2 = -934574346;
                continue;
              default:
                goto label_20;
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator as IDisposable;
          if (disposable != null)
          {
label_16:
            int num2 = -1623938102;
            while (true)
            {
              int num3 = -675277639;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_16;
                case 1:
                  WindowHelper.\u200F‎⁮⁫⁬⁭⁫‪⁭⁮‎⁮⁭‍‫‍⁮‏‏‭⁬‪‏‮⁯‮‫⁯‬‍‮⁭‌⁬‭‌‏‫⁯‮(disposable);
                  num2 = (int) num4 * 1903464042 ^ -316724147;
                  continue;
                default:
                  goto label_19;
              }
            }
          }
label_19:;
        }
label_20:;
      }
      catch (Exception ex)
      {
      }
label_22:
      List<IntPtr> numList = handles;
label_23:
      int num8 = -260332204;
      while (true)
      {
        int num1 = -675277639;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 1:
            num8 = (int) num2 * -179090716 ^ -1467208498;
            continue;
          case 2:
            goto label_23;
          default:
            goto label_26;
        }
      }
label_26:
      return numList;
    }

    public static void Move(IntPtr handle, Rectangle rectangle, bool repaint = true)
    {
label_1:
      int num1 = 1544966199;
      while (true)
      {
        int num2 = 161211384;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            flag1 = WindowHelper.IsMinimized(handle);
            num1 = (int) num3 * 116718910 ^ 1263809112;
            continue;
          case 1:
            WindowHelper.RestoreWindow(handle);
            num1 = (int) num3 * 821297685 ^ -262761573;
            continue;
          case 2:
            int num4 = !flag1 ? 931184763 : (num4 = 1067275295);
            int num5 = (int) num3 * -1092320826;
            num1 = num4 ^ num5;
            continue;
          case 3:
            NativeMethods.MoveWindow(handle, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, repaint);
            num1 = 772542117;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * -203562769 ^ 520413371;
            continue;
          case 7:
            flag2 = NativeMethods.IsWindow(handle);
            num1 = (int) num3 * -1127644711 ^ 366431382;
            continue;
          case 8:
            num1 = (int) num3 * -282541507 ^ -819419086;
            continue;
          case 9:
            int num6 = !flag2 ? 1035174061 : (num6 = 941450072);
            int num7 = (int) num3 * 935391048;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    internal static void RestoreWindow(IntPtr handle)
    {
      bool flag = WindowHelper.IsValid(handle);
label_1:
      int num1 = 1567850676;
      while (true)
      {
        int num2 = 965939643;
        uint num3;
        NativeMethods.WINDOWPLACEMENT lpwndpl;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            lpwndpl.length = Marshal.SizeOf<NativeMethods.WINDOWPLACEMENT>((M0) lpwndpl);
            NativeMethods.SetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * -193289684 ^ 264679056;
            continue;
          case 1:
            lpwndpl.showCmd = 9;
            num1 = (int) num3 * -373957225 ^ -412916856;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1101604098 ^ 1919158649;
            continue;
          case 4:
            num1 = (int) num3 * 1998481972 ^ 1363723382;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = 76543758;
            continue;
          case 7:
            lpwndpl = new NativeMethods.WINDOWPLACEMENT();
            num1 = (int) num3 * -1527370778 ^ -2011530401;
            continue;
          case 8:
            NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            int num4 = (lpwndpl.showCmd & 9) == 9 ? -1334785639 : (num4 = -1156517991);
            int num5 = (int) num3 * 494111967;
            num1 = num4 ^ num5;
            continue;
          case 9:
            int num6 = flag ? -1773360300 : (num6 = -805119278);
            int num7 = (int) num3 * 500907108;
            num1 = num6 ^ num7;
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
      int num1 = 1145620040;
      while (true)
      {
        int num2 = 1495928331;
        uint num3;
        NativeMethods.WINDOWPLACEMENT lpwndpl;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            goto label_3;
          case 1:
            lpwndpl.length = Marshal.SizeOf<NativeMethods.WINDOWPLACEMENT>((M0) lpwndpl);
            NativeMethods.SetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * -758853551 ^ -1346593398;
            continue;
          case 2:
            lpwndpl = new NativeMethods.WINDOWPLACEMENT();
            num1 = (int) num3 * 930445117 ^ 1501670451;
            continue;
          case 3:
            flag = (lpwndpl.showCmd & 2) != 2;
            num1 = (int) num3 * 691137048 ^ -1863385510;
            continue;
          case 4:
            num1 = (int) num3 * -201042330 ^ 2073637136;
            continue;
          case 5:
            num1 = (int) num3 * -1064461938 ^ 714683403;
            continue;
          case 6:
            NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * 462598471 ^ 303871786;
            continue;
          case 7:
            int num4 = WindowHelper.IsValid(handle) ? -1443638635 : (num4 = -1898098332);
            int num5 = (int) num3 * 469104581;
            num1 = num4 ^ num5;
            continue;
          case 8:
            num1 = 730239467;
            continue;
          case 9:
            int num6 = flag ? 1723695947 : (num6 = 1543851023);
            int num7 = (int) num3 * 185105388;
            num1 = num6 ^ num7;
            continue;
          case 10:
            goto label_1;
          case 11:
            lpwndpl.showCmd = 2;
            num1 = (int) num3 * -1422219431 ^ -722049175;
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
label_1:
      int num1 = 1219545001;
      bool flag;
      while (true)
      {
        int num2 = 1832215000;
        uint num3;
        NativeMethods.WINDOWPLACEMENT lpwndpl;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            flag = false;
            num1 = 228860584;
            continue;
          case 1:
            int num4 = (lpwndpl.showCmd & 2) == 2 ? -1778025647 : (num4 = -180689323);
            int num5 = (int) num3 * 1278108523;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_1;
          case 4:
            flag = true;
            num1 = (int) num3 * -1518864468 ^ 422640177;
            continue;
          case 5:
            num1 = (int) num3 * 1211652139 ^ 2052626981;
            continue;
          case 6:
            num1 = (int) num3 * 1543105564 ^ -1980624526;
            continue;
          case 7:
            NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * -1827021538 ^ 829722086;
            continue;
          case 8:
            lpwndpl = new NativeMethods.WINDOWPLACEMENT();
            num1 = (int) num3 * -1012436573 ^ -1618860218;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag;
    }

    public static bool IsValid(IntPtr handle)
    {
label_1:
      int num1 = -420500000;
      bool flag1;
      while (true)
      {
        int num2 = -1060453418;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 2:
            int num4 = !flag2 ? -506197409 : (num4 = -201810720);
            int num5 = (int) num3 * 377889960;
            num1 = num4 ^ num5;
            continue;
          case 3:
            num1 = (int) num3 * -1767079489 ^ 738202782;
            continue;
          case 4:
            num1 = -1809982854;
            continue;
          case 5:
            flag1 = true;
            num1 = (int) num3 * -1549619539 ^ -1707625220;
            continue;
          case 6:
            num1 = (int) num3 * -1210448568 ^ -736784754;
            continue;
          case 7:
            flag1 = false;
            num1 = (int) num3 * -1499837712 ^ 1022946976;
            continue;
          case 8:
            flag2 = NativeMethods.IsWindow(handle);
            num1 = (int) num3 * -208965351 ^ -269348803;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag1;
    }

    public static NativeMethods.WINDOWPLACEMENT GetPlacement(IntPtr handle)
    {
      NativeMethods.WINDOWPLACEMENT lpwndpl = new NativeMethods.WINDOWPLACEMENT();
label_1:
      int num1 = 2127905476;
      NativeMethods.WINDOWPLACEMENT windowplacement;
      while (true)
      {
        int num2 = 2109130207;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            windowplacement = lpwndpl;
            num1 = (int) num3 * 997910026 ^ 1953377983;
            continue;
          case 3:
            lpwndpl.length = Marshal.SizeOf<NativeMethods.WINDOWPLACEMENT>((M0) lpwndpl);
            NativeMethods.GetWindowPlacement(handle, ref lpwndpl);
            num1 = (int) num3 * -297156469 ^ 1919851651;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return windowplacement;
    }

    public static int SetWindowLong(IntPtr windowHandle, NativeMethods.GWLParameter nIndex, int dwNewLong)
    {
      if (IntPtr.Size != 8)
        goto label_4;
label_1:
      int num1 = -573924302;
label_2:
      int num2;
      while (true)
      {
        int num3 = -1695653639;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 6U)
        {
          case 0:
            goto label_4;
          case 1:
            num2 = (int) NativeMethods.SetWindowLongPtr64(windowHandle, nIndex, new IntPtr(dwNewLong));
            num1 = (int) num4 * -1991240766 ^ -1844181762;
            continue;
          case 2:
            num1 = (int) num4 * -360548092 ^ 856070000;
            continue;
          case 3:
            num1 = (int) num4 * 999355672 ^ 1867132168;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      return num2;
label_4:
      num2 = NativeMethods.SetWindowLong32(windowHandle, nIndex, dwNewLong);
      num1 = -604002751;
      goto label_2;
    }

    public static Rectangle GetScreenPlacement(Screen screen, ScreenPlacement horizontal, ScreenPlacement vertical)
    {
label_1:
      int num1 = 354128530;
      Rectangle rectangle1;
      while (true)
      {
        int num2 = 74175028;
        uint num3;
        Size size;
        Rectangle rectangle2;
        System.Drawing.Point location;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 113U)
        {
          case 0:
label_21:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local1 = @size;
            rectangle2 = screen.WorkingArea;
            int num4 = rectangle2.Height / 3;
            // ISSUE: explicit reference operation
            (^local1).Height = num4;
            num1 = 2135099750;
            continue;
          case 1:
            num1 = (int) num3 * 1348365807 ^ -904488680;
            continue;
          case 2:
            flag = true;
            num1 = (int) num3 * -994301829 ^ 677847780;
            continue;
          case 3:
            flag = true;
            num1 = (int) num3 * 707936551 ^ 1204275610;
            continue;
          case 4:
label_78:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local2 = @size;
            rectangle2 = WindowHelper.\u206C⁮‍⁪‌‭⁬‎‮‍‬⁫⁮⁬‏‬‫‭‭⁪⁪‮‏⁭⁯‬​​‎‮‫‎⁯⁯‭⁯⁪⁯‮⁮‮(screen);
            int num5 = rectangle2.Width / 2;
            // ISSUE: explicit reference operation
            (^local2).Width = num5;
            num1 = 1744005266;
            continue;
          case 5:
          case 72:
          case 81:
label_26:
            int num6;
            num1 = num6 = flag ? 729922256 : (num6 = 1100313991);
            continue;
          case 6:
            flag = true;
            num1 = (int) num3 * 1157932203 ^ 898105751;
            continue;
          case 7:
            num1 = (int) num3 * -86887984 ^ -68230485;
            continue;
          case 8:
            num1 = (int) num3 * 1850562743 ^ 1648541164;
            continue;
          case 9:
label_28:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local3 = @size;
            rectangle2 = screen.WorkingArea;
            int num7 = rectangle2.Height / 2;
            // ISSUE: explicit reference operation
            (^local3).Height = num7;
            num1 = 2121347976;
            continue;
          case 10:
            rectangle1 = new Rectangle(location, size);
            num1 = (int) num3 * 1306159210 ^ 484245770;
            continue;
          case 11:
            flag = true;
            num1 = (int) num3 * -1532214882 ^ -974211195;
            continue;
          case 12:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local4 = @location;
            rectangle2 = screen.WorkingArea;
            int y1 = rectangle2.Y;
            rectangle2 = screen.WorkingArea;
            int num8 = rectangle2.Height / 3;
            int num9 = y1 + num8;
            // ISSUE: explicit reference operation
            (^local4).Y = num9;
            num1 = (int) num3 * 1286431331 ^ 1413128132;
            continue;
          case 13:
            size = new Size();
            num1 = (int) num3 * 1725798924 ^ -1205637473;
            continue;
          case 14:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local5 = @location;
            rectangle2 = screen.WorkingArea;
            int num10 = rectangle2.Y + size.Height * 2;
            // ISSUE: explicit reference operation
            (^local5).Y = num10;
            num1 = (int) num3 * -288510398 ^ -1761178868;
            continue;
          case 15:
            flag = true;
            num1 = (int) num3 * -407314408 ^ -1940880523;
            continue;
          case 16:
            num1 = (int) num3 * 1846174068 ^ 1897252770;
            continue;
          case 17:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local6 = @location;
            rectangle2 = screen.WorkingArea;
            int x1 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local6).X = x1;
            num1 = (int) num3 * 6963537 ^ 2004566;
            continue;
          case 18:
label_31:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local7 = @size;
            rectangle2 = screen.WorkingArea;
            int num11 = rectangle2.Height / 2;
            // ISSUE: explicit reference operation
            (^local7).Height = num11;
            num1 = 1929245448;
            continue;
          case 19:
label_37:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local8 = @size;
            rectangle2 = screen.WorkingArea;
            int num12 = rectangle2.Width / 3;
            // ISSUE: explicit reference operation
            (^local8).Width = num12;
            num1 = 1298077907;
            continue;
          case 20:
label_14:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local9 = @size;
            rectangle2 = screen.WorkingArea;
            int num13 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local9).Width = num13;
            num1 = 803117231;
            continue;
          case 21:
label_5:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local10 = @size;
            rectangle2 = screen.WorkingArea;
            int num14 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local10).Height = num14;
            num1 = 1418280017;
            continue;
          case 22:
          case 57:
          case 69:
label_50:
            switch (vertical)
            {
              case ScreenPlacement.Undefined:
                goto label_26;
              case ScreenPlacement.FirstHalf:
                goto label_43;
              case ScreenPlacement.SecondHalf:
                goto label_28;
              case ScreenPlacement.FirstThird:
                goto label_80;
              case ScreenPlacement.FirstTwoThirds:
                goto label_3;
              case ScreenPlacement.SecondThird:
                goto label_96;
              case ScreenPlacement.SecondTwoThirds:
                goto label_102;
              case ScreenPlacement.ThirdThird:
                goto label_21;
              case ScreenPlacement.FirstQuarter:
                goto label_29;
              case ScreenPlacement.SecondQuarter:
                goto label_111;
              case ScreenPlacement.SecondTwoQuarters:
                goto label_31;
              case ScreenPlacement.ThirdQuarter:
                goto label_5;
              case ScreenPlacement.FourthQuarter:
                goto label_94;
              case ScreenPlacement.Full:
                goto label_109;
              default:
                num1 = 2147435773;
                continue;
            }
          case 23:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local11 = @location;
            rectangle2 = screen.WorkingArea;
            int num15 = rectangle2.Y + size.Height * 2;
            // ISSUE: explicit reference operation
            (^local11).Y = num15;
            flag = true;
            num1 = (int) num3 * -1026821590 ^ -2133075760;
            continue;
          case 24:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local12 = @location;
            rectangle2 = screen.WorkingArea;
            int num16 = rectangle2.Y + size.Height;
            // ISSUE: explicit reference operation
            (^local12).Y = num16;
            flag = true;
            num1 = (int) num3 * 1959344134 ^ -226321432;
            continue;
          case 25:
            rectangle1 = Rectangle.Empty;
            num1 = (int) num3 * -2030558249 ^ 287613425;
            continue;
          case 26:
label_110:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local13 = @size;
            rectangle2 = screen.WorkingArea;
            int num17 = rectangle2.Width / 2;
            // ISSUE: explicit reference operation
            (^local13).Width = num17;
            num1 = 1597021553;
            continue;
          case 27:
            num1 = (int) num3 * 2123853370 ^ -1681678873;
            continue;
          case 28:
            num1 = (int) num3 * 1958198180 ^ 1276480581;
            continue;
          case 29:
label_56:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local14 = @size;
            rectangle2 = screen.WorkingArea;
            int num18 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local14).Width = num18;
            num1 = 1565433077;
            continue;
          case 30:
            num1 = (int) num3 * 1493133011 ^ -1708120451;
            continue;
          case 31:
            num1 = (int) num3 * -1312880016 ^ -1073799201;
            continue;
          case 32:
            num1 = (int) num3 * -1842406220 ^ 2102529601;
            continue;
          case 33:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local15 = @location;
            rectangle2 = screen.WorkingArea;
            int x2 = rectangle2.X;
            rectangle2 = screen.WorkingArea;
            int num19 = rectangle2.Width / 3;
            int num20 = x2 + num19;
            // ISSUE: explicit reference operation
            (^local15).X = num20;
            num1 = (int) num3 * -1514176666 ^ 1014459006;
            continue;
          case 34:
            num1 = (int) num3 * -644589520 ^ -529576867;
            continue;
          case 35:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local16 = @location;
            rectangle2 = screen.WorkingArea;
            int x3 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local16).X = x3;
            num1 = (int) num3 * 1091210604 ^ -658390317;
            continue;
          case 37:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local17 = @location;
            rectangle2 = screen.WorkingArea;
            int y2 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local17).Y = y2;
            num1 = (int) num3 * 1827897523 ^ 732570129;
            continue;
          case 38:
            num1 = (int) num3 * 1637663485 ^ -1239334238;
            continue;
          case 39:
            num1 = (int) num3 * -1947898525 ^ 1089941171;
            continue;
          case 40:
            flag = true;
            num1 = (int) num3 * 1052338400 ^ 1026123863;
            continue;
          case 41:
label_48:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local18 = @size;
            rectangle2 = screen.WorkingArea;
            int num21 = rectangle2.Width / 3 * 2;
            // ISSUE: explicit reference operation
            (^local18).Width = num21;
            num1 = 909844189;
            continue;
          case 42:
label_94:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local19 = @size;
            rectangle2 = screen.WorkingArea;
            int num22 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local19).Height = num22;
            num1 = 840516379;
            continue;
          case 43:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local20 = @location;
            rectangle2 = screen.WorkingArea;
            int x4 = rectangle2.X;
            rectangle2 = screen.WorkingArea;
            int num23 = rectangle2.Width / 4;
            int num24 = x4 + num23;
            // ISSUE: explicit reference operation
            (^local20).X = num24;
            num1 = (int) num3 * -1578503147 ^ 1282496331;
            continue;
          case 44:
            switch (horizontal)
            {
              case ScreenPlacement.Undefined:
                goto label_50;
              case ScreenPlacement.FirstHalf:
                goto label_78;
              case ScreenPlacement.SecondHalf:
                goto label_110;
              case ScreenPlacement.FirstThird:
                goto label_37;
              case ScreenPlacement.FirstTwoThirds:
                goto label_81;
              case ScreenPlacement.SecondThird:
                goto label_53;
              case ScreenPlacement.SecondTwoThirds:
                goto label_48;
              case ScreenPlacement.ThirdThird:
                goto label_44;
              case ScreenPlacement.FirstQuarter:
                goto label_27;
              case ScreenPlacement.SecondQuarter:
                goto label_56;
              case ScreenPlacement.SecondTwoQuarters:
                goto label_74;
              case ScreenPlacement.ThirdQuarter:
                goto label_41;
              case ScreenPlacement.FourthQuarter:
                goto label_14;
              case ScreenPlacement.Full:
                goto label_9;
              default:
                num1 = (int) num3 * 1891620585 ^ 1205418697;
                continue;
            }
          case 45:
            num1 = (int) num3 * -1376340712 ^ -398968616;
            continue;
          case 46:
            num1 = (int) num3 * -633833566 ^ -1602338156;
            continue;
          case 47:
            flag = true;
            num1 = (int) num3 * -1597437982 ^ -1680404335;
            continue;
          case 48:
label_27:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local21 = @size;
            rectangle2 = screen.WorkingArea;
            int num25 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local21).Width = num25;
            num1 = 603722300;
            continue;
          case 49:
            num1 = (int) num3 * 937205192 ^ 1183661415;
            continue;
          case 50:
            flag = false;
            num1 = (int) num3 * -812697566 ^ 1628650195;
            continue;
          case 51:
            flag = true;
            num1 = (int) num3 * -887271902 ^ 1486780521;
            continue;
          case 52:
            flag = true;
            num1 = (int) num3 * -567543473 ^ -1798977365;
            continue;
          case 53:
            flag = true;
            num1 = (int) num3 * 2125578970 ^ -252273828;
            continue;
          case 54:
label_44:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local22 = @size;
            rectangle2 = screen.WorkingArea;
            int num26 = rectangle2.Width / 3;
            // ISSUE: explicit reference operation
            (^local22).Width = num26;
            num1 = 425513320;
            continue;
          case 55:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local23 = @location;
            rectangle2 = screen.WorkingArea;
            int num27 = rectangle2.X + size.Width;
            // ISSUE: explicit reference operation
            (^local23).X = num27;
            flag = true;
            num1 = (int) num3 * -2123706092 ^ 224723253;
            continue;
          case 56:
label_111:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local24 = @size;
            rectangle2 = screen.WorkingArea;
            int num28 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local24).Height = num28;
            num1 = 684979793;
            continue;
          case 58:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local25 = @location;
            rectangle2 = screen.WorkingArea;
            int num29 = rectangle2.X + size.Width;
            // ISSUE: explicit reference operation
            (^local25).X = num29;
            num1 = (int) num3 * 1417839630 ^ -1707910284;
            continue;
          case 59:
            num1 = (int) num3 * -1151830205 ^ -1009628764;
            continue;
          case 60:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local26 = @location;
            rectangle2 = screen.WorkingArea;
            int num30 = rectangle2.Y + size.Height * 3;
            // ISSUE: explicit reference operation
            (^local26).Y = num30;
            num1 = (int) num3 * 2134547140 ^ -1958998845;
            continue;
          case 61:
label_41:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local27 = @size;
            rectangle2 = screen.WorkingArea;
            int num31 = rectangle2.Width / 4;
            // ISSUE: explicit reference operation
            (^local27).Width = num31;
            num1 = 414541281;
            continue;
          case 62:
label_96:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local28 = @size;
            rectangle2 = screen.WorkingArea;
            int num32 = rectangle2.Height / 3;
            // ISSUE: explicit reference operation
            (^local28).Height = num32;
            num1 = 648468581;
            continue;
          case 63:
            flag = true;
            num1 = (int) num3 * -334212729 ^ -1281919031;
            continue;
          case 64:
label_74:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local29 = @size;
            rectangle2 = screen.WorkingArea;
            int num33 = rectangle2.Width / 2;
            // ISSUE: explicit reference operation
            (^local29).Width = num33;
            num1 = 916064000;
            continue;
          case 65:
            flag = true;
            num1 = (int) num3 * 1258332172 ^ -1739840019;
            continue;
          case 66:
            flag = true;
            num1 = (int) num3 * -78038095 ^ -950621814;
            continue;
          case 67:
            num1 = (int) num3 * 278079340 ^ -1535800030;
            continue;
          case 68:
            flag = true;
            num1 = (int) num3 * -1131598368 ^ -636807018;
            continue;
          case 70:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local30 = @location;
            rectangle2 = screen.WorkingArea;
            int x5 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local30).X = x5;
            num1 = (int) num3 * -1410944019 ^ 340643388;
            continue;
          case 71:
            flag = true;
            num1 = (int) num3 * 1468440613 ^ 2132499677;
            continue;
          case 73:
            num1 = (int) num3 * 370208082 ^ 255791440;
            continue;
          case 74:
            num1 = 1273356673;
            continue;
          case 75:
            num1 = (int) num3 * 1738813480 ^ -9473068;
            continue;
          case 76:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local31 = @location;
            rectangle2 = screen.WorkingArea;
            int num34 = rectangle2.Y + size.Height / 4;
            // ISSUE: explicit reference operation
            (^local31).Y = num34;
            num1 = (int) num3 * 920785731 ^ 576639232;
            continue;
          case 77:
            flag = true;
            num1 = (int) num3 * -97102355 ^ -1626965810;
            continue;
          case 78:
label_53:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local32 = @size;
            rectangle2 = screen.WorkingArea;
            int num35 = rectangle2.Width / 3;
            // ISSUE: explicit reference operation
            (^local32).Width = num35;
            num1 = 2001451293;
            continue;
          case 79:
            flag = true;
            num1 = (int) num3 * -643343390 ^ 355995496;
            continue;
          case 80:
            flag = true;
            num1 = (int) num3 * -2061217784 ^ 137662462;
            continue;
          case 82:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local33 = @location;
            rectangle2 = screen.WorkingArea;
            int num36 = rectangle2.X + size.Width;
            // ISSUE: explicit reference operation
            (^local33).X = num36;
            num1 = (int) num3 * -958208548 ^ -287557952;
            continue;
          case 83:
            num1 = (int) num3 * -145540776 ^ -822209099;
            continue;
          case 84:
            num1 = (int) num3 * 687591451 ^ 1585499376;
            continue;
          case 85:
            num1 = (int) num3 * -620838968 ^ 1151585253;
            continue;
          case 86:
label_109:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local34 = @size;
            rectangle2 = screen.WorkingArea;
            int height = rectangle2.Height;
            // ISSUE: explicit reference operation
            (^local34).Height = height;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local35 = @location;
            rectangle2 = screen.WorkingArea;
            int y3 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local35).Y = y3;
            num1 = 1332844901;
            continue;
          case 87:
            num1 = (int) num3 * -1344348512 ^ -397510211;
            continue;
          case 88:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local36 = @location;
            rectangle2 = screen.WorkingArea;
            int x6 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local36).X = x6;
            num1 = (int) num3 * 1388748599 ^ -1335234625;
            continue;
          case 89:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local37 = @size;
            rectangle2 = screen.WorkingArea;
            int num37 = rectangle2.Height / 3 * 2;
            // ISSUE: explicit reference operation
            (^local37).Height = num37;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local38 = @location;
            rectangle2 = screen.WorkingArea;
            int y4 = rectangle2.Y;
            rectangle2 = screen.WorkingArea;
            int num38 = rectangle2.Height / 3;
            int num39 = y4 + num38;
            // ISSUE: explicit reference operation
            (^local38).Y = num39;
            num1 = 746189609;
            continue;
          case 90:
            goto label_1;
          case 91:
label_102:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local39 = @size;
            rectangle2 = screen.WorkingArea;
            int num40 = rectangle2.Height / 3 * 2;
            // ISSUE: explicit reference operation
            (^local39).Height = num40;
            num1 = 107080455;
            continue;
          case 92:
            num1 = (int) num3 * -257133205 ^ -1326367999;
            continue;
          case 93:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local40 = @location;
            rectangle2 = screen.WorkingArea;
            int num41 = rectangle2.X + size.Width * 3;
            // ISSUE: explicit reference operation
            (^local40).X = num41;
            num1 = (int) num3 * 623197827 ^ -188934653;
            continue;
          case 94:
            num1 = (int) num3 * -1035202125 ^ 30241477;
            continue;
          case 95:
label_80:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local41 = @size;
            rectangle2 = screen.WorkingArea;
            int num42 = rectangle2.Height / 3;
            // ISSUE: explicit reference operation
            (^local41).Height = num42;
            num1 = 1191708421;
            continue;
          case 96:
label_81:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local42 = @size;
            rectangle2 = screen.WorkingArea;
            int num43 = rectangle2.Width / 3 * 2;
            // ISSUE: explicit reference operation
            (^local42).Width = num43;
            num1 = 1853874631;
            continue;
          case 97:
            num1 = (int) num3 * -1347158467 ^ 212971670;
            continue;
          case 98:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local43 = @location;
            rectangle2 = screen.WorkingArea;
            int num44 = rectangle2.X + size.Width * 2;
            // ISSUE: explicit reference operation
            (^local43).X = num44;
            flag = true;
            num1 = (int) num3 * -1716547198 ^ 757087684;
            continue;
          case 99:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local44 = @location;
            rectangle2 = screen.WorkingArea;
            int num45 = rectangle2.X + size.Width * 2;
            // ISSUE: explicit reference operation
            (^local44).X = num45;
            num1 = (int) num3 * -1043626169 ^ -1913576982;
            continue;
          case 100:
            flag = true;
            num1 = (int) num3 * 606876203 ^ 1303775854;
            continue;
          case 101:
            location = new System.Drawing.Point();
            num1 = (int) num3 * -821730488 ^ 697391343;
            continue;
          case 102:
            flag = true;
            num1 = (int) num3 * -1932251619 ^ 1293262847;
            continue;
          case 103:
            flag = true;
            num1 = (int) num3 * -1213248232 ^ -1154577408;
            continue;
          case 104:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local45 = @location;
            rectangle2 = screen.WorkingArea;
            int num46 = rectangle2.Y + size.Height;
            // ISSUE: explicit reference operation
            (^local45).Y = num46;
            flag = true;
            num1 = (int) num3 * 1747543773 ^ -11489542;
            continue;
          case 105:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local46 = @location;
            rectangle2 = screen.WorkingArea;
            int x7 = rectangle2.X;
            // ISSUE: explicit reference operation
            (^local46).X = x7;
            num1 = (int) num3 * -298236609 ^ -882554950;
            continue;
          case 106:
label_43:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local47 = @size;
            rectangle2 = screen.WorkingArea;
            int num47 = rectangle2.Height / 2;
            // ISSUE: explicit reference operation
            (^local47).Height = num47;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local48 = @location;
            rectangle2 = screen.WorkingArea;
            int y5 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local48).Y = y5;
            num1 = 967976006;
            continue;
          case 107:
            num1 = (int) num3 * 318180069 ^ 1297839852;
            continue;
          case 108:
            num1 = (int) num3 * 1167906381 ^ 944616981;
            continue;
          case 109:
label_9:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local49 = @size;
            rectangle2 = screen.WorkingArea;
            int width = rectangle2.Width;
            // ISSUE: explicit reference operation
            (^local49).Width = width;
            num1 = 695067752;
            continue;
          case 110:
label_29:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Size& local50 = @size;
            rectangle2 = screen.WorkingArea;
            int num48 = rectangle2.Height / 4;
            // ISSUE: explicit reference operation
            (^local50).Height = num48;
            flag = true;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local51 = @location;
            rectangle2 = screen.WorkingArea;
            int y6 = rectangle2.Y;
            // ISSUE: explicit reference operation
            (^local51).Y = y6;
            num1 = 487332381;
            continue;
          case 111:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            System.Drawing.Point& local52 = @location;
            rectangle2 = screen.WorkingArea;
            int y7 = rectangle2.Y;
            rectangle2 = screen.WorkingArea;
            int num49 = rectangle2.Height / 3;
            int num50 = y7 + num49;
            // ISSUE: explicit reference operation
            (^local52).Y = num50;
            num1 = (int) num3 * -1165302144 ^ 100855531;
            continue;
          case 112:
            num1 = (int) num3 * 58217372 ^ -1970334806;
            continue;
          default:
            goto label_112;
        }
      }
label_112:
      return rectangle1;
    }

    internal static IntPtr GetProcessWindow(string appName)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WindowHelper.\u003C\u003Ec__DisplayClass22_0 cDisplayClass220 = new WindowHelper.\u003C\u003Ec__DisplayClass22_0();
label_1:
      int num1 = 302328900;
      while (true)
      {
        int num2 = 1380275029;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass220.appName = appName;
            num1 = (int) num3 * -1130059083 ^ 1763113728;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      IntPtr num4;
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        cDisplayClass220.appName = WindowHelper.\u206A⁬​⁯‍‮⁭⁮⁫‏⁬‪‪​⁬⁯‬‬⁪⁮‮⁪⁪‭‌⁮⁯‬⁮‍‎‪⁬‎‬⁫‏‏‪⁪‮(cDisplayClass220.appName);
label_6:
        int num2 = 429325660;
        while (true)
        {
          int num3 = 1380275029;
          uint num5;
          bool flag;
          List<Process> list;
          Process process;
          switch ((num5 = (uint) (num2 ^ num3)) % 9U)
          {
            case 0:
              num4 = WindowHelper.\u206D‌‮⁮‍‌⁯‮‌⁮‌⁮‍⁮‍‮‮‎‭⁫‌⁭​‭⁪⁬‫⁯‎​⁫⁭​‬‌⁮⁬‮‏⁮‮(process);
              num2 = (int) num5 * 407790782 ^ -1289870006;
              continue;
            case 1:
              num2 = 640801612;
              continue;
            case 2:
              flag = process != null;
              num2 = (int) num5 * -1378218670 ^ -796936149;
              continue;
            case 4:
              // ISSUE: method pointer
              process = (Process) Enumerable.FirstOrDefault<Process>((IEnumerable<M0>) list, (Func<M0, bool>) new Func<Process, bool>((object) cDisplayClass220, __methodptr(\u003CGetProcessWindow\u003Eb__0)));
              num2 = (int) num5 * 353226923 ^ -375397054;
              continue;
            case 5:
              goto label_6;
            case 6:
              int num6 = !flag ? 1265424566 : (num6 = 1550332889);
              int num7 = (int) num5 * -1090889081;
              num2 = num6 ^ num7;
              continue;
            case 7:
              list = ((IEnumerable<Process>) WindowHelper.\u200E‏​‍‌‪‍‌⁫⁫‍⁭⁮‌‏‮⁪⁪⁬⁫⁬⁪‫‌⁯⁬⁪‎‫‮‮‍‏‮⁪‮‬⁫⁫‬‮()).ToList<Process>();
              num2 = (int) num5 * -963963575 ^ 101265008;
              continue;
            case 8:
              goto label_19;
            default:
              goto label_15;
          }
        }
      }
      catch (Exception ex)
      {
      }
label_15:
      num4 = IntPtr.Zero;
label_16:
      int num8 = 1937263309;
      while (true)
      {
        int num2 = 1380275029;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 3U)
        {
          case 1:
            num8 = (int) num3 * -1254821379 ^ 2084636062;
            continue;
          case 2:
            goto label_16;
          default:
            goto label_19;
        }
      }
label_19:
      return num4;
    }

    public static void ForceForeground(IntPtr handle)
    {
label_1:
      int num1 = -1187738684;
      while (true)
      {
        int num2 = -30331469;
        uint num3;
        IntPtr windowThreadProcessId;
        IntPtr idAttachTo;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_3;
          case 1:
            NativeMethods.BringWindowToTop(handle);
            NativeMethods.ShowWindow(handle, WindowShowStyle.Show);
            num1 = -420770736;
            continue;
          case 2:
            num1 = (int) num3 * -1660059112 ^ 901268648;
            continue;
          case 3:
            goto label_1;
          case 4:
            NativeMethods.AttachThreadInput(new IntPtr(6), idAttachTo, 1);
            NativeMethods.BringWindowToTop(handle);
            num1 = (int) num3 * -141740300 ^ -1826069918;
            continue;
          case 5:
            NativeMethods.AttachThreadInput(windowThreadProcessId, idAttachTo, 0);
            num1 = (int) num3 * 1756096834 ^ -1712820694;
            continue;
          case 6:
            int num4 = windowThreadProcessId != idAttachTo ? 2097736005 : (num4 = 1380143382);
            int num5 = (int) num3 * 1075084727;
            num1 = num4 ^ num5;
            continue;
          case 7:
            windowThreadProcessId = NativeMethods.GetWindowThreadProcessId(NativeMethods.GetForegroundWindow(), IntPtr.Zero);
            idAttachTo = new IntPtr((long) NativeMethods.GetCurrentThreadId());
            num1 = (int) num3 * -1010879692 ^ -893154606;
            continue;
          case 8:
            NativeMethods.ShowWindow(handle, WindowShowStyle.Show);
            num1 = (int) num3 * 1911006141 ^ -67987420;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
    {
      bool flag = IntPtr.Size == 8;
label_1:
      int num1 = -558252974;
      IntPtr num2;
      while (true)
      {
        int num3 = -489115272;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num4 * 713537613 ^ 235897536;
            continue;
          case 2:
            int num5 = !flag ? 1923475519 : (num5 = 1396598770);
            int num6 = (int) num4 * 276142769;
            num1 = num5 ^ num6;
            continue;
          case 3:
            num2 = new IntPtr(NativeMethods.SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
            num1 = -773984457;
            continue;
          case 4:
            num2 = NativeMethods.SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            num1 = (int) num4 * 1108781852 ^ -1877423869;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return num2;
    }

    internal static unsafe void GetWindowItemInformation(IntPtr handle, out string itemType, out string[] itemStrings, out string[] itemStyles, out IntPtr itemHandle)
    {
label_1:
      int num1 = 1763752903;
      while (true)
      {
        int num2 = 1271542647;
        uint num3;
        int index;
        IntPtr lpBuffer;
        byte* numPtr;
        IntPtr lpNumberOfBytesRead;
        string str;
        int lpNumberOfBytesWritten;
        bool flag1;
        TBBUTTONINFO* tbbuttoninfoPtr;
        bool flag2;
        string[] strArray1;
        uint uIDItem;
        StringBuilder lpString;
        uint lpdwProcessId;
        IntPtr num4;
        string[] strArray2;
        IntPtr num5;
        long int64;
        int length;
        int num6;
        IntPtr num7;
        bool flag3;
        bool flag4;
        string empty;
        IntPtr hMenu;
        IntPtr num8;
        TBBUTTON* tbbuttonPtr;
        bool flag5;
        bool flag6;
        bool flag7;
        switch ((num3 = (uint) (num1 ^ num2)) % 78U)
        {
          case 0:
            int num9;
            num1 = num9 = ((uint) tbbuttoninfoPtr->fsStyle & 128U) > 0U ? 286496445 : (num9 = 1537400068);
            continue;
          case 1:
            num1 = (int) num3 * 795346092 ^ 558345881;
            continue;
          case 2:
            empty += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2510524541U);
            num1 = (int) num3 * -739879395 ^ 1600416950;
            continue;
          case 3:
            strArray1 = new string[0];
            num8 = IntPtr.Zero;
            num1 = (int) num3 * -389455107 ^ -1001820437;
            continue;
          case 4:
            str = string.Empty;
            num1 = (int) num3 * -1442802772 ^ 1411594404;
            continue;
          case 5:
            lpString = new StringBuilder(128);
            num1 = (int) num3 * -1446168555 ^ 1853379809;
            continue;
          case 6:
            lpBuffer = new IntPtr((void*) numPtr);
            lpNumberOfBytesRead = new IntPtr(0);
            num1 = (int) num3 * -499786143 ^ 368631335;
            continue;
          case 7:
            lpNumberOfBytesWritten = (int) User32.GetMenuItemCount(hMenu);
            num1 = (int) num3 * 1113563474 ^ 1076207052;
            continue;
          case 8:
            goto label_3;
          case 9:
            num1 = (int) num3 * -1147431069 ^ -621125215;
            continue;
          case 10:
            goto label_1;
          case 11:
            flag6 = empty.Length > 2;
            num1 = 1056943891;
            continue;
          case 12:
            int num10 = !flag6 ? -208648313 : (num10 = -1356813596);
            int num11 = (int) num3 * -751772043;
            num1 = num10 ^ num11;
            continue;
          case 13:
            itemStrings = strArray2;
            itemHandle = num8;
            num1 = (int) num3 * 199339116 ^ 1216310899;
            continue;
          case 14:
            num5 = User32.SendMessage(handle, 1087U, (IntPtr) num6, num7);
            num1 = (int) num3 * 269428198 ^ -929575403;
            continue;
          case 15:
            int num12;
            num1 = num12 = ((uint) tbbuttoninfoPtr->fsStyle & 16U) <= 0U ? 1093782533 : (num12 = 1563512061);
            continue;
          case 16:
            num1 = (int) num3 * -1961160922 ^ -1787425697;
            continue;
          case 17:
            flag4 = Kernel32.ReadProcessMemory(num4, num7, lpBuffer, 4096U, lpNumberOfBytesRead);
            num1 = (int) num3 * -1979738899 ^ -423475833;
            continue;
          case 18:
            flag5 = (long) uIDItem < (long) lpNumberOfBytesWritten;
            num1 = 1856701362;
            continue;
          case 19:
            ++uIDItem;
            num1 = (int) num3 * 945589767 ^ 581902928;
            continue;
          case 20:
            int num13 = lpNumberOfBytesWritten == -1 ? -115499914 : (num13 = -1200207228);
            int num14 = (int) num3 * 1538540020;
            num1 = num13 ^ num14;
            continue;
          case 21:
            strArray2[index] = Marshal.PtrToStringUni((IntPtr) ((void*) numPtr), lpNumberOfBytesWritten);
            num1 = (int) num3 * -1169894593 ^ -1020013175;
            continue;
          case 22:
            lpNumberOfBytesWritten = (int) User32.SendMessage(handle, 1099U, (IntPtr) num6, num7);
            num1 = (int) num3 * 1559692405 ^ -113556659;
            continue;
          case 23:
            strArray1 = new string[lpNumberOfBytesWritten];
            uIDItem = 0U;
            num1 = (int) num3 * 998716716 ^ -887959488;
            continue;
          case 24:
            User32.GetWindowThreadProcessId(handle, out lpdwProcessId);
            num1 = (int) num3 * 894062826 ^ -238712028;
            continue;
          case 25:
            num1 = 1229373440;
            continue;
          case 26:
            lpNumberOfBytesWritten = (int) User32.SendMessage(handle, 1047U, (IntPtr) index, num7);
            num1 = (int) num3 * -2042126424 ^ 543892855;
            continue;
          case 27:
            length = (int) User32.SendMessage(handle, 1048U, 0U, 0U);
            flag7 = length > 0;
            num1 = (int) num3 * -1663669622 ^ -1437298430;
            continue;
          case 28:
            empty += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1567693563U);
            num1 = (int) num3 * -1913837053 ^ -577704293;
            continue;
          case 29:
            int num15 = flag7 ? -1149133813 : (num15 = -940657933);
            int num16 = (int) num3 * 441399571;
            num1 = num15 ^ num16;
            continue;
          case 30:
            num6 = tbbuttonPtr->idCommand;
            num1 = (int) num3 * 2068376385 ^ -89962327;
            continue;
          case 31:
            num1 = 1043880483;
            continue;
          case 32:
            int num17 = !flag1 ? 1408880747 : (num17 = 439238081);
            int num18 = (int) num3 * -1120422562;
            num1 = num17 ^ num18;
            continue;
          case 33:
            tbbuttoninfoPtr = (TBBUTTONINFO*) numPtr;
            num6 = 0;
            num1 = (int) num3 * -300579007 ^ 504510162;
            continue;
          case 34:
            num1 = 219261552;
            continue;
          case 35:
            num1 = (int) num3 * -808354157 ^ 382767402;
            continue;
          case 36:
            num1 = (int) num3 * -69920306 ^ -20399841;
            continue;
          case 37:
            empty += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2117251953U);
            num1 = (int) num3 * 672042995 ^ -1153629367;
            continue;
          case 38:
            num7 = Kernel32.VirtualAllocEx(num4, IntPtr.Zero, new UIntPtr(4096U), 4096U, 4U);
            tbbuttonPtr = (TBBUTTON*) numPtr;
            num1 = (int) num3 * -1691433965 ^ -257816732;
            continue;
          case 39:
            flag4 = Kernel32.WriteProcessMemory(num4, num7, lpBuffer, (uint) sizeof (TBBUTTONINFO), out lpNumberOfBytesWritten);
            num1 = (int) num3 * 1385754363 ^ 1127497898;
            continue;
          case 40:
            flag1 = lpNumberOfBytesWritten == 0;
            num1 = (int) num3 * 1572050539 ^ 2088774349;
            continue;
          case 41:
            Kernel32.VirtualFreeEx(num4, num7, UIntPtr.Zero, 32768U);
            Kernel32.CloseHandle(num4);
            num1 = (int) num3 * -1282726043 ^ -170638287;
            continue;
          case 42:
            num1 = (int) num3 * -482843345 ^ -1086136290;
            continue;
          case 43:
            str = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2846500696U);
            num1 = (int) num3 * -1908825813 ^ -27709476;
            continue;
          case 44:
            hMenu = User32.SendMessage(handle, 481U, IntPtr.Zero, IntPtr.Zero);
            num1 = (int) num3 * 1230222243 ^ 1308363247;
            continue;
          case 45:
            int menuString = (int) User32.GetMenuString(hMenu, uIDItem, lpString, lpString.Capacity, 1024U);
            strArray1[(int) uIDItem] = lpString.ToString();
            num1 = (int) num3 * -708813490 ^ 335520588;
            continue;
          case 46:
            int num19;
            num1 = num19 = index >= length ? 1766300044 : (num19 = 1148466160);
            continue;
          case 47:
            str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3059864303U);
            num1 = (int) num3 * 2085153598 ^ 843938850;
            continue;
          case 48:
            num1 = 2006493122;
            continue;
          case 49:
            int num20;
            num1 = num20 = ((uint) tbbuttoninfoPtr->fsStyle & 8U) <= 0U ? 262500284 : (num20 = 1689160293);
            continue;
          case 50:
            flag2 = lpNumberOfBytesWritten < 4096;
            num1 = 1755614781;
            continue;
          case 51:
            num1 = 1612261827;
            continue;
          case 52:
            index = 0;
            num1 = (int) num3 * 329219888 ^ 1845111819;
            continue;
          case 53:
            strArray2 = new string[0];
            num1 = (int) num3 * 1036335327 ^ -237391231;
            continue;
          case 54:
            int64 = num5.ToInt64();
            num1 = (int) num3 * -1241400341 ^ 510337772;
            continue;
          case 55:
            strArray2 = new string[length];
            num1 = (int) num3 * 327005926 ^ -1994566694;
            continue;
          case 56:
            tbbuttoninfoPtr->cbSize = (uint) Marshal.SizeOf(typeof (TBBUTTONINFO));
            tbbuttoninfoPtr->dwMask = 72U;
            num1 = (int) num3 * -1239305019 ^ -1167873264;
            continue;
          case 57:
            num1 = 1503977905;
            continue;
          case 58:
            num1 = (int) num3 * 1631278655 ^ 1455084848;
            continue;
          case 59:
            num1 = (int) num3 * -142054994 ^ -1879212840;
            continue;
          case 60:
            int num21 = !flag2 ? -1791191767 : (num21 = -1019704772);
            int num22 = (int) num3 * -797452171;
            num1 = num21 ^ num22;
            continue;
          case 61:
            strArray1[index] = empty.Substring(2);
            num1 = (int) num3 * 1572500435 ^ 1465281302;
            continue;
          case 62:
            empty += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3586962582U);
            num1 = (int) num3 * 118993592 ^ 1467564084;
            continue;
          case 63:
            itemType = str;
            itemStyles = strArray1;
            num1 = 1150203920;
            continue;
          case 64:
            num1 = (int) num3 * 2068232405 ^ -391511406;
            continue;
          case 65:
            strArray1 = new string[length];
            lpdwProcessId = 0U;
            num1 = (int) num3 * -194462675 ^ -518254840;
            continue;
          case 66:
            flag4 = Kernel32.ReadProcessMemory(num4, num7, lpBuffer, (uint) sizeof (TBBUTTON), lpNumberOfBytesRead);
            num1 = 817414935;
            continue;
          case 67:
            num4 = Kernel32.OpenProcess(2035711U, false, lpdwProcessId);
            numPtr = stackalloc byte[4096];
            num1 = (int) num3 * 265696885 ^ -398750666;
            continue;
          case 68:
            flag3 = User32.IsMenu(hMenu);
            num1 = (int) num3 * -1745457643 ^ -245600377;
            continue;
          case 69:
            flag4 = Kernel32.ReadProcessMemory(num4, num7, lpBuffer, (uint) sizeof (TBBUTTONINFO), lpNumberOfBytesRead);
            empty = string.Empty;
            int num23 = ((uint) tbbuttoninfoPtr->fsStyle & 1U) <= 0U ? -609397935 : (num23 = -376807403);
            int num24 = (int) num3 * -2008189431;
            num1 = num23 ^ num24;
            continue;
          case 70:
            int num25 = flag3 ? 1309856671 : (num25 = 756328338);
            int num26 = (int) num3 * -1765320622;
            num1 = num25 ^ num26;
            continue;
          case 71:
            lpNumberOfBytesWritten = 0;
            num1 = 669456875;
            continue;
          case 72:
            num8 = hMenu;
            num1 = (int) num3 * -150676435 ^ 1134773740;
            continue;
          case 73:
            int num27 = flag5 ? -745366029 : (num27 = -798452181);
            int num28 = (int) num3 * -1838812370;
            num1 = num27 ^ num28;
            continue;
          case 74:
            num1 = (int) num3 * -1122796166 ^ 1796486485;
            continue;
          case 75:
            int num29 = int64 == -1L ? -918942206 : (num29 = -934345688);
            int num30 = (int) num3 * 108476096;
            num1 = num29 ^ num30;
            continue;
          case 76:
            ++index;
            num1 = 1092061389;
            continue;
          case 77:
            numPtr[lpNumberOfBytesWritten] = (byte) 0;
            ++lpNumberOfBytesWritten;
            num1 = 595934359;
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
      IntPtr ZeroOnly = NativeMethods.FindWindow(ModuleName, MainWindowTitle);
      bool flag = ZeroOnly.Equals((object) IntPtr.Zero);
label_1:
      int num1 = -194704938;
      IntPtr num2;
      while (true)
      {
        int num3 = -929564815;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 12U)
        {
          case 0:
            num1 = (int) num4 * -283926672 ^ -757758764;
            continue;
          case 1:
            num2 = ZeroOnly;
            num1 = -2132975373;
            continue;
          case 2:
            num1 = (int) num4 * 650458835 ^ -1586556680;
            continue;
          case 3:
            int num5 = flag ? 77778062 : (num5 = 1710094699);
            int num6 = (int) num4 * -1552169119;
            num1 = num5 ^ num6;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num7 = !ZeroOnly.Equals((object) IntPtr.Zero) ? -1484641791 : (num7 = -1260111481);
            int num8 = (int) num4 * 863109220;
            num1 = num7 ^ num8;
            continue;
          case 6:
            num2 = new IntPtr(0);
            num1 = (int) num4 * -674456199 ^ -1306233391;
            continue;
          case 7:
            ZeroOnly = NativeMethods.FindWindowByCaption(ZeroOnly, MainWindowTitle);
            num1 = (int) num4 * -873994861 ^ -357519807;
            continue;
          case 8:
            num1 = -1706855966;
            continue;
          case 9:
            int num9 = string.IsNullOrEmpty(MainWindowTitle) ? 1559061012 : (num9 = 1452575513);
            int num10 = (int) num4 * -1106350786;
            num1 = num9 ^ num10;
            continue;
          case 11:
            num1 = -827410644;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return num2;
    }

    public static bool IsWindowVisible(IntPtr handle)
    {
label_1:
      int num1 = -1295189629;
      bool flag;
      while (true)
      {
        int num2 = -1993643206;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = WindowHelper.IsMinimized(handle) ? -335392356 : (num4 = -105880201);
            int num5 = (int) num3 * 64039058;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * -821358774 ^ 391002541;
            continue;
          case 4:
            flag = false;
            num1 = (int) num3 * -1063079142 ^ 687150944;
            continue;
          case 5:
            flag = NativeMethods.IsWindowVisible(handle);
            num1 = (int) num3 * 1301843789 ^ -1802341579;
            continue;
          case 6:
            num1 = (int) num3 * 220178005 ^ 1771946591;
            continue;
          case 7:
            num1 = -208544801;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return flag;
    }

    public static bool SetForegroundWindow(IntPtr handle)
    {
label_1:
      int num1 = -779571760;
      bool flag;
      while (true)
      {
        int num2 = -297790039;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * 432470123 ^ 1288995214;
            continue;
          case 1:
            int num4 = NativeMethods.IsWindow(handle) ? -644280820 : (num4 = -2086829962);
            int num5 = (int) num3 * -1883851253;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag = false;
            num1 = (int) num3 * 1392143942 ^ 1544925515;
            continue;
          case 4:
            num1 = -1979210662;
            continue;
          case 5:
            num1 = (int) num3 * 1954271066 ^ -2088384708;
            continue;
          case 6:
            flag = NativeMethods.SetForegroundWindow(handle);
            num1 = (int) num3 * 1321516225 ^ -1883544102;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return flag;
    }

    internal static string GetWindowStyles(IntPtr handle)
    {
label_1:
      int num1 = 940583008;
      string str1;
      while (true)
      {
        int num2 = 122243962;
        uint num3;
        long int64;
        bool flag1;
        IntPtr windowLongPtr;
        string str2;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        switch ((num3 = (uint) (num1 ^ num2)) % 52U)
        {
          case 0:
            int num4 = flag1 ? -337591742 : (num4 = -1263597620);
            int num5 = (int) num3 * 425472760;
            num1 = num4 ^ num5;
            continue;
          case 1:
            int num6;
            num1 = num6 = ((ulong) int64 & 67108864UL) <= 0UL ? 1279994911 : (num6 = 1296177566);
            continue;
          case 2:
            str2 += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1269046029U);
            num1 = (int) num3 * 1164082629 ^ 673493664;
            continue;
          case 3:
            str2 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(547024590U);
            num1 = (int) num3 * 1004400377 ^ -1515469242;
            continue;
          case 4:
            int num7 = !flag7 ? 340207226 : (num7 = 1895813281);
            int num8 = (int) num3 * -242306835;
            num1 = num7 ^ num8;
            continue;
          case 5:
            int num9 = !flag4 ? -2120246058 : (num9 = -849310812);
            int num10 = (int) num3 * 1283824438;
            num1 = num9 ^ num10;
            continue;
          case 6:
            str2 += \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1580307124U);
            num1 = (int) num3 * -874875936 ^ 1275502392;
            continue;
          case 7:
            str2 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(382802394U);
            num1 = (int) num3 * -69122986 ^ -805525972;
            continue;
          case 8:
            int num11;
            num1 = num11 = ((ulong) int64 & 2097152UL) > 0UL ? 1621287997 : (num11 = 2085924689);
            continue;
          case 9:
            int num12 = !flag2 ? -797610956 : (num12 = -862101319);
            int num13 = (int) num3 * 1787814184;
            num1 = num12 ^ num13;
            continue;
          case 10:
            str2 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(862634100U);
            num1 = (int) num3 * 1361483943 ^ -1775873980;
            continue;
          case 11:
            str2 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(579438688U);
            num1 = (int) num3 * 1028390172 ^ 817492215;
            continue;
          case 12:
            int num14 = !flag3 ? -1723444908 : (num14 = -1501036150);
            int num15 = (int) num3 * -877130979;
            num1 = num14 ^ num15;
            continue;
          case 13:
            str2 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2770201895U);
            num1 = (int) num3 * -460864943 ^ 184720491;
            continue;
          case 14:
            flag2 = ((ulong) int64 & 1073741824UL) > 0UL;
            num1 = 1696694055;
            continue;
          case 15:
            int num16 = ((ulong) int64 & 2147483648UL) > 0UL ? 2052984793 : (num16 = 310327129);
            int num17 = (int) num3 * -1898549289;
            num1 = num16 ^ num17;
            continue;
          case 16:
            int64 = windowLongPtr.ToInt64();
            int num18 = (ulong) int64 > 0UL ? -867035741 : (num18 = -1388730271);
            int num19 = (int) num3 * -1232117223;
            num1 = num18 ^ num19;
            continue;
          case 17:
            flag5 = ((ulong) int64 & 33554432UL) > 0UL;
            num1 = 918020228;
            continue;
          case 18:
            int num20;
            num1 = num20 = ((ulong) int64 & 65536UL) <= 0UL ? 576130461 : (num20 = 1010419977);
            continue;
          case 19:
            str2 += \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(344929063U);
            num1 = (int) num3 * -1461904126 ^ -1533824155;
            continue;
          case 20:
            str2 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1849855158U);
            num1 = (int) num3 * 1495749528 ^ -887222401;
            continue;
          case 21:
            int num21;
            num1 = num21 = ((ulong) int64 & 262144UL) > 0UL ? 336664377 : (num21 = 826971815);
            continue;
          case 22:
            int num22;
            num1 = num22 = ((ulong) int64 & 16777216UL) > 0UL ? 109365107 : (num22 = 971357362);
            continue;
          case 23:
            str2 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2247942276U);
            num1 = (int) num3 * 590806980 ^ 2119648269;
            continue;
          case 24:
            flag7 = ((ulong) int64 & 8388608UL) > 0UL;
            num1 = 1849557926;
            continue;
          case 25:
            str2 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4196382365U);
            num1 = (int) num3 * -851159848 ^ -1949618123;
            continue;
          case 26:
            num1 = (int) num3 * 460258144 ^ -1443343689;
            continue;
          case 27:
            str1 = str2;
            num1 = 1047040624;
            continue;
          case 28:
            str2 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1822297512U);
            num1 = (int) num3 * 2132403106 ^ 794172572;
            continue;
          case 29:
            num1 = (int) num3 * -1604578015 ^ -2015988716;
            continue;
          case 30:
            int num23 = !flag5 ? -949177682 : (num23 = -2111778599);
            int num24 = (int) num3 * -1086897133;
            num1 = num23 ^ num24;
            continue;
          case 31:
            str2 += \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2392701228U);
            num1 = (int) num3 * -1434029287 ^ 66817732;
            continue;
          case 32:
            int num25;
            num1 = num25 = ((ulong) int64 & 4194304UL) > 0UL ? 1969049396 : (num25 = 326751398);
            continue;
          case 33:
            str2 += \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1791356788U);
            num1 = (int) num3 * 650263251 ^ -195025713;
            continue;
          case 34:
            flag4 = ((ulong) int64 & 536870912UL) > 0UL;
            num1 = 634134543;
            continue;
          case 35:
            str2 += \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1267665717U);
            num1 = (int) num3 * -1348621006 ^ 600488474;
            continue;
          case 36:
            int num26;
            num1 = num26 = ((ulong) int64 & 134217728UL) > 0UL ? 646597601 : (num26 = 1022698323);
            continue;
          case 37:
            flag6 = ((ulong) int64 & 131072UL) > 0UL;
            num1 = 1948043999;
            continue;
          case 38:
            str2 = string.Empty;
            windowLongPtr = User32.GetWindowLongPtr(handle, -16);
            num1 = (int) num3 * 1734401690 ^ 487381390;
            continue;
          case 39:
            str2 = (str2 + \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2784982583U)).Remove(0, 2);
            num1 = 476038066;
            continue;
          case 40:
            str2 += \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1070462624U);
            num1 = (int) num3 * 1091784739 ^ 1168502568;
            continue;
          case 42:
            goto label_1;
          case 43:
            flag3 = ((ulong) int64 & 1048576UL) > 0UL;
            num1 = 940608966;
            continue;
          case 44:
            str2 += \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1852426096U);
            num1 = (int) num3 * -2005130328 ^ -1786646152;
            continue;
          case 45:
            int num27 = !flag6 ? -757893274 : (num27 = -1296548764);
            int num28 = (int) num3 * -530522303;
            num1 = num27 ^ num28;
            continue;
          case 46:
            int num29;
            num1 = num29 = ((ulong) int64 & 268435456UL) > 0UL ? 566035484 : (num29 = 294521806);
            continue;
          case 47:
            str2 += \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1144124664U);
            num1 = (int) num3 * -1916253548 ^ -2074992101;
            continue;
          case 48:
            num1 = (int) num3 * 662861294 ^ 894358337;
            continue;
          case 49:
            int num30;
            num1 = num30 = ((ulong) int64 & 65536UL) <= 0UL ? 1123957901 : (num30 = 2043563471);
            continue;
          case 50:
            int num31;
            num1 = num31 = ((ulong) int64 & 524288UL) <= 0UL ? 984359911 : (num31 = 781045473);
            continue;
          case 51:
            flag1 = ((ulong) int64 & 131072UL) > 0UL;
            num1 = 519335422;
            continue;
          default:
            goto label_53;
        }
      }
label_53:
      return str1;
    }

    internal static string GetWindowExtendedStyles(IntPtr handle)
    {
      string str1 = string.Empty;
label_1:
      int num1 = 291112925;
      string str2;
      while (true)
      {
        int num2 = 469687093;
        uint num3;
        bool flag1;
        int windowLongPtr;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        bool flag8;
        bool flag9;
        bool flag10;
        bool flag11;
        bool flag12;
        bool flag13;
        bool flag14;
        bool flag15;
        bool flag16;
        switch ((num3 = (uint) (num1 ^ num2)) % 72U)
        {
          case 0:
            int num4 = flag13 ? 1998230611 : (num4 = 1175705259);
            int num5 = (int) num3 * -1337910268;
            num1 = num4 ^ num5;
            continue;
          case 1:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3436397867U));
            num1 = (int) num3 * 1395220198 ^ 361596302;
            continue;
          case 2:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1156444373U));
            num1 = (int) num3 * 811551068 ^ 1981688409;
            continue;
          case 3:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2446944674U));
            num1 = (int) num3 * 1069529140 ^ 1516412215;
            continue;
          case 4:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2127761536U));
            num1 = (int) num3 * -1673744352 ^ -655609533;
            continue;
          case 5:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(599829185U));
            num1 = (int) num3 * 1924661844 ^ -1105043333;
            continue;
          case 6:
            flag7 = ((ulong) windowLongPtr & 262144UL) > 0UL;
            num1 = 988035597;
            continue;
          case 7:
            int num6 = flag6 ? -211990055 : (num6 = -899591579);
            int num7 = (int) num3 * -2113123765;
            num1 = num6 ^ num7;
            continue;
          case 8:
            flag12 = ((ulong) windowLongPtr & 4096UL) > 0UL;
            num1 = 1667929195;
            continue;
          case 9:
            str1 = WindowHelper.\u200E‍‫‬‌⁯‎‭⁮⁪‌‪⁮‫‍‌‭⁬‮⁭‪‪‌‬⁮‪⁭‪⁮‎⁭⁮⁫‮⁫‮‏‬‪‎‮(str1, 0, 2);
            num1 = 1464051752;
            continue;
          case 10:
            int num8 = flag3 ? 1898211759 : (num8 = 1584058266);
            int num9 = (int) num3 * 1207849161;
            num1 = num8 ^ num9;
            continue;
          case 11:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3019012620U));
            num1 = (int) num3 * -717330806 ^ 2037424535;
            continue;
          case 13:
            flag8 = ((ulong) windowLongPtr & 128UL) > 0UL;
            num1 = 1992678804;
            continue;
          case 14:
            flag10 = ((ulong) windowLongPtr & 134217728UL) > 0UL;
            num1 = 98167234;
            continue;
          case 15:
            int num10 = flag4 ? -22591462 : (num10 = -364046713);
            int num11 = (int) num3 * 253469451;
            num1 = num10 ^ num11;
            continue;
          case 16:
            flag11 = ((ulong) windowLongPtr & 0UL) > 0UL;
            num1 = 424788692;
            continue;
          case 17:
            flag2 = ((ulong) windowLongPtr & 65536UL) > 0UL;
            num1 = 132632960;
            continue;
          case 18:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1000388454U));
            num1 = (int) num3 * 418229414 ^ -1854519423;
            continue;
          case 19:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3219259439U));
            num1 = (int) num3 * 1449046350 ^ -1885411285;
            continue;
          case 20:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1373582801U));
            num1 = (int) num3 * -1350669299 ^ -1923228191;
            continue;
          case 21:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1205978224U));
            num1 = (int) num3 * -981816991 ^ -1919887516;
            continue;
          case 22:
            int num12;
            num1 = num12 = ((ulong) windowLongPtr & 256UL) <= 0UL ? 286083973 : (num12 = 366312739);
            continue;
          case 23:
            int num13;
            num1 = num13 = ((ulong) windowLongPtr & 1048576UL) <= 0UL ? 1043661398 : (num13 = 1337607886);
            continue;
          case 24:
            flag15 = ((ulong) windowLongPtr & 512UL) > 0UL;
            num1 = 773846274;
            continue;
          case 25:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(43996704U));
            num1 = (int) num3 * -192548676 ^ -1438836524;
            continue;
          case 26:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(797092864U));
            num1 = (int) num3 * -1625471724 ^ -888199728;
            continue;
          case 27:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(727973280U));
            num1 = (int) num3 * 1299659318 ^ 1754129889;
            continue;
          case 28:
            flag3 = ((ulong) windowLongPtr & 32UL) > 0UL;
            num1 = 56427247;
            continue;
          case 29:
            flag6 = ((ulong) windowLongPtr & 64UL) > 0UL;
            num1 = 191320818;
            continue;
          case 30:
            int num14 = !flag14 ? -215459281 : (num14 = -698593316);
            int num15 = (int) num3 * 52123500;
            num1 = num14 ^ num15;
            continue;
          case 31:
            int num16 = flag15 ? 136756174 : (num16 = 1758617058);
            int num17 = (int) num3 * 1975435910;
            num1 = num16 ^ num17;
            continue;
          case 32:
            int num18 = ((ulong) windowLongPtr & 1UL) <= 0UL ? 2000120953 : (num18 = 1774891582);
            int num19 = (int) num3 * -603080947;
            num1 = num18 ^ num19;
            continue;
          case 33:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2453469178U));
            num1 = (int) num3 * -241991096 ^ 2081915490;
            continue;
          case 34:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2268364379U));
            num1 = (int) num3 * 850509944 ^ -1183649870;
            continue;
          case 35:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(396459875U));
            num1 = (int) num3 * -1201379019 ^ -1959156319;
            continue;
          case 36:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(839116042U));
            num1 = (int) num3 * -150616467 ^ 733822894;
            continue;
          case 37:
            int num20 = !flag2 ? -1907932077 : (num20 = -2012613032);
            int num21 = (int) num3 * -361767459;
            num1 = num20 ^ num21;
            continue;
          case 38:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(734818766U));
            num1 = (int) num3 * -1196156639 ^ -1084373677;
            continue;
          case 39:
            int num22 = !flag10 ? -2127578813 : (num22 = -1502217656);
            int num23 = (int) num3 * 1450048617;
            num1 = num22 ^ num23;
            continue;
          case 40:
            int num24 = !flag16 ? 1223351562 : (num24 = 351920660);
            int num25 = (int) num3 * -1524473460;
            num1 = num24 ^ num25;
            continue;
          case 41:
            int num26 = flag8 ? -1534925892 : (num26 = -1446019615);
            int num27 = (int) num3 * 1244136114;
            num1 = num26 ^ num27;
            continue;
          case 42:
            str2 = str1;
            num1 = 1357204545;
            continue;
          case 43:
            int num28 = !flag9 ? -594622205 : (num28 = -1959645648);
            int num29 = (int) num3 * 81535956;
            num1 = num28 ^ num29;
            continue;
          case 44:
            flag4 = ((ulong) windowLongPtr & 0UL) > 0UL;
            num1 = 1043326362;
            continue;
          case 45:
            flag16 = ((ulong) windowLongPtr & 524288UL) > 0UL;
            num1 = 328501549;
            continue;
          case 46:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(507120746U));
            num1 = (int) num3 * -1946287684 ^ -2002056413;
            continue;
          case 47:
            flag9 = (uint) windowLongPtr > 0U;
            num1 = (int) num3 * 1854687954 ^ 424288800;
            continue;
          case 48:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3999172219U));
            num1 = (int) num3 * 330306591 ^ -361753376;
            continue;
          case 49:
            int num30 = !flag11 ? -1618760503 : (num30 = -469029685);
            int num31 = (int) num3 * -1426617115;
            num1 = num30 ^ num31;
            continue;
          case 50:
            int num32;
            num1 = num32 = ((ulong) windowLongPtr & 8UL) > 0UL ? 491248952 : (num32 = 1480884427);
            continue;
          case 51:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1296681416U));
            num1 = (int) num3 * -1580469246 ^ 92887546;
            continue;
          case 52:
            int num33 = !flag1 ? 641527243 : (num33 = 1080825222);
            int num34 = (int) num3 * 1692002376;
            num1 = num33 ^ num34;
            continue;
          case 53:
            int num35;
            num1 = num35 = ((ulong) windowLongPtr & 1024UL) <= 0UL ? 587108365 : (num35 = 585825111);
            continue;
          case 54:
            int num36 = !flag12 ? -1707955381 : (num36 = -1093485766);
            int num37 = (int) num3 * 361234039;
            num1 = num36 ^ num37;
            continue;
          case 55:
            goto label_1;
          case 56:
            windowLongPtr = (int) User32.GetWindowLongPtr(handle, -20);
            num1 = (int) num3 * 605678126 ^ -625503398;
            continue;
          case 57:
            num1 = (int) num3 * -2110252515 ^ -128755552;
            continue;
          case 58:
            int num38;
            num1 = num38 = ((ulong) windowLongPtr & 16384UL) > 0UL ? 796044697 : (num38 = 1686588253);
            continue;
          case 59:
            int num39 = !flag5 ? -1648178336 : (num39 = -123337065);
            int num40 = (int) num3 * 1640099395;
            num1 = num39 ^ num40;
            continue;
          case 60:
            flag14 = ((ulong) windowLongPtr & 0UL) > 0UL;
            num1 = 307675819;
            continue;
          case 61:
            num1 = (int) num3 * -824086568 ^ 1199298215;
            continue;
          case 62:
            int num41;
            num1 = num41 = ((ulong) windowLongPtr & 33554432UL) > 0UL ? 1297151673 : (num41 = 1225375939);
            continue;
          case 63:
            flag1 = ((ulong) windowLongPtr & 131072UL) > 0UL;
            num1 = 612428593;
            continue;
          case 64:
            int num42 = flag7 ? 54054927 : (num42 = 209263032);
            int num43 = (int) num3 * 149011060;
            num1 = num42 ^ num43;
            continue;
          case 65:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4105544505U));
            num1 = (int) num3 * -85712858 ^ -483329247;
            continue;
          case 66:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3006361191U));
            num1 = (int) num3 * -1027638096 ^ 1791920236;
            continue;
          case 67:
            flag13 = ((ulong) windowLongPtr & 4194304UL) > 0UL;
            num1 = 1051806797;
            continue;
          case 68:
            int num44;
            num1 = num44 = ((ulong) windowLongPtr & 4UL) <= 0UL ? 63871359 : (num44 = 1813963976);
            continue;
          case 69:
            str1 = WindowHelper.\u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1008239178U));
            num1 = (int) num3 * 27923184 ^ 968890107;
            continue;
          case 70:
            flag5 = ((ulong) windowLongPtr & 16UL) > 0UL;
            num1 = 436125822;
            continue;
          case 71:
            int num45;
            num1 = num45 = ((ulong) windowLongPtr & 8192UL) <= 0UL ? 910977921 : (num45 = 2139930191);
            continue;
          default:
            goto label_73;
        }
      }
label_73:
      return str2;
    }

    public static Screen GetScreen(string name)
    {
label_1:
      int num1 = 619598565;
      Screen screen1;
      while (true)
      {
        int num2 = 2115823702;
        uint num3;
        int index;
        Screen screen2;
        Screen[] screenArray;
        string str;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            int num4 = !WindowHelper.\u202E‫‫⁫⁪‮⁭‏‌⁫‪⁯​‮‪⁬‭‌‍​‍‏​‬‌⁯‌⁭‏​‬‎‌‮⁫‭​⁭‏‪‮(WindowHelper.\u202C⁪⁬⁮‏⁭‬‬‮‫‫⁪‭​‌‎⁯‍‫⁭‌‪‬⁯‮⁯‮⁬⁫​⁬⁬‍‮‭‭⁬⁭⁯‭‮(screen2), str) ? -1733536705 : (num4 = -1435591490);
            int num5 = (int) num3 * 1814992135;
            num1 = num4 ^ num5;
            continue;
          case 1:
            num1 = (int) num3 * -2034551845 ^ 242469726;
            continue;
          case 2:
            screen2 = screenArray[index];
            num1 = 1722358145;
            continue;
          case 3:
            screenArray = WindowHelper.\u200B‬⁫⁫⁬‌‮‍⁮⁭‏⁫‫‬⁫⁮‏‬⁭⁪⁬‎‌‬‏​‬‎‎⁯⁯‮‬‎‮‍⁮⁬⁭⁭‮();
            num1 = (int) num3 * -97924704 ^ -1908148660;
            continue;
          case 4:
            str = name;
            num1 = (int) num3 * -1074906550 ^ 1541311500;
            continue;
          case 5:
            num1 = 16250881;
            continue;
          case 7:
            screen1 = WindowHelper.\u202B‏⁮⁬⁯‫‏‪‫⁬⁬‬⁫‏‭⁯‫‭‌​⁮⁮‏‫⁮‭‍‬‪​‮‪⁫‌‎‭⁫⁫‫‭‮();
            num1 = (int) num3 * -291567649 ^ 310294239;
            continue;
          case 8:
            screen1 = screen2;
            num1 = (int) num3 * -401072980 ^ 477066259;
            continue;
          case 9:
            ++index;
            num1 = (int) num3 * 1967472140 ^ 2054365765;
            continue;
          case 10:
            int num6;
            num1 = num6 = index < screenArray.Length ? 954630648 : (num6 = 128238360);
            continue;
          case 11:
            index = 0;
            num1 = (int) num3 * 251609461 ^ 712542259;
            continue;
          case 12:
            goto label_1;
          default:
            goto label_14;
        }
      }
label_14:
      return screen1;
    }

    public static Bitmap PrintWindow(IntPtr hwnd)
    {
label_1:
      int num1 = 1663269601;
      Rectangle windowRectangle;
      while (true)
      {
        int num2 = 336428859;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            windowRectangle = WindowHelper.GetWindowRectangle(hwnd);
            num1 = (int) num3 * -2146589742 ^ 1123216308;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      Bitmap bitmap1 = new Bitmap(windowRectangle.Width, windowRectangle.Height);
      Graphics graphics = Graphics.FromImage((Image) bitmap1);
      try
      {
        IntPtr hdc = graphics.GetHdc();
        try
        {
          Win32.PrintWindow(hwnd, hdc, 0U);
        }
        finally
        {
label_8:
          int num2 = 1130387464;
          while (true)
          {
            int num3 = 336428859;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 1:
                graphics.ReleaseHdc(hdc);
                num2 = (int) num4 * 2097709289 ^ 969727721;
                continue;
              case 2:
                num2 = (int) num4 * -723127683 ^ -444684788;
                continue;
              case 3:
                goto label_8;
              case 4:
                num2 = (int) num4 * 1792729163 ^ 1909147708;
                continue;
              default:
                goto label_13;
            }
          }
label_13:;
        }
      }
      finally
      {
        if (graphics != null)
        {
label_15:
          int num2 = 1325054756;
          while (true)
          {
            int num3 = 336428859;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_15;
              case 1:
                num2 = (int) num4 * -352146722 ^ 222392619;
                continue;
              case 3:
                graphics.Dispose();
                num2 = (int) num4 * 1420679497 ^ -1590721307;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
      Bitmap bitmap2 = bitmap1;
label_21:
      int num5 = 525238070;
      while (true)
      {
        int num2 = 336428859;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_21;
          case 1:
            num5 = (int) num3 * -429271594 ^ -394249817;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      return bitmap2;
    }

    public static Bitmap GetWindowAsBitmap(IntPtr _handle, bool bBringForeground = true, int _leftPixel = 0, int _topPixel = 0, int _height = 0, int _width = 0)
    {
      Bitmap bitmap = (Bitmap) null;
      try
      {
        Rectangle windowRectangle = WindowHelper.GetWindowRectangle(_handle);
        if (!(windowRectangle != Rectangle.Empty))
          goto label_12;
label_2:
        int num1 = -605789136;
label_3:
        while (true)
        {
          int num2 = -1862077948;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              goto label_12;
            case 1:
              num1 = (int) num3 * 1125093327 ^ -2025305918;
              continue;
            case 2:
              flag = bBringForeground;
              num1 = (int) num3 * -224464056 ^ 1020754501;
              continue;
            case 3:
              num1 = (int) num3 * -1624287769 ^ -1060074351;
              continue;
            case 4:
              NativeMethods.SetForegroundWindow(_handle);
              num1 = (int) num3 * 1044768724 ^ 1662852065;
              continue;
            case 5:
              goto label_2;
            case 6:
              bitmap = new Bitmap(windowRectangle.Width, windowRectangle.Height, PixelFormat.Format32bppArgb);
              num1 = -1719945716;
              continue;
            case 7:
              bitmap.Tag = (object) _handle.ToString();
              num1 = (int) num3 * -1144831381 ^ 1538022974;
              continue;
            case 8:
              num1 = (int) num3 * 1838074471 ^ -1617522696;
              continue;
            case 9:
              int num4 = !flag ? 296907836 : (num4 = 1425257626);
              int num5 = (int) num3 * -1583195608;
              num1 = num4 ^ num5;
              continue;
            case 10:
              num1 = (int) num3 * -415240268 ^ 1937096724;
              continue;
            case 12:
              Graphics.FromImage((Image) bitmap).CopyFromScreen(windowRectangle.X, windowRectangle.Y, 0, 0, windowRectangle.Size, CopyPixelOperation.SourceCopy);
              num1 = (int) num3 * -429515854 ^ 1111942137;
              continue;
            case 13:
              num1 = (int) num3 * 1726858083 ^ 307754531;
              continue;
            default:
              goto label_20;
          }
        }
label_12:
        num1 = -731327207;
        goto label_3;
      }
      catch (Exception ex)
      {
label_17:
        int num1 = -1621173490;
        while (true)
        {
          int num2 = -1862077948;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_17;
            case 1:
              num1 = (int) num3 * -990152153 ^ -1796659213;
              continue;
            default:
              goto label_20;
          }
        }
      }
label_20:
      return bitmap;
    }

    public static bool IsWindowOverlapped(IntPtr hWnd, HashSet<IntPtr> ignoreHandles)
    {
      if (!(hWnd == IntPtr.Zero))
        goto label_5;
label_1:
      int num1 = -889863324;
label_2:
      bool flag1;
      bool flag2;
      while (true)
      {
        int num2 = -1025183492;
        uint num3;
        NativeMethods.RECT lpRect1;
        NativeMethods.RECT lpRect2;
        HashSet<IntPtr> numSet;
        bool flag3;
        NativeMethods.RECT lprcDst;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 27U)
        {
          case 0:
            flag2 = true;
            num1 = (int) num3 * -1833639621 ^ -827074226;
            continue;
          case 1:
            if ((hWnd = NativeMethods.GetWindow(hWnd, NativeMethods.GetWindow_Cmd.GW_HWNDPREV)) != IntPtr.Zero)
            {
              num1 = -1094281089;
              continue;
            }
            num4 = 0;
            break;
          case 3:
            num1 = (int) num3 * -2054859528 ^ -1931200687;
            continue;
          case 4:
            num5 = NativeMethods.IntersectRect(out lprcDst, ref lpRect2, ref lpRect1) ? 1 : 0;
            goto label_29;
          case 5:
            num6 = ignoreHandles.Contains(hWnd) ? 1 : 0;
            goto label_34;
          case 6:
            num1 = (int) num3 * 2138611840 ^ -1534535524;
            continue;
          case 7:
            if (NativeMethods.GetWindowRect(hWnd, out lpRect1))
            {
              num1 = (int) num3 * -1813242517 ^ -84479825;
              continue;
            }
            goto label_28;
          case 8:
            int num7 = !flag3 ? 550664789 : (num7 = 2088704635);
            int num8 = (int) num3 * 1485672213;
            num1 = num7 ^ num8;
            continue;
          case 9:
            if (WindowHelper.IsWindowVisible(hWnd))
            {
              num1 = (int) num3 * -766356912 ^ 1663634726;
              continue;
            }
            goto label_28;
          case 10:
            numSet = new HashSet<IntPtr>() { hWnd };
            num1 = -1680648812;
            continue;
          case 11:
            num1 = (int) num3 * 1433839647 ^ 1350447384;
            continue;
          case 12:
            flag2 = false;
            num1 = (int) num3 * 1613286566 ^ 86310375;
            continue;
          case 13:
            lprcDst = new NativeMethods.RECT();
            num1 = -173087773;
            continue;
          case 14:
            lpRect2 = new NativeMethods.RECT();
            num1 = (int) num3 * -1855375043 ^ -1268365584;
            continue;
          case 15:
            flag2 = false;
            num1 = (int) num3 * -1446915864 ^ 742206081;
            continue;
          case 16:
            goto label_5;
          case 17:
            NativeMethods.GetWindowRect(hWnd, out lpRect2);
            num1 = (int) num3 * 931243293 ^ -1782887142;
            continue;
          case 18:
            num4 = !numSet.Contains(hWnd) ? 1 : 0;
            break;
          case 19:
            goto label_1;
          case 20:
            num1 = -1548783204;
            continue;
          case 21:
            flag2 = false;
            num1 = (int) num3 * 359282113 ^ 1231343386;
            continue;
          case 22:
            int num9 = flag1 ? 1252865197 : (num9 = 1206975260);
            int num10 = (int) num3 * 569470743;
            num1 = num9 ^ num10;
            continue;
          case 23:
            lpRect1 = lprcDst;
            num1 = (int) num3 * 229536774 ^ -585197673;
            continue;
          case 24:
            num1 = (int) num3 * -1546810807 ^ -2002318846;
            continue;
          case 25:
            num1 = (int) num3 * 1202553838 ^ -727775889;
            continue;
          case 26:
            numSet.Add(hWnd);
            if (ignoreHandles != null)
            {
              num1 = -1310509753;
              continue;
            }
            num6 = 0;
            goto label_34;
          default:
            goto label_38;
        }
        int num11;
        num1 = num11 = num4 != 0 ? -1904668132 : (num11 = -1524797916);
        continue;
label_28:
        num5 = 0;
label_29:
        flag3 = num5 != 0;
        num1 = -888004246;
        continue;
label_34:
        int num12;
        num1 = num12 = num6 != 0 ? -12288430 : (num12 = -1325344584);
      }
label_38:
      return flag2;
label_5:
      flag1 = !WindowHelper.IsWindowVisible(hWnd);
      num1 = -1863827407;
      goto label_2;
    }

    internal static bool IsPixelColorMatching(IntPtr iHandle, int _x, int _y, int _R, int _B, int _G)
    {
label_1:
      int num1 = -1602331649;
      bool flag1;
      while (true)
      {
        int num2 = -1168350202;
        uint num3;
        bool flag2;
        Color pixelColor;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            if ((int) pixelColor.R == _R)
            {
              num1 = (int) num3 * 969952666 ^ 322169087;
              continue;
            }
            break;
          case 1:
            int num5 = flag3 ? -1814431385 : (num5 = -190364739);
            int num6 = (int) num3 * -1062124725;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num1 = (int) num3 * 843878921 ^ -787143262;
            continue;
          case 4:
            flag1 = flag2;
            num1 = -492737055;
            continue;
          case 5:
            if ((int) pixelColor.G == _G)
            {
              num1 = (int) num3 * -1628829927 ^ -1336989075;
              continue;
            }
            break;
          case 6:
            num4 = (int) pixelColor.B == _B ? 1 : 0;
            goto label_9;
          case 7:
            pixelColor = NativeMethods.GetPixelColor(_x, _y);
            num1 = (int) num3 * 184225073 ^ 1453946625;
            continue;
          case 8:
            goto label_1;
          case 9:
            flag2 = false;
            num1 = (int) num3 * -200207947 ^ -381230384;
            continue;
          case 10:
            flag2 = true;
            num1 = (int) num3 * -21888137 ^ 674863428;
            continue;
          case 11:
            num1 = (int) num3 * -845941125 ^ 1095018116;
            continue;
          default:
            goto label_17;
        }
        num4 = 0;
label_9:
        flag3 = num4 != 0;
        num1 = -753859293;
      }
label_17:
      return flag1;
    }

    internal static Rectangle GetScreenNonWorkingArea(Screen screen)
    {
label_1:
      int num1 = -1135756907;
      Rectangle rectangle1;
      while (true)
      {
        int num2 = -23204782;
        uint num3;
        Rectangle rectangle2;
        int num4;
        int num5;
        int num6;
        Rectangle rectangle3;
        int num7;
        bool flag1;
        bool flag2;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 56U)
        {
          case 0:
            num1 = (int) num3 * 880716737 ^ 516306071;
            continue;
          case 1:
            num1 = (int) num3 * 1107474978 ^ 8465895;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local1 = @rectangle2;
            rectangle3 = screen.Bounds;
            int top1 = rectangle3.Top;
            // ISSUE: explicit reference operation
            (^local1).Y = top1;
            num1 = (int) num3 * -1051284444 ^ -274295523;
            continue;
          case 3:
            num1 = -817154532;
            continue;
          case 4:
            flag3 = num7 > 0;
            num1 = -1996500051;
            continue;
          case 5:
            num1 = (int) num3 * -1762964219 ^ -1664316110;
            continue;
          case 6:
            rectangle2 = Rectangle.Empty;
            num1 = (int) num3 * -2050561773 ^ 1365293365;
            continue;
          case 7:
            rectangle2.Width = num4;
            num1 = (int) num3 * 111461287 ^ -405424919;
            continue;
          case 8:
            num1 = (int) num3 * 1854145803 ^ 1331318128;
            continue;
          case 9:
            num1 = (int) num3 * -378358144 ^ 1221684863;
            continue;
          case 11:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local2 = @rectangle2;
            rectangle3 = screen.Bounds;
            int height1 = rectangle3.Height;
            // ISSUE: explicit reference operation
            (^local2).Height = height1;
            num1 = (int) num3 * -886147545 ^ 530750335;
            continue;
          case 12:
            int num8 = Math.Abs(rectangle3.Left);
            rectangle3 = screen.WorkingArea;
            int num9 = Math.Abs(rectangle3.Left);
            num6 = Math.Abs(num8 - num9);
            num1 = (int) num3 * -2137162624 ^ -1193007098;
            continue;
          case 13:
            rectangle1 = rectangle2;
            num1 = -1191383528;
            continue;
          case 14:
            rectangle2.Height = num7;
            num1 = (int) num3 * 1112322955 ^ -801465680;
            continue;
          case 15:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local3 = @rectangle2;
            rectangle3 = screen.Bounds;
            int height2 = rectangle3.Height;
            // ISSUE: explicit reference operation
            (^local3).Height = height2;
            num1 = (int) num3 * 805314812 ^ 1473125030;
            continue;
          case 16:
            num1 = (int) num3 * -803751612 ^ -1053836855;
            continue;
          case 17:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local4 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int bottom = rectangle3.Bottom;
            // ISSUE: explicit reference operation
            (^local4).Y = bottom;
            num1 = (int) num3 * -537519718 ^ -709671762;
            continue;
          case 18:
            rectangle2 = new Rectangle();
            rectangle3 = WindowHelper.\u200F‍‮‫⁬‫⁭⁭‪‎‍⁯‫​‎‌‍⁯‎‪⁫‭⁪⁫⁪​‫⁫‌‮⁬‮‭⁭‫⁯⁮⁪‫‬‮(screen);
            num1 = (int) num3 * -1918545517 ^ 1036196320;
            continue;
          case 19:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local5 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int left1 = rectangle3.Left;
            // ISSUE: explicit reference operation
            (^local5).X = left1;
            num1 = (int) num3 * 2088104483 ^ -1065807674;
            continue;
          case 20:
            int num10 = num6 <= 0 ? 1827613229 : (num10 = 1471316866);
            int num11 = (int) num3 * 2128394642;
            num1 = num10 ^ num11;
            continue;
          case 21:
            num1 = -1861662996;
            continue;
          case 22:
            rectangle2.Width = num6;
            num1 = (int) num3 * 218434597 ^ 1845393199;
            continue;
          case 23:
            int num12 = !flag3 ? 1913549648 : (num12 = 1400850187);
            int num13 = (int) num3 * 10234216;
            num1 = num12 ^ num13;
            continue;
          case 24:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local6 = @rectangle2;
            rectangle3 = screen.Bounds;
            int top2 = rectangle3.Top;
            // ISSUE: explicit reference operation
            (^local6).Y = top2;
            num1 = (int) num3 * 1380202190 ^ -529732772;
            continue;
          case 25:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local7 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int right = rectangle3.Right;
            // ISSUE: explicit reference operation
            (^local7).X = right;
            num1 = (int) num3 * 324274172 ^ -948284107;
            continue;
          case 26:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local8 = @rectangle2;
            rectangle3 = screen.Bounds;
            int left2 = rectangle3.Left;
            // ISSUE: explicit reference operation
            (^local8).X = left2;
            num1 = (int) num3 * -84294117 ^ 150995604;
            continue;
          case 27:
            int num14 = rectangle3.Width - num6;
            rectangle3 = screen.WorkingArea;
            int width1 = rectangle3.Width;
            num4 = num14 - width1;
            num1 = (int) num3 * -1014723127 ^ 451476336;
            continue;
          case 28:
            num1 = (int) num3 * 63693038 ^ -1105287423;
            continue;
          case 29:
            int num15 = flag1 ? -437817639 : (num15 = -1151168269);
            int num16 = (int) num3 * 1377006891;
            num1 = num15 ^ num16;
            continue;
          case 30:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local9 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int width2 = rectangle3.Width;
            // ISSUE: explicit reference operation
            (^local9).Width = width2;
            num1 = (int) num3 * 1838862755 ^ 1933487449;
            continue;
          case 31:
            num1 = (int) num3 * 2135911123 ^ 1275353810;
            continue;
          case 32:
            num1 = (int) num3 * 1291759974 ^ -172864946;
            continue;
          case 33:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local10 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int left3 = rectangle3.Left;
            // ISSUE: explicit reference operation
            (^local10).X = left3;
            num1 = (int) num3 * -818808918 ^ 2055005272;
            continue;
          case 34:
            int num17;
            num1 = num17 = num5 <= 0 ? -915315977 : (num17 = -446775319);
            continue;
          case 35:
            num1 = -123862605;
            continue;
          case 36:
            num1 = (int) num3 * 784798776 ^ -1088504215;
            continue;
          case 37:
            int num18 = !rectangle3.Equals((object) WindowHelper.\u206C⁮‍⁪‌‭⁬‎‮‍‬⁫⁮⁬‏‬‫‭‭⁪⁪‮‏⁭⁯‬​​‎‮‫‎⁯⁯‭⁯⁪⁯‮⁮‮(screen)) ? -126533206 : (num18 = -732558621);
            int num19 = (int) num3 * 1422650978;
            num1 = num18 ^ num19;
            continue;
          case 38:
            rectangle2 = Rectangle.Empty;
            num1 = (int) num3 * -166995016 ^ -1230826343;
            continue;
          case 39:
            num1 = (int) num3 * -2131739668 ^ 165249586;
            continue;
          case 40:
            num1 = (int) num3 * 1059606019 ^ 1462825304;
            continue;
          case 41:
            rectangle3 = screen.Bounds;
            int num20 = rectangle3.Height - num7;
            rectangle3 = screen.WorkingArea;
            int height3 = rectangle3.Height;
            num5 = num20 - height3;
            num1 = (int) num3 * -60571837 ^ -1623167243;
            continue;
          case 42:
            num1 = (int) num3 * 925908151 ^ 1199904850;
            continue;
          case 43:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local11 = @rectangle2;
            rectangle3 = screen.Bounds;
            int top3 = rectangle3.Top;
            // ISSUE: explicit reference operation
            (^local11).Y = top3;
            num1 = (int) num3 * 537603302 ^ 541784273;
            continue;
          case 44:
            rectangle1 = Rectangle.Empty;
            num1 = (int) num3 * 1017016713 ^ 1472173462;
            continue;
          case 45:
            num1 = (int) num3 * 1229293474 ^ 1249304707;
            continue;
          case 46:
            int num21 = flag2 ? 835796481 : (num21 = 61617476);
            int num22 = (int) num3 * -48459305;
            num1 = num21 ^ num22;
            continue;
          case 47:
            flag2 = num4 > 0;
            num1 = -446977076;
            continue;
          case 48:
            num1 = (int) num3 * -1618710214 ^ 93965448;
            continue;
          case 49:
            rectangle2.Height = num5;
            num1 = (int) num3 * -684412342 ^ 235757423;
            continue;
          case 50:
            num1 = (int) num3 * 557384851 ^ -465994141;
            continue;
          case 51:
            goto label_1;
          case 52:
            rectangle3 = screen.Bounds;
            int num23 = Math.Abs(rectangle3.Top);
            rectangle3 = screen.WorkingArea;
            int num24 = Math.Abs(rectangle3.Top);
            num7 = Math.Abs(num23 - num24);
            rectangle3 = screen.Bounds;
            num1 = (int) num3 * 1596103951 ^ -1058150907;
            continue;
          case 53:
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            Rectangle& local12 = @rectangle2;
            rectangle3 = screen.WorkingArea;
            int width3 = rectangle3.Width;
            // ISSUE: explicit reference operation
            (^local12).Width = width3;
            num1 = (int) num3 * 478024117 ^ 23520641;
            continue;
          case 54:
            rectangle3 = WindowHelper.\u200F‍‮‫⁬‫⁭⁭‪‎‍⁯‫​‎‌‍⁯‎‪⁫‭⁪⁫⁪​‫⁫‌‮⁬‮‭⁭‫⁯⁮⁪‫‬‮(screen);
            num1 = -1028626081;
            continue;
          case 55:
            flag1 = screen == null;
            num1 = (int) num3 * 2000287225 ^ 1674209296;
            continue;
          default:
            goto label_57;
        }
      }
label_57:
      return rectangle1;
    }

    public static List<Rectangle> FindDockedTaskBars()
    {
      List<Rectangle> rectangleList1 = new List<Rectangle>();
label_1:
      int num1 = 1903598758;
      List<Rectangle> rectangleList2;
      while (true)
      {
        int num2 = 217121361;
        uint num3;
        int index;
        Screen[] screenArray;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * -112790438 ^ 1317693597;
            continue;
          case 1:
            num1 = (int) num3 * -1273835685 ^ -557301958;
            continue;
          case 2:
            screenArray = WindowHelper.\u200B‬⁫⁫⁬‌‮‍⁮⁭‏⁫‫‬⁫⁮‏‬⁭⁪⁬‎‌‬‏​‬‎‎⁯⁯‮‬‎‮‍⁮⁬⁭⁭‮();
            num1 = (int) num3 * 1873732879 ^ -477866526;
            continue;
          case 3:
            Screen screen = screenArray[index];
            num1 = 252679527;
            continue;
          case 4:
            int num4 = rectangleList1.Count == 0 ? 529416175 : (num4 = 1096374449);
            int num5 = (int) num3 * 1434611303;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_1;
          case 6:
            index = 0;
            num1 = (int) num3 * -1090910838 ^ 1375626009;
            continue;
          case 7:
            num1 = (int) num3 * 1106402348 ^ -952236742;
            continue;
          case 8:
            num1 = (int) num3 * 1581943011 ^ 940737663;
            continue;
          case 9:
            rectangleList2 = rectangleList1;
            num1 = 159638409;
            continue;
          case 10:
            int num6;
            num1 = num6 = index >= screenArray.Length ? 867026993 : (num6 = 1189157391);
            continue;
          case 11:
            ++index;
            num1 = (int) num3 * -1008273426 ^ -1964152719;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return rectangleList2;
    }

    static StringBuilder \u206B‫‬⁯‫‬⁭‎‌⁮⁯‍‍⁯‬‬⁬⁪⁬‪‭‌‫‌‬⁮‭‌‮⁫‬‍⁭​‎‍‭‫‏⁫‮([In] int obj0)
    {
      return new StringBuilder(obj0);
    }

    static int \u202E⁮⁪‮‪‎‏⁪⁫⁫⁯⁫‪‫‭⁪⁭⁭⁭⁯⁯⁫‍‌⁭‌‎⁮‬⁭⁪‬‎‏​‪⁯‫‪‍‮([In] StringBuilder obj0)
    {
      return obj0.Capacity;
    }

    static string \u202B⁮⁫⁫​​‪‭⁪⁫‬‬‪⁫‌⁫‬‮⁬​‬‏‬⁫‪‎‮‎‮⁯‫⁪‪⁬⁭‬⁮‪⁫‎‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static Screen[] \u200B‬⁫⁫⁬‌‮‍⁮⁭‏⁫‫‬⁫⁮‏‬⁭⁪⁬‎‌‬‏​‬‎‎⁯⁯‮‬‎‮‍⁮⁬⁭⁭‮()
    {
      return Screen.AllScreens;
    }

    static Rectangle \u200F‍‮‫⁬‫⁭⁭‪‎‍⁯‫​‎‌‍⁯‎‪⁫‭⁪⁫⁪​‫⁫‌‮⁬‮‭⁭‫⁯⁮⁪‫‬‮([In] Screen obj0)
    {
      return obj0.Bounds;
    }

    static bool \u206F⁮‪‭​‮‫‫⁫‭‬⁯‌⁭⁫‏‪⁫‏‬​‬‮‬‌‮⁫‮⁯‌‏‏⁪‍‭‮⁭​‏‎‮([In] Process obj0)
    {
      return obj0.HasExited;
    }

    static ProcessThreadCollection \u200B​‍‮‮‫‎‪‬⁭‬‫‮‪‭‏‌‌⁭‍‍⁫⁭⁬‎‬⁭‮‎‌⁪⁬⁮⁭‍‭‭‮‍⁪‮([In] Process obj0)
    {
      return obj0.Threads;
    }

    static IEnumerator \u206E‏‭‮‪​⁬‌‍⁫‮⁪⁯⁪‏‏​⁮‏‌⁮⁯‭​⁪⁯⁬‪⁬⁭‪⁭‭⁭‫‬⁮⁭‫‮([In] ReadOnlyCollectionBase obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u202C‍‏‪‎‍‬‫‌⁬‍⁬⁫⁭‮⁫‏‭‍⁬⁯⁪​⁮‬‎‮⁮⁫‭‎‫‭⁬⁯‍‪‪‍‎‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static int \u200F‬⁪⁬‍⁭‮‭‌‌⁪⁬‫⁬‍⁬⁯‍⁯‫‎⁬‫‏‫‮⁬‭‌‪‌​⁪‍⁬‮⁮⁫‭⁮‮([In] ProcessThread obj0)
    {
      return obj0.Id;
    }

    static uint \u206F⁭‏‮⁭‎‍‪⁬​‪‬‌‬⁮⁪‌⁫‬⁮‫‌‫‫⁯‭⁭‬‏⁫‮‫‍⁬‌‌‬​​⁯‮([In] int obj0)
    {
      return Convert.ToUInt32(obj0);
    }

    static bool \u206A⁯⁮​‪‪‫‍‫‏‮⁫​‮​​​‌⁫⁮‌​⁬⁮‎⁬‌‎⁭‎⁯⁫⁭‍⁫‮⁪⁯‬‪‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u200F‎⁮⁫⁬⁭⁫‪⁭⁮‎⁮⁭‍‫‍⁮‏‏‭⁬‪‏‮⁯‮‫⁯‬‍‮⁭‌⁬‭‌‏‫⁯‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Rectangle \u206C⁮‍⁪‌‭⁬‎‮‍‬⁫⁮⁬‏‬‫‭‭⁪⁪‮‏⁭⁯‬​​‎‮‫‎⁯⁯‭⁯⁪⁯‮⁮‮([In] Screen obj0)
    {
      return obj0.WorkingArea;
    }

    static string \u206A⁬​⁯‍‮⁭⁮⁫‏⁬‪‪​⁬⁯‬‬⁪⁮‮⁪⁪‭‌⁮⁯‬⁮‍‎‪⁬‎‬⁫‏‏‪⁪‮([In] string obj0)
    {
      return obj0.ToUpper();
    }

    static Process[] \u200E‏​‍‌‪‍‌⁫⁫‍⁭⁮‌‏‮⁪⁪⁬⁫⁬⁪‫‌⁯⁬⁪‎‫‮‮‍‏‮⁪‮‬⁫⁫‬‮()
    {
      return Process.GetProcesses();
    }

    static IntPtr \u206D‌‮⁮‍‌⁯‮‌⁮‌⁮‍⁮‍‮‮‎‭⁫‌⁭​‭⁪⁬‫⁯‎​⁫⁭​‬‌⁮⁬‮‏⁮‮([In] Process obj0)
    {
      return obj0.MainWindowHandle;
    }

    static string \u200F‌‏‭‫‮‎‭⁯‬‭‮⁬‮‎​⁭⁯‍‬⁬⁮‍‍‌‪‌​⁯⁮⁬‫‮‮⁭⁮‭⁪‭‌‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static string \u200E‍‫‬‌⁯‎‭⁮⁪‌‪⁮‫‍‌‭⁬‮⁭‪‪‌‬⁮‪⁭‪⁮‎⁭⁮⁫‮⁫‮‏‬‪‎‮([In] string obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Remove(obj1, obj2);
    }

    static string \u202C⁪⁬⁮‏⁭‬‬‮‫‫⁪‭​‌‎⁯‍‫⁭‌‪‬⁯‮⁯‮⁬⁫​⁬⁬‍‮‭‭⁬⁭⁯‭‮([In] Screen obj0)
    {
      return obj0.DeviceName;
    }

    static bool \u202E‫‫⁫⁪‮⁭‏‌⁫‪⁯​‮‪⁬‭‌‍​‍‏​‬‌⁯‌⁭‏​‬‎‌‮⁫‭​⁭‏‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static Screen \u202B‏⁮⁬⁯‫‏‪‫⁬⁬‬⁫‏‭⁯‫‭‌​⁮⁮‏‫⁮‭‍‬‪​‮‪⁫‌‎‭⁫⁫‫‭‮()
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

      public GDI32()
      {
label_1:
        int num1 = -1897911898;
        while (true)
        {
          int num2 = -1232730124;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1622614154 ^ -858591640;
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
