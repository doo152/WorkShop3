namespace Workshop3
{
    partial class Main
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
            this.Commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datPackages = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnProdNew = new System.Windows.Forms.Button();
            this.btnProdEdit = new System.Windows.Forms.Button();
            this.datProduct = new System.Windows.Forms.DataGridView();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuppCombo = new System.Windows.Forms.ComboBox();
            this.ProdCombo = new System.Windows.Forms.ComboBox();
            this.btnPSAdd = new System.Windows.Forms.Button();
            this.btnPSUpdate = new System.Windows.Forms.Button();
            this.btnPSDelete = new System.Windows.Forms.Button();
            this.PSdataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datPackages)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datProduct)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Commission
            // 
            this.Commission.HeaderText = "Commission";
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // pkgName
            // 
            this.pkgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pkgName.HeaderText = "Name";
            this.pkgName.Name = "pkgName";
            this.pkgName.ReadOnly = true;
            // 
            // datPackages
            // 
            this.datPackages.AllowUserToAddRows = false;
            this.datPackages.AllowUserToResizeRows = false;
            this.datPackages.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkgName,
            this.StartDate,
            this.EndDate,
            this.Description,
            this.Price,
            this.Commission});
            this.datPackages.Location = new System.Drawing.Point(16, 8);
            this.datPackages.MultiSelect = false;
            this.datPackages.Name = "datPackages";
            this.datPackages.ReadOnly = true;
            this.datPackages.RowHeadersVisible = false;
            this.datPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datPackages.Size = new System.Drawing.Size(614, 363);
            this.datPackages.TabIndex = 0;
            this.datPackages.DoubleClick += new System.EventHandler(this.datPackages_DoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(656, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(656, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(656, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(752, 408);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datPackages);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtProdName);
            this.tabPage2.Controls.Add(this.btnProdNew);
            this.tabPage2.Controls.Add(this.btnProdEdit);
            this.tabPage2.Controls.Add(this.datProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(27, 220);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 9;
            // 
            // btnProdNew
            // 
            this.btnProdNew.Location = new System.Drawing.Point(151, 234);
            this.btnProdNew.Name = "btnProdNew";
            this.btnProdNew.Size = new System.Drawing.Size(75, 23);
            this.btnProdNew.TabIndex = 7;
            this.btnProdNew.Text = "Add New";
            this.btnProdNew.UseVisualStyleBackColor = true;
            this.btnProdNew.Click += new System.EventHandler(this.btnProdNew_Click);
            // 
            // btnProdEdit
            // 
            this.btnProdEdit.Location = new System.Drawing.Point(151, 205);
            this.btnProdEdit.Name = "btnProdEdit";
            this.btnProdEdit.Size = new System.Drawing.Size(75, 23);
            this.btnProdEdit.TabIndex = 6;
            this.btnProdEdit.Text = "Edit";
            this.btnProdEdit.UseVisualStyleBackColor = true;
            this.btnProdEdit.Click += new System.EventHandler(this.btnProdEdit_Click);
            // 
            // datProduct
            // 
            this.datProduct.AllowUserToAddRows = false;
            this.datProduct.AllowUserToDeleteRows = false;
            this.datProduct.AllowUserToResizeColumns = false;
            this.datProduct.AllowUserToResizeRows = false;
            this.datProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdName});
            this.datProduct.Location = new System.Drawing.Point(27, 30);
            this.datProduct.Name = "datProduct";
            this.datProduct.ReadOnly = true;
            this.datProduct.RowHeadersVisible = false;
            this.datProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datProduct.Size = new System.Drawing.Size(240, 150);
            this.datProduct.TabIndex = 5;
            this.datProduct.SelectionChanged += new System.EventHandler(this.datProduct_SelectionChanged);
            // 
            // colProdName
            // 
            this.colProdName.HeaderText = "Product Name";
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suppliers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.IDBox);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.SuppCombo);
            this.tabPage4.Controls.Add(this.ProdCombo);
            this.tabPage4.Controls.Add(this.btnPSAdd);
            this.tabPage4.Controls.Add(this.btnPSUpdate);
            this.tabPage4.Controls.Add(this.btnPSDelete);
            this.tabPage4.Controls.Add(this.PSdataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(744, 382);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Products & Suppliers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(569, 82);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(123, 20);
            this.IDBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name";
            // 
            // SuppCombo
            // 
            this.SuppCombo.FormattingEnabled = true;
            this.SuppCombo.Location = new System.Drawing.Point(569, 190);
            this.SuppCombo.Name = "SuppCombo";
            this.SuppCombo.Size = new System.Drawing.Size(152, 21);
            this.SuppCombo.TabIndex = 9;
            // 
            // ProdCombo
            // 
            this.ProdCombo.FormattingEnabled = true;
            this.ProdCombo.Location = new System.Drawing.Point(569, 138);
            this.ProdCombo.Name = "ProdCombo";
            this.ProdCombo.Size = new System.Drawing.Size(123, 21);
            this.ProdCombo.TabIndex = 10;
            // 
            // btnPSAdd
            // 
            this.btnPSAdd.Location = new System.Drawing.Point(451, 278);
            this.btnPSAdd.Name = "btnPSAdd";
            this.btnPSAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPSAdd.TabIndex = 5;
            this.btnPSAdd.Text = "Add";
            this.btnPSAdd.UseVisualStyleBackColor = true;
            this.btnPSAdd.Click += new System.EventHandler(this.btnPSAdd_Click);
            // 
            // btnPSUpdate
            // 
            this.btnPSUpdate.Location = new System.Drawing.Point(554, 278);
            this.btnPSUpdate.Name = "btnPSUpdate";
            this.btnPSUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnPSUpdate.TabIndex = 6;
            this.btnPSUpdate.Text = "Edit";
            this.btnPSUpdate.UseVisualStyleBackColor = true;
            this.btnPSUpdate.Click += new System.EventHandler(this.btnPSUpdate_Click);
            // 
            // btnPSDelete
            // 
            this.btnPSDelete.Location = new System.Drawing.Point(652, 278);
            this.btnPSDelete.Name = "btnPSDelete";
            this.btnPSDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPSDelete.TabIndex = 7;
            this.btnPSDelete.Text = "Delete";
            this.btnPSDelete.UseVisualStyleBackColor = true;
            this.btnPSDelete.Click += new System.EventHandler(this.btnPSDelete_Click);
            // 
            // PSdataGridView
            // 
            this.PSdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PSdataGridView.Location = new System.Drawing.Point(6, 32);
            this.PSdataGridView.Name = "PSdataGridView";
            this.PSdataGridView.RowHeadersVisible = false;
            this.PSdataGridView.Size = new System.Drawing.Size(424, 299);
            this.PSdataGridView.TabIndex = 4;
            this.PSdataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PSdataGridView_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product-Suppliers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ProductSupplierID";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 417);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "PackagesDisplay";
            this.Activated += new System.EventHandler(this.PackagesDisplay_Activated);
            this.Load += new System.EventHandler(this.PackagesDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datPackages)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datProduct)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Commission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgName;
        private System.Windows.Forms.DataGridView datPackages;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnProdNew;
        private System.Windows.Forms.Button btnProdEdit;
        private System.Windows.Forms.DataGridView datProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SuppCombo;
        private System.Windows.Forms.ComboBox ProdCombo;
        private System.Windows.Forms.Button btnPSAdd;
        private System.Windows.Forms.Button btnPSUpdate;
        private System.Windows.Forms.Button btnPSDelete;
        private System.Windows.Forms.DataGridView PSdataGridView;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}