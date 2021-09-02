using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice2
{
    class Clavier
    {
        private void OnClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                (sender as Button).BackColor = Color.Blue;
            }

        }
        public Clavier() : base()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Image = Properties.Resources.tortue;
            Invalidate();

            Click += OnClick;
        }
    }
}
