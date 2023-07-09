using System;

namespace DivisionDosNumeros
{
    class Program  
    {
        static void Main()
        {
            //Declaración de Variables
            double dividendo, divisor, cociente, residuo;

            //Entrada de Datos
            Console.Write("Escriba el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("El divisor no puede ser 0");
                return;
            }

            //Proceso de Datos
            cociente = dividendo / divisor;
            residuo = dividendo % divisor;

            //Salida de Información
            Console.WriteLine("El cociente es " + Math.Floor(cociente) + " y el residuo es " + residuo);
        }
    }    
}