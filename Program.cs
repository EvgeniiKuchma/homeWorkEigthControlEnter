using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkEigthControlEnter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordForExit = "exit";
            string userInput = " ";

            while (wordForExit != userInput)
            {
                Console.Write("Для выхода из программы введите слово exit: ");
                userInput = Console.ReadLine();
                if (wordForExit == userInput)
                {
                    Console.WriteLine("Верное слово");
                    break;
                }
                Console.WriteLine("Попробуйте еще раз");
            }
        }
    }
}
