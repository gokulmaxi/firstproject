using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class PokerHandling
    {
        public static string[] CARD_RANKS= { "2", "3", "4", "5", "6", "7", "8", "9", "10","J","Q","K","A" };
        static string[] CARD_SUITS = { "c","d","h","s"};
        public PokerHandling() {
            string[] cards = { "10h","Jh","Qh","Kh","Ah"};
            string output = PokerHandRanking(cards);
            Console.WriteLine(output);
        }
        // all cards end with same suits
        private static bool IsFlush(string[] hand)
        {
            return hand.All(card => card.EndsWith(hand[0][1]));
        }
        private static bool IsStraight(string[] hand)
        {
            var cardRanks = hand.Select(card => card.Substring(0,card.Length-1))
                .Select(rank=>CARD_RANKS.ToList().IndexOf(rank)).
                OrderBy(rankIndex => rankIndex);
            var minRAnk = cardRanks.First();
            return cardRanks.SequenceEqual(Enumerable.Range(minRAnk, 5));
        }
        private static int[] CountRanks(string[] hand)
        {
            return CARD_RANKS.Select(rank => hand.Count(card => card.StartsWith(rank))).ToArray();
        }
        private static bool IsFourOfAKind(string[] hand)
        {
            return CountRanks(hand).Contains(4);
        }
        private static bool IsThreeOfKind(string[] hand)
        {
            return CountRanks(hand).Contains(3);
        }
        private static bool IsPair(string[] hand)
        {
            return CountRanks(hand).Contains(2);
        }
        private static bool isFullHouse(string[] hand)
        {
            return IsThreeOfKind(hand) && IsPair(hand);
        }
        private static bool IsTwoPair(string[] hand)
        {
            return CountRanks(hand).Count(rankCount => rankCount == 2) == 2;
        }
    private static bool IsRoyalFlush(string[] hand)
    {
        return IsStraight(hand) && hand.All(card => card.StartsWith("10") || card.StartsWith("K"));
    }

    private static bool IsStraightFlush(string[] hand)
    {
        return IsStraight(hand) && IsFlush(hand);
    }

    private static bool IsFullHouse(string[] hand)
        {
            return IsThreeOfKind(hand) && IsPair(hand);
        }
    public static string PokerHandRanking(string[] hand)
    {
        if (IsRoyalFlush(hand))
        {
            return "Royal Flush";
        }
        if (IsStraightFlush(hand))
        {
            return "Straight Flush";
        }
        if (IsFourOfAKind(hand))
        {
            return "Four of a Kind";
        }
        if (IsFullHouse(hand))
        {
            return "Full House";
        }
        if (IsFlush(hand))
        {
            return "Flush";
        }
        if (IsStraight(hand))
        {
            return "Straight";
        }
        if (IsThreeOfKind(hand))
        {
            return "Three of a Kind";
        }
        if (IsTwoPair(hand))
        {
            return "Two Pair";
        }
        if (IsPair(hand))
        {
            return "Pair";
        }
        return "High Card";
    }
    }
}
