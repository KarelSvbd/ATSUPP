/* Projet   : Tamagotchi
 * Version  : 1.0
 * Date     : 14.10.2021
 * 
 * Desc.    : Créer une simulation de Tamagotchi, https://classroom.google.com/c/Mzg3ODczMjU0MzMy/a/Mzg3ODczMjU0MzQ0/details
 */
using System;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class lblFatigue : Form
    {
        //Creation d'un nouveau Tama (vitesse recommandée 30)
        Tama Bestiole = new Tama("Tim", 80, 80, 10, 10, 30);
        
        public lblFatigue()
        {
            InitializeComponent();
            
        }

        //Permet de à l'utlisateur d'intéragie avec la classe Tama
        private void btnManger_Click(object sender, EventArgs e)
        {
            Bestiole.Manger(10);
        }

        private void btnBoire_Click(object sender, EventArgs e)
        {
            Bestiole.Boire(10);
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            Bestiole.Dormir(10);
        }

        private void btnSoigner_Click(object sender, EventArgs e)
        {
            Bestiole.Soigner(10);
        }

        //Bouton de nouvelle partie
        private void btnReset_Click(object sender, EventArgs e)
        {
            Bestiole.NewGame("Tam", 80, 80, 10, 10, 30);
        }

        /// <summary>
        /// Permet de mettre à jour la vue grâce aux information présents dans les paramètres Bestiole
        /// </summary>
        public void UpdateView()
        {
            pgbCalorie.Value = Bestiole.Calorie;
            pgbLiquide.Value = Bestiole.Liquide;
            pgbFatigue.Value = Bestiole.Fatigue;
            pgbVirus.Value = Bestiole.Virus;

            tbxEtat.Text = Bestiole.Vivre();
            tbxTama.Text = Bestiole.ImageLapin();

            //Si la bestiole est morte, on désactive les boutons qui permettent à l'utlisateur d'intéragir avec elle.
            //On affiche son nom et le nombre de seconde qu'elle est restée en vie.
            if (Bestiole.EstMort())
            {
                btnManger.Enabled = false;
                btnBoire.Enabled = false;
                btnSoigner.Enabled = false;
                btnDormir.Enabled = false;
                tbxEtat.Text +=  " " + Bestiole.Nom + " a survecu : " + Bestiole.SECONDEENVIE.ToString() + " secondes";
            }
            else
            {
                btnManger.Enabled = true;
                btnBoire.Enabled = true;
                btnSoigner.Enabled = true;
                btnDormir.Enabled = true;
            }
        }
        /// <summary>
        /// On met à jour les élèment en fonction du timer
        /// </summary>
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
