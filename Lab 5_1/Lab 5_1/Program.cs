using System;
using System.Collections.Generic;

namespace Lab_5_1
{
    class Program
    {
        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();

            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);
            }

            foreach (string task in taskList) 
            {
                 Console.WriteLine(task);
            }
        }
    }
}
