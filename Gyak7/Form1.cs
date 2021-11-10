using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
            lblOp1.Text = "Op 1";
            lblOp2.Text = "Op 2";
            btnSum.Text = "+";
            btnSub.Text = "-";
            btnMultip.Text = "*";
            btnDiv.Text = "/";
            btnMod.Text = "%";
            lblAns.Text = "Eredmény";
            btnDel.Text = "Töröl";
            btnEnd.Text = "Vége";

            btnDel.Enabled = false;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txtAns.Text = (int.Parse(txtOp1.Text) + int.Parse(txtOp2.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtAns.Text = (int.Parse(txtOp1.Text) - int.Parse(txtOp2.Text)).ToString();
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            txtAns.Text = (int.Parse(txtOp1.Text) * int.Parse(txtOp2.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtAns.Text = (int.Parse(txtOp1.Text) / int.Parse(txtOp2.Text)).ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            txtAns.Text = (int.Parse(txtOp1.Text) % int.Parse(txtOp2.Text)).ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtOp1.Text = String.Empty;
            txtOp2.Text = String.Empty;
            txtAns.Text = String.Empty;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOp1_TextChanged(object sender, EventArgs e)
        {
            if (txtOp1.Text == String.Empty)
            {
                if (txtOp2.Text == String.Empty)
                {
                    btnDel.Enabled = false;
                }
                else
                {
                    btnDel.Enabled = true;
                }
            }
        }
    }
}
