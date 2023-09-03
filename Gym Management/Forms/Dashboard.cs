using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management.Forms
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            this.RightToLeft = RightToLeft.No;
            PaymentDash.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dayntime.Start();
        }

        private void month_Tick(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void dayntime_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MMMM");
            label3.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            label2.Text = DateTime.Now.ToString("T");

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UID = SearchDash.Text;
            DateTime now = DateTime.Now;
            string UIDlg = "NF" + UID + "";
            string Timelg = now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                OleDbConnection connectioncheck = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\Visual Studio\Gym Management\Gym Management\Gym Management\Database\Memberdetails.accdb");
                connectioncheck.Open();
                OleDbCommand checkCmd = connectioncheck.CreateCommand();
                checkCmd.CommandType = CommandType.Text;
                //checkCmd.CommandText = "SELECT TOP 1 PaymentMonth AS PaymentMonthColumn FROM payment WHERE Addno = ? ORDER BY PaymentDate DESC";
                checkCmd.CommandText = "SELECT TOP 1 PaymentMonth AS PaymentMonthColumn FROM payment WHERE Addno = ? ORDER BY PaymentDate ASC";
                checkCmd.Parameters.AddWithValue("@Addno", UID);
                object result2 = checkCmd.ExecuteScalar();

                    if (result2 != null)
                    {

                        string Paymentmonth = result2.ToString();

                        DateTime now1 = DateTime.Now;
                        int selectedMonth = now.Month;
                        int selectedYear = now.Year;
                        string Curmonth = $"{selectedYear}-{selectedMonth:D2}";

                        if (Paymentmonth == Curmonth)
                        {
                            {
                                PaymentDash.Visible = true;
                                panel7.Visible = true;
                                PaymentDash.Text = "Membership Valid";
                                panel7.BackColor = Color.Green;
                                // Set up a Windows Forms Timer to hide the error message after 2 seconds
                                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                                timer.Interval = 1000; // 2000 milliseconds = 2 seconds
                                timer.Tick += (sender, e) =>
                                {
                                    panel7.BackColor = Color.FromArgb(255, 128, 128);
                                    PaymentDash.Visible = false;
                                    timer.Stop(); // Stop the timer after executing the action
                                };
                                timer.Start();
                            }

                            //PaymentDash.Visible = true;
                            //PaymentDash.Text = $"{Paymentmonth}";

                        }
                        else
                        {
                            PaymentDash.Text = "Not Paid for this Month";
                        }
                    }
                    else
                    {
                        PaymentDash.Visible = true;
                        PaymentDash.Text = "Enter valid Addmission Number";
                    }


                checkCmd.CommandText = "SELECT  Fname FROM members WHERE Addno = ? ";
                checkCmd.Parameters.AddWithValue("@Addno", UID);
                object Fname = checkCmd.ExecuteScalar();
                //int Timelg1 = 34;
                checkCmd.CommandText = "INSERT into timelog([Time],Addno,Fname)values('" + Timelg + "','" + UIDlg + "','" + Fname + "')";
                checkCmd.ExecuteNonQuery();
                connectioncheck.Close();

            }
            catch (Exception ex)
            {
                // Handle and display the exception message
                PaymentDash.Text = $"An error occurred: {ex.Message}";
            }
        }
    }
}
