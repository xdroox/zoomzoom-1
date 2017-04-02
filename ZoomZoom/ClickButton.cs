// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ClickButton
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;

namespace ZoomZoom
{
  public class ClickButton : ActivityBase
  {
    private static List<ZoomButton> buttons = new List<ZoomButton>();
    private ZoomWindowType zoomWindowType = ZoomWindowType.Undefined;
    private ZoomButtonType buttonType = ZoomButtonType.Unknown;
    private ZoomButton button = (ZoomButton) null;
    private ZoomWindow window = (ZoomWindow) null;
    private ZoomMeeting meeting = (ZoomMeeting) null;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 1141140004;
        TraceType traceType;
        while (true)
        {
          int num2 = 1722340188;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1164288065 ^ -907637840;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public ZoomButtonType ButtonType
    {
      get
      {
label_1:
        int num1 = -568039516;
        ZoomButtonType buttonType;
        while (true)
        {
          int num2 = -853690836;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              buttonType = this.buttonType;
              num1 = (int) num3 * 1689221328 ^ -2039620632;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return buttonType;
      }
      set
      {
        this.buttonType = value;
      }
    }

    public ZoomWindowType ZoomWindowType
    {
      get
      {
        return this.zoomWindowType;
      }
      set
      {
label_1:
        int num1 = 1726476349;
        while (true)
        {
          int num2 = 644217526;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.zoomWindowType = value;
              num1 = (int) num3 * 1624974251 ^ 721158404;
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

    public ZoomButton Button
    {
      get
      {
label_1:
        int num1 = -1047125242;
        ZoomButton button;
        while (true)
        {
          int num2 = -1958600097;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              button = this.button;
              num1 = (int) num3 * -1599664824 ^ -1531514709;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return button;
      }
      set
      {
        this.button = value;
      }
    }

    public ZoomWindow Window
    {
      get
      {
label_1:
        int num1 = -1862198638;
        ZoomWindow window;
        while (true)
        {
          int num2 = -1354914523;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              window = this.window;
              num1 = (int) num3 * -976250492 ^ -1721314798;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return window;
      }
      set
      {
        this.window = value;
      }
    }

    public ZoomMeeting Meeting
    {
      get
      {
label_1:
        int num1 = 1257483244;
        ZoomMeeting meeting;
        while (true)
        {
          int num2 = 432887077;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1611248309 ^ -1982337109;
              continue;
            case 1:
              meeting = this.meeting;
              num1 = (int) num3 * 1488390613 ^ -813216600;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return meeting;
      }
      set
      {
        this.meeting = value;
      }
    }

    public static List<ZoomButton> Buttons
    {
      get
      {
        List<ZoomButton> buttons = ClickButton.buttons;
label_1:
        int num1 = 1509514892;
        while (true)
        {
          int num2 = 49111156;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 252427575 ^ -1056353991;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return buttons;
      }
      set
      {
        ClickButton.buttons = value;
      }
    }

    public ClickButton(ZoomWindowType zoomWindowType, ZoomButtonType buttonType)
    {
label_1:
      int num1 = -1863293921;
      while (true)
      {
        int num2 = -74883068;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.ButtonType = buttonType;
            num1 = (int) num3 * -1132471553 ^ 1013070967;
            continue;
          case 3:
            this.ZoomWindowType = zoomWindowType;
            num1 = (int) num3 * -1248379996 ^ 48785983;
            continue;
          case 4:
            num1 = (int) num3 * 55678490 ^ -1096176848;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    public ClickButton(ZoomButtonType buttonType)
    {
      this.Meeting = this.Engine.ActiveMeeting;
      this.Window = this.Engine.ActiveMeetingWindow;
      this.ButtonType = buttonType;
    }

    public ClickButton(ZoomWindow window, ZoomButton button)
    {
      this.Meeting = this.Engine.ActiveMeeting;
      this.Window = window;
      this.Button = button;
    }

    protected override void ExecuteLogic()
    {
label_1:
      int num1 = 12235110;
      while (true)
      {
        int num2 = 265570470;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 861801503 ^ 1736297995;
            continue;
          case 1:
            this.SetActivityState(ActivityState.InProgress, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1651691663U));
            num1 = (int) num3 * -1055954759 ^ 116863121;
            continue;
          case 2:
            ActivityBase.endTime = DateTime.Now.AddSeconds(2.0);
            num1 = (int) num3 * -510084997 ^ 1241979907;
            continue;
          case 3:
            int num4 = (int) this.window.ClickButton(this.button);
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3772893620U));
            num1 = (int) num3 * 877752872 ^ 1443912338;
            continue;
          case 4:
            goto label_3;
          case 5:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = -1856571762;
      bool flag;
      while (true)
      {
        int num2 = -2140094425;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = true;
            num1 = (int) num3 * -1323161933 ^ 1569321701;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }
  }
}
