// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Utils.Encryption
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

namespace ZoomZoom.Models.Utils
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
        int num1 = -2046790399;
        byte[] numArray1;
        byte[] numArray2;
        while (true)
        {
          int num2 = -85745577;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              numArray2 = Encryption.StringCipher.Generate256BitsOfRandomEntropy();
              num1 = (int) num3 * 1118138310 ^ -248877735;
              continue;
            case 2:
              numArray1 = Encryption.StringCipher.Generate256BitsOfRandomEntropy();
              num1 = (int) num3 * 710488722 ^ -587121442;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        byte[] numArray3 = Encryption.StringCipher.\u206B‎⁫⁪⁪⁬‬⁬‭‫‏⁭⁯⁪‬‌‫⁪‍⁯‭‪‏‍⁭⁪⁭‬‎‌‍⁯‫‮‌‫‫⁭⁪⁯‮(Encryption.StringCipher.\u202D⁫⁫‭⁬⁪‏⁮‫‭‏⁫⁯‬‎⁫‮‭⁪‭⁪⁪‌‬‭‌⁬⁫⁫‌‍⁬⁫⁫⁫‪⁭‪⁮‭‮(), plainText);
        Rfc2898DeriveBytes rfc2898DeriveBytes = Encryption.StringCipher.\u200C⁬⁬​‭‎‌‌‍‏⁫‎⁭‏⁭⁭‮‫‭⁫​‎⁬⁯‏‎⁭‎⁫‬‮‌⁯‭⁯⁫​‍‬‭‮(passPhrase, numArray1, 1000);
        try
        {
          byte[] numArray4 = Encryption.StringCipher.\u200B‬⁭‫‭‪‬‮⁬‬‎‍⁪‪⁬‭‌‭‮⁪‍⁯⁫‭‭⁯‬​⁮⁬‌‎‌‫‌‭⁬⁯⁭⁬‮((DeriveBytes) rfc2898DeriveBytes, 32);
          RijndaelManaged rijndaelManaged = Encryption.StringCipher.\u202E​‪‭‏‪⁫‎‪⁭⁬‌‭⁯⁯‪⁮⁬‬‪‍‭‎⁮‎‌‏‏​⁭‍‮‏⁪‭‪⁪‪‪‮();
          try
          {
            Encryption.StringCipher.\u206C‬⁮⁪‬‎‬‭⁪‮⁪⁭‍‬⁭​‫‏⁫⁯‫‫⁭‫​⁪‎⁬‎‍‪‫‮‌‬‎‬‏‍⁯‮((SymmetricAlgorithm) rijndaelManaged, 256);
label_8:
            int num2 = -1827759058;
            while (true)
            {
              int num3 = -85745577;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_8;
                case 1:
                  Encryption.StringCipher.\u206E⁯⁯‎⁯‬‭⁫‫‮⁫⁮‪‭⁫‬‮‮⁯‬⁪‌‭⁯‎‪⁫‭‪⁭⁯‎‍‌‏‭⁫⁭⁪‪‮((SymmetricAlgorithm) rijndaelManaged, CipherMode.CBC);
                  num2 = (int) num4 * 31461700 ^ -1247209653;
                  continue;
                default:
                  goto label_11;
              }
            }
label_11:
            Encryption.StringCipher.\u200F‭‎‪‌‭‎⁮⁪‮‏‮‬⁫‏‎‬‪‭⁭⁫⁪⁫⁮‮‌‮‭‪⁫‍⁫⁪‪⁬‪‬‫⁭‬‮((SymmetricAlgorithm) rijndaelManaged, PaddingMode.PKCS7);
            ICryptoTransform cryptoTransform = Encryption.StringCipher.\u200E⁭‬⁮‫‭​‎⁮‏⁬⁯‫‎‪‮‬⁮⁫‬⁮‏‌‭‎‌⁯​‏‎⁮‎​‮⁫⁭‌‮​‌‮((SymmetricAlgorithm) rijndaelManaged, numArray4, numArray2);
            try
            {
              MemoryStream memoryStream = Encryption.StringCipher.\u202B‮‌‪‌‭‮⁬‭‭‫‬⁮⁮‎‍‌⁪⁪‮⁬‏⁫‮‮⁮‮⁬‬⁯⁬‍⁯‏‪‏‏⁬‍‌‮();
              try
              {
                CryptoStream cryptoStream = Encryption.StringCipher.\u200B⁯‍‬​‏‭‪‪‫‍‍⁫⁯‎‭⁭‍‬‭⁫⁪‬‮‮⁭​⁬‪‎‎‫‏‬​⁭‫‏⁫⁮‮((Stream) memoryStream, cryptoTransform, CryptoStreamMode.Write);
                try
                {
label_15:
                  int num3 = -2061112498;
                  byte[] numArray5;
                  while (true)
                  {
                    int num4 = -85745577;
                    uint num5;
                    switch ((num5 = (uint) (num3 ^ num4)) % 7U)
                    {
                      case 1:
                        Encryption.StringCipher.\u200B‫‎‮⁬‏‮‫‍​⁬‌⁮‏⁪‭‍‫‭⁬‬‭⁫‏‭‪‬‭‭‌⁭⁪‍‍⁯‫‪‍​⁯‮((Stream) cryptoStream, numArray3, 0, numArray3.Length);
                        num3 = (int) num5 * -256269655 ^ 410381095;
                        continue;
                      case 2:
                        goto label_15;
                      case 3:
                        numArray5 = ((IEnumerable<byte>) numArray5).Concat<byte>((IEnumerable<byte>) numArray2).ToArray<byte>();
                        num3 = (int) num5 * 557157991 ^ -1380586470;
                        continue;
                      case 4:
                        Encryption.StringCipher.\u202E‌⁬‫⁭⁬‪​⁭⁬‌‏‌‪‫​‬⁪‬‌‫⁫‭⁮⁭​​‪‪‪‏⁬‫‍⁯‏‪⁯⁪⁪‮((Stream) cryptoStream);
                        num3 = (int) num5 * 2147272783 ^ -2097146453;
                        continue;
                      case 5:
                        numArray5 = ((IEnumerable<byte>) numArray5).Concat<byte>((IEnumerable<byte>) Encryption.StringCipher.\u206B‍⁭⁭⁭‪‭⁫⁬⁭‍‪⁫‎⁫⁫⁭​⁯​‎‎⁯⁫⁪‎⁬‪⁪⁯⁭⁮‍‭‎‮‏⁭⁮‮‮(memoryStream)).ToArray<byte>();
                        Encryption.StringCipher.\u202E‌⁬‫⁭⁬‪​⁭⁬‌‏‌‪‫​‬⁪‬‌‫⁫‭⁮⁭​​‪‪‪‏⁬‫‍⁯‏‪⁯⁪⁪‮((Stream) memoryStream);
                        num3 = (int) num5 * -471534089 ^ -970869699;
                        continue;
                      case 6:
                        Encryption.StringCipher.\u206A‭⁪⁬‍‫⁪⁭​⁯⁭‏⁬‫‫‭​‎‍‏⁫‌⁯‍⁭‫⁮‮⁬‪⁫​⁪⁬‫⁮‪‬⁫⁬‮(cryptoStream);
                        numArray5 = numArray1;
                        num3 = (int) num5 * -2096274695 ^ 897346062;
                        continue;
                      default:
                        goto label_22;
                    }
                  }
label_22:
                  return Encryption.StringCipher.\u202E‏‌‎⁯‭‌⁪‏‏⁪⁪‫⁫⁯‬‏⁫‎‎‫‎⁭‍‭‏‏‮⁭‪⁬⁮⁬⁬‮‎‍​⁪⁮‮(numArray5);
                }
                finally
                {
                  if (cryptoStream != null)
                  {
label_24:
                    int num3 = -592945509;
                    while (true)
                    {
                      int num4 = -85745577;
                      uint num5;
                      switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                      {
                        case 1:
                          Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) cryptoStream);
                          num3 = (int) num5 * 825399209 ^ 1837690414;
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
                  int num3 = -748819784;
                  while (true)
                  {
                    int num4 = -85745577;
                    uint num5;
                    switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                    {
                      case 1:
                        Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) memoryStream);
                        num3 = (int) num5 * -850387758 ^ 1626468331;
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
                int num3 = -1002694696;
                while (true)
                {
                  int num4 = -85745577;
                  uint num5;
                  switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                  {
                    case 0:
                      goto label_34;
                    case 1:
                      num3 = (int) num5 * 1358808428 ^ -1356379163;
                      continue;
                    case 3:
                      Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) cryptoTransform);
                      num3 = (int) num5 * 2126680090 ^ 409983088;
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
              int num2 = -2116146626;
              while (true)
              {
                int num3 = -85745577;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_40;
                  case 1:
                    Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) rijndaelManaged);
                    num2 = (int) num4 * -2059494747 ^ 612641653;
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
          if (rfc2898DeriveBytes != null)
          {
label_45:
            int num2 = -1201628059;
            while (true)
            {
              int num3 = -85745577;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 3U)
              {
                case 0:
                  goto label_45;
                case 1:
                  Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) rfc2898DeriveBytes);
                  num2 = (int) num4 * -1962487265 ^ -125382659;
                  continue;
                default:
                  goto label_48;
              }
            }
          }
label_48:;
        }
      }

      internal static string Decrypt(string cipherText, string passPhrase)
      {
label_1:
        int num1 = 501436747;
        byte[] numArray1;
        byte[] array1;
        byte[] array2;
        while (true)
        {
          int num2 = 738458260;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              numArray1 = Encryption.StringCipher.\u206F⁭‪‪⁪⁮‎‮⁮‭⁭‮‏​⁭‭⁭‌⁮‏⁮‏‎‪‍⁯‬‏⁯‫‍‭⁮⁫‭⁯‫‭‬‮(cipherText);
              array1 = ((IEnumerable<byte>) numArray1).Take<byte>(32).ToArray<byte>();
              array2 = ((IEnumerable<byte>) numArray1).Skip<byte>(32).Take<byte>(32).ToArray<byte>();
              num1 = (int) num3 * 1246882404 ^ -418594571;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        byte[] array3 = ((IEnumerable<byte>) numArray1).Skip<byte>(64).Take<byte>(numArray1.Length - 64).ToArray<byte>();
        Rfc2898DeriveBytes rfc2898DeriveBytes = Encryption.StringCipher.\u200C⁬⁬​‭‎‌‌‍‏⁫‎⁭‏⁭⁭‮‫‭⁫​‎⁬⁯‏‎⁭‎⁫‬‮‌⁯‭⁯⁫​‍‬‭‮(passPhrase, array1, 1000);
        try
        {
          byte[] numArray2 = Encryption.StringCipher.\u200B‬⁭‫‭‪‬‮⁬‬‎‍⁪‪⁬‭‌‭‮⁪‍⁯⁫‭‭⁯‬​⁮⁬‌‎‌‫‌‭⁬⁯⁭⁬‮((DeriveBytes) rfc2898DeriveBytes, 32);
          RijndaelManaged rijndaelManaged = Encryption.StringCipher.\u202E​‪‭‏‪⁫‎‪⁭⁬‌‭⁯⁯‪⁮⁬‬‪‍‭‎⁮‎‌‏‏​⁭‍‮‏⁪‭‪⁪‪‪‮();
          try
          {
label_7:
            int num2 = 28845016;
            while (true)
            {
              int num3 = 738458260;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 7U)
              {
                case 0:
                  Encryption.StringCipher.\u200F‭‎‪‌‭‎⁮⁪‮‏‮‬⁫‏‎‬‪‭⁭⁫⁪⁫⁮‮‌‮‭‪⁫‍⁫⁪‪⁬‪‬‫⁭‬‮((SymmetricAlgorithm) rijndaelManaged, PaddingMode.PKCS7);
                  num2 = (int) num4 * -661680415 ^ 1951003755;
                  continue;
                case 1:
                  num2 = (int) num4 * -356392171 ^ -1681727040;
                  continue;
                case 2:
                  goto label_7;
                case 3:
                  num2 = (int) num4 * -470590744 ^ -782524955;
                  continue;
                case 5:
                  Encryption.StringCipher.\u206C‬⁮⁪‬‎‬‭⁪‮⁪⁭‍‬⁭​‫‏⁫⁯‫‫⁭‫​⁪‎⁬‎‍‪‫‮‌‬‎‬‏‍⁯‮((SymmetricAlgorithm) rijndaelManaged, 256);
                  num2 = (int) num4 * 1677601627 ^ -1568491426;
                  continue;
                case 6:
                  Encryption.StringCipher.\u206E⁯⁯‎⁯‬‭⁫‫‮⁫⁮‪‭⁫‬‮‮⁯‬⁪‌‭⁯‎‪⁫‭‪⁭⁯‎‍‌‏‭⁫⁭⁪‪‮((SymmetricAlgorithm) rijndaelManaged, CipherMode.CBC);
                  num2 = (int) num4 * -1030785962 ^ -423386197;
                  continue;
                default:
                  goto label_14;
              }
            }
label_14:
            ICryptoTransform cryptoTransform = Encryption.StringCipher.\u202E‏⁪‌⁯‌‏⁯‪⁯‭‌‍⁪⁭⁬​‎⁪‬‎‫‍⁬‏‬⁭⁫‭⁯‪⁮‮​‮‌‫‏‌‮‮((SymmetricAlgorithm) rijndaelManaged, numArray2, array2);
            try
            {
              MemoryStream memoryStream = Encryption.StringCipher.\u206C⁪‫‪⁭⁯‌‫‬‭⁯⁮​⁫‮​‮⁪‏‌‌​‌‏⁮⁫⁭⁬⁭⁯‍‫‌‌⁪‏‎‪‏⁪‮(array3);
              try
              {
                CryptoStream cryptoStream = Encryption.StringCipher.\u200B⁯‍‬​‏‭‪‪‫‍‍⁫⁯‎‭⁭‍‬‭⁫⁪‬‮‮⁭​⁬‪‎‎‫‏‬​⁭‫‏⁫⁮‮((Stream) memoryStream, cryptoTransform, CryptoStreamMode.Read);
                try
                {
label_18:
                  int num3 = 851018175;
                  byte[] numArray3;
                  int num4;
                  while (true)
                  {
                    int num5 = 738458260;
                    uint num6;
                    switch ((num6 = (uint) (num3 ^ num5)) % 5U)
                    {
                      case 0:
                        goto label_18;
                      case 2:
                        numArray3 = new byte[array3.Length];
                        num4 = Encryption.StringCipher.\u200B‭⁯⁫‪‪‬‮‬‍‎‏‎​​‫‬‎⁮‎‪⁭‭‬‍⁭‌‪⁪⁯‏​⁮‌⁯⁭‪‌⁭‭‮((Stream) cryptoStream, numArray3, 0, numArray3.Length);
                        Encryption.StringCipher.\u202E‌⁬‫⁭⁬‪​⁭⁬‌‏‌‪‫​‬⁪‬‌‫⁫‭⁮⁭​​‪‪‪‏⁬‫‍⁯‏‪⁯⁪⁪‮((Stream) memoryStream);
                        num3 = (int) num6 * -1117707901 ^ 917374912;
                        continue;
                      case 3:
                        Encryption.StringCipher.\u202E‌⁬‫⁭⁬‪​⁭⁬‌‏‌‪‫​‬⁪‬‌‫⁫‭⁮⁭​​‪‪‪‏⁬‫‍⁯‏‪⁯⁪⁪‮((Stream) cryptoStream);
                        num3 = (int) num6 * 1299384133 ^ 511628013;
                        continue;
                      case 4:
                        num3 = (int) num6 * -1743601871 ^ -915056807;
                        continue;
                      default:
                        goto label_23;
                    }
                  }
label_23:
                  return Encryption.StringCipher.\u206D‫‎⁪‌‍⁬⁭⁪‌‬⁮‍⁭​⁯‌‭‍⁯⁭‍⁪⁮⁮‏​‫⁬‏‍⁬‫⁮⁮‬‎‬‪⁯‮(Encryption.StringCipher.\u202D⁫⁫‭⁬⁪‏⁮‫‭‏⁫⁯‬‎⁫‮‭⁪‭⁪⁪‌‬‭‌⁬⁫⁫‌‍⁬⁫⁫⁫‪⁭‪⁮‭‮(), numArray3, 0, num4);
                }
                finally
                {
                  if (cryptoStream != null)
                  {
label_25:
                    int num3 = 911247350;
                    while (true)
                    {
                      int num4 = 738458260;
                      uint num5;
                      switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                      {
                        case 0:
                          goto label_25;
                        case 1:
                          num3 = (int) num5 * 54240338 ^ 1763741701;
                          continue;
                        case 2:
                          Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) cryptoStream);
                          num3 = (int) num5 * -318069612 ^ 266729669;
                          continue;
                        default:
                          goto label_29;
                      }
                    }
                  }
label_29:;
                }
              }
              finally
              {
                if (memoryStream != null)
                {
label_31:
                  int num3 = 27179126;
                  while (true)
                  {
                    int num4 = 738458260;
                    uint num5;
                    switch ((num5 = (uint) (num3 ^ num4)) % 4U)
                    {
                      case 0:
                        goto label_31;
                      case 1:
                        num3 = (int) num5 * -1311652086 ^ 1156542701;
                        continue;
                      case 2:
                        Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) memoryStream);
                        num3 = (int) num5 * -1468536722 ^ -142955611;
                        continue;
                      default:
                        goto label_35;
                    }
                  }
                }
label_35:;
              }
            }
            finally
            {
              if (cryptoTransform != null)
              {
label_37:
                int num3 = 954938693;
                while (true)
                {
                  int num4 = 738458260;
                  uint num5;
                  switch ((num5 = (uint) (num3 ^ num4)) % 3U)
                  {
                    case 0:
                      goto label_37;
                    case 2:
                      Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) cryptoTransform);
                      num3 = (int) num5 * 808197929 ^ 693095081;
                      continue;
                    default:
                      goto label_40;
                  }
                }
              }
label_40:;
            }
          }
          finally
          {
            if (rijndaelManaged != null)
            {
label_42:
              int num2 = 1451300227;
              while (true)
              {
                int num3 = 738458260;
                uint num4;
                switch ((num4 = (uint) (num2 ^ num3)) % 3U)
                {
                  case 0:
                    goto label_42;
                  case 1:
                    Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) rijndaelManaged);
                    num2 = (int) num4 * -479905074 ^ -67250872;
                    continue;
                  default:
                    goto label_45;
                }
              }
            }
label_45:;
          }
        }
        finally
        {
          if (rfc2898DeriveBytes != null)
          {
label_47:
            int num2 = 238056630;
            while (true)
            {
              int num3 = 738458260;
              uint num4;
              switch ((num4 = (uint) (num2 ^ num3)) % 4U)
              {
                case 0:
                  goto label_47;
                case 1:
                  num2 = (int) num4 * -1048873530 ^ 1532519501;
                  continue;
                case 2:
                  Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) rfc2898DeriveBytes);
                  num2 = (int) num4 * 432373491 ^ -1457060897;
                  continue;
                default:
                  goto label_51;
              }
            }
          }
label_51:;
        }
      }

      private static byte[] Generate256BitsOfRandomEntropy()
      {
        byte[] numArray = new byte[32];
        RNGCryptoServiceProvider cryptoServiceProvider = Encryption.StringCipher.\u202C⁫​‪​‪‎‌‍‍‌⁮‏‭‪⁪⁪‫‭⁫⁫‎‍‫‎⁬‭‮⁮‏‬⁮‭⁬‮⁮‭⁮⁫‎‮();
        try
        {
label_2:
          int num1 = -862538930;
          while (true)
          {
            int num2 = -80378410;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 5U)
            {
              case 0:
                goto label_2;
              case 1:
                num1 = (int) num3 * 2087573742 ^ -552338483;
                continue;
              case 2:
                num1 = (int) num3 * 1229708094 ^ -1462493622;
                continue;
              case 4:
                Encryption.StringCipher.\u200C‭‎‬‌⁭⁪‏⁪⁯‮‌‫⁮‫‬‏‬‪‍⁭⁪‎‭‎⁮⁪‌‌‍‭‬⁬⁮⁫​⁪‍‎‏‮((RandomNumberGenerator) cryptoServiceProvider, numArray);
                num1 = (int) num3 * 1510237428 ^ -2137780259;
                continue;
              default:
                goto label_13;
            }
          }
        }
        finally
        {
          if (cryptoServiceProvider != null)
          {
label_8:
            int num1 = -4152401;
            while (true)
            {
              int num2 = -80378410;
              uint num3;
              switch ((num3 = (uint) (num1 ^ num2)) % 4U)
              {
                case 0:
                  goto label_8;
                case 1:
                  Encryption.StringCipher.\u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮((IDisposable) cryptoServiceProvider);
                  num1 = (int) num3 * 233924207 ^ -1052300181;
                  continue;
                case 2:
                  num1 = (int) num3 * -1875396478 ^ 1522836261;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
label_13:
        return numArray;
      }

      static Encoding \u202D⁫⁫‭⁬⁪‏⁮‫‭‏⁫⁯‬‎⁫‮‭⁪‭⁪⁪‌‬‭‌⁬⁫⁫‌‍⁬⁫⁫⁫‪⁭‪⁮‭‮()
      {
        return Encoding.UTF8;
      }

      static byte[] \u206B‎⁫⁪⁪⁬‬⁬‭‫‏⁭⁯⁪‬‌‫⁪‍⁯‭‪‏‍⁭⁪⁭‬‎‌‍⁯‫‮‌‫‫⁭⁪⁯‮([In] Encoding obj0, [In] string obj1)
      {
        return obj0.GetBytes(obj1);
      }

      static Rfc2898DeriveBytes \u200C⁬⁬​‭‎‌‌‍‏⁫‎⁭‏⁭⁭‮‫‭⁫​‎⁬⁯‏‎⁭‎⁫‬‮‌⁯‭⁯⁫​‍‬‭‮([In] string obj0, [In] byte[] obj1, [In] int obj2)
      {
        return new Rfc2898DeriveBytes(obj0, obj1, obj2);
      }

      static byte[] \u200B‬⁭‫‭‪‬‮⁬‬‎‍⁪‪⁬‭‌‭‮⁪‍⁯⁫‭‭⁯‬​⁮⁬‌‎‌‫‌‭⁬⁯⁭⁬‮([In] DeriveBytes obj0, [In] int obj1)
      {
        return obj0.GetBytes(obj1);
      }

      static RijndaelManaged \u202E​‪‭‏‪⁫‎‪⁭⁬‌‭⁯⁯‪⁮⁬‬‪‍‭‎⁮‎‌‏‏​⁭‍‮‏⁪‭‪⁪‪‪‮()
      {
        return new RijndaelManaged();
      }

      static void \u206C‬⁮⁪‬‎‬‭⁪‮⁪⁭‍‬⁭​‫‏⁫⁯‫‫⁭‫​⁪‎⁬‎‍‪‫‮‌‬‎‬‏‍⁯‮([In] SymmetricAlgorithm obj0, [In] int obj1)
      {
        obj0.BlockSize = obj1;
      }

      static void \u206E⁯⁯‎⁯‬‭⁫‫‮⁫⁮‪‭⁫‬‮‮⁯‬⁪‌‭⁯‎‪⁫‭‪⁭⁯‎‍‌‏‭⁫⁭⁪‪‮([In] SymmetricAlgorithm obj0, [In] CipherMode obj1)
      {
        obj0.Mode = obj1;
      }

      static void \u200F‭‎‪‌‭‎⁮⁪‮‏‮‬⁫‏‎‬‪‭⁭⁫⁪⁫⁮‮‌‮‭‪⁫‍⁫⁪‪⁬‪‬‫⁭‬‮([In] SymmetricAlgorithm obj0, [In] PaddingMode obj1)
      {
        obj0.Padding = obj1;
      }

      static ICryptoTransform \u200E⁭‬⁮‫‭​‎⁮‏⁬⁯‫‎‪‮‬⁮⁫‬⁮‏‌‭‎‌⁯​‏‎⁮‎​‮⁫⁭‌‮​‌‮([In] SymmetricAlgorithm obj0, [In] byte[] obj1, [In] byte[] obj2)
      {
        return obj0.CreateEncryptor(obj1, obj2);
      }

      static MemoryStream \u202B‮‌‪‌‭‮⁬‭‭‫‬⁮⁮‎‍‌⁪⁪‮⁬‏⁫‮‮⁮‮⁬‬⁯⁬‍⁯‏‪‏‏⁬‍‌‮()
      {
        return new MemoryStream();
      }

      static CryptoStream \u200B⁯‍‬​‏‭‪‪‫‍‍⁫⁯‎‭⁭‍‬‭⁫⁪‬‮‮⁭​⁬‪‎‎‫‏‬​⁭‫‏⁫⁮‮([In] Stream obj0, [In] ICryptoTransform obj1, [In] CryptoStreamMode obj2)
      {
        return new CryptoStream(obj0, obj1, obj2);
      }

      static void \u200B‫‎‮⁬‏‮‫‍​⁬‌⁮‏⁪‭‍‫‭⁬‬‭⁫‏‭‪‬‭‭‌⁭⁪‍‍⁯‫‪‍​⁯‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
      {
        obj0.Write(obj1, obj2, obj3);
      }

      static void \u206A‭⁪⁬‍‫⁪⁭​⁯⁭‏⁬‫‫‭​‎‍‏⁫‌⁯‍⁭‫⁮‮⁬‪⁫​⁪⁬‫⁮‪‬⁫⁬‮([In] CryptoStream obj0)
      {
        obj0.FlushFinalBlock();
      }

      static byte[] \u206B‍⁭⁭⁭‪‭⁫⁬⁭‍‪⁫‎⁫⁫⁭​⁯​‎‎⁯⁫⁪‎⁬‪⁪⁯⁭⁮‍‭‎‮‏⁭⁮‮‮([In] MemoryStream obj0)
      {
        return obj0.ToArray();
      }

      static void \u202E‌⁬‫⁭⁬‪​⁭⁬‌‏‌‪‫​‬⁪‬‌‫⁫‭⁮⁭​​‪‪‪‏⁬‫‍⁯‏‪⁯⁪⁪‮([In] Stream obj0)
      {
        obj0.Close();
      }

      static string \u202E‏‌‎⁯‭‌⁪‏‏⁪⁪‫⁫⁯‬‏⁫‎‎‫‎⁭‍‭‏‏‮⁭‪⁬⁮⁬⁬‮‎‍​⁪⁮‮([In] byte[] obj0)
      {
        return Convert.ToBase64String(obj0);
      }

      static void \u200F⁯‎⁬​‌⁯⁯⁮‮⁪‪⁯‌⁫‌⁭‪‪⁬⁪‫‌⁮‫⁪⁪⁭⁬‭⁫⁯‮‮⁭⁭⁬‫⁯‌‮([In] IDisposable obj0)
      {
        obj0.Dispose();
      }

      static byte[] \u206F⁭‪‪⁪⁮‎‮⁮‭⁭‮‏​⁭‭⁭‌⁮‏⁮‏‎‪‍⁯‬‏⁯‫‍‭⁮⁫‭⁯‫‭‬‮([In] string obj0)
      {
        return Convert.FromBase64String(obj0);
      }

      static ICryptoTransform \u202E‏⁪‌⁯‌‏⁯‪⁯‭‌‍⁪⁭⁬​‎⁪‬‎‫‍⁬‏‬⁭⁫‭⁯‪⁮‮​‮‌‫‏‌‮‮([In] SymmetricAlgorithm obj0, [In] byte[] obj1, [In] byte[] obj2)
      {
        return obj0.CreateDecryptor(obj1, obj2);
      }

      static MemoryStream \u206C⁪‫‪⁭⁯‌‫‬‭⁯⁮​⁫‮​‮⁪‏‌‌​‌‏⁮⁫⁭⁬⁭⁯‍‫‌‌⁪‏‎‪‏⁪‮([In] byte[] obj0)
      {
        return new MemoryStream(obj0);
      }

      static int \u200B‭⁯⁫‪‪‬‮‬‍‎‏‎​​‫‬‎⁮‎‪⁭‭‬‍⁭‌‪⁪⁯‏​⁮‌⁯⁭‪‌⁭‭‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
      {
        return obj0.Read(obj1, obj2, obj3);
      }

      static string \u206D‫‎⁪‌‍⁬⁭⁪‌‬⁮‍⁭​⁯‌‭‍⁯⁭‍⁪⁮⁮‏​‫⁬‏‍⁬‫⁮⁮‬‎‬‪⁯‮([In] Encoding obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
      {
        return obj0.GetString(obj1, obj2, obj3);
      }

      static RNGCryptoServiceProvider \u202C⁫​‪​‪‎‌‍‍‌⁮‏‭‪⁪⁪‫‭⁫⁫‎‍‫‎⁬‭‮⁮‏‬⁮‭⁬‮⁮‭⁮⁫‎‮()
      {
        return new RNGCryptoServiceProvider();
      }

      static void \u200C‭‎‬‌⁭⁪‏⁪⁯‮‌‫⁮‫‬‏‬‪‍⁭⁪‎‭‎⁮⁪‌‌‍‭‬⁬⁮⁫​⁪‍‎‏‮([In] RandomNumberGenerator obj0, [In] byte[] obj1)
      {
        obj0.GetBytes(obj1);
      }
    }
  }
}
