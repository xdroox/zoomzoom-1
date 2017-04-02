// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Core.TraceObject
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models.Core
{
  public class TraceObject
  {
    public string Text { get; set; }

    public TraceType TraceType { get; set; }

    public bool ThrewException { get; set; }

    public DateTime EventTime { get; internal set; }
  }
}
