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
    public partial class FrmEmprunts : Form
    {
        private ApiClient _apiClient = new ApiClient();
        private dynamic _data;
        public FrmEmprunts(User utilisateur)
        {
            InitializeComponent();

            _data = _apiClient.DeserialiseJSON(_apiClient.GetEmprunts());
            DisplayEmprunt();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstEmprunts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayEmprunt()
        {
            foreach(var element in _data)
            {
                lstEmprunts.Items.Add(_apiClient.GetNamePersonneById(element["0"].ToString()) + " " + _apiClient.GetNameModeleById(element["1"].ToString()));
            }
        }

    }
}
