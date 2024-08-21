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

        }
    }
}
