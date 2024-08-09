namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            Name = name;
        }
    }

    public class Order
    {

    }

    public static class Constructors
    {
        public static void ConstructorsProgram()
        {
            var customer = new Customer(1,"Mykola");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
