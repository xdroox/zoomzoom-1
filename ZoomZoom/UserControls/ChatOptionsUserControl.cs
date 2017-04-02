// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.ChatOptionsUserControl
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ZoomZoom.ViewModels;

namespace ZoomZoom.UserControls
{
  public class ChatOptionsUserControl : UserControl, IComponentConnector
  {
    public static readonly DependencyProperty ActivityProperty = ChatOptionsUserControl.\u200E‫⁮⁯‌​⁫⁯‮‮‌⁮‌‏‪‏‫‮⁭⁮‮​⁫‍‫⁪‭‌​‍‭‏‪⁮‮‏‮⁫​‍‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3551827985U), ChatOptionsUserControl.\u206B‭‏‬⁮⁫‮​⁮​‪⁪‮​​‪⁮‎‮‮‏⁮‏‬‮⁭⁯⁬⁮⁬‬‮⁮‪⁮⁫⁬⁯‫⁫‮(__typeref (ActivityBase)), ChatOptionsUserControl.\u206B‭‏‬⁮⁫‮​⁮​‪⁪‮​​‪⁮‎‮‮‏⁮‏‬‮⁭⁯⁬⁮⁬‬‮⁮‪⁮⁫⁬⁯‫⁫‮(__typeref (ChatOptionsUserControl)), ChatOptionsUserControl.\u202C‍‍⁮⁪⁯‏‮‍‭⁯⁬‮‭‮⁯‪‍‬‬⁯⁫⁬⁯‭⁫‮‬⁫⁬​‬⁪‭‎⁬⁪‮⁬⁬‮((object) null, new PropertyChangedCallback(ChatOptionsUserControl.OnActivityChanged)));
    internal ChatOptionsUserControl parent;
    internal ComboBox cbCategories;
    internal Button btnNewCategory;
    internal Button btnDeleteCategory;
    internal TextBox txtNewCategory;
    internal Button btnSaveCategory;
    internal Button btnCancelCategory;
    internal ComboBox cbContents;
    internal Button btnNewContent;
    internal Button btnDeleteContent;
    internal TextBox txtContent;
    internal Button btnSaveContent;
    internal Button btnCancelContent;
    private bool _contentLoaded;

    public ActivityBase Activity
    {
      get
      {
label_1:
        int num1 = 1947609093;
        ActivityBase activityBase;
        while (true)
        {
          int num2 = 821434708;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              activityBase = (ActivityBase) ChatOptionsUserControl.\u202D‎⁬‍‌⁪‍⁬⁪‌‪⁯⁮‍‮​⁯‎‮⁮‮‭​‮⁬‭​‍‍‍⁫‮‎‫‫‪⁪⁪‎⁭‮((DependencyObject) this, ChatOptionsUserControl.ActivityProperty);
              num1 = (int) num3 * -524060658 ^ 556525613;
              continue;
            case 3:
              num1 = (int) num3 * 517477537 ^ -1195153319;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return activityBase;
      }
      set
      {
        ChatOptionsUserControl.\u206A‏⁮⁫‬⁯⁯‬‏‎⁮‮‭‮⁪⁮⁫‬‎​⁯⁪⁯⁬⁬‌‫‍‍‬⁫‎‍⁬‫⁫‫‎⁫‏‮((DependencyObject) this, ChatOptionsUserControl.ActivityProperty, (object) value);
label_1:
        int num1 = 937889192;
        while (true)
        {
          int num2 = 818440714;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -296445204 ^ -643006089;
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

    public ChatOptionsViewModel ViewModel
    {
      get
      {
label_1:
        int num1 = -2058965432;
        ChatOptionsViewModel optionsViewModel;
        while (true)
        {
          int num2 = -1232313693;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -316192170 ^ 92995074;
              continue;
            case 2:
              goto label_1;
            case 3:
              optionsViewModel = (ChatOptionsViewModel) ChatOptionsUserControl.\u202C‬‬‏⁫‮‭‍‏‪⁪⁯‪‍⁭‬⁭‪‎⁬‎⁯⁯⁪‭‌‎‮‏⁮‮⁬‫⁬‍‭‏‏‍⁮‮(ChatOptionsUserControl.\u202B‬⁫⁫⁪‏‮‍⁮⁭‫⁬⁪‍⁮‬⁯⁭⁬⁬‫‫⁮‪⁫‌‌‬⁭‎‭⁫‌‬⁮⁭‭⁫‪‏‮((FrameworkElement) this), (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2296256922U));
              num1 = (int) num3 * -1587044266 ^ -1083190787;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return optionsViewModel;
      }
    }

    public ChatOptionsUserControl()
    {
label_1:
      int num1 = -1054442830;
      while (true)
      {
        int num2 = -342089231;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            this.InitializeComponent();
            num1 = (int) num3 * 1385039842 ^ 674743498;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ChatOptionsUserControl.\u206E‭⁭‫‏‫‭‏​‬‬‎‍⁮‬​‮​​‌​‭‪⁫⁬⁬⁪‍⁫⁬​⁬‏‪‏‏⁯‌⁮‭‮((FrameworkElement) this, (object) this.ViewModel);
    }

    private static void OnActivityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
label_1:
      int num1 = -234518968;
      while (true)
      {
        int num2 = -705496477;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -876737334 ^ -712663926;
            continue;
          case 3:
            ((ChatOptionsUserControl) d).Activity = (ActivityBase) e.NewValue;
            num1 = (int) num3 * 1898170780 ^ 247206057;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = 1024315914;
      while (true)
      {
        int num2 = 1764671341;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ChatOptionsUserControl.\u206E‭⁭‫‏‫‭‏​‬‬‎‍⁮‬​‮​​‌​‭‪⁫⁬⁬⁪‍⁫⁬​⁬‏‪‏‏⁯‌⁮‭‮((FrameworkElement) this, (object) this.ViewModel);
            this.ViewModel.Load(this, this.Activity);
            num1 = (int) num3 * -620994963 ^ 318898832;
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

    private void UserControl_Unloaded(object sender, RoutedEventArgs e)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = 1440039415;
      while (true)
      {
        int num2 = 21908448;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -2065234450 ^ -316539114;
            continue;
          case 2:
            num1 = (int) num3 * -1858328942 ^ -783622932;
            continue;
          case 3:
            this._contentLoaded = true;
            ChatOptionsUserControl.\u202E‪‭⁪‪⁮⁬‬⁯‍‎⁫‪‍⁬⁯‫‫‮⁬‮‪‌⁭⁪‎⁮‍‭‎⁬⁯⁯‬‏⁮⁭⁫‏⁪‮((object) this, ChatOptionsUserControl.\u206A‪‬‫⁪⁪‭‪‍‮‪‬⁮⁮‮⁫⁯‪‍‪⁯⁯​‏⁫⁪⁮‫‪‬‮‏‬‏⁬‭‫‭‭‪‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2204117890U), UriKind.Relative));
            num1 = 1848173820;
            continue;
          case 4:
            goto label_3;
          case 5:
            int num4 = contentLoaded ? -256670737 : (num4 = -356809921);
            int num5 = (int) num3 * -1549011080;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      int num1;
      switch (connectionId)
      {
        case 1:
label_26:
          this.parent = (ChatOptionsUserControl) target;
          num1 = -1191474164;
          break;
        case 2:
label_6:
          this.cbCategories = (ComboBox) target;
          num1 = -661824766;
          break;
        case 3:
label_13:
          this.btnNewCategory = (Button) target;
          num1 = -73114151;
          break;
        case 4:
label_8:
          this.btnDeleteCategory = (Button) target;
          num1 = -73114151;
          break;
        case 5:
label_22:
          this.txtNewCategory = (TextBox) target;
          num1 = -1664731976;
          break;
        case 6:
label_4:
          this.btnSaveCategory = (Button) target;
          num1 = -73114151;
          break;
        case 7:
label_18:
          this.btnCancelCategory = (Button) target;
          num1 = -1556093281;
          break;
        case 8:
label_21:
          this.cbContents = (ComboBox) target;
          num1 = -73114151;
          break;
        case 9:
label_15:
          this.btnNewContent = (Button) target;
          num1 = -871647017;
          break;
        case 10:
label_30:
          this.btnDeleteContent = (Button) target;
          num1 = -771857590;
          break;
        case 11:
label_16:
          this.txtContent = (TextBox) target;
          num1 = -73114151;
          break;
        case 12:
label_29:
          this.btnSaveContent = (Button) target;
          num1 = -211759461;
          break;
        case 13:
label_28:
          this.btnCancelContent = (Button) target;
          num1 = -854831931;
          break;
        default:
label_1:
          num1 = -1733964416;
          break;
      }
      while (true)
      {
        int num2 = -1180913119;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 29U)
        {
          case 0:
            ChatOptionsUserControl.\u202E⁪‌​‪‍⁪‬‪‪‌​⁬‌‎⁫⁭‮‌‎⁮⁪‬‮‍‎⁮⁫⁫⁫⁪‬‮⁭‎‭⁭⁮​‬‮((FrameworkElement) this.parent, new RoutedEventHandler(this.UserControl_Unloaded));
            num1 = (int) num3 * -1954482419 ^ 1513808040;
            continue;
          case 1:
            goto label_30;
          case 2:
            this._contentLoaded = true;
            num1 = -73114151;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_3;
          case 5:
            goto label_26;
          case 6:
            num1 = (int) num3 * -1078270621 ^ -300360715;
            continue;
          case 7:
            goto label_13;
          case 8:
            num1 = (int) num3 * -131556529 ^ 1844605422;
            continue;
          case 9:
            num1 = (int) num3 * -774695552 ^ 543408857;
            continue;
          case 10:
            ChatOptionsUserControl.\u206B‎‎‏‌​‍‎​⁮‬⁯‭⁭⁯‍⁭‪‌‏‏⁬‏⁭‫‪‏⁪​‮⁫⁫‬‍‎‮‮‬‪‬‮((FrameworkElement) this.parent, new RoutedEventHandler(this.UserControl_Loaded));
            num1 = (int) num3 * -601097703 ^ -862655765;
            continue;
          case 11:
            goto label_15;
          case 12:
            goto label_16;
          case 13:
            goto label_28;
          case 14:
            goto label_21;
          case 15:
            num1 = (int) num3 * 957620675 ^ -1098229917;
            continue;
          case 16:
            num1 = (int) num3 * -395515478 ^ -1114282601;
            continue;
          case 17:
            num1 = (int) num3 * 88695042 ^ 1322338463;
            continue;
          case 18:
            num1 = (int) num3 * -542658768 ^ 1190028793;
            continue;
          case 19:
            goto label_18;
          case 20:
            goto label_6;
          case 21:
            num1 = (int) num3 * -1870629555 ^ -240911723;
            continue;
          case 22:
            goto label_29;
          case 23:
            num1 = (int) num3 * 1838724152 ^ -1864855011;
            continue;
          case 24:
            goto label_22;
          case 25:
            num1 = (int) num3 * -655026328 ^ 133754273;
            continue;
          case 26:
            goto label_1;
          case 27:
            num1 = (int) num3 * -550481806 ^ 2082548538;
            continue;
          case 28:
            goto label_4;
          default:
            goto label_31;
        }
      }
label_31:
      return;
label_3:;
    }

    static object \u202D‎⁬‍‌⁪‍⁬⁪‌‪⁯⁮‍‮​⁯‎‮⁮‮‭​‮⁬‭​‍‍‍⁫‮‎‫‫‪⁪⁪‎⁭‮([In] DependencyObject obj0, [In] DependencyProperty obj1)
    {
      return obj0.GetValue(obj1);
    }

    static void \u206A‏⁮⁫‬⁯⁯‬‏‎⁮‮‭‮⁪⁮⁫‬‎​⁯⁪⁯⁬⁬‌‫‍‍‬⁫‎‍⁬‫⁫‫‎⁫‏‮([In] DependencyObject obj0, [In] DependencyProperty obj1, [In] object obj2)
    {
      obj0.SetValue(obj1, obj2);
    }

    static ResourceDictionary \u202B‬⁫⁫⁪‏‮‍⁮⁭‫⁬⁪‍⁮‬⁯⁭⁬⁬‫‫⁮‪⁫‌‌‬⁭‎‭⁫‌‬⁮⁭‭⁫‪‏‮([In] FrameworkElement obj0)
    {
      return obj0.Resources;
    }

    static object \u202C‬‬‏⁫‮‭‍‏‪⁪⁯‪‍⁭‬⁭‪‎⁬‎⁯⁯⁪‭‌‎‮‏⁮‮⁬‫⁬‍‭‏‏‍⁮‮([In] ResourceDictionary obj0, [In] object obj1)
    {
      return obj0[obj1];
    }

    static void \u206E‭⁭‫‏‫‭‏​‬‬‎‍⁮‬​‮​​‌​‭‪⁫⁬⁬⁪‍⁫⁬​⁬‏‪‏‏⁯‌⁮‭‮([In] FrameworkElement obj0, [In] object obj1)
    {
      obj0.DataContext = obj1;
    }

    static Uri \u206A‪‬‫⁪⁪‭‪‍‮‪‬⁮⁮‮⁫⁯‪‍‪⁯⁯​‏⁫⁪⁮‫‪‬‮‏‬‏⁬‭‫‭‭‪‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u202E‪‭⁪‪⁮⁬‬⁯‍‎⁫‪‍⁬⁯‫‫‮⁬‮‪‌⁭⁪‎⁮‍‭‎⁬⁯⁯‬‏⁮⁭⁫‏⁪‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206B‎‎‏‌​‍‎​⁮‬⁯‭⁭⁯‍⁭‪‌‏‏⁬‏⁭‫‪‏⁪​‮⁫⁫‬‍‎‮‮‬‪‬‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u202E⁪‌​‪‍⁪‬‪‪‌​⁬‌‎⁫⁭‮‌‎⁮⁪‬‮‍‎⁮⁫⁫⁫⁪‬‮⁭‎‭⁭⁮​‬‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Unloaded += obj1;
    }

    static Type \u206B‭‏‬⁮⁫‮​⁮​‪⁪‮​​‪⁮‎‮‮‏⁮‏‬‮⁭⁯⁬⁮⁬‬‮⁮‪⁮⁫⁬⁯‫⁫‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static PropertyMetadata \u202C‍‍⁮⁪⁯‏‮‍‭⁯⁬‮‭‮⁯‪‍‬‬⁯⁫⁬⁯‭⁫‮‬⁫⁬​‬⁪‭‎⁬⁪‮⁬⁬‮([In] object obj0, [In] PropertyChangedCallback obj1)
    {
      return new PropertyMetadata(obj0, obj1);
    }

    static DependencyProperty \u200E‫⁮⁯‌​⁫⁯‮‮‌⁮‌‏‪‏‫‮⁭⁮‮​⁫‍‫⁪‭‌​‍‭‏‪⁮‮‏‮⁫​‍‮([In] string obj0, [In] Type obj1, [In] Type obj2, [In] PropertyMetadata obj3)
    {
      return DependencyProperty.Register(obj0, obj1, obj2, obj3);
    }
  }
}
