// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ProcessRights
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
{
  public class ProcessRights
  {
    public const uint TERMINATE = 1;
    public const uint CREATE_THREAD = 2;
    public const uint SET_SESSIONID = 4;
    public const uint VM_OPERATION = 8;
    public const uint VM_READ = 16;
    public const uint VM_WRITE = 32;
    public const uint DUP_HANDLE = 64;
    public const uint CREATE_PROCESS = 128;
    public const uint SET_QUOTA = 256;
    public const uint SET_INFORMATION = 512;
    public const uint QUERY_INFORMATION = 1024;
    public const uint SUSPEND_RESUME = 2048;
    private const uint STANDARD_RIGHTS_REQUIRED = 983040;
    private const uint SYNCHRONIZE = 1048576;
    public const uint ALL_ACCESS = 2035711;
  }
}
