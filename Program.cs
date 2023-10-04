using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 20, 30, 40, 50, 60 };
            int[] n = new int[] { 3, 4, 5 };
            char[] c = { 'L', 'u', 'i', 's' };
            string s = "Mona Lisa";

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("La variable es de tipo int \n");

            for(int i=0;i<3;i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.WriteLine("La variable es de tipo int \n");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.WriteLine("La variable es de tipo char \n");

            Console.WriteLine(s);
            Console.WriteLine("La variable es de tipo string \n");

            Console.ReadLine();
        }
    }
}
