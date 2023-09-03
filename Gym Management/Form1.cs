namespace Gym_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Gym_Management.Forms.Dashboard child = new Gym_Management.Forms.Dashboard() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Gym_Management.Forms.Dashboard child = new Gym_Management.Forms.Dashboard() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
        }

        private void btnworkoutplan_Click(object sender, EventArgs e)
        {
            Gym_Management.Forms.Workout_Plan child = new Gym_Management.Forms.Workout_Plan() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();

        }

        private void btnmembership_Click(object sender, EventArgs e)
        {
            Gym_Management.Forms.Membershipup child = new Gym_Management.Forms.Membershipup() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
        }

        private void btnstore_Click(object sender, EventArgs e)
        {
            Gym_Management.Forms.Store child = new Gym_Management.Forms.Store() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
        }

        private void btnnewmember_Click(object sender, EventArgs e)
        {
            Gym_Management.Forms.New_Member child = new Gym_Management.Forms.New_Member() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            Gym_Management.Forms.Setting child = new Gym_Management.Forms.Setting() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.BringToFront();
            child.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Maximized*/

            ;
        }
    }
}