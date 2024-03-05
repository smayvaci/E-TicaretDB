namespace Project.WinUI
{
    partial class Form2
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
            this.btnForm2 = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.btnDeleteCategories = new System.Windows.Forms.Button();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.btnListCategories = new System.Windows.Forms.Button();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(656, 554);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(137, 37);
            this.btnForm2.TabIndex = 15;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 423);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(143, 26);
            this.txtDescription.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 358);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 26);
            this.txtName.TabIndex = 13;
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.Location = new System.Drawing.Point(331, 554);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(170, 37);
            this.btnUpdateCategories.TabIndex = 12;
            this.btnUpdateCategories.Text = "Update Categories";
            this.btnUpdateCategories.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategories
            // 
            this.btnDeleteCategories.Location = new System.Drawing.Point(331, 487);
            this.btnDeleteCategories.Name = "btnDeleteCategories";
            this.btnDeleteCategories.Size = new System.Drawing.Size(170, 41);
            this.btnDeleteCategories.TabIndex = 11;
            this.btnDeleteCategories.Text = "Delete Categories";
            this.btnDeleteCategories.UseVisualStyleBackColor = true;
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.Location = new System.Drawing.Point(331, 423);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(170, 42);
            this.btnAddCategories.TabIndex = 10;
            this.btnAddCategories.Text = "Add Categories";
            this.btnAddCategories.UseVisualStyleBackColor = true;
            // 
            // btnListCategories
            // 
            this.btnListCategories.Location = new System.Drawing.Point(331, 358);
            this.btnListCategories.Name = "btnListCategories";
            this.btnListCategories.Size = new System.Drawing.Size(170, 42);
            this.btnListCategories.TabIndex = 9;
            this.btnListCategories.Text = "List Categories";
            this.btnListCategories.UseVisualStyleBackColor = true;
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 20;
            this.lstCategories.Location = new System.Drawing.Point(146, 101);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(1102, 224);
            this.lstCategories.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 693);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateCategories);
            this.Controls.Add(this.btnDeleteCategories);
            this.Controls.Add(this.btnAddCategories);
            this.Controls.Add(this.btnListCategories);
            this.Controls.Add(this.lstCategories);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.Button btnDeleteCategories;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.Button btnListCategories;
        private System.Windows.Forms.ListBox lstCategories;
    }
}