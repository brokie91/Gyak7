using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Közepek";
            lbX.Text = "X";
            lbY.Text = "Y";
            lbSzamtani.Text = "Számtani";
            lbMertani.Text = "Mértani";
            lbHarmonikus.Text = "Harmonikus";
            btnSzamol.Text = "Számol";
            btnTorles.Text = "Törlés";
            btnVege.Text = "Vége";

            //Nem használható textBoxok
            txtSzamtani.Enabled = false;
            txtMertani.Enabled = false;
            txtHarmonikus.Enabled = false;

            //Kezdetben nem használható gombok
            btnSzamol.Enabled = false;
            btnTorles.Enabled = false;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            txtSzamtani.Text = ((double.Parse(txtX.Text) + double.Parse(txtY.Text))/2).ToString();
            txtMertani.Text = Math.Sqrt((int.Parse(txtX.Text) * int.Parse(txtY.Text))).ToString();
            txtHarmonikus.Text = (2 / (1 / double.Parse(txtX.Text) + 1 / double.Parse(txtY.Text))).ToString();
        }

        private void btnVege_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            txtX.Text = String.Empty;
            txtY.Text = String.Empty;
            txtSzamtani.Text = String.Empty;
            txtMertani.Text = String.Empty;
            txtHarmonikus.Text = String.Empty;
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            if (txtX.Text != String.Empty && txtY.Text != String.Empty)
            {
                btnSzamol.Enabled = true;
            }
            else
            {
                btnSzamol.Enabled = false;
            }

            if (txtX.Text != String.Empty || txtY.Text != String.Empty)
            {
                btnTorles.Enabled = true;
            }
            else
            {
                btnTorles.Enabled = false;
            }
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            if (txtX.Text != String.Empty && txtY.Text != String.Empty)
            {
                btnSzamol.Enabled = true;
            }
            else
            {
                btnSzamol.Enabled = false;
            }

            if (txtX.Text != String.Empty || txtY.Text != String.Empty)
            {
                btnTorles.Enabled = true;
            }
            else
            {
                btnTorles.Enabled = false;
            }
        }
    }
}
