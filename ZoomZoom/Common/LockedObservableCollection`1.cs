// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.LockedObservableCollection`1
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using ZoomZoom.Models.Events;

namespace ZoomZoom.Common
{
  public class LockedObservableCollection<T> : ObservableCollection<T>
  {
    protected static readonly object collectionLock = LockedObservableCollection<T>.\u202D‌‮⁬‎‮‪⁫‍‏​‫‮‮‮⁮⁮‬⁮‏‮‎‌⁬‮⁮‫‎‮‭⁮‪‏‬⁪​‬‮‍‭‮();
    protected static readonly ILog log = LockedObservableCollection<T>.\u206F‪‎‏‮‮⁭‌⁮‏‫⁫‪‮​⁮⁭‌⁮⁮‌⁮‭⁫⁮‏​‏‬‍⁯⁮‪‏‎⁪⁪‭‬⁭‮(LockedObservableCollection<T>.\u202C‫‪‫​⁮‪​⁮⁮‮⁬‏‏⁬‏‏‬⁯‫‌‬‌⁭‪⁪‍‌⁭‪‍‭‭⁫‍‍‎⁬‌‬‮((MemberInfo) LockedObservableCollection<T>.\u206A⁭‎⁫‭‫⁮‎‪⁭‏⁪‎‌⁪⁫‏‪‍‏⁪‪‌‫⁬⁬‍⁭‪‮‍⁫⁫⁭‎​⁮⁯‍‌‮()));
    private object source;
    private bool subscribeToChanges;
    protected readonly IEventAggregator _eventAggregator;

    protected object Source
    {
      get
      {
        return this.source;
      }
      set
      {
label_1:
        int num1 = 1067696571;
        while (true)
        {
          int num2 = 886142646;
          uint num3;
          bool flag;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 17U)
          {
            case 0:
              this.source = value;
              num1 = 1958041084;
              continue;
            case 1:
              if (this.source != null)
              {
                num1 = (int) num3 * 1493315302 ^ -403980149;
                continue;
              }
              num4 = 0;
              break;
            case 2:
              if (this.source != value)
              {
                num1 = (int) num3 * 1927943075 ^ -960648809;
                continue;
              }
              goto label_24;
            case 3:
              this.DetachEventHandler();
              num1 = (int) num3 * -216611047 ^ -1325091044;
              continue;
            case 4:
              this.OnPropertyChanged(LockedObservableCollection<T>.\u200F‎‌‮‫⁯​⁫⁯‪⁯⁪‫‬⁪‎‌‌⁮‬‬⁮⁯‫‬‍⁮‍​‭⁬‍‍⁮⁪‌‭‪‌‏‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2610469069U)));
              num1 = 1418437372;
              continue;
            case 5:
              int num6 = !flag ? -1117442765 : (num6 = -659595768);
              int num7 = (int) num3 * 724053145;
              num1 = num6 ^ num7;
              continue;
            case 6:
              num1 = (int) num3 * -2085903046 ^ 445714569;
              continue;
            case 7:
              this.AttachEventHandler();
              num1 = (int) num3 * -1572946547 ^ -2101362840;
              continue;
            case 8:
              goto label_1;
            case 9:
              num1 = (int) num3 * 277657200 ^ -1594574386;
              continue;
            case 10:
              num5 = this.SubscribeToChanges ? 1 : 0;
              goto label_25;
            case 11:
              num1 = (int) num3 * 1978924494 ^ -1768795907;
              continue;
            case 12:
              goto label_3;
            case 13:
              num1 = (int) num3 * 2099844886 ^ -976327293;
              continue;
            case 14:
              num1 = (int) num3 * 848659461 ^ -277564396;
              continue;
            case 15:
              if (this.source != null)
              {
                num1 = (int) num3 * 718053762 ^ -288776183;
                continue;
              }
              goto label_24;
            case 16:
              num4 = this.SubscribeToChanges ? 1 : 0;
              break;
            default:
              goto label_26;
          }
          int num8;
          num1 = num8 = num4 != 0 ? 833889681 : (num8 = 1627765790);
          continue;
label_24:
          num5 = 0;
label_25:
          flag = num5 != 0;
          num1 = 182118026;
        }
label_26:
        return;
label_3:;
      }
    }

    public bool SubscribeToChanges
    {
      get
      {
label_1:
        int num1 = -275553997;
        bool subscribeToChanges;
        while (true)
        {
          int num2 = -84908130;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1845040198 ^ -1971936860;
              continue;
            case 1:
              subscribeToChanges = this.subscribeToChanges;
              num1 = (int) num3 * -1283433743 ^ -1806218069;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return subscribeToChanges;
      }
      set
      {
        this.subscribeToChanges = value;
      }
    }

    public LockedObservableCollection()
    {
      base.\u002Ector();
label_1:
      int num1 = 1539065316;
      while (true)
      {
        int num2 = 1798262911;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1739151928 ^ -1924004238;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 1346057647 ^ 1599613438;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      LockedObservableCollection<T>.\u202C‫⁭⁯‫‏⁯‌‭‪‫‎​⁪⁭‌‌⁬‏‭​‪‪‌⁪⁬‬⁮‪‪‍⁮‏‌‪‬⁯‍‬‏‮((IEnumerable) ((Collection<T>) this).Items, LockedObservableCollection<T>.collectionLock);
      this._eventAggregator = ApplicationService.Instance.EventAggregator;
    }

    public LockedObservableCollection(Collection<T> source, bool subscribeToChanges = true)
    {
      base.\u002Ector();
      LockedObservableCollection<T>.\u202C‫⁭⁯‫‏⁯‌‭‪‫‎​⁪⁭‌‌⁬‏‭​‪‪‌⁪⁬‬⁮‪‪‍⁮‏‌‪‬⁯‍‬‏‮((IEnumerable) ((Collection<T>) this).Items, LockedObservableCollection<T>.collectionLock);
      this.SetSourceCollection(source, subscribeToChanges);
      this._eventAggregator = ApplicationService.Instance.EventAggregator;
    }

    public LockedObservableCollection(ConcurrentBag<T> bag, bool subscribe)
    {
      base.\u002Ector();
label_1:
      int num1 = 991205772;
      while (true)
      {
        int num2 = 748108292;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1526806015 ^ -141300612;
            continue;
          case 3:
            this.Refresh();
            num1 = (int) num3 * -1720589286 ^ 2037677043;
            continue;
          case 4:
            num1 = (int) num3 * -673774628 ^ -1683264527;
            continue;
          case 5:
            this.source = (object) bag;
            num1 = (int) num3 * -1332518137 ^ -1995491093;
            continue;
          case 6:
            num1 = (int) num3 * 313977389 ^ -322047937;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      this.subscribeToChanges = subscribe;
    }

    internal void SetSourceCollection(Collection<T> source, bool subscribeToChanges = true)
    {
      object collectionLock = LockedObservableCollection<T>.collectionLock;
      bool flag = false;
      try
      {
        LockedObservableCollection<T>.\u206F‍⁭​⁪‮‎‌‫⁪‍⁪‫‪‏‬‎‫‏‮⁫⁪​​⁬⁯⁯⁮‍‎‭⁪‭​‮‌‎‍⁭⁬‮(collectionLock, ref flag);
label_2:
        int num1 = -892543836;
        while (true)
        {
          int num2 = -2020860603;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              this.SubscribeToChanges = subscribeToChanges;
              num1 = (int) num3 * -809613826 ^ -2041104797;
              continue;
            case 1:
              num1 = (int) num3 * 1792458916 ^ -939845745;
              continue;
            case 3:
              goto label_2;
            case 4:
              num1 = (int) num3 * 1991038350 ^ 1799678432;
              continue;
            case 5:
              this.Source = (object) source;
              num1 = (int) num3 * -1053924196 ^ -1904585377;
              continue;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_9:
          int num1 = -2019058012;
          while (true)
          {
            int num2 = -2020860603;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num1 = (int) num3 * -1443068371 ^ 329240274;
                continue;
              case 1:
                LockedObservableCollection<T>.\u206D‬‏‫‍‭‮​⁬‌‎‪‍‮⁬⁭‮‭‭‎‫⁯‪⁫⁪‭⁬⁪⁯⁮‍‎‍‎⁭‏⁭​‎⁫‮(collectionLock);
                num1 = (int) num3 * -1005493628 ^ 492435269;
                continue;
              case 2:
                goto label_9;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_14:
      LockedObservableCollection<T>.\u206E⁬‬⁯‮‍⁮‭‎‏‬‫‌⁬‍​​‬⁯‌‮‪⁭‬‬‪‮‍⁬‬‭⁯‪‪‭‎⁯‎‭⁬‮(new WaitCallback(this.PopulateCollection), (object) source);
    }

    public void Refresh()
    {
      try
      {
label_2:
        int num1 = -683822371;
        while (true)
        {
          int num2 = -504877753;
          uint num3;
          ObservableCollection<T> source1;
          int index1;
          bool flag1;
          bool flag2;
          ConcurrentBag<T> source2;
          T[] objArray;
          List<T> source3;
          int index2;
          bool flag3;
          bool flag4;
          int index3;
          bool flag5;
          bool flag6;
          bool flag7;
          switch ((num3 = (uint) (num1 ^ num2)) % 50U)
          {
            case 0:
              int num4 = source2 == null ? -1052248335 : (num4 = -1514180792);
              int num5 = (int) num3 * -179376849;
              num1 = num4 ^ num5;
              continue;
            case 1:
              index1 = 0;
              num1 = (int) num3 * -873750417 ^ -90479872;
              continue;
            case 2:
              source2 = this.source as ConcurrentBag<T>;
              num1 = (int) num3 * 723517811 ^ 1517555797;
              continue;
            case 3:
              int num6 = flag4 ? -734392988 : (num6 = -1706434946);
              int num7 = (int) num3 * 250695309;
              num1 = num6 ^ num7;
              continue;
            case 4:
              num1 = -1651689893;
              continue;
            case 5:
              num1 = (int) num3 * 732460912 ^ -363795541;
              continue;
            case 6:
              num1 = (int) num3 * -271231988 ^ 1791224570;
              continue;
            case 7:
              num1 = (int) num3 * 1609660047 ^ -1742466785;
              continue;
            case 8:
              num1 = -50177021;
              continue;
            case 9:
              num1 = (int) num3 * -263328824 ^ -454716912;
              continue;
            case 10:
              // ISSUE: explicit non-virtual call
              __nonvirtual (((Collection<T>) this).Add(objArray[index3]));
              num1 = (int) num3 * -1108237070 ^ 1159225950;
              continue;
            case 11:
              ++index3;
              num1 = (int) num3 * 1348360607 ^ 1480364511;
              continue;
            case 12:
              // ISSUE: explicit non-virtual call
              __nonvirtual (((Collection<T>) this).Add(((Collection<T>) source1)[index1]));
              num1 = (int) num3 * -1415503537 ^ -1083885159;
              continue;
            case 13:
              // ISSUE: explicit non-virtual call
              flag1 = !__nonvirtual (((Collection<T>) this).Contains(((Collection<T>) source1)[index1]));
              num1 = -429236408;
              continue;
            case 14:
              int num8 = flag6 ? -2094834476 : (num8 = -1797649648);
              int num9 = (int) num3 * -2101653506;
              num1 = num8 ^ num9;
              continue;
            case 15:
              num1 = (int) num3 * -381846225 ^ -147361933;
              continue;
            case 16:
              source2.CopyTo(objArray, 0);
              index3 = 0;
              num1 = (int) num3 * -1180716610 ^ -1944702612;
              continue;
            case 17:
              int num10 = flag3 ? -288422848 : (num10 = -1085918290);
              int num11 = (int) num3 * 908201245;
              num1 = num10 ^ num11;
              continue;
            case 18:
              ++index2;
              num1 = (int) num3 * -562157045 ^ -1352965730;
              continue;
            case 19:
              index2 = 0;
              num1 = (int) num3 * 1601627114 ^ -1456539616;
              continue;
            case 20:
              num1 = -878877749;
              continue;
            case 21:
              flag7 = this.source is List<T>;
              num1 = -8539285;
              continue;
            case 22:
              num1 = (int) num3 * 1470926551 ^ -364394537;
              continue;
            case 23:
              int num12 = source1 != null ? -1643502880 : (num12 = -884588234);
              int num13 = (int) num3 * 1478386430;
              num1 = num12 ^ num13;
              continue;
            case 24:
              goto label_2;
            case 25:
              source3 = this.source as List<T>;
              flag4 = source3 != null;
              num1 = (int) num3 * 336331314 ^ 1495078276;
              continue;
            case 26:
              num1 = (int) num3 * 1880739658 ^ -1053083160;
              continue;
            case 27:
              flag5 = index2 < source3.Count;
              num1 = -1962617598;
              continue;
            case 28:
              num1 = -1833684885;
              continue;
            case 29:
              num1 = -1189952420;
              continue;
            case 30:
              num1 = (int) num3 * -529269462 ^ -1735349549;
              continue;
            case 31:
              flag2 = index3 < objArray.Length;
              num1 = -920364731;
              continue;
            case 32:
              int num14 = !flag2 ? 1795258714 : (num14 = 455903997);
              int num15 = (int) num3 * -1493359960;
              num1 = num14 ^ num15;
              continue;
            case 33:
              // ISSUE: explicit non-virtual call
              flag3 = !__nonvirtual (((Collection<T>) this).Contains(source3[index2]));
              num1 = (int) num3 * -259453817 ^ 823389835;
              continue;
            case 34:
              flag6 = index1 < ((Collection<T>) source1).Count;
              num1 = -1994614695;
              continue;
            case 35:
              ++index1;
              num1 = (int) num3 * -1370689714 ^ 1255159091;
              continue;
            case 36:
              int num16 = flag7 ? 1855569919 : (num16 = 2030416240);
              int num17 = (int) num3 * 266177854;
              num1 = num16 ^ num17;
              continue;
            case 37:
              int num18;
              num1 = num18 = !(this.source is ConcurrentBag<T>) ? -1833684885 : (num18 = -172549120);
              continue;
            case 38:
              num1 = (int) num3 * -609446607 ^ -958806797;
              continue;
            case 39:
              num1 = (int) num3 * -126373574 ^ -5964679;
              continue;
            case 40:
              source1 = this.source as ObservableCollection<T>;
              num1 = (int) num3 * -226339738 ^ 1891669290;
              continue;
            case 41:
              int num19 = !flag1 ? -1579862212 : (num19 = -1454354058);
              int num20 = (int) num3 * 298617273;
              num1 = num19 ^ num20;
              continue;
            case 42:
              goto label_62;
            case 43:
              objArray = new T[source2.get_Count()];
              num1 = (int) num3 * 70346356 ^ -1376757919;
              continue;
            case 44:
              num1 = -1200635122;
              continue;
            case 45:
              // ISSUE: explicit non-virtual call
              __nonvirtual (((Collection<T>) this).Add(source3[index2]));
              num1 = (int) num3 * 1808068120 ^ 930739435;
              continue;
            case 46:
              num1 = (int) num3 * -727290017 ^ 2126467188;
              continue;
            case 47:
              num1 = (int) num3 * 1936421845 ^ 469809040;
              continue;
            case 48:
              num1 = -1833684885;
              continue;
            case 49:
              int num21 = !flag5 ? 1600378030 : (num21 = 569684473);
              int num22 = (int) num3 * 1298187121;
              num1 = num21 ^ num22;
              continue;
            default:
              goto label_57;
          }
        }
label_57:
        return;
label_62:;
      }
      catch (Exception ex)
      {
label_55:
        int num1 = -1208134174;
        while (true)
        {
          int num2 = -504877753;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -844616448 ^ 959016901;
              continue;
            case 1:
              goto label_53;
            case 2:
              num1 = (int) num3 * -444725465 ^ 1520519170;
              continue;
            case 3:
              LockedObservableCollection<T>.\u206E​⁫⁯‎⁮⁭‏⁭⁮‫‎⁮‍⁬‪‌⁮⁯‌‪⁭‪⁭‌‭‏⁯‍‬‪‪‭⁬‫‮‭‮‌⁪‮(LockedObservableCollection<T>.log, (object) ex);
              num1 = (int) num3 * 876128230 ^ 1780535943;
              continue;
            case 4:
              goto label_55;
            case 5:
              num1 = (int) num3 * -533542493 ^ 1805944327;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_53:;
      }
    }

    private void AttachEventHandler()
    {
label_1:
      int num1 = -1393122263;
      while (true)
      {
        int num2 = -1747346656;
        uint num3;
        ObservableCollection<T> source;
        bool flag1;
        bool flag2;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            flag2 = this.Source is IObjectChanged;
            num1 = (int) num3 * 128913251 ^ -1716138196;
            continue;
          case 1:
            // ISSUE: method pointer
            source.add_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(Source_CollectionChanged)));
            num1 = (int) num3 * 1529871180 ^ 1857860441;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -2144276224 ^ 2102742254;
            continue;
          case 4:
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.SourceObjectsChanged), (ThreadOption) 1, false, new Predicate<ObjectChangedEventPayload>(this.FilterObjectsChangedEvent));
            num1 = (int) num3 * 1711297537 ^ -1382602777;
            continue;
          case 5:
            num1 = -661763057;
            continue;
          case 6:
            flag1 = source != null;
            num1 = (int) num3 * 1451486249 ^ 1227738140;
            continue;
          case 7:
            num4 = this.SubscribeToChanges ? 1 : 0;
            break;
          case 8:
            source = this.Source as ObservableCollection<T>;
            num1 = -859167626;
            continue;
          case 9:
            if (this.Source != null)
            {
              num1 = (int) num3 * 2066763060 ^ -1973321869;
              continue;
            }
            num4 = 0;
            break;
          case 10:
            int num5 = flag1 ? -866627413 : (num5 = -564690225);
            int num6 = (int) num3 * 253250321;
            num1 = num5 ^ num6;
            continue;
          case 11:
            num1 = (int) num3 * -327010515 ^ 2101115099;
            continue;
          case 12:
            int num7 = !flag2 ? 863194820 : (num7 = 825999575);
            int num8 = (int) num3 * 1806386325;
            num1 = num7 ^ num8;
            continue;
          case 13:
            goto label_3;
          case 14:
            num1 = (int) num3 * -134596188 ^ 339738103;
            continue;
          case 15:
            num1 = -1169915539;
            continue;
          default:
            goto label_21;
        }
        int num9;
        num1 = num9 = num4 != 0 ? -82696224 : (num9 = -1169915539);
      }
label_21:
      return;
label_3:;
    }

    private void SourceObjectsChanged(ObjectChangedEventPayload obj)
    {
    }

    private bool FilterObjectsChangedEvent(ObjectChangedEventPayload obj)
    {
      if (obj.ChangeType == ChangeType.Added)
        goto label_9;
label_1:
      int num1 = -839538107;
label_2:
      bool flag1;
      while (true)
      {
        int num2 = -137313075;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            num1 = (int) num3 * -1610668292 ^ -310612254;
            continue;
          case 1:
            flag1 = true;
            num1 = (int) num3 * 808984844 ^ 430899341;
            continue;
          case 2:
            // ISSUE: type reference
            flag2 = LockedObservableCollection<T>.\u202E⁫⁫⁪‎‎​⁬⁭⁫​‪‬⁫‭⁭​⁫⁭‫‍⁯​‎​‬⁪‬‫‮⁬‏⁯‭⁯⁯‪⁬⁭‌‮(obj.ObjectType, LockedObservableCollection<T>.\u206C‪‍​‫⁭⁮⁬‪‭‏⁪⁮⁫‭‏‏‮‮​‌‮⁭​⁪⁯⁬‏​⁯‏⁬‭‎‏‍‮‬‬‏‮(__typeref (T)));
            num1 = (int) num3 * -1111589030 ^ -1439170957;
            continue;
          case 3:
            flag1 = false;
            num1 = -2089449134;
            continue;
          case 4:
            int num4 = flag2 ? 148079115 : (num4 = 566857748);
            int num5 = (int) num3 * 14098526;
            num1 = num4 ^ num5;
            continue;
          case 5:
            num1 = -1264353362;
            continue;
          case 6:
            goto label_8;
          case 7:
            num1 = (int) num3 * -2104365003 ^ 613287922;
            continue;
          case 9:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_8:
      int num6 = obj.ChangeType == ChangeType.Removed ? 1 : 0;
      goto label_10;
label_13:
      return flag1;
label_9:
      num6 = 1;
label_10:
      num1 = num6 != 0 ? -683525337 : (num1 = -1264353362);
      goto label_2;
    }

    private void DetachEventHandler()
    {
label_1:
      int num1 = 2079478401;
      while (true)
      {
        int num2 = 1632392265;
        uint num3;
        ObservableCollection<T> source;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * -55117400 ^ -1312237087;
            continue;
          case 1:
            // ISSUE: method pointer
            source.remove_CollectionChanged(new NotifyCollectionChangedEventHandler((object) this, __methodptr(Source_CollectionChanged)));
            num1 = (int) num3 * -1979176519 ^ -677274408;
            continue;
          case 2:
            source = this.Source as ObservableCollection<T>;
            num1 = (int) num3 * -11048296 ^ 1554169362;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = 34837298;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * -1358877327 ^ -701497442;
            continue;
          case 7:
            num4 = this.SubscribeToChanges ? 1 : 0;
            break;
          case 8:
            if (this.Source == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1446732678 ^ -468856890;
            continue;
          case 9:
            int num5 = flag ? -1149377381 : (num5 = -1993809622);
            int num6 = (int) num3 * 2025011384;
            num1 = num5 ^ num6;
            continue;
          case 10:
            num1 = (int) num3 * -502858751 ^ -841764627;
            continue;
          case 11:
            int num7 = source != null ? -639070538 : (num7 = -586079224);
            int num8 = (int) num3 * 461637019;
            num1 = num7 ^ num8;
            continue;
          default:
            goto label_17;
        }
        flag = num4 != 0;
        num1 = 625408508;
      }
label_17:
      return;
label_3:;
    }

    private void PopulateCollection(object newSource)
    {
label_1:
      int num1 = 1718497559;
      Collection<T> source1;
      object collectionLock1;
      while (true)
      {
        int num2 = 2073607718;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            int num4 = !flag2 ? 1967300250 : (num4 = 1612095525);
            int num5 = (int) num3 * -883392300;
            num1 = num4 ^ num5;
            continue;
          case 2:
            collectionLock1 = LockedObservableCollection<T>.collectionLock;
            num1 = (int) num3 * 1681171308 ^ -223699079;
            continue;
          case 3:
            num1 = (int) num3 * -423913660 ^ 1227892845;
            continue;
          case 4:
            goto label_69;
          case 5:
            flag1 = this.Source is Collection<T>;
            num1 = 70876250;
            continue;
          case 6:
            goto label_1;
          case 7:
            if (flag1)
            {
              num1 = (int) num3 * 2007712947 ^ -1397592821;
              continue;
            }
            goto label_47;
          case 8:
            source1 = this.Source as Collection<T>;
            num1 = (int) num3 * -1051020351 ^ -2048633157;
            continue;
          case 9:
            LockedObservableCollection<T>.\u202B‎​‪‏⁫‌‭‪‌⁬‪‍⁯‍‏⁬‭⁮‏‭‪⁯⁬⁯⁭‬​‫‫⁮‫⁮‍‪‮‌‎⁪‮(LockedObservableCollection<T>.\u202C⁭‍‫⁮‪⁫⁯​​‬⁬⁮‫‌⁭‮‏‏⁬⁪‬​‭‮​‮⁫​‫⁫⁬⁪⁬‌‫‎‭​⁪‮((DispatcherObject) LockedObservableCollection<T>.\u206E​⁫‬‫⁯‪‏​⁯‍‍‭⁬‍⁪‎‬‭‏‬‏​‎‏⁮‫‮‭‭⁭⁮‪‌⁭⁭‪‏‮‮‮()), (Delegate) new LockedObservableCollection<T>.PopulateCollectionCallback(this.PopulateCollection), new object[1]
            {
              newSource
            });
            num1 = (int) num3 * -1652778732 ^ -2036952368;
            continue;
          case 10:
            flag2 = !LockedObservableCollection<T>.\u202C⁭‏‎‍‫⁭⁬⁫‪⁮‭‪⁭⁮‍‏⁬⁯‫‫‫​⁬‎‎⁪⁮​‫‮‏​⁪​‪‫⁮⁮⁪‮(LockedObservableCollection<T>.\u202C⁭‍‫⁮‪⁫⁯​​‬⁬⁮‫‌⁭‮‏‏⁬⁪‬​‭‮​‮⁫​‫⁫⁬⁪⁬‌‫‎‭​⁪‮((DispatcherObject) LockedObservableCollection<T>.\u206E​⁫‬‫⁯‪‏​⁯‍‍‭⁬‍⁪‎‬‭‏‬‏​‎‏⁮‫‮‭‭⁭⁮‪‌⁭⁭‪‏‮‮‮()));
            num1 = (int) num3 * 645175559 ^ 908885674;
            continue;
          default:
            goto label_12;
        }
      }
label_69:
      return;
label_12:
      bool flag3 = false;
      try
      {
        LockedObservableCollection<T>.\u206F‍⁭​⁪‮‎‌‫⁪‍⁪‫‪‏‬‎‫‏‮⁫⁪​​⁬⁯⁯⁮‍‎‭⁪‭​‮‌‎‍⁭⁬‮(collectionLock1, ref flag3);
label_14:
        int num2 = 415373269;
        while (true)
        {
          int num3 = 2073607718;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_14;
            case 2:
              num2 = (int) num4 * 319450797 ^ -869159227;
              continue;
            case 3:
              // ISSUE: explicit non-virtual call
              __nonvirtual (((Collection<T>) this).Clear());
              num2 = (int) num4 * -378630637 ^ -15225007;
              continue;
            default:
              goto label_18;
          }
        }
label_18:
        IEnumerator<T> enumerator = source1.GetEnumerator();
        try
        {
label_28:
          int num3 = LockedObservableCollection<T>.\u206B‪⁯‎‪‎‮⁭​⁬‍⁭‏​‎​‭‌‌‭‎⁬‍‍‎‎⁪‏⁯‎‫⁮⁫​‮‬⁭⁭‫‏‮((IEnumerator) enumerator) ? 1209197478 : (num3 = 978116122);
          while (true)
          {
            int num4 = 2073607718;
            uint num5;
            T current;
            switch ((num5 = (uint) (num3 ^ num4)) % 9U)
            {
              case 0:
                // ISSUE: explicit non-virtual call
                int num6 = !__nonvirtual (((Collection<T>) this).Contains(current)) ? 906796334 : (num6 = 972087702);
                int num7 = (int) num5 * 205238861;
                num3 = num6 ^ num7;
                continue;
              case 1:
                num3 = 138169217;
                continue;
              case 2:
                num3 = 1209197478;
                continue;
              case 3:
                num3 = (int) num5 * -1523561236 ^ 1222709585;
                continue;
              case 5:
                current = enumerator.Current;
                num3 = 57508539;
                continue;
              case 6:
                // ISSUE: explicit non-virtual call
                __nonvirtual (((Collection<T>) this).Add(current));
                num3 = (int) num5 * -643893785 ^ 979998810;
                continue;
              case 7:
                goto label_28;
              case 8:
                num3 = (int) num5 * -1858949897 ^ -1148428614;
                continue;
              default:
                goto label_40;
            }
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_30:
            int num3 = 384726271;
            while (true)
            {
              int num4 = 2073607718;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 0:
                  goto label_30;
                case 1:
                  LockedObservableCollection<T>.\u202B‪‮‬‎​⁫⁪⁭‭‫⁪‪‏‫‌‫‍⁮‎‭‎‌‬​‬‍⁯‏‌‌‍⁮‌⁫‏‮⁫‍‮‮((IDisposable) enumerator);
                  num3 = (int) num5 * 2069625595 ^ -560062702;
                  continue;
                case 3:
                  num3 = (int) num5 * -158353719 ^ -1874788141;
                  continue;
                default:
                  goto label_34;
              }
            }
          }
label_34:;
        }
      }
      finally
      {
        if (flag3)
        {
label_36:
          int num2 = 21768494;
          while (true)
          {
            int num3 = 2073607718;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                LockedObservableCollection<T>.\u206D‬‏‫‍‭‮​⁬‌‎‪‍‮⁬⁭‮‭‭‎‫⁯‪⁫⁪‭⁬⁪⁯⁮‍‎‍‎⁭‏⁭​‎⁫‮(collectionLock1);
                num2 = (int) num4 * 2106325474 ^ 2008917474;
                continue;
              case 2:
                goto label_36;
              default:
                goto label_39;
            }
          }
        }
label_39:;
      }
label_40:
label_41:
      int num8 = 1544486081;
label_42:
      object collectionLock2;
      List<T> source2;
      bool flag4;
      while (true)
      {
        int num2 = 2073607718;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 7U)
        {
          case 0:
            collectionLock2 = LockedObservableCollection<T>.collectionLock;
            num8 = (int) num3 * 454443171 ^ 906122315;
            continue;
          case 1:
            goto label_65;
          case 2:
            source2 = this.Source as List<T>;
            num8 = (int) num3 * 1804665362 ^ 1647885425;
            continue;
          case 3:
            goto label_41;
          case 5:
            goto label_47;
          case 6:
            if (flag4)
            {
              num8 = (int) num3 * 6565583 ^ 1374464508;
              continue;
            }
            goto label_79;
          default:
            goto label_48;
        }
      }
label_65:
      return;
label_48:
      bool flag5 = false;
      try
      {
        LockedObservableCollection<T>.\u206F‍⁭​⁪‮‎‌‫⁪‍⁪‫‪‏‬‎‫‏‮⁫⁪​​⁬⁯⁯⁮‍‎‭⁪‭​‮‌‎‍⁭⁬‮(collectionLock2, ref flag5);
label_50:
        int num2 = 653773656;
        while (true)
        {
          int num3 = 2073607718;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_50;
            case 1:
              num2 = (int) num4 * 1901987517 ^ -1717427656;
              continue;
            case 2:
              num2 = (int) num4 * -940262674 ^ -441936533;
              continue;
            default:
              goto label_54;
          }
        }
label_54:
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Collection<T>) this).Clear());
        using (List<T>.Enumerator enumerator = source2.GetEnumerator())
        {
label_59:
          int num3 = enumerator.MoveNext() ? 1283644550 : (num3 = 628733670);
          while (true)
          {
            int num4 = 2073607718;
            uint num5;
            T current;
            switch ((num5 = (uint) (num3 ^ num4)) % 7U)
            {
              case 0:
                num3 = 1283644550;
                continue;
              case 1:
                current = enumerator.Current;
                num3 = 985754464;
                continue;
              case 2:
                // ISSUE: explicit non-virtual call
                __nonvirtual (((Collection<T>) this).Add(current));
                num3 = (int) num5 * -1319591446 ^ 681950944;
                continue;
              case 3:
                // ISSUE: explicit non-virtual call
                int num6 = !__nonvirtual (((Collection<T>) this).Contains(current)) ? 1835293475 : (num6 = 979024356);
                int num7 = (int) num5 * 1333090171;
                num3 = num6 ^ num7;
                continue;
              case 4:
                goto label_59;
              case 6:
                num3 = 1679973635;
                continue;
              default:
                goto label_73;
            }
          }
        }
      }
      finally
      {
        if (flag5)
        {
label_67:
          int num2 = 1271935281;
          while (true)
          {
            int num3 = 2073607718;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_67;
              case 1:
                num2 = (int) num4 * -501498102 ^ -1302288686;
                continue;
              case 3:
                LockedObservableCollection<T>.\u206D‬‏‫‍‭‮​⁬‌‎‪‍‮⁬⁭‮‭‭‎‫⁯‪⁫⁪‭⁬⁪⁯⁮‍‎‍‎⁭‏⁭​‎⁫‮(collectionLock2);
                num2 = (int) num4 * 904396060 ^ -787178333;
                continue;
              default:
                goto label_72;
            }
          }
        }
label_72:;
      }
label_73:
label_74:
      int num9 = 539864811;
label_75:
      while (true)
      {
        int num2 = 2073607718;
        uint num3;
        switch ((num3 = (uint) (num9 ^ num2)) % 7U)
        {
          case 0:
            goto label_79;
          case 1:
            num9 = (int) num3 * -1064999610 ^ -513026145;
            continue;
          case 2:
            goto label_74;
          case 3:
            goto label_80;
          case 4:
            num9 = (int) num3 * -1494544745 ^ 457344445;
            continue;
          case 5:
            LockedObservableCollection<T>.\u206E​⁫⁯‎⁮⁭‏⁭⁮‫‎⁮‍⁬‪‌⁮⁯‌‪⁭‪⁭‌‭‏⁯‍‬‪‪‭⁬‫‮‭‮‌⁪‮(LockedObservableCollection<T>.log, (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3755009746U));
            num9 = (int) num3 * 1904270593 ^ 1513920547;
            continue;
          case 6:
            goto label_76;
          default:
            goto label_63;
        }
      }
label_63:
      return;
label_76:
      return;
label_80:
      throw LockedObservableCollection<T>.\u200E‭⁮‌‮⁮⁬‏‏⁬‫⁭‏‭⁪‍‫⁮⁪⁭‌⁭‭‪‭‪⁪⁬‮⁭⁪‪‍‬‎‍‍‎‍⁬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3359298547U));
label_79:
      int num10;
      num9 = num10 = this.source == null ? 483372689 : (num10 = 1632932527);
      goto label_75;
label_47:
      flag4 = this.Source is List<T>;
      num8 = 1307718856;
      goto label_42;
    }

    private void Source_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
label_1:
      int num1 = 494967886;
      object collectionLock;
      while (true)
      {
        int num2 = 18481074;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            collectionLock = LockedObservableCollection<T>.collectionLock;
            num1 = (int) num3 * -184695259 ^ -522986399;
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
        LockedObservableCollection<T>.\u206F‍⁭​⁪‮‎‌‫⁪‍⁪‫‪‏‬‎‫‏‮⁫⁪​​⁬⁯⁯⁮‍‎‭⁪‭​‮‌‎‍⁭⁬‮(collectionLock, ref flag);
label_6:
        int num2 = 1268353305;
        while (true)
        {
          int num3 = 18481074;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_6;
            case 1:
              num2 = (int) num4 * 924795759 ^ 1892709482;
              continue;
            case 3:
              num2 = (int) num4 * 52684102 ^ -675437082;
              continue;
            case 4:
              if (LockedObservableCollection<T>.\u200E⁭​‬⁮‪⁭‭⁪‏‎‪⁫⁪‎⁫‎‎​⁯‮⁫⁭‪⁮‏⁬‎‬⁮‪‭‭‫⁫‌⁭⁭⁭‮‮(e) != null)
              {
                num2 = (int) num4 * 243387997 ^ -788764452;
                continue;
              }
              goto label_29;
            default:
              goto label_12;
          }
        }
label_12:
        IEnumerator enumerator1 = LockedObservableCollection<T>.\u202C⁯​‭‪‍‌‏‭⁯⁭‪⁪‬‭⁯‫⁪‎​‎⁯​‮‌⁯⁫‮⁪‬⁮⁯‏‬‫⁬‎⁬‫‫‮((IEnumerable) LockedObservableCollection<T>.\u200E⁭​‬⁮‪⁭‭⁪‏‎‪⁫⁪‎⁫‎‎​⁯‮⁫⁭‪⁮‏⁬‎‬⁮‪‭‭‫⁫‌⁭⁭⁭‮‮(e));
        try
        {
label_17:
          int num3 = !LockedObservableCollection<T>.\u206B‪⁯‎‪‎‮⁭​⁬‍⁭‏​‎​‭‌‌‭‎⁬‍‍‎‎⁪‏⁯‎‫⁮⁫​‮‬⁭⁭‫‏‮(enumerator1) ? 1735242656 : (num3 = 473777604);
          while (true)
          {
            int num4 = 18481074;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 5U)
            {
              case 0:
                goto label_17;
              case 1:
                num3 = (int) num5 * 282516129 ^ -215280866;
                continue;
              case 3:
                num3 = 473777604;
                continue;
              case 4:
                LockedObservableCollection<T>.\u206E⁬‬⁯‮‍⁮‭‎‏‬‫‌⁬‍​​‬⁯‌‮‪⁭‬‬‪‮‍⁬‬‭⁯‪‪‭‎⁯‎‭⁬‮(new WaitCallback(this.HandleCollectionChanged), (object) (T) LockedObservableCollection<T>.\u200E⁪⁮⁫‍​‏‬‬‏‬⁬⁮‎⁯‎​⁫‪⁬⁮⁪‍‍‬‎⁫⁮⁮‍‬‭⁮‎‪⁫⁮‌‫‏‮(enumerator1));
                num3 = 574537663;
                continue;
              default:
                goto label_26;
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator1 as IDisposable;
label_20:
          int num3 = 612561454;
          while (true)
          {
            int num4 = 18481074;
            uint num5;
            switch ((num5 = (uint) (num3 ^ num4)) % 5U)
            {
              case 0:
                goto label_20;
              case 1:
                int num6 = disposable == null ? -799327713 : (num6 = -597851736);
                int num7 = (int) num5 * 188687488;
                num3 = num6 ^ num7;
                continue;
              case 3:
                num3 = (int) num5 * 220740350 ^ -1301608731;
                continue;
              case 4:
                LockedObservableCollection<T>.\u202B‪‮‬‎​⁫⁪⁭‭‫⁪‪‏‫‌‫‍⁮‎‭‎‌‬​‬‍⁯‏‌‌‍⁮‌⁫‏‮⁫‍‮‮(disposable);
                num3 = (int) num5 * 271434259 ^ -1656054433;
                continue;
              default:
                goto label_25;
            }
          }
label_25:;
        }
label_26:
label_27:
        int num8 = 84263375;
label_28:
        while (true)
        {
          int num3 = 18481074;
          uint num4;
          switch ((num4 = (uint) (num8 ^ num3)) % 4U)
          {
            case 0:
              goto label_27;
            case 1:
              goto label_29;
            case 3:
              num8 = (int) num4 * 1558975727 ^ -837100019;
              continue;
            default:
              goto label_32;
          }
        }
label_32:
        IEnumerator enumerator2 = LockedObservableCollection<T>.\u202C⁯​‭‪‍‌‏‭⁯⁭‪⁪‬‭⁯‫⁪‎​‎⁯​‮‌⁯⁫‮⁪‬⁮⁯‏‬‫⁬‎⁬‫‫‮((IEnumerable) LockedObservableCollection<T>.\u200C‬‎⁪⁯‮⁮‫‍⁪‭‫⁫⁮‌‍⁫⁪‫⁭‬‬‫‎‏⁬‎⁭‬‮‍‎‎⁬‬⁭‬‌‮‬‮(e));
        try
        {
label_36:
          int num3 = !LockedObservableCollection<T>.\u206B‪⁯‎‪‎‮⁭​⁬‍⁭‏​‎​‭‌‌‭‎⁬‍‍‎‎⁪‏⁯‎‫⁮⁫​‮‬⁭⁭‫‏‮(enumerator2) ? 2141421155 : (num3 = 717107143);
          while (true)
          {
            int num4 = 18481074;
            uint num5;
            T obj;
            switch ((num5 = (uint) (num3 ^ num4)) % 6U)
            {
              case 0:
                goto label_36;
              case 1:
                obj = (T) LockedObservableCollection<T>.\u200E⁪⁮⁫‍​‏‬‬‏‬⁬⁮‎⁯‎​⁫‪⁬⁮⁪‍‍‬‎⁫⁮⁮‍‬‭⁮‎‪⁫⁮‌‫‏‮(enumerator2);
                num3 = 1522084629;
                continue;
              case 2:
                num3 = 717107143;
                continue;
              case 3:
                num3 = (int) num5 * -1668112575 ^ 1381268815;
                continue;
              case 4:
                LockedObservableCollection<T>.\u206E⁬‬⁯‮‍⁮‭‎‏‬‫‌⁬‍​​‬⁯‌‮‪⁭‬‬‪‮‍⁬‬‭⁯‪‪‭‎⁯‎‭⁬‮(new WaitCallback(this.HandleCollectionChanged), (object) obj);
                num3 = (int) num5 * 1855511086 ^ -1061482958;
                continue;
              default:
                goto label_46;
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator2 as IDisposable;
          if (disposable != null)
          {
label_41:
            int num3 = 940168907;
            while (true)
            {
              int num4 = 18481074;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 1:
                  LockedObservableCollection<T>.\u202B‪‮‬‎​⁫⁪⁭‭‫⁪‪‏‫‌‫‍⁮‎‭‎‌‬​‬‍⁯‏‌‌‍⁮‌⁫‏‮⁫‍‮‮(disposable);
                  num3 = (int) num5 * -1369745982 ^ -1712399134;
                  continue;
                case 2:
                  num3 = (int) num5 * -1117945448 ^ 1431667638;
                  continue;
                case 3:
                  goto label_41;
                default:
                  goto label_45;
              }
            }
          }
label_45:;
        }
label_46:
        return;
label_29:
        if (LockedObservableCollection<T>.\u200C‬‎⁪⁯‮⁮‫‍⁪‭‫⁫⁮‌‍⁫⁪‫⁭‬‬‫‎‏⁬‎⁭‬‮‍‎‎⁬‬⁭‬‌‮‬‮(e) == null)
          return;
        num8 = 1038981337;
        goto label_28;
      }
      finally
      {
        if (flag)
        {
label_48:
          int num2 = 2109774737;
          while (true)
          {
            int num3 = 18481074;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_48;
              case 2:
                LockedObservableCollection<T>.\u206D‬‏‫‍‭‮​⁬‌‎‪‍‮⁬⁭‮‭‭‎‫⁯‪⁫⁪‭⁬⁪⁯⁮‍‎‍‎⁭‏⁭​‎⁫‮(collectionLock);
                num2 = (int) num4 * -570358786 ^ 1314829275;
                continue;
              default:
                goto label_52;
            }
          }
        }
label_52:;
      }
    }

    private void HandleCollectionChanged(object eventArgs)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      LockedObservableCollection<T>.\u003C\u003Ec__DisplayClass23_0 cDisplayClass230 = new LockedObservableCollection<T>.\u003C\u003Ec__DisplayClass23_0();
label_1:
      int num1 = 2051804915;
      while (true)
      {
        int num2 = 1835210724;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass230.eventArgs = eventArgs;
            num1 = (int) num3 * 977011289 ^ 200992494;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass230.\u003C\u003E4__this = this;
            num1 = (int) num3 * -819663972 ^ 1731571278;
            continue;
          case 2:
            // ISSUE: method pointer
            LockedObservableCollection<T>.\u202E‫‬‏‪‪⁭⁮‬‭⁪⁮⁯⁫‬‌‌⁬⁫‬‏⁯⁪‪⁫⁮⁭‏⁬⁮⁫⁮​⁭‎⁭‌⁭‏‪‮(LockedObservableCollection<T>.\u202C⁭‍‫⁮‪⁫⁯​​‬⁬⁮‫‌⁭‮‏‏⁬⁪‬​‭‮​‮⁫​‫⁫⁬⁪⁬‌‫‎‭​⁪‮((DispatcherObject) LockedObservableCollection<T>.\u206E​⁫‬‫⁯‪‏​⁯‍‍‭⁬‍⁪‎‬‭‏‬‏​‎‏⁮‫‮‭‭⁭⁮‪‌⁭⁭‪‏‮‮‮()), new Action((object) cDisplayClass230, __methodptr(\u003CHandleCollectionChanged\u003Eb__0)));
            num1 = (int) num3 * 483430212 ^ -1238795901;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -881264443 ^ 1396632082;
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

    static PropertyChangedEventArgs \u200F‎‌‮‫⁯​⁫⁯‪⁯⁪‫‬⁪‎‌‌⁮‬‬⁮⁯‫‬‍⁮‍​‭⁬‍‍⁮⁪‌‭‪‌‏‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }

    static void \u202C‫⁭⁯‫‏⁯‌‭‪‫‎​⁪⁭‌‌⁬‏‭​‪‪‌⁪⁬‬⁮‪‪‍⁮‏‌‪‬⁯‍‬‏‮([In] IEnumerable obj0, [In] object obj1)
    {
      BindingOperations.EnableCollectionSynchronization(obj0, obj1);
    }

    static void \u206F‍⁭​⁪‮‎‌‫⁪‍⁪‫‪‏‬‎‫‏‮⁫⁪​​⁬⁯⁯⁮‍‎‭⁪‭​‮‌‎‍⁭⁬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u206D‬‏‫‍‭‮​⁬‌‎‪‍‮⁬⁭‮‭‭‎‫⁯‪⁫⁪‭⁬⁪⁯⁮‍‎‍‎⁭‏⁭​‎⁫‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static bool \u206E⁬‬⁯‮‍⁮‭‎‏‬‫‌⁬‍​​‬⁯‌‮‪⁭‬‬‪‮‍⁬‬‭⁯‪‪‭‎⁯‎‭⁬‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static void \u206E​⁫⁯‎⁮⁭‏⁭⁮‫‎⁮‍⁬‪‌⁮⁯‌‪⁭‪⁭‌‭‏⁯‍‬‪‪‭⁬‫‮‭‮‌⁪‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static Type \u206C‪‍​‫⁭⁮⁬‪‭‏⁪⁮⁫‭‏‏‮‮​‌‮⁭​⁪⁯⁬‏​⁯‏⁬‭‎‏‍‮‬‬‏‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static bool \u202E⁫⁫⁪‎‎​⁬⁭⁫​‪‬⁫‭⁭​⁫⁭‫‍⁯​‎​‬⁪‬‫‮⁬‏⁯‭⁯⁯‪⁬⁭‌‮([In] Type obj0, [In] Type obj1)
    {
      return Type.op_Equality(obj0, obj1);
    }

    static Application \u206E​⁫‬‫⁯‪‏​⁯‍‍‭⁬‍⁪‎‬‭‏‬‏​‎‏⁮‫‮‭‭⁭⁮‪‌⁭⁭‪‏‮‮‮()
    {
      return Application.Current;
    }

    static Dispatcher \u202C⁭‍‫⁮‪⁫⁯​​‬⁬⁮‫‌⁭‮‏‏⁬⁪‬​‭‮​‮⁫​‫⁫⁬⁪⁬‌‫‎‭​⁪‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static bool \u202C⁭‏‎‍‫⁭⁬⁫‪⁮‭‪⁭⁮‍‏⁬⁯‫‫‫​⁬‎‎⁪⁮​‫‮‏​⁪​‪‫⁮⁮⁪‮([In] Dispatcher obj0)
    {
      return obj0.CheckAccess();
    }

    static object \u202B‎​‪‏⁫‌‭‪‌⁬‪‍⁯‍‏⁬‭⁮‏‭‪⁯⁬⁯⁭‬​‫‫⁮‫⁮‍‪‮‌‎⁪‮([In] Dispatcher obj0, [In] Delegate obj1, [In] object[] obj2)
    {
      return obj0.Invoke(obj1, obj2);
    }

    static bool \u206B‪⁯‎‪‎‮⁭​⁬‍⁭‏​‎​‭‌‌‭‎⁬‍‍‎‎⁪‏⁯‎‫⁮⁫​‮‬⁭⁭‫‏‮([In] IEnumerator obj0)
    {
      return obj0.MoveNext();
    }

    static void \u202B‪‮‬‎​⁫⁪⁭‭‫⁪‪‏‫‌‫‍⁮‎‭‎‌‬​‬‍⁯‏‌‌‍⁮‌⁫‏‮⁫‍‮‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static Exception \u200E‭⁮‌‮⁮⁬‏‏⁬‫⁭‏‭⁪‍‫⁮⁪⁭‌⁭‭‪‭‪⁪⁬‮⁭⁪‪‍‬‎‍‍‎‍⁬‮([In] string obj0)
    {
      return new Exception(obj0);
    }

    static IList \u200E⁭​‬⁮‪⁭‭⁪‏‎‪⁫⁪‎⁫‎‎​⁯‮⁫⁭‪⁮‏⁬‎‬⁮‪‭‭‫⁫‌⁭⁭⁭‮‮([In] NotifyCollectionChangedEventArgs obj0)
    {
      return obj0.get_NewItems();
    }

    static IEnumerator \u202C⁯​‭‪‍‌‏‭⁯⁭‪⁪‬‭⁯‫⁪‎​‎⁯​‮‌⁯⁫‮⁪‬⁮⁯‏‬‫⁬‎⁬‫‫‮([In] IEnumerable obj0)
    {
      return obj0.GetEnumerator();
    }

    static object \u200E⁪⁮⁫‍​‏‬‬‏‬⁬⁮‎⁯‎​⁫‪⁬⁮⁪‍‍‬‎⁫⁮⁮‍‬‭⁮‎‪⁫⁮‌‫‏‮([In] IEnumerator obj0)
    {
      return obj0.Current;
    }

    static IList \u200C‬‎⁪⁯‮⁮‫‍⁪‭‫⁫⁮‌‍⁫⁪‫⁭‬‬‫‎‏⁬‎⁭‬‮‍‎‎⁬‬⁭‬‌‮‬‮([In] NotifyCollectionChangedEventArgs obj0)
    {
      return obj0.get_OldItems();
    }

    static void \u202E‫‬‏‪‪⁭⁮‬‭⁪⁮⁯⁫‬‌‌⁬⁫‬‏⁯⁪‪⁫⁮⁭‏⁬⁮⁫⁮​⁭‎⁭‌⁭‏‪‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static object \u202D‌‮⁬‎‮‪⁫‍‏​‫‮‮‮⁮⁮‬⁮‏‮‎‌⁬‮⁮‫‎‮‭⁮‪‏‬⁪​‬‮‍‭‮()
    {
      return new object();
    }

    static MethodBase \u206A⁭‎⁫‭‫⁮‎‪⁭‏⁪‎‌⁪⁫‏‪‍‏⁪‪‌‫⁬⁬‍⁭‪‮‍⁫⁫⁭‎​⁮⁯‍‌‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u202C‫‪‫​⁮‪​⁮⁮‮⁬‏‏⁬‏‏‬⁯‫‌‬‌⁭‪⁪‍‌⁭‪‍‭‭⁫‍‍‎⁬‌‬‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206F‪‎‏‮‮⁭‌⁮‏‫⁫‪‮​⁮⁭‌⁮⁮‌⁮‭⁫⁮‏​‏‬‍⁯⁮‪‏‎⁪⁪‭‬⁭‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }

    private delegate void PopulateCollectionCallback(object newSource);
  }
}
