using System.Collections.Generic;

namespace PokerWithDealer.net.Person
{
    sealed class Player : Person
    {
        private int _money = 1000;
        public int Money
        {
            get
            {
                return _money;
            }
        }
        public int Bet { get; set; }
        public void AddMoney(int money)
        {
            _money += money * 2;
        }
        public void RemoveMoney(int money)
        {
            _money -= money;
        }
        public void ReturnMoney(int money)
        {
            _money += money;
        }
        private Player()
        {
            this.CardInHand = new List<Card>();
        }
        private static Player instance;
        public static Player GetInstance()
        {
            if (instance is null)
            {
                instance = new Player();
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
