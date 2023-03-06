namespace New_metro_App.Forms
{
    partial class FormSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtRepwd = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.iconSignup = new FontAwesome.Sharp.IconButton();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill Your Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(29, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(29, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(29, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Conform Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(34, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 31);
            this.txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(34, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 31);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(34, 347);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(334, 31);
            this.txtPwd.TabIndex = 9;
            // 
            // txtRepwd
            // 
            this.txtRepwd.Location = new System.Drawing.Point(34, 420);
            this.txtRepwd.Name = "txtRepwd";
            this.txtRepwd.Size = new System.Drawing.Size(334, 31);
            this.txtRepwd.TabIndex = 10;
            this.txtRepwd.Leave += new System.EventHandler(this.txtRepwd_Leave);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radMale.ForeColor = System.Drawing.Color.AliceBlue;
            this.radMale.Location = new System.Drawing.Point(36, 274);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(53, 30);
            this.radMale.TabIndex = 11;
            this.radMale.TabStop = true;
            this.radMale.Text = "M";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radFemale.ForeColor = System.Drawing.Color.AliceBlue;
            this.radFemale.Location = new System.Drawing.Point(110, 274);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(46, 30);
            this.radFemale.TabIndex = 12;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "F";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // iconSignup
            // 
            this.iconSignup.BackColor = System.Drawing.Color.Lavender;
            this.iconSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSignup.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconSignup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconSignup.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconSignup.IconColor = System.Drawing.Color.Black;
            this.iconSignup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSignup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSignup.Location = new System.Drawing.Point(220, 469);
            this.iconSignup.Name = "iconSignup";
            this.iconSignup.Size = new System.Drawing.Size(148, 51);
            this.iconSignup.TabIndex = 13;
            this.iconSignup.Text = "Sign Up";
            this.iconSignup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSignup.UseVisualStyleBackColor = false;
            this.iconSignup.Click += new System.EventHandler(this.iconSignup_Click);
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLogin.LinkColor = System.Drawing.Color.Cyan;
            this.linkLogin.Location = new System.Drawing.Point(39, 496);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(58, 26);
            this.linkLogin.TabIndex = 14;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.iconSignup);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.txtRepwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPwd;
        private TextBox txtRepwd;
        private RadioButton radMale;
        private RadioButton radFemale;
        private FontAwesome.Sharp.IconButton iconSignup;
        private LinkLabel linkLogin;
    }
}