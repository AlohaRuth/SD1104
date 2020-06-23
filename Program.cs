using System;

namespace Lab_4_4_Improved_Spam_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blacklist = {
            "buy", "viagra", "XXX", "free money", "lifetime offer", "send money", "bank account", "nigeria", "online", "pharmacy", "h8te", "meet girls"

            };

            string message = Console.ReadLine();
            bool isSpam = false;
            message = message.ToLower();
            for (int i = 0; i < blacklist.Length; i++)
            {
                if (message.Contains(blacklist[i]))
                {
                    isSpam = true;
                }
            }

            if(isSpam == true)
            {
                Console.WriteLine("This message has spam");
            }
            else
            {
                Console.WriteLine("This message is secure");
            }
        }
    }
}
