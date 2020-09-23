using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa laskemaan!");
         /* Console.WriteLine("Anna ensimmäinen luku");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Summa on: " + c);
            */
            
            Console.WriteLine("Anna ensimmäinen luku: ");
            string luku1 = Console.ReadLine();
            Console.WriteLine("Anna toinen luku: ");
            string luku2 = Console.ReadLine();
            int summa = int.Parse(luku1) + int.Parse(luku2);
            Console.WriteLine("Summa on: " + summa);
        }
    }
}
