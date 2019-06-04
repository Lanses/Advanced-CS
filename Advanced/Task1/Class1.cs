using System;
using System.Collections.Generic;
using System.Text;
using static Task1.Class1;

namespace Task1
{
    public delegate void HandleNumbers(int x, int y);

    public class Class1
    {

        public void Multiplying(int x, int y)
        {
            if (x >= 0  && y >=0)
            {
                x *= y;
                y *= x;
                NumbersMultiplied?.Invoke(x, y);
            }
        }

        public event HandleNumbers NumbersMultiplied;
    }
}
