using System;
using System.Collections.Generic;

namespace CS_Cypher_Example
{
    internal class Program
    {
        private static CharSet Characters = new CharSet();
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Message:");
            string message = Console.ReadLine();
            
            Console.WriteLine("Here are the values!");
            foreach(char ch in message)
                Console.Write($"{Characters[ch]} ");

            Console.WriteLine();
            
            string encryptedMessage = CeaserCipherEncrypt(message, 17);
            Console.WriteLine($"Encrypted Text:  {encryptedMessage}");

            string decryptedMessage = CeaserCipherDecrypt(encryptedMessage, 17);
            Console.WriteLine($"Decrypted Encrypted Text: {decryptedMessage}");
        }

        /// <summary>
        /// Encrypt a message using a particular key for the Ceaser Cipher
        /// </summary>
        /// <param name="message">Message to Encrypt</param>
        /// <param name="key">Secret Number used in the Encryption step</param>
        /// <returns>Encrypted String</returns>
        public static string CeaserCipherEncrypt(string message, int key)
        {
            string output = "";
            foreach (char ch in message)
            {
                // try to look up the character number in the set.
                int characterNumber = Characters[ch];
                if (characterNumber != -1)
                {
                    characterNumber = (characterNumber + key) % Characters.Size;
                    output += Characters[characterNumber];
                }
                else
                {
                    output += ch;
                }
            }

            return output;
        }
        /// <summary>
        /// Decrypt a message using a particular key for the Ceaser Cipher
        /// </summary>
        /// <param name="encryptedMessage">Message to Decrypt</param>
        /// <param name="key">Secret Number used in the Encryption step</param>
        /// <returns>Encrypted String</returns>
        public static string CeaserCipherDecrypt(string encryptedMessage, int key)
        {
            string output = "";
            foreach (char ch in encryptedMessage)
            {
                // try to look up the character number in the set.
                int characterNumber = Characters[ch];
                if (characterNumber != -1)
                {
                    characterNumber = (characterNumber - key) % Characters.Size;
                    output += Characters[characterNumber];
                }
                else
                {
                    output += ch;
                }
            }

            return output;
        }
    }
}