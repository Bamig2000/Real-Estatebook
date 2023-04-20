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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int a = 0;
        public string rightdata(string s)
        {
            int lastdoubledot = s.LastIndexOf('g');
            string result = s.Substring(lastdoubledot + 2 ).Trim();
            return result;
        }
        public string rightpicdata(string s)
        {
            int lastdoubledot = s.LastIndexOf('s');
            string result = s.Substring(lastdoubledot + 2).Trim();
            return result;
        }
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
                button3.Enabled = false;
                button7.Enabled = false;
            }
            

        }
        private string rightinfo(string str)
        {
            int lastdoubledot = str.LastIndexOf(':');
            string result = str.Substring(lastdoubledot + 1).Trim();
            return result;
        }
        public void udpatelabels(int a)
        {
            int result;
            string contract = comboBox1.SelectedItem.ToString();
            string Id = textBox1.Text;
            string rooms = textBox2.Text;
            string[] filePaths = Directory.GetFiles(@"C:\Users\Pc\Desktop\PROJECT5\bin\Debug", "*.txt");
            string[] matches = new string[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                foreach (string line in File.ReadLines(filePaths[i]))
                {
                    string i_d = "ID: ";
                    string contr = "Contract Type: ";
                    string roms = "Rooms: ";
                    if (line.Contains(contr + contract) || line.Contains(i_d+Id) || line.Contains(roms+rooms))
                    {
                       
                        matches[i] = rightdata(filePaths[i]);

                    }
                   

                }
            }

            result = matches.GetLength(0);

            if (matches == null)
            {
                MessageBox.Show("No results");
                groupBox2.Enabled = false;
            }
            else
            {
                try
                {
                    groupBox2.Enabled = true;
                    FileStream fs = new FileStream($"{matches[a]}", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    label1.Text = $"{a + 1} out of {result}";
                    string temp = (sr.ReadLine());
                    label26.Text = rightinfo((sr.ReadLine()));
                    label27.Text = rightinfo((sr.ReadLine()));
                    label31.Text = rightinfo((sr.ReadLine()));
                    label29.Text = rightinfo((sr.ReadLine()));
                    label30.Text = rightinfo((sr.ReadLine()));
                    label28.Text = rightinfo((sr.ReadLine()));
                    string m = (sr.ReadLine());
                    label11.Text = rightinfo((sr.ReadLine()));
                    label12.Text = rightinfo((sr.ReadLine()));
                    label13.Text = rightinfo((sr.ReadLine()));
                    label14.Text = rightinfo((sr.ReadLine()));
                    label15.Text = rightinfo((sr.ReadLine()));
                    label16.Text = rightinfo((sr.ReadLine()));
                    label17.Text = rightinfo((sr.ReadLine()));
                    label18.Text = rightinfo((sr.ReadLine()));
                    label19.Text = rightinfo((sr.ReadLine()));
                    while (!sr.EndOfStream)
                    {
                        label32.Text = sr.ReadLine();
                    }
                   
                    updatepic(label11.Text, 0);

                    sr.Close();
                    fs.Close();

                    if (a + 1 != 1)
                    {
                        button1.Enabled = true;
                    }
                    else if (a == 0)
                    {
                        button1.Enabled = false;
                    }

                    else if (a  == matches.GetLength(0))
                    {
                        button2.Enabled = false;
                    }
                    else if (a + 1 != result)
                    {
                        button2.Enabled = true;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {

                    button2.Enabled = false;
                }
                
            }


        }
        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            
          
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                udpatelabels(a);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            a -= 1;
            udpatelabels(a);
            button2.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a += 1;
            udpatelabels(a);
            button3.Enabled = true;
            button7.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            int pic = 0;
            updatepic(label11.Text, pic);
            button3.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int pic = 1;
            button3.Enabled = true;
            updatepic(label11.Text, pic);
            button7.Enabled = false;
        }
    }
}
