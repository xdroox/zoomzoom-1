// Decompiled with JetBrains decompiler
// Type: ZoomZoom.GlobalEventProvider
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ZoomZoom
{
  public class GlobalEventProvider : Component
  {
    protected override bool CanRaiseEvents
    {
      get
      {
label_1:
        int num1 = -421985792;
        bool flag;
        while (true)
        {
          int num2 = -385472493;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1426170818 ^ -2053826745;
              continue;
            case 3:
              flag = true;
              num1 = (int) num3 * 1826289606 ^ -915355736;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return flag;
      }
    }

    private event KeyPressEventHandler m_KeyPress
    {
      add
      {
        KeyPressEventHandler pressEventHandler1 = this.m_KeyPress;
label_1:
        int num1 = -2146441960;
        while (true)
        {
          int num2 = -1018743938;
          uint num3;
          KeyPressEventHandler pressEventHandler2;
          KeyPressEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = pressEventHandler1 != comparand ? -1531118127 : (num4 = -1113791207);
              int num5 = (int) num3 * 217460059;
              num1 = num4 ^ num5;
              continue;
            case 2:
              comparand = pressEventHandler1;
              num1 = -56333703;
              continue;
            case 3:
              pressEventHandler1 = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.m_KeyPress, pressEventHandler2, comparand);
              num1 = (int) num3 * -1297500242 ^ 338610095;
              continue;
            case 4:
              goto label_3;
            case 5:
              pressEventHandler2 = (KeyPressEventHandler) GlobalEventProvider.\u206B‭⁭⁭‫⁬‮‏‎⁫⁭⁯‏​​‍⁬‪​‬‌⁭⁬‏‍‬​‎⁫⁮‍⁮⁭‮⁭​⁭‫⁯⁮‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1385957769 ^ 1374399562;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
      remove
      {
        KeyPressEventHandler pressEventHandler1 = this.m_KeyPress;
label_1:
        int num1 = -28597283;
        while (true)
        {
          int num2 = -2012586368;
          uint num3;
          KeyPressEventHandler comparand;
          KeyPressEventHandler pressEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              pressEventHandler1 = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.m_KeyPress, pressEventHandler2, comparand);
              num1 = (int) num3 * 276593724 ^ -373863469;
              continue;
            case 1:
              comparand = pressEventHandler1;
              num1 = -84612286;
              continue;
            case 2:
              pressEventHandler2 = (KeyPressEventHandler) GlobalEventProvider.\u206B​‭⁬⁭‎‪⁫‬‏⁪‏‏⁪‫⁭‬⁯⁪‭⁭‫‌⁯⁫⁯‏⁯⁭‌⁪⁬⁬‏‌‫‏‫‏⁬‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1329516574 ^ -309857914;
              continue;
            case 3:
              int num4 = pressEventHandler1 != comparand ? -1575901552 : (num4 = -1082989332);
              int num5 = (int) num3 * 264666439;
              num1 = num4 ^ num5;
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

    public event KeyPressEventHandler KeyPress
    {
      add
      {
label_1:
        int num1 = -293452150;
        while (true)
        {
          int num2 = -554496101;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 1:
              flag = this.m_KeyPress == null;
              num1 = (int) num3 * -1274994702 ^ 578869447;
              continue;
            case 2:
              KeyboardHookManager.KeyPress += new KeyPressEventHandler(this.HookManager_KeyPress);
              num1 = (int) num3 * -996062946 ^ -1941980471;
              continue;
            case 3:
              int num4 = flag ? 1233332100 : (num4 = 842271945);
              int num5 = (int) num3 * -900390823;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        this.m_KeyPress += value;
      }
      remove
      {
label_1:
        int num1 = -201008111;
        while (true)
        {
          int num2 = -2065421443;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              KeyboardHookManager.KeyPress -= new KeyPressEventHandler(this.HookManager_KeyPress);
              num1 = (int) num3 * 637426964 ^ 887319934;
              continue;
            case 1:
              int num4 = flag ? -1915123384 : (num4 = -718851996);
              int num5 = (int) num3 * 1950386410;
              num1 = num4 ^ num5;
              continue;
            case 2:
              flag = this.m_KeyPress == null;
              num1 = (int) num3 * -45646652 ^ 240080268;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.m_KeyPress -= value;
              num1 = (int) num3 * 462589527 ^ 35999188;
              continue;
            case 5:
              num1 = (int) num3 * 1048108228 ^ -57168669;
              continue;
            case 6:
              goto label_1;
            case 7:
              num1 = (int) num3 * 2058206912 ^ -1836902227;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    private event KeyEventHandler m_KeyUp
    {
      add
      {
        KeyEventHandler keyEventHandler1 = this.m_KeyUp;
label_1:
        int num1 = -2008149881;
        while (true)
        {
          int num2 = -530401620;
          uint num3;
          KeyEventHandler keyEventHandler2;
          KeyEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              keyEventHandler2 = (KeyEventHandler) GlobalEventProvider.\u206B‭⁭⁭‫⁬‮‏‎⁫⁭⁯‏​​‍⁬‪​‬‌⁭⁬‏‍‬​‎⁫⁮‍⁮⁭‮⁭​⁭‫⁯⁮‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 571343427 ^ -410127294;
              continue;
            case 2:
              comparand = keyEventHandler1;
              num1 = -1486729327;
              continue;
            case 3:
              keyEventHandler1 = Interlocked.CompareExchange<KeyEventHandler>(ref this.m_KeyUp, keyEventHandler2, comparand);
              int num4 = keyEventHandler1 == comparand ? 1611311998 : (num4 = 227400263);
              int num5 = (int) num3 * -1583613760;
              num1 = num4 ^ num5;
              continue;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
      remove
      {
        KeyEventHandler keyEventHandler1 = this.m_KeyUp;
label_1:
        int num1 = 93209741;
        while (true)
        {
          int num2 = 1995881340;
          uint num3;
          KeyEventHandler comparand;
          KeyEventHandler keyEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              keyEventHandler1 = Interlocked.CompareExchange<KeyEventHandler>(ref this.m_KeyUp, keyEventHandler2, comparand);
              int num4 = keyEventHandler1 == comparand ? 1165633772 : (num4 = 13887495);
              int num5 = (int) num3 * -1115097083;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = keyEventHandler1;
              num1 = 546014286;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              keyEventHandler2 = (KeyEventHandler) GlobalEventProvider.\u206B​‭⁬⁭‎‪⁫‬‏⁪‏‏⁪‫⁭‬⁯⁪‭⁭‫‌⁯⁫⁯‏⁯⁭‌⁪⁬⁬‏‌‫‏‫‏⁬‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -116416732 ^ 1289992438;
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

    public event KeyEventHandler KeyUp
    {
      add
      {
label_1:
        int num1 = 802936843;
        while (true)
        {
          int num2 = 681945495;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * 177962888 ^ 2042771412;
              continue;
            case 1:
              this.m_KeyUp += value;
              num1 = 533412161;
              continue;
            case 2:
              goto label_3;
            case 3:
              flag = this.m_KeyUp == null;
              num1 = (int) num3 * -282938355 ^ 260878636;
              continue;
            case 4:
              num1 = (int) num3 * 1990105436 ^ 256129302;
              continue;
            case 5:
              KeyboardHookManager.KeyUp += new KeyEventHandler(this.HookManager_KeyUp);
              num1 = (int) num3 * -1700271994 ^ 1918035459;
              continue;
            case 6:
              num1 = (int) num3 * -2048505876 ^ -1266266799;
              continue;
            case 7:
              int num4 = flag ? -975754762 : (num4 = -704655606);
              int num5 = (int) num3 * 882513145;
              num1 = num4 ^ num5;
              continue;
            case 8:
              goto label_1;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
      remove
      {
        this.m_KeyUp -= value;
        bool flag = this.m_KeyUp == null;
label_1:
        int num1 = -2071743538;
        while (true)
        {
          int num2 = -654108681;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = !flag ? 1337355641 : (num4 = 882206084);
              int num5 = (int) num3 * -2097718880;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              KeyboardHookManager.KeyUp -= new KeyEventHandler(this.HookManager_KeyUp);
              num1 = (int) num3 * 2131583775 ^ 1356641572;
              continue;
            case 4:
              num1 = (int) num3 * -469567488 ^ 1558870489;
              continue;
            case 5:
              num1 = (int) num3 * -1783257364 ^ -1596420118;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_3:;
      }
    }

    private event KeyEventHandler m_KeyDown
    {
      add
      {
        KeyEventHandler keyEventHandler1 = this.m_KeyDown;
label_1:
        int num1 = 985978542;
        while (true)
        {
          int num2 = 1420844447;
          uint num3;
          KeyEventHandler comparand;
          KeyEventHandler keyEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = keyEventHandler1;
              keyEventHandler2 = (KeyEventHandler) GlobalEventProvider.\u206B‭⁭⁭‫⁬‮‏‎⁫⁭⁯‏​​‍⁬‪​‬‌⁭⁬‏‍‬​‎⁫⁮‍⁮⁭‮⁭​⁭‫⁯⁮‮((Delegate) comparand, (Delegate) value);
              num1 = 1358244968;
              continue;
            case 2:
              goto label_1;
            case 3:
              keyEventHandler1 = Interlocked.CompareExchange<KeyEventHandler>(ref this.m_KeyDown, keyEventHandler2, comparand);
              int num4 = keyEventHandler1 != comparand ? 1417603579 : (num4 = 598845178);
              int num5 = (int) num3 * -1869543917;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
      remove
      {
        KeyEventHandler keyEventHandler = this.m_KeyDown;
label_1:
        int num1 = 393893549;
        while (true)
        {
          int num2 = 1206162588;
          uint num3;
          KeyEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = keyEventHandler;
              num1 = 131647805;
              continue;
            case 2:
              int num4 = keyEventHandler != comparand ? 1837096309 : (num4 = 825731989);
              int num5 = (int) num3 * 1936173118;
              num1 = num4 ^ num5;
              continue;
            case 3:
              keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.m_KeyDown, (KeyEventHandler) GlobalEventProvider.\u206B​‭⁬⁭‎‪⁫‬‏⁪‏‏⁪‫⁭‬⁯⁪‭⁭‫‌⁯⁫⁯‏⁯⁭‌⁪⁬⁬‏‌‫‏‫‏⁬‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -1692485625 ^ -1841590417;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public event KeyEventHandler KeyDown
    {
      add
      {
        bool flag = this.m_KeyDown == null;
label_1:
        int num1 = -1885335328;
        while (true)
        {
          int num2 = -1302712802;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 2104974366 ^ -815535163;
              continue;
            case 1:
              goto label_3;
            case 2:
              KeyboardHookManager.KeyDown += new KeyEventHandler(this.HookManager_KeyDown);
              num1 = (int) num3 * -2103243386 ^ -293106077;
              continue;
            case 3:
              goto label_1;
            case 4:
              num1 = (int) num3 * -1354792262 ^ 892721280;
              continue;
            case 5:
              this.m_KeyDown += value;
              num1 = -2056683744;
              continue;
            case 6:
              int num4 = flag ? -515090079 : (num4 = -271122503);
              int num5 = (int) num3 * -1043292398;
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
      remove
      {
label_1:
        int num1 = -1859966718;
        while (true)
        {
          int num2 = -451035532;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              int num4 = !flag ? 1065743954 : (num4 = 324444433);
              int num5 = (int) num3 * -1209476890;
              num1 = num4 ^ num5;
              continue;
            case 1:
              flag = this.m_KeyDown == null;
              num1 = (int) num3 * 413309608 ^ 1130633245;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.m_KeyDown -= value;
              num1 = (int) num3 * -1531737317 ^ 1580138011;
              continue;
            case 4:
              num1 = (int) num3 * -95913930 ^ -1040230365;
              continue;
            case 5:
              num1 = (int) num3 * 2079093169 ^ 987924422;
              continue;
            case 6:
              num1 = (int) num3 * 1305594865 ^ 316379385;
              continue;
            case 7:
              KeyboardHookManager.KeyDown -= new KeyEventHandler(this.HookManager_KeyDown);
              num1 = (int) num3 * -193182692 ^ -1842709457;
              continue;
            case 8:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      bool flag = this.m_KeyPress != null;
label_1:
      int num1 = -2105783786;
      while (true)
      {
        int num2 = -1688916385;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1207690103 ^ 656074948;
            continue;
          case 3:
            num1 = (int) num3 * -819787119 ^ 1828030551;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            this.m_KeyPress((object) this, e);
            num1 = (int) num3 * -4831753 ^ -126955615;
            continue;
          case 5:
            int num4 = !flag ? 224845961 : (num4 = 540959840);
            int num5 = (int) num3 * 374160307;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    private void HookManager_KeyUp(object sender, KeyEventArgs e)
    {
label_1:
      int num1 = -41933788;
      while (true)
      {
        int num2 = -238020238;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -677415235 ^ 865796676;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.m_KeyUp((object) this, e);
            num1 = (int) num3 * 1072343452 ^ 424746285;
            continue;
          case 3:
            num1 = (int) num3 * -2054742165 ^ 578626405;
            continue;
          case 4:
            int num4 = flag ? -848692293 : (num4 = -800513719);
            int num5 = (int) num3 * -1801429089;
            num1 = num4 ^ num5;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            flag = this.m_KeyUp != null;
            num1 = (int) num3 * 1517791061 ^ -1327931898;
            continue;
          case 6:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private void HookManager_KeyDown(object sender, KeyEventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      this.m_KeyDown((object) this, e);
    }

    static Delegate \u206B‭⁭⁭‫⁬‮‏‎⁫⁭⁯‏​​‍⁬‪​‬‌⁭⁬‏‍‬​‎⁫⁮‍⁮⁭‮⁭​⁭‫⁯⁮‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u206B​‭⁬⁭‎‪⁫‬‏⁪‏‏⁪‫⁭‬⁯⁪‭⁭‫‌⁯⁫⁯‏⁯⁭‌⁪⁬⁬‏‌‫‏‫‏⁬‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }
  }
}
