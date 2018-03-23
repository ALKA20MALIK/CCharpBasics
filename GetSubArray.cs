using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class GetSubArray
    {
        public static void printSubArray()
        {
            int[] array1 = { 1 ,12 ,3 ,4 ,5, 14 ,7, 8, 9, 10 };
            int[] subArray = new int[10];
            Console.WriteLine(Array.BinarySearch(array1,12));
            return;
            int x = 0,k=0;
            for (int i = 0; i < array1.Length; i++)
            {
                x = array1[i];
                k = 0;
                Array.Clear(subArray,0,subArray.Length);
                
                 subArray[k] = array1[i];
                for (int j = i+1; j < array1.Length; j++)
                {
                    x+= array1[j];
                    k++;
                    subArray[k] = array1[j];
                    if (x==15)
                    {
                        foreach (var item in subArray)
                        {
                            if (item == 0) { break; }
                            Console.WriteLine(item);
                        }
                        break;
                    }
                }
                break;
            }
        }

        static void Main(string[] args)
        {
            GetSubArray.printSubArray();
        }

    }
}
