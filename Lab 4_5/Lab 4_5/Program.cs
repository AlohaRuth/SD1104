using System;

namespace Lab_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of scores.
            List<int> scores = new List<int>();
            scores.Add(1200);
            scores.Add(4400);
            scores.Add(3700);
            scores.Add(8900);
            scores.Add(7200);

            //sort the list in order and print results.
            scores.Sort();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            //Reverse the list order and print results.
            scores.Reverse();
            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            //Adding to the list
            scores.Add(2400);

            //Removing from the list
            scores.Remove(4400);
        }
    }
}
