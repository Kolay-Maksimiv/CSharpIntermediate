namespace Classes
{
    public class Customer1
    {
        public int Id;
        public string Name;

        public readonly List<Order> Orders = new List<Order>();

        public Customer1(int id)
        {
            Id = id;
        }

        public Customer1(int id, string name) : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }
    }

    public static class Fields
    {
        public static void FieldsProgram()
        {
            var customer = new Customer1(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
