using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string search;
            bool contains;
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine(alice);

            Console.WriteLine("Please enter search term:");
            search = Console.ReadLine();

            contains = alice.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0;

            Console.WriteLine(contains);
            Console.ReadLine();
        }
    }
}
