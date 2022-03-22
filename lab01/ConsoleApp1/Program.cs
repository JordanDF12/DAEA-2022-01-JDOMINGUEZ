using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static void Primos()
        {
            int numero = 2;
            int divisible = 0;
            while(numero <= 10)
            {
                for(int i = 1; i <=numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisible++;
                    }
                    if (divisible > 2)
                    {
                        Console.WriteLine("{0} no es primo", numero);
                        break;
                    }
                }
                if (divisible == 2)
                {
                    Console.WriteLine("{0} es primo", numero);
                }
                divisible = 0;
                numero++;
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA LAB 01");
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos numeros");
                Console.WriteLine("[2] Resta de dos numeros");
                Console.WriteLine("[3] Multiplicacion de dos numeros");
                Console.WriteLine("[4] Division de dos numeros");
                Console.WriteLine("[5] Imprimir la raiz cuadrada de los 10 primeros numeros enteros");
                Console.WriteLine("[6] Los 10 primeros numeros primos");
                Console.WriteLine("[7] convertidor de ªC a ªF");
                Console.WriteLine("[8] Convertidor de ªF a ªC");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer numero");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer numero");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer numero");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el grado Celsius");
                        double C = Convert.ToInt32(Console.ReadLine());
                        double Fa = (((C * 9) / 5) + 32);
                        Console.WriteLine("{0} grados Celsius en Fahrenheit es {1}", C, Fa);
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el grado Fahrenheit");
                        double F = Convert.ToInt32(Console.ReadLine());
                        double Cel = (((F - 32) * 5) / 9);
                        Console.WriteLine("{0} grados Fahrenheit en Celsius es {1}", F, Cel);
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
            Console.ReadKey();
        }
    }
}
