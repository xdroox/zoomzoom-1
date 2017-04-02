// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.CaptureWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using ZoomZoom.Models.Images;

namespace ZoomZoom.Models.Activities
{
  public class CaptureWindow : ActivityBase
  {
    private SelectWindow selectWindowActivity;
    private CaptureVideoWindow captureVideoWindowActivity;
    private ZoomWindow selectedWindow;
    private ZoomImage image;

    public override TraceType TraceType
    {
      get
      {
        return TraceType.Activity;
      }
    }

    internal SelectWindow SelectWindowActivity
    {
      get
      {
label_1:
        int num1 = -1389379609;
        SelectWindow selectWindowActivity;
        while (true)
        {
          int num2 = -1291488378;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              selectWindowActivity = this.selectWindowActivity;
              num1 = (int) num3 * -594214087 ^ 871842953;
              continue;
            case 2:
              num1 = (int) num3 * -1843466360 ^ -649583799;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return selectWindowActivity;
      }
      set
      {
        this.selectWindowActivity = value;
      }
    }

    public CaptureVideoWindow CaptureVideoWindowActivity
    {
      get
      {
        CaptureVideoWindow videoWindowActivity = this.captureVideoWindowActivity;
label_1:
        int num1 = -1736001966;
        while (true)
        {
          int num2 = -992472011;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1574718433 ^ 1921868678;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return videoWindowActivity;
      }
      set
      {
        this.captureVideoWindowActivity = value;
      }
    }

    public ZoomWindow SelectedWindow
    {
      get
      {
label_1:
        int num1 = 756077190;
        ZoomWindow selectedWindow;
        while (true)
        {
          int num2 = 2056680151;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              selectedWindow = this.selectedWindow;
              num1 = (int) num3 * -490018171 ^ -1794631828;
              continue;
            case 2:
              num1 = (int) num3 * -417219958 ^ 74010407;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return selectedWindow;
      }
      set
      {
        this.selectedWindow = value;
      }
    }

    public ZoomImage Image
    {
      get
      {
label_1:
        int num1 = 851096972;
        ZoomImage image;
        while (true)
        {
          int num2 = 1069417713;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -934322476 ^ 421514574;
              continue;
            case 1:
              image = this.image;
              num1 = (int) num3 * -1997841129 ^ 391443270;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return image;
      }
      set
      {
label_1:
        int num1 = -296084570;
        while (true)
        {
          int num2 = -1789222836;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.image = value;
              num1 = (int) num3 * -1281810211 ^ -1273452521;
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

    public CaptureWindow()
    {
label_1:
      int num1 = -1027356605;
      while (true)
      {
        int num2 = -1503331913;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1934741512 ^ 869472471;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = 1635697149;
      while (true)
      {
        int num2 = 1548539289;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 38U)
        {
          case 0:
            num1 = (int) num3 * 817388502 ^ 1516195468;
            continue;
          case 1:
            flag2 = this.Image != null;
            num1 = (int) num3 * -1552463733 ^ 739592665;
            continue;
          case 2:
            this.SelectedWindow = this.SelectWindowActivity.SelectedWindow;
            num1 = (int) num3 * -733277401 ^ 1266568570;
            continue;
          case 3:
            num1 = (int) num3 * -1743578341 ^ 1713332418;
            continue;
          case 4:
            int num5 = !flag1 ? -546791168 : (num5 = -883883698);
            int num6 = (int) num3 * -1435481213;
            num1 = num5 ^ num6;
            continue;
          case 5:
            num1 = (int) num3 * -799245333 ^ 396749115;
            continue;
          case 6:
            num1 = (int) num3 * -434010976 ^ 645501731;
            continue;
          case 7:
            num1 = (int) num3 * 1451608575 ^ -1742017971;
            continue;
          case 8:
            num1 = (int) num3 * -1755395908 ^ -1652353021;
            continue;
          case 9:
            num1 = (int) num3 * 153377764 ^ 731091885;
            continue;
          case 10:
            num1 = 246013867;
            continue;
          case 11:
            CaptureWindow.\u206D⁭⁫‏‍⁬‎​‪​⁪‏⁬‮⁫‎⁭⁪‌‏‍‮‎⁪‎‎‮‌‎⁭‮⁬‏‍‫​⁮‍‮⁫‮(CoreObject.log, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3242682282U), (object) this.SelectedWindow.ZoomWindowType, (object) this.SelectedWindow.Location);
            Engine engine = this.Engine;
            ZoomWindow selectedWindow = this.SelectedWindow;
            Rectangle empty = Rectangle.Empty;
            int num7 = 4;
            ImageOptions options = new ImageOptions();
            int num8 = this.Options.DisplayAfterCapture ? 1 : 0;
            options.DisplayAfterCapture = num8 != 0;
            int num9 = this.Options.SaveAfterCapture ? 1 : 0;
            options.SaveToDisk = num9 != 0;
            this.Image = engine.CaptureImage(selectedWindow, empty, (ImageEnums.ImageType) num7, options);
            num1 = (int) num3 * -1488827451 ^ -613173373;
            continue;
          case 12:
            int num10 = !flag3 ? -1972703555 : (num10 = -1515655614);
            int num11 = (int) num3 * 1927289461;
            num1 = num10 ^ num11;
            continue;
          case 13:
            if (this.SelectedWindow == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1792190431 ^ 1064619847;
            continue;
          case 14:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(912275313U));
            num1 = 757508855;
            continue;
          case 15:
            flag3 = this.ExecuteSubActivity((ActivityBase) this.SelectWindowActivity, true) == ActivityState.Completed;
            num1 = (int) num3 * 1772573488 ^ 1028897029;
            continue;
          case 16:
            num1 = (int) num3 * -1054487102 ^ 1742145425;
            continue;
          case 17:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3867918917U));
            num1 = (int) num3 * 1120419981 ^ 402066348;
            continue;
          case 18:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2080111643U));
            num1 = (int) num3 * -1238688538 ^ -2060013967;
            continue;
          case 19:
            num1 = (int) num3 * -1187976472 ^ 200346330;
            continue;
          case 20:
            num1 = 792080381;
            continue;
          case 21:
            int num12 = !flag2 ? 453108687 : (num12 = 1372017575);
            int num13 = (int) num3 * 311536320;
            num1 = num12 ^ num13;
            continue;
          case 22:
            goto label_3;
          case 23:
            goto label_1;
          case 24:
            CaptureVideoWindow captureVideoWindow = new CaptureVideoWindow(this.SelectedWindow);
            int num14 = 1;
            captureVideoWindow.AutoGenerated = num14 != 0;
            this.CaptureVideoWindowActivity = captureVideoWindow;
            num1 = (int) num3 * -1758141322 ^ 721204073;
            continue;
          case 25:
            num1 = 977563480;
            continue;
          case 26:
            this.SelectWindowActivity = new SelectWindow((List<ZoomWindowType>) null);
            num1 = (int) num3 * 349946333 ^ -1482052610;
            continue;
          case 27:
            num1 = (int) num3 * -983910695 ^ 1637485102;
            continue;
          case 28:
            num1 = (int) num3 * -808091807 ^ -822898148;
            continue;
          case 29:
            num4 = this.SelectedWindow.ZoomWindowType == ZoomWindowType.Video ? 1 : 0;
            break;
          case 30:
            num1 = (int) num3 * -1494712737 ^ 226378392;
            continue;
          case 31:
            flag1 = this.SelectedWindow != null;
            num1 = 368755319;
            continue;
          case 32:
            num1 = (int) num3 * 527554281 ^ 2019595519;
            continue;
          case 33:
            this.Engine.AddActivity((ActivityBase) this.CaptureVideoWindowActivity, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1431255308U));
            num1 = (int) num3 * 155247578 ^ -1947810375;
            continue;
          case 34:
            num1 = (int) num3 * 2034461845 ^ -549995181;
            continue;
          case 35:
            num1 = (int) num3 * -985650129 ^ 830264663;
            continue;
          case 36:
            this.SetActivityState(this.SelectWindowActivity.ActivityState, this.SelectWindowActivity.Status);
            num1 = 792080381;
            continue;
          case 37:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2450088578U));
            num1 = (int) num3 * -1981441049 ^ -1828609235;
            continue;
          default:
            goto label_43;
        }
        int num15;
        num1 = num15 = num4 == 0 ? 827305074 : (num15 = 872145089);
      }
label_43:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = -802099167;
      bool flag;
      while (true)
      {
        int num2 = -1538407108;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = true;
            num1 = (int) num3 * 651214135 ^ 1590928685;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    static void \u206D⁭⁫‏‍⁬‎​‪​⁪‏⁬‮⁫‎⁭⁪‌‏‍‮‎⁪‎‎‮‌‎⁭‮⁬‏‍‫​⁮‍‮⁫‮([In] ILog obj0, [In] string obj1, [In] object obj2, [In] object obj3)
    {
      obj0.DebugFormat(obj1, obj2, obj3);
    }
  }
}
