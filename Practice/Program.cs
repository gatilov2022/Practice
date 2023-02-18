using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            String inputString = Console.ReadLine();

            if (!CheckInputString(inputString)) return;

            int halfLengthLine = inputString.Length / 2;
            String result = inputString.Length % 2 == 0 ?
                ReverseLine(inputString.Substring(0, halfLengthLine)) + ReverseLine(inputString.Substring(halfLengthLine))
                : ReverseLine(inputString) + inputString;

            Console.WriteLine("Результат: {0}", result);
        }

        //Реверс строки inputString
        static String ReverseLine(String inputString)
        {
            var arrayLine = inputString.ToArray();
            Array.Reverse(arrayLine);
            return new String(arrayLine);
        }

        //Задание 2
        static bool CheckInputString(String inputString)
        {
            String result = "";
            if (!Regex.IsMatch(inputString, @"^[a-z]*$"))
            {
                Console.WriteLine("Были введены не подходящие символы. Не подходящих символы: ");
                foreach (var symbol in inputString)
                {
                    if (!Regex.IsMatch(symbol.ToString(), @"^[a-z]*$"))
                        result += symbol;
                }

                Console.WriteLine(result);
                return false;
            }
            return true;
        }
    }
}
