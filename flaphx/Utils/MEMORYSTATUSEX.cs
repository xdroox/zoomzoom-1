// Decompiled with JetBrains decompiler
// Type: flaphx.utils.MEMORYSTATUSEX
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace flaphx.utils
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
      int num1 = -2140942400;
      while (true)
      {
        int num2 = -1935533862;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Length = Marshal.SizeOf<MEMORYSTATUSEX>((M0) this);
            num1 = (int) num3 * -1844498381 ^ 2112373322;
            continue;
          case 2:
            num1 = (int) num3 * 1306668153 ^ -1914986563;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void StopTheCompilerComplaining()
    {
label_1:
      int num1 = 1265269914;
      while (true)
      {
        int num2 = 855618925;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this.AvailableVirtual = 0UL;
            num1 = (int) num3 * 1133823791 ^ -1279053491;
            continue;
          case 1:
            this.Length = 0;
            num1 = (int) num3 * 1398496754 ^ 405852313;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.TotalPhysical = 0UL;
            this.AvailablePhysical = 0UL;
            num1 = (int) num3 * 3423184 ^ -29699654;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.TotalVirtual = 0UL;
            num1 = (int) num3 * -1430321553 ^ -161216844;
            continue;
          case 6:
            this.MemoryLoad = 0;
            num1 = (int) num3 * -1587887442 ^ 908105265;
            continue;
          case 7:
            this.AvailableExtendedVirtual = 0UL;
            num1 = (int) num3 * -1012818013 ^ 315111572;
            continue;
          case 8:
            this.TotalPageFile = 0UL;
            this.AvailablePageFile = 0UL;
            num1 = (int) num3 * -1193487821 ^ -737101026;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }
  }
}
