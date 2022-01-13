using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(string[] args)
    {
        string fname, lname, fullName;
        Console.WriteLine("Enter first name:");
        fname = Console.ReadLine();
        Console.WriteLine("Enter last name:");
        lname = Console.ReadLine();
        fullName = fname + " " + lname;
        Console.WriteLine("Full name : " + fullName);
    }
}
