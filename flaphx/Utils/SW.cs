// Decompiled with JetBrains decompiler
// Type: flaphx.utils.SW
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace flaphx.utils
{
  internal class SW
  {
    public const int HIDE = 0;
    public const int SHOWNORMAL = 1;
    public const int NORMAL = 1;
    public const int SHOWMINIMIZED = 2;
    public const int SHOWMAXIMIZED = 3;
    public const int MAXIMIZE = 3;
    public const int SHOWNOACTIVATE = 4;
    public const int SHOW = 5;
    public const int MINIMIZE = 6;
    public const int SHOWMINNOACTIVE = 7;
    public const int SHOWNA = 8;
    public const int RESTORE = 9;
    public const int SHOWDEFAULT = 10;
    public const int FORCEMINIMIZE = 11;
    public const int MAX = 11;

    public SW()
    {
label_1:
      int num1 = 693541870;
      while (true)
      {
        int num2 = 1460965626;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 2027504998 ^ -260711612;
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
