// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Windows.WindowMovementPayload
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom.Models.Windows
{
  public class WindowMovementPayload
  {
    private bool changed = false;
    private int x;
    private int y;
    private ZoomWindowType windowType;
    private ZoomWindowType relatedWindow;

    public bool Changed
    {
      get
      {
        bool changed = this.changed;
label_1:
        int num1 = 676709152;
        while (true)
        {
          int num2 = 306360253;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 780880398 ^ 298595925;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return changed;
      }
    }

    public int X
    {
      get
      {
label_1:
        int num1 = 712098407;
        int x;
        while (true)
        {
          int num2 = 899710742;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              x = this.x;
              num1 = (int) num3 * -1023158520 ^ 1824392080;
              continue;
            case 2:
              num1 = (int) num3 * -1163534766 ^ 1297283302;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return x;
      }
      set
      {
        this.x = value;
        this.changed = true;
      }
    }

    public int Y
    {
      get
      {
label_1:
        int num1 = -161050171;
        int y;
        while (true)
        {
          int num2 = -1692556578;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 809572963 ^ 165540617;
              continue;
            case 3:
              y = this.y;
              num1 = (int) num3 * -188569372 ^ 2009406708;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return y;
      }
      set
      {
label_1:
        int num1 = -2062301738;
        while (true)
        {
          int num2 = -184478730;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.y = value;
              this.changed = true;
              num1 = (int) num3 * -1073827655 ^ -2143220060;
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

    public ZoomWindowType WindowType
    {
      get
      {
label_1:
        int num1 = 287634260;
        ZoomWindowType windowType;
        while (true)
        {
          int num2 = 19670681;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              windowType = this.windowType;
              num1 = (int) num3 * -931071925 ^ 2071024405;
              continue;
            case 3:
              num1 = (int) num3 * -1968632570 ^ -1812595663;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return windowType;
      }
      set
      {
label_1:
        int num1 = -1923894274;
        while (true)
        {
          int num2 = -808741059;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.windowType = value;
              num1 = (int) num3 * -1085260046 ^ 2092509130;
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

    public ZoomWindowType RelatedWindow
    {
      get
      {
label_1:
        int num1 = 670150396;
        ZoomWindowType relatedWindow;
        while (true)
        {
          int num2 = 1007173109;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -364835902 ^ -1604985977;
              continue;
            case 1:
              relatedWindow = this.relatedWindow;
              num1 = (int) num3 * -1351845564 ^ -691603499;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return relatedWindow;
      }
      set
      {
label_1:
        int num1 = 488088121;
        while (true)
        {
          int num2 = 779496484;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.relatedWindow = value;
              num1 = (int) num3 * -139591439 ^ -1591227070;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.changed = true;
              num1 = (int) num3 * 883434066 ^ 1901881374;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }
  }
}
