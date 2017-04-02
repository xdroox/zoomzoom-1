// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MeetingButton
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Generic;

namespace ZoomZoom
{
  public class MeetingButton
  {
    private ZoomButton button = (ZoomButton) null;
    private ZoomMeeting meeting = (ZoomMeeting) null;
    private ZoomWindow meetingWindow = (ZoomWindow) null;

    public ZoomButton Button
    {
      get
      {
        ZoomButton button = this.button;
label_1:
        int num1 = -1726601768;
        while (true)
        {
          int num2 = -2133063850;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 119678387 ^ 2013235109;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return button;
      }
      set
      {
        this.button = value;
      }
    }

    public ZoomMeeting Meeting
    {
      get
      {
label_1:
        int num1 = 1324146591;
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = 1713574082;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              meeting = this.meeting;
              num1 = (int) num3 * -2060926519 ^ 540071493;
              continue;
            case 2:
              num1 = (int) num3 * 1192415984 ^ 643680166;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return meeting;
      }
      set
      {
        this.meeting = value;
      }
    }

    public ZoomWindow MeetingWindow
    {
      get
      {
label_1:
        int num1 = 2111028402;
        ZoomWindow meetingWindow;
        while (true)
        {
          int num2 = 981939462;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingWindow = this.meetingWindow;
              num1 = (int) num3 * 334449971 ^ -1887605610;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingWindow;
      }
      set
      {
        this.meetingWindow = value;
      }
    }

    public MeetingButton()
    {
label_1:
      int num1 = -2036019623;
      while (true)
      {
        int num2 = -826713436;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 2057847212 ^ -1387007073;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 1833552433 ^ 538927079;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public MeetingButton(ZoomMeeting meeting, ZoomButton button)
    {
label_1:
      int num1 = -696454798;
      while (true)
      {
        int num2 = -1831530081;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Button = button;
            num1 = (int) num3 * 791734846 ^ -1295907163;
            continue;
          case 2:
            num1 = (int) num3 * 980859637 ^ 501261883;
            continue;
          case 3:
            this.Meeting = meeting;
            num1 = (int) num3 * 1485137876 ^ 682844648;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    public static List<MeetingButton> Load(string meetingId)
    {
label_1:
      int num1 = 1502347762;
      List<MeetingButton> meetingButtonList;
      while (true)
      {
        int num2 = 1816723303;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            meetingButtonList = new List<MeetingButton>();
            num1 = (int) num3 * -1870518498 ^ 550097327;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return meetingButtonList;
    }
  }
}
