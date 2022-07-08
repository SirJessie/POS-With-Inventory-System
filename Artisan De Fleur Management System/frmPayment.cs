using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Artisan_De_Fleur_Management_System
{
    public partial class frmPayment : Form
    {
        // DISABLING CLOSE BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void txtbCashAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtbCashAmount.Text != "")
            {
                double total, cash;
                total = Convert.ToDouble(txtbTotalAmount.Text);
                cash = Convert.ToDouble(txtbCashAmount.Text);
                if (cash >= total)
                {
                    txtbChange.Text = Math.Round((cash - total), 2).ToString("N");
                }
                else
                {
                    txtbChange.Text = "0.00";
                }

            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtbCashAmount.Text != "")
            {
                double total, cash;
                total = Convert.ToDouble(txtbTotalAmount.Text);
                cash = Convert.ToDouble(txtbCashAmount.Text);
                if (cash >= total)
                {
                    if(cash > total)
                    {
                        MessageBox.Show("Change is P" + (cash - total) , "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Thankyou for purchasing. Come again...", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insufficient Amount!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Cash Amount!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbCashAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                btnPayment.PerformClick();
            }
        }

    }
}
