// Decompiled with JetBrains decompiler
// Type: ZoomZoom.JoinOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
{
  public class JoinOptions
  {
    public bool CancelWhenMeetingInProgress { get; set; } = false;

    public bool CancelWhenMeetingWaitingForHost { get; set; } = false;

    public double SecondsToWaitBeforeTryAgain { get; set; } = 1.0;

    public double SecondsToWaitAfterJoiningBeforeOfficciallyComplete { get; set; } = 0.0;
  }
}
