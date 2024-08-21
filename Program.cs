using System;

namespace HolaMundo
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            // Ejercicio 1: Hola Mundo
            Console.WriteLine("Hello, World!");

            // Ejercicio 2: Saludar a una persona
            Console.WriteLine("Por favor, ingrese su nombre:");
            string nombre =  Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + "!");

            // Ejercicio 3: Suma de dos números
            Console.WriteLine("Ingresa un número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro número:");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;

            Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es " + suma);
        }
    }
}
