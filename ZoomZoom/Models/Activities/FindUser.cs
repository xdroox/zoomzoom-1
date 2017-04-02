// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.FindUser
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ZoomZoom.Models.Activities
{
  public class FindUser : ActivityBase
  {
    private string userName = string.Empty;
    private bool userFound = false;
    private ZoomWindow particiapntsWindow = (ZoomWindow) null;
    private ZoomImage participantsImage = (ZoomImage) null;
    private bool initiateChat = true;
    private ZoomMeeting meetingFoundIn;

    public string UserName
    {
      get
      {
label_1:
        int num1 = -2057136911;
        string userName;
        while (true)
        {
          int num2 = -1617402646;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -942254225 ^ -288149825;
              continue;
            case 3:
              userName = this.userName;
              num1 = (int) num3 * 794097176 ^ -1917882609;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return userName;
      }
      set
      {
        this.userName = value;
      }
    }

    public bool UserFound
    {
      get
      {
label_1:
        int num1 = 1175113642;
        bool userFound;
        while (true)
        {
          int num2 = 366014127;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              userFound = this.userFound;
              num1 = (int) num3 * 311171911 ^ -57966118;
              continue;
            case 2:
              num1 = (int) num3 * -65611390 ^ -1829083173;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return userFound;
      }
      set
      {
label_1:
        int num1 = 1920010968;
        while (true)
        {
          int num2 = 1635645948;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.userFound = value;
              num1 = (int) num3 * -1992384667 ^ -48773993;
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
    }

    public ZoomMeeting MeetingFoundIn
    {
      get
      {
label_1:
        int num1 = 2009330457;
        ZoomMeeting meetingFoundIn;
        while (true)
        {
          int num2 = 2101801375;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1203839918 ^ 1289272901;
              continue;
            case 2:
              meetingFoundIn = this.meetingFoundIn;
              num1 = (int) num3 * -811354767 ^ -93992140;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingFoundIn;
      }
      set
      {
label_1:
        int num1 = -1100097993;
        while (true)
        {
          int num2 = -1445997825;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.meetingFoundIn = value;
              num1 = (int) num3 * -603583860 ^ -106697833;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public ZoomWindow ParticipantsWindow
    {
      get
      {
        ZoomWindow particiapntsWindow = this.particiapntsWindow;
label_1:
        int num1 = 930156450;
        while (true)
        {
          int num2 = 2101998116;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1546724649 ^ 1635205658;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return particiapntsWindow;
      }
      set
      {
label_1:
        int num1 = -1012875121;
        while (true)
        {
          int num2 = -1151593532;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.particiapntsWindow = value;
              num1 = (int) num3 * 207566668 ^ -1738410120;
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
    }

    public bool InitiateChat
    {
      get
      {
label_1:
        int num1 = -1411044913;
        bool initiateChat;
        while (true)
        {
          int num2 = -2020803758;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              initiateChat = this.initiateChat;
              num1 = (int) num3 * 1658339591 ^ 1580233483;
              continue;
            case 2:
              num1 = (int) num3 * 1212866774 ^ -2087641939;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return initiateChat;
      }
      set
      {
        this.initiateChat = value;
      }
    }

    public ZoomImage ParticipantsImage
    {
      get
      {
label_1:
        int num1 = 269598367;
        ZoomImage participantsImage;
        while (true)
        {
          int num2 = 896504046;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              participantsImage = this.participantsImage;
              num1 = (int) num3 * -33621156 ^ -427195456;
              continue;
            case 2:
              num1 = (int) num3 * 1264825237 ^ 66494448;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return participantsImage;
      }
      set
      {
        this.participantsImage = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
        return TraceType.Activity;
      }
    }

    public FindUser()
    {
label_1:
      int num1 = 1416883003;
      while (true)
      {
        int num2 = 1841787724;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1392927085 ^ 1144019892;
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

    public FindUser(string userName, bool initiateChat = true)
    {
label_1:
      int num1 = -897249599;
      while (true)
      {
        int num2 = -1329100262;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            this.InitiateChat = initiateChat;
            num1 = (int) num3 * 234159277 ^ -298052669;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.UserFound = false;
            num1 = (int) num3 * -1019590818 ^ -1112065782;
            continue;
          case 3:
            num1 = (int) num3 * -2016352758 ^ 519298422;
            continue;
          case 4:
            goto label_1;
          case 5:
            this.ActivityState = ActivityState.Pending;
            this.UserName = userName;
            this.MeetingFoundIn = (ZoomMeeting) null;
            num1 = (int) num3 * -1536883494 ^ 462165295;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    internal bool IsUserInMeeting()
    {
label_1:
      int num1 = -1291857663;
      bool userFound;
      while (true)
      {
        int num2 = -1470011271;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        Color pixelColor;
        int x;
        int y;
        Bitmap windowAsBitmap;
        bool flag5;
        int num4;
        bool flag6;
        System.Drawing.Point location;
        int num5;
        bool flag7;
        int num6;
        int num7;
        int num8;
        int num9;
        switch ((num3 = (uint) (num1 ^ num2)) % 79U)
        {
          case 0:
            ++y;
            num1 = -796249252;
            continue;
          case 1:
            num4 = 0;
            num1 = (int) num3 * -886949888 ^ -161592158;
            continue;
          case 2:
            if (flag2)
            {
              num7 = 0;
              goto label_59;
            }
            else
            {
              num1 = -925996088;
              continue;
            }
          case 3:
            num1 = -269870606;
            continue;
          case 4:
            this.ParticipantsWindow.Click(new System.Drawing.Point(50, 50), true, true, 0);
            num1 = (int) num3 * -857970872 ^ 103780273;
            continue;
          case 5:
            pixelColor = ZoomZoom.NativeMethods.GetPixelColor(x, y);
            if ((int) pixelColor.R == (int) byte.MaxValue)
            {
              num1 = -219587508;
              continue;
            }
            break;
          case 6:
            this.UserFound = true;
            num1 = (int) num3 * 2047220002 ^ 539644279;
            continue;
          case 7:
            num1 = (int) num3 * 189211121 ^ 1373279275;
            continue;
          case 8:
            location = this.ParticipantsWindow.Location;
            y = location.Y + 130;
            num1 = (int) num3 * 1169272002 ^ 988021621;
            continue;
          case 9:
            goto label_1;
          case 10:
            location = this.ParticipantsWindow.Location;
            num1 = (int) num3 * 113069305 ^ 787184050;
            continue;
          case 11:
            CoreObject.log.Info((object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2521966049U));
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2139572853U));
            num1 = (int) num3 * 71079474 ^ -554288875;
            continue;
          case 12:
            windowAsBitmap = WindowHelper.GetWindowAsBitmap(this.ParticipantsWindow.Handle, true, x - 10, y - 10, 20, 20);
            num1 = (int) num3 * 1667833860 ^ 927585760;
            continue;
          case 13:
            Thread.Sleep(40);
            num1 = (int) num3 * 1569649483 ^ 482048148;
            continue;
          case 14:
            num1 = -1882719077;
            continue;
          case 15:
            num1 = (int) num3 * 886289872 ^ -497583134;
            continue;
          case 16:
            this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(633325816U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(621566787U));
            num1 = (int) num3 * 1638159162 ^ -90137094;
            continue;
          case 17:
            num9 = y < num6 ? 1 : 0;
            goto label_70;
          case 18:
            num1 = -1741155748;
            continue;
          case 19:
            int num10 = !flag6 ? 2071356187 : (num10 = 1043578129);
            int num11 = (int) num3 * 302684395;
            num1 = num10 ^ num11;
            continue;
          case 20:
            flag6 = this.ParticipantsWindow != null;
            num1 = (int) num3 * -1873631290 ^ -601122821;
            continue;
          case 21:
            int num12 = flag4 ? -1680572297 : (num12 = -1022543266);
            int num13 = (int) num3 * 1090224950;
            num1 = num12 ^ num13;
            continue;
          case 22:
            num1 = (int) num3 * 61228938 ^ 285007894;
            continue;
          case 23:
            num1 = (int) num3 * 358174864 ^ 1093625038;
            continue;
          case 24:
            num1 = (int) num3 * 917587841 ^ -946102772;
            continue;
          case 25:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2752725919U));
            this.UserFound = false;
            num1 = (int) num3 * 2040274269 ^ -667501105;
            continue;
          case 26:
            num1 = (int) num3 * -917665379 ^ -791258134;
            continue;
          case 27:
            this.InitiateChatWithUser();
            num1 = (int) num3 * 610250035 ^ -1440109155;
            continue;
          case 28:
            windowAsBitmap.Save(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(116486949U));
            num1 = (int) num3 * 650661249 ^ 746315975;
            continue;
          case 29:
            CoreObject.log.DebugFormat(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2689515073U), (object) num4);
            num1 = (int) num3 * 974927785 ^ -999522683;
            continue;
          case 30:
            userFound = this.userFound;
            num1 = -1562345712;
            continue;
          case 31:
            SendKeys.SendWait(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(312308053U));
            num1 = (int) num3 * -1015815433 ^ -1003371031;
            continue;
          case 32:
            this.UserFound = false;
            num1 = (int) num3 * -1426363211 ^ -1223205848;
            continue;
          case 33:
            int num14 = !flag7 ? 1727870159 : (num14 = 1458179686);
            int num15 = (int) num3 * 1465927385;
            num1 = num14 ^ num15;
            continue;
          case 34:
            num1 = (int) num3 * 947959647 ^ -220607040;
            continue;
          case 35:
            location = this.ParticipantsWindow.Location;
            num6 = location.Y + 130 + 20;
            num1 = (int) num3 * -159372715 ^ -1849528515;
            continue;
          case 36:
            num1 = (int) num3 * 269381741 ^ 958557684;
            continue;
          case 37:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2115824116U));
            num1 = (int) num3 * -206319518 ^ 771111443;
            continue;
          case 38:
            num1 = (int) num3 * 1950266909 ^ -1082874648;
            continue;
          case 39:
            this.ReportProgress(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1887044018U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(549033290U));
            num1 = (int) num3 * 1667821404 ^ -1102212928;
            continue;
          case 40:
            this.MeetingFoundIn = this.Engine.ActiveMeeting;
            num1 = (int) num3 * -174997619 ^ 1502298308;
            continue;
          case 41:
            num1 = (int) num3 * 1075417463 ^ -2113832183;
            continue;
          case 42:
            num1 = (int) num3 * 1284725722 ^ 2040837257;
            continue;
          case 43:
            num1 = (int) num3 * 480050529 ^ -1599262806;
            continue;
          case 44:
            SendKeys.SendWait(this.UserName);
            num1 = (int) num3 * 1407605324 ^ -1928392248;
            continue;
          case 46:
            num1 = (int) num3 * 1668373644 ^ -448775626;
            continue;
          case 47:
            this.ReportProgress(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1923940318U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(909533374U));
            num1 = (int) num3 * 1466097833 ^ -97839632;
            continue;
          case 48:
            num1 = -1847747416;
            continue;
          case 49:
            num1 = -1676539364;
            continue;
          case 50:
            num7 = x < num5 ? 1 : 0;
            goto label_59;
          case 51:
            this.ParticipantsWindow = this.ParticipantsWindow != null ? this.ParticipantsWindow : this.Engine.WindowManager.OpenParticipantsWindow();
            num1 = -35863305;
            continue;
          case 52:
            num1 = (int) num3 * 1573635157 ^ -10146564;
            continue;
          case 53:
            int num16 = !flag3 ? -1367403817 : (num16 = -1411216175);
            int num17 = (int) num3 * 4045542;
            num1 = num16 ^ num17;
            continue;
          case 54:
            this.ParticipantsWindow.Click(new System.Drawing.Point(50, 50), true, true, 0);
            num1 = (int) num3 * 239304631 ^ 337703700;
            continue;
          case 55:
            if ((int) pixelColor.G == (int) byte.MaxValue)
            {
              num1 = (int) num3 * 31089589 ^ -1661992643;
              continue;
            }
            break;
          case 56:
            num1 = (int) num3 * -51206191 ^ 752040167;
            continue;
          case 57:
            int num18 = flag5 ? 1751259226 : (num18 = 1225529418);
            int num19 = (int) num3 * 627743810;
            num1 = num18 ^ num19;
            continue;
          case 58:
            num1 = (int) num3 * -1083734770 ^ -734835212;
            continue;
          case 59:
            int num20 = flag1 ? 1664344045 : (num20 = 1262656543);
            int num21 = (int) num3 * -601231973;
            num1 = num20 ^ num21;
            continue;
          case 60:
            num1 = (int) num3 * -1943692005 ^ 631358871;
            continue;
          case 61:
            flag1 = windowAsBitmap != null;
            num1 = (int) num3 * 272987762 ^ 1382712488;
            continue;
          case 62:
            ++num4;
            num1 = (int) num3 * 119488786 ^ 17150790;
            continue;
          case 63:
            x = location.X + 27;
            num1 = (int) num3 * 1870998982 ^ 190139992;
            continue;
          case 64:
            num1 = (int) num3 * -1610876155 ^ -1171252087;
            continue;
          case 65:
            ++x;
            num1 = -882101579;
            continue;
          case 66:
            Thread.Sleep(40);
            num1 = (int) num3 * 930525001 ^ 1323055595;
            continue;
          case 67:
            num8 = (int) pixelColor.B != (int) byte.MaxValue ? 1 : 0;
            goto label_12;
          case 68:
            location = this.ParticipantsWindow.Location;
            num5 = location.X + 30 + 20;
            num1 = (int) num3 * -758651953 ^ -2116091675;
            continue;
          case 69:
            num1 = (int) num3 * -821393200 ^ -1254712538;
            continue;
          case 70:
            y = location.Y + (int) sbyte.MaxValue;
            ZoomZoom.NativeMethods.GetPixelColor(x, y);
            num1 = (int) num3 * 646003407 ^ -2108545537;
            continue;
          case 71:
            flag2 = false;
            num1 = -1135850086;
            continue;
          case 72:
            SendKeys.SendWait(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3623352111U));
            num1 = (int) num3 * 1735579411 ^ 1394611833;
            continue;
          case 73:
            flag5 = !flag2;
            num1 = (int) num3 * -1539517384 ^ 815153823;
            continue;
          case 74:
            location = this.ParticipantsWindow.Location;
            num1 = (int) num3 * 1149129298 ^ 963204745;
            continue;
          case 75:
            if (flag2)
            {
              num9 = 0;
              goto label_70;
            }
            else
            {
              num1 = -1766576220;
              continue;
            }
          case 76:
            this.ReportProgress(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2540893611U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(816329466U));
            num1 = (int) num3 * -856125044 ^ -1813585853;
            continue;
          case 77:
            flag3 = flag2;
            num1 = (int) num3 * -531067908 ^ 1743409321;
            continue;
          case 78:
            num1 = (int) num3 * 1074077444 ^ 1931360485;
            continue;
          default:
            goto label_90;
        }
        num8 = 1;
label_12:
        int num22;
        num1 = num22 = num8 == 0 ? -1139832840 : (num22 = -1869535407);
        continue;
label_59:
        flag7 = num7 != 0;
        num1 = -1810883152;
        continue;
label_70:
        flag4 = num9 != 0;
        num1 = -1682965216;
      }
label_90:
      return userFound;
    }

    private void InitiateChatWithUser()
    {
label_1:
      int num1 = -295294418;
      while (true)
      {
        int num2 = -262317420;
        uint num3;
        System.Drawing.Point coordinates;
        bool initiateChat;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            coordinates = new System.Drawing.Point(this.ParticipantsWindow.Location.X + 15, this.ParticipantsWindow.Location.Y + 115);
            num1 = (int) num3 * 2012805448 ^ 1831716187;
            continue;
          case 1:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3870600829U));
            num1 = (int) num3 * -1434921491 ^ -219669417;
            continue;
          case 2:
            initiateChat = this.InitiateChat;
            num1 = (int) num3 * 2125682329 ^ -1777785422;
            continue;
          case 3:
            goto label_1;
          case 4:
            int num4 = !initiateChat ? 843510738 : (num4 = 425505756);
            int num5 = (int) num3 * -1605702590;
            num1 = num4 ^ num5;
            continue;
          case 5:
            this.ParticipantsWindow.Click(coordinates, true, true, 0);
            num1 = (int) num3 * 1594113726 ^ -2122185453;
            continue;
          case 6:
            goto label_3;
          case 7:
            this.ParticipantsWindow.Click(coordinates, true, true, 0);
            num1 = (int) num3 * 1276347283 ^ 60231084;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    protected override void ExecuteLogic()
    {
      try
      {
label_2:
        int num1 = 844853109;
        while (true)
        {
          int num2 = 1520848517;
          uint num3;
          bool flag;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              goto label_2;
            case 1:
              if (this.IsUserInMeeting())
              {
                num4 = 0;
                break;
              }
              num1 = 1334578112;
              continue;
            case 2:
              this.ReportProgress(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3970428184U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3233434380U));
              num1 = (int) num3 * -180742249 ^ 1748453599;
              continue;
            case 3:
              goto label_29;
            case 4:
              num1 = 1095304050;
              continue;
            case 5:
              int num5 = flag ? 438382690 : (num5 = 152616025);
              int num6 = (int) num3 * -721102330;
              num1 = num5 ^ num6;
              continue;
            case 6:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2712802898U));
              num1 = (int) num3 * -139371020 ^ -168448396;
              continue;
            case 7:
              num1 = (int) num3 * -1293257789 ^ 1317254616;
              continue;
            case 8:
              num1 = (int) num3 * 915537856 ^ 822190523;
              continue;
            case 9:
              num4 = this.ActivityState == ActivityState.InProgress ? 1 : 0;
              break;
            case 10:
              int num7 = !FindUser.\u206D‏‌‎⁭⁫⁮‌‭‫⁬⁪‏‌‮⁫‍‪⁭‌⁫‎⁬⁭‫‎​‮‬‎⁭⁭‍‍‏​‍⁫‫‏‮(this.UserName, string.Empty) ? 69100068 : (num7 = 328228149);
              int num8 = (int) num3 * 1033634526;
              num1 = num7 ^ num8;
              continue;
            case 11:
              num1 = (int) num3 * 771072388 ^ -997350337;
              continue;
            case 12:
              this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4188784052U));
              num1 = (int) num3 * 1188446307 ^ -404636774;
              continue;
            case 13:
              num1 = (int) num3 * -1179043871 ^ -917398748;
              continue;
            default:
              goto label_24;
          }
          flag = num4 != 0;
          num1 = 451781118;
        }
label_24:
        return;
label_29:;
      }
      catch (Exception ex)
      {
label_22:
        int num1 = 1037605684;
        while (true)
        {
          int num2 = 1520848517;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_20;
            case 1:
              FindUser.\u206B‬⁪⁬‌‬⁪‬⁯‏‌‌⁫​⁬⁮‍⁬⁭⁭​‮​‍⁬‭⁭⁪⁮‭‍⁬‌‍⁬⁯‌⁫⁭‮‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1399140309 ^ -1509553941;
              continue;
            case 2:
              goto label_22;
            case 3:
              num1 = (int) num3 * 1131880807 ^ -1133994742;
              continue;
            case 4:
              num1 = (int) num3 * -559141648 ^ 451607274;
              continue;
            case 5:
              this.SetActivityState(ActivityState.Error, FindUser.\u200E⁫⁬‬‫‫⁬‫‍​‫‮⁭‏⁪⁪‮‭‫⁫⁮⁭‮‍‬⁪⁬‫‌⁯‪⁪‭⁯⁫⁯‬​⁬‮‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(27601363U), FindUser.\u206D‎‌⁯‪​‏‌‎‌‬⁫​‪⁯‪⁮‮‪‎⁯⁯⁮‌⁮‍‏⁮‌⁭‬‏‍⁪⁬⁬⁮⁭⁪‫‮(ex)));
              num1 = (int) num3 * -2080874605 ^ 403598870;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_20:;
      }
    }

    internal override bool Valid()
    {
label_1:
      int num1 = 1918361244;
      bool flag;
      while (true)
      {
        int num2 = 43189397;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1416969559 ^ -1734000446;
            continue;
          case 1:
            flag = true;
            num1 = (int) num3 * 1559056378 ^ -144735357;
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

    static bool \u206D‏‌‎⁭⁫⁮‌‭‫⁬⁪‏‌‮⁫‍‪⁭‌⁫‎⁬⁭‫‎​‮‬‎⁭⁭‍‍‏​‍⁫‫‏‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static void \u206B‬⁪⁬‌‬⁪‬⁯‏‌‌⁫​⁬⁮‍⁬⁭⁭​‮​‍⁬‭⁭⁪⁮‭‍⁬‌‍⁬⁯‌⁫⁭‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static string \u206D‎‌⁯‪​‏‌‎‌‬⁫​‪⁯‪⁮‮‪‎⁯⁯⁮‌⁮‍‏⁮‌⁭‬‏‍⁪⁬⁬⁮⁭⁪‫‮([In] Exception obj0)
    {
      return obj0.Message;
    }

    static string \u200E⁫⁬‬‫‫⁬‫‍​‫‮⁭‏⁪⁪‮‭‫⁫⁮⁭‮‍‬⁪⁬‫‌⁯‪⁪‭⁯⁫⁯‬​⁬‮‮([In] string obj0, [In] string obj1)
    {
      return obj0 + obj1;
    }
  }
}
