// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.RemoveUser
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ZoomZoom.Models.Activities
{
  public class RemoveUser : ActivityBase
  {
    private string userName = string.Empty;
    private string manualUserName = string.Empty;
    private ObservableCollection<string> userNames = new ObservableCollection<string>();
    private ZoomWindow participantsWindow;
    private MeetingOptions meetingOptions;

    public string UserName
    {
      get
      {
        string userName = this.userName;
label_1:
        int num1 = 147183202;
        while (true)
        {
          int num2 = 28984284;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1854868321 ^ -1532961641;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return userName;
      }
      set
      {
label_1:
        int num1 = -1486413857;
        while (true)
        {
          int num2 = -754219122;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1849061780 ^ -1121323101;
              continue;
            case 1:
              int num4 = !RemoveUser.\u202B‬​‪⁮⁪‮​⁫‏‬‬⁭‬‮⁪⁫‍⁮‫⁫‭‌⁭‬‎‌‮⁫‪‍‪‏⁭‌‎⁮‭‫⁮‮(this.userName, value) ? 409057670 : (num4 = 942015731);
              int num5 = (int) num3 * -1463493151;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * 207069447 ^ 2083629127;
              continue;
            case 3:
              this.userName = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1391274932U));
              num1 = -672161798;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    public ZoomWindow ParticipantsWindow
    {
      get
      {
        return this.participantsWindow;
      }
      set
      {
label_1:
        int num1 = -893161042;
        while (true)
        {
          int num2 = -1457982672;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.participantsWindow = value;
              num1 = (int) num3 * -1389841020 ^ 343739045;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2292975286U));
              num1 = (int) num3 * 767592602 ^ -2082229273;
              continue;
            case 4:
              num1 = (int) num3 * -411906047 ^ 1357623757;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public string ManualUserName
    {
      get
      {
label_1:
        int num1 = -476346167;
        string manualUserName;
        while (true)
        {
          int num2 = -1440878006;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1776346364 ^ 1525587084;
              continue;
            case 3:
              manualUserName = this.manualUserName;
              num1 = (int) num3 * -915690746 ^ 1415520069;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return manualUserName;
      }
      set
      {
label_1:
        int num1 = 1335515016;
        while (true)
        {
          int num2 = 118890873;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.manualUserName = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(287089344U));
              num1 = (int) num3 * 173479431 ^ -1787696824;
              continue;
            case 2:
              num1 = (int) num3 * -1920192499 ^ -92460673;
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
    }

    public ObservableCollection<string> UserNames
    {
      get
      {
        ObservableCollection<string> userNames = this.userNames;
label_1:
        int num1 = 970063842;
        while (true)
        {
          int num2 = 1047248515;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1328639954 ^ 477885333;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return userNames;
      }
      set
      {
label_1:
        int num1 = 1531304617;
        while (true)
        {
          int num2 = 189161309;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              flag = value != null;
              num1 = (int) num3 * 2143311101 ^ -1711227121;
              continue;
            case 1:
              this.userNames.add_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(UserNames_CollectionChanged)));
              num1 = (int) num3 * 1627349839 ^ -1134452027;
              continue;
            case 2:
              int num4 = !flag ? -1955365052 : (num4 = -1808052267);
              int num5 = (int) num3 * 1380266513;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 498974617 ^ -709512494;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            case 6:
              num1 = (int) num3 * 351645569 ^ -1450472178;
              continue;
            case 7:
              num1 = (int) num3 * 713966843 ^ 453008031;
              continue;
            case 8:
              int num6 = this.userNames != null ? -1405183178 : (num6 = -1766161449);
              int num7 = (int) num3 * -657209428;
              num1 = num6 ^ num7;
              continue;
            case 9:
              num1 = (int) num3 * -549639482 ^ 1406580960;
              continue;
            case 10:
              this.userNames = value;
              num1 = 595683121;
              continue;
            case 11:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(385407491U));
              num1 = 554200681;
              continue;
            case 12:
              num1 = (int) num3 * 1976254952 ^ -100153574;
              continue;
            case 13:
              this.userNames.remove_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(UserNames_CollectionChanged)));
              num1 = (int) num3 * 961725603 ^ 1248811857;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_3:;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 1142267166;
        TraceType traceType;
        while (true)
        {
          int num2 = 1096208425;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 102449414 ^ 44362656;
              continue;
            case 2:
              goto label_1;
            case 3:
              traceType = TraceType.Activity;
              num1 = (int) num3 * -1274064020 ^ 42732089;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public RemoveUser(string userName)
    {
label_1:
      int num1 = 693528772;
      while (true)
      {
        int num2 = 1314152276;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -2068327600 ^ -331334313;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        this.UserName = userName;
        this.UserNames = this.Engine.ActiveUsers;
      }
      catch (Exception ex)
      {
        RemoveUser.\u200B‬‪‎‌‍​‪​⁭‍⁪‪⁯⁮‎⁮⁭​⁪‎​‪‏‎⁮⁫‮⁪‍​‮⁬⁭‏‪‌‍‌‫‮(CoreObject.log, (object) ex);
      }
    }

    ~RemoveUser()
    {
      try
      {
label_3:
        int num1 = -145925335;
        while (true)
        {
          int num2 = -875400100;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.UserNames = (ObservableCollection<string>) null;
              num1 = (int) num3 * 1725651621 ^ -1064530930;
              continue;
            case 2:
              goto label_17;
            case 3:
              num1 = (int) num3 * 518265248 ^ -1384495090;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_17:;
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -861409668;
        while (true)
        {
          int num2 = -875400100;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_9;
            case 1:
              num1 = (int) num3 * -1564524290 ^ -115171121;
              continue;
            case 2:
              RemoveUser.\u200B‬‪‎‌‍​‪​⁭‍⁪‪⁯⁮‎⁮⁭​⁪‎​‪‏‎⁮⁫‮⁪‍​‮⁬⁭‏‪‌‍‌‫‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -728317961 ^ -1640319691;
              continue;
            case 3:
              goto label_11;
            case 4:
              num1 = (int) num3 * 766857142 ^ -1078870896;
              continue;
            case 5:
              num1 = (int) num3 * -1062034184 ^ 1870504721;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_11:;
      }
      finally
      {
        // ISSUE: explicit finalizer call
        base.Finalize();
      }
    }

    private void UserNames_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      if (RemoveUser.\u206D‍⁮‍‫‮⁯⁭‎‬​‍⁮​⁯‏‎⁯​‍⁯⁮‬‬‍⁮‏‌‍‎‫‭⁮‌‭⁫‫⁭‍‭‮(e) == null)
        goto label_5;
label_1:
      int num1 = -1579222109;
label_2:
      bool flag;
      while (true)
      {
        int num2 = -2008712162;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            int num5 = flag ? 515173023 : (num5 = 208706084);
            int num6 = (int) num3 * 753481346;
            num1 = num5 ^ num6;
            continue;
          case 1:
            goto label_4;
          case 2:
            goto label_1;
          case 3:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2449232254U));
            num1 = (int) num3 * -870526922 ^ -395844517;
            continue;
          case 4:
            this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1196782602U));
            num1 = (int) num3 * 828424783 ^ -522052272;
            continue;
          case 5:
            num4 = RemoveUser.\u200D⁯‍​‫‎‍‏⁬‮‎⁭⁬‬⁯‬‭‮‭⁬‏‬​‏⁭⁯‮‪⁬‌​‏⁫‍‭⁬⁭‪‎⁬‮((ICollection) RemoveUser.\u206F‭‍⁯‮‭‌‮‍​⁯‫⁮‭‮‮‎‪‍⁮‫‬⁭⁪​⁬⁭‬‍⁫‎‌⁬⁫‫‮⁭‍‌⁯‮(e)) > 0 ? 1 : 0;
            break;
          case 6:
            if (RemoveUser.\u206F‭‍⁯‮‭‌‮‍​⁯‫⁮‭‮‮‎‪‍⁮‫‬⁭⁪​⁬⁭‬‍⁫‎‌⁬⁫‫‮⁭‍‌⁯‮(e) != null)
            {
              num1 = -1847890745;
              continue;
            }
            num4 = 0;
            break;
          case 7:
            num1 = (int) num3 * 1024132646 ^ 14834;
            continue;
          case 8:
            goto label_3;
          case 9:
            num1 = (int) num3 * -996791260 ^ 761113958;
            continue;
          case 10:
            num1 = (int) num3 * 492573287 ^ 636966676;
            continue;
          case 11:
            num1 = (int) num3 * -834862061 ^ -1105533512;
            continue;
          default:
            goto label_19;
        }
        int num7;
        num1 = num7 = num4 != 0 ? -1651673659 : (num7 = -999024466);
      }
label_19:
      return;
label_3:
      return;
label_4:
      int num8 = RemoveUser.\u200D⁯‍​‫‎‍‏⁬‮‎⁭⁬‬⁯‬‭‮‭⁬‏‬​‏⁭⁯‮‪⁬‌​‏⁫‍‭⁬⁭‪‎⁬‮((ICollection) RemoveUser.\u206D‍⁮‍‫‮⁯⁭‎‬​‍⁮​⁯‏‎⁯​‍⁯⁮‬‬‍⁮‏‌‍‎‫‭⁮‌‭⁫‫⁭‍‭‮(e)) > 0 ? 1 : 0;
      goto label_6;
label_5:
      num8 = 0;
label_6:
      flag = num8 != 0;
      num1 = -1271208202;
      goto label_2;
    }

    private void ClickRemoveUser()
    {
label_1:
      int num1 = 1166123339;
      while (true)
      {
        int num2 = 806644866;
        uint num3;
        System.Drawing.Point location;
        int X;
        int Y;
        int num4;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            User32.SetCursorPos(X, Y);
            User32.mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0U, 0);
            num1 = (int) num3 * 920090176 ^ -317401106;
            continue;
          case 1:
            num5 = 95;
            num1 = (int) num3 * 502197773 ^ -1188609263;
            continue;
          case 2:
            num1 = (int) num3 * 2124609580 ^ 81246267;
            continue;
          case 3:
            num1 = (int) num3 * -1665097559 ^ 402400881;
            continue;
          case 4:
            num1 = (int) num3 * 2109671045 ^ 1847246380;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 1093954879 ^ 514555101;
            continue;
          case 7:
            location = this.ParticipantsWindow.Location;
            num1 = (int) num3 * -891732341 ^ 421961508;
            continue;
          case 8:
            location = this.ParticipantsWindow.Location;
            X = location.X + this.ParticipantsWindow.Size.Width - num4;
            num1 = (int) num3 * -373466139 ^ 1030769597;
            continue;
          case 9:
            this.ParticipantsWindow.Activate();
            num1 = (int) num3 * -794979473 ^ -1740746441;
            continue;
          case 10:
            Thread.Sleep(40);
            num1 = (int) num3 * -839094629 ^ 137542284;
            continue;
          case 11:
            Y = location.Y + num5;
            num1 = (int) num3 * -903152862 ^ 1546062635;
            continue;
          case 12:
            SendKeys.SendWait(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3041818178U));
            num1 = (int) num3 * 1581241200 ^ -516087500;
            continue;
          case 13:
            goto label_1;
          case 14:
            num4 = 30;
            num1 = (int) num3 * -1326784492 ^ 798443017;
            continue;
          case 15:
            User32.SetCursorPos(X, Y);
            User32.mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0U, 0);
            num1 = (int) num3 * 860235129 ^ -1330333535;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return;
label_3:;
    }

    private void WaitForRemoveUserPrompt()
    {
      bool flag1 = false;
label_1:
      int num1 = 2143087701;
      while (true)
      {
        int num2 = 1854774595;
        uint num3;
        DateTime dateTime;
        bool flag2;
        ZoomWindow window;
        DateTime now;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 22U)
        {
          case 0:
            Thread.Sleep(10);
            num1 = 423301956;
            continue;
          case 1:
            num1 = (int) num3 * 1597022050 ^ -1971176302;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag3 = flag1;
            num1 = 1301401316;
            continue;
          case 4:
            window.Close(false, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2947358615U));
            num1 = (int) num3 * -1025425544 ^ -1464870621;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 1837862253 ^ 982136117;
            continue;
          case 7:
            int num4 = !flag3 ? 555405414 : (num4 = 451744406);
            int num5 = (int) num3 * 329852090;
            num1 = num4 ^ num5;
            continue;
          case 8:
            flag1 = true;
            num1 = (int) num3 * -1481082188 ^ 233122787;
            continue;
          case 9:
            num1 = (int) num3 * 1863149706 ^ -63607683;
            continue;
          case 10:
            dateTime = now.AddSeconds(2.0);
            num1 = (int) num3 * 1144162179 ^ -868242709;
            continue;
          case 11:
            num1 = 1665284710;
            continue;
          case 12:
            num1 = (int) num3 * -945503315 ^ -1703304038;
            continue;
          case 13:
            this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1419748770U));
            num1 = (int) num3 * 818126002 ^ 1458141930;
            continue;
          case 14:
            window = this.Engine.GetWindow(ZoomWindowType.RequestRecord);
            int num6;
            num1 = num6 = window != null ? 1827478785 : (num6 = 544766635);
            continue;
          case 15:
            num1 = (int) num3 * 246605307 ^ -1681954883;
            continue;
          case 16:
            this.SetActivityState(ActivityState.Completed, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(347503242U));
            num1 = (int) num3 * 652822544 ^ -1615368542;
            continue;
          case 17:
            num1 = (int) num3 * 700491081 ^ -733686083;
            continue;
          case 18:
            now = DateTime.Now;
            num1 = (int) num3 * 969459128 ^ -1073087607;
            continue;
          case 19:
            int num7 = flag2 ? 1379815603 : (num7 = 80033460);
            int num8 = (int) num3 * 23819162;
            num1 = num7 ^ num8;
            continue;
          case 20:
            flag2 = dateTime > DateTime.Now;
            num1 = (int) num3 * -1370365703 ^ 63562644;
            continue;
          case 21:
            num1 = (int) num3 * 478440842 ^ -1019237535;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      return;
label_3:;
    }

    private List<IntPtr> LoadExistingWindows()
    {
label_1:
      int num1 = 1696227998;
      List<IntPtr> visibleWindowHandles;
      List<ZoomWindow> zoomWindowList;
      while (true)
      {
        int num2 = 1402811833;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            zoomWindowList = new List<ZoomWindow>();
            num1 = (int) num3 * -1136179074 ^ 323007573;
            continue;
          case 3:
            visibleWindowHandles = WindowManager.GetVisibleWindowHandles(this.Engine.ActiveMeetingWindow.ProcessId);
            num1 = (int) num3 * -2079482401 ^ 1793256653;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      using (List<IntPtr>.Enumerator enumerator = visibleWindowHandles.GetEnumerator())
      {
label_12:
        int num2 = !enumerator.MoveNext() ? 360325190 : (num2 = 176832570);
        while (true)
        {
          int num3 = 1402811833;
          uint num4;
          ZoomWindow zoomWindow;
          IntPtr current;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              goto label_12;
            case 1:
              zoomWindow = ZoomWindow.New(current);
              zoomWindow.Refresh(false, false);
              num2 = (int) num4 * -1046809369 ^ -2076341976;
              continue;
            case 2:
              num2 = (int) num4 * -525058933 ^ -583592305;
              continue;
            case 3:
              current = enumerator.Current;
              num2 = 1110823452;
              continue;
            case 4:
              num2 = 176832570;
              continue;
            case 5:
              num2 = (int) num4 * 986765509 ^ -1318405087;
              continue;
            case 6:
              zoomWindowList.Add(zoomWindow);
              num2 = (int) num4 * 1105867034 ^ -1447925849;
              continue;
            default:
              goto label_16;
          }
        }
      }
label_16:
      List<IntPtr> numList = visibleWindowHandles;
label_17:
      int num5 = 1306129172;
      while (true)
      {
        int num2 = 1402811833;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_17;
          case 1:
            num5 = (int) num3 * -1445452396 ^ 709423800;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return numList;
    }

    protected override void ExecuteLogic()
    {
      try
      {
label_2:
        int num1 = 1342754498;
        while (true)
        {
          int num2 = 1370460153;
          uint num3;
          FindUser findUser;
          bool flag1;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 21U)
          {
            case 0:
              num1 = 180968279;
              continue;
            case 1:
              num1 = 34551794;
              continue;
            case 2:
              findUser = new FindUser(this.UserName, false);
              num1 = (int) num3 * -1710021572 ^ 109123917;
              continue;
            case 3:
              int num4 = !flag1 ? -587443438 : (num4 = -1829365416);
              int num5 = (int) num3 * 783136968;
              num1 = num4 ^ num5;
              continue;
            case 4:
              int num6 = flag2 ? -53619821 : (num6 = -539997945);
              int num7 = (int) num3 * 1985462580;
              num1 = num6 ^ num7;
              continue;
            case 5:
              num1 = (int) num3 * -886209823 ^ -1318243657;
              continue;
            case 6:
              this.WaitForRemoveUserPrompt();
              num1 = (int) num3 * -163341516 ^ 144557616;
              continue;
            case 7:
              num1 = 1894753458;
              continue;
            case 8:
              num1 = (int) num3 * -792281151 ^ 885267237;
              continue;
            case 9:
              num1 = (int) num3 * -678032838 ^ 1409816603;
              continue;
            case 10:
              int num8 = this.Engine.ActiveMeeting == null ? 244136239 : (num8 = 1942951177);
              int num9 = (int) num3 * -435379621;
              num1 = num8 ^ num9;
              continue;
            case 11:
              flag1 = this.ExecuteSubActivity((ActivityBase) findUser, true) == ActivityState.Completed;
              num1 = (int) num3 * 1965490566 ^ 1056320242;
              continue;
            case 12:
              this.ParticipantsWindow = this.Engine.GetWindow(ZoomWindowType.Participants);
              flag2 = this.ParticipantsWindow != null;
              num1 = (int) num3 * 1026126403 ^ 1823074584;
              continue;
            case 13:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(414362049U));
              num1 = (int) num3 * -1875523229 ^ 1555556477;
              continue;
            case 14:
              this.SetActivityState(ActivityState.Error, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3914295231U));
              num1 = 419706981;
              continue;
            case 15:
              goto label_24;
            case 16:
              this.ClickRemoveUser();
              num1 = (int) num3 * -1296344434 ^ 1471045686;
              continue;
            case 17:
              num1 = (int) num3 * 1267217961 ^ 1582849666;
              continue;
            case 18:
              num1 = (int) num3 * 1757089607 ^ -1993141700;
              continue;
            case 19:
              goto label_2;
            case 20:
              num1 = (int) num3 * 1724016886 ^ -1809588623;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_24:;
      }
      catch (Exception ex)
      {
label_26:
        int num1 = 270031716;
        while (true)
        {
          int num2 = 1370460153;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_26;
            case 2:
              RemoveUser.\u200B‬‪‎‌‍​‪​⁭‍⁪‪⁯⁮‎⁮⁭​⁪‎​‪‏‎⁮⁫‮⁪‍​‮⁬⁭‏‪‌‍‌‫‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 668948908 ^ 291703628;
              continue;
            default:
              goto label_29;
          }
        }
label_29:
        this.SetActivityState(ActivityState.Error, RemoveUser.\u202B​‪⁯⁮‮‏⁫​⁪⁫⁪​​⁭‫⁮‌‌‪‏‎⁭‬‫⁯‎⁬‪‭⁫⁬‍​‍⁯⁭‏⁭‮(ex));
      }
    }

    internal override bool Valid()
    {
      bool flag = true;
label_1:
      int num1 = -1482635135;
      while (true)
      {
        int num2 = -1472959810;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * 1131717078 ^ 531931466;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    internal override void ResetProperties()
    {
label_1:
      int num1 = -1741162672;
      while (true)
      {
        int num2 = -1652158097;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 844426810 ^ -32037622;
            continue;
          case 1:
            this.Options = new ActivityOptions();
            num1 = (int) num3 * -1723327370 ^ -1788581734;
            continue;
          case 2:
            this.UserName = "";
            num1 = (int) num3 * 409937097 ^ -1714432787;
            continue;
          case 3:
            this.MeetingOptions = new MeetingOptions();
            num1 = (int) num3 * 1986979002 ^ -176393899;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    static bool \u202B‬​‪⁮⁪‮​⁫‏‬‬⁭‬‮⁪⁫‍⁮‫⁫‭‌⁭‬‎‌‮⁫‪‍‪‏⁭‌‎⁮‭‫⁮‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static void \u200B‬‪‎‌‍​‪​⁭‍⁪‪⁯⁮‎⁮⁭​⁪‎​‪‏‎⁮⁫‮⁪‍​‮⁬⁭‏‪‌‍‌‫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static IList \u206D‍⁮‍‫‮⁯⁭‎‬​‍⁮​⁯‏‎⁯​‍⁯⁮‬‬‍⁮‏‌‍‎‫‭⁮‌‭⁫‫⁭‍‭‮([In] NotifyCollectionChangedEventArgs obj0)
    {
      return obj0.get_NewItems();
    }

    static int \u200D⁯‍​‫‎‍‏⁬‮‎⁭⁬‬⁯‬‭‮‭⁬‏‬​‏⁭⁯‮‪⁬‌​‏⁫‍‭⁬⁭‪‎⁬‮([In] ICollection obj0)
    {
      return obj0.Count;
    }

    static IList \u206F‭‍⁯‮‭‌‮‍​⁯‫⁮‭‮‮‎‪‍⁮‫‬⁭⁪​⁬⁭‬‍⁫‎‌⁬⁫‫‮⁭‍‌⁯‮([In] NotifyCollectionChangedEventArgs obj0)
    {
      return obj0.get_OldItems();
    }

    static string \u202B​‪⁯⁮‮‏⁫​⁪⁫⁪​​⁭‫⁮‌‌‪‏‎⁭‬‫⁯‎⁬‪‭⁫⁬‍​‍⁯⁭‏⁭‮([In] Exception obj0)
    {
      return obj0.Message;
    }
  }
}
