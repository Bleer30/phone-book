namespace phone_book
{
    partial class Reg_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_data));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.New_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Save_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Info_gbox = new System.Windows.Forms.GroupBox();
            this.com_textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.address_textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email_textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cell_textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tel_textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ln_textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fn_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Info_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.New_butt,
            this.toolStripSeparator2,
            this.Save_butt,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(398, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // New_butt
            // 
            this.New_butt.Image = ((System.Drawing.Image)(resources.GetObject("New_butt.Image")));
            this.New_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.New_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_butt.Name = "New_butt";
            this.New_butt.Size = new System.Drawing.Size(93, 41);
            this.New_butt.Text = "New data";
            this.New_butt.Click += new System.EventHandler(this.New_butt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // Save_butt
            // 
            this.Save_butt.Enabled = false;
            this.Save_butt.Image = ((System.Drawing.Image)(resources.GetObject("Save_butt.Image")));
            this.Save_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_butt.Name = "Save_butt";
            this.Save_butt.Size = new System.Drawing.Size(116, 41);
            this.Save_butt.Text = "Save Changes";
            this.Save_butt.Click += new System.EventHandler(this.Save_butt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // Info_gbox
            // 
            this.Info_gbox.Controls.Add(this.com_textBox8);
            this.Info_gbox.Controls.Add(this.label8);
            this.Info_gbox.Controls.Add(this.address_textBox7);
            this.Info_gbox.Controls.Add(this.label7);
            this.Info_gbox.Controls.Add(this.email_textBox6);
            this.Info_gbox.Controls.Add(this.label6);
            this.Info_gbox.Controls.Add(this.cell_textBox5);
            this.Info_gbox.Controls.Add(this.label5);
            this.Info_gbox.Controls.Add(this.tel_textBox4);
            this.Info_gbox.Controls.Add(this.label4);
            this.Info_gbox.Controls.Add(this.ln_textBox3);
            this.Info_gbox.Controls.Add(this.label3);
            this.Info_gbox.Controls.Add(this.fn_textBox2);
            this.Info_gbox.Controls.Add(this.label2);
            this.Info_gbox.Controls.Add(this.id_textBox1);
            this.Info_gbox.Controls.Add(this.label1);
            this.Info_gbox.Enabled = false;
            this.Info_gbox.Location = new System.Drawing.Point(13, 58);
            this.Info_gbox.Name = "Info_gbox";
            this.Info_gbox.Size = new System.Drawing.Size(373, 319);
            this.Info_gbox.TabIndex = 1;
            this.Info_gbox.TabStop = false;
            this.Info_gbox.Text = "Information";
            this.Info_gbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // com_textBox8
            // 
            this.com_textBox8.Location = new System.Drawing.Point(83, 244);
            this.com_textBox8.Name = "com_textBox8";
            this.com_textBox8.Size = new System.Drawing.Size(245, 20);
            this.com_textBox8.TabIndex = 15;
            this.com_textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // address_textBox7
            // 
            this.address_textBox7.Location = new System.Drawing.Point(83, 218);
            this.address_textBox7.Name = "address_textBox7";
            this.address_textBox7.Size = new System.Drawing.Size(245, 20);
            this.address_textBox7.TabIndex = 13;
            this.address_textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // email_textBox6
            // 
            this.email_textBox6.Location = new System.Drawing.Point(83, 192);
            this.email_textBox6.Name = "email_textBox6";
            this.email_textBox6.Size = new System.Drawing.Size(245, 20);
            this.email_textBox6.TabIndex = 11;
            this.email_textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cell_textBox5
            // 
            this.cell_textBox5.Location = new System.Drawing.Point(83, 166);
            this.cell_textBox5.Name = "cell_textBox5";
            this.cell_textBox5.Size = new System.Drawing.Size(245, 20);
            this.cell_textBox5.TabIndex = 9;
            this.cell_textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cell:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tel_textBox4
            // 
            this.tel_textBox4.Location = new System.Drawing.Point(83, 140);
            this.tel_textBox4.Name = "tel_textBox4";
            this.tel_textBox4.Size = new System.Drawing.Size(245, 20);
            this.tel_textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone:";
            // 
            // ln_textBox3
            // 
            this.ln_textBox3.Location = new System.Drawing.Point(83, 114);
            this.ln_textBox3.Name = "ln_textBox3";
            this.ln_textBox3.Size = new System.Drawing.Size(245, 20);
            this.ln_textBox3.TabIndex = 5;
            this.ln_textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // fn_textBox2
            // 
            this.fn_textBox2.Location = new System.Drawing.Point(83, 88);
            this.fn_textBox2.Name = "fn_textBox2";
            this.fn_textBox2.Size = new System.Drawing.Size(245, 20);
            this.fn_textBox2.TabIndex = 3;
            this.fn_textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // id_textBox1
            // 
            this.id_textBox1.Location = new System.Drawing.Point(83, 62);
            this.id_textBox1.Name = "id_textBox1";
            this.id_textBox1.Size = new System.Drawing.Size(245, 20);
            this.id_textBox1.TabIndex = 1;
            this.id_textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Reg_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 410);
            this.Controls.Add(this.Info_gbox);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Reg_data";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Data";
            this.Load += new System.EventHandler(this.Reg_data_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Info_gbox.ResumeLayout(false);
            this.Info_gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton New_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Save_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox Info_gbox;
        private System.Windows.Forms.TextBox com_textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox address_textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email_textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cell_textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tel_textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ln_textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fn_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_textBox1;
        private System.Windows.Forms.Label label1;
    }
}