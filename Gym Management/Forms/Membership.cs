using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Gym_Management.Forms
{
    public partial class Membershipup : Form
    {
        private string AddnoValue;
        public Membershipup()
        {
            InitializeComponent();
            this.RightToLeft = RightToLeft.No;
            monthRB.Checked = true;
            dpick.Enabled = false;
            errorSR.Visible = false;
            error.Visible = false;
            labelup.Visible = false;
            addvl.Visible = false;
            fnamevl.Visible = false;
            lnamevl.Visible = false;
            LSpayvl.Visible = false;
            dpick.Format = DateTimePickerFormat.Custom;
            dpick.CustomFormat = "dd MMMM yyyy";

        }

        private void memup_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("MMMM");
            label3.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            label2.Text = DateTime.Now.ToString("T");

        }

        private void Membershipup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = SearchID.Text;
            if (!Int64.TryParse(SearchID.Text, out long Mno) || SearchID.Text.Length != 4 || string.IsNullOrWhiteSpace(SearchID.Text))
            {
                errorSR.Visible = true;
                errorSR.ForeColor = Color.Red;
                errorSR.Text = "Addmision Number not Valid";
                // Set up a Windows Forms Timer to hide the error message after 2 seconds
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                timer.Tick += (sender, e) =>
                {
                    errorSR.Visible = false;
                    timer.Stop(); // Stop the timer after executing the action
                };
                timer.Start();
                return;
            }

            try
            {

                OleDbConnection connectioncheck = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connectioncheck.Open();
                OleDbCommand checkCmd = connectioncheck.CreateCommand();
                checkCmd.CommandType = CommandType.Text;
                checkCmd.CommandText = "SELECT Fname AS FirstNameColumn, Lname AS LastNameColumn, Addno AS AddNoColumn FROM members WHERE Addno = ?";
                checkCmd.Parameters.AddWithValue("@Addno", ID);
                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    OleDbDataReader reader = checkCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader["FirstNameColumn"].ToString();
                        string lastName = reader["LastNameColumn"].ToString();
                        string Addno = reader["AddNoColumn"].ToString();

                        fnamevl.Visible = true;
                        lnamevl.Visible = true;
                        addvl.Visible = true;

                        fnamevl.Text = $"{firstName}";
                        lnamevl.Text = $" {lastName}";
                        addvl.Text = $"NF{Addno}";
                        AddnoValue = Addno;

                    }
                    else
                    {
                        errorSR.Text = "Invalid Addmission Number lol";
                    }

                    reader.Close();

                }
                else
                {
                    errorSR.Visible = true;
                    errorSR.ForeColor = Color.Red;
                    errorSR.Text = "Addmision Number not Valid";
                    // Set up a Windows Forms Timer to hide the error message after 2 seconds
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                    timer.Tick += (sender, e) =>
                    {
                        errorSR.Visible = false;
                        timer.Stop(); // Stop the timer after executing the action
                    };
                    timer.Start();
                    return;
                }
                checkCmd.CommandText = "SELECT TOP 1 PaymentMonth AS PaymentMonthColumn FROM payment WHERE Addno = ? ORDER BY PaymentDate ASC";
                checkCmd.Parameters.AddWithValue("@Addno", ID);
                object result2 = checkCmd.ExecuteScalar();
                {
                    if (result2 != null)
                    {
                        OleDbDataReader reader = checkCmd.ExecuteReader();

                        if (reader.Read())
                        {

                            string Paymentmonth = reader["PaymentMonthColumn"].ToString();

                            LSpayvl.Visible = true;
                            LSpayvl.Text = $"{Paymentmonth}";

                        }
                        reader.Close();
                    }
                    else
                    {
                        LSpayvl.Visible = true;
                        LSpayvl.Text = "Payment not Updated yet";

                    }

                }
                //else
                //{

                //    label4.Text = "User not Found.";
                //    // Member with the given Addno does not exist
                //    // You might want to show an error message
                //}
            }
            catch (Exception ex)
            {
                // Handle and display the exception message
                labelup.Text = $"An error occurred: {ex.Message}";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dpick.Value;
            int selectedMonth = selectedDate.Month;
            int selectedYear = selectedDate.Year;
            string Pmonth = $"{selectedYear}-{selectedMonth:D2}";
            DateTimeFormatInfo dateFormat = CultureInfo.CurrentCulture.DateTimeFormat;

            //string Pmonth = dateFormat.GetMonthName(selectedMonth);
            string MemType = "";
            string Paydate = dpick.Text;
            bool isCheked = monthRB.Checked;
            string amount = amounttext.Text;
            string Addno = AddnoValue;
            if (isCheked)
            {
                MemType = monthRB.Text;
            }
            else if (month6RB.Checked)
            {
                MemType = month6RB.Text;
            }
            else if (annualRB.Checked)
            {
                MemType = annualRB.Text;
            }
            if (string.IsNullOrWhiteSpace(amounttext.Text))
            {
                error.Visible = true;
                error.ForeColor = Color.Red;
                error.Text = "Please enter a valid Amount";
                // Set up a Windows Forms Timer to hide the error message after 2 seconds
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                timer.Tick += (sender, e) =>
                {
                    error.Visible = false;
                    timer.Stop(); // Stop the timer after executing the action
                };
                timer.Start();
                return;
            }
            if (string.IsNullOrEmpty(Addno))
            {
                errorSR.Visible = true;
                errorSR.ForeColor = Color.Red;
                errorSR.Text = "Addmision Number not Valid";
                // Set up a Windows Forms Timer to hide the error message after 2 seconds
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                timer.Tick += (sender, e) =>
                {
                    errorSR.Visible = false;
                    timer.Stop(); // Stop the timer after executing the action
                };
                timer.Start();
                return;
            }


            bool isRegistrationSuccessful = false;
            try
            {
                OleDbConnection connectioncheck = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connectioncheck.Open();
                OleDbCommand checkCmd = connectioncheck.CreateCommand();
                checkCmd.CommandType = CommandType.Text;
                checkCmd.CommandText = "SELECT COUNT(*) FROM payment WHERE PaymentMonth = ? AND Addno = ?";
                checkCmd.Parameters.AddWithValue("@PaymentMonth", Pmonth);
                checkCmd.Parameters.AddWithValue("@Addno", Addno);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                connectioncheck.Close();

                if (count > 0)
                {
                    updatepanel.Visible = true;
                    updatepanel.BackColor = Color.Red;
                    labelup.Visible = true;
                    labelup.Text = "User already Paid.";
                    return; // Stop further execution
                }
                else
                {
                    labelup.Text = "New User";
                }

                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into payment(Addno,PaymentDate,PaymentMonth,PaymentAmount,PaymentType)values('" + Addno + "','" + Paydate + "','" + Pmonth + "','" + amount + "','" + MemType + "')";
                cmd.ExecuteNonQuery();
                isRegistrationSuccessful = true;
                connection.Close();

                if (isRegistrationSuccessful)
                {
                    updatepanel.Visible = true;
                    labelup.Visible = true;
                    updatepanel.BackColor = Color.Green;
                    labelup.Text = "Payment Updated";
                    // Set up a Windows Forms Timer to hide the error message after 2 seconds
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                    timer.Tick += (sender, e) =>
                    {
                        updatepanel.Visible = false;
                        labelup.Visible = false;
                        fnamevl.Visible = false;
                        lnamevl.Visible = false;
                        addvl.Visible = false;
                        LSpayvl.Visible = false;
                        timer.Stop(); // Stop the timer after executing the action
                    };
                    timer.Start();
                    return;
                }
            }
            catch (Exception ex)
            {
                // Handle and display the exception message
                labelup.Text = $"An error occurred: {ex.Message}";
            }
        }

        private void SearchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void addno_Click(object sender, EventArgs e)
        {

        }
    }
}


