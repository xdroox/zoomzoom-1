// Decompiled with JetBrains decompiler
// Type: ZoomZoom.LayoutManager
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom
{
  public class LayoutManager : ManagerBase
  {
    private static LayoutManager instance = (LayoutManager) null;
    private Rectangle manyCamRect = Rectangle.Empty;
    private static readonly object singletonLocker;
    private static readonly object patternLocker;
    private static List<IntPtr> managedWindowHandles;

    public static LayoutManager Instance
    {
      get
      {
        if (LayoutManager.instance == null)
        {
label_1:
          int num1 = -1763906048;
          object singletonLocker;
          while (true)
          {
            int num2 = -187627672;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_1;
              case 1:
                singletonLocker = LayoutManager.singletonLocker;
                num1 = (int) num3 * 1598266925 ^ 248626793;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          bool flag1 = false;
          try
          {
            LayoutManager.\u206E‫‮⁯‍‬‭⁪‫‏⁫‭⁫‮​‎⁪‍⁯⁬​​⁯‌‬⁬⁮‍⁭⁪‪⁫⁬⁫⁮‮‍⁬‏‎‮(singletonLocker, ref flag1);
label_6:
            int num2 = -144888294;
            while (true)
            {
              int num3 = -187627672;
              uint num4;
              bool flag2;
              switch ((num4 = (uint) (num2 ^ num3)) % 9U)
              {
                case 0:
                  LayoutManager.instance = new LayoutManager();
                  num2 = (int) num4 * 1222022226 ^ 175555201;
                  continue;
                case 1:
                  num2 = (int) num4 * 966616515 ^ 1508160484;
                  continue;
                case 2:
                  num2 = (int) num4 * -1476403093 ^ 307265776;
                  continue;
                case 3:
                  goto label_6;
                case 4:
                  int num5 = flag2 ? 575982315 : (num5 = 2065736020);
                  int num6 = (int) num4 * 1959568772;
                  num2 = num5 ^ num6;
                  continue;
                case 5:
                  flag2 = LayoutManager.instance == null;
                  num2 = (int) num4 * -1641782209 ^ 839451075;
                  continue;
                case 7:
                  num2 = (int) num4 * -1255820669 ^ 1442481785;
                  continue;
                case 8:
                  num2 = -1546498688;
                  continue;
                default:
                  goto label_20;
              }
            }
          }
          finally
          {
            if (flag1)
            {
label_16:
              int num2 = -1158231033;
              while (true)
              {
                int num3 = -187627672;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_16;
                  case 2:
                    LayoutManager.\u206D‎‫⁯‏‬‎‪​⁫‪‪⁭‎‍‮⁮⁭⁪‎‎‪‫‪⁭‌⁪⁬⁫⁬⁯⁫​⁯⁫⁭⁯⁭⁬⁯‮(singletonLocker);
                    num2 = (int) num4 * -1815060212 ^ 1080778693;
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
        else
          goto label_23;
label_21:
        int num7 = -712673150;
label_22:
        int num8 = -187627672;
        uint num9;
        LayoutManager instance;
        switch ((num9 = (uint) (num7 ^ num8)) % 3U)
        {
          case 0:
            goto label_21;
          case 1:
            break;
          default:
            return instance;
        }
label_23:
        instance = LayoutManager.instance;
        num7 = -1864621770;
        goto label_22;
      }
    }

    static LayoutManager()
    {
label_1:
      int num1 = 725234211;
      while (true)
      {
        int num2 = 1839208539;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            LayoutManager.patternLocker = LayoutManager.\u202E‏‌⁭⁪‏‪‌‏​‬⁭​‎‫‌‍⁪‎‍‌​‪‬‪‮‍⁪‍⁪​‌⁪⁪⁫⁬⁯‬‪‏‮();
            num1 = (int) num3 * 160652226 ^ -1424239941;
            continue;
          case 1:
            LayoutManager.singletonLocker = LayoutManager.\u202E‏‌⁭⁪‏‪‌‏​‬⁭​‎‫‌‍⁪‎‍‌​‪‬‪‮‍⁪‍⁪​‌⁪⁪⁫⁬⁯‬‪‏‮();
            num1 = (int) num3 * 1805528125 ^ -637535153;
            continue;
          case 2:
            LayoutManager.managedWindowHandles = new List<IntPtr>();
            num1 = (int) num3 * 1369300642 ^ 1776096513;
            continue;
          case 3:
            goto label_3;
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

    public LayoutManager()
    {
label_1:
      int num1 = 1954847896;
      while (true)
      {
        int num2 = 1197915793;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 208798510 ^ -786097708;
            continue;
          case 2:
            goto label_3;
          case 3:
            LayoutManager.\u200B⁫⁯⁭‮‪​‬‪​⁮⁯‫​‬⁪⁪⁬⁬‬‫‭‌‏‏‌‏⁭​‍⁮⁫‪‏⁭‭‌⁬‬⁫‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1559532169U), new object[0]);
            num1 = (int) num3 * -2061589185 ^ -1208838758;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    static void \u206E‫‮⁯‍‬‭⁪‫‏⁫‭⁫‮​‎⁪‍⁯⁬​​⁯‌‬⁬⁮‍⁭⁪‪⁫⁬⁫⁮‮‍⁬‏‎‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206D‎‫⁯‏‬‎‪​⁫‪‪⁭‎‍‮⁮⁭⁪‎‎‪‫‪⁭‌⁪⁬⁫⁬⁯⁫​⁯⁫⁭⁯⁭⁬⁯‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static void \u200B⁫⁯⁭‮‪​‬‪​⁮⁯‫​‬⁪⁪⁬⁬‬‫‭‌‏‏‌‏⁭​‍⁮⁫‪‏⁭‭‌⁬‬⁫‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static object \u202E‏‌⁭⁪‏‪‌‏​‬⁭​‎‫‌‍⁪‎‍‌​‪‬‪‮‍⁪‍⁪​‌⁪⁪⁫⁬⁯‬‪‏‮()
    {
      return new object();
    }
  }
}
