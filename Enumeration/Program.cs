using Enumeration.Entities;
using Enumeration.Entities.Enums;
using System;

/*    OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 
      OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered"); 
      
      OrderStatus os;
      Enum.TryParse("Delivered", out os);*/

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
