// Decompiled with JetBrains decompiler
// Type: ZoomZoom.CoreProtector
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ZoomZoom.Models.Core;
using ZoomZoom.Properties;
using ZoomZoomLicense;

namespace ZoomZoom
{
  internal static class CoreProtector
  {
    private static readonly string COMPILE_DATE = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1935201320U);
    private const string PUBLIC_FTP_USERNAME = "zoomzoom";
    private const string PUBLIC_FTP_PASSWORD = "ZOom12!@";
    private const string FTP_LICENSE_FOLDER = "licenses/";
    private static readonly ILog log;

    public static DateTime DATECOMPILED
    {
      get
      {
        DateTime dateTime = CoreProtector.\u200E‏‫‏‭⁬‮⁪‍‏‍‬‬‌‏‬‭​‌‎‫‌⁭⁪⁫‌‏‎‬‬‬⁫⁪‌‬‏⁪⁬‌‪‮(CoreProtector.COMPILE_DATE);
label_1:
        int num1 = 974690813;
        while (true)
        {
          int num2 = 1820121950;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -220114025 ^ 1056922923;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dateTime;
      }
    }

    static CoreProtector()
    {
label_1:
      int num1 = -1717819028;
      while (true)
      {
        int num2 = -1226597131;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: type reference
            CoreProtector.log = CoreProtector.\u202B‎‍⁯⁯⁯⁫‏‌⁭‬‮‫⁬‫‎⁭⁯‪​​‎‫​⁬‌‬⁭​‫‮‮‬‏‭‫⁫‍⁪⁭‮(CoreProtector.\u206E‏‭‭‮⁯‌‍‏‫‏‬‫‬‫⁬⁪​​‌‎‫⁯‎‏‍‪‍​‎⁭⁭⁯‍‍‮‮‬‮‮‮(__typeref (CoreProtector)));
            num1 = (int) num3 * -1449230691 ^ -559448971;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    internal static void TransmitLicenseRequest()
    {
label_1:
      int num1 = 141266600;
      ftp ftp;
      List<string> list;
      List<string> stringList;
      while (true)
      {
        int num2 = 1479631534;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            list = ((IEnumerable<string>) CoreProtector.\u202A⁭⁭⁯‌‍‪⁬‌⁫⁬⁮‫⁫⁪‪‬‏‮‭⁭‍‏‮⁫‎‏⁯⁯‫⁯‭​⁮⁫⁮⁫‭‏⁪‮(Resources.LicenseRoot)).ToList<string>();
            stringList = new List<string>();
            num1 = (int) num3 * 1329699747 ^ 146759652;
            continue;
          case 2:
            ftp = new ftp(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(454679715U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2666317483U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3894491713U));
            num1 = (int) num3 * -2132314090 ^ 1432056794;
            continue;
          case 3:
            num1 = (int) num3 * 861542259 ^ 1069149062;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      using (List<string>.Enumerator enumerator = list.GetEnumerator())
      {
label_13:
        int num2 = !enumerator.MoveNext() ? 710627825 : (num2 = 1971039799);
        while (true)
        {
          int num3 = 1479631534;
          uint num4;
          string remoteFile;
          string current;
          switch ((num4 = (uint) (num2 ^ num3)) % 12U)
          {
            case 0:
              num2 = 1971039799;
              continue;
            case 1:
              int num5 = ftp.upload(remoteFile, current) ? 1205613286 : (num5 = 763074484);
              int num6 = (int) num4 * 392612258;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = (int) num4 * 645144440 ^ 1980627813;
              continue;
            case 4:
              num2 = (int) num4 * -1065422757 ^ -598504290;
              continue;
            case 5:
              current = enumerator.Current;
              num2 = 379149740;
              continue;
            case 6:
              goto label_13;
            case 7:
              remoteFile = CoreProtector.\u200E⁭‮‍⁮⁪⁫​‮‌‍‍⁪‫⁫‪⁭⁫‌‭‍‌​⁮‭⁯‭⁯‎⁮‎⁮‮‫⁪​‮⁫⁮⁬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(855314943U), CoreProtector.\u202A⁮⁪⁬​⁬⁬⁮⁫⁬‮‭‮‫⁮‬‬‬‬⁬⁯​‏⁪⁬⁭‍⁭⁯⁯⁭‪‪‍‏‭‪‏‏⁮‮(current));
              num2 = (int) num4 * -1675650533 ^ -2036547558;
              continue;
            case 8:
              num2 = 1431791180;
              continue;
            case 9:
              stringList.Add(current);
              num2 = (int) num4 * 934811859 ^ -913040030;
              continue;
            case 10:
              num2 = (int) num4 * -950930831 ^ 1710406465;
              continue;
            case 11:
              num2 = (int) num4 * -497937646 ^ 955002712;
              continue;
            default:
              goto label_22;
          }
        }
      }
label_22:
label_23:
      int num7 = 2076261630;
      while (true)
      {
        int num2 = 1479631534;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 12U)
        {
          case 0:
            num7 = (int) num3 * 666123896 ^ 921391651;
            continue;
          case 1:
            goto label_25;
          case 2:
            num7 = 572353123;
            continue;
          case 3:
            num7 = 360355034;
            continue;
          case 4:
            int num4 = (int) CoreProtector.\u206A‫‭‮⁭‭⁭‍⁫‎​‫⁯⁪⁫‫⁮‪‍‏⁯‌‌‪‫‍‍‏⁯⁬⁭‮​⁯⁬⁮​‎⁮‬‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(782855032U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3672308744U), MessageBoxButtons.OK);
            num7 = (int) num3 * 216261062 ^ -1822330514;
            continue;
          case 5:
            num7 = (int) num3 * -1281084317 ^ 22815722;
            continue;
          case 6:
            CoreProtector.\u202A⁮‏⁬‏‬⁯⁪⁮‬‫⁫⁫‎⁪⁬⁯⁫‫⁬‫‌‮⁮⁬‎⁮‭‎⁭‫⁬​‫⁯‮‭‪‭⁬‮(CoreProtector.\u200F‪⁯​‬⁯⁮‭‫​‫‎⁪⁮‍‪‪⁫‏⁬⁮‪‎⁯⁯‫⁮⁯⁯​⁬⁪‭‮‎⁪‍‬‍‎‮(Resources.LicenseRoot));
            num7 = (int) num3 * -1949391463 ^ 252970383;
            continue;
          case 7:
            num7 = (int) num3 * -1338220461 ^ 1356623681;
            continue;
          case 8:
            int num5 = stringList.Count != list.Count ? -1044535633 : (num5 = -697858619);
            int num6 = (int) num3 * 1535512097;
            num7 = num5 ^ num6;
            continue;
          case 9:
            num7 = (int) num3 * -506626471 ^ -1206797231;
            continue;
          case 10:
            goto label_23;
          case 11:
            int num8 = CoreProtector.\u200B‮‭‍‎‏‍‭‫‪‪‪‍⁮⁬‎‬‪⁭⁫‫⁫‫‏⁫‫‌‬⁭‎‬⁯⁯‫⁬‭‏⁬⁭‫‮(CoreProtector.\u206E⁭‌‮⁫‏‭⁯‮‫⁭​⁪‏‫‏‎‏‌​‌‌⁭​‫‎‪‬⁪⁬‮⁫⁫‏⁬⁯⁫​‍‭‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(837523683U), (object) (list.Count - stringList.Count)), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4169866186U), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes ? -889258509 : (num8 = -572617360);
            int num9 = (int) num3 * 1963774632;
            num7 = num8 ^ num9;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_25:;
    }

    private static bool LicenseRootFolderExists()
    {
      bool flag1 = !CoreProtector.\u202C‎‎‫‭‍‌⁯‪​⁪‭‪⁭‬‬‎​‭‌‌‌‪‮‮‍‫‫‏‪⁮⁮⁬‭⁪⁬‎‪‌‭‮(Resources.LicenseRoot);
label_1:
      int num1 = 1209606669;
      bool flag2;
      while (true)
      {
        int num2 = 79917591;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 78775337 ^ 1051211415;
            continue;
          case 2:
            CoreProtector.\u200B​‍‮‎⁭⁫‭‮‫‮‌⁫⁭⁬​‌​⁫‭‎‫‍‌‭⁯‪⁭‫‏⁪‍⁮⁪‫‌‎‭​⁬‮(Resources.LicenseRoot);
            num1 = (int) num3 * -959392506 ^ -1365715286;
            continue;
          case 3:
            flag2 = true;
            num1 = 1283851286;
            continue;
          case 4:
            int num4 = !flag1 ? 600100346 : (num4 = 678066413);
            int num5 = (int) num3 * -222949858;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return flag2;
    }

    internal static MachineState GetMachineState()
    {
      MachineState machineState1 = MachineState.Undetermined;
      MachineState machineState2;
      try
      {
label_2:
        int num1 = -1343412457;
        while (true)
        {
          int num2 = -481878345;
          uint num3;
          DateTime dateTime;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              num1 = (int) num3 * 1730309596 ^ 474310290;
              continue;
            case 1:
              goto label_8;
            case 2:
              goto label_2;
            case 3:
              num1 = -888282184;
              continue;
            case 4:
              int num4 = dateTime.AddDays(30.0) < DateTime.Now ? -1559941900 : (num4 = -1032527279);
              int num5 = (int) num3 * -177027516;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 510401760 ^ 673836736;
              continue;
            case 6:
              num1 = (int) num3 * 1511600883 ^ -1617387255;
              continue;
            case 7:
              num1 = -831478305;
              continue;
            case 8:
              dateTime = CoreProtector.\u200E‏‫‏‭⁬‮⁪‍‏‍‬‬‌‏‬‭​‌‎‫‌⁭⁪⁫‌‏‎‬‬‬⁫⁪‌‬‏⁪⁬‌‪‮(CoreProtector.COMPILE_DATE);
              num1 = (int) num3 * 1463294053 ^ -51661368;
              continue;
            case 9:
              machineState1 = MachineState.Outdated;
              num1 = (int) num3 * -217147086 ^ 2088742408;
              continue;
            default:
              goto label_14;
          }
        }
label_8:
        machineState2 = new LicenseChecker().GetState();
        goto label_18;
      }
      catch (Exception ex)
      {
        machineState1 = MachineState.Error;
        CoreProtector.log.Error((object) ex);
      }
label_14:
      machineState2 = machineState1;
label_15:
      int num6 = -1400835339;
      while (true)
      {
        int num1 = -481878345;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 0:
            goto label_15;
          case 1:
            num6 = (int) num2 * 781144586 ^ 1755966923;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return machineState2;
    }

    internal static void ExportLicense(string macAddress)
    {
label_1:
      int num1 = 1923356461;
      while (true)
      {
        int num2 = 2050214009;
        uint num3;
        License license;
        string licenseRoot;
        string str;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            license.Licensee = CoreProtector.\u200F⁪‮‌‍⁮‬‎⁮⁪⁯‍⁯‮‬⁯⁫‌⁯‮⁪‪⁭‭‮‌⁭‫‭​​‌⁮⁫⁬⁫‮‎‪‪‮();
            num1 = (int) num3 * -1537389269 ^ 930953215;
            continue;
          case 1:
            licenseRoot = Resources.LicenseRoot;
            CoreProtector.\u200D‪‭‍⁪‫‬‭‭⁭⁯⁯⁪⁯‫‭‮‪‌⁯⁬​‭​‌⁫⁬‌⁯⁭⁭‭⁭⁯⁮⁯‭⁫‮‫‮(licenseRoot, str);
            int num4 = !CoreProtector.\u202C‎‎‫‭‍‌⁯‪​⁪‭‪⁭‬‬‎​‭‌‌‌‪‮‮‍‫‫‏‪⁮⁮⁬‭⁪⁬‎‪‌‭‮(licenseRoot) ? 412641103 : (num4 = 1218056561);
            int num5 = (int) num3 * -745668599;
            num1 = num4 ^ num5;
            continue;
          case 2:
            license.DateRequested = DateTime.Now;
            num1 = (int) num3 * -863090512 ^ 153358108;
            continue;
          case 3:
            license = new License();
            num1 = 313527243;
            continue;
          case 4:
            license.Node = macAddress;
            num1 = (int) num3 * 1793480647 ^ 1795880634;
            continue;
          case 5:
            license.DateExpires = CoreProtector.\u200E‏‫‏‭⁬‮⁪‍‏‍‬‬‌‏‬‭​‌‎‫‌⁭⁪⁫‌‏‎‬‬‬⁫⁪‌‬‏⁪⁬‌‪‮(CoreProtector.COMPILE_DATE).AddDays(30.0);
            num1 = (int) num3 * -1200663270 ^ -683511489;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -1173507156 ^ 682285796;
            continue;
          case 8:
            license.MachineName = CoreProtector.\u202E‌‫‪‪⁭⁭‌⁯‏‌⁮⁫‎‍‭‎‭‪⁯⁭‎‮⁫‍‪⁬‏⁮⁭‪​‬‬⁮‎‬‎‎‮();
            num1 = (int) num3 * 924916207 ^ -1157671823;
            continue;
          case 9:
            num1 = (int) num3 * -524718652 ^ 25558546;
            continue;
          case 10:
            goto label_3;
          case 11:
            LicenseHelper.Save(license, Path.Combine(Engine.Instance.Settings.LicenseRoot, license.FileName));
            num1 = (int) num3 * 431591654 ^ -1277521901;
            continue;
          case 12:
            str = CoreProtector.\u200E⁭‮‍⁮⁪⁫​‮‌‍‍⁪‫⁫‪⁭⁫‌‭‍‌​⁮‭⁯‭⁯‎⁮‎⁮‮‫⁪​‮⁫⁮⁬‮(macAddress, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1772799200U));
            num1 = (int) num3 * 738438175 ^ 832264366;
            continue;
          case 13:
            CoreProtector.\u200B​‍‮‎⁭⁫‭‮‫‮‌⁫⁭⁬​‌​⁫‭‎‫‍‌‭⁯‪⁭‫‏⁪‍⁮⁪‫‌‎‭​⁬‮(licenseRoot);
            num1 = (int) num3 * -994001036 ^ 2063126318;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    private static bool DownloadLicense(string filePath)
    {
      string str = CoreProtector.\u200E⁭‮‍⁮⁪⁫​‮‌‍‍⁪‫⁫‪⁭⁫‌‭‍‌​⁮‭⁯‭⁯‎⁮‎⁮‮‫⁪​‮⁫⁮⁬‮(Engine.Instance.Settings.URL_LicenseRoot, CoreProtector.\u202A⁮⁪⁬​⁬⁬⁮⁫⁬‮‭‮‫⁮‬‬‬‬⁬⁯​‏⁪⁬⁭‍⁭⁯⁯⁭‪‪‍‏‭‪‏‏⁮‮(filePath));
      bool flag1;
      try
      {
label_2:
        int num1 = 741791741;
        while (true)
        {
          int num2 = 219656479;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -288851835 ^ -1041695750;
              continue;
            case 2:
              CoreUtils.DeleteFile(filePath);
              num1 = (int) num3 * -776074535 ^ 496689884;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_6;
          }
        }
label_6:
        WebClient webClient = CoreProtector.\u200F⁯⁫‪​‮‮‮‎‬‭‏‬‍⁬⁪‭‎‎‌‌⁮‌​‌⁯‌‪⁮⁪⁪‎⁬‍‌⁪‌‎‎‍‮();
        try
        {
          CoreProtector.\u200B⁮⁭⁭‭‬⁬⁫‪‌‪‍‌‪⁪⁬‏‌‪‍⁪⁬‌‏⁭⁮⁮⁮⁮‎‪‫⁬‫‪⁬​⁬⁪‮‮(webClient, str, filePath);
        }
        finally
        {
          if (webClient != null)
          {
label_9:
            int num2 = 1473216978;
            while (true)
            {
              int num3 = 219656479;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 1:
                  CoreProtector.\u202E‭‭‌‬⁪‭‮‌⁯‪⁬⁭⁮⁬‌‏⁪‎‭​‏⁮‏‮⁭⁭⁫‮⁮​⁬⁪‭⁯⁪⁭​⁪⁫‮((IDisposable) webClient);
                  num2 = (int) num4 * 1412138296 ^ -1998643347;
                  continue;
                case 2:
                  goto label_9;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
        bool flag2 = CoreProtector.\u206F‏‮​‮‌‌‫⁬‏‭‏‫‭‮⁭‍‍‍‫‬‪‌⁫​‭⁪⁫‮‍⁭‎⁬​‪⁯⁮⁭‪‪‮(filePath);
label_14:
        int num5 = 837304732;
        while (true)
        {
          int num2 = 219656479;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 6U)
          {
            case 0:
              num5 = (int) num3 * -574731303 ^ 1629286341;
              continue;
            case 2:
              goto label_17;
            case 3:
              num5 = 1877564888;
              continue;
            case 4:
              goto label_14;
            case 5:
              int num4 = !flag2 ? -730607775 : (num4 = -1875931294);
              int num6 = (int) num3 * -2032165427;
              num5 = num4 ^ num6;
              continue;
            default:
              goto label_39;
          }
        }
label_17:
        flag1 = true;
        goto label_43;
      }
      catch (WebException ex)
      {
label_21:
        int num1 = 433893317;
        while (true)
        {
          int num2 = 219656479;
          uint num3;
          bool flag2;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              num1 = (int) num3 * 1959570934 ^ -951456377;
              continue;
            case 2:
              int num4 = !flag3 ? 593565308 : (num4 = 1691789927);
              int num5 = (int) num3 * 1500850347;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 500330623 ^ -1631470307;
              continue;
            case 4:
              goto label_21;
            case 5:
              flag2 = CoreProtector.\u200E‍​‎⁪‫‮⁭‌‪⁪‍​‪⁯⁭⁬⁯‎‏‪⁫‪⁮⁮‌⁭‫⁬⁯‍‏⁫‪‫⁫⁬​⁫‬‮(CoreProtector.\u200D‮‫‪‮‬⁬‪‪⁭‭‬‫‏⁮​⁮‫⁪​⁭‬‪‍‏‬⁭​‌‎‫‌‏⁮‍‮‌⁯⁯‪‮(CoreProtector.\u202E‏‪⁭⁮‬‭⁪‫⁬​⁭⁮​‪‌⁭‪‏‫‎​‌‭‪‮‍‪‫⁯⁪⁫‮⁯‫‪‮⁪⁭⁯‮((Exception) ex)), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2297098700U));
              num1 = 138232334;
              continue;
            case 6:
              CoreProtector.\u202A⁪​⁬​⁪‮‫⁮‭‌⁪⁯‌‫‍‫‎⁪‭⁬‌⁬⁭⁪⁮⁪‏​‍⁮‏‌‭‪⁭‫‏⁪‮‮(CoreProtector.log, (object) ex);
              num1 = 1629987817;
              continue;
            case 7:
              goto label_30;
            case 8:
              int num6 = flag2 ? 160576981 : (num6 = 1673079884);
              int num7 = (int) num3 * 47773776;
              num1 = num6 ^ num7;
              continue;
            case 9:
              goto label_31;
            case 10:
              num1 = (int) num3 * -779694 ^ -1254414192;
              continue;
            case 11:
              num1 = (int) num3 * 1838064157 ^ 727019188;
              continue;
            case 12:
              flag3 = CoreProtector.\u200E‍​‎⁪‫‮⁭‌‪⁪‍​‪⁯⁭⁬⁯‎‏‪⁫‪⁮⁮‌⁭‫⁬⁯‍‏⁫‪‫⁫⁬​⁫‬‮(CoreProtector.\u202E‏‪⁭⁮‬‭⁪‫⁬​⁭⁮​‪‌⁭‪‏‫‎​‌‭‪‮‍‪‫⁯⁪⁫‮⁯‫‪‮⁪⁭⁯‮((Exception) ex), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4196737569U));
              num1 = (int) num3 * -903917125 ^ 1027093353;
              continue;
            default:
              goto label_39;
          }
        }
label_30:
        CoreProtector.\u200D‍‍⁯⁬‬​‮⁯⁬⁬‍⁭‍‪‍‏⁬‎‌⁬‍‭‫‍⁭‮‭⁫⁯‍‪‎‫‪⁯⁬‭‌‬‮(CoreProtector.log, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3304582831U), (object) str);
        flag1 = false;
        goto label_43;
label_31:
        CoreProtector.\u200D‍‍⁯⁬‬​‮⁯⁬⁬‍⁭‍‪‍‏⁬‎‌⁬‍‭‫‍⁭‮‭⁫⁯‍‪‎‫‪⁯⁬‭‌‬‮(CoreProtector.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4179376133U), (object) str);
        flag1 = false;
        goto label_43;
      }
      catch (Exception ex)
      {
label_35:
        int num1 = 1008511950;
        while (true)
        {
          int num2 = 219656479;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_35;
            case 1:
              CoreProtector.\u202A⁪​⁬​⁪‮‫⁮‭‌⁪⁯‌‫‍‫‎⁪‭⁬‌⁬⁭⁪⁮⁪‏​‍⁮‏‌‭‪⁭‫‏⁪‮‮(CoreProtector.log, (object) ex);
              num1 = (int) num3 * -115367055 ^ 626097601;
              continue;
            default:
              goto label_38;
          }
        }
label_38:
        throw ex;
      }
label_39:
      flag1 = false;
label_40:
      int num8 = 666352417;
      while (true)
      {
        int num1 = 219656479;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 0:
            goto label_40;
          case 1:
            num8 = (int) num2 * 1060848116 ^ -804315309;
            continue;
          default:
            goto label_43;
        }
      }
label_43:
      return flag1;
    }

    static DateTime \u200E‏‫‏‭⁬‮⁪‍‏‍‬‬‌‏‬‭​‌‎‫‌⁭⁪⁫‌‏‎‬‬‬⁫⁪‌‬‏⁪⁬‌‪‮([In] string obj0)
    {
      return Convert.ToDateTime(obj0);
    }

    static string[] \u202A⁭⁭⁯‌‍‪⁬‌⁫⁬⁮‫⁫⁪‪‬‏‮‭⁭‍‏‮⁫‎‏⁯⁯‫⁯‭​⁮⁫⁮⁫‭‏⁪‮([In] string obj0)
    {
      return Directory.GetFiles(obj0);
    }

    static string \u202A⁮⁪⁬​⁬⁬⁮⁫⁬‮‭‮‫⁮‬‬‬‬⁬⁯​‏⁪⁬⁭‍⁭⁯⁯⁭‪‪‍‏‭‪‏‏⁮‮([In] string obj0)
    {
      return Path.GetFileName(obj0);
    }

    static string \u200E⁭‮‍⁮⁪⁫​‮‌‍‍⁪‫⁫‪⁭⁫‌‭‍‌​⁮‭⁯‭⁯‎⁮‎⁮‮‫⁪​‮⁫⁮⁬‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static string \u206E⁭‌‮⁫‏‭⁯‮‫⁭​⁪‏‫‏‎‏‌​‌‌⁭​‫‎‪‬⁪⁬‮⁫⁫‏⁬⁯⁫​‍‭‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static DialogResult \u200B‮‭‍‎‏‍‭‫‪‪‪‍⁮⁬‎‬‪⁭⁫‫⁫‫‏⁫‫‌‬⁭‎‬⁯⁯‫⁬‭‏⁬⁭‫‮([In] string obj0, [In] string obj1, [In] MessageBoxButtons obj2, [In] MessageBoxIcon obj3, [In] MessageBoxDefaultButton obj4)
    {
      return MessageBox.Show(obj0, obj1, obj2, obj3, obj4);
    }

    static string \u200F‪⁯​‬⁯⁮‭‫​‫‎⁪⁮‍‪‪⁫‏⁬⁮‪‎⁯⁯‫⁮⁯⁯​⁬⁪‭‮‎⁪‍‬‍‎‮([In] string obj0)
    {
      return Path.GetDirectoryName(obj0);
    }

    static Process \u202A⁮‏⁬‏‬⁯⁪⁮‬‫⁫⁫‎⁪⁬⁯⁫‫⁬‫‌‮⁮⁬‎⁮‭‎⁭‫⁬​‫⁯‮‭‪‭⁬‮([In] string obj0)
    {
      return Process.Start(obj0);
    }

    static DialogResult \u206A‫‭‮⁭‭⁭‍⁫‎​‫⁯⁪⁫‫⁮‪‍‏⁯‌‌‪‫‍‍‏⁯⁬⁭‮​⁯⁬⁮​‎⁮‬‮([In] string obj0, [In] string obj1, [In] MessageBoxButtons obj2)
    {
      return MessageBox.Show(obj0, obj1, obj2);
    }

    static bool \u202C‎‎‫‭‍‌⁯‪​⁪‭‪⁭‬‬‎​‭‌‌‌‪‮‮‍‫‫‏‪⁮⁮⁬‭⁪⁬‎‪‌‭‮([In] string obj0)
    {
      return Directory.Exists(obj0);
    }

    static DirectoryInfo \u200B​‍‮‎⁭⁫‭‮‫‮‌⁫⁭⁬​‌​⁫‭‎‫‍‌‭⁯‪⁭‫‏⁪‍⁮⁪‫‌‎‭​⁬‮([In] string obj0)
    {
      return Directory.CreateDirectory(obj0);
    }

    static string \u200D‪‭‍⁪‫‬‭‭⁭⁯⁯⁪⁯‫‭‮‪‌⁯⁬​‭​‌⁫⁬‌⁯⁭⁭‭⁭⁯⁮⁯‭⁫‮‫‮([In] string obj0, [In] string obj1)
    {
      return Path.Combine(obj0, obj1);
    }

    static string \u202E‌‫‪‪⁭⁭‌⁯‏‌⁮⁫‎‍‭‎‭‪⁯⁭‎‮⁫‍‪⁬‏⁮⁭‪​‬‬⁮‎‬‎‎‮()
    {
      return Environment.MachineName;
    }

    static string \u200F⁪‮‌‍⁮‬‎⁮⁪⁯‍⁯‮‬⁯⁫‌⁯‮⁪‪⁭‭‮‌⁭‫‭​​‌⁮⁫⁬⁫‮‎‪‪‮()
    {
      return Environment.UserName;
    }

    static WebClient \u200F⁯⁫‪​‮‮‮‎‬‭‏‬‍⁬⁪‭‎‎‌‌⁮‌​‌⁯‌‪⁮⁪⁪‎⁬‍‌⁪‌‎‎‍‮()
    {
      return new WebClient();
    }

    static void \u200B⁮⁭⁭‭‬⁬⁫‪‌‪‍‌‪⁪⁬‏‌‪‍⁪⁬‌‏⁭⁮⁮⁮⁮‎‪‫⁬‫‪⁬​⁬⁪‮‮([In] WebClient obj0, [In] string obj1, [In] string obj2)
    {
      obj0.DownloadFile(obj1, obj2);
    }

    static void \u202E‭‭‌‬⁪‭‮‌⁯‪⁬⁭⁮⁬‌‏⁪‎‭​‏⁮‏‮⁭⁭⁫‮⁮​⁬⁪‭⁯⁪⁭​⁪⁫‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static bool \u206F‏‮​‮‌‌‫⁬‏‭‏‫‭‮⁭‍‍‍‫‬‪‌⁫​‭⁪⁫‮‍⁭‎⁬​‪⁯⁮⁭‪‪‮([In] string obj0)
    {
      return System.IO.File.Exists(obj0);
    }

    static string \u202E‏‪⁭⁮‬‭⁪‫⁬​⁭⁮​‪‌⁭‪‏‫‎​‌‭‪‮‍‪‫⁯⁪⁫‮⁯‫‪‮⁪⁭⁯‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static bool \u200E‍​‎⁪‫‮⁭‌‪⁪‍​‪⁯⁭⁬⁯‎‏‪⁫‪⁮⁮‌⁭‫⁬⁯‍‏⁫‪‫⁫⁬​⁫‬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static void \u200D‍‍⁯⁬‬​‮⁯⁬⁬‍⁭‍‪‍‏⁬‎‌⁬‍‭‫‍⁭‮‭⁫⁯‍‪‎‫‪⁯⁬‭‌‬‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static string \u200D‮‫‪‮‬⁬‪‪⁭‭‬‫‏⁮​⁮‫⁪​⁭‬‪‍‏‬⁭​‌‎‫‌‏⁮‍‮‌⁯⁯‪‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static void \u202A⁪​⁬​⁪‮‫⁮‭‌⁪⁯‌‫‍‫‎⁪‭⁬‌⁬⁭⁪⁮⁪‏​‍⁮‏‌‭‪⁭‫‏⁪‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static System.Type \u206E‏‭‭‮⁯‌‍‏‫‏‬‫‬‫⁬⁪​​‌‎‫⁯‎‏‍‪‍​‎⁭⁭⁯‍‍‮‮‬‮‮‮([In] RuntimeTypeHandle obj0)
    {
      return System.Type.GetTypeFromHandle(obj0);
    }

    static ILog \u202B‎‍⁯⁯⁯⁫‏‌⁭‬‮‫⁬‫‎⁭⁯‪​​‎‫​⁬‌‬⁭​‫‮‮‬‏‭‫⁫‍⁪⁭‮([In] System.Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
