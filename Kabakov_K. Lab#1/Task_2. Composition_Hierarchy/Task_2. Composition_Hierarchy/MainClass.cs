using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Composition_Hierarchy
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.DisplayCardDeck();
        }
    }
}
