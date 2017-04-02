// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomWindowEventArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom
{
  public class ZoomWindowEventArgs : EventArgs
  {
    public IntPtr Handle { get; set; }

    public string Title { get; set; }

    public string ClassName { get; set; }

    public bool Visible { get; set; }

    public ZoomWindowType ZoomWindowType { get; set; }

    public int Width { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public int Height { get; private set; }

    public ZoomWindow Window { get; set; }

    public ZoomWindowEventArgs(ZoomWindow window)
    {
label_1:
      int num1 = -435400525;
      while (true)
      {
        int num2 = -840015693;
        uint num3;
        System.Drawing.Point location;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            this.Height = window.Size.Height;
            num1 = (int) num3 * 1150071976 ^ 797204234;
            continue;
          case 1:
            num1 = (int) num3 * 1373486184 ^ 68106145;
            continue;
          case 2:
            this.Window = window;
            num1 = (int) num3 * -1947234246 ^ 942829525;
            continue;
          case 3:
            location = window.Location;
            this.Y = location.Y;
            num1 = (int) num3 * -1326813987 ^ -1185085149;
            continue;
          case 4:
            this.Width = window.Size.Width;
            num1 = (int) num3 * 1568777294 ^ -735440046;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 1254833064 ^ -408234140;
            continue;
          case 7:
            this.Handle = window.Handle;
            num1 = (int) num3 * 446836721 ^ -1283891008;
            continue;
          case 8:
            this.Visible = window.IsVisible;
            num1 = (int) num3 * 2047458513 ^ -1676862833;
            continue;
          case 9:
            num1 = (int) num3 * 39913071 ^ 2041562631;
            continue;
          case 10:
            this.Title = window.Title;
            num1 = (int) num3 * -2034644688 ^ 465344911;
            continue;
          case 11:
            this.ClassName = window.ClassName;
            num1 = (int) num3 * 1109726875 ^ 2035918975;
            continue;
          case 12:
            this.ZoomWindowType = window.ZoomWindowType;
            location = window.Location;
            this.X = location.X;
            num1 = (int) num3 * -910325988 ^ -222438880;
            continue;
          case 13:
            num1 = (int) num3 * 420981204 ^ 1343535230;
            continue;
          case 14:
            goto label_1;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_3:;
    }
  }
}
