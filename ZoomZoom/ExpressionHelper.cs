// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ExpressionHelper
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Linq.Expressions;

namespace ZoomZoom
{
  [Obsolete("Use ExpressionUtilities instead. 9/25/2014")]
  public class ExpressionHelper
  {
    [Obsolete("Use ExpressionUtilities.GetPropertyName instead. 9/25/2014")]
    public static string GetName<TClass, TProperty>(Expression<Func<TClass, TProperty>> expression)
    {
label_1:
      int num1 = 765084080;
      string propertyName;
      while (true)
      {
        int num2 = 542021591;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            num1 = (int) num3 * -1296494272 ^ -1841687354;
            continue;
          case 2:
            goto label_1;
          case 3:
            propertyName = ExpressionUtilities.GetPropertyName<TClass, TProperty>(expression);
            num1 = (int) num3 * -701321050 ^ 513466501;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return propertyName;
    }

    [Obsolete("Use ExpressionUtilities.GetPropertyName instead. 9/25/2014")]
    public static string GetName<TProperty>(Expression<Func<TProperty>> expression)
    {
label_1:
      int num1 = -1214815627;
      string propertyName;
      while (true)
      {
        int num2 = -1310253325;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 1:
            propertyName = ExpressionUtilities.GetPropertyName<TProperty>(expression);
            num1 = (int) num3 * -1011852755 ^ -1335856473;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return propertyName;
    }

    [Obsolete("Use ExpressionUtilities.GetPropertyName instead. 9/25/2014")]
    public static string GetName<TClass>(Expression<Func<TClass, object>> expression)
    {
label_1:
      int num1 = 1000859716;
      string propertyName;
      while (true)
      {
        int num2 = 6155730;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            propertyName = ExpressionUtilities.GetPropertyName<TClass>(expression);
            num1 = (int) num3 * 2057970788 ^ -263082944;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return propertyName;
    }
  }
}
