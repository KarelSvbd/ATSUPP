using Intercom.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAtelierSupport
{
    public partial class frmEmprunts : Form
    {
        public frmEmprunts()
        {
            InitializeComponent();
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
                JObject response = JObject.Parse(strresulttest);

                foreach(var raw in response)
                {
                    Console.WriteLine(raw.ToString());
                }
                
                sr.Close();
            }
            FrmMain frmMain = new FrmMain(utilisateur);
            frmMain.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstEmprunts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
