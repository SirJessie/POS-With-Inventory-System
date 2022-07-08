using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Artisan_De_Fleur_Management_System
{
    public partial class frmInventory : Form
    {
        public static string file_location = "";

        OpenFileDialog browseImage = new OpenFileDialog();

        public frmInventory()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            if(btnRegister.Text == "ADD PRODUCT")
            {
                ProductID();
            }
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            file_location = "";

            frmAdminDashboard obj = (frmAdminDashboard)Application.OpenForms["frmAdminDashboard"];
            obj.fill_Inventory();
            obj.cmbI_FilterBy.Text = "ALL";

            if (obj.cmbI_SearchBy.Text == "Search by:")
            {
                obj.cmbI_FilterBy.Text = "Filter by:";
            }

            obj.dgvInventory.Update();
            obj.dgvInventory.Refresh();

            obj.lblI_ProductCode.Text = "";
            obj.lblI_ProductName.Text = "";
            obj.lblI_Stocks.Text = "";
            obj.lblI_Price.Text = "";
            obj.lblI_StockStatus.Text = "";
            obj.txtb_Description.Text = "";
            obj.lblProductCategory.Text = "";

            obj.btnMI_Update.Enabled = false;
        }

        private void btnBrowseIMG_Click(object sender, EventArgs e)
        {
            browseImage.Title = "SELECT IMAGES";
            browseImage.Filter = "Images File (*.BMP;*.JPG;*.PNG;*.GIF) | *.BMP;*.JPG;*.PNG;*.GIF";

            if (browseImage.ShowDialog() == DialogResult.OK)
            {
                string newFileName = browseImage.FileName.Replace("\\", "\\\\");

                file_location = newFileName.ToString();
                pbImage.ImageLocation = newFileName.ToString();
            }
        }

        private void btnRemoveIMG_Click(object sender, EventArgs e)
        {
            pbImage.ImageLocation = null;
            pbImage.Image = Artisan_De_Fleur_Management_System.Properties.Resources.Logo1;
            pbImage.Update();
            file_location = "";
        }

        private void ProductID()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string dtID = DateTime.Now.ToString("yyyy");
            string query = "Select max(ID) as ID from tbl_inventory";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (!reader.HasRows || Convert.IsDBNull(reader["ID"]))
            {
                txtbProductCode.Text = "P" + dtID + "10001";
            }
            else
            {
                int newID = (int)reader.GetInt32("ID");
                newID += 1;
                txtbProductCode.Text = "P" + dtID + newID.ToString("10000");
            }

            reader.Close();
            cnn.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string checkProductCode = "";
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=artisandefleurdb;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }

            string query2 = "Select ProductCode FROM tbl_inventory where ProductCode = '" + txtbProductCode.Text + "'";

            try
            {
                MySqlDataAdapter sda2 = new MySqlDataAdapter(query2, cnn);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                checkProductCode = dt2.Rows[0][0].ToString();


            }
            catch (System.IndexOutOfRangeException)
            {

            }

            if (btnRegister.Text == "ADD PRODUCT")
            {
                if (checkProductCode.ToString() == txtbProductCode.Text)
                {
                    MessageBox.Show("Product Code already exist.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    try
                    {
                        if (!Directory.Exists(@"C:\Artisan De Fleur\Resources\Products"))
                        {
                            Directory.CreateDirectory(@"C:\Artisan De Fleur\Resources\Products");
                            MessageBox.Show("Images Folder Created...");
                        }
                        else
                        {
                            string path = @"C:\Artisan De Fleur\Resources\Products";
                            pbImage.Image.Save(path + @"\" + txtbProductCode.Text + ".jpg", ImageFormat.Jpeg);

                            if (txtbProductCode.Text.Trim() == "")
                            {
                                pbImage.Image = Artisan_De_Fleur_Management_System.Properties.Resources.Logo1;
                            }
                            else
                            {
                                string filePath = path + @"\" + txtbProductCode.Text + ".jpg";

                                string newFileName = filePath.Replace("\\", "\\\\");

                                pbImage.ImageLocation = newFileName.ToString();
                                file_location = newFileName.ToString();
                            }
                        }

                        int myIntValue = (int)nupQuantity.Value;

                        string query = "INSERT into tbl_inventory(ProductImage, ProductCode, ProductName, ProductCategory, ProductDescription, ProductStocks, ProductPrice) Values('" + file_location.ToString().Replace("\\", "\\\\") + "', '" + txtbProductCode.Text + "', '" + txtbProductName.Text + "', '" + txtbCategory.Text + "', '" + txtbSummary.Text.Replace("'", "") + "', '" + myIntValue.ToString() + "', '" + txtbCurrentPrice.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();

                        cnn.Close();

                        MessageBox.Show("Saved successfully.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }

                try
                {
                    if (!Directory.Exists(@"C:\Artisan De Fleur\Resources\Products"))
                    {
                        Directory.CreateDirectory(@"C:\Artisan De Fleur\Resources\Products");
                        MessageBox.Show("Images Folder Created...");
                    }
                    else
                    {
                        string path = @"C:\Artisan De Fleur\Resources\Products";
                        pbImage.Image.Save(path + @"\" + txtbProductCode.Text + ".jpg", ImageFormat.Jpeg);

                        if (txtbProductCode.Text.Trim() == "")
                        {
                            pbImage.Image = Artisan_De_Fleur_Management_System.Properties.Resources.Logo1;
                        }
                        else
                        {
                            string filePath = path + @"\" + txtbProductCode.Text + ".jpg";

                            string newFileName = filePath.Replace("\\", "\\\\");

                            pbImage.ImageLocation = newFileName.ToString();
                            file_location = newFileName.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                int myIntValue = (int)nupQuantity.Value;

                string query = "UPDATE tbl_inventory SET ProductName = '" + txtbProductName.Text.Trim() + "', ProductCategory = '" + txtbCategory.Text.Trim() + "', ProductDescription = '" + txtbSummary.Text.Replace("'", "") + "', ProductStocks = '" + myIntValue.ToString() + "', ProductPrice = '" + txtbCurrentPrice.Text + "', ProductImage = '" + file_location.ToString().Replace("\\", "\\\\") + "' WHERE ProductCode = '" + txtbProductCode.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();
                this.Close();

                MessageBox.Show("Updated successfully.", "Artisan De Fleur Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
