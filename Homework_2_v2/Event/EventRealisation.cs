using Event.Delegate;

namespace Event
{
    public class EventRealisation
    {

        public event HandleEvent PriceDependingDistanceCalculation;
        public event ChangedPriceHandler ChangedPrice;

        public PriceOfFlight Price(Price d)
        {
            var priceOfFlight = new PriceOfFlight
            {
                D = d.D
            };

            PriceDependingDistanceCalculation.Invoke(priceOfFlight.D);
            return GetPrice(priceOfFlight);

        }

        private PriceOfFlight GetPrice(PriceOfFlight priceOfFlight, int a = 100, int b = 300, int c = 700, int e = 1500)
        {

            if (priceOfFlight.D >= a && priceOfFlight.D <= b)
            {
                priceOfFlight.D *= 0.5;


            }
            else if (priceOfFlight.D >= b && priceOfFlight.D <= c)
            {
                priceOfFlight.D *= 0.45;

                ChangedPrice?.Invoke(priceOfFlight.D);
            }
            else if (priceOfFlight.D >= c && priceOfFlight.D <= e)
            {
                priceOfFlight.D *= 0.4;
            }

            return priceOfFlight;

        }
    }
}