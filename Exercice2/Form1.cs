/* Projet   : Exercice2
 * Desc     : https://classroom.google.com/c/Mzg3ODczMjU0MzMy/a/Mzg3ODczMjU0MzM5/details
 * Date     : 16.09.2021
 * Version  : 1.0
 * 
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A
 */

using System;
using System.Collections;
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
            Stack listeChar = new Stack();
            string resultat = "";
            foreach(char l in s)
            {
                listeChar.Push(l);
            }
            foreach(var ltr in listeChar)
            {
                resultat += ltr;
            }
            return resultat;

        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            //Envoie du tbxText dans la class Clavier
            Clavier.reftbx = tbxText;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            tbxText.Text += clavier1.Interpreteur(e.KeyChar);
            tbxText.Text += clavier2.Interpreteur(e.KeyChar);
            tbxText.Text += clavier3.Interpreteur(e.KeyChar);
            tbxText.Text += clavier4.Interpreteur(e.KeyChar);
            tbxText.Text += clavier5.Interpreteur(e.KeyChar);
            tbxText.Text += clavier6.Interpreteur(e.KeyChar);
            tbxText.Text += clavier7.Interpreteur(e.KeyChar);
            tbxText.Text += clavier8.Interpreteur(e.KeyChar);
            tbxText.Text += clavier9.Interpreteur(e.KeyChar);
            tbxText.Text += clavier10.Interpreteur(e.KeyChar);
            tbxText.Text += clavier11.Interpreteur(e.KeyChar);
            tbxText.Text += clavier12.Interpreteur(e.KeyChar);
            tbxText.Text += clavier13.Interpreteur(e.KeyChar);
            tbxText.Text += clavier14.Interpreteur(e.KeyChar);
            tbxText.Text += clavier15.Interpreteur(e.KeyChar);
            tbxText.Text += clavier16.Interpreteur(e.KeyChar);
            tbxText.Text += clavier17.Interpreteur(e.KeyChar);
            tbxText.Text += clavier18.Interpreteur(e.KeyChar);
            tbxText.Text += clavier19.Interpreteur(e.KeyChar);
            tbxText.Text += clavier20.Interpreteur(e.KeyChar);
            tbxText.Text += clavier21.Interpreteur(e.KeyChar);
            tbxText.Text += clavier22.Interpreteur(e.KeyChar);
            tbxText.Text += clavier23.Interpreteur(e.KeyChar);
            tbxText.Text += clavier24.Interpreteur(e.KeyChar);
            tbxText.Text += clavier25.Interpreteur(e.KeyChar);
            tbxText.Text += clavier26.Interpreteur(e.KeyChar);
            tbxText.Text += clavier27.Interpreteur(e.KeyChar);
            tbxText.Text += clavier28.Interpreteur(e.KeyChar);

        }
    }
}
