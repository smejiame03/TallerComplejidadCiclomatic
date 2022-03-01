using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de inscripción");
            int num_inscripcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del estudiante");
            String nom_estudiante = Console.ReadLine();
            Console.WriteLine("Ingrese el patrimonio del estudiante");
            int patrimonio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el estrato social del estudiante");
            int estrato_social = int.Parse(Console.ReadLine());


            double pagmat = 50000;


            if ((patrimonio > 2000000) ^(estrato_social > 3))
            {
                pagmat = pagmat + 0.03 * patrimonio;
            }

            Console.WriteLine("El estudiante con numero de inscripcion:" + num_inscripcion, "y nombre: " + nom_estudiante, "debe pagar $: " + pagmat);
        }
    }
}
