// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ExpressionUtilities
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public class ExpressionUtilities
  {
    [MethodImpl((MethodImplOptions) 256)]
    public static string GetPropertyName<TClass, TProperty>(Expression<Func<TClass, TProperty>> expression)
    {
      if (!(ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression) is UnaryExpression))
        goto label_5;
label_1:
      int num1 = -1729304794;
label_2:
      string str;
      while (true)
      {
        int num2 = -881579743;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            num1 = (int) num3 * 1948357330 ^ -1018981067;
            continue;
          case 1:
            str = ExpressionUtilities.\u202D‎‌⁪⁪‍‫‌‭⁭⁪‮‎‬‌⁮‪‎⁭‬‌⁪⁯⁫‏⁫‎⁮‍⁪‏‎‍⁯‮⁭‬‍‌⁫‮(ExpressionUtilities.\u202D⁬⁪​⁭⁭‎‌‫‮⁫‏‫‭‎‎​‪‭‍⁮⁪⁪⁮‬‬‫‎⁭‪‌‭⁮⁬⁯⁪​⁫‏⁫‮((MemberExpression) ExpressionUtilities.\u202B⁪‍​‫‎‪⁫⁫‌⁯⁮‭‬‪‪‍‏​‭‍‎⁬‮‭⁭‪‮⁪⁭‏‪⁮‌‫‬‮⁪‭‏‮((UnaryExpression) ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression))));
            num1 = (int) num3 * 1209889181 ^ -757266186;
            continue;
          case 3:
            num1 = (int) num3 * -954873378 ^ -1724810865;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_7:
      return str;
label_5:
      str = ExpressionUtilities.\u202D‎‌⁪⁪‍‫‌‭⁭⁪‮‎‬‌⁮‪‎⁭‬‌⁪⁯⁫‏⁫‎⁮‍⁪‏‎‍⁯‮⁭‬‍‌⁫‮(ExpressionUtilities.\u202D⁬⁪​⁭⁭‎‌‫‮⁫‏‫‭‎‎​‪‭‍⁮⁪⁪⁮‬‬‫‎⁭‪‌‭⁮⁬⁯⁪​⁫‏⁫‮((MemberExpression) ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression)));
      num1 = -598421682;
      goto label_2;
    }

    [MethodImpl((MethodImplOptions) 256)]
    public static string GetPropertyName<TProperty>(Expression<Func<TProperty>> expression)
    {
label_1:
      int num1 = -736521882;
      string str;
      while (true)
      {
        int num2 = -2141533736;
        uint num3;
        bool flag;
        switch ((num3 = (uint) (num1 ^ num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            str = ExpressionUtilities.\u202D‎‌⁪⁪‍‫‌‭⁭⁪‮‎‬‌⁮‪‎⁭‬‌⁪⁯⁫‏⁫‎⁮‍⁪‏‎‍⁯‮⁭‬‍‌⁫‮(ExpressionUtilities.\u202D⁬⁪​⁭⁭‎‌‫‮⁫‏‫‭‎‎​‪‭‍⁮⁪⁪⁮‬‬‫‎⁭‪‌‭⁮⁬⁯⁪​⁫‏⁫‮((MemberExpression) ExpressionUtilities.\u202B⁪‍​‫‎‪⁫⁫‌⁯⁮‭‬‪‪‍‏​‭‍‎⁬‮‭⁭‪‮⁪⁭‏‪⁮‌‫‬‮⁪‭‏‮((UnaryExpression) ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression))));
            num1 = (int) num3 * 1181907590 ^ 1358088426;
            continue;
          case 3:
            str = ExpressionUtilities.\u202D‎‌⁪⁪‍‫‌‭⁭⁪‮‎‬‌⁮‪‎⁭‬‌⁪⁯⁫‏⁫‎⁮‍⁪‏‎‍⁯‮⁭‬‍‌⁫‮(ExpressionUtilities.\u202D⁬⁪​⁭⁭‎‌‫‮⁫‏‫‭‎‎​‪‭‍⁮⁪⁪⁮‬‬‫‎⁭‪‌‭⁮⁬⁯⁪​⁫‏⁫‮((MemberExpression) ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression)));
            num1 = -1684095560;
            continue;
          case 4:
            flag = ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression) is UnaryExpression;
            num1 = (int) num3 * 1540476008 ^ 313396080;
            continue;
          case 5:
            int num4 = !flag ? 42004330 : (num4 = 185423751);
            int num5 = (int) num3 * 1384376410;
            num1 = num4 ^ num5;
            continue;
          case 6:
            num1 = (int) num3 * -296051025 ^ -964953648;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return str;
    }

    [MethodImpl((MethodImplOptions) 256)]
    public static string GetPropertyName<TClass>(Expression<Func<TClass, object>> expression)
    {
label_1:
      int num1 = -1575939316;
      string str;
      while (true)
      {
        int num2 = -1560980374;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            str = ExpressionUtilities.\u202D‎‌⁪⁪‍‫‌‭⁭⁪‮‎‬‌⁮‪‎⁭‬‌⁪⁯⁫‏⁫‎⁮‍⁪‏‎‍⁯‮⁭‬‍‌⁫‮(ExpressionUtilities.\u202D⁬⁪​⁭⁭‎‌‫‮⁫‏‫‭‎‎​‪‭‍⁮⁪⁪⁮‬‬‫‎⁭‪‌‭⁮⁬⁯⁪​⁫‏⁫‮((MemberExpression) ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression)));
            num1 = -1667575219;
            continue;
          case 1:
            num1 = (int) num3 * -1586500794 ^ -2119440858;
            continue;
          case 2:
            int num4 = ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression) is UnaryExpression ? 1033492187 : (num4 = 1661271604);
            int num5 = (int) num3 * 1068189696;
            num1 = num4 ^ num5;
            continue;
          case 3:
            goto label_1;
          case 5:
            str = ExpressionUtilities.\u202D‎‌⁪⁪‍‫‌‭⁭⁪‮‎‬‌⁮‪‎⁭‬‌⁪⁯⁫‏⁫‎⁮‍⁪‏‎‍⁯‮⁭‬‍‌⁫‮(ExpressionUtilities.\u202D⁬⁪​⁭⁭‎‌‫‮⁫‏‫‭‎‎​‪‭‍⁮⁪⁪⁮‬‬‫‎⁭‪‌‭⁮⁬⁯⁪​⁫‏⁫‮((MemberExpression) ExpressionUtilities.\u202B⁪‍​‫‎‪⁫⁫‌⁯⁮‭‬‪‪‍‏​‭‍‎⁬‮‭⁭‪‮⁪⁭‏‪⁮‌‫‬‮⁪‭‏‮((UnaryExpression) ExpressionUtilities.\u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮((LambdaExpression) expression))));
            num1 = (int) num3 * -2090886632 ^ 142911252;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return str;
    }

    static Expression \u206D‮‭‫‮⁯‎‪⁫⁮‫​⁪‍​⁭​⁪⁪⁭‍⁬⁭‭⁯⁬⁬‏⁪⁬⁮​⁯‪‌⁬‬⁭⁯‭‮([In] LambdaExpression obj0)
    {
      return obj0.Body;
    }

    static Expression \u202B⁪‍​‫‎‪⁫⁫‌⁯⁮‭‬‪‪‍‏​‭‍‎⁬‮‭⁭‪‮⁪⁭‏‪⁮‌‫‬‮⁪‭‏‮([In] UnaryExpression obj0)
    {
      return obj0.Operand;
    }

    static MemberInfo \u202D⁬⁪​⁭⁭‎‌‫‮⁫‏‫‭‎‎​‪‭‍⁮⁪⁪⁮‬‬‫‎⁭‪‌‭⁮⁬⁯⁪​⁫‏⁫‮([In] MemberExpression obj0)
    {
      return obj0.Member;
    }

    static string \u202D‎‌⁪⁪‍‫‌‭⁭⁪‮‎‬‌⁮‪‎⁭‬‌⁪⁯⁫‏⁫‎⁮‍⁪‏‎‍⁯‮⁭‬‍‌⁫‮([In] MemberInfo obj0)
    {
      return obj0.Name;
    }
  }
}
