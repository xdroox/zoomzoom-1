// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.MarginSetter
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;

namespace ZoomZoom.Common
{
  public class MarginSetter
  {
    public static readonly DependencyProperty MarginProperty = MarginSetter.\u202C‬⁮⁫‎‏‪​‌‌‭⁯‌⁫⁮‪⁭​⁯​‬​‍⁫‏⁬​⁮⁭⁯‭⁮​‎‫‬‮⁭‫‌‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2261108753U), MarginSetter.\u200F‭⁯‪‏‮​‎‮⁭⁯‬‎⁯⁪‫⁪‏⁮⁫‌⁫‫‎‏⁯⁪⁬‫‫‬‬‬‬⁬‭​​‌‍‮(__typeref (Thickness)), MarginSetter.\u200F‭⁯‪‏‮​‎‮⁭⁯‬‎⁯⁪‫⁪‏⁮⁫‌⁫‫‎‏⁯⁪⁬‫‫‬‬‬‬⁬‭​​‌‍‮(__typeref (MarginSetter)), (PropertyMetadata) MarginSetter.\u200E‮​‏⁮​‌‫⁮‏⁮⁪‏⁬‫⁯‎⁮⁯‫⁪⁭⁭‭⁫‏‌‭‬⁭⁪‮‍⁯‬‍⁮⁫‎⁬‮((object) new Thickness(), new PropertyChangedCallback(MarginSetter.MarginChangedCallback)));

    public MarginSetter()
    {
label_1:
      int num1 = -716249214;
      while (true)
      {
        int num2 = -1673504172;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -430655766 ^ 435748690;
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

    public static Thickness GetMargin(DependencyObject obj)
    {
label_1:
      int num1 = -638709494;
      Thickness thickness;
      while (true)
      {
        int num2 = -223412317;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            thickness = (Thickness) MarginSetter.\u206B⁫‍⁫‎‍​‏​‍⁪⁫‍⁮​⁮‫​‫⁫⁭⁪‍⁭‏‭‫‬‎‪‌⁮⁭‪‪⁪⁪⁫⁪‮(obj, MarginSetter.MarginProperty);
            num1 = (int) num3 * 1259533966 ^ 1961549631;
            continue;
          case 2:
            num1 = (int) num3 * -698477290 ^ 1664407960;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return thickness;
    }

    public static void SetMargin(DependencyObject obj, Thickness value)
    {
label_1:
      int num1 = -1729658554;
      while (true)
      {
        int num2 = -209394179;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            MarginSetter.\u202A⁫‫‪‪‬‮⁮‏‎‮‬⁫‬‮​‍⁪‬‫‫⁫‮⁭⁯‌⁭⁪⁪‎‍⁮‫⁬⁮​⁬‎⁯⁫‮(obj, MarginSetter.MarginProperty, (object) value);
            num1 = (int) num3 * 2088773781 ^ 113660978;
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

    public static void MarginChangedCallback(object sender, DependencyPropertyChangedEventArgs e)
    {
label_1:
      int num1 = -957828968;
      while (true)
      {
        int num2 = -1610364093;
        uint num3;
        Panel panel;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            MarginSetter.\u202C⁯⁫‮‮‪‎‫​‫‪‭‏⁮‎⁪⁪⁯‭‫‏‏‫⁮⁭‬⁯‬‎‮⁬⁯‍‮‮‌⁮⁮⁮⁭‮((FrameworkElement) panel, new RoutedEventHandler(MarginSetter.Panel_Loaded));
            MarginSetter.\u202E‌⁯‏⁭‌⁯⁪⁬‎‏‭⁮⁯‍⁯‏‍‪‮‭⁫⁮‮‌‭‫‫⁬‏⁭⁬⁯‬‭⁪‭‏‬⁬‮((FrameworkElement) panel, new RoutedEventHandler(MarginSetter.Panel_Unloaded));
            num1 = -754456119;
            continue;
          case 1:
            int num4 = panel == null ? 1770685480 : (num4 = 1400783087);
            int num5 = (int) num3 * -1141248099;
            num1 = num4 ^ num5;
            continue;
          case 2:
            panel = sender as Panel;
            num1 = (int) num3 * 83617254 ^ 1283201718;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * 1563584953 ^ -799119293;
            continue;
          case 5:
            num1 = (int) num3 * 960727455 ^ -1299152219;
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

    private static void Panel_Unloaded(object sender, RoutedEventArgs e)
    {
      throw MarginSetter.\u206F⁯‍⁭‏‫⁯‌‪‭‬⁮‫​‌‌⁫‬⁯⁯​‌‬​‫⁪⁪‍‭‮‍⁯‬⁯⁭‫‫‏​⁯‮();
    }

    private static void Panel_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = 1955197664;
      Panel panel;
      while (true)
      {
        int num2 = 1854366829;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            panel = sender as Panel;
            num1 = (int) num3 * -1040041132 ^ -2087380868;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      IEnumerator enumerator = MarginSetter.\u206C‬⁯‍‭​⁫‌⁬⁬⁪⁭‍⁬‎‮‭⁪‪‪⁭⁫⁪‏⁬⁫‫‌‌⁮⁭‪⁯‌⁮‬‭‫‭⁫‮(MarginSetter.\u202A‌⁯⁯‪⁮‪⁬⁫‭‬⁯‏‮‌⁬⁭‏‎⁯⁭​‪⁬‪⁬‭⁪⁬‫‏⁯⁯⁯⁪⁭‍⁯⁫‎‮(panel));
      try
      {
label_13:
        int num2 = !MarginSetter.\u206B‬⁫⁮‬‌‬‪‫⁬⁭‫⁫‫‫‫⁪⁪⁭⁬‌‭⁮‫​‭‏‏‏‫⁬⁯‮⁬⁫⁬⁮⁬‫‌‮(enumerator) ? 1524606410 : (num2 = 1649536833);
        while (true)
        {
          int num3 = 1854366829;
          uint num4;
          FrameworkElement frameworkElement;
          object obj;
          bool flag;
          switch ((num4 = (uint) (num2 ^ num3)) % 10U)
          {
            case 0:
              int num5 = flag ? 337122481 : (num5 = 1677486706);
              int num6 = (int) num4 * -1686351486;
              num2 = num5 ^ num6;
              continue;
            case 1:
              frameworkElement = obj as FrameworkElement;
              flag = frameworkElement == null;
              num2 = (int) num4 * 1779221509 ^ -1836134570;
              continue;
            case 2:
              num2 = (int) num4 * -1124801725 ^ -1916651856;
              continue;
            case 3:
              num2 = (int) num4 * -1357414498 ^ -331266090;
              continue;
            case 4:
              obj = MarginSetter.\u200E⁪‮⁭‮‏‎‬‭⁭‎‌⁪‮‭​‬⁫‍‌⁪‎‭‪⁫‮‌‪‬​‬⁫‌⁭⁮‏‮⁯⁬‭‮(enumerator);
              num2 = 445694472;
              continue;
            case 5:
              goto label_20;
            case 6:
              num2 = (int) num4 * 740964766 ^ -644200316;
              continue;
            case 7:
              goto label_13;
            case 8:
              num2 = 1649536833;
              continue;
            case 9:
              MarginSetter.\u200B‏‏⁯⁬‪‏‌‪⁬‎⁭⁪‌‮‪⁮⁭‪⁮⁪‎⁬⁮‭‏‎‎⁬‎‏‬⁪‬⁫⁭‬⁭⁫‌‮(frameworkElement, MarginSetter.GetMargin((DependencyObject) panel));
              num2 = 1613963621;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_20:;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
label_18:
        int num2 = 1750734163;
        while (true)
        {
          int num3 = 1854366829;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_18;
            case 2:
              int num5 = disposable != null ? -167250840 : (num5 = -8564665);
              int num6 = (int) num4 * -1149605263;
              num2 = num5 ^ num6;
              continue;
            case 3:
              num2 = (int) num4 * -1935045302 ^ 1253770969;
              continue;
            case 4:
              MarginSetter.\u206D‏‬⁫‍‪‍‎‮⁬⁮‮‪‫⁮⁪​‮⁭⁬⁮​⁪⁪⁮‫‭‭‬⁫‍‌‪‌​‎‮​⁭‎‮(disposable);
              num2 = (int) num4 * 1276767669 ^ -414076710;
              continue;
            default:
              goto label_24;
          }
        }
label_24:;
      }
    }

    static object \u206B⁫‍⁫‎‍​‏​‍⁪⁫‍⁮​⁮‫​‫⁫⁭⁪‍⁭‏‭‫‬‎‪‌⁮⁭‪‪⁪⁪⁫⁪‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u202A⁫‫‪‪‬‮⁮‏‎‮‬⁫‬‮​‍⁪‬‫‫⁫‮⁭⁯‌⁭⁪⁪‎‍⁮‫⁬⁮​⁬‎⁯⁫‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static void \u202C⁯⁫‮‮‪‎‫​‫‪‭‏⁮‎⁪⁪⁯‭‫‏‏‫⁮⁭‬⁯‬‎‮⁬⁯‍‮‮‌⁮⁮⁮⁭‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u202E‌⁯‏⁭‌⁯⁪⁬‎‏‭⁮⁯‍⁯‏‍‪‮‭⁫⁮‮‌‭‫‫⁬‏⁭⁬⁯‬‭⁪‭‏‬⁬‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Unloaded += obj1;
    }

    static NotImplementedException \u206F⁯‍⁭‏‫⁯‌‪‭‬⁮‫​‌‌⁫‬⁯⁯​‌‬​‫⁪⁪‍‭‮‍⁯‬⁯⁭‫‫‏​⁯‮()
    {
      return new NotImplementedException();
    }

    static UIElementCollection \u202A‌⁯⁯‪⁮‪⁬⁫‭‬⁯‏‮‌⁬⁭‏‎⁯⁭​‪⁬‪⁬‭⁪⁬‫‏⁯⁯⁯⁪⁭‍⁯⁫‎‮([In] Panel obj0)
    {
      return obj0.Children;
    }

    static IEnumerator \u206C‬⁯‍‭​⁫‌⁬⁬⁪⁭‍⁬‎‮‭⁪‪‪⁭⁫⁪‏⁬⁫‫‌‌⁮⁭‪⁯‌⁮‬‭‫‭⁫‮([In] UIElementCollection obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u200E⁪‮⁭‮‏‎‬‭⁭‎‌⁪‮‭​‬⁫‍‌⁪‎‭‪⁫‮‌‪‬​‬⁫‌⁭⁮‏‮⁯⁬‭‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static void \u200B‏‏⁯⁬‪‏‌‪⁬‎⁭⁪‌‮‪⁮⁭‪⁮⁪‎⁬⁮‭‏‎‎⁬‎‏‬⁪‬⁫⁭‬⁭⁫‌‮([In] FrameworkElement obj0, [In] Thickness obj1)
    {
      obj0.Margin = obj1;
    }

    static bool \u206B‬⁫⁮‬‌‬‪‫⁬⁭‫⁫‫‫‫⁪⁪⁭⁬‌‭⁮‫​‭‏‏‏‫⁬⁯‮⁬⁫⁬⁮⁬‫‌‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u206D‏‬⁫‍‪‍‎‮⁬⁮‮‪‫⁮⁪​‮⁭⁬⁮​⁪⁪⁮‫‭‭‬⁫‍‌‪‌​‎‮​⁭‎‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Type \u200F‭⁯‪‏‮​‎‮⁭⁯‬‎⁯⁪‫⁪‏⁮⁫‌⁫‫‎‏⁯⁪⁬‫‫‬‬‬‬⁬‭​​‌‍‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static UIPropertyMetadata \u200E‮​‏⁮​‌‫⁮‏⁮⁪‏⁬‫⁯‎⁮⁯‫⁪⁭⁭‭⁫‏‌‭‬⁭⁪‮‍⁯‬‍⁮⁫‎⁬‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new UIPropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u202C‬⁮⁫‎‏‪​‌‌‭⁯‌⁫⁮‪⁭​⁯​‬​‍⁫‏⁬​⁮⁭⁯‭⁮​‎‫‬‮⁭‫‌‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.RegisterAttached(obj0, obj1, obj2, obj3);
    }
  }
}
