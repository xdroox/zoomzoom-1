// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomButton
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using ZoomZoom.Models.Data;

namespace ZoomZoom
{
  public class ZoomButton : DataObject
  {
    private static readonly object buttonLock = ZoomButton.\u200F‬‍‭‍⁮⁪‬‫⁮‭⁪⁯‎⁮⁪​⁭⁪⁫‎⁫⁮⁯‏‪‭⁭‍⁬⁪‍‮‬⁪‭‪⁯⁬⁭‮();
    private int buttonX = 0;
    private int buttonY = 0;
    private bool requiresRightClick = false;
    private string meetingId = string.Empty;
    private ZoomWindowType zoomWindowType = ZoomWindowType.Undefined;
    private int windowHeight = 0;
    private int windowWidth = 0;
    private ZoomWindowType resultingWindowType = ZoomWindowType.Undefined;
    private DateTime dateModified = DateTime.MinValue;
    private DateTime dateCreated = DateTime.MinValue;
    private ClickState clickState = ClickState.Unknown;

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = -320895539;
        TraceType traceType;
        while (true)
        {
          int num2 = -1937886255;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              traceType = TraceType.Window;
              num1 = (int) num3 * 10775506 ^ 374252241;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public int ButtonX
    {
      get
      {
        return this.buttonX;
      }
      set
      {
label_1:
        int num1 = -511485988;
        object buttonLock;
        while (true)
        {
          int num2 = -388131380;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              buttonLock = ZoomButton.buttonLock;
              num1 = (int) num3 * 1139940224 ^ -904323471;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_6:
          int num2 = -1766681786;
          while (true)
          {
            int num3 = -388131380;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 0:
                goto label_6;
              case 2:
                num2 = (int) num4 * -112482165 ^ 1504670409;
                continue;
              case 3:
                num2 = (int) num4 * 545173106 ^ -1108858805;
                continue;
              default:
                goto label_10;
            }
          }
label_10:
          this.buttonX = value;
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = -286810853;
            while (true)
            {
              int num3 = -388131380;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_12;
                case 2:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num2 = (int) num4 * 2047915680 ^ -1742867155;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3981050831U));
label_18:
        int num5 = -1751482095;
        while (true)
        {
          int num2 = -388131380;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 3U)
          {
            case 0:
              goto label_18;
            case 1:
              num5 = (int) num3 * 1783746671 ^ -1220107407;
              continue;
            case 2:
              goto label_20;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_20:;
      }
    }

    public int ButtonY
    {
      get
      {
label_1:
        int num1 = -168416401;
        int buttonY;
        while (true)
        {
          int num2 = -57811562;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -711370989 ^ -1969840;
              continue;
            case 1:
              buttonY = this.buttonY;
              num1 = (int) num3 * 210497456 ^ -1299098006;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return buttonY;
      }
      set
      {
        object buttonLock = ZoomButton.buttonLock;
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_2:
          int num1 = 369798751;
          while (true)
          {
            int num2 = 1547488112;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 6U)
            {
              case 0:
                num1 = (int) num3 * 1464755086 ^ 99346955;
                continue;
              case 1:
                this.buttonY = value;
                num1 = (int) num3 * 517803613 ^ 807698484;
                continue;
              case 3:
                num1 = (int) num3 * 1999550984 ^ -910652842;
                continue;
              case 4:
                goto label_2;
              case 5:
                num1 = (int) num3 * 1706706154 ^ 1175109428;
                continue;
              default:
                goto label_14;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_9:
            int num1 = 607950745;
            while (true)
            {
              int num2 = 1547488112;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 1:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num1 = (int) num3 * -88456831 ^ -1960406679;
                  continue;
                case 2:
                  goto label_9;
                default:
                  goto label_13;
              }
            }
          }
label_13:;
        }
label_14:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(529607301U));
label_15:
        int num4 = 481057241;
        while (true)
        {
          int num1 = 1547488112;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 3U)
          {
            case 0:
              goto label_17;
            case 1:
              num4 = (int) num2 * 901719316 ^ 2062853183;
              continue;
            case 2:
              goto label_15;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_17:;
      }
    }

    public bool RequiresRightClick
    {
      get
      {
        bool requiresRightClick = this.requiresRightClick;
label_1:
        int num1 = 958126143;
        while (true)
        {
          int num2 = 1836738516;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -1025081488 ^ -1003950636;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return requiresRightClick;
      }
      set
      {
        object buttonLock = ZoomButton.buttonLock;
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_2:
          int num1 = -1200183913;
          while (true)
          {
            int num2 = -1153479684;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                this.requiresRightClick = value;
                num1 = (int) num3 * -2002912672 ^ -111691278;
                continue;
              default:
                goto label_12;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_6:
            int num1 = -1935083434;
            while (true)
            {
              int num2 = -1153479684;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 1:
                  num1 = (int) num3 * -1791245978 ^ 976884306;
                  continue;
                case 2:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num1 = (int) num3 * 2050744545 ^ -2015712181;
                  continue;
                case 3:
                  goto label_6;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
label_12:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3925052772U));
label_13:
        int num4 = -1757737375;
        while (true)
        {
          int num1 = -1153479684;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 3U)
          {
            case 0:
              goto label_15;
            case 1:
              num4 = (int) num2 * -1549815778 ^ -387274212;
              continue;
            case 2:
              goto label_13;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_15:;
      }
    }

    public string MeetingId
    {
      get
      {
label_1:
        int num1 = 2033338392;
        string meetingId;
        while (true)
        {
          int num2 = 2086861267;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 2084904981 ^ -1348837288;
              continue;
            case 3:
              meetingId = this.meetingId;
              num1 = (int) num3 * 428937153 ^ 1224485905;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingId;
      }
      set
      {
label_1:
        int num1 = -1388691546;
        object buttonLock;
        while (true)
        {
          int num2 = -1112395262;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              buttonLock = ZoomButton.buttonLock;
              num1 = (int) num3 * 1364062892 ^ 1531203250;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_6:
          int num2 = -1091520188;
          while (true)
          {
            int num3 = -1112395262;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 4U)
            {
              case 1:
                this.meetingId = value;
                num2 = (int) num4 * 779060804 ^ 991799470;
                continue;
              case 2:
                num2 = (int) num4 * -690401722 ^ 344469471;
                continue;
              case 3:
                goto label_6;
              default:
                goto label_15;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_11:
            int num2 = -300073400;
            while (true)
            {
              int num3 = -1112395262;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_11;
                case 2:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num2 = (int) num4 * -1786558570 ^ 423368033;
                  continue;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
label_15:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1246343050U));
      }
    }

    public ZoomWindowType ZoomWindowType
    {
      get
      {
        ZoomWindowType zoomWindowType = this.zoomWindowType;
label_1:
        int num1 = 978796243;
        while (true)
        {
          int num2 = 379433110;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -66658247 ^ 214642072;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return zoomWindowType;
      }
      set
      {
        object buttonLock = ZoomButton.buttonLock;
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
          this.zoomWindowType = value;
        }
        finally
        {
          if (flag)
          {
label_3:
            int num1 = 609878338;
            while (true)
            {
              int num2 = 1601734600;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_3;
                case 2:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num1 = (int) num3 * 1472204291 ^ 2126297085;
                  continue;
                case 3:
                  num1 = (int) num3 * 1868166777 ^ 151664838;
                  continue;
                default:
                  goto label_7;
              }
            }
          }
label_7:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1684167442U));
      }
    }

    public int WindowHeight
    {
      get
      {
        int windowHeight = this.windowHeight;
label_1:
        int num1 = -1028226504;
        while (true)
        {
          int num2 = -1411476335;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -902740450 ^ 1623628416;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return windowHeight;
      }
      set
      {
        object buttonLock = ZoomButton.buttonLock;
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_2:
          int num1 = 714460562;
          while (true)
          {
            int num2 = 1527969018;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 1:
                this.windowHeight = value;
                num1 = (int) num3 * -1185580430 ^ 399384335;
                continue;
              case 2:
                goto label_2;
              default:
                goto label_11;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_6:
            int num1 = 1262793152;
            while (true)
            {
              int num2 = 1527969018;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_6;
                case 1:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num1 = (int) num3 * -1842496662 ^ 417871843;
                  continue;
                default:
                  goto label_10;
              }
            }
          }
label_10:;
        }
label_11:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(348658611U));
label_12:
        int num4 = 78833470;
        while (true)
        {
          int num1 = 1527969018;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 3U)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_14;
            case 2:
              num4 = (int) num2 * 1413292145 ^ 45770826;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return;
label_14:;
      }
    }

    public int WindowWidth
    {
      get
      {
        return this.windowWidth;
      }
      set
      {
        object buttonLock = ZoomButton.buttonLock;
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_2:
          int num1 = -1854142438;
          while (true)
          {
            int num2 = -896783807;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_2;
              case 2:
                num1 = (int) num3 * 606325643 ^ -386007322;
                continue;
              case 3:
                num1 = (int) num3 * -37916586 ^ -1484563699;
                continue;
              default:
                goto label_6;
            }
          }
label_6:
          this.windowWidth = value;
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = -1217591929;
            while (true)
            {
              int num2 = -896783807;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_8;
                case 1:
                  num1 = (int) num3 * 1340879755 ^ -1960382563;
                  continue;
                case 2:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num1 = (int) num3 * -1620161212 ^ 1900584712;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(637868973U));
      }
    }

    public ZoomWindowType ResultingWindowType
    {
      get
      {
label_1:
        int num1 = 794789484;
        ZoomWindowType resultingWindowType;
        while (true)
        {
          int num2 = 1251537225;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 166532502 ^ -291686246;
              continue;
            case 1:
              resultingWindowType = this.resultingWindowType;
              num1 = (int) num3 * -1286471434 ^ -1796385529;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return resultingWindowType;
      }
      set
      {
label_1:
        int num1 = -199925980;
        object buttonLock;
        while (true)
        {
          int num2 = -905424437;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              buttonLock = ZoomButton.buttonLock;
              num1 = (int) num3 * 263576946 ^ -884879757;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_6:
          int num2 = -165725330;
          while (true)
          {
            int num3 = -905424437;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                goto label_6;
              case 2:
                num2 = (int) num4 * -541469512 ^ 2028673764;
                continue;
              case 3:
                this.resultingWindowType = value;
                num2 = (int) num4 * 1513737012 ^ 1435373438;
                continue;
              case 4:
                num2 = (int) num4 * 1134217919 ^ 1233199380;
                continue;
              default:
                goto label_17;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = -968305667;
            while (true)
            {
              int num3 = -905424437;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_12;
                case 1:
                  num2 = (int) num4 * 1561263607 ^ 465419375;
                  continue;
                case 2:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num2 = (int) num4 * 682547037 ^ 1729656612;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
label_17:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3225287297U));
      }
    }

    public DateTime DateModified
    {
      get
      {
label_1:
        int num1 = -2116564735;
        DateTime dateModified;
        while (true)
        {
          int num2 = -728668803;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              dateModified = this.dateModified;
              num1 = (int) num3 * -1444045541 ^ 586151307;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dateModified;
      }
      set
      {
label_1:
        int num1 = 1242618928;
        object buttonLock;
        while (true)
        {
          int num2 = 989306737;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              buttonLock = ZoomButton.buttonLock;
              num1 = (int) num3 * 323814754 ^ -2087355447;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_6:
          int num2 = 99229016;
          while (true)
          {
            int num3 = 989306737;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 3U)
            {
              case 0:
                goto label_6;
              case 2:
                num2 = (int) num4 * -1338579147 ^ 47765777;
                continue;
              default:
                goto label_9;
            }
          }
label_9:
          this.dateModified = value;
        }
        finally
        {
          if (flag)
          {
label_11:
            int num2 = 588008747;
            while (true)
            {
              int num3 = 989306737;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_11;
                case 2:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num2 = (int) num4 * -2039108341 ^ -1304772028;
                  continue;
                case 3:
                  num2 = (int) num4 * 1783365787 ^ 2138164369;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3096187508U));
      }
    }

    public DateTime DateCreated
    {
      get
      {
        return this.dateCreated;
      }
      set
      {
        object buttonLock = ZoomButton.buttonLock;
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_2:
          int num1 = 155434717;
          while (true)
          {
            int num2 = 119960264;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                num1 = (int) num3 * 1436148002 ^ 1132513135;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          this.dateCreated = value;
        }
        finally
        {
          if (flag)
          {
label_7:
            int num1 = 664705855;
            while (true)
            {
              int num2 = 119960264;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  num1 = (int) num3 * 1478749252 ^ 79093213;
                  continue;
                case 2:
                  goto label_7;
                case 3:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num1 = (int) num3 * 1679857204 ^ -1695174980;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(327274448U));
label_14:
        int num4 = 221675524;
        while (true)
        {
          int num1 = 119960264;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 3U)
          {
            case 0:
              goto label_16;
            case 1:
              num4 = (int) num2 * 61149314 ^ 2140507963;
              continue;
            case 2:
              goto label_14;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_16:;
      }
    }

    public System.Drawing.Point ButtonLocation
    {
      get
      {
label_1:
        int num1 = 1050965814;
        System.Drawing.Point point;
        while (true)
        {
          int num2 = 2066808673;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1505243463 ^ 1681610680;
              continue;
            case 3:
              point = new System.Drawing.Point(this.ButtonX, this.ButtonY);
              num1 = (int) num3 * 90187312 ^ -2023040004;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return point;
      }
      set
      {
label_1:
        int num1 = -396747031;
        object buttonLock;
        while (true)
        {
          int num2 = -1403626348;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              buttonLock = ZoomButton.buttonLock;
              num1 = (int) num3 * -1065926050 ^ 1903850614;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
          this.ButtonX = value.X;
label_6:
          int num2 = -1694863853;
          while (true)
          {
            int num3 = -1403626348;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                goto label_6;
              case 1:
                this.ButtonY = value.Y;
                num2 = (int) num4 * -1657159907 ^ 625145530;
                continue;
              case 2:
                num2 = (int) num4 * 2081624551 ^ 2117813437;
                continue;
              case 3:
                num2 = (int) num4 * 415685514 ^ -1848776;
                continue;
              default:
                goto label_17;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = -125508047;
            while (true)
            {
              int num3 = -1403626348;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_12;
                case 1:
                  Monitor.Exit(buttonLock);
                  num2 = (int) num4 * -914982894 ^ -659714703;
                  continue;
                case 3:
                  num2 = (int) num4 * 207822844 ^ 38968030;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
label_17:
        this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3232226125U));
      }
    }

    public Size WindowSize
    {
      get
      {
label_1:
        int num1 = 1490004253;
        Size size;
        while (true)
        {
          int num2 = 2094808972;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -898460253 ^ -160234553;
              continue;
            case 1:
              size = new Size(this.WindowWidth, this.WindowHeight);
              num1 = (int) num3 * -907025941 ^ -1870087685;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return size;
      }
      set
      {
        object buttonLock = ZoomButton.buttonLock;
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_2:
          int num1 = 1106668660;
          while (true)
          {
            int num2 = 57082357;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                num1 = (int) num3 * -883305232 ^ -296391993;
                continue;
              case 1:
                this.WindowWidth = value.Width;
                this.WindowHeight = value.Height;
                num1 = (int) num3 * -2095796260 ^ 1127381377;
                continue;
              case 3:
                goto label_2;
              case 4:
                num1 = (int) num3 * 64056912 ^ 309372488;
                continue;
              default:
                goto label_12;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_8:
            int num1 = 1446723162;
            while (true)
            {
              int num2 = 57082357;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_8;
                case 1:
                  Monitor.Exit(buttonLock);
                  num1 = (int) num3 * 1743099068 ^ 2074976018;
                  continue;
                default:
                  goto label_11;
              }
            }
          }
label_11:;
        }
label_12:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(93573494U));
      }
    }

    public ClickState ClickState
    {
      get
      {
label_1:
        int num1 = 1063419521;
        ClickState clickState;
        while (true)
        {
          int num2 = 829233748;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1345305030 ^ 1584842710;
              continue;
            case 1:
              clickState = this.clickState;
              num1 = (int) num3 * 747361996 ^ 127398608;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return clickState;
      }
      set
      {
label_1:
        int num1 = 1434302666;
        object buttonLock;
        while (true)
        {
          int num2 = 1541080596;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              buttonLock = ZoomButton.buttonLock;
              num1 = (int) num3 * -2070525809 ^ 763400731;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        bool flag = false;
        try
        {
          ZoomButton.\u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮(buttonLock, ref flag);
label_6:
          int num2 = 1612942164;
          while (true)
          {
            int num3 = 1541080596;
            uint num4;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                goto label_6;
              case 1:
                num2 = (int) num4 * -1800375856 ^ -933938167;
                continue;
              case 2:
                num2 = (int) num4 * -617385726 ^ 1602269208;
                continue;
              case 4:
                this.clickState = value;
                num2 = (int) num4 * 1171492493 ^ 1032808759;
                continue;
              default:
                goto label_18;
            }
          }
        }
        finally
        {
          if (flag)
          {
label_12:
            int num2 = 1998901013;
            while (true)
            {
              int num3 = 1541080596;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_12;
                case 1:
                  ZoomButton.\u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮(buttonLock);
                  num2 = (int) num4 * 1846405337 ^ -835678313;
                  continue;
                case 2:
                  num2 = (int) num4 * 579464640 ^ 1138215539;
                  continue;
                default:
                  goto label_17;
              }
            }
          }
label_17:;
        }
label_18:
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2691060034U));
label_19:
        int num5 = 1196267646;
        while (true)
        {
          int num2 = 1541080596;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 3U)
          {
            case 0:
              goto label_19;
            case 1:
              num5 = (int) num3 * 1504945975 ^ 97031584;
              continue;
            case 2:
              goto label_21;
            default:
              goto label_14;
          }
        }
label_14:
        return;
label_21:;
      }
    }

    public override ObjectDataTable ZoomZoomTable
    {
      get
      {
        ObjectDataTable objectDataTable = ObjectDataTable.Buttons;
label_1:
        int num1 = -1032232480;
        while (true)
        {
          int num2 = -1823917039;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -45840862 ^ -1236845689;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return objectDataTable;
      }
    }

    public override bool Equals(object obj)
    {
      ZoomButton zoomButton = obj as ZoomButton;
      bool flag1 = zoomButton != null;
label_1:
      int num1 = -81858747;
      bool flag2;
      while (true)
      {
        int num2 = -2085574915;
        uint num3;
        int num4;
        bool flag3;
        Size windowSize;
        ZoomWindowType zoomWindowType;
        int num5;
        int num6;
        int num7;
        switch ((num3 = (uint) (num1 ^ num2)) % 28U)
        {
          case 0:
            if (num4.Equals(this.ButtonX))
            {
              num1 = (int) num3 * -1362017133 ^ -1235414666;
              continue;
            }
            goto label_32;
          case 1:
            num1 = (int) num3 * 482454609 ^ -1892110730;
            continue;
          case 2:
            zoomWindowType = zoomButton.ZoomWindowType;
            num1 = (int) num3 * -284519853 ^ -611646795;
            continue;
          case 3:
            if (zoomButton.Uri != 0L)
            {
              num6 = 0;
              goto label_22;
            }
            else
            {
              num1 = -1781970612;
              continue;
            }
          case 4:
            num4 = zoomButton.ButtonX;
            num1 = (int) num3 * 620624636 ^ 1290114781;
            continue;
          case 5:
            zoomWindowType = zoomButton.ResultingWindowType;
            if (zoomWindowType.Equals((object) this.ResultingWindowType))
            {
              num1 = (int) num3 * -803987898 ^ -39176126;
              continue;
            }
            goto label_32;
          case 6:
            num1 = (int) num3 * 1918225033 ^ -1944700753;
            continue;
          case 7:
            num1 = (int) num3 * 1882616411 ^ 1104838131;
            continue;
          case 8:
            flag2 = true;
            num1 = (int) num3 * -1469380778 ^ -306577055;
            continue;
          case 9:
            if (zoomButton.MeetingId.Equals(this.MeetingId))
            {
              num1 = (int) num3 * 1138459478 ^ 2105148757;
              continue;
            }
            goto label_32;
          case 10:
            flag2 = true;
            num1 = (int) num3 * -1965251326 ^ 1017593503;
            continue;
          case 11:
            if (num4.Equals(this.ButtonY))
            {
              num1 = (int) num3 * -1609262914 ^ -893343258;
              continue;
            }
            goto label_32;
          case 12:
            goto label_1;
          case 13:
            num1 = -1178955012;
            continue;
          case 14:
            if (windowSize.Equals((object) this.WindowSize))
            {
              num1 = (int) num3 * -759359995 ^ 1918397593;
              continue;
            }
            goto label_32;
          case 15:
            num4 = zoomButton.ButtonY;
            num1 = (int) num3 * 1827256962 ^ -115391268;
            continue;
          case 17:
            num1 = (int) num3 * 2041396424 ^ -1725290267;
            continue;
          case 18:
            windowSize = zoomButton.WindowSize;
            num1 = (int) num3 * 783058099 ^ 110644777;
            continue;
          case 19:
            int num8 = !flag3 ? -1790088601 : (num8 = -720525195);
            int num9 = (int) num3 * -281628491;
            num1 = num8 ^ num9;
            continue;
          case 20:
            int num10 = flag1 ? -1511455670 : (num10 = -513634807);
            int num11 = (int) num3 * -899980863;
            num1 = num10 ^ num11;
            continue;
          case 21:
            num1 = -1998666319;
            continue;
          case 22:
            num7 = this.Uri > 0L ? 1 : 0;
            break;
          case 23:
            if (zoomButton.Uri != this.Uri)
            {
              num7 = 0;
              break;
            }
            num1 = (int) num3 * -1514679546 ^ -51019791;
            continue;
          case 24:
            flag2 = false;
            num1 = -775277631;
            continue;
          case 25:
            num6 = this.Uri == 0L ? 1 : 0;
            goto label_22;
          case 26:
            num5 = zoomWindowType.Equals((object) this.ZoomWindowType) ? 1 : 0;
            goto label_33;
          case 27:
            num1 = (int) num3 * 791429205 ^ -1298278366;
            continue;
          default:
            goto label_42;
        }
        int num12;
        num1 = num12 = num7 == 0 ? -964458082 : (num12 = -1384914888);
        continue;
label_22:
        flag3 = num6 != 0;
        num1 = -399687438;
        continue;
label_32:
        num5 = 0;
label_33:
        int num13;
        num1 = num13 = num5 == 0 ? -1256060416 : (num13 = -1608108024);
      }
label_42:
      return flag2;
    }

    public override int GetHashCode()
    {
label_1:
      int num1 = 1776899767;
      int num2;
      while (true)
      {
        int num3 = 1790883078;
        uint num4;
        switch ((num4 = (uint) (num1 ^ num3)) % 4U)
        {
          case 1:
            num2 = this.\u206D​⁬‎​‪​‬‪‏‌‪⁭‫⁭‎‪⁮‍‮‪⁭⁬⁮⁯‌⁪‬⁫‭‌‍‪​​‏⁪‫‎‎‮();
            num1 = (int) num4 * -1031562467 ^ 1953899084;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num4 * 2125513302 ^ -1682978260;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return num2;
    }

    public override string ToString()
    {
label_1:
      int num1 = 51459263;
      string str;
      while (true)
      {
        int num2 = 758940706;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            str = ZoomButton.\u206B⁫​‫‭‮‬‬⁪‍​⁪‎‮‫⁫⁬⁬‫‪‎⁯​‎⁫‏‏‏⁫⁪​‎‭‌‪‬⁯⁭‍‌‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(708788007U), new object[4]
            {
              (object) this.ZoomWindowType,
              (object) this.ButtonX,
              (object) this.ButtonY,
              (object) this.ResultingWindowType
            });
            num1 = (int) num3 * 292216944 ^ -1298649575;
            continue;
          case 3:
            num1 = (int) num3 * 1148287949 ^ -384104633;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    internal bool Save()
    {
      bool flag1 = false;
      try
      {
        this.Engine.AddButton(this);
        flag1 = this.SaveDatabaseObject();
      }
      catch (Exception ex)
      {
label_3:
        int num1 = 771075802;
        while (true)
        {
          int num2 = 1887527317;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              num1 = (int) num3 * 1936939995 ^ -382332960;
              continue;
            case 3:
              ZoomButton.\u206F⁪⁬‎‏‪‏‭‬⁮‬‏‌‪‌⁫‮⁮‫‍⁯⁮‍‎‍⁭⁯‫‭‫⁯‪⁬‮‌⁫⁮⁬⁬‫‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 2116811775 ^ 404527881;
              continue;
            default:
              goto label_7;
          }
        }
      }
label_7:
      bool flag2 = flag1;
label_8:
      int num4 = 1626097958;
      while (true)
      {
        int num1 = 1887527317;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_8;
          case 2:
            num4 = (int) num2 * -428757505 ^ -2083660991;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return flag2;
    }

    internal bool Delete()
    {
      bool flag1 = false;
      try
      {
        this.Engine.RemoveButton(this);
label_2:
        int num1 = -1297739269;
        while (true)
        {
          int num2 = -488765423;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * 1987854831 ^ 632648835;
              continue;
            case 2:
              num1 = -977796906;
              continue;
            case 3:
              num1 = (int) num3 * 56847356 ^ -2124606825;
              continue;
            case 4:
              int num4 = this.Uri <= 0L ? 1194579412 : (num4 = 2034626897);
              int num5 = (int) num3 * -390135456;
              num1 = num4 ^ num5;
              continue;
            case 6:
              flag1 = this.DeleteDatabaseObject();
              num1 = (int) num3 * 145800291 ^ -1523918622;
              continue;
            default:
              goto label_14;
          }
        }
      }
      catch (Exception ex)
      {
label_10:
        int num1 = -72132832;
        while (true)
        {
          int num2 = -488765423;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              ZoomButton.\u206F⁪⁬‎‏‪‏‭‬⁮‬‏‌‪‌⁫‮⁮‫‍⁯⁮‍‎‍⁭⁯‫‭‫⁯‪⁬‮‌⁫⁮⁬⁬‫‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1942378708 ^ 184020502;
              continue;
            case 2:
              goto label_10;
            case 3:
              num1 = (int) num3 * 258079617 ^ 98689518;
              continue;
            default:
              goto label_14;
          }
        }
      }
label_14:
      bool flag2 = flag1;
label_15:
      int num6 = -467088162;
      while (true)
      {
        int num1 = -488765423;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 0:
            goto label_15;
          case 1:
            num6 = (int) num2 * -245817075 ^ -826266798;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return flag2;
    }

    public override Dictionary<string, object> GetDataDictionary()
    {
label_1:
      int num1 = 519693726;
      Dictionary<string, object> dictionary1;
      while (true)
      {
        int num2 = 804536725;
        uint num3;
        Dictionary<string, object> dictionary2;
        switch ((num3 = (uint) (num1 ^ num2)) % 16U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 14008471 ^ -1323050598;
            continue;
          case 2:
            dictionary1 = dictionary2;
            num1 = (int) num3 * 2089889971 ^ 1712307319;
            continue;
          case 3:
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(193400849U), (object) this.ButtonX);
            num1 = (int) num3 * 1450745418 ^ 1554011089;
            continue;
          case 5:
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2263636494U), (object) this.ButtonY);
            num1 = (int) num3 * 410447091 ^ 1272555287;
            continue;
          case 6:
            dictionary2.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1383235083U), (object) this.RequiresRightClick);
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3174833053U), (object) this.MeetingId);
            num1 = (int) num3 * 218697757 ^ -627625307;
            continue;
          case 7:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3645992511U), (object) this.ResultingWindowType);
            num1 = (int) num3 * -548250900 ^ -1557518323;
            continue;
          case 8:
            dictionary2.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3435639904U), (object) this.WindowWidth);
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3171592636U), (object) this.WindowHeight);
            num1 = (int) num3 * -1948482527 ^ 1529867458;
            continue;
          case 9:
            dictionary2.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3071765281U), (object) this.ZoomWindowType);
            num1 = (int) num3 * 142646250 ^ -1195003650;
            continue;
          case 10:
            num1 = (int) num3 * -1797001503 ^ 1320471930;
            continue;
          case 11:
            dictionary2 = new Dictionary<string, object>();
            dictionary2.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U), (object) this.Uri);
            num1 = (int) num3 * -225891812 ^ -1676701422;
            continue;
          case 12:
            Dictionary<string, object> dictionary3 = dictionary2;
            string key1 = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2110344247U);
            DateTime dateTime = this.DateModified;
            // ISSUE: variable of a boxed type
            __Boxed<DateTime> local1 = (ValueType) (dateTime.Equals(DateTime.MinValue) ? DateTime.Now : this.DateModified);
            dictionary3.Add(key1, (object) local1);
            Dictionary<string, object> dictionary4 = dictionary2;
            string key2 = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3749137450U);
            dateTime = this.DateCreated;
            // ISSUE: variable of a boxed type
            __Boxed<DateTime> local2 = (ValueType) (dateTime.Equals(DateTime.MinValue) ? DateTime.Now : this.DateCreated);
            dictionary4.Add(key2, (object) local2);
            num1 = 1073288967;
            continue;
          case 13:
            num1 = (int) num3 * -2104426947 ^ 768056586;
            continue;
          case 14:
            num1 = (int) num3 * -1272792293 ^ -874604154;
            continue;
          case 15:
            num1 = (int) num3 * -1657138693 ^ 494207303;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return dictionary1;
    }

    public override bool LoadDataObject(SQLiteDataReader cReader)
    {
      this.Uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U));
label_1:
      int num1 = 1107650424;
      bool flag;
      while (true)
      {
        int num2 = 1069279816;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            num1 = (int) num3 * 1953260561 ^ 271773365;
            continue;
          case 1:
            this.IsDirty = false;
            num1 = (int) num3 * 908916126 ^ 2114943629;
            continue;
          case 2:
            this.WindowWidth = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2817441920U));
            num1 = (int) num3 * -1418794068 ^ 276998529;
            continue;
          case 3:
            this.MeetingId = cReader.GetFieldValueString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2717614565U));
            num1 = (int) num3 * -1071789821 ^ -1798059575;
            continue;
          case 4:
            this.ZoomWindowType = (ZoomWindowType) cReader.GetFieldValueInt(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4147782293U));
            num1 = (int) num3 * -1873679463 ^ -244976101;
            continue;
          case 5:
            this.WindowHeight = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3171592636U));
            num1 = (int) num3 * -1332778724 ^ 1874307841;
            continue;
          case 6:
            goto label_1;
          case 7:
            this.DateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3397799221U));
            this.DateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2182723723U));
            num1 = (int) num3 * 1894121422 ^ -1987469597;
            continue;
          case 8:
            num1 = (int) num3 * -1869839248 ^ 383445111;
            continue;
          case 9:
            this.ButtonY = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3870973655U));
            num1 = (int) num3 * -616415211 ^ -1351233904;
            continue;
          case 10:
            num1 = (int) num3 * -1069391017 ^ 727019225;
            continue;
          case 11:
            this.ButtonX = cReader.GetFieldValueInt(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1138832489U));
            num1 = (int) num3 * 1350604003 ^ 1066484707;
            continue;
          case 12:
            this.RequiresRightClick = cReader.GetFieldValueInt(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1101356991U)) == 1;
            num1 = 1945143449;
            continue;
          case 13:
            this.ResultingWindowType = (ZoomWindowType) cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1743251508U));
            num1 = (int) num3 * -1739932937 ^ -2003563684;
            continue;
          case 14:
            flag = true;
            num1 = (int) num3 * 483403854 ^ 80292879;
            continue;
          case 16:
            num1 = (int) num3 * -864853066 ^ 2000277444;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return flag;
    }

    static void \u206F⁮⁬⁮⁫⁫⁬‮‌⁭‌‫​‫‎‍⁭⁪‎‌‏⁮​‎‌⁫‬⁬‌‮​‫‫‌⁯⁪‏‎‍‬‮([In] object obj0, [In] ref bool obj1)
    {
      Monitor.Enter(obj0, ref obj1);
    }

    static void \u202E​‪‪‬⁮‍‬⁬‮‭‪⁭‍​‪⁮⁪⁪⁫‮‏‪⁫⁮‎‮⁯⁫​⁯​⁫‌‪‪⁬​‌‎‮([In] object obj0)
    {
      Monitor.Exit(obj0);
    }

    int \u206D​⁬‎​‪​‬‪‏‌‪⁭‫⁭‎‪⁮‍‮‪⁭⁬⁮⁯‌⁪‬⁫‭‌‍‪​​‏⁪‫‎‎‮()
    {
      return base.GetHashCode();
    }

    static string \u206B⁫​‫‭‮‬‬⁪‍​⁪‎‮‫⁫⁬⁬‫‪‎⁯​‎⁫‏‏‏⁫⁪​‎‭‌‪‬⁯⁭‍‌‮([In] string obj0, [In] object[] obj1)
    {
      return string.Format(obj0, obj1);
    }

    static void \u206F⁪⁬‎‏‪‏‭‬⁮‬‏‌‪‌⁫‮⁮‫‍⁯⁮‍‎‍⁭⁯‫‭‫⁯‪⁬‮‌⁫⁮⁬⁬‫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static object \u200F‬‍‭‍⁮⁪‬‫⁮‭⁪⁯‎⁮⁪​⁭⁪⁫‎⁫⁮⁯‏‪‭⁭‍⁬⁪‍‮‬⁪‭‪⁯⁬⁭‮()
    {
      return new object();
    }
  }
}
