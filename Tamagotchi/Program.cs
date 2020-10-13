using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tamagotchi t = new Tamagotchi();

            Console.WriteLine("Give your new tamagotchi a name");

            t.name = Console.ReadLine();


        }
    }
}
