// Decompiled with JetBrains decompiler
// Type: flaphx.utils.ProcessRights
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace flaphx.utils
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

    public ProcessRights()
    {
label_1:
      int num1 = -1498738000;
      while (true)
      {
        int num2 = -1013391367;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -578361153 ^ 1090619371;
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
  }
}
