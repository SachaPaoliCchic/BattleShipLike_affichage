using BattleShip;
namespace Serveur
  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrilleBattle Grille = new GrilleBattle();

            Grille.Tirer(2, 2);
            Grille.PlacerBateau(1, 1, 1, 2);
            Console.WriteLine("Grille d'attaque");
            Grille.AfficherGrilleDattaque();
            Console.WriteLine("Ma grille");
            Grille.AfficherMaGrille();

        }
    }
}
