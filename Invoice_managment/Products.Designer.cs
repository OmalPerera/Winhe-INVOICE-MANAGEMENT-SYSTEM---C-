namespace Invoice_managment
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.P_TxtB_searchKeyword = new System.Windows.Forms.TextBox();
            this.P_Btn_Search = new System.Windows.Forms.Button();
            this.P_Btn_home = new System.Windows.Forms.Button();
            this.P_DataGridView = new System.Windows.Forms.DataGridView();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Btn_Delete = new System.Windows.Forms.Button();
            this.P_Btn_edit = new System.Windows.Forms.Button();
            this.P_Btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.P_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // P_TxtB_searchKeyword
            // 
            this.P_TxtB_searchKeyword.Location = new System.Drawing.Point(185, 31);
            this.P_TxtB_searchKeyword.Name = "P_TxtB_searchKeyword";
            this.P_TxtB_searchKeyword.Size = new System.Drawing.Size(420, 22);
            this.P_TxtB_searchKeyword.TabIndex = 0;
            this.P_TxtB_searchKeyword.Text = "   I\'m looking for...";
            this.P_TxtB_searchKeyword.TextChanged += new System.EventHandler(this.P_TxtB_searchKeyword_TextChanged);
            // 
            // P_Btn_Search
            // 
            this.P_Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.P_Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.P_Btn_Search.FlatAppearance.BorderSize = 0;
            this.P_Btn_Search.ForeColor = System.Drawing.Color.White;
            this.P_Btn_Search.Location = new System.Drawing.Point(636, 27);
            this.P_Btn_Search.Name = "P_Btn_Search";
            this.P_Btn_Search.Size = new System.Drawing.Size(90, 31);
            this.P_Btn_Search.TabIndex = 1;
            this.P_Btn_Search.Text = "Search";
            this.P_Btn_Search.UseVisualStyleBackColor = false;
            this.P_Btn_Search.Click += new System.EventHandler(this.P_Btn_Search_Click);
            // 
            // P_Btn_home
            // 
            this.P_Btn_home.Location = new System.Drawing.Point(35, 31);
            this.P_Btn_home.Name = "P_Btn_home";
            this.P_Btn_home.Size = new System.Drawing.Size(59, 21);
            this.P_Btn_home.TabIndex = 2;
            this.P_Btn_home.Text = "Home";
            this.P_Btn_home.UseVisualStyleBackColor = true;
            this.P_Btn_home.Click += new System.EventHandler(this.P_Btn_home_Click);
            // 
            // P_DataGridView
            // 
            this.P_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.P_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Product_Description,
            this.Purchase_Date,
            this.Selling_Price,
            this.Quantity});
            this.P_DataGridView.Location = new System.Drawing.Point(34, 75);
            this.P_DataGridView.Name = "P_DataGridView";
            this.P_DataGridView.Size = new System.Drawing.Size(721, 219);
            this.P_DataGridView.TabIndex = 3;
            this.P_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.P_DataGridView_CellContentClick);
            // 
            // Product_ID
            // 
            this.Product_ID.Frozen = true;
            this.Product_ID.HeaderText = "ID";
            this.Product_ID.Name = "Product_ID";
            // 
            // Product_Name
            // 
            this.Product_Name.Frozen = true;
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Width = 150;
            // 
            // Product_Description
            // 
            this.Product_Description.Frozen = true;
            this.Product_Description.HeaderText = "Description";
            this.Product_Description.MinimumWidth = 7;
            this.Product_Description.Name = "Product_Description";
            this.Product_Description.Width = 150;
            // 
            // Purchase_Date
            // 
            this.Purchase_Date.Frozen = true;
            this.Purchase_Date.HeaderText = "Purchase Date";
            this.Purchase_Date.Name = "Purchase_Date";
            // 
            // Selling_Price
            // 
            this.Selling_Price.Frozen = true;
            this.Selling_Price.HeaderText = "Selling Price";
            this.Selling_Price.Name = "Selling_Price";
            // 
            // Quantity
            // 
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // P_Btn_Delete
            // 
            this.P_Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.P_Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.P_Btn_Delete.Location = new System.Drawing.Point(636, 310);
            this.P_Btn_Delete.Name = "P_Btn_Delete";
            this.P_Btn_Delete.Size = new System.Drawing.Size(115, 31);
            this.P_Btn_Delete.TabIndex = 4;
            this.P_Btn_Delete.Text = "Delete Product";
            this.P_Btn_Delete.UseVisualStyleBackColor = false;
            this.P_Btn_Delete.Click += new System.EventHandler(this.P_Btn_Delete_Click);
            // 
            // P_Btn_edit
            // 
            this.P_Btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.P_Btn_edit.ForeColor = System.Drawing.Color.White;
            this.P_Btn_edit.Location = new System.Drawing.Point(490, 310);
            this.P_Btn_edit.Name = "P_Btn_edit";
            this.P_Btn_edit.Size = new System.Drawing.Size(115, 31);
            this.P_Btn_edit.TabIndex = 5;
            this.P_Btn_edit.Text = "Edit Product";
            this.P_Btn_edit.UseVisualStyleBackColor = false;
            this.P_Btn_edit.Click += new System.EventHandler(this.P_Btn_edit_Click);
            // 
            // P_Btn_add
            // 
            this.P_Btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.P_Btn_add.ForeColor = System.Drawing.Color.White;
            this.P_Btn_add.Location = new System.Drawing.Point(337, 310);
            this.P_Btn_add.Name = "P_Btn_add";
            this.P_Btn_add.Size = new System.Drawing.Size(115, 31);
            this.P_Btn_add.TabIndex = 6;
            this.P_Btn_add.Text = "Add Product";
            this.P_Btn_add.UseVisualStyleBackColor = false;
            this.P_Btn_add.Click += new System.EventHandler(this.P_Btn_add_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.P_Btn_add);
            this.Controls.Add(this.P_Btn_edit);
            this.Controls.Add(this.P_Btn_Delete);
            this.Controls.Add(this.P_DataGridView);
            this.Controls.Add(this.P_Btn_home);
            this.Controls.Add(this.P_Btn_Search);
            this.Controls.Add(this.P_TxtB_searchKeyword);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.P_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox P_TxtB_searchKeyword;
        private System.Windows.Forms.Button P_Btn_Search;
        private System.Windows.Forms.Button P_Btn_home;
        private System.Windows.Forms.DataGridView P_DataGridView;
        private System.Windows.Forms.Button P_Btn_Delete;
        private System.Windows.Forms.Button P_Btn_edit;
        private System.Windows.Forms.Button P_Btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}