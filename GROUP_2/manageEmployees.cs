using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Oracle.ManagedDataAccess.Client;

namespace GROUP_2
{
    public partial class manageEmployees : Form
    {
        empDBMS empDBMSobj = new empDBMS();
        public manageEmployees()
        {
            InitializeComponent();
        }

        private void employeesView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void manageEmployees_Load(object sender, EventArgs e)
        {
            DataTable dt = empDBMSobj.RetriveEMP();
            employeesView.DataSource = dt;

        }

        private void search_Click(object sender, EventArgs e)
        {
            DataTable dt = empDBMSobj.RETRIVEbyID(int.Parse(inputBox.Text));
            employeesView.DataSource = dt;
        }

        private void employeesView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            empIDbox.Text = employeesView.Rows[rowIndex].Cells[0].Value.ToString();
            empNameBox.Text = employeesView.Rows[rowIndex].Cells[1].Value.ToString();
            emailBox.Text = employeesView.Rows[rowIndex].Cells[2].Value.ToString();
            passwordBox.Text = employeesView.Rows[rowIndex].Cells[3].Value.ToString();
            categoryBox.Text = employeesView.Rows[rowIndex].Cells[4].Value.ToString();
            taskbox.Text = employeesView.Rows[rowIndex].Cells[5].Value.ToString();
            salaryBOX.Text = employeesView.Rows[rowIndex].Cells[6].Value.ToString();
            addressBOX.Text = employeesView.Rows[rowIndex].Cells[7].Value.ToString();
            contactBOX.Text = employeesView.Rows[rowIndex].Cells[8].Value.ToString();
            cnic.Text = employeesView.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void Task_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            empDBMSobj.EmployeeID = int.Parse(empIDbox.Text);
            empDBMSobj.Name = empNameBox.Text;
            empDBMSobj.Email = emailBox.Text;
            empDBMSobj.Password = passwordBox.Text;
            empDBMSobj.PhoneNumber = contactBOX.Text;
            empDBMSobj.category = categoryBox.Text;
            empDBMSobj.Task = taskbox.Text;
            empDBMSobj.Salary = decimal.Parse(salaryBOX.Text);
            empDBMSobj.Address = addressBOX.Text;
            empDBMSobj.CNIC = cnic.Text;


            empDBMSobj.addEMP();
            ReloadGRID();
        }
        private void ReloadGRID()
        {
            DataTable dt = empDBMSobj.RetriveEMP();
            employeesView.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            empDBMSobj.EmployeeID = int.Parse(empIDbox.Text);
            empDBMSobj.Name = empNameBox.Text;
            empDBMSobj.Email = emailBox.Text;
            empDBMSobj.Password = passwordBox.Text;
            empDBMSobj.PhoneNumber = contactBOX.Text;
            empDBMSobj.category = categoryBox.Text;
            empDBMSobj.Task = taskbox.Text;
            empDBMSobj.Salary = decimal.Parse(salaryBOX.Text);
            empDBMSobj.Address = addressBOX.Text;
            empDBMSobj.CNIC = cnic.Text;

            empDBMSobj.updateEMP();
            ReloadGRID();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            empDBMSobj.deleteEMP(int.Parse(employeeID.Text));
            ReloadGRID();
        }

        private void assignTask_Click(object sender, EventArgs e)
        {
            empDBMSobj.Task = taskbox.Text;
            empDBMSobj.assignTask();
            ReloadGRID();
        }

        private void employeesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
