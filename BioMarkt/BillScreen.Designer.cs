namespace BioMarkt
{
    partial class BillScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.cmbProductCategoryBills = new System.Windows.Forms.ComboBox();
            this.txtBillsAmount = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnBillSave = new System.Windows.Forms.Button();
            this.btnBillEdit = new System.Windows.Forms.Button();
            this.btnBillClear = new System.Windows.Forms.Button();
            this.btnBillDelete = new System.Windows.Forms.Button();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.ForeColor = System.Drawing.Color.White;
            this.lblProductCategory.Location = new System.Drawing.Point(44, 61);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(109, 13);
            this.lblProductCategory.TabIndex = 1;
            this.lblProductCategory.Text = "Produkt Kategorie";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(44, 88);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(45, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Menge";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(44, 117);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(90, 13);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Gesamt Betrag";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCustomer.ForeColor = System.Drawing.Color.White;
            this.txtCustomer.Location = new System.Drawing.Point(173, 34);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(156, 20);
            this.txtCustomer.TabIndex = 4;
            // 
            // cmbProductCategoryBills
            // 
            this.cmbProductCategoryBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cmbProductCategoryBills.ForeColor = System.Drawing.Color.White;
            this.cmbProductCategoryBills.FormattingEnabled = true;
            this.cmbProductCategoryBills.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.cmbProductCategoryBills.Location = new System.Drawing.Point(173, 60);
            this.cmbProductCategoryBills.Name = "cmbProductCategoryBills";
            this.cmbProductCategoryBills.Size = new System.Drawing.Size(121, 21);
            this.cmbProductCategoryBills.TabIndex = 5;
            // 
            // txtBillsAmount
            // 
            this.txtBillsAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBillsAmount.ForeColor = System.Drawing.Color.White;
            this.txtBillsAmount.Location = new System.Drawing.Point(173, 88);
            this.txtBillsAmount.Name = "txtBillsAmount";
            this.txtBillsAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBillsAmount.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(173, 117);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 7;
            // 
            // btnBillSave
            // 
            this.btnBillSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillSave.ForeColor = System.Drawing.Color.White;
            this.btnBillSave.Location = new System.Drawing.Point(16, 183);
            this.btnBillSave.Name = "btnBillSave";
            this.btnBillSave.Size = new System.Drawing.Size(75, 23);
            this.btnBillSave.TabIndex = 8;
            this.btnBillSave.Text = "Speichern";
            this.btnBillSave.UseVisualStyleBackColor = false;
            this.btnBillSave.Click += new System.EventHandler(this.btnBillSave_Click);
            // 
            // btnBillEdit
            // 
            this.btnBillEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillEdit.ForeColor = System.Drawing.Color.White;
            this.btnBillEdit.Location = new System.Drawing.Point(97, 183);
            this.btnBillEdit.Name = "btnBillEdit";
            this.btnBillEdit.Size = new System.Drawing.Size(83, 23);
            this.btnBillEdit.TabIndex = 9;
            this.btnBillEdit.Text = "Bearbeiten";
            this.btnBillEdit.UseVisualStyleBackColor = false;
            this.btnBillEdit.Click += new System.EventHandler(this.btnBillEdit_Click);
            // 
            // btnBillClear
            // 
            this.btnBillClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillClear.ForeColor = System.Drawing.Color.White;
            this.btnBillClear.Location = new System.Drawing.Point(186, 183);
            this.btnBillClear.Name = "btnBillClear";
            this.btnBillClear.Size = new System.Drawing.Size(108, 23);
            this.btnBillClear.TabIndex = 10;
            this.btnBillClear.Text = "Felder Leeren";
            this.btnBillClear.UseVisualStyleBackColor = false;
            this.btnBillClear.Click += new System.EventHandler(this.btnBillClear_Click);
            // 
            // btnBillDelete
            // 
            this.btnBillDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillDelete.ForeColor = System.Drawing.Color.White;
            this.btnBillDelete.Location = new System.Drawing.Point(300, 183);
            this.btnBillDelete.Name = "btnBillDelete";
            this.btnBillDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBillDelete.TabIndex = 11;
            this.btnBillDelete.Text = "Löschen";
            this.btnBillDelete.UseVisualStyleBackColor = false;
            this.btnBillDelete.Click += new System.EventHandler(this.btnBillDelete_Click);
            // 
            // BillsDGV
            // 
            this.BillsDGV.AllowUserToAddRows = false;
            this.BillsDGV.AllowUserToDeleteRows = false;
            this.BillsDGV.AllowUserToOrderColumns = true;
            this.BillsDGV.AllowUserToResizeColumns = false;
            this.BillsDGV.AllowUserToResizeRows = false;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.BillsDGV.Location = new System.Drawing.Point(12, 212);
            this.BillsDGV.MultiSelect = false;
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.RowTemplate.ReadOnly = true;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(774, 229);
            this.BillsDGV.TabIndex = 12;
            this.BillsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellClick);
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BillsDGV);
            this.Controls.Add(this.btnBillDelete);
            this.Controls.Add(this.btnBillClear);
            this.Controls.Add(this.btnBillEdit);
            this.Controls.Add(this.btnBillSave);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtBillsAmount);
            this.Controls.Add(this.cmbProductCategoryBills);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillScreen";
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ComboBox cmbProductCategoryBills;
        private System.Windows.Forms.TextBox txtBillsAmount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnBillSave;
        private System.Windows.Forms.Button btnBillEdit;
        private System.Windows.Forms.Button btnBillClear;
        private System.Windows.Forms.Button btnBillDelete;
        private System.Windows.Forms.DataGridView BillsDGV;
    }
}