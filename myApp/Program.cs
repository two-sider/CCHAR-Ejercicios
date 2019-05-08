using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Cual es tu edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu edad es {0}",edad);
        }
    }
}
