using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double x, y, i;
                Console.WriteLine("Введите первое число");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите арифметический знак действия:");
                string z = Console.ReadLine();

                switch (z)
                {
                    case "+":
                        i = x + y;
                        Console.WriteLine(x + "+" + y + "=" + i);
                        break;
                    case "-":
                        i = x - y;
                        Console.WriteLine(x + "-" + y + "=" + i);
                        break;
                    case "*":
                        i = x * y;
                        Console.WriteLine(x + "*" + y + "=" + i);
                        break;
                    case "/":
                        i = x / y;
                        Console.WriteLine(x + "/" + y + "=" + i);
                        break;
                    case "%":
                        i = x % y;
                        Console.WriteLine(x + "%" + y + "=" + i);
                        break;
                    default:
                        Console.WriteLine("Данное действие не поддерживается!");
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
