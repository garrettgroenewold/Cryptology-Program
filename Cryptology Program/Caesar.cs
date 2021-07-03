using System;

namespace Cryptology_Program
{
    class Caesar : Cipher
    {
        
        // decribes cipher to user
        public static string Describe() 
        {
            return "A Caesar cipher, also known as a shift cipher, takes a line of text and shifts every letter through the alphabet by an equal amount."; // description of a Caesar cipher
        } 
        
        // takes a string (text)
        // turns the string into an array of characters
        // finds each character in that array in the "alphabet" array
        // shifts each character (shift) to a different index through addition
               
        public static string Encrypt(string text, int shift)
        {
            text = text.ToUpper(); // sets the string to upper case
            if (shift > 25) // checks if number to shift is greater than 25
            {
                shift = shift % 26; // if "shift" is greater than 25, will set "shift" to equal modulo
            }
            char[] encryptedTextArray = new char[text.Length]; // creates an empty array to store encrypted characters.
            string encryptedText; // finished string. All characters will be shifted to new alphabet position
            int newIndex; // initializes variable to store the desired index of "alphabet" array
            char[] textArray = text.ToCharArray(); // changes string to array of characters
            int workingIndex = 0; // variable to keep track of the index of each character
            
            foreach (char character in textArray)
            {
                if (Char.IsLetter(character) == true) // checks if the character is in the alphabet
                {
                    int characterIndex = Array.IndexOf(alphabet, character); // takes the index of the character in the "alphabet" array
                    newIndex = characterIndex + shift; // shifts index by specified amount
                    
                    if (newIndex > 25) // check if the new index is within the bounds of the alphabet array
                    {
                        newIndex = newIndex % 26; // if "newIndex" is greater than 25, sets "newIndex" to modulo of 26
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
        
        // this is a reverse of the Encrypt method
        public static string Decrypt(string text, int shift)
        {
            text = text.ToUpper(); // sets the string to upper case
            if (shift > 25) // checks if number to shift is greater than 25
            {
                shift = shift % 26; // if "shift" is greater than 25, will set "shift" to equal modulo
            }

            char[] decryptedTextArray = new char[text.Length]; // creates an empty array to store encrypted characters.
            string decryptedText; // finished string. All characters will be shifted to new alphabet position
            int newIndex; // initializes variable to store the desired index of "alphabet" array
            char[] textArray = text.ToCharArray(); // changes string to array of characters
            int workingIndex = 0; // variable to keep track of the index of each character
            
            foreach (char character in textArray)
            {
                
                                
                if (Char.IsLetter(character) == true)
                {
                    int characterIndex = Array.IndexOf(alphabet, character); // takes the index of the character in the "alphabet array
                    //Console.WriteLine(characterIndex);
                    newIndex = characterIndex - shift; // shifts index by specified amount
                    
                    if (newIndex < 0) // check if the new index is within the bounds of the alphabet array
                    {
                        newIndex = newIndex + 26; // if "newIndex" is less than zero, adds 26 to "newIndex"
                    }

                    decryptedTextArray[workingIndex] = alphabet[newIndex]; // sets corresponding location in new array to new character
                }

                else
                {
                    decryptedTextArray[workingIndex] = character; // saves character as is to encryptedTextArray if it is not in the alphabet
                }

                workingIndex++; // iterates the index being worked on up by one

            }
             
             decryptedText = string.Join("", decryptedTextArray); // joins finish array into a string


            return decryptedText; // returns finished string
        }
    }
}