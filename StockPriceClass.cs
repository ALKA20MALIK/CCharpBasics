using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CCharpBasic
{
    //find out best price to sell stock if you have choice of multiple times to buy and sell
    class StockPriceClass
    {
        public void CalculatePrice(int [] PriceList)
        {
            int buyDay = 0, sellDay = 0;
            int localMinima = 0, localMaxima = 0;
            for (int i = 0; i < PriceList.Length; i++)
            {
                if (!(i + 1 == PriceList.Length))
                {
                    if (PriceList[i] < PriceList[i + 1] && localMinima == 0)
                    {
                        localMinima = PriceList[i];
                        buyDay = i;
                    }
                    else if (localMinima != 0 && PriceList[i] > PriceList[i + 1])
                    {
                        localMaxima = PriceList[i];
                        sellDay = i;
                        Console.WriteLine($"Buy Day:{buyDay}");
                        Console.WriteLine($"Sell Day:{sellDay}");
                        localMaxima = 0;
                        localMinima = 0;
                    }
                }
                else
                {
                    localMaxima = PriceList[i];
                    sellDay = i;
                }
                if (localMaxima != 0 && localMinima != 0)
                {
                    Console.WriteLine($"Buy Day:{buyDay}");
                    Console.WriteLine($"Sell Day:{sellDay}");
                }
            }
        }

    }
    class IsElementExists
    {
        //IsElementExists
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
    class CampareArray
    {
        public void CampareArraytwoArray()
        {
            List<int> List1 = new List<int>() { 10,12};
            List<int> List2 = new List<int>() { 1, 2, 4, 5 };
         
            
            int[] arrayList = new int[5];
            arrayList = List1.Except(List2).ToArray();
            if (arrayList.Length > 0)
            { 
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }
                arrayList= arrayList.Reverse().ToArray();
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }
            }
           
           
        }
    }
}
