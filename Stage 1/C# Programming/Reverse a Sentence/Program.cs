using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        string rev = "";
        string[] temp = str.Split();
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            rev += temp[i] + " ";
        }
        Console.WriteLine(rev);
    }
}
