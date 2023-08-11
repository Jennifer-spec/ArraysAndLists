using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {


            //deck.Cards = new List<Card>();


            //card cardOne = new card();
            //cardOne.face = "queen";
            //cardOne.suit = "spades";

            //deck.Cards.Add(cardOne);

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Deck deck = new Deck();

            deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        

    }
}
