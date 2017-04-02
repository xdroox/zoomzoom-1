// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.FloodHunt
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace ZoomZoom.Models.Activities
{
  public class FloodHunt : ActivityBase
  {
    private MeetingOptions meetingOptions;

    public new MeetingOptions MeetingOptions
    {
      get
      {
        MeetingOptions meetingOptions = this.meetingOptions;
label_1:
        int num1 = 310520183;
        while (true)
        {
          int num2 = 982252225;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1782669523 ^ 1469892027;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingOptions;
      }
      set
      {
        this.meetingOptions = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 2131602784;
        TraceType traceType;
        while (true)
        {
          int num2 = 471758197;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -245437103 ^ 792372299;
              continue;
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1317790842 ^ 5331419;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    protected override void ExecuteLogic()
    {
      this.EndTime = DateTime.MaxValue;
label_1:
      int num1 = -348847070;
      while (true)
      {
        int num2 = -1107601175;
        uint num3;
        JoinMeeting joinMeeting;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 28U)
        {
          case 0:
            this.Options.DisableHighlighting = true;
            num1 = (int) num3 * -1673597057 ^ -517599465;
            continue;
          case 1:
            int num5;
            num1 = num5 = !this.ContinueExecution() ? -1270141885 : (num5 = -611599198);
            continue;
          case 2:
            FloodHunt.\u206E‪‫‏‫‎⁬​⁫⁭⁫‌⁬‬⁬‌⁯‎⁯⁪⁫⁮⁯‏⁯⁮⁫⁮‫⁮‮⁮‍‌‍⁪​​‬⁬‮(1000);
            num1 = -1528020826;
            continue;
          case 3:
            this.MeetingOptions.RequiresActiveMeetingWindow = false;
            num1 = (int) num3 * -2070373336 ^ 93604329;
            continue;
          case 4:
            this.Options.SaveAfterCapture = true;
            num1 = (int) num3 * 1523955952 ^ -971684249;
            continue;
          case 5:
            this.MeetingOptions.RequiresActiveMeeting = false;
            num1 = (int) num3 * -2308670 ^ -1050069292;
            continue;
          case 6:
            joinMeeting = new JoinMeeting(this.Engine.NextMeeting.MeetingId);
            num1 = (int) num3 * 1915364705 ^ -2091658386;
            continue;
          case 7:
            num1 = (int) num3 * 1847787436 ^ -11741031;
            continue;
          case 8:
            num1 = (int) num3 * 1831734477 ^ 1488333751;
            continue;
          case 9:
            this.Options.DisplayAfterCapture = false;
            num1 = (int) num3 * -2105211232 ^ -837176198;
            continue;
          case 10:
            goto label_1;
          case 11:
            num1 = -225399319;
            continue;
          case 12:
            FloodHunt.\u200B⁫⁬⁬‏‫‭⁬⁪⁬⁬‬‭‍‪‮​‏⁫‌‌‌‭⁬‫‍‎⁫‮​‏‬‬‮‭⁯‌‫⁭⁮‮(FloodHunt.\u200C⁮‫‌⁭⁯‌‭‮⁮⁬‭‮⁪​⁯‭‎‬‭‏⁮⁬‬⁯⁯⁪⁪⁫‪⁬‫‫⁮‬‫‫‮‫⁪‮());
            num1 = (int) num3 * -30923485 ^ 1895009285;
            continue;
          case 13:
            num4 = this.Engine.ActiveMeetingWindow == null ? 1 : 0;
            break;
          case 14:
            num1 = (int) num3 * -89258743 ^ -253036274;
            continue;
          case 15:
            num1 = (int) num3 * -738526842 ^ -1430415494;
            continue;
          case 16:
            num1 = (int) num3 * 1450452359 ^ -491126159;
            continue;
          case 17:
            int num6 = (int) this.ExecuteSubActivity((ActivityBase) joinMeeting, true);
            num1 = (int) num3 * -1999446037 ^ 559704776;
            continue;
          case 18:
            this.Options.MaximumStartCount = 1000;
            num1 = (int) num3 * 655440434 ^ -1666363782;
            continue;
          case 19:
            num1 = (int) num3 * 1411354248 ^ -1616381072;
            continue;
          case 20:
            if (this.Engine.ActiveMeeting != null)
            {
              num1 = (int) num3 * 982252216 ^ 1404823416;
              continue;
            }
            num4 = 1;
            break;
          case 21:
            this.Options.MinimizeEngineView = true;
            num1 = (int) num3 * 285714073 ^ -869326405;
            continue;
          case 22:
            goto label_3;
          case 23:
            num1 = (int) num3 * 1152856336 ^ -581477512;
            continue;
          case 24:
            num1 = (int) num3 * 1278043412 ^ 1158931360;
            continue;
          case 25:
            this.Options.DisableApplyLayout = false;
            num1 = (int) num3 * 1927827121 ^ 1181365552;
            continue;
          case 26:
            num1 = (int) num3 * 789919956 ^ 436744207;
            continue;
          case 27:
            num1 = (int) num3 * -1326676956 ^ 1318837192;
            continue;
          default:
            goto label_33;
        }
        int num7;
        num1 = num7 = num4 == 0 ? -581531913 : (num7 = -1056914507);
      }
label_33:
      return;
label_3:;
    }

    internal override bool Valid()
    {
      throw FloodHunt.\u206E⁬‮‍‍⁪‭‬⁫⁫‮⁮⁫⁬⁮‬‌‫‮⁯‌⁭‭⁫‏‌‪⁫⁬⁬‫⁪​‫⁫⁮⁭⁬⁫‏‮();
    }

    static CancellationTokenSource \u200C⁮‫‌⁭⁯‌‭‮⁮⁬‭‮⁪​⁯‭‎‬‭‏⁮⁬‬⁯⁯⁪⁪⁫‪⁬‫‫⁮‬‫‫‮‫⁪‮()
    {
      return new CancellationTokenSource();
    }

    static CancellationToken \u200B⁫⁬⁬‏‫‭⁬⁪⁬⁬‬‭‍‪‮​‏⁫‌‌‌‭⁬‫‍‎⁫‮​‏‬‬‮‭⁯‌‫⁭⁮‮([In] CancellationTokenSource obj0)
    {
      return obj0.get_Token();
    }

    static Task \u206E‪‫‏‫‎⁬​⁫⁭⁫‌⁬‬⁬‌⁯‎⁯⁪⁫⁮⁯‏⁯⁮⁫⁮‫⁮‮⁮‍‌‍⁪​​‬⁬‮([In] int obj0)
    {
      return Task.Delay(obj0);
    }

    static NotImplementedException \u206E⁬‮‍‍⁪‭‬⁫⁫‮⁮⁫⁬⁮‬‌‫‮⁯‌⁭‭⁫‏‌‪⁫⁬⁬‫⁪​‫⁫⁮⁭⁬⁫‏‮()
    {
      return new NotImplementedException();
    }
  }
}
