/* Projet   : QueueCinemaObjet
 * Class    : QueueCinema.cs
 * Desc.    : Permet de modeler une personne avec son nom et son numéro de groupe en propriété
 * Version  : 1.0
 * Date     : 23.09.2021
 * 
 * Auteur   : Karel Vilem Svoboda
 * 
 */

namespace QueueCinemaObjet
{
    class Personne
    {
        //Champs
        private string _prenom;
        private int _numeroGroup = 0;
        


        //Propriétés
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public int NumeroGroup
        {
            get { return _numeroGroup; }
            set { _numeroGroup = value; }
        }
        
        //Constructeur
        public Personne(string prenom, int numeroGroup)
        {
            _prenom = prenom;
            _numeroGroup = numeroGroup;
        }

        public override string ToString()
        {
            return _prenom + "(" + _numeroGroup + ")  ";
        }
    }
}
