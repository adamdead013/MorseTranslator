using System;
using System.Collections.Generic;

namespace MorseTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var morseDict = new Dictionary<char, string>()
            {
                ['А'] = ".-",
                ['Б'] = "-...",
                ['В'] = ".--",
                ['Г'] = "--.",
                ['Д'] = "-..",
                ['Е'] = ".",
                ['Ё'] = ".",
                ['Ж'] = "...-",
                ['З'] = "--..",
                ['И'] = "..",
                ['Й'] = ".---",
                ['К'] = "-.-",
                ['Л'] = ".-..",
                ['М'] = "--",
                ['Н'] = "-.",
                ['О'] = "---",
                ['П'] = ".--.",
                ['Р'] = ".-.",
                ['С'] = "...",
                ['Т'] = "-",
                ['У'] = "..-",
                ['Ф'] = "..-.",
                ['Х'] = "....",
                ['Ц'] = "-.-.",
                ['Ч'] = "---.",
                ['Ш'] = "----",
                ['Щ'] = "--.-",
                ['Ъ'] = "--.--",
                ['Ы'] = "-.--",
                ['Ь'] = "-..-",
                ['Э'] = "..-..",
                ['Ю'] = "..--",
                ['Я'] = ".-.-"
            };

            string resultStr = "";
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (morseDict.ContainsKey(Char.ToUpper(input[i])))
                    {
                    resultStr += morseDict[Char.ToUpper(input[i])] + " ";
                }                      
            }
            Console.WriteLine(resultStr);
        }
    }
}
