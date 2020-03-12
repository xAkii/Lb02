using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class frmTaschenrechner : Form
    {
        double zahl1, zahl2;
        public frmTaschenrechner()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            ZahlenEinlesen();
            Class1.Addition(zahl1,zahl2);
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            ZahlenEinlesen();
            lblErgebnis.Text = Convert.ToString(Class1.Subtraktion(zahl1, zahl2));
        }

        private void btnMultiplikation_Click(object sender, EventArgs e)
        {
            ZahlenEinlesen();
            lblErgebnis.Text = Convert.ToString(Class1.Multiplikation(zahl1, zahl2));
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ZahlenEinlesen();
            lblErgebnis.Text = Convert.ToString(Class1.Division(zahl1, zahl2));
        }

        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            ZahlenEinlesen();
            lblErgebnis.Text = Convert.ToString(Class1.Mittelwert(zahl1, zahl2));
        }

        private void btnPotenz_Click(object sender, EventArgs e)
        {
            ZahlenEinlesen();
            lblErgebnis.Text = Convert.ToString(Class1.Potenz(zahl1, zahl2));
        }

        private void btnMaxium_Click(object sender, EventArgs e)
        {
            ZahlenEinlesen();
            lblErgebnis.Text = Convert.ToString(Class1.Maximum(zahl1, zahl2));
        }

        public void ZahlenEinlesen()
        {
            try
            {
                zahl1 = Convert.ToDouble(txtOperand1.Text);
                zahl2 = Convert.ToDouble(txtOperand2.Text);
            }
            catch (Exception e)
            {
                txtOperand1.Text = "";
                txtOperand2.Text = "";
            }
            
        }

    }
}
