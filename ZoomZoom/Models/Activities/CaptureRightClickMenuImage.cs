// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.CaptureRightClickMenuImage
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom.Models.Activities
{
  public class CaptureRightClickMenuImage : ActivityBase
  {
    private ZoomWindow window;

    public ZoomWindow Window
    {
      get
      {
label_1:
        int num1 = -1804732593;
        ZoomWindow window;
        while (true)
        {
          int num2 = -797138475;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              window = this.window;
              num1 = (int) num3 * 388031775 ^ -1392078425;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return window;
      }
      set
      {
label_1:
        int num1 = -1233739947;
        while (true)
        {
          int num2 = -729431848;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(666835085U));
              num1 = (int) num3 * -441794810 ^ 2064611906;
              continue;
            case 1:
              this.window = value;
              num1 = (int) num3 * 2082502222 ^ 2107745898;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -1825250642;
        TraceType traceType;
        while (true)
        {
          int num2 = -51659584;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * 846577860 ^ 205720501;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public CaptureRightClickMenuImage(ZoomWindow window)
    {
label_1:
      int num1 = -723846738;
      while (true)
      {
        int num2 = -1393437668;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Window = window;
            num1 = (int) num3 * -1894045158 ^ 710255478;
            continue;
          case 2:
            num1 = (int) num3 * -769567524 ^ -2024370063;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    protected override void ExecuteLogic()
    {
      CaptureRightClickMenuImage.\u202E⁯⁪⁫⁫⁮⁫‪‏⁮‌⁫‎‭‍⁫⁮‭‪​​‎​⁫‬⁭‍⁫⁫⁭​‏‬⁪⁬‎‪‍⁬‏‮(150);
label_1:
      int num1 = 1404912968;
      while (true)
      {
        int num2 = 885619381;
        uint num3;
        ZoomWindow window;
        Bitmap bitmap;
        long sqlScalarLong;
        bool flag;
        int X;
        int Y;
        System.Drawing.Point location;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 25U)
        {
          case 0:
            num1 = (int) num3 * 202975700 ^ 828776238;
            continue;
          case 1:
            int num5 = flag ? 791140083 : (num5 = 1051759578);
            int num6 = (int) num3 * -180036566;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num1 = (int) num3 * -1903166557 ^ -1245049033;
            continue;
          case 3:
            Y = location.Y + 25;
            User32.SetCursorPos(X, Y);
            User32.mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0U, 0);
            num1 = (int) num3 * -1729023121 ^ 2009974263;
            continue;
          case 4:
            flag = sqlScalarLong == 0L;
            num1 = (int) num3 * 1680146852 ^ 898406319;
            continue;
          case 5:
            location = this.Window.Location;
            num1 = (int) num3 * -1035027535 ^ -455697684;
            continue;
          case 6:
            User32.mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0U, 0);
            num1 = (int) num3 * 1389639826 ^ -814516799;
            continue;
          case 7:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1945440402U));
            sqlScalarLong = Engine.Instance.ZoomZoomDatabase.GetSQLScalar_Long(string.Format(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3272676367U), (object) bitmap.Height, (object) bitmap.Width, (object) ZoomWindowType.ZoomMenu));
            num1 = (int) num3 * -1547764603 ^ 1261293311;
            continue;
          case 8:
            if (window == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1078487760 ^ 1525597729;
            continue;
          case 9:
            window = this.Engine.GetWindow(ZoomWindowType.ZoomMenu);
            num1 = (int) num3 * 2019296371 ^ -214776933;
            continue;
          case 10:
            Thread.Sleep(40);
            num1 = (int) num3 * 2075741819 ^ 414404948;
            continue;
          case 11:
            bitmap = WindowHelper.PrintWindow(window.Handle);
            num1 = (int) num3 * 930746091 ^ 1075488519;
            continue;
          case 12:
            X = location.X + 25;
            num1 = (int) num3 * 13752739 ^ -258924040;
            continue;
          case 13:
            num1 = 163372417;
            continue;
          case 14:
            num1 = (int) num3 * -1597276313 ^ -2072275847;
            continue;
          case 15:
            num4 = window.IsVisible ? 1 : 0;
            break;
          case 16:
            goto label_3;
          case 17:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(666633269U));
            num1 = (int) num3 * -1970558301 ^ 806703244;
            continue;
          case 18:
            num1 = (int) num3 * 1319796816 ^ 1725473759;
            continue;
          case 19:
            goto label_1;
          case 20:
            Thread.Sleep(40);
            num1 = (int) num3 * -148891044 ^ -428173612;
            continue;
          case 21:
            location = this.Window.Location;
            num1 = (int) num3 * -463571417 ^ 1021144419;
            continue;
          case 22:
            num1 = 195827864;
            continue;
          case 23:
            User32.SetCursorPos(X, Y);
            num1 = (int) num3 * -1265194510 ^ -1883750093;
            continue;
          case 24:
            new ZoomImage(window, bitmap).SaveDatabaseObject();
            num1 = (int) num3 * 376189214 ^ -752893734;
            continue;
          default:
            goto label_30;
        }
        int num7;
        num1 = num7 = num4 != 0 ? 1362989178 : (num7 = 663676133);
      }
label_30:
      return;
label_3:;
    }

    internal override bool Valid()
    {
label_1:
      int num1 = -1766522880;
      bool flag;
      while (true)
      {
        int num2 = -1980242658;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * 1817947859 ^ -1322994099;
            continue;
          case 2:
            flag = true;
            num1 = (int) num3 * -247390042 ^ -1232031733;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    static void \u202E⁯⁪⁫⁫⁮⁫‪‏⁮‌⁫‎‭‍⁫⁮‭‪​​‎​⁫‬⁭‍⁫⁫⁭​‏‬⁪⁬‎‪‍⁬‏‮([In] int obj0)
    {
      Thread.Sleep(obj0);
    }
  }
}
