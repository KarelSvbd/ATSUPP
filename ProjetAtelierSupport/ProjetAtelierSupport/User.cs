using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtelierSupport
{
    public class User
    {
        private string _nom;
        private string _prenom;
        private string _email;
        private string _password;
        private string _sessionKey;
        private string _idGrade;
        private string _nomGrade;

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


        public User(string nom, string pernom, string email, string password, string sessionKey, string idGrade)
        {
            _nom = nom;
            _prenom = pernom;
            _email = email;
            _password = password;
            _sessionKey = sessionKey;
            _idGrade = idGrade;
            _nomGrade = getNomGradeByIdGrade(idGrade);
        }


        private string getNomGradeByIdGrade(string idGrade)
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
               
                sr.Close();
            }
        }
    }
}
