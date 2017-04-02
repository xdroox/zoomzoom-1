// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomZoomEventArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;

namespace ZoomZoom
{
  public class ZoomZoomEventArgs : EventArgs
  {
    public ZoomZoomEventType EventType { get; set; }

    public ZoomObjectType EventObjectType { get; set; }

    public string EventDescription { get; set; }

    public IEnumerable<object> ItemsAdded { get; internal set; }

    public IEnumerable<object> ItemsRemoved { get; internal set; }
  }
}
