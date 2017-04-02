// Decompiled with JetBrains decompiler
// Type: ZoomZoom.HighlightEventArg
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom
{
  public class HighlightEventArg : EventArgs
  {
    public HighlightInfo Highlight { get; set; }

    public HighlightEventArg()
    {
label_1:
      int num1 = 1914661072;
      while (true)
      {
        int num2 = 830745637;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 97503136 ^ 1849259184;
            continue;
          case 2:
            goto label_3;
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
