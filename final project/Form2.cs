using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MediumPurple;
            button1.Font = new Font("MV Boli", 11, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.Font = new Font("MV Boli", 9, FontStyle.Bold);
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.MediumPurple;
            button2.Font = new Font("MV Boli", 11, FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button2.Font = new Font("MV Boli", 9, FontStyle.Bold);
        }

    }
}
