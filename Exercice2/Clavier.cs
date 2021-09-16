/* Projet   : Exercice2
 * Date     : 16.09.2021
 * Version  : 1.0
 * 
 * Class    : Clavier.cs
 * Desc     : Crée un bouton
 *
 * Auteur   : Karel V. Svoboda
 * Classe   : I.DA-P4A
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercice2
{
    class Clavier : Button
    {
        //Définition des champs
        private string _lettre;
        //Récupération de tbxText
        public static TextBox reftbx;

        //propriétés
        public string Lettre
        {
            get { return _lettre; }   
            set { _lettre = value; } 
        }
        private void OnClick(object sender, EventArgs e)
        {
            //On envoie le text du bouton et on le place dans tbxText 
            _lettre = Text;
            reftbx.Text += Text;
        }
        public Clavier() : base()
        {
            //Définition du style du bouton
            Size = new Size(50, 50);
            BackColor = Color.Black;
            ForeColor = Color.White;
            //ajout de la mathode OnClivkà l'évenement Click du bouton
            Click += OnClick;
        }
    }
}
