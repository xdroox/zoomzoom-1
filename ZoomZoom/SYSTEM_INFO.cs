// Decompiled with JetBrains decompiler
// Type: ZoomZoom.SYSTEM_INFO
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
{
  public struct SYSTEM_INFO
  {
    public _PROCESSOR_INFO_UNION uProcessorInfo;
    public uint dwPageSize;
    public uint lpMinimumApplicationAddress;
    public uint lpMaximumApplicationAddress;
    public uint dwActiveProcessorMask;
    public uint dwNumberOfProcessors;
    public uint dwProcessorType;
    public uint dwAllocationGranularity;
    public uint dwProcessorLevel;
    public uint dwProcessorRevision;
  }
}
