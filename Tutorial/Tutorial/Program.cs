// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            string UserAge = "3";

            Console.WriteLine("Type in userage!");
           UserAge = Console.ReadLine();

            if (
                UserAge == "4"
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
    }
}