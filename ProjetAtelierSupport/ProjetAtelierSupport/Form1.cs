/* Projet   : ProjetAtelierSupport
 * Desc.    : 
 * Date     :
 * Version  :
 * 
 * Auteur   :
 * Classe   :
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ProjetAtelierSupport
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(tbxEmail.Text != "" && tbxPassword.Text != "")
            {
                User utilisateur;
                string strurltest = String.Format("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?connect=ep&email=" + tbxEmail.Text + "&password="+ tbxPassword.Text+"");
                WebRequest requestObject = WebRequest.Create(strurltest);
                requestObject.Method = "GET";
                HttpWebResponse responseObject = null;
                responseObject = (HttpWebResponse)requestObject.GetResponse();

                string strresulttest = null;
                using (Stream steam = responseObject.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(steam);
                    strresulttest = sr.ReadToEnd();
                    JObject response = JObject.Parse(strresulttest);

                    // TODO: Traitement en fonction de la réponse
                    utilisateur = new User(response["nomPersonne"].ToString(), response["prenomPersonne"].ToString(), response["email"].ToString(), response["password"].ToString(), response["sessionKey"].ToString(), response["idGrade"].ToString());
                    sr.Close();
                }
                FrmMain frmMain = new FrmMain(utilisateur);
                frmMain.Show();
                
                
            }
            else
            {
                tbxResponse.ForeColor = Color.Red;
                tbxResponse.Text = "Veuillez remplir tout les champs";
            }
                


        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
