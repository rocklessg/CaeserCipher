using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipher
{
    public class Cipher
    {
        public static char CipherCharacters(char character, int key)
        {
            if (!char.IsLetter(character))
            {
                return character;
            }

            char letter = char.IsUpper(character) ? 'A' : 'a';
            char result = (char)((((character + key) - letter) % 26) + letter);
            return result;
        }
    }
}
