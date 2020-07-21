using System;

namespace Lab_8_5_Reality_Tv_Star_
{
    class Applications //Creating the Class for applictions the begining for the inheritance.
    {
        public string First_name;
        public string Last_name;
        public string DOB;
        public string address;
        public string city;
        public string state;
        public int zip;
        public string Main_number;
        public string email;
        public bool app_Submitted;
        public bool app_Accepted;
        //adding corasponce
        public Applications(string First_name, string Last_name, string DOB, string address, string city, string state, int zip, string Main_number, string email)
        {
            this.First_name = First_name;
            this.Last_name = Last_name;
            this.DOB = DOB;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.Main_number = Main_number;
            this.email = email;
            app_Submitted = false;
            app_Accepted = false;
        }
        //adding method
        public void Submit()
        {
            app_Submitted = true;
            Console.WriteLine("Application has been submitted.");
        }

        public virtual void Accepted()
        {
            app_Accepted = true;
            Console.WriteLine("Application Accepted.");
        }
        

    }
    //Now a class for House Hunters with an inheritance from Applications
    class House_Hunter: Applications
    {
        public string job_Title;
        public int currentAnnualincome;
        public int whenBuyinghouse;
        public int num0fBedrooms;
        public int num0fBathrooms;

        public House_Hunter(string job_Title, int currentIncome, int whenBuying, int bedrooms, int bathrooms,
            string First_name, string Last_name, string DOB, string address, string city, string state, int zip, string Main_number, string email): 
            base(First_name, Last_name, DOB, address, city, state, zip, Main_number, email)
        {
            this.job_Title = job_Title;
            this.currentAnnualincome = currentIncome;
            this.whenBuyinghouse = whenBuying;
            this.num0fBedrooms = bedrooms;
            this.num0fBathrooms = bathrooms;
        }
        //Write an override method
        public override void Accepted()
        {
            base.Accepted();
            Console.WriteLine("Congratulations! You've been accepted to Dream House Hunters");
        }

    }
    //Repeat the same for Paradise Island
    class Paradise_Island: Applications
    {
        public string Gender;
        public string Name0fpartner;
        public int YearsDating;

        public Paradise_Island(string Gender, string parnter_Name, int yearsDating,
          string First_name, string Last_name, string DOB, string address, string city, string state, int zip, string Main_number, string email)
         : base(First_name, Last_name, DOB, address, city, state, zip, Main_number, email)
        {
            this.Gender = Gender;
            this.Name0fpartner = parnter_Name;
            this.YearsDating = yearsDating;

        }
        //Repeat override method
        public override void Accepted()
        {
            base.Accepted();
            Console.WriteLine("Congratulations! You've been accepted to Paradise Island.");
        }

    }
    //Repeat for Above Deck
    class Above_Deck: Applications
    {
        public int Years0feXperienceInBoating;
        public string Nationality;

        public Above_Deck (int YearsBoating, string Nationality, 
            string First_name, string Last_name, string DOB, string address, string city, string state, int zip, string Main_number, string email):
            base(First_name, Last_name, DOB, address, city, state, zip, Main_number, email)
        {
            this.Years0feXperienceInBoating = YearsBoating;
            this.Nationality = Nationality;

        }

        //Repeate override method
        public override void Accepted()
        {
            base.Accepted();
            Console.WriteLine("Congratulations! You've been accepted to Above Deck.");
        }


    }

    class Program
    {
        //Testing the Classes by making customers.
        static void Main(string[] args)
        {
            House_Hunter DreamHouseContestant = new House_Hunter("Full Stack Web Debeloper", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
                "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");
            DreamHouseContestant.Submit();
            DreamHouseContestant.Accepted();

            Paradise_Island paradiseContestant = new Paradise_Island("Female", "Carl", 2, "Patti", "Johnson",
                "5/4/1994", "211 Love Rd", "Los Angeles", "California", 90001, "988-444-1234", "patti.johnson@gmail.com");
            paradiseContestant.Submit();
            paradiseContestant.Accepted();

            Above_Deck Contestant = new Above_Deck(20, "American", "Captain", "Lee", "7/12/1964",
                "311 Bravo Way", "Los Angeles", "California", 90001, "711-333-1234", "captian@gmail.com");
            Contestant.Submit();
            Contestant.Accepted();
        }
    }
}
