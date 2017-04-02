// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.ActivityOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;

namespace ZoomZoom.Models.Activities
{
  public class ActivityOptions : CoreObject
  {
    private static readonly object optionsLock = ActivityOptions.\u206F⁫‎⁭‭‫⁪‭​‎⁮⁪‍‮‌‬‮‍⁬‬‎‬‪‍‫‬‮‮‭⁫‬‍⁯‍​⁭⁯‫⁪‮‮();
    private Dictionary<string, object> settingsPriorToStart = new Dictionary<string, object>();

    public bool DisableHighlighting { get; set; }

    public bool DisableApplyLayout { get; set; }

    public int MaximumStartCount { get; internal set; }

    public bool DisplayAfterCapture { get; set; }

    public bool SaveAfterCapture { get; set; }

    public bool MinimizeEngineView { get; set; }

    public string ExecuteAs { get; set; }

    public bool SuppressProgressReports { get; set; }

    public Dictionary<string, object> SettingsPriorToStart
    {
      get
      {
        Dictionary<string, object> settingsPriorToStart = this.settingsPriorToStart;
label_1:
        int num1 = 478128182;
        while (true)
        {
          int num2 = 222133449;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 605092419 ^ -912991660;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return settingsPriorToStart;
      }
      set
      {
        this.settingsPriorToStart = value;
      }
    }

    public List<string> UserNameList { get; set; }

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Activity;
label_1:
        int num1 = 773605030;
        while (true)
        {
          int num2 = 2036777838;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1356167148 ^ 7449500;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public bool MinimizeOverlappedWindows { get; internal set; }

    public ActivityOptions()
    {
      this.DisableHighlighting = false;
      this.DisableApplyLayout = false;
      this.MaximumStartCount = 3;
      this.DisplayAfterCapture = false;
      this.SaveAfterCapture = false;
      this.ExecuteAs = "";
    }

    internal void AddPriorSetting(string key, object value)
    {
      object optionsLock = ActivityOptions.optionsLock;
      bool flag1 = false;
      try
      {
        ActivityOptions.\u206C⁫⁫‮‎⁭‏⁯⁮‏⁭⁮‮‌‮‏​‏‎‎⁯‫⁯⁯‍‎⁫⁬⁬‬‎‫‪​⁪‭​‍⁪‬‮(optionsLock, ref flag1);
label_2:
        int num1 = 970443500;
        while (true)
        {
          int num2 = 520644361;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 14U)
          {
            case 0:
              this.SettingsPriorToStart[key] = value;
              num1 = (int) num3 * -1362274183 ^ -779643940;
              continue;
            case 1:
              num1 = (int) num3 * 177206733 ^ 1611227943;
              continue;
            case 2:
              this.SettingsPriorToStart.Add(key, value);
              num1 = (int) num3 * -483457697 ^ 1100453826;
              continue;
            case 3:
              num1 = (int) num3 * 190627522 ^ 492124851;
              continue;
            case 4:
              num1 = (int) num3 * -1010291524 ^ 50520611;
              continue;
            case 5:
              num1 = (int) num3 * 1908825782 ^ 941006596;
              continue;
            case 6:
              flag2 = this.SettingsPriorToStart.ContainsKey(key);
              num1 = (int) num3 * 1217537740 ^ -606483677;
              continue;
            case 7:
              num1 = (int) num3 * 1525757696 ^ 1323142115;
              continue;
            case 8:
              int num4 = flag2 ? 1948236253 : (num4 = 1086647368);
              int num5 = (int) num3 * 1163514839;
              num1 = num4 ^ num5;
              continue;
            case 9:
              num1 = (int) num3 * 2110940877 ^ -124490744;
              continue;
            case 10:
              num1 = 438615751;
              continue;
            case 11:
              goto label_2;
            case 12:
              goto label_20;
            case 13:
              num1 = 1704026295;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        return;
label_20:;
      }
      finally
      {
        if (flag1)
        {
label_18:
          int num1 = 1359942530;
          while (true)
          {
            int num2 = 520644361;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_18;
              case 1:
                ActivityOptions.\u200B‭‮⁭‫‍⁫‌‎‭‮‏⁪‭‬​‫⁪⁪‮​‬‫‭⁬‌‬‬‮‭‏‏‮‬⁪​⁯⁭⁪‍‮(optionsLock);
                num1 = (int) num3 * -1529010074 ^ -421108153;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
    }

    internal object GetPriorSetting(string key)
    {
label_1:
      int num1 = 62733790;
      object obj1;
      while (true)
      {
        int num2 = 1313426708;
        uint num3;
        object obj2;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            obj1 = obj2;
            num1 = 1024130472;
            continue;
          case 1:
            int num4 = !flag ? -167602693 : (num4 = -703667232);
            int num5 = (int) num3 * -425038881;
            num1 = num4 ^ num5;
            continue;
          case 2:
            obj2 = (object) null;
            num1 = (int) num3 * 1111110339 ^ -525652220;
            continue;
          case 3:
            obj2 = this.SettingsPriorToStart[key];
            num1 = (int) num3 * 1993904771 ^ -2108039387;
            continue;
          case 4:
            num1 = (int) num3 * 1504336077 ^ 2003164631;
            continue;
          case 5:
            goto label_1;
          case 6:
            flag = this.SettingsPriorToStart.ContainsKey(key);
            num1 = (int) num3 * 808044395 ^ 669971479;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return obj1;
    }

    internal bool HasPriorSetting(string key)
    {
      bool flag1 = false;
label_1:
      int num1 = 117416667;
      object optionsLock;
      while (true)
      {
        int num2 = 1578132745;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            optionsLock = ActivityOptions.optionsLock;
            num1 = (int) num3 * 914520277 ^ 722931366;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag2 = false;
      try
      {
        ActivityOptions.\u206C⁫⁫‮‎⁭‏⁯⁮‏⁭⁮‮‌‮‏​‏‎‎⁯‫⁯⁯‍‎⁫⁬⁬‬‎‫‪​⁪‭​‍⁪‬‮(optionsLock, ref flag2);
label_6:
        int num2 = 1777637142;
        while (true)
        {
          int num3 = 1578132745;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              flag1 = this.SettingsPriorToStart.ContainsKey(key);
              num2 = (int) num4 * 1529900972 ^ 116574180;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_10:
          int num2 = 336558562;
          while (true)
          {
            int num3 = 1578132745;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_10;
              case 2:
                num2 = (int) num4 * -16741462 ^ 1801297648;
                continue;
              case 3:
                ActivityOptions.\u200B‭‮⁭‫‍⁫‌‎‭‮‏⁪‭‬​‫⁪⁪‮​‬‫‭⁬‌‬‬‮‭‏‏‮‬⁪​⁯⁭⁪‍‮(optionsLock);
                num2 = (int) num4 * -467687879 ^ 159204164;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      bool flag3 = flag1;
label_16:
      int num5 = 1578348972;
      while (true)
      {
        int num2 = 1578132745;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_16;
          case 2:
            num5 = (int) num3 * -725516722 ^ -1496119877;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return flag3;
    }

    internal void RemovePriorSetting(string key)
    {
label_1:
      int num1 = 1083936038;
      object optionsLock;
      while (true)
      {
        int num2 = 1285846535;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            optionsLock = ActivityOptions.optionsLock;
            num1 = (int) num3 * -392867124 ^ 52754907;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        ActivityOptions.\u206C⁫⁫‮‎⁭‏⁯⁮‏⁭⁮‮‌‮‏​‏‎‎⁯‫⁯⁯‍‎⁫⁬⁬‬‎‫‪​⁪‭​‍⁪‬‮(optionsLock, ref flag);
label_6:
        int num2 = 1558653882;
        while (true)
        {
          int num3 = 1285846535;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = (int) num4 * -932111642 ^ -1402638555;
              continue;
            case 1:
              goto label_16;
            case 2:
              goto label_6;
            case 3:
              num2 = (int) num4 * -219580230 ^ -1383176714;
              continue;
            case 4:
              this.SettingsPriorToStart.Remove(key);
              num2 = (int) num4 * 873301845 ^ -1576849952;
              continue;
            case 5:
              num2 = (int) num4 * 659192637 ^ 1382348056;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return;
label_16:;
      }
      finally
      {
        if (flag)
        {
label_14:
          int num2 = 1013261038;
          while (true)
          {
            int num3 = 1285846535;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 791019069 ^ -564007692;
                continue;
              case 1:
                ActivityOptions.\u200B‭‮⁭‫‍⁫‌‎‭‮‏⁪‭‬​‫⁪⁪‮​‬‫‭⁬‌‬‬‮‭‏‏‮‬⁪​⁯⁭⁪‍‮(optionsLock);
                num2 = (int) num4 * 431323509 ^ -1799445442;
                continue;
              case 2:
                goto label_14;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    protected virtual void CapturePriorSettings()
    {
      if (!this.DisableApplyLayout)
        goto label_6;
label_1:
      int num1 = 153574406;
label_2:
      while (true)
      {
        int num2 = 1159064709;
        uint num3;
        bool minimizeEngineView;
        switch ((num3 = (uint) (num1 ^ num2)) % 13U)
        {
          case 0:
            minimizeEngineView = this.MinimizeEngineView;
            num1 = 1004695636;
            continue;
          case 1:
            num1 = (int) num3 * -615932882 ^ -660271851;
            continue;
          case 2:
            num1 = (int) num3 * -1099715417 ^ 161103668;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 216821355 ^ 1432855677;
            continue;
          case 5:
            this.AddPriorSetting(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1474280944U), (object) this.Engine.Settings.DisplayHighlightWindows);
            num1 = (int) num3 * -1616320015 ^ 2140856881;
            continue;
          case 6:
            num1 = (int) num3 * 644093963 ^ 1678789286;
            continue;
          case 7:
            this.AddPriorSetting(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4065527654U), (object) this.Engine.Settings.ApplyLayoutPattern);
            num1 = (int) num3 * 673345062 ^ -1440144995;
            continue;
          case 8:
            goto label_3;
          case 9:
            num1 = (int) num3 * -1493477163 ^ 1438174707;
            continue;
          case 10:
            int num4 = !minimizeEngineView ? 1535190027 : (num4 = 1798527005);
            int num5 = (int) num3 * 1491799755;
            num1 = num4 ^ num5;
            continue;
          case 11:
            this.AddPriorSetting(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3174571410U), (object) ActivityOptions.\u200B‌‭‬‮‍⁪‏‪‪‍‭⁪‪⁭⁭⁫⁫​⁪⁪⁬‫‬⁯⁯‮⁯‪‭⁬​⁪⁯​‫⁬⁫⁯‬‮((UIElement) this.Engine.EngineView));
            num1 = (int) num3 * -803150792 ^ -1191093207;
            continue;
          case 12:
            goto label_6;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_3:
      return;
label_6:
      num1 = this.DisableHighlighting ? 261245518 : (num1 = 1428171306);
      goto label_2;
    }

    protected virtual void RestorePriorSettings()
    {
label_1:
      int num1 = 694393231;
      while (true)
      {
        int num2 = 827733847;
        uint num3;
        bool flag1;
        bool flag2;
        int num4;
        int num5;
        int num6;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            goto label_1;
          case 1:
            ActivityOptions.\u200F‍⁫⁮‎⁮⁪⁫‫⁯⁭‫⁯⁮‬⁪⁫⁮⁫⁯‪⁭‫‌​⁪‌‭⁪⁫‬⁬​⁯⁬⁬‌‬⁭‮((UIElement) this.Engine.EngineView, (Visibility) this.GetPriorSetting(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2639068262U)));
            num1 = (int) num3 * 231136485 ^ -1046002601;
            continue;
          case 2:
            num1 = (int) num3 * 2009966712 ^ 1835967365;
            continue;
          case 3:
            int num7 = flag1 ? -427653752 : (num7 = -1148133894);
            int num8 = (int) num3 * 615662583;
            num1 = num7 ^ num8;
            continue;
          case 4:
            this.Engine.Settings.ApplyLayoutPattern = (bool) this.GetPriorSetting(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4065527654U));
            num1 = (int) num3 * 1338747944 ^ -1670483973;
            continue;
          case 5:
            num4 = this.HasPriorSetting("") ? 1 : 0;
            goto label_22;
          case 6:
            num1 = (int) num3 * -616086498 ^ -1393851412;
            continue;
          case 7:
            num1 = (int) num3 * 141379105 ^ -1815840251;
            continue;
          case 8:
            num1 = (int) num3 * 955315735 ^ 1006334299;
            continue;
          case 9:
            int num9 = !flag2 ? -1721645339 : (num9 = -698598086);
            int num10 = (int) num3 * 919905923;
            num1 = num9 ^ num10;
            continue;
          case 10:
            num1 = (int) num3 * 1301230499 ^ 1966767562;
            continue;
          case 11:
            num1 = (int) num3 * -1622230212 ^ 213837575;
            continue;
          case 12:
            this.Engine.Settings.DisplayHighlightWindows = (bool) this.GetPriorSetting(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1463639909U));
            num1 = (int) num3 * -1919238202 ^ 1972631912;
            continue;
          case 13:
            num5 = this.HasPriorSetting(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2082865122U)) ? 1 : 0;
            break;
          case 14:
            if (this.MinimizeEngineView)
            {
              num1 = 1102898836;
              continue;
            }
            num6 = 0;
            goto label_25;
          case 15:
            num6 = this.HasPriorSetting(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1233662718U)) ? 1 : 0;
            goto label_25;
          case 16:
            if (this.DisableHighlighting)
            {
              num1 = 1229895473;
              continue;
            }
            num4 = 0;
            goto label_22;
          case 17:
            num1 = (int) num3 * 1180598149 ^ 1240371353;
            continue;
          case 18:
            goto label_3;
          case 19:
            num1 = (int) num3 * -1176907973 ^ 1286668868;
            continue;
          case 20:
            if (!this.DisableApplyLayout)
            {
              num5 = 0;
              break;
            }
            num1 = (int) num3 * -496180355 ^ -1715465797;
            continue;
          default:
            goto label_32;
        }
        int num11;
        num1 = num11 = num5 != 0 ? 413404177 : (num11 = 1581725432);
        continue;
label_22:
        flag2 = num4 != 0;
        num1 = 162617838;
        continue;
label_25:
        flag1 = num6 != 0;
        num1 = 1634976942;
      }
label_32:
      return;
label_3:;
    }

    static void \u206C⁫⁫‮‎⁭‏⁯⁮‏⁭⁮‮‌‮‏​‏‎‎⁯‫⁯⁯‍‎⁫⁬⁬‬‎‫‪​⁪‭​‍⁪‬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200B‭‮⁭‫‍⁫‌‎‭‮‏⁪‭‬​‫⁪⁪‮​‬‫‭⁬‌‬‬‮‭‏‏‮‬⁪​⁯⁭⁪‍‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static Visibility \u200B‌‭‬‮‍⁪‏‪‪‍‭⁪‪⁭⁭⁫⁫​⁪⁪⁬‫‬⁯⁯‮⁯‪‭⁬​⁪⁯​‫⁬⁫⁯‬‮([In] UIElement obj0)
    {
      return obj0.Visibility;
    }

    static void \u200F‍⁫⁮‎⁮⁪⁫‫⁯⁭‫⁯⁮‬⁪⁫⁮⁫⁯‪⁭‫‌​⁪‌‭⁪⁫‬⁬​⁯⁬⁬‌‬⁭‮([In] UIElement obj0, [In] Visibility obj1)
    {
      obj0.Visibility = obj1;
    }

    static object \u206F⁫‎⁭‭‫⁪‭​‎⁮⁪‍‮‌‬‮‍⁬‬‎‬‪‍‫‬‮‮‭⁫‬‍⁯‍​⁭⁯‫⁪‮‮()
    {
      return new object();
    }
  }
}
