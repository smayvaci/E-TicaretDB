namespace Project.WinUI
{
    partial class Form1
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
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.btnDeleteCategories = new System.Windows.Forms.Button();
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.AddProducts = new System.Windows.Forms.Button();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.CategoryName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 20;
            this.lstCategories.Location = new System.Drawing.Point(57, 37);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(505, 244);
            this.lstCategories.TabIndex = 0;
            this.lstCategories.Click += new System.EventHandler(this.lstCategories_Click);
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.Location = new System.Drawing.Point(279, 304);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(170, 63);
            this.btnAddCategories.TabIndex = 2;
            this.btnAddCategories.Text = "Add Categories";
            this.btnAddCategories.UseVisualStyleBackColor = true;
            this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click);
            // 
            // btnDeleteCategories
            // 
            this.btnDeleteCategories.Location = new System.Drawing.Point(279, 380);
            this.btnDeleteCategories.Name = "btnDeleteCategories";
            this.btnDeleteCategories.Size = new System.Drawing.Size(170, 55);
            this.btnDeleteCategories.TabIndex = 3;
            this.btnDeleteCategories.Text = "Delete Categories";
            this.btnDeleteCategories.UseVisualStyleBackColor = true;
            this.btnDeleteCategories.Click += new System.EventHandler(this.btnDeleteCategories_Click);
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.Location = new System.Drawing.Point(279, 454);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(170, 55);
            this.btnUpdateCategories.TabIndex = 4;
            this.btnUpdateCategories.Text = "Update Categories";
            this.btnUpdateCategories.UseVisualStyleBackColor = true;
            this.btnUpdateCategories.Click += new System.EventHandler(this.btnUpdateCategories_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 334);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(57, 409);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(143, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(1221, 575);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(137, 37);
            this.btnForm2.TabIndex = 7;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.Form2_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 20;
            this.lstProducts.Location = new System.Drawing.Point(675, 37);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(505, 244);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.Click += new System.EventHandler(this.lstCategories_Click);
            // 
            // AddProducts
            // 
            this.AddProducts.Location = new System.Drawing.Point(908, 304);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(170, 56);
            this.AddProducts.TabIndex = 2;
            this.AddProducts.Text = "Add Products";
            this.AddProducts.UseVisualStyleBackColor = true;
            this.AddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.Location = new System.Drawing.Point(908, 381);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(170, 54);
            this.btnDeleteProducts.TabIndex = 3;
            this.btnDeleteProducts.Text = "Delete Products";
            this.btnDeleteProducts.UseVisualStyleBackColor = true;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
            // 
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Location = new System.Drawing.Point(908, 454);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(170, 55);
            this.btnUpdateProducts.TabIndex = 4;
            this.btnUpdateProducts.Text = "Update Products";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(687, 334);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(143, 26);
            this.txtProductName.TabIndex = 5;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(687, 409);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(143, 26);
            this.txtProductPrice.TabIndex = 6;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(687, 481);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(143, 28);
            this.cmbCategories.TabIndex = 8;
            // 
            // CategoryName
            // 
            this.CategoryName.BackColor = System.Drawing.Color.LightGray;
            this.CategoryName.Location = new System.Drawing.Point(58, 311);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(142, 20);
            this.CategoryName.TabIndex = 9;
            this.CategoryName.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(58, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProductName.Location = new System.Drawing.Point(687, 311);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(143, 20);
            this.ProductName.TabIndex = 11;
            this.ProductName.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(687, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(690, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Products Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 682);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateProducts);
            this.Controls.Add(this.btnUpdateCategories);
            this.Controls.Add(this.btnDeleteProducts);
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.btnDeleteCategories);
            this.Controls.Add(this.btnAddCategories);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lstCategories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.Button btnDeleteCategories;
        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button btnDeleteProducts;
        private System.Windows.Forms.Button btnUpdateProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label CategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}