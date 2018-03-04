using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    abstract class DefaultImplimentation
    {
        public abstract float calculateSalary();
    
        public void DisplayName(string FirstName,string LastName)
        {
            Console.WriteLine($"First Name: {FirstName}, LastName:  {LastName}");
        }
    }

    class PermanentEmployee: DefaultImplimentation
    {
        public override float calculateSalary()
        {
            return 50000;
        }
    }
    class ContractEmployee: DefaultImplimentation
    {
        public override float calculateSalary()
        {
            return 2000 * 10;
        }

    }
    class TemporaryEmployee : DefaultImplimentation
    {
        public override float calculateSalary()
        {
            return 2000 * 10;
        }

    }

}
