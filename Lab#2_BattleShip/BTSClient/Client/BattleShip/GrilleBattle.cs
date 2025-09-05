using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class GrilleBattle
    {
        /* Tableau dans lequel on va contenir nos symboles, on a choisi
         B pour beateau; X pour bateau touché et O dans le cas où la 
         case est vide. Deplus ce sera lui qui va nous permettre de 
         savoir au fure et à mesure de remplir notre grille et sera envoyé
         du client au serveur plus du serveur au client
        */

        private char[,] emplacement = new char[4, 4];
        List<string> caractereGrille = new List<string>();

        string lettreDuTableau ="ABCD";

        // au debut ce tableau est vide car personne n'a encore joué donc...

        public GrilleBattle()
        {
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                    emplacement[x, y] = '-';
        }


        public void PlacerBateau(int x, int y, int a, int b)
        {
            // Ici on va verifier les coordonnées entrées  càd être sur que on a
            // une entrée correcte de la forme A2 ou B1 et non un G9 par exmple
            emplacement[x, y] = 'B';
            emplacement[a, b] = 'B';
        }

        public void Tirer(int x, int y)
        {
            // Ici on va verifier les coordonnées entrées  càd être sur que on a
            // une entrée correcte de la forme A2 ou B1 et non un G9 par exmple

            if (emplacement[x, y] == 'B')
            {
                emplacement[x, y] = 'T'; // Bateau touché
            }
            else if (emplacement[x, y] == '-')
            {
                emplacement[x, y] = 'X';
            }
        }
         
        public bool VerifierCoordonnée(string coord, out char lettreColonne, out int ligne)
        {
            lettreColonne = ' ';
            ligne = -1;

            if (string.IsNullOrWhiteSpace(coord) || coord.Length < 2 || coord.Length >= 3)
                return false;

            coord = coord.Trim().ToUpper();

            // Lettre
            lettreColonne = coord[0];

            //foreach (char  in lettreDuTableau)
            //{

            //}
            if ( !(lettreDuTableau.Contains('C')))
                return false;

            // Colonne
            

            if (!int.TryParse(coord.Substring(1), out int colNum) )
                return false;

            if(!(colNum < 1 || colNum > 4))
                return false;


            ligne = colNum - 1;
            return true;
        }

        public void AfficherMaGrille()
        {
            Console.Write("    ");
            foreach (char letter in "ABCD")
            {
                Console.Write($" {letter}  ");
            }
            Console.WriteLine();

            Console.WriteLine("  ┌───┬───┬───┬───┐");

            // Lignes 1–4
            for (int numLigne = 0; numLigne < 4; numLigne++)
            {
                Console.Write($"{numLigne + 1} │");
                for (int barreHorizontale = 0; barreHorizontale < 4; barreHorizontale++)
                {
                    Console.Write($" {emplacement[numLigne, barreHorizontale]} │");
                }
                Console.WriteLine();

                if (numLigne < 3)
                    Console.WriteLine("  ├───┼───┼───┼───┤");
                else
                    Console.WriteLine("  └───┴───┴───┴───┘");
            }
        }

        public void AfficherGrilleDattaque()
        {
            Console.Write("    ");
            foreach (char letter in "ABCD")
            {
                Console.Write($" {letter}  ");
            }
            Console.WriteLine();

            Console.WriteLine("  ┌───┬───┬───┬───┐");

            // Lignes 1–4
            for (int numLigne = 0; numLigne < 4; numLigne++)
            {
                Console.Write($"{numLigne + 1} │");
                for (int barreHorizontale = 0; barreHorizontale < 4; barreHorizontale++)
                {
                    Console.Write($" {emplacement[numLigne, barreHorizontale]} │");
                }
                Console.WriteLine();

                if (numLigne < 3)
                    Console.WriteLine("  ├───┼───┼───┼───┤");
                else
                    Console.WriteLine("  └───┴───┴───┴───┘");
            }
        }
    }
}
