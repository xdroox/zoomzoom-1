// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ObservableObject
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace ZoomZoom
{
  [DataContract]
  public class ObservableObject : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_1:
        int num1 = -596824611;
        while (true)
        {
          int num2 = -1295985786;
          uint num3;
          PropertyChangedEventHandler comparand;
          PropertyChangedEventHandler changedEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
              int num4 = changedEventHandler1 == comparand ? -504740482 : (num4 = -405752883);
              int num5 = (int) num3 * 1242392720;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_1;
            case 3:
              comparand = changedEventHandler1;
              num1 = -236200342;
              continue;
            case 4:
              changedEventHandler2 = (PropertyChangedEventHandler) ObservableObject.\u202E‮⁮‫‏‪‪‎⁫⁬‫⁭⁪‪‌⁫‪‮‬‮‮⁭‏‎‏‫‬⁬‬⁭⁪‍‏​‍‎⁮​‎‍‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1922795611 ^ -310275077;
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
        PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_1:
        int num1 = -1798986243;
        while (true)
        {
          int num2 = -1740116090;
          uint num3;
          PropertyChangedEventHandler comparand;
          PropertyChangedEventHandler changedEventHandler2;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              changedEventHandler2 = (PropertyChangedEventHandler) ObservableObject.\u202D‪‫⁭⁮⁫‍⁯⁫‫⁭‫‭‭‪⁭‌⁭⁬‭‪​​‫⁭‎​⁭⁮⁫‫⁬​⁮⁯⁪‏‪⁪⁭‮((Delegate) comparand, (Delegate) value);
              num1 = (int) num3 * 1371617753 ^ -463988790;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              comparand = changedEventHandler1;
              num1 = -664077236;
              continue;
            case 4:
              changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
              num1 = (int) num3 * 888419306 ^ -1355017599;
              continue;
            case 5:
              int num4 = changedEventHandler1 == comparand ? 161767259 : (num4 = 315264373);
              int num5 = (int) num3 * -114263016;
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
    }

    public ObservableObject()
    {
label_1:
      int num1 = 781371494;
      while (true)
      {
        int num2 = 361285761;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 1449957728 ^ -223423338;
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

    public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    {
      this.RaisePropertyChanged(ObservableObject.\u206D‭‬‬⁭‍‌‬‏⁭⁯⁫⁬‮‫​⁮‎‌⁭​⁭‮‎‌‬⁫⁬‪‭‪‪‬‎⁫⁮‍‍​⁭‮(propertyName));
label_1:
      int num1 = -1349897754;
      while (true)
      {
        int num2 = -1797275313;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -1157283848 ^ 564117630;
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

    protected virtual void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
      // ISSUE: reference to a compiler-generated field
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      bool flag = propertyChanged != null;
label_1:
      int num1 = -820109076;
      while (true)
      {
        int num2 = -1434171534;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            int num4 = !flag ? 185015360 : (num4 = 608011741);
            int num5 = (int) num3 * -286142041;
            num1 = num4 ^ num5;
            continue;
          case 2:
            propertyChanged((object) this, args);
            num1 = (int) num3 * 97317670 ^ -16116372;
            continue;
          case 3:
            num1 = (int) num3 * -1912703750 ^ -1112878094;
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

    public void RaiseAllPropertiesChanged()
    {
      this.RaisePropertyChanged(ObservableObject.\u206D‭‬‬⁭‍‌‬‏⁭⁯⁫⁬‮‫​⁮‎‌⁭​⁭‮‎‌‬⁫⁬‪‭‪‪‬‎⁫⁮‍‍​⁭‮(string.Empty));
    }

    public virtual bool Set<T>(string propertyName, ref T oldValue, T newValue)
    {
label_1:
      int num1 = 1035506475;
      bool flag1;
      while (true)
      {
        int num2 = 254165186;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * -1410115870 ^ 797418881;
            continue;
          case 1:
            flag2 = ObservableObject.\u200C‎⁪‬‭‍‪‏‪‭⁮‪​‭‮⁯⁫‌‎⁬‏⁮‭​‬‍‏​⁭⁬‎⁯⁪‬‭‮‭‎⁫‪‮((object) oldValue, (object) newValue);
            num1 = (int) num3 * -575568918 ^ 1295839094;
            continue;
          case 2:
            flag1 = false;
            num1 = (int) num3 * 297104392 ^ 245194542;
            continue;
          case 3:
            oldValue = newValue;
            this.RaisePropertyChanged(ObservableObject.\u206D‭‬‬⁭‍‌‬‏⁭⁯⁫⁬‮‫​⁮‎‌⁭​⁭‮‎‌‬⁫⁬‪‭‪‪‬‎⁫⁮‍‍​⁭‮(propertyName));
            flag1 = true;
            num1 = 716239209;
            continue;
          case 4:
            goto label_1;
          case 6:
            int num4 = !flag2 ? 1538984499 : (num4 = 891668013);
            int num5 = (int) num3 * 1647067006;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return flag1;
    }

    static Delegate \u202E‮⁮‫‏‪‪‎⁫⁬‫⁭⁪‪‌⁫‪‮‬‮‮⁭‏‎‏‫‬⁬‬⁭⁪‍‏​‍‎⁮​‎‍‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Combine(obj0, obj1);
    }

    static Delegate \u202D‪‫⁭⁮⁫‍⁯⁫‫⁭‫‭‭‪⁭‌⁭⁬‭‪​​‫⁭‎​⁭⁮⁫‫⁬​⁮⁯⁪‏‪⁪⁭‮([In] Delegate obj0, [In] Delegate obj1)
    {
      return Delegate.Remove(obj0, obj1);
    }

    static PropertyChangedEventArgs \u206D‭‬‬⁭‍‌‬‏⁭⁯⁫⁬‮‫​⁮‎‌⁭​⁭‮‎‌‬⁫⁬‪‭‪‪‬‎⁫⁮‍‍​⁭‮([In] string obj0)
    {
      return new PropertyChangedEventArgs(obj0);
    }

    static bool \u200C‎⁪‬‭‍‪‏‪‭⁮‪​‭‮⁯⁫‌‎⁬‏⁮‭​‬‍‏​⁭⁬‎⁯⁪‬‭‮‭‎⁫‪‮([In] object obj0, [In] object obj1)
    {
      return object.Equals(obj0, obj1);
    }
  }
}
