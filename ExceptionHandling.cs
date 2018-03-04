using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException():base(){
        }
        public InvalidAgeException(string str) : base(str)
        {

        }
    }
    class Person
    {
        private String _Name;
        private int _Age;
        public string Name
        {
            get
            {
               return _Name;
            }
            set
            {
                _Name = Name;
            }
        }
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value <= 0)
                {
                    InvalidAgeException obj = new InvalidAgeException("Age can not be 0");
                
                }
                else _Age = value;
            }
        }
    }
    class ExceptionHandling
    {
        public static void throwException(string str)
        {
                
            try
            {          
                str = str.ToString();
                    
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Exception");
            }

            finally
            {
               
                Console.WriteLine("Finally");
            }
        }
    }
}

