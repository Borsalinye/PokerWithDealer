using PokerWithDealer.net.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace PokerWithDealer.net
{
    class Table
    {
        public Dealer Dealer { get; set; }
        public Player Player { get; set; }
        public List<Card> CardOnTable { get; set; }
        public Table(Dealer dealer, Player player)
        {
            this.Dealer = dealer;
            this.Player = player;
        }
        public Table NewGame()
        {
            return new Table(Dealer.GetInstance(), Player.GetInstance());
        }
        public void GiveCard(Card card)
        {
            CardOnTable.Add(card);
        }
        //private void Combination(List<Card> cards) //алгоритм поиска комбинации
        //{
        //    bool strit = false;
        //    cards.Sort();
        //    int result = cards.Select(x => x.Rank).GroupBy(g => g).OrderByDescending(o => o.Count()).FirstOrDefault().Count();
        //    if (result == 2)
        //    {
        //        //пара
        //    }
        //    else if (result == 3)
        //    {
        //        result = 0;
        //        result = cards.Select(x => x.Rank).GroupBy(g => g).OrderByDescending(o => o.Count()).LastOrDefault().Count();
        //        if (result == 2)
        //        {
        //            //тут фулхаус
        //        }
        //        else
        //        {
        //            //тут тройка
        //        }
        //    }
        //    else if (result == 4)
        //    {
        //        //каре
        //    }
        //    else if ((int)cards[4].Rank - (int)cards[0].Rank == 4)
        //    {
        //        Strit();
        //        if (strit == true)
        //        {
        //            //стрит
        //        }
        //    }
        //    int valsuit = cards.Select(x => x.Suit).GroupBy(g => g).OrderByDescending(o => o.Count()).FirstOrDefault().Count();
        //    if ((int)cards[4].Suit - (int)cards[0].Suit == 4)
        //    {
        //        Strit();
        //        if (strit == true && valsuit == 5)
        //        {
        //            //флеш рояль
        //        }
        //    }
        //    else if (valsuit == 5)
        //    {
        //        //флеш
        //    }

        //    void Strit()
        //    {
        //        for (int i = 0; i < (int)cards.Count - 1; i++)
        //        {
        //            if ((int)cards[i + 1].Rank - (int)cards[i].Rank == 1)
        //            {
        //                strit = true;
        //            }
        //            else
        //            {
        //                strit = false;
        //                break;
        //            }
        //        }
        //    }
        //}
    }
}
