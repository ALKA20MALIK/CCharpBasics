using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class SRP
    {

    }
    interface IUser
    {
        bool LoginUser(string UserName,string Password);
        bool RegisterUser(string UserName, string Email, string Password);
       
    }
    interface IEmailSender
    {
        bool SendEmail();
    }
    interface ILogger
    {
        bool LogError();
    }
   
}
