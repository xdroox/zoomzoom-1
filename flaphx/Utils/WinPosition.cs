// Decompiled with JetBrains decompiler
// Type: flaphx.utils.WinPosition
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace flaphx.utils
{
  public class WinPosition
  {
    public int Left { get; set; }

    public int Top { get; set; }

    public int Right { get; set; }

    public int Bottom { get; set; }

    public WinPosition()
    {
label_1:
      int num1 = -127908714;
      while (true)
      {
        int num2 = -666484197;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1794258618 ^ -1596421729;
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

    public WinPosition(NativeMethods.TITLEBARINFO pti)
    {
label_1:
      int num1 = -1613322285;
      while (true)
      {
        int num2 = -1002061423;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Top = pti.rcTitleBar.top;
            num1 = (int) num3 * 203006237 ^ 1358508778;
            continue;
          case 2:
            this.Left = pti.rcTitleBar.left;
            num1 = (int) num3 * -1015340728 ^ 703870521;
            continue;
          case 3:
            num1 = (int) num3 * 667051298 ^ -267995897;
            continue;
          case 4:
            this.Right = pti.rcTitleBar.right;
            num1 = (int) num3 * 2101824383 ^ -1923197498;
            continue;
          case 5:
            num1 = (int) num3 * -1287946787 ^ 1450230057;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = (int) num3 * -1899568101 ^ -1794337315;
            continue;
          case 8:
            num1 = (int) num3 * 724358344 ^ 481497679;
            continue;
          case 9:
            num1 = (int) num3 * -906870680 ^ -453736585;
            continue;
          case 10:
            this.Bottom = pti.rcTitleBar.bottom;
            num1 = (int) num3 * 1373610291 ^ -1933420476;
            continue;
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
