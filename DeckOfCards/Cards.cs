using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Cards
    {
        string[] cardSuit = { "Clubs", "Diamonds", "Hearts", "Spades" };
        string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        
        public void ShuffleCards()
        {
            int playerCount = 9;
            int n = 0;
            int[] player = new int[4];


            string[,] suffCards = new string[cardSuit.Length, rank.Length];

            for (int i = 0; i < cardSuit.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    suffCards[i, j] = cardSuit[i] + " of " + rank[j];
                }
            }

            Random random = new Random();
            int k = 0;

            while( k <= player.Length)
            {
                for (n = 1; n <= playerCount; n++)
                {
                   int  randSuit = random.Next(0, cardSuit.Length);
                   int  randRank = random.Next(0, rank.Length);

                    suffCards[randSuit, randRank] = cardSuit[randSuit] + " of " + rank[randRank];
                    Console.WriteLine("The cards distributed for player" + " " + player[k]+ "is" + " " + suffCards[randSuit, randRank]);
                 }
                k++;
            }
        }

    }
}
