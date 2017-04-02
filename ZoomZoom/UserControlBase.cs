// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControlBase
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using ZoomZoom.ViewModels;

namespace ZoomZoom
{
  public class UserControlBase : UserControl
  {
    public static readonly DependencyProperty EngineViewModelProperty = UserControlBase.\u202E‪‎⁫‫‭⁮‫⁫⁭⁯‌‎⁬​⁪⁮‮‬‪‭‍⁯‎‮‬‮⁯‪‭‭⁯⁫​⁬⁮⁮‎⁯⁪‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4288659258U), UserControlBase.\u206E⁬‭‍⁮⁬‫​⁬‍⁪‎⁮‏‏‌⁬‎‭‏‎‌⁭⁪‭⁯‍⁯‭⁮‮⁭‭⁫⁫‪⁬‌‎‎‮(__typeref (EngineViewModel)), UserControlBase.\u206E⁬‭‍⁮⁬‫​⁬‍⁪‎⁮‏‏‌⁬‎‭‏‎‌⁭⁪‭⁯‍⁯‭⁮‮⁭‭⁫⁫‪⁬‌‎‎‮(__typeref (UserControlBase)), UserControlBase.\u206F‌⁬⁭‫‭⁫‫⁯⁫⁭‪‍‭⁭⁬⁯⁬⁭⁭‪‬‌‭‪​‫⁮⁪⁭⁬‪⁮⁬⁭‎‪‪‬⁯‮((object) null, new PropertyChangedCallback(UserControlBase.OnViewModelChanged)));

    public EngineViewModel EngineViewModel
    {
      get
      {
label_1:
        int num1 = -2145769826;
        EngineViewModel engineViewModel;
        while (true)
        {
          int num2 = -1706616503;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              engineViewModel = (EngineViewModel) UserControlBase.\u202C⁬⁯⁭⁯⁫‌​​‍​⁫⁪‎‏‭‮⁬‫‌⁬‪‪‭⁪⁯⁯‭‍‫‮‭⁮‎‪⁯⁭‫⁫‍‮((DependencyObject) this, UserControlBase.EngineViewModelProperty);
              num1 = (int) num3 * -1314164216 ^ 1719136201;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return engineViewModel;
      }
      set
      {
label_1:
        int num1 = 946482134;
        while (true)
        {
          int num2 = 1674506843;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              UserControlBase.\u202C‏⁮⁬⁮‌⁬‬‍‎‌⁪‎‌⁯‬⁪⁭‎‭⁯‎‍‍‎⁯⁬⁭‬⁪​⁮‮⁮‭‪⁬‌⁯‭‮((DependencyObject) this, UserControlBase.EngineViewModelProperty, (object) value);
              num1 = (int) num3 * -1028407950 ^ 967985594;
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

    private static void OnViewModelChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
    {
label_1:
      int num1 = 1394529067;
      while (true)
      {
        int num2 = 782382095;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            ((UserControlBase) obj).EngineViewModel = (EngineViewModel) args.NewValue;
            num1 = (int) num3 * 208475139 ^ 803413345;
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

    static object \u202C⁬⁯⁭⁯⁫‌​​‍​⁫⁪‎‏‭‮⁬‫‌⁬‪‪‭⁪⁯⁯‭‍‫‮‭⁮‎‪⁯⁭‫⁫‍‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u202C‏⁮⁬⁮‌⁬‬‍‎‌⁪‎‌⁯‬⁪⁭‎‭⁯‎‍‍‎⁯⁬⁭‬⁪​⁮‮⁮‭‪⁬‌⁯‭‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static Type \u206E⁬‭‍⁮⁬‫​⁬‍⁪‎⁮‏‏‌⁬‎‭‏‎‌⁭⁪‭⁯‍⁯‭⁮‮⁭‭⁫⁫‪⁬‌‎‎‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static PropertyMetadata \u206F‌⁬⁭‫‭⁫‫⁯⁫⁭‪‍‭⁭⁬⁯⁬⁭⁭‪‬‌‭‪​‫⁮⁪⁭⁬‪⁮⁬⁭‎‪‪‬⁯‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new PropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u202E‪‎⁫‫‭⁮‫⁫⁭⁯‌‎⁬​⁪⁮‮‬‪‭‍⁯‎‮‬‮⁯‪‭‭⁯⁫​⁬⁮⁮‎⁯⁪‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.Register(obj0, obj1, obj2, obj3);
    }
  }
}
