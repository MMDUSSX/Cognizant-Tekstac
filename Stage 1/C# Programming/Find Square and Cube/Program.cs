using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2               //DO NOT Change namespace name
{
    public class Program                //DO NOT Change class 'Program' name
    {
        public static void Main(string[] args)        //DO NOT Change 'Main' method Signature
        {
            //Implement your code here
            Console.WriteLine("Enter a Number");
            double number=Convert.ToDouble(Console.ReadLine());
            double squarenumber=FindSquare(number);
            double cubenumber=FindCube(number);
            Console.WriteLine("Square of "+number+" is "+squarenumber);
            Console.WriteLine("Cube of "+number+" is "+cubenumber);
        }

      //Implement methods here. Keep the method 'public' and 'static'
      static double FindSquare(double num){
          return num*num;
          
      }
      
      static double FindCube(double num){
          return num*num*num;
      }
    }
}
