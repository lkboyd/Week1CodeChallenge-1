using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge___Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Do FizzBuzz Loop 1=>20
            for (var i = 1; i <= 20; i++)
            {
                // Call FizzBuzz() for each number in the loop
                FizzBuzz(i);

            }   // End FizzBuzzLoop 1=>20
            */


            /*
            // Do FizzBuzz Loop 92=>79
            for (int i = 92; i >= 79; i--)
            {
                // Call FizzBuzz() for each number in the loop
                FizzBuzz(i);
            }   // End FizzBuzzLoop 92=>79
            */


            /*
            //Call Yodaizer Function with the text "I like code"
            Yodaizer("I like code");
            */


            /*
            //Call TextStats Function with the text "Coding is super fun and useful.  This function requires the use of 
            //arrays, loops, indexes, and if statements. There was a lot of thought that went into this code."          
            TextStats("Coding is super fun and useful. This function requires the use of arrays, loops, indexes, and if statements. There was a lot of thought that went into this code.");
            */
              
             /*
            //Call IsPrime Function
            // Do IsPrime Loop 1=>25
            for (var i = 1; i <= 25; i++)
            {
                // Call IsPrime() for each number in the loop
                IsPrime(i);
            }   // End IsPrime Loop 1=>25
            */

            /*
            //Call DashInsert Function with the number 8675309
            DashInsert(8675309);
            */


            //Console.ReadKey() to keep the console window open until we close it.
            Console.ReadKey();
        }

        //FizzBuzz
        static void FizzBuzz(int number)
        {
            //If statement checking for zeroes since they will always have a remainder of 0 when '%' is used
            if (number == 0)
            {
                //Print zero
                Console.WriteLine(number);
            }
            //Else if statement checking if number is divisible by 3 AND 5
            else if (number % 5 == 0 && number % 3 == 0)
            {
                //Print FizzBuzz
                Console.WriteLine("FizzBuzz");
            }
            //Else if statement checking for divisibility by 3
            else if (number % 3 == 0)
            {
                //Print Buzz
                Console.WriteLine("Buzz");
            }
            //Else if statement checking for divisibility by 5
            else if (number % 5 == 0)
            {
                //Print Fizz
                Console.WriteLine("Fizz");
            }
            //Else statement leaving all numbers not divisible by 3 or 5
            else
            {
                //Print number
                Console.WriteLine(number);
            }
        }

        //Yodaizer
        static void Yodaizer(string text)
        {
            //Convert 'text' parameter into an array of individual words
            string[] yodaArray = text.Split(' ');

            //If statement checking for 3 words
            if (yodaArray.Length == 3)
            {
                //print last word, comma, then first two words with appropriate spaces
                Console.Write(yodaArray[2] + ", " + yodaArray[0] + " " + yodaArray[1]);
            }
            //else statement for sentences with more or less than three words
            else
            {
                //for loop that will cycle backwards from the last index of the new array
                for (int i = yodaArray.Length - 1; i >= 0; i--)
                {
                    //print out each word from the array backwards
                    Console.Write(yodaArray[i] + " ");
                }
            }
        }

        //Text Stats
        static void TextStats(string input)
        {
            //declare variables for # of characters, words, vowels, consonants, and special characters
            var characters = input.Length;
            string[] wordsArray = input.Split(' ');
            var words = wordsArray.Length;
            var vowels = 0;
            var consonants = 0;
            var miscCharacters = 0;

            //For loop that will cycle through all characters of a string
            for (int i = 0; i < input.Length; i++)
            {
                //If statement checking for vowels
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    //add one to vowels count when a character is a vowel
                    vowels = vowels + 1;
                }

                //else if statement checking for consonants
                else if (input[i] == 'b' || input[i] == 'c' || input[i] == 'd' || input[i] == 'e' || input[i] == 'f' || input[i] == 'g' || input[i] == 'h' || input[i] == 'j' || input[i] == 'k' || input[i] == 'l' || input[i] == 'i' || input[i] == 'm' || input[i] == 'n' || input[i] == 'p' || input[i] == 'q' || input[i] == 'r' || input[i] == 's' || input[i] == 't' || input[i] == 'v' || input[i] == 'w' || input[i] == 'x' || input[i] == 'y' || input[i] == 'z')
                {
                    //add one to consonants count when a character is a consonant
                    consonants = consonants + 1;
                }
                else
                {
                    //add one to special characters count if character is neither a vowel or consonant
                    miscCharacters = miscCharacters + 1;
                }
            }

            //declare variables for longest word, second longest word, and shortest word
            var longestWord = "";
            var secondLongestWord = "";
            var shortestWord = "thisstringiswaylongerthantheshortestwordwillbe";

            //Cycle through every word in wordsArray
            for (int i = 0; i < wordsArray.Length; i++)
            {
                //declare variable for current word
                var currentWord = wordsArray[i];

                //Check to see if current word is longer than longest word
                if (currentWord.Length > longestWord.Length)
                {
                    //set secondLongestWord to the string of the previous longest word
                    secondLongestWord = longestWord;

                    //set longest word to current word
                    longestWord = currentWord;
                }
                //else if checking if current word is shorter than shortest word
                else if (currentWord.Length < shortestWord.Length)
                {
                    //set shortest word to current word
                    shortestWord = currentWord;
                }
            }


            //print out all of the values
            Console.WriteLine("Number of characters: " + characters);
            Console.WriteLine("Number of words: " + words);
            Console.WriteLine("Number of vowels: " + vowels);
            Console.WriteLine("Number of consonants: " + consonants);
            Console.WriteLine("Number of special characters: " + miscCharacters);
            Console.WriteLine("Longest word: " + longestWord);
            Console.WriteLine("Second longest word: " + secondLongestWord);
            Console.WriteLine("Shortest word: " + shortestWord);
        }

        //IsPrime
        static void IsPrime(int number)
        {
            bool prime = true;
            //for loop that will cycle through all numbers BETWEEN 1 and number passed through parameter
            for (var i = 2; i < number; i++)
            {
                //see if number is divisible by any number between
                if (number % i == 0)
                {
                    //if composite condition is met return prime = false and break loop
                    prime = false;
                    break;
                }
            }
            if (prime == false)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(number + " is a prime number!");
            }
        }

        //DashInsert
        static void DashInsert(int number)
        {
            //Convert and store number into string
            var numberString = number.ToString();

            //Print first number
            Console.Write(numberString[0]);

            //
            for (var i = 1; i < numberString.Length; i++)
            {
                if (Convert.ToInt32(numberString[i]) % 2 != 0)
                {
                    if (Convert.ToInt32(numberString[i - 1]) % 2 != 0)
                    {
                        Console.Write("-" + numberString[i]);
                    }
                    else { Console.Write(numberString[i]); }
                }
                else { Console.Write(numberString[i]); }
            }
        }

    }
}
