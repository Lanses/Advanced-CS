using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    class TaroCard : ICard
    {
        public List<int> taroCards = new List<int>();

        public void Do()
        {
            var pokerDeck = new Deck<PokerCard>();
            pokerDeck.Add();
        }


        public Guid Id { get; set; }

        public void Add(T)
        {
            taroCards.Add(T);
        }

        public void Remove(T)
        {
            taroCards.Remove(T);
        }

    }
}
