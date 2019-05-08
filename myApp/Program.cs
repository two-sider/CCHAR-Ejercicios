using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            while (true){
            Console.WriteLine("Cual es tu edad");
            edad = Convert.ToInt32(Console.ReadLine());
            
            if (edad >=18)
            {
                Console.WriteLine("Tu edad es {0} y eres mayor de edad",edad);
                break;
            }
            else if (edad < 0) 
            {
                Console.WriteLine("No existes, por favor intenta con una edad real");
            }
            else
            {
                Console.WriteLine("Tu edad es {0} y no eres mayor de edad",edad);
                break;
            }
            }


        }
    }
}
