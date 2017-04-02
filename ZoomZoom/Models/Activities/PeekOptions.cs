// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Activities.PeekOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

namespace ZoomZoom.Models.Activities
{
  public class PeekOptions : CoreObject
  {
    private bool leaveMeetingOnceCompleted = true;
    private bool useSpecializedPattern = false;
    private bool suspendInitialMeetingActivities = true;
    private bool maximizeImageViewerAfterCapture = true;

    public bool SuspendInitialMeetingActivities
    {
      get
      {
label_1:
        int num1 = -842355661;
        bool meetingActivities;
        while (true)
        {
          int num2 = -1731486834;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              meetingActivities = this.suspendInitialMeetingActivities;
              num1 = (int) num3 * 141161596 ^ -1184931524;
              continue;
            case 2:
              num1 = (int) num3 * 1189703021 ^ 1267154611;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingActivities;
      }
      set
      {
        this.suspendInitialMeetingActivities = value;
label_1:
        int num1 = 1167691189;
        while (true)
        {
          int num2 = 1658349056;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3660162393U));
              num1 = (int) num3 * -1315289003 ^ -503127729;
              continue;
            case 2:
              num1 = (int) num3 * 1391532583 ^ -478301547;
              continue;
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

    public bool UseSpecializedPattern
    {
      get
      {
        bool specializedPattern = this.useSpecializedPattern;
label_1:
        int num1 = -222482815;
        while (true)
        {
          int num2 = -1032617213;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 777562818 ^ -1423765928;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return specializedPattern;
      }
      set
      {
label_1:
        int num1 = 2062109129;
        while (true)
        {
          int num2 = 1054913038;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(21795600U));
              num1 = (int) num3 * -1832898342 ^ 913146530;
              continue;
            case 2:
              this.useSpecializedPattern = value;
              num1 = (int) num3 * 1623286825 ^ 69319204;
              continue;
            case 3:
              goto label_3;
            case 4:
              num1 = (int) num3 * -1263954433 ^ -1061077347;
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

    public bool LeaveMeetingOnceCompleted
    {
      get
      {
        bool meetingOnceCompleted = this.leaveMeetingOnceCompleted;
label_1:
        int num1 = 402917606;
        while (true)
        {
          int num2 = 1634398580;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 1246113553 ^ -1865224459;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return meetingOnceCompleted;
      }
      set
      {
label_1:
        int num1 = 516523158;
        while (true)
        {
          int num2 = 483475774;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              num1 = (int) num3 * -1228435158 ^ -1954049293;
              continue;
            case 1:
              this.leaveMeetingOnceCompleted = value;
              num1 = (int) num3 * -1990823922 ^ 1019801646;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3221695933U));
              num1 = (int) num3 * -1160344135 ^ -134410271;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    public bool MaximizeImageViewerAfterCapture
    {
      get
      {
        bool viewerAfterCapture = this.maximizeImageViewerAfterCapture;
label_1:
        int num1 = -471592799;
        while (true)
        {
          int num2 = -1164460374;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * -1084859262 ^ 232528466;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return viewerAfterCapture;
      }
      set
      {
        this.maximizeImageViewerAfterCapture = value;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 519181043;
        TraceType traceType;
        while (true)
        {
          int num2 = 84787318;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              traceType = TraceType.Activity;
              num1 = (int) num3 * 2130292034 ^ 66978829;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public PeekOptions()
    {
      if (this.Engine == null)
        return;
      this.LeaveMeetingOnceCompleted = this.Engine.Settings.PeekOptions_LeaveMeetingOnceCompleted;
      this.SuspendInitialMeetingActivities = this.Engine.Settings.PeekOptions_SuspendInitialMeetingActivities;
      this.UseSpecializedPattern = this.Engine.Settings.PeekOptions_UseSpecializedPattern;
      this.MaximizeImageViewerAfterCapture = this.Engine.Settings.PeekOptions_MaximizeImageViewerAfterCapture;
    }
  }
}
