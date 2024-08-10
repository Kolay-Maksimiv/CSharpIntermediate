namespace Inheritance
{
    public static class AccessModifiers
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Promote()
            {
                var rating = CulculateRating(excludeOrders: true);

                if (rating == 0)
                    Console.WriteLine("Promoted to Level 1");
                else
                    Console.WriteLine("Promoted to Level 2");
            }

            protected int CulculateRating(bool excludeOrders)
            {
                return 0;
            }
        }

        public class GoldCustomer : Customer
        {
            public void OfferVouchar()
            {
                var rating = CulculateRating(excludeOrders: true);
            }
        }

        public static void AccessModifiersProgram()
        {
            var goldCustomer = new GoldCustomer();

            goldCustomer.OfferVouchar();

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
