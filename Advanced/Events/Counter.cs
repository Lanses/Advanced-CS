using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
        public delegate void HandleHundredDelegate();
         public class Counter
         {
            public void Count() { 
            for(int i = 0; i <= 100; i++)
            {
                if (i == 100)
                {
                    //notify everyone 100 apeared
                    HundredReached.Invoke();
                    i = 0;
                }
            }
        }

        public event HandleHundredDelegate HundredReached;

    }
}
