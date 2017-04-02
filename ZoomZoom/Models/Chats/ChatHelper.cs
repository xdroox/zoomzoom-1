// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Chats.ChatHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Chats
{
  public static class ChatHelper
  {
    public static readonly ILog log = ChatHelper.\u206A⁭‬⁭‏⁪⁭‮‍​‎‫‮⁬‮‮‍⁫‫‬⁭⁭‮‍⁮‏⁭⁫​‭‭⁪‎⁮‌‬‌‭⁯‍‮(ChatHelper.\u200F⁫⁭‎‮​⁫⁯⁯‭‌⁯⁭‌⁬‍‏‎⁪⁪⁪⁫⁭‬⁯‮​⁪‬‌⁬‬‪⁮‌‫‬⁪‮((MemberInfo) ChatHelper.\u206A‎‌⁯⁫⁭⁮⁫‍‬⁪‏⁮⁭‪‮‫‭⁭⁫⁯⁪‫​⁯‎⁯‪‪‎⁫‪‮​‏‬‪⁯⁪⁭‮()));

    public static void InvokeChat(ZoomWindow videoWindow)
    {
      System.Drawing.Point pt;
      ZoomZoom.NativeMethods.GetCursorPos(out pt);
      try
      {
        if (videoWindow == null)
          goto label_5;
label_2:
        int num1 = 636061998;
label_3:
        while (true)
        {
          int num2 = 2070443284;
          uint num3;
          System.Drawing.Point location;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * -95136036 ^ -1772598997;
              continue;
            case 2:
              num1 = (int) num3 * 755950489 ^ -1876305810;
              continue;
            case 3:
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * 1668372822 ^ 723477270;
              continue;
            case 4:
              goto label_4;
            case 5:
              num1 = (int) num3 * 1922795880 ^ 921820613;
              continue;
            case 6:
              User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
              num1 = (int) num3 * -1539076234 ^ -1922341653;
              continue;
            case 7:
              User32.SetCursorPos(pt.X, pt.Y);
              num1 = (int) num3 * 1912795145 ^ -1696354366;
              continue;
            case 8:
              location = WindowHelper.GetWindowRectangle(videoWindow.Handle).Location;
              location.Offset(25, 25);
              User32.SetCursorPos(pt.X, pt.Y);
              num1 = (int) num3 * -968308088 ^ 1885837716;
              continue;
            case 9:
              User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * 1559960784 ^ -1433729363;
              continue;
            case 10:
              num1 = (int) num3 * 1109927590 ^ -1696860069;
              continue;
            case 12:
              location.Offset(25, 25);
              num1 = (int) num3 * -1534759896 ^ 1364224683;
              continue;
            case 13:
              User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
              num1 = (int) num3 * -136068056 ^ 308862420;
              continue;
            default:
              goto label_22;
          }
        }
label_4:
        int num4 = videoWindow.ZoomWindowType == ZoomWindowType.Video ? 1 : 0;
        goto label_6;
label_5:
        num4 = 0;
label_6:
        num1 = num4 != 0 ? 965134888 : (num1 = 799017711);
        goto label_3;
      }
      catch (Exception ex)
      {
label_19:
        int num1 = 1663993825;
        while (true)
        {
          int num2 = 2070443284;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_19;
            case 2:
              ChatHelper.log.Error((object) ex);
              num1 = (int) num3 * -182813124 ^ -1412249593;
              continue;
            default:
              goto label_22;
          }
        }
      }
label_22:
      User32.SetCursorPos(pt.X, pt.Y);
    }

    static MethodBase \u206A‎‌⁯⁫⁭⁮⁫‍‬⁪‏⁮⁭‪‮‫‭⁭⁫⁯⁪‫​⁯‎⁯‪‪‎⁫‪‮​‏‬‪⁯⁪⁭‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200F⁫⁭‎‮​⁫⁯⁯‭‌⁯⁭‌⁬‍‏‎⁪⁪⁪⁫⁭‬⁯‮​⁪‬‌⁬‬‪⁮‌‫‬⁪‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206A⁭‬⁭‏⁪⁭‮‍​‎‫‮⁬‮‮‍⁫‫‬⁭⁭‮‍⁮‏⁭⁫​‭‭⁪‎⁮‌‬‌‭⁯‍‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
