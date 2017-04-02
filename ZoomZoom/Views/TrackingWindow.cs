// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Views.TrackingWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace ZoomZoom.Views
{
  public class TrackingWindow : Window, IComponentConnector
  {
    protected static readonly ILog log = TrackingWindow.\u200F⁯⁮‬⁮‬‫‌​‭‌​⁯‫‪‭‬‌‮‭‏‏‎‬‪‮⁯‎‪⁬​‪⁫‪‍⁬⁭‪‌⁬‮(TrackingWindow.\u206D⁯‮⁪⁭⁮‏‍‍‏‌‭⁪‫​‍‮⁭‭‎⁯⁭‎⁮‌⁭⁯​‎‫‍⁭‬‭⁮‫⁪⁯​‍‮((MemberInfo) TrackingWindow.\u202C⁪‬⁭⁯‌⁬⁭‮⁬⁫⁭‏‎‪⁪‮‫⁬‍⁭⁪‪‏⁯​‬​⁮‍⁯‍⁭⁪⁯⁫⁯‫​‍‮()));
    private IntPtr targetHandle = IntPtr.Zero;
    private ZoomWindow zoomWindow = (ZoomWindow) null;
    private HighlightInfo highlightTarget = (HighlightInfo) null;
    private Rectangle highlightRegion = Rectangle.Empty;
    private Storyboard myStoryboard = (Storyboard) null;
    private IntPtr handle = IntPtr.Zero;
    protected static readonly object trackingLock;
    private DispatcherTimer timer;
    private Engine engine;
    private ColorAnimation myColorAnimation;
    internal TrackingWindow GlowWindow;
    internal Slider slider1;
    internal ThicknessAnimation ThicknessAnimation;
    private bool _contentLoaded;

    public Engine Engine
    {
      get
      {
label_1:
        int num1 = 429513418;
        Engine engine;
        while (true)
        {
          int num2 = 1219466951;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 847066653 ^ -473419727;
              continue;
            case 1:
              engine = this.engine;
              num1 = (int) num3 * -447145492 ^ 2052879355;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return engine;
      }
      set
      {
label_1:
        int num1 = -1130163788;
        while (true)
        {
          int num2 = -721550087;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.engine = value;
              num1 = (int) num3 * -1064992657 ^ 1739308637;
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

    public DispatcherTimer Timer
    {
      get
      {
        DispatcherTimer timer = this.timer;
label_1:
        int num1 = 1596259349;
        while (true)
        {
          int num2 = 1049226884;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1577579960 ^ -1179642683;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return timer;
      }
      set
      {
label_1:
        int num1 = -1049933961;
        while (true)
        {
          int num2 = -1456686200;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.timer = value;
              num1 = (int) num3 * 1102848602 ^ 2094040891;
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

    public HighlightInfo HighlightTarget
    {
      get
      {
label_1:
        int num1 = 1993265874;
        HighlightInfo highlightTarget;
        while (true)
        {
          int num2 = 1410152638;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              highlightTarget = this.highlightTarget;
              num1 = (int) num3 * -311217872 ^ 179601854;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return highlightTarget;
      }
      set
      {
label_1:
        int num1 = -1881066924;
        while (true)
        {
          int num2 = -870790063;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              flag = this.highlightTarget != null;
              num1 = (int) num3 * -1732076422 ^ 376665299;
              continue;
            case 1:
              num1 = (int) num3 * -220982594 ^ -853466556;
              continue;
            case 2:
              int num4 = !flag ? -352851816 : (num4 = -803521313);
              int num5 = (int) num3 * 2051538825;
              num1 = num4 ^ num5;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * 114006782 ^ 1850242879;
              continue;
            case 5:
              this.highlightTarget = value;
              num1 = (int) num3 * 1589816511 ^ -1700837838;
              continue;
            case 6:
              System.Drawing.Color color = this.HighlightTarget.Color;
              int a = (int) color.A;
              color = this.HighlightTarget.Color;
              int r = (int) color.R;
              color = this.HighlightTarget.Color;
              int g = (int) color.G;
              color = this.HighlightTarget.Color;
              int b = (int) color.B;
              this.Foreground = (System.Windows.Media.Brush) new SolidColorBrush(System.Windows.Media.Color.FromArgb((byte) a, (byte) r, (byte) g, (byte) b));
              num1 = (int) num3 * -718068382 ^ 1886064492;
              continue;
            case 7:
              goto label_1;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public Rectangle HighlightRegion
    {
      get
      {
        Rectangle highlightRegion = this.highlightRegion;
label_1:
        int num1 = -1784750747;
        while (true)
        {
          int num2 = -157671787;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -884631545 ^ 64754946;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return highlightRegion;
      }
      set
      {
        this.highlightRegion = value;
      }
    }

    public Storyboard MyStoryboard
    {
      get
      {
        Storyboard storyboard = this.myStoryboard;
label_1:
        int num1 = 151492473;
        while (true)
        {
          int num2 = 1163145033;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1521423665 ^ 2115463507;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return storyboard;
      }
      set
      {
        this.myStoryboard = value;
      }
    }

    public CancellationToken Token { get; internal set; }

    public IntPtr Handle
    {
      get
      {
        return this.handle;
      }
      set
      {
label_1:
        int num1 = 514049172;
        while (true)
        {
          int num2 = 250662153;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.handle = value;
              num1 = (int) num3 * -1864004430 ^ -6434156;
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

    static TrackingWindow()
    {
label_1:
      int num1 = -481458430;
      while (true)
      {
        int num2 = -454503675;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            TrackingWindow.trackingLock = TrackingWindow.\u202A‬⁬‪‬‬⁫‎⁮⁫‎‌⁭​‪⁯⁯‏‭‫‪⁬‬​‏⁭⁭‪‏‍⁬‮⁪‮‬‬‎⁬⁭‎‮();
            num1 = (int) num3 * -1187068653 ^ -1045946777;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public TrackingWindow()
    {
      this.InitializeComponent();
      this.Engine = Engine.Instance;
      this.Timer = TrackingWindow.\u206A‪⁭⁭⁫‭‫‪⁬⁫‪‏‫‎⁬‌‭‪‍⁮‌⁫⁭⁪⁮⁬⁮‪​‬​‮⁮‍⁫‍⁮‭‎‭‮(DispatcherPriority.Normal, TrackingWindow.\u200D‎‭‌‫‫⁯‏‎⁬‍‮‎‍‎⁭‏‮‫‪‍‪⁮‬‬‬⁯⁮‎‎⁮⁯‭‪⁯​⁭‫‫⁭‮((DispatcherObject) this));
      TrackingWindow.\u206C⁬‬‬‮‫‮⁫‬‍⁪‫⁮⁯⁯‍‍⁪⁯‬‬‮‮‭⁮⁪‬⁪‍⁮‬‮⁯‭‭​⁮⁯⁮‌‮(this.Timer, TimeSpan.FromMilliseconds(100.0));
      TrackingWindow.\u200E‬‍⁯‏‌‮‎‍⁬⁯‫‎⁬‏⁭‎⁭‭⁮‫‬⁯‏⁯⁫‪⁮⁪‮‭‪‫‮⁪‭‪⁬‎‌‮(this.Timer, new EventHandler(this.Timer_Tick));
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      CancellationToken token = this.Token;
label_1:
      int num1 = 63194792;
      while (true)
      {
        int num2 = 1124165409;
        uint num3;
        Rectangle rectangle;
        bool flag1;
        bool flag2;
        bool flag3;
        Rectangle currentTarget;
        bool flag4;
        bool cancellationRequested;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 52U)
        {
          case 0:
            this.HighlightTarget = this.Engine.HighlightTarget;
            num1 = (int) num3 * -1362402879 ^ -1114593701;
            continue;
          case 1:
            rectangle = new Rectangle(new System.Drawing.Point(currentTarget.X - 5, currentTarget.Y - 5), new System.Drawing.Size(currentTarget.Width + 10, currentTarget.Height + 10));
            TrackingWindow.log.DebugFormat(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3288928595U), (object) this.HighlightTarget);
            int num7 = this.Top == (double) rectangle.Y ? -2073769025 : (num7 = -1280607570);
            int num8 = (int) num3 * 1887831541;
            num1 = num7 ^ num8;
            continue;
          case 2:
            if (this.Engine.HighlightTarget != null)
            {
              num1 = 897153897;
              continue;
            }
            num4 = 0;
            goto label_59;
          case 3:
            TrackingWindow.log.DebugFormat(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3197624816U), (object) this.HighlightTarget);
            this.Hide();
            this.HighlightTarget = (HighlightInfo) null;
            num1 = (int) num3 * -1341333824 ^ -1807661835;
            continue;
          case 4:
            num1 = (int) num3 * 1523658385 ^ -160496850;
            continue;
          case 5:
            currentTarget = this.HighlightTarget.CurrentTarget;
            if (this.WindowState != WindowState.Normal)
            {
              num5 = 1;
              goto label_30;
            }
            else
            {
              num1 = 730168162;
              continue;
            }
          case 6:
            this.ChangeAnimationColor();
            num1 = (int) num3 * 1323154458 ^ 1441625803;
            continue;
          case 7:
            flag3 = this.Visibility == Visibility.Visible;
            num1 = (int) num3 * 207713610 ^ 1208678095;
            continue;
          case 8:
            num1 = (int) num3 * -2105287538 ^ -374497097;
            continue;
          case 9:
            num1 = (int) num3 * -133144189 ^ -1460234482;
            continue;
          case 10:
            num1 = (int) num3 * 1424540076 ^ -307616441;
            continue;
          case 11:
            int num9 = (uint) this.Visibility > 0U ? -713734577 : (num9 = -431648987);
            int num10 = (int) num3 * -770269913;
            num1 = num9 ^ num10;
            continue;
          case 12:
            int num11 = !flag3 ? -1848346606 : (num11 = -1248602528);
            int num12 = (int) num3 * 1120257029;
            num1 = num11 ^ num12;
            continue;
          case 13:
            this.Close();
            num1 = (int) num3 * 598680807 ^ 1357866888;
            continue;
          case 14:
            num1 = (int) num3 * 900868091 ^ -993742715;
            continue;
          case 15:
            int num13 = flag1 ? 2138681672 : (num13 = 1306303445);
            int num14 = (int) num3 * 360886439;
            num1 = num13 ^ num14;
            continue;
          case 16:
            num1 = (int) num3 * 1159494508 ^ 1416927270;
            continue;
          case 17:
            num1 = (int) num3 * -1324215418 ^ 1719644596;
            continue;
          case 18:
            num1 = (int) num3 * -164183025 ^ -788884331;
            continue;
          case 19:
            flag1 = this.Left != (double) rectangle.X;
            num1 = 1529586250;
            continue;
          case 20:
            num6 = this.HighlightTarget.Expires < DateTime.Now ? 1 : 0;
            break;
          case 21:
            this.Timer.Stop();
            num1 = (int) num3 * 795527577 ^ -2123743255;
            continue;
          case 22:
            this.Top = (double) rectangle.Y;
            num1 = (int) num3 * -657482550 ^ -204077;
            continue;
          case 23:
            num1 = (int) num3 * -1045327232 ^ 1698230457;
            continue;
          case 24:
            this.HighlightTarget.LastTracking = rectangle;
            num1 = (int) num3 * 1239704239 ^ -202563570;
            continue;
          case 25:
            int num15 = !flag2 ? 1495374794 : (num15 = 344651983);
            int num16 = (int) num3 * 1629922415;
            num1 = num15 ^ num16;
            continue;
          case 26:
            this.Width = (double) rectangle.Width;
            num1 = (int) num3 * -463832886 ^ 809924257;
            continue;
          case 27:
            num1 = (int) num3 * 1391848844 ^ 797962277;
            continue;
          case 28:
            this.HighlightTarget.LastTarget = currentTarget;
            num1 = 1265969675;
            continue;
          case 29:
            num1 = (int) num3 * 1019959603 ^ -723018997;
            continue;
          case 30:
            num1 = 1045425562;
            continue;
          case 31:
            goto label_1;
          case 32:
            num1 = (int) num3 * -245952881 ^ 1318277370;
            continue;
          case 33:
            this.Hide();
            num1 = (int) num3 * 787600911 ^ -25298350;
            continue;
          case 34:
            int num17;
            num1 = num17 = this.HighlightTarget == null ? 975894879 : (num17 = 271143812);
            continue;
          case 35:
            if (this.HighlightTarget != null)
            {
              num1 = 1279561673;
              continue;
            }
            num6 = 0;
            break;
          case 36:
            this.Left = (double) rectangle.X;
            num1 = (int) num3 * 1644393699 ^ -1051366932;
            continue;
          case 37:
            num1 = (int) num3 * 864286057 ^ 472554693;
            continue;
          case 38:
            num1 = (int) num3 * -1497542180 ^ 1450804897;
            continue;
          case 39:
            num5 = this.HighlightTarget.LastTarget != currentTarget ? 1 : 0;
            goto label_30;
          case 40:
            num1 = 1761778491;
            continue;
          case 41:
            this.Height = (double) rectangle.Height;
            num1 = (int) num3 * -1939705027 ^ -1996042843;
            continue;
          case 42:
            int num18 = cancellationRequested ? 1052584098 : (num18 = 1630155197);
            int num19 = (int) num3 * 356559793;
            num1 = num18 ^ num19;
            continue;
          case 43:
            num1 = 2084649235;
            continue;
          case 44:
            int num20 = !flag4 ? 1065408589 : (num20 = 208397908);
            int num21 = (int) num3 * -606865569;
            num1 = num20 ^ num21;
            continue;
          case 45:
            int num22;
            num1 = num22 = this.Width == (double) rectangle.Width ? 1836570582 : (num22 = 65172915);
            continue;
          case 46:
            goto label_3;
          case 47:
            flag2 = this.Height != (double) rectangle.Height;
            num1 = 807700288;
            continue;
          case 48:
            num4 = this.Engine.HighlightTarget != this.HighlightTarget ? 1 : 0;
            goto label_59;
          case 49:
            // ISSUE: explicit reference operation
            cancellationRequested = ((CancellationToken) @token).get_IsCancellationRequested();
            num1 = (int) num3 * 983312055 ^ 880784820;
            continue;
          case 50:
            num1 = (int) num3 * 1430826505 ^ 746232108;
            continue;
          case 51:
            this.Show();
            num1 = (int) num3 * 404569269 ^ -664408389;
            continue;
          default:
            goto label_63;
        }
        int num23;
        num1 = num23 = num6 == 0 ? 1959105711 : (num23 = 320791049);
        continue;
label_30:
        flag4 = num5 != 0;
        num1 = 1384417325;
        continue;
label_59:
        int num24;
        num1 = num24 = num4 == 0 ? 1498464090 : (num24 = 2043370750);
      }
label_63:
      return;
label_3:;
    }

    public void ChangeAnimationColor()
    {
      bool flag1 = !TrackingWindow.\u200F‭‌⁮‌‏⁪​‬‏⁮‏⁫‍‬‭‫‏‭‎‌‫⁭‭‮‫⁪⁬⁬‪⁯⁬‍⁫‏‬⁯⁬⁪‬‮(TrackingWindow.\u200D‎‭‌‫‫⁯‏‎⁬‍‮‎‍‎⁭‏‮‫‪‍‪⁮‬‬‬⁯⁮‎‎⁮⁯‭‪⁯​⁭‫‫⁭‮((DispatcherObject) this));
label_1:
      int num1 = 474040037;
      while (true)
      {
        int num2 = 763728341;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * -34270811 ^ -1884633215;
            continue;
          case 1:
            TrackingWindow.\u202D​‌⁬‬⁫⁫⁭‬⁮⁯⁪⁯‫‮⁮‏‬⁭‬​‫⁫⁫⁯‎⁮‫‏⁮⁫⁫⁬‎⁬⁪​​‫‮(TrackingWindow.\u200D‎‭‌‫‫⁯‏‎⁬‍‮‎‍‎⁭‏‮‫‪‍‪⁮‬‬‬⁯⁮‎‎⁮⁯‭‪⁯​⁭‫‫⁭‮((DispatcherObject) this), (Delegate) new TrackingWindow.ChangeAnimationColorCallback(this.ChangeAnimationColor), new object[0]);
            num1 = (int) num3 * 392076001 ^ -1164335560;
            continue;
          case 2:
            flag2 = this.HighlightTarget != null;
            num1 = 1499708217;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -594896412 ^ 1918809798;
            continue;
          case 5:
            goto label_1;
          case 6:
            int num4 = !flag2 ? -584652617 : (num4 = -747022096);
            int num5 = (int) num3 * -1739166827;
            num1 = num4 ^ num5;
            continue;
          case 7:
            int num6 = !flag1 ? -748921244 : (num6 = -308155806);
            int num7 = (int) num3 * -1561311111;
            num1 = num6 ^ num7;
            continue;
          case 8:
            num1 = (int) num3 * -1454308116 ^ 360705127;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private void MyColorAnimation_Completed(object sender, EventArgs e)
    {
    }

    private void GlowWindow_Loaded(object sender, RoutedEventArgs e)
    {
label_1:
      int num1 = 1438184076;
      while (true)
      {
        int num2 = 488618403;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            TrackingWindow.\u202E‫⁯‮⁮⁪‫​‏⁭‭⁭‪‌⁭‎⁯‫‬‬⁮​⁯‪⁭‮​⁯‏​​⁬‍‎‭‏‍​⁮‪‮(this.Timer);
            num1 = (int) num3 * 1236520612 ^ 108927467;
            continue;
          case 1:
            num1 = (int) num3 * -1127528675 ^ 917747408;
            continue;
          case 2:
            num1 = (int) num3 * -95168877 ^ -1065593582;
            continue;
          case 3:
            this.Handle = TrackingWindow.\u202C‍⁭⁭⁮​⁯⁯⁫‍‌⁬‍‏‫‪⁮⁯⁪‭⁫‍⁪‏⁬⁮​⁯‎⁯‎‏⁫⁯‌⁭‌‪‫‍‮(TrackingWindow.\u200D‎⁬‏‭‮‌⁮⁭‬‫‏⁯⁬⁬‪​⁪⁭⁯‭‫​⁬‎‭‍‌⁯​⁬‎‪​⁪⁮⁯‌⁭‎‮((Window) this));
            num1 = 1897484163;
            continue;
          case 4:
            int num4 = this.Timer == null ? -1879900874 : (num4 = -1166666310);
            int num5 = (int) num3 * 296804942;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_3;
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

    internal void SetTrackingTarget(ZoomWindow window)
    {
      bool flag1 = !TrackingWindow.\u200F‭‌⁮‌‏⁪​‬‏⁮‏⁫‍‬‭‫‏‭‎‌‫⁭‭‮‫⁪⁬⁬‪⁯⁬‍⁫‏‬⁯⁬⁪‬‮(TrackingWindow.\u200D‎‭‌‫‫⁯‏‎⁬‍‮‎‍‎⁭‏‮‫‪‍‪⁮‬‬‬⁯⁮‎‎⁮⁯‭‪⁯​⁭‫‫⁭‮((DispatcherObject) this));
label_1:
      int num1 = 982691530;
      object trackingLock1;
      while (true)
      {
        int num2 = 1698370631;
        uint num3;
        bool isExpired;
        bool flag2;
        bool flag3;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 20U)
        {
          case 1:
            int num4 = flag1 ? -85451315 : (num4 = -1510272300);
            int num5 = (int) num3 * -1798747901;
            num1 = num4 ^ num5;
            continue;
          case 2:
            this.HighlightTarget.UpdateLocation = true;
            num1 = (int) num3 * -1040636647 ^ 718705408;
            continue;
          case 3:
            trackingLock1 = TrackingWindow.trackingLock;
            num1 = (int) num3 * -792576744 ^ -1863884161;
            continue;
          case 4:
            num1 = (int) num3 * -2134137647 ^ 408304680;
            continue;
          case 5:
            if (flag4)
            {
              num1 = (int) num3 * -675776937 ^ 981213718;
              continue;
            }
            goto label_57;
          case 6:
            num1 = (int) num3 * -1201850155 ^ -607880052;
            continue;
          case 7:
            int num6 = flag2 ? 1831951810 : (num6 = 1544484949);
            int num7 = (int) num3 * -1980100977;
            num1 = num6 ^ num7;
            continue;
          case 8:
            num1 = (int) num3 * -1179043053 ^ 1068166961;
            continue;
          case 9:
            num1 = (int) num3 * -1439792735 ^ 353282902;
            continue;
          case 10:
            if (isExpired)
            {
              num1 = (int) num3 * -1423037886 ^ -1979385597;
              continue;
            }
            goto label_38;
          case 11:
            flag3 = this.HighlightTarget.ZoomWindow == window;
            num1 = (int) num3 * -1218750468 ^ 1410715616;
            continue;
          case 12:
            goto label_10;
          case 13:
            goto label_65;
          case 14:
            num1 = (int) num3 * -1058210014 ^ 819357896;
            continue;
          case 15:
            isExpired = this.HighlightTarget.IsExpired;
            num1 = 1256654997;
            continue;
          case 16:
            flag4 = this.HighlightTarget != null;
            num1 = 233721490;
            continue;
          case 17:
            flag2 = this.HighlightTarget.Rectangle != window.Rectangle;
            num1 = (int) num3 * 128302469 ^ 1197408181;
            continue;
          case 18:
            goto label_1;
          case 19:
            if (flag3)
            {
              num1 = (int) num3 * 995319693 ^ 1990479126;
              continue;
            }
            goto label_40;
          default:
            goto label_23;
        }
      }
label_65:
      return;
label_10:
      TrackingWindow.\u202D​‌⁬‬⁫⁫⁭‬⁮⁯⁪⁯‫‮⁮‏‬⁭‬​‫⁫⁫⁯‎⁮‫‏⁮⁫⁫⁬‎⁬⁪​​‫‮(TrackingWindow.\u200D‎‭‌‫‫⁯‏‎⁬‍‮‎‍‎⁭‏‮‫‪‍‪⁮‬‬‬⁯⁮‎‎⁮⁯‭‪⁯​⁭‫‫⁭‮((DispatcherObject) this), (Delegate) new TrackingWindow.SetTrackingTargetCallback(this.SetTrackingTarget), new object[1]
      {
        (object) window
      });
      return;
label_23:
      bool flag5 = false;
      try
      {
        TrackingWindow.\u200E‪⁯‫‌​‮‍⁮⁪​‭‮⁬‫‌‫⁬‎​⁪​⁯⁫‌‫⁫‏‬⁫‬‭⁫⁭‏‪‏‏⁫‎‮(trackingLock1, ref flag5);
label_25:
        int num2 = 273989654;
        while (true)
        {
          int num3 = 1698370631;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_25;
            case 1:
              num2 = (int) num4 * -1702926012 ^ 1659408676;
              continue;
            case 2:
              goto label_53;
            case 3:
              this.HighlightTarget = (HighlightInfo) null;
              num2 = (int) num4 * 56953805 ^ -1220070650;
              continue;
            default:
              goto label_47;
          }
        }
label_47:
        return;
label_53:
        return;
      }
      finally
      {
        if (flag5)
        {
label_30:
          int num2 = 299049596;
          while (true)
          {
            int num3 = 1698370631;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * -2128679475 ^ -1200645622;
                continue;
              case 2:
                goto label_30;
              case 3:
                TrackingWindow.\u200F‬⁮‫‏⁭‫​⁯‏‮⁫‌‫‏⁪⁫‍‪‏​‬⁪‭‏‏​‬‍‭‭‪‍‎‍‫‍‭⁪⁪‮(trackingLock1);
                num2 = (int) num4 * 1902730578 ^ 59036069;
                continue;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
label_36:
      object trackingLock2;
      int num8;
      while (true)
      {
        int num2 = 1698370631;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 5U)
        {
          case 0:
            num8 = 2085118488;
            continue;
          case 1:
            trackingLock2 = TrackingWindow.trackingLock;
            num8 = (int) num3 * 629076220 ^ 1631937301;
            continue;
          case 3:
            goto label_38;
          case 4:
            goto label_40;
          default:
            goto label_42;
        }
      }
label_42:
      bool flag6 = false;
      try
      {
        TrackingWindow.\u200E‪⁯‫‌​‮‍⁮⁪​‭‮⁬‫‌‫⁬‎​⁪​⁯⁫‌‫⁫‏‬⁫‬‭⁫⁭‏‪‏‏⁫‎‮(trackingLock2, ref flag6);
        this.HighlightTarget = (HighlightInfo) null;
        goto label_50;
      }
      finally
      {
        if (flag6)
        {
label_45:
          int num2 = 881296283;
          while (true)
          {
            int num3 = 1698370631;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                TrackingWindow.\u200F‬⁮‫‏⁭‫​⁯‏‮⁫‌‫‏⁪⁫‍‪‏​‬⁪‭‏‏​‬‍‭‭‪‍‎‍‫‍‭⁪⁪‮(trackingLock2);
                num2 = (int) num4 * -1187902845 ^ -517750388;
                continue;
              case 2:
                goto label_45;
              default:
                goto label_49;
            }
          }
        }
label_49:;
      }
label_38:
      num8 = 711752218;
      goto label_36;
label_40:
      if (this.HighlightTarget.IsExpired)
      {
        num8 = 1218956612;
        goto label_36;
      }
label_50:
label_51:
      int num9 = 1983560758;
label_52:
      bool flag7;
      while (true)
      {
        int num2 = 1698370631;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 7U)
        {
          case 0:
            goto label_51;
          case 1:
            goto label_57;
          case 3:
            if (flag7)
            {
              num9 = (int) num3 * 835305315 ^ 145847220;
              continue;
            }
            goto label_75;
          case 4:
            num9 = (int) num3 * 780797974 ^ 992075182;
            continue;
          case 5:
            num9 = (int) num3 * 2139339581 ^ 2121323887;
            continue;
          case 6:
            if (this.CanSetHighlightTarget(window))
            {
              num9 = (int) num3 * -818365095 ^ -989700986;
              continue;
            }
            goto label_82;
          default:
            goto label_61;
        }
      }
label_75:
      return;
label_61:
      object trackingLock3 = TrackingWindow.trackingLock;
      bool flag8 = false;
      try
      {
        TrackingWindow.\u200E‪⁯‫‌​‮‍⁮⁪​‭‮⁬‫‌‫⁬‎​⁪​⁯⁫‌‫⁫‏‬⁫‬‭⁫⁭‏‪‏‏⁫‎‮(trackingLock3, ref flag8);
label_63:
        int num2 = 2135061207;
        while (true)
        {
          int num3 = 1698370631;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              goto label_63;
            case 1:
              num2 = (int) num4 * 980996535 ^ -2055099304;
              continue;
            case 2:
              num2 = (int) num4 * 2039084828 ^ -658544019;
              continue;
            case 3:
              this.HighlightTarget = new HighlightInfo(window, (object) this);
              num2 = (int) num4 * -1111454353 ^ -1578929728;
              continue;
            case 4:
              num2 = (int) num4 * -942086263 ^ 296170927;
              continue;
            case 5:
              num2 = (int) num4 * 1315710220 ^ -526083267;
              continue;
            default:
              goto label_79;
          }
        }
      }
      finally
      {
        if (flag8)
        {
label_73:
          int num2 = 1069101216;
          while (true)
          {
            int num3 = 1698370631;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_73;
              case 1:
                num2 = (int) num4 * -407759207 ^ 1770693956;
                continue;
              case 3:
                TrackingWindow.\u200F‬⁮‫‏⁭‫​⁯‏‮⁫‌‫‏⁪⁫‍‪‏​‬⁪‭‏‏​‬‍‭‭‪‍‎‍‫‍‭⁪⁪‮(trackingLock3);
                num2 = (int) num4 * 1592789633 ^ 1330811573;
                continue;
              default:
                goto label_78;
            }
          }
        }
label_78:;
      }
label_79:
label_80:
      int num10 = 568443284;
label_81:
      int num11 = 1698370631;
      uint num12;
      switch ((num12 = (uint) (num10 ^ num11)) % 3U)
      {
        case 0:
          goto label_80;
        case 1:
          return;
        case 2:
          break;
        default:
          return;
      }
label_82:
      num10 = 2109722520;
      goto label_81;
label_57:
      flag7 = window != null;
      num9 = 1614968289;
      goto label_52;
    }

    private bool CanSetHighlightTarget(ZoomWindow window)
    {
label_1:
      int num1 = -1882408515;
      bool flag1;
      while (true)
      {
        int num2 = -75161797;
        uint num3;
        ZoomWindowType zoomWindowType;
        bool flag2;
        bool flag3;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num1 = (int) num3 * -1319442714 ^ 2004275051;
            continue;
          case 1:
          case 8:
label_5:
            flag1 = false;
            num1 = -2118050646;
            continue;
          case 2:
            num1 = (int) num3 * 1162315648 ^ 1876679804;
            continue;
          case 3:
            num1 = (int) num3 * 547070293 ^ 2141722748;
            continue;
          case 4:
            int num4 = flag2 ? -1491772074 : (num4 = -1222649519);
            int num5 = (int) num3 * -1175281288;
            num1 = num4 ^ num5;
            continue;
          case 5:
            flag1 = false;
            num1 = -1533065092;
            continue;
          case 6:
            goto label_1;
          case 7:
            flag1 = false;
            num1 = (int) num3 * 47759110 ^ -1314794025;
            continue;
          case 9:
            flag1 = true;
            num1 = (int) num3 * -222754642 ^ 178522716;
            continue;
          case 10:
label_19:
            flag3 = this.HighlightTarget == null;
            num1 = -469049821;
            continue;
          case 11:
            switch (zoomWindowType)
            {
              case ZoomWindowType.Undefined:
              case ZoomWindowType.ZoomZoomMain:
              case ZoomWindowType.Container:
              case ZoomWindowType.Other:
              case ZoomWindowType.ManyCamBroadcast:
              case ZoomWindowType.AudioNotification:
              case ZoomWindowType.MeetingButtonBar:
              case ZoomWindowType.GalleryScrollRight:
              case ZoomWindowType.GalleryScrollLeft:
              case ZoomWindowType.ToolTip:
              case ZoomWindowType.GalleryView:
              case ZoomWindowType.SpeakerViewScrollLeft:
              case ZoomWindowType.SpeakerViewScrollRight:
              case ZoomWindowType.SpeakerView:
              case ZoomWindowType.MeetingViewToggle:
              case ZoomWindowType.ManyCamApp:
              case ZoomWindowType.ImageHistoryView:
                goto label_5;
              case ZoomWindowType.AccountPanel:
              case ZoomWindowType.Join:
              case ZoomWindowType.Notification:
              case ZoomWindowType.DualVideo:
              case ZoomWindowType.Video:
              case ZoomWindowType.InvalidMeeting:
              case ZoomWindowType.JoinAudio:
              case ZoomWindowType.Settings:
              case ZoomWindowType.Invite:
              case ZoomWindowType.ScreenSharingDisabled:
              case ZoomWindowType.WaitingForHost:
              case ZoomWindowType.LeaveCurrent:
              case ZoomWindowType.RequestRecord:
              case ZoomWindowType.AudioError:
              case ZoomWindowType.AudioMenu:
              case ZoomWindowType.Sharing:
              case ZoomWindowType.Locked:
              case ZoomWindowType.Full:
              case ZoomWindowType.EndMeeting:
              case ZoomWindowType.ScreenShareOptions:
              case ZoomWindowType.RequestRemoteControl:
              case ZoomWindowType.Password:
              case ZoomWindowType.Rename:
              case ZoomWindowType.ZoomMenu:
              case ZoomWindowType.RemoveUserConfirmation:
                goto label_12;
              case ZoomWindowType.Meeting:
              case ZoomWindowType.Chat:
              case ZoomWindowType.Participants:
                goto label_19;
              default:
                num1 = (int) num3 * -864315417 ^ 1303378523;
                continue;
            }
          case 12:
            flag2 = !window.IsVisible;
            num1 = (int) num3 * 425908949 ^ -1483339685;
            continue;
          case 13:
            num1 = (int) num3 * 1974265956 ^ 1111263680;
            continue;
          case 14:
            int num6 = flag3 ? 2059191827 : (num6 = 163866031);
            int num7 = (int) num3 * 946348129;
            num1 = num6 ^ num7;
            continue;
          case 16:
            zoomWindowType = window.ZoomWindowType;
            num1 = -2008443189;
            continue;
          case 17:
            num1 = (int) num3 * -694230941 ^ -1871378065;
            continue;
          case 18:
label_12:
            flag1 = true;
            num1 = -1533065092;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return flag1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      bool contentLoaded = this._contentLoaded;
label_1:
      int num1 = 145027738;
      while (true)
      {
        int num2 = 1535388312;
        uint num3;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -897190588 ^ 1482569357;
            continue;
          case 1:
            TrackingWindow.\u202C⁯‏⁫‮‭‪‏‫‎‎‍‬‌⁮‬‮⁮⁫⁫‬‎⁯‍⁫‪⁫⁬‌‫⁫​‎‍‪‮‪⁯⁬⁬‮((object) this, uri);
            num1 = (int) num3 * -300458798 ^ 1137859834;
            continue;
          case 2:
            int num4 = !contentLoaded ? -2015952665 : (num4 = -1084105684);
            int num5 = (int) num3 * -1389767540;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -551856519 ^ -1325235142;
            continue;
          case 5:
            goto label_3;
          case 6:
            num1 = (int) num3 * -646940781 ^ 402823015;
            continue;
          case 7:
            this._contentLoaded = true;
            uri = TrackingWindow.\u206E‎‫‎‏​⁮‏‮​‌⁯‬⁮‪⁮⁯⁪⁪⁬⁬‍⁫‏⁭‮⁪‮‮‎‬‭‭‪‮‭⁮‪‭‭‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1268109030U), UriKind.Relative);
            num1 = 83786153;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
label_1:
      int num1 = 746258646;
      while (true)
      {
        int num2 = 520228941;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            this._contentLoaded = true;
            num1 = 1663775391;
            continue;
          case 2:
            TrackingWindow.\u206D‬‏⁯‍⁯⁬​‪‍‮⁬‬⁪⁮⁭‫‎‍‭‎‏⁪⁮‎‬‭‭‫‎‬⁪‪‮⁪‫‏‭‭‍‮((FrameworkElement) this.GlowWindow, new RoutedEventHandler(this.GlowWindow_Loaded));
            num1 = (int) num3 * -714485913 ^ 1124893483;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = (int) num3 * -1250432914 ^ 545625631;
            continue;
          case 5:
            num1 = (int) num3 * -1579766311 ^ -1873855209;
            continue;
          case 6:
label_13:
            this.slider1 = (Slider) target;
            num1 = 1663775391;
            continue;
          case 7:
            switch (connectionId)
            {
              case 1:
                goto label_10;
              case 2:
                goto label_13;
              case 3:
                goto label_9;
              default:
                num1 = (int) num3 * 819629246 ^ -912244584;
                continue;
            }
          case 8:
label_10:
            this.GlowWindow = (TrackingWindow) target;
            num1 = 1588506223;
            continue;
          case 9:
label_9:
            this.ThicknessAnimation = (ThicknessAnimation) target;
            num1 = 727486349;
            continue;
          case 10:
            num1 = (int) num3 * 1000040019 ^ -1904812692;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    static Dispatcher \u200D‎‭‌‫‫⁯‏‎⁬‍‮‎‍‎⁭‏‮‫‪‍‪⁮‬‬‬⁯⁮‎‎⁮⁯‭‪⁯​⁭‫‫⁭‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static DispatcherTimer \u206A‪⁭⁭⁫‭‫‪⁬⁫‪‏‫‎⁬‌‭‪‍⁮‌⁫⁭⁪⁮⁬⁮‪​‬​‮⁮‍⁫‍⁮‭‎‭‮([In] DispatcherPriority obj0, [In] Dispatcher obj1)
    {
      return new DispatcherTimer(obj0, obj1);
    }

    static void \u206C⁬‬‬‮‫‮⁫‬‍⁪‫⁮⁯⁯‍‍⁪⁯‬‬‮‮‭⁮⁪‬⁪‍⁮‬‮⁯‭‭​⁮⁯⁮‌‮([In] DispatcherTimer obj0, [In] TimeSpan obj1)
    {
      obj0.Interval = obj1;
    }

    static void \u200E‬‍⁯‏‌‮‎‍⁬⁯‫‎⁬‏⁭‎⁭‭⁮‫‬⁯‏⁯⁫‪⁮⁪‮‭‪‫‮⁪‭‪⁬‎‌‮([In] DispatcherTimer obj0, [In] EventHandler obj1)
    {
      obj0.Tick += obj1;
    }

    static bool \u200F‭‌⁮‌‏⁪​‬‏⁮‏⁫‍‬‭‫‏‭‎‌‫⁭‭‮‫⁪⁬⁬‪⁯⁬‍⁫‏‬⁯⁬⁪‬‮([In] Dispatcher obj0)
    {
      return obj0.CheckAccess();
    }

    static object \u202D​‌⁬‬⁫⁫⁭‬⁮⁯⁪⁯‫‮⁮‏‬⁭‬​‫⁫⁫⁯‎⁮‫‏⁮⁫⁫⁬‎⁬⁪​​‫‮([In] Dispatcher obj0, [In] Delegate obj1, [In] object[] obj2)
    {
      return obj0.Invoke(obj1, obj2);
    }

    static void \u202E‫⁯‮⁮⁪‫​‏⁭‭⁭‪‌⁭‎⁯‫‬‬⁮​⁯‪⁭‮​⁯‏​​⁬‍‎‭‏‍​⁮‪‮([In] DispatcherTimer obj0)
    {
      obj0.Start();
    }

    static WindowInteropHelper \u200D‎⁬‏‭‮‌⁮⁭‬‫‏⁯⁬⁬‪​⁪⁭⁯‭‫​⁬‎‭‍‌⁯​⁬‎‪​⁪⁮⁯‌⁭‎‮([In] Window obj0)
    {
      return new WindowInteropHelper(obj0);
    }

    static IntPtr \u202C‍⁭⁭⁮​⁯⁯⁫‍‌⁬‍‏‫‪⁮⁯⁪‭⁫‍⁪‏⁬⁮​⁯‎⁯‎‏⁫⁯‌⁭‌‪‫‍‮([In] WindowInteropHelper obj0)
    {
      return obj0.Handle;
    }

    static void \u200E‪⁯‫‌​‮‍⁮⁪​‭‮⁬‫‌‫⁬‎​⁪​⁯⁫‌‫⁫‏‬⁫‬‭⁫⁭‏‪‏‏⁫‎‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200F‬⁮‫‏⁭‫​⁯‏‮⁫‌‫‏⁪⁫‍‪‏​‬⁪‭‏‏​‬‍‭‭‪‍‎‍‫‍‭⁪⁪‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static Uri \u206E‎‫‎‏​⁮‏‮​‌⁯‬⁮‪⁮⁯⁪⁪⁬⁬‍⁫‏⁭‮⁪‮‮‎‬‭‭‪‮‭⁮‪‭‭‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u202C⁯‏⁫‮‭‪‏‫‎‎‍‬‌⁮‬‮⁮⁫⁫‬‎⁯‍⁫‪⁫⁬‌‫⁫​‎‍‪‮‪⁯⁬⁬‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206D‬‏⁯‍⁯⁬​‪‍‮⁬‬⁪⁮⁭‫‎‍‭‎‏⁪⁮‎‬‭‭‫‎‬⁪‪‮⁪‫‏‭‭‍‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static MethodBase \u202C⁪‬⁭⁯‌⁬⁭‮⁬⁫⁭‏‎‪⁪‮‫⁬‍⁭⁪‪‏⁯​‬​⁮‍⁯‍⁭⁪⁯⁫⁯‫​‍‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206D⁯‮⁪⁭⁮‏‍‍‏‌‭⁪‫​‍‮⁭‭‎⁯⁭‎⁮‌⁭⁯​‎‫‍⁭‬‭⁮‫⁪⁯​‍‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u200F⁯⁮‬⁮‬‫‌​‭‌​⁯‫‪‭‬‌‮‭‏‏‎‬‪‮⁯‎‪⁬​‪⁫‪‍⁬⁭‪‌⁬‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static object \u202A‬⁬‪‬‬⁫‎⁮⁫‎‌⁭​‪⁯⁯‏‭‫‪⁬‬​‏⁭⁭‪‏‍⁬‮⁪‮‬‬‎⁬⁭‎‮()
    {
      return new object();
    }

    public delegate void ChangeAnimationColorCallback();

    private delegate void SetTrackingTargetCallback(ZoomWindow window);
  }
}
