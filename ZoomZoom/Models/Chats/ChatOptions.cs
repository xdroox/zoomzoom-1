// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Chats.ChatOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZoomZoom.Common;

namespace ZoomZoom.Models.Chats
{
  public class ChatOptions : CoreObject
  {
    private static LockedObservableCollection<MessageCategory> sourceCategories = new LockedObservableCollection<MessageCategory>();
    private MessageCategory sourceCategory = (MessageCategory) null;
    private MessageContent content = (MessageContent) null;
    private string userName = (string) null;
    private bool randomMessage = false;
    private bool randomMessageSupported = false;
    private string manualMessage = string.Empty;
    private bool manualMessageSupported = false;
    private bool isValid = false;
    private string messageToSend = (string) null;
    private static LockedObservableCollection<MessageContent> sourceMessages;

    public LockedObservableCollection<MessageCategory> SourceCategories
    {
      get
      {
label_1:
        int num1 = -154628179;
        LockedObservableCollection<MessageCategory> sourceCategories;
        while (true)
        {
          int num2 = -697674508;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              sourceCategories = ChatOptions.sourceCategories;
              num1 = (int) num3 * -1951315581 ^ -1378679388;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -97438797 ^ 1731547257;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return sourceCategories;
      }
      set
      {
        ChatOptions.sourceCategories = value;
label_1:
        int num1 = -1255924970;
        while (true)
        {
          int num2 = -897628535;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 300871543 ^ 749219112;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1978748702U));
              num1 = (int) num3 * 1595149637 ^ -1792773969;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -728484128;
        TraceType traceType;
        while (true)
        {
          int num2 = -1581404839;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Chat;
              num1 = (int) num3 * -774409437 ^ 1026273676;
              continue;
            case 2:
              num1 = (int) num3 * -1171589348 ^ 2143548658;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public MessageCategory SourceCategory
    {
      get
      {
label_1:
        int num1 = -1880169239;
        MessageCategory sourceCategory;
        while (true)
        {
          int num2 = -1745168600;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              sourceCategory = this.sourceCategory;
              num1 = (int) num3 * -542539316 ^ 1755836698;
              continue;
            case 2:
              num1 = (int) num3 * -420265910 ^ -1281755477;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return sourceCategory;
      }
      set
      {
label_1:
        int num1 = -729782300;
        while (true)
        {
          int num2 = -305920014;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              goto label_1;
            case 1:
              this.LoadSourceContents();
              num1 = (int) num3 * -2029622951 ^ -1696286439;
              continue;
            case 2:
              num1 = (int) num3 * -1765226897 ^ 165271823;
              continue;
            case 3:
              num1 = (int) num3 * 308728505 ^ -446430615;
              continue;
            case 4:
              this.sourceCategory = value;
              int num4 = this.sourceCategory == null ? -708023955 : (num4 = -1592155875);
              int num5 = (int) num3 * 441141335;
              num1 = num4 ^ num5;
              continue;
            case 5:
              num1 = -965165545;
              continue;
            case 6:
              num1 = (int) num3 * -721860156 ^ -1117940859;
              continue;
            case 7:
              goto label_3;
            case 8:
              this.SourceContent = (MessageContent) null;
              num1 = (int) num3 * 533936799 ^ -393009478;
              continue;
            case 9:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1301769020U));
              num1 = -731397945;
              continue;
            case 10:
              num1 = (int) num3 * 1601318011 ^ -1758871527;
              continue;
            case 11:
              int num6 = flag ? 70513197 : (num6 = 1344118070);
              int num7 = (int) num3 * -2025404031;
              num1 = num6 ^ num7;
              continue;
            case 12:
              flag = !this.sourceCategory.AutoGenerated;
              num1 = (int) num3 * -1729698790 ^ -34864025;
              continue;
            case 13:
              this.ManualMessageSupported = true;
              num1 = (int) num3 * 1618868378 ^ -1755444390;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_3:;
      }
    }

    public LockedObservableCollection<MessageContent> SourceContents
    {
      get
      {
label_1:
        int num1 = -101590304;
        LockedObservableCollection<MessageContent> sourceMessages;
        while (true)
        {
          int num2 = -1105788459;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -158437080 ^ -899710058;
              continue;
            case 1:
              sourceMessages = ChatOptions.sourceMessages;
              num1 = (int) num3 * -1743354556 ^ -121518011;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return sourceMessages;
      }
      set
      {
        ChatOptions.sourceMessages = value;
        if (value != null)
          goto label_9;
label_1:
        int num1 = -1944452358;
label_2:
        while (true)
        {
          int num2 = -302300459;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -836145745 ^ -48202701;
              continue;
            case 2:
              num1 = (int) num3 * -2029404029 ^ 1950441033;
              continue;
            case 3:
              goto label_8;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1955230644U));
              num1 = -266146374;
              continue;
            case 5:
              this.RandomMessage = false;
              num1 = (int) num3 * 1344808952 ^ 798019230;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:
        return;
label_8:
        int num4 = this.RandomMessage ? 1 : 0;
        goto label_10;
label_9:
        num4 = 0;
label_10:
        num1 = num4 != 0 ? -2014956 : (num1 = -2022854658);
        goto label_2;
      }
    }

    public MessageContent SourceContent
    {
      get
      {
        MessageContent content = this.content;
label_1:
        int num1 = -1865533580;
        while (true)
        {
          int num2 = -1526408285;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 812758374 ^ 727139052;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return content;
      }
      set
      {
        this.content = value;
label_1:
        int num1 = 2000542136;
        while (true)
        {
          int num2 = 99636933;
          uint num3;
          bool flag1;
          bool flag2;
          bool flag3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 25U)
          {
            case 0:
              int num5 = flag2 ? 1217975632 : (num5 = 476029929);
              int num6 = (int) num3 * -1140448473;
              num1 = num5 ^ num6;
              continue;
            case 1:
              num1 = (int) num3 * 940059756 ^ -566907791;
              continue;
            case 2:
              this.ManualMessage = DateTime.Now.ToString();
              num1 = (int) num3 * 305084374 ^ 1980041647;
              continue;
            case 3:
              int num7 = !flag3 ? -215202450 : (num7 = -116355881);
              int num8 = (int) num3 * -1155155190;
              num1 = num7 ^ num8;
              continue;
            case 4:
              num1 = 1778110983;
              continue;
            case 5:
              num1 = (int) num3 * 1953835153 ^ -1918484541;
              continue;
            case 6:
              num4 = !ChatOptions.\u200D⁫⁫‎‭‪⁪‮‎‭⁬‏⁮‏‎‮‎⁬⁯‭‬‪‌⁬⁭⁫‫‮‎‌‮⁪⁪‎‫‎‌‫⁯‮(this.content.ContentText) ? 1 : 0;
              goto label_12;
            case 7:
              num1 = (int) num3 * -72766134 ^ -782934252;
              continue;
            case 8:
              flag3 = ChatOptions.\u206F‌‌​⁪⁯‌⁫‪⁫⁫⁭‬‪‌⁭‍⁯‏​⁫‫⁮⁭‏​⁬‎‌‌⁫‎‫‎‬‌‫‮⁬⁬‮(this.content.ContentText, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3409232957U));
              num1 = (int) num3 * 778138356 ^ -1486443540;
              continue;
            case 9:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2053548791U));
              num1 = (int) num3 * -147876055 ^ -1403896034;
              continue;
            case 10:
              this.RandomMessage = false;
              num1 = 1966257374;
              continue;
            case 11:
              goto label_1;
            case 12:
              if (this.SourceCategory != null)
              {
                num1 = (int) num3 * -658070770 ^ -967657351;
                continue;
              }
              break;
            case 13:
              this.ManualMessage = this.Engine.Settings.GetRandomText();
              num1 = (int) num3 * -788483673 ^ -140115907;
              continue;
            case 14:
              this.ManualMessage = Guid.NewGuid().ToString();
              num1 = (int) num3 * 475976893 ^ 1948526861;
              continue;
            case 15:
              num1 = (int) num3 * 142872381 ^ 293608149;
              continue;
            case 16:
              num1 = (int) num3 * 1306177580 ^ -264153810;
              continue;
            case 17:
              int num9;
              num1 = num9 = this.content.ContentText.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3040659562U)) ? 1237723178 : (num9 = 811579121);
              continue;
            case 18:
              goto label_3;
            case 19:
              flag1 = this.content.ContentText.Equals(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2934774063U));
              num1 = 480492459;
              continue;
            case 20:
              int num10 = flag1 ? -1695818576 : (num10 = -598126826);
              int num11 = (int) num3 * -653594640;
              num1 = num10 ^ num11;
              continue;
            case 21:
              num1 = (int) num3 * -1936166711 ^ -1712645611;
              continue;
            case 22:
              num1 = (int) num3 * -980768140 ^ 789521255;
              continue;
            case 23:
              if (this.content != null)
              {
                num1 = (int) num3 * 313641621 ^ -956294694;
                continue;
              }
              break;
            case 24:
              if (ChatOptions.\u206F‌‌​⁪⁯‌⁫‪⁫⁫⁭‬‪‌⁭‍⁯‏​⁫‫⁮⁭‏​⁬‎‌‌⁫‎‫‎‬‌‫‮⁬⁬‮(this.SourceCategory.CategoryName, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1448669856U)))
              {
                num1 = (int) num3 * -2077108272 ^ 1652515980;
                continue;
              }
              break;
            default:
              goto label_32;
          }
          num4 = 0;
label_12:
          flag2 = num4 != 0;
          num1 = 2048355751;
        }
label_32:
        return;
label_3:;
      }
    }

    public string ManualMessage
    {
      get
      {
        string manualMessage = this.manualMessage;
label_1:
        int num1 = 875736256;
        while (true)
        {
          int num2 = 315238378;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 191530610 ^ -856686810;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return manualMessage;
      }
      set
      {
label_1:
        int num1 = -1097451899;
        while (true)
        {
          int num2 = -436196624;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.manualMessage = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1957269003U));
              num1 = (int) num3 * -282181514 ^ 1862156780;
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

    public bool RandomMessage
    {
      get
      {
label_1:
        int num1 = -1909601651;
        bool randomMessage;
        while (true)
        {
          int num2 = -2099417436;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              randomMessage = this.randomMessage;
              num1 = (int) num3 * 1074780559 ^ -126351451;
              continue;
            case 2:
              num1 = (int) num3 * -1259409224 ^ 2091422363;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return randomMessage;
      }
      set
      {
        this.randomMessage = value;
label_1:
        int num1 = -1376735110;
        while (true)
        {
          int num2 = -259405475;
          uint num3;
          bool flag;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1843010228 ^ 75664374;
              continue;
            case 2:
              if (this.content != null)
              {
                num1 = (int) num3 * -1492151310 ^ 400899173;
                continue;
              }
              break;
            case 4:
              num1 = (int) num3 * 1768996358 ^ 1871821512;
              continue;
            case 5:
              this.SourceContent = (MessageContent) null;
              num1 = (int) num3 * -1347289815 ^ -1370941935;
              continue;
            case 6:
              num4 = !ChatOptions.\u200D⁫⁫‎‭‪⁪‮‎‭⁬‏⁮‏‎‮‎⁬⁯‭‬‪‌⁬⁭⁫‫‮‎‌‮⁪⁪‎‫‎‌‫⁯‮(this.content.ContentText) ? 1 : 0;
              goto label_8;
            case 7:
              if (!this.randomMessage)
              {
                num5 = 0;
                goto label_11;
              }
              else
              {
                num1 = -1349313672;
                continue;
              }
            case 8:
              if (ChatOptions.\u206F‌‌​⁪⁯‌⁫‪⁫⁫⁭‬‪‌⁭‍⁯‏​⁫‫⁮⁭‏​⁬‎‌‌⁫‎‫‎‬‌‫‮⁬⁬‮(this.SourceCategory.CategoryName, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1911978268U)))
              {
                num1 = (int) num3 * -494310655 ^ -529044737;
                continue;
              }
              break;
            case 9:
              num5 = this.SourceContent != null ? 1 : 0;
              goto label_11;
            case 10:
              int num6 = !flag ? 1949461020 : (num6 = 1532591528);
              int num7 = (int) num3 * -1595728096;
              num1 = num6 ^ num7;
              continue;
            case 11:
              if (this.SourceCategory != null)
              {
                num1 = (int) num3 * 1068373436 ^ 785543741;
                continue;
              }
              break;
            case 12:
              num1 = (int) num3 * -1020496063 ^ -682460540;
              continue;
            case 13:
              num1 = (int) num3 * 730632805 ^ -705052380;
              continue;
            default:
              goto label_23;
          }
          num4 = 0;
label_8:
          int num8;
          num1 = num8 = num4 != 0 ? -603336699 : (num8 = -1948710526);
          continue;
label_11:
          flag = num5 != 0;
          num1 = -812562189;
        }
label_23:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3247888920U));
      }
    }

    public bool ManualMessageSupported
    {
      get
      {
label_1:
        int num1 = 1541447277;
        bool messageSupported;
        while (true)
        {
          int num2 = 1432452557;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              messageSupported = this.manualMessageSupported;
              num1 = (int) num3 * -34713435 ^ -1653053327;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return messageSupported;
      }
      set
      {
label_1:
        int num1 = 1096966229;
        while (true)
        {
          int num2 = 974340198;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.manualMessageSupported = value;
              num1 = (int) num3 * -191790242 ^ 2011199966;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2281928619U));
      }
    }

    public bool RandomMessageSupported
    {
      get
      {
label_1:
        int num1 = 1216586283;
        bool messageSupported;
        while (true)
        {
          int num2 = 1974279762;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1538018901 ^ -1555511700;
              continue;
            case 1:
              messageSupported = this.randomMessageSupported;
              num1 = (int) num3 * -523947224 ^ -1753581118;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return messageSupported;
      }
      set
      {
        this.randomMessageSupported = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3760950140U));
label_1:
        int num1 = 106622321;
        while (true)
        {
          int num2 = 1237888270;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 723923144 ^ 1821274418;
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

    public bool IsValid
    {
      get
      {
label_1:
        int num1 = -675337166;
        bool isValid;
        while (true)
        {
          int num2 = -1372466641;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              isValid = this.isValid;
              num1 = (int) num3 * 1922248210 ^ -1561299709;
              continue;
            case 2:
              num1 = (int) num3 * -1833940808 ^ 609238660;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return isValid;
      }
      set
      {
        this.isValid = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1377307985U));
      }
    }

    public string MessageToSend
    {
      get
      {
        string messageToSend = this.messageToSend;
label_1:
        int num1 = -787965697;
        while (true)
        {
          int num2 = -57505348;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 606634277 ^ -453486841;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return messageToSend;
      }
      private set
      {
label_1:
        int num1 = 317533018;
        while (true)
        {
          int num2 = 1556880901;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * -1833320413 ^ -349535915;
              continue;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(298346818U));
              num1 = (int) num3 * -1825409990 ^ -60648800;
              continue;
            case 4:
              this.messageToSend = value;
              num1 = (int) num3 * -1697982402 ^ 1704354593;
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

    public string UserName
    {
      get
      {
label_1:
        int num1 = 1451095749;
        string userName;
        while (true)
        {
          int num2 = 1681438813;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              userName = this.userName;
              num1 = (int) num3 * 696633993 ^ -1482246311;
              continue;
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
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2587971764U));
      }
    }

    static ChatOptions()
    {
label_1:
      int num1 = -1694159202;
      while (true)
      {
        int num2 = -707698894;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ChatOptions.sourceMessages = new LockedObservableCollection<MessageContent>();
            num1 = (int) num3 * 30983645 ^ -119505768;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public ChatOptions()
    {
label_1:
      int num1 = 173952481;
      while (true)
      {
        int num2 = 1733575628;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.LoadSources();
            num1 = (int) num3 * 28840854 ^ 312372429;
            continue;
          case 1:
            num1 = (int) num3 * -182601342 ^ -2063485179;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 1709847222 ^ 454426575;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    public ChatOptions(string contentText)
    {
label_1:
      int num1 = -1055522768;
      while (true)
      {
        int num2 = -135119954;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -1719452507 ^ -1347763481;
            continue;
          case 1:
            num1 = (int) num3 * -1774727106 ^ -1124592623;
            continue;
          case 2:
            this.ManualMessage = contentText;
            num1 = (int) num3 * -1861499171 ^ 1371607848;
            continue;
          case 3:
            this.LoadSources();
            num1 = (int) num3 * 387749721 ^ -343650420;
            continue;
          case 4:
            num1 = (int) num3 * 1223453657 ^ -1473452645;
            continue;
          case 5:
            goto label_3;
          case 6:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private void LoadSourceContents()
    {
label_1:
      int num1 = -1832065350;
      List<MessageContent> messageContents;
      while (true)
      {
        int num2 = -731738571;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            ((Collection<MessageContent>) this.SourceContents).Clear();
            num1 = (int) num3 * -1436977676 ^ -132188630;
            continue;
          case 2:
            num1 = (int) num3 * -439365969 ^ -1730043034;
            continue;
          case 3:
            messageContents = this.Engine.GetMessageContents(this.SourceCategory);
            num1 = (int) num3 * -233784676 ^ -1584942809;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      using (List<MessageContent>.Enumerator enumerator = messageContents.GetEnumerator())
      {
label_12:
        int num2 = enumerator.MoveNext() ? -559973838 : (num2 = -1245459955);
        while (true)
        {
          int num3 = -731738571;
          uint num4;
          MessageContent current;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = (int) num4 * 1834226403 ^ -251033821;
              continue;
            case 1:
              current = enumerator.Current;
              num2 = -459126446;
              continue;
            case 2:
              goto label_12;
            case 3:
              num2 = -559973838;
              continue;
            case 5:
              ((Collection<MessageContent>) this.SourceContents).Add(current);
              num2 = (int) num4 * 2132000934 ^ -506780453;
              continue;
            default:
              goto label_15;
          }
        }
      }
label_15:
      this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2778315199U));
      this.SourceContent = (MessageContent) null;
    }

    internal void LoadSources()
    {
      this.SourceCategories = new LockedObservableCollection<MessageCategory>((Collection<MessageCategory>) this.Engine.MessageCategories, false);
label_1:
      int num1 = 1062481841;
      while (true)
      {
        int num2 = 1286281132;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.SourceContents = new LockedObservableCollection<MessageContent>();
            num1 = (int) num3 * 882507936 ^ 1010847660;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public override void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    {
label_1:
      int num1 = -1179928700;
      while (true)
      {
        int num2 = -1707019955;
        uint num3;
        bool flag;
        string str;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * 885128567 ^ 418723624;
            continue;
          case 1:
            str = ChatOptions.\u202C⁬‎‭⁫​‮‭⁪‮⁪⁫⁮⁬⁯‍‌‫‫‎‭‮⁪‎⁫​⁬⁯‎⁫⁮⁮‍‭⁭‭⁪⁯‍‮(propertyName);
            if (!ChatOptions.\u206F‌‌​⁪⁯‌⁫‪⁫⁫⁭‬‪‌⁭‍⁯‏​⁫‫⁮⁭‏​⁬‎‌‌⁫‎‫‎‬‌‫‮⁬⁬‮(str, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3232999885U)))
            {
              num1 = (int) num3 * 1039566210 ^ -1271226253;
              continue;
            }
            num4 = 0;
            break;
          case 2:
            goto label_3;
          case 3:
            int num5 = flag ? -336900526 : (num5 = -1871065779);
            int num6 = (int) num3 * -56318617;
            num1 = num5 ^ num6;
            continue;
          case 4:
            num4 = !ChatOptions.\u206F‌‌​⁪⁯‌⁫‪⁫⁫⁭‬‪‌⁭‍⁯‏​⁫‫⁮⁭‏​⁬‎‌‌⁫‎‫‎‬‌‫‮⁬⁬‮(str, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3296407615U)) ? 1 : 0;
            break;
          case 5:
            this.RaisePropertyChanged(ChatOptions.\u206B‮⁯‭⁫⁭​‏‭​‬‮‏‮‭‭⁯⁮‮‭‬​‎‏‏‎‍‍‌⁮⁭‍⁬⁯⁮⁯​‍‫‏‮(propertyName));
            num1 = -286200464;
            continue;
          case 6:
            goto label_1;
          case 7:
            this.CheckIfValid();
            num1 = (int) num3 * -732749760 ^ -76114339;
            continue;
          case 8:
            num1 = (int) num3 * 1949301724 ^ -1360238599;
            continue;
          default:
            goto label_14;
        }
        flag = num4 != 0;
        num1 = -601265631;
      }
label_14:
      return;
label_3:;
    }

    private void CheckIfValid()
    {
label_1:
      int num1 = -1316276345;
      while (true)
      {
        int num2 = -1646582128;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            this.IsValid = true;
            num1 = (int) num3 * -807808652 ^ -1856035341;
            continue;
          case 1:
            num1 = -807623848;
            continue;
          case 2:
            flag = !ChatOptions.\u200D⁫⁫‎‭‪⁪‮‎‭⁬‏⁮‏‎‮‎⁬⁯‭‬‪‌⁬⁭⁫‫‮‎‌‮⁪⁪‎‫‎‌‫⁯‮(this.GetMessage());
            num1 = (int) num3 * -1903607582 ^ -1928492496;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * 1738650595 ^ 1592550506;
            continue;
          case 5:
            this.IsValid = false;
            num1 = (int) num3 * -1563655107 ^ 846406015;
            continue;
          case 6:
            num1 = (int) num3 * -2054488896 ^ -729632739;
            continue;
          case 7:
            int num4 = !flag ? -977232155 : (num4 = -369628158);
            int num5 = (int) num3 * 1513371165;
            num1 = num4 ^ num5;
            continue;
          case 8:
            num1 = (int) num3 * -288575845 ^ 108118482;
            continue;
          case 9:
            num1 = (int) num3 * 1940948626 ^ 1847047339;
            continue;
          case 10:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    internal string GetMessage()
    {
      string str1 = (string) null;
label_1:
      int num1 = 1517581535;
      string str2;
      while (true)
      {
        int num2 = 1352531815;
        uint num3;
        bool flag1;
        MessageContent messageContent;
        bool flag2;
        Guid guid;
        bool flag3;
        int num4;
        int num5;
        int num6;
        int num7;
        switch ((num3 = (uint) (num1 ^ num2)) % 45U)
        {
          case 0:
            int num8 = !flag1 ? 314669981 : (num8 = 326970810);
            int num9 = (int) num3 * 1232329029;
            num1 = num8 ^ num9;
            continue;
          case 1:
            if (this.SourceCategory != null)
            {
              num1 = (int) num3 * 1587608148 ^ 1689211522;
              continue;
            }
            goto label_35;
          case 2:
            str1 = this.ManualMessage;
            num1 = (int) num3 * 1320460326 ^ -2108379218;
            continue;
          case 3:
            num1 = (int) num3 * 546880726 ^ -2034438221;
            continue;
          case 4:
            num1 = (int) num3 * 65073495 ^ -1271050858;
            continue;
          case 5:
            num1 = (int) num3 * -512116265 ^ 341151342;
            continue;
          case 6:
            messageContent = this.Engine.GetMessageContent(this.SourceCategory);
            int num10 = messageContent != null ? 482222480 : (num10 = 2002156633);
            int num11 = (int) num3 * 855351256;
            num1 = num10 ^ num11;
            continue;
          case 7:
            num1 = (int) num3 * -521125955 ^ -1481461060;
            continue;
          case 8:
            num1 = (int) num3 * 208107945 ^ -442972936;
            continue;
          case 9:
            num1 = (int) num3 * -1153093881 ^ 815338777;
            continue;
          case 10:
            num1 = (int) num3 * -525817994 ^ -2036490080;
            continue;
          case 11:
            int num12 = !flag2 ? -2023004269 : (num12 = -1656851920);
            int num13 = (int) num3 * 421015650;
            num1 = num12 ^ num13;
            continue;
          case 12:
            num5 = !this.RandomMessage ? 1 : 0;
            goto label_24;
          case 13:
            int num14;
            num1 = num14 = !this.SourceContent.ContentText.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3803686680U)) ? 1561375229 : (num14 = 1547128981);
            continue;
          case 14:
            num1 = (int) num3 * 1300575828 ^ -1039143137;
            continue;
          case 15:
            num1 = 1727810686;
            continue;
          case 16:
            num1 = (int) num3 * 373894798 ^ 1314705327;
            continue;
          case 17:
            str1 = this.SourceContent.ContentText;
            num1 = (int) num3 * -1568805290 ^ -1965813368;
            continue;
          case 18:
            str2 = str1;
            num1 = (int) num3 * -67254574 ^ 612490942;
            continue;
          case 19:
            int num15 = flag3 ? -39403758 : (num15 = -754305353);
            int num16 = (int) num3 * 1114947416;
            num1 = num15 ^ num16;
            continue;
          case 20:
            num1 = (int) num3 * 13454314 ^ 56752035;
            continue;
          case 21:
            num1 = (int) num3 * -1295630509 ^ -1685316741;
            continue;
          case 22:
            if (this.SourceCategory != null)
            {
              num1 = 1409421268;
              continue;
            }
            num6 = 0;
            goto label_50;
          case 23:
            num7 = this.SourceContent != null ? 1 : 0;
            break;
          case 24:
            if (this.SourceCategory.AutoGenerated)
            {
              num1 = (int) num3 * -201069565 ^ 1677033575;
              continue;
            }
            goto label_35;
          case 25:
            this.MessageToSend = str1;
            num1 = 619033470;
            continue;
          case 26:
            num1 = 59640689;
            continue;
          case 27:
            str1 = DateTime.Now.ToString();
            num1 = (int) num3 * 44376206 ^ -1850843929;
            continue;
          case 28:
            guid = Guid.NewGuid();
            num1 = (int) num3 * -2006886613 ^ -1961627502;
            continue;
          case 29:
            str1 = this.Engine.Settings.GetRandomText();
            num1 = (int) num3 * 2141251281 ^ -339893905;
            continue;
          case 30:
            if (this.RandomMessage)
            {
              num1 = 1863354165;
              continue;
            }
            goto label_35;
          case 31:
            if (this.SourceCategory == null)
            {
              num7 = 0;
              break;
            }
            num1 = 144561679;
            continue;
          case 33:
            str1 = messageContent.ContentText;
            num1 = (int) num3 * -2053152670 ^ -1255745751;
            continue;
          case 34:
            num1 = (int) num3 * -375891440 ^ -1388644938;
            continue;
          case 35:
            num1 = (int) num3 * 1469844981 ^ -106515939;
            continue;
          case 36:
            str1 = guid.ToString();
            num1 = (int) num3 * 1257053553 ^ 2060327645;
            continue;
          case 37:
            num4 = this.SourceContent != null ? 1 : 0;
            goto label_36;
          case 38:
            int num17;
            num1 = num17 = !this.SourceContent.ContentText.Equals(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2666157003U)) ? 1197493796 : (num17 = 861204570);
            continue;
          case 39:
            num1 = (int) num3 * -482653789 ^ 539352342;
            continue;
          case 40:
            int num18;
            num1 = num18 = this.SourceContent.ContentText.Equals(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2844023268U)) ? 1661687378 : (num18 = 1902665956);
            continue;
          case 41:
            if (ChatOptions.\u200D⁫⁫‎‭‪⁪‮‎‭⁬‏⁮‏‎‮‎⁬⁯‭‬‪‌⁬⁭⁫‫‮‎‌‮⁪⁪‎‫‎‌‫⁯‮(this.ManualMessage))
            {
              num5 = 0;
              goto label_24;
            }
            else
            {
              num1 = (int) num3 * -927882567 ^ 2049243977;
              continue;
            }
          case 42:
            num6 = this.RandomMessage ? 1 : 0;
            goto label_50;
          case 43:
            flag2 = ChatOptions.\u206F‌‌​⁪⁯‌⁫‪⁫⁫⁭‬‪‌⁭‍⁯‏​⁫‫⁮⁭‏​⁬‎‌‌⁫‎‫‎‬‌‫‮⁬⁬‮(this.SourceContent.ContentText, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1514605326U));
            num1 = (int) num3 * 132244850 ^ 29904097;
            continue;
          case 44:
            goto label_1;
          default:
            goto label_60;
        }
        flag1 = num7 != 0;
        num1 = 1749335292;
        continue;
label_24:
        int num19;
        num1 = num19 = num5 != 0 ? 1107371796 : (num19 = 470032568);
        continue;
label_35:
        num4 = 0;
label_36:
        flag3 = num4 != 0;
        num1 = 2006042772;
        continue;
label_50:
        int num20;
        num1 = num20 = num6 != 0 ? 1199046214 : (num20 = 1727810686);
      }
label_60:
      return str2;
    }

    static bool \u206F‌‌​⁪⁯‌⁫‪⁫⁫⁭‬‪‌⁭‍⁯‏​⁫‫⁮⁭‏​⁬‎‌‌⁫‎‫‎‬‌‫‮⁬⁬‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u200D⁫⁫‎‭‪⁪‮‎‭⁬‏⁮‏‎‮‎⁬⁯‭‬‪‌⁬⁭⁫‫‮‎‌‮⁪⁪‎‫‎‌‫⁯‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static string \u202C⁬‎‭⁫​‮‭⁪‮⁪⁫⁮⁬⁯‍‌‫‫‎‭‮⁪‎⁫​⁬⁯‎⁫⁮⁮‍‭⁭‭⁪⁯‍‮([In] string obj0)
    {
      return obj0.ToLower();
    }

    static PropertyChangedEventArgs \u206B‮⁯‭⁫⁭​‏‭​‬‮‏‮‭‭⁯⁮‮‭‬​‎‏‏‎‍‍‌⁮⁭‍⁬⁯⁮⁯​‍‫‏‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }
  }
}
