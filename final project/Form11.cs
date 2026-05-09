using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.MediumPurple;
            button3.Font = new Font("MV Boli", 11, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
