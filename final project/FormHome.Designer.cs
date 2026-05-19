namespace final_project
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            lblTitle = new Label();
            lblStory = new Label();
            lblName = new Label();
            txtName = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(583, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cat Navigation: Your Campus Club Guide";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblStory
            // 
            lblStory.Font = new Font("微軟正黑體", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblStory.ForeColor = Color.FromArgb(200, 200, 220);
            lblStory.Location = new Point(12, 70);
            lblStory.Name = "lblStory";
            lblStory.Size = new Size(554, 604);
            lblStory.TabIndex = 1;
            lblStory.Text = resources.GetString("lblStory.Text");
            lblStory.TextAlign = ContentAlignment.MiddleLeft;
            lblStory.Click += lblStory_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("微軟正黑體", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(67, 689);
            lblName.Name = "lblName";
            lblName.Size = new Size(191, 28);
            lblName.TabIndex = 2;
            lblName.Text = "Enter your name :\r\n";
            lblName.Click += lblName_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("微軟正黑體", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtName.Location = new Point(276, 686);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 37);
            txtName.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(30, 80, 160);
            btnStart.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(119, 753);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(296, 53);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start the Adventure 🚀\r\n";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(578, 844);
            Controls.Add(btnStart);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblStory);
            Controls.Add(lblTitle);
            Name = "FormHome";
            Text = "Form2";
            Load += FormHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStory;
        private Label lblName;
        private TextBox txtName;
        private Button btnStart;
    }
}