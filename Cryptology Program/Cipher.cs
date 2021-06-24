using System;

namespace Cryptology_Program
{
    abstract class Cipher
    {
        // Alphabet to be utilized by ciphers
        public static char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        

        // Each cipher will have a seperate encryption method
        // Returned string will be encrypted text
        // Each cipher should also have a Decrypt method
        // Decrypt should be reverse of Encrypt method
        // Returned string should be plain readable text
    }
}