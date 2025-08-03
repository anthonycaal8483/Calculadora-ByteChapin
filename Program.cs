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
        
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        
        double resultado = 0;
        bool operacionValida = true; 
        
        switch (opcion)
        {
            case 1:
                resultado = Suma(num1, num2);
                break;
            case 2:
                resultado = Resta(num1, num2);
                break;
            case 3:
                resultado = Multiplicacion(num1, num2);
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = Division(num1, num2);
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    operacionValida = false;
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                operacionValida = false;
                break;
        }
        
        if (operacionValida)
        {
            Console.WriteLine($"El resultado es: {resultado}");
        }
    }

    static double Suma(double a, double b)
    {
        return a + b;
    }

    static double Resta(double a, double b)
    {
        return a - b;
    }

    static double Multiplicacion(double a, double b)
    {
        return a * b;
    }

    static double Division(double a, double b)
    {
        return a / b;
    }
}