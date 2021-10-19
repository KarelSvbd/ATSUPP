/*  Projet  : JeuAnimal
 *  Version : 1.0
 *  Date    : 30.09.2021
 *  Desc    : Class Fichier permet de lire un fichier et teste ligne par ligne et de stoquer les resultat dans une List
 *  
 *  Auteur  : Karel Vilem Svoboda
 */


using System.Collections.Generic;
using System.IO;

namespace JeuAnimal
{
    class Fichier
    {
        private List<Animal> _lstAnimaux = new List<Animal>();

        public List<Animal> LstAnimaux
        {
            get
            {
                return _lstAnimaux;
            }
        }
        public Fichier()
        {
            // /!\ changer la location de l'élément en cas de changmenet de machine/!\
            string fileName = @"C:\github\ATSUPP\JeuAnimal\JeuAnimal\animaux.txt";

            //Stockage des lignes dans un Enumerable
            IEnumerable<string> lines = File.ReadLines(fileName);
            RetrunArrayAnimaux(lines);
        }

        private void RetrunArrayAnimaux(IEnumerable<string> lignes)
        {
            //Chaque ligne correspond à un animal qu'on ajoute dans la liste
            foreach(string animal in lignes)
            {
                _lstAnimaux.Add(new Animal(animal));
            }
        }
    }
}
