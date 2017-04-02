// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Events.WarSettings
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace ZoomZoom.Models.Events
{
  public class WarSettings
  {
    public bool WarEnabled { get; set; }

    public bool FloodAfterJoin { get; internal set; }

    public string ForceMeeting { get; internal set; }

    public MeetingEventAction MeetingRemovalAction { get; internal set; }

    public MeetingEventAction MeetingHoldAction { get; internal set; }

    public bool FloodHostAfterJoin { get; internal set; }

    public bool FindButtonsAfterJoin { get; internal set; }

    public List<ZoomButton> MeetingButtons { get; internal set; }

    public bool AutoAttendent { get; internal set; }

    public static string XmlSerializeToString(object objectInstance)
    {
label_1:
      int num1 = 226527610;
      XmlSerializer xmlSerializer;
      while (true)
      {
        int num2 = 22877589;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            xmlSerializer = WarSettings.\u206F‫‬⁮‌‭‭⁮⁫⁭⁯‎‮‪‭⁫⁫​‮​​‎​‫⁭⁯⁭⁮⁫​⁯‪⁪‎⁮⁯⁭⁬‫‬‮(WarSettings.\u202D⁫‪‬‭‬‭‫‬⁭‌⁪​​​⁭‪‎⁭⁪‎⁫‎‎⁬‪‫⁫‬⁯⁬‪⁪⁯⁫⁬⁬‍‭⁪‮(objectInstance));
            num1 = (int) num3 * 1047516128 ^ -684987545;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      StringBuilder stringBuilder = WarSettings.\u200B⁭‏‬‎​‍‭⁯‏‌⁮⁫‮‪‎⁯⁭‏⁯‎⁬⁪‫⁯⁬‫‏‮‮‌‌⁬⁪‬‮‎⁮⁬‎‮();
      TextWriter textWriter = (TextWriter) WarSettings.\u200C‫⁯⁯‬‫‬⁭‫‪‏‬‮⁪‭‎⁭‬‍‬⁪‪​⁬​‫‌‎‮‏‫‫⁬‏⁭​⁫⁪‎‮(stringBuilder);
      try
      {
        WarSettings.\u206C‏‫‭‫⁪‎⁬‮⁭⁯⁪‍‭⁪‫⁭‍⁭⁫‫‫‎‫‮‍‫‌‮‭​‭⁪​‬‮‮⁪‏⁮‮(xmlSerializer, textWriter, objectInstance);
      }
      finally
      {
        if (textWriter != null)
        {
label_7:
          int num2 = 465434984;
          while (true)
          {
            int num3 = 22877589;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 1:
                WarSettings.\u202A⁮‭⁭​⁫⁪​‭⁫⁮‏‮‍⁬⁫⁯⁭‎⁫‬⁯⁭‎‍‫‪‌‬‪​‍⁫‪‭⁮‍‪‌‮((IDisposable) textWriter);
                num2 = (int) num4 * 1967853560 ^ 1869639469;
                continue;
              case 2:
                goto label_7;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
      string str = WarSettings.\u206C⁯‭​⁫⁫⁬​‌​‭⁮‎‬‮‮‍⁯‪‭‎‌‍‬⁪‫⁯⁪⁯‫⁪‫‪‌‏‬⁮‏‏‏‮((object) stringBuilder);
label_12:
      int num5 = 899499183;
      while (true)
      {
        int num2 = 22877589;
        uint num3;
        switch ((num3 = (uint) (num5 ^ num2)) % 3U)
        {
          case 0:
            goto label_12;
          case 2:
            num5 = (int) num3 * 1442672184 ^ -1115495037;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return str;
    }

    public static object XmlDeserializeFromString(string objectData)
    {
      // ISSUE: type reference
      XmlSerializer xmlSerializer = WarSettings.\u206F‫‬⁮‌‭‭⁮⁫⁭⁯‎‮‪‭⁫⁫​‮​​‎​‫⁭⁯⁭⁮⁫​⁯‪⁪‎⁮⁯⁭⁬‫‬‮(WarSettings.\u200E‫⁫‌‫⁪‎‬‪‏‮​⁯⁬⁪‪‮‌‪‏‎‮⁫⁯⁭‫‎⁬‎⁯‫⁪​‌​⁪‪⁬‭⁭‮(__typeref (WarSettings)));
      TextReader textReader = (TextReader) WarSettings.\u200F‬⁬‭⁫⁮‌‪⁮‌‮‎‍⁫‬‍‬‭​‬⁬‬⁪‏⁮⁮‎⁫⁯⁫⁪‌​‪‪​⁯⁬‪⁯‮(objectData);
      object obj1;
      try
      {
label_2:
        int num1 = 1867445316;
        while (true)
        {
          int num2 = 1393690477;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -189880252 ^ -844249574;
              continue;
            case 1:
              obj1 = WarSettings.\u206B‍‌‏‍‪‏⁪‭‪⁫‌​‍‎‫⁬‬‬⁫‏‏‪‭​‭⁭‏‎‫‌‍⁫‏⁯​‪⁬‌⁮‮(xmlSerializer, textReader);
              num1 = (int) num3 * -1437921020 ^ -244746507;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        if (textReader != null)
        {
label_7:
          int num1 = 898011228;
          while (true)
          {
            int num2 = 1393690477;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_7;
              case 1:
                WarSettings.\u202A⁮‭⁭​⁫⁪​‭⁫⁮‏‮‍⁬⁫⁯⁭‎⁫‬⁯⁭‎‍‫‪‌‬‪​‍⁫‪‭⁮‍‪‌‮((IDisposable) textReader);
                num1 = (int) num3 * -587286793 ^ -1634906031;
                continue;
              case 3:
                num1 = (int) num3 * -637318587 ^ 1969501276;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
label_12:
      object obj2 = obj1;
label_13:
      int num4 = 14279353;
      while (true)
      {
        int num1 = 1393690477;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_13;
          case 1:
            num4 = (int) num2 * 1762234876 ^ 1525079357;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return obj2;
    }

    static Type \u202D⁫‪‬‭‬‭‫‬⁭‌⁪​​​⁭‪‎⁭⁪‎⁫‎‎⁬‪‫⁫‬⁯⁬‪⁪⁯⁫⁬⁬‍‭⁪‮([In] object obj0)
    {
      return obj0.GetType();
    }

    static XmlSerializer \u206F‫‬⁮‌‭‭⁮⁫⁭⁯‎‮‪‭⁫⁫​‮​​‎​‫⁭⁯⁭⁮⁫​⁯‪⁪‎⁮⁯⁭⁬‫‬‮([In] Type obj0)
    {
      return new XmlSerializer(obj0);
    }

    static StringBuilder \u200B⁭‏‬‎​‍‭⁯‏‌⁮⁫‮‪‎⁯⁭‏⁯‎⁬⁪‫⁯⁬‫‏‮‮‌‌⁬⁪‬‮‎⁮⁬‎‮()
    {
      return new StringBuilder();
    }

    static StringWriter \u200C‫⁯⁯‬‫‬⁭‫‪‏‬‮⁪‭‎⁭‬‍‬⁪‪​⁬​‫‌‎‮‏‫‫⁬‏⁭​⁫⁪‎‮([In] StringBuilder obj0)
    {
      return new StringWriter(obj0);
    }

    static void \u206C‏‫‭‫⁪‎⁬‮⁭⁯⁪‍‭⁪‫⁭‍⁭⁫‫‫‎‫‮‍‫‌‮‭​‭⁪​‬‮‮⁪‏⁮‮([In] XmlSerializer obj0, [In] TextWriter obj1, [In] object obj2)
    {
      obj0.Serialize(obj1, obj2);
    }

    static void \u202A⁮‭⁭​⁫⁪​‭⁫⁮‏‮‍⁬⁫⁯⁭‎⁫‬⁯⁭‎‍‫‪‌‬‪​‍⁫‪‭⁮‍‪‌‮([In] IDisposable obj0)
    {
      obj0.Dispose();
    }

    static string \u206C⁯‭​⁫⁫⁬​‌​‭⁮‎‬‮‮‍⁯‪‭‎‌‍‬⁪‫⁯⁪⁯‫⁪‫‪‌‏‬⁮‏‏‏‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static Type \u200E‫⁫‌‫⁪‎‬‪‏‮​⁯⁬⁪‪‮‌‪‏‎‮⁫⁯⁭‫‎⁬‎⁯‫⁪​‌​⁪‪⁬‭⁭‮([In] RuntimeTypeHandle obj0)
    {
      return Type.GetTypeFromHandle(obj0);
    }

    static StringReader \u200F‬⁬‭⁫⁮‌‪⁮‌‮‎‍⁫‬‍‬‭​‬⁬‬⁪‏⁮⁮‎⁫⁯⁫⁪‌​‪‪​⁯⁬‪⁯‮([In] string obj0)
    {
      return new StringReader(obj0);
    }

    static object \u206B‍‌‏‍‪‏⁪‭‪⁫‌​‍‎‫⁬‬‬⁫‏‏‪‭​‭⁭‏‎‫‌‍⁫‏⁯​‪⁬‌⁮‮([In] XmlSerializer obj0, [In] TextReader obj1)
    {
      return obj0.Deserialize(obj1);
    }
  }
}
