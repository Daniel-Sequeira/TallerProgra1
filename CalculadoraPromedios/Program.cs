using System;

namespace CalculadoraPromedios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una calculadora de promedios
            evaluador();

            Console.WriteLine("¿Quieres evaluar otro alumno"+" "+
           "Escriba (1) para Iniciar/ (0) para salir");

            int decide = Convert.ToInt32(Console.ReadLine());

            
            if (decide == 1)
            {
                evaluador();
          
            }

            Console.WriteLine("Hasta Luego!");
        }

        static void evaluador()
        {
            Console.WriteLine("Ingrese el nombre del Alumno");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la calificación del cuatrimestre 1");
            int cuatri1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del cuatrimestre 2");
            int cuatri2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del cuatrimestre 3");
            int cuatri3 = Convert.ToInt32(Console.ReadLine());

            double notaFinal = (cuatri1 + cuatri2 + cuatri3) / 3;

            if (notaFinal >= 70)
            {
                Console.WriteLine($"({nombre} está en condición APROBADO su calificaión es {notaFinal}");
            }
            else
            {
                Console.WriteLine($"{nombre} a REPROBADO su calificación es {notaFinal}");
            }

        }
    }

}