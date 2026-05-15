using System.Drawing.Drawing2D;

namespace 結果圖1
{
    public partial class result2 : Form
    {
        public result2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel1.Width - 1,
                panel1.Height - 1
            );

            RoundPanel(panel1, 10);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel2.Width - 1,
                panel2.Height - 1
            );

            RoundPanel(panel2, 10);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel3.Width - 1,
                panel3.Height - 1
            );

            RoundPanel(panel3, 10);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel4.Width - 1,
                panel4.Height - 1
            );

            RoundPanel(panel4, 10);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel5.Width - 1,
                panel5.Height - 1
            );

            RoundPanel(panel5, 10);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        //框框圓角
        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            RoundPanel(panel7, 30);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            RoundPanel(panel8, 30);
        }

        private void result1_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            RoundPanel(panel9, 30);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            RoundPanel(panel10, 30);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            RoundPanel(panel11, 30);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel14.Width - 1,
                panel14.Height - 1
            );

            RoundPanel(panel14, 30);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel15.Width - 1,
                panel15.Height - 1
            );

            RoundPanel(panel15, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //鼠標移到button1放大效果

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(392, 772);
            button1.Size = new Size(182, 46);
            button1.Font = new Font("Gill Sans Ultra Bold", 10);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(140, 35);
            button1.Font = new Font("Gill Sans Ultra Bold", 8);
            button1.Location = new Point(413, 777);
        }

        //鼠標移到linkLabel1字變白色
        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.White;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.FromArgb(17, 51, 23);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }

}
