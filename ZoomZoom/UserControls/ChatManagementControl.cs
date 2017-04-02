// Decompiled with JetBrains decompiler
// Type: ZoomZoom.UserControls.ChatManagementControl
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

namespace ZoomZoom.UserControls
{
  public class ChatManagementControl : UserControl, IComponentConnector
  {
    internal ChatManagementControl TopWindow;
    internal CheckBox cbSendGreetingAfterJoin;
    internal Label lChatSource;
    internal ComboBox cbChatSource;
    internal CheckBox cbFloodEnabled;
    internal CheckBox cbFloodAfterJoin;
    internal CheckBox cbFloodPrivatelyAfterJoin;
    internal CheckBox cbFloodHostAfterJoin;
    internal CheckBox cbFloodTargetsAfterJoin;
    internal TextBox txtFloodTargets;
    internal TextBox txtFloodOptions_MessageContent;
    internal CheckBox cbRemoveUsersFlooding;
    internal CheckBox cbAutoResponderEnabled;
    internal TextBox txtAutoResponderMessage;
    internal CheckBox cbAutoRespondBlockedUser;
    internal TextBox txtAutoRespondBlockedUserMessage;
    internal TextBox txtAutoRespondBlockedUserList;
    internal CheckBox cbDesktopAlertEnabled;
    internal CheckBox cbDesktopAlert_ShowOnlyIfReceived;
    internal TextBox txtDesktopAlert_ShowOnlyIfReceived;
    internal ComboBox cbCategories;
    internal Button btnNewCategory;
    internal Button btnEditCategory;
    internal Button btnDeleteCategory;
    internal TextBox txtNewCategory;
    internal Button btnSaveCategory;
    internal Button btnCancelCategory;
    internal ComboBox cbContents;
    internal Button btnNewContent;
    internal Button btnEditContent;
    internal Button btnCopyClipboard;
    internal Button btnSetFloodDefault;
    internal Button btnDeleteContent;
    internal TextBox txtContent;
    internal Button btnSaveContent;
    internal Button btnCancelContent;
    internal ListBox listBox;
    private bool _contentLoaded;

    public ChatManagementControl()
    {
      this.InitializeComponent();
    }

    private void TopWindow_Loaded(object sender, RoutedEventArgs e)
    {
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (!this._contentLoaded)
        goto label_5;
label_1:
      int num1 = 1489329338;
label_2:
      while (true)
      {
        int num2 = 1519751923;
        uint num3;
        Uri uri;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            ChatManagementControl.\u206D⁪⁫⁭‭‮‏‪‏⁬⁯⁫⁭‬‪‌‭⁮‌⁭​‎‎‎⁯‏‮‍‬⁪‬⁫‬⁯‮⁬‌‍‏‎‮((object) this, uri);
            num1 = (int) num3 * 113222984 ^ -969268507;
            continue;
          case 1:
            num1 = (int) num3 * 406266341 ^ -1452351352;
            continue;
          case 2:
            goto label_3;
          case 3:
            uri = ChatManagementControl.\u202D‫‎⁪⁮‏⁫‎‬⁪‬‏​‫‍‏⁪⁪⁬⁬⁭⁯‬‬⁮​⁮​‍‎‫‬‫‏‪⁭‪⁭⁪‎‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2589042610U), UriKind.Relative);
            num1 = (int) num3 * -48939537 ^ -721418098;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_5;
          default:
            goto label_8;
        }
      }
label_8:
      return;
label_3:
      return;
label_5:
      this._contentLoaded = true;
      num1 = 2076280644;
      goto label_2;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      int num1 = connectionId;
label_1:
      int num2 = 1729585168;
      while (true)
      {
        int num3 = 1346994696;
        uint num4;
        switch ((num4 = (uint) (num2 ^ num3)) % 63U)
        {
          case 0:
            num2 = (int) num4 * -1249254799 ^ 1557838011;
            continue;
          case 1:
            num2 = (int) num4 * 2118629079 ^ 68327239;
            continue;
          case 2:
            num2 = (int) num4 * 1131449813 ^ 762079632;
            continue;
          case 3:
            num2 = (int) num4 * -46285424 ^ -1669638277;
            continue;
          case 4:
label_27:
            this.btnSaveCategory = (Button) target;
            num2 = 1356418647;
            continue;
          case 5:
label_17:
            this.cbFloodEnabled = (CheckBox) target;
            num2 = 1903907624;
            continue;
          case 6:
label_53:
            this.btnCancelContent = (Button) target;
            num2 = 1391867803;
            continue;
          case 7:
label_19:
            this.cbAutoResponderEnabled = (CheckBox) target;
            num2 = 1296872348;
            continue;
          case 8:
            num2 = (int) num4 * -278466018 ^ -610239523;
            continue;
          case 9:
label_29:
            this.btnSaveContent = (Button) target;
            num2 = 1572330379;
            continue;
          case 10:
            num2 = (int) num4 * 32227685 ^ 101230132;
            continue;
          case 11:
            num2 = (int) num4 * 1069277950 ^ 533852357;
            continue;
          case 12:
            num2 = (int) num4 * -540897749 ^ 1836145735;
            continue;
          case 13:
label_49:
            this.btnCancelCategory = (Button) target;
            num2 = 2083690134;
            continue;
          case 14:
label_33:
            this.cbFloodHostAfterJoin = (CheckBox) target;
            num2 = 1176290739;
            continue;
          case 15:
label_32:
            this.btnDeleteCategory = (Button) target;
            num2 = 1391867803;
            continue;
          case 16:
            goto label_1;
          case 17:
label_20:
            this.cbDesktopAlert_ShowOnlyIfReceived = (CheckBox) target;
            num2 = 1391867803;
            continue;
          case 18:
label_8:
            this.lChatSource = (Label) target;
            num2 = 1512874422;
            continue;
          case 19:
label_44:
            this.btnSetFloodDefault = (Button) target;
            num2 = 1916537060;
            continue;
          case 20:
label_21:
            this.cbDesktopAlertEnabled = (CheckBox) target;
            num2 = 1391867803;
            continue;
          case 21:
            num2 = (int) num4 * -228193633 ^ -1009359404;
            continue;
          case 22:
            num2 = (int) num4 * 1434983925 ^ 902259292;
            continue;
          case 23:
            goto label_3;
          case 24:
            this._contentLoaded = true;
            num2 = 1391867803;
            continue;
          case 25:
label_16:
            this.cbChatSource = (ComboBox) target;
            num2 = 1391867803;
            continue;
          case 26:
            num2 = (int) num4 * -214952039 ^ -1534092200;
            continue;
          case 27:
label_28:
            this.cbAutoRespondBlockedUser = (CheckBox) target;
            num2 = 1391867803;
            continue;
          case 28:
            num2 = (int) num4 * 2061567794 ^ -1732958451;
            continue;
          case 29:
label_35:
            this.cbRemoveUsersFlooding = (CheckBox) target;
            num2 = 1391867803;
            continue;
          case 30:
            switch (num1)
            {
              case 1:
                goto label_56;
              case 2:
                goto label_64;
              case 3:
                goto label_8;
              case 4:
                goto label_16;
              case 5:
                goto label_17;
              case 6:
                goto label_11;
              case 7:
                goto label_55;
              case 8:
                goto label_33;
              case 9:
                goto label_34;
              case 10:
                goto label_40;
              case 11:
                goto label_47;
              case 12:
                goto label_35;
              case 13:
                goto label_19;
              case 14:
                goto label_45;
              case 15:
                goto label_28;
              case 16:
                goto label_23;
              case 17:
                goto label_15;
              case 18:
                goto label_21;
              case 19:
                goto label_20;
              case 20:
                goto label_63;
              case 21:
                goto label_10;
              case 22:
                goto label_37;
              case 23:
                goto label_22;
              case 24:
                goto label_32;
              case 25:
                goto label_5;
              case 26:
                goto label_27;
              case 27:
                goto label_49;
              case 28:
                goto label_38;
              case 29:
                goto label_46;
              case 30:
                goto label_41;
              case 31:
                goto label_14;
              case 32:
                goto label_44;
              case 33:
                goto label_6;
              case 34:
                goto label_58;
              case 35:
                goto label_29;
              case 36:
                goto label_53;
              case 37:
                goto label_18;
              default:
                num2 = (int) num4 * -707764708 ^ -1290437189;
                continue;
            }
          case 31:
label_38:
            this.cbContents = (ComboBox) target;
            num2 = 1391867803;
            continue;
          case 32:
label_37:
            this.btnNewCategory = (Button) target;
            num2 = 1207480479;
            continue;
          case 33:
label_64:
            this.cbSendGreetingAfterJoin = (CheckBox) target;
            num2 = 855358373;
            continue;
          case 34:
            num2 = (int) num4 * -810753812 ^ -797092626;
            continue;
          case 35:
            num2 = (int) num4 * -1132761881 ^ 137628004;
            continue;
          case 36:
label_58:
            this.txtContent = (TextBox) target;
            num2 = 398215129;
            continue;
          case 37:
label_18:
            this.listBox = (ListBox) target;
            num2 = 1920303137;
            continue;
          case 38:
label_46:
            this.btnNewContent = (Button) target;
            num2 = 1391867803;
            continue;
          case 39:
label_47:
            this.txtFloodOptions_MessageContent = (TextBox) target;
            num2 = 1391867803;
            continue;
          case 40:
label_63:
            this.txtDesktopAlert_ShowOnlyIfReceived = (TextBox) target;
            num2 = 1391867803;
            continue;
          case 41:
label_5:
            this.txtNewCategory = (TextBox) target;
            num2 = 2129948995;
            continue;
          case 42:
label_41:
            this.btnEditContent = (Button) target;
            num2 = 1878016235;
            continue;
          case 43:
            ChatManagementControl.\u206F‭⁬​⁯⁪​⁮⁬‍‮‏‭‭⁬‫‫‌‍​⁬⁯⁮⁬‍⁯⁬​⁫‌⁫‮‮‭⁮‬⁬⁯⁫‫‮((FrameworkElement) this.TopWindow, new RoutedEventHandler(this.TopWindow_Loaded));
            num2 = (int) num4 * -497425000 ^ 2017558507;
            continue;
          case 44:
            num2 = (int) num4 * 603720442 ^ -1506858275;
            continue;
          case 45:
            num2 = (int) num4 * 791264953 ^ -1619321419;
            continue;
          case 46:
            num2 = (int) num4 * -1909293069 ^ 1765242398;
            continue;
          case 47:
label_22:
            this.btnEditCategory = (Button) target;
            num2 = 1391867803;
            continue;
          case 48:
            num2 = (int) num4 * -1549044340 ^ -224402805;
            continue;
          case 49:
label_6:
            this.btnDeleteContent = (Button) target;
            num2 = 1258730636;
            continue;
          case 50:
label_45:
            this.txtAutoResponderMessage = (TextBox) target;
            num2 = 532941999;
            continue;
          case 51:
label_34:
            this.cbFloodTargetsAfterJoin = (CheckBox) target;
            num2 = 1391867803;
            continue;
          case 52:
label_15:
            this.txtAutoRespondBlockedUserList = (TextBox) target;
            num2 = 1391867803;
            continue;
          case 53:
            num2 = (int) num4 * 1191740958 ^ 2098363873;
            continue;
          case 54:
label_56:
            this.TopWindow = (ChatManagementControl) target;
            num2 = 1580071838;
            continue;
          case 55:
label_11:
            this.cbFloodAfterJoin = (CheckBox) target;
            num2 = 1391867803;
            continue;
          case 56:
            num2 = (int) num4 * -1879494785 ^ -2048465294;
            continue;
          case 57:
            num2 = (int) num4 * -611020149 ^ 902328538;
            continue;
          case 58:
label_23:
            this.txtAutoRespondBlockedUserMessage = (TextBox) target;
            num2 = 853351575;
            continue;
          case 59:
label_10:
            this.cbCategories = (ComboBox) target;
            num2 = 1391867803;
            continue;
          case 60:
label_14:
            this.btnCopyClipboard = (Button) target;
            num2 = 480411019;
            continue;
          case 61:
label_55:
            this.cbFloodPrivatelyAfterJoin = (CheckBox) target;
            num2 = 1330825305;
            continue;
          case 62:
label_40:
            this.txtFloodTargets = (TextBox) target;
            num2 = 1391867803;
            continue;
          default:
            goto label_66;
        }
      }
label_66:
      return;
label_3:;
    }

    static Uri \u202D‫‎⁪⁮‏⁫‎‬⁪‬‏​‫‍‏⁪⁪⁬⁬⁭⁯‬‬⁮​⁮​‍‎‫‬‫‏‪⁭‪⁭⁪‎‮([In] string obj0, [In] UriKind obj1)
    {
      return new Uri(obj0, obj1);
    }

    static void \u206D⁪⁫⁭‭‮‏‪‏⁬⁯⁫⁭‬‪‌‭⁮‌⁭​‎‎‎⁯‏‮‍‬⁪‬⁫‬⁯‮⁬‌‍‏‎‮([In] object obj0, [In] Uri obj1)
    {
      Application.LoadComponent(obj0, obj1);
    }

    static void \u206F‭⁬​⁯⁪​⁮⁬‍‮‏‭‭⁬‫‫‌‍​⁬⁯⁮⁬‍⁯⁬​⁫‌⁫‮‮‭⁮‬⁬⁯⁫‫‮([In] FrameworkElement obj0, [In] RoutedEventHandler obj1)
    {
      obj0.Loaded += obj1;
    }
  }
}
