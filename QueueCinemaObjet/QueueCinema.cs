/* Projet   : QueueCinemaObjet
 * Class    : QueueCinema.cs
 * Desc.    : Permet de gérér une list<Personne> et de trier les personnes grâce à leur numéro de groupe
 * Version  : 1.0
 * Date     : 23.09.2021
 * 
 * Auteur   : Karel Vilem Svoboda
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueCinemaObjet
{
    class QueueCinema
    {
        //Champs
        private bool _isEmpty;
        private int _count;
        private int _countGroups;
        private string str;
        private Personne ancienElement;
        private int compteur;
        bool flag = false;

        List<Personne> file = new List<Personne>();
        //<numero, nombre> 
        public static Dictionary<int, int> groupes = new Dictionary<int, int>();

        //Propriétés
        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { _isEmpty = value; }
        }

        public int Count
        {
            get {
                _count = file.Count;
                return _count; 
            }
        }

        public int CountGroups
        {
            get {

                return _countGroups +1; 
            }
        }

        public QueueCinema()
        {

        }

        /// <summary>
        /// Permet d'ajouter un élément à la liste et d'appeler la fonciton de tri
        /// </summary>
        /// <param name="pAdd"></param>
        /// <returns>retourne la nouvelle liste</returns>
        public List<Personne> Enqueue(Personne pAdd)
        {
            
            Tri(pAdd);
            //Si on ajoute le nouvel élément grâce à la première fonction, on a pas besoin d'appeler la seconde
            if (flag)
            {
                flag = false;
            }
            else
            {
                file.Add(pAdd);
            }
            _isEmpty = false;
            
            return file;
        }

        /// <summary>
        /// Permet de supprimer un élément de la list
        /// </summary>
        /// <param name="pSuppr"></param>
        public void Dequeue(Personne pSuppr)
        {
            file.Remove(pSuppr);
        }

        /// <summary>
        /// Permet de vider la list
        /// </summary>
        public void Clear()
        {
            file.Clear();
            //La liste est vidée
            _isEmpty = true;
        }

        public override string ToString()
        {
            //Chaque element apporte toString() et on l'ajoute à un string que l'on retourne
            foreach(Personne element in file)
            {
                str += element.ToString();

            }
            return str;
        }
        

        /// <summary>
        /// Permet d'ajouter une personne et de tirer la liste en fonction de sa propriété numroGroup
        /// </summary>
        /// <param name="nouvelElement">nouvelle Personnne à ajouter à la list</param>
        public void Tri(Personne nouvelElement)
        {
            compteur = 0;
            //Parcours de la file
            foreach(Personne element in file)
            {
                if(compteur > 0)
                {
                    //Si le numéro group de notre nouvelle personne est identique à celui de la personne qui se trouve dans la file, on l'ajoute à sa position
                    if (nouvelElement.NumeroGroup == ancienElement.NumeroGroup)
                    {
                        _countGroups++;
                        groupes.Add(nouvelElement.NumeroGroup, 1);
                        file.Insert(compteur, nouvelElement);
                        flag = true;
                        //le break permet d'éviter une erreur lors de la prochaine itération due au changement de la file
                        break;
                    }
                    
                }
                compteur++;
                //stockage de la personne précédente
                ancienElement = element;
                
            }
            

        }
    }
}
