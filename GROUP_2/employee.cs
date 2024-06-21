using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GROUP_2
{
    public partial class employee : Form
    {
        string emailCred, accTF;
        public employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           empProfile obj = new empProfile();
            obj.sendCredentials(emailCred, accTF);
            obj.ShowDialog();
        }

        private void ticketSelling_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void sendCredentials(string email, string accT)
        {
            emailCred = email;
            accTF = accT;
        }
    }
}
