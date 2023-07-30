namespace Gym_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnnewmember = new Button();
            btnsetting = new Button();
            btnstore = new Button();
            btnmembership = new Button();
            btnworkoutplan = new Button();
            btndashboard = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnnewmember);
            panel1.Controls.Add(btnsetting);
            panel1.Controls.Add(btnstore);
            panel1.Controls.Add(btnmembership);
            panel1.Controls.Add(btnworkoutplan);
            panel1.Controls.Add(btndashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 678);
            panel1.TabIndex = 0;
            // 
            // btnnewmember
            // 
            btnnewmember.Dock = DockStyle.Bottom;
            btnnewmember.FlatAppearance.BorderSize = 0;
            btnnewmember.FlatAppearance.MouseOverBackColor = Color.Red;
            btnnewmember.FlatStyle = FlatStyle.Flat;
            btnnewmember.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnnewmember.ForeColor = Color.Black;
            btnnewmember.Image = (Image)resources.GetObject("btnnewmember.Image");
            btnnewmember.Location = new Point(0, 558);
            btnnewmember.Name = "btnnewmember";
            btnnewmember.Size = new Size(230, 60);
            btnnewmember.TabIndex = 1;
            btnnewmember.Text = "New Member";
            btnnewmember.TextAlign = ContentAlignment.MiddleLeft;
            btnnewmember.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnnewmember.UseVisualStyleBackColor = true;
            btnnewmember.Click += btnnewmember_Click;
            // 
            // btnsetting
            // 
            btnsetting.Dock = DockStyle.Bottom;
            btnsetting.FlatAppearance.BorderSize = 0;
            btnsetting.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 73, 172);
            btnsetting.FlatStyle = FlatStyle.Flat;
            btnsetting.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnsetting.ForeColor = Color.Black;
            btnsetting.Image = (Image)resources.GetObject("btnsetting.Image");
            btnsetting.Location = new Point(0, 618);
            btnsetting.Name = "btnsetting";
            btnsetting.Size = new Size(230, 60);
            btnsetting.TabIndex = 1;
            btnsetting.Text = "Setting";
            btnsetting.TextAlign = ContentAlignment.MiddleLeft;
            btnsetting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnsetting.UseVisualStyleBackColor = true;
            btnsetting.Click += btnsetting_Click;
            // 
            // btnstore
            // 
            btnstore.Dock = DockStyle.Top;
            btnstore.FlatAppearance.BorderSize = 0;
            btnstore.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 154, 46);
            btnstore.FlatStyle = FlatStyle.Flat;
            btnstore.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnstore.ForeColor = Color.Black;
            btnstore.Image = (Image)resources.GetObject("btnstore.Image");
            btnstore.ImageAlign = ContentAlignment.MiddleRight;
            btnstore.Location = new Point(0, 330);
            btnstore.Name = "btnstore";
            btnstore.Size = new Size(230, 60);
            btnstore.TabIndex = 1;
            btnstore.Text = "Store";
            btnstore.TextAlign = ContentAlignment.MiddleLeft;
            btnstore.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnstore.UseVisualStyleBackColor = true;
            btnstore.Click += btnstore_Click;
            // 
            // btnmembership
            // 
            btnmembership.Dock = DockStyle.Top;
            btnmembership.FlatAppearance.BorderSize = 0;
            btnmembership.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 73, 172);
            btnmembership.FlatStyle = FlatStyle.Flat;
            btnmembership.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnmembership.ForeColor = Color.Black;
            btnmembership.Image = (Image)resources.GetObject("btnmembership.Image");
            btnmembership.ImageAlign = ContentAlignment.MiddleRight;
            btnmembership.Location = new Point(0, 270);
            btnmembership.Name = "btnmembership";
            btnmembership.Size = new Size(230, 60);
            btnmembership.TabIndex = 1;
            btnmembership.Text = "Membership";
            btnmembership.TextAlign = ContentAlignment.MiddleLeft;
            btnmembership.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnmembership.UseVisualStyleBackColor = true;
            btnmembership.Click += btnmembership_Click;
            // 
            // btnworkoutplan
            // 
            btnworkoutplan.Dock = DockStyle.Top;
            btnworkoutplan.FlatAppearance.BorderSize = 0;
            btnworkoutplan.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 73, 172);
            btnworkoutplan.FlatStyle = FlatStyle.Flat;
            btnworkoutplan.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnworkoutplan.ForeColor = Color.Black;
            btnworkoutplan.Image = (Image)resources.GetObject("btnworkoutplan.Image");
            btnworkoutplan.ImageAlign = ContentAlignment.MiddleRight;
            btnworkoutplan.Location = new Point(0, 210);
            btnworkoutplan.Name = "btnworkoutplan";
            btnworkoutplan.Size = new Size(230, 60);
            btnworkoutplan.TabIndex = 1;
            btnworkoutplan.Text = "Workout Plan";
            btnworkoutplan.TextAlign = ContentAlignment.MiddleRight;
            btnworkoutplan.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnworkoutplan.UseVisualStyleBackColor = true;
            btnworkoutplan.Click += btnworkoutplan_Click;
            // 
            // btndashboard
            // 
            btndashboard.Dock = DockStyle.Top;
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 73, 172);
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndashboard.ForeColor = Color.Black;
            btndashboard.Image = Properties.Resources.diagram;
            btndashboard.ImageAlign = ContentAlignment.MiddleRight;
            btndashboard.Location = new Point(0, 150);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(230, 60);
            btndashboard.TabIndex = 1;
            btndashboard.Text = "Dashboard";
            btndashboard.TextAlign = ContentAlignment.MiddleRight;
            btndashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btndashboard.UseVisualStyleBackColor = true;
            btndashboard.Click += btndashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 150);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 247, 255);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(230, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1051, 678);
            panel3.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1281, 678);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Gym Management ";
            TransparencyKey = Color.WhiteSmoke;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btndashboard;
        private Button btnnewmember;
        private Button btnsetting;
        private Button btnmembership;
        private Button btnworkoutplan;
        private Panel panel3;
        private Button btnstore;
    }
}