using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Derékszögű háromszög";
            lbA.Text = "A oldal";
            lbB.Text = "B oldal";
            lbC.Text = "C oldal";
            txtC.Enabled = false;
            btnSzamol.Text = "Számol";
            btnSzamol.Enabled = false;
            btnDel.Text = "Töröl";
            btnEnd.Text = "Vége";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtA.Text = String.Empty;
            txtB.Text = String.Empty;
            txtC.Text = String.Empty;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            if (!(txtA.Text==String.Empty) && !(txtB.Text == String.Empty))
            {
                txtC.Text = (int.Parse(txtA.Text) + int.Parse(txtB.Text)).ToString();
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
