// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Meetings.MeetingCapabilities
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using ZoomZoom.Models.Images;
using ZoomZoom.Properties;

namespace ZoomZoom.Models.Meetings
{
  public class MeetingCapabilities : CoreObject
  {
    private List<MeetingCapability> active;

    public List<MeetingCapability> Active
    {
      get
      {
        List<MeetingCapability> active = this.active;
label_1:
        int num1 = 235662091;
        while (true)
        {
          int num2 = 343223693;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -839370675 ^ 1002130081;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return active;
      }
      set
      {
label_1:
        int num1 = 748191116;
        while (true)
        {
          int num2 = 414311579;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -860353517 ^ -846495906;
              continue;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3944615255U));
              num1 = (int) num3 * -1898236509 ^ 1151386359;
              continue;
            case 3:
              goto label_1;
            case 4:
              this.active = value;
              num1 = (int) num3 * -849387547 ^ 483041665;
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

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Meeting;
label_1:
        int num1 = 1426368059;
        while (true)
        {
          int num2 = 2072076922;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1562898520 ^ 605108219;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public MeetingCapabilities()
    {
label_1:
      int num1 = 903212060;
      while (true)
      {
        int num2 = 1425180769;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1583444825 ^ -1121015879;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.active = new List<MeetingCapability>();
            num1 = (int) num3 * -959686611 ^ -61719764;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public void Reset()
    {
label_1:
      int num1 = 387302256;
      while (true)
      {
        int num2 = 425232222;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * 592300604 ^ -1823826662;
            continue;
          case 2:
            this.Trace(TraceType.Meeting, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(897191104U));
            num1 = (int) num3 * -236675785 ^ 958522833;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      this.active = (List<MeetingCapability>) null;
    }

    public bool MenuHasCapability(ZoomImage image, MeetingCapability capability)
    {
label_1:
      int num1 = -742150509;
      bool flag1;
      while (true)
      {
        int num2 = -1103671886;
        uint num3;
        bool flag2;
        bool flag3;
        Bitmap capabilityExemplar;
        bool flag4;
        bool flag5;
        switch ((num3 = (uint) (num1 ^ num2)) % 22U)
        {
          case 0:
            int num4 = !flag4 ? 1149874641 : (num4 = 2011460142);
            int num5 = (int) num3 * -2104469707;
            num1 = num4 ^ num5;
            continue;
          case 1:
            flag3 = false;
            num1 = (int) num3 * 1534924529 ^ -545107631;
            continue;
          case 2:
            num1 = (int) num3 * -283945335 ^ -1181666391;
            continue;
          case 3:
            int num6 = flag5 ? -1838786969 : (num6 = -664320067);
            int num7 = (int) num3 * -690108407;
            num1 = num6 ^ num7;
            continue;
          case 4:
            MeetingCapabilities.\u200D‌‎‎⁪‪‏‬‭‎⁫‫⁬⁭‌‫‭‪‌‭⁪⁮‏‫‎‭⁭⁯‎⁯‏‍‪‮​⁭⁪‮‍‍‮((Image) image.Bitmap, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(29933282U));
            num1 = (int) num3 * 311640856 ^ 805793109;
            continue;
          case 5:
            MeetingCapabilities.\u200D‌‎‎⁪‪‏‬‭‎⁫‫⁬⁭‌‫‭‪‌‭⁪⁮‏‫‎‭⁭⁯‎⁯‏‍‪‮​⁭⁪‮‍‍‮((Image) capabilityExemplar, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2477799921U));
            num1 = (int) num3 * -981899771 ^ 540490222;
            continue;
          case 6:
            int num8 = flag2 ? 1576011450 : (num8 = 1898414507);
            int num9 = (int) num3 * -1595514936;
            num1 = num8 ^ num9;
            continue;
          case 7:
            num1 = (int) num3 * 593408311 ^ 1288628384;
            continue;
          case 8:
            capabilityExemplar = this.GetCapabilityExemplar(capability);
            flag2 = capabilityExemplar != null;
            num1 = (int) num3 * -1932142540 ^ -1432016656;
            continue;
          case 9:
            goto label_1;
          case 11:
            num1 = (int) num3 * 250361518 ^ -1406267617;
            continue;
          case 12:
            flag5 = ImageHelper.ContainsImage(image.Bitmap, capabilityExemplar);
            num1 = (int) num3 * -658357214 ^ 1813663475;
            continue;
          case 13:
            flag3 = true;
            num1 = (int) num3 * 267423089 ^ -126602767;
            continue;
          case 14:
            num1 = (int) num3 * -1016730615 ^ -169997115;
            continue;
          case 15:
            flag1 = flag3;
            num1 = -2019313278;
            continue;
          case 16:
            num1 = -872353062;
            continue;
          case 17:
            num1 = (int) num3 * -1650038515 ^ -927774164;
            continue;
          case 18:
            num1 = (int) num3 * -2127382727 ^ -1858996878;
            continue;
          case 19:
            num1 = -2140878469;
            continue;
          case 20:
            num1 = (int) num3 * -1196635111 ^ -393104357;
            continue;
          case 21:
            flag4 = image.Uri == 0L;
            num1 = -1688818298;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return flag1;
    }

    public Bitmap GetCapabilityExemplar(MeetingCapability capability)
    {
label_1:
      int num1 = -1708141201;
      Bitmap bitmap;
      while (true)
      {
        int num2 = -635271218;
        uint num3;
        MeetingCapability meetingCapability;
        switch ((num3 = (uint) (num1 ^ num2)) % 26U)
        {
          case 0:
label_17:
            bitmap = Resources.rmenu_rename;
            num1 = -1161542495;
            continue;
          case 1:
            meetingCapability = capability;
            num1 = (int) num3 * -340709376 ^ -2069548357;
            continue;
          case 2:
            num1 = (int) num3 * -1675903251 ^ -494473527;
            continue;
          case 3:
label_16:
            bitmap = Resources.rmenu_remove;
            num1 = -947369674;
            continue;
          case 4:
          case 7:
          case 17:
          case 22:
label_19:
            bitmap = (Bitmap) null;
            num1 = -794530442;
            continue;
          case 5:
label_18:
            bitmap = Resources.rmenu_pin2;
            num1 = -22633442;
            continue;
          case 6:
            num1 = (int) num3 * -1974623447 ^ 870607105;
            continue;
          case 8:
label_10:
            bitmap = Resources.rmenu_hold;
            num1 = -765246127;
            continue;
          case 9:
label_21:
            bitmap = Resources.rmenu_chat;
            num1 = -765246127;
            continue;
          case 10:
label_24:
            bitmap = Resources.rmenu_spotlight;
            num1 = -514789675;
            continue;
          case 11:
            num1 = (int) num3 * 75292235 ^ -486010396;
            continue;
          case 12:
label_20:
            bitmap = Resources.rmenu_pin1;
            num1 = -765246127;
            continue;
          case 13:
            num1 = (int) num3 * 1867297391 ^ 1334226544;
            continue;
          case 14:
            goto label_1;
          case 16:
            num1 = (int) num3 * -569959846 ^ 1181101525;
            continue;
          case 18:
label_9:
            bitmap = Resources.rmenu_host;
            num1 = -293747388;
            continue;
          case 19:
            num1 = (int) num3 * -156707125 ^ 573455503;
            continue;
          case 20:
label_3:
            bitmap = Resources.rmenu_stop;
            num1 = -881967311;
            continue;
          case 21:
            num1 = (int) num3 * -1393498191 ^ -702460422;
            continue;
          case 23:
            switch (meetingCapability)
            {
              case MeetingCapability.StopVideo:
                goto label_3;
              case MeetingCapability.StartVideo:
              case MeetingCapability.RemoveFromHold:
                goto label_19;
              case MeetingCapability.Chat:
                goto label_21;
              case MeetingCapability.Rename:
                goto label_17;
              case MeetingCapability.Pin1:
                goto label_20;
              case MeetingCapability.Pin2:
                goto label_18;
              case MeetingCapability.SpotLight:
                goto label_24;
              case MeetingCapability.MakeHost:
                goto label_6;
              case MeetingCapability.MakeCoHost:
                goto label_9;
              case MeetingCapability.Remove:
                goto label_16;
              case MeetingCapability.PutOnHold:
                goto label_10;
              default:
                num1 = (int) num3 * -294757603 ^ 843084974;
                continue;
            }
          case 24:
            num1 = (int) num3 * 1982467293 ^ 1774847369;
            continue;
          case 25:
label_6:
            bitmap = Resources.rmenu_host;
            num1 = -765246127;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return bitmap;
    }

    internal void Subscribe()
    {
label_1:
      int num1 = -846980655;
      while (true)
      {
        int num2 = -760379252;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<MeetingMenuCaptured>()).Subscribe(new Action<ZoomImage>(this.MenuCaptured), (ThreadOption) 0);
            num1 = (int) num3 * -481164137 ^ -1342227289;
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

    internal void Unsubscribe()
    {
label_1:
      int num1 = -1544786151;
      while (true)
      {
        int num2 = -2021591305;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<MeetingMenuCaptured>()).Unsubscribe(new Action<ZoomImage>(this.MenuCaptured));
            num1 = (int) num3 * -106083719 ^ -1989178642;
            continue;
          case 3:
            num1 = (int) num3 * -647215381 ^ -1658489989;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void MenuCaptured(ZoomImage image)
    {
      // ISSUE: type reference
      IEnumerator enumerator = MeetingCapabilities.\u206E‬‌⁫‌​‎‎‮‮‬⁪‮⁮⁯‪⁮⁬‬‌⁪‬⁪‫‎‎⁭⁭⁮‬‫‎‪⁪‬⁭‌‌⁭⁫‮(MeetingCapabilities.\u206A‌‏‪‌‭‭⁪‬‬⁭⁬‮‍⁬‮​⁯⁪‫‮‬‫‫‮‎​‪‌‪‫⁬⁯​⁯‌⁮‍⁫⁭‮(MeetingCapabilities.\u202C‫‭⁪‭‭‍‬‌‭⁭‮⁭⁪⁬‎‪​‏‪‎‎​‫‎‌‏⁮⁬⁭⁭‪‮‬⁪‭‍‎⁬‎‮(__typeref (MeetingCapability))));
      try
      {
label_6:
        int num1 = !MeetingCapabilities.\u202A⁫‍⁪‫‪⁭‮‪⁮⁮‬‫‌​⁮⁮​‮⁭‪‮⁫​⁪⁪⁮⁮​‮⁪⁮‎⁯‭‎‮⁭​‌‮(enumerator) ? -1706034549 : (num1 = -1052474436);
        while (true)
        {
          int num2 = -1741064248;
          uint num3;
          bool flag;
          MeetingCapability capability;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 16U)
          {
            case 0:
              goto label_6;
            case 1:
              num1 = (int) num3 * -311486720 ^ 1318718410;
              continue;
            case 2:
              num1 = -1552710312;
              continue;
            case 3:
              goto label_25;
            case 4:
              capability = (MeetingCapability) MeetingCapabilities.\u200D⁯⁬‭​‫‪⁬⁭​⁭⁪⁫‬⁯⁬​‬‭‍‌‭⁬‭⁬⁭‪‏⁯‭‌‬‌⁯‌⁭⁯⁫‪‮‮(enumerator);
              num1 = -1794985482;
              continue;
            case 5:
              int num5;
              num1 = num5 = !this.active.Contains(capability) ? -899408694 : (num5 = -1937999967);
              continue;
            case 6:
              int num6 = flag ? -964475486 : (num6 = -768465509);
              int num7 = (int) num3 * -2007597567;
              num1 = num6 ^ num7;
              continue;
            case 7:
              num1 = -1052474436;
              continue;
            case 8:
              num4 = !this.active.Contains(capability) ? 1 : 0;
              break;
            case 9:
              this.active.Remove(capability);
              num1 = (int) num3 * -1242832355 ^ 435462447;
              continue;
            case 10:
              this.active.Add(capability);
              num1 = (int) num3 * 2102011870 ^ -388720199;
              continue;
            case 11:
              MeetingCapabilities.\u202B‪‏‍‪​⁭‬‪‍‏‮‫⁬⁯‏​‬‌⁮⁪​⁫⁯⁫‬⁯‮⁯⁫⁯⁮⁬‎⁪⁬‬‪‌⁯‮(CoreObject.log, MeetingCapabilities.\u206C‎⁫‫‫‮‪‏⁭‪⁬⁬⁭‫​⁬‎‌‌‌‍‫‏⁫⁮‫⁬‪⁯‍⁫‎⁪‭⁬‪‏‮⁪‬‮((object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2961930172U), (object) capability), new object[0]);
              num1 = (int) num3 * -1373825360 ^ -83664286;
              continue;
            case 12:
              num1 = (int) num3 * 527171779 ^ 73470551;
              continue;
            case 13:
              num1 = (int) num3 * 645639828 ^ 1183960973;
              continue;
            case 14:
              num1 = (int) num3 * -1194000584 ^ -326998169;
              continue;
            case 15:
              if (this.MenuHasCapability(image, capability))
              {
                num1 = (int) num3 * -1911264456 ^ 117093688;
                continue;
              }
              num4 = 0;
              break;
            default:
              goto label_21;
          }
          flag = num4 != 0;
          num1 = -928105602;
        }
label_21:
        return;
label_25:;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
label_23:
        int num1 = -234778679;
        while (true)
        {
          int num2 = -1741064248;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              int num4 = disposable == null ? 1340193238 : (num4 = 1986378337);
              int num5 = (int) num3 * 2103817070;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_23;
            case 3:
              MeetingCapabilities.\u200C⁪‪⁭‪‫‮⁮‪‏⁭⁯⁪⁫‪‏‍‫⁭⁪⁭⁭​⁮⁯‭‬‫⁭‮‍‏‌‬‭‌⁮⁯⁪‪‮(disposable);
              num1 = (int) num3 * 208520067 ^ 900226669;
              continue;
            default:
              goto label_28;
          }
        }
label_28:;
      }
    }

    static void \u200D‌‎‎⁪‪‏‬‭‎⁫‫⁬⁭‌‫‭‪‌‭⁪⁮‏‫‎‭⁭⁯‎⁯‏‍‪‮​⁭⁪‮‍‍‮([In] Image obj0, [In] string obj1)
    {
      obj0.Save(obj1);
    }

    static Type \u202C‫‭⁪‭‭‍‬‌‭⁭‮⁭⁪⁬‎‪​‏‪‎‎​‫‎‌‏⁮⁬⁭⁭‪‮‬⁪‭‍‎⁬‎‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static Array \u206A‌‏‪‌‭‭⁪‬‬⁭⁬‮‍⁬‮​⁯⁪‫‮‬‫‫‮‎​‪‌‪‫⁬⁯​⁯‌⁮‍⁫⁭‮([In] Type obj0)
    {
      return Enum.GetValues(obj0);
    }

    static IEnumerator \u206E‬‌⁫‌​‎‎‮‮‬⁪‮⁮⁯‪⁮⁬‬‌⁪‬⁪‫‎‎⁭⁭⁮‬‫‎‪⁪‬⁭‌‌⁭⁫‮([In] Array obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u200D⁯⁬‭​‫‪⁬⁭​⁭⁪⁫‬⁯⁬​‬‭‍‌‭⁬‭⁬⁭‪‏⁯‭‌‬‌⁯‌⁭⁯⁫‪‮‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static string \u206C‎⁫‫‫‮‪‏⁭‪⁬⁬⁭‫​⁬‎‌‌‌‍‫‏⁫⁮‫⁬‪⁯‍⁫‎⁪‭⁬‪‏‮⁪‬‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }

    static void \u202B‪‏‍‪​⁭‬‪‍‏‮‫⁬⁯‏​‬‌⁮⁪​⁫⁯⁫‬⁯‮⁯⁫⁯⁮⁬‎⁪⁬‬‪‌⁯‮([In] ILog obj0, [In] string obj1, [In] object[] obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static bool \u202A⁫‍⁪‫‪⁭‮‪⁮⁮‬‫‌​⁮⁮​‮⁭‪‮⁫​⁪⁪⁮⁮​‮⁪⁮‎⁯‭‎‮⁭​‌‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u200C⁪‪⁭‪‫‮⁮‪‏⁭⁯⁪⁫‪‏‍‫⁭⁪⁭⁭​⁮⁯‭‬‫⁭‮‍‏‌‬‭‌⁮⁯⁪‪‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }
  }
}
