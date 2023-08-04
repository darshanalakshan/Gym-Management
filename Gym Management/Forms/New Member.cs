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
            string Mtype = memtype.Text;
            string Pfit = perfit.Text;
            string Jdate = jdatepick.Text;

            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text))
            {
                errorMessagefname.Visible = true;
                errorMessagefname.Text = "*required ";
                errorMessagelname.Visible = true;
                errorMessagelname.Text = "*required ";
                return;
            }
            if (!Int64.TryParse(txtMno.Text, out long Mno) || txtMno.Text.Length != 10 || string.IsNullOrWhiteSpace(txtMno.Text))
            {
                errorMessagemobile.Visible = true;
                errorMessagemobile.Text = "Please enter a valid mobile number.";
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
                    checklbl.Text = "User already exists.";
                    return; // Stop further execution
                }

                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into members(Fname,Lname,Dob,Mno,Gender,Mtype,Pfit,Jdate)values('" + Fname + "','" + Lname + "','" + Dob + "','" + Mno + "','" + Gender + "','" + Mtype + "','" + Pfit + "','" + Jdate + "')";
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
                    showpanel.BackColor = Color.Green;
                    showpanel.Visible = true;
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
            memtype.SelectedIndex = -1;
            perfit.SelectedIndex = -1;
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
    }
}
