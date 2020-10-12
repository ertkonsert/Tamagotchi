using System;
using System.Collections.Generic;

namespace tamagotchi
{
    public class Tamagotchi
    {
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();
        bool isAlive = true;
        Random generator = new Random();
        public string name;



        public void Feed()
        {
            hunger -= generator.Next(2, 3);
            Console.WriteLine("You give " + name + "some food.");
            Console.WriteLine(name + " seems happy and gobbles it up so fast you worry it will choke.");
            ReduceBoredom();
        }

        public void Hi()
        {

            Console.WriteLine("You say:");
            Console.WriteLine("'Hello " + name + "!'");
            

            if (words.Count > 0)
            {
                Console.WriteLine(name + " responds:");
                Console.WriteLine(words[generator.Next(words.Count)]);
            }

            else
            {
                Console.WriteLine(name + " blinks at you in response.");
            }

            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }

            if (hunger < 0)
            {
                hunger = 0;
            }
            if (boredom < 0)
            {
                boredom = 0;
            }
        }

        public void PrintStats()
        {
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            if (isAlive == true)
            {
            Console.WriteLine("Your Tamagotchi " + name + " is alive and well!");                
            }
            else
            {
                Console.WriteLine("Your Tamagotchi " + name + " has died. :(");
            }
        }
    
        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom -= generator.Next(1, 2);

        }



    }
}
