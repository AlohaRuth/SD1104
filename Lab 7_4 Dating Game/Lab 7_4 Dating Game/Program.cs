using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace Lab_7_4_Dating_Game
{
    //Part 1 Creating the DatingProfile Class
    class DatingProfile //1-2 Profile properties
    {
        public string First_Name;
        private string Last_Name;
        public int Age;
        public string Gender;
        public string Bio;
        private List<Messages> MyMessages; //Part 3 add-on

        //1-3 Construstor
        public DatingProfile(string First_Name, string Last_Name, int Age, string Gender)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Age = Age;
            this.Gender = Gender;
            MyMessages = new List<Messages>(); //Part 3 add-on
        }

        //1-4 Dating Profile methods
        public void WriteBio(string text) 
        {
            Bio = text;
        }

        public void AddToInbox(Messages message)
        {
            MyMessages.Add(message);
        }

        
        public void ReadMessage()
        { //Part 3 add-on create method
            foreach (Messages message in MyMessages)
            {
                if(message.isRead == false)
                {
                    Console.WriteLine(message.Message_Title);
                    Console.WriteLine(message.Message_Data);
                    message.isRead = true;
                }
            }
        }

        public void SendMessage(string Message_Title, string Message_Data, DatingProfile toProfile)
        { //Part 3 add-on create method
            Messages message = new Messages(this, Message_Title, Message_Data); 
            toProfile.AddToInbox(message);

        }
    }

   
    /// Part 2 Creating a message class
    class Messages //2-2 the following properties
    {
        public DatingProfile sender;
        public string Message_Title;
        public string Message_Data;
        public bool isRead;

        //2-3 Constructor
        public Messages(DatingProfile sender, string Message_Title, string Message_Data)
        {
            this.sender = sender;
            this.Message_Title = Message_Title;
            this.Message_Data = Message_Data;
            isRead = false;
        }
    }
    
    class Program
    {
        static void Main(string[] args) //Testing the Classes!!
        {
            DatingProfile zelda = new DatingProfile("Zelda", "Hyrule", 119, "Female");
            zelda.WriteBio("Hyrule Princess that has been battling Evil for a 100 years waiting for the hero to wake up.");

            DatingProfile link = new DatingProfile("Link", "Knight", 119, "Male");
            link.WriteBio("Just woke up in a strange chamber with no memory of how I got there or who I am.");

            zelda.SendMessage("Wake Up", "Link... Wake up.... Hyrule needs you.", link);
            link.ReadMessage();

        }
    }
}
