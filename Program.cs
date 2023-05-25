using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Create an array of strings
            string[] texts = new string[5] { "apple", "banana", "orange", "apple", "mango" };

            // Part 2: Ask the user to input some text
            Console.WriteLine("Enter some text:");

            string userInput = Console.ReadLine();

            // Part 3: Loop to add the user's text input to each string in the array
            for (int i = 0; i < texts.Length; i++)
            {
                texts[i] = texts[i] + (" ") + userInput;
            }

            Console.WriteLine();

            // Part 4: Loop to print each string in the array
            Console.WriteLine("Updated array elements:");
            for (int i = 0; i < texts.Length; i++)
            {
                Console.WriteLine(texts[i]);
            }

            Console.WriteLine();

            // Part 5: Infinite loop
            while (true)
            {
                Console.WriteLine("This is an infinite loop.");
                break;
            }

            Console.WriteLine();

            // Part 7: Loop with the "<" comparison operator
            Console.WriteLine("Loop with '<' operator:");
            for (int i = 0; i < texts.Length; i++)
            {
                Console.WriteLine(texts[i]);
            }

            Console.WriteLine();

            // Part 8: Loop with the "<=" comparison operator
            Console.WriteLine("Loop with '<=' operator:");
            for (int i = 0; i <= texts.Length - 1; i++)
            {
                Console.WriteLine(texts[i]);
            }

            Console.WriteLine();

            // Part 9: List of unique strings
            List<string> stringsList = new List<string>()
            {
                "Apple",
                "Banana",
                "Orange",
                "Mango"
            };

            // Part 10: Ask the user to input text to search for in the list
            Console.WriteLine("Enter text to search in the list:");
            string searchInput = Console.ReadLine();

            // Part 11: Loop to search and display the index of matching items
            bool found = false;
            for (int i = 0; i < stringsList.Count; i++)
            {
                if (stringsList[i] == searchInput)
                {
                    Console.WriteLine($"Match found at index {i}.");
                    found = true;
                    break;
                }
            }

            // Part 12: Check if the user input is not in the list
            if (!found)
            {
                Console.WriteLine("Input not found in the list.");
            }

            Console.WriteLine();

            // Part 13: List of strings with duplicates
            List<string> duplicateList = new List<string>()
            {
                "Apple",
                "Banana",
                "Orange",
                "Apple",
                "Mango"
            };

            // Part 14: Ask the user to select text to search for in the list
            Console.WriteLine("Enter text to search in the duplicate list:");
            string searchInput2 = Console.ReadLine();

            // Part 15: Loop to display indices of matching items
            bool found2 = false;
            for (int i = 0; i < duplicateList.Count; i++)
            {
                if (duplicateList[i] == searchInput2)
                {
                    Console.WriteLine($"Match found at index {i}.");
                    found2 = true;
                }
            }

            // Part 16: Check if the user input is not in the list
            if (!found2)
            {
                Console.WriteLine("Input not found in the list.");
            }

            Console.WriteLine();

            // Part 17: List of strings with duplicates
            List<string> duplicateCheckList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "C"
            };

            // Part 18: Loop to evaluate each item in the list and display a message
            List<string> uniqueItems = new List<string>();
            foreach (string item in duplicateCheckList)
            {
                if (uniqueItems.Contains(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    uniqueItems.Add(item);
                    Console.WriteLine($"{item} - this item is unique");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
