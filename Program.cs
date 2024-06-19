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
            
            while (true)
            {
                Console.Write("Для выхода из программы введите слово exit: ");
                wordForExit = Console.ReadLine();
                if (wordForExit == "exit")
                {
                    Console.WriteLine("Верное слово");
                    break;
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз");
                }
            }
        }
    }
}
