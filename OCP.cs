using System;
namespace CCharpBasic
{   
    

    public abstract class Employee
    {
        public void printEmployeeName(string Name)
        {
            Console.WriteLine(Name);
        }
        public abstract decimal calculateBonus(string type);

    }
    public class PermanentEmployee2: Employee
    {
        public override decimal calculateBonus(string type)
        {
            return 5000*.5m;
        }
    }
    public class ContractEmployee2 : Employee
    {
        public override decimal calculateBonus(string type)
        {
            return 5000 * .1m;
        }
    }
        
    public class OtherEmployee2: Employee
    {
        public override decimal calculateBonus(string type)
        {
            return 5000 * .05m;
        }

    }
}
    
