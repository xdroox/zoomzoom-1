// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomMeetingEventArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
{
  public class ZoomMeetingEventArgs : ZoomZoomEventArgs
  {
    public string MeetingId { get; set; }

    public MeetingStatus NewMeetingStatus { get; set; }

    public ZoomMeeting Meeting { get; set; }

    public object ChangedProperty { get; set; }

    public ZoomMeetingEventArgs(ZoomMeeting meeting, MeetingStatus status)
    {
label_1:
      int num1 = 1125392722;
      while (true)
      {
        int num2 = 1270546201;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            this.Meeting = meeting;
            this.MeetingId = meeting.MeetingId;
            num1 = (int) num3 * 1750384849 ^ -128515342;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 1500324204 ^ 392135285;
            continue;
          case 4:
            this.NewMeetingStatus = status;
            num1 = (int) num3 * -72092448 ^ -1887743164;
            continue;
          case 5:
            num1 = (int) num3 * -1134211736 ^ -2035072695;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }
  }
}
