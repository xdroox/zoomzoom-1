// Decompiled with JetBrains decompiler
// Type: ZoomZoom.CoreUtils
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using log4net.Appender;
using log4net.Repository;
using log4net.Repository.Hierarchy;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public static class CoreUtils
  {
    private static ILog log = CoreUtils.\u202A⁯‬‏⁫⁮⁭⁬‏‎⁬⁮‬⁬⁭⁮‎⁮⁪‪⁫⁬‫‎‎⁬‫⁯‌⁯‌‍⁪⁪⁬‎‏⁮⁮‎‮(CoreUtils.\u200E⁬⁬‍‪‏⁪​‌‮⁭⁬⁪⁭‮‪‎⁯⁬⁫‍⁪⁫‬‌‮‮​‬⁫‬‏‫‏‬‎⁭‮‪‍‮((MemberInfo) CoreUtils.\u206C‮⁬‎‭‍​‭⁯​‎⁫‮⁪⁬‭‪‌‭⁮‫⁫‎‍‍⁫​‭‬‌‫​​⁫‭⁫‮‏‫⁭‮()));

    public static void LogStackTrace(int frameCount = 0)
    {
label_1:
      int num1 = -1755474799;
      string str;
      while (true)
      {
        int num2 = -743419639;
        uint num3;
        StackTrace stackTrace;
        int num4;
        int num5;
        bool flag1;
        StackFrame stackFrame;
        bool flag2;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            num1 = (int) num3 * -2089215135 ^ -1389412551;
            continue;
          case 1:
            str = CoreUtils.\u200F‏‍⁫‍‎⁬‌‫‬​⁮⁫⁪‫⁮‍‍‏‪‍‪⁬‭⁫⁫⁬⁬⁬⁫‪‏⁫‌⁭‬⁬‬‮⁯‮(str, CoreUtils.\u202B⁮⁫‏⁮‭⁭⁫‌‫‬‫‍⁯⁫‮‭⁮​‎⁬‮⁫‎⁭⁯​‌⁬⁭⁮⁫‎⁮‏⁮​⁯⁬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2111699407U), (object) CoreUtils.\u206E‫‪⁮‫‌​​‎⁬⁬‌‏⁫⁯⁫​‌‭‭‮‪‭⁮‫⁬‌‏‎⁪‌‪‍‪‭‌⁭‭⁪‌‮(stackFrame), (object) CoreUtils.\u206D‏‬⁭‎‭‏⁪​‎⁪‫‎⁮‬‏⁪⁯‫‫‫⁫‭‫‬‫⁮⁪⁮‮‌​⁭‪⁭‌​⁭‬⁬‮(stackFrame)));
            num1 = -448653618;
            continue;
          case 2:
            num1 = (int) num3 * 1148681372 ^ -1579372430;
            continue;
          case 3:
            str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(84009370U);
            num1 = -2034364368;
            continue;
          case 4:
            num4 = CoreUtils.\u202B⁫⁯⁭​‏⁬‮‭⁭‍‎⁫⁮⁫⁪‭‌⁫⁮⁫⁯‭⁭⁬‌⁯‌⁬⁫‪⁪‬‍‍‬‏⁭⁯‪‮(stackTrace);
            num1 = (int) num3 * 1235302473 ^ -1378531154;
            continue;
          case 5:
            num1 = (int) num3 * -713828524 ^ -493091502;
            continue;
          case 6:
            str = string.Empty;
            num1 = -1606662780;
            continue;
          case 7:
            goto label_1;
          case 8:
            stackFrame = CoreUtils.\u206A‎‫‫‫‌⁯‌​⁭‫⁫‍⁭⁬‫‪‏⁪‌⁬⁫‬⁭‪⁬‌‏⁪‭⁪‎‪⁮​⁯‮‏⁫‏‮(stackTrace, num5 + 1);
            flag2 = !CoreUtils.\u202A⁮​⁬‬‌​‫⁬‌‫‫⁭‬⁮⁯‫⁫‮​‎‬⁬‎‭‮‎⁫⁯⁯​⁬‌⁮‌‬⁭⁯⁪‬‮(str, string.Empty);
            num1 = -2110635736;
            continue;
          case 10:
            num6 = frameCount;
            break;
          case 11:
            int num7 = !flag2 ? -536127872 : (num7 = -75037894);
            int num8 = (int) num3 * -1205439557;
            num1 = num7 ^ num8;
            continue;
          case 12:
            stackTrace = CoreUtils.\u206E‫‪⁮‏‬⁮‍‭‬‬‬⁮⁬‬‌​⁫‎‭‏⁬‫‍‬‬‭​⁭⁯​‫‫‪‪​​⁪⁪‭‮(true);
            num1 = (int) num3 * 1932228552 ^ 1026495838;
            continue;
          case 13:
            flag1 = num5 < num4 - 1;
            num1 = -1050603598;
            continue;
          case 14:
            num5 = 0;
            num1 = (int) num3 * 2086371516 ^ -493942050;
            continue;
          case 15:
            str = CoreUtils.\u200F‏‍⁫‍‎⁬‌‫‬​⁮⁫⁪‫⁮‍‍‏‪‍‪⁬‭⁫⁫⁬⁬⁬⁫‪‏⁫‌⁭‬⁬‬‮⁯‮(str, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3924998595U));
            num1 = (int) num3 * 920385262 ^ 1707750489;
            continue;
          case 16:
            num1 = (int) num3 * -1962303891 ^ 544791571;
            continue;
          case 17:
            num1 = (int) num3 * 465244077 ^ 82048303;
            continue;
          case 18:
            if (frameCount == 0)
            {
              num6 = CoreUtils.\u202B⁫⁯⁭​‏⁬‮‭⁭‍‎⁫⁮⁫⁪‭‌⁫⁮⁫⁯‭⁭⁬‌⁯‌⁬⁫‪⁪‬‍‍‬‏⁭⁯‪‮(stackTrace);
              break;
            }
            num1 = (int) num3 * -1280669490 ^ -1942832998;
            continue;
          case 19:
            int num9 = !flag1 ? 1954483333 : (num9 = 1330242485);
            int num10 = (int) num3 * -609520333;
            num1 = num9 ^ num10;
            continue;
          case 20:
            ++num5;
            num1 = (int) num3 * 1936745132 ^ -342230298;
            continue;
          default:
            goto label_25;
        }
        num4 = num6;
        int num11;
        num1 = num11 = num4 <= CoreUtils.\u202B⁫⁯⁭​‏⁬‮‭⁭‍‎⁫⁮⁫⁪‭‌⁫⁮⁫⁯‭⁭⁬‌⁯‌⁬⁫‪⁪‬‍‍‬‏⁭⁯‪‮(stackTrace) ? -808596070 : (num11 = -899373972);
      }
label_25:
      CoreUtils.\u206E‬‏‫‌‎⁭‌‮‎‮​‪‌‎⁯⁫‫⁮⁭⁪​‪⁭⁬⁭⁮⁬⁮‍‬⁫‮‌‍⁯‭⁮‏‮‮(CoreUtils.log, (object) str);
    }

    internal static string GetCallingMethod()
    {
label_1:
      int num1 = 1899528925;
      string str;
      while (true)
      {
        int num2 = 1192986389;
        uint num3;
        bool flag;
        StackTrace stackTrace;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1710395046 ^ -612960376;
            continue;
          case 2:
            str = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1062537593U);
            num1 = (int) num3 * -993850145 ^ -2010393611;
            continue;
          case 3:
            num1 = (int) num3 * 811030912 ^ -774087566;
            continue;
          case 4:
            num1 = (int) num3 * 1729748471 ^ 616773467;
            continue;
          case 5:
            str = CoreUtils.\u202D⁭⁮‎‫‪‮‭⁫⁭‬‏‌⁪⁫⁮‮‭⁯​⁬‌⁮⁭‪‍‬​‭‬⁭‍‮‎​‏‭⁫‫⁯‮((MemberInfo) CoreUtils.\u206E‫‪⁮‫‌​​‎⁬⁬‌‏⁫⁯⁫​‌‭‭‮‪‭⁮‫⁬‌‏‎⁪‌‪‍‪‭‌⁭‭⁪‌‮(CoreUtils.\u206A‎‫‫‫‌⁯‌​⁭‫⁫‍⁭⁬‫‪‏⁪‌⁬⁫‬⁭‪⁬‌‏⁪‭⁪‎‪⁮​⁯‮‏⁫‏‮(stackTrace, 1)));
            num1 = (int) num3 * 1255274584 ^ 2001487250;
            continue;
          case 6:
            flag = CoreUtils.\u202B⁫⁯⁭​‏⁬‮‭⁭‍‎⁫⁮⁫⁪‭‌⁫⁮⁫⁯‭⁭⁬‌⁯‌⁬⁫‪⁪‬‍‍‬‏⁭⁯‪‮(stackTrace) > 0;
            num1 = (int) num3 * -1902939621 ^ 858264153;
            continue;
          case 7:
            num1 = 111059604;
            continue;
          case 8:
            stackTrace = CoreUtils.\u206E‪⁮‏‪⁫⁭⁪‭​‎⁫‮⁫⁫⁪‫⁮‬‌⁫⁫‏⁮‍⁯⁭⁯‌⁪⁬⁯​‍⁮⁬​‮‌‎‮();
            num1 = (int) num3 * -1754359687 ^ -414257433;
            continue;
          case 10:
            int num4 = flag ? 1595726200 : (num4 = 269351142);
            int num5 = (int) num3 * 2015586637;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return str;
    }

    internal static string GetLoggingFileName()
    {
label_1:
      int num1 = -500775120;
      string str1;
      while (true)
      {
        int num2 = -1613069324;
        uint num3;
        FileAppender fileAppender;
        string str2;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 1:
            if (fileAppender != null)
            {
              str2 = CoreUtils.\u206F⁭‫⁮⁬‍⁬‪‫​⁬⁬⁫⁯‭⁬‌‫‌⁯⁮⁯‌⁪‍⁪‌‎⁯‭‪⁪‎‫‌‪⁭⁪‬⁮‮(fileAppender);
              break;
            }
            num1 = (int) num3 * 1606679080 ^ -1711301241;
            continue;
          case 2:
            fileAppender = ((IEnumerable) CoreUtils.\u200F​‍​​‏‌‫‭⁪⁪‏‌⁫‎⁯‭‭‭‭‫‍⁪‫⁫‮‫‌‌⁪‮⁮⁫⁮​‌‪⁪‫‪‮(CoreUtils.\u200C⁪‏​‪⁬‪‌‪‪⁯‭‏‬‍‫‭‬‮​‬‭‎‪‪⁫‍⁫⁮⁫‫​‌‍⁯‪⁪‫‍⁪‮((log4net.Repository.Hierarchy.Hierarchy) CoreUtils.\u200E‍‍⁭‏⁫⁬‬‏⁫‬⁪‪‎‮⁭‮⁪‏‍⁫‍‭⁬⁭‮‪⁬‍⁮‮‌‭⁮⁪‌⁪‪​⁬‮()))).OfType<FileAppender>().FirstOrDefault<FileAppender>();
            num1 = (int) num3 * 1428296902 ^ -792495157;
            continue;
          case 3:
            num1 = (int) num3 * 1936316095 ^ -332738807;
            continue;
          case 4:
            goto label_1;
          case 5:
            str2 = string.Empty;
            break;
          default:
            goto label_10;
        }
        str1 = str2;
        num1 = -864883511;
      }
label_10:
      return str1;
    }

    internal static void DeleteFile(string destinationFile)
    {
      try
      {
label_2:
        int num1 = 1974223429;
        while (true)
        {
          int num2 = 1062189209;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -1845069301 ^ 1772608200;
              continue;
            case 1:
              num1 = 2086889270;
              continue;
            case 2:
              int num4 = !flag ? -1563373150 : (num4 = -794227785);
              int num5 = (int) num3 * 1914216347;
              num1 = num4 ^ num5;
              continue;
            case 3:
              CoreUtils.\u206C⁫⁬‭‫‏‌‭‌⁭⁫‮‭‬‪‬⁮‍‏‍‍‍⁯‬⁮‬⁬⁫⁫⁪‬⁫‍​⁭‌⁯⁯‫⁭‮(destinationFile);
              num1 = (int) num3 * -2145943191 ^ 611023445;
              continue;
            case 4:
              goto label_16;
            case 5:
              flag = !CoreUtils.\u202B⁭‫⁬‭⁭‍‪‏‪‎‮‮‪‎‌‎‌​⁮⁮‮⁭⁪‪‏‏‎‌‭‬​‬‫‌‏⁫⁬⁪‮(destinationFile);
              num1 = (int) num3 * -1412127589 ^ 931555463;
              continue;
            case 6:
              goto label_2;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_16:;
      }
      catch (Exception ex)
      {
label_12:
        int num1 = 1077484930;
        while (true)
        {
          int num2 = 1062189209;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_10;
            case 2:
              num1 = (int) num3 * -1867168465 ^ 2028725253;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_10:;
      }
    }

    internal static void CreateDirectory(string directory)
    {
      try
      {
        bool flag = !CoreUtils.\u202E⁫‭‬⁬‫⁮‬‪‮‎‪⁫‏​⁯‭‎​‮⁪‫‮‭‎‬⁫‮‎⁯⁬‌‏⁯⁯‮‮‍⁬‮‮(directory);
label_2:
        int num1 = 1367309810;
        while (true)
        {
          int num2 = 717742937;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_16;
            case 1:
              num1 = (int) num3 * -1087647414 ^ -367579383;
              continue;
            case 2:
              CoreUtils.\u200E‏⁫‏⁬‏⁭‫⁫⁪⁪‍‭​‌⁫⁫⁬‌​⁬⁮‫⁮⁫‪⁯‭‍⁯⁯‪​‍⁬‬‍‮​⁮‮(directory);
              num1 = (int) num3 * -1384849002 ^ 2025349734;
              continue;
            case 3:
              int num4 = flag ? -906876052 : (num4 = -1411792401);
              int num5 = (int) num3 * 1564312472;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_2;
            case 5:
              num1 = (int) num3 * -2113934488 ^ 815334623;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_16:;
      }
      catch (Exception ex)
      {
label_11:
        int num1 = 1282091614;
        while (true)
        {
          int num2 = 717742937;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1818360602 ^ 2022059132;
              continue;
            case 1:
              goto label_9;
            case 2:
              goto label_11;
            case 3:
              CoreUtils.\u200B‫‫‪⁫‭‬‭⁮‎‍‌‪‪‌‭‭⁫‎⁪⁬‫‎⁯‌⁪⁪​‭​​⁫⁭⁭‏‎‍⁯‌⁮‮(CoreUtils.log, (object) ex);
              num1 = (int) num3 * 1360953364 ^ 1472812757;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_9:;
      }
    }

    static StackTrace \u206E‫‪⁮‏‬⁮‍‭‬‬‬⁮⁬‬‌​⁫‎‭‏⁬‫‍‬‬‭​⁭⁯​‫‫‪‪​​⁪⁪‭‮([In] bool obj0)
    {
      return new StackTrace(obj0);
    }

    static int \u202B⁫⁯⁭​‏⁬‮‭⁭‍‎⁫⁮⁫⁪‭‌⁫⁮⁫⁯‭⁭⁬‌⁯‌⁬⁫‪⁪‬‍‍‬‏⁭⁯‪‮([In] StackTrace obj0)
    {
      return obj0.FrameCount;
    }

    static StackFrame \u206A‎‫‫‫‌⁯‌​⁭‫⁫‍⁭⁬‫‪‏⁪‌⁬⁫‬⁭‪⁬‌‏⁪‭⁪‎‪⁮​⁯‮‏⁫‏‮([In] StackTrace obj0, [In] int obj1)
    {
      return obj0.GetFrame(obj1);
    }

    static bool \u202A⁮​⁬‬‌​‫⁬‌‫‫⁭‬⁮⁯‫⁫‮​‎‬⁬‎‭‮‎⁫⁯⁯​⁬‌⁮‌‬⁭⁯⁪‬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static string \u200F‏‍⁫‍‎⁬‌‫‬​⁮⁫⁪‫⁮‍‍‏‪‍‪⁬‭⁫⁫⁬⁬⁬⁫‪‏⁫‌⁭‬⁬‬‮⁯‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static MethodBase \u206E‫‪⁮‫‌​​‎⁬⁬‌‏⁫⁯⁫​‌‭‭‮‪‭⁮‫⁬‌‏‎⁪‌‪‍‪‭‌⁭‭⁪‌‮([In] StackFrame obj0)
    {
      return obj0.GetMethod();
    }

    static int \u206D‏‬⁭‎‭‏⁪​‎⁪‫‎⁮‬‏⁪⁯‫‫‫⁫‭‫‬‫⁮⁪⁮‮‌​⁭‪⁭‌​⁭‬⁬‮([In] StackFrame obj0)
    {
      return obj0.GetFileLineNumber();
    }

    static string \u202B⁮⁫‏⁮‭⁭⁫‌‫‬‫‍⁯⁫‮‭⁮​‎⁬‮⁫‎⁭⁯​‌⁬⁭⁮⁫‎⁮‏⁮​⁯⁬‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static void \u206E‬‏‫‌‎⁭‌‮‎‮​‪‌‎⁯⁫‫⁮⁭⁪​‪⁭⁬⁭⁮⁬⁮‍‬⁫‮‌‍⁯‭⁮‏‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static StackTrace \u206E‪⁮‏‪⁫⁭⁪‭​‎⁫‮⁫⁫⁪‫⁮‬‌⁫⁫‏⁮‍⁯⁭⁯‌⁪⁬⁯​‍⁮⁬​‮‌‎‮()
    {
      return new StackTrace();
    }

    static string \u202D⁭⁮‎‫‪‮‭⁫⁭‬‏‌⁪⁫⁮‮‭⁯​⁬‌⁮⁭‪‍‬​‭‬⁭‍‮‎​‏‭⁫‫⁯‮([In] MemberInfo obj0)
    {
      return obj0.Name;
    }

    static ILoggerRepository \u200E‍‍⁭‏⁫⁬‬‏⁫‬⁪‪‎‮⁭‮⁪‏‍⁫‍‭⁬⁭‮‪⁬‍⁮‮‌‭⁮⁪‌⁪‪​⁬‮()
    {
      return LogManager.GetRepository();
    }

    static Logger \u200C⁪‏​‪⁬‪‌‪‪⁯‭‏‬‍‫‭‬‮​‬‭‎‪‪⁫‍⁫⁮⁫‫​‌‍⁯‪⁪‫‍⁪‮([In] log4net.Repository.Hierarchy.Hierarchy obj0)
    {
      return obj0.get_Root();
    }

    static AppenderCollection \u200F​‍​​‏‌‫‭⁪⁪‏‌⁫‎⁯‭‭‭‭‫‍⁪‫⁫‮‫‌‌⁪‮⁮⁫⁮​‌‪⁪‫‪‮([In] Logger obj0)
    {
      return obj0.get_Appenders();
    }

    static string \u206F⁭‫⁮⁬‍⁬‪‫​⁬⁬⁫⁯‭⁬‌‫‌⁯⁮⁯‌⁪‍⁪‌‎⁯‭‪⁪‎‫‌‪⁭⁪‬⁮‮([In] FileAppender obj0)
    {
      return obj0.get_File();
    }

    static bool \u202B⁭‫⁬‭⁭‍‪‏‪‎‮‮‪‎‌‎‌​⁮⁮‮⁭⁪‪‏‏‎‌‭‬​‬‫‌‏⁫⁬⁪‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static void \u206C⁫⁬‭‫‏‌‭‌⁭⁫‮‭‬‪‬⁮‍‏‍‍‍⁯‬⁮‬⁬⁫⁫⁪‬⁫‍​⁭‌⁯⁯‫⁭‮([In] string obj0)
    {
      File.Delete(obj0);
    }

    static bool \u202E⁫‭‬⁬‫⁮‬‪‮‎‪⁫‏​⁯‭‎​‮⁪‫‮‭‎‬⁫‮‎⁯⁬‌‏⁯⁯‮‮‍⁬‮‮([In] string obj0)
    {
      return Directory.Exists(obj0);
    }

    static DirectoryInfo \u200E‏⁫‏⁬‏⁭‫⁫⁪⁪‍‭​‌⁫⁫⁬‌​⁬⁮‫⁮⁫‪⁯‭‍⁯⁯‪​‍⁬‬‍‮​⁮‮([In] string obj0)
    {
      return Directory.CreateDirectory(obj0);
    }

    static void \u200B‫‫‪⁫‭‬‭⁮‎‍‌‪‪‌‭‭⁫‎⁪⁬‫‎⁯‌⁪⁪​‭​​⁫⁭⁭‏‎‍⁯‌⁮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static MethodBase \u206C‮⁬‎‭‍​‭⁯​‎⁫‮⁪⁬‭‪‌‭⁮‫⁫‎‍‍⁫​‭‬‌‫​​⁫‭⁫‮‏‫⁭‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200E⁬⁬‍‪‏⁪​‌‮⁭⁬⁪⁭‮‪‎⁯⁬⁫‍⁪⁫‬‌‮‮​‬⁫‬‏‫‏‬‎⁭‮‪‍‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202A⁯‬‏⁫⁮⁭⁬‏‎⁬⁮‬⁬⁭⁮‎⁮⁪‪⁫⁬‫‎‎⁬‫⁯‌⁯‌‍⁪⁪⁬‎‏⁮⁮‎‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
