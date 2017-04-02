// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Core.LicenseChecker
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;
using ZoomZoomLicense;

namespace ZoomZoom.Models.Core
{
  internal class LicenseChecker : CoreObject
  {
    private List<License> localLicenses = new List<License>();
    private List<string> macAddresses;

    public override TraceType TraceType
    {
      get
      {
        return TraceType.Application;
      }
    }

    public LicenseChecker()
    {
      this.macAddresses = MacAddresses.GetMacAddresses();
    }

    internal MachineState GetState()
    {
      MachineState machineState = MachineState.Undetermined;
      try
      {
label_2:
        int num1 = -103866810;
        string str1;
        Stream stream;
        while (true)
        {
          int num2 = -1516036435;
          uint num3;
          WebResponse webResponse;
          string plainText;
          string str2;
          string str3;
          string str4;
          string urlLicenseCheck;
          string str5;
          WebRequest webRequest;
          ZoomDB zoomDb;
          Version version;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 1:
              num1 = (int) num3 * -1302631139 ^ 1143490205;
              continue;
            case 2:
              goto label_2;
            case 3:
              version = LicenseChecker.\u202E⁪‌⁮‍‌​‎‫⁫⁭‫‌‭‫‌‬‎⁫⁮‌‮​⁪⁬‍‏‌⁪​⁭‫‍‍‫‫‭‮‪⁮‮(LicenseChecker.\u206A‮‫​‫⁫‮‬‍⁬⁫‌⁪‮‌‮⁮‭⁯‍⁪‏‌⁭⁫‪⁯⁬⁮‏‬‭⁬‏‭‭‍‬⁯‪‮(LicenseChecker.\u200C​‏‪⁭⁬‌‪⁪⁭‏⁬‫‎⁬‫⁯⁯‫‫‏⁫⁭‏⁭⁫‮‫⁯⁬​​‪​‌‌‫‎‌⁫‮()));
              num1 = (int) num3 * 613799006 ^ 1761706099;
              continue;
            case 4:
              LicenseChecker.\u202A‫‏⁯‍​⁯‪‏‏‬‭‮‏⁪‏‏⁫‍‭⁭⁫‭‪‍‏‭⁮‍‫⁮⁬‏‍⁭​⁭‭‌⁬‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2488087537U), (object) str5);
              num1 = (int) num3 * -526270809 ^ 1300627184;
              continue;
            case 5:
              stream = LicenseChecker.\u202C‫‎⁯‮​‌‍‭⁫⁭⁭‌⁮‍⁫‮⁮‫⁭‌‮⁫‪‍‭⁫‫​‮⁫‬⁭⁪⁯⁬‏⁮‌‭‮(webResponse);
              num1 = (int) num3 * -416560762 ^ -1914339752;
              continue;
            case 6:
              string zoomUserName = zoomDb.GetZoomUserName(true);
              plainText = LicenseChecker.\u200B⁭⁬⁮‍‭⁬⁯‮‏‬⁯⁪‍‌⁪⁫⁭‬‫⁪⁬⁪‭⁫‫‎‬‫⁮⁫⁫‬‍‬⁬‫‮‍‏‮(new object[9]
              {
                (object) LicenseChecker.\u206D⁯⁬​‮⁪⁭​​⁯‎⁪​‫‮​‏⁯⁮​⁪⁬‍‮‫⁪‍⁬‌​⁮‮​‪‪‎‍⁭‏⁪‮(),
                (object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(643205451U),
                (object) str3,
                (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(750811209U),
                (object) LicenseChecker.\u200C‏‪‍‎‎‬⁮‏‪⁪⁮⁪‍‌⁫‎⁪‭‏‏⁬‎‍​‍⁮‭⁯‌‬‫⁫‍‌​⁬​‌‫‮(),
                (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(750811209U),
                (object) zoomUserName,
                (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1162138903U),
                (object) version
              });
              num1 = (int) num3 * -1951430430 ^ 111288900;
              continue;
            case 7:
              str3 = LicenseChecker.\u202E‌‍‪‏‮‬⁭‌⁯‮‌‭⁭⁭⁪​⁭​‍‪⁭‭⁫‪‍‏‌​⁭​‫‭⁯‪‭⁭‎‫⁪‮((object) this.macAddresses[0]);
              num1 = (int) num3 * -581074390 ^ 1558951827;
              continue;
            case 8:
              str5 = LicenseChecker.\u206F‍⁪‌‮‭​‪​‫⁭‫⁫‎‍‭​‍⁮‬​⁮‬‌‌‌‎‮‭⁫⁫‍‪​⁬‪‌‌‏‍‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2926653085U), (object) urlLicenseCheck, (object) str4);
              num1 = (int) num3 * -1043681111 ^ 637906417;
              continue;
            case 9:
              LicenseChecker.\u202A‫‏⁯‍​⁯‪‏‏‬‭‮‏⁪‏‏⁫‍‭⁭⁫‭‪‍‏‭⁮‍‫⁮⁬‏‍⁭​⁭‭‌⁬‮(CoreObject.log, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3350383145U), (object) plainText);
              num1 = (int) num3 * -304282680 ^ -1288921387;
              continue;
            case 10:
              zoomDb = new ZoomDB();
              num1 = (int) num3 * -1805759386 ^ -2116963830;
              continue;
            case 11:
              LicenseChecker.\u202A‫‏⁯‍​⁯‪‏‏‬‭‮‏⁪‏‏⁫‍‭⁭⁫‭‪‍‏‭⁮‍‫⁮⁬‏‍⁭​⁭‭‌⁬‮(CoreObject.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4023968219U), (object) str4);
              num1 = (int) num3 * 2103877556 ^ -169461589;
              continue;
            case 12:
              str2 = Encryption.StringCipher.Encrypt(plainText, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(153602125U));
              LicenseChecker.\u202A‫‏⁯‍​⁯‪‏‏‬‭‮‏⁪‏‏⁫‍‭⁭⁫‭‪‍‏‭⁮‍‫⁮⁬‏‍⁭​⁭‭‌⁬‮(CoreObject.log, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1215693063U), (object) str2);
              num1 = (int) num3 * -1397829613 ^ 631394824;
              continue;
            case 13:
              str1 = string.Empty;
              num1 = (int) num3 * 943820283 ^ 16833328;
              continue;
            case 14:
              urlLicenseCheck = this.Engine.Settings.URL_LicenseCheck;
              num1 = (int) num3 * 718955722 ^ -1329547427;
              continue;
            case 15:
              webRequest = LicenseChecker.\u202E‌‪‏‍​⁫‪⁬⁭⁫‌‪‬‭‫‪‫‮⁮‏⁫‪‬⁫‮⁬‍‫‏‮‎‎‫⁯⁫‎‫‍‌‮(str5);
              num1 = (int) num3 * 49361408 ^ 2046884289;
              continue;
            case 16:
              webResponse = LicenseChecker.\u206E⁭⁬‭​‍⁮‌⁫⁭⁮⁭‫‮​⁬​⁬‌⁫⁭⁯⁭⁪⁬‬⁬⁫⁯‎⁬⁭‪‭​⁪‮⁬⁭‌‮(webRequest);
              num1 = (int) num3 * 1386869246 ^ 1696601456;
              continue;
            case 17:
              str4 = LicenseChecker.\u206B‏​‏‌‌⁬⁯⁭‏‭‏‏​‪⁫⁫‎⁭​⁬‮‬⁯⁭​⁪‌⁭‭‭​⁭‏‫⁯⁫‪‫‭‮(str2);
              num1 = (int) num3 * 1254468118 ^ 348026222;
              continue;
            default:
              goto label_20;
          }
        }
label_20:
        StreamReader streamReader = LicenseChecker.\u202C⁯‎‫⁫⁬⁪‬⁫⁪‭⁯⁫‌‍‪‭‌⁪⁮‫‮⁫⁮​⁮⁮​⁪⁮⁮⁭‎‭‏‌‌‮‫‫‮(stream);
        try
        {
label_22:
          int num2 = -225146436;
          while (true)
          {
            int num3 = -1516036435;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_22;
              case 1:
                str1 = LicenseChecker.\u206A⁭‍⁭‪​‏‍⁫‬⁯‍‎‏‬‎‬‏⁮‍‫‍⁫⁯⁬⁯⁪⁭‫‭‮‭‪‪‮‬⁫‎‎‍‮((TextReader) streamReader);
                num2 = (int) num4 * -964810104 ^ 222321575;
                continue;
              case 2:
                num2 = (int) num4 * -133399129 ^ -1570608744;
                continue;
              default:
                goto label_32;
            }
          }
        }
        finally
        {
          if (streamReader != null)
          {
label_27:
            int num2 = -372437916;
            while (true)
            {
              int num3 = -1516036435;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 1:
                  LicenseChecker.\u200F⁪‍‮‪‫‭‬‏‍‬‫​‬⁭​⁬‪​‪‎⁫‏‮⁭‍⁭‫⁭⁯⁬⁫‮‭‏‫⁯‍‮((IDisposable) streamReader);
                  num2 = (int) num4 * 1281695228 ^ 642986623;
                  continue;
                case 2:
                  num2 = (int) num4 * 1863411420 ^ 572362261;
                  continue;
                case 3:
                  goto label_27;
                default:
                  goto label_31;
              }
            }
          }
label_31:;
        }
label_32:
        bool flag1 = LicenseChecker.\u202B⁬⁪⁯⁬‌‫⁪‎‎​​‏‎⁫‏⁮⁭⁮‭⁭‬‫‭‎⁪⁪⁬​⁭‭⁪⁮⁯‭​⁫⁯​‬‮(str1, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4146815863U));
label_33:
        int num5 = -1398162700;
        while (true)
        {
          int num2 = -1516036435;
          uint num3;
          bool flag2;
          bool flag3;
          bool flag4;
          switch ((num3 = (uint) (num5 ^ num2)) % 24U)
          {
            case 0:
              machineState = MachineState.Pending;
              num5 = (int) num3 * -1144813352 ^ 1635887544;
              continue;
            case 1:
              num5 = (int) num3 * 1114474306 ^ 1555894421;
              continue;
            case 2:
              num5 = -75406287;
              continue;
            case 3:
              int num4 = !flag2 ? 937360658 : (num4 = 1240315283);
              int num6 = (int) num3 * 1357336007;
              num5 = num4 ^ num6;
              continue;
            case 5:
              goto label_33;
            case 6:
              machineState = MachineState.Licensed;
              num5 = (int) num3 * -2104502439 ^ -1829032125;
              continue;
            case 7:
              machineState = MachineState.Error;
              num5 = (int) num3 * 323155294 ^ 1971894369;
              continue;
            case 8:
              num5 = (int) num3 * -1277295115 ^ -672376233;
              continue;
            case 9:
              machineState = MachineState.Unlicensed;
              num5 = (int) num3 * 199512461 ^ 1076104761;
              continue;
            case 10:
              num5 = (int) num3 * 607818026 ^ 626191651;
              continue;
            case 11:
              num5 = (int) num3 * 572608094 ^ 40739216;
              continue;
            case 12:
              num5 = (int) num3 * -991792224 ^ 1160169939;
              continue;
            case 13:
              num5 = (int) num3 * 1273920562 ^ 592236781;
              continue;
            case 14:
              num5 = (int) num3 * -2015179524 ^ -1241600385;
              continue;
            case 15:
              flag4 = LicenseChecker.\u202A⁬‬‫‫‬‫‪‏‪‎⁪⁬⁯‪‬​‭‍⁭‎‪⁫‫‌​⁫‎‭‭‍⁪‏‮‭​⁬‮⁪‍‮(str1, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(968488618U));
              num5 = -1185539241;
              continue;
            case 16:
              int num7;
              num5 = num7 = !LicenseChecker.\u202B⁬⁪⁯⁬‌‫⁪‎‎​​‏‎⁫‏⁮⁭⁮‭⁭‬‫‭‎⁪⁪⁬​⁭‭⁪⁮⁯‭​⁫⁯​‬‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2970581667U)) ? -1911865877 : (num7 = -2101963768);
              continue;
            case 17:
              int num8 = !flag1 ? -1437313005 : (num8 = -1865793206);
              int num9 = (int) num3 * -1980514770;
              num5 = num8 ^ num9;
              continue;
            case 18:
              int num10 = flag4 ? 111284391 : (num10 = 1187202624);
              int num11 = (int) num3 * 697704283;
              num5 = num10 ^ num11;
              continue;
            case 19:
              flag2 = LicenseChecker.\u202B⁬⁪⁯⁬‌‫⁪‎‎​​‏‎⁫‏⁮⁭⁮‭⁭‬‫‭‎⁪⁪⁬​⁭‭⁪⁮⁯‭​⁫⁯​‬‮(str1, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(913572364U));
              num5 = -1390357282;
              continue;
            case 20:
              num5 = (int) num3 * 1875990516 ^ 1644456949;
              continue;
            case 21:
              machineState = MachineState.LicenseOutdated;
              num5 = (int) num3 * -1180469727 ^ -1190680086;
              continue;
            case 22:
              flag3 = LicenseChecker.\u202B⁬⁪⁯⁬‌‫⁪‎‎​​‏‎⁫‏⁮⁭⁮‭⁭‬‫‭‎⁪⁪⁬​⁭‭⁪⁮⁯‭​⁫⁯​‬‮(str1, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(557189150U));
              num5 = -1023331998;
              continue;
            case 23:
              int num12 = !flag3 ? 1282600670 : (num12 = 1324506941);
              int num13 = (int) num3 * -1942304708;
              num5 = num12 ^ num13;
              continue;
            default:
              goto label_61;
          }
        }
      }
      catch (Exception ex)
      {
        LicenseChecker.\u200E⁮⁬⁬‬‌‍​​​⁬⁭‫​‪⁫⁭‭‫​‫‬‮‭⁬‮‫⁬⁫‍⁬‫‮‌​⁯‏⁪⁬‏‮(CoreObject.log, (object) ex);
label_58:
        int num1 = -1501644866;
        while (true)
        {
          int num2 = -1516036435;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1139749725 ^ -55033706;
              continue;
            case 2:
              goto label_58;
            default:
              goto label_61;
          }
        }
      }
label_61:
      return machineState;
    }

    private void LoadLicenses()
    {
label_1:
      int num1 = 1353376370;
      while (true)
      {
        int num2 = 1828484675;
        uint num3;
        string[] strArray;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            int num4 = flag ? 1576644718 : (num4 = 1315324965);
            int num5 = (int) num3 * 873964894;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag = LicenseChecker.\u202C‪‌​‌⁫⁯⁬‍‏⁬⁫⁬‏⁪‭⁪‮⁬‬‮‬‪⁬‬⁭⁬‬⁭‮‬⁯‬‍⁭⁪‪⁪⁬⁮‮(Engine.Instance.Settings.LicenseRoot);
            num1 = (int) num3 * -1357496633 ^ 1093177756;
            continue;
          case 2:
            ((IEnumerable<string>) strArray).ToList<string>().ForEach((Action<string>) (x =>
            {
              this.LoadLicense(x);
label_1:
              int num2 = 405112738;
              while (true)
              {
                int num3 = 704441904;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    num2 = (int) num4 * 2127283173 ^ -700251552;
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
            }));
            num1 = (int) num3 * -2098667440 ^ 707013072;
            continue;
          case 3:
            num1 = (int) num3 * 390549626 ^ 488230171;
            continue;
          case 4:
            strArray = LicenseChecker.\u202E⁫‫‪‪‫‮‍⁭‪‏⁯‮⁬‬⁯⁬‫⁭⁬⁫⁫‮⁫‮​‭‭⁪⁪‍⁭⁮⁯⁬‬‮‭‮‮‮(Engine.Instance.Settings.LicenseRoot);
            num1 = (int) num3 * 1350797057 ^ -1427032019;
            continue;
          case 5:
            num1 = (int) num3 * -130026450 ^ 203582393;
            continue;
          case 6:
            goto label_3;
          case 7:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    private void LoadLicense(string localFile)
    {
label_1:
      int num1 = 1806115735;
      while (true)
      {
        int num2 = 1858529304;
        uint num3;
        License localLicense;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            num1 = (int) num3 * 268603115 ^ -852106926;
            continue;
          case 1:
            num1 = (int) num3 * -1038605348 ^ 709638707;
            continue;
          case 2:
            CoreUtils.DeleteFile(localFile);
            num1 = (int) num3 * -568585503 ^ -597849679;
            continue;
          case 3:
            flag = !LicenseHelper.ValidateLicense(localLicense);
            num1 = 1093011991;
            continue;
          case 4:
            localLicense = LicenseHelper.Load(localFile);
            int num5 = localLicense != null ? -414022339 : (num5 = -1207443804);
            int num6 = (int) num3 * 1423503198;
            num1 = num5 ^ num6;
            continue;
          case 5:
            CoreUtils.DeleteFile(localFile);
            num1 = (int) num3 * 2035642254 ^ 536449254;
            continue;
          case 6:
            if (!(localLicense.DateExpires < DateTime.Now))
            {
              num1 = (int) num3 * 586689045 ^ -217730561;
              continue;
            }
            num4 = 1;
            break;
          case 7:
            num4 = LicenseChecker.\u202B‫​‮‏⁭‮⁪‍⁬⁭​⁯‪⁮‎‭⁪⁯​⁬‬‭⁬⁪‮‫⁪‫‬‭‍⁯‎‬⁮‪‍‌‌‮(LicenseChecker.\u200B‪⁬‫⁭‏​⁯‍‬⁮‭⁬​‫⁪‭‬‎‮⁫‭⁯⁭‪​⁪‎‌‭⁭‌⁮⁮‬⁭​‎​‍‮(localLicense.Node), LicenseChecker.\u200B‪⁬‫⁭‏​⁯‍‬⁮‭⁬​‫⁪‭‬‎‮⁫‭⁯⁭‪​⁪‎‌‭⁭‌⁮⁮‬⁭​‎​‍‮(LicenseChecker.\u206D⁯⁬​‮⁪⁭​​⁯‎⁪​‫‮​‏⁯⁮​⁪⁬‍‮‫⁪‍⁬‌​⁮‮​‪‪‎‍⁭‏⁪‮())) ? 1 : 0;
            break;
          case 8:
            goto label_3;
          case 9:
            goto label_1;
          case 10:
            num1 = (int) num3 * -219037199 ^ 2123309791;
            continue;
          case 11:
            num1 = 1268572454;
            continue;
          case 12:
            int num7 = flag ? -2047095899 : (num7 = -1861277428);
            int num8 = (int) num3 * -388759493;
            num1 = num7 ^ num8;
            continue;
          default:
            goto label_18;
        }
        int num9;
        num1 = num9 = num4 != 0 ? 851665440 : (num9 = 1266792440);
      }
label_18:
      return;
label_3:;
    }

    static Assembly \u200C​‏‪⁭⁬‌‪⁪⁭‏⁬‫‎⁬‫⁯⁯‫‫‏⁫⁭‏⁭⁫‮‫⁯⁬​​‪​‌‌‫‎‌⁫‮()
    {
      return Assembly.GetExecutingAssembly();
    }

    static AssemblyName \u206A‮‫​‫⁫‮‬‍⁬⁫‌⁪‮‌‮⁮‭⁯‍⁪‏‌⁭⁫‪⁯⁬⁮‏‬‭⁬‏‭‭‍‬⁯‪‮([In] Assembly obj0)
    {
      return obj0.GetName();
    }

    static Version \u202E⁪‌⁮‍‌​‎‫⁫⁭‫‌‭‫‌‬‎⁫⁮‌‮​⁪⁬‍‏‌⁪​⁭‫‍‍‫‫‭‮‪⁮‮([In] AssemblyName obj0)
    {
      return obj0.Version;
    }

    static string \u202E‌‍‪‏‮‬⁭‌⁯‮‌‭⁭⁭⁪​⁭​‍‪⁭‭⁫‪‍‏‌​⁭​‫‭⁯‪‭⁭‎‫⁪‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u206D⁯⁬​‮⁪⁭​​⁯‎⁪​‫‮​‏⁯⁮​⁪⁬‍‮‫⁪‍⁬‌​⁮‮​‪‪‎‍⁭‏⁪‮()
    {
      return Environment.MachineName;
    }

    static string \u200C‏‪‍‎‎‬⁮‏‪⁪⁮⁪‍‌⁫‎⁪‭‏‏⁬‎‍​‍⁮‭⁯‌‬‫⁫‍‌​⁬​‌‫‮()
    {
      return Environment.UserName;
    }

    static string \u200B⁭⁬⁮‍‭⁬⁯‮‏‬⁯⁪‍‌⁪⁫⁭‬‫⁪⁬⁪‭⁫‫‎‬‫⁮⁫⁫‬‍‬⁬‫‮‍‏‮([In] object[] obj0)
    {
      return string.Concat(obj0);
    }

    static void \u202A‫‏⁯‍​⁯‪‏‏‬‭‮‏⁪‏‏⁫‍‭⁭⁫‭‪‍‏‭⁮‍‫⁮⁬‏‍⁭​⁭‭‌⁬‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static string \u206B‏​‏‌‌⁬⁯⁭‏‭‏‏​‪⁫⁫‎⁭​⁬‮‬⁯⁭​⁪‌⁭‭‭​⁭‏‫⁯⁫‪‫‭‮([In] string obj0)
    {
      return HttpUtility.UrlEncode(obj0);
    }

    static string \u206F‍⁪‌‮‭​‪​‫⁭‫⁫‎‍‭​‍⁮‬​⁮‬‌‌‌‎‮‭⁫⁫‍‪​⁬‪‌‌‏‍‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static WebRequest \u202E‌‪‏‍​⁫‪⁬⁭⁫‌‪‬‭‫‪‫‮⁮‏⁫‪‬⁫‮⁬‍‫‏‮‎‎‫⁯⁫‎‫‍‌‮([In] string obj0)
    {
      return WebRequest.Create(obj0);
    }

    static WebResponse \u206E⁭⁬‭​‍⁮‌⁫⁭⁮⁭‫‮​⁬​⁬‌⁫⁭⁯⁭⁪⁬‬⁬⁫⁯‎⁬⁭‪‭​⁪‮⁬⁭‌‮([In] WebRequest obj0)
    {
      return obj0.GetResponse();
    }

    static Stream \u202C‫‎⁯‮​‌‍‭⁫⁭⁭‌⁮‍⁫‮⁮‫⁭‌‮⁫‪‍‭⁫‫​‮⁫‬⁭⁪⁯⁬‏⁮‌‭‮([In] WebResponse obj0)
    {
      return obj0.GetResponseStream();
    }

    static StreamReader \u202C⁯‎‫⁫⁬⁪‬⁫⁪‭⁯⁫‌‍‪‭‌⁪⁮‫‮⁫⁮​⁮⁮​⁪⁮⁮⁭‎‭‏‌‌‮‫‫‮([In] Stream obj0)
    {
      return new StreamReader(obj0);
    }

    static string \u206A⁭‍⁭‪​‏‍⁫‬⁯‍‎‏‬‎‬‏⁮‍‫‍⁫⁯⁬⁯⁪⁭‫‭‮‭‪‪‮‬⁫‎‎‍‮([In] TextReader obj0)
    {
      return obj0.ReadToEnd();
    }

    static void \u200F⁪‍‮‪‫‭‬‏‍‬‫​‬⁭​⁬‪​‪‎⁫‏‮⁭‍⁭‫⁭⁯⁬⁫‮‭‏‫⁯‍‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static bool \u202B⁬⁪⁯⁬‌‫⁪‎‎​​‏‎⁫‏⁮⁭⁮‭⁭‬‫‭‎⁪⁪⁬​⁭‭⁪⁮⁯‭​⁫⁯​‬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u202A⁬‬‫‫‬‫‪‏‪‎⁪⁬⁯‪‬​‭‍⁭‎‪⁫‫‌​⁫‎‭‭‍⁪‏‮‭​⁬‮⁪‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static void \u200E⁮⁬⁬‬‌‍​​​⁬⁭‫​‪⁫⁭‭‫​‫‬‮‭⁬‮‫⁬⁫‍⁬‫‮‌​⁯‏⁪⁬‏‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static bool \u202C‪‌​‌⁫⁯⁬‍‏⁬⁫⁬‏⁪‭⁪‮⁬‬‮‬‪⁬‬⁭⁬‬⁭‮‬⁯‬‍⁭⁪‪⁪⁬⁮‮([In] string obj0)
    {
      return Directory.Exists(obj0);
    }

    static string[] \u202E⁫‫‪‪‫‮‍⁭‪‏⁯‮⁬‬⁯⁬‫⁭⁬⁫⁫‮⁫‮​‭‭⁪⁪‍⁭⁮⁯⁬‬‮‭‮‮‮([In] string obj0)
    {
      return Directory.GetFiles(obj0);
    }

    static string \u200B‪⁬‫⁭‏​⁯‍‬⁮‭⁬​‫⁪‭‬‎‮⁫‭⁯⁭‪​⁪‎‌‭⁭‌⁮⁮‬⁭​‎​‍‮([In] string obj0)
    {
      return obj0.ToUpper();
    }

    static bool \u202B‫​‮‏⁭‮⁪‍⁬⁭​⁯‪⁮‎‭⁪⁯​⁬‬‭⁬⁪‮‫⁪‫‬‭‍⁯‎‬⁮‪‍‌‌‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }
  }
}
