using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Ex_02_Voiture
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "";
            string marque = "";
            string model = "";
            string couleur = "";

            

            Console.Write(" Marque : ");
            Console.ForegroundColor = ConsoleColor.Red;
            // Récup des données utilisateurs
            marque = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" Model : ");
            Console.ForegroundColor = ConsoleColor.Red;
            // Récup des données utilisateurs
            model = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" Couleur : ");
            Console.ForegroundColor = ConsoleColor.Red;
            // Récup des données utilisateurs
            couleur = Console.ReadLine();

            // Créer la voiture
            Voiture Voit = new Voiture(marque, model, couleur);

            // Clear la console
            Console.Clear();

            // Tant que ! de q reste dans la boucle
            while (data != "q")
            {
                // Affiche la voiture
                Console.WriteLine(Voit);

                Console.WriteLine();
                // Change la couleur du texte
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("****************");
                Console.Write(" + | Accelerer"); Console.WriteLine(" *");
                Console.Write(" - | Decelerer"); Console.WriteLine(" *");
                Console.Write(" S | Start"); Console.WriteLine("     *");
                Console.Write(" P | Stop"); Console.WriteLine("      *");
                Console.Write(" K | Klaxon"); Console.WriteLine("    *");
                Console.Write(" C | Couleur"); Console.WriteLine("   *");
                Console.Write(" Q | Quitter"); Console.WriteLine("   *");
                Console.Write("****************");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                Console.Write("Action : ");

                Console.ForegroundColor = ConsoleColor.Red;
                data = Console.ReadLine();
                // Efface la console
                Console.Clear();

                // Utilisation de la varible data pour choisir les options
                switch (data)
                {
                    // Appel la fonction suivant l'option choisis
                    case "+":
                        Console.WriteLine(Voit.Accelerer());
                        break;

                    case "-":
                        Console.WriteLine(Voit.Freiner());
                        break;

                    case "s":
                        Console.WriteLine(Voit.DemarrerMoteur());
                        break;

                    case "p":
                        Console.WriteLine(Voit.ArretMoteur());
                        break;

                    case "k":
                        Console.WriteLine(Voit.Klaxoner());
                        break;

                    case "c":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Nouvelle Couleur : ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        couleur = Console.ReadLine();
                        Voit.Couleur = couleur;
                        Console.WriteLine(Voit.Couleur);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
