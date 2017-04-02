// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ViewModels.AlertValues
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Windows.Media;

namespace ZoomZoom.ViewModels
{
  internal class AlertValues
  {
    private Color alertColor = AlertValues.\u206D‭‭⁫‍‏⁫‍‎‌⁭⁮‮⁬‬‪‬⁫‍‏‫⁪⁮⁪‮‭⁭⁭‍‪⁬⁬⁪⁬⁪‬‎​‍⁬‮();
    private string header;
    private string body;

    public string Header
    {
      get
      {
label_1:
        int num1 = 1218601004;
        string header;
        while (true)
        {
          int num2 = 118073910;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              header = this.header;
              num1 = (int) num3 * 2024650475 ^ 152369096;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return header;
      }
      set
      {
label_1:
        int num1 = 1411419721;
        while (true)
        {
          int num2 = 457054007;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.header = value;
              num1 = (int) num3 * 1927676845 ^ -2121248431;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public string Body
    {
      get
      {
label_1:
        int num1 = -599254116;
        string body;
        while (true)
        {
          int num2 = -667921089;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -417308540 ^ -571928247;
              continue;
            case 3:
              body = this.body;
              num1 = (int) num3 * 535616680 ^ 596386910;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return body;
      }
      set
      {
        this.body = value;
      }
    }

    public Color AlertColor
    {
      get
      {
        return this.alertColor;
      }
      set
      {
label_1:
        int num1 = -1292533847;
        while (true)
        {
          int num2 = -1035899218;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.alertColor = value;
              num1 = (int) num3 * -2021524587 ^ -1224110677;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public AlertValues(string header, string body, Color? alertColor = null)
    {
label_1:
      int num1 = 747723399;
      while (true)
      {
        int num2 = 1955926287;
        uint num3;
        bool hasValue;
        switch ((num3 = (uint) (num1 ^ num2)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Body = body;
            num1 = (int) num3 * 788081183 ^ 840407049;
            continue;
          case 2:
            this.Header = header;
            num1 = (int) num3 * -519813823 ^ 46943006;
            continue;
          case 3:
            num1 = (int) num3 * -800547689 ^ 1318974051;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.AlertColor = alertColor.Value;
            num1 = (int) num3 * -193440695 ^ 842164566;
            continue;
          case 6:
            num1 = (int) num3 * -1013646400 ^ 1149058619;
            continue;
          case 7:
            num1 = (int) num3 * -925554925 ^ 463965062;
            continue;
          case 8:
            hasValue = alertColor.HasValue;
            num1 = (int) num3 * -430281543 ^ 1201782757;
            continue;
          case 9:
            num1 = (int) num3 * -1277468901 ^ -204896642;
            continue;
          case 10:
            int num4 = hasValue ? 2133963774 : (num4 = 797218530);
            int num5 = (int) num3 * -1117632136;
            num1 = num4 ^ num5;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return;
label_3:;
    }

    static Color \u206D‭‭⁫‍‏⁫‍‎‌⁭⁮‮⁬‬‪‬⁫‍‏‫⁪⁮⁪‮‭⁭⁭‍‪⁬⁬⁪⁬⁪‬‎​‍⁬‮()
    {
      return Colors.Blue;
    }
  }
}
