/* Projet   : ProjetAtelierSupport
 * Class    : FrmEmprunts.cs
 * Desc.    : Gère la vue de la FrmEmprunts
 * Date     : 23.12.2021
 * Version  : 0.1
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A - 4e CFPT Info.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetAtelierSupport
{
    public partial class FrmEmprunts : Form
    {
        private ApiClient _apiClient = new ApiClient();
        private dynamic _data;
        private User _user;
        private List<Emprunt> _emprunts = new List<Emprunt>();

        public User UserActuel
        {
            get { return _user; }
            set { _user = value; }
        }
        /// <summary>
        /// Form avec la liste des emprunts
        /// </summary>
        /// <param name="utilisateur"></param>
        public FrmEmprunts(User utilisateur)
        {
            InitializeComponent();
            _user = utilisateur;
            UpdateView();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstEmprunts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = true;
        }

        /// <summary>
        /// Permet d'afficer les emprunts dans la listbox lstEmprunts
        /// </summary>
        private void DisplayEmprunt()
        {
            lstEmprunts.Items.Clear();
            foreach(var element in _data)
            {
                lstEmprunts.Items.Add(_apiClient.GetNamePersonneById(element["0"].ToString(), _user) + " " + _apiClient.GetNameModeleById(element["1"].ToString(), _user));
                _emprunts.Add(new Emprunt(element["1"].ToString(), element["0"].ToString()));
            }
        }

        /// <summary>
        /// https://stackoverflow.com/questions/4454423/c-sharp-listbox-item-double-click-event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEmprunts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstEmprunts.IndexFromPoint(e.Location);
            //Test du niveau de grade
            if(Convert.ToInt32(_user.IdGrade) < 4)
            {
                if (index != ListBox.NoMatches)
                {
                    FrmModifEmprunt frmMain = new FrmModifEmprunt(_emprunts[index], _apiClient, this);
                    frmMain.Show();
                }
            }

        }

        /// <summary>
        /// Actualise la liste
        /// </summary>
        public void UpdateView()
        {
            _data = _apiClient.DeserialiseJSON(_apiClient.GetEmprunts(_user));
            DisplayEmprunt();
        }
    }
}
