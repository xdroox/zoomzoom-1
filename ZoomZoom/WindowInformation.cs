// Decompiled with JetBrains decompiler
// Type: ZoomZoom.WindowInformation
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public class WindowInformation
  {
    public bool IsValid = true;
    public string Caption = string.Empty;
    public string Class = string.Empty;
    public int Height = 0;
    public int Width = 0;
    public List<WindowInformation> ChildWindows = new List<WindowInformation>();
    public List<WindowInformation> SiblingWindows = new List<WindowInformation>();
    public IntPtr Handle;

    public List<IntPtr> ChildWindowHandles
    {
      get
      {
        List<IntPtr> numList;
        try
        {
          IEnumerable<IntPtr> source = (IEnumerable<IntPtr>) Enumerable.Select<WindowInformation, IntPtr>((IEnumerable<M0>) this.ChildWindows.AsEnumerable<WindowInformation>(), (Func<M0, M1>) (WindowInformation.\u003C\u003Ec.\u003C\u003E9__10_0 ?? (WindowInformation.\u003C\u003Ec.\u003C\u003E9__10_0 = new Func<WindowInformation, IntPtr>((object) WindowInformation.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003Cget_ChildWindowHandles\u003Eb__10_0)))));
label_2:
          int num1 = -1118608218;
          while (true)
          {
            int num2 = -1570902079;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 2:
                numList = source.ToList<IntPtr>();
                num1 = (int) num3 * -419234075 ^ -943427650;
                continue;
              default:
                goto label_6;
            }
          }
        }
        catch (Exception ex)
        {
          numList = (List<IntPtr>) null;
        }
label_6:
        return numList;
      }
    }

    public WindowInformation Parent { get; set; }

    public IntPtr ParentHandle
    {
      get
      {
label_1:
        int num1 = 633091557;
        IntPtr num2;
        while (true)
        {
          int num3 = 1452944877;
          uint num4;
          bool flag;
          switch ((num4 = (uint) (num1 ^ num3)) % 7U)
          {
            case 0:
              num2 = IntPtr.Zero;
              num1 = 731868482;
              continue;
            case 1:
              flag = this.Parent != null;
              num1 = (int) num4 * 1963745975 ^ -1962843522;
              continue;
            case 2:
              goto label_1;
            case 4:
              int num5 = !flag ? -661027676 : (num5 = -617992446);
              int num6 = (int) num4 * -592346163;
              num1 = num5 ^ num6;
              continue;
            case 5:
              num2 = this.Parent.Handle;
              num1 = (int) num4 * -17653136 ^ 466183232;
              continue;
            case 6:
              num1 = (int) num4 * 158944209 ^ 1815265183;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return num2;
      }
    }

    public Process Process
    {
      get
      {
        Process process;
        try
        {
          int processId = 0;
label_2:
          int num1 = 1680401649;
          while (true)
          {
            int num2 = 2100488339;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 2:
                WindowInformation.GetWindowThreadProcessId(this.Handle, out processId);
                process = WindowInformation.\u202B‮​⁫⁪‌‌‮⁪‌‌⁪⁭⁬⁯⁯‮​‭⁬‫‌‮⁬‭⁪‌‌‬‫‌‏‮⁭‪‎‭‭‭‮‮(processId);
                num1 = (int) num3 * -853403454 ^ -1539940002;
                continue;
              default:
                goto label_10;
            }
          }
        }
        catch (Exception ex)
        {
label_6:
          int num1 = 1829919026;
          while (true)
          {
            int num2 = 2100488339;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                num1 = (int) num3 * -1104214857 ^ 1786095359;
                continue;
              case 2:
                goto label_6;
              case 3:
                process = (Process) null;
                num1 = (int) num3 * 1076233785 ^ 380278664;
                continue;
              default:
                goto label_10;
            }
          }
        }
label_10:
        return process;
      }
    }

    public List<IntPtr> SiblingWindowHandles
    {
      get
      {
        List<IntPtr> numList;
        try
        {
          IEnumerable<IntPtr> source = (IEnumerable<IntPtr>) Enumerable.Select<WindowInformation, IntPtr>((IEnumerable<M0>) this.SiblingWindows.AsEnumerable<WindowInformation>(), (Func<M0, M1>) (WindowInformation.\u003C\u003Ec.\u003C\u003E9__22_0 ?? (WindowInformation.\u003C\u003Ec.\u003C\u003E9__22_0 = new Func<WindowInformation, IntPtr>((object) WindowInformation.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003Cget_SiblingWindowHandles\u003Eb__22_0)))));
label_2:
          int num1 = -1453049012;
          while (true)
          {
            int num2 = -2050454695;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 2:
                numList = source.ToList<IntPtr>();
                num1 = (int) num3 * -198169252 ^ -1954232726;
                continue;
              default:
                goto label_6;
            }
          }
        }
        catch (Exception ex)
        {
          numList = (List<IntPtr>) null;
        }
label_6:
        return numList;
      }
    }

    public int ThreadID
    {
      get
      {
        int num1;
        try
        {
          int processId = 0;
label_2:
          int num2 = 457832067;
          while (true)
          {
            int num3 = 1417730902;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                num1 = WindowInformation.GetWindowThreadProcessId(this.Handle, out processId);
                num2 = (int) num4 * 1535836867 ^ -729100340;
                continue;
              default:
                goto label_6;
            }
          }
        }
        catch (Exception ex)
        {
          num1 = -1;
        }
label_6:
        return num1;
      }
    }

    public WindowInformation()
    {
label_1:
      int num1 = 1485556176;
      while (true)
      {
        int num2 = 673225143;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1235587546 ^ 552128842;
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

    [DllImport("user32")]
    public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

    public override string ToString()
    {
label_1:
      int num1 = -949413540;
      string str;
      while (true)
      {
        int num2 = -390829475;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1849542555 ^ -1432109770;
            continue;
          case 1:
            str = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2880279071U) + this.Handle.ToString() + \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(848340815U) + this.Handle.ToString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(433560821U)) + \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(408071401U) + this.Caption + \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(516640615U) + this.Class;
            num1 = (int) num3 * -2122293003 ^ 909191636;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    static Process \u202B‮​⁫⁪‌‌‮⁪‌‌⁪⁭⁬⁯⁯‮​‭⁬‫‌‮⁬‭⁪‌‌‬‫‌‏‮⁭‪‎‭‭‭‮‮([In] int obj0)
    {
      return Process.GetProcessById(obj0);
    }
  }
}
