// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ManagerBase
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace ZoomZoom
{
  public class ManagerBase : CoreObject
  {
    protected static readonly object managerLock = ManagerBase.\u200D‮‪‬⁬⁫‌‌‍‭‪⁫‍‌‭‮⁯‍⁫⁯‏‪‍‫‌‫‌​⁬‎⁫⁪⁭‎⁭‎‮‫⁪‮();
    protected DateTime startTime = DateTime.MinValue;
    private SharedData sharedData = (SharedData) null;
    private ManagerState managerState = ManagerState.Undefined;
    protected bool initialized;
    protected bool cancelRequested;
    private CancellationToken token;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -1929678074;
        TraceType traceType;
        while (true)
        {
          int num2 = -1715801185;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              traceType = TraceType.Application;
              num1 = (int) num3 * 2107453288 ^ -215030111;
              continue;
            case 2:
              num1 = (int) num3 * -156024243 ^ 1073657730;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public bool Initialized
    {
      get
      {
label_1:
        int num1 = 296516182;
        bool initialized;
        while (true)
        {
          int num2 = 1541219913;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1872220844 ^ -2046419828;
              continue;
            case 3:
              initialized = this.initialized;
              num1 = (int) num3 * 324536675 ^ -1268527206;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return initialized;
      }
      set
      {
        this.initialized = value;
      }
    }

    public bool CancelRequested
    {
      get
      {
label_1:
        int num1 = -1635230130;
        bool cancelRequested;
        while (true)
        {
          int num2 = -1403942295;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -2080841154 ^ 1698862941;
              continue;
            case 3:
              cancelRequested = this.cancelRequested;
              num1 = (int) num3 * -517029073 ^ 763508253;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return cancelRequested;
      }
      set
      {
        this.cancelRequested = value;
      }
    }

    protected DateTime StartTime
    {
      get
      {
        return this.startTime;
      }
      set
      {
        this.startTime = value;
      }
    }

    public ManagerState ManagerState
    {
      get
      {
label_1:
        int num1 = 905944508;
        ManagerState managerState;
        while (true)
        {
          int num2 = 1923604594;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              managerState = this.managerState;
              num1 = (int) num3 * 841400840 ^ 2087571705;
              continue;
            case 3:
              num1 = (int) num3 * 1093991211 ^ 607132390;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return managerState;
      }
      set
      {
        this.managerState = value;
      }
    }

    protected SharedData SharedData
    {
      get
      {
        if (this.sharedData != null)
          goto label_6;
label_1:
        int num1 = -239732304;
label_2:
        while (true)
        {
          int num2 = -1894603883;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_6;
            case 1:
              this.sharedData = Engine.Instance.SharedData;
              num1 = (int) num3 * -1171675797 ^ 194905618;
              continue;
            case 2:
              num1 = (int) num3 * 1254920398 ^ -1571887641;
              continue;
            case 3:
              num1 = (int) num3 * 396324825 ^ -1339112989;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        SharedData sharedData;
        return sharedData;
label_6:
        sharedData = this.sharedData;
        num1 = -1688380847;
        goto label_2;
      }
      set
      {
        this.sharedData = value;
      }
    }

    public CancellationToken Token
    {
      get
      {
label_1:
        int num1 = 151444812;
        CancellationToken token;
        while (true)
        {
          int num2 = 1978537122;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -2137316152 ^ 2142260482;
              continue;
            case 2:
              token = this.token;
              num1 = (int) num3 * 1853118355 ^ -343379451;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return token;
      }
      set
      {
label_1:
        int num1 = -566845889;
        while (true)
        {
          int num2 = -178091207;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.token = value;
              num1 = (int) num3 * -482599409 ^ 1315764639;
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

    internal virtual void Cancel()
    {
      object managerLock = ManagerBase.managerLock;
      bool flag = false;
      try
      {
        ManagerBase.\u206B​‬⁪‎‭‏‬‬​‌⁬⁯‮‎⁪⁬⁮‏‫⁫​⁯⁬‌⁬⁬‭⁮‏​⁭‫⁪⁪‍‮⁪‫⁬‮(managerLock, ref flag);
        this.CancelRequested = true;
label_2:
        int num1 = -1831412988;
        while (true)
        {
          int num2 = -117358434;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              num1 = (int) num3 * 1884983218 ^ -1632133522;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_9:;
      }
      finally
      {
        if (flag)
        {
label_7:
          int num1 = -1218904226;
          while (true)
          {
            int num2 = -117358434;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                ManagerBase.\u202D‭‪⁫‏‎‮‬⁮‫​⁯⁪‬⁫‭⁮⁯‏⁫​⁯⁫‭‪‭‏‮​‫‎​‏‭‍‌‍‬‮‮(managerLock);
                num1 = (int) num3 * -2142364593 ^ -2085084569;
                continue;
              case 2:
                goto label_7;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
    }

    protected Task StartSTATask(Action func)
    {
label_1:
      int num1 = 786247874;
      Task task;
      while (true)
      {
        int num2 = 1229466523;
        uint num3;
        Thread thread;
        Action func1;
        TaskCompletionSource<object> tcs;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            ManagerBase.\u206D⁪⁯‪‌‎​‏⁪‭‮‭‍‎‏‎⁯‬⁪⁪⁪‭‌⁯⁬​‎‏‎⁯‪⁬‬‍‏​⁯⁪⁬‮(thread);
            num1 = (int) num3 * 587742219 ^ -1392086544;
            continue;
          case 1:
            func1 = func;
            num1 = (int) num3 * -287062011 ^ -1206169710;
            continue;
          case 2:
            num1 = (int) num3 * 989351899 ^ 1418722637;
            continue;
          case 3:
            task = (Task) tcs.get_Task();
            num1 = (int) num3 * -1876050536 ^ -1061438331;
            continue;
          case 4:
            tcs = new TaskCompletionSource<object>();
            thread = ManagerBase.\u200C‌‮‫‫‏⁭⁫‌⁬‭⁫⁮‏⁪​⁪⁫​‫‭‮‍⁬‏‌⁮‎⁮‍‮​⁪⁫⁮‏⁪⁪⁭⁭‮((ThreadStart) (() =>
            {
              try
              {
label_2:
                int num2 = -1253943086;
                while (true)
                {
                  int num3 = -1267960905;
                  uint num4;
                  switch ((num4 = (uint) (num2 ^ num3)) % 5U)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      func1.Invoke();
                      tcs.SetResult((object) null);
                      num2 = (int) num4 * 229725413 ^ -2069505776;
                      continue;
                    case 2:
                      num2 = (int) num4 * -68265399 ^ 1367051159;
                      continue;
                    case 3:
                      num2 = (int) num4 * -1131047697 ^ 534124723;
                      continue;
                    case 4:
                      goto label_15;
                    default:
                      goto label_12;
                  }
                }
label_12:
                return;
label_15:;
              }
              catch (Exception ex)
              {
label_10:
                int num2 = -1645652178;
                while (true)
                {
                  int num3 = -1267960905;
                  uint num4;
                  switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                  {
                    case 0:
                      tcs.SetException(ex);
                      num2 = (int) num4 * -295926253 ^ -1484353756;
                      continue;
                    case 1:
                      num2 = (int) num4 * -168581484 ^ 1190245955;
                      continue;
                    case 2:
                      goto label_10;
                    case 3:
                      goto label_8;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return;
label_8:;
              }
            }));
            ManagerBase.\u200D‎‫​⁫‪⁫⁯‪‍‏‭‎⁯⁭⁫​‮​‬‍⁪‎‫⁭‭‎‪⁬‪‎​⁭⁮‏⁯‭‍‬⁯‮(thread, ApartmentState.STA);
            num1 = (int) num3 * 744935025 ^ 1830199557;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * -626387376 ^ -1909850324;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return task;
    }

    static void \u206B​‬⁪‎‭‏‬‬​‌⁬⁯‮‎⁪⁬⁮‏‫⁫​⁯⁬‌⁬⁬‭⁮‏​⁭‫⁪⁪‍‮⁪‫⁬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202D‭‪⁫‏‎‮‬⁮‫​⁯⁪‬⁫‭⁮⁯‏⁫​⁯⁫‭‪‭‏‮​‫‎​‏‭‍‌‍‬‮‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static Thread \u200C‌‮‫‫‏⁭⁫‌⁬‭⁫⁮‏⁪​⁪⁫​‫‭‮‍⁬‏‌⁮‎⁮‍‮​⁪⁫⁮‏⁪⁪⁭⁭‮([In] ThreadStart obj0)
    {
      return new Thread(obj0);
    }

    static void \u200D‎‫​⁫‪⁫⁯‪‍‏‭‎⁯⁭⁫​‮​‬‍⁪‎‫⁭‭‎‪⁬‪‎​⁭⁮‏⁯‭‍‬⁯‮([In] Thread obj0, [In] ApartmentState obj1)
    {
      obj0.SetApartmentState(obj1);
    }

    static void \u206D⁪⁯‪‌‎​‏⁪‭‮‭‍‎‏‎⁯‬⁪⁪⁪‭‌⁯⁬​‎‏‎⁯‪⁬‬‍‏​⁯⁪⁬‮([In] Thread obj0)
    {
      obj0.Start();
    }

    static object \u200D‮‪‬⁬⁫‌‌‍‭‪⁫‍‌‭‮⁯‍⁫⁯‏‪‍‫‌‫‌​⁬‎⁫⁪⁭‎⁭‎‮‫⁪‮()
    {
      return new object();
    }
  }
}
