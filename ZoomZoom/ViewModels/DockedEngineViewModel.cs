// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.DockedEngineViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using ZoomZoom.Models.Core;
using ZoomZoom.Models.Events;

namespace ZoomZoom.ViewModels
{
  public class DockedEngineViewModel : ViewModelBase
  {
    private TraceObject lastTraceObject = (TraceObject) null;
    private List<TraceObject> tracedEvents = (List<TraceObject>) null;
    public const string TraceObjectPropertyName = "TraceObject";
    public const string TracedEventsPropertyName = "TracedEvents";

    public TraceObject LastTraceObject
    {
      get
      {
label_1:
        int num1 = 1978599430;
        TraceObject lastTraceObject;
        while (true)
        {
          int num2 = 582858419;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              lastTraceObject = this.lastTraceObject;
              num1 = (int) num3 * -2128958053 ^ 1592933642;
              continue;
            case 2:
              num1 = (int) num3 * -13597083 ^ 1503814310;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return lastTraceObject;
      }
      set
      {
label_1:
        int num1 = 556882771;
        while (true)
        {
          int num2 = 234690409;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1003169338U));
              num1 = (int) num3 * -1066054967 ^ -650592072;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * 408289454 ^ -1661944815;
              continue;
            case 4:
              int num4 = this.lastTraceObject == value ? 1415030992 : (num4 = 674125020);
              int num5 = (int) num3 * -1406749431;
              num1 = num4 ^ num5;
              continue;
            case 5:
              this.lastTraceObject = value;
              num1 = 635992578;
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

    public List<TraceObject> TracedEvents
    {
      get
      {
        List<TraceObject> tracedEvents = this.tracedEvents;
label_1:
        int num1 = -38074860;
        while (true)
        {
          int num2 = -1098487298;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1675928151 ^ -1252386437;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return tracedEvents;
      }
      set
      {
label_1:
        int num1 = -21305744;
        while (true)
        {
          int num2 = -1633076214;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              int num4 = !flag ? -1616744879 : (num4 = -317334380);
              int num5 = (int) num3 * -125404772;
              num1 = num4 ^ num5;
              continue;
            case 1:
              goto label_3;
            case 2:
              num1 = (int) num3 * 567527771 ^ -952937059;
              continue;
            case 3:
              num1 = (int) num3 * 93468117 ^ 1381925824;
              continue;
            case 4:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3924944418U));
              num1 = (int) num3 * 1412126186 ^ 2119206862;
              continue;
            case 5:
              this.tracedEvents = value;
              num1 = -532366606;
              continue;
            case 6:
              goto label_1;
            case 7:
              num1 = (int) num3 * -145217426 ^ -523407959;
              continue;
            case 8:
              flag = this.tracedEvents == value;
              num1 = (int) num3 * 52748162 ^ -1335749322;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_3:;
      }
    }

    public DockedEngineViewModel()
    {
      this.TracedEvents = new List<TraceObject>();
      ((CompositePresentationEvent<TraceObject>) this._eventAggregator.GetEvent<TraceEvent>()).Subscribe(new Action<TraceObject>(this.TracedEvent), (ThreadOption) 1);
    }

    private void TracedEvent(TraceObject obj)
    {
      this.TracedEvents.Add(obj);
label_1:
      int num1 = -26579234;
      while (true)
      {
        int num2 = -871105518;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -1848651361 ^ 1795138069;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1075548814U));
            num1 = (int) num3 * 996250770 ^ 135051335;
            continue;
          case 4:
            this.LastTraceObject = obj;
            num1 = (int) num3 * -116289557 ^ 21851347;
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
}
