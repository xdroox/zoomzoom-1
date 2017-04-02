// Decompiled with JetBrains decompiler
// Type: flaphx.utils.EFileAccess
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace flaphx.utils
{
  [Flags]
  public enum EFileAccess : uint
  {
    GenericRead = 2147483648,
    GenericWrite = 1073741824,
    GenericExecute = 536870912,
    GenericAll = 268435456,
  }
}
