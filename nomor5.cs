using System;

public class nomor5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your value");
        int usia = int.Parse(Console.ReadLine());

        if(usia>=21)
        {
            Console.WriteLine("Dewasa");
        }else if(usia>=13)
        {
            Console.WriteLine("Remaja");
        }else if(usia>=9)
        {
            Console.WriteLine("Bimbingan Orang Tua");
        }else if(usia<9)
        {
            Console.WriteLine("Semua Usia");
        }
        
     
    }
}