using System;

namespace AppDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME USUARIO \n ");

            Console.WriteLine("\n Escriba su Primer Nombre y Primer apellido PORFAVOR ! :");
            string nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Digita el Primer numero ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Digita el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 * num2;
            Console.WriteLine("\n Ingenier@ " + nombre + " el resultado de la Multiplicacion que Digito es: " + resultado);
        }
    }
}
