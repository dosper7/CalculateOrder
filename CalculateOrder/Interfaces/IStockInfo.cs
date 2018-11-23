using CalculateOrder.Order;
using System.Collections.Generic;

namespace CalculateOrder.Interfaces
{
    public interface IStockInfo
    {
        List<ProductStock> GetProductsInStock();
    }
}
