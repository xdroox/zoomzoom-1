// Decompiled with JetBrains decompiler
// Type: ZoomZoom.EnumBindingSourceExtension
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Markup;

namespace ZoomZoom
{
  public class EnumBindingSourceExtension : MarkupExtension
  {
    private Type _enumType;

    public Type EnumType
    {
      get
      {
label_1:
        int num1 = -1161533070;
        Type enumType;
        while (true)
        {
          int num2 = -1838354235;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1106379329 ^ 868837968;
              continue;
            case 3:
              enumType = this._enumType;
              num1 = (int) num3 * -1932605330 ^ 628920718;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return enumType;
      }
      set
      {
label_1:
        int num1 = -819106881;
        while (true)
        {
          int num2 = -1352503150;
          uint num3;
          bool flag1;
          Type type;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 12U)
          {
            case 0:
              num1 = (int) num3 * -1700888732 ^ -797197512;
              continue;
            case 1:
              flag2 = EnumBindingSourceExtension.\u206B⁪⁭⁪‏‍⁮‌‮‪‪⁬‎⁬⁭‍⁭‬⁪⁭‌⁯⁭‌‫‍‎​‮‫‌⁫‭⁬‬‮⁯‮‪‍‮(value, this._enumType);
              num1 = (int) num3 * 1248123557 ^ -194494825;
              continue;
            case 2:
              goto label_1;
            case 3:
              flag1 = !EnumBindingSourceExtension.\u206B⁯‪‭⁯⁪‎​‮⁫​‭⁬‬⁪⁮​‎⁪⁪‫⁮‪‫⁪‬⁯⁯‏‭‫⁪‮‪⁭‪‮​‮‬‮(type);
              num1 = (int) num3 * 1516057879 ^ 1699852453;
              continue;
            case 4:
              int num4 = !flag2 ? -1248589557 : (num4 = -1010433322);
              int num5 = (int) num3 * -1724876574;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_3;
            case 6:
              int num6 = !EnumBindingSourceExtension.\u206B⁪⁭⁪‏‍⁮‌‮‪‪⁬‎⁬⁭‍⁭‬⁪⁭‌⁯⁭‌‫‍‎​‮‫‌⁫‭⁬‬‮⁯‮‪‍‮((Type) null, value) ? 579216106 : (num6 = 964359661);
              int num7 = (int) num3 * -1330042672;
              num1 = num6 ^ num7;
              continue;
            case 7:
              goto label_10;
            case 8:
              this._enumType = value;
              num1 = -1177544061;
              continue;
            case 9:
              num1 = -1448097846;
              continue;
            case 10:
              int num8 = flag1 ? 2059734911 : (num8 = 1432652885);
              int num9 = (int) num3 * 628365923;
              num1 = num8 ^ num9;
              continue;
            case 11:
              type = EnumBindingSourceExtension.\u200B‭‬⁬⁫‌‭‫‪‏‍‮⁫‎‎‮⁫‫‍‭‬‪‌⁭⁪‫‫⁬⁬⁭‮‭‪‎‮‍​‭‭‎‮(value) ?? value;
              num1 = -701752195;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_3:
        return;
label_10:
        throw EnumBindingSourceExtension.\u206A⁯⁪‏⁫‫⁯‍⁬‎‍​⁮​⁯⁬‏⁫‏​⁪‏‏‌‍⁮‏​⁭‏⁬⁫⁭⁪⁪‪⁪‭‪⁮‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1060926172U));
      }
    }

    public EnumBindingSourceExtension()
    {
    }

    public EnumBindingSourceExtension(Type enumType)
    {
label_1:
      int num1 = -1755720646;
      while (true)
      {
        int num2 = -2111261444;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.EnumType = enumType;
            num1 = (int) num3 * -406045573 ^ -324827505;
            continue;
          case 2:
            num1 = (int) num3 * -1918371441 ^ -1027945088;
            continue;
          case 3:
            num1 = (int) num3 * 2077079620 ^ 291486966;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
      bool flag = EnumBindingSourceExtension.\u202B‫⁫‫‌⁯‌⁭⁯⁮⁫‮‏‪⁬​⁪‮⁬‏⁮‏‬‪‪‏‌⁬‌‌⁯‏‌⁪‍‌‪​⁭⁮‮((Type) null, this._enumType);
label_1:
      int num1 = -1983318071;
      object obj;
      while (true)
      {
        int num2 = -1284967747;
        uint num3;
        Type type;
        Array array1;
        Array array2;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 1:
            goto label_5;
          case 2:
            int num4 = !flag ? -664470116 : (num4 = -1904030346);
            int num5 = (int) num3 * 346576166;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_1;
          case 4:
            type = EnumBindingSourceExtension.\u200B‭‬⁬⁫‌‭‫‪‏‍‮⁫‎‎‮⁫‫‍‭‬‪‌⁭⁪‫‫⁬⁬⁭‮‭‪‎‮‍​‭‭‎‮(this._enumType) ?? this._enumType;
            num1 = -105043386;
            continue;
          case 5:
            array2 = EnumBindingSourceExtension.\u202C‭‪‍⁬⁫​‫⁫‫⁭‭‭‎⁫⁪‮‎‎‮⁬‍‍⁭​‭‬‌⁯‬‎⁫⁬‬⁪⁯‪⁭‬‫‮(type, EnumBindingSourceExtension.\u206A‏‭⁭‭‬‭‭‬⁫‏‭‫‮‪⁯⁫‏⁭⁬‌⁯‏​‏⁭⁮​‫⁯‏‮⁯‍⁮⁮‍⁫⁫‌‮(array1) + 1);
            num1 = -1293567540;
            continue;
          case 6:
            EnumBindingSourceExtension.\u206B⁯‫‬⁮‭‏‫‏⁮‌‌⁯‍‌⁮⁮‎‏‏‍‮‫⁯⁫‌⁯‪‎‎‍⁯⁯‌⁮⁮‭‬‪⁫‮(array1, array2, 1);
            num1 = (int) num3 * -2136414586 ^ 1345927099;
            continue;
          case 7:
            array1 = EnumBindingSourceExtension.\u206F‮⁫‪‭⁪‭⁬⁫⁯⁭​‭⁭‌‬‍⁪⁪‭‍⁫‮‫⁬‭⁬‮⁫‌‫⁪⁭‭⁮‎‌⁮⁭⁫‮(type);
            num1 = (int) num3 * 1711378132 ^ -1202429723;
            continue;
          case 8:
            obj = (object) array2;
            num1 = (int) num3 * 31673921 ^ -1975888970;
            continue;
          case 9:
            int num6 = EnumBindingSourceExtension.\u202B‫⁫‫‌⁯‌⁭⁯⁮⁫‮‏‪⁬​⁪‮⁬‏⁮‏‬‪‪‏‌⁬‌‌⁯‏‌⁪‍‌‪​⁭⁮‮(type, this._enumType) ? -1120996923 : (num6 = -11969288);
            int num7 = (int) num3 * 1354754976;
            num1 = num6 ^ num7;
            continue;
          case 10:
            obj = (object) array1;
            num1 = (int) num3 * 857102810 ^ 1405313190;
            continue;
          default:
            goto label_12;
        }
      }
label_5:
      throw EnumBindingSourceExtension.\u200F‏‍‮⁭⁬‫⁯⁫‌‫‭‏⁮‫‎‮‮‎‮‎‫‭‎⁬‏‎⁮⁪‪⁮⁪‪‏‌⁯⁭‌‎‭‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3068694724U));
label_12:
      return obj;
    }

    static bool \u206B⁪⁭⁪‏‍⁮‌‮‪‪⁬‎⁬⁭‍⁭‬⁪⁭‌⁯⁭‌‫‍‎​‮‫‌⁫‭⁬‬‮⁯‮‪‍‮([In] Type obj0, [In] Type obj1)
    {
      return Type.op_Inequality(obj0, obj1);
    }

    static Type \u200B‭‬⁬⁫‌‭‫‪‏‍‮⁫‎‎‮⁫‫‍‭‬‪‌⁭⁪‫‫⁬⁬⁭‮‭‪‎‮‍​‭‭‎‮([In] Type obj0)
    {
      return Nullable.GetUnderlyingType(obj0);
    }

    static bool \u206B⁯‪‭⁯⁪‎​‮⁫​‭⁬‬⁪⁮​‎⁪⁪‫⁮‪‫⁪‬⁯⁯‏‭‫⁪‮‪⁭‪‮​‮‬‮([In] Type obj0)
    {
      return obj0.IsEnum;
    }

    static ArgumentException \u206A⁯⁪‏⁫‫⁯‍⁬‎‍​⁮​⁯⁬‏⁫‏​⁪‏‏‌‍⁮‏​⁭‏⁬⁫⁭⁪⁪‪⁪‭‪⁮‮([In] string obj0)
    {
      return new ArgumentException(obj0);
    }

    static bool \u202B‫⁫‫‌⁯‌⁭⁯⁮⁫‮‏‪⁬​⁪‮⁬‏⁮‏‬‪‪‏‌⁬‌‌⁯‏‌⁪‍‌‪​⁭⁮‮([In] Type obj0, [In] Type obj1)
    {
      return Type.op_Equality(obj0, obj1);
    }

    static InvalidOperationException \u200F‏‍‮⁭⁬‫⁯⁫‌‫‭‏⁮‫‎‮‮‎‮‎‫‭‎⁬‏‎⁮⁪‪⁮⁪‪‏‌⁯⁭‌‎‭‮([In] string obj0)
    {
      return new InvalidOperationException(obj0);
    }

    static Array \u206F‮⁫‪‭⁪‭⁬⁫⁯⁭​‭⁭‌‬‍⁪⁪‭‍⁫‮‫⁬‭⁬‮⁫‌‫⁪⁭‭⁮‎‌⁮⁭⁫‮([In] Type obj0)
    {
      return Enum.GetValues(obj0);
    }

    static int \u206A‏‭⁭‭‬‭‭‬⁫‏‭‫‮‪⁯⁫‏⁭⁬‌⁯‏​‏⁭⁮​‫⁯‏‮⁯‍⁮⁮‍⁫⁫‌‮([In] Array obj0)
    {
      return obj0.Length;
    }

    static Array \u202C‭‪‍⁬⁫​‫⁫‫⁭‭‭‎⁫⁪‮‎‎‮⁬‍‍⁭​‭‬‌⁯‬‎⁫⁬‬⁪⁯‪⁭‬‫‮([In] Type obj0, [In] int obj1)
    {
      return Array.CreateInstance(obj0, obj1);
    }

    static void \u206B⁯‫‬⁮‭‏‫‏⁮‌‌⁯‍‌⁮⁮‎‏‏‍‮‫⁯⁫‌⁯‪‎‎‍⁯⁯‌⁮⁮‭‬‪⁫‮([In] Array obj0, [In] Array obj1, [In] int obj2)
    {
      obj0.CopyTo(obj1, obj2);
    }
  }
}
