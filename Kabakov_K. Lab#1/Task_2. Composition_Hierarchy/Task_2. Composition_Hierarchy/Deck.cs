using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Composition_Hierarchy
{
    class Deck
    {
        //Массивы cardNames и cardSuits используются для образования колоды.
        protected string[] cardNames = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        protected string[] cardSuits = { "Hearts", "Tiles", "Clovers", "Pikes" };
       
        protected static int cardsAmount = 52;
        protected Card[] cardDeck = new Card[cardsAmount];

        
        public Deck()
        {
            //Под каждую карту которая итерируется внешним циклом,
            //выбирается масть которая итерируется внутренним циклом.
            for (int i = (int)CardName.Two, counter = 0; i <= (int)CardName.Ace; i++) {
                for (int j = (int)CardSuit.Hearts; j <= (int)CardSuit.Pickes; j++, counter++) {
                    cardDeck[counter] = new Card(cardNames[i], cardSuits[j]);
                }
            }
        }

        public void DisplayCardDeck()
        {
            for (int i = 0; i < cardsAmount; i++) {
                if (i % 4 == 0) { Console.WriteLine(); }
                Console.WriteLine($"Card №{i + 1}; Name: {cardDeck[i].CardName} Suit: {cardDeck[i].CardSuit}");
            }
        }
    }
}
