using System;

public class nomor4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your value");
        int tahun = int.Parse(Console.ReadLine());

        if(tahun%400 == 0)
        {
            Console.WriteLine("Tahun Kabisat");

        }else if(tahun%100 == 0)
        {
            Console.WriteLine("Bukan Tahun Kabisat");

        }else if(tahun%100 == 0 && tahun%400 == 0 )
        {
            Console.WriteLine("Tahun Kabisat");
        }
        else if (tahun % 4 == 0)
        {
            Console.WriteLine("Tahun Kabisat");
        }else 
        {
            Console.WriteLine("Bukan Tahun Kabisat");
        }      
     
    }
}