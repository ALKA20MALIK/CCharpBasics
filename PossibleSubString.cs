using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    class PossibleSubString
    {
        void generateSubstrings(string inputstr)
        {
            string FinalString = "";
            string str = "";
            for (int i = 0; i < inputstr.Length; i++)
            {
                str = "";
                for (int j = i; j < inputstr.Length; j++)
                {
                    str += inputstr[j];
                    FinalString += str+',';
                }
            }
            FinalString = FinalString.Remove(FinalString.Length-1);
            string[] arr = FinalString.Split(',');
            arr = arr.Distinct().ToArray();
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
           
        }
        void stringOperations(string str)
        {
            string strReverse = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                strReverse += str[i];
            }
           
            Console.WriteLine($"\nReversed String: {strReverse}");

            char[] arr = str.Reverse().ToArray();
            foreach (var item in arr)
            {
                Console.Write($" {item}, ");
            }
            Console.Write($"\nToLower Case: {str.ToLower()}");
            Console.Write($"\nToUpper Case: {str.ToUpper()}");

            // Console.Write($"\nToLowerInvariant: {str.ToLowerInvariant()}");
            String str1 = "hello";
            String strCloned = str1.Clone().ToString();
            strCloned = "mai";
            //int n= str1.CompareTo(strCloned);
            //Console.Write($"\nCloned: {strCloned }");
            //int n = str1.CompareTo(strCloned);
            Console.WriteLine();
           

        }
        static void Main(string[] args)
        {
            //string name = "abc";
            //char[] array = new char[3];
            //string [] strarray = new string[6];
            //array = name.ToCharArray();
            //name = string.Join(",", array);
            //Console.WriteLine(name);
            //int i = 6;
            //strarray=name.Split(',','6');
            PossibleSubString ps = new PossibleSubString();
            ps.generateSubstrings("alka");
            ps.stringOperations("alka");


        }
    }
}
