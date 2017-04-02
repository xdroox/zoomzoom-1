// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Events.KeyEventData
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Windows.Forms;

namespace ZoomZoom.Models.Events
{
  public class KeyEventData
  {
    public bool IsCtrlDown { get; set; }

    public bool IsAltDown { get; set; }

    public bool IsShiftDown { get; set; }

    public Keys Keys { get; set; }
  }
}
