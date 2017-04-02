// Decompiled with JetBrains decompiler
// Type: flaphx.utils.TBBUTTON
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace flaphx.utils
{
  internal struct TBBUTTON
  {
    public int iBitmap;
    public int idCommand;
    public byte fsState;
    public byte fsStyle;
    public byte bReserved1;
    public byte bReserved2;
    public uint dwData;
    public IntPtr ipText;
  }
}
