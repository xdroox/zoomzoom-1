// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.ActivityEventBaseArguments
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom.Models.Activities
{
  internal class ActivityEventBaseArguments
  {
    private ActivityBase currentActivity;

    public string TargetGuid { get; set; }

    public string ActivityName { get; set; }

    public string Status { get; set; }

    public ActivityEventBaseArguments(ActivityBase currentActivity, string statusReport = "")
    {
label_1:
      int num1 = 6894523;
      while (true)
      {
        int num2 = 1143797209;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            this.TargetGuid = currentActivity.Guid;
            num1 = (int) num3 * 1576181957 ^ 1829142634;
            continue;
          case 2:
            num1 = (int) num3 * 92920028 ^ -1426800904;
            continue;
          case 4:
            num1 = (int) num3 * 571135437 ^ 974194008;
            continue;
          case 5:
            this.ActivityName = ActivityEventBaseArguments.\u202C‫⁫‭⁭‪‪‏‍‬⁭‎‬⁫⁪⁭⁭‭‏‌‬⁭‭‏‬​⁮‍‎⁬‬⁭​⁯⁯⁫⁭⁬​⁬‮((object) currentActivity);
            num1 = (int) num3 * -1997683879 ^ -351730849;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      this.Status = statusReport;
    }

    static string \u202C‫⁫‭⁭‪‪‏‍‬⁭‎‬⁫⁪⁭⁭‭‏‌‬⁭‭‏‬​⁮‍‎⁬‬⁭​⁯⁯⁫⁭⁬​⁬‮([In] object obj0)
    {
      return obj0.ToString();
    }
  }
}
