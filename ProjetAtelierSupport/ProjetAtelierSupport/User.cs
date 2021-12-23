/* Projet   : ProjetAtelierSupport
 * Class    : User.cs
 * Desc.    : Permet de créer un utilisateur identique à celui dans la base de données
 * Date     : 23.12.2021
 * Version  : 1.0
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A - 4e CFPT Info.
*/

using System;
using System.IO;
using System.Net;

namespace ProjetAtelierSupport
{
    public class User
    {
        #region Variables d'instances
        private readonly string _idPersonne, _nom, _prenom, _email, _password, _sessionKey, _idGrade, _nomGrade;
        #endregion

        #region Proptiétés publiques
        public string IdPersonne
        {
            get { return _idPersonne; }
        }
        public string Nom
        {
            get { return _nom; }
        }
        public string Prenom
        {
            get { return _prenom; }
        }
        public string Email
        {
            get { return _email; }
        }
        public string Password { 
            get { return _password;} 
        }

        public string SessionKey
        {
            get { return _sessionKey; }
        }

        public string IdGrade
        {
            get { return _idGrade; }
        }

        public string NomGrade
        {
            get { return _nomGrade; }
        }
        #endregion

        /// <summary>
        /// Permet de créer un utilisateur
        /// </summary>
        /// <param name="idPersonne">id du User</param>
        /// <param name="nom">nom du User</param>
        /// <param name="pernom">prenom du User</param>
        /// <param name="email">email du User</param>
        /// <param name="password">password du User</param>
        /// <param name="sessionKey">clé de session du User</param>
        /// <param name="idGrade">idGrade du User</param>
        public User(string idPersonne, string nom, string pernom, string email, string password, string sessionKey, string idGrade)
        {
            _idPersonne = idPersonne;
            _nom = nom;
            _prenom = pernom;
            _email = email;
            _password = password;
            _sessionKey = sessionKey;
            _idGrade = idGrade;
            _nomGrade = GetNomGradeByIdGrade(idGrade);
        }

        /// <summary>
        /// Permet de récupérer le nom du grade en fonction de l'id de ce dernier
        /// </summary>
        /// <param name="idGrade">id du grade</param>
        /// <returns>nom du grade</returns>
        private string GetNomGradeByIdGrade(string idGrade)
        {

            string strurltest = String.Format("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?grades=nom&idGrade=" + idGrade);
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = "GET";
            HttpWebResponse responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream steam = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(steam);
                strresulttest = sr.ReadToEnd();
                string result = "";
    
                for(int i = 0; i < strresulttest.Length; i++)
                {
                    if(i == 0 || i == strresulttest.Length - 1)
                    {

                    }
                    else
                    {
                        result += strresulttest[i];
                    }
                }
                return result;
            }
        }
    }
}
