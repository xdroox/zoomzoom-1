// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Meetings.MeetingOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using ZoomZoom.Models.Activities;

namespace ZoomZoom.Models.Meetings
{
  public class MeetingOptions : ActivityOptions
  {
    public bool RequiresActiveMeeting { get; set; } = false;

    public bool RequiresActiveMeetingWindow { get; set; } = false;

    public bool RequiresHostCapability { get; set; } = false;
  }
}
