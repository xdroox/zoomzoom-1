// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Core.CoreOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Core
{
  public class CoreOptions : ObservableObject
  {
    protected static readonly ILog log = CoreOptions.\u206B‭‭⁪⁭‭‮⁫‪​‬‬‏‍​‌‪⁪​‫⁭‭‪⁬​⁯⁮⁮‪⁮​⁪‭⁭‎‌‏⁬⁮⁭‮(CoreOptions.\u206E‮⁪⁫‪‪‬⁭⁬‍⁬⁬‪‍⁮‮‬‭‏⁯‪⁭‍​‫‫⁬‍‪‭‮‭⁮⁭‬‎⁫‫⁬‪‮((MemberInfo) CoreOptions.\u202C‌‫⁭‫‭‭‏‎‬⁯⁬⁫‍‪‏‍‮‎⁭‭‫‏‌⁪⁯‭⁪‫‏‭​​⁬‏‭‍⁮⁪‎‮()));
    private Engine engine = (Engine) null;

    protected Engine Engine
    {
      get
      {
label_1:
        int num1 = 1232561034;
        Engine engine;
        while (true)
        {
          int num2 = 1824304147;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              engine = this.engine;
              num1 = (int) num3 * -313248101 ^ -773973105;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 930280141 ^ 1482416280;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return engine;
      }
      set
      {
label_1:
        int num1 = 967951502;
        while (true)
        {
          int num2 = 1528377560;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.engine = value;
              num1 = (int) num3 * 802265792 ^ -1753355013;
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

    public CoreOptions()
    {
      this.Engine = Engine.Instance;
    }

    static MethodBase \u202C‌‫⁭‫‭‭‏‎‬⁯⁬⁫‍‪‏‍‮‎⁭‭‫‏‌⁪⁯‭⁪‫‏‭​​⁬‏‭‍⁮⁪‎‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u206E‮⁪⁫‪‪‬⁭⁬‍⁬⁬‪‍⁮‮‬‭‏⁯‪⁭‍​‫‫⁬‍‪‭‮‭⁮⁭‬‎⁫‫⁬‪‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206B‭‭⁪⁭‭‮⁫‪​‬‬‏‍​‌‪⁪​‫⁭‭‪⁬​⁯⁮⁮‪⁮​⁪‭⁭‎‌‏⁬⁮⁭‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
