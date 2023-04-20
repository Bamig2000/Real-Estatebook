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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random R = new Random();
        string deflt = "Properties.Resources.NoImage";
      
        int num;
        char alpha;
        public string img(string s)
        {
            string a = s + ".PNG";
            return a;

        }
        public void CopyFiles(string sourcePath, string id,int c)
        {
         
            try
            {
                System.IO.File.Copy(sourcePath, $@"C:\Users\Pc\Desktop\PROJECT5\bin\Debug\Images\{id}.PNG", false);
            }
            catch (System.IO.IOException )
            {
                string[] filePaths = Directory.GetFiles(@"C:\Users\Pc\Desktop\PROJECT5\bin\Debug\Images", $"*{id}");
                string a = $"_{(filePaths.Length+1)}";
                System.IO.File.Copy(sourcePath, $@"C:\Users\Pc\Desktop\PROJECT5\bin\Debug\Images\{id + a}.PNG", true);

            }
          
        }
   
        public void changepic(string pic)
        {
            pictureBox1.Image = new Bitmap(pic);
        }
      
        public string flter (string s) 
        {
            string x = s + ".txt";
            return x;
        }

        public void opt()
        {
            CheckBox[] check = new CheckBox[12];
            check[0] = checkBox1;
            check[1] = checkBox2;
            check[2] = checkBox3;
            check[3] = checkBox4;
            check[4] = checkBox5;
            check[5] = checkBox6;
            check[6] = checkBox7;
            check[7] = checkBox8;
            check[8] = checkBox9;
            check[9] = checkBox10;
            check[10] = checkBox11;
            check[11] = checkBox12;
            for (int i = 0; i < 12; i++)
            {
                if (check[i].Checked)
                {
                    All.options.Add(check[i].Text);
                }


            }

        }
        public void clear()
        {

            TextBox[] texts = new TextBox[13];
            texts[0] = textBox1;
            texts[1] = textBox2;
            texts[2] = textBox3;
            texts[3] = textBox4;
            texts[4] = textBox5;
            texts[5] = textBox6;
            texts[6] = textBox7;
            texts[7] = textBox8;
            texts[8] = textBox9;
            texts[9] = textBox10;
            texts[10] = textBox11;
            texts[11] = textBox12;
            texts[12] = textBox13;
            for (int i = 0; i < 13; i++)
            {
                texts[i].Text = "";
            }
            CheckBox[] checks = new CheckBox[12];
            checks[0] = checkBox1;
            checks[1] = checkBox2;
            checks[2] = checkBox3;
            checks[3] = checkBox4;
            checks[4] = checkBox5;
            checks[5] = checkBox6;
            checks[6] = checkBox7;
            checks[7] = checkBox8;
            checks[8] = checkBox9;
            checks[9] = checkBox10;
            checks[10] = checkBox11;
            checks[11] = checkBox12;

            for (int i = 0; i < 12; i++)
            {
                checks[i].Checked = false;
            }
            num = R.Next(100, 999);
            alpha = (char)R.Next('a', 'z');
            Id(num,alpha);
            try
            {
                changepic(deflt);
            }
            catch (Exception )
            {
                pictureBox1.Image = Properties.Resources.NoImage;
              
            }
        
            
        }
        public string Id(int a,char b)
        {

            return b +"-"+ a.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            num = R.Next(100, 999);
            alpha = (char)R.Next('A', 'Z');
            label10.Text = Id(num,alpha);
            button1.Enabled = false;
            button2.Enabled = false;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string id, name, surname, address, email, dateofbirth, addres, contract;
                long phone;
                   int floor, rooms, bathrooms;
                double age, size, price;
                id = label10.Text;
                name = textBox8.Text;
                surname = textBox9.Text;
                address = textBox11.Text.ToString();
                email = textBox13.Text.ToString();
                dateofbirth = textBox10.Text.ToString();
                addres = textBox4.Text.ToString();
                phone = Convert.ToInt32(textBox12.Text);
                floor = Convert.ToInt32(textBox2.Text);
                rooms = Convert.ToInt32(textBox5.Text);
                bathrooms = Convert.ToInt32(textBox6.Text);
                age = Convert.ToDouble(textBox3.Text);
                size = Convert.ToDouble(textBox1.Text);
                price = Convert.ToDouble(textBox7.Text);
                contract = comboBox1.SelectedItem.ToString();
                opt();

                All.owners.Add(new Owner(id, name, surname, address, phone, email, dateofbirth));
                All.properties.Add(new Property(addres, floor, age, rooms, bathrooms, size, price, contract));
                FileStream fs = new FileStream(flter(id), FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("^^^^^^^^^^OWNER^^^^^^^^^^");
                sw.WriteLine($"Name: {name}");
                sw.WriteLine($"Surname: {surname}");
                sw.WriteLine($"Address: {address}");
                sw.WriteLine($"E-Mail: {email}");
                sw.WriteLine($"Date of Birth: {dateofbirth}");
                sw.WriteLine($"Phone Number: {phone}");
                sw.WriteLine("^^^^^^^^^^PROPERTY^^^^^^^^^^");
                sw.WriteLine($"ID: {id}");
                sw.WriteLine($"Size: {size}");
                sw.WriteLine($"Floor: {floor}");
                sw.WriteLine($"Age: {age}");
                sw.WriteLine($"Address: {addres}");
                sw.WriteLine($"Rooms: {rooms}");
                sw.WriteLine($"Bathrooms: {bathrooms}");
                sw.WriteLine($"Contract Type: {contract}");
                sw.WriteLine($"Price: {price}");
              
                for (int i = 0; i < All.options.Count; i++)
                {
                    sw.Write($"|*{All.options[i]}*||");
                }

                sw.Close();
                fs.Close();
                clear();
                MessageBox.Show("Property has been added");
                All.images = null;
                button1.Enabled = false;
                button2.Enabled = false;
                num = R.Next(100, 999);
               
                alpha = (char)R.Next('a', 'z');
                label10.Text = Id(num,alpha);
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
               

            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            f1 = openFileDialog1;
            f1.ShowDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = true;
                string img = f1.FileName.ToString();
                All.images.Add(img);
               changepic(img);
                CopyFiles(img,label10.Text,1);
                
            }
            else if (f1.ShowDialog() == DialogResult.Cancel)
            {
                if (All.images==null)
                {
                    changepic(deflt);
                }
                else
                {
                    changepic(All.images[0]);
                }
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            changepic(All.images[1]);
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            changepic(All.images[0]);
            button2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
        
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.ButtonFace;
        }
    }
}
