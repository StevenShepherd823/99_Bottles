using System;

namespace _99_Botttles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many bottles are on the wall?");
            int bottles = Convert.ToInt32(Console.ReadLine());

            while (bottles > 1)
            {
                Console.WriteLine($"{bottles} bottles of beer on the wall.");
                Console.WriteLine($"{bottles} bottles of beer!");
                Console.WriteLine($"Take one down, Pass it around");
                bottles--;
                Console.WriteLine($"{bottles} of beer on the wall!");
                Console.WriteLine("");
            }
                Console.WriteLine($"Last bottle of beer on the wall.");
                Console.WriteLine($"Last bottle of beer!");
                Console.WriteLine($"Take it down, Pass it around");
               
                Console.WriteLine($"No MORE Bootles of beer on the wall!");

            
            
        }
    }
}
