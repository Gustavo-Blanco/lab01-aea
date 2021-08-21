using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Restar dos números");
                Console.WriteLine("[4] Multiplicar dos números");
                Console.WriteLine("[5] Dividir dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir de farenheit a celcius o viceversa");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        double r1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        double r2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", r1, r2, Resta(r1, r2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        double m1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        double m2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", m1, m2, Multiplicar(m1, m2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", d1, d2, Dividir(d1, d2));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese el máximo número");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        foreach (var n in numerosPrimos(n1))
                        {
                            Console.WriteLine(n);
                        }
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Eliga una opción");
                        Console.WriteLine("[0] Farenheit a Celcius");
                        Console.WriteLine("[1] Celcius a Farenheit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese un número");
                        double numero = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Resultado: "+ CelciusOrFarenheit(option,numero));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        //Función para calcular la suma de 2 números enteros
        static double Suma(double a, double b)
        {
            return a + b;
        }

        static double Resta(double a, double b) => a - b;
        static double Multiplicar(double a, double b) => a * b;
        static double Dividir(double a, double b) {
            if (b == 0)
            {
                Console.WriteLine("el divisor no debe ser 0");
                return -1;
            }
            return a / b;   
        }

        static double CelciusOrFarenheit (int opcion, double numero)
        {
            if (opcion == 0)
            {
                return 5 * (numero - 32) / 9;
            }
            else
            {
                return ((9 * numero) / 5) + 32;
            }
        } 

        static List<int> numerosPrimos(int maximo)
        {
            List<int> numeros = new List<int>();
            int count = 2;

            while (numeros.Count < maximo)
            {
                bool primo = true;

                for (int x = 2; x < count; x++)
                {

                    if (count % x == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    numeros.Add(count);
                }
                count++;
            }
            
            return numeros;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

    }
}
