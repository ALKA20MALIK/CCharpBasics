using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class ShiftArrayBytwo
    {
        public void ShiftArray(int[] Array,int n,int Method)
        {
            if (Method == 1)
            {
                for (int j = 0; j < n; j++)
                {
                    int temp = Array[0];

                    for (int i = 1; i < Array.Length; i++)
                    {
                        Array[i - 1] = Array[i];
                    }
                    Array[Array.Length - 1] = temp;
                }
            }
           
            foreach (var item in Array)
            {
                Console.Write($"{item},");
            }
        }
    }
}
