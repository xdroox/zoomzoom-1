// Decompiled with JetBrains decompiler
// Type: flaphx.utils.MemAllocationType
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace flaphx.utils
{
  public class MemAllocationType
  {
    public const uint COMMIT = 4096;
    public const uint RESERVE = 8192;
    public const uint DECOMMIT = 16384;
    public const uint RELEASE = 32768;
    public const uint FREE = 65536;
    public const uint PRIVATE = 131072;
    public const uint MAPPED = 262144;
    public const uint RESET = 524288;
    public const uint TOP_DOWN = 1048576;
    public const uint WRITE_WATCH = 2097152;
    public const uint PHYSICAL = 4194304;
    public const uint LARGE_PAGES = 536870912;
    public const uint FOURMB_PAGES = 2147483648;

    public MemAllocationType()
    {
label_1:
      int num1 = -1723528455;
      while (true)
      {
        int num2 = -1652718502;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -566321099 ^ -160489208;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }
  }
}
