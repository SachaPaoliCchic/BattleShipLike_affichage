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
                if (Grille.PlacerBateau(x1, y1, x2, y2))
                    {
                    Console.WriteLine("Bateau placé avec succès !");
                }
                else
                {
                    Console.WriteLine("Les coordonnées ne sont pas adjacentes !");
                }
            }
            else
            {
                Console.WriteLine("Coordonnées invalides");
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

            Console.WriteLine("Entrez les coordonnées où tirer (ex: B3):");
            string coordTir2 = Console.ReadLine();
            if (Grille.ConvertirCoord(coordTir2, out int xt2, out int yt2))
            {
                if (!Grille.Tirer(xt2, yt2))
                    Console.WriteLine("Vous avez déjà tiré à cet endroit !");

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