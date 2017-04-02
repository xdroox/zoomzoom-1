// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Events.ObjectChangedEventPayload
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models.Events
{
  public class ObjectChangedEventPayload
  {
    public object ChangedObject { get; set; }

    public ChangeType ChangeType { get; set; }

    public Type ObjectType { get; set; }

    public ObjectChangedEventPayload()
    {
label_1:
      int num1 = 164480061;
      while (true)
      {
        int num2 = 1332855426;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 671725740 ^ -922260352;
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
