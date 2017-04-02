// Decompiled with JetBrains decompiler
// Type: flaphx.utils.MemoryProtection
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace flaphx.utils
{
  public class MemoryProtection
  {
    public const uint PAGE_NOACCESS = 1;
    public const uint PAGE_READONLY = 2;
    public const uint PAGE_READWRITE = 4;
    public const uint PAGE_WRITECOPY = 8;
    public const uint PAGE_EXECUTE = 16;
    public const uint PAGE_EXECUTE_READ = 32;
    public const uint PAGE_EXECUTE_READWRITE = 64;
    public const uint PAGE_EXECUTE_WRITECOPY = 128;
    public const uint PAGE_GUARD = 256;
    public const uint PAGE_NOCACHE = 512;
    public const uint PAGE_WRITECOMBINE = 1024;

    public MemoryProtection()
    {
label_1:
      int num1 = 841292250;
      while (true)
      {
        int num2 = 1812406531;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -271396438 ^ -1943490045;
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
