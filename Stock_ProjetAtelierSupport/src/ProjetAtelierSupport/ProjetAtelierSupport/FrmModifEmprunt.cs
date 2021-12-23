/* Projet   : ProjetAtelierSupport
 * Class    : FrmModifEmprunt.cs
 * Desc.    : Gère la vue de la FrmModifEmprunt
 * Date     : 23.12.2021
 * Version  : 0.1
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A - 4e CFPT Info.
 */

using System;
using System.Windows.Forms;

namespace ProjetAtelierSupport
{
    public partial class FrmModifEmprunt : Form
    {
        Emprunt _emprunt;
        ApiClient _apiClient;
        FrmEmprunts _frmEmprunts;

        /// <summary>
        /// Crée une form de modification d'emprunt
        /// </summary>
        /// <param name="emprunt"></param>
        /// <param name="apiClient"></param>
        /// <param name="frmEmprunts"></param>
        public FrmModifEmprunt(Emprunt emprunt, ApiClient apiClient, FrmEmprunts frmEmprunts)
        {
            InitializeComponent();
            _emprunt = emprunt;
            _apiClient = apiClient;
            _frmEmprunts = frmEmprunts;

            //Affichage du nom en fonction de l'id de l'utilisateur
            tbxPeronneInitiale.Text = _apiClient.GetNamePersonneById(_emprunt.IdPersonne, _frmEmprunts.UserActuel);
            tbxObjetInitial.Text = _apiClient.GetNameModeleById(_emprunt.IdModele, _frmEmprunts.UserActuel);
            
            //Ajout des éléments dans les combosboxs
            foreach(var personne in _apiClient.GetAllPersonne(_frmEmprunts.UserActuel))
            {
                cbxPersonne.Items.Add(personne);
            }
            foreach(var modele in _apiClient.GetAllModele(_frmEmprunts.UserActuel))
            {
                cbxObjet.Items.Add(modele);
            }

            //Affichage des donnée par défault dans les combos box en fonction de l'id de l'utlisateur
            cbxObjet.SelectedItem = _apiClient.GetNameModeleById(_emprunt.IdModele, _frmEmprunts.UserActuel);
            cbxPersonne.SelectedItem = _apiClient.GetNamePersonneById(_emprunt.IdPersonne, _frmEmprunts.UserActuel);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            _apiClient.ModifierEmprunt(_emprunt.IdModele, _emprunt.IdPersonne, (cbxObjet.SelectedIndex + 1).ToString(), (cbxPersonne.SelectedIndex+1).ToString(), _frmEmprunts.UserActuel);

            //Met à jour la vue de FrmEmprunt
            _frmEmprunts.UpdateView();
            Close();
        }
    }
}
