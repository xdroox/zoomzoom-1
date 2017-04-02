// Decompiled with JetBrains decompiler
// Type: flaphx.utils.TBBUTTONINFO
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace flaphx.utils
{
  internal struct TBBUTTONINFO
  {
    public uint cbSize;
    public uint dwMask;
    public int idCommand;
    public int iImage;
    public byte fsState;
    public byte fsStyle;
    public ushort cx;
    public uint lParam;
    public IntPtr pszText;
    public int cchText;
  }
}
