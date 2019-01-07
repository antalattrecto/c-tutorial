// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            int UserAge = 3;
            string UserInput;

            Console.WriteLine("Type in userage!");
            UserAge = Convert.ToInt16(UserAge);
            UserInput = Console.ReadLine();
            

            if (
                UserInput == "4"
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