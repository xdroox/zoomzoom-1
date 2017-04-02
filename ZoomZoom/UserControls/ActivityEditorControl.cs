// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.ActivityEditorControl
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

namespace ZoomZoom.UserControls
{
  public class ActivityEditorControl : UserControl, IComponentConnector
  {
    private bool _contentLoaded;

    public ActivityEditorControl()
    {
label_1:
      int num1 = -526422056;
      while (true)
      {
        int num2 = -1712174726;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.InitializeComponent();
            num1 = (int) num3 * 1362522209 ^ -637761242;
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

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
label_1:
      int num1 = -383753550;
      while (true)
      {
        int num2 = -700788205;
        uint num3;
        bool contentLoaded;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * -409662284 ^ -982130210;
            continue;
          case 1:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * -841302390 ^ -1830977786;
            continue;
          case 2:
            ActivityEditorControl.\u200D⁬​‫​⁫‍⁫‭‍‏‮‏‪⁯‌⁭‏‍‮⁫‭⁯‬​⁯⁭⁬‪⁮‏‍‮⁯⁪⁮⁪‌‮‏‮((object) this, uri);
            num1 = (int) num3 * 662786822 ^ -224307101;
            continue;
          case 3:
            num1 = (int) num3 * -1196516962 ^ 948113097;
            continue;
          case 4:
            num1 = (int) num3 * -143115913 ^ -1142909430;
            continue;
          case 5:
            goto label_1;
          case 6:
            uri = ActivityEditorControl.\u206C⁮⁭⁪⁬‍‬⁮‬⁮‍⁮‫‮⁭‮‍‫‫⁪‍‏‌‫‪‮‪‍‪‍‭‌​‍⁭‌‌‏​‎‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(811964282U), UriKind.Relative);
            num1 = (int) num3 * -1052087057 ^ -608756059;
            continue;
          case 7:
            int num4 = !contentLoaded ? -1579322854 : (num4 = -1366326985);
            int num5 = (int) num3 * 1180845119;
            num1 = num4 ^ num5;
            continue;
          case 8:
            this._contentLoaded = true;
            num1 = -1047146047;
            continue;
          case 9:
            goto label_3;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      this._contentLoaded = true;
    }

    static Uri \u206C⁮⁭⁪⁬‍‬⁮‬⁮‍⁮‫‮⁭‮‍‫‫⁪‍‏‌‫‪‮‪‍‪‍‭‌​‍⁭‌‌‏​‎‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200D⁬​‫​⁫‍⁫‭‍‏‮‏‪⁯‌⁭‏‍‮⁫‭⁯‬​⁯⁭⁬‪⁮‏‍‮⁯⁪⁮⁪‌‮‏‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }
  }
}
