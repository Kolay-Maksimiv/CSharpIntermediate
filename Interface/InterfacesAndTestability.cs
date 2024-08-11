
namespace Interface
{
    public static class InterfacesAndTestability
    {
        public class OrderProcessor
        {
            private readonly IShippingCalculator _shippingCalculator;

            public OrderProcessor(IShippingCalculator shippingCalculator)
            {
                _shippingCalculator = shippingCalculator;
            }

            public void Process(Order order)
            {
                if (order.IsShipped)
                    throw new InvalidOperationException("This order is already processed");

                order.Shipment = new Shipment
                {
                    Cost = _shippingCalculator.CalculateShipping(order),
                    ShippingDate = DateTime.Today.AddDays(1)
                };
            }
        }

        public class Order
        {
            public DateTime DatePlaced { get; set; }
            public float TotalPrice { get; set; }
            public Shipment Shipment { get; set; }
            public bool IsShipped
            {
                get { return Shipment is not null; }
            }
        }

        public interface IShippingCalculator
        {
            float CalculateShipping(Order order);
        }

        public class ShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                if (order.TotalPrice < 30f)
                    return order.TotalPrice * 0.1f;

                return 0;
            }
        }

        public class Shipment
        {
            public float Cost { get; set; }
            public DateTime ShippingDate { get; set; }
        }

        public static void InterfacesAndTestabilityProgram()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}