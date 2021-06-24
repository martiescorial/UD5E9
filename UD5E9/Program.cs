using System;

namespace UD5E9
{
    class Program
    {
        static void Main(string[] args)
        {
            String numero1 = "Introduce un numero";
            int elemento1 = Convert.ToInt32(numero1);

            String numero2 = "Introduce un numero";
            int elemento2 = Convert.ToInt32(numero2);

            String numero3 = "Introduce un numero";
            int elemento3 = Convert.ToInt32(numero3);

            int[] array = { elemento1, elemento2, elemento3 };

            Console.WriteLine(array);
        }
    }
}
