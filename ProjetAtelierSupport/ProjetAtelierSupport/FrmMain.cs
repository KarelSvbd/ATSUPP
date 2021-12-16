using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAtelierSupport
{
    public partial class FrmMain : Form
    {
        private User user;
        private ApiClient apiClient = new ApiClient();
        public FrmMain(User utilisateur)
        {
            InitializeComponent();
            user = utilisateur;
            lblEmail.Text = user.Email;

            btnEmprunts.Enabled = false;
            btnModeles.Enabled = false;
            btnTypeObjet.Enabled = false;
            btnPersonnes.Enabled = false;
            btnConnexions.Enabled = false;
            btnGrade.Enabled = false;

            switch (user.IdGrade)
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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmInfoUser frmInfoUser = new FrmInfoUser(user);
            frmInfoUser.Show();
        }

        private void btnEmprunts_Click(object sender, EventArgs e)
        {
            FrmEmprunts frmEmp = new FrmEmprunts(user);
            frmEmp.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            apiClient.Disconnect(user.IdPersonne);
        }
    }
}
