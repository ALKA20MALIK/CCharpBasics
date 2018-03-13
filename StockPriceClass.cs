using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    //find out best price to sell stock if you have choice of multiple times to buy and sell
    class SotckClass
    {
        public void CalculatePrice(int [] PriceList)
        {
            int localMinima = 0, localMaxima = 0;
            for (int i = 0; i < PriceList.Length; i++)
            {
                if (!(i + 1 == PriceList.Length))
                {
                    if (PriceList[i] < PriceList[i + 1] && localMinima == 0)
                    {
                        localMinima = PriceList[i];
                    }
                    else if (localMinima != 0 && PriceList[i] > PriceList[i + 1])
                    {
                        localMaxima = PriceList[i];
                        Console.WriteLine($"Local Minima:{localMinima}");
                        Console.WriteLine($"Local Maxima:{localMaxima}");
                        localMaxima = 0;
                        localMinima = 0;
                    }
                }
                else
                {
                    localMaxima = PriceList[i];
                }
                if (localMaxima != 0 && localMinima != 0)
                {
                    Console.WriteLine($"Local Minima:{localMinima}");
                    Console.WriteLine($"Local Maxima:{localMaxima}");
                }
            }
        }

    }
}
