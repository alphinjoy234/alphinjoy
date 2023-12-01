namespace Inventory_Platform
{
    partial class vendorfrm1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addVendorID = new TextBox();
            label9 = new Label();
            clear_btn = new Button();
            delete_btn = new Button();
            update_btn = new Button();
            add_btn = new Button();
            addcompanyadrs = new TextBox();
            label8 = new Label();
            addcompanydetails = new TextBox();
            label7 = new Label();
            addsoftwaretype = new TextBox();
            label6 = new Label();
            addproductdetails = new TextBox();
            label5 = new Label();
            addcompanyweb = new TextBox();
            label4 = new Label();
            addcompanyname = new TextBox();
            label3 = new Label();
            addproductname = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 22);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 373);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(15, 63);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(850, 276);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addVendorID);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(clear_btn);
            panel2.Controls.Add(delete_btn);
            panel2.Controls.Add(update_btn);
            panel2.Controls.Add(add_btn);
            panel2.Controls.Add(addcompanyadrs);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(addcompanydetails);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addsoftwaretype);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addproductdetails);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addcompanyweb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addcompanyname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addproductname);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 394);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 236);
            panel2.TabIndex = 1;
            // 
            // addVendorID
            // 
            addVendorID.Location = new Point(196, 39);
            addVendorID.Margin = new Padding(4, 3, 4, 3);
            addVendorID.Name = "addVendorID";
            addVendorID.Size = new Size(136, 27);
            addVendorID.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(97, 48);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 19);
            label9.TabIndex = 38;
            label9.Text = "Vendor ID";
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.FromArgb(64, 64, 64);
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.FlatAppearance.BorderSize = 0;
            clear_btn.FlatAppearance.CheckedBackColor = Color.Gray;
            clear_btn.FlatAppearance.MouseDownBackColor = Color.Gray;
            clear_btn.FlatAppearance.MouseOverBackColor = Color.Gray;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clear_btn.ForeColor = Color.White;
            clear_btn.Location = new Point(668, 172);
            clear_btn.Margin = new Padding(4, 3, 4, 3);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(125, 41);
            clear_btn.TabIndex = 37;
            clear_btn.Text = "CLEAR";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(64, 64, 64);
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatAppearance.CheckedBackColor = Color.Gray;
            delete_btn.FlatAppearance.MouseDownBackColor = Color.Gray;
            delete_btn.FlatAppearance.MouseOverBackColor = Color.Gray;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(668, 123);
            delete_btn.Margin = new Padding(4, 3, 4, 3);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(125, 41);
            delete_btn.TabIndex = 36;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.FromArgb(64, 64, 64);
            update_btn.Cursor = Cursors.Hand;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatAppearance.CheckedBackColor = Color.Gray;
            update_btn.FlatAppearance.MouseDownBackColor = Color.Gray;
            update_btn.FlatAppearance.MouseOverBackColor = Color.Gray;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(668, 74);
            update_btn.Margin = new Padding(4, 3, 4, 3);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(125, 41);
            update_btn.TabIndex = 35;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(64, 64, 64);
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatAppearance.CheckedBackColor = Color.Gray;
            add_btn.FlatAppearance.MouseDownBackColor = Color.Gray;
            add_btn.FlatAppearance.MouseOverBackColor = Color.Gray;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(668, 23);
            add_btn.Margin = new Padding(4, 3, 4, 3);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(125, 41);
            add_btn.TabIndex = 34;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // addcompanyadrs
            // 
            addcompanyadrs.Location = new Point(490, 159);
            addcompanyadrs.Margin = new Padding(4, 3, 4, 3);
            addcompanyadrs.Name = "addcompanyadrs";
            addcompanyadrs.Size = new Size(136, 27);
            addcompanyadrs.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(351, 167);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 19);
            label8.TabIndex = 32;
            label8.Text = "Company Address";
            // 
            // addcompanydetails
            // 
            addcompanydetails.Location = new Point(490, 117);
            addcompanydetails.Margin = new Padding(4, 3, 4, 3);
            addcompanydetails.Name = "addcompanydetails";
            addcompanydetails.Size = new Size(136, 27);
            addcompanydetails.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(344, 127);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 30;
            label7.Text = "Company Details";
            // 
            // addsoftwaretype
            // 
            addsoftwaretype.Location = new Point(195, 121);
            addsoftwaretype.Margin = new Padding(4, 3, 4, 3);
            addsoftwaretype.Name = "addsoftwaretype";
            addsoftwaretype.Size = new Size(136, 27);
            addsoftwaretype.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 130);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 28;
            label6.Text = "Type Of Software";
            // 
            // addproductdetails
            // 
            addproductdetails.Location = new Point(490, 39);
            addproductdetails.Margin = new Padding(4, 3, 4, 3);
            addproductdetails.Name = "addproductdetails";
            addproductdetails.Size = new Size(136, 27);
            addproductdetails.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(357, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 26;
            label5.Text = "Product Details";
            // 
            // addcompanyweb
            // 
            addcompanyweb.Location = new Point(195, 158);
            addcompanyweb.Margin = new Padding(4, 3, 4, 3);
            addcompanyweb.Name = "addcompanyweb";
            addcompanyweb.Size = new Size(136, 27);
            addcompanyweb.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 19);
            label4.TabIndex = 24;
            label4.Text = "Company Website";
            // 
            // addcompanyname
            // 
            addcompanyname.Location = new Point(490, 80);
            addcompanyname.Margin = new Padding(4, 3, 4, 3);
            addcompanyname.Name = "addcompanyname";
            addcompanyname.Size = new Size(136, 27);
            addcompanyname.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(356, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 22;
            label3.Text = "Company Name";
            // 
            // addproductname
            // 
            addproductname.Location = new Point(195, 80);
            addproductname.Margin = new Padding(4, 3, 4, 3);
            addproductname.Name = "addproductname";
            addproductname.Size = new Size(136, 27);
            addproductname.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 19);
            label2.TabIndex = 20;
            label2.Text = "Product Name";
            // 
            // vendorfrm1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "vendorfrm1";
            Size = new Size(923, 644);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private TextBox addVendorID;
        private Label label9;
        private Button clear_btn;
        private Button delete_btn;
        private Button update_btn;
        private Button add_btn;
        private TextBox addcompanyadrs;
        private Label label8;
        private TextBox addcompanydetails;
        private Label label7;
        private TextBox addsoftwaretype;
        private Label label6;
        private TextBox addproductdetails;
        private Label label5;
        private TextBox addcompanyweb;
        private Label label4;
        private TextBox addcompanyname;
        private Label label3;
        private TextBox addproductname;
        private Label label2;
    }
}
