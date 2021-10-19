/*  Projet  : JeuAnimal
 *  Version : 1.0
 *  Date    : 30.09.2021
 *  Desc    : Class Animal permet de créer des animaux et d'ajouter la personne qui l'a trouvé
 *  
 *  Auteur  : Karel Vilem Svoboda
 */

namespace JeuAnimal
{
    class Animal
    {
        private string _nom;
        private Joueur _personne;

        public string Nom
        {
            get
            {
                return _nom;
            }
        }
        public Joueur Personne
        {
            get
            {
                return _personne;
            }
        }

        //constructeur désigné
        public Animal(string nom, Joueur personne)
        {
            _nom = nom;
            _personne = personne;
        }

        public Animal(string nom) : this(nom, new Joueur(""))
        {

        }
    }
}
