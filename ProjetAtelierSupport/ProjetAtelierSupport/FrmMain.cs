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
            frmInfoUser frmInfoUser = new frmInfoUser(user);
            frmInfoUser.Show();
        }

        private void btnEmprunts_Click(object sender, EventArgs e)
        {
            frmEmprunts frmEmp = new frmEmprunts();
            frmEmp.Show();
        }
    }
}
