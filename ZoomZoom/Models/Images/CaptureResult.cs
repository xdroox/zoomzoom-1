// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.CaptureResult
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

namespace ZoomZoom.Models.Images
{
  internal class CaptureResult : CoreObject
  {
    private ZoomImage image = (ZoomImage) null;
    private CaptureState state = CaptureState.Unknown;
    private string stateMessage = (string) null;
    private CaptureRequest request;

    internal TimeSpan CaptureSpan { get; set; }

    public CaptureRequest Request
    {
      get
      {
        CaptureRequest request = this.request;
label_1:
        int num1 = -1117835197;
        while (true)
        {
          int num2 = -1263502823;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 682960236 ^ -1399302914;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return request;
      }
      set
      {
        this.request = value;
      }
    }

    public ZoomImage Image
    {
      get
      {
label_1:
        int num1 = -389795778;
        ZoomImage image;
        while (true)
        {
          int num2 = -598050230;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              image = this.image;
              num1 = (int) num3 * 1611674889 ^ 230319728;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return image;
      }
      set
      {
        this.image = value;
      }
    }

    public CaptureState State
    {
      get
      {
label_1:
        int num1 = 325388443;
        CaptureState state;
        while (true)
        {
          int num2 = 2010663497;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              state = this.state;
              num1 = (int) num3 * -1940239717 ^ 105206488;
              continue;
            case 3:
              num1 = (int) num3 * -1501750065 ^ -175797431;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return state;
      }
      set
      {
        this.state = value;
      }
    }

    public string StateMessage
    {
      get
      {
        string stateMessage = this.stateMessage;
label_1:
        int num1 = -775040671;
        while (true)
        {
          int num2 = -1040417401;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -376202124 ^ -114622601;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return stateMessage;
      }
      set
      {
        this.stateMessage = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
        return TraceType.Image;
      }
    }

    public CaptureResult(CaptureRequest request)
    {
      this.Request = request;
      this.State = CaptureState.Pending;
    }

    internal void SetState(CaptureState state, string stateMessage = null)
    {
      this.State = state;
label_1:
      int num1 = 743856866;
      while (true)
      {
        int num2 = 1709998592;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            this.StateMessage = stateMessage;
            num1 = (int) num3 * 989017972 ^ -927285825;
            continue;
          case 1:
            int num4 = !flag ? -972359419 : (num4 = -1642313768);
            int num5 = (int) num3 * -239297213;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * -1258624586 ^ 1944688536;
            continue;
          case 3:
            flag = !CaptureResult.\u202C⁮⁪‫​‮‮‏​‭⁬⁮‏‏​‭‏‍⁮‮⁬⁪‌‮⁫‌‎⁫‌‬‮‪‫‪‏‮⁫‍‭⁪‮(stateMessage);
            num1 = (int) num3 * -622373757 ^ -1586829799;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 1679595007 ^ -358982425;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    internal void SetImage(BitmapSource source)
    {
label_1:
      int num1 = 691033202;
      while (true)
      {
        int num2 = 890540837;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            this.State = CaptureState.Captured;
            num1 = (int) num3 * -1202441787 ^ 786134270;
            continue;
          case 1:
            this.CaptureSpan = this.Request.Instantiated - DateTime.Now;
            num1 = (int) num3 * 2051525033 ^ -467755093;
            continue;
          case 2:
            flag = source != null;
            num1 = (int) num3 * 654169298 ^ 1619080923;
            continue;
          case 3:
            num1 = (int) num3 * -1220158914 ^ 1704326492;
            continue;
          case 4:
            num1 = (int) num3 * 657312528 ^ 1515990729;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.Image.BitmapSource = source;
            num1 = (int) num3 * -425996816 ^ 29373821;
            continue;
          case 7:
            goto label_3;
          case 8:
            int num4 = !flag ? -1591266771 : (num4 = -902027556);
            int num5 = (int) num3 * -1773568010;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    static bool \u202C⁮⁪‫​‮‮‏​‭⁬⁮‏‏​‭‏‍⁮‮⁬⁪‌‮⁫‌‎⁫‌‬‮‪‫‪‏‮⁫‍‭⁪‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }
  }
}
