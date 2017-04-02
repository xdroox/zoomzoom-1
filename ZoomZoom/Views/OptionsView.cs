// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.OptionsView
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
using Telerik.Windows.Controls;

namespace ZoomZoom.Views
{
  public class OptionsView : Window, IComponentConnector
  {
    internal CheckBox cbEnabledVideoToChatLinking;
    internal CheckBox cbAutoCaptureVideoImages;
    internal RadNumericUpDown nudAutoCaptureVideoInterval;
    private bool _contentLoaded;

    public OptionsView()
    {
label_1:
      int num1 = 24267836;
      while (true)
      {
        int num2 = 1998184462;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1929628002 ^ 1156480969;
            continue;
          case 3:
            num1 = (int) num3 * 1944287911 ^ 1108484302;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = 1298352492;
      while (true)
      {
        int num2 = 1590969849;
        uint num3;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this._contentLoaded = true;
            uri = OptionsView.\u202B⁫⁫⁫​‪⁬⁮⁭‫​‪‬‪⁮⁫‏‍⁯‌‬‫‏‍⁭‪‌‎⁯‭‍⁪‌‫​⁬‬⁭‮⁮‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(203811862U), UriKind.Relative);
            num1 = 730670169;
            continue;
          case 1:
            int num4 = contentLoaded ? 1052520892 : (num4 = 835384600);
            int num5 = (int) num3 * 628392811;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_3;
          case 3:
            OptionsView.\u202E‫‬⁯⁫‭⁭⁫​⁭⁯⁫⁬‎‪​⁭‭​⁭‏‫‎⁮⁮⁯‏‪​⁭‌‪‭‍⁫‌⁫⁮⁫⁪‮((object) this, uri);
            num1 = (int) num3 * 737447912 ^ 2115427303;
            continue;
          case 4:
            num1 = (int) num3 * -1168116553 ^ -1351369867;
            continue;
          case 5:
            num1 = (int) num3 * -1802747323 ^ -1290486643;
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

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      int num1;
      switch (connectionId)
      {
        case 1:
label_8:
          this.cbEnabledVideoToChatLinking = (CheckBox) target;
          num1 = -523244409;
          break;
        case 2:
label_9:
          this.cbAutoCaptureVideoImages = (CheckBox) target;
          num1 = -1613334102;
          break;
        case 3:
label_5:
          this.nudAutoCaptureVideoInterval = (RadNumericUpDown) target;
          num1 = -1089101313;
          break;
        default:
label_1:
          num1 = -1453788247;
          break;
      }
      while (true)
      {
        int num2 = -185484815;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_8;
          case 2:
            goto label_5;
          case 3:
            num1 = (int) num3 * -218824921 ^ -1295911088;
            continue;
          case 4:
            num1 = (int) num3 * -1682782974 ^ 1998966498;
            continue;
          case 5:
            goto label_9;
          case 6:
            goto label_3;
          case 7:
            this._contentLoaded = true;
            num1 = -1613334102;
            continue;
          case 8:
            num1 = (int) num3 * -1672487985 ^ -310176520;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    static Uri \u202B⁫⁫⁫​‪⁬⁮⁭‫​‪‬‪⁮⁫‏‍⁯‌‬‫‏‍⁭‪‌‎⁯‭‍⁪‌‫​⁬‬⁭‮⁮‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u202E‫‬⁯⁫‭⁭⁫​⁭⁯⁫⁬‎‪​⁭‭​⁭‏‫‎⁮⁮⁯‏‪​⁭‌‪‭‍⁫‌⁫⁮⁫⁪‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }
  }
}
