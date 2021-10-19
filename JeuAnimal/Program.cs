/*  Projet  : JeuAnimal
 *  Version : 1.0
 *  Date    : 30.09.2021
 *  Desc    : https://classroom.google.com/c/Mzg3ODczMjU0MzMy/a/Mzg3ODczMjU0MzQz/details
 *  
 *  Auteur  : Karel Vilem Svoboda
 */


using System;

namespace JeuAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Définition des variables locales
            Animaux lstAnimaux = new Animaux(true);
            Animaux lstAnimauxDonnee = new Animaux(false);

            Jeu partie = new Jeu();
            int nbrJoueurs;
            int nbrLettres;
            char lettreRandom = partie.GetLetter();
            int compteur = 1;

            //Début du jeu
            //Demande du nombre de joueur de la partie
            Console.WriteLine("Bonjour, vous voulez jouer à combien de personnes ?");
            nbrJoueurs = Convert.ToInt32(Console.ReadLine());
            //Creation des objets Joueur et stockage dans la liste de l'objet Joueurs
            for (int i = 0; i < nbrJoueurs; i++)
            {
                Console.WriteLine("Définir le nom du joueur " + (i + 1).ToString());
                Joueurs.lstJoueurs.Add(new Joueur(Console.ReadLine()));
            }
            //Demande du nombre de lettres
            Console.WriteLine("Combien de lettres voulez-vous trouver ?");
            nbrLettres = Convert.ToInt32(Console.ReadLine());
            //Tant que le compteur n'aura pas atteint la valeur du nombre de lettres, on joue
            while(compteur <= nbrLettres)
            {
                //pour chaque joueur
                for (int i = 0; i < nbrJoueurs; i++)
                {
                    //cassage en cas de dépassement du nombre de lettres
                    if(compteur > nbrLettres)
                    {
                        break;
                    }
                    if (partie.TourJoueur(Joueurs.lstJoueurs[i], lettreRandom, lstAnimaux, lstAnimauxDonnee))
                    {

                    }
                    //S'execute si le joueur a fait une erreur
                    else
                    {
                        lettreRandom = partie.GetLetter();
                        compteur++;
                    }
                }
            }

            Console.WriteLine("--------------");
            Console.WriteLine("La partie est terminée, affichage des résultats");
            //On affiche le résultat pour chaque joueur avec les animaux qu'il a trouvé
            foreach(Joueur rJoueur in Joueurs.lstJoueurs)
            {
                Console.WriteLine(rJoueur.ToString() + lstAnimauxDonnee.returnAnimauxByJoueur(rJoueur));
            }
            Console.WriteLine("--------------");
            //affiche la liste complète des animaux trouvés
            Console.WriteLine("Liste des Animaux : " + lstAnimauxDonnee.ToString());
        }
    }
}
