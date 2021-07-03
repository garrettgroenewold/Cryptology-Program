using System;

namespace Cryptology_Program
{
    class Atbash : Cipher
    {
        // describes cipher to user
        public static string Describe()
        {
            return "An Atbash cipher, also known as a mirror cipher, takes a line of text and mirrors each letter in the alphabet, so a becomes z, b becomes y etc.";
        }

        // takes a string (text)
        // turns the string into an array of characters
        // finds each character in that array in the "alphabet" array
        // flips each character in the "alphabet array
        public static string Mirror(string text)
        {
            text = text.ToUpper(); // sets the string to upper case
            char[] encryptedTextArray = new char[text.Length]; // creates an empty array to store encrypted characters.
            string encryptedText; // finished string. all characters will be mirrored in alphabet
            int newIndex; // initializes variable to store the desired index of "alphabet" array
            char[] textArray = text.ToCharArray(); // changes string to array of characters
            int workingIndex = 0; // variable to keep track of the index of each character

            foreach (char character in textArray)
            {
                if (Char.IsLetter(character) == true) // checks if the character is in the alphabet
                {
                    int characterIndex = Array.IndexOf(alphabet, character); // takes the index of the character in the "alphabet" array
                    
                    if (characterIndex <= 12) // checks if character is at or before 12th index of the "alphabet" array
                    {
                        newIndex = (((12 - characterIndex) * 2) + 1) + characterIndex; // flips character through alphabet
                    }

                    else
                    {
                        newIndex = (characterIndex - (((characterIndex - 13) * 2) + 1)); // flips character through alphabet
                    }

                    encryptedTextArray[workingIndex] = alphabet[newIndex]; // sets corresponding location in new array to new character
                }

                else 
                {
                    encryptedTextArray[workingIndex] = character; // saves character as is to encryptedTextArray if it is not in the alphabet
                }

                workingIndex++; // iterates the index being worked on up by one
            }
            encryptedText = string.Join("", encryptedTextArray); // joins finish array into a string


            return encryptedText; // returns finished string
        }
    }
}