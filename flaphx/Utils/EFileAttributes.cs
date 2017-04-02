// Decompiled with JetBrains decompiler
// Type: flaphx.utils.EFileAttributes
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace flaphx.utils
{
  [Flags]
  public enum EFileAttributes : uint
  {
    Readonly = 1,
    Hidden = 2,
    System = 4,
    Directory = 16,
    Archive = 32,
    Device = 64,
    Normal = 128,
    Temporary = 256,
    SparseFile = 512,
    ReparsePoint = 1024,
    Compressed = 2048,
    Offline = 4096,
    NotContentIndexed = 8192,
    Encrypted = 16384,
    Write_Through = 2147483648,
    Overlapped = 1073741824,
    NoBuffering = 536870912,
    RandomAccess = 268435456,
    SequentialScan = 134217728,
    DeleteOnClose = 67108864,
    BackupSemantics = 33554432,
    PosixSemantics = 16777216,
    OpenReparsePoint = 2097152,
    OpenNoRecall = 1048576,
    FirstPipeInstance = 524288,
  }
}
