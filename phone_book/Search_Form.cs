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
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            string fn;
            fn = "C:\\Test\\";
            string p;
            string r;
            p = fn + this.textBox1.Text + "_fn.txt";
            if (System.IO.File.Exists(p)==true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.fn_textBox2.Text = r;
            }
            //---------------------------------------------------
            p = fn + this.textBox1.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.ln_textBox3.Text = r;
            }
            //---------------------------------------------------
            p = fn + this.textBox1.Text + "_tel.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tel_textBox4.Text = r;
            }
            //---------------------------------------------------
            p = fn + this.textBox1.Text + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.cell_textBox5.Text = r;
            }
            //---------------------------------------------------
            p = fn + this.textBox1.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_textBox6.Text = r;
            }
            //---------------------------------------------------
            p = fn + this.textBox1.Text + "_add.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.address_textBox7.Text = r;
            }
            //---------------------------------------------------
            p = fn + this.textBox1.Text + "_comm.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.com_textBox8.Text = r;
            }
            //---------------------------------------------------
            this.id_textBox1.Text = this.textBox1.Text;
        }
    }
}
