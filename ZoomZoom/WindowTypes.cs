// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WindowTypes
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public static class WindowTypes
  {
    public static ZoomWindowType GetZoomWindowType(ZoomWindow window)
    {
label_1:
      int num1 = -113306286;
      ZoomWindowType zoomWindowType;
      while (true)
      {
        int num2 = -157183575;
        uint num3;
        bool flag;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num4 = WindowTypes.\u200E⁪‎⁭‪‮⁬‮⁬​⁬⁪⁪‌⁬‭‭‌‪⁪‌‍‍‫‍‮⁮⁫‌‪⁬‭⁯​⁪⁫⁪‪⁯⁪‮(window.ClassName, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3917233848U)) ? 1 : 0;
            break;
          case 1:
            int num6 = !flag ? 547011304 : (num6 = 1502090082);
            int num7 = (int) num3 * 1971440066;
            num1 = num6 ^ num7;
            continue;
          case 2:
            zoomWindowType = ZoomWindowType.Join;
            num1 = (int) num3 * 185298459 ^ 343370591;
            continue;
          case 3:
            zoomWindowType = ZoomWindowType.Notification;
            num1 = (int) num3 * 2002562866 ^ -841383418;
            continue;
          case 4:
            int num8;
            num1 = num8 = WindowTypes.\u202D⁭⁯‏⁫‪⁭‏⁫⁫‏‪⁫⁫⁫‮​⁭⁭​‍⁬⁯‎‌‬⁬⁪⁬‪‪‬⁭​⁫⁯‏‍​‪‮(window.Title, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(150677755U)) ? -1262100552 : (num8 = -867555973);
            continue;
          case 5:
            num1 = (int) num3 * 1131882437 ^ 1978044921;
            continue;
          case 6:
            if (WindowTypes.\u200E‫⁪‌⁫‎‬‮⁯​​‮‭⁯⁪⁮⁮‮⁬‫‍‮‭⁪‍‭‏⁮‎‫‪‍​‏⁮⁬​‪​⁮‮(window.Title, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3720136570U)))
            {
              num5 = 1;
              goto label_18;
            }
            else
            {
              num1 = -314179765;
              continue;
            }
          case 7:
            num1 = (int) num3 * -194604559 ^ 1046849121;
            continue;
          case 9:
            num1 = (int) num3 * 312394706 ^ -30623049;
            continue;
          case 10:
            zoomWindowType = ZoomWindowType.Undefined;
            num1 = -724914976;
            continue;
          case 11:
            if (!WindowTypes.\u200E⁪‎⁭‪‮⁬‮⁬​⁬⁪⁪‌⁬‭‭‌‪⁪‌‍‍‫‍‮⁮⁫‌‪⁬‭⁯​⁪⁫⁪‪⁯⁪‮(window.Title, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(183836725U)))
            {
              num4 = 0;
              break;
            }
            num1 = -724428175;
            continue;
          case 12:
            zoomWindowType = ZoomWindowType.Meeting;
            num1 = (int) num3 * -1614610891 ^ 492327024;
            continue;
          case 13:
            num1 = (int) num3 * -10914553 ^ 636814010;
            continue;
          case 14:
            zoomWindowType = ZoomWindowType.EndMeeting;
            num1 = (int) num3 * -2015177378 ^ -80329584;
            continue;
          case 15:
            num1 = (int) num3 * 1763878652 ^ -1373235088;
            continue;
          case 16:
            flag = WindowTypes.\u200E⁪‎⁭‪‮⁬‮⁬​⁬⁪⁪‌⁬‭‭‌‪⁪‌‍‍‫‍‮⁮⁫‌‪⁬‭⁯​⁪⁫⁪‪⁯⁪‮(window.Title, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1788301675U));
            num1 = (int) num3 * 82380060 ^ 1539301191;
            continue;
          case 17:
            goto label_1;
          case 18:
            num5 = WindowTypes.\u200E‫⁪‌⁫‎‬‮⁯​​‮‭⁯⁪⁮⁮‮⁬‫‍‮‭⁪‍‭‏⁮‎‫‪‍​‏⁮⁬​‪​⁮‮(window.Title, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1939817492U)) ? 1 : 0;
            goto label_18;
          default:
            goto label_26;
        }
        int num9;
        num1 = num9 = num4 == 0 ? -1686129474 : (num9 = -1505081886);
        continue;
label_18:
        int num10;
        num1 = num10 = num5 != 0 ? -1449701895 : (num10 = -2050817425);
      }
label_26:
      return zoomWindowType;
    }

    static bool \u200E⁪‎⁭‪‮⁬‮⁬​⁬⁪⁪‌⁬‭‭‌‪⁪‌‍‍‫‍‮⁮⁫‌‪⁬‭⁯​⁪⁫⁪‪⁯⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u200E‫⁪‌⁫‎‬‮⁯​​‮‭⁯⁪⁮⁮‮⁬‫‍‮‭⁪‍‭‏⁮‎‫‪‍​‏⁮⁬​‪​⁮‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static bool \u202D⁭⁯‏⁫‪⁭‏⁫⁫‏‪⁫⁫⁫‮​⁭⁭​‍⁬⁯‎‌‬⁬⁪⁬‪‪‬⁭​⁫⁯‏‍​‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.StartsWith(obj1);
    }
  }
}
