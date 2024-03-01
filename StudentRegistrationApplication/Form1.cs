using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            string LastName = Convert.ToString(textBox1.Text);
            string FirstName = Convert.ToString(textBox2.Text);
            string MiddleName = Convert.ToString(textBox3.Text);
            string GMale = Convert.ToString(radioButton1.Checked);
            string GFemale = Convert.ToString(radioButton2.Checked);

            Console.Write("Student Name: " + FirstName + MiddleName + LastName);
            Console.Write("Gender: " + GMale + GFemale);
            Console.Write("Date of Birth: ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }

            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }

        }

        
    }
}
