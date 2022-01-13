using System;
using System.Collections;
using System.Globalization;
using System.IO;


public class Program  //DO NOT CHANGE the name of class 'Program'
{
    public static void Main(string[] args) //DO NOT CHANGE 'Main' Signature
    {

        //Fill the code here
        StreamReader reader = new StreamReader("input.csv");
        string data = "";
        Product p = null;
        ArrayList arlobj = new ArrayList();
        while ((data = reader.ReadLine()) != null)
        {
            string[] info = data.Split(',');
            string productName = info[0].Trim();
            string serialNumber = info[1].Trim();
            DateTime purchaseDate = DateTime.ParseExact(info[2].Trim(), "dd-MM-yyyy", null);
            double cost = Double.Parse(info[3].Trim());
            p = new Product(productName, serialNumber, purchaseDate, cost);
            arlobj.Add(p);

        }
        Console.WriteLine("{0}", String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", "Purchase Date", "Cost"));
        foreach (var obj in arlobj)
        {
            Product prd = (Product)obj;
            Console.WriteLine("{0}", prd.ToString());
        }
    }

}