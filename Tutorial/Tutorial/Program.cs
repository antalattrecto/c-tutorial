// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            int UserAge;

            Console.WriteLine("Type in userage!");
            Console.ReadLine();

            try
            {

                if (
                    UserAge >= 4
                    )

                {
                    Console.WriteLine("Hello World!");

                }

                else
                {
                    Console.WriteLine("Bujok");
                }


                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

            catch (InvalidCastException e)
            {
                Console.WriteLine("Invalid input, please type in an integer between 0-100", e);
            }
        }
    }
}