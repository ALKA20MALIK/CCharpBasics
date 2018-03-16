using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CCharpBasic
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            PermanentEmployee pe = new PermanentEmployee();
            //pe.DisplayName("ALKA", "MALIK");
            //Console.WriteLine(pe.calculateSalary());

            //ContractEmployee ce = new ContractEmployee();
            //ce.DisplayName("BHOOPENDRA", "RATHORE");
            // Console.WriteLine(ce.calculateSalary());

            //PersonBChild pc1 = new PersonBChild();
            //PersonBChild pc = new PersonBChild("ALka","Malik");
            //VarAndDynamic vd1 = new VarAndDynamic();
            //vd1.Displayvar();
            //vd1.Displaydynamic(10233);
            //vd1.DisplayChangeddynamic("Pooja");
            //ConsAndReadOnly ro = new ConsAndReadOnly();

            //Finalizer4 f = new Finalizer4();
            //StockPriceClass sc = new StockPriceClass();


            //Console.WriteLine("Enter Number of priceList Array:");
            //int arrLen = Convert.ToUInt16(Console.ReadLine());
            //int[] arrList = new int[arrLen];
            //for (int i = 0; i < arrLen; i++)
            //{
            //    Console.WriteLine($"Enter {i + 1} Price of priceList Array:");
            //    int Price = Convert.ToUInt16(Console.ReadLine());
            //    arrList[i] = Price;
            //}
            //Console.WriteLine($"You have enter PriceList:");
            //foreach (var item in arrList)
            //{
            //    Console.Write($"{item},");
            //}
            //Console.WriteLine("Calculate Stock Price To Buy/sell :Press Any key...");
            //Console.ReadKey();
            //sc.CalculatePrice(arrList);
            //int[] Array1 = {2,1,9,5657 };
            //int[] Array2 = {1,3,5,8,10};
            //IsElementExists x = new IsElementExists(Array1, Array2);
            //CampareArray ca = new CampareArray();
            //ca.CampareArraytwoArray();
            //ShiftArrayBytwo sf = new ShiftArrayBytwo();

            //sf.ShiftArray(arrList,4,1);
            //sf.ShiftArray(arrList,2,2);
            // Displaying double quotes in c#
            //int[,] arr = { { 2,5,7},{1,6,9 } };


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{arr[i,j]},");
            //    }
            //    Console.WriteLine();
            //}
            //MissingNumber m = new MissingNumber();
            //m.MissingNum();
            //SwitchCase s = new SwitchCase();
            //s.Decision();
            clsDelegate cd = new clsDelegate();
            PrintMsgDelegate m1 = new PrintMsgDelegate(cd.PrintMsg1);
            PrintMsgDelegate m2 = new PrintMsgDelegate(cd.PrintMsg2);
            PrintMsgDelegate m3 = new PrintMsgDelegate(cd.PrintMsg3);
            PrintMsgDelegate m4 = m1 + m2 + m3;
            int x=m4();
            Console.WriteLine(x);
        }
    }
}
