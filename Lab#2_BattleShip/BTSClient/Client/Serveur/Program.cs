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
            string? coord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(coord) || !Grille.PlacerBateau(coord))
            {
                Console.WriteLine("Placement invalide (coordonnées incorrectes ou non adjacentes).");
            }

            // Affichage des grilles après placement
            Console.WriteLine("\nMa grille de défense :");
            Grille.AfficherMaGrilleBateau();

            Console.WriteLine("\nMa grille d'attaque :");
            Grille.AfficherGrilleTir();

            // Premier tir
            Console.WriteLine("\nEntrez les coordonnées où tirer (ex: B3):");
            string? coordTir = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(coordTir) || !Grille.Tirer(coordTir))
            {
                Console.WriteLine("Coordonnées invalides ou case déjà jouée !");
            }

            Console.WriteLine("\nMa grille de défense :");
            Grille.AfficherMaGrilleBateau();
            Console.WriteLine("\nMa grille d'attaque :");
            Grille.AfficherGrilleTir();

            // Deuxième tir
            Console.WriteLine("\nEntrez les coordonnées où tirer (ex: B3):");
            string? coordTir2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(coordTir2) || !Grille.Tirer(coordTir2))
            {
                Console.WriteLine("Coordonnées invalides ou case déjà jouée !");
            }

            Console.WriteLine("\nMa grille de défense :");
            Grille.AfficherMaGrilleBateau();
            Console.WriteLine("\nMa grille d'attaque :");
            Grille.AfficherGrilleTir();
        }
    }
}
