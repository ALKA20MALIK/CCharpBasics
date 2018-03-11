using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class Finalizer1
    {
        ~Finalizer1()
        {
            Console.WriteLine($"Finalizer1");
        }
    }
    class Finalizer2:Finalizer1
    {
        ~Finalizer2()
        {
            Console.WriteLine($"Finalizer2");

        }
    }
    class Finalizer3: Finalizer2
    {
        ~Finalizer3()
        {
            Console.WriteLine($"Finalizer3");

        }
    }
    class Finalizer4: Finalizer3
    {
        ~Finalizer4()
        {
            Console.WriteLine($"Finalizer4");

        }
    }
}
