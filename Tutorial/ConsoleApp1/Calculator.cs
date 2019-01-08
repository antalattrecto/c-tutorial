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
            Again:
            try
            {

                char op;
                double first, second, result;
                string userInput;

            Start:

                Console.Write("Type in your first number: ");

                first = Convert.ToDouble(Console.ReadLine());

                Console.Write("Type in your second number: ");

                second = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your operator (+, -, *, /, % ): ");
                op = (char)Console.Read();

                switch (op)
                {

                    case '+':
                        result = first + second;
                        Console.WriteLine("The result is: {0}", result);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;

                    case '-':
                        result = first - second;
                        Console.WriteLine("The result is: {0}", result);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;

                    case '*':
                        result = first * second;
                        Console.WriteLine("The result is: {0}", result);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;

                    case '/':
                        result = first / second;
                        Console.WriteLine("The result is: {0}", result);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;

                    case '%':
                        result = first * second / 100;
                        Console.WriteLine("The result is: {0}", result);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine("Invalid operator! Press any key to continue.");
                        Console.ReadLine();
                        break;

                }


                Console.ReadLine();
                Console.WriteLine("Press 1 to quit, 2 to run another operation!");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    goto Finish;
                }

                else
                {
                    goto Start;
                }

            Finish:

                Console.WriteLine("Good Bye!");

            }

            catch
            {
                Console.WriteLine("Hit Enter and type in a valid number!");
                Console.ReadLine();
                goto Again;
            }

        }
    }
}
