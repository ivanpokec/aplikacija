using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacija
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btIzracunaj_Click(object sender, EventArgs e)
        {
            float polumjer = 0;

            polumjer = izracunaj(polumjer);
            if (chkSpremi.Checked == true) IstRezultati.Items.Add(polumjer);
        }

        private float izracunaj(float polumjer)
        {
            float povrsina = 0;
            float opseg = 0;

            float.TryParse(txtPolumjer.Text, out polumjer);

            if (polumjer > 0)
            {
                opseg = 2 * polumjer * (float)Math.PI;
                povrsina = polumjer * polumjer * (float)Math.PI;

                txtOpseg.Text = Math.Round(opseg,2).ToString();
                txtPovršina.Text = Math.Round(povrsina,2).ToString();


            }
            return polumjer;
        }

        private void IstRezultati_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float polumjer = 0;
            float.TryParse(IstRezultati.SelectedItem.ToString(),out polumjer;
            txtPolumjer.Text=polumjer.ToString();
            btIzracunaj_Click(null,null);
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            IstRezultati.Items.Clear();
            txtOpseg = "0,00";
            txtPolumjer = "0,00";
            txtPovršina = "0,00";
        }
    }
}
