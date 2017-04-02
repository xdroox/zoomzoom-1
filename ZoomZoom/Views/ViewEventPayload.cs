// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.ViewEventPayload
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Views
{
  internal class ViewEventPayload
  {
    public IntPtr Handle { get; set; }

    public ViewEventType ViewEventType { get; set; }

    public ViewEventPayload(IntPtr handle, ViewEventType eventType)
    {
label_1:
      int num1 = -1252968220;
      while (true)
      {
        int num2 = -980969358;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.ViewEventType = eventType;
            num1 = (int) num3 * 305431673 ^ 168038818;
            continue;
          case 1:
            num1 = (int) num3 * 384218580 ^ -1347207221;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            this.Handle = handle;
            num1 = (int) num3 * -2065568102 ^ 1405803088;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }
  }
}
