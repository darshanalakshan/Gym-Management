using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
