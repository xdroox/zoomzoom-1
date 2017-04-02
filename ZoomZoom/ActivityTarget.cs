// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ActivityTarget
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.ObjectModel;

namespace ZoomZoom
{
  public class ActivityTarget : CoreObject
  {
    private static readonly object targetLock = ActivityTarget.\u200B‪⁪‫​‬⁯⁬‍‪⁫⁬‍⁬⁯‌‭⁯⁫⁭‌‏⁯‪⁪⁫⁭⁯⁯‍‎⁬‮‎‬‪‬⁯⁪⁯‮();
    private string target = string.Empty;
    private ObservableCollection<string> targets = new ObservableCollection<string>();
    private bool findTarget = false;
    private ObservableCollection<string> userNames = new ObservableCollection<string>();
    private string userName = string.Empty;

    public string Target
    {
      get
      {
label_1:
        int num1 = -976653527;
        string target;
        while (true)
        {
          int num2 = -247972749;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 337433935 ^ 997183439;
              continue;
            case 2:
              target = this.target;
              num1 = (int) num3 * 441964663 ^ -1499331700;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return target;
      }
      set
      {
label_1:
        int num1 = 1821254494;
        while (true)
        {
          int num2 = 1486641563;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.target = value;
              num1 = (int) num3 * 521788524 ^ -1730987297;
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

    public ObservableCollection<string> Targets
    {
      get
      {
label_1:
        int num1 = -857005581;
        ObservableCollection<string> targets;
        while (true)
        {
          int num2 = -1378756456;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              targets = this.targets;
              num1 = (int) num3 * -1567655182 ^ -222157512;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return targets;
      }
      set
      {
        this.targets = value;
      }
    }

    public bool FindTarget
    {
      get
      {
label_1:
        int num1 = -285719681;
        bool findTarget;
        while (true)
        {
          int num2 = -1052406643;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              findTarget = this.findTarget;
              num1 = (int) num3 * 1468034810 ^ -1265872426;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return findTarget;
      }
      set
      {
label_1:
        int num1 = 1846971042;
        while (true)
        {
          int num2 = 223579343;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.findTarget = value;
              num1 = (int) num3 * -428963585 ^ 1456986294;
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

    public ObservableCollection<string> UserNames
    {
      get
      {
label_1:
        int num1 = -296308439;
        ObservableCollection<string> activeUsers;
        while (true)
        {
          int num2 = -1000128683;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              activeUsers = this.Engine.ActiveUsers;
              num1 = (int) num3 * -1625358151 ^ 1714012284;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeUsers;
      }
    }

    public string UserName
    {
      get
      {
label_1:
        int num1 = -1469882693;
        string userName;
        while (true)
        {
          int num2 = -2082446035;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              userName = this.userName;
              num1 = (int) num3 * -869557592 ^ -930311724;
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
        this.userName = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
        return TraceType.Activity;
      }
    }

    public ActivityTarget()
    {
label_1:
      int num1 = -1971395345;
      while (true)
      {
        int num2 = -740452655;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_3;
          case 1:
            ((Collection<string>) this.targets).Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3340326474U));
            num1 = (int) num3 * -1709103011 ^ 1668625627;
            continue;
          case 2:
            num1 = (int) num3 * 777926010 ^ 119073772;
            continue;
          case 3:
            num1 = (int) num3 * -475825133 ^ 1269013216;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * -516434221 ^ 737547110;
            continue;
          case 6:
            ((Collection<string>) this.targets).Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(112296576U));
            num1 = (int) num3 * 1088996760 ^ -848356099;
            continue;
          case 7:
            ((Collection<string>) this.targets).Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1117683297U));
            num1 = (int) num3 * -1000230590 ^ -871254531;
            continue;
          case 8:
            num1 = (int) num3 * 301666651 ^ -1723690511;
            continue;
          case 9:
            ((Collection<string>) this.targets).Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1035425539U));
            num1 = (int) num3 * 676980891 ^ -2062166804;
            continue;
          case 10:
            ((Collection<string>) this.targets).Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2886348403U));
            num1 = (int) num3 * -1157690180 ^ -2134008069;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    static object \u200B‪⁪‫​‬⁯⁬‍‪⁫⁬‍⁬⁯‌‭⁯⁫⁭‌‏⁯‪⁪⁫⁭⁯⁯‍‎⁬‮‎‬‪‬⁯⁪⁯‮()
    {
      return new object();
    }
  }
}
