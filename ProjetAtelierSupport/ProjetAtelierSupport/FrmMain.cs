/* Projet   : ProjetAtelierSupport
 * Class    : FrmMain.cs
 * Desc.    : Gère la vue de la FrmMain
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
    public partial class FrmMain : Form
    {
        private User _user;
        private ApiClient _apiClient = new ApiClient();
        public FrmMain(User utilisateur)
        {
            InitializeComponent();
            _user = utilisateur;
            lblEmail.Text = _user.Email;

            //Désactivation de touts les boutons
            btnEmprunts.Enabled = false;
            btnModeles.Enabled = false;
            btnTypeObjet.Enabled = false;
            btnPersonnes.Enabled = false;
            btnConnexions.Enabled = false;
            btnGrade.Enabled = false;

            //Activation des boutons en fonction du grade
            //1 -> le plus élevé, 4 -> le plus faible
            switch (_user.IdGrade)
            {
                case "1":
                    btnEmprunts.Enabled = true;
                    btnModeles.Enabled = true;
                    btnTypeObjet.Enabled = true;
                    btnPersonnes.Enabled = true;
                    btnConnexions.Enabled = true;
                    btnGrade.Enabled = true;
                    break;
                case "2":
                    btnEmprunts.Enabled = true;
                    btnModeles.Enabled = true;
                    btnTypeObjet.Enabled = true;
                    btnPersonnes.Enabled = true;
                    btnGrade.Enabled = true;
                    break;
                case "3":
                    btnEmprunts.Enabled = true;
                    btnModeles.Enabled = true;
                    btnTypeObjet.Enabled = true;
                    break;
                case "4":
                    btnEmprunts.Enabled = true;
                    break;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmInfoUser frmInfoUser = new FrmInfoUser(_user);
            frmInfoUser.Show();
        }

        private void btnEmprunts_Click(object sender, EventArgs e)
        {
            FrmEmprunts frmEmp = new FrmEmprunts(_user);
            frmEmp.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _apiClient.Disconnect(_user.IdPersonne, _user);
        }
    }
}
