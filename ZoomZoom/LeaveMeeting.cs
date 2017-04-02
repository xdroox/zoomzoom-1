// Decompiled with JetBrains decompiler
// Type: ZoomZoom.LeaveMeeting
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace ZoomZoom
{
  public class LeaveMeeting : ActivityBase
  {
    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -506167270;
        TraceType traceType;
        while (true)
        {
          int num2 = -1768582092;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1198320352 ^ 1121833339;
              continue;
            case 2:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -399021566 ^ 1902604073;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public LeaveMeeting()
    {
label_1:
      int num1 = 979181031;
      DateTime now;
      while (true)
      {
        int num2 = 1860766816;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            now = DateTime.Now;
            num1 = (int) num3 * 1373121029 ^ -2011650944;
            continue;
          case 1:
            num1 = (int) num3 * -176800283 ^ -415908594;
            continue;
          case 2:
            goto label_1;
          case 4:
            num1 = (int) num3 * 393845791 ^ 1454485798;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      ActivityBase.endTime = now.AddSeconds(2.0);
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = 92695733;
      while (true)
      {
        int num2 = 928548532;
        uint num3;
        ZoomWindow zoomWindow;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            this.WaitForEvent(ZoomEventType.Show, ZoomWindowType.AccountPanel, 5.0);
            num1 = (int) num3 * -1588500427 ^ 2065171171;
            continue;
          case 2:
            num1 = (int) num3 * 1910119292 ^ -217282635;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            zoomWindow = (ZoomWindow) Enumerable.FirstOrDefault<ZoomWindow>((IEnumerable<M0>) this.Engine.SharedData.ActiveWindows, (Func<M0, bool>) (LeaveMeeting.\u003C\u003Ec.\u003C\u003E9__3_0 ?? (LeaveMeeting.\u003C\u003Ec.\u003C\u003E9__3_0 = new Func<ZoomWindow, bool>((object) LeaveMeeting.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CExecuteLogic\u003Eb__3_0)))));
            int num4;
            num1 = num4 = zoomWindow == null ? 594335753 : (num4 = 922657809);
            continue;
          case 4:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(522675794U));
            num1 = 459019898;
            continue;
          case 5:
            num1 = (int) num3 * -1288946656 ^ 234735877;
            continue;
          case 6:
            zoomWindow.Close(false, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2468418288U));
            num1 = (int) num3 * 1172461453 ^ 1989115351;
            continue;
          case 7:
            num1 = (int) num3 * 783230695 ^ -849444061;
            continue;
          case 8:
            goto label_3;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = -2100176822;
      bool flag;
      while (true)
      {
        int num2 = -251382767;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = true;
            num1 = (int) num3 * -2076433116 ^ 1920909365;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    internal override void ResetProperties()
    {
    }
  }
}
