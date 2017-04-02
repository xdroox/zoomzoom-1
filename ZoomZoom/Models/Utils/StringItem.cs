// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Utils.StringItem
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Utils
{
  public class StringItem : CoreObject
  {
    private string itemValue;

    public string Value
    {
      get
      {
label_1:
        int num1 = 23372394;
        string itemValue;
        while (true)
        {
          int num2 = 2030476481;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              itemValue = this.itemValue;
              num1 = (int) num3 * 1097196362 ^ 1879310139;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return itemValue;
      }
      set
      {
        this.itemValue = value;
label_1:
        int num1 = 861723499;
        while (true)
        {
          int num2 = 1492932435;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1945278088U));
              num1 = (int) num3 * 451850784 ^ 2113989786;
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

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 1397256729;
        TraceType traceType;
        while (true)
        {
          int num2 = 1088173356;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              traceType = TraceType.Other;
              num1 = (int) num3 * 1449073945 ^ -1365804538;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1114027570 ^ 258730122;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public StringItem(string stringValue)
    {
label_1:
      int num1 = 1387698983;
      while (true)
      {
        int num2 = 1451102996;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            this.Value = stringValue;
            num1 = (int) num3 * -1716059896 ^ 905390433;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -844796053 ^ -81181659;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = 600824568;
      bool flag1;
      while (true)
      {
        int num2 = 240288630;
        uint num3;
        string str;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            int num4 = !flag2 ? -287410203 : (num4 = -2016159165);
            int num5 = (int) num3 * -339362571;
            num1 = num4 ^ num5;
            continue;
          case 2:
            flag1 = StringItem.\u202E‌‌‏⁭⁬⁫‏‮‬​‫⁮⁭​‎​‎‬‍⁫‭⁪​⁫‮‬⁪‫⁭‍‍⁮⁪‫⁫‍⁮‪‭‮(str, this.Value);
            num1 = (int) num3 * -1097418783 ^ -1815035939;
            continue;
          case 3:
            goto label_1;
          case 4:
            str = obj as string;
            num1 = (int) num3 * -967689105 ^ 982224055;
            continue;
          case 5:
            flag2 = str != null;
            num1 = (int) num3 * -1540194982 ^ -1337865104;
            continue;
          case 6:
            flag1 = this.\u202D​⁭‮‏⁭⁬‪‌⁮‌⁬⁮‎‍⁫‍‮‏‍‬‫⁬‪​‮​​‬‮‮⁯‪‌‫​‭⁫​⁯‮(obj);
            num1 = 1974287027;
            continue;
          case 7:
            num1 = (int) num3 * 1436764386 ^ -687598588;
            continue;
          case 8:
            num1 = (int) num3 * 1383467109 ^ 1028910364;
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
label_1:
      int num1 = 2028198114;
      int num2;
      while (true)
      {
        int num3 = 533184389;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num4 * 222075438 ^ -299214788;
            continue;
          case 3:
            num2 = StringItem.\u206A⁯‪‬​​⁫‮⁭⁫​⁯⁪​⁭‬‭⁮‪‪‭‍⁮‬‬⁯‭⁭‎⁫⁪‎‫‪‭‬‎‎‬⁪‮((object) this.Value);
            num1 = (int) num4 * 729708456 ^ -2068117205;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return num2;
    }

    static bool \u202E‌‌‏⁭⁬⁫‏‮‬​‫⁮⁭​‎​‎‬‍⁫‭⁪​⁫‮‬⁪‫⁭‍‍⁮⁪‫⁫‍⁮‪‭‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    bool \u202D​⁭‮‏⁭⁬‪‌⁮‌⁬⁮‎‍⁫‍‮‏‍‬‫⁬‪​‮​​‬‮‮⁯‪‌‫​‭⁫​⁯‮([In] object obj0)
    {
      return base.Equals(obj0);
    }

    static int \u206A⁯‪‬​​⁫‮⁭⁫​⁯⁪​⁭‬‭⁮‪‪‭‍⁮‬‬⁯‭⁭‎⁫⁪‎‫‪‭‬‎‎‬⁪‮([In] object obj0)
    {
      return obj0.GetHashCode();
    }
  }
}
