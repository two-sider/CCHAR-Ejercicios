using System;

namespace myApp
{
    class Program
    {
        static void Mayor_menor_edad()
        {
            int edad;

            while (true)
            {
                Console.WriteLine("Cual es tu edad");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("Tu edad es {0} y eres mayor de edad", edad);
                    break;
                }
                else if (edad < 0)
                {
                    Console.WriteLine("No existes, por favor intenta con una edad real");
                }
                else
                {
                    Console.WriteLine("Tu edad es {0} y no eres mayor de edad", edad);
                    break;
                }
            }

        }
        static void numeros_1_100()
        {
            int i;
            for (i = 0; i <= 100; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
        static void numeros_pares()
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
        static void numeros_impares()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
        static void ejercicios(){
            int ejercicio;
            Console.WriteLine("Cual ejercicio quieres correr", Environment.NewLine, 
            " 1 = mayor o menor de edad", Environment.NewLine,
            " 2 = numeros del 1 al 100",Environment.NewLine,
            " 3 = numeros pares", Environment.NewLine,
            " 4 = numeros impares");
            ejercicio = Convert.ToInt32(Console.ReadLine());
            switch (ejercicio)
            {
                case 1:
                    Mayor_menor_edad();
                    break;
                case 2:
                    numeros_1_100();
                    break;
                case 3:
                    numeros_pares();
                    break;
                case 4:
                    numeros_impares();
                    break;
                default:
                    Console.WriteLine("Intente un numero nuevamente");
                    break;
            }

        }
        static void Main(string[] args)
        {
            ejercicios();
        }
    }
}
