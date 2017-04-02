// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Message
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models
{
  public class Message
  {
    public string Text { get; set; }

    public DateTime Timestamp { get; set; }

    public MessageSide Side { get; set; }

    public MessageSide PrevSide { get; set; }

    public Message()
    {
label_1:
      int num1 = 1287592013;
      while (true)
      {
        int num2 = 744582454;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 200971365 ^ -561733925;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.Timestamp = DateTime.Now;
            num1 = (int) num3 * 630512930 ^ -355162284;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }
  }
}
