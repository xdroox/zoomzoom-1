// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.STATask
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace ZoomZoom.Common
{
  public static class STATask
  {
    internal static Task StartSTATask(Action func)
    {
label_1:
      int num1 = 1591523470;
      Task task;
      while (true)
      {
        int num2 = 597204183;
        uint num3;
        Thread thread;
        Action func1;
        TaskCompletionSource<object> tcs;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            thread = STATask.\u206C‎‫‪⁮‫‪‌‫‎⁯⁮​‪‏‌⁬‪‫⁬⁪‎‌‌‏‫‬​⁬‮⁮⁪‎‌⁫‭⁪⁫‪⁭‮((ThreadStart) (() =>
            {
              try
              {
                func1.Invoke();
label_2:
                int num2 = -493841776;
                while (true)
                {
                  int num3 = -1381166500;
                  uint num4;
                  switch ((num4 = (uint) (num2 ^ num3)) % 5U)
                  {
                    case 0:
                      goto label_4;
                    case 1:
                      num2 = (int) num4 * -1076496987 ^ -37176539;
                      continue;
                    case 2:
                      tcs.SetResult((object) null);
                      num2 = (int) num4 * -1801168644 ^ 305334788;
                      continue;
                    case 3:
                      goto label_2;
                    case 4:
                      num2 = (int) num4 * -1893068396 ^ 966238728;
                      continue;
                    default:
                      goto label_9;
                  }
                }
label_9:
                return;
label_4:;
              }
              catch (Exception ex)
              {
                tcs.SetException(ex);
              }
            }));
            num1 = (int) num3 * -558339090 ^ -1667042675;
            continue;
          case 1:
            func1 = func;
            num1 = (int) num3 * 717226805 ^ -1903794170;
            continue;
          case 2:
            STATask.\u202C‫‪⁯‪⁯‭‬‮⁮‍⁪‌⁬⁫⁯‬‌‪‎‪‫‬⁬‏⁬‪⁭‮‍​⁭‪‬‪⁬‭‪⁬⁯‮(thread, ApartmentState.STA);
            STATask.\u200D‮⁫‌‪⁫‎‭⁫‭⁯⁬⁯⁭‭‏‫‭‬⁫‬​‮​⁯‌‮⁭‌⁭⁫⁪‪‫‮⁯‭⁪‭⁮‮(thread);
            num1 = (int) num3 * -1449259546 ^ 1261772541;
            continue;
          case 4:
            num1 = (int) num3 * 2088368728 ^ -755096336;
            continue;
          case 5:
            goto label_1;
          case 6:
            task = (Task) tcs.get_Task();
            num1 = (int) num3 * -900422368 ^ -113973036;
            continue;
          case 7:
            tcs = new TaskCompletionSource<object>();
            num1 = (int) num3 * -1896781215 ^ 996764640;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return task;
    }

    static Thread \u206C‎‫‪⁮‫‪‌‫‎⁯⁮​‪‏‌⁬‪‫⁬⁪‎‌‌‏‫‬​⁬‮⁮⁪‎‌⁫‭⁪⁫‪⁭‮([In] ThreadStart obj0)
    {
      return new Thread(obj0);
    }

    static void \u202C‫‪⁯‪⁯‭‬‮⁮‍⁪‌⁬⁫⁯‬‌‪‎‪‫‬⁬‏⁬‪⁭‮‍​⁭‪‬‪⁬‭‪⁬⁯‮([In] Thread obj0, [In] ApartmentState obj1)
    {
      obj0.SetApartmentState(obj1);
    }

    static void \u200D‮⁫‌‪⁫‎‭⁫‭⁯⁬⁯⁭‭‏‫‭‬⁫‬​‮​⁯‌‮⁭‌⁭⁫⁪‪‫‮⁯‭⁪‭⁮‮([In] Thread obj0)
    {
      obj0.Start();
    }
  }
}
