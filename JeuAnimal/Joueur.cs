/*  Projet  : JeuAnimal
 *  Version : 1.0
 *  Date    : 30.09.2021
 *  Desc    : Class joueur qui permet de créer des joueur et de leur ajouter des points
 *  
 *  Auteur  : Karel Vilem Svoboda
 */

namespace JeuAnimal
{
    class Joueur
    {
        private int _points;
        private string _nom;

        public int Points
        {
            get
            {
                return _points;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }
        }

        public Joueur(string nom)
        {
            _nom = nom;
        }

        /// <summary>
        /// Permet d'incrémenter les points
        /// </summary>
        /// <param name="nbrPoints"></param>
        public void AjouterPoints(int nbrPoints)
        {
            _points += nbrPoints;
        }

        /// <summary>
        /// Overrride de ToString afin de pouvoir afficher un string complet avec le nom et les points du joueur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Joueur " + _nom.ToString() + ", " + "Points " + _points.ToString();
        }
    }
}
