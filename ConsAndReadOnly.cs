using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class ConsAndReadOnly
    {
        const decimal Pi = 3.14m;
        readonly static decimal PistaticReadOnly;
        readonly public decimal PiReadOnly;

        public void Display()
        {
           
            Console.WriteLine($"PistaticReadOnly : {PistaticReadOnly}");
            Console.WriteLine($"PiReadOnly : {PiReadOnly}");

        }
        //public ConsAndReadOnly()
        //{

        //    PiReadOnly = 45;         
        //    Console.WriteLine($"PiReadOnly defult :{PiReadOnly}");
        //}
        //public ConsAndReadOnly(decimal value)
        //{
        //    PiReadOnly = value;
        //    Console.WriteLine($"PiReadOnly not defult :{PiReadOnly}");
        //}
        //static ConsAndReadOnly()
        //{ 
        //    PistaticReadOnly = 345m;
        //    Console.WriteLine($"PistaticReadOnly static :{PistaticReadOnly}");
        //}

    }
}
