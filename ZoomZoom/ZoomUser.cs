// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomUser
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using System.Xml.Serialization;
using ZoomZoom.Models.Data;

namespace ZoomZoom
{
  [XmlType(AnonymousType = true)]
  [XmlRoot("zoomUser")]
  [DesignerCategory("code")]
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [Serializable]
  public class ZoomUser : DataObject
  {
    private static readonly object _locker = ZoomUser.\u200D⁬‎‭‪⁮⁮⁯⁯‎‫‭⁮‬‫‍⁮‮‏‮‍‌⁭‭⁮‌‭⁫‏⁭‏‬‎‌‪‫⁭⁭‭‭‮();
    protected internal ILog Log = ZoomUser.\u202D‌‌‬‫⁬‏‬‫‫‪‮⁬⁫‍⁮‎‏‌⁮‌‏‭‫⁪‫‮‍⁭⁪‍⁬‪‍​‭‌⁪⁫⁫‮(ZoomUser.\u206A‍⁪‏‏⁭⁪​⁬‫⁫‏⁫‮‬‌‫⁪‬‭‭​‭⁪‪⁪⁫‮⁭‍⁪‭‎‏⁬⁮⁯‫‫‫‮((MemberInfo) ZoomUser.\u202D‭‭‪⁫‍‎⁯⁪‍‍⁯‏‏‮‎⁫​‪‌‫​‌​‌⁫⁮‌⁯⁪‎⁭⁪‎​‮⁮‮‬‏‮()));
    private long _uri = 0;
    private string _userGUID = "";
    private string _userName = "";
    private DateTime _dateCreated = DateTime.MinValue;
    private DateTime _dateModified = DateTime.MinValue;
    private DateTime _dateDeleted = DateTime.MinValue;
    private DateTime _lastSeen = DateTime.MinValue;
    private bool _isFriend = false;
    private bool _isBlocked = false;
    private bool _isAlias = false;
    private long _primaryUserUri = 0;
    private AliasFlag _aliasFlags = AliasFlag.None;
    private List<string> _userAliases = new List<string>();
    private bool _isImpersonated = false;
    private string _userNotes;
    private bool _bNeverChatted;

    [XmlAttribute]
    public string UserGUID
    {
      get
      {
        string userGuid = this._userGUID;
label_1:
        int num1 = -1906521163;
        while (true)
        {
          int num2 = -1327002994;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 728427337 ^ 1732231081;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return userGuid;
      }
      set
      {
label_1:
        int num1 = 1120516845;
        while (true)
        {
          int num2 = 58691204;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this._userGUID = value;
              num1 = (int) num3 * -1186234748 ^ -265986669;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2324113766U));
              num1 = (int) num3 * 1684490434 ^ 427698450;
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

    [XmlAttribute]
    public string UserName
    {
      get
      {
        string userName = this._userName;
label_1:
        int num1 = -690912329;
        while (true)
        {
          int num2 = -342379966;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 927938552 ^ -114881433;
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
label_1:
        int num1 = 848060112;
        while (true)
        {
          int num2 = 1792792057;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this._userName = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1959159945U));
              num1 = (int) num3 * 1834399334 ^ -1365477860;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1523492954 ^ -1507170461;
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

    [XmlAttribute(DataType = "date")]
    public DateTime DateCreated
    {
      get
      {
label_1:
        int num1 = 1859809615;
        DateTime dateCreated;
        while (true)
        {
          int num2 = 421719609;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              dateCreated = this._dateCreated;
              num1 = (int) num3 * 1016425824 ^ 1255739238;
              continue;
            case 3:
              num1 = (int) num3 * 676518630 ^ 680113350;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return dateCreated;
      }
      set
      {
        this._dateCreated = value;
label_1:
        int num1 = 764252348;
        while (true)
        {
          int num2 = 377089505;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3159846649U));
              num1 = (int) num3 * -270751391 ^ -1107564806;
              continue;
            case 2:
              num1 = (int) num3 * -1181279012 ^ -510327067;
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

    [XmlAttribute(DataType = "date")]
    public DateTime DateModified
    {
      get
      {
label_1:
        int num1 = -386661466;
        DateTime dateModified;
        while (true)
        {
          int num2 = -1341524140;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1581991121 ^ -2133758983;
              continue;
            case 2:
              dateModified = this._dateModified;
              num1 = (int) num3 * 329955149 ^ 1781211499;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return dateModified;
      }
      set
      {
        this._dateModified = value;
label_1:
        int num1 = 288462466;
        while (true)
        {
          int num2 = 2143870939;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2430253183U));
              num1 = (int) num3 * 1153575201 ^ 293024045;
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

    [XmlAttribute(DataType = "date")]
    public DateTime DateLastSeen
    {
      get
      {
        return this._lastSeen;
      }
      set
      {
        this._lastSeen = value;
label_1:
        int num1 = 889805417;
        while (true)
        {
          int num2 = 596224824;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1090840697U));
              num1 = (int) num3 * 230129565 ^ 757669541;
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

    [XmlAttribute(DataType = "date")]
    public DateTime DateDeleted
    {
      get
      {
label_1:
        int num1 = 883096129;
        DateTime dateDeleted;
        while (true)
        {
          int num2 = 2126909606;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 565866016 ^ 401999999;
              continue;
            case 2:
              goto label_1;
            case 3:
              dateDeleted = this._dateDeleted;
              num1 = (int) num3 * 742901620 ^ 105389570;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return dateDeleted;
      }
      set
      {
label_1:
        int num1 = -1167257843;
        while (true)
        {
          int num2 = -601765030;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this._dateDeleted = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1325097287U));
              num1 = (int) num3 * -1880827126 ^ -807318510;
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

    [XmlAttribute]
    public bool IsFriend
    {
      get
      {
label_1:
        int num1 = -1025675669;
        bool isFriend;
        while (true)
        {
          int num2 = -479507340;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              isFriend = this._isFriend;
              num1 = (int) num3 * -296129020 ^ -11799840;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return isFriend;
      }
      set
      {
label_1:
        int num1 = -2033205527;
        while (true)
        {
          int num2 = -991377343;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this._isFriend = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3675647128U));
              num1 = (int) num3 * -2007035845 ^ 1064544947;
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

    [XmlAttribute]
    public bool IsBlocked
    {
      get
      {
label_1:
        int num1 = -1479201511;
        bool isBlocked;
        while (true)
        {
          int num2 = -1341328124;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1111503509 ^ 2094447322;
              continue;
            case 1:
              isBlocked = this._isBlocked;
              num1 = (int) num3 * -1079279892 ^ -145966560;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return isBlocked;
      }
      set
      {
        this._isBlocked = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2334470157U));
      }
    }

    [XmlAttribute]
    public bool IsAlias
    {
      get
      {
        bool isAlias = this._isAlias;
label_1:
        int num1 = 148663514;
        while (true)
        {
          int num2 = 547427139;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1447156337 ^ -1735170667;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return isAlias;
      }
      set
      {
        this._isAlias = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3005331448U));
      }
    }

    public long PrimaryUserUri
    {
      get
      {
label_1:
        int num1 = 1407726039;
        long primaryUserUri;
        while (true)
        {
          int num2 = 1162156668;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              primaryUserUri = this._primaryUserUri;
              num1 = (int) num3 * -592574470 ^ -1954790119;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return primaryUserUri;
      }
      set
      {
        this._primaryUserUri = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3195815422U));
label_1:
        int num1 = -910535305;
        while (true)
        {
          int num2 = -138854930;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 361449932 ^ 1340115005;
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

    public AliasFlag AliasFlags
    {
      get
      {
        AliasFlag aliasFlags = this._aliasFlags;
label_1:
        int num1 = 1269386862;
        while (true)
        {
          int num2 = 554119959;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -2117733498 ^ -2098761457;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return aliasFlags;
      }
      set
      {
        this._aliasFlags = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3075470524U));
      }
    }

    public string Notes
    {
      get
      {
        return this._userNotes;
      }
      set
      {
        this._userNotes = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1201688509U));
      }
    }

    [XmlArrayItem("signature", typeof (string), Form = XmlSchemaForm.Unqualified)]
    [XmlArray(Form = XmlSchemaForm.Unqualified)]
    public List<string> Aliases
    {
      get
      {
        List<string> userAliases = this._userAliases;
label_1:
        int num1 = 1037046555;
        while (true)
        {
          int num2 = 517579152;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1822809503 ^ 1211810552;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return userAliases;
      }
      set
      {
label_1:
        int num1 = 920460002;
        while (true)
        {
          int num2 = 1217374644;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1175099713U));
              num1 = (int) num3 * 1396542266 ^ 711481205;
              continue;
            case 2:
              this._userAliases = value;
              num1 = (int) num3 * 550607893 ^ -697183625;
              continue;
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

    public bool NeverChatted
    {
      get
      {
label_1:
        int num1 = 1596321808;
        bool bNeverChatted;
        while (true)
        {
          int num2 = 452279937;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              bNeverChatted = this._bNeverChatted;
              num1 = (int) num3 * -968040126 ^ -2046648592;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return bNeverChatted;
      }
      set
      {
        this._bNeverChatted = value;
      }
    }

    public bool IsImpersonated
    {
      get
      {
label_1:
        int num1 = -922763040;
        bool isImpersonated;
        while (true)
        {
          int num2 = -1952550494;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1064098465 ^ -1257426954;
              continue;
            case 2:
              isImpersonated = this._isImpersonated;
              num1 = (int) num3 * 755763434 ^ 119017595;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return isImpersonated;
      }
      set
      {
        this._isImpersonated = value;
      }
    }

    public override ObjectDataTable ZoomZoomTable
    {
      get
      {
label_1:
        int num1 = -350492267;
        ObjectDataTable objectDataTable;
        while (true)
        {
          int num2 = -1086962075;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              objectDataTable = ObjectDataTable.Users;
              num1 = (int) num3 * 1720122578 ^ 1473026750;
              continue;
            case 2:
              goto label_1;
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
label_1:
        int num1 = 214022636;
        TraceType traceType;
        while (true)
        {
          int num2 = 2087013739;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.User;
              num1 = (int) num3 * -1014469212 ^ 1112683202;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    private ZoomUser()
    {
label_1:
      int num1 = -515680196;
      while (true)
      {
        int num2 = -72078613;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -591984543 ^ 2076846968;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public ZoomUser(string sFriendlyName)
    {
label_1:
      int num1 = 632916812;
      while (true)
      {
        int num2 = 431634756;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1581505588 ^ -1460444506;
            continue;
          case 2:
            num1 = (int) num3 * 1028256512 ^ 1751168367;
            continue;
          case 3:
            this.DateModified = DateTime.Now;
            num1 = (int) num3 * 980874060 ^ -1820736438;
            continue;
          case 4:
            this.UserName = sFriendlyName;
            num1 = (int) num3 * -1656760238 ^ 775546513;
            continue;
          case 5:
            this.DateCreated = DateTime.Now;
            num1 = (int) num3 * -1866515211 ^ -1129758298;
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

    public ZoomUser(SQLiteDataReader cReader)
    {
      this.LoadDataObject(cReader);
    }

    public bool BlockUser()
    {
label_1:
      int num1 = 2007843790;
      bool flag1;
      while (true)
      {
        int num2 = 1257811929;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            this._isFriend = false;
            num1 = (int) num3 * 1804273585 ^ 1426418674;
            continue;
          case 1:
            num1 = (int) num3 * -1126139734 ^ -464552509;
            continue;
          case 2:
            int num4 = !this._isFriend ? 2120181338 : (num4 = 266026291);
            int num5 = (int) num3 * 1423967914;
            num1 = num4 ^ num5;
            continue;
          case 3:
            flag2 = false;
            num1 = (int) num3 * 961613191 ^ -1735257554;
            continue;
          case 4:
            flag1 = flag2;
            num1 = 1148855653;
            continue;
          case 5:
            goto label_1;
          case 6:
            int num6 = !this._isBlocked ? -720162817 : (num6 = -1679790451);
            int num7 = (int) num3 * -525634550;
            num1 = num6 ^ num7;
            continue;
          case 7:
            this._isBlocked = true;
            num1 = 45599748;
            continue;
          case 9:
            flag2 = true;
            num1 = (int) num3 * -610061164 ^ -802422152;
            continue;
          case 10:
            num1 = (int) num3 * 191833302 ^ 1889018349;
            continue;
          case 11:
            num1 = (int) num3 * -267664240 ^ 1017475950;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return flag1;
    }

    private string FormatSQL(string stringToFormat)
    {
      if (stringToFormat == null)
        goto label_5;
label_1:
      int num1 = 1593042229;
label_2:
      string str;
      while (true)
      {
        int num2 = 1617150709;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_5;
          case 1:
            str = ZoomUser.\u200F‏‪‬⁯⁭‫⁫⁭⁬⁫‫⁪⁬‏‏⁮‪‮‍‍⁭⁫‫⁯‎​‫⁭‌‌⁫⁬‬⁮‮‪⁮​‍‮(stringToFormat, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1022940561U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1669876505U));
            num1 = (int) num3 * -271965940 ^ 2116517811;
            continue;
          case 2:
            num1 = (int) num3 * 1115375498 ^ 2080716308;
            continue;
          case 3:
            goto label_1;
          case 5:
            num1 = (int) num3 * -1471150977 ^ -349070998;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return str;
label_5:
      str = string.Empty;
      num1 = 481798366;
      goto label_2;
    }

    public override Dictionary<string, object> GetDataDictionary()
    {
label_1:
      int num1 = 1427954028;
      Dictionary<string, object> dictionary1;
      while (true)
      {
        int num2 = 1261642744;
        uint num3;
        Dictionary<string, object> dictionary2;
        switch ((num3 = (uint) (num1 ^ num2)) % 25U)
        {
          case 0:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2182723723U), (object) this.DateCreated);
            num1 = (int) num3 * -1452713012 ^ -1115444954;
            continue;
          case 1:
            num1 = (int) num3 * -290524518 ^ 1280049286;
            continue;
          case 2:
            num1 = (int) num3 * -835658784 ^ 1235359708;
            continue;
          case 3:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1051676875U), (object) this.PrimaryUserUri);
            num1 = (int) num3 * -1323330191 ^ -1970288774;
            continue;
          case 4:
            num1 = (int) num3 * -538537297 ^ -335039148;
            continue;
          case 5:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(415143333U), (object) this.IsImpersonated);
            num1 = (int) num3 * 96503078 ^ 444976935;
            continue;
          case 6:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(46290154U), (object) this.AliasFlags);
            num1 = (int) num3 * 594847609 ^ 144853498;
            continue;
          case 7:
            num1 = (int) num3 * 512374059 ^ -1275552504;
            continue;
          case 8:
            dictionary1 = dictionary2;
            num1 = (int) num3 * 589539005 ^ -1194064811;
            continue;
          case 9:
            num1 = (int) num3 * -406433275 ^ 2108239071;
            continue;
          case 10:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3545937118U), (object) this.IsAlias);
            num1 = (int) num3 * 1808639056 ^ -1003475355;
            continue;
          case 11:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(749377801U), (object) this.IsFriend);
            num1 = (int) num3 * -395752269 ^ -1736993755;
            continue;
          case 12:
            goto label_1;
          case 14:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3075063878U), (object) this.DateLastSeen);
            num1 = (int) num3 * -1574268198 ^ 1648113206;
            continue;
          case 15:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3546223336U), (object) this.Notes);
            num1 = (int) num3 * 1036941363 ^ -1464046847;
            continue;
          case 16:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2893256781U), (object) this.UserName);
            num1 = (int) num3 * 2040984893 ^ -249241416;
            continue;
          case 17:
            num1 = (int) num3 * -1104845490 ^ 638282602;
            continue;
          case 18:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3980213974U), (object) this.IsBlocked);
            num1 = (int) num3 * -1453986106 ^ -2029283277;
            continue;
          case 19:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2223083214U), (object) this.DateModified);
            num1 = (int) num3 * 609373706 ^ -1232922342;
            continue;
          case 20:
            dictionary2 = new Dictionary<string, object>();
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U), (object) this.Uri);
            num1 = (int) num3 * 1129789863 ^ 908934788;
            continue;
          case 21:
            num1 = (int) num3 * 1873559064 ^ -1768678888;
            continue;
          case 22:
            dictionary2.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4263926115U), (object) this.NeverChatted);
            num1 = (int) num3 * -587918343 ^ 1504145065;
            continue;
          case 23:
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2704224687U), (object) this.UserGUID);
            num1 = (int) num3 * 846644902 ^ 724673239;
            continue;
          case 24:
            num1 = (int) num3 * -164315069 ^ -1597549859;
            continue;
          default:
            goto label_26;
        }
      }
label_26:
      return dictionary1;
    }

    public override bool LoadDataObject(SQLiteDataReader cReader)
    {
      bool flag = false;
      try
      {
label_2:
        int num1 = -760480002;
        while (true)
        {
          int num2 = -1203421360;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 19U)
          {
            case 0:
              num1 = (int) num3 * -573500016 ^ 1418491728;
              continue;
            case 1:
              this.NeverChatted = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3681909733U)) == 1;
              num1 = -2062922295;
              continue;
            case 2:
              this.AliasFlags = (AliasFlag) cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2539370780U));
              num1 = (int) num3 * -900324107 ^ 1070319058;
              continue;
            case 4:
              num1 = (int) num3 * -1697162192 ^ -129974975;
              continue;
            case 5:
              this.Uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U));
              num1 = (int) num3 * 98363610 ^ -1560911793;
              continue;
            case 6:
              this.IsImpersonated = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3469609132U)) == 1;
              num1 = -907835638;
              continue;
            case 7:
              this.UserName = cReader.GetFieldValueString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1373956289U));
              num1 = (int) num3 * 1467867913 ^ 382824231;
              continue;
            case 8:
              goto label_2;
            case 9:
              this.IsAlias = cReader.GetFieldValueInt(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3545937118U)) == 1;
              num1 = -112825481;
              continue;
            case 10:
              this.UserGUID = cReader.GetFieldValueString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3711160230U));
              num1 = (int) num3 * -1466318865 ^ -1142404109;
              continue;
            case 11:
              this.PrimaryUserUri = cReader.GetFieldValueLong(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1576745987U));
              num1 = (int) num3 * 746699731 ^ -1894535900;
              continue;
            case 12:
              this.DateLastSeen = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1089986642U));
              num1 = (int) num3 * 124630226 ^ -1817557248;
              continue;
            case 13:
              num1 = (int) num3 * -248994151 ^ 505370757;
              continue;
            case 14:
              this.DateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3335598589U));
              num1 = (int) num3 * -797226566 ^ 457035597;
              continue;
            case 15:
              this.IsBlocked = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3447326922U)) == 1;
              num1 = -2125595971;
              continue;
            case 16:
              this.IsFriend = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4255455709U)) == 1;
              num1 = -6378920;
              continue;
            case 17:
              this.DateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3689749305U));
              num1 = (int) num3 * 1463847255 ^ -1648905841;
              continue;
            case 18:
              num1 = (int) num3 * 1305444088 ^ -233252528;
              continue;
            default:
              goto label_26;
          }
        }
      }
      catch (Exception ex)
      {
label_22:
        int num1 = -328538091;
        while (true)
        {
          int num2 = -1203421360;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_22;
            case 1:
              num1 = (int) num3 * -1791811367 ^ -883837367;
              continue;
            default:
              goto label_25;
          }
        }
label_25:
        ZoomUser.\u206A‎⁮‍‮‫‮‍⁬‮‪⁮‬⁪‏‍⁯‫⁭⁬⁪‫‬‭⁯⁯‎⁯‫⁮⁭‪⁭‍‏‏‮‭⁮‫‮(CoreObject.log, (object) ex);
      }
label_26:
      return flag;
    }

    static MethodBase \u202D‭‭‪⁫‍‎⁯⁪‍‍⁯‏‏‮‎⁫​‪‌‫​‌​‌⁫⁮‌⁯⁪‎⁭⁪‎​‮⁮‮‬‏‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206A‍⁪‏‏⁭⁪​⁬‫⁫‏⁫‮‬‌‫⁪‬‭‭​‭⁪‪⁪⁫‮⁭‍⁪‭‎‏⁬⁮⁯‫‫‫‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202D‌‌‬‫⁬‏‬‫‫‪‮⁬⁫‍⁮‎‏‌⁮‌‏‭‫⁪‫‮‍⁭⁪‍⁬‪‍​‭‌⁪⁫⁫‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static string \u200F‏‪‬⁯⁭‫⁫⁭⁬⁫‫⁪⁬‏‏⁮‪‮‍‍⁭⁫‫⁯‎​‫⁭‌‌⁫⁬‬⁮‮‪⁮​‍‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    static void \u206A‎⁮‍‮‫‮‍⁬‮‪⁮‬⁪‏‍⁯‫⁭⁬⁪‫‬‭⁯⁯‎⁯‫⁮⁭‪⁭‍‏‏‮‭⁮‫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static object \u200D⁬‎‭‪⁮⁮⁯⁯‎‫‭⁮‬‫‍⁮‮‏‮‍‌⁭‭⁮‌‭⁫‏⁭‏‬‎‌‪‫⁭⁭‭‭‮()
    {
      return new object();
    }
  }
}
