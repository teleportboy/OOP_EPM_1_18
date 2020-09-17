using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Composition_Hierarchy
{
    class Card
    {
        private string cardName;
        public string CardName { set { cardName = value; } get { return cardName; } }

        private string cardSuit;
        public string CardSuit { set { cardSuit = value; } get { return cardSuit; } }

        public Card() 
        {
            cardName = null;
            cardSuit = null;
        }
        public Card(string name, string suit)
        {
            CardName = name;
            CardSuit = suit;
        }
    }
}
