// Decompiled with JetBrains decompiler
// Type: ZoomZoom.SharedData
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom
{
  public class SharedData
  {
    public static int contextId = 0;
    protected readonly ILog log = SharedData.\u206E‪⁪‎​⁭⁪⁪‭⁭‌‪⁬‫⁪⁮‎⁭‭‎⁭‫⁭‭⁬⁭‍‭⁫⁬⁯⁭⁯‌‮‬​⁮⁫‍‮(SharedData.\u200E‮⁭⁬‍⁫‪‭​‪‮⁪​‪‪⁪⁭⁭⁬⁯‭⁫‭‍‎‮⁪⁯⁪‮‮‍⁪‎⁯‍⁯‮‌⁫‮((MemberInfo) SharedData.\u202A‫⁫⁪‌‍‭⁬‮‭‫‫‭‬⁮‍​‮⁮‫⁪‌‮⁭​⁮‍‪‬⁫⁫‎‭‌‮‎⁫‪​‌‮()));
    private LayoutPattern activePattern = (LayoutPattern) null;
    private ObservableCollection<ZoomButton> meetingButtons = new ObservableCollection<ZoomButton>();
    public static readonly object dataLock;

    public SynchronizationContext Context { get; set; }

    public Engine App { get; set; }

    public ConcurrentQueue<ZoomEvent> ActivityQueue { get; set; }

    public ConcurrentQueue<ZoomEvent> HookQueue { get; set; }

    public ConcurrentQueue<ZoomEvent> WindowQueue { get; set; }

    public ConcurrentBag<ZoomWindow> ActiveWindows { get; set; }

    public ConcurrentBag<ActivityBase> ActivitiesCompleted { get; set; }

    public Settings Settings { get; set; }

    public ObservableCollection<ZoomButton> MeetingButtons
    {
      get
      {
label_1:
        int num1 = -459799354;
        ObservableCollection<ZoomButton> meetingButtons;
        while (true)
        {
          int num2 = -1535269393;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingButtons = this.meetingButtons;
              num1 = (int) num3 * -332511069 ^ 713331587;
              continue;
            case 3:
              num1 = (int) num3 * -846554183 ^ 2079703686;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingButtons;
      }
      set
      {
        this.meetingButtons = value;
      }
    }

    static SharedData()
    {
label_1:
      int num1 = 1161173;
      while (true)
      {
        int num2 = 1815371609;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            SharedData.dataLock = SharedData.\u202D​⁪⁬‏⁭​⁯‎⁯‍⁫‭⁪⁯‎‬⁯‏⁫‏‎‫​‏‍‏‌‌⁬‌‍‪⁪‍‭⁬⁫‭‍‮();
            num1 = (int) num3 * 1779110105 ^ 1338375041;
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

    public SharedData()
    {
label_1:
      int num1 = 79129400;
      while (true)
      {
        int num2 = 1360791782;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1733353493 ^ 1188111311;
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

    internal void SetActivePattern(LayoutPattern pattern)
    {
label_1:
      int num1 = -1582567626;
      object dataLock;
      while (true)
      {
        int num2 = -554570146;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            dataLock = SharedData.dataLock;
            num1 = (int) num3 * -1619709966 ^ -568713933;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        SharedData.\u206E​​⁫⁭‍‬‮⁭‎⁪⁫‏⁫‫⁬⁫‌⁯⁭‎‎‌⁫‎⁬⁪⁬‏‎⁭​‎⁬⁫⁬⁬‏​‪‮(dataLock, ref flag);
        this.activePattern = pattern;
      }
      finally
      {
        if (flag)
        {
label_7:
          int num2 = -2040093341;
          while (true)
          {
            int num3 = -554570146;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_7;
              case 1:
                SharedData.\u206B⁮‫‫‪⁭‭‌‮⁬‏⁭‪‭⁭⁮‭‮‏‌⁭‌‬‍‮⁬‭‪‌​‪‌‏⁯⁫‏‏⁭‍⁭‮(dataLock);
                num2 = (int) num4 * 980393169 ^ 2039205412;
                continue;
              case 3:
                num2 = (int) num4 * 599136642 ^ -763283174;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
    }

    internal void RemoveButton(ZoomButton button)
    {
      object dataLock = SharedData.dataLock;
      bool flag = false;
      try
      {
        SharedData.\u206E​​⁫⁭‍‬‮⁭‎⁪⁫‏⁫‫⁬⁫‌⁯⁭‎‎‌⁫‎⁬⁪⁬‏‎⁭​‎⁬⁫⁬⁬‏​‪‮(dataLock, ref flag);
label_2:
        int num1 = -237930759;
        while (true)
        {
          int num2 = -90087806;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              ((Collection<ZoomButton>) this.MeetingButtons).Remove(button);
              num1 = (int) num3 * -1310858613 ^ -965948481;
              continue;
            case 1:
              num1 = (int) num3 * -1134958852 ^ -1050688;
              continue;
            case 2:
              goto label_12;
            case 3:
              button = (ZoomButton) null;
              num1 = -1756225546;
              continue;
            case 4:
              int num4 = ((Collection<ZoomButton>) this.MeetingButtons).Contains(button) ? 1281453152 : (num4 = 1150094729);
              int num5 = (int) num3 * -2090776782;
              num1 = num4 ^ num5;
              continue;
            case 5:
              goto label_2;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_12:;
      }
      finally
      {
        if (flag)
        {
label_10:
          int num1 = -1268003640;
          while (true)
          {
            int num2 = -90087806;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_10;
              case 2:
                SharedData.\u206B⁮‫‫‪⁭‭‌‮⁬‏⁭‪‭⁭⁮‭‮‏‌⁭‌‬‍‮⁬‭‪‌​‪‌‏⁯⁫‏‏⁭‍⁭‮(dataLock);
                num1 = (int) num3 * -332114335 ^ 1897897051;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    static MethodBase \u202A‫⁫⁪‌‍‭⁬‮‭‫‫‭‬⁮‍​‮⁮‫⁪‌‮⁭​⁮‍‪‬⁫⁫‎‭‌‮‎⁫‪​‌‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200E‮⁭⁬‍⁫‪‭​‪‮⁪​‪‪⁪⁭⁭⁬⁯‭⁫‭‍‎‮⁪⁯⁪‮‮‍⁪‎⁯‍⁯‮‌⁫‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206E‪⁪‎​⁭⁪⁪‭⁭‌‪⁬‫⁪⁮‎⁭‭‎⁭‫⁭‭⁬⁭‍‭⁫⁬⁯⁭⁯‌‮‬​⁮⁫‍‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    static void \u206E​​⁫⁭‍‬‮⁭‎⁪⁫‏⁫‫⁬⁫‌⁯⁭‎‎‌⁫‎⁬⁪⁬‏‎⁭​‎⁬⁫⁬⁬‏​‪‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206B⁮‫‫‪⁭‭‌‮⁬‏⁭‪‭⁭⁮‭‮‏‌⁭‌‬‍‮⁬‭‪‌​‪‌‏⁯⁫‏‏⁭‍⁭‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static object \u202D​⁪⁬‏⁭​⁯‎⁯‍⁫‭⁪⁯‎‬⁯‏⁫‏‎‫​‏‍‏‌‌⁬‌‍‪⁪‍‭⁬⁫‭‍‮()
    {
      return new object();
    }
  }
}
