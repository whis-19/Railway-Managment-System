using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_2
{
    public partial class admin : Form
    {
        string email, accT;
        public admin()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageTrainSchedule obj = new ManageTrainSchedule();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedback obj = new feedback();
            obj.ShowDialog();
        }

        private void mngEmployees_Click(object sender, EventArgs e)
        {
            manageEmployees obj = new manageEmployees();
            obj.ShowDialog();
        }

        private void checkProfile_Click(object sender, EventArgs e)
        {
            adminProfile obj = new adminProfile();
            obj.sendCredentials(email, accT);
            obj.ShowDialog();
        }

        private void viewTrains_Click(object sender, EventArgs e)
        {
            viewTrains obj = new viewTrains();
            obj.ShowDialog();
        }

        private void assignTask_Click(object sender, EventArgs e)
        {
            manageEmployees obj = new manageEmployees();
            obj.ShowDialog();
        }
        public void sendCredentials(string emailF,string accTF)
        {
            email = emailF;
            accT = accTF;
        }
        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
