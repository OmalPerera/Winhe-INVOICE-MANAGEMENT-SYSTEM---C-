namespace Invoice_managment
{
    partial class InvoiceGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceGenerator));
            this.IG_DataGridView = new System.Windows.Forms.DataGridView();
            this.IG_Btn_home = new System.Windows.Forms.Button();
            this.IG_Btn_Search = new System.Windows.Forms.Button();
            this.IG_TxtB_searchKeyword = new System.Windows.Forms.TextBox();
            this.IG_lbl_title = new System.Windows.Forms.Label();
            this.IG_Btn_ViewAllInvoice = new System.Windows.Forms.Button();
            this.IG_Lbl_productIdOfSelected = new System.Windows.Forms.Label();
            this.IG_lbl_productNameOfSelectedItem = new System.Windows.Forms.Label();
            this.IG_lbl_qty = new System.Windows.Forms.Label();
            this.IG_lbl_addToInvoice = new System.Windows.Forms.Button();
            this.IG_TxtB_Qty = new System.Windows.Forms.TextBox();
            this.IG_dataGridView_Invoice = new System.Windows.Forms.DataGridView();
            this.IG_TxtB_Total = new System.Windows.Forms.TextBox();
            this.IG_lbl_Total = new System.Windows.Forms.Label();
            this.IG_TxtB_Discount = new System.Windows.Forms.TextBox();
            this.IG_lbl_Discount = new System.Windows.Forms.Label();
            this.IG_TxtB_TotalPrice = new System.Windows.Forms.TextBox();
            this.IG_lbl_TotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IG_lbl_CustomerName = new System.Windows.Forms.Label();
            this.IG_Btn_SearchCustomer = new System.Windows.Forms.Button();
            this.IG_Btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IG_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IG_dataGridView_Invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // IG_DataGridView
            // 
            this.IG_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.IG_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IG_DataGridView.Location = new System.Drawing.Point(32, 132);
            this.IG_DataGridView.Name = "IG_DataGridView";
            this.IG_DataGridView.Size = new System.Drawing.Size(721, 122);
            this.IG_DataGridView.TabIndex = 12;
            // 
            // IG_Btn_home
            // 
            this.IG_Btn_home.Location = new System.Drawing.Point(32, 39);
            this.IG_Btn_home.Name = "IG_Btn_home";
            this.IG_Btn_home.Size = new System.Drawing.Size(59, 21);
            this.IG_Btn_home.TabIndex = 11;
            this.IG_Btn_home.Text = "Home";
            this.IG_Btn_home.UseVisualStyleBackColor = true;
            this.IG_Btn_home.Click += new System.EventHandler(this.IG_Btn_home_Click);
            // 
            // IG_Btn_Search
            // 
            this.IG_Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_Search.FlatAppearance.BorderSize = 0;
            this.IG_Btn_Search.ForeColor = System.Drawing.Color.White;
            this.IG_Btn_Search.Location = new System.Drawing.Point(479, 95);
            this.IG_Btn_Search.Name = "IG_Btn_Search";
            this.IG_Btn_Search.Size = new System.Drawing.Size(90, 31);
            this.IG_Btn_Search.TabIndex = 10;
            this.IG_Btn_Search.Text = "Search";
            this.IG_Btn_Search.UseVisualStyleBackColor = false;
            // 
            // IG_TxtB_searchKeyword
            // 
            this.IG_TxtB_searchKeyword.Location = new System.Drawing.Point(32, 99);
            this.IG_TxtB_searchKeyword.Name = "IG_TxtB_searchKeyword";
            this.IG_TxtB_searchKeyword.Size = new System.Drawing.Size(420, 20);
            this.IG_TxtB_searchKeyword.TabIndex = 9;
            this.IG_TxtB_searchKeyword.Text = "   Which item do you want ... ?";
            // 
            // IG_lbl_title
            // 
            this.IG_lbl_title.AutoSize = true;
            this.IG_lbl_title.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IG_lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_lbl_title.Location = new System.Drawing.Point(480, 18);
            this.IG_lbl_title.Name = "IG_lbl_title";
            this.IG_lbl_title.Size = new System.Drawing.Size(272, 46);
            this.IG_lbl_title.TabIndex = 20;
            this.IG_lbl_title.Text = "Generate Invoice";
            // 
            // IG_Btn_ViewAllInvoice
            // 
            this.IG_Btn_ViewAllInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_ViewAllInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_ViewAllInvoice.FlatAppearance.BorderSize = 0;
            this.IG_Btn_ViewAllInvoice.ForeColor = System.Drawing.Color.White;
            this.IG_Btn_ViewAllInvoice.Location = new System.Drawing.Point(111, 34);
            this.IG_Btn_ViewAllInvoice.Name = "IG_Btn_ViewAllInvoice";
            this.IG_Btn_ViewAllInvoice.Size = new System.Drawing.Size(108, 31);
            this.IG_Btn_ViewAllInvoice.TabIndex = 21;
            this.IG_Btn_ViewAllInvoice.Text = "View All Invoices";
            this.IG_Btn_ViewAllInvoice.UseVisualStyleBackColor = false;
            // 
            // IG_Lbl_productIdOfSelected
            // 
            this.IG_Lbl_productIdOfSelected.AutoSize = true;
            this.IG_Lbl_productIdOfSelected.Location = new System.Drawing.Point(29, 269);
            this.IG_Lbl_productIdOfSelected.Name = "IG_Lbl_productIdOfSelected";
            this.IG_Lbl_productIdOfSelected.Size = new System.Drawing.Size(64, 13);
            this.IG_Lbl_productIdOfSelected.TabIndex = 22;
            this.IG_Lbl_productIdOfSelected.Text = "Product ID :";
            // 
            // IG_lbl_productNameOfSelectedItem
            // 
            this.IG_lbl_productNameOfSelectedItem.AutoSize = true;
            this.IG_lbl_productNameOfSelectedItem.Location = new System.Drawing.Point(195, 269);
            this.IG_lbl_productNameOfSelectedItem.Name = "IG_lbl_productNameOfSelectedItem";
            this.IG_lbl_productNameOfSelectedItem.Size = new System.Drawing.Size(81, 13);
            this.IG_lbl_productNameOfSelectedItem.TabIndex = 23;
            this.IG_lbl_productNameOfSelectedItem.Text = "Product Name :";
            // 
            // IG_lbl_qty
            // 
            this.IG_lbl_qty.AutoSize = true;
            this.IG_lbl_qty.Location = new System.Drawing.Point(483, 269);
            this.IG_lbl_qty.Name = "IG_lbl_qty";
            this.IG_lbl_qty.Size = new System.Drawing.Size(23, 13);
            this.IG_lbl_qty.TabIndex = 24;
            this.IG_lbl_qty.Text = "Qty";
            // 
            // IG_lbl_addToInvoice
            // 
            this.IG_lbl_addToInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_lbl_addToInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_lbl_addToInvoice.FlatAppearance.BorderSize = 0;
            this.IG_lbl_addToInvoice.ForeColor = System.Drawing.Color.White;
            this.IG_lbl_addToInvoice.Location = new System.Drawing.Point(645, 260);
            this.IG_lbl_addToInvoice.Name = "IG_lbl_addToInvoice";
            this.IG_lbl_addToInvoice.Size = new System.Drawing.Size(108, 31);
            this.IG_lbl_addToInvoice.TabIndex = 25;
            this.IG_lbl_addToInvoice.Text = "Add to Invoice";
            this.IG_lbl_addToInvoice.UseVisualStyleBackColor = false;
            // 
            // IG_TxtB_Qty
            // 
            this.IG_TxtB_Qty.Location = new System.Drawing.Point(522, 266);
            this.IG_TxtB_Qty.Name = "IG_TxtB_Qty";
            this.IG_TxtB_Qty.Size = new System.Drawing.Size(47, 20);
            this.IG_TxtB_Qty.TabIndex = 26;
            this.IG_TxtB_Qty.Text = "1";
            this.IG_TxtB_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IG_dataGridView_Invoice
            // 
            this.IG_dataGridView_Invoice.BackgroundColor = System.Drawing.Color.White;
            this.IG_dataGridView_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IG_dataGridView_Invoice.Location = new System.Drawing.Point(32, 372);
            this.IG_dataGridView_Invoice.Name = "IG_dataGridView_Invoice";
            this.IG_dataGridView_Invoice.Size = new System.Drawing.Size(721, 122);
            this.IG_dataGridView_Invoice.TabIndex = 27;
            // 
            // IG_TxtB_Total
            // 
            this.IG_TxtB_Total.Location = new System.Drawing.Point(344, 500);
            this.IG_TxtB_Total.Name = "IG_TxtB_Total";
            this.IG_TxtB_Total.Size = new System.Drawing.Size(47, 20);
            this.IG_TxtB_Total.TabIndex = 29;
            this.IG_TxtB_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IG_TxtB_Total.TextChanged += new System.EventHandler(this.IG_TxtB_Total_TextChanged);
            // 
            // IG_lbl_Total
            // 
            this.IG_lbl_Total.AutoSize = true;
            this.IG_lbl_Total.Location = new System.Drawing.Point(305, 503);
            this.IG_lbl_Total.Name = "IG_lbl_Total";
            this.IG_lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.IG_lbl_Total.TabIndex = 28;
            this.IG_lbl_Total.Text = "Total";
            this.IG_lbl_Total.Click += new System.EventHandler(this.IG_lbl_Total_Click);
            // 
            // IG_TxtB_Discount
            // 
            this.IG_TxtB_Discount.Location = new System.Drawing.Point(500, 500);
            this.IG_TxtB_Discount.Name = "IG_TxtB_Discount";
            this.IG_TxtB_Discount.Size = new System.Drawing.Size(69, 20);
            this.IG_TxtB_Discount.TabIndex = 31;
            this.IG_TxtB_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IG_TxtB_Discount.TextChanged += new System.EventHandler(this.IG_TxtB_Discount_TextChanged);
            // 
            // IG_lbl_Discount
            // 
            this.IG_lbl_Discount.AutoSize = true;
            this.IG_lbl_Discount.Location = new System.Drawing.Point(445, 503);
            this.IG_lbl_Discount.Name = "IG_lbl_Discount";
            this.IG_lbl_Discount.Size = new System.Drawing.Size(49, 13);
            this.IG_lbl_Discount.TabIndex = 30;
            this.IG_lbl_Discount.Text = "Discount";
            this.IG_lbl_Discount.Click += new System.EventHandler(this.IG_lbl_Discount_Click);
            // 
            // IG_TxtB_TotalPrice
            // 
            this.IG_TxtB_TotalPrice.Location = new System.Drawing.Point(680, 500);
            this.IG_TxtB_TotalPrice.Name = "IG_TxtB_TotalPrice";
            this.IG_TxtB_TotalPrice.Size = new System.Drawing.Size(73, 20);
            this.IG_TxtB_TotalPrice.TabIndex = 33;
            this.IG_TxtB_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IG_lbl_TotalPrice
            // 
            this.IG_lbl_TotalPrice.AutoSize = true;
            this.IG_lbl_TotalPrice.Location = new System.Drawing.Point(619, 503);
            this.IG_lbl_TotalPrice.Name = "IG_lbl_TotalPrice";
            this.IG_lbl_TotalPrice.Size = new System.Drawing.Size(58, 13);
            this.IG_lbl_TotalPrice.TabIndex = 32;
            this.IG_lbl_TotalPrice.Text = "Total Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Customer : ";
            // 
            // IG_lbl_CustomerName
            // 
            this.IG_lbl_CustomerName.AutoSize = true;
            this.IG_lbl_CustomerName.Location = new System.Drawing.Point(95, 563);
            this.IG_lbl_CustomerName.Name = "IG_lbl_CustomerName";
            this.IG_lbl_CustomerName.Size = new System.Drawing.Size(0, 13);
            this.IG_lbl_CustomerName.TabIndex = 35;
            // 
            // IG_Btn_SearchCustomer
            // 
            this.IG_Btn_SearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_SearchCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_SearchCustomer.FlatAppearance.BorderSize = 0;
            this.IG_Btn_SearchCustomer.ForeColor = System.Drawing.Color.White;
            this.IG_Btn_SearchCustomer.Location = new System.Drawing.Point(259, 554);
            this.IG_Btn_SearchCustomer.Name = "IG_Btn_SearchCustomer";
            this.IG_Btn_SearchCustomer.Size = new System.Drawing.Size(105, 25);
            this.IG_Btn_SearchCustomer.TabIndex = 36;
            this.IG_Btn_SearchCustomer.Text = "Search Customer";
            this.IG_Btn_SearchCustomer.UseVisualStyleBackColor = false;
            // 
            // IG_Btn_Print
            // 
            this.IG_Btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_Print.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.IG_Btn_Print.FlatAppearance.BorderSize = 0;
            this.IG_Btn_Print.ForeColor = System.Drawing.Color.White;
            this.IG_Btn_Print.Location = new System.Drawing.Point(662, 551);
            this.IG_Btn_Print.Name = "IG_Btn_Print";
            this.IG_Btn_Print.Size = new System.Drawing.Size(90, 31);
            this.IG_Btn_Print.TabIndex = 37;
            this.IG_Btn_Print.Text = "Print";
            this.IG_Btn_Print.UseVisualStyleBackColor = false;
            this.IG_Btn_Print.Click += new System.EventHandler(this.IG_Btn_Print_Click);
            // 
            // InvoiceGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 605);
            this.Controls.Add(this.IG_Btn_Print);
            this.Controls.Add(this.IG_Btn_SearchCustomer);
            this.Controls.Add(this.IG_lbl_CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IG_TxtB_TotalPrice);
            this.Controls.Add(this.IG_lbl_TotalPrice);
            this.Controls.Add(this.IG_TxtB_Discount);
            this.Controls.Add(this.IG_lbl_Discount);
            this.Controls.Add(this.IG_TxtB_Total);
            this.Controls.Add(this.IG_lbl_Total);
            this.Controls.Add(this.IG_dataGridView_Invoice);
            this.Controls.Add(this.IG_TxtB_Qty);
            this.Controls.Add(this.IG_lbl_addToInvoice);
            this.Controls.Add(this.IG_lbl_qty);
            this.Controls.Add(this.IG_lbl_productNameOfSelectedItem);
            this.Controls.Add(this.IG_Lbl_productIdOfSelected);
            this.Controls.Add(this.IG_Btn_ViewAllInvoice);
            this.Controls.Add(this.IG_lbl_title);
            this.Controls.Add(this.IG_DataGridView);
            this.Controls.Add(this.IG_Btn_home);
            this.Controls.Add(this.IG_Btn_Search);
            this.Controls.Add(this.IG_TxtB_searchKeyword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceGenerator";
            this.Text = "Invoice Generator";
            this.Load += new System.EventHandler(this.InvoiceGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IG_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IG_dataGridView_Invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IG_DataGridView;
        private System.Windows.Forms.Button IG_Btn_home;
        private System.Windows.Forms.Button IG_Btn_Search;
        private System.Windows.Forms.TextBox IG_TxtB_searchKeyword;
        private System.Windows.Forms.Label IG_lbl_title;
        private System.Windows.Forms.Button IG_Btn_ViewAllInvoice;
        private System.Windows.Forms.Label IG_Lbl_productIdOfSelected;
        private System.Windows.Forms.Label IG_lbl_productNameOfSelectedItem;
        private System.Windows.Forms.Label IG_lbl_qty;
        private System.Windows.Forms.Button IG_lbl_addToInvoice;
        private System.Windows.Forms.TextBox IG_TxtB_Qty;
        private System.Windows.Forms.DataGridView IG_dataGridView_Invoice;
        private System.Windows.Forms.TextBox IG_TxtB_Total;
        private System.Windows.Forms.Label IG_lbl_Total;
        private System.Windows.Forms.TextBox IG_TxtB_Discount;
        private System.Windows.Forms.Label IG_lbl_Discount;
        private System.Windows.Forms.TextBox IG_TxtB_TotalPrice;
        private System.Windows.Forms.Label IG_lbl_TotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IG_lbl_CustomerName;
        private System.Windows.Forms.Button IG_Btn_SearchCustomer;
        private System.Windows.Forms.Button IG_Btn_Print;

    }
}