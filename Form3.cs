using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROJECT5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int slide;
        int pic;
        public void updatepic(string s, int a)
        {
            string[] Images = (Directory.GetFiles(@"C:\Users\Pc\Desktop\PROJECT5\bin\Debug\Images", $"{s}*"));
            try
            {
                string b = Images[a];
                pictureBox1.Image = new Bitmap(b);
            }
            catch (Exception)
            {

                button4.Enabled = false;
                button5.Enabled = false;
            }
          
         

        }
        public string rightpicdata(string s)
        {
            int lastdoubledot = s.LastIndexOf('s');
            string result = s.Substring(lastdoubledot + 2).Trim();
            return result;
        }
        private string rightinfo(string str)
        {
            int lastdoubledot = str.LastIndexOf(':');
            string result = str.Substring(lastdoubledot + 1).Trim();
            return result;
        }
        public string rightdata(string s)
        {
            int lastdoubledot = s.LastIndexOf('g');
            string result = s.Substring(lastdoubledot + 2).Trim();
            return result;
        }
        public void updatelabel(int a)
        {
            string[] filePaths = Directory.GetFiles(@"C:\Users\Pc\Desktop\PROJECT5\bin\Debug", "*.txt");


            FileStream fs = new FileStream($"{rightdata(filePaths[a])}", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            label32.Text = $"{a + 1} out of {filePaths.Length}";
            string temp = (sr.ReadLine());
            label26.Text = rightinfo((sr.ReadLine()));
            label27.Text = rightinfo((sr.ReadLine()));
            label28.Text = rightinfo((sr.ReadLine()));
            label29.Text = rightinfo((sr.ReadLine()));
            label30.Text = rightinfo((sr.ReadLine()));
            label31.Text = rightinfo((sr.ReadLine()));
            string m = (sr.ReadLine());
            label10.Text = rightinfo((sr.ReadLine()));
            label11.Text = rightinfo((sr.ReadLine()));
            label12.Text = rightinfo((sr.ReadLine()));
            label13.Text = rightinfo((sr.ReadLine()));
            label14.Text = rightinfo((sr.ReadLine()));
            label15.Text = rightinfo((sr.ReadLine()));
            label16.Text = rightinfo((sr.ReadLine()));
            label17.Text = rightinfo((sr.ReadLine()));
            label18.Text = rightinfo((sr.ReadLine()));

            while (!sr.EndOfStream)
            {
                label19.Text = sr.ReadLine();
            }




            sr.Close();
            fs.Close();
            if (a + 1 == filePaths.Length)
            {
                button2.Enabled = false;
            }
            else if (a == 0)
            {
                button1.Enabled = false;
            }
            else if (a + 1 != filePaths.Length)
            {
                button2.Enabled = true;
            }
            else if (a != 0)
            {
                button1.Enabled = true;
            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            slide += 1;
            updatelabel(slide);
            button1.Enabled = true;
            updatepic(label10.Text, 0);
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pic = 0;
            button1.Enabled = false;
            slide = 0;
            updatelabel(slide);
            button4.Enabled = false;
            updatepic(label10.Text, pic);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            slide -= 1;
            updatelabel(slide);
            button2.Enabled = true;
            updatepic(label10.Text, 0);
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pic=0;
            button5.Enabled = true;
            updatepic(label10.Text, pic);
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pic = 1;
            button4.Enabled = true;
            updatepic(label10.Text, pic);
            button5.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}