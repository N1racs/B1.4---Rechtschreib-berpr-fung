using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._4___Rechtschreibüberprüfung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] words = { "programmieren", "Schifffahrt", "Rythmus", "Sorgfalt", "Atmosphäre" };
            int randomWords = random.Next(words.Length);
            string wordsInput = "Das Wort ist > ";
            string wordsInput2 = " < Gib es ein: ";
            string falseInput = "Leider falsch geschrieben! Einen Versuch hast du noch!";
            string rightInput = "Richtig!";
            string falseInput2 = "Das war wieder falsch! versuche es ein andermal.";
            

            Console.WriteLine(wordsInput + words[randomWords] + wordsInput2);
            Console.Write("> ");
            string input = Console.ReadLine();


            if (input == "programmieren")
            {
                Console.WriteLine(rightInput);
                return;

            }
            else if (input == "Schifffahrt")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else if (input == "Rythmus")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else if (input == "Sorgfalt")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else if (input == "Atmosphäre")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else
            {
                Console.WriteLine(falseInput);
            }

            Console.Write("> ");
            string input2 = Console.ReadLine();

            if (input2 == "programmieren")
            {
                Console.WriteLine(rightInput);
                return;

            }
            else if (input2 == "Schifffahrt")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else if (input2 == "Rythmus")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else if (input2 == "Sorgfalt")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else if (input2 == "Atmosphäre")
            {
                Console.WriteLine(rightInput);
                return;
            }
            else
            {
                Console.WriteLine(falseInput2);
            }
        }
    }
}
