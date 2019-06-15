﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public static class Class1
    {
        public static IEnumerable<IEnumerable<T>> Transpose<T>(this IEnumerable<IEnumerable<T>> source)
        {
            if (source == null) throw new ArgumentNullException("source");
            var enumerators = source.Select(x => x.GetEnumerator()).ToArray();
            try
            {
                while (enumerators.All(x => x.MoveNext()))
                {
                    yield return enumerators.Select(x => x.Current).ToArray();
                }
            }
            finally
            {
                foreach (var enumerator in enumerators)
                    enumerator.Dispose();
            }
        }

    }
}
