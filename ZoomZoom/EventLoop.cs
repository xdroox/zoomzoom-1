// Decompiled with JetBrains decompiler
// Type: ZoomZoom.EventLoop
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public class EventLoop
  {
    private Process proc = (Process) null;
    private DateTime NextProcessCheck = DateTime.MinValue;
    private const uint PM_NOREMOVE = 0;
    private const uint PM_REMOVE = 1;
    private const uint WM_QUIT = 18;

    public void StartListening(int processId)
    {
      this.proc = EventLoop.\u202E⁪⁫⁮⁬⁬‎⁬‮⁮⁯⁯‫⁭‮‪⁭⁬‎‍‮⁯‭‎⁪⁪⁮​‌‭⁯⁯‎‪⁯⁮‎‬⁬⁭‮(processId);
label_1:
      int num1 = -463848210;
      while (true)
      {
        int num2 = -430256878;
        uint num3;
        bool flag1;
        bool flag2;
        EventLoop.MSG lpMsg;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 22U)
        {
          case 0:
          case 18:
            num1 = -1414348933;
            continue;
          case 1:
            int num5 = flag1 ? -115296761 : (num5 = -146779118);
            int num6 = (int) num3 * -1264826008;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num1 = (int) num3 * 1174604931 ^ 477015725;
            continue;
          case 3:
            num1 = (int) num3 * 1960548623 ^ 1972519365;
            continue;
          case 4:
            EventLoop.TranslateMessage(ref lpMsg);
            EventLoop.DispatchMessage(ref lpMsg);
            num1 = -1014631142;
            continue;
          case 5:
            num1 = (int) num3 * -1416368499 ^ 752828808;
            continue;
          case 6:
            flag1 = this.proc == null;
            num1 = (int) num3 * 713642107 ^ -1214473945;
            continue;
          case 7:
            int num7 = !EventLoop.PeekMessage(out lpMsg, IntPtr.Zero, 0U, 0U, 1U) ? -292730886 : (num7 = -1461771633);
            int num8 = (int) num3 * 621186750;
            num1 = num7 ^ num8;
            continue;
          case 8:
            num1 = -1676131808;
            continue;
          case 9:
            goto label_1;
          case 10:
            num4 = this.ProcessRunning(processId) ? 1 : 0;
            break;
          case 11:
            num1 = -2110659835;
            continue;
          case 12:
            num1 = (int) num3 * -2058794514 ^ -33741029;
            continue;
          case 13:
            flag3 = (int) lpMsg.Message == 18;
            num1 = (int) num3 * 1614173457 ^ -210008303;
            continue;
          case 14:
            num1 = (int) num3 * 352840651 ^ -1400670544;
            continue;
          case 15:
            this.NextProcessCheck = DateTime.Now.AddSeconds(5.0);
            num1 = (int) num3 * 2110173823 ^ -1270289503;
            continue;
          case 16:
            if (this.NextProcessCheck < DateTime.Now)
            {
              num1 = -1142335806;
              continue;
            }
            num4 = 0;
            break;
          case 17:
            num1 = (int) num3 * 1657769310 ^ -258432087;
            continue;
          case 19:
            int num9 = !flag2 ? 660707677 : (num9 = 196928778);
            int num10 = (int) num3 * 1818188171;
            num1 = num9 ^ num10;
            continue;
          case 20:
            int num11 = flag3 ? -2023463596 : (num11 = -1094063292);
            int num12 = (int) num3 * -2074575783;
            num1 = num11 ^ num12;
            continue;
          case 21:
            goto label_8;
          default:
            goto label_3;
        }
        flag2 = num4 != 0;
        num1 = -299917909;
      }
label_3:
      return;
label_8:;
    }

    private bool ProcessRunning(int processId)
    {
label_1:
      int num1 = -116919938;
      bool flag1;
      while (true)
      {
        int num2 = -155915443;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            int num5 = !flag2 ? -1779667189 : (num5 = -1499494479);
            int num6 = (int) num3 * -959956827;
            num1 = num5 ^ num6;
            continue;
          case 1:
            if (this.proc != null)
            {
              num1 = (int) num3 * 1873595378 ^ 1447751314;
              continue;
            }
            num4 = 1;
            break;
          case 2:
            num1 = (int) num3 * 1168532840 ^ 1462527327;
            continue;
          case 3:
            flag1 = true;
            num1 = (int) num3 * 651175424 ^ 2101354454;
            continue;
          case 5:
            num4 = EventLoop.\u202B⁭‪‬‎‌‬‬‏⁪‭‎‏⁫⁪‎‎‎‏‫⁭⁯⁮‏⁬‬‎‌‏‪‎⁯‮‫‮⁭⁮‎‌‍‮(this.proc) ? 1 : 0;
            break;
          case 6:
            num1 = -2022609052;
            continue;
          case 7:
            goto label_1;
          case 8:
            flag1 = false;
            num1 = (int) num3 * -2036976510 ^ -1208330051;
            continue;
          case 9:
            num1 = (int) num3 * -896784041 ^ -2092321358;
            continue;
          default:
            goto label_14;
        }
        flag2 = num4 != 0;
        num1 = -1204010771;
      }
label_14:
      return flag1;
    }

    [DllImport("user32.dll")]
    private static extern bool PeekMessage(out EventLoop.MSG lpMsg, IntPtr hwnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

    [DllImport("user32.dll")]
    private static extern bool TranslateMessage(ref EventLoop.MSG lpMsg);

    [DllImport("user32.dll")]
    private static extern IntPtr DispatchMessage(ref EventLoop.MSG lpMsg);

    static Process \u202E⁪⁫⁮⁬⁬‎⁬‮⁮⁯⁯‫⁭‮‪⁭⁬‎‍‮⁯‭‎⁪⁪⁮​‌‭⁯⁯‎‪⁯⁮‎‬⁬⁭‮([In] int obj0)
    {
      return Process.GetProcessById(obj0);
    }

    static bool \u202B⁭‪‬‎‌‬‬‏⁪‭‎‏⁫⁪‎‎‎‏‫⁭⁯⁮‏⁬‬‎‌‏‪‎⁯‮‫‮⁭⁮‎‌‍‮([In] Process obj0)
    {
      return obj0.HasExited;
    }

    private struct MSG
    {
      public IntPtr Hwnd;
      public uint Message;
      public IntPtr WParam;
      public IntPtr LParam;
      public uint Time;
      public System.Drawing.Point Point;
    }
  }
}
