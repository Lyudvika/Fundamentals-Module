using System;
using System.Security;

namespace _01._Advertisement_Message
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use thatproduct.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = new string[] {"Now I feel good.", "I have succeeded with this product.", "Makesmiracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfMessages; i++)
            {
                Random random = new Random();
                int phraseIndex = random.Next(0, phrases.Length);
                int eventsIndex = random.Next(0, events.Length);
                int authorsIndex = random.Next(0, authors.Length);
                int citiesIndex = random.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {cities[citiesIndex]}.");
            }
        }
    }
}