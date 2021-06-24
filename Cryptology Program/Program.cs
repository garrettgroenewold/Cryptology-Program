using System;

namespace Cryptology_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CipherSelect();
        }

        
        static void ListCiphers()
        {
            string[] ciphers = {"Caesar"}; // array of ciphers
            Console.WriteLine("Your options are:");
                foreach (string cipher in ciphers)
                {
                    Console.WriteLine(cipher);
                }

        }
        static void CipherSelect()
        {
            Console.WriteLine("Hello! Welcome to my cryptology program. With this you'll be able to take text and encrypt or decrypt it based off of different ciphers.\nPress ENTER to continue."); // welcomes user and explains the program
            Console.ReadLine(); // pauses program, waiting for user to continue
            
            string[] ciphers = {"Caesar"}; // array of ciphers

            Console.WriteLine("Would you like to encrypt or decrypt text? "); // asks user what they would like to do
            
            string response = Console.ReadLine(); // saves user input as a variable
            response = response.ToLower(); // sets response to lowercase
            
            while (response != "encrypt" && response != "decrypt") // checks if user input is valid option
            {
                Console.WriteLine("Please type \"encrypt\" or \"decrypt.\" "); // prints error message

                response = Console.ReadLine(); // saves user input
            }
            
            if (response == "encrypt")
            {
                Console.WriteLine("What cipher would you like to use? Type \"list\" if you would like to see your options. "); // asks user which cipher they would like to use.

                string encryptOption = Console.ReadLine(); // saves input as a variable

                encryptOption = encryptOption.ToLower(); // sets user response to lowercase
                encryptOption = char.ToUpper(encryptOption[0]) + encryptOption.Substring(1); // sets first letter in string to uppercase. I did this for aesthetic
                
                if (encryptOption == "List")
                {
                    ListCiphers();

                    Console.WriteLine("Which cipher would you like to use?"); // asks user for choice
                    encryptOption = Console.ReadLine(); // saves user input
                    encryptOption = char.ToUpper(encryptOption[0]) + encryptOption.Substring(1); // sets first letter in string to uppercase.
                }
                bool isCipherOption = Array.Exists(ciphers, input => input == encryptOption); // checks if user choice is in "ciphers" array

                while (isCipherOption == false)
                {
                    Console.WriteLine("Please enter one of the offered ciphers. Type \"list\" if you need to see your options."); // prints error message
                    encryptOption = Console.ReadLine(); // saves user input
                    encryptOption = encryptOption.ToLower(); // sets string to lower case
                    encryptOption = char.ToUpper(encryptOption[0]) + encryptOption.Substring(1); // sets first letter in string to uppercase.
                    
                    if (encryptOption == "list")
                    {
                        ListCiphers();

                        Console.WriteLine("Which cipher would you like to use?"); // ask user for choice
                        encryptOption = Console.ReadLine(); // saves user input
                        encryptOption = encryptOption.ToLower(); // sets user response to lowercase
                        encryptOption = char.ToUpper(encryptOption[0]) + encryptOption.Substring(1); // sets first letter in string to uppercase.
                        
                    }
                    
                    isCipherOption = Array.Exists(ciphers, input => input == encryptOption); // checks if user choice is in "ciphers" array
                }
                
                switch (encryptOption)
                {
                    case "Caesar":

                        string text; // initializes variable for text
                        int shift; // initializes variable for number to shift by

                        Console.WriteLine("Do you need a description of Caesar ciphers? "); // asks user if they would like a description of the cipher
                        string answer = Console.ReadLine(); // saves user input
                        answer = answer.ToLower(); // sets input to lower case

                        while (answer != "yes" && answer != "no") // makes sure user input "yes" or "no"
                        {
                            Console.WriteLine("Please answer \"yes\" or \"no.\""); // gives user error message
                            answer = Console.ReadLine(); // saves user input
                        }
                        if (answer == "yes") // checks if user answered "yes"
                        {
                            Console.WriteLine(Caesar.Describe()); // describes cipher to user
                        }
                    
                        Console.WriteLine("What is the text you would like to encrypt? Please check the text for typos."); // asks user for text
                        text = Console.ReadLine(); // saves user input

                        Console.WriteLine("What number would you like to shift by?"); // asks user for number
                        string userNumber = Console.ReadLine(); // saves user input
                        bool checkIfNumber = Int32.TryParse(userNumber, out shift); // changes user input to string if possible
                    
                        while (checkIfNumber == false)
                        {
                            Console.WriteLine("Please enter a number.");
                        
                            userNumber = Console.ReadLine(); // saves user input
                            checkIfNumber = Int32.TryParse(userNumber, out shift); // changes user input to string if possible
                        }
                        
                        Console.WriteLine(Caesar.Encrypt(text, shift)); // runs encryption

                        break;


                }
            }

            else
            {
                Console.WriteLine("What cipher would you like to use? Type \"list\" if you would like to see your options. "); // asks user which cipher they would like to use.

                string decryptOption = Console.ReadLine(); // saves input as a variable

                decryptOption = decryptOption.ToLower(); // sets user response to lowercase
                decryptOption = char.ToUpper(decryptOption[0]) + decryptOption.Substring(1); // sets first letter in string to uppercase. I did this for aesthetic
                
                if (decryptOption == "List")
                {
                    ListCiphers();

                    Console.WriteLine("Which cipher would you like to use?"); // asks user for choice
                    decryptOption = Console.ReadLine(); // saves user input
                    decryptOption = char.ToUpper(decryptOption[0]) + decryptOption.Substring(1); // sets first letter in string to uppercase.
                }
                bool isCipherOption = Array.Exists(ciphers, input => input == decryptOption); // checks if user choice is in "ciphers" array

                while (isCipherOption == false)
                {
                    Console.WriteLine("Please enter one of the offered ciphers. Type \"list\" if you need to see your options."); // prints error message
                    decryptOption = Console.ReadLine(); // saves user input
                    decryptOption = decryptOption.ToLower(); // sets string to lower case
                    decryptOption = char.ToUpper(decryptOption[0]) + decryptOption.Substring(1); // sets first letter in string to uppercase.
                    
                    if (decryptOption == "list")
                    {
                        ListCiphers();

                        Console.WriteLine("Which cipher would you like to use?"); // ask user for choice
                        decryptOption = Console.ReadLine(); // saves user input
                        decryptOption = decryptOption.ToLower(); // sets user response to lowercase
                        decryptOption = char.ToUpper(decryptOption[0]) + decryptOption.Substring(1); // sets first letter in string to uppercase.
                        
                    }
                    
                    isCipherOption = Array.Exists(ciphers, input => input == decryptOption); // checks if user choice is in "ciphers" array
                }
                
                switch (decryptOption)
                {
                    case "Caesar":

                        string text; // initializes variable for text
                        int shift; // initializes variable for number to shift by

                        Console.WriteLine("Do you need a description of Caesar ciphers? "); // asks user if they would like a description of the cipher
                        string answer = Console.ReadLine(); // saves user input
                        answer = answer.ToLower(); // sets input to lower case

                        while (answer != "yes" && answer != "no") // makes sure user input "yes" or "no"
                        {
                            Console.WriteLine("Please answer \"yes\" or \"no.\""); // gives user error message
                            answer = Console.ReadLine(); // saves user input
                        }
                        if (answer == "yes") // checks if user answered "yes"
                        {
                            Console.WriteLine(Caesar.Describe()); // describes cipher to user
                        }
                    
                        Console.WriteLine("What is the text you would like to decrypt? Please check the text for typos."); // asks user for text
                        text = Console.ReadLine(); // saves user input

                        Console.WriteLine("What number would you like to shift by?"); // asks user for number
                        string userNumber = Console.ReadLine(); // saves user input
                        bool checkIfNumber = Int32.TryParse(userNumber, out shift); // changes user input to string if possible
                    
                        while (checkIfNumber == false)
                        {
                            Console.WriteLine("Please enter a number.");
                        
                            userNumber = Console.ReadLine(); // saves user input
                            checkIfNumber = Int32.TryParse(userNumber, out shift); // changes user input to string if possible
                        }
                        
                        Console.WriteLine(Caesar.Decrypt(text, shift)); // runs decryption

                        break;


                }
            }
        }
    }
}
