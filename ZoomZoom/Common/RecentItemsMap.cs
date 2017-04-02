// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.RecentItemsMap
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ZoomZoom.Common
{
  [TypeDescriptionProvider(typeof (RecentItemsMap.RecentItemsMapDescriptionProvider))]
  public class RecentItemsMap
  {
    private Dictionary<string, RecentItemsMap.RecentItems> _recents;

    internal Dictionary<string, RecentItemsMap.RecentItems> RecentItemsLists
    {
      get
      {
        if (this._recents != null)
          goto label_4;
label_1:
        int num1 = -394231265;
label_2:
        while (true)
        {
          int num2 = -1205350865;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this._recents = new Dictionary<string, RecentItemsMap.RecentItems>();
              num1 = (int) num3 * -511270838 ^ 1070621925;
              continue;
            case 2:
              goto label_4;
            case 4:
              num1 = (int) num3 * -1301794049 ^ -217903542;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        Dictionary<string, RecentItemsMap.RecentItems> recents;
        return recents;
label_4:
        recents = this._recents;
        num1 = -966108646;
        goto label_2;
      }
    }

    public int Count
    {
      get
      {
label_1:
        int num1 = 1755767855;
        int num2;
        while (true)
        {
          int num3 = 2040157360;
          uint num4;
          bool flag;
          switch ((num4 = (uint) (num1 ^ num3)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num4 * -683048271 ^ 496057371;
              continue;
            case 3:
              int num5 = flag ? -30016225 : (num5 = -1411558971);
              int num6 = (int) num4 * -2126822191;
              num1 = num5 ^ num6;
              continue;
            case 4:
              num2 = this._recents.Count;
              num1 = (int) num4 * 1093950121 ^ 396165301;
              continue;
            case 5:
              num1 = (int) num4 * -1580809387 ^ 1043706211;
              continue;
            case 6:
              num2 = 0;
              num1 = 1077743789;
              continue;
            case 7:
              flag = this._recents != null;
              num1 = (int) num4 * -1205314186 ^ -307315191;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return num2;
      }
    }

    public void AddSourceProperty(string propName, int itemCount = 10)
    {
      this.RecentItemsLists[propName] = new RecentItemsMap.RecentItems(propName, itemCount);
    }

    public void RemoveSourceProperty(string propName)
    {
label_1:
      int num1 = -326049460;
      while (true)
      {
        int num2 = -2030128794;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.RecentItemsLists.Remove(propName);
            num1 = (int) num3 * -1713876362 ^ -1059693148;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    internal void UpdateList(string sourcePropertyName, object newItem)
    {
      bool flag = this.RecentItemsLists.ContainsKey(sourcePropertyName);
label_1:
      int num1 = 252208223;
      while (true)
      {
        int num2 = 1742970402;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_3;
          case 1:
            this.RecentItemsLists[sourcePropertyName].AddItem(newItem);
            num1 = (int) num3 * 2045002224 ^ -331974151;
            continue;
          case 2:
            num1 = (int) num3 * 989276555 ^ -1152209864;
            continue;
          case 3:
            num1 = (int) num3 * -1202176873 ^ 1283073527;
            continue;
          case 4:
            num1 = (int) num3 * -1369048662 ^ -926436943;
            continue;
          case 5:
            int num4 = flag ? 1964777277 : (num4 = 1913931517);
            int num5 = (int) num3 * -606844404;
            num1 = num4 ^ num5;
            continue;
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

    public class RecentItems
    {
      public string SourceProperty { get; set; }

      public int MaxItems { get; set; }

      public List<object> Items { get; set; }

      public RecentItems(string sourceProperty, int maxCount = 10)
      {
        this.SourceProperty = sourceProperty;
        this.MaxItems = maxCount;
        this.Items = new List<object>();
      }

      internal void AddItem(object newItem)
      {
label_1:
        int num1 = -1865992206;
        while (true)
        {
          int num2 = -1766465618;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              num1 = (int) num3 * 592944199 ^ 1712107033;
              continue;
            case 1:
              num1 = (int) num3 * -2010243412 ^ -88134798;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = this.Items.Count > this.MaxItems ? -1420072667 : (num4 = -1623206052);
              int num5 = (int) num3 * -1632466209;
              num1 = num4 ^ num5;
              continue;
            case 4:
              this.Items.Add(newItem);
              num1 = (int) num3 * 1451487559 ^ 1797003553;
              continue;
            case 5:
              this.Items.RemoveAt(0);
              num1 = (int) num3 * 1257347671 ^ 141550932;
              continue;
            case 6:
              num1 = (int) num3 * 626483248 ^ -1768517629;
              continue;
            case 7:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }

      public override string ToString()
      {
label_1:
        int num1 = 1220863229;
        string str1;
        while (true)
        {
          int num2 = 1639554091;
          uint num3;
          bool flag1;
          string str2;
          int index;
          bool flag2;
          bool flag3;
          switch ((num3 = (uint) (num1 ^ num2)) % 18U)
          {
            case 0:
              goto label_1;
            case 1:
              str1 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(889979208U);
              num1 = (int) num3 * -234146349 ^ 2015910756;
              continue;
            case 2:
              flag1 = index < this.Items.Count;
              num1 = 258967290;
              continue;
            case 3:
              int num4 = !flag3 ? -560455030 : (num4 = -1527299035);
              int num5 = (int) num3 * 2019281722;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag2 = !RecentItemsMap.RecentItems.\u202E⁫⁫‭‪⁬‬⁬⁯⁭‬‮⁬⁬⁫‌‫‍‪‬‫‪‮‮‪‎⁯‬⁭⁪‭‭‎⁪‎‏​‮‪‌‮(str2);
              num1 = (int) num3 * -445664845 ^ -604631990;
              continue;
            case 5:
              num1 = 805721478;
              continue;
            case 6:
              num1 = (int) num3 * 1578249638 ^ 1233523038;
              continue;
            case 7:
              str2 = RecentItemsMap.RecentItems.\u202B⁬⁭⁯‏‪‌⁪‌⁭‪‮‌⁭⁫‮‎‮‫‪‌⁯‮⁫‮​‏⁭‎⁯‬‏⁫⁪⁪‬⁪‭‏‮(str2, RecentItemsMap.RecentItems.\u202C‪⁭⁪‫‬⁮​​⁭⁯⁫‫⁭‪⁮⁬⁬‌⁯⁪⁯⁫⁭‮‭⁬⁬‌‌‏⁭‪⁮⁬‬⁭‬⁫⁭‮(this.Items[index]));
              ++index;
              num1 = 1667959563;
              continue;
            case 8:
              str2 = "";
              index = 0;
              num1 = (int) num3 * -1144626265 ^ 2112781152;
              continue;
            case 10:
              num1 = 1038271562;
              continue;
            case 11:
              int num6 = !flag2 ? -67461858 : (num6 = -923236077);
              int num7 = (int) num3 * -955517428;
              num1 = num6 ^ num7;
              continue;
            case 12:
              str2 = RecentItemsMap.RecentItems.\u202B⁬⁭⁯‏‪‌⁪‌⁭‪‮‌⁭⁫‮‎‮‫‪‌⁯‮⁫‮​‏⁭‎⁯‬‏⁫⁪⁪‬⁪‭‏‮(str2, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2489243058U));
              num1 = (int) num3 * 1102496623 ^ -1883558300;
              continue;
            case 13:
              int num8 = !flag1 ? -1892849151 : (num8 = -347992499);
              int num9 = (int) num3 * -1523013894;
              num1 = num8 ^ num9;
              continue;
            case 14:
              str1 = str2;
              num1 = (int) num3 * -941953114 ^ 456145101;
              continue;
            case 15:
              num1 = (int) num3 * -493953566 ^ 826589833;
              continue;
            case 16:
              num1 = (int) num3 * 1969644561 ^ -468100368;
              continue;
            case 17:
              flag3 = index == 0;
              num1 = (int) num3 * 2038369030 ^ -1518069610;
              continue;
            default:
              goto label_19;
          }
        }
label_19:
        return str1;
      }

      static string \u202B⁬⁭⁯‏‪‌⁪‌⁭‪‮‌⁭⁫‮‎‮‫‪‌⁯‮⁫‮​‏⁭‎⁯‬‏⁫⁪⁪‬⁪‭‏‮([In] string obj0, [In] string obj1)
      {
        return obj0 + obj1;
      }

      static string \u202C‪⁭⁪‫‬⁮​​⁭⁯⁫‫⁭‪⁮⁬⁬‌⁯⁪⁯⁫⁭‮‭⁬⁬‌‌‏⁭‪⁮⁬‬⁭‬⁫⁭‮([In] object obj0)
      {
        return obj0.ToString();
      }

      static bool \u202E⁫⁫‭‪⁬‬⁬⁯⁭‬‮⁬⁬⁫‌‫‍‪‬‫‪‮‮‪‎⁯‬⁭⁪‭‭‎⁪‎‏​‮‪‌‮([In] string obj0)
      {
        return string.IsNullOrEmpty(obj0);
      }
    }

    private class RecentItemsMapDescriptionProvider : TypeDescriptionProvider
    {
      public RecentItemsMapDescriptionProvider()
        : this(RecentItemsMap.RecentItemsMapDescriptionProvider.\u202D⁯⁪⁯⁮⁮​​‪​⁮⁬‌⁫⁬‫‎‭​‏⁭‌‏‌​‫‮⁯⁮⁫​‬​‫‬⁯⁬​‮‮(RecentItemsMap.RecentItemsMapDescriptionProvider.\u202C‪⁬⁪⁭‏⁬⁮⁮⁯‌‎‌‍⁬⁫‎⁮‭⁯⁯‬⁯‌‮⁭​‌‌‫⁫⁮‌‬​‪‮​‮‮‮(__typeref (CommandMap))))
      {
        // ISSUE: type reference (out of statement scope)
      }

      public RecentItemsMapDescriptionProvider(TypeDescriptionProvider parent)
        : base(parent)
      {
      }

      public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
      {
label_1:
        int num1 = 346400605;
        ICustomTypeDescriptor customTypeDescriptor;
        while (true)
        {
          int num2 = 1738379484;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 50976119 ^ -273323266;
              continue;
            case 1:
              customTypeDescriptor = (ICustomTypeDescriptor) new RecentItemsMap.RecentItemsMapDescriptor(this.\u200C‏‮‍⁮‏‌⁫‬‏⁪‌⁮⁫‪‌‮‌⁭‌​‎⁬⁯‍‎‫‍‎‌‎⁭‎⁯‏⁪⁯⁫‭‭‮(objectType, instance), instance as RecentItemsMap);
              num1 = (int) num3 * -1004445709 ^ 1673940715;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return customTypeDescriptor;
      }

      static Type \u202C‪⁬⁪⁭‏⁬⁮⁮⁯‌‎‌‍⁬⁫‎⁮‭⁯⁯‬⁯‌‮⁭​‌‌‫⁫⁮‌‬​‪‮​‮‮‮([In] RuntimeTypeHandle obj0)
      {
        return Type.GetTypeFromHandle(obj0);
      }

      static TypeDescriptionProvider \u202D⁯⁪⁯⁮⁮​​‪​⁮⁬‌⁫⁬‫‎‭​‏⁭‌‏‌​‫‮⁯⁮⁫​‬​‫‬⁯⁬​‮‮([In] Type obj0)
      {
        return TypeDescriptor.GetProvider(obj0);
      }

      ICustomTypeDescriptor \u200C‏‮‍⁮‏‌⁫‬‏⁪‌⁮⁫‪‌‮‌⁭‌​‎⁬⁯‍‎‫‍‎‌‎⁭‎⁯‏⁪⁯⁫‭‭‮([In] Type obj0, [In] object obj1)
      {
        return base.GetTypeDescriptor(obj0, obj1);
      }
    }

    private class RecentItemsMapDescriptor : CustomTypeDescriptor
    {
      private RecentItemsMap _map;

      public RecentItemsMapDescriptor(ICustomTypeDescriptor descriptor, RecentItemsMap map)
        : base(descriptor)
      {
label_1:
        int num1 = 646156394;
        while (true)
        {
          int num2 = 2022827353;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -527644698 ^ 1900028260;
              continue;
            case 3:
              num1 = (int) num3 * 245693349 ^ -1212100456;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        this._map = map;
      }

      public override PropertyDescriptorCollection GetProperties()
      {
label_1:
        int num1 = 2138027296;
        PropertyDescriptor[] propertyDescriptorArray;
        int num2;
        while (true)
        {
          int num3 = 591157532;
          uint num4;
          switch ((num4 = (uint) (num1 ^ num3)) % 5U)
          {
            case 0:
              num2 = 0;
              num1 = (int) num4 * 2142857414 ^ -1644643506;
              continue;
            case 1:
              propertyDescriptorArray = new PropertyDescriptor[this._map.RecentItemsLists.Count];
              num1 = (int) num4 * -770347248 ^ -343506239;
              continue;
            case 2:
              goto label_1;
            case 4:
              num1 = (int) num4 * -786188381 ^ 1820455852;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        Dictionary<string, RecentItemsMap.RecentItems>.Enumerator enumerator = this._map.RecentItemsLists.GetEnumerator();
        try
        {
label_11:
          int num3 = enumerator.MoveNext() ? 995870983 : (num3 = 1810287261);
          while (true)
          {
            int num4 = 591157532;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 4U)
            {
              case 0:
                num3 = 995870983;
                continue;
              case 2:
                goto label_11;
              case 3:
                KeyValuePair<string, RecentItemsMap.RecentItems> current = enumerator.Current;
                propertyDescriptorArray[num2++] = (PropertyDescriptor) new RecentItemsMap.RecentItemsPropertyDescriptor(current);
                num3 = 124246958;
                continue;
              default:
                goto label_17;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
label_13:
          int num3 = 1667620263;
          while (true)
          {
            int num4 = 591157532;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 3U)
            {
              case 1:
                num3 = (int) num5 * -414338576 ^ -870091691;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_16;
            }
          }
label_16:;
        }
label_17:
        return RecentItemsMap.RecentItemsMapDescriptor.\u206B‎‎‬⁪⁭⁬⁯‏​​⁯‍‪‎‪‫⁭‍⁪‏‮‮‏‪‍‪‏‮⁫‫⁮⁮⁬⁮‌⁫⁫‫‬‮(propertyDescriptorArray);
      }

      static PropertyDescriptorCollection \u206B‎‎‬⁪⁭⁬⁯‏​​⁯‍‪‎‪‫⁭‍⁪‏‮‮‏‪‍‪‏‮⁫‫⁮⁮⁬⁮‌⁫⁫‫‬‮([In] PropertyDescriptor[] obj0)
      {
        return new PropertyDescriptorCollection(obj0);
      }
    }

    private class RecentItemsPropertyDescriptor : PropertyDescriptor
    {
      private RecentItemsMap.RecentItems _recentItemList;

      public override bool IsReadOnly
      {
        get
        {
label_1:
          int num1 = -4441864;
          bool flag;
          while (true)
          {
            int num2 = -784199782;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_1;
              case 2:
                flag = true;
                num1 = (int) num3 * -1837009529 ^ 1355939815;
                continue;
              case 3:
                num1 = (int) num3 * 1962693320 ^ 1376148419;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          return flag;
        }
      }

      public override Type ComponentType
      {
        get
        {
          throw RecentItemsMap.RecentItemsPropertyDescriptor.\u206D‏⁯‍​‌⁫‍‌⁭‎⁯‍‪‍‬⁯⁮⁫‌⁮⁭⁯‪‍‍⁯‪⁪⁫‍‏⁫‍⁬‪‭‫⁯⁫‮();
        }
      }

      public override Type PropertyType
      {
        get
        {
          Type type = RecentItemsMap.RecentItemsPropertyDescriptor.\u206E‭⁮‮⁫⁬‭​⁮⁯‭‪‏‪⁪‎‌‫‏⁮‍‍‭⁫​⁫‮⁪‮‎‌‪​⁮​⁯‌‪⁮‬‮(__typeref (RecentItemsMap.RecentItems));
label_1:
          int num1 = -621153597;
          while (true)
          {
            int num2 = -278577298;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_1;
              case 2:
                num1 = (int) num3 * 1508415085 ^ -884387575;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return type;
        }
      }

      public RecentItemsPropertyDescriptor(KeyValuePair<string, RecentItemsMap.RecentItems> recentItemsList)
        : base(recentItemsList.Key, (Attribute[]) null)
      {
label_1:
        int num1 = -207270003;
        while (true)
        {
          int num2 = -1353061990;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -2105233762 ^ 1082232639;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 562330009 ^ 75441949;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        this._recentItemList = recentItemsList.Value;
      }

      public override bool CanResetValue(object component)
      {
label_1:
        int num1 = -1593554747;
        bool flag;
        while (true)
        {
          int num2 = -2141755029;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              flag = false;
              num1 = (int) num3 * -239810944 ^ -1807073188;
              continue;
            case 3:
              num1 = (int) num3 * 1491298153 ^ 1549346909;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return flag;
      }

      public override object GetValue(object component)
      {
        RecentItemsMap recentItemsMap = component as RecentItemsMap;
        if (recentItemsMap == null)
          goto label_3;
label_1:
        int num1 = -904950852;
label_2:
        object obj;
        while (true)
        {
          int num2 = -1076182148;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 1615957229 ^ 2029655565;
              continue;
            case 2:
              num1 = (int) num3 * -1267314181 ^ 323772394;
              continue;
            case 4:
              goto label_7;
            case 5:
              obj = (object) RecentItemsMap.RecentItemsPropertyDescriptor.\u202E‎⁭⁬‭⁫‮⁮‮‭‪‏‏‏‬⁬⁯‎⁫⁯⁭‭‬‮⁬‫‪⁪​⁫⁮⁭⁬‮⁯⁫​⁫⁬‭‮((object) recentItemsMap.RecentItemsLists[RecentItemsMap.RecentItemsPropertyDescriptor.\u202C‍‫⁫⁫‍‎‌‏‮‭⁫‭​‍​⁫⁮‫⁭‫‮⁯‮‍⁯⁬⁫⁪⁪⁭‌‮​‬⁭‮‬​⁪‮((MemberDescriptor) this)]);
              num1 = (int) num3 * -1193758271 ^ 356714211;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_7:
        throw RecentItemsMap.RecentItemsPropertyDescriptor.\u202C‍‏‫​‬‫‏‎‭⁯⁮‎⁭‌⁬‎⁭‫‎‌‍⁬⁬‮‫⁮⁯⁮⁯‫⁯‬⁪‏‏⁭‭‪‭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2031831755U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2416756475U));
label_8:
        return obj;
label_3:
        num1 = -178741471;
        goto label_2;
      }

      public override void ResetValue(object component)
      {
        throw RecentItemsMap.RecentItemsPropertyDescriptor.\u206D‏⁯‍​‌⁫‍‌⁭‎⁯‍‪‍‬⁯⁮⁫‌⁮⁭⁯‪‍‍⁯‪⁪⁫‍‏⁫‍⁬‪‭‫⁯⁫‮();
      }

      public override void SetValue(object component, object value)
      {
        throw RecentItemsMap.RecentItemsPropertyDescriptor.\u206D‏⁯‍​‌⁫‍‌⁭‎⁯‍‪‍‬⁯⁮⁫‌⁮⁭⁯‪‍‍⁯‪⁪⁫‍‏⁫‍⁬‪‭‫⁯⁫‮();
      }

      public override bool ShouldSerializeValue(object component)
      {
label_1:
        int num1 = -1607303792;
        bool flag;
        while (true)
        {
          int num2 = -33045076;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              flag = false;
              num1 = (int) num3 * -2007644686 ^ -2111264859;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return flag;
      }

      static NotImplementedException \u206D‏⁯‍​‌⁫‍‌⁭‎⁯‍‪‍‬⁯⁮⁫‌⁮⁭⁯‪‍‍⁯‪⁪⁫‍‏⁫‍⁬‪‭‫⁯⁫‮()
      {
        return new NotImplementedException();
      }

      static string \u202C‍‫⁫⁫‍‎‌‏‮‭⁫‭​‍​⁫⁮‫⁭‫‮⁯‮‍⁯⁬⁫⁪⁪⁭‌‮​‬⁭‮‬​⁪‮([In] MemberDescriptor obj0)
      {
        return obj0.Name;
      }

      static string \u202E‎⁭⁬‭⁫‮⁮‮‭‪‏‏‏‬⁬⁯‎⁫⁯⁭‭‬‮⁬‫‪⁪​⁫⁮⁭⁬‮⁯⁫​⁫⁬‭‮([In] object obj0)
      {
        return obj0.ToString();
      }

      static ArgumentException \u202C‍‏‫​‬‫‏‎‭⁯⁮‎⁭‌⁬‎⁭‫‎‌‍⁬⁬‮‫⁮⁯⁮⁯‫⁯‬⁪‏‏⁭‭‪‭‮([In] string obj0, [In] string obj1)
      {
        return new ArgumentException(obj0, obj1);
      }

      static Type \u206E‭⁮‮⁫⁬‭​⁮⁯‭‪‏‪⁪‎‌‫‏⁮‍‍‭⁫​⁫‮⁪‮‎‌‪​⁮​⁯‌‪⁮‬‮([In] RuntimeTypeHandle obj0)
      {
        return Type.GetTypeFromHandle(obj0);
      }
    }
  }
}
