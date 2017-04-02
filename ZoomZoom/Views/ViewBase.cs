// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.ViewBase
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using ZoomZoom.ViewModels;

namespace ZoomZoom.Views
{
  public class ViewBase : Window
  {
    protected ILog log = ViewBase.\u200E‮⁫‎‬‭‫‪‭‬⁭‏‬⁭‫‮​‪‭​‌‌⁪‬⁪‌‭⁪⁬​‍‍‪‪⁭‏‏‭⁪‬‮(ViewBase.\u200B‍⁬⁮⁮‍⁮⁭‌⁪⁮⁯‎⁭‪‬‌⁫‬‎‏‫⁬⁮‎⁯​‭⁬‍‍‮‪⁬‭‏‌‎‭‪‮((MemberInfo) ViewBase.\u200B⁭⁭⁫⁮‪‮​‏‭⁬‎‮⁪‏‏⁭‬‭⁫‍‮⁬‫‎⁯⁬⁮‬‌‮⁯‍‪⁬⁮‎‏⁮‌‮()));
    private Engine engine = (Engine) null;
    private ViewModelBase viewModel = (ViewModelBase) null;

    public ViewModelBase ViewModel
    {
      get
      {
        ViewModelBase viewModel = this.viewModel;
label_1:
        int num1 = -799651232;
        while (true)
        {
          int num2 = -2038085340;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 867356976 ^ -110443536;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return viewModel;
      }
      set
      {
label_1:
        int num1 = -1488884255;
        while (true)
        {
          int num2 = -1682441388;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.viewModel = value;
              num1 = (int) num3 * 593605867 ^ -2092620190;
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

    public Engine Engine
    {
      get
      {
        Engine engine = this.engine;
label_1:
        int num1 = -1786678675;
        while (true)
        {
          int num2 = -1102648260;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -2019297744 ^ 81332372;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return engine;
      }
      set
      {
        this.engine = value;
      }
    }

    public ViewBase(ViewModelBase viewModel)
    {
      this.engine = viewModel.Engine;
      this.viewModel = viewModel;
    }

    static MethodBase \u200B⁭⁭⁫⁮‪‮​‏‭⁬‎‮⁪‏‏⁭‬‭⁫‍‮⁬‫‎⁯⁬⁮‬‌‮⁯‍‪⁬⁮‎‏⁮‌‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200B‍⁬⁮⁮‍⁮⁭‌⁪⁮⁯‎⁭‪‬‌⁫‬‎‏‫⁬⁮‎⁯​‭⁬‍‍‮‪⁬‭‏‌‎‭‪‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u200E‮⁫‎‬‭‫‪‭‬⁭‏‬⁭‫‮​‪‭​‌‌⁪‬⁪‌‭⁪⁬​‍‍‪‪⁭‏‏‭⁪‬‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
