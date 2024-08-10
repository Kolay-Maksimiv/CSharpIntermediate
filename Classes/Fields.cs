namespace Classes
{
    public static class Fields
    {
        public class Customer
        {
            public int Id;
            public string Name;

            public readonly List<Order> Orders = new List<Order>();

            public Customer(int id)
            {
                Id = id;
            }

            public Customer(int id, string name) : this(id)
            {
                Name = name;
            }

            public void Promote()
            {
                //Orders = new List<Order>();
            }
        }
        
        public class Order { }

        public static void FieldsProgram()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
