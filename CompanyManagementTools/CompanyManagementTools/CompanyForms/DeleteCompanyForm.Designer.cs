
namespace CompanyManagementTools.CompanyForms
{
    partial class DeleteCompanyForm
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
            this.cmbDeleteComp = new System.Windows.Forms.ComboBox();
            this.btnCancelDeleteComp = new System.Windows.Forms.Button();
            this.btnDeleteComp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDeleteComp
            // 
            this.cmbDeleteComp.FormattingEnabled = true;
            this.cmbDeleteComp.Location = new System.Drawing.Point(123, 119);
            this.cmbDeleteComp.Name = "cmbDeleteComp";
            this.cmbDeleteComp.Size = new System.Drawing.Size(384, 24);
            this.cmbDeleteComp.TabIndex = 0;
            this.cmbDeleteComp.Text = "Select A Company To Delete";
            this.cmbDeleteComp.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteComp_SelectedIndexChanged);
            // 
            // btnCancelDeleteComp
            // 
            this.btnCancelDeleteComp.Location = new System.Drawing.Point(226, 149);
            this.btnCancelDeleteComp.Name = "btnCancelDeleteComp";
            this.btnCancelDeleteComp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDeleteComp.TabIndex = 1;
            this.btnCancelDeleteComp.Text = "Cancel";
            this.btnCancelDeleteComp.UseVisualStyleBackColor = true;
            this.btnCancelDeleteComp.Click += new System.EventHandler(this.btnCancelDeleteComp_Click);
            // 
            // btnDeleteComp
            // 
            this.btnDeleteComp.Location = new System.Drawing.Point(325, 149);
            this.btnDeleteComp.Name = "btnDeleteComp";
            this.btnDeleteComp.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteComp.TabIndex = 2;
            this.btnDeleteComp.Text = "Delete";
            this.btnDeleteComp.UseVisualStyleBackColor = true;
            this.btnDeleteComp.Click += new System.EventHandler(this.btnDeleteComp_Click);
            // 
            // DeleteCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
            this.Controls.Add(this.btnDeleteComp);
            this.Controls.Add(this.btnCancelDeleteComp);
            this.Controls.Add(this.cmbDeleteComp);
            this.Name = "DeleteCompanyForm";
            this.Text = "DeleteCompanyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeleteComp;
        private System.Windows.Forms.Button btnCancelDeleteComp;
        private System.Windows.Forms.Button btnDeleteComp;
    }
}