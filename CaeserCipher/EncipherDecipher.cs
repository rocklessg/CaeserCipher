using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipher
{
    public class EncipherDecipher
    {
        public static string Encrypt(string input, int key)
        {
            string output = string.Empty;

            foreach (char character in input)
                output += Cipher.CipherCharacters(character, key);

            return output;

        }


        public static string Decrypt(string input, int key)
        {
            return Encrypt(input, 26 - key);
        }
    }
}
