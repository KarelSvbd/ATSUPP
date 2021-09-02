/* Auteur       : Karel V. Svoboda
 * Classe       : I.DA-P4A, atelier support
 * Date         : 02.09.2021
 * 
 * Projet       : Exercice 1 Queue au cinéma
 * Desc.        : https://classroom.google.com/c/Mzg3ODczMjU0MzMy/a/Mzg3ODczMjU0MzM4/details
 * Version      : 1.0
 */
using System;
using System.Collections.Generic;

namespace QueueAuCinéma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veillez saisir deux nombres entre 1 et 6");
            //lecture de la saisie des utlisateurs
            string personne1 = Console.ReadLine();
            string personne2 = Console.ReadLine();

            //initialisation de la queue initialle
            int[] queue = new int[] { 1, 2, 3, 4, 5, 6 };

            //creation de la liste avec les valeurs de la queue
            List<int> file = new List<int>(queue);

            int ancienneValeur = 0;
            string affichage = null;

            //Appet de la fonction ajout affichage et stockage de la nouvelle liste
            file = ajoutPersonne(file, Convert.ToInt32(personne1));
            ajoutPersonne(file, Convert.ToInt32(personne2));

            //construction du string d'affichage
            foreach (int personne in file)
            {
                //si un élément de la list correspond à l'ancinne valeur, on ajoute un espace
                if(ancienneValeur == personne)
                {
                    affichage += " " + personne.ToString();
                }
                //si un ancinne valeur a une valeur de 0, cela veut dire que c'est la première itération du foreach et par conséquent que c'est le premier élément de la liste
                else if (ancienneValeur == 0)
                {
                    affichage += personne.ToString();
                }
                //si un élément de la list ne correspond pas à l'ancinne valeur, on ajoute une virgule
                else if (ancienneValeur != personne)
                {
                    affichage += "," + personne.ToString();

                }
                //stockage de l'ancienne valeur
                ancienneValeur = personne;
            }

            Console.WriteLine(affichage);

            //methode d'ajout de personnes
            //retourne la nouvelle verions de la file
            static List<int> ajoutPersonne(List<int> file, int nouvellePersonne)
            {
                int index = 0;
                int positionPers = 0;
                foreach (int personne in file)
                {
                    if (nouvellePersonne == personne)
                    {
                        
                        //si il y a une personne avec la nouvelle valeur après la première, on se place derrière
                        if (nouvellePersonne == file.IndexOf(index + 2))
                        {
                            positionPers = index + 1;
                        }
                        else
                        {
                            positionPers = index;
                        }
                        
                        //insertion de la nouvelle donnée dans la file
                        file.Insert(positionPers, nouvellePersonne);
                        //on casse car nous avons terminé et la boucle ne sert plus à rien
                        break;
                    }
                    index++;

                }
                //retourne la file modifiée
                return file;
            }
        }
    }
}
