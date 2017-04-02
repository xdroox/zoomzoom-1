// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ImageHistoryViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using GalaSoft.MvvmLight;
using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using ZoomZoom.Common;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Images;
using ZoomZoom.Views;

namespace ZoomZoom.ViewModels
{
  public class ImageHistoryViewModel : ViewModelBase
  {
    private static readonly object imageLock = ImageHistoryViewModel.\u202D⁭‍‮‮⁬⁬​‭⁬‪‏⁮‍‏⁮‏‫‬‎‏‫⁫⁪‎‫‏⁬⁮‌‏‪⁬‎‏⁬⁯​⁫‮();
    private ImageHistoryView imageHistoryView = (ImageHistoryView) null;
    private int imageHeight = 0;
    private int imageWidth = 0;
    private bool noSource = false;
    private EngineView engineView = (EngineView) null;
    private ImageEnums.ImageType selectedImageType = ImageEnums.ImageType.Undefined;
    private List<string> imageTypes = new List<string>();
    private ObservableCollection<ZoomUser> users = (ObservableCollection<ZoomUser>) null;
    private ZoomUser selectedUser = (ZoomUser) null;
    private bool displayUserSelector = false;
    private ZoomImage pendingDisplayItem = (ZoomImage) null;
    private LockedObservableCollection<ZoomImage> images;
    private ZoomImage selectedImage;
    private string selectedUserName;

    public LockedObservableCollection<ZoomImage> Images
    {
      get
      {
label_1:
        int num1 = 76631086;
        LockedObservableCollection<ZoomImage> images;
        while (true)
        {
          int num2 = 94263181;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1223296093 ^ 671818556;
              continue;
            case 2:
              goto label_1;
            case 3:
              images = this.images;
              num1 = (int) num3 * -1248994234 ^ -27146857;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return images;
      }
      set
      {
label_1:
        int num1 = -904880587;
        while (true)
        {
          int num2 = -1050189128;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(448445442U));
              num1 = (int) num3 * 1607308618 ^ -707218985;
              continue;
            case 1:
              this.images = value;
              num1 = (int) num3 * -1376259359 ^ -1149876047;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public ZoomImage SelectedImage
    {
      get
      {
label_1:
        int num1 = -1647007225;
        ZoomImage selectedImage;
        while (true)
        {
          int num2 = -1691303646;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -477559076 ^ 2142804476;
              continue;
            case 1:
              selectedImage = this.selectedImage;
              num1 = (int) num3 * 361267030 ^ 755159072;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return selectedImage;
      }
      set
      {
label_1:
        int num1 = -933863405;
        while (true)
        {
          int num2 = -1594680830;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 13U)
          {
            case 0:
              num1 = (int) num3 * 41299055 ^ 405342583;
              continue;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1690702820U));
              num1 = -620636070;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = flag ? 425633285 : (num4 = 692583008);
              int num5 = (int) num3 * -1148991116;
              num1 = num4 ^ num5;
              continue;
            case 4:
              num1 = (int) num3 * -1506403261 ^ 1852027127;
              continue;
            case 5:
              goto label_3;
            case 6:
              this.DisplayUserSelector = this.selectedImage.ImageType == ImageEnums.ImageType.Video;
              num1 = (int) num3 * -1722048423 ^ -1501415626;
              continue;
            case 7:
              num1 = (int) num3 * -1815823266 ^ -1395211967;
              continue;
            case 8:
              this.SelectedUser = this.selectedImage.User;
              num1 = (int) num3 * 328781382 ^ 633104039;
              continue;
            case 9:
              num1 = (int) num3 * 1212306729 ^ 1814206503;
              continue;
            case 10:
              this.ImageHeight = this.selectedImage.ImageHeight;
              this.ImageWidth = this.selectedImage.ImageWidth;
              num1 = (int) num3 * -1119048487 ^ -1189923289;
              continue;
            case 11:
              this.selectedImage = value;
              flag = this.selectedImage != null;
              num1 = (int) num3 * -2014246598 ^ -1873463672;
              continue;
            case 12:
              num1 = (int) num3 * 1270551668 ^ 511693688;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_3:;
      }
    }

    public ImageHistoryView ImageHistoryView
    {
      get
      {
label_1:
        int num1 = -915849029;
        ImageHistoryView imageHistoryView;
        while (true)
        {
          int num2 = -657633193;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              imageHistoryView = this.imageHistoryView;
              num1 = (int) num3 * -1608158376 ^ 736749695;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return imageHistoryView;
      }
      set
      {
        this.imageHistoryView = value;
label_1:
        int num1 = -26494912;
        while (true)
        {
          int num2 = -405682904;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3668243264U));
              num1 = (int) num3 * 1688854033 ^ 1915726758;
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

    public int ImageHeight
    {
      get
      {
        int imageHeight = this.imageHeight;
label_1:
        int num1 = 399362505;
        while (true)
        {
          int num2 = 762191041;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -2051361108 ^ -163662389;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return imageHeight;
      }
      set
      {
        this.imageHeight = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(567152199U));
      }
    }

    public int ImageWidth
    {
      get
      {
label_1:
        int num1 = 263489912;
        int imageWidth;
        while (true)
        {
          int num2 = 910784877;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              imageWidth = this.imageWidth;
              num1 = (int) num3 * 117544758 ^ -1882315384;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return imageWidth;
      }
      set
      {
label_1:
        int num1 = -1453370087;
        while (true)
        {
          int num2 = -69785936;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.imageWidth = value;
              num1 = (int) num3 * 1078499527 ^ 1077342064;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3713518017U));
      }
    }

    public bool NoSource
    {
      get
      {
        bool noSource = this.noSource;
label_1:
        int num1 = 1734957463;
        while (true)
        {
          int num2 = 316708444;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1925400856 ^ -1863302564;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return noSource;
      }
      set
      {
        this.noSource = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2355623115U));
      }
    }

    public EngineView EngineView
    {
      get
      {
label_1:
        int num1 = 472851831;
        EngineView engineView;
        while (true)
        {
          int num2 = 199176250;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1788922897 ^ -944231036;
              continue;
            case 1:
              engineView = this.engineView;
              num1 = (int) num3 * -357574301 ^ -7602523;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return engineView;
      }
      set
      {
        this.engineView = value;
      }
    }

    public List<string> ImageTypes
    {
      get
      {
label_1:
        int num1 = 417465835;
        List<string> imageTypes;
        while (true)
        {
          int num2 = 1613007468;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -305306962 ^ 1842534453;
              continue;
            case 2:
              goto label_1;
            case 3:
              imageTypes = this.imageTypes;
              num1 = (int) num3 * -2007070449 ^ -1530247583;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return imageTypes;
      }
      set
      {
        this.imageTypes = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2661765537U));
      }
    }

    public ImageEnums.ImageType SelectedImageType
    {
      get
      {
label_1:
        int num1 = -189170753;
        ImageEnums.ImageType selectedImageType;
        while (true)
        {
          int num2 = -906731376;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 517584101 ^ 472608459;
              continue;
            case 3:
              selectedImageType = this.selectedImageType;
              num1 = (int) num3 * 566797292 ^ 1779505182;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return selectedImageType;
      }
      set
      {
label_1:
        int num1 = 1732590254;
        while (true)
        {
          int num2 = 191386878;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.LoadImages((object) null);
              num1 = (int) num3 * -838572264 ^ 1248816679;
              continue;
            case 3:
              this.selectedImageType = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(274853336U));
              num1 = (int) num3 * -1198259428 ^ -1241271854;
              continue;
            case 4:
              num1 = (int) num3 * 1939281171 ^ -39073905;
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

    public ObservableCollection<ZoomUser> Users
    {
      get
      {
label_1:
        int num1 = -937392489;
        ObservableCollection<ZoomUser> users;
        while (true)
        {
          int num2 = -1939658024;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              users = this.users;
              num1 = (int) num3 * -1726875308 ^ 1046250726;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return users;
      }
      set
      {
        this.users = value;
      }
    }

    public ZoomUser SelectedUser
    {
      get
      {
label_1:
        int num1 = 389288245;
        ZoomUser selectedUser;
        while (true)
        {
          int num2 = 276141100;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              selectedUser = this.selectedUser;
              num1 = (int) num3 * 838496877 ^ 1165415619;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedUser;
      }
      set
      {
label_1:
        int num1 = -1558840424;
        while (true)
        {
          int num2 = -76738469;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1536206814U));
              num1 = -1380088602;
              continue;
            case 1:
              this.SelectedUserName = "";
              num1 = (int) num3 * -1311357805 ^ -771905346;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.selectedUser = value;
              num1 = (int) num3 * -983783344 ^ 426891740;
              continue;
            case 4:
              this.selectedUserName = this.selectedUser.UserName;
              num1 = -1919883357;
              continue;
            case 5:
              goto label_3;
            case 6:
              num1 = (int) num3 * 236694092 ^ 208366603;
              continue;
            case 7:
              int num4 = this.selectedUser == null ? -1610374404 : (num4 = -515551247);
              int num5 = (int) num3 * -28026846;
              num1 = num4 ^ num5;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    public string SelectedUserName
    {
      get
      {
        string selectedUserName = this.selectedUserName;
label_1:
        int num1 = 678505354;
        while (true)
        {
          int num2 = 1388609184;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -621058274 ^ -1352329642;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedUserName;
      }
      set
      {
label_1:
        int num1 = 1893625974;
        while (true)
        {
          int num2 = 1163226075;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.selectedUserName = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3707988067U));
              num1 = (int) num3 * -120358602 ^ 669747706;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 1685545252 ^ -644222553;
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

    public bool DisplayUserSelector
    {
      get
      {
label_1:
        int num1 = 129721685;
        bool displayUserSelector;
        while (true)
        {
          int num2 = 1717323325;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              displayUserSelector = this.displayUserSelector;
              num1 = (int) num3 * -1081121107 ^ -1637748279;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return displayUserSelector;
      }
      set
      {
label_1:
        int num1 = 1804004742;
        while (true)
        {
          int num2 = 1646616873;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1003393363 ^ -1540924880;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.displayUserSelector = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2819724597U));
              num1 = (int) num3 * -446534398 ^ 1713037930;
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

    public ImageHistoryViewModel(IEventAggregator eventAggregator)
    {
      ImageHistoryViewModel.\u200D​‮‎⁮‎⁮‭‭‍‍‪‮⁮‪‎⁫‬‎‍‭‭‮‬‍‏⁯‮‍‍⁫⁫⁯⁮⁭‍‪⁪‎‮(ViewModelBase.log, (object) \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(849316307U));
      ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<ImageCapturedEvent>()).Subscribe(new Action<ZoomImage>(this.AddCapturedImage), (ThreadOption) 1);
      this.Engine = Engine.Instance;
      this.Images = new LockedObservableCollection<ZoomImage>();
      this.Users = new ObservableCollection<ZoomUser>();
      if (ImageHistoryViewModel.\u206C⁯‭‭‪⁭‌‫‫‎‏‮‌⁯​‌‏‬‍⁮⁮​⁫⁭⁭​⁫‫‍​⁭‬‮​‬⁯‮‍‫‏‮((ViewModelBase) this))
      {
        ZoomImage zoomImage = new ZoomImage(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2602678733U));
        ((Collection<ZoomImage>) this.Images).Add(zoomImage);
        this.SelectedImage = zoomImage;
      }
      else
      {
        ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<ImageDisplayEvent>()).Subscribe(new Action<ZoomImage>(this.DisplayImage), (ThreadOption) 1);
        ((CompositePresentationEvent<List<ZoomImage>>) this._eventAggregator.GetEvent<ImagesDisplayEvent>()).Subscribe(new Action<List<ZoomImage>>(this.DisplayImages), (ThreadOption) 1);
        ((CompositePresentationEvent<ZoomChat>) this._eventAggregator.GetEvent<ChatSentEvent>()).Subscribe(new Action<ZoomChat>(this.AddUserFromChat), (ThreadOption) 1);
        ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.UserAdded), (ThreadOption) 1, false, (Predicate<ObjectChangedEventPayload>) (obj =>
        {
label_1:
          int num1 = 1769160121;
          bool flag;
          while (true)
          {
            int num2 = 510782382;
            uint num3;
            int num4;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                num4 = obj.ChangeType == ChangeType.Added ? 1 : 0;
                break;
              case 2:
                goto label_1;
              case 3:
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (ImageHistoryViewModel.\u003C\u003Ec.\u202C​‎‫‍‪⁯‏‪‫‬⁭⁫‍⁯⁬‫⁬‫‏​‮⁪⁭⁫⁬⁬‏⁪⁭‪‌‏‮‬‫⁭‏⁮⁭‮(obj.ObjectType, ImageHistoryViewModel.\u003C\u003Ec.\u200E‌​‌​⁬⁮‫‍‫‮‭⁯‍‫‮‏‭⁪⁯‍‬‭⁯⁪‮‌⁪​‪‌⁪⁯‫‏‮‫⁫⁮⁪‮(__typeref (ZoomUser))))
                {
                  num1 = (int) num3 * 126122325 ^ -941836963;
                  continue;
                }
                num4 = 0;
                break;
              default:
                goto label_8;
            }
            flag = num4 != 0;
            num1 = 1015503003;
          }
label_8:
          return flag;
        }));
        this.LoadCommands();
      }
      this.LoadImageTypes();
    }

    ~ImageHistoryViewModel()
    {
      try
      {
        ((CompositePresentationEvent<ZoomImage>) this._eventAggregator.GetEvent<ImageCapturedEvent>()).Unsubscribe(new Action<ZoomImage>(this.AddCapturedImage));
      }
      finally
      {
        // ISSUE: explicit finalizer call
        // ISSUE: explicit non-virtual call
        __nonvirtual (((object) this).Finalize());
label_3:
        int num1 = 147739767;
        while (true)
        {
          int num2 = 1434870803;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 242895955 ^ 318981996;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:;
      }
    }

    internal void DisplayView()
    {
label_1:
      int num1 = 754070918;
      while (true)
      {
        int num2 = 363397512;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -83439341 ^ 1061005743;
            continue;
          case 2:
            this.ShowView();
            num1 = (int) num3 * -2030397474 ^ -1927492147;
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

    private void AddUserFromChat(ZoomChat obj)
    {
label_1:
      int num1 = 961168437;
      object modelLock;
      ZoomUser user1;
      ZoomUser user2;
      while (true)
      {
        int num2 = 1524459546;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            user1 = this.Engine.GetUser(obj.ReceivingZoomId, false);
            user2 = this.Engine.GetUser(obj.SendingZoomId, false);
            num1 = (int) num3 * 1642335198 ^ 1082690901;
            continue;
          case 1:
            if (obj != null)
            {
              num1 = (int) num3 * 435019332 ^ 1528658115;
              continue;
            }
            goto label_34;
          case 3:
            goto label_1;
          case 4:
            modelLock = ViewModelBase.modelLock;
            num1 = (int) num3 * -1677029894 ^ 1419740461;
            continue;
          default:
            goto label_7;
        }
      }
label_34:
      return;
label_7:
      bool flag1 = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock, ref flag1);
label_9:
        int num2 = 1013098101;
        while (true)
        {
          int num3 = 1524459546;
          uint num4;
          bool flag2;
          int num5;
          int num6;
          switch ((num4 = (uint) (num2 ^ num3)) % 16U)
          {
            case 0:
              num5 = !((Collection<ZoomUser>) this.Users).Contains(user1) ? 1 : 0;
              break;
            case 1:
              if (user2 == null)
              {
                num6 = 0;
                goto label_28;
              }
              else
              {
                num2 = (int) num4 * -2012686422 ^ -1280990054;
                continue;
              }
            case 2:
              ((Collection<ZoomUser>) this.Users).Add(user1);
              num2 = (int) num4 * 1283706838 ^ 20851752;
              continue;
            case 3:
              num2 = (int) num4 * 290871166 ^ -68922647;
              continue;
            case 4:
              num2 = 1139754054;
              continue;
            case 5:
              ((Collection<ZoomUser>) this.Users).Add(user2);
              num2 = (int) num4 * -549274447 ^ -691573508;
              continue;
            case 6:
              int num7 = flag2 ? -2141390809 : (num7 = -138558924);
              int num8 = (int) num4 * -1926116559;
              num2 = num7 ^ num8;
              continue;
            case 7:
              num2 = (int) num4 * -1021668220 ^ 783504066;
              continue;
            case 8:
              if (user1 == null)
              {
                num5 = 0;
                break;
              }
              num2 = 1811840026;
              continue;
            case 9:
              num2 = (int) num4 * 1080068529 ^ 823931835;
              continue;
            case 10:
              num6 = !((Collection<ZoomUser>) this.Users).Contains(user2) ? 1 : 0;
              goto label_28;
            case 11:
              num2 = (int) num4 * 1296343614 ^ -1555713355;
              continue;
            case 13:
              goto label_9;
            case 14:
              num2 = (int) num4 * -1413967416 ^ -1046699859;
              continue;
            case 15:
              num2 = (int) num4 * 2061222260 ^ -1056989129;
              continue;
            default:
              goto label_38;
          }
          int num9;
          num2 = num9 = num5 == 0 ? 1705318494 : (num9 = 408904584);
          continue;
label_28:
          flag2 = num6 != 0;
          num2 = 1525040044;
        }
      }
      finally
      {
        if (flag1)
        {
label_32:
          int num2 = 721270743;
          while (true)
          {
            int num3 = 1524459546;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 498727211 ^ 850298321;
                continue;
              case 1:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock);
                num2 = (int) num4 * -112154128 ^ 844295042;
                continue;
              case 2:
                goto label_32;
              default:
                goto label_37;
            }
          }
        }
label_37:;
      }
label_38:;
    }

    private void UserAdded(ObjectChangedEventPayload obj)
    {
      if (obj == null)
        return;
label_1:
      int num1 = 81599280;
      ZoomUser changedObject;
      object modelLock;
      while (true)
      {
        int num2 = 1969658829;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            modelLock = ViewModelBase.modelLock;
            num1 = (int) num3 * -240373392 ^ 2108131274;
            continue;
          case 2:
            changedObject = obj.ChangedObject as ZoomUser;
            num1 = (int) num3 * -378040307 ^ -508271240;
            continue;
          case 3:
            num1 = (int) num3 * -29815892 ^ 1999558181;
            continue;
          case 5:
            if (changedObject != null)
            {
              num1 = (int) num3 * -1525587859 ^ -432420581;
              continue;
            }
            goto label_31;
          case 6:
            num1 = (int) num3 * 1528073301 ^ 1053861355;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      bool flag1 = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock, ref flag1);
label_11:
        int num2 = 788211659;
        while (true)
        {
          int num3 = 1969658829;
          uint num4;
          bool flag2;
          switch ((num4 = (uint) (num2 ^ num3)) % 8U)
          {
            case 0:
              goto label_11;
            case 1:
              int num5 = flag2 ? 138602812 : (num5 = 1363809344);
              int num6 = (int) num4 * 1373372562;
              num2 = num5 ^ num6;
              continue;
            case 2:
              num2 = (int) num4 * 98194110 ^ 996528398;
              continue;
            case 3:
              num2 = (int) num4 * 287874174 ^ -1512949726;
              continue;
            case 5:
              ((Collection<ZoomUser>) this.Users).Add(changedObject);
              num2 = (int) num4 * -221340193 ^ -721313708;
              continue;
            case 6:
              flag2 = !((Collection<ZoomUser>) this.Users).Contains(changedObject);
              num2 = (int) num4 * -423846319 ^ -1570032534;
              continue;
            case 7:
              num2 = 813364009;
              continue;
            default:
              goto label_27;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_21:
          int num2 = 1681128930;
          while (true)
          {
            int num3 = 1969658829;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_21;
              case 2:
                num2 = (int) num4 * 738699284 ^ 351840160;
                continue;
              case 3:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock);
                num2 = (int) num4 * -1051161291 ^ 1682441096;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
label_27:
label_28:
      int num7 = 212577935;
label_29:
      int num8 = 1969658829;
      uint num9;
      switch ((num9 = (uint) (num7 ^ num8)) % 3U)
      {
        case 0:
          goto label_28;
        case 1:
          break;
        case 2:
          return;
        default:
          return;
      }
label_31:
      num7 = 683105278;
      goto label_29;
    }

    private void LoadImageTypes()
    {
label_1:
      int num1 = 799258159;
      object modelLock;
      while (true)
      {
        int num2 = 1401305794;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            modelLock = ViewModelBase.modelLock;
            num1 = (int) num3 * 2047997785 ^ -871252645;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock, ref flag);
label_6:
        int num2 = 980899932;
        while (true)
        {
          int num3 = 1401305794;
          uint num4;
          int index;
          string[] strArray;
          string str;
          switch ((num4 = (uint) (num2 ^ num3)) % 14U)
          {
            case 0:
              num2 = (int) num4 * -247165303 ^ 1335972088;
              continue;
            case 1:
              // ISSUE: type reference
              strArray = ImageHistoryViewModel.\u206B‍​⁫‬⁫‫‮‌‮⁭‪‭⁮⁫⁮‎‏​⁬​​⁬⁬‭‎‎‏‌⁯‌‬⁪‍‬‫‌⁯‫‌‮(ImageHistoryViewModel.\u202C⁯‭​‪‪‫​​‍⁫⁬‎⁬‭‏‌⁬‪⁫⁭‮‌‪⁭⁬‍‫‍⁭‌⁯⁫⁫⁯​⁫​‪⁫‮(__typeref (ImageEnums.ImageType)));
              index = 0;
              num2 = (int) num4 * -240298298 ^ -1361543217;
              continue;
            case 2:
              int num5;
              num2 = num5 = index >= strArray.Length ? 1789450824 : (num5 = 1782434507);
              continue;
            case 3:
              ++index;
              num2 = (int) num4 * -1580240979 ^ 584510615;
              continue;
            case 4:
              this.ImageTypes.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1098299006U));
              num2 = (int) num4 * 1466139191 ^ -179262353;
              continue;
            case 5:
              this.ImageTypes.Clear();
              num2 = (int) num4 * -2060234318 ^ 597247693;
              continue;
            case 6:
              this.ImageTypes.Add(ImageHistoryViewModel.\u200D‬⁫‪‍⁬‫⁯‪⁬‪⁯⁪⁯⁪‪‭‏‏‫‮⁫⁯‏⁭⁫‍‬‍‭‎‬‪⁫‌‫‫​‫‫‮((object) str));
              num2 = (int) num4 * -46412529 ^ 2146421233;
              continue;
            case 7:
              str = strArray[index];
              num2 = 1794940218;
              continue;
            case 9:
              num2 = (int) num4 * 338086392 ^ 1342200576;
              continue;
            case 10:
              num2 = (int) num4 * 465301828 ^ 411142517;
              continue;
            case 11:
              num2 = (int) num4 * -1334389716 ^ -1289553854;
              continue;
            case 12:
              goto label_6;
            case 13:
              num2 = (int) num4 * -1808526779 ^ 526081112;
              continue;
            default:
              goto label_26;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_21:
          int num2 = 1537356268;
          while (true)
          {
            int num3 = 1401305794;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_21;
              case 2:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock);
                num2 = (int) num4 * 1379312755 ^ -1427350515;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:
      this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2625509734U));
label_27:
      int num6 = 1195146566;
      while (true)
      {
        int num2 = 1401305794;
        uint num3;
        switch ((num3 = (uint) (num6 ^ num2)) % 3U)
        {
          case 0:
            goto label_27;
          case 1:
            num6 = (int) num3 * 1241308033 ^ -1915767253;
            continue;
          case 2:
            goto label_29;
          default:
            goto label_23;
        }
      }
label_23:
      return;
label_29:;
    }

    private void DisplayImages(List<ZoomImage> images)
    {
      try
      {
        this.SelectedImage = (ZoomImage) null;
label_2:
        int num1 = -1733825743;
        object modelLock;
        while (true)
        {
          int num2 = -1086554424;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              modelLock = ViewModelBase.modelLock;
              num1 = (int) num3 * 1739337774 ^ -2013366757;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        bool flag1 = false;
        try
        {
          ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock, ref flag1);
label_7:
          int num2 = -1977082539;
          while (true)
          {
            int num3 = -1086554424;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_7;
              case 1:
                num2 = (int) num4 * -1077822860 ^ -1437482114;
                continue;
              case 2:
                num2 = (int) num4 * -1732567811 ^ -1876123595;
                continue;
              default:
                goto label_11;
            }
          }
label_11:
          using (List<ZoomImage>.Enumerator enumerator = images.GetEnumerator())
          {
label_16:
            int num3 = enumerator.MoveNext() ? -1526604548 : (num3 = -1315242724);
            while (true)
            {
              int num4 = -1086554424;
              uint num5;
              ZoomImage current;
              bool flag2;
              switch ((num5 = (uint) (num3 ^ num4)) % 17U)
              {
                case 0:
                  num3 = -1526604548;
                  continue;
                case 1:
                  num3 = (int) num5 * -871016863 ^ -1940628058;
                  continue;
                case 2:
                  this.SelectedImage = current;
                  num3 = (int) num5 * 2021170839 ^ 1842065666;
                  continue;
                case 3:
                  int num6 = ((Collection<ZoomImage>) this.Images).Contains(current) ? -871754619 : (num6 = -1451901637);
                  int num7 = (int) num5 * -496179411;
                  num3 = num6 ^ num7;
                  continue;
                case 4:
                  goto label_16;
                case 5:
                  num3 = (int) num5 * -1052945173 ^ 1206320849;
                  continue;
                case 6:
                  int num8;
                  num3 = num8 = this.SelectedImage.ImageHeight < current.ImageHeight ? -1151632011 : (num8 = -1928059819);
                  continue;
                case 7:
                  num3 = (int) num5 * -1152254538 ^ 1553695883;
                  continue;
                case 8:
                  ((Collection<ZoomImage>) this.Images).Add(current);
                  num3 = (int) num5 * -334407391 ^ 1239541291;
                  continue;
                case 9:
                  int num9 = flag2 ? -1016841521 : (num9 = -1419670228);
                  int num10 = (int) num5 * -457490810;
                  num3 = num9 ^ num10;
                  continue;
                case 10:
                  this.SelectedImage = current;
                  num3 = (int) num5 * 1163694754 ^ 1196202267;
                  continue;
                case 11:
                  num3 = (int) num5 * -1307035379 ^ -88334112;
                  continue;
                case 12:
                  current = enumerator.Current;
                  num3 = -2005478212;
                  continue;
                case 14:
                  num3 = -607775537;
                  continue;
                case 15:
                  flag2 = this.SelectedImage == null;
                  num3 = -409964483;
                  continue;
                case 16:
                  num3 = (int) num5 * -1327717515 ^ -900890740;
                  continue;
                default:
                  goto label_37;
              }
            }
          }
        }
        finally
        {
          if (flag1)
          {
label_32:
            int num2 = -2035601002;
            while (true)
            {
              int num3 = -1086554424;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_32;
                case 1:
                  num2 = (int) num4 * -981424617 ^ -174362548;
                  continue;
                case 2:
                  ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock);
                  num2 = (int) num4 * -1474093780 ^ 573027849;
                  continue;
                default:
                  goto label_36;
              }
            }
          }
label_36:;
        }
label_37:
        this.ShowView();
label_38:
        int num11 = -75973497;
        while (true)
        {
          int num2 = -1086554424;
          uint num3;
          switch ((num3 = (uint) (num11 ^ num2)) % 3U)
          {
            case 0:
              goto label_38;
            case 1:
              num11 = (int) num3 * 1777232193 ^ 1616410440;
              continue;
            case 2:
              goto label_48;
            default:
              goto label_46;
          }
        }
label_46:
        return;
label_48:;
      }
      catch (Exception ex)
      {
        ImageHistoryViewModel.\u200E‭⁫‌‏⁬⁪⁪⁬⁭⁯⁫‪⁭‪‏‪‎⁮‭​⁭‍⁪⁫‍⁫‏​⁭⁪‍⁪‌​⁬⁯⁭⁭‌‮(ViewModelBase.log, (object) ex);
label_44:
        int num1 = -1210806441;
        while (true)
        {
          int num2 = -1086554424;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_44;
            case 1:
              num1 = (int) num3 * -2122860779 ^ 1955976331;
              continue;
            case 2:
              goto label_42;
            default:
              goto label_40;
          }
        }
label_40:
        return;
label_42:;
      }
    }

    private void DisplayImage(ZoomImage obj)
    {
      if (obj.ImageHeight <= 0)
        goto label_8;
label_1:
      int num1 = 582868087;
label_2:
      object imageLock;
      bool flag1;
      while (true)
      {
        int num2 = 631642698;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 2:
            imageLock = ImageHistoryViewModel.imageLock;
            num1 = (int) num3 * 1986478563 ^ 265039853;
            continue;
          case 3:
            num1 = (int) num3 * 1144557179 ^ -113373087;
            continue;
          case 4:
            if (flag1)
            {
              num1 = (int) num3 * -769317312 ^ -323814293;
              continue;
            }
            goto label_29;
          case 5:
            goto label_7;
          default:
            goto label_10;
        }
      }
label_29:
      return;
label_7:
      int num4 = obj.ImageWidth > 0 ? 1 : 0;
      goto label_9;
label_10:
      bool flag2 = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(imageLock, ref flag2);
label_12:
        int num2 = 707014260;
        while (true)
        {
          int num3 = 631642698;
          uint num5;
          bool flag3;
          switch ((num5 = (uint) (num2 ^ num3)) % 7U)
          {
            case 0:
              ((Collection<ZoomImage>) this.Images).Insert(0, obj);
              num2 = (int) num5 * -300670875 ^ 1038968354;
              continue;
            case 1:
              num2 = (int) num5 * 1934003334 ^ -1861387072;
              continue;
            case 3:
              num2 = (int) num5 * 1594851170 ^ -2058568166;
              continue;
            case 4:
              goto label_12;
            case 5:
              int num6 = flag3 ? -170711784 : (num6 = -70623390);
              int num7 = (int) num5 * 1141054670;
              num2 = num6 ^ num7;
              continue;
            case 6:
              flag3 = !((Collection<ZoomImage>) this.Images).Contains(obj);
              num2 = (int) num5 * 2075982518 ^ 1808531936;
              continue;
            default:
              goto label_26;
          }
        }
      }
      finally
      {
        if (flag2)
        {
label_21:
          int num2 = 392756639;
          while (true)
          {
            int num3 = 631642698;
            uint num5;
            switch ((num5 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_21;
              case 1:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(imageLock);
                num2 = (int) num5 * -1761201479 ^ 791814696;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:
      if (this.Engine.Settings.AutoCaptureVideoImages)
        goto label_31;
label_27:
      int num8 = 2030022803;
label_28:
      bool flag4;
      while (true)
      {
        int num2 = 631642698;
        uint num3;
        bool flag3;
        switch ((num3 = (uint) (num8 ^ num2)) % 15U)
        {
          case 0:
            goto label_27;
          case 1:
            this.SelectedImage = this.pendingDisplayItem;
            num8 = (int) num3 * -1158486076 ^ 433607962;
            continue;
          case 2:
            this.pendingDisplayItem = obj;
            num8 = 1070704078;
            continue;
          case 3:
            num8 = (int) num3 * 435157614 ^ 1543057239;
            continue;
          case 4:
            flag3 = this.pendingDisplayItem != null;
            num8 = (int) num3 * -360185524 ^ -94689698;
            continue;
          case 5:
            num8 = (int) num3 * 1683491068 ^ 568571553;
            continue;
          case 6:
            num8 = 79965763;
            continue;
          case 7:
            int num5 = !flag3 ? 93132882 : (num5 = 58727024);
            int num6 = (int) num3 * 941924710;
            num8 = num5 ^ num6;
            continue;
          case 8:
            num8 = (int) num3 * 552082651 ^ 1049799224;
            continue;
          case 9:
            num8 = 458605818;
            continue;
          case 10:
            int num7 = flag4 ? 747761351 : (num7 = 690034712);
            int num9 = (int) num3 * -842767713;
            num8 = num7 ^ num9;
            continue;
          case 11:
            num8 = (int) num3 * 537826817 ^ -722860457;
            continue;
          case 12:
            goto label_23;
          case 13:
            this.SelectedImage = obj;
            num8 = (int) num3 * -916646602 ^ 1296687877;
            continue;
          case 14:
            goto label_30;
          default:
            goto label_19;
        }
      }
label_19:
      return;
label_23:
      return;
label_30:
      int num10 = this.Engine.Settings.AutoSpotlightEnabled ? 1 : 0;
      goto label_32;
label_31:
      num10 = 1;
label_32:
      flag4 = num10 != 0;
      num8 = 1408136871;
      goto label_28;
label_8:
      num4 = 0;
label_9:
      flag1 = num4 != 0;
      num1 = 89870068;
      goto label_2;
    }

    internal void Initialize(EngineView engineView)
    {
label_1:
      int num1 = 535293126;
      while (true)
      {
        int num2 = 1399660171;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * 1927778065 ^ 448514420;
            continue;
          case 1:
            this.EngineView = engineView;
            num1 = (int) num3 * -662701596 ^ 1019367983;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void LoadImages(object obj)
    {
      object imageLock1 = ImageHistoryViewModel.imageLock;
      bool flag1 = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(imageLock1, ref flag1);
label_2:
        int num1 = -413759086;
        while (true)
        {
          int num2 = -2069577216;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_2;
            case 2:
              num1 = (int) num3 * 1823107930 ^ -513004582;
              continue;
            case 3:
              num1 = (int) num3 * 376460579 ^ -252135497;
              continue;
            case 4:
              ((Collection<ZoomImage>) this.Images).Clear();
              num1 = (int) num3 * 1079355484 ^ -1150830101;
              continue;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_8:
          int num1 = -1904799075;
          while (true)
          {
            int num2 = -2069577216;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(imageLock1);
                num1 = (int) num3 * -1512028562 ^ -1694682451;
                continue;
              case 2:
                goto label_8;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
label_12:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      List<ZoomImage>.Enumerator enumerator = ((IEnumerable<ZoomImage>) Enumerable.OrderByDescending<ZoomImage, DateTime>((IEnumerable<M0>) this.Engine.GetImages(this.SelectedImageType), (Func<M0, M1>) (ImageHistoryViewModel.\u003C\u003Ec.\u003C\u003E9__63_0 ?? (ImageHistoryViewModel.\u003C\u003Ec.\u003C\u003E9__63_0 = new Func<ZoomImage, DateTime>((object) ImageHistoryViewModel.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CLoadImages\u003Eb__63_0)))))).ToList<ZoomImage>().GetEnumerator();
      try
      {
label_54:
        uint num1;
        if (enumerator.MoveNext())
        {
label_16:
          ZoomImage current = enumerator.Current;
          int num2 = -183015366;
          while (true)
          {
            int num3 = -2069577216;
            switch ((num1 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                num2 = -2048930213;
                continue;
              case 2:
                goto label_16;
              default:
                goto label_17;
            }
          }
label_17:
          object imageLock2 = ImageHistoryViewModel.imageLock;
          bool flag2 = false;
          try
          {
            ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(imageLock2, ref flag2);
label_19:
            int num3 = -1517106567;
            while (true)
            {
              int num4 = -2069577216;
              uint num5;
              switch ((num5 = (uint) (num3 ^ num4)) % 4U)
              {
                case 0:
                  goto label_19;
                case 1:
                  ((Collection<ZoomImage>) this.Images).Add(current);
                  num3 = (int) num5 * 1745615661 ^ -1003251457;
                  continue;
                case 2:
                  num3 = (int) num5 * -105528879 ^ 188805913;
                  continue;
                default:
                  goto label_28;
              }
            }
          }
          finally
          {
            if (flag2)
            {
label_24:
              int num3 = -1732843525;
              while (true)
              {
                int num4 = -2069577216;
                uint num5;
                switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                {
                  case 0:
                    goto label_24;
                  case 1:
                    ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(imageLock2);
                    num3 = (int) num5 * -1599260883 ^ -646778730;
                    continue;
                  default:
                    goto label_27;
                }
              }
            }
label_27:;
          }
label_28:
          bool flag3 = current.User != null;
label_29:
          int num6 = -2122894602;
          object modelLock;
          while (true)
          {
            int num3 = -2069577216;
            uint num4;
            switch ((num4 = (uint) (num6 ^ num3)) % 4U)
            {
              case 0:
                goto label_29;
              case 2:
                if (flag3)
                {
                  num6 = (int) num4 * -225402944 ^ -1961905961;
                  continue;
                }
                goto label_53;
              case 3:
                modelLock = ViewModelBase.modelLock;
                num6 = (int) num4 * -763039901 ^ 704370324;
                continue;
              default:
                goto label_34;
            }
          }
label_34:
          bool flag4 = false;
          try
          {
            ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock, ref flag4);
label_36:
            int num3 = -410897618;
            while (true)
            {
              int num4 = -2069577216;
              uint num5;
              bool flag5;
              switch ((num5 = (uint) (num3 ^ num4)) % 8U)
              {
                case 0:
                  goto label_36;
                case 2:
                  int num7 = flag5 ? 851130555 : (num7 = 1397066871);
                  int num8 = (int) num5 * -1118520124;
                  num3 = num7 ^ num8;
                  continue;
                case 3:
                  ((Collection<ZoomUser>) this.Users).Add(current.User);
                  num3 = (int) num5 * -1234456176 ^ -696252219;
                  continue;
                case 4:
                  flag5 = !((Collection<ZoomUser>) this.Users).Contains(current.User);
                  num3 = (int) num5 * -1063026696 ^ -1965934366;
                  continue;
                case 5:
                  num3 = (int) num5 * -1923121178 ^ -132899359;
                  continue;
                case 6:
                  num3 = (int) num5 * -845977992 ^ -1681961628;
                  continue;
                case 7:
                  num3 = -1429951639;
                  continue;
                default:
                  goto label_50;
              }
            }
          }
          finally
          {
            if (flag4)
            {
label_45:
              int num3 = -1888562375;
              while (true)
              {
                int num4 = -2069577216;
                uint num5;
                switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                {
                  case 0:
                    num3 = (int) num5 * -480359521 ^ 2099973959;
                    continue;
                  case 1:
                    ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock);
                    num3 = (int) num5 * 830376849 ^ 2140928705;
                    continue;
                  case 2:
                    goto label_45;
                  default:
                    goto label_49;
                }
              }
            }
label_49:;
          }
label_50:;
        }
        else
          goto label_55;
label_51:
        int num9 = -1757655595;
label_52:
        int num10 = -2069577216;
        switch ((num1 = (uint) (num9 ^ num10)) % 4U)
        {
          case 0:
            return;
          case 1:
            break;
          case 2:
            goto label_51;
          case 3:
            goto label_54;
          default:
            return;
        }
label_53:
        num9 = -1037995233;
        goto label_52;
label_55:
        num9 = -1088611632;
        goto label_52;
      }
      finally
      {
        enumerator.Dispose();
label_58:
        int num1 = -2061520106;
        while (true)
        {
          int num2 = -2069577216;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_58;
            case 2:
              num1 = (int) num3 * 2470119 ^ 1895520017;
              continue;
            default:
              goto label_62;
          }
        }
label_62:;
      }
    }

    private void ImageHistoryView_Closed(object sender, EventArgs e)
    {
      object modelLock = ViewModelBase.modelLock;
      bool flag = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock, ref flag);
        if (this.ImageHistoryView == null)
          goto label_4;
label_2:
        int num1 = 581088904;
label_3:
        while (true)
        {
          int num2 = 1590116318;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 157524547 ^ 1943568160;
              continue;
            case 1:
              num1 = (int) num3 * 499590141 ^ 448004398;
              continue;
            case 2:
              goto label_2;
            case 3:
              goto label_13;
            case 4:
              goto label_4;
            case 5:
              num1 = (int) num3 * -622266488 ^ -487916870;
              continue;
            case 6:
              ImageHistoryViewModel.\u206C‬⁪‮‭⁮⁮⁭⁪⁫​‍‭‪‏‮‏‭⁮‪⁬⁪‏⁫‏⁮⁯⁮‎‭‮⁭‫‫‍‭⁮⁭‮⁮‮((Window) this.ImageHistoryView, new EventHandler(this.ImageHistoryView_Closed));
              num1 = (int) num3 * -1212854085 ^ -257564162;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_13:
        return;
label_4:
        this.ImageHistoryView = (ImageHistoryView) null;
        num1 = 1073904544;
        goto label_3;
      }
      finally
      {
        if (flag)
        {
label_11:
          int num1 = 1793250901;
          while (true)
          {
            int num2 = 1590116318;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_11;
              case 2:
                num1 = (int) num3 * 1503361484 ^ 395030491;
                continue;
              case 3:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock);
                num1 = (int) num3 * 528134881 ^ 694020803;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    private void DetachEventHandlers()
    {
    }

    private void AddCapturedImage(ZoomImage obj)
    {
      object imageLock = ImageHistoryViewModel.imageLock;
      bool flag1 = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(imageLock, ref flag1);
label_2:
        int num1 = -566449761;
        while (true)
        {
          int num2 = -1823574359;
          uint num3;
          bool flag2;
          bool flag3;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 23U)
          {
            case 0:
              num1 = (int) num3 * 695216132 ^ 1532417053;
              continue;
            case 1:
              if (this.Engine.Settings.AutoSpotlightEnabled)
              {
                num1 = (int) num3 * -503309460 ^ -801652014;
                continue;
              }
              break;
            case 2:
              int num6;
              num1 = num6 = this.Engine.Settings.AutoCaptureVideoImages ? -1936445846 : (num6 = -1021697213);
              continue;
            case 3:
              this.SelectedImage = obj;
              num1 = (int) num3 * -62820498 ^ -555993563;
              continue;
            case 4:
              num1 = (int) num3 * 1571389969 ^ 1357829146;
              continue;
            case 5:
              int num7 = flag2 ? -272878123 : (num7 = -2125354927);
              int num8 = (int) num3 * 1426971738;
              num1 = num7 ^ num8;
              continue;
            case 7:
              this.SelectedImageType = ImageEnums.ImageType.Video;
              num1 = (int) num3 * -563446659 ^ 1798870558;
              continue;
            case 8:
              num1 = (int) num3 * -1373484616 ^ -1948503629;
              continue;
            case 9:
              flag2 = !((Collection<ZoomImage>) this.Images).Contains(obj);
              num1 = (int) num3 * -6749173 ^ 1800755914;
              continue;
            case 10:
              num1 = (int) num3 * -1008528034 ^ 719537824;
              continue;
            case 11:
              goto label_2;
            case 12:
              num4 = obj.ImageType == ImageEnums.ImageType.Video ? 1 : 0;
              goto label_19;
            case 13:
              int num9;
              num1 = num9 = this.SelectedImageType == ImageEnums.ImageType.All ? -382068244 : (num9 = -2047971502);
              continue;
            case 14:
              if (this.SelectedImageType == ImageEnums.ImageType.Undefined)
              {
                num1 = (int) num3 * -1659511233 ^ -1849747671;
                continue;
              }
              break;
            case 15:
              if (obj != null)
              {
                num1 = -45168269;
                continue;
              }
              break;
            case 16:
              int num10 = !flag3 ? -2145259573 : (num10 = -307112966);
              int num11 = (int) num3 * -1148124549;
              num1 = num10 ^ num11;
              continue;
            case 17:
              num1 = (int) num3 * -770610490 ^ 39041782;
              continue;
            case 18:
              if (obj != null)
              {
                num1 = -462451145;
                continue;
              }
              num5 = 0;
              goto label_29;
            case 19:
              num5 = obj.ImageType == this.SelectedImageType ? 1 : 0;
              goto label_29;
            case 20:
              num1 = (int) num3 * 336914475 ^ 1315030301;
              continue;
            case 21:
              num1 = -1532181032;
              continue;
            case 22:
              ((Collection<ZoomImage>) this.Images).Add(obj);
              num1 = (int) num3 * -882596916 ^ 944315750;
              continue;
            default:
              goto label_41;
          }
          num4 = 0;
label_19:
          flag3 = num4 != 0;
          num1 = -2051526239;
          continue;
label_29:
          int num12;
          num1 = num12 = num5 == 0 ? -160351887 : (num12 = -389223828);
        }
      }
      finally
      {
        if (flag1)
        {
label_35:
          int num1 = -88712132;
          while (true)
          {
            int num2 = -1823574359;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_35;
              case 1:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(imageLock);
                num1 = (int) num3 * 1874398824 ^ 308115506;
                continue;
              case 3:
                num1 = (int) num3 * 2128751552 ^ -1792042685;
                continue;
              default:
                goto label_40;
            }
          }
        }
label_40:;
      }
label_41:
      if (this.Engine.ActiveActivity != null)
        return;
label_42:
      int num13 = -1890374205;
      while (true)
      {
        int num1 = -1823574359;
        uint num2;
        switch ((num2 = (uint) (num13 ^ num1)) % 5U)
        {
          case 0:
            num13 = (int) num2 * -2053246961 ^ -1790944239;
            continue;
          case 1:
            goto label_37;
          case 2:
            num13 = (int) num2 * 1841762557 ^ -1085079681;
            continue;
          case 3:
            goto label_42;
          case 4:
            this.ShowView();
            num13 = (int) num2 * 822372531 ^ -1119904639;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      return;
label_37:;
    }

    private void ShowView()
    {
label_1:
      int num1 = -972490145;
      // ISSUE: variable of a compiler-generated type
      ImageHistoryViewModel.\u003C\u003Ec__DisplayClass68_0 cDisplayClass680;
      object modelLock1;
      while (true)
      {
        int num2 = -1526776729;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            modelLock1 = ViewModelBase.modelLock;
            num1 = (int) num3 * 166342015 ^ 661910284;
            continue;
          case 1:
            ImageHistoryViewModel.\u200D‭‬‮‏​⁪⁫‎​‮‍⁯‪‌‌⁯‬‮⁫​‫⁮‪⁭‎⁫‏⁬‎⁫⁮‭‪​⁬‌⁫⁬⁬‮(ImageHistoryViewModel.\u202E⁬‌⁬‏‌‌‍‫⁭‫‏‬​⁪‮‬⁫‏⁫⁮‏⁮​‪‭⁪‏⁯‫‎‬‍‬‍⁭⁭⁬‮⁮‮((DispatcherObject) this.EngineView), (Delegate) new ImageHistoryViewModel.ShowViewCallback(this.ShowView), new object[0]);
            num1 = (int) num3 * -1222048197 ^ 252713440;
            continue;
          case 2:
            if (this.EngineView == null)
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * 1764493884 ^ 1448976569;
            continue;
          case 3:
            num1 = (int) num3 * -117031713 ^ 1917887972;
            continue;
          case 4:
            goto label_41;
          case 6:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass680 = new ImageHistoryViewModel.\u003C\u003Ec__DisplayClass68_0();
            // ISSUE: reference to a compiler-generated field
            cDisplayClass680.copy = (ImageHistoryView) null;
            num1 = -193816589;
            continue;
          case 7:
            goto label_1;
          case 8:
            num4 = !ImageHistoryViewModel.\u206F‪‫‏⁯‬‎⁭‏‫‎‪⁭​‮⁮⁮⁭⁭⁪‭‭⁮⁬‎⁮‮‍‎‍‬‎‮‎⁭‭⁪‪​‏‮((DispatcherObject) this.EngineView) ? 1 : 0;
            break;
          default:
            goto label_12;
        }
        int num5;
        num1 = num5 = num4 == 0 ? -77956818 : (num5 = -1130730187);
      }
label_41:
      return;
label_12:
      bool flag1 = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock1, ref flag1);
label_14:
        int num2 = -1968021668;
        while (true)
        {
          int num3 = -1526776729;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              goto label_14;
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass680.copy = this.Engine.ImageHistoryView;
              num2 = (int) num4 * 1809261151 ^ -1010803106;
              continue;
            case 3:
              num2 = (int) num4 * -1269318987 ^ -1690855699;
              continue;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (flag1)
        {
label_19:
          int num2 = -423396884;
          while (true)
          {
            int num3 = -1526776729;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_19;
              case 2:
                num2 = (int) num4 * 140436161 ^ -997534944;
                continue;
              case 3:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock1);
                num2 = (int) num4 * 735900583 ^ 1319604356;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:
      // ISSUE: reference to a compiler-generated field
      bool flag2 = cDisplayClass680.copy == null;
label_25:
      int num6 = -1136126982;
      while (true)
      {
        int num2 = -1526776729;
        uint num3;
        bool flag3;
        switch ((num3 = (uint) (num6 ^ num2)) % 9U)
        {
          case 1:
            if (flag3)
            {
              num6 = (int) num3 * 147878266 ^ 651381993;
              continue;
            }
            goto label_50;
          case 2:
            // ISSUE: reference to a compiler-generated field
            ImageHistoryViewModel.\u200C⁯‎⁯⁮⁮‮⁪⁫‫​‭‬‎‍‮‪⁯‫‍‌‬⁫‪‫⁯‏‬‬‏‫‏‍‪⁭‭‬‬⁯⁭‮((Window) cDisplayClass680.copy, (Window) this.EngineView);
            // ISSUE: reference to a compiler-generated field
            ImageHistoryViewModel.\u200D​⁭‪⁬⁯‬⁯‭‍‎​⁫‍⁭‏⁪‮‌⁯⁯‬‍‍⁯‪⁬⁫‭‪⁫‎‪⁫⁪‬⁮‭⁫⁮‮((Window) cDisplayClass680.copy, new EventHandler(this.ImageHistoryView_Closed));
            num6 = (int) num3 * 36329759 ^ -1022058918;
            continue;
          case 3:
            int num4 = !flag2 ? -391103544 : (num4 = -511964110);
            int num5 = (int) num3 * -1760342040;
            num6 = num4 ^ num5;
            continue;
          case 4:
            goto label_25;
          case 5:
            // ISSUE: reference to a compiler-generated field
            this.Engine.SetImageHistoryView(cDisplayClass680.copy);
            num6 = (int) num3 * 1106667382 ^ -1521703526;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass680.copy = new ImageHistoryView();
            // ISSUE: reference to a compiler-generated field
            ImageHistoryViewModel.\u202B⁭‬⁪‌‫‫⁮⁪⁪⁬​‪⁯⁪‍⁮‮⁬‌‪‏‍‌⁭‭‌​‪⁫‮‎‪‮‪⁯⁮‮⁬‌‮((Window) cDisplayClass680.copy, true);
            num6 = (int) num3 * 1850550207 ^ 97683518;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            flag3 = cDisplayClass680.copy != null;
            num6 = -1492946810;
            continue;
          case 8:
            num6 = (int) num3 * -607560652 ^ -1051996532;
            continue;
          default:
            goto label_36;
        }
      }
label_36:
      object modelLock2 = ViewModelBase.modelLock;
      bool flag4 = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock2, ref flag4);
        // ISSUE: reference to a compiler-generated field
        this.ImageHistoryView = cDisplayClass680.copy;
      }
      finally
      {
        if (flag4)
        {
label_39:
          int num2 = -1973206442;
          while (true)
          {
            int num3 = -1526776729;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                num2 = (int) num4 * 87954782 ^ -1360990760;
                continue;
              case 1:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock2);
                num2 = (int) num4 * 127041623 ^ -181161816;
                continue;
              case 2:
                goto label_39;
              default:
                goto label_44;
            }
          }
        }
label_44:;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      ImageHistoryViewModel.\u200F‍‭‭‎‬‬‎⁭​‬⁪⁫‫⁮⁯‫⁭⁯⁪‎‎‪‎‍⁬​⁮‌‌‏⁫‍‬⁭‭‌⁭⁪⁮‮(ImageHistoryViewModel.\u202E⁬‌⁬‏‌‌‍‫⁭‫‏‬​⁪‮‬⁫‏⁫⁮‏⁮​‪‭⁪‏⁯‫‎‬‍‬‍⁭⁭⁬‮⁮‮((DispatcherObject) cDisplayClass680.copy), new Action((object) cDisplayClass680, __methodptr(\u003CShowView\u003Eb__0)));
label_46:
      int num7 = -609507984;
label_47:
      while (true)
      {
        int num2 = -1526776729;
        uint num3;
        switch ((num3 = (uint) (num7 ^ num2)) % 4U)
        {
          case 0:
            goto label_46;
          case 1:
            goto label_48;
          case 2:
            goto label_50;
          case 3:
            num7 = (int) num3 * 1788525394 ^ -678625789;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return;
label_48:
      return;
label_50:
      num7 = -426510314;
      goto label_47;
    }

    private void LoadCommands()
    {
      bool flag = this.Commands.Count == 0;
label_1:
      int num1 = -1978473145;
      while (true)
      {
        int num2 = -1975705100;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            num1 = (int) num3 * -177132733 ^ -392987069;
            continue;
          case 1:
            num1 = (int) num3 * -2055256186 ^ 657560903;
            continue;
          case 2:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(440496940U), (Action<object>) (x => this.ExecuteDeleteImages()), (Predicate<object>) (x => this.CanDeleteImages()));
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2372102612U), (Action<object>) (x => this.ExecuteFindWindow()), (Predicate<object>) (x => this.CanFindWindow()));
            num1 = (int) num3 * 14571905 ^ -1104433443;
            continue;
          case 3:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3749559396U), (Action<object>) (x => this.ExecuteSaveImage()), (Predicate<object>) (x => this.CanExecuteSaveImage()));
            num1 = (int) num3 * 279444573 ^ -1271927087;
            continue;
          case 4:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3477921496U), (Action<object>) (x => this.ExecuteSaveSelectedUser()), (Predicate<object>) (x => this.CanSaveSelectedUser()));
            num1 = (int) num3 * -1856607143 ^ 1585343347;
            continue;
          case 5:
            int num4 = flag ? -1612614914 : (num4 = -1161314951);
            int num5 = (int) num3 * -1136319628;
            num1 = num4 ^ num5;
            continue;
          case 6:
            goto label_1;
          case 7:
            goto label_3;
          case 8:
            this.Commands.AddCommand(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1016136024U), (Action<object>) (x =>
            {
              this.ExecuteDeleteImage();
label_1:
              int num2 = 968521280;
              while (true)
              {
                int num3 = 628730546;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    num2 = (int) num4 * -1588334873 ^ -1270913498;
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
            }), (Predicate<object>) (x => this.CanDeleteImage()));
            num1 = (int) num3 * -182009874 ^ -501805416;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_3:;
    }

    private bool CanSaveSelectedUser()
    {
label_1:
      int num1 = -1275256251;
      bool flag1;
      while (true)
      {
        int num2 = -748619714;
        uint num3;
        string str1;
        bool flag2;
        int num4;
        string str2;
        int num5;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            flag1 = true;
            num1 = (int) num3 * -2098875505 ^ -2004865963;
            continue;
          case 1:
            flag1 = false;
            num1 = -779384571;
            continue;
          case 2:
            num1 = (int) num3 * -148601233 ^ -1369009840;
            continue;
          case 4:
            if (this.SelectedImage != null)
            {
              num1 = -689230110;
              continue;
            }
            num4 = 0;
            goto label_23;
          case 5:
            if (this.selectedUser != null)
            {
              str2 = this.SelectedUser.UserName;
              goto label_8;
            }
            else
            {
              num1 = (int) num3 * 390855334 ^ 2085410149;
              continue;
            }
          case 6:
            goto label_1;
          case 7:
            str2 = this.SelectedUserName;
            goto label_8;
          case 8:
            num4 = !ImageHistoryViewModel.\u202E⁮‍⁯​⁮⁮‏‌⁭‮‪⁯⁪‫‍‎⁮‎‪‮⁭‎⁪⁭⁭⁪‮‮‮‌‪⁪‎‎‏‌‫‌‌‮(this.SelectedImage.UserName) ? 1 : 0;
            goto label_23;
          case 9:
            num1 = (int) num3 * 667458513 ^ -634106500;
            continue;
          case 10:
            int num6 = flag2 ? 333997474 : (num6 = 1233120120);
            int num7 = (int) num3 * 810930578;
            num1 = num6 ^ num7;
            continue;
          case 11:
            num5 = !ImageHistoryViewModel.\u202A‬⁯⁯‏‮⁫‭⁬‍‭⁯‫‬‏​‬‌‮‎‏‏⁪‎⁭‫⁮⁭‪‪‎‮‫⁬⁯⁯⁮‭‫‍‮(str1, this.SelectedImage.UserName) ? 1 : 0;
            break;
          case 12:
            flag1 = true;
            num1 = (int) num3 * 1662087786 ^ 1715129197;
            continue;
          case 13:
            num1 = (int) num3 * -395282039 ^ -1739212201;
            continue;
          default:
            goto label_24;
        }
label_5:
        flag2 = num5 != 0;
        num1 = -2048466904;
        continue;
label_8:
        str1 = str2;
        if (ImageHistoryViewModel.\u202E⁮‍⁯​⁮⁮‏‌⁭‮‪⁯⁪‫‍‎⁮‎‪‮⁭‎⁪⁭⁭⁪‮‮‮‌‪⁪‎‎‏‌‫‌‌‮(str1))
        {
          num5 = 0;
          goto label_5;
        }
        else
        {
          num1 = -655303047;
          continue;
        }
label_23:
        int num8;
        num1 = num8 = num4 == 0 ? -1270797189 : (num8 = -1132335653);
      }
label_24:
      return flag1;
    }

    private void ExecuteSaveSelectedUser()
    {
      try
      {
label_2:
        int num1 = -1785828765;
        ZoomUser user;
        object modelLock;
        while (true)
        {
          int num2 = -1045051054;
          uint num3;
          bool flag1;
          bool flag2;
          int num4;
          int num5;
          switch ((num3 = (uint) (num1 ^ num2)) % 19U)
          {
            case 0:
              user = this.Engine.GetUser(this.SelectedUserName, true);
              num1 = (int) num3 * -62922517 ^ 1571439985;
              continue;
            case 1:
              num1 = (int) num3 * -321115415 ^ -663349052;
              continue;
            case 2:
              flag1 = this.SelectedImage.User != user;
              num1 = -82953252;
              continue;
            case 3:
              if (this.SelectedUser != null)
              {
                num1 = -2055907366;
                continue;
              }
              num4 = 0;
              goto label_18;
            case 4:
              num1 = (int) num3 * 1799379028 ^ -40914620;
              continue;
            case 5:
              if (this.SelectedImage != null)
              {
                num1 = (int) num3 * 619992865 ^ 1780854963;
                continue;
              }
              goto label_54;
            case 6:
              num1 = (int) num3 * 614726202 ^ 774862807;
              continue;
            case 7:
              num1 = (int) num3 * -317813734 ^ -1480110243;
              continue;
            case 9:
              num5 = !ImageHistoryViewModel.\u202E⁮‍⁯​⁮⁮‏‌⁭‮‪⁯⁪‫‍‎⁮‎‪‮⁭‎⁪⁭⁭⁪‮‮‮‌‪⁪‎‎‏‌‫‌‌‮(this.SelectedUserName) ? 1 : 0;
              break;
            case 10:
              user = this.SelectedImage.User;
              if (this.SelectedUser != null)
              {
                num5 = 0;
                break;
              }
              num1 = (int) num3 * -751869933 ^ 1992180361;
              continue;
            case 11:
              num4 = ImageHistoryViewModel.\u206B‬‬‏⁮⁪‫‮‎⁮‌⁬‬‫‪‫⁬‌⁮‭‍‍​⁭‌‎‎⁫⁮‏⁬⁬‍‫⁯​⁪⁭‌⁪‮(this.SelectedUser.UserName, this.SelectedUserName) ? 1 : 0;
              goto label_18;
            case 12:
              goto label_2;
            case 13:
              if (flag1)
              {
                num1 = (int) num3 * 1814846603 ^ -290914132;
                continue;
              }
              goto label_46;
            case 14:
              this.SelectedImage.SaveDatabaseObject();
              modelLock = ViewModelBase.modelLock;
              num1 = (int) num3 * -329644384 ^ -1340925410;
              continue;
            case 15:
              user = this.Engine.GetUser(this.SelectedUserName, true);
              num1 = (int) num3 * 272587116 ^ -484208641;
              continue;
            case 16:
              this.SelectedImage.User = user;
              num1 = (int) num3 * 662189762 ^ -119235834;
              continue;
            case 17:
              num1 = (int) num3 * 1398389521 ^ 1919147800;
              continue;
            case 18:
              int num6 = !flag2 ? -1963705688 : (num6 = -167574432);
              int num7 = (int) num3 * 1224975393;
              num1 = num6 ^ num7;
              continue;
            default:
              goto label_29;
          }
          flag2 = num5 != 0;
          num1 = -719726176;
          continue;
label_18:
          int num8;
          num1 = num8 = num4 == 0 ? -2120074383 : (num8 = -2090614392);
        }
label_54:
        return;
label_29:
        bool flag = false;
        try
        {
          ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(modelLock, ref flag);
label_31:
          int num2 = -1555539979;
          while (true)
          {
            int num3 = -1045051054;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_31;
              case 1:
                ((Collection<ZoomUser>) this.Users).Add(user);
                num2 = (int) num4 * -1823906281 ^ 744202759;
                continue;
              case 3:
                num2 = (int) num4 * -1967500650 ^ 1238173133;
                continue;
              default:
                goto label_42;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_36:
            int num2 = -166884484;
            while (true)
            {
              int num3 = -1045051054;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_36;
                case 2:
                  ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(modelLock);
                  num2 = (int) num4 * 50446663 ^ -1696349233;
                  continue;
                case 3:
                  num2 = (int) num4 * -1701102245 ^ -368986358;
                  continue;
                default:
                  goto label_41;
              }
            }
          }
label_41:;
        }
label_42:
        this.SelectedUser = user;
label_43:
        int num9 = -303627189;
label_44:
        int num10 = -1045051054;
        uint num11;
        switch ((num11 = (uint) (num9 ^ num10)) % 3U)
        {
          case 0:
            goto label_43;
          case 1:
            return;
          case 2:
            break;
          default:
            return;
        }
label_46:
        num9 = -2074319211;
        goto label_44;
      }
      catch (Exception ex)
      {
        ImageHistoryViewModel.\u200E‭⁫‌‏⁬⁪⁪⁬⁭⁯⁫‪⁭‪‏‪‎⁮‭​⁭‍⁪⁫‍⁫‏​⁭⁪‍⁪‌​⁬⁯⁭⁭‌‮(ViewModelBase.log, (object) ex);
label_49:
        int num1 = -2101547593;
        while (true)
        {
          int num2 = -1045051054;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1496341520 ^ 1376792417;
              continue;
            case 1:
              num1 = (int) num3 * -599830640 ^ -934382130;
              continue;
            case 2:
              goto label_49;
            case 3:
              goto label_45;
            default:
              goto label_38;
          }
        }
label_38:
        return;
label_45:;
      }
    }

    private bool CanDeleteImages()
    {
label_1:
      int num1 = -1656203022;
      bool flag;
      while (true)
      {
        int num2 = -2106034712;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 2042373722 ^ -608370395;
            continue;
          case 2:
            flag = ((Collection<ZoomImage>) this.Images).Count > 0;
            num1 = (int) num3 * -1735531726 ^ -1622147259;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteDeleteImages()
    {
      object imageLock = ImageHistoryViewModel.imageLock;
      bool flag = false;
      try
      {
        ImageHistoryViewModel.\u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮(imageLock, ref flag);
label_2:
        int num1 = 1797502979;
        while (true)
        {
          int num2 = 1964111027;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 1:
              num1 = (int) num3 * 1103347657 ^ 206229282;
              continue;
            case 2:
              goto label_2;
            case 3:
              num1 = (int) num3 * -1068532820 ^ -950440412;
              continue;
            case 4:
              ((Collection<ZoomImage>) this.Images).Clear();
              num1 = (int) num3 * 1230471328 ^ -517869275;
              continue;
            case 5:
              num1 = (int) num3 * 1373969035 ^ 2029848593;
              continue;
            case 6:
              ((Collection<ZoomImage>) this.Images).CopyTo(new ZoomImage[((Collection<ZoomImage>) this.Images).Count], 0);
              num1 = (int) num3 * 1907013905 ^ -1738059224;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (flag)
        {
label_10:
          int num1 = 350920306;
          while (true)
          {
            int num2 = 1964111027;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_10;
              case 1:
                ImageHistoryViewModel.\u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮(imageLock);
                num1 = (int) num3 * -1196105296 ^ 156464797;
                continue;
              case 2:
                num1 = (int) num3 * 859782119 ^ -878522594;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      ImageHistoryViewModel.\u206E⁪⁫‫‍‌‏‏​‫‎‌‬‬⁭⁪‪‌‪⁬‎⁯​‬‎‍⁯⁬‍‭⁬‭‏‍‫​‎⁭‍‏‮(new WaitCallback(this.DeleteImages), (object) ((IEnumerable<ZoomImage>) this.images).ToList<ZoomImage>());
    }

    private void DeleteImages(object state)
    {
      try
      {
        List<ZoomImage> zoomImageList = state as List<ZoomImage>;
label_2:
        int num1 = -217999850;
        while (true)
        {
          int num2 = -717576022;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1639558999 ^ -1258400721;
              continue;
            case 1:
              if (flag)
              {
                num1 = (int) num3 * -1279431271 ^ 1056863453;
                continue;
              }
              goto label_25;
            case 2:
              flag = zoomImageList != null;
              num1 = (int) num3 * 1135924398 ^ -1821002011;
              continue;
            case 3:
              num1 = (int) num3 * -1993198159 ^ -883444225;
              continue;
            case 5:
              goto label_2;
            default:
              goto label_9;
          }
        }
label_25:
        return;
label_9:
        using (List<ZoomImage>.Enumerator enumerator = zoomImageList.GetEnumerator())
        {
label_16:
          int num2 = enumerator.MoveNext() ? -1694860077 : (num2 = -1557948892);
          while (true)
          {
            int num3 = -717576022;
            uint num4;
            ZoomImage current;
            switch ((num4 = (uint) (num2 ^ num3)) % 6U)
            {
              case 0:
                num2 = (int) num4 * 1966062562 ^ -844050499;
                continue;
              case 1:
                current = enumerator.Current;
                num2 = -1559086688;
                continue;
              case 3:
                goto label_16;
              case 4:
                this.Engine.RemoveImage(current);
                num2 = (int) num4 * -1086356733 ^ -186303042;
                continue;
              case 5:
                num2 = -1694860077;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
      catch (Exception ex)
      {
label_22:
        int num1 = -542317909;
        while (true)
        {
          int num2 = -717576022;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_20;
            case 1:
              ImageHistoryViewModel.\u200E‭⁫‌‏⁬⁪⁪⁬⁭⁯⁫‪⁭‪‏‪‎⁮‭​⁭‍⁪⁫‍⁫‏​⁭⁪‍⁪‌​⁬⁯⁭⁭‌‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * 977670051 ^ -1182461946;
              continue;
            case 2:
              goto label_22;
            default:
              goto label_17;
          }
        }
label_17:
        return;
label_20:;
      }
    }

    private bool CanFindWindow()
    {
      return this.SelectedImage != null;
    }

    private void ExecuteFindWindow()
    {
    }

    private bool CanDeleteImage()
    {
      bool flag = this.SelectedImage != null;
label_1:
      int num1 = -1309491306;
      while (true)
      {
        int num2 = -1762946022;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 208624758 ^ 90628383;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteDeleteImage()
    {
label_1:
      int num1 = -294620710;
      while (true)
      {
        int num2 = -2071142479;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            this.SelectedImage = ((Collection<ZoomImage>) this.Images)[((Collection<ZoomImage>) this.Images).Count - 1];
            num1 = (int) num3 * -119088031 ^ 1736267996;
            continue;
          case 1:
            int num4 = flag ? -1163256394 : (num4 = -1214013060);
            int num5 = (int) num3 * -1859956697;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_3;
          case 3:
            ZoomImage selectedImage = this.SelectedImage;
            this.Engine.RemoveImage(selectedImage);
            ((Collection<ZoomImage>) this.Images).Remove(selectedImage);
            num1 = (int) num3 * 977656377 ^ -1035977130;
            continue;
          case 4:
            this.SelectedImage = (ZoomImage) null;
            num1 = (int) num3 * 934559530 ^ -1873890938;
            continue;
          case 5:
            num1 = (int) num3 * 1898800181 ^ 247276890;
            continue;
          case 6:
            goto label_1;
          case 7:
            flag = ((Collection<ZoomImage>) this.Images).Count > 0;
            num1 = (int) num3 * 1826194042 ^ -757122690;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    private bool CanExecuteSaveImage()
    {
label_1:
      int num1 = 2100528528;
      bool flag;
      while (true)
      {
        int num2 = 1086368811;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.SelectedImage != null;
            num1 = (int) num3 * 1604615433 ^ 1190284504;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteSaveImage()
    {
    }

    static void \u200D​‮‎⁮‎⁮‭‭‍‍‪‮⁮‪‎⁫‬‎‍‭‭‮‬‍‏⁯‮‍‍⁫⁫⁯⁮⁭‍‪⁪‎‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Debug(obj1);
    }

    static bool \u206C⁯‭‭‪⁭‌‫‫‎‏‮‌⁯​‌‏‬‍⁮⁮​⁫⁭⁭​⁫‫‍​⁭‬‮​‬⁯‮‍‫‏‮([In] ViewModelBase obj0)
    {
      return obj0.get_IsInDesignMode();
    }

    static void \u202A⁪‍‌‍‬‌⁭⁬‌⁬⁫⁬⁬‮‬‬‍‏‭‍‏‎‍⁭​‌‌‭‌‮‏‭⁪⁯⁪‌⁭‎‬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u200D‬⁮‏‌⁮⁫⁭⁬⁮‍⁫‍‫‎⁫⁬‎⁭‎‭⁯‏‪⁭‮⁮‍⁪‏‬‪‪‭‪‏‬‪‫‍‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    static Type \u202C⁯‭​‪‪‫​​‍⁫⁬‎⁬‭‏‌⁬‪⁫⁭‮‌‪⁭⁬‍‫‍⁭‌⁯⁫⁫⁯​⁫​‪⁫‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static string[] \u206B‍​⁫‬⁫‫‮‌‮⁭‪‭⁮⁫⁮‎‏​⁬​​⁬⁬‭‎‎‏‌⁯‌‬⁪‍‬‫‌⁯‫‌‮([In] Type obj0)
    {
      return Enum.GetNames(obj0);
    }

    static string \u200D‬⁫‪‍⁬‫⁯‪⁬‪⁯⁪⁯⁪‪‭‏‏‫‮⁫⁯‏⁭⁫‍‬‍‭‎‬‪⁫‌‫‫​‫‫‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static void \u200E‭⁫‌‏⁬⁪⁪⁬⁭⁯⁫‪⁭‪‏‪‎⁮‭​⁭‍⁪⁫‍⁫‏​⁭⁪‍⁪‌​⁬⁯⁭⁭‌‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static void \u206C‬⁪‮‭⁮⁮⁭⁪⁫​‍‭‪‏‮‏‭⁮‪⁬⁪‏⁫‏⁮⁯⁮‎‭‮⁭‫‫‍‭⁮⁭‮⁮‮([In] Window obj0, [In] EventHandler obj1)
    {
      obj0.Closed -= obj1;
    }

    static bool \u206F‪‫‏⁯‬‎⁭‏‫‎‪⁭​‮⁮⁮⁭⁭⁪‭‭⁮⁬‎⁮‮‍‎‍‬‎‮‎⁭‭⁪‪​‏‮([In] DispatcherObject obj0)
    {
      return obj0.CheckAccess();
    }

    static Dispatcher \u202E⁬‌⁬‏‌‌‍‫⁭‫‏‬​⁪‮‬⁫‏⁫⁮‏⁮​‪‭⁪‏⁯‫‎‬‍‬‍⁭⁭⁬‮⁮‮([In] DispatcherObject obj0)
    {
      return obj0.Dispatcher;
    }

    static object \u200D‭‬‮‏​⁪⁫‎​‮‍⁯‪‌‌⁯‬‮⁫​‫⁮‪⁭‎⁫‏⁬‎⁫⁮‭‪​⁬‌⁫⁬⁬‮([In] Dispatcher obj0, [In] Delegate obj1, [In] object[] obj2)
    {
      return obj0.Invoke(obj1, obj2);
    }

    static void \u202B⁭‬⁪‌‫‫⁮⁪⁪⁬​‪⁯⁪‍⁮‮⁬‌‪‏‍‌⁭‭‌​‪⁫‮‎‪‮‪⁯⁮‮⁬‌‮([In] Window obj0, [In] bool obj1)
    {
      obj0.Topmost = obj1;
    }

    static void \u200C⁯‎⁯⁮⁮‮⁪⁫‫​‭‬‎‍‮‪⁯‫‍‌‬⁫‪‫⁯‏‬‬‏‫‏‍‪⁭‭‬‬⁯⁭‮([In] Window obj0, [In] Window obj1)
    {
      obj0.Owner = obj1;
    }

    static void \u200D​⁭‪⁬⁯‬⁯‭‍‎​⁫‍⁭‏⁪‮‌⁯⁯‬‍‍⁯‪⁬⁫‭‪⁫‎‪⁫⁪‬⁮‭⁫⁮‮([In] Window obj0, [In] EventHandler obj1)
    {
      obj0.Closed += obj1;
    }

    static void \u200F‍‭‭‎‬‬‎⁭​‬⁪⁫‫⁮⁯‫⁭⁯⁪‎‎‪‎‍⁬​⁮‌‌‏⁫‍‬⁭‭‌⁭⁪⁮‮([In] Dispatcher obj0, [In] Action obj1)
    {
      obj0.Invoke(obj1);
    }

    static bool \u202E⁮‍⁯​⁮⁮‏‌⁭‮‪⁯⁪‫‍‎⁮‎‪‮⁭‎⁪⁭⁭⁪‮‮‮‌‪⁪‎‎‏‌‫‌‌‮([In] string obj0)
    {
      return string.IsNullOrWhiteSpace(obj0);
    }

    static bool \u202A‬⁯⁯‏‮⁫‭⁬‍‭⁯‫‬‏​‬‌‮‎‏‏⁪‎⁭‫⁮⁭‪‪‎‮‫⁬⁯⁯⁮‭‫‍‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u206B‬‬‏⁮⁪‫‮‎⁮‌⁬‬‫‪‫⁬‌⁮‭‍‍​⁭‌‎‎⁫⁮‏⁬⁬‍‫⁯​⁪⁭‌⁪‮([In] string obj0, [In] string obj1)
    {
      return obj0 != obj1;
    }

    static bool \u206E⁪⁫‫‍‌‏‏​‫‎‌‬‬⁭⁪‪‌‪⁬‎⁯​‬‎‍⁯⁬‍‭⁬‭‏‍‫​‎⁭‍‏‮([In] WaitCallback obj0, [In] object obj1)
    {
      return ThreadPool.QueueUserWorkItem(obj0, obj1);
    }

    static object \u202D⁭‍‮‮⁬⁬​‭⁬‪‏⁮‍‏⁮‏‫‬‎‏‫⁫⁪‎‫‏⁬⁮‌‏‪⁬‎‏⁬⁯​⁫‮()
    {
      return new object();
    }

    private delegate void ShowViewCallback();
  }
}
