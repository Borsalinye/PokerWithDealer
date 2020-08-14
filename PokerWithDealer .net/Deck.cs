using System;
using System.Collections.Generic;
using System.Linq;
using static PokerWithDealer.net.Card;

namespace PokerWithDealer.net
{
    class Deck
    {
        private readonly List<Card> cards = new List<Card>();
        public Deck()
        {
            this.cards = NewDeck();
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public void RemoveCard(Card card)
        {
            cards.Remove(card);
        }
        public Card RollCard()
        {
            Card card = cards.FirstOrDefault();
            RemoveCard(card);
            return card;
        }
        public List<Card> NewDeck()
        {
            int i = 0;
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
                    AddCard(new Card(suit, rank));
                    i++;
                }
            }
            Shuffle();
            return cards;
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = cards.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
        }
    }
}
