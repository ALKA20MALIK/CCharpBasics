using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class MissingNumber
    {
        public void MissingNum()
        {
            int[] array = { 1,4,5,6,9 };
            int x = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (x == array[i])
                {
                }
                else
                {
                    Console.WriteLine($"Missing Number:{x}");
                    i--;           
                }
                x++;
            }
        }
    }
}
