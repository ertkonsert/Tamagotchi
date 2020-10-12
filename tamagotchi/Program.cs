using System;


namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "It's Tamagotchi Time!! (it always is)";
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

            Console.WriteLine();
            Console.WriteLine("Such a wonderful name!");
            Console.WriteLine("So...");
            
            while(tg1.GetAlive() == true)
            {
                tg1.PrintStats();
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("     1. Say hi to " + tg1.name + ".");
                Console.WriteLine("     2. Feed " + tg1.name + ".");
                Console.WriteLine("     3. Teach " + tg1.name + " a word.");
                Console.WriteLine("     4. Sit in silence and contemplate existance.");

                string action = Console.ReadLine();

                while (action != "1" && action != "2" && action != "3" && action != "4")
                {
                    Console.WriteLine("Answer with the number associated to the action you want to take, please!");
                    action = Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine();

                if (action == "1")
                {
                    tg1.Hi();
                
                }

                if (action == "2")
                {
                    tg1.Feed();
                }

                if (action == "3")
                {
                    Console.WriteLine("What word do you want to teach " + tg1.name + "?");
                    string word = Console.ReadLine();
                    tg1.Teach(word);
                    Console.WriteLine("You repeat the word a handful (you've got very big hands) of times and " + tg1.name + " sure knows this word well now! (you hope)");
                }

                if (action == "4")
                {
                    Console.WriteLine("You contemplate your existance for a bit...");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine("Well that was fun! Nothing like existential dread early on a tuesday morning. :)");
                }

                Console.ReadLine();

                tg1.Tick();
                Console.Clear();
            }

            Console.WriteLine("Well, woopsies! Let's take a look here.");
            tg1.PrintStats();
            Console.WriteLine();
            Console.WriteLine("Hm. Well.");

            Console.WriteLine();
            Console.WriteLine("Goodbye then!");


            Console.ReadLine();
        }
    }
}
