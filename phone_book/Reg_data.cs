using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone_book
{
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.Info_gbox.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void New_butt_Click(object sender, EventArgs e)
        {
            this.New_butt.Enabled = false;
            this.Save_butt.Enabled = true;
            this.Info_gbox.Enabled = true;
            //----------------------------
            this.id_textBox1.ResetText();
            this.fn_textBox2.ResetText();
            this.ln_textBox3.ResetText();
            this.tel_textBox4.ResetText();
            this.cell_textBox5.ResetText();
            this.email_textBox6.ResetText();
            this.address_textBox7.ResetText();
            this.com_textBox8.ResetText();
        }

        private void Save_butt_Click(object sender, EventArgs e) 
        {
            if (this.id_textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            this.Save_butt.Enabled = false;
            this.New_butt.Enabled = true;
            this.Info_gbox.Enabled = false;
            //-----------------------------
            string fn;
            fn = "C:\\Test\\";
            string p;
            //-----------------------------
            p = fn + this.id_textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.fn_textBox2.Text, Encoding.UTF8);
            //-----------------------------
            p = fn + this.id_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.ln_textBox3.Text, Encoding.UTF8);
            //----------------------------- 
            p = fn + this.id_textBox1.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.tel_textBox4.Text, Encoding.UTF8);
            //----------------------------- 
            p = fn + this.id_textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.cell_textBox5.Text, Encoding.UTF8);
            //----------------------------- 
            p = fn + this.id_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.email_textBox6.Text, Encoding.UTF8);
            //----------------------------- 
            p = fn + this.id_textBox1.Text + "_add.txt";
            System.IO.File.WriteAllText(p, this.address_textBox7.Text, Encoding.UTF8);
            //----------------------------- 
            p = fn + this.id_textBox1.Text + "_comm.txt";
            System.IO.File.WriteAllText(p, this.com_textBox8.Text, Encoding.UTF8);
            //----------------------------- 
            MessageBox.Show("Saved!");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
