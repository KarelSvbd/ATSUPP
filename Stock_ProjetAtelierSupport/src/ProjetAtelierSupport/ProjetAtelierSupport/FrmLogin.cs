/* Projet   : ProjetAtelierSupport
 * Class    : frmLogin.cs
 * Desc.    : Login de connexion
 * Date     : 16.12.2021
 * Version  : 0.1
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A - 4e CFPT Info.
 */

using System;
using System.Windows.Forms;

namespace ProjetAtelierSupport
{
    public partial class FrmLogin : Form
    {
        private ApiClient _apiClient = new ApiClient();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //Si tous les champs sont remplis
            if(tbxEmail.Text != "" && tbxPassword.Text != "")
            {
                //Essai de login
                User response = _apiClient.CreateUserByGetCall("http://localhost/ProjetsWeb/API_ProjetAtelierSupport/?connect=ep&email=" + tbxEmail.Text + "&password=" + tbxPassword.Text + "");

                //Si le login est correcte
                if(response != null)
                {
                    //Ouverture de la form suivante
                    FrmMain frmMain = new FrmMain(response);
                    frmMain.Show();
                }
                //Si le login est erroné
                else
                {
                    tbxResponse.Text = "Mauvaises données de connexion";
                }
            }
            else
            {
                tbxResponse.Text = "Veuillez remplir tout les champs";
            }
        }
    }
}
