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
using System.Text.RegularExpressions;

namespace Artisan_De_Fleur_Management_System
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            this.ActiveControl = txtbFirstname;
            this.ShowInTaskbar = false;
            InitializeComponent();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtbPassword.PasswordChar = '\0';
                txtbConfirmpass.PasswordChar = '\0';
                txtbPassword.Focus();
            }
            else if (cbShow.Checked == false)
            {
                txtbPassword.PasswordChar = '*';
                txtbConfirmpass.PasswordChar = '*';
                txtbPassword.Focus();
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {

            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "MM/dd/yyyy";

            if (frmAdminDashboard.Birthday_Value != "")
            {
                dtpBirthday.Value = Convert.ToDateTime(frmAdminDashboard.Birthday_Value);
            }
        }

        private void AdminID()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string dtID = DateTime.Now.ToString("yyyy");
            string query = "Select max(ID) as ID from tbl_useraccounts";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (!reader.HasRows || Convert.IsDBNull(reader["ID"]))
            {
                txtbUserID.Text = "AE" + dtID + "10001";
                txtbUsername.Text = "ADMIN" + "0001";
            }
            else
            {
                int newID = (int)reader.GetInt32("ID");
                newID += 1;
                txtbUserID.Text = "AE" + dtID + newID.ToString("10000");
                txtbUsername.Text = "ADMIN" + newID.ToString("0000");
            }

            reader.Close();
            cnn.Close();
        }

        private void CashierID()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string dtID = DateTime.Now.ToString("yyyy");
            string query = "Select max(ID) as ID from tbl_useraccounts";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (!reader.HasRows || Convert.IsDBNull(reader["ID"]))
            {
                txtbUserID.Text = "CE" + dtID + "10001";
                txtbUsername.Text = "CASHIER" + "0001";
            }
            else
            {
                int newID = (int)reader.GetInt32("ID");
                newID += 1;
                txtbUserID.Text = "CE" + dtID + newID.ToString("10000");
                txtbUsername.Text = "CASHIER" + newID.ToString("0000");
            }

            reader.Close();
            cnn.Close();
        }

        private void Clear()
        {
            cmbUsertype.SelectedIndex = -1;
            txtbUserID.Clear();

            txtbFirstname.Clear();
            txtbLastname.Clear();
            txtbMI.Clear();
            cmbGender.SelectedIndex = -1;

            dtpBirthday.ResetText();
            txtbPhone.Clear();
            txtbAddress.Clear();

            txtbUsername.Clear();
            txtbPassword.Clear();
            txtbConfirmpass.Clear();
            txtbPassword.PasswordChar = '*';
            txtbConfirmpass.PasswordChar = '*';
            cbShow.Checked = false;
        }

        private void cmbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsertype.Text == "ADMIN")
            {
                AdminID();
            }
            else if (cmbUsertype.Text == "CASHIER")
            {
                CashierID();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var dateAndTime = dtpBirthday.Value;
            var date = dateAndTime.Date;

            string phonePattern = @"^(09|\+639)\d{9}$"; // Philippine Phone number pattern   
            bool isPhoneValid = Regex.IsMatch(txtbPhone.Text, phonePattern);

            string passwordPattern = @"^(?=.*\d)(?=.*[A-Z])(?=.*[^A-Z0-9])(?!.*\s).{8,}$"; // Password pattern   
            bool isPasswordValid = Regex.IsMatch(txtbPassword.Text, passwordPattern);
            bool isPassword2Valid = Regex.IsMatch(txtbConfirmpass.Text, passwordPattern);

            if (btnRegister.Text == "CREATE ACCOUNT")
            {
                if (txtbFirstname.Text == "" || txtbLastname.Text == "" || txtbMI.Text == "" || txtbAddress.Text == "" || cmbUsertype.SelectedIndex == -1 || txtbPassword.Text == "" || txtbConfirmpass.Text == "" || txtbPhone.Text == "")
                {
                    MessageBox.Show("Please fill in the blanks.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtbPassword.Text != txtbConfirmpass.Text)
                {
                    MessageBox.Show("Please confirm your password.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtbPassword.TextLength < 8 || txtbConfirmpass.TextLength < 8)
                {
                    MessageBox.Show("Password must be minimum of 8 characters.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!isPasswordValid && !isPassword2Valid)
                {
                    MessageBox.Show("Password should contain at least one numeric digit, and one special character (? ! . *), but no spaces.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select gender.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtpBirthday.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Please select your birthday.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!isPhoneValid)
                {
                    MessageBox.Show("Phone number is invalid.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                    MySqlConnection cnn = new MySqlConnection(connectionString);

                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    string query = "INSERT into tbl_useraccounts(UserID, Fname, Lname, Mname, Address, Gender, ContactNumber, Uname, Passwd, UserType, Birthdate) Values('" + txtbUserID.Text + "', '" + txtbFirstname.Text.Trim() + "', '" + txtbLastname.Text.Trim() + "', '" + txtbMI.Text + "', '" + txtbAddress.Text + "', '" + cmbGender.Text + "', '" + txtbPhone.Text + "', '" + txtbUsername.Text + "', '" + txtbPassword.Text + "', '" + cmbUsertype.Text + "', '" + date.ToString("MM/dd/yyyy") + "')";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                    cnn.Close();
                    Clear();

                    MessageBox.Show("Saved successfully.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (txtbFirstname.Text == "" || txtbLastname.Text == "" || txtbMI.Text == "" || txtbAddress.Text == "" || cmbUsertype.SelectedIndex == -1 || txtbPassword.Text == "" || txtbConfirmpass.Text == "" || txtbPhone.Text == "")
                {
                    MessageBox.Show("Please fill in the blanks.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtbPassword.Text != txtbConfirmpass.Text)
                {
                    MessageBox.Show("Please confirm your password.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtbPassword.TextLength < 8 || txtbConfirmpass.TextLength < 8)
                {
                    MessageBox.Show("Password must be minimum of 8 characters.", "Book Shop Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!isPasswordValid && !isPassword2Valid)
                {
                    MessageBox.Show("Password should contain at least one numeric digit, and one special character  (? ! . *), but no spaces.", "Book Shop Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select gender.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtpBirthday.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Please select your birthday.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!isPhoneValid)
                {
                    MessageBox.Show("Phone number is invalid.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                    MySqlConnection cnn = new MySqlConnection(connectionString);

                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    string query = "UPDATE tbl_useraccounts SET Fname = '" + txtbFirstname.Text.Trim() + "', Lname = '" + txtbLastname.Text.Trim() + "', Mname = '" + txtbMI.Text + "', Address = '" + txtbAddress.Text + "' , Gender = '" + cmbGender.Text + "', ContactNumber = '" + txtbPhone.Text + "', Passwd = '" + txtbPassword.Text + "', Birthdate = '" + date.ToString("MM/dd/yyyy") + "' WHERE UserID = '" + txtbUserID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                    cnn.Close();
                    Clear();
                    this.Close();

                    MessageBox.Show("Updated successfully.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtbFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbFirstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
        }

        private void txtbFirstname_TextChanged(object sender, EventArgs e)
        {
            string sentence = txtbFirstname.Text;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            sentence = regex.Replace(sentence, " ");
            txtbFirstname.SelectionStart = txtbFirstname.Text.Length;
            txtbFirstname.SelectionLength = 0;
            txtbFirstname.Text = sentence.ToString();
        }

        private void txtbLastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
        }

        private void txtbLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbLastname_TextChanged(object sender, EventArgs e)
        {
            string sentence = txtbLastname.Text;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            sentence = regex.Replace(sentence, " ");
            txtbLastname.SelectionStart = txtbLastname.Text.Length;
            txtbLastname.SelectionLength = 0;
            txtbLastname.Text = sentence.ToString();
        }

        private void txtbMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbMI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
        }

        private void txtbMI_TextChanged(object sender, EventArgs e)
        {
            string sentence = txtbMI.Text;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            sentence = regex.Replace(sentence, " ");
            txtbMI.SelectionStart = txtbMI.Text.Length;
            txtbMI.SelectionLength = 0;
            txtbMI.Text = sentence.ToString();
        }

        private void txtbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '+' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
        }

        private void txtbPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string phone_number = txtbPhone.Text.Trim();
                txtbPhone.Text = phone_number.ToString();
                txtbPhone.SelectionStart = txtbPhone.Text.Length;
                txtbPhone.SelectionLength = 0;

                string str = txtbPhone.Text;
                string res = str.Substring(0, 1);

                if (res.ToString() == "0")
                {
                    txtbPhone.MaxLength = 11;
                }
                else if (res.ToString() == "+")
                {
                    txtbPhone.MaxLength = 13;
                }
                else
                {
                    txtbPhone.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
        }

        private void txtbConfirmpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
        }




        //END OF CODE

    }
}
