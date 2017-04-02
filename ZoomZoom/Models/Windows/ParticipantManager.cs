// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Windows.ParticipantManager
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;

namespace ZoomZoom.Models.Windows
{
  public class ParticipantManager : CoreObject
  {
    private List<string> findUserNames = new List<string>();
    private IntPtr windowHandle;

    public IntPtr WindowHandle
    {
      get
      {
label_1:
        int num1 = -1214988759;
        IntPtr windowHandle;
        while (true)
        {
          int num2 = -1557012808;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1778976005 ^ -2025225129;
              continue;
            case 1:
              windowHandle = this.windowHandle;
              num1 = (int) num3 * 174036659 ^ 1685431387;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return windowHandle;
      }
      set
      {
        this.windowHandle = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -197779934;
        TraceType traceType;
        while (true)
        {
          int num2 = -892475185;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1588016341 ^ 1903292993;
              continue;
            case 1:
              traceType = TraceType.Window;
              num1 = (int) num3 * -532234316 ^ -1324179625;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public ParticipantManager()
    {
label_1:
      int num1 = 970704101;
      while (true)
      {
        int num2 = 1944369432;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * -956819866 ^ -1512581584;
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
}
