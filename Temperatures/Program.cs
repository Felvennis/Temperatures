using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            int taille = 5;
            float[] t = new float[taille];

            float moyenne = 0;
            for (int k =0; k < taille; k++)
            {
                Console.Write("Entrez la température n°" + (k + 1) + "=");
                t[k] = float.Parse(Console.ReadLine());
                moyenne += t[k];
            }
            moyenne = moyenne / taille;

            int nbsup = 0;
            for (int k =0; k < taille; k++)
            {
                if (t[k] > moyenne)
                {
                    nbsup++;
                }
            }
            Console.WriteLine("Nombre de t° au-dessus de la moyenne = " + nbsup);
            Console.ReadLine();
        }
    }
}
