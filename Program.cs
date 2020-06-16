using System;
using System.Net.Http;

namespace Lab3_5_spamchecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3_5 Spam Checker");
            string blackListPhrase = "warrenty";
            string blackListWords = "weight";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListPhrase) || message.Contains(blackListWords))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            
            else
            {
                isSpam = false;


                Console.WriteLine("The message is not spam");
                

                
            }

            

        }
    }
}
