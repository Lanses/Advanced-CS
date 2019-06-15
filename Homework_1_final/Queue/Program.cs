using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Queue<int> q = new Queue<int>();

        q.Enqueue(7);
        q.Enqueue(15);
        q.Enqueue(24);

        int[] arr = q.ToArray();

    }
}