using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            // var startingDeck =  from s in Suits()
            //                     from r in Ranks()
            //                     select new { Suit = s, Rank = r };

            var startingDeck = Suits()
                                .SelectMany(suit => Ranks()
                                                    .Select(rank => new { Suit = suit, Rank = rank }));

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);
            foreach(var card in shuffle) {
                Console.WriteLine(card);
            }
        }

        static IEnumerable<string> Suits() {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks() {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
