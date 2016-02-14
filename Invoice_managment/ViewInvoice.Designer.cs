namespace Invoice_managment
{
    partial class ViewInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInvoice));
            this.VI_DataGridView = new System.Windows.Forms.DataGridView();
            this.VI_Btn_home = new System.Windows.Forms.Button();
            this.VI_Btn_Search = new System.Windows.Forms.Button();
            this.VI_TxtB_searchKeyword = new System.Windows.Forms.TextBox();
            this.VI_Btn_gotoInvoive = new System.Windows.Forms.Button();
            this.IV_ComboB_invoiceNo = new System.Windows.Forms.ComboBox();
            this.VI_lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VI_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VI_DataGridView
            // 
            this.VI_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.VI_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VI_DataGridView.Location = new System.Drawing.Point(32, 130);
            this.VI_DataGridView.Name = "VI_DataGridView";
            this.VI_DataGridView.Size = new System.Drawing.Size(721, 217);
            this.VI_DataGridView.TabIndex = 12;
            // 
            // VI_Btn_home
            // 
            this.VI_Btn_home.Location = new System.Drawing.Point(33, 36);
            this.VI_Btn_home.Name = "VI_Btn_home";
            this.VI_Btn_home.Size = new System.Drawing.Size(59, 21);
            this.VI_Btn_home.TabIndex = 11;
            this.VI_Btn_home.Text = "Home";
            this.VI_Btn_home.UseVisualStyleBackColor = true;
            this.VI_Btn_home.Click += new System.EventHandler(this.VI_Btn_home_Click);
            // 
            // VI_Btn_Search
            // 
            this.VI_Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.VI_Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.VI_Btn_Search.FlatAppearance.BorderSize = 0;
            this.VI_Btn_Search.ForeColor = System.Drawing.Color.White;
            this.VI_Btn_Search.Location = new System.Drawing.Point(623, 93);
            this.VI_Btn_Search.Name = "VI_Btn_Search";
            this.VI_Btn_Search.Size = new System.Drawing.Size(130, 26);
            this.VI_Btn_Search.TabIndex = 10;
            this.VI_Btn_Search.Text = "Search";
            this.VI_Btn_Search.UseVisualStyleBackColor = false;
            // 
            // VI_TxtB_searchKeyword
            // 
            this.VI_TxtB_searchKeyword.Location = new System.Drawing.Point(33, 98);
            this.VI_TxtB_searchKeyword.Name = "VI_TxtB_searchKeyword";
            this.VI_TxtB_searchKeyword.Size = new System.Drawing.Size(359, 20);
            this.VI_TxtB_searchKeyword.TabIndex = 9;
            this.VI_TxtB_searchKeyword.Text = "\r\n";
            // 
            // VI_Btn_gotoInvoive
            // 
            this.VI_Btn_gotoInvoive.Location = new System.Drawing.Point(107, 36);
            this.VI_Btn_gotoInvoive.Name = "VI_Btn_gotoInvoive";
            this.VI_Btn_gotoInvoive.Size = new System.Drawing.Size(59, 21);
            this.VI_Btn_gotoInvoive.TabIndex = 13;
            this.VI_Btn_gotoInvoive.Text = "Invoice";
            this.VI_Btn_gotoInvoive.UseVisualStyleBackColor = true;
            this.VI_Btn_gotoInvoive.Click += new System.EventHandler(this.VI_Btn_gotoInvoive_Click);
            // 
            // IV_ComboB_invoiceNo
            // 
            this.IV_ComboB_invoiceNo.FormattingEnabled = true;
            this.IV_ComboB_invoiceNo.Location = new System.Drawing.Point(433, 98);
            this.IV_ComboB_invoiceNo.Name = "IV_ComboB_invoiceNo";
            this.IV_ComboB_invoiceNo.Size = new System.Drawing.Size(140, 21);
            this.IV_ComboB_invoiceNo.TabIndex = 14;
            this.IV_ComboB_invoiceNo.Text = "Invoice No";
            // 
            // VI_lbl_title
            // 
            this.VI_lbl_title.AutoSize = true;
            this.VI_lbl_title.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VI_lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.VI_lbl_title.Location = new System.Drawing.Point(577, 26);
            this.VI_lbl_title.Name = "VI_lbl_title";
            this.VI_lbl_title.Size = new System.Drawing.Size(126, 46);
            this.VI_lbl_title.TabIndex = 15;
            this.VI_lbl_title.Text = "Invoice";
            this.VI_lbl_title.Click += new System.EventHandler(this.VI_lbl_title_Click);
            // 
            // ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.VI_lbl_title);
            this.Controls.Add(this.IV_ComboB_invoiceNo);
            this.Controls.Add(this.VI_Btn_gotoInvoive);
            this.Controls.Add(this.VI_DataGridView);
            this.Controls.Add(this.VI_Btn_home);
            this.Controls.Add(this.VI_Btn_Search);
            this.Controls.Add(this.VI_TxtB_searchKeyword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewInvoice";
            this.Text = "View Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.VI_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VI_DataGridView;
        private System.Windows.Forms.Button VI_Btn_home;
        private System.Windows.Forms.Button VI_Btn_Search;
        private System.Windows.Forms.TextBox VI_TxtB_searchKeyword;
        private System.Windows.Forms.Button VI_Btn_gotoInvoive;
        private System.Windows.Forms.ComboBox IV_ComboB_invoiceNo;
        private System.Windows.Forms.Label VI_lbl_title;

    }
}