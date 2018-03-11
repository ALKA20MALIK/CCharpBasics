using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class PersonA
    {
        private string _FirstName, _LastName;

        public string FirstName
        {
            set { _FirstName = value; }
            get { return _FirstName; }
        }
        public string LastName
        {
            set { _LastName = value; }
            get { return _LastName; }
        }

    }

    class PersonB
    {
        private string FirstName, LastName;
        public PersonB()
        {
            Console.WriteLine("default PersonB");
        }
        public PersonB(string FName,string LName)
        {
            FirstName = FName;
            LastName = LName;
            Console.WriteLine($"{FirstName +" "+ LastName}");
        }
        
    }

    abstract class absBase {
        public abstract void absprint();
        public virtual void print() { }
    }
    class absChild: absBase
    {
        public sealed override void absprint(){}
        public sealed override void print() { }

    }

    class PersonBChild: PersonB
    {
        static int Count;
        //private string FirstName, LastName;

        public PersonBChild() : base() { }
        public PersonBChild(string FName, string LName) :base(FName, LName) { }
        //{
        //    //FirstName = FName;
        //    //LastName= LName;
        //    //Console.WriteLine($"Base Class Member FullName: {FirstName+" "+LastName}");
        //}
        static PersonBChild()
        {
            Count++;
            Console.WriteLine($"static Count: {Count}");
        }
        ~PersonBChild()
        {
            Console.WriteLine("Hello Dear");
        }
    }

    class CopyPerson
    {
        string FirstName, LastName;
        public CopyPerson(string FN,string LN)
        {
            FirstName = FN;
            LastName = LN;
            Console.WriteLine($"{FirstName +" "+LastName}");
        }
        public CopyPerson(CopyPerson person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Console.WriteLine($"Copied: {FirstName + " " + LastName}");
        }

        public string Fname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
    }
   
}
