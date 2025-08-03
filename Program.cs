using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            double resultado = Sumar(num1, num2);
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
        if (opcion == 4)
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            double resultado = Dividir(num1, num2);
            Console.WriteLine("El resultado de la division es: " + resultado);
        }
        // ...puedes agregar el resto de opciones aquí...
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }
    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
           Console.Write("No se puede dividir entre 0"); 
        }
        else
        {
        return a/b;
        }
    }
    // TODO: Implementar funciones de resta, multiplicación, división
}
