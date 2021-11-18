using System.Collections.Generic;
using System.Linq;

namespace CS_Cypher_Example
{
    public partial class CharSet
    {
        /// <summary>
        /// The Characters that can be used in a text cipher
        /// </summary>
        private static readonly string CHARSET =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.?!@#$%^&*()_+=- \t\r\n";


        /// <summary>
        /// How many characters are in this CHARSET?
        /// Useful for Modulo Arthmetic!
        /// e.g.  int n = (Characters[ch] + 7) % Characters.Size
        /// </summary>
        public int Size => CHARSET.Length;
        
        /// <summary>
        /// Get the Index of a character in the CHARSET
        /// If the given character does not appear in the CHARSET, returns -1
        /// </summary>
        /// <param name="c">Character to search for</param>
        public int this[char c] => CHARSET.ToCharArray().Contains(c) ? CHARSET.IndexOf(c) : -1;
        
        /// <summary>
        /// Get the Character at position n in the CHARSET
        /// if n is not valid, returns default (possibly null).
        /// </summary>
        /// <param name="n">Character Number to get back</param>
        public char this[int n] => n >= 0 && n < CHARSET.Length ? CHARSET[n] : default;
    }
}