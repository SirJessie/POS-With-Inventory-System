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
    public partial class frmPOS : Form
    {
        //Public variables
        DialogResult dialogResult;
        public static string Barcode;

        public static string ProductCode;
        public static string ProductName;
        public static string ProductCategory;

        public static string ProductStock;
        public static string ProductPrice;

        public static string buyDate;
        public static int transacNum;
        public static int transaction = 0;
        public static int num;

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


        public frmPOS()
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

            transaction = 0;

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

        private void frmPOS_Load(object sender, EventArgs e)
        {
            txtbSearch.Focus();
            cmbFilterBy.SelectedIndex = 0;

            lvCart.Columns.Add("#", 30);
            lvCart.Columns.Add("Product Code", 100);
            lvCart.Columns.Add("Name", 160);
            lvCart.Columns.Add("Qty", 50);
            lvCart.Columns.Add("Price", 80);
            lvCart.Columns.Add("Amount", 80);

            //Load items
            LoadProducts();
        }

        private void LoadProducts()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query = "Select ProductCode, ProductName, ProductStocks, ProductPrice from tbl_inventory";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItems.DataSource = dt;


            cnn.Close();
        }

        public void fillCart()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query = "Select ProductCode, ProductName, ProductQty, ProductPrice, ProductTotal from tbl_transactions Where ReferenceNum = '" + lblTransnum.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            num = 0;
            lvCart.Items.Clear();

            while (reader.Read())
            {
                num++;
                ListViewItem items = new ListViewItem(num.ToString());
                items.SubItems.Add(reader.GetString(0));
                items.SubItems.Add(reader.GetString(1));
                items.SubItems.Add(reader.GetInt32(2).ToString());
                items.SubItems.Add(reader.GetDouble(3).ToString());
                items.SubItems.Add(reader.GetDouble(4).ToString());
                lvCart.Items.Add(items);
            }

            reader.Close();

            cnn.Close();
        }

        //fill ascending
        public void fill_Ascending()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query = "Select ProductCode, ProductName, ProductStocks, ProductPrice from tbl_inventory ORDER BY ID ASC";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItems.DataSource = dt;
            dgvItems.ClearSelection();
            cnn.Close();
        }

        //fill descending
        public void fill_Descending()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query = "Select ProductCode, ProductName, ProductStocks, ProductPrice from tbl_inventory ORDER BY ID DESC";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItems.DataSource = dt;
            dgvItems.ClearSelection();
            cnn.Close();
        }

        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductCode = dgvItems.CurrentRow.Cells[0].Value.ToString();
                ProductName = dgvItems.CurrentRow.Cells[1].Value.ToString();
                ProductStock = dgvItems.CurrentRow.Cells[2].Value.ToString();
                ProductPrice = dgvItems.CurrentRow.Cells[3].Value.ToString();
                nupQty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewTransaction()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }


            string query = "Select * from tbl_transactions order by ID desc limit 1";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                transacNum = reader.GetInt32(2);
                buyDate = reader.GetString(8).ToString();
            }
            reader.Close();

            cnn.Close();


            if (buyDate != DateTime.Today.ToString("yyyy-MM-dd"))
            {
                transacNum = 1000;
            }

            transacNum++;

            lblTransnum.Text = DateTime.Today.ToString("yyyyMMd") + transacNum;
        }

        private void AddToCart()
        {
            try
            {
                if (lblTransnum.Text != "000000000")
                {
                    if (nupQty.Value > 0)
                    {
                        int currentStock = 0, newStock;
                        int qty = Convert.ToInt32(nupQty.Value);
                        double amount = Convert.ToDouble(ProductPrice) * qty;
                        double currentTotal = Convert.ToDouble(lblTotalAmount.Text);

                        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                        MySqlConnection cnn = new MySqlConnection(connectionString);

                        if (cnn.State != ConnectionState.Open)
                        {
                            cnn.Open();
                        }

                        //Item in cart
                        string item_exist = "SELECT * FROM tbl_transactions WHERE ProductCode = '" + ProductCode + "' AND ReferenceNum = '" + lblTransnum.Text + "'";
                        MySqlCommand cmd_exist = new MySqlCommand(item_exist, cnn);
                        MySqlDataReader reader_exist = cmd_exist.ExecuteReader();

                        if (reader_exist.Read() != true)
                        {
                            reader_exist.Close();


                            //Get current stock
                            string query = "Select * from tbl_inventory where ProductCode = '" + ProductCode + "'";
                            MySqlCommand cmd_stock = new MySqlCommand(query, cnn);
                            MySqlDataReader reader_stock = cmd_stock.ExecuteReader();

                            while (reader_stock.Read())
                            {
                                currentStock = reader_stock.GetInt32(6);
                            }
                            if (qty <= currentStock)
                            {
                                reader_stock.Close();

                                newStock = currentStock - qty;

                                //Add to cart
                                string add_to_cart = "INSERT into tbl_transactions (ReferenceNum, TransactionNum, BuyDate, ProductCode, ProductName, ProductQty, ProductPrice, ProductTotal) Values('" + lblTransnum.Text + "', '" + transacNum + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "', '" + ProductCode + "', '" + ProductName + "', '" + qty + "', '" + ProductPrice + "', '" + amount + "')";
                                MySqlCommand cmd_add = new MySqlCommand(add_to_cart, cnn);
                                cmd_add.ExecuteNonQuery();

                                //Remove stock
                                string remove_stock = "UPDATE tbl_inventory SET ProductStocks = '" + newStock + "' WHERE ProductCode = '" + ProductCode + "'";
                                MySqlCommand cmd_rmv_stock = new MySqlCommand(remove_stock, cnn);
                                cmd_rmv_stock.ExecuteNonQuery();

                                cnn.Close();

                                MessageBox.Show("Item added to cart.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                double total_amount = currentTotal + amount;

                                lblTotalAmount.Text = Math.Round(total_amount, 2).ToString("N");
                                //fill cart
                                fillCart();

                                //fill items
                                LoadProducts();


                            }
                            else
                            {
                                MessageBox.Show("Insufficient stock!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (currentStock <= 20 && currentStock > 0)
                                {
                                    MessageBox.Show("CRITICAL STOCKS", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (currentStock == 0)
                                {
                                    MessageBox.Show("OUT OF STOCKS", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }



                        }
                        else
                        {
                            MessageBox.Show("Item exist to cart. You can't add twice, but you can update your item in cart!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                        nupQty.Value = 0;

                        txtbSearch.Focus();


                    }
                    else
                    {
                        MessageBox.Show("Choose quantity");
                    }
                }
                else
                {
                    nupQty.Value = 0;
                    MessageBox.Show("Add transaction first!");

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (transaction == 0)
            {
                NewTransaction();
                AddToCart();
                btnEdit.Enabled = true;
                transaction = 1;
            }
            else
            {
                AddToCart();
                
            }
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "ASCENDING")
            {
                fill_Ascending();
            }
            else if (cmbFilterBy.Text == "DESCENDING")
            {
                fill_Descending();
            }
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtbSearch.Text == "" || txtbSearch.Text == "Search...")
                {
                    LoadProducts();
                    dgvItems.ClearSelection();
                }
                else
                {
                    //Search all
                    if (cmbFilterBy.Text == "ASCENDING")
                    {
                        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                        MySqlConnection cnn = new MySqlConnection(connectionString);

                        if (cnn.State != ConnectionState.Open)
                        {
                            cnn.Open();
                        }

                        string query = "Select ProductCode, ProductName, ProductStocks, ProductPrice from tbl_inventory where CONCAT(ProductCode, ProductName, ProductStocks, ProductPrice) LIKE '%" + txtbSearch.Text + "%' ORDER BY ID ASC";
                        MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvItems.DataSource = dt;
                        dgvItems.ClearSelection();
                        cnn.Close();
                    }

                    //Search Active Item
                    else if (cmbFilterBy.Text == "DESCENDING")
                    {
                        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                        MySqlConnection cnn = new MySqlConnection(connectionString);

                        if (cnn.State != ConnectionState.Open)
                        {
                            cnn.Open();
                        }

                        string query = "Select ProductCode, ProductName, ProductStocks, ProductPrice from tbl_inventory where CONCAT(ProductCode, ProductName, ProductStocks, ProductPrice) LIKE '%" + txtbSearch.Text + "%' ORDER BY ID DESC";
                        MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvItems.DataSource = dt;
                        dgvItems.ClearSelection();
                        cnn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbSearch_MouseEnter(object sender, EventArgs e)
        {
            txtbSearch.CharacterCasing = CharacterCasing.Normal;
            txtbSearch.Text = "Search...";
        }

        private void txtbSearch_Click(object sender, EventArgs e)
        {
            txtbSearch.Text = "";
            txtbSearch.ForeColor = Color.Black;
            txtbSearch.CharacterCasing = CharacterCasing.Upper;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "Edit")
                {

                    btnEdit.Text = "Save";
                    btnAdd.Enabled = false;
                    btnVoid.Enabled = false;
                    btnCheckout.Enabled = false;
                    dgvItems.Enabled = false;
                    lvCart.Focus();
                }
                else if (btnEdit.Text == "Save")
                {
                    if (lvCart.SelectedItems.Count > 0)
                    {
                        int currentStock = 0, newStock;

                        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                        MySqlConnection cnn = new MySqlConnection(connectionString);

                        if (cnn.State != ConnectionState.Open)
                        {
                            cnn.Open();
                        }

                        if (nupQty.Value > 0)
                        {
                            //Get current stock
                            string query = "Select * from tbl_inventory where ProductCode = '" + ProductCode + "'";
                            MySqlCommand cmd_stock = new MySqlCommand(query, cnn);
                            MySqlDataReader reader_stock = cmd_stock.ExecuteReader();

                            while (reader_stock.Read())
                            {
                                currentStock = reader_stock.GetInt32(6);
                            }

                            reader_stock.Close();

                            newStock = currentStock + Convert.ToInt32(ProductStock);

                            lblTotalAmount.Text = Math.Round(Convert.ToDouble(lblTotalAmount.Text) - (Convert.ToDouble(ProductPrice) * Convert.ToInt32(ProductStock)), 2).ToString("N");

                            //Retrieve stock in inventory
                            string retrieve_stock = "UPDATE tbl_inventory SET ProductStocks = '" + newStock + "' WHERE ProductCode = '" + ProductCode + "'";
                            MySqlCommand retrieve_cmd = new MySqlCommand(retrieve_stock, cnn);
                            retrieve_cmd.ExecuteNonQuery();

                            currentStock = 0;
                            newStock = 0;

                            //Get new stock in inventory
                            string new_stock = "Select * from tbl_inventory where ProductCode = '" + ProductCode + "'";
                            MySqlCommand cmd_new = new MySqlCommand(new_stock, cnn);
                            MySqlDataReader reader_new = cmd_new.ExecuteReader();

                            while (reader_new.Read())
                            {
                                currentStock = reader_new.GetInt32(6);
                            }

                            int qty = Convert.ToInt32(nupQty.Value);
                            double amount = Convert.ToDouble(ProductPrice);

                            if (qty < currentStock)
                            {
                                reader_new.Close();

                                newStock = currentStock - qty;
                                double total = Convert.ToDouble(lblTotalAmount.Text) + (amount * qty);
                                double lvAmount = amount * qty;

                                lblTotalAmount.Text = Math.Round(total, 2).ToString("N");

                                //Subtract stock in inventory
                                string subtract_stock = "UPDATE tbl_inventory SET ProductStocks = '" + newStock + "' WHERE ProductCode = '" + ProductCode + "'";
                                MySqlCommand subtract_cmd = new MySqlCommand(subtract_stock, cnn);
                                subtract_cmd.ExecuteNonQuery();

                                //Update stock in cart
                                string update_qty = "UPDATE tbl_transactions SET ProductQty = '" + nupQty.Value + "', ProductTotal = '" + lvAmount + "' WHERE ProductCode = '" + ProductCode + "' AND BuyDate = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'";
                                MySqlCommand update_cmd = new MySqlCommand(update_qty, cnn);
                                update_cmd.ExecuteNonQuery();

                                cnn.Close();

                                //fill items
                                LoadProducts();

                                //fill cart
                                fillCart();

                                btnEdit.Text = "Edit";
                                btnAdd.Enabled = true;
                                btnVoid.Enabled = true;
                                btnCheckout.Enabled = true;
                                nupQty.Value = 0;
                                dgvItems.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Insufficient stock!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (currentStock <= 20 && currentStock > 0)
                                {
                                    MessageBox.Show("CRITICAL STOCKS", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (currentStock == 0)
                                {
                                    MessageBox.Show("OUT OF STOCKS", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Choose quantity", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select item you want to edit!");
                        btnEdit.Text = "Edit";
                        btnAdd.Enabled = true;
                    }

                }
            }catch (Exception)
            {
                MessageBox.Show("Select item you want to edit!");
                btnEdit.Text = "Edit";
                btnAdd.Enabled = true;
            }
        }

        private void lvCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProductCode = lvCart.SelectedItems[0].SubItems[1].Text;
                ProductName = lvCart.SelectedItems[0].SubItems[2].Text;
                ProductStock = lvCart.SelectedItems[0].SubItems[3].Text;
                ProductPrice = lvCart.SelectedItems[0].SubItems[4].Text;

                if (btnEdit.Text == "Save")
                {
                    nupQty.Focus();

                    nupQty.Value = Convert.ToInt32(ProductStock);

                }


            }
            catch (Exception)
            {
            }
        }

        private void nupQty_ValueChanged(object sender, EventArgs e)
        {
            if (nupQty.Value <= 0)
            {
                nupQty.Value = 1;
            }
            if (nupQty.Text.Trim() == "")
            {
                nupQty.Value = 1;
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if(lvCart.SelectedItems.Count > 0)
            {
                try
                {
                    int currentStock = 0, newStock;
                    int qty = Convert.ToInt32(ProductStock);
                    double amount = Convert.ToDouble(ProductPrice) * qty;
                    double currentTotal = Convert.ToDouble(lblTotalAmount.Text);

                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                    MySqlConnection cnn = new MySqlConnection(connectionString);

                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Artisan De Fleur Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //Get current stock
                        string query = "Select * from tbl_inventory where ProductCode = '" + ProductCode + "'";
                        MySqlCommand cmd_stock = new MySqlCommand(query, cnn);
                        MySqlDataReader reader_stock = cmd_stock.ExecuteReader();

                        while (reader_stock.Read())
                        {
                            currentStock = reader_stock.GetInt32(6);
                        }

                        newStock = currentStock + qty;

                        reader_stock.Close();

                        //Add the voided stock
                        string add_stock = "UPDATE tbl_inventory SET ProductStocks = '" + newStock + "' WHERE ProductCode = '" + ProductCode + "'";
                        MySqlCommand cmd_add_stock = new MySqlCommand(add_stock, cnn);
                        cmd_add_stock.ExecuteNonQuery();

                        //Delete from cart
                        string void_item = "Delete from tbl_transactions where ProductCode = '" + ProductCode + "' AND  ReferenceNum = '" + lblTransnum.Text + "' AND BuyDate = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'";
                        MySqlCommand cmd_void = new MySqlCommand(void_item, cnn);
                        cmd_void.ExecuteNonQuery();

                        MessageBox.Show("Item removed from cart!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        double total_amount = currentTotal - amount;

                        lblTotalAmount.Text = Math.Round(total_amount, 2).ToString("N");

                        //fill the cart
                        fillCart();

                        //fill the items
                        LoadProducts();

                        if(lvCart.Items.Count > 0)
                        {
                            btnEdit.Enabled = false;
                            btnEdit.Text = "Edit";
                            btnAdd.Enabled = true;
                        }

                    }

                    cnn.Close();

                    ProductCode = "";
                    ProductName = "";
                    ProductStock = "";
                    ProductPrice = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Select item you want to remove!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select item you want to remove!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(lvCart.Items.Count != 0)
            {
                num = 0;

                //fill cart form payment
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
                MySqlConnection cnn = new MySqlConnection(connectionString);

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                string query = "Select ProductCode, ProductName, ProductQty, ProductPrice, ProductTotal from tbl_transactions where BuyDate = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' AND ReferenceNum = '" + lblTransnum.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();

                transaction = 0;

                frmPayment frmPayment = new frmPayment();


                frmPayment.lvCart.Items.Clear();

                while (reader.Read())
                {
                    num++;
                    ListViewItem items = new ListViewItem(num.ToString());
                    items.SubItems.Add(reader.GetString(0));
                    items.SubItems.Add(reader.GetString(1));
                    items.SubItems.Add(reader.GetInt32(2).ToString());
                    items.SubItems.Add(reader.GetDouble(3).ToString());
                    items.SubItems.Add(reader.GetDouble(4).ToString());
                    frmPayment.lvCart.Items.Add(items);
                }

                frmPayment.lblNoItems.Text = num + " item(s)";
                double total = Convert.ToDouble(lblTotalAmount.Text);
                frmPayment.txtbTotalAmount.Text = Math.Round(total, 2).ToString("N");
                frmPayment.lblCashierName.Text = lblUser.Text;

                reader.Close();

                cnn.Close();


                //transaction number in payment
                frmPayment.lblTransNum.Text = lblTransnum.Text;

                //listview payment columns
                frmPayment.lvCart.View = View.Details;
                frmPayment.lvCart.Columns.Add("#", 30);
                frmPayment.lvCart.Columns.Add("ProductCode", 200);
                frmPayment.lvCart.Columns.Add("Name", 300);
                frmPayment.lvCart.Columns.Add("Qty", 100);
                frmPayment.lvCart.Columns.Add("Price", 140);
                frmPayment.lvCart.Columns.Add("Amount", 140);

                lvCart.Items.Clear();
                lblTotalAmount.Text = "0.00";
                nupQty.Value = 0;
                lblTransnum.Text = "000000000";
                frmPayment.Visible = true;
                btnEdit.Enabled = false;
            }else
            {
                MessageBox.Show("Your cart is empty!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTransnum.Text = "000000000";
            }
            
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogResult = MessageBox.Show("Are you sure you want to logout?", "Artisan De Fleur Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (lblTransnum.Text != "000000000")
            {
                MessageBox.Show("Cannot logout! End the transaction first!", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dialogResult == DialogResult.Yes)
                {
                    LOGOUT();
                }
            }
        }
    }

}