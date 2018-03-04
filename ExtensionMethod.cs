using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    static class ExtensionMethod
    {
            public static string ToUpperCase(this string str)
            {
                str = str.ToUpper();
                return str;
            }
    }
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class CultureAttribute:Attribute
    {
        string _culture;
        public string culture
        {
            get
            {
                return _culture;
            }
            set
            {
                _culture= culture;
            }
        }
    }
    
}
