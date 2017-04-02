// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.ChatManagementViewModel
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ZoomZoom.Common;
using ZoomZoom.Models.Chats;
using ZoomZoom.Models.Events;
using ZoomZoom.Models.Meetings;

namespace ZoomZoom.ViewModels
{
  public class ChatManagementViewModel : ViewModelBase
  {
    private LockedObservableCollection<ZoomChat> recentChats = (LockedObservableCollection<ZoomChat>) null;
    private LockedObservableCollection<ZoomChat> activeChats = (LockedObservableCollection<ZoomChat>) null;
    private LockedObservableCollection<MessageCategory> categories = new LockedObservableCollection<MessageCategory>();
    private MessageContent content = (MessageContent) null;
    private LockedObservableCollection<MessageContent> contents = new LockedObservableCollection<MessageContent>();
    private bool editContentInProgress = false;
    private MessageCategory selectedCategory = (MessageCategory) null;
    private LockedObservableCollection<ZoomMeeting> recentMeetings = new LockedObservableCollection<ZoomMeeting>();
    private LockedObservableCollection<ZoomUser> activeUsers = new LockedObservableCollection<ZoomUser>();
    private MessageCategory editCategory = (MessageCategory) null;
    private MessageContent modifyContent = (MessageContent) null;
    private MessageContent selectedContent = (MessageContent) null;
    private bool editCategoryInProgress;
    public const string ContentPropertyName = "Content";
    public const string ContentsPropertyName = "Contents";
    public const string EditContentInProgressPropertyName = "EditContentInProgress";
    public const string SelectedCategoryPropertyName = "SelectedCategory";
    public const string RecentMeetingsPropertyName = "RecentMeetings";
    public const string ActiveUsersPropertyName = "ActiveUsers";

    public MessageContent Content
    {
      get
      {
label_1:
        int num1 = 1665474330;
        MessageContent content;
        while (true)
        {
          int num2 = 1074135479;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1526352826 ^ -1085055808;
              continue;
            case 1:
              content = this.content;
              num1 = (int) num3 * 673730953 ^ -71057726;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return content;
      }
      set
      {
        bool flag = this.content == value;
label_1:
        int num1 = 1174202110;
        while (true)
        {
          int num2 = 1981424232;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1721043217U));
              num1 = (int) num3 * -697245225 ^ 1568373225;
              continue;
            case 1:
              num1 = (int) num3 * -68693664 ^ -1931998356;
              continue;
            case 2:
              this.content = value;
              num1 = 396563312;
              continue;
            case 3:
              num1 = (int) num3 * -1143783903 ^ 461570332;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              int num4 = !flag ? -28768268 : (num4 = -1365625331);
              int num5 = (int) num3 * 210022433;
              num1 = num4 ^ num5;
              continue;
            case 7:
              num1 = (int) num3 * 749836232 ^ -260323724;
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

    public LockedObservableCollection<MessageContent> Contents
    {
      get
      {
label_1:
        int num1 = 87164075;
        LockedObservableCollection<MessageContent> contents;
        while (true)
        {
          int num2 = 1712029712;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -988814339 ^ 426253455;
              continue;
            case 3:
              contents = this.contents;
              num1 = (int) num3 * -777264760 ^ -745218346;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return contents;
      }
      set
      {
        bool flag = this.contents == value;
label_1:
        int num1 = -1541122804;
        while (true)
        {
          int num2 = -356170946;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * 287394129 ^ -1350645048;
              continue;
            case 1:
              int num4 = !flag ? 930392425 : (num4 = 892311041);
              int num5 = (int) num3 * 1505817948;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * -915987331 ^ 1470739988;
              continue;
            case 3:
              this.contents = value;
              num1 = -1915262778;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1029880040U));
              num1 = (int) num3 * -870224457 ^ 68594641;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public bool EditContentInProgress
    {
      get
      {
        return this.editContentInProgress;
      }
      set
      {
label_1:
        int num1 = -303748617;
        while (true)
        {
          int num2 = -199068108;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3148669540U));
              num1 = (int) num3 * 1066414934 ^ -565598916;
              continue;
            case 2:
              goto label_3;
            case 3:
              flag = this.editContentInProgress == value;
              num1 = (int) num3 * -664118089 ^ -1277117532;
              continue;
            case 4:
              this.editContentInProgress = value;
              num1 = -283848923;
              continue;
            case 5:
              int num4 = flag ? -1151659180 : (num4 = -1848779209);
              int num5 = (int) num3 * -656386285;
              num1 = num4 ^ num5;
              continue;
            case 6:
              num1 = (int) num3 * -1260127040 ^ -462789266;
              continue;
            case 7:
              num1 = (int) num3 * 1099369589 ^ -1855410443;
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

    public LockedObservableCollection<MessageCategory> Categories
    {
      get
      {
label_1:
        int num1 = 1998409283;
        LockedObservableCollection<MessageCategory> categories;
        while (true)
        {
          int num2 = 1803609483;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              categories = this.categories;
              num1 = (int) num3 * 1463228788 ^ 1128449229;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return categories;
      }
      set
      {
label_1:
        int num1 = -41555844;
        while (true)
        {
          int num2 = -432224228;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.categories = value;
              num1 = (int) num3 * -709252759 ^ 439316665;
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

    public MessageCategory SelectedCategory
    {
      get
      {
label_1:
        int num1 = -1307917487;
        MessageCategory selectedCategory;
        while (true)
        {
          int num2 = -1208658345;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              selectedCategory = this.selectedCategory;
              num1 = (int) num3 * -1592301072 ^ 904619867;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedCategory;
      }
      set
      {
        if (this.selectedCategory != value)
          goto label_8;
label_1:
        int num1 = 1088199627;
label_2:
        List<MessageContent> messageContents;
        while (true)
        {
          int num2 = 1947754959;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 10U)
          {
            case 0:
              goto label_8;
            case 1:
              num1 = (int) num3 * 1170056940 ^ -687413117;
              continue;
            case 2:
              num1 = (int) num3 * -997444393 ^ 1754767026;
              continue;
            case 3:
              ((Collection<MessageContent>) this.Contents).Clear();
              num1 = (int) num3 * -1666331615 ^ -1568914607;
              continue;
            case 4:
              goto label_1;
            case 5:
              if (this.SelectedCategory != null)
              {
                num1 = (int) num3 * -481486317 ^ 1936306538;
                continue;
              }
              goto label_25;
            case 7:
              goto label_15;
            case 8:
              messageContents = this.Engine.GetMessageContents(this.SelectedCategory);
              num1 = (int) num3 * 1414129715 ^ -1822338736;
              continue;
            case 9:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3492079630U));
              num1 = (int) num3 * 1950358259 ^ -1398080497;
              continue;
            default:
              goto label_11;
          }
        }
label_15:
        return;
label_25:
        return;
label_11:
        List<MessageContent>.Enumerator enumerator = messageContents.GetEnumerator();
        try
        {
label_19:
          int num2 = enumerator.MoveNext() ? 1343666694 : (num2 = 227396266);
          while (true)
          {
            int num3 = 1947754959;
            uint num4;
            MessageContent current;
            switch ((num4 = (uint) (num2 ^ num3)) % 8U)
            {
              case 0:
                ((Collection<MessageContent>) this.Contents).Add(current);
                num2 = (int) num4 * 867386827 ^ -358989035;
                continue;
              case 1:
                current = enumerator.Current;
                num2 = 874542808;
                continue;
              case 2:
                num2 = (int) num4 * 99864091 ^ -898005046;
                continue;
              case 3:
                num2 = (int) num4 * 1597659086 ^ -2046370557;
                continue;
              case 4:
                num2 = 1343666694;
                continue;
              case 6:
                goto label_19;
              case 7:
                num2 = (int) num4 * 442405809 ^ 860830192;
                continue;
              default:
                goto label_28;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
label_23:
          int num2 = 763478559;
          while (true)
          {
            int num3 = 1947754959;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                num2 = (int) num4 * 1600407985 ^ -841413561;
                continue;
              case 2:
                goto label_23;
              default:
                goto label_27;
            }
          }
label_27:;
        }
label_28:
        return;
label_8:
        this.selectedCategory = value;
        num1 = 1865886958;
        goto label_2;
      }
    }

    public LockedObservableCollection<ZoomChat> ActiveChats
    {
      get
      {
label_1:
        int num1 = 1956151915;
        LockedObservableCollection<ZoomChat> activeChats;
        while (true)
        {
          int num2 = 1167872215;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              activeChats = this.activeChats;
              num1 = (int) num3 * 1964858161 ^ -264375248;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeChats;
      }
      set
      {
label_1:
        int num1 = -777972622;
        while (true)
        {
          int num2 = -1115745519;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -672145527 ^ -768290268;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.activeChats = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3500261260U));
              num1 = (int) num3 * -1576810383 ^ -525588078;
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

    public bool EditCategoryInProgress
    {
      get
      {
label_1:
        int num1 = 1194008860;
        bool categoryInProgress;
        while (true)
        {
          int num2 = 1838394347;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              categoryInProgress = this.editCategoryInProgress;
              num1 = (int) num3 * 1910335492 ^ -308226226;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return categoryInProgress;
      }
      set
      {
label_1:
        int num1 = 1860787629;
        while (true)
        {
          int num2 = 570494819;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.editCategoryInProgress = value;
              num1 = (int) num3 * -397399673 ^ 1276239270;
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

    public LockedObservableCollection<ZoomMeeting> RecentMeetings
    {
      get
      {
        LockedObservableCollection<ZoomMeeting> recentMeetings = this.recentMeetings;
label_1:
        int num1 = -1887416881;
        while (true)
        {
          int num2 = -1899191107;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 258619492 ^ 1596800654;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return recentMeetings;
      }
      set
      {
label_1:
        int num1 = 201061318;
        while (true)
        {
          int num2 = 1975044087;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = !flag ? -1785165406 : (num4 = -1184909248);
              int num5 = (int) num3 * -1252897192;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.recentMeetings = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4231599576U));
              num1 = 1301799357;
              continue;
            case 4:
              num1 = (int) num3 * -453418528 ^ -863761821;
              continue;
            case 5:
              num1 = (int) num3 * -592668852 ^ -1123877957;
              continue;
            case 6:
              flag = this.recentMeetings == value;
              num1 = (int) num3 * 1149741367 ^ 1835419719;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_3:;
      }
    }

    public LockedObservableCollection<ZoomUser> ActiveUsers
    {
      get
      {
label_1:
        int num1 = 816361834;
        LockedObservableCollection<ZoomUser> activeUsers;
        while (true)
        {
          int num2 = 1859474495;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              activeUsers = this.activeUsers;
              num1 = (int) num3 * -447895660 ^ -1582865943;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return activeUsers;
      }
      set
      {
label_1:
        int num1 = 1691365291;
        while (true)
        {
          int num2 = 614901032;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              num1 = (int) num3 * -1874801762 ^ 167843399;
              continue;
            case 1:
              int num4 = this.activeUsers == value ? -163357522 : (num4 = -1414701400);
              int num5 = (int) num3 * 1965157398;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * -646947113 ^ 515393355;
              continue;
            case 3:
              goto label_1;
            case 4:
              this.activeUsers = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1702744575U));
              num1 = 1789240836;
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
    }

    public LockedObservableCollection<ZoomChat> RecentChats
    {
      get
      {
label_1:
        int num1 = -1633697406;
        LockedObservableCollection<ZoomChat> recentChats;
        while (true)
        {
          int num2 = -232838948;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              recentChats = this.recentChats;
              num1 = (int) num3 * -1298565827 ^ 1987251811;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return recentChats;
      }
      set
      {
label_1:
        int num1 = -390580263;
        while (true)
        {
          int num2 = -48801678;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.recentChats = value;
              num1 = (int) num3 * -535891416 ^ 576527898;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(936595625U));
      }
    }

    public MessageCategory ModifyCategory
    {
      get
      {
label_1:
        int num1 = 1853594287;
        MessageCategory editCategory;
        while (true)
        {
          int num2 = 211711;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              editCategory = this.editCategory;
              num1 = (int) num3 * 66523078 ^ 1183061345;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return editCategory;
      }
      set
      {
        this.editCategory = value;
label_1:
        int num1 = 1801528929;
        while (true)
        {
          int num2 = 1623754608;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3064677179U));
              num1 = (int) num3 * -830858451 ^ 74420979;
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

    public MessageContent ModifyContent
    {
      get
      {
        MessageContent modifyContent = this.modifyContent;
label_1:
        int num1 = 631219516;
        while (true)
        {
          int num2 = 1465707449;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -328005114 ^ 979191611;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return modifyContent;
      }
      set
      {
label_1:
        int num1 = -130613389;
        while (true)
        {
          int num2 = -758416615;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2339143618U));
              num1 = (int) num3 * -1355233839 ^ -632674260;
              continue;
            case 2:
              this.modifyContent = value;
              num1 = (int) num3 * -203125582 ^ -2022293928;
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

    public MessageContent SelectedContent
    {
      get
      {
        MessageContent selectedContent = this.selectedContent;
label_1:
        int num1 = 1413228081;
        while (true)
        {
          int num2 = 710882621;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 692295369 ^ 502736960;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return selectedContent;
      }
      set
      {
        this.selectedContent = value;
      }
    }

    public ChatManagementViewModel()
    {
label_1:
      int num1 = -1114406965;
      while (true)
      {
        int num2 = -705696047;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 10U)
        {
          case 0:
            goto label_3;
          case 1:
            this.ActiveChats = new LockedObservableCollection<ZoomChat>();
            num1 = (int) num3 * 1175298098 ^ 983324593;
            continue;
          case 2:
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.ChatChanged), (ThreadOption) 1, false, (Predicate<ObjectChangedEventPayload>) (obj =>
            {
label_1:
              int num2 = 1217343393;
              bool flag;
              while (true)
              {
                int num3 = 1289013416;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    flag = ChatManagementViewModel.\u003C\u003Ec.\u200C‍⁫‮​‍‭‪‍​‮‍‮⁮‎⁭‎⁪‬‫⁪‏‏‍⁫‌‌⁮⁮‏⁮⁪‪⁪⁮⁫⁮​‫⁯‮(obj.ObjectType, ChatManagementViewModel.\u003C\u003Ec.\u206D‏‌‍‮⁭⁪‮‪⁮⁬​⁮‮‌‬‌‌‭⁬‫⁫‭‎‏‌⁭‌‬‪⁪‫⁬‪⁬⁮⁫‫⁭⁭‮(__typeref (ZoomChat)));
                    num2 = (int) num4 * -317650183 ^ -260867229;
                    continue;
                  case 2:
                    num2 = (int) num4 * 125500383 ^ -440881959;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return flag;
            }));
            ((CompositePresentationEvent<ObjectChangedEventPayload>) this._eventAggregator.GetEvent<ObjectChangeEvent>()).Subscribe(new Action<ObjectChangedEventPayload>(this.CategoryChange), (ThreadOption) 1, false, (Predicate<ObjectChangedEventPayload>) (obj =>
            {
label_1:
              int num2 = 1191544841;
              bool flag;
              while (true)
              {
                int num3 = 549090696;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                {
                  case 1:
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    flag = ChatManagementViewModel.\u003C\u003Ec.\u200C‍⁫‮​‍‭‪‍​‮‍‮⁮‎⁭‎⁪‬‫⁪‏‏‍⁫‌‌⁮⁮‏⁮⁪‪⁪⁮⁫⁮​‫⁯‮(obj.ObjectType, ChatManagementViewModel.\u003C\u003Ec.\u206D‏‌‍‮⁭⁪‮‪⁮⁬​⁮‮‌‬‌‌‭⁬‫⁫‭‎‏‌⁭‌‬‪⁪‫⁬‪⁬⁮⁫‫⁭⁭‮(__typeref (MessageCategory)));
                    num2 = (int) num4 * -193695833 ^ -1382012476;
                    continue;
                  case 2:
                    goto label_1;
                  case 3:
                    num2 = (int) num4 * 1319220888 ^ 32377832;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return flag;
            }));
            this.LoadCommands();
            num1 = -1202193366;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -626896021 ^ -1208646812;
            continue;
          case 5:
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingJoinedEvent>()).Subscribe(new Action<ZoomMeeting>(this.MeetingJoined), (ThreadOption) 1);
            ((CompositePresentationEvent<ZoomMeeting>) this._eventAggregator.GetEvent<MeetingJoinedEvent>()).Subscribe(new Action<ZoomMeeting>(this.MeetingLeft), (ThreadOption) 1);
            num1 = (int) num3 * 584090451 ^ 630000170;
            continue;
          case 6:
            this.RecentChats = new LockedObservableCollection<ZoomChat>();
            num1 = (int) num3 * -1694787194 ^ -1048347852;
            continue;
          case 7:
            num1 = (int) num3 * 1022494876 ^ -478320711;
            continue;
          case 8:
            this.Categories.SetSourceCollection((Collection<MessageCategory>) this.Engine.MessageCategories, false);
            num1 = (int) num3 * 2131278020 ^ 5744364;
            continue;
          case 9:
            this.Engine = Engine.Instance;
            num1 = (int) num3 * -2050676756 ^ -130764881;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return;
label_3:;
    }

    private void LoadRecentChats()
    {
    }

    private void MeetingLeft(ZoomMeeting obj)
    {
      ((Collection<ZoomMeeting>) this.RecentMeetings).Add(obj);
    }

    private void MeetingJoined(ZoomMeeting obj)
    {
label_1:
      int num1 = 1877159846;
      while (true)
      {
        int num2 = 915338495;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            ((Collection<ZoomChat>) this.ActiveChats).Clear();
            num1 = (int) num3 * 2062373047 ^ -399630992;
            continue;
          case 1:
            ((Collection<ZoomUser>) this.ActiveUsers).Clear();
            num1 = (int) num3 * 1398098932 ^ 1635426102;
            continue;
          case 2:
            num1 = (int) num3 * 253016310 ^ -980111197;
            continue;
          case 3:
            goto label_1;
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

    private void CategoryChange(ObjectChangedEventPayload obj)
    {
label_1:
      int num1 = 552325882;
      while (true)
      {
        int num2 = 643819723;
        uint num3;
        ChangeType changeType;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            num1 = (int) num3 * -58372569 ^ 1899010057;
            continue;
          case 1:
            int num4 = flag1 ? 1149727987 : (num4 = 1901191938);
            int num5 = (int) num3 * -240727218;
            num1 = num4 ^ num5;
            continue;
          case 2:
            goto label_21;
          case 3:
            num1 = (int) num3 * 1927618996 ^ -1236871946;
            continue;
          case 4:
            goto label_17;
          case 5:
            ((Collection<MessageCategory>) this.Categories).Remove((MessageCategory) obj.ChangedObject);
            num1 = (int) num3 * 1603409687 ^ -259151683;
            continue;
          case 6:
            num1 = (int) num3 * 1280297872 ^ 860226325;
            continue;
          case 7:
label_13:
            flag2 = ((Collection<MessageCategory>) this.Categories).Contains((MessageCategory) obj.ChangedObject);
            num1 = 629674215;
            continue;
          case 8:
            goto label_9;
          case 9:
            int num6 = flag2 ? 1544333289 : (num6 = 1635702489);
            int num7 = (int) num3 * 92928541;
            num1 = num6 ^ num7;
            continue;
          case 10:
            switch (changeType)
            {
              case ChangeType.Updated:
                goto label_8;
              case ChangeType.Added:
                goto label_14;
              case ChangeType.Removed:
                goto label_13;
              case ChangeType.Activated:
                goto label_3;
              case ChangeType.Deactivated:
                goto label_22;
              case ChangeType.Saved:
                goto label_23;
              default:
                num1 = (int) num3 * -898901591 ^ 1607240624;
                continue;
            }
          case 11:
            num1 = (int) num3 * -272053265 ^ 14438067;
            continue;
          case 12:
            changeType = obj.ChangeType;
            num1 = (int) num3 * -1910633620 ^ -616176801;
            continue;
          case 13:
            goto label_24;
          case 14:
label_14:
            flag1 = !((Collection<MessageCategory>) this.Categories).Contains((MessageCategory) obj.ChangedObject);
            num1 = 1504787719;
            continue;
          case 15:
            num1 = (int) num3 * 762012645 ^ -1692672778;
            continue;
          case 16:
            goto label_1;
          case 17:
            goto label_25;
          case 18:
            ((Collection<MessageCategory>) this.Categories).Add((MessageCategory) obj.ChangedObject);
            num1 = (int) num3 * 1579898441 ^ -822836880;
            continue;
          default:
            goto label_26;
        }
      }
label_24:
      return;
label_25:
      return;
label_26:
      return;
label_21:
      return;
label_17:
      return;
label_9:
      return;
label_22:
      return;
label_23:
      return;
label_8:
      return;
label_3:;
    }

    private void ChatChanged(ObjectChangedEventPayload obj)
    {
      bool flag1;
      bool flag2;
      int num1;
      switch (obj.ChangeType)
      {
        case ChangeType.Updated:
          return;
        case ChangeType.Added:
label_5:
          flag1 = !((Collection<ZoomChat>) this.ActiveChats).Contains((ZoomChat) obj.ChangedObject);
          num1 = 1046413600;
          break;
        case ChangeType.Removed:
label_7:
          flag2 = ((Collection<ZoomChat>) this.ActiveChats).Contains((ZoomChat) obj.ChangedObject);
          num1 = 1177485625;
          break;
        case ChangeType.Activated:
          return;
        case ChangeType.Deactivated:
          return;
        case ChangeType.Saved:
          return;
        default:
label_1:
          num1 = 987416437;
          break;
      }
      while (true)
      {
        int num2 = 152041525;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -336729310 ^ 765486341;
            continue;
          case 2:
            num1 = (int) num3 * 1328495200 ^ 311375008;
            continue;
          case 3:
            goto label_11;
          case 4:
            ((Collection<ZoomChat>) this.ActiveChats).Remove((ZoomChat) obj.ChangedObject);
            num1 = (int) num3 * -1760014570 ^ -406567268;
            continue;
          case 5:
            goto label_9;
          case 6:
            num1 = (int) num3 * 1138654241 ^ -94818636;
            continue;
          case 7:
            int num4 = !flag1 ? -1251976570 : (num4 = -1023876372);
            int num5 = (int) num3 * 571615249;
            num1 = num4 ^ num5;
            continue;
          case 8:
            goto label_4;
          case 9:
            goto label_5;
          case 10:
            int num6 = flag2 ? -1532550429 : (num6 = -498353696);
            int num7 = (int) num3 * -2118801330;
            num1 = num6 ^ num7;
            continue;
          case 11:
            goto label_3;
          case 12:
            ((Collection<ZoomChat>) this.ActiveChats).Add((ZoomChat) obj.ChangedObject);
            num1 = (int) num3 * 153048037 ^ 2138488987;
            continue;
          case 13:
            goto label_7;
          default:
            goto label_20;
        }
      }
label_3:
      return;
label_20:
      return;
label_4:
      return;
label_11:
      return;
label_9:;
    }

    public void LoadCommands()
    {
      if (this.Commands.Count != 0)
        return;
label_1:
      int num1 = 852479014;
      while (true)
      {
        int num2 = 2021098161;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 21U)
        {
          case 0:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1709101131U), (Action<object>) (x =>
            {
              this.ExecuteCancelCategory();
label_1:
              int num2 = -1827264474;
              while (true)
              {
                int num3 = -125290982;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    num2 = (int) num4 * -891979398 ^ 431620159;
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
            }), (Predicate<object>) (x => this.CanCancelCategory()));
            num1 = (int) num3 * -999174072 ^ 774044067;
            continue;
          case 1:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(764407653U), (Action<object>) (x => this.ExecuteUpdateContent()), (Predicate<object>) (x => this.CanUpdateContent()));
            num1 = (int) num3 * 944813350 ^ 96188472;
            continue;
          case 2:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2155033467U), (Action<object>) (x =>
            {
              this.ExecuteSetFloodDefault();
label_1:
              int num2 = 1828125802;
              while (true)
              {
                int num3 = 212860922;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num2 = (int) num4 * -1070951210 ^ -845298252;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanSetFloodDefault()));
            num1 = (int) num3 * -1948638905 ^ 26479921;
            continue;
          case 3:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2520657189U), (Action<object>) (x =>
            {
              this.ExecuteSaveContent();
label_1:
              int num2 = 432774562;
              while (true)
              {
                int num3 = 746264308;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    num2 = (int) num4 * 134660587 ^ 349717350;
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
            }), (Predicate<object>) (x => this.CanSaveContent()));
            num1 = (int) num3 * -281576096 ^ -1972246520;
            continue;
          case 4:
            num1 = (int) num3 * -980297104 ^ -1595714378;
            continue;
          case 5:
            this.Commands.AddCommand(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1841339075U), (Action<object>) (x => this.ExecuteNewCategory()), (Predicate<object>) (x => this.CanExecuteNewCategory()));
            num1 = (int) num3 * 1036303789 ^ -901155971;
            continue;
          case 6:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3378312085U), (Action<object>) (x => this.ExecuteCopyContentClipboard()), (Predicate<object>) (x => this.CanCopyContentClipboard()));
            num1 = (int) num3 * -2086226205 ^ -1375808151;
            continue;
          case 7:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1957294421U), (Action<object>) (x =>
            {
              this.ExecuteDeleteCategory();
label_1:
              int num2 = -407261021;
              while (true)
              {
                int num3 = -1917086354;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num2 = (int) num4 * 338437444 ^ 70324989;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanDeleteCategory()));
            num1 = (int) num3 * -1683676332 ^ -756076752;
            continue;
          case 8:
            num1 = (int) num3 * -1032000416 ^ -905049338;
            continue;
          case 9:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(596422931U), (Action<object>) (x => this.ExecuteSaveCategory()), (Predicate<object>) (x => this.CanSaveCategory()));
            num1 = (int) num3 * -595782132 ^ 1046985514;
            continue;
          case 10:
            goto label_1;
          case 11:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2714487852U), (Action<object>) (x => this.ExecuteUpdateCategory()), (Predicate<object>) (x => this.CanUpdateCategory()));
            num1 = (int) num3 * -1606497428 ^ -1396504257;
            continue;
          case 12:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1657925936U), (Action<object>) (x => this.ExecuteCancelContent()), (Predicate<object>) (x => this.CanCancelContent()));
            num1 = (int) num3 * 2108761148 ^ 1177831449;
            continue;
          case 13:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3368802138U), (Action<object>) (x =>
            {
              this.ExecuteNewContent();
label_1:
              int num2 = 410948557;
              while (true)
              {
                int num3 = 228033074;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    num2 = (int) num4 * -705470160 ^ -1822974215;
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
            }), (Predicate<object>) (x => this.CanExecuteNewContent()));
            num1 = (int) num3 * 798781530 ^ -745020224;
            continue;
          case 14:
            this.Commands.AddCommand(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2824506659U), (Action<object>) (x => this.ExecuteImportContent()), (Predicate<object>) (x => this.CanImportContent()));
            this.Commands.AddCommand(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(797966659U), (Action<object>) (x =>
            {
              this.ExecuteExportContent();
label_1:
              int num2 = 1387739868;
              while (true)
              {
                int num3 = 477737140;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    num2 = (int) num4 * -919031498 ^ 1028945434;
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
            }), (Predicate<object>) (x => this.CanExportContent()));
            num1 = (int) num3 * 1186674201 ^ -1387951281;
            continue;
          case 15:
            num1 = (int) num3 * -1533795686 ^ 1932591504;
            continue;
          case 16:
            num1 = (int) num3 * 1972499900 ^ -2066345704;
            continue;
          case 17:
            this.Commands.AddCommand(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1423067158U), (Action<object>) (x =>
            {
              this.ExecuteDeleteContent();
label_1:
              int num2 = 87122216;
              while (true)
              {
                int num3 = 1266190804;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    goto label_3;
                  case 2:
                    num2 = (int) num4 * 1979435645 ^ 1462585451;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              return;
label_3:;
            }), (Predicate<object>) (x => this.CanDeleteContent()));
            num1 = (int) num3 * 629786516 ^ -816918636;
            continue;
          case 18:
            num1 = (int) num3 * 1161546327 ^ -1714026284;
            continue;
          case 19:
            goto label_23;
          case 20:
            this.Commands.AddCommand(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(339806451U), (Action<object>) (x =>
            {
              this.ExecuteMoveContent();
label_1:
              int num2 = -454777324;
              while (true)
              {
                int num3 = -652698469;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_1;
                  case 1:
                    num2 = (int) num4 * 1920897659 ^ -1524300387;
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
            }), (Predicate<object>) (x => this.CanMoveContent()));
            num1 = (int) num3 * -1957942566 ^ 1532954568;
            continue;
          default:
            goto label_24;
        }
      }
label_24:
      return;
label_23:;
    }

    private void ExecuteSetFloodDefault()
    {
label_1:
      int num1 = 883391391;
      while (true)
      {
        int num2 = 1022234982;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            num1 = (int) num3 * 812532129 ^ 462718031;
            continue;
          case 1:
            flag = this.SelectedContent != null;
            num1 = (int) num3 * -563368039 ^ -1221323188;
            continue;
          case 2:
            num1 = (int) num3 * -475200550 ^ 712376040;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_3;
          case 5:
            int num4 = flag ? 1002948742 : (num4 = 691524081);
            int num5 = (int) num3 * -47821553;
            num1 = num4 ^ num5;
            continue;
          case 6:
            this.Engine.Settings.FloodOptions_MessageContent = this.SelectedContent.ContentText;
            num1 = (int) num3 * 488542077 ^ 1186499684;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return;
label_3:;
    }

    private bool CanSetFloodDefault()
    {
label_1:
      int num1 = 926124306;
      bool flag;
      while (true)
      {
        int num2 = 1051730814;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.SelectedContent != null;
            num1 = (int) num3 * -1016568359 ^ -1490874758;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteCopyContentClipboard()
    {
      try
      {
label_2:
        int num1 = 697497295;
        while (true)
        {
          int num2 = 110682233;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              ChatManagementViewModel.\u202C‫⁫‭‬‭‎‫‍‫⁮‫‪‫⁫⁭​‌⁯‍​‎⁪‪⁮‭⁯‭‍⁬⁫‮⁪‪​⁮⁮‌⁬⁪‮((object) this.SelectedContent.ContentText, true, 5, 50);
              num1 = (int) num3 * 1847759774 ^ -2010698494;
              continue;
            case 1:
              int num4 = !flag ? 1959876301 : (num4 = 691334288);
              int num5 = (int) num3 * 1869063249;
              num1 = num4 ^ num5;
              continue;
            case 2:
              num1 = (int) num3 * -166979843 ^ 789309406;
              continue;
            case 3:
              num1 = (int) num3 * -465107169 ^ 1222360814;
              continue;
            case 4:
              goto label_2;
            case 5:
              num1 = 1432995670;
              continue;
            case 6:
              flag = this.SelectedContent != null;
              num1 = (int) num3 * 788478870 ^ 1141003220;
              continue;
            case 7:
              goto label_17;
            default:
              goto label_15;
          }
        }
label_15:
        return;
label_17:;
      }
      catch (Exception ex)
      {
label_13:
        int num1 = 464547082;
        while (true)
        {
          int num2 = 110682233;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_13;
            case 1:
              ChatManagementViewModel.\u206A‍‍‫‭⁮‌‌⁬‏‌‎‮⁯‭‌⁯⁮⁮‫‮⁭‎‫⁭⁬⁮⁬​‪⁬‮​‌​​⁪⁭‮‮‮(ViewModelBase.log, (object) ex);
              num1 = (int) num3 * 654613116 ^ 1127479450;
              continue;
            case 2:
              goto label_11;
            default:
              goto label_4;
          }
        }
label_4:
        return;
label_11:;
      }
    }

    private bool CanCopyContentClipboard()
    {
label_1:
      int num1 = 1833743741;
      bool flag;
      while (true)
      {
        int num2 = 1543304134;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.SelectedContent != null;
            num1 = (int) num3 * 1006682712 ^ 1414039612;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private bool CanCancelContent()
    {
label_1:
      int num1 = 1998666632;
      bool flag;
      while (true)
      {
        int num2 = 433112138;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = this.ModifyContent != null;
            num1 = (int) num3 * 1828900738 ^ -491341095;
            continue;
          case 3:
            num1 = (int) num3 * 27274429 ^ 1488723308;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteCancelContent()
    {
label_1:
      int num1 = -1842665933;
      while (true)
      {
        int num2 = -193848750;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.ModifyContent = (MessageContent) null;
            num1 = (int) num3 * 667357205 ^ 152582249;
            continue;
          case 2:
            num1 = (int) num3 * -1471233168 ^ -1343107206;
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

    private bool CanCancelCategory()
    {
label_1:
      int num1 = 1067353164;
      bool flag;
      while (true)
      {
        int num2 = 887943282;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -1170477459 ^ -927807540;
            continue;
          case 2:
            flag = this.ModifyCategory != null;
            num1 = (int) num3 * 865448954 ^ 1086037443;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteCancelCategory()
    {
      this.ModifyCategory = (MessageCategory) null;
    }

    private bool CanImportContent()
    {
label_1:
      int num1 = -116057910;
      bool flag;
      while (true)
      {
        int num2 = -1810668925;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            flag = true;
            num1 = (int) num3 * 2001018132 ^ -1697156220;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1966180125 ^ 812966586;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteImportContent()
    {
label_1:
      int num1 = 1975307103;
      while (true)
      {
        int num2 = 400628158;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 2128282349 ^ -204015887;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private bool CanExportContent()
    {
      bool flag = true;
label_1:
      int num1 = 1608916425;
      while (true)
      {
        int num2 = 1034454823;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1889749710 ^ -1137754473;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteExportContent()
    {
label_1:
      int num1 = -455611832;
      while (true)
      {
        int num2 = -1193148391;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -351545119 ^ 501351059;
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

    private bool CanMoveContent()
    {
      bool flag = true;
label_1:
      int num1 = -213470098;
      while (true)
      {
        int num2 = -1781735619;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * 1638450994 ^ 794915782;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteMoveContent()
    {
label_1:
      int num1 = -512548595;
      while (true)
      {
        int num2 = -1665757697;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1440902317 ^ -496906827;
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

    private bool CanExecuteNewCategory()
    {
label_1:
      int num1 = -295495794;
      bool flag;
      while (true)
      {
        int num2 = -2049205744;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 969569368 ^ -1171358549;
            continue;
          case 2:
            flag = this.ModifyCategory == null;
            num1 = (int) num3 * -1315502238 ^ -1719245083;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteNewCategory()
    {
label_1:
      int num1 = -1339545466;
      while (true)
      {
        int num2 = -1662893674;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.ModifyCategory = this.Engine.GetMessageCategory(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1149646746U), true);
            this.SelectedCategory = this.ModifyCategory;
            num1 = (int) num3 * 1997137964 ^ -1786738395;
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

    private bool CanDeleteCategory()
    {
      bool flag = this.SelectedCategory != null;
label_1:
      int num1 = 1585697044;
      while (true)
      {
        int num2 = 872928302;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -2068137739 ^ -1402474110;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteDeleteCategory()
    {
      ((Collection<MessageCategory>) this.Categories).Remove(this.SelectedCategory);
      this.Engine.RemoveMessageCategory(this.SelectedCategory);
      this.SelectedCategory = (MessageCategory) null;
    }

    private bool CanUpdateCategory()
    {
      bool flag = this.ModifyCategory == null;
label_1:
      int num1 = 1531333541;
      while (true)
      {
        int num2 = 1353644916;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            num1 = (int) num3 * -231743989 ^ 167106017;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteUpdateCategory()
    {
      this.ModifyCategory = this.SelectedCategory;
label_1:
      int num1 = -1053419690;
      while (true)
      {
        int num2 = -352641845;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -2033427328 ^ -1038496501;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private bool CanSaveCategory()
    {
label_1:
      int num1 = 734900483;
      bool flag;
      while (true)
      {
        int num2 = 1101432523;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            num1 = (int) num3 * -64449592 ^ 1914550516;
            continue;
          case 2:
            goto label_1;
          case 3:
            if (this.ModifyCategory != null)
            {
              num1 = (int) num3 * -1639396348 ^ 1053295779;
              continue;
            }
            num4 = 0;
            break;
          case 4:
            num4 = this.ModifyCategory.IsDirty ? 1 : 0;
            break;
          default:
            goto label_9;
        }
        flag = num4 != 0;
        num1 = 117140386;
      }
label_9:
      return flag;
    }

    private void ExecuteSaveCategory()
    {
label_1:
      int num1 = 1953946318;
      while (true)
      {
        int num2 = 1686824951;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 8U)
        {
          case 0:
            num1 = (int) num3 * -407154481 ^ -1378379987;
            continue;
          case 1:
            this.ModifyCategory.SaveDatabaseObject();
            num1 = (int) num3 * 1271578183 ^ -1336418301;
            continue;
          case 2:
            this.SelectedCategory = this.ModifyCategory;
            num1 = (int) num3 * -969233526 ^ -269726307;
            continue;
          case 3:
            ((Collection<MessageCategory>) this.Categories).Add(this.ModifyCategory);
            num1 = (int) num3 * 1656829726 ^ 1511130053;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.ModifyCategory = (MessageCategory) null;
            this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3355880608U));
            num1 = (int) num3 * 473570243 ^ -1233650308;
            continue;
          case 6:
            num1 = (int) num3 * 586651157 ^ -1997882876;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_10:
      return;
label_3:;
    }

    private bool CanExecuteNewContent()
    {
label_1:
      int num1 = 388720710;
      bool flag;
      while (true)
      {
        int num2 = 1655634375;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = this.ModifyContent == null;
            num1 = (int) num3 * -1667806617 ^ 351845559;
            continue;
          case 3:
            num1 = (int) num3 * 1362427134 ^ 1805541107;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return flag;
    }

    private void ExecuteNewContent()
    {
label_1:
      int num1 = -1085442543;
      while (true)
      {
        int num2 = -1784494497;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.SelectedContent = this.ModifyContent;
            num1 = (int) num3 * 1119461458 ^ 615029573;
            continue;
          case 2:
            this.ModifyContent = new MessageContent(this.SelectedCategory, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1954218898U));
            num1 = (int) num3 * -351052765 ^ 1320859444;
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

    private bool CanDeleteContent()
    {
label_1:
      int num1 = 807319185;
      bool flag;
      while (true)
      {
        int num2 = 39424400;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            flag = this.SelectedContent != null;
            num1 = (int) num3 * 848118303 ^ 1397725757;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteDeleteContent()
    {
label_1:
      int num1 = -1718372648;
      while (true)
      {
        int num2 = -639409880;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.SelectedContent = (MessageContent) null;
            num1 = (int) num3 * 242366914 ^ 39791319;
            continue;
          case 1:
            ((Collection<MessageContent>) this.Contents).Remove(this.SelectedContent);
            this.Engine.RemoveMessageContent(this.SelectedContent);
            num1 = (int) num3 * -537180205 ^ -1857755932;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * -1169418264 ^ -1974465895;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    private bool CanUpdateContent()
    {
label_1:
      int num1 = -1721915783;
      bool flag;
      while (true)
      {
        int num2 = -2054995949;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            flag = this.ModifyContent == null;
            num1 = (int) num3 * -1796343736 ^ 852111589;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return flag;
    }

    private void ExecuteUpdateContent()
    {
label_1:
      int num1 = -493253168;
      while (true)
      {
        int num2 = -19944458;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.ModifyContent = this.SelectedContent;
            num1 = (int) num3 * -302662085 ^ -2106839858;
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

    private bool CanSaveContent()
    {
label_1:
      int num1 = 884268601;
      bool flag;
      while (true)
      {
        int num2 = 1317743104;
        uint num3;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            num1 = (int) num3 * 11799380 ^ 420008255;
            continue;
          case 1:
            if (this.ModifyContent != null)
            {
              num1 = (int) num3 * 851693815 ^ 2053403037;
              continue;
            }
            num4 = 0;
            break;
          case 2:
            goto label_1;
          case 4:
            num4 = this.ModifyContent.IsDirty ? 1 : 0;
            break;
          default:
            goto label_9;
        }
        flag = num4 != 0;
        num1 = 1280153285;
      }
label_9:
      return flag;
    }

    private void ExecuteSaveContent()
    {
      this.ModifyContent.SaveDatabaseObject();
      ((Collection<MessageContent>) this.Contents).Add(this.ModifyContent);
label_1:
      int num1 = -1474568966;
      while (true)
      {
        int num2 = -441896376;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -641672678 ^ -1686233619;
            continue;
          case 2:
            this.SelectedContent = this.ModifyContent;
            num1 = (int) num3 * 117979660 ^ 1626822555;
            continue;
          case 3:
            this.ModifyContent = (MessageContent) null;
            num1 = (int) num3 * 2106810551 ^ -785629061;
            continue;
          case 4:
            this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(132145247U));
            num1 = (int) num3 * -176134181 ^ -274594982;
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

    static void \u202C‫⁫‭‬‭‎‫‍‫⁮‫‪‫⁫⁭​‌⁯‍​‎⁪‪⁮‭⁯‭‍⁬⁫‮⁪‪​⁮⁮‌⁬⁪‮([In] object obj0, [In] bool obj1, [In] int obj2, [In] int obj3)
    {
      Clipboard.SetDataObject(obj0, obj1, obj2, obj3);
    }

    static void \u206A‍‍‫‭⁮‌‌⁬‏‌‎‮⁯‭‌⁯⁮⁮‫‮⁭‎‫⁭⁬⁮⁬​‪⁬‮​‌​​⁪⁭‮‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }
  }
}
