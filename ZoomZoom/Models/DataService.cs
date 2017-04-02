// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.DataService
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;

namespace ZoomZoom.Models
{
  public class DataService : IDataService
  {
    public void GetData(Action<DataItem, Exception> callback)
    {
label_1:
      int num1 = 683606526;
      while (true)
      {
        int num2 = 668103531;
        uint num3;
        DataItem dataItem;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            callback.Invoke(dataItem, (Exception) null);
            num1 = (int) num3 * 881323154 ^ -887837292;
            continue;
          case 1:
            dataItem = new DataItem(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2330202808U));
            num1 = (int) num3 * -1209313109 ^ -586078352;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
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
