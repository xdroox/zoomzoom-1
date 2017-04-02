// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Windows.ZoomMonitor
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Windows
{
  public class ZoomMonitor : CoreObject
  {
    private int monitorNumber;
    private string screenName;

    public int MonitorNumber
    {
      get
      {
label_1:
        int num1 = -1021226930;
        int monitorNumber;
        while (true)
        {
          int num2 = -414730855;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1238603708 ^ 1106016128;
              continue;
            case 2:
              goto label_1;
            case 3:
              monitorNumber = this.monitorNumber;
              num1 = (int) num3 * -930385340 ^ -66387175;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return monitorNumber;
      }
      set
      {
label_1:
        int num1 = 1336109442;
        while (true)
        {
          int num2 = 790009506;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.monitorNumber = value;
              num1 = 230815991;
              continue;
            case 1:
              int num4 = flag ? 648934308 : (num4 = 398042489);
              int num5 = (int) num3 * -492695998;
              num1 = num4 ^ num5;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1564992765U));
              num1 = (int) num3 * -28351101 ^ 1092285037;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              flag = this.monitorNumber == value;
              num1 = (int) num3 * -1180174821 ^ -787666688;
              continue;
            case 6:
              num1 = (int) num3 * 906728680 ^ 1961024962;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public string ScreenName
    {
      get
      {
label_1:
        int num1 = -107778877;
        string screenName;
        while (true)
        {
          int num2 = -1393007856;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              screenName = this.screenName;
              num1 = (int) num3 * 857132434 ^ 1502463097;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return screenName;
      }
      set
      {
label_1:
        int num1 = -1003594990;
        while (true)
        {
          int num2 = -47600416;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              this.screenName = value;
              num1 = -403938408;
              continue;
            case 1:
              num1 = (int) num3 * -511183030 ^ 138688539;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3366961789U));
              num1 = (int) num3 * 393404269 ^ 744677513;
              continue;
            case 4:
              goto label_1;
            case 5:
              num1 = (int) num3 * 836873678 ^ 1880780059;
              continue;
            case 6:
              int num4 = !ZoomMonitor.\u202A‏⁯⁭⁮⁮‪⁯⁯‍‌⁫‫⁬‎‏​‬‪‎‫‬‬‌‌⁪‍⁮⁭⁫‫‮‫​⁪‎‏‏‮⁫‮(this.screenName, value) ? -104462732 : (num4 = -2124020621);
              int num5 = (int) num3 * -60608456;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -2067421786;
        TraceType traceType;
        while (true)
        {
          int num2 = -1068995492;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              traceType = TraceType.Window;
              num1 = (int) num3 * 343971654 ^ 1486623371;
              continue;
            case 3:
              num1 = (int) num3 * 2000381794 ^ 938285867;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public ZoomMonitor(int monitorNumber, string deviceName)
    {
      this.monitorNumber = monitorNumber;
      this.ScreenName = deviceName;
    }

    public override string ToString()
    {
label_1:
      int num1 = 2113035864;
      string str;
      while (true)
      {
        int num2 = 645495423;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -871265961 ^ 1632751582;
            continue;
          case 3:
            str = ZoomMonitor.\u200D⁪‬‬‬‭‏‮⁮⁫⁫⁪‫⁫‏‮⁯⁯⁬⁬⁯⁯‪‪‮‎‍⁫‌‭⁪‮⁫⁫⁭⁪‎‫‎⁭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3369137274U), (object) this.monitorNumber);
            num1 = (int) num3 * 1060777394 ^ -1099886720;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = 523180085;
      bool flag1;
      while (true)
      {
        int num2 = 1606872124;
        uint num3;
        ZoomMonitor zoomMonitor;
        int result;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            num4 = int.TryParse(ZoomMonitor.\u206E⁭⁫⁭⁯‪⁮‬‏‮‫⁮⁪‎‮‌⁬⁯⁪⁮⁭⁭‎‏‫⁫‫‪⁪⁫⁫​‪‪⁯‍⁫‌​‮‮(ZoomMonitor.\u206A​‫‮‍‍⁯‬⁭‫⁯⁪‬‬⁬‌⁮‏‫⁮‬‏‏⁫⁯⁯​⁭‎⁪⁫⁮⁬‬‪‮‌‏⁪‫‮(obj), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2683959415U), ""), out result) ? 1 : 0;
            break;
          case 1:
            num1 = (int) num3 * -1559788713 ^ 1038750394;
            continue;
          case 2:
            flag1 = this.\u202D‍​⁭​‎‫‌⁯‮‫‭‬​⁬‫‬‮⁮⁪‬‎‎⁫⁭​⁯⁮‪‪‌⁫‮‬⁭⁪​‍⁮⁯‮(obj);
            num1 = 1641695980;
            continue;
          case 3:
            zoomMonitor = obj as ZoomMonitor;
            num1 = (int) num3 * 1593510372 ^ -234853814;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * 1278799312 ^ 408064849;
            continue;
          case 6:
            int num5 = !flag2 ? -1746203794 : (num5 = -272079317);
            int num6 = (int) num3 * -1600300825;
            num1 = num5 ^ num6;
            continue;
          case 7:
            num1 = (int) num3 * -1708783624 ^ 965682164;
            continue;
          case 8:
            num1 = (int) num3 * 1482592229 ^ 1700581786;
            continue;
          case 9:
            if (obj == null)
            {
              num4 = 0;
              break;
            }
            num1 = 2038924078;
            continue;
          case 11:
            flag1 = zoomMonitor.MonitorNumber == this.monitorNumber;
            num1 = (int) num3 * -1905722944 ^ 1900117793;
            continue;
          case 12:
            int num7 = zoomMonitor == null ? -468615861 : (num7 = -78789565);
            int num8 = (int) num3 * -754428267;
            num1 = num7 ^ num8;
            continue;
          case 13:
            flag1 = result == this.monitorNumber;
            num1 = (int) num3 * 2078564672 ^ 852408898;
            continue;
          default:
            goto label_18;
        }
        flag2 = num4 != 0;
        num1 = 1817966886;
      }
label_18:
      return flag1;
    }

    public override int GetHashCode()
    {
label_1:
      int num1 = -1486653679;
      int hashCode;
      while (true)
      {
        int num2 = -458497324;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1078279799 ^ 561626414;
            continue;
          case 1:
            hashCode = this.monitorNumber.GetHashCode();
            num1 = (int) num3 * -47228848 ^ -1969182368;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return hashCode;
    }

    static bool \u202A‏⁯⁭⁮⁮‪⁯⁯‍‌⁫‫⁬‎‏​‬‪‎‫‬‬‌‌⁪‍⁮⁭⁫‫‮‫​⁪‎‏‏‮⁫‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static string \u200D⁪‬‬‬‭‏‮⁮⁫⁫⁪‫⁫‏‮⁯⁯⁬⁬⁯⁯‪‪‮‎‍⁫‌‭⁪‮⁫⁫⁭⁪‎‫‎⁭‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static string \u206A​‫‮‍‍⁯‬⁭‫⁯⁪‬‬⁬‌⁮‏‫⁮‬‏‏⁫⁯⁯​⁭‎⁪⁫⁮⁬‬‪‮‌‏⁪‫‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u206E⁭⁫⁭⁯‪⁮‬‏‮‫⁮⁪‎‮‌⁬⁯⁪⁮⁭⁭‎‏‫⁫‫‪⁪⁫⁫​‪‪⁯‍⁫‌​‮‮([In] string obj0, [In] string obj1, [In] string obj2)
    {
      return obj0.Replace(obj1, obj2);
    }

    bool \u202D‍​⁭​‎‫‌⁯‮‫‭‬​⁬‫‬‮⁮⁪‬‎‎⁫⁭​⁯⁮‪‪‌⁫‮‬⁭⁪​‍⁮⁯‮([In] object obj0)
    {
      return base.Equals(obj0);
    }
  }
}
