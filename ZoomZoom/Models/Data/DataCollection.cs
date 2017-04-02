// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Data.DataCollection
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Data
{
  public class DataCollection : ObservableCollection<ZoomImage>
  {
    protected static readonly ILog log = DataCollection.\u206F‍⁬⁯⁮‮‪‌‌⁭‍‬‍⁪​⁮⁭⁮⁪‏‎⁫⁪‭‮‎‫‍⁭‏‭‏‏‪​⁬‪‎⁬⁯‮(DataCollection.\u200D‏​​‍‏‏⁪‎⁯⁬​‏‌‮⁭‮⁪‍‏‮‮‎‭‬‫‬⁪‏‮‫‍‮‪‎‬‫‏‌‎‮((MemberInfo) DataCollection.\u206E⁮‎‏‬⁭⁯⁮⁭‎‮‮‏‎‫⁬‮⁪‍‏‫‭‏⁬‏‏‮‏‏⁬‮‫‍‫⁮​‪⁯⁪⁭‮()));
    private Engine zoomZoom;

    public DataCollection()
    {
      base.\u002Ector();
label_1:
      int num1 = -60214553;
      while (true)
      {
        int num2 = -567779216;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            num1 = (int) num3 * -2089632561 ^ 813571927;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.zoomZoom = Engine.Instance;
    }

    static MethodBase \u206E⁮‎‏‬⁭⁯⁮⁭‎‮‮‏‎‫⁬‮⁪‍‏‫‭‏⁬‏‏‮‏‏⁬‮‫‍‫⁮​‪⁯⁪⁭‮()
    {
      return MethodBase.GetCurrentMethod();
    }

    static Type \u200D‏​​‍‏‏⁪‎⁯⁬​‏‌‮⁭‮⁪‍‏‮‮‎‭‬‫‬⁪‏‮‫‍‮‪‎‬‫‏‌‎‮([In] MemberInfo obj0)
    {
      return obj0.DeclaringType;
    }

    static ILog \u206F‍⁬⁯⁮‮‪‌‌⁭‍‬‍⁪​⁮⁭⁮⁪‏‎⁫⁪‭‮‎‫‍⁭‏‭‏‏‪​⁬‪‎⁬⁯‮([In] Type obj0)
    {
      return LogManager.GetLogger(obj0);
    }
  }
}
