using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4HTML
{
    class Filewriter
    {
        string myHTML = "C://weblogs//myHTML.html";
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder htmlText = new StringBuilder();
            string headingOpen = "<h1>";
            string headingClose = "</h1>";
            string unoderliOp = "<ul>";
            string unoderliCl = "</ul>";
            string listOpen = "<li>";
            string listClose = "</li>";
            string bodyOp = "<body>";
            string bodyCl = "</body>";

            Console.WriteLine("Enter a text for your HTML header.");
            string HTMLheader = Console.ReadLine();

            Console.WriteLine("Please choose an Item for your list.");
            string item1 = Console.ReadLine();

            Console.WriteLine("Please choose another Item for your list.");
            string item2 = Console.ReadLine();

            Console.WriteLine("Please choose the last Item for your list.");
            string item3 = Console.ReadLine();

            htmlText.Append(bodyOp);
            htmlText.Append(headingOpen);
            htmlText.Append(HTMLheader);
            htmlText.Append(headingClose);
            htmlText.Append(unoderliOp);
            htmlText.Append(listOpen);
            htmlText.Append(item1);
            htmlText.Append(listClose);
            htmlText.Append(listOpen);
            htmlText.Append(item2);
            htmlText.Append(listClose);
            htmlText.Append(listOpen);
            htmlText.Append(item3);
            htmlText.Append(listClose);
            htmlText.Append(unoderliCl);
            htmlText.Append(bodyCl);

            File.WriteAllText("C:\\weblogs\\myHTML.html", htmlText.ToString());
            
        }
    }
}
