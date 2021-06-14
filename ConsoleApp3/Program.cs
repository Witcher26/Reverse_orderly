using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Создать список, содержащий элементы," +
                "начинающиеся с заглавной буквы, в порядке" +
                "обратном тому" +
                "как они встречались в тексте";

            string[] separatot = { " ", ", ", "." };
            string[] splitWord = text.Split(separatot, StringSplitOptions.RemoveEmptyEntries);
            List<string> wordsToUpperRevord = new List<string>();
            foreach(string word in splitWord.Reverse())
            {
                string newWord = word.Substring(0, 1).ToUpper() + word.Substring(1);
                wordsToUpperRevord.Add(newWord);
            }
            foreach(var word in wordsToUpperRevord)
                {
                Console.WriteLine(word);
                 }
            Console.ReadKey();
          


        }
    }
 }



