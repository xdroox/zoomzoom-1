// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.MeetingManagementControl
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Telerik.Windows.Controls;

namespace ZoomZoom.UserControls
{
  public class MeetingManagementControl : UserControl, IComponentConnector
  {
    internal StackPanel ManageButtonContent;
    internal RadComboBox cbMeetings;
    internal Button btnJoin;
    internal Button btnJoinAttack;
    internal Button btnHammer;
    internal Button btnFlood;
    internal Button btnPeek;
    internal Button btnForce;
    internal Button btnWar;
    internal Button btnNew;
    internal Button btnDelete;
    internal TextBox txtNewMeetingId;
    internal Button btnNewMeetingIdSave;
    internal Button btnNewMeetingIdCancel;
    internal TextBlock tbMeeetingStatus;
    internal TextBox txtForceMeeting;
    internal CheckBox cbMeetingAutoFindUsersEnabled;
    internal CheckBox cbJoinChangeUserName;
    internal TextBox txtJoinUserName;
    internal Button btnNewJoinUserName;
    internal Button btnJoinDeleteUserName;
    internal ListBox lbJoinNames;
    internal TextBox txtUserName;
    internal Button btnNewUserName;
    internal Button btnDeleteUserName;
    internal ListBox lbUserNames;
    internal Expander expMeetingUsers;
    internal Expander expMeetingButtons;
    private bool _contentLoaded;

    public MeetingManagementControl()
    {
label_1:
      int num1 = 405938627;
      while (true)
      {
        int num2 = 17340953;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -1155608083 ^ -702206984;
            continue;
          case 3:
            this.InitializeComponent();
            num1 = (int) num3 * -1408842321 ^ -114754571;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
    }

    private void UserControl_Unloaded(object sender, RoutedEventArgs e)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
label_1:
      int num1 = 2000585681;
      while (true)
      {
        int num2 = 917949834;
        uint num3;
        bool contentLoaded;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            contentLoaded = this._contentLoaded;
            num1 = (int) num3 * -1972358190 ^ 1802512543;
            continue;
          case 2:
            this._contentLoaded = true;
            MeetingManagementControl.\u206B⁯‌​‫‪⁬‬‎‮⁫‎‫​‏⁯⁫⁯‮​‌‏‍‭‬‏‬​⁪⁯‭‌⁭‫‪⁫‭‮​⁭‮((object) this, MeetingManagementControl.\u202E‭‎‍⁭‏‎‭‎‮‫⁪‬‭⁯‎‮‬‌‫⁬⁮‪⁮⁭⁭‪⁬⁭‌‭⁫‮‫‭⁪‎⁫‪‏‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1124799395U), UriKind.Relative));
            num1 = 300957564;
            continue;
          case 3:
            int num4 = contentLoaded ? -802371764 : (num4 = -704830675);
            int num5 = (int) num3 * -555618421;
            num1 = num4 ^ num5;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num3 * -1720952481 ^ 1345086421;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:;
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      int num1 = connectionId;
label_1:
      int num2 = -33275109;
      while (true)
      {
        int num3 = -307570436;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 51U)
        {
          case 0:
            this._contentLoaded = true;
            num2 = -408664837;
            continue;
          case 1:
            num2 = (int) num4 * -1724838724 ^ -41684493;
            continue;
          case 2:
label_46:
            this.ManageButtonContent = (StackPanel) target;
            num2 = -408664837;
            continue;
          case 3:
label_28:
            this.tbMeeetingStatus = (TextBlock) target;
            num2 = -408664837;
            continue;
          case 4:
            num2 = (int) num4 * -84135372 ^ -193149821;
            continue;
          case 5:
            num2 = (int) num4 * -597490561 ^ -173926194;
            continue;
          case 6:
label_40:
            this.txtNewMeetingId = (TextBox) target;
            num2 = -476853563;
            continue;
          case 7:
label_39:
            this.btnNew = (Button) target;
            num2 = -408664837;
            continue;
          case 8:
label_53:
            this.btnNewUserName = (Button) target;
            num2 = -1893145366;
            continue;
          case 9:
label_24:
            this.txtUserName = (TextBox) target;
            num2 = -685749879;
            continue;
          case 10:
            MeetingManagementControl.\u202E⁯⁮‍⁪‏​‫⁬⁭‫⁪‫‮‎​‌​​⁭‫‎⁪⁯⁬​‏‎‬‌‬⁪⁫‪⁮‪‎‌‮⁪‮((FrameworkElement) target, new RoutedEventHandler(this.UserControl_Unloaded));
            num2 = (int) num4 * 1124360358 ^ 488605611;
            continue;
          case 11:
label_48:
            this.expMeetingUsers = (Expander) target;
            num2 = -491893946;
            continue;
          case 12:
            num2 = (int) num4 * -2006519346 ^ 665957769;
            continue;
          case 13:
label_44:
            this.cbJoinChangeUserName = (CheckBox) target;
            num2 = -408664837;
            continue;
          case 14:
label_42:
            this.txtForceMeeting = (TextBox) target;
            num2 = -408664837;
            continue;
          case 15:
            num2 = (int) num4 * -943461599 ^ 955894559;
            continue;
          case 16:
label_10:
            this.btnDelete = (Button) target;
            num2 = -965520208;
            continue;
          case 17:
            num2 = (int) num4 * 1172432752 ^ -1607093829;
            continue;
          case 18:
            switch (num1)
            {
              case 1:
                goto label_6;
              case 2:
                goto label_46;
              case 3:
                goto label_50;
              case 4:
                goto label_4;
              case 5:
                goto label_25;
              case 6:
                goto label_37;
              case 7:
                goto label_12;
              case 8:
                goto label_14;
              case 9:
                goto label_27;
              case 10:
                goto label_21;
              case 11:
                goto label_39;
              case 12:
                goto label_10;
              case 13:
                goto label_40;
              case 14:
                goto label_32;
              case 15:
                goto label_43;
              case 16:
                goto label_28;
              case 17:
                goto label_42;
              case 18:
                goto label_17;
              case 19:
                goto label_44;
              case 20:
                goto label_11;
              case 21:
                goto label_52;
              case 22:
                goto label_41;
              case 23:
                goto label_7;
              case 24:
                goto label_24;
              case 25:
                goto label_53;
              case 26:
                goto label_13;
              case 27:
                goto label_15;
              case 28:
                goto label_48;
              case 29:
                goto label_23;
              default:
                num2 = (int) num4 * 1749109639 ^ 1313515356;
                continue;
            }
          case 19:
label_25:
            this.btnJoinAttack = (Button) target;
            num2 = -408664837;
            continue;
          case 20:
label_7:
            this.lbJoinNames = (ListBox) target;
            num2 = -1332644445;
            continue;
          case 21:
label_41:
            this.btnJoinDeleteUserName = (Button) target;
            num2 = -1719669297;
            continue;
          case 22:
label_50:
            this.cbMeetings = (RadComboBox) target;
            num2 = -408664837;
            continue;
          case 23:
            num2 = (int) num4 * -34193682 ^ -1345742165;
            continue;
          case 24:
label_4:
            this.btnJoin = (Button) target;
            num2 = -1849877454;
            continue;
          case 25:
            num2 = (int) num4 * 448436522 ^ -1955565147;
            continue;
          case 26:
            num2 = (int) num4 * 687532975 ^ 9188750;
            continue;
          case 27:
label_32:
            this.btnNewMeetingIdSave = (Button) target;
            num2 = -408664837;
            continue;
          case 28:
label_15:
            this.lbUserNames = (ListBox) target;
            num2 = -408664837;
            continue;
          case 29:
label_37:
            this.btnHammer = (Button) target;
            num2 = -132706408;
            continue;
          case 30:
            num2 = (int) num4 * 820581863 ^ 398899993;
            continue;
          case 31:
label_17:
            this.cbMeetingAutoFindUsersEnabled = (CheckBox) target;
            num2 = -1885088687;
            continue;
          case 32:
label_21:
            this.btnWar = (Button) target;
            num2 = -408664837;
            continue;
          case 33:
            goto label_1;
          case 34:
            goto label_3;
          case 35:
label_23:
            this.expMeetingButtons = (Expander) target;
            num2 = -408664837;
            continue;
          case 36:
label_43:
            this.btnNewMeetingIdCancel = (Button) target;
            num2 = -1530058825;
            continue;
          case 37:
            num2 = (int) num4 * 739943814 ^ -857839755;
            continue;
          case 38:
label_27:
            this.btnForce = (Button) target;
            num2 = -2136953417;
            continue;
          case 39:
            num2 = (int) num4 * 1823781847 ^ -120711175;
            continue;
          case 40:
            num2 = (int) num4 * 1370723179 ^ 1477523996;
            continue;
          case 41:
label_14:
            this.btnPeek = (Button) target;
            num2 = -1283799671;
            continue;
          case 42:
label_11:
            this.txtJoinUserName = (TextBox) target;
            num2 = -1683997468;
            continue;
          case 43:
label_52:
            this.btnNewJoinUserName = (Button) target;
            num2 = -408664837;
            continue;
          case 44:
            num2 = (int) num4 * 537629904 ^ -1828813141;
            continue;
          case 45:
label_13:
            this.btnDeleteUserName = (Button) target;
            num2 = -1240100121;
            continue;
          case 46:
            num2 = (int) num4 * -1329012463 ^ -1445982815;
            continue;
          case 47:
            num2 = (int) num4 * -2132035460 ^ -1072507729;
            continue;
          case 48:
label_12:
            this.btnFlood = (Button) target;
            num2 = -987199838;
            continue;
          case 49:
label_6:
            MeetingManagementControl.\u202C⁭‎⁪⁯‮⁪‬⁪‭⁭‏‪‪‬‪⁮‪‬‏​⁯‏​⁮‫⁫​⁬⁬‍‭⁫‫⁯⁪‏‏​⁮‮((FrameworkElement) target, new RoutedEventHandler(this.UserControl_Loaded));
            num2 = -567190972;
            continue;
          case 50:
            num2 = (int) num4 * -420880059 ^ -183874190;
            continue;
          default:
            goto label_54;
        }
      }
label_54:
      return;
label_3:;
    }

    static Uri \u202E‭‎‍⁭‏‎‭‎‮‫⁪‬‭⁯‎‮‬‌‫⁬⁮‪⁮⁭⁭‪⁬⁭‌‭⁫‮‫‭⁪‎⁫‪‏‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u206B⁯‌​‫‪⁬‬‎‮⁫‎‫​‏⁯⁫⁯‮​‌‏‍‭‬‏‬​⁪⁯‭‌⁭‫‪⁫‭‮​⁭‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u202C⁭‎⁪⁯‮⁪‬⁪‭⁭‏‪‪‬‪⁮‪‬‏​⁯‏​⁮‫⁫​⁬⁬‍‭⁫‫⁯⁪‏‏​⁮‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }

    static void \u202E⁯⁮‍⁪‏​‫⁬⁭‫⁪‫‮‎​‌​​⁭‫‎⁪⁯⁬​‏‎‬‌‬⁪⁫‪⁮‪‎‌‮⁪‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Unloaded += obj1;
    }
  }
}
