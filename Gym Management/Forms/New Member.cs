using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gym_Management.Forms
{
    public partial class New_Member : Form
    {
        //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb";
        public New_Member()
        {
            InitializeComponent();
            this.RightToLeft = RightToLeft.No;
            errorMessagelname.Visible = false;
            errorMessagefname.Visible = false;
            errorMessagemobile.Visible = false;
            checklbl.Visible = false;
            reg.Visible = false;
            checklbl.Visible = false;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_Member_Load(object sender, EventArgs e)
        {
            DobPick.Format = DateTimePickerFormat.Custom;
            DobPick.CustomFormat = "dd MMMM yyyy";
            jdatepick.Format = DateTimePickerFormat.Custom;
            jdatepick.CustomFormat = "dd MMMM yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Fname = txtFname.Text;
            string Lname = txtLname.Text;

            string Gender = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                Gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                Gender = radioButton2.Text;
            }
            string Dob = DobPick.Text;
            string weight = weightvl.Text;
            string height = heightvl.Text;
            string Jdate = jdatepick.Text;
            string emailad = email.Text;

            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text))
            {
                errorMessagefname.Visible = true;
                errorMessagefname.ForeColor = Color.Red;
                errorMessagefname.Text = "*required ";
                errorMessagelname.Visible = true;
                errorMessagelname.ForeColor = Color.Red;
                errorMessagelname.Text = "*required ";
                // Set up a Windows Forms Timer to hide the error message after 2 seconds
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                timer.Tick += (sender, e) =>
                {
                    errorMessagefname.Visible = false;
                    errorMessagelname.Visible = false;
                    timer.Stop(); // Stop the timer after executing the action
                };
                timer.Start();
                return;
            }
            if (!Int64.TryParse(txtMno.Text, out long Mno) || txtMno.Text.Length != 10 || string.IsNullOrWhiteSpace(txtMno.Text))
            {
                errorMessagemobile.Visible = true;
                errorMessagemobile.ForeColor = Color.Red;
                errorMessagemobile.Text = "Please enter a valid mobile number.";
                // Set up a Windows Forms Timer to hide the error message after 2 seconds
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                timer.Tick += (sender, e) =>
                {
                    errorMessagemobile.Visible = false;
                    timer.Stop(); // Stop the timer after executing the action
                };
                timer.Start();
                return;
            }


            bool isRegistrationSuccessful = false;
            try
            {
                errorMessagefname.Text = "";
                errorMessagelname.Text = "";
                errorMessagemobile.Text = "";

                OleDbConnection connectioncheck = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connectioncheck.Open();
                OleDbCommand checkCmd = connectioncheck.CreateCommand();
                checkCmd.CommandType = CommandType.Text;
                checkCmd.CommandText = "SELECT COUNT(*) FROM members WHERE Mno = ? OR Fname = ? ";
                checkCmd.Parameters.AddWithValue("@Mno", Mno);
                checkCmd.Parameters.AddWithValue("@Fname", txtFname.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                connectioncheck.Close();

                if (count > 0)
                {
                    checklbl.Visible = true;
                    reg.Visible = false;
                    checklbl.Visible = true;
                    checklbl.Text = "User already exists.";
                    return; // Stop further execution
                }

                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into members(Fname,Lname,Dob,Mno,Gender,Email,Weight,Height,Jdate)values('" + Fname + "','" + Lname + "','" + Dob + "','" + Mno + "','" + Gender + "','" + emailad + "','" + weight + "','" + height + "','" + Jdate + "')";
                cmd.ExecuteNonQuery();
                isRegistrationSuccessful = true;
                connection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorMessagefname.Text = ex.Message;
                errorMessagefname.Text = ex.Message;

            }

            if (isRegistrationSuccessful)
            {
                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connection.Open();
                OleDbCommand cmd2 = connection.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT Addno FROM members WHERE Fname = @Fname";
                cmd2.Parameters.AddWithValue("@Fname", txtFname.Text);
                OleDbDataReader reader = cmd2.ExecuteReader();
                {
                    string fname = "";
                    while (reader.Read())
                    {

                        fname = reader["Addno"].ToString();


                    }
                    tableLayoutPanel2.BackColor = Color.Green;
                    tableLayoutPanel2.Visible = true;
                    reg.Visible = true;
                    reg.Text = "Welcome " + txtFname.Text + ",\nAdmission number is NF0" + fname + ".";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFname.ResetText();
            txtLname.ResetText();
            DobPick.Value = DateTime.Now;
            txtMno.ResetText();
            weightvl.ResetText();
            heightvl.ResetText();
            email.ResetText();
            jdatepick.Value = DateTime.Now;
            showpanel.BackColor = Color.White;
            reg.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checklbl.Visible = false;

        }

        private void reg_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void jdatepick_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void weightvl_TextChanged(object sender, EventArgs e)
        {

        }

        private void DobPick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }
    }
}
