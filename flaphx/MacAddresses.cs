// Decompiled with JetBrains decompiler
// Type: flaphx.MacAddresses
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace flaphx
{
  public static class MacAddresses
  {
    private static bool RelevantNicType(NetworkInterface nic)
    {
label_1:
      int num1 = -1829876245;
      bool flag;
      while (true)
      {
        int num2 = -1466663880;
        uint num3;
        NetworkInterfaceType networkInterfaceType;
        switch ((num3 = (uint) (num1 ^ num2)) % 52U)
        {
          case 0:
            int num4;
            num1 = num4 = networkInterfaceType == NetworkInterfaceType.Ethernet ? -525660754 : (num4 = -787012300);
            continue;
          case 1:
            num1 = (int) num3 * 2083592200 ^ 1153948934;
            continue;
          case 2:
            num1 = (int) num3 * 1907021230 ^ 165136656;
            continue;
          case 3:
            int num5 = networkInterfaceType == NetworkInterfaceType.MultiRateSymmetricDsl ? 2141829554 : (num5 = 962944440);
            int num6 = (int) num3 * 719272228;
            num1 = num5 ^ num6;
            continue;
          case 4:
            num1 = (int) num3 * 439876685 ^ -877450462;
            continue;
          case 5:
            int num7;
            num1 = num7 = networkInterfaceType != NetworkInterfaceType.IPOverAtm ? -519801942 : (num7 = -525660754);
            continue;
          case 6:
            num1 = (int) num3 * -614631915 ^ 1717039139;
            continue;
          case 7:
            num1 = (int) num3 * 1864909091 ^ -2111361116;
            continue;
          case 8:
            int num8 = networkInterfaceType <= NetworkInterfaceType.VeryHighSpeedDsl ? -846642123 : (num8 = -1735160015);
            int num9 = (int) num3 * 824383009;
            num1 = num8 ^ num9;
            continue;
          case 9:
            int num10 = networkInterfaceType == NetworkInterfaceType.Unknown ? 2037227071 : (num10 = 591876273);
            int num11 = (int) num3 * 1383040119;
            num1 = num10 ^ num11;
            continue;
          case 10:
            num1 = (int) num3 * 1684496758 ^ 567665720;
            continue;
          case 11:
            num1 = (int) num3 * -764902331 ^ 1602408257;
            continue;
          case 12:
            goto label_1;
          case 13:
            int num12;
            num1 = num12 = networkInterfaceType == NetworkInterfaceType.FastEthernetFx ? -525660754 : (num12 = -1704845186);
            continue;
          case 14:
            num1 = (int) num3 * 260498014 ^ 5603975;
            continue;
          case 15:
            int num13 = networkInterfaceType != NetworkInterfaceType.Atm ? 2141814281 : (num13 = 1907835488);
            int num14 = (int) num3 * 1085652626;
            num1 = num13 ^ num14;
            continue;
          case 16:
            int num15;
            num1 = num15 = networkInterfaceType == NetworkInterfaceType.Fddi ? -525660754 : (num15 = -1332305974);
            continue;
          case 17:
            num1 = (int) num3 * -119294551 ^ 529766223;
            continue;
          case 18:
            int num16 = networkInterfaceType <= NetworkInterfaceType.Ethernet ? 334835395 : (num16 = 1929842963);
            int num17 = (int) num3 * -753983741;
            num1 = num16 ^ num17;
            continue;
          case 19:
            num1 = (int) num3 * -1355823414 ^ 150111016;
            continue;
          case 20:
            int num18;
            num1 = num18 = networkInterfaceType <= NetworkInterfaceType.Tunnel ? -1869854472 : (num18 = -540663936);
            continue;
          case 21:
            int num19;
            num1 = num19 = networkInterfaceType != NetworkInterfaceType.GigabitEthernet ? -1115587440 : (num19 = -525660754);
            continue;
          case 22:
            num1 = (int) num3 * -985271088 ^ 340835662;
            continue;
          case 23:
            networkInterfaceType = MacAddresses.\u200E⁪‬​⁬​⁫‫‮‫⁮⁫⁮⁫‭‪‌‏⁮‬⁮⁪‭‭‫‬⁭‎⁯⁫⁮‫⁬⁬‏⁮⁪‫‎⁮‮(nic);
            int num20 = networkInterfaceType <= NetworkInterfaceType.FastEthernetFx ? 1040242079 : (num20 = 112299597);
            int num21 = (int) num3 * -1581286857;
            num1 = num20 ^ num21;
            continue;
          case 24:
            num1 = (int) num3 * -1415983825 ^ 904878813;
            continue;
          case 25:
            num1 = (int) num3 * -1633585118 ^ 178956065;
            continue;
          case 26:
            num1 = (int) num3 * 883703160 ^ -1070401314;
            continue;
          case 27:
            num1 = (int) num3 * 690724437 ^ -1322411205;
            continue;
          case 28:
label_22:
            flag = false;
            num1 = -2057468701;
            continue;
          case 29:
            int num22 = networkInterfaceType != NetworkInterfaceType.Wireless80211 ? 1367612503 : (num22 = 325830759);
            int num23 = (int) num3 * 348992749;
            num1 = num22 ^ num23;
            continue;
          case 30:
            num1 = (int) num3 * 282111507 ^ -1867395317;
            continue;
          case 32:
            int num24;
            num1 = num24 = networkInterfaceType == (NetworkInterfaceType) 237 ? -525660754 : (num24 = -1814263360);
            continue;
          case 33:
            int num25;
            num1 = num25 = networkInterfaceType == (NetworkInterfaceType) 243 ? -525660754 : (num25 = -1719278689);
            continue;
          case 34:
            int num26;
            num1 = num26 = networkInterfaceType != NetworkInterfaceType.HighPerformanceSerialBus ? -60034149 : (num26 = -525660754);
            continue;
          case 35:
            int num27;
            num1 = num27 = networkInterfaceType == NetworkInterfaceType.Tunnel ? -1301523332 : (num27 = -1574816374);
            continue;
          case 36:
            int num28;
            num1 = num28 = networkInterfaceType <= NetworkInterfaceType.HighPerformanceSerialBus ? -821191433 : (num28 = -1420057688);
            continue;
          case 37:
            int num29;
            num1 = num29 = networkInterfaceType == NetworkInterfaceType.GenericModem ? -525660754 : (num29 = -1452292307);
            continue;
          case 38:
            int num30;
            num1 = num30 = networkInterfaceType == NetworkInterfaceType.FastEthernetT ? -525660754 : (num30 = -1750395806);
            continue;
          case 39:
            int num31;
            num1 = num31 = networkInterfaceType != (NetworkInterfaceType) 244 ? -647535169 : (num31 = -525660754);
            continue;
          case 40:
            num1 = (int) num3 * 753133992 ^ -1354148274;
            continue;
          case 41:
            int num32;
            num1 = num32 = networkInterfaceType != NetworkInterfaceType.Isdn ? -267241073 : (num32 = -525660754);
            continue;
          case 42:
            int num33 = networkInterfaceType > NetworkInterfaceType.Slip ? -1020623040 : (num33 = -819406264);
            int num34 = (int) num3 * -658726035;
            num1 = num33 ^ num34;
            continue;
          case 43:
            switch (networkInterfaceType)
            {
              case NetworkInterfaceType.BasicIsdn:
              case NetworkInterfaceType.PrimaryIsdn:
              case (NetworkInterfaceType) 22:
              case NetworkInterfaceType.Loopback:
              case (NetworkInterfaceType) 25:
              case NetworkInterfaceType.Ethernet3Megabit:
              case NetworkInterfaceType.Ethernet3Megabit | NetworkInterfaceType.Unknown:
                goto label_12;
              case NetworkInterfaceType.Ppp:
              case NetworkInterfaceType.Slip:
                goto label_22;
              default:
                num1 = -1440681407;
                continue;
            }
          case 44:
            num1 = (int) num3 * 1108843207 ^ -1581551645;
            continue;
          case 45:
            num1 = (int) num3 * 743560332 ^ 157522530;
            continue;
          case 46:
            int num35;
            num1 = num35 = networkInterfaceType > NetworkInterfaceType.GenericModem ? -1043558142 : (num35 = -900324969);
            continue;
          case 47:
            num1 = (int) num3 * 1568785431 ^ -1454605626;
            continue;
          case 48:
            switch (networkInterfaceType)
            {
              case NetworkInterfaceType.AsymmetricDsl:
              case NetworkInterfaceType.RateAdaptDsl:
              case NetworkInterfaceType.SymmetricDsl:
              case NetworkInterfaceType.VeryHighSpeedDsl:
                goto label_12;
              default:
                num1 = -1188373303;
                continue;
            }
          case 49:
            int num36;
            num1 = num36 = networkInterfaceType == NetworkInterfaceType.TokenRing ? -525660754 : (num36 = -1098779993);
            continue;
          case 50:
label_12:
            flag = true;
            num1 = -988941079;
            continue;
          case 51:
            num1 = (int) num3 * -1358936924 ^ -1943504803;
            continue;
          default:
            goto label_55;
        }
      }
label_55:
      return flag;
    }

    public static List<string> GetMacAddresses()
    {
label_1:
      int num1 = -2009887707;
      List<string> stringList1;
      while (true)
      {
        int num2 = -1616000224;
        uint num3;
        List<string> stringList2;
        int index;
        string str;
        bool flag;
        NetworkInterface[] networkInterfaceArray;
        NetworkInterface networkInterface;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 0:
            str = MacAddresses.\u202A‭‏‌⁪‎‬‫‭‭‌⁭⁮‪‍‌‍‭‌⁪‌‫‫‫⁯‪‏⁪‏⁪‍⁮‭⁪⁪‏⁭⁯‫‭‮((object) MacAddresses.\u202E‏‫⁪‌‫‭‫⁭‮⁭‌‍‫⁭‬​‪‪‍⁮⁪‎‏‌‌‪‮‬⁭‍⁪‫‭‭⁪⁫⁯‮(networkInterface));
            if (MacAddresses.\u200F‬‍‍‍⁮‌‫‮⁪​‮‎‭​⁫⁫⁬⁭‪‎‎‪​‍⁬​‮‭‮⁮‌‎‫‌‮⁫⁬‮⁯‮(str, string.Empty))
            {
              num4 = 0;
              break;
            }
            num1 = (int) num3 * -1864754869 ^ -738553788;
            continue;
          case 1:
            int num5 = flag ? -858044882 : (num5 = -273610409);
            int num6 = (int) num3 * 697410915;
            num1 = num5 ^ num6;
            continue;
          case 2:
            num1 = (int) num3 * -1275016331 ^ 368554107;
            continue;
          case 3:
            num1 = -25697062;
            continue;
          case 4:
            networkInterface = networkInterfaceArray[index];
            num1 = -1419223516;
            continue;
          case 5:
            num1 = (int) num3 * 580700709 ^ 1183741477;
            continue;
          case 6:
            num4 = !stringList2.Contains(str) ? 1 : 0;
            break;
          case 7:
            stringList2.Add(str);
            num1 = (int) num3 * -1979897827 ^ 1207802454;
            continue;
          case 8:
            index = 0;
            num1 = (int) num3 * 416406743 ^ 514920120;
            continue;
          case 9:
            num1 = (int) num3 * 442524922 ^ 1899979479;
            continue;
          case 10:
            ++index;
            num1 = -646427321;
            continue;
          case 11:
            num1 = (int) num3 * -193426619 ^ -708847360;
            continue;
          case 13:
            goto label_1;
          case 14:
            int num7;
            num1 = num7 = index < networkInterfaceArray.Length ? -1718276239 : (num7 = -1562158317);
            continue;
          case 15:
            int num8 = MacAddresses.\u200F‌‮‫‬⁭​‬‪⁭‎⁪⁪⁯⁭‏⁪‫⁪‮‍‬‮⁭​‌⁫⁯​⁮​‬⁭⁪⁫‎​‮⁭‬‮(networkInterface) == OperationalStatus.Up ? -454992004 : (num8 = -728615242);
            int num9 = (int) num3 * -931899685;
            num1 = num8 ^ num9;
            continue;
          case 16:
            networkInterfaceArray = MacAddresses.\u200F‏⁯​‎‮‎‍‪⁮‬⁪​‌‏⁮⁫‮​‪⁪​⁫‫‏‌⁬⁫⁫‏‬⁭⁫​‪‎⁫⁫‮⁯‮();
            num1 = (int) num3 * -1798317879 ^ -415378106;
            continue;
          case 17:
            stringList2.Remove(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(1888074853U));
            stringList1 = stringList2;
            num1 = (int) num3 * 789911393 ^ -191705312;
            continue;
          case 18:
            stringList2 = new List<string>();
            num1 = (int) num3 * -108531590 ^ 1931577829;
            continue;
          default:
            goto label_23;
        }
        flag = num4 != 0;
        num1 = -1256761312;
      }
label_23:
      return stringList1;
    }

    static NetworkInterfaceType \u200E⁪‬​⁬​⁫‫‮‫⁮⁫⁮⁫‭‪‌‏⁮‬⁮⁪‭‭‫‬⁭‎⁯⁫⁮‫⁬⁬‏⁮⁪‫‎⁮‮([In] NetworkInterface obj0)
    {
      return obj0.NetworkInterfaceType;
    }

    static NetworkInterface[] \u200F‏⁯​‎‮‎‍‪⁮‬⁪​‌‏⁮⁫‮​‪⁪​⁫‫‏‌⁬⁫⁫‏‬⁭⁫​‪‎⁫⁫‮⁯‮()
    {
      return NetworkInterface.GetAllNetworkInterfaces();
    }

    static OperationalStatus \u200F‌‮‫‬⁭​‬‪⁭‎⁪⁪⁯⁭‏⁪‫⁪‮‍‬‮⁭​‌⁫⁯​⁮​‬⁭⁪⁫‎​‮⁭‬‮([In] NetworkInterface obj0)
    {
      return obj0.OperationalStatus;
    }

    static PhysicalAddress \u202E‏‫⁪‌‫‭‫⁭‮⁭‌‍‫⁭‬​‪‪‍⁮⁪‎‏‌‌‪‮‬⁭‍⁪‫‭‭⁪⁫⁯‮([In] NetworkInterface obj0)
    {
      return obj0.GetPhysicalAddress();
    }

    static string \u202A‭‏‌⁪‎‬‫‭‭‌⁭⁮‪‍‌‍‭‌⁪‌‫‫‫⁯‪‏⁪‏⁪‍⁮‭⁪⁪‏⁭⁯‫‭‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static bool \u200F‬‍‍‍⁮‌‫‮⁪​‮‎‭​⁫⁫⁬⁭‪‎‎‪​‍⁬​‮‭‮⁮‌‎‫‌‮⁫⁬‮⁯‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }
  }
}
