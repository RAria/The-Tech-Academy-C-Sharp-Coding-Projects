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

            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            // List<Card> newList = deck.Cards.Where(X => X.Face == Face.King).ToList();

            List<int> numbers = new List<int>() {12,34,45,55,63,13,5,6,633,643,66};

            int sum = numbers.Where(x => x < 20).Sum();

            Console.WriteLine(sum);

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);

            //}
            
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);

            //}

            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        

  

    }
}
