using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Schema;
//Programa con 1 clase, 5 metodos y 5 variables.
namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            acciones objeto1 = new acciones();
            Console.WriteLine("Por favor ingresa un numero entero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El factorial de " + n1 + " es: " + objeto1.CalculoFactorial(n1));
            acciones objeto2 = new acciones();
            Console.WriteLine("Ingresa un numero de 3 cifras");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero que ingresaste ahora es: " + objeto2.InvertirN(num));
            acciones objeto3 = new acciones();
            Console.WriteLine("Ingrese un numero");
            int N = int.Parse(Console.ReadLine());
            objeto3.multiplicar(N);
            acciones objeto4 = new acciones();
            Console.WriteLine("Escribe un numero decimal");
            int numero = Convert.ToInt32(Console.ReadLine());
            long binario = objeto4.decimalBinario(numero);
            Console.WriteLine("El numero decimal " + numero + " en binario es: " + binario);
            acciones objeto5 = new acciones();
            String hexadecimal = objeto5.decimalHexadecimal(numero);
            Console.WriteLine("El numero decimal " + numero + " en hexadecimal es " + hexadecimal);
            Console.ReadKey();
        }
    }

    class acciones
    {
        int fact = 1;
        public int CalculoFactorial(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        int aux;
        public int InvertirN(int num)
        {
            int centenas = num / 100;
            num = num % 100;
            int decenas = num / 10;
            int unidades = num % 10;
            aux = (unidades * 100) + (decenas * 10) + centenas;
            return aux;
        }
        int total;
        public int multiplicar(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                total = i * a;
                Console.WriteLine(i + " X " + a + " = " + total);
            }
            return total;
        }
        public long decimalBinario(int numDecimal)
        {

            if (numDecimal < 0)
            {
                return -1;
            }

            long binario = 0;
            long digito;
            const int DIVISOR = 2;
            for (int i = numDecimal, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = i % DIVISOR;

                binario += digito * Convert.ToInt64(Math.Pow(10, j));
            }
            return binario;

        }
        public String decimalHexadecimal(int numero)
        {

            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };

            String hexadecimal = "";

            const int DIVISOR = 16;
            long resto = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                resto = i % DIVISOR;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;

                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }


            return hexadecimal;

        }
    }
}
