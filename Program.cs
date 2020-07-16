﻿//using System;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int myInt = 1;
            float myFloat = 0.42f;
            bool myBoolean = true;
            string myName = "John";
            char myChar = 'a';
            StringBuilder address = new StringBuilder();
            address.Append("8150");
            address.Append(", Marne Road");
            address.Append(", Ft Benning, GA 31905");
            string concatenatedAddress = address.ToString();
            Console.WriteLine(concatenatedAddress);
            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string smtText = "The Cloud Apps Developer Program is a great great opportunity to start a new career career.";
            // Find match of duplicate of words.
            MatchCollection matches = rx.Matches(smtText);
            // Report the number of matches found.
            Console.WriteLine("{0} matches found in:\n {1}", matches.Count, smtText);
            double d = 5673.74;
            int i;
            // cast double to int.
            i = (int)d;
            System.Console.WriteLine(i);
            string userEnteredValue = "542.12";
            double flightCost = Convert.ToDouble(userEnteredValue);
            Console.WriteLine(flightCost);
            Console.WriteLine(myInt);
        }
    }
}
