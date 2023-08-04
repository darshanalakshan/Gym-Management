namespace Gym_Management.Forms
{
    partial class New_Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Member));
            label1 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            reg = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label2 = new Label();
            txtFname = new TextBox();
            label7 = new Label();
            label3 = new Label();
            txtLname = new TextBox();
            DobPick = new DateTimePicker();
            label6 = new Label();
            txtMno = new TextBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            showpanel = new Panel();
            button1 = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            button2 = new Button();
            label16 = new Label();
            checklbl = new Label();
            label15 = new Label();
            label11 = new Label();
            label14 = new Label();
            errorMessagemobile = new Label();
            label13 = new Label();
            errorMessagelname = new Label();
            label9 = new Label();
            errorMessagefname = new Label();
            memtype = new ComboBox();
            label8 = new Label();
            label10 = new Label();
            jdatepick = new DateTimePicker();
            perfit = new ComboBox();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            showpanel.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 17);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 30);
            label1.TabIndex = 0;
            label1.Text = "Member Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 71);
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1001, 27);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(273, 13);
            label12.TabIndex = 1;
            label12.Text = "Join Our Gym and Start Your Fitness Journey Today";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reg
            // 
            reg.AutoSize = true;
            reg.Dock = DockStyle.Fill;
            reg.Location = new Point(70, 43);
            reg.Name = "reg";
            reg.Size = new Size(195, 129);
            reg.TabIndex = 0;
            reg.Text = "label20";
            reg.TextAlign = ContentAlignment.MiddleCenter;
            reg.Click += reg_Click;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(298, 336);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 25);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(192, 336);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 25);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 336);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFname.BorderStyle = BorderStyle.FixedSingle;
            txtFname.Location = new Point(192, 71);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(162, 29);
            txtFname.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(40, 204);
            label7.Name = "label7";
            label7.Size = new Size(115, 19);
            label7.TabIndex = 13;
            label7.Text = "Mobile Number";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 137);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLname.BorderStyle = BorderStyle.FixedSingle;
            txtLname.Location = new Point(192, 133);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(162, 29);
            txtLname.TabIndex = 1;
            // 
            // DobPick
            // 
            DobPick.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DobPick.Format = DateTimePickerFormat.Custom;
            DobPick.Location = new Point(192, 267);
            DobPick.Name = "DobPick";
            DobPick.Size = new Size(162, 29);
            DobPick.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 275);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 11;
            label6.Text = "Date of Birth";
            // 
            // txtMno
            // 
            txtMno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMno.Location = new Point(192, 199);
            txtMno.MaxLength = 10;
            txtMno.Name = "txtMno";
            txtMno.Size = new Size(162, 29);
            txtMno.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(245, 247, 255);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1280, 848);
            panel2.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1260, 828);
            tableLayoutPanel1.TabIndex = 23;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(showpanel);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(checklbl);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(errorMessagemobile);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(errorMessagelname);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(errorMessagefname);
            panel3.Controls.Add(memtype);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(jdatepick);
            panel3.Controls.Add(txtMno);
            panel3.Controls.Add(perfit);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(DobPick);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(txtFname);
            panel3.Controls.Add(txtLname);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(750, 822);
            panel3.TabIndex = 3;
            // 
            // showpanel
            // 
            showpanel.BackColor = Color.White;
            showpanel.Controls.Add(tableLayoutPanel2);
            showpanel.Location = new Point(395, 445);
            showpanel.Name = "showpanel";
            showpanel.Size = new Size(336, 215);
            showpanel.TabIndex = 21;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 73, 172);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(38, 706);
            button1.Name = "button1";
            button1.Size = new Size(164, 53);
            button1.TabIndex = 19;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.Location = new Point(621, 252);
            label19.Name = "label19";
            label19.Size = new Size(89, 21);
            label19.TabIndex = 6;
            label19.Text = "Rs.3000.00";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label18.AutoSize = true;
            label18.Location = new Point(621, 178);
            label18.Name = "label18";
            label18.Size = new Size(89, 21);
            label18.TabIndex = 5;
            label18.Text = "Rs.2500.00";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.Location = new Point(397, 244);
            label17.Name = "label17";
            label17.Size = new Size(192, 21);
            label17.TabIndex = 4;
            label17.Text = "🔹 Workout + Treadmill";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 73, 172);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(217, 706);
            button2.Name = "button2";
            button2.Size = new Size(164, 53);
            button2.TabIndex = 20;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.Location = new Point(397, 170);
            label16.Name = "label16";
            label16.Size = new Size(101, 21);
            label16.TabIndex = 3;
            label16.Text = "🔹 Workout";
            // 
            // checklbl
            // 
            checklbl.AutoSize = true;
            checklbl.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checklbl.ForeColor = Color.Crimson;
            checklbl.Location = new Point(520, 334);
            checklbl.Name = "checklbl";
            checklbl.Size = new Size(49, 17);
            checklbl.TabIndex = 16;
            checklbl.Text = "label20";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.Location = new Point(621, 109);
            label15.Name = "label15";
            label15.Size = new Size(89, 21);
            label15.TabIndex = 2;
            label15.Text = "Rs.1000.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 412);
            label11.Name = "label11";
            label11.Size = new Size(236, 25);
            label11.TabIndex = 0;
            label11.Text = "Membership Information";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(397, 97);
            label14.Name = "label14";
            label14.Size = new Size(143, 19);
            label14.TabIndex = 1;
            label14.Text = "🔹 ADMISSION FREE";
            // 
            // errorMessagemobile
            // 
            errorMessagemobile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorMessagemobile.AutoSize = true;
            errorMessagemobile.Font = new Font("Calibri", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            errorMessagemobile.Location = new Point(192, 231);
            errorMessagemobile.Name = "errorMessagemobile";
            errorMessagemobile.Size = new Size(42, 13);
            errorMessagemobile.TabIndex = 15;
            errorMessagemobile.Text = "label20";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(479, 19);
            label13.Name = "label13";
            label13.Size = new Size(158, 25);
            label13.TabIndex = 0;
            label13.Text = "Membership Fee";
            // 
            // errorMessagelname
            // 
            errorMessagelname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorMessagelname.AutoSize = true;
            errorMessagelname.Font = new Font("Calibri", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            errorMessagelname.Location = new Point(192, 165);
            errorMessagelname.Name = "errorMessagelname";
            errorMessagelname.Size = new Size(42, 13);
            errorMessagelname.TabIndex = 14;
            errorMessagelname.Text = "label20";
            errorMessagelname.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(40, 484);
            label9.Name = "label9";
            label9.Size = new Size(129, 19);
            label9.TabIndex = 17;
            label9.Text = "Membership Type";
            // 
            // errorMessagefname
            // 
            errorMessagefname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorMessagefname.AutoSize = true;
            errorMessagefname.Font = new Font("Calibri", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            errorMessagefname.Location = new Point(192, 103);
            errorMessagefname.Name = "errorMessagefname";
            errorMessagefname.Size = new Size(42, 13);
            errorMessagefname.TabIndex = 14;
            errorMessagefname.Text = "label20";
            // 
            // memtype
            // 
            memtype.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            memtype.DropDownStyle = ComboBoxStyle.DropDownList;
            memtype.FlatStyle = FlatStyle.System;
            memtype.FormattingEnabled = true;
            memtype.Items.AddRange(new object[] { "Monthly", "6 Months", "12 Months" });
            memtype.Location = new Point(187, 479);
            memtype.Name = "memtype";
            memtype.RightToLeft = RightToLeft.No;
            memtype.Size = new Size(167, 29);
            memtype.TabIndex = 18;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(40, 552);
            label8.Name = "label8";
            label8.Size = new Size(122, 19);
            label8.TabIndex = 15;
            label8.Text = "Preferred Fitness";
            // 
            // label10
            // 
            label10.AccessibleRole = AccessibleRole.None;
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(201, 25);
            label10.TabIndex = 1;
            label10.Text = "Personal Information";
            // 
            // jdatepick
            // 
            jdatepick.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jdatepick.Format = DateTimePickerFormat.Custom;
            jdatepick.Location = new Point(187, 611);
            jdatepick.Name = "jdatepick";
            jdatepick.Size = new Size(167, 29);
            jdatepick.TabIndex = 10;
            // 
            // perfit
            // 
            perfit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            perfit.DisplayMember = "Select Package Type";
            perfit.DropDownStyle = ComboBoxStyle.DropDownList;
            perfit.FlatStyle = FlatStyle.System;
            perfit.FormattingEnabled = true;
            perfit.Items.AddRange(new object[] { "Workout", "Workout + Treadmill" });
            perfit.Location = new Point(187, 547);
            perfit.Name = "perfit";
            perfit.RightToLeft = RightToLeft.No;
            perfit.Size = new Size(167, 29);
            perfit.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 619);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 9;
            label5.Text = "Join Date";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(759, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(498, 822);
            panel6.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 822);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(reg, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(336, 215);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // New_Member
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 255);
            ClientSize = new Size(1284, 918);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "New_Member";
            Text = "New_Member";
            Load += New_Member_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            showpanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Label label2;
        private TextBox txtFname;
        private Label label7;
        private Label label3;
        private TextBox txtLname;
        private DateTimePicker DobPick;
        private Label label6;
        private TextBox txtMno;
        private Panel panel2;
        private Panel panel3;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
        private Panel panel6;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label errorMessagefname;
        private Label errorMessagemobile;
        private Label errorMessagelname;
        private Label checklbl;
        private Label reg;
        private Button button2;
        private Label label11;
        private Button button1;
        private Label label9;
        private ComboBox memtype;
        private Label label8;
        private DateTimePicker jdatepick;
        private ComboBox perfit;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel showpanel;
        private TableLayoutPanel tableLayoutPanel2;
    }
}