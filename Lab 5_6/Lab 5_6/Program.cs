using System;
using System.Threading.Tasks.Dataflow;

namespace Lab_5_6
{
    class Program
    {
        public struct customerProfile //making customer structure
        {
            public string first_Name;
            public string last_Name;
            public int age;
            public bool member_Status;
        }
        

        static void Main(string[] args)
        {
            //Creating cumstomers
            customerProfile customer1 = new customerProfile();
            customer1.first_Name = "James";
            customer1.last_Name = "Nelson";
            customer1.age = 19;
            customer1.member_Status = false;

            customerProfile customer2 = new customerProfile();
            customer2.first_Name = "Huck";
            customer2.last_Name = "Doneldson";
            customer2.age = 30;
            customer2.member_Status = false;

            customerProfile customer3 = new customerProfile();
            customer3.first_Name = "Jen";
            customer3.last_Name = "Carry";
            customer3.age = 25;
            customer3.member_Status = true;

            customerProfile[] allcustomerProfiles = { customer1, customer2, customer3 };

            for (int i = 0; i < allcustomerProfiles.Length; i++)
            {
                //checking customer age
                if (allcustomerProfiles[i].age < 21)
                {
                    Console.WriteLine("Customer " + allcustomerProfiles[i].first_Name + " " + allcustomerProfiles[i].last_Name + "  is not of legal age to order.");
                }
                else
                {
                    Console.WriteLine("Customer " + allcustomerProfiles[i].first_Name + " " + allcustomerProfiles[i].last_Name + " may place an order.");
                }

                //checking customer membership status
                if (allcustomerProfiles[i].member_Status == true)
                {
                    Console.WriteLine("Customer " + allcustomerProfiles[i].first_Name + " " + allcustomerProfiles[i].last_Name + " is a Premium Member.");
                }
                else
                {
                    Console.WriteLine("Customer " + allcustomerProfiles[i].first_Name + " " + allcustomerProfiles[i].last_Name + " is a Standard Member.");
                }
            }
        }
    }
}
