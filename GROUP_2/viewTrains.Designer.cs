namespace GROUP_2
{
    partial class viewTrains
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.trainView = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fromCity = new System.Windows.Forms.ComboBox();
            this.toCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 76;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(42, 272);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(36, 16);
            this.date.TabIndex = 75;
            this.date.Text = "Date";
            this.date.Click += new System.EventHandler(this.taskDeadline_Click);
            // 
            // trainView
            // 
            this.trainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainView.Location = new System.Drawing.Point(476, 151);
            this.trainView.Name = "trainView";
            this.trainView.RowHeadersWidth = 51;
            this.trainView.RowTemplate.Height = 24;
            this.trainView.Size = new System.Drawing.Size(402, 225);
            this.trainView.TabIndex = 66;
            this.trainView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesView_CellContentClick);
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Location = new System.Drawing.Point(42, 190);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(38, 16);
            this.employeeID.TabIndex = 59;
            this.employeeID.Text = "From";
            this.employeeID.Click += new System.EventHandler(this.employeeID_Click);
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(42, 232);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(24, 16);
            this.employeeName.TabIndex = 58;
            this.employeeName.Text = "To";
            this.employeeName.Click += new System.EventHandler(this.employeeName_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(246, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(131, 41);
            this.title.TabIndex = 57;
            this.title.Text = "Trains";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(174, 312);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(100, 35);
            this.view.TabIndex = 74;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.assignTask_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GROUP_2.Properties.Resources.ASSALA;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(30, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.fromCity.Location = new System.Drawing.Point(162, 182);
            this.fromCity.Name = "fromCity";
            this.fromCity.Size = new System.Drawing.Size(121, 24);
            this.fromCity.TabIndex = 78;
            this.fromCity.Tag = "";
            this.fromCity.Text = "Choose city";
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
            this.toCity.Location = new System.Drawing.Point(162, 224);
            this.toCity.Name = "toCity";
            this.toCity.Size = new System.Drawing.Size(121, 24);
            this.toCity.TabIndex = 79;
            this.toCity.Text = "Choose city";
            this.toCity.SelectedIndexChanged += new System.EventHandler(this.toCity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Search ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(555, 116);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 22);
            this.inputBox.TabIndex = 67;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GROUP_2.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(661, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 25);
            this.button1.TabIndex = 77;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP_2.Properties.Resources.train_track;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 456);
            this.Controls.Add(this.toCity);
            this.Controls.Add(this.fromCity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.trainView);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox2);
            this.Name = "viewTrains";
            this.Text = " ";
            this.Load += new System.EventHandler(this.viewTrains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DataGridView trainView;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.ComboBox fromCity;
        private System.Windows.Forms.ComboBox toCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button1;
    }
}