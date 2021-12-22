using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals1             //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    { 
        public static void Main(string[] args)        //DO NOT CHANGE 'Main' Signature
        {
            //Fill the code here
            Console.Write("Enter your name:");
            string name=Console.ReadLine();
            Console.Write("Enter your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Country:");
            string country=Console.ReadLine();
            Console.Write("Welcome "+name+". Your age is "+age+" and you are from "+country);
        }
    }
}