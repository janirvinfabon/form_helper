namespace MyFormHelper.forms
{
    partial class main_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidateTextbox = new System.Windows.Forms.Button();
            this.txtFirst_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLast_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValidateCombobox = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnValidatePassword = new System.Windows.Forms.Button();
            this.cmbAccess_type = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContact_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLast_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirst_name);
            this.groupBox1.Controls.Add(this.btnValidateTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validate Textbox";
            // 
            // btnValidateTextbox
            // 
            this.btnValidateTextbox.Location = new System.Drawing.Point(173, 153);
            this.btnValidateTextbox.Name = "btnValidateTextbox";
            this.btnValidateTextbox.Size = new System.Drawing.Size(75, 25);
            this.btnValidateTextbox.TabIndex = 6;
            this.btnValidateTextbox.Text = "Validate";
            this.btnValidateTextbox.UseVisualStyleBackColor = true;
            // 
            // txtFirst_name
            // 
            this.txtFirst_name.Location = new System.Drawing.Point(13, 43);
            this.txtFirst_name.Name = "txtFirst_name";
            this.txtFirst_name.Size = new System.Drawing.Size(235, 20);
            this.txtFirst_name.TabIndex = 1;
            this.txtFirst_name.Tag = "alphanumeric";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // txtLast_name
            // 
            this.txtLast_name.Location = new System.Drawing.Point(13, 85);
            this.txtLast_name.Name = "txtLast_name";
            this.txtLast_name.Size = new System.Drawing.Size(235, 20);
            this.txtLast_name.TabIndex = 3;
            this.txtLast_name.Tag = "alphanumeric";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtContact_no
            // 
            this.txtContact_no.Location = new System.Drawing.Point(13, 127);
            this.txtContact_no.Name = "txtContact_no";
            this.txtContact_no.Size = new System.Drawing.Size(235, 20);
            this.txtContact_no.TabIndex = 5;
            this.txtContact_no.Tag = "numeric";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact No.:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.cmbAccess_type);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnValidateCombobox);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Validate Combobox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Access type:";
            // 
            // btnValidateCombobox
            // 
            this.btnValidateCombobox.Location = new System.Drawing.Point(173, 109);
            this.btnValidateCombobox.Name = "btnValidateCombobox";
            this.btnValidateCombobox.Size = new System.Drawing.Size(75, 25);
            this.btnValidateCombobox.TabIndex = 4;
            this.btnValidateCombobox.Text = "Validate";
            this.btnValidateCombobox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.btnValidatePassword);
            this.groupBox3.Location = new System.Drawing.Point(284, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Validate Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(13, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "alphanumeric";
            // 
            // btnValidatePassword
            // 
            this.btnValidatePassword.Location = new System.Drawing.Point(173, 69);
            this.btnValidatePassword.Name = "btnValidatePassword";
            this.btnValidatePassword.Size = new System.Drawing.Size(75, 25);
            this.btnValidatePassword.TabIndex = 2;
            this.btnValidatePassword.Text = "Validate";
            this.btnValidatePassword.UseVisualStyleBackColor = true;
            // 
            // cmbAccess_type
            // 
            this.cmbAccess_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccess_type.FormattingEnabled = true;
            this.cmbAccess_type.Location = new System.Drawing.Point(13, 41);
            this.cmbAccess_type.Name = "cmbAccess_type";
            this.cmbAccess_type.Size = new System.Drawing.Size(235, 21);
            this.cmbAccess_type.TabIndex = 1;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(13, 82);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(235, 21);
            this.cmbStatus.TabIndex = 3;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 375);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContact_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLast_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst_name;
        private System.Windows.Forms.Button btnValidateTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbAccess_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnValidateCombobox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnValidatePassword;
    }
}