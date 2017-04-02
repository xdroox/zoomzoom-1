// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MouseEventExtArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZoomZoom
{
  public class MouseEventExtArgs : MouseEventArgs
  {
    private bool m_Handled;

    public bool Handled
    {
      get
      {
        bool handled = this.m_Handled;
label_1:
        int num1 = 666785136;
        while (true)
        {
          int num2 = 1892631185;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -2101528806 ^ 412613294;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return handled;
      }
      set
      {
        this.m_Handled = value;
      }
    }

    public MouseEventExtArgs(MouseButtons buttons, int clicks, int x, int y, int delta)
      : base(buttons, clicks, x, y, delta)
    {
label_1:
      int num1 = -130227737;
      while (true)
      {
        int num2 = -1073186808;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1382217542 ^ 908293409;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1462887212 ^ -212482092;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    internal MouseEventExtArgs(MouseEventArgs e)
      : base(MouseEventExtArgs.\u200E‭‬⁯⁫‫‪⁮⁯‌⁫‪‍‮‏⁫⁪‬⁭‎‮⁬‭‫⁪‮⁬‪​⁭⁫⁭​‫⁮​‏‍‮‬‮(e), MouseEventExtArgs.\u206D‫‭⁯‎‪‌⁪‎‮‪⁯⁫⁭⁭⁮‬⁪‏⁪⁯‏⁬‌‭‪⁪‍⁯‪‬‌⁮‬‮‫‌⁮‌‎‮(e), MouseEventExtArgs.\u202C⁪‌‫⁫‪‫⁫‮‪⁭‪⁪⁮⁯​⁮⁮⁮⁯‍‮⁫‮⁬‎‌‬‏⁯‪‮‫⁫‏‍⁪⁫‏‮‮(e), MouseEventExtArgs.\u206E⁫⁫‎‌⁬⁮‍⁭‏⁮‪⁮‬‮‭⁮‬‎‎⁪​‮⁬‭⁭‮‍‎‎⁪​⁯⁮⁭⁯‭⁯⁭⁮‮(e), MouseEventExtArgs.\u206A‫‌‍‫⁮⁯⁮‫​​‍‌⁬⁮‮⁭‎‫‭‭‮⁬‌​⁫⁫‎‍⁮‭‍‬⁯‬‫⁮‏‭⁭‮(e))
    {
    }

    static MouseButtons \u200E‭‬⁯⁫‫‪⁮⁯‌⁫‪‍‮‏⁫⁪‬⁭‎‮⁬‭‫⁪‮⁬‪​⁭⁫⁭​‫⁮​‏‍‮‬‮([In] MouseEventArgs obj0)
    {
      return obj0.Button;
    }

    static int \u206D‫‭⁯‎‪‌⁪‎‮‪⁯⁫⁭⁭⁮‬⁪‏⁪⁯‏⁬‌‭‪⁪‍⁯‪‬‌⁮‬‮‫‌⁮‌‎‮([In] MouseEventArgs obj0)
    {
      return obj0.Clicks;
    }

    static int \u202C⁪‌‫⁫‪‫⁫‮‪⁭‪⁪⁮⁯​⁮⁮⁮⁯‍‮⁫‮⁬‎‌‬‏⁯‪‮‫⁫‏‍⁪⁫‏‮‮([In] MouseEventArgs obj0)
    {
      return obj0.X;
    }

    static int \u206E⁫⁫‎‌⁬⁮‍⁭‏⁮‪⁮‬‮‭⁮‬‎‎⁪​‮⁬‭⁭‮‍‎‎⁪​⁯⁮⁭⁯‭⁯⁭⁮‮([In] MouseEventArgs obj0)
    {
      return obj0.Y;
    }

    static int \u206A‫‌‍‫⁮⁯⁮‫​​‍‌⁬⁮‮⁭‎‫‭‭‮⁬‌​⁫⁫‎‍⁮‭‍‬⁯‬‫⁮‏‭⁭‮([In] MouseEventArgs obj0)
    {
      return obj0.Delta;
    }
  }
}
