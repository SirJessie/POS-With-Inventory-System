namespace Artisan_De_Fleur_Management_System
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.gbItemInformation = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtbCurrentPrice = new System.Windows.Forms.TextBox();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtbStatus = new System.Windows.Forms.TextBox();
            this.txtbCategory = new System.Windows.Forms.TextBox();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.txtbProductName = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtbSummary = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.txtbProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.gbItemImage = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRemoveIMG = new System.Windows.Forms.Button();
            this.btnBrowseIMG = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbItemInformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.gbItemImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbItemInformation
            // 
            this.gbItemInformation.Controls.Add(this.groupBox2);
            this.gbItemInformation.Controls.Add(this.txtbCategory);
            this.gbItemInformation.Controls.Add(this.lblYearPublished);
            this.gbItemInformation.Controls.Add(this.txtbProductName);
            this.gbItemInformation.Controls.Add(this.lblPublisher);
            this.gbItemInformation.Controls.Add(this.txtbSummary);
            this.gbItemInformation.Controls.Add(this.lblSummary);
            this.gbItemInformation.Controls.Add(this.txtbProductCode);
            this.gbItemInformation.Controls.Add(this.lblProductCode);
            this.gbItemInformation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItemInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gbItemInformation.Location = new System.Drawing.Point(12, 8);
            this.gbItemInformation.Name = "gbItemInformation";
            this.gbItemInformation.Size = new System.Drawing.Size(537, 421);
            this.gbItemInformation.TabIndex = 20;
            this.gbItemInformation.TabStop = false;
            this.gbItemInformation.Text = "ITEM INFORMATION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nupQuantity);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.txtbCurrentPrice);
            this.groupBox2.Controls.Add(this.lblCurrentPrice);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtbStatus);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox2.Location = new System.Drawing.Point(11, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 134);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ITEM STOCK INFORMATION";
            // 
            // nupQuantity
            // 
            this.nupQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupQuantity.Location = new System.Drawing.Point(286, 30);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(63, 26);
            this.nupQuantity.TabIndex = 1;
            this.nupQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblQuantity.Location = new System.Drawing.Point(100, 32);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(124, 20);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "STOCK QUANTITY:";
            // 
            // txtbCurrentPrice
            // 
            this.txtbCurrentPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbCurrentPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCurrentPrice.Location = new System.Drawing.Point(286, 94);
            this.txtbCurrentPrice.MaxLength = 255;
            this.txtbCurrentPrice.Name = "txtbCurrentPrice";
            this.txtbCurrentPrice.Size = new System.Drawing.Size(159, 26);
            this.txtbCurrentPrice.TabIndex = 2;
            this.txtbCurrentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCurrentPrice.Location = new System.Drawing.Point(109, 97);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(117, 20);
            this.lblCurrentPrice.TabIndex = 31;
            this.lblCurrentPrice.Text = "CURRENT PRICE:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStatus.Location = new System.Drawing.Point(118, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 20);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "STOCK STATUS:";
            // 
            // txtbStatus
            // 
            this.txtbStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbStatus.Location = new System.Drawing.Point(286, 62);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.ReadOnly = true;
            this.txtbStatus.Size = new System.Drawing.Size(159, 26);
            this.txtbStatus.TabIndex = 30;
            this.txtbStatus.TabStop = false;
            this.txtbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbCategory
            // 
            this.txtbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbCategory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCategory.Location = new System.Drawing.Point(170, 100);
            this.txtbCategory.MaxLength = 50;
            this.txtbCategory.Name = "txtbCategory";
            this.txtbCategory.Size = new System.Drawing.Size(344, 26);
            this.txtbCategory.TabIndex = 7;
            this.txtbCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearPublished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblYearPublished.Location = new System.Drawing.Point(7, 103);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(151, 20);
            this.lblYearPublished.TabIndex = 25;
            this.lblYearPublished.Text = "PRODUCT CATEGORY:";
            // 
            // txtbProductName
            // 
            this.txtbProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbProductName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbProductName.Location = new System.Drawing.Point(170, 62);
            this.txtbProductName.MaxLength = 255;
            this.txtbProductName.Name = "txtbProductName";
            this.txtbProductName.Size = new System.Drawing.Size(344, 26);
            this.txtbProductName.TabIndex = 6;
            this.txtbProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPublisher.Location = new System.Drawing.Point(7, 65);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(117, 20);
            this.lblPublisher.TabIndex = 23;
            this.lblPublisher.Text = "PRODUCT NAME:";
            // 
            // txtbSummary
            // 
            this.txtbSummary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbSummary.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSummary.Location = new System.Drawing.Point(170, 143);
            this.txtbSummary.MaxLength = 255;
            this.txtbSummary.Multiline = true;
            this.txtbSummary.Name = "txtbSummary";
            this.txtbSummary.Size = new System.Drawing.Size(344, 122);
            this.txtbSummary.TabIndex = 8;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSummary.Location = new System.Drawing.Point(7, 143);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(99, 20);
            this.lblSummary.TabIndex = 16;
            this.lblSummary.Text = "DESCRIPTION:";
            // 
            // txtbProductCode
            // 
            this.txtbProductCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbProductCode.Enabled = false;
            this.txtbProductCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbProductCode.Location = new System.Drawing.Point(139, 25);
            this.txtbProductCode.Name = "txtbProductCode";
            this.txtbProductCode.Size = new System.Drawing.Size(203, 26);
            this.txtbProductCode.TabIndex = 1;
            this.txtbProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblProductCode.Location = new System.Drawing.Point(7, 28);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(116, 20);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "PRODUCT CODE:";
            // 
            // gbItemImage
            // 
            this.gbItemImage.Controls.Add(this.btnRegister);
            this.gbItemImage.Controls.Add(this.btnRemoveIMG);
            this.gbItemImage.Controls.Add(this.btnBrowseIMG);
            this.gbItemImage.Controls.Add(this.pbImage);
            this.gbItemImage.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.gbItemImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gbItemImage.Location = new System.Drawing.Point(555, 17);
            this.gbItemImage.Name = "gbItemImage";
            this.gbItemImage.Size = new System.Drawing.Size(350, 412);
            this.gbItemImage.TabIndex = 21;
            this.gbItemImage.TabStop = false;
            this.gbItemImage.Text = "ITEM IMAGE";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegister.Location = new System.Drawing.Point(48, 335);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(249, 59);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "ADD PRODUCT";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRemoveIMG
            // 
            this.btnRemoveIMG.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemoveIMG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveIMG.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveIMG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveIMG.Location = new System.Drawing.Point(73, 272);
            this.btnRemoveIMG.Name = "btnRemoveIMG";
            this.btnRemoveIMG.Size = new System.Drawing.Size(200, 46);
            this.btnRemoveIMG.TabIndex = 10;
            this.btnRemoveIMG.Text = "Remove Photo";
            this.btnRemoveIMG.UseVisualStyleBackColor = false;
            this.btnRemoveIMG.Click += new System.EventHandler(this.btnRemoveIMG_Click);
            // 
            // btnBrowseIMG
            // 
            this.btnBrowseIMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBrowseIMG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseIMG.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrowseIMG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrowseIMG.Location = new System.Drawing.Point(73, 221);
            this.btnBrowseIMG.Name = "btnBrowseIMG";
            this.btnBrowseIMG.Size = new System.Drawing.Size(200, 45);
            this.btnBrowseIMG.TabIndex = 9;
            this.btnBrowseIMG.Text = "Browse Image";
            this.btnBrowseIMG.UseVisualStyleBackColor = false;
            this.btnBrowseIMG.Click += new System.EventHandler(this.btnBrowseIMG_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Image = global::Artisan_De_Fleur_Management_System.Properties.Resources.Logo1;
            this.pbImage.Location = new System.Drawing.Point(73, 25);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 192);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(914, 441);
            this.Controls.Add(this.gbItemImage);
            this.Controls.Add(this.gbItemInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTISAN DE FLEUR | ADMIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventory_FormClosing);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.gbItemInformation.ResumeLayout(false);
            this.gbItemInformation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.gbItemImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItemInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.TextBox txtbCurrentPrice;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtbStatus;
        public System.Windows.Forms.TextBox txtbCategory;
        private System.Windows.Forms.Label lblYearPublished;
        public System.Windows.Forms.TextBox txtbProductName;
        private System.Windows.Forms.Label lblPublisher;
        public System.Windows.Forms.TextBox txtbSummary;
        private System.Windows.Forms.Label lblSummary;
        public System.Windows.Forms.TextBox txtbProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.GroupBox gbItemImage;
        public System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRemoveIMG;
        private System.Windows.Forms.Button btnBrowseIMG;
        public System.Windows.Forms.PictureBox pbImage;
    }
}