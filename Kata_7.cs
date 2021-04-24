using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task("Monday", 15, 2));
        }
        public static string Task(string w, int n, int c)
        {
            Dictionary<string, string> timetable = new Dictionary<string, string>
            {
                ["Monday"] = "James",
                ["Tuesday"] = "John",
                ["Wednesday"] = "Robert",
                ["Thursday"] = "Michael",
                ["Friday"] = "William"
            };
            return $"It is {w} today, {timetable[w]}, you have to work, you must spray {n} trees and you need {n*c} dollars to buy liquid";
            //It is (weekday) today, (name), you have to work, you must spray (number) trees and you need (x) dollars to buy liquid
            //James John Robert Michael William
        }
    }
}
