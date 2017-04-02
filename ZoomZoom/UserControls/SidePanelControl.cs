// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.SidePanelControl
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
  public class SidePanelControl : UserControl, IComponentConnector
  {
    private bool _contentLoaded;

    public SidePanelControl()
    {
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
label_1:
      int num1 = 791761413;
      while (true)
      {
        int num2 = 510633080;
        uint num3;
        bool contentLoaded;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this._contentLoaded = true;
            num1 = 1917315840;
            continue;
          case 1:
            num1 = (int) num3 * 2054739238 ^ 1350720327;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 185744809 ^ -265650562;
            continue;
          case 4:
            int num4 = !contentLoaded ? -1701069147 : (num4 = -195320161);
            int num5 = (int) num3 * 1160687934;
            num1 = num4 ^ num5;
            continue;
          case 5:
            SidePanelControl.\u200E‍‌‪‬‬⁬⁭⁭‮⁬‏‫‭⁮‮⁬⁪⁭‫⁫‎⁭⁮⁪⁯‍‬‮⁯‭‍⁮‫‍‭⁮⁬​⁬‮((object) this, SidePanelControl.\u206C​‭​‍‌⁯⁮‍‪‌‌‌‎‪‮⁪⁯‏‌​⁪‭‌⁬‎‬⁭⁮​‎‌⁭‪⁮⁯‮‍‭‍‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2323616986U), UriKind.Relative));
            num1 = (int) num3 * 1561755736 ^ -2088207353;
            continue;
          case 6:
            goto label_1;
          case 7:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * 1683465345 ^ 1325835736;
            continue;
          case 8:
            num1 = (int) num3 * 155610952 ^ 104006693;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = 225864418;
      while (true)
      {
        int num2 = 177439589;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this._contentLoaded = true;
            num1 = (int) num3 * 66891633 ^ 272849355;
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

    static Uri \u206C​‭​‍‌⁯⁮‍‪‌‌‌‎‪‮⁪⁯‏‌​⁪‭‌⁬‎‬⁭⁮​‎‌⁭‪⁮⁯‮‍‭‍‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u200E‍‌‪‬‬⁬⁭⁭‮⁬‏‫‭⁮‮⁬⁪⁭‫⁫‎⁭⁮⁪⁯‍‬‮⁯‭‍⁮‫‍‭⁮⁬​⁬‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }
  }
}
