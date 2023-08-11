using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne2
{
    class Program
    {
        static void Main(string[] args)
        {//This is not complete program, sorry

            ////Game game = new Game();
            ////game.Dealer = "Jessa";
            ////game.Name = "TwentyOne";

            ////TwentyOneGame game = new TwentyOneGame();
            //Game game = new Game();
            //game.Players = new List<string>() { "Jessa", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
