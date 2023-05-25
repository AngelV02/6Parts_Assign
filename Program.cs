using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a one-dimensional array of strings.
            string[] texts = new string[5];

            // Step 2: Ask the user to input some text.
            Console.WriteLine("Enter some text:");

            // Step 3: Loop to add the user's text input to each string in the array.
            for (int i = 0; i < texts.Length; i++)
            {
                string userInput = Console.ReadLine();
                texts[i] = texts[i] + userInput;
            }

            Console.WriteLine(); 

            // Step 4: Loop to print each string in the array.
            Console.WriteLine("Updated array elements:");
            for (int i = 0; i < texts.Length; i++)
            {
                Console.WriteLine(texts[i]);
            }

            Console.WriteLine(); 

            // Step 5: Add an infinite loop.

            // Infinite loop:

            //while (true)
            //{
            //    Console.WriteLine("This is an infinite loop.");
            //}

            // Step 6: Fix the infinite loop.
            // Comment out the infinite loop and then save the code.

            Console.WriteLine(); 

            // Step 7: Loop with the "<" comparison operator.
            Console.WriteLine("Loop with '<' operator:");
            for (int i = 0; i < texts.Length; i++)
            {
                Console.WriteLine(texts[i]);
            }

            Console.WriteLine(); 

            // Step 8: Loop with the "<=" comparison operator.
            Console.WriteLine("Loop with '<=' operator:");
            for (int i = 0; i <= texts.Length - 1; i++)
            {
                Console.WriteLine(texts[i]);
            }

            Console.WriteLine(); 

            // Step 9: List of unique strings.
            List<string> stringsList = new List<string>()
            {
                "Apple",
                "Banana",
                "Orange",
                "Mango"
            };

            // Step 10: Ask the user to input text to search for in the list.
            Console.WriteLine("Enter text to search in the list:");

            // Step 11: Loop to search and display the index of the matching items.
            string searchInput = Console.ReadLine();
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

            // Step 12: Check if the user input is not in the list.
            if (!found)
            {
                Console.WriteLine("Input not found in the list.");
            }

            Console.WriteLine(); 

            // Step 13: List of strings with duplicates.
            List<string> duplicateList = new List<string>()
            {
                "Apple",
                "Banana",
                "Orange",
                "Apple",
                "Mango"
            };

            // Step 14: Ask the user to select text to search for in the list.
            Console.WriteLine("Enter text to search in the duplicate list:");

            // Step 15: Loop to display indices of matching items.
            string searchInput2 = Console.ReadLine();
            bool found2 = false;
            for (int i = 0; i < duplicateList.Count; i++)
            {
                if (duplicateList[i] == searchInput2)
                {
                    Console.WriteLine($"Match found at index {i}.");
                    found2 = true;
                }
            }

            // Step 16: Check if the user input is not in the list.
            if (!found2)
            {
                Console.WriteLine("Input not found in the list.");
            }

            Console.WriteLine(); 

            // Step 17: List of strings with duplicates.
            List<string> duplicateCheckList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "C"
            };

            // Step 18: Loop to evaluate each item in the list and display a message.
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
        }
    }
}
