// Decompiled with JetBrains decompiler
// Type: ZoomZoom.MouseActionProcess
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ZoomZoom
{
  public class MouseActionProcess
  {
    public static IntPtr currentWindow = new IntPtr(0);
    public static BaseWindow lastWin;
    public const int WM_KEYDOWN = 256;
    public const int WH_KEYBOARD_LL = 13;
    public const int WH_MOUSE_LL = 14;

    private void drawFrame(object win)
    {
label_1:
      int num1 = 962303266;
      while (true)
      {
        int num2 = 1474439288;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            MouseActionProcess.\u202B‪⁭⁮​‏‫⁫‬​‬‪⁪​‬‮⁬‌⁪⁮⁬​⁬‮⁪‭⁯‮⁫‪⁪‏‍⁬‫‍‬‭‭‪‮(200);
            num1 = (int) num3 * 89756489 ^ 1093170863;
            continue;
          case 2:
            num1 = (int) num3 * 1396603469 ^ 1693725863;
            continue;
          case 3:
            ControlPaint.DrawReversibleFrame(new Rectangle(((BaseWindow) win).rect.X, ((BaseWindow) win).rect.Y, ((BaseWindow) win).rect.Width, ((BaseWindow) win).rect.Height), Color.Black, FrameStyle.Thick);
            num1 = 1919656720;
            continue;
          case 4:
            int num4 = MouseActionProcess.\u200C⁮‫⁫‮‭‌⁯‬⁭‪‎‮‪⁫⁫‏⁬⁭‫⁫⁫⁫‎‪‎​‏​⁭‌‪‏‏‪⁫‏‏⁭‎‮(MouseActionProcess.\u200C⁯⁫‪⁭‎‪‮‪⁮‬​⁪⁫‏‪⁭‎‎‫‪‌⁮‫⁬‪⁮⁬⁮‮​‪⁬⁫​‎​‍⁮‫‮()) != null ? 637018481 : (num4 = 2066483241);
            int num5 = (int) num3 * -429768636;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    static Thread \u200C⁯⁫‪⁭‎‪‮‪⁮‬​⁪⁫‏‪⁭‎‎‫‪‌⁮‫⁬‪⁮⁬⁮‮​‪⁬⁫​‎​‍⁮‫‮()
    {
      return Thread.CurrentThread;
    }

    static string \u200C⁮‫⁫‮‭‌⁯‬⁭‪‎‮‪⁫⁫‏⁬⁭‫⁫⁫⁫‎‪‎​‏​⁭‌‪‏‏‪⁫‏‏⁭‎‮([In] Thread obj0)
    {
      return obj0.Name;
    }

    static void \u202B‪⁭⁮​‏‫⁫‬​‬‪⁪​‬‮⁬‌⁪⁮⁬​⁬‮⁪‭⁯‮⁫‪⁪‏‍⁬‫‍‬‭‭‪‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }
  }
}
