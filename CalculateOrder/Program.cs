using CalculateOrder.Checkout;
using System;
using System.Linq;

namespace CalculateOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
                Console.WriteLine("Missing order info");

            var stockInfo = new CSVStockInfo(args[0]);
            var orderInfo = new ConsoleOrderInfo(args.Skip(1));
            var processOrder = new ConsoleProcessOrder(orderInfo, stockInfo);
            var total = processOrder.GetTotal(23);

            Console.WriteLine($"total order price: {total}");
            Console.ReadKey();
        }

    }
}
