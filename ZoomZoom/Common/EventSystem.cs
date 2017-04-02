// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.EventSystem
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using Microsoft.Practices.Prism.Events;
using System;
using System.Runtime.InteropServices;

namespace ZoomZoom.Common
{
  public static class EventSystem
  {
    private static IEventAggregator _current;

    public static IEventAggregator Current
    {
      get
      {
        IEventAggregator ieventAggregator = EventSystem._current ?? (EventSystem._current = (IEventAggregator) EventSystem.\u200E⁫‌⁫‪‎⁫⁫⁭⁪‪⁮‎‎⁯‬‬⁪‍‮‌‪⁪⁭⁫⁪⁯⁯⁮‬‏⁬‬‬‎‮‬⁪‍‭‮());
label_1:
        int num1 = -1631270212;
        while (true)
        {
          int num2 = -184069380;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 244448720 ^ 821863652;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return ieventAggregator;
      }
    }

    private static CompositePresentationEvent<TEvent> GetEvent<TEvent>()
    {
label_1:
      int num1 = 196543819;
      CompositePresentationEvent<TEvent> presentationEvent;
      while (true)
      {
        int num2 = 1703870836;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1038905808 ^ 686353521;
            continue;
          case 2:
            goto label_1;
          case 3:
            presentationEvent = (CompositePresentationEvent<TEvent>) EventSystem.Current.GetEvent<CompositePresentationEvent<TEvent>>();
            num1 = (int) num3 * 767757766 ^ 1417353698;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return presentationEvent;
    }

    public static void Publish<TEvent>()
    {
label_1:
      int num1 = -551831151;
      while (true)
      {
        int num2 = -1080925613;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            EventSystem.Publish<TEvent>(default (TEvent));
            num1 = (int) num3 * 808186986 ^ 2091105904;
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

    public static void Publish<TEvent>(TEvent @event)
    {
label_1:
      int num1 = 1934021327;
      while (true)
      {
        int num2 = 753287589;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1922582074 ^ -1344516;
            continue;
          case 2:
            EventSystem.GetEvent<TEvent>().Publish(@event);
            num1 = (int) num3 * -1542967713 ^ -821543446;
            continue;
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

    public static SubscriptionToken Subscribe<TEvent>(Action action, ThreadOption threadOption = 0, bool keepSubscriberReferenceAlive = false)
    {
label_1:
      int num1 = -750605845;
      SubscriptionToken subscriptionToken;
      while (true)
      {
        int num2 = -1418082192;
        uint num3;
        Action action1;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            action1 = action;
            num1 = (int) num3 * 252453975 ^ 1329304813;
            continue;
          case 2:
            subscriptionToken = EventSystem.Subscribe<TEvent>((Action<TEvent>) (e => action1.Invoke()), threadOption, keepSubscriberReferenceAlive, (Predicate<TEvent>) null);
            num1 = (int) num3 * 285195750 ^ -1220031749;
            continue;
          case 3:
            num1 = (int) num3 * -516267740 ^ 2102403064;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return subscriptionToken;
    }

    public static SubscriptionToken Subscribe<TEvent>(Action<TEvent> action, ThreadOption threadOption = 0, bool keepSubscriberReferenceAlive = false, Predicate<TEvent> filter = null)
    {
label_1:
      int num1 = 1943181974;
      SubscriptionToken subscriptionToken;
      while (true)
      {
        int num2 = 1359680912;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            num1 = (int) num3 * -474459873 ^ 1745830435;
            continue;
          case 2:
            subscriptionToken = EventSystem.GetEvent<TEvent>().Subscribe(action, threadOption, keepSubscriberReferenceAlive, filter);
            num1 = (int) num3 * -932479644 ^ 979201281;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return subscriptionToken;
    }

    public static void Unsubscribe<TEvent>(SubscriptionToken token)
    {
      EventSystem.\u202E​⁫‭⁪⁯⁮⁬‌⁪⁫⁪⁬⁭‬⁯⁮‪‏⁭‌⁪‌‮​⁭‌‌⁭‫⁯‮‌‮‌⁪​‌‍‫‮((EventBase) EventSystem.GetEvent<TEvent>(), token);
label_1:
      int num1 = -684128334;
      while (true)
      {
        int num2 = -127432896;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 1309579309 ^ -1846290424;
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

    public static void Unsubscribe<TEvent>(Action<TEvent> subscriber)
    {
label_1:
      int num1 = -1081253152;
      while (true)
      {
        int num2 = -662036061;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 1503362434 ^ 2021464351;
            continue;
          case 2:
            goto label_3;
          case 3:
            EventSystem.GetEvent<TEvent>().Unsubscribe(subscriber);
            num1 = (int) num3 * 1951030387 ^ 201468199;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return;
label_3:;
    }

    static EventAggregator \u200E⁫‌⁫‪‎⁫⁫⁭⁪‪⁮‎‎⁯‬‬⁪‍‮‌‪⁪⁭⁫⁪⁯⁯⁮‬‏⁬‬‬‎‮‬⁪‍‭‮()
    {
      return new EventAggregator();
    }

    static void \u202E​⁫‭⁪⁯⁮⁬‌⁪⁫⁪⁬⁭‬⁯⁮‪‏⁭‌⁪‌‮​⁭‌‌⁭‫⁯‮‌‮‌⁪​‌‍‫‮([In] EventBase obj0, [In] SubscriptionToken obj1)
    {
      obj0.Unsubscribe(obj1);
    }
  }
}
