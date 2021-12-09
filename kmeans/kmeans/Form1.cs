namespace kmeans
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<int> lstNumero = new List<int>();
        List<int> lstNumeroTires = new List<int>();
        public Form1()
        {
            InitializeComponent();
            lblListe.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstNumero.Add(Convert.ToInt32(nudNumero.Value));
            lblListe.Text = "";
            foreach (int element in lstNumero)
            {
                lblListe.Text += element.ToString() + " " ;
            }
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                lstNumeroTires.Add(lstNumero[random.Next(0, lstNumero.Count)]);
            }
            lblNumeroTrouves.Text = "";
            foreach (int element in lstNumeroTires)
            {
                lblNumeroTrouves.Text += element.ToString();
            }
        }
    }
}