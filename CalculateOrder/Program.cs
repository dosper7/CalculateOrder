using CalculateOrder.Checkout;
using CalculateOrder.Interfaces;
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
            IProcessOrder po = ProcessOrderFactory.Get("console", orderInfo, stockInfo);
            var total = po.GetTotal(23);

            Console.WriteLine($"total order price: {total}");
            Console.ReadKey();
        }

    }
}
