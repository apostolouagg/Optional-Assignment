using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proairetikh2
{
    public partial class Form2 : Form
    {
        StreamWriter sw;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new StreamWriter("students.txt", true);

                //name
                if (textBox1.Text.Any(char.IsDigit) || string.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception();
                }

                //lastname
                if (textBox2.Text.Any(char.IsDigit) || string.IsNullOrEmpty(textBox2.Text))
                {
                    throw new Exception();
                }

                //age
                if (int.Parse(textBox3.Text) < 17 || int.Parse(textBox3.Text) > 85)
                {
                    throw new Exception();
                }

                //am
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    throw new Exception();
                }

                //email
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    if (!textBox5.Text.EndsWith("@gmail.com") || !textBox5.Text.EndsWith("@yahoo.gr"))
                    {
                        throw new Exception();
                    }
                }

                //phonenumber
                if (textBox6.Text.Any(char.IsLetter) || string.IsNullOrEmpty(textBox6.Text) || textBox6.Text.Length != 10)
                {
                    throw new Exception();
                }

                sw.WriteLine(textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text + "/" + textBox4.Text + "/" + textBox5.Text + "/" + textBox6.Text + Environment.NewLine);


                MessageBox.Show("Student saved successfully!");

                sw.Close();

                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Something is incorrect. Please try again!");
                sw.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
    }


}
