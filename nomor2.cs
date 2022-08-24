using System;

public class nomor2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your value");
        int nilai = int.Parse(Console.ReadLine());

        if(nilai>=90)
        {
            Console.WriteLine("A");
        }else 
        if(nilai>=80)
        {
            Console.WriteLine("B");
        }else 
        if(nilai>=70)
        {
            Console.WriteLine("C");
        }else 
        if(nilai>=60)
        {
            Console.WriteLine("D");
        }else if(nilai<=59)
        {
            Console.WriteLine("E");
        }
     
    }
}