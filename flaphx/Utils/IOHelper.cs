// Decompiled with JetBrains decompiler
// Type: flaphx.Utils.IOHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace flaphx.Utils
{
  internal static class IOHelper
  {
    internal static void DeleteFile(string filePath)
    {
      try
      {
label_2:
        int num1 = -1369288659;
        while (true)
        {
          int num2 = -2026674009;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              num1 = (int) num3 * -698689044 ^ 698511114;
              continue;
            case 1:
              goto label_4;
            case 2:
              goto label_2;
            case 3:
              IOHelper.\u202B​⁫⁭‌⁬⁬‏‍⁮⁮‫‬‫‪‫‪⁫‎⁫​​⁭⁯‍‮⁮‮‎‫‪⁮‎‫⁯​⁫‪⁭‫‮(filePath);
              num1 = (int) num3 * 1377415113 ^ 1003049854;
              continue;
            case 4:
              int num4 = !flag ? 643675727 : (num4 = 1184941109);
              int num5 = (int) num3 * 1311214318;
              num1 = num4 ^ num5;
              continue;
            case 5:
              flag = IOHelper.\u202A⁫⁪⁯‮‫‎‭‌⁫⁪⁭‮‎⁭‫⁫‫‭‌‍⁬‪⁯⁬⁬‏‍‭⁮‬⁪‍‪‬‏‫‫‏‍‮(filePath);
              num1 = (int) num3 * 1266796344 ^ -1790497803;
              continue;
            case 6:
              num1 = -157298741;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        return;
label_4:;
      }
      catch (Exception ex)
      {
      }
    }

    static bool \u202A⁫⁪⁯‮‫‎‭‌⁫⁪⁭‮‎⁭‫⁫‫‭‌‍⁬‪⁯⁬⁬‏‍‭⁮‬⁪‍‪‬‏‫‫‏‍‮([In] string obj0)
    {
      return File.Exists(obj0);
    }

    static void \u202B​⁫⁭‌⁬⁬‏‍⁮⁮‫‬‫‪‫‪⁫‎⁫​​⁭⁯‍‮⁮‮‎‫‪⁮‎‫⁯​⁫‪⁭‫‮([In] string obj0)
    {
      File.Delete(obj0);
    }
  }
}
