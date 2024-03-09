using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proairetikh2.Form2;

namespace proairetikh2
{
    public partial class Form1 : Form
    {
        public string search;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("students.txt");
                String s = sr.ReadLine();

                if (s != " ")
                {
                    StringBuilder sb = new StringBuilder();
                    while (s != null)
                    {
                        sb.Append(s.Split('/')[0] + Environment.NewLine);
                        s = sr.ReadLine();
                    }

                    MessageBox.Show(sb.ToString());

                    sr.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are no student.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search = textBox1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;

                StreamReader sr = new StreamReader("students.txt");
                string s = sr.ReadLine();

                while(s!=null)
                {
                    if (s.StartsWith(search))
                    {
                        MessageBox.Show(s);
                        flag = false;
                        return;
                    }

                    s = sr.ReadLine();
                }

                if (flag)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again!");
            }
            
        }
    }
}
