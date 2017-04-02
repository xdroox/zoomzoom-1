// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ApplicationService
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;

namespace ZoomZoom
{
  internal sealed class ApplicationService
  {
    private static readonly ApplicationService _instance = new ApplicationService();
    private IEventAggregator _eventAggregator;

    internal static ApplicationService Instance
    {
      get
      {
        ApplicationService instance = ApplicationService._instance;
label_1:
        int num1 = 503785669;
        while (true)
        {
          int num2 = 1843963099;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 620999356 ^ -287981953;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return instance;
      }
    }

    internal IEventAggregator EventAggregator
    {
      get
      {
label_1:
        int num1 = 951833479;
        IEventAggregator eventAggregator;
        while (true)
        {
          int num2 = 1124457396;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = !flag ? -505930859 : (num4 = -132729450);
              int num5 = (int) num3 * -1910874880;
              num1 = num4 ^ num5;
              continue;
            case 1:
              num1 = (int) num3 * 764223229 ^ 1275422488;
              continue;
            case 2:
              this._eventAggregator = (IEventAggregator) ApplicationService.\u206F‮‭​⁮⁭‬⁫‭⁫‭⁬⁯‫‌‍⁪⁯​⁪‬⁮⁯⁪⁭⁯‪⁫⁪⁪‎‭‎‌⁮​​⁫‍⁫‮();
              num1 = (int) num3 * 1757327472 ^ 1890652021;
              continue;
            case 3:
              eventAggregator = this._eventAggregator;
              num1 = 115199754;
              continue;
            case 5:
              flag = this._eventAggregator == null;
              num1 = (int) num3 * -109821823 ^ 117333125;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_8:
        return eventAggregator;
      }
    }

    private ApplicationService()
    {
    }

    static Microsoft.Practices.Prism.Events.EventAggregator \u206F‮‭​⁮⁭‬⁫‭⁫‭⁬⁯‫‌‍⁪⁯​⁪‬⁮⁯⁪⁭⁯‪⁫⁪⁪‎‭‎‌⁮​​⁫‍⁫‮()
    {
      return new Microsoft.Practices.Prism.Events.EventAggregator();
    }
  }
}
