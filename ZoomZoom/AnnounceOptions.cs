// Decompiled with JetBrains decompiler
// Type: ZoomZoom.AnnounceOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
{
  public class AnnounceOptions
  {
    private bool leaveWrongMeeting = false;
    private bool leaveAfterMessage = true;
    private bool findButtonsWhenMissing = true;
    private string meetingId = string.Empty;
    private string message = string.Empty;

    public bool FindButtonsWhenMissing
    {
      get
      {
label_1:
        int num1 = 416299982;
        bool buttonsWhenMissing;
        while (true)
        {
          int num2 = 1732380227;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              buttonsWhenMissing = this.findButtonsWhenMissing;
              num1 = (int) num3 * 1321282146 ^ 1329947457;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return buttonsWhenMissing;
      }
      set
      {
        this.findButtonsWhenMissing = value;
      }
    }

    public bool LeaveWrongMeeting
    {
      get
      {
label_1:
        int num1 = 372863031;
        bool leaveWrongMeeting;
        while (true)
        {
          int num2 = 1427245769;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1164582851 ^ -1727571828;
              continue;
            case 2:
              leaveWrongMeeting = this.leaveWrongMeeting;
              num1 = (int) num3 * -1821512178 ^ 776930392;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return leaveWrongMeeting;
      }
      set
      {
        this.leaveWrongMeeting = value;
      }
    }

    public bool LeaveAfterMessage
    {
      get
      {
label_1:
        int num1 = 1924712662;
        bool leaveAfterMessage;
        while (true)
        {
          int num2 = 504975808;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              leaveAfterMessage = this.leaveAfterMessage;
              num1 = (int) num3 * 910747345 ^ -1017137883;
              continue;
            case 3:
              num1 = (int) num3 * 402332317 ^ 278303446;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return leaveAfterMessage;
      }
      set
      {
        this.leaveAfterMessage = value;
      }
    }

    public string MeetingId
    {
      get
      {
label_1:
        int num1 = -192952832;
        string meetingId;
        while (true)
        {
          int num2 = -898550103;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              meetingId = this.meetingId;
              num1 = (int) num3 * 627810864 ^ -1527671289;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingId;
      }
      set
      {
        this.meetingId = value;
      }
    }

    public string Message
    {
      get
      {
label_1:
        int num1 = 1391506867;
        string message;
        while (true)
        {
          int num2 = 1747001446;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              message = this.message;
              num1 = (int) num3 * -1029111686 ^ 1018121610;
              continue;
            case 2:
              num1 = (int) num3 * -922788521 ^ -332356421;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return message;
      }
      set
      {
        this.message = value;
      }
    }
  }
}
