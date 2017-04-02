// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Design.DesignDataService
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using ZoomZoom.Models;

namespace ZoomZoom.Design
{
  public class DesignDataService : IDataService
  {
    public void GetData(Action<DataItem, Exception> callback)
    {
label_1:
      int num1 = 1330091917;
      while (true)
      {
        int num2 = 661349110;
        uint num3;
        DataItem dataItem;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            dataItem = new DataItem(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(699634075U));
            num1 = (int) num3 * -1231456602 ^ 1509720552;
            continue;
          case 2:
            callback.Invoke(dataItem, (Exception) null);
            num1 = (int) num3 * 259839060 ^ -1397332187;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 356262761 ^ 1478909390;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_3:;
    }
  }
}
