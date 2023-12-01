namespace Inventory_Platform
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            manage_inv = new Button();
            button1 = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            vendorfrm11 = new vendorfrm1();
            button5 = new Button();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(manage_inv);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(923, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 700);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Bottom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(15, 520);
            button6.Name = "button6";
            button6.Size = new Size(247, 60);
            button6.TabIndex = 8;
            button6.Text = "INFO";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(15, 580);
            button4.Name = "button4";
            button4.Size = new Size(247, 60);
            button4.TabIndex = 7;
            button4.Text = "EXIT";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Bottom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(15, 640);
            button3.Name = "button3";
            button3.Size = new Size(247, 60);
            button3.TabIndex = 6;
            button3.Text = "HELP";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // manage_inv
            // 
            manage_inv.Cursor = Cursors.Hand;
            manage_inv.Dock = DockStyle.Top;
            manage_inv.FlatAppearance.BorderSize = 0;
            manage_inv.FlatStyle = FlatStyle.Flat;
            manage_inv.ForeColor = Color.White;
            manage_inv.Location = new Point(15, 159);
            manage_inv.Name = "manage_inv";
            manage_inv.Size = new Size(247, 60);
            manage_inv.TabIndex = 5;
            manage_inv.Text = "MANAGE INVENTORY";
            manage_inv.TextImageRelation = TextImageRelation.ImageBeforeText;
            manage_inv.UseVisualStyleBackColor = true;
            manage_inv.Click += manage_inv_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(15, 99);
            button1.Name = "button1";
            button1.Size = new Size(247, 60);
            button1.TabIndex = 4;
            button1.Text = "HOME";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 601);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(262, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 601);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 99);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 26);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "WELCOME";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(vendorfrm11);
            panel5.Controls.Add(button5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(923, 56);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // vendorfrm11
            // 
            vendorfrm11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            vendorfrm11.Location = new Point(0, 56);
            vendorfrm11.Margin = new Padding(4, 3, 4, 3);
            vendorfrm11.Name = "vendorfrm11";
            vendorfrm11.Size = new Size(923, 644);
            vendorfrm11.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.Location = new Point(884, 12);
            button5.Name = "button5";
            button5.Size = new Size(33, 33);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 56);
            panel6.Name = "panel6";
            panel6.Size = new Size(923, 644);
            panel6.TabIndex = 2;
            panel6.Paint += panel6_Paint;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button3;
        private Button manage_inv;
        private Button button4;
        private Panel panel5;
        private Button button6;
        private Panel panel6;
        private vendorfrm1 vendorfrm11;
        private Button button5;
    }
}