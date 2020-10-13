using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {

        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>() {"Hello", "Happy", "Play", "Goodbye"};
        private bool isAlive = true;
        Random generator = new Random();
        
        public string name;

        public void Feed(){
            hunger = -3;
        }
        public void Hi(){
            int r = generator.Next(words.Count);
            string saywords = words[r];
            reduceBoredom();
        }
        public void Teach(string word){
            words.Add(word); 
            reduceBoredom();        
        }
        public void Tick(){
            if (boredom > 10){
                boredom = +1;
            }
            if (hunger > 10){
                hunger = +1;
            }
            GetAlive();
        }
        public void PrintStats(){
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
        }
        public bool GetAlive(){
            if (hunger == 10 || boredom == 10){
                isAlive = false;
            }
            else{
                isAlive = true;
            }
            return isAlive;
        }
        private void reduceBoredom(){
            boredom = -3;
        }
    }
}
