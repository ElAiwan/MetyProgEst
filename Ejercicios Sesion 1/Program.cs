using System;

namespace HolaMundo
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            /* Ejercicio 1: Hola Mundo */

            Console.WriteLine("Hello, World!");


            /* Ejercicio 2: Saludar a una persona */

            Console.WriteLine("Por favor, ingrese su nombre:");
            string nombre =  Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + "!");

            /* Ejercicio 3: Suma de dos números */

            Console.WriteLine("Ingresa un número:");        // Solicita al usuario que ingrese un número
            int numero1 = int.Parse(Console.ReadLine());    // Convierte la entrada de texto del usuario en un número entero y lo asigna a la variable numero1

            Console.WriteLine("Ingresa otro número:");      // Solicita al usuario que ingrese un número
            int numero2 = int.Parse(Console.ReadLine());    // Convierte la entrada de texto del usuario en un número entero y lo asigna a la variable numero2

            int suma = numero1 + numero2;   // Suma los dos números y almacena el resultado en la variable suma

            Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es " + suma);   // Imprime el resultado de la suma al usuario

            /* Ejercicio 3: Suma de dos números - segunda variante */

            // Console.WriteLine("Ingresa un número:"); este código en este segunda variante del ejercicio es innecesario, ya que las variantes son definidas en el código
            int a = 7;  // primera variable definida, no se puede cambiar
            int b = 8;  // variable variable definida, no se puede cambiar
            int c = a + b;  // Suma las dos variables fijas y almacena el resultado en la variable c

            Console.WriteLine("La suma de " + a + " y " + b + " es: " +c); // Imprime el resultado de la suma al usuario


            /* Ejercicio 4: Calcular el área de un círculo */

            Console.WriteLine("Ingresa el radio del círculo:"); // Solicita al usuario que ingrese un número
            
            double radio = double.Parse(Console.ReadLine());    // Convierte la entrada de texto del usuario en un número decimal
            double area = Math.PI * Math.Pow(radio, 2); // Calcula el área usando la fórmula Área = pi * radio^2
            
            Console.WriteLine("El área del círculo que tiene un radio de " + radio + " es " + area);    // Imprime el resultado del área del círculo


            /* Ejercicio 5: Aumentar el salario */

            Console.WriteLine("Ingrese el nombre del trabajador:"); // Solicita al usuario que ingrese un nombre
            string nombreTrabajador = Console.ReadLine();

            Console.WriteLine("Ingrese el cargo del trabajador:");  // Solicita al usuario el cargo del trabajador
            string cargoTrabajador = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del trabajarod:"); // Solicita al usuario el salario del trabajador
            double salario = double.Parse(Console.ReadLine());  // Convierte la entrada de texto del usuario en un número 

            double aumento = salario * 0.10;    // calcula el aumento del 10% del salario
            double nuevoSalario = salario + aumento;    //  calcula el resultado del nuevo salario

                //Imprime los datos ingresados del trabajador
            Console.WriteLine("\nDatos del trabajador:");
            Console.WriteLine("Nombre: " + nombreTrabajador);
            Console.WriteLine("Cargo: " + cargoTrabajador);
            Console.WriteLine("Salario actual: " + salario + " córdobas");
            Console.WriteLine("Aumento del 10%: " + aumento + " córdobas");
            Console.WriteLine("Nuevo salario: " + nuevoSalario + " córdobas");


            /* Ejercicio 6: Número par o impar */

            Console.WriteLine("\nIngrese un número:");  // Solicita al usuario que ingrese un número
            int numero = int.Parse(Console.ReadLine()); // Convierte la entrada de texto del usuario en un número

            if (numero % 2 == 0) {    // Condición para determinar si el número es par. El número es par si el resto de su división por 2 es 0
                Console.WriteLine("El número " + numero + " es par.");  // Imprime la respuesta si la condición se cumple
            }
            else {  // Condición es falsa
                Console.WriteLine("El número " + numero + " es impar.");    // Imprime la respuesta si la condición no se cumple
            }


            /* Ejercicio 7: Mayor de tres números */

            Console.WriteLine("\nIngrese el primer número:");   // Solicita al usuario ingresar el primer número
            int num1 = int.Parse(Console.ReadLine());       // Convierte la entrada de texto del usuario en un número

            Console.WriteLine("Ingrese el segundo número");     // Solicita al usuario ingresar el segundo número
            int num2 = int.Parse(Console.ReadLine());       // Convierte la entrada de texto del usuario en un número

            Console.WriteLine("Ingrese el tercer número");      // Solicita al usuario ingresar el tercer número
            int num3 = int.Parse(Console.ReadLine());       // Convierte la entrada de texto del usuario en un número

            int numeroMayor;

            if (num1 > num2 && num1 > num3)     // Comparación numero 1 con 2 y 3
            {
                numeroMayor = num1;     // Si la condición es cierta, el número 1 es el mayor de los tres
            }
            else if (num2 > num1 && num2 > num3)    // Si número 1 no se mayor, se compara el número 2 con el 1 y el 3
            {
                numeroMayor = num2;     // Si la condición es cierta, el número 2 es el mayor
            }
            else    // Si ni el número 1 ni el número 2 son ciertos
            {
                numeroMayor = num3;     // Entonces el número 3 es el mayor
            }

            Console.WriteLine("El número mayor es: " + numeroMayor);    // Imprimir el resultado
        }
    }
}
