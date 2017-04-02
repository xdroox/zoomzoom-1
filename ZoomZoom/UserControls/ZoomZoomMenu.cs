// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.ZoomZoomMenu
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
  public class ZoomZoomMenu : UserControl, IComponentConnector
  {
    private bool _contentLoaded;

    public ZoomZoomMenu()
    {
label_1:
      int num1 = 1365991286;
      while (true)
      {
        int num2 = 1226429929;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.InitializeComponent();
            num1 = (int) num3 * 347672079 ^ 742628988;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * -1320050062 ^ 357309834;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = -154078815;
      while (true)
      {
        int num2 = -1205859735;
        uint num3;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            uri = ZoomZoomMenu.\u202E⁯​‍‫⁫⁯‌⁪⁯⁪⁪‪‍⁪‎‌‭‏⁮⁬⁯‍⁫‭‫‮‎​‮‌‫‍​⁭⁬‭‌‏⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3892766268U), UriKind.Relative);
            num1 = (int) num3 * 589101193 ^ -1466796247;
            continue;
          case 2:
            this._contentLoaded = true;
            num1 = -1390150677;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * 1259218365 ^ -378019021;
            continue;
          case 5:
            int num4 = !contentLoaded ? 1706495230 : (num4 = 1688202335);
            int num5 = (int) num3 * -1080802243;
            num1 = num4 ^ num5;
            continue;
          case 6:
            ZoomZoomMenu.\u202D‮‬​‭‫‌‬‭⁮‫‮​‪⁪⁬⁮‎‏‪‏‏‏‫‭‪‪⁭‮⁬‮⁪‮⁬‏⁭⁪‮⁯⁫‮((object) this, uri);
            num1 = (int) num3 * 1353957842 ^ 1461687761;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      this._contentLoaded = true;
    }

    static Uri \u202E⁯​‍‫⁫⁯‌⁪⁯⁪⁪‪‍⁪‎‌‭‏⁮⁬⁯‍⁫‭‫‮‎​‮‌‫‍​⁭⁬‭‌‏⁬‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u202D‮‬​‭‫‌‬‭⁮‫‮​‪⁪⁬⁮‎‏‪‏‏‏‫‭‪‪⁭‮⁬‮⁪‮⁬‏⁭⁪‮⁯⁫‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }
  }
}
