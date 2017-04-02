// Decompiled with JetBrains decompiler
// Type: flaphx.utils.WindowInformation
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace flaphx.utils
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
          int num1 = -1192544308;
          while (true)
          {
            int num2 = -1975270371;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                numList = source.ToList<IntPtr>();
                num1 = (int) num3 * 166383773 ^ 1775937702;
                continue;
              default:
                goto label_10;
            }
          }
        }
        catch (Exception ex)
        {
label_6:
          int num1 = -696390318;
          while (true)
          {
            int num2 = -1975270371;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_6;
              case 1:
                num1 = (int) num3 * -39457941 ^ -1552825289;
                continue;
              default:
                goto label_9;
            }
          }
label_9:
          numList = (List<IntPtr>) null;
        }
label_10:
        return numList;
      }
    }

    public WindowInformation Parent { get; set; }

    public IntPtr ParentHandle
    {
      get
      {
        bool flag = this.Parent != null;
label_1:
        int num1 = 2000509173;
        IntPtr num2;
        while (true)
        {
          int num3 = 271950391;
          uint num4;
          switch ((num4 = (uint) (num1 ^ num3)) % 7U)
          {
            case 0:
              num1 = (int) num4 * 1941519740 ^ -259500753;
              continue;
            case 1:
              num2 = IntPtr.Zero;
              num1 = 1716159630;
              continue;
            case 2:
              num1 = (int) num4 * -1341086356 ^ -1070677173;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num5 = flag ? -1544842375 : (num5 = -156099536);
              int num6 = (int) num4 * -514216185;
              num1 = num5 ^ num6;
              continue;
            case 5:
              num2 = this.Parent.Handle;
              num1 = (int) num4 * 561933003 ^ -979143471;
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
label_2:
          int num1 = 2029436355;
          int processId;
          while (true)
          {
            int num2 = 1679952209;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 2:
                processId = 0;
                WindowInformation.GetWindowThreadProcessId(this.Handle, out processId);
                num1 = (int) num3 * -850284203 ^ -3221199;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          process = WindowInformation.\u202A‌‎‌‪‎‍‮‬⁫‮‬⁫‌‪‏⁮‬⁬‮‏⁪⁮‮‮‎‎⁬⁯⁪‮‎‏⁯‭‏⁭⁬⁯⁪‮(processId);
        }
        catch (Exception ex)
        {
label_7:
          int num1 = 1917769590;
          while (true)
          {
            int num2 = 1679952209;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_7;
              case 1:
                process = (Process) null;
                num1 = (int) num3 * -361032499 ^ -2006529017;
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
label_2:
          int num1 = -678928453;
          IEnumerable<IntPtr> source;
          while (true)
          {
            int num2 = -842143411;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                source = (IEnumerable<IntPtr>) Enumerable.Select<WindowInformation, IntPtr>((IEnumerable<M0>) this.SiblingWindows.AsEnumerable<WindowInformation>(), (Func<M0, M1>) (WindowInformation.\u003C\u003Ec.\u003C\u003E9__22_0 ?? (WindowInformation.\u003C\u003Ec.\u003C\u003E9__22_0 = new Func<WindowInformation, IntPtr>((object) WindowInformation.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003Cget_SiblingWindowHandles\u003Eb__22_0)))));
                num1 = -1516209869;
                continue;
              case 2:
                goto label_2;
              default:
                goto label_5;
            }
          }
label_5:
          numList = source.ToList<IntPtr>();
        }
        catch (Exception ex)
        {
label_7:
          int num1 = -670362682;
          while (true)
          {
            int num2 = -842143411;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_7;
              case 1:
                numList = (List<IntPtr>) null;
                num1 = (int) num3 * -2029678110 ^ -2143318403;
                continue;
              case 3:
                num1 = (int) num3 * 1156891295 ^ -911333411;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:
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
          num1 = WindowInformation.GetWindowThreadProcessId(this.Handle, out processId);
        }
        catch (Exception ex)
        {
label_3:
          int num2 = -964491369;
          while (true)
          {
            int num3 = -790041622;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num1 = -1;
                num2 = (int) num4 * -492474642 ^ 265955325;
                continue;
              case 2:
                goto label_3;
              default:
                goto label_6;
            }
          }
        }
label_6:
        return num1;
      }
    }

    [DllImport("user32")]
    public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

    public override string ToString()
    {
label_1:
      int num1 = -787871747;
      string str;
      while (true)
      {
        int num2 = -645728530;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2501270442U) + this.Handle.ToString() + \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3768165735U) + this.Handle.ToString(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(444261139U)) + \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(986470263U) + this.Caption + \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(516640615U) + this.Class;
            num1 = (int) num3 * -1315866956 ^ 1222547544;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return str;
    }

    static Process \u202A‌‎‌‪‎‍‮‬⁫‮‬⁫‌‪‏⁮‬⁬‮‏⁪⁮‮‮‎‎⁬⁯⁪‮‎‏⁯‭‏⁭⁬⁯⁪‮([In] int obj0)
    {
      return Process.GetProcessById(obj0);
    }
  }
}
