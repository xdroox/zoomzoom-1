// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomZoomDataColumn
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom
{
  public class ZoomZoomDataColumn
  {
    private object defaultValue = (object) null;
    private string fieldDotNetType = string.Empty;
    private string fieldNameDatabase = string.Empty;
    private string fieldNameCaption = string.Empty;
    private bool readOnly = false;
    private bool isUnique = false;
    private bool isBrowsable = true;

    public string FieldNameDatabase
    {
      get
      {
        string fieldNameDatabase = this.fieldNameDatabase;
label_1:
        int num1 = 636195953;
        while (true)
        {
          int num2 = 2005633860;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1656495389 ^ -374507925;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return fieldNameDatabase;
      }
      set
      {
        this.fieldNameDatabase = value;
      }
    }

    public string FieldNameCaption
    {
      get
      {
        string fieldNameCaption = this.fieldNameCaption;
label_1:
        int num1 = -1079843001;
        while (true)
        {
          int num2 = -1188708452;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -928325592 ^ 446005107;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return fieldNameCaption;
      }
      set
      {
        this.fieldNameCaption = value;
      }
    }

    public string FieldDotNetType
    {
      get
      {
        string fieldDotNetType = this.fieldDotNetType;
label_1:
        int num1 = 1911976444;
        while (true)
        {
          int num2 = 320636221;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1242241309 ^ -71655949;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return fieldDotNetType;
      }
      set
      {
        this.fieldDotNetType = value;
      }
    }

    public bool IsReadonly
    {
      get
      {
label_1:
        int num1 = 894915526;
        bool flag;
        while (true)
        {
          int num2 = 414659760;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 841865695 ^ 1429409368;
              continue;
            case 2:
              flag = this.readOnly;
              num1 = (int) num3 * -1095726693 ^ -1774927189;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return flag;
      }
      set
      {
label_1:
        int num1 = 138199237;
        while (true)
        {
          int num2 = 1901965953;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.readOnly = value;
              num1 = (int) num3 * -331252178 ^ 1468106379;
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

    public bool IsUnique
    {
      get
      {
        bool isUnique = this.isUnique;
label_1:
        int num1 = -1624881057;
        while (true)
        {
          int num2 = -1027731620;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -472042531 ^ -1198933740;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return isUnique;
      }
      set
      {
        this.isUnique = value;
      }
    }

    public object DefaultValue
    {
      get
      {
label_1:
        int num1 = 1656386703;
        object defaultValue;
        while (true)
        {
          int num2 = 1253043344;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1441743558 ^ -1241705983;
              continue;
            case 2:
              goto label_1;
            case 3:
              defaultValue = this.defaultValue;
              num1 = (int) num3 * 906475290 ^ 1408767950;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return defaultValue;
      }
      set
      {
        this.defaultValue = value;
      }
    }

    public bool IsBrowsable
    {
      get
      {
label_1:
        int num1 = -1835272042;
        bool isBrowsable;
        while (true)
        {
          int num2 = -1120432903;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1294118204 ^ 1804802788;
              continue;
            case 3:
              isBrowsable = this.isBrowsable;
              num1 = (int) num3 * -745753134 ^ -1993986947;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return isBrowsable;
      }
      set
      {
label_1:
        int num1 = -305815791;
        while (true)
        {
          int num2 = -754576623;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.isBrowsable = value;
              num1 = (int) num3 * -1489386612 ^ -603043128;
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

    public ZoomZoomDataColumn(string columnName, string columnCaption, string columnDotNetType, bool uniqueValues, bool isreadonly, object oDefaultValue = null, bool browsable = true)
    {
      this.FieldNameDatabase = columnName;
      this.FieldNameCaption = columnCaption;
      this.FieldDotNetType = columnDotNetType;
      this.isUnique = uniqueValues;
      this.readOnly = isreadonly;
      this.defaultValue = oDefaultValue;
      this.isBrowsable = browsable;
    }

    internal static string GetSQLDateFormat(DateTime? dateTime)
    {
      string str1 = "";
label_1:
      int num1 = 15311511;
      string str2;
      while (true)
      {
        int num2 = 289593066;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -959228805 ^ -157547308;
            continue;
          case 1:
            str2 = str1;
            num1 = 478932290;
            continue;
          case 2:
            goto label_1;
          case 3:
            str1 = dateTime.Value.ToString(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2322711128U));
            num1 = (int) num3 * -1303162118 ^ -1320096504;
            continue;
          case 4:
            num1 = (int) num3 * -683594718 ^ 875988179;
            continue;
          case 5:
            int num4 = dateTime.HasValue ? -1972493423 : (num4 = -1708030377);
            int num5 = (int) num3 * -812962164;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = (int) num3 * -353200144 ^ 854747401;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return str2;
    }
  }
}
