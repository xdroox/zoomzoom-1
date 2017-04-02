// Decompiled with JetBrains decompiler
// Type: ZoomZoomLicense.LicenseHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ZoomZoomLicense
{
  public static class LicenseHelper
  {
    private static string LicenseServer;

    public static License Load(string fileName)
    {
      License license = (License) null;
      try
      {
label_2:
        int num1 = 44338411;
        while (true)
        {
          int num2 = 371792680;
          uint num3;
          TextReader textReader;
          XmlSerializer xmlSerializer;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              LicenseHelper.\u206D‪⁬‏‭‮‎‪‌‎⁬‌‮‪⁬‫‍⁮⁫‏‍‎​‎​⁮‭⁮‬⁫⁯‭⁫‮‌⁫‪‫⁯‪‮(textReader);
              num1 = (int) num3 * 1259755027 ^ -684059904;
              continue;
            case 2:
              // ISSUE: type reference
              xmlSerializer = LicenseHelper.\u200F⁫‌⁬‭‫⁬‮‮‎​‏‭‍‌‮⁫‭‍⁪⁪‭⁮⁫‍‏‫‪‭⁭‫⁭‪‌⁭‍‎⁮⁮⁮‮(LicenseHelper.\u206D‎‍​‏‌⁭‌⁯​‫‌‎‍‏‬‮‏⁭‪‬⁫‮⁬‍⁫⁭⁭‎‏‎​⁬⁮⁪⁫⁯‮⁫‍‮(__typeref (License)));
              num1 = (int) num3 * -1415869284 ^ 1058800764;
              continue;
            case 3:
              goto label_2;
            case 4:
              license = (License) LicenseHelper.\u206E‮‫‫‪‭⁬‏⁪‫‌⁪‌‏⁭​‫⁬⁬‌‬‭⁯⁮⁮⁬‍‏⁬‫‮⁫⁭‏⁫‮⁭‪⁮⁪‮(xmlSerializer, textReader);
              num1 = (int) num3 * 1027082432 ^ -1187014021;
              continue;
            case 5:
              textReader = (TextReader) null;
              xmlSerializer = (XmlSerializer) null;
              num1 = (int) num3 * 1901401305 ^ -1698070874;
              continue;
            case 6:
              textReader = (TextReader) LicenseHelper.\u202A‎‭‬‮​⁭‎⁮‬⁭‪⁯‮‬‬‌‫‭‏⁯⁯‪⁪‭‮⁫⁭‮‌‏‌​‮‎⁯⁫⁯‏‌‮(fileName);
              num1 = (int) num3 * -32846662 ^ 408048567;
              continue;
            default:
              goto label_16;
          }
        }
      }
      catch (Exception ex)
      {
label_10:
        int num1 = 321483533;
        while (true)
        {
          int num2 = 371792680;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              LicenseHelper.\u200F‫‏⁯⁪‌⁪‍‍‮⁪⁭⁪​‬⁭‎⁯‫⁪‬‭⁯‬‍‫⁮⁫⁯‫⁫⁭⁮‭​⁯‏‌‮‍‮(LicenseHelper.\u200E‮‫⁮⁬⁯‮⁪⁪‮‍‮⁬‎‍‎‮⁭‭‫‬‭‍‪‫⁮‍​⁪⁫‭‫‭⁯‫‬⁫‮‏⁭‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1588592788U), LicenseHelper.\u202B‭⁬⁬⁪‮⁬‪‬‎‪‬‭⁭⁪‮‫⁭‎‌⁮​‏‍‮‫⁮⁪⁯‍⁮​⁯‎⁮⁮‍⁫‏‌‮(ex)));
              num1 = (int) num3 * 610477975 ^ -2073624651;
              continue;
            case 1:
              num1 = (int) num3 * -776737556 ^ -505458164;
              continue;
            case 2:
              goto label_10;
            case 4:
              num1 = (int) num3 * -1126050596 ^ -336645759;
              continue;
            case 5:
              num1 = (int) num3 * -1522604402 ^ 108854222;
              continue;
            default:
              goto label_16;
          }
        }
      }
label_16:
      return license;
    }

    public static bool Save(License license, string filePath)
    {
      bool flag1 = false;
      try
      {
        // ISSUE: type reference
        XmlSerializer xmlSerializer = LicenseHelper.\u200F⁫‌⁬‭‫⁬‮‮‎​‏‭‍‌‮⁫‭‍⁪⁪‭⁮⁫‍‏‫‪‭⁭‫⁭‪‌⁭‍‎⁮⁮⁮‮(LicenseHelper.\u206D‎‍​‏‌⁭‌⁯​‫‌‎‍‏‬‮‏⁭‪‬⁫‮⁬‍⁫⁭⁭‎‏‎​⁬⁮⁪⁫⁯‮⁫‍‮(__typeref (License)));
        TextWriter textWriter = (TextWriter) LicenseHelper.\u200F⁯⁪⁫‫‎⁭‌‌‎⁫⁯‎‍‮⁮⁮⁬‎​‍‮‭⁬‭‭​⁭⁬‏‭‭‎‍‭‬‍‌‭⁯‮(filePath);
        try
        {
label_3:
          int num1 = 192322250;
          while (true)
          {
            int num2 = 675845724;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 6U)
            {
              case 0:
                LicenseHelper.\u200D‌⁬‌‮‍‏⁭⁫⁫⁬​‮​‫⁪‬‏‍‫‍⁭⁯⁭⁭⁭‪‏‫‏‬‎‫⁪⁮‍‮​⁫‫‮(textWriter);
                num1 = (int) num3 * 567760209 ^ -231811281;
                continue;
              case 1:
                num1 = (int) num3 * -2063116062 ^ -1499146981;
                continue;
              case 2:
                num1 = (int) num3 * -402172395 ^ 579279800;
                continue;
              case 3:
                goto label_3;
              case 4:
                LicenseHelper.\u206C​‬​‏‫‌‮⁮⁫⁭‬⁭⁭⁪⁮‮⁪‎​‎‬‬‫⁪⁯‭‎⁭‍​⁪‪⁮⁪‌⁯‏‎⁭‮(xmlSerializer, textWriter, (object) license);
                num1 = (int) num3 * 225734057 ^ 2046048184;
                continue;
              default:
                goto label_15;
            }
          }
        }
        finally
        {
          if (textWriter != null)
          {
label_10:
            int num1 = 2111390777;
            while (true)
            {
              int num2 = 675845724;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * -1906065216 ^ 1063042407;
                  continue;
                case 1:
                  LicenseHelper.\u206C⁯‎‌‮⁯⁬⁯‬⁯‌⁭‌‌‏⁯⁯‍⁯‮⁬‭‌⁭‮⁫⁪⁫⁬⁯‍⁭‌‎​‌​‍‌‎‮((IDisposable) textWriter);
                  num1 = (int) num3 * 198480945 ^ 2142788805;
                  continue;
                case 2:
                  goto label_10;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
label_15:
        flag1 = true;
      }
      catch (Exception ex)
      {
label_17:
        int num1 = 1180652104;
        while (true)
        {
          int num2 = 675845724;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              LicenseHelper.\u200F‫‏⁯⁪‌⁪‍‍‮⁪⁭⁪​‬⁭‎⁯‫⁪‬‭⁯‬‍‫⁮⁫⁯‫⁫⁭⁮‭​⁯‏‌‮‍‮(LicenseHelper.\u200E‭‍⁬‫⁮‬⁬⁮​⁮⁮‍⁬‮⁪⁬⁬⁯‌⁯⁮⁭‮⁭‏‍⁮‪‫‭⁬‎⁭‮‮⁪‫⁪‬‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3204850362U), (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3304677717U), (object) LicenseHelper.\u202B‭⁬⁬⁪‮⁬‪‬‎‪‬‭⁭⁪‮‫⁭‎‌⁮​‏‍‮‫⁮⁪⁯‍⁮​⁯‎⁮⁮‍⁫‏‌‮(ex), (object) ex));
              num1 = (int) num3 * 32164050 ^ 622819849;
              continue;
            case 2:
              goto label_17;
            default:
              goto label_20;
          }
        }
      }
label_20:
      bool flag2 = flag1;
label_21:
      int num4 = 285696990;
      while (true)
      {
        int num1 = 675845724;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_21;
          case 1:
            num4 = (int) num2 * 284310314 ^ 756858104;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      return flag2;
    }

    public static bool ValidateLicense(License localLicense)
    {
      bool flag;
      try
      {
        HttpClient httpClient = LicenseHelper.\u202A‭⁮⁬‌⁯⁭⁯⁪​‎‏‍‌⁫⁬‌‮‬⁭‍‮‌‮‎⁪‫‬⁭‌‍⁯⁪​⁪⁯⁭⁮‪⁪‮();
label_2:
        int num1 = -1801571015;
        while (true)
        {
          int num2 = -1698105259;
          uint num3;
          string str;
          HttpResponseMessage result1;
          License result2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              flag = true;
              num1 = -87800919;
              continue;
            case 1:
              num1 = (int) num3 * 2008935587 ^ 1948716983;
              continue;
            case 2:
              if (result2.DateExpires == localLicense.DateExpires)
              {
                num1 = (int) num3 * -928711233 ^ 126615497;
                continue;
              }
              break;
            case 3:
              num4 = LicenseHelper.\u206A‬‭⁪⁫⁮‌‭‪‪⁯⁫⁭‪‭‪⁭‭‬‍⁭⁭‍‪⁮​⁭⁬⁮‍‏⁯⁯⁯‮‮‪⁫⁪⁯‮(result2.RequestToken, localLicense.RequestToken) ? 1 : 0;
              goto label_7;
            case 4:
              flag = false;
              num1 = (int) num3 * 2103174008 ^ 200965616;
              continue;
            case 5:
              str = LicenseHelper.\u200E‮‫⁮⁬⁯‮⁪⁪‮‍‮⁬‎‍‎‮⁭‭‫‬‭‍‪‫⁮‍​⁪⁫‭‫‭⁯‫‬⁫‮‏⁭‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1955892746U), localLicense.Node);
              num1 = (int) num3 * -926792795 ^ -593743430;
              continue;
            case 6:
              result1 = LicenseHelper.\u200B‏⁪‌‭‎⁯⁮‬⁪‫‍⁯⁮‍‫‏‪⁪‫‮‏‏‎⁪⁪‭⁯⁫‌‫‍‏‌‫‫⁬‪‭‍‮(httpClient, str).get_Result();
              int num5 = LicenseHelper.\u202B‬‭⁯‍‬⁪‬⁪‪‏⁪‮⁮‍‎⁯⁭‫‫⁬‍⁭​‎⁯‪‬​‭‏‪⁫⁪​⁬⁭⁫⁯‎‮(result1) ? -909136120 : (num5 = -856464655);
              int num6 = (int) num3 * 572922087;
              num1 = num5 ^ num6;
              continue;
            case 7:
              result2 = ((Task<License>) HttpContentExtensions.ReadAsAsync<License>(LicenseHelper.\u202A​‭⁯⁪‏⁮⁬‌‌‌⁮‍‎⁫‏⁭‍‬‎⁯⁪⁭​‫⁬⁬‎‍⁬‎‫‫‌‪‍⁪⁯‎‏‮(result1))).get_Result();
              num1 = (int) num3 * -521139299 ^ -760603430;
              continue;
            case 8:
              goto label_2;
            case 9:
              goto label_14;
            case 11:
              if (LicenseHelper.\u206A‬‭⁪⁫⁮‌‭‪‪⁯⁫⁭‪‭‪⁭‭‬‍⁭⁭‍‪⁮​⁭⁬⁮‍‏⁯⁯⁯‮‮‪⁫⁪⁯‮(result2.Node, localLicense.Node))
              {
                num1 = (int) num3 * -643669904 ^ 2014759194;
                continue;
              }
              break;
            case 12:
              if (LicenseHelper.\u206A‬‭⁪⁫⁮‌‭‪‪⁯⁫⁭‪‭‪⁭‭‬‍⁭⁭‍‪⁮​⁭⁬⁮‍‏⁯⁯⁯‮‮‪⁫⁪⁯‮(result2.Licensee, localLicense.Licensee))
              {
                num1 = (int) num3 * -885431901 ^ 123726838;
                continue;
              }
              break;
            case 13:
              LicenseHelper.\u206B⁮‌‭⁯⁪‌‬‭‪‏‪⁯⁬‬‭⁫⁮‭⁭⁬⁪⁫⁮‎‏⁪‍‭‬‮‭‍⁬​‫‏‮​⁬‮(LicenseHelper.\u202D⁪⁯⁭‎⁬⁮⁯‫⁮‬‏⁪‌‎⁫‫⁫‫⁬‏‮‪‬⁬‏⁫‭‍‎⁫‫‎⁯‫‬‏‏​⁯‮(httpClient)).Add(LicenseHelper.\u200D⁬‫⁬‫‭‌⁬⁪‍⁫‮​‏⁬⁯⁭⁬⁫⁫⁪⁫‫‌‏‎‫‌‍‍‌​⁭⁯‫⁫‎⁮⁫‍‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1434096782U)));
              num1 = (int) num3 * 662115125 ^ -1550653239;
              continue;
            case 14:
              LicenseHelper.\u206D‬‍‫‮⁮‫⁭‬‪‬‪⁯‫⁮⁯‬‫​⁭‮⁯⁭‮⁯‮‏⁮​‮‫‫‬‎‎‌‫‌‬⁭‮(httpClient, LicenseHelper.\u206E‪‫‬⁯⁫‮⁫‮⁬‏⁭‏‬‬‭⁪‍​⁪⁭‍⁪⁮⁮‍‪⁪⁫⁫⁭⁯⁯⁯‪⁭‌‎‪‍‮(LicenseHelper.LicenseServer));
              num1 = (int) num3 * 1048253767 ^ 370377906;
              continue;
            case 15:
              num1 = -300986361;
              continue;
            case 16:
              num1 = (int) num3 * -751233102 ^ 1134372088;
              continue;
            default:
              goto label_25;
          }
          num4 = 0;
label_7:
          int num7;
          num1 = num7 = num4 != 0 ? -761930627 : (num7 = -1727432170);
        }
label_14:
        flag = true;
      }
      catch (Exception ex)
      {
        throw;
      }
label_25:
      return flag;
    }

    public static bool CheckLicense(License localLicense)
    {
      throw LicenseHelper.\u206E⁮⁪⁫‫⁪‌⁮‫​‫​‌⁬​‫‎‮⁯⁮⁭‍‬⁯‬⁫‎⁪‭⁬⁭‭‪‫⁯⁫‭‬⁯⁯‮();
    }

    static Type \u206D‎‍​‏‌⁭‌⁯​‫‌‎‍‏‬‮‏⁭‪‬⁫‮⁬‍⁫⁭⁭‎‏‎​⁬⁮⁪⁫⁯‮⁫‍‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static XmlSerializer \u200F⁫‌⁬‭‫⁬‮‮‎​‏‭‍‌‮⁫‭‍⁪⁪‭⁮⁫‍‏‫‪‭⁭‫⁭‪‌⁭‍‎⁮⁮⁮‮([In] Type obj0)
    {
      return new XmlSerializer(obj0);
    }

    static StreamReader \u202A‎‭‬‮​⁭‎⁮‬⁭‪⁯‮‬‬‌‫‭‏⁯⁯‪⁪‭‮⁫⁭‮‌‏‌​‮‎⁯⁫⁯‏‌‮([In] string obj0)
    {
      return new StreamReader(obj0);
    }

    static object \u206E‮‫‫‪‭⁬‏⁪‫‌⁪‌‏⁭​‫⁬⁬‌‬‭⁯⁮⁮⁬‍‏⁬‫‮⁫⁭‏⁫‮⁭‪⁮⁪‮([In] XmlSerializer obj0, [In] TextReader obj1)
    {
      return obj0.Deserialize(obj1);
    }

    static void \u206D‪⁬‏‭‮‎‪‌‎⁬‌‮‪⁬‫‍⁮⁫‏‍‎​‎​⁮‭⁮‬⁫⁯‭⁫‮‌⁫‪‫⁯‪‮([In] TextReader obj0)
    {
      obj0.Close();
    }

    static string \u202B‭⁬⁬⁪‮⁬‪‬‎‪‬‭⁭⁪‮‫⁭‎‌⁮​‏‍‮‫⁮⁪⁯‍⁮​⁯‎⁮⁮‍⁫‏‌‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u200E‮‫⁮⁬⁯‮⁪⁪‮‍‮⁬‎‍‎‮⁭‭‫‬‭‍‪‫⁮‍​⁪⁫‭‫‭⁯‫‬⁫‮‏⁭‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static void \u200F‫‏⁯⁪‌⁪‍‍‮⁪⁭⁪​‬⁭‎⁯‫⁪‬‭⁯‬‍‫⁮⁫⁯‫⁫⁭⁮‭​⁯‏‌‮‍‮([In] string obj0)
    {
      Console.WriteLine(obj0);
    }

    static StreamWriter \u200F⁯⁪⁫‫‎⁭‌‌‎⁫⁯‎‍‮⁮⁮⁬‎​‍‮‭⁬‭‭​⁭⁬‏‭‭‎‍‭‬‍‌‭⁯‮([In] string obj0)
    {
      return new StreamWriter(obj0);
    }

    static void \u206C​‬​‏‫‌‮⁮⁫⁭‬⁭⁭⁪⁮‮⁪‎​‎‬‬‫⁪⁯‭‎⁭‍​⁪‪⁮⁪‌⁯‏‎⁭‮([In] XmlSerializer obj0, [In] TextWriter obj1, [In] object obj2)
    {
      obj0.Serialize(obj1, obj2);
    }

    static void \u200D‌⁬‌‮‍‏⁭⁫⁫⁬​‮​‫⁪‬‏‍‫‍⁭⁯⁭⁭⁭‪‏‫‏‬‎‫⁪⁮‍‮​⁫‫‮([In] TextWriter obj0)
    {
      obj0.Close();
    }

    static void \u206C⁯‎‌‮⁯⁬⁯‬⁯‌⁭‌‌‏⁯⁯‍⁯‮⁬‭‌⁭‮⁫⁪⁫⁬⁯‍⁭‌‎​‌​‍‌‎‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static string \u200E‭‍⁬‫⁮‬⁬⁮​⁮⁮‍⁬‮⁪⁬⁬⁯‌⁯⁮⁭‮⁭‏‍⁮‪‫‭⁬‎⁭‮‮⁪‫⁪‬‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      return string.Format(obj0, obj1, obj2, obj3);
    }

    static HttpClient \u202A‭⁮⁬‌⁯⁭⁯⁪​‎‏‍‌⁫⁬‌‮‬⁭‍‮‌‮‎⁪‫‬⁭‌‍⁯⁪​⁪⁯⁭⁮‪⁪‮()
    {
      return new HttpClient();
    }

    static Uri \u206E‪‫‬⁯⁫‮⁫‮⁬‏⁭‏‬‬‭⁪‍​⁪⁭‍⁪⁮⁮‍‪⁪⁫⁫⁭⁯⁯⁯‪⁭‌‎‪‍‮([In] string obj0)
    {
      return new Uri(obj0);
    }

    static void \u206D‬‍‫‮⁮‫⁭‬‪‬‪⁯‫⁮⁯‬‫​⁭‮⁯⁭‮⁯‮‏⁮​‮‫‫‬‎‎‌‫‌‬⁭‮([In] HttpClient obj0, [In] Uri obj1)
    {
      obj0.BaseAddress = obj1;
    }

    static HttpRequestHeaders \u202D⁪⁯⁭‎⁬⁮⁯‫⁮‬‏⁪‌‎⁫‫⁫‫⁬‏‮‪‬⁬‏⁫‭‍‎⁫‫‎⁯‫‬‏‏​⁯‮([In] HttpClient obj0)
    {
      return obj0.DefaultRequestHeaders;
    }

    static HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> \u206B⁮‌‭⁯⁪‌‬‭‪‏‪⁯⁬‬‭⁫⁮‭⁭⁬⁪⁫⁮‎‏⁪‍‭‬‮‭‍⁬​‫‏‮​⁬‮([In] HttpRequestHeaders obj0)
    {
      return obj0.Accept;
    }

    static MediaTypeWithQualityHeaderValue \u200D⁬‫⁬‫‭‌⁬⁪‍⁫‮​‏⁬⁯⁭⁬⁫⁫⁪⁫‫‌‏‎‫‌‍‍‌​⁭⁯‫⁫‎⁮⁫‍‮([In] string obj0)
    {
      return new MediaTypeWithQualityHeaderValue(obj0);
    }

    static Task<HttpResponseMessage> \u200B‏⁪‌‭‎⁯⁮‬⁪‫‍⁯⁮‍‫‏‪⁪‫‮‏‏‎⁪⁪‭⁯⁫‌‫‍‏‌‫‫⁬‪‭‍‮([In] HttpClient obj0, [In] string obj1)
    {
      return obj0.GetAsync(obj1);
    }

    static bool \u202B‬‭⁯‍‬⁪‬⁪‪‏⁪‮⁮‍‎⁯⁭‫‫⁬‍⁭​‎⁯‪‬​‭‏‪⁫⁪​⁬⁭⁫⁯‎‮([In] HttpResponseMessage obj0)
    {
      return obj0.IsSuccessStatusCode;
    }

    static HttpContent \u202A​‭⁯⁪‏⁮⁬‌‌‌⁮‍‎⁫‏⁭‍‬‎⁯⁪⁭​‫⁬⁬‎‍⁬‎‫‫‌‪‍⁪⁯‎‏‮([In] HttpResponseMessage obj0)
    {
      return obj0.Content;
    }

    static bool \u206A‬‭⁪⁫⁮‌‭‪‪⁯⁫⁭‪‭‪⁭‭‬‍⁭⁭‍‪⁮​⁭⁬⁮‍‏⁯⁯⁯‮‮‪⁫⁪⁯‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static NotImplementedException \u206E⁮⁪⁫‫⁪‌⁮‫​‫​‌⁬​‫‎‮⁯⁮⁭‍‬⁯‬⁫‎⁪‭⁬⁭‭‪‫⁯⁫‭‬⁯⁯‮()
    {
      return new NotImplementedException();
    }
  }
}
