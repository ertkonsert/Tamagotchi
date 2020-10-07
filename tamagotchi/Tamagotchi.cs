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
        }

        public void Hi()
        {
            if (words.Count > 1)
            {
                Console.WriteLine(words[generator.Next(words.Count)]);
            }

            else
            {
                Console.WriteLine("Your Tamagotchi doesn't know any words yet!");
            }
        }

        public void Teach(string word)
        {
            
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            if (isAlive == true)
            {
            Console.WriteLine("Your Tamagotchi is alive and well!");                
            }
            else
            {
                Console.WriteLine("Your Tamagotchi has died. :(");
            }
        }
    
        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {

        }



    }
}
