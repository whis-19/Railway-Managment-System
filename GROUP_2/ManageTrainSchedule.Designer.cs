namespace GROUP_2
{
    partial class ManageTrainSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.trainName = new System.Windows.Forms.Label();
            this.trainID = new System.Windows.Forms.Label();
            this.arrivalCity = new System.Windows.Forms.Label();
            this.departureCity = new System.Windows.Forms.Label();
            this.trainNameBox = new System.Windows.Forms.TextBox();
            this.trainIDbox = new System.Windows.Forms.TextBox();
            this.trainscheduleView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.capacity = new System.Windows.Forms.Label();
            this.route = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.Label();
            this.departureTime = new System.Windows.Forms.Label();
            this.routeBox = new System.Windows.Forms.TextBox();
            this.depTimeBox = new System.Windows.Forms.TextBox();
            this.arrTimeBox = new System.Windows.Forms.TextBox();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.fareBox = new System.Windows.Forms.TextBox();
            this.Statusbox = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.fare = new System.Windows.Forms.Label();
            this.fromCity = new System.Windows.Forms.ComboBox();
            this.toCity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(238, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(423, 41);
            this.title.TabIndex = 14;
            this.title.Text = "Manage Train Schedule";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // trainName
            // 
            this.trainName.AutoSize = true;
            this.trainName.Location = new System.Drawing.Point(34, 218);
            this.trainName.Name = "trainName";
            this.trainName.Size = new System.Drawing.Size(81, 16);
            this.trainName.TabIndex = 15;
            this.trainName.Text = "Train Name:";
            // 
            // trainID
            // 
            this.trainID.AutoSize = true;
            this.trainID.Location = new System.Drawing.Point(34, 176);
            this.trainID.Name = "trainID";
            this.trainID.Size = new System.Drawing.Size(57, 16);
            this.trainID.TabIndex = 16;
            this.trainID.Text = "Train ID:";
            // 
            // arrivalCity
            // 
            this.arrivalCity.AutoSize = true;
            this.arrivalCity.Location = new System.Drawing.Point(34, 293);
            this.arrivalCity.Name = "arrivalCity";
            this.arrivalCity.Size = new System.Drawing.Size(73, 16);
            this.arrivalCity.TabIndex = 17;
            this.arrivalCity.Text = "Arrival City:";
            // 
            // departureCity
            // 
            this.departureCity.AutoSize = true;
            this.departureCity.Location = new System.Drawing.Point(34, 264);
            this.departureCity.Name = "departureCity";
            this.departureCity.Size = new System.Drawing.Size(95, 16);
            this.departureCity.TabIndex = 18;
            this.departureCity.Text = "Departure City:";
            // 
            // trainNameBox
            // 
            this.trainNameBox.Location = new System.Drawing.Point(154, 215);
            this.trainNameBox.Name = "trainNameBox";
            this.trainNameBox.Size = new System.Drawing.Size(181, 22);
            this.trainNameBox.TabIndex = 20;
            this.trainNameBox.TextChanged += new System.EventHandler(this.trainNameBox_TextChanged);
            // 
            // trainIDbox
            // 
            this.trainIDbox.Location = new System.Drawing.Point(154, 170);
            this.trainIDbox.Name = "trainIDbox";
            this.trainIDbox.Size = new System.Drawing.Size(181, 22);
            this.trainIDbox.TabIndex = 21;
            // 
            // trainscheduleView
            // 
            this.trainscheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainscheduleView.Location = new System.Drawing.Point(468, 124);
            this.trainscheduleView.Name = "trainscheduleView";
            this.trainscheduleView.RowHeadersWidth = 51;
            this.trainscheduleView.RowTemplate.Height = 24;
            this.trainscheduleView.Size = new System.Drawing.Size(402, 225);
            this.trainscheduleView.TabIndex = 25;
            this.trainscheduleView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainscheduleView_CellContentClick);
            this.trainscheduleView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.trainscheduleView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search ID";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(547, 89);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 22);
            this.inputBox.TabIndex = 26;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(468, 369);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 34);
            this.add.TabIndex = 29;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(784, 369);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 34);
            this.update.TabIndex = 31;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(626, 369);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 34);
            this.delete.TabIndex = 32;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // search
            // 
            this.search.BackgroundImage = global::GROUP_2.Properties.Resources.search;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.Location = new System.Drawing.Point(653, 88);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(30, 25);
            this.search.TabIndex = 28;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GROUP_2.Properties.Resources.ASSALA;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(37, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(34, 446);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(63, 16);
            this.capacity.TabIndex = 33;
            this.capacity.Text = "Capacity:";
            // 
            // route
            // 
            this.route.AutoSize = true;
            this.route.Location = new System.Drawing.Point(34, 336);
            this.route.Name = "route";
            this.route.Size = new System.Drawing.Size(46, 16);
            this.route.TabIndex = 34;
            this.route.Text = "Route:";
            // 
            // arrivalTime
            // 
            this.arrivalTime.AutoSize = true;
            this.arrivalTime.Location = new System.Drawing.Point(34, 408);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(82, 16);
            this.arrivalTime.TabIndex = 35;
            this.arrivalTime.Text = "Arrival Time:";
            // 
            // departureTime
            // 
            this.departureTime.AutoSize = true;
            this.departureTime.Location = new System.Drawing.Point(34, 372);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(104, 16);
            this.departureTime.TabIndex = 36;
            this.departureTime.Text = "Departure Time:";
            // 
            // routeBox
            // 
            this.routeBox.Location = new System.Drawing.Point(154, 333);
            this.routeBox.Name = "routeBox";
            this.routeBox.Size = new System.Drawing.Size(181, 22);
            this.routeBox.TabIndex = 37;
            // 
            // depTimeBox
            // 
            this.depTimeBox.Location = new System.Drawing.Point(154, 370);
            this.depTimeBox.Name = "depTimeBox";
            this.depTimeBox.Size = new System.Drawing.Size(181, 22);
            this.depTimeBox.TabIndex = 38;
            // 
            // arrTimeBox
            // 
            this.arrTimeBox.Location = new System.Drawing.Point(154, 408);
            this.arrTimeBox.Name = "arrTimeBox";
            this.arrTimeBox.Size = new System.Drawing.Size(181, 22);
            this.arrTimeBox.TabIndex = 39;
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(154, 446);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(181, 22);
            this.capacityBox.TabIndex = 40;
            // 
            // fareBox
            // 
            this.fareBox.Location = new System.Drawing.Point(154, 488);
            this.fareBox.Name = "fareBox";
            this.fareBox.Size = new System.Drawing.Size(181, 22);
            this.fareBox.TabIndex = 41;
            // 
            // Statusbox
            // 
            this.Statusbox.Location = new System.Drawing.Point(154, 530);
            this.Statusbox.Name = "Statusbox";
            this.Statusbox.Size = new System.Drawing.Size(181, 22);
            this.Statusbox.TabIndex = 42;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(34, 530);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(47, 16);
            this.status.TabIndex = 43;
            this.status.Text = "Status;";
            // 
            // fare
            // 
            this.fare.AutoSize = true;
            this.fare.Location = new System.Drawing.Point(34, 491);
            this.fare.Name = "fare";
            this.fare.Size = new System.Drawing.Size(38, 16);
            this.fare.TabIndex = 44;
            this.fare.Text = "Fare:";
            // 
            // fromCity
            // 
            this.fromCity.FormattingEnabled = true;
            this.fromCity.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Kotla Qasim Khan",
            "Faisalabad",
            "Rawalpindi",
            "Gujranwala",
            "Peshawar",
            "Multan",
            "Hyderabad City",
            "Islamabad",
            "Quetta",
            "Cantonment",
            "Eminabad"});
            this.fromCity.Location = new System.Drawing.Point(154, 261);
            this.fromCity.Name = "fromCity";
            this.fromCity.Size = new System.Drawing.Size(181, 24);
            this.fromCity.TabIndex = 79;
            this.fromCity.Tag = "";
            // 
            // toCity
            // 
            this.toCity.FormattingEnabled = true;
            this.toCity.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Kotla Qasim Khan",
            "Faisalabad",
            "Rawalpindi",
            "Gujranwala",
            "Peshawar",
            "Multan",
            "Hyderabad City",
            "Islamabad",
            "Quetta",
            "Cantonment",
            "Eminabad"});
            this.toCity.Location = new System.Drawing.Point(154, 293);
            this.toCity.Name = "toCity";
            this.toCity.Size = new System.Drawing.Size(181, 24);
            this.toCity.TabIndex = 80;
            // 
            // ManageTrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP_2.Properties.Resources.train_track;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 608);
            this.Controls.Add(this.toCity);
            this.Controls.Add(this.fromCity);
            this.Controls.Add(this.fare);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Statusbox);
            this.Controls.Add(this.fareBox);
            this.Controls.Add(this.capacityBox);
            this.Controls.Add(this.arrTimeBox);
            this.Controls.Add(this.depTimeBox);
            this.Controls.Add(this.routeBox);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.route);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.trainscheduleView);
            this.Controls.Add(this.trainIDbox);
            this.Controls.Add(this.trainNameBox);
            this.Controls.Add(this.departureCity);
            this.Controls.Add(this.arrivalCity);
            this.Controls.Add(this.trainID);
            this.Controls.Add(this.trainName);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ManageTrainSchedule";
            this.Text = "ManageTrainSchedule";
            this.Load += new System.EventHandler(this.ManageTrainSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainscheduleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label trainName;
        private System.Windows.Forms.Label trainID;
        private System.Windows.Forms.Label arrivalCity;
        private System.Windows.Forms.Label departureCity;
        private System.Windows.Forms.TextBox trainNameBox;
        private System.Windows.Forms.TextBox trainIDbox;
        private System.Windows.Forms.DataGridView trainscheduleView;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label route;
        private System.Windows.Forms.Label arrivalTime;
        private System.Windows.Forms.Label departureTime;
        private System.Windows.Forms.TextBox routeBox;
        private System.Windows.Forms.TextBox depTimeBox;
        private System.Windows.Forms.TextBox arrTimeBox;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.TextBox fareBox;
        private System.Windows.Forms.TextBox Statusbox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label fare;
        private System.Windows.Forms.ComboBox fromCity;
        private System.Windows.Forms.ComboBox toCity;
    }
}