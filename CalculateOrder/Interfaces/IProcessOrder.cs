using System.Collections.Generic;

namespace CalculateOrder.Interfaces
{
    public interface IProcessOrder
    {
        IOrderInfo Order { get; set; }
        IStockInfo Stock { get; set; }
        double GetTotal(double VAT);
    }
}
