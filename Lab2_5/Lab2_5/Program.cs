using System;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userInput1 = Console.ReadLine();
            int num1 = int.Parse(userInput1);
            Console.WriteLine("Please enter a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("The answer when adding is:");
            Console.WriteLine(result);

            result = num1 - num2;
            Console.WriteLine("The answer when subtracting is:");
            Console.WriteLine(result);

            result = num1 * num2;
            Console.WriteLine("The answer when multiplying is:");
            Console.WriteLine(result);

            double result2 = (double) num1 / (double) num2;
            Console.WriteLine("The answer when dividing is:");
            Console.WriteLine(result2);

            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);

            Console.WriteLine("Lets multiply! Please enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number.");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Last one! Please enter a third number.");
            int num3 = Convert.ToInt32(Console.ReadLine());
            result = num1 * num2 * num3;
            Console.WriteLine("The answer when multiplying them is:");
            Console.WriteLine(result);

            Console.WriteLine("PLease enter your age.");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look younger than " + age);



        }
    }
}
