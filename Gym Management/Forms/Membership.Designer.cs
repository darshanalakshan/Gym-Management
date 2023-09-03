namespace Gym_Management.Forms
{
    partial class Membershipup
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            memup = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            panel3 = new Panel();
            updatepanel = new Panel();
            labelup = new Label();
            groupBox2 = new GroupBox();
            dpick = new DateTimePicker();
            monthRB = new RadioButton();
            month6RB = new RadioButton();
            error = new Label();
            annualRB = new RadioButton();
            label5 = new Label();
            button2 = new Button();
            amounttext = new TextBox();
            label6 = new Label();
            errorSR = new Label();
            groupBox1 = new GroupBox();
            LSpayvl = new Label();
            label8 = new Label();
            addno = new Label();
            addvl = new Label();
            fname = new Label();
            fnamevl = new Label();
            lname = new Label();
            lnamevl = new Label();
            label7 = new Label();
            button1 = new Button();
            SearchID = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            updatepanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 71);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(973, 14);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "label1";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1042, 43);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "label1";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 1;
            label1.Text = "Membership Update";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memup
            // 
            memup.Enabled = true;
            memup.Tick += memup_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1133, 619);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(updatepanel);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(errorSR);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(SearchID);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1113, 599);
            panel3.TabIndex = 0;
            // 
            // updatepanel
            // 
            updatepanel.Controls.Add(labelup);
            updatepanel.Location = new Point(0, 497);
            updatepanel.Name = "updatepanel";
            updatepanel.Size = new Size(1110, 102);
            updatepanel.TabIndex = 26;
            // 
            // labelup
            // 
            labelup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelup.AutoSize = true;
            labelup.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelup.Location = new Point(480, 35);
            labelup.Name = "labelup";
            labelup.Size = new Size(72, 30);
            labelup.TabIndex = 23;
            labelup.Text = "label9";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dpick);
            groupBox2.Controls.Add(monthRB);
            groupBox2.Controls.Add(month6RB);
            groupBox2.Controls.Add(error);
            groupBox2.Controls.Add(annualRB);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(amounttext);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(21, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 316);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment Details";
            // 
            // dpick
            // 
            dpick.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dpick.Format = DateTimePickerFormat.Custom;
            dpick.Location = new Point(182, 111);
            dpick.Name = "dpick";
            dpick.Size = new Size(200, 25);
            dpick.TabIndex = 16;
            // 
            // monthRB
            // 
            monthRB.AutoSize = true;
            monthRB.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            monthRB.Location = new Point(83, 40);
            monthRB.Name = "monthRB";
            monthRB.Size = new Size(73, 21);
            monthRB.TabIndex = 10;
            monthRB.TabStop = true;
            monthRB.Text = "Monthly";
            monthRB.UseVisualStyleBackColor = true;
            // 
            // month6RB
            // 
            month6RB.AutoSize = true;
            month6RB.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            month6RB.Location = new Point(182, 40);
            month6RB.Name = "month6RB";
            month6RB.Size = new Size(75, 21);
            month6RB.TabIndex = 11;
            month6RB.TabStop = true;
            month6RB.Text = "6 Month";
            month6RB.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            error.Location = new Point(182, 181);
            error.Name = "error";
            error.Size = new Size(43, 17);
            error.TabIndex = 22;
            error.Text = "label9";
            // 
            // annualRB
            // 
            annualRB.AutoSize = true;
            annualRB.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            annualRB.Location = new Point(283, 40);
            annualRB.Name = "annualRB";
            annualRB.Size = new Size(65, 21);
            annualRB.TabIndex = 12;
            annualRB.TabStop = true;
            annualRB.Text = "Annual";
            annualRB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 117);
            label5.Name = "label5";
            label5.Size = new Size(88, 17);
            label5.TabIndex = 14;
            label5.Text = "Payment Date";
            // 
            // button2
            // 
            button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(201, 221);
            button2.Name = "button2";
            button2.Size = new Size(171, 41);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // amounttext
            // 
            amounttext.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            amounttext.Location = new Point(182, 155);
            amounttext.Name = "amounttext";
            amounttext.Size = new Size(200, 25);
            amounttext.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(52, 163);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 18;
            label6.Text = "Amount";
            // 
            // errorSR
            // 
            errorSR.AutoSize = true;
            errorSR.Location = new Point(174, 66);
            errorSR.Name = "errorSR";
            errorSR.Size = new Size(38, 15);
            errorSR.TabIndex = 24;
            errorSR.Text = "label9";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LSpayvl);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(addno);
            groupBox1.Controls.Add(addvl);
            groupBox1.Controls.Add(fname);
            groupBox1.Controls.Add(fnamevl);
            groupBox1.Controls.Add(lname);
            groupBox1.Controls.Add(lnamevl);
            groupBox1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(616, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 316);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Details";
            // 
            // LSpayvl
            // 
            LSpayvl.AutoSize = true;
            LSpayvl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LSpayvl.Location = new Point(260, 239);
            LSpayvl.Name = "LSpayvl";
            LSpayvl.Size = new Size(45, 17);
            LSpayvl.TabIndex = 11;
            LSpayvl.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(72, 239);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 10;
            label8.Text = "Last Payment";
            // 
            // addno
            // 
            addno.AutoSize = true;
            addno.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addno.Location = new Point(72, 59);
            addno.Name = "addno";
            addno.Size = new Size(128, 17);
            addno.TabIndex = 3;
            addno.Text = "Addmission Number";
            addno.Click += addno_Click;
            // 
            // addvl
            // 
            addvl.AutoSize = true;
            addvl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addvl.Location = new Point(260, 59);
            addvl.Name = "addvl";
            addvl.Size = new Size(45, 17);
            addvl.TabIndex = 7;
            addvl.Text = "label5";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(72, 117);
            fname.Name = "fname";
            fname.Size = new Size(71, 17);
            fname.TabIndex = 5;
            fname.Text = "First Name";
            // 
            // fnamevl
            // 
            fnamevl.AutoSize = true;
            fnamevl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fnamevl.Location = new Point(260, 117);
            fnamevl.Name = "fnamevl";
            fnamevl.Size = new Size(45, 17);
            fnamevl.TabIndex = 8;
            fnamevl.Text = "label6";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lname.Location = new Point(72, 179);
            lname.Name = "lname";
            lname.Size = new Size(70, 17);
            lname.TabIndex = 6;
            lname.Text = "Last Name";
            // 
            // lnamevl
            // 
            lnamevl.AutoSize = true;
            lnamevl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lnamevl.Location = new Point(260, 179);
            lnamevl.Name = "lnamevl";
            lnamevl.Size = new Size(45, 17);
            lnamevl.TabIndex = 9;
            lnamevl.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 40);
            label7.Name = "label7";
            label7.Size = new Size(147, 21);
            label7.TabIndex = 20;
            label7.Text = "Addmision Number";
            // 
            // button1
            // 
            button1.Location = new Point(412, 40);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchID
            // 
            SearchID.Location = new Point(174, 40);
            SearchID.MaxLength = 4;
            SearchID.Name = "SearchID";
            SearchID.Size = new Size(213, 23);
            SearchID.TabIndex = 0;
            SearchID.TextChanged += SearchID_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Membershipup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 690);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Membershipup";
            Text = "Membership";
            Load += Membershipup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            updatepanel.ResumeLayout(false);
            updatepanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private System.Windows.Forms.Timer memup;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private TextBox SearchID;
        private ContextMenuStrip contextMenuStrip1;
        private Label lnamevl;
        private Label fnamevl;
        private Label addvl;
        private Label lname;
        private Label fname;
        private Label addno;
        private RadioButton annualRB;
        private RadioButton month6RB;
        private RadioButton monthRB;
        private ContextMenuStrip contextMenuStrip2;
        private Label label5;
        private Button button2;
        private DateTimePicker dpick;
        private TextBox amounttext;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label LSpayvl;
        private Label label8;
        private Label error;
        private Label labelup;
        private Label errorSR;
        private GroupBox groupBox2;
        private Panel updatepanel;
    }
}