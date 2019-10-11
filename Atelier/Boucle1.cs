using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1Tableau
{
    class Program
    {
        static void AfficherIntro (ref int nb1)
        {
            Console.WriteLine("Veuillez saisir un nombre entier");
            nb1 = Convert.ToInt32(Console.ReadLine());  
        }
        static void AfficherResultat (int tot)
        {
            Console.WriteLine("Le resultat est " + tot);
        }
        static void Main(string[] args)
        {
            int nb1 = 0;
            int tot = 1; 

            AfficherIntro(ref nb1);

            for (int i = 1; i <= nb1; i++)
            {
                tot = tot * i;     
            }

            AfficherResultat(tot);
            Console.ReadKey();
        }
    }
}