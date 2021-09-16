/* Projet   : Exercice2
 * Desc     : https://classroom.google.com/c/Mzg3ODczMjU0MzMy/a/Mzg3ODczMjU0MzM5/details
 * Date     : 16.09.2021
 * Version  : 1.0
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A
 */

using System;
using System.Windows.Forms;

namespace Exercice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Quand le bouton est appuyé, on inverse le texte et on l'envoie dans tbxReverse
        private void btnReverse_Click(object sender, EventArgs e)
        {
            tbxReverse.Text = Reverse(tbxText.Text);
        }

        //Methode d'inversion, retourne la variable s inversée
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            //Envoie du tbxText dans la class Clavier
            Clavier.reftbx = tbxText;
        }
    }
}
