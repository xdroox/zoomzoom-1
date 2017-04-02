// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MouseEventData
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZoomZoom
{
  public class MouseEventData
  {
    private List<Keys> list;

    public int X { get; set; }

    public int Y { get; set; }

    public System.Drawing.Point Location { get; set; }

    public MouseButtons Buttons { get; set; }

    public DateTime ClickTime { get; set; }

    public IntPtr WindowClicked { get; set; }

    public List<Keys> KeysDown { get; set; }

    public object RelativeX { get; internal set; }

    public object RelativeY { get; internal set; }

    public MouseEventData()
    {
label_1:
      int num1 = -1549565844;
      while (true)
      {
        int num2 = -1388150739;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -946575950 ^ 1600903095;
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

    public MouseEventData(MouseEventArgs args)
    {
label_1:
      int num1 = -936051158;
      while (true)
      {
        int num2 = -1085848522;
        uint num3;
        IntPtr windowClicked;
        bool flag;
        Rectangle windowRectangle;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            this.Buttons = MouseEventData.\u202E‫‬‭‬​‌‍⁫​​‪‌⁯‪⁮⁭⁭⁭‬‍⁫‮‎‍‌‫​‮​‫⁮⁮‬⁬‌‭⁬‎⁬‮(args);
            num1 = (int) num3 * 1525883839 ^ -1869001057;
            continue;
          case 1:
            this.WindowClicked = User32.WindowFromPoint(new POINT()
            {
              x = this.X,
              y = this.Y
            });
            num1 = (int) num3 * -1641522931 ^ 609638969;
            continue;
          case 2:
            windowClicked = this.WindowClicked;
            num1 = (int) num3 * 388596625 ^ 165974226;
            continue;
          case 3:
            this.Y = MouseEventData.\u200D‬⁯⁯⁭⁪⁭​‭⁪⁯‏​⁫‫‎⁭‪⁪⁯⁫‮‫‮⁭‌‎‏​‭​⁬​⁭⁫⁪‌‪‏‫‮(args);
            this.Location = MouseEventData.\u206C‭‎‏​⁮​⁫‌‭⁭⁪‮‬⁫⁮⁫⁫‪‮‪‫‮⁭⁯​⁮‭‍‌‏⁪‫⁬⁭‎‬⁬⁭‫‮(args);
            num1 = (int) num3 * -578684820 ^ -802579733;
            continue;
          case 4:
            this.RelativeY = (object) (this.Y - windowRectangle.Y);
            num1 = (int) num3 * 1271612637 ^ 1048201302;
            continue;
          case 5:
            int num4 = flag ? -787057706 : (num4 = -952214584);
            int num5 = (int) num3 * 1596407197;
            num1 = num4 ^ num5;
            continue;
          case 6:
            num1 = (int) num3 * 1617108791 ^ -1849350306;
            continue;
          case 7:
            num1 = (int) num3 * 1094136547 ^ 1063216414;
            continue;
          case 8:
            flag = !windowClicked.Equals((object) IntPtr.Zero);
            num1 = (int) num3 * 1752203611 ^ -1972102595;
            continue;
          case 9:
            this.ClickTime = DateTime.Now;
            num1 = (int) num3 * 1606358433 ^ -733084214;
            continue;
          case 10:
            num1 = (int) num3 * 1006380585 ^ -680283782;
            continue;
          case 11:
            goto label_3;
          case 12:
            num1 = (int) num3 * 874660844 ^ -1227750870;
            continue;
          case 13:
            windowRectangle = WindowHelper.GetWindowRectangle(this.WindowClicked);
            num1 = (int) num3 * -1659007827 ^ -635600158;
            continue;
          case 14:
            this.X = MouseEventData.\u202C⁪‍⁫⁬‎⁯⁫‬⁭‌⁯⁭‭⁬‬‮⁪⁪⁭‍‬‭‍‭‫⁬⁯‍⁪‫⁪‫‫‎‌‏‪‭‮‮(args);
            num1 = (int) num3 * 583070653 ^ -823827509;
            continue;
          case 15:
            goto label_1;
          case 16:
            this.RelativeX = (object) (this.X - windowRectangle.X);
            num1 = (int) num3 * 896768921 ^ -859984418;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return;
label_3:;
    }

    public MouseEventData(MouseEventArgs args, List<Keys> list)
      : this(args)
    {
label_1:
      int num1 = -824924503;
      while (true)
      {
        int num2 = -1612503986;
        uint num3;
        Rectangle windowRectangle;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            num1 = (int) num3 * -478798482 ^ 397026483;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.KeysDown = list;
            num1 = -690238150;
            continue;
          case 3:
            num1 = (int) num3 * -1292951336 ^ -877620562;
            continue;
          case 4:
            this.Location = MouseEventData.\u206C‭‎‏​⁮​⁫‌‭⁭⁪‮‬⁫⁮⁫⁫‪‮‪‫‮⁭⁯​⁮‭‍‌‏⁪‫⁬⁭‎‬⁬⁭‫‮(args);
            num1 = (int) num3 * -1642805183 ^ -1071624449;
            continue;
          case 5:
            this.WindowClicked = User32.WindowFromPoint(new POINT()
            {
              x = this.X,
              y = this.Y
            });
            num1 = (int) num3 * -392276514 ^ 1317024267;
            continue;
          case 6:
            this.Buttons = MouseEventData.\u202E‫‬‭‬​‌‍⁫​​‪‌⁯‪⁮⁭⁭⁭‬‍⁫‮‎‍‌‫​‮​‫⁮⁮‬⁬‌‭⁬‎⁬‮(args);
            num1 = (int) num3 * 449562895 ^ 1943755411;
            continue;
          case 7:
            this.Y = MouseEventData.\u200D‬⁯⁯⁭⁪⁭​‭⁪⁯‏​⁫‫‎⁭‪⁪⁯⁫‮‫‮⁭‌‎‏​‭​⁬​⁭⁫⁪‌‪‏‫‮(args);
            num1 = (int) num3 * -1011070811 ^ -1425214117;
            continue;
          case 8:
            num1 = (int) num3 * -1271925728 ^ -1737399606;
            continue;
          case 9:
            goto label_1;
          case 10:
            this.RelativeY = (object) (this.Y - windowRectangle.Y);
            num1 = (int) num3 * -335000860 ^ -1509778805;
            continue;
          case 11:
            num1 = (int) num3 * -321255383 ^ -703305185;
            continue;
          case 12:
            num1 = (int) num3 * 1414441358 ^ -1794115781;
            continue;
          case 13:
            this.X = MouseEventData.\u202C⁪‍⁫⁬‎⁯⁫‬⁭‌⁯⁭‭⁬‬‮⁪⁪⁭‍‬‭‍‭‫⁬⁯‍⁪‫⁪‫‫‎‌‏‪‭‮‮(args);
            num1 = (int) num3 * -1463393491 ^ 636891068;
            continue;
          case 14:
            int num4 = this.WindowClicked.Equals((object) IntPtr.Zero) ? 291095722 : (num4 = 1584606151);
            int num5 = (int) num3 * -1635026752;
            num1 = num4 ^ num5;
            continue;
          case 15:
            this.RelativeX = (object) (this.X - windowRectangle.X);
            num1 = (int) num3 * -1263346483 ^ -972315994;
            continue;
          case 16:
            this.ClickTime = DateTime.Now;
            num1 = (int) num3 * -2137513357 ^ 1473745127;
            continue;
          case 17:
            windowRectangle = WindowHelper.GetWindowRectangle(this.WindowClicked);
            num1 = (int) num3 * -348788526 ^ 426316521;
            continue;
          case 18:
            num1 = (int) num3 * -1186626973 ^ -1514506112;
            continue;
          case 19:
            num1 = (int) num3 * -1126034914 ^ -1069232452;
            continue;
          case 20:
            num1 = (int) num3 * 829976025 ^ 171102216;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return;
label_3:;
    }

    static int \u202C⁪‍⁫⁬‎⁯⁫‬⁭‌⁯⁭‭⁬‬‮⁪⁪⁭‍‬‭‍‭‫⁬⁯‍⁪‫⁪‫‫‎‌‏‪‭‮‮([In] MouseEventArgs obj0)
    {
      return obj0.X;
    }

    static int \u200D‬⁯⁯⁭⁪⁭​‭⁪⁯‏​⁫‫‎⁭‪⁪⁯⁫‮‫‮⁭‌‎‏​‭​⁬​⁭⁫⁪‌‪‏‫‮([In] MouseEventArgs obj0)
    {
      return obj0.Y;
    }

    static System.Drawing.Point \u206C‭‎‏​⁮​⁫‌‭⁭⁪‮‬⁫⁮⁫⁫‪‮‪‫‮⁭⁯​⁮‭‍‌‏⁪‫⁬⁭‎‬⁬⁭‫‮([In] MouseEventArgs obj0)
    {
      return obj0.Location;
    }

    static MouseButtons \u202E‫‬‭‬​‌‍⁫​​‪‌⁯‪⁮⁭⁭⁭‬‍⁫‮‎‍‌‫​‮​‫⁮⁮‬⁬‌‭⁬‎⁬‮([In] MouseEventArgs obj0)
    {
      return obj0.Button;
    }
  }
}
