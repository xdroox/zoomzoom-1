// Decompiled with JetBrains decompiler
// Type: ZoomZoom.VersionInfo
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public class VersionInfo
  {
    private string title = string.Empty;
    private string url = string.Empty;
    private string version = string.Empty;
    private string changelog = string.Empty;
    private bool mandatory = false;
    private long size = 0;
    private string fileName = string.Empty;
    private string published = string.Empty;
    private string localPath = string.Empty;
    private bool downloaded = false;

    public string Title
    {
      get
      {
label_1:
        int num1 = -441241455;
        string title;
        while (true)
        {
          int num2 = -1251650859;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              title = this.title;
              num1 = (int) num3 * 10326502 ^ -1436137226;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return title;
      }
      set
      {
label_1:
        int num1 = -756946803;
        while (true)
        {
          int num2 = -864578055;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.title = value;
              num1 = (int) num3 * -1207158663 ^ 118229672;
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

    public string Url
    {
      get
      {
label_1:
        int num1 = -141555806;
        string url;
        while (true)
        {
          int num2 = -1002546347;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 371926061 ^ -776139574;
              continue;
            case 3:
              url = this.url;
              num1 = (int) num3 * 1191956982 ^ 1676594629;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return url;
      }
      set
      {
label_1:
        int num1 = -632118701;
        while (true)
        {
          int num2 = -1341683794;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.url = value;
              num1 = (int) num3 * 899842985 ^ -2059380424;
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

    public string Version
    {
      get
      {
label_1:
        int num1 = 739420231;
        string version;
        while (true)
        {
          int num2 = 347817505;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              version = this.version;
              num1 = (int) num3 * -1105176871 ^ -1002761654;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return version;
      }
      set
      {
        this.version = value;
      }
    }

    public System.Version VersionObj
    {
      get
      {
label_1:
        int num1 = 628128876;
        System.Version version;
        while (true)
        {
          int num2 = 1454184581;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1063696558 ^ -730024166;
              continue;
            case 1:
              version = VersionInfo.\u206E⁮⁬‮‭⁯‍‪‌‪⁬‬⁮​‭‍‎‫‬‎​‏‌‍‮‏‪‍‮‪⁯⁫‭‮‭⁭⁬​​‪‮(this.version);
              num1 = (int) num3 * -1990540515 ^ -1567266228;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return version;
      }
    }

    public string Changelog
    {
      get
      {
        string changelog = this.changelog;
label_1:
        int num1 = -1848132491;
        while (true)
        {
          int num2 = -171708970;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1733430789 ^ 1276210662;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return changelog;
      }
      set
      {
        this.changelog = value;
      }
    }

    public bool Mandatory
    {
      get
      {
        return this.mandatory;
      }
      set
      {
        this.mandatory = value;
      }
    }

    public long Size
    {
      get
      {
        long size = this.size;
label_1:
        int num1 = 1408731846;
        while (true)
        {
          int num2 = 231592642;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -393521607 ^ -1828800494;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return size;
      }
      set
      {
        this.size = value;
      }
    }

    public string FileName
    {
      get
      {
label_1:
        int num1 = -281659433;
        string fileName;
        while (true)
        {
          int num2 = -418545182;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              fileName = this.fileName;
              num1 = (int) num3 * 582531763 ^ -549306489;
              continue;
            case 2:
              num1 = (int) num3 * -1774038905 ^ -671058052;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return fileName;
      }
      set
      {
label_1:
        int num1 = -328766254;
        while (true)
        {
          int num2 = -1409519110;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.fileName = value;
              num1 = (int) num3 * 738506795 ^ 500934874;
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

    public DateTime PublishedDate
    {
      get
      {
label_1:
        int num1 = 1723959979;
        DateTime dateTime;
        while (true)
        {
          int num2 = 185030037;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              dateTime = VersionInfo.\u200B‎‮‌⁭‫⁭⁪‌⁪⁫‭⁫‎‫⁭‏⁬⁪⁪‪‪‬⁭⁪‮⁭⁪‏‭‎‬‏⁬⁬‬‮‌‪‎‮(this.published);
              num1 = (int) num3 * 549886052 ^ 1889661884;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return dateTime;
      }
    }

    public string Published
    {
      get
      {
        string published = this.published;
label_1:
        int num1 = 64158747;
        while (true)
        {
          int num2 = 1314654530;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1783428032 ^ 1556489246;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return published;
      }
      set
      {
        this.published = value;
      }
    }

    public string LocalPath
    {
      get
      {
label_1:
        int num1 = 1552035197;
        string localPath;
        while (true)
        {
          int num2 = 1316611949;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              localPath = this.localPath;
              num1 = (int) num3 * -1380025633 ^ 1559788411;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return localPath;
      }
      set
      {
        this.localPath = value;
      }
    }

    public bool Downloaded
    {
      get
      {
        bool downloaded = this.downloaded;
label_1:
        int num1 = 89063354;
        while (true)
        {
          int num2 = 1013342599;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 2129356733 ^ -286909148;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return downloaded;
      }
      set
      {
        this.downloaded = value;
      }
    }

    public VersionInfo()
    {
label_1:
      int num1 = -1125451883;
      while (true)
      {
        int num2 = -1142461104;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1275342760 ^ 1604683229;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    static System.Version \u206E⁮⁬‮‭⁯‍‪‌‪⁬‬⁮​‭‍‎‫‬‎​‏‌‍‮‏‪‍‮‪⁯⁫‭‮‭⁭⁬​​‪‮([In] string obj0)
    {
      return new System.Version(obj0);
    }

    static DateTime \u200B‎‮‌⁭‫⁭⁪‌⁪⁫‭⁫‎‫⁭‏⁬⁪⁪‪‪‬⁭⁪‮⁭⁪‏‭‎‬‏⁬⁬‬‮‌‪‎‮([In] string obj0)
    {
      return Convert.ToDateTime(obj0);
    }
  }
}
