using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_1
{
    public class Class1
    {
        public void Do()
        {
            var stringList = new List<int>();
            var hashSet = new HashSet<int>();
            var sorter = new GenericSorter<ICollection<int>, int>();
            var sortedStringList = sorter.Sort(stringList);
            var sorted = sorter.Sort(hashSet);
        }
    }
}
