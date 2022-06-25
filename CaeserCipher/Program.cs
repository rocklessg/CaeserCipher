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
