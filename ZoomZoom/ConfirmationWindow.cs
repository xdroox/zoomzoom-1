// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ConfirmationWindow
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;

namespace ZoomZoom
{
  public class ConfirmationWindow : RadWindow
  {
    public ConfirmationWindow()
    {
      base.\u002Ector();
    }

    public static void Alert(string message, int width = 400)
    {
      DialogParameters dialogParameters1 = ConfirmationWindow.\u200B⁭‎⁪⁯‪‬‌⁮‏⁭⁮‌‪‍‏‬‌‫⁯‬‏⁮‌‪⁫‭⁯​​‌‮‬‪​‏‭⁭⁫⁮‮();
      TextBlock textBlock = ConfirmationWindow.\u200D⁬⁪‎⁪​⁮⁬‮⁮‏⁬‍‮‏‬‫‭‭‬⁬⁫‬‌‮‫‎‍‍‎‪‬‮⁭‏‬‍‪‏⁫‮();
      string str = message;
      ConfirmationWindow.\u200F‬‎⁯‏⁯‬‪‪‬‍‪⁪⁪‭​‫⁬⁫‭⁬⁪‏⁫‍⁯⁪‫‭‏‌‎⁫‪⁯⁯‎‮‪⁯‮(textBlock, str);
      double num1 = (double) width;
      ConfirmationWindow.\u200D‬⁯‭‫⁫‏⁫⁭‮‭‭‭⁮‮⁬⁪‪⁮​⁬⁬⁯‭‍‭‏‪‮⁮‫⁮‎‏‌‫​‏‪‪‮((FrameworkElement) textBlock, num1);
      int num2 = 2;
      ConfirmationWindow.\u206E‮‎⁮‌‏‏⁭‍‍‍⁬⁬‌‍‍⁪⁭⁫‮‪‫⁭​‪⁫⁬⁬⁫⁬⁫‏‌⁪​⁬‏⁮⁪⁯‮(textBlock, (TextWrapping) num2);
      ConfirmationWindow.\u202E‎⁮‮⁮‎‍⁭⁪‬‎‭⁯‎⁬‬‫​‪‫‮‪⁮​⁭‫‫⁯‪⁯⁭​⁫‎⁮​⁬‭⁪⁮‮(dialogParameters1, (object) textBlock);
      Window window = ConfirmationWindow.\u206C⁯‍⁬⁪‏​⁬‬‫⁮‍⁮‍⁭‌‮⁫‪‪‏‎​‎‮‌‏‫‪‎‍‎⁫​‌‮⁭‍‏⁪‮(ConfirmationWindow.\u200D‌‪‬⁫‍‌‮‪⁭⁬‏⁯‏⁬‎⁯‏‭‏‫​‏⁯‭‌‏⁭‪‬‌⁭⁬‎⁯⁯‪‎⁬⁯‮());
      ConfirmationWindow.\u202D​‭‏⁬‏⁯​⁯⁮‌​‬‌⁯‮​‪‏⁭​⁯‭‌‎‬‭⁭‍‮⁪​⁬⁫​⁭⁬‮‪⁮‮(dialogParameters1, (ContentControl) window);
      DialogParameters dialogParameters2 = dialogParameters1;
label_1:
      int num3 = 1923332203;
      while (true)
      {
        int num4 = 1456619733;
        uint num5;
        switch ((num5 = (uint) (num3 ^ num4)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ConfirmationWindow.\u206D‫⁫⁪‮‎‎⁪⁭⁪‎‎‭‏‭‮⁬‫⁮‬‫‫‍‬⁫‬⁯‌⁪⁪⁯‪⁬⁪‌‍‎‫‌‪‮(dialogParameters2);
            num3 = (int) num5 * -933188666 ^ 2020076850;
            continue;
          case 3:
            num3 = (int) num5 * 1976533963 ^ 1894033017;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    public static void Confirm(string message, EventHandler<WindowClosedEventArgs> closed, int width = 400)
    {
      DialogParameters dialogParameters = ConfirmationWindow.\u200B⁭‎⁪⁯‪‬‌⁮‏⁭⁮‌‪‍‏‬‌‫⁯‬‏⁮‌‪⁫‭⁯​​‌‮‬‪​‏‭⁭⁫⁮‮();
      TextBlock textBlock = ConfirmationWindow.\u200D⁬⁪‎⁪​⁮⁬‮⁮‏⁬‍‮‏‬‫‭‭‬⁬⁫‬‌‮‫‎‍‍‎‪‬‮⁭‏‬‍‪‏⁫‮();
      string str1 = message;
      ConfirmationWindow.\u200F‬‎⁯‏⁯‬‪‪‬‍‪⁪⁪‭​‫⁬⁫‭⁬⁪‏⁫‍⁯⁪‫‭‏‌‎⁫‪⁯⁯‎‮‪⁯‮(textBlock, str1);
      double num1 = (double) width;
      ConfirmationWindow.\u200D‬⁯‭‫⁫‏⁫⁭‮‭‭‭⁮‮⁬⁪‪⁮​⁬⁬⁯‭‍‭‏‪‮⁮‫⁮‎‏‌‫​‏‪‪‮((FrameworkElement) textBlock, num1);
      int num2 = 2;
      ConfirmationWindow.\u206E‮‎⁮‌‏‏⁭‍‍‍⁬⁬‌‍‍⁪⁭⁫‮‪‫⁭​‪⁫⁬⁬⁫⁬⁫‏‌⁪​⁬‏⁮⁪⁯‮(textBlock, (TextWrapping) num2);
      ConfirmationWindow.\u202E‎⁮‮⁮‎‍⁭⁪‬‎‭⁯‎⁬‬‫​‪‫‮‪⁮​⁭‫‫⁯‪⁯⁭​⁫‎⁮​⁬‭⁪⁮‮(dialogParameters, (object) textBlock);
      string str2 = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4108996109U);
      ConfirmationWindow.\u200B⁯‏⁪‬​‮‍‪‎‮‎⁯‬‮‌⁪⁭‪‮‮⁬‫⁫‬‭‏‬‍⁮‌‪‪‭⁫‫‭‍‎⁫‮(dialogParameters, (object) str2);
      string str3 = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2654545477U);
      ConfirmationWindow.\u206F⁪​‪‮⁭‌‎‌⁯⁫‪​‫⁯‪‭‌‮⁪‭‮​‭‌⁪‮‪‭‭⁬‎‮‏⁫‌⁯‍‭‮(dialogParameters, (object) str3);
      EventHandler<WindowClosedEventArgs> eventHandler = closed;
      ConfirmationWindow.\u206A‎‬‎‮‭‪‌​‭‎⁬⁪‬‪‌⁫‬⁫⁬⁬⁪‫‎‮‏‪‭‭​‭‪‮⁬‭⁫‍‫‪⁯‮(dialogParameters, eventHandler);
      Window window = ConfirmationWindow.\u206C⁯‍⁬⁪‏​⁬‬‫⁮‍⁮‍⁭‌‮⁫‪‪‏‎​‎‮‌‏‫‪‎‍‎⁫​‌‮⁭‍‏⁪‮(ConfirmationWindow.\u200D‌‪‬⁫‍‌‮‪⁭⁬‏⁯‏⁬‎⁯‏‭‏‫​‏⁯‭‌‏⁭‪‬‌⁭⁬‎⁯⁯‪‎⁬⁯‮());
      ConfirmationWindow.\u202D​‭‏⁬‏⁯​⁯⁮‌​‬‌⁯‮​‪‏⁭​⁯‭‌‎‬‭⁭‍‮⁪​⁬⁫​⁭⁬‮‪⁮‮(dialogParameters, (ContentControl) window);
      ConfirmationWindow.\u200B⁮‎‫‮⁮​‎‬‍⁬‬‪‌‬‏⁫⁪‍‮‍‭‮⁭⁬‮‫‮⁫⁬‍‌‫⁫‮‫​‪‍⁯‮(dialogParameters);
label_1:
      int num3 = 547398914;
      while (true)
      {
        int num4 = 228941397;
        uint num5;
        switch ((num5 = (uint) (num3 ^ num4)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num3 = (int) num5 * 752961306 ^ 1570273528;
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

    public static void Prompt(string message, EventHandler<WindowClosedEventArgs> closed, int width = 400)
    {
label_1:
      int num1 = -2027896472;
      while (true)
      {
        int num2 = -225222726;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            DialogParameters dialogParameters = ConfirmationWindow.\u200B⁭‎⁪⁯‪‬‌⁮‏⁭⁮‌‪‍‏‬‌‫⁯‬‏⁮‌‪⁫‭⁯​​‌‮‬‪​‏‭⁭⁫⁮‮();
            TextBlock textBlock = ConfirmationWindow.\u200D⁬⁪‎⁪​⁮⁬‮⁮‏⁬‍‮‏‬‫‭‭‬⁬⁫‬‌‮‫‎‍‍‎‪‬‮⁭‏‬‍‪‏⁫‮();
            string str1 = message;
            ConfirmationWindow.\u200F‬‎⁯‏⁯‬‪‪‬‍‪⁪⁪‭​‫⁬⁫‭⁬⁪‏⁫‍⁯⁪‫‭‏‌‎⁫‪⁯⁯‎‮‪⁯‮(textBlock, str1);
            double num4 = (double) width;
            ConfirmationWindow.\u200D‬⁯‭‫⁫‏⁫⁭‮‭‭‭⁮‮⁬⁪‪⁮​⁬⁬⁯‭‍‭‏‪‮⁮‫⁮‎‏‌‫​‏‪‪‮((FrameworkElement) textBlock, num4);
            int num5 = 2;
            ConfirmationWindow.\u206E‮‎⁮‌‏‏⁭‍‍‍⁬⁬‌‍‍⁪⁭⁫‮‪‫⁭​‪⁫⁬⁬⁫⁬⁫‏‌⁪​⁬‏⁮⁪⁯‮(textBlock, (TextWrapping) num5);
            ConfirmationWindow.\u202E‎⁮‮⁮‎‍⁭⁪‬‎‭⁯‎⁬‬‫​‪‫‮‪⁮​⁭‫‫⁯‪⁯⁭​⁫‎⁮​⁬‭⁪⁮‮(dialogParameters, (object) textBlock);
            string str2 = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(447670033U);
            ConfirmationWindow.\u200B⁯‏⁪‬​‮‍‪‎‮‎⁯‬‮‌⁪⁭‪‮‮⁬‫⁫‬‭‏‬‍⁮‌‪‪‭⁫‫‭‍‎⁫‮(dialogParameters, (object) str2);
            string str3 = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2726924953U);
            ConfirmationWindow.\u206F⁪​‪‮⁭‌‎‌⁯⁫‪​‫⁯‪‭‌‮⁪‭‮​‭‌⁪‮‪‭‭⁬‎‮‏⁫‌⁯‍‭‮(dialogParameters, (object) str3);
            EventHandler<WindowClosedEventArgs> eventHandler = closed;
            ConfirmationWindow.\u206A‎‬‎‮‭‪‌​‭‎⁬⁪‬‪‌⁫‬⁫⁬⁬⁪‫‎‮‏‪‭‭​‭‪‮⁬‭⁫‍‫‪⁯‮(dialogParameters, eventHandler);
            Window window = ConfirmationWindow.\u206C⁯‍⁬⁪‏​⁬‬‫⁮‍⁮‍⁭‌‮⁫‪‪‏‎​‎‮‌‏‫‪‎‍‎⁫​‌‮⁭‍‏⁪‮(ConfirmationWindow.\u200D‌‪‬⁫‍‌‮‪⁭⁬‏⁯‏⁬‎⁯‏‭‏‫​‏⁯‭‌‏⁭‪‬‌⁭⁬‎⁯⁯‪‎⁬⁯‮());
            ConfirmationWindow.\u202D​‭‏⁬‏⁯​⁯⁮‌​‬‌⁯‮​‪‏⁭​⁯‭‌‎‬‭⁭‍‮⁪​⁬⁫​⁭⁬‮‪⁮‮(dialogParameters, (ContentControl) window);
            ConfirmationWindow.\u206C⁬⁫‍⁪‮⁫⁫⁮‬​⁮⁯‬‪‎‮⁮⁬‏⁭‬‍⁪‫‮⁬​​‬‌‌⁫‬​‭⁭‬‌⁭‮(dialogParameters);
            num1 = (int) num3 * -1726818930 ^ -889134255;
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

    static DialogParameters \u200B⁭‎⁪⁯‪‬‌⁮‏⁭⁮‌‪‍‏‬‌‫⁯‬‏⁮‌‪⁫‭⁯​​‌‮‬‪​‏‭⁭⁫⁮‮()
    {
      return new DialogParameters();
    }

    static TextBlock \u200D⁬⁪‎⁪​⁮⁬‮⁮‏⁬‍‮‏‬‫‭‭‬⁬⁫‬‌‮‫‎‍‍‎‪‬‮⁭‏‬‍‪‏⁫‮()
    {
      return new TextBlock();
    }

    static void \u200F‬‎⁯‏⁯‬‪‪‬‍‪⁪⁪‭​‫⁬⁫‭⁬⁪‏⁫‍⁯⁪‫‭‏‌‎⁫‪⁯⁯‎‮‪⁯‮([In] TextBlock obj0, [In] string obj1)
    {
      obj0.Text = obj1;
    }

    static void \u200D‬⁯‭‫⁫‏⁫⁭‮‭‭‭⁮‮⁬⁪‪⁮​⁬⁬⁯‭‍‭‏‪‮⁮‫⁮‎‏‌‫​‏‪‪‮([In] FrameworkElement obj0, [In] double obj1)
    {
      obj0.Width = obj1;
    }

    static void \u206E‮‎⁮‌‏‏⁭‍‍‍⁬⁬‌‍‍⁪⁭⁫‮‪‫⁭​‪⁫⁬⁬⁫⁬⁫‏‌⁪​⁬‏⁮⁪⁯‮([In] TextBlock obj0, [In] TextWrapping obj1)
    {
      obj0.TextWrapping = obj1;
    }

    static void \u202E‎⁮‮⁮‎‍⁭⁪‬‎‭⁯‎⁬‬‫​‪‫‮‪⁮​⁭‫‫⁯‪⁯⁭​⁫‎⁮​⁬‭⁪⁮‮([In] DialogParameters obj0, [In] object obj1)
    {
      obj0.set_Content(obj1);
    }

    static Application \u200D‌‪‬⁫‍‌‮‪⁭⁬‏⁯‏⁬‎⁯‏‭‏‫​‏⁯‭‌‏⁭‪‬‌⁭⁬‎⁯⁯‪‎⁬⁯‮()
    {
      return Application.Current;
    }

    static Window \u206C⁯‍⁬⁪‏​⁬‬‫⁮‍⁮‍⁭‌‮⁫‪‪‏‎​‎‮‌‏‫‪‎‍‎⁫​‌‮⁭‍‏⁪‮([In] Application obj0)
    {
      return obj0.MainWindow;
    }

    static void \u202D​‭‏⁬‏⁯​⁯⁮‌​‬‌⁯‮​‪‏⁭​⁯‭‌‎‬‭⁭‍‮⁪​⁬⁫​⁭⁬‮‪⁮‮([In] DialogParameters obj0, [In] ContentControl obj1)
    {
      obj0.set_Owner(obj1);
    }

    static void \u206D‫⁫⁪‮‎‎⁪⁭⁪‎‎‭‏‭‮⁬‫⁮‬‫‫‍‬⁫‬⁯‌⁪⁪⁯‪⁬⁪‌‍‎‫‌‪‮([In] DialogParameters obj0)
    {
      RadWindow.Alert(obj0);
    }

    static void \u200B⁯‏⁪‬​‮‍‪‎‮‎⁯‬‮‌⁪⁭‪‮‮⁬‫⁫‬‭‏‬‍⁮‌‪‪‭⁫‫‭‍‎⁫‮([In] DialogParameters obj0, [In] object obj1)
    {
      obj0.set_OkButtonContent(obj1);
    }

    static void \u206F⁪​‪‮⁭‌‎‌⁯⁫‪​‫⁯‪‭‌‮⁪‭‮​‭‌⁪‮‪‭‭⁬‎‮‏⁫‌⁯‍‭‮([In] DialogParameters obj0, [In] object obj1)
    {
      obj0.set_CancelButtonContent(obj1);
    }

    static void \u206A‎‬‎‮‭‪‌​‭‎⁬⁪‬‪‌⁫‬⁫⁬⁬⁪‫‎‮‏‪‭‭​‭‪‮⁬‭⁫‍‫‪⁯‮([In] DialogParameters obj0, [In] EventHandler<WindowClosedEventArgs> obj1)
    {
      obj0.set_Closed(obj1);
    }

    static void \u200B⁮‎‫‮⁮​‎‬‍⁬‬‪‌‬‏⁫⁪‍‮‍‭‮⁭⁬‮‫‮⁫⁬‍‌‫⁫‮‫​‪‍⁯‮([In] DialogParameters obj0)
    {
      RadWindow.Confirm(obj0);
    }

    static void \u206C⁬⁫‍⁪‮⁫⁫⁮‬​⁮⁯‬‪‎‮⁮⁬‏⁭‬‍⁪‫‮⁬​​‬‌‌⁫‬​‭⁭‬‌⁭‮([In] DialogParameters obj0)
    {
      RadWindow.Prompt(obj0);
    }
  }
}
