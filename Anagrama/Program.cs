using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Reto: ¿Es un anagrama?

 * Enunciado: Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Boolean) según sean o no anagramas.
 * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
 * NO hace falta comprobar que ambas palabras existan.
 * Dos palabras exactamente iguales no son anagrama.


 */

namespace Anagrama
{
    internal class Program
    {
        public static string palabra1;
        public static string palabra2;

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una palabra:");
            palabra1 = Console.ReadLine();
            Console.WriteLine("\nEscribe otra palabra");
            palabra2 = Console.ReadLine();

            if (ComprobarAnagrama())
            {
                Console.WriteLine("Es un anagrama.");
            }
            else
            {
                Console.WriteLine("No es un anagrama.");
            }
        }

        public static bool ComprobarAnagrama()
        {
            string palabra1m = palabra1.ToLower();
            string palabra2m = palabra2.ToLower();

            char[] palabraArray1 = palabra1m.ToCharArray();
            char[] palabraArray2 = palabra2m.ToCharArray();

            //ordenar las letras
            Array.Sort(palabraArray1);
            Array.Sort(palabraArray2);

            if (palabra1m == palabra2m || palabra1.Length != palabra2.Length)
            {
                return false;
            }
            else if (Enumerable.SequenceEqual(palabraArray1, palabraArray2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
