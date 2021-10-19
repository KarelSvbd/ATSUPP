/*  Projet  : JeuAnimal
 *  Version : 1.0
 *  Date    : 30.09.2021
 *  Desc    : Permet de jouer un tour et de renvoyer si l'utlisateur a juste ou pas
 *  
 *  Auteur  : Karel Vilem Svoboda
 */

using System;

namespace JeuAnimal
{
    class Jeu
    {
        /// <summary>
        /// Permet de retourner une lettre d'alphabet aléatoire
        /// Source : https://stackoverflow.com/questions/15249138/pick-random-char
        /// </summary>
        /// <returns>une lettre aléatoire</returns>
        public char GetLetter()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }


        /// <summary>
        /// Permet de jouer un tour
        /// </summary>
        /// <param name="personne">/param>
        /// <param name="lettreRandom"></param>
        /// <param name="lstAnimaux"></param>
        /// <param name="lstAnimauxDonnee"></param>
        /// <returns>Si true = Joueur a juste, si false = joueur a faux</returns>
        public bool TourJoueur(Joueur personne,char lettreRandom, Animaux lstAnimaux, Animaux lstAnimauxDonnee)
        {
            Console.WriteLine("C'est à vous joueur " + personne.Nom.ToString() + " !");
            Console.WriteLine("Ecrivez un nom d'animal avec la lettre " + lettreRandom.ToString());
            //On récupére la réponse et on la met en minuscule afin de ne pas rendre le jeu case sensitive
            string response = Console.ReadLine().ToLower();
            //Si la première lettre du resultat correspond à la lettre demandée
            if (response[0] == lettreRandom)
            {
                //Si l'animal se trouve dans la base de donnée 
                if (lstAnimaux.AnimalExiste(response))
                {
                    //Si l'animal n'a pas déjà été choisi
                    if (!lstAnimauxDonnee.AnimalExiste(response))
                    {
                        personne.AjouterPoints(1);
                        Console.WriteLine("Félicitations, vous avez gagné un point. Joueur suivant");
                        lstAnimauxDonnee.Ajouter(response, personne);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Navré, mais ce nom a déjà été donnée.");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Cet animal n'existe pas.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Dommage, mais la lettre que vous avez entrée est erronée.");
                return false;
            }

        }
    }
}
