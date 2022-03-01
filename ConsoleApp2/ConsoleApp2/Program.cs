using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del primer numero: ");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero: ");
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer numero: ");
            int N3 = int.Parse(Console.ReadLine());

            int mayor = 0;

            if ((N1 > N2) ^ (N1 > N3))
            {
                mayor = N1;
            }
            else
            {
                if (N2 > N3)
                {
                    mayor = N2;
                }
                else
                {
                    mayor = N3;
                }
            }

            Console.WriteLine("El valor mayor entre: ", N1, ",", N2, "y", N3, "Es: " + mayor);

            
        }
    }
}

