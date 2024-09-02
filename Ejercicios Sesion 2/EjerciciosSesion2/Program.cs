using System.Security.Cryptography.X509Certificates;

namespace EjerciciosSesion2
{
    internal class Ejercicios
    {
        static void Main(string[] args)
        {
            /* Ejercicio 1: Calcular el monto a pagar por la compra de x cantidad de productos a x precio. */

            // Solicitar el ingreso de la cantidad de productos
            Console.Write("Ingrese la cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Solicitar el prpecio de cada producto
            Console.Write("Ingrese el precio por producto: ");
            double precio = double.Parse(Console.ReadLine());

            // Calcular el monto total
            double montoTotal = cantidad * precio;

            // Imprimir el resultado
            Console.WriteLine($"El monto por pagar es: " + montoTotal);


            /* Ejercicios 2: Calcular la nota final de un estudiante que posee 3 notas. La nota final se calcula de la suma de las 3 notas divido entre 3. */

            //Solicitar el ingreso de la primera nota
            Console.WriteLine("Ingrese la primera nota:");
            double nota1 = double.Parse(Console.ReadLine());

            // Solicitar el ingreso de la segunda nota
            Console.WriteLine("Ingrese la segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            // Solicitar el ingreso de la tercera nota
            Console.WriteLine("Ingrese la tercera nota:");
            double nota3 = double.Parse(Console.ReadLine());

            // Calcular el promedio de las 3 notas
            double notaFinal = (nota1 + nota2 + nota3) / 3;

            // Imprimir el resultado
            Console.WriteLine("La nota final del estudiante es: " + notaFinal);


            /* Ejercicio 3 - primera variante: Calcular el cubo de un número. */

            // Solicitar el ingreso de un número
            Console.WriteLine("Ingrese un número: ");
            double numero = double.Parse(Console.ReadLine()); // el número es leído como texto y se transforma a un número

            // Función para conseguir el valor de un número elevado al cubo
            double numeroCubo = (numero * numero * numero);

            // Imprimir resultado
            Console.WriteLine(numero + " al cubo es " + numeroCubo);

            /* Ejercicio 3 - Segunda variante */

            // Ingresar un número
            Console.WriteLine("Ingrese un número: ");
            double valor = double.Parse(Console.ReadLine());

            // Calcular el cubo usando Math.Pow. Math.Pow eleva un número a una potencia dada (valor del número, potencia dada)
            double valorCubo = Math.Pow(valor, 3);

            // Imprimir el resultado
            Console.WriteLine(valor + " al cubo es " + numeroCubo);

            /* Ejercicio 4: Calcular la raíz cuadrada de un número. */

            // Ingresar un número
            Console.WriteLine("Ingrese un número: ");
            double numeroRaiz = double.Parse(Console.ReadLine());

            // Calcular la raíz cuadrada usando la función Math.Sqrt
            double raizCuadrada = Math.Sqrt(numeroRaiz);

            // Imprimir resultado
            Console.WriteLine("La raíz cuadrada de " + numeroRaiz + " es " +raizCuadrada);


            /* Ejercicio 5: Calcular el área de un círculo. */

            Console.WriteLine("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            // Calcular el área del círculo usando la fórmula: Área = pi * radio^2
            double area = Math.PI * Math.Pow(radio, 2);

            // Imprimir resultado
            Console.WriteLine("El área del círculo con radio " + radio + " es " + area);

        }
    }
}
