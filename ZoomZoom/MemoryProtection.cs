// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MemoryProtection
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
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
  }
}
