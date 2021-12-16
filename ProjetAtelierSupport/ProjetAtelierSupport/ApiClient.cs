/* Projet   : ProjetAtelierSupport
 * Class    : ApiClient.cs
 * Desc.    : Permet de stocker un emprunt
 * Date     : 16.12.2021
 * Version  : 1.0
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
        public void Disconnect(string idPersonne)
        {
            string strurltest = String.Format("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?connect=disconnect&idUser=" + idPersonne);
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
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// 
        /// https://www.youtube.com/watch?v=CjoAYslTKX0
        /// </summary>
        /// <param name="strJson"></param>
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

        public string GetEmprunts()
        {
            string strurltest = String.Format("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?emprunt=all");
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = "GET";
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

        //TODO : récupration dynamique
        public string GetNamePersonneById(string idPersonne)
        {
            List<string> listUser = new List<string>();

            listUser.Add("Svoboda Karel");
            listUser.Add("Ferreira Jose");
            listUser.Add("Serna Georges");
            listUser.Add("Younes Amir");
            listUser.Add("Laborde Robin");

            return listUser[Convert.ToInt32(idPersonne) - 1];

        }

        //TODO : récupration dynamique
        public string GetNameModeleById(string idModele)
        {
            List<string> listUser = new List<string>();

            listUser.Add("HP LaserJet Pro M125nw");
            listUser.Add("iPhone X");
            listUser.Add("iPhone 11");
            listUser.Add("iPhone 12");
            listUser.Add("iPhone 13");
            listUser.Add("QC20");
            listUser.Add("SoundSport");
            listUser.Add("Cloud X");
            listUser.Add("Ethernet 10m");
            listUser.Add("Asus Strix");
            listUser.Add("HP ASIOP");
            listUser.Add("PS5");

            return listUser[Convert.ToInt32(idModele) - 1];

        }
    }
}
