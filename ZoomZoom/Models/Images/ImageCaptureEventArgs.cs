// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.ImageCaptureEventArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models.Images
{
  internal class ImageCaptureEventArgs : EventArgs
  {
    internal CaptureRequest Request { get; set; }

    internal CaptureResult Result { get; set; }

    public ImageCaptureEventArgs(CaptureResult result)
    {
      this.Result = result;
      this.Request = result.Request;
    }
  }
}
