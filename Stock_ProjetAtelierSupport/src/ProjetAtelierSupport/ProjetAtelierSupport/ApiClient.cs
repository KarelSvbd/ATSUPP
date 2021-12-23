/* Projet   : ProjetAtelierSupport
 * Class    : ApiClient.cs
 * Desc.    : Permet de stocker un emprunt
 * Date     : 23.12.2021
 * Version  : 0.1
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A - 4e CFPT Info.
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ProjetAtelierSupport
{
    public class ApiClient
    {
        /// <summary>
        /// Permet de créer un utilisateur après un appel GET
        /// </summary>
        /// <param name="url">Requête à l'API</param>
        /// <returns>Retourne le nouvel utilisateur ou null si la requête est erronée</returns>
        public User CreateUserByGetCall(string url)
        {
            User utilisateur = null;
            string strurltest = String.Format(url);
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = "GET";
            try
            {
                HttpWebResponse responseObject = null;
                responseObject = (HttpWebResponse)requestObject.GetResponse();
                string strresulttest = null;
                using (Stream steam = responseObject.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(steam);
                    strresulttest = sr.ReadToEnd();
                    JObject response = JObject.Parse(strresulttest);
                    utilisateur = new User(response["idPersonne"].ToString(), response["nomPersonne"].ToString(), response["prenomPersonne"].ToString(), response["email"].ToString(), response["password"].ToString(), response["sessionKey"].ToString(), response["idGrade"].ToString());
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return utilisateur;
        }

        /// <summary>
        /// Permet de se connecter et de détruire la clé
        /// </summary>
        /// <param name="idPersonne">idPersonne</param>
        public void Disconnect(string idPersonne, User user)
        {
            ApiRequest("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?connect=disconnect&idUser=" + idPersonne, "get", user);
        }

        /// <summary>
        /// Permet de désérialiser le JSON
        /// https://www.youtube.com/watch?v=CjoAYslTKX0
        /// </summary>
        /// <param name="strJson">string en Json</param>
        public dynamic DeserialiseJSON(string strJson)
        {
            try
            {
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJson);

                return jPerson;
            }
            catch(Exception ex)
            {
                Console.WriteLine("error : " + ex);
                return null;
            }
        }

        public string GetEmprunts(User user)
        {
            return ApiRequest("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?emprunt=all", "get", user);
        }

        /// <summary>
        /// Permet de modifier un emprunt
        /// </summary>
        /// <param name="indexAncienModele"></param>
        /// <param name="indexAncienPersonne"></param>
        /// <param name="indexNouveauModele"></param>
        /// <param name="indexNouveauPersonne"></param>
        public void ModifierEmprunt(string indexAncienModele, string indexAncienPersonne, string indexNouveauModele, string indexNouveauPersonne, User user)
        {
           ApiRequest("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?emprunt=noms&indexAncienModele=" + indexAncienModele + "&indexAncienPersonne=" + indexAncienPersonne + "&indexNouveauModele=" + indexNouveauModele + "&indexNouveauPersonne=" + indexNouveauPersonne + "", "put", user);
        }

        /// <summary>
        /// Recupère le nom d'une personne en fonction de son id
        /// </summary>
        /// <param name="idPersonne">id de la personne</param>
        /// <param name="user">utilisateur actuel de l'application</param>
        /// <returns>nom de la personne</returns>
        public string GetNamePersonneById(string idPersonne, User user)
        {
            return GetAllPersonne(user)[Convert.ToInt32(idPersonne) - 1];
        }

        /// <summary>
        /// Recupère le nom du modele en fonction de son id
        /// </summary>
        /// <param name="idModele">id du modele</param>
        /// <param name="user">utilisateur actuel de l'application</param>
        /// <returns></returns>
        public string GetNameModeleById(string idModele, User user)
        {
            return GetAllModele(user)[Convert.ToInt32(idModele) - 1];
        }

        /// <summary>
        /// Permet de récupérer les noms et prénoms des utilisateurs
        /// </summary>
        /// <returns>Liste des prenoms et noms</returns>
        public List<string> GetAllPersonne(User user)
        {
            List<string> listPersonne = new List<string>();
            foreach (var element in DeserialiseJSON(ApiRequest("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?personnes=all", "get", user)))
            {
                listPersonne.Add(element["nomPersonne"].ToString() + " " + element["prenomPersonne"].ToString());
            }
            return listPersonne;
        }

        /// <summary>
        /// Recupére touts les nom de modele
        /// </summary>
        /// <returns>Liste des noms de modele</returns>
        public List<string> GetAllModele(User user)
        {
            List<string> listModele = new List<string>();
            foreach (var element in DeserialiseJSON(ApiRequest("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?modele=noms", "get", user)))
            {
                listModele.Add(element["nomModele"].ToString());
            }
            return listModele;
        }

        /// <summary>
        /// Permet de faire une requête à une API
        /// </summary>
        /// <param name="url">url de la demande</param>
        /// <returns>le résultat de la requête</returns>
        public string ApiRequest(string url, string method, User user)
        {
            string strurltest = String.Format(url + "&key=" + user.SessionKey + " &idUser=" + user.IdPersonne + " ");
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = method.ToUpper();
            HttpWebResponse responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream steam = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(steam);
                strresulttest = sr.ReadToEnd();
                var settings = new JsonSerializerSettings();
                settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
                sr.Close();
            }

            return strresulttest;
        }
    }
}
