using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order(100.0, "USA", new List<PackingLabel>(), new List<ShippingLabel>());
        Order order2 = new Order(200.0, "Canada", new List<PackingLabel>(), new List<ShippingLabel>());
        Order order3 = new Order(300.0, "Mexico", new List<PackingLabel>(), new List<ShippingLabel>());
        Order order4 = new Order(400.0, "USA", new List<PackingLabel>(), new List<ShippingLabel>());


        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);
        orders.Add(order4);
    }
}