// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.WindowSelectorViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;

namespace ZoomZoom.ViewModels
{
  public class WindowSelectorViewModel : ViewModelBase
  {
    private ZoomWindow _selectedWindow = (ZoomWindow) null;
    protected new readonly IEventAggregator _eventAggregator;

    public ZoomWindow SelectedWindow
    {
      get
      {
label_1:
        int num1 = -1080825434;
        ZoomWindow selectedWindow;
        while (true)
        {
          int num2 = -459102112;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * -389192352 ^ -790091040;
              continue;
            case 2:
              selectedWindow = this._selectedWindow;
              num1 = (int) num3 * -886124812 ^ -448406099;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return selectedWindow;
      }
      set
      {
label_1:
        int num1 = 987980637;
        while (true)
        {
          int num2 = 554029274;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              ((CompositePresentationEvent<ZoomWindow>) this._eventAggregator.GetEvent<WindowSelectedEvent>()).Publish(this._selectedWindow);
              num1 = (int) num3 * -813057108 ^ -707897933;
              continue;
            case 3:
              this._selectedWindow = value;
              num1 = (int) num3 * 1441504467 ^ 1205028569;
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

    public WindowSelectorViewModel(IEventAggregator eventAggregator)
    {
label_1:
      int num1 = -837997548;
      while (true)
      {
        int num2 = -731053197;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * 1508307842 ^ -2065142197;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this._eventAggregator = eventAggregator;
    }
  }
}
