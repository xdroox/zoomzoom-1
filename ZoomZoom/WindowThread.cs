// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WindowThread
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Concurrent;
using System.Threading;

namespace ZoomZoom
{
  public class WindowThread
  {
    public Thread Thread { get; set; }

    public ConcurrentQueue<ZoomEvent> UnprocessedEvents { get; set; }

    public ConcurrentQueue<ZoomEvent> ProcessedEvents { get; set; }

    public WindowManager WindowInspector { get; set; }

    public WindowThread()
    {
label_1:
      int num1 = -1511626322;
      while (true)
      {
        int num2 = -1702476540;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -2120797888 ^ -1667403431;
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
