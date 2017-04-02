// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MEMORYSTATUSEX
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom
{
  [StructLayout(LayoutKind.Sequential)]
  public class MEMORYSTATUSEX
  {
    public int Length;
    public int MemoryLoad;
    public ulong TotalPhysical;
    public ulong AvailablePhysical;
    public ulong TotalPageFile;
    public ulong AvailablePageFile;
    public ulong TotalVirtual;
    public ulong AvailableVirtual;
    public ulong AvailableExtendedVirtual;

    public MEMORYSTATUSEX()
    {
label_1:
      int num1 = -1796203992;
      while (true)
      {
        int num2 = -782711117;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1969442000 ^ -563416079;
            continue;
          case 3:
            num1 = (int) num3 * -391237136 ^ -2026351790;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      this.Length = Marshal.SizeOf<MEMORYSTATUSEX>((M0) this);
    }

    private void StopTheCompilerComplaining()
    {
label_1:
      int num1 = -29604624;
      while (true)
      {
        int num2 = -1286072964;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            goto label_1;
          case 2:
            this.AvailablePageFile = 0UL;
            num1 = (int) num3 * -518761362 ^ -1624223107;
            continue;
          case 3:
            this.TotalPageFile = 0UL;
            num1 = (int) num3 * -637419537 ^ -2038878125;
            continue;
          case 4:
            this.Length = 0;
            num1 = (int) num3 * 1961201998 ^ 2070817546;
            continue;
          case 5:
            this.TotalVirtual = 0UL;
            num1 = (int) num3 * 275515007 ^ 1746834142;
            continue;
          case 6:
            this.MemoryLoad = 0;
            num1 = (int) num3 * -36010353 ^ -1560034455;
            continue;
          case 7:
            this.TotalPhysical = 0UL;
            this.AvailablePhysical = 0UL;
            num1 = (int) num3 * -1404642368 ^ 1947117399;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      this.AvailableVirtual = 0UL;
      this.AvailableExtendedVirtual = 0UL;
    }
  }
}
