// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.DataItem
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom.Models
{
  public class DataItem
  {
    public string Title { get; private set; }

    public DataItem(string title)
    {
label_1:
      int num1 = 730386992;
      while (true)
      {
        int num2 = 571928933;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1030707297 ^ -388521911;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.Title = title;
    }
  }
}
