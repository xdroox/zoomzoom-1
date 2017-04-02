// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Windows.PreviousWindowEvent
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models.Windows
{
  public class PreviousWindowEvent
  {
    public ZoomWindowType ZoomWindowType { get; set; }

    public ZoomEventType ZoomEventType { get; set; }

    public IntPtr Handle { get; set; }

    public bool MovedMainWindow { get; internal set; }
  }
}
