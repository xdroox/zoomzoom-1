// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.JoinAttack
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace ZoomZoom.Models.Activities
{
  public class JoinAttack : ActivityBase
  {
    private DateTime lastExecuted = DateTime.MinValue;
    private string meetingId;

    public string MeetingId
    {
      get
      {
        string meetingId = this.meetingId;
label_1:
        int num1 = -532978258;
        while (true)
        {
          int num2 = -1618111446;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1694623499 ^ 1567715628;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingId;
      }
      set
      {
        this.meetingId = value;
label_1:
        int num1 = -809646669;
        while (true)
        {
          int num2 = -1244470103;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1698286874U));
              num1 = (int) num3 * 599495590 ^ 122389113;
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

    public JoinAttack(ZoomMeeting meeting)
    {
label_1:
      int num1 = -490142458;
      while (true)
      {
        int num2 = -1169662982;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this.EndTime = DateTime.Now.AddSeconds(30.0);
            num1 = (int) num3 * 580121055 ^ 1565425854;
            continue;
          case 1:
            this.MeetingId = meeting.MeetingId;
            num1 = (int) num3 * 1319808130 ^ 1869428812;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 1182728171 ^ 733025434;
            continue;
          case 5:
            this.RequiresAuthorization = true;
            num1 = (int) num3 * 1654303704 ^ -1552558533;
            continue;
          case 6:
            num1 = (int) num3 * 1084289943 ^ 1688238813;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    protected override void ExecuteLogic()
    {
label_9:
      int num1 = !this.ContinueExecution() ? -1318204892 : (num1 = -534662937);
      while (true)
      {
        int num2 = -1601840425;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = -534662937;
            continue;
          case 1:
            int num4 = !flag ? -257393211 : (num4 = -629542010);
            int num5 = (int) num3 * 2128805923;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * 1279836672 ^ -1246245890;
            continue;
          case 3:
            goto label_9;
          case 4:
            num1 = -777993329;
            continue;
          case 5:
            this.JoinAttackTaskAsync(this.Token);
            num1 = -323749058;
            continue;
          case 6:
            num1 = (int) num3 * 1384941817 ^ -963460118;
            continue;
          case 7:
            goto label_3;
          case 8:
            flag = this.lastExecuted.AddSeconds(1.0) < DateTime.Now;
            num1 = (int) num3 * 551440783 ^ 793881078;
            continue;
          case 9:
            this.ProcessEvents();
            num1 = (int) num3 * -1161407230 ^ -1849854237;
            continue;
          case 10:
            this.lastExecuted = DateTime.Now;
            num1 = (int) num3 * -280223169 ^ 125767815;
            continue;
          case 11:
            Thread.Sleep(50);
            num1 = (int) num3 * -1640409738 ^ -1885353302;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    internal Task JoinAttackTaskAsync(CancellationToken token)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      JoinAttack.\u003CJoinAttackTaskAsync\u003Ed__7 attackTaskAsyncD7 = new JoinAttack.\u003CJoinAttackTaskAsync\u003Ed__7();
label_1:
      int num1 = -1906427834;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        int num2 = -848515030;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            attackTaskAsyncD7.\u003C\u003E4__this = this;
            num1 = (int) num3 * -468921223 ^ -680641861;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            attackTaskAsyncD7.\u003C\u003E1__state = -1;
            // ISSUE: reference to a compiler-generated field
            tBuilder = attackTaskAsyncD7.\u003C\u003Et__builder;
            num1 = (int) num3 * 578767230 ^ -1392202072;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            attackTaskAsyncD7.token = token;
            // ISSUE: reference to a compiler-generated field
            attackTaskAsyncD7.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num1 = (int) num3 * 2045742645 ^ 982840469;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      // ISSUE: explicit reference operation
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      ((AsyncTaskMethodBuilder) @tBuilder).Start<JoinAttack.\u003CJoinAttackTaskAsync\u003Ed__7>((M0&) @attackTaskAsyncD7);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      return ((AsyncTaskMethodBuilder) @attackTaskAsyncD7.\u003C\u003Et__builder).get_Task();
    }

    protected Task StartSTATask(Action func)
    {
label_1:
      int num1 = -396204695;
      Task task;
      while (true)
      {
        int num2 = -1882111531;
        uint num3;
        Thread thread;
        TaskCompletionSource<object> tcs;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 354809277 ^ 453180871;
            continue;
          case 1:
            JoinAttack.\u206C‭⁬⁮‭‌⁮‪⁮‪‌‬⁫​​‫⁪‍‍‬‎‭⁭⁭⁬‮‭‭‎‌⁪‍‌‭‌⁯‎‫‬⁯‮(thread);
            num1 = (int) num3 * 345773881 ^ -1515043857;
            continue;
          case 2:
            tcs = new TaskCompletionSource<object>();
            thread = JoinAttack.\u206F⁪⁭⁪‌‍⁫⁮‍‮⁯⁯​‮‭‬‎‮‍⁫⁬​⁯⁫‭⁭‫‭‌‍‭‪‏‮‏‌‬⁫⁬‮((ThreadStart) (() =>
            {
              try
              {
label_2:
                int num2 = 2135717351;
                while (true)
                {
                  int num3 = 1344962558;
                  uint num4;
                  switch ((num4 = (uint) (num2 ^ num3)) % 6U)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      func.Invoke();
                      num2 = (int) num4 * 2115475405 ^ 1380241215;
                      continue;
                    case 2:
                      num2 = (int) num4 * -2045662633 ^ 384423091;
                      continue;
                    case 3:
                      goto label_17;
                    case 4:
                      tcs.SetResult((object) null);
                      num2 = (int) num4 * 1162006518 ^ -2028136351;
                      continue;
                    case 5:
                      num2 = (int) num4 * 1865279441 ^ 819704023;
                      continue;
                    default:
                      goto label_13;
                  }
                }
label_13:
                return;
label_17:;
              }
              catch (Exception ex)
              {
label_11:
                int num2 = 1300745360;
                while (true)
                {
                  int num3 = 1344962558;
                  uint num4;
                  switch ((num4 = (uint) (num2 ^ num3)) % 5U)
                  {
                    case 0:
                      num2 = (int) num4 * -1722933173 ^ -11178998;
                      continue;
                    case 1:
                      tcs.SetException(ex);
                      num2 = (int) num4 * 1227794919 ^ 108165958;
                      continue;
                    case 2:
                      num2 = (int) num4 * -265963207 ^ 1555775733;
                      continue;
                    case 3:
                      goto label_9;
                    case 4:
                      goto label_11;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return;
label_9:;
              }
            }));
            JoinAttack.\u202C‪‭‮‬⁮‎⁪​‏⁪​⁪⁪‫⁮‌‪⁮‎‪‌‮‪⁮‬⁬‍‎‮‫⁪‫⁪⁭⁭‫⁫‍‭‮(thread, ApartmentState.STA);
            num1 = (int) num3 * 1677934264 ^ 653834358;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1376066048 ^ 1605591330;
            continue;
          case 5:
            task = (Task) tcs.get_Task();
            num1 = (int) num3 * 68481832 ^ -721269245;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return task;
    }

    private void ProcessEvents()
    {
      try
      {
label_2:
        int num1 = -496590015;
        while (true)
        {
          int num2 = -732586811;
          uint num3;
          bool flag1;
          ZoomEvent pendingEvent;
          bool flag2;
          bool flag3;
          ZoomWindow window;
          switch ((num3 = (uint) (num1 ^ num2)) % 21U)
          {
            case 0:
              int num4 = flag1 ? 414028493 : (num4 = 1409841062);
              int num5 = (int) num3 * 1402749695;
              num1 = num4 ^ num5;
              continue;
            case 1:
              window.Close(false, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1577954334U));
              num1 = (int) num3 * -1183107380 ^ 847497479;
              continue;
            case 2:
              goto label_2;
            case 3:
              num1 = -1154556989;
              continue;
            case 4:
              flag3 = window != null;
              num1 = (int) num3 * 660387139 ^ 583670705;
              continue;
            case 5:
              num1 = (int) num3 * -1939081024 ^ -289842571;
              continue;
            case 6:
              num1 = (int) num3 * 593849314 ^ 817729011;
              continue;
            case 7:
              window = this.Engine.GetWindow(ZoomWindowType.Meeting);
              num1 = -277729667;
              continue;
            case 8:
              int num6 = !ZoomZoom.NativeMethods.DestroyWindow(pendingEvent.WindowHandle) ? 1956356428 : (num6 = 357692342);
              int num7 = (int) num3 * 480920484;
              num1 = num6 ^ num7;
              continue;
            case 9:
              CoreObject.log.Debug((object) (\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4177809707U) + ZoomZoom.NativeMethods.GetLastError().ToString()));
              num1 = (int) num3 * 897252412 ^ -1378669327;
              continue;
            case 10:
              num1 = (int) num3 * 463643943 ^ 457655370;
              continue;
            case 11:
              num1 = (int) num3 * 1312286524 ^ 1437950073;
              continue;
            case 12:
              JoinAttack.\u202C‍‎⁭⁪⁪‌⁪‪‪‭‍‪⁫‌⁪‏‭⁭‬⁭⁯⁬‬⁯‏‪⁪‌‏‫​‏⁬‪‪‍‭⁪‍‮(CoreObject.log, (object) JoinAttack.\u206A⁭‪‫‪⁮​⁯​​‎⁯‏‌‫‌‫‍‍‫‬⁯‎⁬⁮⁭‪‍‍‍⁪‎⁮‫⁪‪‬‏⁪⁬‮((object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3309255995U), (object) pendingEvent));
              num1 = (int) num3 * 914932407 ^ 487017949;
              continue;
            case 13:
              num1 = (int) num3 * 2096319401 ^ -1342819766;
              continue;
            case 14:
              goto label_31;
            case 15:
              pendingEvent = this.GetPendingEvent();
              flag2 = pendingEvent != null;
              num1 = (int) num3 * -745465066 ^ 1005877846;
              continue;
            case 16:
              int num8 = flag3 ? -1653590273 : (num8 = -969085820);
              int num9 = (int) num3 * -873608805;
              num1 = num8 ^ num9;
              continue;
            case 17:
              num1 = -1417451008;
              continue;
            case 18:
              this.Trace(TraceType.Activity, JoinAttack.\u200B⁪‌‌‪‎⁪‬‌​‫‏‏‫‏‫⁮‬‪⁭‭⁯⁬⁫‮⁬‏​‍⁬‬⁮‭⁫‮‫⁭⁫⁯‌‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4033050755U), (object) pendingEvent.WindowHandle));
              num1 = (int) num3 * 911242218 ^ 1378243773;
              continue;
            case 19:
              int num10 = !flag2 ? -890159805 : (num10 = -180505459);
              int num11 = (int) num3 * -114012311;
              num1 = num10 ^ num11;
              continue;
            case 20:
              flag1 = JoinAttack.\u206C‪⁭‫‫‫‌⁪⁮‬‬‮⁮⁮‭‮‫‮⁮‏‮‍⁪⁫⁬‌‬​‫⁯‮⁮‏‍​‎‭‬‌‭‮(pendingEvent.WindowTitle, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3960671279U));
              num1 = (int) num3 * 1393779797 ^ -438026158;
              continue;
            default:
              goto label_28;
          }
        }
label_28:
        return;
label_31:;
      }
      catch (Exception ex)
      {
label_26:
        int num1 = -1271562248;
        while (true)
        {
          int num2 = -732586811;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_26;
            case 1:
              num1 = (int) num3 * 1530565629 ^ -2109438830;
              continue;
            case 2:
              num1 = (int) num3 * 1211072160 ^ 1934387426;
              continue;
            case 3:
              goto label_24;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_24:;
      }
    }

    private void InitiateJoin(object meetingId)
    {
      try
      {
        JoinAttack.\u206F‫‮​‮‌‏‮⁮⁫⁯⁫‪‭​⁮⁪‫‪⁬‪‍⁪​⁮⁪‬‌⁮⁯⁭‮⁮‍‬‌‎‪‌‮(this.Engine.Settings.ZoomExePath, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2032981318U));
label_2:
        int num1 = -1262958237;
        while (true)
        {
          int num2 = -1095072986;
          uint num3;
          ProcessStartInfo processStartInfo1;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              JoinAttack.\u202C⁪⁮⁫‮‪‬​‪⁭⁭‎⁯⁪‏‭‭‬‌‏⁭‌⁮‭‭⁪⁭⁬⁫‭⁮‬‭⁯‭‎‪‭‎⁭‮(processStartInfo1);
              num1 = (int) num3 * 1711312795 ^ 555603328;
              continue;
            case 1:
              string str1 = JoinAttack.\u200B⁪‌‌‪‎⁪‬‌​‫‏‏‫‏‫⁮‬‪⁭‭⁯⁬⁫‮⁬‏​‍⁬‬⁮‭⁫‮‫⁭⁫⁯‌‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3150945443U), meetingId);
              ProcessStartInfo processStartInfo2 = JoinAttack.\u206C⁭‬‌‌‍‌⁬​‏‪⁭‎⁮‍⁬⁮⁮⁮⁭⁯‍‬⁬‎‍‏‎‪⁯‍‪‬‬‮‎​‫‍‍‮();
              string str2 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3204904539U);
              JoinAttack.\u206B‎⁬‪‫‌⁪‪⁫‮‎‪⁯⁭⁭⁪⁬‎⁮‬‮⁫‬‬‬‏⁭‎‫‬‏‌‭​‌‌⁯‭‎‫‮(processStartInfo2, str2);
              string str3 = JoinAttack.\u200B⁪‌‌‪‎⁪‬‌​‫‏‏‫‏‫⁮‬‪⁭‭⁯⁬⁫‮⁬‏​‍⁬‬⁮‭⁫‮‫⁭⁫⁯‌‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3987318200U), (object) str1);
              JoinAttack.\u206A‍‌​‌‏‍‎⁮⁪‫‏⁪⁯‫⁭‫⁪‍⁯‌‫⁮‬⁮⁬‪‮⁫‌‫‪‍⁫‮‫⁪‎⁪‎‮(processStartInfo2, str3);
              int num4 = 1;
              JoinAttack.\u206E‭‬‍‬⁫‮‌⁪⁪​‍‭⁬⁪⁮‎⁯⁮⁭‫‏‪‫‏⁯‬‎‭⁯‬‭⁯​​‏⁭⁪‌⁭‮(processStartInfo2, (ProcessWindowStyle) num4);
              int num5 = 0;
              JoinAttack.\u202A⁫⁫⁫⁮⁪‬‏‬⁫‫⁯‍‏⁭‭‏⁫​‌⁮‏⁭⁬‎‬⁬⁪⁯‮⁫‫⁪‮⁯⁪‎‎‭⁬‮(processStartInfo2, num5 != 0);
              processStartInfo1 = processStartInfo2;
              num1 = (int) num3 * -945467938 ^ 1309583868;
              continue;
            case 2:
              goto label_14;
            case 3:
              goto label_2;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_14:;
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -1707898984;
        while (true)
        {
          int num2 = -1095072986;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_7;
            case 2:
              JoinAttack.\u206B‮⁮⁪​‮‮⁫‮‫‮‪‫⁪⁪⁮‎‬‬‫‎‌⁫‎‫⁮⁬⁫‮⁬⁪⁯⁮⁫‌‎⁯‏‍⁪‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 87917583 ^ 380549467;
              continue;
            case 3:
              num1 = (int) num3 * 794571267 ^ 331022846;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_7:;
      }
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 721376005;
      bool flag;
      while (true)
      {
        int num2 = 2122265436;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1040946908 ^ -2109954269;
            continue;
          case 1:
            flag = !JoinAttack.\u202A‎‪⁪‪⁫⁫‌‎⁫‌‌⁫‏⁭​‬⁫​⁬‮⁭⁭​‪⁭⁮⁮‌‮⁮‬⁬⁮​⁬⁫​⁪⁭‮(this.MeetingId);
            num1 = (int) num3 * 1263744480 ^ -1487855288;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    static Thread \u206F⁪⁭⁪‌‍⁫⁮‍‮⁯⁯​‮‭‬‎‮‍⁫⁬​⁯⁫‭⁭‫‭‌‍‭‪‏‮‏‌‬⁫⁬‮([In] ThreadStart obj0)
    {
      return new Thread(obj0);
    }

    static void \u202C‪‭‮‬⁮‎⁪​‏⁪​⁪⁪‫⁮‌‪⁮‎‪‌‮‪⁮‬⁬‍‎‮‫⁪‫⁪⁭⁭‫⁫‍‭‮([In] Thread obj0, [In] ApartmentState obj1)
    {
      obj0.SetApartmentState(obj1);
    }

    static void \u206C‭⁬⁮‭‌⁮‪⁮‪‌‬⁫​​‫⁪‍‍‬‎‭⁭⁭⁬‮‭‭‎‌⁪‍‌‭‌⁯‎‫‬⁯‮([In] Thread obj0)
    {
      obj0.Start();
    }

    static string \u206A⁭‪‫‪⁮​⁯​​‎⁯‏‌‫‌‫‍‍‫‬⁯‎⁬⁮⁭‪‍‍‍⁪‎⁮‫⁪‪‬‏⁪⁬‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static void \u202C‍‎⁭⁪⁪‌⁪‪‪‭‍‪⁫‌⁪‏‭⁭‬⁭⁯⁬‬⁯‏‪⁪‌‏‫​‏⁬‪‪‍‭⁪‍‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static bool \u206C‪⁭‫‫‫‌⁪⁮‬‬‮⁮⁮‭‮‫‮⁮‏‮‍⁪⁫⁬‌‬​‫⁯‮⁮‏‍​‎‭‬‌‭‮([In] string obj0, [In] string obj1)
    {
      return obj0.Contains(obj1);
    }

    static string \u200B⁪‌‌‪‎⁪‬‌​‫‏‏‫‏‫⁮‬‪⁭‭⁯⁬⁫‮⁬‏​‍⁬‬⁮‭⁫‮‫⁭⁫⁯‌‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u206F‫‮​‮‌‏‮⁮⁫⁯⁫‪‭​⁮⁪‫‪⁬‪‍⁪​⁮⁪‬‌⁮⁯⁭‮⁮‍‬‌‎‪‌‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }

    static ProcessStartInfo \u206C⁭‬‌‌‍‌⁬​‏‪⁭‎⁮‍⁬⁮⁮⁮⁭⁯‍‬⁬‎‍‏‎‪⁯‍‪‬‬‮‎​‫‍‍‮()
    {
      return new ProcessStartInfo();
    }

    static void \u206B‎⁬‪‫‌⁪‪⁫‮‎‪⁯⁭⁭⁪⁬‎⁮‬‮⁫‬‬‬‏⁭‎‫‬‏‌‭​‌‌⁯‭‎‫‮([In] ProcessStartInfo obj0, [In] string obj1)
    {
      obj0.FileName = obj1;
    }

    static void \u206A‍‌​‌‏‍‎⁮⁪‫‏⁪⁯‫⁭‫⁪‍⁯‌‫⁮‬⁮⁬‪‮⁫‌‫‪‍⁫‮‫⁪‎⁪‎‮([In] ProcessStartInfo obj0, [In] string obj1)
    {
      obj0.Arguments = obj1;
    }

    static void \u206E‭‬‍‬⁫‮‌⁪⁪​‍‭⁬⁪⁮‎⁯⁮⁭‫‏‪‫‏⁯‬‎‭⁯‬‭⁯​​‏⁭⁪‌⁭‮([In] ProcessStartInfo obj0, [In] ProcessWindowStyle obj1)
    {
      obj0.WindowStyle = obj1;
    }

    static void \u202A⁫⁫⁫⁮⁪‬‏‬⁫‫⁯‍‏⁭‭‏⁫​‌⁮‏⁭⁬‎‬⁬⁪⁯‮⁫‫⁪‮⁯⁪‎‎‭⁬‮([In] ProcessStartInfo obj0, [In] bool obj1)
    {
      obj0.UseShellExecute = obj1;
    }

    static Process \u202C⁪⁮⁫‮‪‬​‪⁭⁭‎⁯⁪‏‭‭‬‌‏⁭‌⁮‭‭⁪⁭⁬⁫‭⁮‬‭⁯‭‎‪‭‎⁭‮([In] ProcessStartInfo obj0)
    {
      return Process.Start(obj0);
    }

    static void \u206B‮⁮⁪​‮‮⁫‮‫‮‪‫⁪⁪⁮‎‬‬‫‎‌⁫‎‫⁮⁬⁫‮⁬⁪⁯⁮⁫‌‎⁯‏‍⁪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static bool \u202A‎‪⁪‪⁫⁫‌‎⁫‌‌⁫‏⁭​‬⁫​⁬‮⁭⁭​‪⁭⁮⁮‌‮⁮‬⁬⁮​⁬⁫​⁪⁭‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }
  }
}
