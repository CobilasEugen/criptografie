using System;
using System.Collections.Generic;
using System.Text;

using System.Security.Cryptography;

namespace CriptoWF
{
    class Aes
    {
        private readonly AesManaged aes = new AesManaged();
        private readonly System.Text.UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

        private const int CHUNK_SIZE = 128;

        public Aes(CipherMode mode = CipherMode.CBC, PaddingMode padding = PaddingMode.PKCS7)
        {

            aes.KeySize = CHUNK_SIZE;
            aes.BlockSize = CHUNK_SIZE;

            aes.Mode = mode;
            aes.Padding = padding;

            aes.GenerateKey();
            aes.GenerateIV();
        }

        public Aes(byte[] key, byte[] iv, CipherMode mode = CipherMode.CBC, PaddingMode padding = PaddingMode.PKCS7)
        {
            aes.Mode = mode;
            aes.Padding = padding;
            aes.Key = key;
            aes.IV = iv;
        }

        public string Decrypt(byte[] cipher)
        {
            ICryptoTransform transform = aes.CreateDecryptor();
            byte[] decryptedValue = transform.TransformFinalBlock(cipher, 0, cipher.Length);
            return unicodeEncoding.GetString(decryptedValue);
        }     
        public byte[] EncryptToByte(string plain)
        {
            ICryptoTransform encryptor = aes.CreateEncryptor();
            byte[] cipher = unicodeEncoding.GetBytes(plain);
            byte[] encryptedValue = encryptor.TransformFinalBlock(cipher, 0, cipher.Length);
            return encryptedValue;
        }
        public string GetKey()
        {
            return Convert.ToBase64String(aes.Key);
        }

        public string GetIV()
        {
            return Convert.ToBase64String(aes.IV);
        }

        public override string ToString()
        {
            return "KEY:" + GetKey() + Environment.NewLine + "IV:" + GetIV();
        }
    }
}
