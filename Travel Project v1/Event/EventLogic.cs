﻿using Event.Deleagte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{ 

    public class EventLogic
    {
        public void PriceOfFlight(double d)
        {
            if (d >= 100 && d <= 300)
            {
                d *= 0.5;
            }
            else if (d >= 300 && d <= 700)
            {
                d *= 0.45;
            }
            else if (d >= 700 && d <= 1500)
            {
                d *= 0.4;
            }
        }

        public event HandleEvent PriceDependingDistanceCalculation;

    }
}
