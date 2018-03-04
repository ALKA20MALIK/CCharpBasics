using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    
    class Program
    {
        readonly public int num;
        const  int num1 =1;
       
        static void Main(string[] args)
        {
            PermanentEmployee pe = new PermanentEmployee();
            pe.DisplayName("ALKA", "MALIK");
            Console.WriteLine(pe.calculateSalary());

            ContractEmployee ce = new ContractEmployee();
            ce.DisplayName("BHOOPENDRA", "RATHORE");
            Console.WriteLine(ce.calculateSalary());



        }
    }
}
