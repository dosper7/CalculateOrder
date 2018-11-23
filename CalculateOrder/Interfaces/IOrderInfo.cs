using CalculateOrder.Elements;
using System.Collections.Generic;

namespace CalculateOrder.Interfaces
{
    public interface IOrderInfo
    {
        List<OrderItem> Items { get; set; }
    }
}
