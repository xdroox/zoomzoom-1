// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Core.ftp
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Core
{
  internal class ftp
  {
    protected static readonly ILog log = ftp.\u202B‭‌‫‍⁫‫⁬‭​⁫‏⁫‬‌⁭‫​⁫​‍‫⁫⁫‬‌‬⁮‎‏​‍‪‏​‮‭‮⁪⁭‮(ftp.\u202C‮‭‫‮⁪⁮‬‎‬⁬​⁪‪‮⁪⁪‪​‍‮​‮⁯‍⁮‫‌⁫⁬‌⁫⁭⁬‌‏​⁭⁮⁬‮((MemberInfo) ftp.\u202B‍‫⁬‏⁪‮‬‌‌⁭⁫‪‬‏‌​⁮‬‍⁭‍⁭‎⁪⁯‫‬⁮‍‭⁬⁭‭⁪‏⁯‭⁬‎‮()));
    private string host = (string) null;
    private string user = (string) null;
    private string pass = (string) null;
    private FtpWebRequest ftpRequest = (FtpWebRequest) null;
    private FtpWebResponse ftpResponse = (FtpWebResponse) null;
    private Stream ftpStream = (Stream) null;
    private int bufferSize = 2048;

    public ftp(string hostIP, string userName, string password)
    {
      this.host = hostIP;
      this.user = userName;
      this.pass = password;
    }

    public void download(string remoteFile, string localFile)
    {
      try
      {
        Uri uri1 = ftp.\u200F⁬‏‫⁭‎⁫⁯​⁫‌⁫‮‏‪⁯‏‏‮‍‬‮‏‮⁮‪⁮​​⁪‍‫⁯‍‮‮‭​‫‭‮(this.host);
        Uri uri2 = ftp.\u206D‫​⁮⁬‭‪​‏‍‌⁭⁬‌‬⁪⁬‏⁮⁪‫‌‎⁭⁮​‪‪‌‌⁮⁮⁪⁭‌‮‍⁭⁫⁫‮(remoteFile, UriKind.Relative);
label_2:
        int num1 = 898901268;
        while (true)
        {
          int num2 = 822664626;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
              num1 = (int) num3 * -908112926 ^ -1767040367;
              continue;
            case 1:
              num1 = (int) num3 * -1817999478 ^ -314456127;
              continue;
            case 2:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * 53220285 ^ -1606173527;
              continue;
            case 3:
              this.ftpStream = ftp.\u202A‫​⁬‪‭⁭⁮‌‫‬‫‮‪‎‏⁮‫​⁪⁬‬‪⁫⁮‎⁪‮⁯⁭‭‌‪⁭‏‮⁪⁮⁫⁪‮((WebResponse) this.ftpResponse);
              num1 = (int) num3 * 308506734 ^ -901438095;
              continue;
            case 4:
              this.ftpRequest = (FtpWebRequest) ftp.\u200C‭⁭⁯⁬‍​⁯‍‌‮‏⁪‌​‭‌‌‬‌⁭⁭⁬‎‎⁮‏⁯‬‏⁪⁭​‌‭‌‏‫‎⁭‮(ftp.\u200E⁬⁭⁭⁪‌⁪⁫‬‎⁮‎‫‌‮‪‪⁭⁪⁪‭‪⁪⁭⁫‫​‮‫⁭‫‪‌‏‬‭⁫‮⁫⁬‮(uri1, uri2));
              num1 = (int) num3 * -709537377 ^ 686353270;
              continue;
            case 5:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, false);
              num1 = (int) num3 * 1318355498 ^ -1261024715;
              continue;
            case 6:
              goto label_2;
            case 8:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1347849220U));
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              num1 = (int) num3 * -479481569 ^ -1494452167;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        FileStream fileStream = ftp.\u200C⁮​‬‎​⁯​‏⁪‌‪‌‎‎‪‬⁬‌‭‏⁭⁯‬‪‮‬⁯⁭‫⁭​​⁮‪‍‫⁭‫‌‮(localFile, FileMode.Create);
        byte[] numArray = new byte[this.bufferSize];
        int num4 = ftp.\u202D⁯‫⁮⁪⁮⁫‪⁪⁫⁫‍‮‍​‎‌‪‍‮​⁬‪‬‍‪⁮​⁮⁬‮‪‎⁮⁯⁯‮‏⁯‫‮(this.ftpStream, numArray, 0, this.bufferSize);
        try
        {
label_18:
          int num2 = num4 > 0 ? 2030933439 : (num2 = 1167488111);
          while (true)
          {
            int num3 = 822664626;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                goto label_18;
              case 2:
                num2 = 2030933439;
                continue;
              case 3:
                num2 = 1183476272;
                continue;
              case 4:
                ftp.\u206B​‏⁭​⁯‌‮​⁯​⁭‭⁬‭⁯‌‫⁮‌‭‪‬⁪⁫‮‍‬‪‌‫⁯⁭‎⁭​​⁭⁮‬‮((Stream) fileStream, numArray, 0, num4);
                num4 = ftp.\u202D⁯‫⁮⁪⁮⁫‪⁪⁫⁫‍‮‍​‎‌‪‍‮​⁬‪‬‍‪⁮​⁮⁬‮‪‎⁮⁯⁯‮‏⁯‫‮(this.ftpStream, numArray, 0, this.bufferSize);
                num2 = (int) num5 * -1177922478 ^ -984511925;
                continue;
              case 5:
                num2 = (int) num5 * -2123245042 ^ -1600510780;
                continue;
              default:
                goto label_24;
            }
          }
        }
        catch (Exception ex)
        {
label_20:
          int num2 = 425802263;
          while (true)
          {
            int num3 = 822664626;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_20;
              case 1:
                num2 = (int) num5 * 230410996 ^ -1994371984;
                continue;
              case 2:
                ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
                num2 = (int) num5 * 1154017367 ^ -2136579805;
                continue;
              default:
                goto label_24;
            }
          }
        }
label_24:
        ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮((Stream) fileStream);
label_25:
        int num6 = 1101753596;
        while (true)
        {
          int num2 = 822664626;
          uint num3;
          switch ((num3 = (uint) (num6 ^ num2)) % 6U)
          {
            case 0:
              goto label_25;
            case 1:
              num6 = (int) num3 * -1188787700 ^ 697090858;
              continue;
            case 2:
              ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮(this.ftpStream);
              num6 = (int) num3 * -167459529 ^ -1608362161;
              continue;
            case 3:
              ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
              num6 = (int) num3 * 1504512020 ^ 1753677277;
              continue;
            case 4:
              this.ftpRequest = (FtpWebRequest) null;
              num6 = (int) num3 * -232377295 ^ 181463619;
              continue;
            case 5:
              goto label_39;
            default:
              goto label_38;
          }
        }
label_38:
        return;
label_39:;
      }
      catch (Exception ex)
      {
label_33:
        int num1 = 667406343;
        while (true)
        {
          int num2 = 822664626;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_33;
            case 1:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
              num1 = (int) num3 * -1913335714 ^ 860725371;
              continue;
            case 2:
              goto label_35;
            case 3:
              num1 = (int) num3 * -2113916284 ^ -59649816;
              continue;
            default:
              goto label_31;
          }
        }
label_31:
        return;
label_35:;
      }
    }

    public bool upload(string remoteFile, string localFile)
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = 10324544;
        FileStream fileStream;
        while (true)
        {
          int num2 = 1550787933;
          uint num3;
          Uri uri1;
          Uri uri2;
          Uri uri3;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              this.ftpStream = ftp.\u206F⁬‮​⁮‏‫‮‎‫⁪‬‪‫⁯⁮​‌⁯⁬⁬‏‬​‭⁪⁬‍‮‍⁪⁪​⁯​‏‏‭⁬‭‮((WebRequest) this.ftpRequest);
              fileStream = ftp.\u200C⁮​‬‎​⁯​‏⁪‌‪‌‎‎‪‬⁬‌‭‏⁭⁯‬‪‮‬⁯⁭‫⁭​​⁮‪‍‫⁭‫‌‮(localFile, FileMode.Create);
              num1 = (int) num3 * -1066143303 ^ -757302458;
              continue;
            case 1:
              uri1 = ftp.\u200F⁬‏‫⁭‎⁫⁯​⁫‌⁫‮‏‪⁯‏‏‮‍‬‮‏‮⁮‪⁮​​⁪‍‫⁯‍‮‮‭​‫‭‮(this.host);
              uri2 = ftp.\u206D‫​⁮⁬‭‪​‏‍‌⁭⁬‌‬⁪⁬‏⁮⁪‫‌‎⁭⁮​‪‪‌‌⁮⁮⁪⁭‌‮‍⁭⁫⁫‮(remoteFile, UriKind.Relative);
              num1 = (int) num3 * 1295700777 ^ 1980489865;
              continue;
            case 2:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3312542462U));
              num1 = (int) num3 * 249891229 ^ -812435977;
              continue;
            case 4:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              num1 = (int) num3 * 938411986 ^ 320104058;
              continue;
            case 5:
              uri3 = ftp.\u200E⁬⁭⁭⁪‌⁪⁫‬‎⁮‎‫‌‮‪‪⁭⁪⁪‭‪⁪⁭⁫‫​‮‫⁭‫‪‌‏‬‭⁫‮⁫⁬‮(uri1, uri2);
              num1 = (int) num3 * -1877820095 ^ 315718103;
              continue;
            case 6:
              goto label_2;
            case 7:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * -1106211544 ^ -251643149;
              continue;
            case 8:
              num1 = (int) num3 * 1548299618 ^ -1648082887;
              continue;
            case 9:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              num1 = (int) num3 * 151723065 ^ -2045976446;
              continue;
            case 10:
              num1 = (int) num3 * 100555389 ^ -1161573345;
              continue;
            case 11:
              this.ftpRequest = (FtpWebRequest) ftp.\u200C‭⁭⁯⁬‍​⁯‍‌‮‏⁪‌​‭‌‌‬‌⁭⁭⁬‎‎⁮‏⁯‬‏⁪⁭​‌‭‌‏‫‎⁭‮(uri3);
              ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
              num1 = (int) num3 * 566994950 ^ 1253012086;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        byte[] numArray = new byte[this.bufferSize];
        int num4 = ftp.\u202D⁯‫⁮⁪⁮⁫‪⁪⁫⁫‍‮‍​‎‌‪‍‮​⁬‪‬‍‪⁮​⁮⁬‮‪‎⁮⁯⁯‮‏⁯‫‮((Stream) fileStream, numArray, 0, this.bufferSize);
        try
        {
label_18:
          int num2 = (uint) num4 > 0U ? 1360784382 : (num2 = 1709009794);
          while (true)
          {
            int num3 = 1550787933;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 6U)
            {
              case 1:
                goto label_18;
              case 2:
                num2 = 1360784382;
                continue;
              case 3:
                num2 = 1973706129;
                continue;
              case 4:
                ftp.\u206B​‏⁭​⁯‌‮​⁯​⁭‭⁬‭⁯‌‫⁮‌‭‪‬⁪⁫‮‍‬‪‌‫⁯⁭‎⁭​​⁭⁮‬‮(this.ftpStream, numArray, 0, num4);
                num4 = ftp.\u202D⁯‫⁮⁪⁮⁫‪⁪⁫⁫‍‮‍​‎‌‪‍‮​⁬‪‬‍‪⁮​⁮⁬‮‪‎⁮⁯⁯‮‏⁯‫‮((Stream) fileStream, numArray, 0, this.bufferSize);
                num2 = (int) num5 * -644524536 ^ -1967029694;
                continue;
              case 5:
                num2 = (int) num5 * -1028876689 ^ 1016232234;
                continue;
              default:
                goto label_27;
            }
          }
        }
        catch (Exception ex)
        {
label_23:
          int num2 = 1194462557;
          while (true)
          {
            int num3 = 1550787933;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num2 = (int) num5 * 2023575026 ^ 369236122;
                continue;
              case 2:
                goto label_23;
              default:
                goto label_26;
            }
          }
label_26:
          ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
        }
label_27:
        ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮((Stream) fileStream);
label_28:
        int num6 = 1041729782;
        while (true)
        {
          int num2 = 1550787933;
          uint num3;
          switch ((num3 = (uint) (num6 ^ num2)) % 5U)
          {
            case 0:
              this.ftpRequest = (FtpWebRequest) null;
              num6 = (int) num3 * -1429712860 ^ -1863675171;
              continue;
            case 1:
              num6 = (int) num3 * -1295207815 ^ 498812538;
              continue;
            case 2:
              ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮(this.ftpStream);
              num6 = (int) num3 * -51076719 ^ -464308596;
              continue;
            case 4:
              goto label_28;
            default:
              goto label_33;
          }
        }
label_33:
        flag1 = true;
      }
      catch (Exception ex)
      {
label_35:
        int num1 = 1496889252;
        while (true)
        {
          int num2 = 1550787933;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ftp.\u200B⁭‫‏⁬⁫‭⁮⁯‌‏⁮⁬‫​‪⁭‮⁫⁯⁭‫⁫‭‎⁮‌‎‎‮‬‎⁮‏‫‏‪‮⁮⁮‮((object) ex));
              num1 = (int) num3 * -922111617 ^ -2031312418;
              continue;
            case 2:
              goto label_35;
            default:
              goto label_38;
          }
        }
      }
label_38:
      bool flag2 = flag1;
label_39:
      int num7 = 723052116;
      while (true)
      {
        int num1 = 1550787933;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 3U)
        {
          case 1:
            num7 = (int) num2 * -701510746 ^ -2085280125;
            continue;
          case 2:
            goto label_39;
          default:
            goto label_42;
        }
      }
label_42:
      return flag2;
    }

    public void delete(string deleteFile)
    {
      try
      {
label_2:
        int num1 = -1775293722;
        while (true)
        {
          int num2 = -144891245;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              num1 = (int) num3 * 1102807657 ^ 1236235383;
              continue;
            case 1:
              num1 = (int) num3 * -824037392 ^ 1932971360;
              continue;
            case 2:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * 1382314070 ^ 1383939840;
              continue;
            case 3:
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              num1 = (int) num3 * 1732681513 ^ 681922374;
              continue;
            case 4:
              ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
              num1 = (int) num3 * -1759645431 ^ -1808893597;
              continue;
            case 5:
              num1 = (int) num3 * -1121772331 ^ 253930808;
              continue;
            case 6:
              goto label_28;
            case 7:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1322294476U));
              num1 = (int) num3 * -709290119 ^ -1525115451;
              continue;
            case 8:
              ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
              num1 = (int) num3 * -856237155 ^ -630608074;
              continue;
            case 9:
              this.ftpRequest = (FtpWebRequest) ftp.\u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮(ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(this.host, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3768165735U), deleteFile));
              num1 = (int) num3 * 721998030 ^ 1481806227;
              continue;
            case 10:
              num1 = (int) num3 * 999470588 ^ 1617769797;
              continue;
            case 11:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              num1 = (int) num3 * 1385676722 ^ 2081296405;
              continue;
            case 12:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              num1 = (int) num3 * -946943281 ^ 214334888;
              continue;
            case 13:
              num1 = (int) num3 * 386619790 ^ -419517630;
              continue;
            case 14:
              this.ftpRequest = (FtpWebRequest) null;
              num1 = (int) num3 * 1200359673 ^ 594799623;
              continue;
            case 15:
              num1 = (int) num3 * -390729627 ^ 337761412;
              continue;
            case 16:
              num1 = (int) num3 * -220435450 ^ -937666658;
              continue;
            case 17:
              goto label_2;
            default:
              goto label_27;
          }
        }
label_27:
        return;
label_28:;
      }
      catch (Exception ex)
      {
label_22:
        int num1 = -922266103;
        while (true)
        {
          int num2 = -144891245;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_22;
            case 1:
              goto label_24;
            case 2:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
              num1 = (int) num3 * -1822912705 ^ -1546158818;
              continue;
            case 3:
              num1 = (int) num3 * 1245729651 ^ 2043061283;
              continue;
            default:
              goto label_20;
          }
        }
label_20:
        return;
label_24:;
      }
    }

    public void rename(string currentFileNameAndPath, string newFileName)
    {
      try
      {
        this.ftpRequest = (FtpWebRequest) ftp.\u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮(ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(this.host, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4175618675U), currentFileNameAndPath));
label_2:
        int num1 = -1028606307;
        while (true)
        {
          int num2 = -153812151;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              num1 = (int) num3 * 1100530210 ^ 309205054;
              continue;
            case 1:
              goto label_22;
            case 2:
              ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
              num1 = (int) num3 * 372780592 ^ -1656982539;
              continue;
            case 3:
              num1 = (int) num3 * -375429349 ^ -1559285950;
              continue;
            case 4:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              num1 = (int) num3 * -1096760893 ^ 805663327;
              continue;
            case 5:
              ftp.\u202A‎⁭⁯⁪⁭‎⁮⁪‪‬‎‬⁭‮‌‭‪‬‪⁭‭​‭‌‎⁪⁯⁮⁫⁬​⁮‭‭‪​‪‎‪‮(this.ftpRequest, newFileName);
              num1 = (int) num3 * 1414439933 ^ -347092170;
              continue;
            case 6:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              num1 = (int) num3 * 104555642 ^ -1512607884;
              continue;
            case 7:
              goto label_2;
            case 8:
              this.ftpRequest = (FtpWebRequest) null;
              num1 = (int) num3 * -1428756116 ^ -62711694;
              continue;
            case 9:
              num1 = (int) num3 * -1551288425 ^ -1762404011;
              continue;
            case 10:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * -1358478545 ^ 1698569662;
              continue;
            case 11:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1528797910U));
              num1 = (int) num3 * 1780928928 ^ 1846034034;
              continue;
            case 12:
              ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
              num1 = (int) num3 * -775266324 ^ 1694469144;
              continue;
            default:
              goto label_21;
          }
        }
label_21:
        return;
label_22:;
      }
      catch (Exception ex)
      {
        ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
label_17:
        int num1 = -1410062040;
        while (true)
        {
          int num2 = -153812151;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_17;
            case 1:
              num1 = (int) num3 * -532135722 ^ 803289054;
              continue;
            case 2:
              goto label_19;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_19:;
      }
    }

    public void createDirectory(string newDirectory)
    {
      try
      {
label_2:
        int num1 = -1373537136;
        while (true)
        {
          int num2 = -727203325;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              num1 = (int) num3 * -2030800656 ^ -1164503571;
              continue;
            case 1:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              num1 = (int) num3 * -838685173 ^ 1531936311;
              continue;
            case 2:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              num1 = (int) num3 * 1609428918 ^ -968951570;
              continue;
            case 3:
              num1 = (int) num3 * 1377848138 ^ 836639993;
              continue;
            case 4:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3658186689U));
              num1 = (int) num3 * -1806687298 ^ -932591621;
              continue;
            case 5:
              this.ftpRequest = (FtpWebRequest) ftp.\u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮(ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(this.host, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3768165735U), newDirectory));
              ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
              num1 = (int) num3 * -40471039 ^ 1462345030;
              continue;
            case 6:
              goto label_2;
            case 7:
              goto label_19;
            case 8:
              ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
              this.ftpRequest = (FtpWebRequest) null;
              num1 = (int) num3 * 905496934 ^ -1481434649;
              continue;
            default:
              goto label_18;
          }
        }
label_18:
        return;
label_19:;
      }
      catch (Exception ex)
      {
label_13:
        int num1 = -1557007832;
        while (true)
        {
          int num2 = -727203325;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_13;
            case 1:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
              num1 = (int) num3 * 726284019 ^ 158632618;
              continue;
            case 2:
              goto label_15;
            case 3:
              num1 = (int) num3 * -1673117700 ^ -1394666206;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_15:;
      }
    }

    public string getFileCreatedDateTime(string fileName)
    {
      try
      {
        this.ftpRequest = (FtpWebRequest) ftp.\u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮(ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(this.host, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4175618675U), fileName));
        ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
label_2:
        int num1 = -1906247661;
        while (true)
        {
          int num2 = -744316984;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3187720095U));
              num1 = (int) num3 * 601815261 ^ -1017760134;
              continue;
            case 1:
              num1 = (int) num3 * 330607199 ^ -268986849;
              continue;
            case 2:
              num1 = (int) num3 * 340570337 ^ -485243631;
              continue;
            case 3:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              num1 = (int) num3 * -1731118877 ^ -2121138129;
              continue;
            case 5:
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              this.ftpStream = ftp.\u202A‫​⁬‪‭⁭⁮‌‫‬‫‮‪‎‏⁮‫​⁪⁬‬‪⁫⁮‎⁪‮⁯⁭‭‌‪⁭‏‮⁪⁮⁫⁪‮((WebResponse) this.ftpResponse);
              num1 = (int) num3 * -1021038766 ^ -1730594576;
              continue;
            case 6:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * 585135509 ^ -51333244;
              continue;
            case 7:
              goto label_2;
            case 8:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              num1 = (int) num3 * -1276651670 ^ 593735564;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        StreamReader streamReader = ftp.\u200B‭⁮‎⁪‌‮‌‎‍⁮⁭​⁭‫⁫​⁫‬‎⁭‏‬⁫‪‮‬⁫​‭⁮‫​⁪⁭‮‎‌‏‏‮(this.ftpStream);
        string str = (string) null;
        try
        {
label_13:
          int num2 = -1187511325;
          while (true)
          {
            int num3 = -744316984;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_13;
              case 1:
                num2 = (int) num4 * -1143071818 ^ 639655368;
                continue;
              case 3:
                str = ftp.\u206A‏⁮⁭‬‎‎‫‭‎‏⁯⁪‍‪‮‏⁮​‬‬‌‮⁮‫⁬⁪‎‎‪⁯‏‬⁪⁯⁯‏‭⁬‭‮((TextReader) streamReader);
                num2 = (int) num4 * -1117561798 ^ 1463155015;
                continue;
              default:
                goto label_24;
            }
          }
        }
        catch (Exception ex)
        {
label_18:
          int num2 = -1314789965;
          while (true)
          {
            int num3 = -744316984;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                goto label_18;
              case 1:
                num2 = (int) num4 * -825793740 ^ -2133062822;
                continue;
              case 3:
                num2 = (int) num4 * -1050189038 ^ -991841450;
                continue;
              case 4:
                ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
                num2 = (int) num4 * 981855797 ^ 680869587;
                continue;
              case 5:
                num2 = (int) num4 * -1750369173 ^ 2068279118;
                continue;
              default:
                goto label_24;
            }
          }
        }
label_24:
        ftp.\u206A‪‏‌‪​⁮​⁮‌‭‫‎‫⁪‫‭⁬‍⁭‮⁫​‏‍⁭⁬‏‎‎‭​‮‫‍⁭⁫​‫⁭‮((TextReader) streamReader);
label_25:
        int num5 = -2046083901;
        while (true)
        {
          int num2 = -744316984;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 6U)
          {
            case 0:
              ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
              num5 = (int) num3 * 1603236961 ^ -1154039087;
              continue;
            case 1:
              this.ftpRequest = (FtpWebRequest) null;
              num5 = (int) num3 * 1263897193 ^ -888863755;
              continue;
            case 2:
              goto label_25;
            case 3:
              num5 = (int) num3 * 736930216 ^ -840565335;
              continue;
            case 5:
              ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮(this.ftpStream);
              num5 = (int) num3 * 571693830 ^ 1134384690;
              continue;
            default:
              goto label_31;
          }
        }
label_31:
        return str;
      }
      catch (Exception ex)
      {
label_33:
        int num1 = -1762576487;
        while (true)
        {
          int num2 = -744316984;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
              num1 = (int) num3 * -1773806321 ^ 1906659083;
              continue;
            case 1:
              num1 = (int) num3 * -173600776 ^ -397480019;
              continue;
            case 3:
              goto label_33;
            case 4:
              num1 = (int) num3 * 792158261 ^ 190147804;
              continue;
            default:
              goto label_38;
          }
        }
      }
label_38:
      return "";
    }

    public string getFileSize(string fileName)
    {
      string str1;
      try
      {
label_2:
        int num1 = 330424497;
        while (true)
        {
          int num2 = 1352793501;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              goto label_2;
            case 1:
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              num1 = (int) num3 * -905694741 ^ 2060183779;
              continue;
            case 2:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(205518535U));
              num1 = (int) num3 * 1598932461 ^ -1926099152;
              continue;
            case 3:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * -2129496673 ^ 557599908;
              continue;
            case 4:
              ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
              num1 = (int) num3 * -1502616190 ^ 1973160722;
              continue;
            case 5:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              num1 = (int) num3 * -277506187 ^ -1557112532;
              continue;
            case 6:
              this.ftpRequest = (FtpWebRequest) ftp.\u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮(ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(this.host, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4175618675U), fileName));
              num1 = (int) num3 * -1590973445 ^ 1444602721;
              continue;
            case 8:
              num1 = (int) num3 * 1015445455 ^ -1745236810;
              continue;
            case 9:
              this.ftpStream = ftp.\u202A‫​⁬‪‭⁭⁮‌‫‬‫‮‪‎‏⁮‫​⁪⁬‬‪⁫⁮‎⁪‮⁯⁭‭‌‪⁭‏‮⁪⁮⁫⁪‮((WebResponse) this.ftpResponse);
              num1 = (int) num3 * -447779335 ^ 862673417;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        StreamReader streamReader = ftp.\u200B‭⁮‎⁪‌‮‌‎‍⁮⁭​⁭‫⁫​⁫‬‎⁭‏‬⁫‪‮‬⁫​‭⁮‫​⁪⁭‮‎‌‏‏‮(this.ftpStream);
        string str2 = (string) null;
        try
        {
label_14:
          int num2 = 1354690384;
          while (true)
          {
            int num3 = 1352793501;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 0:
                num2 = (int) num4 * -916877456 ^ 1476951434;
                continue;
              case 1:
                num2 = (int) num4 * 500678471 ^ 464233334;
                continue;
              case 2:
                num2 = 830506771;
                continue;
              case 3:
                goto label_14;
              case 4:
                int num5;
                num2 = num5 = ftp.\u200E⁮⁪‌‮⁪⁮⁫⁬⁬‭‌‏‎‭‭‮⁭‬‭‍‪‫⁮⁮⁬‭‪‫⁪​‭⁬⁬​⁯‎⁪‏‎‮((TextReader) streamReader) == -1 ? 1631660885 : (num5 = 324837991);
                continue;
              case 5:
                num2 = (int) num4 * -187990792 ^ 1422177281;
                continue;
              case 6:
                str2 = ftp.\u206A‏⁮⁭‬‎‎‫‭‎‏⁯⁪‍‪‮‏⁮​‬‬‌‮⁮‫⁬⁪‎‎‪⁯‏‬⁪⁯⁯‏‭⁬‭‮((TextReader) streamReader);
                num2 = (int) num4 * -484299049 ^ -12299066;
                continue;
              default:
                goto label_26;
            }
          }
        }
        catch (Exception ex)
        {
          ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
label_23:
          int num2 = 1355246374;
          while (true)
          {
            int num3 = 1352793501;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_23;
              case 1:
                num2 = (int) num4 * -976307637 ^ -584077479;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:
        ftp.\u206A‪‏‌‪​⁮​⁮‌‭‫‎‫⁪‫‭⁬‍⁭‮⁫​‏‍⁭⁬‏‎‎‭​‮‫‍⁭⁫​‫⁭‮((TextReader) streamReader);
label_27:
        int num6 = 256459716;
        while (true)
        {
          int num2 = 1352793501;
          uint num3;
          switch ((num3 = (uint) (num6 ^ num2)) % 5U)
          {
            case 1:
              ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮(this.ftpStream);
              ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
              num6 = (int) num3 * 420487254 ^ -1625889076;
              continue;
            case 2:
              this.ftpRequest = (FtpWebRequest) null;
              num6 = (int) num3 * 1943144064 ^ -1059238315;
              continue;
            case 3:
              goto label_27;
            case 4:
              num6 = (int) num3 * -148526278 ^ -58961595;
              continue;
            default:
              goto label_32;
          }
        }
label_32:
        str1 = str2;
        goto label_42;
      }
      catch (Exception ex)
      {
label_34:
        int num1 = 1035833056;
        while (true)
        {
          int num2 = 1352793501;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_34;
            case 1:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
              num1 = (int) num3 * -730750432 ^ 1180635026;
              continue;
            case 3:
              num1 = (int) num3 * 1612575097 ^ 19671148;
              continue;
            default:
              goto label_38;
          }
        }
      }
label_38:
      str1 = "";
label_39:
      int num7 = 11045672;
      while (true)
      {
        int num1 = 1352793501;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 3U)
        {
          case 1:
            num7 = (int) num2 * 499944991 ^ 1646605312;
            continue;
          case 2:
            goto label_39;
          default:
            goto label_42;
        }
      }
label_42:
      return str1;
    }

    public string[] directoryListSimple(string directory)
    {
      string[] strArray;
      try
      {
        this.ftpRequest = (FtpWebRequest) ftp.\u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮(ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(this.host, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3768165735U), directory));
        ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
        ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
label_2:
        int num1 = -1777793545;
        while (true)
        {
          int num2 = -1637016155;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 946380426 ^ -576385585;
              continue;
            case 1:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              num1 = (int) num3 * 1839706813 ^ 1922989438;
              continue;
            case 3:
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              this.ftpStream = ftp.\u202A‫​⁬‪‭⁭⁮‌‫‬‫‮‪‎‏⁮‫​⁪⁬‬‪⁫⁮‎⁪‮⁯⁭‭‌‪⁭‏‮⁪⁮⁫⁪‮((WebResponse) this.ftpResponse);
              num1 = (int) num3 * 1407660404 ^ -2043146038;
              continue;
            case 4:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2261944114U));
              num1 = (int) num3 * -342708492 ^ -70366369;
              continue;
            case 5:
              goto label_2;
            case 6:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * 1223748801 ^ -1846145388;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        StreamReader streamReader = ftp.\u200B‭⁮‎⁪‌‮‌‎‍⁮⁭​⁭‫⁫​⁫‬‎⁭‏‬⁫‪‮‬⁫​‭⁮‫​⁪⁭‮‎‌‏‏‮(this.ftpStream);
        string str = (string) null;
        try
        {
label_11:
          int num2 = -622274138;
          while (true)
          {
            int num3 = -1637016155;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                num2 = (int) num4 * -1355988862 ^ 336186958;
                continue;
              case 1:
                num2 = (int) num4 * 1847800871 ^ 109382005;
                continue;
              case 3:
                goto label_11;
              case 4:
                str = ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(str, ftp.\u202E‫‬⁮‏‬⁮‮‪⁫⁫‭‏⁪⁯‬⁪‪‍‭‪‎‭​‏‪⁬‮‭⁮⁪⁯‎⁯‭⁫‌⁬‌‏‮((TextReader) streamReader), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3157271136U));
                num2 = -686185595;
                continue;
              case 5:
                num2 = (int) num4 * 1276764224 ^ 548731136;
                continue;
              case 6:
                int num5;
                num2 = num5 = ftp.\u200E⁮⁪‌‮⁪⁮⁫⁬⁬‭‌‏‎‭‭‮⁭‬‭‍‪‫⁮⁮⁬‭‪‫⁪​‭⁬⁬​⁯‎⁪‏‎‮((TextReader) streamReader) == -1 ? -1139381451 : (num5 = -1163440655);
                continue;
              default:
                goto label_22;
            }
          }
        }
        catch (Exception ex)
        {
          ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
label_19:
          int num2 = -1776860173;
          while (true)
          {
            int num3 = -1637016155;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num2 = (int) num4 * 1376749986 ^ 709855410;
                continue;
              case 2:
                goto label_19;
              default:
                goto label_22;
            }
          }
        }
label_22:
        ftp.\u206A‪‏‌‪​⁮​⁮‌‭‫‎‫⁪‫‭⁬‍⁭‮⁫​‏‍⁭⁬‏‎‎‭​‮‫‍⁭⁫​‫⁭‮((TextReader) streamReader);
label_23:
        int num6 = -127820097;
        while (true)
        {
          int num2 = -1637016155;
          uint num3;
          switch ((num3 = (uint) (num6 ^ num2)) % 3U)
          {
            case 1:
              ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮(this.ftpStream);
              ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
              num6 = (int) num3 * 1673828694 ^ -881609848;
              continue;
            case 2:
              goto label_23;
            default:
              goto label_26;
          }
        }
label_26:
        this.ftpRequest = (FtpWebRequest) null;
        try
        {
label_28:
          int num2 = -2003896141;
          while (true)
          {
            int num3 = -1637016155;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_28;
              case 2:
                strArray = ftp.\u202B‭⁯‮‬‎⁫‫‬‪⁯⁪⁭⁬‫‌‎⁪‎‪‎⁪​‫⁭‬‏‌‏‫‏‫⁭‏‍‍‍‮‎‪‮(str, ftp.\u200D‫​⁭‌‬⁮‮⁯⁬​‏‍‮​⁯⁬‫‏‌‫⁮‮‪‭‏‮‮‪‭‪‬‎⁮​‍‪⁪‌‬‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(750811209U)));
                num2 = (int) num4 * 2107593966 ^ -130629145;
                continue;
              default:
                goto label_41;
            }
          }
        }
        catch (Exception ex)
        {
label_32:
          int num2 = -2140467879;
          while (true)
          {
            int num3 = -1637016155;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
                num2 = (int) num4 * -185457423 ^ -1925277297;
                continue;
              case 2:
                goto label_32;
              default:
                goto label_40;
            }
          }
        }
      }
      catch (Exception ex)
      {
label_36:
        int num1 = -449121001;
        while (true)
        {
          int num2 = -1637016155;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1819407686 ^ -1415095961;
              continue;
            case 2:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
              num1 = (int) num3 * -1685800230 ^ 2055070904;
              continue;
            case 3:
              goto label_36;
            default:
              goto label_40;
          }
        }
      }
label_40:
      strArray = new string[1]{ "" };
label_41:
      return strArray;
    }

    public string[] directoryListDetailed(string directory)
    {
      string[] strArray;
      try
      {
        this.ftpRequest = (FtpWebRequest) ftp.\u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮(ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(this.host, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(335691925U), directory));
        ftp.\u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮((WebRequest) this.ftpRequest, (ICredentials) ftp.\u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮(this.user, this.pass));
label_2:
        int num1 = -1121809750;
        StreamReader streamReader;
        while (true)
        {
          int num2 = -462421234;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              goto label_2;
            case 1:
              this.ftpStream = ftp.\u202A‫​⁬‪‭⁭⁮‌‫‬‫‮‪‎‏⁮‫​⁪⁬‬‪⁫⁮‎⁪‮⁯⁭‭‌‪⁭‏‮⁪⁮⁫⁪‮((WebResponse) this.ftpResponse);
              num1 = (int) num3 * -60907604 ^ 1831993242;
              continue;
            case 2:
              num1 = (int) num3 * -303952669 ^ -1584749563;
              continue;
            case 4:
              ftp.\u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮(this.ftpRequest, true);
              num1 = (int) num3 * -656062337 ^ -1468951768;
              continue;
            case 5:
              ftp.\u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮(this.ftpRequest, true);
              num1 = (int) num3 * 1184333926 ^ 1834304014;
              continue;
            case 6:
              streamReader = ftp.\u200B‭⁮‎⁪‌‮‌‎‍⁮⁭​⁭‫⁫​⁫‬‎⁭‏‬⁫‪‮‬⁫​‭⁮‫​⁪⁭‮‎‌‏‏‮(this.ftpStream);
              num1 = (int) num3 * -29363562 ^ 194064221;
              continue;
            case 7:
              this.ftpResponse = (FtpWebResponse) ftp.\u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮((WebRequest) this.ftpRequest);
              num1 = (int) num3 * -1584183359 ^ 457215902;
              continue;
            case 8:
              ftp.\u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮((WebRequest) this.ftpRequest, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2215812759U));
              num1 = (int) num3 * -696648497 ^ 885486239;
              continue;
            case 9:
              ftp.\u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮(this.ftpRequest, true);
              num1 = (int) num3 * 666370814 ^ 867623791;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        string str = (string) null;
        try
        {
label_14:
          int num2 = -1523621827;
          while (true)
          {
            int num3 = -462421234;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                int num5;
                num2 = num5 = ftp.\u200E⁮⁪‌‮⁪⁮⁫⁬⁬‭‌‏‎‭‭‮⁭‬‭‍‪‫⁮⁮⁬‭‪‫⁪​‭⁬⁬​⁯‎⁪‏‎‮((TextReader) streamReader) == -1 ? -1471496708 : (num5 = -701529243);
                continue;
              case 1:
                num2 = (int) num4 * -1787611382 ^ -1130143450;
                continue;
              case 3:
                str = ftp.\u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮(str, ftp.\u202E‫‬⁮‏‬⁮‮‪⁫⁫‭‏⁪⁯‬⁪‪‍‭‪‎‭​‏‪⁬‮‭⁮⁪⁯‎⁯‭⁫‌⁬‌‏‮((TextReader) streamReader), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1162138903U));
                num2 = (int) num4 * 914786217 ^ 2015185055;
                continue;
              case 4:
                goto label_14;
              case 5:
                num2 = -98193311;
                continue;
              default:
                goto label_21;
            }
          }
        }
        catch (Exception ex)
        {
          ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
        }
label_21:
        ftp.\u206A‪‏‌‪​⁮​⁮‌‭‫‎‫⁪‫‭⁬‍⁭‮⁫​‏‍⁭⁬‏‎‎‭​‮‫‍⁭⁫​‫⁭‮((TextReader) streamReader);
        ftp.\u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮(this.ftpStream);
        ftp.\u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮((WebResponse) this.ftpResponse);
        this.ftpRequest = (FtpWebRequest) null;
        try
        {
          strArray = ftp.\u202B‭⁯‮‬‎⁫‫‬‪⁯⁪⁭⁬‫‌‎⁪‎‪‎⁪​‫⁭‬‏‌‏‫‏‫⁭‏‍‍‍‮‎‪‮(str, ftp.\u200D‫​⁭‌‬⁮‮⁯⁬​‏‍‮​⁯⁬‫‏‌‫⁮‮‪‭‏‮‮‪‭‪‬‎⁮​‍‪⁪‌‬‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3157271136U)));
          goto label_38;
        }
        catch (Exception ex)
        {
label_24:
          int num2 = -1615515324;
          while (true)
          {
            int num3 = -462421234;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_24;
              case 1:
                num2 = (int) num4 * 1796102775 ^ 1151609654;
                continue;
              case 2:
                ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
                num2 = (int) num4 * -1934442168 ^ 1290196347;
                continue;
              default:
                goto label_34;
            }
          }
        }
      }
      catch (Exception ex)
      {
label_29:
        int num1 = -887698518;
        while (true)
        {
          int num2 = -462421234;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_29;
            case 1:
              ftp.\u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮(ftp.log, (object) ex);
              num1 = (int) num3 * -1562359880 ^ 516190366;
              continue;
            case 2:
              num1 = (int) num3 * 935737624 ^ 736811995;
              continue;
            case 3:
              num1 = (int) num3 * -2100828825 ^ -1220002475;
              continue;
            default:
              goto label_34;
          }
        }
      }
label_34:
      strArray = new string[1]{ "" };
label_35:
      int num6 = -1276965242;
      while (true)
      {
        int num1 = -462421234;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 0:
            goto label_35;
          case 2:
            num6 = (int) num2 * 1899462080 ^ -1824812797;
            continue;
          default:
            goto label_38;
        }
      }
label_38:
      return strArray;
    }

    static Uri \u200F⁬‏‫⁭‎⁫⁯​⁫‌⁫‮‏‪⁯‏‏‮‍‬‮‏‮⁮‪⁮​​⁪‍‫⁯‍‮‮‭​‫‭‮([In] string obj0)
    {
      return new Uri(obj0);
    }

    static Uri \u206D‫​⁮⁬‭‪​‏‍‌⁭⁬‌‬⁪⁬‏⁮⁪‫‌‎⁭⁮​‪‪‌‌⁮⁮⁪⁭‌‮‍⁭⁫⁫‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static Uri \u200E⁬⁭⁭⁪‌⁪⁫‬‎⁮‎‫‌‮‪‪⁭⁪⁪‭‪⁪⁭⁫‫​‮‫⁭‫‪‌‏‬‭⁫‮⁫⁬‮([In] Uri obj0, [In] Uri obj1)
    {
      return new Uri(obj0, obj1);
    }

    static WebRequest \u200C‭⁭⁯⁬‍​⁯‍‌‮‏⁪‌​‭‌‌‬‌⁭⁭⁬‎‎⁮‏⁯‬‏⁪⁭​‌‭‌‏‫‎⁭‮([In] Uri obj0)
    {
      return WebRequest.Create(obj0);
    }

    static NetworkCredential \u200E⁯⁮‮‍‫⁫‫⁯‏‪‮⁫‍‪‏‪​⁫​⁪⁫‭⁮‪‪‫‎‎‬‎⁯‬‌‏⁫⁫⁭‪‪‮([In] string obj0, [In] string obj1)
    {
      return new NetworkCredential(obj0, obj1);
    }

    static void \u202A⁪⁬⁮‫⁫‍‍‮⁫‪⁬‌​⁭​‭⁭‮⁬‏⁮​‭⁭‎‍⁫⁬⁬‏​⁭‍‏‎‭⁭⁭‭‮([In] WebRequest obj0, [In] ICredentials obj1)
    {
      obj0.Credentials = obj1;
    }

    static void \u206F​‭‭‏⁯‮⁯⁫‬⁯‭‏​‍⁪⁫⁭⁯⁮⁬‎‪‭⁬‮⁫‎​‎⁮‍‏‍‫‍‎​‫‮([In] FtpWebRequest obj0, [In] bool obj1)
    {
      obj0.UseBinary = obj1;
    }

    static void \u202C⁮‎‪‬‌‌‫⁭⁬‎‏⁭‫​‌⁮‌‭⁫⁫‮‬​‫‪⁮​​‮‫‌⁫‬‏⁪‪⁯‭⁪‮([In] FtpWebRequest obj0, [In] bool obj1)
    {
      obj0.UsePassive = obj1;
    }

    static void \u202C‏⁭‪⁭⁯‏⁬‬‏⁪⁭‭⁪‪‏⁮⁪‍‏‬‪​⁯‭‪⁫‭⁪⁪⁫‮‬‫⁪‪‫​‭‮([In] FtpWebRequest obj0, [In] bool obj1)
    {
      obj0.KeepAlive = obj1;
    }

    static void \u200F⁮‍‪‫⁮⁪‍‬‬‌‌⁫‪⁭‏⁬‫​‫⁭‎‎⁮‪‮‎⁬‌⁫‪⁪‪‭‬‬‏⁬‎‮‮([In] WebRequest obj0, [In] string obj1)
    {
      obj0.Method = obj1;
    }

    static WebResponse \u206B​‏‫⁪⁬​⁭⁭‭⁭‬⁫‍​​‪‫⁪‏‭⁮⁪‮⁫‎⁮⁬⁬‏⁫‌‫‫⁮⁬⁫‏⁪‍‮([In] WebRequest obj0)
    {
      return obj0.GetResponse();
    }

    static Stream \u202A‫​⁬‪‭⁭⁮‌‫‬‫‮‪‎‏⁮‫​⁪⁬‬‪⁫⁮‎⁪‮⁯⁭‭‌‪⁭‏‮⁪⁮⁫⁪‮([In] WebResponse obj0)
    {
      return obj0.GetResponseStream();
    }

    static FileStream \u200C⁮​‬‎​⁯​‏⁪‌‪‌‎‎‪‬⁬‌‭‏⁭⁯‬‪‮‬⁯⁭‫⁭​​⁮‪‍‫⁭‫‌‮([In] string obj0, [In] FileMode obj1)
    {
      return new FileStream(obj0, obj1);
    }

    static int \u202D⁯‫⁮⁪⁮⁫‪⁪⁫⁫‍‮‍​‎‌‪‍‮​⁬‪‬‍‪⁮​⁮⁬‮‪‎⁮⁯⁯‮‏⁯‫‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
    {
      return obj0.Read(obj1, obj2, obj3);
    }

    static void \u206B​‏⁭​⁯‌‮​⁯​⁭‭⁬‭⁯‌‫⁮‌‭‪‬⁪⁫‮‍‬‪‌‫⁯⁭‎⁭​​⁭⁮‬‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
    {
      obj0.Write(obj1, obj2, obj3);
    }

    static void \u200F‭⁯⁮⁮⁫‍‪‌‍‏‏⁭‪‫‮⁬‎‍⁯‎‍⁪⁮⁭‮‪‍‮‮⁬‎‭⁯⁫‫‪‎‮‍‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u200E⁪‭‪‮⁬‪⁭‮‏​⁭⁫⁯‏‎‌‌‮​‌‏‌‪‏​‬‮‪‏‌‏​‍‬​⁫‪‎‌‮([In] Stream obj0)
    {
      obj0.Close();
    }

    static void \u206B‫‍‌⁪⁬‎‬‭‎‪‌‌⁭⁯‮‭‌‎‭‮‏‎‫⁯​​⁯‫‍⁬‍⁮​⁪‮‌‎⁮‭‮([In] WebResponse obj0)
    {
      obj0.Close();
    }

    static Stream \u206F⁬‮​⁮‏‫‮‎‫⁪‬‪‫⁯⁮​‌⁯⁬⁬‏‬​‭⁪⁬‍‮‍⁪⁪​⁯​‏‏‭⁬‭‮([In] WebRequest obj0)
    {
      return obj0.GetRequestStream();
    }

    static string \u200B⁭‫‏⁬⁫‭⁮⁯‌‏⁮⁬‫​‪⁭‮⁫⁯⁭‫⁫‭‎⁮‌‎‎‮‬‎⁮‏‫‏‪‮⁮⁮‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u200E⁪‏​⁯‍‭‫‪‎‬‏​​‭‭‎⁫‫‪⁪‍‭⁭⁬⁮⁫⁫⁯‫⁭​‌‍‎‬‭‭⁬‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0 + obj1 + obj2;
    }

    static WebRequest \u200E‬⁮‌‌‮⁪‎‫‭‍⁮⁯⁮‫⁪⁪⁯⁬⁬‍‮‎‬‮⁯⁭⁪⁭⁪‮⁮‬⁪⁫‎⁬⁯‬‮([In] string obj0)
    {
      return WebRequest.Create(obj0);
    }

    static void \u202A‎⁭⁯⁪⁭‎⁮⁪‪‬‎‬⁭‮‌‭‪‬‪⁭‭​‭‌‎⁪⁯⁮⁫⁬​⁮‭‭‪​‪‎‪‮([In] FtpWebRequest obj0, [In] string obj1)
    {
      obj0.RenameTo = obj1;
    }

    static StreamReader \u200B‭⁮‎⁪‌‮‌‎‍⁮⁭​⁭‫⁫​⁫‬‎⁭‏‬⁫‪‮‬⁫​‭⁮‫​⁪⁭‮‎‌‏‏‮([In] Stream obj0)
    {
      return new StreamReader(obj0);
    }

    static string \u206A‏⁮⁭‬‎‎‫‭‎‏⁯⁪‍‪‮‏⁮​‬‬‌‮⁮‫⁬⁪‎‎‪⁯‏‬⁪⁯⁯‏‭⁬‭‮([In] TextReader obj0)
    {
      return obj0.ReadToEnd();
    }

    static void \u206A‪‏‌‪​⁮​⁮‌‭‫‎‫⁪‫‭⁬‍⁭‮⁫​‏‍⁭⁬‏‎‎‭​‮‫‍⁭⁫​‫⁭‮([In] TextReader obj0)
    {
      obj0.Close();
    }

    static int \u200E⁮⁪‌‮⁪⁮⁫⁬⁬‭‌‏‎‭‭‮⁭‬‭‍‪‫⁮⁮⁬‭‪‫⁪​‭⁬⁬​⁯‎⁪‏‎‮([In] TextReader obj0)
    {
      return obj0.Peek();
    }

    static string \u202E‫‬⁮‏‬⁮‮‪⁫⁫‭‏⁪⁯‬⁪‪‍‭‪‎‭​‏‪⁬‮‭⁮⁪⁯‎⁯‭⁫‌⁬‌‏‮([In] TextReader obj0)
    {
      return obj0.ReadLine();
    }

    static char[] \u200D‫​⁭‌‬⁮‮⁯⁬​‏‍‮​⁯⁬‫‏‌‫⁮‮‪‭‏‮‮‪‭‪‬‎⁮​‍‪⁪‌‬‮([In] string obj0)
    {
      return obj0.ToCharArray();
    }

    static string[] \u202B‭⁯‮‬‎⁫‫‬‪⁯⁪⁭⁬‫‌‎⁪‎‪‎⁪​‫⁭‬‏‌‏‫‏‫⁭‏‍‍‍‮‎‪‮([In] string obj0, [In] char[] obj1)
    {
      return obj0.Split(obj1);
    }

    static MethodBase \u202B‍‫⁬‏⁪‮‬‌‌⁭⁫‪‬‏‌​⁮‬‍⁭‍⁭‎⁪⁯‫‬⁮‍‭⁬⁭‭⁪‏⁯‭⁬‎‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202C‮‭‫‮⁪⁮‬‎‬⁬​⁪‪‮⁪⁪‪​‍‮​‮⁯‍⁮‫‌⁫⁬‌⁫⁭⁬‌‏​⁭⁮⁬‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202B‭‌‫‍⁫‫⁬‭​⁫‏⁫‬‌⁭‫​⁫​‍‫⁫⁫‬‌‬⁮‎‏​‍‪‏​‮‭‮⁪⁭‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
