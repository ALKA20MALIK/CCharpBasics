using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            PersonBChild pc1 = new PersonBChild();
            PersonBChild pc = new PersonBChild("ALka","Malik");
            VarAndDynamic vd1 = new VarAndDynamic();
            vd1.Displayvar();
            vd1.Displaydynamic(10233);
            vd1.DisplayChangeddynamic("Pooja");
            ConsAndReadOnly ro = new ConsAndReadOnly();

            Finalizer4 f = new Finalizer4();
        }
    }
}
