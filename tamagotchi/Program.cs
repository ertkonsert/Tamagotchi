using System;


namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Welcome to Tamagotchi Planet";
            Console.WriteLine("Welcome to Tamagotchi Planet!");
            Console.WriteLine("Here you get to take care of your very own Tamagotchi! They are very helpless on their own and need someone to keep them alive, no pressure. :)");
            Console.WriteLine();
            Console.WriteLine("Press enter to adopt your first Tamagotchi!");
            Console.ReadLine();
            Console.Clear();

            Tamagotchi tg1 = new Tamagotchi();
            Console.WriteLine("Wow!");
            Console.WriteLine("What's their name?");
            tg1.name = Console.ReadLine();



            Console.ReadLine();
        }
    }
}
