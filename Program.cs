using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберете функцию +,-,*,/");
            string C = Console.ReadLine();
            Math math = new Math();
            double rezult;
            if (C == "+")
            {
                rezult = math.plus(A, B);
                Console.WriteLine(rezult);
            }
            if (C == "-")
            {
                rezult = math.minus(A, B);
                Console.WriteLine(rezult);
            }
            if (C == "*")
            {
                rezult = math.multiplication(A, B);
                Console.WriteLine(rezult);
            }
        }
    }
}
