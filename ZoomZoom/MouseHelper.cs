// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MouseHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom
{
  internal class MouseHelper
  {
    protected static readonly ILog log = MouseHelper.\u200C‮‪⁫⁪‬‍‫⁬​⁫‪⁬‎⁯‫‍‏​‬⁬⁫⁪‭⁪‍⁬‪‏‌‬‬⁭⁯⁪‫⁭⁯⁫⁯‮(MouseHelper.\u206B‮⁪‮‍⁬‮⁬⁮‎‏‭‏‭‌​‭‫‎⁫‫‌⁭‎‫⁯‪‌‭‭⁭⁬‪‏‫⁯‫⁮⁫‬‮((MemberInfo) MouseHelper.\u206E‬‫‌⁯⁮⁫‫⁪⁯‭‭‍​⁭⁮‮‮‫‮​‮⁯‌⁮‌‍⁯‏‎⁭⁫⁬‍⁬⁬‌‏‫‭‮()));
    private const uint MOUSEEVENTF_ABSOLUTE = 32768;
    private const uint MOUSEEVENTF_LEFTDOWN = 2;
    private const uint MOUSEEVENTF_LEFTUP = 4;
    private const uint MOUSEEVENTF_MIDDLEDOWN = 32;
    private const uint MOUSEEVENTF_MIDDLEUP = 64;
    private const uint MOUSEEVENTF_MOVE = 1;
    private const uint MOUSEEVENTF_RIGHTDOWN = 8;
    private const uint MOUSEEVENTF_RIGHTUP = 16;
    private const uint MOUSEEVENTF_XDOWN = 128;
    private const uint MOUSEEVENTF_XUP = 256;
    private const uint MOUSEEVENTF_WHEEL = 2048;
    private const uint MOUSEEVENTF_HWHEEL = 4096;

    internal static bool ClickWindowPosition(string sClassName, string sCaption, int iButtonX, int iButtonY, bool bIsRightClick = false)
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = 224937726;
        while (true)
        {
          int num2 = 741915089;
          uint num3;
          System.Drawing.Point pt;
          IntPtr window;
          int X;
          int Y;
          NativeMethods.RECT lpRect;
          switch ((num3 = (uint) (num1 ^ num2)) % 23U)
          {
            case 0:
              NativeMethods.mouse_event(4U, (uint) X, (uint) Y, 0U, new UIntPtr(0U));
              num1 = (int) num3 * 716316647 ^ 460477814;
              continue;
            case 1:
              NativeMethods.GetCursorPos(out pt);
              NativeMethods.SetForegroundWindow(window);
              num1 = (int) num3 * -76300905 ^ -1599784311;
              continue;
            case 2:
              num1 = 445797368;
              continue;
            case 3:
              flag1 = true;
              num1 = (int) num3 * -1985668933 ^ -1424145002;
              continue;
            case 4:
              NativeMethods.mouse_event(8U, (uint) X, (uint) Y, 0U, new UIntPtr(0U));
              num1 = (int) num3 * 1408532272 ^ -1527429059;
              continue;
            case 6:
              num1 = 1700219716;
              continue;
            case 7:
              num1 = (int) num3 * -899950514 ^ -2115495911;
              continue;
            case 8:
              window = WindowHelper.FindWindow(sClassName, sCaption, 0);
              num1 = (int) num3 * 861402322 ^ -1790242589;
              continue;
            case 9:
              num1 = (int) num3 * -17923032 ^ 1313291313;
              continue;
            case 10:
              num1 = (int) num3 * 117209080 ^ 1682004277;
              continue;
            case 11:
              NativeMethods.mouse_event(2U, (uint) X, (uint) Y, 0U, new UIntPtr(0U));
              num1 = (int) num3 * -436787434 ^ 123401903;
              continue;
            case 12:
              NativeMethods.SetCursorPos(pt.X, pt.Y);
              num1 = 6865055;
              continue;
            case 13:
              X = lpRect.left + iButtonX;
              num1 = (int) num3 * -633023474 ^ -1643474693;
              continue;
            case 14:
              NativeMethods.mouse_event(16U, (uint) X, (uint) Y, 0U, new UIntPtr(0U));
              num1 = (int) num3 * -1729202298 ^ -258598524;
              continue;
            case 15:
              num1 = (int) num3 * -810058012 ^ 444580614;
              continue;
            case 16:
              int num4 = !window.Equals((object) IntPtr.Zero) ? 1580112976 : (num4 = 1221965899);
              int num5 = (int) num3 * 1008767600;
              num1 = num4 ^ num5;
              continue;
            case 17:
              NativeMethods.SetCursorPos(X, Y);
              int num6 = bIsRightClick ? -1548474994 : (num6 = -475846207);
              int num7 = (int) num3 * -967312348;
              num1 = num6 ^ num7;
              continue;
            case 18:
              num1 = (int) num3 * 2116740299 ^ 1364581882;
              continue;
            case 19:
              NativeMethods.GetWindowRect(window, out lpRect);
              num1 = (int) num3 * -1477419003 ^ -502864874;
              continue;
            case 20:
              Y = lpRect.top + iButtonY;
              num1 = (int) num3 * 78139671 ^ -616891612;
              continue;
            case 21:
              flag1 = true;
              num1 = 1573235599;
              continue;
            case 22:
              goto label_2;
            default:
              goto label_30;
          }
        }
      }
      catch (Exception ex)
      {
label_26:
        int num1 = 146649232;
        while (true)
        {
          int num2 = 741915089;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_26;
            case 1:
              num1 = (int) num3 * 310907744 ^ 1032978430;
              continue;
            case 3:
              MouseHelper.log.Error((object) ex);
              num1 = (int) num3 * 916368342 ^ 14935845;
              continue;
            default:
              goto label_30;
          }
        }
      }
label_30:
      bool flag2 = flag1;
label_31:
      int num8 = 96237691;
      while (true)
      {
        int num1 = 741915089;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 0:
            goto label_31;
          case 2:
            num8 = (int) num2 * 2064342190 ^ -828860846;
            continue;
          default:
            goto label_34;
        }
      }
label_34:
      return flag2;
    }

    internal static bool ClickWindowPosition(IntPtr iHandle, int iButtonX, int iButtonY, bool leftclick = true, int millisecondDelay = 0, bool bringToForeground = true)
    {
      bool flag1 = false;
      System.Drawing.Point pt;
      NativeMethods.GetCursorPos(out pt);
      try
      {
label_2:
        int num1 = 1077462663;
        while (true)
        {
          int num2 = 131530624;
          uint num3;
          int X;
          int Y;
          bool flag2;
          Rectangle rectangle;
          switch ((num3 = (uint) (num1 ^ num2)) % 26U)
          {
            case 0:
              num1 = (int) num3 * -315869979 ^ 1056236955;
              continue;
            case 1:
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -1743403663 ^ 668430530;
              continue;
            case 3:
              int num4 = flag2 ? -1497558233 : (num4 = -42706472);
              int num5 = (int) num3 * 793877046;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag2 = leftclick;
              num1 = 1612984793;
              continue;
            case 5:
              NativeMethods.RECT lpRect;
              NativeMethods.GetWindowRect(iHandle, out lpRect);
              rectangle = new Rectangle(lpRect.left, lpRect.top, lpRect.right - lpRect.left, lpRect.bottom - lpRect.top);
              num1 = (int) num3 * 1998695165 ^ -1792820023;
              continue;
            case 6:
              num1 = (int) num3 * -5310055 ^ 1195456668;
              continue;
            case 7:
              MouseHelper.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3661082341U), (object) X, (object) Y);
              num1 = (int) num3 * 690226080 ^ -877394466;
              continue;
            case 8:
              num1 = (int) num3 * -2080616650 ^ 583859293;
              continue;
            case 9:
              flag1 = true;
              num1 = 809884836;
              continue;
            case 10:
              num1 = (int) num3 * 912195551 ^ 1842413118;
              continue;
            case 11:
              User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * -1244355826 ^ -868410646;
              continue;
            case 12:
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -1518113165 ^ 558242580;
              continue;
            case 13:
              Y = rectangle.Y + iButtonY;
              int num6 = !bringToForeground ? -425805098 : (num6 = -1462323904);
              int num7 = (int) num3 * 1633159342;
              num1 = num6 ^ num7;
              continue;
            case 14:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 363266970 ^ -1005891505;
              continue;
            case 15:
              goto label_2;
            case 16:
              num1 = 1723542530;
              continue;
            case 17:
              NativeMethods.SetForegroundWindow(iHandle);
              num1 = (int) num3 * -283842598 ^ 1107911746;
              continue;
            case 18:
              X = rectangle.X + iButtonX;
              num1 = (int) num3 * -358766828 ^ -1822000393;
              continue;
            case 19:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 832875103 ^ 793046678;
              continue;
            case 20:
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              Thread.Sleep(40);
              num1 = (int) num3 * 1684652910 ^ 1260837209;
              continue;
            case 21:
              num1 = (int) num3 * -1187364526 ^ -585926691;
              continue;
            case 22:
              MouseHelper.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1748831990U), (object) X, (object) Y);
              num1 = (int) num3 * -1908754318 ^ 1953538441;
              continue;
            case 23:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 1835846872 ^ 2128216590;
              continue;
            case 24:
              Thread.Sleep(40);
              num1 = (int) num3 * 1744567162 ^ 140965477;
              continue;
            case 25:
              User32.SetCursorPos(X, Y);
              num1 = (int) num3 * 1280832811 ^ 1661454273;
              continue;
            default:
              goto label_29;
          }
        }
      }
      catch (Exception ex)
      {
        MouseHelper.log.Error((object) ex);
      }
label_29:
      NativeMethods.SetCursorPos(pt.X, pt.Y);
label_30:
      int num8 = 1226915515;
      bool flag3;
      while (true)
      {
        int num1 = 131530624;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 0:
            goto label_30;
          case 1:
            flag3 = flag1;
            num8 = (int) num2 * -1629406193 ^ -1706261641;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return flag3;
    }

    internal static bool ClickScreenPosition(IntPtr iHandle, int iButtonX, int iButtonY, bool leftclick = true, int millisecondDelay = 0)
    {
      bool flag1 = false;
      System.Drawing.Point pt;
      NativeMethods.GetCursorPos(out pt);
      try
      {
label_2:
        int num1 = -1928775121;
        while (true)
        {
          int num2 = -2075344511;
          uint num3;
          int X;
          int Y;
          Rectangle rectangle;
          switch ((num3 = (uint) (num1 ^ num2)) % 30U)
          {
            case 0:
              num1 = (int) num3 * -1326293158 ^ 1232092505;
              continue;
            case 1:
              NativeMethods.SetCursorPos(X, Y);
              num1 = -919576754;
              continue;
            case 2:
              int num4 = millisecondDelay <= 0 ? 1413692108 : (num4 = 1852861153);
              int num5 = (int) num3 * -229152735;
              num1 = num4 ^ num5;
              continue;
            case 3:
              MouseHelper.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4240118149U), (object) X, (object) Y, (object) millisecondDelay);
              NativeMethods.SetCursorPos(X, Y);
              num1 = (int) num3 * -541033860 ^ -1843946065;
              continue;
            case 4:
              int num6 = !leftclick ? -1759133664 : (num6 = -1707228935);
              int num7 = (int) num3 * -1634354033;
              num1 = num6 ^ num7;
              continue;
            case 5:
              int num8 = millisecondDelay > 0 ? -1247569397 : (num8 = -614273273);
              int num9 = (int) num3 * -1322997135;
              num1 = num8 ^ num9;
              continue;
            case 6:
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * -351745483 ^ 1747816496;
              continue;
            case 7:
              num1 = (int) num3 * -600066746 ^ 1381670170;
              continue;
            case 8:
              NativeMethods.SetForegroundWindow(iHandle);
              num1 = (int) num3 * 1690160246 ^ 129431611;
              continue;
            case 9:
              Thread.Sleep(millisecondDelay);
              num1 = (int) num3 * 1001651596 ^ 1426985224;
              continue;
            case 10:
              num1 = (int) num3 * -627643505 ^ -480526039;
              continue;
            case 11:
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -1832188993 ^ -1253973701;
              continue;
            case 12:
              Thread.Sleep(millisecondDelay);
              num1 = (int) num3 * -17025962 ^ -786901886;
              continue;
            case 13:
              num1 = -1346417572;
              continue;
            case 14:
              User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * -241585978 ^ -188704518;
              continue;
            case 15:
              num1 = (int) num3 * -1242398288 ^ -1106584320;
              continue;
            case 16:
              NativeMethods.SetForegroundWindow(iHandle);
              num1 = (int) num3 * -1177337233 ^ -212607447;
              continue;
            case 17:
              num1 = (int) num3 * -992730021 ^ -2055527260;
              continue;
            case 18:
              NativeMethods.RECT lpRect;
              NativeMethods.GetWindowRect(iHandle, out lpRect);
              rectangle = new Rectangle(lpRect.left, lpRect.top, lpRect.right - lpRect.left, lpRect.bottom - lpRect.top);
              X = rectangle.X + iButtonX;
              num1 = (int) num3 * 1563709274 ^ -1660495565;
              continue;
            case 19:
              NativeMethods.SetCursorPos(X, Y);
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = -736406943;
              continue;
            case 20:
              num1 = (int) num3 * 258346172 ^ -1265904533;
              continue;
            case 21:
              num1 = (int) num3 * 2026114747 ^ -301612393;
              continue;
            case 22:
              MouseHelper.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1540974581U), (object) X, (object) Y, (object) millisecondDelay);
              num1 = (int) num3 * 626902717 ^ -1385445741;
              continue;
            case 23:
              goto label_2;
            case 24:
              Y = rectangle.Y + iButtonY;
              num1 = (int) num3 * -611995432 ^ 912711899;
              continue;
            case 26:
              NativeMethods.SetCursorPos(X, Y);
              num1 = (int) num3 * -635767580 ^ -197340899;
              continue;
            case 27:
              flag1 = true;
              num1 = -391052736;
              continue;
            case 28:
              num1 = (int) num3 * 645846836 ^ 327229898;
              continue;
            case 29:
              num1 = (int) num3 * 720718685 ^ 444617849;
              continue;
            default:
              goto label_36;
          }
        }
      }
      catch (Exception ex)
      {
label_33:
        int num1 = -1485836666;
        while (true)
        {
          int num2 = -2075344511;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_33;
            case 1:
              MouseHelper.log.Error((object) ex);
              num1 = (int) num3 * 606348759 ^ -681220735;
              continue;
            default:
              goto label_36;
          }
        }
      }
label_36:
      NativeMethods.SetCursorPos(pt.X, pt.Y);
label_37:
      int num10 = -960590796;
      bool flag2;
      while (true)
      {
        int num1 = -2075344511;
        uint num2;
        switch ((num2 = (uint) (num10 ^ num1)) % 4U)
        {
          case 0:
            goto label_37;
          case 1:
            flag2 = flag1;
            num10 = (int) num2 * -1225640777 ^ -423476019;
            continue;
          case 3:
            num10 = (int) num2 * -975136231 ^ 1825986056;
            continue;
          default:
            goto label_41;
        }
      }
label_41:
      return flag2;
    }

    static MethodBase \u206E‬‫‌⁯⁮⁫‫⁪⁯‭‭‍​⁭⁮‮‮‫‮​‮⁯‌⁮‌‍⁯‏‎⁭⁫⁬‍⁬⁬‌‏‫‭‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206B‮⁪‮‍⁬‮⁬⁮‎‏‭‏‭‌​‭‫‎⁫‫‌⁭‎‫⁯‪‌‭‭⁭⁬‪‏‫⁯‫⁮⁫‬‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u200C‮‪⁫⁪‬‍‫⁬​⁫‪⁬‎⁯‫‍‏​‬⁬⁫⁪‭⁪‍⁬‪‏‌‬‬⁭⁯⁪‫⁭⁯⁫⁯‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
