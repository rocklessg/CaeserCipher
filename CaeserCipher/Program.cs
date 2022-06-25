using System;

namespace CaeserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Enter your Key");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = EncipherDecipher.Encrypt(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = EncipherDecipher.Decrypt(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");




            Console.ReadKey();
        }
    }
}

//Julius Caesar protected his confidential information by encrypting it using a cipher.
//Caesar 's cipher shifts each letter by a number of letters. If the shift takes you
//past the end of the alphabet, just rotate back to the front of the alphabet.
//In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.

//Original alphabet:      abcdefghijklmnopqrstuvwxyz
//Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc
//Example


//The alphabet is rotated by , matching the mapping above. The encrypted string is .

//Note: The cipher only encrypts letters; symbols, such as -, remain unencrypted.

//Function Description

//Complete the caesarCipher function in the editor below.

//caesarCipher has the following parameter(s):

//string s: cleartext
//int k: the alphabet rotation factor
//Returns

//string: the encrypted string
//Input Format

//The first line contains the integer, , the length of the unencrypted string.
//The second line contains the unencrypted string, .
//The third line contains, the number of letters to rotate the alphabet by.

//Constraints



// is a valid ASCII string without any spaces.

//Sample Input

//11
//middle-Outz
//2
//Sample Output

//okffng-Qwvb
//Explanation

//Original alphabet:      abcdefghijklmnopqrstuvwxyz
//Alphabet rotated +2:    cdefghijklmnopqrstuvwxyzab

//m -> o
//i -> k
//d -> f
//d -> f
//l -> n
//e -> g
//-    -
//O -> Q
//u -> w
//t -> v
//z -> b
