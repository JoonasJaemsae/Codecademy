using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program asks the user for a string and encrypts it with Caesar Cipher
            by replacing each alphabetical character with one that is three places
            ahead in the alphabet. After 'z', the selection loops back to the beginning to 'a'.
            */
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 
                'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter a message you'd like to encrypt:");
            string msgString = Console.ReadLine().ToLower();

            char[] secretMessage = msgString.ToCharArray();
            int arrayLength = secretMessage.Length;
            char[] encryptedMessage = new char[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                char character = secretMessage[i];
                /*
                If the character is not part of the alphabet, we skip it
                and move onto the next letter.
                */
                if (!Array.Exists(alphabet, toFind => toFind == character))
                {
                    continue;
                }
                int letterPosition = Array.IndexOf(alphabet, character);
                /*
                The modulo helps the alphabet loop around
                back to the beginning after 'z'.
                */
                letterPosition = (letterPosition + 3) % 26;
                char encryptedChar = alphabet[letterPosition];
                encryptedMessage[i] = encryptedChar;
            }
            string encryptedString = String.Join("", encryptedMessage);
            Console.WriteLine(encryptedString);
            Console.ReadLine();
        }
    }
}
