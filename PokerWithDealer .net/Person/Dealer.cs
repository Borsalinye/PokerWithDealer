using System.Collections.Generic;

namespace PokerWithDealer.net.Person
{
    sealed class Dealer : Person
    {
        private Dealer()
        {
            this.CardInHand = new List<Card>();
        }
        private static Dealer instance;
        public static Dealer GetInstance()
        {
            if (instance is null)
            {
                instance = new Dealer();
                return instance;
            }
            else
            {
                return instance;
            }
        }
        public override void GiveCard(Card card)
        {
            CardInHand.Add(card);
        }
    }
}
