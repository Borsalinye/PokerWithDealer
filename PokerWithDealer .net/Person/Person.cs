using System.Collections.Generic;

namespace PokerWithDealer.net.Person
{
    abstract class Person
    {
        public List<Card> CardInHand { get; set; }
        public abstract void GiveCard(Card card);
        public Command Command { get; set; }
    }
    public enum Command
    {
        Bet,
        Fold,
        Raise,
        Check
    }
}
