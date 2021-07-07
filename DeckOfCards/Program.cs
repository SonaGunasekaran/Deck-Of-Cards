using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DECK OF CARDS program");
            Cards obj = new Cards();
            obj.ShuffleCards();
        }
    }
}

