// Decompiled with JetBrains decompiler
// Type: ZoomZoom.GCL
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom
{
  internal class GCL
  {
    public const int MENUNAME = -8;
    public const int HBRBACKGROUND = -10;
    public const int HCURSOR = -12;
    public const int HICON = -14;
    public const int HMODULE = -16;
    public const int CBWNDEXTRA = -18;
    public const int CBCLSEXTRA = -20;
    public const int WNDPROC = -24;
    public const int STYLE = -26;
    public const int ATOM = -32;
    public const int HICONSM = -34;
    public const int GCW_ATOM = -32;
    public const int GCL_CBCLSEXTRA = -20;
    public const int GCL_CBWNDEXTRA = -18;
    public const int GCLP_MENUNAME = -8;
    public const int GCLP_HBRBACKGROUND = -10;
    public const int GCLP_HCURSOR = -12;
    public const int GCLP_HICON = -14;
    public const int GCLP_HMODULE = -16;
    public const int GCLP_WNDPROC = -24;
    public const int GCLP_HICONSM = -34;
    public const int GCL_STYLE = -26;

    public GCL()
    {
label_1:
      int num1 = -608973352;
      while (true)
      {
        int num2 = -1970816607;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 397209171 ^ -381691040;
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
