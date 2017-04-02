// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.ImageManagementControl
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
  public class ImageManagementControl : UserControl, IComponentConnector
  {
    private bool _contentLoaded;

    public ImageManagementControl()
    {
      this.InitializeComponent();
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
label_1:
      int num1 = -1655485681;
      while (true)
      {
        int num2 = -580740465;
        uint num3;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            this._contentLoaded = true;
            num1 = -43426615;
            continue;
          case 2:
            num1 = (int) num3 * -583400344 ^ 665856842;
            continue;
          case 3:
            int num4 = !this._contentLoaded ? 1770378254 : (num4 = 1547551048);
            int num5 = (int) num3 * 1516358901;
            num1 = num4 ^ num5;
            continue;
          case 4:
            num1 = (int) num3 * -1110731972 ^ -1545647231;
            continue;
          case 5:
            num1 = (int) num3 * -559886805 ^ -141946298;
            continue;
          case 6:
            goto label_3;
          case 7:
            ImageManagementControl.\u206D‪⁭⁭⁯⁬​​⁬⁭‮⁪⁪‪‮‫‬⁪‍‬‎‪‎‏‎‮‪⁬‮⁫⁪⁫‪‍⁬‮‫‍‍‮‮((object) this, uri);
            num1 = (int) num3 * -803892804 ^ 1071793885;
            continue;
          case 8:
            uri = ImageManagementControl.\u200D‪​‎‮‭‭⁪‭‍‫‏⁪⁪⁯‬‏⁭⁭‭​‮‌​​⁪‫‌‌‪‏‮⁪⁮⁬⁪⁭⁯‮‬‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3778853855U), UriKind.Relative);
            num1 = (int) num3 * -682796690 ^ -1296994667;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = 1690112221;
      while (true)
      {
        int num2 = 1116112111;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this._contentLoaded = true;
            num1 = (int) num3 * 964315060 ^ 798406795;
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

    static Uri \u200D‪​‎‮‭‭⁪‭‍‫‏⁪⁪⁯‬‏⁭⁭‭​‮‌​​⁪‫‌‌‪‏‮⁪⁮⁬⁪⁭⁯‮‬‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u206D‪⁭⁭⁯⁬​​⁬⁭‮⁪⁪‪‮‫‬⁪‍‬‎‪‎‏‎‮‪⁬‮⁫⁪⁫‪‍⁬‮‫‍‍‮‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }
  }
}
