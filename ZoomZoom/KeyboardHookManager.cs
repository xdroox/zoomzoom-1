// Decompiled with JetBrains decompiler
// Type: ZoomZoom.KeyboardHookManager
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
  public class KeyboardHookManager
  {
    private static MouseButtons s_PrevClickedButton;
    private static System.Windows.Forms.Timer s_DoubleClickTimer;
    private const int WH_MOUSE_LL = 14;
    private const int WH_KEYBOARD_LL = 13;
    private const int WH_MOUSE = 7;
    private const int WH_KEYBOARD = 2;
    private const int WM_MOUSEMOVE = 512;
    private const int WM_LBUTTONDOWN = 513;
    private const int WM_RBUTTONDOWN = 516;
    private const int WM_MBUTTONDOWN = 519;
    private const int WM_LBUTTONUP = 514;
    private const int WM_RBUTTONUP = 517;
    private const int WM_MBUTTONUP = 520;
    private const int WM_LBUTTONDBLCLK = 515;
    private const int WM_RBUTTONDBLCLK = 518;
    private const int WM_MBUTTONDBLCLK = 521;
    private const int WM_MOUSEWHEEL = 522;
    private const int WM_KEYDOWN = 256;
    private const int WM_KEYUP = 257;
    private const int WM_SYSKEYDOWN = 260;
    private const int WM_SYSKEYUP = 261;
    private const byte VK_SHIFT = 16;
    private const byte VK_CAPITAL = 20;
    private const byte VK_NUMLOCK = 144;
    private static KeyboardHookManager.HookProc s_MouseDelegate;
    private static int s_MouseHookHandle;
    private static int m_OldX;
    private static int m_OldY;
    private static KeyboardHookManager.HookProc s_KeyboardDelegate;
    private static int s_KeyboardHookHandle;
    private static int refTimeMs;

    private static event MouseEventHandler s_MouseMove
    {
      add
      {
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseMove;
label_1:
        int num1 = -1450332215;
        while (true)
        {
          int num2 = -1824636128;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              int num4 = mouseEventHandler1 == comparand ? -238709398 : (num4 = -1277896759);
              int num5 = (int) num3 * 157006592;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = mouseEventHandler1;
              num1 = -1892671738;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 2091556377 ^ -2006496361;
              continue;
            case 5:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseMove, mouseEventHandler2, comparand);
              num1 = (int) num3 * -363019018 ^ -378495682;
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
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseMove;
label_1:
        int num1 = -61666163;
        while (true)
        {
          int num2 = -1455827456;
          uint num3;
          MouseEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = mouseEventHandler1;
              MouseEventHandler mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseMove, mouseEventHandler2, comparand);
              num1 = -1736097161;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = mouseEventHandler1 == comparand ? 950164177 : (num4 = 418679290);
              int num5 = (int) num3 * 1969084161;
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
    }

    public static event MouseEventHandler MouseMove
    {
      add
      {
        KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
label_1:
        int num1 = 1294383963;
        while (true)
        {
          int num2 = 138073013;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              KeyboardHookManager.s_MouseMove += value;
              num1 = (int) num3 * -1168245218 ^ 183595183;
              continue;
            case 2:
              num1 = (int) num3 * -1389526167 ^ 825087790;
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
      remove
      {
label_1:
        int num1 = -1757904414;
        while (true)
        {
          int num2 = -1295902711;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1418399215 ^ 1821205820;
              continue;
            case 2:
              goto label_1;
            case 3:
              KeyboardHookManager.s_MouseMove -= value;
              num1 = (int) num3 * -751317116 ^ 1209923329;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
      }
    }

    private static event EventHandler<MouseEventExtArgs> s_MouseMoveExt
    {
      add
      {
        EventHandler<MouseEventExtArgs> eventHandler1 = KeyboardHookManager.s_MouseMoveExt;
label_1:
        int num1 = -1939489864;
        while (true)
        {
          int num2 = -1138810099;
          uint num3;
          EventHandler<MouseEventExtArgs> eventHandler2;
          EventHandler<MouseEventExtArgs> comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              eventHandler2 = (EventHandler<MouseEventExtArgs>) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1606298315 ^ -1885086206;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = eventHandler1;
              num1 = -323845173;
              continue;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler<MouseEventExtArgs>>(ref KeyboardHookManager.s_MouseMoveExt, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? 342618720 : (num4 = 299810512);
              int num5 = (int) num3 * 530989880;
              num1 = num4 ^ num5;
              continue;
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
        EventHandler<MouseEventExtArgs> eventHandler1 = KeyboardHookManager.s_MouseMoveExt;
label_1:
        int num1 = 462910103;
        while (true)
        {
          int num2 = 900168768;
          uint num3;
          EventHandler<MouseEventExtArgs> comparand;
          EventHandler<MouseEventExtArgs> eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = eventHandler1 == comparand ? -1534071783 : (num4 = -983454229);
              int num5 = (int) num3 * 1113392702;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = eventHandler1;
              eventHandler2 = (EventHandler<MouseEventExtArgs>) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              num1 = 969540887;
              continue;
            case 4:
              eventHandler1 = Interlocked.CompareExchange<EventHandler<MouseEventExtArgs>>(ref KeyboardHookManager.s_MouseMoveExt, eventHandler2, comparand);
              num1 = (int) num3 * 2066886344 ^ -572197062;
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

    public static event EventHandler<MouseEventExtArgs> MouseMoveExt
    {
      add
      {
label_1:
        int num1 = 2004414079;
        while (true)
        {
          int num2 = 575592893;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              KeyboardHookManager.s_MouseMoveExt += value;
              num1 = (int) num3 * -1425012385 ^ 1176295614;
              continue;
            case 2:
              num1 = (int) num3 * -1328863143 ^ -1395513801;
              continue;
            case 3:
              KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
              num1 = (int) num3 * 1266188527 ^ -1017992190;
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
label_1:
        int num1 = -12506221;
        while (true)
        {
          int num2 = -717541206;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
              num1 = (int) num3 * -789455896 ^ -1032570788;
              continue;
            case 1:
              KeyboardHookManager.s_MouseMoveExt -= value;
              num1 = (int) num3 * -816228171 ^ 383947915;
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

    private static event MouseEventHandler s_MouseClick
    {
      add
      {
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseClick;
label_1:
        int num1 = -2066452651;
        while (true)
        {
          int num2 = -1343174631;
          uint num3;
          MouseEventHandler mouseEventHandler2;
          MouseEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseClick, mouseEventHandler2, comparand);
              num1 = (int) num3 * 1469743882 ^ 1485564411;
              continue;
            case 2:
              int num4 = mouseEventHandler1 != comparand ? -537012307 : (num4 = -452493902);
              int num5 = (int) num3 * 8697171;
              num1 = num4 ^ num5;
              continue;
            case 3:
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1894234974 ^ 382050102;
              continue;
            case 4:
              comparand = mouseEventHandler1;
              num1 = -1866635730;
              continue;
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
      remove
      {
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseClick;
label_1:
        int num1 = 1174199981;
        while (true)
        {
          int num2 = 1423037556;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseClick, mouseEventHandler2, comparand);
              int num4 = mouseEventHandler1 != comparand ? 1933579669 : (num4 = 486434038);
              int num5 = (int) num3 * 1226024003;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = mouseEventHandler1;
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              num1 = 1531798556;
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

    public static event MouseEventHandler MouseClick
    {
      add
      {
        KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
label_1:
        int num1 = -681543124;
        while (true)
        {
          int num2 = -1364551089;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1620807564 ^ 939326874;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              KeyboardHookManager.s_MouseClick += value;
              num1 = (int) num3 * -1526175636 ^ 1115532227;
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
label_1:
        int num1 = 1461560016;
        while (true)
        {
          int num2 = 2123909651;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1058831163 ^ -183846736;
              continue;
            case 3:
              KeyboardHookManager.s_MouseClick -= value;
              num1 = (int) num3 * 278309169 ^ -1869615206;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
      }
    }

    private static event EventHandler<MouseEventExtArgs> s_MouseClickExt
    {
      add
      {
        EventHandler<MouseEventExtArgs> eventHandler1 = KeyboardHookManager.s_MouseClickExt;
label_1:
        int num1 = 1890985817;
        while (true)
        {
          int num2 = 2034055164;
          uint num3;
          EventHandler<MouseEventExtArgs> comparand;
          EventHandler<MouseEventExtArgs> eventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              eventHandler1 = Interlocked.CompareExchange<EventHandler<MouseEventExtArgs>>(ref KeyboardHookManager.s_MouseClickExt, eventHandler2, comparand);
              int num4 = eventHandler1 != comparand ? 1149587832 : (num4 = 440781861);
              int num5 = (int) num3 * -20646763;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_3;
            case 2:
              eventHandler2 = (EventHandler<MouseEventExtArgs>) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1711710768 ^ -317754207;
              continue;
            case 3:
              goto label_1;
            case 4:
              comparand = eventHandler1;
              num1 = 690041772;
              continue;
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
        EventHandler<MouseEventExtArgs> eventHandler1 = KeyboardHookManager.s_MouseClickExt;
label_1:
        int num1 = -1785962073;
        while (true)
        {
          int num2 = -1699593752;
          uint num3;
          EventHandler<MouseEventExtArgs> comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              EventHandler<MouseEventExtArgs> eventHandler2 = (EventHandler<MouseEventExtArgs>) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              eventHandler1 = Interlocked.CompareExchange<EventHandler<MouseEventExtArgs>>(ref KeyboardHookManager.s_MouseClickExt, eventHandler2, comparand);
              num1 = (int) num3 * -1854391509 ^ -632529644;
              continue;
            case 1:
              int num4 = eventHandler1 == comparand ? 1384672754 : (num4 = 2032712494);
              int num5 = (int) num3 * -143414971;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = eventHandler1;
              num1 = -484346125;
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

    public static event EventHandler<MouseEventExtArgs> MouseClickExt
    {
      add
      {
label_1:
        int num1 = -38057616;
        while (true)
        {
          int num2 = -817859383;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1284960683 ^ 1129026603;
              continue;
            case 1:
              KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
              KeyboardHookManager.s_MouseClickExt += value;
              num1 = (int) num3 * 1681722667 ^ -2095653814;
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
      remove
      {
label_1:
        int num1 = -847423712;
        while (true)
        {
          int num2 = -293412635;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              KeyboardHookManager.s_MouseClickExt -= value;
              KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
              num1 = (int) num3 * -386339679 ^ 385708774;
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

    private static event MouseEventHandler s_MouseDown
    {
      add
      {
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseDown;
label_1:
        int num1 = -189456101;
        while (true)
        {
          int num2 = -1192706541;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseDown, mouseEventHandler2, comparand);
              int num4 = mouseEventHandler1 == comparand ? -1877374135 : (num4 = -1003678492);
              int num5 = (int) num3 * 260405681;
              num1 = num4 ^ num5;
              continue;
            case 1:
              comparand = mouseEventHandler1;
              num1 = -1261311299;
              continue;
            case 2:
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1674225683 ^ -2120360022;
              continue;
            case 3:
              goto label_1;
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
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseDown;
label_1:
        int num1 = -152602566;
        while (true)
        {
          int num2 = -1627231080;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = mouseEventHandler1;
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              num1 = -224025075;
              continue;
            case 2:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseDown, mouseEventHandler2, comparand);
              num1 = (int) num3 * -1128586520 ^ -1280006188;
              continue;
            case 3:
              int num4 = mouseEventHandler1 == comparand ? 173487745 : (num4 = 1882590838);
              int num5 = (int) num3 * 379858915;
              num1 = num4 ^ num5;
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

    public static event MouseEventHandler MouseDown
    {
      add
      {
        KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
label_1:
        int num1 = -914546399;
        while (true)
        {
          int num2 = -1284273620;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -477044529 ^ 497843755;
              continue;
            case 1:
              KeyboardHookManager.s_MouseDown += value;
              num1 = (int) num3 * 1305039522 ^ -1103300906;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
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
        KeyboardHookManager.s_MouseDown -= value;
label_1:
        int num1 = -948280292;
        while (true)
        {
          int num2 = -1488408563;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
              num1 = (int) num3 * -1789062304 ^ 793266947;
              continue;
            case 1:
              num1 = (int) num3 * -1830077455 ^ 1115733692;
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

    private static event MouseEventHandler s_MouseUp
    {
      add
      {
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseUp;
label_1:
        int num1 = -1144261640;
        while (true)
        {
          int num2 = -1486882010;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = mouseEventHandler1;
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = -199032154;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = mouseEventHandler1 != comparand ? 912711576 : (num4 = 1662483174);
              int num5 = (int) num3 * 2002973538;
              num1 = num4 ^ num5;
              continue;
            case 4:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseUp, mouseEventHandler2, comparand);
              num1 = (int) num3 * -1109280226 ^ -191130858;
              continue;
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
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseUp;
label_1:
        int num1 = 926704449;
        while (true)
        {
          int num2 = 950001170;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseUp, mouseEventHandler2, comparand);
              int num4 = mouseEventHandler1 == comparand ? 1953707049 : (num4 = 1942777152);
              int num5 = (int) num3 * 898988301;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              comparand = mouseEventHandler1;
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              num1 = 903224791;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public static event MouseEventHandler MouseUp
    {
      add
      {
        KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
label_1:
        int num1 = 2071453509;
        while (true)
        {
          int num2 = 1533570495;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              KeyboardHookManager.s_MouseUp += value;
              num1 = (int) num3 * -1552490360 ^ 742104247;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
      remove
      {
        KeyboardHookManager.s_MouseUp -= value;
label_1:
        int num1 = 30452060;
        while (true)
        {
          int num2 = 584116175;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1369110620 ^ 1696742093;
              continue;
            case 2:
              goto label_3;
            case 3:
              KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
              num1 = (int) num3 * -465564791 ^ 661611881;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    private static event MouseEventHandler s_MouseWheel
    {
      add
      {
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseWheel;
label_1:
        int num1 = -163335582;
        while (true)
        {
          int num2 = -1763066564;
          uint num3;
          MouseEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              MouseEventHandler mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseWheel, mouseEventHandler2, comparand);
              int num4 = mouseEventHandler1 == comparand ? 964155389 : (num4 = 1504010672);
              int num5 = (int) num3 * 2060271346;
              num1 = num4 ^ num5;
              continue;
            case 2:
              comparand = mouseEventHandler1;
              num1 = -392434483;
              continue;
            case 3:
              goto label_3;
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
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseWheel;
label_1:
        int num1 = 2054796958;
        while (true)
        {
          int num2 = 21912350;
          uint num3;
          MouseEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              MouseEventHandler mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseWheel, mouseEventHandler2, comparand);
              num1 = (int) num3 * -178639989 ^ -73990752;
              continue;
            case 3:
              comparand = mouseEventHandler1;
              num1 = 1102902456;
              continue;
            case 4:
              int num4 = mouseEventHandler1 == comparand ? -93835211 : (num4 = -961681810);
              int num5 = (int) num3 * 1807030884;
              num1 = num4 ^ num5;
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

    public static event MouseEventHandler MouseWheel
    {
      add
      {
label_1:
        int num1 = 823617484;
        while (true)
        {
          int num2 = 474250455;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
              num1 = (int) num3 * 200362863 ^ -1928884762;
              continue;
            case 3:
              KeyboardHookManager.s_MouseWheel += value;
              num1 = (int) num3 * -783860738 ^ -1842807464;
              continue;
            case 4:
              num1 = (int) num3 * 112920824 ^ 1500521938;
              continue;
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
label_1:
        int num1 = -1189978024;
        while (true)
        {
          int num2 = -410347147;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              KeyboardHookManager.s_MouseWheel -= value;
              num1 = (int) num3 * -693199784 ^ 325170214;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * -1560785923 ^ 1479926622;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
      }
    }

    private static event MouseEventHandler s_MouseDoubleClick
    {
      add
      {
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseDoubleClick;
label_1:
        int num1 = 780692710;
        while (true)
        {
          int num2 = 2068185989;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = mouseEventHandler1;
              num1 = 58448740;
              continue;
            case 2:
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1422301224 ^ -1670598802;
              continue;
            case 3:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseDoubleClick, mouseEventHandler2, comparand);
              int num4 = mouseEventHandler1 != comparand ? -117409410 : (num4 = -1202280227);
              int num5 = (int) num3 * -1860576248;
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
        MouseEventHandler mouseEventHandler1 = KeyboardHookManager.s_MouseDoubleClick;
label_1:
        int num1 = 1042954523;
        while (true)
        {
          int num2 = 1689592485;
          uint num3;
          MouseEventHandler comparand;
          MouseEventHandler mouseEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = mouseEventHandler1;
              num1 = 1577152135;
              continue;
            case 2:
              goto label_3;
            case 3:
              mouseEventHandler2 = (MouseEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1399969479 ^ 2050358580;
              continue;
            case 4:
              mouseEventHandler1 = Interlocked.CompareExchange<MouseEventHandler>(ref KeyboardHookManager.s_MouseDoubleClick, mouseEventHandler2, comparand);
              int num4 = mouseEventHandler1 != comparand ? 1539121965 : (num4 = 61238061);
              int num5 = (int) num3 * -1870265838;
              num1 = num4 ^ num5;
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

    public static event MouseEventHandler MouseDoubleClick
    {
      add
      {
label_1:
        int num1 = 891973334;
        while (true)
        {
          int num2 = 1788027003;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              KeyboardHookManager.s_MouseDoubleClick += value;
              num1 = 153770701;
              continue;
            case 1:
              KeyboardHookManager.EnsureSubscribedToGlobalMouseEvents();
              flag = KeyboardHookManager.s_MouseDoubleClick == null;
              num1 = (int) num3 * -1406237026 ^ 1099708570;
              continue;
            case 2:
              System.Windows.Forms.Timer timer = KeyboardHookManager.\u206D⁮⁮‬⁬⁮​‬‏‏⁫‪‏​‌‍⁫‮‮‎‏⁪​‌‏⁬‌‬‎⁪‬‮‪‎‪‪⁪‮⁪‎‮();
              int doubleClickTime = KeyboardHookManager.GetDoubleClickTime();
              KeyboardHookManager.\u202E‎⁮⁬‏‎‌⁬‪⁬⁪‮⁯‍⁮‎‭‎‍‮‬‮‏‫‍‏‪‭‭‮‬‏‫‎‪⁬⁫‌⁪‌‮(timer, doubleClickTime);
              int num4 = 0;
              KeyboardHookManager.\u202A‏‪‍‏⁬‬‍‌‍⁯⁪‫‌‫‏‍‍‪⁯‬⁭‭​⁯‮​‫‮‫⁬‭​‎‍‬⁫⁫‏‎‮(timer, num4 != 0);
              KeyboardHookManager.s_DoubleClickTimer = timer;
              num1 = (int) num3 * 162134630 ^ 1063165354;
              continue;
            case 3:
              num1 = (int) num3 * 292324938 ^ 2079304981;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num5 = flag ? 1575540562 : (num5 = 742151175);
              int num6 = (int) num3 * -1661650204;
              num1 = num5 ^ num6;
              continue;
            case 6:
              num1 = (int) num3 * -88849020 ^ 1940990347;
              continue;
            case 7:
              KeyboardHookManager.\u200B‫​‫‫‎‎‏‭‭⁭⁪‍‪⁬‪⁮‌‎⁬‮⁭‪‮‌‮​‌⁯⁯‏‌⁮‪‫‌‫‮‫‍‮(KeyboardHookManager.s_DoubleClickTimer, new EventHandler(KeyboardHookManager.DoubleClickTimeElapsed));
              KeyboardHookManager.MouseUp += new MouseEventHandler(KeyboardHookManager.OnMouseUp);
              num1 = (int) num3 * 1401389204 ^ -1373809194;
              continue;
            case 8:
              goto label_3;
            case 9:
              num1 = (int) num3 * -1406962164 ^ -280642917;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_3:;
      }
      remove
      {
        if (KeyboardHookManager.s_MouseDoubleClick == null)
          goto label_6;
label_1:
        int num1 = -1017234970;
label_2:
        while (true)
        {
          int num2 = -949973763;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              num1 = -663623966;
              continue;
            case 1:
              num1 = (int) num3 * 401293647 ^ -1906055756;
              continue;
            case 2:
              int num4 = KeyboardHookManager.s_MouseDoubleClick != null ? -629833163 : (num4 = -1969248348);
              int num5 = (int) num3 * -2067043965;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
            case 4:
              KeyboardHookManager.MouseUp -= new MouseEventHandler(KeyboardHookManager.OnMouseUp);
              num1 = (int) num3 * -1215978415 ^ -431040797;
              continue;
            case 5:
              goto label_6;
            case 6:
              KeyboardHookManager.\u200B‪‍⁮‪⁬‭‫⁭⁯‮⁭⁪‍‭⁯‍‍‭⁬‭⁭‫‫⁮⁭⁭‭‪‪‫⁮‌​‮​‮‬‪‏‮(KeyboardHookManager.s_DoubleClickTimer, new EventHandler(KeyboardHookManager.DoubleClickTimeElapsed));
              KeyboardHookManager.s_DoubleClickTimer = (System.Windows.Forms.Timer) null;
              num1 = (int) num3 * -2124653623 ^ -1065164715;
              continue;
            case 7:
              num1 = (int) num3 * -604154756 ^ 1096628452;
              continue;
            case 8:
              goto label_1;
            case 9:
              KeyboardHookManager.s_MouseDoubleClick -= value;
              num1 = (int) num3 * 1220618180 ^ 1749575925;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_3:
        return;
label_6:
        KeyboardHookManager.TryUnsubscribeFromGlobalMouseEvents();
        num1 = -431477522;
        goto label_2;
      }
    }

    private static event KeyPressEventHandler s_KeyPress
    {
      add
      {
        KeyPressEventHandler pressEventHandler1 = KeyboardHookManager.s_KeyPress;
label_1:
        int num1 = 2113846866;
        while (true)
        {
          int num2 = 747005156;
          uint num3;
          KeyPressEventHandler comparand;
          KeyPressEventHandler pressEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = pressEventHandler1;
              num1 = 91891786;
              continue;
            case 2:
              pressEventHandler1 = Interlocked.CompareExchange<KeyPressEventHandler>(ref KeyboardHookManager.s_KeyPress, pressEventHandler2, comparand);
              int num4 = pressEventHandler1 != comparand ? -1270932607 : (num4 = -1079361878);
              int num5 = (int) num3 * -1779444069;
              num1 = num4 ^ num5;
              continue;
            case 3:
              pressEventHandler2 = (KeyPressEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1921939440 ^ 931175213;
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
        KeyPressEventHandler pressEventHandler1 = KeyboardHookManager.s_KeyPress;
label_1:
        int num1 = 1940595847;
        while (true)
        {
          int num2 = 574208246;
          uint num3;
          KeyPressEventHandler comparand;
          KeyPressEventHandler pressEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = pressEventHandler1;
              pressEventHandler2 = (KeyPressEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              num1 = 1789349876;
              continue;
            case 2:
              pressEventHandler1 = Interlocked.CompareExchange<KeyPressEventHandler>(ref KeyboardHookManager.s_KeyPress, pressEventHandler2, comparand);
              int num4 = pressEventHandler1 != comparand ? 1008739305 : (num4 = 714145911);
              int num5 = (int) num3 * 64715575;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public static event KeyPressEventHandler KeyPress
    {
      add
      {
label_1:
        int num1 = 559052441;
        while (true)
        {
          int num2 = 390782152;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              KeyboardHookManager.EnsureSubscribedToGlobalKeyboardEvents();
              num1 = (int) num3 * 954883151 ^ -743512704;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 2092031634 ^ 1649311946;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        KeyboardHookManager.s_KeyPress += value;
      }
      remove
      {
label_1:
        int num1 = -2065269623;
        while (true)
        {
          int num2 = -236862299;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              KeyboardHookManager.s_KeyPress -= value;
              KeyboardHookManager.TryUnsubscribeFromGlobalKeyboardEvents();
              num1 = (int) num3 * -1604388507 ^ 1714346347;
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

    private static event KeyEventHandler s_KeyUp
    {
      add
      {
        KeyEventHandler keyEventHandler1 = KeyboardHookManager.s_KeyUp;
label_1:
        int num1 = -158601363;
        while (true)
        {
          int num2 = -1622682908;
          uint num3;
          KeyEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              comparand = keyEventHandler1;
              num1 = -982245998;
              continue;
            case 2:
              KeyEventHandler keyEventHandler2 = (KeyEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              keyEventHandler1 = Interlocked.CompareExchange<KeyEventHandler>(ref KeyboardHookManager.s_KeyUp, keyEventHandler2, comparand);
              int num4 = keyEventHandler1 != comparand ? -1208316215 : (num4 = -220634853);
              int num5 = (int) num3 * 1516570710;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
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
        KeyEventHandler keyEventHandler1 = KeyboardHookManager.s_KeyUp;
label_1:
        int num1 = 665857708;
        while (true)
        {
          int num2 = 1660467438;
          uint num3;
          KeyEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              comparand = keyEventHandler1;
              KeyEventHandler keyEventHandler2 = (KeyEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              keyEventHandler1 = Interlocked.CompareExchange<KeyEventHandler>(ref KeyboardHookManager.s_KeyUp, keyEventHandler2, comparand);
              num1 = 1072272693;
              continue;
            case 3:
              int num4 = keyEventHandler1 != comparand ? 1173472165 : (num4 = 914293034);
              int num5 = (int) num3 * 863440875;
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
    }

    public static event KeyEventHandler KeyUp
    {
      add
      {
label_1:
        int num1 = 1552083255;
        while (true)
        {
          int num2 = 897120534;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 236594840 ^ 1263872721;
              continue;
            case 1:
              KeyboardHookManager.EnsureSubscribedToGlobalKeyboardEvents();
              num1 = (int) num3 * -72547951 ^ 1161137759;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        KeyboardHookManager.s_KeyUp += value;
      }
      remove
      {
label_1:
        int num1 = 308215914;
        while (true)
        {
          int num2 = 2019824179;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              KeyboardHookManager.s_KeyUp -= value;
              num1 = (int) num3 * 246001753 ^ -809918592;
              continue;
            case 2:
              KeyboardHookManager.TryUnsubscribeFromGlobalKeyboardEvents();
              num1 = (int) num3 * -1190094012 ^ 994894568;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    private static event KeyEventHandler s_KeyDown
    {
      add
      {
        KeyEventHandler keyEventHandler1 = KeyboardHookManager.s_KeyDown;
label_1:
        int num1 = 960653197;
        while (true)
        {
          int num2 = 385980288;
          uint num3;
          KeyEventHandler keyEventHandler2;
          KeyEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              keyEventHandler2 = (KeyEventHandler) KeyboardHookManager.\u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1080360578 ^ -1114321879;
              continue;
            case 1:
              comparand = keyEventHandler1;
              num1 = 2129348286;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              keyEventHandler1 = Interlocked.CompareExchange<KeyEventHandler>(ref KeyboardHookManager.s_KeyDown, keyEventHandler2, comparand);
              int num4 = keyEventHandler1 == comparand ? -1941298319 : (num4 = -1310846419);
              int num5 = (int) num3 * -1962700768;
              num1 = num4 ^ num5;
              continue;
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
        KeyEventHandler keyEventHandler1 = KeyboardHookManager.s_KeyDown;
label_1:
        int num1 = -1048184400;
        while (true)
        {
          int num2 = -1581219606;
          uint num3;
          KeyEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              KeyEventHandler keyEventHandler2 = (KeyEventHandler) KeyboardHookManager.\u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮((Delegate) comparand, (Delegate) value);
              keyEventHandler1 = Interlocked.CompareExchange<KeyEventHandler>(ref KeyboardHookManager.s_KeyDown, keyEventHandler2, comparand);
              num1 = (int) num3 * -360133450 ^ -631800732;
              continue;
            case 1:
              comparand = keyEventHandler1;
              num1 = -603536538;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = keyEventHandler1 == comparand ? 893207036 : (num4 = 778426764);
              int num5 = (int) num3 * -1621589750;
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
    }

    public static event KeyEventHandler KeyDown
    {
      add
      {
label_1:
        int num1 = -563844462;
        while (true)
        {
          int num2 = -1335433466;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              KeyboardHookManager.EnsureSubscribedToGlobalKeyboardEvents();
              num1 = (int) num3 * -1542351277 ^ -569804859;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        KeyboardHookManager.s_KeyDown += value;
      }
      remove
      {
        KeyboardHookManager.s_KeyDown -= value;
label_1:
        int num1 = -768519558;
        while (true)
        {
          int num2 = -957358020;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              KeyboardHookManager.TryUnsubscribeFromGlobalKeyboardEvents();
              num1 = (int) num3 * -1174680320 ^ 2025180853;
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

    public KeyboardHookManager()
    {
label_1:
      int num1 = 1251128943;
      while (true)
      {
        int num2 = 1840203011;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -833362247 ^ -1357384839;
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

    private static void DoubleClickTimeElapsed(object sender, EventArgs e)
    {
label_1:
      int num1 = 708267436;
      while (true)
      {
        int num2 = 1529078576;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            KeyboardHookManager.\u202A‏‪‍‏⁬‬‍‌‍⁯⁪‫‌‫‏‍‍‪⁯‬⁭‭​⁯‮​‫‮‫⁬‭​‎‍‬⁫⁫‏‎‮(KeyboardHookManager.s_DoubleClickTimer, false);
            num1 = (int) num3 * -1057695861 ^ 829154086;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      KeyboardHookManager.s_PrevClickedButton = MouseButtons.None;
    }

    private static void OnMouseUp(object sender, MouseEventArgs e)
    {
      if (KeyboardHookManager.\u202C‌​‪‬⁪‬‏​⁮⁭‎⁯‪​‬⁫​‪‬​‌‏⁮⁬‎⁪‏⁫⁭‬⁯​​‏⁪⁯‍‍⁮‮(e) >= 1)
        goto label_7;
label_1:
      int num1 = -1465475597;
label_2:
      MouseButtons mouseButtons;
      while (true)
      {
        int num2 = -1263405173;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 15U)
        {
          case 0:
            int num4 = mouseButtons.Equals((object) KeyboardHookManager.s_PrevClickedButton) ? 292138078 : (num4 = 23541243);
            int num5 = (int) num3 * -1429124233;
            num1 = num4 ^ num5;
            continue;
          case 1:
            KeyboardHookManager.s_PrevClickedButton = MouseButtons.None;
            num1 = (int) num3 * -816346778 ^ -1163604323;
            continue;
          case 2:
            num1 = (int) num3 * -500928225 ^ 1875668737;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -696426014 ^ -1498231753;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * 235540778 ^ 201943203;
            continue;
          case 7:
            num1 = (int) num3 * -163127063 ^ -1908096737;
            continue;
          case 8:
            num1 = -720389273;
            continue;
          case 9:
            goto label_7;
          case 10:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseDoubleClick((object) null, e);
            num1 = (int) num3 * 1000533143 ^ 504715185;
            continue;
          case 11:
            num1 = (int) num3 * -1618514076 ^ -1897080591;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            int num6 = KeyboardHookManager.s_MouseDoubleClick == null ? 1342630776 : (num6 = 775069760);
            int num7 = (int) num3 * -1105047217;
            num1 = num6 ^ num7;
            continue;
          case 13:
            KeyboardHookManager.\u202A‏‪‍‏⁬‬‍‌‍⁯⁪‫‌‫‏‍‍‪⁯‬⁭‭​⁯‮​‫‮‫⁬‭​‎‍‬⁫⁫‏‎‮(KeyboardHookManager.s_DoubleClickTimer, false);
            num1 = -452932246;
            continue;
          case 14:
            KeyboardHookManager.\u202A‏‪‍‏⁬‬‍‌‍⁯⁪‫‌‫‏‍‍‪⁯‬⁭‭​⁯‮​‫‮‫⁬‭​‎‍‬⁫⁫‏‎‮(KeyboardHookManager.s_DoubleClickTimer, true);
            KeyboardHookManager.s_PrevClickedButton = KeyboardHookManager.\u206B‫‮⁬⁭‫‏‬‬‍‎‫‬‎‪‪‫‏‫​‏‎‬⁭⁮‬‎‫⁫‮‏⁫‪‪⁭​⁫‮‎⁭‮(e);
            num1 = (int) num3 * -640303135 ^ 84773195;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return;
label_3:
      return;
label_7:
      mouseButtons = KeyboardHookManager.\u206B‫‮⁬⁭‫‏‬‬‍‎‫‬‎‪‪‫‏‫​‏‎‬⁭⁮‬‎‫⁫‮‏⁫‪‪⁭​⁫‮‎⁭‮(e);
      num1 = -475783195;
      goto label_2;
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
    private static extern int SetWindowsHookEx(int idHook, KeyboardHookManager.HookProc lpfn, IntPtr hMod, int dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
    private static extern int UnhookWindowsHookEx(int idHook);

    [DllImport("user32")]
    public static extern int GetDoubleClickTime();

    [DllImport("user32")]
    private static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

    [DllImport("user32")]
    private static extern int GetKeyboardState(byte[] pbKeyState);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern short GetKeyState(int vKey);

    private static int MouseHookProc(int nCode, int wParam, IntPtr lParam)
    {
label_1:
      int num1 = -1472514950;
      int num2;
      while (true)
      {
        int num3 = -342653205;
        uint num4;
        int clicks;
        short num5;
        KeyboardHookManager.MouseLLHookStruct structure;
        MouseButtons buttons;
        bool flag1;
        DateTime now;
        int millisecond;
        bool flag2;
        bool flag3;
        MouseEventExtArgs e;
        bool flag4;
        bool flag5;
        bool flag6;
        int num6;
        bool flag7;
        bool flag8;
        int num7;
        int num8;
        int num9;
        int num10;
        int num11;
        int num12;
        switch ((num4 = (uint) (num1 ^ num3)) % 84U)
        {
          case 0:
            num1 = (int) num4 * -1578248549 ^ -175727648;
            continue;
          case 1:
            num1 = -2105623872;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseMoveExt != null)
            {
              num1 = (int) num4 * -1248557942 ^ -807699033;
              continue;
            }
            num7 = 0;
            goto label_82;
          case 3:
            num2 = KeyboardHookManager.CallNextHookEx(KeyboardHookManager.s_MouseHookHandle, nCode, wParam, lParam);
            num1 = (int) num4 * 2096323258 ^ -616516274;
            continue;
          case 4:
            num1 = (int) num4 * 880274975 ^ -943984709;
            continue;
          case 5:
            KeyboardHookManager.refTimeMs = now.Millisecond;
            num1 = (int) num4 * 955557789 ^ 1141299246;
            continue;
          case 6:
            num1 = (int) num4 * -1768719793 ^ -2025089591;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseClickExt != null)
            {
              num1 = -1469869670;
              continue;
            }
            num8 = 0;
            goto label_57;
          case 8:
            num9 = millisecond > KeyboardHookManager.refTimeMs ? 1 : 0;
            goto label_78;
          case 9:
label_41:
            buttons = MouseButtons.Left;
            clicks = 2;
            num1 = -1991345943;
            continue;
          case 10:
            int num13;
            // ISSUE: reference to a compiler-generated field
            num1 = num13 = KeyboardHookManager.s_MouseMove == null ? -1870337159 : (num13 = -833411821);
            continue;
          case 11:
            int num14 = !flag4 ? 1695420737 : (num14 = 838985773);
            int num15 = (int) num4 * -1867893033;
            num1 = num14 ^ num15;
            continue;
          case 12:
label_20:
            if (millisecond - KeyboardHookManager.refTimeMs < 200)
            {
              num1 = -1912815673;
              continue;
            }
            num9 = 0;
            goto label_78;
          case 13:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseMove((object) null, (MouseEventArgs) e);
            num1 = (int) num4 * -2081288925 ^ -1450862782;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseClick == null)
            {
              num10 = 0;
              break;
            }
            num1 = -2069642462;
            continue;
          case 15:
            buttons = MouseButtons.Left;
            num1 = (int) num4 * 882374976 ^ -1673563481;
            continue;
          case 16:
label_30:
            num5 = (short) (structure.MouseData >> 16 & (int) ushort.MaxValue);
            num1 = -110351589;
            continue;
          case 17:
            num8 = clicks > 0 ? 1 : 0;
            goto label_57;
          case 18:
            num1 = (int) num4 * -268029026 ^ -210910510;
            continue;
          case 20:
            goto label_1;
          case 21:
            flag5 = nCode >= 0;
            num1 = (int) num4 * 1234865238 ^ 2098903464;
            continue;
          case 22:
            num1 = (int) num4 * -948088093 ^ 1351529727;
            continue;
          case 23:
            int num16 = flag6 ? 1221434234 : (num16 = 1464966653);
            int num17 = (int) num4 * -1636334547;
            num1 = num16 ^ num17;
            continue;
          case 24:
            clicks = 1;
            num1 = (int) num4 * -328810829 ^ -1022599721;
            continue;
          case 25:
            num11 = clicks == 2 ? 1 : 0;
            goto label_52;
          case 26:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseClick((object) null, (MouseEventArgs) e);
            num1 = (int) num4 * 662528378 ^ -651007681;
            continue;
          case 27:
            num1 = (int) num4 * 65881558 ^ -1611846237;
            continue;
          case 28:
            flag3 = false;
            num1 = (int) num4 * 209247582 ^ 1376746512;
            continue;
          case 29:
            num7 = KeyboardHookManager.m_OldY != structure.Point.Y ? 1 : 0;
            goto label_82;
          case 30:
            clicks = 0;
            num1 = (int) num4 * 90957449 ^ -2082165779;
            continue;
          case 31:
            int num18 = flag7 ? 1714310670 : (num18 = 178063989);
            int num19 = (int) num4 * -1880118452;
            num1 = num18 ^ num19;
            continue;
          case 32:
          case 67:
label_43:
            e = new MouseEventExtArgs(buttons, clicks, structure.Point.X, structure.Point.Y, (int) num5);
            int num20;
            // ISSUE: reference to a compiler-generated field
            num1 = num20 = KeyboardHookManager.s_MouseUp != null & flag2 ? -1257193985 : (num20 = -515662519);
            continue;
          case 33:
            num10 = clicks > 0 ? 1 : 0;
            break;
          case 34:
            int num21;
            num1 = num21 = !e.Handled ? -840485738 : (num21 = -564745190);
            continue;
          case 35:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseClickExt((object) null, e);
            num1 = (int) num4 * 1021334675 ^ -307672428;
            continue;
          case 36:
label_73:
            flag3 = true;
            buttons = MouseButtons.Right;
            num1 = -288555027;
            continue;
          case 37:
            num1 = -1892995239;
            continue;
          case 38:
            // ISSUE: reference to a compiler-generated field
            flag7 = KeyboardHookManager.s_MouseDown != null & flag3;
            num1 = -1226852076;
            continue;
          case 39:
            structure = (KeyboardHookManager.MouseLLHookStruct) Marshal.PtrToStructure(lParam, typeof (KeyboardHookManager.MouseLLHookStruct));
            buttons = MouseButtons.None;
            num1 = (int) num4 * -1854950694 ^ 738331490;
            continue;
          case 40:
            if (KeyboardHookManager.m_OldX != structure.Point.X)
            {
              num7 = 1;
              goto label_82;
            }
            else
            {
              num1 = -591483642;
              continue;
            }
          case 41:
            KeyboardHookManager.m_OldX = structure.Point.X;
            KeyboardHookManager.m_OldY = structure.Point.Y;
            num1 = (int) num4 * -1525437130 ^ 1028027256;
            continue;
          case 42:
            now = DateTime.Now;
            millisecond = now.Millisecond;
            num1 = (int) num4 * 637535758 ^ -1446145588;
            continue;
          case 43:
            num2 = KeyboardHookManager.CallNextHookEx(KeyboardHookManager.s_MouseHookHandle, nCode, wParam, lParam);
            num1 = -1531713328;
            continue;
          case 44:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseDown((object) null, (MouseEventArgs) e);
            num1 = (int) num4 * 1520490467 ^ 153997481;
            continue;
          case 45:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseWheel == null)
            {
              num12 = 0;
              goto label_36;
            }
            else
            {
              num1 = -372811371;
              continue;
            }
          case 46:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseMoveExt((object) null, e);
            num1 = (int) num4 * -762119334 ^ -2078566948;
            continue;
          case 47:
            num5 = (short) 0;
            num1 = (int) num4 * 997396948 ^ 104569013;
            continue;
          case 48:
            num1 = (int) num4 * -221007936 ^ -1960909694;
            continue;
          case 49:
            int num22 = !flag1 ? 560262331 : (num22 = 155866779);
            int num23 = (int) num4 * -1289534011;
            num1 = num22 ^ num23;
            continue;
          case 50:
            num2 = -1;
            num1 = (int) num4 * 1198724104 ^ 1817628224;
            continue;
          case 51:
            num6 = wParam;
            num1 = (int) num4 * 1669517363 ^ 1799714357;
            continue;
          case 52:
            num1 = (int) num4 * 151538460 ^ -162884067;
            continue;
          case 53:
label_38:
            buttons = MouseButtons.Right;
            clicks = 2;
            num1 = -776023108;
            continue;
          case 54:
            num12 = (uint) num5 > 0U ? 1 : 0;
            goto label_36;
          case 55:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseWheel((object) null, (MouseEventArgs) e);
            num1 = (int) num4 * 872519059 ^ -1887721684;
            continue;
          case 56:
            num1 = (int) num4 * 520869399 ^ -788043527;
            continue;
          case 57:
label_65:
            flag2 = true;
            buttons = MouseButtons.Left;
            clicks = 1;
            num1 = -110351589;
            continue;
          case 58:
            num1 = (int) num4 * 1546156780 ^ 1038677948;
            continue;
          case 59:
            switch (num6)
            {
              case 512:
                goto label_20;
              case 513:
                goto label_27;
              case 514:
                goto label_65;
              case 515:
                goto label_41;
              case 516:
                goto label_73;
              case 517:
                goto label_15;
              case 518:
                goto label_38;
              case 519:
              case 520:
              case 521:
                goto label_43;
              case 522:
                goto label_30;
              default:
                num1 = (int) num4 * 1348690814 ^ -1149422871;
                continue;
            }
          case 60:
            // ISSUE: reference to a compiler-generated field
            int num24 = KeyboardHookManager.s_MouseMove != null ? -102764748 : (num24 = -805385047);
            int num25 = (int) num4 * 2106803577;
            num1 = num24 ^ num25;
            continue;
          case 61:
            num1 = (int) num4 * 629393440 ^ 86613427;
            continue;
          case 62:
            clicks = 1;
            num1 = (int) num4 * 1793316845 ^ 221593493;
            continue;
          case 63:
            num1 = (int) num4 * -285651705 ^ 1257386433;
            continue;
          case 64:
label_27:
            flag3 = true;
            num1 = -2140397088;
            continue;
          case 65:
            num1 = (int) num4 * 1499836058 ^ -714771517;
            continue;
          case 66:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseUp((object) null, (MouseEventArgs) e);
            num1 = (int) num4 * -1475195988 ^ 1354381568;
            continue;
          case 68:
            int num26 = !flag8 ? 569364417 : (num26 = 1942022013);
            int num27 = (int) num4 * -1153839635;
            num1 = num26 ^ num27;
            continue;
          case 69:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_MouseDoubleClick((object) null, (MouseEventArgs) e);
            num1 = (int) num4 * -6792547 ^ -182178298;
            continue;
          case 70:
            int num28;
            // ISSUE: reference to a compiler-generated field
            num1 = num28 = KeyboardHookManager.s_MouseMoveExt == null ? -750973674 : (num28 = -1300430011);
            continue;
          case 71:
            num1 = (int) num4 * -1571510981 ^ 1469289750;
            continue;
          case 72:
            clicks = 1;
            num1 = (int) num4 * 1491723599 ^ 495328559;
            continue;
          case 73:
            int num29 = !flag5 ? 1339318233 : (num29 = 2073612348);
            int num30 = (int) num4 * 1346770453;
            num1 = num29 ^ num30;
            continue;
          case 74:
            num1 = (int) num4 * -1897401643 ^ -1781788495;
            continue;
          case 75:
            flag2 = false;
            num1 = (int) num4 * 717901341 ^ 1551473815;
            continue;
          case 76:
label_15:
            flag2 = true;
            num1 = -927687999;
            continue;
          case 77:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseDoubleClick == null)
            {
              num11 = 0;
              goto label_52;
            }
            else
            {
              num1 = -239627262;
              continue;
            }
          case 78:
            buttons = MouseButtons.Right;
            num1 = (int) num4 * 757894530 ^ 543587771;
            continue;
          case 79:
            num1 = (int) num4 * -97017031 ^ -1152910315;
            continue;
          case 80:
            num1 = (int) num4 * 1593044230 ^ -213144550;
            continue;
          case 81:
            now = DateTime.Now;
            num1 = (int) num4 * -1880230430 ^ 519738668;
            continue;
          case 82:
            num1 = (int) num4 * 303736231 ^ 554814265;
            continue;
          case 83:
            num1 = (int) num4 * -1923742394 ^ 655892724;
            continue;
          default:
            goto label_105;
        }
        int num31;
        num1 = num31 = num10 == 0 ? -2022139384 : (num31 = -889634619);
        continue;
label_36:
        int num32;
        num1 = num32 = num12 == 0 ? -1427428047 : (num32 = -688230480);
        continue;
label_52:
        flag1 = num11 != 0;
        num1 = -1211762362;
        continue;
label_57:
        flag6 = num8 != 0;
        num1 = -980515792;
        continue;
label_78:
        flag4 = num9 != 0;
        num1 = -352189056;
        continue;
label_82:
        flag8 = num7 != 0;
        num1 = -1536882413;
      }
label_105:
      return num2;
    }

    private static void EnsureSubscribedToGlobalMouseEvents()
    {
label_1:
      int num1 = -664654785;
      int lastWin32Error;
      while (true)
      {
        int num2 = -1643373654;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = !flag1 ? -685064681 : (num4 = -1179188294);
            int num5 = (int) num3 * -1200396317;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = -406925293;
            continue;
          case 3:
            int num6 = flag2 ? -778028932 : (num6 = -627555892);
            int num7 = (int) num3 * -1023065010;
            num1 = num6 ^ num7;
            continue;
          case 4:
            flag1 = KeyboardHookManager.s_MouseHookHandle == 0;
            num1 = (int) num3 * 1634435160 ^ -338357826;
            continue;
          case 5:
            lastWin32Error = Marshal.GetLastWin32Error();
            num1 = (int) num3 * -1914577243 ^ -2015290574;
            continue;
          case 6:
            KeyboardHookManager.s_MouseDelegate = new KeyboardHookManager.HookProc(KeyboardHookManager.MouseHookProc);
            KeyboardHookManager.s_MouseHookHandle = KeyboardHookManager.SetWindowsHookEx(14, KeyboardHookManager.s_MouseDelegate, new IntPtr(0), 0);
            flag2 = KeyboardHookManager.s_MouseHookHandle == 0;
            num1 = (int) num3 * -677059977 ^ 1517183954;
            continue;
          case 7:
            num1 = (int) num3 * 250428380 ^ 545814322;
            continue;
          case 8:
            goto label_8;
          case 9:
            goto label_3;
          case 10:
            num1 = (int) num3 * 1560704999 ^ -2144979562;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:
      return;
label_8:
      throw new Win32Exception(lastWin32Error);
    }

    private static void TryUnsubscribeFromGlobalMouseEvents()
    {
label_1:
      int num1 = 693552246;
      while (true)
      {
        int num2 = 100872107;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseDown == null)
            {
              num1 = (int) num3 * -1899949314 ^ -1035299593;
              continue;
            }
            break;
          case 1:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseClick == null)
            {
              num1 = (int) num3 * -1341622674 ^ 70751104;
              continue;
            }
            break;
          case 2:
            goto label_3;
          case 3:
            KeyboardHookManager.ForceUnsunscribeFromGlobalMouseEvents();
            num1 = (int) num3 * -1983869179 ^ 781288484;
            continue;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseMoveExt == null)
            {
              num1 = (int) num3 * -1500386235 ^ -1156732187;
              continue;
            }
            break;
          case 6:
            int num5 = flag ? 1933802927 : (num5 = 2135944240);
            int num6 = (int) num3 * -1930102954;
            num1 = num5 ^ num6;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseClickExt == null)
            {
              num1 = (int) num3 * -606457790 ^ 5700297;
              continue;
            }
            break;
          case 8:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseMove == null)
            {
              num1 = (int) num3 * 1746778621 ^ -1430518308;
              continue;
            }
            break;
          case 9:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_MouseUp == null)
            {
              num1 = (int) num3 * 1932694154 ^ 1054405197;
              continue;
            }
            break;
          case 10:
            // ISSUE: reference to a compiler-generated field
            num4 = KeyboardHookManager.s_MouseWheel == null ? 1 : 0;
            goto label_10;
          default:
            goto label_21;
        }
        num4 = 0;
label_10:
        flag = num4 != 0;
        num1 = 1641206431;
      }
label_21:
      return;
label_3:;
    }

    private static void ForceUnsunscribeFromGlobalMouseEvents()
    {
label_1:
      int num1 = -898812421;
      int num2;
      while (true)
      {
        int num3 = -240203903;
        uint num4;
        bool flag;
        int num5;
        switch ((num4 = (uint) (num1 ^ num3)) % 12U)
        {
          case 0:
            num1 = (int) num4 * -1718054351 ^ 1232664704;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_4;
          case 3:
            int num6 = num5 == 0 ? -1464246328 : (num6 = -827431783);
            int num7 = (int) num4 * -2047563822;
            num1 = num6 ^ num7;
            continue;
          case 4:
            goto label_1;
          case 5:
            num5 = KeyboardHookManager.UnhookWindowsHookEx(KeyboardHookManager.s_MouseHookHandle);
            num1 = (int) num4 * 1565943936 ^ 1173223040;
            continue;
          case 6:
            flag = (uint) KeyboardHookManager.s_MouseHookHandle > 0U;
            num1 = (int) num4 * -292964670 ^ 1459997985;
            continue;
          case 7:
            num2 = KeyboardHookManager.\u200B⁬⁮‏‫‪⁬‏​‏‎‫‪‌‫⁭‬⁯⁯‌‪⁫‎‬‎‮‌⁭⁯⁯⁮‭‎⁭‏⁪‍‮⁭‍‮();
            num1 = (int) num4 * 1074002586 ^ -303096759;
            continue;
          case 8:
            int num8 = flag ? -1226165435 : (num8 = -1932938416);
            int num9 = (int) num4 * -662252444;
            num1 = num8 ^ num9;
            continue;
          case 9:
            KeyboardHookManager.s_MouseHookHandle = 0;
            num1 = (int) num4 * 1506648368 ^ 2050654618;
            continue;
          case 10:
            num1 = -13088384;
            continue;
          case 11:
            KeyboardHookManager.s_MouseDelegate = (KeyboardHookManager.HookProc) null;
            num1 = (int) num4 * -1312180156 ^ -1762830862;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:
      return;
label_4:
      throw KeyboardHookManager.\u202C⁭‍⁮⁭⁫⁮‬‌‭⁪⁬‮‭⁮​⁯⁮‌⁮⁭‭‪⁮‏‏‫⁯⁪​‏‬‍‎‪‎‍‍‪‮‮(num2);
    }

    private static int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
    {
      bool flag1 = false;
label_1:
      int num1 = -1252709682;
      int num2;
      while (true)
      {
        int num3 = -266066647;
        uint num4;
        KeyboardHookManager.KeyboardHookStruct keyboardHookStruct;
        KeyEventArgs e1;
        char upper;
        KeyPressEventArgs e2;
        bool flag2;
        KeyEventArgs e3;
        byte[] numArray;
        byte[] lpwTransKey;
        bool flag3;
        bool flag4;
        bool flag5;
        bool flag6;
        bool flag7;
        int num5;
        int num6;
        int num7;
        int num8;
        int num9;
        int num10;
        int num11;
        int num12;
        switch ((num4 = (uint) (num1 ^ num3)) % 52U)
        {
          case 0:
            int num13 = !flag7 ? 1401368068 : (num13 = 1856162907);
            int num14 = (int) num4 * -1187450268;
            num1 = num13 ^ num14;
            continue;
          case 1:
            num2 = -1;
            num1 = (int) num4 * 138687283 ^ 875962558;
            continue;
          case 2:
            int num15 = !flag3 ? 1700289050 : (num15 = 727719360);
            int num16 = (int) num4 * 392738479;
            num1 = num15 ^ num16;
            continue;
          case 3:
            if (!flag1)
            {
              num1 = (int) num4 * -1375849754 ^ -509377173;
              continue;
            }
            num5 = 1;
            goto label_33;
          case 4:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_KeyUp != null)
            {
              num1 = -1162949367;
              continue;
            }
            num6 = 0;
            goto label_52;
          case 5:
            num7 = wParam == 256 ? 1 : 0;
            break;
          case 6:
            goto label_1;
          case 7:
            int num17 = nCode < 0 ? -1134957222 : (num17 = -1007649705);
            int num18 = (int) num4 * -862376317;
            num1 = num17 ^ num18;
            continue;
          case 8:
            if (wParam == 257)
            {
              num6 = 1;
              goto label_52;
            }
            else
            {
              num1 = (int) num4 * 1651373823 ^ 1743151624;
              continue;
            }
          case 9:
            num1 = -196416955;
            continue;
          case 10:
            num8 = 0;
            goto label_43;
          case 11:
            num9 = char.IsLetter(upper) ? 1 : 0;
            goto label_67;
          case 12:
            num1 = (int) num4 * -506908497 ^ -387003112;
            continue;
          case 13:
            num1 = (int) num4 * 304757000 ^ -641579171;
            continue;
          case 14:
            num1 = (int) num4 * 1905882293 ^ -603061079;
            continue;
          case 15:
            int num19 = flag6 ? 450299594 : (num19 = 1655076088);
            int num20 = (int) num4 * 857788767;
            num1 = num19 ^ num20;
            continue;
          case 16:
            if (wParam != 256)
            {
              num1 = (int) num4 * -1895703593 ^ 953002718;
              continue;
            }
            num10 = 1;
            goto label_48;
          case 17:
            flag1 = KeyboardHookManager.\u206E​‮⁬⁪‪‬‪‫⁫‪⁯⁭‬⁬‫‮⁫‍⁮⁪⁫​⁯‪‫​⁯⁫‫‍‏‍‪‍‪⁯‬‌‬‮(e1);
            num1 = (int) num4 * -905914585 ^ 1804963967;
            continue;
          case 18:
            upper = char.ToUpper(upper);
            num1 = (int) num4 * -1355354785 ^ 647325843;
            continue;
          case 19:
            int num21 = !flag2 ? 45389644 : (num21 = 566803995);
            int num22 = (int) num4 * -1617695125;
            num1 = num21 ^ num22;
            continue;
          case 20:
            if (flag4 ^ flag5)
            {
              num1 = (int) num4 * 161188525 ^ -1385841706;
              continue;
            }
            num9 = 0;
            goto label_67;
          case 21:
            num1 = -761509777;
            continue;
          case 22:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_KeyDown == null)
            {
              num10 = 0;
              goto label_48;
            }
            else
            {
              num1 = (int) num4 * -987166113 ^ 1815648923;
              continue;
            }
          case 23:
            num1 = (int) num4 * -1157241572 ^ 565996242;
            continue;
          case 24:
            if (!flag1)
            {
              num1 = (int) num4 * 1639696787 ^ -976821649;
              continue;
            }
            num11 = 1;
            goto label_37;
          case 25:
            num12 = 0;
            goto label_79;
          case 26:
            num11 = KeyboardHookManager.\u206D⁪‏⁯‬⁫‫⁯‌⁫⁮⁪​⁪‍‭‎‮‭⁯⁫⁬‬⁪⁮‏⁪‬‌‏‮‏⁭⁭​⁬⁮​‬‏‮(e2) ? 1 : 0;
            goto label_37;
          case 27:
            lpwTransKey = new byte[2];
            num1 = (int) num4 * -1562429491 ^ -1876011673;
            continue;
          case 28:
            e2 = KeyboardHookManager.\u206A‭‪‌‪‎⁮‌⁫⁪‏‮⁭‪‎⁯‬‫⁬‌‎⁫⁫​⁭​⁫‭‌‬‫‪⁯‬⁫‫‍​‬‌‮(upper);
            num1 = -571450538;
            continue;
          case 29:
            if ((int) KeyboardHookManager.GetKeyState(20) == 0)
            {
              num1 = (int) num4 * 2016878973 ^ 970687361;
              continue;
            }
            num12 = 1;
            goto label_79;
          case 30:
            KeyboardHookManager.GetKeyboardState(numArray);
            num1 = (int) num4 * -2029497363 ^ 1168393296;
            continue;
          case 31:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_KeyPress((object) null, e2);
            num1 = (int) num4 * -397677349 ^ -1713289406;
            continue;
          case 33:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_KeyUp((object) null, e3);
            num1 = (int) num4 * 977006854 ^ -912792260;
            continue;
          case 34:
            num1 = (int) num4 * 1756880897 ^ -1205119285;
            continue;
          case 35:
            num1 = (int) num4 * -278155978 ^ 1626878891;
            continue;
          case 36:
            num5 = KeyboardHookManager.\u206E​‮⁬⁪‪‬‪‫⁫‪⁯⁭‬⁬‫‮⁫‍⁮⁪⁫​⁯‪‫​⁯⁫‫‍‏‍‪‍‪⁯‬‌‬‮(e3) ? 1 : 0;
            goto label_33;
          case 37:
            numArray = new byte[256];
            num1 = (int) num4 * 1977571435 ^ -1559241272;
            continue;
          case 38:
            int num23;
            num1 = num23 = flag1 ? -764566620 : (num23 = -525035113);
            continue;
          case 39:
            num1 = (int) num4 * 349739567 ^ 988640233;
            continue;
          case 40:
            upper = (char) lpwTransKey[0];
            num1 = (int) num4 * 125227421 ^ 78902361;
            continue;
          case 41:
            flag3 = KeyboardHookManager.ToAscii(keyboardHookStruct.VirtualKeyCode, keyboardHookStruct.ScanCode, numArray, lpwTransKey, keyboardHookStruct.Flags) == 1;
            num1 = (int) num4 * -233701578 ^ 180567581;
            continue;
          case 42:
            num2 = KeyboardHookManager.CallNextHookEx(KeyboardHookManager.s_KeyboardHookHandle, nCode, wParam, lParam);
            num1 = -1412315735;
            continue;
          case 43:
            // ISSUE: type reference
            keyboardHookStruct = (KeyboardHookManager.KeyboardHookStruct) KeyboardHookManager.\u202C⁪‌‭⁬⁫‏​​‌‏‏‬‪‏‎‭‮⁮⁫‪⁯​‫‍‫‭⁯⁫⁯‎‭⁭⁪‭‮⁪‏‎‍‮(lParam, KeyboardHookManager.\u200F‫⁬⁬⁭⁭‎‬‍⁯‏⁯​⁯‫‍⁬​‬⁫⁫‍‭‌‪⁭⁫​⁮⁬‬‮‬‏‍⁫‮⁯‍⁫‮(__typeref (KeyboardHookManager.KeyboardHookStruct)));
            num1 = (int) num4 * 452315065 ^ -411259768;
            continue;
          case 44:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_KeyPress == null)
            {
              num7 = 0;
              break;
            }
            num1 = -1752646776;
            continue;
          case 45:
            num6 = wParam == 261 ? 1 : 0;
            goto label_52;
          case 46:
            e1 = KeyboardHookManager.\u200C⁫‭‏‪⁫⁭‭‮⁭‪‭‏‌​⁯‭‫‬‬‫⁬⁭⁭‬⁪‭⁮⁮⁬‌‫⁫‎⁬‏‎‍‌‏‮((Keys) keyboardHookStruct.VirtualKeyCode);
            num1 = (int) num4 * -1091288191 ^ 919611779;
            continue;
          case 47:
            num10 = wParam == 260 ? 1 : 0;
            goto label_48;
          case 48:
            // ISSUE: reference to a compiler-generated field
            KeyboardHookManager.s_KeyDown((object) null, e1);
            num1 = (int) num4 * 738278689 ^ 538678322;
            continue;
          case 49:
            num1 = (int) num4 * 1895280941 ^ -1653753411;
            continue;
          case 50:
            e3 = KeyboardHookManager.\u200C⁫‭‏‪⁫⁭‭‮⁭‪‭‏‌​⁯‭‫‬‬‫⁬⁭⁭‬⁪‭⁮⁮⁬‌‫⁫‎⁬‏‎‍‌‏‮((Keys) keyboardHookStruct.VirtualKeyCode);
            num1 = (int) num4 * 1271041528 ^ 1070333940;
            continue;
          case 51:
            if (((int) KeyboardHookManager.GetKeyState(16) & 128) == 128)
            {
              num8 = 1;
              goto label_43;
            }
            else
            {
              num1 = (int) num4 * -1011277508 ^ 51847515;
              continue;
            }
          default:
            goto label_81;
        }
        flag2 = num7 != 0;
        num1 = -941927822;
        continue;
label_33:
        flag1 = num5 != 0;
        num1 = -938243363;
        continue;
label_37:
        flag1 = num11 != 0;
        num1 = -1581336732;
        continue;
label_43:
        flag5 = num8 != 0;
        num1 = -1310469752;
        continue;
label_48:
        flag6 = num10 != 0;
        num1 = -715143078;
        continue;
label_52:
        flag7 = num6 != 0;
        num1 = -55522691;
        continue;
label_67:
        int num24;
        num1 = num24 = num9 != 0 ? -1893925589 : (num24 = -487888339);
        continue;
label_79:
        flag4 = num12 != 0;
        num1 = -364841552;
      }
label_81:
      return num2;
    }

    private static void EnsureSubscribedToGlobalKeyboardEvents()
    {
label_1:
      int num1 = 1723325433;
      int lastWin32Error;
      while (true)
      {
        int num2 = 705552817;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = 483517978;
            continue;
          case 1:
            goto label_8;
          case 2:
            goto label_3;
          case 3:
            KeyboardHookManager.s_KeyboardHookHandle = KeyboardHookManager.SetWindowsHookEx(13, KeyboardHookManager.s_KeyboardDelegate, new IntPtr(0), 0);
            flag = KeyboardHookManager.s_KeyboardHookHandle == 0;
            num1 = (int) num3 * 2046939797 ^ 2073570678;
            continue;
          case 4:
            lastWin32Error = Marshal.GetLastWin32Error();
            num1 = (int) num3 * 1918278725 ^ 320288762;
            continue;
          case 5:
            goto label_1;
          case 6:
            KeyboardHookManager.s_KeyboardDelegate = new KeyboardHookManager.HookProc(KeyboardHookManager.KeyboardHookProc);
            num1 = (int) num3 * 1796209906 ^ 1233224010;
            continue;
          case 7:
            int num4 = !flag ? 20796680 : (num4 = 1030119669);
            int num5 = (int) num3 * -1558009198;
            num1 = num4 ^ num5;
            continue;
          case 8:
            int num6 = KeyboardHookManager.s_KeyboardHookHandle != 0 ? 1833488794 : (num6 = 262058180);
            int num7 = (int) num3 * -1196343440;
            num1 = num6 ^ num7;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:
      return;
label_8:
      throw new Win32Exception(lastWin32Error);
    }

    private static void TryUnsubscribeFromGlobalKeyboardEvents()
    {
      // ISSUE: reference to a compiler-generated field
      if (KeyboardHookManager.s_KeyDown != null)
        goto label_9;
label_1:
      int num1 = -299859675;
label_2:
      while (true)
      {
        int num2 = -241465352;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            KeyboardHookManager.ForceUnsunscribeFromGlobalKeyboardEvents();
            num1 = (int) num3 * 553771751 ^ 249014572;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            if (KeyboardHookManager.s_KeyUp == null)
            {
              num1 = (int) num3 * 55323729 ^ 17582840;
              continue;
            }
            goto label_9;
          case 2:
            num1 = (int) num3 * -140973326 ^ -67950637;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:
      return;
label_8:
      // ISSUE: reference to a compiler-generated field
      int num4 = KeyboardHookManager.s_KeyPress == null ? 1 : 0;
      goto label_10;
label_9:
      num4 = 0;
label_10:
      num1 = num4 == 0 ? -943626273 : (num1 = -802957386);
      goto label_2;
    }

    private static void ForceUnsunscribeFromGlobalKeyboardEvents()
    {
label_1:
      int num1 = 209981419;
      while (true)
      {
        int num2 = 1250264223;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            int num5 = num4 == 0 ? -1733848338 : (num5 = -1277159700);
            int num6 = (int) num3 * -2076775263;
            num1 = num5 ^ num6;
            continue;
          case 1:
            num1 = (int) num3 * 1548661022 ^ 1819859369;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = 1262508541;
            continue;
          case 4:
            goto label_5;
          case 5:
            goto label_1;
          case 6:
            int num7 = (uint) KeyboardHookManager.s_KeyboardHookHandle > 0U ? -1531666173 : (num7 = -1518359083);
            int num8 = (int) num3 * -2054105198;
            num1 = num7 ^ num8;
            continue;
          case 7:
            num4 = KeyboardHookManager.UnhookWindowsHookEx(KeyboardHookManager.s_KeyboardHookHandle);
            num1 = (int) num3 * -2114178715 ^ -2010600571;
            continue;
          case 8:
            num1 = (int) num3 * 144608111 ^ 763651394;
            continue;
          case 9:
            KeyboardHookManager.s_KeyboardHookHandle = 0;
            KeyboardHookManager.s_KeyboardDelegate = (KeyboardHookManager.HookProc) null;
            num1 = (int) num3 * 1220391968 ^ -1285953255;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:
      return;
label_5:
      throw KeyboardHookManager.\u202C⁭‍⁮⁭⁫⁮‬‌‭⁪⁬‮‭⁮​⁯⁮‌⁮⁭‭‪⁮‏‏‫⁯⁪​‏‬‍‎‪‎‍‍‪‮‮(KeyboardHookManager.\u200B⁬⁮‏‫‪⁬‏​‏‎‫‪‌‫⁭‬⁯⁯‌‪⁫‎‬‎‮‌⁭⁯⁯⁮‭‎⁭‏⁪‍‮⁭‍‮());
    }

    static Delegate \u200C‫⁫​‏‭‪⁮⁪⁬⁪‎‌‪⁭⁬‪‬⁮⁯⁭‫⁪‭‏⁫⁭⁫⁫⁯‌⁫⁯‌​⁮‏⁯⁫⁪‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u200C‭‌⁬‎⁮⁯‌‪⁬‍‮‌‪⁭⁭‏‏‭‬⁮‌‍‭‫⁪‫⁯⁫⁫‮⁪‬‎‪‮⁯‬⁫⁯‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static System.Windows.Forms.Timer \u206D⁮⁮‬⁬⁮​‬‏‏⁫‪‏​‌‍⁫‮‮‎‏⁪​‌‏⁬‌‬‎⁪‬‮‪‎‪‪⁪‮⁪‎‮()
    {
      return new System.Windows.Forms.Timer();
    }

    static void \u202E‎⁮⁬‏‎‌⁬‪⁬⁪‮⁯‍⁮‎‭‎‍‮‬‮‏‫‍‏‪‭‭‮‬‏‫‎‪⁬⁫‌⁪‌‮([In] System.Windows.Forms.Timer obj0, [In] int obj1)
    {
      obj0.Interval = obj1;
    }

    static void \u202A‏‪‍‏⁬‬‍‌‍⁯⁪‫‌‫‏‍‍‪⁯‬⁭‭​⁯‮​‫‮‫⁬‭​‎‍‬⁫⁫‏‎‮([In] System.Windows.Forms.Timer obj0, [In] bool obj1)
    {
      obj0.Enabled = obj1;
    }

    static void \u200B‫​‫‫‎‎‏‭‭⁭⁪‍‪⁬‪⁮‌‎⁬‮⁭‪‮‌‮​‌⁯⁯‏‌⁮‪‫‌‫‮‫‍‮([In] System.Windows.Forms.Timer obj0, [In] EventHandler obj1)
    {
      obj0.Tick += obj1;
    }

    static void \u200B‪‍⁮‪⁬‭‫⁭⁯‮⁭⁪‍‭⁯‍‍‭⁬‭⁭‫‫⁮⁭⁭‭‪‪‫⁮‌​‮​‮‬‪‏‮([In] System.Windows.Forms.Timer obj0, [In] EventHandler obj1)
    {
      obj0.Tick -= obj1;
    }

    static int \u202C‌​‪‬⁪‬‏​⁮⁭‎⁯‪​‬⁫​‪‬​‌‏⁮⁬‎⁪‏⁫⁭‬⁯​​‏⁪⁯‍‍⁮‮([In] MouseEventArgs obj0)
    {
      return obj0.Clicks;
    }

    static MouseButtons \u206B‫‮⁬⁭‫‏‬‬‍‎‫‬‎‪‪‫‏‫​‏‎‬⁭⁮‬‎‫⁫‮‏⁫‪‪⁭​⁫‮‎⁭‮([In] MouseEventArgs obj0)
    {
      return obj0.Button;
    }

    static int \u200B⁬⁮‏‫‪⁬‏​‏‎‫‪‌‫⁭‬⁯⁯‌‪⁫‎‬‎‮‌⁭⁯⁯⁮‭‎⁭‏⁪‍‮⁭‍‮()
    {
      return Marshal.GetLastWin32Error();
    }

    static Win32Exception \u202C⁭‍⁮⁭⁫⁮‬‌‭⁪⁬‮‭⁮​⁯⁮‌⁮⁭‭‪⁮‏‏‫⁯⁪​‏‬‍‎‪‎‍‍‪‮‮([In] int obj0)
    {
      return new Win32Exception(obj0);
    }

    static System.Type \u200F‫⁬⁬⁭⁭‎‬‍⁯‏⁯​⁯‫‍⁬​‬⁫⁫‍‭‌‪⁭⁫​⁮⁬‬‮‬‏‍⁫‮⁯‍⁫‮([In] RuntimeTypeHandle obj0)
    {
      return System.Type.GetTypeFromHandle(obj0);
    }

    static object \u202C⁪‌‭⁬⁫‏​​‌‏‏‬‪‏‎‭‮⁮⁫‪⁯​‫‍‫‭⁯⁫⁯‎‭⁭⁪‭‮⁪‏‎‍‮([In] IntPtr obj0, [In] System.Type obj1)
    {
      return Marshal.PtrToStructure(obj0, obj1);
    }

    static KeyEventArgs \u200C⁫‭‏‪⁫⁭‭‮⁭‪‭‏‌​⁯‭‫‬‬‫⁬⁭⁭‬⁪‭⁮⁮⁬‌‫⁫‎⁬‏‎‍‌‏‮([In] Keys obj0)
    {
      return new KeyEventArgs(obj0);
    }

    static bool \u206E​‮⁬⁪‪‬‪‫⁫‪⁯⁭‬⁬‫‮⁫‍⁮⁪⁫​⁯‪‫​⁯⁫‫‍‏‍‪‍‪⁯‬‌‬‮([In] KeyEventArgs obj0)
    {
      return obj0.Handled;
    }

    static KeyPressEventArgs \u206A‭‪‌‪‎⁮‌⁫⁪‏‮⁭‪‎⁯‬‫⁬‌‎⁫⁫​⁭​⁫‭‌‬‫‪⁯‬⁫‫‍​‬‌‮([In] char obj0)
    {
      return new KeyPressEventArgs(obj0);
    }

    static bool \u206D⁪‏⁯‬⁫‫⁯‌⁫⁮⁪​⁪‍‭‎‮‭⁯⁫⁬‬⁪⁮‏⁪‬‌‏‮‏⁭⁭​⁬⁮​‬‏‮([In] KeyPressEventArgs obj0)
    {
      return obj0.Handled;
    }

    private struct Point
    {
      public int X;
      public int Y;
    }

    private struct MouseLLHookStruct
    {
      public KeyboardHookManager.Point Point;
      public int MouseData;
      public int Flags;
      public int Time;
      public int ExtraInfo;
    }

    private struct KeyboardHookStruct
    {
      public int VirtualKeyCode;
      public int ScanCode;
      public int Flags;
      public int Time;
      public int ExtraInfo;
    }

    private delegate int HookProc(int nCode, int wParam, IntPtr lParam);
  }
}
