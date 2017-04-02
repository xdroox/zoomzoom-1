// Decompiled with JetBrains decompiler
// Type: ZoomZoom.RegistryHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Win32;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public static class RegistryHelper
  {
    private static ILog log = RegistryHelper.\u202B‍⁪​‭​​‍‪‫​‬‏‏⁭⁫‎⁬‏‬‎‮‪⁮⁬‮‭⁬‫‍‬⁮‎⁪⁯‍⁪⁪‭⁭‮(RegistryHelper.\u202D‬⁪⁪‫‪⁯‪⁫⁮‬‍​‍​‪‫‭‭​⁪‍‍‌‏⁬​‫⁬⁯‏⁭‮‏‬‪‬⁫⁭‭‮((MemberInfo) RegistryHelper.\u200B⁪‎‮⁯​‎⁯⁮‫⁫⁯‫⁭‫⁭⁬⁮⁭‍‍‪⁪⁬‮⁮⁮‏‍⁯⁪⁬​‍‪‌‫‍‫‪‮()));

    public static string GetRegistryKeyValue(RegistryKey rBaseKey, string sKeyName, string sValueName)
    {
      string str1 = string.Empty;
      RegistryKey registryKey = RegistryHelper.\u200E‭‬‏⁭⁮⁫⁮⁭‏‮⁬‭‏‎‭​⁫‪⁪⁯‎⁮‪‫‪‭‎⁮‭⁯⁫⁯‌⁮⁯‮⁭⁫‪‮(rBaseKey, sKeyName);
      try
      {
label_2:
        int num1 = 226534299;
        while (true)
        {
          int num2 = 1242241546;
          uint num3;
          object obj;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              num1 = 1248822469;
              continue;
            case 1:
              num1 = (int) num3 * 553818711 ^ -684993780;
              continue;
            case 2:
              RegistryHelper.\u200B​‭‎‫‬⁫‌​⁬‪​‏‍‎‫‌⁫‫​‫​‍​‬‪‫⁫​‭‏‏⁬‌⁫⁫‏‬‫‏‮(registryKey);
              num1 = 149845333;
              continue;
            case 3:
              str1 = RegistryHelper.\u206B‏‍‫‬⁬‭⁫⁪​⁬‮⁪⁪​⁪​⁫‏⁫​‪‎⁫‮⁭⁫‌‎‮⁫‎⁯‭‏‏⁭⁭‫‌‮(obj);
              num1 = (int) num3 * -1646843629 ^ 1779846843;
              continue;
            case 4:
              num1 = (int) num3 * -151755989 ^ -1434849893;
              continue;
            case 6:
              int num4 = !flag ? -1227011668 : (num4 = -823066625);
              int num5 = (int) num3 * -1542929309;
              num1 = num4 ^ num5;
              continue;
            case 7:
              num1 = (int) num3 * 2057077036 ^ -1964431945;
              continue;
            case 8:
              num1 = (int) num3 * -1088137074 ^ 1649380640;
              continue;
            case 9:
              flag = obj != null;
              num1 = (int) num3 * 796628017 ^ -2141589135;
              continue;
            case 10:
              int num6 = registryKey == null ? 2040010012 : (num6 = 1994709902);
              int num7 = (int) num3 * 1299832649;
              num1 = num6 ^ num7;
              continue;
            case 11:
              obj = RegistryHelper.\u206B⁫⁫‌‮‭⁯⁮‌‌‪‏‌⁯​​‪‭​‌⁯‮‮‪‏‪‌‮‍⁭‬‬‏‎​⁭⁬‏⁪⁪‮(registryKey, sValueName);
              num1 = (int) num3 * -1711571885 ^ 1209763534;
              continue;
            case 12:
              goto label_2;
            default:
              goto label_20;
          }
        }
      }
      finally
      {
        if (registryKey != null)
        {
label_16:
          int num1 = 1554035548;
          while (true)
          {
            int num2 = 1242241546;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_16;
              case 1:
                RegistryHelper.\u202B⁫⁬‮⁬‌‌‍‬‍‌⁪‎‮⁮‭⁬‍‍‮‍⁯‍‎​‬⁫‏⁮⁫‫‫⁫‪‮‫⁪‬‎⁫‮((IDisposable) registryKey);
                num1 = (int) num3 * -275312971 ^ -1804313290;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
label_20:
      string str2 = str1;
label_21:
      int num8 = 1921550815;
      while (true)
      {
        int num1 = 1242241546;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 1:
            num8 = (int) num2 * 838353880 ^ 1006504719;
            continue;
          case 2:
            goto label_21;
          default:
            goto label_24;
        }
      }
label_24:
      return str2;
    }

    public static bool SetRegistryKeyValue(RegistryKey rBaseKey, string sKeyName, string sValueName, string sValue, RegistryValueKind rValueKind)
    {
      bool flag = false;
      try
      {
        RegistryKey registryKey = RegistryHelper.\u202E‫‍​⁭‎‬‌⁪‮⁬‬⁭⁪‫⁫⁭⁬‬‪‫⁭‬⁯⁫‎‌⁯⁭‪⁮‮‫‮‫‬‫⁯⁫‍‮(rBaseKey, sKeyName);
        try
        {
          RegistryHelper.\u200C‮‫⁯⁬‌​⁫⁫‪‮⁭‌‭⁮⁭‮‏‌‍‮‪‮‬⁬‮‍⁪‏⁬‭‮⁯‌‏⁫⁯‭⁯‍‮(registryKey, sValueName, (object) sValue, rValueKind);
label_3:
          int num1 = 594945085;
          while (true)
          {
            int num2 = 861698348;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * 80808625 ^ 1097704642;
                continue;
              case 2:
                goto label_3;
              case 3:
                RegistryHelper.\u200B​‭‎‫‬⁫‌​⁬‪​‏‍‎‫‌⁫‫​‫​‍​‬‪‫⁫​‭‏‏⁬‌⁫⁫‏‬‫‏‮(registryKey);
                flag = true;
                num1 = (int) num3 * 2020961108 ^ 1459570964;
                continue;
              default:
                goto label_18;
            }
          }
        }
        finally
        {
          if (registryKey != null)
          {
label_8:
            int num1 = 1643198997;
            while (true)
            {
              int num2 = 861698348;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * 732187679 ^ -1657649750;
                  continue;
                case 1:
                  RegistryHelper.\u202B⁫⁬‮⁬‌‌‍‬‍‌⁪‎‮⁮‭⁬‍‍‮‍⁯‍‎​‬⁫‏⁮⁫‫‫⁫‪‮‫⁪‬‎⁫‮((IDisposable) registryKey);
                  num1 = (int) num3 * -598891301 ^ -116047717;
                  continue;
                case 3:
                  goto label_8;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
      }
      catch (Exception ex)
      {
label_14:
        int num1 = 567706137;
        while (true)
        {
          int num2 = 861698348;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              RegistryHelper.\u200E⁯‮​‍⁯‭⁯‪‭‭‭‫‫⁬⁯‭‌⁯⁭⁪‪⁯‭‭‫⁭‬⁫‫⁫‎⁭‫‫‮⁬‌‎‫‮(RegistryHelper.log, (object) ex);
              num1 = (int) num3 * 1328966887 ^ -953086994;
              continue;
            case 1:
              num1 = (int) num3 * -940548167 ^ -249213103;
              continue;
            case 3:
              goto label_14;
            default:
              goto label_18;
          }
        }
      }
label_18:
      return flag;
    }

    static RegistryKey \u200E‭‬‏⁭⁮⁫⁮⁭‏‮⁬‭‏‎‭​⁫‪⁪⁯‎⁮‪‫‪‭‎⁮‭⁯⁫⁯‌⁮⁯‮⁭⁫‪‮([In] RegistryKey obj0, [In] string obj1)
    {
      return obj0.OpenSubKey(obj1);
    }

    static object \u206B⁫⁫‌‮‭⁯⁮‌‌‪‏‌⁯​​‪‭​‌⁯‮‮‪‏‪‌‮‍⁭‬‬‏‎​⁭⁬‏⁪⁪‮([In] RegistryKey obj0, [In] string obj1)
    {
      return obj0.GetValue(obj1);
    }

    static string \u206B‏‍‫‬⁬‭⁫⁪​⁬‮⁪⁪​⁪​⁫‏⁫​‪‎⁫‮⁭⁫‌‎‮⁫‎⁯‭‏‏⁭⁭‫‌‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static void \u200B​‭‎‫‬⁫‌​⁬‪​‏‍‎‫‌⁫‫​‫​‍​‬‪‫⁫​‭‏‏⁬‌⁫⁫‏‬‫‏‮([In] RegistryKey obj0)
    {
      obj0.Close();
    }

    static void \u202B⁫⁬‮⁬‌‌‍‬‍‌⁪‎‮⁮‭⁬‍‍‮‍⁯‍‎​‬⁫‏⁮⁫‫‫⁫‪‮‫⁪‬‎⁫‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static RegistryKey \u202E‫‍​⁭‎‬‌⁪‮⁬‬⁭⁪‫⁫⁭⁬‬‪‫⁭‬⁯⁫‎‌⁯⁭‪⁮‮‫‮‫‬‫⁯⁫‍‮([In] RegistryKey obj0, [In] string obj1)
    {
      return obj0.CreateSubKey(obj1);
    }

    static void \u200C‮‫⁯⁬‌​⁫⁫‪‮⁭‌‭⁮⁭‮‏‌‍‮‪‮‬⁬‮‍⁪‏⁬‭‮⁯‌‏⁫⁯‭⁯‍‮([In] RegistryKey obj0, [In] string obj1, [In] object obj2, [In] RegistryValueKind obj3)
    {
      obj0.SetValue(obj1, obj2, obj3);
    }

    static void \u200E⁯‮​‍⁯‭⁯‪‭‭‭‫‫⁬⁯‭‌⁯⁭⁪‪⁯‭‭‫⁭‬⁫‫⁫‎⁭‫‫‮⁬‌‎‫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static MethodBase \u200B⁪‎‮⁯​‎⁯⁮‫⁫⁯‫⁭‫⁭⁬⁮⁭‍‍‪⁪⁬‮⁮⁮‏‍⁯⁪⁬​‍‪‌‫‍‫‪‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202D‬⁪⁪‫‪⁯‪⁫⁮‬‍​‍​‪‫‭‭​⁪‍‍‌‏⁬​‫⁬⁯‏⁭‮‏‬‪‬⁫⁭‭‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202B‍⁪​‭​​‍‪‫​‬‏‏⁭⁫‎⁬‏‬‎‮‪⁮⁬‮‭⁬‫‍‬⁮‎⁪⁯‍⁪⁪‭⁭‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
