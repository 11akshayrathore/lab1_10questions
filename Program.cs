using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_10questions
{

    class Program
    {
        static void Main()
        {
            AllQuestions();
        }

        static void AllQuestions()
        {
            Console.WriteLine("Question 1: Sum of Transactions");
            int[] transactions = { 200, -150, 340, 500, -100 };
            int total = 0;
            foreach (int t in transactions)
            {
                total += t;
            }
            Console.WriteLine($"Total Sum: {total}\n");

           
            
            
            
            Console.WriteLine("Question 2: Average Score");
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0f;
            foreach (float score in scores)
            {
                sum += score;
            }
            float average = sum / scores.Length;
            Console.WriteLine($"Average Score: {average:F2}\n");

           
            
            
            
            Console.WriteLine("Question 3: Most Expensive Item");
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int max = prices[0];
            foreach (int price in prices)
            {
                if (price > max)
                {
                    max = price;
                }
            }
            Console.WriteLine($"Most Expensive Item: {max}\n");

            
            
            
            
            
            
            Console.WriteLine("Question 4: Count Male and Female Participants");
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int maleCount = 0, femaleCount = 0;
            foreach (int code in participantCodes)
            {
                if (code % 2 == 0)
                    maleCount++;
                else
                    femaleCount++;
            }
            Console.WriteLine($"Male: {maleCount}, Female: {femaleCount}\n");

           
            
            
            
            
            
            Console.WriteLine("Question 5: Reverse Search History");
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            Console.Write("Reversed: ");
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.Write(searchHistory[i] + " ");
            }
            Console.WriteLine("\n");

            
            
            
            
            
            
            
            Console.WriteLine("Question 6: Multiply Measurements by Factor");
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;
            Console.Write("Adjusted: ");
            foreach (int m in measurements)
            {
                Console.Write(m * factor + " ");
            }
            Console.WriteLine("\n");

            
            
            
            
            
            
            
            
            Console.WriteLine("Question 7: Search Book Code");
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            int foundIndex = -1;
            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    foundIndex = i;
                    break;
                }
            }
            if (foundIndex != -1)
                Console.WriteLine($"Book code found at index: {foundIndex}");
            else
                Console.WriteLine("Book code not found.");
            Console.WriteLine();

            
            
            
            
            
            
            
            
            Console.WriteLine("Question 8: Second Smallest Grade");
            int[] grades = { 56, 78, 89, 45, 67 };
            Array.Sort(grades);
            int secondSmallest = grades[1];
            Console.WriteLine($"Second Smallest Grade: {secondSmallest}\n");

            
            
            
            
            
            
            
            Console.WriteLine("Question 9: Remove Duplicates");
            int[] ids = { 102, 215, 102, 324, 215 };
            HashSet<int> uniqueIds = new HashSet<int>();
            foreach (int id in ids)
            {
                uniqueIds.Add(id);
            }
            Console.WriteLine("Unique IDs: " + string.Join(", ", uniqueIds) + "\n");

           
            
            
            
            
            
            
            
            Console.WriteLine("Question 10: Common Elements Between Datasets");
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            HashSet<int> set1 = new HashSet<int>(dataset1);
            HashSet<int> commons = new HashSet<int>();
            foreach (int item in dataset2)
            {
                if (set1.Contains(item))
                    commons.Add(item);
            }
            Console.WriteLine("Common Elements: " + string.Join(", ", commons));
            Console.WriteLine("all done");
        }
    }
}
