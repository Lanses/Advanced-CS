using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    class PockerCard : ICard
    {
        public List<int> pokerCards = new List<int>();

        public Guid Id { get; set; }

        public void Add(T)
        {
            pokerCards.Add(T);
        }

        public void Remove(T)
        {
            pokerCards.Remove(T);
        }
    }
}
