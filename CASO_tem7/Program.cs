using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO_tem7
{
    internal class Program
    {
        static public void numero_naturales()
        {
            Console.WriteLine("Ingresar numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++)
            {
                S = S + c;
            }
            Console.WriteLine("La suma es: " + S);
        }
        static public int sumaNN_con_recursividad(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N + sumaNN_con_recursividad(N - 1);
        }
        static public int sumaNpares(int N)
        {
            if (N == 2)
            {
                return 2;
            }
            return N + sumaNpares(N - 2);
        }
        static public long fact(long N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N * fact(N - 1);
        }
        static public int pot(int B, int exp)
        {
            if (exp == 1)
            {
                return B;
            }
            return B * pot(B, exp - 1);
        }
        static public int cuenta_reg(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            Console.WriteLine(N);
            return cuenta_reg(N - 1);
        }
        static public int suma_arreglos(int[] numeros, int indice)
        {
            if (indice >=numeros.Length)
            {
                return 0;
            }
            return numeros[indice]+ suma_arreglos(numeros, indice + 1);
        }
        static void Main(string[] args)
        {
            int opc = 0;
            bool valor = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*******************************");
                Console.WriteLine("\tMenu de opciones");
                Console.WriteLine("*******************************");
                Console.WriteLine("[1] Suma de N numeros naturales");
                Console.WriteLine("[2] Suma de N numeros naturales con recursividad");
                Console.WriteLine("[3] Suma de N numeros pares con recursividad");
                Console.WriteLine("[4] Factorial");
                Console.WriteLine("[5] Potencia");
                Console.WriteLine("[6] Cuenta regresiva");
                Console.WriteLine("[7] Arreglos");
                Console.WriteLine("[8] Salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numero_naturales();
                        break;
                    case 2:
                        Console.WriteLine("Ingresar numero de N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + sumaNN_con_recursividad(N));
                        break;
                    case 3:
                        Console.WriteLine("Ingresar numero de N: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + sumaNpares(N1*2));
                        break;
                    case 4:
                        Console.WriteLine("Ingresar numero de N: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es: " + fact(n2));
                        break;
                    case 5:
                        Console.WriteLine("Ingresar base: ");
                        int B = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar exponente: ");
                        int exp = int.Parse(Console.ReadLine());
                        Console.WriteLine(B + "elevada" + exp+"="+pot(B,exp));
                        break;
                    case 6:
                        int n3;
                        n3=int.Parse(Console.ReadLine());
                        cuenta_reg(n3);
                        break;
                    case 7:
                        int[] numeros= {10,15,20,25,30};
                        Console.WriteLine("La suma del arreglo es: "+suma_arreglos(numeros, 0));
                        break;
                    case 8:
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();
            }  
        }
    }
}

