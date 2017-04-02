// Decompiled with JetBrains decompiler
// Type: ZoomZoom.HighlightInfo
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Drawing;

namespace ZoomZoom
{
  public class HighlightInfo
  {
    public Color Color { get; set; }

    public Rectangle Rectangle { get; set; }

    public DateTime Created { get; set; }

    public DateTime Expires { get; set; }

    public bool Drawn { get; set; }

    public IntPtr Handle { get; set; }

    public ZoomWindowType ZoomWindowType { get; set; }

    public ZoomWindow ZoomWindow { get; set; }

    public bool UpdateLocation { get; internal set; }

    public bool IsExpired
    {
      get
      {
label_1:
        int num1 = 777396113;
        bool flag;
        while (true)
        {
          int num2 = 1475665235;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              flag = this.Expires < DateTime.Now;
              num1 = (int) num3 * 854568363 ^ -490377594;
              continue;
            case 3:
              num1 = (int) num3 * 439631900 ^ 930728890;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return flag;
      }
    }

    public Rectangle LastTarget { get; set; }

    public Rectangle LastTracking { get; set; }

    public Rectangle CurrentTarget
    {
      get
      {
        Rectangle windowRectangle = WindowHelper.GetWindowRectangle(this.Handle);
label_1:
        int num1 = -1203640023;
        while (true)
        {
          int num2 = -670202921;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1204071849 ^ 372768838;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowRectangle;
      }
    }

    public HighlightInfo(ZoomWindow higlightWindow, object source)
    {
label_1:
      int num1 = 465504161;
      while (true)
      {
        int num2 = 138346698;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 14U)
        {
          case 0:
            this.ZoomWindow = higlightWindow;
            num1 = (int) num3 * 782003770 ^ 873730412;
            continue;
          case 1:
            this.Drawn = false;
            num1 = (int) num3 * 1731709346 ^ -1076888368;
            continue;
          case 2:
            this.Color = Color.Yellow;
            num1 = (int) num3 * 385379706 ^ 880576901;
            continue;
          case 3:
            num1 = (int) num3 * -592541421 ^ 140933936;
            continue;
          case 4:
            this.ZoomWindowType = higlightWindow.ZoomWindowType;
            num1 = (int) num3 * 468079632 ^ 2036010866;
            continue;
          case 5:
            goto label_3;
          case 6:
            this.Handle = higlightWindow.Handle;
            num1 = (int) num3 * -247209371 ^ 1022573298;
            continue;
          case 7:
            this.Created = DateTime.Now;
            num1 = (int) num3 * 1924014290 ^ 792967257;
            continue;
          case 8:
            num1 = (int) num3 * 1505108246 ^ -190389950;
            continue;
          case 9:
            this.Expires = DateTime.Now.AddSeconds(2.0);
            num1 = (int) num3 * -1033959190 ^ 508593153;
            continue;
          case 10:
            this.Rectangle = higlightWindow.Rectangle;
            num1 = (int) num3 * 1743525656 ^ 400833985;
            continue;
          case 11:
            num1 = (int) num3 * 1754880822 ^ -1678249582;
            continue;
          case 12:
            goto label_1;
          case 13:
            num1 = (int) num3 * -2013823097 ^ -1385283884;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return;
label_3:;
    }

    public HighlightInfo(Rectangle region, int durationInSeconds)
    {
label_1:
      int num1 = 1226909568;
      while (true)
      {
        int num2 = 79570877;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 12U)
        {
          case 0:
            num1 = (int) num3 * -1506960185 ^ 1020421443;
            continue;
          case 1:
            this.ZoomWindowType = ZoomWindowType.Undefined;
            num1 = (int) num3 * 70794601 ^ 1911447028;
            continue;
          case 2:
            num1 = (int) num3 * 177414404 ^ -1097681292;
            continue;
          case 3:
            num1 = (int) num3 * 1100973490 ^ -1734942886;
            continue;
          case 4:
            this.Rectangle = region;
            num1 = (int) num3 * -1319747577 ^ 60045777;
            continue;
          case 5:
            this.Expires = DateTime.Now.AddSeconds((double) durationInSeconds);
            num1 = (int) num3 * 2139496367 ^ -1619277971;
            continue;
          case 6:
            goto label_3;
          case 7:
            this.Drawn = false;
            num1 = (int) num3 * -1885491286 ^ -401843547;
            continue;
          case 8:
            this.Created = DateTime.Now;
            num1 = (int) num3 * 800467226 ^ 1138418218;
            continue;
          case 9:
            num1 = (int) num3 * -1351182535 ^ -322210012;
            continue;
          case 10:
            this.Handle = IntPtr.Zero;
            this.ZoomWindow = (ZoomWindow) null;
            num1 = (int) num3 * 2066642059 ^ -1456071483;
            continue;
          case 11:
            goto label_1;
          default:
            goto label_14;
        }
      }
label_14:
      return;
label_3:;
    }

    internal void Reset()
    {
      this.Expires = DateTime.Now.AddSeconds(2.0);
label_1:
      int num1 = -1723771357;
      while (true)
      {
        int num2 = -2130916427;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            this.Drawn = false;
            num1 = (int) num3 * 112435860 ^ -1763098988;
            continue;
          case 1:
            num1 = (int) num3 * 1970884325 ^ 305277884;
            continue;
          case 2:
            num1 = (int) num3 * 632579822 ^ -27396626;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }

    public override string ToString()
    {
label_1:
      int num1 = -800296818;
      string str;
      while (true)
      {
        int num2 = -1840364138;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            str = string.Format(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(552225273U), (object) this.ZoomWindowType, (object) this.Expires.ToShortTimeString());
            num1 = (int) num3 * 1916667663 ^ -1859486111;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return str;
    }

    public override bool Equals(object obj)
    {
label_1:
      int num1 = -530771851;
      bool flag1;
      while (true)
      {
        int num2 = -848017900;
        uint num3;
        bool flag2;
        HighlightInfo highlightInfo;
        switch ((num3 = (uint) (num1 ^ num2)) % 9U)
        {
          case 0:
            flag2 = highlightInfo != null;
            num1 = (int) num3 * 783259083 ^ 413549144;
            continue;
          case 1:
            flag1 = base.Equals(obj);
            num1 = -1421726710;
            continue;
          case 2:
            flag1 = highlightInfo.Handle.Equals((object) this.Handle);
            num1 = (int) num3 * 395837408 ^ -230401387;
            continue;
          case 3:
            int num4 = !flag2 ? 1536147026 : (num4 = 1266857109);
            int num5 = (int) num3 * 1974381786;
            num1 = num4 ^ num5;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * 1737186879 ^ -820812487;
            continue;
          case 7:
            num1 = (int) num3 * -541744597 ^ 2142226527;
            continue;
          case 8:
            highlightInfo = obj as HighlightInfo;
            num1 = (int) num3 * -1840367349 ^ 1934317979;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag1;
    }

    public override int GetHashCode()
    {
      IntPtr handle = this.Handle;
label_1:
      int num1 = -1004604126;
      int hashCode;
      while (true)
      {
        int num2 = -329800852;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            hashCode = handle.GetHashCode();
            num1 = (int) num3 * 1137482427 ^ 33628371;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return hashCode;
    }

    internal void UpdateRectangles(IntPtr handle)
    {
      WindowHelper.GetWindowRectangle(this.Handle);
    }
  }
}
