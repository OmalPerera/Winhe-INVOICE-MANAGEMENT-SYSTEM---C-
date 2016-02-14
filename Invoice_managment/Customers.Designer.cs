namespace Invoice_managment
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.Cus_Btn_AddCustomer = new System.Windows.Forms.Button();
            this.Cus_DataGridView = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cusomer_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_Btn_home = new System.Windows.Forms.Button();
            this.Cus_Btn_Search = new System.Windows.Forms.Button();
            this.Cus_TxtB_searchKeyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cus_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Cus_Btn_AddCustomer
            // 
            this.Cus_Btn_AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.Cus_Btn_AddCustomer.ForeColor = System.Drawing.Color.White;
            this.Cus_Btn_AddCustomer.Location = new System.Drawing.Point(634, 306);
            this.Cus_Btn_AddCustomer.Name = "Cus_Btn_AddCustomer";
            this.Cus_Btn_AddCustomer.Size = new System.Drawing.Size(115, 31);
            this.Cus_Btn_AddCustomer.TabIndex = 9;
            this.Cus_Btn_AddCustomer.Text = "Add Customer";
            this.Cus_Btn_AddCustomer.UseVisualStyleBackColor = false;
            this.Cus_Btn_AddCustomer.Click += new System.EventHandler(this.Cus_Btn_AddCustomer_Click);
            // 
            // Cus_DataGridView
            // 
            this.Cus_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Cus_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cus_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Customer_Name,
            this.Cusomer_Email,
            this.Address,
            this.contact_Number,
            this.date_Of_Birth,
            this.gender});
            this.Cus_DataGridView.Location = new System.Drawing.Point(32, 71);
            this.Cus_DataGridView.Name = "Cus_DataGridView";
            this.Cus_DataGridView.Size = new System.Drawing.Size(721, 219);
            this.Cus_DataGridView.TabIndex = 8;
            // 
            // Customer_ID
            // 
            this.Customer_ID.Frozen = true;
            this.Customer_ID.HeaderText = "ID";
            this.Customer_ID.Name = "Customer_ID";
            // 
            // Customer_Name
            // 
            this.Customer_Name.Frozen = true;
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.Name = "Customer_Name";
            // 
            // Cusomer_Email
            // 
            this.Cusomer_Email.Frozen = true;
            this.Cusomer_Email.HeaderText = "Email";
            this.Cusomer_Email.Name = "Cusomer_Email";
            // 
            // Address
            // 
            this.Address.Frozen = true;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // contact_Number
            // 
            this.contact_Number.Frozen = true;
            this.contact_Number.HeaderText = "Contact Number";
            this.contact_Number.Name = "contact_Number";
            // 
            // date_Of_Birth
            // 
            this.date_Of_Birth.Frozen = true;
            this.date_Of_Birth.HeaderText = "Date Of Birth";
            this.date_Of_Birth.Name = "date_Of_Birth";
            // 
            // gender
            // 
            this.gender.Frozen = true;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // Cus_Btn_home
            // 
            this.Cus_Btn_home.Location = new System.Drawing.Point(33, 27);
            this.Cus_Btn_home.Name = "Cus_Btn_home";
            this.Cus_Btn_home.Size = new System.Drawing.Size(59, 21);
            this.Cus_Btn_home.TabIndex = 7;
            this.Cus_Btn_home.Text = "Home";
            this.Cus_Btn_home.UseVisualStyleBackColor = true;
            this.Cus_Btn_home.Click += new System.EventHandler(this.Cus_Btn_home_Click);
            // 
            // Cus_Btn_Search
            // 
            this.Cus_Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.Cus_Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.Cus_Btn_Search.FlatAppearance.BorderSize = 0;
            this.Cus_Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Cus_Btn_Search.Location = new System.Drawing.Point(634, 23);
            this.Cus_Btn_Search.Name = "Cus_Btn_Search";
            this.Cus_Btn_Search.Size = new System.Drawing.Size(90, 31);
            this.Cus_Btn_Search.TabIndex = 6;
            this.Cus_Btn_Search.Text = "Search";
            this.Cus_Btn_Search.UseVisualStyleBackColor = false;
            // 
            // Cus_TxtB_searchKeyword
            // 
            this.Cus_TxtB_searchKeyword.Location = new System.Drawing.Point(183, 27);
            this.Cus_TxtB_searchKeyword.Name = "Cus_TxtB_searchKeyword";
            this.Cus_TxtB_searchKeyword.Size = new System.Drawing.Size(420, 20);
            this.Cus_TxtB_searchKeyword.TabIndex = 5;
            this.Cus_TxtB_searchKeyword.Text = "    Search for a Customer ...";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Cus_Btn_AddCustomer);
            this.Controls.Add(this.Cus_DataGridView);
            this.Controls.Add(this.Cus_Btn_home);
            this.Controls.Add(this.Cus_Btn_Search);
            this.Controls.Add(this.Cus_TxtB_searchKeyword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.Cus_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cus_Btn_AddCustomer;
        private System.Windows.Forms.DataGridView Cus_DataGridView;
        private System.Windows.Forms.Button Cus_Btn_home;
        private System.Windows.Forms.Button Cus_Btn_Search;
        private System.Windows.Forms.TextBox Cus_TxtB_searchKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cusomer_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;

    }
}