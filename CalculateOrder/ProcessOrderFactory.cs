using CalculateOrder.Checkout;
using CalculateOrder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateOrder
{
    public class ProcessOrderFactory
    {
        public static IProcessOrder Get(string typeName, IOrderInfo orderInfo, IStockInfo stockInfo)
        {
            switch (typeName)
            {
                case "console":
                    return new ConsoleProcessOrder(orderInfo, stockInfo);
                default:
                    throw new NotSupportedException("Unsupported process order type");
            }
        }
    }
}
