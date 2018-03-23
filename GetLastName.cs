using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CCharpBasic
{
    class GetLastName
    {
        public static void PrintLastName()
        {
            Console.WriteLine("Enter Full Name");
            string FullName = Console.ReadLine();
            string LastName, FirstName,MiddleName;
            //string LastName = FullName.Substring(startIndex); get Last name by substing()
            //ArrayList Array = new ArrayList();
            int Len=FullName.Split().Length-1;
            //string splitedArrLen = FullName.Split(" "); 
            //string LastName = FullName.Split()[Len]; //get Last name by split()
            int i = FullName.Length-1, j=0,startIndex = 0,endIndex = 0;

            while (i>= 0)
            {
                if(FullName[i] ==' ')
                {
                    break;
                }
                startIndex++;
                i--;
            }
            startIndex = FullName.Length - startIndex;
            LastName = FullName.Substring(startIndex);
            //Console.WriteLine($"LastName: {LastName}");

            while (j <= FullName.Length - 1)
            {
                if (FullName[j] == ' ')
                {
                    break;
                }
                endIndex++;
                j++;
            }

            //FirstName = FullName.Substring(0, endIndex);
            //Console.WriteLine($"FirstName: {FirstName}");
            //MiddleName = FullName.Substring(endIndex + 1, FullName.Length - startIndex-1);
            //Console.WriteLine($"Middle Name: {MiddleName}");
            //Through Spliter
            
            int index1 = FullName.Split()[0].Length;
            int index2 = FullName.Split()[1].Length;
            int index3 = FullName.Split()[2].Length;
            Console.WriteLine($"First Name :{FullName.Split()[0]}");
            Console.WriteLine($"Middle Name: {FullName.Split()[1]}");
            Console.WriteLine($"Last Name: {FullName.Split()[2]}");


        }
        public static void Main()
        {
            GetLastName.PrintLastName();
        }
       
    }
}
