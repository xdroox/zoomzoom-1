// Decompiled with JetBrains decompiler
// Type: ZoomZoom.GridUtils
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;

namespace ZoomZoom
{
  public class GridUtils
  {
    public static readonly DependencyProperty RowDefinitionsProperty = GridUtils.\u200E‬⁯⁭⁫‪‪⁫‍‍⁬‬​⁭⁮‬⁬⁪⁫‌⁬‎⁭‬⁫⁫‪⁮⁫‌⁫‮​⁫‭‪‍⁬‫‬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2123449789U), GridUtils.\u206E‫‫‏‭​⁪‍⁪⁫‬‎‌‪‏⁫‏‪​‫‌‬‌‬‎⁮‫‮‭⁯‍‍‌‍⁫⁫⁮‍‪‮(__typeref (string)), GridUtils.\u206E‫‫‏‭​⁪‍⁪⁫‬‎‌‪‏⁫‏‪​‫‌‬‌‬‎⁮‫‮‭⁯‍‍‌‍⁫⁫⁮‍‪‮(__typeref (GridUtils)), GridUtils.\u200F‬‮⁪⁬⁯⁯‮‎‫‎‍‌⁯⁯‏‮⁭‏‫‭‭‭‌‍‍⁮‪‮‭⁬​‫⁮‮‮‭⁫‭‬‮((object) "", new PropertyChangedCallback(GridUtils.OnRowDefinitionsPropertyChanged)));
    public static readonly DependencyProperty ColumnDefinitionsProperty;

    static GridUtils()
    {
label_1:
      int num1 = -1932241870;
      while (true)
      {
        int num2 = -1096849796;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: type reference
            // ISSUE: type reference
            GridUtils.ColumnDefinitionsProperty = GridUtils.\u200E‬⁯⁭⁫‪‪⁫‍‍⁬‬​⁭⁮‬⁬⁪⁫‌⁬‎⁭‬⁫⁫‪⁮⁫‌⁫‮​⁫‭‪‍⁬‫‬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1033347448U), GridUtils.\u206E‫‫‏‭​⁪‍⁪⁫‬‎‌‪‏⁫‏‪​‫‌‬‌‬‎⁮‫‮‭⁯‍‍‌‍⁫⁫⁮‍‪‮(__typeref (string)), GridUtils.\u206E‫‫‏‭​⁪‍⁪⁫‬‎‌‪‏⁫‏‪​‫‌‬‌‬‎⁮‫‮‭⁯‍‍‌‍⁫⁫⁮‍‪‮(__typeref (GridUtils)), GridUtils.\u200F‬‮⁪⁬⁯⁯‮‎‫‎‍‌⁯⁯‏‮⁭‏‫‭‭‭‌‍‍⁮‪‮‭⁬​‫⁮‮‮‭⁫‭‬‮((object) "", new PropertyChangedCallback(GridUtils.OnColumnDefinitionsPropertyChanged)));
            num1 = (int) num3 * 1564835429 ^ 1493440676;
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

    public static string GetRowDefinitions(DependencyObject d)
    {
label_1:
      int num1 = -106469347;
      string str;
      while (true)
      {
        int num2 = -1697440185;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * 469240798 ^ -1674000987;
            continue;
          case 2:
            str = (string) GridUtils.\u202A‫⁮‎⁯⁭​‌‍⁪⁪‫‭​⁪‎⁯⁯‎‭‬⁮⁬‎‫‮⁭⁫​‍‮⁪‏⁯‍‫‏‏‍⁭‮(d, GridUtils.RowDefinitionsProperty);
            num1 = (int) num3 * 1097246363 ^ 2004579172;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    public static void SetRowDefinitions(DependencyObject d, string value)
    {
      GridUtils.\u202E‏⁫‍‫‭‪‎⁯⁫⁮‮​‌⁭⁫‎‭‬⁬‏⁪‮‍⁪‌‌‮⁫‏‍⁫‍⁫‬‌⁮‮‪‬‮(d, GridUtils.RowDefinitionsProperty, (object) value);
label_1:
      int num1 = -1204952495;
      while (true)
      {
        int num2 = -278948394;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1811029534 ^ -2072010997;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private static void OnRowDefinitionsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      Grid grid = d as Grid;
      GridUtils.\u202E‪⁪⁮‎‏‭‏​‌⁬⁪‬⁬‪⁯‌‪‍‌‌⁪⁬​‬⁫⁬⁯‌‌⁯⁯‫‬⁪⁪‪‏‍⁫‮(GridUtils.\u206C⁫​‭⁭⁭‍⁪⁫⁫‏‭‪‪‎‭‌‫⁭⁬‍‫‍⁯⁮⁪‮‪⁮‪⁯‪⁯⁫⁯⁯‮⁬‎‍‮(grid));
label_1:
      int num1 = 1347820847;
      while (true)
      {
        int num2 = 541808663;
        uint num3;
        int index;
        string[] strArray;
        string length;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 0:
            num1 = (int) num3 * -1743007090 ^ -728412313;
            continue;
          case 1:
            num1 = (int) num3 * 683278318 ^ 268335525;
            continue;
          case 2:
            goto label_1;
          case 3:
            length = strArray[index];
            num1 = 834546768;
            continue;
          case 4:
            num1 = (int) num3 * -56249893 ^ -1975995722;
            continue;
          case 5:
            int num4 = length.Trim() == "" ? -1269391221 : (num4 = -274359439);
            int num5 = (int) num3 * 1606088683;
            num1 = num4 ^ num5;
            continue;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num3 * 1822803389 ^ 516345383;
            continue;
          case 8:
            int num6;
            num1 = num6 = index < strArray.Length ? 471198356 : (num6 = 999537581);
            continue;
          case 9:
            num1 = (int) num3 * -424943027 ^ 368876932;
            continue;
          case 10:
            strArray = (e.NewValue as string).Split(',');
            num1 = (int) num3 * 1499367205 ^ -272240192;
            continue;
          case 11:
            num1 = (int) num3 * 1893579581 ^ 353399150;
            continue;
          case 12:
            ++index;
            num1 = (int) num3 * 118115432 ^ 1872792099;
            continue;
          case 13:
            grid.RowDefinitions.Add(new RowDefinition()
            {
              Height = GridUtils.ParseLength(length)
            });
            num1 = 229495901;
            continue;
          case 14:
            num1 = (int) num3 * -1382759309 ^ 1042006042;
            continue;
          case 15:
            grid.RowDefinitions.Add(new RowDefinition());
            num1 = (int) num3 * 1822109523 ^ -535122458;
            continue;
          case 16:
            num1 = (int) num3 * 1993861213 ^ 221823657;
            continue;
          case 17:
            index = 0;
            num1 = (int) num3 * -1638213249 ^ -240599675;
            continue;
          case 18:
            num1 = 647478403;
            continue;
          case 19:
            num1 = (int) num3 * -2119101322 ^ -1953456316;
            continue;
          default:
            goto label_22;
        }
      }
label_22:
      return;
label_3:;
    }

    public static string GetColumnDefinitions(DependencyObject d)
    {
      string str = (string) GridUtils.\u202A‫⁮‎⁯⁭​‌‍⁪⁪‫‭​⁪‎⁯⁯‎‭‬⁮⁬‎‫‮⁭⁫​‍‮⁪‏⁯‍‫‏‏‍⁭‮(d, GridUtils.ColumnDefinitionsProperty);
label_1:
      int num1 = -1343853007;
      while (true)
      {
        int num2 = -1644674486;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 455943115 ^ 496807635;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return str;
    }

    public static void SetColumnDefinitions(DependencyObject d, string value)
    {
      GridUtils.\u202E‏⁫‍‫‭‪‎⁯⁫⁮‮​‌⁭⁫‎‭‬⁬‏⁪‮‍⁪‌‌‮⁫‏‍⁫‍⁫‬‌⁮‮‪‬‮(d, GridUtils.ColumnDefinitionsProperty, (object) value);
    }

    private static void OnColumnDefinitionsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
label_1:
      int num1 = 1500632598;
      while (true)
      {
        int num2 = 669484549;
        uint num3;
        bool flag;
        string newValue;
        string[] strArray1;
        string[] strArray2;
        int index;
        string length;
        Grid grid;
        switch ((num3 = (uint) (num1 ^ num2)) % 18U)
        {
          case 0:
            num1 = (int) num3 * -392681729 ^ 1503721486;
            continue;
          case 1:
            num1 = (int) num3 * -1446607649 ^ 1606741188;
            continue;
          case 2:
            int num4;
            num1 = num4 = index >= strArray2.Length ? 2031969093 : (num4 = 529140342);
            continue;
          case 3:
            grid = d as Grid;
            num1 = (int) num3 * -349729296 ^ 1399183803;
            continue;
          case 4:
            ++index;
            num1 = (int) num3 * 2052899649 ^ 784971275;
            continue;
          case 5:
            goto label_1;
          case 6:
            flag = length.Trim() == "";
            num1 = (int) num3 * -641152792 ^ -1448245841;
            continue;
          case 7:
            num1 = 1121206847;
            continue;
          case 8:
            GridUtils.\u206F‪‮‏⁪‪‮⁮⁯⁪‭‭‏⁪⁭‫⁫‫​‭‎⁮‏⁭⁭‪⁫‫‏⁫‎⁭‭⁪⁮⁬⁫‎‌⁫‮(GridUtils.\u202E‬⁫‪‫‮‪‎⁭‭‎⁭⁮⁮‮‍‍⁬⁬⁪‭⁫⁫⁭⁫⁪​‮⁫​‏‎⁫‭⁪⁯⁭‭‮‌‮(grid));
            newValue = e.NewValue as string;
            num1 = (int) num3 * -690924099 ^ 1169322275;
            continue;
          case 9:
            length = strArray2[index];
            num1 = 1076875822;
            continue;
          case 10:
            int num5 = flag ? 1507309831 : (num5 = 80178198);
            int num6 = (int) num3 * 1456277392;
            num1 = num5 ^ num6;
            continue;
          case 11:
            num1 = (int) num3 * -265618399 ^ 1546870685;
            continue;
          case 12:
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            num1 = (int) num3 * -512428143 ^ -364095275;
            continue;
          case 13:
            strArray2 = strArray1;
            index = 0;
            num1 = (int) num3 * -871176546 ^ -2074409577;
            continue;
          case 14:
            strArray1 = newValue.Split(',');
            num1 = (int) num3 * 902127709 ^ 2034526608;
            continue;
          case 15:
            grid.ColumnDefinitions.Add(new ColumnDefinition()
            {
              Width = GridUtils.ParseLength(length)
            });
            num1 = 557750708;
            continue;
          case 16:
            goto label_3;
          case 17:
            num1 = (int) num3 * 1787319306 ^ -282502646;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return;
label_3:;
    }

    private static GridLength ParseLength(string length)
    {
      length = GridUtils.\u200B⁯‬⁯‌‫⁭‪⁯​‪‬⁫⁭‫‭‫⁮‌‍⁫⁮​‭⁭‬‍‫‬‌⁭‍‪‬‬‬‪‎⁯⁬‮(length);
      if (!GridUtils.\u200D⁯‭⁮‪‭⁮⁬‮‭‮⁮‪‌​‌‬‎⁬⁯‭⁪​⁭‬‫⁯‏‬‏‪⁬‏‍⁮⁯‏‫⁫⁯‮(GridUtils.\u206E‬‎⁬‍⁯⁯⁮​‮⁮⁫​‍⁫‍‌‬⁫‭​‭‬‪⁪‍⁯‮‬‎‬‮‫⁭​‭‮‫‍⁪‮(length), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4188831903U)))
        goto label_6;
label_1:
      int num1 = 811947005;
label_2:
      GridLength gridLength;
      bool flag1;
      while (true)
      {
        int num2 = 1037947414;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            gridLength = new GridLength(0.0, GridUnitType.Auto);
            num1 = (int) num3 * 820275913 ^ -733095467;
            continue;
          case 1:
            gridLength = new GridLength(double.Parse(length), GridUnitType.Star);
            num1 = 815946156;
            continue;
          case 2:
            length = length.Replace(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2619836369U), "");
            flag2 = string.IsNullOrEmpty(length);
            num1 = (int) num3 * -1269812207 ^ -310916951;
            continue;
          case 3:
            num1 = (int) num3 * -2130375017 ^ 1093816399;
            continue;
          case 4:
            goto label_6;
          case 5:
            gridLength = new GridLength(double.Parse(length), GridUnitType.Pixel);
            num1 = 815946156;
            continue;
          case 7:
            num1 = (int) num3 * 186687851 ^ 1329742817;
            continue;
          case 8:
            int num4 = flag1 ? -526917320 : (num4 = -391527473);
            int num5 = (int) num3 * -1701446728;
            num1 = num4 ^ num5;
            continue;
          case 9:
            int num6 = !flag2 ? -1954247045 : (num6 = -1571517296);
            int num7 = (int) num3 * -1663628272;
            num1 = num6 ^ num7;
            continue;
          case 10:
            length = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(248015323U);
            num1 = (int) num3 * 101331726 ^ 728720223;
            continue;
          case 11:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_13:
      return gridLength;
label_6:
      flag1 = length.Contains(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2328837835U));
      num1 = 766225642;
      goto label_2;
    }

    static object \u202A‫⁮‎⁯⁭​‌‍⁪⁪‫‭​⁪‎⁯⁯‎‭‬⁮⁬‎‫‮⁭⁫​‍‮⁪‏⁯‍‫‏‏‍⁭‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u202E‏⁫‍‫‭‪‎⁯⁫⁮‮​‌⁭⁫‎‭‬⁬‏⁪‮‍⁪‌‌‮⁫‏‍⁫‍⁫‬‌⁮‮‪‬‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static RowDefinitionCollection \u206C⁫​‭⁭⁭‍⁪⁫⁫‏‭‪‪‎‭‌‫⁭⁬‍‫‍⁯⁮⁪‮‪⁮‪⁯‪⁯⁫⁯⁯‮⁬‎‍‮([In] Grid obj0)
    {
      return obj0.RowDefinitions;
    }

    static void \u202E‪⁪⁮‎‏‭‏​‌⁬⁪‬⁬‪⁯‌‪‍‌‌⁪⁬​‬⁫⁬⁯‌‌⁯⁯‫‬⁪⁪‪‏‍⁫‮([In] RowDefinitionCollection obj0)
    {
      obj0.Clear();
    }

    static ColumnDefinitionCollection \u202E‬⁫‪‫‮‪‎⁭‭‎⁭⁮⁮‮‍‍⁬⁬⁪‭⁫⁫⁭⁫⁪​‮⁫​‏‎⁫‭⁪⁯⁭‭‮‌‮([In] Grid obj0)
    {
      return obj0.ColumnDefinitions;
    }

    static void \u206F‪‮‏⁪‪‮⁮⁯⁪‭‭‏⁪⁭‫⁫‫​‭‎⁮‏⁭⁭‪⁫‫‏⁫‎⁭‭⁪⁮⁬⁫‎‌⁫‮([In] ColumnDefinitionCollection obj0)
    {
      obj0.Clear();
    }

    static string \u200B⁯‬⁯‌‫⁭‪⁯​‪‬⁫⁭‫‭‫⁮‌‍⁫⁮​‭⁭‬‍‫‬‌⁭‍‪‬‬‬‪‎⁯⁬‮([In] string obj0)
    {
      return obj0.Trim();
    }

    static string \u206E‬‎⁬‍⁯⁯⁮​‮⁮⁫​‍⁫‍‌‬⁫‭​‭‬‪⁪‍⁯‮‬‎‬‮‫⁭​‭‮‫‍⁪‮([In] string obj0)
    {
      return obj0.ToLowerInvariant();
    }

    static bool \u200D⁯‭⁮‪‭⁮⁬‮‭‮⁮‪‌​‌‬‎⁬⁯‭⁪​⁭‬‫⁯‏‬‏‪⁬‏‍⁮⁯‏‫⁫⁯‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static Type \u206E‫‫‏‭​⁪‍⁪⁫‬‎‌‪‏⁫‏‪​‫‌‬‌‬‎⁮‫‮‭⁯‍‍‌‍⁫⁫⁮‍‪‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static PropertyMetadata \u200F‬‮⁪⁬⁯⁯‮‎‫‎‍‌⁯⁯‏‮⁭‏‫‭‭‭‌‍‍⁮‪‮‭⁬​‫⁮‮‮‭⁫‭‬‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new PropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u200E‬⁯⁭⁫‪‪⁫‍‍⁬‬​⁭⁮‬⁬⁪⁫‌⁬‎⁭‬⁫⁫‪⁮⁫‌⁫‮​⁫‭‪‍⁬‫‬‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.RegisterAttached(obj0, obj1, obj2, obj3);
    }
  }
}
