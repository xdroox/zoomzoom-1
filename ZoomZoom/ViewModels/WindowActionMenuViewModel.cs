// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.WindowActionMenuViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom.ViewModels
{
  internal class WindowActionMenuViewModel
  {
    public WindowActionMenuViewModel()
    {
label_1:
      int num1 = 1250303800;
      while (true)
      {
        int num2 = 568326041;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -173145654 ^ 414798426;
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
