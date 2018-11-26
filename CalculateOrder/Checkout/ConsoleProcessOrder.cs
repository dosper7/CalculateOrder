using CalculateOrder.Interfaces;
using System.Linq;

namespace CalculateOrder.Checkout
{
    public class ConsoleProcessOrder : IProcessOrder
    {
        public IOrderInfo Order { get; set; }
        public IStockInfo Stock { get; set; }

        public ConsoleProcessOrder(IOrderInfo order, IStockInfo stock)
        {
            this.Order = order;
            this.Stock = stock;
        }

        public double GetTotal(double VAT)
        {
            double total = 0;
            var stock = Stock.GetProductsInStock();

            foreach (var prodOrder in Order.Items)
            {
                var prodInStock = stock.FirstOrDefault(p => p.ProductCode == prodOrder.ProductCode);
                if (prodInStock != null)
                {
                    var numItems = Math.Min(prodOrder.Quantity, prodInStock.Quantity);
                    total += numItems * prodInStock.Price;
                }
            }

            return total * (1 + VAT);
        }


    }
}
