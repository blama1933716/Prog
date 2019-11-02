using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire2
{
    class Program
    {
        static Random generateurNb = new Random();
        static void NbJoueur(out int nbJoueur)
        {
            Console.WriteLine("Bonjour, veuillez saisir le nombre de joueur que vous souhaitez affronter.");
            nbJoueur = Convert.ToInt32 (Console.ReadLine());
        }       
        public struct Joueur
        {
            public string nom;
            public int nbvie;
            public Carte[] tabCarte;

            public Joueur (string _nom, int nbvie ) : this()
            {              
                nom = _nom;
                tabCarte = new Carte[3];
                for (int i = 0; i < tabCarte.Length; i++)
                {
                    tabCarte[i] = new Carte((Sorte)generateurNb.Next(1, 5), generateurNb.Next(1, 14));
                }
            }
        }
        public enum Sorte { Coeur = 1, Pique = 2, Carreau = 3, Trefle = 4}
        public struct Carte
        {
            public Sorte sorteCarte;
            public int valeurCarte;

            public Carte(Sorte _sorteCarte, int _valeurCarte) : this()
            {
                sorteCarte = _sorteCarte;
                valeurCarte = _valeurCarte;
            }
        }
        static void AfficherMenu()
        {
            Console.WriteLine("3 options : ");
            Console.WriteLine("1 - Remplacer une de vos carte par une autre de la pioche");
            Console.WriteLine("2 - Remplacer une de vos cartes par celle retournée");
            Console.WriteLine("3 - Si le total des cartes est de + 21, annoncer le dernier tour");
            
        }
        static void Main(string[] args)
        {
            Joueur joueur1 = new Joueur("joe", 3);
            Joueur joueur2 = new Joueur("ordi", 3);
            Carte carteCentre = new Carte((Sorte)generateurNb.Next(1, 5), generateurNb.Next(1, 14));
            int nbJoueur = 0;
            int nb = 0;
            int choix = 0;
            int temp = 0;

            //            NbJoueur(out nbJoueur);


            //Afficher les cartes du joueur 1

            Console.WriteLine("Carte 1 : " + joueur1.tabCarte[0].valeurCarte + " - " + joueur1.tabCarte[0].sorteCarte);
            Console.WriteLine("Carte 2 : " + joueur1.tabCarte[1].valeurCarte + " - " + joueur1.tabCarte[1].sorteCarte);
            Console.WriteLine("Carte 3 : " + joueur1.tabCarte[2].valeurCarte + " - " + joueur1.tabCarte[2].sorteCarte);

            //Afficher la carte du centre
            Console.WriteLine("Carte Centre : " + carteCentre.valeurCarte + " - " + carteCentre.sorteCarte);
            
            //Afficher les options du joueur
            AfficherMenu();
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Saisir la carte a enlever : ");
                temp = Convert.ToInt16 (Console.ReadLine());
                new Carte((Sorte)generateurNb.Next(1, 5), generateurNb.Next(1, 14));
                joueur1 : Console.WriteLine("Nouvelle Carte : " + joueur1.tabCarte[choix - 1].valeurCarte + " - " + joueur1.tabCarte[choix - 1].sorteCarte);
                
            }
            else if (choix == 2) 
            {
                Console.WriteLine("Saisir la carte a enlever : ");
                temp = Convert.ToInt16(Console.ReadLine());
                joueur1: Console.WriteLine("Nouvelle carte : " + carteCentre.valeurCarte + " - " + carteCentre.sorteCarte);
            }

            Console.ReadKey();
        }
           


    }
}
