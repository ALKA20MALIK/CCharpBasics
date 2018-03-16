using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    delegate int PrintMsgDelegate(out int z);

    class clsDelegate
    {

       public int  PrintMsg1(out int x)
        {
            x = 1;
            return 1;
            //Console.WriteLine("PrintMsg1");
        }
        public int PrintMsg2(out int x)
        {
            x = 2;
            return 2;
            //Console.WriteLine("PrintMsg2");
        }
        public int PrintMsg3(out int x)
        {
            x = 3;
            //Console.WriteLine("PrintMsg3");
            return 3;
           
        }
    }


}
