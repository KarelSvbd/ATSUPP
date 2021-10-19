/* Projet   : QueueCinemaObjet
 * Desc.    : Afficher une queue dans en regroupant les personnes par leur numéro de groupe
 * Version  : 1.1
 * Date     : 23.09.2021
 * 
 * Auteur   : Karel Vilem Svoboda
 * 
 */
using System;

namespace QueueCinemaObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Yvette", 7);
            Personne p2 = new Personne("Tina", 2);
            Personne p3 = new Personne("Georges", 3);
            Personne p4 = new Personne("Tam", 7);
            Personne p5 = new Personne("Sarah", 1);
            Personne p6 = new Personne("Tim", 5);
            Personne p7 = new Personne("Tom", 5);
            Personne p8 = new Personne("Tam", 2);
            Personne p9 = new Personne("Gauthier", 8);
            QueueCinema file = new QueueCinema();

            
            file.Enqueue(p1);
            file.Enqueue(p2);
            file.Enqueue(p3);
            file.Enqueue(p4);
            file.Enqueue(p5);
            file.Enqueue(p6);
            file.Enqueue(p7);
            file.Enqueue(p8);
            file.Enqueue(p9);

            Console.WriteLine(file.ToString());
            Console.WriteLine("--------------------");
            Console.WriteLine("Nombres de personnes : " + file.Count);
            Console.WriteLine("Nombres de groupes : " + file.CountGroups);
            
        }
    }
}
