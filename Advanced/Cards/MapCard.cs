using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards
{
    class MapCard : ICard
    {
        public List<int> mapCards = new List<int>();

        public Guid Id { get; set; }

        public void Add(T)
        {
            mapCards.Add(T);
        }

        public void Remove(T)
        {
            mapCards.Remove(T);
        }

    }
}
