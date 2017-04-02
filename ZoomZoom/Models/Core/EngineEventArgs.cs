// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Core.EngineEventArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models.Core
{
  public class EngineEventArgs : EventArgs
  {
    public Engine Engine { get; set; }

    public Exception Exception { get; set; }

    public EngineEvent EngineEvent { get; set; }

    public EngineState EngineState { get; set; }

    public MachineState MachineState { get; set; }

    public bool QuitApplication { get; set; }

    public string StatusMessage { get; set; }

    public EngineEventArgs(Engine engine)
    {
      this.Engine = engine;
    }
  }
}
