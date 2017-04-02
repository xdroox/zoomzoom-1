// Decompiled with JetBrains decompiler
// Type: flaphx.utils.Win32Rect
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace flaphx.utils
{
  public struct Win32Rect
  {
    public int Left;
    public int Top;
    public int Right;
    public int Bottom;

    public int Width
    {
      get
      {
label_1:
        int num1 = 1786607032;
        int num2;
        while (true)
        {
          int num3 = 619159785;
          uint num4;
          switch ((num4 = (uint) (num1 ^ num3)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num2 = this.Right - this.Left;
              num1 = (int) num4 * -1190196577 ^ -879294551;
              continue;
            case 3:
              num1 = (int) num4 * -83371507 ^ -612506276;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return num2;
      }
    }

    public int Height
    {
      get
      {
label_1:
        int num1 = 1216515793;
        int num2;
        while (true)
        {
          int num3 = 1912944560;
          uint num4;
          switch ((num4 = (uint) (num1 ^ num3)) % 3U)
          {
            case 1:
              num2 = this.Bottom - this.Top;
              num1 = (int) num4 * -1150604352 ^ 1684465042;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return num2;
      }
    }
  }
}
