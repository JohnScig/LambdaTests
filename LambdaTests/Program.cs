using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTests
{
    class Program
    {

        public delegate string Encrypt(string plaintext);
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is the message to be encrypted");
            string plaintextMessage = Console.ReadLine();

            Console.WriteLine("What level of encryption do you want? (1-low, 2-medium, 3- high)");
            int encryptionLevel = Convert.ToInt32(Console.ReadLine());

            Encrypt encryptText;
            switch (encryptionLevel)
            {
                case 3:
                    encryptText = new Encrypt(Cypher.cypherHi);
                    break;
                case 2:
                    encryptText = new Encrypt(Cypher.cypherMed);
                    break;
                default:
                    encryptText = new Encrypt(Cypher.cypherLow);
                    break;
            }

            Console.WriteLine(encryptText.Invoke(plaintextMessage));
            Console.ReadLine();
        }

        public static string Cipher (string plainText, Encrypt encryption)
        {
            return encryption(plainText) + " " + DateTime.Now.ToString("HH:mm");
        }
    }
}
