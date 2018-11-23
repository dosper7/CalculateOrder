using CalculateOrder.Interfaces;
using CalculateOrder.Elements;
using System.Collections.Generic;
using System.Linq;

namespace CalculateOrder.Checkout
{
    public class ConsoleOrderInfo : IOrderInfo
    {
        private List<string> ConsoleProductData { get; set; }
        public List<OrderItem> Items { get; set; }

        public ConsoleOrderInfo(IEnumerable<string> consoleProductData)
        {
            this.ConsoleProductData = consoleProductData.ToList();
            ParseProducts();
        }

        private void ParseProducts()
        {
            this.Items = new List<OrderItem>();
           

            while (this.ConsoleProductData.Count != 0)
            {
                Items.Add(new OrderItem()
                {
                    ProductCode = this.ConsoleProductData[0],
                    Quantity = int.Parse(this.ConsoleProductData[1])
                });

                this.ConsoleProductData = this.ConsoleProductData.Skip(2).ToList();
            }


        }

    }
}
