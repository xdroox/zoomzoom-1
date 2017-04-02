// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomActivityEventArgs
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public class ZoomActivityEventArgs : ZoomZoomEventArgs
  {
    public string ActivityId { get; set; }

    public ActivityState ActivityState { get; set; }

    public string ActivityDescription { get; set; }

    public string MinorStatus { get; private set; }

    public string Status { get; private set; }

    public string ActivityName { get; set; }

    public ActivityBase Activity { get; set; }

    public ZoomActivityEventArgs(ActivityBase activity, string status)
    {
      this.Activity = activity;
      this.ActivityName = activity.Name;
      this.ActivityDescription = activity.Name;
      this.ActivityId = ZoomActivityEventArgs.\u202A‭‌⁫⁯⁬​‎⁪‭⁭‎‮‏⁪⁬‮⁫⁮⁮⁭‮‮‬⁮​​‏⁬‌⁭⁪⁬‌‬‫‬⁭⁭⁬‮((object) activity);
      this.ActivityState = activity.ActivityState;
      this.Status = status;
      if (this.ActivityState != ActivityState.Completed || !(activity is JoinMeeting))
        return;
      this.Status = ZoomActivityEventArgs.\u206E‮⁪⁭⁬⁮‫⁫⁪‎‎​⁭⁪⁮⁪⁫⁫‏⁫⁮⁯‫⁪⁬‬‪‫‮⁫‫‫‎⁮‭‎‍‍⁯⁫‮((object) \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(436551003U), (object) ((JoinMeeting) activity).MeetingStatus);
    }

    static string \u202A‭‌⁫⁯⁬​‎⁪‭⁭‎‮‏⁪⁬‮⁫⁮⁮⁭‮‮‬⁮​​‏⁬‌⁭⁪⁬‌‬‫‬⁭⁭⁬‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u206E‮⁪⁭⁬⁮‫⁫⁪‎‎​⁭⁪⁮⁪⁫⁫‏⁫⁮⁯‫⁪⁬‬‪‫‮⁫‫‫‎⁮‭‎‍‍⁯⁫‮([In] object obj0, [In] object obj1)
    {
      return obj0.ToString() + obj1;
    }
  }
}
