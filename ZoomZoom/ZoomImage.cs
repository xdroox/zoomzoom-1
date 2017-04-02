// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomImage
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ZoomZoom.Models.Data;
using ZoomZoom.Models.Images;

namespace ZoomZoom
{
  public class ZoomImage : DataObject
  {
    private long meetingUri = 0;
    private long userUri = 0;
    private long chatUri = 0;
    private string userName = (string) null;
    private ZoomWindowType zoomWindowType = ZoomWindowType.Undefined;
    private ImageEnums.ImageType imageType = ImageEnums.ImageType.Undefined;
    private string name = string.Empty;
    private DateTime dateCreated = DateTime.MinValue;
    private DateTime dateModified = DateTime.MinValue;
    private int imageHeight = 0;
    private int imageWidth = 0;
    private IntPtr windowHandle = IntPtr.Zero;
    private ZoomWindow zoomWindow = (ZoomWindow) null;
    private bool displayAfterCapture = false;
    private bool displayHighlightWindow = false;
    private Rectangle rectangle = Rectangle.Empty;
    private ZoomUser user = (ZoomUser) null;
    private ZoomChat chat = (ZoomChat) null;
    private ZoomMeeting meeting = (ZoomMeeting) null;
    private Bitmap bitmap;
    private BitmapSource bitmapSource;

    public BitmapSource BitmapSource
    {
      get
      {
label_1:
        int num1 = -696534257;
        BitmapSource bitmapSource;
        while (true)
        {
          int num2 = -1956293986;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1742804505 ^ -1765230395;
              continue;
            case 1:
              bitmapSource = this.bitmapSource;
              num1 = (int) num3 * 1873239648 ^ 1646844118;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return bitmapSource;
      }
      set
      {
label_1:
        int num1 = -409308897;
        while (true)
        {
          int num2 = -2093861240;
          uint num3;
          bool flag1;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              flag2 = ZoomImage.\u206D‏‎‭‮‍‬​⁬⁮⁮⁭‪⁮‮⁫⁬‫​⁫‌‎‎‪‍⁪‭‪‍⁮‌‭‭​‎‌‬⁭‪‪‮((ImageSource) this.BitmapSource) != (double) this.ImageHeight;
              num1 = (int) num3 * 917946529 ^ 1729729868;
              continue;
            case 1:
              this.bitmapSource = value;
              flag1 = value != null;
              num1 = (int) num3 * -1065163705 ^ -191697980;
              continue;
            case 2:
              num1 = (int) num3 * 658002880 ^ -1616441176;
              continue;
            case 3:
              num1 = (int) num3 * -567030686 ^ -839474878;
              continue;
            case 4:
              int num4 = flag2 ? -783246582 : (num4 = -766510910);
              int num5 = (int) num3 * 1781778883;
              num1 = num4 ^ num5;
              continue;
            case 5:
              this.ImageWidth = (int) ZoomImage.\u200D⁯‌‫‏⁯⁪⁪⁯⁭‮⁯‮‍‪⁭​‪⁮⁬‏‍⁭‍‮‮⁫⁮⁭⁭‭‮‍​‍⁬‎⁯‌⁪‮((ImageSource) this.BitmapSource);
              num1 = (int) num3 * -2106423527 ^ -1813605840;
              continue;
            case 6:
              int num6;
              num1 = num6 = ZoomImage.\u200D⁯‌‫‏⁯⁪⁪⁯⁭‮⁯‮‍‪⁭​‪⁮⁬‏‍⁭‍‮‮⁫⁮⁭⁭‭‮‍​‍⁬‎⁯‌⁪‮((ImageSource) this.BitmapSource) != (double) this.ImageWidth ? -655542216 : (num6 = -1553616724);
              continue;
            case 7:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(283664080U));
              num1 = -1407405891;
              continue;
            case 8:
              goto label_3;
            case 9:
              num1 = (int) num3 * -139199496 ^ -1613514666;
              continue;
            case 10:
              this.ImageHeight = (int) ZoomImage.\u206D‏‎‭‮‍‬​⁬⁮⁮⁭‪⁮‮⁫⁬‫​⁫‌‎‎‪‍⁪‭‪‍⁮‌‭‭​‎‌‬⁭‪‪‮((ImageSource) this.BitmapSource);
              num1 = (int) num3 * 129331529 ^ -1281540606;
              continue;
            case 11:
              int num7 = flag1 ? 1296163061 : (num7 = 46030719);
              int num8 = (int) num3 * -229481622;
              num1 = num7 ^ num8;
              continue;
            case 12:
              num1 = (int) num3 * -1679951532 ^ -294808129;
              continue;
            case 13:
              num1 = (int) num3 * -1470084361 ^ -1138322785;
              continue;
            case 14:
              num1 = (int) num3 * 1365578262 ^ 1160321471;
              continue;
            case 15:
              num1 = (int) num3 * 378516144 ^ -1555239644;
              continue;
            case 16:
              num1 = -238951459;
              continue;
            case 17:
              goto label_1;
            default:
              goto label_20;
          }
        }
label_20:
        return;
label_3:;
      }
    }

    public Bitmap Bitmap
    {
      get
      {
label_1:
        int num1 = 1065516379;
        Bitmap bitmap;
        while (true)
        {
          int num2 = 2073434444;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * -1879562950 ^ 1942331846;
              continue;
            case 1:
              if (this.bitmap != null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 1177032628 ^ -1602086656;
              continue;
            case 2:
              int num5 = flag ? 1968389269 : (num5 = 1799212060);
              int num6 = (int) num3 * -1727873488;
              num1 = num5 ^ num6;
              continue;
            case 3:
              num1 = (int) num3 * -43276835 ^ 1232189733;
              continue;
            case 4:
              num4 = this.bitmapSource != null ? 1 : 0;
              break;
            case 5:
              goto label_1;
            case 6:
              bitmap = this.bitmap;
              num1 = 514257446;
              continue;
            case 8:
              this.bitmap = this.BitmapSource.ToWinFormsBitmap();
              num1 = (int) num3 * -1536364512 ^ 591546497;
              continue;
            default:
              goto label_13;
          }
          flag = num4 != 0;
          num1 = 2019706648;
        }
label_13:
        return bitmap;
      }
      set
      {
        this.bitmap = value;
label_1:
        int num1 = 556322641;
        while (true)
        {
          int num2 = 1369469326;
          uint num3;
          bool flag1;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 15U)
          {
            case 1:
              flag1 = value != null;
              num1 = (int) num3 * -1854069756 ^ 1668251591;
              continue;
            case 2:
              int num4;
              num1 = num4 = ZoomImage.\u206E‬⁪⁪⁪​​‏​⁯‬‫⁭⁯⁫‬‬‪‌‎⁮‫‬‌‏⁯⁯‭⁪‫‪⁯‮⁮‮‬‫‪‫⁮‮((Image) this.Bitmap) == this.ImageWidth ? 1749863393 : (num4 = 1892595726);
              continue;
            case 3:
              this.ImageHeight = ZoomImage.\u200E‫‍⁭⁬‏⁭⁪‪⁪⁮⁪​‫‎‎⁯‪⁮⁯​‫‌‭⁮‭⁮‬⁪‬‮​⁮‫‪‏​‫‌‍‮((Image) this.Bitmap);
              num1 = (int) num3 * 1520526779 ^ -2075036634;
              continue;
            case 4:
              num1 = (int) num3 * 392982674 ^ -443765950;
              continue;
            case 5:
              num1 = 617292955;
              continue;
            case 6:
              int num5 = flag2 ? 512475271 : (num5 = 1967943827);
              int num6 = (int) num3 * 109589562;
              num1 = num5 ^ num6;
              continue;
            case 7:
              this.ImageWidth = ZoomImage.\u206E‬⁪⁪⁪​​‏​⁯‬‫⁭⁯⁫‬‬‪‌‎⁮‫‬‌‏⁯⁯‭⁪‫‪⁯‮⁮‮‬‫‪‫⁮‮((Image) this.Bitmap);
              num1 = (int) num3 * -1108874772 ^ -547387342;
              continue;
            case 8:
              num1 = (int) num3 * -1710464868 ^ 1488470441;
              continue;
            case 9:
              flag2 = ZoomImage.\u200E‫‍⁭⁬‏⁭⁪‪⁪⁮⁪​‫‎‎⁯‪⁮⁯​‫‌‭⁮‭⁮‬⁪‬‮​⁮‫‪‏​‫‌‍‮((Image) this.Bitmap) != this.ImageHeight;
              num1 = (int) num3 * -1010570558 ^ 1595699963;
              continue;
            case 10:
              num1 = (int) num3 * 1337682827 ^ 1166583674;
              continue;
            case 11:
              int num7 = flag1 ? 1087889511 : (num7 = 891735536);
              int num8 = (int) num3 * -824169441;
              num1 = num7 ^ num8;
              continue;
            case 12:
              goto label_1;
            case 13:
              num1 = (int) num3 * 2068917016 ^ -1617440511;
              continue;
            case 14:
              num1 = (int) num3 * -1356175213 ^ -1629150677;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2443212812U));
      }
    }

    public IntPtr WindowHandle
    {
      get
      {
        return this.windowHandle;
      }
      set
      {
        bool flag = this.windowHandle == value;
label_1:
        int num1 = -998945835;
        while (true)
        {
          int num2 = -2020711889;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 949633602 ^ -1555096043;
              continue;
            case 1:
              this.windowHandle = value;
              num1 = -1988592774;
              continue;
            case 2:
              num1 = (int) num3 * -1910352038 ^ 423167695;
              continue;
            case 3:
              int num4 = flag ? -466547183 : (num4 = -1481454319);
              int num5 = (int) num3 * 1122715620;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_1;
            case 5:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3670091446U));
              num1 = (int) num3 * -256071568 ^ -394406196;
              continue;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public ZoomWindow ZoomWindow
    {
      get
      {
label_1:
        int num1 = 290809293;
        ZoomWindow zoomWindow;
        while (true)
        {
          int num2 = 668734548;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -465590867 ^ 2013398575;
              continue;
            case 1:
              flag = this.Engine != null;
              num1 = (int) num3 * 1391215953 ^ 1755264354;
              continue;
            case 2:
              zoomWindow = this.Engine.GetWindow(this.WindowHandle, false);
              num1 = (int) num3 * 1324830074 ^ 1827614406;
              continue;
            case 4:
              zoomWindow = (ZoomWindow) null;
              num1 = 1571564476;
              continue;
            case 5:
              goto label_1;
            case 6:
              num1 = (int) num3 * -1832110704 ^ 463355527;
              continue;
            case 7:
              int num4 = !flag ? 287356698 : (num4 = 1890930908);
              int num5 = (int) num3 * 853238646;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return zoomWindow;
      }
      set
      {
label_1:
        int num1 = -1529956687;
        while (true)
        {
          int num2 = -2129975427;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 1:
              num1 = (int) num3 * -628248572 ^ -1420016795;
              continue;
            case 2:
              int num4 = flag ? 1703309912 : (num4 = 1355663749);
              int num5 = (int) num3 * 642360302;
              num1 = num4 ^ num5;
              continue;
            case 3:
              this.WindowHandle = this.zoomWindow.Handle;
              num1 = (int) num3 * 1486844842 ^ -659786726;
              continue;
            case 4:
              this.zoomWindow = value;
              flag = this.zoomWindow != null;
              num1 = (int) num3 * -1441411327 ^ -1014484585;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2720744857U));
      }
    }

    public string Name
    {
      get
      {
        return this.name;
      }
      set
      {
        this.name = value;
label_1:
        int num1 = 1280373050;
        while (true)
        {
          int num2 = 436077895;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4283083687U));
              num1 = (int) num3 * -1054566149 ^ -1713725127;
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

    public DateTime DateCreated
    {
      get
      {
        DateTime dateCreated = this.dateCreated;
label_1:
        int num1 = -1473015955;
        while (true)
        {
          int num2 = -928151673;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 919895685 ^ 665717724;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dateCreated;
      }
      set
      {
        this.dateCreated = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3159846649U));
      }
    }

    public bool DisplayAfterCapture
    {
      get
      {
label_1:
        int num1 = -1627541930;
        bool displayAfterCapture;
        while (true)
        {
          int num2 = -1234944630;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              displayAfterCapture = this.displayAfterCapture;
              num1 = (int) num3 * 1741454236 ^ 1155389519;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return displayAfterCapture;
      }
      set
      {
label_1:
        int num1 = -1011282255;
        while (true)
        {
          int num2 = -1541000902;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -2135176410 ^ -463606886;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.displayAfterCapture = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4246893949U));
              num1 = (int) num3 * 918271924 ^ -1858186973;
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

    public bool DisplayHighlightWindow
    {
      get
      {
label_1:
        int num1 = 747721038;
        bool displayHighlightWindow;
        while (true)
        {
          int num2 = 214829755;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              displayHighlightWindow = this.displayHighlightWindow;
              num1 = (int) num3 * 1745933475 ^ -1666967777;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return displayHighlightWindow;
      }
      set
      {
        this.displayHighlightWindow = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(711911151U));
label_1:
        int num1 = 1856641559;
        while (true)
        {
          int num2 = 580307239;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 592532296 ^ -100047476;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public ZoomWindowType ZoomWindowType
    {
      get
      {
label_1:
        int num1 = -171246356;
        ZoomWindowType zoomWindowType;
        while (true)
        {
          int num2 = -1062828166;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1209647953 ^ 1944978082;
              continue;
            case 2:
              zoomWindowType = this.zoomWindowType;
              num1 = (int) num3 * -1512350425 ^ 1428629829;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return zoomWindowType;
      }
      set
      {
        this.zoomWindowType = value;
label_1:
        int num1 = 79566963;
        while (true)
        {
          int num2 = 419553559;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1684167442U));
              num1 = (int) num3 * 1856964902 ^ -729043670;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public Rectangle Rectangle
    {
      get
      {
label_1:
        int num1 = -1572822415;
        Rectangle rectangle;
        while (true)
        {
          int num2 = -523273432;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1468199823 ^ -1122233538;
              continue;
            case 1:
              rectangle = this.rectangle;
              num1 = (int) num3 * -1932046131 ^ -49552511;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return rectangle;
      }
      set
      {
label_1:
        int num1 = 1412925277;
        while (true)
        {
          int num2 = 1559440159;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.rectangle = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2227798090U));
              num1 = (int) num3 * -1218689794 ^ 1806696787;
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
    }

    public long MeetingUri
    {
      get
      {
label_1:
        int num1 = 1986280285;
        long meetingUri;
        while (true)
        {
          int num2 = 862472947;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              meetingUri = this.meetingUri;
              num1 = (int) num3 * 597470478 ^ 1601418837;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingUri;
      }
      set
      {
label_1:
        int num1 = -799086452;
        while (true)
        {
          int num2 = -36425561;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(129168074U));
              num1 = (int) num3 * 2147438477 ^ -1825886032;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.meetingUri = value;
              num1 = (int) num3 * 901351366 ^ 1270443116;
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

    public long UserUri
    {
      get
      {
label_1:
        int num1 = 989384299;
        long userUri;
        while (true)
        {
          int num2 = 1844452293;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1456233938 ^ 872449164;
              continue;
            case 2:
              userUri = this.userUri;
              num1 = (int) num3 * 2083997945 ^ 1642315690;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return userUri;
      }
      set
      {
        this.userUri = value;
label_1:
        int num1 = 1475788331;
        while (true)
        {
          int num2 = 201994538;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3361683222U));
              num1 = (int) num3 * 118088085 ^ -381286360;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 538158430 ^ -130922706;
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

    public long ChatUri
    {
      get
      {
        long chatUri = this.chatUri;
label_1:
        int num1 = -1967091608;
        while (true)
        {
          int num2 = -2080638895;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -265383015 ^ 1377555854;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chatUri;
      }
      set
      {
label_1:
        int num1 = -1496971099;
        while (true)
        {
          int num2 = -1982260165;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.chatUri = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2568406931U));
              num1 = (int) num3 * -1792267339 ^ -2012936252;
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

    public string UserName
    {
      get
      {
        string userName = this.userName;
label_1:
        int num1 = -238993423;
        while (true)
        {
          int num2 = -276135686;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1837280196 ^ -1494412194;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return userName;
      }
      set
      {
        this.userName = value;
label_1:
        int num1 = -226758122;
        while (true)
        {
          int num2 = -1044875942;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3204517876U));
              num1 = (int) num3 * -1812443740 ^ 730062748;
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

    public int ImageHeight
    {
      get
      {
label_1:
        int num1 = -1438478148;
        int imageHeight;
        while (true)
        {
          int num2 = -1991562839;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -962737167 ^ 96836170;
              continue;
            case 1:
              imageHeight = this.imageHeight;
              num1 = (int) num3 * 1933205609 ^ -1896146332;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return imageHeight;
      }
      set
      {
        this.imageHeight = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(567152199U));
      }
    }

    public int ImageWidth
    {
      get
      {
label_1:
        int num1 = -1425025630;
        int imageWidth;
        while (true)
        {
          int num2 = -124901095;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 909834855 ^ -1788463728;
              continue;
            case 3:
              imageWidth = this.imageWidth;
              num1 = (int) num3 * 1912075545 ^ 1460315423;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return imageWidth;
      }
      set
      {
        this.imageWidth = value;
label_1:
        int num1 = 647388660;
        while (true)
        {
          int num2 = 1158719020;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(639531675U));
              num1 = (int) num3 * -1588474203 ^ 928100331;
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

    public DateTime DateModified
    {
      get
      {
label_1:
        int num1 = -211252077;
        DateTime dateModified;
        while (true)
        {
          int num2 = -570396845;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              dateModified = this.dateModified;
              num1 = (int) num3 * 1958776270 ^ -406797010;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dateModified;
      }
      set
      {
label_1:
        int num1 = 1897138405;
        while (true)
        {
          int num2 = 525613454;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -1351065198 ^ -504646613;
              continue;
            case 3:
              this.dateModified = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3096187508U));
              num1 = (int) num3 * 1568275661 ^ -1269700905;
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

    public ImageEnums.ImageType ImageType
    {
      get
      {
        return this.imageType;
      }
      set
      {
label_1:
        int num1 = -372441188;
        while (true)
        {
          int num2 = -1989331435;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1555280885U));
              num1 = (int) num3 * -1985280103 ^ -733892522;
              continue;
            case 1:
              this.imageType = value;
              num1 = (int) num3 * -600336500 ^ -194691631;
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
    }

    public ZoomUser User
    {
      get
      {
label_1:
        int num1 = -1308930065;
        ZoomUser user;
        while (true)
        {
          int num2 = -1507830802;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              user = this.user;
              num1 = (int) num3 * 1409911457 ^ -373946027;
              continue;
            case 2:
              num1 = (int) num3 * 1569647808 ^ -193701167;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return user;
      }
      set
      {
        this.user = value;
label_1:
        int num1 = -419244127;
        while (true)
        {
          int num2 = -1706855343;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.UserUri = this.user.Uri;
              num1 = (int) num3 * -2136848676 ^ -1336036802;
              continue;
            case 1:
              int num4 = !flag ? 1311413446 : (num4 = 292181837);
              int num5 = (int) num3 * -256931654;
              num1 = num4 ^ num5;
              continue;
            case 2:
              flag = this.user != null;
              num1 = (int) num3 * -970484350 ^ -1809521942;
              continue;
            case 3:
              num1 = (int) num3 * -696769130 ^ 1189583394;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1909431601U));
      }
    }

    public ZoomChat Chat
    {
      get
      {
label_1:
        int num1 = -379431150;
        ZoomChat chat;
        while (true)
        {
          int num2 = -694796055;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              chat = this.chat;
              num1 = (int) num3 * 1362949344 ^ 741288347;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return chat;
      }
      set
      {
        this.chat = value;
        bool flag = this.chat != null;
label_1:
        int num1 = -1384634832;
        while (true)
        {
          int num2 = -176662272;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2796987152U));
              num1 = -160680861;
              continue;
            case 3:
              int num4 = !flag ? 165939459 : (num4 = 2084040078);
              int num5 = (int) num3 * -167343141;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.ChatUri = this.chat.Uri;
              num1 = (int) num3 * -2016320474 ^ -44802969;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public ZoomMeeting Meeting
    {
      get
      {
label_1:
        int num1 = 34550226;
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = 1906659145;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1289318105 ^ -300313632;
              continue;
            case 2:
              goto label_1;
            case 3:
              meeting = this.meeting;
              num1 = (int) num3 * 1034854247 ^ 1786690292;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meeting;
      }
      set
      {
label_1:
        int num1 = -1353015831;
        while (true)
        {
          int num2 = -702386404;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.meetingUri = this.meeting.Uri;
              num1 = (int) num3 * 1532498582 ^ -248929948;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.meeting = value;
              int num4 = this.meeting == null ? -898881704 : (num4 = -1937854798);
              int num5 = (int) num3 * -1002561480;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2670290613U));
              num1 = -1275031046;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public override ObjectDataTable ZoomZoomTable
    {
      get
      {
label_1:
        int num1 = 1266232796;
        ObjectDataTable objectDataTable;
        while (true)
        {
          int num2 = 1115968272;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              objectDataTable = ObjectDataTable.Images;
              num1 = (int) num3 * 1936351988 ^ -102614756;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return objectDataTable;
      }
    }

    public override TraceType TraceType
    {
      get
      {
        return TraceType.Image;
      }
    }

    public ZoomImage(ZoomWindow window, BitmapSource source)
    {
      this.windowHandle = window.Handle;
      this.ZoomWindowType = window.ZoomWindowType;
      this.zoomWindow = window;
      this.bitmapSource = source;
      this.name = ZoomImage.\u206A‎‮‭​‭‫⁮‪​⁭‍⁭‍‪⁬‬‎‎⁭‌‫‌⁮⁮⁭‪⁮‍‮⁪⁭‏⁬‪‬​‏‏‎‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(646903610U), (object) this.ZoomWindowType, (object) this.WindowHandle);
      this.dateCreated = DateTime.Now;
      this.Rectangle = window.Rectangle;
      this.imageWidth = (int) ZoomImage.\u200D⁯‌‫‏⁯⁪⁪⁯⁭‮⁯‮‍‪⁭​‪⁮⁬‏‍⁭‍‮‮⁫⁮⁭⁭‭‮‍​‍⁬‎⁯‌⁪‮((ImageSource) source);
      this.imageHeight = (int) ZoomImage.\u206D‏‎‭‮‍‬​⁬⁮⁮⁭‪⁮‮⁫⁬‫​⁫‌‎‎‪‍⁪‭‪‍⁮‌‭‭​‎‌‬⁭‪‪‮((ImageSource) source);
    }

    public ZoomImage(ZoomWindow window, Bitmap bitmap)
    {
      this.windowHandle = window.Handle;
      this.ZoomWindowType = window.ZoomWindowType;
      this.zoomWindow = window;
      this.bitmap = bitmap;
      this.bitmapSource = bitmap.ToWpfBitmap();
      this.name = ZoomImage.\u206A‎‮‭​‭‫⁮‪​⁭‍⁭‍‪⁬‬‎‎⁭‌‫‌⁮⁮⁭‪⁮‍‮⁪⁭‏⁬‪‬​‏‏‎‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(646903610U), (object) this.ZoomWindowType, (object) this.WindowHandle);
      this.dateCreated = DateTime.Now;
      this.Rectangle = window.Rectangle;
      this.imageHeight = ZoomImage.\u200E‫‍⁭⁬‏⁭⁪‪⁪⁮⁪​‫‎‎⁯‪⁮⁯​‫‌‭⁮‭⁮‬⁪‬‮​⁮‫‪‏​‫‌‍‮((Image) bitmap);
      this.imageWidth = ZoomImage.\u206E‬⁪⁪⁪​​‏​⁯‬‫⁭⁯⁫‬‬‪‌‎⁮‫‬‌‏⁯⁯‭⁪‫‪⁯‮⁮‮‬‫‪‫⁮‮((Image) bitmap);
    }

    public ZoomImage(SQLiteDataReader cReader, bool lazyLoadImage = true)
    {
      this.LoadDataObject(cReader);
    }

    public ZoomImage(string filePath)
    {
      this.Bitmap = ZoomImage.\u200D⁬‭‌‫‍‪⁮‌⁫⁪‍⁭‌‏‍⁭‌‬⁪⁫‪‌​⁯⁭‭⁪‏‮‪‎⁬​⁬⁭‍‪‮‭‮(filePath);
      this.BitmapSource = (BitmapSource) ZoomImage.\u200D⁭⁬⁭‎‍⁮‎⁮‌‪⁯​‫‪⁫‮‪⁫‫‎⁬‫⁮‫⁮‬⁪⁮​‭‭⁪⁬⁯⁯⁯‬‪‪‮(ZoomImage.\u200E​⁯⁯⁭⁫⁯‬‌‌‭‬‮‫‫⁫⁮‬‎‏‎‭‭‮‌‭⁪‮​‏​⁭​‮‬‍‭​‪⁯‮(filePath));
      this.ImageHeight = (int) ZoomImage.\u206D‏‎‭‮‍‬​⁬⁮⁮⁭‪⁮‮⁫⁬‫​⁫‌‎‎‪‍⁪‭‪‍⁮‌‭‭​‎‌‬⁭‪‪‮((ImageSource) this.BitmapSource);
      this.ImageWidth = (int) ZoomImage.\u200D⁯‌‫‏⁯⁪⁪⁯⁭‮⁯‮‍‪⁭​‪⁮⁬‏‍⁭‍‮‮⁫⁮⁭⁭‭‮‍​‍⁬‎⁯‌⁪‮((ImageSource) this.BitmapSource);
      this.Name = ZoomImage.\u206B‪‍‍‏‭​‮⁫⁪⁫‏⁫‎‫‎⁫‮⁯⁫⁯‌‌‍⁭‎‬⁪‫‭⁫‎⁮‎⁯‍⁯‎‬⁬‮(filePath);
    }

    public override Dictionary<string, object> GetDataDictionary()
    {
label_1:
      int num1 = 651851950;
      Dictionary<string, object> dictionary1;
      while (true)
      {
        int num2 = 185773611;
        uint num3;
        Dictionary<string, object> dictionary2;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 29U)
        {
          case 0:
            int num4 = flag2 ? 551713067 : (num4 = 188615454);
            int num5 = (int) num3 * -533942510;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * 632631531 ^ -1604954324;
            continue;
          case 3:
            num1 = (int) num3 * -267303114 ^ 568895752;
            continue;
          case 4:
            dictionary2 = new Dictionary<string, object>();
            num1 = (int) num3 * -1959096445 ^ 1583241611;
            continue;
          case 5:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3450719713U), (object) this.MeetingUri);
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3080182564U), (object) this.ChatUri);
            num1 = (int) num3 * -621643074 ^ -1466423601;
            continue;
          case 6:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2905870342U), (object) this.Name);
            num1 = (int) num3 * 783105241 ^ -986402071;
            continue;
          case 7:
            num1 = (int) num3 * 910339357 ^ 533461673;
            continue;
          case 8:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3523099189U), (object) ZoomImage.BitmapToByteArray((Image) this.bitmap, ZoomImage.\u206C‫⁭⁫‎‮⁪‍⁪‫​‮⁪‬⁫‏⁯​‪⁫‭⁬⁯‌‍‎⁭‫‮⁫​‮​‭‬‪‏⁪​⁮‮()));
            num1 = (int) num3 * -1683659815 ^ 1703966230;
            continue;
          case 9:
            goto label_1;
          case 10:
            num1 = (int) num3 * 1308009790 ^ 2033733403;
            continue;
          case 11:
            flag1 = this.bitmapSource != null;
            num1 = (int) num3 * -182861639 ^ 1598378247;
            continue;
          case 12:
            num1 = (int) num3 * 1475919693 ^ -252651404;
            continue;
          case 13:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3402256922U), (object) this.ImageType);
            num1 = (int) num3 * 1844322822 ^ 785197371;
            continue;
          case 14:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(850864340U), (object) DateTime.MinValue);
            num1 = (int) num3 * 1432354441 ^ 358168897;
            continue;
          case 15:
            num1 = (int) num3 * -80602263 ^ 1590840130;
            continue;
          case 16:
            num1 = (int) num3 * -769049457 ^ 706176471;
            continue;
          case 17:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3758218176U), (object) this.UserUri);
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3848806831U), (object) this.UserName);
            num1 = (int) num3 * 486744659 ^ 808820012;
            continue;
          case 18:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3970518777U), (object) 0);
            num1 = (int) num3 * -1367585501 ^ 1883578101;
            continue;
          case 19:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2182723723U), (object) this.DateCreated);
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3397799221U), (object) this.DateModified);
            num1 = (int) num3 * 1134877972 ^ 59746880;
            continue;
          case 20:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3756650564U), (object) this.BitmapSourceToByte(this.bitmapSource));
            num1 = (int) num3 * -576105104 ^ -1643646279;
            continue;
          case 21:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(869869778U), (object) this.ImageHeight);
            num1 = (int) num3 * 1932961743 ^ 1187500546;
            continue;
          case 22:
            num1 = (int) num3 * 2116361316 ^ 1470299896;
            continue;
          case 23:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1714565130U), (object) this.ImageWidth);
            num1 = (int) num3 * 1434166928 ^ 1983456853;
            continue;
          case 24:
            num1 = (int) num3 * -1413621062 ^ -679698639;
            continue;
          case 25:
            flag2 = this.bitmap != null;
            num1 = 1308735518;
            continue;
          case 26:
            dictionary1 = dictionary2;
            num1 = 1697136103;
            continue;
          case 27:
            int num6 = flag1 ? -1283867636 : (num6 = -96475309);
            int num7 = (int) num3 * -2024894659;
            num1 = num6 ^ num7;
            continue;
          case 28:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U), (object) this.Uri);
            num1 = (int) num3 * 457750914 ^ -1538360622;
            continue;
          default:
            goto label_30;
        }
      }
label_30:
      return dictionary1;
    }

    internal bool LoadImage()
    {
      bool flag1 = false;
      try
      {
        byte[] imageContent = this.Engine.ZoomZoomDatabase.GetImageContent(this.Uri);
label_2:
        int num1 = -247212906;
        while (true)
        {
          int num2 = -644215019;
          uint num3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              flag1 = true;
              num1 = (int) num3 * 1166250800 ^ 1540009562;
              continue;
            case 1:
              if (imageContent != null)
              {
                num1 = (int) num3 * -444271708 ^ -144625858;
                continue;
              }
              num4 = 0;
              break;
            case 2:
              this.Bitmap = this.BitmapSource.ToWinFormsBitmap();
              num1 = (int) num3 * -1761427092 ^ 1241646536;
              continue;
            case 3:
              this.BitmapSource = BitmapConversion.ByteArrayToBitmapSource(imageContent);
              num1 = (int) num3 * 1391598231 ^ -622125829;
              continue;
            case 4:
              num1 = -2093035672;
              continue;
            case 5:
              num1 = (int) num3 * -30183192 ^ 1140843845;
              continue;
            case 6:
              goto label_2;
            case 8:
              num4 = (uint) imageContent.Length > 0U ? 1 : 0;
              break;
            default:
              goto label_19;
          }
          int num5;
          num1 = num5 = num4 == 0 ? -186281891 : (num5 = -190256899);
        }
      }
      catch (Exception ex)
      {
label_15:
        int num1 = -1103570004;
        while (true)
        {
          int num2 = -644215019;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1870220622 ^ -1456676286;
              continue;
            case 1:
              ZoomImage.\u206E‌⁮⁬⁮⁯⁪⁫⁫⁮‭⁭‫⁬‬​‪⁬‬‮‍‏⁬⁭​‌⁫⁯‌⁫‪⁭⁫​‏‭⁮⁯‬‮‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1481926297 ^ 72228834;
              continue;
            case 2:
              goto label_15;
            default:
              goto label_19;
          }
        }
      }
label_19:
      bool flag2 = flag1;
label_20:
      int num6 = -853678362;
      while (true)
      {
        int num1 = -644215019;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 1:
            num6 = (int) num2 * -1538711503 ^ -1407843308;
            continue;
          case 2:
            goto label_20;
          default:
            goto label_23;
        }
      }
label_23:
      return flag2;
    }

    public byte[] BitmapImageToByte(BitmapImage imageSource)
    {
label_1:
      int num1 = 698281710;
      Stream stream;
      byte[] numArray1;
      while (true)
      {
        int num2 = 784873094;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num4 = ZoomImage.\u206D⁬‭‌‌‫‍⁯‎⁮‍‫‭‫⁯‎‌‌‪⁯‬‎‪⁫‎‍⁭⁮‌⁪‮‪‭‪⁫‌‭‪‮‮‮(stream) > 0L ? 1 : 0;
            break;
          case 2:
            stream = ZoomImage.\u200C‬‎‮‭‪​‪⁮‬⁭‌⁬‫‭⁯‪⁯‭‌​‬‍⁭⁬​⁭⁭‫⁭‎‏⁯‮⁬‭⁮‮⁬‮(imageSource);
            num1 = (int) num3 * -883100967 ^ -1831727850;
            continue;
          case 3:
            goto label_1;
          case 4:
            numArray1 = (byte[]) null;
            if (stream == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1030000668 ^ -352912284;
            continue;
          case 5:
            num1 = (int) num3 * 1865637551 ^ 1663932734;
            continue;
          default:
            goto label_11;
        }
        if (num4 != 0)
          num1 = 879011607;
        else
          goto label_26;
      }
label_11:
      BinaryReader binaryReader = ZoomImage.\u206B⁬‫⁮⁮‏⁬​‫‏‭⁪​‮‫⁭‍‫‬⁭‍‭‍‎‍‌‭‬‪⁬⁮⁬‬‌‭‭​‫‮‎‮(stream);
      try
      {
label_13:
        int num2 = 235791003;
        while (true)
        {
          int num3 = 784873094;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              num2 = (int) num4 * -509432863 ^ 994640688;
              continue;
            case 1:
              numArray1 = ZoomImage.\u206C‏‌‎‬⁭⁭‌⁬⁫⁬‭‌‎​‎‭‭‫⁬​⁪‫​‭‍⁫⁭‮‭⁪⁬‬‎⁫‭‮‭‏‫‮(binaryReader, (int) ZoomImage.\u206D⁬‭‌‌‫‍⁯‎⁮‍‫‭‫⁯‎‌‌‪⁯‬‎‪⁫‎‍⁭⁮‌⁪‮‪‭‪⁫‌‭‪‮‮‮(stream));
              num2 = (int) num4 * -348088741 ^ 862895253;
              continue;
            case 3:
              goto label_13;
            default:
              goto label_23;
          }
        }
      }
      finally
      {
        if (binaryReader != null)
        {
label_18:
          int num2 = 135118623;
          while (true)
          {
            int num3 = 784873094;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_18;
              case 1:
                ZoomImage.\u206B‪‍⁫‎⁬⁯‬‌‭‍‍⁮​⁯‎⁪‏⁯⁭‪⁭‍‮⁮‫‬‏⁭​‪⁮‌​‮‪‬⁮​‏‮((IDisposable) binaryReader);
                num2 = (int) num4 * -1847315022 ^ 797968018;
                continue;
              case 2:
                num2 = (int) num4 * -1763139240 ^ 1584843265;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_23:
label_24:
      int num5 = 284649459;
label_25:
      while (true)
      {
        int num2 = 784873094;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 4U)
        {
          case 0:
            goto label_24;
          case 1:
            goto label_26;
          case 3:
            num5 = (int) num3 * 183548688 ^ 566998512;
            continue;
          default:
            goto label_28;
        }
      }
label_28:
      byte[] numArray2;
      return numArray2;
label_26:
      numArray2 = numArray1;
      num5 = 1680527465;
      goto label_25;
    }

    public byte[] ImageSourceToBytes(BitmapEncoder encoder, ImageSource imageSource)
    {
label_1:
      int num1 = 737567686;
      byte[] numArray1;
      BitmapSource bitmapSource;
      while (true)
      {
        int num2 = 297270474;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 2:
            bitmapSource = imageSource as BitmapSource;
            if (bitmapSource != null)
            {
              num1 = (int) num3 * -1152084401 ^ 569239816;
              continue;
            }
            goto label_23;
          case 3:
            num1 = (int) num3 * 2097059700 ^ 1897456245;
            continue;
          case 4:
            numArray1 = (byte[]) null;
            num1 = (int) num3 * 1320190885 ^ 144895018;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      ZoomImage.\u206A⁬⁯‏⁬​‪⁯‌​⁪‌‪‪⁬‮‏⁪‪‪‫‬⁪‮‭⁪⁭‮‪⁮‮‮‍‪⁬‪​‍‬‮‮(encoder).Add(ZoomImage.\u206E⁭⁪‭⁭‪⁮‌‫‍‭⁮⁭‍‏⁯‎⁫‬‌‎⁪‫‪‌‏‍‏⁬‌‍‍⁬⁫⁭‌⁭‭⁬⁬‮(bitmapSource));
      MemoryStream memoryStream = ZoomImage.\u206F⁫‫‬⁫⁮‎​‬⁭‌‭‍‫‮⁬‏⁪‬⁮‭‫‫‬‬⁮‮‭‫‫‏‫‍‮‮⁭‍‌‮‬‮();
      try
      {
label_9:
        int num2 = 270263648;
        while (true)
        {
          int num3 = 297270474;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = (int) num4 * -1114872257 ^ 1239045497;
              continue;
            case 2:
              ZoomImage.\u206D‪⁭‍⁬‌⁫​‫‍‫‫‎⁪‫⁯‫⁫‮‫‮‎‏⁮⁭​⁮⁪⁬‏⁪​‌⁫⁪‭‮⁪‭‎‮(encoder, (Stream) memoryStream);
              num2 = (int) num4 * -367427084 ^ 1671645043;
              continue;
            case 3:
              numArray1 = ZoomImage.\u206D‌‏‬⁬‍⁪‭‭‭‌⁬‮‌‎‍⁭​‍‍‬⁫‏⁪⁮‎⁭⁯⁪⁭‪‫‏​​⁪⁪‌‬‎‮(memoryStream);
              num2 = (int) num4 * -791890469 ^ 468415133;
              continue;
            case 4:
              goto label_9;
            case 5:
              num2 = (int) num4 * -1124026788 ^ 683218419;
              continue;
            default:
              goto label_20;
          }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
label_16:
          int num2 = 1508923721;
          while (true)
          {
            int num3 = 297270474;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_16;
              case 1:
                ZoomImage.\u206B‪‍⁫‎⁬⁯‬‌‭‍‍⁮​⁯‎⁪‏⁯⁭‪⁭‍‮⁮‫‬‏⁭​‪⁮‌​‮‪‬⁮​‏‮((IDisposable) memoryStream);
                num2 = (int) num4 * 1927148662 ^ -1640196830;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
label_20:
label_21:
      int num5 = 192801753;
label_22:
      while (true)
      {
        int num2 = 297270474;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 4U)
        {
          case 0:
            goto label_21;
          case 2:
            num5 = (int) num3 * -940860336 ^ -1945253625;
            continue;
          case 3:
            goto label_23;
          default:
            goto label_25;
        }
      }
label_25:
      byte[] numArray2;
      return numArray2;
label_23:
      numArray2 = numArray1;
      num5 = 1114562116;
      goto label_22;
    }

    public override bool LoadDataObject(SQLiteDataReader cReader)
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = 632373823;
        while (true)
        {
          int num2 = 1972491053;
          uint num3;
          bool flag2;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 23U)
          {
            case 0:
              flag2 = this.UserUri > 0L;
              num1 = (int) num3 * -351943206 ^ 1741458402;
              continue;
            case 2:
              this.imageType = (ImageEnums.ImageType) cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3402256922U));
              num1 = (int) num3 * 2077626457 ^ -2126106069;
              continue;
            case 3:
              this.uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3666502981U));
              num1 = (int) num3 * -1912742102 ^ -830901467;
              continue;
            case 4:
              int num4 = flag2 ? -695192752 : (num4 = -497185042);
              int num5 = (int) num3 * 527713835;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = (int) num3 * 1605701805 ^ -972047897;
              continue;
            case 6:
              num1 = (int) num3 * -1577560007 ^ 1457248555;
              continue;
            case 7:
              this.User = this.Engine.GetUser(this.UserUri);
              num1 = (int) num3 * 1381603987 ^ -2127389292;
              continue;
            case 8:
              this.UserName = this.User.UserName;
              num1 = (int) num3 * 1185006269 ^ -1582706149;
              continue;
            case 9:
              flag3 = this.User != null;
              num1 = (int) num3 * 504260205 ^ -211056762;
              continue;
            case 10:
              num1 = 1105389823;
              continue;
            case 11:
              num1 = (int) num3 * -46563282 ^ -1445215884;
              continue;
            case 12:
              num1 = (int) num3 * -1198074194 ^ 93873212;
              continue;
            case 13:
              this.UserUri = cReader.GetFieldValueLong(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1172614769U));
              num1 = (int) num3 * 1689418744 ^ 940730859;
              continue;
            case 14:
              flag1 = true;
              num1 = (int) num3 * -266627587 ^ 1533709272;
              continue;
            case 15:
              this.chatUri = cReader.GetFieldValueLong(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3080182564U));
              num1 = (int) num3 * 60155861 ^ -837515003;
              continue;
            case 16:
              int num6 = !flag3 ? -1016582493 : (num6 = -1617919097);
              int num7 = (int) num3 * -542964425;
              num1 = num6 ^ num7;
              continue;
            case 17:
              this.dateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3335598589U));
              num1 = (int) num3 * -150073450 ^ -1163060530;
              continue;
            case 18:
              this.meetingUri = cReader.GetFieldValueLong(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3171538459U));
              num1 = (int) num3 * -44208014 ^ -794430225;
              continue;
            case 19:
              this.imageHeight = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(608746246U));
              this.imageWidth = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1714565130U));
              num1 = (int) num3 * 314844331 ^ -1082777713;
              continue;
            case 20:
              this.dateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3689749305U));
              num1 = 705759730;
              continue;
            case 21:
              goto label_2;
            case 22:
              this.name = cReader.GetFieldValueString(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2905870342U));
              num1 = (int) num3 * -1382441589 ^ -884399366;
              continue;
            default:
              goto label_30;
          }
        }
      }
      catch (Exception ex)
      {
label_26:
        int num1 = 529762604;
        while (true)
        {
          int num2 = 1972491053;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -950611591 ^ 1913316888;
              continue;
            case 2:
              goto label_26;
            default:
              goto label_29;
          }
        }
label_29:
        ZoomImage.\u206E‌⁮⁬⁮⁯⁪⁫⁫⁮‭⁭‫⁬‬​‪⁬‬‮‍‏⁬⁭​‌⁫⁯‌⁫‪⁭⁫​‏‭⁮⁯‬‮‮(CoreObject.log, (object) ex);
      }
label_30:
      bool flag4 = flag1;
label_31:
      int num8 = 1880924137;
      while (true)
      {
        int num1 = 1972491053;
        uint num2;
        switch ((num2 = (uint) (num8 ^ num1)) % 3U)
        {
          case 1:
            num8 = (int) num2 * -879976295 ^ 1054483500;
            continue;
          case 2:
            goto label_31;
          default:
            goto label_34;
        }
      }
label_34:
      return flag4;
    }

    internal static byte[] BitmapToByteArray(Image image, ImageFormat format)
    {
      MemoryStream memoryStream = ZoomImage.\u206F⁫‫‬⁫⁮‎​‬⁭‌‭‍‫‮⁬‏⁪‬⁮‭‫‫‬‬⁮‮‭‫‫‏‫‍‮‮⁭‍‌‮‬‮();
      try
      {
label_2:
        int num1 = -851636125;
        while (true)
        {
          int num2 = -1102320834;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              ZoomImage.\u206E‫⁪‭‌⁭‬‬⁪⁯​‍‪​‌‎⁯‭⁬‪‭​‮‫‌​⁭​‭⁮⁭‬⁪​‬‌‏‬‍‫‮(image, (Stream) memoryStream, format);
              num1 = (int) num3 * -485719256 ^ -290109365;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_5;
          }
        }
label_5:
        return ZoomImage.\u206D‌‏‬⁬‍⁪‭‭‭‌⁬‮‌‎‍⁭​‍‍‬⁫‏⁪⁮‎⁭⁯⁪⁭‪‫‏​​⁪⁪‌‬‎‮(memoryStream);
      }
      finally
      {
        if (memoryStream != null)
        {
label_7:
          int num1 = -1974440941;
          while (true)
          {
            int num2 = -1102320834;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                ZoomImage.\u206B‪‍⁫‎⁬⁯‬‌‭‍‍⁮​⁯‎⁪‏⁯⁭‪⁭‍‮⁮‫‬‏⁭​‪⁮‌​‮‪‬⁮​‏‮((IDisposable) memoryStream);
                num1 = (int) num3 * 1339538162 ^ 738782567;
                continue;
              case 2:
                goto label_7;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
    }

    internal static BitmapImage ByteToBitmapImage(byte[] imageBytes)
    {
      BitmapImage bitmapImage = ZoomImage.\u202E⁫⁫‭‍⁮‪⁭‪‫‎⁭⁬‌‍‭‭⁭‬‫⁬⁫‬‌‍‭⁫‏‍​⁮‭‏‎‮⁬‌‪⁭⁪‮();
      MemoryStream memoryStream1 = ZoomImage.\u206F⁫‫‬⁫⁮‎​‬⁭‌‭‍‫‮⁬‏⁪‬⁮‭‫‫‬‬⁮‮‭‫‫‏‫‍‮‮⁭‍‌‮‬‮();
      try
      {
        ZoomImage.\u206A‌‪‫⁫‏⁮⁬‬⁫⁮‬​‌‎‮⁭‭‬​​‪​‎⁮⁭‪⁭‌⁭‫⁭⁫‎⁯‮⁫‫‌‮‮((Stream) memoryStream1, imageBytes, 0, imageBytes.Length);
label_2:
        int num1 = -852852447;
        Image image;
        while (true)
        {
          int num2 = -2005929201;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -1127086876 ^ -156320782;
              continue;
            case 2:
              num1 = (int) num3 * 1774462016 ^ -1950959889;
              continue;
            case 3:
              image = ZoomImage.\u206E‮⁯‮‪‪‬‍⁫⁬‭⁯‏​⁫⁭‍‌‭‭‏‮⁮‪‮⁬‏‭‏⁪‬‬⁫‮⁪⁮‪‍‍⁬‮((Stream) memoryStream1);
              num1 = (int) num3 * 844503036 ^ -769129847;
              continue;
            case 4:
              goto label_2;
            case 5:
              ZoomImage.\u202C‭‎‮‫⁫‎‫⁪⁯‭‎⁯‎‪⁭​⁮‮‫‌‮‏‫⁮⁬‌‪‏⁯⁯‮‪⁭⁮‎⁪‭⁬‌‮(bitmapImage);
              num1 = (int) num3 * 1046504379 ^ -1005300166;
              continue;
            case 6:
              ZoomImage.\u202C⁮‏‬‏⁯‮⁪‮‬‮⁯⁬‍‮⁪⁭‎​⁬‏⁫⁭⁫‭‏⁭‮⁮‏‍‍‪‏‬⁬‏⁯‪‍‮((Stream) memoryStream1, 0L);
              num1 = (int) num3 * 1323152491 ^ -1584188383;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        MemoryStream memoryStream2 = ZoomImage.\u206F⁫‫‬⁫⁮‎​‬⁭‌‭‍‫‮⁬‏⁪‬⁮‭‫‫‬‬⁮‮‭‫‫‏‫‍‮‮⁭‍‌‮‬‮();
        try
        {
          ZoomImage.\u206E‫⁪‭‌⁭‬‬⁪⁯​‍‪​‌‎⁯‭⁬‪‭​‮‫‌​⁭​‭⁮⁭‬⁪​‬‌‏‬‍‫‮(image, (Stream) memoryStream2, ZoomImage.\u206C‫⁭⁫‎‮⁪‍⁪‫​‮⁪‬⁫‏⁯​‪⁫‭⁬⁯‌‍‎⁭‫‮⁫​‮​‭‬‪‏⁪​⁮‮());
label_11:
          int num2 = -7329679;
          while (true)
          {
            int num3 = -2005929201;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                ZoomImage.\u200B‮⁮‌⁪‌‪‭‎‮‭‏‬⁪‌⁪​‍⁫‌‌⁫⁫‭‬⁪‭‮⁪​‮⁫‍‏⁮‎‮‫‮⁯‮(bitmapImage, (Stream) memoryStream2);
                num2 = (int) num4 * -97821156 ^ -1287073736;
                continue;
              case 1:
                ZoomImage.\u200B‎⁭‭⁪‭‎‫‬​‏⁭‭​‬⁭‫‌‎⁯⁭⁪‪‭⁪⁪⁪⁬⁮‮‭⁯⁯⁫⁬⁭⁫‫⁭⁬‮((Stream) memoryStream2, 0L, SeekOrigin.Begin);
                num2 = (int) num4 * 1274024083 ^ -1873132364;
                continue;
              case 2:
                num2 = (int) num4 * -2123135176 ^ -424353986;
                continue;
              case 3:
                goto label_11;
              case 5:
                num2 = (int) num4 * -1855870989 ^ 2039603828;
                continue;
              default:
                goto label_23;
            }
          }
        }
        finally
        {
          if (memoryStream2 != null)
          {
label_18:
            int num2 = -316683248;
            while (true)
            {
              int num3 = -2005929201;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_18;
                case 1:
                  num2 = (int) num4 * 1531363781 ^ 2118294848;
                  continue;
                case 3:
                  ZoomImage.\u206B‪‍⁫‎⁬⁯‬‌‭‍‍⁮​⁯‎⁪‏⁯⁭‪⁭‍‮⁮‫‬‏⁭​‪⁮‌​‮‪‬⁮​‏‮((IDisposable) memoryStream2);
                  num2 = (int) num4 * -887215079 ^ -2105637391;
                  continue;
                default:
                  goto label_22;
              }
            }
          }
label_22:;
        }
label_23:
        ZoomImage.\u206C⁭‫‏‌‫‮⁯‍⁭⁭‏‪‎⁪⁪⁮‮⁪‪⁮‬⁫‮‪‏​‫⁭‭⁯‎‮‮‎‪‌‎‮⁯‮(bitmapImage);
label_24:
        int num5 = -1228320394;
        while (true)
        {
          int num2 = -2005929201;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 3U)
          {
            case 0:
              goto label_24;
            case 1:
              num5 = (int) num3 * -199462339 ^ -918713323;
              continue;
            default:
              goto label_33;
          }
        }
      }
      finally
      {
        if (memoryStream1 != null)
        {
label_28:
          int num1 = -357746370;
          while (true)
          {
            int num2 = -2005929201;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                ZoomImage.\u206B‪‍⁫‎⁬⁯‬‌‭‍‍⁮​⁯‎⁪‏⁯⁭‪⁭‍‮⁮‫‬‏⁭​‪⁮‌​‮‪‬⁮​‏‮((IDisposable) memoryStream1);
                num1 = (int) num3 * -1176116870 ^ 46053386;
                continue;
              case 2:
                goto label_28;
              case 3:
                num1 = (int) num3 * 63316311 ^ 1270366482;
                continue;
              default:
                goto label_32;
            }
          }
        }
label_32:;
      }
label_33:
      return bitmapImage;
    }

    private byte[] BitmapSourceToByte(BitmapSource bitmapSource)
    {
      JpegBitmapEncoder jpegBitmapEncoder = ZoomImage.\u206A⁮⁫‫‭‮⁭⁬⁬⁬‪‎⁫⁯⁭‪⁯‏‎⁫⁯⁮‎⁬‪⁭‬​‮‭⁯‪⁬‌‍⁫‪​⁭‌‮();
      ZoomImage.\u200C‫‭⁬⁭⁪‮‮‌⁬‌‭‮‎​⁭‌‏‌⁮‏​⁪⁯⁯⁫‍‌​‌⁬⁭⁬​‪⁭⁭​⁫‪‮(jpegBitmapEncoder, 100);
      MemoryStream memoryStream = ZoomImage.\u206F⁫‫‬⁫⁮‎​‬⁭‌‭‍‫‮⁬‏⁪‬⁮‭‫‫‬‬⁮‮‭‫‫‏‫‍‮‮⁭‍‌‮‬‮();
      byte[] numArray1;
      try
      {
        ZoomImage.\u206A⁬⁯‏⁬​‪⁯‌​⁪‌‪‪⁬‮‏⁪‪‪‫‬⁪‮‭⁪⁭‮‪⁮‮‮‍‪⁬‪​‍‬‮‮((BitmapEncoder) jpegBitmapEncoder).Add(ZoomImage.\u206E⁭⁪‭⁭‪⁮‌‫‍‭⁮⁭‍‏⁯‎⁫‬‌‎⁪‫‪‌‏‍‏⁬‌‍‍⁬⁫⁭‌⁭‭⁬⁬‮(bitmapSource));
label_2:
        int num1 = 990808861;
        while (true)
        {
          int num2 = 1011178345;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * -714775408 ^ -306282862;
              continue;
            case 2:
              ZoomImage.\u206A‏‎‏⁭‮‭​‫‫‬‍‪⁯⁬‌‏⁭⁬‪‫‎‌⁮⁯‪‌‫‭‏⁪⁫⁫‌‏⁮‎⁭‏⁬‮((Stream) memoryStream);
              num1 = (int) num3 * -1200553724 ^ -1967448615;
              continue;
            case 3:
              num1 = (int) num3 * -879775345 ^ 2145317021;
              continue;
            case 4:
              num1 = (int) num3 * 1959304641 ^ 1240545930;
              continue;
            case 5:
              goto label_2;
            case 6:
              numArray1 = ZoomImage.\u206D‌‏‬⁬‍⁪‭‭‭‌⁬‮‌‎‍⁭​‍‍‬⁫‏⁪⁮‎⁭⁯⁪⁭‪‫‏​​⁪⁪‌‬‎‮(memoryStream);
              num1 = (int) num3 * 1678894179 ^ 1040880457;
              continue;
            case 7:
              ZoomImage.\u206D‪⁭‍⁬‌⁫​‫‍‫‫‎⁪‫⁯‫⁫‮‫‮‎‏⁮⁭​⁮⁪⁬‏⁪​‌⁫⁪‭‮⁪‭‎‮((BitmapEncoder) jpegBitmapEncoder, (Stream) memoryStream);
              num1 = (int) num3 * 1433159756 ^ -1231725469;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
label_11:
          int num1 = 1232962580;
          while (true)
          {
            int num2 = 1011178345;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_11;
              case 2:
                ZoomImage.\u206B‪‍⁫‎⁬⁯‬‌‭‍‍⁮​⁯‎⁪‏⁯⁭‪⁭‍‮⁮‫‬‏⁭​‪⁮‌​‮‪‬⁮​‏‮((IDisposable) memoryStream);
                num1 = (int) num3 * -1975558412 ^ -2041285628;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      byte[] numArray2 = numArray1;
label_16:
      int num4 = 1852276455;
      while (true)
      {
        int num1 = 1011178345;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 1:
            num4 = (int) num2 * 1985754680 ^ 1633921019;
            continue;
          case 2:
            goto label_16;
          default:
            goto label_19;
        }
      }
label_19:
      return numArray2;
    }

    static double \u206D‏‎‭‮‍‬​⁬⁮⁮⁭‪⁮‮⁫⁬‫​⁫‌‎‎‪‍⁪‭‪‍⁮‌‭‭​‎‌‬⁭‪‪‮([In] ImageSource obj0)
    {
      return obj0.Height;
    }

    static double \u200D⁯‌‫‏⁯⁪⁪⁯⁭‮⁯‮‍‪⁭​‪⁮⁬‏‍⁭‍‮‮⁫⁮⁭⁭‭‮‍​‍⁬‎⁯‌⁪‮([In] ImageSource obj0)
    {
      return obj0.Width;
    }

    static int \u200E‫‍⁭⁬‏⁭⁪‪⁪⁮⁪​‫‎‎⁯‪⁮⁯​‫‌‭⁮‭⁮‬⁪‬‮​⁮‫‪‏​‫‌‍‮([In] Image obj0)
    {
      return obj0.Height;
    }

    static int \u206E‬⁪⁪⁪​​‏​⁯‬‫⁭⁯⁫‬‬‪‌‎⁮‫‬‌‏⁯⁯‭⁪‫‪⁯‮⁮‮‬‫‪‫⁮‮([In] Image obj0)
    {
      return obj0.Width;
    }

    static string \u206A‎‮‭​‭‫⁮‪​⁭‍⁭‍‪⁬‬‎‎⁭‌‫‌⁮⁮⁭‪⁮‍‮⁪⁭‏⁬‪‬​‏‏‎‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      return string.Format(obj0, obj1, obj2);
    }

    static Bitmap \u200D⁬‭‌‫‍‪⁮‌⁫⁪‍⁭‌‏‍⁭‌‬⁪⁫‪‌​⁯⁭‭⁪‏‮‪‎⁬​⁬⁭‍‪‮‭‮([In] string obj0)
    {
      return new Bitmap(obj0);
    }

    static Uri \u200E​⁯⁯⁭⁫⁯‬‌‌‭‬‮‫‫⁫⁮‬‎‏‎‭‭‮‌‭⁪‮​‏​⁭​‮‬‍‭​‪⁯‮([In] string obj0)
    {
      return new Uri(obj0);
    }

    static BitmapImage \u200D⁭⁬⁭‎‍⁮‎⁮‌‪⁯​‫‪⁫‮‪⁫‫‎⁬‫⁮‫⁮‬⁪⁮​‭‭⁪⁬⁯⁯⁯‬‪‪‮([In] Uri obj0)
    {
      return new BitmapImage(obj0);
    }

    static string \u206B‪‍‍‏‭​‮⁫⁪⁫‏⁫‎‫‎⁫‮⁯⁫⁯‌‌‍⁭‎‬⁪‫‭⁫‎⁮‎⁯‍⁯‎‬⁬‮([In] string obj0)
    {
      return Path.GetFileNameWithoutExtension(obj0);
    }

    static ImageFormat \u206C‫⁭⁫‎‮⁪‍⁪‫​‮⁪‬⁫‏⁯​‪⁫‭⁬⁯‌‍‎⁭‫‮⁫​‮​‭‬‪‏⁪​⁮‮()
    {
      return ImageFormat.Bmp;
    }

    static void \u206E‌⁮⁬⁮⁯⁪⁫⁫⁮‭⁭‫⁬‬​‪⁬‬‮‍‏⁬⁭​‌⁫⁯‌⁫‪⁭⁫​‏‭⁮⁯‬‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static Stream \u200C‬‎‮‭‪​‪⁮‬⁭‌⁬‫‭⁯‪⁯‭‌​‬‍⁭⁬​⁭⁭‫⁭‎‏⁯‮⁬‭⁮‮⁬‮([In] BitmapImage obj0)
    {
      return obj0.StreamSource;
    }

    static long \u206D⁬‭‌‌‫‍⁯‎⁮‍‫‭‫⁯‎‌‌‪⁯‬‎‪⁫‎‍⁭⁮‌⁪‮‪‭‪⁫‌‭‪‮‮‮([In] Stream obj0)
    {
      return obj0.Length;
    }

    static BinaryReader \u206B⁬‫⁮⁮‏⁬​‫‏‭⁪​‮‫⁭‍‫‬⁭‍‭‍‎‍‌‭‬‪⁬⁮⁬‬‌‭‭​‫‮‎‮([In] Stream obj0)
    {
      return new BinaryReader(obj0);
    }

    static byte[] \u206C‏‌‎‬⁭⁭‌⁬⁫⁬‭‌‎​‎‭‭‫⁬​⁪‫​‭‍⁫⁭‮‭⁪⁬‬‎⁫‭‮‭‏‫‮([In] BinaryReader obj0, [In] int obj1)
    {
      return obj0.ReadBytes(obj1);
    }

    static void \u206B‪‍⁫‎⁬⁯‬‌‭‍‍⁮​⁯‎⁪‏⁯⁭‪⁭‍‮⁮‫‬‏⁭​‪⁮‌​‮‪‬⁮​‏‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static IList<BitmapFrame> \u206A⁬⁯‏⁬​‪⁯‌​⁪‌‪‪⁬‮‏⁪‪‪‫‬⁪‮‭⁪⁭‮‪⁮‮‮‍‪⁬‪​‍‬‮‮([In] BitmapEncoder obj0)
    {
      return obj0.Frames;
    }

    static BitmapFrame \u206E⁭⁪‭⁭‪⁮‌‫‍‭⁮⁭‍‏⁯‎⁫‬‌‎⁪‫‪‌‏‍‏⁬‌‍‍⁬⁫⁭‌⁭‭⁬⁬‮([In] BitmapSource obj0)
    {
      return BitmapFrame.Create(obj0);
    }

    static MemoryStream \u206F⁫‫‬⁫⁮‎​‬⁭‌‭‍‫‮⁬‏⁪‬⁮‭‫‫‬‬⁮‮‭‫‫‏‫‍‮‮⁭‍‌‮‬‮()
    {
      return new MemoryStream();
    }

    static void \u206D‪⁭‍⁬‌⁫​‫‍‫‫‎⁪‫⁯‫⁫‮‫‮‎‏⁮⁭​⁮⁪⁬‏⁪​‌⁫⁪‭‮⁪‭‎‮([In] BitmapEncoder obj0, [In] Stream obj1)
    {
      obj0.Save(obj1);
    }

    static byte[] \u206D‌‏‬⁬‍⁪‭‭‭‌⁬‮‌‎‍⁭​‍‍‬⁫‏⁪⁮‎⁭⁯⁪⁭‪‫‏​​⁪⁪‌‬‎‮([In] MemoryStream obj0)
    {
      return obj0.ToArray();
    }

    static void \u206E‫⁪‭‌⁭‬‬⁪⁯​‍‪​‌‎⁯‭⁬‪‭​‮‫‌​⁭​‭⁮⁭‬⁪​‬‌‏‬‍‫‮([In] Image obj0, [In] Stream obj1, [In] ImageFormat obj2)
    {
      obj0.Save(obj1, obj2);
    }

    static BitmapImage \u202E⁫⁫‭‍⁮‪⁭‪‫‎⁭⁬‌‍‭‭⁭‬‫⁬⁫‬‌‍‭⁫‏‍​⁮‭‏‎‮⁬‌‪⁭⁪‮()
    {
      return new BitmapImage();
    }

    static void \u206A‌‪‫⁫‏⁮⁬‬⁫⁮‬​‌‎‮⁭‭‬​​‪​‎⁮⁭‪⁭‌⁭‫⁭⁫‎⁯‮⁫‫‌‮‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
    {
      obj0.Write(obj1, obj2, obj3);
    }

    static void \u202C⁮‏‬‏⁯‮⁪‮‬‮⁯⁬‍‮⁪⁭‎​⁬‏⁫⁭⁫‭‏⁭‮⁮‏‍‍‪‏‬⁬‏⁯‪‍‮([In] Stream obj0, [In] long obj1)
    {
      obj0.Position = obj1;
    }

    static Image \u206E‮⁯‮‪‪‬‍⁫⁬‭⁯‏​⁫⁭‍‌‭‭‏‮⁮‪‮⁬‏‭‏⁪‬‬⁫‮⁪⁮‪‍‍⁬‮([In] Stream obj0)
    {
      return Image.FromStream(obj0);
    }

    static void \u202C‭‎‮‫⁫‎‫⁪⁯‭‎⁯‎‪⁭​⁮‮‫‌‮‏‫⁮⁬‌‪‏⁯⁯‮‪⁭⁮‎⁪‭⁬‌‮([In] BitmapImage obj0)
    {
      obj0.BeginInit();
    }

    static long \u200B‎⁭‭⁪‭‎‫‬​‏⁭‭​‬⁭‫‌‎⁯⁭⁪‪‭⁪⁪⁪⁬⁮‮‭⁯⁯⁫⁬⁭⁫‫⁭⁬‮([In] Stream obj0, [In] long obj1, [In] SeekOrigin obj2)
    {
      return obj0.Seek(obj1, obj2);
    }

    static void \u200B‮⁮‌⁪‌‪‭‎‮‭‏‬⁪‌⁪​‍⁫‌‌⁫⁫‭‬⁪‭‮⁪​‮⁫‍‏⁮‎‮‫‮⁯‮([In] BitmapImage obj0, [In] Stream obj1)
    {
      obj0.StreamSource = obj1;
    }

    static void \u206C⁭‫‏‌‫‮⁯‍⁭⁭‏‪‎⁪⁪⁮‮⁪‪⁮‬⁫‮‪‏​‫⁭‭⁯‎‮‮‎‪‌‎‮⁯‮([In] BitmapImage obj0)
    {
      obj0.EndInit();
    }

    static JpegBitmapEncoder \u206A⁮⁫‫‭‮⁭⁬⁬⁬‪‎⁫⁯⁭‪⁯‏‎⁫⁯⁮‎⁬‪⁭‬​‮‭⁯‪⁬‌‍⁫‪​⁭‌‮()
    {
      return new JpegBitmapEncoder();
    }

    static void \u200C‫‭⁬⁭⁪‮‮‌⁬‌‭‮‎​⁭‌‏‌⁮‏​⁪⁯⁯⁫‍‌​‌⁬⁭⁬​‪⁭⁭​⁫‪‮([In] JpegBitmapEncoder obj0, [In] int obj1)
    {
      obj0.QualityLevel = obj1;
    }

    static void \u206A‏‎‏⁭‮‭​‫‫‬‍‪⁯⁬‌‏⁭⁬‪‫‎‌⁮⁯‪‌‫‭‏⁪⁫⁫‌‏⁮‎⁭‏⁬‮([In] Stream obj0)
    {
      obj0.Close();
    }
  }
}
