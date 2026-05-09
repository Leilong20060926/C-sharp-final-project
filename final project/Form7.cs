using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();

            this.Hide();
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.MediumPurple;
            button3.Font = new Font("MV Boli", 11, FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
            button3.Font = new Font("MV Boli", 9, FontStyle.Bold);
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
