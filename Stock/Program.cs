using System;
using System.Collections.Generic;
using System.Linq;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stocks = new List<int> { 20, 40, 52, 15, 30, 50, 10, 25 };
            List<int> profits = new List<int> { };
            foreach (var item in stocks)
            {
                var indexOf = stocks.IndexOf(item);
                var nextIndex = indexOf + 1;
                if (nextIndex != 8)
                {
                    var profit = stocks[nextIndex] - stocks[indexOf];
                    profits.Add(profit);
                    var max = profits.Max();
                    if (profit > 0)
                    {
                        Console.WriteLine("Index: {4} -\t Buy = {0},\t Sale= {1} \t and Profit = {2} \n\t\t Max Profit={3} \n\n", item, stocks[nextIndex], profit, max,indexOf);
                    }else if (profit < 0)
                    {
                        Console.WriteLine("Index: {1} -\t\t Loss= {0} \n", profit,indexOf);
                    }
                }
            }
          
            Console.ReadLine();
        }
    }
}
