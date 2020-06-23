using System;

namespace Lab_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
            string[] task = new string[7];

            for (int i =0; 1 < days.Length; i++)
            {
                Console.WriteLine("Type in a new Task for " + days[i]);
                task[i] = days[i] + " : " + Console.ReadLine();

            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(task[i]);
            }
        }
    }
}
