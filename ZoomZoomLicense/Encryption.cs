// Decompiled with JetBrains decompiler
// Type: ZoomZoomLicense.Encryption
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ZoomZoomLicense
{
  internal static class Encryption
  {
    internal static class StringCipher
    {
      private const int Keysize = 256;
      private const int DerivationIterations = 1000;

      internal static string Encrypt(string plainText, string passPhrase)
      {
label_1:
        int num1 = 1725118145;
        byte[] numArray1;
        byte[] numArray2;
        byte[] numArray3;
        while (true)
        {
          int num2 = 1238008190;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              numArray1 = Encryption.StringCipher.Generate256BitsOfRandomEntropy();
              num1 = (int) num3 * -2027509408 ^ -2126811137;
              continue;
            case 2:
              numArray2 = Encryption.StringCipher.Generate256BitsOfRandomEntropy();
              num1 = (int) num3 * -1393808625 ^ -1407802984;
              continue;
            case 4:
              numArray3 = Encryption.StringCipher.\u206E‏‭‫⁬⁬⁯⁯⁫⁬⁯‌​‏⁫‌‍⁫‌‭‍‬‬‪​‍⁯‎⁮⁭⁮‫⁯​⁫⁮‬⁭‭‮‮(Encryption.StringCipher.\u202B‍‌⁮⁭‬‌‫⁪⁪⁭⁯⁬⁭⁪‭⁭‬‎⁬‫‏⁬⁯‭⁭‮‪⁬⁬⁮⁪‬‬‍‍‎⁯⁬‪‮(), plainText);
              num1 = (int) num3 * -291364251 ^ -2043911482;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        Rfc2898DeriveBytes rfc2898DeriveBytes = Encryption.StringCipher.\u200B‭⁪‏‏‪‎‮‌‌‭‎‫​⁭‫⁪⁮‮⁬⁫⁬⁫‮⁪‍⁭⁪‮‫‍​‎⁬‫⁮⁭⁫‮⁪‮(passPhrase, numArray1, 1000);
        try
        {
          byte[] numArray4 = Encryption.StringCipher.\u202B⁯‭⁪‫​⁭⁪‬⁫‭⁬‭‪⁬‏‏‪‮‬‪⁫‬‬​‮‌‬⁫‪​‭⁫​⁯‮​‮‭⁫‮((DeriveBytes) rfc2898DeriveBytes, 32);
          RijndaelManaged rijndaelManaged = Encryption.StringCipher.\u202B‭‭⁯‮⁭⁭‫⁬‍‏​‭‫‬‏‮⁯​⁯⁯​‭‏⁫⁪‏‬‏‍‌​‪⁪‍‪‪⁫​⁯‮();
          try
          {
            Encryption.StringCipher.\u200C‌⁪‫⁬⁫‌⁫‍⁬⁫‭‍⁯‏⁭⁬‮⁪⁯⁮‬‍⁮⁪⁪⁬‬⁮‎‫‎⁯⁪​‌‍⁫‍⁬‮((SymmetricAlgorithm) rijndaelManaged, 256);
label_9:
            int num2 = 543029445;
            while (true)
            {
              int num3 = 1238008190;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  Encryption.StringCipher.\u206F⁭‬⁫‫‬‪​‫‍​⁭​⁫‭⁯‪‫‎‫⁬‬‏‭‫‪‭‭⁬​⁬⁫⁮​⁮‌⁪‪‮⁯‮((SymmetricAlgorithm) rijndaelManaged, PaddingMode.PKCS7);
                  num2 = (int) num4 * -1246720023 ^ 1744210423;
                  continue;
                case 2:
                  goto label_9;
                case 3:
                  Encryption.StringCipher.\u206F‪‭⁫‎‌⁭⁪‏⁭‫‎​⁬⁬‭‬‪⁪‬‌‏‎⁬‌⁪‮​⁯⁫​‪‬⁮⁫⁪‭​⁪⁪‮((SymmetricAlgorithm) rijndaelManaged, CipherMode.CBC);
                  num2 = (int) num4 * 105430042 ^ -1994093568;
                  continue;
                default:
                  goto label_13;
              }
            }
label_13:
            ICryptoTransform cryptoTransform = Encryption.StringCipher.\u206E‭⁫⁭‭⁯⁪​‬‏⁬‪‎‮‮⁫‬‬‮‪⁭‏⁮‪‮⁮⁭​⁬‎⁯⁫⁯⁮‪⁬‌‮‏‪‮((SymmetricAlgorithm) rijndaelManaged, numArray4, numArray2);
            try
            {
              MemoryStream memoryStream = Encryption.StringCipher.\u202A​‏‍​⁭‌⁪⁬⁮⁯‌⁫‌⁯‮‪⁯⁯⁮‪⁪‪⁮​​‍‌⁭‬‮⁭‫‌​‎⁬‍⁫⁪‮();
              try
              {
                CryptoStream cryptoStream = Encryption.StringCipher.\u206F‏⁯⁮⁪‪‮⁪‌‫‮‌​‪‮⁮⁯‫​⁪‌‭⁯⁫⁭‮‎⁪⁮⁯‪⁫‫‭⁮‫‮⁫‪‮((Stream) memoryStream, cryptoTransform, CryptoStreamMode.Write);
                try
                {
label_17:
                  int num3 = 1091473035;
                  byte[] numArray5;
                  while (true)
                  {
                    int num4 = 1238008190;
                    uint num5;
                    switch ((num5 = (uint) (num3 ^ num4)) % 8U)
                    {
                      case 0:
                        num3 = (int) num5 * 536319991 ^ 1210579809;
                        continue;
                      case 1:
                        numArray5 = ((IEnumerable<byte>) numArray5).Concat<byte>((IEnumerable<byte>) Encryption.StringCipher.\u202C‌‍⁫​‍⁫⁬‍‮‪‎​‬⁯⁪⁪⁬⁮⁬‪​​​‮‪‌‍⁬‮​​‭‍‎⁬⁬‪⁪⁭‮(memoryStream)).ToArray<byte>();
                        Encryption.StringCipher.\u200B⁭‍‍‏⁬‫‪‎‏⁯‏‫‫‍‍⁪‌⁬⁯⁫‬⁫⁬⁯⁬‪​⁮​‮‭‎⁯‬⁭⁫‪⁭⁬‮((Stream) memoryStream);
                        num3 = (int) num5 * -1808223167 ^ -1049732572;
                        continue;
                      case 3:
                        Encryption.StringCipher.\u200B⁭‍‍‏⁬‫‪‎‏⁯‏‫‫‍‍⁪‌⁬⁯⁫‬⁫⁬⁯⁬‪​⁮​‮‭‎⁯‬⁭⁫‪⁭⁬‮((Stream) cryptoStream);
                        num3 = (int) num5 * 1877631577 ^ -994134729;
                        continue;
                      case 4:
                        goto label_17;
                      case 5:
                        Encryption.StringCipher.\u202C⁫‏‏‌​‪⁪⁭‍‮‭​⁭‍⁭⁪‮⁭‏‌‌⁫‫⁭‎⁭‎‮⁬‭⁮⁫‫‍⁭‮‪⁪‫‮((Stream) cryptoStream, numArray3, 0, numArray3.Length);
                        Encryption.StringCipher.\u200D⁬‫⁫⁬⁫‫‎⁫⁪‪⁬⁮⁭⁮‌‬‏⁪‬‎⁪⁭‮‍⁪‬​⁪‫‎‮‫‬‬⁯⁬‮‮‌‮(cryptoStream);
                        num3 = (int) num5 * -1009046506 ^ -292096992;
                        continue;
                      case 6:
                        numArray5 = ((IEnumerable<byte>) numArray5).Concat<byte>((IEnumerable<byte>) numArray2).ToArray<byte>();
                        num3 = (int) num5 * -543894161 ^ 1985221885;
                        continue;
                      case 7:
                        numArray5 = numArray1;
                        num3 = (int) num5 * -509240946 ^ 795103034;
                        continue;
                      default:
                        goto label_25;
                    }
                  }
label_25:
                  return Encryption.StringCipher.\u206F‍⁯‫⁪‫⁯⁮⁫‮‭⁯‎⁭⁫⁭⁮⁭‭⁪‭⁫​​⁮‌⁭⁯‏‫⁪‌‬⁬⁫‪‍⁬‎⁮‮(numArray5);
                }
                finally
                {
                  if (cryptoStream != null)
                  {
label_27:
                    int num3 = 1048511309;
                    while (true)
                    {
                      int num4 = 1238008190;
                      uint num5;
                      switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                      {
                        case 0:
                          num3 = (int) num5 * 997623715 ^ 412777791;
                          continue;
                        case 2:
                          goto label_27;
                        case 3:
                          Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) cryptoStream);
                          num3 = (int) num5 * -821341212 ^ 792529474;
                          continue;
                        default:
                          goto label_31;
                      }
                    }
                  }
label_31:;
                }
              }
              finally
              {
                if (memoryStream != null)
                {
label_33:
                  int num3 = 1716841583;
                  while (true)
                  {
                    int num4 = 1238008190;
                    uint num5;
                    switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                    {
                      case 0:
                        num3 = (int) num5 * 1054910821 ^ -1069474544;
                        continue;
                      case 1:
                        Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) memoryStream);
                        num3 = (int) num5 * 1271121409 ^ -85849893;
                        continue;
                      case 3:
                        goto label_33;
                      default:
                        goto label_37;
                    }
                  }
                }
label_37:;
              }
            }
            finally
            {
              if (cryptoTransform != null)
              {
label_39:
                int num3 = 996916697;
                while (true)
                {
                  int num4 = 1238008190;
                  uint num5;
                  switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                  {
                    case 0:
                      goto label_39;
                    case 2:
                      num3 = (int) num5 * 613812449 ^ 977631409;
                      continue;
                    case 3:
                      Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) cryptoTransform);
                      num3 = (int) num5 * 1141439682 ^ -1454415890;
                      continue;
                    default:
                      goto label_43;
                  }
                }
              }
label_43:;
            }
          }
          finally
          {
            if (rijndaelManaged != null)
            {
label_45:
              int num2 = 1530733077;
              while (true)
              {
                int num3 = 1238008190;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 1:
                    Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) rijndaelManaged);
                    num2 = (int) num4 * -1160684607 ^ 356865299;
                    continue;
                  case 2:
                    goto label_45;
                  default:
                    goto label_48;
                }
              }
            }
label_48:;
          }
        }
        finally
        {
          if (rfc2898DeriveBytes != null)
          {
label_50:
            int num2 = 1230150351;
            while (true)
            {
              int num3 = 1238008190;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_50;
                case 1:
                  Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) rfc2898DeriveBytes);
                  num2 = (int) num4 * 1060011729 ^ -1990576355;
                  continue;
                case 2:
                  num2 = (int) num4 * -1411344594 ^ -1730363003;
                  continue;
                default:
                  goto label_54;
              }
            }
          }
label_54:;
        }
      }

      internal static string Decrypt(string cipherText, string passPhrase)
      {
label_1:
        int num1 = -339134484;
        byte[] array1;
        byte[] array2;
        byte[] array3;
        while (true)
        {
          int num2 = -1405626996;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              byte[] numArray = Encryption.StringCipher.\u202D⁫‎‭‮‫‌‮‎⁮‍⁭‬‭⁮‮‭⁯⁯​‭‏​‭‏‪‌⁯⁪‌‍‭‏⁪⁪‮‮‭‏⁮‮(cipherText);
              array1 = ((IEnumerable<byte>) numArray).Take<byte>(32).ToArray<byte>();
              array2 = ((IEnumerable<byte>) numArray).Skip<byte>(32).Take<byte>(32).ToArray<byte>();
              array3 = ((IEnumerable<byte>) numArray).Skip<byte>(64).Take<byte>(numArray.Length - 64).ToArray<byte>();
              num1 = (int) num3 * 1613132367 ^ -823298619;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        Rfc2898DeriveBytes rfc2898DeriveBytes = Encryption.StringCipher.\u200B‭⁪‏‏‪‎‮‌‌‭‎‫​⁭‫⁪⁮‮⁬⁫⁬⁫‮⁪‍⁭⁪‮‫‍​‎⁬‫⁮⁭⁫‮⁪‮(passPhrase, array1, 1000);
        string str;
        try
        {
          byte[] numArray1 = Encryption.StringCipher.\u202B⁯‭⁪‫​⁭⁪‬⁫‭⁬‭‪⁬‏‏‪‮‬‪⁫‬‬​‮‌‬⁫‪​‭⁫​⁯‮​‮‭⁫‮((DeriveBytes) rfc2898DeriveBytes, 32);
          RijndaelManaged rijndaelManaged = Encryption.StringCipher.\u202B‭‭⁯‮⁭⁭‫⁬‍‏​‭‫‬‏‮⁯​⁯⁯​‭‏⁫⁪‏‬‏‍‌​‪⁪‍‪‪⁫​⁯‮();
          try
          {
            Encryption.StringCipher.\u200C‌⁪‫⁬⁫‌⁫‍⁬⁫‭‍⁯‏⁭⁬‮⁪⁯⁮‬‍⁮⁪⁪⁬‬⁮‎‫‎⁯⁪​‌‍⁫‍⁬‮((SymmetricAlgorithm) rijndaelManaged, 256);
label_7:
            int num2 = -2108965543;
            while (true)
            {
              int num3 = -1405626996;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 5U)
              {
                case 1:
                  Encryption.StringCipher.\u206F‪‭⁫‎‌⁭⁪‏⁭‫‎​⁬⁬‭‬‪⁪‬‌‏‎⁬‌⁪‮​⁯⁫​‪‬⁮⁫⁪‭​⁪⁪‮((SymmetricAlgorithm) rijndaelManaged, CipherMode.CBC);
                  num2 = (int) num4 * 618150410 ^ -1911288490;
                  continue;
                case 2:
                  num2 = (int) num4 * 857597341 ^ -1710314557;
                  continue;
                case 3:
                  num2 = (int) num4 * 2739850 ^ 1740236715;
                  continue;
                case 4:
                  goto label_7;
                default:
                  goto label_12;
              }
            }
label_12:
            Encryption.StringCipher.\u206F⁭‬⁫‫‬‪​‫‍​⁭​⁫‭⁯‪‫‎‫⁬‬‏‭‫‪‭‭⁬​⁬⁫⁮​⁮‌⁪‪‮⁯‮((SymmetricAlgorithm) rijndaelManaged, PaddingMode.PKCS7);
            ICryptoTransform cryptoTransform = Encryption.StringCipher.\u206F‍⁫​⁪‭⁫⁬‪‍⁪⁭‪⁮‬⁬‌‮‍⁪⁫⁮‮​‎‎‬‮⁫‏⁫‭‫⁭⁫‍‬‎‫‏‮((SymmetricAlgorithm) rijndaelManaged, numArray1, array2);
            try
            {
              MemoryStream memoryStream = Encryption.StringCipher.\u206D⁫‮‌‮⁪‌⁮‭⁬​‮⁬‎‏⁭‏‪⁬⁪‬⁫‍‭​‎⁪⁮⁯⁮‬‍⁭‌‌‎‫⁫⁪‮(array3);
              try
              {
                CryptoStream cryptoStream = Encryption.StringCipher.\u206F‏⁯⁮⁪‪‮⁪‌‫‮‌​‪‮⁮⁯‫​⁪‌‭⁯⁫⁭‮‎⁪⁮⁯‪⁫‫‭⁮‫‮⁫‪‮((Stream) memoryStream, cryptoTransform, CryptoStreamMode.Read);
                try
                {
                  byte[] numArray2 = new byte[array3.Length];
label_16:
                  int num3 = -336069608;
                  while (true)
                  {
                    int num4 = -1405626996;
                    uint num5;
                    int num6;
                    switch ((num5 = (uint) (num3 ^ num4)) % 7U)
                    {
                      case 0:
                        str = Encryption.StringCipher.\u202D‏‏⁫‎⁯‬‏‍‏⁯‮⁮‬‫‏‬‍‭‍⁯⁮⁯⁮‮‍⁮‪‬​‬⁯‫‍‍​‬‮‪‍‮(Encryption.StringCipher.\u202B‍‌⁮⁭‬‌‫⁪⁪⁭⁯⁬⁭⁪‭⁭‬‎⁬‫‏⁬⁯‭⁭‮‪⁬⁬⁮⁪‬‬‍‍‎⁯⁬‪‮(), numArray2, 0, num6);
                        num3 = (int) num5 * -761957164 ^ -2089241146;
                        continue;
                      case 1:
                        num3 = (int) num5 * -2147283260 ^ -2073083944;
                        continue;
                      case 2:
                        num3 = (int) num5 * -443183628 ^ -500938189;
                        continue;
                      case 3:
                        goto label_16;
                      case 4:
                        num6 = Encryption.StringCipher.\u202E‬‭⁯⁫‪‫⁪‬⁮⁯⁫‪⁭‏‫‭‮​‮⁭⁯‫⁭⁪⁯⁭⁪‮⁬⁮⁬‫‏⁮⁮‭⁪‮‭‮((Stream) cryptoStream, numArray2, 0, numArray2.Length);
                        Encryption.StringCipher.\u200B⁭‍‍‏⁬‫‪‎‏⁯‏‫‫‍‍⁪‌⁬⁯⁫‬⁫⁬⁯⁬‪​⁮​‮‭‎⁯‬⁭⁫‪⁭⁬‮((Stream) memoryStream);
                        num3 = (int) num5 * -908627668 ^ -1855307469;
                        continue;
                      case 6:
                        Encryption.StringCipher.\u200B⁭‍‍‏⁬‫‪‎‏⁯‏‫‫‍‍⁪‌⁬⁯⁫‬⁫⁬⁯⁬‪​⁮​‮‭‎⁯‬⁭⁫‪⁭⁬‮((Stream) cryptoStream);
                        num3 = (int) num5 * 2002218383 ^ -785722189;
                        continue;
                      default:
                        goto label_51;
                    }
                  }
                }
                finally
                {
                  if (cryptoStream != null)
                  {
label_24:
                    int num3 = -1804531692;
                    while (true)
                    {
                      int num4 = -1405626996;
                      uint num5;
                      switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                      {
                        case 1:
                          Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) cryptoStream);
                          num3 = (int) num5 * -294756241 ^ 1731612100;
                          continue;
                        case 2:
                          goto label_24;
                        default:
                          goto label_27;
                      }
                    }
                  }
label_27:;
                }
              }
              finally
              {
                if (memoryStream != null)
                {
label_29:
                  int num3 = -533594357;
                  while (true)
                  {
                    int num4 = -1405626996;
                    uint num5;
                    switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                    {
                      case 1:
                        Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) memoryStream);
                        num3 = (int) num5 * 5488554 ^ 377313665;
                        continue;
                      case 2:
                        goto label_29;
                      default:
                        goto label_32;
                    }
                  }
                }
label_32:;
              }
            }
            finally
            {
              if (cryptoTransform != null)
              {
label_34:
                int num3 = -260423222;
                while (true)
                {
                  int num4 = -1405626996;
                  uint num5;
                  switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                  {
                    case 0:
                      goto label_34;
                    case 1:
                      num3 = (int) num5 * 1435133298 ^ -578604815;
                      continue;
                    case 2:
                      Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) cryptoTransform);
                      num3 = (int) num5 * 1915717077 ^ -636424145;
                      continue;
                    default:
                      goto label_38;
                  }
                }
              }
label_38:;
            }
          }
          finally
          {
            if (rijndaelManaged != null)
            {
label_40:
              int num2 = -1557039883;
              while (true)
              {
                int num3 = -1405626996;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 4U)
                {
                  case 1:
                    Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) rijndaelManaged);
                    num2 = (int) num4 * 2058159097 ^ -2143280241;
                    continue;
                  case 2:
                    num2 = (int) num4 * 1999011571 ^ -1179318182;
                    continue;
                  case 3:
                    goto label_40;
                  default:
                    goto label_44;
                }
              }
            }
label_44:;
          }
        }
        finally
        {
          if (rfc2898DeriveBytes != null)
          {
label_46:
            int num2 = -1755030215;
            while (true)
            {
              int num3 = -1405626996;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_46;
                case 1:
                  Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) rfc2898DeriveBytes);
                  num2 = (int) num4 * -1022439926 ^ 60639732;
                  continue;
                case 2:
                  num2 = (int) num4 * 1783835443 ^ -1163288679;
                  continue;
                default:
                  goto label_50;
              }
            }
          }
label_50:;
        }
label_51:
        return str;
      }

      private static byte[] Generate256BitsOfRandomEntropy()
      {
        byte[] numArray1 = new byte[32];
        RNGCryptoServiceProvider cryptoServiceProvider = Encryption.StringCipher.\u202C‭‎⁭⁮⁮⁭⁮⁭‍‏‏‫‪⁯‬⁭‪‫‭​‬​‪‬‪‭‬⁬⁭​⁫⁯‮⁮⁯‮⁭⁮⁬‮();
        try
        {
label_2:
          int num1 = -1527656288;
          while (true)
          {
            int num2 = -1730161519;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 0:
                goto label_2;
              case 1:
                Encryption.StringCipher.\u200E‫​‎⁯⁯⁬‭⁬‏⁮‍⁭‌‮‮‎‮⁪‭⁭⁮⁯‌‫‍​‌⁬⁭‭⁮‍‍‏⁮⁬‭⁪‎‮((RandomNumberGenerator) cryptoServiceProvider, numArray1);
                num1 = (int) num3 * 535973090 ^ 1503322445;
                continue;
              case 2:
                num1 = (int) num3 * -1877854317 ^ -1933570188;
                continue;
              default:
                goto label_11;
            }
          }
        }
        finally
        {
          if (cryptoServiceProvider != null)
          {
label_7:
            int num1 = -1310083315;
            while (true)
            {
              int num2 = -1730161519;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 3U)
              {
                case 0:
                  goto label_7;
                case 2:
                  Encryption.StringCipher.\u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮((IDisposable) cryptoServiceProvider);
                  num1 = (int) num3 * 1232314620 ^ 1354274767;
                  continue;
                default:
                  goto label_10;
              }
            }
          }
label_10:;
        }
label_11:
        byte[] numArray2 = numArray1;
label_12:
        int num4 = -1771957670;
        while (true)
        {
          int num1 = -1730161519;
          uint num2;
          switch ((num2 = (uint) (num4 ^ num1)) % 3U)
          {
            case 1:
              num4 = (int) num2 * 1895443221 ^ -1599899323;
              continue;
            case 2:
              goto label_12;
            default:
              goto label_15;
          }
        }
label_15:
        return numArray2;
      }

      static Encoding \u202B‍‌⁮⁭‬‌‫⁪⁪⁭⁯⁬⁭⁪‭⁭‬‎⁬‫‏⁬⁯‭⁭‮‪⁬⁬⁮⁪‬‬‍‍‎⁯⁬‪‮()
      {
        return Encoding.UTF8;
      }

      static byte[] \u206E‏‭‫⁬⁬⁯⁯⁫⁬⁯‌​‏⁫‌‍⁫‌‭‍‬‬‪​‍⁯‎⁮⁭⁮‫⁯​⁫⁮‬⁭‭‮‮([In] Encoding obj0, [In] string obj1)
      {
        return obj0.GetBytes(obj1);
      }

      static Rfc2898DeriveBytes \u200B‭⁪‏‏‪‎‮‌‌‭‎‫​⁭‫⁪⁮‮⁬⁫⁬⁫‮⁪‍⁭⁪‮‫‍​‎⁬‫⁮⁭⁫‮⁪‮([In] string obj0, [In] byte[] obj1, [In] int obj2)
      {
        return new Rfc2898DeriveBytes(obj0, obj1, obj2);
      }

      static byte[] \u202B⁯‭⁪‫​⁭⁪‬⁫‭⁬‭‪⁬‏‏‪‮‬‪⁫‬‬​‮‌‬⁫‪​‭⁫​⁯‮​‮‭⁫‮([In] DeriveBytes obj0, [In] int obj1)
      {
        return obj0.GetBytes(obj1);
      }

      static RijndaelManaged \u202B‭‭⁯‮⁭⁭‫⁬‍‏​‭‫‬‏‮⁯​⁯⁯​‭‏⁫⁪‏‬‏‍‌​‪⁪‍‪‪⁫​⁯‮()
      {
        return new RijndaelManaged();
      }

      static void \u200C‌⁪‫⁬⁫‌⁫‍⁬⁫‭‍⁯‏⁭⁬‮⁪⁯⁮‬‍⁮⁪⁪⁬‬⁮‎‫‎⁯⁪​‌‍⁫‍⁬‮([In] SymmetricAlgorithm obj0, [In] int obj1)
      {
        obj0.BlockSize = obj1;
      }

      static void \u206F‪‭⁫‎‌⁭⁪‏⁭‫‎​⁬⁬‭‬‪⁪‬‌‏‎⁬‌⁪‮​⁯⁫​‪‬⁮⁫⁪‭​⁪⁪‮([In] SymmetricAlgorithm obj0, [In] CipherMode obj1)
      {
        obj0.Mode = obj1;
      }

      static void \u206F⁭‬⁫‫‬‪​‫‍​⁭​⁫‭⁯‪‫‎‫⁬‬‏‭‫‪‭‭⁬​⁬⁫⁮​⁮‌⁪‪‮⁯‮([In] SymmetricAlgorithm obj0, [In] PaddingMode obj1)
      {
        obj0.Padding = obj1;
      }

      static ICryptoTransform \u206E‭⁫⁭‭⁯⁪​‬‏⁬‪‎‮‮⁫‬‬‮‪⁭‏⁮‪‮⁮⁭​⁬‎⁯⁫⁯⁮‪⁬‌‮‏‪‮([In] SymmetricAlgorithm obj0, [In] byte[] obj1, [In] byte[] obj2)
      {
        return obj0.CreateEncryptor(obj1, obj2);
      }

      static MemoryStream \u202A​‏‍​⁭‌⁪⁬⁮⁯‌⁫‌⁯‮‪⁯⁯⁮‪⁪‪⁮​​‍‌⁭‬‮⁭‫‌​‎⁬‍⁫⁪‮()
      {
        return new MemoryStream();
      }

      static CryptoStream \u206F‏⁯⁮⁪‪‮⁪‌‫‮‌​‪‮⁮⁯‫​⁪‌‭⁯⁫⁭‮‎⁪⁮⁯‪⁫‫‭⁮‫‮⁫‪‮([In] Stream obj0, [In] ICryptoTransform obj1, [In] CryptoStreamMode obj2)
      {
        return new CryptoStream(obj0, obj1, obj2);
      }

      static void \u202C⁫‏‏‌​‪⁪⁭‍‮‭​⁭‍⁭⁪‮⁭‏‌‌⁫‫⁭‎⁭‎‮⁬‭⁮⁫‫‍⁭‮‪⁪‫‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
      {
        obj0.Write(obj1, obj2, obj3);
      }

      static void \u200D⁬‫⁫⁬⁫‫‎⁫⁪‪⁬⁮⁭⁮‌‬‏⁪‬‎⁪⁭‮‍⁪‬​⁪‫‎‮‫‬‬⁯⁬‮‮‌‮([In] CryptoStream obj0)
      {
        obj0.FlushFinalBlock();
      }

      static byte[] \u202C‌‍⁫​‍⁫⁬‍‮‪‎​‬⁯⁪⁪⁬⁮⁬‪​​​‮‪‌‍⁬‮​​‭‍‎⁬⁬‪⁪⁭‮([In] MemoryStream obj0)
      {
        return obj0.ToArray();
      }

      static void \u200B⁭‍‍‏⁬‫‪‎‏⁯‏‫‫‍‍⁪‌⁬⁯⁫‬⁫⁬⁯⁬‪​⁮​‮‭‎⁯‬⁭⁫‪⁭⁬‮([In] Stream obj0)
      {
        obj0.Close();
      }

      static string \u206F‍⁯‫⁪‫⁯⁮⁫‮‭⁯‎⁭⁫⁭⁮⁭‭⁪‭⁫​​⁮‌⁭⁯‏‫⁪‌‬⁬⁫‪‍⁬‎⁮‮([In] byte[] obj0)
      {
        return Convert.ToBase64String(obj0);
      }

      static void \u200B⁯⁬‬‍‪⁪‬‏⁪‌‬⁯‪‮​⁪⁮⁫⁬‬‌⁮⁭⁪‎⁮‭⁯⁪‬‎‪‎​‮‫‭‌⁮‮([In] IDisposable obj0)
      {
        obj0.Dispose();
      }

      static byte[] \u202D⁫‎‭‮‫‌‮‎⁮‍⁭‬‭⁮‮‭⁯⁯​‭‏​‭‏‪‌⁯⁪‌‍‭‏⁪⁪‮‮‭‏⁮‮([In] string obj0)
      {
        return Convert.FromBase64String(obj0);
      }

      static ICryptoTransform \u206F‍⁫​⁪‭⁫⁬‪‍⁪⁭‪⁮‬⁬‌‮‍⁪⁫⁮‮​‎‎‬‮⁫‏⁫‭‫⁭⁫‍‬‎‫‏‮([In] SymmetricAlgorithm obj0, [In] byte[] obj1, [In] byte[] obj2)
      {
        return obj0.CreateDecryptor(obj1, obj2);
      }

      static MemoryStream \u206D⁫‮‌‮⁪‌⁮‭⁬​‮⁬‎‏⁭‏‪⁬⁪‬⁫‍‭​‎⁪⁮⁯⁮‬‍⁭‌‌‎‫⁫⁪‮([In] byte[] obj0)
      {
        return new MemoryStream(obj0);
      }

      static int \u202E‬‭⁯⁫‪‫⁪‬⁮⁯⁫‪⁭‏‫‭‮​‮⁭⁯‫⁭⁪⁯⁭⁪‮⁬⁮⁬‫‏⁮⁮‭⁪‮‭‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
      {
        return obj0.Read(obj1, obj2, obj3);
      }

      static string \u202D‏‏⁫‎⁯‬‏‍‏⁯‮⁮‬‫‏‬‍‭‍⁯⁮⁯⁮‮‍⁮‪‬​‬⁯‫‍‍​‬‮‪‍‮([In] Encoding obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
      {
        return obj0.GetString(obj1, obj2, obj3);
      }

      static RNGCryptoServiceProvider \u202C‭‎⁭⁮⁮⁭⁮⁭‍‏‏‫‪⁯‬⁭‪‫‭​‬​‪‬‪‭‬⁬⁭​⁫⁯‮⁮⁯‮⁭⁮⁬‮()
      {
        return new RNGCryptoServiceProvider();
      }

      static void \u200E‫​‎⁯⁯⁬‭⁬‏⁮‍⁭‌‮‮‎‮⁪‭⁭⁮⁯‌‫‍​‌⁬⁭‭⁮‍‍‏⁮⁬‭⁪‎‮([In] RandomNumberGenerator obj0, [In] byte[] obj1)
      {
        obj0.GetBytes(obj1);
      }
    }
  }
}
