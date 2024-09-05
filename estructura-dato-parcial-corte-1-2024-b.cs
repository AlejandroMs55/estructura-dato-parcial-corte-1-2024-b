using System;

namespace SumaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el primer numero
            Console.WriteLine("Ingresa el primer numero:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            // Solicitar al usuario que ingrese el segundo numero
            Console.WriteLine("Ingresa el segundo numero:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Sumar los dos numeros
            double suma = numero1 + numero2;

            // Mostrar el resultado
            Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es: " + suma);

            // Esperar a que el usuario presione una tecla para salir
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}