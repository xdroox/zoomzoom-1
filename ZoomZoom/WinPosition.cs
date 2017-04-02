// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WinPosition
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
{
  public class WinPosition
  {
    public int Left { get; set; }

    public int Top { get; set; }

    public int Right { get; set; }

    public int Bottom { get; set; }

    public WinPosition()
    {
    }

    public WinPosition(NativeMethods.TITLEBARINFO pti)
    {
label_1:
      int num1 = 1942692917;
      while (true)
      {
        int num2 = 399678149;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            this.Top = pti.rcTitleBar.top;
            num1 = (int) num3 * 913341613 ^ 1225683768;
            continue;
          case 1:
            num1 = (int) num3 * -1565613516 ^ -1750776440;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.Left = pti.rcTitleBar.left;
            num1 = (int) num3 * -1409279242 ^ 14216600;
            continue;
          case 4:
            num1 = (int) num3 * 1637811204 ^ 605355680;
            continue;
          case 5:
            num1 = (int) num3 * 1041750215 ^ 388173894;
            continue;
          case 6:
            num1 = (int) num3 * -103983641 ^ 1040575942;
            continue;
          case 7:
            num1 = (int) num3 * -171131827 ^ -255451686;
            continue;
          case 8:
            this.Bottom = pti.rcTitleBar.bottom;
            num1 = (int) num3 * -549010213 ^ -1106748807;
            continue;
          case 9:
            this.Right = pti.rcTitleBar.right;
            num1 = (int) num3 * 525005261 ^ 308523584;
            continue;
          case 10:
            goto label_3;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }
  }
}
