// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Converters.DisplayStringAttribute
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Converters
{
  [AttributeUsage(AttributeTargets.Field)]
  public sealed class DisplayStringAttribute : Attribute
  {
    private readonly string value;

    public string Value
    {
      get
      {
label_1:
        int num1 = -328105904;
        string str;
        while (true)
        {
          int num2 = -111474733;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -249002558 ^ 698776986;
              continue;
            case 3:
              str = this.value;
              num1 = (int) num3 * 1780842147 ^ -1534851680;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return str;
      }
    }

    public string ResourceKey { get; set; }

    public DisplayStringAttribute(string v)
    {
label_1:
      int num1 = -1739948500;
      while (true)
      {
        int num2 = -642342700;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * -60259844 ^ -2057420492;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.value = v;
    }

    public DisplayStringAttribute()
    {
    }
  }
}
