using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_Факториал
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");

            var factorial = Convert.ToUInt32(Console.ReadLine());

            IsOutput(CountFactorial(factorial));

        }
        static ulong CountFactorial(uint factorial)
        {
            if (factorial == 0)
            {
                return 1;
            }
            else
            {
                return factorial * CountFactorial(factorial - 1);
            }
        }
        static void IsOutput(ulong factorial)
        {

            { 
                string str = $"║ {factorial} ║";
                Print('╔', '═', '╗', str);
                Console.WriteLine(str);
                Print('╚', '═', '╝', str); 
            }
        }
        static void Print(char left, char middle, char right, string str)
        {
            Console.Write(left);
            Console.Write(new string(middle, str.Length - 2));
            Console.WriteLine(right);
        }
    }
}
