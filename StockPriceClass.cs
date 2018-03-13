using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    //find out best price to sell stock if you have choice of multiple times to buy and sell
    class StockPriceClass
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
    class IsElementExists
    {
        public IsElementExists(int[] Array1, int[] Array2)
        {
          
            for (int i = 0; i < Array1.Length; i++)
            {
               
                for (int j = 0; j < Array2.Length; j++)
                {
                    if (Array1[i] != Array2[j] && j+1 == Array2.Length)
                    {
                        Console.WriteLine($"Not exists in Array2:{Array1[i]}");
                       
                    }
                    else if (Array1[i] == Array2[j])
                    {
                        break;                       
                    }
                }
                
            }

        }
    }
}
