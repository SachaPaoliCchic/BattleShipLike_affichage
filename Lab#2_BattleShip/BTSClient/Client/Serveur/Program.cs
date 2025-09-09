using BattleShip;

namespace Serveur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrilleBattle Grille = new GrilleBattle();

            // Placement du bateau
            Console.WriteLine("Entrez les coordonnées du bateau (ex: A1 A2):");
            string[] coords = Console.ReadLine()?.Split(' ');

            if (coords != null && coords.Length == 2)
            {
                if (Grille.PlacerBateau(coords[0], coords[1]))
                {
                    Console.WriteLine("Bateau placé avec succès !");
                }
                else
                {
                    Console.WriteLine("Placement invalide (coordonnées incorrectes ou non adjacentes).");
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide (il faut donner deux coordonnées).");
            }

            Console.WriteLine("\nMa grille :");
            Grille.AfficherMaGrilleBateau();

            Console.WriteLine("\nMa grille d'attaque :");
            Grille.AfficherGrilleTir();

            // Premier tir
            Console.WriteLine("\nEntrez les coordonnées où tirer (ex: B3):");
            string coordTir = Console.ReadLine();
            if (Grille.Tirer(coordTir))
            {
                Console.WriteLine("Tir effectué !");
            }
            else
            {
                Console.WriteLine("Coordonnées invalides ou case déjà jouée !");
            }

            Console.WriteLine("\nMa grille d'attaque :");
            Grille.AfficherGrilleTir();

            // Deuxième tir
            Console.WriteLine("\nEntrez les coordonnées où tirer (ex: B3):");
            string coordTir2 = Console.ReadLine();
            if (Grille.Tirer(coordTir2))
            {
                Console.WriteLine("Tir effectué !");
            }
            else
            {
                Console.WriteLine("Coordonnées invalides ou case déjà jouée !");
            }

            Console.WriteLine("\nMa grille d'attaque :");
            Grille.AfficherGrilleTir();
        }
    }
}
