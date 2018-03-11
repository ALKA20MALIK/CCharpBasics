using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class VarAndDynamic
    {
        dynamic Name = "Malik";
      
        public void Displayvar()
        {
            var Name1 = "alka";
            Console.WriteLine($"Name1.Length : { Name1.Length}");

        }
        
        public void Displaydynamic(int i)
        {
            
            Console.WriteLine($"dynamic: {Name}");
            Console.WriteLine($"dynamicLength : {Name.Length}");
            Name = i;
            Console.WriteLine($"dynamic: {Name}");
            //Console.WriteLine($"dynamicLength : {Name.Length}");
        }
        public void DisplayChangeddynamic(string i)
        {
            Name = i;
            Console.WriteLine($"Change dynamic: {Name}");
            Console.WriteLine($"dynamicLength : {Name.Length}");
        }
    }
}
