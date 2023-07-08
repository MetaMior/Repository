using System;

namespace SumaDosNumeros
{
    class Program  
    {
        static void Main()
        {
            //Declaración de Variables
            double numero1, numero2, resultado;

            //Entrada de Datos
            Console.Write("Escriba el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            //Proceso de Datos
            resultado = numero1 + numero2;

            //Salida de Información
            Console.Write("El resultado de la suma es: " + resultado);
        }
    }    
}