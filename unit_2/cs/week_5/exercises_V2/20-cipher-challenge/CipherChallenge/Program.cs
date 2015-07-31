/******************** Summary *************************
Exercise: Refactor the Martian Cypher Challenge

This exercise is presented in the format of a working console app. You will be familiar with console apps from the Microsoft Virtual Academy Videos. 

Console apps must always have a project assigend as the starting project and that project must have a static void Main method in one of the classes.

Static will be covered in more depth later. In short it means the Main method does not belong to a specific object and can be called without instantiation. 
That sounds very cryptic - so just roll with it for now and expect to see it in every Console App.
*******************************************************/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CipherChallenge
{
   public class Program
    {
        // The static void main is the starting point of any Console App. ie we have to have one.
        private static void Main(string[] args)
        {
            // Here an instance of the cipher class is created (right of the =) and assigned to a variable of the same type that is called cipher.
            CipherChallengeClass cipher = new CipherChallengeClass();

            Console.WriteLine(cipher.MartianCipher("ger^wsqifshc*nywx^kix^qi&10000*fekw@sj$gssp%vergl@hsvmxsw?"));

            Console.WriteLine("Click [Enter] to exit");
            Console.ReadLine();
        }
    }

    public class CipherChallengeClass
    {
        // RUN THE CODE BEFORE YOU MAKE ANY CHANGES.
        // What if the code doesn't even work? (It does, but you should still always run it before making changes)!
        // HINTS:
        //   If you do not understand what a line of code is doing. Go into the console and try to figure out how it works.
        //   Use Console.WriteLine statements to track what your program is doing at each step. See line 89 for an example.

        public String MartianCipher(String codedMessage)
        {
            // Check out this method in the console to see how it works! Also refer to the documentation.
            var input = codedMessage.ToLower().ToCharArray();
            var decodedLetters = new List<Char>();

            var cipher = new Dictionary<Char, Char>
            {
                // This is technically a shift of four letters...Can you think of a way to automate this? Is a Dictionary
                // the best data structure for this problem? What are the pros and cons of Dictionaries?
                {'e', 'a'},
                {'f', 'b'},
                {'g', 'c'},
                {'h', 'd'},
                {'i', 'e'},
                {'j', 'f'},
                {'k', 'g'},
                {'l', 'h'},
                {'m', 'i'},
                {'n', 'j'},
                {'o', 'k'},
                {'p', 'l'},
                {'q', 'm'},
                {'r', 'n'},
                {'s', 'o'},
                {'t', 'p'},
                {'u', 'q'},
                {'v', 'r'},
                {'w', 's'},
                {'x', 't'},
                {'y', 'u'},
                {'z', 'v'},
                {'a', 'w'},
                {'b', 'x'},
                {'c', 'y'},
                {'d', 'z'}
            };

            foreach (var x in input) // What is foreach doing here?
            {
                var foundMatch = false;
                // Why would this be assigned to false from the outset? What happens when it's true?
                foreach (var pair in cipher)
                {
                    char y = pair.Key;
                    if (x == y)
                        // What is this comparing? Where is it getting x? Where is it getting y? What are those variables really?
                    {
                        Console.WriteLine("I am comparing x and y. X is " + x + " and Y is " + y + ".\n");
                        decodedLetters.Add(cipher[y]); // How else could cipher[y] be expressed?
                        foundMatch = true;
                        break; // Why is it breaking here?
                    }
                    if (x == '@' || x == '#' || x == '$' || x == '%' || x == '^' || x == '&' || x == '*')
                        //What the heck is this doing?
                    {
                        decodedLetters.Add(' ');
                        foundMatch = true;
                        break;
                    }
                    if (Char.IsDigit(x))
                    {
                        decodedLetters.Add(x);
                        foundMatch = true;
                        break;
                    }
                }
                if (!foundMatch) // What is this looking for?
                    decodedLetters.Add(x);
            }

            var decodedSentence = String.Concat(decodedLetters); // What does the .Concat() method do?

            var regex = new Regex(@"\d+"); //What is this matching? Look at the regex documentation for help.

            if (regex.IsMatch(decodedSentence))
            {
                var match = regex.Match(decodedSentence);
                var number = Convert.ToInt32(match.Value);
                var newNumber = number/100;
                decodedSentence = regex.Replace(decodedSentence, newNumber.ToString());
            }
            return decodedSentence; // What is this returning?
        }
    }
}