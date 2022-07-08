namespace Artisan_De_Fleur_Management_System
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.label3 = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.lblNoItems = new System.Windows.Forms.Label();
            this.txtbChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbCashAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbTotalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTransNum = new System.Windows.Forms.Label();
            this.lvCart = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cashier Name:";
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.Location = new System.Drawing.Point(617, 101);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(109, 46);
            this.lblCashierName.TabIndex = 35;
            this.lblCashierName.Text = "Name";
            // 
            // lblNoItems
            // 
            this.lblNoItems.AutoSize = true;
            this.lblNoItems.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoItems.Location = new System.Drawing.Point(720, 43);
            this.lblNoItems.Name = "lblNoItems";
            this.lblNoItems.Size = new System.Drawing.Size(19, 24);
            this.lblNoItems.TabIndex = 34;
            this.lblNoItems.Text = "#";
            // 
            // txtbChange
            // 
            this.txtbChange.Enabled = false;
            this.txtbChange.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbChange.Location = new System.Drawing.Point(609, 360);
            this.txtbChange.Multiline = true;
            this.txtbChange.Name = "txtbChange";
            this.txtbChange.Size = new System.Drawing.Size(411, 51);
            this.txtbChange.TabIndex = 33;
            this.txtbChange.Text = "0.00";
            this.txtbChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Change:";
            // 
            // txtbCashAmount
            // 
            this.txtbCashAmount.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCashAmount.Location = new System.Drawing.Point(609, 271);
            this.txtbCashAmount.Multiline = true;
            this.txtbCashAmount.Name = "txtbCashAmount";
            this.txtbCashAmount.Size = new System.Drawing.Size(411, 51);
            this.txtbCashAmount.TabIndex = 31;
            this.txtbCashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbCashAmount.TextChanged += new System.EventHandler(this.txtbCashAmount_TextChanged);
            this.txtbCashAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCashAmount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cash Amount:";
            // 
            // txtbTotalAmount
            // 
            this.txtbTotalAmount.Enabled = false;
            this.txtbTotalAmount.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotalAmount.Location = new System.Drawing.Point(609, 182);
            this.txtbTotalAmount.Multiline = true;
            this.txtbTotalAmount.Name = "txtbTotalAmount";
            this.txtbTotalAmount.Size = new System.Drawing.Size(411, 51);
            this.txtbTotalAmount.TabIndex = 29;
            this.txtbTotalAmount.Text = "0.00";
            this.txtbTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "No. of items:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Transaction No.:";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(609, 431);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(411, 69);
            this.btnPayment.TabIndex = 25;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblTransNum
            // 
            this.lblTransNum.AutoSize = true;
            this.lblTransNum.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransNum.Location = new System.Drawing.Point(747, 10);
            this.lblTransNum.Name = "lblTransNum";
            this.lblTransNum.Size = new System.Drawing.Size(19, 24);
            this.lblTransNum.TabIndex = 24;
            this.lblTransNum.Text = "#";
            // 
            // lvCart
            // 
            this.lvCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCart.FullRowSelect = true;
            this.lvCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCart.Location = new System.Drawing.Point(12, 10);
            this.lvCart.MultiSelect = false;
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(585, 490);
            this.lvCart.TabIndex = 22;
            this.lvCart.TileSize = new System.Drawing.Size(10, 10);
            this.lvCart.UseCompatibleStateImageBehavior = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1032, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCashierName);
            this.Controls.Add(this.lblNoItems);
            this.Controls.Add(this.txtbChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbCashAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblTransNum);
            this.Controls.Add(this.lvCart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTISAN DE FLEUR | CASHIER";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblCashierName;
        public System.Windows.Forms.Label lblNoItems;
        public System.Windows.Forms.TextBox txtbChange;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtbCashAmount;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtbTotalAmount;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPayment;
        public System.Windows.Forms.Label lblTransNum;
        public System.Windows.Forms.ListView lvCart;
    }
}