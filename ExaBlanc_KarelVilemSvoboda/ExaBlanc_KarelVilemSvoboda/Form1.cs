using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaBlanc_KarelVilemSvoboda
{
    public partial class Frm1 : Form
    {
        PMModel _model;
        public Frm1()
        {
            InitializeComponent();

            foreach (var item in PMModel.AvailableDurations)
            {
                cbxDuree.Items.Add(item);
            }

            foreach (var item in PMModel.AvailableRate)
            {
                cbxVehicule.Items.Add(item);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _model = new PMModel(cbxVehicule.SelectedIndex, cbxDuree.SelectedIndex, tbxImmatriculation.Text);
            tbxTicket.Text = _model.ticketString;
            
        }
    }
}
