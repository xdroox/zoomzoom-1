// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ViewModelBase
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using GalaSoft.MvvmLight;
using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using ZoomZoom.Common;

namespace ZoomZoom.ViewModels
{
  public abstract class ViewModelBase : ViewModelBase
  {
    protected static readonly ILog log = ViewModelBase.\u202A‎⁪​⁬‎⁭‮‮‫‍‫‏⁮‍⁭‪⁭‍⁪‌⁯‎‏‎⁮‪⁫‭‬⁫‭‏⁬‍‬​⁪‬‌‮(ViewModelBase.\u206D⁮‌​‌‪‏‮‫‌‌‭‎‭‏‭⁮‬‬‎‮‌‪⁪⁪‫‭‎‍‏‍⁮⁬​‮‪‬⁬⁭‏‮((MemberInfo) ViewModelBase.\u200B​‮‭⁮‌​⁭⁭‮⁯‬⁫‭⁬‌⁫​‏⁯⁪‍⁮‬‎⁯‮‌‍‪​⁪⁫‪‍⁮‫​​‮‮()));
    protected readonly IEventAggregator _eventAggregator;
    protected static readonly object modelLock;
    private Engine engine;
    private Window view;
    private UserControl userControl;
    private bool initialized;
    private CommandMap commands;
    private IntPtr viewHandle;

    public IntPtr ViewHandle
    {
      get
      {
label_1:
        int num1 = 2040875544;
        IntPtr viewHandle;
        while (true)
        {
          int num2 = 1089865930;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -48268378 ^ -954961396;
              continue;
            case 2:
              viewHandle = this.viewHandle;
              num1 = (int) num3 * -1419290902 ^ -1673642249;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return viewHandle;
      }
      set
      {
label_1:
        int num1 = 380064478;
        while (true)
        {
          int num2 = 1635038080;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.viewHandle = value;
              num1 = (int) num3 * -523234090 ^ 343996101;
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

    public Engine Engine
    {
      get
      {
        if (this.engine != null)
          goto label_4;
label_1:
        int num1 = -711538708;
label_2:
        while (true)
        {
          int num2 = -626312123;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -1552775562 ^ -1909751008;
              continue;
            case 1:
              this.engine = Engine.Instance;
              num1 = (int) num3 * -1410260030 ^ 1790407746;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_4;
            default:
              goto label_6;
          }
        }
label_6:
        Engine engine;
        return engine;
label_4:
        engine = this.engine;
        num1 = -314921044;
        goto label_2;
      }
      set
      {
label_1:
        int num1 = 306166399;
        while (true)
        {
          int num2 = 398535133;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.engine = value;
              num1 = (int) num3 * -1591019529 ^ -2135335837;
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

    public Window View
    {
      get
      {
label_1:
        int num1 = 872277352;
        Window view;
        while (true)
        {
          int num2 = 1695401035;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              view = this.view;
              num1 = (int) num3 * -1491768436 ^ 716645961;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return view;
      }
      set
      {
label_1:
        int num1 = 1550581042;
        while (true)
        {
          int num2 = 1791896053;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(276490987U));
              num1 = (int) num3 * 1548779056 ^ -1578628924;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.view = value;
              num1 = (int) num3 * 1172973193 ^ -1297751130;
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

    public UserControl UserControl
    {
      get
      {
        return this.userControl;
      }
      set
      {
label_1:
        int num1 = 1619771861;
        while (true)
        {
          int num2 = 1353425122;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(293412481U));
              num1 = (int) num3 * 432406693 ^ 750702095;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.userControl = value;
              num1 = (int) num3 * -1346595477 ^ -2100139329;
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

    public bool Initialized
    {
      get
      {
label_1:
        int num1 = -1108220452;
        bool initialized;
        while (true)
        {
          int num2 = -666113654;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              initialized = this.initialized;
              num1 = (int) num3 * 912504539 ^ -1840480153;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return initialized;
      }
      set
      {
label_1:
        int num1 = -1390614913;
        while (true)
        {
          int num2 = -1304085488;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(328915266U));
              num1 = (int) num3 * 585214043 ^ 1801540213;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.initialized = value;
              num1 = (int) num3 * -61128350 ^ 663463223;
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

    public ZoomMeeting ActiveMeeting
    {
      get
      {
        return Engine.Instance.ActiveMeeting;
      }
    }

    public ActivityBase ActiveActivity
    {
      get
      {
        ActivityBase activeActivity = Engine.Instance.ActiveActivity;
label_1:
        int num1 = -144522608;
        while (true)
        {
          int num2 = -81021733;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 313637626 ^ -901067562;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeActivity;
      }
    }

    public CommandMap Commands
    {
      get
      {
label_1:
        int num1 = -1088483438;
        CommandMap commands;
        while (true)
        {
          int num2 = -859931377;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              commands = this.commands;
              num1 = (int) num3 * -2020484481 ^ 1099362443;
              continue;
            case 3:
              num1 = (int) num3 * -1880929641 ^ -1695502196;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return commands;
      }
      private set
      {
        this.commands = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2505050249U));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_1:
        int num1 = 1736301612;
        while (true)
        {
          int num2 = 220227187;
          uint num3;
          PropertyChangedEventHandler comparand;
          PropertyChangedEventHandler changedEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              changedEventHandler2 = (PropertyChangedEventHandler) ViewModelBase.\u202E⁬‭⁯⁬‬‌‏⁯⁭‌‍​⁮⁯‮‭⁪⁪‬‭⁭​‌‌‬‎‏‭‎‪⁭⁪⁫⁫⁫‫‫​‌‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * -1016442325 ^ 11697444;
              continue;
            case 3:
              comparand = changedEventHandler1;
              num1 = 136698139;
              continue;
            case 4:
              int num4 = changedEventHandler1 == comparand ? -476212 : (num4 = -495057566);
              int num5 = (int) num3 * -1347261431;
              num1 = num4 ^ num5;
              continue;
            case 5:
              changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
              num1 = (int) num3 * -1432174910 ^ -1968715853;
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
        PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;
label_1:
        int num1 = -1328582762;
        while (true)
        {
          int num2 = -2126688553;
          uint num3;
          PropertyChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = changedEventHandler;
              num1 = -604907767;
              continue;
            case 2:
              changedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, (PropertyChangedEventHandler) ViewModelBase.\u202D‮‮‭‫‫‎‮‭‬⁬‭⁮⁫⁬​‭‭‬⁫⁯‍⁪‮​⁮‬‮‭‪‏⁭‪⁯‪‬​⁮‌⁯‮((Delegate) comparand, (Delegate) value), comparand);
              int num4 = changedEventHandler == comparand ? -1973807805 : (num4 = -1451799042);
              int num5 = (int) num3 * 1847781900;
              num1 = num4 ^ num5;
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

    static ViewModelBase()
    {
label_1:
      int num1 = 1192818851;
      while (true)
      {
        int num2 = 1892447662;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            ViewModelBase.modelLock = ViewModelBase.\u202C⁫⁯‏‍⁫‮⁯‏‮⁫‮‫‎⁯⁬‬‎‫⁮‫‭‏⁭⁪⁯‬‌‮⁯‏‏⁭‌‬⁯⁯‍⁮‌‮();
            num1 = (int) num3 * 783923444 ^ 547061170;
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

    public ViewModelBase()
    {
      base.\u002Ector();
      this._eventAggregator = ApplicationService.Instance.EventAggregator;
      this.Commands = new CommandMap();
    }

    public ViewModelBase(IEventAggregator eventAggregator)
    {
      base.\u002Ector();
label_1:
      int num1 = 1588594482;
      while (true)
      {
        int num2 = 1523056129;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            this._eventAggregator = eventAggregator;
            num1 = (int) num3 * 1321463414 ^ 766797783;
            continue;
          case 2:
            this.Commands = new CommandMap();
            num1 = (int) num3 * 1025331390 ^ 1966295875;
            continue;
          case 3:
            num1 = (int) num3 * 1543802363 ^ -768231885;
            continue;
          case 4:
            num1 = (int) num3 * 1694032602 ^ -1722100523;
            continue;
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

    public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    {
      this.RaisePropertyChanged(ViewModelBase.\u200B‎⁭‍⁭⁯‌⁯‍‭⁫‬‌‮‪⁯‮⁬‫⁫‌‍‮‏‭‎‌‏⁬‫⁯⁫‭‬‬‍‌⁮⁪‬‮(propertyName));
    }

    public void RaisePropertyChanged(System.Linq.Expressions.Expression<Func<object>> propertyNameExpression)
    {
      this.RaisePropertyChanged(ViewModelBase.\u200B‎⁭‍⁭⁯‌⁯‍‭⁫‬‌‮‪⁯‮⁬‫⁫‌‍‮‏‭‎‌‏⁬‫⁯⁫‭‬‬‍‌⁮⁪‬‮(ExpressionUtilities.GetPropertyName<object>(propertyNameExpression)));
    }

    public void RaisePropertyChanged<TClass>(System.Linq.Expressions.Expression<Func<TClass, object>> propertyNameExpression)
    {
      this.RaisePropertyChanged(ViewModelBase.\u200B‎⁭‍⁭⁯‌⁯‍‭⁫‬‌‮‪⁯‮⁬‫⁫‌‍‮‏‭‎‌‏⁬‫⁯⁫‭‬‬‍‌⁮⁪‬‮(ExpressionUtilities.GetPropertyName<TClass>(propertyNameExpression)));
    }

    protected virtual void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
label_1:
      int num1 = -1521467222;
      while (true)
      {
        int num2 = -1596281378;
        uint num3;
        PropertyChangedEventHandler propertyChanged;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            int num4 = flag ? -1784949298 : (num4 = -393005375);
            int num5 = (int) num3 * 968541605;
            num1 = num4 ^ num5;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            propertyChanged = this.PropertyChanged;
            flag = propertyChanged != null;
            num1 = (int) num3 * 938843875 ^ 608617654;
            continue;
          case 2:
            propertyChanged((object) this, args);
            num1 = (int) num3 * 1907514800 ^ -152218875;
            continue;
          case 3:
            goto label_3;
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

    public void RaiseAllPropertiesChanged()
    {
label_1:
      int num1 = -116226462;
      while (true)
      {
        int num2 = -1832908349;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.RaisePropertyChanged(ViewModelBase.\u200B‎⁭‍⁭⁯‌⁯‍‭⁫‬‌‮‪⁯‮⁬‫⁫‌‍‮‏‭‎‌‏⁬‫⁯⁫‭‬‬‍‌⁮⁪‬‮(string.Empty));
            num1 = (int) num3 * -328693237 ^ 2030733854;
            continue;
          case 2:
            num1 = (int) num3 * 755324207 ^ -2113300999;
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

    public void AddActivity(ActivityBase newActivity)
    {
      try
      {
        bool flag = this.Engine != null;
label_2:
        int num1 = 1162357170;
        while (true)
        {
          int num2 = 405318391;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = (int) num3 * -438808330 ^ 561945919;
              continue;
            case 1:
              num1 = 378625934;
              continue;
            case 2:
              num1 = (int) num3 * 2085980068 ^ 1639509263;
              continue;
            case 3:
              ViewModelBase.\u206B‭‭‏‏⁪‫⁭⁮⁫‭‍‮⁮⁫⁯‏‮⁫‌‌‌⁪⁫‪‌‌‎‪⁯‮‏‭​‪‮‎‍‭⁬‮(ViewModelBase.log, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2845659090U), (object) newActivity.Name);
              num1 = (int) num3 * 119921320 ^ 313285495;
              continue;
            case 4:
              goto label_2;
            case 5:
              this.Engine.AddActivity(newActivity, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1739840206U));
              num1 = (int) num3 * 113229709 ^ 2143204464;
              continue;
            case 6:
              num1 = (int) num3 * -472706836 ^ -79656138;
              continue;
            case 7:
              goto label_4;
            case 8:
              int num4 = flag ? 1278502607 : (num4 = 1408959375);
              int num5 = (int) num3 * 1021555936;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        return;
label_4:;
      }
      catch (Exception ex)
      {
        ViewModelBase.\u202D‏‮⁭‭‮⁯​‪⁬‫⁯‫‌⁫⁬⁭‍⁯‮⁮‭⁯⁫‎‫‫⁪⁫⁮⁬⁫⁯‎‬‏‌‌⁭⁮‮(ViewModelBase.log, (object) ex);
      }
    }

    protected virtual bool ContinueExecution()
    {
label_1:
      int num1 = 186955524;
      bool flag1;
      while (true)
      {
        int num2 = 1176331157;
        uint num3;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * -668468728 ^ -765944963;
            continue;
          case 1:
            if (this.Engine == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -300314097 ^ 1836059611;
            continue;
          case 2:
            num1 = 787382193;
            continue;
          case 3:
            goto label_1;
          case 5:
            num4 = this.Engine.EngineState == EngineState.Executing ? 1 : 0;
            break;
          case 6:
            flag1 = false;
            num1 = (int) num3 * 1298707534 ^ 845196207;
            continue;
          case 7:
            flag1 = true;
            num1 = (int) num3 * 1376581474 ^ 1488890063;
            continue;
          case 8:
            num1 = (int) num3 * -2059169821 ^ 847032345;
            continue;
          case 9:
            int num5 = !flag2 ? 1773841889 : (num5 = 970669748);
            int num6 = (int) num3 * -1348638282;
            num1 = num5 ^ num6;
            continue;
          default:
            goto label_14;
        }
        flag2 = num4 != 0;
        num1 = 889707062;
      }
label_14:
      return flag1;
    }

    public virtual void ShellCommand(string fileName, string arguments = "")
    {
      try
      {
        ViewModelBase.\u202E⁬⁬‌⁬‮⁪​⁯‌​⁯⁫⁮‍⁭⁮‏⁮⁭⁯‍‫‪⁪⁪⁮‫‫⁯‍⁯‎⁫‮⁮‏⁮‏‏‮(ViewModelBase.\u200D⁬‮⁮⁭‮‪‌‍‍‪‍​‌⁮⁮⁯‮⁬‌‎‬⁯‎‮‏⁬⁪‎‮‎⁭⁫⁮​‎‪⁪‌‎‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4062811561U), (object) fileName));
      }
      catch (Exception ex)
      {
label_3:
        int num1 = 1972575309;
        while (true)
        {
          int num2 = 756765915;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_5;
            case 2:
              ViewModelBase.\u202D‏‮⁭‭‮⁯​‪⁬‫⁯‫‌⁫⁬⁭‍⁯‮⁮‭⁯⁫‎‫‫⁪⁫⁮⁬⁫⁯‎‬‏‌‌⁭⁮‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * -991454186 ^ -1680570814;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_5:;
      }
    }

    static Delegate \u202E⁬‭⁯⁬‬‌‏⁯⁭‌‍​⁮⁯‮‭⁪⁪‬‭⁭​‌‌‬‎‏‭‎‪⁭⁪⁫⁫⁫‫‫​‌‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u202D‮‮‭‫‫‎‮‭‬⁬‭⁮⁫⁬​‭‭‬⁫⁯‍⁪‮​⁮‬‮‭‪‏⁭‪⁯‪‬​⁮‌⁯‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static PropertyChangedEventArgs \u200B‎⁭‍⁭⁯‌⁯‍‭⁫‬‌‮‪⁯‮⁬‫⁫‌‍‮‏‭‎‌‏⁬‫⁯⁫‭‬‬‍‌⁮⁪‬‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }

    static void \u206B‭‭‏‏⁪‫⁭⁮⁫‭‍‮⁮⁫⁯‏‮⁫‌‌‌⁪⁫‪‌‌‎‪⁯‮‏‭​‪‮‎‍‭⁬‮([In] ILog obj0, [In] string obj1, [In] object obj2)
    {
      obj0.DebugFormat(obj1, obj2);
    }

    static void \u202D‏‮⁭‭‮⁯​‪⁬‫⁯‫‌⁫⁬⁭‍⁯‮⁮‭⁯⁫‎‫‫⁪⁫⁮⁬⁫⁯‎‬‏‌‌⁭⁮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static string \u200D⁬‮⁮⁭‮‪‌‍‍‪‍​‌⁮⁮⁯‮⁬‌‎‬⁯‎‮‏⁬⁪‎‮‎⁭⁫⁮​‎‪⁪‌‎‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static Process \u202E⁬⁬‌⁬‮⁪​⁯‌​⁯⁫⁮‍⁭⁮‏⁮⁭⁯‍‫‪⁪⁪⁮‫‫⁯‍⁯‎⁫‮⁮‏⁮‏‏‮([In] string obj0)
    {
      return Process.Start(obj0);
    }

    static MethodBase \u200B​‮‭⁮‌​⁭⁭‮⁯‬⁫‭⁬‌⁫​‏⁯⁪‍⁮‬‎⁯‮‌‍‪​⁪⁫‪‍⁮‫​​‮‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206D⁮‌​‌‪‏‮‫‌‌‭‎‭‏‭⁮‬‬‎‮‌‪⁪⁪‫‭‎‍‏‍⁮⁬​‮‪‬⁬⁭‏‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u202A‎⁪​⁬‎⁭‮‮‫‍‫‏⁮‍⁭‪⁭‍⁪‌⁯‎‏‎⁮‪⁫‭‬⁫‭‏⁬‍‬​⁪‬‌‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static object \u202C⁫⁯‏‍⁫‮⁯‏‮⁫‮‫‎⁯⁬‬‎‫⁮‫‭‏⁭⁪⁯‬‌‮⁯‏‏⁭‌‬⁯⁯‍⁮‌‮()
    {
      return new object();
    }
  }
}
