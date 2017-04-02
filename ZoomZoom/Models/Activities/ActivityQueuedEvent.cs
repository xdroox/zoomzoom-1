// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.ActivityQueuedEvent
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;

namespace ZoomZoom.Models.Activities
{
  internal class ActivityQueuedEvent : CompositePresentationEvent<ActivityEventBaseArguments>
  {
    public ActivityQueuedEvent()
    {
      base.\u002Ector();
label_1:
      int num1 = -1995170013;
      while (true)
      {
        int num2 = -1264894353;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 1484712886 ^ 1511479207;
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
}
