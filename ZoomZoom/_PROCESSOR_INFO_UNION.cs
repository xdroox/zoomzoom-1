// Decompiled with JetBrains decompiler
// Type: ZoomZoom._PROCESSOR_INFO_UNION
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom
{
  [StructLayout(LayoutKind.Explicit)]
  public struct _PROCESSOR_INFO_UNION
  {
    [FieldOffset(0)]
    public uint dwOemId;
    [FieldOffset(0)]
    public ushort wProcessorArchitecture;
    [FieldOffset(2)]
    public ushort wReserved;
  }
}
