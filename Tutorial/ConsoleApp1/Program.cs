using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Calculator
    {
        static void Main(string[] args)
        {
            char op;
            double first, second, result;

            Console.Write("Type in integer for A: ");
            first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type in integer for B: ");
            second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, / ): ");
            op = (char)Console.Read();

            switch (op)
            {
               
                case '+':
                    result = first + second;
                    Console.WriteLine("The result is: {0}", result);
                    Console.ReadLine();
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine("The result is: {0}", result);
                    Console.ReadLine();
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine("The result is: {0}", result);
                    Console.ReadLine();
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine("The result is: {0}", result);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    Console.ReadLine();
                    break;


            }

            Console.ReadLine();

        }
    }
}
