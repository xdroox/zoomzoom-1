// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.SynchronizedObservableCollection`1
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZoomZoom.Common
{
  [ComVisible(false)]
  [DebuggerDisplay("Count = {Count}")]
  [Serializable]
  public class SynchronizedObservableCollection<T> : IList<T>, ICollection<T>, IDisposable, IEnumerable<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, INotifyPropertyChanged, ICollection, IList, IEnumerable, INotifyCollectionChanged
  {
    private readonly ReaderWriterLockSlim _itemsLock = SynchronizedObservableCollection<T>.\u206F‎‌​‍​‮⁫‫‪‌⁬⁫‬⁬⁬‌⁫⁯‪⁯‌​‬⁬‮⁮⁬‬‫⁫​⁪‍‬⁯‬‏⁮‏‮();
    private readonly object _lock = SynchronizedObservableCollection<T>.\u206E‪⁭​‎‍‮​‫⁮⁪​⁮‮⁯‍⁬‍‎‮‌‍‎‬‍⁬‬⁪‮‏⁪‮‪‎‭⁭‌‍‎‮‮();
    private readonly SynchronizedObservableCollection<T>.SimpleMonitor _monitor = new SynchronizedObservableCollection<T>.SimpleMonitor();
    private readonly SynchronizationContext _context;
    private readonly IList<T> _items;
    [NonSerialized]
    private object _syncRoot;

    bool IList.IsFixedSize
    {
      get
      {
        IList items = this._items as IList;
label_1:
        int num1 = -2146595318;
        bool flag;
        while (true)
        {
          int num2 = -114873475;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 2:
              flag = SynchronizedObservableCollection<T>.\u200F⁫⁭‌⁭‮⁭‬‭‮‬​⁪⁪⁮‍⁭⁭‮⁮‬‭⁮⁭⁮‪⁫⁪‮‬‬⁮‍⁯‬⁭‮‬‏‮‮(items);
              num1 = (int) num3 * 614127489 ^ -2090889706;
              continue;
            case 3:
              int num4 = items != null ? -2091902853 : (num4 = -2064077910);
              int num5 = (int) num3 * 869252898;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * -1114754945 ^ 73545863;
              continue;
            case 5:
              flag = this._items.IsReadOnly;
              num1 = -1299726636;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return flag;
      }
    }

    bool ICollection<T>.IsReadOnly
    {
      get
      {
label_1:
        int num1 = 1785839587;
        bool isReadOnly;
        while (true)
        {
          int num2 = 1510466485;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 1874369481 ^ 219433512;
              continue;
            case 2:
              isReadOnly = this._items.IsReadOnly;
              num1 = (int) num3 * 565244990 ^ 2042284504;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return isReadOnly;
      }
    }

    bool IList.IsReadOnly
    {
      get
      {
label_1:
        int num1 = -412722903;
        bool isReadOnly;
        while (true)
        {
          int num2 = -1015197913;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -1179006829 ^ 910449652;
              continue;
            case 2:
              isReadOnly = this._items.IsReadOnly;
              num1 = (int) num3 * -278546808 ^ -143672554;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return isReadOnly;
      }
    }

    bool ICollection.IsSynchronized
    {
      get
      {
        return true;
      }
    }

    object ICollection.SyncRoot
    {
      get
      {
label_1:
        int num1 = -1177420148;
        while (true)
        {
          int num2 = -788289046;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
              num1 = (int) num3 * 2121393750 ^ 406774355;
              continue;
            case 3:
              if (this._syncRoot == null)
              {
                num1 = (int) num3 * 1491198299 ^ -1103659556;
                continue;
              }
              goto label_29;
            case 4:
              num1 = (int) num3 * 1525483062 ^ -984608621;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        try
        {
label_9:
          int num2 = -1472465893;
          while (true)
          {
            int num3 = -788289046;
            uint num4;
            bool flag;
            ICollection items;
            switch ((num4 = (uint) (num2 ^ num3)) % 11U)
            {
              case 0:
                num2 = -1482310483;
                continue;
              case 1:
                items = this._items as ICollection;
                num2 = (int) num4 * 1229709750 ^ 798227982;
                continue;
              case 2:
                this._syncRoot = SynchronizedObservableCollection<T>.\u202E⁬‏​‍⁭‏⁪‌⁫‏‫‫⁯⁬​⁯‌⁫⁭⁪‪‌⁬⁪⁯‮⁭‌⁯‏​⁬‭⁪‪‍⁭‪‫‮(items);
                num2 = (int) num4 * 1629995828 ^ -426842175;
                continue;
              case 4:
                num2 = (int) num4 * -317204064 ^ -405881447;
                continue;
              case 5:
                int num5 = flag ? -2141605869 : (num5 = -1295222712);
                int num6 = (int) num4 * 1133886084;
                num2 = num5 ^ num6;
                continue;
              case 6:
                flag = items != null;
                num2 = (int) num4 * -1322550259 ^ 744693110;
                continue;
              case 7:
                Interlocked.CompareExchange<object>(ref this._syncRoot, SynchronizedObservableCollection<T>.\u206E‪⁭​‎‍‮​‫⁮⁪​⁮‮⁯‍⁬‍‎‮‌‍‎‬‍⁬‬⁪‮‏⁪‮‪‎‭⁭‌‍‎‮‮(), (object) null);
                num2 = (int) num4 * 1505228648 ^ -1719595837;
                continue;
              case 8:
                goto label_9;
              case 9:
                num2 = (int) num4 * 327873685 ^ -1818300651;
                continue;
              case 10:
                num2 = (int) num4 * 23607950 ^ 939268286;
                continue;
              default:
                goto label_26;
            }
          }
        }
        finally
        {
label_21:
          int num2 = -1977820717;
          while (true)
          {
            int num3 = -788289046;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
                num2 = (int) num4 * 318879694 ^ -1826599269;
                continue;
              case 2:
                goto label_21;
              case 3:
                num2 = (int) num4 * 814873704 ^ 1890325474;
                continue;
              default:
                goto label_25;
            }
          }
label_25:;
        }
label_26:
label_27:
        int num7 = -1525599692;
label_28:
        int num8 = -788289046;
        uint num9;
        object syncRoot;
        switch ((num9 = (uint) (num7 ^ num8)) % 3U)
        {
          case 1:
            break;
          case 2:
            goto label_27;
          default:
            return syncRoot;
        }
label_29:
        syncRoot = this._syncRoot;
        num7 = -805703453;
        goto label_28;
      }
    }

    public int Count
    {
      get
      {
        SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
        int count;
        try
        {
label_2:
          int num1 = -1148924510;
          while (true)
          {
            int num2 = -1184507606;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 2:
                count = this._items.Count;
                num1 = (int) num3 * 1244814551 ^ 133327064;
                continue;
              default:
                goto label_6;
            }
          }
        }
        finally
        {
          SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
        }
label_6:
        return count;
      }
    }

    public T this[int index]
    {
      get
      {
        SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
        try
        {
label_2:
          int num1 = -1068184511;
          while (true)
          {
            int num2 = -1650559612;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                this.CheckIndex(index);
                num1 = (int) num3 * -1510935046 ^ 413264092;
                continue;
              case 2:
                num1 = (int) num3 * -2070640569 ^ -1055921026;
                continue;
              case 3:
                goto label_2;
              default:
                goto label_6;
            }
          }
label_6:
          return this._items[index];
        }
        finally
        {
          SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
        }
      }
      set
      {
        SynchronizedObservableCollection<T>.\u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮(this._itemsLock);
        T obj;
        try
        {
          this.CheckIsReadOnly();
label_2:
          int num1 = -1566235141;
          while (true)
          {
            int num2 = -1584364042;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 7U)
            {
              case 0:
                obj = this[index];
                num1 = (int) num3 * 1238059567 ^ 1577251836;
                continue;
              case 1:
                this.CheckReentrancy();
                num1 = (int) num3 * 1497222686 ^ 2142030939;
                continue;
              case 2:
                goto label_2;
              case 4:
                this._items[index] = value;
                num1 = (int) num3 * 204414365 ^ -1227134925;
                continue;
              case 5:
                this.CheckIndex(index);
                num1 = (int) num3 * 117949221 ^ 1501561370;
                continue;
              case 6:
                num1 = (int) num3 * 1045775518 ^ 596719502;
                continue;
              default:
                goto label_10;
            }
          }
        }
        finally
        {
          SynchronizedObservableCollection<T>.\u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮(this._itemsLock);
        }
label_10:
        this.OnPropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3051756489U));
        this.OnCollectionChanged((NotifyCollectionChangedAction) 2, (object) obj, (object) value, index);
      }
    }

    object IList.this[int index]
    {
      get
      {
label_1:
        int num1 = -369176967;
        object obj;
        while (true)
        {
          int num2 = -1664895858;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1626972824 ^ -1020814097;
              continue;
            case 2:
              goto label_1;
            case 3:
              obj = (object) this[index];
              num1 = (int) num3 * 323055157 ^ -463623899;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return obj;
      }
      set
      {
        try
        {
label_2:
          int num1 = 62918475;
          while (true)
          {
            int num2 = 1635548692;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_2;
              case 1:
                goto label_7;
              case 2:
                num1 = (int) num3 * -1836468912 ^ -1093565947;
                continue;
              case 3:
                this[index] = (T) value;
                num1 = (int) num3 * 270656439 ^ 1465611795;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return;
label_7:;
        }
        catch (InvalidCastException ex)
        {
          throw SynchronizedObservableCollection<T>.\u206F‮‬⁯‫‬‫‬‫‬⁪⁫‫‭‭‮‪‪‎⁮⁬⁮⁫⁯⁬​‬⁬⁭⁮‍‬‌‮‬‌‬⁭‍⁫‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2387047518U));
        }
      }
    }

    event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
    {
      add
      {
        this.PropertyChanged += value;
      }
      remove
      {
label_1:
        int num1 = -1066726851;
        while (true)
        {
          int num2 = -249392367;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.PropertyChanged -= value;
              num1 = (int) num3 * 1842570588 ^ 130312053;
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

    public event NotifyCollectionChangedEventHandler CollectionChanged
    {
      add
      {
        NotifyCollectionChangedEventHandler changedEventHandler = this.CollectionChanged;
label_1:
        int num1 = 1691163386;
        while (true)
        {
          int num2 = 1166400778;
          uint num3;
          NotifyCollectionChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              int num4 = changedEventHandler == comparand ? 756385111 : (num4 = 1960187978);
              int num5 = (int) num3 * 128880292;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              changedEventHandler = Interlocked.CompareExchange<NotifyCollectionChangedEventHandler>(ref this.CollectionChanged, (NotifyCollectionChangedEventHandler) SynchronizedObservableCollection<T>.\u202D⁪‬‫⁮⁬‎⁫​⁬⁫‪‬⁭‌‭‬⁮‭‍‌⁪‏‪‬‪‏⁯​‌⁬‭‪‮​‮⁭⁫‎‎‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -1723988331 ^ -149085714;
              continue;
            case 4:
              comparand = changedEventHandler;
              num1 = 65155714;
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
        NotifyCollectionChangedEventHandler changedEventHandler = this.CollectionChanged;
label_1:
        int num1 = -828825285;
        while (true)
        {
          int num2 = -613893567;
          uint num3;
          NotifyCollectionChangedEventHandler comparand;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              changedEventHandler = Interlocked.CompareExchange<NotifyCollectionChangedEventHandler>(ref this.CollectionChanged, (NotifyCollectionChangedEventHandler) SynchronizedObservableCollection<T>.\u200B‭‌⁪⁫⁭‎‬‬‌‬‫‏‍⁫⁮‮⁯⁬‪⁯⁬⁯‭‫‪‮⁬‮‪⁪⁮‪​‭‫⁫⁪‫‮((Delegate) comparand, (Delegate) value), comparand);
              num1 = (int) num3 * -770862111 ^ -1811587233;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num4 = changedEventHandler == comparand ? -728352843 : (num4 = -1747363063);
              int num5 = (int) num3 * -1494935550;
              num1 = num4 ^ num5;
              continue;
            case 4:
              comparand = changedEventHandler;
              num1 = -1014939994;
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

    protected event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_1:
        int num1 = -26838394;
        while (true)
        {
          int num2 = -1458037108;
          uint num3;
          PropertyChangedEventHandler comparand;
          PropertyChangedEventHandler changedEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
              num1 = (int) num3 * -419406089 ^ 305921088;
              continue;
            case 2:
              comparand = changedEventHandler1;
              num1 = -810139520;
              continue;
            case 3:
              int num4 = changedEventHandler1 == comparand ? 1146571498 : (num4 = 1590115372);
              int num5 = (int) num3 * -1765630170;
              num1 = num4 ^ num5;
              continue;
            case 4:
              changedEventHandler2 = (PropertyChangedEventHandler) SynchronizedObservableCollection<T>.\u202D⁪‬‫⁮⁬‎⁫​⁬⁫‪‬⁭‌‭‬⁮‭‍‌⁪‏‪‬‪‏⁯​‌⁬‭‪‮​‮⁭⁫‎‎‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1126831863 ^ 1849506885;
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
      remove
      {
        PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_1:
        int num1 = 622004978;
        while (true)
        {
          int num2 = 978742779;
          uint num3;
          PropertyChangedEventHandler comparand;
          PropertyChangedEventHandler changedEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              comparand = changedEventHandler1;
              changedEventHandler2 = (PropertyChangedEventHandler) SynchronizedObservableCollection<T>.\u200B‭‌⁪⁫⁭‎‬‬‌‬‫‏‍⁫⁮‮⁯⁬‪⁯⁬⁯‭‫‪‮⁬‮‪⁪⁮‪​‭‫⁫⁪‫‮((Delegate) comparand, (Delegate) value);
              num1 = 722220189;
              continue;
            case 2:
              changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
              int num4 = changedEventHandler1 != comparand ? 1808855830 : (num4 = 416425539);
              int num5 = (int) num3 * -1463604154;
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

    public SynchronizedObservableCollection()
    {
      this._context = SynchronizedObservableCollection<T>.\u206B‬‭⁭‫⁯‏‎‬‪‪⁮‬⁪‍‍⁫‬‏⁫‏‬‍⁪‫‬‪⁯‪‫⁭⁬‎‍​‮⁮‮‌⁫‮();
      this._items = (IList<T>) new List<T>();
    }

    private IDisposable BlockReentrancy()
    {
      this._monitor.Enter();
      IDisposable monitor = (IDisposable) this._monitor;
label_1:
      int num1 = 868542520;
      while (true)
      {
        int num2 = 971428503;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -72139196 ^ -956154759;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return monitor;
    }

    private void CheckIndex(int index)
    {
label_1:
      int num1 = -1393869501;
      while (true)
      {
        int num2 = -299892654;
        uint num3;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            int num5 = flag ? -834305719 : (num5 = -1578943992);
            int num6 = (int) num3 * -913377341;
            num1 = num5 ^ num6;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_3;
          case 4:
            num4 = index >= this._items.Count ? 1 : 0;
            break;
          case 5:
            if (index < 0)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * 1635842321 ^ -1311849397;
            continue;
          default:
            goto label_11;
        }
        flag = num4 != 0;
        num1 = -314427999;
      }
label_11:
      return;
label_3:
      return;
label_4:
      throw SynchronizedObservableCollection<T>.\u200D​‮⁫‭​‫⁭‭‫‌‪‮‫⁭⁪⁭⁬‮​⁭‏‭‏‭⁫‏‪⁯‏​‍‎⁫‮​‍‍‌⁮‮();
    }

    private void CheckIsReadOnly()
    {
label_1:
      int num1 = -1307637217;
      while (true)
      {
        int num2 = -203553298;
        uint num3;
        bool isReadOnly;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * -1295565739 ^ 228388112;
            continue;
          case 1:
            int num4 = !isReadOnly ? 492421724 : (num4 = 1387389116);
            int num5 = (int) num3 * 2038430288;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_1;
          case 4:
            goto label_3;
          case 5:
            isReadOnly = this._items.IsReadOnly;
            num1 = (int) num3 * -1169913232 ^ 1311649929;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:
      return;
label_5:
      throw SynchronizedObservableCollection<T>.\u202B⁭⁭‫‮​⁭‭​⁫‭‪‭⁬​‭‬‪⁬‍‌⁬⁪⁭‏‮⁬‫‫‍‪​​​‎‍⁫​‪‏‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1772641862U));
    }

    private void CheckReentrancy()
    {
label_1:
      int num1 = 92848874;
      while (true)
      {
        int num2 = 1968357181;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            if (this._monitor.Busy)
            {
              num1 = (int) num3 * -1646770035 ^ -2034125770;
              continue;
            }
            break;
          case 2:
            // ISSUE: reference to a compiler-generated field
            if (this.CollectionChanged != null)
            {
              num1 = (int) num3 * -658843197 ^ 198814877;
              continue;
            }
            break;
          case 3:
            goto label_4;
          case 4:
            // ISSUE: reference to a compiler-generated field
            num4 = SynchronizedObservableCollection<T>.\u206A‮​‍‫⁮‬‫⁭⁯‭‫‪‭​‏‎‌‍⁪‭‮‭‌⁭‌‌⁫‌‪⁫⁮‬‍‏‫⁫⁫‍‎‮((Delegate) this.CollectionChanged).Length > 1 ? 1 : 0;
            goto label_7;
          case 5:
            goto label_1;
          default:
            goto label_12;
        }
        num4 = 0;
label_7:
        int num5;
        num1 = num5 = num4 != 0 ? 1118313338 : (num5 = 1526604761);
      }
label_12:
      return;
label_3:
      return;
label_4:
      throw SynchronizedObservableCollection<T>.\u202B⁭⁬⁮‏‫⁯​‍‭​‭‫⁬‍⁮‭⁮‌​‏‮‎‭⁭⁮⁭⁫‪⁭⁪​⁪⁯‫‬‏⁮​⁮‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(360068718U));
    }

    private static bool IsCompatibleObject(object value)
    {
label_1:
      int num1 = 558523251;
      bool flag;
      while (true)
      {
        int num2 = 741921993;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 548251800 ^ -556788484;
            continue;
          case 3:
            num4 = (object) default (T) == null ? 1 : 0;
            break;
          case 4:
            if (value is T)
            {
              num4 = 1;
              break;
            }
            num1 = (int) num3 * 320127557 ^ -778951674;
            continue;
          case 5:
            if (value != null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1476219672 ^ 206529538;
            continue;
          default:
            goto label_12;
        }
        flag = num4 != 0;
        num1 = 571148725;
      }
label_12:
      return flag;
    }

    private void OnPropertyChanged(string propertyName)
    {
label_1:
      int num1 = -777104013;
      while (true)
      {
        int num2 = -1101847329;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.OnPropertyChanged(SynchronizedObservableCollection<T>.\u206C‮⁮‎​⁪‬‌⁭​‮‌‎⁮​⁫​‪⁬‬⁬⁫‎‮‬⁪‬‮⁯‮​‭‎‮‎⁮⁪​⁪⁮‮(propertyName));
            num1 = (int) num3 * 2031660601 ^ -327468197;
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

    private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index)
    {
label_1:
      int num1 = 840793538;
      while (true)
      {
        int num2 = 1873695400;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.OnCollectionChanged(SynchronizedObservableCollection<T>.\u206B‮‎‏⁭⁭⁮‭⁪‪‪⁬‭‍⁮‪⁮⁬⁬​​‮⁪⁮‭‮⁮⁮⁫⁮‌‪⁭‎‌⁭‏⁫⁪‌‮(action, item, index));
            num1 = (int) num3 * -1386047363 ^ -387957175;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index, int oldIndex)
    {
      this.OnCollectionChanged(SynchronizedObservableCollection<T>.\u200C‏⁫‫‌⁬⁫‎‭‏‌‏⁭‭‪⁬⁮​‌⁮⁯‭⁬‪⁯​‎​‌⁮‍‬‏‭⁭‌⁫‪‭‬‮(action, item, index, oldIndex));
    }

    private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index)
    {
label_1:
      int num1 = -792307418;
      while (true)
      {
        int num2 = -30565097;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.OnCollectionChanged(SynchronizedObservableCollection<T>.\u200C‫‭‎‫‭‫‍⁬⁪⁫‎‪‏⁯‌‮​‪⁮‭‫⁫‮⁪‪⁬​‬‫‫‫‍‫⁯‮‬‭⁮‪‮(action, newItem, oldItem, index));
            num1 = (int) num3 * -432785879 ^ -1233656654;
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

    private void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    {
label_1:
      int num1 = -295860808;
      NotifyCollectionChangedEventHandler collectionChanged;
      while (true)
      {
        int num2 = -1803230911;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 1168422395 ^ -2028511507;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            collectionChanged = this.CollectionChanged;
            num1 = (int) num3 * 1410008731 ^ 664592803;
            continue;
          case 3:
            int num4 = collectionChanged == null ? -1888032078 : (num4 = -188244232);
            int num5 = (int) num3 * 1866888885;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_17;
          case 5:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_17:
      return;
label_6:
      IDisposable disposable = this.BlockReentrancy();
      try
      {
label_8:
        int num2 = -1846424341;
        while (true)
        {
          int num3 = -1803230911;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_8;
            case 1:
              goto label_13;
            case 2:
              SynchronizedObservableCollection<T>.\u200C‪‮‏‮⁫⁭‎‍⁭‮⁫‌‎‬‬‫‏⁬⁯‫‏⁭‪⁭‍⁯‬‎​‪⁮‭‪‫⁫​‏‎⁯‮(this._context, (SendOrPostCallback) (state =>
              {
                collectionChanged.Invoke((object) this, e);
label_1:
                int num2 = 93393980;
                while (true)
                {
                  int num3 = 1162288434;
                  uint num4;
                  switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                  {
                    case 0:
                      goto label_3;
                    case 1:
                      num2 = (int) num4 * -815220740 ^ -565611707;
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
              }), (object) null);
              num2 = (int) num4 * 730088264 ^ -1179958090;
              continue;
            case 3:
              num2 = (int) num4 * 484781688 ^ 1734021788;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_13:;
      }
      finally
      {
        if (disposable != null)
        {
label_15:
          int num2 = -368312261;
          while (true)
          {
            int num3 = -1803230911;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_15;
              case 1:
                num2 = (int) num4 * 510250758 ^ 443132288;
                continue;
              case 2:
                SynchronizedObservableCollection<T>.\u202C‫⁮⁪‍⁫‬‎⁭‮⁭⁯⁮⁮‏⁫‪⁯‪​‮‏⁬⁭‍‭⁪‮‬‎⁫⁪‪⁮‪‭‌⁮‫‬‮(disposable);
                num2 = (int) num4 * -1287541700 ^ -563638668;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    private void OnCollectionReset()
    {
label_1:
      int num1 = -864193262;
      while (true)
      {
        int num2 = -475741641;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.OnCollectionChanged(SynchronizedObservableCollection<T>.\u206E⁪⁭‌⁮⁯⁪‍‫‭‪​​​‪‍⁯⁬⁪‬​⁯⁮⁯‮‍‎‎‫‫‎⁪‮⁪⁭‬‏‌⁯‪‮((NotifyCollectionChangedAction) 4));
            num1 = (int) num3 * -1974435106 ^ -1215931055;
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

    private void OnPropertyChanged(PropertyChangedEventArgs e)
    {
label_1:
      int num1 = 1247781904;
      while (true)
      {
        int num2 = 403387468;
        uint num3;
        PropertyChangedEventHandler propertyChanged;
        PropertyChangedEventArgs e1;
        SynchronizedObservableCollection<T> observableCollection;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            e1 = e;
            num1 = (int) num3 * -66053504 ^ 487548765;
            continue;
          case 2:
            observableCollection = this;
            num1 = (int) num3 * -674160372 ^ -361577641;
            continue;
          case 3:
            goto label_3;
          case 4:
            SynchronizedObservableCollection<T>.\u200C‪‮‏‮⁫⁭‎‍⁭‮⁫‌‎‬‬‫‏⁬⁯‫‏⁭‪⁭‍⁯‬‎​‪⁮‭‪‫⁫​‏‎⁯‮(this._context, (SendOrPostCallback) (state => propertyChanged((object) observableCollection, e1)), (object) null);
            num1 = 913546750;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            propertyChanged = this.PropertyChanged;
            num1 = (int) num3 * -1585091619 ^ -550595903;
            continue;
          case 6:
            int num4 = propertyChanged == null ? 762051815 : (num4 = 2038882140);
            int num5 = (int) num3 * 1968260961;
            num1 = num4 ^ num5;
            continue;
          case 7:
            num1 = (int) num3 * 2130019593 ^ -1001955024;
            continue;
          case 8:
            num1 = (int) num3 * 944662856 ^ 1255190387;
            continue;
          case 9:
            num1 = (int) num3 * -825496733 ^ 1297993438;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    public void Add(T item)
    {
      SynchronizedObservableCollection<T>.\u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮(this._itemsLock);
label_1:
      int num1 = -1090853350;
      while (true)
      {
        int num2 = -971844440;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1598612356 ^ -1259077066;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      int count = this._items.Count;
      try
      {
label_6:
        int num2 = -101051879;
        while (true)
        {
          int num3 = -971844440;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              goto label_6;
            case 1:
              this.CheckIsReadOnly();
              this.CheckReentrancy();
              num2 = (int) num4 * 824308860 ^ -1398122098;
              continue;
            case 2:
              num2 = (int) num4 * 1005982006 ^ -1679419727;
              continue;
            case 4:
              num2 = (int) num4 * -1879924396 ^ -441790193;
              continue;
            case 5:
              this._items.Insert(count, item);
              num2 = (int) num4 * -497513127 ^ 2085531153;
              continue;
            default:
              goto label_19;
          }
        }
      }
      finally
      {
label_13:
        int num2 = -1954920779;
        while (true)
        {
          int num3 = -971844440;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              SynchronizedObservableCollection<T>.\u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮(this._itemsLock);
              num2 = (int) num4 * -1046323303 ^ -839006677;
              continue;
            case 2:
              num2 = (int) num4 * -645592556 ^ -539105464;
              continue;
            case 3:
              goto label_13;
            default:
              goto label_18;
          }
        }
label_18:;
      }
label_19:
      this.OnPropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(986808247U));
label_20:
      int num5 = -632185107;
      while (true)
      {
        int num2 = -971844440;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 4U)
        {
          case 0:
            goto label_20;
          case 1:
            this.OnPropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(529807092U));
            num5 = (int) num3 * 1261143124 ^ 1113109474;
            continue;
          case 2:
            this.OnCollectionChanged((NotifyCollectionChangedAction) 0, (object) item, count);
            num5 = (int) num3 * 1540751347 ^ 112520757;
            continue;
          case 3:
            goto label_22;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_22:;
    }

    int IList.Add(object value)
    {
label_1:
      int num1 = -2131185895;
      while (true)
      {
        int num2 = -75827755;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            SynchronizedObservableCollection<T>.\u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮(this._itemsLock);
            num1 = (int) num3 * 1490141425 ^ -612032539;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      int count = this._items.Count;
      T obj;
      try
      {
label_6:
        int num2 = -1227640132;
        while (true)
        {
          int num3 = -75827755;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              num2 = (int) num4 * 420278616 ^ 301367304;
              continue;
            case 2:
              this.CheckIsReadOnly();
              this.CheckReentrancy();
              obj = (T) value;
              num2 = (int) num4 * 38187219 ^ 142499290;
              continue;
            case 3:
              goto label_6;
            case 4:
              this._items.Insert(count, obj);
              num2 = (int) num4 * -803597138 ^ -259236532;
              continue;
            default:
              goto label_18;
          }
        }
      }
      catch (InvalidCastException ex)
      {
        throw SynchronizedObservableCollection<T>.\u206F‮‬⁯‫‬‫‬‫‬⁪⁫‫‭‭‮‪‪‎⁮⁬⁮⁫⁯⁬​‬⁬⁭⁮‍‬‌‮‬‌‬⁭‍⁫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1607230553U));
      }
      finally
      {
label_13:
        int num2 = -452153205;
        while (true)
        {
          int num3 = -75827755;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_13;
            case 1:
              num2 = (int) num4 * 480136728 ^ 359292162;
              continue;
            case 2:
              SynchronizedObservableCollection<T>.\u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮(this._itemsLock);
              num2 = (int) num4 * -1706940357 ^ 2127385322;
              continue;
            default:
              goto label_17;
          }
        }
label_17:;
      }
label_18:
      this.OnPropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3906139371U));
label_19:
      int num5 = -1501617280;
      int num6;
      while (true)
      {
        int num2 = -75827755;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 7U)
        {
          case 0:
            this.OnCollectionChanged((NotifyCollectionChangedAction) 0, (object) obj, count);
            num5 = (int) num3 * 613521968 ^ 278374037;
            continue;
          case 1:
            this.OnPropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3051756489U));
            num5 = (int) num3 * 2016098057 ^ -318258208;
            continue;
          case 2:
            num5 = (int) num3 * -257431014 ^ 108259239;
            continue;
          case 4:
            num6 = count;
            num5 = (int) num3 * -1023647720 ^ -97105574;
            continue;
          case 5:
            goto label_19;
          case 6:
            num5 = (int) num3 * -109121540 ^ 340931716;
            continue;
          default:
            goto label_26;
        }
      }
label_26:
      return num6;
    }

    public void Clear()
    {
label_1:
      int num1 = 531680263;
      while (true)
      {
        int num2 = 1634895381;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            SynchronizedObservableCollection<T>.\u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮(this._itemsLock);
            num1 = (int) num3 * -1284962878 ^ -1529034809;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        this.CheckIsReadOnly();
label_6:
        int num2 = 1168583604;
        while (true)
        {
          int num3 = 1634895381;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 6U)
          {
            case 0:
              num2 = (int) num4 * 1084416767 ^ -1928963174;
              continue;
            case 1:
              num2 = (int) num4 * -1535744779 ^ -1420612833;
              continue;
            case 2:
              goto label_6;
            case 3:
              this.CheckReentrancy();
              num2 = (int) num4 * 2084136539 ^ 1574207952;
              continue;
            case 4:
              this._items.Clear();
              num2 = (int) num4 * -630428724 ^ -1626078737;
              continue;
            default:
              goto label_19;
          }
        }
      }
      finally
      {
label_13:
        int num2 = 433468244;
        while (true)
        {
          int num3 = 1634895381;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              SynchronizedObservableCollection<T>.\u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮(this._itemsLock);
              num2 = (int) num4 * 1838701518 ^ -1817630787;
              continue;
            case 2:
              num2 = (int) num4 * 1339402104 ^ -904824123;
              continue;
            case 3:
              goto label_13;
            default:
              goto label_18;
          }
        }
label_18:;
      }
label_19:
      this.OnPropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(958278185U));
label_20:
      int num5 = 1129648249;
      while (true)
      {
        int num2 = 1634895381;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 5U)
        {
          case 0:
            this.OnCollectionReset();
            num5 = (int) num3 * -1281617816 ^ -250254271;
            continue;
          case 1:
            num5 = (int) num3 * -465566853 ^ -2016026176;
            continue;
          case 2:
            goto label_22;
          case 3:
            goto label_20;
          case 4:
            this.OnPropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(529807092U));
            num5 = (int) num3 * -398722888 ^ -584818075;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return;
label_22:;
    }

    public void CopyTo(T[] array, int index)
    {
label_1:
      int num1 = -1465191980;
      while (true)
      {
        int num2 = -105034050;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
            num1 = (int) num3 * -26783673 ^ -283240608;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
label_6:
        int num2 = -575498428;
        while (true)
        {
          int num3 = -105034050;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_14;
            case 2:
              this._items.CopyTo(array, index);
              num2 = (int) num4 * 1321206563 ^ 85242799;
              continue;
            case 3:
              num2 = (int) num4 * -1877119366 ^ -955046147;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_14:;
      }
      finally
      {
        SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
label_12:
        int num2 = -1527187357;
        while (true)
        {
          int num3 = -105034050;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_12;
            case 1:
              num2 = (int) num4 * -607771526 ^ 1013977755;
              continue;
            default:
              goto label_16;
          }
        }
label_16:;
      }
    }

    void ICollection.CopyTo(Array array, int index)
    {
      SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
      try
      {
        if (array != null)
          goto label_6;
label_2:
        int num1 = 1994322639;
label_3:
        object[] objArray;
        bool flag1;
        while (true)
        {
          int num2 = 1690010622;
          uint num3;
          bool flag2;
          bool flag3;
          T[] array1;
          Type type1;
          Type type2;
          bool flag4;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 30U)
          {
            case 0:
              int num5 = !flag1 ? 823417053 : (num5 = 1059451246);
              int num6 = (int) num3 * -1573410465;
              num1 = num5 ^ num6;
              continue;
            case 1:
              goto label_19;
            case 2:
              num1 = (int) num3 * 581308888 ^ 876091713;
              continue;
            case 3:
              num4 = !SynchronizedObservableCollection<T>.\u202D​‪‌‮⁬‍⁮⁫⁬​‮‬⁯‎‏‍⁫‏‍‪‏‪‪‪‌‬‬⁫⁭‮‮⁫⁭‫⁮⁯⁮‫‌‮(type2, type1) ? 1 : 0;
              break;
            case 4:
              array1 = array as T[];
              num1 = 19779418;
              continue;
            case 5:
              goto label_6;
            case 6:
              goto label_32;
            case 7:
              num1 = (int) num3 * 1848817143 ^ -1860120558;
              continue;
            case 8:
              int num7;
              num1 = num7 = index >= 0 ? 1162273274 : (num7 = 210718453);
              continue;
            case 9:
              goto label_2;
            case 10:
              goto label_4;
            case 11:
              goto label_22;
            case 12:
              int num8 = flag2 ? 630063124 : (num8 = 1525711855);
              int num9 = (int) num3 * 1483566124;
              num1 = num8 ^ num9;
              continue;
            case 13:
              flag3 = (uint) SynchronizedObservableCollection<T>.\u206D‬⁫⁫⁬‬​⁭‎⁭⁪‎‎‬⁮⁮​‭‌⁪‮‌‏⁭‭​⁭‮‮⁬⁭‍⁬⁬⁭⁯‭⁭‍⁭‮(array, 0) > 0U;
              num1 = 24500649;
              continue;
            case 14:
              type1 = SynchronizedObservableCollection<T>.\u200E‬‍​‮‫⁫⁬‭‍‏⁭‪⁬⁬⁯⁫‌​⁪‍⁮⁮⁯‭⁯‫⁮⁭⁭⁮⁬‭‭‭⁬⁮‬‪‍‮(SynchronizedObservableCollection<T>.\u202B⁫⁮‪⁯‎⁪‪‍​‬‬⁪‭​⁪⁯‪‫‮‪‬‌‫⁬‪⁯‫‪‮‏‏​‏‏‭‮​⁬⁭‮((object) array));
              // ISSUE: type reference
              type2 = SynchronizedObservableCollection<T>.\u202B​⁬⁫‪⁪‫‏⁭‬‎⁪‪‭‫⁭⁬‌‪‎‮⁬‍⁫‎‮⁪‭‫‎​‍⁪‫⁬‮‌‬‫⁮‮(__typeref (T));
              num1 = 944786757;
              continue;
            case 15:
              if (!SynchronizedObservableCollection<T>.\u202D​‪‌‮⁬‍⁮⁫⁬​‮‬⁯‎‏‍⁫‏‍‪‏‪‪‪‌‬‬⁫⁭‮‮⁫⁭‫⁮⁯⁮‫‌‮(type1, type2))
              {
                num1 = (int) num3 * 1667854665 ^ -139211064;
                continue;
              }
              num4 = 0;
              break;
            case 16:
              num1 = (int) num3 * -1459036991 ^ 1688226676;
              continue;
            case 17:
              goto label_21;
            case 18:
              this._items.CopyTo(array1, index);
              num1 = (int) num3 * 2123743552 ^ 980657437;
              continue;
            case 19:
              int num10 = flag3 ? 450662987 : (num10 = 73618633);
              int num11 = (int) num3 * -1124567857;
              num1 = num10 ^ num11;
              continue;
            case 20:
              num1 = (int) num3 * -360696763 ^ 1163388168;
              continue;
            case 22:
              int num12 = flag4 ? -1732873694 : (num12 = -963266052);
              int num13 = (int) num3 * 544758553;
              num1 = num12 ^ num13;
              continue;
            case 23:
              objArray = array as object[];
              num1 = 1587666225;
              continue;
            case 24:
              goto label_16;
            case 25:
              flag2 = objArray == null;
              num1 = (int) num3 * 1714386196 ^ 299728042;
              continue;
            case 26:
              flag4 = array1 != null;
              num1 = (int) num3 * 953466034 ^ 731858404;
              continue;
            case 27:
              goto label_14;
            case 28:
              int num14;
              num1 = num14 = SynchronizedObservableCollection<T>.\u202B‮‮‎⁯‍‎‌⁫‮⁯‭⁬‬‮‬⁯‌⁯​⁮‫⁭⁭‎⁬⁮‮⁪⁮⁯‍‫‬‬⁪⁫​‏‮(array) - index >= this._items.Count ? 1690655720 : (num14 = 968120062);
              continue;
            case 29:
              goto label_48;
            default:
              goto label_34;
          }
          int num15;
          num1 = num15 = num4 == 0 ? 1238691211 : (num15 = 2115377491);
        }
label_48:
        return;
label_4:
        throw SynchronizedObservableCollection<T>.\u200D⁭‫​⁫‭‮‍⁪‎⁭‏‌‌‭‭‫‮‫‬⁪‪‭⁫‍‍⁭⁪​⁮⁮‭⁪‫⁬⁬‫⁪⁭⁫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3992410414U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(221598204U));
label_14:
        throw SynchronizedObservableCollection<T>.\u206B​‫​‪​‍‫‏​‏⁬‪‎‎⁮‌‌‏‎⁮‫⁭​​​‌⁫‬‏‭‬‍⁬‮⁭‪​‍‭‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(759378138U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(603945235U));
label_16:
        throw SynchronizedObservableCollection<T>.\u206B⁭⁯⁮‎⁪⁮⁪‮‮‬‫​⁬‮⁪‎⁯⁬⁬‏‌​‏⁪⁬‍⁫⁯⁫‫⁮⁪‭‏‪⁭‮‭‏‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3346684986U));
label_19:
        throw SynchronizedObservableCollection<T>.\u206B⁭⁯⁮‎⁪⁮⁪‮‮‬‫​⁬‮⁪‎⁯⁬⁬‏‌​‏⁪⁬‍⁫⁯⁫‫⁮⁪‭‏‪⁭‮‭‏‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2400061942U));
label_21:
        throw SynchronizedObservableCollection<T>.\u200D⁭‫​⁫‭‮‍⁪‎⁭‏‌‌‭‭‫‮‫‬⁪‪‭⁫‍‍⁭⁪​⁮⁮‭⁪‫⁬⁬‫⁪⁭⁫‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1013701499U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(911296597U));
label_22:
        throw SynchronizedObservableCollection<T>.\u206B⁫⁫⁯‬‎‏⁭⁬⁬⁬‌⁪⁮‭⁮⁯⁮​‏‮⁫⁪⁮⁬‫⁯‬‏‎‬⁬‎‏‎‍‪⁭‏‬‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2652559360U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2645536573U));
label_32:
        throw SynchronizedObservableCollection<T>.\u206F‮‬⁯‫‬‫‬‫‬⁪⁫‫‭‭‮‪‪‎⁮⁬⁮⁫⁯⁬​‬⁬⁭⁮‍‬‌‮‬‌‬⁭‍⁫‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2769205416U));
label_34:
        int count = this._items.Count;
        try
        {
label_36:
          int num2 = 634862776;
          while (true)
          {
            int num3 = 1690010622;
            uint num4;
            int index1;
            bool flag2;
            switch ((num4 = (uint) (num2 ^ num3)) % 10U)
            {
              case 0:
                goto label_36;
              case 1:
                num2 = (int) num4 * -1428960767 ^ 304250311;
                continue;
              case 3:
                int num5 = !flag2 ? 104692107 : (num5 = 969618709);
                int num6 = (int) num4 * -1449715136;
                num2 = num5 ^ num6;
                continue;
              case 4:
                index1 = 0;
                num2 = (int) num4 * 982971096 ^ -1506600520;
                continue;
              case 5:
                ++index1;
                num2 = (int) num4 * 681051614 ^ -1269590173;
                continue;
              case 6:
                num2 = (int) num4 * -1667967016 ^ 1062867893;
                continue;
              case 7:
                objArray[index++] = (object) this._items[index1];
                num2 = 1065833564;
                continue;
              case 8:
                num2 = (int) num4 * 1202915304 ^ 97258531;
                continue;
              case 9:
                flag2 = index1 < count;
                num2 = 602345237;
                continue;
              default:
                goto label_47;
            }
          }
        }
        catch (ArrayTypeMismatchException ex)
        {
          throw SynchronizedObservableCollection<T>.\u206B⁭⁯⁮‎⁪⁮⁪‮‮‬‫​⁬‮⁪‎⁯⁬⁬‏‌​‏⁪⁬‍⁫⁯⁫‫⁮⁪‭‏‪⁭‮‭‏‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2400061942U));
        }
label_47:
        return;
label_6:
        flag1 = SynchronizedObservableCollection<T>.\u202E⁮‫⁬‬‪​⁫⁪‪‭‪‌‏‮​‌‍‪‮‏‪⁫‏‮​‫⁭‎⁭‬‫‎‎‫‌‫‮‬‌‮(array) != 1;
        num1 = 1917326496;
        goto label_3;
      }
      finally
      {
label_50:
        int num1 = 678881407;
        while (true)
        {
          int num2 = 1690010622;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_50;
            case 1:
              SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
              num1 = (int) num3 * -425535424 ^ 1131390810;
              continue;
            default:
              goto label_53;
          }
        }
label_53:;
      }
    }

    public bool Contains(T item)
    {
      SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
      try
      {
        return this._items.Contains(item);
      }
      finally
      {
label_3:
        int num1 = -971598347;
        while (true)
        {
          int num2 = -690220508;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
              num1 = (int) num3 * 68415085 ^ 1979165226;
              continue;
            default:
              goto label_6;
          }
        }
label_6:;
      }
    }

    bool IList.Contains(object value)
    {
      bool flag = SynchronizedObservableCollection<T>.IsCompatibleObject(value);
label_1:
      int num1 = 1521600351;
      while (true)
      {
        int num2 = 1808937446;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            if (flag)
            {
              num1 = (int) num3 * 1053850844 ^ 495176264;
              continue;
            }
            goto label_15;
          case 2:
            num1 = (int) num3 * 1205192684 ^ -1519577182;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
      try
      {
        return this._items.Contains((T) value);
      }
      finally
      {
label_9:
        int num2 = 1163743827;
        while (true)
        {
          int num3 = 1808937446;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_9;
            case 2:
              num2 = (int) num4 * -2015009415 ^ 500316318;
              continue;
            case 3:
              num2 = (int) num4 * 1498372374 ^ 619117727;
              continue;
            case 4:
              SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
              num2 = (int) num4 * -1025334362 ^ -1305547204;
              continue;
            default:
              goto label_14;
          }
        }
label_14:;
      }
label_15:
      return false;
    }

    public void Dispose()
    {
      SynchronizedObservableCollection<T>.\u206D‫⁬⁬​⁬‭‮‬⁬‍‭‮⁫‮‍⁬‭⁫‏⁭​⁫⁯‪‫‭‫‫⁯‏⁭‌‭‪‮⁬‏⁮‌‮(this._itemsLock);
label_1:
      int num1 = 280270833;
      while (true)
      {
        int num2 = 1176757534;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -113536193 ^ 789180021;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public IEnumerator<T> GetEnumerator()
    {
      SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
      try
      {
        return (IEnumerator<T>) this._items.ToList<T>().GetEnumerator();
      }
      finally
      {
        SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
      try
      {
        return SynchronizedObservableCollection<T>.\u206F‌⁭​⁭⁬‫⁭‎‍⁯⁮⁯‌‫‌‍‮‍⁬⁭‪⁯‎⁮⁯⁪‬​‬‏‬‮‭‏‭​​‏‎‮((IEnumerable) this._items.ToList<T>());
      }
      finally
      {
label_3:
        int num1 = -737715794;
        while (true)
        {
          int num2 = -1042837340;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 433317894 ^ 1381984846;
              continue;
            case 2:
              SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
              num1 = (int) num3 * -38245313 ^ 87984399;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:;
      }
    }

    public int IndexOf(T item)
    {
label_1:
      int num1 = -20557985;
      while (true)
      {
        int num2 = -852401484;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
            num1 = (int) num3 * 673812523 ^ 1698446677;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      int num4;
      try
      {
label_6:
        int num2 = -2107337678;
        while (true)
        {
          int num3 = -852401484;
          uint num5;
          switch ((num5 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              num4 = this._items.IndexOf(item);
              num2 = (int) num5 * 1072922609 ^ -14133191;
              continue;
            default:
              goto label_10;
          }
        }
      }
      finally
      {
        SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
      }
label_10:
      return num4;
    }

    int IList.IndexOf(object value)
    {
label_1:
      int num1 = 348574509;
      while (true)
      {
        int num2 = 444978683;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            flag = SynchronizedObservableCollection<T>.IsCompatibleObject(value);
            num1 = (int) num3 * 489922214 ^ 767019524;
            continue;
          case 2:
            num1 = (int) num3 * -698797098 ^ 1153984047;
            continue;
          case 3:
            goto label_1;
          case 4:
            if (flag)
            {
              num1 = (int) num3 * 794198297 ^ -521954406;
              continue;
            }
            goto label_17;
          default:
            goto label_7;
        }
      }
label_7:
      SynchronizedObservableCollection<T>.\u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮(this._itemsLock);
      int num4;
      try
      {
label_9:
        int num2 = 592151073;
        while (true)
        {
          int num3 = 444978683;
          uint num5;
          switch ((num5 = (uint) (num2 ^ num3)) % 3U)
          {
            case 1:
              num4 = this._items.IndexOf((T) value);
              num2 = (int) num5 * 1217473882 ^ -1304506262;
              continue;
            case 2:
              goto label_9;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
label_13:
        int num2 = 399561381;
        while (true)
        {
          int num3 = 444978683;
          uint num5;
          switch ((num5 = (uint) (num2 ^ num3)) % 3U)
          {
            case 0:
              goto label_13;
            case 1:
              SynchronizedObservableCollection<T>.\u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮(this._itemsLock);
              num2 = (int) num5 * -1745862132 ^ -851443659;
              continue;
            default:
              goto label_16;
          }
        }
label_16:;
      }
label_17:
      num4 = -1;
label_18:
      return num4;
    }

    public void Insert(int index, T item)
    {
      SynchronizedObservableCollection<T>.\u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮(this._itemsLock);
      try
      {
        this.CheckIsReadOnly();
        this.CheckIndex(index);
label_2:
        int num1 = 445123690;
        while (true)
        {
          int num2 = 333383687;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * 539184737 ^ 1795426740;
              continue;
            case 2:
              num1 = (int) num3 * 1689890907 ^ 1313524495;
              continue;
            case 3:
              goto label_2;
            case 4:
              this._items.Insert(index, item);
              num1 = (int) num3 * -253373980 ^ 1543848425;
              continue;
            case 5:
              this.CheckReentrancy();
              num1 = (int) num3 * -191350948 ^ -737387445;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
label_9:
        int num1 = 914010857;
        while (true)
        {
          int num2 = 333383687;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -507426444 ^ 655032843;
              continue;
            case 2:
              SynchronizedObservableCollection<T>.\u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮(this._itemsLock);
              num1 = (int) num3 * -812104204 ^ -1543747006;
              continue;
            case 3:
              goto label_9;
            default:
              goto label_14;
          }
        }
label_14:;
      }
label_15:
      this.OnPropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3906139371U));
label_16:
      int num4 = 593171122;
      while (true)
      {
        int num1 = 333383687;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 6U)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_18;
          case 2:
            num4 = (int) num2 * 765773283 ^ 910604497;
            continue;
          case 3:
            num4 = (int) num2 * 1538700532 ^ 1247990292;
            continue;
          case 4:
            this.OnCollectionChanged((NotifyCollectionChangedAction) 0, (object) item, index);
            num4 = (int) num2 * -129237126 ^ -60358042;
            continue;
          case 5:
            this.OnPropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3478259480U));
            num4 = (int) num2 * 713825738 ^ -2136008573;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_18:;
    }

    void IList.Insert(int index, object value)
    {
      try
      {
label_2:
        int num1 = -554457455;
        while (true)
        {
          int num2 = -1021602873;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              this.Insert(index, (T) value);
              num1 = (int) num3 * 585714545 ^ -1742699055;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_6:;
      }
      catch (InvalidCastException ex)
      {
        throw SynchronizedObservableCollection<T>.\u206F‮‬⁯‫‬‫‬‫‬⁪⁫‫‭‭‮‪‪‎⁮⁬⁮⁫⁯⁬​‬⁬⁭⁮‍‬‌‮‬‌‬⁭‍⁫‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2803954823U));
      }
    }

    public bool Remove(T item)
    {
      SynchronizedObservableCollection<T>.\u200B‪⁫​‍‍‪‪⁬⁪⁬‬‮‫‌⁪‮‫‎⁯‫‪‬‏‍⁯‭‍⁯‌‪‬‫‍‬‏⁪‎‎⁯‮(this._itemsLock);
      bool flag1;
      int index;
      T obj;
      try
      {
        this.CheckIsReadOnly();
label_2:
        int num1 = 122210762;
        while (true)
        {
          int num2 = 423440818;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = !flag2 ? -1279115473 : (num4 = -947573627);
              int num5 = (int) num3 * 168082429;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_29;
            case 3:
              goto label_2;
            case 4:
              index = this._items.IndexOf(item);
              num1 = (int) num3 * 1520167962 ^ 1597215468;
              continue;
            case 5:
              flag1 = false;
              num1 = (int) num3 * -536362915 ^ -1409740917;
              continue;
            case 6:
              flag2 = index < 0;
              num1 = (int) num3 * 876156848 ^ -1699769491;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        SynchronizedObservableCollection<T>.\u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮(this._itemsLock);
        try
        {
label_10:
          int num2 = 742971855;
          while (true)
          {
            int num3 = 423440818;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 7U)
            {
              case 0:
                num2 = (int) num4 * 461490552 ^ -1258870991;
                continue;
              case 2:
                num2 = (int) num4 * 512961603 ^ -967545465;
                continue;
              case 3:
                this.CheckReentrancy();
                num2 = (int) num4 * -1549136169 ^ 354975039;
                continue;
              case 4:
                goto label_10;
              case 5:
                this._items.RemoveAt(index);
                num2 = (int) num4 * -962258980 ^ 1520510495;
                continue;
              case 6:
                obj = this._items[index];
                num2 = (int) num4 * -913975044 ^ -4088000;
                continue;
              default:
                goto label_23;
            }
          }
        }
        finally
        {
          SynchronizedObservableCollection<T>.\u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮(this._itemsLock);
label_18:
          int num2 = 1850244923;
          while (true)
          {
            int num3 = 423440818;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num2 = (int) num4 * -464231049 ^ -765124608;
                continue;
              case 2:
                goto label_18;
              default:
                goto label_21;
            }
          }
label_21:;
        }
      }
      finally
      {
        SynchronizedObservableCollection<T>.\u202A⁫‏‪‬‪⁮⁫⁪⁮‭‮‮‌‭‮⁮⁯​‮⁫‎‎⁪⁫‮⁪‪‍⁫‎⁭‫⁮‫⁭‫‪‪‌‮(this._itemsLock);
      }
label_23:
      this.OnPropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1576005568U));
      this.OnPropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3478259480U));
      this.OnCollectionChanged((NotifyCollectionChangedAction) 1, (object) obj, index);
label_24:
      int num6 = 1623601929;
      while (true)
      {
        int num1 = 423440818;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 5U)
        {
          case 0:
            flag1 = true;
            num6 = (int) num2 * -649385185 ^ -1316019008;
            continue;
          case 1:
            num6 = (int) num2 * -1465560655 ^ 177061481;
            continue;
          case 2:
            num6 = (int) num2 * -132871747 ^ 1548061474;
            continue;
          case 4:
            goto label_24;
          default:
            goto label_29;
        }
      }
label_29:
      return flag1;
    }

    void IList.Remove(object value)
    {
label_1:
      int num1 = -1464292225;
      while (true)
      {
        int num2 = -402013063;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = !SynchronizedObservableCollection<T>.IsCompatibleObject(value) ? -1103998380 : (num4 = -1593079134);
            int num5 = (int) num3 * -1481771292;
            num1 = num4 ^ num5;
            continue;
          case 2:
            num1 = (int) num3 * 642057214 ^ 1539548178;
            continue;
          case 3:
            this.Remove((T) value);
            num1 = (int) num3 * 12646217 ^ 1766719315;
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

    public void RemoveAt(int index)
    {
label_1:
      int num1 = 2000612512;
      while (true)
      {
        int num2 = 1587657482;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            SynchronizedObservableCollection<T>.\u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮(this._itemsLock);
            num1 = (int) num3 * 2028801733 ^ -1036581687;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      T obj;
      try
      {
label_6:
        int num2 = 1480084318;
        while (true)
        {
          int num3 = 1587657482;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 7U)
          {
            case 1:
              obj = this._items[index];
              num2 = (int) num4 * 841522846 ^ 128476967;
              continue;
            case 2:
              this.CheckReentrancy();
              num2 = (int) num4 * -1092680576 ^ -30978425;
              continue;
            case 3:
              num2 = (int) num4 * -1188829907 ^ -23011815;
              continue;
            case 4:
              this.CheckIndex(index);
              num2 = (int) num4 * -1971384370 ^ -1685049909;
              continue;
            case 5:
              this.CheckIsReadOnly();
              num2 = (int) num4 * 931202808 ^ 158220933;
              continue;
            case 6:
              goto label_6;
            default:
              goto label_13;
          }
        }
label_13:
        this._items.RemoveAt(index);
      }
      finally
      {
label_15:
        int num2 = 729810307;
        while (true)
        {
          int num3 = 1587657482;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 1:
              SynchronizedObservableCollection<T>.\u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮(this._itemsLock);
              num2 = (int) num4 * 329731669 ^ -614717231;
              continue;
            case 2:
              num2 = (int) num4 * 2116821053 ^ -1866913336;
              continue;
            case 3:
              goto label_15;
            default:
              goto label_19;
          }
        }
label_19:;
      }
      this.OnPropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1576005568U));
label_21:
      int num5 = 981256586;
      while (true)
      {
        int num2 = 1587657482;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_21;
          case 2:
            num5 = (int) num3 * 916426911 ^ 962766406;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      this.OnPropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(393592628U));
      this.OnCollectionChanged((NotifyCollectionChangedAction) 1, (object) obj, index);
    }

    static ReaderWriterLockSlim \u206F‎‌​‍​‮⁫‫‪‌⁬⁫‬⁬⁬‌⁫⁯‪⁯‌​‬⁬‮⁮⁬‬‫⁫​⁪‍‬⁯‬‏⁮‏‮()
    {
      return new ReaderWriterLockSlim();
    }

    static object \u206E‪⁭​‎‍‮​‫⁮⁪​⁮‮⁯‍⁬‍‎‮‌‍‎‬‍⁬‬⁪‮‏⁪‮‪‎‭⁭‌‍‎‮‮()
    {
      return new object();
    }

    static SynchronizationContext \u206B‬‭⁭‫⁯‏‎‬‪‪⁮‬⁪‍‍⁫‬‏⁫‏‬‍⁪‫‬‪⁯‪‫⁭⁬‎‍​‮⁮‮‌⁫‮()
    {
      return SynchronizationContext.Current;
    }

    static Delegate \u202D⁪‬‫⁮⁬‎⁫​⁬⁫‪‬⁭‌‭‬⁮‭‍‌⁪‏‪‬‪‏⁯​‌⁬‭‪‮​‮⁭⁫‎‎‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u200B‭‌⁪⁫⁭‎‬‬‌‬‫‏‍⁫⁮‮⁯⁬‪⁯⁬⁯‭‫‪‮⁬‮‪⁪⁮‪​‭‫⁫⁪‫‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static bool \u200F⁫⁭‌⁭‮⁭‬‭‮‬​⁪⁪⁮‍⁭⁭‮⁮‬‭⁮⁭⁮‪⁫⁪‮‬‬⁮‍⁯‬⁭‮‬‏‮‮([In] IList obj0)
    {
      return obj0.IsFixedSize;
    }

    static void \u202C⁫‭⁮‮‪⁭‪‎‪‮⁭‭⁮‫‮⁬⁪‫‮‪‪‮⁬⁮‌⁪‌​‍‪​‭‭⁫​⁪‏⁮‬‮([In] ReaderWriterLockSlim obj0)
    {
      obj0.EnterReadLock();
    }

    static object \u202E⁬‏​‍⁭‏⁪‌⁫‏‫‫⁯⁬​⁯‌⁫⁭⁪‪‌⁬⁪⁯‮⁭‌⁯‏​⁬‭⁪‪‍⁭‪‫‮([In] ICollection obj0)
    {
      return obj0.SyncRoot;
    }

    static void \u206A‏⁬⁪‭⁮⁯⁬‭‏‍⁭‭⁬‎⁫⁯‌‬‬‫​‎⁬‍⁬⁫‮⁫⁯‏‫​‍‬⁪‍‍‪‮([In] ReaderWriterLockSlim obj0)
    {
      obj0.ExitReadLock();
    }

    static void \u200F‭⁯‮‪‪‌‭‎‏‫⁫⁬‮‭‍⁯‎‭‮‮‭⁪‎⁫⁯⁬⁮‭‭‮‎⁭⁫‬⁭‌⁫‏‫‮([In] ReaderWriterLockSlim obj0)
    {
      obj0.EnterWriteLock();
    }

    static void \u206A‭‎​⁮‎‍‌⁯‏‮‏‫⁭⁫‌‎‬⁬‬‌⁬​‬⁯⁫‭‎‎‎⁯‌⁮‌⁬‍‫‏⁮‮‮([In] ReaderWriterLockSlim obj0)
    {
      obj0.ExitWriteLock();
    }

    static ArgumentException \u206F‮‬⁯‫‬‫‬‫‬⁪⁫‫‭‭‮‪‪‎⁮⁬⁮⁫⁯⁬​‬⁬⁭⁮‍‬‌‮‬‌‬⁭‍⁫‮([In] string obj0)
    {
      return new ArgumentException(obj0);
    }

    static ArgumentOutOfRangeException \u200D​‮⁫‭​‫⁭‭‫‌‪‮‫⁭⁪⁭⁬‮​⁭‏‭‏‭⁫‏‪⁯‏​‍‎⁫‮​‍‍‌⁮‮()
    {
      return new ArgumentOutOfRangeException();
    }

    static NotSupportedException \u202B⁭⁭‫‮​⁭‭​⁫‭‪‭⁬​‭‬‪⁬‍‌⁬⁪⁭‏‮⁬‫‫‍‪​​​‎‍⁫​‪‏‮([In] string obj0)
    {
      return new NotSupportedException(obj0);
    }

    static Delegate[] \u206A‮​‍‫⁮‬‫⁭⁯‭‫‪‭​‏‎‌‍⁪‭‮‭‌⁭‌‌⁫‌‪⁫⁮‬‍‏‫⁫⁫‍‎‮([In] Delegate obj0)
    {
      return obj0.GetInvocationList();
    }

    static InvalidOperationException \u202B⁭⁬⁮‏‫⁯​‍‭​‭‫⁬‍⁮‭⁮‌​‏‮‎‭⁭⁮⁭⁫‪⁭⁪​⁪⁯‫‬‏⁮​⁮‮([In] string obj0)
    {
      return new InvalidOperationException(obj0);
    }

    static PropertyChangedEventArgs \u206C‮⁮‎​⁪‬‌⁭​‮‌‎⁮​⁫​‪⁬‬⁬⁫‎‮‬⁪‬‮⁯‮​‭‎‮‎⁮⁪​⁪⁮‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }

    static NotifyCollectionChangedEventArgs \u206B‮‎‏⁭⁭⁮‭⁪‪‪⁬‭‍⁮‪⁮⁬⁬​​‮⁪⁮‭‮⁮⁮⁫⁮‌‪⁭‎‌⁭‏⁫⁪‌‮([In] NotifyCollectionChangedAction obj0, [In] object obj1, [In] int obj2)
    {
      return new NotifyCollectionChangedEventArgs(obj0, obj1, obj2);
    }

    static NotifyCollectionChangedEventArgs \u200C‏⁫‫‌⁬⁫‎‭‏‌‏⁭‭‪⁬⁮​‌⁮⁯‭⁬‪⁯​‎​‌⁮‍‬‏‭⁭‌⁫‪‭‬‮([In] NotifyCollectionChangedAction obj0, [In] object obj1, [In] int obj2, [In] int obj3)
    {
      return new NotifyCollectionChangedEventArgs(obj0, obj1, obj2, obj3);
    }

    static NotifyCollectionChangedEventArgs \u200C‫‭‎‫‭‫‍⁬⁪⁫‎‪‏⁯‌‮​‪⁮‭‫⁫‮⁪‪⁬​‬‫‫‫‍‫⁯‮‬‭⁮‪‮([In] NotifyCollectionChangedAction obj0, [In] object obj1, [In] object obj2, [In] int obj3)
    {
      return new NotifyCollectionChangedEventArgs(obj0, obj1, obj2, obj3);
    }

    static void \u200C‪‮‏‮⁫⁭‎‍⁭‮⁫‌‎‬‬‫‏⁬⁯‫‏⁭‪⁭‍⁯‬‎​‪⁮‭‪‫⁫​‏‎⁯‮([In] SynchronizationContext obj0, [In] SendOrPostCallback obj1, [In] object obj2)
    {
      obj0.Send(obj1, obj2);
    }

    static void \u202C‫⁮⁪‍⁫‬‎⁭‮⁭⁯⁮⁮‏⁫‪⁯‪​‮‏⁬⁭‍‭⁪‮‬‎⁫⁪‪⁮‪‭‌⁮‫‬‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static NotifyCollectionChangedEventArgs \u206E⁪⁭‌⁮⁯⁪‍‫‭‪​​​‪‍⁯⁬⁪‬​⁯⁮⁯‮‍‎‎‫‫‎⁪‮⁪⁭‬‏‌⁯‪‮([In] NotifyCollectionChangedAction obj0)
    {
      return new NotifyCollectionChangedEventArgs(obj0);
    }

    static ArgumentNullException \u206B⁫⁫⁯‬‎‏⁭⁬⁬⁬‌⁪⁮‭⁮⁯⁮​‏‮⁫⁪⁮⁬‫⁯‬‏‎‬⁬‎‏‎‍‪⁭‏‬‮([In] string obj0, [In] string obj1)
    {
      return new ArgumentNullException(obj0, obj1);
    }

    static int \u202E⁮‫⁬‬‪​⁫⁪‪‭‪‌‏‮​‌‍‪‮‏‪⁫‏‮​‫⁭‎⁭‬‫‎‎‫‌‫‮‬‌‮([In] Array obj0)
    {
      return obj0.Rank;
    }

    static ArgumentException \u200D⁭‫​⁫‭‮‍⁪‎⁭‏‌‌‭‭‫‮‫‬⁪‪‭⁫‍‍⁭⁪​⁮⁮‭⁪‫⁬⁬‫⁪⁭⁫‮([In] string obj0, [In] string obj1)
    {
      return new ArgumentException(obj0, obj1);
    }

    static int \u206D‬⁫⁫⁬‬​⁭‎⁭⁪‎‎‬⁮⁮​‭‌⁪‮‌‏⁭‭​⁭‮‮⁬⁭‍⁬⁬⁭⁯‭⁭‍⁭‮([In] Array obj0, [In] int obj1)
    {
      return obj0.GetLowerBound(obj1);
    }

    static ArgumentOutOfRangeException \u206B​‫​‪​‍‫‏​‏⁬‪‎‎⁮‌‌‏‎⁮‫⁭​​​‌⁫‬‏‭‬‍⁬‮⁭‪​‍‭‮([In] string obj0, [In] string obj1)
    {
      return new ArgumentOutOfRangeException(obj0, obj1);
    }

    static int \u202B‮‮‎⁯‍‎‌⁫‮⁯‭⁬‬‮‬⁯‌⁯​⁮‫⁭⁭‎⁬⁮‮⁪⁮⁯‍‫‬‬⁪⁫​‏‮([In] Array obj0)
    {
      return obj0.Length;
    }

    static Type \u202B⁫⁮‪⁯‎⁪‪‍​‬‬⁪‭​⁪⁯‪‫‮‪‬‌‫⁬‪⁯‫‪‮‏‏​‏‏‭‮​⁬⁭‮([In] object obj0)
    {
      return obj0.GetType();
    }

    static Type \u200E‬‍​‮‫⁫⁬‭‍‏⁭‪⁬⁬⁯⁫‌​⁪‍⁮⁮⁯‭⁯‫⁮⁭⁭⁮⁬‭‭‭⁬⁮‬‪‍‮([In] Type obj0)
    {
      return obj0.GetElementType();
    }

    static Type \u202B​⁬⁫‪⁪‫‏⁭‬‎⁪‪‭‫⁭⁬‌‪‎‮⁬‍⁫‎‮⁪‭‫‎​‍⁪‫⁬‮‌‬‫⁮‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static bool \u202D​‪‌‮⁬‍⁮⁫⁬​‮‬⁯‎‏‍⁫‏‍‪‏‪‪‪‌‬‬⁫⁭‮‮⁫⁭‫⁮⁯⁮‫‌‮([In] Type obj0, [In] Type obj1)
    {
      return obj0.IsAssignableFrom(obj1);
    }

    static ArrayTypeMismatchException \u206B⁭⁯⁮‎⁪⁮⁪‮‮‬‫​⁬‮⁪‎⁯⁬⁬‏‌​‏⁪⁬‍⁫⁯⁫‫⁮⁪‭‏‪⁭‮‭‏‮([In] string obj0)
    {
      return new ArrayTypeMismatchException(obj0);
    }

    static void \u206D‫⁬⁬​⁬‭‮‬⁬‍‭‮⁫‮‍⁬‭⁫‏⁭​⁫⁯‪‫‭‫‫⁯‏⁭‌‭‪‮⁬‏⁮‌‮([In] ReaderWriterLockSlim obj0)
    {
      obj0.Dispose();
    }

    static IEnumerator \u206F‌⁭​⁭⁬‫⁭‎‍⁯⁮⁯‌‫‌‍‮‍⁬⁭‪⁯‎⁮⁯⁪‬​‬‏‬‮‭‏‭​​‏‎‮([In] IEnumerable obj0)
    {
      return obj0.GetEnumerator();
    }

    static void \u200B‪⁫​‍‍‪‪⁬⁪⁬‬‮‫‌⁪‮‫‎⁯‫‪‬‏‍⁯‭‍⁯‌‪‬‫‍‬‏⁪‎‎⁯‮([In] ReaderWriterLockSlim obj0)
    {
      obj0.EnterUpgradeableReadLock();
    }

    static void \u202A⁫‏‪‬‪⁮⁫⁪⁮‭‮‮‌‭‮⁮⁯​‮⁫‎‎⁪⁫‮⁪‪‍⁫‎⁭‫⁮‫⁭‫‪‪‌‮([In] ReaderWriterLockSlim obj0)
    {
      obj0.ExitUpgradeableReadLock();
    }

    private class SimpleMonitor : IDisposable
    {
      private int _busyCount;

      public bool Busy
      {
        get
        {
          bool flag = this._busyCount > 0;
label_1:
          int num1 = -992322390;
          while (true)
          {
            int num2 = -1417728827;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_1;
              case 1:
                num1 = (int) num3 * -201190765 ^ -437304291;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return flag;
        }
      }

      public void Enter()
      {
        this._busyCount = this._busyCount + 1;
      }

      public void Dispose()
      {
        this._busyCount = this._busyCount - 1;
      }
    }
  }
}
