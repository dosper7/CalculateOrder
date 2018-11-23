using CalculateOrder.Elements;
using System.Collections.Generic;

namespace CalculateOrder.Interfaces
{
    public interface IStockInfo
    {
        List<ProductStock> GetProductsInStock();
    }
}
