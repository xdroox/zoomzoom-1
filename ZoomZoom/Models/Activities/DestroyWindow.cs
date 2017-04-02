// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.DestroyWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;

namespace ZoomZoom.Models.Activities
{
  public class DestroyWindow : ActivityBase
  {
    public override TraceType TraceType
    {
      get
      {
        return TraceType.Activity;
      }
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = -1429295382;
      while (true)
      {
        int num2 = -1611479477;
        uint num3;
        SelectWindow selectWindow;
        bool flag;
        ZoomWindow result;
        switch ((num3 = (uint) (num1 ^ num2)) % 23U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = -12548247;
            continue;
          case 2:
            num1 = (int) num3 * -933018826 ^ -956981214;
            continue;
          case 3:
            this.SetActivityState(selectWindow.ActivityState, selectWindow.Status);
            num1 = (int) num3 * -1648305426 ^ -494782163;
            continue;
          case 4:
            num1 = (int) num3 * 780812049 ^ -1423476753;
            continue;
          case 5:
            ZoomZoom.NativeMethods.DestroyWindow(result.Handle);
            num1 = (int) num3 * 1012134292 ^ -1191433747;
            continue;
          case 6:
            selectWindow = new SelectWindow(new List<ZoomWindowType>()
            {
              ZoomWindowType.Video
            });
            num1 = (int) num3 * 1805284683 ^ -149297064;
            continue;
          case 7:
            num1 = (int) num3 * -1051959149 ^ -1552212641;
            continue;
          case 8:
            num1 = (int) num3 * -2065580932 ^ -1748114902;
            continue;
          case 9:
            num1 = -1639268573;
            continue;
          case 10:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3793110030U));
            num1 = (int) num3 * 523298849 ^ -1612000629;
            continue;
          case 11:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3114797549U));
            num1 = (int) num3 * -1476400902 ^ 729428412;
            continue;
          case 12:
            num1 = (int) num3 * 957145072 ^ 102594969;
            continue;
          case 13:
            int num4 = !flag ? -1450637567 : (num4 = -620504218);
            int num5 = (int) num3 * 51645085;
            num1 = num4 ^ num5;
            continue;
          case 14:
            int num6 = result != null ? 908130473 : (num6 = 810008195);
            int num7 = (int) num3 * -2054817898;
            num1 = num6 ^ num7;
            continue;
          case 15:
            num1 = (int) num3 * 1391745035 ^ -1865135931;
            continue;
          case 16:
            ZoomZoom.NativeMethods.DestroyWindow(new IntPtr(ZoomZoom.NativeMethods.GetParent(result.Parent.ToInt64())));
            ZoomZoom.NativeMethods.DestroyWindow(result.Parent);
            num1 = (int) num3 * 2142260164 ^ 1744968997;
            continue;
          case 17:
            num1 = -161078912;
            continue;
          case 18:
            flag = this.ExecuteSubActivity((ActivityBase) selectWindow, true) == ActivityState.Completed;
            num1 = (int) num3 * 81964066 ^ 1261042731;
            continue;
          case 19:
            num1 = (int) num3 * 541345032 ^ -402770672;
            continue;
          case 20:
            goto label_3;
          case 21:
            result = selectWindow.Result as ZoomWindow;
            num1 = (int) num3 * 1428320302 ^ 1255478683;
            continue;
          case 22:
            num1 = (int) num3 * -1935709800 ^ -356220473;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = -1596365169;
      bool flag;
      while (true)
      {
        int num2 = -1003591411;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1073096218 ^ -1684491624;
            continue;
          case 2:
            flag = true;
            num1 = (int) num3 * 448357371 ^ 1799726570;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }
  }
}
