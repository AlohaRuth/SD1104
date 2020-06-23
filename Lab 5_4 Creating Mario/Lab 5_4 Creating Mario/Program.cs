using System;

namespace Lab_5_4_Creating_Mario
{
    class Program
    {
        public struct Mario
        {
            public enum Size
            {
                small,
                large
            }

            
            public int num0fLives;
            public string currentlvl;
            public Size size0fMario;
            public bool canThrowfireballs;
            public bool isJumping;
            public int num0fCoins;
            

        }

        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.num0fLives = 3;
            mario.currentlvl = "World 1-1";
            mario.size0fMario = Mario.Size.small;
            mario.canThrowfireballs = false;
            mario.isJumping = false;


            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            mario.isJumping = true;

            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            mario.isJumping = false;


            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            mario.num0fLives += 1;


            Console.WriteLine("Mario is hit by a Gooba and looses a life.");
            mario.num0fLives -= 1;


            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            mario.canThrowfireballs = true;


            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            mario.size0fMario = Mario.Size.large;
            

            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            mario.num0fCoins = 10;


            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            mario.currentlvl = "World 1-2";


        }
    }
}
