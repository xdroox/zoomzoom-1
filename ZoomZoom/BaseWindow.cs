// Decompiled with JetBrains decompiler
// Type: ZoomZoom.BaseWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom
{
  public class BaseWindow
  {
    public IntPtr hWnd;
    public string className;
    public string text;
    public User32.RECT rect;
    public string styles;
    public string extendedStyles;
    public string itemType;
    public IntPtr hMenu;
    public string[] itemStrings;
    public string[] itemStyles;
    public IntPtr parent;
    public IntPtr child;
    public IntPtr owner;
    public IntPtr next;
    public IntPtr previous;

    public BaseWindow()
    {
label_1:
      int num1 = 1481298671;
      while (true)
      {
        int num2 = 848150832;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 6466371 ^ -1556515729;
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

    public static BaseWindow WindowFromPoint(IntPtr handle, POINT pt)
    {
      BaseWindow baseWindow = (BaseWindow) null;
label_1:
      int num1 = 1208534756;
      while (true)
      {
        int num2 = 1225993713;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1188871469 ^ -1189766215;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return baseWindow;
    }

    public static object WindowFromHandle(IntPtr hWnd)
    {
      throw BaseWindow.\u206D‫‭​‎‮‏‬⁫⁭​⁮⁪‬⁫‭⁯‌⁮‌⁬‬‍‎⁪⁫‭‬⁮⁪‎‏‬⁬‭‏‏‪⁪‌‮();
    }

    static NotImplementedException \u206D‫‭​‎‮‏‬⁫⁭​⁮⁪‬⁫‭⁯‌⁮‌⁬‬‍‎⁪⁫‭‬⁮⁪‎‏‬⁬‭‏‏‪⁪‌‮()
    {
      return new NotImplementedException();
    }
  }
}
