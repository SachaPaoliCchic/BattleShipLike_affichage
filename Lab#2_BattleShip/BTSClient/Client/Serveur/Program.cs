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
            if (coords != null && coords.Length == 2 &&
                Grille.ConvertirCoord(coords[0], out int x1, out int y1) &&
                Grille.ConvertirCoord(coords[1], out int x2, out int y2))
            {
                Grille.PlacerBateau(x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("Coordonnées invalides ou cases non adjacentes !");
            }

            Console.WriteLine("Ma grille");
            Grille.AfficherMaGrilleBateau();
            Console.WriteLine("Ma grille d'attaque");
            Grille.AfficherGrilleTir();

            // Tir
            Console.WriteLine("Entrez les coordonnées où tirer (ex: B3):");
            string coordTir = Console.ReadLine();
            if (Grille.ConvertirCoord(coordTir, out int xt, out int yt))
            {
                Grille.Tirer(xt, yt);
            }
            else
            {
                Console.WriteLine("Coordonnées de tir invalides !");
            }

            Console.WriteLine("Ma grille d'attaque");
            Grille.AfficherGrilleTir();
            
        }
    }
}