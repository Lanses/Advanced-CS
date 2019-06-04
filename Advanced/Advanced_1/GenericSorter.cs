using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced_1
{
    public class GenericSorter<T, V> where T : ICollection<V> where V : IComparable
    { 
        public IEnumerable<V> Sort(T collection)
        {
            return Enumerable.Empty<V>();
        }
    }
}
