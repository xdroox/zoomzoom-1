// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UnmappedWindowClick
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom
{
  public class UnmappedWindowClick
  {
    public DateTime ClickTime { get; set; }

    public System.Drawing.Point ClickPoint { get; set; }

    public ZoomWindow ClickedWindow { get; set; }

    public ZoomWindow OpenedWindow { get; set; }
  }
}
