using System;

public class nomor3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your value");
        int nilai = int.Parse(Console.ReadLine());

        if(nilai%2 == 0)
        {
            Console.WriteLine("Genap");
        }else
        {
            Console.WriteLine("Ganjil");

        }
        
     
    }
}