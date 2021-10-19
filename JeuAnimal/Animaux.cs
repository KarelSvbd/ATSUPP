/*  Projet  : JeuAnimal
 *  Version : 1.0
 *  Date    : 30.09.2021
 *  Desc    : Class Animaux permet de gérer une list composé d'objet Animal
 *  
 *  Auteur  : Karel Vilem Svoboda
 */

using System.Collections.Generic;

namespace JeuAnimal
{
    class Animaux
    {
        private List<Animal> _lstAnimaux = new List<Animal>();
        private Fichier _f = new Fichier();

        public List<Animal> LstAnimaux
        {
            get
            {
                return _lstAnimaux;
            }
        }

        public Animaux(bool recupFichier)
        {
            if (recupFichier)
            {
                RecupererElementFichier();
            }
            
        }
        /// <summary>
        /// Permet d'ajouter un animal en fonction du joueur qui l'a trouvé
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="personne"></param>
        public void Ajouter(string animal, Joueur personne)
        {
            _lstAnimaux.Add(new Animal(animal, personne));
        }

        /// <summary>
        /// Permet j'ajouter au jeu les animaux qui sont présents dans la liste de l'objet Fichier
        /// </summary>
        private void RecupererElementFichier()
        {
            _lstAnimaux.AddRange(_f.LstAnimaux);
        }
        //Recherche si l'animal se trouve dans la liste
        public bool AnimalExiste(string nomAnimal)
        {
            foreach(Animal animal in _lstAnimaux)
            {
                if(animal.Nom == nomAnimal.ToUpper() || animal.Nom == nomAnimal)
                {
                    return true;
                }
               
            }
            return false;
        }

        /// <summary>
        /// Overrride la methode ToString
        /// </summary>
        /// <returns>Retourne un string formé de tout les naimaux trouvés</returns>
        public override string ToString()
        {
            string resultat = "";
            foreach(Animal animal in _lstAnimaux)
            {
                resultat += animal.Nom + " ";
            }
            return resultat;
        }

        /// <summary>
        /// Retourne un string des animaux trouvés par un joueur
        /// </summary>
        /// <param name="personne"></param>
        /// <returns></returns>
        public string returnAnimauxByJoueur(Joueur personne)
        {
            string resultat = "";
            foreach(Animal element in _lstAnimaux)
            {
                if(personne == element.Personne)
                {
                    resultat += " " + element.Nom;
                }
            }
            return resultat;
        }
    }
}
