/* Projet   : ProjetAtelierSupport
 * Class    : Emprunt.cs
 * Desc.    : Permet de stocker un emprunt
 * Date     : 16.12.2021
 * Version  : 1.0
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A - 4e CFPT Info.
 */
namespace ProjetAtelierSupport
{
    public class Emprunt
    {
        private string _idModele;
        private string _idPersonne;

        public string IdModele
        {
            get { return _idModele; }
            set { _idModele = value; }
        }
        public string IdPersonne
        {
            get { return _idPersonne; }
            set { _idPersonne = value; }
        }

        public Emprunt(string idModele, string idPersonne)
        {
            _idModele = idModele;
            _idPersonne = idPersonne;
        }
    }
}
