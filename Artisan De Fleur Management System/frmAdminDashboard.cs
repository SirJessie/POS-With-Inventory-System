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
    public partial class frmAdminDashboard : Form
    {
        public static string GetUserID;
        // MANAGE USERS
        public static string UserID;
        public static string UserType;

        public static string Firstname;
        public static string Lastname;
        public static string Middlename;
        public static string Gender;
        public static string Birthday;
        public static string Birthday_Value = "";
        public static string ContactNumber;
        public static string Address;

        public static string username;
        public static string password;

        // MANAGE INVENTORY
        public static string ProductCode;
        public static string ProductName;
        public static string ProductCategory;
        public static string ProductDescription;

        public static string ProductStock;
        public static string ProductStockStatus;
        public static string ProductCurrentPrice;

        public static string ProductImage;


        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void LOGOUT()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            cnn.Close();

            this.Hide();
            this.Parent = null;
            //e.Cancel = true;

            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is frmLogin);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void frmAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            LOGOUT();
        }

        private void txtbMU_Search_TextChanged(object sender, EventArgs e)
        {
            if (txtbU_Search.Text == "")
            {
                fill_Users();
                dgvUserAcc.ClearSelection();
            }
            dgvUserAcc.ClearSelection();

            if (cmbU_SearchBy.Text == "USER ID")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select UserID, UserType, ContactNumber,Gender from tbl_useraccounts where UserID != '" + lblUserID.Text + "' AND UserID LIKE '%" + txtbU_Search.Text + "%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUserAcc.DataSource = dt;
                dgvUserAcc.ClearSelection();
                cnn.Close();
            }
            if (cmbU_SearchBy.Text == "FIRST NAME")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select UserID, UserType, ContactNumber,Gender from tbl_useraccounts where UserID != '" + lblUserID.Text + "' AND Firstname LIKE '%" + txtbU_Search.Text + "%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUserAcc.DataSource = dt;
                dgvUserAcc.ClearSelection();
                cnn.Close();
            }
            if (cmbU_SearchBy.Text == "LAST NAME")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select UserID, UserType, ContactNumber,Gender from tbl_useraccounts where UserID != '" + lblUserID.Text + "' AND Lastname LIKE '%" + txtbU_Search.Text + "%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUserAcc.DataSource = dt;
                dgvUserAcc.ClearSelection();
                cnn.Close();
            }
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGOUT();
        }


        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblUserID.Text = lblUserID.Text;
            // Manage Users
            fill_Users();
            // Manage Inventory
            fill_Inventory();

            fillTransactions();

            this.ActiveControl = txtbU_Search;

            //Combo Boxes
            // Manage Users
            cmbU_SearchBy.Text = "Search By:";
            cmbU_FilterBy.Text = "Filter By:";

            // Manage Inventory
            cmbI_SearchBy.Text = "Search By:";
            cmbI_FilterBy.Text = "Filter By:";
        }
//MANAGE USER CODE
        private void cmbU_SearchBy_DropDown(object sender, EventArgs e)
        {
            if (cmbU_SearchBy.Items.Contains("Search by:"))
            {
                cmbU_SearchBy.Items.Remove("Search by:");
            }
        }

        private void cmbU_SearchBy_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbU_SearchBy.SelectedIndex > -1)
            {
                cmbU_SearchBy.SelectedIndex = cmbU_SearchBy.SelectedIndex;
            }
            else
            {
                if (!cmbU_SearchBy.Items.Contains("Search by:"))
                {
                    cmbU_SearchBy.Items.Add("Search by:");
                }

                cmbU_SearchBy.Text = "Search by:";
            }
        }

        private void cmbU_FilterBy_DropDown(object sender, EventArgs e)
        {
            if (cmbU_FilterBy.Items.Contains("Filter by:"))
            {
                cmbU_FilterBy.Items.Remove("Filter by:");
            }
        }

        private void cmbU_FilterBy_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbU_FilterBy.SelectedIndex > -1)
            {
                cmbU_FilterBy.SelectedIndex = cmbU_FilterBy.SelectedIndex;
            }
            else
            {
                if (!cmbU_FilterBy.Items.Contains("Filter by:"))
                {
                    cmbU_FilterBy.Items.Add("Filter by:");
                }

                cmbU_FilterBy.Text = "Filter by:";
            }
        }

        public void fill_Users()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query = "Select UserID, UserType, Fname, Mname, Lname,Birthdate from tbl_useraccounts WHERE UserID != '" + lblUserID.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUserAcc.DataSource = dt;


            cnn.Close();
        }

        private void MU_Clear()
        {
            txtbU_Search.Clear();

            lblMU_UserID_Answer.Text = "";
            lblMU_UserType_Answer.Text = "";
            lblMU_Fullname_Answer.Text = "";
            lblMU_Birthday_Answer.Text = "";
            lblGender.Text = "";
            lblMU_ContactNumber_Answer.Text = "";

            btnMU_Update.Enabled = false;
        }

        private void DGV_USER()
        {
            lblMU_UserID_Answer.Text = dgvUserAcc.CurrentRow.Cells[0].Value.ToString();
            lblMU_UserType_Answer.Text = dgvUserAcc.CurrentRow.Cells[1].Value.ToString();
            lblMU_ContactNumber_Answer.Text = dgvUserAcc.CurrentRow.Cells[3].Value.ToString();

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";

                string query2 = "Select Fname,Lname,Mname,Birthdate,ContactNumber,UserID,UserType,Gender,Address,Uname,Passwd FROM tbl_useraccounts where UserID = '" + lblMU_UserID_Answer.Text + "'";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                MySqlDataAdapter sda2 = new MySqlDataAdapter(query2, cnn);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                // USER INFORMATION
                lblMU_Fullname_Answer.Text = dt2.Rows[0][0].ToString() + " " + dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][1].ToString();
                lblMU_Birthday_Answer.Text = dt2.Rows[0][3].ToString();
                lblGender.Text = dt2.Rows[0][7].ToString();

                // STORE TO PUBLIC STRING
                UserID = dt2.Rows[0][5].ToString();
                UserType = dt2.Rows[0][6].ToString();

                Firstname = dt2.Rows[0][0].ToString();
                Lastname = dt2.Rows[0][1].ToString();
                Middlename = dt2.Rows[0][2].ToString();
                Birthday = dt2.Rows[0][3].ToString();
                Birthday_Value = dt2.Rows[0][3].ToString();
                Gender = dt2.Rows[0][7].ToString();
                ContactNumber = dt2.Rows[0][4].ToString();
                Address = dt2.Rows[0][8].ToString();

                username = dt2.Rows[0][9].ToString();
                password = dt2.Rows[0][10].ToString();

                cnn.Close();
            }
            catch (System.IndexOutOfRangeException)
            {

            }
        }

        private void dgvUserAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_USER();
            btnMU_Update.Enabled = true;
        }

        private void btnMU_Create_Click(object sender, EventArgs e)
        {
            frmUsers Create = new frmUsers();
            Create.ShowDialog();
        }

        private void btnMU_Update_Click(object sender, EventArgs e)
        {
            frmUsers Update = new frmUsers();

            Update.cmbUsertype.Text = UserType.ToString();
            Update.txtbUserID.Text = UserID.ToString();
            Update.cmbUsertype.Enabled = false;

            Update.txtbFirstname.Text = Firstname.ToString();
            Update.txtbLastname.Text = Lastname.ToString();
            Update.txtbMI.Text = Middlename.ToString();
            Update.cmbGender.Text = Gender.ToString();

            //Update.dtpBirthday.Value = Convert.ToDateTime(Birthday);
            Update.txtbPhone.Text = ContactNumber.ToString();
            Update.txtbAddress.Text = Address.ToString();

            Update.txtbUsername.Text = username.ToString();
            Update.txtbPassword.Text = password.ToString();
            Update.txtbConfirmpass.Text = password.ToString();

            Update.btnRegister.Text = "Save changes";
            Update.ShowDialog();
        }

        private void cmbU_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbU_SearchBy.Text == "USER ID" || cmbU_SearchBy.Text == "FIRST NAME" || cmbU_SearchBy.Text == "LAST NAME")
            {
                txtbU_Search.Enabled = true;
            }else
            {
                txtbU_Search.Enabled = false;
                cmbU_FilterBy.SelectedIndex = 0;
            }
            if (cmbU_SearchBy.Text == "USER ID")
            {
                cmbU_FilterBy.Text = "ALL";
                fill_Users();

                dgvUserAcc.ClearSelection();
            }
            if (cmbU_SearchBy.Text == "FIRST NAME")
            {
                cmbU_FilterBy.Text = "ALL";
                fill_Users();

                dgvUserAcc.ClearSelection();
            }
            if (cmbU_SearchBy.Text == "LAST NAME")
            {
                cmbU_FilterBy.Text = "ALL";
                fill_Users();

                dgvUserAcc.ClearSelection();
            }

            MU_Clear();
        }

        private void cmbU_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbU_FilterBy.Text == "Filter By:")
            {
                fill_Users();
                dgvUserAcc.ClearSelection();
            }
            if (cmbU_FilterBy.Text == "ALL")
            {
                fill_Users();
                dgvUserAcc.ClearSelection();
            }
            if (cmbU_FilterBy.Text == "ADMIN")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select UserID, UserType, ContactNumber,Gender from tbl_useraccounts where UserType = '" + "ADMIN" + "' AND UserID != '" + lblUserID.Text + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUserAcc.DataSource = dt;


                cnn.Close();
            }
            if (cmbU_FilterBy.Text == "CASHIER")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select UserID, UserType, ContactNumber,Gender from tbl_useraccounts where UserType = '" + "CASHIER" + "' AND UserID != '" + lblUserID.Text + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUserAcc.DataSource = dt;


                cnn.Close();
            }

            MU_Clear();
        }

//MANAGE INVENTORY
        private void cmbI_SearchBy_DropDown(object sender, EventArgs e)
        {
            if (cmbI_SearchBy.Items.Contains("Search By:"))
            {
                cmbI_SearchBy.Items.Remove("Search By:");
            }
        }

        private void cmbI_SearchBy_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbI_SearchBy.SelectedIndex > -1)
            {
                cmbI_SearchBy.SelectedIndex = cmbI_SearchBy.SelectedIndex;
            }
            else
            {
                if (!cmbI_SearchBy.Items.Contains("Search By:"))
                {
                    cmbI_SearchBy.Items.Add("Search By:");
                }

                cmbI_SearchBy.Text = "Search By:";
            }
        }

        private void cmbI_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbI_SearchBy.Text == "PRODUCT CODE" || cmbI_SearchBy.Text == "CATEGORY")
            {
                txtbI_Search.Enabled = true;
            }
            else
            {
                txtbI_Search.Enabled = false;
                cmbI_SearchBy.SelectedIndex = 0;
            }
            if (cmbI_SearchBy.Text == "PRODUCT CODE")
            {
                cmbI_FilterBy.Text = "ALL";
                fill_Inventory();

                dgvInventory.ClearSelection();
            }
            if (cmbI_SearchBy.Text == "CATEGORY")
            {
                cmbI_FilterBy.Text = "ALL";
                fill_Inventory();

                dgvInventory.ClearSelection();
            }

            MI_Clear();
        }
        private void cmbI_FilterBy_DropDown(object sender, EventArgs e)
        {
            if (cmbI_FilterBy.Items.Contains("Filter By:"))
            {
                cmbI_FilterBy.Items.Remove("Filter By:");
            }
        }

        private void cmbI_FilterBy_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbI_FilterBy.SelectedIndex > -1)
            {
                cmbI_FilterBy.SelectedIndex = cmbI_FilterBy.SelectedIndex;
            }
            else
            {
                if (!cmbI_FilterBy.Items.Contains("Filter By:"))
                {
                    cmbI_FilterBy.Items.Add("Filter By:");
                }

                cmbI_FilterBy.Text = "Filter By:";
            }
        }

        public void fill_Inventory()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query = "Select ProductCode, ProductName, ProductCategory, ProductStocks from tbl_inventory";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvInventory.DataSource = dt;


            cnn.Close();
        }

        private void btnI_Create_Click(object sender, EventArgs e)
        {
            frmInventory Add = new frmInventory();
            Add.ShowDialog();
        }

        private void MI_Clear()
        {
            txtbI_Search.Clear();

            pbProductImage.Image = Artisan_De_Fleur_Management_System.Properties.Resources.Logo1;

            lblI_ProductCode.Text = "";
            lblI_ProductName.Text = "";
            lblI_Stocks.Text = "";
            lblProductCategory.Text = "";
            lblI_Price.Text = "";
            txtb_Description.Text = "";

            btnMI_Update.Enabled = false;
        }

        private void DGV_MI()
        {
            // ITEM INFORMATION
            lblI_ProductCode.Text = dgvInventory.CurrentRow.Cells[0].Value.ToString();
            lblI_ProductName.Text = dgvInventory.CurrentRow.Cells[1].Value.ToString();
            lblProductCategory.Text = dgvInventory.CurrentRow.Cells[2].Value.ToString();
            lblI_Stocks.Text = dgvInventory.CurrentRow.Cells[3].Value.ToString();

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";

                string query2 = "Select ProductImage, ProductCode, ProductName, ProductCategory, ProductDescription, ProductStocks, ProductPrice FROM tbl_inventory where ProductCode = '" + lblI_ProductCode  .Text + "'";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                MySqlDataAdapter sda2 = new MySqlDataAdapter(query2, cnn);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                // ITEM INFORMATION
                lblI_ProductCode.Text = dt2.Rows[0][1].ToString();
                lblI_Price.Text = dt2.Rows[0][6].ToString();
                lblI_ProductName.Text = dt2.Rows[0][2].ToString();
                lblProductCategory.Text = dt2.Rows[0][3].ToString();
                txtb_Description.Text = dt2.Rows[0][4].ToString();
                lblI_Stocks.Text = dt2.Rows[0][5].ToString();
                if (Convert.ToInt32(dt2.Rows[0][5].ToString()) > 20)
                {
                    lblI_StockStatus.ForeColor = Color.DarkGreen;
                    lblI_StockStatus.Text = "ON STOCKS";
                }
                else if (Convert.ToInt32(dt2.Rows[0][5].ToString()) <= 20 && Convert.ToInt32(dt2.Rows[0][5].ToString()) > 0)
                {
                    lblI_StockStatus.ForeColor = Color.DarkOrange;
                    lblI_StockStatus.Text = "CRITICAL STOCKS";
                }
                else if (Convert.ToInt32(dt2.Rows[0][5].ToString()) == 0)
                {
                    lblI_StockStatus.ForeColor = Color.Red;
                    lblI_StockStatus.Text = "OUT OF STOCKS";
                }
                pbProductImage.ImageLocation = dt2.Rows[0][0].ToString().Replace("\\", "\\\\");

                if (dt2.Rows[0][0].ToString() == "")
                {
                    pbProductImage.Image = Artisan_De_Fleur_Management_System.Properties.Resources.Logo1;
                }

                // STORE TO PUBLIC STRING
                ProductCode = dt2.Rows[0][1].ToString();
                ProductName = dt2.Rows[0][2].ToString();
                ProductCategory = dt2.Rows[0][3].ToString();
                ProductDescription = dt2.Rows[0][4].ToString();
                ProductStock = dt2.Rows[0][5].ToString();
                if (Convert.ToInt32(ProductStock) > 20)
                {
                    ProductStockStatus = "ON STOCKS";
                }
                else if (Convert.ToInt32(ProductStock) <= 20 && Convert.ToInt32(ProductStock) > 0)
                {
                    ProductStockStatus = "CRITICAL STOCKS";
                }
                else if (Convert.ToInt32(ProductStock) == 0)
                {
                    ProductStockStatus = "OUT OF STOCKS";
                }
                ProductCurrentPrice = dt2.Rows[0][6].ToString();

                ProductImage = dt2.Rows[0][0].ToString();
                frmInventory.file_location = ProductImage;


                cnn.Close();
            }
            catch (System.IndexOutOfRangeException)
            {

            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_MI();
            btnMI_Update.Enabled = true;
        }

        private void btnMI_Update_Click(object sender, EventArgs e)
        {
            frmInventory Update = new frmInventory();

            int checkQuantity;
            checkQuantity = Convert.ToInt32(ProductStock);

            Update.txtbProductCode.Text = ProductCode.ToString();

            Update.nupQuantity.Value = checkQuantity;
            Update.txtbStatus.Text = ProductStockStatus.ToString();
            Update.txtbCurrentPrice.Text = ProductCurrentPrice.ToString();

            Update.txtbProductName.Text = ProductName.ToString();
            Update.txtbCategory.Text = ProductCategory.ToString();
            Update.txtbSummary.Text = ProductDescription.ToString();

            frmInventory.file_location = ProductImage;
            Update.pbImage.ImageLocation = frmInventory.file_location;


            if (checkQuantity < 5)
            {
                Update.txtbStatus.ForeColor = Color.DarkOrange;
            }
            else if (checkQuantity == 0)
            {
                Update.txtbStatus.ForeColor = Color.Red;
            }
            else
            {
                Update.txtbStatus.ForeColor = Color.DarkGreen;
            }

            Update.txtbProductCode.Enabled = false;

            Update.btnRegister.Text = "UPDATE PRODUCT";
            Update.ShowDialog();
        }

        private void cmbI_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbI_FilterBy.Text == "ALL")
            {
                fill_Inventory();
                dgvInventory.ClearSelection();
            }
            if (cmbI_FilterBy.Text == "ON STOCKS")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select ProductCode, ProductName, ProductCategory, ProductStocks from tbl_inventory where ProductStocks > 20";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInventory.DataSource = dt;


                cnn.Close();
            }
            if (cmbI_FilterBy.Text == "CRITICAL STOCKS")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select ProductCode, ProductName, ProductCategory, ProductStocks from tbl_inventory where ProductStocks <= 20 AND ProductStocks > 0";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInventory.DataSource = dt;


                cnn.Close();
            }
            if (cmbI_FilterBy.Text == "OUT OF STOCKS")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select ProductCode, ProductName, ProductCategory, ProductStocks from tbl_inventory where ProductStocks = 0";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInventory.DataSource = dt;


                cnn.Close();
            }

            MI_Clear();
        }

        //MANAGE TRANSACTIONS
        public void fillTransactions()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query = "Select ReferenceNum, ProductCode, ProductName, ProductTotal, BuyDate from tbl_transactions";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTransactions.DataSource = dt;


            cnn.Close();
        }

        private void txtbI_Search_TextChanged(object sender, EventArgs e)
        {
            if (txtbI_Search.Text == "")
            {
                fill_Inventory();
                dgvInventory.ClearSelection();
            }
            dgvInventory.ClearSelection();

            if (cmbI_SearchBy.Text == "PRODUCT CODE")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select  ProductCode, ProductName, ProductCategory, ProductStocks from tbl_inventory where ProductCode LIKE '%" + txtbI_Search.Text + "%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInventory.DataSource = dt;
                dgvInventory.ClearSelection();
                cnn.Close();
            }
            if (cmbI_SearchBy.Text == "CATEGORY")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select  ProductCode, ProductName, ProductCategory, ProductStocks from tbl_inventory where ProductCode LIKE '%" + txtbI_Search.Text + "%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInventory.DataSource = dt;
                dgvInventory.ClearSelection();
                cnn.Close();
            }
        }
    }

}
