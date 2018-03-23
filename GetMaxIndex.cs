using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class GetMaxIndex
    {
        public static void getMaxIndexNum()
        {
            int[] array = { 1, 45, 5, 6, 1, 341, 1 };
            int x = 0,gcount=0, count=0;

            for (int i = 0; i < array.Length; i++)
            {
                count = 1;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > gcount)
                {
                    gcount = count;
                }
            }
            Console.WriteLine($"Max Count:{gcount}");

        }
       public static void Main(string[] arg)
        {
            GetMaxIndex.getMaxIndexNum();
        }
    }
}
