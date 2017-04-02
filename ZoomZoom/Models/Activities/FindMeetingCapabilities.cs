// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.FindMeetingCapabilities
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ZoomZoom.Models.Images;
using ZoomZoom.Models.Meetings;

namespace ZoomZoom.Models.Activities
{
  internal class FindMeetingCapabilities : ActivityBase
  {
    private ZoomMeeting meeting;

    public ZoomMeeting Meeting
    {
      get
      {
        ZoomMeeting meeting = this.meeting;
label_1:
        int num1 = -745743942;
        while (true)
        {
          int num2 = -1526094273;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -683676773 ^ -1835612016;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return meeting;
      }
      set
      {
        this.meeting = value;
      }
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = 369791559;
      while (true)
      {
        int num2 = 1327077210;
        uint num3;
        bool flag1;
        ZoomWindow window;
        CaptureRightClickMenuImage rightClickMenuImage;
        bool flag2;
        Bitmap result;
        ZoomImage zoomImage;
        bool flag3;
        bool flag4;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 44U)
        {
          case 0:
            num1 = 1500867979;
            continue;
          case 1:
            num1 = (int) num3 * 1673046827 ^ -895830095;
            continue;
          case 2:
            this.ReportProgress(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1068239302U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3915714764U));
            num1 = 1354439242;
            continue;
          case 3:
            num1 = (int) num3 * -89602063 ^ 1971313622;
            continue;
          case 4:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(135044537U));
            num1 = (int) num3 * -1103367854 ^ -647791384;
            continue;
          case 5:
            num1 = (int) num3 * 1689037344 ^ -95524077;
            continue;
          case 6:
            num1 = (int) num3 * 201818243 ^ -1140608261;
            continue;
          case 7:
            result = rightClickMenuImage.Result as Bitmap;
            flag2 = result != null;
            num1 = (int) num3 * -1053674062 ^ -1880564922;
            continue;
          case 8:
            ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<MeetingMenuCaptured>()).Publish(zoomImage);
            num1 = (int) num3 * -799938781 ^ 2093437796;
            continue;
          case 9:
            if (this.ExecuteSubActivity((ActivityBase) rightClickMenuImage, true) == ActivityState.Completed)
            {
              num1 = (int) num3 * -602294636 ^ 1693496856;
              continue;
            }
            num4 = 0;
            break;
          case 10:
            num1 = (int) num3 * 1054273953 ^ -36638900;
            continue;
          case 11:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3767747491U));
            num1 = 2017387918;
            continue;
          case 12:
            num1 = (int) num3 * 2135303577 ^ -20237476;
            continue;
          case 13:
            num1 = (int) num3 * -110708354 ^ 241253238;
            continue;
          case 14:
            goto label_3;
          case 15:
            num1 = 1222639864;
            continue;
          case 16:
            goto label_1;
          case 17:
            num1 = (int) num3 * -853986132 ^ 100031621;
            continue;
          case 18:
            num1 = (int) num3 * 968018979 ^ 275195570;
            continue;
          case 19:
            num1 = (int) num3 * 230410716 ^ 1500576022;
            continue;
          case 20:
            int num5 = flag3 ? 1374289229 : (num5 = 931556385);
            int num6 = (int) num3 * -729268056;
            num1 = num5 ^ num6;
            continue;
          case 21:
            num1 = (int) num3 * -1080955894 ^ 661333761;
            continue;
          case 22:
            int num7 = !flag2 ? -198224959 : (num7 = -2075973605);
            int num8 = (int) num3 * -223049688;
            num1 = num7 ^ num8;
            continue;
          case 23:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(303029259U));
            num1 = 1093241107;
            continue;
          case 24:
            flag1 = this.Meeting == null;
            num1 = 923378082;
            continue;
          case 25:
            int num9 = flag4 ? 1497785683 : (num9 = 484644605);
            int num10 = (int) num3 * 1290972425;
            num1 = num9 ^ num10;
            continue;
          case 26:
            this.Meeting.SetDisplayMode(DisplayMode.GalleryView);
            num1 = (int) num3 * -380294911 ^ -1120702338;
            continue;
          case 27:
            int num11 = window != null ? 1685940278 : (num11 = 641790170);
            int num12 = (int) num3 * 1523460929;
            num1 = num11 ^ num12;
            continue;
          case 28:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: method pointer
            window = ((IEnumerable<ZoomWindow>) Enumerable.Where<ZoomWindow>((IEnumerable<M0>) this.Engine.GetWindows(ZoomWindowType.Video), (Func<M0, bool>) (FindMeetingCapabilities.\u003C\u003Ec.\u003C\u003E9__4_0 ?? (FindMeetingCapabilities.\u003C\u003Ec.\u003C\u003E9__4_0 = new Func<ZoomWindow, bool>((object) FindMeetingCapabilities.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CExecuteLogic\u003Eb__4_0)))))).FirstOrDefault<ZoomWindow>();
            num1 = 117364085;
            continue;
          case 29:
            this.ReportProgress(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3817464673U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2005217345U));
            flag4 = this.Meeting.DisplayMode != DisplayMode.GalleryView;
            num1 = 358767627;
            continue;
          case 30:
            num1 = (int) num3 * 317890947 ^ 655320301;
            continue;
          case 31:
            num1 = (int) num3 * -1985693109 ^ -2024544576;
            continue;
          case 32:
            int num13 = !flag1 ? -2047211617 : (num13 = -1238831223);
            int num14 = (int) num3 * -973649339;
            num1 = num13 ^ num14;
            continue;
          case 33:
            this.EndTime = DateTime.Now.AddSeconds(5.0);
            this.MinimizeWindows(this.MeetingWindow);
            num1 = (int) num3 * 2051123601 ^ 419240660;
            continue;
          case 34:
            num4 = rightClickMenuImage.Result != null ? 1 : 0;
            break;
          case 35:
            rightClickMenuImage = new CaptureRightClickMenuImage(window);
            num1 = (int) num3 * 1302579712 ^ -1922451541;
            continue;
          case 36:
            num1 = (int) num3 * 1505014819 ^ -2095474243;
            continue;
          case 37:
            zoomImage = new ZoomImage(this.Engine.GetWindow(ZoomWindowType.ZoomMenu), result)
            {
              ImageType = ImageEnums.ImageType.Menu,
              DisplayAfterCapture = false
            };
            num1 = (int) num3 * -1317904692 ^ 378113630;
            continue;
          case 38:
            num1 = 1221373242;
            continue;
          case 39:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1643478147U));
            num1 = 560609152;
            continue;
          case 40:
            this.RestoreWindows();
            num1 = 848853864;
            continue;
          case 41:
            num1 = (int) num3 * 596949132 ^ -382988876;
            continue;
          case 42:
            this.Trace(TraceType.Activity, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1380347990U));
            num1 = (int) num3 * -1629873710 ^ 1618197919;
            continue;
          case 43:
            int num15;
            num1 = num15 = this.ContinueExecution() ? 587701674 : (num15 = 1773059790);
            continue;
          default:
            goto label_49;
        }
        flag3 = num4 != 0;
        num1 = 573101018;
      }
label_49:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 126572397;
      bool flag;
      while (true)
      {
        int num2 = 586410982;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -387501861 ^ -1923486219;
            continue;
          case 3:
            flag = true;
            num1 = (int) num3 * 756627092 ^ -600097272;
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
