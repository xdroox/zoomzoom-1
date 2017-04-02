// Decompiled with JetBrains decompiler
// Type: ZoomZoom.AutoUpdater
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;

namespace ZoomZoom
{
  internal static class AutoUpdater
  {
    private static readonly ILog log = AutoUpdater.\u202C⁯⁭‪⁪⁪⁫‬‍‏‎‫‎‍‎‭⁬⁬‎⁪‎‏⁪‮‎⁯⁭‌‍⁯‮⁮⁪⁬⁫‎‬‌‭‮‮(AutoUpdater.\u206D‌⁪⁪⁫‬​⁭⁭​⁯‪‬‮‪‪‫⁭‌⁯‪‬‏​‮‎⁫‮‎⁪⁫⁬‍‎‪‎⁬‎‍⁫‮(__typeref (AutoUpdater)));

    internal static bool HandleUpdate(Version currentVersion)
    {
      bool flag1;
      try
      {
        VersionInfo versionUpdateManifest = AutoUpdater.GetVersionUpdateManifest();
label_2:
        int num1 = -2106094162;
        while (true)
        {
          int num2 = -488866680;
          uint num3;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              AutoUpdater.\u206C‬⁪‍‫‪​‌⁯⁪⁫‎‏‍‌⁯‪‭⁭‬⁯‪‍⁯⁪⁭‬‍⁫⁮⁮⁮‎⁪‪⁪⁫‪​‪‮(AutoUpdater.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3440153829U), (object) versionUpdateManifest.Version);
              flag2 = AutoUpdater.\u200D⁮‮⁭‬⁫​⁪‫‏‮‮‫⁮‬⁭⁪‬⁮⁫‫⁫‌‌‫‮‮​​‏⁫⁫⁫‭‏‭‬⁯‪⁪‮(versionUpdateManifest.VersionObj, currentVersion);
              num1 = (int) num3 * 221337358 ^ -883562509;
              continue;
            case 1:
              AutoUpdater.\u206C‪⁯⁮⁫​‬‏⁪​‎‍‭‪‎​‬‍‬⁫​‬‍‮‍​⁪‮‍‪⁫‮‪‍⁪‍‬‎‍‮(AutoUpdater.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2867649888U), (object) versionUpdateManifest.Url);
              num1 = (int) num3 * -1779760540 ^ -1349377661;
              continue;
            case 2:
              num1 = (int) num3 * -1067975961 ^ 523789062;
              continue;
            case 3:
              if (flag2)
              {
                num1 = (int) num3 * 1909618010 ^ 93749823;
                continue;
              }
              goto label_32;
            case 4:
              num4 = versionUpdateManifest.Downloaded ? 1 : 0;
              break;
            case 5:
              goto label_2;
            case 6:
              if (versionUpdateManifest == null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * -1967916749 ^ 460295246;
              continue;
            default:
              goto label_15;
          }
          if (num4 != 0)
            num1 = -738610022;
          else
            goto label_27;
        }
label_15:
        WebClient webClient = AutoUpdater.\u202D‬‭‬‍‪​​‏⁯‫‬⁫‌⁪‫‬‬​⁬⁭⁭‎‭‪‪⁭‎⁮​‪⁪‍⁬⁮⁫‫‭‪‮();
        try
        {
          AutoUpdater.\u202E⁭​‌‪‪⁮⁬‭⁯⁭‫‮‍‬‎‭​‮‬‏​‍‮‮‭‌‭‭‫⁪​‬⁭⁮‪⁫‪‬‫‮(webClient, versionUpdateManifest.Url, versionUpdateManifest.LocalPath);
        }
        finally
        {
          if (webClient != null)
          {
label_18:
            int num2 = -156631826;
            while (true)
            {
              int num3 = -488866680;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_18;
                case 2:
                  AutoUpdater.\u206A⁬‌‫‍‬‭‮⁫⁫⁪​⁪​‪‏‎‮‎‪‫⁪‫‌‏⁭‌⁬‌‫​‭‎⁭​‮⁮⁭‏⁪‮((IDisposable) webClient);
                  num2 = (int) num4 * -1562863918 ^ 724949991;
                  continue;
                case 3:
                  num2 = (int) num4 * -1661902431 ^ 848217422;
                  continue;
                default:
                  goto label_22;
              }
            }
          }
label_22:;
        }
        AutoUpdater.\u206C‪⁯⁮⁫​‬‏⁪​‎‍‭‪‎​‬‍‬⁫​‬‍‮‍​⁪‮‍‪⁫‮‪‍⁪‍‬‎‍‮(AutoUpdater.log, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2687888692U), (object) versionUpdateManifest.LocalPath);
label_24:
        int num5 = -1946468049;
label_25:
        while (true)
        {
          int num2 = -488866680;
          uint num3;
          Process process;
          switch ((num3 = (uint) (num5 ^ num2)) % 13U)
          {
            case 1:
              goto label_27;
            case 2:
              num5 = (int) num3 * 2061054204 ^ 974318807;
              continue;
            case 3:
              AutoUpdater.\u200B​‫⁭‭‫‌‪⁭⁪‮⁯⁮⁭‭⁬⁯⁮​⁬⁬‍‏‌⁭​⁯‪‏‎‮⁮‍‭⁭‍‭​​‬‮(AutoUpdater.\u202E​⁭⁮‫‍‫‮‌‏‎‮⁬‪⁭​‮‍⁯⁪⁪⁯⁫⁪‬⁬⁮⁮‏⁬⁫⁯‬‎⁯​‫‮‬⁮‮(process), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2411473677U));
              num5 = (int) num3 * 1679915625 ^ -1218889322;
              continue;
            case 4:
              goto label_26;
            case 5:
              AutoUpdater.\u200D⁭⁫‫‭‬‪‭‫‏⁫‫​‮‍⁪‬⁬⁯‎⁪‌‪⁫‫⁭‏⁮⁯‫‌‌‫‭⁫‬‬‍‮‮(AutoUpdater.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(61842332U), new object[0]);
              num5 = (int) num3 * -656362277 ^ 1061874146;
              continue;
            case 6:
              AutoUpdater.\u202E⁫⁫‌​‮‬‎‮⁯⁯‪‫‌⁫‪‭⁬‪‭​‬‍⁫⁭⁬⁫‌‏⁮‭⁯⁫‫​‏⁫‍‍‭‮(AutoUpdater.\u202E​⁭⁮‫‍‫‮‌‏‎‮⁬‪⁭​‮‍⁯⁪⁪⁯⁫⁪‬⁬⁮⁮‏⁬⁫⁯‬‎⁯​‫‮‬⁮‮(process), AutoUpdater.\u200D⁯​‍‭‭‪⁬‏‫‍‌‍‏‎‏​⁮⁬⁯⁭‮‭‬‭‏‌‌‌‮⁮⁫‪‏⁯⁪‫⁮⁫⁫‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2087729563U), (object) versionUpdateManifest.LocalPath));
              AutoUpdater.\u200F‬‬⁭‫​‍‍‪‪⁫⁫⁭‮‪⁯‍‪⁬⁪⁬‭‮‬‫⁮‪‏⁫⁯‪‏‭⁭‌‎‫‍‎‎‮(process);
              num5 = (int) num3 * -1748236207 ^ 1041993441;
              continue;
            case 7:
              AutoUpdater.\u206C‪⁯⁮⁫​‬‏⁪​‎‍‭‪‎​‬‍‬⁫​‬‍‮‍​⁪‮‍‪⁫‮‪‍⁪‍‬‎‍‮(AutoUpdater.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3847809487U), (object) AutoUpdater.\u206A‭⁯​⁮‎⁭‪​⁫⁯‎‭⁫‏‬‫⁬⁮‏⁯‏‮⁯⁮‮‎⁯‮‭⁭⁪⁭‪⁭‮⁫⁯⁬‮((object) currentVersion));
              num5 = (int) num3 * -1208743602 ^ 1289676669;
              continue;
            case 8:
              goto label_45;
            case 9:
              goto label_32;
            case 10:
              process = AutoUpdater.\u200E‭‮⁯‍⁭‎⁮​‏‬‭‏‭‎‌‏‬⁭‏⁪‬⁪‌‎‌‫‬​‮⁪‮‎‪‫‏⁭⁯‏‬‮();
              num5 = (int) num3 * 1390564827 ^ -1892531041;
              continue;
            case 11:
              flag1 = true;
              num5 = (int) num3 * -366722592 ^ -1081286638;
              continue;
            case 12:
              goto label_24;
            default:
              goto label_36;
          }
        }
label_26:
        AutoUpdater.\u200B‬‌⁬⁬⁪‭‎⁯‬⁯‏‍‎‍⁫​⁪‎‍⁫‍​‮‬‭‏‪⁮‌‏‮‎‬‫‬⁮⁭⁮‍‮(0);
        flag1 = false;
        goto label_45;
label_36:
        flag1 = true;
        goto label_45;
label_27:
        num5 = -1526811695;
        goto label_25;
label_32:
        num5 = -1507283055;
        goto label_25;
      }
      catch (Exception ex)
      {
        AutoUpdater.\u200F⁪​‌⁭⁬‪‫⁭‮⁭‍‬⁪‬‮⁮‬‪​⁪‎‎‮‭‍​⁯⁮‌‬‫​⁮⁬⁫⁯‬‫‪‮(AutoUpdater.log, (object) ex);
label_38:
        int num1 = -856190346;
        while (true)
        {
          int num2 = -488866680;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_38;
            case 2:
              num1 = (int) num3 * -1451704918 ^ 1027441540;
              continue;
            default:
              goto label_41;
          }
        }
      }
label_41:
      flag1 = false;
label_42:
      int num6 = -2014891297;
      while (true)
      {
        int num1 = -488866680;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 0:
            goto label_42;
          case 1:
            num6 = (int) num2 * -586017368 ^ 2116667628;
            continue;
          default:
            goto label_45;
        }
      }
label_45:
      return flag1;
    }

    private static VersionInfo GetVersionUpdateManifest()
    {
label_1:
      int num1 = 2022627580;
      VersionInfo versionInfo;
      while (true)
      {
        int num2 = 658625475;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            versionInfo = new VersionInfo()
            {
              Downloaded = false
            };
            num1 = (int) num3 * -1469921613 ^ -764384446;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      string str = string.Empty;
      try
      {
        string urlUpdateManifest = ZoomZoom.Properties.Settings.Default.URL_UpdateManifest;
        AutoUpdater.\u206C‪⁯⁮⁫​‬‏⁪​‎‍‭‪‎​‬‍‬⁫​‬‍‮‍​⁪‮‍‪⁫‮‪‍⁪‍‬‎‍‮(AutoUpdater.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1628011463U), (object) urlUpdateManifest);
        str = string.Format(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(24001649U), (object) AutoUpdater.\u200D⁪‬‫⁭⁮⁯⁫⁪​‭‭​​⁫⁮⁬⁫⁬​⁬⁬⁮‎‌‏‍⁫‭‎‫⁪⁭⁫‪‎⁭‪⁫‏‮(), (object) string.Format(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3065388934U), (object) DateTime.Now.ToString(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(499223326U))));
label_6:
        int num2 = 862506346;
        while (true)
        {
          int num3 = 658625475;
          uint num4;
          XmlDocument xmlDocument;
          TextReader textReader;
          XmlSerializer xmlSerializer;
          object obj;
          switch ((num4 = (uint) (num2 ^ num3)) % 14U)
          {
            case 0:
              obj = xmlSerializer.Deserialize(textReader);
              num2 = (int) num4 * 1279851503 ^ -179893650;
              continue;
            case 1:
              versionInfo = (VersionInfo) obj;
              versionInfo.LocalPath = Path.Combine(Path.GetTempPath(), versionInfo.FileName);
              num2 = (int) num4 * -2065938906 ^ -473885370;
              continue;
            case 2:
              xmlDocument.Save(str);
              num2 = (int) num4 * -94013096 ^ 467785681;
              continue;
            case 3:
              xmlSerializer = new XmlSerializer(typeof (VersionInfo));
              num2 = (int) num4 * 701041325 ^ -1935795298;
              continue;
            case 4:
              xmlDocument = (XmlDocument) null;
              num2 = (int) num4 * 1014889382 ^ -268184594;
              continue;
            case 5:
              num2 = (int) num4 * 1727034017 ^ 1281560074;
              continue;
            case 6:
              xmlDocument = new XmlDocument();
              xmlDocument.Load(urlUpdateManifest);
              num2 = (int) num4 * 968836621 ^ -1206099285;
              continue;
            case 7:
              goto label_6;
            case 9:
              AutoUpdater.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(571602802U), (object) str);
              num2 = (int) num4 * -1095086963 ^ -389765839;
              continue;
            case 10:
              textReader = (TextReader) new StreamReader(str);
              num2 = (int) num4 * -1904811080 ^ 1101309287;
              continue;
            case 11:
              versionInfo.Downloaded = true;
              num2 = (int) num4 * 65158457 ^ -424985384;
              continue;
            case 12:
              num2 = (int) num4 * -1818305003 ^ 1047332845;
              continue;
            case 13:
              CoreUtils.DeleteFile(str);
              num2 = (int) num4 * 1963424639 ^ -222484813;
              continue;
            default:
              goto label_37;
          }
        }
      }
      catch (WebException ex)
      {
label_21:
        int num2 = 1141000620;
        while (true)
        {
          int num3 = 658625475;
          uint num4;
          bool flag;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              int num5 = !flag ? 1431178967 : (num5 = 955190525);
              int num6 = (int) num4 * -312672662;
              num2 = num5 ^ num6;
              continue;
            case 1:
              flag = ex.Message.Contains(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1144832847U));
              num2 = (int) num4 * 1400983827 ^ -493350758;
              continue;
            case 3:
              num2 = (int) num4 * -1033846607 ^ -1511469367;
              continue;
            case 4:
              goto label_21;
            default:
              goto label_37;
          }
        }
      }
      catch (Exception ex)
      {
label_27:
        int num2 = 1821751120;
        while (true)
        {
          int num3 = 658625475;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              AutoUpdater.log.Error((object) ex);
              num2 = (int) num4 * -1017445506 ^ 1157606940;
              continue;
            case 2:
              num2 = (int) num4 * -285930466 ^ -1980165046;
              continue;
            case 3:
              goto label_27;
            case 4:
              num2 = (int) num4 * 2134035023 ^ -1896489688;
              continue;
            default:
              goto label_37;
          }
        }
      }
      finally
      {
        CoreUtils.DeleteFile(str);
label_33:
        int num2 = 54714734;
        while (true)
        {
          int num3 = 658625475;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num2 = (int) num4 * -485112725 ^ 1044008543;
              continue;
            case 2:
              goto label_33;
            default:
              goto label_36;
          }
        }
label_36:;
      }
label_37:
      return versionInfo;
    }

    static void \u206C‬⁪‍‫‪​‌⁯⁪⁫‎‏‍‌⁯‪‭⁭‬⁯‪‍⁯⁪⁭‬‍⁫⁮⁮⁮‎⁪‪⁪⁫‪​‪‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.InfoFormat(obj1, obj2);
    }

    static bool \u200D⁮‮⁭‬⁫​⁪‫‏‮‮‫⁮‬⁭⁪‬⁮⁫‫⁫‌‌‫‮‮​​‏⁫⁫⁫‭‏‭‬⁯‪⁪‮([In] Version obj0, [In] Version obj1)
    {
      return obj0 > obj1;
    }

    static void \u206C‪⁯⁮⁫​‬‏⁪​‎‍‭‪‎​‬‍‬⁫​‬‍‮‍​⁪‮‍‪⁫‮‪‍⁪‍‬‎‍‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static WebClient \u202D‬‭‬‍‪​​‏⁯‫‬⁫‌⁪‫‬‬​⁬⁭⁭‎‭‪‪⁭‎⁮​‪⁪‍⁬⁮⁫‫‭‪‮()
    {
      return new WebClient();
    }

    static void \u202E⁭​‌‪‪⁮⁬‭⁯⁭‫‮‍‬‎‭​‮‬‏​‍‮‮‭‌‭‭‫⁪​‬⁭⁮‪⁫‪‬‫‮([In] WebClient obj0, [In] string obj1, [In] string obj2)
    {
      obj0.DownloadFile(obj1, obj2);
    }

    static void \u206A⁬‌‫‍‬‭‮⁫⁫⁪​⁪​‪‏‎‮‎‪‫⁪‫‌‏⁭‌⁬‌‫​‭‎⁭​‮⁮⁭‏⁪‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Process \u200E‭‮⁯‍⁭‎⁮​‏‬‭‏‭‎‌‏‬⁭‏⁪‬⁪‌‎‌‫‬​‮⁪‮‎‪‫‏⁭⁯‏‬‮()
    {
      return new Process();
    }

    static ProcessStartInfo \u202E​⁭⁮‫‍‫‮‌‏‎‮⁬‪⁭​‮‍⁯⁪⁪⁯⁫⁪‬⁬⁮⁮‏⁬⁫⁯‬‎⁯​‫‮‬⁮‮([In] Process obj0)
    {
      return obj0.StartInfo;
    }

    static void \u200B​‫⁭‭‫‌‪⁭⁪‮⁯⁮⁭‭⁬⁯⁮​⁬⁬‍‏‌⁭​⁯‪‏‎‮⁮‍‭⁭‍‭​​‬‮([In] ProcessStartInfo obj0, [In] string obj1)
    {
      obj0.FileName = obj1;
    }

    static string \u200D⁯​‍‭‭‪⁬‏‫‍‌‍‏‎‏​⁮⁬⁯⁭‮‭‬‭‏‌‌‌‮⁮⁫‪‏⁯⁪‫⁮⁫⁫‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u202E⁫⁫‌​‮‬‎‮⁯⁯‪‫‌⁫‪‭⁬‪‭​‬‍⁫⁭⁬⁫‌‏⁮‭⁯⁫‫​‏⁫‍‍‭‮([In] ProcessStartInfo obj0, [In] string obj1)
    {
      obj0.Arguments = obj1;
    }

    static bool \u200F‬‬⁭‫​‍‍‪‪⁫⁫⁭‮‪⁯‍‪⁬⁪⁬‭‮‬‫⁮‪‏⁫⁯‪‏‭⁭‌‎‫‍‎‎‮([In] Process obj0)
    {
      return obj0.Start();
    }

    static void \u200B‬‌⁬⁬⁪‭‎⁯‬⁯‏‍‎‍⁫​⁪‎‍⁫‍​‮‬‭‏‪⁮‌‏‮‎‬‫‬⁮⁭⁮‍‮([In] int obj0)
    {
      Environment.Exit(obj0);
    }

    static string \u206A‭⁯​⁮‎⁭‪​⁫⁯‎‭⁫‏‬‫⁬⁮‏⁯‏‮⁯⁮‮‎⁯‮‭⁭⁪⁭‪⁭‮⁫⁯⁬‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static void \u200D⁭⁫‫‭‬‪‭‫‏⁫‫​‮‍⁪‬⁬⁯‎⁪‌‪⁫‫⁭‏⁮⁯‫‌‌‫‭⁫‬‬‍‮‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u200F⁪​‌⁭⁬‪‫⁭‮⁭‍‬⁪‬‮⁮‬‪​⁪‎‎‮‭‍​⁯⁮‌‬‫​⁮⁬⁫⁯‬‫‪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static string \u200D⁪‬‫⁭⁮⁯⁫⁪​‭‭​​⁫⁮⁬⁫⁬​⁬⁬⁮‎‌‏‍⁫‭‎‫⁪⁭⁫‪‎⁭‪⁫‏‮()
    {
      return Path.GetTempPath();
    }

    static Type \u206D‌⁪⁪⁫‬​⁭⁭​⁯‪‬‮‪‪‫⁭‌⁯‪‬‏​‮‎⁫‮‎⁪⁫⁬‍‎‪‎⁬‎‍⁫‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static ILog \u202C⁯⁭‪⁪⁪⁫‬‍‏‎‫‎‍‎‭⁬⁬‎⁪‎‏⁪‮‎⁯⁭‌‍⁯‮⁮⁪⁬⁫‎‬‌‭‮‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
