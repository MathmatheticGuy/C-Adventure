using System;

namespace MaldLibs_WordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program ...
            Author: ...
            */


            // Let the user know that the program is starting:
            Console.Write("Start the Program");


            // Give the Mad Lib a title:
            string title = "Princess Bubblegum";

            Console.WriteLine(title);
            // Define user input and variables:
            string name;
            string adj1;
            string adj2;
            string adj3;
            string verb;
            string noun1;
            string noun2;


            Console.Write("Enter a name: ");
            name = Console.ReadLine();
            Console.Write("Enter 1st Adj: ");
            adj1 = Console.ReadLine();
            Console.Write("Enter 2nd Adj: ");
            adj2 = Console.ReadLine();
            Console.Write("Enter 3rd Adj: ");
            adj3 = Console.ReadLine();

            Console.Write("Enter a Verb: ");
            verb = Console.ReadLine();
            Console.Write("Enter the 1st Noun: ");
            noun1 = Console.ReadLine();
            Console.Write("Enter the 2nd Noun: ");
            noun2 = Console.ReadLine();

            string[] categories = { "animal", "food", "fruit", "superhero", "country", "dessert", "year" };
            // Create a Dictionary to store the user input:
            var userInput = new Dictionary<String, string>();

            // Ask the user for each word in the categories array:
            foreach (string category in categories)
            {
                Console.WriteLine($"Enter a {category}");
                // for each item in catefories, add a value beside it. Make a key:value pair
                userInput.Add(category, Console.ReadLine());
            };


            // The template for the story:
            string story = $"This morning {name} woke up feeling {adj1}. \n'It is going to be a {adj2} day!' Outside, a bunch of {userInput["animal"]}s were protesting to keep {userInput["food"]} in stores." +
               $"\nThey began to {verb} to the rhythm of the {noun1}, which made all the {userInput["fruit"]}s very {adj3}.\n Concerned, {name} texted {userInput["superhero"]}, " +
               $"who flew {name} to {userInput["country"]} and dropped {name} in a puddle of frozen {userInput["dessert"]}.\n {name} woke up in the year {userInput["year"]}," +
               $" in a world where {noun2}s ruled the world.\n";


            // Print the story:
            Console.Write(story);
        }
    }
}