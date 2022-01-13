using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2  //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
        public static void Main(string[] args)     //DO NOT change the 'Main' method signature
        {
            //Implement the code here
            int pizzaprice = 200;
            int puffprice = 40;
            int pepsiprice = 120;
            Console.WriteLine("Enter the number of pizzas bought :");
            int numpizza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of puffs bought :");
            int numpuff = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of pepsi bought :");
            int numpepsi = Convert.ToInt32(Console.ReadLine());
            int pizzatotal = numpizza * pizzaprice;
            int pufftotal = puffprice * numpuff;
            int pepsitotal = pepsiprice * numpepsi;
            int total = pizzatotal + pufftotal + pepsitotal;
            double gst = 0.12 * total;
            double cess = 0.05 * total;
            Console.WriteLine();
            Console.WriteLine("Bill Details");
            Console.WriteLine();
            Console.WriteLine("Cost of Pizzas :" + pizzatotal);
            Console.WriteLine("Cost of Puffs :" + pufftotal);
            Console.WriteLine("Cost of Pepsis :" + pepsitotal);
            Console.WriteLine("GST 12% : " + gst);
            Console.WriteLine("CESS 5% : " + cess);
            Console.WriteLine("Total Price :" + total);
        }
    }
}
