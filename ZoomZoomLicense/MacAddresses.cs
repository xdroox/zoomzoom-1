// Decompiled with JetBrains decompiler
// Type: ZoomZoomLicense.MacAddresses
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace ZoomZoomLicense
{
  public static class MacAddresses
  {
    private static bool RelevantNicType(NetworkInterface nic)
    {
label_1:
      int num1 = -1697867596;
      bool flag;
      while (true)
      {
        int num2 = -1751522714;
        uint num3;
        NetworkInterfaceType networkInterfaceType;
        switch ((num3 = (uint) (num1 ^ num2)) % 53U)
        {
          case 0:
            int num4;
            num1 = num4 = networkInterfaceType != NetworkInterfaceType.FastEthernetT ? -2077654011 : (num4 = -1098331989);
            continue;
          case 1:
            int num5;
            num1 = num5 = networkInterfaceType == (NetworkInterfaceType) 237 ? -1098331989 : (num5 = -372830936);
            continue;
          case 2:
            num1 = (int) num3 * -1449360549 ^ -71196170;
            continue;
          case 3:
            switch (networkInterfaceType)
            {
              case NetworkInterfaceType.BasicIsdn:
              case NetworkInterfaceType.PrimaryIsdn:
              case (NetworkInterfaceType) 22:
              case NetworkInterfaceType.Loopback:
              case (NetworkInterfaceType) 25:
              case NetworkInterfaceType.Ethernet3Megabit:
              case NetworkInterfaceType.Ethernet3Megabit | NetworkInterfaceType.Unknown:
                goto label_28;
              case NetworkInterfaceType.Ppp:
              case NetworkInterfaceType.Slip:
                goto label_31;
              default:
                num1 = -1791977023;
                continue;
            }
          case 4:
            int num6 = networkInterfaceType == NetworkInterfaceType.Unknown ? 747513816 : (num6 = 1413091498);
            int num7 = (int) num3 * 364931614;
            num1 = num6 ^ num7;
            continue;
          case 5:
            num1 = (int) num3 * 678834727 ^ 379449289;
            continue;
          case 6:
            num1 = (int) num3 * 1399996029 ^ -539145185;
            continue;
          case 7:
            num1 = (int) num3 * -1392433555 ^ 129821878;
            continue;
          case 8:
            int num8 = networkInterfaceType > NetworkInterfaceType.Slip ? 755548839 : (num8 = 794831677);
            int num9 = (int) num3 * 424162188;
            num1 = num8 ^ num9;
            continue;
          case 9:
            int num10;
            num1 = num10 = networkInterfaceType == NetworkInterfaceType.Fddi ? -1098331989 : (num10 = -311908925);
            continue;
          case 10:
            num1 = (int) num3 * -1119066697 ^ -1089115906;
            continue;
          case 11:
            num1 = (int) num3 * 1176591718 ^ -1482559380;
            continue;
          case 12:
            int num11 = networkInterfaceType != NetworkInterfaceType.Atm ? 1358069466 : (num11 = 299691635);
            int num12 = (int) num3 * 1028679332;
            num1 = num11 ^ num12;
            continue;
          case 13:
            num1 = (int) num3 * -879945161 ^ 7437247;
            continue;
          case 14:
            num1 = (int) num3 * -369100561 ^ 905069164;
            continue;
          case 15:
            num1 = (int) num3 * -250046269 ^ 788757296;
            continue;
          case 16:
            num1 = (int) num3 * -1007918000 ^ -1330191210;
            continue;
          case 17:
            int num13;
            num1 = num13 = networkInterfaceType != (NetworkInterfaceType) 244 ? -2088751799 : (num13 = -1098331989);
            continue;
          case 18:
            networkInterfaceType = MacAddresses.\u202B‏‎⁭⁭‫‎‏‭‍‌‌‌⁫‬‌⁪⁪‍‮⁫⁮‮‮‬⁪⁫‎​⁮⁯‭‮‍‏​⁮‭⁫‭‮(nic);
            num1 = (int) num3 * -680310464 ^ -736795907;
            continue;
          case 19:
            int num14;
            num1 = num14 = networkInterfaceType != NetworkInterfaceType.HighPerformanceSerialBus ? -305708350 : (num14 = -1098331989);
            continue;
          case 20:
            switch (networkInterfaceType)
            {
              case NetworkInterfaceType.AsymmetricDsl:
              case NetworkInterfaceType.RateAdaptDsl:
              case NetworkInterfaceType.SymmetricDsl:
              case NetworkInterfaceType.VeryHighSpeedDsl:
                goto label_28;
              default:
                num1 = -1304692273;
                continue;
            }
          case 21:
            int num15;
            num1 = num15 = networkInterfaceType != NetworkInterfaceType.GenericModem ? -800865546 : (num15 = -1098331989);
            continue;
          case 22:
            num1 = (int) num3 * -644477871 ^ -399425066;
            continue;
          case 23:
            int num16;
            num1 = num16 = networkInterfaceType == NetworkInterfaceType.IPOverAtm ? -1098331989 : (num16 = -242040484);
            continue;
          case 24:
            num1 = (int) num3 * -2040999836 ^ 1804688996;
            continue;
          case 25:
            int num17;
            num1 = num17 = networkInterfaceType == NetworkInterfaceType.Ethernet ? -1098331989 : (num17 = -1496640606);
            continue;
          case 26:
            int num18;
            num1 = num18 = networkInterfaceType == NetworkInterfaceType.Tunnel ? -1389865790 : (num18 = -193070220);
            continue;
          case 27:
            num1 = (int) num3 * 527236960 ^ 2015842603;
            continue;
          case 28:
            num1 = (int) num3 * 1295423139 ^ 1206609861;
            continue;
          case 29:
            num1 = (int) num3 * -1432709689 ^ 1971525624;
            continue;
          case 30:
            goto label_1;
          case 31:
            int num19;
            num1 = num19 = networkInterfaceType == (NetworkInterfaceType) 243 ? -1098331989 : (num19 = -502126956);
            continue;
          case 32:
            num1 = (int) num3 * 154636263 ^ 1684478524;
            continue;
          case 33:
            int num20;
            num1 = num20 = networkInterfaceType > NetworkInterfaceType.HighPerformanceSerialBus ? -1799506489 : (num20 = -1783474595);
            continue;
          case 34:
            int num21 = networkInterfaceType <= NetworkInterfaceType.VeryHighSpeedDsl ? -370911398 : (num21 = -1054147129);
            int num22 = (int) num3 * -1167500806;
            num1 = num21 ^ num22;
            continue;
          case 35:
            int num23 = networkInterfaceType == NetworkInterfaceType.Wireless80211 ? -1505314325 : (num23 = -858810159);
            int num24 = (int) num3 * 2027622624;
            num1 = num23 ^ num24;
            continue;
          case 36:
            int num25;
            num1 = num25 = networkInterfaceType <= NetworkInterfaceType.Tunnel ? -1137949065 : (num25 = -1881504224);
            continue;
          case 37:
            int num26;
            num1 = num26 = networkInterfaceType != NetworkInterfaceType.GigabitEthernet ? -1813945365 : (num26 = -1098331989);
            continue;
          case 38:
            int num27 = networkInterfaceType > NetworkInterfaceType.FastEthernetFx ? -47421781 : (num27 = -1886927231);
            int num28 = (int) num3 * 1277099588;
            num1 = num27 ^ num28;
            continue;
          case 39:
            int num29;
            num1 = num29 = networkInterfaceType != NetworkInterfaceType.TokenRing ? -662411083 : (num29 = -1098331989);
            continue;
          case 40:
            int num30 = networkInterfaceType != NetworkInterfaceType.MultiRateSymmetricDsl ? 1399898574 : (num30 = 1302413127);
            int num31 = (int) num3 * -25033468;
            num1 = num30 ^ num31;
            continue;
          case 41:
label_28:
            flag = true;
            num1 = -38950282;
            continue;
          case 42:
            int num32 = networkInterfaceType > NetworkInterfaceType.Ethernet ? -26643918 : (num32 = -725642499);
            int num33 = (int) num3 * 1757594568;
            num1 = num32 ^ num33;
            continue;
          case 43:
            int num34;
            num1 = num34 = networkInterfaceType == NetworkInterfaceType.Isdn ? -1098331989 : (num34 = -678024870);
            continue;
          case 44:
            num1 = (int) num3 * -599064100 ^ 854349267;
            continue;
          case 45:
            num1 = (int) num3 * -493170248 ^ 443580515;
            continue;
          case 46:
            num1 = (int) num3 * -88615396 ^ -1534384277;
            continue;
          case 48:
            int num35;
            num1 = num35 = networkInterfaceType <= NetworkInterfaceType.GenericModem ? -752768096 : (num35 = -1888769780);
            continue;
          case 49:
label_31:
            flag = false;
            num1 = -2085207160;
            continue;
          case 50:
            int num36;
            num1 = num36 = networkInterfaceType == NetworkInterfaceType.FastEthernetFx ? -1098331989 : (num36 = -2002062409);
            continue;
          case 51:
            num1 = (int) num3 * 860406132 ^ -583419825;
            continue;
          case 52:
            num1 = (int) num3 * -1453069235 ^ 1775455276;
            continue;
          default:
            goto label_56;
        }
      }
label_56:
      return flag;
    }

    public static List<string> GetMacAddresses()
    {
label_1:
      int num1 = -852423272;
      List<string> stringList1;
      while (true)
      {
        int num2 = -1025836527;
        uint num3;
        List<string> stringList2;
        NetworkInterface[] networkInterfaceArray;
        int index;
        string str;
        NetworkInterface networkInterface;
        bool flag;
        int num4;
        switch ((num3 = (uint) (num1 ^ num2)) % 17U)
        {
          case 0:
            int num5 = !flag ? -309565780 : (num5 = -559638526);
            int num6 = (int) num3 * 1190281625;
            num1 = num5 ^ num6;
            continue;
          case 1:
            stringList2.Remove(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3879325713U));
            num1 = (int) num3 * -1358617526 ^ 841809491;
            continue;
          case 2:
            int num7 = MacAddresses.\u200B⁫⁬⁭⁮⁭⁮⁯‭⁬⁮‍‮⁫‌‏⁯⁭⁫⁭⁭‍⁮‬‭‭‮‌⁮⁭‌‍⁪‍‪‌⁪⁪⁭⁯‮(networkInterface) == OperationalStatus.Up ? 167728647 : (num7 = 157919215);
            int num8 = (int) num3 * -1351944012;
            num1 = num7 ^ num8;
            continue;
          case 3:
            ++index;
            num1 = -2066393916;
            continue;
          case 4:
            num4 = !stringList2.Contains(str) ? 1 : 0;
            break;
          case 5:
            stringList2 = new List<string>();
            networkInterfaceArray = MacAddresses.\u206E‬‬‏‫⁭⁮‬‮⁯‍⁮‭‏​‍⁮‭‌‍‪‌‫‎‭‏‮⁫‬‌‎​‌⁭​​‬‌‪‭‮();
            index = 0;
            num1 = (int) num3 * -352730931 ^ 1321151607;
            continue;
          case 6:
            goto label_1;
          case 7:
            num1 = -1478032321;
            continue;
          case 8:
            num1 = (int) num3 * -1928397821 ^ 1192760509;
            continue;
          case 9:
            str = MacAddresses.\u200F‍​‪‍‎‫‪‍‪⁪⁬‌⁯‏‬​‌‫‎⁭‍‭⁫‫‎‏‮⁭‫⁮‪⁬‫⁯‬⁮⁯⁮‫‮((object) MacAddresses.\u202D⁭‬‏‫‏‌⁫⁭⁪⁫‎‌‭‏‫‪‬​‮‫‬‍⁫‌‭⁬‎‭⁪⁫‏‫‫‌‎‏‌⁯‬‮(networkInterface));
            num1 = (int) num3 * 337017833 ^ 242751124;
            continue;
          case 10:
            networkInterface = networkInterfaceArray[index];
            num1 = -1894571179;
            continue;
          case 11:
            if (!MacAddresses.\u206E‬⁯⁪⁯‎‍‭​‭‍‪⁪⁬‏⁫‏‪​‎‏⁯⁬⁫‮⁪⁪⁪‭‮⁯‏⁫‭⁬⁫‫⁫⁭‌‮(str, string.Empty))
            {
              num1 = (int) num3 * -221553096 ^ -1306982791;
              continue;
            }
            num4 = 0;
            break;
          case 12:
            stringList2.Add(str);
            num1 = (int) num3 * -1264662573 ^ -575605105;
            continue;
          case 13:
            int num9;
            num1 = num9 = index >= networkInterfaceArray.Length ? -1570491169 : (num9 = -1794099925);
            continue;
          case 14:
            num1 = (int) num3 * 1646669885 ^ -1851039769;
            continue;
          case 15:
            stringList1 = stringList2;
            num1 = (int) num3 * 17057005 ^ 464743241;
            continue;
          default:
            goto label_21;
        }
        flag = num4 != 0;
        num1 = -166455251;
      }
label_21:
      return stringList1;
    }

    static NetworkInterfaceType \u202B‏‎⁭⁭‫‎‏‭‍‌‌‌⁫‬‌⁪⁪‍‮⁫⁮‮‮‬⁪⁫‎​⁮⁯‭‮‍‏​⁮‭⁫‭‮([In] NetworkInterface obj0)
    {
      return obj0.NetworkInterfaceType;
    }

    static NetworkInterface[] \u206E‬‬‏‫⁭⁮‬‮⁯‍⁮‭‏​‍⁮‭‌‍‪‌‫‎‭‏‮⁫‬‌‎​‌⁭​​‬‌‪‭‮()
    {
      return NetworkInterface.GetAllNetworkInterfaces();
    }

    static OperationalStatus \u200B⁫⁬⁭⁮⁭⁮⁯‭⁬⁮‍‮⁫‌‏⁯⁭⁫⁭⁭‍⁮‬‭‭‮‌⁮⁭‌‍⁪‍‪‌⁪⁪⁭⁯‮([In] NetworkInterface obj0)
    {
      return obj0.OperationalStatus;
    }

    static PhysicalAddress \u202D⁭‬‏‫‏‌⁫⁭⁪⁫‎‌‭‏‫‪‬​‮‫‬‍⁫‌‭⁬‎‭⁪⁫‏‫‫‌‎‏‌⁯‬‮([In] NetworkInterface obj0)
    {
      return obj0.GetPhysicalAddress();
    }

    static string \u200F‍​‪‍‎‫‪‍‪⁪⁬‌⁯‏‬​‌‫‎⁭‍‭⁫‫‎‏‮⁭‫⁮‪⁬‫⁯‬⁮⁯⁮‫‮([In] object obj0)
    {
      return obj0.ToString();
    }

    static bool \u206E‬⁯⁪⁯‎‍‭​‭‍‪⁪⁬‏⁫‏‪​‎‏⁯⁬⁫‮⁪⁪⁪‭‮⁯‏⁫‭⁬⁫‫⁫⁭‌‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }
  }
}
