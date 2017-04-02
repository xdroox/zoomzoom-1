// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.WindowActionMenu
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
  public class WindowActionMenu : UserControl, IComponentConnector
  {
    private bool _contentLoaded;

    public WindowActionMenu()
    {
label_1:
      int num1 = 1999306584;
      while (true)
      {
        int num2 = 1572514753;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.InitializeComponent();
            num1 = (int) num3 * -1385270718 ^ 1889561265;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 639988571 ^ -1184931144;
            continue;
          case 4:
            num1 = (int) num3 * -729575147 ^ 1235461391;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (!this._contentLoaded)
        goto label_6;
label_1:
      int num1 = -1701725912;
label_2:
      Uri uri;
      while (true)
      {
        int num2 = -1423716001;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -250718336 ^ -1343941151;
            continue;
          case 1:
            WindowActionMenu.\u200C‬‌‬‬‎​⁭‪⁬⁯‪‌‪‭​⁭‌⁭​‮‍⁮‎⁮​‎‪‌⁯‎⁮⁯‏‮‮⁪⁮‎‮((object) this, uri);
            num1 = (int) num3 * 678987356 ^ 1349599839;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 1059702998 ^ 2044363931;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_6;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:
      return;
label_6:
      this._contentLoaded = true;
      uri = WindowActionMenu.\u206D‬‍⁯‫⁫⁯‍‎‏⁮‬⁫⁮‍‌‭‪‭⁪‏‪⁪‍⁫⁭‫‍⁬​⁯​⁭⁫‮⁪⁬⁬‌⁬‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1341803704U), UriKind.Relative);
      num1 = -1920359606;
      goto label_2;
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = -775197286;
      while (true)
      {
        int num2 = -858998154;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this._contentLoaded = true;
            num1 = (int) num3 * 1536103392 ^ -497424343;
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

    static Uri \u206D‬‍⁯‫⁫⁯‍‎‏⁮‬⁫⁮‍‌‭‪‭⁪‏‪⁪‍⁫⁭‫‍⁬​⁯​⁭⁫‮⁪⁬⁬‌⁬‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200C‬‌‬‬‎​⁭‪⁬⁯‪‌‪‭​⁭‌⁭​‮‍⁮‎⁮​‎‪‌⁯‎⁮⁯‏‮‮⁪⁮‎‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }
  }
}
