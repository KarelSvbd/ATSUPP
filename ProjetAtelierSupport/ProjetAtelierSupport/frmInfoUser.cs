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
    public partial class frmInfoUser : Form
    {
        private User _user;
        public frmInfoUser(User user)
        {
            InitializeComponent();
            _user = user;
            Text = _user.Nom + " " + _user.Prenom;
        }

        private void frmInfoUser_Load(object sender, EventArgs e)
        {
            lblEmail.Text = _user.Email;
            lblNom.Text = _user.Nom;
            lblPrenom.Text = _user.Prenom;
            lblGrade.Text = _user.NomGrade;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
