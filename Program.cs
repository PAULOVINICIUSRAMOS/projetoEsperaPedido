using Course.Endities;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Endities.Enums;

namespace Course
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


            Console.WriteLine(txt);


            Console.ReadLine();
        }
    }

}
