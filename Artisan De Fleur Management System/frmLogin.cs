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
    public partial class frmLogin : Form
    {
        public static string UserID;
        public static string UserType;
        public static string Firstname;
        public static string Lastname;
        public static string MI;
        public static string username;
        public static string password;

        public static string Fullname;

        public frmLogin()
        {
            this.ActiveControl = txtbUsername;
            InitializeComponent();
        }

        private void LOGIN()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            string query = "Select Count(*) FROM tbl_useraccounts where Uname = '" + txtbUsername.Text + "' and Passwd = '" + txtbPassword.Text + "'";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            MySqlDataAdapter sda = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                string selectAccount = "Select UserID,Fname,Lname,Mname,UserType,Uname,Passwd FROM tbl_useraccounts where Uname = '" + txtbUsername.Text + "' and Passwd = '" + txtbPassword.Text + "'";

                try
                {
                    MySqlDataAdapter sda2 = new MySqlDataAdapter(selectAccount, cnn);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);

                    UserID = dt2.Rows[0][0].ToString();
                    Firstname = dt2.Rows[0][1].ToString();
                    Lastname = dt2.Rows[0][2].ToString();
                    Fullname = Firstname.ToString() + " " + Lastname.ToString();

                    MI = dt2.Rows[0][3].ToString();
                    UserType = dt2.Rows[0][4].ToString();
                    username = dt2.Rows[0][5].ToString();
                    password = dt2.Rows[0][6].ToString();

                }
                catch (System.IndexOutOfRangeException)
                {

                }

                if (UserType.ToString() == "ADMIN")
                {
                    frmAdminDashboard frmAdmin = new frmAdminDashboard();
                    frmAdmin.Visible = true;
                    frmAdmin.lblUser.Text = "Welcome, " + Fullname;
                    frmAdmin.lblUserID.Text = UserID;
                    txtbPassword.Clear();
                    txtbUsername.Clear();
                    txtbUsername.Focus();
                    this.Hide();
                    cnn.Close();
                }else if (UserType.ToString() == "CASHIER")
                {
                    frmPOS POS = new frmPOS();
                    POS.Visible = true;
                    POS.lblUser.Text = Fullname;
                    txtbPassword.Clear();
                    txtbUsername.Clear();
                    txtbUsername.Focus();
                    this.Hide();
                    cnn.Close();
                }
            }
            else
            {
                MessageBox.Show("You've entered wrong credentials.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbPassword.Clear();
                txtbPassword.Focus();
            }
            cnn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbPassword.Text == "" && txtbUsername.Text == "")
            {
                MessageBox.Show("Please fill in the blanks.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbUsername.Focus();
            }
            else if (txtbPassword.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbPassword.Focus();
            }
            else if (txtbUsername.Text == "")
            {
                MessageBox.Show("Please enter your username.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbUsername.Focus();
            }
            else
            {
                try
                {
                    LOGIN();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Connection not open!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbPassword.Text = "";
                    txtbUsername.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtbPassword.PasswordChar = '\0';
            }
            else if (cbShow.Checked == false)
            {
                txtbPassword.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tDateTime.Enabled = true;
            txtbUsername.Focus();
        }

        private void tDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss");
        }

        private void txtbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtbPassword.Focus();
            }
        }

        private void txtbUsername_TextChanged(object sender, EventArgs e)
        {
            string username = txtbUsername.Text.Trim();
            txtbUsername.Text = username.ToString();
            txtbUsername.SelectionStart = txtbUsername.Text.Length;
            txtbUsername.SelectionLength = 0;
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtbPassword.Text.Trim();
            txtbPassword.Text = password.ToString();
            txtbPassword.SelectionStart = txtbPassword.Text.Length;
            txtbPassword.SelectionLength = 0;
        }

        private void txtbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
