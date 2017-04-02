// Decompiled with JetBrains decompiler
// Type: ZoomZoomLicense.License
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;

namespace ZoomZoomLicense
{
  public sealed class License
  {
    private string licensee = "";
    private string node = "";
    private DateTime dateExpires = DateTime.MinValue;
    private DateTime dateRequested = DateTime.MinValue;
    private string requestToken = "";
    private string machineName;

    public string MachineName
    {
      get
      {
label_1:
        int num1 = 1213942369;
        string machineName;
        while (true)
        {
          int num2 = 556757520;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              machineName = this.machineName;
              num1 = (int) num3 * -1785343004 ^ 1921652503;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1390847369 ^ 404060071;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return machineName;
      }
      set
      {
        this.machineName = value;
        this.GenerateToken();
      }
    }

    public string Licensee
    {
      get
      {
        return this.licensee;
      }
      set
      {
label_1:
        int num1 = -1846870071;
        while (true)
        {
          int num2 = -230392082;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.GenerateToken();
              num1 = (int) num3 * 1876326292 ^ 1034865919;
              continue;
            case 3:
              this.licensee = value;
              num1 = (int) num3 * -559327118 ^ -405531234;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public string Node
    {
      get
      {
        return this.node;
      }
      set
      {
label_1:
        int num1 = -219131786;
        while (true)
        {
          int num2 = -1214584897;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.node = value;
              num1 = (int) num3 * -1825652243 ^ -1494296312;
              continue;
            case 2:
              this.GenerateToken();
              num1 = (int) num3 * 1212928774 ^ 1160093951;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public DateTime DateExpires
    {
      get
      {
label_1:
        int num1 = -1482476001;
        DateTime dateExpires;
        while (true)
        {
          int num2 = -1094679365;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              dateExpires = this.dateExpires;
              num1 = (int) num3 * -1126334639 ^ -1767711471;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dateExpires;
      }
      set
      {
label_1:
        int num1 = 1978794561;
        while (true)
        {
          int num2 = 1282685241;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.dateExpires = value;
              num1 = (int) num3 * 1021481387 ^ 1214481678;
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
      }
    }

    public DateTime DateRequested
    {
      get
      {
        return this.dateRequested;
      }
      set
      {
        this.dateRequested = value;
      }
    }

    public string RequestToken
    {
      get
      {
        string requestToken = this.requestToken;
label_1:
        int num1 = -1340112994;
        while (true)
        {
          int num2 = -15894160;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1933311253 ^ -1991305540;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return requestToken;
      }
      set
      {
        this.requestToken = value;
      }
    }

    public string FileName
    {
      get
      {
label_1:
        int num1 = 332474628;
        string str;
        while (true)
        {
          int num2 = 749107171;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 2090214997 ^ -1901768294;
              continue;
            case 2:
              goto label_1;
            case 3:
              str = License.\u206B⁭​⁮⁬‍‫⁪⁫⁬‌‫⁭‍‫​‏‮‪​⁬​⁫‭‮‏⁭‪‏⁭⁯​‭​‪‮‏⁪⁬‌‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2423965423U), (object) this.Node);
              num1 = (int) num3 * 1169087775 ^ -1174198686;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return str;
      }
    }

    public static License Invalid
    {
      get
      {
label_1:
        int num1 = 1531910477;
        License license1;
        while (true)
        {
          int num2 = 386445535;
          uint num3;
          License license2;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              license2.Node = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1279424746U);
              num1 = (int) num3 * 271934617 ^ 408990274;
              continue;
            case 1:
              num1 = (int) num3 * -730388532 ^ 1242323180;
              continue;
            case 2:
              license2 = new License();
              num1 = (int) num3 * 1003260088 ^ -2042901909;
              continue;
            case 3:
              license2.RequestToken = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1279424746U);
              num1 = (int) num3 * 44406880 ^ 557528557;
              continue;
            case 4:
              license1 = license2;
              num1 = (int) num3 * -1839679938 ^ -1903292287;
              continue;
            case 5:
              license2.Licensee = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1643374929U);
              num1 = (int) num3 * 1182330717 ^ 1155704706;
              continue;
            case 6:
              license2.DateExpires = DateTime.MinValue;
              num1 = (int) num3 * 1578660746 ^ -1394484334;
              continue;
            case 7:
              goto label_1;
            case 9:
              license2.DateRequested = DateTime.Now;
              num1 = (int) num3 * -146352892 ^ -509831566;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return license1;
      }
    }

    public License()
    {
      this.MachineName = License.\u202A⁮‎‍‭‏‮‪⁫‪‎‎‌‏⁪⁬‍⁮⁬‍⁫⁪‭‍‬‭​⁭‪‍‫‏⁫‫‍‌‌⁪‭‏‮();
      this.Licensee = License.\u200D⁮⁮‭⁮‍‫⁫⁪⁭⁪⁬⁬‬​‪‌‍‎‪‫​‏‬⁭‍⁮⁬⁬⁬⁭‪‫⁭⁭‏⁬⁬‬⁬‮();
    }

    private void GenerateToken()
    {
label_1:
      int num1 = 937114415;
      while (true)
      {
        int num2 = 1506014314;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 2024391347 ^ -135791283;
            continue;
          case 1:
            this.RequestToken = Encryption.StringCipher.Encrypt(License.\u206F⁮⁯​‫‎‭‮⁮⁬⁯⁫‫‎⁫‮⁭⁮‭​‫‫‭‪‬‮⁯‭⁮‫‭‏‌⁬⁬‮‏⁬⁫‌‮(new string[5]
            {
              this.MachineName,
              \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3157761791U),
              this.Licensee,
              \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(265576099U),
              this.Node
            }), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1891850659U));
            num1 = (int) num3 * -2060023615 ^ -1201865437;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public override string ToString()
    {
      return License.\u200F⁬​⁪‪⁮⁪⁬‏⁮⁭⁪‭‭‌‍‬⁭‬⁭‪⁯‍‌‏‪‮⁭⁯⁬‮‏‭⁭‍‏‮⁮‮‬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3659342058U), new object[5]{ (object) this.Licensee, (object) this.Node, (object) this.RequestToken, (object) this.DateExpires, (object) this.DateRequested });
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = 502329813;
      bool flag1;
      while (true)
      {
        int num2 = 1273854550;
        uint num3;
        License license;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            int num4 = flag2 ? -485320618 : (num4 = -1518488666);
            int num5 = (int) num3 * -2103774366;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag2 = license != null;
            num1 = (int) num3 * -211855693 ^ 1091384073;
            continue;
          case 3:
            goto label_1;
          case 4:
            license = obj as License;
            num1 = (int) num3 * 2029850921 ^ 2116235185;
            continue;
          case 5:
            flag1 = this.\u206A‌⁪⁬‭⁬‮⁯‏‪‫‪⁬‬‌​‏‮⁪‭‏​‫‎⁫‮‪⁫‮⁬‎⁯⁮‮‎‍⁪⁫​⁮‮(obj);
            num1 = 140409177;
            continue;
          case 6:
            num1 = (int) num3 * 2043146897 ^ 1367628075;
            continue;
          case 7:
            num1 = (int) num3 * -1996252642 ^ -756588126;
            continue;
          case 8:
            flag1 = License.\u206C⁬‍‫⁮​⁫⁪⁪‎‌‌⁮‫‫⁯‮‍‫‪‎​‫⁫‍⁪⁮‬‏​‫⁬‎‎​⁪‮‏‏⁯‮(license.RequestToken, this.RequestToken);
            num1 = (int) num3 * 2090340107 ^ 1814593745;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag1;
    }

    public override int GetHashCode()
    {
      int num1 = License.\u200F‭‪⁬‎‪⁪⁭⁯‭‏⁪⁫⁬​⁯⁪‫⁫​‭⁪⁫⁯‮‫‍‏‎‌⁯⁬‍⁪⁯⁭‭‫‭‏‮((object) this.RequestToken);
label_1:
      int num2 = -947448837;
      while (true)
      {
        int num3 = -195550332;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num2 = (int) num4 * -890239240 ^ -1176356578;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return num1;
    }

    static string \u206B⁭​⁮⁬‍‫⁪⁫⁬‌‫⁭‍‫​‏‮‪​⁬​⁫‭‮‏⁭‪‏⁭⁯​‭​‪‮‏⁪⁬‌‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u202A⁮‎‍‭‏‮‪⁫‪‎‎‌‏⁪⁬‍⁮⁬‍⁫⁪‭‍‬‭​⁭‪‍‫‏⁫‫‍‌‌⁪‭‏‮()
    {
      return Environment.MachineName;
    }

    static string \u200D⁮⁮‭⁮‍‫⁫⁪⁭⁪⁬⁬‬​‪‌‍‎‪‫​‏‬⁭‍⁮⁬⁬⁬⁭‪‫⁭⁭‏⁬⁬‬⁬‮()
    {
      return Environment.UserName;
    }

    static string \u206F⁮⁯​‫‎‭‮⁮⁬⁯⁫‫‎⁫‮⁭⁮‭​‫‫‭‪‬‮⁯‭⁮‫‭‏‌⁬⁬‮‏⁬⁫‌‮([In] string[] obj0)
    {
      return string.Concat(obj0);
    }

    static string \u200F⁬​⁪‪⁮⁪⁬‏⁮⁭⁪‭‭‌‍‬⁭‬⁭‪⁯‍‌‏‪‮⁭⁯⁬‮‏‭⁭‍‏‮⁮‮‬‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static bool \u206C⁬‍‫⁮​⁫⁪⁪‎‌‌⁮‫‫⁯‮‍‫‪‎​‫⁫‍⁪⁮‬‏​‫⁬‎‎​⁪‮‏‏⁯‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    bool \u206A‌⁪⁬‭⁬‮⁯‏‪‫‪⁬‬‌​‏‮⁪‭‏​‫‎⁫‮‪⁫‮⁬‎⁯⁮‮‎‍⁪⁫​⁮‮([In] object obj0)
    {
      return base.Equals(obj0);
    }

    static int \u200F‭‪⁬‎‪⁪⁭⁯‭‏⁪⁫⁬​⁯⁪‫⁫​‭⁪⁫⁯‮‫‍‏‎‌⁯⁬‍⁪⁯⁭‭‫‭‏‮([In] object obj0)
    {
      return obj0.GetHashCode();
    }
  }
}
