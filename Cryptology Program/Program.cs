using System;

namespace Cryptology_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CipherSelect();
        }

        // lists ciphers for user
        static void ListCiphers()
        {
            string[] ciphers = {"Caesar", "Atbash"}; // array of ciphers - if a cypher ISN'T in this array, user will be thrown an error if they try to use it
            Console.WriteLine("Your options are:");
                foreach (string cipher in ciphers)
                {
                    Console.WriteLine(cipher);
                }

        }

        // asks user which ciphers they would like described
        // prints description of cipher
        // loops until user says they don't need any more descriptions
        static void Description()
        {
            string[] ciphers = {"Caesar", "Atbash"}; // array of ciphers - if a cypher ISN'T in this array, user will be thrown an error if they try to use it

            string moreDescriptions = "";
            do
            {                
                Console.WriteLine("Which cipher would you like a description of? "); // describes cipher to user
                string descriptionResponse = Console.ReadLine(); // reads user input
                descriptionResponse = descriptionResponse.ToLower(); // sets user input to lower case
                descriptionResponse = char.ToUpper(descriptionResponse[0]) + descriptionResponse.Substring(1); // sets first character in string to uppercase

                bool isItCipher = Array.Exists(ciphers, input => input == descriptionResponse); // checks if user choice is in "ciphers" array

                while (isItCipher == false)
                {
                    Console.WriteLine("Please enter one of the offered ciphers."); // prints error message
                    descriptionResponse = Console.ReadLine(); // saves user input
                    descriptionResponse = descriptionResponse.ToLower(); // sets string to lower case
                    descriptionResponse = char.ToUpper(descriptionResponse[0]) + descriptionResponse.Substring(1); // sets first letter in string to uppercase

                    isItCipher = Array.Exists(ciphers, input => input == descriptionResponse); // checks if user choice is in "ciphers" array
                }

                switch (descriptionResponse)
                {
                    case "Caesar":
                    
                        Console.WriteLine(Caesar.Describe()); // prints description of Caesar Cipher

                        break;
                    
                    case "Atbash":

                        Console.WriteLine(Atbash.Describe()); // prints description of Atbash Cipher

                        break;

                }

                Console.WriteLine("Do you need a description of any other cyphers "); // asks user if they'd like more cipher descriptions
                moreDescriptions = Console.ReadLine(); // reads user input
                while (moreDescriptions != "yes" && moreDescriptions != "no") // makes sure user input "yes" or "no"
                {
                    Console.WriteLine("Please answer \"yes\" or \"no.\""); // gives user error message
                    moreDescriptions = Console.ReadLine(); // saves user input
                    moreDescriptions = moreDescriptions.ToLower(); // sets input to lower case
                }
                        
            } while (moreDescriptions == "yes");
        }
        static void CipherSelect()
        {
            Console.WriteLine("Hello! Welcome to my cryptology program. With this you'll be able to take text and encrypt or decrypt it based off of different ciphers.\nPress ENTER to continue."); // welcomes user and explains the program
            Console.ReadLine(); // pauses program, waiting for user to continue
            
            
            string[] ciphers = {"Caesar", "Atbash"}; // array of ciphers

            Console.WriteLine("Would you like to encrypt or decrypt text? "); // asks user what they would like to do
            
            string response = Console.ReadLine(); // saves user input as a variable
            response = response.ToLower(); // sets response to lowercase
            
            while (response != "encrypt" && response != "decrypt") // checks if user input is valid option
            {
                Console.WriteLine("Please type \"encrypt\" or \"decrypt.\" "); // prints error message

                response = Console.ReadLine(); // saves user input
                response = response.ToLower(); // sets response to lowercase
            }

            string text; // initializes variable for text
            
            if ( response == "encrypt")
            {
                Console.WriteLine("Please enter the text you would like to encrypt. Please check the text for typos. "); // asks user for text
                text = Console.ReadLine(); // saves user input
            }

            else
            {
                Console.WriteLine("Please enter the text you would like to decrypt. Please check the text for typos. "); // asks user for text
                text = Console.ReadLine(); // saves user input
            }

            string continueResponse = ""; // initializes variable for response if user would like to continue using program
            
            do
            {
                Console.WriteLine("What cipher would you like to use? Type \"list\" if you would like to see your options. "); // asks user which cipher they would like to use.

                string cipherOption = Console.ReadLine(); // saves input as a variable

                cipherOption = cipherOption.ToLower(); // sets user response to lowercase
                cipherOption = char.ToUpper(cipherOption[0]) + cipherOption.Substring(1); // sets first letter in string to uppercase. I did this for aesthetic
                
                if (cipherOption == "List")
                {
                    ListCiphers();

                    Console.WriteLine("Do you need a description of any of the ciphers? "); // asks user if they need any ciphers described

                    string answer = Console.ReadLine(); // saves user input
                    answer = answer.ToLower(); // sets input to lower case

                    while (answer != "yes" && answer != "no") // makes sure user input "yes" or "no"
                    {
                        Console.WriteLine("Please answer \"yes\" or \"no.\""); // gives user error message
                        answer = Console.ReadLine(); // saves user input
                        answer = answer.ToLower(); // sets input to lower case
                    }
                    if (answer == "yes") // checks if user answered "yes"
                    {
                        Description(); // runs description method
                    }                    

                    Console.WriteLine("Which cipher would you like to use?"); // asks user for choice
                    cipherOption = Console.ReadLine(); // saves user input
                    cipherOption = cipherOption.ToLower();
                    cipherOption = char.ToUpper(cipherOption[0]) + cipherOption.Substring(1); // sets first letter in string to uppercase.
                }
                bool isCipherOption = Array.Exists(ciphers, input => input == cipherOption); // checks if user choice is in "ciphers" array

                while (isCipherOption == false)
                {
                    Console.WriteLine("Please enter one of the offered ciphers. Type \"list\" if you need to see your options."); // prints error message
                    cipherOption = Console.ReadLine(); // saves user input
                    cipherOption = cipherOption.ToLower(); // sets string to lower case
                    cipherOption = char.ToUpper(cipherOption[0]) + cipherOption.Substring(1); // sets first letter in string to uppercase.
                    
                    if (cipherOption == "list")
                    {
                        ListCiphers();

                        Console.WriteLine("Do you need a description of any of the ciphers? "); // asks user if they need any ciphers described

                    string answer = Console.ReadLine(); // saves user input
                    answer = answer.ToLower(); // sets input to lower case

                    while (answer != "yes" && answer != "no") // makes sure user input "yes" or "no"
                    {
                        Console.WriteLine("Please answer \"yes\" or \"no.\""); // gives user error message
                        answer = Console.ReadLine(); // saves user input
                        answer = answer.ToLower(); // sets input to lower case
                    }
                    if (answer == "yes") // checks if user answered "yes"
                    {
                        Description(); // runs description method
                    }

                        Console.WriteLine("Which cipher would you like to use?"); // ask user for choice
                        cipherOption = Console.ReadLine(); // saves user input
                        cipherOption = cipherOption.ToLower(); // sets user response to lowercase
                        cipherOption = char.ToUpper(cipherOption[0]) + cipherOption.Substring(1); // sets first letter in string to uppercase.
                        isCipherOption = Array.Exists(ciphers, input => input == cipherOption); // checks if user choice is in "ciphers" array
                    }
                    
                    
                }
                
                switch (cipherOption)
                {
                    case "Caesar":

                        int shift; // initializes variable for number to shift by                    

                        Console.WriteLine("What number would you like to shift by?"); // asks user for number
                        string userNumber = Console.ReadLine(); // saves user input
                        bool checkIfNumber = Int32.TryParse(userNumber, out shift); // changes user input to string if possible
                    
                        while (checkIfNumber == false)
                        {
                            Console.WriteLine("Please enter a number.");
                        
                            userNumber = Console.ReadLine(); // saves user input
                            checkIfNumber = Int32.TryParse(userNumber, out shift); // changes user input to string if possible
                        }
                        
                        if (response == "encrypt")
                        {
                            text = Caesar.Encrypt(text, shift); // runs encryption
                            Console.WriteLine(text); // prints encrypted text
                        }

                        else
                        {
                            text = Caesar.Decrypt(text, shift); // runs encryption
                            Console.WriteLine(text); // prints encrypted text
                        }
                        
                        break;

                    case "Atbash":

                        text = Atbash.Mirror(text); // runs Mirror method to encrypt or decrypt the text
                        Console.WriteLine(text); // prints encrypted decrypted text

                        break;


                    

                    
                   

                }
                Console.WriteLine("Would you like to run the text through another cipher? "); // asks user if they would like to run through the program with a different cipher
                continueResponse = Console.ReadLine(); // reads user input
                continueResponse = continueResponse.ToLower(); // changes user input to lower case

                while (continueResponse != "yes" && continueResponse != "no")
                {
                    Console.WriteLine("Please enter \"yes\" or \"no\" ");
                    continueResponse = Console.ReadLine(); // reads user input
                    continueResponse = continueResponse.ToLower(); // changes user input to lower case
                }
            } while (continueResponse == "yes");   
        }
    }
}
