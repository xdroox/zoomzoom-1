// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Chats.ChatLinkObject
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models.Chats
{
  public class ChatLinkObject
  {
    public ActivityBase Activity { get; set; }

    public string Message { get; set; }

    public string ReceiverName { get; set; }

    public string SenderName { get; set; }

    public string MeetingId { get; set; }

    public DateTime Sent { get; set; }

    public Action Callback { get; set; }
  }
}
