namespace Workshop3
{
    partial class PackagesDisplay
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
            this.datPackages = new System.Windows.Forms.DataGridView();
            this.pkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datPackages)).BeginInit();
            this.SuspendLayout();
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
            this.datPackages.Location = new System.Drawing.Point(16, 16);
            this.datPackages.MultiSelect = false;
            this.datPackages.Name = "datPackages";
            this.datPackages.ReadOnly = true;
            this.datPackages.RowHeadersVisible = false;
            this.datPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datPackages.Size = new System.Drawing.Size(614, 363);
            this.datPackages.TabIndex = 0;
            this.datPackages.DoubleClick += new System.EventHandler(this.datPackages_DoubleClick);
            // 
            // pkgName
            // 
            this.pkgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pkgName.HeaderText = "Name";
            this.pkgName.Name = "pkgName";
            this.pkgName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Commission
            // 
            this.Commission.HeaderText = "Commission";
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(656, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(656, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(656, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PackagesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 395);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.datPackages);
            this.Name = "PackagesDisplay";
            this.Text = "PackagesDisplay";
            this.Activated += new System.EventHandler(this.PackagesDisplay_Activated);
            this.Load += new System.EventHandler(this.PackagesDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commission;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}