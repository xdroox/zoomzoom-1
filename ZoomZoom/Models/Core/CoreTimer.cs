// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Core.CoreTimer
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom.Models.Core
{
  public class CoreTimer
  {
    public int DelayTime { get; set; }

    public int IntervalTime { get; set; }

    public Timer Timer { get; set; }

    public CoreTimer.StateInfo SI { get; set; }

    public int Treshold { get; private set; }

    public CoreTimer(int delayTime, int intervalTime, int treshold)
    {
      this.DelayTime = delayTime;
      this.IntervalTime = intervalTime;
      this.Treshold = treshold;
      this.Timer = CoreTimer.\u202C‭‍​‭⁮⁫⁬⁭⁪‎‏⁯‏‬‮‫⁫​⁯‮‌‭‍⁪‭⁭⁬‌⁮⁮‬‍⁫⁯‎‮⁪‏⁮‮(new TimerCallback(this.TimerCallbackWorker), (object) new CoreTimer.StateInfo(), delayTime, intervalTime);
    }

    public void TimerCallbackWorker(object state)
    {
      CoreTimer.StateInfo stateInfo = state as CoreTimer.StateInfo;
label_1:
      int num1 = 1844677376;
      while (true)
      {
        int num2 = 1780467679;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            num1 = (int) num3 * 714261315 ^ -1382257448;
            continue;
          case 1:
            num1 = (int) num3 * 1959078765 ^ 39724846;
            continue;
          case 2:
            int num4 = stateInfo == null ? 1790265158 : (num4 = 1700496424);
            int num5 = (int) num3 * -1490685558;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_13;
          case 4:
            num1 = 580506520;
            continue;
          case 5:
            goto label_3;
          case 6:
            goto label_1;
          case 7:
            int num6 = stateInfo.ExecutionCounter <= this.Treshold ? 430867403 : (num6 = 2026814832);
            int num7 = (int) num3 * -1000736146;
            num1 = num6 ^ num7;
            continue;
          case 8:
            num1 = (int) num3 * -1809509743 ^ 1981783032;
            continue;
          case 9:
            num1 = (int) num3 * -574454370 ^ 124590310;
            continue;
          case 10:
            num1 = (int) num3 * -394321661 ^ -838880987;
            continue;
          case 11:
            ++stateInfo.ExecutionCounter;
            num1 = 1900889041;
            continue;
          case 12:
            CoreTimer.\u200D‮‌⁭⁭‪‭⁯⁬⁫‪⁯⁫‪‭‭⁬⁬‪‏⁬‫‪‎‫⁪‪⁭⁬⁭⁭‌⁯⁯⁫‮⁪‍‍‏‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1311659482U), (object) stateInfo.ExecutionCounter, (object) CoreTimer.\u202C⁮⁬‌‍‌‮‮⁬‏⁪‏⁫⁮‏‮⁬⁯‍‬​⁬⁭‭⁯‬‏‍​‍‬‌‪‎‍‭⁫‪‫‫‮((object) stateInfo));
            num1 = (int) num3 * 1644155924 ^ -157825108;
            continue;
          case 13:
            num1 = (int) num3 * -1251116407 ^ -571155378;
            continue;
          case 14:
            CoreTimer.\u200F‫‭⁬‎‫‍⁭‭‮‬⁮‪⁪‎⁮‪⁫⁭‍⁮‍⁬‏⁬‏‪⁭‬​‍⁪‬⁭‮‎⁯⁯‏⁯‮(this.Timer, -1, -1);
            CoreTimer.\u200C‍⁮‌⁫⁯​‮‎⁯⁫‍⁫‪‮‎‍⁮⁪⁪‎⁪​‏⁭‪‭⁪⁮‬‍‮⁫⁭⁮‍⁬⁬‏⁯‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1823382722U), (object) this.Treshold);
            num1 = (int) num3 * 751065992 ^ 1231680157;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_3:
      return;
label_13:
      throw CoreTimer.\u206F‫⁬‭⁭‏⁯‏‮‭‬‬‬​‏​⁫‏⁫‌‏‏⁭⁫‏‫‪‫‪‎⁮⁬⁫‬‭‏‍⁫⁮⁭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(813700913U));
    }

    static Timer \u202C‭‍​‭⁮⁫⁬⁭⁪‎‏⁯‏‬‮‫⁫​⁯‮‌‭‍⁪‭⁭⁬‌⁮⁮‬‍⁫⁯‎‮⁪‏⁮‮([In] TimerCallback obj0, [In] object obj1, [In] int obj2, [In] int obj3)
    {
      return new Timer(obj0, obj1, obj2, obj3);
    }

    static ArgumentNullException \u206F‫⁬‭⁭‏⁯‏‮‭‬‬‬​‏​⁫‏⁫‌‏‏⁭⁫‏‫‪‫‪‎⁮⁬⁫‬‭‏‍⁫⁮⁭‮([In] string obj0)
    {
      return new ArgumentNullException(obj0);
    }

    static bool \u200F‫‭⁬‎‫‍⁭‭‮‬⁮‪⁪‎⁮‪⁫⁭‍⁮‍⁬‏⁬‏‪⁭‬​‍⁪‬⁭‮‎⁯⁯‏⁯‮([In] Timer obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Change(obj1, obj2);
    }

    static void \u200C‍⁮‌⁫⁯​‮‎⁯⁫‍⁫‪‮‎‍⁮⁪⁪‎⁪​‏⁭‪‭⁪⁮‬‍‮⁫⁭⁮‍⁬⁬‏⁯‮([In] string obj0, [In] object obj1)
    {
      Console.WriteLine(obj0, obj1);
    }

    static string \u202C⁮⁬‌‍‌‮‮⁬‏⁪‏⁫⁮‏‮⁬⁯‍‬​⁬⁭‭⁯‬‏‍​‍‬‌‪‎‍‭⁫‪‫‫‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static void \u200D‮‌⁭⁭‪‭⁯⁬⁫‪⁯⁫‪‭‭⁬⁬‪‏⁬‫‪‎‫⁪‪⁭⁬⁭⁭‌⁯⁯⁫‮⁪‍‍‏‮([In] string obj0, [In] object obj1, [In] object obj2)
    {
      Console.WriteLine(obj0, obj1, obj2);
    }

    public class StateInfo
    {
      public int ExecutionCounter { get; set; }

      public DateTime LastRun
      {
        get
        {
label_1:
          int num1 = 976420485;
          DateTime now;
          while (true)
          {
            int num2 = 1258289646;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_1;
              case 2:
                now = DateTime.Now;
                num1 = (int) num3 * -683860992 ^ 968876082;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return now;
        }
      }

      public StateInfo()
      {
label_1:
        int num1 = -1333285531;
        while (true)
        {
          int num2 = -10295327;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * -194485284 ^ -1606671492;
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

      public override string ToString()
      {
label_1:
        int num1 = 1383406734;
        string str;
        while (true)
        {
          int num2 = 1816523269;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              str = this.LastRun.ToString();
              num1 = (int) num3 * -2073161009 ^ -1560549219;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return str;
      }
    }
  }
}
