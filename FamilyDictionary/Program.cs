using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>()
            {
                {"name", "Alyssa"},
                {"age", "26"}
            });
            myFamily.Add("brother", new Dictionary<string, string>()
            {
                {"name", "Aaron"},
                {"age", "28"}
            });
            myFamily.Add("father", new Dictionary<string, string>()
            {
                {"name", "Randall"},
                {"age", "52"}
            });
            myFamily.Add("mother", new Dictionary<string, string>()
            {
                {"name", "Diana"},
                {"age", "51"}
            });
            myFamily.Add("husband", new Dictionary<string, string>()
            {
                {"name", "Brandon"},
                {"age", "34"}
            });

            foreach (var relationship in myFamily)
            {
                Console.WriteLine($"My {relationship.Key}'s name is {relationship.Value["name"]} and is {relationship.Value["age"]} years old.");
            }

            Console.ReadLine();
        }
    }
}
