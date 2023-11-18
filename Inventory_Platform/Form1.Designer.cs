namespace Inventory_Platform
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            txtComPassword = new TextBox();
            label4 = new Label();
            checkbxShowPas = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(194, 48);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(33, 117);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Email Id";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(232, 233, 231);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(33, 145);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(232, 233, 231);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(33, 220);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(216, 28);
            txtpassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(33, 192);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(232, 233, 231);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(33, 302);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(33, 274);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkbxShowPas
            // 
            checkbxShowPas.AutoSize = true;
            checkbxShowPas.Cursor = Cursors.Hand;
            checkbxShowPas.FlatStyle = FlatStyle.Flat;
            checkbxShowPas.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkbxShowPas.ForeColor = SystemColors.ActiveCaption;
            checkbxShowPas.Location = new Point(155, 336);
            checkbxShowPas.Name = "checkbxShowPas";
            checkbxShowPas.Size = new Size(122, 23);
            checkbxShowPas.TabIndex = 7;
            checkbxShowPas.Text = "Show Password";
            checkbxShowPas.UseVisualStyleBackColor = true;
            checkbxShowPas.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(33, 364);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(33, 416);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(55, 454);
            label5.Name = "label5";
            label5.Size = new Size(181, 19);
            label5.TabIndex = 10;
            label5.Text = "Already Have An Account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(91, 473);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 11;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkbxShowPas);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtComPassword;
        private Label label4;
        private CheckBox checkbxShowPas;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}