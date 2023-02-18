using System;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            String inputString = Console.ReadLine();

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
    }
}
