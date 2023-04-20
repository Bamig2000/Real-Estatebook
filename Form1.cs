using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

       

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

       
        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.SystemColors.ButtonFace;
        }
    }
}
