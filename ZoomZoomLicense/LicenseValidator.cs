// Decompiled with JetBrains decompiler
// Type: ZoomZoomLicense.LicenseValidator
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ZoomZoomLicense
{
  public class LicenseValidator
  {
    public bool IsValid
    {
      get
      {
label_1:
        int num1 = 2098717515;
        bool flag;
        while (true)
        {
          int num2 = 1012894771;
          uint num3;
          List<string> macAddresses;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              flag = false;
              num1 = 2010337185;
              continue;
            case 1:
              num1 = (int) num3 * 1948763268 ^ 508100283;
              continue;
            case 2:
              num1 = 1938295162;
              continue;
            case 3:
              int num4 = macAddresses.Contains(this.License.Node) ? 882571178 : (num4 = 1337074380);
              int num5 = (int) num3 * -1282994074;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * -1290710991 ^ -848457005;
              continue;
            case 5:
              flag = false;
              num1 = (int) num3 * 846999910 ^ -769533628;
              continue;
            case 7:
              flag = true;
              num1 = (int) num3 * -1979975107 ^ 1919891930;
              continue;
            case 8:
              num1 = (int) num3 * 752309168 ^ 1114045364;
              continue;
            case 9:
              macAddresses = MacAddresses.GetMacAddresses();
              num1 = (int) num3 * -118635174 ^ 2026889704;
              continue;
            case 10:
              new License().Node = macAddresses.FirstOrDefault<string>();
              int num6 = !LicenseValidator.\u202E‮​⁮‮‪‮⁫⁪‮‍‬⁯⁬⁭‮⁪‬‮‏‏‎‎⁫‎‬⁮‏‮‍‫‭‭‌‫⁭‍‪⁬⁮‮(Encryption.StringCipher.Decrypt(this.License.RequestToken, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3405955081U)), LicenseValidator.\u202D‪⁮⁫‎‎‮⁮⁮⁬⁪⁬‍‎‌⁮‪⁮‮‎​‏‭⁬⁬⁫⁯⁭​⁯‪‬⁫​⁭‭⁮‏‪‮(new string[5]
              {
                LicenseValidator.\u200D‫‭‫‬‬‫⁬‍‮‭⁬‬‬‎‭⁬⁪⁪⁪⁮⁯‪​⁭⁪⁫⁮‍‌‌‍⁮‎⁫‏⁯‪​⁫‮(),
                \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3568506100U),
                LicenseValidator.\u200C‫‬‎‭⁯‫⁪‏‪⁬⁬‭‭‫⁪‮⁮‌‌‎‪⁫⁬⁯‎‪⁯⁫⁯‏⁪‮‏‍⁮⁭‮‍⁭‮(),
                \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1783281445U),
                macAddresses.FirstOrDefault<string>()
              })) ? -2125480455 : (num6 = -117605232);
              int num7 = (int) num3 * -5503448;
              num1 = num6 ^ num7;
              continue;
            case 11:
              goto label_1;
            case 12:
              num1 = (int) num3 * -350129148 ^ -1651677787;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return flag;
      }
    }

    public bool IsExpired
    {
      get
      {
        bool flag = this.License.DateExpires < DateTime.Now;
label_1:
        int num1 = 1770843165;
        while (true)
        {
          int num2 = 1690229110;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 2100458620 ^ -1874579515;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return flag;
      }
    }

    public License License { get; set; }

    public LicenseValidator(License license)
    {
      this.License = new License();
      this.License.MachineName = license.MachineName;
      this.License.Licensee = license.Licensee;
      this.License.Node = license.Node;
      this.License.DateExpires = license.DateExpires;
    }

    static string \u200D‫‭‫‬‬‫⁬‍‮‭⁬‬‬‎‭⁬⁪⁪⁪⁮⁯‪​⁭⁪⁫⁮‍‌‌‍⁮‎⁫‏⁯‪​⁫‮()
    {
      return Environment.MachineName;
    }

    static string \u200C‫‬‎‭⁯‫⁪‏‪⁬⁬‭‭‫⁪‮⁮‌‌‎‪⁫⁬⁯‎‪⁯⁫⁯‏⁪‮‏‍⁮⁭‮‍⁭‮()
    {
      return Environment.UserName;
    }

    static string \u202D‪⁮⁫‎‎‮⁮⁮⁬⁪⁬‍‎‌⁮‪⁮‮‎​‏‭⁬⁬⁫⁯⁭​⁯‪‬⁫​⁭‭⁮‏‪‮([In] string[] obj0)
    {
      return string.Concat(obj0);
    }

    static bool \u202E‮​⁮‮‪‮⁫⁪‮‍‬⁯⁬⁭‮⁪‬‮‏‏‎‎⁫‎‬⁮‏‮‍‫‭‭‌‫⁭‍‪⁬⁮‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }
  }
}
