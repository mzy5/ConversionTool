using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertorLeiEuro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtLei_TextChanged(object sender, EventArgs e)
        {

            Double sumaLei;
            bool conversionIsSuccessful;
            conversionIsSuccessful = Double.TryParse(txtLei.Text, out sumaLei);
            if (conversionIsSuccessful == true)
            {
                var sumaEuro = sumaLei * 1 / 4.9;
                txtEuro.Text = Convert.ToString(sumaEuro);
            }
        }

        private void txtEuro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
