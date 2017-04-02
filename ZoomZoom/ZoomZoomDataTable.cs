// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomZoomDataTable
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace ZoomZoom
{
  public class ZoomZoomDataTable : CoreObject
  {
    private DataTable dtRecords = (DataTable) null;

    public DataTable Table
    {
      get
      {
        DataTable dtRecords = this.dtRecords;
label_1:
        int num1 = -1786995875;
        while (true)
        {
          int num2 = -1746549555;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * -513045038 ^ -1752208846;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return dtRecords;
      }
    }

    public override TraceType TraceType
    {
      get
      {
label_1:
        int num1 = 2001756887;
        TraceType traceType;
        while (true)
        {
          int num2 = 312241233;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              num1 = (int) num3 * 303843719 ^ -591915798;
              continue;
            case 2:
              traceType = TraceType.DataStorage;
              num1 = (int) num3 * -1423532667 ^ -477882946;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return traceType;
      }
    }

    public ZoomZoomDataTable(ObjectDataTable zTable)
    {
label_1:
      int num1 = -186716135;
      while (true)
      {
        int num2 = -1228522820;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        switch ((num3 = (uint) (num1 ^ num2)) % 153U)
        {
          case 0:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2131605649U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(79335662U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1595765881U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -2009483108 ^ 1160329981;
            continue;
          case 1:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3335598589U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1012655458U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2191166129U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -795388514 ^ -1020073197;
            continue;
          case 2:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809658423U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2872383811U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U), false, true, SqlDataType.AUTO, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3382247043U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2447814532U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -544649728 ^ -6345650;
            continue;
          case 3:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3749137450U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1012655458U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1085347245U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -1523990965 ^ 687121591;
            continue;
          case 4:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3570847879U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3536836121U), false, false, SqlDataType.BLOB, "");
            num1 = (int) num3 * -1327085430 ^ -974490196;
            continue;
          case 5:
            num1 = (int) num3 * 1429224924 ^ 104919161;
            continue;
          case 6:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1393710410U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4210297005U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2791097987U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * 2035317386 ^ -597638212;
            continue;
          case 7:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3980213974U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(218802078U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3339368032U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            num1 = (int) num3 * 1402739805 ^ 1120044679;
            continue;
          case 8:
            num1 = (int) num3 * -1584309321 ^ -705277694;
            continue;
          case 9:
            flag1 = zTable == ObjectDataTable.Images;
            num1 = -1655886095;
            continue;
          case 10:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3866020062U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(439425413U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1068093275U), false, false, SqlDataType.CHAR255, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3749137450U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(218802078U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4110066166U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -625702726 ^ 765526552;
            continue;
          case 11:
            num1 = (int) num3 * -1959258098 ^ -2140368199;
            continue;
          case 12:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1284437015U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4264803125U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(823442149U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            num1 = (int) num3 * -781250013 ^ 126052239;
            continue;
          case 13:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(771323941U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3285416485U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1650272001U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -1447193656 ^ -1072041903;
            continue;
          case 14:
            num1 = (int) num3 * -16475088 ^ 1181106934;
            continue;
          case 15:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(388165143U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1854638451U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(742315859U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(379866246U));
            num1 = (int) num3 * 1913450255 ^ -1690590274;
            continue;
          case 16:
            num1 = (int) num3 * 2080092282 ^ -301423469;
            continue;
          case 17:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3934014715U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(79335662U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3057364918U), false, false, SqlDataType.DATETIME, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(756716222U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1012655458U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3675789310U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 1803959314 ^ -649293802;
            continue;
          case 18:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809658423U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(230266068U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809658423U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * -1699810808 ^ 2079069843;
            continue;
          case 19:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4010642295U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * 1126457507 ^ 620591456;
            continue;
          case 20:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4265576084U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3285416485U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1464963477U), false, false, SqlDataType.CHAR255, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1077609212U));
            num1 = (int) num3 * -1733291175 ^ -705176146;
            continue;
          case 21:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(69011950U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(842305745U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1205971567U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4010642295U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1169339606U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1875403407U));
            num1 = (int) num3 * -221617460 ^ -1990674425;
            continue;
          case 22:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3213433278U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2299193070U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3321360757U));
            num1 = (int) num3 * -1330639901 ^ 290326113;
            continue;
          case 23:
            num1 = (int) num3 * -825882714 ^ -1364339236;
            continue;
          case 24:
            num1 = (int) num3 * -1401620591 ^ -795715376;
            continue;
          case 25:
            num1 = (int) num3 * 718600963 ^ 796248969;
            continue;
          case 26:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3335598589U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(218802078U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3542051894U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -1998380219 ^ 1639758329;
            continue;
          case 27:
            num1 = (int) num3 * 734178779 ^ 2092739217;
            continue;
          case 28:
            num1 = (int) num3 * -34312493 ^ -709342175;
            continue;
          case 29:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3440097605U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2872383811U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1644894013U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3321360757U));
            num1 = (int) num3 * 1214036667 ^ -1279784911;
            continue;
          case 30:
            num1 = (int) num3 * -1872506906 ^ -376526594;
            continue;
          case 31:
            num1 = (int) num3 * 530121003 ^ -1032852207;
            continue;
          case 32:
            num1 = (int) num3 * -629708712 ^ 1817985413;
            continue;
          case 33:
            num1 = (int) num3 * -152833024 ^ -1682719927;
            continue;
          case 34:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2062857889U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3285416485U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3452646420U), false, false, SqlDataType.TEXT, "");
            num1 = (int) num3 * -786167205 ^ 1098353011;
            continue;
          case 35:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3645992511U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3896222972U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1875403407U));
            num1 = (int) num3 * 953736511 ^ 260058523;
            continue;
          case 36:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3444990068U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2519347422U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4108442718U), false, false, SqlDataType.TEXT, "");
            num1 = (int) num3 * 584212101 ^ -1477599658;
            continue;
          case 37:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2110344247U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1012655458U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3504646217U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 1372168962 ^ -1120641176;
            continue;
          case 38:
            this.dtRecords = ZoomZoomDataTable.\u202E‭‌‌⁫‪‏⁪‎‫‮⁫‫‫‭⁪‪⁪‮⁯⁭⁮‎‪‏‎‏‭⁯‮‪​‎‪‫‏‭⁯‎⁬‮(ZoomZoomDataTable.GetTableName(zTable));
            num1 = (int) num3 * 493965155 ^ -1813566659;
            continue;
          case 39:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3689749305U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(79335662U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2743957119U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -136631134 ^ 197049975;
            continue;
          case 40:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809658423U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763802783U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * 1221604499 ^ -1381545815;
            continue;
          case 41:
            num1 = (int) num3 * -587758836 ^ 1448340376;
            continue;
          case 42:
            num1 = (int) num3 * 817499311 ^ -363632603;
            continue;
          case 43:
            num1 = (int) num3 * 2014640172 ^ -1411949117;
            continue;
          case 44:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(240715330U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2822142358U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1338363100U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            num1 = (int) num3 * -405409582 ^ 162919277;
            continue;
          case 45:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2872383811U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * 181714022 ^ 1174651060;
            continue;
          case 46:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3848806831U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2519347422U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1881423708U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -1208782734 ^ -1208209450;
            continue;
          case 47:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(932623153U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2822142358U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3416655381U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(796984510U));
            num1 = (int) num3 * -864442864 ^ 1391162011;
            continue;
          case 48:
            goto label_3;
          case 49:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1257971364U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(330856199U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1476918632U), false, false, SqlDataType.TEXT, "");
            num1 = (int) num3 * 132606912 ^ 428688460;
            continue;
          case 50:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(258476723U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2353899725U), false, false, SqlDataType.CHAR255, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4042609916U));
            num1 = (int) num3 * 445417832 ^ 861691786;
            continue;
          case 51:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2131605649U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2594147511U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4004769233U), false, false, SqlDataType.DATETIME, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2110344247U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2594147511U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3542051894U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 1877661853 ^ 1804664236;
            continue;
          case 52:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1302173362U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763802783U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3431562141U), false, false, SqlDataType.BIGINT, "");
            num1 = (int) num3 * -1114764647 ^ -980997889;
            continue;
          case 53:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1009758262U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2990687298U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3321360757U));
            num1 = (int) num3 * -1009084810 ^ -632538487;
            continue;
          case 54:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1190308914U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(230266068U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2793531610U), false, false, SqlDataType.BIGINT, "");
            num1 = (int) num3 * 1953396211 ^ -947364442;
            continue;
          case 55:
            int num4;
            num1 = num4 = zTable == ObjectDataTable.Meetings ? -36285092 : (num4 = -96651736);
            continue;
          case 56:
            num1 = (int) num3 * 1391052689 ^ -1907832235;
            continue;
          case 57:
            num1 = (int) num3 * -1150290852 ^ 1234791204;
            continue;
          case 58:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2273146441U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3962109739U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(379866246U));
            num1 = (int) num3 * 158380443 ^ 1183132200;
            continue;
          case 59:
            num1 = (int) num3 * 1865719470 ^ 1685781811;
            continue;
          case 60:
            num1 = (int) num3 * 824950308 ^ -867793742;
            continue;
          case 61:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3090839352U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2519347422U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2558390674U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -2066634608 ^ -397650326;
            continue;
          case 62:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(850864340U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1012655458U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(533313733U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 1320628117 ^ 520494956;
            continue;
          case 63:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3180789194U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2519347422U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(469809388U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(379866246U));
            num1 = (int) num3 * -893291952 ^ 1173660075;
            continue;
          case 64:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3335598589U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1012655458U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2191166129U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 2040925028 ^ 914549940;
            continue;
          case 65:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4184677475U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763802783U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1186946514U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * 606711613 ^ -1884746414;
            continue;
          case 66:
            flag4 = zTable == ObjectDataTable.MessageContent;
            num1 = -487929281;
            continue;
          case 67:
            num1 = (int) num3 * -693482025 ^ 909272308;
            continue;
          case 68:
            num1 = (int) num3 * -721764013 ^ 1762112674;
            continue;
          case 69:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(439425413U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809658423U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * -880558518 ^ 541397571;
            continue;
          case 70:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2208913666U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3765902094U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3297400768U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            num1 = (int) num3 * 1828756637 ^ -1789226021;
            continue;
          case 71:
            num1 = (int) num3 * 1107871896 ^ 936025808;
            continue;
          case 72:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2223083214U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(79335662U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2743957119U), false, false, SqlDataType.DATETIME, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3075063878U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2822142358U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3931953956U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -1354393067 ^ 1505392269;
            continue;
          case 73:
            num1 = (int) num3 * 173163156 ^ -1868985257;
            continue;
          case 74:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3666502981U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2872383811U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U), false, true, SqlDataType.AUTO, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(69825715U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(576753682U), false, false, SqlDataType.INTEGER, "");
            num1 = (int) num3 * 1226017440 ^ 1794838766;
            continue;
          case 75:
            int num5 = flag1 ? 1674228870 : (num5 = 1155324197);
            int num6 = (int) num3 * 923592152;
            num1 = num5 ^ num6;
            continue;
          case 76:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1908639481U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2822142358U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4101871538U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            num1 = (int) num3 * -178517222 ^ -1234141688;
            continue;
          case 77:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3887009631U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3494037062U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(792221796U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * 1819444475 ^ 1966055546;
            continue;
          case 78:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1340030865U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2445849749U), false, false, SqlDataType.TEXT, "");
            num1 = (int) num3 * -2091000967 ^ 2008739482;
            continue;
          case 79:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3335598589U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2403466730U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1085347245U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 2037152867 ^ -2144387904;
            continue;
          case 80:
            num1 = (int) num3 * 742893923 ^ 422647797;
            continue;
          case 81:
            num1 = (int) num3 * 781540803 ^ 1867850019;
            continue;
          case 82:
            num1 = (int) num3 * -1704202643 ^ -251193573;
            continue;
          case 83:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4010642295U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(890639199U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * -1459715358 ^ -668886048;
            continue;
          case 84:
            num1 = (int) num3 * 80337867 ^ -400945973;
            continue;
          case 85:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2590097170U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4074658362U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            num1 = (int) num3 * 586182597 ^ -2081413467;
            continue;
          case 86:
            num1 = (int) num3 * -650819520 ^ 1021765209;
            continue;
          case 87:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(179000486U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4210297005U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(67439346U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -524755469 ^ -1220337805;
            continue;
          case 88:
            flag2 = zTable == ObjectDataTable.Buttons;
            num1 = -704892030;
            continue;
          case 89:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2131605649U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2594147511U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(206748010U), false, false, SqlDataType.DATETIME, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(573709161U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2594147511U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3542051894U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -686217882 ^ 1930219137;
            continue;
          case 90:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(749377801U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3765902094U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3132943240U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            num1 = (int) num3 * 121650348 ^ -1579830535;
            continue;
          case 91:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(511804889U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3756318934U), false, false, SqlDataType.INTEGER, "");
            num1 = (int) num3 * -1389767341 ^ 1577033284;
            continue;
          case 92:
            num1 = (int) num3 * 506710396 ^ -578577486;
            continue;
          case 93:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2953331651U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2618473868U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1858185237U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1854638451U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(4277202194U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * 1561232740 ^ 1234484092;
            continue;
          case 94:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(413833566U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2822142358U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1032287977U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * -1669652084 ^ -1304096670;
            continue;
          case 95:
            int num7 = flag3 ? 1279376115 : (num7 = 1266023753);
            int num8 = (int) num3 * -939047168;
            num1 = num7 ^ num8;
            continue;
          case 96:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(995623292U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763802783U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1934549649U), false, false, SqlDataType.BIGINT, "");
            num1 = (int) num3 * 451973331 ^ 724717730;
            continue;
          case 97:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3758218176U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2872383811U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3322992927U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3321360757U));
            num1 = (int) num3 * 1847987877 ^ 637761864;
            continue;
          case 98:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763802783U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3772655508U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * 406053584 ^ 312564656;
            continue;
          case 99:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2131605649U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1012655458U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3250613451U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -1178735638 ^ 266686795;
            continue;
          case 100:
            num1 = (int) num3 * -976678905 ^ -436352284;
            continue;
          case 101:
            num1 = (int) num3 * 696531953 ^ -783210587;
            continue;
          case 102:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1679528045U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2403466730U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(206748010U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 1800934087 ^ -2090031963;
            continue;
          case 103:
            flag3 = zTable == ObjectDataTable.Users;
            num1 = -1801129474;
            continue;
          case 104:
            num1 = (int) num3 * 878012806 ^ 1581269790;
            continue;
          case 105:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2169446332U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1854638451U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1730644455U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * 664253073 ^ 965644220;
            continue;
          case 106:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(721856803U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3765902094U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4274111715U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(379866246U));
            num1 = (int) num3 * 138819150 ^ -1370752317;
            continue;
          case 107:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(765642902U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3285416485U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2051846353U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -1387845609 ^ 1574778168;
            continue;
          case 108:
            int num9;
            num1 = num9 = zTable == ObjectDataTable.MessageCategory ? -1693473064 : (num9 = -703015179);
            continue;
          case 109:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2109086311U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2763802783U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4164667596U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * -1939993931 ^ 1763386340;
            continue;
          case 110:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3174833053U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2767265747U), false, false, SqlDataType.CHAR255, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(131947921U));
            num1 = (int) num3 * 419006781 ^ -1317377803;
            continue;
          case 111:
            num1 = (int) num3 * -1005737237 ^ 442424504;
            continue;
          case 112:
            num1 = (int) num3 * 1091601337 ^ 1439480131;
            continue;
          case 113:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1809658423U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4010642295U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U), false, true, SqlDataType.AUTO, "");
            num1 = (int) num3 * -432280388 ^ -1911791561;
            continue;
          case 114:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2195805526U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1724310416U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * 138279499 ^ 1772670900;
            continue;
          case 115:
            num1 = (int) num3 * 1071871972 ^ -86985596;
            continue;
          case 116:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3089005445U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4233546122U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -1071021137 ^ -677686622;
            continue;
          case 117:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3921276970U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(904086244U), false, false, SqlDataType.INTEGER, "");
            num1 = (int) num3 * 25645241 ^ -978042349;
            continue;
          case 118:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3689749305U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2594147511U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3250613451U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 1514134232 ^ 352075499;
            continue;
          case 119:
            num1 = (int) num3 * 371268384 ^ -964033024;
            continue;
          case 120:
            int num10;
            num1 = num10 = zTable == ObjectDataTable.ActivityLog ? -1493790885 : (num10 = -68385893);
            continue;
          case 121:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(461293305U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1379078901U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * 1650669262 ^ 514184841;
            continue;
          case 122:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3372572099U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2959082709U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3321360757U));
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3280929938U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(32237298U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1875403407U));
            num1 = (int) num3 * 1879413580 ^ -1640244561;
            continue;
          case 123:
            num1 = (int) num3 * -855056054 ^ 977200976;
            continue;
          case 124:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3450719713U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(230266068U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1186946514U), false, false, SqlDataType.BIGINT, "");
            num1 = (int) num3 * 339340602 ^ -1056096884;
            continue;
          case 125:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3397799221U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(218802078U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2743957119U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * 20284207 ^ 770823588;
            continue;
          case 126:
            int num11 = flag2 ? -1716497629 : (num11 = -763764302);
            int num12 = (int) num3 * 50014445;
            num1 = num11 ^ num12;
            continue;
          case (uint) sbyte.MaxValue:
            goto label_1;
          case 128:
            num1 = (int) num3 * 22530435 ^ -280823073;
            continue;
          case 129:
            int num13;
            num1 = num13 = zTable == ObjectDataTable.Chats ? -531694653 : (num13 = -2989739);
            continue;
          case 130:
            int num14;
            num1 = num14 = zTable == ObjectDataTable.Settings ? -1027778651 : (num14 = -283414184);
            continue;
          case 131:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(415143333U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1504405030U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * 1154158282 ^ 1413074319;
            continue;
          case 132:
            num1 = (int) num3 * 926406651 ^ -1642938358;
            continue;
          case 133:
            num1 = (int) num3 * 1471770084 ^ 504270916;
            continue;
          case 134:
            num1 = (int) num3 * -1988067143 ^ -1165613115;
            continue;
          case 135:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1576745987U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(439425413U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1059601445U), false, false, SqlDataType.BIGINT, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * 1027256151 ^ -178339245;
            continue;
          case 136:
            num1 = (int) num3 * -322285932 ^ 1414525209;
            continue;
          case 137:
            num1 = (int) num3 * 545166497 ^ 1212543062;
            continue;
          case 138:
            int num15 = zTable == ObjectDataTable.Activities ? -22870932 : (num15 = -649796877);
            int num16 = (int) num3 * -593032251;
            num1 = num15 ^ num16;
            continue;
          case 139:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1386601224U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4210297005U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1201688509U), false, false, SqlDataType.TEXT, "");
            num1 = (int) num3 * -1951987995 ^ 974681350;
            continue;
          case 140:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3121440192U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(218802078U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2612440051U), false, false, SqlDataType.DATETIME, "");
            num1 = (int) num3 * -1710242023 ^ -590114537;
            continue;
          case 141:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3848806831U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(364453081U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(353473319U), false, false, SqlDataType.CHAR255, "");
            num1 = (int) num3 * -1612601759 ^ -886409971;
            continue;
          case 142:
            int num17 = !flag4 ? -461229412 : (num17 = -27906165);
            int num18 = (int) num3 * -342501488;
            num1 = num17 ^ num18;
            continue;
          case 143:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(2263636494U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2822142358U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1947782883U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3954314989U));
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3423026343U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(492222490U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1450779822U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3321360757U));
            num1 = (int) num3 * 932717025 ^ 689277802;
            continue;
          case 144:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1900366742U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3765902094U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(169490539U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1549624929U));
            num1 = (int) num3 * -196016325 ^ 5126124;
            continue;
          case 145:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2781190747U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(4210297005U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1721043217U), false, false, SqlDataType.TEXT, "");
            num1 = (int) num3 * 1687895907 ^ -382158370;
            continue;
          case 146:
            num1 = (int) num3 * -1201426625 ^ -409937452;
            continue;
          case 147:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2045719063U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1092693179U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1875403407U));
            num1 = (int) num3 * 1678898232 ^ -650659211;
            continue;
          case 148:
            num1 = (int) num3 * -57613908 ^ -1282682750;
            continue;
          case 149:
            num1 = (int) num3 * 1871334521 ^ -276111096;
            continue;
          case 150:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3311850810U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(330856199U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3222348680U), false, false, SqlDataType.TEXT, "");
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1441269875U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(501702451U), false, false, SqlDataType.INTEGER, "");
            num1 = (int) num3 * -1002357654 ^ -46603536;
            continue;
          case 151:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1196293930U), \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(523803786U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3319179238U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3321360757U));
            num1 = (int) num3 * 1222620545 ^ -1154582547;
            continue;
          case 152:
            ZoomZoomDataTable.AddDataColumn(ref this.dtRecords, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2148283125U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2822142358U), \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3457928409U), false, false, SqlDataType.INTEGER, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(379866246U));
            num1 = (int) num3 * 1722478192 ^ 792824912;
            continue;
          default:
            goto label_155;
        }
      }
label_155:
      return;
label_3:;
    }

    public static string GetTableName(ObjectDataTable zoomZoomTable)
    {
label_1:
      int num1 = 305787390;
      string str;
      while (true)
      {
        int num2 = 290209703;
        uint num3;
        ObjectDataTable objectDataTable;
        switch ((num3 = (uint) (num1 ^ num2)) % 24U)
        {
          case 0:
label_3:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3660307624U);
            num1 = 1073379598;
            continue;
          case 1:
            objectDataTable = zoomZoomTable;
            num1 = (int) num3 * 1049445884 ^ 289149017;
            continue;
          case 2:
            switch (objectDataTable)
            {
              case ObjectDataTable.Unkonown:
              case ObjectDataTable.NotSupported:
                goto label_20;
              case ObjectDataTable.ActivityLog:
                goto label_13;
              case ObjectDataTable.Buttons:
                goto label_9;
              case ObjectDataTable.Chats:
                goto label_15;
              case ObjectDataTable.Images:
                goto label_8;
              case ObjectDataTable.MessageCategory:
                goto label_3;
              case ObjectDataTable.MessageContent:
                goto label_24;
              case ObjectDataTable.Meetings:
                goto label_23;
              case ObjectDataTable.Settings:
                goto label_5;
              case ObjectDataTable.Users:
                goto label_14;
              case ObjectDataTable.Activities:
                goto label_4;
              default:
                num1 = (int) num3 * -241534852 ^ 619079223;
                continue;
            }
          case 3:
          case 20:
label_20:
            str = string.Empty;
            num1 = 1522286537;
            continue;
          case 4:
label_14:
            str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2810915955U);
            num1 = 453835657;
            continue;
          case 5:
            goto label_1;
          case 6:
label_15:
            str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4119167163U);
            num1 = 524591960;
            continue;
          case 7:
            num1 = (int) num3 * -28635228 ^ 1684045781;
            continue;
          case 8:
            num1 = (int) num3 * -65198957 ^ -607909204;
            continue;
          case 9:
label_13:
            str = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1842879422U);
            num1 = 1461231148;
            continue;
          case 10:
            num1 = (int) num3 * 37606490 ^ -1546788227;
            continue;
          case 11:
label_24:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1024068654U);
            num1 = 453835657;
            continue;
          case 12:
label_8:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(448445442U);
            num1 = 715006085;
            continue;
          case 13:
            num1 = (int) num3 * 559266711 ^ 317824682;
            continue;
          case 14:
            num1 = (int) num3 * -741359781 ^ 177783443;
            continue;
          case 15:
label_9:
            str = \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2249585399U);
            num1 = 1884453874;
            continue;
          case 16:
            num1 = (int) num3 * 175936767 ^ 1032324705;
            continue;
          case 17:
            num1 = (int) num3 * 551050453 ^ 111770900;
            continue;
          case 18:
label_4:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3810217973U);
            num1 = 1642513855;
            continue;
          case 19:
            num1 = (int) num3 * -568252705 ^ 731029916;
            continue;
          case 21:
label_5:
            str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1994378595U);
            num1 = 453835657;
            continue;
          case 23:
label_23:
            str = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3442423980U);
            num1 = 453835657;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return str;
    }

    public DataRow NewRow()
    {
label_1:
      int num1 = -2037526995;
      DataRow dataRow;
      while (true)
      {
        int num2 = -490169224;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            dataRow = ZoomZoomDataTable.\u202B​‬⁭‌‏⁬‫‭‬⁪‍‬‌‬‬⁫⁭⁬‬⁭‍‌⁫​‫‬‫⁪​‍⁯‬‪⁭⁬‏⁫‮‍‮(this.dtRecords);
            num1 = (int) num3 * -332899545 ^ -875270920;
            continue;
          case 3:
            num1 = (int) num3 * 661206598 ^ 1635109264;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return dataRow;
    }

    public bool AddRow(DataRow drRecord)
    {
label_1:
      int num1 = -1588329468;
      bool flag1;
      while (true)
      {
        int num2 = -192810999;
        uint num3;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 6U)
        {
          case 0:
            ZoomZoomDataTable.\u202E‮‍‮‫‏‏⁪⁪‎‬‭‭‫‬⁬‫‬‪⁭‬⁮‫⁫‎⁬​⁪‌⁯⁯⁬⁪‌‬‬‮⁫⁮⁪‮(ZoomZoomDataTable.\u206B⁯‍⁫⁫‪‪‭‪‮⁫‬⁭‎‬‬⁮​‪⁯⁮‫‎‫‏⁪⁭‭⁪⁮⁫⁫‪‎‮‎‎⁯‏‭‮(this.dtRecords), drRecord);
            flag2 = true;
            num1 = (int) num3 * -425874631 ^ 656275049;
            continue;
          case 1:
            num1 = (int) num3 * 1211390645 ^ -1779104397;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag2 = false;
            num1 = (int) num3 * 1721806291 ^ -1503712674;
            continue;
          case 4:
            flag1 = flag2;
            num1 = (int) num3 * 1677098017 ^ -1807400648;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return flag1;
    }

    public static void AddDataColumn(ref DataTable dt, string sColumnName, string sType, string sCaption, bool bReadyOnly, bool bUnique, SqlDataType dataType, string databaseDefault = "")
    {
      DataColumn dataColumn = ZoomZoomDataTable.\u206D‏⁫⁮‫⁯‮‪⁬⁬⁯​‌‏​‬‏‮⁬⁬‭‬‌‬⁫⁭‌⁫⁮‫⁭⁬‫‍⁪⁮⁫‍‏⁭‮();
label_1:
      int num1 = -80247107;
      while (true)
      {
        int num2 = -1790563004;
        uint num3;
        bool flag1;
        bool flag2;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            ZoomZoomDataTable.\u200D⁬‬‪‍‫​​‏‬⁬‌⁯⁫‏⁮⁬‏⁮⁯‏‍⁯‭⁮​⁬⁯⁯‎‎‍‫⁯‭‍⁬‭⁯⁬‮((Hashtable) ZoomZoomDataTable.\u206F⁭⁭​‭‭‎⁬⁪​‫⁫‫‭‬​⁪⁫‍‎‬‏‫‏​‌⁬‍‫⁯‏⁮‍‫⁪‪⁪⁫‍‮(dataColumn), (object) \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2228199790U), (object) databaseDefault);
            num1 = (int) num3 * -1605079286 ^ 1578133939;
            continue;
          case 1:
            flag1 = !ZoomZoomDataTable.\u200B‬⁭‭⁯‎‮‪​⁭⁭‪⁯‫‍⁪⁫⁫‎‫‪‎​⁬‭⁮⁮⁬⁮‍⁯‬‍​⁪‮⁪‏‫‮‮(databaseDefault, string.Empty);
            num1 = -72256197;
            continue;
          case 2:
            ZoomZoomDataTable.\u206A‬‌‎‏‎⁭‫⁯‪‭​⁪⁬​‬⁫⁫⁫‏‏​‮‭⁯​‌⁪‮​⁫‏​‫‬​‏‬‬‏‮(dataColumn, bReadyOnly);
            num1 = (int) num3 * -696007044 ^ -154340328;
            continue;
          case 3:
            flag2 = !ZoomZoomDataTable.\u200B‬⁭‭⁯‎‮‪​⁭⁭‪⁯‫‍⁪⁫⁫‎‫‪‎​⁬‭⁮⁮⁬⁮‍⁯‬‍​⁪‮⁪‏‫‮‮(ZoomZoomDataTable.GetDataType(dataType), string.Empty);
            num1 = (int) num3 * -1577545030 ^ 993372862;
            continue;
          case 4:
            num1 = (int) num3 * 1004265749 ^ 1372807588;
            continue;
          case 5:
            num1 = (int) num3 * -1521472928 ^ 1902265678;
            continue;
          case 6:
            ZoomZoomDataTable.\u200B⁫‍⁮‪‏‏⁫⁪⁫⁯‪‭‫⁬⁮‮‍‬‏‎⁬‎‏‪⁪​​‏‬​​‌​⁫‫‪⁪⁭‭‮(ZoomZoomDataTable.\u200D⁭​‎‏‫‍⁭​‎⁪​‏​⁬⁬⁭⁯‪⁮⁮‌‬‌‪‫⁬‮‫⁭⁯⁬​‭⁫⁪⁮‌‏⁪‮(dt), dataColumn);
            num1 = -1919201881;
            continue;
          case 7:
            ZoomZoomDataTable.\u206D‏⁫‏‏‍‬‫⁮‏​⁬⁫‭⁪⁫⁪‏⁭‬⁬‎⁮‭‍⁭‍‪‪‮‍‪‮‌⁮‫​‮‮⁪‮(dataColumn, ZoomZoomDataTable.\u200E‍⁮‬⁬⁯​‭‮‎‫⁪⁮⁯​‏​​‌⁮‬‎⁯‌‏⁪⁬‭‪‭‎‏‎‌⁭‍‍‫‫‍‮(sType));
            ZoomZoomDataTable.\u200F⁪‎‌‍⁮‪⁫‬⁪‫‮⁪⁬⁫⁮‍⁫‌‪‍⁭‏‏‏‌⁮⁮⁭‎⁮‌‏‬‭⁬‮‮‭‫‮(dataColumn, sColumnName);
            num1 = (int) num3 * 628021339 ^ -1007973403;
            continue;
          case 8:
            goto label_3;
          case 9:
            ZoomZoomDataTable.\u200C‮⁪⁬‮⁯⁭⁫‍​‪⁭⁫‭⁮‫⁯‮‫‫​‏‭‭‭‎‪‮‏‮⁬⁫‍‌‌‬‭‬⁭‭‮(dataColumn, dataType == SqlDataType.AUTO);
            num1 = (int) num3 * -1415079578 ^ -1304516963;
            continue;
          case 10:
            ZoomZoomDataTable.\u200D⁬‬‪‍‫​​‏‬⁬‌⁯⁫‏⁮⁬‏⁮⁯‏‍⁯‭⁮​⁬⁯⁯‎‎‍‫⁯‭‍⁬‭⁯⁬‮((Hashtable) ZoomZoomDataTable.\u206F⁭⁭​‭‭‎⁬⁪​‫⁫‫‭‬​⁪⁫‍‎‬‏‫‏​‌⁬‍‫⁯‏⁮‍‫⁪‪⁪⁫‍‮(dataColumn), (object) \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3122428034U), (object) ZoomZoomDataTable.GetDataType(dataType));
            num1 = (int) num3 * -1552325280 ^ 1383349127;
            continue;
          case 11:
            ZoomZoomDataTable.\u206B⁯‏⁪⁬‬‮⁮⁭⁯⁯‮⁫‪‪‬​‫‮⁯⁭⁮⁬⁯‏⁭⁭⁪‪⁬‍‮⁪⁫⁪‌‮‌‪‭‮(dataColumn, bUnique);
            num1 = (int) num3 * 300510151 ^ 1270310990;
            continue;
          case 12:
            num1 = (int) num3 * -663687356 ^ 1608771859;
            continue;
          case 13:
            num1 = (int) num3 * -2018152322 ^ -1409937465;
            continue;
          case 14:
            num1 = (int) num3 * -1748148591 ^ 826934194;
            continue;
          case 15:
            goto label_1;
          case 16:
            int num4 = flag2 ? 287988899 : (num4 = 771624398);
            int num5 = (int) num3 * -1730811672;
            num1 = num4 ^ num5;
            continue;
          case 17:
            int num6 = !flag1 ? 1792741525 : (num6 = 112836871);
            int num7 = (int) num3 * 620681286;
            num1 = num6 ^ num7;
            continue;
          case 18:
            ZoomZoomDataTable.\u206F⁬⁯⁬‫‪⁭‍‭‬⁪⁭‮‬⁮‪‭⁬‭​‏⁪‬‮‪​‍​⁪⁪‌‍‏‌⁪⁮⁫‫‍‬‮(dataColumn, sCaption);
            num1 = (int) num3 * -1897114941 ^ 532513719;
            continue;
          default:
            goto label_21;
        }
      }
label_21:
      return;
label_3:;
    }

    public static string[] GetEmpty()
    {
label_1:
      int num1 = -2078428581;
      string[] strArray;
      while (true)
      {
        int num2 = -870426835;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            strArray = new string[0];
            num1 = (int) num3 * 1645821783 ^ -118980624;
            continue;
          case 3:
            num1 = (int) num3 * 611399138 ^ 333364686;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return strArray;
    }

    internal static SqlDataType GetDataType(string dataType)
    {
      string s = dataType;
      // ISSUE: reference to a compiler-generated method
      uint stringHash = \u003CPrivateImplementationDetails\u003E.ComputeStringHash(s);
label_1:
      int num1 = 1195300241;
      SqlDataType sqlDataType;
      while (true)
      {
        int num2 = 258166783;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 44U)
        {
          case 0:
            int num4;
            num1 = num4 = ZoomZoomDataTable.\u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮(s, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1450617291U)) ? 362351422 : (num4 = 456209433);
            continue;
          case 1:
            sqlDataType = SqlDataType.DATETIME;
            num1 = 427026657;
            continue;
          case 2:
            num1 = (int) num3 * -1985494885 ^ 499641577;
            continue;
          case 3:
            num1 = (int) num3 * -1513489505 ^ -1576703046;
            continue;
          case 4:
            int num5 = (int) stringHash == 249928074 ? -1343147511 : (num5 = -678136999);
            int num6 = (int) num3 * -735194183;
            num1 = num5 ^ num6;
            continue;
          case 5:
            sqlDataType = SqlDataType.BLOB;
            num1 = 1409009484;
            continue;
          case 6:
            num1 = (int) num3 * -1191729374 ^ 231065187;
            continue;
          case 7:
            sqlDataType = SqlDataType.BIGINT;
            num1 = 152907486;
            continue;
          case 8:
            goto label_1;
          case 9:
            int num7;
            num1 = num7 = (int) stringHash == -1927465947 ? 1113635372 : (num7 = 1197565263);
            continue;
          case 10:
            num1 = (int) num3 * -1427421162 ^ 192604283;
            continue;
          case 11:
            num1 = (int) num3 * -1928844524 ^ -1168847029;
            continue;
          case 12:
            sqlDataType = SqlDataType.CHAR255;
            num1 = 152907486;
            continue;
          case 13:
            int num8;
            num1 = num8 = stringHash > 2163098750U ? 1997664358 : (num8 = 1005333120);
            continue;
          case 14:
            num1 = (int) num3 * 915121581 ^ 1598094997;
            continue;
          case 15:
            num1 = (int) num3 * -1369284022 ^ 1785109793;
            continue;
          case 16:
            int num9;
            num1 = num9 = (int) stringHash == 1799337296 ? 169557628 : (num9 = 1733073673);
            continue;
          case 17:
            int num10;
            num1 = num10 = (int) stringHash == -2131868546 ? 280230579 : (num10 = 1754371546);
            continue;
          case 18:
            num1 = (int) num3 * 1090714651 ^ -19076067;
            continue;
          case 19:
            int num11 = (int) stringHash != 1985042424 ? -1378225078 : (num11 = -2039192714);
            int num12 = (int) num3 * -1352111902;
            num1 = num11 ^ num12;
            continue;
          case 20:
            num1 = (int) num3 * -1083101938 ^ 156359458;
            continue;
          case 21:
            sqlDataType = SqlDataType.AUTO;
            num1 = 1475658297;
            continue;
          case 22:
            num1 = (int) num3 * 779333490 ^ 1480872690;
            continue;
          case 23:
            int num13;
            num1 = num13 = ZoomZoomDataTable.\u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮(s, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1220110869U)) ? 87967390 : (num13 = 2010152573);
            continue;
          case 24:
            num1 = (int) num3 * 1808359038 ^ -2022924521;
            continue;
          case 26:
            num1 = (int) num3 * 1394146369 ^ 1788270656;
            continue;
          case 27:
            int num14;
            num1 = num14 = !ZoomZoomDataTable.\u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮(s, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2238111151U)) ? 1888624589 : (num14 = 555334614);
            continue;
          case 28:
            int num15;
            num1 = num15 = ZoomZoomDataTable.\u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮(s, \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(394892474U)) ? 615190359 : (num15 = 1663150913);
            continue;
          case 29:
            num1 = (int) num3 * -589869280 ^ -1172948225;
            continue;
          case 30:
            num1 = (int) num3 * 1859105428 ^ 763551343;
            continue;
          case 31:
            num1 = (int) num3 * -1032860024 ^ -330636314;
            continue;
          case 32:
            sqlDataType = SqlDataType.TEXT;
            num1 = 152907486;
            continue;
          case 33:
            sqlDataType = SqlDataType.INTEGER;
            num1 = 589852168;
            continue;
          case 34:
            int num16;
            num1 = num16 = !ZoomZoomDataTable.\u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮(s, \u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1443077037U)) ? 531633004 : (num16 = 1865603338);
            continue;
          case 35:
            int num17;
            num1 = num17 = !ZoomZoomDataTable.\u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮(s, \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3421025581U)) ? 2008488483 : (num17 = 2038083823);
            continue;
          case 36:
            int num18;
            num1 = num18 = (int) stringHash != 1299628970 ? 1151572496 : (num18 = 145839847);
            continue;
          case 37:
            int num19;
            num1 = num19 = (int) stringHash == -1822965296 ? 732909349 : (num19 = 1379612932);
            continue;
          case 38:
            int num20;
            num1 = num20 = !ZoomZoomDataTable.\u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮(s, \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(614497304U)) ? 1361409074 : (num20 = 1123512516);
            continue;
          case 39:
            num1 = (int) num3 * 2053677569 ^ -1328750483;
            continue;
          case 40:
            sqlDataType = SqlDataType.Unknown;
            num1 = 152907486;
            continue;
          case 41:
            num1 = (int) num3 * -1182488918 ^ 1790390653;
            continue;
          case 42:
            int num21 = stringHash <= 1799337296U ? -318537309 : (num21 = -1415687754);
            int num22 = (int) num3 * 164040640;
            num1 = num21 ^ num22;
            continue;
          case 43:
            num1 = (int) num3 * -35891610 ^ -1264514396;
            continue;
          default:
            goto label_45;
        }
      }
label_45:
      return sqlDataType;
    }

    internal static string GetDataType(SqlDataType dataType)
    {
      string str;
      int num1;
      switch (dataType)
      {
        case SqlDataType.Unknown:
label_9:
          throw ZoomZoomDataTable.\u202C​‮‌‍‮‪‪‬​⁭⁫‫⁯⁬‏‪‏‎⁯‫‏‌‎‪‮‬‭⁮⁯‌⁮⁫‏‮⁪‏‬‫⁯‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3782526822U));
        case SqlDataType.AUTO:
label_12:
          str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(171190487U);
          num1 = 18368886;
          break;
        case SqlDataType.INTEGER:
label_6:
          str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1379707347U);
          num1 = 815104526;
          break;
        case SqlDataType.BIGINT:
label_7:
          str = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3828514505U);
          num1 = 32667509;
          break;
        case SqlDataType.CHAR255:
label_3:
          str = \u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3038435673U);
          num1 = 1258035737;
          break;
        case SqlDataType.TEXT:
label_16:
          str = \u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3775176297U);
          num1 = 1212675912;
          break;
        case SqlDataType.BLOB:
label_11:
          str = \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4212829617U);
          num1 = 1358163431;
          break;
        case SqlDataType.DATETIME:
label_4:
          str = \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(2377260358U);
          num1 = 1828392321;
          break;
        default:
label_1:
          num1 = 1715928125;
          break;
      }
      while (true)
      {
        int num2 = 1602261324;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            num1 = (int) num3 * 2049032397 ^ -1944167015;
            continue;
          case 1:
            num1 = (int) num3 * 1348648484 ^ -568742275;
            continue;
          case 2:
            num1 = (int) num3 * -520814432 ^ 1027910358;
            continue;
          case 3:
            goto label_12;
          case 4:
            goto label_9;
          case 5:
            num1 = (int) num3 * 1745661978 ^ -376744674;
            continue;
          case 6:
            goto label_7;
          case 7:
            goto label_4;
          case 8:
            num1 = (int) num3 * -1822267421 ^ 557108657;
            continue;
          case 9:
            goto label_1;
          case 11:
            goto label_16;
          case 12:
            num1 = (int) num3 * 1179879903 ^ -914057859;
            continue;
          case 13:
            num1 = (int) num3 * 354840652 ^ 2036522734;
            continue;
          case 14:
            goto label_11;
          case 15:
            goto label_3;
          case 16:
            goto label_6;
          default:
            goto label_18;
        }
      }
label_18:
      return str;
    }

    internal string GetColumnValueFormatted(DataColumn column, Dictionary<string, object> data)
    {
label_1:
      int num1 = 1717070165;
      string str;
      SqlDataType dataType;
      while (true)
      {
        int num2 = 1846727194;
        uint num3;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        object obj;
        switch ((num3 = (uint) (num1 ^ num2)) % 29U)
        {
          case 0:
            goto label_28;
          case 1:
            int num4 = flag2 ? 2085764459 : (num4 = 1224043511);
            int num5 = (int) num3 * -1886520604;
            num1 = num4 ^ num5;
            continue;
          case 2:
          case 16:
label_29:
            num1 = 1391172161;
            continue;
          case 3:
            num1 = (int) num3 * 260135514 ^ -275763759;
            continue;
          case 4:
            num1 = (int) num3 * -1827233686 ^ -2082367108;
            continue;
          case 5:
            str = ZoomZoomDataTable.\u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4001632741U), (object) (int) data[ZoomZoomDataTable.\u202A‪‮‮‭​‭‬‭⁪‎⁮‬⁫‏​⁮⁮‪‫​‭⁫‍⁫‏‫⁫‭‭⁪‍⁪⁪‫‬⁭⁮‭‌‮(column)]);
            num1 = (int) num3 * 1571099864 ^ 522606320;
            continue;
          case 6:
            goto label_24;
          case 7:
            str = ZoomZoomDataTable.\u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1557563562U), obj);
            num1 = 1045434668;
            continue;
          case 8:
            str = ZoomZoomDataTable.\u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(469692563U), (object) ZoomZoomDatabase.FormatSQL((string) obj));
            num1 = (int) num3 * -752479474 ^ 666080086;
            continue;
          case 9:
            num1 = (int) num3 * -1380390856 ^ -771359888;
            continue;
          case 10:
            num1 = (int) num3 * -1441257196 ^ 2005423239;
            continue;
          case 11:
            num1 = (int) num3 * -1361091216 ^ 1695966260;
            continue;
          case 12:
            obj = data[ZoomZoomDataTable.\u202A‪‮‮‭​‭‬‭⁪‎⁮‬⁫‏​⁮⁮‪‫​‭⁫‍⁫‏‫⁫‭‭⁪‍⁪⁪‫‬⁭⁮‭‌‮(column)];
            switch (dataType)
            {
              case SqlDataType.Unknown:
                goto label_24;
              case SqlDataType.AUTO:
              case SqlDataType.INTEGER:
              case SqlDataType.BIGINT:
                goto label_14;
              case SqlDataType.CHAR255:
              case SqlDataType.TEXT:
              case SqlDataType.DATETIME:
                goto label_15;
              case SqlDataType.BLOB:
                goto label_29;
              default:
                num1 = (int) num3 * 1296535951 ^ -1972698215;
                continue;
            }
          case 14:
            int num6 = flag4 ? 591596126 : (num6 = 1535347897);
            int num7 = (int) num3 * -750866649;
            num1 = num6 ^ num7;
            continue;
          case 15:
            int num8 = !flag1 ? -1951666679 : (num8 = -1436433667);
            int num9 = (int) num3 * -955056550;
            num1 = num8 ^ num9;
            continue;
          case 17:
label_14:
            flag4 = obj is bool;
            num1 = 898233563;
            continue;
          case 18:
            goto label_1;
          case 19:
            num1 = (int) num3 * 1582819711 ^ -1782074961;
            continue;
          case 20:
            num1 = (int) num3 * 1061691658 ^ -578291928;
            continue;
          case 21:
            int num10 = !flag3 ? 1539384489 : (num10 = 475475846);
            int num11 = (int) num3 * -996491536;
            num1 = num10 ^ num11;
            continue;
          case 22:
            str = string.Empty;
            num1 = 240539808;
            continue;
          case 23:
            dataType = ZoomZoomDataTable.GetDataType(ZoomZoomDataTable.\u202B‍‌‬‭‭‏‬‌‫⁪‎‮⁯⁮‭‭‍⁬⁯‭‮‭⁮⁯‏⁯⁯⁯‪‮​‎‏‏⁬‎‏‭‍‮(ZoomZoomDataTable.\u200C‍⁭⁭‫‪⁭‪​‫⁪⁪⁪⁮‏‭‬‍​‫‏‪‪‎⁭⁮‎⁮‎‎⁬‫‏⁬‫‌‮‎⁫⁯‮((Hashtable) ZoomZoomDataTable.\u206F⁭⁭​‭‭‎⁬⁪​‫⁫‫‭‬​⁪⁫‍‎‬‏‫‏​‌⁬‍‫⁯‏⁮‍‫⁪‪⁪⁫‍‮(column), (object) \u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(4025150799U))));
            flag2 = data.ContainsKey(ZoomZoomDataTable.\u202A‪‮‮‭​‭‬‭⁪‎⁮‬⁫‏​⁮⁮‪‫​‭⁫‍⁫‏‫⁫‭‭⁪‍⁪⁪‫‬⁭⁮‭‌‮(column));
            num1 = (int) num3 * -1601320149 ^ 1482526083;
            continue;
          case 24:
            flag1 = obj is Enum;
            num1 = 218065196;
            continue;
          case 25:
label_15:
            flag3 = obj is string;
            num1 = 1578414419;
            continue;
          case 26:
            str = ZoomZoomDataTable.\u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(527282104U), data[ZoomZoomDataTable.\u202A‪‮‮‭​‭‬‭⁪‎⁮‬⁫‏​⁮⁮‪‫​‭⁫‍⁫‏‫⁫‭‭⁪‍⁪⁪‫‬⁭⁮‭‌‮(column)]);
            num1 = 53314796;
            continue;
          case 27:
            num1 = (int) num3 * -1791389274 ^ -543050879;
            continue;
          case 28:
            str = ZoomZoomDataTable.\u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3173821136U), (object) ((bool) data[ZoomZoomDataTable.\u202A‪‮‮‭​‭‬‭⁪‎⁮‬⁫‏​⁮⁮‪‫​‭⁫‍⁫‏‫⁫‭‭⁪‍⁪⁪‫‬⁭⁮‭‌‮(column)] ? 1 : 0));
            num1 = 1937135598;
            continue;
          default:
            goto label_30;
        }
      }
label_24:
      throw ZoomZoomDataTable.\u202C​‮‌‍‮‪‪‬​⁭⁫‫⁯⁬‏‪‏‎⁯‫‏‌‎‪‮‬‭⁮⁯‌⁮⁫‏‮⁪‏‬‫⁯‮(ZoomZoomDataTable.\u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(395284059U), (object) dataType));
label_28:
      throw ZoomZoomDataTable.\u202C​‮‌‍‮‪‪‬​⁭⁫‫⁯⁬‏‪‏‎⁯‫‏‌‎‪‮‬‭⁮⁯‌⁮⁫‏‮⁪‏‬‫⁯‮(ZoomZoomDataTable.\u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(168777208U), (object) ZoomZoomDataTable.\u202A‪‮‮‭​‭‬‭⁪‎⁮‬⁫‏​⁮⁮‪‫​‭⁫‍⁫‏‫⁫‭‭⁪‍⁪⁪‫‬⁭⁮‭‌‮(column)));
label_30:
      return str;
    }

    public static DateTime GetRowValue_DateTime(DataRow dr, string sFieldName)
    {
      DateTime dateTime1 = DateTime.MinValue;
      try
      {
label_2:
        int num1 = -108408717;
        while (true)
        {
          int num2 = -1089262284;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              dateTime1 = (DateTime) ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName);
              num1 = (int) num3 * -1544537472 ^ 555984443;
              continue;
            case 1:
              int num4 = flag ? 41771783 : (num4 = 38052355);
              int num5 = (int) num3 * 1680334035;
              num1 = num4 ^ num5;
              continue;
            case 3:
              num1 = (int) num3 * 1900423008 ^ 1441269272;
              continue;
            case 4:
              goto label_2;
            case 5:
              flag = ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName) != null;
              num1 = (int) num3 * -928820895 ^ 1430899370;
              continue;
            default:
              goto label_13;
          }
        }
      }
      catch (Exception ex)
      {
label_9:
        int num1 = -922571827;
        while (true)
        {
          int num2 = -1089262284;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_9;
            case 1:
              ZoomZoomDataTable.\u202E‮‭⁫‫⁫‭⁭‍​‮‭‌‭‏‫⁫​⁫‭⁬‍⁯‍‏‪‎‫‮‍⁮⁪⁫⁯​‬‌​‏‮‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1179507887 ^ 912438938;
              continue;
            case 3:
              num1 = (int) num3 * 1522312353 ^ 1622699809;
              continue;
            default:
              goto label_13;
          }
        }
      }
label_13:
      DateTime dateTime2 = dateTime1;
label_14:
      int num6 = -1077864685;
      while (true)
      {
        int num1 = -1089262284;
        uint num2;
        switch ((num2 = (uint) (num6 ^ num1)) % 3U)
        {
          case 1:
            num6 = (int) num2 * -1832762124 ^ 2049528517;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_17;
        }
      }
label_17:
      return dateTime2;
    }

    public static bool GetRowValue_Boolean(DataRow dr, string sFieldName)
    {
      bool flag1 = false;
      try
      {
label_2:
        int num1 = -1811085254;
        while (true)
        {
          int num2 = -332208008;
          uint num3;
          bool flag2;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              goto label_2;
            case 1:
              num1 = (int) num3 * -329264641 ^ 912183484;
              continue;
            case 2:
              if (ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName) == null)
              {
                num4 = 0;
                break;
              }
              num1 = (int) num3 * 922679993 ^ 1786499972;
              continue;
            case 4:
              flag1 = true;
              num1 = (int) num3 * 892048755 ^ -1397608131;
              continue;
            case 5:
              int num5 = flag2 ? -350832501 : (num5 = -1719561673);
              int num6 = (int) num3 * 133648764;
              num1 = num5 ^ num6;
              continue;
            case 6:
              num4 = (bool) ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName) ? 1 : 0;
              break;
            case 7:
              num1 = (int) num3 * 2123808894 ^ 465962094;
              continue;
            default:
              goto label_14;
          }
          flag2 = num4 != 0;
          num1 = -1213022699;
        }
      }
      catch (Exception ex)
      {
        ZoomZoomDataTable.\u202E‮‭⁫‫⁫‭⁭‍​‮‭‌‭‏‫⁫​⁫‭⁬‍⁯‍‏‪‎‫‮‍⁮⁪⁫⁯​‬‌​‏‮‮(CoreObject.log, (object) ex);
      }
label_14:
      bool flag3 = flag1;
label_15:
      int num7 = -1036380506;
      while (true)
      {
        int num1 = -332208008;
        uint num2;
        switch ((num2 = (uint) (num7 ^ num1)) % 3U)
        {
          case 0:
            goto label_15;
          case 2:
            num7 = (int) num2 * -1905600124 ^ -460606289;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return flag3;
    }

    public static int GetRowValue_Integer(DataRow dr, string sFieldName)
    {
      int num1 = 0;
      try
      {
label_2:
        int num2 = 945255167;
        while (true)
        {
          int num3 = 426742036;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 4U)
          {
            case 0:
              num1 = ZoomZoomDataTable.\u206C‪​‫‬⁮⁬‏⁭⁬​‍⁬‏‮⁬⁪‬‬‭⁯⁫‎‪‎⁯‌⁯​‎‮‬‬‫‎‪‫‍‌‮‮(ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName));
              num2 = (int) num4 * -882284328 ^ 661947253;
              continue;
            case 2:
              goto label_2;
            case 3:
              int num5 = ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName) != null ? -618227584 : (num5 = -2114674407);
              int num6 = (int) num4 * 1863343236;
              num2 = num5 ^ num6;
              continue;
            default:
              goto label_12;
          }
        }
      }
      catch (Exception ex)
      {
label_7:
        int num2 = 1259774122;
        while (true)
        {
          int num3 = 426742036;
          uint num4;
          switch ((num4 = (uint) (num2 ^ num3)) % 5U)
          {
            case 0:
              goto label_7;
            case 2:
              num2 = (int) num4 * -1996899885 ^ -613287969;
              continue;
            case 3:
              num2 = (int) num4 * 2132982137 ^ -618736338;
              continue;
            case 4:
              ZoomZoomDataTable.\u202E‮‭⁫‫⁫‭⁭‍​‮‭‌‭‏‫⁫​⁫‭⁬‍⁯‍‏‪‎‫‮‍⁮⁪⁫⁯​‬‌​‏‮‮(CoreObject.log, (object) ex);
              num2 = (int) num4 * 1924317 ^ -550251894;
              continue;
            default:
              goto label_12;
          }
        }
      }
label_12:
      int num7 = num1;
label_13:
      int num8 = 344473649;
      while (true)
      {
        int num2 = 426742036;
        uint num3;
        switch ((num3 = (uint) (num8 ^ num2)) % 3U)
        {
          case 1:
            num8 = (int) num3 * 823702629 ^ 611247968;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_16;
        }
      }
label_16:
      return num7;
    }

    public static string GetRowValue_String(DataRow dr, string sFieldName)
    {
      string str1 = string.Empty;
      try
      {
        if (ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName) != null)
        {
label_2:
          int num1 = 794256650;
          while (true)
          {
            int num2 = 291359415;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 1:
                num1 = (int) num3 * -651921284 ^ -1126948900;
                continue;
              case 2:
                num1 = (int) num3 * -1254153014 ^ -1257443038;
                continue;
              case 3:
                str1 = ZoomZoomDataTable.\u202B‍‌‬‭‭‏‬‌‫⁪‎‮⁯⁮‭‭‍⁬⁯‭‮‭⁮⁯‏⁯⁯⁯‪‮​‎‏‏⁬‎‏‭‍‮(ZoomZoomDataTable.\u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮(dr, sFieldName));
                num1 = (int) num3 * -921554051 ^ 1730042466;
                continue;
              case 4:
                goto label_2;
              default:
                goto label_12;
            }
          }
        }
      }
      catch (Exception ex)
      {
label_8:
        int num1 = 2122985560;
        while (true)
        {
          int num2 = 291359415;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * 1812925191 ^ -911272766;
              continue;
            case 2:
              goto label_8;
            case 3:
              ZoomZoomDataTable.\u202E‮‭⁫‫⁫‭⁭‍​‮‭‌‭‏‫⁫​⁫‭⁬‍⁯‍‏‪‎‫‮‍⁮⁪⁫⁯​‬‌​‏‮‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * -1447844432 ^ 1659775043;
              continue;
            default:
              goto label_12;
          }
        }
      }
label_12:
      string str2 = str1;
label_13:
      int num4 = 2142618158;
      while (true)
      {
        int num1 = 291359415;
        uint num2;
        switch ((num2 = (uint) (num4 ^ num1)) % 3U)
        {
          case 0:
            goto label_13;
          case 2:
            num4 = (int) num2 * -149762213 ^ 82134892;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return str2;
    }

    static DataTable \u202E‭‌‌⁫‪‏⁪‎‫‮⁫‫‫‭⁪‪⁪‮⁯⁭⁮‎‪‏‎‏‭⁯‮‪​‎‪‫‏‭⁯‎⁬‮([In] string obj0)
    {
      return new DataTable(obj0);
    }

    static DataRow \u202B​‬⁭‌‏⁬‫‭‬⁪‍‬‌‬‬⁫⁭⁬‬⁭‍‌⁫​‫‬‫⁪​‍⁯‬‪⁭⁬‏⁫‮‍‮([In] DataTable obj0)
    {
      return obj0.NewRow();
    }

    static DataRowCollection \u206B⁯‍⁫⁫‪‪‭‪‮⁫‬⁭‎‬‬⁮​‪⁯⁮‫‎‫‏⁪⁭‭⁪⁮⁫⁫‪‎‮‎‎⁯‏‭‮([In] DataTable obj0)
    {
      return obj0.Rows;
    }

    static void \u202E‮‍‮‫‏‏⁪⁪‎‬‭‭‫‬⁬‫‬‪⁭‬⁮‫⁫‎⁬​⁪‌⁯⁯⁬⁪‌‬‬‮⁫⁮⁪‮([In] DataRowCollection obj0, [In] DataRow obj1)
    {
      obj0.Add(obj1);
    }

    static DataColumn \u206D‏⁫⁮‫⁯‮‪⁬⁬⁯​‌‏​‬‏‮⁬⁬‭‬‌‬⁫⁭‌⁫⁮‫⁭⁬‫‍⁪⁮⁫‍‏⁭‮()
    {
      return new DataColumn();
    }

    static Type \u200E‍⁮‬⁬⁯​‭‮‎‫⁪⁮⁯​‏​​‌⁮‬‎⁯‌‏⁪⁬‭‪‭‎‏‎‌⁭‍‍‫‫‍‮([In] string obj0)
    {
      return Type.GetType(obj0);
    }

    static void \u206D‏⁫‏‏‍‬‫⁮‏​⁬⁫‭⁪⁫⁪‏⁭‬⁬‎⁮‭‍⁭‍‪‪‮‍‪‮‌⁮‫​‮‮⁪‮([In] DataColumn obj0, [In] Type obj1)
    {
      obj0.DataType = obj1;
    }

    static void \u200F⁪‎‌‍⁮‪⁫‬⁪‫‮⁪⁬⁫⁮‍⁫‌‪‍⁭‏‏‏‌⁮⁮⁭‎⁮‌‏‬‭⁬‮‮‭‫‮([In] DataColumn obj0, [In] string obj1)
    {
      obj0.ColumnName = obj1;
    }

    static void \u200C‮⁪⁬‮⁯⁭⁫‍​‪⁭⁫‭⁮‫⁯‮‫‫​‏‭‭‭‎‪‮‏‮⁬⁫‍‌‌‬‭‬⁭‭‮([In] DataColumn obj0, [In] bool obj1)
    {
      obj0.AutoIncrement = obj1;
    }

    static void \u206F⁬⁯⁬‫‪⁭‍‭‬⁪⁭‮‬⁮‪‭⁬‭​‏⁪‬‮‪​‍​⁪⁪‌‍‏‌⁪⁮⁫‫‍‬‮([In] DataColumn obj0, [In] string obj1)
    {
      obj0.Caption = obj1;
    }

    static void \u206A‬‌‎‏‎⁭‫⁯‪‭​⁪⁬​‬⁫⁫⁫‏‏​‮‭⁯​‌⁪‮​⁫‏​‫‬​‏‬‬‏‮([In] DataColumn obj0, [In] bool obj1)
    {
      obj0.ReadOnly = obj1;
    }

    static void \u206B⁯‏⁪⁬‬‮⁮⁭⁯⁯‮⁫‪‪‬​‫‮⁯⁭⁮⁬⁯‏⁭⁭⁪‪⁬‍‮⁪⁫⁪‌‮‌‪‭‮([In] DataColumn obj0, [In] bool obj1)
    {
      obj0.Unique = obj1;
    }

    static bool \u200B‬⁭‭⁯‎‮‪​⁭⁭‪⁯‫‍⁪⁫⁫‎‫‪‎​⁬‭⁮⁮⁬⁮‍⁯‬‍​⁪‮⁪‏‫‮‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static PropertyCollection \u206F⁭⁭​‭‭‎⁬⁪​‫⁫‫‭‬​⁪⁫‍‎‬‏‫‏​‌⁬‍‫⁯‏⁮‍‫⁪‪⁪⁫‍‮([In] DataColumn obj0)
    {
      return obj0.ExtendedProperties;
    }

    static void \u200D⁬‬‪‍‫​​‏‬⁬‌⁯⁫‏⁮⁬‏⁮⁯‏‍⁯‭⁮​⁬⁯⁯‎‎‍‫⁯‭‍⁬‭⁯⁬‮([In] Hashtable obj0, [In] object obj1, [In] object obj2)
    {
      obj0.Add(obj1, obj2);
    }

    static DataColumnCollection \u200D⁭​‎‏‫‍⁭​‎⁪​‏​⁬⁬⁭⁯‪⁮⁮‌‬‌‪‫⁬‮‫⁭⁯⁬​‭⁫⁪⁮‌‏⁪‮([In] DataTable obj0)
    {
      return obj0.Columns;
    }

    static void \u200B⁫‍⁮‪‏‏⁫⁪⁫⁯‪‭‫⁬⁮‮‍‬‏‎⁬‎‏‪⁪​​‏‬​​‌​⁫‫‪⁪⁭‭‮([In] DataColumnCollection obj0, [In] DataColumn obj1)
    {
      obj0.Add(obj1);
    }

    static bool \u206A​‫⁭‫⁬⁭⁬‬‬​‮‪‌⁬‎‎‎⁪⁮‬⁭⁯‫⁭⁫‪‪⁫⁮‎‫‮‭‍⁮‎‌‮‍‮([In] string obj0, [In] string obj1)
    {
      return obj0 == obj1;
    }

    static Exception \u202C​‮‌‍‮‪‪‬​⁭⁫‫⁯⁬‏‪‏‎⁯‫‏‌‎‪‮‬‭⁮⁯‌⁮⁫‏‮⁪‏‬‫⁯‮([In] string obj0)
    {
      return new Exception(obj0);
    }

    static object \u200C‍⁭⁭‫‪⁭‪​‫⁪⁪⁪⁮‏‭‬‍​‫‏‪‪‎⁭⁮‎⁮‎‎⁬‫‏⁬‫‌‮‎⁫⁯‮([In] Hashtable obj0, [In] object obj1)
    {
      return obj0[obj1];
    }

    static string \u202B‍‌‬‭‭‏‬‌‫⁪‎‮⁯⁮‭‭‍⁬⁯‭‮‭⁮⁯‏⁯⁯⁯‪‮​‎‏‏⁬‎‏‭‍‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static string \u202A‪‮‮‭​‭‬‭⁪‎⁮‬⁫‏​⁮⁮‪‫​‭⁫‍⁫‏‫⁫‭‭⁪‍⁪⁪‫‬⁭⁮‭‌‮([In] DataColumn obj0)
    {
      return obj0.ColumnName;
    }

    static string \u200C‮⁯⁪‬‎‏⁬‪⁫‪⁫⁬⁬‬⁮‮‮‎‮⁯⁬⁮⁯⁬‪‪⁫‍⁫⁮‌⁯⁭‬‏‎⁯⁯⁯‮([In] string obj0, [In] object obj1)
    {
      return string.Format(obj0, obj1);
    }

    static object \u200C‬‏⁭‬⁪‍⁬‎‌⁭⁭⁭⁯⁮⁭‬⁫⁯⁯​⁭‍‌‏⁬‫‭‏⁪‎⁬‏⁬⁯⁭‮⁮‫⁮‮([In] DataRow obj0, [In] string obj1)
    {
      return obj0[obj1];
    }

    static void \u202E‮‭⁫‫⁫‭⁭‍​‮‭‌‭‏‫⁫​⁫‭⁬‍⁯‍‏‪‎‫‮‍⁮⁪⁫⁯​‬‌​‏‮‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }

    static int \u206C‪​‫‬⁮⁬‏⁭⁬​‍⁬‏‮⁬⁪‬‬‭⁯⁫‎‪‎⁯‌⁯​‎‮‬‬‫‎‪‫‍‌‮‮([In] object obj0)
    {
      return Convert.ToInt32(obj0);
    }
  }
}
