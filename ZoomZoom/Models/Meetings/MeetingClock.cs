// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Meetings.MeetingClock
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom.Models.Meetings
{
  internal class MeetingClock
  {
    private int myVar;

    public int MyProperty
    {
      get
      {
        int var = this.myVar;
label_1:
        int num1 = -1221330215;
        while (true)
        {
          int num2 = -251450712;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -120687150 ^ -1747985755;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return var;
      }
      set
      {
label_1:
        int num1 = 1099022499;
        while (true)
        {
          int num2 = 786641343;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.myVar = value;
              num1 = (int) num3 * 167944148 ^ -688099247;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public MeetingClock()
    {
label_1:
      int num1 = -326888193;
      while (true)
      {
        int num2 = -997032895;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1311156619 ^ -1566032789;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }
  }
}
