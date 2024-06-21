using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace GROUP_2
{
    public partial class ManageTrainSchedule : Form
    {
        TrainDBMS trainDBMSobj= new TrainDBMS();

       public ManageTrainSchedule()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string trainName = trainNameBox.Text;
           
            DateTime departureTime = DateTime.Parse(depTimeBox.Text);
            DateTime arrivalTime = DateTime.Parse(arrTimeBox.Text);
            string route = routeBox.Text;
            string departure = fromCity.Text;
            string destination = toCity.Text;
            int capacity = int.Parse(capacityBox.Text);
            decimal fare = decimal.Parse(fareBox.Text);
            string status = Statusbox.Text;

           trainDBMSobj.addTrain( trainName,departureTime, arrivalTime, route, departure, destination, capacity, fare, status);
           reloadPage();
        }
        public void reloadPage()
        {
            DataTable tableData = trainDBMSobj.RetrieveTrain();
            trainscheduleView.DataSource = tableData;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            int tID = int.Parse(trainIDbox.Text);
            trainDBMSobj.deleteTrain(tID);
            reloadPage();

        }

        private void trainNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainscheduleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageTrainSchedule_Load(object sender, EventArgs e)
        {
            reloadPage();

        }

        private void search_Click(object sender, EventArgs e)
        {
            DataTable tableData = trainDBMSobj.retrieveTrainByID(int.Parse(inputBox.Text));
            trainscheduleView.DataSource = tableData;
        }

        private void trainscheduleView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            trainIDbox.Text = trainscheduleView.Rows[rowIndex].Cells[0].Value.ToString();
            trainNameBox.Text = trainscheduleView.Rows[rowIndex].Cells[1].Value.ToString();
            depTimeBox.Text = trainscheduleView.Rows[rowIndex].Cells[3].Value.ToString();
            arrTimeBox.Text = trainscheduleView.Rows[rowIndex].Cells[4].Value.ToString();
            routeBox.Text = trainscheduleView.Rows[rowIndex].Cells[5].Value.ToString();
            fromCity.Text = trainscheduleView.Rows[rowIndex].Cells[6].Value.ToString();
            toCity.Text = trainscheduleView.Rows[rowIndex].Cells[7].Value.ToString();
            capacityBox.Text = trainscheduleView.Rows[rowIndex].Cells[8].Value.ToString();
            fareBox.Text = trainscheduleView.Rows[rowIndex].Cells[9].Value.ToString();
            Statusbox.Text = trainscheduleView.Rows[rowIndex].Cells[10].Value.ToString();

        }

        private void update_Click(object sender, EventArgs e)
        {
            string trainName = trainNameBox.Text;

            DateTime departureTime = DateTime.Parse(depTimeBox.Text);
            DateTime arrivalTime = DateTime.Parse(arrTimeBox.Text);
            string route = routeBox.Text;
            string departure = fromCity.Text;
            string destination = toCity.Text;
            int capacity = int.Parse(capacityBox.Text);
            decimal fare = decimal.Parse(fareBox.Text);
            string status = Statusbox.Text;
            int trainID = int.Parse(trainIDbox.Text);

            trainDBMSobj.UpdateTrain(trainID, trainName, departureTime, arrivalTime, route, departure, destination, capacity, fare, status);
            reloadPage();
        }
    }
}
