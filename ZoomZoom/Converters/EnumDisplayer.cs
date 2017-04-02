// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.EnumDisplayer
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Data;
using System.Windows.Markup;

namespace ZoomZoom.Converters
{
  [ContentProperty("OverriddenDisplayEntries")]
  public class EnumDisplayer : IValueConverter
  {
    private Type type;
    private IDictionary displayValues;
    private IDictionary reverseValues;
    private List<EnumDisplayEntry> overriddenDisplayEntries;

    public Type Type
    {
      get
      {
label_1:
        int num1 = -256590484;
        Type type;
        while (true)
        {
          int num2 = -141212323;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              type = this.type;
              num1 = (int) num3 * -1000735339 ^ 437543856;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return type;
      }
      set
      {
label_1:
        int num1 = -429985914;
        while (true)
        {
          int num2 = -455425720;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 1:
              flag = !EnumDisplayer.\u202C⁭‫‭‍‫‎‍‏‎⁭‭‎⁮‬⁪‪‌‫‮‪‪‬‫‫‎‪⁫⁫‪‎‍‭‍⁯⁮‪⁭⁬‮(value);
              num1 = (int) num3 * 1517686155 ^ -1199700605;
              continue;
            case 2:
              int num4 = !flag ? -47182486 : (num4 = -1537451282);
              int num5 = (int) num3 * -1932959761;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_5:
        throw EnumDisplayer.\u200F⁫‍⁮‫‮‬⁭⁪⁫⁭‌⁯‏⁮⁪⁫‪‎⁫‭‎⁪‬‫‬⁪‭⁯⁬⁫‭‪⁫⁬‌​​‎‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2324006458U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2789128787U));
label_6:
        this.type = value;
      }
    }

    public List<EnumDisplayEntry> OverriddenDisplayEntries
    {
      get
      {
label_1:
        int num1 = -420233423;
        List<EnumDisplayEntry> overriddenDisplayEntries;
        while (true)
        {
          int num2 = -2019424722;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              this.overriddenDisplayEntries = new List<EnumDisplayEntry>();
              num1 = (int) num3 * 1392769345 ^ 1757046758;
              continue;
            case 2:
              overriddenDisplayEntries = this.overriddenDisplayEntries;
              num1 = -1364278324;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = this.overriddenDisplayEntries != null ? -45185653 : (num4 = -2082677629);
              int num5 = (int) num3 * -1018105566;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return overriddenDisplayEntries;
      }
    }

    public ReadOnlyCollection<string> DisplayNames
    {
      get
      {
        Type type = EnumDisplayer.\u206F‬‫⁪⁫⁬‭‍⁭‬‏⁫⁬​‌⁫⁪⁮⁯⁮⁮‭‪‏‌⁯⁬‏‫‪⁬⁬‪‭‪⁮‌‏‬‭‮(EnumDisplayer.\u206A‬‎⁬‎⁯‎⁬‭‏⁯⁫⁮‎⁭​‍‌⁯‪‏‎​⁪‪‫⁫⁬‏⁫⁪⁮‬‏⁬‬⁫⁮‮⁫‮(EnumDisplayer.\u202E⁮‮​⁮⁮‭‭‮‫‎⁯‌‏‭⁬‌‬⁬​‭‍‍​⁯‫⁬‭⁫‌‭⁬⁯‬⁯‭⁮‮‌⁮‮(__typeref (Dictionary<,>))), new Type[2]
        {
          EnumDisplayer.\u202E⁮‮​⁮⁮‭‭‮‫‎⁯‌‏‭⁬‌‬⁬​‭‍‍​⁯‫⁬‭⁫‌‭⁬⁯‬⁯‭⁮‮‌⁮‮(__typeref (string)),
          this.type
        });
label_1:
        int num1 = -1766939842;
        ReadOnlyCollection<string> readOnlyCollection;
        while (true)
        {
          int num2 = -629814061;
          uint num3;
          int index;
          FieldInfo[] fieldInfoArray1;
          string displayStringValue;
          object enumValue;
          FieldInfo[] fieldInfoArray2;
          FieldInfo fieldInfo;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 20U)
          {
            case 0:
              index = 0;
              num1 = (int) num3 * -84535858 ^ -1733991199;
              continue;
            case 1:
              EnumDisplayer.\u206D‌‎⁪⁪‏⁭‏‎‭⁮‭⁯⁮⁬⁪‏​‫‫‎‍‌⁭⁫‭‪⁮‭‎‫​⁯‭‭‎⁫⁮⁪‫‮(this.displayValues, enumValue, (object) displayStringValue);
              num1 = (int) num3 * 150974247 ^ -858756426;
              continue;
            case 2:
              displayStringValue = this.GetDisplayStringValue((DisplayStringAttribute[]) EnumDisplayer.\u200D‎‪‮⁯⁬‌⁭‫⁭​‭‭⁯‌⁬⁪‪‌‌⁬⁪⁫‎⁫‫​⁮⁬⁭‌⁮⁭‏⁪⁮‬‪‬⁯‮((MemberInfo) fieldInfo, EnumDisplayer.\u202E⁮‮​⁮⁮‭‭‮‫‎⁯‌‏‭⁬‌‬⁬​‭‍‍​⁯‫⁬‭⁫‌‭⁬⁯‬⁯‭⁮‮‌⁮‮(__typeref (DisplayStringAttribute)), false));
              num1 = (int) num3 * -955110749 ^ 1529080829;
              continue;
            case 3:
              int num4;
              num1 = num4 = displayStringValue != null ? -1756137934 : (num4 = -841512844);
              continue;
            case 4:
              num1 = (int) num3 * 353150262 ^ 1093713696;
              continue;
            case 5:
              readOnlyCollection = new List<string>((IEnumerable<string>) EnumDisplayer.\u206E​‮⁭‫‭⁪⁬‎‫‬‏‌‭‬‏‪‪⁯‏‭‬‮‭⁪‍‬‫‌‫​⁪‪⁯‌⁭‭‎⁭⁪‮(this.displayValues)).AsReadOnly();
              num1 = (int) num3 * 698924667 ^ 1915195859;
              continue;
            case 6:
              EnumDisplayer.\u206D‌‎⁪⁪‏⁭‏‎‭⁮‭⁯⁮⁬⁪‏​‫‫‎‍‌⁭⁫‭‪⁮‭‎‫​⁯‭‭‎⁫⁮⁪‫‮(this.reverseValues, (object) displayStringValue, enumValue);
              num1 = (int) num3 * -519546864 ^ -1725172141;
              continue;
            case 7:
              num1 = (int) num3 * 1539856472 ^ 1274069500;
              continue;
            case 8:
              fieldInfo = fieldInfoArray2[index];
              num1 = -1158498923;
              continue;
            case 9:
              displayStringValue = this.GetBackupDisplayStringValue(enumValue);
              num1 = (int) num3 * -1836703145 ^ 1477815979;
              continue;
            case 10:
              int num5;
              num1 = num5 = index >= fieldInfoArray2.Length ? -1529522554 : (num5 = -835126813);
              continue;
            case 11:
              int num6 = flag ? 1182198300 : (num6 = 616282114);
              int num7 = (int) num3 * 761381510;
              num1 = num6 ^ num7;
              continue;
            case 12:
              enumValue = EnumDisplayer.\u200F‏​‬‫⁫‍⁪‍‪‪‎⁭⁪​‪‍‬⁫‮‮‮⁫‫⁫‫⁬‌⁮‏‫‫⁫‪⁬‌⁫⁭‭‍‮(fieldInfo, (object) null);
              flag = displayStringValue == null;
              num1 = (int) num3 * 1069570981 ^ -258251308;
              continue;
            case 13:
              this.displayValues = (IDictionary) EnumDisplayer.\u200C‎‌⁮‌‏⁭‎⁫⁬⁪‫⁪⁪‫⁫⁭‏⁯‏‪⁯‮‌⁫‎‌‮‬⁬‌‪⁬‎​​⁪⁯‎‭‮(type);
              this.reverseValues = (IDictionary) EnumDisplayer.\u200C‎‌⁮‌‏⁭‎⁫⁬⁪‫⁪⁪‫⁫⁭‏⁯‏‪⁯‮‌⁫‎‌‮‬⁬‌‪⁬‎​​⁪⁯‎‭‮(EnumDisplayer.\u206F‬‫⁪⁫⁬‭‍⁭‬‏⁫⁬​‌⁫⁪⁮⁯⁮⁮‭‪‏‌⁯⁬‏‫‪⁬⁬‪‭‪⁮‌‏‬‭‮(EnumDisplayer.\u206A‬‎⁬‎⁯‎⁬‭‏⁯⁫⁮‎⁭​‍‌⁯‪‏‎​⁪‪‫⁫⁬‏⁫⁪⁮‬‏⁬‬⁫⁮‮⁫‮(EnumDisplayer.\u202E⁮‮​⁮⁮‭‭‮‫‎⁯‌‏‭⁬‌‬⁬​‭‍‍​⁯‫⁬‭⁫‌‭⁬⁯‬⁯‭⁮‮‌⁮‮(__typeref (Dictionary<,>))), new Type[2]
              {
                this.type,
                EnumDisplayer.\u202E⁮‮​⁮⁮‭‭‮‫‎⁯‌‏‭⁬‌‬⁬​‭‍‍​⁯‫⁬‭⁫‌‭⁬⁯‬⁯‭⁮‮‌⁮‮(__typeref (string))
              }));
              fieldInfoArray1 = EnumDisplayer.\u200F‭‭‪‬‍‌‮⁮⁯‌‮‪‎​‌​‎‭‮⁬⁪‪‪⁫‎‏‭⁭⁭⁭‍‪‫‫⁭⁪‮‬‪‮(this.type, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
              num1 = (int) num3 * -930172853 ^ 402011549;
              continue;
            case 14:
              ++index;
              num1 = (int) num3 * -82618210 ^ -820214243;
              continue;
            case 15:
              num1 = -1053380351;
              continue;
            case 16:
              goto label_1;
            case 17:
              fieldInfoArray2 = fieldInfoArray1;
              num1 = (int) num3 * 15422729 ^ 1457023650;
              continue;
            case 18:
              num1 = (int) num3 * 740616901 ^ 830314603;
              continue;
            default:
              goto label_21;
          }
        }
label_21:
        return readOnlyCollection;
      }
    }

    public EnumDisplayer()
    {
    }

    public EnumDisplayer(Type type)
    {
label_1:
      int num1 = -843021679;
      while (true)
      {
        int num2 = -640930994;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1547507967 ^ -746865915;
            continue;
          case 3:
            this.Type = type;
            num1 = (int) num3 * -385645670 ^ -1662527273;
            continue;
          case 4:
            num1 = (int) num3 * 676602978 ^ -1523380942;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private string GetDisplayStringValue(DisplayStringAttribute[] a)
    {
label_1:
      int num1 = -1721120555;
      string str;
      while (true)
      {
        int num2 = -1336548971;
        uint num3;
        DisplayStringAttribute displayStringAttribute;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            goto label_1;
          case 2:
            str = EnumDisplayer.\u206C⁮‬‎⁫⁭‎​⁪⁭‏⁯‌‫​⁫⁯‬‌⁮‬‭‍⁯‏⁮‏⁪⁮‏​⁯‬‍⁪⁪‭‮‬‏‮(EnumDisplayer.\u200D⁪‍‏⁮‫‬‪‬⁫‭‫⁯⁬⁮⁭‏‬‌‌⁭‮​⁯‮⁭‭‮‫​⁬‫⁪‍‫‫‌⁫⁮⁫‮(this.type), displayStringAttribute.ResourceKey);
            num1 = (int) num3 * -1457779634 ^ -1807636205;
            continue;
          case 3:
            num1 = (int) num3 * -132182014 ^ -1214905406;
            continue;
          case 4:
            str = (string) null;
            num1 = (int) num3 * 673234991 ^ 862930176;
            continue;
          case 5:
            displayStringAttribute = a[0];
            num1 = -1771017488;
            continue;
          case 6:
            int num5 = !flag ? 248242922 : (num5 = 1122784719);
            int num6 = (int) num3 * -1896933807;
            num1 = num5 ^ num6;
            continue;
          case 7:
            num4 = a.Length == 0 ? 1 : 0;
            break;
          case 8:
            if (a != null)
            {
              num1 = (int) num3 * -1824535374 ^ 1958839502;
              continue;
            }
            num4 = 1;
            break;
          case 9:
            int num7 = EnumDisplayer.\u206A⁭⁬⁬‮‍‎⁬⁮⁬‏‫⁬‍‏‏‫‏‫⁮‌‏​‭⁫‏‪⁫‌‏‌‏⁯⁪⁮‎‍‫​‮‮(displayStringAttribute.ResourceKey) ? 548424918 : (num7 = 1371863827);
            int num8 = (int) num3 * 836190504;
            num1 = num7 ^ num8;
            continue;
          case 10:
            num1 = (int) num3 * 2134580141 ^ 909862854;
            continue;
          case 11:
            str = displayStringAttribute.Value;
            num1 = -1939915942;
            continue;
          default:
            goto label_16;
        }
        flag = num4 != 0;
        num1 = -1797439413;
      }
label_16:
      return str;
    }

    private string GetBackupDisplayStringValue(object enumValue)
    {
label_1:
      int num1 = 1562312516;
      string str;
      while (true)
      {
        int num2 = 2031066544;
        uint num3;
        EnumDisplayEntry enumDisplayEntry;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            int num5 = !enumDisplayEntry.ExcludeFromDisplay ? -253445085 : (num5 = -1701430289);
            int num6 = (int) num3 * 1766991599;
            num1 = num5 ^ num6;
            continue;
          case 1:
            num1 = (int) num3 * -560647738 ^ -2057305710;
            continue;
          case 2:
            str = EnumDisplayer.\u202B‭⁯⁯‪⁮‫‭⁮‫‍‮⁯⁪‪⁭⁪‫‎‌⁮⁯‫⁭⁫‪⁫​⁪‎⁯​⁮‍‎‫⁮⁬⁬‬‮(this.type, enumValue);
            num1 = 859546488;
            continue;
          case 3:
            num1 = (int) num3 * -2050232411 ^ 809915170;
            continue;
          case 4:
            num1 = (int) num3 * 1348263302 ^ -1218646489;
            continue;
          case 5:
            str = enumDisplayEntry.DisplayString;
            num1 = 1216362591;
            continue;
          case 6:
            num4 = this.overriddenDisplayEntries.Count > 0 ? 1 : 0;
            break;
          case 7:
            int num7 = flag2 ? 281541071 : (num7 = 792874195);
            int num8 = (int) num3 * -301459149;
            num1 = num7 ^ num8;
            continue;
          case 8:
            int num9 = !flag1 ? -736608832 : (num9 = -651898937);
            int num10 = (int) num3 * -1271100938;
            num1 = num9 ^ num10;
            continue;
          case 10:
            flag2 = enumDisplayEntry != null;
            num1 = (int) num3 * 1857218749 ^ -1710311804;
            continue;
          case 11:
            num1 = 1956520040;
            continue;
          case 12:
            if (this.overriddenDisplayEntries != null)
            {
              num1 = (int) num3 * 384365123 ^ -1491816761;
              continue;
            }
            num4 = 0;
            break;
          case 13:
            goto label_1;
          case 14:
            num1 = (int) num3 * -2090641236 ^ 1553922600;
            continue;
          case 15:
            str = (string) null;
            num1 = (int) num3 * -7608983 ^ -1038558287;
            continue;
          case 16:
            enumDisplayEntry = this.overriddenDisplayEntries.Find((Predicate<EnumDisplayEntry>) (entry =>
            {
label_1:
              int num2 = -1643299051;
              bool flag;
              while (true)
              {
                int num3 = -1533895432;
                uint num4;
                object obj;
                switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                {
                  case 0:
                    // ISSUE: reference to a compiler-generated method
                    flag = EnumDisplayer.\u003C\u003Ec__DisplayClass14_0.\u206A‪‬‍⁯‪‍‬⁮⁮⁪‬⁭‎⁬‮‌‮​‭‭‮‌‏‍‎‫⁬⁯​‭​​⁭⁫‮‪⁯​‫‮(enumValue, obj);
                    num2 = (int) num4 * 1472086931 ^ -1747827382;
                    continue;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    obj = EnumDisplayer.\u003C\u003Ec__DisplayClass14_0.\u202A‏​⁯​‌‬⁬⁭‮‫‌‏‍⁪‏⁯‏‭⁮‌‪⁭‪‫⁫​‫⁪‭⁭‫‬‌⁮‪⁭⁪‎⁪‮(this.type, entry.EnumValue);
                    num2 = (int) num4 * -161051631 ^ -919322247;
                    continue;
                  case 3:
                    goto label_1;
                  default:
                    goto label_5;
                }
              }
label_5:
              return flag;
            }));
            num1 = (int) num3 * 1926275068 ^ -2010827727;
            continue;
          default:
            goto label_21;
        }
        flag1 = num4 != 0;
        num1 = 1953296780;
      }
label_21:
      return str;
    }

    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 1308622546;
      object obj;
      while (true)
      {
        int num2 = 790427120;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            obj = EnumDisplayer.\u206C⁬‫‫​⁪‪⁫‏‬​​‪⁮‫‪‫‮⁪⁫⁮⁫⁬‎‫‬⁫⁬⁬‮‎⁮‏‎‎⁮‮‏‪‫‮(this.displayValues, value);
            num1 = (int) num3 * -252997162 ^ 1256075847;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return obj;
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
label_1:
      int num1 = 1262588566;
      object obj;
      while (true)
      {
        int num2 = 1417419787;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            obj = EnumDisplayer.\u206C⁬‫‫​⁪‪⁫‏‬​​‪⁮‫‪‫‮⁪⁫⁮⁫⁬‎‫‬⁫⁬⁬‮‎⁮‏‎‎⁮‮‏‪‫‮(this.reverseValues, value);
            num1 = (int) num3 * -879907201 ^ 384742849;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return obj;
    }

    static bool \u202C⁭‫‭‍‫‎‍‏‎⁭‭‎⁮‬⁪‪‌‫‮‪‪‬‫‫‎‪⁫⁫‪‎‍‭‍⁯⁮‪⁭⁬‮([In] Type obj0)
    {
      return obj0.IsEnum;
    }

    static ArgumentException \u200F⁫‍⁮‫‮‬⁭⁪⁫⁭‌⁯‏⁮⁪⁫‪‎⁫‭‎⁪‬‫‬⁪‭⁯⁬⁫‭‪⁫⁬‌​​‎‮([In] string obj0, [In] string obj1)
    {
      return new ArgumentException(obj0, obj1);
    }

    static Type \u202E⁮‮​⁮⁮‭‭‮‫‎⁯‌‏‭⁬‌‬⁬​‭‍‍​⁯‫⁬‭⁫‌‭⁬⁯‬⁯‭⁮‮‌⁮‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static Type \u206A‬‎⁬‎⁯‎⁬‭‏⁯⁫⁮‎⁭​‍‌⁯‪‏‎​⁪‪‫⁫⁬‏⁫⁪⁮‬‏⁬‬⁫⁮‮⁫‮([In] Type obj0)
    {
      return obj0.GetGenericTypeDefinition();
    }

    static Type \u206F‬‫⁪⁫⁬‭‍⁭‬‏⁫⁬​‌⁫⁪⁮⁯⁮⁮‭‪‏‌⁯⁬‏‫‪⁬⁬‪‭‪⁮‌‏‬‭‮([In] Type obj0, [In] Type[] obj1)
    {
      return obj0.MakeGenericType(obj1);
    }

    static object \u200C‎‌⁮‌‏⁭‎⁫⁬⁪‫⁪⁪‫⁫⁭‏⁯‏‪⁯‮‌⁫‎‌‮‬⁬‌‪⁬‎​​⁪⁯‎‭‮([In] Type obj0)
    {
      return Activator.CreateInstance(obj0);
    }

    static FieldInfo[] \u200F‭‭‪‬‍‌‮⁮⁯‌‮‪‎​‌​‎‭‮⁬⁪‪‪⁫‎‏‭⁭⁭⁭‍‪‫‫⁭⁪‮‬‪‮([In] Type obj0, [In] System.Reflection.BindingFlags obj1)
    {
      return obj0.GetFields(obj1);
    }

    static object[] \u200D‎‪‮⁯⁬‌⁭‫⁭​‭‭⁯‌⁬⁪‪‌‌⁬⁪⁫‎⁫‫​⁮⁬⁭‌⁮⁭‏⁪⁮‬‪‬⁯‮([In] MemberInfo obj0, [In] Type obj1, [In] bool obj2)
    {
      return obj0.GetCustomAttributes(obj1, obj2);
    }

    static object \u200F‏​‬‫⁫‍⁪‍‪‪‎⁭⁪​‪‍‬⁫‮‮‮⁫‫⁫‫⁬‌⁮‏‫‫⁫‪⁬‌⁫⁭‭‍‮([In] FieldInfo obj0, [In] object obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u206D‌‎⁪⁪‏⁭‏‎‭⁮‭⁯⁮⁬⁪‏​‫‫‎‍‌⁭⁫‭‪⁮‭‎‫​⁯‭‭‎⁫⁮⁪‫‮([In] IDictionary obj0, [In] object obj1, [In] object obj2)
    {
      obj0.Add(obj1, obj2);
    }

    static ICollection \u206E​‮⁭‫‭⁪⁬‎‫‬‏‌‭‬‏‪‪⁯‏‭‬‮‭⁪‍‬‫‌‫​⁪‪⁯‌⁭‭‎⁭⁪‮([In] IDictionary obj0)
    {
      return obj0.Values;
    }

    static bool \u206A⁭⁬⁬‮‍‎⁬⁮⁬‏‫⁬‍‏‏‫‏‫⁮‌‏​‭⁫‏‪⁫‌‏‌‏⁯⁪⁮‎‍‫​‮‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static ResourceManager \u200D⁪‍‏⁮‫‬‪‬⁫‭‫⁯⁬⁮⁭‏‬‌‌⁭‮​⁯‮⁭‭‮‫​⁬‫⁪‍‫‫‌⁫⁮⁫‮([In] Type obj0)
    {
      return new ResourceManager(obj0);
    }

    static string \u206C⁮‬‎⁫⁭‎​⁪⁭‏⁯‌‫​⁫⁯‬‌⁮‬‭‍⁯‏⁮‏⁪⁮‏​⁯‬‍⁪⁪‭‮‬‏‮([In] ResourceManager obj0, [In] string obj1)
    {
      return obj0.GetString(obj1);
    }

    static string \u202B‭⁯⁯‪⁮‫‭⁮‫‍‮⁯⁪‪⁭⁪‫‎‌⁮⁯‫⁭⁫‪⁫​⁪‎⁯​⁮‍‎‫⁮⁬⁬‬‮([In] Type obj0, [In] object obj1)
    {
      return Enum.GetName(obj0, obj1);
    }

    static object \u206C⁬‫‫​⁪‪⁫‏‬​​‪⁮‫‪‫‮⁪⁫⁮⁫⁬‎‫‬⁫⁬⁬‮‎⁮‏‎‎⁮‮‏‪‫‮([In] IDictionary obj0, [In] object obj1)
    {
      return obj0[obj1];
    }
  }
}
