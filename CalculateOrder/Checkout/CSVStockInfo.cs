using CalculateOrder.Interfaces;
using CalculateOrder.Elements;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CalculateOrder.Checkout
{
    public class CSVStockInfo : IStockInfo
    {
        private string CsvFilePath { get; set; }
        private List<ProductStock> stockList = null;

        public CSVStockInfo(string csvFilePath)
        {
            this.CsvFilePath = csvFilePath;
            ParseCsvFile();
        }

        public List<ProductStock> GetProductsInStock()
        {
            return this.stockList;
        }

        private void ParseCsvFile()
        {
            this.stockList = new List<ProductStock>();
            if (File.Exists(this.CsvFilePath))
            {
                var readingFileTask = File.ReadAllLinesAsync(CsvFilePath);
                readingFileTask.Wait();
                var lines = readingFileTask.Result;

                if (lines.Length > 0)
                {
                    foreach (var item in lines)
                    {
                        var stockInfo = item.Split(",");
                        if (stockInfo.Length == 3)
                        {
                            stockList.Add(new ProductStock()
                            {
                                ProductCode = stockInfo[0],
                                Quantity = int.Parse(stockInfo[1]),
                                Price = double.Parse(stockInfo[2], CultureInfo.GetCultureInfo("en-us")),
                            });
                        }
                    }
                }
            }
        }


    }
}
